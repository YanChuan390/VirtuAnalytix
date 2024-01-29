using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using Assets.Plugins.HG.General;
using HG;
using Il2CppDummyDll;
using Plugins.HG.PermissionManager;
using UnityEngine;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class RequestPermissionExample : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	private const string STORAGE_PERMISSION = "android.permission.READ_EXTERNAL_STORAGE";

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text output;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x18EAFF8", Offset = "0x18EAFF8", VA = "0x18EAFF8")]
	public void TestRequestPermission()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x18EB13C", Offset = "0x18EB13C", VA = "0x18EB13C")]
	private void OnPermissionGranted(string grantedPermission)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x18EB19C", Offset = "0x18EB19C", VA = "0x18EB19C")]
	private void OnPermissionDenied(string deniedPermission)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x18EB1FC", Offset = "0x18EB1FC", VA = "0x18EB1FC")]
	public void CheckPermission()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x18EB114", Offset = "0x18EB114", VA = "0x18EB114")]
	private void ShowMessage(string message)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x18EB2A8", Offset = "0x18EB2A8", VA = "0x18EB2A8")]
	public RequestPermissionExample()
	{
	}
}
[Token(Token = "0x2000003")]
public class ReadWriteTestScene : MonoBehaviour
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text output;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x18EACE8", Offset = "0x18EACE8", VA = "0x18EACE8")]
	public void RequestReadPermission()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x18EADD8", Offset = "0x18EADD8", VA = "0x18EADD8")]
	public void RequestWritePermission()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x18EAEC8", Offset = "0x18EAEC8", VA = "0x18EAEC8")]
	private void OnPermissionGranted(string grantedPermission)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x18EAF70", Offset = "0x18EAF70", VA = "0x18EAF70")]
	private void OnPermissionDenied(string deniedPermission)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x18EAF48", Offset = "0x18EAF48", VA = "0x18EAF48")]
	private void ShowMessage(string message)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x18EAFF0", Offset = "0x18EAFF0", VA = "0x18EAFF0")]
	public ReadWriteTestScene()
	{
	}
}
[Token(Token = "0x2000004")]
public class ExampleRationaleDialog : MonoBehaviour
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Action onOkPressed;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x18E90EC", Offset = "0x18E90EC", VA = "0x18E90EC")]
	public void SetOkCallback(Action OnOkPressed)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x18E90F4", Offset = "0x18E90F4", VA = "0x18E90F4")]
	public void OnButtonPressed()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x18E917C", Offset = "0x18E917C", VA = "0x18E917C")]
	public ExampleRationaleDialog()
	{
	}
}
[Token(Token = "0x2000005")]
public class TestRationaleDialogExample : MonoBehaviour
{
	[Token(Token = "0x4000005")]
	private const string STORAGE_PERMISSION = "android.permission.WRITE_EXTERNAL_STORAGE";

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text output;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Canvas mainCanvas;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject rationaleDialogPrefab;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x18EBCAC", Offset = "0x18EBCAC", VA = "0x18EBCAC")]
	public void TestRequestPermission()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x18EBD64", Offset = "0x18EBD64", VA = "0x18EBD64")]
	private void ShowRationaleDialog(Action onOkPressed)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x18EBE3C", Offset = "0x18EBE3C", VA = "0x18EBE3C")]
	private void RequestPermission()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x18EBF2C", Offset = "0x18EBF2C", VA = "0x18EBF2C")]
	private void OnPermissionGranted(string grantedPermission)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x18EBFB4", Offset = "0x18EBFB4", VA = "0x18EBFB4")]
	private void OnPermissionDenied(string deniedPermission)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x18EBF8C", Offset = "0x18EBF8C", VA = "0x18EBF8C")]
	private void ShowMessage(string message)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x18EC014", Offset = "0x18EC014", VA = "0x18EC014")]
	public TestRationaleDialogExample()
	{
	}
}
namespace Assets.Plugins.HG.PermissionManager
{
	[Token(Token = "0x2000006")]
	public class BehaviourSelector : Singleton<BehaviourSelector>
	{
		[Token(Token = "0x4000009")]
		private const int ANDROID_6_API_LEVEL = 23;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IPermissionManagerBehaviour _currentBehaviour;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IPermissionsManipulator _permissionsManipulator;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ISkipPermissionsDialogManipulator _skipManipulator;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _manipulatorsSet;

		[Token(Token = "0x17000001")]
		public static IPermissionManagerBehaviour CurrentBehaviour
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x18E7748", Offset = "0x18E7748", VA = "0x18E7748")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x18E779C", Offset = "0x18E779C", VA = "0x18E779C")]
		public BehaviourSelector()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x18E78C8", Offset = "0x18E78C8", VA = "0x18E78C8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x18E7918", Offset = "0x18E7918", VA = "0x18E7918")]
		public void SetManipulators(IPermissionsManipulator permissionsManipulator, ISkipPermissionsDialogManipulator skipManipulator)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x18E7AE4", Offset = "0x18E7AE4", VA = "0x18E7AE4")]
		private void SetupExternalListeners()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x18E77F8", Offset = "0x18E77F8", VA = "0x18E77F8")]
		private bool SwitchBehaviour()
		{
			return default(bool);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x18E7F24", Offset = "0x18E7F24", VA = "0x18E7F24")]
		private void SwitchBehaviourAndLog()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x18E7ED0", Offset = "0x18E7ED0", VA = "0x18E7ED0")]
		private IPermissionManagerBehaviour GetBehaviour()
		{
			return null;
		}
	}
}
namespace Assets.Plugins.HG.General
{
	[Token(Token = "0x2000007")]
	public class Singleton<T> where T : new()
	{
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static T _instance;

		[Token(Token = "0x17000002")]
		public static T Instance
		{
			[Token(Token = "0x600001F")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x6000020")]
		public Singleton()
		{
		}
	}
}
namespace Plugins.HG.PermissionManager
{
	[Serializable]
	[Token(Token = "0x2000008")]
	public class AndroidPermissionCallback : AndroidJavaProxy
	{
		[Token(Token = "0x200003A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91D85C", Offset = "0x91D85C")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40000EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AndroidPermissionCallback <>4__this;

			[Token(Token = "0x40000F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string permissionName;

			[Token(Token = "0x6000113")]
			[Address(RVA = "0x18E6798", Offset = "0x18E6798", VA = "0x18E6798")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000114")]
			[Address(RVA = "0x18ECBF0", Offset = "0x18ECBF0", VA = "0x18ECBF0")]
			internal void <OnPermissionGranted>b__0()
			{
			}
		}

		[Token(Token = "0x200003B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91D86C", Offset = "0x91D86C")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40000F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AndroidPermissionCallback <>4__this;

			[Token(Token = "0x40000F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string permissionName;

			[Token(Token = "0x6000115")]
			[Address(RVA = "0x18E687C", Offset = "0x18E687C", VA = "0x18E687C")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000116")]
			[Address(RVA = "0x18ECC4C", Offset = "0x18ECC4C", VA = "0x18ECC4C")]
			internal void <OnPermissionDenied>b__0()
			{
			}
		}

		[Token(Token = "0x14000001")]
		private event Action<string> OnPermissionGrantedAction
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x18E643C", Offset = "0x18E643C", VA = "0x18E643C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DACC", Offset = "0x91DACC")]
			add
			{
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x18E64DC", Offset = "0x18E64DC", VA = "0x18E64DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DADC", Offset = "0x91DADC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		private event Action<string> OnPermissionDeniedAction
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x18E657C", Offset = "0x18E657C", VA = "0x18E657C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DAEC", Offset = "0x91DAEC")]
			add
			{
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x18E661C", Offset = "0x18E661C", VA = "0x18E661C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DAFC", Offset = "0x91DAFC")]
			remove
			{
			}
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x18E58A8", Offset = "0x18E58A8", VA = "0x18E58A8")]
		public AndroidPermissionCallback(Action<string> onGrantedCallback, Action<string> onDeniedCallback)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x18E66BC", Offset = "0x18E66BC", VA = "0x18E66BC")]
		public void OnPermissionGranted(string permissionName)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x18E67A0", Offset = "0x18E67A0", VA = "0x18E67A0")]
		public void OnPermissionDenied(string permissionName)
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class AndroidBehaviour : IPermissionManagerBehaviour
	{
		[Serializable]
		[Token(Token = "0x200003C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91D87C", Offset = "0x91D87C")]
		private sealed class <>c
		{
			[Token(Token = "0x40000F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action <>9__0_0;

			[Token(Token = "0x6000118")]
			[Address(RVA = "0x18ECBE4", Offset = "0x18ECBE4", VA = "0x18ECBE4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000119")]
			[Address(RVA = "0x18ECBEC", Offset = "0x18ECBEC", VA = "0x18ECBEC")]
			internal void <.ctor>b__0_0()
			{
			}
		}

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AndroidJavaObject _currentActivity;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static AndroidJavaObject _permissionsNative;

		[Token(Token = "0x17000003")]
		private static AndroidJavaObject Activity
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x18E559C", Offset = "0x18E559C", VA = "0x18E559C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x18E5100", Offset = "0x18E5100", VA = "0x18E5100")]
		public AndroidBehaviour()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x18E5338", Offset = "0x18E5338", VA = "0x18E5338", Slot = "4")]
		public bool IsPermissionGranted(string permissionName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x18E5690", Offset = "0x18E5690", VA = "0x18E5690", Slot = "6")]
		public bool ShouldShowRequestPermissionRationale(string permissionName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x18E57BC", Offset = "0x18E57BC", VA = "0x18E57BC", Slot = "5")]
		public void RequestPermission(string permissionName, Action<string> OnPermissionGranted, Action<string> OnPermissionDenied)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x18E5AC8", Offset = "0x18E5AC8", VA = "0x18E5AC8", Slot = "7")]
		public bool IsPlatformSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x18E5AD0", Offset = "0x18E5AD0", VA = "0x18E5AD0", Slot = "8")]
		public void OpenNativeSettings()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x18E5464", Offset = "0x18E5464", VA = "0x18E5464")]
		private static AndroidJavaObject GetNative()
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x18E5970", Offset = "0x18E5970", VA = "0x18E5970")]
		private static void RequestPermissions(string[] permissionNames, AndroidPermissionCallback callback)
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class AndroidSixBehaviour : TestAndroidBehaviour
	{
		[Token(Token = "0x200003D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91D88C", Offset = "0x91D88C")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40000F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<string> OnPermissionDenied;

			[Token(Token = "0x40000F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string permissionName;

			[Token(Token = "0x40000F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<string> OnPermissionGranted;

			[Token(Token = "0x40000F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AndroidSixBehaviour <>4__this;

			[Token(Token = "0x40000F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action <>9__7;

			[Token(Token = "0x40000FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action <>9__8;

			[Token(Token = "0x600011A")]
			[Address(RVA = "0x18E72B8", Offset = "0x18E72B8", VA = "0x18E72B8")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600011B")]
			[Address(RVA = "0x18ECCA8", Offset = "0x18ECCA8", VA = "0x18ECCA8")]
			internal void <RequestPermissionImpl>b__0()
			{
			}

			[Token(Token = "0x600011C")]
			[Address(RVA = "0x18ECCFC", Offset = "0x18ECCFC", VA = "0x18ECCFC")]
			internal void <RequestPermissionImpl>b__1()
			{
			}

			[Token(Token = "0x600011D")]
			[Address(RVA = "0x18ECD50", Offset = "0x18ECD50", VA = "0x18ECD50")]
			internal void <RequestPermissionImpl>b__2()
			{
			}

			[Token(Token = "0x600011E")]
			[Address(RVA = "0x18ECDA4", Offset = "0x18ECDA4", VA = "0x18ECDA4")]
			internal void <RequestPermissionImpl>b__3()
			{
			}

			[Token(Token = "0x600011F")]
			[Address(RVA = "0x18ECDF8", Offset = "0x18ECDF8", VA = "0x18ECDF8")]
			internal void <RequestPermissionImpl>b__4()
			{
			}

			[Token(Token = "0x6000120")]
			[Address(RVA = "0x18ECE4C", Offset = "0x18ECE4C", VA = "0x18ECE4C")]
			internal void <RequestPermissionImpl>b__5(IPermissionsDialog dialog)
			{
			}

			[Token(Token = "0x6000121")]
			[Address(RVA = "0x18ECF90", Offset = "0x18ECF90", VA = "0x18ECF90")]
			internal void <RequestPermissionImpl>b__7()
			{
			}

			[Token(Token = "0x6000122")]
			[Address(RVA = "0x18ECFE4", Offset = "0x18ECFE4", VA = "0x18ECFE4")]
			internal void <RequestPermissionImpl>b__6(IPermissionsDialog dialog)
			{
			}

			[Token(Token = "0x6000123")]
			[Address(RVA = "0x18ED0A8", Offset = "0x18ED0A8", VA = "0x18ED0A8")]
			internal void <RequestPermissionImpl>b__8()
			{
			}
		}

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IPermissionsDialogFactory _permissionsDialogFactory;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly PermissionsState _permissionsState;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly DataHolder.PermissionsData _permissionsData;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly PermissionRequestQueue _permissionQueue;

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x18E6884", Offset = "0x18E6884", VA = "0x18E6884")]
		public AndroidSixBehaviour(IPermissionsManipulator manipulator, IPermissionsDialogFactory permissionsDialogFactory, PermissionsState permissionsState, DataHolder.PermissionsData permissionsData)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x18E6A98", Offset = "0x18E6A98", VA = "0x18E6A98", Slot = "9")]
		public override bool IsPermissionGranted(string permissionName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x18E6D04", Offset = "0x18E6D04", VA = "0x18E6D04", Slot = "10")]
		public override void RequestPermission(string permissionName, Action<string> OnPermissionGranted, Action<string> OnPermissionDenied)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x18E6DDC", Offset = "0x18E6DDC", VA = "0x18E6DDC")]
		private void RequestPermissionImpl(string permissionName, Action<string> OnPermissionGranted, Action<string> OnPermissionDenied)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x18E75DC", Offset = "0x18E75DC", VA = "0x18E75DC")]
		private string GetDialogText(string permissionName)
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x18E76E0", Offset = "0x18E76E0", VA = "0x18E76E0", Slot = "11")]
		public override bool ShouldShowRequestPermissionRationale(string permissionName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x18E7740", Offset = "0x18E7740", VA = "0x18E7740", Slot = "12")]
		public override bool IsPlatformSupported()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200000B")]
	public class NullBehaviour : IPermissionManagerBehaviour
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x18E9AE8", Offset = "0x18E9AE8", VA = "0x18E9AE8", Slot = "4")]
		public bool IsPermissionGranted(string permissionName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x18E9AF0", Offset = "0x18E9AF0", VA = "0x18E9AF0", Slot = "5")]
		public void RequestPermission(string permissionName, Action<string> OnPermissionGranted, Action<string> OnPermissionDenied)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x18E9B4C", Offset = "0x18E9B4C", VA = "0x18E9B4C", Slot = "6")]
		public bool ShouldShowRequestPermissionRationale(string permissionName)
		{
			return default(bool);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x18E9B54", Offset = "0x18E9B54", VA = "0x18E9B54", Slot = "7")]
		public bool IsPlatformSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x18E9B5C", Offset = "0x18E9B5C", VA = "0x18E9B5C", Slot = "8")]
		public void OpenNativeSettings()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x18E9B60", Offset = "0x18E9B60", VA = "0x18E9B60")]
		public NullBehaviour()
		{
		}
	}
	[Token(Token = "0x200000C")]
	internal class PermissionRequestQueue
	{
		[Token(Token = "0x200003E")]
		private class PermissionRequest
		{
			[Token(Token = "0x40000FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string PermissionName;

			[Token(Token = "0x40000FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<string> OnPermissionGranted;

			[Token(Token = "0x40000FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<string> OnPermissionDenied;

			[Token(Token = "0x6000124")]
			[Address(RVA = "0x18E9EE4", Offset = "0x18E9EE4", VA = "0x18E9EE4")]
			public PermissionRequest()
			{
			}
		}

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Action<string, Action<string>, Action<string>> _requestPermissionDelegate;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _requestInProgress;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<PermissionRequest> _queue;

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x18E69F0", Offset = "0x18E69F0", VA = "0x18E69F0")]
		public PermissionRequestQueue(Action<string, Action<string>, Action<string>> requestPermissionDelegate)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x18E6D20", Offset = "0x18E6D20", VA = "0x18E6D20")]
		public void Add(string permissionName, Action<string> onPermissionGranted, Action<string> onPermissionDenied)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x18E9F50", Offset = "0x18E9F50", VA = "0x18E9F50")]
		private void ProcessQueue()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x18EA148", Offset = "0x18EA148", VA = "0x18EA148")]
		private void OnRequestFinished(string permissionName)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x18E9EEC", Offset = "0x18E9EEC", VA = "0x18E9EEC")]
		private void AddToQueue(PermissionRequest request)
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class PreAndroidSixBehaviour : TestAndroidBehaviour
	{
		[Token(Token = "0x200003F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91D89C", Offset = "0x91D89C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40000FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<string> OnPermissionGranted;

			[Token(Token = "0x40000FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string permissionName;

			[Token(Token = "0x4000100")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<string> OnPermissionDenied;

			[Token(Token = "0x6000125")]
			[Address(RVA = "0x18EACD0", Offset = "0x18EACD0", VA = "0x18EACD0")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000126")]
			[Address(RVA = "0x18ED37C", Offset = "0x18ED37C", VA = "0x18ED37C")]
			internal void <RequestPermission>b__0()
			{
			}

			[Token(Token = "0x6000127")]
			[Address(RVA = "0x18ED3D0", Offset = "0x18ED3D0", VA = "0x18ED3D0")]
			internal void <RequestPermission>b__1()
			{
			}
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x18EAB40", Offset = "0x18EAB40", VA = "0x18EAB40")]
		public PreAndroidSixBehaviour(IPermissionsManipulator manipulator)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x18EAB74", Offset = "0x18EAB74", VA = "0x18EAB74", Slot = "9")]
		public override bool IsPermissionGranted(string permissionName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x18EABA8", Offset = "0x18EABA8", VA = "0x18EABA8", Slot = "10")]
		public override void RequestPermission(string permissionName, Action<string> OnPermissionGranted, Action<string> OnPermissionDenied)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x18EACD8", Offset = "0x18EACD8", VA = "0x18EACD8", Slot = "11")]
		public override bool ShouldShowRequestPermissionRationale(string permissionName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x18EACE0", Offset = "0x18EACE0", VA = "0x18EACE0", Slot = "12")]
		public override bool IsPlatformSupported()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200000E")]
	public abstract class TestAndroidBehaviour : IPermissionManagerBehaviour
	{
		[Token(Token = "0x2000040")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91D8AC", Offset = "0x91D8AC")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000101")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string permissionName;

			[Token(Token = "0x6000128")]
			[Address(RVA = "0x18EBC34", Offset = "0x18EBC34", VA = "0x18EBC34")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000129")]
			[Address(RVA = "0x18ED424", Offset = "0x18ED424", VA = "0x18ED424")]
			internal bool <IsPermissionInManifests>b__0(IPermissionInfo p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IPermissionsManipulator _manipulator;

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x18E69BC", Offset = "0x18E69BC", VA = "0x18E69BC")]
		public TestAndroidBehaviour(IPermissionsManipulator manipulator)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x18E6AF8", Offset = "0x18E6AF8", VA = "0x18E6AF8")]
		protected bool IsPermissionInManifests(string permissionName)
		{
			return default(bool);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x18E6C70", Offset = "0x18E6C70", VA = "0x18E6C70")]
		protected void ShowNotInManifestError(string permissionName)
		{
		}

		[Token(Token = "0x600004B")]
		public abstract bool IsPermissionGranted(string permissionName);

		[Token(Token = "0x600004C")]
		public abstract void RequestPermission(string permissionName, Action<string> OnPermissionGranted, Action<string> OnPermissionDenied);

		[Token(Token = "0x600004D")]
		public abstract bool ShouldShowRequestPermissionRationale(string permissionName);

		[Token(Token = "0x600004E")]
		public abstract bool IsPlatformSupported();

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x18EBC3C", Offset = "0x18EBC3C", VA = "0x18EBC3C", Slot = "8")]
		public void OpenNativeSettings()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public interface IPermissionManagerBehaviour
	{
		[Token(Token = "0x6000050")]
		bool IsPermissionGranted(string permissionName);

		[Token(Token = "0x6000051")]
		void RequestPermission(string permissionName, Action<string> OnPermissionGranted, Action<string> OnPermissionDenied);

		[Token(Token = "0x6000052")]
		bool ShouldShowRequestPermissionRationale(string permissionName);

		[Token(Token = "0x6000053")]
		bool IsPlatformSupported();

		[Token(Token = "0x6000054")]
		void OpenNativeSettings();
	}
	[Token(Token = "0x2000010")]
	internal enum FadeState
	{
		[Token(Token = "0x400001C")]
		FadingIn,
		[Token(Token = "0x400001D")]
		FadingOut,
		[Token(Token = "0x400001E")]
		Idle
	}
	[Token(Token = "0x2000011")]
	public class CanvasGroupFader : MonoBehaviour
	{
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _initialAlpha;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _fadeSpeedMultiplier;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FadeState state;

		[Token(Token = "0x14000003")]
		private event Action OnFadedOut
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x18E7FF0", Offset = "0x18E7FF0", VA = "0x18E7FF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DB0C", Offset = "0x91DB0C")]
			add
			{
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x18E8090", Offset = "0x18E8090", VA = "0x18E8090")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DB1C", Offset = "0x91DB1C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		private event Action OnFadedIn
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x18E8130", Offset = "0x18E8130", VA = "0x18E8130")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DB2C", Offset = "0x91DB2C")]
			add
			{
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x18E81D0", Offset = "0x18E81D0", VA = "0x18E81D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DB3C", Offset = "0x91DB3C")]
			remove
			{
			}
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x18E8270", Offset = "0x18E8270", VA = "0x18E8270")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x18E8298", Offset = "0x18E8298", VA = "0x18E8298")]
		public void FadeIn([Optional] Action onFinish)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x18E82EC", Offset = "0x18E82EC", VA = "0x18E82EC")]
		public void FadeOut([Optional] Action onFinish)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x18E8344", Offset = "0x18E8344", VA = "0x18E8344")]
		private void Update()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x18E84F0", Offset = "0x18E84F0", VA = "0x18E84F0")]
		public CanvasGroupFader()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public interface IPermissionsDialogFactory
	{
		[Token(Token = "0x600005E")]
		void CreateTwoButton(string message, Action<IPermissionsDialog> onLeftPressed, Action<IPermissionsDialog> onRightPressed, bool checkboxVisible, bool isCheckedonToggled);
	}
	[Token(Token = "0x2000013")]
	public interface IPermissionsDialog
	{
		[Token(Token = "0x600005F")]
		bool IsChecked();
	}
	[Token(Token = "0x2000014")]
	public class PermissionsDialog : UnityDialog, IPermissionsDialog
	{
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Toggle dontAskAgainCheckbox;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroupFader _canvasFader;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _buttonWasPressed;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x18EA150", Offset = "0x18EA150", VA = "0x18EA150", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x18EA2C4", Offset = "0x18EA2C4", VA = "0x18EA2C4", Slot = "7")]
		protected override void OnButtonPressed(Action dlg)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x18EA33C", Offset = "0x18EA33C", VA = "0x18EA33C", Slot = "8")]
		protected override void DestorySelf()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x18EA3CC", Offset = "0x18EA3CC", VA = "0x18EA3CC", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x18EA3EC", Offset = "0x18EA3EC", VA = "0x18EA3EC")]
		public void SetupCheckbox(bool visible, bool isChecked)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x18EA500", Offset = "0x18EA500", VA = "0x18EA500")]
		private void UpdateButtons(bool isChecked)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x18EA528", Offset = "0x18EA528", VA = "0x18EA528", Slot = "9")]
		public bool IsChecked()
		{
			return default(bool);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x18EA548", Offset = "0x18EA548", VA = "0x18EA548")]
		public PermissionsDialog()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x18EA558", Offset = "0x18EA558", VA = "0x18EA558")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DB4C", Offset = "0x91DB4C")]
		private void <DestorySelf>b__5_0()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class UnityDialog : MonoBehaviour
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Text messageLabel;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Button leftButton;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected Button rightButton;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Action _onLeftPressed;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Action _onRightPressed;

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x18EA1D8", Offset = "0x18EA1D8", VA = "0x18EA1D8", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x18EA3E8", Offset = "0x18EA3E8", VA = "0x18EA3E8", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x18EC31C", Offset = "0x18EC31C", VA = "0x18EC31C", Slot = "6")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x18EA304", Offset = "0x18EA304", VA = "0x18EA304", Slot = "7")]
		protected virtual void OnButtonPressed(Action dlg)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x18EC320", Offset = "0x18EC320", VA = "0x18EC320", Slot = "8")]
		protected virtual void DestorySelf()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x18EC3A0", Offset = "0x18EC3A0", VA = "0x18EC3A0")]
		public void Setup(string message, Action onLeftPressed, Action onRightPressed)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x18EA550", Offset = "0x18EA550", VA = "0x18EA550")]
		public UnityDialog()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x18EC404", Offset = "0x18EC404", VA = "0x18EC404")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DB5C", Offset = "0x91DB5C")]
		private void <Awake>b__5_0()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x18EC414", Offset = "0x18EC414", VA = "0x18EC414")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DB6C", Offset = "0x91DB6C")]
		private void <Awake>b__5_1()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class UnityPermissionsDialogFactory : IPermissionsDialogFactory
	{
		[Token(Token = "0x2000041")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91D8BC", Offset = "0x91D8BC")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000102")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<IPermissionsDialog> onLeftPressed;

			[Token(Token = "0x4000103")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PermissionsDialog dialog;

			[Token(Token = "0x4000104")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<IPermissionsDialog> onRightPressed;

			[Token(Token = "0x600012A")]
			[Address(RVA = "0x18EC6E0", Offset = "0x18EC6E0", VA = "0x18EC6E0")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600012B")]
			[Address(RVA = "0x18ED4DC", Offset = "0x18ED4DC", VA = "0x18ED4DC")]
			internal void <CreateTwoButton>b__0()
			{
			}

			[Token(Token = "0x600012C")]
			[Address(RVA = "0x18ED534", Offset = "0x18ED534", VA = "0x18ED534")]
			internal void <CreateTwoButton>b__1()
			{
			}
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x18EC424", Offset = "0x18EC424", VA = "0x18EC424", Slot = "4")]
		public void CreateTwoButton(string message, Action<IPermissionsDialog> onLeftPressed, Action<IPermissionsDialog> onRightPressed, bool checkboxVisible, bool isChecked)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x18EC6E8", Offset = "0x18EC6E8", VA = "0x18EC6E8")]
		public UnityPermissionsDialogFactory()
		{
		}
	}
}
namespace Plugins.HG.General.Utils
{
	[Token(Token = "0x2000017")]
	public static class ScriptableHelper
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x18EA9C8", Offset = "0x18EA9C8", VA = "0x18EA9C8")]
		public static void Save(UnityEngine.Object scriptableObject)
		{
		}

		[Token(Token = "0x6000075")]
		public static T Load<T>(string filename, string path) where T : ScriptableObject
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		public static T Create<T>(string filename, string path) where T : ScriptableObject
		{
			return null;
		}
	}
}
namespace Plugins.HG.Editor.General.Utils
{
	[Token(Token = "0x2000018")]
	public class EditorSingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x17000004")]
		public static T Instance
		{
			[Token(Token = "0x6000078")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000077")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000079")]
		public static TComponent Create<TComponent>(string uniqueName) where TComponent : MonoBehaviour
		{
			return null;
		}

		[Token(Token = "0x600007A")]
		public static TComponent CreateFast<TComponent>(string uniqueName) where TComponent : MonoBehaviour
		{
			return null;
		}

		[Token(Token = "0x600007B")]
		public EditorSingletonMonoBehaviour()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class MainThreadDispatcher : EditorSingletonMonoBehaviour<MainThreadDispatcher>
	{
		[Token(Token = "0x2000042")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91D8CC", Offset = "0x91D8CC")]
		private sealed class <>c__DisplayClass2_0<T>
		{
			[Token(Token = "0x4000105")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> action;

			[Token(Token = "0x4000106")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T data;

			[Token(Token = "0x600012D")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600012E")]
			internal void <RunOnMainThread>b__0()
			{
			}
		}

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<Action> delayedActions;

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x18E51FC", Offset = "0x18E51FC", VA = "0x18E51FC")]
		public static void RunOnMainThread(Action action)
		{
		}

		[Token(Token = "0x600007D")]
		public static void RunOnMainThread<T>(Action<T> action, T data)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x18E97E0", Offset = "0x18E97E0", VA = "0x18E97E0")]
		private void Update()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x18E9A40", Offset = "0x18E9A40", VA = "0x18E9A40")]
		public MainThreadDispatcher()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class UpdateScheduler : EditorSingletonMonoBehaviour<UpdateScheduler>
	{
		[Token(Token = "0x14000005")]
		public event Action OnUpdate
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x18EC6F0", Offset = "0x18EC6F0", VA = "0x18EC6F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DB7C", Offset = "0x91DB7C")]
			add
			{
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x18EC790", Offset = "0x18EC790", VA = "0x18EC790")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DB8C", Offset = "0x91DB8C")]
			remove
			{
			}
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x18EC830", Offset = "0x18EC830", VA = "0x18EC830")]
		private void Update()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x18EC844", Offset = "0x18EC844", VA = "0x18EC844")]
		public UpdateScheduler()
		{
		}
	}
}
namespace HG
{
	[Token(Token = "0x200001B")]
	public enum LogLevel
	{
		[Token(Token = "0x4000031")]
		Info = 1,
		[Token(Token = "0x4000032")]
		Warning,
		[Token(Token = "0x4000033")]
		Error,
		[Token(Token = "0x4000034")]
		None
	}
	[Token(Token = "0x200001C")]
	public static class HGLogger
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string _prefix;

		[Token(Token = "0x4000036")]
		private const string PrefsKey = "HGLogger_SelectedLoggingLevel";

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static LogLevel? _selectedLogLevel;

		[Token(Token = "0x17000005")]
		public static LogLevel SelectedLoggingLevel
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x18E9184", Offset = "0x18E9184", VA = "0x18E9184")]
			get
			{
				return default(LogLevel);
			}
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x18E928C", Offset = "0x18E928C", VA = "0x18E928C")]
			set
			{
			}
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x18E9330", Offset = "0x18E9330", VA = "0x18E9330")]
		public static void SetGlobalPrefix(string prefix)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x18E72C0", Offset = "0x18E72C0", VA = "0x18E72C0")]
		public static void LogInfo(string message)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x18E74F8", Offset = "0x18E74F8", VA = "0x18E74F8")]
		public static void LogInfo(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x18E94D0", Offset = "0x18E94D0", VA = "0x18E94D0")]
		public static void LogWarn(string message)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x18E95AC", Offset = "0x18E95AC", VA = "0x18E95AC")]
		public static void LogWarn(string format, params object[] args)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x18E8F5C", Offset = "0x18E8F5C", VA = "0x18E8F5C")]
		public static void LogError(string message)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x18E9690", Offset = "0x18E9690", VA = "0x18E9690")]
		public static void LogError(string format, params object[] args)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x18E93D0", Offset = "0x18E93D0", VA = "0x18E93D0")]
		private static bool CanLog(LogLevel level)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x18E9440", Offset = "0x18E9440", VA = "0x18E9440")]
		private static string PrepareMessage(string message)
		{
			return null;
		}
	}
	[Token(Token = "0x200001D")]
	public class Permission
	{
		[Token(Token = "0x4000038")]
		public const string ACCESS_CHECKIN_PROPERTIES = "android.permission.ACCESS_CHECKIN_PROPERTIES";

		[Token(Token = "0x4000039")]
		public const string ACCESS_COARSE_LOCATION = "android.permission.ACCESS_COARSE_LOCATION";

		[Token(Token = "0x400003A")]
		public const string ACCESS_FINE_LOCATION = "android.permission.ACCESS_FINE_LOCATION";

		[Token(Token = "0x400003B")]
		public const string ACCESS_LOCATION_EXTRA_COMMANDS = "android.permission.ACCESS_LOCATION_EXTRA_COMMANDS";

		[Token(Token = "0x400003C")]
		public const string ACCESS_NETWORK_STATE = "android.permission.ACCESS_NETWORK_STATE";

		[Token(Token = "0x400003D")]
		public const string ACCESS_NOTIFICATION_POLICY = "android.permission.ACCESS_NOTIFICATION_POLICY";

		[Token(Token = "0x400003E")]
		public const string ACCESS_WIFI_STATE = "android.permission.ACCESS_WIFI_STATE";

		[Token(Token = "0x400003F")]
		public const string ACCOUNT_MANAGER = "android.permission.ACCOUNT_MANAGER";

		[Token(Token = "0x4000040")]
		public const string ADD_VOICEMAIL = "com.android.voicemail.permission.ADD_VOICEMAIL";

		[Token(Token = "0x4000041")]
		public const string ANSWER_PHONE_CALLS = "android.permission.ANSWER_PHONE_CALLS";

		[Token(Token = "0x4000042")]
		public const string BATTERY_STATS = "android.permission.BATTERY_STATS";

		[Token(Token = "0x4000043")]
		public const string BIND_ACCESSIBILITY_SERVICE = "android.permission.BIND_ACCESSIBILITY_SERVICE";

		[Token(Token = "0x4000044")]
		public const string BIND_APPWIDGET = "android.permission.BIND_APPWIDGET";

		[Token(Token = "0x4000045")]
		public const string BIND_AUTOFILL_SERVICE = "android.permission.BIND_AUTOFILL_SERVICE";

		[Token(Token = "0x4000046")]
		public const string BIND_CARRIER_MESSAGING_SERVICE = "android.permission.BIND_CARRIER_MESSAGING_SERVICE";

		[Token(Token = "0x4000047")]
		public const string BIND_CARRIER_SERVICES = "android.permission.BIND_CARRIER_SERVICES";

		[Token(Token = "0x4000048")]
		public const string BIND_CHOOSER_TARGET_SERVICE = "android.permission.BIND_CHOOSER_TARGET_SERVICE";

		[Token(Token = "0x4000049")]
		public const string BIND_CONDITION_PROVIDER_SERVICE = "android.permission.BIND_CONDITION_PROVIDER_SERVICE";

		[Token(Token = "0x400004A")]
		public const string BIND_DEVICE_ADMIN = "android.permission.BIND_DEVICE_ADMIN";

		[Token(Token = "0x400004B")]
		public const string BIND_DREAM_SERVICE = "android.permission.BIND_DREAM_SERVICE";

		[Token(Token = "0x400004C")]
		public const string BIND_INCALL_SERVICE = "android.permission.BIND_INCALL_SERVICE";

		[Token(Token = "0x400004D")]
		public const string BIND_INPUT_METHOD = "android.permission.BIND_INPUT_METHOD";

		[Token(Token = "0x400004E")]
		public const string BIND_MIDI_DEVICE_SERVICE = "android.permission.BIND_MIDI_DEVICE_SERVICE";

		[Token(Token = "0x400004F")]
		public const string BIND_NFC_SERVICE = "android.permission.BIND_NFC_SERVICE";

		[Token(Token = "0x4000050")]
		public const string BIND_NOTIFICATION_LISTENER_SERVICE = "android.permission.BIND_NOTIFICATION_LISTENER_SERVICE";

		[Token(Token = "0x4000051")]
		public const string BIND_PRINT_SERVICE = "android.permission.BIND_PRINT_SERVICE";

		[Token(Token = "0x4000052")]
		public const string BIND_QUICK_SETTINGS_TILE = "android.permission.BIND_QUICK_SETTINGS_TILE";

		[Token(Token = "0x4000053")]
		public const string BIND_REMOTEVIEWS = "android.permission.BIND_REMOTEVIEWS";

		[Token(Token = "0x4000054")]
		public const string BIND_SCREENING_SERVICE = "android.permission.BIND_SCREENING_SERVICE";

		[Token(Token = "0x4000055")]
		public const string BIND_TELECOM_CONNECTION_SERVICE = "android.permission.BIND_TELECOM_CONNECTION_SERVICE";

		[Token(Token = "0x4000056")]
		public const string BIND_TEXT_SERVICE = "android.permission.BIND_TEXT_SERVICE";

		[Token(Token = "0x4000057")]
		public const string BIND_TV_INPUT = "android.permission.BIND_TV_INPUT";

		[Token(Token = "0x4000058")]
		public const string BIND_VISUAL_VOICEMAIL_SERVICE = "android.permission.BIND_VISUAL_VOICEMAIL_SERVICE";

		[Token(Token = "0x4000059")]
		public const string BIND_VOICE_INTERACTION = "android.permission.BIND_VOICE_INTERACTION";

		[Token(Token = "0x400005A")]
		public const string BIND_VPN_SERVICE = "android.permission.BIND_VPN_SERVICE";

		[Token(Token = "0x400005B")]
		public const string BIND_VR_LISTENER_SERVICE = "android.permission.BIND_VR_LISTENER_SERVICE";

		[Token(Token = "0x400005C")]
		public const string BIND_WALLPAPER = "android.permission.BIND_WALLPAPER";

		[Token(Token = "0x400005D")]
		public const string BLUETOOTH = "android.permission.BLUETOOTH";

		[Token(Token = "0x400005E")]
		public const string BLUETOOTH_ADMIN = "android.permission.BLUETOOTH_ADMIN";

		[Token(Token = "0x400005F")]
		public const string BLUETOOTH_PRIVILEGED = "android.permission.BLUETOOTH_PRIVILEGED";

		[Token(Token = "0x4000060")]
		public const string BODY_SENSORS = "android.permission.BODY_SENSORS";

		[Token(Token = "0x4000061")]
		public const string BROADCAST_PACKAGE_REMOVED = "android.permission.BROADCAST_PACKAGE_REMOVED";

		[Token(Token = "0x4000062")]
		public const string BROADCAST_SMS = "android.permission.BROADCAST_SMS";

		[Token(Token = "0x4000063")]
		public const string BROADCAST_STICKY = "android.permission.BROADCAST_STICKY";

		[Token(Token = "0x4000064")]
		public const string BROADCAST_WAP_PUSH = "android.permission.BROADCAST_WAP_PUSH";

		[Token(Token = "0x4000065")]
		public const string CALL_PHONE = "android.permission.CALL_PHONE";

		[Token(Token = "0x4000066")]
		public const string CALL_PRIVILEGED = "android.permission.CALL_PRIVILEGED";

		[Token(Token = "0x4000067")]
		public const string CAMERA = "android.permission.CAMERA";

		[Token(Token = "0x4000068")]
		public const string CAPTURE_AUDIO_OUTPUT = "android.permission.CAPTURE_AUDIO_OUTPUT";

		[Token(Token = "0x4000069")]
		public const string CAPTURE_SECURE_VIDEO_OUTPUT = "android.permission.CAPTURE_SECURE_VIDEO_OUTPUT";

		[Token(Token = "0x400006A")]
		public const string CAPTURE_VIDEO_OUTPUT = "android.permission.CAPTURE_VIDEO_OUTPUT";

		[Token(Token = "0x400006B")]
		public const string CHANGE_COMPONENT_ENABLED_STATE = "android.permission.CHANGE_COMPONENT_ENABLED_STATE";

		[Token(Token = "0x400006C")]
		public const string CHANGE_CONFIGURATION = "android.permission.CHANGE_CONFIGURATION";

		[Token(Token = "0x400006D")]
		public const string CHANGE_NETWORK_STATE = "android.permission.CHANGE_NETWORK_STATE";

		[Token(Token = "0x400006E")]
		public const string CHANGE_WIFI_MULTICAST_STATE = "android.permission.CHANGE_WIFI_MULTICAST_STATE";

		[Token(Token = "0x400006F")]
		public const string CHANGE_WIFI_STATE = "android.permission.CHANGE_WIFI_STATE";

		[Token(Token = "0x4000070")]
		public const string CLEAR_APP_CACHE = "android.permission.CLEAR_APP_CACHE";

		[Token(Token = "0x4000071")]
		public const string CONTROL_LOCATION_UPDATES = "android.permission.CONTROL_LOCATION_UPDATES";

		[Token(Token = "0x4000072")]
		public const string DELETE_CACHE_FILES = "android.permission.DELETE_CACHE_FILES";

		[Token(Token = "0x4000073")]
		public const string DELETE_PACKAGES = "android.permission.DELETE_PACKAGES";

		[Token(Token = "0x4000074")]
		public const string DIAGNOSTIC = "android.permission.DIAGNOSTIC";

		[Token(Token = "0x4000075")]
		public const string DISABLE_KEYGUARD = "android.permission.DISABLE_KEYGUARD";

		[Token(Token = "0x4000076")]
		public const string DUMP = "android.permission.DUMP";

		[Token(Token = "0x4000077")]
		public const string EXPAND_STATUS_BAR = "android.permission.EXPAND_STATUS_BAR";

		[Token(Token = "0x4000078")]
		public const string FACTORY_TEST = "android.permission.FACTORY_TEST";

		[Token(Token = "0x4000079")]
		public const string GET_ACCOUNTS = "android.permission.GET_ACCOUNTS";

		[Token(Token = "0x400007A")]
		public const string GET_ACCOUNTS_PRIVILEGED = "android.permission.GET_ACCOUNTS_PRIVILEGED";

		[Token(Token = "0x400007B")]
		public const string GET_PACKAGE_SIZE = "android.permission.GET_PACKAGE_SIZE";

		[Token(Token = "0x400007C")]
		public const string GET_TASKS = "android.permission.GET_TASKS";

		[Token(Token = "0x400007D")]
		public const string GLOBAL_SEARCH = "android.permission.GLOBAL_SEARCH";

		[Token(Token = "0x400007E")]
		public const string INSTALL_LOCATION_PROVIDER = "android.permission.INSTALL_LOCATION_PROVIDER";

		[Token(Token = "0x400007F")]
		public const string INSTALL_PACKAGES = "android.permission.INSTALL_PACKAGES";

		[Token(Token = "0x4000080")]
		public const string INSTALL_SHORTCUT = "com.android.launcher.permission.INSTALL_SHORTCUT";

		[Token(Token = "0x4000081")]
		public const string INSTANT_APP_FOREGROUND_SERVICE = "android.permission.INSTANT_APP_FOREGROUND_SERVICE";

		[Token(Token = "0x4000082")]
		public const string INTERNET = "android.permission.INTERNET";

		[Token(Token = "0x4000083")]
		public const string KILL_BACKGROUND_PROCESSES = "android.permission.KILL_BACKGROUND_PROCESSES";

		[Token(Token = "0x4000084")]
		public const string LOCATION_HARDWARE = "android.permission.LOCATION_HARDWARE";

		[Token(Token = "0x4000085")]
		public const string MANAGE_DOCUMENTS = "android.permission.MANAGE_DOCUMENTS";

		[Token(Token = "0x4000086")]
		public const string MANAGE_OWN_CALLS = "android.permission.MANAGE_OWN_CALLS";

		[Token(Token = "0x4000087")]
		public const string MASTER_CLEAR = "android.permission.MASTER_CLEAR";

		[Token(Token = "0x4000088")]
		public const string MEDIA_CONTENT_CONTROL = "android.permission.MEDIA_CONTENT_CONTROL";

		[Token(Token = "0x4000089")]
		public const string MODIFY_AUDIO_SETTINGS = "android.permission.MODIFY_AUDIO_SETTINGS";

		[Token(Token = "0x400008A")]
		public const string MODIFY_PHONE_STATE = "android.permission.MODIFY_PHONE_STATE";

		[Token(Token = "0x400008B")]
		public const string MOUNT_FORMAT_FILESYSTEMS = "android.permission.MOUNT_FORMAT_FILESYSTEMS";

		[Token(Token = "0x400008C")]
		public const string MOUNT_UNMOUNT_FILESYSTEMS = "android.permission.MOUNT_UNMOUNT_FILESYSTEMS";

		[Token(Token = "0x400008D")]
		public const string NFC = "android.permission.NFC";

		[Token(Token = "0x400008E")]
		public const string PACKAGE_USAGE_STATS = "android.permission.PACKAGE_USAGE_STATS";

		[Token(Token = "0x400008F")]
		public const string PERSISTENT_ACTIVITY = "android.permission.PERSISTENT_ACTIVITY";

		[Token(Token = "0x4000090")]
		public const string PROCESS_OUTGOING_CALLS = "android.permission.PROCESS_OUTGOING_CALLS";

		[Token(Token = "0x4000091")]
		public const string READ_CALENDAR = "android.permission.READ_CALENDAR";

		[Token(Token = "0x4000092")]
		public const string READ_CALL_LOG = "android.permission.READ_CALL_LOG";

		[Token(Token = "0x4000093")]
		public const string READ_CONTACTS = "android.permission.READ_CONTACTS";

		[Token(Token = "0x4000094")]
		public const string READ_EXTERNAL_STORAGE = "android.permission.READ_EXTERNAL_STORAGE";

		[Token(Token = "0x4000095")]
		public const string READ_FRAME_BUFFER = "android.permission.READ_FRAME_BUFFER";

		[Token(Token = "0x4000096")]
		public const string READ_INPUT_STATE = "android.permission.READ_INPUT_STATE";

		[Token(Token = "0x4000097")]
		public const string READ_LOGS = "android.permission.READ_LOGS";

		[Token(Token = "0x4000098")]
		public const string READ_PHONE_NUMBERS = "android.permission.READ_PHONE_NUMBERS";

		[Token(Token = "0x4000099")]
		public const string READ_PHONE_STATE = "android.permission.READ_PHONE_STATE";

		[Token(Token = "0x400009A")]
		public const string READ_SMS = "android.permission.READ_SMS";

		[Token(Token = "0x400009B")]
		public const string READ_SYNC_SETTINGS = "android.permission.READ_SYNC_SETTINGS";

		[Token(Token = "0x400009C")]
		public const string READ_SYNC_STATS = "android.permission.READ_SYNC_STATS";

		[Token(Token = "0x400009D")]
		public const string READ_VOICEMAIL = "com.android.voicemail.permission.READ_VOICEMAIL";

		[Token(Token = "0x400009E")]
		public const string REBOOT = "android.permission.REBOOT";

		[Token(Token = "0x400009F")]
		public const string RECEIVE_BOOT_COMPLETED = "android.permission.RECEIVE_BOOT_COMPLETED";

		[Token(Token = "0x40000A0")]
		public const string RECEIVE_MMS = "android.permission.RECEIVE_MMS";

		[Token(Token = "0x40000A1")]
		public const string RECEIVE_SMS = "android.permission.RECEIVE_SMS";

		[Token(Token = "0x40000A2")]
		public const string RECEIVE_WAP_PUSH = "android.permission.RECEIVE_WAP_PUSH";

		[Token(Token = "0x40000A3")]
		public const string RECORD_AUDIO = "android.permission.RECORD_AUDIO";

		[Token(Token = "0x40000A4")]
		public const string REORDER_TASKS = "android.permission.REORDER_TASKS";

		[Token(Token = "0x40000A5")]
		public const string REQUEST_COMPANION_RUN_IN_BACKGROUND = "android.permission.REQUEST_COMPANION_RUN_IN_BACKGROUND";

		[Token(Token = "0x40000A6")]
		public const string REQUEST_COMPANION_USE_DATA_IN_BACKGROUND = "android.permission.REQUEST_COMPANION_USE_DATA_IN_BACKGROUND";

		[Token(Token = "0x40000A7")]
		public const string REQUEST_DELETE_PACKAGES = "android.permission.REQUEST_DELETE_PACKAGES";

		[Token(Token = "0x40000A8")]
		public const string REQUEST_IGNORE_BATTERY_OPTIMIZATIONS = "android.permission.REQUEST_IGNORE_BATTERY_OPTIMIZATIONS";

		[Token(Token = "0x40000A9")]
		public const string REQUEST_INSTALL_PACKAGES = "android.permission.REQUEST_INSTALL_PACKAGES";

		[Token(Token = "0x40000AA")]
		public const string RESTART_PACKAGES = "android.permission.RESTART_PACKAGES";

		[Token(Token = "0x40000AB")]
		public const string SEND_RESPOND_VIA_MESSAGE = "android.permission.SEND_RESPOND_VIA_MESSAGE";

		[Token(Token = "0x40000AC")]
		public const string SEND_SMS = "android.permission.SEND_SMS";

		[Token(Token = "0x40000AD")]
		public const string SET_ALARM = "com.android.alarm.permission.SET_ALARM";

		[Token(Token = "0x40000AE")]
		public const string SET_ALWAYS_FINISH = "android.permission.SET_ALWAYS_FINISH";

		[Token(Token = "0x40000AF")]
		public const string SET_ANIMATION_SCALE = "android.permission.SET_ANIMATION_SCALE";

		[Token(Token = "0x40000B0")]
		public const string SET_DEBUG_APP = "android.permission.SET_DEBUG_APP";

		[Token(Token = "0x40000B1")]
		public const string SET_PREFERRED_APPLICATIONS = "android.permission.SET_PREFERRED_APPLICATIONS";

		[Token(Token = "0x40000B2")]
		public const string SET_PROCESS_LIMIT = "android.permission.SET_PROCESS_LIMIT";

		[Token(Token = "0x40000B3")]
		public const string SET_TIME = "android.permission.SET_TIME";

		[Token(Token = "0x40000B4")]
		public const string SET_TIME_ZONE = "android.permission.SET_TIME_ZONE";

		[Token(Token = "0x40000B5")]
		public const string SET_WALLPAPER = "android.permission.SET_WALLPAPER";

		[Token(Token = "0x40000B6")]
		public const string SET_WALLPAPER_HINTS = "android.permission.SET_WALLPAPER_HINTS";

		[Token(Token = "0x40000B7")]
		public const string SIGNAL_PERSISTENT_PROCESSES = "android.permission.SIGNAL_PERSISTENT_PROCESSES";

		[Token(Token = "0x40000B8")]
		public const string STATUS_BAR = "android.permission.STATUS_BAR";

		[Token(Token = "0x40000B9")]
		public const string SYSTEM_ALERT_WINDOW = "android.permission.SYSTEM_ALERT_WINDOW";

		[Token(Token = "0x40000BA")]
		public const string TRANSMIT_IR = "android.permission.TRANSMIT_IR";

		[Token(Token = "0x40000BB")]
		public const string UNINSTALL_SHORTCUT = "com.android.launcher.permission.UNINSTALL_SHORTCUT";

		[Token(Token = "0x40000BC")]
		public const string UPDATE_DEVICE_STATS = "android.permission.UPDATE_DEVICE_STATS";

		[Token(Token = "0x40000BD")]
		public const string USE_FINGERPRINT = "android.permission.USE_FINGERPRINT";

		[Token(Token = "0x40000BE")]
		public const string USE_SIP = "android.permission.USE_SIP";

		[Token(Token = "0x40000BF")]
		public const string VIBRATE = "android.permission.VIBRATE";

		[Token(Token = "0x40000C0")]
		public const string WAKE_LOCK = "android.permission.WAKE_LOCK";

		[Token(Token = "0x40000C1")]
		public const string WRITE_APN_SETTINGS = "android.permission.WRITE_APN_SETTINGS";

		[Token(Token = "0x40000C2")]
		public const string WRITE_CALENDAR = "android.permission.WRITE_CALENDAR";

		[Token(Token = "0x40000C3")]
		public const string WRITE_CALL_LOG = "android.permission.WRITE_CALL_LOG";

		[Token(Token = "0x40000C4")]
		public const string WRITE_CONTACTS = "android.permission.WRITE_CONTACTS";

		[Token(Token = "0x40000C5")]
		public const string WRITE_EXTERNAL_STORAGE = "android.permission.WRITE_EXTERNAL_STORAGE";

		[Token(Token = "0x40000C6")]
		public const string WRITE_GSERVICES = "android.permission.WRITE_GSERVICES";

		[Token(Token = "0x40000C7")]
		public const string WRITE_SECURE_SETTINGS = "android.permission.WRITE_SECURE_SETTINGS";

		[Token(Token = "0x40000C8")]
		public const string WRITE_SETTINGS = "android.permission.WRITE_SETTINGS";

		[Token(Token = "0x40000C9")]
		public const string WRITE_SYNC_SETTINGS = "android.permission.WRITE_SYNC_SETTINGS";

		[Token(Token = "0x40000CA")]
		public const string WRITE_VOICEMAIL = "com.android.voicemail.permission.WRITE_VOICEMAIL";

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x18E9B68", Offset = "0x18E9B68", VA = "0x18E9B68")]
		public Permission()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public static class PermissionManager
	{
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x18E9B70", Offset = "0x18E9B70", VA = "0x18E9B70")]
		public static bool IsPermissionGranted(string permissionName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x18E9C1C", Offset = "0x18E9C1C", VA = "0x18E9C1C")]
		public static void RequestPermission(string permissionName, [Optional] Action<string> OnPermissionGranted, [Optional] Action<string> OnPermissionDenied)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x18E9CE4", Offset = "0x18E9CE4", VA = "0x18E9CE4")]
		public static bool IsPlatformSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x18E9D8C", Offset = "0x18E9D8C", VA = "0x18E9D8C")]
		public static bool ShouldShowRequestPermissionRationale(string permissionName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x18E9E3C", Offset = "0x18E9E3C", VA = "0x18E9E3C")]
		public static void OpenNativeSettings()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public interface ICollectionManipulator : IDisposable
	{
		[Token(Token = "0x14000006")]
		event Action OnRefreshRequired;
	}
	[Token(Token = "0x2000020")]
	public interface IPermissionInfo
	{
		[Token(Token = "0x17000006")]
		string FullName
		{
			[Token(Token = "0x6000098")]
			get;
			[Token(Token = "0x6000099")]
			set;
		}

		[Token(Token = "0x17000007")]
		bool IsDangerous
		{
			[Token(Token = "0x600009A")]
			get;
		}

		[Token(Token = "0x17000008")]
		string Description
		{
			[Token(Token = "0x600009B")]
			get;
			[Token(Token = "0x600009C")]
			set;
		}

		[Token(Token = "0x17000009")]
		bool IsNormal
		{
			[Token(Token = "0x600009D")]
			get;
			[Token(Token = "0x600009E")]
			set;
		}

		[Token(Token = "0x600009F")]
		string GetShortName();

		[Token(Token = "0x60000A0")]
		bool Equals(string name);
	}
	[Token(Token = "0x2000021")]
	public enum AddPermissionResult
	{
		[Token(Token = "0x40000CC")]
		OK,
		[Token(Token = "0x40000CD")]
		AlreadyExists,
		[Token(Token = "0x40000CE")]
		Invalid
	}
	[Token(Token = "0x2000022")]
	public interface IPermissionsManipulator : ICollectionManipulator, IDisposable
	{
		[Token(Token = "0x60000A1")]
		IEnumerable<IPermissionInfo> GetAllPermissions();

		[Token(Token = "0x60000A2")]
		void RemovePermission(IPermissionInfo permission);

		[Token(Token = "0x60000A3")]
		AddPermissionResult AddPermission(string text);
	}
	[Token(Token = "0x2000023")]
	public interface ISkipPermissionsDialogManipulator : ICollectionManipulator, IDisposable
	{
		[Token(Token = "0x60000A4")]
		bool IsPermissionDialogsSkipped();

		[Token(Token = "0x60000A5")]
		void RemoveSkipPermissionDialog();

		[Token(Token = "0x60000A6")]
		void AddSkipPermissionDialog();
	}
	[Token(Token = "0x2000024")]
	public class DataHolder
	{
		[Token(Token = "0x2000043")]
		public class Permission
		{
			[Token(Token = "0x4000107")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Category;

			[Token(Token = "0x4000108")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string ShortName;

			[Token(Token = "0x4000109")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string Description;

			[Token(Token = "0x400010A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string FullName;

			[Token(Token = "0x400010B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string ProtectionLevel;

			[Token(Token = "0x600012F")]
			[Address(RVA = "0x18E74A0", Offset = "0x18E74A0", VA = "0x18E74A0")]
			public bool IsDangerous()
			{
				return default(bool);
			}

			[Token(Token = "0x6000130")]
			[Address(RVA = "0x18ED0FC", Offset = "0x18ED0FC", VA = "0x18ED0FC")]
			public bool IsNormal()
			{
				return default(bool);
			}

			[Token(Token = "0x6000131")]
			[Address(RVA = "0x18E90C4", Offset = "0x18E90C4", VA = "0x18E90C4")]
			public Permission()
			{
			}
		}

		[Token(Token = "0x2000044")]
		public class PermissionsData
		{
			[Token(Token = "0x2000046")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91D8EC", Offset = "0x91D8EC")]
			private sealed class <>c__DisplayClass2_0
			{
				[Token(Token = "0x4000116")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string shortName;

				[Token(Token = "0x6000140")]
				[Address(RVA = "0x18ED260", Offset = "0x18ED260", VA = "0x18ED260")]
				public <>c__DisplayClass2_0()
				{
				}

				[Token(Token = "0x6000141")]
				[Address(RVA = "0x18ED58C", Offset = "0x18ED58C", VA = "0x18ED58C")]
				internal bool <FindPermissionByShortName>b__0(Permission p)
				{
					return default(bool);
				}
			}

			[Token(Token = "0x2000047")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91D8FC", Offset = "0x91D8FC")]
			private sealed class <>c__DisplayClass3_0
			{
				[Token(Token = "0x4000117")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string fullName;

				[Token(Token = "0x6000142")]
				[Address(RVA = "0x18ED268", Offset = "0x18ED268", VA = "0x18ED268")]
				public <>c__DisplayClass3_0()
				{
				}

				[Token(Token = "0x6000143")]
				[Address(RVA = "0x18ED5B4", Offset = "0x18ED5B4", VA = "0x18ED5B4")]
				internal bool <FindPermissionByFullName>b__0(Permission p)
				{
					return default(bool);
				}
			}

			[Token(Token = "0x2000048")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91D90C", Offset = "0x91D90C")]
			private sealed class <>c__DisplayClass4_0
			{
				[Token(Token = "0x4000118")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string categoryName;

				[Token(Token = "0x6000144")]
				[Address(RVA = "0x18ED374", Offset = "0x18ED374", VA = "0x18ED374")]
				public <>c__DisplayClass4_0()
				{
				}

				[Token(Token = "0x6000145")]
				[Address(RVA = "0x18ED5DC", Offset = "0x18ED5DC", VA = "0x18ED5DC")]
				internal bool <FindPermissionsByCategory>b__0(Permission p)
				{
					return default(bool);
				}
			}

			[Token(Token = "0x400010C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Permission> AllPermissions;

			[Token(Token = "0x6000132")]
			[Address(RVA = "0x18ED154", Offset = "0x18ED154", VA = "0x18ED154")]
			public List<Permission> GetAllPermissions()
			{
				return null;
			}

			[Token(Token = "0x6000133")]
			[Address(RVA = "0x18ED15C", Offset = "0x18ED15C", VA = "0x18ED15C")]
			public Permission FindPermissionByShortName(string shortName)
			{
				return null;
			}

			[Token(Token = "0x6000134")]
			[Address(RVA = "0x18E739C", Offset = "0x18E739C", VA = "0x18E739C")]
			public Permission FindPermissionByFullName(string fullName)
			{
				return null;
			}

			[Token(Token = "0x6000135")]
			[Address(RVA = "0x18ED270", Offset = "0x18ED270", VA = "0x18ED270")]
			public IList<Permission> FindPermissionsByCategory(string categoryName)
			{
				return null;
			}

			[Token(Token = "0x6000136")]
			[Address(RVA = "0x18E9038", Offset = "0x18E9038", VA = "0x18E9038")]
			public PermissionsData()
			{
			}
		}

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PermissionsData Permissions;

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x18E850C", Offset = "0x18E850C", VA = "0x18E850C")]
		public DataHolder()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class DataHolderFactory
	{
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x18E8514", Offset = "0x18E8514", VA = "0x18E8514")]
		public static DataHolder CreateData()
		{
			return null;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x18E8848", Offset = "0x18E8848", VA = "0x18E8848")]
		private static XmlDocument GetXml()
		{
			return null;
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x18E89AC", Offset = "0x18E89AC", VA = "0x18E89AC")]
		private static DataHolder.PermissionsData GetPermissionsData(XmlNode node)
		{
			return null;
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x18E90E4", Offset = "0x18E90E4", VA = "0x18E90E4")]
		public DataHolderFactory()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public enum PermissionState
	{
		[Token(Token = "0x40000D1")]
		NotRequested,
		[Token(Token = "0x40000D2")]
		DeniedOnce,
		[Token(Token = "0x40000D3")]
		DeniedDontAskAgain,
		[Token(Token = "0x40000D4")]
		Granted
	}
	[Serializable]
	[Token(Token = "0x2000027")]
	public class PermissionsState : SerializableDictionary<string, PermissionState>
	{
		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DataHolder.PermissionsData _permisstionsData;

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x18EA5D8", Offset = "0x18EA5D8", VA = "0x18EA5D8")]
		public PermissionsState()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x18EA7A0", Offset = "0x18EA7A0", VA = "0x18EA7A0")]
		public void Init(DataHolder.PermissionsData permissionsData)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x18EA7A8", Offset = "0x18EA7A8", VA = "0x18EA7A8")]
		private void OnPlayModeStateChanged()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x18EA86C", Offset = "0x18EA86C", VA = "0x18EA86C", Slot = "7")]
		public override void Set(string permissionName, PermissionState value)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x18EA908", Offset = "0x18EA908", VA = "0x18EA908", Slot = "8")]
		public override PermissionState Get(string permissionName, PermissionState defaultValue = PermissionState.NotRequested)
		{
			return default(PermissionState);
		}
	}
	[Token(Token = "0x2000028")]
	public class PermissionsStateScriptable : ScriptableObject
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PermissionsState PermissionsState;

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x18EA9A4", Offset = "0x18EA9A4", VA = "0x18EA9A4")]
		public void Init(DataHolder.PermissionsData permissionsData)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x18EA9C4", Offset = "0x18EA9C4", VA = "0x18EA9C4")]
		public void Save()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x18EA9CC", Offset = "0x18EA9CC", VA = "0x18EA9CC")]
		public PermissionsStateScriptable()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class SerializableDictionary<TKey, TValue> : IDisposable where TKey : IComparable
	{
		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TKey> _keys;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TValue> _values;

		[Token(Token = "0x1700000A")]
		public IEnumerable<TKey> Keys
		{
			[Token(Token = "0x60000B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		public IEnumerable<TValue> Values
		{
			[Token(Token = "0x60000B9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000007")]
		public event Action<TKey> OnValueChanged
		{
			[Token(Token = "0x60000B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DBBC", Offset = "0x91DBBC")]
			add
			{
			}
			[Token(Token = "0x60000B5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DBCC", Offset = "0x91DBCC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event Action OnDictionaryChanged
		{
			[Token(Token = "0x60000B6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DBDC", Offset = "0x91DBDC")]
			add
			{
			}
			[Token(Token = "0x60000B7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DBEC", Offset = "0x91DBEC")]
			remove
			{
			}
		}

		[Token(Token = "0x60000BA")]
		public virtual void Set(TKey key, TValue value)
		{
		}

		[Token(Token = "0x60000BB")]
		public virtual TValue Get(TKey key, [Optional] TValue defaultValue)
		{
			return (TValue)null;
		}

		[Token(Token = "0x60000BC")]
		public void Remove(TKey key)
		{
		}

		[Token(Token = "0x60000BD")]
		private int GetKeyIndex(TKey key)
		{
			return default(int);
		}

		[Token(Token = "0x60000BE")]
		public void Clear()
		{
		}

		[Token(Token = "0x60000BF")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60000C0")]
		public SerializableDictionary()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public interface ISettings
	{
		[Token(Token = "0x14000009")]
		event Action<string> OnValueChanged;

		[Token(Token = "0x60000C3")]
		string Get(string key, [Optional] string defaultValue);

		[Token(Token = "0x60000C4")]
		int GetInt(string key, int defaultValue = 0);

		[Token(Token = "0x60000C5")]
		bool GetBool(string key, bool defaultValue = false);
	}
	[Serializable]
	[Token(Token = "0x200002B")]
	public class Settings : SerializableDictionary<string, string>, ISettings
	{
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x18EB2B0", Offset = "0x18EB2B0", VA = "0x18EB2B0", Slot = "12")]
		public int GetInt(string key, int defaultValue = 0)
		{
			return default(int);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x18EB300", Offset = "0x18EB300", VA = "0x18EB300")]
		public void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x18EB350", Offset = "0x18EB350", VA = "0x18EB350", Slot = "13")]
		public bool GetBool(string key, bool defaultValue = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x18EB40C", Offset = "0x18EB40C", VA = "0x18EB40C")]
		public void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x18EB460", Offset = "0x18EB460", VA = "0x18EB460")]
		public Settings()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class SettingsHolder : Singleton<SettingsHolder>
	{
		[Token(Token = "0x40000DB")]
		private const string SettingsFilename = "ManifestSettings";

		[Token(Token = "0x40000DC")]
		private const string PermissionsStateFilename = "PermissionsState";

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private SettingsScriptableObject loadedSettings;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Settings _settings;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TestingSettings _testingSettings;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PermissionsStateScriptable permissionsState;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PermissionsState _permissionsState;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private DataHolder _dataHolder;

		[Token(Token = "0x1700000C")]
		public TestingSettings TestingSettings
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x18EB4B4", Offset = "0x18EB4B4", VA = "0x18EB4B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		public PermissionsState PermissionsState
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x18EB4BC", Offset = "0x18EB4BC", VA = "0x18EB4BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x18EB4C4", Offset = "0x18EB4C4", VA = "0x18EB4C4")]
		public SettingsHolder()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x18EB82C", Offset = "0x18EB82C", VA = "0x18EB82C")]
		public DataHolder GetDataHolder()
		{
			return null;
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x18EB868", Offset = "0x18EB868", VA = "0x18EB868")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x18EB984", Offset = "0x18EB984", VA = "0x18EB984")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DC1C", Offset = "0x91DC1C")]
		private void <.ctor>b__12_0()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x18EB9A4", Offset = "0x18EB9A4", VA = "0x18EB9A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DC2C", Offset = "0x91DC2C")]
		private void <.ctor>b__12_1()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class SettingsScriptableObject : ScriptableObject
	{
		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Settings setttings;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x18EB9A0", Offset = "0x18EB9A0", VA = "0x18EB9A0")]
		public void Save()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x18EB9C0", Offset = "0x18EB9C0", VA = "0x18EB9C0")]
		public SettingsScriptableObject()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class TestingSettings : IDisposable
	{
		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Settings _settings;

		[Token(Token = "0x40000E5")]
		private const string _TestingEnabled = "TestingEnabled";

		[Token(Token = "0x40000E6")]
		private const string _TestingApiLevel = "TestingApiLevel";

		[Token(Token = "0x40000E7")]
		private const string _TestingStorePersistently = "TestingStorePersistent";

		[Token(Token = "0x1700000E")]
		public bool TestingEnabled
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x18EA80C", Offset = "0x18EA80C", VA = "0x18EA80C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x18EC01C", Offset = "0x18EC01C", VA = "0x18EC01C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public int TestingApiLevel
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x18EC0A8", Offset = "0x18EC0A8", VA = "0x18EC0A8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x18EC100", Offset = "0x18EC100", VA = "0x18EC100")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public bool TestingStorePersistently
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x18EA814", Offset = "0x18EA814", VA = "0x18EA814")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x18EC188", Offset = "0x18EC188", VA = "0x18EC188")]
			set
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event Action OnTestingEnabledChanged
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x18E7D90", Offset = "0x18E7D90", VA = "0x18E7D90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DC3C", Offset = "0x91DC3C")]
			add
			{
			}
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x18E7C50", Offset = "0x18E7C50", VA = "0x18E7C50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DC4C", Offset = "0x91DC4C")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event Action OnTestingApiLevelChanged
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x18E7E30", Offset = "0x18E7E30", VA = "0x18E7E30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DC5C", Offset = "0x91DC5C")]
			add
			{
			}
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x18E7CF0", Offset = "0x18E7CF0", VA = "0x18E7CF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DC6C", Offset = "0x91DC6C")]
			remove
			{
			}
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x18EB744", Offset = "0x18EB744", VA = "0x18EB744")]
		public TestingSettings(Settings settings)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x18EC214", Offset = "0x18EC214", VA = "0x18EC214")]
		private void OnValueChanged(string s)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x18EC2C8", Offset = "0x18EC2C8", VA = "0x18EC2C8")]
		public void Clear()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x18EB914", Offset = "0x18EB914", VA = "0x18EB914", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace HG.General
{
	[Token(Token = "0x200002F")]
	public class PlayModeDetector
	{
		[Token(Token = "0x1400000C")]
		public static event Action OnPlayModeStateChanged
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x18EA6AC", Offset = "0x18EA6AC", VA = "0x18EA6AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DC7C", Offset = "0x91DC7C")]
			add
			{
			}
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x18EAA40", Offset = "0x18EAA40", VA = "0x18EAA40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DC8C", Offset = "0x91DC8C")]
			remove
			{
			}
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x18EAB34", Offset = "0x18EAB34", VA = "0x18EAB34")]
		static PlayModeDetector()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x18EAB38", Offset = "0x18EAB38", VA = "0x18EAB38")]
		public PlayModeDetector()
		{
		}
	}
}
namespace HG.Extensions
{
	[Token(Token = "0x2000030")]
	public static class ActionExtension
	{
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x18E50F0", Offset = "0x18E50F0", VA = "0x18E50F0")]
		public static void InvokeSafe(this Action action)
		{
		}

		[Token(Token = "0x60000E7")]
		public static void InvokeSafe<T1>(this Action<T1> action, T1 value)
		{
		}

		[Token(Token = "0x60000E8")]
		public static void InvokeSafe<T1, T2>(this Action<T1, T2> action, T1 value1, T2 value2)
		{
		}
	}
	[Token(Token = "0x2000031")]
	public static class CollectionExtensions
	{
		[Token(Token = "0x2000045")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91D8DC", Offset = "0x91D8DC")]
		private sealed class <DistinctBy>d__0<TSource, TKey> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400010D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400010E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TSource <>2__current;

			[Token(Token = "0x400010F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000110")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IEnumerable<TSource> source;

			[Token(Token = "0x4000111")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IEnumerable<TSource> <>3__source;

			[Token(Token = "0x4000112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Func<TSource, TKey> keySelector;

			[Token(Token = "0x4000113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<TSource, TKey> <>3__keySelector;

			[Token(Token = "0x4000114")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private HashSet<TKey> <seenKeys>5__2;

			[Token(Token = "0x4000115")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IEnumerator<TSource> <>7__wrap2;

			[Token(Token = "0x17000018")]
			private TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[Token(Token = "0x600013B")]
				[DebuggerHidden]
				get
				{
					return (TSource)null;
				}
			}

			[Token(Token = "0x17000019")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600013D")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000137")]
			[DebuggerHidden]
			public <DistinctBy>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000138")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000139")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600013A")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600013C")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600013E")]
			[DebuggerHidden]
			private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600013F")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x60000E9")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x91DCCC", Offset = "0x91DCCC")]
		public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		[Token(Token = "0x60000EA")]
		public static bool IsNullOrEmpty<T>(this IList<T> list)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EB")]
		public static void ForEach<T>(this IList<T> list, Action<T> action)
		{
		}
	}
	[Token(Token = "0x2000032")]
	public static class StringExtensions
	{
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x18EBA34", Offset = "0x18EBA34", VA = "0x18EBA34")]
		public static string RemoveEndSubStr(this string inputText, string toRemove)
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x18EBA9C", Offset = "0x18EBA9C", VA = "0x18EBA9C")]
		public static string RemoveStartSubStr(this string inputText, string toRemove)
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x18EBAF8", Offset = "0x18EBAF8", VA = "0x18EBAF8")]
		public static bool StartsWithAny(this string text, params string[] options)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x18EBB88", Offset = "0x18EBB88", VA = "0x18EBB88")]
		public static bool EndsWithAny(this string text, params string[] options)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x18E76D8", Offset = "0x18E76D8", VA = "0x18E76D8")]
		public static bool IsNullOrEmpty(this string text)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x18EBC18", Offset = "0x18EBC18", VA = "0x18EBC18")]
		public static void Clear(this StringBuilder value)
		{
		}
	}
	[Token(Token = "0x2000033")]
	public static class XmlExtensions
	{
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x18E90CC", Offset = "0x18E90CC", VA = "0x18E90CC")]
		public static string StringOrDefault(this XmlAttribute attr, [Optional] string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x18EC898", Offset = "0x18EC898", VA = "0x18EC898")]
		public static bool BoolOrDefault(this XmlAttribute attr, bool defaultValue = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x18EC944", Offset = "0x18EC944", VA = "0x18EC944")]
		public static string ToPrettyXml(this XmlDocument document)
		{
			return null;
		}
	}
}
namespace HG.Collections
{
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x91D7DC", Offset = "0x91D7DC")]
	public class ImmutableList<T> : IReadOnlyList<T>, IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IList<T> _list;

		[Token(Token = "0x17000011")]
		public int Count
		{
			[Token(Token = "0x60000F9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000012")]
		public T Item
		{
			[Token(Token = "0x60000FA")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x60000F5")]
		public ImmutableList(IList<T> list)
		{
		}

		[Token(Token = "0x60000F6")]
		public static ImmutableList<T> Empty()
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		public static implicit operator ImmutableList<T>(List<T> l)
		{
			return null;
		}
	}
	[Token(Token = "0x2000035")]
	public static class ImmutableExtensions
	{
		[Token(Token = "0x60000FC")]
		public static IReadOnlyCollection<T> ToReadonlyCollection<T>(this IList<T> list)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		public static IReadOnlyList<T> ToReadonlyList<T>(this IList<T> list)
		{
			return null;
		}
	}
	[Token(Token = "0x2000036")]
	public interface IReadOnlyCollection<T> : IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x17000013")]
		int Count
		{
			[Token(Token = "0x60000FE")]
			get;
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x91D824", Offset = "0x91D824")]
	public interface IReadOnlyList<T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x17000014")]
		T Item
		{
			[Token(Token = "0x60000FF")]
			get;
		}
	}
	[Token(Token = "0x2000038")]
	public interface IReadOnlyReactiveCollection<T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x1400000D")]
		event Action<T> Removed;

		[Token(Token = "0x1400000E")]
		event Action<T> Added;
	}
	[Token(Token = "0x2000039")]
	public class ReactiveList<T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable, ICollection<T>, IReadOnlyReactiveCollection<T>
	{
		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<T> _list;

		[Token(Token = "0x17000015")]
		public int Count
		{
			[Token(Token = "0x6000110")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000016")]
		private bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[Token(Token = "0x6000111")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000017")]
		private int HG.Collections.IReadOnlyCollection<T>.Count
		{
			[Token(Token = "0x6000112")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1400000F")]
		public event Action<T> Removed
		{
			[Token(Token = "0x6000104")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DE54", Offset = "0x91DE54")]
			add
			{
			}
			[Token(Token = "0x6000105")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DE64", Offset = "0x91DE64")]
			remove
			{
			}
		}

		[Token(Token = "0x14000010")]
		public event Action<T> Added
		{
			[Token(Token = "0x6000106")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DE74", Offset = "0x91DE74")]
			add
			{
			}
			[Token(Token = "0x6000107")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x91DE84", Offset = "0x91DE84")]
			remove
			{
			}
		}

		[Token(Token = "0x6000108")]
		public ReactiveList(List<T> list)
		{
		}

		[Token(Token = "0x6000109")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600010A")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600010B")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x600010C")]
		public void Clear()
		{
		}

		[Token(Token = "0x600010D")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x600010E")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x600010F")]
		public bool Remove(T item)
		{
			return default(bool);
		}
	}
}
