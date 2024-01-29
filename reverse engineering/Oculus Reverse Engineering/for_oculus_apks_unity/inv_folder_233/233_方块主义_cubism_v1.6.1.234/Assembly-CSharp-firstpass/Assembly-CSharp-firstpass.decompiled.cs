using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class Colorx
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0xA4E600", Offset = "0xA4E600", VA = "0xA4E600")]
	public static Color Slerp(this Color a, Color b, float t)
	{
		return default(Color);
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xA4E8E0", Offset = "0xA4E8E0", VA = "0xA4E8E0")]
	public static void H(this Color c, int hue0to360, ref Color thisColor)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xA4EAD8", Offset = "0xA4EAD8", VA = "0xA4EAD8")]
	public static void H(this Color c, float hue0to1, ref Color thisColor)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xA4EB10", Offset = "0xA4EB10", VA = "0xA4EB10")]
	public static void S(this Color c, int saturation0to360, ref Color thisColor)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xA4EB54", Offset = "0xA4EB54", VA = "0xA4EB54")]
	public static void S(this Color c, float saturation0to1, ref Color thisColor)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xA4EB8C", Offset = "0xA4EB8C", VA = "0xA4EB8C")]
	public static void B(this Color c, int brightness0to360, ref Color thisColor)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xA4EBD0", Offset = "0xA4EBD0", VA = "0xA4EBD0")]
	public static void B(this Color c, float brightness0to1, ref Color thisColor)
	{
	}
}
[Serializable]
[Token(Token = "0x2000003")]
public struct HSBColor
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float h;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float s;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float b;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float a;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xA4EC08", Offset = "0xA4EC08", VA = "0xA4EC08")]
	public HSBColor(float h, float s, float b, float a)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xA4EC14", Offset = "0xA4EC14", VA = "0xA4EC14")]
	public HSBColor(float h, float s, float b)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xA4EC28", Offset = "0xA4EC28", VA = "0xA4EC28")]
	public HSBColor(Color col)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xA4E6A0", Offset = "0xA4E6A0", VA = "0xA4E6A0")]
	public static HSBColor FromColor(Color color)
	{
		return default(HSBColor);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xA4E91C", Offset = "0xA4E91C", VA = "0xA4E91C")]
	public static Color ToColor(HSBColor hsbColor)
	{
		return default(Color);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xA4E8D4", Offset = "0xA4E8D4", VA = "0xA4E8D4")]
	public Color ToColor()
	{
		return default(Color);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xA4EC44", Offset = "0xA4EC44", VA = "0xA4EC44", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xA4E790", Offset = "0xA4E790", VA = "0xA4E790")]
	public static HSBColor Lerp(HSBColor a, HSBColor b, float t)
	{
		return default(HSBColor);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xA4EE20", Offset = "0xA4EE20", VA = "0xA4EE20")]
	public static void Test()
	{
	}
}
[Token(Token = "0x2000004")]
public class Test : MonoBehaviour
{
	[Token(Token = "0x6000011")]
	[Address(RVA = "0xA4F110", Offset = "0xA4F110", VA = "0xA4F110")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xA4F4F0", Offset = "0xA4F4F0", VA = "0xA4F4F0")]
	public Test()
	{
	}
}
namespace SimpleJSON
{
	[Token(Token = "0x2000005")]
	public enum JSONNodeType
	{
		[Token(Token = "0x4000006")]
		Array = 1,
		[Token(Token = "0x4000007")]
		Object = 2,
		[Token(Token = "0x4000008")]
		String = 3,
		[Token(Token = "0x4000009")]
		Number = 4,
		[Token(Token = "0x400000A")]
		NullValue = 5,
		[Token(Token = "0x400000B")]
		Boolean = 6,
		[Token(Token = "0x400000C")]
		None = 7,
		[Token(Token = "0x400000D")]
		Custom = 255
	}
	[Token(Token = "0x2000006")]
	public enum JSONTextMode
	{
		[Token(Token = "0x400000F")]
		Compact,
		[Token(Token = "0x4000010")]
		Indent
	}
	[Token(Token = "0x2000007")]
	public abstract class JSONNode
	{
		[Token(Token = "0x2000008")]
		public struct Enumerator
		{
			[Token(Token = "0x2000009")]
			private enum Type
			{
				[Token(Token = "0x4000019")]
				None,
				[Token(Token = "0x400001A")]
				Array,
				[Token(Token = "0x400001B")]
				Object
			}

			[Token(Token = "0x4000015")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Type type;

			[Token(Token = "0x4000016")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private Dictionary<string, JSONNode>.Enumerator m_Object;

			[Token(Token = "0x4000017")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator m_Array;

			[Token(Token = "0x1700001B")]
			public bool IsValid
			{
				[Token(Token = "0x600005C")]
				[Address(RVA = "0xA5198C", Offset = "0xA5198C", VA = "0xA5198C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700001C")]
			public KeyValuePair<string, JSONNode> Current
			{
				[Token(Token = "0x600005F")]
				[Address(RVA = "0xA519EC", Offset = "0xA519EC", VA = "0xA519EC")]
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			[Token(Token = "0x600005D")]
			[Address(RVA = "0xA5199C", Offset = "0xA5199C", VA = "0xA5199C")]
			public Enumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x600005E")]
			[Address(RVA = "0xA519C8", Offset = "0xA519C8", VA = "0xA519C8")]
			public Enumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x6000060")]
			[Address(RVA = "0xA51AB8", Offset = "0xA51AB8", VA = "0xA51AB8")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200000A")]
		public struct ValueEnumerator
		{
			[Token(Token = "0x400001C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x1700001D")]
			public JSONNode Current
			{
				[Token(Token = "0x6000064")]
				[Address(RVA = "0xA51C10", Offset = "0xA51C10", VA = "0xA51C10")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000061")]
			[Address(RVA = "0xA51B4C", Offset = "0xA51B4C", VA = "0xA51B4C")]
			public ValueEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x6000062")]
			[Address(RVA = "0xA51B8C", Offset = "0xA51B8C", VA = "0xA51B8C")]
			public ValueEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x6000063")]
			[Address(RVA = "0xA51BFC", Offset = "0xA51BFC", VA = "0xA51BFC")]
			public ValueEnumerator(Enumerator aEnumerator)
			{
			}

			[Token(Token = "0x6000065")]
			[Address(RVA = "0xA51C54", Offset = "0xA51C54", VA = "0xA51C54")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000066")]
			[Address(RVA = "0xA51C58", Offset = "0xA51C58", VA = "0xA51C58")]
			public ValueEnumerator GetEnumerator()
			{
				return default(ValueEnumerator);
			}
		}

		[Token(Token = "0x200000B")]
		public struct KeyEnumerator
		{
			[Token(Token = "0x400001D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x1700001E")]
			public string Current
			{
				[Token(Token = "0x600006A")]
				[Address(RVA = "0xA51D2C", Offset = "0xA51D2C", VA = "0xA51D2C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000067")]
			[Address(RVA = "0xA51C68", Offset = "0xA51C68", VA = "0xA51C68")]
			public KeyEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x6000068")]
			[Address(RVA = "0xA51CA8", Offset = "0xA51CA8", VA = "0xA51CA8")]
			public KeyEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x6000069")]
			[Address(RVA = "0xA51D18", Offset = "0xA51D18", VA = "0xA51D18")]
			public KeyEnumerator(Enumerator aEnumerator)
			{
			}

			[Token(Token = "0x600006B")]
			[Address(RVA = "0xA51D68", Offset = "0xA51D68", VA = "0xA51D68")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600006C")]
			[Address(RVA = "0xA51D6C", Offset = "0xA51D6C", VA = "0xA51D6C")]
			public KeyEnumerator GetEnumerator()
			{
				return default(KeyEnumerator);
			}
		}

		[Token(Token = "0x200000C")]
		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerator, IDisposable, IEnumerable<KeyValuePair<string, JSONNode>>, IEnumerable
		{
			[Token(Token = "0x400001E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private JSONNode m_Node;

			[Token(Token = "0x400001F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x1700001F")]
			public KeyValuePair<string, JSONNode> Current
			{
				[Token(Token = "0x600006E")]
				[Address(RVA = "0xA51D7C", Offset = "0xA51D7C", VA = "0xA51D7C", Slot = "4")]
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			[Token(Token = "0x17000020")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600006F")]
				[Address(RVA = "0xA51D84", Offset = "0xA51D84", VA = "0xA51D84", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600006D")]
			[Address(RVA = "0xA4F908", Offset = "0xA4F908", VA = "0xA4F908")]
			internal LinqEnumerator(JSONNode aNode)
			{
			}

			[Token(Token = "0x6000070")]
			[Address(RVA = "0xA51DE8", Offset = "0xA51DE8", VA = "0xA51DE8", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000071")]
			[Address(RVA = "0xA51DF0", Offset = "0xA51DF0", VA = "0xA51DF0", Slot = "5")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000072")]
			[Address(RVA = "0xA51E04", Offset = "0xA51E04", VA = "0xA51E04", Slot = "9")]
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000073")]
			[Address(RVA = "0xA51E68", Offset = "0xA51E68", VA = "0xA51E68", Slot = "8")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000074")]
			[Address(RVA = "0xA51F14", Offset = "0xA51F14", VA = "0xA51F14", Slot = "10")]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class <get_Children>d__43 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000020")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000022")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x17000021")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000078")]
				[Address(RVA = "0xA51F94", Offset = "0xA51F94", VA = "0xA51F94", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000022")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600007A")]
				[Address(RVA = "0xA51FDC", Offset = "0xA51FDC", VA = "0xA51FDC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000075")]
			[Address(RVA = "0xA4F694", Offset = "0xA4F694", VA = "0xA4F694")]
			[DebuggerHidden]
			public <get_Children>d__43(int <>1__state)
			{
			}

			[Token(Token = "0x6000076")]
			[Address(RVA = "0xA51F78", Offset = "0xA51F78", VA = "0xA51F78", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000077")]
			[Address(RVA = "0xA51F7C", Offset = "0xA51F7C", VA = "0xA51F7C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000079")]
			[Address(RVA = "0xA51F9C", Offset = "0xA51F9C", VA = "0xA51F9C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600007B")]
			[Address(RVA = "0xA51FE4", Offset = "0xA51FE4", VA = "0xA51FE4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600007C")]
			[Address(RVA = "0xA5207C", Offset = "0xA5207C", VA = "0xA5207C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class <get_DeepChildren>d__45 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000023")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000024")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000025")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000026")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONNode <>4__this;

			[Token(Token = "0x4000027")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			[Token(Token = "0x4000028")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;

			[Token(Token = "0x17000023")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000082")]
				[Address(RVA = "0xA526CC", Offset = "0xA526CC", VA = "0xA526CC", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000024")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000084")]
				[Address(RVA = "0xA52714", Offset = "0xA52714", VA = "0xA52714", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600007D")]
			[Address(RVA = "0xA4F740", Offset = "0xA4F740", VA = "0xA4F740")]
			[DebuggerHidden]
			public <get_DeepChildren>d__45(int <>1__state)
			{
			}

			[Token(Token = "0x600007E")]
			[Address(RVA = "0xA52080", Offset = "0xA52080", VA = "0xA52080", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600007F")]
			[Address(RVA = "0xA52138", Offset = "0xA52138", VA = "0xA52138", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000080")]
			[Address(RVA = "0xA5261C", Offset = "0xA5261C", VA = "0xA5261C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000081")]
			[Address(RVA = "0xA5256C", Offset = "0xA5256C", VA = "0xA5256C")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x6000083")]
			[Address(RVA = "0xA526D4", Offset = "0xA526D4", VA = "0xA526D4", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000085")]
			[Address(RVA = "0xA5271C", Offset = "0xA5271C", VA = "0xA5271C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000086")]
			[Address(RVA = "0xA527C0", Offset = "0xA527C0", VA = "0xA527C0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool forceASCII;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static bool longAsString;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public static bool allowLineComments;

		[Token(Token = "0x4000014")]
		[ThreadStatic]
		private static StringBuilder m_EscapeBuilder;

		[Token(Token = "0x17000001")]
		public abstract JSONNodeType Tag
		{
			[Token(Token = "0x6000013")]
			get;
		}

		[Token(Token = "0x17000002")]
		public virtual JSONNode this[int aIndex]
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0xA4F4F8", Offset = "0xA4F4F8", VA = "0xA4F4F8", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000015")]
			[Address(RVA = "0xA4F500", Offset = "0xA4F500", VA = "0xA4F500", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public virtual JSONNode this[string aKey]
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0xA4F504", Offset = "0xA4F504", VA = "0xA4F504", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0xA4F50C", Offset = "0xA4F50C", VA = "0xA4F50C", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public virtual string Value
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0xA4F510", Offset = "0xA4F510", VA = "0xA4F510", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0xA4F550", Offset = "0xA4F550", VA = "0xA4F550", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public virtual int Count
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0xA4F554", Offset = "0xA4F554", VA = "0xA4F554", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000006")]
		public virtual bool IsNumber
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0xA4F55C", Offset = "0xA4F55C", VA = "0xA4F55C", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000007")]
		public virtual bool IsString
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0xA4F564", Offset = "0xA4F564", VA = "0xA4F564", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public virtual bool IsBoolean
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0xA4F56C", Offset = "0xA4F56C", VA = "0xA4F56C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		public virtual bool IsNull
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0xA4F574", Offset = "0xA4F574", VA = "0xA4F574", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		public virtual bool IsArray
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0xA4F57C", Offset = "0xA4F57C", VA = "0xA4F57C", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public virtual bool IsObject
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0xA4F584", Offset = "0xA4F584", VA = "0xA4F584", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		public virtual bool Inline
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0xA4F58C", Offset = "0xA4F58C", VA = "0xA4F58C", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0xA4F594", Offset = "0xA4F594", VA = "0xA4F594", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public virtual IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0xA4F624", Offset = "0xA4F624", VA = "0xA4F624", Slot = "27")]
			[IteratorStateMachine(typeof(<get_Children>d__43))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		public IEnumerable<JSONNode> DeepChildren
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0xA4F6C8", Offset = "0xA4F6C8", VA = "0xA4F6C8")]
			[IteratorStateMachine(typeof(<get_DeepChildren>d__45))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public IEnumerable<KeyValuePair<string, JSONNode>> Linq
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0xA4F8A8", Offset = "0xA4F8A8", VA = "0xA4F8A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		public KeyEnumerator Keys
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0xA4F9CC", Offset = "0xA4F9CC", VA = "0xA4F9CC")]
			get
			{
				return default(KeyEnumerator);
			}
		}

		[Token(Token = "0x17000011")]
		public ValueEnumerator Values
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0xA4FA08", Offset = "0xA4FA08", VA = "0xA4FA08")]
			get
			{
				return default(ValueEnumerator);
			}
		}

		[Token(Token = "0x17000012")]
		public virtual double AsDouble
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0xA4FA44", Offset = "0xA4FA44", VA = "0xA4FA44", Slot = "33")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0xA4FAE8", Offset = "0xA4FAE8", VA = "0xA4FAE8", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public virtual int AsInt
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0xA4FB70", Offset = "0xA4FB70", VA = "0xA4FB70", Slot = "35")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0xA4FBA4", Offset = "0xA4FBA4", VA = "0xA4FBA4", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public virtual float AsFloat
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0xA4FBBC", Offset = "0xA4FBBC", VA = "0xA4FBBC", Slot = "37")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0xA4FBDC", Offset = "0xA4FBDC", VA = "0xA4FBDC", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public virtual bool AsBool
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0xA4FBF0", Offset = "0xA4FBF0", VA = "0xA4FBF0", Slot = "39")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600003C")]
			[Address(RVA = "0xA4FCA8", Offset = "0xA4FCA8", VA = "0xA4FCA8", Slot = "40")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public virtual long AsLong
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0xA4FD20", Offset = "0xA4FD20", VA = "0xA4FD20", Slot = "41")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600003E")]
			[Address(RVA = "0xA4FD54", Offset = "0xA4FD54", VA = "0xA4FD54", Slot = "42")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public virtual ulong AsULong
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0xA4FD90", Offset = "0xA4FD90", VA = "0xA4FD90", Slot = "43")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x6000040")]
			[Address(RVA = "0xA4FDC4", Offset = "0xA4FDC4", VA = "0xA4FDC4", Slot = "44")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0xA4FE00", Offset = "0xA4FE00", VA = "0xA4FE00", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public virtual JSONObject AsObject
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0xA4FE78", Offset = "0xA4FE78", VA = "0xA4FE78", Slot = "46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		internal static StringBuilder EscapeBuilder
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0xA50AA4", Offset = "0xA50AA4", VA = "0xA50AA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xA4F598", Offset = "0xA4F598", VA = "0xA4F598", Slot = "20")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xA4F59C", Offset = "0xA4F59C", VA = "0xA4F59C", Slot = "21")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xA4F600", Offset = "0xA4F600", VA = "0xA4F600", Slot = "22")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xA4F608", Offset = "0xA4F608", VA = "0xA4F608", Slot = "23")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xA4F610", Offset = "0xA4F610", VA = "0xA4F610", Slot = "24")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xA4F618", Offset = "0xA4F618", VA = "0xA4F618", Slot = "25")]
		public virtual void Clear()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xA4F61C", Offset = "0xA4F61C", VA = "0xA4F61C", Slot = "26")]
		public virtual JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xA4F774", Offset = "0xA4F774", VA = "0xA4F774", Slot = "28")]
		public virtual bool HasKey(string aKey)
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xA4F77C", Offset = "0xA4F77C", VA = "0xA4F77C", Slot = "29")]
		public virtual JSONNode GetValueOrDefault(string aKey, JSONNode aDefault)
		{
			return null;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xA4F784", Offset = "0xA4F784", VA = "0xA4F784", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xA4F810", Offset = "0xA4F810", VA = "0xA4F810", Slot = "30")]
		public virtual string ToString(int aIndent)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

		[Token(Token = "0x6000031")]
		public abstract Enumerator GetEnumerator();

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xA4FEF0", Offset = "0xA4FEF0", VA = "0xA4FEF0")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xA50080", Offset = "0xA50080", VA = "0xA50080")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xA50284", Offset = "0xA50284", VA = "0xA50284")]
		public static implicit operator JSONNode(double n)
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xA50358", Offset = "0xA50358", VA = "0xA50358")]
		public static implicit operator double(JSONNode d)
		{
			return default(double);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xA503E0", Offset = "0xA503E0", VA = "0xA503E0")]
		public static implicit operator JSONNode(float n)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xA50448", Offset = "0xA50448", VA = "0xA50448")]
		public static implicit operator float(JSONNode d)
		{
			return default(float);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xA504D0", Offset = "0xA504D0", VA = "0xA504D0")]
		public static implicit operator JSONNode(int n)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xA50530", Offset = "0xA50530", VA = "0xA50530")]
		public static implicit operator int(JSONNode d)
		{
			return default(int);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xA505B8", Offset = "0xA505B8", VA = "0xA505B8")]
		public static implicit operator JSONNode(long n)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xA5069C", Offset = "0xA5069C", VA = "0xA5069C")]
		public static implicit operator long(JSONNode d)
		{
			return default(long);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xA50724", Offset = "0xA50724", VA = "0xA50724")]
		public static implicit operator JSONNode(ulong n)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xA50808", Offset = "0xA50808", VA = "0xA50808")]
		public static implicit operator ulong(JSONNode d)
		{
			return default(ulong);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xA50890", Offset = "0xA50890", VA = "0xA50890")]
		public static implicit operator JSONNode(bool b)
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xA5095C", Offset = "0xA5095C", VA = "0xA5095C")]
		public static implicit operator bool(JSONNode d)
		{
			return default(bool);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xA509E4", Offset = "0xA509E4", VA = "0xA509E4")]
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue)
		{
			return null;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xA50104", Offset = "0xA50104", VA = "0xA50104")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xA50A20", Offset = "0xA50A20", VA = "0xA50A20")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xA50A90", Offset = "0xA50A90", VA = "0xA50A90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xA50A9C", Offset = "0xA50A9C", VA = "0xA50A9C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xA50B70", Offset = "0xA50B70", VA = "0xA50B70")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xA50E60", Offset = "0xA50E60", VA = "0xA50E60")]
		private static JSONNode ParseElement(string token, bool quoted)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xA5103C", Offset = "0xA5103C", VA = "0xA5103C")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xA51934", Offset = "0xA51934", VA = "0xA51934")]
		protected JSONNode()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class JSONArray : JSONNode
	{
		[Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class <get_Children>d__24 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400002B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400002C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONArray <>4__this;

			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700002C")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x600009D")]
				[Address(RVA = "0xA535B8", Offset = "0xA535B8", VA = "0xA535B8", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600009F")]
				[Address(RVA = "0xA53600", Offset = "0xA53600", VA = "0xA53600", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000099")]
			[Address(RVA = "0xA5321C", Offset = "0xA5321C", VA = "0xA5321C")]
			[DebuggerHidden]
			public <get_Children>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0xA533B8", Offset = "0xA533B8", VA = "0xA533B8", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600009B")]
			[Address(RVA = "0xA533D4", Offset = "0xA533D4", VA = "0xA533D4", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600009C")]
			[Address(RVA = "0xA53568", Offset = "0xA53568", VA = "0xA53568")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600009E")]
			[Address(RVA = "0xA535C0", Offset = "0xA535C0", VA = "0xA535C0", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000A0")]
			[Address(RVA = "0xA53608", Offset = "0xA53608", VA = "0xA53608", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60000A1")]
			[Address(RVA = "0xA536AC", Offset = "0xA536AC", VA = "0xA536AC", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inline;

		[Token(Token = "0x17000025")]
		public override bool Inline
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0xA527C4", Offset = "0xA527C4", VA = "0xA527C4", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000088")]
			[Address(RVA = "0xA527CC", Offset = "0xA527CC", VA = "0xA527CC", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0xA527D8", Offset = "0xA527D8", VA = "0xA527D8", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000027")]
		public override bool IsArray
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0xA527E0", Offset = "0xA527E0", VA = "0xA527E0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000028")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0xA52874", Offset = "0xA52874", VA = "0xA52874", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008D")]
			[Address(RVA = "0xA52990", Offset = "0xA52990", VA = "0xA52990", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0xA52AF8", Offset = "0xA52AF8", VA = "0xA52AF8", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008F")]
			[Address(RVA = "0xA52B58", Offset = "0xA52B58", VA = "0xA52B58", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public override int Count
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0xA52C6C", Offset = "0xA52C6C", VA = "0xA52C6C", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002B")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0xA531A4", Offset = "0xA531A4", VA = "0xA531A4", Slot = "27")]
			[IteratorStateMachine(typeof(<get_Children>d__24))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xA527E8", Offset = "0xA527E8", VA = "0xA527E8", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xA52CB4", Offset = "0xA52CB4", VA = "0xA52CB4", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xA52DC8", Offset = "0xA52DC8", VA = "0xA52DC8", Slot = "23")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xA52E7C", Offset = "0xA52E7C", VA = "0xA52E7C", Slot = "24")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xA52EDC", Offset = "0xA52EDC", VA = "0xA52EDC", Slot = "25")]
		public override void Clear()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xA52F4C", Offset = "0xA52F4C", VA = "0xA52F4C", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xA53250", Offset = "0xA53250", VA = "0xA53250", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xA51894", Offset = "0xA51894", VA = "0xA51894")]
		public JSONArray()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class JSONObject : JSONNode
	{
		[Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class <get_Children>d__27 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONObject <>4__this;

			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000035")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x60000BD")]
				[Address(RVA = "0xA54A14", Offset = "0xA54A14", VA = "0xA54A14", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000036")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000BF")]
				[Address(RVA = "0xA54A5C", Offset = "0xA54A5C", VA = "0xA54A5C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B9")]
			[Address(RVA = "0xA54418", Offset = "0xA54418", VA = "0xA54418")]
			[DebuggerHidden]
			public <get_Children>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x60000BA")]
			[Address(RVA = "0xA54800", Offset = "0xA54800", VA = "0xA54800", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000BB")]
			[Address(RVA = "0xA5481C", Offset = "0xA5481C", VA = "0xA5481C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000BC")]
			[Address(RVA = "0xA549C4", Offset = "0xA549C4", VA = "0xA549C4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60000BE")]
			[Address(RVA = "0xA54A1C", Offset = "0xA54A1C", VA = "0xA54A1C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000C0")]
			[Address(RVA = "0xA54A64", Offset = "0xA54A64", VA = "0xA54A64", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60000C1")]
			[Address(RVA = "0xA54B08", Offset = "0xA54B08", VA = "0xA54B08", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inline;

		[Token(Token = "0x1700002E")]
		public override bool Inline
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0xA536B0", Offset = "0xA536B0", VA = "0xA536B0", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0xA536B8", Offset = "0xA536B8", VA = "0xA536B8", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0xA536C4", Offset = "0xA536C4", VA = "0xA536C4", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000030")]
		public override bool IsObject
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0xA536CC", Offset = "0xA536CC", VA = "0xA536CC", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000031")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0xA5375C", Offset = "0xA5375C", VA = "0xA5375C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0xA53890", Offset = "0xA53890", VA = "0xA53890", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0xA539BC", Offset = "0xA539BC", VA = "0xA539BC", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0xA53A5C", Offset = "0xA53A5C", VA = "0xA53A5C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public override int Count
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0xA53B98", Offset = "0xA53B98", VA = "0xA53B98", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000034")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0xA543A0", Offset = "0xA543A0", VA = "0xA543A0", Slot = "27")]
			[IteratorStateMachine(typeof(<get_Children>d__27))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xA536D4", Offset = "0xA536D4", VA = "0xA536D4", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xA53BE8", Offset = "0xA53BE8", VA = "0xA53BE8", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xA53D50", Offset = "0xA53D50", VA = "0xA53D50", Slot = "22")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xA53E14", Offset = "0xA53E14", VA = "0xA53E14", Slot = "23")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xA53EF0", Offset = "0xA53EF0", VA = "0xA53EF0", Slot = "24")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xA540B8", Offset = "0xA540B8", VA = "0xA540B8", Slot = "25")]
		public override void Clear()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xA54108", Offset = "0xA54108", VA = "0xA54108", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xA542CC", Offset = "0xA542CC", VA = "0xA542CC", Slot = "28")]
		public override bool HasKey(string aKey)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xA54324", Offset = "0xA54324", VA = "0xA54324", Slot = "29")]
		public override JSONNode GetValueOrDefault(string aKey, JSONNode aDefault)
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xA5444C", Offset = "0xA5444C", VA = "0xA5444C", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xA517F4", Offset = "0xA517F4", VA = "0xA517F4")]
		public JSONObject()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class JSONString : JSONNode
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_Data;

		[Token(Token = "0x17000037")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0xA54B0C", Offset = "0xA54B0C", VA = "0xA54B0C", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000038")]
		public override bool IsString
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0xA54B14", Offset = "0xA54B14", VA = "0xA54B14", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public override string Value
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0xA54B30", Offset = "0xA54B30", VA = "0xA54B30", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0xA54B38", Offset = "0xA54B38", VA = "0xA54B38", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xA54B1C", Offset = "0xA54B1C", VA = "0xA54B1C", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xA4FF84", Offset = "0xA4FF84", VA = "0xA4FF84")]
		public JSONString(string aData)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xA54B40", Offset = "0xA54B40", VA = "0xA54B40", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xA54BA4", Offset = "0xA54BA4", VA = "0xA54BA4", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xA54C44", Offset = "0xA54C44", VA = "0xA54C44", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xA54D54", Offset = "0xA54D54", VA = "0xA54D54", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xA54D74", Offset = "0xA54D74", VA = "0xA54D74", Slot = "25")]
		public override void Clear()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class JSONNumber : JSONNode
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private double m_Data;

		[Token(Token = "0x1700003A")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0xA54DBC", Offset = "0xA54DBC", VA = "0xA54DBC", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x1700003B")]
		public override bool IsNumber
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0xA54DC4", Offset = "0xA54DC4", VA = "0xA54DC4", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		public override string Value
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0xA54DE0", Offset = "0xA54DE0", VA = "0xA54DE0", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0xA54E48", Offset = "0xA54E48", VA = "0xA54E48", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public override double AsDouble
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0xA54ED4", Offset = "0xA54ED4", VA = "0xA54ED4", Slot = "33")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0xA54EDC", Offset = "0xA54EDC", VA = "0xA54EDC", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public override long AsLong
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0xA54EE4", Offset = "0xA54EE4", VA = "0xA54EE4", Slot = "41")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0xA54F04", Offset = "0xA54F04", VA = "0xA54F04", Slot = "42")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public override ulong AsULong
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0xA54F10", Offset = "0xA54F10", VA = "0xA54F10", Slot = "43")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0xA54F28", Offset = "0xA54F28", VA = "0xA54F28", Slot = "44")]
			set
			{
			}
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xA54DCC", Offset = "0xA54DCC", VA = "0xA54DCC", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xA502EC", Offset = "0xA502EC", VA = "0xA502EC")]
		public JSONNumber(double aData)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xA54F34", Offset = "0xA54F34", VA = "0xA54F34")]
		public JSONNumber(string aData)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xA54FAC", Offset = "0xA54FAC", VA = "0xA54FAC", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xA55018", Offset = "0xA55018", VA = "0xA55018", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xA5504C", Offset = "0xA5504C", VA = "0xA5504C")]
		private static bool IsNumeric(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xA551EC", Offset = "0xA551EC", VA = "0xA551EC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xA55310", Offset = "0xA55310", VA = "0xA55310", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xA55380", Offset = "0xA55380", VA = "0xA55380", Slot = "25")]
		public override void Clear()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class JSONBool : JSONNode
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_Data;

		[Token(Token = "0x17000040")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0xA55388", Offset = "0xA55388", VA = "0xA55388", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000041")]
		public override bool IsBoolean
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0xA55390", Offset = "0xA55390", VA = "0xA55390", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000042")]
		public override string Value
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0xA553AC", Offset = "0xA553AC", VA = "0xA553AC", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0xA553B8", Offset = "0xA553B8", VA = "0xA553B8", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public override bool AsBool
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0xA55434", Offset = "0xA55434", VA = "0xA55434", Slot = "39")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0xA5543C", Offset = "0xA5543C", VA = "0xA5543C", Slot = "40")]
			set
			{
			}
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xA55398", Offset = "0xA55398", VA = "0xA55398", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xA508F0", Offset = "0xA508F0", VA = "0xA508F0")]
		public JSONBool(bool aData)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xA55448", Offset = "0xA55448", VA = "0xA55448")]
		public JSONBool(string aData)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xA554C0", Offset = "0xA554C0", VA = "0xA554C0", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xA55528", Offset = "0xA55528", VA = "0xA55528", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xA555A0", Offset = "0xA555A0", VA = "0xA555A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xA55618", Offset = "0xA55618", VA = "0xA55618", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xA55624", Offset = "0xA55624", VA = "0xA55624", Slot = "25")]
		public override void Clear()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class JSONNull : JSONNode
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static JSONNull m_StaticInstance;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool reuseSameInstance;

		[Token(Token = "0x17000044")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0xA55684", Offset = "0xA55684", VA = "0xA55684", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000045")]
		public override bool IsNull
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0xA5568C", Offset = "0xA5568C", VA = "0xA5568C", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		public override string Value
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0xA556A8", Offset = "0xA556A8", VA = "0xA556A8", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0xA556E8", Offset = "0xA556E8", VA = "0xA556E8", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public override bool AsBool
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0xA556EC", Offset = "0xA556EC", VA = "0xA556EC", Slot = "39")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0xA556F4", Offset = "0xA556F4", VA = "0xA556F4", Slot = "40")]
			set
			{
			}
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xA4FFF0", Offset = "0xA4FFF0", VA = "0xA4FFF0")]
		public static JSONNull CreateOrGet()
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xA5562C", Offset = "0xA5562C", VA = "0xA5562C")]
		private JSONNull()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xA55694", Offset = "0xA55694", VA = "0xA55694", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xA556F8", Offset = "0xA556F8", VA = "0xA556F8", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xA55744", Offset = "0xA55744", VA = "0xA55744", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xA557D0", Offset = "0xA557D0", VA = "0xA557D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xA557D8", Offset = "0xA557D8", VA = "0xA557D8", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}
	}
	[Token(Token = "0x2000018")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_Key;

		[Token(Token = "0x17000048")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0xA5589C", Offset = "0xA5589C", VA = "0xA5589C", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000049")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0xA558B8", Offset = "0xA558B8", VA = "0xA558B8", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000102")]
			[Address(RVA = "0xA55918", Offset = "0xA55918", VA = "0xA55918", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0xA559B4", Offset = "0xA559B4", VA = "0xA559B4", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000104")]
			[Address(RVA = "0xA55A24", Offset = "0xA55A24", VA = "0xA55A24", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public override int AsInt
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0xA55C58", Offset = "0xA55C58", VA = "0xA55C58", Slot = "35")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600010C")]
			[Address(RVA = "0xA55CDC", Offset = "0xA55CDC", VA = "0xA55CDC", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public override float AsFloat
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0xA55D64", Offset = "0xA55D64", VA = "0xA55D64", Slot = "37")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0xA55DE8", Offset = "0xA55DE8", VA = "0xA55DE8", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public override double AsDouble
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0xA55E70", Offset = "0xA55E70", VA = "0xA55E70", Slot = "33")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000110")]
			[Address(RVA = "0xA55EF4", Offset = "0xA55EF4", VA = "0xA55EF4", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public override long AsLong
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0xA55F7C", Offset = "0xA55F7C", VA = "0xA55F7C", Slot = "41")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0xA5608C", Offset = "0xA5608C", VA = "0xA5608C", Slot = "42")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public override ulong AsULong
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0xA561C0", Offset = "0xA561C0", VA = "0xA561C0", Slot = "43")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x6000114")]
			[Address(RVA = "0xA562D0", Offset = "0xA562D0", VA = "0xA562D0", Slot = "44")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public override bool AsBool
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0xA56404", Offset = "0xA56404", VA = "0xA56404", Slot = "39")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000116")]
			[Address(RVA = "0xA56488", Offset = "0xA56488", VA = "0xA56488", Slot = "40")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0xA56510", Offset = "0xA56510", VA = "0xA56510", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public override JSONObject AsObject
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0xA56588", Offset = "0xA56588", VA = "0xA56588", Slot = "46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xA558A4", Offset = "0xA558A4", VA = "0xA558A4", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xA52924", Offset = "0xA52924", VA = "0xA52924")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xA53820", Offset = "0xA53820", VA = "0xA53820")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x6000100")]
		private T Set<T>(T aVal) where T : JSONNode
		{
			return null;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xA55AC8", Offset = "0xA55AC8", VA = "0xA55AC8", Slot = "21")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xA55B64", Offset = "0xA55B64", VA = "0xA55B64", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xA55C08", Offset = "0xA55C08", VA = "0xA55C08")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xA55C20", Offset = "0xA55C20", VA = "0xA55C20")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xA55C38", Offset = "0xA55C38", VA = "0xA55C38", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xA55C50", Offset = "0xA55C50", VA = "0xA55C50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xA56600", Offset = "0xA56600", VA = "0xA56600", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}
	}
	[Token(Token = "0x2000019")]
	public static class JSON
	{
		[Token(Token = "0x600011A")]
		[Address(RVA = "0xA56654", Offset = "0xA56654", VA = "0xA56654")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x200001A")]
	[AddComponentMenu("Scripts/RootMotion/Baker")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200001B")]
		public enum Mode
		{
			[Token(Token = "0x400004E")]
			AnimationClips,
			[Token(Token = "0x400004F")]
			AnimationStates,
			[Token(Token = "0x4000050")]
			PlayableDirector,
			[Token(Token = "0x4000051")]
			Realtime
		}

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(1f, 90f)]
		[Tooltip("In AnimationClips, AnimationStates or PlayableDirector mode - the frame rate at which the animation clip will be sampled. In Realtime mode - the frame rate at which the pose will be sampled. With the latter, the frame rate is not guaranteed if the player is not able to reach it.")]
		public int frameRate;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 0.1f)]
		[Tooltip("Maximum allowed error for keyframe reduction.")]
		public float keyReductionError;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("AnimationClips mode can be used to bake a batch of AnimationClips directly without the need of setting up an AnimatorController. AnimationStates mode is useful for when you need to set up a more complex rig with layers and AvatarMasks in Mecanim. PlayableDirector mode bakes a Timeline. Realtime mode is for continuous baking of gameplay, ragdoll phsysics or PuppetMaster dynamics.")]
		public Mode mode;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("AnimationClips to bake.")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The name of the AnimationStates to bake (must be on the base layer) in the Animator above (Right-click on this component header and select 'Find Animation States' to have Baker fill those in automatically, required that state names match with the names of the clips used in them).")]
		public string[] animationStates;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Sets the baked animation clip to loop time and matches the last frame keys with the first. Note that when overwriting a previously baked clip, AnimationClipSettings will be copied from the existing clip.")]
		public bool loop;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The folder to save the baked AnimationClips to.")]
		public string saveToFolder;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("String that will be added to each clip or animation state name for the saved clip. For example if your animation state/clip names were 'Idle' and 'Walk', then with '_Baked' as Append Name, the Baker will create 'Idle_Baked' and 'Walk_Baked' animation clips.")]
		public string appendName;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Name of the created AnimationClip file.")]
		public string saveName;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public Animator animator;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public PlayableDirector director;

		[Token(Token = "0x17000053")]
		public bool isBaking
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0xA567B8", Offset = "0xA567B8", VA = "0xA567B8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000120")]
			[Address(RVA = "0xA567C0", Offset = "0xA567C0", VA = "0xA567C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public float bakingProgress
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0xA567CC", Offset = "0xA567CC", VA = "0xA567CC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000122")]
			[Address(RVA = "0xA567D4", Offset = "0xA567D4", VA = "0xA567D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000055")]
		protected float clipLength
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0xA567DC", Offset = "0xA567DC", VA = "0xA567DC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000129")]
			[Address(RVA = "0xA567E4", Offset = "0xA567E4", VA = "0xA567E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xA566A8", Offset = "0xA566A8", VA = "0xA566A8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xA566EC", Offset = "0xA566EC", VA = "0xA566EC")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xA56730", Offset = "0xA56730", VA = "0xA56730")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xA56774", Offset = "0xA56774", VA = "0xA56774")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000123")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x6000124")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x6000125")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x6000126")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x6000127")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xA567EC", Offset = "0xA567EC", VA = "0xA567EC")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xA567F0", Offset = "0xA567F0", VA = "0xA567F0")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xA567F4", Offset = "0xA567F4", VA = "0xA567F4")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xA567F8", Offset = "0xA567F8", VA = "0xA567F8")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("If true, produced AnimationClips will be marked as Legacy and usable with the Legacy animation system.")]
		public bool markAsLegacy;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Root Transform of the hierarchy to bake.")]
		public Transform root;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("Root Node used for root motion.")]
		public Transform rootNode;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("List of Transforms to ignore, rotation curves will not be baked for these Transforms.")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Tooltip("LocalPosition curves will be baked for these Transforms only. If you are baking a character, the pelvis bone should be added to this array.")]
		public Transform[] bakePositionList;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerTransform[] children;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerTransform rootChild;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int rootChildIndex;

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xA568F0", Offset = "0xA568F0", VA = "0xA568F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xA56D0C", Offset = "0xA56D0C", VA = "0xA56D0C", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xA56D14", Offset = "0xA56D14", VA = "0xA56D14", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xA56F00", Offset = "0xA56F00", VA = "0xA56F00", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xA57164", Offset = "0xA57164", VA = "0xA57164", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xA5747C", Offset = "0xA5747C", VA = "0xA5747C", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xA56B08", Offset = "0xA56B08", VA = "0xA56B08")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xA56BC0", Offset = "0xA56BC0", VA = "0xA56BC0")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xA576DC", Offset = "0xA576DC", VA = "0xA576DC")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class TQ
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xA57738", Offset = "0xA57738", VA = "0xA57738")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class AvatarUtility
	{
		[Token(Token = "0x6000138")]
		[Address(RVA = "0xA5779C", Offset = "0xA5779C", VA = "0xA5779C")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xA579EC", Offset = "0xA579EC", VA = "0xA579EC")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xA579CC", Offset = "0xA579CC", VA = "0xA579CC")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xA58044", Offset = "0xA58044", VA = "0xA58044")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public static class BakerUtilities
	{
		[Token(Token = "0x600013C")]
		[Address(RVA = "0xA5804C", Offset = "0xA5804C", VA = "0xA5804C")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xA58084", Offset = "0xA58084", VA = "0xA58084")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xA58448", Offset = "0xA58448", VA = "0xA58448")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xA58628", Offset = "0xA58628", VA = "0xA58628")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xA5862C", Offset = "0xA5862C", VA = "0xA5862C")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x2000020")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xA587C0", Offset = "0xA587C0", VA = "0xA587C0")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xA58A7C", Offset = "0xA58A7C", VA = "0xA58A7C")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xA58938", Offset = "0xA58938", VA = "0xA58938")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xA58C04", Offset = "0xA58C04", VA = "0xA58C04")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xA58F94", Offset = "0xA58F94", VA = "0xA58F94")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xA59084", Offset = "0xA59084", VA = "0xA59084")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xA59168", Offset = "0xA59168", VA = "0xA59168")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xA590EC", Offset = "0xA590EC", VA = "0xA590EC")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xA591D0", Offset = "0xA591D0", VA = "0xA591D0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xA59278", Offset = "0xA59278", VA = "0xA59278")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000021")]
	public class BakerMuscle
	{
		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xA59564", Offset = "0xA59564", VA = "0xA59564")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xA595C8", Offset = "0xA595C8", VA = "0xA595C8")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xA5A05C", Offset = "0xA5A05C", VA = "0xA5A05C")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xA5A104", Offset = "0xA5A104", VA = "0xA5A104")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xA59FFC", Offset = "0xA59FFC", VA = "0xA59FFC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xA5A1F8", Offset = "0xA5A1F8", VA = "0xA5A1F8")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xA5A234", Offset = "0xA5A234", VA = "0xA5A234")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000022")]
	public class BakerTransform
	{
		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xA56C78", Offset = "0xA56C78", VA = "0xA56C78")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xA56EEC", Offset = "0xA56EEC", VA = "0xA56EEC")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xA571C8", Offset = "0xA571C8", VA = "0xA571C8")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xA5A23C", Offset = "0xA5A23C", VA = "0xA5A23C")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xA56DE4", Offset = "0xA56DE4", VA = "0xA56DE4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xA5A4C4", Offset = "0xA5A4C4", VA = "0xA5A4C4")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xA574E8", Offset = "0xA574E8", VA = "0xA574E8")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xA56F6C", Offset = "0xA56F6C", VA = "0xA56F6C")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("Should the hand IK curves be added to the animation? Disable this if the original hand positions are not important when using the clip on another character via Humanoid retargeting.")]
		public bool bakeHandIK;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Max keyframe reduction error for the Root.Q/T, LeftFoot IK and RightFoot IK channels. Having a larger error value for 'Key Reduction Error' and a smaller one for this enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(0f, 0.1f)]
		public float IKKeyReductionError;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(1f, 9f)]
		[Tooltip("Frame rate divider for the muscle curves. If you have 'Frame Rate' set to 30, and this value set to 3, the muscle curves will be baked at 10 fps. Only the Root Q/T and Hand and Foot IK curves will be baked at 30. This enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		public int muscleFrameRateDiv;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float[] muscles;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HumanPose pose;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HumanPoseHandler handler;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 bodyPosition;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion bodyRotation;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int mN;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xA5A52C", Offset = "0xA5A52C", VA = "0xA5A52C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xA5A9E4", Offset = "0xA5A9E4", VA = "0xA5A9E4", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xA5AA00", Offset = "0xA5AA00", VA = "0xA5AA00", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xA5AADC", Offset = "0xA5AADC", VA = "0xA5AADC", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xA5AB98", Offset = "0xA5AB98", VA = "0xA5AB98", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xA5AD38", Offset = "0xA5AD38", VA = "0xA5AD38", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xA5B04C", Offset = "0xA5B04C", VA = "0xA5B04C")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xA5B124", Offset = "0xA5B124", VA = "0xA5B124")]
		public HumanoidBaker()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000025")]
		public enum UpdateMode
		{
			[Token(Token = "0x40000B5")]
			Update,
			[Token(Token = "0x40000B6")]
			FixedUpdate,
			[Token(Token = "0x40000B7")]
			LateUpdate,
			[Token(Token = "0x40000B8")]
			FixedLateUpdate
		}

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[Header("Position")]
		public bool smoothFollow;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Rotation")]
		public float rotationSensitivity;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Distance")]
		public float distance;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Header("Blocking")]
		public LayerMask blockingLayers;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float blockingOriginOffset;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Range(0f, 1f)]
		public float blockedOffset;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 targetDistance;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 position;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion rotation;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 smoothPosition;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000056")]
		public float x
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0xA5B1C8", Offset = "0xA5B1C8", VA = "0xA5B1C8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000163")]
			[Address(RVA = "0xA5B1D0", Offset = "0xA5B1D0", VA = "0xA5B1D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public float y
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0xA5B1D8", Offset = "0xA5B1D8", VA = "0xA5B1D8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000165")]
			[Address(RVA = "0xA5B1E0", Offset = "0xA5B1E0", VA = "0xA5B1E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public float distanceTarget
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0xA5B1E8", Offset = "0xA5B1E8", VA = "0xA5B1E8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000167")]
			[Address(RVA = "0xA5B1F0", Offset = "0xA5B1F0", VA = "0xA5B1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000059")]
		private float zoomAdd
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0xA5BC48", Offset = "0xA5BC48", VA = "0xA5BC48")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xA5B1F8", Offset = "0xA5B1F8", VA = "0xA5B1F8")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xA5B230", Offset = "0xA5B230", VA = "0xA5B230")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xA5B238", Offset = "0xA5B238", VA = "0xA5B238", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xA5B360", Offset = "0xA5B360", VA = "0xA5B360", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xA5B3A8", Offset = "0xA5B3A8", VA = "0xA5B3A8", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xA5B400", Offset = "0xA5B400", VA = "0xA5B400", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xA5B458", Offset = "0xA5B458", VA = "0xA5B458")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xA5B38C", Offset = "0xA5B38C", VA = "0xA5B38C")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xA5B5E4", Offset = "0xA5B5E4", VA = "0xA5B5E4")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xA5BC0C", Offset = "0xA5BC0C", VA = "0xA5BC0C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xA5BCB4", Offset = "0xA5BCB4", VA = "0xA5BCB4")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xA5BD7C", Offset = "0xA5BD7C", VA = "0xA5BD7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xA5BDA8", Offset = "0xA5BDA8", VA = "0xA5BDA8")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xA5BFCC", Offset = "0xA5BFCC", VA = "0xA5BFCC")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xA5C008", Offset = "0xA5C008", VA = "0xA5C008")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000027")]
	public enum Axis
	{
		[Token(Token = "0x40000BF")]
		X,
		[Token(Token = "0x40000C0")]
		Y,
		[Token(Token = "0x40000C1")]
		Z
	}
	[Token(Token = "0x2000028")]
	public class AxisTools
	{
		[Token(Token = "0x6000178")]
		[Address(RVA = "0xA5C024", Offset = "0xA5C024", VA = "0xA5C024")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xA5C104", Offset = "0xA5C104", VA = "0xA5C104")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xA5C13C", Offset = "0xA5C13C", VA = "0xA5C13C")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xA5C284", Offset = "0xA5C284", VA = "0xA5C284")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xA5C238", Offset = "0xA5C238", VA = "0xA5C238")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xA5C380", Offset = "0xA5C380", VA = "0xA5C380")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xA5C3C4", Offset = "0xA5C3C4", VA = "0xA5C3C4")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xA5C850", Offset = "0xA5C850", VA = "0xA5C850")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000029")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x200002A")]
		public class LimbOrientation
		{
			[Token(Token = "0x40000C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40000C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40000C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000183")]
			[Address(RVA = "0xA5CB4C", Offset = "0xA5CB4C", VA = "0xA5CB4C")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x1700005A")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0xA5C898", Offset = "0xA5C898", VA = "0xA5C898")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0xA5CBC0", Offset = "0xA5CBC0", VA = "0xA5CBC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xA5C858", Offset = "0xA5C858", VA = "0xA5C858")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x200002B")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x200002C")]
		public enum BoneType
		{
			[Token(Token = "0x40000DC")]
			Unassigned,
			[Token(Token = "0x40000DD")]
			Spine,
			[Token(Token = "0x40000DE")]
			Head,
			[Token(Token = "0x40000DF")]
			Arm,
			[Token(Token = "0x40000E0")]
			Leg,
			[Token(Token = "0x40000E1")]
			Tail,
			[Token(Token = "0x40000E2")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x200002D")]
		public enum BoneSide
		{
			[Token(Token = "0x40000E4")]
			Center,
			[Token(Token = "0x40000E5")]
			Left,
			[Token(Token = "0x40000E6")]
			Right
		}

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xA5CE74", Offset = "0xA5CE74", VA = "0xA5CE74")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xA5D138", Offset = "0xA5D138", VA = "0xA5D138")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xA5D36C", Offset = "0xA5D36C", VA = "0xA5D36C")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xA5D3E0", Offset = "0xA5D3E0", VA = "0xA5D3E0")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xA5D474", Offset = "0xA5D474", VA = "0xA5D474")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xA5D020", Offset = "0xA5D020", VA = "0xA5D020")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xA5D2E4", Offset = "0xA5D2E4", VA = "0xA5D2E4")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xA5DBAC", Offset = "0xA5DBAC", VA = "0xA5DBAC")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xA5DA04", Offset = "0xA5DA04", VA = "0xA5DA04")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xA5DAD8", Offset = "0xA5DAD8", VA = "0xA5DAD8")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xA5D65C", Offset = "0xA5D65C", VA = "0xA5D65C")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xA5D6F8", Offset = "0xA5D6F8", VA = "0xA5D6F8")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xA5D794", Offset = "0xA5D794", VA = "0xA5D794")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xA5D830", Offset = "0xA5D830", VA = "0xA5D830")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xA5D8CC", Offset = "0xA5D8CC", VA = "0xA5D8CC")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xA5D968", Offset = "0xA5D968", VA = "0xA5D968")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xA5DD94", Offset = "0xA5DD94", VA = "0xA5DD94")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xA5D588", Offset = "0xA5D588", VA = "0xA5D588")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xA5DD10", Offset = "0xA5DD10", VA = "0xA5DD10")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xA5DDF4", Offset = "0xA5DDF4", VA = "0xA5DDF4")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xA5DEB4", Offset = "0xA5DEB4", VA = "0xA5DEB4")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xA5DC9C", Offset = "0xA5DC9C", VA = "0xA5DC9C")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xA5DC2C", Offset = "0xA5DC2C", VA = "0xA5DC2C")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200002E")]
	public class BipedReferences
	{
		[Token(Token = "0x200002F")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40000F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40000F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700005E")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60001B5")]
				[Address(RVA = "0xA6371C", Offset = "0xA6371C", VA = "0xA6371C")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xA63708", Offset = "0xA63708", VA = "0xA63708")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700005C")]
		public virtual bool isFilled
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0xA5FEAC", Offset = "0xA5FEAC", VA = "0xA5FEAC", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		public bool isEmpty
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0xA60208", Offset = "0xA60208", VA = "0xA60208")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xA60218", Offset = "0xA60218", VA = "0xA60218", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xA605A4", Offset = "0xA605A4", VA = "0xA605A4", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xA60934", Offset = "0xA60934", VA = "0xA60934")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xA60F60", Offset = "0xA60F60", VA = "0xA60F60")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xA60B9C", Offset = "0xA60B9C", VA = "0xA60B9C")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xA616A8", Offset = "0xA616A8", VA = "0xA616A8")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xA61788", Offset = "0xA61788", VA = "0xA61788")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xA62200", Offset = "0xA62200", VA = "0xA62200")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xA62020", Offset = "0xA62020", VA = "0xA62020")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xA61DC0", Offset = "0xA61DC0", VA = "0xA61DC0")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xA61824", Offset = "0xA61824", VA = "0xA61824")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xA62114", Offset = "0xA62114", VA = "0xA62114")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xA622E0", Offset = "0xA622E0", VA = "0xA622E0")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xA62DA0", Offset = "0xA62DA0", VA = "0xA62DA0")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xA62860", Offset = "0xA62860", VA = "0xA62860")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xA63074", Offset = "0xA63074", VA = "0xA63074")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xA62BB4", Offset = "0xA62BB4", VA = "0xA62BB4")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xA6307C", Offset = "0xA6307C", VA = "0xA6307C")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xA63084", Offset = "0xA63084", VA = "0xA63084")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xA63238", Offset = "0xA63238", VA = "0xA63238")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xA636A0", Offset = "0xA636A0", VA = "0xA636A0")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xA60B34", Offset = "0xA60B34", VA = "0xA60B34")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xA63724", Offset = "0xA63724", VA = "0xA63724")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xA6372C", Offset = "0xA6372C", VA = "0xA6372C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xA63824", Offset = "0xA63824", VA = "0xA63824")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class Hierarchy
	{
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xA6361C", Offset = "0xA6361C", VA = "0xA6361C")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xA63510", Offset = "0xA63510", VA = "0xA63510")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xA61900", Offset = "0xA61900", VA = "0xA61900")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xA61F10", Offset = "0xA61F10", VA = "0xA61F10")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xA61B80", Offset = "0xA61B80", VA = "0xA61B80")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xA63834", Offset = "0xA63834", VA = "0xA63834")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xA61A30", Offset = "0xA61A30", VA = "0xA61A30")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xA63928", Offset = "0xA63928", VA = "0xA63928")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xA63C94", Offset = "0xA63C94", VA = "0xA63C94")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xA63A8C", Offset = "0xA63A8C", VA = "0xA63A8C")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xA63E1C", Offset = "0xA63E1C", VA = "0xA63E1C")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xA63E24", Offset = "0xA63E24", VA = "0xA63E24")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xA63E8C", Offset = "0xA63E8C", VA = "0xA63E8C")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000034")]
	public enum InterpolationMode
	{
		[Token(Token = "0x4000100")]
		None,
		[Token(Token = "0x4000101")]
		InOutCubic,
		[Token(Token = "0x4000102")]
		InOutQuintic,
		[Token(Token = "0x4000103")]
		InOutSine,
		[Token(Token = "0x4000104")]
		InQuintic,
		[Token(Token = "0x4000105")]
		InQuartic,
		[Token(Token = "0x4000106")]
		InCubic,
		[Token(Token = "0x4000107")]
		InQuadratic,
		[Token(Token = "0x4000108")]
		InElastic,
		[Token(Token = "0x4000109")]
		InElasticSmall,
		[Token(Token = "0x400010A")]
		InElasticBig,
		[Token(Token = "0x400010B")]
		InSine,
		[Token(Token = "0x400010C")]
		InBack,
		[Token(Token = "0x400010D")]
		OutQuintic,
		[Token(Token = "0x400010E")]
		OutQuartic,
		[Token(Token = "0x400010F")]
		OutCubic,
		[Token(Token = "0x4000110")]
		OutInCubic,
		[Token(Token = "0x4000111")]
		OutInQuartic,
		[Token(Token = "0x4000112")]
		OutElastic,
		[Token(Token = "0x4000113")]
		OutElasticSmall,
		[Token(Token = "0x4000114")]
		OutElasticBig,
		[Token(Token = "0x4000115")]
		OutSine,
		[Token(Token = "0x4000116")]
		OutBack,
		[Token(Token = "0x4000117")]
		OutBackCubic,
		[Token(Token = "0x4000118")]
		OutBackQuartic,
		[Token(Token = "0x4000119")]
		BackInCubic,
		[Token(Token = "0x400011A")]
		BackInQuartic
	}
	[Token(Token = "0x2000035")]
	public class Interp
	{
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xA63EF4", Offset = "0xA63EF4", VA = "0xA63EF4")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xA6487C", Offset = "0xA6487C", VA = "0xA6487C")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xA648EC", Offset = "0xA648EC", VA = "0xA648EC")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xA642F4", Offset = "0xA642F4", VA = "0xA642F4")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xA64300", Offset = "0xA64300", VA = "0xA64300")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xA64324", Offset = "0xA64324", VA = "0xA64324")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xA64360", Offset = "0xA64360", VA = "0xA64360")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xA64378", Offset = "0xA64378", VA = "0xA64378")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xA6438C", Offset = "0xA6438C", VA = "0xA6438C")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xA643A0", Offset = "0xA643A0", VA = "0xA643A0")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xA643B0", Offset = "0xA643B0", VA = "0xA643B0")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xA643F8", Offset = "0xA643F8", VA = "0xA643F8")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xA64430", Offset = "0xA64430", VA = "0xA64430")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xA64458", Offset = "0xA64458", VA = "0xA64458")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xA6495C", Offset = "0xA6495C", VA = "0xA6495C")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xA6448C", Offset = "0xA6448C", VA = "0xA6448C")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xA644B4", Offset = "0xA644B4", VA = "0xA644B4")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xA644E4", Offset = "0xA644E4", VA = "0xA644E4")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xA64518", Offset = "0xA64518", VA = "0xA64518")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xA6455C", Offset = "0xA6455C", VA = "0xA6455C")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xA645C0", Offset = "0xA645C0", VA = "0xA645C0")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xA64624", Offset = "0xA64624", VA = "0xA64624")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xA64678", Offset = "0xA64678", VA = "0xA64678")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xA646CC", Offset = "0xA646CC", VA = "0xA646CC")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xA64704", Offset = "0xA64704", VA = "0xA64704")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xA64738", Offset = "0xA64738", VA = "0xA64738")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xA64990", Offset = "0xA64990", VA = "0xA64990")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xA6477C", Offset = "0xA6477C", VA = "0xA6477C")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xA6480C", Offset = "0xA6480C", VA = "0xA6480C")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xA6483C", Offset = "0xA6483C", VA = "0xA6483C")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xA64A20", Offset = "0xA64A20", VA = "0xA64A20")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xA65A28", Offset = "0xA65A28", VA = "0xA65A28")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xA65A90", Offset = "0xA65A90", VA = "0xA65A90")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000037")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xA65AF8", Offset = "0xA65AF8", VA = "0xA65AF8")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xA65B44", Offset = "0xA65B44", VA = "0xA65B44")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xA65C00", Offset = "0xA65C00", VA = "0xA65C00")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xA65B58", Offset = "0xA65B58", VA = "0xA65B58")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xA65C14", Offset = "0xA65C14", VA = "0xA65C14")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xA65CA4", Offset = "0xA65CA4", VA = "0xA65CA4")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xA65CCC", Offset = "0xA65CCC", VA = "0xA65CCC")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xA65D18", Offset = "0xA65D18", VA = "0xA65D18")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xA65D80", Offset = "0xA65D80", VA = "0xA65D80")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xA65ED4", Offset = "0xA65ED4", VA = "0xA65ED4")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xA6600C", Offset = "0xA6600C", VA = "0xA6600C")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xA66064", Offset = "0xA66064", VA = "0xA66064")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000038")]
	public static class QuaTools
	{
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xA66088", Offset = "0xA66088", VA = "0xA66088")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xA660E0", Offset = "0xA660E0", VA = "0xA660E0")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xA66210", Offset = "0xA66210", VA = "0xA66210")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xA66390", Offset = "0xA66390", VA = "0xA66390")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xA6646C", Offset = "0xA6646C", VA = "0xA6646C")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xA66548", Offset = "0xA66548", VA = "0xA66548")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xA66760", Offset = "0xA66760", VA = "0xA66760")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xA667AC", Offset = "0xA667AC", VA = "0xA667AC")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xA667F8", Offset = "0xA667F8", VA = "0xA667F8")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xA668FC", Offset = "0xA668FC", VA = "0xA668FC")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xA66A00", Offset = "0xA66A00", VA = "0xA66A00")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xA66B14", Offset = "0xA66B14", VA = "0xA66B14")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xA66BBC", Offset = "0xA66BBC", VA = "0xA66BBC")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xA66CC8", Offset = "0xA66CC8", VA = "0xA66CC8")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xA66E30", Offset = "0xA66E30", VA = "0xA66E30")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xA67014", Offset = "0xA67014", VA = "0xA67014")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xA670E4", Offset = "0xA670E4", VA = "0xA670E4")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xA67268", Offset = "0xA67268", VA = "0xA67268")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xA67374", Offset = "0xA67374", VA = "0xA67374")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000039")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700005F")]
		public static T instance
		{
			[Token(Token = "0x6000206")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000207")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000208")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000060")]
		private bool animatePhysics
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0xA674E8", Offset = "0xA674E8", VA = "0xA674E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000061")]
		private bool isAnimated
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0xA677A8", Offset = "0xA677A8", VA = "0xA677A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xA673CC", Offset = "0xA673CC", VA = "0xA673CC")]
		public void Disable()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xA67460", Offset = "0xA67460", VA = "0xA67460", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xA67464", Offset = "0xA67464", VA = "0xA67464", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xA67468", Offset = "0xA67468", VA = "0xA67468", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xA6746C", Offset = "0xA6746C", VA = "0xA6746C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xA674E4", Offset = "0xA674E4", VA = "0xA674E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xA67494", Offset = "0xA67494", VA = "0xA67494")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xA6776C", Offset = "0xA6776C", VA = "0xA6776C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xA675B4", Offset = "0xA675B4", VA = "0xA675B4")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xA67840", Offset = "0xA67840", VA = "0xA67840")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xA6788C", Offset = "0xA6788C", VA = "0xA6788C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xA678D8", Offset = "0xA678D8", VA = "0xA678D8")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xA67910", Offset = "0xA67910", VA = "0xA67910")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xA67920", Offset = "0xA67920", VA = "0xA67920")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xA679D4", Offset = "0xA679D4", VA = "0xA679D4")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xA67A88", Offset = "0xA67A88", VA = "0xA67A88")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xA67B3C", Offset = "0xA67B3C", VA = "0xA67B3C")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public static class V2Tools
	{
		[Token(Token = "0x600021C")]
		[Address(RVA = "0xA67B44", Offset = "0xA67B44", VA = "0xA67B44")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xA67B4C", Offset = "0xA67B4C", VA = "0xA67B4C")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xA67BDC", Offset = "0xA67BDC", VA = "0xA67BDC")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xA67C70", Offset = "0xA67C70", VA = "0xA67C70")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xA67D20", Offset = "0xA67D20", VA = "0xA67D20")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200003D")]
	public static class V3Tools
	{
		[Token(Token = "0x6000221")]
		[Address(RVA = "0xA67D7C", Offset = "0xA67D7C", VA = "0xA67D7C")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xA67D9C", Offset = "0xA67D9C", VA = "0xA67D9C")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xA67E70", Offset = "0xA67E70", VA = "0xA67E70")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xA67F28", Offset = "0xA67F28", VA = "0xA67F28")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xA67F84", Offset = "0xA67F84", VA = "0xA67F84")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xA67FE0", Offset = "0xA67FE0", VA = "0xA67FE0")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xA680F8", Offset = "0xA680F8", VA = "0xA680F8")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xA68154", Offset = "0xA68154", VA = "0xA68154")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xA6818C", Offset = "0xA6818C", VA = "0xA6818C")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xA682DC", Offset = "0xA682DC", VA = "0xA682DC")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xA68458", Offset = "0xA68458", VA = "0xA68458")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xA68688", Offset = "0xA68688", VA = "0xA68688")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xA688D8", Offset = "0xA688D8", VA = "0xA688D8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xA68B30", Offset = "0xA68B30", VA = "0xA68B30")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xA68CDC", Offset = "0xA68CDC", VA = "0xA68CDC")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xA68ED4", Offset = "0xA68ED4", VA = "0xA68ED4")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xA68F50", Offset = "0xA68F50", VA = "0xA68F50")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xA68FE0", Offset = "0xA68FE0", VA = "0xA68FE0")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xA69078", Offset = "0xA69078", VA = "0xA69078")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xA69068", Offset = "0xA69068", VA = "0xA69068")]
		public static Vector3 Div(Vector3 v1, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200003E")]
	public static class Warning
	{
		[Token(Token = "0x200003F")]
		public delegate void Logger(string message);

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xA690F4", Offset = "0xA690F4", VA = "0xA690F4")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xA6918C", Offset = "0xA6918C", VA = "0xA6918C")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000040")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xA69354", Offset = "0xA69354", VA = "0xA69354")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xA69398", Offset = "0xA69398", VA = "0xA69398")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xA693DC", Offset = "0xA693DC", VA = "0xA693DC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xA69420", Offset = "0xA69420", VA = "0xA69420")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xA69464", Offset = "0xA69464", VA = "0xA69464")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xA694FC", Offset = "0xA694FC", VA = "0xA694FC")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xA69518", Offset = "0xA69518", VA = "0xA69518")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xA69544", Offset = "0xA69544", VA = "0xA69544")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xA69570", Offset = "0xA69570", VA = "0xA69570")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xA695AC", Offset = "0xA695AC", VA = "0xA695AC")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xA695EC", Offset = "0xA695EC", VA = "0xA695EC")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xA6960C", Offset = "0xA6960C", VA = "0xA6960C")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xA6962C", Offset = "0xA6962C", VA = "0xA6962C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xA69650", Offset = "0xA69650", VA = "0xA69650")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xA69678", Offset = "0xA69678", VA = "0xA69678")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xA696A0", Offset = "0xA696A0", VA = "0xA696A0")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xA69480", Offset = "0xA69480", VA = "0xA69480")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xA696C4", Offset = "0xA696C4", VA = "0xA696C4")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xA696D0", Offset = "0xA696D0", VA = "0xA696D0")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xA696DC", Offset = "0xA696DC", VA = "0xA696DC")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xA69948", Offset = "0xA69948", VA = "0xA69948", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xA699E4", Offset = "0xA699E4", VA = "0xA699E4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xA69D08", Offset = "0xA69D08", VA = "0xA69D08", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xA6A174", Offset = "0xA6A174", VA = "0xA6A174")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xA6A198", Offset = "0xA6A198", VA = "0xA6A198")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000041")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000062")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0xA69818", Offset = "0xA69818", VA = "0xA69818")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0xA6A3C0", Offset = "0xA6A3C0", VA = "0xA6A3C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xA69B98", Offset = "0xA69B98", VA = "0xA69B98")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xA6A234", Offset = "0xA6A234", VA = "0xA6A234")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000042")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000064")]
		public bool isValid
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0xA6A57C", Offset = "0xA6A57C", VA = "0xA6A57C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000259")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xA6A5DC", Offset = "0xA6A5DC", VA = "0xA6A5DC")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xA6A5E4", Offset = "0xA6A5E4", VA = "0xA6A5E4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xA6A67C", Offset = "0xA6A67C", VA = "0xA6A67C")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xA6A684", Offset = "0xA6A684", VA = "0xA6A684")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000065")]
		private bool positionChanged
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0xA6A7B0", Offset = "0xA6A7B0", VA = "0xA6A7B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xA6A6AC", Offset = "0xA6A6AC", VA = "0xA6A6AC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xA6A80C", Offset = "0xA6A80C", VA = "0xA6A80C")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xA6A814", Offset = "0xA6A814", VA = "0xA6A814")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xA6A83C", Offset = "0xA6A83C", VA = "0xA6A83C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xA6A8B8", Offset = "0xA6A8B8", VA = "0xA6A8B8")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xA6A8C0", Offset = "0xA6A8C0", VA = "0xA6A8C0")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000066")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0xA6A9EC", Offset = "0xA6A9EC", VA = "0xA6A9EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xA6A8E8", Offset = "0xA6A8E8", VA = "0xA6A8E8", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xA6AA44", Offset = "0xA6AA44", VA = "0xA6AA44")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xA6AA4C", Offset = "0xA6AA4C", VA = "0xA6AA4C")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public class Constraints
	{
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xA6AA74", Offset = "0xA6AA74", VA = "0xA6AA74")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xA69CB8", Offset = "0xA69CB8", VA = "0xA69CB8")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xA69E7C", Offset = "0xA69E7C", VA = "0xA69E7C")]
		public void Update()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xA6A574", Offset = "0xA6A574", VA = "0xA6A574")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000048")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x2000049")]
		public enum DOF
		{
			[Token(Token = "0x400015B")]
			One,
			[Token(Token = "0x400015C")]
			Three
		}

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Master Weight for the finger.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Rotational degrees of freedom. When set to 'One' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
		public DOF rotationDOF;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("If enabled, keeps bone1 twist angle fixed relative to bone2.")]
		public bool fixBone1Twist;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 defaultBendNormal;

		[Token(Token = "0x17000067")]
		public bool initiated
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0xA6AAD4", Offset = "0xA6AAD4", VA = "0xA6AAD4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0xA6AADC", Offset = "0xA6AADC", VA = "0xA6AADC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0xA6AAE8", Offset = "0xA6AAE8", VA = "0xA6AAE8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000270")]
			[Address(RVA = "0xA6AB08", Offset = "0xA6AB08", VA = "0xA6AB08")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0xA6AB28", Offset = "0xA6AB28", VA = "0xA6AB28")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000272")]
			[Address(RVA = "0xA6AB48", Offset = "0xA6AB48", VA = "0xA6AB48")]
			set
			{
			}
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xA6AB68", Offset = "0xA6AB68", VA = "0xA6AB68")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xA6AC54", Offset = "0xA6AC54", VA = "0xA6AC54")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xA6B2BC", Offset = "0xA6B2BC", VA = "0xA6B2BC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xA6B388", Offset = "0xA6B388", VA = "0xA6B388")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xA6B440", Offset = "0xA6B440", VA = "0xA6B440")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xA6B9D8", Offset = "0xA6B9D8", VA = "0xA6B9D8")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("The master weight for all fingers.")]
		public float weight;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x1700006A")]
		public bool initiated
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0xA6B9E8", Offset = "0xA6B9E8", VA = "0xA6B9E8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600027A")]
			[Address(RVA = "0xA6B9F0", Offset = "0xA6B9F0", VA = "0xA6B9F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xA6B9FC", Offset = "0xA6B9FC", VA = "0xA6B9FC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xA6BA70", Offset = "0xA6BA70", VA = "0xA6BA70")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xA6BD7C", Offset = "0xA6BD7C", VA = "0xA6BD7C")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xA6BEE8", Offset = "0xA6BEE8", VA = "0xA6BEE8")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xA6BC94", Offset = "0xA6BC94", VA = "0xA6BC94")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xA6C048", Offset = "0xA6C048", VA = "0xA6C048", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xA6C0F0", Offset = "0xA6C0F0", VA = "0xA6C0F0")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xA6C154", Offset = "0xA6C154", VA = "0xA6C154")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xA6C1BC", Offset = "0xA6C1BC", VA = "0xA6C1BC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xA6C218", Offset = "0xA6C218", VA = "0xA6C218", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xA6C21C", Offset = "0xA6C21C", VA = "0xA6C21C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xA6C230", Offset = "0xA6C230", VA = "0xA6C230")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x200004C")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		public float weight;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x1700006B")]
		public bool initiated
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0xA6C298", Offset = "0xA6C298", VA = "0xA6C298")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000289")]
			[Address(RVA = "0xA6C2A0", Offset = "0xA6C2A0", VA = "0xA6C2A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x6000287")]
		public abstract void ResetPosition();

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xA6C2AC", Offset = "0xA6C2AC", VA = "0xA6C2AC")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xA6C55C", Offset = "0xA6C55C", VA = "0xA6C55C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xA6C370", Offset = "0xA6C370", VA = "0xA6C370")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xA6C580", Offset = "0xA6C580", VA = "0xA6C580")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028E")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600028F")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xA6C6F4", Offset = "0xA6C6F4", VA = "0xA6C6F4")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200004D")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xA6C8FC", Offset = "0xA6C8FC", VA = "0xA6C8FC", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xA6C940", Offset = "0xA6C940", VA = "0xA6C940", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xA6C984", Offset = "0xA6C984", VA = "0xA6C984", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xA6CA64", Offset = "0xA6CA64", VA = "0xA6CA64")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xA6CB04", Offset = "0xA6CB04", VA = "0xA6CB04")]
		private void Update()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xA6CB58", Offset = "0xA6CB58", VA = "0xA6CB58")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xA6D0C8", Offset = "0xA6D0C8", VA = "0xA6D0C8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xA6D108", Offset = "0xA6D108", VA = "0xA6D108")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xA6D77C", Offset = "0xA6D77C", VA = "0xA6D77C")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xA6D8A4", Offset = "0xA6D8A4", VA = "0xA6D8A4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xA6DA74", Offset = "0xA6DA74", VA = "0xA6DA74")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xA6DC1C", Offset = "0xA6DC1C", VA = "0xA6DC1C")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x200004F")]
		public class SpineEffector
		{
			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight;

			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;

			[Token(Token = "0x60002AF")]
			[Address(RVA = "0xA6E8B4", Offset = "0xA6E8B4", VA = "0xA6E8B4")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60002B0")]
			[Address(RVA = "0xA6E8C4", Offset = "0xA6E8C4", VA = "0xA6E8C4")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xA6DCA8", Offset = "0xA6DCA8", VA = "0xA6DCA8")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xA6DCEC", Offset = "0xA6DCEC", VA = "0xA6DCEC", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xA6DD30", Offset = "0xA6DD30", VA = "0xA6DD30", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xA6DD74", Offset = "0xA6DD74", VA = "0xA6DD74", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xA6DDDC", Offset = "0xA6DDDC", VA = "0xA6DDDC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xA6DE64", Offset = "0xA6DE64", VA = "0xA6DE64")]
		private void Update()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xA6E0D4", Offset = "0xA6E0D4", VA = "0xA6E0D4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xA6E0E0", Offset = "0xA6E0E0", VA = "0xA6E0E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xA6DEC0", Offset = "0xA6DEC0", VA = "0xA6DEC0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xA6E0EC", Offset = "0xA6E0EC", VA = "0xA6E0EC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xA6E45C", Offset = "0xA6E45C", VA = "0xA6E45C")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xA6E5E0", Offset = "0xA6E5E0", VA = "0xA6E5E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xA6E714", Offset = "0xA6E714", VA = "0xA6E714")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xA6E828", Offset = "0xA6E828", VA = "0xA6E828")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
		public float maxRootRotationAngle;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xA6E908", Offset = "0xA6E908", VA = "0xA6E908", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xA6E94C", Offset = "0xA6E94C", VA = "0xA6E94C", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xA6E990", Offset = "0xA6E990", VA = "0xA6E990", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xA6E9A8", Offset = "0xA6E9A8", VA = "0xA6E9A8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xA6EBC4", Offset = "0xA6EBC4", VA = "0xA6EBC4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xA6ECA4", Offset = "0xA6ECA4", VA = "0xA6ECA4")]
		private void Update()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xA6F390", Offset = "0xA6F390", VA = "0xA6F390")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xA6F7F0", Offset = "0xA6F7F0", VA = "0xA6F7F0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xA6F99C", Offset = "0xA6F99C", VA = "0xA6F99C")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xA6FD24", Offset = "0xA6FD24", VA = "0xA6FD24")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xA6FEFC", Offset = "0xA6FEFC", VA = "0xA6FEFC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xA70100", Offset = "0xA70100", VA = "0xA70100")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x2000052")]
		public struct Foot
		{
			[Token(Token = "0x40001A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x40001A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x40001A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x40001A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0xA70C58", Offset = "0xA70C58", VA = "0xA70C58")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		public float rootRotationWeight;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		[Range(-90f, 0f)]
		public float minRootRotation;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 90f)]
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		public float maxRootRotation;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("The head (optional, if you intend to maintain it's rotation).")]
		public Transform head;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xA7018C", Offset = "0xA7018C", VA = "0xA7018C", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xA701D0", Offset = "0xA701D0", VA = "0xA701D0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xA70214", Offset = "0xA70214", VA = "0xA70214", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xA7023C", Offset = "0xA7023C", VA = "0xA7023C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xA70340", Offset = "0xA70340", VA = "0xA70340")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xA70534", Offset = "0xA70534", VA = "0xA70534")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xA70598", Offset = "0xA70598", VA = "0xA70598")]
		private void Update()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xA705F0", Offset = "0xA705F0", VA = "0xA705F0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xA70904", Offset = "0xA70904", VA = "0xA70904")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xA70C8C", Offset = "0xA70C8C", VA = "0xA70C8C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xA70D1C", Offset = "0xA70D1C", VA = "0xA70D1C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xA7116C", Offset = "0xA7116C", VA = "0xA7116C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xA7182C", Offset = "0xA7182C", VA = "0xA7182C")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xA71AE4", Offset = "0xA71AE4", VA = "0xA71AE4")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xA71C18", Offset = "0xA71C18", VA = "0xA71C18")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xA71EE0", Offset = "0xA71EE0", VA = "0xA71EE0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xA71F10", Offset = "0xA71F10", VA = "0xA71F10")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xA7210C", Offset = "0xA7210C", VA = "0xA7210C")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder VRIK")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Reference to the VRIK componet.")]
		public VRIK ik;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xA7223C", Offset = "0xA7223C", VA = "0xA7223C")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xA72280", Offset = "0xA72280", VA = "0xA72280", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xA722C4", Offset = "0xA722C4", VA = "0xA722C4", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xA72308", Offset = "0xA72308", VA = "0xA72308", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xA72320", Offset = "0xA72320", VA = "0xA72320")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xA723A8", Offset = "0xA723A8", VA = "0xA723A8")]
		private void Update()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xA723FC", Offset = "0xA723FC", VA = "0xA723FC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xA72634", Offset = "0xA72634", VA = "0xA72634")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xA72828", Offset = "0xA72828", VA = "0xA72828")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xA728AC", Offset = "0xA728AC", VA = "0xA728AC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xA72B48", Offset = "0xA72B48", VA = "0xA72B48")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xA72C7C", Offset = "0xA72C7C", VA = "0xA72C7C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xA72E14", Offset = "0xA72E14", VA = "0xA72E14")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x2000055")]
		public enum Quality
		{
			[Token(Token = "0x40001C2")]
			Fastest,
			[Token(Token = "0x40001C3")]
			Simple,
			[Token(Token = "0x40001C4")]
			Best
		}

		[Token(Token = "0x2000056")]
		public class Leg
		{
			[Token(Token = "0x40001C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40001CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40001D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x40001D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x40001D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x40001D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x40001D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40001D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x40001D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x40001D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x40001D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x40001D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x17000074")]
			public bool isGrounded
			{
				[Token(Token = "0x60002F5")]
				[Address(RVA = "0xA743A4", Offset = "0xA743A4", VA = "0xA743A4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002F6")]
				[Address(RVA = "0xA743AC", Offset = "0xA743AC", VA = "0xA743AC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000075")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60002F7")]
				[Address(RVA = "0xA743B8", Offset = "0xA743B8", VA = "0xA743B8")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60002F8")]
				[Address(RVA = "0xA743C4", Offset = "0xA743C4", VA = "0xA743C4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000076")]
			public bool initiated
			{
				[Token(Token = "0x60002F9")]
				[Address(RVA = "0xA743D0", Offset = "0xA743D0", VA = "0xA743D0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002FA")]
				[Address(RVA = "0xA743D8", Offset = "0xA743D8", VA = "0xA743D8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000077")]
			public float heightFromGround
			{
				[Token(Token = "0x60002FB")]
				[Address(RVA = "0xA743E4", Offset = "0xA743E4", VA = "0xA743E4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60002FC")]
				[Address(RVA = "0xA743EC", Offset = "0xA743EC", VA = "0xA743EC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000078")]
			public Vector3 velocity
			{
				[Token(Token = "0x60002FD")]
				[Address(RVA = "0xA743F4", Offset = "0xA743F4", VA = "0xA743F4")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60002FE")]
				[Address(RVA = "0xA74400", Offset = "0xA74400", VA = "0xA74400")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000079")]
			public Transform transform
			{
				[Token(Token = "0x60002FF")]
				[Address(RVA = "0xA7440C", Offset = "0xA7440C", VA = "0xA7440C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000300")]
				[Address(RVA = "0xA74414", Offset = "0xA74414", VA = "0xA74414")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700007A")]
			public float IKOffset
			{
				[Token(Token = "0x6000301")]
				[Address(RVA = "0xA7441C", Offset = "0xA7441C", VA = "0xA7441C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000302")]
				[Address(RVA = "0xA74424", Offset = "0xA74424", VA = "0xA74424")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700007B")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x6000303")]
				[Address(RVA = "0xA7442C", Offset = "0xA7442C", VA = "0xA7442C")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x6000304")]
				[Address(RVA = "0xA74444", Offset = "0xA74444", VA = "0xA74444")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700007C")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x6000305")]
				[Address(RVA = "0xA74464", Offset = "0xA74464", VA = "0xA74464")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x6000306")]
				[Address(RVA = "0xA7447C", Offset = "0xA7447C", VA = "0xA7447C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700007D")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x6000307")]
				[Address(RVA = "0xA7449C", Offset = "0xA7449C", VA = "0xA7449C")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700007E")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x600030D")]
				[Address(RVA = "0xA74D88", Offset = "0xA74D88", VA = "0xA74D88")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700007F")]
			private float rootYOffset
			{
				[Token(Token = "0x6000316")]
				[Address(RVA = "0xA74ED8", Offset = "0xA74ED8", VA = "0xA74ED8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0xA744E4", Offset = "0xA744E4", VA = "0xA744E4")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0xA73328", Offset = "0xA73328", VA = "0xA73328")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0xA744F8", Offset = "0xA744F8", VA = "0xA744F8")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600030B")]
			[Address(RVA = "0xA74014", Offset = "0xA74014", VA = "0xA74014")]
			public void Reset()
			{
			}

			[Token(Token = "0x600030C")]
			[Address(RVA = "0xA73414", Offset = "0xA73414", VA = "0xA73414")]
			public void Process()
			{
			}

			[Token(Token = "0x600030E")]
			[Address(RVA = "0xA74998", Offset = "0xA74998", VA = "0xA74998")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600030F")]
			[Address(RVA = "0xA74538", Offset = "0xA74538", VA = "0xA74538")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0xA74E1C", Offset = "0xA74E1C", VA = "0xA74E1C")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0xA74804", Offset = "0xA74804", VA = "0xA74804")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0xA74884", Offset = "0xA74884", VA = "0xA74884")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0xA74E88", Offset = "0xA74E88", VA = "0xA74E88")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000314")]
			[Address(RVA = "0xA74DBC", Offset = "0xA74DBC", VA = "0xA74DBC")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0xA74F64", Offset = "0xA74F64", VA = "0xA74F64")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000317")]
			[Address(RVA = "0xA73288", Offset = "0xA73288", VA = "0xA73288")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000057")]
		public class Pelvis
		{
			[Token(Token = "0x40001DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40001DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40001DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40001DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40001E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x17000080")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x6000318")]
				[Address(RVA = "0xA75114", Offset = "0xA75114", VA = "0xA75114")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000319")]
				[Address(RVA = "0xA75120", Offset = "0xA75120", VA = "0xA75120")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000081")]
			public float heightOffset
			{
				[Token(Token = "0x600031A")]
				[Address(RVA = "0xA7512C", Offset = "0xA7512C", VA = "0xA7512C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600031B")]
				[Address(RVA = "0xA75134", Offset = "0xA75134", VA = "0xA75134")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0xA733F0", Offset = "0xA733F0", VA = "0xA733F0")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0xA73F80", Offset = "0xA73F80", VA = "0xA73F80")]
			public void Reset()
			{
			}

			[Token(Token = "0x600031E")]
			[Address(RVA = "0xA7513C", Offset = "0xA7513C", VA = "0xA7513C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0xA73D94", Offset = "0xA73D94", VA = "0xA73D94")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000320")]
			[Address(RVA = "0xA73320", Offset = "0xA73320", VA = "0xA73320")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Offset of the foot center along character forward axis.")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		[Range(0f, 90f)]
		public float maxFootRotationAngle;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		public float pelvisDamper;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("If false, keeps the foot that is over a ledge at the root level. If true, lowers the overstepping foot and body by the 'Max Step' value.")]
		public bool overstepFallsDown;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Quality quality;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700006C")]
		public Leg[] legs
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0xA72E68", Offset = "0xA72E68", VA = "0xA72E68")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0xA72E70", Offset = "0xA72E70", VA = "0xA72E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0xA72E78", Offset = "0xA72E78", VA = "0xA72E78")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xA72E80", Offset = "0xA72E80", VA = "0xA72E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public bool isGrounded
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0xA72E88", Offset = "0xA72E88", VA = "0xA72E88")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0xA72E90", Offset = "0xA72E90", VA = "0xA72E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public Transform root
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0xA72E9C", Offset = "0xA72E9C", VA = "0xA72E9C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0xA72EA4", Offset = "0xA72EA4", VA = "0xA72EA4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0xA72EAC", Offset = "0xA72EAC", VA = "0xA72EAC")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0xA72EC4", Offset = "0xA72EC4", VA = "0xA72EC4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public bool rootGrounded
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0xA72EE4", Offset = "0xA72EE4", VA = "0xA72EE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000072")]
		public Vector3 up
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xA6D83C", Offset = "0xA6D83C", VA = "0xA6D83C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000073")]
		private bool useRootRotation
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0xA740A8", Offset = "0xA740A8", VA = "0xA740A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xA72F2C", Offset = "0xA72F2C", VA = "0xA72F2C")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xA7318C", Offset = "0xA7318C", VA = "0xA7318C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xA6CE58", Offset = "0xA6CE58", VA = "0xA6CE58")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xA6D580", Offset = "0xA6D580", VA = "0xA6D580")]
		public void Update()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xA6F218", Offset = "0xA6F218", VA = "0xA6F218")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xA6C9EC", Offset = "0xA6C9EC", VA = "0xA6C9EC")]
		public void Reset()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xA73400", Offset = "0xA73400", VA = "0xA73400")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xA7415C", Offset = "0xA7415C", VA = "0xA7415C")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xA741E0", Offset = "0xA741E0", VA = "0xA741E0")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xA74334", Offset = "0xA74334", VA = "0xA74334")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xA6C7AC", Offset = "0xA6C7AC", VA = "0xA6C7AC")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class AimIK : IK
	{
		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xA75190", Offset = "0xA75190", VA = "0xA75190", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xA751D4", Offset = "0xA751D4", VA = "0xA751D4", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xA75218", Offset = "0xA75218", VA = "0xA75218")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xA7525C", Offset = "0xA7525C", VA = "0xA7525C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xA752A0", Offset = "0xA752A0", VA = "0xA752A0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xA752E4", Offset = "0xA752E4", VA = "0xA752E4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xA752EC", Offset = "0xA752EC", VA = "0xA752EC")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Arm IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xA7536C", Offset = "0xA7536C", VA = "0xA7536C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xA753B0", Offset = "0xA753B0", VA = "0xA753B0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xA753F4", Offset = "0xA753F4", VA = "0xA753F4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xA75438", Offset = "0xA75438", VA = "0xA75438")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xA7547C", Offset = "0xA7547C", VA = "0xA7547C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xA75484", Offset = "0xA75484", VA = "0xA75484")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xA754F4", Offset = "0xA754F4", VA = "0xA754F4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xA75538", Offset = "0xA75538", VA = "0xA75538", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xA7557C", Offset = "0xA7557C", VA = "0xA7557C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xA755C0", Offset = "0xA755C0", VA = "0xA755C0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xA75604", Offset = "0xA75604", VA = "0xA75604", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xA7560C", Offset = "0xA7560C", VA = "0xA7560C")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page6.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xA7567C", Offset = "0xA7567C", VA = "0xA7567C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xA756C0", Offset = "0xA756C0", VA = "0xA756C0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xA75704", Offset = "0xA75704", VA = "0xA75704")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xA75748", Offset = "0xA75748", VA = "0xA75748")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xA7578C", Offset = "0xA7578C", VA = "0xA7578C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xA75794", Offset = "0xA75794", VA = "0xA75794")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xA75804", Offset = "0xA75804", VA = "0xA75804", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xA75848", Offset = "0xA75848", VA = "0xA75848", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xA7588C", Offset = "0xA7588C", VA = "0xA7588C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xA758D0", Offset = "0xA758D0", VA = "0xA758D0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xA75914", Offset = "0xA75914", VA = "0xA75914", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xA7591C", Offset = "0xA7591C", VA = "0xA7591C")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xA7598C", Offset = "0xA7598C", VA = "0xA7598C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xA759D0", Offset = "0xA759D0", VA = "0xA759D0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xA75A14", Offset = "0xA75A14", VA = "0xA75A14")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xA75A58", Offset = "0xA75A58", VA = "0xA75A58")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xA75A9C", Offset = "0xA75A9C", VA = "0xA75A9C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xA75AE0", Offset = "0xA75AE0", VA = "0xA75AE0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xA75B24", Offset = "0xA75B24", VA = "0xA75B24")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xA75B48", Offset = "0xA75B48", VA = "0xA75B48", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xA75B50", Offset = "0xA75B50", VA = "0xA75B50")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xA75D0C", Offset = "0xA75D0C", VA = "0xA75D0C")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xA761BC", Offset = "0xA761BC", VA = "0xA761BC")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xA761DC", Offset = "0xA761DC", VA = "0xA761DC")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xA762B4", Offset = "0xA762B4", VA = "0xA762B4")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x600034D")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xA76354", Offset = "0xA76354", VA = "0xA76354", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xA763CC", Offset = "0xA763CC", VA = "0xA763CC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xA7643C", Offset = "0xA7643C", VA = "0xA7643C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000351")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000352")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xA7535C", Offset = "0xA7535C", VA = "0xA7535C")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Optional. Assign it if you are using 'Animate Physics' as the Update Mode.")]
		public Animator animator;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000082")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0xA7648C", Offset = "0xA7648C", VA = "0xA7648C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xA76518", Offset = "0xA76518", VA = "0xA76518")]
		private void Start()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xA7657C", Offset = "0xA7657C", VA = "0xA7657C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xA7661C", Offset = "0xA7661C", VA = "0xA7661C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xA76648", Offset = "0xA76648", VA = "0xA76648")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xA765A0", Offset = "0xA765A0", VA = "0xA765A0")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xA766CC", Offset = "0xA766CC", VA = "0xA766CC")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	public class LegIK : IK
	{
		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xA766D4", Offset = "0xA766D4", VA = "0xA766D4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xA76718", Offset = "0xA76718", VA = "0xA76718", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xA7675C", Offset = "0xA7675C", VA = "0xA7675C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xA767A0", Offset = "0xA767A0", VA = "0xA767A0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xA767E4", Offset = "0xA767E4", VA = "0xA767E4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xA767EC", Offset = "0xA767EC", VA = "0xA767EC")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xA7685C", Offset = "0xA7685C", VA = "0xA7685C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xA768A0", Offset = "0xA768A0", VA = "0xA768A0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xA768E4", Offset = "0xA768E4", VA = "0xA768E4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xA76928", Offset = "0xA76928", VA = "0xA76928")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xA7696C", Offset = "0xA7696C", VA = "0xA7696C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xA76974", Offset = "0xA76974", VA = "0xA76974")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page13.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xA769E4", Offset = "0xA769E4", VA = "0xA769E4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xA76A28", Offset = "0xA76A28", VA = "0xA76A28", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xA76A6C", Offset = "0xA76A6C", VA = "0xA76A6C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xA76AB0", Offset = "0xA76AB0", VA = "0xA76AB0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xA76AF4", Offset = "0xA76AF4", VA = "0xA76AF4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xA76AFC", Offset = "0xA76AFC", VA = "0xA76AFC")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page15.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xA76B6C", Offset = "0xA76B6C", VA = "0xA76B6C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xA76BB0", Offset = "0xA76BB0", VA = "0xA76BB0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xA76BF4", Offset = "0xA76BF4", VA = "0xA76BF4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xA76C38", Offset = "0xA76C38", VA = "0xA76C38")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xA76C7C", Offset = "0xA76C7C", VA = "0xA76C7C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xA76C84", Offset = "0xA76C84", VA = "0xA76C84")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x2000065")]
		public class References
		{
			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x40001F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40001F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Optional")]
			public Transform chest;

			[Token(Token = "0x40001F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Optional")]
			public Transform neck;

			[Token(Token = "0x40001F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("Optional")]
			public Transform leftShoulder;

			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x40001F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x40001FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x40001FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Optional")]
			public Transform rightShoulder;

			[Token(Token = "0x40001FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40001FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40001FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40001FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftThigh;

			[Token(Token = "0x4000200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftCalf;

			[Token(Token = "0x4000201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftFoot;

			[Token(Token = "0x4000202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Tooltip("Optional")]
			public Transform leftToes;

			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightThigh;

			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightCalf;

			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightFoot;

			[Token(Token = "0x4000206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[Tooltip("Optional")]
			public Transform rightToes;

			[Token(Token = "0x17000083")]
			public bool isFilled
			{
				[Token(Token = "0x600037D")]
				[Address(RVA = "0xA775C0", Offset = "0xA775C0", VA = "0xA775C0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000084")]
			public bool isEmpty
			{
				[Token(Token = "0x600037E")]
				[Address(RVA = "0xA77204", Offset = "0xA77204", VA = "0xA77204")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600037C")]
			[Address(RVA = "0xA77BB4", Offset = "0xA77BB4", VA = "0xA77BB4")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x600037F")]
			[Address(RVA = "0xA76DDC", Offset = "0xA76DDC", VA = "0xA76DDC")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000380")]
			[Address(RVA = "0xA77BAC", Offset = "0xA77BAC", VA = "0xA77BAC")]
			public References()
			{
			}
		}

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		public References references;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver;

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xA76CF4", Offset = "0xA76CF4", VA = "0xA76CF4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xA76D38", Offset = "0xA76D38", VA = "0xA76D38", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xA76D7C", Offset = "0xA76D7C", VA = "0xA76D7C")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xA76DC0", Offset = "0xA76DC0", VA = "0xA76DC0")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xA77168", Offset = "0xA77168", VA = "0xA77168")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xA77190", Offset = "0xA77190", VA = "0xA77190", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xA77198", Offset = "0xA77198", VA = "0xA77198", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xA7797C", Offset = "0xA7797C", VA = "0xA7797C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xA77B0C", Offset = "0xA77B0C", VA = "0xA77B0C")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public class FABRIKChain
	{
		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xA77FF0", Offset = "0xA77FF0", VA = "0xA77FF0")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xA780B4", Offset = "0xA780B4", VA = "0xA780B4")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xA780D4", Offset = "0xA780D4", VA = "0xA780D4")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xA78328", Offset = "0xA78328", VA = "0xA78328")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xA78194", Offset = "0xA78194", VA = "0xA78194")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xA7840C", Offset = "0xA7840C", VA = "0xA7840C")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xA7846C", Offset = "0xA7846C", VA = "0xA7846C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xA789C0", Offset = "0xA789C0", VA = "0xA789C0")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xA78B54", Offset = "0xA78B54", VA = "0xA78B54")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xA78C5C", Offset = "0xA78C5C", VA = "0xA78C5C")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000069")]
		public class BendBone
		{
			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			[Tooltip("The weight of rotating this bone.")]
			public float weight;

			[Token(Token = "0x4000243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000399")]
			[Address(RVA = "0xA7BE50", Offset = "0xA7BE50", VA = "0xA7BE50")]
			public BendBone()
			{
			}

			[Token(Token = "0x600039A")]
			[Address(RVA = "0xA7BEB0", Offset = "0xA7BEB0", VA = "0xA7BEB0")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x600039B")]
			[Address(RVA = "0xA79574", Offset = "0xA79574", VA = "0xA79574")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600039C")]
			[Address(RVA = "0xA79944", Offset = "0xA79944", VA = "0xA79944")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("Master weight for positioning the head.")]
		[LargeHeader("Position")]
		public float positionWeight;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The weight of moving the body along with the head")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[Tooltip("The weight of moving the thighs along with the head")]
		public float thighWeight;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The weight of rotating the head bone after solving")]
		[Range(0f, 1f)]
		[LargeHeader("Rotation")]
		public float rotationWeight;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Clamping the rotation of the body")]
		[Range(0f, 1f)]
		public float bodyClampWeight;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Clamping the rotation of the head")]
		[Range(0f, 1f)]
		public float headClampWeight;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		[Range(0f, 1f)]
		public float bendWeight;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The bones to use for bending.")]
		public BendBone[] bendBones;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		[LargeHeader("CCD")]
		[Range(0f, 1f)]
		public float CCDWeight;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The weight of rolling the bones in towards the target")]
		[Range(0f, 1f)]
		public float roll;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1000f)]
		[Tooltip("Smoothing the CCD effect.")]
		public float damper;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		[Range(0f, 1f)]
		[LargeHeader("Stretching")]
		public float postStretchWeight;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float chestDirectionWeight;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xA78C64", Offset = "0xA78C64", VA = "0xA78C64")]
		private void Start()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xA79100", Offset = "0xA79100", VA = "0xA79100")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xA795A0", Offset = "0xA795A0", VA = "0xA795A0")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xA7996C", Offset = "0xA7996C", VA = "0xA7996C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xA7A268", Offset = "0xA7A268", VA = "0xA7A268")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xA7A660", Offset = "0xA7A660", VA = "0xA7A660")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xA7AA70", Offset = "0xA7AA70", VA = "0xA7AA70")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xA7B3E8", Offset = "0xA7B3E8", VA = "0xA7B3E8")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xA79FAC", Offset = "0xA79FAC", VA = "0xA79FAC")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xA7B624", Offset = "0xA7B624", VA = "0xA7B624")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xA7B308", Offset = "0xA7B308", VA = "0xA7B308")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xA7B208", Offset = "0xA7B208", VA = "0xA7B208")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xA7B984", Offset = "0xA7B984", VA = "0xA7B984")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xA7BCA8", Offset = "0xA7BCA8", VA = "0xA7BCA8")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x200006B")]
		public class ChildConstraint
		{
			[Token(Token = "0x400025B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x400025C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x400025D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x400025E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x4000261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000262")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000263")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000264")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x17000085")]
			public float nominalDistance
			{
				[Token(Token = "0x60003B1")]
				[Address(RVA = "0xA7EE84", Offset = "0xA7EE84", VA = "0xA7EE84")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60003B2")]
				[Address(RVA = "0xA7EE8C", Offset = "0xA7EE8C", VA = "0xA7EE8C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000086")]
			public bool isRigid
			{
				[Token(Token = "0x60003B3")]
				[Address(RVA = "0xA7EE94", Offset = "0xA7EE94", VA = "0xA7EE94")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003B4")]
				[Address(RVA = "0xA7EE9C", Offset = "0xA7EE9C", VA = "0xA7EE9C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60003B5")]
			[Address(RVA = "0xA7EEA8", Offset = "0xA7EEA8", VA = "0xA7EEA8")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60003B6")]
			[Address(RVA = "0xA7CB90", Offset = "0xA7CB90", VA = "0xA7CB90")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60003B7")]
			[Address(RVA = "0xA7D23C", Offset = "0xA7D23C", VA = "0xA7D23C")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60003B8")]
			[Address(RVA = "0xA7EC48", Offset = "0xA7EC48", VA = "0xA7EC48")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200006C")]
		public enum Smoothing
		{
			[Token(Token = "0x4000266")]
			None,
			[Token(Token = "0x4000267")]
			Exponential,
			[Token(Token = "0x4000268")]
			Cubic
		}

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float push;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(-1f, 1f)]
		public float pushParent;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float reach;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x400025A")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xA7BF2C", Offset = "0xA7BF2C", VA = "0xA7BF2C")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xA7C094", Offset = "0xA7C094", VA = "0xA7C094")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xA7C1C8", Offset = "0xA7C1C8", VA = "0xA7C1C8")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xA7C300", Offset = "0xA7C300", VA = "0xA7C300")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xA7C3BC", Offset = "0xA7C3BC", VA = "0xA7C3BC")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xA7C4C8", Offset = "0xA7C4C8", VA = "0xA7C4C8")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xA7CE58", Offset = "0xA7CE58", VA = "0xA7CE58")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xA7C634", Offset = "0xA7C634", VA = "0xA7C634")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xA7D420", Offset = "0xA7D420", VA = "0xA7D420")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xA7D6B4", Offset = "0xA7D6B4", VA = "0xA7D6B4")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xA7D984", Offset = "0xA7D984", VA = "0xA7D984")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xA7E34C", Offset = "0xA7E34C", VA = "0xA7E34C")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xA7E844", Offset = "0xA7E844", VA = "0xA7E844")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xA7EA44", Offset = "0xA7EA44", VA = "0xA7EA44")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xA7E730", Offset = "0xA7E730", VA = "0xA7E730")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xA7E1EC", Offset = "0xA7E1EC", VA = "0xA7E1EC")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xA7E6CC", Offset = "0xA7E6CC", VA = "0xA7E6CC")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xA7EB20", Offset = "0xA7EB20", VA = "0xA7EB20")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xA7E5F8", Offset = "0xA7E5F8", VA = "0xA7E5F8")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xA7E948", Offset = "0xA7E948", VA = "0xA7E948")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006D")]
	public class IKConstraintBend
	{
		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000087")]
		public bool initiated
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0xA7F0C0", Offset = "0xA7F0C0", VA = "0xA7F0C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0xA7F0C8", Offset = "0xA7F0C8", VA = "0xA7F0C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xA7EEE8", Offset = "0xA7EEE8", VA = "0xA7EEE8")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xA7C028", Offset = "0xA7C028", VA = "0xA7C028")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xA7F0D4", Offset = "0xA7F0D4", VA = "0xA7F0D4")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xA7CBE4", Offset = "0xA7CBE4", VA = "0xA7CBE4")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xA7CBF0", Offset = "0xA7CBF0", VA = "0xA7CBF0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xA7F2A8", Offset = "0xA7F2A8", VA = "0xA7F2A8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xA7F5FC", Offset = "0xA7F5FC", VA = "0xA7F5FC")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xA7DBBC", Offset = "0xA7DBBC", VA = "0xA7DBBC")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xA7F160", Offset = "0xA7F160", VA = "0xA7F160")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xA7F204", Offset = "0xA7F204", VA = "0xA7F204")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class IKEffector
	{
		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000088")]
		public bool isEndEffector
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0xA7F9C4", Offset = "0xA7F9C4", VA = "0xA7F9C4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0xA7F9CC", Offset = "0xA7F9CC", VA = "0xA7F9CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xA7B928", Offset = "0xA7B928", VA = "0xA7B928")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xA7F9D8", Offset = "0xA7F9D8", VA = "0xA7F9D8")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xA7FA5C", Offset = "0xA7FA5C", VA = "0xA7FA5C")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xA7FBFC", Offset = "0xA7FBFC", VA = "0xA7FBFC")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xA7FDB8", Offset = "0xA7FDB8", VA = "0xA7FDB8")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xA800AC", Offset = "0xA800AC", VA = "0xA800AC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xA8034C", Offset = "0xA8034C", VA = "0xA8034C")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xA8046C", Offset = "0xA8046C", VA = "0xA8046C")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xA80508", Offset = "0xA80508", VA = "0xA80508")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xA80BBC", Offset = "0xA80BBC", VA = "0xA80BBC")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xA80C14", Offset = "0xA80C14", VA = "0xA80C14")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xA80DE8", Offset = "0xA80DE8", VA = "0xA80DE8")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xA81044", Offset = "0xA81044", VA = "0xA81044")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200006F")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000070")]
		public class BoneMap
		{
			[Token(Token = "0x400029B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400029C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x400029D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x40002A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x40002AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x40002AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40002AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x40002AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000089")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60003DA")]
				[Address(RVA = "0xA81590", Offset = "0xA81590", VA = "0xA81590")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008A")]
			public bool isNodeBone
			{
				[Token(Token = "0x60003DD")]
				[Address(RVA = "0xA81648", Offset = "0xA81648", VA = "0xA81648")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700008B")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60003F1")]
				[Address(RVA = "0xA81A10", Offset = "0xA81A10", VA = "0xA81A10")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60003D9")]
			[Address(RVA = "0xA81564", Offset = "0xA81564", VA = "0xA81564")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60003DB")]
			[Address(RVA = "0xA815C0", Offset = "0xA815C0", VA = "0xA815C0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60003DC")]
			[Address(RVA = "0xA81604", Offset = "0xA81604", VA = "0xA81604")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60003DE")]
			[Address(RVA = "0xA81658", Offset = "0xA81658", VA = "0xA81658")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60003DF")]
			[Address(RVA = "0xA8172C", Offset = "0xA8172C", VA = "0xA8172C")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60003E0")]
			[Address(RVA = "0xA81734", Offset = "0xA81734", VA = "0xA81734")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60003E1")]
			[Address(RVA = "0xA81800", Offset = "0xA81800", VA = "0xA81800")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60003E2")]
			[Address(RVA = "0xA8186C", Offset = "0xA8186C", VA = "0xA8186C")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60003E3")]
			[Address(RVA = "0xA81900", Offset = "0xA81900", VA = "0xA81900")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60003E4")]
			[Address(RVA = "0xA81B78", Offset = "0xA81B78", VA = "0xA81B78")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60003E5")]
			[Address(RVA = "0xA81BA4", Offset = "0xA81BA4", VA = "0xA81BA4")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60003E6")]
			[Address(RVA = "0xA81BD0", Offset = "0xA81BD0", VA = "0xA81BD0")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60003E7")]
			[Address(RVA = "0xA81BF8", Offset = "0xA81BF8", VA = "0xA81BF8")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60003E8")]
			[Address(RVA = "0xA81CBC", Offset = "0xA81CBC", VA = "0xA81CBC")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003E9")]
			[Address(RVA = "0xA81E50", Offset = "0xA81E50", VA = "0xA81E50")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xA81E74", Offset = "0xA81E74", VA = "0xA81E74")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60003EB")]
			[Address(RVA = "0xA81F94", Offset = "0xA81F94", VA = "0xA81F94")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60003EC")]
			[Address(RVA = "0xA81FF8", Offset = "0xA81FF8", VA = "0xA81FF8")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60003ED")]
			[Address(RVA = "0xA82178", Offset = "0xA82178", VA = "0xA82178")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60003EE")]
			[Address(RVA = "0xA822F8", Offset = "0xA822F8", VA = "0xA822F8")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60003EF")]
			[Address(RVA = "0xA82374", Offset = "0xA82374", VA = "0xA82374")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60003F0")]
			[Address(RVA = "0xA81D34", Offset = "0xA81D34", VA = "0xA81D34")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60003F2")]
			[Address(RVA = "0xA8249C", Offset = "0xA8249C", VA = "0xA8249C")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xA81300", Offset = "0xA81300", VA = "0xA81300", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xA81308", Offset = "0xA81308", VA = "0xA81308", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xA8130C", Offset = "0xA8130C", VA = "0xA8130C")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xA81448", Offset = "0xA81448", VA = "0xA81448")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xA8155C", Offset = "0xA8155C", VA = "0xA8155C")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000071")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xA824B8", Offset = "0xA824B8", VA = "0xA824B8", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xA82554", Offset = "0xA82554", VA = "0xA82554")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xA825D8", Offset = "0xA825D8", VA = "0xA825D8")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xA82670", Offset = "0xA82670", VA = "0xA82670")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xA82688", Offset = "0xA82688", VA = "0xA82688")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xA826A4", Offset = "0xA826A4", VA = "0xA826A4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xA82730", Offset = "0xA82730", VA = "0xA82730")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xA82748", Offset = "0xA82748", VA = "0xA82748")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000072")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000073")]
		public enum BoneMapType
		{
			[Token(Token = "0x40002C0")]
			Parent,
			[Token(Token = "0x40002C1")]
			Bone1,
			[Token(Token = "0x40002C2")]
			Bone2,
			[Token(Token = "0x40002C3")]
			Bone3
		}

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xA8276C", Offset = "0xA8276C", VA = "0xA8276C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xA827E0", Offset = "0xA827E0", VA = "0xA827E0")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xA828A8", Offset = "0xA828A8", VA = "0xA828A8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xA82B60", Offset = "0xA82B60", VA = "0xA82B60")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xA82C7C", Offset = "0xA82C7C", VA = "0xA82C7C")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xA82DC4", Offset = "0xA82DC4", VA = "0xA82DC4")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xA82DD0", Offset = "0xA82DD0", VA = "0xA82DD0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xA82E68", Offset = "0xA82E68", VA = "0xA82E68")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xA82F10", Offset = "0xA82F10", VA = "0xA82F10", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xA8316C", Offset = "0xA8316C", VA = "0xA8316C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xA831CC", Offset = "0xA831CC", VA = "0xA831CC")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000074")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(1f, 3f)]
		public int iterations;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float twistWeight;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xA83314", Offset = "0xA83314", VA = "0xA83314", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xA83634", Offset = "0xA83634", VA = "0xA83634")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xA83770", Offset = "0xA83770", VA = "0xA83770")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xA838E0", Offset = "0xA838E0", VA = "0xA838E0")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xA838F0", Offset = "0xA838F0", VA = "0xA838F0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xA8394C", Offset = "0xA8394C", VA = "0xA8394C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xA839C4", Offset = "0xA839C4", VA = "0xA839C4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xA83FD8", Offset = "0xA83FD8", VA = "0xA83FD8")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xA84010", Offset = "0xA84010", VA = "0xA84010")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xA84274", Offset = "0xA84274", VA = "0xA84274")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xA8459C", Offset = "0xA8459C", VA = "0xA8459C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xA8467C", Offset = "0xA8467C", VA = "0xA8467C")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xA84730", Offset = "0xA84730", VA = "0xA84730")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000075")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000076")]
		public class Point
		{
			[Token(Token = "0x40002DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40002DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x40002DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40002DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x40002E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40002E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000429")]
			[Address(RVA = "0xA85008", Offset = "0xA85008", VA = "0xA85008")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600042A")]
			[Address(RVA = "0xA8504C", Offset = "0xA8504C", VA = "0xA8504C")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600042B")]
			[Address(RVA = "0xA8512C", Offset = "0xA8512C", VA = "0xA8512C")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x600042C")]
			[Address(RVA = "0xA85158", Offset = "0xA85158", VA = "0xA85158")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x600042D")]
			[Address(RVA = "0xA85184", Offset = "0xA85184", VA = "0xA85184")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x600042E")]
			[Address(RVA = "0xA851C8", Offset = "0xA851C8", VA = "0xA851C8")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600042F")]
			[Address(RVA = "0xA8520C", Offset = "0xA8520C", VA = "0xA8520C")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000077")]
		public class Bone : Point
		{
			[Token(Token = "0x40002E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40002E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40002E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40002E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40002E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x1700008D")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000430")]
				[Address(RVA = "0xA8526C", Offset = "0xA8526C", VA = "0xA8526C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000431")]
				[Address(RVA = "0xA8534C", Offset = "0xA8534C", VA = "0xA8534C")]
				set
				{
				}
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0xA853C4", Offset = "0xA853C4", VA = "0xA853C4")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000433")]
			[Address(RVA = "0xA85630", Offset = "0xA85630", VA = "0xA85630")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0xA858EC", Offset = "0xA858EC", VA = "0xA858EC")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0xA85AE0", Offset = "0xA85AE0", VA = "0xA85AE0")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000436")]
			[Address(RVA = "0xA85B08", Offset = "0xA85B08", VA = "0xA85B08")]
			public Bone()
			{
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0xA85B74", Offset = "0xA85B74", VA = "0xA85B74")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0xA85BEC", Offset = "0xA85BEC", VA = "0xA85BEC")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000078")]
		public class Node : Point
		{
			[Token(Token = "0x40002E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40002E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40002E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40002EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000439")]
			[Address(RVA = "0xA85C74", Offset = "0xA85C74", VA = "0xA85C74")]
			public Node()
			{
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0xA7C2DC", Offset = "0xA7C2DC", VA = "0xA7C2DC")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0xA85C78", Offset = "0xA85C78", VA = "0xA85C78")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x2000079")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x200007A")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public bool executedInEditor;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("The positional or the master weight of the solver.")]
		public float IKPositionWeight;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x1700008C")]
		public bool initiated
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0xA84C14", Offset = "0xA84C14", VA = "0xA84C14")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600041D")]
			[Address(RVA = "0xA84C1C", Offset = "0xA84C1C", VA = "0xA84C1C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xA84974", Offset = "0xA84974", VA = "0xA84974")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000414")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xA849E8", Offset = "0xA849E8", VA = "0xA849E8")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xA84B60", Offset = "0xA84B60", VA = "0xA84B60")]
		public void Update()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xA84BD0", Offset = "0xA84BD0", VA = "0xA84BD0", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xA84BDC", Offset = "0xA84BDC", VA = "0xA84BDC")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xA84BE8", Offset = "0xA84BE8", VA = "0xA84BE8")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xA84BF0", Offset = "0xA84BF0", VA = "0xA84BF0")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xA84C0C", Offset = "0xA84C0C", VA = "0xA84C0C")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x600041E")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x600041F")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x6000420")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000421")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x6000422")]
		protected abstract void OnInitiate();

		[Token(Token = "0x6000423")]
		protected abstract void OnUpdate();

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xA84C28", Offset = "0xA84C28", VA = "0xA84C28")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xA84C40", Offset = "0xA84C40", VA = "0xA84C40")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xA84D64", Offset = "0xA84D64", VA = "0xA84D64")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xA84DFC", Offset = "0xA84DFC", VA = "0xA84DFC")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xA84FF0", Offset = "0xA84FF0", VA = "0xA84FF0")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float poleWeight;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x1700008E")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0xA85EC8", Offset = "0xA85EC8", VA = "0xA85EC8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700008F")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0xA85EF8", Offset = "0xA85EF8", VA = "0xA85EF8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000090")]
		protected override int minBones
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0xA86B2C", Offset = "0xA86B2C", VA = "0xA86B2C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000091")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0xA8706C", Offset = "0xA8706C", VA = "0xA8706C", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xA85D90", Offset = "0xA85D90", VA = "0xA85D90")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xA85F28", Offset = "0xA85F28", VA = "0xA85F28", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xA861B4", Offset = "0xA861B4", VA = "0xA861B4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xA86A84", Offset = "0xA86A84", VA = "0xA86A84")]
		private void Solve()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xA86720", Offset = "0xA86720", VA = "0xA86720")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xA86B34", Offset = "0xA86B34", VA = "0xA86B34")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xA870CC", Offset = "0xA870CC", VA = "0xA870CC")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007C")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xA87170", Offset = "0xA87170", VA = "0xA87170", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xA874CC", Offset = "0xA874CC", VA = "0xA874CC")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xA8752C", Offset = "0xA8752C", VA = "0xA8752C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xA87670", Offset = "0xA87670", VA = "0xA87670", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xA877D0", Offset = "0xA877D0", VA = "0xA877D0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xA87810", Offset = "0xA87810", VA = "0xA87810", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xA87860", Offset = "0xA87860", VA = "0xA87860", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xA87BC0", Offset = "0xA87BC0", VA = "0xA87BC0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xA87BE0", Offset = "0xA87BE0", VA = "0xA87BE0")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xA878B8", Offset = "0xA878B8", VA = "0xA878B8")]
		private void Read()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xA87C44", Offset = "0xA87C44", VA = "0xA87C44")]
		private void Write()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xA87DBC", Offset = "0xA87DBC", VA = "0xA87DBC")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007D")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xA87F50", Offset = "0xA87F50", VA = "0xA87F50")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xA87FC0", Offset = "0xA87FC0", VA = "0xA87FC0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xA88030", Offset = "0xA88030", VA = "0xA88030", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xA882E4", Offset = "0xA882E4", VA = "0xA882E4")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xA88974", Offset = "0xA88974", VA = "0xA88974")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007E")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000092")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000465")]
			[Address(RVA = "0xA8991C", Offset = "0xA8991C", VA = "0xA8991C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xA8897C", Offset = "0xA8897C", VA = "0xA8897C")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xA88F5C", Offset = "0xA88F5C", VA = "0xA88F5C")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xA8908C", Offset = "0xA8908C", VA = "0xA8908C", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xA89114", Offset = "0xA89114", VA = "0xA89114", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xA89610", Offset = "0xA89610", VA = "0xA89610", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xA89924", Offset = "0xA89924", VA = "0xA89924")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xA88A54", Offset = "0xA88A54", VA = "0xA88A54")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xA89044", Offset = "0xA89044", VA = "0xA89044")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xA898D4", Offset = "0xA898D4", VA = "0xA898D4")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xA88DF0", Offset = "0xA88DF0", VA = "0xA88DF0")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xA89FD0", Offset = "0xA89FD0", VA = "0xA89FD0")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xA8A038", Offset = "0xA8A038", VA = "0xA8A038")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xA8A108", Offset = "0xA8A108", VA = "0xA8A108")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xA8A1D0", Offset = "0xA8A1D0", VA = "0xA8A1D0")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xA89388", Offset = "0xA89388", VA = "0xA89388")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xA894CC", Offset = "0xA894CC", VA = "0xA894CC")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xA8A2C0", Offset = "0xA8A2C0", VA = "0xA8A2C0")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xA89BC0", Offset = "0xA89BC0", VA = "0xA89BC0")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xA89034", Offset = "0xA89034", VA = "0xA89034")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xA8A930", Offset = "0xA8A930", VA = "0xA8A930")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xA8A480", Offset = "0xA8A480", VA = "0xA8A480")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xA89A40", Offset = "0xA89A40", VA = "0xA89A40")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xA89B10", Offset = "0xA89B10", VA = "0xA89B10")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xA8A9E8", Offset = "0xA8A9E8", VA = "0xA8A9E8")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007F")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float rootPin;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xA8AA6C", Offset = "0xA8AA6C", VA = "0xA8AA6C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xA8B0C0", Offset = "0xA8B0C0", VA = "0xA8B0C0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xA8B14C", Offset = "0xA8B14C", VA = "0xA8B14C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xA8B1E0", Offset = "0xA8B1E0", VA = "0xA8B1E0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xA8B2C8", Offset = "0xA8B2C8", VA = "0xA8B2C8")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xA8B358", Offset = "0xA8B358", VA = "0xA8B358", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xA8B758", Offset = "0xA8B758", VA = "0xA8B758", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xA8B930", Offset = "0xA8B930", VA = "0xA8B930", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xA8B7F8", Offset = "0xA8B7F8", VA = "0xA8B7F8")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xA8B530", Offset = "0xA8B530", VA = "0xA8B530")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xA8B9B4", Offset = "0xA8B9B4", VA = "0xA8B9B4")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 10f)]
		public int iterations;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xA8BA14", Offset = "0xA8BA14", VA = "0xA8BA14")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xA8BAF0", Offset = "0xA8BAF0", VA = "0xA8BAF0")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xA8BB38", Offset = "0xA8BB38", VA = "0xA8BB38")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xA8BC4C", Offset = "0xA8BC4C", VA = "0xA8BC4C")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xA8BC9C", Offset = "0xA8BC9C", VA = "0xA8BC9C")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xA8BD10", Offset = "0xA8BD10", VA = "0xA8BD10", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xA8BEA8", Offset = "0xA8BEA8", VA = "0xA8BEA8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xA8C004", Offset = "0xA8C004", VA = "0xA8C004", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xA8C204", Offset = "0xA8C204", VA = "0xA8C204", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xA8C2D8", Offset = "0xA8C2D8", VA = "0xA8C2D8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xA8C3C0", Offset = "0xA8C3C0", VA = "0xA8C3C0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xA8C520", Offset = "0xA8C520", VA = "0xA8C520", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xA8C6BC", Offset = "0xA8C6BC", VA = "0xA8C6BC", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xA8C8F4", Offset = "0xA8C8F4", VA = "0xA8C8F4", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xA8CBD4", Offset = "0xA8CBD4", VA = "0xA8CBD4", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xA8CC0C", Offset = "0xA8CC0C", VA = "0xA8CC0C", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xA8CCF0", Offset = "0xA8CCF0", VA = "0xA8CCF0")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x400031D")]
		Body,
		[Token(Token = "0x400031E")]
		LeftShoulder,
		[Token(Token = "0x400031F")]
		RightShoulder,
		[Token(Token = "0x4000320")]
		LeftThigh,
		[Token(Token = "0x4000321")]
		RightThigh,
		[Token(Token = "0x4000322")]
		LeftHand,
		[Token(Token = "0x4000323")]
		RightHand,
		[Token(Token = "0x4000324")]
		LeftFoot,
		[Token(Token = "0x4000325")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x4000327")]
		LeftArm,
		[Token(Token = "0x4000328")]
		RightArm,
		[Token(Token = "0x4000329")]
		LeftLeg,
		[Token(Token = "0x400032A")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Range(0f, 1f)]
		public float spineStiffness;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[Range(-1f, 1f)]
		public float pullBodyVertical;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000093")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0xA8CE00", Offset = "0xA8CE00", VA = "0xA8CE00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0xA8CF40", Offset = "0xA8CF40", VA = "0xA8CF40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0xA8CF48", Offset = "0xA8CF48", VA = "0xA8CF48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0xA8CF50", Offset = "0xA8CF50", VA = "0xA8CF50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0xA8CF58", Offset = "0xA8CF58", VA = "0xA8CF58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0xA8CF60", Offset = "0xA8CF60", VA = "0xA8CF60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0xA8CF68", Offset = "0xA8CF68", VA = "0xA8CF68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0xA8CF70", Offset = "0xA8CF70", VA = "0xA8CF70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0xA8CF78", Offset = "0xA8CF78", VA = "0xA8CF78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0xA8CF80", Offset = "0xA8CF80", VA = "0xA8CF80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0xA8CFAC", Offset = "0xA8CFAC", VA = "0xA8CFAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0xA8CFD8", Offset = "0xA8CFD8", VA = "0xA8CFD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0xA8D004", Offset = "0xA8D004", VA = "0xA8D004")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0xA8D030", Offset = "0xA8D030", VA = "0xA8D030")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0xA8D058", Offset = "0xA8D058", VA = "0xA8D058")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A2")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0xA8D084", Offset = "0xA8D084", VA = "0xA8D084")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A3")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0xA8D0B0", Offset = "0xA8D0B0", VA = "0xA8D0B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A4")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0xA8D0DC", Offset = "0xA8D0DC", VA = "0xA8D0DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0xA8EECC", Offset = "0xA8EECC", VA = "0xA8EECC")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0xA8EED8", Offset = "0xA8EED8", VA = "0xA8EED8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xA8D104", Offset = "0xA8D104", VA = "0xA8D104")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xA8D204", Offset = "0xA8D204", VA = "0xA8D204")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xA8D154", Offset = "0xA8D154", VA = "0xA8D154")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xA8D27C", Offset = "0xA8D27C", VA = "0xA8D27C")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xA8CE08", Offset = "0xA8CE08", VA = "0xA8CE08")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xA8D344", Offset = "0xA8D344", VA = "0xA8D344")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xA8D3F4", Offset = "0xA8D3F4", VA = "0xA8D3F4")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xA8D4A0", Offset = "0xA8D4A0", VA = "0xA8D4A0")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xA8D54C", Offset = "0xA8D54C", VA = "0xA8D54C")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xA8D554", Offset = "0xA8D554", VA = "0xA8D554")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xA8D57C", Offset = "0xA8D57C", VA = "0xA8D57C")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xA8D63C", Offset = "0xA8D63C", VA = "0xA8D63C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xA8D7CC", Offset = "0xA8D7CC", VA = "0xA8D7CC")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xA8E7C4", Offset = "0xA8E7C4", VA = "0xA8E7C4")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xA8ED74", Offset = "0xA8ED74", VA = "0xA8ED74")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xA8EDD0", Offset = "0xA8EDD0", VA = "0xA8EDD0")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xA8EC14", Offset = "0xA8EC14", VA = "0xA8EC14")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xA8ECC4", Offset = "0xA8ECC4", VA = "0xA8ECC4")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xA8EEE4", Offset = "0xA8EEE4", VA = "0xA8EEE4")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xA8EFA8", Offset = "0xA8EFA8", VA = "0xA8EFA8", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xA8F078", Offset = "0xA8F078", VA = "0xA8F078")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xA8F194", Offset = "0xA8F194", VA = "0xA8F194")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xA8F324", Offset = "0xA8F324", VA = "0xA8F324")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xA8F49C", Offset = "0xA8F49C", VA = "0xA8F49C", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xA8F6FC", Offset = "0xA8F6FC", VA = "0xA8F6FC", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xA8F774", Offset = "0xA8F774", VA = "0xA8F774")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000084")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x170000A6")]
		protected virtual int minBones
		{
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0xA8FFB4", Offset = "0xA8FFB4", VA = "0xA8FFB4", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A7")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0xA8FFBC", Offset = "0xA8FFBC", VA = "0xA8FFBC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A8")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0xA8FFC4", Offset = "0xA8FFC4", VA = "0xA8FFC4", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A9")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0xA90468", Offset = "0xA90468", VA = "0xA90468", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000AA")]
		protected float positionOffset
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0xA90524", Offset = "0xA90524", VA = "0xA90524")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xA8F780", Offset = "0xA8F780", VA = "0xA8F780")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xA8F904", Offset = "0xA8F904", VA = "0xA8F904")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xA8FA30", Offset = "0xA8FA30", VA = "0xA8FA30", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xA8FA90", Offset = "0xA8FA90", VA = "0xA8FA90", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xA8FB04", Offset = "0xA8FB04", VA = "0xA8FB04", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xA8FED0", Offset = "0xA8FED0", VA = "0xA8FED0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xA8FED8", Offset = "0xA8FED8", VA = "0xA8FED8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xA8FFCC", Offset = "0xA8FFCC", VA = "0xA8FFCC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xA8FFD0", Offset = "0xA8FFD0", VA = "0xA8FFD0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xA8FFD4", Offset = "0xA8FFD4", VA = "0xA8FFD4")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xA9056C", Offset = "0xA9056C", VA = "0xA9056C")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xA90924", Offset = "0xA90924", VA = "0xA90924")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xA90BB8", Offset = "0xA90BB8", VA = "0xA90BB8")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000085")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xA90C20", Offset = "0xA90C20", VA = "0xA90C20", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xA90F7C", Offset = "0xA90F7C", VA = "0xA90F7C")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xA90FE0", Offset = "0xA90FE0", VA = "0xA90FE0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xA91124", Offset = "0xA91124", VA = "0xA91124", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xA91284", Offset = "0xA91284", VA = "0xA91284", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xA912D4", Offset = "0xA912D4", VA = "0xA912D4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xA91334", Offset = "0xA91334", VA = "0xA91334", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xA91694", Offset = "0xA91694", VA = "0xA91694", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xA916B4", Offset = "0xA916B4", VA = "0xA916B4")]
		private void Solve()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xA9138C", Offset = "0xA9138C", VA = "0xA9138C")]
		private void Read()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xA91740", Offset = "0xA91740", VA = "0xA91740")]
		private void Write()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xA918B8", Offset = "0xA918B8", VA = "0xA918B8")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000086")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x2000087")]
		public enum BendModifier
		{
			[Token(Token = "0x4000355")]
			Animation,
			[Token(Token = "0x4000356")]
			Target,
			[Token(Token = "0x4000357")]
			Parent,
			[Token(Token = "0x4000358")]
			Arm,
			[Token(Token = "0x4000359")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x2000088")]
		public struct AxisDirection
		{
			[Token(Token = "0x400035A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x400035B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x400035C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x60004EB")]
			[Address(RVA = "0xA92E3C", Offset = "0xA92E3C", VA = "0xA92E3C")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float bendModifierWeight;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x170000AB")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0xA92E20", Offset = "0xA92E20", VA = "0xA92E20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xA91A50", Offset = "0xA91A50", VA = "0xA91A50")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xA91A94", Offset = "0xA91A94", VA = "0xA91A94")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xA91B00", Offset = "0xA91B00", VA = "0xA91B00", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xA92048", Offset = "0xA92048", VA = "0xA92048", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xA92B64", Offset = "0xA92B64", VA = "0xA92B64", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xA92C0C", Offset = "0xA92C0C", VA = "0xA92C0C")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xA92DA0", Offset = "0xA92DA0", VA = "0xA92DA0")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xA91E5C", Offset = "0xA91E5C", VA = "0xA91E5C")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xA92104", Offset = "0xA92104", VA = "0xA92104")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000089")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200008A")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x170000B2")]
			public Vector3 forward
			{
				[Token(Token = "0x600050B")]
				[Address(RVA = "0xA94C08", Offset = "0xA94C08", VA = "0xA94C08")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000507")]
			[Address(RVA = "0xA95260", Offset = "0xA95260", VA = "0xA95260")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000508")]
			[Address(RVA = "0xA93D68", Offset = "0xA93D68", VA = "0xA93D68")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000509")]
			[Address(RVA = "0xA94018", Offset = "0xA94018", VA = "0xA94018")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x600050A")]
			[Address(RVA = "0xA94F50", Offset = "0xA94F50", VA = "0xA94F50")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(0f, 1f)]
		public float headWeight;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float eyesWeight;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Range(0f, 1f)]
		public float clampWeightHead;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Range(0f, 1f)]
		public float clampWeightEyes;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool isDirty;

		[Token(Token = "0x170000AC")]
		protected bool spineIsValid
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0xA9356C", Offset = "0xA9356C", VA = "0xA9356C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AD")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0xA93714", Offset = "0xA93714", VA = "0xA93714")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AE")]
		protected bool headIsValid
		{
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0xA93638", Offset = "0xA93638", VA = "0xA93638")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AF")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0xA93738", Offset = "0xA93738", VA = "0xA93738")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B0")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x6000501")]
			[Address(RVA = "0xA93648", Offset = "0xA93648", VA = "0xA93648")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B1")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x6000502")]
			[Address(RVA = "0xA937A4", Offset = "0xA937A4", VA = "0xA937A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xA92FD8", Offset = "0xA92FD8", VA = "0xA92FD8")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xA92FF4", Offset = "0xA92FF4", VA = "0xA92FF4")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xA93020", Offset = "0xA93020", VA = "0xA93020")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xA93058", Offset = "0xA93058", VA = "0xA93058")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xA930A0", Offset = "0xA930A0", VA = "0xA930A0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xA930F8", Offset = "0xA930F8", VA = "0xA930F8")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xA93168", Offset = "0xA93168", VA = "0xA93168", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xA93280", Offset = "0xA93280", VA = "0xA93280")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xA9328C", Offset = "0xA9328C", VA = "0xA9328C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xA933BC", Offset = "0xA933BC", VA = "0xA933BC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xA937C8", Offset = "0xA937C8", VA = "0xA937C8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xA939EC", Offset = "0xA939EC", VA = "0xA939EC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xA93B4C", Offset = "0xA93B4C", VA = "0xA93B4C")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xA93D90", Offset = "0xA93D90", VA = "0xA93D90", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xA94104", Offset = "0xA94104", VA = "0xA94104", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xA941C8", Offset = "0xA941C8", VA = "0xA941C8")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xA943E4", Offset = "0xA943E4", VA = "0xA943E4")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xA9472C", Offset = "0xA9472C", VA = "0xA9472C")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xA94C38", Offset = "0xA94C38", VA = "0xA94C38")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xA93BFC", Offset = "0xA93BFC", VA = "0xA93BFC")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xA95058", Offset = "0xA95058", VA = "0xA95058")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008B")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200008C")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000523")]
			[Address(RVA = "0xA96504", Offset = "0xA96504", VA = "0xA96504")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000524")]
			[Address(RVA = "0xA96DAC", Offset = "0xA96DAC", VA = "0xA96DAC")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000525")]
			[Address(RVA = "0xA91AD0", Offset = "0xA91AD0", VA = "0xA91AD0")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000526")]
			[Address(RVA = "0xA96E48", Offset = "0xA96E48", VA = "0xA96E48")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xA95268", Offset = "0xA95268", VA = "0xA95268")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xA953FC", Offset = "0xA953FC", VA = "0xA953FC")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xA9557C", Offset = "0xA9557C", VA = "0xA9557C")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xA95588", Offset = "0xA95588", VA = "0xA95588")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xA955A4", Offset = "0xA955A4", VA = "0xA955A4")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xA955B0", Offset = "0xA955B0", VA = "0xA955B0")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xA955B8", Offset = "0xA955B8", VA = "0xA955B8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xA956A4", Offset = "0xA956A4", VA = "0xA956A4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xA9579C", Offset = "0xA9579C", VA = "0xA9579C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xA957DC", Offset = "0xA957DC", VA = "0xA957DC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xA9582C", Offset = "0xA9582C", VA = "0xA9582C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xA95BD0", Offset = "0xA95BD0", VA = "0xA95BD0")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xA95C1C", Offset = "0xA95C1C", VA = "0xA95C1C")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xA96110", Offset = "0xA96110", VA = "0xA96110")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xA96268", Offset = "0xA96268", VA = "0xA96268", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xA96414", Offset = "0xA96414", VA = "0xA96414")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xA96394", Offset = "0xA96394", VA = "0xA96394")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xA965F4", Offset = "0xA965F4", VA = "0xA965F4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xA96E3C", Offset = "0xA96E3C", VA = "0xA96E3C", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xA96E40", Offset = "0xA96E40", VA = "0xA96E40", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xA96E44", Offset = "0xA96E44", VA = "0xA96E44", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xA96BEC", Offset = "0xA96BEC", VA = "0xA96BEC")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xA92C78", Offset = "0xA92C78", VA = "0xA92C78")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008D")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200008E")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x200008F")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x40003BD")]
				YawPitch,
				[Token(Token = "0x40003BE")]
				FromTo
			}

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The hand target. This should not be the hand controller itself, but a child GameObject parented to it so you could adjust it's position/rotation to match the orientation of the hand bone. The best practice for setup would be to move the hand controller to the avatar's hand as it it was held by the avatar, duplicate the avatar's hand bone and parent it to the hand controller. Then assign the duplicate to this slot.")]
			public Transform target;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the hand target. Note that if you have nulled the target, the hand will still be pulled to the last position of the target until you set this value to 0.")]
			public float positionWeight;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the hand target. Note that if you have nulled the target, the hand will still be rotated to the last rotation of the target until you set this value to 0.")]
			public float rotationWeight;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Different techniques for shoulder bone rotation.")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Range(0f, 1f)]
			[Tooltip("The weight of shoulder rotation")]
			public float shoulderRotationWeight;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("The weight of twisting the shoulders backwards when arms are lifted up.")]
			[Range(0f, 1f)]
			public float shoulderTwistWeight;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Angular offset of the elbow bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Use this to make the arm shorter/longer. Works by displacement of hand and forearm localPosition.")]
			[Range(0.01f, 2f)]
			public float armLengthMlp;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Evaluates stretching of the arm by target distance relative to arm length. Value at time 1 represents stretching amount at the point where distance to the target is equal to arm length. Value at time 2 represents stretching amount at the point where distance to the target is double the arm length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce elbow snapping (start stretching the arm slightly before target distance reaches arm length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x40003BA")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x40003BB")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x170000B4")]
			public Vector3 position
			{
				[Token(Token = "0x6000543")]
				[Address(RVA = "0xA9C630", Offset = "0xA9C630", VA = "0xA9C630")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000544")]
				[Address(RVA = "0xA9C63C", Offset = "0xA9C63C", VA = "0xA9C63C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B5")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000545")]
				[Address(RVA = "0xA9C648", Offset = "0xA9C648", VA = "0xA9C648")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000546")]
				[Address(RVA = "0xA9C654", Offset = "0xA9C654", VA = "0xA9C654")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B6")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000547")]
				[Address(RVA = "0xA9C660", Offset = "0xA9C660", VA = "0xA9C660")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B7")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000548")]
				[Address(RVA = "0xA9C688", Offset = "0xA9C688", VA = "0xA9C688")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000549")]
				[Address(RVA = "0xA9C6BC", Offset = "0xA9C6BC", VA = "0xA9C6BC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B9")]
			private VirtualBone hand
			{
				[Token(Token = "0x600054A")]
				[Address(RVA = "0xA9C6FC", Offset = "0xA9C6FC", VA = "0xA9C6FC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0xA9C73C", Offset = "0xA9C73C", VA = "0xA9C73C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0xA9D03C", Offset = "0xA9D03C", VA = "0xA9D03C", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0xA9D2E8", Offset = "0xA9D2E8", VA = "0xA9D2E8", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600054E")]
			[Address(RVA = "0xA9D30C", Offset = "0xA9D30C", VA = "0xA9D30C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600054F")]
			[Address(RVA = "0xA9A56C", Offset = "0xA9A56C", VA = "0xA9A56C")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000550")]
			[Address(RVA = "0xA9DBD8", Offset = "0xA9DBD8", VA = "0xA9DBD8", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0xA9DC30", Offset = "0xA9DC30", VA = "0xA9DC30", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000552")]
			[Address(RVA = "0xA9D65C", Offset = "0xA9D65C", VA = "0xA9D65C")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000553")]
			[Address(RVA = "0xA9D6DC", Offset = "0xA9D6DC", VA = "0xA9D6DC")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000554")]
			[Address(RVA = "0xA9DE3C", Offset = "0xA9DE3C", VA = "0xA9DE3C")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000555")]
			[Address(RVA = "0xA9C4A0", Offset = "0xA9C4A0", VA = "0xA9C4A0")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000090")]
		public abstract class BodyPart
		{
			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x170000BA")]
			public float sqrMag
			{
				[Token(Token = "0x600055B")]
				[Address(RVA = "0xA9DF54", Offset = "0xA9DF54", VA = "0xA9DF54")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600055C")]
				[Address(RVA = "0xA9DF5C", Offset = "0xA9DF5C", VA = "0xA9DF5C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000BB")]
			public float mag
			{
				[Token(Token = "0x600055D")]
				[Address(RVA = "0xA9DF64", Offset = "0xA9DF64", VA = "0xA9DF64")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600055E")]
				[Address(RVA = "0xA9DF6C", Offset = "0xA9DF6C", VA = "0xA9DF6C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000556")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x6000557")]
			public abstract void PreSolve();

			[Token(Token = "0x6000558")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000559")]
			public abstract void ApplyOffsets(float scale);

			[Token(Token = "0x600055A")]
			public abstract void ResetOffsets();

			[Token(Token = "0x600055F")]
			[Address(RVA = "0xA9DF74", Offset = "0xA9DF74", VA = "0xA9DF74")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000560")]
			[Address(RVA = "0xA9DF7C", Offset = "0xA9DF7C", VA = "0xA9DF7C")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000561")]
			[Address(RVA = "0xA9E198", Offset = "0xA9E198", VA = "0xA9E198")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000562")]
			[Address(RVA = "0xA9E220", Offset = "0xA9E220", VA = "0xA9E220")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000563")]
			[Address(RVA = "0xA9E424", Offset = "0xA9E424", VA = "0xA9E424")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000564")]
			[Address(RVA = "0xA9E46C", Offset = "0xA9E46C", VA = "0xA9E46C")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000565")]
			[Address(RVA = "0xA9E590", Offset = "0xA9E590", VA = "0xA9E590")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000566")]
			[Address(RVA = "0xA9E6F4", Offset = "0xA9E6F4", VA = "0xA9E6F4")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000567")]
			[Address(RVA = "0xA9E818", Offset = "0xA9E818", VA = "0xA9E818")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000568")]
			[Address(RVA = "0xA9E82C", Offset = "0xA9E82C", VA = "0xA9E82C")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000091")]
		public class Footstep
		{
			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
			public bool relaxFlag;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x170000BC")]
			public bool isStepping
			{
				[Token(Token = "0x6000569")]
				[Address(RVA = "0xA9E8C4", Offset = "0xA9E8C4", VA = "0xA9E8C4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000BD")]
			public float stepProgress
			{
				[Token(Token = "0x600056A")]
				[Address(RVA = "0xA9E8D8", Offset = "0xA9E8D8", VA = "0xA9E8D8")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600056B")]
				[Address(RVA = "0xA9E8E0", Offset = "0xA9E8E0", VA = "0xA9E8E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600056C")]
			[Address(RVA = "0xA9E8E8", Offset = "0xA9E8E8", VA = "0xA9E8E8")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x600056D")]
			[Address(RVA = "0xA9EAAC", Offset = "0xA9EAAC", VA = "0xA9EAAC")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x600056E")]
			[Address(RVA = "0xA9EAF4", Offset = "0xA9EAF4", VA = "0xA9EAF4")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0xA9ED38", Offset = "0xA9ED38", VA = "0xA9ED38")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000570")]
			[Address(RVA = "0xA9EF40", Offset = "0xA9EF40", VA = "0xA9EF40")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0xA9F124", Offset = "0xA9F124", VA = "0xA9F124")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000092")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The foot/toe target. This should not be the foot tracker itself, but a child GameObject parented to it so you could adjust it's position/rotation to match the orientation of the foot/toe bone. If a toe bone is assigned in the References, the solver will match the toe bone to this target. If no toe bone assigned, foot bone will be used instead.")]
			public Transform target;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the toe/foot target. Note that if you have nulled the target, the foot will still be pulled to the last position of the target until you set this value to 0.")]
			public float positionWeight;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the toe/foot target. Note that if you have nulled the target, the foot will still be rotated to the last rotation of the target until you set this value to 0.")]
			public float rotationWeight;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Angular offset of knee bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If 0, the bend plane will be locked to the rotation of the pelvis and rotating the foot will have no effect on the knee direction. If 1, to the target rotation of the leg so that the knee will bend towards the forward axis of the foot. Values in between will be slerped between the two.")]
			[Range(0f, 1f)]
			public float bendToTargetWeight;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[Range(0.01f, 2f)]
			[Tooltip("Use this to make the leg shorter/longer. Works by displacement of foot and calf localPosition.")]
			public float legLengthMlp;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Evaluates stretching of the leg by target distance relative to leg length. Value at time 1 represents stretching amount at the point where distance to the target is equal to leg length. Value at time 1 represents stretching amount at the point where distance to the target is double the leg length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce knee snapping (start stretching the arm slightly before target distance reaches leg length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x170000BE")]
			public Vector3 position
			{
				[Token(Token = "0x6000572")]
				[Address(RVA = "0xA9F298", Offset = "0xA9F298", VA = "0xA9F298")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000573")]
				[Address(RVA = "0xA9F2A4", Offset = "0xA9F2A4", VA = "0xA9F2A4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000BF")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000574")]
				[Address(RVA = "0xA9F2B0", Offset = "0xA9F2B0", VA = "0xA9F2B0")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000575")]
				[Address(RVA = "0xA9F2BC", Offset = "0xA9F2BC", VA = "0xA9F2BC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000C0")]
			public bool hasToes
			{
				[Token(Token = "0x6000576")]
				[Address(RVA = "0xA9F2C8", Offset = "0xA9F2C8", VA = "0xA9F2C8")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000577")]
				[Address(RVA = "0xA9F2D0", Offset = "0xA9F2D0", VA = "0xA9F2D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000C1")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000578")]
				[Address(RVA = "0xA9F2DC", Offset = "0xA9F2DC", VA = "0xA9F2DC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000579")]
				[Address(RVA = "0xA9F304", Offset = "0xA9F304", VA = "0xA9F304")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C3")]
			private VirtualBone foot
			{
				[Token(Token = "0x600057A")]
				[Address(RVA = "0xA9F330", Offset = "0xA9F330", VA = "0xA9F330")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			private VirtualBone toes
			{
				[Token(Token = "0x600057B")]
				[Address(RVA = "0xA9F35C", Offset = "0xA9F35C", VA = "0xA9F35C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C5")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x600057C")]
				[Address(RVA = "0xA9F388", Offset = "0xA9F388", VA = "0xA9F388")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C6")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x600057D")]
				[Address(RVA = "0xA9F3BC", Offset = "0xA9F3BC", VA = "0xA9F3BC")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600057E")]
				[Address(RVA = "0xA9F3C8", Offset = "0xA9F3C8", VA = "0xA9F3C8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600057F")]
			[Address(RVA = "0xA9F3D4", Offset = "0xA9F3D4", VA = "0xA9F3D4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000580")]
			[Address(RVA = "0xA9F98C", Offset = "0xA9F98C", VA = "0xA9F98C", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000581")]
			[Address(RVA = "0xAA01BC", Offset = "0xAA01BC", VA = "0xAA01BC", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000582")]
			[Address(RVA = "0xAA016C", Offset = "0xAA016C", VA = "0xAA016C")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000583")]
			[Address(RVA = "0xA9FF20", Offset = "0xA9FF20", VA = "0xA9FF20")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000584")]
			[Address(RVA = "0xAA0698", Offset = "0xAA0698", VA = "0xAA0698")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000585")]
			[Address(RVA = "0xAA109C", Offset = "0xAA109C", VA = "0xAA109C")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x6000586")]
			[Address(RVA = "0xAA08DC", Offset = "0xAA08DC", VA = "0xAA08DC")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000587")]
			[Address(RVA = "0xAA14F4", Offset = "0xAA14F4", VA = "0xAA14F4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000588")]
			[Address(RVA = "0xAA16FC", Offset = "0xAA16FC", VA = "0xAA16FC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000589")]
			[Address(RVA = "0xAA17DC", Offset = "0xAA17DC", VA = "0xAA17DC")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000093")]
		public class Locomotion
		{
			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Used for blending in/out of procedural locomotion.")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			public float stepThreshold;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			public float maxVelocity;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The amount of head/hand target velocity prediction.")]
			public float velocityFactor;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			[Range(0.9f, 1f)]
			public float maxLegStretch;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The speed of moving a foot to the next position.")]
			public float stepSpeed;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("Reduce this value if locomotion makes the head bob too much.")]
			public float maxBodyYOffset;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Range(0f, 180f)]
			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Interpolation mode of the step.")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Offset for the approximated center of mass.")]
			public Vector3 offset;

			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Called when the left foot has finished a step.")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Called when the right foot has finished a step")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Footstep[] footsteps;

			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Vector3 lastComPosition;

			[Token(Token = "0x400040B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private Vector3 comVelocity;

			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int leftFootIndex;

			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int rightFootIndex;

			[Token(Token = "0x170000C7")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x600058A")]
				[Address(RVA = "0xAA18B8", Offset = "0xAA18B8", VA = "0xAA18B8")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600058B")]
				[Address(RVA = "0xAA18C4", Offset = "0xAA18C4", VA = "0xAA18C4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000C8")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000592")]
				[Address(RVA = "0xAA3B34", Offset = "0xAA3B34", VA = "0xAA3B34")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000C9")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000593")]
				[Address(RVA = "0xAA3B68", Offset = "0xAA3B68", VA = "0xAA3B68")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000CA")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000594")]
				[Address(RVA = "0xAA3BA0", Offset = "0xAA3BA0", VA = "0xAA3BA0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000CB")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000595")]
				[Address(RVA = "0xAA3BD4", Offset = "0xAA3BD4", VA = "0xAA3BD4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600058C")]
			[Address(RVA = "0xAA18D0", Offset = "0xAA18D0", VA = "0xAA18D0")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x600058D")]
			[Address(RVA = "0xAA1BD8", Offset = "0xAA1BD8", VA = "0xAA1BD8")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x600058E")]
			[Address(RVA = "0xAA1DBC", Offset = "0xAA1DBC", VA = "0xAA1DBC")]
			public void Relax()
			{
			}

			[Token(Token = "0x600058F")]
			[Address(RVA = "0xAA1E08", Offset = "0xAA1E08", VA = "0xAA1E08")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000590")]
			[Address(RVA = "0xAA21D0", Offset = "0xAA21D0", VA = "0xAA21D0")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000591")]
			[Address(RVA = "0xAA2288", Offset = "0xAA2288", VA = "0xAA2288")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale)
			{
			}

			[Token(Token = "0x6000596")]
			[Address(RVA = "0xAA3764", Offset = "0xAA3764", VA = "0xAA3764")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000597")]
			[Address(RVA = "0xAA3918", Offset = "0xAA3918", VA = "0xAA3918")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000598")]
			[Address(RVA = "0xAA3984", Offset = "0xAA3984", VA = "0xAA3984")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000599")]
			[Address(RVA = "0xAA3C0C", Offset = "0xAA3C0C", VA = "0xAA3C0C")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000094")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The head target. This should not be the camera Transform itself, but a child GameObject parented to it so you could adjust it's position/rotation  to match the orientation of the head bone. The best practice for setup would be to move the camera to the avatar's eyes, duplicate the avatar's head bone and parent it to the camera. Then assign the duplicate to this slot.")]
			public Transform headTarget;

			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The pelvis target (optional), useful for seated rigs or if you had an additional tracker on the backpack or belt are. The best practice for setup would be to duplicate the avatar's pelvis bone and parenting it to the pelvis tracker. Then assign the duplicate to this slot.")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Positional weight of the head target. Note that if you have nulled the headTarget, the head will still be pulled to the last position of the headTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the head target. Note that if you have nulled the headTarget, the head will still be rotated to the last rotation of the headTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Positional weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be pulled to the last position of the pelvisTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Rotational weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be rotated to the last rotation of the pelvisTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Range(0f, 1f)]
			[Tooltip("Weight of turning the chest towards the 'Chest Goal'.")]
			public float chestGoalWeight;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Determines how much the body will follow the position of the head.")]
			[Range(0f, 1f)]
			public float bodyPosStiffness;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			[Range(0f, 1f)]
			public float bodyRotStiffness;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			[FormerlySerializedAs("chestRotationWeight")]
			[Range(0f, 1f)]
			public float neckStiffness;

			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			[Range(0f, 1f)]
			public float rotateChestByHands;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Tooltip("Clamps chest rotation. Value of 0.5 allows 90 degrees of rotation for the chest relative to the head. Value of 0 allows 180 degrees and value of 1 means the chest will be locked relative to the head.")]
			[Range(0f, 1f)]
			public float chestClampWeight;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Clamps head rotation. Value of 0.5 allows 90 degrees of rotation for the head relative to the headTarget. Value of 0 allows 180 degrees and value of 1 means head rotation will be locked to the target.")]
			[Range(0f, 1f)]
			public float headClampWeight;

			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[Tooltip("How much will the pelvis maintain it's animated position?")]
			[Range(0f, 1f)]
			public float maintainPelvisPosition;

			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			[Range(0f, 180f)]
			public float maxRootAngle;

			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[Tooltip("Angular offset for root heading. Adjust this value to turn the root relative to the HMD around the vertical axis. Usefulf for fighting or shooting games where you would sometimes want the avatar to stand at an angled stance.")]
			[Range(-180f, 180f)]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x170000CC")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x600059A")]
				[Address(RVA = "0xAA36FC", Offset = "0xAA36FC", VA = "0xAA36FC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CD")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x600059B")]
				[Address(RVA = "0xAA3D04", Offset = "0xAA3D04", VA = "0xAA3D04")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			public VirtualBone chest
			{
				[Token(Token = "0x600059C")]
				[Address(RVA = "0xAA3D38", Offset = "0xAA3D38", VA = "0xAA3D38")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CF")]
			private VirtualBone neck
			{
				[Token(Token = "0x600059D")]
				[Address(RVA = "0xAA3D80", Offset = "0xAA3D80", VA = "0xAA3D80")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D0")]
			public VirtualBone head
			{
				[Token(Token = "0x600059E")]
				[Address(RVA = "0xAA3730", Offset = "0xAA3730", VA = "0xAA3730")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x600059F")]
				[Address(RVA = "0xAA3DB4", Offset = "0xAA3DB4", VA = "0xAA3DB4")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60005A0")]
				[Address(RVA = "0xAA3DC8", Offset = "0xAA3DC8", VA = "0xAA3DC8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000D2")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x60005A1")]
				[Address(RVA = "0xAA3DDC", Offset = "0xAA3DDC", VA = "0xAA3DDC")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60005A2")]
				[Address(RVA = "0xAA3DF0", Offset = "0xAA3DF0", VA = "0xAA3DF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0xAA3E04", Offset = "0xAA3E04", VA = "0xAA3E04", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0xAA4A64", Offset = "0xAA4A64", VA = "0xAA4A64", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0xAA4C4C", Offset = "0xAA4C4C", VA = "0xAA4C4C", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0xAA53F4", Offset = "0xAA53F4", VA = "0xAA53F4")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0xAA5A30", Offset = "0xAA5A30", VA = "0xAA5A30")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0xAA6390", Offset = "0xAA6390", VA = "0xAA6390")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xAA6B34", Offset = "0xAA6B34", VA = "0xAA6B34")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0xAA7114", Offset = "0xAA7114", VA = "0xAA7114", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xAA72E4", Offset = "0xAA72E4", VA = "0xAA72E4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60005AC")]
			[Address(RVA = "0xAA5638", Offset = "0xAA5638", VA = "0xAA5638")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x60005AD")]
			[Address(RVA = "0xAA6860", Offset = "0xAA6860", VA = "0xAA6860")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x60005AE")]
			[Address(RVA = "0xAA5F74", Offset = "0xAA5F74", VA = "0xAA5F74")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x60005AF")]
			[Address(RVA = "0xAA73B8", Offset = "0xAA73B8", VA = "0xAA73B8")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005B0")]
			[Address(RVA = "0xAA6938", Offset = "0xAA6938", VA = "0xAA6938")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0xAA65F0", Offset = "0xAA65F0", VA = "0xAA65F0")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60005B2")]
			[Address(RVA = "0xAA7654", Offset = "0xAA7654", VA = "0xAA7654")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000095")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000446")]
			Pelvis,
			[Token(Token = "0x4000447")]
			Chest,
			[Token(Token = "0x4000448")]
			Head,
			[Token(Token = "0x4000449")]
			LeftHand,
			[Token(Token = "0x400044A")]
			RightHand,
			[Token(Token = "0x400044B")]
			LeftFoot,
			[Token(Token = "0x400044C")]
			RightFoot,
			[Token(Token = "0x400044D")]
			LeftHeel,
			[Token(Token = "0x400044E")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x2000096")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000450")]
			Pelvis,
			[Token(Token = "0x4000451")]
			Chest,
			[Token(Token = "0x4000452")]
			Head
		}

		[Serializable]
		[Token(Token = "0x2000097")]
		public class VirtualBone
		{
			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x60005B3")]
			[Address(RVA = "0xA9F8FC", Offset = "0xA9F8FC", VA = "0xA9F8FC")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0xA9F96C", Offset = "0xA9F96C", VA = "0xA9F96C")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005B5")]
			[Address(RVA = "0xAA776C", Offset = "0xAA776C", VA = "0xAA776C")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0xA9E038", Offset = "0xA9E038", VA = "0xA9E038")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0xA9E2B4", Offset = "0xA9E2B4", VA = "0xA9E2B4")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005B8")]
			[Address(RVA = "0xAA796C", Offset = "0xAA796C", VA = "0xAA796C")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xAA7B14", Offset = "0xAA7B14", VA = "0xAA7B14")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0xAA7C9C", Offset = "0xAA7C9C", VA = "0xAA7C9C")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0xAA0CB8", Offset = "0xAA0CB8", VA = "0xAA0CB8")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0xAA7D40", Offset = "0xAA7D40", VA = "0xAA7D40")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0xAA6D48", Offset = "0xAA6D48", VA = "0xAA6D48")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0xAA7E98", Offset = "0xAA7E98", VA = "0xAA7E98")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0xAA7FAC", Offset = "0xAA7FAC", VA = "0xAA7FAC")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Range(0f, 2f)]
		[Tooltip("LOD 0: Full quality solving. LOD 1: Shoulder solving, stretching plant feet disabled, spine solving quality reduced. This provides about 30% of performance gain. LOD 2: Culled, but updating root position and rotation if locomotion is enabled.")]
		public int LOD;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Scale of the character. Value of 1 means normal adult human size.")]
		public float scale;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[Tooltip("If true, will keep the toes planted even if head target is out of reach, so this can cause the camera to exit the head if it is too high for the model to reach. Enabling this increases the cost of the solver as the legs will have to be solved multiple times.")]
		public bool plantFeet;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Tooltip("The spine solver.")]
		public Spine spine;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Tooltip("The left arm solver.")]
		public Arm leftArm;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Tooltip("The right arm solver.")]
		public Arm rightArm;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Tooltip("The left leg solver.")]
		public Leg leftLeg;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Tooltip("The right leg solver.")]
		public Leg rightLeg;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("Procedural leg shuffling for stationary VR games. Not designed for roomscale and thumbstick locomotion. For those it would be better to use a strafing locomotion blend tree to make the character follow the horizontal direction towards the HMD by root motion or script.")]
		public Locomotion locomotion;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x170000B3")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x600053E")]
			[Address(RVA = "0xA9C254", Offset = "0xA9C254", VA = "0xA9C254")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600053F")]
			[Address(RVA = "0xA9C25C", Offset = "0xA9C25C", VA = "0xA9C25C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xA96E50", Offset = "0xA96E50", VA = "0xA96E50")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xA97270", Offset = "0xA97270", VA = "0xA97270")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xA97124", Offset = "0xA97124", VA = "0xA97124")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xA97684", Offset = "0xA97684", VA = "0xA97684")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xA977C8", Offset = "0xA977C8", VA = "0xA977C8")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xA97808", Offset = "0xA97808", VA = "0xA97808")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xA9792C", Offset = "0xA9792C", VA = "0xA9792C")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xA97A08", Offset = "0xA97A08", VA = "0xA97A08")]
		public void Reset()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xA98194", Offset = "0xA98194", VA = "0xA98194", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xA982E8", Offset = "0xA982E8", VA = "0xA982E8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xA984D4", Offset = "0xA984D4", VA = "0xA984D4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xA98544", Offset = "0xA98544", VA = "0xA98544", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xA985B4", Offset = "0xA985B4", VA = "0xA985B4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xA987B0", Offset = "0xA987B0", VA = "0xA987B0")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xA97570", Offset = "0xA97570", VA = "0xA97570")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xA97B1C", Offset = "0xA97B1C", VA = "0xA97B1C")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xA98A20", Offset = "0xA98A20", VA = "0xA98A20", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xA98A5C", Offset = "0xA98A5C", VA = "0xA98A5C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xA9A0A4", Offset = "0xA9A0A4", VA = "0xA9A0A4")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xA97C6C", Offset = "0xA97C6C", VA = "0xA97C6C")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xA98E68", Offset = "0xA98E68", VA = "0xA98E68")]
		private void Solve()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xA9A4F8", Offset = "0xA9A4F8", VA = "0xA9A4F8")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xA9A534", Offset = "0xA9A534", VA = "0xA9A534")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xA99F68", Offset = "0xA99F68", VA = "0xA99F68")]
		private void Write()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xA9BB68", Offset = "0xA9BB68", VA = "0xA9BB68")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xA9C264", Offset = "0xA9C264", VA = "0xA9C264")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If using multiple solvers, add them in inverse hierarchical order - first forearm roll bone, then forearm bone and upper arm bone.")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xAA8160", Offset = "0xAA8160", VA = "0xAA8160")]
		public void Start()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xAA878C", Offset = "0xAA878C", VA = "0xAA878C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xAA8D20", Offset = "0xAA8D20", VA = "0xAA8D20")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xAA8DD0", Offset = "0xAA8DD0", VA = "0xAA8DD0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xAA8EE8", Offset = "0xAA8EE8", VA = "0xAA8EE8")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000099")]
	public class TwistSolver
	{
		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("The transform that this solver operates on.")]
		public Transform transform;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If this is the forearm roll bone, the parent should be the forearm bone. If null, will be found automatically.")]
		public Transform parent;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If this is the forearm roll bone, the child should be the hand bone. If null, will attempt to find automatically. Assign the hand manually if the hand bone is not a child of the roll bone.")]
		public Transform[] children;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[Tooltip("The weight of relaxing the twist of this Transform")]
		public float weight;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Rotation offset around the twist axis.")]
		[Range(-180f, 180f)]
		public float twistAngleOffset;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 axis;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion[] childRotations;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool inititated;

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xAA8F40", Offset = "0xAA8F40", VA = "0xAA8F40")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xAA8328", Offset = "0xAA8328", VA = "0xAA8328")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xAA883C", Offset = "0xAA883C", VA = "0xAA883C")]
		public void Relax()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009A")]
	public class InteractionEffector
	{
		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x170000D3")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0xAA9028", Offset = "0xAA9028", VA = "0xAA9028")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0xAA9030", Offset = "0xAA9030", VA = "0xAA9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public bool isPaused
		{
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0xAA9038", Offset = "0xAA9038", VA = "0xAA9038")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0xAA9040", Offset = "0xAA9040", VA = "0xAA9040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0xAA904C", Offset = "0xAA904C", VA = "0xAA904C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0xAA9054", Offset = "0xAA9054", VA = "0xAA9054")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		public bool inInteraction
		{
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0xAA905C", Offset = "0xAA905C", VA = "0xAA905C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D7")]
		public float progress
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0xAAB220", Offset = "0xAAB220", VA = "0xAAB220")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xAA90BC", Offset = "0xAA90BC", VA = "0xAA90BC")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xAA914C", Offset = "0xAA914C", VA = "0xAA914C")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xAA91D8", Offset = "0xAA91D8", VA = "0xAA91D8")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xAA9344", Offset = "0xAA9344", VA = "0xAA9344")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xAA9720", Offset = "0xAA9720", VA = "0xAA9720")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xAA9840", Offset = "0xAA9840", VA = "0xAA9840")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xAA9894", Offset = "0xAA9894", VA = "0xAA9894")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xAA9EE4", Offset = "0xAA9EE4", VA = "0xAA9EE4")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xAAA9D8", Offset = "0xAAA9D8", VA = "0xAAA9D8")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xAAABF8", Offset = "0xAAABF8", VA = "0xAAABF8")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xAAB0D4", Offset = "0xAAB0D4", VA = "0xAAB0D4")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xAAB394", Offset = "0xAAB394", VA = "0xAAB394")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009B")]
	public class InteractionLookAt
	{
		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xAAB65C", Offset = "0xAAB65C", VA = "0xAAB65C")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xAAB76C", Offset = "0xAAB76C", VA = "0xAAB76C")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xAAB804", Offset = "0xAAB804", VA = "0xAAB804")]
		public void Update()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xAAB9F4", Offset = "0xAAB9F4", VA = "0xAAB9F4")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xAABA9C", Offset = "0xAABA9C", VA = "0xAABA9C")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xAABB48", Offset = "0xAABB48", VA = "0xAABB48")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x200009C")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200009D")]
		public class InteractionEvent
		{
			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The animations called on this event.")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public Message[] messages;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0xAAB250", Offset = "0xAAB250", VA = "0xAAB250")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0xAACA4C", Offset = "0xAACA4C", VA = "0xAACA4C")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200009E")]
		public class Message
		{
			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The name of the function called.")]
			public string function;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			[Token(Token = "0x40004A5")]
			private const string empty = "";

			[Token(Token = "0x6000600")]
			[Address(RVA = "0xAAC954", Offset = "0xAAC954", VA = "0xAAC954")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0xAACA54", Offset = "0xAACA54", VA = "0xAACA54")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200009F")]
		public class AnimatorEvent
		{
			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The name of the animation state.")]
			public string animationState;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The crossfading time.")]
			public float crossfadeTime;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40004AC")]
			private const string empty = "";

			[Token(Token = "0x6000602")]
			[Address(RVA = "0xAAC878", Offset = "0xAAC878", VA = "0xAAC878")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0xAACA5C", Offset = "0xAACA5C", VA = "0xAACA5C")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0xAACB0C", Offset = "0xAACB0C", VA = "0xAACB0C")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0xAACBE4", Offset = "0xAACBE4", VA = "0xAACBE4")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A0")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20000A1")]
			public enum Type
			{
				[Token(Token = "0x40004B0")]
				PositionWeight,
				[Token(Token = "0x40004B1")]
				RotationWeight,
				[Token(Token = "0x40004B2")]
				PositionOffsetX,
				[Token(Token = "0x40004B3")]
				PositionOffsetY,
				[Token(Token = "0x40004B4")]
				PositionOffsetZ,
				[Token(Token = "0x40004B5")]
				Pull,
				[Token(Token = "0x40004B6")]
				Reach,
				[Token(Token = "0x40004B7")]
				RotateBoneWeight,
				[Token(Token = "0x40004B8")]
				Push,
				[Token(Token = "0x40004B9")]
				PushParent,
				[Token(Token = "0x40004BA")]
				PoserWeight,
				[Token(Token = "0x40004BB")]
				BendGoalWeight
			}

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			[Token(Token = "0x6000606")]
			[Address(RVA = "0xAAC188", Offset = "0xAAC188", VA = "0xAAC188")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0xAACBF8", Offset = "0xAACBF8", VA = "0xAACBF8")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A2")]
		public class Multiplier
		{
			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000608")]
			[Address(RVA = "0xAAC790", Offset = "0xAAC790", VA = "0xAAC790")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0xAACC00", Offset = "0xAACC00", VA = "0xAACC00")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x170000D8")]
		public float length
		{
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0xAABD7C", Offset = "0xAABD7C", VA = "0xAABD7C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0xAABD84", Offset = "0xAABD84", VA = "0xAABD84")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xAABD8C", Offset = "0xAABD8C", VA = "0xAABD8C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0xAABD94", Offset = "0xAABD94", VA = "0xAABD94")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0xAABF4C", Offset = "0xAABF4C", VA = "0xAABF4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DB")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0xAAB314", Offset = "0xAAB314", VA = "0xAAB314")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xAABB5C", Offset = "0xAABB5C", VA = "0xAABB5C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xAABBA0", Offset = "0xAABBA0", VA = "0xAABBA0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xAABBE4", Offset = "0xAABBE4", VA = "0xAABBE4")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xAABC28", Offset = "0xAABC28", VA = "0xAABC28")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xAABC6C", Offset = "0xAABC6C", VA = "0xAABC6C")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xAABCB0", Offset = "0xAABCB0", VA = "0xAABCB0")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xAABCF4", Offset = "0xAABCF4", VA = "0xAABCF4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xAABD38", Offset = "0xAABD38", VA = "0xAABD38")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xAABD9C", Offset = "0xAABD9C", VA = "0xAABD9C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xAABFCC", Offset = "0xAABFCC", VA = "0xAABFCC")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xAA9E50", Offset = "0xAA9E50", VA = "0xAA9E50")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xAAC11C", Offset = "0xAAC11C", VA = "0xAAC11C")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xAA9D14", Offset = "0xAA9D14", VA = "0xAA9D14")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xAA9E48", Offset = "0xAA9E48", VA = "0xAA9E48")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xAAA5C8", Offset = "0xAAA5C8", VA = "0xAAA5C8")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xAAAEC0", Offset = "0xAAAEC0", VA = "0xAAAEC0")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xAAC7C0", Offset = "0xAAC7C0", VA = "0xAAC7C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xAAC1A4", Offset = "0xAAC1A4", VA = "0xAAC1A4")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xAAC124", Offset = "0xAAC124", VA = "0xAAC124")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xAAC734", Offset = "0xAAC734", VA = "0xAAC734")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xAAC7C4", Offset = "0xAAC7C4", VA = "0xAAC7C4")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xAAC820", Offset = "0xAAC820", VA = "0xAAC820")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000A4")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000A5")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The master speed for all interactions.")]
		public float speed;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("collider")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		[Header("Triggering")]
		public Collider characterCollider;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		[FormerlySerializedAs("camera")]
		public Transform FPSCamera;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Tooltip("Reference to the FBBIK component.")]
		[Space(10f)]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x170000DC")]
		public bool inInteraction
		{
			[Token(Token = "0x6000612")]
			[Address(RVA = "0xAACE30", Offset = "0xAACE30", VA = "0xAACE30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DD")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0xAAE890", Offset = "0xAAE890", VA = "0xAAE890")]
			get
			{
				return null;
			}
			[Token(Token = "0x600062D")]
			[Address(RVA = "0xAAE898", Offset = "0xAAE898", VA = "0xAAE898")]
			set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x600062E")]
			[Address(RVA = "0xAAE8A0", Offset = "0xAAE8A0", VA = "0xAAE8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600062F")]
			[Address(RVA = "0xAAE8A8", Offset = "0xAAE8A8", VA = "0xAAE8A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public bool initiated
		{
			[Token(Token = "0x6000630")]
			[Address(RVA = "0xAAE8B0", Offset = "0xAAE8B0", VA = "0xAAE8B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000631")]
			[Address(RVA = "0xAAE8B8", Offset = "0xAAE8B8", VA = "0xAAE8B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xAACC10", Offset = "0xAACC10", VA = "0xAACC10")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xAACC54", Offset = "0xAACC54", VA = "0xAACC54")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xAACC98", Offset = "0xAACC98", VA = "0xAACC98")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xAACCDC", Offset = "0xAACCDC", VA = "0xAACCDC")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xAACD20", Offset = "0xAACD20", VA = "0xAACD20")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xAACD64", Offset = "0xAACD64", VA = "0xAACD64")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xAACDA8", Offset = "0xAACDA8", VA = "0xAACDA8")]
		[ContextMenu("Support")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xAACDEC", Offset = "0xAACDEC", VA = "0xAACDEC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xAACFA8", Offset = "0xAACFA8", VA = "0xAACFA8")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xAAD060", Offset = "0xAAD060", VA = "0xAAD060")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xAAD118", Offset = "0xAAD118", VA = "0xAAD118")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xAAD1B0", Offset = "0xAAD1B0", VA = "0xAAD1B0")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xAAD294", Offset = "0xAAD294", VA = "0xAAD294")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xAAD38C", Offset = "0xAAD38C", VA = "0xAAD38C")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xAAD410", Offset = "0xAAD410", VA = "0xAAD410")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xAAD494", Offset = "0xAAD494", VA = "0xAAD494")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xAAD518", Offset = "0xAAD518", VA = "0xAAD518")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xAAD580", Offset = "0xAAD580", VA = "0xAAD580")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xAAD5E8", Offset = "0xAAD5E8", VA = "0xAAD5E8")]
		public void StopAll()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xAAD644", Offset = "0xAAD644", VA = "0xAAD644")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xAAD6C4", Offset = "0xAAD6C4", VA = "0xAAD6C4")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xAAD76C", Offset = "0xAAD76C", VA = "0xAAD76C")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xAAD83C", Offset = "0xAAD83C", VA = "0xAAD83C")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xAADACC", Offset = "0xAADACC", VA = "0xAADACC")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xAADC88", Offset = "0xAADC88", VA = "0xAADC88")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xAADEF0", Offset = "0xAADEF0", VA = "0xAADEF0")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xAAE17C", Offset = "0xAAE17C", VA = "0xAAE17C")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xAAE1B4", Offset = "0xAAE1B4", VA = "0xAAE1B4")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xAAE214", Offset = "0xAAE214", VA = "0xAAE214")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xAAE31C", Offset = "0xAAE31C", VA = "0xAAE31C")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xAAE4FC", Offset = "0xAAE4FC", VA = "0xAAE4FC")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xAAE770", Offset = "0xAAE770", VA = "0xAAE770")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xAADFD8", Offset = "0xAADFD8", VA = "0xAADFD8")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xAAE8C4", Offset = "0xAAE8C4", VA = "0xAAE8C4")]
		public void Start()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xAAF05C", Offset = "0xAAF05C", VA = "0xAAF05C")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xAAF07C", Offset = "0xAAF07C", VA = "0xAAF07C")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xAAF098", Offset = "0xAAF098", VA = "0xAAF098")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xAAF0B4", Offset = "0xAAF0B4", VA = "0xAAF0B4")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xAAF108", Offset = "0xAAF108", VA = "0xAAF108")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xAAF274", Offset = "0xAAF274", VA = "0xAAF274")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xAAF370", Offset = "0xAAF370", VA = "0xAAF370")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xAAF51C", Offset = "0xAAF51C", VA = "0xAAF51C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xAAF600", Offset = "0xAAF600", VA = "0xAAF600")]
		public void Update()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xAAF8C0", Offset = "0xAAF8C0", VA = "0xAAF8C0")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xAAEE14", Offset = "0xAAEE14", VA = "0xAAEE14")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xAAF9F0", Offset = "0xAAF9F0", VA = "0xAAF9F0")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xAAFAFC", Offset = "0xAAFAFC", VA = "0xAAFAFC")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xAAFB84", Offset = "0xAAFB84", VA = "0xAAFB84")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xAAFC44", Offset = "0xAAFC44", VA = "0xAAFC44")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xAAFC5C", Offset = "0xAAFC5C", VA = "0xAAFC5C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xAACEC8", Offset = "0xAACEC8", VA = "0xAACEC8")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xAAD9B8", Offset = "0xAAD9B8", VA = "0xAAD9B8")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xAB0054", Offset = "0xAB0054", VA = "0xAB0054")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A7")]
		public enum RotationMode
		{
			[Token(Token = "0x40004E4")]
			TwoDOF,
			[Token(Token = "0x40004E5")]
			ThreeDOF
		}

		[Serializable]
		[Token(Token = "0x20000A8")]
		public class Multiplier
		{
			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x600065A")]
			[Address(RVA = "0xAB10AC", Offset = "0xAB10AC", VA = "0xAB10AC")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("2 or 3 degrees of freedom to match this InteractionTarget's rotation to the effector bone rotation.")]
		public RotationMode rotationMode;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating this InteractionTarget to the effector bone in the start of the interaction (and during if 'Rotate Once' is disabled")]
		public float threeDOFWeight;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xAB06E8", Offset = "0xAB06E8", VA = "0xAB06E8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xAB072C", Offset = "0xAB072C", VA = "0xAB072C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xAB0770", Offset = "0xAB0770", VA = "0xAB0770")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xAB07B4", Offset = "0xAB07B4", VA = "0xAB07B4")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xAB07F8", Offset = "0xAB07F8", VA = "0xAB07F8")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xAB083C", Offset = "0xAB083C", VA = "0xAB083C")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xAB0880", Offset = "0xAB0880", VA = "0xAB0880")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xAB08C4", Offset = "0xAB08C4", VA = "0xAB08C4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xAB0908", Offset = "0xAB0908", VA = "0xAB0908")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xAB096C", Offset = "0xAB096C", VA = "0xAB096C")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xAB09F8", Offset = "0xAB09F8", VA = "0xAB09F8")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xAB1038", Offset = "0xAB1038", VA = "0xAB1038")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000AA")]
		public class CharacterPosition
		{
			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Angle offset from the default forward direction.")]
			[Range(-180f, 180f)]
			public float angleOffset;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Range(0f, 180f)]
			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			public float maxAngle;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("If true, will rotate the trigger around it's Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;

			[Token(Token = "0x170000E0")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000662")]
				[Address(RVA = "0xAB14C4", Offset = "0xAB14C4", VA = "0xAB14C4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E1")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000663")]
				[Address(RVA = "0xAB14D0", Offset = "0xAB14D0", VA = "0xAB14D0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0xAB1590", Offset = "0xAB1590", VA = "0xAB1590")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0xAB1CF4", Offset = "0xAB1CF4", VA = "0xAB1CF4")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AB")]
		public class CameraPosition
		{
			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("What the camera should be looking at to trigger the interaction? If null, this camera position will not be used.")]
			public Collider lookAtTarget;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Range(0f, 180f)]
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			public float maxAngle;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;

			[Token(Token = "0x6000666")]
			[Address(RVA = "0xAB1D08", Offset = "0xAB1D08", VA = "0xAB1D08")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0xAB1E80", Offset = "0xAB1E80", VA = "0xAB1E80")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0xAB2188", Offset = "0xAB2188", VA = "0xAB2188")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AC")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20000AD")]
			public class Interaction
			{
				[Token(Token = "0x40004FA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40004FB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x600066B")]
				[Address(RVA = "0xAB220C", Offset = "0xAB220C", VA = "0xAB220C")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The range for the character's position and rotation.")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The range for the character camera's position and rotation.")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Definitions of the interactions associated with this range.")]
			public Interaction[] interactions;

			[Token(Token = "0x6000669")]
			[Address(RVA = "0xAB13BC", Offset = "0xAB13BC", VA = "0xAB13BC")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0xAB21FC", Offset = "0xAB21FC", VA = "0xAB21FC")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xAB10B4", Offset = "0xAB10B4", VA = "0xAB10B4")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xAB10F8", Offset = "0xAB10F8", VA = "0xAB10F8")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xAB113C", Offset = "0xAB113C", VA = "0xAB113C")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xAB1180", Offset = "0xAB1180", VA = "0xAB1180")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xAB11C4", Offset = "0xAB11C4", VA = "0xAB11C4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xAB1208", Offset = "0xAB1208", VA = "0xAB1208")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xAB146C", Offset = "0xAB146C", VA = "0xAB146C")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000AF")]
		public class Map
		{
			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000673")]
			[Address(RVA = "0xAB2500", Offset = "0xAB2500", VA = "0xAB2500")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0xAB283C", Offset = "0xAB283C", VA = "0xAB283C")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0xAB27FC", Offset = "0xAB27FC", VA = "0xAB27FC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0xAB2680", Offset = "0xAB2680", VA = "0xAB2680")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xAB2214", Offset = "0xAB2214", VA = "0xAB2214", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xAB258C", Offset = "0xAB258C", VA = "0xAB258C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xAB2590", Offset = "0xAB2590", VA = "0xAB2590", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xAB27A0", Offset = "0xAB27A0", VA = "0xAB27A0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xAB2530", Offset = "0xAB2530", VA = "0xAB2530")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xAB246C", Offset = "0xAB246C", VA = "0xAB246C")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xAB2880", Offset = "0xAB2880", VA = "0xAB2880")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xAB28A0", Offset = "0xAB28A0", VA = "0xAB28A0", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xAB295C", Offset = "0xAB295C", VA = "0xAB295C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xAB2B00", Offset = "0xAB2B00", VA = "0xAB2B00", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xAB2BE8", Offset = "0xAB2BE8", VA = "0xAB2BE8", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xAB29B0", Offset = "0xAB29B0", VA = "0xAB29B0")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xAB2F18", Offset = "0xAB2F18", VA = "0xAB2F18")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float localRotationWeight;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float localPositionWeight;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x600067D")]
		public abstract void AutoMapping();

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xAB2F28", Offset = "0xAB2F28", VA = "0xAB2F28")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x600067F")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000680")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000681")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xAB2F34", Offset = "0xAB2F34", VA = "0xAB2F34", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xAB2F78", Offset = "0xAB2F78", VA = "0xAB2F78", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xAB2FA4", Offset = "0xAB2FA4", VA = "0xAB2FA4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xAB2890", Offset = "0xAB2890", VA = "0xAB2890")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000B3")]
		public class Rigidbone
		{
			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000698")]
			[Address(RVA = "0xAB3564", Offset = "0xAB3564", VA = "0xAB3564")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0xAB40AC", Offset = "0xAB40AC", VA = "0xAB40AC")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0xAB3E6C", Offset = "0xAB3E6C", VA = "0xAB3E6C")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000B4")]
		public class Child
		{
			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x600069B")]
			[Address(RVA = "0xAB36B8", Offset = "0xAB36B8", VA = "0xAB36B8")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0xAB41C4", Offset = "0xAB41C4", VA = "0xAB41C4")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0xAB4180", Offset = "0xAB4180", VA = "0xAB4180")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000B5")]
		[CompilerGenerated]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000E4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006A1")]
				[Address(RVA = "0xAB46C8", Offset = "0xAB46C8", VA = "0xAB46C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006A3")]
				[Address(RVA = "0xAB4710", Offset = "0xAB4710", VA = "0xAB4710", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0xAB3714", Offset = "0xAB3714", VA = "0xAB3714")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0xAB44E4", Offset = "0xAB44E4", VA = "0xAB44E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0xAB44E8", Offset = "0xAB44E8", VA = "0xAB44E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0xAB46D0", Offset = "0xAB46D0", VA = "0xAB46D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x170000E2")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0xAB2FE8", Offset = "0xAB2FE8", VA = "0xAB2FE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E3")]
		private bool ikUsed
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0xAB3AA0", Offset = "0xAB3AA0", VA = "0xAB3AA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xAB2FBC", Offset = "0xAB2FBC", VA = "0xAB2FBC")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xAB304C", Offset = "0xAB304C", VA = "0xAB304C")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xAB3158", Offset = "0xAB3158", VA = "0xAB3158")]
		public void Start()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xAB30F0", Offset = "0xAB30F0", VA = "0xAB30F0")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xAB373C", Offset = "0xAB373C", VA = "0xAB373C")]
		private void Update()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xAB3964", Offset = "0xAB3964", VA = "0xAB3964")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xAB3A04", Offset = "0xAB3A04", VA = "0xAB3A04")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xAB3BF4", Offset = "0xAB3BF4", VA = "0xAB3BF4")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xAB3A74", Offset = "0xAB3A74", VA = "0xAB3A74")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xAB3BC0", Offset = "0xAB3BC0", VA = "0xAB3BC0")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xAB3C74", Offset = "0xAB3C74", VA = "0xAB3C74")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xAB3C18", Offset = "0xAB3C18", VA = "0xAB3C18")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xAB3094", Offset = "0xAB3094", VA = "0xAB3094")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xAB3998", Offset = "0xAB3998", VA = "0xAB3998")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xAB42D4", Offset = "0xAB42D4", VA = "0xAB42D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xAB43EC", Offset = "0xAB43EC", VA = "0xAB43EC")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x170000E6")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0xAB4B7C", Offset = "0xAB4B7C", VA = "0xAB4B7C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000E7")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0xAB4B88", Offset = "0xAB4B88", VA = "0xAB4B88")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000E8")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0xAB4BB8", Offset = "0xAB4BB8", VA = "0xAB4BB8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0xAB4BC0", Offset = "0xAB4BC0", VA = "0xAB4BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xAB4718", Offset = "0xAB4718", VA = "0xAB4718")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xAB4754", Offset = "0xAB4754", VA = "0xAB4754")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xAB476C", Offset = "0xAB476C", VA = "0xAB476C")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xAB4AEC", Offset = "0xAB4AEC", VA = "0xAB4AEC")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xAB4B50", Offset = "0xAB4B50", VA = "0xAB4B50")]
		public void Disable()
		{
		}

		[Token(Token = "0x60006AD")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xAB49F0", Offset = "0xAB49F0", VA = "0xAB49F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xAB4BCC", Offset = "0xAB4BCC", VA = "0xAB4BCC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xAB4BD0", Offset = "0xAB4BD0", VA = "0xAB4BD0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xAB4BF8", Offset = "0xAB4BF8", VA = "0xAB4BF8")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xAB4CCC", Offset = "0xAB4CCC", VA = "0xAB4CCC")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xAB4F24", Offset = "0xAB4F24", VA = "0xAB4F24")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xAB5078", Offset = "0xAB5078", VA = "0xAB5078")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float limit;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xAB50D8", Offset = "0xAB50D8", VA = "0xAB50D8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xAB511C", Offset = "0xAB511C", VA = "0xAB511C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xAB5160", Offset = "0xAB5160", VA = "0xAB5160")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xAB51A4", Offset = "0xAB51A4", VA = "0xAB51A4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xAB51E8", Offset = "0xAB51E8", VA = "0xAB51E8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xAB5220", Offset = "0xAB5220", VA = "0xAB5220")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xAB5544", Offset = "0xAB5544", VA = "0xAB5544")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xAB5554", Offset = "0xAB5554", VA = "0xAB5554")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xAB5598", Offset = "0xAB5598", VA = "0xAB5598")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xAB55DC", Offset = "0xAB55DC", VA = "0xAB55DC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xAB5620", Offset = "0xAB5620", VA = "0xAB5620")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xAB5664", Offset = "0xAB5664", VA = "0xAB5664", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xAB5668", Offset = "0xAB5668", VA = "0xAB5668")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xAB5888", Offset = "0xAB5888", VA = "0xAB5888")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000BA")]
		public class ReachCone
		{
			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000E9")]
			public Vector3 o
			{
				[Token(Token = "0x60006D3")]
				[Address(RVA = "0xAB75D0", Offset = "0xAB75D0", VA = "0xAB75D0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000EA")]
			public Vector3 a
			{
				[Token(Token = "0x60006D4")]
				[Address(RVA = "0xAB75FC", Offset = "0xAB75FC", VA = "0xAB75FC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000EB")]
			public Vector3 b
			{
				[Token(Token = "0x60006D5")]
				[Address(RVA = "0xAB762C", Offset = "0xAB762C", VA = "0xAB762C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000EC")]
			public Vector3 c
			{
				[Token(Token = "0x60006D6")]
				[Address(RVA = "0xAB765C", Offset = "0xAB765C", VA = "0xAB765C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000ED")]
			public bool isValid
			{
				[Token(Token = "0x60006D8")]
				[Address(RVA = "0xAB6B18", Offset = "0xAB6B18", VA = "0xAB6B18")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0xAB6FBC", Offset = "0xAB6FBC", VA = "0xAB6FBC")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0xAB7120", Offset = "0xAB7120", VA = "0xAB7120")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BB")]
		public class LimitPoint
		{
			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0xAB6B28", Offset = "0xAB6B28", VA = "0xAB6B28")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 3f)]
		public int smoothIterations;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xAB58A0", Offset = "0xAB58A0", VA = "0xAB58A0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xAB58E4", Offset = "0xAB58E4", VA = "0xAB58E4")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xAB5928", Offset = "0xAB5928", VA = "0xAB5928")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xAB596C", Offset = "0xAB596C", VA = "0xAB596C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xAB59B0", Offset = "0xAB59B0", VA = "0xAB59B0")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xAB5FE8", Offset = "0xAB5FE8", VA = "0xAB5FE8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xAB6070", Offset = "0xAB6070", VA = "0xAB6070")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xAB6650", Offset = "0xAB6650", VA = "0xAB6650")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xAB5A3C", Offset = "0xAB5A3C", VA = "0xAB5A3C")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xAB6B8C", Offset = "0xAB6B8C", VA = "0xAB6B8C")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xAB7394", Offset = "0xAB7394", VA = "0xAB7394")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xAB73DC", Offset = "0xAB73DC", VA = "0xAB73DC")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xAB743C", Offset = "0xAB743C", VA = "0xAB743C")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xAB63AC", Offset = "0xAB63AC", VA = "0xAB63AC")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xAB74A8", Offset = "0xAB74A8", VA = "0xAB74A8")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xAB7574", Offset = "0xAB7574", VA = "0xAB7574")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xAB768C", Offset = "0xAB768C", VA = "0xAB768C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xAB76D0", Offset = "0xAB76D0", VA = "0xAB76D0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xAB7714", Offset = "0xAB7714", VA = "0xAB7714")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xAB7758", Offset = "0xAB7758", VA = "0xAB7758")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xAB779C", Offset = "0xAB779C", VA = "0xAB779C")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xAB77B8", Offset = "0xAB77B8", VA = "0xAB77B8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xAB77F0", Offset = "0xAB77F0", VA = "0xAB77F0")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xAB7B9C", Offset = "0xAB7B9C", VA = "0xAB7B9C")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000BE")]
		[CompilerGenerated]
		private sealed class <TurnToTarget>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x170000EF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006ED")]
				[Address(RVA = "0xAB8B7C", Offset = "0xAB8B7C", VA = "0xAB8B7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006EF")]
				[Address(RVA = "0xAB8BC4", Offset = "0xAB8BC4", VA = "0xAB8BC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006EA")]
			[Address(RVA = "0xAB8988", Offset = "0xAB8988", VA = "0xAB8988")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0xAB8A94", Offset = "0xAB8A94", VA = "0xAB8A94", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0xAB8A98", Offset = "0xAB8A98", VA = "0xAB8A98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0xAB8B84", Offset = "0xAB8B84", VA = "0xAB8B84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Master weight of the IK solver.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Target Smoothing")]
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		public Transform target;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Smoothing time for turning towards the yaw and pitch of the target using Mathf.SmoothDampAngle. Value of 0 means smooth damping is disabled.")]
		public float smoothDampTime;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("RootRotation")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		[Range(0f, 180f)]
		public float maxRootAngle;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If enabled, aligns the root forward to target direction after 'Max Root Angle' has been exceeded.")]
		public bool turnToTarget;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The time of turning towards the target direction if 'Max Root Angle has been exceeded and 'Turn To Target' is enabled.")]
		public float turnToTargetTime;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		[Header("Mode")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform lastTarget;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float switchWeight;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float switchWeightV;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float weightV;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 lastPosition;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 dir;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		private bool turningToTarget;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float turnToTargetMlpV;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float yawV;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float pitchV;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float dirMagV;

		[Token(Token = "0x170000EE")]
		private Vector3 pivot
		{
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0xAB7C24", Offset = "0xAB7C24", VA = "0xAB7C24")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xAB7BA8", Offset = "0xAB7BA8", VA = "0xAB7BA8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xAB7CA8", Offset = "0xAB7CA8", VA = "0xAB7CA8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xAB84F8", Offset = "0xAB84F8", VA = "0xAB84F8")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xAB867C", Offset = "0xAB867C", VA = "0xAB867C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xAB8920", Offset = "0xAB8920", VA = "0xAB8920")]
		[IteratorStateMachine(typeof(<TurnToTarget>d__37))]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xAB89B0", Offset = "0xAB89B0", VA = "0xAB89B0")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C0")]
		public class Pose
		{
			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0xAB8C9C", Offset = "0xAB8C9C", VA = "0xAB8C9C")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0xAB920C", Offset = "0xAB920C", VA = "0xAB920C")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0xAB9214", Offset = "0xAB9214", VA = "0xAB9214")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xAB8BCC", Offset = "0xAB8BCC", VA = "0xAB8BCC")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xAB914C", Offset = "0xAB914C", VA = "0xAB914C")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xAB91AC", Offset = "0xAB91AC", VA = "0xAB91AC")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C2")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000C3")]
			public class EffectorLink
			{
				[Token(Token = "0x400057A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400057B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x60006FB")]
				[Address(RVA = "0xAB96D8", Offset = "0xAB96D8", VA = "0xAB96D8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0xAB9380", Offset = "0xAB9380", VA = "0xAB9380")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0xAB96B0", Offset = "0xAB96B0", VA = "0xAB96B0")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0xAB96C0", Offset = "0xAB96C0", VA = "0xAB96C0")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xAB9230", Offset = "0xAB9230", VA = "0xAB9230", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xAB9690", Offset = "0xAB9690", VA = "0xAB9690")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Speed of tilting")]
		public float tiltSpeed;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xAB96E0", Offset = "0xAB96E0", VA = "0xAB96E0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xAB9748", Offset = "0xAB9748", VA = "0xAB9748", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xAB99E8", Offset = "0xAB99E8", VA = "0xAB99E8")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class CCDBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CCDIK ik;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xAB9A04", Offset = "0xAB9A04", VA = "0xAB9A04")]
		private void Start()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xAB9AD4", Offset = "0xAB9AD4", VA = "0xAB9AD4")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xAB9D68", Offset = "0xAB9D68", VA = "0xAB9D68")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xAB9E74", Offset = "0xAB9E74", VA = "0xAB9E74")]
		public CCDBendGoal()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If slot assigned, will update Animator before IK.")]
		public Animator animator;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Create/Final IK/Editor IK Pose")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x170000F1")]
		public IK ik
		{
			[Token(Token = "0x6000703")]
			[Address(RVA = "0xAB9E84", Offset = "0xAB9E84", VA = "0xAB9E84")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000704")]
			[Address(RVA = "0xAB9E8C", Offset = "0xAB9E8C", VA = "0xAB9E8C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xAB9E94", Offset = "0xAB9E94", VA = "0xAB9E94")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xABA008", Offset = "0xABA008", VA = "0xABA008")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xABA264", Offset = "0xABA264", VA = "0xABA264")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xABA390", Offset = "0xABA390", VA = "0xABA390")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xABA544", Offset = "0xABA544", VA = "0xABA544")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xABA748", Offset = "0xABA748", VA = "0xABA748")]
		public void Update()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xABA9BC", Offset = "0xABA9BC", VA = "0xABA9BC")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	[CreateAssetMenu(fileName = "Editor IK Pose", menuName = "Final IK/Editor IK Pose", order = 1)]
	public class EditorIKPose : ScriptableObject
	{
		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] localPositions;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Quaternion[] localRotations;

		[Token(Token = "0x170000F2")]
		public bool poseStored
		{
			[Token(Token = "0x600070C")]
			[Address(RVA = "0xABA0E4", Offset = "0xABA0E4", VA = "0xABA0E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xABA404", Offset = "0xABA404", VA = "0xABA404")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xABA108", Offset = "0xABA108", VA = "0xABA108")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xABAA14", Offset = "0xABAA14", VA = "0xABAA14")]
		public EditorIKPose()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C9")]
		public abstract class HitPoint
		{
			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000F4")]
			public bool inProgress
			{
				[Token(Token = "0x6000714")]
				[Address(RVA = "0xABAB34", Offset = "0xABAB34", VA = "0xABAB34")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000F5")]
			protected float crossFader
			{
				[Token(Token = "0x6000715")]
				[Address(RVA = "0xABB034", Offset = "0xABB034", VA = "0xABB034")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000716")]
				[Address(RVA = "0xABB03C", Offset = "0xABB03C", VA = "0xABB03C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000F6")]
			protected float timer
			{
				[Token(Token = "0x6000717")]
				[Address(RVA = "0xABB044", Offset = "0xABB044", VA = "0xABB044")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000718")]
				[Address(RVA = "0xABB04C", Offset = "0xABB04C", VA = "0xABB04C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000F7")]
			protected Vector3 force
			{
				[Token(Token = "0x6000719")]
				[Address(RVA = "0xABB054", Offset = "0xABB054", VA = "0xABB054")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600071A")]
				[Address(RVA = "0xABB060", Offset = "0xABB060", VA = "0xABB060")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000F8")]
			protected Vector3 point
			{
				[Token(Token = "0x600071B")]
				[Address(RVA = "0xABB06C", Offset = "0xABB06C", VA = "0xABB06C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600071C")]
				[Address(RVA = "0xABB078", Offset = "0xABB078", VA = "0xABB078")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0xABAEFC", Offset = "0xABAEFC", VA = "0xABAEFC")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x600071E")]
			[Address(RVA = "0xABAC08", Offset = "0xABAC08", VA = "0xABAC08")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600071F")]
			protected abstract float GetLength();

			[Token(Token = "0x6000720")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000721")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000722")]
			[Address(RVA = "0xABB084", Offset = "0xABB084", VA = "0xABB084")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CA")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000CB")]
			public class EffectorLink
			{
				[Token(Token = "0x4000599")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400059A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x400059B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400059C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000727")]
				[Address(RVA = "0xABB3B8", Offset = "0xABB3B8", VA = "0xABB3B8")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000728")]
				[Address(RVA = "0xABB214", Offset = "0xABB214", VA = "0xABB214")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000729")]
				[Address(RVA = "0xABB468", Offset = "0xABB468", VA = "0xABB468")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000723")]
			[Address(RVA = "0xABB098", Offset = "0xABB098", VA = "0xABB098", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000724")]
			[Address(RVA = "0xABB1B4", Offset = "0xABB1B4", VA = "0xABB1B4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0xABB228", Offset = "0xABB228", VA = "0xABB228", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000726")]
			[Address(RVA = "0xABB454", Offset = "0xABB454", VA = "0xABB454")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CC")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000CD")]
			public class BoneLink
			{
				[Token(Token = "0x40005A0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				[Token(Token = "0x40005A1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Token(Token = "0x40005A2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x40005A3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x600072E")]
				[Address(RVA = "0xABB728", Offset = "0xABB728", VA = "0xABB728")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600072F")]
				[Address(RVA = "0xABB554", Offset = "0xABB554", VA = "0xABB554")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000730")]
				[Address(RVA = "0xABB8C8", Offset = "0xABB8C8", VA = "0xABB8C8")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600072A")]
			[Address(RVA = "0xABB470", Offset = "0xABB470", VA = "0xABB470", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0xABB4FC", Offset = "0xABB4FC", VA = "0xABB4FC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0xABB560", Offset = "0xABB560", VA = "0xABB560", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600072D")]
			[Address(RVA = "0xABB8B4", Offset = "0xABB8B4", VA = "0xABB8B4")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000F3")]
		public bool inProgress
		{
			[Token(Token = "0x6000710")]
			[Address(RVA = "0xABAA98", Offset = "0xABAA98", VA = "0xABAA98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xABAB48", Offset = "0xABAB48", VA = "0xABAB48", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xABACE0", Offset = "0xABACE0", VA = "0xABACE0")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xABB024", Offset = "0xABB024", VA = "0xABB024")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000CF")]
		public abstract class Offset
		{
			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000F9")]
			protected float crossFader
			{
				[Token(Token = "0x6000734")]
				[Address(RVA = "0xABBE38", Offset = "0xABBE38", VA = "0xABBE38")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000735")]
				[Address(RVA = "0xABBE40", Offset = "0xABBE40", VA = "0xABBE40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000FA")]
			protected float timer
			{
				[Token(Token = "0x6000736")]
				[Address(RVA = "0xABBE48", Offset = "0xABBE48", VA = "0xABBE48")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000737")]
				[Address(RVA = "0xABBE50", Offset = "0xABBE50", VA = "0xABBE50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000FB")]
			protected Vector3 force
			{
				[Token(Token = "0x6000738")]
				[Address(RVA = "0xABBE58", Offset = "0xABBE58", VA = "0xABBE58")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000739")]
				[Address(RVA = "0xABBE64", Offset = "0xABBE64", VA = "0xABBE64")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000FC")]
			protected Vector3 point
			{
				[Token(Token = "0x600073A")]
				[Address(RVA = "0xABBE70", Offset = "0xABBE70", VA = "0xABBE70")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600073B")]
				[Address(RVA = "0xABBE7C", Offset = "0xABBE7C", VA = "0xABBE7C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600073C")]
			[Address(RVA = "0xABBCE8", Offset = "0xABBCE8", VA = "0xABBCE8")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0xABB9E4", Offset = "0xABB9E4", VA = "0xABB9E4")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600073E")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x600073F")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000740")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000741")]
			[Address(RVA = "0xABBE88", Offset = "0xABBE88", VA = "0xABBE88")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D0")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000D1")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x40005B4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x40005B5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x40005B6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40005B7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000746")]
				[Address(RVA = "0xABC26C", Offset = "0xABC26C", VA = "0xABC26C")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000747")]
				[Address(RVA = "0xABC090", Offset = "0xABC090", VA = "0xABC090")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000748")]
				[Address(RVA = "0xABC300", Offset = "0xABC300", VA = "0xABC300")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000742")]
			[Address(RVA = "0xABBE9C", Offset = "0xABBE9C", VA = "0xABBE9C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0xABC030", Offset = "0xABC030", VA = "0xABC030", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000744")]
			[Address(RVA = "0xABC0A4", Offset = "0xABC0A4", VA = "0xABC0A4", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000745")]
			[Address(RVA = "0xABC2E4", Offset = "0xABC2E4", VA = "0xABC2E4")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D2")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000D3")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x40005BB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x40005BC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Token(Token = "0x40005BD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x40005BE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x600074D")]
				[Address(RVA = "0xABC6C0", Offset = "0xABC6C0", VA = "0xABC6C0")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600074E")]
				[Address(RVA = "0xABC438", Offset = "0xABC438", VA = "0xABC438")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600074F")]
				[Address(RVA = "0xABC7DC", Offset = "0xABC7DC", VA = "0xABC7DC")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public int curveIndex;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000749")]
			[Address(RVA = "0xABC308", Offset = "0xABC308", VA = "0xABC308", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600074A")]
			[Address(RVA = "0xABC3E0", Offset = "0xABC3E0", VA = "0xABC3E0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600074B")]
			[Address(RVA = "0xABC444", Offset = "0xABC444", VA = "0xABC444", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600074C")]
			[Address(RVA = "0xABC7C8", Offset = "0xABC7C8", VA = "0xABC7C8")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xABB92C", Offset = "0xABB92C", VA = "0xABB92C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xABBAC4", Offset = "0xABBAC4", VA = "0xABBAC4")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xABBE18", Offset = "0xABBE18", VA = "0xABBE18")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000D5")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000D6")]
			public class EffectorLink
			{
				[Token(Token = "0x40005CC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005CD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000756")]
				[Address(RVA = "0xABCDA4", Offset = "0xABCDA4", VA = "0xABCDA4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The speed to follow the Transform")]
			public float speed;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Matching target velocity")]
			[Range(0f, 1f)]
			public float matchVelocity;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("gravity applied to the Body")]
			public float gravity;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000753")]
			[Address(RVA = "0xABC8AC", Offset = "0xABC8AC", VA = "0xABC8AC")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000754")]
			[Address(RVA = "0xABCA2C", Offset = "0xABCA2C", VA = "0xABCA2C")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000755")]
			[Address(RVA = "0xABCD88", Offset = "0xABCD88", VA = "0xABCD88")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The array of Bodies")]
		public Body[] bodies;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xABC840", Offset = "0xABC840", VA = "0xABC840")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xABC988", Offset = "0xABC988", VA = "0xABC988", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xABCD78", Offset = "0xABCD78", VA = "0xABCD78")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The target to look at. Do not use the Target transform that is assigned to LookAtIK. Set to null if you wish to stop looking.")]
		[Header("Target Smoothing")]
		public Transform target;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The time it takes to blend in/out of LookAtIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The position of the pivot that the look at target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Minimum distance of looking from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the look direction.")]
		[Range(0f, 180f)]
		[Header("RootRotation")]
		public float maxRootAngle;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000FD")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0xABCE14", Offset = "0xABCE14", VA = "0xABCE14")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xABCDAC", Offset = "0xABCDAC", VA = "0xABCDAC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xABCE98", Offset = "0xABCE98", VA = "0xABCE98")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xABD398", Offset = "0xABD398", VA = "0xABD398")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xABD51C", Offset = "0xABD51C", VA = "0xABD51C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xABD768", Offset = "0xABD768", VA = "0xABD768")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D9")]
		public class OffsetLimits
		{
			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("The limits")]
			public float minX;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The limits")]
			public float maxX;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The limits")]
			public float minY;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The limits")]
			public float maxY;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The limits")]
			public float minZ;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The limits")]
			public float maxZ;

			[Token(Token = "0x6000765")]
			[Address(RVA = "0xABD964", Offset = "0xABD964", VA = "0xABD964")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0xABDBD4", Offset = "0xABDBD4", VA = "0xABDBD4")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000767")]
			[Address(RVA = "0xABDC44", Offset = "0xABDC44", VA = "0xABDC44")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0xABDC8C", Offset = "0xABDC8C", VA = "0xABDC8C")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000DA")]
		[CompilerGenerated]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000FF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600076C")]
				[Address(RVA = "0xABDDE8", Offset = "0xABDDE8", VA = "0xABDDE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000100")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600076E")]
				[Address(RVA = "0xABDE30", Offset = "0xABDE30", VA = "0xABDE30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000769")]
			[Address(RVA = "0xABD868", Offset = "0xABD868", VA = "0xABD868")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0xABDC94", Offset = "0xABDC94", VA = "0xABDC94", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600076B")]
			[Address(RVA = "0xABDC98", Offset = "0xABDC98", VA = "0xABDC98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600076D")]
			[Address(RVA = "0xABDDF0", Offset = "0xABDDF0", VA = "0xABDDF0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000FE")]
		protected float deltaTime
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0xAB9360", Offset = "0xAB9360", VA = "0xAB9360")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600075E")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xAB9728", Offset = "0xAB9728", VA = "0xAB9728", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xABD800", Offset = "0xABD800", VA = "0xABD800")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xABD890", Offset = "0xABD890", VA = "0xABD890")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xABCCD0", Offset = "0xABCCD0", VA = "0xABCCD0")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xABDAC8", Offset = "0xABDAC8", VA = "0xABDAC8", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xAB96A0", Offset = "0xAB96A0", VA = "0xAB96A0")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000DC")]
		[CompilerGenerated]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x17000102")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000779")]
				[Address(RVA = "0xABE23C", Offset = "0xABE23C", VA = "0xABE23C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000103")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600077B")]
				[Address(RVA = "0xABE284", Offset = "0xABE284", VA = "0xABE284", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000776")]
			[Address(RVA = "0xABDEE0", Offset = "0xABDEE0", VA = "0xABDEE0")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0xABE0E8", Offset = "0xABE0E8", VA = "0xABE0E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000778")]
			[Address(RVA = "0xABE0EC", Offset = "0xABE0EC", VA = "0xABE0EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600077A")]
			[Address(RVA = "0xABE244", Offset = "0xABE244", VA = "0xABE244", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x17000101")]
		protected float deltaTime
		{
			[Token(Token = "0x600076F")]
			[Address(RVA = "0xABDE38", Offset = "0xABDE38", VA = "0xABDE38")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000770")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xABDE58", Offset = "0xABDE58", VA = "0xABDE58", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xABDE78", Offset = "0xABDE78", VA = "0xABDE78")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xABDF08", Offset = "0xABDF08", VA = "0xABDF08")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xABDFDC", Offset = "0xABDFDC", VA = "0xABDFDC", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xABBE28", Offset = "0xABBE28", VA = "0xABBE28")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000DE")]
		public class EffectorLink
		{
			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x600077F")]
			[Address(RVA = "0xABE28C", Offset = "0xABE28C", VA = "0xABE28C")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000780")]
			[Address(RVA = "0xABE5D8", Offset = "0xABE5D8", VA = "0xABE5D8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xAB9934", Offset = "0xAB9934", VA = "0xAB9934")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xABE4DC", Offset = "0xABE4DC", VA = "0xABE4DC")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xABE580", Offset = "0xABE580", VA = "0xABE580")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E0")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20000E1")]
			public class EffectorLink
			{
				[Token(Token = "0x4000609")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Effector to apply the offset to.")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400060A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Multiplier of the offset value, can be negative.")]
				public float weight;

				[Token(Token = "0x6000787")]
				[Address(RVA = "0xABEC2C", Offset = "0xABEC2C", VA = "0xABEC2C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Bones to start the raycast from. Multiple raycasts can be used by assigning more than 1 bone.")]
			public Transform[] raycastFrom;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Transform to raycast towards. Usually the body part that you want to keep from penetrating.")]
			public Transform raycastTo;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Range(0f, 1f)]
			[Tooltip("If 0, will use simple raycasting, if > 0, will use sphere casting (better, but slower).")]
			public float raycastRadius;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this to FBBIK effectors.")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The time of smooth interpolation of the offset value to avoid penetration.")]
			public float smoothTimeIn;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The time of smooth interpolation of the offset value blending out of penetration avoidance.")]
			public float smoothTimeOut;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Layers to keep penetrating from.")]
			public LayerMask layers;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x6000783")]
			[Address(RVA = "0xABE650", Offset = "0xABE650", VA = "0xABE650")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000784")]
			[Address(RVA = "0xABE7F0", Offset = "0xABE7F0", VA = "0xABE7F0")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000785")]
			[Address(RVA = "0xABE8F8", Offset = "0xABE8F8", VA = "0xABE8F8")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000786")]
			[Address(RVA = "0xABEC18", Offset = "0xABEC18", VA = "0xABEC18")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders;

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xABE5E0", Offset = "0xABE5E0", VA = "0xABE5E0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xABE7E0", Offset = "0xABE7E0", VA = "0xABE7E0")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E3")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20000E4")]
			public class EffectorLink
			{
				[Token(Token = "0x4000628")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000629")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000797")]
				[Address(RVA = "0xABFF80", Offset = "0xABFF80", VA = "0xABFF80")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(0f, 1f)]
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			public float additivity;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000794")]
			[Address(RVA = "0xABEDD0", Offset = "0xABEDD0", VA = "0xABEDD0")]
			public void Start()
			{
			}

			[Token(Token = "0x6000795")]
			[Address(RVA = "0xABF92C", Offset = "0xABF92C", VA = "0xABF92C")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0xABFF6C", Offset = "0xABFF6C", VA = "0xABFF6C")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E5")]
		public enum Handedness
		{
			[Token(Token = "0x400062B")]
			Right,
			[Token(Token = "0x400062C")]
			Left
		}

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Which hand is holding the weapon?")]
		public Handedness handedness;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Space(10f)]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x17000104")]
		public bool isFinished
		{
			[Token(Token = "0x6000788")]
			[Address(RVA = "0xABEC34", Offset = "0xABEC34", VA = "0xABEC34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000105")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x600078E")]
			[Address(RVA = "0xABFB30", Offset = "0xABFB30", VA = "0xABFB30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000106")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x600078F")]
			[Address(RVA = "0xABFB6C", Offset = "0xABFB6C", VA = "0xABFB6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000107")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000790")]
			[Address(RVA = "0xABFAF8", Offset = "0xABFAF8", VA = "0xABFAF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000108")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000791")]
			[Address(RVA = "0xABFB14", Offset = "0xABFB14", VA = "0xABFB14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xABEC58", Offset = "0xABEC58", VA = "0xABEC58")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xABEC84", Offset = "0xABEC84", VA = "0xABEC84")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xABEEA4", Offset = "0xABEEA4", VA = "0xABEEA4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xABFBA8", Offset = "0xABFBA8", VA = "0xABFBA8")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0xABFCC0", Offset = "0xABFCC0", VA = "0xABFCC0")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xABFD10", Offset = "0xABFD10", VA = "0xABFD10", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xABFEE0", Offset = "0xABFEE0", VA = "0xABFEE0")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Weight of shoulder rotation")]
		public float weight;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xABFF88", Offset = "0xABFF88", VA = "0xABFF88")]
		private void Start()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xAC0078", Offset = "0xAC0078", VA = "0xAC0078")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xAC0154", Offset = "0xAC0154", VA = "0xAC0154")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xAC0558", Offset = "0xAC0558", VA = "0xAC0558")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xAC058C", Offset = "0xAC058C", VA = "0xAC058C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xAC0698", Offset = "0xAC0698", VA = "0xAC0698")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000E8")]
		public class Settings
		{
			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Multiplies character scale")]
			public float scaleMlp;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Local axis of the HMD facing forward.")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Local axis of the HMD facing up.")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Local axis of the hand trackers pointing from the wrist towards the palm.")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Local axis of the hand trackers pointing in the direction of the surface normal of the back of the hand.")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("Local axis of the foot trackers towards the player's forward direction.")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Local axis of the foot tracker towards the up direction.")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Space(10f)]
			[Tooltip("Offset of the head bone from the HMD in (headTrackerForward, headTrackerUp) space relative to the head tracker.")]
			public Vector3 headOffset;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("Offset of the hand bones from the hand trackers in (handTrackerForward, handTrackerUp) space relative to the hand trackers.")]
			public Vector3 handOffset;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Forward offset of the foot bones from the foot trackers.")]
			public float footForwardOffset;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Inward offset of the foot bones from the foot trackers.")]
			public float footInwardOffset;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Range(-180f, 180f)]
			[Tooltip("Used for adjusting foot heading relative to the foot trackers.")]
			public float footHeadingOffset;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Token(Token = "0x60007AD")]
			[Address(RVA = "0xAC40E4", Offset = "0xAC40E4", VA = "0xAC40E4")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E9")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20000EA")]
			public class Target
			{
				[Token(Token = "0x400064B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x400064C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x400064D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x60007AF")]
				[Address(RVA = "0xAC4280", Offset = "0xAC4280", VA = "0xAC4280")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x60007B0")]
				[Address(RVA = "0xAC4334", Offset = "0xAC4334", VA = "0xAC4334")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60007AE")]
			[Address(RVA = "0xAC4278", Offset = "0xAC4278", VA = "0xAC4278")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xAC06AC", Offset = "0xAC06AC", VA = "0xAC06AC")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xAC06C4", Offset = "0xAC06C4", VA = "0xAC06C4")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xAC07EC", Offset = "0xAC07EC", VA = "0xAC07EC")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xAC070C", Offset = "0xAC070C", VA = "0xAC070C")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xAC0804", Offset = "0xAC0804", VA = "0xAC0804")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xAC1A64", Offset = "0xAC1A64", VA = "0xAC1A64")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xAC211C", Offset = "0xAC211C", VA = "0xAC211C")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xAC2A2C", Offset = "0xAC2A2C", VA = "0xAC2A2C")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xAC2C9C", Offset = "0xAC2C9C", VA = "0xAC2C9C")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xAC2EB8", Offset = "0xAC2EB8", VA = "0xAC2EB8")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xAC3678", Offset = "0xAC3678", VA = "0xAC3678")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xAC3440", Offset = "0xAC3440", VA = "0xAC3440")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xAC3920", Offset = "0xAC3920", VA = "0xAC3920")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xAC3CB8", Offset = "0xAC3CB8", VA = "0xAC3CB8")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xAC3D9C", Offset = "0xAC3D9C", VA = "0xAC3D9C")]
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000EB")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xAC4390", Offset = "0xAC4390", VA = "0xAC4390")]
		private void Start()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xAC43E0", Offset = "0xAC43E0", VA = "0xAC43E0")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xAC4408", Offset = "0xAC4408", VA = "0xAC4408")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xAC4528", Offset = "0xAC4528", VA = "0xAC4528")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x17000109")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x60007B5")]
			[Address(RVA = "0xAC4540", Offset = "0xAC4540", VA = "0xAC4540")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007B6")]
			[Address(RVA = "0xAC454C", Offset = "0xAC454C", VA = "0xAC454C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xAC4558", Offset = "0xAC4558", VA = "0xAC4558")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xAC464C", Offset = "0xAC464C", VA = "0xAC464C")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xAC480C", Offset = "0xAC480C", VA = "0xAC480C")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xAC4964", Offset = "0xAC4964", VA = "0xAC4964")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xAC4D2C", Offset = "0xAC4D2C", VA = "0xAC4D2C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xAC4E38", Offset = "0xAC4E38", VA = "0xAC4E38")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x20000ED")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000EE")]
		public class Offset
		{
			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x60007C1")]
			[Address(RVA = "0xAC4EF4", Offset = "0xAC4EF4", VA = "0xAC4EF4")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0xAC515C", Offset = "0xAC515C", VA = "0xAC515C")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xAC4E40", Offset = "0xAC4E40", VA = "0xAC4E40")]
		private void Start()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xAC4E90", Offset = "0xAC4E90", VA = "0xAC4E90")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xAC509C", Offset = "0xAC509C", VA = "0xAC509C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xAC5154", Offset = "0xAC5154", VA = "0xAC5154")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xAC5164", Offset = "0xAC5164", VA = "0xAC5164")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xAC51E4", Offset = "0xAC51E4", VA = "0xAC51E4")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The direction of the animated weapon swing in character space. Tweak this value to adjust the aiming.")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xAC51EC", Offset = "0xAC51EC", VA = "0xAC51EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xAC5258", Offset = "0xAC5258", VA = "0xAC5258")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xAC52B8", Offset = "0xAC52B8", VA = "0xAC52B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xAC52F0", Offset = "0xAC52F0", VA = "0xAC52F0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xAC55AC", Offset = "0xAC55AC", VA = "0xAC55AC")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("AimPoser is a tool that returns an animation name based on direction.")]
		public AimPoser aimPoser;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK aim;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Reference to the LookAt component (only used for the head in this instance).")]
		public LookAtIK lookAt;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component.")]
		public Animator animator;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Time of cross-fading from pose to pose.")]
		public float crossfadeTime;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Will keep the aim target at a distance.")]
		public float minAimDistance;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xAC55B4", Offset = "0xAC55B4", VA = "0xAC55B4")]
		private void Start()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xAC55EC", Offset = "0xAC55EC", VA = "0xAC55EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xAC5738", Offset = "0xAC5738", VA = "0xAC5738")]
		private void Pose()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xAC58A8", Offset = "0xAC58A8", VA = "0xAC58A8")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xAC5A8C", Offset = "0xAC5A8C", VA = "0xAC5A8C")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xAC5B1C", Offset = "0xAC5B1C", VA = "0xAC5B1C")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xAC5B30", Offset = "0xAC5B30", VA = "0xAC5B30")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xAC5C9C", Offset = "0xAC5C9C", VA = "0xAC5C9C")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xAC5E98", Offset = "0xAC5E98", VA = "0xAC5E98")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[LargeHeader("References")]
		public Animator animator;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[LargeHeader("Look At")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float lookAtWeight;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float lookAtBodyWeight;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float lookAtHeadWeight;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float lookAtEyesWeight;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float lookAtClampWeight;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[LargeHeader("Foot")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float footPositionWeight;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[LargeHeader("Hand")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float handPositionWeight;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float handRotationWeight;

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xAC5EC8", Offset = "0xAC5EC8", VA = "0xAC5EC8")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xAC62F4", Offset = "0xAC62F4", VA = "0xAC62F4")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 lastPosition;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sine;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit rootHit;

		[Token(Token = "0x1700010A")]
		public Vector3 velocity
		{
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0xAC6314", Offset = "0xAC6314", VA = "0xAC6314")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0xAC6320", Offset = "0xAC6320", VA = "0xAC6320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xAC632C", Offset = "0xAC632C", VA = "0xAC632C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xAC635C", Offset = "0xAC635C", VA = "0xAC635C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xAC6CE0", Offset = "0xAC6CE0", VA = "0xAC6CE0")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xAC6A5C", Offset = "0xAC6A5C", VA = "0xAC6A5C")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xAC6DF0", Offset = "0xAC6DF0", VA = "0xAC6DF0")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x1700010B")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60007DC")]
			[Address(RVA = "0xAC6E1C", Offset = "0xAC6E1C", VA = "0xAC6E1C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xAC6E9C", Offset = "0xAC6E9C", VA = "0xAC6E9C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xAC71E0", Offset = "0xAC71E0", VA = "0xAC71E0")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000F8")]
		[CompilerGenerated]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x1700010E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007ED")]
				[Address(RVA = "0xAC81E8", Offset = "0xAC81E8", VA = "0xAC81E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007EF")]
				[Address(RVA = "0xAC8230", Offset = "0xAC8230", VA = "0xAC8230", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007EA")]
			[Address(RVA = "0xAC7E8C", Offset = "0xAC7E8C", VA = "0xAC7E8C")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0xAC7F44", Offset = "0xAC7F44", VA = "0xAC7F44", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0xAC7F48", Offset = "0xAC7F48", VA = "0xAC7F48", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0xAC81F0", Offset = "0xAC81F0", VA = "0xAC81F0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x1700010C")]
		public bool isStepping
		{
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0xAC71F4", Offset = "0xAC71F4", VA = "0xAC71F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010D")]
		public Vector3 position
		{
			[Token(Token = "0x60007E0")]
			[Address(RVA = "0xAC6DC0", Offset = "0xAC6DC0", VA = "0xAC6DC0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007E1")]
			[Address(RVA = "0xAC7208", Offset = "0xAC7208", VA = "0xAC7208")]
			set
			{
			}
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xAC7254", Offset = "0xAC7254", VA = "0xAC7254")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xAC749C", Offset = "0xAC749C", VA = "0xAC749C")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xAC7674", Offset = "0xAC7674", VA = "0xAC7674")]
		private void Start()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xAC788C", Offset = "0xAC788C", VA = "0xAC788C")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xAC7AEC", Offset = "0xAC7AEC", VA = "0xAC7AEC")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xAC7C54", Offset = "0xAC7C54", VA = "0xAC7C54")]
		private void Update()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xAC77E8", Offset = "0xAC77E8", VA = "0xAC77E8")]
		[IteratorStateMachine(typeof(<Step>d__33))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xAC7EB4", Offset = "0xAC7EB4", VA = "0xAC7EB4")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xAC8238", Offset = "0xAC8238", VA = "0xAC8238")]
		private void Start()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xAC8304", Offset = "0xAC8304", VA = "0xAC8304")]
		private void Update()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xAC8578", Offset = "0xAC8578", VA = "0xAC8578")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000FB")]
		public struct Warp
		{
			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Layer of the 'Animation State' in the Animator.")]
			public int animationLayer;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Name of the state in the Animator to warp.")]
			public string animationState;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Warping weight by normalized time of the animation state.")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Animated point to warp from. This should be in character space so keep this Transform parented to the root of the character.")]
			public Transform warpFrom;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("World space point to warp to.")]
			public Transform warpTo;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Which FBBIK effector to use?")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000FC")]
		public enum EffectorMode
		{
			[Token(Token = "0x40006CA")]
			PositionOffset,
			[Token(Token = "0x40006CB")]
			Position
		}

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component to use")]
		public Animator animator;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Using effector.positionOffset or effector.position with effector.positionWeight? The former will enable you to use effector.position for other things, the latter will weigh in the effectors, hence using Reach and Pull in the process.")]
		public EffectorMode effectorMode;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The array of warps, can have multiple simultaneous warps.")]
		[Space(10f)]
		public Warp[] warps;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xAC8580", Offset = "0xAC8580", VA = "0xAC8580", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xAC85A0", Offset = "0xAC85A0", VA = "0xAC85A0")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xAC87B8", Offset = "0xAC87B8", VA = "0xAC87B8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xAC8A70", Offset = "0xAC8A70", VA = "0xAC8A70")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xAC8B04", Offset = "0xAC8B04", VA = "0xAC8B04")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xAC8B0C", Offset = "0xAC8B0C", VA = "0xAC8B0C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xAC8B5C", Offset = "0xAC8B5C", VA = "0xAC8B5C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xAC8D64", Offset = "0xAC8D64", VA = "0xAC8D64", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xAC8F8C", Offset = "0xAC8F8C", VA = "0xAC8F8C")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float headLookWeight;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xAC8FA0", Offset = "0xAC8FA0", VA = "0xAC8FA0", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xAC9134", Offset = "0xAC9134", VA = "0xAC9134", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xAC91A4", Offset = "0xAC91A4", VA = "0xAC91A4")]
		private void Read()
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xAC92DC", Offset = "0xAC92DC", VA = "0xAC92DC")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xAC9338", Offset = "0xAC9338", VA = "0xAC9338")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xAC9980", Offset = "0xAC9980", VA = "0xAC9980")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xAC9794", Offset = "0xAC9794", VA = "0xAC9794")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xAC9C24", Offset = "0xAC9C24", VA = "0xAC9C24")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xAC9D30", Offset = "0xAC9D30", VA = "0xAC9D30")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xAC9D4C", Offset = "0xAC9D4C", VA = "0xAC9D4C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xAC9DA8", Offset = "0xAC9DA8", VA = "0xAC9DA8", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xACA0FC", Offset = "0xACA0FC", VA = "0xACA0FC")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xACA1EC", Offset = "0xACA1EC", VA = "0xACA1EC")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x17000110")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x600080B")]
			[Address(RVA = "0xACA44C", Offset = "0xACA44C", VA = "0xACA44C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000111")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x600080C")]
			[Address(RVA = "0xACA4CC", Offset = "0xACA4CC", VA = "0xACA4CC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xACA1F4", Offset = "0xACA1F4", VA = "0xACA1F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xACA25C", Offset = "0xACA25C", VA = "0xACA25C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xACA54C", Offset = "0xACA54C", VA = "0xACA54C")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xACA554", Offset = "0xACA554", VA = "0xACA554", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xACA9B0", Offset = "0xACA9B0", VA = "0xACA9B0")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xACA9B8", Offset = "0xACA9B8", VA = "0xACA9B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xACAA5C", Offset = "0xACAA5C", VA = "0xACAA5C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xACAEB8", Offset = "0xACAEB8", VA = "0xACAEB8")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xACAF58", Offset = "0xACAF58", VA = "0xACAF58")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000104")]
		public class Limb
		{
			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x6000818")]
			[Address(RVA = "0xACB0EC", Offset = "0xACB0EC", VA = "0xACB0EC")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000819")]
			[Address(RVA = "0xACB210", Offset = "0xACB210", VA = "0xACB210")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xACAFC8", Offset = "0xACAFC8", VA = "0xACAFC8")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xACB164", Offset = "0xACB164", VA = "0xACB164")]
		private void Start()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xACB1FC", Offset = "0xACB1FC", VA = "0xACB1FC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xACB200", Offset = "0xACB200", VA = "0xACB200")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xACB220", Offset = "0xACB220", VA = "0xACB220")]
		private void Start()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xACB288", Offset = "0xACB288", VA = "0xACB288")]
		private void Update()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xACB350", Offset = "0xACB350", VA = "0xACB350")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The target we want to hit")]
		public Transform target;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The pin Transform is used to reference the exact hit point in the animation (used by AimIK to aim the upper body to follow the target).In Legacy and Generic modes you can just create and position a reference point in your animating software and include it in the FBX. Then in Unity if you added a GameObject with the exact same name under the character's root, it would be animated to the required position.In Humanoid mode however, Mecanim loses track of any Transform that does not belong to the avatar, so in this case the pin point has to be manually set inside the Unity Editor.")]
		public Transform pin;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The Full Body Biped IK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The Aim IK component. Aim IK is ust used for following the target slightly with the body.")]
		public AimIK aim;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The effector type of the punching hand")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Weight of aiming the body to follow the target")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xACB358", Offset = "0xACB358", VA = "0xACB358")]
		private void Start()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xACB3A8", Offset = "0xACB3A8", VA = "0xACB3A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xACB540", Offset = "0xACB540", VA = "0xACB540")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xACB548", Offset = "0xACB548", VA = "0xACB548")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xACB618", Offset = "0xACB618", VA = "0xACB618")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xACB6A4", Offset = "0xACB6A4", VA = "0xACB6A4")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xACBB78", Offset = "0xACBB78", VA = "0xACBB78")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xACBC84", Offset = "0xACBC84", VA = "0xACBC84")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float aimWeight;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float sightWeight;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 180f)]
		public float maxAngle;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AimIK headAim;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CameraControllerFPS cam;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Recoil recoil;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		public float cameraRecoilWeight;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool updateFrame;

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xACBC8C", Offset = "0xACBC8C", VA = "0xACBC8C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xACBE28", Offset = "0xACBE28", VA = "0xACBE28")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xACBE34", Offset = "0xACBE34", VA = "0xACBE34")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xACC0F4", Offset = "0xACC0F4", VA = "0xACC0F4")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xACC398", Offset = "0xACC398", VA = "0xACC398")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xACBEF8", Offset = "0xACBEF8", VA = "0xACBEF8")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xACD050", Offset = "0xACD050", VA = "0xACD050")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float walkSpeed;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xACD070", Offset = "0xACD070", VA = "0xACD070")]
		private void Start()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xACD0EC", Offset = "0xACD0EC", VA = "0xACD0EC")]
		private void Update()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xACD1E8", Offset = "0xACD1E8", VA = "0xACD1E8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xACD294", Offset = "0xACD294", VA = "0xACD294")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xACD2A4", Offset = "0xACD2A4", VA = "0xACD2A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xACD3E8", Offset = "0xACD3E8", VA = "0xACD3E8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xACD54C", Offset = "0xACD54C", VA = "0xACD54C")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xACD55C", Offset = "0xACD55C", VA = "0xACD55C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xACD728", Offset = "0xACD728", VA = "0xACD728")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xACDB38", Offset = "0xACDB38", VA = "0xACDB38")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xACDB48", Offset = "0xACDB48", VA = "0xACDB48")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xACDC30", Offset = "0xACDC30", VA = "0xACDC30")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xACDD1C", Offset = "0xACDD1C", VA = "0xACDD1C")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xACDD24", Offset = "0xACDD24", VA = "0xACDD24")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xACE224", Offset = "0xACE224", VA = "0xACE224")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The object to interact to")]
		public InteractionObject interactionObject;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The effectors to interact with")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xACE22C", Offset = "0xACE22C", VA = "0xACE22C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xACE27C", Offset = "0xACE27C", VA = "0xACE27C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xACE528", Offset = "0xACE528", VA = "0xACE528")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000110")]
		public class Partner
		{
			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x17000112")]
			private Transform neck
			{
				[Token(Token = "0x6000843")]
				[Address(RVA = "0xACED34", Offset = "0xACED34", VA = "0xACED34")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000841")]
			[Address(RVA = "0xACE558", Offset = "0xACE558", VA = "0xACE558")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000842")]
			[Address(RVA = "0xACE5D4", Offset = "0xACE5D4", VA = "0xACE5D4")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000844")]
			[Address(RVA = "0xACEBCC", Offset = "0xACEBCC", VA = "0xACEBCC")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x6000845")]
			[Address(RVA = "0xACED80", Offset = "0xACED80", VA = "0xACED80")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xACE530", Offset = "0xACE530", VA = "0xACE530")]
		private void Start()
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0xACE578", Offset = "0xACE578", VA = "0xACE578")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xACEBBC", Offset = "0xACEBBC", VA = "0xACEBBC")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000112")]
		public enum Mode
		{
			[Token(Token = "0x4000757")]
			Position,
			[Token(Token = "0x4000758")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x2000113")]
		public class Absorber
		{
			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of effector (hand, foot, shoulder...) - this is just an enum")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("How much should motion be absorbed on this effector")]
			public float weight;

			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x600084C")]
			[Address(RVA = "0xACEEF8", Offset = "0xACEEF8", VA = "0xACEEF8")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x600084D")]
			[Address(RVA = "0xACF0CC", Offset = "0xACF0CC", VA = "0xACF0CC")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x600084E")]
			[Address(RVA = "0xACF0F0", Offset = "0xACF0F0", VA = "0xACF0F0")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x600084F")]
			[Address(RVA = "0xACF200", Offset = "0xACF200", VA = "0xACF200")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000850")]
			[Address(RVA = "0xACF398", Offset = "0xACF398", VA = "0xACF398")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Use either effector position, position weight, rotation, rotationWeight or positionOffset and rotating the bone directly.")]
		public Mode mode;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Array containing the absorbers")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Weight falloff curve (how fast will the effect reduce after impact)")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("How fast will the impact fade away. (if 1, effect lasts for 1 second)")]
		public float falloffSpeed;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xACED94", Offset = "0xACED94", VA = "0xACED94", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xACEE78", Offset = "0xACEE78", VA = "0xACEE78")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xACEFC0", Offset = "0xACEFC0", VA = "0xACEFC0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xACF184", Offset = "0xACF184", VA = "0xACF184")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xACF270", Offset = "0xACF270", VA = "0xACF270", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xACF388", Offset = "0xACF388", VA = "0xACF388")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xACF3F8", Offset = "0xACF3F8", VA = "0xACF3F8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xACF468", Offset = "0xACF468", VA = "0xACF468")]
		private void Update()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xACF538", Offset = "0xACF538", VA = "0xACF538")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xACF680", Offset = "0xACF680", VA = "0xACF680")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000116")]
		public class EffectorLink
		{
			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000858")]
			[Address(RVA = "0xACF900", Offset = "0xACF900", VA = "0xACF900")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xACF694", Offset = "0xACF694", VA = "0xACF694", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xACF780", Offset = "0xACF780", VA = "0xACF780", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xACF8F8", Offset = "0xACF8F8", VA = "0xACF8F8")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		[Tooltip("The master weight of this script.")]
		public float weight;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Multiplier for the distance of the root to the target.")]
		public float hangingDistanceMlp;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Where does the root of the character land when weight is blended out?")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		[Tooltip("How is the root of the character rotated when weight is blended out?")]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xACF910", Offset = "0xACF910", VA = "0xACF910")]
		private void Start()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xACFC10", Offset = "0xACFC10", VA = "0xACFC10")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xAD040C", Offset = "0xAD040C", VA = "0xAD040C")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x17000113")]
		private bool holding
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0xAD0804", Offset = "0xAD0804", VA = "0xAD0804")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000114")]
		private bool holdingLeft
		{
			[Token(Token = "0x6000864")]
			[Address(RVA = "0xAD08D4", Offset = "0xAD08D4", VA = "0xAD08D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000115")]
		private bool holdingRight
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0xAD082C", Offset = "0xAD082C", VA = "0xAD082C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xAD0478", Offset = "0xAD0478", VA = "0xAD0478")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600085D")]
		protected abstract void RotatePivot();

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xAD097C", Offset = "0xAD097C", VA = "0xAD097C")]
		private void Start()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xAD0B3C", Offset = "0xAD0B3C", VA = "0xAD0B3C")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xAD0CAC", Offset = "0xAD0CAC", VA = "0xAD0CAC")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xAD0D7C", Offset = "0xAD0D7C", VA = "0xAD0D7C")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xAD0EA8", Offset = "0xAD0EA8", VA = "0xAD0EA8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xAD1028", Offset = "0xAD1028", VA = "0xAD1028")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xAD1224", Offset = "0xAD1224", VA = "0xAD1224")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x6000868")]
		[Address(RVA = "0xAD1238", Offset = "0xAD1238", VA = "0xAD1238", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0xAD1418", Offset = "0xAD1418", VA = "0xAD1418")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x600086A")]
		[Address(RVA = "0xAD142C", Offset = "0xAD142C", VA = "0xAD142C", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xAD1540", Offset = "0xAD1540", VA = "0xAD1540")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xAD1554", Offset = "0xAD1554", VA = "0xAD1554")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xAD15EC", Offset = "0xAD15EC", VA = "0xAD15EC")]
		private void Update()
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xAD1704", Offset = "0xAD1704", VA = "0xAD1704")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xAD170C", Offset = "0xAD170C", VA = "0xAD170C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xAD175C", Offset = "0xAD175C", VA = "0xAD175C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xAD17A8", Offset = "0xAD17A8", VA = "0xAD17A8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xAD1840", Offset = "0xAD1840", VA = "0xAD1840")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x200011E")]
		[CompilerGenerated]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x17000116")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600087A")]
				[Address(RVA = "0xAD1B80", Offset = "0xAD1B80", VA = "0xAD1B80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000117")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600087C")]
				[Address(RVA = "0xAD1BC8", Offset = "0xAD1BC8", VA = "0xAD1BC8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000877")]
			[Address(RVA = "0xAD19B4", Offset = "0xAD19B4", VA = "0xAD19B4")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000878")]
			[Address(RVA = "0xAD19EC", Offset = "0xAD19EC", VA = "0xAD19EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000879")]
			[Address(RVA = "0xAD19F0", Offset = "0xAD19F0", VA = "0xAD19F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600087B")]
			[Address(RVA = "0xAD1B88", Offset = "0xAD1B88", VA = "0xAD1B88", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xAD1850", Offset = "0xAD1850", VA = "0xAD1850")]
		private void Start()
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xAD1900", Offset = "0xAD1900", VA = "0xAD1900")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xAD193C", Offset = "0xAD193C", VA = "0xAD193C")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xAD19DC", Offset = "0xAD19DC", VA = "0xAD19DC")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000120")]
		[CompilerGenerated]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x17000118")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000883")]
				[Address(RVA = "0xAD1E3C", Offset = "0xAD1E3C", VA = "0xAD1E3C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000119")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000885")]
				[Address(RVA = "0xAD1E84", Offset = "0xAD1E84", VA = "0xAD1E84", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000880")]
			[Address(RVA = "0xAD1CE0", Offset = "0xAD1CE0", VA = "0xAD1CE0")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000881")]
			[Address(RVA = "0xAD1D10", Offset = "0xAD1D10", VA = "0xAD1D10", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000882")]
			[Address(RVA = "0xAD1D14", Offset = "0xAD1D14", VA = "0xAD1D14", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000884")]
			[Address(RVA = "0xAD1E44", Offset = "0xAD1E44", VA = "0xAD1E44", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x600087D")]
		[Address(RVA = "0xAD1BD0", Offset = "0xAD1BD0", VA = "0xAD1BD0")]
		private void Start()
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0xAD1C78", Offset = "0xAD1C78", VA = "0xAD1C78")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0xAD1D08", Offset = "0xAD1D08", VA = "0xAD1D08")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000122")]
		public class EffectorLink
		{
			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float distanceMlp;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public LayerMask touchLayers;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float lerpSpeed;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float minSwitchTime;

			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float releaseDistance;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool sliding;

			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float raycastDistance;

			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private bool inTouch;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private RaycastHit hit;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Vector3 targetPosition;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private Quaternion targetRotation;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private bool initiated;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float nextSwitchTime;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float speedF;

			[Token(Token = "0x600088A")]
			[Address(RVA = "0xAD1EF0", Offset = "0xAD1EF0", VA = "0xAD1EF0")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600088B")]
			[Address(RVA = "0xAD2A2C", Offset = "0xAD2A2C", VA = "0xAD2A2C")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x600088C")]
			[Address(RVA = "0xAD22B4", Offset = "0xAD22B4", VA = "0xAD22B4")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600088D")]
			[Address(RVA = "0xAD2B14", Offset = "0xAD2B14", VA = "0xAD2B14")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600088E")]
			[Address(RVA = "0xAD2BF8", Offset = "0xAD2BF8", VA = "0xAD2BF8")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600088F")]
			[Address(RVA = "0xAD2C84", Offset = "0xAD2C84", VA = "0xAD2C84")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000890")]
			[Address(RVA = "0xAD2D0C", Offset = "0xAD2D0C", VA = "0xAD2D0C")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000891")]
			[Address(RVA = "0xAD286C", Offset = "0xAD286C", VA = "0xAD286C")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000892")]
			[Address(RVA = "0xAD2D94", Offset = "0xAD2D94", VA = "0xAD2D94")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xAD1E8C", Offset = "0xAD1E8C", VA = "0xAD1E8C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xAD2254", Offset = "0xAD2254", VA = "0xAD2254")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xAD27BC", Offset = "0xAD27BC", VA = "0xAD27BC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xAD2A24", Offset = "0xAD2A24", VA = "0xAD2A24")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Transform to transfer motion to.")]
		public Transform to;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The amount of motion to transfer.")]
		[Range(0f, 1f)]
		public float transferMotion;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xAD2DD0", Offset = "0xAD2DD0", VA = "0xAD2DD0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xAD2E00", Offset = "0xAD2E00", VA = "0xAD2E00")]
		private void Update()
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xAD2EB0", Offset = "0xAD2EB0", VA = "0xAD2EB0")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The left hand target parented to the right hand.")]
		public Transform leftHandTarget;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xAD2EC4", Offset = "0xAD2EC4", VA = "0xAD2EC4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xAD30A8", Offset = "0xAD30A8", VA = "0xAD30A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xAD3344", Offset = "0xAD3344", VA = "0xAD3344")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0xAD340C", Offset = "0xAD340C", VA = "0xAD340C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xAD3518", Offset = "0xAD3518", VA = "0xAD3518")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x600089B")]
		[Address(RVA = "0xAD3520", Offset = "0xAD3520", VA = "0xAD3520", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xAD3638", Offset = "0xAD3638", VA = "0xAD3638")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xAD3800", Offset = "0xAD3800", VA = "0xAD3800")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x600089E")]
		[Address(RVA = "0xAD381C", Offset = "0xAD381C", VA = "0xAD381C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0xAD3A24", Offset = "0xAD3A24", VA = "0xAD3A24")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0xAD3A90", Offset = "0xAD3A90", VA = "0xAD3A90")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000128")]
		[CompilerGenerated]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x1700011A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008AA")]
				[Address(RVA = "0xAD41DC", Offset = "0xAD41DC", VA = "0xAD41DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008AC")]
				[Address(RVA = "0xAD4224", Offset = "0xAD4224", VA = "0xAD4224", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008A7")]
			[Address(RVA = "0xAD3E70", Offset = "0xAD3E70", VA = "0xAD3E70")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60008A8")]
			[Address(RVA = "0xAD4060", Offset = "0xAD4060", VA = "0xAD4060", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008A9")]
			[Address(RVA = "0xAD4064", Offset = "0xAD4064", VA = "0xAD4064", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008AB")]
			[Address(RVA = "0xAD41E4", Offset = "0xAD41E4", VA = "0xAD41E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0xAD3A98", Offset = "0xAD3A98", VA = "0xAD3A98")]
		private void Start()
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xAD3BBC", Offset = "0xAD3BBC", VA = "0xAD3BBC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0xAD3B54", Offset = "0xAD3B54", VA = "0xAD3B54")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0xAD3E98", Offset = "0xAD3E98", VA = "0xAD3E98")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0xAD3F70", Offset = "0xAD3F70", VA = "0xAD3F70")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xAD4044", Offset = "0xAD4044", VA = "0xAD4044")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xAD422C", Offset = "0xAD422C", VA = "0xAD422C")]
		private void Start()
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xAD4294", Offset = "0xAD4294", VA = "0xAD4294")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xAD4340", Offset = "0xAD4340", VA = "0xAD4340")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200012B")]
		public class Part
		{
			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x60008B2")]
			[Address(RVA = "0xAD43B4", Offset = "0xAD43B4", VA = "0xAD43B4")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x60008B3")]
			[Address(RVA = "0xAD44D4", Offset = "0xAD44D4", VA = "0xAD44D4")]
			public Part()
			{
			}
		}

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xAD4350", Offset = "0xAD4350", VA = "0xAD4350")]
		private void Update()
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xAD44CC", Offset = "0xAD44CC", VA = "0xAD44CC")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xAD44DC", Offset = "0xAD44DC", VA = "0xAD44DC")]
		private void Update()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xAD4620", Offset = "0xAD4620", VA = "0xAD4620")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xAD4784", Offset = "0xAD4784", VA = "0xAD4784")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class VRIKCalibrationBasic : MonoBehaviour
	{
		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The VRIK component.")]
		public VRIK ik;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Head")]
		[Tooltip("HMD.")]
		public Transform centerEyeAnchor;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Position offset of the camera from the head bone (root space).")]
		public Vector3 headAnchorPositionOffset;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Rotation offset of the camera from the head bone (root space).")]
		public Vector3 headAnchorRotationOffset;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Hands")]
		[Tooltip("Left Hand Controller")]
		public Transform leftHandAnchor;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Right Hand Controller")]
		public Transform rightHandAnchor;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Position offset of the hand controller from the hand bone (controller space).")]
		public Vector3 handAnchorPositionOffset;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Rotation offset of the hand controller from the hand bone (controller space).")]
		public Vector3 handAnchorRotationOffset;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("Scale")]
		[Tooltip("Multiplies the scale of the root.")]
		public float scaleMlp;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xAD4794", Offset = "0xAD4794", VA = "0xAD4794")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xAD491C", Offset = "0xAD491C", VA = "0xAD491C")]
		public VRIKCalibrationBasic()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the VRIK component on the avatar.")]
		public VRIK ik;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The settings for VRIK calibration.")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The HMD.")]
		public Transform headTracker;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("(Optional) A tracker placed anywhere on the body of the player, preferrably close to the pelvis, on the belt area.")]
		public Transform bodyTracker;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's left hand.")]
		public Transform leftHandTracker;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's right hand.")]
		public Transform rightHandTracker;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's left leg.")]
		public Transform leftFootTracker;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's right leg.")]
		public Transform rightFootTracker;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xAD498C", Offset = "0xAD498C", VA = "0xAD498C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xAD4AE4", Offset = "0xAD4AE4", VA = "0xAD4AE4")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0xAD4B4C", Offset = "0xAD4B4C", VA = "0xAD4B4C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xAD4B9C", Offset = "0xAD4B9C", VA = "0xAD4B9C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0xAD4D74", Offset = "0xAD4D74", VA = "0xAD4D74")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x2000130")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0xAD4DCC", Offset = "0xAD4DCC", VA = "0xAD4DCC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0xAD52EC", Offset = "0xAD52EC", VA = "0xAD52EC")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x1700011C")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0xAD5368", Offset = "0xAD5368", VA = "0xAD5368", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0xAD5348", Offset = "0xAD5348", VA = "0xAD5348", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xAD5370", Offset = "0xAD5370", VA = "0xAD5370")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0xAD53D0", Offset = "0xAD53D0", VA = "0xAD53D0", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0xACA0EC", Offset = "0xACA0EC", VA = "0xACA0EC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0xAD57C0", Offset = "0xAD57C0", VA = "0xAD57C0", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0xAD5554", Offset = "0xAD5554", VA = "0xAD5554")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0xAD57D0", Offset = "0xAD57D0", VA = "0xAD57D0")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000132")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0xAD57E8", Offset = "0xAD57E8", VA = "0xAD57E8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0xAD5844", Offset = "0xAD5844", VA = "0xAD5844", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0xAD58D4", Offset = "0xAD58D4", VA = "0xAD58D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0xAD59F8", Offset = "0xAD59F8", VA = "0xAD59F8")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Range(0.1f, 3f)]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x4000803")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000804")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float jumpLeg;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastJump;

		[Token(Token = "0x1700011D")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0xAD5A9C", Offset = "0xAD5A9C", VA = "0xAD5A9C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0xAD5A00", Offset = "0xAD5A00", VA = "0xAD5A00", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0xAD5A80", Offset = "0xAD5A80", VA = "0xAD5A80", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0xAD5B90", Offset = "0xAD5B90", VA = "0xAD5B90", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0xAD5F84", Offset = "0xAD5F84", VA = "0xAD5F84")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xAD60AC", Offset = "0xAD60AC", VA = "0xAD60AC")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Base Parameters")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		public Transform gravityTarget;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		public float gravityMultiplier;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x4000812")]
		protected const float half = 0.5f;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60008D2")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0xAD60C0", Offset = "0xAD60C0", VA = "0xAD60C0")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0xAD62AC", Offset = "0xAD62AC", VA = "0xAD62AC", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0xAD645C", Offset = "0xAD645C", VA = "0xAD645C", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0xAD65FC", Offset = "0xAD65FC", VA = "0xAD65FC")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0xAD665C", Offset = "0xAD665C", VA = "0xAD665C")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0xAD67C0", Offset = "0xAD67C0", VA = "0xAD67C0")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0xAD69C4", Offset = "0xAD69C4", VA = "0xAD69C4")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0xAD69E8", Offset = "0xAD69E8", VA = "0xAD69E8")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0xAD6A0C", Offset = "0xAD6A0C", VA = "0xAD6A0C")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xAD6B58", Offset = "0xAD6B58", VA = "0xAD6B58")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x2000135")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x2000136")]
		public enum MoveMode
		{
			[Token(Token = "0x4000850")]
			Directional,
			[Token(Token = "0x4000851")]
			Strafe
		}

		[Token(Token = "0x2000137")]
		public struct AnimState
		{
			[Token(Token = "0x4000852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x4000856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x4000857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x4000858")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x2000138")]
		[CompilerGenerated]
		private sealed class <JumpSmooth>d__75 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000859")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400085A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400085B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x400085C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x400085D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x400085E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x1700011F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008F2")]
				[Address(RVA = "0xAD95B8", Offset = "0xAD95B8", VA = "0xAD95B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000120")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008F4")]
				[Address(RVA = "0xAD9600", Offset = "0xAD9600", VA = "0xAD9600", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008EF")]
			[Address(RVA = "0xAD9384", Offset = "0xAD9384", VA = "0xAD9384")]
			[DebuggerHidden]
			public <JumpSmooth>d__75(int <>1__state)
			{
			}

			[Token(Token = "0x60008F0")]
			[Address(RVA = "0xAD94C0", Offset = "0xAD94C0", VA = "0xAD94C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008F1")]
			[Address(RVA = "0xAD94C4", Offset = "0xAD94C4", VA = "0xAD94C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008F3")]
			[Address(RVA = "0xAD95C0", Offset = "0xAD95C0", VA = "0xAD95C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Movement")]
		public MoveMode moveMode;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Header("Rotation")]
		public bool lookInCameraDirection;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Header("Jumping and Falling")]
		public bool smoothJump;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Header("Wall Running")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[Header("Crouching")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool fixedFrame;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private float wallRunEndTime;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3 gravity;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float velocityY;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private bool doubleJumped;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		private bool jumpReleased;

		[Token(Token = "0x1700011E")]
		public bool onGround
		{
			[Token(Token = "0x60008DD")]
			[Address(RVA = "0xAD6B78", Offset = "0xAD6B78", VA = "0xAD6B78")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008DE")]
			[Address(RVA = "0xAD6B80", Offset = "0xAD6B80", VA = "0xAD6B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0xAD6B8C", Offset = "0xAD6B8C", VA = "0xAD6B8C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0xAD6D5C", Offset = "0xAD6D5C", VA = "0xAD6D5C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0xAD6DE0", Offset = "0xAD6DE0", VA = "0xAD6DE0", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xAD6EF4", Offset = "0xAD6EF4", VA = "0xAD6EF4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xAD7F1C", Offset = "0xAD7F1C", VA = "0xAD7F1C", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0xAD83AC", Offset = "0xAD83AC", VA = "0xAD83AC", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xAD75A8", Offset = "0xAD75A8", VA = "0xAD75A8")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0xAD8484", Offset = "0xAD8484", VA = "0xAD8484")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0xAD8B0C", Offset = "0xAD8B0C", VA = "0xAD8B0C")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xAD7FA8", Offset = "0xAD7FA8", VA = "0xAD7FA8")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0xAD8BFC", Offset = "0xAD8BFC", VA = "0xAD8BFC", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0xAD907C", Offset = "0xAD907C", VA = "0xAD907C")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0xAD91A4", Offset = "0xAD91A4", VA = "0xAD91A4", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0xAD92F8", Offset = "0xAD92F8", VA = "0xAD92F8")]
		[IteratorStateMachine(typeof(<JumpSmooth>d__75))]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0xAD79BC", Offset = "0xAD79BC", VA = "0xAD79BC")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0xAD93AC", Offset = "0xAD93AC", VA = "0xAD93AC")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000139")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200013A")]
		public enum RotationMode
		{
			[Token(Token = "0x400086D")]
			Smooth,
			[Token(Token = "0x400086E")]
			Linear
		}

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The component that updates the camera.")]
		public CameraController cameraController;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Acceleration of movement.")]
		public float accelerationTime;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Turning speed.")]
		public float turnTime;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		public bool walkByDefault;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Smooth or linear rotation.")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Procedural motion speed (if not using root motion).")]
		public float moveSpeed;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x17000121")]
		public bool isGrounded
		{
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0xAD9608", Offset = "0xAD9608", VA = "0xAD9608")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0xAD9610", Offset = "0xAD9610", VA = "0xAD9610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0xAD961C", Offset = "0xAD961C", VA = "0xAD961C")]
		private void Start()
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0xAD96B0", Offset = "0xAD96B0", VA = "0xAD96B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0xAD9CC8", Offset = "0xAD9CC8", VA = "0xAD9CC8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0xAD96F8", Offset = "0xAD96F8", VA = "0xAD96F8")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0xAD9A60", Offset = "0xAD9A60", VA = "0xAD9A60")]
		private void Move()
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0xAD9CF8", Offset = "0xAD9CF8", VA = "0xAD9CF8")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0xAD9D90", Offset = "0xAD9D90", VA = "0xAD9D90")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xAD9E10", Offset = "0xAD9E10", VA = "0xAD9E10")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x200013B")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0xAD9E38", Offset = "0xAD9E38", VA = "0xAD9E38", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0xAD9F54", Offset = "0xAD9F54", VA = "0xAD9F54", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0xADA5B8", Offset = "0xADA5B8", VA = "0xADA5B8")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0xADA7A4", Offset = "0xADA7A4", VA = "0xADA7A4")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x200013C")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x200013D")]
		public struct State
		{
			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x400087A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x400087B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x400087C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x6000903")]
		[Address(RVA = "0xAD9E74", Offset = "0xAD9E74", VA = "0xAD9E74", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0xADA7D0", Offset = "0xADA7D0", VA = "0xADA7D0", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0xADA7C0", Offset = "0xADA7C0", VA = "0xADA7C0")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x200013E")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x6000906")]
		[Address(RVA = "0xADAB14", Offset = "0xADAB14", VA = "0xADAB14")]
		private void Update()
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0xADAB4C", Offset = "0xADAB4C", VA = "0xADAB4C")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x200013F")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x6000908")]
		[Address(RVA = "0xADAB54", Offset = "0xADAB54", VA = "0xADAB54")]
		private void Update()
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0xADAB7C", Offset = "0xADAB7C", VA = "0xADAB7C")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0xADAC20", Offset = "0xADAC20", VA = "0xADAC20")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000140")]
	public class Navigator
	{
		[Token(Token = "0x2000141")]
		public enum State
		{
			[Token(Token = "0x4000890")]
			Idle,
			[Token(Token = "0x4000891")]
			Seeking,
			[Token(Token = "0x4000892")]
			OnPath
		}

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Should this Navigator be actively seeking a path.")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Increase this value if the character starts running in a circle, not able to reach the corner because of a too large turning radius.")]
		public float cornerRadius;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Recalculate path if target position has moved by this distance from the position it was at when the path was originally calculated")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Sample within this distance from sourcePosition.")]
		public float maxSampleDistance;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Interval of updating the path")]
		public float nextPathInterval;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x17000122")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x600090B")]
			[Address(RVA = "0xADAC34", Offset = "0xADAC34", VA = "0xADAC34")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600090C")]
			[Address(RVA = "0xADAC40", Offset = "0xADAC40", VA = "0xADAC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000123")]
		public State state
		{
			[Token(Token = "0x600090D")]
			[Address(RVA = "0xADAC4C", Offset = "0xADAC4C", VA = "0xADAC4C")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Token(Token = "0x600090E")]
			[Address(RVA = "0xADAC54", Offset = "0xADAC54", VA = "0xADAC54")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0xAD9EA0", Offset = "0xAD9EA0", VA = "0xAD9EA0")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0xADA174", Offset = "0xADA174", VA = "0xADA174")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0xADAD34", Offset = "0xADAD34", VA = "0xADAD34")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0xADAD98", Offset = "0xADAD98", VA = "0xADAD98")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xADAC5C", Offset = "0xADAC5C", VA = "0xADAC5C")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0xADACB8", Offset = "0xADACB8", VA = "0xADACB8")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0xADA5E0", Offset = "0xADA5E0", VA = "0xADA5E0")]
		public void Visualize()
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0xADAECC", Offset = "0xADAECC", VA = "0xADAECC")]
		public Navigator()
		{
		}
	}
}
namespace Discord
{
	[Token(Token = "0x2000142")]
	public class ActivityManager
	{
		[Token(Token = "0x2000143")]
		internal struct FFIEvents
		{
			[Token(Token = "0x2000144")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ActivityJoinHandler(IntPtr ptr, string secret);

			[Token(Token = "0x2000145")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ActivitySpectateHandler(IntPtr ptr, string secret);

			[Token(Token = "0x2000146")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ActivityJoinRequestHandler(IntPtr ptr, ref User user);

			[Token(Token = "0x2000147")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ActivityInviteHandler(IntPtr ptr, ActivityActionType type, ref User user, ref Activity activity);

			[Token(Token = "0x4000899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ActivityJoinHandler OnActivityJoin;

			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal ActivitySpectateHandler OnActivitySpectate;

			[Token(Token = "0x400089B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal ActivityJoinRequestHandler OnActivityJoinRequest;

			[Token(Token = "0x400089C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal ActivityInviteHandler OnActivityInvite;
		}

		[Token(Token = "0x2000148")]
		internal struct FFIMethods
		{
			[Token(Token = "0x2000149")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result RegisterCommandMethod(IntPtr methodsPtr, string command);

			[Token(Token = "0x200014A")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result RegisterSteamMethod(IntPtr methodsPtr, uint steamId);

			[Token(Token = "0x200014B")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void UpdateActivityCallback(IntPtr ptr, Result result);

			[Token(Token = "0x200014C")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void UpdateActivityMethod(IntPtr methodsPtr, ref Activity activity, IntPtr callbackData, UpdateActivityCallback callback);

			[Token(Token = "0x200014D")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ClearActivityCallback(IntPtr ptr, Result result);

			[Token(Token = "0x200014E")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ClearActivityMethod(IntPtr methodsPtr, IntPtr callbackData, ClearActivityCallback callback);

			[Token(Token = "0x200014F")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SendRequestReplyCallback(IntPtr ptr, Result result);

			[Token(Token = "0x2000150")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SendRequestReplyMethod(IntPtr methodsPtr, long userId, ActivityJoinRequestReply reply, IntPtr callbackData, SendRequestReplyCallback callback);

			[Token(Token = "0x2000151")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SendInviteCallback(IntPtr ptr, Result result);

			[Token(Token = "0x2000152")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SendInviteMethod(IntPtr methodsPtr, long userId, ActivityActionType type, string content, IntPtr callbackData, SendInviteCallback callback);

			[Token(Token = "0x2000153")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void AcceptInviteCallback(IntPtr ptr, Result result);

			[Token(Token = "0x2000154")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void AcceptInviteMethod(IntPtr methodsPtr, long userId, IntPtr callbackData, AcceptInviteCallback callback);

			[Token(Token = "0x400089D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal RegisterCommandMethod RegisterCommand;

			[Token(Token = "0x400089E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal RegisterSteamMethod RegisterSteam;

			[Token(Token = "0x400089F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal UpdateActivityMethod UpdateActivity;

			[Token(Token = "0x40008A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal ClearActivityMethod ClearActivity;

			[Token(Token = "0x40008A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal SendRequestReplyMethod SendRequestReply;

			[Token(Token = "0x40008A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal SendInviteMethod SendInvite;

			[Token(Token = "0x40008A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal AcceptInviteMethod AcceptInvite;
		}

		[Token(Token = "0x2000155")]
		public delegate void UpdateActivityHandler(Result result);

		[Token(Token = "0x2000156")]
		public delegate void ClearActivityHandler(Result result);

		[Token(Token = "0x2000157")]
		public delegate void SendRequestReplyHandler(Result result);

		[Token(Token = "0x2000158")]
		public delegate void SendInviteHandler(Result result);

		[Token(Token = "0x2000159")]
		public delegate void AcceptInviteHandler(Result result);

		[Token(Token = "0x200015A")]
		public delegate void ActivityJoinHandler(string secret);

		[Token(Token = "0x200015B")]
		public delegate void ActivitySpectateHandler(string secret);

		[Token(Token = "0x200015C")]
		public delegate void ActivityJoinRequestHandler(ref User user);

		[Token(Token = "0x200015D")]
		public delegate void ActivityInviteHandler(ActivityActionType type, ref User user, ref Activity activity);

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x17000124")]
		private FFIMethods Methods
		{
			[Token(Token = "0x6000918")]
			[Address(RVA = "0xADB654", Offset = "0xADB654", VA = "0xADB654")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000001")]
		public event ActivityJoinHandler OnActivityJoin
		{
			[Token(Token = "0x6000919")]
			[Address(RVA = "0xADB774", Offset = "0xADB774", VA = "0xADB774")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600091A")]
			[Address(RVA = "0xADB810", Offset = "0xADB810", VA = "0xADB810")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event ActivitySpectateHandler OnActivitySpectate
		{
			[Token(Token = "0x600091B")]
			[Address(RVA = "0xADB8AC", Offset = "0xADB8AC", VA = "0xADB8AC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600091C")]
			[Address(RVA = "0xADB948", Offset = "0xADB948", VA = "0xADB948")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event ActivityJoinRequestHandler OnActivityJoinRequest
		{
			[Token(Token = "0x600091D")]
			[Address(RVA = "0xADB9E4", Offset = "0xADB9E4", VA = "0xADB9E4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600091E")]
			[Address(RVA = "0xADBA80", Offset = "0xADBA80", VA = "0xADBA80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event ActivityInviteHandler OnActivityInvite
		{
			[Token(Token = "0x600091F")]
			[Address(RVA = "0xADBB1C", Offset = "0xADBB1C", VA = "0xADBB1C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000920")]
			[Address(RVA = "0xADBBB8", Offset = "0xADBBB8", VA = "0xADBBB8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0xADB5B4", Offset = "0xADB5B4", VA = "0xADB5B4")]
		public void RegisterCommand()
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0xADBC54", Offset = "0xADBC54", VA = "0xADBC54")]
		internal ActivityManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0xADBDCC", Offset = "0xADBDCC", VA = "0xADBDCC")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0xADB5BC", Offset = "0xADB5BC", VA = "0xADB5BC")]
		public void RegisterCommand(string command)
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0xADC29C", Offset = "0xADC29C", VA = "0xADC29C")]
		public void RegisterSteam(uint steamId)
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0xADAF30", Offset = "0xADAF30", VA = "0xADAF30")]
		[MonoPInvokeCallback]
		private static void UpdateActivityCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0xADC334", Offset = "0xADC334", VA = "0xADC334")]
		public void UpdateActivity(Activity activity, UpdateActivityHandler callback)
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xADAFDC", Offset = "0xADAFDC", VA = "0xADAFDC")]
		[MonoPInvokeCallback]
		private static void ClearActivityCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0xADC4DC", Offset = "0xADC4DC", VA = "0xADC4DC")]
		public void ClearActivity(ClearActivityHandler callback)
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0xADB088", Offset = "0xADB088", VA = "0xADB088")]
		[MonoPInvokeCallback]
		private static void SendRequestReplyCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0xADC67C", Offset = "0xADC67C", VA = "0xADC67C")]
		public void SendRequestReply(long userId, ActivityJoinRequestReply reply, SendRequestReplyHandler callback)
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0xADB134", Offset = "0xADB134", VA = "0xADB134")]
		[MonoPInvokeCallback]
		private static void SendInviteCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0xADC834", Offset = "0xADC834", VA = "0xADC834")]
		public void SendInvite(long userId, ActivityActionType type, string content, SendInviteHandler callback)
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0xADB1E0", Offset = "0xADB1E0", VA = "0xADB1E0")]
		[MonoPInvokeCallback]
		private static void AcceptInviteCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0xADC9F4", Offset = "0xADC9F4", VA = "0xADC9F4")]
		public void AcceptInvite(long userId, AcceptInviteHandler callback)
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0xADB28C", Offset = "0xADB28C", VA = "0xADB28C")]
		[MonoPInvokeCallback]
		private static void OnActivityJoinImpl(IntPtr ptr, string secret)
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0xADB350", Offset = "0xADB350", VA = "0xADB350")]
		[MonoPInvokeCallback]
		private static void OnActivitySpectateImpl(IntPtr ptr, string secret)
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0xADB414", Offset = "0xADB414", VA = "0xADB414")]
		[MonoPInvokeCallback]
		private static void OnActivityJoinRequestImpl(IntPtr ptr, ref User user)
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0xADB4D8", Offset = "0xADB4D8", VA = "0xADB4D8")]
		[MonoPInvokeCallback]
		private static void OnActivityInviteImpl(IntPtr ptr, ActivityActionType type, ref User user, ref Activity activity)
		{
		}
	}
	[Token(Token = "0x200015E")]
	internal static class Constants
	{
		[Token(Token = "0x40008A4")]
		public const string DllName = "discord_game_sdk";
	}
	[Token(Token = "0x200015F")]
	public enum Result
	{
		[Token(Token = "0x40008A6")]
		Ok,
		[Token(Token = "0x40008A7")]
		ServiceUnavailable,
		[Token(Token = "0x40008A8")]
		InvalidVersion,
		[Token(Token = "0x40008A9")]
		LockFailed,
		[Token(Token = "0x40008AA")]
		InternalError,
		[Token(Token = "0x40008AB")]
		InvalidPayload,
		[Token(Token = "0x40008AC")]
		InvalidCommand,
		[Token(Token = "0x40008AD")]
		InvalidPermissions,
		[Token(Token = "0x40008AE")]
		NotFetched,
		[Token(Token = "0x40008AF")]
		NotFound,
		[Token(Token = "0x40008B0")]
		Conflict,
		[Token(Token = "0x40008B1")]
		InvalidSecret,
		[Token(Token = "0x40008B2")]
		InvalidJoinSecret,
		[Token(Token = "0x40008B3")]
		NoEligibleActivity,
		[Token(Token = "0x40008B4")]
		InvalidInvite,
		[Token(Token = "0x40008B5")]
		NotAuthenticated,
		[Token(Token = "0x40008B6")]
		InvalidAccessToken,
		[Token(Token = "0x40008B7")]
		ApplicationMismatch,
		[Token(Token = "0x40008B8")]
		InvalidDataUrl,
		[Token(Token = "0x40008B9")]
		InvalidBase64,
		[Token(Token = "0x40008BA")]
		NotFiltered,
		[Token(Token = "0x40008BB")]
		LobbyFull,
		[Token(Token = "0x40008BC")]
		InvalidLobbySecret,
		[Token(Token = "0x40008BD")]
		InvalidFilename,
		[Token(Token = "0x40008BE")]
		InvalidFileSize,
		[Token(Token = "0x40008BF")]
		InvalidEntitlement,
		[Token(Token = "0x40008C0")]
		NotInstalled,
		[Token(Token = "0x40008C1")]
		NotRunning,
		[Token(Token = "0x40008C2")]
		InsufficientBuffer,
		[Token(Token = "0x40008C3")]
		PurchaseCanceled,
		[Token(Token = "0x40008C4")]
		InvalidGuild,
		[Token(Token = "0x40008C5")]
		InvalidEvent,
		[Token(Token = "0x40008C6")]
		InvalidChannel,
		[Token(Token = "0x40008C7")]
		InvalidOrigin,
		[Token(Token = "0x40008C8")]
		RateLimited,
		[Token(Token = "0x40008C9")]
		OAuth2Error,
		[Token(Token = "0x40008CA")]
		SelectChannelTimeout,
		[Token(Token = "0x40008CB")]
		GetGuildTimeout,
		[Token(Token = "0x40008CC")]
		SelectVoiceForceRequired,
		[Token(Token = "0x40008CD")]
		CaptureShortcutAlreadyListening,
		[Token(Token = "0x40008CE")]
		UnauthorizedForAchievement,
		[Token(Token = "0x40008CF")]
		InvalidGiftCode,
		[Token(Token = "0x40008D0")]
		PurchaseError,
		[Token(Token = "0x40008D1")]
		TransactionAborted
	}
	[Token(Token = "0x2000160")]
	public enum CreateFlags
	{
		[Token(Token = "0x40008D3")]
		Default,
		[Token(Token = "0x40008D4")]
		NoRequireDiscord
	}
	[Token(Token = "0x2000161")]
	public enum LogLevel
	{
		[Token(Token = "0x40008D6")]
		Error = 1,
		[Token(Token = "0x40008D7")]
		Warn,
		[Token(Token = "0x40008D8")]
		Info,
		[Token(Token = "0x40008D9")]
		Debug
	}
	[Token(Token = "0x2000162")]
	public enum UserFlag
	{
		[Token(Token = "0x40008DB")]
		Partner = 2,
		[Token(Token = "0x40008DC")]
		HypeSquadEvents = 4,
		[Token(Token = "0x40008DD")]
		HypeSquadHouse1 = 0x40,
		[Token(Token = "0x40008DE")]
		HypeSquadHouse2 = 0x80,
		[Token(Token = "0x40008DF")]
		HypeSquadHouse3 = 0x100
	}
	[Token(Token = "0x2000163")]
	public enum PremiumType
	{
		[Token(Token = "0x40008E1")]
		None,
		[Token(Token = "0x40008E2")]
		Tier1,
		[Token(Token = "0x40008E3")]
		Tier2
	}
	[Token(Token = "0x2000164")]
	public enum ImageType
	{
		[Token(Token = "0x40008E5")]
		User
	}
	[Token(Token = "0x2000165")]
	public enum ActivityType
	{
		[Token(Token = "0x40008E7")]
		Playing,
		[Token(Token = "0x40008E8")]
		Streaming,
		[Token(Token = "0x40008E9")]
		Listening,
		[Token(Token = "0x40008EA")]
		Watching
	}
	[Token(Token = "0x2000166")]
	public enum ActivityActionType
	{
		[Token(Token = "0x40008EC")]
		Join = 1,
		[Token(Token = "0x40008ED")]
		Spectate
	}
	[Token(Token = "0x2000167")]
	public enum ActivityJoinRequestReply
	{
		[Token(Token = "0x40008EF")]
		No,
		[Token(Token = "0x40008F0")]
		Yes,
		[Token(Token = "0x40008F1")]
		Ignore
	}
	[Token(Token = "0x2000168")]
	public enum Status
	{
		[Token(Token = "0x40008F3")]
		Offline,
		[Token(Token = "0x40008F4")]
		Online,
		[Token(Token = "0x40008F5")]
		Idle,
		[Token(Token = "0x40008F6")]
		DoNotDisturb
	}
	[Token(Token = "0x2000169")]
	public enum RelationshipType
	{
		[Token(Token = "0x40008F8")]
		None,
		[Token(Token = "0x40008F9")]
		Friend,
		[Token(Token = "0x40008FA")]
		Blocked,
		[Token(Token = "0x40008FB")]
		PendingIncoming,
		[Token(Token = "0x40008FC")]
		PendingOutgoing,
		[Token(Token = "0x40008FD")]
		Implicit
	}
	[Token(Token = "0x200016A")]
	public enum LobbyType
	{
		[Token(Token = "0x40008FF")]
		Private = 1,
		[Token(Token = "0x4000900")]
		Public
	}
	[Token(Token = "0x200016B")]
	public enum LobbySearchComparison
	{
		[Token(Token = "0x4000902")]
		LessThanOrEqual = -2,
		[Token(Token = "0x4000903")]
		LessThan,
		[Token(Token = "0x4000904")]
		Equal,
		[Token(Token = "0x4000905")]
		GreaterThan,
		[Token(Token = "0x4000906")]
		GreaterThanOrEqual,
		[Token(Token = "0x4000907")]
		NotEqual
	}
	[Token(Token = "0x200016C")]
	public enum LobbySearchCast
	{
		[Token(Token = "0x4000909")]
		String = 1,
		[Token(Token = "0x400090A")]
		Number
	}
	[Token(Token = "0x200016D")]
	public enum LobbySearchDistance
	{
		[Token(Token = "0x400090C")]
		Local,
		[Token(Token = "0x400090D")]
		Default,
		[Token(Token = "0x400090E")]
		Extended,
		[Token(Token = "0x400090F")]
		Global
	}
	[Token(Token = "0x200016E")]
	public enum EntitlementType
	{
		[Token(Token = "0x4000911")]
		Purchase = 1,
		[Token(Token = "0x4000912")]
		PremiumSubscription,
		[Token(Token = "0x4000913")]
		DeveloperGift,
		[Token(Token = "0x4000914")]
		TestModePurchase,
		[Token(Token = "0x4000915")]
		FreePurchase,
		[Token(Token = "0x4000916")]
		UserGift,
		[Token(Token = "0x4000917")]
		PremiumPurchase
	}
	[Token(Token = "0x200016F")]
	public enum SkuType
	{
		[Token(Token = "0x4000919")]
		Application = 1,
		[Token(Token = "0x400091A")]
		DLC,
		[Token(Token = "0x400091B")]
		Consumable,
		[Token(Token = "0x400091C")]
		Bundle
	}
	[Token(Token = "0x2000170")]
	public enum InputModeType
	{
		[Token(Token = "0x400091E")]
		VoiceActivity,
		[Token(Token = "0x400091F")]
		PushToTalk
	}
	[Token(Token = "0x2000171")]
	public struct User
	{
		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long Id;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Username;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Discriminator;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Avatar;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Bot;
	}
	[Token(Token = "0x2000172")]
	public struct OAuth2Token
	{
		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string AccessToken;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Scopes;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public long Expires;
	}
	[Token(Token = "0x2000173")]
	public struct ImageHandle
	{
		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ImageType Type;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long Id;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint Size;

		[Token(Token = "0x6000997")]
		[Address(RVA = "0xADEC18", Offset = "0xADEC18", VA = "0xADEC18")]
		public static ImageHandle User(long id)
		{
			return default(ImageHandle);
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0xADEC2C", Offset = "0xADEC2C", VA = "0xADEC2C")]
		public static ImageHandle User(long id, uint size)
		{
			return default(ImageHandle);
		}
	}
	[Token(Token = "0x2000174")]
	public struct ImageDimensions
	{
		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint Width;

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint Height;
	}
	[Token(Token = "0x2000175")]
	public struct ActivityTimestamps
	{
		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long Start;

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long End;
	}
	[Token(Token = "0x2000176")]
	public struct ActivityAssets
	{
		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string LargeImage;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string LargeText;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string SmallImage;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string SmallText;
	}
	[Token(Token = "0x2000177")]
	public struct PartySize
	{
		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int CurrentSize;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int MaxSize;
	}
	[Token(Token = "0x2000178")]
	public struct ActivityParty
	{
		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string Id;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PartySize Size;
	}
	[Token(Token = "0x2000179")]
	public struct ActivitySecrets
	{
		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string Match;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Join;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Spectate;
	}
	[Token(Token = "0x200017A")]
	public struct Activity
	{
		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ActivityType Type;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long ApplicationId;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string State;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Details;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ActivityTimestamps Timestamps;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ActivityAssets Assets;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ActivityParty Party;

		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public ActivitySecrets Secrets;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool Instance;
	}
	[Token(Token = "0x200017B")]
	public struct Presence
	{
		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Status Status;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Activity Activity;
	}
	[Token(Token = "0x200017C")]
	public struct Relationship
	{
		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public RelationshipType Type;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public User User;

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Presence Presence;
	}
	[Token(Token = "0x200017D")]
	public struct Lobby
	{
		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long Id;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public LobbyType Type;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public long OwnerId;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Secret;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint Capacity;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool Locked;
	}
	[Token(Token = "0x200017E")]
	public struct FileStat
	{
		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string Filename;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong Size;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ulong LastModified;
	}
	[Token(Token = "0x200017F")]
	public struct Entitlement
	{
		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long Id;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EntitlementType Type;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public long SkuId;
	}
	[Token(Token = "0x2000180")]
	public struct SkuPrice
	{
		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint Amount;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Currency;
	}
	[Token(Token = "0x2000181")]
	public struct Sku
	{
		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long Id;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SkuType Type;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SkuPrice Price;
	}
	[Token(Token = "0x2000182")]
	public struct InputMode
	{
		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputModeType Type;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Shortcut;
	}
	[Token(Token = "0x2000183")]
	public struct UserAchievement
	{
		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long UserId;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long AchievementId;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte PercentComplete;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string UnlockedAt;
	}
	[Token(Token = "0x2000184")]
	public struct LobbyTransaction
	{
		[Token(Token = "0x2000185")]
		internal struct FFIMethods
		{
			[Token(Token = "0x2000186")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SetTypeMethod(IntPtr methodsPtr, LobbyType type);

			[Token(Token = "0x2000187")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SetOwnerMethod(IntPtr methodsPtr, long ownerId);

			[Token(Token = "0x2000188")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SetCapacityMethod(IntPtr methodsPtr, uint capacity);

			[Token(Token = "0x2000189")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SetMetadataMethod(IntPtr methodsPtr, string key, string value);

			[Token(Token = "0x200018A")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result DeleteMetadataMethod(IntPtr methodsPtr, string key);

			[Token(Token = "0x200018B")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SetLockedMethod(IntPtr methodsPtr, bool locked);

			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal SetTypeMethod SetType;

			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal SetOwnerMethod SetOwner;

			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal SetCapacityMethod SetCapacity;

			[Token(Token = "0x4000966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal SetMetadataMethod SetMetadata;

			[Token(Token = "0x4000967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal DeleteMetadataMethod DeleteMetadata;

			[Token(Token = "0x4000968")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal SetLockedMethod SetLocked;
		}

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal IntPtr MethodsPtr;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal object MethodsStructure;

		[Token(Token = "0x17000125")]
		private FFIMethods Methods
		{
			[Token(Token = "0x6000999")]
			[Address(RVA = "0xADEC38", Offset = "0xADEC38", VA = "0xADEC38")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0xADED50", Offset = "0xADED50", VA = "0xADED50")]
		public void SetType(LobbyType type)
		{
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0xADEE1C", Offset = "0xADEE1C", VA = "0xADEE1C")]
		public void SetOwner(long ownerId)
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0xADEEE8", Offset = "0xADEEE8", VA = "0xADEEE8")]
		public void SetCapacity(uint capacity)
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0xADEFB4", Offset = "0xADEFB4", VA = "0xADEFB4")]
		public void SetMetadata(string key, string value)
		{
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0xADF090", Offset = "0xADF090", VA = "0xADF090")]
		public void DeleteMetadata(string key)
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0xADF15C", Offset = "0xADF15C", VA = "0xADF15C")]
		public void SetLocked(bool locked)
		{
		}
	}
	[Token(Token = "0x200018C")]
	public struct LobbyMemberTransaction
	{
		[Token(Token = "0x200018D")]
		internal struct FFIMethods
		{
			[Token(Token = "0x200018E")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SetMetadataMethod(IntPtr methodsPtr, string key, string value);

			[Token(Token = "0x200018F")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result DeleteMetadataMethod(IntPtr methodsPtr, string key);

			[Token(Token = "0x400096B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal SetMetadataMethod SetMetadata;

			[Token(Token = "0x400096C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal DeleteMetadataMethod DeleteMetadata;
		}

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal IntPtr MethodsPtr;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal object MethodsStructure;

		[Token(Token = "0x17000126")]
		private FFIMethods Methods
		{
			[Token(Token = "0x60009B8")]
			[Address(RVA = "0xADFC24", Offset = "0xADFC24", VA = "0xADFC24")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0xADFD30", Offset = "0xADFD30", VA = "0xADFD30")]
		public void SetMetadata(string key, string value)
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0xADFE00", Offset = "0xADFE00", VA = "0xADFE00")]
		public void DeleteMetadata(string key)
		{
		}
	}
	[Token(Token = "0x2000190")]
	public struct LobbySearchQuery
	{
		[Token(Token = "0x2000191")]
		internal struct FFIMethods
		{
			[Token(Token = "0x2000192")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result FilterMethod(IntPtr methodsPtr, string key, LobbySearchComparison comparison, LobbySearchCast cast, string value);

			[Token(Token = "0x2000193")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SortMethod(IntPtr methodsPtr, string key, LobbySearchCast cast, string value);

			[Token(Token = "0x2000194")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result LimitMethod(IntPtr methodsPtr, uint limit);

			[Token(Token = "0x2000195")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result DistanceMethod(IntPtr methodsPtr, LobbySearchDistance distance);

			[Token(Token = "0x400096F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal FilterMethod Filter;

			[Token(Token = "0x4000970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal SortMethod Sort;

			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal LimitMethod Limit;

			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal DistanceMethod Distance;
		}

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal IntPtr MethodsPtr;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal object MethodsStructure;

		[Token(Token = "0x17000127")]
		private FFIMethods Methods
		{
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0xAE01E4", Offset = "0xAE01E4", VA = "0xAE01E4")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0xAE02F4", Offset = "0xAE02F4", VA = "0xAE02F4")]
		public void Filter(string key, LobbySearchComparison comparison, LobbySearchCast cast, string value)
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0xAE03E8", Offset = "0xAE03E8", VA = "0xAE03E8")]
		public void Sort(string key, LobbySearchCast cast, string value)
		{
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0xAE04CC", Offset = "0xAE04CC", VA = "0xAE04CC")]
		public void Limit(uint limit)
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0xAE0598", Offset = "0xAE0598", VA = "0xAE0598")]
		public void Distance(LobbySearchDistance distance)
		{
		}
	}
	[Token(Token = "0x2000196")]
	public class ResultException : Exception
	{
		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public readonly Result Result;

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0xADBD20", Offset = "0xADBD20", VA = "0xADBD20")]
		public ResultException(Result result)
		{
		}
	}
	[Token(Token = "0x2000197")]
	public class Discord : IDisposable
	{
		[Token(Token = "0x2000198")]
		internal struct FFIEvents
		{
		}

		[Token(Token = "0x2000199")]
		internal struct FFIMethods
		{
			[Token(Token = "0x200019A")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void DestroyHandler(IntPtr MethodsPtr);

			[Token(Token = "0x200019B")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result RunCallbacksMethod(IntPtr methodsPtr);

			[Token(Token = "0x200019C")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SetLogHookCallback(IntPtr ptr, LogLevel level, string message);

			[Token(Token = "0x200019D")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SetLogHookMethod(IntPtr methodsPtr, LogLevel minLevel, IntPtr callbackData, SetLogHookCallback callback);

			[Token(Token = "0x200019E")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetApplicationManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x200019F")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetUserManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x20001A0")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetImageManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x20001A1")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetActivityManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x20001A2")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetRelationshipManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x20001A3")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetLobbyManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x20001A4")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetNetworkManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x20001A5")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetOverlayManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x20001A6")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetStorageManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x20001A7")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetStoreManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x20001A8")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetVoiceManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x20001A9")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate IntPtr GetAchievementManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x400099E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal DestroyHandler Destroy;

			[Token(Token = "0x400099F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal RunCallbacksMethod RunCallbacks;

			[Token(Token = "0x40009A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal SetLogHookMethod SetLogHook;

			[Token(Token = "0x40009A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal GetApplicationManagerMethod GetApplicationManager;

			[Token(Token = "0x40009A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal GetUserManagerMethod GetUserManager;

			[Token(Token = "0x40009A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal GetImageManagerMethod GetImageManager;

			[Token(Token = "0x40009A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal GetActivityManagerMethod GetActivityManager;

			[Token(Token = "0x40009A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal GetRelationshipManagerMethod GetRelationshipManager;

			[Token(Token = "0x40009A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal GetLobbyManagerMethod GetLobbyManager;

			[Token(Token = "0x40009A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal GetNetworkManagerMethod GetNetworkManager;

			[Token(Token = "0x40009A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal GetOverlayManagerMethod GetOverlayManager;

			[Token(Token = "0x40009A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal GetStorageManagerMethod GetStorageManager;

			[Token(Token = "0x40009AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal GetStoreManagerMethod GetStoreManager;

			[Token(Token = "0x40009AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal GetVoiceManagerMethod GetVoiceManager;

			[Token(Token = "0x40009AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal GetAchievementManagerMethod GetAchievementManager;
		}

		[Token(Token = "0x20001AA")]
		internal struct FFICreateParams
		{
			[Token(Token = "0x40009AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal long ClientId;

			[Token(Token = "0x40009AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal ulong Flags;

			[Token(Token = "0x40009AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal IntPtr Events;

			[Token(Token = "0x40009B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal IntPtr EventData;

			[Token(Token = "0x40009B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal IntPtr ApplicationEvents;

			[Token(Token = "0x40009B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal uint ApplicationVersion;

			[Token(Token = "0x40009B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal IntPtr UserEvents;

			[Token(Token = "0x40009B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal uint UserVersion;

			[Token(Token = "0x40009B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal IntPtr ImageEvents;

			[Token(Token = "0x40009B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal uint ImageVersion;

			[Token(Token = "0x40009B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal IntPtr ActivityEvents;

			[Token(Token = "0x40009B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal uint ActivityVersion;

			[Token(Token = "0x40009B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal IntPtr RelationshipEvents;

			[Token(Token = "0x40009BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal uint RelationshipVersion;

			[Token(Token = "0x40009BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal IntPtr LobbyEvents;

			[Token(Token = "0x40009BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			internal uint LobbyVersion;

			[Token(Token = "0x40009BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			internal IntPtr NetworkEvents;

			[Token(Token = "0x40009BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			internal uint NetworkVersion;

			[Token(Token = "0x40009BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			internal IntPtr OverlayEvents;

			[Token(Token = "0x40009C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			internal uint OverlayVersion;

			[Token(Token = "0x40009C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			internal IntPtr StorageEvents;

			[Token(Token = "0x40009C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			internal uint StorageVersion;

			[Token(Token = "0x40009C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			internal IntPtr StoreEvents;

			[Token(Token = "0x40009C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			internal uint StoreVersion;

			[Token(Token = "0x40009C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			internal IntPtr VoiceEvents;

			[Token(Token = "0x40009C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			internal uint VoiceVersion;

			[Token(Token = "0x40009C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			internal IntPtr AchievementEvents;

			[Token(Token = "0x40009C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			internal uint AchievementVersion;
		}

		[Token(Token = "0x20001AB")]
		public delegate void SetLogHookHandler(LogLevel level, string message);

		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private GCHandle SelfHandle;

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr EventsPtr;

		[Token(Token = "0x4000976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FFIEvents Events;

		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IntPtr ApplicationEventsPtr;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ApplicationManager.FFIEvents ApplicationEvents;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal ApplicationManager ApplicationManagerInstance;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IntPtr UserEventsPtr;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UserManager.FFIEvents UserEvents;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal UserManager UserManagerInstance;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IntPtr ImageEventsPtr;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ImageManager.FFIEvents ImageEvents;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal ImageManager ImageManagerInstance;

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private IntPtr ActivityEventsPtr;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ActivityManager.FFIEvents ActivityEvents;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal ActivityManager ActivityManagerInstance;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private IntPtr RelationshipEventsPtr;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RelationshipManager.FFIEvents RelationshipEvents;

		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal RelationshipManager RelationshipManagerInstance;

		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private IntPtr LobbyEventsPtr;

		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private LobbyManager.FFIEvents LobbyEvents;

		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		internal LobbyManager LobbyManagerInstance;

		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private IntPtr NetworkEventsPtr;

		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private NetworkManager.FFIEvents NetworkEvents;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		internal NetworkManager NetworkManagerInstance;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private IntPtr OverlayEventsPtr;

		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private OverlayManager.FFIEvents OverlayEvents;

		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		internal OverlayManager OverlayManagerInstance;

		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private IntPtr StorageEventsPtr;

		[Token(Token = "0x4000990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private StorageManager.FFIEvents StorageEvents;

		[Token(Token = "0x4000991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		internal StorageManager StorageManagerInstance;

		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private IntPtr StoreEventsPtr;

		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private StoreManager.FFIEvents StoreEvents;

		[Token(Token = "0x4000994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		internal StoreManager StoreManagerInstance;

		[Token(Token = "0x4000995")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private IntPtr VoiceEventsPtr;

		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private VoiceManager.FFIEvents VoiceEvents;

		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		internal VoiceManager VoiceManagerInstance;

		[Token(Token = "0x4000998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private IntPtr AchievementEventsPtr;

		[Token(Token = "0x4000999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private AchievementManager.FFIEvents AchievementEvents;

		[Token(Token = "0x400099A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		internal AchievementManager AchievementManagerInstance;

		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private object MethodsStructure;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private GCHandle? setLogHook;

		[Token(Token = "0x17000128")]
		private FFIMethods Methods
		{
			[Token(Token = "0x60009DA")]
			[Address(RVA = "0xAE0EBC", Offset = "0xAE0EBC", VA = "0xAE0EBC")]
			get
			{
				return default(FFIMethods);
			}
		}

		[PreserveSig]
		[Token(Token = "0x60009D9")]
		[Address(RVA = "0xAE0E24", Offset = "0xAE0E24", VA = "0xAE0E24")]
		private static extern Result DiscordCreate(uint version, ref FFICreateParams createParams, out IntPtr manager);

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0xAE0FD0", Offset = "0xAE0FD0", VA = "0xAE0FD0")]
		public Discord(long clientId, ulong flags)
		{
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0xAE13EC", Offset = "0xAE13EC", VA = "0xAE13EC")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0xAE145C", Offset = "0xAE145C", VA = "0xAE145C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0xAE15F4", Offset = "0xAE15F4", VA = "0xAE15F4")]
		public void RunCallbacks()
		{
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0xAE0D80", Offset = "0xAE0D80", VA = "0xAE0D80")]
		[MonoPInvokeCallback]
		private static void SetLogHookCallbackImpl(IntPtr ptr, LogLevel level, string message)
		{
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0xAE1684", Offset = "0xAE1684", VA = "0xAE1684")]
		public void SetLogHook(LogLevel minLevel, SetLogHookHandler callback)
		{
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0xAE18B8", Offset = "0xAE18B8", VA = "0xAE18B8")]
		public ApplicationManager GetApplicationManager()
		{
			return null;
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0xAE1A34", Offset = "0xAE1A34", VA = "0xAE1A34")]
		public UserManager GetUserManager()
		{
			return null;
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0xAE1BB8", Offset = "0xAE1BB8", VA = "0xAE1BB8")]
		public ImageManager GetImageManager()
		{
			return null;
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0xAE1D34", Offset = "0xAE1D34", VA = "0xAE1D34")]
		public ActivityManager GetActivityManager()
		{
			return null;
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0xAE1DEC", Offset = "0xAE1DEC", VA = "0xAE1DEC")]
		public RelationshipManager GetRelationshipManager()
		{
			return null;
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0xAE1F70", Offset = "0xAE1F70", VA = "0xAE1F70")]
		public LobbyManager GetLobbyManager()
		{
			return null;
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0xAE20F4", Offset = "0xAE20F4", VA = "0xAE20F4")]
		public NetworkManager GetNetworkManager()
		{
			return null;
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0xAE21B0", Offset = "0xAE21B0", VA = "0xAE21B0")]
		public OverlayManager GetOverlayManager()
		{
			return null;
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0xAE226C", Offset = "0xAE226C", VA = "0xAE226C")]
		public StorageManager GetStorageManager()
		{
			return null;
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0xAE2328", Offset = "0xAE2328", VA = "0xAE2328")]
		public StoreManager GetStoreManager()
		{
			return null;
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0xAE23E4", Offset = "0xAE23E4", VA = "0xAE23E4")]
		public VoiceManager GetVoiceManager()
		{
			return null;
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0xAE24A0", Offset = "0xAE24A0", VA = "0xAE24A0")]
		public AchievementManager GetAchievementManager()
		{
			return null;
		}
	}
	[Token(Token = "0x20001AC")]
	internal class MonoPInvokeCallbackAttribute : Attribute
	{
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0xAE3E80", Offset = "0xAE3E80", VA = "0xAE3E80")]
		public MonoPInvokeCallbackAttribute()
		{
		}
	}
	[Token(Token = "0x20001AD")]
	public class ApplicationManager
	{
		[Token(Token = "0x20001AE")]
		internal struct FFIEvents
		{
		}

		[Token(Token = "0x20001AF")]
		internal struct FFIMethods
		{
			[Token(Token = "0x20001B0")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ValidateOrExitCallback(IntPtr ptr, Result result);

			[Token(Token = "0x20001B1")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ValidateOrExitMethod(IntPtr methodsPtr, IntPtr callbackData, ValidateOrExitCallback callback);

			[Token(Token = "0x20001B2")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void GetCurrentLocaleMethod(IntPtr methodsPtr, StringBuilder locale);

			[Token(Token = "0x20001B3")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void GetCurrentBranchMethod(IntPtr methodsPtr, StringBuilder branch);

			[Token(Token = "0x20001B4")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void GetOAuth2TokenCallback(IntPtr ptr, Result result, ref OAuth2Token oauth2Token);

			[Token(Token = "0x20001B5")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void GetOAuth2TokenMethod(IntPtr methodsPtr, IntPtr callbackData, GetOAuth2TokenCallback callback);

			[Token(Token = "0x20001B6")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void GetTicketCallback(IntPtr ptr, Result result, ref string data);

			[Token(Token = "0x20001B7")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void GetTicketMethod(IntPtr methodsPtr, IntPtr callbackData, GetTicketCallback callback);

			[Token(Token = "0x40009CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ValidateOrExitMethod ValidateOrExit;

			[Token(Token = "0x40009CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal GetCurrentLocaleMethod GetCurrentLocale;

			[Token(Token = "0x40009CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal GetCurrentBranchMethod GetCurrentBranch;

			[Token(Token = "0x40009CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal GetOAuth2TokenMethod GetOAuth2Token;

			[Token(Token = "0x40009CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal GetTicketMethod GetTicket;
		}

		[Token(Token = "0x20001B8")]
		public delegate void ValidateOrExitHandler(Result result);

		[Token(Token = "0x20001B9")]
		public delegate void GetOAuth2TokenHandler(Result result, ref OAuth2Token oauth2Token);

		[Token(Token = "0x20001BA")]
		public delegate void GetTicketHandler(Result result, ref string data);

		[Token(Token = "0x40009C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x40009CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x17000129")]
		private FFIMethods Methods
		{
			[Token(Token = "0x6000A32")]
			[Address(RVA = "0xAE409C", Offset = "0xAE409C", VA = "0xAE409C")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0xAE1970", Offset = "0xAE1970", VA = "0xAE1970")]
		internal ApplicationManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0xAE41B4", Offset = "0xAE41B4", VA = "0xAE41B4")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0xAE3E88", Offset = "0xAE3E88", VA = "0xAE3E88")]
		[MonoPInvokeCallback]
		private static void ValidateOrExitCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0xAE4224", Offset = "0xAE4224", VA = "0xAE4224")]
		public void ValidateOrExit(ValidateOrExitHandler callback)
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0xAE43C4", Offset = "0xAE43C4", VA = "0xAE43C4")]
		public string GetCurrentLocale()
		{
			return null;
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0xAE4464", Offset = "0xAE4464", VA = "0xAE4464")]
		public string GetCurrentBranch()
		{
			return null;
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0xAE3F34", Offset = "0xAE3F34", VA = "0xAE3F34")]
		[MonoPInvokeCallback]
		private static void GetOAuth2TokenCallbackImpl(IntPtr ptr, Result result, ref OAuth2Token oauth2Token)
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0xAE4504", Offset = "0xAE4504", VA = "0xAE4504")]
		public void GetOAuth2Token(GetOAuth2TokenHandler callback)
		{
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0xAE3FE8", Offset = "0xAE3FE8", VA = "0xAE3FE8")]
		[MonoPInvokeCallback]
		private static void GetTicketCallbackImpl(IntPtr ptr, Result result, ref string data)
		{
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0xAE46A4", Offset = "0xAE46A4", VA = "0xAE46A4")]
		public void GetTicket(GetTicketHandler callback)
		{
		}
	}
	[Token(Token = "0x20001BB")]
	public class UserManager
	{
		[Token(Token = "0x20001BC")]
		internal struct FFIEvents
		{
			[Token(Token = "0x20001BD")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void CurrentUserUpdateHandler(IntPtr ptr);

			[Token(Token = "0x40009D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal CurrentUserUpdateHandler OnCurrentUserUpdate;
		}

		[Token(Token = "0x20001BE")]
		internal struct FFIMethods
		{
			[Token(Token = "0x20001BF")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetCurrentUserMethod(IntPtr methodsPtr, ref User currentUser);

			[Token(Token = "0x20001C0")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void GetUserCallback(IntPtr ptr, Result result, ref User user);

			[Token(Token = "0x20001C1")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void GetUserMethod(IntPtr methodsPtr, long userId, IntPtr callbackData, GetUserCallback callback);

			[Token(Token = "0x20001C2")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetCurrentUserPremiumTypeMethod(IntPtr methodsPtr, ref PremiumType premiumType);

			[Token(Token = "0x20001C3")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result CurrentUserHasFlagMethod(IntPtr methodsPtr, UserFlag flag, ref bool hasFlag);

			[Token(Token = "0x40009D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal GetCurrentUserMethod GetCurrentUser;

			[Token(Token = "0x40009D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal GetUserMethod GetUser;

			[Token(Token = "0x40009D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal GetCurrentUserPremiumTypeMethod GetCurrentUserPremiumType;

			[Token(Token = "0x40009D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal CurrentUserHasFlagMethod CurrentUserHasFlag;
		}

		[Token(Token = "0x20001C4")]
		public delegate void GetUserHandler(Result result, ref User user);

		[Token(Token = "0x20001C5")]
		public delegate void CurrentUserUpdateHandler();

		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x40009D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x1700012A")]
		private FFIMethods Methods
		{
			[Token(Token = "0x6000A69")]
			[Address(RVA = "0xAE589C", Offset = "0xAE589C", VA = "0xAE589C")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000005")]
		public event CurrentUserUpdateHandler OnCurrentUserUpdate
		{
			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0xAE59AC", Offset = "0xAE59AC", VA = "0xAE59AC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0xAE5A48", Offset = "0xAE5A48", VA = "0xAE5A48")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0xAE1AEC", Offset = "0xAE1AEC", VA = "0xAE1AEC")]
		internal UserManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0xAE5AE4", Offset = "0xAE5AE4", VA = "0xAE5AE4")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0xAE5C74", Offset = "0xAE5C74", VA = "0xAE5C74")]
		public User GetCurrentUser()
		{
			return default(User);
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0xAE5734", Offset = "0xAE5734", VA = "0xAE5734")]
		[MonoPInvokeCallback]
		private static void GetUserCallbackImpl(IntPtr ptr, Result result, ref User user)
		{
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0xAE5D28", Offset = "0xAE5D28", VA = "0xAE5D28")]
		public void GetUser(long userId, GetUserHandler callback)
		{
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0xAE5ED0", Offset = "0xAE5ED0", VA = "0xAE5ED0")]
		public PremiumType GetCurrentUserPremiumType()
		{
			return default(PremiumType);
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0xAE5F6C", Offset = "0xAE5F6C", VA = "0xAE5F6C")]
		public bool CurrentUserHasFlag(UserFlag flag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0xAE57E8", Offset = "0xAE57E8", VA = "0xAE57E8")]
		[MonoPInvokeCallback]
		private static void OnCurrentUserUpdateImpl(IntPtr ptr)
		{
		}
	}
	[Token(Token = "0x20001C6")]
	public class ImageManager
	{
		[Token(Token = "0x20001C7")]
		internal struct FFIEvents
		{
		}

		[Token(Token = "0x20001C8")]
		internal struct FFIMethods
		{
			[Token(Token = "0x20001C9")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void FetchCallback(IntPtr ptr, Result result, ImageHandle handleResult);

			[Token(Token = "0x20001CA")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void FetchMethod(IntPtr methodsPtr, ImageHandle handle, bool refresh, IntPtr callbackData, FetchCallback callback);

			[Token(Token = "0x20001CB")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetDimensionsMethod(IntPtr methodsPtr, ImageHandle handle, ref ImageDimensions dimensions);

			[Token(Token = "0x20001CC")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetDataMethod(IntPtr methodsPtr, ImageHandle handle, byte[] data, int dataLen);

			[Token(Token = "0x40009DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal FetchMethod Fetch;

			[Token(Token = "0x40009DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal GetDimensionsMethod GetDimensions;

			[Token(Token = "0x40009DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal GetDataMethod GetData;
		}

		[Token(Token = "0x20001CD")]
		public delegate void FetchHandler(Result result, ImageHandle handleResult);

		[Token(Token = "0x40009D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x40009D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x1700012B")]
		private FFIMethods Methods
		{
			[Token(Token = "0x6000A94")]
			[Address(RVA = "0xAE6C64", Offset = "0xAE6C64", VA = "0xAE6C64")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0xAE1C70", Offset = "0xAE1C70", VA = "0xAE1C70")]
		internal ImageManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0xAE6D7C", Offset = "0xAE6D7C", VA = "0xAE6D7C")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0xAE6B88", Offset = "0xAE6B88", VA = "0xAE6B88")]
		[MonoPInvokeCallback]
		private static void FetchCallbackImpl(IntPtr ptr, Result result, ImageHandle handleResult)
		{
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0xAE6DEC", Offset = "0xAE6DEC", VA = "0xAE6DEC")]
		public void Fetch(ImageHandle handle, bool refresh, FetchHandler callback)
		{
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0xAE6FC8", Offset = "0xAE6FC8", VA = "0xAE6FC8")]
		public ImageDimensions GetDimensions(ImageHandle handle)
		{
			return default(ImageDimensions);
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0xAE7084", Offset = "0xAE7084", VA = "0xAE7084")]
		public void GetData(ImageHandle handle, byte[] data)
		{
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0xAE7148", Offset = "0xAE7148", VA = "0xAE7148")]
		public void Fetch(ImageHandle handle, FetchHandler callback)
		{
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0xAE717C", Offset = "0xAE717C", VA = "0xAE717C")]
		public byte[] GetData(ImageHandle handle)
		{
			return null;
		}
	}
	[Token(Token = "0x20001CE")]
	public class RelationshipManager
	{
		[Token(Token = "0x20001CF")]
		internal struct FFIEvents
		{
			[Token(Token = "0x20001D0")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void RefreshHandler(IntPtr ptr);

			[Token(Token = "0x20001D1")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void RelationshipUpdateHandler(IntPtr ptr, ref Relationship relationship);

			[Token(Token = "0x40009E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal RefreshHandler OnRefresh;

			[Token(Token = "0x40009E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal RelationshipUpdateHandler OnRelationshipUpdate;
		}

		[Token(Token = "0x20001D2")]
		internal struct FFIMethods
		{
			[Token(Token = "0x20001D3")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate bool FilterCallback(IntPtr ptr, ref Relationship relationship);

			[Token(Token = "0x20001D4")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void FilterMethod(IntPtr methodsPtr, IntPtr callbackData, FilterCallback callback);

			[Token(Token = "0x20001D5")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result CountMethod(IntPtr methodsPtr, ref int count);

			[Token(Token = "0x20001D6")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetMethod(IntPtr methodsPtr, long userId, ref Relationship relationship);

			[Token(Token = "0x20001D7")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetAtMethod(IntPtr methodsPtr, uint index, ref Relationship relationship);

			[Token(Token = "0x40009E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal FilterMethod Filter;

			[Token(Token = "0x40009E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal CountMethod Count;

			[Token(Token = "0x40009E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal GetMethod Get;

			[Token(Token = "0x40009E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal GetAtMethod GetAt;
		}

		[Token(Token = "0x20001D8")]
		public delegate bool FilterHandler(ref Relationship relationship);

		[Token(Token = "0x20001D9")]
		public delegate void RefreshHandler();

		[Token(Token = "0x20001DA")]
		public delegate void RelationshipUpdateHandler(ref Relationship relationship);

		[Token(Token = "0x40009DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x40009DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x1700012C")]
		private FFIMethods Methods
		{
			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0xAE7D84", Offset = "0xAE7D84", VA = "0xAE7D84")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000006")]
		public event RefreshHandler OnRefresh
		{
			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0xAE7E94", Offset = "0xAE7E94", VA = "0xAE7E94")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0xAE7F30", Offset = "0xAE7F30", VA = "0xAE7F30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event RelationshipUpdateHandler OnRelationshipUpdate
		{
			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0xAE7FCC", Offset = "0xAE7FCC", VA = "0xAE7FCC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0xAE8068", Offset = "0xAE8068", VA = "0xAE8068")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0xAE1EA4", Offset = "0xAE1EA4", VA = "0xAE1EA4")]
		internal RelationshipManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0xAE8104", Offset = "0xAE8104", VA = "0xAE8104")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0xAE7B6C", Offset = "0xAE7B6C", VA = "0xAE7B6C")]
		[MonoPInvokeCallback]
		private static bool FilterCallbackImpl(IntPtr ptr, ref Relationship relationship)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0xAE83A8", Offset = "0xAE83A8", VA = "0xAE83A8")]
		public void Filter(FilterHandler callback)
		{
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0xAE855C", Offset = "0xAE855C", VA = "0xAE855C")]
		public int Count()
		{
			return default(int);
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0xAE85F8", Offset = "0xAE85F8", VA = "0xAE85F8")]
		public Relationship Get(long userId)
		{
			return default(Relationship);
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0xAE86C0", Offset = "0xAE86C0", VA = "0xAE86C0")]
		public Relationship GetAt(uint index)
		{
			return default(Relationship);
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0xAE7C0C", Offset = "0xAE7C0C", VA = "0xAE7C0C")]
		[MonoPInvokeCallback]
		private static void OnRefreshImpl(IntPtr ptr)
		{
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0xAE7CC0", Offset = "0xAE7CC0", VA = "0xAE7CC0")]
		[MonoPInvokeCallback]
		private static void OnRelationshipUpdateImpl(IntPtr ptr, ref Relationship relationship)
		{
		}
	}
	[Token(Token = "0x20001DB")]
	public class LobbyManager
	{
		[Token(Token = "0x20001DC")]
		internal struct FFIEvents
		{
			[Token(Token = "0x20001DD")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void LobbyUpdateHandler(IntPtr ptr, long lobbyId);

			[Token(Token = "0x20001DE")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void LobbyDeleteHandler(IntPtr ptr, long lobbyId, uint reason);

			[Token(Token = "0x20001DF")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void MemberConnectHandler(IntPtr ptr, long lobbyId, long userId);

			[Token(Token = "0x20001E0")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void MemberUpdateHandler(IntPtr ptr, long lobbyId, long userId);

			[Token(Token = "0x20001E1")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void MemberDisconnectHandler(IntPtr ptr, long lobbyId, long userId);

			[Token(Token = "0x20001E2")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void LobbyMessageHandler(IntPtr ptr, long lobbyId, long userId, IntPtr dataPtr, int dataLen);

			[Token(Token = "0x20001E3")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SpeakingHandler(IntPtr ptr, long lobbyId, long userId, bool speaking);

			[Token(Token = "0x20001E4")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void NetworkMessageHandler(IntPtr ptr, long lobbyId, long userId, byte channelId, IntPtr dataPtr, int dataLen);

			[Token(Token = "0x40009F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal LobbyUpdateHandler OnLobbyUpdate;

			[Token(Token = "0x40009F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal LobbyDeleteHandler OnLobbyDelete;

			[Token(Token = "0x40009F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal MemberConnectHandler OnMemberConnect;

			[Token(Token = "0x40009F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal MemberUpdateHandler OnMemberUpdate;

			[Token(Token = "0x40009F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal MemberDisconnectHandler OnMemberDisconnect;

			[Token(Token = "0x40009F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal LobbyMessageHandler OnLobbyMessage;

			[Token(Token = "0x40009F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal SpeakingHandler OnSpeaking;

			[Token(Token = "0x40009F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal NetworkMessageHandler OnNetworkMessage;
		}

		[Token(Token = "0x20001E5")]
		internal struct FFIMethods
		{
			[Token(Token = "0x20001E6")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetLobbyCreateTransactionMethod(IntPtr methodsPtr, ref IntPtr transaction);

			[Token(Token = "0x20001E7")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetLobbyUpdateTransactionMethod(IntPtr methodsPtr, long lobbyId, ref IntPtr transaction);

			[Token(Token = "0x20001E8")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetMemberUpdateTransactionMethod(IntPtr methodsPtr, long lobbyId, long userId, ref IntPtr transaction);

			[Token(Token = "0x20001E9")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void CreateLobbyCallback(IntPtr ptr, Result result, ref Lobby lobby);

			[Token(Token = "0x20001EA")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void CreateLobbyMethod(IntPtr methodsPtr, IntPtr transaction, IntPtr callbackData, CreateLobbyCallback callback);

			[Token(Token = "0x20001EB")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void UpdateLobbyCallback(IntPtr ptr, Result result);

			[Token(Token = "0x20001EC")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void UpdateLobbyMethod(IntPtr methodsPtr, long lobbyId, IntPtr transaction, IntPtr callbackData, UpdateLobbyCallback callback);

			[Token(Token = "0x20001ED")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void DeleteLobbyCallback(IntPtr ptr, Result result);

			[Token(Token = "0x20001EE")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void DeleteLobbyMethod(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, DeleteLobbyCallback callback);

			[Token(Token = "0x20001EF")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ConnectLobbyCallback(IntPtr ptr, Result result, ref Lobby lobby);

			[Token(Token = "0x20001F0")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ConnectLobbyMethod(IntPtr methodsPtr, long lobbyId, string secret, IntPtr callbackData, ConnectLobbyCallback callback);

			[Token(Token = "0x20001F1")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ConnectLobbyWithActivitySecretCallback(IntPtr ptr, Result result, ref Lobby lobby);

			[Token(Token = "0x20001F2")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ConnectLobbyWithActivitySecretMethod(IntPtr methodsPtr, string activitySecret, IntPtr callbackData, ConnectLobbyWithActivitySecretCallback callback);

			[Token(Token = "0x20001F3")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void DisconnectLobbyCallback(IntPtr ptr, Result result);

			[Token(Token = "0x20001F4")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void DisconnectLobbyMethod(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, DisconnectLobbyCallback callback);

			[Token(Token = "0x20001F5")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetLobbyMethod(IntPtr methodsPtr, long lobbyId, ref Lobby lobby);

			[Token(Token = "0x20001F6")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetLobbyActivitySecretMethod(IntPtr methodsPtr, long lobbyId, StringBuilder secret);

			[Token(Token = "0x20001F7")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetLobbyMetadataValueMethod(IntPtr methodsPtr, long lobbyId, string key, StringBuilder value);

			[Token(Token = "0x20001F8")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetLobbyMetadataKeyMethod(IntPtr methodsPtr, long lobbyId, int index, StringBuilder key);

			[Token(Token = "0x20001F9")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result LobbyMetadataCountMethod(IntPtr methodsPtr, long lobbyId, ref int count);

			[Token(Token = "0x20001FA")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result MemberCountMethod(IntPtr methodsPtr, long lobbyId, ref int count);

			[Token(Token = "0x20001FB")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetMemberUserIdMethod(IntPtr methodsPtr, long lobbyId, int index, ref long userId);

			[Token(Token = "0x20001FC")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetMemberUserMethod(IntPtr methodsPtr, long lobbyId, long userId, ref User user);

			[Token(Token = "0x20001FD")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetMemberMetadataValueMethod(IntPtr methodsPtr, long lobbyId, long userId, string key, StringBuilder value);

			[Token(Token = "0x20001FE")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetMemberMetadataKeyMethod(IntPtr methodsPtr, long lobbyId, long userId, int index, StringBuilder key);

			[Token(Token = "0x20001FF")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result MemberMetadataCountMethod(IntPtr methodsPtr, long lobbyId, long userId, ref int count);

			[Token(Token = "0x2000200")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void UpdateMemberCallback(IntPtr ptr, Result result);

			[Token(Token = "0x2000201")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void UpdateMemberMethod(IntPtr methodsPtr, long lobbyId, long userId, IntPtr transaction, IntPtr callbackData, UpdateMemberCallback callback);

			[Token(Token = "0x2000202")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SendLobbyMessageCallback(IntPtr ptr, Result result);

			[Token(Token = "0x2000203")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SendLobbyMessageMethod(IntPtr methodsPtr, long lobbyId, byte[] data, int dataLen, IntPtr callbackData, SendLobbyMessageCallback callback);

			[Token(Token = "0x2000204")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetSearchQueryMethod(IntPtr methodsPtr, ref IntPtr query);

			[Token(Token = "0x2000205")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SearchCallback(IntPtr ptr, Result result);

			[Token(Token = "0x2000206")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SearchMethod(IntPtr methodsPtr, IntPtr query, IntPtr callbackData, SearchCallback callback);

			[Token(Token = "0x2000207")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void LobbyCountMethod(IntPtr methodsPtr, ref int count);

			[Token(Token = "0x2000208")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetLobbyIdMethod(IntPtr methodsPtr, int index, ref long lobbyId);

			[Token(Token = "0x2000209")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ConnectVoiceCallback(IntPtr ptr, Result result);

			[Token(Token = "0x200020A")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ConnectVoiceMethod(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, ConnectVoiceCallback callback);

			[Token(Token = "0x200020B")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void DisconnectVoiceCallback(IntPtr ptr, Result result);

			[Token(Token = "0x200020C")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void DisconnectVoiceMethod(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, DisconnectVoiceCallback callback);

			[Token(Token = "0x200020D")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result ConnectNetworkMethod(IntPtr methodsPtr, long lobbyId);

			[Token(Token = "0x200020E")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result DisconnectNetworkMethod(IntPtr methodsPtr, long lobbyId);

			[Token(Token = "0x200020F")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result FlushNetworkMethod(IntPtr methodsPtr);

			[Token(Token = "0x2000210")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result OpenNetworkChannelMethod(IntPtr methodsPtr, long lobbyId, byte channelId, bool reliable);

			[Token(Token = "0x2000211")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SendNetworkMessageMethod(IntPtr methodsPtr, long lobbyId, long userId, byte channelId, byte[] data, int dataLen);

			[Token(Token = "0x40009F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal GetLobbyCreateTransactionMethod GetLobbyCreateTransaction;

			[Token(Token = "0x40009FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal GetLobbyUpdateTransactionMethod GetLobbyUpdateTransaction;

			[Token(Token = "0x40009FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal GetMemberUpdateTransactionMethod GetMemberUpdateTransaction;

			[Token(Token = "0x40009FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal CreateLobbyMethod CreateLobby;

			[Token(Token = "0x40009FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal UpdateLobbyMethod UpdateLobby;

			[Token(Token = "0x40009FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal DeleteLobbyMethod DeleteLobby;

			[Token(Token = "0x40009FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal ConnectLobbyMethod ConnectLobby;

			[Token(Token = "0x4000A00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal ConnectLobbyWithActivitySecretMethod ConnectLobbyWithActivitySecret;

			[Token(Token = "0x4000A01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal DisconnectLobbyMethod DisconnectLobby;

			[Token(Token = "0x4000A02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal GetLobbyMethod GetLobby;

			[Token(Token = "0x4000A03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal GetLobbyActivitySecretMethod GetLobbyActivitySecret;

			[Token(Token = "0x4000A04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal GetLobbyMetadataValueMethod GetLobbyMetadataValue;

			[Token(Token = "0x4000A05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal GetLobbyMetadataKeyMethod GetLobbyMetadataKey;

			[Token(Token = "0x4000A06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal LobbyMetadataCountMethod LobbyMetadataCount;

			[Token(Token = "0x4000A07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal MemberCountMethod MemberCount;

			[Token(Token = "0x4000A08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			internal GetMemberUserIdMethod GetMemberUserId;

			[Token(Token = "0x4000A09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			internal GetMemberUserMethod GetMemberUser;

			[Token(Token = "0x4000A0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			internal GetMemberMetadataValueMethod GetMemberMetadataValue;

			[Token(Token = "0x4000A0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			internal GetMemberMetadataKeyMethod GetMemberMetadataKey;

			[Token(Token = "0x4000A0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			internal MemberMetadataCountMethod MemberMetadataCount;

			[Token(Token = "0x4000A0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			internal UpdateMemberMethod UpdateMember;

			[Token(Token = "0x4000A0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			internal SendLobbyMessageMethod SendLobbyMessage;

			[Token(Token = "0x4000A0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			internal GetSearchQueryMethod GetSearchQuery;

			[Token(Token = "0x4000A10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			internal SearchMethod Search;

			[Token(Token = "0x4000A11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			internal LobbyCountMethod LobbyCount;

			[Token(Token = "0x4000A12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			internal GetLobbyIdMethod GetLobbyId;

			[Token(Token = "0x4000A13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			internal ConnectVoiceMethod ConnectVoice;

			[Token(Token = "0x4000A14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			internal DisconnectVoiceMethod DisconnectVoice;

			[Token(Token = "0x4000A15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			internal ConnectNetworkMethod ConnectNetwork;

			[Token(Token = "0x4000A16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			internal DisconnectNetworkMethod DisconnectNetwork;

			[Token(Token = "0x4000A17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			internal FlushNetworkMethod FlushNetwork;

			[Token(Token = "0x4000A18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			internal OpenNetworkChannelMethod OpenNetworkChannel;

			[Token(Token = "0x4000A19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			internal SendNetworkMessageMethod SendNetworkMessage;
		}

		[Token(Token = "0x2000212")]
		public delegate void CreateLobbyHandler(Result result, ref Lobby lobby);

		[Token(Token = "0x2000213")]
		public delegate void UpdateLobbyHandler(Result result);

		[Token(Token = "0x2000214")]
		public delegate void DeleteLobbyHandler(Result result);

		[Token(Token = "0x2000215")]
		public delegate void ConnectLobbyHandler(Result result, ref Lobby lobby);

		[Token(Token = "0x2000216")]
		public delegate void ConnectLobbyWithActivitySecretHandler(Result result, ref Lobby lobby);

		[Token(Token = "0x2000217")]
		public delegate void DisconnectLobbyHandler(Result result);

		[Token(Token = "0x2000218")]
		public delegate void UpdateMemberHandler(Result result);

		[Token(Token = "0x2000219")]
		public delegate void SendLobbyMessageHandler(Result result);

		[Token(Token = "0x200021A")]
		public delegate void SearchHandler(Result result);

		[Token(Token = "0x200021B")]
		public delegate void ConnectVoiceHandler(Result result);

		[Token(Token = "0x200021C")]
		public delegate void DisconnectVoiceHandler(Result result);

		[Token(Token = "0x200021D")]
		public delegate void LobbyUpdateHandler(long lobbyId);

		[Token(Token = "0x200021E")]
		public delegate void LobbyDeleteHandler(long lobbyId, uint reason);

		[Token(Token = "0x200021F")]
		public delegate void MemberConnectHandler(long lobbyId, long userId);

		[Token(Token = "0x2000220")]
		public delegate void MemberUpdateHandler(long lobbyId, long userId);

		[Token(Token = "0x2000221")]
		public delegate void MemberDisconnectHandler(long lobbyId, long userId);

		[Token(Token = "0x2000222")]
		public delegate void LobbyMessageHandler(long lobbyId, long userId, byte[] data);

		[Token(Token = "0x2000223")]
		public delegate void SpeakingHandler(long lobbyId, long userId, bool speaking);

		[Token(Token = "0x2000224")]
		public delegate void NetworkMessageHandler(long lobbyId, long userId, byte channelId, byte[] data);

		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x1700012D")]
		private FFIMethods Methods
		{
			[Token(Token = "0x6000AE7")]
			[Address(RVA = "0xAEA468", Offset = "0xAEA468", VA = "0xAEA468")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000008")]
		public event LobbyUpdateHandler OnLobbyUpdate
		{
			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0xAEA57C", Offset = "0xAEA57C", VA = "0xAEA57C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AE9")]
			[Address(RVA = "0xAEA618", Offset = "0xAEA618", VA = "0xAEA618")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event LobbyDeleteHandler OnLobbyDelete
		{
			[Token(Token = "0x6000AEA")]
			[Address(RVA = "0xAEA6B4", Offset = "0xAEA6B4", VA = "0xAEA6B4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0xAEA750", Offset = "0xAEA750", VA = "0xAEA750")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event MemberConnectHandler OnMemberConnect
		{
			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0xAEA7EC", Offset = "0xAEA7EC", VA = "0xAEA7EC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AED")]
			[Address(RVA = "0xAEA888", Offset = "0xAEA888", VA = "0xAEA888")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event MemberUpdateHandler OnMemberUpdate
		{
			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0xAEA924", Offset = "0xAEA924", VA = "0xAEA924")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0xAEA9C0", Offset = "0xAEA9C0", VA = "0xAEA9C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event MemberDisconnectHandler OnMemberDisconnect
		{
			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0xAEAA5C", Offset = "0xAEAA5C", VA = "0xAEAA5C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0xAEAAF8", Offset = "0xAEAAF8", VA = "0xAEAAF8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event LobbyMessageHandler OnLobbyMessage
		{
			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0xAEAB94", Offset = "0xAEAB94", VA = "0xAEAB94")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0xAEAC30", Offset = "0xAEAC30", VA = "0xAEAC30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event SpeakingHandler OnSpeaking
		{
			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0xAEACCC", Offset = "0xAEACCC", VA = "0xAEACCC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0xAEAD68", Offset = "0xAEAD68", VA = "0xAEAD68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public event NetworkMessageHandler OnNetworkMessage
		{
			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0xAEAE04", Offset = "0xAEAE04", VA = "0xAEAE04")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0xAEAEA0", Offset = "0xAEAEA0", VA = "0xAEAEA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0xAE2028", Offset = "0xAE2028", VA = "0xAE2028")]
		internal LobbyManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0xAEAF3C", Offset = "0xAEAF3C", VA = "0xAEAF3C")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0xAEB254", Offset = "0xAEB254", VA = "0xAEB254")]
		public LobbyTransaction GetLobbyCreateTransaction()
		{
			return default(LobbyTransaction);
		}

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0xAEB2F0", Offset = "0xAEB2F0", VA = "0xAEB2F0")]
		public LobbyTransaction GetLobbyUpdateTransaction(long lobbyId)
		{
			return default(LobbyTransaction);
		}

		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0xAEB390", Offset = "0xAEB390", VA = "0xAEB390")]
		public LobbyMemberTransaction GetMemberUpdateTransaction(long lobbyId, long userId)
		{
			return default(LobbyMemberTransaction);
		}

		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0xAE9554", Offset = "0xAE9554", VA = "0xAE9554")]
		[MonoPInvokeCallback]
		private static void CreateLobbyCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby)
		{
		}

		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0xAEB440", Offset = "0xAEB440", VA = "0xAEB440")]
		public void CreateLobby(LobbyTransaction transaction, CreateLobbyHandler callback)
		{
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0xAE9608", Offset = "0xAE9608", VA = "0xAE9608")]
		[MonoPInvokeCallback]
		private static void UpdateLobbyCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000B00")]
		[Address(RVA = "0xAEB53C", Offset = "0xAEB53C", VA = "0xAEB53C")]
		public void UpdateLobby(long lobbyId, LobbyTransaction transaction, UpdateLobbyHandler callback)
		{
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0xAE96B4", Offset = "0xAE96B4", VA = "0xAE96B4")]
		[MonoPInvokeCallback]
		private static void DeleteLobbyCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0xAEB640", Offset = "0xAEB640", VA = "0xAEB640")]
		public void DeleteLobby(long lobbyId, DeleteLobbyHandler callback)
		{
		}

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0xAE9760", Offset = "0xAE9760", VA = "0xAE9760")]
		[MonoPInvokeCallback]
		private static void ConnectLobbyCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby)
		{
		}

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0xAEB730", Offset = "0xAEB730", VA = "0xAEB730")]
		public void ConnectLobby(long lobbyId, string secret, ConnectLobbyHandler callback)
		{
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0xAE9814", Offset = "0xAE9814", VA = "0xAE9814")]
		[MonoPInvokeCallback]
		private static void ConnectLobbyWithActivitySecretCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby)
		{
		}

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0xAEB828", Offset = "0xAEB828", VA = "0xAEB828")]
		public void ConnectLobbyWithActivitySecret(string activitySecret, ConnectLobbyWithActivitySecretHandler callback)
		{
		}

		[Token(Token = "0x6000B07")]
		[Address(RVA = "0xAE98C8", Offset = "0xAE98C8", VA = "0xAE98C8")]
		[MonoPInvokeCallback]
		private static void DisconnectLobbyCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0xAEB918", Offset = "0xAEB918", VA = "0xAEB918")]
		public void DisconnectLobby(long lobbyId, DisconnectLobbyHandler callback)
		{
		}

		[Token(Token = "0x6000B09")]
		[Address(RVA = "0xAEBA08", Offset = "0xAEBA08", VA = "0xAEBA08")]
		public Lobby GetLobby(long lobbyId)
		{
			return default(Lobby);
		}

		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0xAEBACC", Offset = "0xAEBACC", VA = "0xAEBACC")]
		public string GetLobbyActivitySecret(long lobbyId)
		{
			return null;
		}

		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0xAEBBC0", Offset = "0xAEBBC0", VA = "0xAEBBC0")]
		public string GetLobbyMetadataValue(long lobbyId, string key)
		{
			return null;
		}

		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0xAEBCC4", Offset = "0xAEBCC4", VA = "0xAEBCC4")]
		public string GetLobbyMetadataKey(long lobbyId, int index)
		{
			return null;
		}

		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0xAEBDC8", Offset = "0xAEBDC8", VA = "0xAEBDC8")]
		public int LobbyMetadataCount(long lobbyId)
		{
			return default(int);
		}

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0xAEBE68", Offset = "0xAEBE68", VA = "0xAEBE68")]
		public int MemberCount(long lobbyId)
		{
			return default(int);
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0xAEBF08", Offset = "0xAEBF08", VA = "0xAEBF08")]
		public long GetMemberUserId(long lobbyId, int index)
		{
			return default(long);
		}

		[Token(Token = "0x6000B10")]
		[Address(RVA = "0xAEBFB0", Offset = "0xAEBFB0", VA = "0xAEBFB0")]
		public User GetMemberUser(long lobbyId, long userId)
		{
			return default(User);
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0xAEC084", Offset = "0xAEC084", VA = "0xAEC084")]
		public string GetMemberMetadataValue(long lobbyId, long userId, string key)
		{
			return null;
		}

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0xAEC190", Offset = "0xAEC190", VA = "0xAEC190")]
		public string GetMemberMetadataKey(long lobbyId, long userId, int index)
		{
			return null;
		}

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0xAEC29C", Offset = "0xAEC29C", VA = "0xAEC29C")]
		public int MemberMetadataCount(long lobbyId, long userId)
		{
			return default(int);
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0xAE9974", Offset = "0xAE9974", VA = "0xAE9974")]
		[MonoPInvokeCallback]
		private static void UpdateMemberCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0xAEC34C", Offset = "0xAEC34C", VA = "0xAEC34C")]
		public void UpdateMember(long lobbyId, long userId, LobbyMemberTransaction transaction, UpdateMemberHandler callback)
		{
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0xAE9A20", Offset = "0xAE9A20", VA = "0xAE9A20")]
		[MonoPInvokeCallback]
		private static void SendLobbyMessageCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0xAEC460", Offset = "0xAEC460", VA = "0xAEC460")]
		public void SendLobbyMessage(long lobbyId, byte[] data, SendLobbyMessageHandler callback)
		{
		}

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0xAEC560", Offset = "0xAEC560", VA = "0xAEC560")]
		public LobbySearchQuery GetSearchQuery()
		{
			return default(LobbySearchQuery);
		}

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0xAE9ACC", Offset = "0xAE9ACC", VA = "0xAE9ACC")]
		[MonoPInvokeCallback]
		private static void SearchCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0xAEC5FC", Offset = "0xAEC5FC", VA = "0xAEC5FC")]
		public void Search(LobbySearchQuery query, SearchHandler callback)
		{
		}

		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0xAEC6F8", Offset = "0xAEC6F8", VA = "0xAEC6F8")]
		public int LobbyCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0xAEC74C", Offset = "0xAEC74C", VA = "0xAEC74C")]
		public long GetLobbyId(int index)
		{
			return default(long);
		}

		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0xAE9B78", Offset = "0xAE9B78", VA = "0xAE9B78")]
		[MonoPInvokeCallback]
		private static void ConnectVoiceCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0xAEC7EC", Offset = "0xAEC7EC", VA = "0xAEC7EC")]
		public void ConnectVoice(long lobbyId, ConnectVoiceHandler callback)
		{
		}

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0xAE9C24", Offset = "0xAE9C24", VA = "0xAE9C24")]
		[MonoPInvokeCallback]
		private static void DisconnectVoiceCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000B20")]
		[Address(RVA = "0xAEC8DC", Offset = "0xAEC8DC", VA = "0xAEC8DC")]
		public void DisconnectVoice(long lobbyId, DisconnectVoiceHandler callback)
		{
		}

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0xAEC9CC", Offset = "0xAEC9CC", VA = "0xAEC9CC")]
		public void ConnectNetwork(long lobbyId)
		{
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0xAECA64", Offset = "0xAECA64", VA = "0xAECA64")]
		public void DisconnectNetwork(long lobbyId)
		{
		}

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0xAECAFC", Offset = "0xAECAFC", VA = "0xAECAFC")]
		public void FlushNetwork()
		{
		}

		[Token(Token = "0x6000B24")]
		[Address(RVA = "0xAECB8C", Offset = "0xAECB8C", VA = "0xAECB8C")]
		public void OpenNetworkChannel(long lobbyId, byte channelId, bool reliable)
		{
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0xAECC38", Offset = "0xAECC38", VA = "0xAECC38")]
		public void SendNetworkMessage(long lobbyId, long userId, byte channelId, byte[] data)
		{
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0xAE9CD0", Offset = "0xAE9CD0", VA = "0xAE9CD0")]
		[MonoPInvokeCallback]
		private static void OnLobbyUpdateImpl(IntPtr ptr, long lobbyId)
		{
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0xAE9D94", Offset = "0xAE9D94", VA = "0xAE9D94")]
		[MonoPInvokeCallback]
		private static void OnLobbyDeleteImpl(IntPtr ptr, long lobbyId, uint reason)
		{
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0xAE9E60", Offset = "0xAE9E60", VA = "0xAE9E60")]
		[MonoPInvokeCallback]
		private static void OnMemberConnectImpl(IntPtr ptr, long lobbyId, long userId)
		{
		}

		[Token(Token = "0x6000B29")]
		[Address(RVA = "0xAE9F2C", Offset = "0xAE9F2C", VA = "0xAE9F2C")]
		[MonoPInvokeCallback]
		private static void OnMemberUpdateImpl(IntPtr ptr, long lobbyId, long userId)
		{
		}

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0xAE9FF8", Offset = "0xAE9FF8", VA = "0xAE9FF8")]
		[MonoPInvokeCallback]
		private static void OnMemberDisconnectImpl(IntPtr ptr, long lobbyId, long userId)
		{
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0xAEA0C4", Offset = "0xAEA0C4", VA = "0xAEA0C4")]
		[MonoPInvokeCallback]
		private static void OnLobbyMessageImpl(IntPtr ptr, long lobbyId, long userId, IntPtr dataPtr, int dataLen)
		{
		}

		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0xAEA220", Offset = "0xAEA220", VA = "0xAEA220")]
		[MonoPInvokeCallback]
		private static void OnSpeakingImpl(IntPtr ptr, long lobbyId, long userId, bool speaking)
		{
		}

		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0xAEA2FC", Offset = "0xAEA2FC", VA = "0xAEA2FC")]
		[MonoPInvokeCallback]
		private static void OnNetworkMessageImpl(IntPtr ptr, long lobbyId, long userId, byte channelId, IntPtr dataPtr, int dataLen)
		{
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0xAECCFC", Offset = "0xAECCFC", VA = "0xAECCFC")]
		public IEnumerable<User> GetMemberUsers(long lobbyID)
		{
			return null;
		}

		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0xAECE84", Offset = "0xAECE84", VA = "0xAECE84")]
		public void SendLobbyMessage(long lobbyID, string data, SendLobbyMessageHandler handler)
		{
		}
	}
	[Token(Token = "0x2000225")]
	public class NetworkManager
	{
		[Token(Token = "0x2000226")]
		internal struct FFIEvents
		{
			[Token(Token = "0x2000227")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void MessageHandler(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen);

			[Token(Token = "0x2000228")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void RouteUpdateHandler(IntPtr ptr, string routeData);

			[Token(Token = "0x4000A1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal MessageHandler OnMessage;

			[Token(Token = "0x4000A1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal RouteUpdateHandler OnRouteUpdate;
		}

		[Token(Token = "0x2000229")]
		internal struct FFIMethods
		{
			[Token(Token = "0x200022A")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void GetPeerIdMethod(IntPtr methodsPtr, ref ulong peerId);

			[Token(Token = "0x200022B")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result FlushMethod(IntPtr methodsPtr);

			[Token(Token = "0x200022C")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result OpenPeerMethod(IntPtr methodsPtr, ulong peerId, string routeData);

			[Token(Token = "0x200022D")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result UpdatePeerMethod(IntPtr methodsPtr, ulong peerId, string routeData);

			[Token(Token = "0x200022E")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result ClosePeerMethod(IntPtr methodsPtr, ulong peerId);

			[Token(Token = "0x200022F")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result OpenChannelMethod(IntPtr methodsPtr, ulong peerId, byte channelId, bool reliable);

			[Token(Token = "0x2000230")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result CloseChannelMethod(IntPtr methodsPtr, ulong peerId, byte channelId);

			[Token(Token = "0x2000231")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SendMessageMethod(IntPtr methodsPtr, ulong peerId, byte channelId, byte[] data, int dataLen);

			[Token(Token = "0x4000A20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal GetPeerIdMethod GetPeerId;

			[Token(Token = "0x4000A21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal FlushMethod Flush;

			[Token(Token = "0x4000A22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal OpenPeerMethod OpenPeer;

			[Token(Token = "0x4000A23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal UpdatePeerMethod UpdatePeer;

			[Token(Token = "0x4000A24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal ClosePeerMethod ClosePeer;

			[Token(Token = "0x4000A25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal OpenChannelMethod OpenChannel;

			[Token(Token = "0x4000A26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal CloseChannelMethod CloseChannel;

			[Token(Token = "0x4000A27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal SendMessageMethod SendMessage;
		}

		[Token(Token = "0x2000232")]
		public delegate void MessageHandler(ulong peerId, byte channelId, byte[] data);

		[Token(Token = "0x2000233")]
		public delegate void RouteUpdateHandler(string routeData);

		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x4000A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x1700012E")]
		private FFIMethods Methods
		{
			[Token(Token = "0x6000C4C")]
			[Address(RVA = "0xAF4A20", Offset = "0xAF4A20", VA = "0xAF4A20")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000010")]
		public event MessageHandler OnMessage
		{
			[Token(Token = "0x6000C4D")]
			[Address(RVA = "0xAF4B38", Offset = "0xAF4B38", VA = "0xAF4B38")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000C4E")]
			[Address(RVA = "0xAF4BD4", Offset = "0xAF4BD4", VA = "0xAF4BD4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event RouteUpdateHandler OnRouteUpdate
		{
			[Token(Token = "0x6000C4F")]
			[Address(RVA = "0xAF4C70", Offset = "0xAF4C70", VA = "0xAF4C70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000C50")]
			[Address(RVA = "0xAF4D0C", Offset = "0xAF4D0C", VA = "0xAF4D0C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000C51")]
		[Address(RVA = "0xAF4DA8", Offset = "0xAF4DA8", VA = "0xAF4DA8")]
		internal NetworkManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000C52")]
		[Address(RVA = "0xAF4E78", Offset = "0xAF4E78", VA = "0xAF4E78")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000C53")]
		[Address(RVA = "0xAF511C", Offset = "0xAF511C", VA = "0xAF511C")]
		public ulong GetPeerId()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000C54")]
		[Address(RVA = "0xAF5168", Offset = "0xAF5168", VA = "0xAF5168")]
		public void Flush()
		{
		}

		[Token(Token = "0x6000C55")]
		[Address(RVA = "0xAF51FC", Offset = "0xAF51FC", VA = "0xAF51FC")]
		public void OpenPeer(ulong peerId, string routeData)
		{
		}

		[Token(Token = "0x6000C56")]
		[Address(RVA = "0xAF52A0", Offset = "0xAF52A0", VA = "0xAF52A0")]
		public void UpdatePeer(ulong peerId, string routeData)
		{
		}

		[Token(Token = "0x6000C57")]
		[Address(RVA = "0xAF5344", Offset = "0xAF5344", VA = "0xAF5344")]
		public void ClosePeer(ulong peerId)
		{
		}

		[Token(Token = "0x6000C58")]
		[Address(RVA = "0xAF53E0", Offset = "0xAF53E0", VA = "0xAF53E0")]
		public void OpenChannel(ulong peerId, byte channelId, bool reliable)
		{
		}

		[Token(Token = "0x6000C59")]
		[Address(RVA = "0xAF5490", Offset = "0xAF5490", VA = "0xAF5490")]
		public void CloseChannel(ulong peerId, byte channelId)
		{
		}

		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0xAF5534", Offset = "0xAF5534", VA = "0xAF5534")]
		public void SendMessage(ulong peerId, byte channelId, byte[] data)
		{
		}

		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0xAF4800", Offset = "0xAF4800", VA = "0xAF4800")]
		[MonoPInvokeCallback]
		private static void OnMessageImpl(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen)
		{
		}

		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0xAF495C", Offset = "0xAF495C", VA = "0xAF495C")]
		[MonoPInvokeCallback]
		private static void OnRouteUpdateImpl(IntPtr ptr, string routeData)
		{
		}
	}
	[Token(Token = "0x2000234")]
	public class OverlayManager
	{
		[Token(Token = "0x2000235")]
		internal struct FFIEvents
		{
			[Token(Token = "0x2000236")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ToggleHandler(IntPtr ptr, bool locked);

			[Token(Token = "0x4000A2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ToggleHandler OnToggle;
		}

		[Token(Token = "0x2000237")]
		internal struct FFIMethods
		{
			[Token(Token = "0x2000238")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void IsEnabledMethod(IntPtr methodsPtr, ref bool enabled);

			[Token(Token = "0x2000239")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void IsLockedMethod(IntPtr methodsPtr, ref bool locked);

			[Token(Token = "0x200023A")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SetLockedCallback(IntPtr ptr, Result result);

			[Token(Token = "0x200023B")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SetLockedMethod(IntPtr methodsPtr, bool locked, IntPtr callbackData, SetLockedCallback callback);

			[Token(Token = "0x200023C")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void OpenActivityInviteCallback(IntPtr ptr, Result result);

			[Token(Token = "0x200023D")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void OpenActivityInviteMethod(IntPtr methodsPtr, ActivityActionType type, IntPtr callbackData, OpenActivityInviteCallback callback);

			[Token(Token = "0x200023E")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void OpenGuildInviteCallback(IntPtr ptr, Result result);

			[Token(Token = "0x200023F")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void OpenGuildInviteMethod(IntPtr methodsPtr, string code, IntPtr callbackData, OpenGuildInviteCallback callback);

			[Token(Token = "0x2000240")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void OpenVoiceSettingsCallback(IntPtr ptr, Result result);

			[Token(Token = "0x2000241")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void OpenVoiceSettingsMethod(IntPtr methodsPtr, IntPtr callbackData, OpenVoiceSettingsCallback callback);

			[Token(Token = "0x4000A2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal IsEnabledMethod IsEnabled;

			[Token(Token = "0x4000A2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal IsLockedMethod IsLocked;

			[Token(Token = "0x4000A2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal SetLockedMethod SetLocked;

			[Token(Token = "0x4000A2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal OpenActivityInviteMethod OpenActivityInvite;

			[Token(Token = "0x4000A30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal OpenGuildInviteMethod OpenGuildInvite;

			[Token(Token = "0x4000A31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal OpenVoiceSettingsMethod OpenVoiceSettings;
		}

		[Token(Token = "0x2000242")]
		public delegate void SetLockedHandler(Result result);

		[Token(Token = "0x2000243")]
		public delegate void OpenActivityInviteHandler(Result result);

		[Token(Token = "0x2000244")]
		public delegate void OpenGuildInviteHandler(Result result);

		[Token(Token = "0x2000245")]
		public delegate void OpenVoiceSettingsHandler(Result result);

		[Token(Token = "0x2000246")]
		public delegate void ToggleHandler(bool locked);

		[Token(Token = "0x4000A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x4000A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x1700012F")]
		private FFIMethods Methods
		{
			[Token(Token = "0x6000C8D")]
			[Address(RVA = "0xAF6C74", Offset = "0xAF6C74", VA = "0xAF6C74")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000012")]
		public event ToggleHandler OnToggle
		{
			[Token(Token = "0x6000C8E")]
			[Address(RVA = "0xAF6D8C", Offset = "0xAF6D8C", VA = "0xAF6D8C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000C8F")]
			[Address(RVA = "0xAF6E28", Offset = "0xAF6E28", VA = "0xAF6E28")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000C90")]
		[Address(RVA = "0xAF6EC4", Offset = "0xAF6EC4", VA = "0xAF6EC4")]
		internal OverlayManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000C91")]
		[Address(RVA = "0xAF6F94", Offset = "0xAF6F94", VA = "0xAF6F94")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000C92")]
		[Address(RVA = "0xAF7124", Offset = "0xAF7124", VA = "0xAF7124")]
		public bool IsEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C93")]
		[Address(RVA = "0xAF7170", Offset = "0xAF7170", VA = "0xAF7170")]
		public bool IsLocked()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C94")]
		[Address(RVA = "0xAF6900", Offset = "0xAF6900", VA = "0xAF6900")]
		[MonoPInvokeCallback]
		private static void SetLockedCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000C95")]
		[Address(RVA = "0xAF71BC", Offset = "0xAF71BC", VA = "0xAF71BC")]
		public void SetLocked(bool locked, SetLockedHandler callback)
		{
		}

		[Token(Token = "0x6000C96")]
		[Address(RVA = "0xAF69AC", Offset = "0xAF69AC", VA = "0xAF69AC")]
		[MonoPInvokeCallback]
		private static void OpenActivityInviteCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000C97")]
		[Address(RVA = "0xAF7364", Offset = "0xAF7364", VA = "0xAF7364")]
		public void OpenActivityInvite(ActivityActionType type, OpenActivityInviteHandler callback)
		{
		}

		[Token(Token = "0x6000C98")]
		[Address(RVA = "0xAF6A58", Offset = "0xAF6A58", VA = "0xAF6A58")]
		[MonoPInvokeCallback]
		private static void OpenGuildInviteCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000C99")]
		[Address(RVA = "0xAF750C", Offset = "0xAF750C", VA = "0xAF750C")]
		public void OpenGuildInvite(string code, OpenGuildInviteHandler callback)
		{
		}

		[Token(Token = "0x6000C9A")]
		[Address(RVA = "0xAF6B04", Offset = "0xAF6B04", VA = "0xAF6B04")]
		[MonoPInvokeCallback]
		private static void OpenVoiceSettingsCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000C9B")]
		[Address(RVA = "0xAF76B4", Offset = "0xAF76B4", VA = "0xAF76B4")]
		public void OpenVoiceSettings(OpenVoiceSettingsHandler callback)
		{
		}

		[Token(Token = "0x6000C9C")]
		[Address(RVA = "0xAF6BB0", Offset = "0xAF6BB0", VA = "0xAF6BB0")]
		[MonoPInvokeCallback]
		private static void OnToggleImpl(IntPtr ptr, bool locked)
		{
		}
	}
	[Token(Token = "0x2000247")]
	public class StorageManager
	{
		[Token(Token = "0x2000248")]
		internal struct FFIEvents
		{
		}

		[Token(Token = "0x2000249")]
		internal struct FFIMethods
		{
			[Token(Token = "0x200024A")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result ReadMethod(IntPtr methodsPtr, string name, byte[] data, int dataLen, ref uint read);

			[Token(Token = "0x200024B")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ReadAsyncCallback(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen);

			[Token(Token = "0x200024C")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ReadAsyncMethod(IntPtr methodsPtr, string name, IntPtr callbackData, ReadAsyncCallback callback);

			[Token(Token = "0x200024D")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ReadAsyncPartialCallback(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen);

			[Token(Token = "0x200024E")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void ReadAsyncPartialMethod(IntPtr methodsPtr, string name, ulong offset, ulong length, IntPtr callbackData, ReadAsyncPartialCallback callback);

			[Token(Token = "0x200024F")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result WriteMethod(IntPtr methodsPtr, string name, byte[] data, int dataLen);

			[Token(Token = "0x2000250")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void WriteAsyncCallback(IntPtr ptr, Result result);

			[Token(Token = "0x2000251")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void WriteAsyncMethod(IntPtr methodsPtr, string name, byte[] data, int dataLen, IntPtr callbackData, WriteAsyncCallback callback);

			[Token(Token = "0x2000252")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result DeleteMethod(IntPtr methodsPtr, string name);

			[Token(Token = "0x2000253")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result ExistsMethod(IntPtr methodsPtr, string name, ref bool exists);

			[Token(Token = "0x2000254")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void CountMethod(IntPtr methodsPtr, ref int count);

			[Token(Token = "0x2000255")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result StatMethod(IntPtr methodsPtr, string name, ref FileStat stat);

			[Token(Token = "0x2000256")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result StatAtMethod(IntPtr methodsPtr, int index, ref FileStat stat);

			[Token(Token = "0x2000257")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetPathMethod(IntPtr methodsPtr, StringBuilder path);

			[Token(Token = "0x4000A34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ReadMethod Read;

			[Token(Token = "0x4000A35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal ReadAsyncMethod ReadAsync;

			[Token(Token = "0x4000A36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal ReadAsyncPartialMethod ReadAsyncPartial;

			[Token(Token = "0x4000A37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal WriteMethod Write;

			[Token(Token = "0x4000A38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal WriteAsyncMethod WriteAsync;

			[Token(Token = "0x4000A39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal DeleteMethod Delete;

			[Token(Token = "0x4000A3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal ExistsMethod Exists;

			[Token(Token = "0x4000A3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal CountMethod Count;

			[Token(Token = "0x4000A3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal StatMethod Stat;

			[Token(Token = "0x4000A3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal StatAtMethod StatAt;

			[Token(Token = "0x4000A3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal GetPathMethod GetPath;
		}

		[Token(Token = "0x2000258")]
		public delegate void ReadAsyncHandler(Result result, byte[] data);

		[Token(Token = "0x2000259")]
		public delegate void ReadAsyncPartialHandler(Result result, byte[] data);

		[Token(Token = "0x200025A")]
		public delegate void WriteAsyncHandler(Result result);

		[Token(Token = "0x4000A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x4000A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x17000130")]
		private FFIMethods Methods
		{
			[Token(Token = "0x6000CDD")]
			[Address(RVA = "0xAF9078", Offset = "0xAF9078", VA = "0xAF9078")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x6000CDE")]
		[Address(RVA = "0xAF918C", Offset = "0xAF918C", VA = "0xAF918C")]
		internal StorageManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000CDF")]
		[Address(RVA = "0xAF9254", Offset = "0xAF9254", VA = "0xAF9254")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000CE0")]
		[Address(RVA = "0xAF92C4", Offset = "0xAF92C4", VA = "0xAF92C4")]
		public uint Read(string name, byte[] data)
		{
			return default(uint);
		}

		[Token(Token = "0x6000CE1")]
		[Address(RVA = "0xAF8D74", Offset = "0xAF8D74", VA = "0xAF8D74")]
		[MonoPInvokeCallback]
		private static void ReadAsyncCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen)
		{
		}

		[Token(Token = "0x6000CE2")]
		[Address(RVA = "0xAF9378", Offset = "0xAF9378", VA = "0xAF9378")]
		public void ReadAsync(string name, ReadAsyncHandler callback)
		{
		}

		[Token(Token = "0x6000CE3")]
		[Address(RVA = "0xAF8EA0", Offset = "0xAF8EA0", VA = "0xAF8EA0")]
		[MonoPInvokeCallback]
		private static void ReadAsyncPartialCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen)
		{
		}

		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0xAF9520", Offset = "0xAF9520", VA = "0xAF9520")]
		public void ReadAsyncPartial(string name, ulong offset, ulong length, ReadAsyncPartialHandler callback)
		{
		}

		[Token(Token = "0x6000CE5")]
		[Address(RVA = "0xAF96E0", Offset = "0xAF96E0", VA = "0xAF96E0")]
		public void Write(string name, byte[] data)
		{
		}

		[Token(Token = "0x6000CE6")]
		[Address(RVA = "0xAF8FCC", Offset = "0xAF8FCC", VA = "0xAF8FCC")]
		[MonoPInvokeCallback]
		private static void WriteAsyncCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000CE7")]
		[Address(RVA = "0xAF9788", Offset = "0xAF9788", VA = "0xAF9788")]
		public void WriteAsync(string name, byte[] data, WriteAsyncHandler callback)
		{
		}

		[Token(Token = "0x6000CE8")]
		[Address(RVA = "0xAF9948", Offset = "0xAF9948", VA = "0xAF9948")]
		public void Delete(string name)
		{
		}

		[Token(Token = "0x6000CE9")]
		[Address(RVA = "0xAF99E4", Offset = "0xAF99E4", VA = "0xAF99E4")]
		public bool Exists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CEA")]
		[Address(RVA = "0xAF9A88", Offset = "0xAF9A88", VA = "0xAF9A88")]
		public int Count()
		{
			return default(int);
		}

		[Token(Token = "0x6000CEB")]
		[Address(RVA = "0xAF9AD4", Offset = "0xAF9AD4", VA = "0xAF9AD4")]
		public FileStat Stat(string name)
		{
			return default(FileStat);
		}

		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0xAF9B8C", Offset = "0xAF9B8C", VA = "0xAF9B8C")]
		public FileStat StatAt(int index)
		{
			return default(FileStat);
		}

		[Token(Token = "0x6000CED")]
		[Address(RVA = "0xAF9C44", Offset = "0xAF9C44", VA = "0xAF9C44")]
		public string GetPath()
		{
			return null;
		}

		[Token(Token = "0x6000CEE")]
		[Address(RVA = "0xAF9D2C", Offset = "0xAF9D2C", VA = "0xAF9D2C")]
		public IEnumerable<FileStat> Files()
		{
			return null;
		}
	}
	[Token(Token = "0x200025B")]
	public class StoreManager
	{
		[Token(Token = "0x200025C")]
		internal struct FFIEvents
		{
			[Token(Token = "0x200025D")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void EntitlementCreateHandler(IntPtr ptr, ref Entitlement entitlement);

			[Token(Token = "0x200025E")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void EntitlementDeleteHandler(IntPtr ptr, ref Entitlement entitlement);

			[Token(Token = "0x4000A43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal EntitlementCreateHandler OnEntitlementCreate;

			[Token(Token = "0x4000A44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal EntitlementDeleteHandler OnEntitlementDelete;
		}

		[Token(Token = "0x200025F")]
		internal struct FFIMethods
		{
			[Token(Token = "0x2000260")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void FetchSkusCallback(IntPtr ptr, Result result);

			[Token(Token = "0x2000261")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void FetchSkusMethod(IntPtr methodsPtr, IntPtr callbackData, FetchSkusCallback callback);

			[Token(Token = "0x2000262")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void CountSkusMethod(IntPtr methodsPtr, ref int count);

			[Token(Token = "0x2000263")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetSkuMethod(IntPtr methodsPtr, long skuId, ref Sku sku);

			[Token(Token = "0x2000264")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetSkuAtMethod(IntPtr methodsPtr, int index, ref Sku sku);

			[Token(Token = "0x2000265")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void FetchEntitlementsCallback(IntPtr ptr, Result result);

			[Token(Token = "0x2000266")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void FetchEntitlementsMethod(IntPtr methodsPtr, IntPtr callbackData, FetchEntitlementsCallback callback);

			[Token(Token = "0x2000267")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void CountEntitlementsMethod(IntPtr methodsPtr, ref int count);

			[Token(Token = "0x2000268")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetEntitlementMethod(IntPtr methodsPtr, long entitlementId, ref Entitlement entitlement);

			[Token(Token = "0x2000269")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetEntitlementAtMethod(IntPtr methodsPtr, int index, ref Entitlement entitlement);

			[Token(Token = "0x200026A")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result HasSkuEntitlementMethod(IntPtr methodsPtr, long skuId, ref bool hasEntitlement);

			[Token(Token = "0x200026B")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void StartPurchaseCallback(IntPtr ptr, Result result);

			[Token(Token = "0x200026C")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void StartPurchaseMethod(IntPtr methodsPtr, long skuId, IntPtr callbackData, StartPurchaseCallback callback);

			[Token(Token = "0x4000A45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal FetchSkusMethod FetchSkus;

			[Token(Token = "0x4000A46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal CountSkusMethod CountSkus;

			[Token(Token = "0x4000A47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal GetSkuMethod GetSku;

			[Token(Token = "0x4000A48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal GetSkuAtMethod GetSkuAt;

			[Token(Token = "0x4000A49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal FetchEntitlementsMethod FetchEntitlements;

			[Token(Token = "0x4000A4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal CountEntitlementsMethod CountEntitlements;

			[Token(Token = "0x4000A4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal GetEntitlementMethod GetEntitlement;

			[Token(Token = "0x4000A4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal GetEntitlementAtMethod GetEntitlementAt;

			[Token(Token = "0x4000A4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal HasSkuEntitlementMethod HasSkuEntitlement;

			[Token(Token = "0x4000A4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal StartPurchaseMethod StartPurchase;
		}

		[Token(Token = "0x200026D")]
		public delegate void FetchSkusHandler(Result result);

		[Token(Token = "0x200026E")]
		public delegate void FetchEntitlementsHandler(Result result);

		[Token(Token = "0x200026F")]
		public delegate void StartPurchaseHandler(Result result);

		[Token(Token = "0x2000270")]
		public delegate void EntitlementCreateHandler(ref Entitlement entitlement);

		[Token(Token = "0x2000271")]
		public delegate void EntitlementDeleteHandler(ref Entitlement entitlement);

		[Token(Token = "0x4000A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x4000A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x17000131")]
		private FFIMethods Methods
		{
			[Token(Token = "0x6000D33")]
			[Address(RVA = "0xAFBCA8", Offset = "0xAFBCA8", VA = "0xAFBCA8")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000013")]
		public event EntitlementCreateHandler OnEntitlementCreate
		{
			[Token(Token = "0x6000D34")]
			[Address(RVA = "0xAFBDBC", Offset = "0xAFBDBC", VA = "0xAFBDBC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000D35")]
			[Address(RVA = "0xAFBE58", Offset = "0xAFBE58", VA = "0xAFBE58")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event EntitlementDeleteHandler OnEntitlementDelete
		{
			[Token(Token = "0x6000D36")]
			[Address(RVA = "0xAFBEF4", Offset = "0xAFBEF4", VA = "0xAFBEF4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000D37")]
			[Address(RVA = "0xAFBF90", Offset = "0xAFBF90", VA = "0xAFBF90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000D38")]
		[Address(RVA = "0xAFC02C", Offset = "0xAFC02C", VA = "0xAFC02C")]
		internal StoreManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000D39")]
		[Address(RVA = "0xAFC0FC", Offset = "0xAFC0FC", VA = "0xAFC0FC")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000D3A")]
		[Address(RVA = "0xAFB91C", Offset = "0xAFB91C", VA = "0xAFB91C")]
		[MonoPInvokeCallback]
		private static void FetchSkusCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000D3B")]
		[Address(RVA = "0xAFC3A0", Offset = "0xAFC3A0", VA = "0xAFC3A0")]
		public void FetchSkus(FetchSkusHandler callback)
		{
		}

		[Token(Token = "0x6000D3C")]
		[Address(RVA = "0xAFC540", Offset = "0xAFC540", VA = "0xAFC540")]
		public int CountSkus()
		{
			return default(int);
		}

		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0xAFC58C", Offset = "0xAFC58C", VA = "0xAFC58C")]
		public Sku GetSku(long skuId)
		{
			return default(Sku);
		}

		[Token(Token = "0x6000D3E")]
		[Address(RVA = "0xAFC648", Offset = "0xAFC648", VA = "0xAFC648")]
		public Sku GetSkuAt(int index)
		{
			return default(Sku);
		}

		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0xAFB9C8", Offset = "0xAFB9C8", VA = "0xAFB9C8")]
		[MonoPInvokeCallback]
		private static void FetchEntitlementsCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000D40")]
		[Address(RVA = "0xAFC704", Offset = "0xAFC704", VA = "0xAFC704")]
		public void FetchEntitlements(FetchEntitlementsHandler callback)
		{
		}

		[Token(Token = "0x6000D41")]
		[Address(RVA = "0xAFC8A4", Offset = "0xAFC8A4", VA = "0xAFC8A4")]
		public int CountEntitlements()
		{
			return default(int);
		}

		[Token(Token = "0x6000D42")]
		[Address(RVA = "0xAFC8F0", Offset = "0xAFC8F0", VA = "0xAFC8F0")]
		public Entitlement GetEntitlement(long entitlementId)
		{
			return default(Entitlement);
		}

		[Token(Token = "0x6000D43")]
		[Address(RVA = "0xAFC9A8", Offset = "0xAFC9A8", VA = "0xAFC9A8")]
		public Entitlement GetEntitlementAt(int index)
		{
			return default(Entitlement);
		}

		[Token(Token = "0x6000D44")]
		[Address(RVA = "0xAFCA60", Offset = "0xAFCA60", VA = "0xAFCA60")]
		public bool HasSkuEntitlement(long skuId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D45")]
		[Address(RVA = "0xAFBA74", Offset = "0xAFBA74", VA = "0xAFBA74")]
		[MonoPInvokeCallback]
		private static void StartPurchaseCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000D46")]
		[Address(RVA = "0xAFCB04", Offset = "0xAFCB04", VA = "0xAFCB04")]
		public void StartPurchase(long skuId, StartPurchaseHandler callback)
		{
		}

		[Token(Token = "0x6000D47")]
		[Address(RVA = "0xAFBB20", Offset = "0xAFBB20", VA = "0xAFBB20")]
		[MonoPInvokeCallback]
		private static void OnEntitlementCreateImpl(IntPtr ptr, ref Entitlement entitlement)
		{
		}

		[Token(Token = "0x6000D48")]
		[Address(RVA = "0xAFBBE4", Offset = "0xAFBBE4", VA = "0xAFBBE4")]
		[MonoPInvokeCallback]
		private static void OnEntitlementDeleteImpl(IntPtr ptr, ref Entitlement entitlement)
		{
		}

		[Token(Token = "0x6000D49")]
		[Address(RVA = "0xAFCCAC", Offset = "0xAFCCAC", VA = "0xAFCCAC")]
		public IEnumerable<Entitlement> GetEntitlements()
		{
			return null;
		}

		[Token(Token = "0x6000D4A")]
		[Address(RVA = "0xAFCE14", Offset = "0xAFCE14", VA = "0xAFCE14")]
		public IEnumerable<Sku> GetSkus()
		{
			return null;
		}
	}
	[Token(Token = "0x2000272")]
	public class VoiceManager
	{
		[Token(Token = "0x2000273")]
		internal struct FFIEvents
		{
			[Token(Token = "0x2000274")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SettingsUpdateHandler(IntPtr ptr);

			[Token(Token = "0x4000A52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal SettingsUpdateHandler OnSettingsUpdate;
		}

		[Token(Token = "0x2000275")]
		internal struct FFIMethods
		{
			[Token(Token = "0x2000276")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetInputModeMethod(IntPtr methodsPtr, ref InputMode inputMode);

			[Token(Token = "0x2000277")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SetInputModeCallback(IntPtr ptr, Result result);

			[Token(Token = "0x2000278")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SetInputModeMethod(IntPtr methodsPtr, InputMode inputMode, IntPtr callbackData, SetInputModeCallback callback);

			[Token(Token = "0x2000279")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result IsSelfMuteMethod(IntPtr methodsPtr, ref bool mute);

			[Token(Token = "0x200027A")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SetSelfMuteMethod(IntPtr methodsPtr, bool mute);

			[Token(Token = "0x200027B")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result IsSelfDeafMethod(IntPtr methodsPtr, ref bool deaf);

			[Token(Token = "0x200027C")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SetSelfDeafMethod(IntPtr methodsPtr, bool deaf);

			[Token(Token = "0x200027D")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result IsLocalMuteMethod(IntPtr methodsPtr, long userId, ref bool mute);

			[Token(Token = "0x200027E")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SetLocalMuteMethod(IntPtr methodsPtr, long userId, bool mute);

			[Token(Token = "0x200027F")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetLocalVolumeMethod(IntPtr methodsPtr, long userId, ref byte volume);

			[Token(Token = "0x2000280")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result SetLocalVolumeMethod(IntPtr methodsPtr, long userId, byte volume);

			[Token(Token = "0x4000A53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal GetInputModeMethod GetInputMode;

			[Token(Token = "0x4000A54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal SetInputModeMethod SetInputMode;

			[Token(Token = "0x4000A55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal IsSelfMuteMethod IsSelfMute;

			[Token(Token = "0x4000A56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal SetSelfMuteMethod SetSelfMute;

			[Token(Token = "0x4000A57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal IsSelfDeafMethod IsSelfDeaf;

			[Token(Token = "0x4000A58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal SetSelfDeafMethod SetSelfDeaf;

			[Token(Token = "0x4000A59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal IsLocalMuteMethod IsLocalMute;

			[Token(Token = "0x4000A5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal SetLocalMuteMethod SetLocalMute;

			[Token(Token = "0x4000A5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal GetLocalVolumeMethod GetLocalVolume;

			[Token(Token = "0x4000A5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal SetLocalVolumeMethod SetLocalVolume;
		}

		[Token(Token = "0x2000281")]
		public delegate void SetInputModeHandler(Result result);

		[Token(Token = "0x2000282")]
		public delegate void SettingsUpdateHandler();

		[Token(Token = "0x4000A4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x4000A50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x17000132")]
		private FFIMethods Methods
		{
			[Token(Token = "0x6000D9B")]
			[Address(RVA = "0xAFEE3C", Offset = "0xAFEE3C", VA = "0xAFEE3C")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000015")]
		public event SettingsUpdateHandler OnSettingsUpdate
		{
			[Token(Token = "0x6000D9C")]
			[Address(RVA = "0xAFEF50", Offset = "0xAFEF50", VA = "0xAFEF50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000D9D")]
			[Address(RVA = "0xAFEFEC", Offset = "0xAFEFEC", VA = "0xAFEFEC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0xAFF088", Offset = "0xAFF088", VA = "0xAFF088")]
		internal VoiceManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0xAFF158", Offset = "0xAFF158", VA = "0xAFF158")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000DA0")]
		[Address(RVA = "0xAFF2E8", Offset = "0xAFF2E8", VA = "0xAFF2E8")]
		public InputMode GetInputMode()
		{
			return default(InputMode);
		}

		[Token(Token = "0x6000DA1")]
		[Address(RVA = "0xAFECDC", Offset = "0xAFECDC", VA = "0xAFECDC")]
		[MonoPInvokeCallback]
		private static void SetInputModeCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0xAFF388", Offset = "0xAFF388", VA = "0xAFF388")]
		public void SetInputMode(InputMode inputMode, SetInputModeHandler callback)
		{
		}

		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0xAFF540", Offset = "0xAFF540", VA = "0xAFF540")]
		public bool IsSelfMute()
		{
			return default(bool);
		}

		[Token(Token = "0x6000DA4")]
		[Address(RVA = "0xAFF5E0", Offset = "0xAFF5E0", VA = "0xAFF5E0")]
		public void SetSelfMute(bool mute)
		{
		}

		[Token(Token = "0x6000DA5")]
		[Address(RVA = "0xAFF67C", Offset = "0xAFF67C", VA = "0xAFF67C")]
		public bool IsSelfDeaf()
		{
			return default(bool);
		}

		[Token(Token = "0x6000DA6")]
		[Address(RVA = "0xAFF71C", Offset = "0xAFF71C", VA = "0xAFF71C")]
		public void SetSelfDeaf(bool deaf)
		{
		}

		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0xAFF7B8", Offset = "0xAFF7B8", VA = "0xAFF7B8")]
		public bool IsLocalMute(long userId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000DA8")]
		[Address(RVA = "0xAFF85C", Offset = "0xAFF85C", VA = "0xAFF85C")]
		public void SetLocalMute(long userId, bool mute)
		{
		}

		[Token(Token = "0x6000DA9")]
		[Address(RVA = "0xAFF900", Offset = "0xAFF900", VA = "0xAFF900")]
		public byte GetLocalVolume(long userId)
		{
			return default(byte);
		}

		[Token(Token = "0x6000DAA")]
		[Address(RVA = "0xAFF9A4", Offset = "0xAFF9A4", VA = "0xAFF9A4")]
		public void SetLocalVolume(long userId, byte volume)
		{
		}

		[Token(Token = "0x6000DAB")]
		[Address(RVA = "0xAFED88", Offset = "0xAFED88", VA = "0xAFED88")]
		[MonoPInvokeCallback]
		private static void OnSettingsUpdateImpl(IntPtr ptr)
		{
		}
	}
	[Token(Token = "0x2000283")]
	public class AchievementManager
	{
		[Token(Token = "0x2000284")]
		internal struct FFIEvents
		{
			[Token(Token = "0x2000285")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void UserAchievementUpdateHandler(IntPtr ptr, ref UserAchievement userAchievement);

			[Token(Token = "0x4000A60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal UserAchievementUpdateHandler OnUserAchievementUpdate;
		}

		[Token(Token = "0x2000286")]
		internal struct FFIMethods
		{
			[Token(Token = "0x2000287")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SetUserAchievementCallback(IntPtr ptr, Result result);

			[Token(Token = "0x2000288")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void SetUserAchievementMethod(IntPtr methodsPtr, long achievementId, byte percentComplete, IntPtr callbackData, SetUserAchievementCallback callback);

			[Token(Token = "0x2000289")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void FetchUserAchievementsCallback(IntPtr ptr, Result result);

			[Token(Token = "0x200028A")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void FetchUserAchievementsMethod(IntPtr methodsPtr, IntPtr callbackData, FetchUserAchievementsCallback callback);

			[Token(Token = "0x200028B")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate void CountUserAchievementsMethod(IntPtr methodsPtr, ref int count);

			[Token(Token = "0x200028C")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetUserAchievementMethod(IntPtr methodsPtr, long userAchievementId, ref UserAchievement userAchievement);

			[Token(Token = "0x200028D")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			internal delegate Result GetUserAchievementAtMethod(IntPtr methodsPtr, int index, ref UserAchievement userAchievement);

			[Token(Token = "0x4000A61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal SetUserAchievementMethod SetUserAchievement;

			[Token(Token = "0x4000A62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal FetchUserAchievementsMethod FetchUserAchievements;

			[Token(Token = "0x4000A63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal CountUserAchievementsMethod CountUserAchievements;

			[Token(Token = "0x4000A64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal GetUserAchievementMethod GetUserAchievement;

			[Token(Token = "0x4000A65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal GetUserAchievementAtMethod GetUserAchievementAt;
		}

		[Token(Token = "0x200028E")]
		public delegate void SetUserAchievementHandler(Result result);

		[Token(Token = "0x200028F")]
		public delegate void FetchUserAchievementsHandler(Result result);

		[Token(Token = "0x2000290")]
		public delegate void UserAchievementUpdateHandler(ref UserAchievement userAchievement);

		[Token(Token = "0x4000A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x4000A5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x17000133")]
		private FFIMethods Methods
		{
			[Token(Token = "0x6000DE4")]
			[Address(RVA = "0xB01240", Offset = "0xB01240", VA = "0xB01240")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000016")]
		public event UserAchievementUpdateHandler OnUserAchievementUpdate
		{
			[Token(Token = "0x6000DE5")]
			[Address(RVA = "0xB01358", Offset = "0xB01358", VA = "0xB01358")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000DE6")]
			[Address(RVA = "0xB013F4", Offset = "0xB013F4", VA = "0xB013F4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000DE7")]
		[Address(RVA = "0xB01490", Offset = "0xB01490", VA = "0xB01490")]
		internal AchievementManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000DE8")]
		[Address(RVA = "0xB01560", Offset = "0xB01560", VA = "0xB01560")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000DE9")]
		[Address(RVA = "0xB01024", Offset = "0xB01024", VA = "0xB01024")]
		[MonoPInvokeCallback]
		private static void SetUserAchievementCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000DEA")]
		[Address(RVA = "0xB016F0", Offset = "0xB016F0", VA = "0xB016F0")]
		public void SetUserAchievement(long achievementId, byte percentComplete, SetUserAchievementHandler callback)
		{
		}

		[Token(Token = "0x6000DEB")]
		[Address(RVA = "0xB010D0", Offset = "0xB010D0", VA = "0xB010D0")]
		[MonoPInvokeCallback]
		private static void FetchUserAchievementsCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000DEC")]
		[Address(RVA = "0xB018A8", Offset = "0xB018A8", VA = "0xB018A8")]
		public void FetchUserAchievements(FetchUserAchievementsHandler callback)
		{
		}

		[Token(Token = "0x6000DED")]
		[Address(RVA = "0xB01A48", Offset = "0xB01A48", VA = "0xB01A48")]
		public int CountUserAchievements()
		{
			return default(int);
		}

		[Token(Token = "0x6000DEE")]
		[Address(RVA = "0xB01A94", Offset = "0xB01A94", VA = "0xB01A94")]
		public UserAchievement GetUserAchievement(long userAchievementId)
		{
			return default(UserAchievement);
		}

		[Token(Token = "0x6000DEF")]
		[Address(RVA = "0xB01B44", Offset = "0xB01B44", VA = "0xB01B44")]
		public UserAchievement GetUserAchievementAt(int index)
		{
			return default(UserAchievement);
		}

		[Token(Token = "0x6000DF0")]
		[Address(RVA = "0xB0117C", Offset = "0xB0117C", VA = "0xB0117C")]
		[MonoPInvokeCallback]
		private static void OnUserAchievementUpdateImpl(IntPtr ptr, ref UserAchievement userAchievement)
		{
		}
	}
}
