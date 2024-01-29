using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using Il2CppDummyDll;
using Jundroo.SimplePlanes.ModTools;
using Jundroo.SimplePlanes.ModTools.Interfaces.Parts;
using SPModSettings;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class Extensions
{
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F28C", Offset = "0xA6F28C")]
	private sealed class <>c__DisplayClass10_0<T>
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Predicate<T>[] args;

		[Token(Token = "0x600000D")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x600000E")]
		internal bool <And>b__0(T item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F29C", Offset = "0xA6F29C")]
	private sealed class <>c__DisplayClass11_0<T>
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Predicate<T>[] args;

		[Token(Token = "0x600000F")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x6000010")]
		internal bool <Or>b__0(T item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x24F5408", Offset = "0x24F5408", VA = "0x24F5408")]
	public static string GetAttribute(this XElement element, XName name, [Optional] string def)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x24F5440", Offset = "0x24F5440", VA = "0x24F5440")]
	public static int GetIntAttribute(this XElement element, XName name, int def = 0)
	{
		return default(int);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x24F5484", Offset = "0x24F5484", VA = "0x24F5484")]
	public static float GetFloatAttribute(this XElement element, XName name, float def = 0f)
	{
		return default(float);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x24F54C8", Offset = "0x24F54C8", VA = "0x24F54C8")]
	public static Vector2 GetVector2Attribute(this XElement element, XName name, [Optional] Vector2 def)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x24F5624", Offset = "0x24F5624", VA = "0x24F5624")]
	public static bool Vector2TryParse(string st, out Vector2 v)
	{
		return default(bool);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x24F575C", Offset = "0x24F575C", VA = "0x24F575C")]
	public static Vector3 GetVector3Attribute(this XElement element, XName name, [Optional] Vector3 def)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x24F58F8", Offset = "0x24F58F8", VA = "0x24F58F8")]
	public static bool Vector3TryParse(string st, out Vector3 v)
	{
		return default(bool);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x24F5A54", Offset = "0x24F5A54", VA = "0x24F5A54")]
	public static bool GetBoolAttribute(this XElement element, XName name, bool def = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x24F5B0C", Offset = "0x24F5B0C", VA = "0x24F5B0C")]
	public static string ToAccurateString(this Vector2 vector)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x24F5BB0", Offset = "0x24F5BB0", VA = "0x24F5BB0")]
	public static string ToAccurateString(this Vector3 vector)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	public static Predicate<T> And<T>(params Predicate<T>[] args)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	public static Predicate<T> Or<T>(params Predicate<T>[] args)
	{
		return null;
	}
}
[Token(Token = "0x2000005")]
public class ServiceProvider : SimplePlanesModServiceProvider
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly ServiceProvider _instance;

	[Token(Token = "0x17000001")]
	public static ServiceProvider Instance
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x24F8BDC", Offset = "0x24F8BDC", VA = "0x24F8BDC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x24F8BD4", Offset = "0x24F8BD4", VA = "0x24F8BD4")]
	private ServiceProvider()
	{
	}
}
[Token(Token = "0x2000006")]
public class SettingsManager : MonoBehaviour
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Setting[] Settings;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string pageId;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string pageName;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string pageDesc;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private IModSettingsPage page;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<Setting, IModSetting> sets;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F32C", Offset = "0xA6F32C")]
	private static SettingsManager <Instance>k__BackingField;

	[Token(Token = "0x17000002")]
	public static SettingsManager Instance
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x24F9104", Offset = "0x24F9104", VA = "0x24F9104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F4DC", Offset = "0xA6F4DC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x24F9150", Offset = "0x24F9150", VA = "0x24F9150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F4EC", Offset = "0xA6F4EC")]
		private set
		{
		}
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x24F8CB8", Offset = "0x24F8CB8", VA = "0x24F8CB8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x24F8D5C", Offset = "0x24F8D5C", VA = "0x24F8D5C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x24F91A0", Offset = "0x24F91A0", VA = "0x24F91A0")]
	public static Setting GetSetting(string id)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x24F9264", Offset = "0x24F9264", VA = "0x24F9264")]
	public SettingsManager()
	{
	}
}
[Serializable]
[Token(Token = "0x2000007")]
public class Setting
{
	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string id;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string name;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ModSettingTypes type;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F33C", Offset = "0xA6F33C")]
	private string <Value>k__BackingField;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public object[] args;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string defaultDesktop;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string defaultAndroid;

	[Token(Token = "0x17000003")]
	public string Value
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x24F8CA0", Offset = "0x24F8CA0", VA = "0x24F8CA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F4FC", Offset = "0xA6F4FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x24F8CA8", Offset = "0x24F8CA8", VA = "0x24F8CA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F50C", Offset = "0xA6F50C")]
		set
		{
		}
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x24F8CB0", Offset = "0x24F8CB0", VA = "0x24F8CB0")]
	public Setting()
	{
	}
}
namespace WNP78.Overload
{
	[Token(Token = "0x2000008")]
	public class InputRowScript : MonoBehaviour
	{
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputField inputName;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InputField inputValue;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Button deleteButton;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F34C", Offset = "0xA6F34C")]
		private Action<string> <OnNameChange>k__BackingField;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F35C", Offset = "0xA6F35C")]
		private Action<string> <OnValueChange>k__BackingField;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F36C", Offset = "0xA6F36C")]
		private Action <OnRemove>k__BackingField;

		[Token(Token = "0x17000004")]
		public Action<string> OnNameChange
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x24F63A4", Offset = "0x24F63A4", VA = "0x24F63A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F51C", Offset = "0xA6F51C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x24F63AC", Offset = "0x24F63AC", VA = "0x24F63AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F52C", Offset = "0xA6F52C")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public Action<string> OnValueChange
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x24F63B4", Offset = "0x24F63B4", VA = "0x24F63B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F53C", Offset = "0xA6F53C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x24F63BC", Offset = "0x24F63BC", VA = "0x24F63BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F54C", Offset = "0xA6F54C")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public Action OnRemove
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x24F63C4", Offset = "0x24F63C4", VA = "0x24F63C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F55C", Offset = "0xA6F55C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x24F63CC", Offset = "0x24F63CC", VA = "0x24F63CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F56C", Offset = "0xA6F56C")]
			set
			{
			}
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x24F63D4", Offset = "0x24F63D4", VA = "0x24F63D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x24F6554", Offset = "0x24F6554", VA = "0x24F6554")]
		private void _nc(string v)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x24F65B8", Offset = "0x24F65B8", VA = "0x24F65B8")]
		private void _vc(string v)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x24F661C", Offset = "0x24F661C", VA = "0x24F661C")]
		private void _rm()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x24F6638", Offset = "0x24F6638", VA = "0x24F6638")]
		public InputRowScript()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class UIScript : MonoBehaviour
	{
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Button SaveButton;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Button CancelButton;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Button AddButton;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Button SettingsButton;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Button SaveSettingsButton;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Button CloseSettingsButton;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Dropdown Dropdown;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform ItemContainer;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject itemTemplate;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public GameObject dialogRoot;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject SettingsPanel;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Slider UIScaleSlider;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Text UIScaleLabel;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float baseScale;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float userScale;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F37C", Offset = "0xA6F37C")]
		private bool <IsOpen>k__BackingField;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F38C", Offset = "0xA6F38C")]
		private static UIScript <Instance>k__BackingField;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F39C", Offset = "0xA6F39C")]
		private MonoBehaviour <DesignerScript>k__BackingField;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F3AC", Offset = "0xA6F3AC")]
		private object <Designer>k__BackingField;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F3BC", Offset = "0xA6F3BC")]
		private MonoBehaviour <GuiScript>k__BackingField;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F3CC", Offset = "0xA6F3CC")]
		private static float <GameUIScale>k__BackingField;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private XElement backup;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ElementProxy rootElement;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<ElementProxy> allElements;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ElementProxy currentElement;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private IPart part;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private MonoBehaviour partScript;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Transform oldParent;

		[Token(Token = "0x17000007")]
		public bool IsOpen
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x24F92DC", Offset = "0x24F92DC", VA = "0x24F92DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F57C", Offset = "0xA6F57C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x24F92E4", Offset = "0x24F92E4", VA = "0x24F92E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F58C", Offset = "0xA6F58C")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public static UIScript Instance
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x24F92F0", Offset = "0x24F92F0", VA = "0x24F92F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F59C", Offset = "0xA6F59C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x24F933C", Offset = "0x24F933C", VA = "0x24F933C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F5AC", Offset = "0xA6F5AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public MonoBehaviour DesignerScript
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x24F938C", Offset = "0x24F938C", VA = "0x24F938C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F5BC", Offset = "0xA6F5BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x24F9394", Offset = "0x24F9394", VA = "0x24F9394")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F5CC", Offset = "0xA6F5CC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public object Designer
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x24F939C", Offset = "0x24F939C", VA = "0x24F939C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F5DC", Offset = "0xA6F5DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x24F93A4", Offset = "0x24F93A4", VA = "0x24F93A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F5EC", Offset = "0xA6F5EC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public MonoBehaviour GuiScript
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x24F93AC", Offset = "0x24F93AC", VA = "0x24F93AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F5FC", Offset = "0xA6F5FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x24F93B4", Offset = "0x24F93B4", VA = "0x24F93B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F60C", Offset = "0xA6F60C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public static float GameUIScale
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x24F93BC", Offset = "0x24F93BC", VA = "0x24F93BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F61C", Offset = "0xA6F61C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x24F9408", Offset = "0x24F9408", VA = "0x24F9408")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F62C", Offset = "0xA6F62C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x24F9460", Offset = "0x24F9460", VA = "0x24F9460")]
		private void Start()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x24F9EB8", Offset = "0x24F9EB8", VA = "0x24F9EB8")]
		private void OnSettingsButtonClicked()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x24F9F44", Offset = "0x24F9F44", VA = "0x24F9F44")]
		private void OnSaveSettingsButtonClicked()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x24F9FFC", Offset = "0x24F9FFC", VA = "0x24F9FFC")]
		private void OnCloseSettingsButtonClicked()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x24FA01C", Offset = "0x24FA01C", VA = "0x24FA01C")]
		private void OnUIScaleSliderChanged(float v)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x24FA0E4", Offset = "0x24FA0E4", VA = "0x24FA0E4")]
		private void OpenUI()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x24FB128", Offset = "0x24FB128", VA = "0x24FB128")]
		private void SaveToPart()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x24FA908", Offset = "0x24FA908", VA = "0x24FA908")]
		private void AddDefaultPartAttributes(XElement e, IPartType partType, IPartScript part)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x24FCAAC", Offset = "0x24FCAAC", VA = "0x24FCAAC")]
		private string _vec3tostr(Vector3 v)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x24FCC84", Offset = "0x24FCC84", VA = "0x24FCC84")]
		private string _vec2tostr(Vector2 v)
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x24FCA7C", Offset = "0x24FCA7C", VA = "0x24FCA7C")]
		private bool _hasAttr(XElement e, XName n)
		{
			return default(bool);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x24FB160", Offset = "0x24FB160", VA = "0x24FB160")]
		private void Apply(XElement xml, bool f = true)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x24FAF40", Offset = "0x24FAF40", VA = "0x24FAF40")]
		private void OnDropdownChange(int newv)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x24FD06C", Offset = "0x24FD06C", VA = "0x24FD06C")]
		private void CloseUI()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x24FCD28", Offset = "0x24FCD28", VA = "0x24FCD28")]
		private void ClearRows()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x24FD0B4", Offset = "0x24FD0B4", VA = "0x24FD0B4")]
		private void OnAddButtonClicked()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x24FD174", Offset = "0x24FD174", VA = "0x24FD174")]
		private void OnOverloadButtonClicked()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x24FD18C", Offset = "0x24FD18C", VA = "0x24FD18C")]
		private void OnSaveButtonClicked()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x24FD1B0", Offset = "0x24FD1B0", VA = "0x24FD1B0")]
		private void OnCancelButtonClicked()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x24F42C4", Offset = "0x24F42C4", VA = "0x24F42C4")]
		public InputRowScript CreateRow()
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x24FA7AC", Offset = "0x24FA7AC", VA = "0x24FA7AC")]
		public void ShowMessage(string msg, float duration)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x24FAFC4", Offset = "0x24FAFC4", VA = "0x24FAFC4")]
		private void BlockKeys(bool block)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x24FD1B4", Offset = "0x24FD1B4", VA = "0x24FD1B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x24FD1BC", Offset = "0x24FD1BC", VA = "0x24FD1BC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x24FD1C4", Offset = "0x24FD1C4", VA = "0x24FD1C4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x24FD1D8", Offset = "0x24FD1D8", VA = "0x24FD1D8")]
		public UIScript()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class ElementProxy
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F3DC", Offset = "0xA6F3DC")]
		private string <Name>k__BackingField;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F3EC", Offset = "0xA6F3EC")]
		private string <ShowName>k__BackingField;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F3FC", Offset = "0xA6F3FC")]
		private List<ElementProxy> <Children>k__BackingField;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F40C", Offset = "0xA6F40C")]
		private List<AttributeProxy> <Attributes>k__BackingField;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F41C", Offset = "0xA6F41C")]
		private ElementProxy <Parent>k__BackingField;

		[Token(Token = "0x1700000D")]
		public string Name
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x24F4744", Offset = "0x24F4744", VA = "0x24F4744")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F63C", Offset = "0xA6F63C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x24F474C", Offset = "0x24F474C", VA = "0x24F474C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F64C", Offset = "0xA6F64C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public string ShowName
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x24F4754", Offset = "0x24F4754", VA = "0x24F4754")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F65C", Offset = "0xA6F65C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x24F475C", Offset = "0x24F475C", VA = "0x24F475C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F66C", Offset = "0xA6F66C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public XElement Element
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x24F4764", Offset = "0x24F4764", VA = "0x24F4764")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		public List<ElementProxy> Children
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x24F4A3C", Offset = "0x24F4A3C", VA = "0x24F4A3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F67C", Offset = "0xA6F67C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x24F4A44", Offset = "0x24F4A44", VA = "0x24F4A44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F68C", Offset = "0xA6F68C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public List<AttributeProxy> Attributes
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x24F4A4C", Offset = "0x24F4A4C", VA = "0x24F4A4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F69C", Offset = "0xA6F69C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x24F4A54", Offset = "0x24F4A54", VA = "0x24F4A54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F6AC", Offset = "0xA6F6AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public ElementProxy Parent
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x24F4A5C", Offset = "0x24F4A5C", VA = "0x24F4A5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F6BC", Offset = "0xA6F6BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x24F4A64", Offset = "0x24F4A64", VA = "0x24F4A64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F6CC", Offset = "0xA6F6CC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x24F4A6C", Offset = "0x24F4A6C", VA = "0x24F4A6C")]
		public ElementProxy(XElement element, ElementProxy parent)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x24F514C", Offset = "0x24F514C", VA = "0x24F514C")]
		public void CreateInputs(Transform parent)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x24F5260", Offset = "0x24F5260", VA = "0x24F5260")]
		public List<ElementProxy> Descendants()
		{
			return null;
		}
	}
	[Token(Token = "0x200000B")]
	public class AttributeProxy
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F42C", Offset = "0xA6F42C")]
		private ElementProxy <Parent>k__BackingField;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F43C", Offset = "0xA6F43C")]
		private string <Name>k__BackingField;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F44C", Offset = "0xA6F44C")]
		private string <Value>k__BackingField;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject row;

		[Token(Token = "0x17000013")]
		public XAttribute Attribute
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x24F3EAC", Offset = "0x24F3EAC", VA = "0x24F3EAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public ElementProxy Parent
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x24F3F5C", Offset = "0x24F3F5C", VA = "0x24F3F5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F6DC", Offset = "0xA6F6DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x24F3F64", Offset = "0x24F3F64", VA = "0x24F3F64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F6EC", Offset = "0xA6F6EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public string Name
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x24F3F6C", Offset = "0x24F3F6C", VA = "0x24F3F6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F6FC", Offset = "0xA6F6FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x24F3F74", Offset = "0x24F3F74", VA = "0x24F3F74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F70C", Offset = "0xA6F70C")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public string Value
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x24F3F7C", Offset = "0x24F3F7C", VA = "0x24F3F7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F71C", Offset = "0xA6F71C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x24F3F84", Offset = "0x24F3F84", VA = "0x24F3F84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F72C", Offset = "0xA6F72C")]
			set
			{
			}
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x24F3F8C", Offset = "0x24F3F8C", VA = "0x24F3F8C")]
		public AttributeProxy(ElementProxy parent)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x24F3FF4", Offset = "0x24F3FF4", VA = "0x24F3FF4")]
		public AttributeProxy(XAttribute attribute, ElementProxy parent)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x24F403C", Offset = "0x24F403C", VA = "0x24F403C")]
		public void Remove()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x24F4120", Offset = "0x24F4120", VA = "0x24F4120")]
		public void CreateRow(Transform parent)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x24F43E0", Offset = "0x24F43E0", VA = "0x24F43E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F73C", Offset = "0xA6F73C")]
		private void <CreateRow>b__18_0(string s)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x24F43E8", Offset = "0x24F43E8", VA = "0x24F43E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F74C", Offset = "0xA6F74C")]
		private void <CreateRow>b__18_1(string s)
		{
		}
	}
}
namespace WNP78.Common
{
	[Token(Token = "0x200000C")]
	public class Draggable : MonoBehaviour, IDragHandler, IEventSystemHandler, IEndDragHandler
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RectTransform WindowTransform;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3? dPos;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Canvas canv;

		[Token(Token = "0x17000017")]
		public Vector2 ScreenSize
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x24F43F0", Offset = "0x24F43F0", VA = "0x24F43F0")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x24F4424", Offset = "0x24F4424", VA = "0x24F4424")]
		private void Start()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x24F4524", Offset = "0x24F4524", VA = "0x24F4524", Slot = "4")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x24F4734", Offset = "0x24F4734", VA = "0x24F4734", Slot = "5")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x24F473C", Offset = "0x24F473C", VA = "0x24F473C")]
		public Draggable()
		{
		}
	}
	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA6F2AC", Offset = "0xA6F2AC")]
	public class InputBlocker : MonoBehaviour
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BoxCollider b;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform r;

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x24F5D88", Offset = "0x24F5D88", VA = "0x24F5D88")]
		private void Start()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x24F5DDC", Offset = "0x24F5DDC", VA = "0x24F5DDC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x24F61AC", Offset = "0x24F61AC", VA = "0x24F61AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x24F62A4", Offset = "0x24F62A4", VA = "0x24F62A4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x24F639C", Offset = "0x24F639C", VA = "0x24F639C")]
		public InputBlocker()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public static class ReflectionUtils
	{
		[Serializable]
		[Token(Token = "0x200000F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F31C", Offset = "0xA6F31C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400004A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<object, Type> <>9__23_0;

			[Token(Token = "0x6000089")]
			[Address(RVA = "0x24FD248", Offset = "0x24FD248", VA = "0x24FD248")]
			public <>c()
			{
			}

			[Token(Token = "0x600008A")]
			[Address(RVA = "0x24FD250", Offset = "0x24FD250", VA = "0x24FD250")]
			internal Type <GetMethodFast>b__23_0(object a)
			{
				return null;
			}
		}

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static BindingFlags allBindingFlags;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Dictionary<string, Type> cachedTypes;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Dictionary<Type, Dictionary<string, PropertyInfo>> cachedProperties;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Dictionary<Type, Dictionary<string, MethodInfo>> cachedMethods;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Dictionary<Type, Dictionary<string, FieldInfo>> cachedFields;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Assembly acs;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static bool inited;

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x24F6640", Offset = "0x24F6640", VA = "0x24F6640")]
		public static string tsn(this Array a)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x24F6904", Offset = "0x24F6904", VA = "0x24F6904")]
		public static Type GetTypeFast(string name)
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x24F6C40", Offset = "0x24F6C40", VA = "0x24F6C40")]
		public static Type GetType(string name)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x24F6CA0", Offset = "0x24F6CA0", VA = "0x24F6CA0")]
		public static object Call(this object obj, string name, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x24F71A0", Offset = "0x24F71A0", VA = "0x24F71A0")]
		public static object CallO(this object obj, string name, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x24F7248", Offset = "0x24F7248", VA = "0x24F7248")]
		public static object GetP(this object obj, string name, params object[] index)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x24F75C8", Offset = "0x24F75C8", VA = "0x24F75C8")]
		public static void SetP(this object obj, string name, object value, params object[] index)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x24F7684", Offset = "0x24F7684", VA = "0x24F7684")]
		public static object GetF(this object obj, string name)
		{
			return null;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x24F7B8C", Offset = "0x24F7B8C", VA = "0x24F7B8C")]
		public static void SetF(this object obj, string name, object value)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x24F7C30", Offset = "0x24F7C30", VA = "0x24F7C30")]
		public static object GetSP(this Type t, string name, params object[] index)
		{
			return null;
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x24F7CC4", Offset = "0x24F7CC4", VA = "0x24F7CC4")]
		public static void SetSP(this Type t, string name, object value, params object[] index)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x24F7D68", Offset = "0x24F7D68", VA = "0x24F7D68")]
		public static object GetSF(this Type t, string name)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x24F7DF4", Offset = "0x24F7DF4", VA = "0x24F7DF4")]
		public static void SetSF(this Type t, string name, object value)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x24F7E80", Offset = "0x24F7E80", VA = "0x24F7E80")]
		public static object CallS(this Type t, string name, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x24F7F10", Offset = "0x24F7F10", VA = "0x24F7F10")]
		public static object CallSO(this Type t, string name, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x24F72F4", Offset = "0x24F72F4", VA = "0x24F72F4")]
		public static PropertyInfo GetPropFast(Type tp, string name)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x24F6D48", Offset = "0x24F6D48", VA = "0x24F6D48")]
		public static MethodInfo GetMethodFast(Type tp, string name, [Optional] object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x24F7728", Offset = "0x24F7728", VA = "0x24F7728")]
		public static FieldInfo GetFieldFast(Type tp, string name)
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x24F6A68", Offset = "0x24F6A68", VA = "0x24F6A68")]
		public static void Init()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x24F7FA0", Offset = "0x24F7FA0", VA = "0x24F7FA0")]
		public static Assembly GetAssembly(string name)
		{
			return null;
		}
	}
	[Token(Token = "0x2000010")]
	public class Resizeable : MonoBehaviour, IDragHandler, IEventSystemHandler, IEndDragHandler, IBeginDragHandler
	{
		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 minSize;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RectTransform WindowTransform;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Canvas canvas;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RectTransform canvT;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector2 lastPos;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector2 lastScreen;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector2 lastSize;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float lastScale;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector2 size;

		[Token(Token = "0x17000018")]
		public Vector2 ScreenSize
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x24F80F8", Offset = "0x24F80F8", VA = "0x24F80F8")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000019")]
		private string XmlPath
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x24F8764", Offset = "0x24F8764", VA = "0x24F8764")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x24F813C", Offset = "0x24F813C", VA = "0x24F813C")]
		private void Start()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x24F827C", Offset = "0x24F827C", VA = "0x24F827C")]
		private void TryLoadSize()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x24F8504", Offset = "0x24F8504", VA = "0x24F8504", Slot = "4")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x24F8640", Offset = "0x24F8640", VA = "0x24F8640", Slot = "5")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x24F8688", Offset = "0x24F8688", VA = "0x24F8688", Slot = "6")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x24F86DC", Offset = "0x24F86DC", VA = "0x24F86DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x24F880C", Offset = "0x24F880C", VA = "0x24F880C")]
		private void SaveToFile(XElement element)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x24F84E4", Offset = "0x24F84E4", VA = "0x24F84E4")]
		private XElement LoadFromFile()
		{
			return null;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x24F88BC", Offset = "0x24F88BC", VA = "0x24F88BC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x24F8BBC", Offset = "0x24F8BBC", VA = "0x24F8BBC")]
		public Resizeable()
		{
		}
	}
}
