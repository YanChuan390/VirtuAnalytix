using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Playables;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class BluetoothDeviceScript : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD516AC")]
	public List<string> DiscoveredDeviceList;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Action InitializedAction;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Action DeinitializedAction;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Action<string> ErrorAction;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6959")]
	public Action<string> ServiceAddedAction;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
	public Action StartedAdvertisingAction;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD516B4")]
	public Action StoppedAdvertisingAction;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Action<string, string> DiscoveredPeripheralAction;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Action<string, string, int, byte[]> DiscoveredPeripheralWithAdvertisingInfoAction;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Action<BluetoothLEHardwareInterface.iBeaconData> DiscoveredBeaconAction;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6961")]
	public Action<string, string> RetrievedConnectedPeripheralAction;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
	public Action<string, byte[]> PeripheralReceivedWriteDataAction;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD516BC")]
	public Action<string> ConnectedPeripheralAction;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Action<string> ConnectedDisconnectPeripheralAction;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Action<string> DisconnectedPeripheralAction;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Action<string, string> DiscoveredServiceAction;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6969")]
	public Action<string, string, string> DiscoveredCharacteristicAction;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
	public Action<string> DidWriteCharacteristicAction;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4CD14")]
	public Dictionary<string, Dictionary<string, Action<string>>> DidUpdateNotificationStateForCharacteristicAction;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Dictionary<string, Dictionary<string, Action<string, string>>> DidUpdateNotificationStateForCharacteristicWithDeviceAddressAction;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Dictionary<string, Dictionary<string, Action<string, byte[]>>> DidUpdateCharacteristicValueAction;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Dictionary<string, Dictionary<string, Action<string, string, byte[]>>> DidUpdateCharacteristicValueWithDeviceAddressAction;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6970")]
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
	[Address(RVA = "0x2BDAA7C", Offset = "0x2BDAA7C", VA = "0x2BDAA7C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2BDAC30", Offset = "0x2BDAC30", VA = "0x2BDAC30")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2BDAC44", Offset = "0x2BDAC44", VA = "0x2BDAC44")]
	public void OnBluetoothMessage(string message)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2BDF64C", Offset = "0x2BDF64C", VA = "0x2BDF64C")]
	public void OnBluetoothData(string base64Data)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2BDEDB4", Offset = "0x2BDEDB4", VA = "0x2BDEDB4")]
	public void OnBluetoothData(string deviceAddress, string characteristic, string base64Data)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2BDE960", Offset = "0x2BDE960", VA = "0x2BDE960")]
	public void OnPeripheralData(string characteristic, string base64Data)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2BDF6E8", Offset = "0x2BDF6E8", VA = "0x2BDF6E8")]
	public BluetoothDeviceScript()
	{
	}
}
[Token(Token = "0x2000003")]
public class BluetoothLEHardwareInterface
{
	[Token(Token = "0x20000BD")]
	public enum CBCharacteristicProperties
	{
		[Token(Token = "0x40005AB")]
		CBCharacteristicPropertyBroadcast = 1,
		[Token(Token = "0x40005AC")]
		CBCharacteristicPropertyRead = 2,
		[Token(Token = "0x40005AD")]
		CBCharacteristicPropertyWriteWithoutResponse = 4,
		[Token(Token = "0x40005AE")]
		CBCharacteristicPropertyWrite = 8,
		[Token(Token = "0x40005AF")]
		CBCharacteristicPropertyNotify = 0x10,
		[Token(Token = "0x40005B0")]
		CBCharacteristicPropertyIndicate = 0x20,
		[Token(Token = "0x40005B1")]
		CBCharacteristicPropertyAuthenticatedSignedWrites = 0x40,
		[Token(Token = "0x40005B2")]
		CBCharacteristicPropertyExtendedProperties = 0x80,
		[Token(Token = "0x40005B3")]
		CBCharacteristicPropertyNotifyEncryptionRequired = 0x100,
		[Token(Token = "0x40005B4")]
		CBCharacteristicPropertyIndicateEncryptionRequired = 0x200
	}

	[Token(Token = "0x20000BE")]
	public enum ScanMode
	{
		[Token(Token = "0x40005B6")]
		LowPower,
		[Token(Token = "0x40005B7")]
		Balanced,
		[Token(Token = "0x40005B8")]
		LowLatency
	}

	[Token(Token = "0x20000BF")]
	public enum ConnectionPriority
	{
		[Token(Token = "0x40005BA")]
		LowPower,
		[Token(Token = "0x40005BB")]
		Balanced,
		[Token(Token = "0x40005BC")]
		High
	}

	[Token(Token = "0x20000C0")]
	public enum iOSProximity
	{
		[Token(Token = "0x40005BE")]
		Unknown,
		[Token(Token = "0x40005BF")]
		Immediate,
		[Token(Token = "0x40005C0")]
		Near,
		[Token(Token = "0x40005C1")]
		Far
	}

	[Token(Token = "0x20000C1")]
	public struct iBeaconData
	{
		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string UUID;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Major;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69A0")]
		public int Minor;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9FFF0")]
		public int RSSI;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD516F4")]
		public int AndroidSignalPower;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public iOSProximity iOSProximity;
	}

	[Token(Token = "0x20000C2")]
	public enum CBAttributePermissions
	{
		[Token(Token = "0x40005C9")]
		CBAttributePermissionsReadable = 1,
		[Token(Token = "0x40005CA")]
		CBAttributePermissionsWriteable = 16,
		[Token(Token = "0x40005CB")]
		CBAttributePermissionsReadEncryptionRequired = 2,
		[Token(Token = "0x40005CC")]
		CBAttributePermissionsWriteEncryptionRequired = 32
	}

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD516DC")]
	private static AndroidJavaObject _android;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static BluetoothDeviceScript bluetoothDeviceScript;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2BDE3B0", Offset = "0x2BDE3B0", VA = "0x2BDE3B0")]
	public static void Log(string message)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2BDF718", Offset = "0x2BDF718", VA = "0x2BDF718")]
	public static BluetoothDeviceScript Initialize(bool asCentral, bool asPeripheral, Action action, Action<string> errorAction)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2BE04B8", Offset = "0x2BE04B8", VA = "0x2BE04B8")]
	public static void DeInitialize(Action action)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2BDE79C", Offset = "0x2BDE79C", VA = "0x2BDE79C")]
	public static void FinishDeInitialize()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2BE0A2C", Offset = "0x2BE0A2C", VA = "0x2BE0A2C")]
	public static void BluetoothEnable(bool enable)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2BE0CB4", Offset = "0x2BE0CB4", VA = "0x2BE0CB4")]
	public static void BluetoothScanMode(ScanMode scanMode)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2BE0F24", Offset = "0x2BE0F24", VA = "0x2BE0F24")]
	public static void BluetoothConnectionPriority(ConnectionPriority connectionPriority)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2BE1194", Offset = "0x2BE1194", VA = "0x2BE1194")]
	public static void PauseMessages(bool isPaused)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2BE141C", Offset = "0x2BE141C", VA = "0x2BE141C")]
	public static void ScanForBeacons(string[] proximityUUIDs, Action<iBeaconData> actionBeaconResponse)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2BE1A5C", Offset = "0x2BE1A5C", VA = "0x2BE1A5C")]
	public static void RequestMtu(string name, int mtu, Action<string, int> action)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2BE1EAC", Offset = "0x2BE1EAC", VA = "0x2BE1EAC")]
	public static void ScanForPeripheralsWithServices(string[] serviceUUIDs, Action<string, string> action, [Optional] Action<string, string, int, byte[]> actionAdvertisingInfo, bool rssiOnly = false, bool clearPeripheralList = true, int recordType = 255)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2BE2700", Offset = "0x2BE2700", VA = "0x2BE2700")]
	public static void RetrieveListOfPeripheralsWithServices(string[] serviceUUIDs, Action<string, string> action)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2BE2DD4", Offset = "0x2BE2DD4", VA = "0x2BE2DD4")]
	public static void StopScan()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2BE2FC8", Offset = "0x2BE2FC8", VA = "0x2BE2FC8")]
	public static void StopBeaconScan()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2BE31BC", Offset = "0x2BE31BC", VA = "0x2BE31BC")]
	public static void DisconnectAll()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2BE33B0", Offset = "0x2BE33B0", VA = "0x2BE33B0")]
	public static void ConnectToPeripheral(string name, Action<string> connectAction, Action<string, string> serviceAction, Action<string, string, string> characteristicAction, [Optional] Action<string> disconnectAction)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2BE3850", Offset = "0x2BE3850", VA = "0x2BE3850")]
	public static void DisconnectPeripheral(string name, Action<string> action)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2BE3C4C", Offset = "0x2BE3C4C", VA = "0x2BE3C4C")]
	public static void ReadCharacteristic(string name, string service, string characteristic, Action<string, byte[]> action)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2BE4448", Offset = "0x2BE4448", VA = "0x2BE4448")]
	public static void WriteCharacteristic(string name, string service, string characteristic, byte[] data, int length, bool withResponse, Action<string> action)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2BE4A04", Offset = "0x2BE4A04", VA = "0x2BE4A04")]
	public static void SubscribeCharacteristic(string name, string service, string characteristic, Action<string> notificationAction, Action<string, byte[]> action)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2BE5424", Offset = "0x2BE5424", VA = "0x2BE5424")]
	public static void SubscribeCharacteristicWithDeviceAddress(string name, string service, string characteristic, Action<string, string> notificationAction, Action<string, string, byte[]> action)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2BE60E0", Offset = "0x2BE60E0", VA = "0x2BE60E0")]
	public static void UnSubscribeCharacteristic(string name, string service, string characteristic, Action<string> action)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2BE6AFC", Offset = "0x2BE6AFC", VA = "0x2BE6AFC")]
	public static void PeripheralName(string newName)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2BE6D3C", Offset = "0x2BE6D3C", VA = "0x2BE6D3C")]
	public static void CreateService(string uuid, bool primary, Action<string> action)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2BE71C8", Offset = "0x2BE71C8", VA = "0x2BE71C8")]
	public static void RemoveService(string uuid)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2BE7408", Offset = "0x2BE7408", VA = "0x2BE7408")]
	public static void RemoveServices()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2BE75FC", Offset = "0x2BE75FC", VA = "0x2BE75FC")]
	public static void CreateCharacteristic(string uuid, CBCharacteristicProperties properties, CBAttributePermissions permissions, byte[] data, int length, Action<string, byte[]> action)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2BE7B78", Offset = "0x2BE7B78", VA = "0x2BE7B78")]
	public static void RemoveCharacteristic(string uuid)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2BE7F70", Offset = "0x2BE7F70", VA = "0x2BE7F70")]
	public static void RemoveCharacteristics()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2BE8164", Offset = "0x2BE8164", VA = "0x2BE8164")]
	public static void StartAdvertising(Action action)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2BE8514", Offset = "0x2BE8514", VA = "0x2BE8514")]
	public static void StopAdvertising(Action action)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x2BE88C4", Offset = "0x2BE88C4", VA = "0x2BE88C4")]
	public static void UpdateCharacteristicValue(string uuid, byte[] data, int length)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x2BE4340", Offset = "0x2BE4340", VA = "0x2BE4340")]
	public static string FullUUID(string uuid)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x2BE8BBC", Offset = "0x2BE8BBC", VA = "0x2BE8BBC")]
	public BluetoothLEHardwareInterface()
	{
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB93AC", Offset = "0xBB93AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB93AC", Offset = "0xBB93AC")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C3")]
		public enum Mode
		{
			[Token(Token = "0x40005CE")]
			AnimationClips,
			[Token(Token = "0x40005CF")]
			AnimationStates,
			[Token(Token = "0x40005D0")]
			PlayableDirector,
			[Token(Token = "0x40005D1")]
			Realtime
		}

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBB230", Offset = "0xBBB230")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBB230", Offset = "0xBBB230")]
		public int frameRate;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBB2D0", Offset = "0xBBB2D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBB2D0", Offset = "0xBBB2D0")]
		public float keyReductionError;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBB370", Offset = "0xBBB370")]
		public Mode mode;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBB3D4", Offset = "0xBBB3D4")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBB438", Offset = "0xBBB438")]
		public string[] animationStates;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4CD1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBB49C", Offset = "0xBBB49C")]
		public bool loop;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBB500", Offset = "0xBBB500")]
		public string saveToFolder;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBB564", Offset = "0xBBB564")]
		public string appendName;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBB5C8", Offset = "0xBBB5C8")]
		public string saveName;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBB62C", Offset = "0xBBB62C")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBB668", Offset = "0xBBB668")]
		private float <bakingProgress>k__BackingField;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51714")]
		[SerializeField]
		[HideInInspector]
		public Animator animator;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		public PlayableDirector director;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBB75C", Offset = "0xBBB75C")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x2BEB2EC", Offset = "0x2BEB2EC", VA = "0x2BEB2EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCB118", Offset = "0xBCB118")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x2BEB330", Offset = "0x2BEB330", VA = "0x2BEB330")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCB154", Offset = "0xBCB154")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x2BEB37C", Offset = "0x2BEB37C", VA = "0x2BEB37C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCB190", Offset = "0xBCB190")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x2BEB3AC", Offset = "0x2BEB3AC", VA = "0x2BEB3AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCB1CC", Offset = "0xBCB1CC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x2BEB3E4", Offset = "0x2BEB3E4", VA = "0x2BEB3E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCB208", Offset = "0xBCB208")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x2BEB414", Offset = "0x2BEB414", VA = "0x2BEB414")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCB244", Offset = "0xBCB244")]
			private set
			{
			}
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2BEB0DC", Offset = "0x2BEB0DC", VA = "0x2BEB0DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCAF88", Offset = "0xBCAF88")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2BEB160", Offset = "0x2BEB160", VA = "0x2BEB160")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCAFEC", Offset = "0xBCAFEC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2BEB1E4", Offset = "0x2BEB1E4", VA = "0x2BEB1E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCB050", Offset = "0xBCB050")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2BEB268", Offset = "0x2BEB268", VA = "0x2BEB268")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCB0B4", Offset = "0xBCB0B4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000033")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x6000034")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x6000035")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x6000036")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x6000037")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2BEB44C", Offset = "0x2BEB44C", VA = "0x2BEB44C")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2BEB460", Offset = "0x2BEB460", VA = "0x2BEB460")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2BEB474", Offset = "0x2BEB474", VA = "0x2BEB474")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2BEB488", Offset = "0x2BEB488", VA = "0x2BEB488")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000005")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBB798", Offset = "0xBBB798")]
		public bool markAsLegacy;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBB7FC", Offset = "0xBBB7FC")]
		public Transform root;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69D7")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBB860", Offset = "0xBBB860")]
		public Transform rootNode;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBB8C4", Offset = "0xBBB8C4")]
		public Transform[] ignoreList;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51724")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBB928", Offset = "0xBBB928")]
		public Transform[] bakePositionList;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BakerTransform[] children;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BakerTransform rootChild;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int rootChildIndex;

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2698FBC", Offset = "0x2698FBC", VA = "0x2698FBC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2699860", Offset = "0x2699860", VA = "0x2699860", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2699890", Offset = "0x2699890", VA = "0x2699890", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2699A6C", Offset = "0x2699A6C", VA = "0x2699A6C", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2699B60", Offset = "0x2699B60", VA = "0x2699B60", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2699C54", Offset = "0x2699C54", VA = "0x2699C54", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2699498", Offset = "0x2699498", VA = "0x2699498")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x269967C", Offset = "0x269967C", VA = "0x269967C")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2699D54", Offset = "0x2699D54", VA = "0x2699D54")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class TQ
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69DF")]
		public Vector3 t;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Quaternion q;

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x3CAF99C", Offset = "0x3CAF99C", VA = "0x3CAF99C")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class AvatarUtility
	{
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2BE8BFC", Offset = "0x2BE8BFC", VA = "0x2BE8BFC")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2BE9080", Offset = "0x2BE9080", VA = "0x2BE9080")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2BE8FB0", Offset = "0x2BE8FB0", VA = "0x2BE8FB0")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2BE9E0C", Offset = "0x2BE9E0C", VA = "0x2BE9E0C")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public static class BakerUtilities
	{
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2BEE0F8", Offset = "0x2BEE0F8", VA = "0x2BEE0F8")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2BF11E0", Offset = "0x2BF11E0", VA = "0x2BF11E0")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2BED2A0", Offset = "0x2BED2A0", VA = "0x2BED2A0")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2BEE190", Offset = "0x2BEE190", VA = "0x2BEE190")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2BEC28C", Offset = "0x2BEC28C", VA = "0x2BEC28C")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x2000009")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5172C")]
		private Transform transform;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private string Qx;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private string Qy;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private string Qz;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69E7")]
		private string Qw;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private string Tx;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51734")]
		private string Ty;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private string Tz;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve rotX;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve rotY;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69EF")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5173C")]
		public AnimationCurve posX;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve posY;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AvatarIKGoal goal;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69F7")]
		private Quaternion lastQ;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private bool lastQSet;

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2BEB5F0", Offset = "0x2BEB5F0", VA = "0x2BEB5F0")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2BEBA04", Offset = "0x2BEBA04", VA = "0x2BEBA04")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2BEB7FC", Offset = "0x2BEB7FC", VA = "0x2BEB7FC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2BEBC48", Offset = "0x2BEBC48", VA = "0x2BEBC48")]
		public void SetIKKeyframes(float time, Avatar avatar, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2BECC70", Offset = "0x2BECC70", VA = "0x2BECC70")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2BECF40", Offset = "0x2BECF40", VA = "0x2BECF40")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2BED178", Offset = "0x2BED178", VA = "0x2BED178")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2BED084", Offset = "0x2BED084", VA = "0x2BED084")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2BED780", Offset = "0x2BED780", VA = "0x2BED780")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2BED8D8", Offset = "0x2BED8D8", VA = "0x2BED8D8")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000A")]
	public class BakerMuscle
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51744")]
		public AnimationCurve curve;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int muscleIndex;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private string propertyName;

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2BEE1A4", Offset = "0x2BEE1A4", VA = "0x2BEE1A4")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2BEE268", Offset = "0x2BEE268", VA = "0x2BEE268")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2BEF210", Offset = "0x2BEF210", VA = "0x2BEF210")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2BEF368", Offset = "0x2BEF368", VA = "0x2BEF368")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2BEF174", Offset = "0x2BEF174", VA = "0x2BEF174")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2BEF55C", Offset = "0x2BEF55C", VA = "0x2BEF55C")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2BEF5F8", Offset = "0x2BEF5F8", VA = "0x2BEF5F8")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	public class BakerTransform
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform transform;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69FF")]
		public AnimationCurve posX;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public AnimationCurve posY;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5174C")]
		public AnimationCurve posZ;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve rotX;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A07")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private string relativePath;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51754")]
		private bool recordPosition;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 relativePosition;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool isRootNode;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion relativeRotation;

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2BEF648", Offset = "0x2BEF648", VA = "0x2BEF648")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2BEF930", Offset = "0x2BEF930", VA = "0x2BEF930")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2BEF9C8", Offset = "0x2BEF9C8", VA = "0x2BEF9C8")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2BF0030", Offset = "0x2BF0030", VA = "0x2BF0030")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2BEF7A4", Offset = "0x2BEF7A4", VA = "0x2BEF7A4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2BF05FC", Offset = "0x2BF05FC", VA = "0x2BF05FC")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2BF0724", Offset = "0x2BF0724", VA = "0x2BF0724")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2BF0D7C", Offset = "0x2BF0D7C", VA = "0x2BF0D7C")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A0F")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBB98C", Offset = "0xBBB98C")]
		public bool bakeHandIK;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBB9F0", Offset = "0xBBB9F0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBB9F0", Offset = "0xBBB9F0")]
		public float IKKeyReductionError;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5175C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBBA90", Offset = "0xBBBA90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBBA90", Offset = "0xBBBA90")]
		public int muscleFrameRateDiv;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A17")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4CD24")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float[] muscles;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private HumanPose pose;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private HumanPoseHandler handler;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A1E")]
		private Vector3 bodyPosition;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Quaternion bodyRotation;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51764")]
		private int mN;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x269C314", Offset = "0x269C314", VA = "0x269C314")]
		private void Awake()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x269CB60", Offset = "0x269CB60", VA = "0x269CB60", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x269CBB0", Offset = "0x269CBB0", VA = "0x269CBB0", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x269CDFC", Offset = "0x269CDFC", VA = "0x269CDFC", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x269CFF0", Offset = "0x269CFF0", VA = "0x269CFF0", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x269D420", Offset = "0x269D420", VA = "0x269D420", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x269DBA0", Offset = "0x269DBA0", VA = "0x269DBA0")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x269DE54", Offset = "0x269DE54", VA = "0x269DE54")]
		public HumanoidBaker()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C4")]
		public enum UpdateMode
		{
			[Token(Token = "0x40005D3")]
			Update,
			[Token(Token = "0x40005D4")]
			FixedUpdate,
			[Token(Token = "0x40005D5")]
			LateUpdate,
			[Token(Token = "0x40005D6")]
			FixedLateUpdate
		}

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform target;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform rotationSpace;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A26")]
		public UpdateMode updateMode;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public bool lockCursor;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5176C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xBBBB30", Offset = "0xBBBB30")]
		public bool smoothFollow;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 offset;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float followSpeed;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xBBBB94", Offset = "0xBBBB94")]
		public float rotationSensitivity;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A2E")]
		public float yMinLimit;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public float yMaxLimit;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51774")]
		public bool rotateAlways;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool rotateOnRightButton;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A36")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xBBBBF8", Offset = "0xBBBBF8")]
		public float distance;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public float minDistance;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5177C")]
		public float maxDistance;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float zoomSpeed;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float zoomSensitivity;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xBBBC5C", Offset = "0xBBBC5C")]
		public LayerMask blockingLayers;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A3E")]
		public float blockingRadius;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public float blockingSmoothTime;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51784")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBBCC0", Offset = "0xBBBCC0")]
		public float blockedOffset;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBBD08", Offset = "0xBBBD08")]
		private float <x>k__BackingField;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBBD44", Offset = "0xBBBD44")]
		private float <y>k__BackingField;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBBD80", Offset = "0xBBBD80")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A46")]
		private Vector3 targetDistance;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Vector3 position;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5178C")]
		private Quaternion rotation;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 smoothPosition;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Camera cam;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool fixedFrame;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A4E")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Quaternion r;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51794")]
		private Vector3 lastUp;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float blockedDistance;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float blockedDistanceV;

		[Token(Token = "0x17000004")]
		public float x
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x2C00664", Offset = "0x2C00664", VA = "0x2C00664")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCB280", Offset = "0xBCB280")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x2C00694", Offset = "0x2C00694", VA = "0x2C00694")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCB2BC", Offset = "0xBCB2BC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x2C006CC", Offset = "0x2C006CC", VA = "0x2C006CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCB2F8", Offset = "0xBCB2F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x2C006FC", Offset = "0x2C006FC", VA = "0x2C006FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCB334", Offset = "0xBCB334")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x2C00734", Offset = "0x2C00734", VA = "0x2C00734")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCB370", Offset = "0xBCB370")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x2C00764", Offset = "0x2C00764", VA = "0x2C00764")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCB3AC", Offset = "0xBCB3AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x2C023C0", Offset = "0x2C023C0", VA = "0x2C023C0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2C0079C", Offset = "0x2C0079C", VA = "0x2C0079C")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2C00864", Offset = "0x2C00864", VA = "0x2C00864")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2C008C4", Offset = "0x2C008C4", VA = "0x2C008C4", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2C00BF8", Offset = "0x2C00BF8", VA = "0x2C00BF8", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2C00C8C", Offset = "0x2C00C8C", VA = "0x2C00C8C", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2C00D30", Offset = "0x2C00D30", VA = "0x2C00D30", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2C00E30", Offset = "0x2C00E30", VA = "0x2C00E30")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2C00C48", Offset = "0x2C00C48", VA = "0x2C00C48")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2C012A0", Offset = "0x2C012A0", VA = "0x2C012A0")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2C02204", Offset = "0x2C02204", VA = "0x2C02204")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2C024EC", Offset = "0x2C024EC", VA = "0x2C024EC")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float rotationSensitivity;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float yMinLimit;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A5E")]
		public float yMaxLimit;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private float x;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD517A4")]
		private float y;

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2C02734", Offset = "0x2C02734", VA = "0x2C02734")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2C027FC", Offset = "0x2C027FC", VA = "0x2C027FC")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2C02B4C", Offset = "0x2C02B4C", VA = "0x2C02B4C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2C02D08", Offset = "0x2C02D08", VA = "0x2C02D08")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public enum Axis
	{
		[Token(Token = "0x40000A2")]
		X,
		[Token(Token = "0x40000A3")]
		Y,
		[Token(Token = "0x40000A4")]
		Z
	}
	[Token(Token = "0x2000010")]
	public class AxisTools
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2BE9E3C", Offset = "0x2BE9E3C", VA = "0x2BE9E3C")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2BE9FFC", Offset = "0x2BE9FFC", VA = "0x2BE9FFC")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2BEA224", Offset = "0x2BEA224", VA = "0x2BEA224")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2BEA634", Offset = "0x2BEA634", VA = "0x2BEA634")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2BEA4B4", Offset = "0x2BEA4B4", VA = "0x2BEA4B4")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2BEA8C4", Offset = "0x2BEA8C4", VA = "0x2BEA8C4")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2BEA984", Offset = "0x2BEA984", VA = "0x2BEA984")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2BEB0AC", Offset = "0x2BEB0AC", VA = "0x2BEB0AC")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000011")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x20000C5")]
		public class LimbOrientation
		{
			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6A6E")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x2BF1E70", Offset = "0x2BF1E70", VA = "0x2BF1E70")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public LimbOrientation leftArm;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD517AC")]
		public LimbOrientation rightArm;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000008")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x2BF1A9C", Offset = "0x2BF1A9C", VA = "0x2BF1A9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x2BF1F68", Offset = "0x2BF1F68", VA = "0x2BF1F68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2BF1A0C", Offset = "0x2BF1A0C", VA = "0x2BF1A0C")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000012")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x20000C6")]
		public enum BoneType
		{
			[Token(Token = "0x40005DB")]
			Unassigned,
			[Token(Token = "0x40005DC")]
			Spine,
			[Token(Token = "0x40005DD")]
			Head,
			[Token(Token = "0x40005DE")]
			Arm,
			[Token(Token = "0x40005DF")]
			Leg,
			[Token(Token = "0x40005E0")]
			Tail,
			[Token(Token = "0x40005E1")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x20000C7")]
		public enum BoneSide
		{
			[Token(Token = "0x40005E3")]
			Center,
			[Token(Token = "0x40005E4")]
			Left,
			[Token(Token = "0x40005E5")]
			Right
		}

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4CD2C")]
		public static string[] typeLeft;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeRight;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeSpine;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeHead;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A75")]
		public static string[] typeArm;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public static string[] typeLeg;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD517B4")]
		public static string[] typeTail;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeEye;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeExclude;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A7D")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD517BC")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] pelvis;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A85")]
		public static string[] hand;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public static string[] foot;

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2BF233C", Offset = "0x2BF233C", VA = "0x2BF233C")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2BF2B24", Offset = "0x2BF2B24", VA = "0x2BF2B24")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2BF308C", Offset = "0x2BF308C", VA = "0x2BF308C")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2BF31D4", Offset = "0x2BF31D4", VA = "0x2BF31D4")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2BF3368", Offset = "0x2BF3368", VA = "0x2BF3368")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2BF26E8", Offset = "0x2BF26E8", VA = "0x2BF26E8")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2BF2ED0", Offset = "0x2BF2ED0", VA = "0x2BF2ED0")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2BF4B60", Offset = "0x2BF4B60", VA = "0x2BF4B60")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2BF45F8", Offset = "0x2BF45F8", VA = "0x2BF45F8")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2BF48AC", Offset = "0x2BF48AC", VA = "0x2BF48AC")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2BF38F0", Offset = "0x2BF38F0", VA = "0x2BF38F0")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2BF3B1C", Offset = "0x2BF3B1C", VA = "0x2BF3B1C")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2BF3D48", Offset = "0x2BF3D48", VA = "0x2BF3D48")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2BF3F74", Offset = "0x2BF3F74", VA = "0x2BF3F74")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2BF41A0", Offset = "0x2BF41A0", VA = "0x2BF41A0")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2BF43CC", Offset = "0x2BF43CC", VA = "0x2BF43CC")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2BF5044", Offset = "0x2BF5044", VA = "0x2BF5044")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2BF3680", Offset = "0x2BF3680", VA = "0x2BF3680")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2BF4EE8", Offset = "0x2BF4EE8", VA = "0x2BF4EE8")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2BF5168", Offset = "0x2BF5168", VA = "0x2BF5168")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2BF5378", Offset = "0x2BF5378", VA = "0x2BF5378")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2BF4DDC", Offset = "0x2BF4DDC", VA = "0x2BF4DDC")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2BF4C98", Offset = "0x2BF4C98", VA = "0x2BF4C98")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000013")]
	public class BipedReferences
	{
		[Token(Token = "0x20000C8")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9FFF0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD517DC")]
			public bool includeEyes;

			[Token(Token = "0x17000072")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x6000616")]
				[Address(RVA = "0x2C005DC", Offset = "0x2C005DC", VA = "0x2C005DC")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x2C00564", Offset = "0x2C00564", VA = "0x2C00564")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD517D4")]
		public Transform root;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform pelvis;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftThigh;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftCalf;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A9D")]
		public Transform leftFoot;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Transform rightThigh;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD517DC")]
		public Transform rightCalf;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform rightFoot;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftUpperArm;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftForearm;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6AA5")]
		public Transform leftHand;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD517E4")]
		public Transform rightForearm;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform rightHand;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform head;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform[] spine;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6AAD")]
		public Transform[] eyes;

		[Token(Token = "0x1700000A")]
		public virtual bool isFilled
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x2BF762C", Offset = "0x2BF762C", VA = "0x2BF762C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x2BF829C", Offset = "0x2BF829C", VA = "0x2BF829C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2BF82F0", Offset = "0x2BF82F0", VA = "0x2BF82F0", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2BF9028", Offset = "0x2BF9028", VA = "0x2BF9028", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2BF9E78", Offset = "0x2BF9E78", VA = "0x2BF9E78")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2BFAFC4", Offset = "0x2BFAFC4", VA = "0x2BFAFC4")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2BFA524", Offset = "0x2BFA524", VA = "0x2BFA524")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2BFC5CC", Offset = "0x2BFC5CC", VA = "0x2BFC5CC")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2BFCA88", Offset = "0x2BFCA88", VA = "0x2BFCA88")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2BFDD14", Offset = "0x2BFDD14", VA = "0x2BFDD14")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2BFD82C", Offset = "0x2BFD82C", VA = "0x2BFD82C")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2BFD31C", Offset = "0x2BFD31C", VA = "0x2BFD31C")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2BFCF0C", Offset = "0x2BFCF0C", VA = "0x2BFCF0C")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2BFDB04", Offset = "0x2BFDB04", VA = "0x2BFDB04")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2BFDF7C", Offset = "0x2BFDF7C", VA = "0x2BFDF7C")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2BFF660", Offset = "0x2BFF660", VA = "0x2BFF660")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2BFE94C", Offset = "0x2BFE94C", VA = "0x2BFE94C")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2BFFAD8", Offset = "0x2BFFAD8", VA = "0x2BFFAD8")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2BFF1F0", Offset = "0x2BFF1F0", VA = "0x2BFF1F0")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2BFFB00", Offset = "0x2BFFB00", VA = "0x2BFFB00")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2BFFB28", Offset = "0x2BFFB28", VA = "0x2BFFB28")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2BFFEFC", Offset = "0x2BFFEFC", VA = "0x2BFFEFC")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2C00324", Offset = "0x2C00324", VA = "0x2C00324")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2BFA45C", Offset = "0x2BFA45C", VA = "0x2BFA45C")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Multiline]
		public string text;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2C02D7C", Offset = "0x2C02D7C", VA = "0x2C02D7C")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string text;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Color color;

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2C02DAC", Offset = "0x2C02DAC", VA = "0x2C02DAC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2C02EEC", Offset = "0x2C02EEC", VA = "0x2C02EEC")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class Hierarchy
	{
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2699E0C", Offset = "0x2699E0C", VA = "0x2699E0C")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x269A35C", Offset = "0x269A35C", VA = "0x269A35C")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2699F78", Offset = "0x2699F78", VA = "0x2699F78")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x269A614", Offset = "0x269A614", VA = "0x269A614")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x269A8EC", Offset = "0x269A8EC", VA = "0x269A8EC")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x269AE0C", Offset = "0x269AE0C", VA = "0x269AE0C")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x269B0C4", Offset = "0x269B0C4", VA = "0x269B0C4")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x269B4D8", Offset = "0x269B4D8", VA = "0x269B4D8")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x269BE68", Offset = "0x269BE68", VA = "0x269BE68")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x269B90C", Offset = "0x269B90C", VA = "0x269B90C")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x269C2E4", Offset = "0x269C2E4", VA = "0x269C2E4")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6AB5")]
		public string name;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public string color;

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x3CA7F74", Offset = "0x3CA7F74", VA = "0x3CA7F74")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x3CA802C", Offset = "0x3CA802C", VA = "0x3CA802C")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000D2")]
		None,
		[Token(Token = "0x40000D3")]
		InOutCubic,
		[Token(Token = "0x40000D4")]
		InOutQuintic,
		[Token(Token = "0x40000D5")]
		InOutSine,
		[Token(Token = "0x40000D6")]
		InQuintic,
		[Token(Token = "0x40000D7")]
		InQuartic,
		[Token(Token = "0x40000D8")]
		InCubic,
		[Token(Token = "0x40000D9")]
		InQuadratic,
		[Token(Token = "0x40000DA")]
		InElastic,
		[Token(Token = "0x40000DB")]
		InElasticSmall,
		[Token(Token = "0x40000DC")]
		InElasticBig,
		[Token(Token = "0x40000DD")]
		InSine,
		[Token(Token = "0x40000DE")]
		InBack,
		[Token(Token = "0x40000DF")]
		OutQuintic,
		[Token(Token = "0x40000E0")]
		OutQuartic,
		[Token(Token = "0x40000E1")]
		OutCubic,
		[Token(Token = "0x40000E2")]
		OutInCubic,
		[Token(Token = "0x40000E3")]
		OutInQuartic,
		[Token(Token = "0x40000E4")]
		OutElastic,
		[Token(Token = "0x40000E5")]
		OutElasticSmall,
		[Token(Token = "0x40000E6")]
		OutElasticBig,
		[Token(Token = "0x40000E7")]
		OutSine,
		[Token(Token = "0x40000E8")]
		OutBack,
		[Token(Token = "0x40000E9")]
		OutBackCubic,
		[Token(Token = "0x40000EA")]
		OutBackQuartic,
		[Token(Token = "0x40000EB")]
		BackInCubic,
		[Token(Token = "0x40000EC")]
		BackInQuartic
	}
	[Token(Token = "0x2000019")]
	public class Interp
	{
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x3CA80EC", Offset = "0x3CA80EC", VA = "0x3CA80EC")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x3CAADFC", Offset = "0x3CAADFC", VA = "0x3CAADFC")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x3CAAFE8", Offset = "0x3CAAFE8", VA = "0x3CAAFE8")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x3CA8A90", Offset = "0x3CA8A90", VA = "0x3CA8A90")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x3CA8B00", Offset = "0x3CA8B00", VA = "0x3CA8B00")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x3CA8C20", Offset = "0x3CA8C20", VA = "0x3CA8C20")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x3CA8D9C", Offset = "0x3CA8D9C", VA = "0x3CA8D9C")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x3CA8E7C", Offset = "0x3CA8E7C", VA = "0x3CA8E7C")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x3CA8F38", Offset = "0x3CA8F38", VA = "0x3CA8F38")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x3CA8FE0", Offset = "0x3CA8FE0", VA = "0x3CA8FE0")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x3CA9078", Offset = "0x3CA9078", VA = "0x3CA9078")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x3CA9258", Offset = "0x3CA9258", VA = "0x3CA9258")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x3CA93F4", Offset = "0x3CA93F4", VA = "0x3CA93F4")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x3CA9538", Offset = "0x3CA9538", VA = "0x3CA9538")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x3CAB2B8", Offset = "0x3CAB2B8", VA = "0x3CAB2B8")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x3CA9694", Offset = "0x3CA9694", VA = "0x3CA9694")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x3CA97B4", Offset = "0x3CA97B4", VA = "0x3CA97B4")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x3CA9914", Offset = "0x3CA9914", VA = "0x3CA9914")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x3CA9A70", Offset = "0x3CA9A70", VA = "0x3CA9A70")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x3CA9C18", Offset = "0x3CA9C18", VA = "0x3CA9C18")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x3CA9E0C", Offset = "0x3CA9E0C", VA = "0x3CA9E0C")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x3CAA000", Offset = "0x3CAA000", VA = "0x3CAA000")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x3CAA1B8", Offset = "0x3CAA1B8", VA = "0x3CAA1B8")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x3CAA370", Offset = "0x3CAA370", VA = "0x3CAA370")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x3CAA4E8", Offset = "0x3CAA4E8", VA = "0x3CAA4E8")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x3CAA644", Offset = "0x3CAA644", VA = "0x3CAA644")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x3CAB414", Offset = "0x3CAB414", VA = "0x3CAB414")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x3CAA7E4", Offset = "0x3CAA7E4", VA = "0x3CAA7E4")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x3CAABAC", Offset = "0x3CAABAC", VA = "0x3CAABAC")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x3CAACC4", Offset = "0x3CAACC4", VA = "0x3CAACC4")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x3CAB7E8", Offset = "0x3CAB7E8", VA = "0x3CAB7E8")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6ADC")]
		public string name;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public string color;

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x3CAB818", Offset = "0x3CAB818", VA = "0x3CAB818")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x3CAB8D0", Offset = "0x3CAB8D0", VA = "0x3CAB8D0")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200001B")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x3CAB990", Offset = "0x3CAB990", VA = "0x3CAB990")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x3CABAD0", Offset = "0x3CABAD0", VA = "0x3CABAD0")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x3CABD6C", Offset = "0x3CABD6C", VA = "0x3CABD6C")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x3CABB28", Offset = "0x3CABB28", VA = "0x3CABB28")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x3CABDC4", Offset = "0x3CABDC4", VA = "0x3CABDC4")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x3CABFF0", Offset = "0x3CABFF0", VA = "0x3CABFF0")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x3CAC0A4", Offset = "0x3CAC0A4", VA = "0x3CAC0A4")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x3CAC1BC", Offset = "0x3CAC1BC", VA = "0x3CAC1BC")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x3CAC330", Offset = "0x3CAC330", VA = "0x3CAC330")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x3CAC5A8", Offset = "0x3CAC5A8", VA = "0x3CAC5A8")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x3CAC7C4", Offset = "0x3CAC7C4", VA = "0x3CAC7C4")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x3CAC8A0", Offset = "0x3CAC8A0", VA = "0x3CAC8A0")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200001C")]
	public static class QuaTools
	{
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x3CAC948", Offset = "0x3CAC948", VA = "0x3CAC948")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x3CACAE0", Offset = "0x3CACAE0", VA = "0x3CACAE0")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x3CACC78", Offset = "0x3CACC78", VA = "0x3CACC78")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x3CACE70", Offset = "0x3CACE70", VA = "0x3CACE70")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x3CAD068", Offset = "0x3CAD068", VA = "0x3CAD068")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x3CAD3AC", Offset = "0x3CAD3AC", VA = "0x3CAD3AC")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x3CAD530", Offset = "0x3CAD530", VA = "0x3CAD530")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x3CAD7A4", Offset = "0x3CAD7A4", VA = "0x3CAD7A4")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x3CADE38", Offset = "0x3CADE38", VA = "0x3CADE38")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x3CAE304", Offset = "0x3CAE304", VA = "0x3CAE304")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x3CAE674", Offset = "0x3CAE674", VA = "0x3CAE674")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x3CAE96C", Offset = "0x3CAE96C", VA = "0x3CAE96C")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x3CAEA50", Offset = "0x3CAEA50", VA = "0x3CAEA50")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200001D")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700000C")]
		public static T instance
		{
			[Token(Token = "0x600010D")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010E")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600010F")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51814")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBBDF8", Offset = "0xBBBDF8")]
		public bool fixTransforms;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animator animator;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animation legacy;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool updateFrame;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6AE4")]
		private bool componentInitiated;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000D")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x3CAEDE4", Offset = "0x3CAEDE4", VA = "0x3CAEDE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		private bool isAnimated
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x3CAF574", Offset = "0x3CAF574", VA = "0x3CAF574")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x3CAEB50", Offset = "0x3CAEB50", VA = "0x3CAEB50")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x3CAEC78", Offset = "0x3CAEC78", VA = "0x3CAEC78", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x3CAEC8C", Offset = "0x3CAEC8C", VA = "0x3CAEC8C", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x3CAECA0", Offset = "0x3CAECA0", VA = "0x3CAECA0", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x3CAECB4", Offset = "0x3CAECB4", VA = "0x3CAECB4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x3CAEDB4", Offset = "0x3CAEDB4", VA = "0x3CAEDB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x3CAED10", Offset = "0x3CAED10", VA = "0x3CAED10")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x3CAF4D4", Offset = "0x3CAF4D4", VA = "0x3CAF4D4")]
		private void Update()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x3CAF060", Offset = "0x3CAF060", VA = "0x3CAF060")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x3CAF754", Offset = "0x3CAF754", VA = "0x3CAF754")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x3CAF80C", Offset = "0x3CAF80C", VA = "0x3CAF80C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x3CAF8E0", Offset = "0x3CAF8E0", VA = "0x3CAF8E0")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x3CAF958", Offset = "0x3CAF958", VA = "0x3CAF958")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5181C")]
		public GameObject target;

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x3CAFA40", Offset = "0x3CAFA40", VA = "0x3CAFA40")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x3CAFBA8", Offset = "0x3CAFBA8", VA = "0x3CAFBA8")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x3CAFD10", Offset = "0x3CAFD10", VA = "0x3CAFD10")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x3CAFE78", Offset = "0x3CAFE78", VA = "0x3CAFE78")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public static class V3Tools
	{
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x3CAFEA8", Offset = "0x3CAFEA8", VA = "0x3CAFEA8")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x3CB004C", Offset = "0x3CB004C", VA = "0x3CB004C")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x3CB01F0", Offset = "0x3CB01F0", VA = "0x3CB01F0")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x3CB03E4", Offset = "0x3CB03E4", VA = "0x3CB03E4")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x3CB0614", Offset = "0x3CB0614", VA = "0x3CB0614")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x3CB0B94", Offset = "0x3CB0B94", VA = "0x3CB0B94")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x3CB1150", Offset = "0x3CB1150", VA = "0x3CB1150")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x3CB1724", Offset = "0x3CB1724", VA = "0x3CB1724")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x3CB1B10", Offset = "0x3CB1B10", VA = "0x3CB1B10")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x3CB1F2C", Offset = "0x3CB1F2C", VA = "0x3CB1F2C")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x3CB2134", Offset = "0x3CB2134", VA = "0x3CB2134")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000021")]
	public static class Warning
	{
		[Token(Token = "0x20000C9")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x3CB2384", Offset = "0x3CB2384", VA = "0x3CB2384")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x3CB28D0", Offset = "0x3CB28D0", VA = "0x3CB28D0")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB9494", Offset = "0xBB9494")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB9494", Offset = "0xBB9494")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BipedReferences references;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2112650", Offset = "0x2112650", VA = "0x2112650")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCB58C", Offset = "0xBCB58C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x21126D4", Offset = "0x21126D4", VA = "0x21126D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCB5F0", Offset = "0xBCB5F0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2112758", Offset = "0x2112758", VA = "0x2112758")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCB654", Offset = "0xBCB654")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x21127DC", Offset = "0x21127DC", VA = "0x21127DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCB6B8", Offset = "0xBCB6B8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2112860", Offset = "0x2112860", VA = "0x2112860")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2112A24", Offset = "0x2112A24", VA = "0x2112A24")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2112A88", Offset = "0x2112A88", VA = "0x2112A88")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2112AF4", Offset = "0x2112AF4", VA = "0x2112AF4")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2112B60", Offset = "0x2112B60", VA = "0x2112B60")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2112BF0", Offset = "0x2112BF0", VA = "0x2112BF0")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2112D58", Offset = "0x2112D58", VA = "0x2112D58")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2112DC4", Offset = "0x2112DC4", VA = "0x2112DC4")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2112E3C", Offset = "0x2112E3C", VA = "0x2112E3C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2112F08", Offset = "0x2112F08", VA = "0x2112F08")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2112F94", Offset = "0x2112F94", VA = "0x2112F94")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2113020", Offset = "0x2113020", VA = "0x2113020")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x21128C4", Offset = "0x21128C4", VA = "0x21128C4")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x211308C", Offset = "0x211308C", VA = "0x211308C")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x21130BC", Offset = "0x21130BC", VA = "0x21130BC")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x21130EC", Offset = "0x21130EC", VA = "0x21130EC")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x21136F4", Offset = "0x21136F4", VA = "0x21136F4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2113850", Offset = "0x2113850", VA = "0x2113850", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x21141D4", Offset = "0x21141D4", VA = "0x21141D4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2114D0C", Offset = "0x2114D0C", VA = "0x2114D0C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2114D70", Offset = "0x2114D70", VA = "0x2114D70")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000023")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6AEC")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51824")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6AF4")]
		public IKSolverAim aim;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Constraints pelvis;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5182C")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x1700000F")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x21134C4", Offset = "0x21134C4", VA = "0x21134C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x211506C", Offset = "0x211506C", VA = "0x211506C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2113C30", Offset = "0x2113C30", VA = "0x2113C30")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x2114E4C", Offset = "0x2114E4C", VA = "0x2114E4C")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000024")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform transform;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float weight;

		[Token(Token = "0x17000011")]
		public bool isValid
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x2115C64", Offset = "0x2115C64", VA = "0x2115C64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600014F")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2115D80", Offset = "0x2115D80", VA = "0x2115D80")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000025")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6AFC")]
		public Vector3 position;

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2115DB0", Offset = "0x2115DB0", VA = "0x2115DB0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2115F80", Offset = "0x2115F80", VA = "0x2115F80")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2115FB0", Offset = "0x2115FB0", VA = "0x2115FB0")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000026")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Vector3 offset;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51834")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool initiated;

		[Token(Token = "0x17000012")]
		private bool positionChanged
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x21163F4", Offset = "0x21163F4", VA = "0x21163F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2115FF8", Offset = "0x2115FF8", VA = "0x2115FF8", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2116528", Offset = "0x2116528", VA = "0x2116528")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2116558", Offset = "0x2116558", VA = "0x2116558")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000027")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Quaternion rotation;

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x21165A0", Offset = "0x21165A0", VA = "0x21165A0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2116780", Offset = "0x2116780", VA = "0x2116780")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x21167B0", Offset = "0x21167B0", VA = "0x21167B0")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000028")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B04")]
		public Quaternion offset;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5183C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool initiated;

		[Token(Token = "0x17000013")]
		private bool rotationChanged
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x2116BE8", Offset = "0x2116BE8", VA = "0x2116BE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x21167F8", Offset = "0x21167F8", VA = "0x21167F8", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2116D18", Offset = "0x2116D18", VA = "0x2116D18")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2116D48", Offset = "0x2116D48", VA = "0x2116D48")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000029")]
	public class Constraints
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B0C")]
		public Transform transform;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Transform target;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51844")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 position;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBBE5C", Offset = "0xBBBE5C")]
		public float positionWeight;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B14")]
		public Vector3 rotation;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBBEA4", Offset = "0xBBBEA4")]
		public float rotationWeight;

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2116D90", Offset = "0x2116D90", VA = "0x2116D90")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2114100", Offset = "0x2114100", VA = "0x2114100")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x211457C", Offset = "0x211457C", VA = "0x211457C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2115364", Offset = "0x2115364", VA = "0x2115364")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002A")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x20000CA")]
		public enum DOF
		{
			[Token(Token = "0x40005E9")]
			One,
			[Token(Token = "0x40005EA")]
			Three
		}

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5184C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBBEEC", Offset = "0xBBBEEC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBBEEC", Offset = "0xBBBEEC")]
		public float weight;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBBF88", Offset = "0xBBBF88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBBF88", Offset = "0xBBBF88")]
		public float rotationWeight;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBC024", Offset = "0xBBC024")]
		public DOF rotationDOF;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBC088", Offset = "0xBBC088")]
		public bool fixBone1Twist;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBC0EC", Offset = "0xBBC0EC")]
		public Transform bone1;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBC150", Offset = "0xBBC150")]
		public Transform bone2;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4CD3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBC1B4", Offset = "0xBBC1B4")]
		public Transform bone3;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBC218", Offset = "0xBBC218")]
		public Transform tip;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBC27C", Offset = "0xBBC27C")]
		public Transform target;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBC2E0", Offset = "0xBBC2E0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B23")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51854")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 bone1Axis;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 tipAxis;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B2B")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x17000014")]
		public bool initiated
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x2FEA4E0", Offset = "0x2FEA4E0", VA = "0x2FEA4E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCB71C", Offset = "0xBCB71C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x2FEA524", Offset = "0x2FEA524", VA = "0x2FEA524")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCB758", Offset = "0xBCB758")]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x2FEA570", Offset = "0x2FEA570", VA = "0x2FEA570")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x2FEA5C4", Offset = "0x2FEA5C4", VA = "0x2FEA5C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x2FEA638", Offset = "0x2FEA638", VA = "0x2FEA638")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x2FEA694", Offset = "0x2FEA694", VA = "0x2FEA694")]
			set
			{
			}
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2FEA7DC", Offset = "0x2FEA7DC", VA = "0x2FEA7DC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2FEAAA4", Offset = "0x2FEAAA4", VA = "0x2FEAAA4")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2FEB7C4", Offset = "0x2FEB7C4", VA = "0x2FEB7C4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2FEB9B4", Offset = "0x2FEB9B4", VA = "0x2FEB9B4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x2FEBB80", Offset = "0x2FEBB80", VA = "0x2FEBB80")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2FECC8C", Offset = "0x2FECC8C", VA = "0x2FECC8C")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBC31C", Offset = "0xBBC31C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBC31C", Offset = "0xBBC31C")]
		public float weight;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Finger[] fingers;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B33")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBC3B8", Offset = "0xBBC3B8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000017")]
		public bool initiated
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x2FECCE0", Offset = "0x2FECCE0", VA = "0x2FECCE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCB794", Offset = "0xBCB794")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x2FECD24", Offset = "0x2FECD24", VA = "0x2FECD24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCB7D0", Offset = "0xBCB7D0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2FECD70", Offset = "0x2FECD70", VA = "0x2FECD70")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2FECEC0", Offset = "0x2FECEC0", VA = "0x2FECEC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCB80C", Offset = "0xBCB80C")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x2FED654", Offset = "0x2FED654", VA = "0x2FED654")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2FEDA3C", Offset = "0x2FEDA3C", VA = "0x2FEDA3C")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2FED468", Offset = "0x2FED468", VA = "0x2FED468")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2FEDD7C", Offset = "0x2FEDD7C", VA = "0x2FEDD7C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2FEDF0C", Offset = "0x2FEDF0C", VA = "0x2FEDF0C")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2FEE014", Offset = "0x2FEE014", VA = "0x2FEE014")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2FEE140", Offset = "0x2FEE140", VA = "0x2FEE140")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2FEE238", Offset = "0x2FEE238", VA = "0x2FEE238", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x2FEE268", Offset = "0x2FEE268", VA = "0x2FEE268", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2FEE2D0", Offset = "0x2FEE2D0", VA = "0x2FEE2D0")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x20000CB")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBC3F4", Offset = "0xBBC3F4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBC3F4", Offset = "0xBBC3F4")]
		public float weight;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51864")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBC490", Offset = "0xBBC490")]
		public Grounding solver;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBC4F4", Offset = "0xBBC4F4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000018")]
		public bool initiated
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x2FF06E0", Offset = "0x2FF06E0", VA = "0x2FF06E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCB870", Offset = "0xBCB870")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x2FF0724", Offset = "0x2FF0724", VA = "0x2FF0724")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCB8AC", Offset = "0xBCB8AC")]
			protected set
			{
			}
		}

		[Token(Token = "0x600017D")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2FF0770", Offset = "0x2FF0770", VA = "0x2FF0770")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2FF0D3C", Offset = "0x2FF0D3C", VA = "0x2FF0D3C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2FF0A0C", Offset = "0x2FF0A0C", VA = "0x2FF0A0C")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2FF0DA0", Offset = "0x2FF0DA0", VA = "0x2FF0DA0")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000184")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000185")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2FF11C4", Offset = "0x2FF11C4", VA = "0x2FF11C4")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB9540", Offset = "0xBB9540")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB9540", Offset = "0xBB9540")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B3B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBC530", Offset = "0xBBC530")]
		public BipedIK ik;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBC594", Offset = "0xBBC594")]
		public float spineBend;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5186C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBC5F8", Offset = "0xBBC5F8")]
		public float spineSpeed;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform[] feet;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B43")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Vector3 spineOffset;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51874")]
		private float lastWeight;

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2FF1714", Offset = "0x2FF1714", VA = "0x2FF1714", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCB8E8", Offset = "0xBCB8E8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2FF1798", Offset = "0x2FF1798", VA = "0x2FF1798", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCB94C", Offset = "0xBCB94C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2FF181C", Offset = "0x2FF181C", VA = "0x2FF181C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2FF1A5C", Offset = "0x2FF1A5C", VA = "0x2FF1A5C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2FF1C98", Offset = "0x2FF1C98", VA = "0x2FF1C98")]
		private void Update()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2FF1E44", Offset = "0x2FF1E44", VA = "0x2FF1E44")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2FF2908", Offset = "0x2FF2908", VA = "0x2FF2908")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2FF29F0", Offset = "0x2FF29F0", VA = "0x2FF29F0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2FF3ED0", Offset = "0x2FF3ED0", VA = "0x2FF3ED0")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2FF419C", Offset = "0x2FF419C", VA = "0x2FF419C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2FF4560", Offset = "0x2FF4560", VA = "0x2FF4560")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2FF4850", Offset = "0x2FF4850", VA = "0x2FF4850")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB95EC", Offset = "0xBB95EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB95EC", Offset = "0xBB95EC")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x20000CC")]
		public class SpineEffector
		{
			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC45A4", Offset = "0xBC45A4")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC4608", Offset = "0xBC4608")]
			public float horizontalWeight;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6B53")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC466C", Offset = "0xBC466C")]
			public float verticalWeight;

			[Token(Token = "0x600061F")]
			[Address(RVA = "0x2FF6828", Offset = "0x2FF6828", VA = "0x2FF6828")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000620")]
			[Address(RVA = "0x2FF686C", Offset = "0x2FF686C", VA = "0x2FF686C")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBC65C", Offset = "0xBBC65C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBC6C0", Offset = "0xBBC6C0")]
		public float spineBend;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBC724", Offset = "0xBBC724")]
		public float spineSpeed;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B4B")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Transform[] feet;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5187C")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool firstSolve;

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2FF4950", Offset = "0x2FF4950", VA = "0x2FF4950")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCB9B0", Offset = "0xBCB9B0")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2FF49D4", Offset = "0x2FF49D4", VA = "0x2FF49D4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCBA14", Offset = "0xBCBA14")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2FF4A58", Offset = "0x2FF4A58", VA = "0x2FF4A58", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCBA78", Offset = "0xBCBA78")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2FF4ADC", Offset = "0x2FF4ADC", VA = "0x2FF4ADC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2FF4BD4", Offset = "0x2FF4BD4", VA = "0x2FF4BD4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2FF4D84", Offset = "0x2FF4D84", VA = "0x2FF4D84")]
		private void Update()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2FF52DC", Offset = "0x2FF52DC", VA = "0x2FF52DC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2FF530C", Offset = "0x2FF530C", VA = "0x2FF530C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2FF4F40", Offset = "0x2FF4F40", VA = "0x2FF4F40")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2FF533C", Offset = "0x2FF533C", VA = "0x2FF533C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2FF5E20", Offset = "0x2FF5E20", VA = "0x2FF5E20")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2FF6248", Offset = "0x2FF6248", VA = "0x2FF6248")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2FF651C", Offset = "0x2FF651C", VA = "0x2FF651C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2FF6720", Offset = "0x2FF6720", VA = "0x2FF6720")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB9698", Offset = "0xBB9698")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB9698", Offset = "0xBB9698")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public IK[] legs;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51884")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBC788", Offset = "0xBBC788")]
		public Transform pelvis;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBC7EC", Offset = "0xBBC7EC")]
		public Transform characterRoot;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBC850", Offset = "0xBBC850")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBC850", Offset = "0xBBC850")]
		public float rootRotationWeight;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBC8EC", Offset = "0xBBC8EC")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B5B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBC950", Offset = "0xBBC950")]
		public float maxRootRotationAngle;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Transform[] feet;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5188C")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int solvedFeet;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B63")]
		private bool solved;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private float lastWeight;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51894")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2FF68FC", Offset = "0x2FF68FC", VA = "0x2FF68FC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCBADC", Offset = "0xBCBADC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2FF6980", Offset = "0x2FF6980", VA = "0x2FF6980", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCBB40", Offset = "0xBCBB40")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2FF6A04", Offset = "0x2FF6A04", VA = "0x2FF6A04", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2FF6A4C", Offset = "0x2FF6A4C", VA = "0x2FF6A4C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2FF6EAC", Offset = "0x2FF6EAC", VA = "0x2FF6EAC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2FF7100", Offset = "0x2FF7100", VA = "0x2FF7100")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2FF8154", Offset = "0x2FF8154", VA = "0x2FF8154")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2FF889C", Offset = "0x2FF889C", VA = "0x2FF889C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2FF8E24", Offset = "0x2FF8E24", VA = "0x2FF8E24")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2FF945C", Offset = "0x2FF945C", VA = "0x2FF945C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2FF9888", Offset = "0x2FF9888", VA = "0x2FF9888")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2FF9C1C", Offset = "0x2FF9C1C", VA = "0x2FF9C1C")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB9744", Offset = "0xBB9744")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB9744", Offset = "0xBB9744")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x20000CD")]
		public struct Foot
		{
			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD518A4")]
			public IKSolver solver;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform transform;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Quaternion rotation;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Grounding.Leg leg;

			[Token(Token = "0x6000621")]
			[Address(RVA = "0x2FFB51C", Offset = "0x2FFB51C", VA = "0x2FFB51C")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBC9B4", Offset = "0xBBC9B4")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBCA18", Offset = "0xBBCA18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBCA18", Offset = "0xBBCA18")]
		public float rootRotationWeight;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBCAB4", Offset = "0xBBCAB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBCAB4", Offset = "0xBBCAB4")]
		public float minRootRotation;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B6B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBCB50", Offset = "0xBBCB50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBCB50", Offset = "0xBBCB50")]
		public float maxRootRotation;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBCBEC", Offset = "0xBBCBEC")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5189C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBCC50", Offset = "0xBBCC50")]
		public float maxLegOffset;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBCCB4", Offset = "0xBBCCB4")]
		public float maxForeLegOffset;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBCD18", Offset = "0xBBCD18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBCD18", Offset = "0xBBCD18")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBCDB4", Offset = "0xBBCDB4")]
		public Transform characterRoot;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B73")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBCE18", Offset = "0xBBCE18")]
		public Transform pelvis;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBCE7C", Offset = "0xBBCE7C")]
		public Transform lastSpineBone;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4CD44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBCEE0", Offset = "0xBBCEE0")]
		public Transform head;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IK[] legs;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IK[] forelegs;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B7A")]
		private Foot[] feet;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD518A4")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B82")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private int solvedFeet;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD518AC")]
		private bool solved;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float angle;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform forefeetRoot;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion headRotation;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B8A")]
		private float lastWeight;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2FF9D1C", Offset = "0x2FF9D1C", VA = "0x2FF9D1C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCBBA4", Offset = "0xBCBBA4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2FF9DA0", Offset = "0x2FF9DA0", VA = "0x2FF9DA0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCBC08", Offset = "0xBCBC08")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2FF9E24", Offset = "0x2FF9E24", VA = "0x2FF9E24", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2FF9E8C", Offset = "0x2FF9E8C", VA = "0x2FF9E8C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2FFA248", Offset = "0x2FFA248", VA = "0x2FFA248")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2FFA5BC", Offset = "0x2FFA5BC", VA = "0x2FFA5BC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2FFA71C", Offset = "0x2FFA71C", VA = "0x2FFA71C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2FFA8D8", Offset = "0x2FFA8D8", VA = "0x2FFA8D8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2FFAF48", Offset = "0x2FFAF48", VA = "0x2FFAF48")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2FFB5C8", Offset = "0x2FFB5C8", VA = "0x2FFB5C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2FFB89C", Offset = "0x2FFB89C", VA = "0x2FFB89C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2FFC384", Offset = "0x2FFC384", VA = "0x2FFC384")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2FFD628", Offset = "0x2FFD628", VA = "0x2FFD628")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x2FFDBD0", Offset = "0x2FFDBD0", VA = "0x2FFDBD0")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2FFDF5C", Offset = "0x2FFDF5C", VA = "0x2FFDF5C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2FFE660", Offset = "0x2FFE660", VA = "0x2FFE660")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2FFE6E4", Offset = "0x2FFE6E4", VA = "0x2FFE6E4")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2FFEA54", Offset = "0x2FFEA54", VA = "0x2FFEA54")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB97F0", Offset = "0xBB97F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB97F0", Offset = "0xBB97F0")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B92")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBCF80", Offset = "0xBBCF80")]
		public VRIK ik;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Transform[] feet;

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2FFEBEC", Offset = "0x2FFEBEC", VA = "0x2FFEBEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCBC6C", Offset = "0xBCBC6C")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x2FFEC70", Offset = "0x2FFEC70", VA = "0x2FFEC70", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCBCD0", Offset = "0xBCBCD0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2FFECF4", Offset = "0x2FFECF4", VA = "0x2FFECF4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCBD34", Offset = "0xBCBD34")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2FFED78", Offset = "0x2FFED78", VA = "0x2FFED78", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2FFEDC0", Offset = "0x2FFEDC0", VA = "0x2FFEDC0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x2FFEF70", Offset = "0x2FFEF70", VA = "0x2FFEF70")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2FFF11C", Offset = "0x2FFF11C", VA = "0x2FFF11C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2FFF49C", Offset = "0x2FFF49C", VA = "0x2FFF49C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2FFFAD4", Offset = "0x2FFFAD4", VA = "0x2FFFAD4")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x2FFFCC4", Offset = "0x2FFFCC4", VA = "0x2FFFCC4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x300014C", Offset = "0x300014C", VA = "0x300014C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x3000420", Offset = "0x3000420", VA = "0x3000420")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x30006E8", Offset = "0x30006E8", VA = "0x30006E8")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000032")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x20000CE")]
		public enum Quality
		{
			[Token(Token = "0x40005F3")]
			Fastest,
			[Token(Token = "0x40005F4")]
			Simple,
			[Token(Token = "0x40005F5")]
			Best
		}

		[Token(Token = "0x20000CF")]
		public class Leg
		{
			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6BBA")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC46D0", Offset = "0xBC46D0")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC470C", Offset = "0xBC470C")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD518E4")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC4748", Offset = "0xBC4748")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC4784", Offset = "0xBC4784")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC47C0", Offset = "0xBC47C0")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6BC2")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC47FC", Offset = "0xBC47FC")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC4838", Offset = "0xBC4838")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD518EC")]
			public bool invertFootCenter;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC4874", Offset = "0xBC4874")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC48B0", Offset = "0xBC48B0")]
			private RaycastHit <capsuleHit>k__BackingField;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Grounding grounding;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6BCA")]
			private float lastTime;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private float deltaTime;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4CD4C")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Quaternion toHitNormal;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Quaternion r;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 up;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6BD1")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD518F4")]
			private Vector3 transformPosition;

			[Token(Token = "0x17000073")]
			public bool isGrounded
			{
				[Token(Token = "0x6000622")]
				[Address(RVA = "0x3004838", Offset = "0x3004838", VA = "0x3004838")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF398", Offset = "0xBCF398")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000623")]
				[Address(RVA = "0x300487C", Offset = "0x300487C", VA = "0x300487C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF3D4", Offset = "0xBCF3D4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000074")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000624")]
				[Address(RVA = "0x30048C8", Offset = "0x30048C8", VA = "0x30048C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF410", Offset = "0xBCF410")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000625")]
				[Address(RVA = "0x3004908", Offset = "0x3004908", VA = "0x3004908")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF44C", Offset = "0xBCF44C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000075")]
			public bool initiated
			{
				[Token(Token = "0x6000626")]
				[Address(RVA = "0x3004968", Offset = "0x3004968", VA = "0x3004968")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF488", Offset = "0xBCF488")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000627")]
				[Address(RVA = "0x30049AC", Offset = "0x30049AC", VA = "0x30049AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF4C4", Offset = "0xBCF4C4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000076")]
			public float heightFromGround
			{
				[Token(Token = "0x6000628")]
				[Address(RVA = "0x30049F8", Offset = "0x30049F8", VA = "0x30049F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF500", Offset = "0xBCF500")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000629")]
				[Address(RVA = "0x3004A28", Offset = "0x3004A28", VA = "0x3004A28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF53C", Offset = "0xBCF53C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000077")]
			public Vector3 velocity
			{
				[Token(Token = "0x600062A")]
				[Address(RVA = "0x3004A60", Offset = "0x3004A60", VA = "0x3004A60")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF578", Offset = "0xBCF578")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600062B")]
				[Address(RVA = "0x3004AA0", Offset = "0x3004AA0", VA = "0x3004AA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF5B4", Offset = "0xBCF5B4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000078")]
			public Transform transform
			{
				[Token(Token = "0x600062C")]
				[Address(RVA = "0x3004B00", Offset = "0x3004B00", VA = "0x3004B00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF5F0", Offset = "0xBCF5F0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600062D")]
				[Address(RVA = "0x3004B30", Offset = "0x3004B30", VA = "0x3004B30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF62C", Offset = "0xBCF62C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000079")]
			public float IKOffset
			{
				[Token(Token = "0x600062E")]
				[Address(RVA = "0x3004B68", Offset = "0x3004B68", VA = "0x3004B68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF668", Offset = "0xBCF668")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600062F")]
				[Address(RVA = "0x3004B98", Offset = "0x3004B98", VA = "0x3004B98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF6A4", Offset = "0xBCF6A4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007A")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x6000630")]
				[Address(RVA = "0x3004BD0", Offset = "0x3004BD0", VA = "0x3004BD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF6E0", Offset = "0xBCF6E0")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x6000631")]
				[Address(RVA = "0x3004BF8", Offset = "0x3004BF8", VA = "0x3004BF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF71C", Offset = "0xBCF71C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007B")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x6000632")]
				[Address(RVA = "0x3004C64", Offset = "0x3004C64", VA = "0x3004C64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF758", Offset = "0xBCF758")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x6000633")]
				[Address(RVA = "0x3004C8C", Offset = "0x3004C8C", VA = "0x3004C8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF794", Offset = "0xBCF794")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007C")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x6000634")]
				[Address(RVA = "0x3004CF8", Offset = "0x3004CF8", VA = "0x3004CF8")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700007D")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x600063A")]
				[Address(RVA = "0x3006EF4", Offset = "0x3006EF4", VA = "0x3006EF4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700007E")]
			private float rootYOffset
			{
				[Token(Token = "0x6000643")]
				[Address(RVA = "0x300747C", Offset = "0x300747C", VA = "0x300747C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000635")]
			[Address(RVA = "0x3004D88", Offset = "0x3004D88", VA = "0x3004D88")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0x300191C", Offset = "0x300191C", VA = "0x300191C")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x6000637")]
			[Address(RVA = "0x3004DF4", Offset = "0x3004DF4", VA = "0x3004DF4")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000638")]
			[Address(RVA = "0x3003E40", Offset = "0x3003E40", VA = "0x3003E40")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0x3001BF8", Offset = "0x3001BF8", VA = "0x3001BF8")]
			public void Process()
			{
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x3006094", Offset = "0x3006094", VA = "0x3006094")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x3004EB0", Offset = "0x3004EB0", VA = "0x3004EB0")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0x30071E8", Offset = "0x30071E8", VA = "0x30071E8")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600063E")]
			[Address(RVA = "0x3005924", Offset = "0x3005924", VA = "0x3005924")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x600063F")]
			[Address(RVA = "0x3005AF8", Offset = "0x3005AF8", VA = "0x3005AF8")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0x30073B0", Offset = "0x30073B0", VA = "0x30073B0")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x3007048", Offset = "0x3007048", VA = "0x3007048")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x3007694", Offset = "0x3007694", VA = "0x3007694")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x3001784", Offset = "0x3001784", VA = "0x3001784")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x20000D0")]
		public class Pelvis
		{
			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC48EC", Offset = "0xBC48EC")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC4928", Offset = "0xBC4928")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Grounding grounding;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6BD9")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private float damperF;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD518FC")]
			private bool initiated;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float lastTime;

			[Token(Token = "0x1700007F")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x6000645")]
				[Address(RVA = "0x30078E8", Offset = "0x30078E8", VA = "0x30078E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF7D0", Offset = "0xBCF7D0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000646")]
				[Address(RVA = "0x3007928", Offset = "0x3007928", VA = "0x3007928")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF80C", Offset = "0xBCF80C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public float heightOffset
			{
				[Token(Token = "0x6000647")]
				[Address(RVA = "0x3007988", Offset = "0x3007988", VA = "0x3007988")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF848", Offset = "0xBCF848")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000648")]
				[Address(RVA = "0x30079B8", Offset = "0x30079B8", VA = "0x30079B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF884", Offset = "0xBCF884")]
				private set
				{
				}
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0x3001B30", Offset = "0x3001B30", VA = "0x3001B30")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x600064A")]
			[Address(RVA = "0x3003CB4", Offset = "0x3003CB4", VA = "0x3003CB4")]
			public void Reset()
			{
			}

			[Token(Token = "0x600064B")]
			[Address(RVA = "0x30079F0", Offset = "0x30079F0", VA = "0x30079F0")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600064C")]
			[Address(RVA = "0x3003628", Offset = "0x3003628", VA = "0x3003628")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0x30018EC", Offset = "0x30018EC", VA = "0x30018EC")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD518BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBCFE4", Offset = "0xBBCFE4")]
		public LayerMask layers;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBD048", Offset = "0xBBD048")]
		public float maxStep;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBD0AC", Offset = "0xBBD0AC")]
		public float heightOffset;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBD110", Offset = "0xBBD110")]
		public float footSpeed;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B9A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBD174", Offset = "0xBBD174")]
		public float footRadius;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBD1D8", Offset = "0xBBD1D8")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD518C4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBD258", Offset = "0xBBD258")]
		public float prediction;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBD2BC", Offset = "0xBBD2BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBD2BC", Offset = "0xBBD2BC")]
		public float footRotationWeight;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBD358", Offset = "0xBBD358")]
		public float footRotationSpeed;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBD3BC", Offset = "0xBBD3BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBD3BC", Offset = "0xBBD3BC")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6BA2")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBD458", Offset = "0xBBD458")]
		public bool rotateSolver;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBD4BC", Offset = "0xBBD4BC")]
		public float pelvisSpeed;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD518CC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBD520", Offset = "0xBBD520")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBD520", Offset = "0xBBD520")]
		public float pelvisDamper;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBD5BC", Offset = "0xBBD5BC")]
		public float lowerPelvisWeight;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBD620", Offset = "0xBBD620")]
		public float liftPelvisWeight;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBD684", Offset = "0xBBD684")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6BAA")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBD6E8", Offset = "0xBBD6E8")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBD74C", Offset = "0xBBD74C")]
		public Quality quality;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD518D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBD7B0", Offset = "0xBBD7B0")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBD7EC", Offset = "0xBBD7EC")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBD828", Offset = "0xBBD828")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBD864", Offset = "0xBBD864")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6BB2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBD8A0", Offset = "0xBBD8A0")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private bool initiated;

		[Token(Token = "0x17000019")]
		public Leg[] legs
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x3000788", Offset = "0x3000788", VA = "0x3000788")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCBD98", Offset = "0xBCBD98")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x30007B8", Offset = "0x30007B8", VA = "0x30007B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCBDD4", Offset = "0xBCBDD4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x30007F0", Offset = "0x30007F0", VA = "0x30007F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCBE10", Offset = "0xBCBE10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x3000820", Offset = "0x3000820", VA = "0x3000820")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCBE4C", Offset = "0xBCBE4C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public bool isGrounded
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x3000858", Offset = "0x3000858", VA = "0x3000858")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCBE88", Offset = "0xBCBE88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x300089C", Offset = "0x300089C", VA = "0x300089C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCBEC4", Offset = "0xBCBEC4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public Transform root
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x30008E8", Offset = "0x30008E8", VA = "0x30008E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCBF00", Offset = "0xBCBF00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x3000918", Offset = "0x3000918", VA = "0x3000918")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCBF3C", Offset = "0xBCBF3C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x3000950", Offset = "0x3000950", VA = "0x3000950")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCBF78", Offset = "0xBCBF78")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x3000978", Offset = "0x3000978", VA = "0x3000978")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCBFB4", Offset = "0xBCBFB4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x30009E4", Offset = "0x30009E4", VA = "0x30009E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001F")]
		public Vector3 up
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x2FF4080", Offset = "0x2FF4080", VA = "0x2FF4080")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000020")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x3003FEC", Offset = "0x3003FEC", VA = "0x3003FEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x3000AD8", Offset = "0x3000AD8", VA = "0x3000AD8")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x3001488", Offset = "0x3001488", VA = "0x3001488")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2FF2354", Offset = "0x2FF2354", VA = "0x2FF2354")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2FF3710", Offset = "0x2FF3710", VA = "0x2FF3710")]
		public void Update()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2FF7CBC", Offset = "0x2FF7CBC", VA = "0x2FF7CBC")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2FF1914", Offset = "0x2FF1914", VA = "0x2FF1914")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x3001B94", Offset = "0x3001B94", VA = "0x3001B94")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x3004174", Offset = "0x3004174", VA = "0x3004174")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x300445C", Offset = "0x300445C", VA = "0x300445C")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x3004658", Offset = "0x3004658", VA = "0x3004658")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x2FF127C", Offset = "0x2FF127C", VA = "0x2FF127C")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB989C", Offset = "0xBB989C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB989C", Offset = "0xBB989C")]
	public class AimIK : IK
	{
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverAim solver;

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2110828", Offset = "0x2110828", VA = "0x2110828", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCBFF0", Offset = "0xBCBFF0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x21108AC", Offset = "0x21108AC", VA = "0x21108AC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC054", Offset = "0xBCC054")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x2110930", Offset = "0x2110930", VA = "0x2110930")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC0B8", Offset = "0xBCC0B8")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x21109B4", Offset = "0x21109B4", VA = "0x21109B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC11C", Offset = "0xBCC11C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2110A38", Offset = "0x2110A38", VA = "0x2110A38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC180", Offset = "0xBCC180")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2110ABC", Offset = "0x2110ABC", VA = "0x2110ABC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x2110AEC", Offset = "0x2110AEC", VA = "0x2110AEC")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB9948", Offset = "0xBB9948")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB9948", Offset = "0xBB9948")]
	public class ArmIK : IK
	{
		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverArm solver;

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2112368", Offset = "0x2112368", VA = "0x2112368", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC1E4", Offset = "0xBCC1E4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x21123EC", Offset = "0x21123EC", VA = "0x21123EC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC248", Offset = "0xBCC248")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2112470", Offset = "0x2112470", VA = "0x2112470")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC2AC", Offset = "0xBCC2AC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x21124F4", Offset = "0x21124F4", VA = "0x21124F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC310", Offset = "0xBCC310")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2112578", Offset = "0x2112578", VA = "0x2112578", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x21125A8", Offset = "0x21125A8", VA = "0x21125A8")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB99F4", Offset = "0xBB99F4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB99F4", Offset = "0xBB99F4")]
	public class CCDIK : IK
	{
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6BE1")]
		public IKSolverCCD solver;

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x211597C", Offset = "0x211597C", VA = "0x211597C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC374", Offset = "0xBCC374")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2115A00", Offset = "0x2115A00", VA = "0x2115A00", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC3D8", Offset = "0xBCC3D8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2115A84", Offset = "0x2115A84", VA = "0x2115A84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC43C", Offset = "0xBCC43C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2115B08", Offset = "0x2115B08", VA = "0x2115B08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC4A0", Offset = "0xBCC4A0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2115B8C", Offset = "0x2115B8C", VA = "0x2115B8C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2115BBC", Offset = "0x2115BBC", VA = "0x2115BBC")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB9AA0", Offset = "0xBB9AA0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB9AA0", Offset = "0xBB9AA0")]
	public class FABRIK : IK
	{
		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x21171BC", Offset = "0x21171BC", VA = "0x21171BC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC504", Offset = "0xBCC504")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2117240", Offset = "0x2117240", VA = "0x2117240", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC568", Offset = "0xBCC568")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x21172C4", Offset = "0x21172C4", VA = "0x21172C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC5CC", Offset = "0xBCC5CC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2117348", Offset = "0x2117348", VA = "0x2117348")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC630", Offset = "0xBCC630")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x21173CC", Offset = "0x21173CC", VA = "0x21173CC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x21173FC", Offset = "0x21173FC", VA = "0x21173FC")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB9B4C", Offset = "0xBB9B4C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB9B4C", Offset = "0xBB9B4C")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51904")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x21183E8", Offset = "0x21183E8", VA = "0x21183E8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC694", Offset = "0xBCC694")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x211846C", Offset = "0x211846C", VA = "0x211846C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC6F8", Offset = "0xBCC6F8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x21184F0", Offset = "0x21184F0", VA = "0x21184F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC75C", Offset = "0xBCC75C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2118574", Offset = "0x2118574", VA = "0x2118574")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC7C0", Offset = "0xBCC7C0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x21185F8", Offset = "0x21185F8", VA = "0x21185F8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2118628", Offset = "0x2118628", VA = "0x2118628")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB9BF8", Offset = "0xBB9BF8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB9BF8", Offset = "0xBB9BF8")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BipedReferences references;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2FEE388", Offset = "0x2FEE388", VA = "0x2FEE388", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC824", Offset = "0xBCC824")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2FEE40C", Offset = "0x2FEE40C", VA = "0x2FEE40C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC888", Offset = "0xBCC888")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2FEE490", Offset = "0x2FEE490", VA = "0x2FEE490")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC8EC", Offset = "0xBCC8EC")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2FEE514", Offset = "0x2FEE514", VA = "0x2FEE514")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC950", Offset = "0xBCC950")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2FEE598", Offset = "0x2FEE598", VA = "0x2FEE598")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCC9B4", Offset = "0xBCC9B4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2FEE61C", Offset = "0x2FEE61C", VA = "0x2FEE61C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCCA18", Offset = "0xBCCA18")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2FEE6A0", Offset = "0x2FEE6A0", VA = "0x2FEE6A0")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2FEE720", Offset = "0x2FEE720", VA = "0x2FEE720", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2FEE750", Offset = "0x2FEE750", VA = "0x2FEE750")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2FEECA4", Offset = "0x2FEECA4", VA = "0x2FEECA4")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2FEF334", Offset = "0x2FEF334", VA = "0x2FEF334")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCCA7C", Offset = "0xBCCA7C")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x2FEF39C", Offset = "0x2FEF39C", VA = "0x2FEF39C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCCAE0", Offset = "0xBCCAE0")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2FEF5A0", Offset = "0x2FEF5A0", VA = "0x2FEF5A0")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000210")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x300DB14", Offset = "0x300DB14", VA = "0x300DB14", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x300DBF4", Offset = "0x300DBF4", VA = "0x300DBF4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x300DC98", Offset = "0x300DC98", VA = "0x300DC98", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000214")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000215")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2FEF67C", Offset = "0x2FEF67C", VA = "0x2FEF67C")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBD8DC", Offset = "0xBBD8DC")]
		public IK[] IKComponents;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6BE9")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBD940", Offset = "0xBBD940")]
		public Animator animator;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private bool fixedFrame;

		[Token(Token = "0x17000021")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x30138D0", Offset = "0x30138D0", VA = "0x30138D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x3013A70", Offset = "0x3013A70", VA = "0x3013A70")]
		private void Start()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x3013B64", Offset = "0x3013B64", VA = "0x3013B64")]
		private void Update()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x3013D24", Offset = "0x3013D24", VA = "0x3013D24")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x3013D8C", Offset = "0x3013D8C", VA = "0x3013D8C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x3013BC0", Offset = "0x3013BC0", VA = "0x3013BC0")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x3013EE8", Offset = "0x3013EE8", VA = "0x3013EE8")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB9CA4", Offset = "0xBB9CA4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB9CA4", Offset = "0xBB9CA4")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5190C")]
		public IKSolverLeg solver;

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x26732A8", Offset = "0x26732A8", VA = "0x26732A8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCCB44", Offset = "0xBCCB44")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x267332C", Offset = "0x267332C", VA = "0x267332C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCCBA8", Offset = "0xBCCBA8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x26733B0", Offset = "0x26733B0", VA = "0x26733B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCCC0C", Offset = "0xBCCC0C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2673434", Offset = "0x2673434", VA = "0x2673434")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCCC70", Offset = "0xBCCC70")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x26734B8", Offset = "0x26734B8", VA = "0x26734B8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x26734E8", Offset = "0x26734E8", VA = "0x26734E8")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB9D50", Offset = "0xBB9D50")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB9D50", Offset = "0xBB9D50")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2673590", Offset = "0x2673590", VA = "0x2673590", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCCCD4", Offset = "0xBCCCD4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x2673614", Offset = "0x2673614", VA = "0x2673614", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCCD38", Offset = "0xBCCD38")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x2673698", Offset = "0x2673698", VA = "0x2673698")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCCD9C", Offset = "0xBCCD9C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x267371C", Offset = "0x267371C", VA = "0x267371C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCCE00", Offset = "0xBCCE00")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x26737A0", Offset = "0x26737A0", VA = "0x26737A0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x26737D0", Offset = "0x26737D0", VA = "0x26737D0")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB9DFC", Offset = "0xBB9DFC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB9DFC", Offset = "0xBB9DFC")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x2675914", Offset = "0x2675914", VA = "0x2675914", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCCE64", Offset = "0xBCCE64")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x2675998", Offset = "0x2675998", VA = "0x2675998", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCCEC8", Offset = "0xBCCEC8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x2675A1C", Offset = "0x2675A1C", VA = "0x2675A1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCCF2C", Offset = "0xBCCF2C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x2675AA0", Offset = "0x2675AA0", VA = "0x2675AA0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCCF90", Offset = "0xBCCF90")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x2675B24", Offset = "0x2675B24", VA = "0x2675B24", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x2675B54", Offset = "0x2675B54", VA = "0x2675B54")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB9EA8", Offset = "0xBB9EA8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB9EA8", Offset = "0xBB9EA8")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x2689164", Offset = "0x2689164", VA = "0x2689164", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCCFF4", Offset = "0xBCCFF4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x26891E8", Offset = "0x26891E8", VA = "0x26891E8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCD058", Offset = "0xBCD058")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x268926C", Offset = "0x268926C", VA = "0x268926C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCD0BC", Offset = "0xBCD0BC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x26892F0", Offset = "0x26892F0", VA = "0x26892F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCD120", Offset = "0xBCD120")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x2689374", Offset = "0x2689374", VA = "0x2689374", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x26893A4", Offset = "0x26893A4", VA = "0x26893A4")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB9F54", Offset = "0xBB9F54")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x20000D1")]
		public class References
		{
			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51914")]
			public Transform root;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform pelvis;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform spine;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC4964", Offset = "0xBC4964")]
			public Transform chest;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6BF9")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC49C8", Offset = "0xBC49C8")]
			public Transform neck;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public Transform head;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD5191C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC4A2C", Offset = "0xBC4A2C")]
			public Transform leftShoulder;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform leftUpperArm;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform leftForearm;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform leftHand;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C01")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC4A90", Offset = "0xBC4A90")]
			public Transform rightShoulder;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public Transform rightUpperArm;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51924")]
			public Transform rightForearm;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform rightHand;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC4AF4", Offset = "0xBC4AF4")]
			public Transform leftThigh;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC4B58", Offset = "0xBC4B58")]
			public Transform leftCalf;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C09")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC4BBC", Offset = "0xBC4BBC")]
			public Transform leftFoot;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC4C20", Offset = "0xBC4C20")]
			public Transform leftToes;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD5192C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC4C84", Offset = "0xBC4C84")]
			public Transform rightThigh;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC4CE8", Offset = "0xBC4CE8")]
			public Transform rightCalf;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC4D4C", Offset = "0xBC4D4C")]
			public Transform rightFoot;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC4DB0", Offset = "0xBC4DB0")]
			public Transform rightToes;

			[Token(Token = "0x17000081")]
			public bool isFilled
			{
				[Token(Token = "0x600064F")]
				[Address(RVA = "0x268C954", Offset = "0x268C954", VA = "0x268C954")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000082")]
			public bool isEmpty
			{
				[Token(Token = "0x6000650")]
				[Address(RVA = "0x268BA10", Offset = "0x268BA10", VA = "0x268BA10")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x268DC90", Offset = "0x268DC90", VA = "0x268DC90")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0x268AEB0", Offset = "0x268AEB0", VA = "0x268AEB0")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x268DC60", Offset = "0x268DC60", VA = "0x268DC60")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6BF1")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0xBBD9A4", Offset = "0xBBD9A4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBD9A4", Offset = "0xBBD9A4")]
		public References references;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBDA70", Offset = "0xBBDA70")]
		public IKSolverVR solver;

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x268ACD0", Offset = "0x268ACD0", VA = "0x268ACD0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCD184", Offset = "0xBCD184")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x268AD54", Offset = "0x268AD54", VA = "0x268AD54", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCD1E8", Offset = "0xBCD1E8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x268ADD8", Offset = "0x268ADD8", VA = "0x268ADD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCD24C", Offset = "0xBCD24C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x268AE5C", Offset = "0x268AE5C", VA = "0x268AE5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCD2B0", Offset = "0xBCD2B0")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x268B898", Offset = "0x268B898", VA = "0x268B898")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCD314", Offset = "0xBCD314")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x268B900", Offset = "0x268B900", VA = "0x268B900", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x268B930", Offset = "0x268B930", VA = "0x268B930", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x268D8F8", Offset = "0x268D8F8", VA = "0x268D8F8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x268DB84", Offset = "0x268DB84", VA = "0x268DB84")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000040")]
	public class FABRIKChain
	{
		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C11")]
		public FABRIK ik;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBDAD4", Offset = "0xBBDAD4")]
		public float pull;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51934")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBDB1C", Offset = "0xBBDB1C")]
		public float pin;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int[] children;

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x21174A4", Offset = "0x21174A4", VA = "0x21174A4")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x21176A8", Offset = "0x21176A8", VA = "0x21176A8")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2117700", Offset = "0x2117700", VA = "0x2117700")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x21180A4", Offset = "0x21180A4", VA = "0x21180A4")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x211794C", Offset = "0x211794C", VA = "0x211794C")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x2118320", Offset = "0x2118320", VA = "0x2118320")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C19")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5193C")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool initiated;

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x21186D0", Offset = "0x21186D0", VA = "0x21186D0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x2119340", Offset = "0x2119340", VA = "0x2119340")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x211976C", Offset = "0x211976C", VA = "0x211976C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x211994C", Offset = "0x211994C", VA = "0x211994C")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D2")]
		public class BendBone
		{
			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC4E14", Offset = "0xBC4E14")]
			public Transform transform;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC4E78", Offset = "0xBC4E78")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC4E78", Offset = "0xBC4E78")]
			public float weight;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C5E")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000653")]
			[Address(RVA = "0x2FE11D0", Offset = "0x2FE11D0", VA = "0x2FE11D0")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x2FE12C0", Offset = "0x2FE12C0", VA = "0x2FE12C0")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x2FE13E0", Offset = "0x2FE13E0", VA = "0x2FE13E0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0x2FE1450", Offset = "0x2FE1450", VA = "0x2FE1450")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C21")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBDB64", Offset = "0xBBDB64")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xBBDBC8", Offset = "0xBBDBC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBDBC8", Offset = "0xBBDBC8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBDBC8", Offset = "0xBBDBC8")]
		public float positionWeight;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4C5BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBDCAC", Offset = "0xBBDCAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBDCAC", Offset = "0xBBDCAC")]
		public float bodyWeight;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBDD48", Offset = "0xBBDD48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBDD48", Offset = "0xBBDD48")]
		public float thighWeight;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBDDE4", Offset = "0xBBDDE4")]
		public bool handsPullBody;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xBBDE48", Offset = "0xBBDE48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBDE48", Offset = "0xBBDE48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBDE48", Offset = "0xBBDE48")]
		public float rotationWeight;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C27")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBDF2C", Offset = "0xBBDF2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBDF2C", Offset = "0xBBDF2C")]
		public float bodyClampWeight;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBDFC8", Offset = "0xBBDFC8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBDFC8", Offset = "0xBBDFC8")]
		public float headClampWeight;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4CD54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBE064", Offset = "0xBBE064")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBE064", Offset = "0xBBE064")]
		public float bendWeight;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBE100", Offset = "0xBBE100")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xBBE164", Offset = "0xBBE164")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBE164", Offset = "0xBBE164")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBE164", Offset = "0xBBE164")]
		public float CCDWeight;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBE248", Offset = "0xBBE248")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBE248", Offset = "0xBBE248")]
		public float roll;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C2E")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBE2E4", Offset = "0xBBE2E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBE2E4", Offset = "0xBBE2E4")]
		public float damper;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBE380", Offset = "0xBBE380")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51944")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xBBE3E4", Offset = "0xBBE3E4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBE3E4", Offset = "0xBBE3E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBE3E4", Offset = "0xBBE3E4")]
		public float postStretchWeight;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBE4C8", Offset = "0xBBE4C8")]
		public float maxStretch;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBE52C", Offset = "0xBBE52C")]
		public float stretchDamper;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBE590", Offset = "0xBBE590")]
		public bool fixHead;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C36")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBE5F4", Offset = "0xBBE5F4")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xBBE658", Offset = "0xBBE658")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5194C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBE6BC", Offset = "0xBBE6BC")]
		public float chestDirectionWeight;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform[] chestBones;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 offset;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C3E")]
		private Vector3 headToBody;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51954")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C46")]
		private float shoulderDist;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private float leftShoulderDist;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5195C")]
		private float rightShoulderDist;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion chestRotation;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C4E")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51964")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C56")]
		private int bendBonesCount;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private int ccdBonesCount;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5196C")]
		private int stretchBonesCount;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int chestBonesCount;

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x211997C", Offset = "0x211997C", VA = "0x211997C")]
		private void Start()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x2119F40", Offset = "0x2119F40", VA = "0x2119F40")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x211A994", Offset = "0x211A994", VA = "0x211A994")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x211B27C", Offset = "0x211B27C", VA = "0x211B27C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x211C7EC", Offset = "0x211C7EC", VA = "0x211C7EC")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x211CED8", Offset = "0x211CED8", VA = "0x211CED8")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x211D688", Offset = "0x211D688", VA = "0x211D688")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x211F128", Offset = "0x211F128", VA = "0x211F128")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x211C1A4", Offset = "0x211C1A4", VA = "0x211C1A4")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x211F568", Offset = "0x211F568", VA = "0x211F568")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x211EEC0", Offset = "0x211EEC0", VA = "0x211EEC0")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x211EA88", Offset = "0x211EA88", VA = "0x211EA88")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x211FD64", Offset = "0x211FD64", VA = "0x211FD64")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x2120248", Offset = "0x2120248", VA = "0x2120248")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x20000D3")]
		public class ChildConstraint
		{
			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C7E")]
			public float pushElasticity;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public float pullElasticity;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4CD5C")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC4F8C", Offset = "0xBC4F8C")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC4FC8", Offset = "0xBC4FC8")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C85")]
			private float crossFade;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private float inverseCrossFade;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51994")]
			private int chain1Index;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int chain2Index;

			[Token(Token = "0x17000083")]
			public float nominalDistance
			{
				[Token(Token = "0x6000657")]
				[Address(RVA = "0x2FEA358", Offset = "0x2FEA358", VA = "0x2FEA358")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF8C0", Offset = "0xBCF8C0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000658")]
				[Address(RVA = "0x2FEA388", Offset = "0x2FEA388", VA = "0x2FEA388")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF8FC", Offset = "0xBCF8FC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000084")]
			public bool isRigid
			{
				[Token(Token = "0x6000659")]
				[Address(RVA = "0x2FEA3C0", Offset = "0x2FEA3C0", VA = "0x2FEA3C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF938", Offset = "0xBCF938")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600065A")]
				[Address(RVA = "0x2FEA404", Offset = "0x2FEA404", VA = "0x2FEA404")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF974", Offset = "0xBCF974")]
				private set
				{
				}
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x2FEA450", Offset = "0x2FEA450", VA = "0x2FEA450")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x2FE30FC", Offset = "0x2FE30FC", VA = "0x2FE30FC")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x2FE4618", Offset = "0x2FE4618", VA = "0x2FE4618")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0x2FE9BA8", Offset = "0x2FE9BA8", VA = "0x2FE9BA8")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D4")]
		public enum Smoothing
		{
			[Token(Token = "0x4000636")]
			None,
			[Token(Token = "0x4000637")]
			Exponential,
			[Token(Token = "0x4000638")]
			Cubic
		}

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBE704", Offset = "0xBBE704")]
		public float pin;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51974")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBE74C", Offset = "0xBBE74C")]
		public float pull;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBE794", Offset = "0xBBE794")]
		public float push;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBE7DC", Offset = "0xBBE7DC")]
		public float pushParent;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBE828", Offset = "0xBBE828")]
		public float reach;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C66")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5197C")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int[] children;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C6E")]
		private float rootLength;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private bool initiated;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51984")]
		private float length;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float distance;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IKSolver.Point p;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float reachForce;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C76")]
		private float pullParentSum;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private float[] crossFades;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5198C")]
		private float sqrMag1;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float sqrMag2;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float sqrMagDif;

		[Token(Token = "0x40001E8")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x2FE14C0", Offset = "0x2FE14C0", VA = "0x2FE14C0")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x2FE1738", Offset = "0x2FE1738", VA = "0x2FE1738")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x2FE1928", Offset = "0x2FE1928", VA = "0x2FE1928")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x2FE1AE8", Offset = "0x2FE1AE8", VA = "0x2FE1AE8")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x2FE1CCC", Offset = "0x2FE1CCC", VA = "0x2FE1CCC")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x2FE1F8C", Offset = "0x2FE1F8C", VA = "0x2FE1F8C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x2FE38FC", Offset = "0x2FE38FC", VA = "0x2FE38FC")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x2FE2398", Offset = "0x2FE2398", VA = "0x2FE2398")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x2FE4B6C", Offset = "0x2FE4B6C", VA = "0x2FE4B6C")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x2FE554C", Offset = "0x2FE554C", VA = "0x2FE554C")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2FE608C", Offset = "0x2FE608C", VA = "0x2FE608C")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2FE7D00", Offset = "0x2FE7D00", VA = "0x2FE7D00")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x2FE8D3C", Offset = "0x2FE8D3C", VA = "0x2FE8D3C")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x2FE9440", Offset = "0x2FE9440", VA = "0x2FE9440")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x2FE8B2C", Offset = "0x2FE8B2C", VA = "0x2FE8B2C")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x2FE7894", Offset = "0x2FE7894", VA = "0x2FE7894")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x2FE8A38", Offset = "0x2FE8A38", VA = "0x2FE8A38")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2FE96F8", Offset = "0x2FE96F8", VA = "0x2FE96F8")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x2FE8768", Offset = "0x2FE8768", VA = "0x2FE8768")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x2FE9098", Offset = "0x2FE9098", VA = "0x2FE9098")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public class IKConstraintBend
	{
		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5199C")]
		public Transform bone1;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform bone2;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform bone3;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform bendGoal;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C95")]
		public Vector3 direction;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD519A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBE870", Offset = "0xBBE870")]
		public float weight;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float clampF;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C9D")]
		private int chainIndex1;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private int nodeIndex1;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD519AC")]
		private int chainIndex2;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int nodeIndex2;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int chainIndex3;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int nodeIndex3;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6CA5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBE8B8", Offset = "0xBBE8B8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000022")]
		public bool initiated
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x300E314", Offset = "0x300E314", VA = "0x300E314")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCD378", Offset = "0xBCD378")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x300E358", Offset = "0x300E358", VA = "0x300E358")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCD3B4", Offset = "0xBCD3B4")]
			private set
			{
			}
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x300DD38", Offset = "0x300DD38", VA = "0x300DD38")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x2FE1644", Offset = "0x2FE1644", VA = "0x2FE1644")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x300E3A4", Offset = "0x300E3A4", VA = "0x300E3A4")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x2FE31B8", Offset = "0x2FE31B8", VA = "0x2FE31B8")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2FE3220", Offset = "0x2FE3220", VA = "0x2FE3220")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x300E8E4", Offset = "0x300E8E4", VA = "0x300E8E4")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x300ED90", Offset = "0x300ED90", VA = "0x300ED90")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x2FE697C", Offset = "0x2FE697C", VA = "0x2FE697C")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x300E4D4", Offset = "0x300E4D4", VA = "0x300E4D4")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x300E6DC", Offset = "0x300E6DC", VA = "0x300E6DC")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public class IKEffector
	{
		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD519B4")]
		public Transform bone;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform target;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBE8F4", Offset = "0xBBE8F4")]
		public float positionWeight;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBE93C", Offset = "0xBBE93C")]
		public float rotationWeight;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6CAD")]
		public Vector3 position;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Quaternion rotation;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD519BC")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBE984", Offset = "0xBBE984")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool effectChildNodes;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBE9C0", Offset = "0xBBE9C0")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6CB5")]
		public Transform[] childBones;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Transform planeBone1;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD519C4")]
		public Transform planeBone2;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform planeBone3;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float posW;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6CBD")]
		private float rotW;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Vector3[] localPositions;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD519CC")]
		private bool usePlaneNodes;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool firstUpdate;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6CC5")]
		private int chainIndex;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private int nodeIndex;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD519D4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6CCD")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD519DC")]
		private int[] childChainIndexes;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000023")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x300F8A8", Offset = "0x300F8A8", VA = "0x300F8A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCD3F0", Offset = "0xBCD3F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x300F8EC", Offset = "0x300F8EC", VA = "0x300F8EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCD42C", Offset = "0xBCD42C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x300F7E8", Offset = "0x300F7E8", VA = "0x300F7E8")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x300F938", Offset = "0x300F938", VA = "0x300F938")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x300FAE4", Offset = "0x300FAE4", VA = "0x300FAE4")]
		public IKEffector()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x300FDBC", Offset = "0x300FDBC", VA = "0x300FDBC")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x30100CC", Offset = "0x30100CC", VA = "0x30100CC")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x3010AC8", Offset = "0x3010AC8", VA = "0x3010AC8")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x301116C", Offset = "0x301116C", VA = "0x301116C")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x301141C", Offset = "0x301141C", VA = "0x301141C")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x30115A0", Offset = "0x30115A0", VA = "0x30115A0")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x3012518", Offset = "0x3012518", VA = "0x3012518")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x30125EC", Offset = "0x30125EC", VA = "0x30125EC")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x3012AC8", Offset = "0x3012AC8", VA = "0x3012AC8")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x30131A8", Offset = "0x30131A8", VA = "0x30131A8")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000D5")]
		public class BoneMap
		{
			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform transform;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int chainIndex;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6CD5")]
			public int nodeIndex;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4CD64")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 planePosition;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6CDC")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD519E4")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float length;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Quaternion animatedRotation;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Transform planeBone1;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6CE4")]
			private Transform planeBone2;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private Transform planeBone3;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD519EC")]
			private int plane1ChainIndex;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int plane1NodeIndex;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int plane2ChainIndex;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int plane2NodeIndex;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6CEC")]
			private int plane3ChainIndex;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000085")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x6000660")]
				[Address(RVA = "0x3014548", Offset = "0x3014548", VA = "0x3014548")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000086")]
			public bool isNodeBone
			{
				[Token(Token = "0x6000663")]
				[Address(RVA = "0x3014838", Offset = "0x3014838", VA = "0x3014838")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000087")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000677")]
				[Address(RVA = "0x30153E0", Offset = "0x30153E0", VA = "0x30153E0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x30144BC", Offset = "0x30144BC", VA = "0x30144BC")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x3014684", Offset = "0x3014684", VA = "0x3014684")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0x3014748", Offset = "0x3014748", VA = "0x3014748")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0x30148C0", Offset = "0x30148C0", VA = "0x30148C0")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x3014A24", Offset = "0x3014A24", VA = "0x3014A24")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x3014A68", Offset = "0x3014A68", VA = "0x3014A68")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x3014D10", Offset = "0x3014D10", VA = "0x3014D10")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x3014F04", Offset = "0x3014F04", VA = "0x3014F04")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x3015074", Offset = "0x3015074", VA = "0x3015074")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x3015800", Offset = "0x3015800", VA = "0x3015800")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x3015870", Offset = "0x3015870", VA = "0x3015870")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x30158E0", Offset = "0x30158E0", VA = "0x30158E0")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x3015950", Offset = "0x3015950", VA = "0x3015950")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x600066E")]
			[Address(RVA = "0x3015BE4", Offset = "0x3015BE4", VA = "0x3015BE4")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600066F")]
			[Address(RVA = "0x30162EC", Offset = "0x30162EC", VA = "0x30162EC")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0x3016374", Offset = "0x3016374", VA = "0x3016374")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000671")]
			[Address(RVA = "0x3016664", Offset = "0x3016664", VA = "0x3016664")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x3016724", Offset = "0x3016724", VA = "0x3016724")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0x3016BC0", Offset = "0x3016BC0", VA = "0x3016BC0")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0x301700C", Offset = "0x301700C", VA = "0x301700C")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0x30171C0", Offset = "0x30171C0", VA = "0x30171C0")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x3015E18", Offset = "0x3015E18", VA = "0x3015E18")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x3017530", Offset = "0x3017530", VA = "0x3017530")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x3013F18", Offset = "0x3013F18", VA = "0x3013F18", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x3013F44", Offset = "0x3013F44", VA = "0x3013F44", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x3013F5C", Offset = "0x3013F5C", VA = "0x3013F5C")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x301427C", Offset = "0x301427C", VA = "0x301427C")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x301448C", Offset = "0x301448C", VA = "0x301448C")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD519F4")]
		public Transform bone;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBEA08", Offset = "0xBBEA08")]
		public float maintainRotationWeight;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BoneMap boneMap;

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x30175CC", Offset = "0x30175CC", VA = "0x30175CC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x30177AC", Offset = "0x30177AC", VA = "0x30177AC")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x3017864", Offset = "0x3017864", VA = "0x3017864")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x3017934", Offset = "0x3017934", VA = "0x3017934")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x301797C", Offset = "0x301797C", VA = "0x301797C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x30179D4", Offset = "0x30179D4", VA = "0x30179D4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x3017AE0", Offset = "0x3017AE0", VA = "0x3017AE0")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x3017B28", Offset = "0x3017B28", VA = "0x3017B28")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000048")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000D6")]
		public enum BoneMapType
		{
			[Token(Token = "0x4000650")]
			Parent,
			[Token(Token = "0x4000651")]
			Bone1,
			[Token(Token = "0x4000652")]
			Bone2,
			[Token(Token = "0x4000653")]
			Bone3
		}

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform parentBone;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6CF4")]
		public Transform bone1;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Transform bone2;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD519FC")]
		public Transform bone3;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBEA50", Offset = "0xBBEA50")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBEA98", Offset = "0xBBEA98")]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool updatePlaneRotations;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6CFC")]
		private BoneMap boneMapParent;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private BoneMap boneMap1;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51A04")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x32BCA98", Offset = "0x32BCA98", VA = "0x32BCA98", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x32BCC9C", Offset = "0x32BCC9C", VA = "0x32BCC9C")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x32BCEB0", Offset = "0x32BCEB0", VA = "0x32BCEB0")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x32BD548", Offset = "0x32BD548", VA = "0x32BD548")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x32BD690", Offset = "0x32BD690", VA = "0x32BD690")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x32BD824", Offset = "0x32BD824", VA = "0x32BD824")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x32BD8A4", Offset = "0x32BD8A4", VA = "0x32BD8A4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x32BDA3C", Offset = "0x32BDA3C", VA = "0x32BDA3C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x32BDC0C", Offset = "0x32BDC0C", VA = "0x32BDC0C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x32BE170", Offset = "0x32BE170", VA = "0x32BE170")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x32BE344", Offset = "0x32BE344", VA = "0x32BE344")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000049")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform[] spineBones;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D0C")]
		public Transform leftThighBone;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Transform rightThighBone;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51A14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBEAE0", Offset = "0xBBEAE0")]
		public int iterations;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBEB2C", Offset = "0xBBEB2C")]
		public float twistWeight;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int rootNodeIndex;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BoneMap[] spine;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D14")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51A1C")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool useFABRIK;

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x32BE7EC", Offset = "0x32BE7EC", VA = "0x32BE7EC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x32BF228", Offset = "0x32BF228", VA = "0x32BF228")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x32BF3A4", Offset = "0x32BF3A4", VA = "0x32BF3A4")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x32BF57C", Offset = "0x32BF57C", VA = "0x32BF57C")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x32BF614", Offset = "0x32BF614", VA = "0x32BF614")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x32BF6F8", Offset = "0x32BF6F8", VA = "0x32BF6F8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x32BF8B8", Offset = "0x32BF8B8", VA = "0x32BF8B8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x32C08A4", Offset = "0x32C08A4", VA = "0x32C08A4")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x32C097C", Offset = "0x32C097C", VA = "0x32C097C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x32C0F90", Offset = "0x32C0F90", VA = "0x32C0F90")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x32C18C0", Offset = "0x32C18C0", VA = "0x32C18C0")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x32C1B90", Offset = "0x32C1B90", VA = "0x32C1B90")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x32C1E50", Offset = "0x32C1E50", VA = "0x32C1E50")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004A")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000D7")]
		public class Point
		{
			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51A2C")]
			public Transform transform;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC5004", Offset = "0xBC5004")]
			public float weight;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6D2C")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x32C5F80", Offset = "0x32C5F80", VA = "0x32C5F80")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x32C6044", Offset = "0x32C6044", VA = "0x32C6044")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x32C6320", Offset = "0x32C6320", VA = "0x32C6320")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x32C6390", Offset = "0x32C6390", VA = "0x32C6390")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0x32C6400", Offset = "0x32C6400", VA = "0x32C6400")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x600067E")]
			[Address(RVA = "0x32C64C4", Offset = "0x32C64C4", VA = "0x32C64C4")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600067F")]
			[Address(RVA = "0x32C5708", Offset = "0x32C5708", VA = "0x32C5708")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D8")]
		public class Bone : Point
		{
			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4CD6C")]
			public float length;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float sqrMag;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 axis;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6D33")]
			private bool isLimited;

			[Token(Token = "0x17000088")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000680")]
				[Address(RVA = "0x32C4078", Offset = "0x32C4078", VA = "0x32C4078")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000681")]
				[Address(RVA = "0x32C42C0", Offset = "0x32C42C0", VA = "0x32C42C0")]
				set
				{
				}
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x32C43F0", Offset = "0x32C43F0", VA = "0x32C43F0")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0x32C4970", Offset = "0x32C4970", VA = "0x32C4970")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000684")]
			[Address(RVA = "0x32C50B8", Offset = "0x32C50B8", VA = "0x32C50B8")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000685")]
			[Address(RVA = "0x32C5578", Offset = "0x32C5578", VA = "0x32C5578")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000686")]
			[Address(RVA = "0x32C55E8", Offset = "0x32C55E8", VA = "0x32C55E8")]
			public Bone()
			{
			}

			[Token(Token = "0x6000687")]
			[Address(RVA = "0x32C57F8", Offset = "0x32C57F8", VA = "0x32C57F8")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0x32C5930", Offset = "0x32C5930", VA = "0x32C5930")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D9")]
		public class Node : Point
		{
			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public float length;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51A34")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 offset;

			[Token(Token = "0x6000689")]
			[Address(RVA = "0x32C5EA8", Offset = "0x32C5EA8", VA = "0x32C5EA8")]
			public Node()
			{
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x32C5ED8", Offset = "0x32C5ED8", VA = "0x32C5ED8")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0x32C5F20", Offset = "0x32C5F20", VA = "0x32C5F20")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x20000DA")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000DB")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBEBB0", Offset = "0xBBEBB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBEBB0", Offset = "0xBBEBB0")]
		public float IKPositionWeight;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBEC4C", Offset = "0xBBEC4C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51A24")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D24")]
		protected bool firstInitiation;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000024")]
		public bool initiated
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x32C2F74", Offset = "0x32C2F74", VA = "0x32C2F74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCD468", Offset = "0xBCD468")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x32C2FB8", Offset = "0x32C2FB8", VA = "0x32C2FB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCD4A4", Offset = "0xBCD4A4")]
			private set
			{
			}
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x32C259C", Offset = "0x32C259C", VA = "0x32C259C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AC")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x32C2674", Offset = "0x32C2674", VA = "0x32C2674")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x32C2C2C", Offset = "0x32C2C2C", VA = "0x32C2C2C")]
		public void Update()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x32C2D58", Offset = "0x32C2D58", VA = "0x32C2D58", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x32C2D98", Offset = "0x32C2D98", VA = "0x32C2D98")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x32C2DF8", Offset = "0x32C2DF8", VA = "0x32C2DF8")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x32C2E28", Offset = "0x32C2E28", VA = "0x32C2E28")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x32C2F44", Offset = "0x32C2F44", VA = "0x32C2F44")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60002B6")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60002B7")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60002B8")]
		public abstract void FixTransforms();

		[Token(Token = "0x60002B9")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60002BA")]
		protected abstract void OnInitiate();

		[Token(Token = "0x60002BB")]
		protected abstract void OnUpdate();

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x32C3004", Offset = "0x32C3004", VA = "0x32C3004")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x32C3064", Offset = "0x32C3064", VA = "0x32C3064")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x32C3358", Offset = "0x32C3358", VA = "0x32C3358")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x32C34EC", Offset = "0x32C34EC", VA = "0x32C34EC")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x32C401C", Offset = "0x32C401C", VA = "0x32C401C")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform transform;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D3B")]
		public Vector3 axis;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Vector3 poleAxis;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51A3C")]
		public Vector3 polePosition;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBECE4", Offset = "0xBBECE4")]
		public float poleWeight;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform poleTarget;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBED2C", Offset = "0xBBED2C")]
		public float clampWeight;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D43")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBED74", Offset = "0xBBED74")]
		public int clampSmoothing;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51A44")]
		private float step;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform lastTransform;

		[Token(Token = "0x17000025")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x32C6818", Offset = "0x32C6818", VA = "0x32C6818")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000026")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x32C6954", Offset = "0x32C6954", VA = "0x32C6954")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000027")]
		protected override int minBones
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x32C89B8", Offset = "0x32C89B8", VA = "0x32C89B8", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000028")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x32C97D0", Offset = "0x32C97D0", VA = "0x32C97D0", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x32C6684", Offset = "0x32C6684", VA = "0x32C6684")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x32C6A90", Offset = "0x32C6A90", VA = "0x32C6A90", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x32C701C", Offset = "0x32C701C", VA = "0x32C701C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x32C86B0", Offset = "0x32C86B0", VA = "0x32C86B0")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x32C7DD8", Offset = "0x32C7DD8", VA = "0x32C7DD8")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x32C89D4", Offset = "0x32C89D4", VA = "0x32C89D4")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x32C98FC", Offset = "0x32C98FC", VA = "0x32C98FC")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004C")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D4B")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBEDBC", Offset = "0xBBEDBC")]
		public float IKRotationWeight;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Quaternion IKRotation;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51A4C")]
		public Point chest;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Point shoulder;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Point upperArm;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Point forearm;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D53")]
		public Point hand;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public bool isLeft;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51A54")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3[] positions;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion[] rotations;

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x32C9B04", Offset = "0x32C9B04", VA = "0x32C9B04", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x32CA2AC", Offset = "0x32CA2AC", VA = "0x32CA2AC")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x32CA41C", Offset = "0x32CA41C", VA = "0x32CA41C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x32CA5E4", Offset = "0x32CA5E4", VA = "0x32CA5E4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x32CAA88", Offset = "0x32CAA88", VA = "0x32CAA88", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x32CAB30", Offset = "0x32CAB30", VA = "0x32CAB30", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x32CAC04", Offset = "0x32CAC04", VA = "0x32CAC04", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x32CB490", Offset = "0x32CB490", VA = "0x32CB490", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x32CB4DC", Offset = "0x32CB4DC", VA = "0x32CB4DC")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x32CACFC", Offset = "0x32CACFC", VA = "0x32CACFC")]
		private void Read()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x32CB5B8", Offset = "0x32CB5B8", VA = "0x32CB5B8")]
		private void Write()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x32CB944", Offset = "0x32CB944", VA = "0x32CB944")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x32CBB84", Offset = "0x32CBB84", VA = "0x32CBB84")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x32CBDA0", Offset = "0x32CBDA0", VA = "0x32CBDA0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x32CCA68", Offset = "0x32CCA68", VA = "0x32CCA68", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x32CDB5C", Offset = "0x32CDB5C", VA = "0x32CDB5C")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x32CEC44", Offset = "0x32CEC44", VA = "0x32CEC44")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D5B")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private bool[] limitedBones;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51A5C")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000029")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x32D1658", Offset = "0x32D1658", VA = "0x32D1658", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x32CEC74", Offset = "0x32CEC74", VA = "0x32CEC74")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x32CFD2C", Offset = "0x32CFD2C", VA = "0x32CFD2C")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x32CFFB4", Offset = "0x32CFFB4", VA = "0x32CFFB4", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x32D00E0", Offset = "0x32D00E0", VA = "0x32D00E0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x32D0CA8", Offset = "0x32D0CA8", VA = "0x32D0CA8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x32D167C", Offset = "0x32D167C", VA = "0x32D167C")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x32CED90", Offset = "0x32CED90", VA = "0x32CED90")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x32CFF18", Offset = "0x32CFF18", VA = "0x32CFF18")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x32D1568", Offset = "0x32D1568", VA = "0x32D1568")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x32CF800", Offset = "0x32CF800", VA = "0x32CF800")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x32D2D8C", Offset = "0x32D2D8C", VA = "0x32D2D8C")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x32D2F90", Offset = "0x32D2F90", VA = "0x32D2F90")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x32D31F8", Offset = "0x32D31F8", VA = "0x32D31F8")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x32D342C", Offset = "0x32D342C", VA = "0x32D342C")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x32D0778", Offset = "0x32D0778", VA = "0x32D0778")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x32D0A18", Offset = "0x32D0A18", VA = "0x32D0A18")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x32D381C", Offset = "0x32D381C", VA = "0x32D381C")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x32D1E48", Offset = "0x32D1E48", VA = "0x32D1E48")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x32CFE4C", Offset = "0x32CFE4C", VA = "0x32CFE4C")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x32D4974", Offset = "0x32D4974", VA = "0x32D4974")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x32D3B58", Offset = "0x32D3B58", VA = "0x32D3B58")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x32D18D8", Offset = "0x32D18D8", VA = "0x32D18D8")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x32D1BE0", Offset = "0x32D1BE0", VA = "0x32D1BE0")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x32D4C34", Offset = "0x32D4C34", VA = "0x32D4C34")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int iterations;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBEE04", Offset = "0xBBEE04")]
		public float rootPin;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FABRIKChain[] chains;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D63")]
		private bool zeroWeightApplied;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private bool[] isRoot;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51A64")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x32D4D08", Offset = "0x32D4D08", VA = "0x32D4D08", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x32D61D8", Offset = "0x32D61D8", VA = "0x32D61D8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x32D6328", Offset = "0x32D6328", VA = "0x32D6328", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x32D64A4", Offset = "0x32D64A4", VA = "0x32D64A4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x32D66DC", Offset = "0x32D66DC", VA = "0x32D66DC")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x32D68E0", Offset = "0x32D68E0", VA = "0x32D68E0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x32D75A4", Offset = "0x32D75A4", VA = "0x32D75A4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x32D79DC", Offset = "0x32D79DC", VA = "0x32D79DC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x32D7714", Offset = "0x32D7714", VA = "0x32D7714")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x32D6F00", Offset = "0x32D6F00", VA = "0x32D6F00")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x32D7B50", Offset = "0x32D7B50", VA = "0x32D7B50")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBEE4C", Offset = "0xBBEE4C")]
		public int iterations;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FBIKChain[] chain;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D6B")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51A6C")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool FABRIKPass;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D73")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51A74")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x32D7C08", Offset = "0x32D7C08", VA = "0x32D7C08")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x32D7E28", Offset = "0x32D7E28", VA = "0x32D7E28")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x32D7EFC", Offset = "0x32D7EFC", VA = "0x32D7EFC")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x32BE740", Offset = "0x32BE740", VA = "0x32BE740")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x32D81CC", Offset = "0x32D81CC", VA = "0x32D81CC")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x32D8308", Offset = "0x32D8308", VA = "0x32D8308", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x32D869C", Offset = "0x32D869C", VA = "0x32D869C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x32D89F4", Offset = "0x32D89F4", VA = "0x32D89F4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x32D8FF4", Offset = "0x32D8FF4", VA = "0x32D8FF4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x32D9200", Offset = "0x32D9200", VA = "0x32D9200", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x32D946C", Offset = "0x32D946C", VA = "0x32D946C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x32D9810", Offset = "0x32D9810", VA = "0x32D9810", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x32D9BFC", Offset = "0x32D9BFC", VA = "0x32D9BFC", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x32DA284", Offset = "0x32DA284", VA = "0x32DA284", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x32DAB84", Offset = "0x32DAB84", VA = "0x32DAB84", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x32DAC04", Offset = "0x32DAC04", VA = "0x32DAC04", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x32DAE7C", Offset = "0x32DAE7C", VA = "0x32DAE7C")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000051")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x4000272")]
		Body,
		[Token(Token = "0x4000273")]
		LeftShoulder,
		[Token(Token = "0x4000274")]
		RightShoulder,
		[Token(Token = "0x4000275")]
		LeftThigh,
		[Token(Token = "0x4000276")]
		RightThigh,
		[Token(Token = "0x4000277")]
		LeftHand,
		[Token(Token = "0x4000278")]
		RightHand,
		[Token(Token = "0x4000279")]
		LeftFoot,
		[Token(Token = "0x400027A")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000052")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x400027C")]
		LeftArm,
		[Token(Token = "0x400027D")]
		RightArm,
		[Token(Token = "0x400027E")]
		LeftLeg,
		[Token(Token = "0x400027F")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform rootNode;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBEE94", Offset = "0xBBEE94")]
		public float spineStiffness;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBEEDC", Offset = "0xBBEEDC")]
		public float pullBodyVertical;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D92")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBEF28", Offset = "0xBBEF28")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBEF74", Offset = "0xBBEF74")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51A8C")]
		private Vector3 offset;

		[Token(Token = "0x1700002A")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x32DB000", Offset = "0x32DB000", VA = "0x32DB000")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x32DB400", Offset = "0x32DB400", VA = "0x32DB400")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x32DB440", Offset = "0x32DB440", VA = "0x32DB440")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x32DB480", Offset = "0x32DB480", VA = "0x32DB480")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x32DB4C0", Offset = "0x32DB4C0", VA = "0x32DB4C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x32DB500", Offset = "0x32DB500", VA = "0x32DB500")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x32DB540", Offset = "0x32DB540", VA = "0x32DB540")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x32DB580", Offset = "0x32DB580", VA = "0x32DB580")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x32DB5C0", Offset = "0x32DB5C0", VA = "0x32DB5C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x32DB600", Offset = "0x32DB600", VA = "0x32DB600")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x32DB660", Offset = "0x32DB660", VA = "0x32DB660")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x32DB6C0", Offset = "0x32DB6C0", VA = "0x32DB6C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x32DB720", Offset = "0x32DB720", VA = "0x32DB720")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x32DB780", Offset = "0x32DB780", VA = "0x32DB780")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x32DB7D4", Offset = "0x32DB7D4", VA = "0x32DB7D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x32DB834", Offset = "0x32DB834", VA = "0x32DB834")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x32DB894", Offset = "0x32DB894", VA = "0x32DB894")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x32DB8F4", Offset = "0x32DB8F4", VA = "0x32DB8F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x32E073C", Offset = "0x32E073C", VA = "0x32E073C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCD4E0", Offset = "0xBCD4E0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x32E077C", Offset = "0x32E077C", VA = "0x32E077C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCD51C", Offset = "0xBCD51C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x32DB948", Offset = "0x32DB948", VA = "0x32DB948")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x32DBBBC", Offset = "0x32DBBBC", VA = "0x32DBBBC")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x32DB9EC", Offset = "0x32DB9EC", VA = "0x32DB9EC")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x32DBD58", Offset = "0x32DBD58", VA = "0x32DBD58")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x32DB040", Offset = "0x32DB040", VA = "0x32DB040")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x32DC118", Offset = "0x32DC118", VA = "0x32DC118")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x32DC2E8", Offset = "0x32DC2E8", VA = "0x32DC2E8")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x32DC4AC", Offset = "0x32DC4AC", VA = "0x32DC4AC")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x32DC808", Offset = "0x32DC808", VA = "0x32DC808")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x32DC838", Offset = "0x32DC838", VA = "0x32DC838")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x32DC88C", Offset = "0x32DC88C", VA = "0x32DC88C")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x32DCAAC", Offset = "0x32DCAAC", VA = "0x32DCAAC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x32DCFF4", Offset = "0x32DCFF4", VA = "0x32DCFF4")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x32DF4FC", Offset = "0x32DF4FC", VA = "0x32DF4FC")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x32E00C4", Offset = "0x32E00C4", VA = "0x32E00C4")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x32E01D0", Offset = "0x32E01D0", VA = "0x32E01D0")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x32DFCBC", Offset = "0x32DFCBC", VA = "0x32DFCBC")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x32DFEC0", Offset = "0x32DFEC0", VA = "0x32DFEC0")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x32E07DC", Offset = "0x32E07DC", VA = "0x32E07DC")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x32E09D8", Offset = "0x32E09D8", VA = "0x32E09D8", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x32E0D28", Offset = "0x32E0D28", VA = "0x32E0D28")]
		private void PullBody()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x32E10EC", Offset = "0x32E10EC", VA = "0x32E10EC")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x32E1490", Offset = "0x32E1490", VA = "0x32E1490")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x32E1920", Offset = "0x32E1920", VA = "0x32E1920", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x32E20AC", Offset = "0x32E20AC", VA = "0x32E20AC", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x32E2274", Offset = "0x32E2274", VA = "0x32E2274")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform target;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float tolerance;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int maxIterations;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D9A")]
		public bool useRotationLimits;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public bool XY;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51A94")]
		public Bone[] bones;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected float chainLength;

		[Token(Token = "0x1700003D")]
		protected virtual int minBones
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x32E34EC", Offset = "0x32E34EC", VA = "0x32E34EC", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003E")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x32E3508", Offset = "0x32E3508", VA = "0x32E3508", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x32E352C", Offset = "0x32E352C", VA = "0x32E352C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0x32E3578", Offset = "0x32E3578", VA = "0x32E3578", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000041")]
		protected float positionOffset
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x32CDA14", Offset = "0x32CDA14", VA = "0x32CDA14")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x32E22C8", Offset = "0x32E22C8", VA = "0x32E22C8")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x32E2654", Offset = "0x32E2654", VA = "0x32E2654")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x32E28D4", Offset = "0x32E28D4", VA = "0x32E28D4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x32E29B8", Offset = "0x32E29B8", VA = "0x32E29B8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x32E2AFC", Offset = "0x32E2AFC", VA = "0x32E2AFC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x32E3284", Offset = "0x32E3284", VA = "0x32E3284", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x32E32CC", Offset = "0x32E32CC", VA = "0x32E32CC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x32E3550", Offset = "0x32E3550", VA = "0x32E3550", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x32E3564", Offset = "0x32E3564", VA = "0x32E3564", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x32CBEB8", Offset = "0x32CBEB8", VA = "0x32CBEB8")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x32CD284", Offset = "0x32CD284", VA = "0x32CD284")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x32E37E0", Offset = "0x32E37E0", VA = "0x32E37E0")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x32C9A34", Offset = "0x32C9A34", VA = "0x32C9A34")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBEFB0", Offset = "0xBBEFB0")]
		public float IKRotationWeight;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6DA2")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Point pelvis;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51A9C")]
		public Point thigh;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Point calf;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Point foot;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Point toe;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6DAA")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51AA4")]
		private Vector3[] positions;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x32E3E0C", Offset = "0x32E3E0C", VA = "0x32E3E0C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x32E45B4", Offset = "0x32E45B4", VA = "0x32E45B4")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x32E4724", Offset = "0x32E4724", VA = "0x32E4724", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x32E48EC", Offset = "0x32E48EC", VA = "0x32E48EC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x32E4D90", Offset = "0x32E4D90", VA = "0x32E4D90", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x32E4E38", Offset = "0x32E4E38", VA = "0x32E4E38", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x32E4F0C", Offset = "0x32E4F0C", VA = "0x32E4F0C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x32E5798", Offset = "0x32E5798", VA = "0x32E5798", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x32E57E4", Offset = "0x32E57E4", VA = "0x32E57E4")]
		private void Solve()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x32E5004", Offset = "0x32E5004", VA = "0x32E5004")]
		private void Read()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x32E59C8", Offset = "0x32E59C8", VA = "0x32E59C8")]
		private void Write()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x32E5D54", Offset = "0x32E5D54", VA = "0x32E5D54")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x20000DC")]
		public enum BendModifier
		{
			[Token(Token = "0x4000664")]
			Animation,
			[Token(Token = "0x4000665")]
			Target,
			[Token(Token = "0x4000666")]
			Parent,
			[Token(Token = "0x4000667")]
			Arm,
			[Token(Token = "0x4000668")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x20000DD")]
		public struct AxisDirection
		{
			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51AB4")]
			public Vector3 direction;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 axis;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float dot;

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x32E9080", Offset = "0x32E9080", VA = "0x32E9080")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AvatarIKGoal goal;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BendModifier bendModifier;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6DB2")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBEFF8", Offset = "0xBBEFF8")]
		public float maintainRotationWeight;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBF040", Offset = "0xBBF040")]
		public float bendModifierWeight;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51AAC")]
		public Transform bendGoal;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6DBA")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51AB4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 animationNormal;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6DC2")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000042")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x32E9004", Offset = "0x32E9004", VA = "0x32E9004")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x32E5F94", Offset = "0x32E5F94", VA = "0x32E5F94")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x32E6054", Offset = "0x32E6054", VA = "0x32E6054")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x32E6100", Offset = "0x32E6100", VA = "0x32E6100", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x32E6D40", Offset = "0x32E6D40", VA = "0x32E6D40", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x32E89D8", Offset = "0x32E89D8", VA = "0x32E89D8", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x32E8C38", Offset = "0x32E8C38", VA = "0x32E8C38")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x32E8F14", Offset = "0x32E8F14", VA = "0x32E8F14")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x32E68A8", Offset = "0x32E68A8", VA = "0x32E68A8")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x32E7024", Offset = "0x32E7024", VA = "0x32E7024")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000DE")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x17000089")]
			public Vector3 forward
			{
				[Token(Token = "0x6000699")]
				[Address(RVA = "0x32EE1A4", Offset = "0x32EE1A4", VA = "0x32EE1A4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x32EF1C4", Offset = "0x32EF1C4", VA = "0x32EF1C4")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x32EBDE4", Offset = "0x32EBDE4", VA = "0x32EBDE4")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000697")]
			[Address(RVA = "0x32EC840", Offset = "0x32EC840", VA = "0x32EC840")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000698")]
			[Address(RVA = "0x32EEBDC", Offset = "0x32EEBDC", VA = "0x32EEBDC")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform target;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6DD2")]
		public LookAtBone[] spine;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public LookAtBone head;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51ACC")]
		public LookAtBone[] eyes;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBF088", Offset = "0xBBF088")]
		public float bodyWeight;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBF0D0", Offset = "0xBBF0D0")]
		public float headWeight;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBF118", Offset = "0xBBF118")]
		public float eyesWeight;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6DDA")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBF160", Offset = "0xBBF160")]
		public float clampWeight;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBF1A8", Offset = "0xBBF1A8")]
		public float clampWeightHead;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4CD7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBF1F0", Offset = "0xBBF1F0")]
		public float clampWeightEyes;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBF238", Offset = "0xBBF238")]
		public int clampSmoothing;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6DE1")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		protected Vector3[] headForwards;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51AD4")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x17000043")]
		protected bool spineIsValid
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x32EA6C0", Offset = "0x32EA6C0", VA = "0x32EA6C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x32EACD4", Offset = "0x32EACD4", VA = "0x32EACD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		protected bool headIsValid
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x32EA988", Offset = "0x32EA988", VA = "0x32EA988")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0x32EAD50", Offset = "0x32EAD50", VA = "0x32EAD50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x32EAA0C", Offset = "0x32EAA0C", VA = "0x32EAA0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x32EAE80", Offset = "0x32EAE80", VA = "0x32EAE80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x32E9140", Offset = "0x32E9140", VA = "0x32E9140")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x32E925C", Offset = "0x32E925C", VA = "0x32E925C")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x32E93AC", Offset = "0x32E93AC", VA = "0x32E93AC")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x32E952C", Offset = "0x32E952C", VA = "0x32E952C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x32E96DC", Offset = "0x32E96DC", VA = "0x32E96DC")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x32E98EC", Offset = "0x32E98EC", VA = "0x32E98EC")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x32E9B2C", Offset = "0x32E9B2C", VA = "0x32E9B2C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x32E9E1C", Offset = "0x32E9E1C", VA = "0x32E9E1C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x32EA16C", Offset = "0x32EA16C", VA = "0x32EA16C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x32EAEFC", Offset = "0x32EAEFC", VA = "0x32EAEFC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x32EB4A4", Offset = "0x32EB4A4", VA = "0x32EB4A4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x32EB90C", Offset = "0x32EB90C", VA = "0x32EB90C")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x32EBE2C", Offset = "0x32EBE2C", VA = "0x32EBE2C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x32ECA68", Offset = "0x32ECA68", VA = "0x32ECA68", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x32ECC60", Offset = "0x32ECC60", VA = "0x32ECC60")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x32ED11C", Offset = "0x32ED11C", VA = "0x32ED11C")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x32ED6EC", Offset = "0x32ED6EC", VA = "0x32ED6EC")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x32EE2E0", Offset = "0x32EE2E0", VA = "0x32EE2E0")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x32EBA54", Offset = "0x32EBA54", VA = "0x32EBA54")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x32EEE60", Offset = "0x32EEE60", VA = "0x32EEE60")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000DF")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51AE4")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x600069A")]
			[Address(RVA = "0x31CAAF4", Offset = "0x31CAAF4", VA = "0x31CAAF4")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0x31CAE84", Offset = "0x31CAE84", VA = "0x31CAE84")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x31CB020", Offset = "0x31CB020", VA = "0x31CB020")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0x31CB15C", Offset = "0x31CB15C", VA = "0x31CB15C")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform target;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBF280", Offset = "0xBBF280")]
		public float IKRotationWeight;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6DE9")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Vector3 bendNormal;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51ADC")]
		public TrigonometricBone bone1;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TrigonometricBone bone2;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TrigonometricBone bone3;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6DF1")]
		protected bool directHierarchy;

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x32EF1F4", Offset = "0x32EF1F4", VA = "0x32EF1F4")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x32EF670", Offset = "0x32EF670", VA = "0x32EF670")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x32EFA08", Offset = "0x32EFA08", VA = "0x32EFA08")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x32EFB38", Offset = "0x32EFB38", VA = "0x32EFB38")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x32EFC54", Offset = "0x32EFC54", VA = "0x32EFC54")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x32EFC9C", Offset = "0x32EFC9C", VA = "0x32EFC9C")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x32EFCCC", Offset = "0x32EFCCC", VA = "0x32EFCCC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x32EFE14", Offset = "0x32EFE14", VA = "0x32EFE14", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x32F0110", Offset = "0x32F0110", VA = "0x32F0110", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x32F0198", Offset = "0x32F0198", VA = "0x32F0198", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x32F024C", Offset = "0x32F024C", VA = "0x32F024C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x32F09BC", Offset = "0x32F09BC", VA = "0x32F09BC")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x32F0AAC", Offset = "0x32F0AAC", VA = "0x32F0AAC")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x32F17B4", Offset = "0x32F17B4", VA = "0x32F17B4")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x32F1C44", Offset = "0x32F1C44", VA = "0x32F1C44", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x32F20B8", Offset = "0x32F20B8", VA = "0x32F20B8")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x32F1F30", Offset = "0x32F1F30", VA = "0x32F1F30")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x32F2344", Offset = "0x32F2344", VA = "0x32F2344", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x32F3AD0", Offset = "0x32F3AD0", VA = "0x32F3AD0", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x32F3AE4", Offset = "0x32F3AE4", VA = "0x32F3AE4", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x32F3AF8", Offset = "0x32F3AF8", VA = "0x32F3AF8", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x32F3424", Offset = "0x32F3424", VA = "0x32F3424")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x32E8D10", Offset = "0x32E8D10", VA = "0x32E8D10")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000E0")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x2000122")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000851")]
				YawPitch,
				[Token(Token = "0x4000852")]
				FromTo
			}

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC504C", Offset = "0xBC504C")]
			public Transform target;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC50B0", Offset = "0xBC50B0")]
			public Transform bendGoal;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC5114", Offset = "0xBC5114")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC5114", Offset = "0xBC5114")]
			public float positionWeight;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6E29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC51B0", Offset = "0xBC51B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC51B0", Offset = "0xBC51B0")]
			public float rotationWeight;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC524C", Offset = "0xBC524C")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51B1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC52B0", Offset = "0xBC52B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC52B0", Offset = "0xBC52B0")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC534C", Offset = "0xBC534C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC534C", Offset = "0xBC534C")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC53E8", Offset = "0xBC53E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC53E8", Offset = "0xBC53E8")]
			public float bendGoalWeight;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC5484", Offset = "0xBC5484")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC5484", Offset = "0xBC5484")]
			public float swivelOffset;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6E31")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC5524", Offset = "0xBC5524")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC5588", Offset = "0xBC5588")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4CD84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC55EC", Offset = "0xBC55EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC55EC", Offset = "0xBC55EC")]
			public float armLengthMlp;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC5690", Offset = "0xBC5690")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6E38")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51B24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC57E4", Offset = "0xBC57E4")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC5820", Offset = "0xBC5820")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool hasShoulder;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6E40")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51B2C")]
			private Vector3 chestForward;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 chestUp;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x400068A")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x400068B")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x1700008A")]
			public Vector3 position
			{
				[Token(Token = "0x600069E")]
				[Address(RVA = "0x31E3A3C", Offset = "0x31E3A3C", VA = "0x31E3A3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF9B0", Offset = "0xBCF9B0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600069F")]
				[Address(RVA = "0x31E3A7C", Offset = "0x31E3A7C", VA = "0x31E3A7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF9EC", Offset = "0xBCF9EC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008B")]
			public Quaternion rotation
			{
				[Token(Token = "0x60006A0")]
				[Address(RVA = "0x31E3ADC", Offset = "0x31E3ADC", VA = "0x31E3ADC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCFA28", Offset = "0xBCFA28")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006A1")]
				[Address(RVA = "0x31E3B24", Offset = "0x31E3B24", VA = "0x31E3B24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCFA64", Offset = "0xBCFA64")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008C")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x60006A2")]
				[Address(RVA = "0x31E3C54", Offset = "0x31E3C54", VA = "0x31E3C54")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008D")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x60006A3")]
				[Address(RVA = "0x31E3CA8", Offset = "0x31E3CA8", VA = "0x31E3CA8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008E")]
			private VirtualBone forearm
			{
				[Token(Token = "0x60006A4")]
				[Address(RVA = "0x31E3D68", Offset = "0x31E3D68", VA = "0x31E3D68")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008F")]
			private VirtualBone hand
			{
				[Token(Token = "0x60006A5")]
				[Address(RVA = "0x31E3E2C", Offset = "0x31E3E2C", VA = "0x31E3E2C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x31E3EF0", Offset = "0x31E3EF0", VA = "0x31E3EF0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x31E5374", Offset = "0x31E5374", VA = "0x31E5374", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x31E585C", Offset = "0x31E585C", VA = "0x31E585C", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x31E59A0", Offset = "0x31E59A0", VA = "0x31E59A0")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x31DD8F8", Offset = "0x31DD8F8", VA = "0x31DD8F8")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x31E8D6C", Offset = "0x31E8D6C", VA = "0x31E8D6C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x31E8E40", Offset = "0x31E8E40", VA = "0x31E8E40", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x31E64A8", Offset = "0x31E64A8", VA = "0x31E64A8")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x31E6CC4", Offset = "0x31E6CC4", VA = "0x31E6CC4")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x31E9344", Offset = "0x31E9344", VA = "0x31E9344")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x31E3344", Offset = "0x31E3344", VA = "0x31E3344")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E1")]
		public abstract class BodyPart
		{
			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC585C", Offset = "0xBC585C")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6E50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC5898", Offset = "0xBC5898")]
			private float <mag>k__BackingField;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51B3C")]
			protected bool initiated;

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int index;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6E58")]
			protected int LOD;

			[Token(Token = "0x17000090")]
			public float sqrMag
			{
				[Token(Token = "0x60006B6")]
				[Address(RVA = "0x31E9698", Offset = "0x31E9698", VA = "0x31E9698")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCFAA0", Offset = "0xBCFAA0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006B7")]
				[Address(RVA = "0x31E96C8", Offset = "0x31E96C8", VA = "0x31E96C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCFADC", Offset = "0xBCFADC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000091")]
			public float mag
			{
				[Token(Token = "0x60006B8")]
				[Address(RVA = "0x31E9700", Offset = "0x31E9700", VA = "0x31E9700")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCFB18", Offset = "0xBCFB18")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006B9")]
				[Address(RVA = "0x31E9730", Offset = "0x31E9730", VA = "0x31E9730")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCFB54", Offset = "0xBCFB54")]
				private set
				{
				}
			}

			[Token(Token = "0x60006B1")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x60006B2")]
			public abstract void PreSolve();

			[Token(Token = "0x60006B3")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x60006B4")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x60006B5")]
			public abstract void ResetOffsets();

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x31E9768", Offset = "0x31E9768", VA = "0x31E9768")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x31D76FC", Offset = "0x31D76FC", VA = "0x31D76FC")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x31EA014", Offset = "0x31EA014", VA = "0x31EA014")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x31EA338", Offset = "0x31EA338", VA = "0x31EA338")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x31EA970", Offset = "0x31EA970", VA = "0x31EA970")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x31DCF14", Offset = "0x31DCF14", VA = "0x31DCF14")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x31E89C0", Offset = "0x31E89C0", VA = "0x31E89C0")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x31EAA14", Offset = "0x31EAA14", VA = "0x31EAA14")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x31EAC5C", Offset = "0x31EAC5C", VA = "0x31EAC5C")]
			public void Visualize()
			{
			}

			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x31E9584", Offset = "0x31E9584", VA = "0x31E9584")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E2")]
		public class Footstep
		{
			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public float stepSpeed;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51B44")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Quaternion rotation;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6E60")]
			public bool isSupportLeg;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC5910", Offset = "0xBC5910")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51B4C")]
			public Vector3 stepFrom;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 stepTo;

			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Quaternion stepFromRot;

			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Quaternion stepToRot;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6E68")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private float supportLegW;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51B54")]
			private float supportLegWV;

			[Token(Token = "0x17000092")]
			public bool isStepping
			{
				[Token(Token = "0x60006C4")]
				[Address(RVA = "0x31EACBC", Offset = "0x31EACBC", VA = "0x31EACBC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000093")]
			public float stepProgress
			{
				[Token(Token = "0x60006C5")]
				[Address(RVA = "0x31EAD44", Offset = "0x31EAD44", VA = "0x31EAD44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCFB90", Offset = "0xBCFB90")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006C6")]
				[Address(RVA = "0x31EAD74", Offset = "0x31EAD74", VA = "0x31EAD74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCFBCC", Offset = "0xBCFBCC")]
				private set
				{
				}
			}

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x31EADAC", Offset = "0x31EADAC", VA = "0x31EADAC")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x31EB150", Offset = "0x31EB150", VA = "0x31EB150")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x31EB328", Offset = "0x31EB328", VA = "0x31EB328")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x31EB728", Offset = "0x31EB728", VA = "0x31EB728")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x31EBAE4", Offset = "0x31EBAE4", VA = "0x31EBAE4")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x31EBED8", Offset = "0x31EBED8", VA = "0x31EBED8")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E3")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC594C", Offset = "0xBC594C")]
			public Transform target;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC59B0", Offset = "0xBC59B0")]
			public Transform bendGoal;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC5A14", Offset = "0xBC5A14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC5A14", Offset = "0xBC5A14")]
			public float positionWeight;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6E70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC5AB0", Offset = "0xBC5AB0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC5AB0", Offset = "0xBC5AB0")]
			public float rotationWeight;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC5B4C", Offset = "0xBC5B4C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC5B4C", Offset = "0xBC5B4C")]
			public float bendGoalWeight;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51B5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC5BE8", Offset = "0xBC5BE8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC5BE8", Offset = "0xBC5BE8")]
			public float swivelOffset;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC5C88", Offset = "0xBC5C88")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC5C88", Offset = "0xBC5C88")]
			public float bendToTargetWeight;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC5D24", Offset = "0xBC5D24")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC5D24", Offset = "0xBC5D24")]
			public float legLengthMlp;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC5DC8", Offset = "0xBC5DC8")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6E78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51B64")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6E80")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC5FD0", Offset = "0xBC5FD0")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51B6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC600C", Offset = "0xBC600C")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC6048", Offset = "0xBC6048")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC6084", Offset = "0xBC6084")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 footPosition;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6E88")]
			private Quaternion footRotation;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private Vector3 bendNormal;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4CD8C")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x17000094")]
			public Vector3 position
			{
				[Token(Token = "0x60006CD")]
				[Address(RVA = "0x31EC3A0", Offset = "0x31EC3A0", VA = "0x31EC3A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCFC08", Offset = "0xBCFC08")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006CE")]
				[Address(RVA = "0x31EC3E0", Offset = "0x31EC3E0", VA = "0x31EC3E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCFC44", Offset = "0xBCFC44")]
				private set
				{
				}
			}

			[Token(Token = "0x17000095")]
			public Quaternion rotation
			{
				[Token(Token = "0x60006CF")]
				[Address(RVA = "0x31EC440", Offset = "0x31EC440", VA = "0x31EC440")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCFC80", Offset = "0xBCFC80")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006D0")]
				[Address(RVA = "0x31EC488", Offset = "0x31EC488", VA = "0x31EC488")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCFCBC", Offset = "0xBCFCBC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000096")]
			public bool hasToes
			{
				[Token(Token = "0x60006D1")]
				[Address(RVA = "0x31EC5B8", Offset = "0x31EC5B8", VA = "0x31EC5B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCFCF8", Offset = "0xBCFCF8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006D2")]
				[Address(RVA = "0x31EC5FC", Offset = "0x31EC5FC", VA = "0x31EC5FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCFD34", Offset = "0xBCFD34")]
				private set
				{
				}
			}

			[Token(Token = "0x17000097")]
			public VirtualBone thigh
			{
				[Token(Token = "0x60006D3")]
				[Address(RVA = "0x31EC648", Offset = "0x31EC648", VA = "0x31EC648")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000098")]
			private VirtualBone calf
			{
				[Token(Token = "0x60006D4")]
				[Address(RVA = "0x31EC69C", Offset = "0x31EC69C", VA = "0x31EC69C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000099")]
			private VirtualBone foot
			{
				[Token(Token = "0x60006D5")]
				[Address(RVA = "0x31EC6FC", Offset = "0x31EC6FC", VA = "0x31EC6FC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009A")]
			private VirtualBone toes
			{
				[Token(Token = "0x60006D6")]
				[Address(RVA = "0x31EC75C", Offset = "0x31EC75C", VA = "0x31EC75C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009B")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x60006D7")]
				[Address(RVA = "0x31DCAB0", Offset = "0x31DCAB0", VA = "0x31DCAB0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009C")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x60006D8")]
				[Address(RVA = "0x31EC7BC", Offset = "0x31EC7BC", VA = "0x31EC7BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCFD70", Offset = "0xBCFD70")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006D9")]
				[Address(RVA = "0x31EC7FC", Offset = "0x31EC7FC", VA = "0x31EC7FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCFDAC", Offset = "0xBCFDAC")]
				private set
				{
				}
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x31EC85C", Offset = "0x31EC85C", VA = "0x31EC85C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x31ED96C", Offset = "0x31ED96C", VA = "0x31ED96C", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x31EF040", Offset = "0x31EF040", VA = "0x31EF040", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x31EEDD4", Offset = "0x31EEDD4", VA = "0x31EEDD4")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x31EE8B0", Offset = "0x31EE8B0", VA = "0x31EE8B0")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x31DD354", Offset = "0x31DD354", VA = "0x31DD354")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x31F0D50", Offset = "0x31F0D50", VA = "0x31F0D50")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x31EFEBC", Offset = "0x31EFEBC", VA = "0x31EFEBC")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x31F169C", Offset = "0x31F169C", VA = "0x31F169C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x31F1BA0", Offset = "0x31F1BA0", VA = "0x31F1BA0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x31E3604", Offset = "0x31E3604", VA = "0x31E3604")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E4")]
		public class Locomotion
		{
			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6E8F")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC60C0", Offset = "0xBC60C0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC60C0", Offset = "0xBC60C0")]
			public float weight;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC615C", Offset = "0xBC615C")]
			public float footDistance;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51B74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC61C0", Offset = "0xBC61C0")]
			public float stepThreshold;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC6224", Offset = "0xBC6224")]
			public float angleThreshold;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC6288", Offset = "0xBC6288")]
			public float comAngleMlp;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC62EC", Offset = "0xBC62EC")]
			public float maxVelocity;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6E97")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC6350", Offset = "0xBC6350")]
			public float velocityFactor;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC63B4", Offset = "0xBC63B4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC63B4", Offset = "0xBC63B4")]
			public float maxLegStretch;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51B7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC6458", Offset = "0xBC6458")]
			public float rootSpeed;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC64BC", Offset = "0xBC64BC")]
			public float stepSpeed;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC6520", Offset = "0xBC6520")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC6584", Offset = "0xBC6584")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6E9F")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC65E8", Offset = "0xBC65E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC65E8", Offset = "0xBC65E8")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC6684", Offset = "0xBC6684")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51B84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC66E8", Offset = "0xBC66E8")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC674C", Offset = "0xBC674C")]
			public Vector3 offset;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6EA7")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51B8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC68A0", Offset = "0xBC68A0")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC6904", Offset = "0xBC6904")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC6968", Offset = "0xBC6968")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Footstep[] footsteps;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6EAF")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private Vector3 comVelocity;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51B94")]
			private int leftFootIndex;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int rightFootIndex;

			[Token(Token = "0x1700009D")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x60006E5")]
				[Address(RVA = "0x31F1D34", Offset = "0x31F1D34", VA = "0x31F1D34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCFDE8", Offset = "0xBCFDE8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006E6")]
				[Address(RVA = "0x31F1D74", Offset = "0x31F1D74", VA = "0x31F1D74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCFE24", Offset = "0xBCFE24")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009E")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x60006EC")]
				[Address(RVA = "0x31F2864", Offset = "0x31F2864", VA = "0x31F2864")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009F")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x60006ED")]
				[Address(RVA = "0x31F28D8", Offset = "0x31F28D8", VA = "0x31F28D8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A0")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x60006EE")]
				[Address(RVA = "0x31F294C", Offset = "0x31F294C", VA = "0x31F294C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000A1")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x60006EF")]
				[Address(RVA = "0x31F29C8", Offset = "0x31F29C8", VA = "0x31F29C8")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x31D7980", Offset = "0x31D7980", VA = "0x31D7980")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x31D09E0", Offset = "0x31D09E0", VA = "0x31D09E0")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x31CE9AC", Offset = "0x31CE9AC", VA = "0x31CE9AC")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x31CE548", Offset = "0x31CE548", VA = "0x31CE548")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x31D9018", Offset = "0x31D9018", VA = "0x31D9018")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x31F1E38", Offset = "0x31F1E38", VA = "0x31F1E38")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x31F2274", Offset = "0x31F2274", VA = "0x31F2274")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x31F2410", Offset = "0x31F2410", VA = "0x31F2410")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x31E3810", Offset = "0x31E3810", VA = "0x31E3810")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E5")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC69A4", Offset = "0xBC69A4")]
			public Transform headTarget;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC6A08", Offset = "0xBC6A08")]
			public Transform pelvisTarget;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6EB7")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC6A6C", Offset = "0xBC6A6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC6A6C", Offset = "0xBC6A6C")]
			public float positionWeight;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC6B08", Offset = "0xBC6B08")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC6B08", Offset = "0xBC6B08")]
			public float rotationWeight;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51B9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC6BA4", Offset = "0xBC6BA4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC6BA4", Offset = "0xBC6BA4")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC6C40", Offset = "0xBC6C40")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC6C40", Offset = "0xBC6C40")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC6CDC", Offset = "0xBC6CDC")]
			public Transform chestGoal;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC6D40", Offset = "0xBC6D40")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC6D40", Offset = "0xBC6D40")]
			public float chestGoalWeight;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6EBF")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC6DDC", Offset = "0xBC6DDC")]
			public float minHeadHeight;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC6E40", Offset = "0xBC6E40")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC6E40", Offset = "0xBC6E40")]
			public float bodyPosStiffness;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51BA4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC6EDC", Offset = "0xBC6EDC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC6EDC", Offset = "0xBC6EDC")]
			public float bodyRotStiffness;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC6F78", Offset = "0xBC6F78")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBC6F78", Offset = "0xBC6F78")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC6F78", Offset = "0xBC6F78")]
			public float neckStiffness;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC705C", Offset = "0xBC705C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC705C", Offset = "0xBC705C")]
			public float rotateChestByHands;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC70F8", Offset = "0xBC70F8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC70F8", Offset = "0xBC70F8")]
			public float chestClampWeight;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6EC7")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC7194", Offset = "0xBC7194")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC7194", Offset = "0xBC7194")]
			public float headClampWeight;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC7230", Offset = "0xBC7230")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51BAC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC7294", Offset = "0xBC7294")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC7294", Offset = "0xBC7294")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC7330", Offset = "0xBC7330")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC7330", Offset = "0xBC7330")]
			public float maxRootAngle;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC73CC", Offset = "0xBC73CC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC73CC", Offset = "0xBC73CC")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6ECF")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51BB4")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6ED7")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51BBC")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6EDF")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC77B4", Offset = "0xBC77B4")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4CD94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC77F0", Offset = "0xBC77F0")]
			private Quaternion <anchorRelativeToHead>k__BackingField;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Quaternion headRotation;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6EE6")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51BC4")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int pelvisIndex;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6EEE")]
			private int spineIndex;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private int chestIndex;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51BCC")]
			private int neckIndex;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int headIndex;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float length;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool hasChest;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6EF6")]
			private bool hasNeck;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private bool hasLegs;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51BD4")]
			private float headHeight;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float sizeMlp;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 chestForward;

			[Token(Token = "0x170000A2")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x60006F4")]
				[Address(RVA = "0x31D0F7C", Offset = "0x31D0F7C", VA = "0x31D0F7C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A3")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x60006F5")]
				[Address(RVA = "0x31F2A44", Offset = "0x31F2A44", VA = "0x31F2A44")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A4")]
			public VirtualBone chest
			{
				[Token(Token = "0x60006F6")]
				[Address(RVA = "0x31DD820", Offset = "0x31DD820", VA = "0x31DD820")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A5")]
			private VirtualBone neck
			{
				[Token(Token = "0x60006F7")]
				[Address(RVA = "0x31F2AA8", Offset = "0x31F2AA8", VA = "0x31F2AA8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A6")]
			public VirtualBone head
			{
				[Token(Token = "0x60006F8")]
				[Address(RVA = "0x31F1DD4", Offset = "0x31F1DD4", VA = "0x31F1DD4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A7")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x60006F9")]
				[Address(RVA = "0x31F2B0C", Offset = "0x31F2B0C", VA = "0x31F2B0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCFE60", Offset = "0xBCFE60")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006FA")]
				[Address(RVA = "0x31F2B54", Offset = "0x31F2B54", VA = "0x31F2B54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCFE9C", Offset = "0xBCFE9C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A8")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x60006FB")]
				[Address(RVA = "0x31F2C84", Offset = "0x31F2C84", VA = "0x31F2C84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCFED8", Offset = "0xBCFED8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006FC")]
				[Address(RVA = "0x31F2CCC", Offset = "0x31F2CCC", VA = "0x31F2CCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCFF14", Offset = "0xBCFF14")]
				private set
				{
				}
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x31F2DFC", Offset = "0x31F2DFC", VA = "0x31F2DFC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x31F4B34", Offset = "0x31F4B34", VA = "0x31F4B34", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x31F513C", Offset = "0x31F513C", VA = "0x31F513C", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x31F6170", Offset = "0x31F6170", VA = "0x31F6170")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x31D7F0C", Offset = "0x31D7F0C", VA = "0x31D7F0C")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x31F7AB4", Offset = "0x31F7AB4", VA = "0x31F7AB4")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x31F8BB0", Offset = "0x31F8BB0", VA = "0x31F8BB0")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x31FA68C", Offset = "0x31FA68C", VA = "0x31FA68C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x31FAB30", Offset = "0x31FAB30", VA = "0x31FAB30", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000706")]
			[Address(RVA = "0x31F6564", Offset = "0x31F6564", VA = "0x31F6564")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x31DCB38", Offset = "0x31DCB38", VA = "0x31DCB38")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000708")]
			[Address(RVA = "0x31F711C", Offset = "0x31F711C", VA = "0x31F711C")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x31FAD70", Offset = "0x31FAD70", VA = "0x31FAD70")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600070A")]
			[Address(RVA = "0x31F8604", Offset = "0x31F8604", VA = "0x31F8604")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x31F7F34", Offset = "0x31F7F34", VA = "0x31F7F34")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x31E2F0C", Offset = "0x31E2F0C", VA = "0x31E2F0C")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E6")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000711")]
			Pelvis,
			[Token(Token = "0x4000712")]
			Chest,
			[Token(Token = "0x4000713")]
			Head,
			[Token(Token = "0x4000714")]
			LeftHand,
			[Token(Token = "0x4000715")]
			RightHand,
			[Token(Token = "0x4000716")]
			LeftFoot,
			[Token(Token = "0x4000717")]
			RightFoot,
			[Token(Token = "0x4000718")]
			LeftHeel,
			[Token(Token = "0x4000719")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000E7")]
		public enum RotationOffset
		{
			[Token(Token = "0x400071B")]
			Pelvis,
			[Token(Token = "0x400071C")]
			Chest,
			[Token(Token = "0x400071D")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000E8")]
		public class VirtualBone
		{
			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public Vector3 readPosition;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51BEC")]
			public Quaternion readRotation;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float length;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6F16")]
			public float sqrMag;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public Vector3 axis;

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x31D7564", Offset = "0x31D7564", VA = "0x31D7564")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600070E")]
			[Address(RVA = "0x31D7608", Offset = "0x31D7608", VA = "0x31D7608")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x31FB6D8", Offset = "0x31FB6D8", VA = "0x31FB6D8")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x31E97A0", Offset = "0x31E97A0", VA = "0x31E97A0")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x31EA4CC", Offset = "0x31EA4CC", VA = "0x31EA4CC")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x31FBCC0", Offset = "0x31FBCC0", VA = "0x31FBCC0")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x31E6764", Offset = "0x31E6764", VA = "0x31E6764")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000714")]
			[Address(RVA = "0x31FC1D0", Offset = "0x31FC1D0", VA = "0x31FC1D0")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x31E7B30", Offset = "0x31E7B30", VA = "0x31E7B30")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x31FC370", Offset = "0x31FC370", VA = "0x31FC370")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000717")]
			[Address(RVA = "0x31F9998", Offset = "0x31F9998", VA = "0x31F9998")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000718")]
			[Address(RVA = "0x31FC800", Offset = "0x31FC800", VA = "0x31FC800")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000719")]
			[Address(RVA = "0x31FCA0C", Offset = "0x31FCA0C", VA = "0x31FCA0C")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform[] solverTransforms;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool hasChest;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool hasNeck;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6DF9")]
		private bool hasShoulders;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private bool hasToes;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51AEC")]
		private bool hasLegs;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3[] readPositions;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion[] readRotations;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E01")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51AF4")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 rootV;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 rootVelocity;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E09")]
		private int supportLegIndex;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private int lastLOD;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51AFC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBF2C8", Offset = "0xBBF2C8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBF2C8", Offset = "0xBBF2C8")]
		public int LOD;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBF364", Offset = "0xBBF364")]
		public bool plantFeet;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBF3C8", Offset = "0xBBF3C8")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBF404", Offset = "0xBBF404")]
		public Spine spine;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E11")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBF468", Offset = "0xBBF468")]
		public Arm leftArm;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBF4CC", Offset = "0xBBF4CC")]
		public Arm rightArm;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51B04")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBF530", Offset = "0xBBF530")]
		public Leg leftLeg;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBF594", Offset = "0xBBF594")]
		public Leg rightLeg;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBF5F8", Offset = "0xBBF5F8")]
		public Locomotion locomotion;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Leg[] legs;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E19")]
		private Arm[] arms;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Vector3 headPosition;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51B0C")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 lastOffset;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 debugPos1;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E21")]
		private Vector3 debugPos2;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Vector3 debugPos3;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51B14")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000049")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x31E2B74", Offset = "0x31E2B74", VA = "0x31E2B74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCD558", Offset = "0xBCD558")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x31E2BA4", Offset = "0x31E2BA4", VA = "0x31E2BA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCD594", Offset = "0xBCD594")]
			private set
			{
			}
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x31CB18C", Offset = "0x31CB18C", VA = "0x31CB18C")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x31CBC50", Offset = "0x31CBC50", VA = "0x31CBC50")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x31CB984", Offset = "0x31CB984", VA = "0x31CB984")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x31CD2E0", Offset = "0x31CD2E0", VA = "0x31CD2E0")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x31CDD18", Offset = "0x31CDD18", VA = "0x31CDD18")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x31CDE40", Offset = "0x31CDE40", VA = "0x31CDE40")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x31CE218", Offset = "0x31CE218", VA = "0x31CE218")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x31CF4F0", Offset = "0x31CF4F0", VA = "0x31CF4F0")]
		public void Reset()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x31D0FE0", Offset = "0x31D0FE0", VA = "0x31D0FE0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x31D12C8", Offset = "0x31D12C8", VA = "0x31D12C8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x31D1858", Offset = "0x31D1858", VA = "0x31D1858", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x31D195C", Offset = "0x31D195C", VA = "0x31D195C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x31D1A64", Offset = "0x31D1A64", VA = "0x31D1A64", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x31D1FAC", Offset = "0x31D1FAC", VA = "0x31D1FAC")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x31CC3E8", Offset = "0x31CC3E8", VA = "0x31CC3E8")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x31CC7D0", Offset = "0x31CC7D0", VA = "0x31CC7D0")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x31CD124", Offset = "0x31CD124", VA = "0x31CD124")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x31CF864", Offset = "0x31CF864", VA = "0x31CF864")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x31D2618", Offset = "0x31D2618", VA = "0x31D2618", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x31D270C", Offset = "0x31D270C", VA = "0x31D270C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x31D6944", Offset = "0x31D6944", VA = "0x31D6944")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x31CFB04", Offset = "0x31CFB04", VA = "0x31CFB04")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x31D351C", Offset = "0x31D351C", VA = "0x31D351C")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x31D7484", Offset = "0x31D7484", VA = "0x31D7484")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x31D74F0", Offset = "0x31D74F0", VA = "0x31D74F0")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x31D661C", Offset = "0x31D661C", VA = "0x31D661C")]
		private void Write()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x31E1BC8", Offset = "0x31E1BC8", VA = "0x31E1BC8")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x31E2BDC", Offset = "0x31E2BDC", VA = "0x31E2BDC")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51BF4")]
		public IK ik;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBF65C", Offset = "0xBBF65C")]
		public Transform parent;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBF6C0", Offset = "0xBBF6C0")]
		public Transform child;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBF724", Offset = "0xBBF724")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBF724", Offset = "0xBBF724")]
		public float weight;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F1E")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBF7C0", Offset = "0xBBF7C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBF7C0", Offset = "0xBBF7C0")]
		public float parentChildCrossfade;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBF85C", Offset = "0xBBF85C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBBF85C", Offset = "0xBBF85C")]
		public float twistAngleOffset;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51BFC")]
		private Vector3 twistAxis;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 axis;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x268944C", Offset = "0x268944C", VA = "0x268944C")]
		public void Relax()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x2689D80", Offset = "0x2689D80", VA = "0x2689D80")]
		private void Start()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x268A764", Offset = "0x268A764", VA = "0x268A764")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x268A888", Offset = "0x268A888", VA = "0x268A888")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x268A9AC", Offset = "0x268A9AC", VA = "0x268A9AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x268AB9C", Offset = "0x268AB9C", VA = "0x268AB9C")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class InteractionEffector
	{
		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F26")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBF8FC", Offset = "0xBBF8FC")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBF938", Offset = "0xBBF938")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51C04")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBF974", Offset = "0xBBF974")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Poser poser;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IKEffector effector;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float timer;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F2E")]
		private float length;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private float weight;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51C0C")]
		private float fadeInSpeed;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float defaultPositionWeight;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float defaultRotationWeight;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float defaultPull;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F36")]
		private float defaultReach;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private float defaultPush;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4CD9C")]
		private float defaultPushParent;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float resetTimer;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool positionWeightUsed;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F3D")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private bool pullUsed;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51C14")]
		private bool reachUsed;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool pushUsed;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool pushParentUsed;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F45")]
		private bool pickedUp;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private bool defaults;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51C1C")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F4D")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51C24")]
		private Transform target;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<bool> triggered;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool started;

		[Token(Token = "0x1700004A")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x31FDF38", Offset = "0x31FDF38", VA = "0x31FDF38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCD5D0", Offset = "0xBCD5D0")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x31FDF68", Offset = "0x31FDF68", VA = "0x31FDF68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCD60C", Offset = "0xBCD60C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public bool isPaused
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x31FDFA0", Offset = "0x31FDFA0", VA = "0x31FDFA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCD648", Offset = "0xBCD648")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x31FDFE4", Offset = "0x31FDFE4", VA = "0x31FDFE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCD684", Offset = "0xBCD684")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x31FE030", Offset = "0x31FE030", VA = "0x31FE030")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCD6C0", Offset = "0xBCD6C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x31FE060", Offset = "0x31FE060", VA = "0x31FE060")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCD6FC", Offset = "0xBCD6FC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public bool inInteraction
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x31FE098", Offset = "0x31FE098", VA = "0x31FE098")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		public float progress
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x3203E68", Offset = "0x3203E68", VA = "0x3203E68")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x31FE1B8", Offset = "0x31FE1B8", VA = "0x31FE1B8")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x31FE28C", Offset = "0x31FE28C", VA = "0x31FE28C")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x31FE408", Offset = "0x31FE408", VA = "0x31FE408")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x31FE8D0", Offset = "0x31FE8D0", VA = "0x31FE8D0")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x31FF640", Offset = "0x31FF640", VA = "0x31FF640")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x31FF96C", Offset = "0x31FF96C", VA = "0x31FF96C")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x31FFAA0", Offset = "0x31FFAA0", VA = "0x31FFAA0")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x3200C0C", Offset = "0x3200C0C", VA = "0x3200C0C")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x32026F8", Offset = "0x32026F8", VA = "0x32026F8")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x3202F64", Offset = "0x3202F64", VA = "0x3202F64")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x3203A58", Offset = "0x3203A58", VA = "0x3203A58")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x3204074", Offset = "0x3204074", VA = "0x3204074")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F55")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBF9B0", Offset = "0xBBF9B0")]
		public LookAtIK ik;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBFA14", Offset = "0xBBFA14")]
		public float lerpSpeed;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51C2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBFA78", Offset = "0xBBFA78")]
		public float weightSpeed;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float stopLookTime;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F5D")]
		private float weight;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x3204664", Offset = "0x3204664", VA = "0x3204664")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x3204A14", Offset = "0x3204A14", VA = "0x3204A14")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x3204BA4", Offset = "0x3204BA4", VA = "0x3204BA4")]
		public void Update()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x32051BC", Offset = "0x32051BC", VA = "0x32051BC")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x32054E4", Offset = "0x32054E4", VA = "0x32054E4")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x3205730", Offset = "0x3205730", VA = "0x3205730")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBB9FB8", Offset = "0xBB9FB8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBB9FB8", Offset = "0xBB9FB8")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E9")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC782C", Offset = "0xBC782C")]
			public float time;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6F6D")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC7890", Offset = "0xBC7890")]
			public bool pause;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC78F4", Offset = "0xBC78F4")]
			public bool pickUp;

			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51C44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC7958", Offset = "0xBC7958")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC79BC", Offset = "0xBC79BC")]
			public Message[] messages;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC7A20", Offset = "0xBC7A20")]
			public UnityEvent unityEvent;

			[Token(Token = "0x600071A")]
			[Address(RVA = "0x2666064", Offset = "0x2666064", VA = "0x2666064")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x2666478", Offset = "0x2666478", VA = "0x2666478")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EA")]
		public class Message
		{
			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC7A84", Offset = "0xBC7A84")]
			public string function;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6F75")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC7AE8", Offset = "0xBC7AE8")]
			public GameObject recipient;

			[Token(Token = "0x400072D")]
			private const string empty = "";

			[Token(Token = "0x600071C")]
			[Address(RVA = "0x2666270", Offset = "0x2666270", VA = "0x2666270")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0x26664A8", Offset = "0x26664A8", VA = "0x26664A8")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EB")]
		public class AnimatorEvent
		{
			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51C4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC7B4C", Offset = "0xBC7B4C")]
			public Animator animator;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC7BB0", Offset = "0xBC7BB0")]
			public Animation animation;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC7C14", Offset = "0xBC7C14")]
			public string animationState;

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC7C78", Offset = "0xBC7C78")]
			public float crossfadeTime;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6F7D")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC7CDC", Offset = "0xBC7CDC")]
			public int layer;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC7D40", Offset = "0xBC7D40")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000734")]
			private const string empty = "";

			[Token(Token = "0x600071E")]
			[Address(RVA = "0x3207F2C", Offset = "0x3207F2C", VA = "0x3207F2C")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x600071F")]
			[Address(RVA = "0x3208170", Offset = "0x3208170", VA = "0x3208170")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000720")]
			[Address(RVA = "0x32082EC", Offset = "0x32082EC", VA = "0x32082EC")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000721")]
			[Address(RVA = "0x32084A0", Offset = "0x32084A0", VA = "0x32084A0")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EC")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x2000123")]
			public enum Type
			{
				[Token(Token = "0x4000854")]
				PositionWeight,
				[Token(Token = "0x4000855")]
				RotationWeight,
				[Token(Token = "0x4000856")]
				PositionOffsetX,
				[Token(Token = "0x4000857")]
				PositionOffsetY,
				[Token(Token = "0x4000858")]
				PositionOffsetZ,
				[Token(Token = "0x4000859")]
				Pull,
				[Token(Token = "0x400085A")]
				Reach,
				[Token(Token = "0x400085B")]
				RotateBoneWeight,
				[Token(Token = "0x400085C")]
				Push,
				[Token(Token = "0x400085D")]
				PushParent,
				[Token(Token = "0x400085E")]
				PoserWeight,
				[Token(Token = "0x400085F")]
				BendGoalWeight
			}

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC7DA4", Offset = "0xBC7DA4")]
			public Type type;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC7E08", Offset = "0xBC7E08")]
			public AnimationCurve curve;

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x266654C", Offset = "0x266654C", VA = "0x266654C")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000723")]
			[Address(RVA = "0x26665F0", Offset = "0x26665F0", VA = "0x26665F0")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000ED")]
		public class Multiplier
		{
			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6F93")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC7E6C", Offset = "0xBC7E6C")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC7ED0", Offset = "0xBC7ED0")]
			public float multiplier;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4CDA4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC7F34", Offset = "0xBC7F34")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000724")]
			[Address(RVA = "0x26664D8", Offset = "0x26664D8", VA = "0x26664D8")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x26665AC", Offset = "0x26665AC", VA = "0x26665AC")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51C34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBFB18", Offset = "0xBBFB18")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBFB7C", Offset = "0xBBFB7C")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBFBE0", Offset = "0xBBFBE0")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F65")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51C3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBFC44", Offset = "0xBBFC44")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBFC80", Offset = "0xBBFC80")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private InteractionTarget[] targets;

		[Token(Token = "0x1700004F")]
		public float length
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x3205BAC", Offset = "0x3205BAC", VA = "0x3205BAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCDA58", Offset = "0xBCDA58")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x3205BDC", Offset = "0x3205BDC", VA = "0x3205BDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCDA94", Offset = "0xBCDA94")]
			private set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x3205C14", Offset = "0x3205C14", VA = "0x3205C14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCDAD0", Offset = "0xBCDAD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x3205C44", Offset = "0x3205C44", VA = "0x3205C44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCDB0C", Offset = "0xBCDB0C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x3206174", Offset = "0x3206174", VA = "0x3206174")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x3203F28", Offset = "0x3203F28", VA = "0x3203F28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x320578C", Offset = "0x320578C", VA = "0x320578C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCD738", Offset = "0xBCD738")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x3205810", Offset = "0x3205810", VA = "0x3205810")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCD79C", Offset = "0xBCD79C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x3205894", Offset = "0x3205894", VA = "0x3205894")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCD800", Offset = "0xBCD800")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x3205918", Offset = "0x3205918", VA = "0x3205918")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCD864", Offset = "0xBCD864")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x320599C", Offset = "0x320599C", VA = "0x320599C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCD8C8", Offset = "0xBCD8C8")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x3205A20", Offset = "0x3205A20", VA = "0x3205A20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCD92C", Offset = "0xBCD92C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x3205AA4", Offset = "0x3205AA4", VA = "0x3205AA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCD990", Offset = "0xBCD990")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x3205B28", Offset = "0x3205B28", VA = "0x3205B28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCD9F4", Offset = "0xBCD9F4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x3205C7C", Offset = "0x3205C7C", VA = "0x3205C7C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x32062C0", Offset = "0x32062C0", VA = "0x32062C0")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x32009D8", Offset = "0x32009D8", VA = "0x32009D8")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x3206698", Offset = "0x3206698", VA = "0x3206698")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x3200690", Offset = "0x3200690", VA = "0x3200690")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x3200998", Offset = "0x3200998", VA = "0x3200998")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x3201CA4", Offset = "0x3201CA4", VA = "0x3201CA4")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x3203494", Offset = "0x3203494", VA = "0x3203494")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x3207D44", Offset = "0x3207D44", VA = "0x3207D44")]
		private void Start()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x3206844", Offset = "0x3206844", VA = "0x3206844")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x32066C8", Offset = "0x32066C8", VA = "0x32066C8")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x3207C2C", Offset = "0x3207C2C", VA = "0x3207C2C")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x3207D74", Offset = "0x3207D74", VA = "0x3207D74")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x3207E8C", Offset = "0x3207E8C", VA = "0x3207E8C")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBBA064", Offset = "0xBBA064")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBBA064", Offset = "0xBBA064")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000EE")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000EF")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBFCBC", Offset = "0xBBFCBC")]
		public string targetTag;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBFD20", Offset = "0xBBFD20")]
		public float fadeInTime;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBFD84", Offset = "0xBBFD84")]
		public float speed;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F9A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBFDE8", Offset = "0xBBFDE8")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xBBFE4C", Offset = "0xBBFE4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBFE4C", Offset = "0xBBFE4C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBBFE4C", Offset = "0xBBFE4C")]
		public Collider characterCollider;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51C64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBFF40", Offset = "0xBBFF40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xBBFF40", Offset = "0xBBFF40")]
		public Transform FPSCamera;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBBFFEC", Offset = "0xBBFFEC")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC0050", Offset = "0xBC0050")]
		public float camRaycastDistance;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC00B4", Offset = "0xBC00B4")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6FA2")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51C6C")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6FAA")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51C74")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xBC00F0", Offset = "0xBC00F0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC00F0", Offset = "0xBC00F0")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC019C", Offset = "0xBC019C")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6FB2")]
		private bool initiated;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Collider lastCollider;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51C7C")]
		private Collider c;

		[Token(Token = "0x17000053")]
		public bool inInteraction
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x2666A40", Offset = "0x2666A40", VA = "0x2666A40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000054")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x266B6EC", Offset = "0x266B6EC", VA = "0x266B6EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x266B71C", Offset = "0x266B71C", VA = "0x266B71C")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x266B754", Offset = "0x266B754", VA = "0x266B754")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCDE68", Offset = "0xBCDE68")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x266B784", Offset = "0x266B784", VA = "0x266B784")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCDEA4", Offset = "0xBCDEA4")]
			private set
			{
			}
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x2666620", Offset = "0x2666620", VA = "0x2666620")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCDB48", Offset = "0xBCDB48")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x26666A4", Offset = "0x26666A4", VA = "0x26666A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCDBAC", Offset = "0xBCDBAC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x2666728", Offset = "0x2666728", VA = "0x2666728")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCDC10", Offset = "0xBCDC10")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x26667AC", Offset = "0x26667AC", VA = "0x26667AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCDC74", Offset = "0xBCDC74")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x2666830", Offset = "0x2666830", VA = "0x2666830")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCDCD8", Offset = "0xBCDCD8")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x26668B4", Offset = "0x26668B4", VA = "0x26668B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCDD3C", Offset = "0xBCDD3C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x2666938", Offset = "0x2666938", VA = "0x2666938")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCDDA0", Offset = "0xBCDDA0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x26669BC", Offset = "0x26669BC", VA = "0x26669BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCDE04", Offset = "0xBCDE04")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x2666E60", Offset = "0x2666E60", VA = "0x2666E60")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x26670EC", Offset = "0x26670EC", VA = "0x26670EC")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x2667340", Offset = "0x2667340", VA = "0x2667340")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x2667514", Offset = "0x2667514", VA = "0x2667514")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x26677E4", Offset = "0x26677E4", VA = "0x26677E4")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x2667B10", Offset = "0x2667B10", VA = "0x2667B10")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x2667CE8", Offset = "0x2667CE8", VA = "0x2667CE8")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x2667EC0", Offset = "0x2667EC0", VA = "0x2667EC0")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x2668098", Offset = "0x2668098", VA = "0x2668098")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x26681B4", Offset = "0x26681B4", VA = "0x26681B4")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x26682D0", Offset = "0x26682D0", VA = "0x26682D0")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x26683B8", Offset = "0x26683B8", VA = "0x26683B8")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x266856C", Offset = "0x266856C", VA = "0x266856C")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x2668718", Offset = "0x2668718", VA = "0x2668718")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x266893C", Offset = "0x266893C", VA = "0x266893C")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x26690F8", Offset = "0x26690F8", VA = "0x26690F8")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x2669688", Offset = "0x2669688", VA = "0x2669688")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x2669E04", Offset = "0x2669E04", VA = "0x2669E04")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x266A488", Offset = "0x266A488", VA = "0x266A488")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x266A560", Offset = "0x266A560", VA = "0x266A560")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x266A6D4", Offset = "0x266A6D4", VA = "0x266A6D4")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x266A938", Offset = "0x266A938", VA = "0x266A938")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x266ACB4", Offset = "0x266ACB4", VA = "0x266ACB4")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x266B4A8", Offset = "0x266B4A8", VA = "0x266B4A8")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x266A02C", Offset = "0x266A02C", VA = "0x266A02C")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x266B7BC", Offset = "0x266B7BC", VA = "0x266B7BC")]
		public void Start()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x266C738", Offset = "0x266C738", VA = "0x266C738")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x266C78C", Offset = "0x266C78C", VA = "0x266C78C")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x266C7E0", Offset = "0x266C7E0", VA = "0x266C7E0")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x266C834", Offset = "0x266C834", VA = "0x266C834")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x266C91C", Offset = "0x266C91C", VA = "0x266C91C")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x266CBB4", Offset = "0x266CBB4", VA = "0x266CBB4")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x266CDF4", Offset = "0x266CDF4", VA = "0x266CDF4")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x266D630", Offset = "0x266D630", VA = "0x266D630")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x266D860", Offset = "0x266D860", VA = "0x266D860")]
		public void Update()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x266DD2C", Offset = "0x266DD2C", VA = "0x266DD2C")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x266C030", Offset = "0x266C030", VA = "0x266C030")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x266DF48", Offset = "0x266DF48", VA = "0x266DF48")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x266E230", Offset = "0x266E230", VA = "0x266E230")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x266E378", Offset = "0x266E378", VA = "0x266E378")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x266E570", Offset = "0x266E570", VA = "0x266E570")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x266E5B8", Offset = "0x266E5B8", VA = "0x266E5B8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x2666C18", Offset = "0x2666C18", VA = "0x2666C18")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x2668E5C", Offset = "0x2668E5C", VA = "0x2668E5C")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x266EB38", Offset = "0x266EB38", VA = "0x266EB38")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBBA110", Offset = "0xBBA110")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBBA110", Offset = "0xBBA110")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F0")]
		public class Multiplier
		{
			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC7F98", Offset = "0xBC7F98")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51C8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC7FFC", Offset = "0xBC7FFC")]
			public float multiplier;

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x2670C44", Offset = "0x2670C44", VA = "0x2670C44")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC0200", Offset = "0xBC0200")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC0264", Offset = "0xBC0264")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC02C8", Offset = "0xBC02C8")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6FBA")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC032C", Offset = "0xBC032C")]
		public Transform pivot;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC0390", Offset = "0xBC0390")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51C84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC03F4", Offset = "0xBC03F4")]
		public float twistWeight;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC0458", Offset = "0xBC0458")]
		public float swingWeight;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC04BC", Offset = "0xBC04BC")]
		public bool rotateOnce;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6FC2")]
		private Transform lastPivot;

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x266F958", Offset = "0x266F958", VA = "0x266F958")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCDEE0", Offset = "0xBCDEE0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x266F9DC", Offset = "0x266F9DC", VA = "0x266F9DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCDF44", Offset = "0xBCDF44")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x266FA60", Offset = "0x266FA60", VA = "0x266FA60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCDFA8", Offset = "0xBCDFA8")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x266FAE4", Offset = "0x266FAE4", VA = "0x266FAE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE00C", Offset = "0xBCE00C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x266FB68", Offset = "0x266FB68", VA = "0x266FB68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE070", Offset = "0xBCE070")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x266FBEC", Offset = "0x266FBEC", VA = "0x266FBEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE0D4", Offset = "0xBCE0D4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x266FC70", Offset = "0x266FC70", VA = "0x266FC70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE138", Offset = "0xBCE138")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x266FCF4", Offset = "0x266FCF4", VA = "0x266FCF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE19C", Offset = "0xBCE19C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x266FD78", Offset = "0x266FD78", VA = "0x266FD78")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x266FEDC", Offset = "0x266FEDC", VA = "0x266FEDC")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x2670008", Offset = "0x2670008", VA = "0x2670008")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x2670B3C", Offset = "0x2670B3C", VA = "0x2670B3C")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBBA1BC", Offset = "0xBBA1BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBBA1BC", Offset = "0xBBA1BC")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F1")]
		public class CharacterPosition
		{
			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC8060", Offset = "0xBC8060")]
			public bool use;

			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC80C4", Offset = "0xBC80C4")]
			public Vector2 offset;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6FCA")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC8128", Offset = "0xBC8128")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC8128", Offset = "0xBC8128")]
			public float angleOffset;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC81C8", Offset = "0xBC81C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC81C8", Offset = "0xBC81C8")]
			public float maxAngle;

			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51C94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC8264", Offset = "0xBC8264")]
			public float radius;

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC82C8", Offset = "0xBC82C8")]
			public bool orbit;

			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC832C", Offset = "0xBC832C")]
			public bool fixYAxis;

			[Token(Token = "0x170000A9")]
			public Vector3 offset3D
			{
				[Token(Token = "0x600072F")]
				[Address(RVA = "0x2671E58", Offset = "0x2671E58", VA = "0x2671E58")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AA")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000730")]
				[Address(RVA = "0x2671F08", Offset = "0x2671F08", VA = "0x2671F08")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000731")]
			[Address(RVA = "0x26720B8", Offset = "0x26720B8", VA = "0x26720B8")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000732")]
			[Address(RVA = "0x26731D8", Offset = "0x26731D8", VA = "0x26731D8")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F2")]
		public class CameraPosition
		{
			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC8390", Offset = "0xBC8390")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6FD2")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC83F4", Offset = "0xBC83F4")]
			public Vector3 direction;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC8458", Offset = "0xBC8458")]
			public float maxDistance;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51C9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC84BC", Offset = "0xBC84BC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC84BC", Offset = "0xBC84BC")]
			public float maxAngle;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC8558", Offset = "0xBC8558")]
			public bool fixYAxis;

			[Token(Token = "0x6000733")]
			[Address(RVA = "0x267129C", Offset = "0x267129C", VA = "0x267129C")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0x26716A8", Offset = "0x26716A8", VA = "0x26716A8")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000735")]
			[Address(RVA = "0x2671D28", Offset = "0x2671D28", VA = "0x2671D28")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F3")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x2000124")]
			public class Interaction
			{
				[Token(Token = "0x4000860")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCA810", Offset = "0xBCA810")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000861")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCA874", Offset = "0xBCA874")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x60007DF")]
				[Address(RVA = "0x2673278", Offset = "0x2673278", VA = "0x2673278")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6FDA")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC8674", Offset = "0xBC8674")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC86D8", Offset = "0xBC86D8")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51CA4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC873C", Offset = "0xBC873C")]
			public Interaction[] interactions;

			[Token(Token = "0x6000736")]
			[Address(RVA = "0x2670F1C", Offset = "0x2670F1C", VA = "0x2670F1C")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x2673234", Offset = "0x2673234", VA = "0x2673234")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC0520", Offset = "0xBC0520")]
		public Range[] ranges;

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x2670C74", Offset = "0x2670C74", VA = "0x2670C74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE200", Offset = "0xBCE200")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x2670CF8", Offset = "0x2670CF8", VA = "0x2670CF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE264", Offset = "0xBCE264")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x2670D7C", Offset = "0x2670D7C", VA = "0x2670D7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE2C8", Offset = "0xBCE2C8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x2670E00", Offset = "0x2670E00", VA = "0x2670E00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE32C", Offset = "0xBCE32C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x2670E84", Offset = "0x2670E84", VA = "0x2670E84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE390", Offset = "0xBCE390")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x2670F08", Offset = "0x2670F08", VA = "0x2670F08")]
		private void Start()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x266D26C", Offset = "0x266D26C", VA = "0x266D26C")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x26711FC", Offset = "0x26711FC", VA = "0x26711FC")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000F4")]
		public class Map
		{
			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6FE2")]
			public Transform bone;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public Transform target;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51CAC")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000738")]
			[Address(RVA = "0x2FEFCDC", Offset = "0x2FEFCDC", VA = "0x2FEFCDC")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000739")]
			[Address(RVA = "0x2FF05EC", Offset = "0x2FF05EC", VA = "0x2FF05EC")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600073A")]
			[Address(RVA = "0x2FF0528", Offset = "0x2FF0528", VA = "0x2FF0528")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0x2FF0140", Offset = "0x2FF0140", VA = "0x2FF0140")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Map[] maps;

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x2FEF6AC", Offset = "0x2FEF6AC", VA = "0x2FEF6AC", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE3F4", Offset = "0xBCE3F4")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x2FEFE30", Offset = "0x2FEFE30", VA = "0x2FEFE30", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x2FEFE60", Offset = "0x2FEFE60", VA = "0x2FEFE60", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x2FF0444", Offset = "0x2FF0444", VA = "0x2FF0444", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x2FEFD4C", Offset = "0x2FEFD4C", VA = "0x2FEFD4C")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x2FEFB74", Offset = "0x2FEFB74", VA = "0x2FEFB74")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x2FF06B0", Offset = "0x2FF06B0", VA = "0x2FF06B0")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Transform[] children;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform _poseRoot;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6FEA")]
		private Transform[] poseChildren;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4CDAC")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x3007AD8", Offset = "0x3007AD8", VA = "0x3007AD8", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x3007C78", Offset = "0x3007C78", VA = "0x3007C78", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x3007F8C", Offset = "0x3007F8C", VA = "0x3007F8C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x3008154", Offset = "0x3008154", VA = "0x3008154", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x3007D18", Offset = "0x3007D18", VA = "0x3007D18")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x30088D4", Offset = "0x30088D4", VA = "0x30088D4")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform poseRoot;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC0584", Offset = "0xBC0584")]
		public float weight;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC05CC", Offset = "0xBC05CC")]
		public float localRotationWeight;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6FF1")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC0614", Offset = "0xBC0614")]
		public float localPositionWeight;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private bool initiated;

		[Token(Token = "0x600044E")]
		public abstract void AutoMapping();

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x2679914", Offset = "0x2679914", VA = "0x2679914")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x6000450")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000451")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000452")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x2679944", Offset = "0x2679944", VA = "0x2679944", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x26799C8", Offset = "0x26799C8", VA = "0x26799C8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x2679A30", Offset = "0x2679A30", VA = "0x2679A30", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x2679A84", Offset = "0x2679A84", VA = "0x2679A84")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBBA268", Offset = "0xBBA268")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000F5")]
		public class Rigidbone
		{
			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7009")]
			public Rigidbody r;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public Transform t;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51CCC")]
			public Collider collider;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Joint joint;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rigidbody c;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool updateAnchor;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7011")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51CD4")]
			public float deltaTime;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 lastPosition;

			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Quaternion lastRotation;

			[Token(Token = "0x600073C")]
			[Address(RVA = "0x267A688", Offset = "0x267A688", VA = "0x267A688")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0x267C440", Offset = "0x267C440", VA = "0x267C440")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x600073E")]
			[Address(RVA = "0x267BF4C", Offset = "0x267BF4C", VA = "0x267BF4C")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000F6")]
		public class Child
		{
			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform t;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7019")]
			public Vector3 localPosition;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public Quaternion localRotation;

			[Token(Token = "0x600073F")]
			[Address(RVA = "0x267A98C", Offset = "0x267A98C", VA = "0x267A98C")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000740")]
			[Address(RVA = "0x267C820", Offset = "0x267C820", VA = "0x267C820")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0x267C75C", Offset = "0x267C75C", VA = "0x267C75C")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000F7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBB014", Offset = "0xBBB014")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51CDC")]
			private int <>1__state;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000AB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000745")]
				[Address(RVA = "0x267D7B0", Offset = "0x267D7B0", VA = "0x267D7B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000747")]
				[Address(RVA = "0x267D880", Offset = "0x267D880", VA = "0x267D880", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000742")]
			[Address(RVA = "0x267AA74", Offset = "0x267AA74", VA = "0x267AA74")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0x267CF48", Offset = "0x267CF48", VA = "0x267CF48", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000744")]
			[Address(RVA = "0x267CF5C", Offset = "0x267CF5C", VA = "0x267CF5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000746")]
			[Address(RVA = "0x267D7E0", Offset = "0x267D7E0", VA = "0x267D7E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51CB4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC065C", Offset = "0xBC065C")]
		public IK ik;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC06C0", Offset = "0xBC06C0")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC0724", Offset = "0xBC0724")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC0788", Offset = "0xBC0788")]
		public float applyVelocity;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6FF9")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC07EC", Offset = "0xBC07EC")]
		public float applyAngularVelocity;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Animator animator;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51CBC")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Child[] children;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool enableRagdollFlag;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7001")]
		private IK[] allIKComponents;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private bool[] fixTransforms;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51CC4")]
		private float ragdollWeight;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float ragdollWeightV;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool fixedFrame;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000056")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x2679B4C", Offset = "0x2679B4C", VA = "0x2679B4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		private bool ikUsed
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x267B480", Offset = "0x267B480", VA = "0x267B480")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x2679AD8", Offset = "0x2679AD8", VA = "0x2679AD8")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x2679C80", Offset = "0x2679C80", VA = "0x2679C80")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x2679EC0", Offset = "0x2679EC0", VA = "0x2679EC0")]
		public void Start()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x2679E04", Offset = "0x2679E04", VA = "0x2679E04")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBCE458", Offset = "0xBCE458")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x267AABC", Offset = "0x267AABC", VA = "0x267AABC")]
		private void Update()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x267B150", Offset = "0x267B150", VA = "0x267B150")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x267B2E8", Offset = "0x267B2E8", VA = "0x267B2E8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x267B884", Offset = "0x267B884", VA = "0x267B884")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x267B408", Offset = "0x267B408", VA = "0x267B408")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x267B7FC", Offset = "0x267B7FC", VA = "0x267B7FC")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x267B9D4", Offset = "0x267B9D4", VA = "0x267B9D4")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x267B8DC", Offset = "0x267B8DC", VA = "0x267B8DC")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x2679D0C", Offset = "0x2679D0C", VA = "0x2679D0C")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x267B1E0", Offset = "0x267B1E0", VA = "0x267B1E0")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x267CBD0", Offset = "0x267CBD0", VA = "0x267CBD0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x267CDC0", Offset = "0x267CDC0", VA = "0x267CDC0")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 axis;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7021")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC088C", Offset = "0xBC088C")]
		private bool <defaultLocalRotationOverride>k__BackingField;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51CE4")]
		private bool initiated;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool applicationQuit;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000058")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x2681450", Offset = "0x2681450", VA = "0x2681450")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000059")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x2681510", Offset = "0x2681510", VA = "0x2681510")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700005A")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x2681638", Offset = "0x2681638", VA = "0x2681638")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCE508", Offset = "0xBCE508")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x268167C", Offset = "0x268167C", VA = "0x268167C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCE544", Offset = "0xBCE544")]
			private set
			{
			}
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x2680B90", Offset = "0x2680B90", VA = "0x2680B90")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x2680C24", Offset = "0x2680C24", VA = "0x2680C24")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x2680D88", Offset = "0x2680D88", VA = "0x2680D88")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x26812E0", Offset = "0x26812E0", VA = "0x26812E0")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x26813C8", Offset = "0x26813C8", VA = "0x26813C8")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000472")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x268111C", Offset = "0x268111C", VA = "0x268111C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x26816C8", Offset = "0x26816C8", VA = "0x26816C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x26816F8", Offset = "0x26816F8", VA = "0x26816F8")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x268175C", Offset = "0x268175C", VA = "0x268175C")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x2681940", Offset = "0x2681940", VA = "0x2681940")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x2681E38", Offset = "0x2681E38", VA = "0x2681E38")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x2681F98", Offset = "0x2681F98", VA = "0x2681F98")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBBA318", Offset = "0xBBA318")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBBA318", Offset = "0xBBA318")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC08C8", Offset = "0xBC08C8")]
		public float limit;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7029")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC0910", Offset = "0xBC0910")]
		public float twistLimit;

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x268207C", Offset = "0x268207C", VA = "0x268207C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE580", Offset = "0xBCE580")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x2682100", Offset = "0x2682100", VA = "0x2682100")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE5E4", Offset = "0xBCE5E4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x2682184", Offset = "0x2682184", VA = "0x2682184")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE648", Offset = "0xBCE648")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x2682208", Offset = "0x2682208", VA = "0x2682208")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE6AC", Offset = "0xBCE6AC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x268228C", Offset = "0x268228C", VA = "0x268228C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x26823CC", Offset = "0x26823CC", VA = "0x26823CC")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x2682930", Offset = "0x2682930", VA = "0x2682930")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBBA3C4", Offset = "0xBBA3C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBBA3C4", Offset = "0xBBA3C4")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public bool useLimits;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51CEC")]
		public float min;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float max;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion lastRotation;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7031")]
		private float lastAngle;

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x268298C", Offset = "0x268298C", VA = "0x268298C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE710", Offset = "0xBCE710")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x2682A10", Offset = "0x2682A10", VA = "0x2682A10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE774", Offset = "0xBCE774")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x2682A94", Offset = "0x2682A94", VA = "0x2682A94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE7D8", Offset = "0xBCE7D8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x2682B18", Offset = "0x2682B18", VA = "0x2682B18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE83C", Offset = "0xBCE83C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x2682B9C", Offset = "0x2682B9C", VA = "0x2682B9C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x2682C50", Offset = "0x2682C50", VA = "0x2682C50")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x268337C", Offset = "0x268337C", VA = "0x268337C")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBBA470", Offset = "0xBBA470")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBBA470", Offset = "0xBBA470")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000F8")]
		public class ReachCone
		{
			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7039")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public float volume;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51CFC")]
			public Vector3 S;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 B;

			[Token(Token = "0x170000AD")]
			public Vector3 o
			{
				[Token(Token = "0x6000748")]
				[Address(RVA = "0x2687554", Offset = "0x2687554", VA = "0x2687554")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AE")]
			public Vector3 a
			{
				[Token(Token = "0x6000749")]
				[Address(RVA = "0x26875B4", Offset = "0x26875B4", VA = "0x26875B4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AF")]
			public Vector3 b
			{
				[Token(Token = "0x600074A")]
				[Address(RVA = "0x2687614", Offset = "0x2687614", VA = "0x2687614")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B0")]
			public Vector3 c
			{
				[Token(Token = "0x600074B")]
				[Address(RVA = "0x2687674", Offset = "0x2687674", VA = "0x2687674")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B1")]
			public bool isValid
			{
				[Token(Token = "0x600074D")]
				[Address(RVA = "0x2685430", Offset = "0x2685430", VA = "0x2685430")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600074C")]
			[Address(RVA = "0x2686228", Offset = "0x2686228", VA = "0x2686228")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x600074E")]
			[Address(RVA = "0x2686504", Offset = "0x2686504", VA = "0x2686504")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F9")]
		public class LimitPoint
		{
			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 point;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float tangentWeight;

			[Token(Token = "0x600074F")]
			[Address(RVA = "0x26854AC", Offset = "0x26854AC", VA = "0x26854AC")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC0994", Offset = "0xBC0994")]
		public float twistLimit;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51CF4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC09DC", Offset = "0xBC09DC")]
		public int smoothIterations;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x268348C", Offset = "0x268348C", VA = "0x268348C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE8A0", Offset = "0xBCE8A0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x2683510", Offset = "0x2683510", VA = "0x2683510")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE904", Offset = "0xBCE904")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x2683594", Offset = "0x2683594", VA = "0x2683594")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE968", Offset = "0xBCE968")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x2683618", Offset = "0x2683618", VA = "0x2683618")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCE9CC", Offset = "0xBCE9CC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x268369C", Offset = "0x268369C", VA = "0x268369C")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x2683FB4", Offset = "0x2683FB4", VA = "0x2683FB4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x2684134", Offset = "0x2684134", VA = "0x2684134")]
		private void Start()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x2684C78", Offset = "0x2684C78", VA = "0x2684C78")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x2683788", Offset = "0x2683788", VA = "0x2683788")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x2685598", Offset = "0x2685598", VA = "0x2685598")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x2686870", Offset = "0x2686870", VA = "0x2686870")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x26869A0", Offset = "0x26869A0", VA = "0x26869A0")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x2686C6C", Offset = "0x2686C6C", VA = "0x2686C6C")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x2684554", Offset = "0x2684554", VA = "0x2684554")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x2686FFC", Offset = "0x2686FFC", VA = "0x2686FFC")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x268749C", Offset = "0x268749C", VA = "0x268749C")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xBBA51C", Offset = "0xBBA51C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xBBA51C", Offset = "0xBBA51C")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7041")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC0B38", Offset = "0xBC0B38")]
		public float twistLimit;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x26876D4", Offset = "0x26876D4", VA = "0x26876D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCEA30", Offset = "0xBCEA30")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x2687758", Offset = "0x2687758", VA = "0x2687758")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCEA94", Offset = "0xBCEA94")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x26877DC", Offset = "0x26877DC", VA = "0x26877DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCEAF8", Offset = "0xBCEAF8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x2687860", Offset = "0x2687860", VA = "0x2687860")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xBCEB5C", Offset = "0xBCEB5C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x26878E4", Offset = "0x26878E4", VA = "0x26878E4")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x268793C", Offset = "0x268793C", VA = "0x268793C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x2687A7C", Offset = "0x2687A7C", VA = "0x2687A7C")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x268820C", Offset = "0x268820C", VA = "0x268820C")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000FA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBB050", Offset = "0xBBB050")]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7068")]
			private object <>2__current;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public AimController <>4__this;

			[Token(Token = "0x170000B2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000753")]
				[Address(RVA = "0x2110728", Offset = "0x2110728", VA = "0x2110728", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000755")]
				[Address(RVA = "0x21107F8", Offset = "0x21107F8", VA = "0x21107F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000750")]
			[Address(RVA = "0x2110168", Offset = "0x2110168", VA = "0x2110168")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000751")]
			[Address(RVA = "0x2110368", Offset = "0x2110368", VA = "0x2110368", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000752")]
			[Address(RVA = "0x211037C", Offset = "0x211037C", VA = "0x211037C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000754")]
			[Address(RVA = "0x2110758", Offset = "0x2110758", VA = "0x2110758", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4CDB4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC0BDC", Offset = "0xBC0BDC")]
		public AimIK ik;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC0C40", Offset = "0xBC0C40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC0C40", Offset = "0xBC0C40")]
		public float weight;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xBC0CDC", Offset = "0xBC0CDC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC0CDC", Offset = "0xBC0CDC")]
		public Transform target;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC0D88", Offset = "0xBC0D88")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7048")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC0DEC", Offset = "0xBC0DEC")]
		public float weightSmoothTime;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xBC0E50", Offset = "0xBC0E50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC0E50", Offset = "0xBC0E50")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51D04")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC0EFC", Offset = "0xBC0EFC")]
		public float maxRadiansDelta;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC0F60", Offset = "0xBC0F60")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC0FC4", Offset = "0xBC0FC4")]
		public float slerpSpeed;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1028", Offset = "0xBC1028")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7050")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC108C", Offset = "0xBC108C")]
		public float minDistance;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC10F0", Offset = "0xBC10F0")]
		public Vector3 offset;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51D0C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xBC1154", Offset = "0xBC1154")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1154", Offset = "0xBC1154")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC1154", Offset = "0xBC1154")]
		public float maxRootAngle;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1238", Offset = "0xBC1238")]
		public bool turnToTarget;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC129C", Offset = "0xBC129C")]
		public float turnToTargetTime;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xBC1300", Offset = "0xBC1300")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1300", Offset = "0xBC1300")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7058")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC13AC", Offset = "0xBC13AC")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Transform lastTarget;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51D14")]
		private float switchWeight;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float switchWeightV;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float weightV;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 lastPosition;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7060")]
		private Vector3 dir;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51D1C")]
		private bool turningToTarget;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float turnToTargetMlpV;

		[Token(Token = "0x1700005B")]
		private Vector3 pivot
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x210E064", Offset = "0x210E064", VA = "0x210E064")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x210DE64", Offset = "0x210DE64", VA = "0x210DE64")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x210E29C", Offset = "0x210E29C", VA = "0x210E29C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x210F610", Offset = "0x210F610", VA = "0x210F610")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x210F940", Offset = "0x210F940", VA = "0x210F940")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x21100AC", Offset = "0x21100AC", VA = "0x21100AC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBCEBC0", Offset = "0xBCEBC0")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x21101B0", Offset = "0x21101B0", VA = "0x21101B0")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000FB")]
		public class Pose
		{
			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool visualize;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7070")]
			public Vector3 direction;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public float yaw;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51D2C")]
			public float pitch;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float angleBuffer;

			[Token(Token = "0x6000756")]
			[Address(RVA = "0x2110B94", Offset = "0x2110B94", VA = "0x2110B94")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000757")]
			[Address(RVA = "0x2111310", Offset = "0x2111310", VA = "0x2111310")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000758")]
			[Address(RVA = "0x2111348", Offset = "0x2111348", VA = "0x2111348")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51D24")]
		public float angleBuffer;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Pose[] poses;

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x2104468", Offset = "0x2104468", VA = "0x2104468")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x210466C", Offset = "0x210466C", VA = "0x210466C")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x2111258", Offset = "0x2111258", VA = "0x2111258")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000FC")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000125")]
			public class EffectorLink
			{
				[Token(Token = "0x4000862")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xD51D3C")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCA8D8", Offset = "0xBCA8D8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000863")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCA93C", Offset = "0xBCA93C")]
				public float weight;

				[Token(Token = "0x60007E0")]
				[Address(RVA = "0x2112338", Offset = "0x2112338", VA = "0x2112338")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC87A0", Offset = "0xBC87A0")]
			public Transform transform;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7078")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC8804", Offset = "0xBC8804")]
			public Transform relativeTo;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC8868", Offset = "0xBC8868")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51D34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC88CC", Offset = "0xBC88CC")]
			public float verticalWeight;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC8930", Offset = "0xBC8930")]
			public float horizontalWeight;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC8994", Offset = "0xBC8994")]
			public float speed;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7080")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private bool firstUpdate;

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x21115F8", Offset = "0x21115F8", VA = "0x21115F8")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x211217C", Offset = "0x211217C", VA = "0x211217C")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x21122CC", Offset = "0x21122CC", VA = "0x21122CC")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1410", Offset = "0xBC1410")]
		public Body[] bodies;

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x21113BC", Offset = "0x21113BC", VA = "0x21113BC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x211214C", Offset = "0x211214C", VA = "0x211214C")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1474", Offset = "0xBC1474")]
		public float tiltSpeed;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC14D8", Offset = "0xBC14D8")]
		public float tiltSensitivity;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7088")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC153C", Offset = "0xBC153C")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC15A0", Offset = "0xBC15A0")]
		public OffsetPose poseRight;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51D44")]
		private float tiltAngle;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 lastForward;

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x2115394", Offset = "0x2115394", VA = "0x2115394", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x2115418", Offset = "0x2115418", VA = "0x2115418", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x211591C", Offset = "0x211591C", VA = "0x211591C")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IK ik;

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x2116EAC", Offset = "0x2116EAC", VA = "0x2116EAC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x2116FAC", Offset = "0x2116FAC", VA = "0x2116FAC")]
		private void Update()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x211718C", Offset = "0x211718C", VA = "0x211718C")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000FD")]
		public abstract class HitPoint
		{
			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC89F8", Offset = "0xBC89F8")]
			public string name;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51D4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC8A5C", Offset = "0xBC8A5C")]
			public Collider collider;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC8AC0", Offset = "0xBC8AC0")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC8B40", Offset = "0xBC8B40")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC8B7C", Offset = "0xBC8B7C")]
			private float <timer>k__BackingField;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7098")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC8BB8", Offset = "0xBC8BB8")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC8BF4", Offset = "0xBC8BF4")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4CDBC")]
			private float length;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float lastTime;

			[Token(Token = "0x170000B4")]
			public bool inProgress
			{
				[Token(Token = "0x600075C")]
				[Address(RVA = "0x3008B2C", Offset = "0x3008B2C", VA = "0x3008B2C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000B5")]
			protected float crossFader
			{
				[Token(Token = "0x600075D")]
				[Address(RVA = "0x30098D0", Offset = "0x30098D0", VA = "0x30098D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD01A8", Offset = "0xBD01A8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600075E")]
				[Address(RVA = "0x3009900", Offset = "0x3009900", VA = "0x3009900")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD01E4", Offset = "0xBD01E4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B6")]
			protected float timer
			{
				[Token(Token = "0x600075F")]
				[Address(RVA = "0x3009938", Offset = "0x3009938", VA = "0x3009938")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD0220", Offset = "0xBD0220")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000760")]
				[Address(RVA = "0x3009968", Offset = "0x3009968", VA = "0x3009968")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD025C", Offset = "0xBD025C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B7")]
			protected Vector3 force
			{
				[Token(Token = "0x6000761")]
				[Address(RVA = "0x30099A0", Offset = "0x30099A0", VA = "0x30099A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD0298", Offset = "0xBD0298")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000762")]
				[Address(RVA = "0x30099E0", Offset = "0x30099E0", VA = "0x30099E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD02D4", Offset = "0xBD02D4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B8")]
			protected Vector3 point
			{
				[Token(Token = "0x6000763")]
				[Address(RVA = "0x3009A40", Offset = "0x3009A40", VA = "0x3009A40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD0310", Offset = "0xBD0310")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000764")]
				[Address(RVA = "0x3009A80", Offset = "0x3009A80", VA = "0x3009A80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD034C", Offset = "0xBD034C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000765")]
			[Address(RVA = "0x3009608", Offset = "0x3009608", VA = "0x3009608")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0x3008DE0", Offset = "0x3008DE0", VA = "0x3008DE0")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000767")]
			protected abstract float GetLength();

			[Token(Token = "0x6000768")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000769")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x600076A")]
			[Address(RVA = "0x3009AE0", Offset = "0x3009AE0", VA = "0x3009AE0")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FE")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000126")]
			public class EffectorLink
			{
				[Token(Token = "0x4000864")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xD51D54")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCA9A0", Offset = "0xBCA9A0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000865")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCAA04", Offset = "0xBCAA04")]
				public float weight;

				[Token(Token = "0x4000866")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private Vector3 lastValue;

				[Token(Token = "0x4000867")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private Vector3 current;

				[Token(Token = "0x60007E1")]
				[Address(RVA = "0x300AF34", Offset = "0x300AF34", VA = "0x300AF34")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60007E2")]
				[Address(RVA = "0x300AA80", Offset = "0x300AA80", VA = "0x300AA80")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007E3")]
				[Address(RVA = "0x300B1E4", Offset = "0x300B1E4", VA = "0x300B1E4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC8C30", Offset = "0xBC8C30")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x709F")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC8C94", Offset = "0xBC8C94")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC8CF8", Offset = "0xBC8CF8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x600076B")]
			[Address(RVA = "0x300A694", Offset = "0x300A694", VA = "0x300A694", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600076C")]
			[Address(RVA = "0x300A988", Offset = "0x300A988", VA = "0x300A988", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600076D")]
			[Address(RVA = "0x300AAD8", Offset = "0x300AAD8", VA = "0x300AAD8", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600076E")]
			[Address(RVA = "0x300B1B4", Offset = "0x300B1B4", VA = "0x300B1B4")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FF")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000127")]
			public class BoneLink
			{
				[Token(Token = "0x4000868")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCAA68", Offset = "0xBCAA68")]
				public Transform bone;

				[Token(Token = "0x4000869")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCAACC", Offset = "0xBCAACC")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBCAACC", Offset = "0xBCAACC")]
				public float weight;

				[Token(Token = "0x400086A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private Quaternion lastValue;

				[Token(Token = "0x400086B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70AF")]
				private Quaternion current;

				[Token(Token = "0x60007E4")]
				[Address(RVA = "0x300A28C", Offset = "0x300A28C", VA = "0x300A28C")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60007E5")]
				[Address(RVA = "0x3009D2C", Offset = "0x3009D2C", VA = "0x3009D2C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007E6")]
				[Address(RVA = "0x300A578", Offset = "0x300A578", VA = "0x300A578")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70A7")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC8D5C", Offset = "0xBC8D5C")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC8DC0", Offset = "0xBC8DC0")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51D5C")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600076F")]
			[Address(RVA = "0x3009B28", Offset = "0x3009B28", VA = "0x3009B28", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000770")]
			[Address(RVA = "0x3009C34", Offset = "0x3009C34", VA = "0x3009C34", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0x3009D84", Offset = "0x3009D84", VA = "0x3009D84", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0x300A548", Offset = "0x300A548", VA = "0x300A548")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1604", Offset = "0xBC1604")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7090")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1668", Offset = "0xBC1668")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700005C")]
		public bool inProgress
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x3008904", Offset = "0x3008904", VA = "0x3008904")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x3008BB8", Offset = "0x3008BB8", VA = "0x3008BB8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x3009108", Offset = "0x3009108", VA = "0x3009108")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x30098A0", Offset = "0x30098A0", VA = "0x30098A0")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x2000100")]
		public abstract class Offset
		{
			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC8E24", Offset = "0xBC8E24")]
			public string name;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC8E88", Offset = "0xBC8E88")]
			public Collider collider;

			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70B7")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC8EEC", Offset = "0xBC8EEC")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC8F6C", Offset = "0xBC8F6C")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51D6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC8FA8", Offset = "0xBC8FA8")]
			private float <timer>k__BackingField;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC8FE4", Offset = "0xBC8FE4")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC9020", Offset = "0xBC9020")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float length;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70BF")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private float lastTime;

			[Token(Token = "0x170000B9")]
			protected float crossFader
			{
				[Token(Token = "0x6000773")]
				[Address(RVA = "0x300BF64", Offset = "0x300BF64", VA = "0x300BF64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD0388", Offset = "0xBD0388")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000774")]
				[Address(RVA = "0x300BF94", Offset = "0x300BF94", VA = "0x300BF94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD03C4", Offset = "0xBD03C4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BA")]
			protected float timer
			{
				[Token(Token = "0x6000775")]
				[Address(RVA = "0x300BFCC", Offset = "0x300BFCC", VA = "0x300BFCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD0400", Offset = "0xBD0400")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000776")]
				[Address(RVA = "0x300BFFC", Offset = "0x300BFFC", VA = "0x300BFFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD043C", Offset = "0xBD043C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BB")]
			protected Vector3 force
			{
				[Token(Token = "0x6000777")]
				[Address(RVA = "0x300C034", Offset = "0x300C034", VA = "0x300C034")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD0478", Offset = "0xBD0478")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000778")]
				[Address(RVA = "0x300C074", Offset = "0x300C074", VA = "0x300C074")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD04B4", Offset = "0xBD04B4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BC")]
			protected Vector3 point
			{
				[Token(Token = "0x6000779")]
				[Address(RVA = "0x300C0D4", Offset = "0x300C0D4", VA = "0x300C0D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD04F0", Offset = "0xBD04F0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600077A")]
				[Address(RVA = "0x300C114", Offset = "0x300C114", VA = "0x300C114")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD052C", Offset = "0xBD052C")]
				private set
				{
				}
			}

			[Token(Token = "0x600077B")]
			[Address(RVA = "0x300BC8C", Offset = "0x300BC8C", VA = "0x300BC8C")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x600077C")]
			[Address(RVA = "0x300B434", Offset = "0x300B434", VA = "0x300B434")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600077D")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x600077E")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600077F")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000780")]
			[Address(RVA = "0x300C174", Offset = "0x300C174", VA = "0x300C174")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000101")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000128")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x400086C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCAB68", Offset = "0xBCAB68")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x400086D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70C7")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCABCC", Offset = "0xBCABCC")]
				public float weight;

				[Token(Token = "0x400086E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
				private Vector3 lastValue;

				[Token(Token = "0x400086F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xD51D7C")]
				private Vector3 current;

				[Token(Token = "0x60007E7")]
				[Address(RVA = "0x300CBDC", Offset = "0x300CBDC", VA = "0x300CBDC")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60007E8")]
				[Address(RVA = "0x300C6D4", Offset = "0x300C6D4", VA = "0x300C6D4")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007E9")]
				[Address(RVA = "0x300CE30", Offset = "0x300CE30", VA = "0x300CE30")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51D74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC905C", Offset = "0xBC905C")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC90C0", Offset = "0xBC90C0")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9124", Offset = "0xBC9124")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000781")]
			[Address(RVA = "0x300C1BC", Offset = "0x300C1BC", VA = "0x300C1BC", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000782")]
			[Address(RVA = "0x300C5DC", Offset = "0x300C5DC", VA = "0x300C5DC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000783")]
			[Address(RVA = "0x300C72C", Offset = "0x300C72C", VA = "0x300C72C", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000784")]
			[Address(RVA = "0x300CDEC", Offset = "0x300CDEC", VA = "0x300CDEC")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000102")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000129")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000870")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70CF")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCAC30", Offset = "0xBCAC30")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000871")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCAC94", Offset = "0xBCAC94")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBCAC94", Offset = "0xBCAC94")]
				public float weight;

				[Token(Token = "0x4000872")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xD51D84")]
				private Quaternion lastValue;

				[Token(Token = "0x4000873")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private Quaternion current;

				[Token(Token = "0x60007EA")]
				[Address(RVA = "0x300D774", Offset = "0x300D774", VA = "0x300D774")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60007EB")]
				[Address(RVA = "0x300D0F8", Offset = "0x300D0F8", VA = "0x300D0F8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007EC")]
				[Address(RVA = "0x300D9F8", Offset = "0x300D9F8", VA = "0x300D9F8")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9188", Offset = "0xBC9188")]
			public int curveIndex;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC91EC", Offset = "0xBC91EC")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000785")]
			[Address(RVA = "0x300CE60", Offset = "0x300CE60", VA = "0x300CE60", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000786")]
			[Address(RVA = "0x300D000", Offset = "0x300D000", VA = "0x300D000", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000787")]
			[Address(RVA = "0x300D150", Offset = "0x300D150", VA = "0x300D150", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000788")]
			[Address(RVA = "0x300D9C8", Offset = "0x300D9C8", VA = "0x300D9C8")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51D64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC16CC", Offset = "0xBC16CC")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1730", Offset = "0xBC1730")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x300B214", Offset = "0x300B214", VA = "0x300B214", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x300B76C", Offset = "0x300B76C", VA = "0x300B76C")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x300BF34", Offset = "0x300BF34", VA = "0x300BF34")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000103")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x200012A")]
			public class EffectorLink
			{
				[Token(Token = "0x4000874")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCAD30", Offset = "0xBCAD30")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000875")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70E7")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCAD94", Offset = "0xBCAD94")]
				public float weight;

				[Token(Token = "0x60007ED")]
				[Address(RVA = "0x31FDF08", Offset = "0x31FDF08", VA = "0x31FDF08")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70D7")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9250", Offset = "0xBC9250")]
			public Transform transform;

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC92B4", Offset = "0xBC92B4")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51D8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9318", Offset = "0xBC9318")]
			public float speed;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC937C", Offset = "0xBC937C")]
			public float acceleration;

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC93E0", Offset = "0xBC93E0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC93E0", Offset = "0xBC93E0")]
			public float matchVelocity;

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC947C", Offset = "0xBC947C")]
			public float gravity;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70DF")]
			private Vector3 delta;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private Vector3 lazyPoint;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51D94")]
			private Vector3 direction;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 lastPosition;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool firstUpdate;

			[Token(Token = "0x6000789")]
			[Address(RVA = "0x31FD14C", Offset = "0x31FD14C", VA = "0x31FD14C")]
			public void Reset()
			{
			}

			[Token(Token = "0x600078A")]
			[Address(RVA = "0x31FD4B0", Offset = "0x31FD4B0", VA = "0x31FD4B0")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600078B")]
			[Address(RVA = "0x31FDE94", Offset = "0x31FDE94", VA = "0x31FDE94")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1794", Offset = "0xBC1794")]
		public Body[] bodies;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC17F8", Offset = "0xBC17F8")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x31FD03C", Offset = "0x31FD03C", VA = "0x31FD03C")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x31FD354", Offset = "0x31FD354", VA = "0x31FD354", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x31FDE64", Offset = "0x31FDE64", VA = "0x31FDE64")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public LookAtIK ik;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51D9C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xBC185C", Offset = "0xBC185C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC185C", Offset = "0xBC185C")]
		public Transform target;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC1908", Offset = "0xBC1908")]
		public float weight;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 offset;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1950", Offset = "0xBC1950")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70EF")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC19B4", Offset = "0xBC19B4")]
		public float weightSmoothTime;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xBC1A18", Offset = "0xBC1A18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1A18", Offset = "0xBC1A18")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4CDC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1AC4", Offset = "0xBC1AC4")]
		public float maxRadiansDelta;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1B28", Offset = "0xBC1B28")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1B8C", Offset = "0xBC1B8C")]
		public float slerpSpeed;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1BF0", Offset = "0xBC1BF0")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70F6")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1C54", Offset = "0xBC1C54")]
		public float minDistance;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xBC1CB8", Offset = "0xBC1CB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1CB8", Offset = "0xBC1CB8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC1CB8", Offset = "0xBC1CB8")]
		public float maxRootAngle;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51DA4")]
		private Transform lastTarget;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float switchWeight;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float switchWeightV;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float weightV;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70FE")]
		private Vector3 lastPosition;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Vector3 dir;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51DAC")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x1700005D")]
		private Vector3 pivot
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x2673A40", Offset = "0x2673A40", VA = "0x2673A40")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x2673878", Offset = "0x2673878", VA = "0x2673878")]
		private void Start()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x2673C78", Offset = "0x2673C78", VA = "0x2673C78")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x2674E0C", Offset = "0x2674E0C", VA = "0x2674E0C")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x267513C", Offset = "0x267513C", VA = "0x267513C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x26757B4", Offset = "0x26757B4", VA = "0x26757B4")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000104")]
		public class OffsetLimits
		{
			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7106")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC94E0", Offset = "0xBC94E0")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9544", Offset = "0xBC9544")]
			public float spring;

			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51DB4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC95A8", Offset = "0xBC95A8")]
			public bool x;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC960C", Offset = "0xBC960C")]
			public bool y;

			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9670", Offset = "0xBC9670")]
			public bool z;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC96D4", Offset = "0xBC96D4")]
			public float minX;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x710E")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9738", Offset = "0xBC9738")]
			public float maxX;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC979C", Offset = "0xBC979C")]
			public float minY;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51DBC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9800", Offset = "0xBC9800")]
			public float maxY;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9864", Offset = "0xBC9864")]
			public float minZ;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC98C8", Offset = "0xBC98C8")]
			public float maxZ;

			[Token(Token = "0x600078C")]
			[Address(RVA = "0x26761D0", Offset = "0x26761D0", VA = "0x26761D0")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600078D")]
			[Address(RVA = "0x2676EE0", Offset = "0x2676EE0", VA = "0x2676EE0")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0x2677030", Offset = "0x2677030", VA = "0x2677030")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600078F")]
			[Address(RVA = "0x2677294", Offset = "0x2677294", VA = "0x2677294")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBB08C", Offset = "0xBBB08C")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7116")]
			private object <>2__current;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000BD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000793")]
				[Address(RVA = "0x2676DE0", Offset = "0x2676DE0", VA = "0x2676DE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000795")]
				[Address(RVA = "0x2676EB0", Offset = "0x2676EB0", VA = "0x2676EB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x2675D48", Offset = "0x2675D48", VA = "0x2675D48")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000791")]
			[Address(RVA = "0x2676A5C", Offset = "0x2676A5C", VA = "0x2676A5C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x2676A70", Offset = "0x2676A70", VA = "0x2676A70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x2676E10", Offset = "0x2676E10", VA = "0x2676E10", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1D9C", Offset = "0xBC1D9C")]
		public float weight;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1E00", Offset = "0xBC1E00")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected float lastTime;

		[Token(Token = "0x1700005E")]
		protected float deltaTime
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x2675BFC", Offset = "0x2675BFC", VA = "0x2675BFC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004C3")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x2675C44", Offset = "0x2675C44", VA = "0x2675C44", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x2675C8C", Offset = "0x2675C8C", VA = "0x2675C8C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBCEC70", Offset = "0xBCEC70")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x2675D90", Offset = "0x2675D90", VA = "0x2675D90")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x2676028", Offset = "0x2676028", VA = "0x2676028")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x2676838", Offset = "0x2676838", VA = "0x2676838", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x2676A18", Offset = "0x2676A18", VA = "0x2676A18")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBB0C8", Offset = "0xBBB0C8")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x711E")]
			private object <>2__current;

			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000BF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000799")]
				[Address(RVA = "0x2677C98", Offset = "0x2677C98", VA = "0x2677C98", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600079B")]
				[Address(RVA = "0x2677D68", Offset = "0x2677D68", VA = "0x2677D68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0x2677410", Offset = "0x2677410", VA = "0x2677410")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0x2677914", Offset = "0x2677914", VA = "0x2677914", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000798")]
			[Address(RVA = "0x2677928", Offset = "0x2677928", VA = "0x2677928", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x2677CC8", Offset = "0x2677CC8", VA = "0x2677CC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51DC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1E64", Offset = "0xBC1E64")]
		public float weight;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1EC8", Offset = "0xBC1EC8")]
		public VRIK ik;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float lastTime;

		[Token(Token = "0x1700005F")]
		protected float deltaTime
		{
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x26772C4", Offset = "0x26772C4", VA = "0x26772C4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004CB")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x267730C", Offset = "0x267730C", VA = "0x267730C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x2677354", Offset = "0x2677354", VA = "0x2677354")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBCED20", Offset = "0xBCED20")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x2677458", Offset = "0x2677458", VA = "0x2677458")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x26776F0", Offset = "0x26776F0", VA = "0x26776F0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x26778D0", Offset = "0x26778D0", VA = "0x26778D0")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000107")]
		public class EffectorLink
		{
			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 offset;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 pin;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7126")]
			public Vector3 pinWeight;

			[Token(Token = "0x600079C")]
			[Address(RVA = "0x2677EE4", Offset = "0x2677EE4", VA = "0x2677EE4")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x600079D")]
			[Address(RVA = "0x2678934", Offset = "0x2678934", VA = "0x2678934")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51DCC")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x2677D98", Offset = "0x2677D98", VA = "0x2677D98")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x267866C", Offset = "0x267866C", VA = "0x267866C")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x2678894", Offset = "0x2678894", VA = "0x2678894")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000108")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x200012B")]
			public class EffectorLink
			{
				[Token(Token = "0x4000876")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x7136")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCADF8", Offset = "0xBCADF8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000877")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCAE5C", Offset = "0xBCAE5C")]
				public float weight;

				[Token(Token = "0x60007EE")]
				[Address(RVA = "0x26798E4", Offset = "0x26798E4", VA = "0x26798E4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51DD4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC992C", Offset = "0xBC992C")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9990", Offset = "0xBC9990")]
			public Transform raycastTo;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC99F4", Offset = "0xBC99F4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC99F4", Offset = "0xBC99F4")]
			public float raycastRadius;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9A90", Offset = "0xBC9A90")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x712E")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9AF4", Offset = "0xBC9AF4")]
			public float smoothTimeIn;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9B58", Offset = "0xBC9B58")]
			public float smoothTimeOut;

			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51DDC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9BBC", Offset = "0xBC9BBC")]
			public LayerMask layers;

			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 offset;

			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 offsetTarget;

			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 offsetV;

			[Token(Token = "0x600079E")]
			[Address(RVA = "0x2678A90", Offset = "0x2678A90", VA = "0x2678A90")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600079F")]
			[Address(RVA = "0x2678F94", Offset = "0x2678F94", VA = "0x2678F94")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x2679308", Offset = "0x2679308", VA = "0x2679308")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x2679880", Offset = "0x2679880", VA = "0x2679880")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1F2C", Offset = "0xBC1F2C")]
		public Avoider[] avoiders;

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x2678964", Offset = "0x2678964", VA = "0x2678964", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x2678F64", Offset = "0x2678F64", VA = "0x2678F64")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000109")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x200012C")]
			public class EffectorLink
			{
				[Token(Token = "0x4000878")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCAEC0", Offset = "0xBCAEC0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000879")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xD51E04")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCAF24", Offset = "0xBCAF24")]
				public float weight;

				[Token(Token = "0x60007EF")]
				[Address(RVA = "0x2680B60", Offset = "0x2680B60", VA = "0x2680B60")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9C20", Offset = "0xBC9C20")]
			public Vector3 offset;

			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51DFC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9C84", Offset = "0xBC9C84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC9C84", Offset = "0xBC9C84")]
			public float additivity;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9D20", Offset = "0xBC9D20")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9D84", Offset = "0xBC9D84")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x715D")]
			private Vector3 lastOffset;

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x267DFFC", Offset = "0x267DFFC", VA = "0x267DFFC")]
			public void Start()
			{
			}

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x267FB9C", Offset = "0x267FB9C", VA = "0x267FB9C")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x2680B00", Offset = "0x2680B00", VA = "0x2680B00")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010A")]
		public enum Handedness
		{
			[Token(Token = "0x40007CB")]
			Right,
			[Token(Token = "0x40007CC")]
			Left
		}

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51DE4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1F90", Offset = "0xBC1F90")]
		public AimIK aimIK;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC1FF4", Offset = "0xBC1FF4")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC2058", Offset = "0xBC2058")]
		public Handedness handedness;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC20BC", Offset = "0xBC20BC")]
		public bool twoHanded;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x713E")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC2120", Offset = "0xBC2120")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC2184", Offset = "0xBC2184")]
		public float magnitudeRandom;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51DEC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC21E8", Offset = "0xBC21E8")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC224C", Offset = "0xBC224C")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC22B0", Offset = "0xBC22B0")]
		public float blendTime;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xBC2314", Offset = "0xBC2314")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC2314", Offset = "0xBC2314")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7146")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private float magnitudeMlp;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4CDCC")]
		private float endTime;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion handRotation;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x714D")]
		private float length;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private bool initiated;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51DF4")]
		private float blendWeight;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float w;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool handRotationsSet;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7155")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x17000060")]
		public bool isFinished
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x267D8B0", Offset = "0x267D8B0", VA = "0x267D8B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000061")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x26801D0", Offset = "0x26801D0", VA = "0x26801D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x268029C", Offset = "0x268029C", VA = "0x268029C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		private Transform primaryHand
		{
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x2680138", Offset = "0x2680138", VA = "0x2680138")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x2680184", Offset = "0x2680184", VA = "0x2680184")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x267D938", Offset = "0x267D938", VA = "0x267D938")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x267DBB0", Offset = "0x267DBB0", VA = "0x267DBB0")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x267E180", Offset = "0x267E180", VA = "0x267E180", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x2680368", Offset = "0x2680368", VA = "0x2680368")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x2680590", Offset = "0x2680590", VA = "0x2680590")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x2680634", Offset = "0x2680634", VA = "0x2680634", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x26809A0", Offset = "0x26809A0", VA = "0x26809A0")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7165")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC23E0", Offset = "0xBC23E0")]
		public float weight;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC2444", Offset = "0xBC2444")]
		public float offset;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51E0C")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool skip;

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x2688250", Offset = "0x2688250", VA = "0x2688250")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x26883AC", Offset = "0x26883AC", VA = "0x26883AC")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x2688614", Offset = "0x2688614", VA = "0x2688614")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x2688E8C", Offset = "0x2688E8C", VA = "0x2688E8C")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x2688F24", Offset = "0x2688F24", VA = "0x2688F24")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x2689104", Offset = "0x2689104", VA = "0x2689104")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x200010B")]
		public class Settings
		{
			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9DE8", Offset = "0xBC9DE8")]
			public float scaleMlp;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9E4C", Offset = "0xBC9E4C")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x716D")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9EB0", Offset = "0xBC9EB0")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9F14", Offset = "0xBC9F14")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51E14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9F78", Offset = "0xBC9F78")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC9FDC", Offset = "0xBC9FDC")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCA040", Offset = "0xBCA040")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCA0A4", Offset = "0xBCA0A4")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7175")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCA108", Offset = "0xBCA108")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xBCA16C", Offset = "0xBCA16C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCA16C", Offset = "0xBCA16C")]
			public Vector3 headOffset;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51E1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCA1FC", Offset = "0xBCA1FC")]
			public Vector3 handOffset;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCA260", Offset = "0xBCA260")]
			public float footForwardOffset;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCA2C4", Offset = "0xBCA2C4")]
			public float footInwardOffset;

			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCA328", Offset = "0xBCA328")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBCA328", Offset = "0xBCA328")]
			public float footHeadingOffset;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x717D")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBCA3C8", Offset = "0xBCA3C8")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBCA410", Offset = "0xBCA410")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x26979B8", Offset = "0x26979B8", VA = "0x26979B8")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010C")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x200012D")]
			public class Target
			{
				[Token(Token = "0x400087A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xD51E34")]
				public bool used;

				[Token(Token = "0x400087B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public Vector3 localPosition;

				[Token(Token = "0x400087C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public Quaternion localRotation;

				[Token(Token = "0x60007F0")]
				[Address(RVA = "0x2694A38", Offset = "0x2694A38", VA = "0x2694A38")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x60007F1")]
				[Address(RVA = "0x2697010", Offset = "0x2697010", VA = "0x2697010")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51E24")]
			public float scale;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Target head;

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Target leftHand;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Target rightHand;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7185")]
			public Target pelvis;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public Target leftFoot;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51E2C")]
			public Target rightFoot;

			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Target leftLegGoal;

			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Target rightLegGoal;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x718D")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x26931C0", Offset = "0x26931C0", VA = "0x26931C0")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x268E2BC", Offset = "0x268E2BC", VA = "0x268E2BC")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x268E624", Offset = "0x268E624", VA = "0x268E624")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x26931F0", Offset = "0x26931F0", VA = "0x26931F0")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x2694BE0", Offset = "0x2694BE0", VA = "0x2694BE0")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x26970FC", Offset = "0x26970FC", VA = "0x26970FC")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Renderer LODRenderer;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7195")]
		public float LODDistance;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public bool allowCulled;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51E3C")]
		private VRIK ik;

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x2697C54", Offset = "0x2697C54", VA = "0x2697C54")]
		private void Start()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x2697CE0", Offset = "0x2697CE0", VA = "0x2697CE0")]
		private void Update()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x2697D4C", Offset = "0x2697D4C", VA = "0x2697D4C")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x2698094", Offset = "0x2698094", VA = "0x2698094")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC24A8", Offset = "0xBC24A8")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform pelvisTarget;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform leftFootTarget;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x719D")]
		private Transform rightFootTarget;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private VRIK ik;

		[Token(Token = "0x17000065")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x26980F0", Offset = "0x26980F0", VA = "0x26980F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCEDD0", Offset = "0xBCEDD0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x2698130", Offset = "0x2698130", VA = "0x2698130")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCEE0C", Offset = "0xBCEE0C")]
			private set
			{
			}
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x2698190", Offset = "0x2698190", VA = "0x2698190")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x26945E0", Offset = "0x26945E0", VA = "0x26945E0")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x269768C", Offset = "0x269768C", VA = "0x269768C")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x26982F8", Offset = "0x26982F8", VA = "0x26982F8")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x2698DAC", Offset = "0x2698DAC", VA = "0x2698DAC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x2698F8C", Offset = "0x2698F8C", VA = "0x2698F8C")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x200007C")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010D")]
		public class Offset
		{
			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public HumanBodyBones bone;

			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x71A4")]
			public Vector3 rotationOffset;

			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private Transform t;

			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x20ED5B0", Offset = "0x20ED5B0", VA = "0x20ED5B0")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x20EDA88", Offset = "0x20EDA88", VA = "0x20EDA88")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4CDD4")]
		public Offset[] offsets;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animator animator;

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x20ED41C", Offset = "0x20ED41C", VA = "0x20ED41C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x20ED4A8", Offset = "0x20ED4A8", VA = "0x20ED4A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x20ED8AC", Offset = "0x20ED8AC", VA = "0x20ED8AC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x20EDA58", Offset = "0x20EDA58", VA = "0x20EDA58")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51E44")]
		public AimIK aimIK;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform pin;

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x2C02F54", Offset = "0x2C02F54", VA = "0x2C02F54")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x2C03084", Offset = "0x2C03084", VA = "0x2C03084")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AimIK ik;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC24E4", Offset = "0xBC24E4")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x2C030B4", Offset = "0x2C030B4", VA = "0x2C030B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x2C032C0", Offset = "0x2C032C0", VA = "0x2C032C0")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71AC")]
		public AimIK aim;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public LimbIK leftArmIK;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51E4C")]
		public Transform leftHand;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform rightHand;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71B4")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2103224", Offset = "0x2103224", VA = "0x2103224")]
		private void Start()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x21032A4", Offset = "0x21032A4", VA = "0x21032A4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x2103824", Offset = "0x2103824", VA = "0x2103824")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51E54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC2548", Offset = "0xBC2548")]
		public AimPoser aimPoser;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC25AC", Offset = "0xBC25AC")]
		public AimIK aim;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC2610", Offset = "0xBC2610")]
		public LookAtIK lookAt;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC2674", Offset = "0xBC2674")]
		public Animator animator;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC26D8", Offset = "0xBC26D8")]
		public float crossfadeTime;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC273C", Offset = "0xBC273C")]
		public float minAimDistance;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51E5C")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x2103854", Offset = "0x2103854", VA = "0x2103854")]
		private void Start()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x21038D4", Offset = "0x21038D4", VA = "0x21038D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x2103BC8", Offset = "0x2103BC8", VA = "0x2103BC8")]
		private void Pose()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x2104090", Offset = "0x2104090", VA = "0x2104090")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x2104810", Offset = "0x2104810", VA = "0x2104810")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x21049E4", Offset = "0x21049E4", VA = "0x21049E4")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AimIK aimIK;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 raycastOffset;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71C4")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public float min;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51E64")]
		public float max;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float lerpSpeed;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private RaycastHit hit;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 offset;

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x210690C", Offset = "0x210690C", VA = "0x210690C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x2106E84", Offset = "0x2106E84", VA = "0x2106E84")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x2107384", Offset = "0x2107384", VA = "0x2107384")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71CC")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xBC27A0", Offset = "0xBC27A0")]
		public Animator animator;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public BipedIK bipedIK;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51E6C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xBC2804", Offset = "0xBC2804")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC2868", Offset = "0xBC2868")]
		public float lookAtWeight;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC28B0", Offset = "0xBC28B0")]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71D4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC28F8", Offset = "0xBC28F8")]
		public float lookAtHeadWeight;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC2940", Offset = "0xBC2940")]
		public float lookAtEyesWeight;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51E74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC2988", Offset = "0xBC2988")]
		public float lookAtClampWeight;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC29D0", Offset = "0xBC29D0")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC2A18", Offset = "0xBC2A18")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xBC2A60", Offset = "0xBC2A60")]
		public Transform footTargetBiped;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71DC")]
		public Transform footTargetAnimator;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC2AC4", Offset = "0xBC2AC4")]
		public float footPositionWeight;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51E7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC2B0C", Offset = "0xBC2B0C")]
		public float footRotationWeight;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xBC2B54", Offset = "0xBC2B54")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC2BB8", Offset = "0xBC2BB8")]
		public float handPositionWeight;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC2C00", Offset = "0xBC2C00")]
		public float handRotationWeight;

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x2C074D8", Offset = "0x2C074D8", VA = "0x2C074D8")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x2C083F4", Offset = "0x2C083F4", VA = "0x2C083F4")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51E84")]
		public float scale;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform body;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float legRotationWeight;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71EC")]
		public float rootPositionSpeed;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public float rootRotationSpeed;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51E8C")]
		public float breatheSpeed;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float breatheMagnitude;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float height;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float minHeight;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71F4")]
		public float raycastHeight;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public float raycastDistance;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4CDDC")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float sine;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private RaycastHit rootHit;

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x20F4AB8", Offset = "0x20F4AB8", VA = "0x20F4AB8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x20F6178", Offset = "0x20F6178", VA = "0x20F6178")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x20F5ADC", Offset = "0x20F5ADC", VA = "0x20F5ADC")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x20F64C4", Offset = "0x20F64C4", VA = "0x20F64C4")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71FB")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Transform cameraTransform;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51E94")]
		public float speed;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float turnSpeed;

		[Token(Token = "0x17000066")]
		public Vector3 inputVector
		{
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x20F65C4", Offset = "0x20F65C4", VA = "0x20F65C4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x20F66C4", Offset = "0x20F66C4", VA = "0x20F66C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x20F6BB0", Offset = "0x20F6BB0", VA = "0x20F6BB0")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x200010E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBB104", Offset = "0xBBB104")]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51EB4")]
			private int <>1__state;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7223")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000C1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007AC")]
				[Address(RVA = "0x20F9C00", Offset = "0x20F9C00", VA = "0x20F9C00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007AE")]
				[Address(RVA = "0x20F9CD0", Offset = "0x20F9CD0", VA = "0x20F9CD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x20F8F90", Offset = "0x20F8F90", VA = "0x20F8F90")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x20F9130", Offset = "0x20F9130", VA = "0x20F9130", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x20F9144", Offset = "0x20F9144", VA = "0x20F9144", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x20F9C30", Offset = "0x20F9C30", VA = "0x20F9C30", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MechSpider mechSpider;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7203")]
		public Vector3 offset;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public float minDelay;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51E9C")]
		public float maxOffset;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float stepSpeed;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float footHeight;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float velocityPrediction;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x720B")]
		public float raycastFocus;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51EA4")]
		public Transform foot;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 footUpAxis;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float footRotationSpeed;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ParticleSystem sand;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7213")]
		private IK ik;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private float stepProgress;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51EAC")]
		private float lastStepTime;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private RaycastHit hit;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x721B")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x17000067")]
		public bool isStepping
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x20F6C0C", Offset = "0x20F6C0C", VA = "0x20F6C0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		public Vector3 position
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x20F6454", Offset = "0x20F6454", VA = "0x20F6454")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x20F6C8C", Offset = "0x20F6C8C", VA = "0x20F6C8C")]
			set
			{
			}
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x20F6D1C", Offset = "0x20F6D1C", VA = "0x20F6D1C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x20F71A4", Offset = "0x20F71A4", VA = "0x20F71A4")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x20F762C", Offset = "0x20F762C", VA = "0x20F762C")]
		private void Start()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x20F7B8C", Offset = "0x20F7B8C", VA = "0x20F7B8C")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x20F849C", Offset = "0x20F849C", VA = "0x20F849C")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x20F89DC", Offset = "0x20F89DC", VA = "0x20F89DC")]
		private void Update()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x20F7A54", Offset = "0x20F7A54", VA = "0x20F7A54")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBCEE48", Offset = "0xBCEE48")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x20F8FD8", Offset = "0x20F8FD8", VA = "0x20F8FD8")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51EBC")]
		private ParticleSystem particles;

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x20F9D00", Offset = "0x20F9D00", VA = "0x20F9D00")]
		private void Start()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x20F9E74", Offset = "0x20F9E74", VA = "0x20F9E74")]
		private void Update()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x20FA2E0", Offset = "0x20FA2E0", VA = "0x20FA2E0")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200010F")]
		public struct Warp
		{
			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9FFF0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCA4B4", Offset = "0xBCA4B4")]
			public int animationLayer;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51EB4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCA518", Offset = "0xBCA518")]
			public string animationState;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCA57C", Offset = "0xBCA57C")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCA5E0", Offset = "0xBCA5E0")]
			public Transform warpFrom;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCA644", Offset = "0xBCA644")]
			public Transform warpTo;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7223")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCA6A8", Offset = "0xBCA6A8")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x2000110")]
		public enum EffectorMode
		{
			[Token(Token = "0x40007F9")]
			PositionOffset,
			[Token(Token = "0x40007FA")]
			Position
		}

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC2C48", Offset = "0xBC2C48")]
		public Animator animator;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC2CAC", Offset = "0xBC2CAC")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xBC2D10", Offset = "0xBC2D10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC2D10", Offset = "0xBC2D10")]
		public Warp[] warps;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x722B")]
		private EffectorMode lastMode;

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x2C033A4", Offset = "0x2C033A4", VA = "0x2C033A4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x2C033EC", Offset = "0x2C033EC", VA = "0x2C033EC")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x2C03924", Offset = "0x2C03924", VA = "0x2C03924", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x2C0433C", Offset = "0x2C0433C", VA = "0x2C0433C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x2C04518", Offset = "0x2C04518", VA = "0x2C04518")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBBA604", Offset = "0xBBA604")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float rotateSpeed;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float blendSpeed;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x723B")]
		public float maxAngle;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public float moveSpeed;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51ED4")]
		public float rootMotionWeight;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Animator animator;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Vector3 moveBlend;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Vector3 moveInput;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7243")]
		protected Vector3 velocity;

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x2C04548", Offset = "0x2C04548", VA = "0x2C04548", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x2C045D4", Offset = "0x2C045D4", VA = "0x2C045D4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x2C04A24", Offset = "0x2C04A24", VA = "0x2C04A24", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x2C050E8", Offset = "0x2C050E8", VA = "0x2C050E8")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBBA6B4", Offset = "0xBBA6B4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBBA6B4", Offset = "0xBBA6B4")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC2DA0", Offset = "0xBC2DA0")]
		public float headLookWeight;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51EDC")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Recoil recoil;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AimIK aim;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x724B")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Vector3 headLookAxis;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4CDE4")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 aimTarget;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x2C05174", Offset = "0x2C05174", VA = "0x2C05174", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x2C05448", Offset = "0x2C05448", VA = "0x2C05448", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x2C055FC", Offset = "0x2C055FC", VA = "0x2C055FC")]
		private void Read()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x2C058EC", Offset = "0x2C058EC", VA = "0x2C058EC")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x2C059A0", Offset = "0x2C059A0", VA = "0x2C059A0")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x2C06804", Offset = "0x2C06804", VA = "0x2C06804")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x2C06390", Offset = "0x2C06390", VA = "0x2C06390")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x2C06F54", Offset = "0x2C06F54", VA = "0x2C06F54")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x2C07134", Offset = "0x2C07134", VA = "0x2C07134")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBBA7B0", Offset = "0xBBA7B0")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7252")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x2C0A5C0", Offset = "0x2C0A5C0", VA = "0x2C0A5C0", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x2C0A660", Offset = "0x2C0A660", VA = "0x2C0A660", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x2C0AB3C", Offset = "0x2C0AB3C", VA = "0x2C0AB3C")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x2C0AEF0", Offset = "0x2C0AEF0", VA = "0x2C0AEF0")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBBA860", Offset = "0xBBA860")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public CameraController cam;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51EE4")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x17000069")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x2C0CB20", Offset = "0x2C0CB20", VA = "0x2C0CB20")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006A")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x2C0CC1C", Offset = "0x2C0CC1C", VA = "0x2C0CC1C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x2C0C558", Offset = "0x2C0C558", VA = "0x2C0C558")]
		private void Start()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x2C0C61C", Offset = "0x2C0C61C", VA = "0x2C0C61C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x2C0CD18", Offset = "0x2C0CD18", VA = "0x2C0CD18")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC2DE8", Offset = "0xBC2DE8")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 bodyOffset;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x725A")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51EEC")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7262")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x20E93F4", Offset = "0x20E93F4", VA = "0x20E93F4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x20EA498", Offset = "0x20EA498", VA = "0x20EA498")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public SimpleLocomotion character;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51EF4")]
		public float forceMlp;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float upForce;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float weightFalloffSpeed;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x726A")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public AnimationCurve scale;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51EFC")]
		private float weight;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 defaultScale;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Rigidbody r;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x20EA4C8", Offset = "0x20EA4C8", VA = "0x20EA4C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x20EA5E0", Offset = "0x20EA5E0", VA = "0x20EA5E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x20EB050", Offset = "0x20EB050", VA = "0x20EB050")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x20EB1E0", Offset = "0x20EB1E0", VA = "0x20EB1E0")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000111")]
		public class Limb
		{
			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51F0C")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x40007FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float mappingWeight;

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x20EB690", Offset = "0x20EB690", VA = "0x20EB690")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x20EB950", Offset = "0x20EB950", VA = "0x20EB950")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7272")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public bool disableAfterStart;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51F04")]
		public Limb leftArm;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Limb rightArm;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Limb leftLeg;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Limb rightLeg;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x727A")]
		public float rootPin;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x20EB2EC", Offset = "0x20EB2EC", VA = "0x20EB2EC")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x20EB7A4", Offset = "0x20EB7A4", VA = "0x20EB7A4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x20EB8DC", Offset = "0x20EB8DC", VA = "0x20EB8DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x20EB90C", Offset = "0x20EB90C", VA = "0x20EB90C")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7282")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public float weight;

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x20EB994", Offset = "0x20EB994", VA = "0x20EB994")]
		private void Start()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x20EBA8C", Offset = "0x20EBA8C", VA = "0x20EBA8C")]
		private void Update()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x20EBC7C", Offset = "0x20EBC7C", VA = "0x20EBC7C")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51F14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC2E30", Offset = "0xBC2E30")]
		public Transform target;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC2E94", Offset = "0xBC2E94")]
		public Transform pin;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC2EF8", Offset = "0xBC2EF8")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC2F5C", Offset = "0xBC2F5C")]
		public AimIK aim;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x728A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC2FC0", Offset = "0xBC2FC0")]
		public float weight;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC3024", Offset = "0xBC3024")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51F1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC3088", Offset = "0xBC3088")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animator animator;

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x20EBCAC", Offset = "0x20EBCAC", VA = "0x20EBCAC")]
		private void Start()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x20EBD38", Offset = "0x20EBD38", VA = "0x20EBD38")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x20EC1B4", Offset = "0x20EC1B4", VA = "0x20EC1B4")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool leftHanded;

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x20EC1E4", Offset = "0x20EC1E4", VA = "0x20EC1E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x20EC314", Offset = "0x20EC314", VA = "0x20EC314")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x20EC468", Offset = "0x20EC468", VA = "0x20EC468")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x20ED20C", Offset = "0x20ED20C", VA = "0x20ED20C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x20ED3EC", Offset = "0x20ED3EC", VA = "0x20ED3EC")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7292")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC30EC", Offset = "0xBC30EC")]
		public float aimWeight;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC3134", Offset = "0xBC3134")]
		public float sightWeight;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51F24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC317C", Offset = "0xBC317C")]
		public float maxAngle;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 aimOffset;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool animatePhysics;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform gun;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x729A")]
		public Transform gunTarget;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51F2C")]
		public AimIK gunAim;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CameraControllerFPS cam;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Recoil recoil;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC31C4", Offset = "0xBC31C4")]
		public float cameraRecoilWeight;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72A2")]
		public Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4CDEC")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool updateFrame;

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x20EDAB8", Offset = "0x20EDAB8", VA = "0x20EDAB8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x20EDE08", Offset = "0x20EDE08", VA = "0x20EDE08")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x20EDE38", Offset = "0x20EDE38", VA = "0x20EDE38")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x20EE5F4", Offset = "0x20EE5F4", VA = "0x20EE5F4")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x20EEAA0", Offset = "0x20EEAA0", VA = "0x20EEAA0")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x20EE020", Offset = "0x20EE020", VA = "0x20EE020")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x20F0378", Offset = "0x20F0378", VA = "0x20F0378")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBBA910", Offset = "0xBBA910")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBBA910", Offset = "0xBBA910")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC320C", Offset = "0xBC320C")]
		public float walkSpeed;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72A9")]
		private float sVel;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Animator animator;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51F34")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x20F03FC", Offset = "0x20F03FC", VA = "0x20F03FC")]
		private void Start()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x20F04B4", Offset = "0x20F04B4", VA = "0x20F04B4")]
		private void Update()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x20F0834", Offset = "0x20F0834", VA = "0x20F0834")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x20F0A28", Offset = "0x20F0A28", VA = "0x20F0A28")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HitReaction hitReaction;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float hitForce;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private string colliderName;

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x20F0D9C", Offset = "0x20F0D9C", VA = "0x20F0D9C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x20F108C", Offset = "0x20F108C", VA = "0x20F108C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x20F11D4", Offset = "0x20F11D4", VA = "0x20F11D4")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72B1")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51F3C")]
		public Transform rightHandTarget;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftHandTarget;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float crossFade;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float speed;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72B9")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x20F1694", Offset = "0x20F1694", VA = "0x20F1694")]
		private void Start()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x20F19CC", Offset = "0x20F19CC", VA = "0x20F19CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x20F21A8", Offset = "0x20F21A8", VA = "0x20F21A8")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51F44")]
		public InteractionSystem character1;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionSystem character2;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionObject handShake;

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x20F21EC", Offset = "0x20F21EC", VA = "0x20F21EC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x20F2334", Offset = "0x20F2334", VA = "0x20F2334")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x20F25C0", Offset = "0x20F25C0", VA = "0x20F25C0")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72C1")]
		public bool interrupt;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public InteractionObject ball;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51F4C")]
		public InteractionObject benchMain;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionObject benchHands;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionObject button;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionObject cigarette;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72C9")]
		public InteractionObject door;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private bool isSitting;

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x20F25F0", Offset = "0x20F25F0", VA = "0x20F25F0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x20F2EE8", Offset = "0x20F2EE8", VA = "0x20F2EE8")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBBAA0C", Offset = "0xBBAA0C")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51F54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC3254", Offset = "0xBC3254")]
		public InteractionObject interactionObject;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC32B8", Offset = "0xBC32B8")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x20F2F18", Offset = "0x20F2F18", VA = "0x20F2F18")]
		private void Awake()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x20F2FA4", Offset = "0x20F2FA4", VA = "0x20F2FA4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x20F3464", Offset = "0x20F3464", VA = "0x20F3464")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000112")]
		public class Partner
		{
			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform mouth;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform mouthTarget;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x72D9")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51F64")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float bodyWeightVertical;

			[Token(Token = "0x4000805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float neckRotationWeight;

			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float headTiltAngle;

			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x72E1")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x4000808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000C3")]
			private Transform neck
			{
				[Token(Token = "0x60007B3")]
				[Address(RVA = "0x20F4924", Offset = "0x20F4924", VA = "0x20F4924")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x20F34FC", Offset = "0x20F34FC", VA = "0x20F34FC")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x20F3638", Offset = "0x20F3638", VA = "0x20F3638")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x20F45A4", Offset = "0x20F45A4", VA = "0x20F45A4")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x20F4A24", Offset = "0x20F4A24", VA = "0x20F4A24")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Partner partner1;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72D1")]
		public Partner partner2;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public float weight;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51F5C")]
		public int iterations;

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x20F3494", Offset = "0x20F3494", VA = "0x20F3494")]
		private void Start()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x20F3554", Offset = "0x20F3554", VA = "0x20F3554")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x20F4560", Offset = "0x20F4560", VA = "0x20F4560")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000113")]
		public enum Mode
		{
			[Token(Token = "0x400080A")]
			Position,
			[Token(Token = "0x400080B")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x2000114")]
		public class Absorber
		{
			[Token(Token = "0x400080C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x72F1")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCA70C", Offset = "0xBCA70C")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBCA770", Offset = "0xBCA770")]
			public float weight;

			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51F7C")]
			private Vector3 position;

			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Quaternion rotation;

			[Token(Token = "0x4000810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IKEffector e;

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x20FA5C4", Offset = "0x20FA5C4", VA = "0x20FA5C4")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x20FAB48", Offset = "0x20FAB48", VA = "0x20FAB48")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x20FABF4", Offset = "0x20FABF4", VA = "0x20FABF4")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x20FAFD0", Offset = "0x20FAFD0", VA = "0x20FAFD0")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x20FB3CC", Offset = "0x20FB3CC", VA = "0x20FB3CC")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51F6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC331C", Offset = "0xBC331C")]
		public Mode mode;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC3380", Offset = "0xBC3380")]
		public Absorber[] absorbers;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC33E4", Offset = "0xBC33E4")]
		public AnimationCurve falloff;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC3448", Offset = "0xBC3448")]
		public float falloffSpeed;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72E9")]
		private float timer;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private float w;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51F74")]
		private Mode initialMode;

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x20FA310", Offset = "0x20FA310", VA = "0x20FA310", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x20FA464", Offset = "0x20FA464", VA = "0x20FA464")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x20FA840", Offset = "0x20FA840", VA = "0x20FA840", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x20FAE6C", Offset = "0x20FAE6C", VA = "0x20FAE6C")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x20FB19C", Offset = "0x20FB19C", VA = "0x20FB19C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x20FB388", Offset = "0x20FB388", VA = "0x20FB388")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Animator animator;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72F9")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Transform cube;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4C5CC")]
		public float cubeRandomPosition;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AnimatorStateInfo info;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72FF")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x20FB4BC", Offset = "0x20FB4BC", VA = "0x20FB4BC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x20FB598", Offset = "0x20FB598", VA = "0x20FB598")]
		private void Update()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x20FB6CC", Offset = "0x20FB6CC", VA = "0x20FB6CC")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x20FB9A8", Offset = "0x20FB9A8", VA = "0x20FB9A8")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000115")]
		public class EffectorLink
		{
			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4CDF4")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float weightMultiplier;

			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x20FDB2C", Offset = "0x20FDB2C", VA = "0x20FDB2C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x20FD340", Offset = "0x20FD340", VA = "0x20FD340", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x20FD5D4", Offset = "0x20FD5D4", VA = "0x20FD5D4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x20FDAFC", Offset = "0x20FDAFC", VA = "0x20FDAFC")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBBAABC", Offset = "0xBBAABC")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC34AC", Offset = "0xBC34AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC34AC", Offset = "0xBC34AC")]
		public float weight;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7306")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC3548", Offset = "0xBC3548")]
		public float hangingDistanceMlp;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC35AC", Offset = "0xBC35AC")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51F84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC362C", Offset = "0xBC362C")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform target;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform leftHandTarget;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform rightHandTarget;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x730E")]
		public Transform leftFootTarget;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Transform rightFootTarget;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51F8C")]
		public Transform pelvisTarget;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform bodyTarget;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform headTarget;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7316")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51F94")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float lastWeight;

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x20FDB70", Offset = "0x20FDB70", VA = "0x20FDB70")]
		private void Start()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x20FE2E0", Offset = "0x20FE2E0", VA = "0x20FE2E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x20FF388", Offset = "0x20FF388", VA = "0x20FF388")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int GUIspace;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x731E")]
		public InteractionObject obj;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Transform pivot;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51F9C")]
		public Transform holdPoint;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float pickUpTime;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float holdWeight;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float holdWeightVel;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7326")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x1700006B")]
		private bool holding
		{
			[Token(Token = "0x6000587")]
			[Address(RVA = "0x20FF71C", Offset = "0x20FF71C", VA = "0x20FF71C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x20FF488", Offset = "0x20FF488", VA = "0x20FF488")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000581")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x20FF78C", Offset = "0x20FF78C", VA = "0x20FF78C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x20FFA00", Offset = "0x20FFA00", VA = "0x20FFA00")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x20FFD54", Offset = "0x20FFD54", VA = "0x20FFD54")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x20FFEF0", Offset = "0x20FFEF0", VA = "0x20FFEF0")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x2100198", Offset = "0x2100198", VA = "0x2100198")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x210054C", Offset = "0x210054C", VA = "0x210054C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x2100874", Offset = "0x2100874", VA = "0x2100874")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x21008BC", Offset = "0x21008BC", VA = "0x21008BC", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x2100D24", Offset = "0x2100D24", VA = "0x2100D24")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x2100D54", Offset = "0x2100D54", VA = "0x2100D54", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x2101104", Offset = "0x2101104", VA = "0x2101104")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51FA4")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform root;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Rigidbody pelvis;

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x2102294", Offset = "0x2102294", VA = "0x2102294")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x2102338", Offset = "0x2102338", VA = "0x2102338")]
		private void Update()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x21026DC", Offset = "0x21026DC", VA = "0x21026DC")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBBAB6C", Offset = "0xBBAB6C")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float magnitude;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x732E")]
		private Recoil recoil;

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x210270C", Offset = "0x210270C", VA = "0x210270C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x2102798", Offset = "0x2102798", VA = "0x2102798")]
		private void Update()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x2102840", Offset = "0x2102840", VA = "0x2102840")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x21028E4", Offset = "0x21028E4", VA = "0x21028E4")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000116")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBB140", Offset = "0xBBB140")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7336")]
			private int <>1__state;

			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private object <>2__current;

			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51FB4")]
			public float resetTime;

			[Token(Token = "0x4000817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000C4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007BF")]
				[Address(RVA = "0x2103124", Offset = "0x2103124", VA = "0x2103124", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007C1")]
				[Address(RVA = "0x21031F4", Offset = "0x21031F4", VA = "0x21031F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x2102BE4", Offset = "0x2102BE4", VA = "0x2102BE4")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x2102C70", Offset = "0x2102C70", VA = "0x2102C70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x2102C84", Offset = "0x2102C84", VA = "0x2102C84", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x2103154", Offset = "0x2103154", VA = "0x2103154", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public float resetDelay;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51FAC")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Transform defaultParent;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Rigidbody r;

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x2102928", Offset = "0x2102928", VA = "0x2102928")]
		private void Start()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x2102A7C", Offset = "0x2102A7C", VA = "0x2102A7C")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x2102B00", Offset = "0x2102B00", VA = "0x2102B00")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBCEEF8", Offset = "0xBCEEF8")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x2102C2C", Offset = "0x2102C2C", VA = "0x2102C2C")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBBAC1C", Offset = "0xBBAC1C")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000117")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBB17C", Offset = "0xBBB17C")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private int <>1__state;

			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51FBC")]
			private object <>2__current;

			[Token(Token = "0x400081A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000C6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007C5")]
				[Address(RVA = "0x210680C", Offset = "0x210680C", VA = "0x210680C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007C7")]
				[Address(RVA = "0x21068DC", Offset = "0x21068DC", VA = "0x21068DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x21064AC", Offset = "0x21064AC", VA = "0x21064AC")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x2106524", Offset = "0x2106524", VA = "0x2106524", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x2106538", Offset = "0x2106538", VA = "0x2106538", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x210683C", Offset = "0x210683C", VA = "0x210683C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animator animator;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x733E")]
		private Quaternion defaultRotation;

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x21062AC", Offset = "0x21062AC", VA = "0x21062AC")]
		private void Start()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x21063F0", Offset = "0x21063F0", VA = "0x21063F0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBCEFA8", Offset = "0xBCEFA8")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x21064F4", Offset = "0x21064F4", VA = "0x21064F4")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000118")]
		public class EffectorLink
		{
			[Token(Token = "0x400081B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7346")]
			public bool enabled;

			[Token(Token = "0x400081C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400081D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51FC4")]
			public InteractionObject interactionObject;

			[Token(Token = "0x400081E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform spherecastFrom;

			[Token(Token = "0x400081F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float spherecastRadius;

			[Token(Token = "0x4000820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float minDistance;

			[Token(Token = "0x4000821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x734E")]
			public LayerMask touchLayers;

			[Token(Token = "0x4000822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			public float lerpSpeed;

			[Token(Token = "0x4000823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51FCC")]
			public float minSwitchTime;

			[Token(Token = "0x4000824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float releaseDistance;

			[Token(Token = "0x4000825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool sliding;

			[Token(Token = "0x4000826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x4000827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7356")]
			private float raycastDistance;

			[Token(Token = "0x4000828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private bool inTouch;

			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4CDFC")]
			private RaycastHit hit;

			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 targetPosition;

			[Token(Token = "0x400082B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Quaternion targetRotation;

			[Token(Token = "0x400082C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool initiated;

			[Token(Token = "0x400082D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x735D")]
			private float nextSwitchTime;

			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private float speedF;

			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x2107534", Offset = "0x2107534", VA = "0x2107534")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x210918C", Offset = "0x210918C", VA = "0x210918C")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x2107BC8", Offset = "0x2107BC8", VA = "0x2107BC8")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x2109374", Offset = "0x2109374", VA = "0x2109374")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x21096B0", Offset = "0x21096B0", VA = "0x21096B0")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x2109810", Offset = "0x2109810", VA = "0x2109810")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x2109970", Offset = "0x2109970", VA = "0x2109970")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x2108EC8", Offset = "0x2108EC8", VA = "0x2108EC8")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x2109AD0", Offset = "0x2109AD0", VA = "0x2109AD0")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x210742C", Offset = "0x210742C", VA = "0x210742C")]
		private void Start()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x2107AD4", Offset = "0x2107AD4", VA = "0x2107AD4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x2108CE4", Offset = "0x2108CE4", VA = "0x2108CE4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x210915C", Offset = "0x210915C", VA = "0x210915C")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51FD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC36AC", Offset = "0xBC36AC")]
		public Transform to;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC3710", Offset = "0xBC3710")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC3710", Offset = "0xBC3710")]
		public float transferMotion;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 lastPosition;

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x2109B9C", Offset = "0x2109B9C", VA = "0x2109B9C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x2109C14", Offset = "0x2109C14", VA = "0x2109C14")]
		private void Update()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x2109EC8", Offset = "0x2109EC8", VA = "0x2109EC8")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC37AC", Offset = "0xBC37AC")]
		public Transform leftHandTarget;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7365")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51FDC")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x210A288", Offset = "0x210A288", VA = "0x210A288")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x210A634", Offset = "0x210A634", VA = "0x210A634")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x210AC48", Offset = "0x210AC48", VA = "0x210AC48")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x210AE0C", Offset = "0x210AE0C", VA = "0x210AE0C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x210AFEC", Offset = "0x210AFEC", VA = "0x210AFEC")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CharacterThirdPerson character;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool disableInputInInteraction;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x736D")]
		public float enableInputAtProgress;

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x210B8D4", Offset = "0x210B8D4", VA = "0x210B8D4", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x210C3C0", Offset = "0x210C3C0", VA = "0x210C3C0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x210C6D8", Offset = "0x210C6D8", VA = "0x210C6D8")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public GameObject[] characters;

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x20F0A6C", Offset = "0x20F0A6C", VA = "0x20F0A6C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x20F0C40", Offset = "0x20F0C40", VA = "0x20F0C40")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x20F0D6C", Offset = "0x20F0D6C", VA = "0x20F0D6C")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000119")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBB1B8", Offset = "0xBBB1B8")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD51FF4")]
			private int <>1__state;

			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000C8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D4")]
				[Address(RVA = "0x2102194", Offset = "0x2102194", VA = "0x2102194", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007D6")]
				[Address(RVA = "0x2102264", Offset = "0x2102264", VA = "0x2102264", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x21018E0", Offset = "0x21018E0", VA = "0x21018E0")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x2101DF0", Offset = "0x2101DF0", VA = "0x2101DF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x2101E04", Offset = "0x2101E04", VA = "0x2101E04", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x21021C4", Offset = "0x21021C4", VA = "0x21021C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51FE4")]
		public float maxAngle;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float switchRotationTime;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float random;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float rotationSpeed;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7375")]
		public Vector3 movePosition;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public float moveSpeed;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51FEC")]
		public int characterLayer;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion targetRotation;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 targetPosition;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x737D")]
		private Vector3 velocity;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Rigidbody r;

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x2101134", Offset = "0x2101134", VA = "0x2101134")]
		private void Start()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x21013E8", Offset = "0x21013E8", VA = "0x21013E8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x210132C", Offset = "0x210132C", VA = "0x210132C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBCF058", Offset = "0xBCF058")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x2101928", Offset = "0x2101928", VA = "0x2101928")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x2101B58", Offset = "0x2101B58", VA = "0x2101B58")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x2101D58", Offset = "0x2101D58", VA = "0x2101D58")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LimbIK limbIK;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7385")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC3810", Offset = "0xBC3810")]
		public float weight;

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x2C07228", Offset = "0x2C07228", VA = "0x2C07228")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x2C07320", Offset = "0x2C07320", VA = "0x2C07320")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x2C07494", Offset = "0x2C07494", VA = "0x2C07494")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200011A")]
		public class Part
		{
			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform transform;

			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x210A018", Offset = "0x210A018", VA = "0x210A018")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x210A258", Offset = "0x210A258", VA = "0x210A258")]
			public Part()
			{
			}
		}

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public Transform target;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD51FFC")]
		public Part[] parts;

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x2109F10", Offset = "0x2109F10", VA = "0x2109F10")]
		private void Update()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x210A228", Offset = "0x210A228", VA = "0x210A228")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x738D")]
		public float hitForce;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private string colliderName;

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x20F1218", Offset = "0x20F1218", VA = "0x20F1218")]
		private void Update()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x20F1508", Offset = "0x20F1508", VA = "0x20F1508")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x20F1650", Offset = "0x20F1650", VA = "0x20F1650")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD52004")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC3858", Offset = "0xBC3858")]
		public VRIK ik;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC38BC", Offset = "0xBC38BC")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC3920", Offset = "0xBC3920")]
		public Transform headTracker;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC3984", Offset = "0xBC3984")]
		public Transform bodyTracker;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7395")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC39E8", Offset = "0xBC39E8")]
		public Transform leftHandTracker;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC3A4C", Offset = "0xBC3A4C")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5200C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC3AB0", Offset = "0xBC3AB0")]
		public Transform leftFootTracker;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC3B14", Offset = "0xBC3B14")]
		public Transform rightFootTracker;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xBC3B78", Offset = "0xBC3B78")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x210C738", Offset = "0x210C738", VA = "0x210C738")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x210CB0C", Offset = "0x210CB0C", VA = "0x210CB0C")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VRIK ik;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x739D")]
		private Vector3 lastPosition;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Quaternion lastRotation;

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x210CBB4", Offset = "0x210CBB4", VA = "0x210CBB4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x210CC80", Offset = "0x210CC80", VA = "0x210CC80")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x210D058", Offset = "0x210D058", VA = "0x210D058")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD52014")]
		public VRIK ik;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform trackingSpace;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform platform;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool moveToPlatform;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73A5")]
		private Transform lastPlatform;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5201C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x210D13C", Offset = "0x210D13C", VA = "0x210D13C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x210DD74", Offset = "0x210DD74", VA = "0x210DD74")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool smoothFollow;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool animatePhysics;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73AD")]
		private Vector3 lastPosition;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Vector3 localPosition;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4CE04")]
		private Quaternion localRotation;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Quaternion lastRotation;

		[Token(Token = "0x1700006C")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x2C084F0", Offset = "0x2C084F0", VA = "0x2C084F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x2C08490", Offset = "0x2C08490", VA = "0x2C08490", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x2C08514", Offset = "0x2C08514", VA = "0x2C08514")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x2C08694", Offset = "0x2C08694", VA = "0x2C08694", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x2C08980", Offset = "0x2C08980", VA = "0x2C08980", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x2C08F24", Offset = "0x2C08F24", VA = "0x2C08F24", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x2C089D8", Offset = "0x2C089D8", VA = "0x2C089D8")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x2C08F80", Offset = "0x2C08F80", VA = "0x2C08F80")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBBACCC", Offset = "0xBBACCC")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float pivotOffset;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73B4")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Animator animator;

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x2C08FDC", Offset = "0x2C08FDC", VA = "0x2C08FDC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x2C0907C", Offset = "0x2C0907C", VA = "0x2C0907C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x2C09278", Offset = "0x2C09278", VA = "0x2C09278")]
		private void Update()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x2C0954C", Offset = "0x2C0954C", VA = "0x2C0954C")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBBAD7C", Offset = "0xBBAD7C")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD52024")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xBC3C90", Offset = "0xBC3C90")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		protected Animator animator;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5202C")]
		private Vector3 lastForward;

		[Token(Token = "0x4000538")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000539")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float deltaAngle;

		[Token(Token = "0x1700006D")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x2C096AC", Offset = "0x2C096AC", VA = "0x2C096AC", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x2C0957C", Offset = "0x2C0957C", VA = "0x2C0957C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x2C09654", Offset = "0x2C09654", VA = "0x2C09654", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x2C0988C", Offset = "0x2C0988C", VA = "0x2C0988C", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x2C0A1F8", Offset = "0x2C0A1F8", VA = "0x2C0A1F8")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x2C0A538", Offset = "0x2C0A538", VA = "0x2C0A538")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBBAE2C", Offset = "0xBBAE2C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBBAE2C", Offset = "0xBBAE2C")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73C4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xBC3D00", Offset = "0xBC3D00")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC3D00", Offset = "0xBC3D00")]
		public Transform gravityTarget;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC3DAC", Offset = "0xBC3DAC")]
		public float gravityMultiplier;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD52034")]
		public float airborneThreshold;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float slopeStartAngle;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float slopeEndAngle;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float spherecastRadius;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73CC")]
		public LayerMask groundLayers;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5203C")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Rigidbody r;

		[Token(Token = "0x4000545")]
		protected const float half = 0.5f;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected float originalHeight;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73D4")]
		protected Vector3 originalCenter;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60005D5")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x2C0AF20", Offset = "0x2C0AF20", VA = "0x2C0AF20")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x2C0B1D0", Offset = "0x2C0B1D0", VA = "0x2C0B1D0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x2C0B450", Offset = "0x2C0B450", VA = "0x2C0B450", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x2C0B928", Offset = "0x2C0B928", VA = "0x2C0B928")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x2C0BAA8", Offset = "0x2C0BAA8", VA = "0x2C0BAA8")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x2C0BE84", Offset = "0x2C0BE84", VA = "0x2C0BE84")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x2C0C1E8", Offset = "0x2C0C1E8", VA = "0x2C0C1E8")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x2C0C240", Offset = "0x2C0C240", VA = "0x2C0C240")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x2C0C298", Offset = "0x2C0C298", VA = "0x2C0C298")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x2C0C4AC", Offset = "0x2C0C4AC", VA = "0x2C0C4AC")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x200011B")]
		public enum MoveMode
		{
			[Token(Token = "0x4000835")]
			Directional,
			[Token(Token = "0x4000836")]
			Strafe
		}

		[Token(Token = "0x200011C")]
		public struct AnimState
		{
			[Token(Token = "0x4000837")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9FFF0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000838")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD5207C")]
			public bool jump;

			[Token(Token = "0x4000839")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool crouch;

			[Token(Token = "0x400083A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool onGround;

			[Token(Token = "0x400083B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool isStrafing;

			[Token(Token = "0x400083C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x741B")]
			public float yVelocity;

			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9FFF0")]
			public bool doubleJump;
		}

		[Token(Token = "0x200011D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBBB1F4", Offset = "0xBBB1F4")]
		private sealed class <JumpSmooth>d__74 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD52094")]
			private int <>1__state;

			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x4000842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7433")]
			private int <steps>5__2;

			[Token(Token = "0x4000843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x170000CA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007DC")]
				[Address(RVA = "0x20E92F4", Offset = "0x20E92F4", VA = "0x20E92F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007DE")]
				[Address(RVA = "0x20E93C4", Offset = "0x20E93C4", VA = "0x20E93C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x20E8FC0", Offset = "0x20E8FC0", VA = "0x20E8FC0")]
			[DebuggerHidden]
			public <JumpSmooth>d__74(int <>1__state)
			{
			}

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x20E9008", Offset = "0x20E9008", VA = "0x20E9008", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x20E901C", Offset = "0x20E901C", VA = "0x20E901C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x20E9324", Offset = "0x20E9324", VA = "0x20E9324", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD52044")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xBC3E10", Offset = "0xBC3E10")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CameraController cam;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xBC3E74", Offset = "0xBC3E74")]
		public MoveMode moveMode;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73DC")]
		public bool smoothPhysics;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public float smoothAccelerationTime;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5204C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float platformFriction;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float groundStickyEffect;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73E4")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xBC3ED8", Offset = "0xBC3ED8")]
		public bool lookInCameraDirection;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD52054")]
		public float turnSpeed;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xBC3F3C", Offset = "0xBC3F3C")]
		public bool smoothJump;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float airSpeed;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73EC")]
		public float airControl;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public float jumpPower;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5205C")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xBC3FA0", Offset = "0xBC3FA0")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73F4")]
		public float wallRunMaxLength;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD52064")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73FC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xBC4004", Offset = "0xBC4004")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC4068", Offset = "0xBC4068")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5206C")]
		public AnimState animState;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Vector3 moveDirection;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animator animator;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 normal;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7404")]
		private Vector3 platformVelocity;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4CE0C")]
		private RaycastHit hit;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float jumpLeg;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float jumpEndTime;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float forwardMlp;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x740B")]
		private float groundDistance;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private float lastAirTime;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD52074")]
		private float stickyForce;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float wallRunWeight;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7413")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5207C")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool fixedFrame;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float wallRunEndTime;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 gravity;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x741B")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private float velocityY;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD52084")]
		private bool doubleJumped;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool jumpReleased;

		[Token(Token = "0x1700006E")]
		public bool onGround
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x2C0CD48", Offset = "0x2C0CD48", VA = "0x2C0CD48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF108", Offset = "0xBCF108")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x2C0CD8C", Offset = "0x2C0CD8C", VA = "0x2C0CD8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF144", Offset = "0xBCF144")]
			private set
			{
			}
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x2C0CDD8", Offset = "0x2C0CDD8", VA = "0x2C0CDD8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x2C0D0C8", Offset = "0x2C0D0C8", VA = "0x2C0D0C8")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x2C0D188", Offset = "0x2C0D188", VA = "0x2C0D188", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x2C0D3B4", Offset = "0x2C0D3B4", VA = "0x2C0D3B4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x2C0FAA8", Offset = "0x2C0FAA8", VA = "0x2C0FAA8", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x2C10380", Offset = "0x2C10380", VA = "0x2C10380", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x2C0E3E0", Offset = "0x2C0E3E0", VA = "0x2C0E3E0")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x2C105F0", Offset = "0x2C105F0", VA = "0x2C105F0")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x2C114C8", Offset = "0x2C114C8", VA = "0x2C114C8")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x2C0FD04", Offset = "0x2C0FD04", VA = "0x2C0FD04")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x2C116BC", Offset = "0x2C116BC", VA = "0x2C116BC", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x2C12000", Offset = "0x2C12000", VA = "0x2C12000")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x2C1263C", Offset = "0x2C1263C", VA = "0x2C1263C", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x2C12B88", Offset = "0x2C12B88", VA = "0x2C12B88")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xBCF180", Offset = "0xBCF180")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x2C0F064", Offset = "0x2C0F064", VA = "0x2C0F064")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x2C12C70", Offset = "0x2C12C70", VA = "0x2C12C70")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xBBAF28", Offset = "0xBBAF28")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200011E")]
		public enum RotationMode
		{
			[Token(Token = "0x4000845")]
			Smooth,
			[Token(Token = "0x4000846")]
			Linear
		}

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5209C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC40A4", Offset = "0xBC40A4")]
		public CameraController cameraController;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC4108", Offset = "0xBC4108")]
		public float accelerationTime;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC416C", Offset = "0xBC416C")]
		public float turnTime;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC41D0", Offset = "0xBC41D0")]
		public bool walkByDefault;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x743B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC4234", Offset = "0xBC4234")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC4298", Offset = "0xBC4298")]
		public float moveSpeed;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD520A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC42FC", Offset = "0xBC42FC")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Animator animator;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float speed;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float angleVel;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7443")]
		private float speedVel;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD520AC")]
		private CharacterController characterController;

		[Token(Token = "0x1700006F")]
		public bool isGrounded
		{
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x2104A44", Offset = "0x2104A44", VA = "0x2104A44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF230", Offset = "0xBCF230")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x2104A88", Offset = "0x2104A88", VA = "0x2104A88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF26C", Offset = "0xBCF26C")]
			private set
			{
			}
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x2104AD4", Offset = "0x2104AD4", VA = "0x2104AD4")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x2104BC4", Offset = "0x2104BC4", VA = "0x2104BC4")]
		private void Update()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x2105BFC", Offset = "0x2105BFC", VA = "0x2105BFC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x2104C5C", Offset = "0x2104C5C", VA = "0x2104C5C")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x21055E0", Offset = "0x21055E0", VA = "0x21055E0")]
		private void Move()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x2105C64", Offset = "0x2105C64", VA = "0x2105C64")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x2105E84", Offset = "0x2105E84", VA = "0x2105E84")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x2105F84", Offset = "0x2105F84", VA = "0x2105F84")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x744B")]
		public Transform moveTarget;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public float stoppingDistance;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD520B4")]
		public float stoppingThreshold;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Navigator navigator;

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x210B01C", Offset = "0x210B01C", VA = "0x210B01C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x210B0DC", Offset = "0x210B0DC", VA = "0x210B0DC", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x210B7A0", Offset = "0x210B7A0", VA = "0x210B7A0")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x210B81C", Offset = "0x210B81C", VA = "0x210B81C")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x200011F")]
		public struct State
		{
			[Token(Token = "0x4000847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x4000848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 lookPos;

			[Token(Token = "0x4000849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool crouch;

			[Token(Token = "0x400084A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x744B")]
			public bool jump;

			[Token(Token = "0x400084B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9FFF0")]
			public int actionIndex;
		}

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool walkByDefault;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool canCrouch;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7453")]
		public bool canJump;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		public State state;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD520BC")]
		protected Transform cam;

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x210B084", Offset = "0x210B084", VA = "0x210B084", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x210BB84", Offset = "0x210BB84", VA = "0x210BB84", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x210B878", Offset = "0x210B878", VA = "0x210B878")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x2C07178", Offset = "0x2C07178", VA = "0x2C07178")]
		private void Update()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x2C071F8", Offset = "0x2C071F8", VA = "0x2C071F8")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4CE14")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool mouse0;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool mouse1;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float slowMoTimeScale;

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x210600C", Offset = "0x210600C", VA = "0x210600C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x2106094", Offset = "0x2106094", VA = "0x2106094")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x2106264", Offset = "0x2106264", VA = "0x2106264")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BB")]
	public class Navigator
	{
		[Token(Token = "0x2000120")]
		public enum State
		{
			[Token(Token = "0x400084D")]
			Idle,
			[Token(Token = "0x400084E")]
			Seeking,
			[Token(Token = "0x400084F")]
			OnPath
		}

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7462")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC4338", Offset = "0xBC4338")]
		public bool activeTargetSeeking;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC439C", Offset = "0xBC439C")]
		public float cornerRadius;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD520C4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC4400", Offset = "0xBC4400")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC4464", Offset = "0xBC4464")]
		public float maxSampleDistance;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xBC44C8", Offset = "0xBC44C8")]
		public float nextPathInterval;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC452C", Offset = "0xBC452C")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x746A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBC4568", Offset = "0xBC4568")]
		private State <state>k__BackingField;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private Transform transform;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD520CC")]
		private int cornerIndex;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3[] corners;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private NavMeshPath path;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7472")]
		private bool initiated;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0000")]
		private float nextPathTime;

		[Token(Token = "0x17000070")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x20FB9F0", Offset = "0x20FB9F0", VA = "0x20FB9F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF2A8", Offset = "0xBCF2A8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000609")]
			[Address(RVA = "0x20FBA30", Offset = "0x20FBA30", VA = "0x20FBA30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF2E4", Offset = "0xBCF2E4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public State state
		{
			[Token(Token = "0x600060A")]
			[Address(RVA = "0x20FBA90", Offset = "0x20FBA90", VA = "0x20FBA90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF320", Offset = "0xBCF320")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x20FBAC0", Offset = "0x20FBAC0", VA = "0x20FBAC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBCF35C", Offset = "0xBCF35C")]
			private set
			{
			}
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x20FBAF8", Offset = "0x20FBAF8", VA = "0x20FBAF8")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x20FBC38", Offset = "0x20FBC38", VA = "0x20FBC38")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x20FC8F0", Offset = "0x20FC8F0", VA = "0x20FC8F0")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x20FC9FC", Offset = "0x20FC9FC", VA = "0x20FC9FC")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x20FC670", Offset = "0x20FC670", VA = "0x20FC670")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x20FC75C", Offset = "0x20FC75C", VA = "0x20FC75C")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x20FCD38", Offset = "0x20FCD38", VA = "0x20FCD38")]
		public void Visualize()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x20FD23C", Offset = "0x20FD23C", VA = "0x20FD23C")]
		public Navigator()
		{
		}
	}
}
