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
	[Address(RVA = "0xA510C8", Offset = "0xA510C8", VA = "0xA510C8")]
	public static Color Slerp(this Color a, Color b, float t)
	{
		return default(Color);
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xA513A8", Offset = "0xA513A8", VA = "0xA513A8")]
	public static void H(this Color c, int hue0to360, ref Color thisColor)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xA515A0", Offset = "0xA515A0", VA = "0xA515A0")]
	public static void H(this Color c, float hue0to1, ref Color thisColor)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xA515D8", Offset = "0xA515D8", VA = "0xA515D8")]
	public static void S(this Color c, int saturation0to360, ref Color thisColor)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xA5161C", Offset = "0xA5161C", VA = "0xA5161C")]
	public static void S(this Color c, float saturation0to1, ref Color thisColor)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xA51654", Offset = "0xA51654", VA = "0xA51654")]
	public static void B(this Color c, int brightness0to360, ref Color thisColor)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xA51698", Offset = "0xA51698", VA = "0xA51698")]
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
	[Address(RVA = "0xA516D0", Offset = "0xA516D0", VA = "0xA516D0")]
	public HSBColor(float h, float s, float b, float a)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xA516DC", Offset = "0xA516DC", VA = "0xA516DC")]
	public HSBColor(float h, float s, float b)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xA516F0", Offset = "0xA516F0", VA = "0xA516F0")]
	public HSBColor(Color col)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xA51168", Offset = "0xA51168", VA = "0xA51168")]
	public static HSBColor FromColor(Color color)
	{
		return default(HSBColor);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xA513E4", Offset = "0xA513E4", VA = "0xA513E4")]
	public static Color ToColor(HSBColor hsbColor)
	{
		return default(Color);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xA5139C", Offset = "0xA5139C", VA = "0xA5139C")]
	public Color ToColor()
	{
		return default(Color);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xA5170C", Offset = "0xA5170C", VA = "0xA5170C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xA51258", Offset = "0xA51258", VA = "0xA51258")]
	public static HSBColor Lerp(HSBColor a, HSBColor b, float t)
	{
		return default(HSBColor);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xA518E8", Offset = "0xA518E8", VA = "0xA518E8")]
	public static void Test()
	{
	}
}
[Token(Token = "0x2000004")]
public class Test : MonoBehaviour
{
	[Token(Token = "0x6000011")]
	[Address(RVA = "0xA51BD8", Offset = "0xA51BD8", VA = "0xA51BD8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xA51FB8", Offset = "0xA51FB8", VA = "0xA51FB8")]
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
				[Address(RVA = "0xA54454", Offset = "0xA54454", VA = "0xA54454")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700001C")]
			public KeyValuePair<string, JSONNode> Current
			{
				[Token(Token = "0x600005F")]
				[Address(RVA = "0xA544B4", Offset = "0xA544B4", VA = "0xA544B4")]
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			[Token(Token = "0x600005D")]
			[Address(RVA = "0xA54464", Offset = "0xA54464", VA = "0xA54464")]
			public Enumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x600005E")]
			[Address(RVA = "0xA54490", Offset = "0xA54490", VA = "0xA54490")]
			public Enumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x6000060")]
			[Address(RVA = "0xA54580", Offset = "0xA54580", VA = "0xA54580")]
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
				[Address(RVA = "0xA546D8", Offset = "0xA546D8", VA = "0xA546D8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000061")]
			[Address(RVA = "0xA54614", Offset = "0xA54614", VA = "0xA54614")]
			public ValueEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x6000062")]
			[Address(RVA = "0xA54654", Offset = "0xA54654", VA = "0xA54654")]
			public ValueEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x6000063")]
			[Address(RVA = "0xA546C4", Offset = "0xA546C4", VA = "0xA546C4")]
			public ValueEnumerator(Enumerator aEnumerator)
			{
			}

			[Token(Token = "0x6000065")]
			[Address(RVA = "0xA5471C", Offset = "0xA5471C", VA = "0xA5471C")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000066")]
			[Address(RVA = "0xA54720", Offset = "0xA54720", VA = "0xA54720")]
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
				[Address(RVA = "0xA547F4", Offset = "0xA547F4", VA = "0xA547F4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000067")]
			[Address(RVA = "0xA54730", Offset = "0xA54730", VA = "0xA54730")]
			public KeyEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x6000068")]
			[Address(RVA = "0xA54770", Offset = "0xA54770", VA = "0xA54770")]
			public KeyEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x6000069")]
			[Address(RVA = "0xA547E0", Offset = "0xA547E0", VA = "0xA547E0")]
			public KeyEnumerator(Enumerator aEnumerator)
			{
			}

			[Token(Token = "0x600006B")]
			[Address(RVA = "0xA54830", Offset = "0xA54830", VA = "0xA54830")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600006C")]
			[Address(RVA = "0xA54834", Offset = "0xA54834", VA = "0xA54834")]
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
				[Address(RVA = "0xA54844", Offset = "0xA54844", VA = "0xA54844", Slot = "4")]
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			[Token(Token = "0x17000020")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600006F")]
				[Address(RVA = "0xA5484C", Offset = "0xA5484C", VA = "0xA5484C", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600006D")]
			[Address(RVA = "0xA523D0", Offset = "0xA523D0", VA = "0xA523D0")]
			internal LinqEnumerator(JSONNode aNode)
			{
			}

			[Token(Token = "0x6000070")]
			[Address(RVA = "0xA548B0", Offset = "0xA548B0", VA = "0xA548B0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000071")]
			[Address(RVA = "0xA548B8", Offset = "0xA548B8", VA = "0xA548B8", Slot = "5")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000072")]
			[Address(RVA = "0xA548CC", Offset = "0xA548CC", VA = "0xA548CC", Slot = "9")]
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000073")]
			[Address(RVA = "0xA54930", Offset = "0xA54930", VA = "0xA54930", Slot = "8")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000074")]
			[Address(RVA = "0xA549DC", Offset = "0xA549DC", VA = "0xA549DC", Slot = "10")]
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
				[Address(RVA = "0xA54A5C", Offset = "0xA54A5C", VA = "0xA54A5C", Slot = "6")]
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
				[Address(RVA = "0xA54AA4", Offset = "0xA54AA4", VA = "0xA54AA4", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000075")]
			[Address(RVA = "0xA5215C", Offset = "0xA5215C", VA = "0xA5215C")]
			[DebuggerHidden]
			public <get_Children>d__43(int <>1__state)
			{
			}

			[Token(Token = "0x6000076")]
			[Address(RVA = "0xA54A40", Offset = "0xA54A40", VA = "0xA54A40", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000077")]
			[Address(RVA = "0xA54A44", Offset = "0xA54A44", VA = "0xA54A44", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000079")]
			[Address(RVA = "0xA54A64", Offset = "0xA54A64", VA = "0xA54A64", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600007B")]
			[Address(RVA = "0xA54AAC", Offset = "0xA54AAC", VA = "0xA54AAC", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600007C")]
			[Address(RVA = "0xA54B44", Offset = "0xA54B44", VA = "0xA54B44", Slot = "5")]
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
				[Address(RVA = "0xA55194", Offset = "0xA55194", VA = "0xA55194", Slot = "6")]
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
				[Address(RVA = "0xA551DC", Offset = "0xA551DC", VA = "0xA551DC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600007D")]
			[Address(RVA = "0xA52208", Offset = "0xA52208", VA = "0xA52208")]
			[DebuggerHidden]
			public <get_DeepChildren>d__45(int <>1__state)
			{
			}

			[Token(Token = "0x600007E")]
			[Address(RVA = "0xA54B48", Offset = "0xA54B48", VA = "0xA54B48", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600007F")]
			[Address(RVA = "0xA54C00", Offset = "0xA54C00", VA = "0xA54C00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000080")]
			[Address(RVA = "0xA550E4", Offset = "0xA550E4", VA = "0xA550E4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000081")]
			[Address(RVA = "0xA55034", Offset = "0xA55034", VA = "0xA55034")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x6000083")]
			[Address(RVA = "0xA5519C", Offset = "0xA5519C", VA = "0xA5519C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000085")]
			[Address(RVA = "0xA551E4", Offset = "0xA551E4", VA = "0xA551E4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000086")]
			[Address(RVA = "0xA55288", Offset = "0xA55288", VA = "0xA55288", Slot = "5")]
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
			[Address(RVA = "0xA51FC0", Offset = "0xA51FC0", VA = "0xA51FC0", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000015")]
			[Address(RVA = "0xA51FC8", Offset = "0xA51FC8", VA = "0xA51FC8", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public virtual JSONNode this[string aKey]
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0xA51FCC", Offset = "0xA51FCC", VA = "0xA51FCC", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0xA51FD4", Offset = "0xA51FD4", VA = "0xA51FD4", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public virtual string Value
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0xA51FD8", Offset = "0xA51FD8", VA = "0xA51FD8", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0xA52018", Offset = "0xA52018", VA = "0xA52018", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public virtual int Count
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0xA5201C", Offset = "0xA5201C", VA = "0xA5201C", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000006")]
		public virtual bool IsNumber
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0xA52024", Offset = "0xA52024", VA = "0xA52024", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000007")]
		public virtual bool IsString
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0xA5202C", Offset = "0xA5202C", VA = "0xA5202C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public virtual bool IsBoolean
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0xA52034", Offset = "0xA52034", VA = "0xA52034", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		public virtual bool IsNull
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0xA5203C", Offset = "0xA5203C", VA = "0xA5203C", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		public virtual bool IsArray
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0xA52044", Offset = "0xA52044", VA = "0xA52044", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public virtual bool IsObject
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0xA5204C", Offset = "0xA5204C", VA = "0xA5204C", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		public virtual bool Inline
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0xA52054", Offset = "0xA52054", VA = "0xA52054", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0xA5205C", Offset = "0xA5205C", VA = "0xA5205C", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public virtual IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0xA520EC", Offset = "0xA520EC", VA = "0xA520EC", Slot = "27")]
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
			[Address(RVA = "0xA52190", Offset = "0xA52190", VA = "0xA52190")]
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
			[Address(RVA = "0xA52370", Offset = "0xA52370", VA = "0xA52370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		public KeyEnumerator Keys
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0xA52494", Offset = "0xA52494", VA = "0xA52494")]
			get
			{
				return default(KeyEnumerator);
			}
		}

		[Token(Token = "0x17000011")]
		public ValueEnumerator Values
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0xA524D0", Offset = "0xA524D0", VA = "0xA524D0")]
			get
			{
				return default(ValueEnumerator);
			}
		}

		[Token(Token = "0x17000012")]
		public virtual double AsDouble
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0xA5250C", Offset = "0xA5250C", VA = "0xA5250C", Slot = "33")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0xA525B0", Offset = "0xA525B0", VA = "0xA525B0", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public virtual int AsInt
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0xA52638", Offset = "0xA52638", VA = "0xA52638", Slot = "35")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0xA5266C", Offset = "0xA5266C", VA = "0xA5266C", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public virtual float AsFloat
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0xA52684", Offset = "0xA52684", VA = "0xA52684", Slot = "37")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0xA526A4", Offset = "0xA526A4", VA = "0xA526A4", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public virtual bool AsBool
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0xA526B8", Offset = "0xA526B8", VA = "0xA526B8", Slot = "39")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600003C")]
			[Address(RVA = "0xA52770", Offset = "0xA52770", VA = "0xA52770", Slot = "40")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public virtual long AsLong
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0xA527E8", Offset = "0xA527E8", VA = "0xA527E8", Slot = "41")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600003E")]
			[Address(RVA = "0xA5281C", Offset = "0xA5281C", VA = "0xA5281C", Slot = "42")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public virtual ulong AsULong
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0xA52858", Offset = "0xA52858", VA = "0xA52858", Slot = "43")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x6000040")]
			[Address(RVA = "0xA5288C", Offset = "0xA5288C", VA = "0xA5288C", Slot = "44")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0xA528C8", Offset = "0xA528C8", VA = "0xA528C8", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public virtual JSONObject AsObject
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0xA52940", Offset = "0xA52940", VA = "0xA52940", Slot = "46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		internal static StringBuilder EscapeBuilder
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0xA5356C", Offset = "0xA5356C", VA = "0xA5356C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xA52060", Offset = "0xA52060", VA = "0xA52060", Slot = "20")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xA52064", Offset = "0xA52064", VA = "0xA52064", Slot = "21")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xA520C8", Offset = "0xA520C8", VA = "0xA520C8", Slot = "22")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xA520D0", Offset = "0xA520D0", VA = "0xA520D0", Slot = "23")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xA520D8", Offset = "0xA520D8", VA = "0xA520D8", Slot = "24")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xA520E0", Offset = "0xA520E0", VA = "0xA520E0", Slot = "25")]
		public virtual void Clear()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xA520E4", Offset = "0xA520E4", VA = "0xA520E4", Slot = "26")]
		public virtual JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xA5223C", Offset = "0xA5223C", VA = "0xA5223C", Slot = "28")]
		public virtual bool HasKey(string aKey)
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xA52244", Offset = "0xA52244", VA = "0xA52244", Slot = "29")]
		public virtual JSONNode GetValueOrDefault(string aKey, JSONNode aDefault)
		{
			return null;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xA5224C", Offset = "0xA5224C", VA = "0xA5224C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xA522D8", Offset = "0xA522D8", VA = "0xA522D8", Slot = "30")]
		public virtual string ToString(int aIndent)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

		[Token(Token = "0x6000031")]
		public abstract Enumerator GetEnumerator();

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xA529B8", Offset = "0xA529B8", VA = "0xA529B8")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xA52B48", Offset = "0xA52B48", VA = "0xA52B48")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xA52D4C", Offset = "0xA52D4C", VA = "0xA52D4C")]
		public static implicit operator JSONNode(double n)
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xA52E20", Offset = "0xA52E20", VA = "0xA52E20")]
		public static implicit operator double(JSONNode d)
		{
			return default(double);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xA52EA8", Offset = "0xA52EA8", VA = "0xA52EA8")]
		public static implicit operator JSONNode(float n)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xA52F10", Offset = "0xA52F10", VA = "0xA52F10")]
		public static implicit operator float(JSONNode d)
		{
			return default(float);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xA52F98", Offset = "0xA52F98", VA = "0xA52F98")]
		public static implicit operator JSONNode(int n)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xA52FF8", Offset = "0xA52FF8", VA = "0xA52FF8")]
		public static implicit operator int(JSONNode d)
		{
			return default(int);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xA53080", Offset = "0xA53080", VA = "0xA53080")]
		public static implicit operator JSONNode(long n)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xA53164", Offset = "0xA53164", VA = "0xA53164")]
		public static implicit operator long(JSONNode d)
		{
			return default(long);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xA531EC", Offset = "0xA531EC", VA = "0xA531EC")]
		public static implicit operator JSONNode(ulong n)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xA532D0", Offset = "0xA532D0", VA = "0xA532D0")]
		public static implicit operator ulong(JSONNode d)
		{
			return default(ulong);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xA53358", Offset = "0xA53358", VA = "0xA53358")]
		public static implicit operator JSONNode(bool b)
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xA53424", Offset = "0xA53424", VA = "0xA53424")]
		public static implicit operator bool(JSONNode d)
		{
			return default(bool);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xA534AC", Offset = "0xA534AC", VA = "0xA534AC")]
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue)
		{
			return null;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xA52BCC", Offset = "0xA52BCC", VA = "0xA52BCC")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xA534E8", Offset = "0xA534E8", VA = "0xA534E8")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xA53558", Offset = "0xA53558", VA = "0xA53558", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xA53564", Offset = "0xA53564", VA = "0xA53564", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xA53638", Offset = "0xA53638", VA = "0xA53638")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xA53928", Offset = "0xA53928", VA = "0xA53928")]
		private static JSONNode ParseElement(string token, bool quoted)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xA53B04", Offset = "0xA53B04", VA = "0xA53B04")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xA543FC", Offset = "0xA543FC", VA = "0xA543FC")]
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
				[Address(RVA = "0xA56080", Offset = "0xA56080", VA = "0xA56080", Slot = "6")]
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
				[Address(RVA = "0xA560C8", Offset = "0xA560C8", VA = "0xA560C8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000099")]
			[Address(RVA = "0xA55CE4", Offset = "0xA55CE4", VA = "0xA55CE4")]
			[DebuggerHidden]
			public <get_Children>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0xA55E80", Offset = "0xA55E80", VA = "0xA55E80", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600009B")]
			[Address(RVA = "0xA55E9C", Offset = "0xA55E9C", VA = "0xA55E9C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600009C")]
			[Address(RVA = "0xA56030", Offset = "0xA56030", VA = "0xA56030")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600009E")]
			[Address(RVA = "0xA56088", Offset = "0xA56088", VA = "0xA56088", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000A0")]
			[Address(RVA = "0xA560D0", Offset = "0xA560D0", VA = "0xA560D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60000A1")]
			[Address(RVA = "0xA56174", Offset = "0xA56174", VA = "0xA56174", Slot = "5")]
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
			[Address(RVA = "0xA5528C", Offset = "0xA5528C", VA = "0xA5528C", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000088")]
			[Address(RVA = "0xA55294", Offset = "0xA55294", VA = "0xA55294", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0xA552A0", Offset = "0xA552A0", VA = "0xA552A0", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000027")]
		public override bool IsArray
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0xA552A8", Offset = "0xA552A8", VA = "0xA552A8", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000028")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0xA5533C", Offset = "0xA5533C", VA = "0xA5533C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008D")]
			[Address(RVA = "0xA55458", Offset = "0xA55458", VA = "0xA55458", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0xA555C0", Offset = "0xA555C0", VA = "0xA555C0", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008F")]
			[Address(RVA = "0xA55620", Offset = "0xA55620", VA = "0xA55620", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public override int Count
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0xA55734", Offset = "0xA55734", VA = "0xA55734", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002B")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0xA55C6C", Offset = "0xA55C6C", VA = "0xA55C6C", Slot = "27")]
			[IteratorStateMachine(typeof(<get_Children>d__24))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xA552B0", Offset = "0xA552B0", VA = "0xA552B0", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xA5577C", Offset = "0xA5577C", VA = "0xA5577C", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xA55890", Offset = "0xA55890", VA = "0xA55890", Slot = "23")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xA55944", Offset = "0xA55944", VA = "0xA55944", Slot = "24")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xA559A4", Offset = "0xA559A4", VA = "0xA559A4", Slot = "25")]
		public override void Clear()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xA55A14", Offset = "0xA55A14", VA = "0xA55A14", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xA55D18", Offset = "0xA55D18", VA = "0xA55D18", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xA5435C", Offset = "0xA5435C", VA = "0xA5435C")]
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
				[Address(RVA = "0xA574DC", Offset = "0xA574DC", VA = "0xA574DC", Slot = "6")]
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
				[Address(RVA = "0xA57524", Offset = "0xA57524", VA = "0xA57524", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B9")]
			[Address(RVA = "0xA56EE0", Offset = "0xA56EE0", VA = "0xA56EE0")]
			[DebuggerHidden]
			public <get_Children>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x60000BA")]
			[Address(RVA = "0xA572C8", Offset = "0xA572C8", VA = "0xA572C8", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000BB")]
			[Address(RVA = "0xA572E4", Offset = "0xA572E4", VA = "0xA572E4", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000BC")]
			[Address(RVA = "0xA5748C", Offset = "0xA5748C", VA = "0xA5748C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60000BE")]
			[Address(RVA = "0xA574E4", Offset = "0xA574E4", VA = "0xA574E4", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60000C0")]
			[Address(RVA = "0xA5752C", Offset = "0xA5752C", VA = "0xA5752C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60000C1")]
			[Address(RVA = "0xA575D0", Offset = "0xA575D0", VA = "0xA575D0", Slot = "5")]
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
			[Address(RVA = "0xA56178", Offset = "0xA56178", VA = "0xA56178", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0xA56180", Offset = "0xA56180", VA = "0xA56180", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0xA5618C", Offset = "0xA5618C", VA = "0xA5618C", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000030")]
		public override bool IsObject
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0xA56194", Offset = "0xA56194", VA = "0xA56194", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000031")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0xA56224", Offset = "0xA56224", VA = "0xA56224", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0xA56358", Offset = "0xA56358", VA = "0xA56358", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0xA56484", Offset = "0xA56484", VA = "0xA56484", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0xA56524", Offset = "0xA56524", VA = "0xA56524", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public override int Count
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0xA56660", Offset = "0xA56660", VA = "0xA56660", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000034")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0xA56E68", Offset = "0xA56E68", VA = "0xA56E68", Slot = "27")]
			[IteratorStateMachine(typeof(<get_Children>d__27))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xA5619C", Offset = "0xA5619C", VA = "0xA5619C", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xA566B0", Offset = "0xA566B0", VA = "0xA566B0", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xA56818", Offset = "0xA56818", VA = "0xA56818", Slot = "22")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xA568DC", Offset = "0xA568DC", VA = "0xA568DC", Slot = "23")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xA569B8", Offset = "0xA569B8", VA = "0xA569B8", Slot = "24")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xA56B80", Offset = "0xA56B80", VA = "0xA56B80", Slot = "25")]
		public override void Clear()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xA56BD0", Offset = "0xA56BD0", VA = "0xA56BD0", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xA56D94", Offset = "0xA56D94", VA = "0xA56D94", Slot = "28")]
		public override bool HasKey(string aKey)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xA56DEC", Offset = "0xA56DEC", VA = "0xA56DEC", Slot = "29")]
		public override JSONNode GetValueOrDefault(string aKey, JSONNode aDefault)
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xA56F14", Offset = "0xA56F14", VA = "0xA56F14", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xA542BC", Offset = "0xA542BC", VA = "0xA542BC")]
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
			[Address(RVA = "0xA575D4", Offset = "0xA575D4", VA = "0xA575D4", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000038")]
		public override bool IsString
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0xA575DC", Offset = "0xA575DC", VA = "0xA575DC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public override string Value
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0xA575F8", Offset = "0xA575F8", VA = "0xA575F8", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0xA57600", Offset = "0xA57600", VA = "0xA57600", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xA575E4", Offset = "0xA575E4", VA = "0xA575E4", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xA52A4C", Offset = "0xA52A4C", VA = "0xA52A4C")]
		public JSONString(string aData)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xA57608", Offset = "0xA57608", VA = "0xA57608", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xA5766C", Offset = "0xA5766C", VA = "0xA5766C", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xA5770C", Offset = "0xA5770C", VA = "0xA5770C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xA5781C", Offset = "0xA5781C", VA = "0xA5781C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xA5783C", Offset = "0xA5783C", VA = "0xA5783C", Slot = "25")]
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
			[Address(RVA = "0xA57884", Offset = "0xA57884", VA = "0xA57884", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x1700003B")]
		public override bool IsNumber
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0xA5788C", Offset = "0xA5788C", VA = "0xA5788C", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		public override string Value
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0xA578A8", Offset = "0xA578A8", VA = "0xA578A8", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0xA57910", Offset = "0xA57910", VA = "0xA57910", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public override double AsDouble
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0xA5799C", Offset = "0xA5799C", VA = "0xA5799C", Slot = "33")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0xA579A4", Offset = "0xA579A4", VA = "0xA579A4", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public override long AsLong
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0xA579AC", Offset = "0xA579AC", VA = "0xA579AC", Slot = "41")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0xA579CC", Offset = "0xA579CC", VA = "0xA579CC", Slot = "42")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public override ulong AsULong
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0xA579D8", Offset = "0xA579D8", VA = "0xA579D8", Slot = "43")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0xA579F0", Offset = "0xA579F0", VA = "0xA579F0", Slot = "44")]
			set
			{
			}
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xA57894", Offset = "0xA57894", VA = "0xA57894", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xA52DB4", Offset = "0xA52DB4", VA = "0xA52DB4")]
		public JSONNumber(double aData)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xA579FC", Offset = "0xA579FC", VA = "0xA579FC")]
		public JSONNumber(string aData)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xA57A74", Offset = "0xA57A74", VA = "0xA57A74", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xA57AE0", Offset = "0xA57AE0", VA = "0xA57AE0", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xA57B14", Offset = "0xA57B14", VA = "0xA57B14")]
		private static bool IsNumeric(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xA57CB4", Offset = "0xA57CB4", VA = "0xA57CB4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xA57DD8", Offset = "0xA57DD8", VA = "0xA57DD8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xA57E48", Offset = "0xA57E48", VA = "0xA57E48", Slot = "25")]
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
			[Address(RVA = "0xA57E50", Offset = "0xA57E50", VA = "0xA57E50", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000041")]
		public override bool IsBoolean
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0xA57E58", Offset = "0xA57E58", VA = "0xA57E58", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000042")]
		public override string Value
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0xA57E74", Offset = "0xA57E74", VA = "0xA57E74", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0xA57E80", Offset = "0xA57E80", VA = "0xA57E80", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public override bool AsBool
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0xA57EFC", Offset = "0xA57EFC", VA = "0xA57EFC", Slot = "39")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0xA57F04", Offset = "0xA57F04", VA = "0xA57F04", Slot = "40")]
			set
			{
			}
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xA57E60", Offset = "0xA57E60", VA = "0xA57E60", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xA533B8", Offset = "0xA533B8", VA = "0xA533B8")]
		public JSONBool(bool aData)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xA57F10", Offset = "0xA57F10", VA = "0xA57F10")]
		public JSONBool(string aData)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xA57F88", Offset = "0xA57F88", VA = "0xA57F88", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xA57FF0", Offset = "0xA57FF0", VA = "0xA57FF0", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xA58068", Offset = "0xA58068", VA = "0xA58068", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xA580E0", Offset = "0xA580E0", VA = "0xA580E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xA580EC", Offset = "0xA580EC", VA = "0xA580EC", Slot = "25")]
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
			[Address(RVA = "0xA5814C", Offset = "0xA5814C", VA = "0xA5814C", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000045")]
		public override bool IsNull
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0xA58154", Offset = "0xA58154", VA = "0xA58154", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		public override string Value
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0xA58170", Offset = "0xA58170", VA = "0xA58170", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0xA581B0", Offset = "0xA581B0", VA = "0xA581B0", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public override bool AsBool
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0xA581B4", Offset = "0xA581B4", VA = "0xA581B4", Slot = "39")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0xA581BC", Offset = "0xA581BC", VA = "0xA581BC", Slot = "40")]
			set
			{
			}
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xA52AB8", Offset = "0xA52AB8", VA = "0xA52AB8")]
		public static JSONNull CreateOrGet()
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xA580F4", Offset = "0xA580F4", VA = "0xA580F4")]
		private JSONNull()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xA5815C", Offset = "0xA5815C", VA = "0xA5815C", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xA581C0", Offset = "0xA581C0", VA = "0xA581C0", Slot = "26")]
		public override JSONNode Clone()
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xA5820C", Offset = "0xA5820C", VA = "0xA5820C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xA58298", Offset = "0xA58298", VA = "0xA58298", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xA582A0", Offset = "0xA582A0", VA = "0xA582A0", Slot = "31")]
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
			[Address(RVA = "0xA58364", Offset = "0xA58364", VA = "0xA58364", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000049")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0xA58380", Offset = "0xA58380", VA = "0xA58380", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000102")]
			[Address(RVA = "0xA583E0", Offset = "0xA583E0", VA = "0xA583E0", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0xA5847C", Offset = "0xA5847C", VA = "0xA5847C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000104")]
			[Address(RVA = "0xA584EC", Offset = "0xA584EC", VA = "0xA584EC", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public override int AsInt
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0xA58720", Offset = "0xA58720", VA = "0xA58720", Slot = "35")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600010C")]
			[Address(RVA = "0xA587A4", Offset = "0xA587A4", VA = "0xA587A4", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public override float AsFloat
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0xA5882C", Offset = "0xA5882C", VA = "0xA5882C", Slot = "37")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0xA588B0", Offset = "0xA588B0", VA = "0xA588B0", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public override double AsDouble
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0xA58938", Offset = "0xA58938", VA = "0xA58938", Slot = "33")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000110")]
			[Address(RVA = "0xA589BC", Offset = "0xA589BC", VA = "0xA589BC", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public override long AsLong
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0xA58A44", Offset = "0xA58A44", VA = "0xA58A44", Slot = "41")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0xA58B54", Offset = "0xA58B54", VA = "0xA58B54", Slot = "42")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public override ulong AsULong
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0xA58C88", Offset = "0xA58C88", VA = "0xA58C88", Slot = "43")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x6000114")]
			[Address(RVA = "0xA58D98", Offset = "0xA58D98", VA = "0xA58D98", Slot = "44")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public override bool AsBool
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0xA58ECC", Offset = "0xA58ECC", VA = "0xA58ECC", Slot = "39")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000116")]
			[Address(RVA = "0xA58F50", Offset = "0xA58F50", VA = "0xA58F50", Slot = "40")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0xA58FD8", Offset = "0xA58FD8", VA = "0xA58FD8", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public override JSONObject AsObject
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0xA59050", Offset = "0xA59050", VA = "0xA59050", Slot = "46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xA5836C", Offset = "0xA5836C", VA = "0xA5836C", Slot = "32")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xA553EC", Offset = "0xA553EC", VA = "0xA553EC")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xA562E8", Offset = "0xA562E8", VA = "0xA562E8")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x6000100")]
		private T Set<T>(T aVal) where T : JSONNode
		{
			return null;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xA58590", Offset = "0xA58590", VA = "0xA58590", Slot = "21")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xA5862C", Offset = "0xA5862C", VA = "0xA5862C", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xA586D0", Offset = "0xA586D0", VA = "0xA586D0")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xA586E8", Offset = "0xA586E8", VA = "0xA586E8")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xA58700", Offset = "0xA58700", VA = "0xA58700", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xA58718", Offset = "0xA58718", VA = "0xA58718", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xA590C8", Offset = "0xA590C8", VA = "0xA590C8", Slot = "31")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}
	}
	[Token(Token = "0x2000019")]
	public static class JSON
	{
		[Token(Token = "0x600011A")]
		[Address(RVA = "0xA5911C", Offset = "0xA5911C", VA = "0xA5911C")]
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
			[Address(RVA = "0xA59280", Offset = "0xA59280", VA = "0xA59280")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000120")]
			[Address(RVA = "0xA59288", Offset = "0xA59288", VA = "0xA59288")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public float bakingProgress
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0xA59294", Offset = "0xA59294", VA = "0xA59294")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000122")]
			[Address(RVA = "0xA5929C", Offset = "0xA5929C", VA = "0xA5929C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000055")]
		protected float clipLength
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0xA592A4", Offset = "0xA592A4", VA = "0xA592A4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000129")]
			[Address(RVA = "0xA592AC", Offset = "0xA592AC", VA = "0xA592AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xA59170", Offset = "0xA59170", VA = "0xA59170")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xA591B4", Offset = "0xA591B4", VA = "0xA591B4")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xA591F8", Offset = "0xA591F8", VA = "0xA591F8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xA5923C", Offset = "0xA5923C", VA = "0xA5923C")]
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
		[Address(RVA = "0xA592B4", Offset = "0xA592B4", VA = "0xA592B4")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xA592B8", Offset = "0xA592B8", VA = "0xA592B8")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xA592BC", Offset = "0xA592BC", VA = "0xA592BC")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xA592C0", Offset = "0xA592C0", VA = "0xA592C0")]
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
		[Address(RVA = "0xA593B8", Offset = "0xA593B8", VA = "0xA593B8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xA597D4", Offset = "0xA597D4", VA = "0xA597D4", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xA597DC", Offset = "0xA597DC", VA = "0xA597DC", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xA599C8", Offset = "0xA599C8", VA = "0xA599C8", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xA59C2C", Offset = "0xA59C2C", VA = "0xA59C2C", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xA59F44", Offset = "0xA59F44", VA = "0xA59F44", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xA595D0", Offset = "0xA595D0", VA = "0xA595D0")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xA59688", Offset = "0xA59688", VA = "0xA59688")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xA5A1A4", Offset = "0xA5A1A4", VA = "0xA5A1A4")]
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
		[Address(RVA = "0xA5A200", Offset = "0xA5A200", VA = "0xA5A200")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class AvatarUtility
	{
		[Token(Token = "0x6000138")]
		[Address(RVA = "0xA5A264", Offset = "0xA5A264", VA = "0xA5A264")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xA5A4B4", Offset = "0xA5A4B4", VA = "0xA5A4B4")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xA5A494", Offset = "0xA5A494", VA = "0xA5A494")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xA5AB0C", Offset = "0xA5AB0C", VA = "0xA5AB0C")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public static class BakerUtilities
	{
		[Token(Token = "0x600013C")]
		[Address(RVA = "0xA5AB14", Offset = "0xA5AB14", VA = "0xA5AB14")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xA5AB4C", Offset = "0xA5AB4C", VA = "0xA5AB4C")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xA5AF10", Offset = "0xA5AF10", VA = "0xA5AF10")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xA5B0F0", Offset = "0xA5B0F0", VA = "0xA5B0F0")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xA5B0F4", Offset = "0xA5B0F4", VA = "0xA5B0F4")]
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
		[Address(RVA = "0xA5B288", Offset = "0xA5B288", VA = "0xA5B288")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xA5B544", Offset = "0xA5B544", VA = "0xA5B544")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xA5B400", Offset = "0xA5B400", VA = "0xA5B400")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xA5B6CC", Offset = "0xA5B6CC", VA = "0xA5B6CC")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xA5BA5C", Offset = "0xA5BA5C", VA = "0xA5BA5C")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xA5BB4C", Offset = "0xA5BB4C", VA = "0xA5BB4C")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xA5BC30", Offset = "0xA5BC30", VA = "0xA5BC30")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xA5BBB4", Offset = "0xA5BBB4", VA = "0xA5BBB4")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xA5BC98", Offset = "0xA5BC98", VA = "0xA5BC98")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xA5BD40", Offset = "0xA5BD40", VA = "0xA5BD40")]
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
		[Address(RVA = "0xA5C02C", Offset = "0xA5C02C", VA = "0xA5C02C")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xA5C090", Offset = "0xA5C090", VA = "0xA5C090")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xA5CB24", Offset = "0xA5CB24", VA = "0xA5CB24")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xA5CBCC", Offset = "0xA5CBCC", VA = "0xA5CBCC")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xA5CAC4", Offset = "0xA5CAC4", VA = "0xA5CAC4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xA5CCC0", Offset = "0xA5CCC0", VA = "0xA5CCC0")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xA5CCFC", Offset = "0xA5CCFC", VA = "0xA5CCFC")]
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
		[Address(RVA = "0xA59740", Offset = "0xA59740", VA = "0xA59740")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xA599B4", Offset = "0xA599B4", VA = "0xA599B4")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xA59C90", Offset = "0xA59C90", VA = "0xA59C90")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xA5CD04", Offset = "0xA5CD04", VA = "0xA5CD04")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xA598AC", Offset = "0xA598AC", VA = "0xA598AC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xA5CF8C", Offset = "0xA5CF8C", VA = "0xA5CF8C")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xA59FB0", Offset = "0xA59FB0", VA = "0xA59FB0")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xA59A34", Offset = "0xA59A34", VA = "0xA59A34")]
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
		[Address(RVA = "0xA5CFF4", Offset = "0xA5CFF4", VA = "0xA5CFF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xA5D4AC", Offset = "0xA5D4AC", VA = "0xA5D4AC", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xA5D4C8", Offset = "0xA5D4C8", VA = "0xA5D4C8", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xA5D5A4", Offset = "0xA5D5A4", VA = "0xA5D5A4", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xA5D660", Offset = "0xA5D660", VA = "0xA5D660", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xA5D800", Offset = "0xA5D800", VA = "0xA5D800", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xA5DB14", Offset = "0xA5DB14", VA = "0xA5DB14")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xA5DBEC", Offset = "0xA5DBEC", VA = "0xA5DBEC")]
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
			[Address(RVA = "0xA5DC90", Offset = "0xA5DC90", VA = "0xA5DC90")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000163")]
			[Address(RVA = "0xA5DC98", Offset = "0xA5DC98", VA = "0xA5DC98")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public float y
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0xA5DCA0", Offset = "0xA5DCA0", VA = "0xA5DCA0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000165")]
			[Address(RVA = "0xA5DCA8", Offset = "0xA5DCA8", VA = "0xA5DCA8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public float distanceTarget
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0xA5DCB0", Offset = "0xA5DCB0", VA = "0xA5DCB0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000167")]
			[Address(RVA = "0xA5DCB8", Offset = "0xA5DCB8", VA = "0xA5DCB8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000059")]
		private float zoomAdd
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0xA5E710", Offset = "0xA5E710", VA = "0xA5E710")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xA5DCC0", Offset = "0xA5DCC0", VA = "0xA5DCC0")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xA5DCF8", Offset = "0xA5DCF8", VA = "0xA5DCF8")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xA5DD00", Offset = "0xA5DD00", VA = "0xA5DD00", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xA5DE28", Offset = "0xA5DE28", VA = "0xA5DE28", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xA5DE70", Offset = "0xA5DE70", VA = "0xA5DE70", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xA5DEC8", Offset = "0xA5DEC8", VA = "0xA5DEC8", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xA5DF20", Offset = "0xA5DF20", VA = "0xA5DF20")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xA5DE54", Offset = "0xA5DE54", VA = "0xA5DE54")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xA5E0AC", Offset = "0xA5E0AC", VA = "0xA5E0AC")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xA5E6D4", Offset = "0xA5E6D4", VA = "0xA5E6D4")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xA5E77C", Offset = "0xA5E77C", VA = "0xA5E77C")]
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
		[Address(RVA = "0xA5E844", Offset = "0xA5E844", VA = "0xA5E844")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xA5E870", Offset = "0xA5E870", VA = "0xA5E870")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xA5EA94", Offset = "0xA5EA94", VA = "0xA5EA94")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xA5EAD0", Offset = "0xA5EAD0", VA = "0xA5EAD0")]
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
		[Address(RVA = "0xA5EAEC", Offset = "0xA5EAEC", VA = "0xA5EAEC")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xA5EBCC", Offset = "0xA5EBCC", VA = "0xA5EBCC")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xA5EC04", Offset = "0xA5EC04", VA = "0xA5EC04")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xA5ED4C", Offset = "0xA5ED4C", VA = "0xA5ED4C")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xA5ED00", Offset = "0xA5ED00", VA = "0xA5ED00")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xA5EE48", Offset = "0xA5EE48", VA = "0xA5EE48")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xA5EE8C", Offset = "0xA5EE8C", VA = "0xA5EE8C")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xA5F318", Offset = "0xA5F318", VA = "0xA5F318")]
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
			[Address(RVA = "0xA5F614", Offset = "0xA5F614", VA = "0xA5F614")]
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
			[Address(RVA = "0xA5F360", Offset = "0xA5F360", VA = "0xA5F360")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0xA5F688", Offset = "0xA5F688", VA = "0xA5F688")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xA5F320", Offset = "0xA5F320", VA = "0xA5F320")]
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
		[Address(RVA = "0xA5F93C", Offset = "0xA5F93C", VA = "0xA5F93C")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xA5FC00", Offset = "0xA5FC00", VA = "0xA5FC00")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xA5FE34", Offset = "0xA5FE34", VA = "0xA5FE34")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xA5FEA8", Offset = "0xA5FEA8", VA = "0xA5FEA8")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xA5FF3C", Offset = "0xA5FF3C", VA = "0xA5FF3C")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xA5FAE8", Offset = "0xA5FAE8", VA = "0xA5FAE8")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xA5FDAC", Offset = "0xA5FDAC", VA = "0xA5FDAC")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xA60674", Offset = "0xA60674", VA = "0xA60674")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xA604CC", Offset = "0xA604CC", VA = "0xA604CC")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xA605A0", Offset = "0xA605A0", VA = "0xA605A0")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xA60124", Offset = "0xA60124", VA = "0xA60124")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xA601C0", Offset = "0xA601C0", VA = "0xA601C0")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xA6025C", Offset = "0xA6025C", VA = "0xA6025C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xA602F8", Offset = "0xA602F8", VA = "0xA602F8")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xA60394", Offset = "0xA60394", VA = "0xA60394")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xA60430", Offset = "0xA60430", VA = "0xA60430")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xA6085C", Offset = "0xA6085C", VA = "0xA6085C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xA60050", Offset = "0xA60050", VA = "0xA60050")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xA607D8", Offset = "0xA607D8", VA = "0xA607D8")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xA608BC", Offset = "0xA608BC", VA = "0xA608BC")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xA6097C", Offset = "0xA6097C", VA = "0xA6097C")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xA60764", Offset = "0xA60764", VA = "0xA60764")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xA606F4", Offset = "0xA606F4", VA = "0xA606F4")]
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
				[Address(RVA = "0xA661E4", Offset = "0xA661E4", VA = "0xA661E4")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xA661D0", Offset = "0xA661D0", VA = "0xA661D0")]
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
			[Address(RVA = "0xA62974", Offset = "0xA62974", VA = "0xA62974", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		public bool isEmpty
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0xA62CD0", Offset = "0xA62CD0", VA = "0xA62CD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xA62CE0", Offset = "0xA62CE0", VA = "0xA62CE0", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xA6306C", Offset = "0xA6306C", VA = "0xA6306C", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xA633FC", Offset = "0xA633FC", VA = "0xA633FC")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xA63A28", Offset = "0xA63A28", VA = "0xA63A28")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xA63664", Offset = "0xA63664", VA = "0xA63664")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xA64170", Offset = "0xA64170", VA = "0xA64170")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xA64250", Offset = "0xA64250", VA = "0xA64250")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xA64CC8", Offset = "0xA64CC8", VA = "0xA64CC8")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xA64AE8", Offset = "0xA64AE8", VA = "0xA64AE8")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xA64888", Offset = "0xA64888", VA = "0xA64888")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xA642EC", Offset = "0xA642EC", VA = "0xA642EC")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xA64BDC", Offset = "0xA64BDC", VA = "0xA64BDC")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xA64DA8", Offset = "0xA64DA8", VA = "0xA64DA8")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xA65868", Offset = "0xA65868", VA = "0xA65868")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xA65328", Offset = "0xA65328", VA = "0xA65328")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xA65B3C", Offset = "0xA65B3C", VA = "0xA65B3C")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xA6567C", Offset = "0xA6567C", VA = "0xA6567C")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xA65B44", Offset = "0xA65B44", VA = "0xA65B44")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xA65B4C", Offset = "0xA65B4C", VA = "0xA65B4C")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xA65D00", Offset = "0xA65D00", VA = "0xA65D00")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xA66168", Offset = "0xA66168", VA = "0xA66168")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xA635FC", Offset = "0xA635FC", VA = "0xA635FC")]
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
		[Address(RVA = "0xA661EC", Offset = "0xA661EC", VA = "0xA661EC")]
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
		[Address(RVA = "0xA661F4", Offset = "0xA661F4", VA = "0xA661F4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xA662EC", Offset = "0xA662EC", VA = "0xA662EC")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class Hierarchy
	{
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xA660E4", Offset = "0xA660E4", VA = "0xA660E4")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xA65FD8", Offset = "0xA65FD8", VA = "0xA65FD8")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xA643C8", Offset = "0xA643C8", VA = "0xA643C8")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xA649D8", Offset = "0xA649D8", VA = "0xA649D8")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xA64648", Offset = "0xA64648", VA = "0xA64648")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xA662FC", Offset = "0xA662FC", VA = "0xA662FC")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xA644F8", Offset = "0xA644F8", VA = "0xA644F8")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xA663F0", Offset = "0xA663F0", VA = "0xA663F0")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xA6675C", Offset = "0xA6675C", VA = "0xA6675C")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xA66554", Offset = "0xA66554", VA = "0xA66554")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xA668E4", Offset = "0xA668E4", VA = "0xA668E4")]
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
		[Address(RVA = "0xA668EC", Offset = "0xA668EC", VA = "0xA668EC")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xA66954", Offset = "0xA66954", VA = "0xA66954")]
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
		[Address(RVA = "0xA669BC", Offset = "0xA669BC", VA = "0xA669BC")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xA67344", Offset = "0xA67344", VA = "0xA67344")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xA673B4", Offset = "0xA673B4", VA = "0xA673B4")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xA66DBC", Offset = "0xA66DBC", VA = "0xA66DBC")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xA66DC8", Offset = "0xA66DC8", VA = "0xA66DC8")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xA66DEC", Offset = "0xA66DEC", VA = "0xA66DEC")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xA66E28", Offset = "0xA66E28", VA = "0xA66E28")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xA66E40", Offset = "0xA66E40", VA = "0xA66E40")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xA66E54", Offset = "0xA66E54", VA = "0xA66E54")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xA66E68", Offset = "0xA66E68", VA = "0xA66E68")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xA66E78", Offset = "0xA66E78", VA = "0xA66E78")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xA66EC0", Offset = "0xA66EC0", VA = "0xA66EC0")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xA66EF8", Offset = "0xA66EF8", VA = "0xA66EF8")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xA66F20", Offset = "0xA66F20", VA = "0xA66F20")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xA67424", Offset = "0xA67424", VA = "0xA67424")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xA66F54", Offset = "0xA66F54", VA = "0xA66F54")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xA66F7C", Offset = "0xA66F7C", VA = "0xA66F7C")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xA66FAC", Offset = "0xA66FAC", VA = "0xA66FAC")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xA66FE0", Offset = "0xA66FE0", VA = "0xA66FE0")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xA67024", Offset = "0xA67024", VA = "0xA67024")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xA67088", Offset = "0xA67088", VA = "0xA67088")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xA670EC", Offset = "0xA670EC", VA = "0xA670EC")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xA67140", Offset = "0xA67140", VA = "0xA67140")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xA67194", Offset = "0xA67194", VA = "0xA67194")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xA671CC", Offset = "0xA671CC", VA = "0xA671CC")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xA67200", Offset = "0xA67200", VA = "0xA67200")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xA67458", Offset = "0xA67458", VA = "0xA67458")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xA67244", Offset = "0xA67244", VA = "0xA67244")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xA672D4", Offset = "0xA672D4", VA = "0xA672D4")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xA67304", Offset = "0xA67304", VA = "0xA67304")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xA674E8", Offset = "0xA674E8", VA = "0xA674E8")]
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
		[Address(RVA = "0xA684F0", Offset = "0xA684F0", VA = "0xA684F0")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xA68558", Offset = "0xA68558", VA = "0xA68558")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000037")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xA685C0", Offset = "0xA685C0", VA = "0xA685C0")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xA6860C", Offset = "0xA6860C", VA = "0xA6860C")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xA686C8", Offset = "0xA686C8", VA = "0xA686C8")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xA68620", Offset = "0xA68620", VA = "0xA68620")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xA686DC", Offset = "0xA686DC", VA = "0xA686DC")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xA6876C", Offset = "0xA6876C", VA = "0xA6876C")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xA68794", Offset = "0xA68794", VA = "0xA68794")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xA687E0", Offset = "0xA687E0", VA = "0xA687E0")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xA68848", Offset = "0xA68848", VA = "0xA68848")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xA6899C", Offset = "0xA6899C", VA = "0xA6899C")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xA68AD4", Offset = "0xA68AD4", VA = "0xA68AD4")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xA68B2C", Offset = "0xA68B2C", VA = "0xA68B2C")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000038")]
	public static class QuaTools
	{
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xA68B50", Offset = "0xA68B50", VA = "0xA68B50")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xA68BA8", Offset = "0xA68BA8", VA = "0xA68BA8")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xA68CD8", Offset = "0xA68CD8", VA = "0xA68CD8")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xA68E58", Offset = "0xA68E58", VA = "0xA68E58")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xA68F34", Offset = "0xA68F34", VA = "0xA68F34")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xA69010", Offset = "0xA69010", VA = "0xA69010")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xA69228", Offset = "0xA69228", VA = "0xA69228")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xA69274", Offset = "0xA69274", VA = "0xA69274")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xA692C0", Offset = "0xA692C0", VA = "0xA692C0")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xA693C4", Offset = "0xA693C4", VA = "0xA693C4")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xA694C8", Offset = "0xA694C8", VA = "0xA694C8")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xA695DC", Offset = "0xA695DC", VA = "0xA695DC")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xA69684", Offset = "0xA69684", VA = "0xA69684")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xA69790", Offset = "0xA69790", VA = "0xA69790")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xA698F8", Offset = "0xA698F8", VA = "0xA698F8")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xA69ADC", Offset = "0xA69ADC", VA = "0xA69ADC")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xA69BAC", Offset = "0xA69BAC", VA = "0xA69BAC")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xA69D30", Offset = "0xA69D30", VA = "0xA69D30")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xA69E3C", Offset = "0xA69E3C", VA = "0xA69E3C")]
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
			[Address(RVA = "0xA69FB0", Offset = "0xA69FB0", VA = "0xA69FB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000061")]
		private bool isAnimated
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0xA6A270", Offset = "0xA6A270", VA = "0xA6A270")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xA69E94", Offset = "0xA69E94", VA = "0xA69E94")]
		public void Disable()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xA69F28", Offset = "0xA69F28", VA = "0xA69F28", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xA69F2C", Offset = "0xA69F2C", VA = "0xA69F2C", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xA69F30", Offset = "0xA69F30", VA = "0xA69F30", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xA69F34", Offset = "0xA69F34", VA = "0xA69F34")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xA69FAC", Offset = "0xA69FAC", VA = "0xA69FAC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xA69F5C", Offset = "0xA69F5C", VA = "0xA69F5C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xA6A234", Offset = "0xA6A234", VA = "0xA6A234")]
		private void Update()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xA6A07C", Offset = "0xA6A07C", VA = "0xA6A07C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xA6A308", Offset = "0xA6A308", VA = "0xA6A308")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xA6A354", Offset = "0xA6A354", VA = "0xA6A354")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xA6A3A0", Offset = "0xA6A3A0", VA = "0xA6A3A0")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xA6A3D8", Offset = "0xA6A3D8", VA = "0xA6A3D8")]
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
		[Address(RVA = "0xA6A3E8", Offset = "0xA6A3E8", VA = "0xA6A3E8")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xA6A49C", Offset = "0xA6A49C", VA = "0xA6A49C")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xA6A550", Offset = "0xA6A550", VA = "0xA6A550")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xA6A604", Offset = "0xA6A604", VA = "0xA6A604")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public static class V2Tools
	{
		[Token(Token = "0x600021C")]
		[Address(RVA = "0xA6A60C", Offset = "0xA6A60C", VA = "0xA6A60C")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xA6A614", Offset = "0xA6A614", VA = "0xA6A614")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xA6A6A4", Offset = "0xA6A6A4", VA = "0xA6A6A4")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xA6A738", Offset = "0xA6A738", VA = "0xA6A738")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xA6A7E8", Offset = "0xA6A7E8", VA = "0xA6A7E8")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200003D")]
	public static class V3Tools
	{
		[Token(Token = "0x6000221")]
		[Address(RVA = "0xA6A844", Offset = "0xA6A844", VA = "0xA6A844")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xA6A864", Offset = "0xA6A864", VA = "0xA6A864")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xA6A938", Offset = "0xA6A938", VA = "0xA6A938")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xA6A9F0", Offset = "0xA6A9F0", VA = "0xA6A9F0")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xA6AA4C", Offset = "0xA6AA4C", VA = "0xA6AA4C")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xA6AAA8", Offset = "0xA6AAA8", VA = "0xA6AAA8")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xA6ABC0", Offset = "0xA6ABC0", VA = "0xA6ABC0")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xA6AC1C", Offset = "0xA6AC1C", VA = "0xA6AC1C")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xA6AC54", Offset = "0xA6AC54", VA = "0xA6AC54")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xA6ADA4", Offset = "0xA6ADA4", VA = "0xA6ADA4")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xA6AF20", Offset = "0xA6AF20", VA = "0xA6AF20")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xA6B150", Offset = "0xA6B150", VA = "0xA6B150")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xA6B3A0", Offset = "0xA6B3A0", VA = "0xA6B3A0")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xA6B5F8", Offset = "0xA6B5F8", VA = "0xA6B5F8")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xA6B7A4", Offset = "0xA6B7A4", VA = "0xA6B7A4")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xA6B99C", Offset = "0xA6B99C", VA = "0xA6B99C")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xA6BA18", Offset = "0xA6BA18", VA = "0xA6BA18")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xA6BAA8", Offset = "0xA6BAA8", VA = "0xA6BAA8")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xA6BB40", Offset = "0xA6BB40", VA = "0xA6BB40")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xA6BB30", Offset = "0xA6BB30", VA = "0xA6BB30")]
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
		[Address(RVA = "0xA6BBBC", Offset = "0xA6BBBC", VA = "0xA6BBBC")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xA6BC54", Offset = "0xA6BC54", VA = "0xA6BC54")]
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
		[Address(RVA = "0xA6BE1C", Offset = "0xA6BE1C", VA = "0xA6BE1C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xA6BE60", Offset = "0xA6BE60", VA = "0xA6BE60")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xA6BEA4", Offset = "0xA6BEA4", VA = "0xA6BEA4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xA6BEE8", Offset = "0xA6BEE8", VA = "0xA6BEE8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xA6BF2C", Offset = "0xA6BF2C", VA = "0xA6BF2C")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xA6BFC4", Offset = "0xA6BFC4", VA = "0xA6BFC4")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xA6BFE0", Offset = "0xA6BFE0", VA = "0xA6BFE0")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xA6C00C", Offset = "0xA6C00C", VA = "0xA6C00C")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xA6C038", Offset = "0xA6C038", VA = "0xA6C038")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xA6C074", Offset = "0xA6C074", VA = "0xA6C074")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xA6C0B4", Offset = "0xA6C0B4", VA = "0xA6C0B4")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xA6C0D4", Offset = "0xA6C0D4", VA = "0xA6C0D4")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xA6C0F4", Offset = "0xA6C0F4", VA = "0xA6C0F4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xA6C118", Offset = "0xA6C118", VA = "0xA6C118")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xA6C140", Offset = "0xA6C140", VA = "0xA6C140")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xA6C168", Offset = "0xA6C168", VA = "0xA6C168")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xA6BF48", Offset = "0xA6BF48", VA = "0xA6BF48")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xA6C18C", Offset = "0xA6C18C", VA = "0xA6C18C")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xA6C198", Offset = "0xA6C198", VA = "0xA6C198")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xA6C1A4", Offset = "0xA6C1A4", VA = "0xA6C1A4")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xA6C410", Offset = "0xA6C410", VA = "0xA6C410", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xA6C4AC", Offset = "0xA6C4AC", VA = "0xA6C4AC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xA6C7D0", Offset = "0xA6C7D0", VA = "0xA6C7D0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xA6CC3C", Offset = "0xA6CC3C", VA = "0xA6CC3C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xA6CC60", Offset = "0xA6CC60", VA = "0xA6CC60")]
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
			[Address(RVA = "0xA6C2E0", Offset = "0xA6C2E0", VA = "0xA6C2E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0xA6CE88", Offset = "0xA6CE88", VA = "0xA6CE88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xA6C660", Offset = "0xA6C660", VA = "0xA6C660")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xA6CCFC", Offset = "0xA6CCFC", VA = "0xA6CCFC")]
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
			[Address(RVA = "0xA6D044", Offset = "0xA6D044", VA = "0xA6D044")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000259")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xA6D0A4", Offset = "0xA6D0A4", VA = "0xA6D0A4")]
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
		[Address(RVA = "0xA6D0AC", Offset = "0xA6D0AC", VA = "0xA6D0AC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xA6D144", Offset = "0xA6D144", VA = "0xA6D144")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xA6D14C", Offset = "0xA6D14C", VA = "0xA6D14C")]
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
			[Address(RVA = "0xA6D278", Offset = "0xA6D278", VA = "0xA6D278")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xA6D174", Offset = "0xA6D174", VA = "0xA6D174", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xA6D2D4", Offset = "0xA6D2D4", VA = "0xA6D2D4")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xA6D2DC", Offset = "0xA6D2DC", VA = "0xA6D2DC")]
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
		[Address(RVA = "0xA6D304", Offset = "0xA6D304", VA = "0xA6D304", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xA6D380", Offset = "0xA6D380", VA = "0xA6D380")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xA6D388", Offset = "0xA6D388", VA = "0xA6D388")]
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
			[Address(RVA = "0xA6D4B4", Offset = "0xA6D4B4", VA = "0xA6D4B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xA6D3B0", Offset = "0xA6D3B0", VA = "0xA6D3B0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xA6D50C", Offset = "0xA6D50C", VA = "0xA6D50C")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xA6D514", Offset = "0xA6D514", VA = "0xA6D514")]
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
		[Address(RVA = "0xA6D53C", Offset = "0xA6D53C", VA = "0xA6D53C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xA6C780", Offset = "0xA6C780", VA = "0xA6C780")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xA6C944", Offset = "0xA6C944", VA = "0xA6C944")]
		public void Update()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xA6D03C", Offset = "0xA6D03C", VA = "0xA6D03C")]
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
			[Address(RVA = "0xA6D59C", Offset = "0xA6D59C", VA = "0xA6D59C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0xA6D5A4", Offset = "0xA6D5A4", VA = "0xA6D5A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0xA6D5B0", Offset = "0xA6D5B0", VA = "0xA6D5B0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000270")]
			[Address(RVA = "0xA6D5D0", Offset = "0xA6D5D0", VA = "0xA6D5D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0xA6D5F0", Offset = "0xA6D5F0", VA = "0xA6D5F0")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000272")]
			[Address(RVA = "0xA6D610", Offset = "0xA6D610", VA = "0xA6D610")]
			set
			{
			}
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xA6D630", Offset = "0xA6D630", VA = "0xA6D630")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xA6D71C", Offset = "0xA6D71C", VA = "0xA6D71C")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xA6DD84", Offset = "0xA6DD84", VA = "0xA6DD84")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xA6DE50", Offset = "0xA6DE50", VA = "0xA6DE50")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xA6DF08", Offset = "0xA6DF08", VA = "0xA6DF08")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xA6E4A0", Offset = "0xA6E4A0", VA = "0xA6E4A0")]
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
			[Address(RVA = "0xA6E4B0", Offset = "0xA6E4B0", VA = "0xA6E4B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600027A")]
			[Address(RVA = "0xA6E4B8", Offset = "0xA6E4B8", VA = "0xA6E4B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xA6E4C4", Offset = "0xA6E4C4", VA = "0xA6E4C4")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xA6E538", Offset = "0xA6E538", VA = "0xA6E538")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xA6E844", Offset = "0xA6E844", VA = "0xA6E844")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xA6E9B0", Offset = "0xA6E9B0", VA = "0xA6E9B0")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xA6E75C", Offset = "0xA6E75C", VA = "0xA6E75C")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xA6EB10", Offset = "0xA6EB10", VA = "0xA6EB10", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xA6EBB8", Offset = "0xA6EBB8", VA = "0xA6EBB8")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xA6EC1C", Offset = "0xA6EC1C", VA = "0xA6EC1C")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xA6EC84", Offset = "0xA6EC84", VA = "0xA6EC84")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xA6ECE0", Offset = "0xA6ECE0", VA = "0xA6ECE0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xA6ECE4", Offset = "0xA6ECE4", VA = "0xA6ECE4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xA6ECF8", Offset = "0xA6ECF8", VA = "0xA6ECF8")]
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
			[Address(RVA = "0xA6ED60", Offset = "0xA6ED60", VA = "0xA6ED60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000289")]
			[Address(RVA = "0xA6ED68", Offset = "0xA6ED68", VA = "0xA6ED68")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x6000287")]
		public abstract void ResetPosition();

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xA6ED74", Offset = "0xA6ED74", VA = "0xA6ED74")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xA6F024", Offset = "0xA6F024", VA = "0xA6F024")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xA6EE38", Offset = "0xA6EE38", VA = "0xA6EE38")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xA6F048", Offset = "0xA6F048", VA = "0xA6F048")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028E")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600028F")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xA6F1BC", Offset = "0xA6F1BC", VA = "0xA6F1BC")]
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
		[Address(RVA = "0xA6F3C4", Offset = "0xA6F3C4", VA = "0xA6F3C4", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xA6F408", Offset = "0xA6F408", VA = "0xA6F408", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xA6F44C", Offset = "0xA6F44C", VA = "0xA6F44C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xA6F52C", Offset = "0xA6F52C", VA = "0xA6F52C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xA6F5CC", Offset = "0xA6F5CC", VA = "0xA6F5CC")]
		private void Update()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xA6F620", Offset = "0xA6F620", VA = "0xA6F620")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xA6FB90", Offset = "0xA6FB90", VA = "0xA6FB90")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xA6FBD0", Offset = "0xA6FBD0", VA = "0xA6FBD0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xA70244", Offset = "0xA70244", VA = "0xA70244")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xA7036C", Offset = "0xA7036C", VA = "0xA7036C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xA7053C", Offset = "0xA7053C", VA = "0xA7053C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xA706E4", Offset = "0xA706E4", VA = "0xA706E4")]
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
			[Address(RVA = "0xA7137C", Offset = "0xA7137C", VA = "0xA7137C")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60002B0")]
			[Address(RVA = "0xA7138C", Offset = "0xA7138C", VA = "0xA7138C")]
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
		[Address(RVA = "0xA70770", Offset = "0xA70770", VA = "0xA70770")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xA707B4", Offset = "0xA707B4", VA = "0xA707B4", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xA707F8", Offset = "0xA707F8", VA = "0xA707F8", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xA7083C", Offset = "0xA7083C", VA = "0xA7083C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xA708A4", Offset = "0xA708A4", VA = "0xA708A4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xA7092C", Offset = "0xA7092C", VA = "0xA7092C")]
		private void Update()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xA70B9C", Offset = "0xA70B9C", VA = "0xA70B9C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xA70BA8", Offset = "0xA70BA8", VA = "0xA70BA8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xA70988", Offset = "0xA70988", VA = "0xA70988")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xA70BB4", Offset = "0xA70BB4", VA = "0xA70BB4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xA70F24", Offset = "0xA70F24", VA = "0xA70F24")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xA710A8", Offset = "0xA710A8", VA = "0xA710A8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xA711DC", Offset = "0xA711DC", VA = "0xA711DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xA712F0", Offset = "0xA712F0", VA = "0xA712F0")]
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
		[Address(RVA = "0xA713D0", Offset = "0xA713D0", VA = "0xA713D0", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xA71414", Offset = "0xA71414", VA = "0xA71414", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xA71458", Offset = "0xA71458", VA = "0xA71458", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xA71470", Offset = "0xA71470", VA = "0xA71470")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xA7168C", Offset = "0xA7168C", VA = "0xA7168C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xA7176C", Offset = "0xA7176C", VA = "0xA7176C")]
		private void Update()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xA71E58", Offset = "0xA71E58", VA = "0xA71E58")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xA722B8", Offset = "0xA722B8", VA = "0xA722B8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xA72464", Offset = "0xA72464", VA = "0xA72464")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xA727EC", Offset = "0xA727EC", VA = "0xA727EC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xA729C4", Offset = "0xA729C4", VA = "0xA729C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xA72BC8", Offset = "0xA72BC8", VA = "0xA72BC8")]
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
			[Address(RVA = "0xA73720", Offset = "0xA73720", VA = "0xA73720")]
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
		[Address(RVA = "0xA72C54", Offset = "0xA72C54", VA = "0xA72C54", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xA72C98", Offset = "0xA72C98", VA = "0xA72C98", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xA72CDC", Offset = "0xA72CDC", VA = "0xA72CDC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xA72D04", Offset = "0xA72D04", VA = "0xA72D04")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xA72E08", Offset = "0xA72E08", VA = "0xA72E08")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xA72FFC", Offset = "0xA72FFC", VA = "0xA72FFC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xA73060", Offset = "0xA73060", VA = "0xA73060")]
		private void Update()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xA730B8", Offset = "0xA730B8", VA = "0xA730B8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xA733CC", Offset = "0xA733CC", VA = "0xA733CC")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xA73754", Offset = "0xA73754", VA = "0xA73754")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xA737E4", Offset = "0xA737E4", VA = "0xA737E4")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xA73C34", Offset = "0xA73C34", VA = "0xA73C34")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xA742F4", Offset = "0xA742F4", VA = "0xA742F4")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xA745AC", Offset = "0xA745AC", VA = "0xA745AC")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xA746E0", Offset = "0xA746E0", VA = "0xA746E0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xA749A8", Offset = "0xA749A8", VA = "0xA749A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xA749D8", Offset = "0xA749D8", VA = "0xA749D8")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xA74BD4", Offset = "0xA74BD4", VA = "0xA74BD4")]
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
		[Address(RVA = "0xA74D04", Offset = "0xA74D04", VA = "0xA74D04")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xA74D48", Offset = "0xA74D48", VA = "0xA74D48", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xA74D8C", Offset = "0xA74D8C", VA = "0xA74D8C", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xA74DD0", Offset = "0xA74DD0", VA = "0xA74DD0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xA74DE8", Offset = "0xA74DE8", VA = "0xA74DE8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xA74E70", Offset = "0xA74E70", VA = "0xA74E70")]
		private void Update()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xA74EC4", Offset = "0xA74EC4", VA = "0xA74EC4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xA750FC", Offset = "0xA750FC", VA = "0xA750FC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xA752F0", Offset = "0xA752F0", VA = "0xA752F0")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xA75374", Offset = "0xA75374", VA = "0xA75374")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xA75610", Offset = "0xA75610", VA = "0xA75610")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xA75744", Offset = "0xA75744", VA = "0xA75744")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xA758DC", Offset = "0xA758DC", VA = "0xA758DC")]
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
				[Address(RVA = "0xA76E6C", Offset = "0xA76E6C", VA = "0xA76E6C")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002F6")]
				[Address(RVA = "0xA76E74", Offset = "0xA76E74", VA = "0xA76E74")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000075")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60002F7")]
				[Address(RVA = "0xA76E80", Offset = "0xA76E80", VA = "0xA76E80")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60002F8")]
				[Address(RVA = "0xA76E8C", Offset = "0xA76E8C", VA = "0xA76E8C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000076")]
			public bool initiated
			{
				[Token(Token = "0x60002F9")]
				[Address(RVA = "0xA76E98", Offset = "0xA76E98", VA = "0xA76E98")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002FA")]
				[Address(RVA = "0xA76EA0", Offset = "0xA76EA0", VA = "0xA76EA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000077")]
			public float heightFromGround
			{
				[Token(Token = "0x60002FB")]
				[Address(RVA = "0xA76EAC", Offset = "0xA76EAC", VA = "0xA76EAC")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60002FC")]
				[Address(RVA = "0xA76EB4", Offset = "0xA76EB4", VA = "0xA76EB4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000078")]
			public Vector3 velocity
			{
				[Token(Token = "0x60002FD")]
				[Address(RVA = "0xA76EBC", Offset = "0xA76EBC", VA = "0xA76EBC")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60002FE")]
				[Address(RVA = "0xA76EC8", Offset = "0xA76EC8", VA = "0xA76EC8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000079")]
			public Transform transform
			{
				[Token(Token = "0x60002FF")]
				[Address(RVA = "0xA76ED4", Offset = "0xA76ED4", VA = "0xA76ED4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000300")]
				[Address(RVA = "0xA76EDC", Offset = "0xA76EDC", VA = "0xA76EDC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700007A")]
			public float IKOffset
			{
				[Token(Token = "0x6000301")]
				[Address(RVA = "0xA76EE4", Offset = "0xA76EE4", VA = "0xA76EE4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000302")]
				[Address(RVA = "0xA76EEC", Offset = "0xA76EEC", VA = "0xA76EEC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700007B")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x6000303")]
				[Address(RVA = "0xA76EF4", Offset = "0xA76EF4", VA = "0xA76EF4")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x6000304")]
				[Address(RVA = "0xA76F0C", Offset = "0xA76F0C", VA = "0xA76F0C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700007C")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x6000305")]
				[Address(RVA = "0xA76F2C", Offset = "0xA76F2C", VA = "0xA76F2C")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x6000306")]
				[Address(RVA = "0xA76F44", Offset = "0xA76F44", VA = "0xA76F44")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700007D")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x6000307")]
				[Address(RVA = "0xA76F64", Offset = "0xA76F64", VA = "0xA76F64")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700007E")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x600030D")]
				[Address(RVA = "0xA77850", Offset = "0xA77850", VA = "0xA77850")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700007F")]
			private float rootYOffset
			{
				[Token(Token = "0x6000316")]
				[Address(RVA = "0xA779A0", Offset = "0xA779A0", VA = "0xA779A0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0xA76FAC", Offset = "0xA76FAC", VA = "0xA76FAC")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0xA75DF0", Offset = "0xA75DF0", VA = "0xA75DF0")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0xA76FC0", Offset = "0xA76FC0", VA = "0xA76FC0")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600030B")]
			[Address(RVA = "0xA76ADC", Offset = "0xA76ADC", VA = "0xA76ADC")]
			public void Reset()
			{
			}

			[Token(Token = "0x600030C")]
			[Address(RVA = "0xA75EDC", Offset = "0xA75EDC", VA = "0xA75EDC")]
			public void Process()
			{
			}

			[Token(Token = "0x600030E")]
			[Address(RVA = "0xA77460", Offset = "0xA77460", VA = "0xA77460")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600030F")]
			[Address(RVA = "0xA77000", Offset = "0xA77000", VA = "0xA77000")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0xA778E4", Offset = "0xA778E4", VA = "0xA778E4")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0xA772CC", Offset = "0xA772CC", VA = "0xA772CC")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0xA7734C", Offset = "0xA7734C", VA = "0xA7734C")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0xA77950", Offset = "0xA77950", VA = "0xA77950")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000314")]
			[Address(RVA = "0xA77884", Offset = "0xA77884", VA = "0xA77884")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0xA77A2C", Offset = "0xA77A2C", VA = "0xA77A2C")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000317")]
			[Address(RVA = "0xA75D50", Offset = "0xA75D50", VA = "0xA75D50")]
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
				[Address(RVA = "0xA77BDC", Offset = "0xA77BDC", VA = "0xA77BDC")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000319")]
				[Address(RVA = "0xA77BE8", Offset = "0xA77BE8", VA = "0xA77BE8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000081")]
			public float heightOffset
			{
				[Token(Token = "0x600031A")]
				[Address(RVA = "0xA77BF4", Offset = "0xA77BF4", VA = "0xA77BF4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600031B")]
				[Address(RVA = "0xA77BFC", Offset = "0xA77BFC", VA = "0xA77BFC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0xA75EB8", Offset = "0xA75EB8", VA = "0xA75EB8")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0xA76A48", Offset = "0xA76A48", VA = "0xA76A48")]
			public void Reset()
			{
			}

			[Token(Token = "0x600031E")]
			[Address(RVA = "0xA77C04", Offset = "0xA77C04", VA = "0xA77C04")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0xA7685C", Offset = "0xA7685C", VA = "0xA7685C")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000320")]
			[Address(RVA = "0xA75DE8", Offset = "0xA75DE8", VA = "0xA75DE8")]
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
			[Address(RVA = "0xA75930", Offset = "0xA75930", VA = "0xA75930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0xA75938", Offset = "0xA75938", VA = "0xA75938")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0xA75940", Offset = "0xA75940", VA = "0xA75940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xA75948", Offset = "0xA75948", VA = "0xA75948")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public bool isGrounded
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0xA75950", Offset = "0xA75950", VA = "0xA75950")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0xA75958", Offset = "0xA75958", VA = "0xA75958")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public Transform root
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0xA75964", Offset = "0xA75964", VA = "0xA75964")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0xA7596C", Offset = "0xA7596C", VA = "0xA7596C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0xA75974", Offset = "0xA75974", VA = "0xA75974")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0xA7598C", Offset = "0xA7598C", VA = "0xA7598C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public bool rootGrounded
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0xA759AC", Offset = "0xA759AC", VA = "0xA759AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000072")]
		public Vector3 up
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xA70304", Offset = "0xA70304", VA = "0xA70304")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000073")]
		private bool useRootRotation
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0xA76B70", Offset = "0xA76B70", VA = "0xA76B70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xA759F4", Offset = "0xA759F4", VA = "0xA759F4")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xA75C54", Offset = "0xA75C54", VA = "0xA75C54")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xA6F920", Offset = "0xA6F920", VA = "0xA6F920")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xA70048", Offset = "0xA70048", VA = "0xA70048")]
		public void Update()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xA71CE0", Offset = "0xA71CE0", VA = "0xA71CE0")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xA6F4B4", Offset = "0xA6F4B4", VA = "0xA6F4B4")]
		public void Reset()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xA75EC8", Offset = "0xA75EC8", VA = "0xA75EC8")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xA76C24", Offset = "0xA76C24", VA = "0xA76C24")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xA76CA8", Offset = "0xA76CA8", VA = "0xA76CA8")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xA76DFC", Offset = "0xA76DFC", VA = "0xA76DFC")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xA6F274", Offset = "0xA6F274", VA = "0xA6F274")]
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
		[Address(RVA = "0xA77C58", Offset = "0xA77C58", VA = "0xA77C58", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xA77C9C", Offset = "0xA77C9C", VA = "0xA77C9C", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xA77CE0", Offset = "0xA77CE0", VA = "0xA77CE0")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xA77D24", Offset = "0xA77D24", VA = "0xA77D24")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xA77D68", Offset = "0xA77D68", VA = "0xA77D68")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xA77DAC", Offset = "0xA77DAC", VA = "0xA77DAC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xA77DB4", Offset = "0xA77DB4", VA = "0xA77DB4")]
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
		[Address(RVA = "0xA77E34", Offset = "0xA77E34", VA = "0xA77E34", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xA77E78", Offset = "0xA77E78", VA = "0xA77E78", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xA77EBC", Offset = "0xA77EBC", VA = "0xA77EBC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xA77F00", Offset = "0xA77F00", VA = "0xA77F00")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xA77F44", Offset = "0xA77F44", VA = "0xA77F44", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xA77F4C", Offset = "0xA77F4C", VA = "0xA77F4C")]
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
		[Address(RVA = "0xA77FBC", Offset = "0xA77FBC", VA = "0xA77FBC", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xA78000", Offset = "0xA78000", VA = "0xA78000", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xA78044", Offset = "0xA78044", VA = "0xA78044")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xA78088", Offset = "0xA78088", VA = "0xA78088")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xA780CC", Offset = "0xA780CC", VA = "0xA780CC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xA780D4", Offset = "0xA780D4", VA = "0xA780D4")]
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
		[Address(RVA = "0xA78144", Offset = "0xA78144", VA = "0xA78144", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xA78188", Offset = "0xA78188", VA = "0xA78188", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xA781CC", Offset = "0xA781CC", VA = "0xA781CC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xA78210", Offset = "0xA78210", VA = "0xA78210")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xA78254", Offset = "0xA78254", VA = "0xA78254", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xA7825C", Offset = "0xA7825C", VA = "0xA7825C")]
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
		[Address(RVA = "0xA782CC", Offset = "0xA782CC", VA = "0xA782CC", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xA78310", Offset = "0xA78310", VA = "0xA78310", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xA78354", Offset = "0xA78354", VA = "0xA78354")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xA78398", Offset = "0xA78398", VA = "0xA78398")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xA783DC", Offset = "0xA783DC", VA = "0xA783DC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xA783E4", Offset = "0xA783E4", VA = "0xA783E4")]
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
		[Address(RVA = "0xA78454", Offset = "0xA78454", VA = "0xA78454", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xA78498", Offset = "0xA78498", VA = "0xA78498", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xA784DC", Offset = "0xA784DC", VA = "0xA784DC")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xA78520", Offset = "0xA78520", VA = "0xA78520")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xA78564", Offset = "0xA78564", VA = "0xA78564")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xA785A8", Offset = "0xA785A8", VA = "0xA785A8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xA785EC", Offset = "0xA785EC", VA = "0xA785EC")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xA78610", Offset = "0xA78610", VA = "0xA78610", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xA78618", Offset = "0xA78618", VA = "0xA78618")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xA787D4", Offset = "0xA787D4", VA = "0xA787D4")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xA78C84", Offset = "0xA78C84", VA = "0xA78C84")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xA78CA4", Offset = "0xA78CA4", VA = "0xA78CA4")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xA78D7C", Offset = "0xA78D7C", VA = "0xA78D7C")]
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
		[Address(RVA = "0xA78E1C", Offset = "0xA78E1C", VA = "0xA78E1C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xA78E94", Offset = "0xA78E94", VA = "0xA78E94", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xA78F04", Offset = "0xA78F04", VA = "0xA78F04", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000351")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000352")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xA77E24", Offset = "0xA77E24", VA = "0xA77E24")]
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
			[Address(RVA = "0xA78F54", Offset = "0xA78F54", VA = "0xA78F54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xA78FE0", Offset = "0xA78FE0", VA = "0xA78FE0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xA79044", Offset = "0xA79044", VA = "0xA79044")]
		private void Update()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xA790E4", Offset = "0xA790E4", VA = "0xA790E4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xA79110", Offset = "0xA79110", VA = "0xA79110")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xA79068", Offset = "0xA79068", VA = "0xA79068")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xA79194", Offset = "0xA79194", VA = "0xA79194")]
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
		[Address(RVA = "0xA7919C", Offset = "0xA7919C", VA = "0xA7919C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xA791E0", Offset = "0xA791E0", VA = "0xA791E0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xA79224", Offset = "0xA79224", VA = "0xA79224")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xA79268", Offset = "0xA79268", VA = "0xA79268")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xA792AC", Offset = "0xA792AC", VA = "0xA792AC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xA792B4", Offset = "0xA792B4", VA = "0xA792B4")]
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
		[Address(RVA = "0xA79324", Offset = "0xA79324", VA = "0xA79324", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xA79368", Offset = "0xA79368", VA = "0xA79368", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xA793AC", Offset = "0xA793AC", VA = "0xA793AC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xA793F0", Offset = "0xA793F0", VA = "0xA793F0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xA79434", Offset = "0xA79434", VA = "0xA79434", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xA7943C", Offset = "0xA7943C", VA = "0xA7943C")]
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
		[Address(RVA = "0xA794AC", Offset = "0xA794AC", VA = "0xA794AC", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xA794F0", Offset = "0xA794F0", VA = "0xA794F0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xA79534", Offset = "0xA79534", VA = "0xA79534")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xA79578", Offset = "0xA79578", VA = "0xA79578")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xA795BC", Offset = "0xA795BC", VA = "0xA795BC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xA795C4", Offset = "0xA795C4", VA = "0xA795C4")]
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
		[Address(RVA = "0xA79634", Offset = "0xA79634", VA = "0xA79634", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xA79678", Offset = "0xA79678", VA = "0xA79678", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xA796BC", Offset = "0xA796BC", VA = "0xA796BC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xA79700", Offset = "0xA79700", VA = "0xA79700")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xA79744", Offset = "0xA79744", VA = "0xA79744", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xA7974C", Offset = "0xA7974C", VA = "0xA7974C")]
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
				[Address(RVA = "0xA7A088", Offset = "0xA7A088", VA = "0xA7A088")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000084")]
			public bool isEmpty
			{
				[Token(Token = "0x600037E")]
				[Address(RVA = "0xA79CCC", Offset = "0xA79CCC", VA = "0xA79CCC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600037C")]
			[Address(RVA = "0xA7A67C", Offset = "0xA7A67C", VA = "0xA7A67C")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x600037F")]
			[Address(RVA = "0xA798A4", Offset = "0xA798A4", VA = "0xA798A4")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000380")]
			[Address(RVA = "0xA7A674", Offset = "0xA7A674", VA = "0xA7A674")]
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
		[Address(RVA = "0xA797BC", Offset = "0xA797BC", VA = "0xA797BC", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xA79800", Offset = "0xA79800", VA = "0xA79800", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xA79844", Offset = "0xA79844", VA = "0xA79844")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xA79888", Offset = "0xA79888", VA = "0xA79888")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xA79C30", Offset = "0xA79C30", VA = "0xA79C30")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xA79C58", Offset = "0xA79C58", VA = "0xA79C58", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xA79C60", Offset = "0xA79C60", VA = "0xA79C60", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xA7A444", Offset = "0xA7A444", VA = "0xA7A444", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xA7A5D4", Offset = "0xA7A5D4", VA = "0xA7A5D4")]
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
		[Address(RVA = "0xA7AAB8", Offset = "0xA7AAB8", VA = "0xA7AAB8")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xA7AB7C", Offset = "0xA7AB7C", VA = "0xA7AB7C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xA7AB9C", Offset = "0xA7AB9C", VA = "0xA7AB9C")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xA7ADF0", Offset = "0xA7ADF0", VA = "0xA7ADF0")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xA7AC5C", Offset = "0xA7AC5C", VA = "0xA7AC5C")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xA7AED4", Offset = "0xA7AED4", VA = "0xA7AED4")]
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
		[Address(RVA = "0xA7AF34", Offset = "0xA7AF34", VA = "0xA7AF34")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xA7B488", Offset = "0xA7B488", VA = "0xA7B488")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xA7B61C", Offset = "0xA7B61C", VA = "0xA7B61C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xA7B724", Offset = "0xA7B724", VA = "0xA7B724")]
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
			[Address(RVA = "0xA7E918", Offset = "0xA7E918", VA = "0xA7E918")]
			public BendBone()
			{
			}

			[Token(Token = "0x600039A")]
			[Address(RVA = "0xA7E978", Offset = "0xA7E978", VA = "0xA7E978")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x600039B")]
			[Address(RVA = "0xA7C03C", Offset = "0xA7C03C", VA = "0xA7C03C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600039C")]
			[Address(RVA = "0xA7C40C", Offset = "0xA7C40C", VA = "0xA7C40C")]
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
		[Address(RVA = "0xA7B72C", Offset = "0xA7B72C", VA = "0xA7B72C")]
		private void Start()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xA7BBC8", Offset = "0xA7BBC8", VA = "0xA7BBC8")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xA7C068", Offset = "0xA7C068", VA = "0xA7C068")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xA7C434", Offset = "0xA7C434", VA = "0xA7C434")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xA7CD30", Offset = "0xA7CD30", VA = "0xA7CD30")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xA7D128", Offset = "0xA7D128", VA = "0xA7D128")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xA7D538", Offset = "0xA7D538", VA = "0xA7D538")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xA7DEB0", Offset = "0xA7DEB0", VA = "0xA7DEB0")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xA7CA74", Offset = "0xA7CA74", VA = "0xA7CA74")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xA7E0EC", Offset = "0xA7E0EC", VA = "0xA7E0EC")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xA7DDD0", Offset = "0xA7DDD0", VA = "0xA7DDD0")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xA7DCD0", Offset = "0xA7DCD0", VA = "0xA7DCD0")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xA7E44C", Offset = "0xA7E44C", VA = "0xA7E44C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xA7E770", Offset = "0xA7E770", VA = "0xA7E770")]
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
				[Address(RVA = "0xA8194C", Offset = "0xA8194C", VA = "0xA8194C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60003B2")]
				[Address(RVA = "0xA81954", Offset = "0xA81954", VA = "0xA81954")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000086")]
			public bool isRigid
			{
				[Token(Token = "0x60003B3")]
				[Address(RVA = "0xA8195C", Offset = "0xA8195C", VA = "0xA8195C")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003B4")]
				[Address(RVA = "0xA81964", Offset = "0xA81964", VA = "0xA81964")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60003B5")]
			[Address(RVA = "0xA81970", Offset = "0xA81970", VA = "0xA81970")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60003B6")]
			[Address(RVA = "0xA7F658", Offset = "0xA7F658", VA = "0xA7F658")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60003B7")]
			[Address(RVA = "0xA7FD04", Offset = "0xA7FD04", VA = "0xA7FD04")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60003B8")]
			[Address(RVA = "0xA81710", Offset = "0xA81710", VA = "0xA81710")]
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
		[Address(RVA = "0xA7E9F4", Offset = "0xA7E9F4", VA = "0xA7E9F4")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xA7EB5C", Offset = "0xA7EB5C", VA = "0xA7EB5C")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xA7EC90", Offset = "0xA7EC90", VA = "0xA7EC90")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xA7EDC8", Offset = "0xA7EDC8", VA = "0xA7EDC8")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xA7EE84", Offset = "0xA7EE84", VA = "0xA7EE84")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xA7EF90", Offset = "0xA7EF90", VA = "0xA7EF90")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xA7F920", Offset = "0xA7F920", VA = "0xA7F920")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xA7F0FC", Offset = "0xA7F0FC", VA = "0xA7F0FC")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xA7FEE8", Offset = "0xA7FEE8", VA = "0xA7FEE8")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xA8017C", Offset = "0xA8017C", VA = "0xA8017C")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xA8044C", Offset = "0xA8044C", VA = "0xA8044C")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xA80E14", Offset = "0xA80E14", VA = "0xA80E14")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xA8130C", Offset = "0xA8130C", VA = "0xA8130C")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xA8150C", Offset = "0xA8150C", VA = "0xA8150C")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xA811F8", Offset = "0xA811F8", VA = "0xA811F8")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xA80CB4", Offset = "0xA80CB4", VA = "0xA80CB4")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xA81194", Offset = "0xA81194", VA = "0xA81194")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xA815E8", Offset = "0xA815E8", VA = "0xA815E8")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xA810C0", Offset = "0xA810C0", VA = "0xA810C0")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xA81410", Offset = "0xA81410", VA = "0xA81410")]
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
			[Address(RVA = "0xA81B88", Offset = "0xA81B88", VA = "0xA81B88")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0xA81B90", Offset = "0xA81B90", VA = "0xA81B90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xA819B0", Offset = "0xA819B0", VA = "0xA819B0")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xA7EAF0", Offset = "0xA7EAF0", VA = "0xA7EAF0")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xA81B9C", Offset = "0xA81B9C", VA = "0xA81B9C")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xA7F6AC", Offset = "0xA7F6AC", VA = "0xA7F6AC")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xA7F6B8", Offset = "0xA7F6B8", VA = "0xA7F6B8")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xA81D70", Offset = "0xA81D70", VA = "0xA81D70")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xA820C4", Offset = "0xA820C4", VA = "0xA820C4")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xA80684", Offset = "0xA80684", VA = "0xA80684")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xA81C28", Offset = "0xA81C28", VA = "0xA81C28")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xA81CCC", Offset = "0xA81CCC", VA = "0xA81CCC")]
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
			[Address(RVA = "0xA8248C", Offset = "0xA8248C", VA = "0xA8248C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0xA82494", Offset = "0xA82494", VA = "0xA82494")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xA7E3F0", Offset = "0xA7E3F0", VA = "0xA7E3F0")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xA824A0", Offset = "0xA824A0", VA = "0xA824A0")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xA82524", Offset = "0xA82524", VA = "0xA82524")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xA826C4", Offset = "0xA826C4", VA = "0xA826C4")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xA82880", Offset = "0xA82880", VA = "0xA82880")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xA82B74", Offset = "0xA82B74", VA = "0xA82B74")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xA82E14", Offset = "0xA82E14", VA = "0xA82E14")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xA82F34", Offset = "0xA82F34", VA = "0xA82F34")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xA82FD0", Offset = "0xA82FD0", VA = "0xA82FD0")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xA83684", Offset = "0xA83684", VA = "0xA83684")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xA836DC", Offset = "0xA836DC", VA = "0xA836DC")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xA838B0", Offset = "0xA838B0", VA = "0xA838B0")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xA83B0C", Offset = "0xA83B0C", VA = "0xA83B0C")]
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
				[Address(RVA = "0xA84058", Offset = "0xA84058", VA = "0xA84058")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008A")]
			public bool isNodeBone
			{
				[Token(Token = "0x60003DD")]
				[Address(RVA = "0xA84110", Offset = "0xA84110", VA = "0xA84110")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700008B")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60003F1")]
				[Address(RVA = "0xA844D8", Offset = "0xA844D8", VA = "0xA844D8")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60003D9")]
			[Address(RVA = "0xA8402C", Offset = "0xA8402C", VA = "0xA8402C")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60003DB")]
			[Address(RVA = "0xA84088", Offset = "0xA84088", VA = "0xA84088")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60003DC")]
			[Address(RVA = "0xA840CC", Offset = "0xA840CC", VA = "0xA840CC")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60003DE")]
			[Address(RVA = "0xA84120", Offset = "0xA84120", VA = "0xA84120")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60003DF")]
			[Address(RVA = "0xA841F4", Offset = "0xA841F4", VA = "0xA841F4")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60003E0")]
			[Address(RVA = "0xA841FC", Offset = "0xA841FC", VA = "0xA841FC")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60003E1")]
			[Address(RVA = "0xA842C8", Offset = "0xA842C8", VA = "0xA842C8")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60003E2")]
			[Address(RVA = "0xA84334", Offset = "0xA84334", VA = "0xA84334")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60003E3")]
			[Address(RVA = "0xA843C8", Offset = "0xA843C8", VA = "0xA843C8")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60003E4")]
			[Address(RVA = "0xA84640", Offset = "0xA84640", VA = "0xA84640")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60003E5")]
			[Address(RVA = "0xA8466C", Offset = "0xA8466C", VA = "0xA8466C")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60003E6")]
			[Address(RVA = "0xA84698", Offset = "0xA84698", VA = "0xA84698")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60003E7")]
			[Address(RVA = "0xA846C0", Offset = "0xA846C0", VA = "0xA846C0")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60003E8")]
			[Address(RVA = "0xA84784", Offset = "0xA84784", VA = "0xA84784")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003E9")]
			[Address(RVA = "0xA84918", Offset = "0xA84918", VA = "0xA84918")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xA8493C", Offset = "0xA8493C", VA = "0xA8493C")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60003EB")]
			[Address(RVA = "0xA84A5C", Offset = "0xA84A5C", VA = "0xA84A5C")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60003EC")]
			[Address(RVA = "0xA84AC0", Offset = "0xA84AC0", VA = "0xA84AC0")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60003ED")]
			[Address(RVA = "0xA84C40", Offset = "0xA84C40", VA = "0xA84C40")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60003EE")]
			[Address(RVA = "0xA84DC0", Offset = "0xA84DC0", VA = "0xA84DC0")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60003EF")]
			[Address(RVA = "0xA84E3C", Offset = "0xA84E3C", VA = "0xA84E3C")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60003F0")]
			[Address(RVA = "0xA847FC", Offset = "0xA847FC", VA = "0xA847FC")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60003F2")]
			[Address(RVA = "0xA84F64", Offset = "0xA84F64", VA = "0xA84F64")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xA83DC8", Offset = "0xA83DC8", VA = "0xA83DC8", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xA83DD0", Offset = "0xA83DD0", VA = "0xA83DD0", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xA83DD4", Offset = "0xA83DD4", VA = "0xA83DD4")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xA83F10", Offset = "0xA83F10", VA = "0xA83F10")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xA84024", Offset = "0xA84024", VA = "0xA84024")]
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
		[Address(RVA = "0xA84F80", Offset = "0xA84F80", VA = "0xA84F80", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xA8501C", Offset = "0xA8501C", VA = "0xA8501C")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xA850A0", Offset = "0xA850A0", VA = "0xA850A0")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xA85138", Offset = "0xA85138", VA = "0xA85138")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xA85150", Offset = "0xA85150", VA = "0xA85150")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xA8516C", Offset = "0xA8516C", VA = "0xA8516C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xA851F8", Offset = "0xA851F8", VA = "0xA851F8")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xA85210", Offset = "0xA85210", VA = "0xA85210")]
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
		[Address(RVA = "0xA85234", Offset = "0xA85234", VA = "0xA85234", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xA852A8", Offset = "0xA852A8", VA = "0xA852A8")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xA85370", Offset = "0xA85370", VA = "0xA85370")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xA85628", Offset = "0xA85628", VA = "0xA85628")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xA85744", Offset = "0xA85744", VA = "0xA85744")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xA8588C", Offset = "0xA8588C", VA = "0xA8588C")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xA85898", Offset = "0xA85898", VA = "0xA85898")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xA85930", Offset = "0xA85930", VA = "0xA85930")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xA859D8", Offset = "0xA859D8", VA = "0xA859D8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xA85C34", Offset = "0xA85C34", VA = "0xA85C34")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xA85C94", Offset = "0xA85C94", VA = "0xA85C94")]
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
		[Address(RVA = "0xA85DDC", Offset = "0xA85DDC", VA = "0xA85DDC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xA860FC", Offset = "0xA860FC", VA = "0xA860FC")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xA86238", Offset = "0xA86238", VA = "0xA86238")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xA863A8", Offset = "0xA863A8", VA = "0xA863A8")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xA863B8", Offset = "0xA863B8", VA = "0xA863B8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xA86414", Offset = "0xA86414", VA = "0xA86414")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xA8648C", Offset = "0xA8648C", VA = "0xA8648C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xA86AA0", Offset = "0xA86AA0", VA = "0xA86AA0")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xA86AD8", Offset = "0xA86AD8", VA = "0xA86AD8")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xA86D3C", Offset = "0xA86D3C", VA = "0xA86D3C")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xA87064", Offset = "0xA87064", VA = "0xA87064")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xA87144", Offset = "0xA87144", VA = "0xA87144")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xA871F8", Offset = "0xA871F8", VA = "0xA871F8")]
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
			[Address(RVA = "0xA87AD0", Offset = "0xA87AD0", VA = "0xA87AD0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600042A")]
			[Address(RVA = "0xA87B14", Offset = "0xA87B14", VA = "0xA87B14")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600042B")]
			[Address(RVA = "0xA87BF4", Offset = "0xA87BF4", VA = "0xA87BF4")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x600042C")]
			[Address(RVA = "0xA87C20", Offset = "0xA87C20", VA = "0xA87C20")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x600042D")]
			[Address(RVA = "0xA87C4C", Offset = "0xA87C4C", VA = "0xA87C4C")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x600042E")]
			[Address(RVA = "0xA87C90", Offset = "0xA87C90", VA = "0xA87C90")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600042F")]
			[Address(RVA = "0xA87CD4", Offset = "0xA87CD4", VA = "0xA87CD4")]
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
				[Address(RVA = "0xA87D34", Offset = "0xA87D34", VA = "0xA87D34")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000431")]
				[Address(RVA = "0xA87E14", Offset = "0xA87E14", VA = "0xA87E14")]
				set
				{
				}
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0xA87E8C", Offset = "0xA87E8C", VA = "0xA87E8C")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000433")]
			[Address(RVA = "0xA880F8", Offset = "0xA880F8", VA = "0xA880F8")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0xA883B4", Offset = "0xA883B4", VA = "0xA883B4")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0xA885A8", Offset = "0xA885A8", VA = "0xA885A8")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000436")]
			[Address(RVA = "0xA885D0", Offset = "0xA885D0", VA = "0xA885D0")]
			public Bone()
			{
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0xA8863C", Offset = "0xA8863C", VA = "0xA8863C")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0xA886B4", Offset = "0xA886B4", VA = "0xA886B4")]
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
			[Address(RVA = "0xA8873C", Offset = "0xA8873C", VA = "0xA8873C")]
			public Node()
			{
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0xA7EDA4", Offset = "0xA7EDA4", VA = "0xA7EDA4")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0xA88740", Offset = "0xA88740", VA = "0xA88740")]
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
			[Address(RVA = "0xA876DC", Offset = "0xA876DC", VA = "0xA876DC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600041D")]
			[Address(RVA = "0xA876E4", Offset = "0xA876E4", VA = "0xA876E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xA8743C", Offset = "0xA8743C", VA = "0xA8743C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000414")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xA874B0", Offset = "0xA874B0", VA = "0xA874B0")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xA87628", Offset = "0xA87628", VA = "0xA87628")]
		public void Update()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xA87698", Offset = "0xA87698", VA = "0xA87698", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xA876A4", Offset = "0xA876A4", VA = "0xA876A4")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xA876B0", Offset = "0xA876B0", VA = "0xA876B0")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xA876B8", Offset = "0xA876B8", VA = "0xA876B8")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xA876D4", Offset = "0xA876D4", VA = "0xA876D4")]
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
		[Address(RVA = "0xA876F0", Offset = "0xA876F0", VA = "0xA876F0")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xA87708", Offset = "0xA87708", VA = "0xA87708")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xA8782C", Offset = "0xA8782C", VA = "0xA8782C")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xA878C4", Offset = "0xA878C4", VA = "0xA878C4")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xA87AB8", Offset = "0xA87AB8", VA = "0xA87AB8")]
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
			[Address(RVA = "0xA88990", Offset = "0xA88990", VA = "0xA88990")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700008F")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0xA889C0", Offset = "0xA889C0", VA = "0xA889C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000090")]
		protected override int minBones
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0xA895F4", Offset = "0xA895F4", VA = "0xA895F4", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000091")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0xA89B34", Offset = "0xA89B34", VA = "0xA89B34", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xA88858", Offset = "0xA88858", VA = "0xA88858")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xA889F0", Offset = "0xA889F0", VA = "0xA889F0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xA88C7C", Offset = "0xA88C7C", VA = "0xA88C7C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xA8954C", Offset = "0xA8954C", VA = "0xA8954C")]
		private void Solve()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xA891E8", Offset = "0xA891E8", VA = "0xA891E8")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xA895FC", Offset = "0xA895FC", VA = "0xA895FC")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xA89B94", Offset = "0xA89B94", VA = "0xA89B94")]
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
		[Address(RVA = "0xA89C38", Offset = "0xA89C38", VA = "0xA89C38", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xA89F94", Offset = "0xA89F94", VA = "0xA89F94")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xA89FF4", Offset = "0xA89FF4", VA = "0xA89FF4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xA8A138", Offset = "0xA8A138", VA = "0xA8A138", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xA8A298", Offset = "0xA8A298", VA = "0xA8A298", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xA8A2D8", Offset = "0xA8A2D8", VA = "0xA8A2D8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xA8A328", Offset = "0xA8A328", VA = "0xA8A328", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xA8A688", Offset = "0xA8A688", VA = "0xA8A688", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xA8A6A8", Offset = "0xA8A6A8", VA = "0xA8A6A8")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xA8A380", Offset = "0xA8A380", VA = "0xA8A380")]
		private void Read()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xA8A70C", Offset = "0xA8A70C", VA = "0xA8A70C")]
		private void Write()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xA8A884", Offset = "0xA8A884", VA = "0xA8A884")]
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
		[Address(RVA = "0xA8AA18", Offset = "0xA8AA18", VA = "0xA8AA18")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xA8AA88", Offset = "0xA8AA88", VA = "0xA8AA88", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xA8AAF8", Offset = "0xA8AAF8", VA = "0xA8AAF8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xA8ADAC", Offset = "0xA8ADAC", VA = "0xA8ADAC")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xA8B43C", Offset = "0xA8B43C", VA = "0xA8B43C")]
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
			[Address(RVA = "0xA8C3E4", Offset = "0xA8C3E4", VA = "0xA8C3E4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xA8B444", Offset = "0xA8B444", VA = "0xA8B444")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xA8BA24", Offset = "0xA8BA24", VA = "0xA8BA24")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xA8BB54", Offset = "0xA8BB54", VA = "0xA8BB54", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xA8BBDC", Offset = "0xA8BBDC", VA = "0xA8BBDC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xA8C0D8", Offset = "0xA8C0D8", VA = "0xA8C0D8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xA8C3EC", Offset = "0xA8C3EC", VA = "0xA8C3EC")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xA8B51C", Offset = "0xA8B51C", VA = "0xA8B51C")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xA8BB0C", Offset = "0xA8BB0C", VA = "0xA8BB0C")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xA8C39C", Offset = "0xA8C39C", VA = "0xA8C39C")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xA8B8B8", Offset = "0xA8B8B8", VA = "0xA8B8B8")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xA8CA98", Offset = "0xA8CA98", VA = "0xA8CA98")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xA8CB00", Offset = "0xA8CB00", VA = "0xA8CB00")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xA8CBD0", Offset = "0xA8CBD0", VA = "0xA8CBD0")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xA8CC98", Offset = "0xA8CC98", VA = "0xA8CC98")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xA8BE50", Offset = "0xA8BE50", VA = "0xA8BE50")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xA8BF94", Offset = "0xA8BF94", VA = "0xA8BF94")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xA8CD88", Offset = "0xA8CD88", VA = "0xA8CD88")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xA8C688", Offset = "0xA8C688", VA = "0xA8C688")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xA8BAFC", Offset = "0xA8BAFC", VA = "0xA8BAFC")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xA8D3F8", Offset = "0xA8D3F8", VA = "0xA8D3F8")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xA8CF48", Offset = "0xA8CF48", VA = "0xA8CF48")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xA8C508", Offset = "0xA8C508", VA = "0xA8C508")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xA8C5D8", Offset = "0xA8C5D8", VA = "0xA8C5D8")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xA8D4B0", Offset = "0xA8D4B0", VA = "0xA8D4B0")]
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
		[Address(RVA = "0xA8D534", Offset = "0xA8D534", VA = "0xA8D534", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xA8DB88", Offset = "0xA8DB88", VA = "0xA8DB88", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xA8DC14", Offset = "0xA8DC14", VA = "0xA8DC14", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xA8DCA8", Offset = "0xA8DCA8", VA = "0xA8DCA8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xA8DD90", Offset = "0xA8DD90", VA = "0xA8DD90")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xA8DE20", Offset = "0xA8DE20", VA = "0xA8DE20", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xA8E220", Offset = "0xA8E220", VA = "0xA8E220", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xA8E3F8", Offset = "0xA8E3F8", VA = "0xA8E3F8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xA8E2C0", Offset = "0xA8E2C0", VA = "0xA8E2C0")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xA8DFF8", Offset = "0xA8DFF8", VA = "0xA8DFF8")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xA8E47C", Offset = "0xA8E47C", VA = "0xA8E47C")]
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
		[Address(RVA = "0xA8E4DC", Offset = "0xA8E4DC", VA = "0xA8E4DC")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xA8E5B8", Offset = "0xA8E5B8", VA = "0xA8E5B8")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xA8E600", Offset = "0xA8E600", VA = "0xA8E600")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xA8E714", Offset = "0xA8E714", VA = "0xA8E714")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xA8E764", Offset = "0xA8E764", VA = "0xA8E764")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xA8E7D8", Offset = "0xA8E7D8", VA = "0xA8E7D8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xA8E970", Offset = "0xA8E970", VA = "0xA8E970", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xA8EACC", Offset = "0xA8EACC", VA = "0xA8EACC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xA8ECCC", Offset = "0xA8ECCC", VA = "0xA8ECCC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xA8EDA0", Offset = "0xA8EDA0", VA = "0xA8EDA0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xA8EE88", Offset = "0xA8EE88", VA = "0xA8EE88", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xA8EFE8", Offset = "0xA8EFE8", VA = "0xA8EFE8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xA8F184", Offset = "0xA8F184", VA = "0xA8F184", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xA8F3BC", Offset = "0xA8F3BC", VA = "0xA8F3BC", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xA8F69C", Offset = "0xA8F69C", VA = "0xA8F69C", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xA8F6D4", Offset = "0xA8F6D4", VA = "0xA8F6D4", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xA8F7B8", Offset = "0xA8F7B8", VA = "0xA8F7B8")]
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
			[Address(RVA = "0xA8F8C8", Offset = "0xA8F8C8", VA = "0xA8F8C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0xA8FA08", Offset = "0xA8FA08", VA = "0xA8FA08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0xA8FA10", Offset = "0xA8FA10", VA = "0xA8FA10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0xA8FA18", Offset = "0xA8FA18", VA = "0xA8FA18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0xA8FA20", Offset = "0xA8FA20", VA = "0xA8FA20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0xA8FA28", Offset = "0xA8FA28", VA = "0xA8FA28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0xA8FA30", Offset = "0xA8FA30", VA = "0xA8FA30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0xA8FA38", Offset = "0xA8FA38", VA = "0xA8FA38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0xA8FA40", Offset = "0xA8FA40", VA = "0xA8FA40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0xA8FA48", Offset = "0xA8FA48", VA = "0xA8FA48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0xA8FA74", Offset = "0xA8FA74", VA = "0xA8FA74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0xA8FAA0", Offset = "0xA8FAA0", VA = "0xA8FAA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0xA8FACC", Offset = "0xA8FACC", VA = "0xA8FACC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0xA8FAF8", Offset = "0xA8FAF8", VA = "0xA8FAF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0xA8FB20", Offset = "0xA8FB20", VA = "0xA8FB20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A2")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0xA8FB4C", Offset = "0xA8FB4C", VA = "0xA8FB4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A3")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0xA8FB78", Offset = "0xA8FB78", VA = "0xA8FB78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A4")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0xA8FBA4", Offset = "0xA8FBA4", VA = "0xA8FBA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0xA91994", Offset = "0xA91994", VA = "0xA91994")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0xA919A0", Offset = "0xA919A0", VA = "0xA919A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xA8FBCC", Offset = "0xA8FBCC", VA = "0xA8FBCC")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xA8FCCC", Offset = "0xA8FCCC", VA = "0xA8FCCC")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xA8FC1C", Offset = "0xA8FC1C", VA = "0xA8FC1C")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xA8FD44", Offset = "0xA8FD44", VA = "0xA8FD44")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xA8F8D0", Offset = "0xA8F8D0", VA = "0xA8F8D0")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xA8FE0C", Offset = "0xA8FE0C", VA = "0xA8FE0C")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xA8FEBC", Offset = "0xA8FEBC", VA = "0xA8FEBC")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xA8FF68", Offset = "0xA8FF68", VA = "0xA8FF68")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xA90014", Offset = "0xA90014", VA = "0xA90014")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xA9001C", Offset = "0xA9001C", VA = "0xA9001C")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xA90044", Offset = "0xA90044", VA = "0xA90044")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xA90104", Offset = "0xA90104", VA = "0xA90104", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xA90294", Offset = "0xA90294", VA = "0xA90294")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xA9128C", Offset = "0xA9128C", VA = "0xA9128C")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xA9183C", Offset = "0xA9183C", VA = "0xA9183C")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xA91898", Offset = "0xA91898", VA = "0xA91898")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xA916DC", Offset = "0xA916DC", VA = "0xA916DC")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xA9178C", Offset = "0xA9178C", VA = "0xA9178C")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xA919AC", Offset = "0xA919AC", VA = "0xA919AC")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xA91A70", Offset = "0xA91A70", VA = "0xA91A70", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xA91B40", Offset = "0xA91B40", VA = "0xA91B40")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xA91C5C", Offset = "0xA91C5C", VA = "0xA91C5C")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xA91DEC", Offset = "0xA91DEC", VA = "0xA91DEC")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xA91F64", Offset = "0xA91F64", VA = "0xA91F64", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xA921C4", Offset = "0xA921C4", VA = "0xA921C4", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xA9223C", Offset = "0xA9223C", VA = "0xA9223C")]
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
			[Address(RVA = "0xA92A7C", Offset = "0xA92A7C", VA = "0xA92A7C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A7")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0xA92A84", Offset = "0xA92A84", VA = "0xA92A84", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A8")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0xA92A8C", Offset = "0xA92A8C", VA = "0xA92A8C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A9")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0xA92F30", Offset = "0xA92F30", VA = "0xA92F30", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000AA")]
		protected float positionOffset
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0xA92FEC", Offset = "0xA92FEC", VA = "0xA92FEC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xA92248", Offset = "0xA92248", VA = "0xA92248")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xA923CC", Offset = "0xA923CC", VA = "0xA923CC")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xA924F8", Offset = "0xA924F8", VA = "0xA924F8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xA92558", Offset = "0xA92558", VA = "0xA92558", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xA925CC", Offset = "0xA925CC", VA = "0xA925CC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xA92998", Offset = "0xA92998", VA = "0xA92998", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xA929A0", Offset = "0xA929A0", VA = "0xA929A0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xA92A94", Offset = "0xA92A94", VA = "0xA92A94", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xA92A98", Offset = "0xA92A98", VA = "0xA92A98", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xA92A9C", Offset = "0xA92A9C", VA = "0xA92A9C")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xA93034", Offset = "0xA93034", VA = "0xA93034")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xA933EC", Offset = "0xA933EC", VA = "0xA933EC")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xA93680", Offset = "0xA93680", VA = "0xA93680")]
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
		[Address(RVA = "0xA936E8", Offset = "0xA936E8", VA = "0xA936E8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xA93A44", Offset = "0xA93A44", VA = "0xA93A44")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xA93AA8", Offset = "0xA93AA8", VA = "0xA93AA8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xA93BEC", Offset = "0xA93BEC", VA = "0xA93BEC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xA93D4C", Offset = "0xA93D4C", VA = "0xA93D4C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xA93D9C", Offset = "0xA93D9C", VA = "0xA93D9C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xA93DFC", Offset = "0xA93DFC", VA = "0xA93DFC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xA9415C", Offset = "0xA9415C", VA = "0xA9415C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xA9417C", Offset = "0xA9417C", VA = "0xA9417C")]
		private void Solve()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xA93E54", Offset = "0xA93E54", VA = "0xA93E54")]
		private void Read()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xA94208", Offset = "0xA94208", VA = "0xA94208")]
		private void Write()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xA94380", Offset = "0xA94380", VA = "0xA94380")]
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
			[Address(RVA = "0xA95904", Offset = "0xA95904", VA = "0xA95904")]
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
			[Address(RVA = "0xA958E8", Offset = "0xA958E8", VA = "0xA958E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xA94518", Offset = "0xA94518", VA = "0xA94518")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xA9455C", Offset = "0xA9455C", VA = "0xA9455C")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xA945C8", Offset = "0xA945C8", VA = "0xA945C8", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xA94B10", Offset = "0xA94B10", VA = "0xA94B10", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xA9562C", Offset = "0xA9562C", VA = "0xA9562C", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xA956D4", Offset = "0xA956D4", VA = "0xA956D4")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xA95868", Offset = "0xA95868", VA = "0xA95868")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xA94924", Offset = "0xA94924", VA = "0xA94924")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xA94BCC", Offset = "0xA94BCC", VA = "0xA94BCC")]
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
				[Address(RVA = "0xA976D0", Offset = "0xA976D0", VA = "0xA976D0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000507")]
			[Address(RVA = "0xA97D28", Offset = "0xA97D28", VA = "0xA97D28")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000508")]
			[Address(RVA = "0xA96830", Offset = "0xA96830", VA = "0xA96830")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000509")]
			[Address(RVA = "0xA96AE0", Offset = "0xA96AE0", VA = "0xA96AE0")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x600050A")]
			[Address(RVA = "0xA97A18", Offset = "0xA97A18", VA = "0xA97A18")]
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
			[Address(RVA = "0xA96034", Offset = "0xA96034", VA = "0xA96034")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AD")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0xA961DC", Offset = "0xA961DC", VA = "0xA961DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AE")]
		protected bool headIsValid
		{
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0xA96100", Offset = "0xA96100", VA = "0xA96100")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AF")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0xA96200", Offset = "0xA96200", VA = "0xA96200")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B0")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x6000501")]
			[Address(RVA = "0xA96110", Offset = "0xA96110", VA = "0xA96110")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B1")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x6000502")]
			[Address(RVA = "0xA9626C", Offset = "0xA9626C", VA = "0xA9626C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xA95AA0", Offset = "0xA95AA0", VA = "0xA95AA0")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xA95ABC", Offset = "0xA95ABC", VA = "0xA95ABC")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xA95AE8", Offset = "0xA95AE8", VA = "0xA95AE8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xA95B20", Offset = "0xA95B20", VA = "0xA95B20")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xA95B68", Offset = "0xA95B68", VA = "0xA95B68")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xA95BC0", Offset = "0xA95BC0", VA = "0xA95BC0")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xA95C30", Offset = "0xA95C30", VA = "0xA95C30", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xA95D48", Offset = "0xA95D48", VA = "0xA95D48")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xA95D54", Offset = "0xA95D54", VA = "0xA95D54", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xA95E84", Offset = "0xA95E84", VA = "0xA95E84", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xA96290", Offset = "0xA96290", VA = "0xA96290", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xA964B4", Offset = "0xA964B4", VA = "0xA964B4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xA96614", Offset = "0xA96614", VA = "0xA96614")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xA96858", Offset = "0xA96858", VA = "0xA96858", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xA96BCC", Offset = "0xA96BCC", VA = "0xA96BCC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xA96C90", Offset = "0xA96C90", VA = "0xA96C90")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xA96EAC", Offset = "0xA96EAC", VA = "0xA96EAC")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xA971F4", Offset = "0xA971F4", VA = "0xA971F4")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xA97700", Offset = "0xA97700", VA = "0xA97700")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xA966C4", Offset = "0xA966C4", VA = "0xA966C4")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xA97B20", Offset = "0xA97B20", VA = "0xA97B20")]
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
			[Address(RVA = "0xA98FCC", Offset = "0xA98FCC", VA = "0xA98FCC")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000524")]
			[Address(RVA = "0xA99874", Offset = "0xA99874", VA = "0xA99874")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000525")]
			[Address(RVA = "0xA94598", Offset = "0xA94598", VA = "0xA94598")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000526")]
			[Address(RVA = "0xA99910", Offset = "0xA99910", VA = "0xA99910")]
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
		[Address(RVA = "0xA97D30", Offset = "0xA97D30", VA = "0xA97D30")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xA97EC4", Offset = "0xA97EC4", VA = "0xA97EC4")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xA98044", Offset = "0xA98044", VA = "0xA98044")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xA98050", Offset = "0xA98050", VA = "0xA98050")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xA9806C", Offset = "0xA9806C", VA = "0xA9806C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xA98078", Offset = "0xA98078", VA = "0xA98078")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xA98080", Offset = "0xA98080", VA = "0xA98080", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xA9816C", Offset = "0xA9816C", VA = "0xA9816C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xA98264", Offset = "0xA98264", VA = "0xA98264", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xA982A4", Offset = "0xA982A4", VA = "0xA982A4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xA982F4", Offset = "0xA982F4", VA = "0xA982F4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xA98698", Offset = "0xA98698", VA = "0xA98698")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xA986E4", Offset = "0xA986E4", VA = "0xA986E4")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xA98BD8", Offset = "0xA98BD8", VA = "0xA98BD8")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xA98D30", Offset = "0xA98D30", VA = "0xA98D30", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xA98EDC", Offset = "0xA98EDC", VA = "0xA98EDC")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xA98E5C", Offset = "0xA98E5C", VA = "0xA98E5C")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xA990BC", Offset = "0xA990BC", VA = "0xA990BC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xA99904", Offset = "0xA99904", VA = "0xA99904", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xA99908", Offset = "0xA99908", VA = "0xA99908", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xA9990C", Offset = "0xA9990C", VA = "0xA9990C", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xA996B4", Offset = "0xA996B4", VA = "0xA996B4")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xA95740", Offset = "0xA95740", VA = "0xA95740")]
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
				[Address(RVA = "0xA9F0F8", Offset = "0xA9F0F8", VA = "0xA9F0F8")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000544")]
				[Address(RVA = "0xA9F104", Offset = "0xA9F104", VA = "0xA9F104")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B5")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000545")]
				[Address(RVA = "0xA9F110", Offset = "0xA9F110", VA = "0xA9F110")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000546")]
				[Address(RVA = "0xA9F11C", Offset = "0xA9F11C", VA = "0xA9F11C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B6")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000547")]
				[Address(RVA = "0xA9F128", Offset = "0xA9F128", VA = "0xA9F128")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B7")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000548")]
				[Address(RVA = "0xA9F150", Offset = "0xA9F150", VA = "0xA9F150")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000549")]
				[Address(RVA = "0xA9F184", Offset = "0xA9F184", VA = "0xA9F184")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B9")]
			private VirtualBone hand
			{
				[Token(Token = "0x600054A")]
				[Address(RVA = "0xA9F1C4", Offset = "0xA9F1C4", VA = "0xA9F1C4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0xA9F204", Offset = "0xA9F204", VA = "0xA9F204", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0xA9FB04", Offset = "0xA9FB04", VA = "0xA9FB04", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0xA9FDB0", Offset = "0xA9FDB0", VA = "0xA9FDB0", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600054E")]
			[Address(RVA = "0xA9FDD4", Offset = "0xA9FDD4", VA = "0xA9FDD4")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600054F")]
			[Address(RVA = "0xA9D034", Offset = "0xA9D034", VA = "0xA9D034")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000550")]
			[Address(RVA = "0xAA06A0", Offset = "0xAA06A0", VA = "0xAA06A0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0xAA06F8", Offset = "0xAA06F8", VA = "0xAA06F8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000552")]
			[Address(RVA = "0xAA0124", Offset = "0xAA0124", VA = "0xAA0124")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000553")]
			[Address(RVA = "0xAA01A4", Offset = "0xAA01A4", VA = "0xAA01A4")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000554")]
			[Address(RVA = "0xAA0904", Offset = "0xAA0904", VA = "0xAA0904")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000555")]
			[Address(RVA = "0xA9EF68", Offset = "0xA9EF68", VA = "0xA9EF68")]
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
				[Address(RVA = "0xAA0A1C", Offset = "0xAA0A1C", VA = "0xAA0A1C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600055C")]
				[Address(RVA = "0xAA0A24", Offset = "0xAA0A24", VA = "0xAA0A24")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000BB")]
			public float mag
			{
				[Token(Token = "0x600055D")]
				[Address(RVA = "0xAA0A2C", Offset = "0xAA0A2C", VA = "0xAA0A2C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600055E")]
				[Address(RVA = "0xAA0A34", Offset = "0xAA0A34", VA = "0xAA0A34")]
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
			[Address(RVA = "0xAA0A3C", Offset = "0xAA0A3C", VA = "0xAA0A3C")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000560")]
			[Address(RVA = "0xAA0A44", Offset = "0xAA0A44", VA = "0xAA0A44")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000561")]
			[Address(RVA = "0xAA0C60", Offset = "0xAA0C60", VA = "0xAA0C60")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000562")]
			[Address(RVA = "0xAA0CE8", Offset = "0xAA0CE8", VA = "0xAA0CE8")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000563")]
			[Address(RVA = "0xAA0EEC", Offset = "0xAA0EEC", VA = "0xAA0EEC")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000564")]
			[Address(RVA = "0xAA0F34", Offset = "0xAA0F34", VA = "0xAA0F34")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000565")]
			[Address(RVA = "0xAA1058", Offset = "0xAA1058", VA = "0xAA1058")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000566")]
			[Address(RVA = "0xAA11BC", Offset = "0xAA11BC", VA = "0xAA11BC")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000567")]
			[Address(RVA = "0xAA12E0", Offset = "0xAA12E0", VA = "0xAA12E0")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000568")]
			[Address(RVA = "0xAA12F4", Offset = "0xAA12F4", VA = "0xAA12F4")]
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
				[Address(RVA = "0xAA138C", Offset = "0xAA138C", VA = "0xAA138C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000BD")]
			public float stepProgress
			{
				[Token(Token = "0x600056A")]
				[Address(RVA = "0xAA13A0", Offset = "0xAA13A0", VA = "0xAA13A0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600056B")]
				[Address(RVA = "0xAA13A8", Offset = "0xAA13A8", VA = "0xAA13A8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600056C")]
			[Address(RVA = "0xAA13B0", Offset = "0xAA13B0", VA = "0xAA13B0")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x600056D")]
			[Address(RVA = "0xAA1574", Offset = "0xAA1574", VA = "0xAA1574")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x600056E")]
			[Address(RVA = "0xAA15BC", Offset = "0xAA15BC", VA = "0xAA15BC")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0xAA1800", Offset = "0xAA1800", VA = "0xAA1800")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000570")]
			[Address(RVA = "0xAA1A08", Offset = "0xAA1A08", VA = "0xAA1A08")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0xAA1BEC", Offset = "0xAA1BEC", VA = "0xAA1BEC")]
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
				[Address(RVA = "0xAA1D60", Offset = "0xAA1D60", VA = "0xAA1D60")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000573")]
				[Address(RVA = "0xAA1D6C", Offset = "0xAA1D6C", VA = "0xAA1D6C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000BF")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000574")]
				[Address(RVA = "0xAA1D78", Offset = "0xAA1D78", VA = "0xAA1D78")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000575")]
				[Address(RVA = "0xAA1D84", Offset = "0xAA1D84", VA = "0xAA1D84")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000C0")]
			public bool hasToes
			{
				[Token(Token = "0x6000576")]
				[Address(RVA = "0xAA1D90", Offset = "0xAA1D90", VA = "0xAA1D90")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000577")]
				[Address(RVA = "0xAA1D98", Offset = "0xAA1D98", VA = "0xAA1D98")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000C1")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000578")]
				[Address(RVA = "0xAA1DA4", Offset = "0xAA1DA4", VA = "0xAA1DA4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000579")]
				[Address(RVA = "0xAA1DCC", Offset = "0xAA1DCC", VA = "0xAA1DCC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C3")]
			private VirtualBone foot
			{
				[Token(Token = "0x600057A")]
				[Address(RVA = "0xAA1DF8", Offset = "0xAA1DF8", VA = "0xAA1DF8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			private VirtualBone toes
			{
				[Token(Token = "0x600057B")]
				[Address(RVA = "0xAA1E24", Offset = "0xAA1E24", VA = "0xAA1E24")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C5")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x600057C")]
				[Address(RVA = "0xAA1E50", Offset = "0xAA1E50", VA = "0xAA1E50")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C6")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x600057D")]
				[Address(RVA = "0xAA1E84", Offset = "0xAA1E84", VA = "0xAA1E84")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600057E")]
				[Address(RVA = "0xAA1E90", Offset = "0xAA1E90", VA = "0xAA1E90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600057F")]
			[Address(RVA = "0xAA1E9C", Offset = "0xAA1E9C", VA = "0xAA1E9C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000580")]
			[Address(RVA = "0xAA2454", Offset = "0xAA2454", VA = "0xAA2454", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000581")]
			[Address(RVA = "0xAA2C84", Offset = "0xAA2C84", VA = "0xAA2C84", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000582")]
			[Address(RVA = "0xAA2C34", Offset = "0xAA2C34", VA = "0xAA2C34")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000583")]
			[Address(RVA = "0xAA29E8", Offset = "0xAA29E8", VA = "0xAA29E8")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000584")]
			[Address(RVA = "0xAA3160", Offset = "0xAA3160", VA = "0xAA3160")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000585")]
			[Address(RVA = "0xAA3B64", Offset = "0xAA3B64", VA = "0xAA3B64")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x6000586")]
			[Address(RVA = "0xAA33A4", Offset = "0xAA33A4", VA = "0xAA33A4")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000587")]
			[Address(RVA = "0xAA3FBC", Offset = "0xAA3FBC", VA = "0xAA3FBC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000588")]
			[Address(RVA = "0xAA41C4", Offset = "0xAA41C4", VA = "0xAA41C4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000589")]
			[Address(RVA = "0xAA42A4", Offset = "0xAA42A4", VA = "0xAA42A4")]
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
				[Address(RVA = "0xAA4380", Offset = "0xAA4380", VA = "0xAA4380")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600058B")]
				[Address(RVA = "0xAA438C", Offset = "0xAA438C", VA = "0xAA438C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000C8")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000592")]
				[Address(RVA = "0xAA65FC", Offset = "0xAA65FC", VA = "0xAA65FC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000C9")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000593")]
				[Address(RVA = "0xAA6630", Offset = "0xAA6630", VA = "0xAA6630")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000CA")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000594")]
				[Address(RVA = "0xAA6668", Offset = "0xAA6668", VA = "0xAA6668")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000CB")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000595")]
				[Address(RVA = "0xAA669C", Offset = "0xAA669C", VA = "0xAA669C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600058C")]
			[Address(RVA = "0xAA4398", Offset = "0xAA4398", VA = "0xAA4398")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x600058D")]
			[Address(RVA = "0xAA46A0", Offset = "0xAA46A0", VA = "0xAA46A0")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x600058E")]
			[Address(RVA = "0xAA4884", Offset = "0xAA4884", VA = "0xAA4884")]
			public void Relax()
			{
			}

			[Token(Token = "0x600058F")]
			[Address(RVA = "0xAA48D0", Offset = "0xAA48D0", VA = "0xAA48D0")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000590")]
			[Address(RVA = "0xAA4C98", Offset = "0xAA4C98", VA = "0xAA4C98")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000591")]
			[Address(RVA = "0xAA4D50", Offset = "0xAA4D50", VA = "0xAA4D50")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale)
			{
			}

			[Token(Token = "0x6000596")]
			[Address(RVA = "0xAA622C", Offset = "0xAA622C", VA = "0xAA622C")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000597")]
			[Address(RVA = "0xAA63E0", Offset = "0xAA63E0", VA = "0xAA63E0")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000598")]
			[Address(RVA = "0xAA644C", Offset = "0xAA644C", VA = "0xAA644C")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000599")]
			[Address(RVA = "0xAA66D4", Offset = "0xAA66D4", VA = "0xAA66D4")]
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
				[Address(RVA = "0xAA61C4", Offset = "0xAA61C4", VA = "0xAA61C4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CD")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x600059B")]
				[Address(RVA = "0xAA67CC", Offset = "0xAA67CC", VA = "0xAA67CC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			public VirtualBone chest
			{
				[Token(Token = "0x600059C")]
				[Address(RVA = "0xAA6800", Offset = "0xAA6800", VA = "0xAA6800")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CF")]
			private VirtualBone neck
			{
				[Token(Token = "0x600059D")]
				[Address(RVA = "0xAA6848", Offset = "0xAA6848", VA = "0xAA6848")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D0")]
			public VirtualBone head
			{
				[Token(Token = "0x600059E")]
				[Address(RVA = "0xAA61F8", Offset = "0xAA61F8", VA = "0xAA61F8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x600059F")]
				[Address(RVA = "0xAA687C", Offset = "0xAA687C", VA = "0xAA687C")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60005A0")]
				[Address(RVA = "0xAA6890", Offset = "0xAA6890", VA = "0xAA6890")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000D2")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x60005A1")]
				[Address(RVA = "0xAA68A4", Offset = "0xAA68A4", VA = "0xAA68A4")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60005A2")]
				[Address(RVA = "0xAA68B8", Offset = "0xAA68B8", VA = "0xAA68B8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0xAA68CC", Offset = "0xAA68CC", VA = "0xAA68CC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0xAA752C", Offset = "0xAA752C", VA = "0xAA752C", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0xAA7714", Offset = "0xAA7714", VA = "0xAA7714", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0xAA7EBC", Offset = "0xAA7EBC", VA = "0xAA7EBC")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0xAA84F8", Offset = "0xAA84F8", VA = "0xAA84F8")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0xAA8E58", Offset = "0xAA8E58", VA = "0xAA8E58")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xAA95FC", Offset = "0xAA95FC", VA = "0xAA95FC")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0xAA9BDC", Offset = "0xAA9BDC", VA = "0xAA9BDC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xAA9DAC", Offset = "0xAA9DAC", VA = "0xAA9DAC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60005AC")]
			[Address(RVA = "0xAA8100", Offset = "0xAA8100", VA = "0xAA8100")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x60005AD")]
			[Address(RVA = "0xAA9328", Offset = "0xAA9328", VA = "0xAA9328")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x60005AE")]
			[Address(RVA = "0xAA8A3C", Offset = "0xAA8A3C", VA = "0xAA8A3C")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x60005AF")]
			[Address(RVA = "0xAA9E80", Offset = "0xAA9E80", VA = "0xAA9E80")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005B0")]
			[Address(RVA = "0xAA9400", Offset = "0xAA9400", VA = "0xAA9400")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0xAA90B8", Offset = "0xAA90B8", VA = "0xAA90B8")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60005B2")]
			[Address(RVA = "0xAAA11C", Offset = "0xAAA11C", VA = "0xAAA11C")]
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
			[Address(RVA = "0xAA23C4", Offset = "0xAA23C4", VA = "0xAA23C4")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0xAA2434", Offset = "0xAA2434", VA = "0xAA2434")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005B5")]
			[Address(RVA = "0xAAA234", Offset = "0xAAA234", VA = "0xAAA234")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0xAA0B00", Offset = "0xAA0B00", VA = "0xAA0B00")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0xAA0D7C", Offset = "0xAA0D7C", VA = "0xAA0D7C")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005B8")]
			[Address(RVA = "0xAAA434", Offset = "0xAAA434", VA = "0xAAA434")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xAAA5DC", Offset = "0xAAA5DC", VA = "0xAAA5DC")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0xAAA764", Offset = "0xAAA764", VA = "0xAAA764")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0xAA3780", Offset = "0xAA3780", VA = "0xAA3780")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0xAAA808", Offset = "0xAAA808", VA = "0xAAA808")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0xAA9810", Offset = "0xAA9810", VA = "0xAA9810")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0xAAA960", Offset = "0xAAA960", VA = "0xAAA960")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0xAAAA74", Offset = "0xAAAA74", VA = "0xAAAA74")]
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
			[Address(RVA = "0xA9ED1C", Offset = "0xA9ED1C", VA = "0xA9ED1C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600053F")]
			[Address(RVA = "0xA9ED24", Offset = "0xA9ED24", VA = "0xA9ED24")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xA99918", Offset = "0xA99918", VA = "0xA99918")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xA99D38", Offset = "0xA99D38", VA = "0xA99D38")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xA99BEC", Offset = "0xA99BEC", VA = "0xA99BEC")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xA9A14C", Offset = "0xA9A14C", VA = "0xA9A14C")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xA9A290", Offset = "0xA9A290", VA = "0xA9A290")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xA9A2D0", Offset = "0xA9A2D0", VA = "0xA9A2D0")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xA9A3F4", Offset = "0xA9A3F4", VA = "0xA9A3F4")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xA9A4D0", Offset = "0xA9A4D0", VA = "0xA9A4D0")]
		public void Reset()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xA9AC5C", Offset = "0xA9AC5C", VA = "0xA9AC5C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xA9ADB0", Offset = "0xA9ADB0", VA = "0xA9ADB0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xA9AF9C", Offset = "0xA9AF9C", VA = "0xA9AF9C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xA9B00C", Offset = "0xA9B00C", VA = "0xA9B00C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xA9B07C", Offset = "0xA9B07C", VA = "0xA9B07C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xA9B278", Offset = "0xA9B278", VA = "0xA9B278")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xA9A038", Offset = "0xA9A038", VA = "0xA9A038")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xA9A5E4", Offset = "0xA9A5E4", VA = "0xA9A5E4")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xA9B4E8", Offset = "0xA9B4E8", VA = "0xA9B4E8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xA9B524", Offset = "0xA9B524", VA = "0xA9B524", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xA9CB6C", Offset = "0xA9CB6C", VA = "0xA9CB6C")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xA9A734", Offset = "0xA9A734", VA = "0xA9A734")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xA9B930", Offset = "0xA9B930", VA = "0xA9B930")]
		private void Solve()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xA9CFC0", Offset = "0xA9CFC0", VA = "0xA9CFC0")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xA9CFFC", Offset = "0xA9CFFC", VA = "0xA9CFFC")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xA9CA30", Offset = "0xA9CA30", VA = "0xA9CA30")]
		private void Write()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xA9E630", Offset = "0xA9E630", VA = "0xA9E630")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xA9ED2C", Offset = "0xA9ED2C", VA = "0xA9ED2C")]
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
		[Address(RVA = "0xAAAC28", Offset = "0xAAAC28", VA = "0xAAAC28")]
		public void Start()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xAAB254", Offset = "0xAAB254", VA = "0xAAB254")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xAAB7E8", Offset = "0xAAB7E8", VA = "0xAAB7E8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xAAB898", Offset = "0xAAB898", VA = "0xAAB898")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xAAB9B0", Offset = "0xAAB9B0", VA = "0xAAB9B0")]
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
		[Address(RVA = "0xAABA08", Offset = "0xAABA08", VA = "0xAABA08")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xAAADF0", Offset = "0xAAADF0", VA = "0xAAADF0")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xAAB304", Offset = "0xAAB304", VA = "0xAAB304")]
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
			[Address(RVA = "0xAABAF0", Offset = "0xAABAF0", VA = "0xAABAF0")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0xAABAF8", Offset = "0xAABAF8", VA = "0xAABAF8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public bool isPaused
		{
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0xAABB00", Offset = "0xAABB00", VA = "0xAABB00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0xAABB08", Offset = "0xAABB08", VA = "0xAABB08")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0xAABB14", Offset = "0xAABB14", VA = "0xAABB14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0xAABB1C", Offset = "0xAABB1C", VA = "0xAABB1C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		public bool inInteraction
		{
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0xAABB24", Offset = "0xAABB24", VA = "0xAABB24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D7")]
		public float progress
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0xAADCE8", Offset = "0xAADCE8", VA = "0xAADCE8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xAABB84", Offset = "0xAABB84", VA = "0xAABB84")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xAABC14", Offset = "0xAABC14", VA = "0xAABC14")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xAABCA0", Offset = "0xAABCA0", VA = "0xAABCA0")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xAABE0C", Offset = "0xAABE0C", VA = "0xAABE0C")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xAAC1E8", Offset = "0xAAC1E8", VA = "0xAAC1E8")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xAAC308", Offset = "0xAAC308", VA = "0xAAC308")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xAAC35C", Offset = "0xAAC35C", VA = "0xAAC35C")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xAAC9AC", Offset = "0xAAC9AC", VA = "0xAAC9AC")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xAAD4A0", Offset = "0xAAD4A0", VA = "0xAAD4A0")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xAAD6C0", Offset = "0xAAD6C0", VA = "0xAAD6C0")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xAADB9C", Offset = "0xAADB9C", VA = "0xAADB9C")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xAADE5C", Offset = "0xAADE5C", VA = "0xAADE5C")]
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
		[Address(RVA = "0xAAE124", Offset = "0xAAE124", VA = "0xAAE124")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xAAE234", Offset = "0xAAE234", VA = "0xAAE234")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xAAE2CC", Offset = "0xAAE2CC", VA = "0xAAE2CC")]
		public void Update()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xAAE4BC", Offset = "0xAAE4BC", VA = "0xAAE4BC")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xAAE564", Offset = "0xAAE564", VA = "0xAAE564")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xAAE610", Offset = "0xAAE610", VA = "0xAAE610")]
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
			[Address(RVA = "0xAADD18", Offset = "0xAADD18", VA = "0xAADD18")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0xAAF514", Offset = "0xAAF514", VA = "0xAAF514")]
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
			[Address(RVA = "0xAAF41C", Offset = "0xAAF41C", VA = "0xAAF41C")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0xAAF51C", Offset = "0xAAF51C", VA = "0xAAF51C")]
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
			[Address(RVA = "0xAAF340", Offset = "0xAAF340", VA = "0xAAF340")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0xAAF524", Offset = "0xAAF524", VA = "0xAAF524")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0xAAF5D4", Offset = "0xAAF5D4", VA = "0xAAF5D4")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0xAAF6AC", Offset = "0xAAF6AC", VA = "0xAAF6AC")]
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
			[Address(RVA = "0xAAEC50", Offset = "0xAAEC50", VA = "0xAAEC50")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0xAAF6C0", Offset = "0xAAF6C0", VA = "0xAAF6C0")]
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
			[Address(RVA = "0xAAF258", Offset = "0xAAF258", VA = "0xAAF258")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0xAAF6C8", Offset = "0xAAF6C8", VA = "0xAAF6C8")]
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
			[Address(RVA = "0xAAE844", Offset = "0xAAE844", VA = "0xAAE844")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0xAAE84C", Offset = "0xAAE84C", VA = "0xAAE84C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xAAE854", Offset = "0xAAE854", VA = "0xAAE854")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0xAAE85C", Offset = "0xAAE85C", VA = "0xAAE85C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0xAAEA14", Offset = "0xAAEA14", VA = "0xAAEA14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DB")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0xAADDDC", Offset = "0xAADDDC", VA = "0xAADDDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xAAE624", Offset = "0xAAE624", VA = "0xAAE624")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xAAE668", Offset = "0xAAE668", VA = "0xAAE668")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xAAE6AC", Offset = "0xAAE6AC", VA = "0xAAE6AC")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xAAE6F0", Offset = "0xAAE6F0", VA = "0xAAE6F0")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xAAE734", Offset = "0xAAE734", VA = "0xAAE734")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xAAE778", Offset = "0xAAE778", VA = "0xAAE778")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xAAE7BC", Offset = "0xAAE7BC", VA = "0xAAE7BC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xAAE800", Offset = "0xAAE800", VA = "0xAAE800")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xAAE864", Offset = "0xAAE864", VA = "0xAAE864")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xAAEA94", Offset = "0xAAEA94", VA = "0xAAEA94")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xAAC918", Offset = "0xAAC918", VA = "0xAAC918")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xAAEBE4", Offset = "0xAAEBE4", VA = "0xAAEBE4")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xAAC7DC", Offset = "0xAAC7DC", VA = "0xAAC7DC")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xAAC910", Offset = "0xAAC910", VA = "0xAAC910")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xAAD090", Offset = "0xAAD090", VA = "0xAAD090")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xAAD988", Offset = "0xAAD988", VA = "0xAAD988")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xAAF288", Offset = "0xAAF288", VA = "0xAAF288")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xAAEC6C", Offset = "0xAAEC6C", VA = "0xAAEC6C")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xAAEBEC", Offset = "0xAAEBEC", VA = "0xAAEBEC")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xAAF1FC", Offset = "0xAAF1FC", VA = "0xAAF1FC")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xAAF28C", Offset = "0xAAF28C", VA = "0xAAF28C")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xAAF2E8", Offset = "0xAAF2E8", VA = "0xAAF2E8")]
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
			[Address(RVA = "0xAAF8F8", Offset = "0xAAF8F8", VA = "0xAAF8F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DD")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0xAB1358", Offset = "0xAB1358", VA = "0xAB1358")]
			get
			{
				return null;
			}
			[Token(Token = "0x600062D")]
			[Address(RVA = "0xAB1360", Offset = "0xAB1360", VA = "0xAB1360")]
			set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x600062E")]
			[Address(RVA = "0xAB1368", Offset = "0xAB1368", VA = "0xAB1368")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600062F")]
			[Address(RVA = "0xAB1370", Offset = "0xAB1370", VA = "0xAB1370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public bool initiated
		{
			[Token(Token = "0x6000630")]
			[Address(RVA = "0xAB1378", Offset = "0xAB1378", VA = "0xAB1378")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000631")]
			[Address(RVA = "0xAB1380", Offset = "0xAB1380", VA = "0xAB1380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xAAF6D8", Offset = "0xAAF6D8", VA = "0xAAF6D8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xAAF71C", Offset = "0xAAF71C", VA = "0xAAF71C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xAAF760", Offset = "0xAAF760", VA = "0xAAF760")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xAAF7A4", Offset = "0xAAF7A4", VA = "0xAAF7A4")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xAAF7E8", Offset = "0xAAF7E8", VA = "0xAAF7E8")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xAAF82C", Offset = "0xAAF82C", VA = "0xAAF82C")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xAAF870", Offset = "0xAAF870", VA = "0xAAF870")]
		[ContextMenu("Support")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xAAF8B4", Offset = "0xAAF8B4", VA = "0xAAF8B4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xAAFA70", Offset = "0xAAFA70", VA = "0xAAFA70")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xAAFB28", Offset = "0xAAFB28", VA = "0xAAFB28")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xAAFBE0", Offset = "0xAAFBE0", VA = "0xAAFBE0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xAAFC78", Offset = "0xAAFC78", VA = "0xAAFC78")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xAAFD5C", Offset = "0xAAFD5C", VA = "0xAAFD5C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xAAFE54", Offset = "0xAAFE54", VA = "0xAAFE54")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xAAFED8", Offset = "0xAAFED8", VA = "0xAAFED8")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xAAFF5C", Offset = "0xAAFF5C", VA = "0xAAFF5C")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xAAFFE0", Offset = "0xAAFFE0", VA = "0xAAFFE0")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xAB0048", Offset = "0xAB0048", VA = "0xAB0048")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xAB00B0", Offset = "0xAB00B0", VA = "0xAB00B0")]
		public void StopAll()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xAB010C", Offset = "0xAB010C", VA = "0xAB010C")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xAB018C", Offset = "0xAB018C", VA = "0xAB018C")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xAB0234", Offset = "0xAB0234", VA = "0xAB0234")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xAB0304", Offset = "0xAB0304", VA = "0xAB0304")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xAB0594", Offset = "0xAB0594", VA = "0xAB0594")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xAB0750", Offset = "0xAB0750", VA = "0xAB0750")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xAB09B8", Offset = "0xAB09B8", VA = "0xAB09B8")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xAB0C44", Offset = "0xAB0C44", VA = "0xAB0C44")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xAB0C7C", Offset = "0xAB0C7C", VA = "0xAB0C7C")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xAB0CDC", Offset = "0xAB0CDC", VA = "0xAB0CDC")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xAB0DE4", Offset = "0xAB0DE4", VA = "0xAB0DE4")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xAB0FC4", Offset = "0xAB0FC4", VA = "0xAB0FC4")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xAB1238", Offset = "0xAB1238", VA = "0xAB1238")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xAB0AA0", Offset = "0xAB0AA0", VA = "0xAB0AA0")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xAB138C", Offset = "0xAB138C", VA = "0xAB138C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xAB1B24", Offset = "0xAB1B24", VA = "0xAB1B24")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xAB1B44", Offset = "0xAB1B44", VA = "0xAB1B44")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xAB1B60", Offset = "0xAB1B60", VA = "0xAB1B60")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xAB1B7C", Offset = "0xAB1B7C", VA = "0xAB1B7C")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xAB1BD0", Offset = "0xAB1BD0", VA = "0xAB1BD0")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xAB1D3C", Offset = "0xAB1D3C", VA = "0xAB1D3C")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xAB1E38", Offset = "0xAB1E38", VA = "0xAB1E38")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xAB1FE4", Offset = "0xAB1FE4", VA = "0xAB1FE4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xAB20C8", Offset = "0xAB20C8", VA = "0xAB20C8")]
		public void Update()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xAB2388", Offset = "0xAB2388", VA = "0xAB2388")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xAB18DC", Offset = "0xAB18DC", VA = "0xAB18DC")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xAB24B8", Offset = "0xAB24B8", VA = "0xAB24B8")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xAB25C4", Offset = "0xAB25C4", VA = "0xAB25C4")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xAB264C", Offset = "0xAB264C", VA = "0xAB264C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xAB270C", Offset = "0xAB270C", VA = "0xAB270C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xAB2724", Offset = "0xAB2724", VA = "0xAB2724")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xAAF990", Offset = "0xAAF990", VA = "0xAAF990")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xAB0480", Offset = "0xAB0480", VA = "0xAB0480")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xAB2B1C", Offset = "0xAB2B1C", VA = "0xAB2B1C")]
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
			[Address(RVA = "0xAB3B74", Offset = "0xAB3B74", VA = "0xAB3B74")]
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
		[Address(RVA = "0xAB31B0", Offset = "0xAB31B0", VA = "0xAB31B0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xAB31F4", Offset = "0xAB31F4", VA = "0xAB31F4")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xAB3238", Offset = "0xAB3238", VA = "0xAB3238")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xAB327C", Offset = "0xAB327C", VA = "0xAB327C")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xAB32C0", Offset = "0xAB32C0", VA = "0xAB32C0")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xAB3304", Offset = "0xAB3304", VA = "0xAB3304")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xAB3348", Offset = "0xAB3348", VA = "0xAB3348")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xAB338C", Offset = "0xAB338C", VA = "0xAB338C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xAB33D0", Offset = "0xAB33D0", VA = "0xAB33D0")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xAB3434", Offset = "0xAB3434", VA = "0xAB3434")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xAB34C0", Offset = "0xAB34C0", VA = "0xAB34C0")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xAB3B00", Offset = "0xAB3B00", VA = "0xAB3B00")]
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
				[Address(RVA = "0xAB3F8C", Offset = "0xAB3F8C", VA = "0xAB3F8C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E1")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000663")]
				[Address(RVA = "0xAB3F98", Offset = "0xAB3F98", VA = "0xAB3F98")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0xAB4058", Offset = "0xAB4058", VA = "0xAB4058")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0xAB47BC", Offset = "0xAB47BC", VA = "0xAB47BC")]
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
			[Address(RVA = "0xAB47D0", Offset = "0xAB47D0", VA = "0xAB47D0")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0xAB4948", Offset = "0xAB4948", VA = "0xAB4948")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0xAB4C50", Offset = "0xAB4C50", VA = "0xAB4C50")]
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
				[Address(RVA = "0xAB4CD4", Offset = "0xAB4CD4", VA = "0xAB4CD4")]
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
			[Address(RVA = "0xAB3E84", Offset = "0xAB3E84", VA = "0xAB3E84")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0xAB4CC4", Offset = "0xAB4CC4", VA = "0xAB4CC4")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xAB3B7C", Offset = "0xAB3B7C", VA = "0xAB3B7C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xAB3BC0", Offset = "0xAB3BC0", VA = "0xAB3BC0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xAB3C04", Offset = "0xAB3C04", VA = "0xAB3C04")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xAB3C48", Offset = "0xAB3C48", VA = "0xAB3C48")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xAB3C8C", Offset = "0xAB3C8C", VA = "0xAB3C8C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xAB3CD0", Offset = "0xAB3CD0", VA = "0xAB3CD0")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xAB3F34", Offset = "0xAB3F34", VA = "0xAB3F34")]
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
			[Address(RVA = "0xAB4FC8", Offset = "0xAB4FC8", VA = "0xAB4FC8")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0xAB5304", Offset = "0xAB5304", VA = "0xAB5304")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0xAB52C4", Offset = "0xAB52C4", VA = "0xAB52C4")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0xAB5148", Offset = "0xAB5148", VA = "0xAB5148")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xAB4CDC", Offset = "0xAB4CDC", VA = "0xAB4CDC", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xAB5054", Offset = "0xAB5054", VA = "0xAB5054", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xAB5058", Offset = "0xAB5058", VA = "0xAB5058", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xAB5268", Offset = "0xAB5268", VA = "0xAB5268", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xAB4FF8", Offset = "0xAB4FF8", VA = "0xAB4FF8")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xAB4F34", Offset = "0xAB4F34", VA = "0xAB4F34")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xAB5348", Offset = "0xAB5348", VA = "0xAB5348")]
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
		[Address(RVA = "0xAB5368", Offset = "0xAB5368", VA = "0xAB5368", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xAB5424", Offset = "0xAB5424", VA = "0xAB5424", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xAB55C8", Offset = "0xAB55C8", VA = "0xAB55C8", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xAB56B0", Offset = "0xAB56B0", VA = "0xAB56B0", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xAB5478", Offset = "0xAB5478", VA = "0xAB5478")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xAB59E0", Offset = "0xAB59E0", VA = "0xAB59E0")]
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
		[Address(RVA = "0xAB59F0", Offset = "0xAB59F0", VA = "0xAB59F0")]
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
		[Address(RVA = "0xAB59FC", Offset = "0xAB59FC", VA = "0xAB59FC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xAB5A40", Offset = "0xAB5A40", VA = "0xAB5A40", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xAB5A6C", Offset = "0xAB5A6C", VA = "0xAB5A6C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xAB5358", Offset = "0xAB5358", VA = "0xAB5358")]
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
			[Address(RVA = "0xAB602C", Offset = "0xAB602C", VA = "0xAB602C")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0xAB6B74", Offset = "0xAB6B74", VA = "0xAB6B74")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0xAB6934", Offset = "0xAB6934", VA = "0xAB6934")]
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
			[Address(RVA = "0xAB6180", Offset = "0xAB6180", VA = "0xAB6180")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0xAB6C8C", Offset = "0xAB6C8C", VA = "0xAB6C8C")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0xAB6C48", Offset = "0xAB6C48", VA = "0xAB6C48")]
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
				[Address(RVA = "0xAB7190", Offset = "0xAB7190", VA = "0xAB7190", Slot = "4")]
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
				[Address(RVA = "0xAB71D8", Offset = "0xAB71D8", VA = "0xAB71D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0xAB61DC", Offset = "0xAB61DC", VA = "0xAB61DC")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0xAB6FAC", Offset = "0xAB6FAC", VA = "0xAB6FAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0xAB6FB0", Offset = "0xAB6FB0", VA = "0xAB6FB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0xAB7198", Offset = "0xAB7198", VA = "0xAB7198", Slot = "8")]
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
			[Address(RVA = "0xAB5AB0", Offset = "0xAB5AB0", VA = "0xAB5AB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E3")]
		private bool ikUsed
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0xAB6568", Offset = "0xAB6568", VA = "0xAB6568")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xAB5A84", Offset = "0xAB5A84", VA = "0xAB5A84")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xAB5B14", Offset = "0xAB5B14", VA = "0xAB5B14")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xAB5C20", Offset = "0xAB5C20", VA = "0xAB5C20")]
		public void Start()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xAB5BB8", Offset = "0xAB5BB8", VA = "0xAB5BB8")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xAB6204", Offset = "0xAB6204", VA = "0xAB6204")]
		private void Update()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xAB642C", Offset = "0xAB642C", VA = "0xAB642C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xAB64CC", Offset = "0xAB64CC", VA = "0xAB64CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xAB66BC", Offset = "0xAB66BC", VA = "0xAB66BC")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xAB653C", Offset = "0xAB653C", VA = "0xAB653C")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xAB6688", Offset = "0xAB6688", VA = "0xAB6688")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xAB673C", Offset = "0xAB673C", VA = "0xAB673C")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xAB66E0", Offset = "0xAB66E0", VA = "0xAB66E0")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xAB5B5C", Offset = "0xAB5B5C", VA = "0xAB5B5C")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xAB6460", Offset = "0xAB6460", VA = "0xAB6460")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xAB6D9C", Offset = "0xAB6D9C", VA = "0xAB6D9C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xAB6EB4", Offset = "0xAB6EB4", VA = "0xAB6EB4")]
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
			[Address(RVA = "0xAB7644", Offset = "0xAB7644", VA = "0xAB7644")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000E7")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0xAB7650", Offset = "0xAB7650", VA = "0xAB7650")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000E8")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0xAB7680", Offset = "0xAB7680", VA = "0xAB7680")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0xAB7688", Offset = "0xAB7688", VA = "0xAB7688")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xAB71E0", Offset = "0xAB71E0", VA = "0xAB71E0")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xAB721C", Offset = "0xAB721C", VA = "0xAB721C")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xAB7234", Offset = "0xAB7234", VA = "0xAB7234")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xAB75B4", Offset = "0xAB75B4", VA = "0xAB75B4")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xAB7618", Offset = "0xAB7618", VA = "0xAB7618")]
		public void Disable()
		{
		}

		[Token(Token = "0x60006AD")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xAB74B8", Offset = "0xAB74B8", VA = "0xAB74B8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xAB7694", Offset = "0xAB7694", VA = "0xAB7694")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xAB7698", Offset = "0xAB7698", VA = "0xAB7698")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xAB76C0", Offset = "0xAB76C0", VA = "0xAB76C0")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xAB7794", Offset = "0xAB7794", VA = "0xAB7794")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xAB79EC", Offset = "0xAB79EC", VA = "0xAB79EC")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xAB7B40", Offset = "0xAB7B40", VA = "0xAB7B40")]
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
		[Address(RVA = "0xAB7BA0", Offset = "0xAB7BA0", VA = "0xAB7BA0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xAB7BE4", Offset = "0xAB7BE4", VA = "0xAB7BE4")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xAB7C28", Offset = "0xAB7C28", VA = "0xAB7C28")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xAB7C6C", Offset = "0xAB7C6C", VA = "0xAB7C6C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xAB7CB0", Offset = "0xAB7CB0", VA = "0xAB7CB0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xAB7CE8", Offset = "0xAB7CE8", VA = "0xAB7CE8")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xAB800C", Offset = "0xAB800C", VA = "0xAB800C")]
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
		[Address(RVA = "0xAB801C", Offset = "0xAB801C", VA = "0xAB801C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xAB8060", Offset = "0xAB8060", VA = "0xAB8060")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xAB80A4", Offset = "0xAB80A4", VA = "0xAB80A4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xAB80E8", Offset = "0xAB80E8", VA = "0xAB80E8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xAB812C", Offset = "0xAB812C", VA = "0xAB812C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xAB8130", Offset = "0xAB8130", VA = "0xAB8130")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xAB8350", Offset = "0xAB8350", VA = "0xAB8350")]
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
				[Address(RVA = "0xABA098", Offset = "0xABA098", VA = "0xABA098")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000EA")]
			public Vector3 a
			{
				[Token(Token = "0x60006D4")]
				[Address(RVA = "0xABA0C4", Offset = "0xABA0C4", VA = "0xABA0C4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000EB")]
			public Vector3 b
			{
				[Token(Token = "0x60006D5")]
				[Address(RVA = "0xABA0F4", Offset = "0xABA0F4", VA = "0xABA0F4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000EC")]
			public Vector3 c
			{
				[Token(Token = "0x60006D6")]
				[Address(RVA = "0xABA124", Offset = "0xABA124", VA = "0xABA124")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000ED")]
			public bool isValid
			{
				[Token(Token = "0x60006D8")]
				[Address(RVA = "0xAB95E0", Offset = "0xAB95E0", VA = "0xAB95E0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0xAB9A84", Offset = "0xAB9A84", VA = "0xAB9A84")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0xAB9BE8", Offset = "0xAB9BE8", VA = "0xAB9BE8")]
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
			[Address(RVA = "0xAB95F0", Offset = "0xAB95F0", VA = "0xAB95F0")]
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
		[Address(RVA = "0xAB8368", Offset = "0xAB8368", VA = "0xAB8368")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xAB83AC", Offset = "0xAB83AC", VA = "0xAB83AC")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xAB83F0", Offset = "0xAB83F0", VA = "0xAB83F0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xAB8434", Offset = "0xAB8434", VA = "0xAB8434")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xAB8478", Offset = "0xAB8478", VA = "0xAB8478")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xAB8AB0", Offset = "0xAB8AB0", VA = "0xAB8AB0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xAB8B38", Offset = "0xAB8B38", VA = "0xAB8B38")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xAB9118", Offset = "0xAB9118", VA = "0xAB9118")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xAB8504", Offset = "0xAB8504", VA = "0xAB8504")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xAB9654", Offset = "0xAB9654", VA = "0xAB9654")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xAB9E5C", Offset = "0xAB9E5C", VA = "0xAB9E5C")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xAB9EA4", Offset = "0xAB9EA4", VA = "0xAB9EA4")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xAB9F04", Offset = "0xAB9F04", VA = "0xAB9F04")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xAB8E74", Offset = "0xAB8E74", VA = "0xAB8E74")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xAB9F70", Offset = "0xAB9F70", VA = "0xAB9F70")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xABA03C", Offset = "0xABA03C", VA = "0xABA03C")]
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
		[Address(RVA = "0xABA154", Offset = "0xABA154", VA = "0xABA154")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xABA198", Offset = "0xABA198", VA = "0xABA198")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xABA1DC", Offset = "0xABA1DC", VA = "0xABA1DC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xABA220", Offset = "0xABA220", VA = "0xABA220")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xABA264", Offset = "0xABA264", VA = "0xABA264")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xABA280", Offset = "0xABA280", VA = "0xABA280", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xABA2B8", Offset = "0xABA2B8", VA = "0xABA2B8")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xABA664", Offset = "0xABA664", VA = "0xABA664")]
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
				[Address(RVA = "0xABB644", Offset = "0xABB644", VA = "0xABB644", Slot = "4")]
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
				[Address(RVA = "0xABB68C", Offset = "0xABB68C", VA = "0xABB68C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006EA")]
			[Address(RVA = "0xABB450", Offset = "0xABB450", VA = "0xABB450")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0xABB55C", Offset = "0xABB55C", VA = "0xABB55C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0xABB560", Offset = "0xABB560", VA = "0xABB560", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0xABB64C", Offset = "0xABB64C", VA = "0xABB64C", Slot = "8")]
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
			[Address(RVA = "0xABA6EC", Offset = "0xABA6EC", VA = "0xABA6EC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xABA670", Offset = "0xABA670", VA = "0xABA670")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xABA770", Offset = "0xABA770", VA = "0xABA770")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xABAFC0", Offset = "0xABAFC0", VA = "0xABAFC0")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xABB144", Offset = "0xABB144", VA = "0xABB144")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xABB3E8", Offset = "0xABB3E8", VA = "0xABB3E8")]
		[IteratorStateMachine(typeof(<TurnToTarget>d__37))]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xABB478", Offset = "0xABB478", VA = "0xABB478")]
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
			[Address(RVA = "0xABB764", Offset = "0xABB764", VA = "0xABB764")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0xABBCD4", Offset = "0xABBCD4", VA = "0xABBCD4")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0xABBCDC", Offset = "0xABBCDC", VA = "0xABBCDC")]
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
		[Address(RVA = "0xABB694", Offset = "0xABB694", VA = "0xABB694")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xABBC14", Offset = "0xABBC14", VA = "0xABBC14")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xABBC74", Offset = "0xABBC74", VA = "0xABBC74")]
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
				[Address(RVA = "0xABC1A0", Offset = "0xABC1A0", VA = "0xABC1A0")]
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
			[Address(RVA = "0xABBE48", Offset = "0xABBE48", VA = "0xABBE48")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0xABC178", Offset = "0xABC178", VA = "0xABC178")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0xABC188", Offset = "0xABC188", VA = "0xABC188")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xABBCF8", Offset = "0xABBCF8", VA = "0xABBCF8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xABC158", Offset = "0xABC158", VA = "0xABC158")]
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
		[Address(RVA = "0xABC1A8", Offset = "0xABC1A8", VA = "0xABC1A8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xABC210", Offset = "0xABC210", VA = "0xABC210", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xABC4B0", Offset = "0xABC4B0", VA = "0xABC4B0")]
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
		[Address(RVA = "0xABC4CC", Offset = "0xABC4CC", VA = "0xABC4CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xABC59C", Offset = "0xABC59C", VA = "0xABC59C")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xABC830", Offset = "0xABC830", VA = "0xABC830")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xABC93C", Offset = "0xABC93C", VA = "0xABC93C")]
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
			[Address(RVA = "0xABC94C", Offset = "0xABC94C", VA = "0xABC94C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000704")]
			[Address(RVA = "0xABC954", Offset = "0xABC954", VA = "0xABC954")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xABC95C", Offset = "0xABC95C", VA = "0xABC95C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xABCAD0", Offset = "0xABCAD0", VA = "0xABCAD0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xABCD2C", Offset = "0xABCD2C", VA = "0xABCD2C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xABCE58", Offset = "0xABCE58", VA = "0xABCE58")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xABD00C", Offset = "0xABD00C", VA = "0xABD00C")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xABD210", Offset = "0xABD210", VA = "0xABD210")]
		public void Update()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xABD484", Offset = "0xABD484", VA = "0xABD484")]
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
			[Address(RVA = "0xABCBAC", Offset = "0xABCBAC", VA = "0xABCBAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xABCECC", Offset = "0xABCECC", VA = "0xABCECC")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xABCBD0", Offset = "0xABCBD0", VA = "0xABCBD0")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xABD4DC", Offset = "0xABD4DC", VA = "0xABD4DC")]
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
				[Address(RVA = "0xABD5FC", Offset = "0xABD5FC", VA = "0xABD5FC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000F5")]
			protected float crossFader
			{
				[Token(Token = "0x6000715")]
				[Address(RVA = "0xABDAFC", Offset = "0xABDAFC", VA = "0xABDAFC")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000716")]
				[Address(RVA = "0xABDB04", Offset = "0xABDB04", VA = "0xABDB04")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000F6")]
			protected float timer
			{
				[Token(Token = "0x6000717")]
				[Address(RVA = "0xABDB0C", Offset = "0xABDB0C", VA = "0xABDB0C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000718")]
				[Address(RVA = "0xABDB14", Offset = "0xABDB14", VA = "0xABDB14")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000F7")]
			protected Vector3 force
			{
				[Token(Token = "0x6000719")]
				[Address(RVA = "0xABDB1C", Offset = "0xABDB1C", VA = "0xABDB1C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600071A")]
				[Address(RVA = "0xABDB28", Offset = "0xABDB28", VA = "0xABDB28")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000F8")]
			protected Vector3 point
			{
				[Token(Token = "0x600071B")]
				[Address(RVA = "0xABDB34", Offset = "0xABDB34", VA = "0xABDB34")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600071C")]
				[Address(RVA = "0xABDB40", Offset = "0xABDB40", VA = "0xABDB40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0xABD9C4", Offset = "0xABD9C4", VA = "0xABD9C4")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x600071E")]
			[Address(RVA = "0xABD6D0", Offset = "0xABD6D0", VA = "0xABD6D0")]
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
			[Address(RVA = "0xABDB4C", Offset = "0xABDB4C", VA = "0xABDB4C")]
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
				[Address(RVA = "0xABDE80", Offset = "0xABDE80", VA = "0xABDE80")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000728")]
				[Address(RVA = "0xABDCDC", Offset = "0xABDCDC", VA = "0xABDCDC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000729")]
				[Address(RVA = "0xABDF30", Offset = "0xABDF30", VA = "0xABDF30")]
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
			[Address(RVA = "0xABDB60", Offset = "0xABDB60", VA = "0xABDB60", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000724")]
			[Address(RVA = "0xABDC7C", Offset = "0xABDC7C", VA = "0xABDC7C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0xABDCF0", Offset = "0xABDCF0", VA = "0xABDCF0", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000726")]
			[Address(RVA = "0xABDF1C", Offset = "0xABDF1C", VA = "0xABDF1C")]
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
				[Address(RVA = "0xABE1F0", Offset = "0xABE1F0", VA = "0xABE1F0")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600072F")]
				[Address(RVA = "0xABE01C", Offset = "0xABE01C", VA = "0xABE01C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000730")]
				[Address(RVA = "0xABE390", Offset = "0xABE390", VA = "0xABE390")]
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
			[Address(RVA = "0xABDF38", Offset = "0xABDF38", VA = "0xABDF38", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0xABDFC4", Offset = "0xABDFC4", VA = "0xABDFC4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0xABE028", Offset = "0xABE028", VA = "0xABE028", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600072D")]
			[Address(RVA = "0xABE37C", Offset = "0xABE37C", VA = "0xABE37C")]
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
			[Address(RVA = "0xABD560", Offset = "0xABD560", VA = "0xABD560")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xABD610", Offset = "0xABD610", VA = "0xABD610", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xABD7A8", Offset = "0xABD7A8", VA = "0xABD7A8")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xABDAEC", Offset = "0xABDAEC", VA = "0xABDAEC")]
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
				[Address(RVA = "0xABE900", Offset = "0xABE900", VA = "0xABE900")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000735")]
				[Address(RVA = "0xABE908", Offset = "0xABE908", VA = "0xABE908")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000FA")]
			protected float timer
			{
				[Token(Token = "0x6000736")]
				[Address(RVA = "0xABE910", Offset = "0xABE910", VA = "0xABE910")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000737")]
				[Address(RVA = "0xABE918", Offset = "0xABE918", VA = "0xABE918")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000FB")]
			protected Vector3 force
			{
				[Token(Token = "0x6000738")]
				[Address(RVA = "0xABE920", Offset = "0xABE920", VA = "0xABE920")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000739")]
				[Address(RVA = "0xABE92C", Offset = "0xABE92C", VA = "0xABE92C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000FC")]
			protected Vector3 point
			{
				[Token(Token = "0x600073A")]
				[Address(RVA = "0xABE938", Offset = "0xABE938", VA = "0xABE938")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600073B")]
				[Address(RVA = "0xABE944", Offset = "0xABE944", VA = "0xABE944")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600073C")]
			[Address(RVA = "0xABE7B0", Offset = "0xABE7B0", VA = "0xABE7B0")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0xABE4AC", Offset = "0xABE4AC", VA = "0xABE4AC")]
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
			[Address(RVA = "0xABE950", Offset = "0xABE950", VA = "0xABE950")]
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
				[Address(RVA = "0xABED34", Offset = "0xABED34", VA = "0xABED34")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000747")]
				[Address(RVA = "0xABEB58", Offset = "0xABEB58", VA = "0xABEB58")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000748")]
				[Address(RVA = "0xABEDC8", Offset = "0xABEDC8", VA = "0xABEDC8")]
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
			[Address(RVA = "0xABE964", Offset = "0xABE964", VA = "0xABE964", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0xABEAF8", Offset = "0xABEAF8", VA = "0xABEAF8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000744")]
			[Address(RVA = "0xABEB6C", Offset = "0xABEB6C", VA = "0xABEB6C", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000745")]
			[Address(RVA = "0xABEDAC", Offset = "0xABEDAC", VA = "0xABEDAC")]
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
				[Address(RVA = "0xABF188", Offset = "0xABF188", VA = "0xABF188")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600074E")]
				[Address(RVA = "0xABEF00", Offset = "0xABEF00", VA = "0xABEF00")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600074F")]
				[Address(RVA = "0xABF2A4", Offset = "0xABF2A4", VA = "0xABF2A4")]
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
			[Address(RVA = "0xABEDD0", Offset = "0xABEDD0", VA = "0xABEDD0", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600074A")]
			[Address(RVA = "0xABEEA8", Offset = "0xABEEA8", VA = "0xABEEA8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600074B")]
			[Address(RVA = "0xABEF0C", Offset = "0xABEF0C", VA = "0xABEF0C", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600074C")]
			[Address(RVA = "0xABF290", Offset = "0xABF290", VA = "0xABF290")]
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
		[Address(RVA = "0xABE3F4", Offset = "0xABE3F4", VA = "0xABE3F4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xABE58C", Offset = "0xABE58C", VA = "0xABE58C")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xABE8E0", Offset = "0xABE8E0", VA = "0xABE8E0")]
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
				[Address(RVA = "0xABF86C", Offset = "0xABF86C", VA = "0xABF86C")]
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
			[Address(RVA = "0xABF374", Offset = "0xABF374", VA = "0xABF374")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000754")]
			[Address(RVA = "0xABF4F4", Offset = "0xABF4F4", VA = "0xABF4F4")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000755")]
			[Address(RVA = "0xABF850", Offset = "0xABF850", VA = "0xABF850")]
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
		[Address(RVA = "0xABF308", Offset = "0xABF308", VA = "0xABF308")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xABF450", Offset = "0xABF450", VA = "0xABF450", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xABF840", Offset = "0xABF840", VA = "0xABF840")]
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
			[Address(RVA = "0xABF8DC", Offset = "0xABF8DC", VA = "0xABF8DC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xABF874", Offset = "0xABF874", VA = "0xABF874")]
		private void Start()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xABF960", Offset = "0xABF960", VA = "0xABF960")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xABFE60", Offset = "0xABFE60", VA = "0xABFE60")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xABFFE4", Offset = "0xABFFE4", VA = "0xABFFE4")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xAC0230", Offset = "0xAC0230", VA = "0xAC0230")]
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
			[Address(RVA = "0xAC042C", Offset = "0xAC042C", VA = "0xAC042C")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0xAC069C", Offset = "0xAC069C", VA = "0xAC069C")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000767")]
			[Address(RVA = "0xAC070C", Offset = "0xAC070C", VA = "0xAC070C")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0xAC0754", Offset = "0xAC0754", VA = "0xAC0754")]
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
				[Address(RVA = "0xAC08B0", Offset = "0xAC08B0", VA = "0xAC08B0", Slot = "4")]
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
				[Address(RVA = "0xAC08F8", Offset = "0xAC08F8", VA = "0xAC08F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000769")]
			[Address(RVA = "0xAC0330", Offset = "0xAC0330", VA = "0xAC0330")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0xAC075C", Offset = "0xAC075C", VA = "0xAC075C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600076B")]
			[Address(RVA = "0xAC0760", Offset = "0xAC0760", VA = "0xAC0760", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600076D")]
			[Address(RVA = "0xAC08B8", Offset = "0xAC08B8", VA = "0xAC08B8", Slot = "8")]
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
			[Address(RVA = "0xABBE28", Offset = "0xABBE28", VA = "0xABBE28")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600075E")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xABC1F0", Offset = "0xABC1F0", VA = "0xABC1F0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xAC02C8", Offset = "0xAC02C8", VA = "0xAC02C8")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xAC0358", Offset = "0xAC0358", VA = "0xAC0358")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xABF798", Offset = "0xABF798", VA = "0xABF798")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xAC0590", Offset = "0xAC0590", VA = "0xAC0590", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xABC168", Offset = "0xABC168", VA = "0xABC168")]
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
				[Address(RVA = "0xAC0D04", Offset = "0xAC0D04", VA = "0xAC0D04", Slot = "4")]
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
				[Address(RVA = "0xAC0D4C", Offset = "0xAC0D4C", VA = "0xAC0D4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000776")]
			[Address(RVA = "0xAC09A8", Offset = "0xAC09A8", VA = "0xAC09A8")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0xAC0BB0", Offset = "0xAC0BB0", VA = "0xAC0BB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000778")]
			[Address(RVA = "0xAC0BB4", Offset = "0xAC0BB4", VA = "0xAC0BB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600077A")]
			[Address(RVA = "0xAC0D0C", Offset = "0xAC0D0C", VA = "0xAC0D0C", Slot = "8")]
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
			[Address(RVA = "0xAC0900", Offset = "0xAC0900", VA = "0xAC0900")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000770")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xAC0920", Offset = "0xAC0920", VA = "0xAC0920", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xAC0940", Offset = "0xAC0940", VA = "0xAC0940")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xAC09D0", Offset = "0xAC09D0", VA = "0xAC09D0")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xAC0AA4", Offset = "0xAC0AA4", VA = "0xAC0AA4", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xABE8F0", Offset = "0xABE8F0", VA = "0xABE8F0")]
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
			[Address(RVA = "0xAC0D54", Offset = "0xAC0D54", VA = "0xAC0D54")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000780")]
			[Address(RVA = "0xAC10A0", Offset = "0xAC10A0", VA = "0xAC10A0")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xABC3FC", Offset = "0xABC3FC", VA = "0xABC3FC")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xAC0FA4", Offset = "0xAC0FA4", VA = "0xAC0FA4")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xAC1048", Offset = "0xAC1048", VA = "0xAC1048")]
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
				[Address(RVA = "0xAC16F4", Offset = "0xAC16F4", VA = "0xAC16F4")]
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
			[Address(RVA = "0xAC1118", Offset = "0xAC1118", VA = "0xAC1118")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000784")]
			[Address(RVA = "0xAC12B8", Offset = "0xAC12B8", VA = "0xAC12B8")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000785")]
			[Address(RVA = "0xAC13C0", Offset = "0xAC13C0", VA = "0xAC13C0")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000786")]
			[Address(RVA = "0xAC16E0", Offset = "0xAC16E0", VA = "0xAC16E0")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders;

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xAC10A8", Offset = "0xAC10A8", VA = "0xAC10A8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xAC12A8", Offset = "0xAC12A8", VA = "0xAC12A8")]
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
				[Address(RVA = "0xAC2A48", Offset = "0xAC2A48", VA = "0xAC2A48")]
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
			[Address(RVA = "0xAC1898", Offset = "0xAC1898", VA = "0xAC1898")]
			public void Start()
			{
			}

			[Token(Token = "0x6000795")]
			[Address(RVA = "0xAC23F4", Offset = "0xAC23F4", VA = "0xAC23F4")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0xAC2A34", Offset = "0xAC2A34", VA = "0xAC2A34")]
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
			[Address(RVA = "0xAC16FC", Offset = "0xAC16FC", VA = "0xAC16FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000105")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x600078E")]
			[Address(RVA = "0xAC25F8", Offset = "0xAC25F8", VA = "0xAC25F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000106")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x600078F")]
			[Address(RVA = "0xAC2634", Offset = "0xAC2634", VA = "0xAC2634")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000107")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000790")]
			[Address(RVA = "0xAC25C0", Offset = "0xAC25C0", VA = "0xAC25C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000108")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000791")]
			[Address(RVA = "0xAC25DC", Offset = "0xAC25DC", VA = "0xAC25DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xAC1720", Offset = "0xAC1720", VA = "0xAC1720")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xAC174C", Offset = "0xAC174C", VA = "0xAC174C")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xAC196C", Offset = "0xAC196C", VA = "0xAC196C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xAC2670", Offset = "0xAC2670", VA = "0xAC2670")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0xAC2788", Offset = "0xAC2788", VA = "0xAC2788")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xAC27D8", Offset = "0xAC27D8", VA = "0xAC27D8", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xAC29A8", Offset = "0xAC29A8", VA = "0xAC29A8")]
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
		[Address(RVA = "0xAC2A50", Offset = "0xAC2A50", VA = "0xAC2A50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xAC2B40", Offset = "0xAC2B40", VA = "0xAC2B40")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xAC2C1C", Offset = "0xAC2C1C", VA = "0xAC2C1C")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xAC3020", Offset = "0xAC3020", VA = "0xAC3020")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xAC3054", Offset = "0xAC3054", VA = "0xAC3054")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xAC3160", Offset = "0xAC3160", VA = "0xAC3160")]
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
			[Address(RVA = "0xAC6BAC", Offset = "0xAC6BAC", VA = "0xAC6BAC")]
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
				[Address(RVA = "0xAC6D48", Offset = "0xAC6D48", VA = "0xAC6D48")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x60007B0")]
				[Address(RVA = "0xAC6DFC", Offset = "0xAC6DFC", VA = "0xAC6DFC")]
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
			[Address(RVA = "0xAC6D40", Offset = "0xAC6D40", VA = "0xAC6D40")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xAC3174", Offset = "0xAC3174", VA = "0xAC3174")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xAC318C", Offset = "0xAC318C", VA = "0xAC318C")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xAC32B4", Offset = "0xAC32B4", VA = "0xAC32B4")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xAC31D4", Offset = "0xAC31D4", VA = "0xAC31D4")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xAC32CC", Offset = "0xAC32CC", VA = "0xAC32CC")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xAC452C", Offset = "0xAC452C", VA = "0xAC452C")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xAC4BE4", Offset = "0xAC4BE4", VA = "0xAC4BE4")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xAC54F4", Offset = "0xAC54F4", VA = "0xAC54F4")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xAC5764", Offset = "0xAC5764", VA = "0xAC5764")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xAC5980", Offset = "0xAC5980", VA = "0xAC5980")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xAC6140", Offset = "0xAC6140", VA = "0xAC6140")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xAC5F08", Offset = "0xAC5F08", VA = "0xAC5F08")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xAC63E8", Offset = "0xAC63E8", VA = "0xAC63E8")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xAC6780", Offset = "0xAC6780", VA = "0xAC6780")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xAC6864", Offset = "0xAC6864", VA = "0xAC6864")]
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
		[Address(RVA = "0xAC6E58", Offset = "0xAC6E58", VA = "0xAC6E58")]
		private void Start()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xAC6EA8", Offset = "0xAC6EA8", VA = "0xAC6EA8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xAC6ED0", Offset = "0xAC6ED0", VA = "0xAC6ED0")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xAC6FF0", Offset = "0xAC6FF0", VA = "0xAC6FF0")]
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
			[Address(RVA = "0xAC7008", Offset = "0xAC7008", VA = "0xAC7008")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007B6")]
			[Address(RVA = "0xAC7014", Offset = "0xAC7014", VA = "0xAC7014")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xAC7020", Offset = "0xAC7020", VA = "0xAC7020")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xAC7114", Offset = "0xAC7114", VA = "0xAC7114")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xAC72D4", Offset = "0xAC72D4", VA = "0xAC72D4")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xAC742C", Offset = "0xAC742C", VA = "0xAC742C")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xAC77F4", Offset = "0xAC77F4", VA = "0xAC77F4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xAC7900", Offset = "0xAC7900", VA = "0xAC7900")]
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
			[Address(RVA = "0xAC79BC", Offset = "0xAC79BC", VA = "0xAC79BC")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0xAC7C24", Offset = "0xAC7C24", VA = "0xAC7C24")]
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
		[Address(RVA = "0xAC7908", Offset = "0xAC7908", VA = "0xAC7908")]
		private void Start()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xAC7958", Offset = "0xAC7958", VA = "0xAC7958")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xAC7B64", Offset = "0xAC7B64", VA = "0xAC7B64")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xAC7C1C", Offset = "0xAC7C1C", VA = "0xAC7C1C")]
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
		[Address(RVA = "0xAC7C2C", Offset = "0xAC7C2C", VA = "0xAC7C2C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xAC7CAC", Offset = "0xAC7CAC", VA = "0xAC7CAC")]
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
		[Address(RVA = "0xAC7CB4", Offset = "0xAC7CB4", VA = "0xAC7CB4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xAC7D20", Offset = "0xAC7D20", VA = "0xAC7D20")]
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
		[Address(RVA = "0xAC7D80", Offset = "0xAC7D80", VA = "0xAC7D80")]
		private void Start()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xAC7DB8", Offset = "0xAC7DB8", VA = "0xAC7DB8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xAC8074", Offset = "0xAC8074", VA = "0xAC8074")]
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
		[Address(RVA = "0xAC807C", Offset = "0xAC807C", VA = "0xAC807C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xAC80B4", Offset = "0xAC80B4", VA = "0xAC80B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xAC8200", Offset = "0xAC8200", VA = "0xAC8200")]
		private void Pose()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xAC8370", Offset = "0xAC8370", VA = "0xAC8370")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xAC8554", Offset = "0xAC8554", VA = "0xAC8554")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xAC85E4", Offset = "0xAC85E4", VA = "0xAC85E4")]
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
		[Address(RVA = "0xAC85F8", Offset = "0xAC85F8", VA = "0xAC85F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xAC8764", Offset = "0xAC8764", VA = "0xAC8764")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xAC8960", Offset = "0xAC8960", VA = "0xAC8960")]
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
		[Address(RVA = "0xAC8990", Offset = "0xAC8990", VA = "0xAC8990")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xAC8DBC", Offset = "0xAC8DBC", VA = "0xAC8DBC")]
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
			[Address(RVA = "0xAC8DDC", Offset = "0xAC8DDC", VA = "0xAC8DDC")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0xAC8DE8", Offset = "0xAC8DE8", VA = "0xAC8DE8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xAC8DF4", Offset = "0xAC8DF4", VA = "0xAC8DF4")]
		private void Start()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xAC8E24", Offset = "0xAC8E24", VA = "0xAC8E24")]
		private void Update()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xAC97A8", Offset = "0xAC97A8", VA = "0xAC97A8")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xAC9524", Offset = "0xAC9524", VA = "0xAC9524")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xAC98B8", Offset = "0xAC98B8", VA = "0xAC98B8")]
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
			[Address(RVA = "0xAC98E4", Offset = "0xAC98E4", VA = "0xAC98E4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xAC9964", Offset = "0xAC9964", VA = "0xAC9964")]
		private void Update()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xAC9CA8", Offset = "0xAC9CA8", VA = "0xAC9CA8")]
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
				[Address(RVA = "0xACACB0", Offset = "0xACACB0", VA = "0xACACB0", Slot = "4")]
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
				[Address(RVA = "0xACACF8", Offset = "0xACACF8", VA = "0xACACF8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007EA")]
			[Address(RVA = "0xACA954", Offset = "0xACA954", VA = "0xACA954")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0xACAA0C", Offset = "0xACAA0C", VA = "0xACAA0C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0xACAA10", Offset = "0xACAA10", VA = "0xACAA10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0xACACB8", Offset = "0xACACB8", VA = "0xACACB8", Slot = "8")]
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
			[Address(RVA = "0xAC9CBC", Offset = "0xAC9CBC", VA = "0xAC9CBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010D")]
		public Vector3 position
		{
			[Token(Token = "0x60007E0")]
			[Address(RVA = "0xAC9888", Offset = "0xAC9888", VA = "0xAC9888")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007E1")]
			[Address(RVA = "0xAC9CD0", Offset = "0xAC9CD0", VA = "0xAC9CD0")]
			set
			{
			}
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xAC9D1C", Offset = "0xAC9D1C", VA = "0xAC9D1C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xAC9F64", Offset = "0xAC9F64", VA = "0xAC9F64")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xACA13C", Offset = "0xACA13C", VA = "0xACA13C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xACA354", Offset = "0xACA354", VA = "0xACA354")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xACA5B4", Offset = "0xACA5B4", VA = "0xACA5B4")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xACA71C", Offset = "0xACA71C", VA = "0xACA71C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xACA2B0", Offset = "0xACA2B0", VA = "0xACA2B0")]
		[IteratorStateMachine(typeof(<Step>d__33))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xACA97C", Offset = "0xACA97C", VA = "0xACA97C")]
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
		[Address(RVA = "0xACAD00", Offset = "0xACAD00", VA = "0xACAD00")]
		private void Start()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xACADCC", Offset = "0xACADCC", VA = "0xACADCC")]
		private void Update()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xACB040", Offset = "0xACB040", VA = "0xACB040")]
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
		[Address(RVA = "0xACB048", Offset = "0xACB048", VA = "0xACB048", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xACB068", Offset = "0xACB068", VA = "0xACB068")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xACB280", Offset = "0xACB280", VA = "0xACB280", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xACB538", Offset = "0xACB538", VA = "0xACB538")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xACB5CC", Offset = "0xACB5CC", VA = "0xACB5CC")]
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
		[Address(RVA = "0xACB5D4", Offset = "0xACB5D4", VA = "0xACB5D4", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xACB624", Offset = "0xACB624", VA = "0xACB624")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xACB82C", Offset = "0xACB82C", VA = "0xACB82C", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xACBA54", Offset = "0xACBA54", VA = "0xACBA54")]
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
		[Address(RVA = "0xACBA68", Offset = "0xACBA68", VA = "0xACBA68", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xACBBFC", Offset = "0xACBBFC", VA = "0xACBBFC", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xACBC6C", Offset = "0xACBC6C", VA = "0xACBC6C")]
		private void Read()
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xACBDA4", Offset = "0xACBDA4", VA = "0xACBDA4")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xACBE00", Offset = "0xACBE00", VA = "0xACBE00")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xACC448", Offset = "0xACC448", VA = "0xACC448")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xACC25C", Offset = "0xACC25C", VA = "0xACC25C")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xACC6EC", Offset = "0xACC6EC", VA = "0xACC6EC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xACC7F8", Offset = "0xACC7F8", VA = "0xACC7F8")]
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
		[Address(RVA = "0xACC814", Offset = "0xACC814", VA = "0xACC814", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xACC870", Offset = "0xACC870", VA = "0xACC870", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xACCBC4", Offset = "0xACCBC4", VA = "0xACCBC4")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xACCCB4", Offset = "0xACCCB4", VA = "0xACCCB4")]
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
			[Address(RVA = "0xACCF14", Offset = "0xACCF14", VA = "0xACCF14")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000111")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x600080C")]
			[Address(RVA = "0xACCF94", Offset = "0xACCF94", VA = "0xACCF94")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xACCCBC", Offset = "0xACCCBC", VA = "0xACCCBC")]
		private void Start()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xACCD24", Offset = "0xACCD24", VA = "0xACCD24")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xACD014", Offset = "0xACD014", VA = "0xACD014")]
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
		[Address(RVA = "0xACD01C", Offset = "0xACD01C", VA = "0xACD01C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xACD478", Offset = "0xACD478", VA = "0xACD478")]
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
		[Address(RVA = "0xACD480", Offset = "0xACD480", VA = "0xACD480")]
		private void Start()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xACD524", Offset = "0xACD524", VA = "0xACD524")]
		private void Update()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xACD980", Offset = "0xACD980", VA = "0xACD980")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xACDA20", Offset = "0xACDA20", VA = "0xACDA20")]
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
			[Address(RVA = "0xACDBB4", Offset = "0xACDBB4", VA = "0xACDBB4")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000819")]
			[Address(RVA = "0xACDCD8", Offset = "0xACDCD8", VA = "0xACDCD8")]
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
		[Address(RVA = "0xACDA90", Offset = "0xACDA90", VA = "0xACDA90")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xACDC2C", Offset = "0xACDC2C", VA = "0xACDC2C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xACDCC4", Offset = "0xACDCC4", VA = "0xACDCC4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xACDCC8", Offset = "0xACDCC8", VA = "0xACDCC8")]
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
		[Address(RVA = "0xACDCE8", Offset = "0xACDCE8", VA = "0xACDCE8")]
		private void Start()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xACDD50", Offset = "0xACDD50", VA = "0xACDD50")]
		private void Update()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xACDE18", Offset = "0xACDE18", VA = "0xACDE18")]
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
		[Address(RVA = "0xACDE20", Offset = "0xACDE20", VA = "0xACDE20")]
		private void Start()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xACDE70", Offset = "0xACDE70", VA = "0xACDE70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xACE008", Offset = "0xACE008", VA = "0xACE008")]
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
		[Address(RVA = "0xACE010", Offset = "0xACE010", VA = "0xACE010")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xACE0E0", Offset = "0xACE0E0", VA = "0xACE0E0")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xACE16C", Offset = "0xACE16C", VA = "0xACE16C")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xACE640", Offset = "0xACE640", VA = "0xACE640")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xACE74C", Offset = "0xACE74C", VA = "0xACE74C")]
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
		[Address(RVA = "0xACE754", Offset = "0xACE754", VA = "0xACE754")]
		private void Start()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xACE8F0", Offset = "0xACE8F0", VA = "0xACE8F0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xACE8FC", Offset = "0xACE8FC", VA = "0xACE8FC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xACEBBC", Offset = "0xACEBBC", VA = "0xACEBBC")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xACEE60", Offset = "0xACEE60", VA = "0xACEE60")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xACE9C0", Offset = "0xACE9C0", VA = "0xACE9C0")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xACFB18", Offset = "0xACFB18", VA = "0xACFB18")]
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
		[Address(RVA = "0xACFB38", Offset = "0xACFB38", VA = "0xACFB38")]
		private void Start()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xACFBB4", Offset = "0xACFBB4", VA = "0xACFBB4")]
		private void Update()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xACFCB0", Offset = "0xACFCB0", VA = "0xACFCB0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xACFD5C", Offset = "0xACFD5C", VA = "0xACFD5C")]
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
		[Address(RVA = "0xACFD6C", Offset = "0xACFD6C", VA = "0xACFD6C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xACFEB0", Offset = "0xACFEB0", VA = "0xACFEB0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xAD0014", Offset = "0xAD0014", VA = "0xAD0014")]
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
		[Address(RVA = "0xAD0024", Offset = "0xAD0024", VA = "0xAD0024")]
		private void Start()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xAD01F0", Offset = "0xAD01F0", VA = "0xAD01F0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xAD0600", Offset = "0xAD0600", VA = "0xAD0600")]
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
		[Address(RVA = "0xAD0610", Offset = "0xAD0610", VA = "0xAD0610")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xAD06F8", Offset = "0xAD06F8", VA = "0xAD06F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xAD07E4", Offset = "0xAD07E4", VA = "0xAD07E4")]
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
		[Address(RVA = "0xAD07EC", Offset = "0xAD07EC", VA = "0xAD07EC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xAD0CEC", Offset = "0xAD0CEC", VA = "0xAD0CEC")]
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
		[Address(RVA = "0xAD0CF4", Offset = "0xAD0CF4", VA = "0xAD0CF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xAD0D44", Offset = "0xAD0D44", VA = "0xAD0D44")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xAD0FF0", Offset = "0xAD0FF0", VA = "0xAD0FF0")]
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
				[Address(RVA = "0xAD17FC", Offset = "0xAD17FC", VA = "0xAD17FC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000841")]
			[Address(RVA = "0xAD1020", Offset = "0xAD1020", VA = "0xAD1020")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000842")]
			[Address(RVA = "0xAD109C", Offset = "0xAD109C", VA = "0xAD109C")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000844")]
			[Address(RVA = "0xAD1694", Offset = "0xAD1694", VA = "0xAD1694")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x6000845")]
			[Address(RVA = "0xAD1848", Offset = "0xAD1848", VA = "0xAD1848")]
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
		[Address(RVA = "0xAD0FF8", Offset = "0xAD0FF8", VA = "0xAD0FF8")]
		private void Start()
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0xAD1040", Offset = "0xAD1040", VA = "0xAD1040")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xAD1684", Offset = "0xAD1684", VA = "0xAD1684")]
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
			[Address(RVA = "0xAD19C0", Offset = "0xAD19C0", VA = "0xAD19C0")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x600084D")]
			[Address(RVA = "0xAD1B94", Offset = "0xAD1B94", VA = "0xAD1B94")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x600084E")]
			[Address(RVA = "0xAD1BB8", Offset = "0xAD1BB8", VA = "0xAD1BB8")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x600084F")]
			[Address(RVA = "0xAD1CC8", Offset = "0xAD1CC8", VA = "0xAD1CC8")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000850")]
			[Address(RVA = "0xAD1E60", Offset = "0xAD1E60", VA = "0xAD1E60")]
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
		[Address(RVA = "0xAD185C", Offset = "0xAD185C", VA = "0xAD185C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xAD1940", Offset = "0xAD1940", VA = "0xAD1940")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xAD1A88", Offset = "0xAD1A88", VA = "0xAD1A88", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xAD1C4C", Offset = "0xAD1C4C", VA = "0xAD1C4C")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xAD1D38", Offset = "0xAD1D38", VA = "0xAD1D38", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xAD1E50", Offset = "0xAD1E50", VA = "0xAD1E50")]
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
		[Address(RVA = "0xAD1EC0", Offset = "0xAD1EC0", VA = "0xAD1EC0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xAD1F30", Offset = "0xAD1F30", VA = "0xAD1F30")]
		private void Update()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xAD2000", Offset = "0xAD2000", VA = "0xAD2000")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xAD2148", Offset = "0xAD2148", VA = "0xAD2148")]
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
			[Address(RVA = "0xAD23C8", Offset = "0xAD23C8", VA = "0xAD23C8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xAD215C", Offset = "0xAD215C", VA = "0xAD215C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xAD2248", Offset = "0xAD2248", VA = "0xAD2248", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xAD23C0", Offset = "0xAD23C0", VA = "0xAD23C0")]
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
		[Address(RVA = "0xAD23D8", Offset = "0xAD23D8", VA = "0xAD23D8")]
		private void Start()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xAD26D8", Offset = "0xAD26D8", VA = "0xAD26D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xAD2ED4", Offset = "0xAD2ED4", VA = "0xAD2ED4")]
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
			[Address(RVA = "0xAD32CC", Offset = "0xAD32CC", VA = "0xAD32CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000114")]
		private bool holdingLeft
		{
			[Token(Token = "0x6000864")]
			[Address(RVA = "0xAD339C", Offset = "0xAD339C", VA = "0xAD339C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000115")]
		private bool holdingRight
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0xAD32F4", Offset = "0xAD32F4", VA = "0xAD32F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xAD2F40", Offset = "0xAD2F40", VA = "0xAD2F40")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600085D")]
		protected abstract void RotatePivot();

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xAD3444", Offset = "0xAD3444", VA = "0xAD3444")]
		private void Start()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xAD3604", Offset = "0xAD3604", VA = "0xAD3604")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xAD3774", Offset = "0xAD3774", VA = "0xAD3774")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xAD3844", Offset = "0xAD3844", VA = "0xAD3844")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xAD3970", Offset = "0xAD3970", VA = "0xAD3970")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xAD3AF0", Offset = "0xAD3AF0", VA = "0xAD3AF0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xAD3CEC", Offset = "0xAD3CEC", VA = "0xAD3CEC")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x6000868")]
		[Address(RVA = "0xAD3D00", Offset = "0xAD3D00", VA = "0xAD3D00", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0xAD3EE0", Offset = "0xAD3EE0", VA = "0xAD3EE0")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x600086A")]
		[Address(RVA = "0xAD3EF4", Offset = "0xAD3EF4", VA = "0xAD3EF4", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xAD4008", Offset = "0xAD4008", VA = "0xAD4008")]
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
		[Address(RVA = "0xAD401C", Offset = "0xAD401C", VA = "0xAD401C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xAD40B4", Offset = "0xAD40B4", VA = "0xAD40B4")]
		private void Update()
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xAD41CC", Offset = "0xAD41CC", VA = "0xAD41CC")]
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
		[Address(RVA = "0xAD41D4", Offset = "0xAD41D4", VA = "0xAD41D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xAD4224", Offset = "0xAD4224", VA = "0xAD4224")]
		private void Update()
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xAD4270", Offset = "0xAD4270", VA = "0xAD4270")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xAD4308", Offset = "0xAD4308", VA = "0xAD4308")]
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
				[Address(RVA = "0xAD4648", Offset = "0xAD4648", VA = "0xAD4648", Slot = "4")]
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
				[Address(RVA = "0xAD4690", Offset = "0xAD4690", VA = "0xAD4690", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000877")]
			[Address(RVA = "0xAD447C", Offset = "0xAD447C", VA = "0xAD447C")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000878")]
			[Address(RVA = "0xAD44B4", Offset = "0xAD44B4", VA = "0xAD44B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000879")]
			[Address(RVA = "0xAD44B8", Offset = "0xAD44B8", VA = "0xAD44B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600087B")]
			[Address(RVA = "0xAD4650", Offset = "0xAD4650", VA = "0xAD4650", Slot = "8")]
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
		[Address(RVA = "0xAD4318", Offset = "0xAD4318", VA = "0xAD4318")]
		private void Start()
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xAD43C8", Offset = "0xAD43C8", VA = "0xAD43C8")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xAD4404", Offset = "0xAD4404", VA = "0xAD4404")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xAD44A4", Offset = "0xAD44A4", VA = "0xAD44A4")]
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
				[Address(RVA = "0xAD4904", Offset = "0xAD4904", VA = "0xAD4904", Slot = "4")]
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
				[Address(RVA = "0xAD494C", Offset = "0xAD494C", VA = "0xAD494C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000880")]
			[Address(RVA = "0xAD47A8", Offset = "0xAD47A8", VA = "0xAD47A8")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000881")]
			[Address(RVA = "0xAD47D8", Offset = "0xAD47D8", VA = "0xAD47D8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000882")]
			[Address(RVA = "0xAD47DC", Offset = "0xAD47DC", VA = "0xAD47DC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000884")]
			[Address(RVA = "0xAD490C", Offset = "0xAD490C", VA = "0xAD490C", Slot = "8")]
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
		[Address(RVA = "0xAD4698", Offset = "0xAD4698", VA = "0xAD4698")]
		private void Start()
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0xAD4740", Offset = "0xAD4740", VA = "0xAD4740")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0xAD47D0", Offset = "0xAD47D0", VA = "0xAD47D0")]
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
			[Address(RVA = "0xAD49B8", Offset = "0xAD49B8", VA = "0xAD49B8")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600088B")]
			[Address(RVA = "0xAD54F4", Offset = "0xAD54F4", VA = "0xAD54F4")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x600088C")]
			[Address(RVA = "0xAD4D7C", Offset = "0xAD4D7C", VA = "0xAD4D7C")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600088D")]
			[Address(RVA = "0xAD55DC", Offset = "0xAD55DC", VA = "0xAD55DC")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600088E")]
			[Address(RVA = "0xAD56C0", Offset = "0xAD56C0", VA = "0xAD56C0")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600088F")]
			[Address(RVA = "0xAD574C", Offset = "0xAD574C", VA = "0xAD574C")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000890")]
			[Address(RVA = "0xAD57D4", Offset = "0xAD57D4", VA = "0xAD57D4")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000891")]
			[Address(RVA = "0xAD5334", Offset = "0xAD5334", VA = "0xAD5334")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000892")]
			[Address(RVA = "0xAD585C", Offset = "0xAD585C", VA = "0xAD585C")]
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
		[Address(RVA = "0xAD4954", Offset = "0xAD4954", VA = "0xAD4954")]
		private void Start()
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xAD4D1C", Offset = "0xAD4D1C", VA = "0xAD4D1C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xAD5284", Offset = "0xAD5284", VA = "0xAD5284")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xAD54EC", Offset = "0xAD54EC", VA = "0xAD54EC")]
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
		[Address(RVA = "0xAD5898", Offset = "0xAD5898", VA = "0xAD5898")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xAD58C8", Offset = "0xAD58C8", VA = "0xAD58C8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xAD5978", Offset = "0xAD5978", VA = "0xAD5978")]
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
		[Address(RVA = "0xAD598C", Offset = "0xAD598C", VA = "0xAD598C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xAD5B70", Offset = "0xAD5B70", VA = "0xAD5B70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xAD5E0C", Offset = "0xAD5E0C", VA = "0xAD5E0C")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0xAD5ED4", Offset = "0xAD5ED4", VA = "0xAD5ED4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xAD5FE0", Offset = "0xAD5FE0", VA = "0xAD5FE0")]
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
		[Address(RVA = "0xAD5FE8", Offset = "0xAD5FE8", VA = "0xAD5FE8", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xAD6100", Offset = "0xAD6100", VA = "0xAD6100")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xAD62C8", Offset = "0xAD62C8", VA = "0xAD62C8")]
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
		[Address(RVA = "0xAD62E4", Offset = "0xAD62E4", VA = "0xAD62E4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0xAD64EC", Offset = "0xAD64EC", VA = "0xAD64EC")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0xAD6558", Offset = "0xAD6558", VA = "0xAD6558")]
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
				[Address(RVA = "0xAD6CA4", Offset = "0xAD6CA4", VA = "0xAD6CA4", Slot = "4")]
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
				[Address(RVA = "0xAD6CEC", Offset = "0xAD6CEC", VA = "0xAD6CEC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008A7")]
			[Address(RVA = "0xAD6938", Offset = "0xAD6938", VA = "0xAD6938")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60008A8")]
			[Address(RVA = "0xAD6B28", Offset = "0xAD6B28", VA = "0xAD6B28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008A9")]
			[Address(RVA = "0xAD6B2C", Offset = "0xAD6B2C", VA = "0xAD6B2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008AB")]
			[Address(RVA = "0xAD6CAC", Offset = "0xAD6CAC", VA = "0xAD6CAC", Slot = "8")]
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
		[Address(RVA = "0xAD6560", Offset = "0xAD6560", VA = "0xAD6560")]
		private void Start()
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xAD6684", Offset = "0xAD6684", VA = "0xAD6684")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0xAD661C", Offset = "0xAD661C", VA = "0xAD661C")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0xAD6960", Offset = "0xAD6960", VA = "0xAD6960")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0xAD6A38", Offset = "0xAD6A38", VA = "0xAD6A38")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xAD6B0C", Offset = "0xAD6B0C", VA = "0xAD6B0C")]
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
		[Address(RVA = "0xAD6CF4", Offset = "0xAD6CF4", VA = "0xAD6CF4")]
		private void Start()
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xAD6D5C", Offset = "0xAD6D5C", VA = "0xAD6D5C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xAD6E08", Offset = "0xAD6E08", VA = "0xAD6E08")]
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
			[Address(RVA = "0xAD6E7C", Offset = "0xAD6E7C", VA = "0xAD6E7C")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x60008B3")]
			[Address(RVA = "0xAD6F9C", Offset = "0xAD6F9C", VA = "0xAD6F9C")]
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
		[Address(RVA = "0xAD6E18", Offset = "0xAD6E18", VA = "0xAD6E18")]
		private void Update()
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xAD6F94", Offset = "0xAD6F94", VA = "0xAD6F94")]
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
		[Address(RVA = "0xAD6FA4", Offset = "0xAD6FA4", VA = "0xAD6FA4")]
		private void Update()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xAD70E8", Offset = "0xAD70E8", VA = "0xAD70E8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xAD724C", Offset = "0xAD724C", VA = "0xAD724C")]
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
		[Address(RVA = "0xAD725C", Offset = "0xAD725C", VA = "0xAD725C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xAD73E4", Offset = "0xAD73E4", VA = "0xAD73E4")]
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
		[Address(RVA = "0xAD7454", Offset = "0xAD7454", VA = "0xAD7454")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xAD75AC", Offset = "0xAD75AC", VA = "0xAD75AC")]
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
		[Address(RVA = "0xAD7614", Offset = "0xAD7614", VA = "0xAD7614")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xAD7664", Offset = "0xAD7664", VA = "0xAD7664")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0xAD783C", Offset = "0xAD783C", VA = "0xAD783C")]
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
		[Address(RVA = "0xAD7894", Offset = "0xAD7894", VA = "0xAD7894")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0xAD7DB4", Offset = "0xAD7DB4", VA = "0xAD7DB4")]
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
			[Address(RVA = "0xAD7E30", Offset = "0xAD7E30", VA = "0xAD7E30", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0xAD7E10", Offset = "0xAD7E10", VA = "0xAD7E10", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xAD7E38", Offset = "0xAD7E38", VA = "0xAD7E38")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0xAD7E98", Offset = "0xAD7E98", VA = "0xAD7E98", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0xACCBB4", Offset = "0xACCBB4", VA = "0xACCBB4", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0xAD8288", Offset = "0xAD8288", VA = "0xAD8288", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0xAD801C", Offset = "0xAD801C", VA = "0xAD801C")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0xAD8298", Offset = "0xAD8298", VA = "0xAD8298")]
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
		[Address(RVA = "0xAD82B0", Offset = "0xAD82B0", VA = "0xAD82B0", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0xAD830C", Offset = "0xAD830C", VA = "0xAD830C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0xAD839C", Offset = "0xAD839C", VA = "0xAD839C")]
		private void Update()
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0xAD84C0", Offset = "0xAD84C0", VA = "0xAD84C0")]
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
			[Address(RVA = "0xAD8564", Offset = "0xAD8564", VA = "0xAD8564", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0xAD84C8", Offset = "0xAD84C8", VA = "0xAD84C8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0xAD8548", Offset = "0xAD8548", VA = "0xAD8548", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0xAD8658", Offset = "0xAD8658", VA = "0xAD8658", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0xAD8A4C", Offset = "0xAD8A4C", VA = "0xAD8A4C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xAD8B74", Offset = "0xAD8B74", VA = "0xAD8B74")]
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
		[Address(RVA = "0xAD8B88", Offset = "0xAD8B88", VA = "0xAD8B88")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0xAD8D74", Offset = "0xAD8D74", VA = "0xAD8D74", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0xAD8F24", Offset = "0xAD8F24", VA = "0xAD8F24", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0xAD90C4", Offset = "0xAD90C4", VA = "0xAD90C4")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0xAD9124", Offset = "0xAD9124", VA = "0xAD9124")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0xAD9288", Offset = "0xAD9288", VA = "0xAD9288")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0xAD948C", Offset = "0xAD948C", VA = "0xAD948C")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0xAD94B0", Offset = "0xAD94B0", VA = "0xAD94B0")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0xAD94D4", Offset = "0xAD94D4", VA = "0xAD94D4")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xAD9620", Offset = "0xAD9620", VA = "0xAD9620")]
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
				[Address(RVA = "0xADC080", Offset = "0xADC080", VA = "0xADC080", Slot = "4")]
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
				[Address(RVA = "0xADC0C8", Offset = "0xADC0C8", VA = "0xADC0C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008EF")]
			[Address(RVA = "0xADBE4C", Offset = "0xADBE4C", VA = "0xADBE4C")]
			[DebuggerHidden]
			public <JumpSmooth>d__75(int <>1__state)
			{
			}

			[Token(Token = "0x60008F0")]
			[Address(RVA = "0xADBF88", Offset = "0xADBF88", VA = "0xADBF88", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008F1")]
			[Address(RVA = "0xADBF8C", Offset = "0xADBF8C", VA = "0xADBF8C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008F3")]
			[Address(RVA = "0xADC088", Offset = "0xADC088", VA = "0xADC088", Slot = "8")]
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
			[Address(RVA = "0xAD9640", Offset = "0xAD9640", VA = "0xAD9640")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008DE")]
			[Address(RVA = "0xAD9648", Offset = "0xAD9648", VA = "0xAD9648")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0xAD9654", Offset = "0xAD9654", VA = "0xAD9654", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0xAD9824", Offset = "0xAD9824", VA = "0xAD9824")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0xAD98A8", Offset = "0xAD98A8", VA = "0xAD98A8", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xAD99BC", Offset = "0xAD99BC", VA = "0xAD99BC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xADA9E4", Offset = "0xADA9E4", VA = "0xADA9E4", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0xADAE74", Offset = "0xADAE74", VA = "0xADAE74", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xADA070", Offset = "0xADA070", VA = "0xADA070")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0xADAF4C", Offset = "0xADAF4C", VA = "0xADAF4C")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0xADB5D4", Offset = "0xADB5D4", VA = "0xADB5D4")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xADAA70", Offset = "0xADAA70", VA = "0xADAA70")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0xADB6C4", Offset = "0xADB6C4", VA = "0xADB6C4", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0xADBB44", Offset = "0xADBB44", VA = "0xADBB44")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0xADBC6C", Offset = "0xADBC6C", VA = "0xADBC6C", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0xADBDC0", Offset = "0xADBDC0", VA = "0xADBDC0")]
		[IteratorStateMachine(typeof(<JumpSmooth>d__75))]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0xADA484", Offset = "0xADA484", VA = "0xADA484")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0xADBE74", Offset = "0xADBE74", VA = "0xADBE74")]
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
			[Address(RVA = "0xADC0D0", Offset = "0xADC0D0", VA = "0xADC0D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0xADC0D8", Offset = "0xADC0D8", VA = "0xADC0D8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0xADC0E4", Offset = "0xADC0E4", VA = "0xADC0E4")]
		private void Start()
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0xADC178", Offset = "0xADC178", VA = "0xADC178")]
		private void Update()
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0xADC790", Offset = "0xADC790", VA = "0xADC790")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0xADC1C0", Offset = "0xADC1C0", VA = "0xADC1C0")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0xADC528", Offset = "0xADC528", VA = "0xADC528")]
		private void Move()
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0xADC7C0", Offset = "0xADC7C0", VA = "0xADC7C0")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0xADC858", Offset = "0xADC858", VA = "0xADC858")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xADC8D8", Offset = "0xADC8D8", VA = "0xADC8D8")]
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
		[Address(RVA = "0xADC900", Offset = "0xADC900", VA = "0xADC900", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0xADCA1C", Offset = "0xADCA1C", VA = "0xADCA1C", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0xADD080", Offset = "0xADD080", VA = "0xADD080")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0xADD26C", Offset = "0xADD26C", VA = "0xADD26C")]
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
		[Address(RVA = "0xADC93C", Offset = "0xADC93C", VA = "0xADC93C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0xADD298", Offset = "0xADD298", VA = "0xADD298", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0xADD288", Offset = "0xADD288", VA = "0xADD288")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x200013E")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x6000906")]
		[Address(RVA = "0xADD5DC", Offset = "0xADD5DC", VA = "0xADD5DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0xADD614", Offset = "0xADD614", VA = "0xADD614")]
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
		[Address(RVA = "0xADD61C", Offset = "0xADD61C", VA = "0xADD61C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0xADD644", Offset = "0xADD644", VA = "0xADD644")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0xADD6E8", Offset = "0xADD6E8", VA = "0xADD6E8")]
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
			[Address(RVA = "0xADD6FC", Offset = "0xADD6FC", VA = "0xADD6FC")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600090C")]
			[Address(RVA = "0xADD708", Offset = "0xADD708", VA = "0xADD708")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000123")]
		public State state
		{
			[Token(Token = "0x600090D")]
			[Address(RVA = "0xADD714", Offset = "0xADD714", VA = "0xADD714")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Token(Token = "0x600090E")]
			[Address(RVA = "0xADD71C", Offset = "0xADD71C", VA = "0xADD71C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0xADC968", Offset = "0xADC968", VA = "0xADC968")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0xADCC3C", Offset = "0xADCC3C", VA = "0xADCC3C")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0xADD7FC", Offset = "0xADD7FC", VA = "0xADD7FC")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0xADD860", Offset = "0xADD860", VA = "0xADD860")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xADD724", Offset = "0xADD724", VA = "0xADD724")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0xADD780", Offset = "0xADD780", VA = "0xADD780")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0xADD0A8", Offset = "0xADD0A8", VA = "0xADD0A8")]
		public void Visualize()
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0xADD994", Offset = "0xADD994", VA = "0xADD994")]
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
			[Address(RVA = "0xADE11C", Offset = "0xADE11C", VA = "0xADE11C")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000001")]
		public event ActivityJoinHandler OnActivityJoin
		{
			[Token(Token = "0x6000919")]
			[Address(RVA = "0xADE23C", Offset = "0xADE23C", VA = "0xADE23C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600091A")]
			[Address(RVA = "0xADE2D8", Offset = "0xADE2D8", VA = "0xADE2D8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event ActivitySpectateHandler OnActivitySpectate
		{
			[Token(Token = "0x600091B")]
			[Address(RVA = "0xADE374", Offset = "0xADE374", VA = "0xADE374")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600091C")]
			[Address(RVA = "0xADE410", Offset = "0xADE410", VA = "0xADE410")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event ActivityJoinRequestHandler OnActivityJoinRequest
		{
			[Token(Token = "0x600091D")]
			[Address(RVA = "0xADE4AC", Offset = "0xADE4AC", VA = "0xADE4AC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600091E")]
			[Address(RVA = "0xADE548", Offset = "0xADE548", VA = "0xADE548")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event ActivityInviteHandler OnActivityInvite
		{
			[Token(Token = "0x600091F")]
			[Address(RVA = "0xADE5E4", Offset = "0xADE5E4", VA = "0xADE5E4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000920")]
			[Address(RVA = "0xADE680", Offset = "0xADE680", VA = "0xADE680")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0xADE07C", Offset = "0xADE07C", VA = "0xADE07C")]
		public void RegisterCommand()
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0xADE71C", Offset = "0xADE71C", VA = "0xADE71C")]
		internal ActivityManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0xADE894", Offset = "0xADE894", VA = "0xADE894")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0xADE084", Offset = "0xADE084", VA = "0xADE084")]
		public void RegisterCommand(string command)
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0xADED64", Offset = "0xADED64", VA = "0xADED64")]
		public void RegisterSteam(uint steamId)
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0xADD9F8", Offset = "0xADD9F8", VA = "0xADD9F8")]
		[MonoPInvokeCallback]
		private static void UpdateActivityCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0xADEDFC", Offset = "0xADEDFC", VA = "0xADEDFC")]
		public void UpdateActivity(Activity activity, UpdateActivityHandler callback)
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xADDAA4", Offset = "0xADDAA4", VA = "0xADDAA4")]
		[MonoPInvokeCallback]
		private static void ClearActivityCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0xADEFA4", Offset = "0xADEFA4", VA = "0xADEFA4")]
		public void ClearActivity(ClearActivityHandler callback)
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0xADDB50", Offset = "0xADDB50", VA = "0xADDB50")]
		[MonoPInvokeCallback]
		private static void SendRequestReplyCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0xADF144", Offset = "0xADF144", VA = "0xADF144")]
		public void SendRequestReply(long userId, ActivityJoinRequestReply reply, SendRequestReplyHandler callback)
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0xADDBFC", Offset = "0xADDBFC", VA = "0xADDBFC")]
		[MonoPInvokeCallback]
		private static void SendInviteCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0xADF2FC", Offset = "0xADF2FC", VA = "0xADF2FC")]
		public void SendInvite(long userId, ActivityActionType type, string content, SendInviteHandler callback)
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0xADDCA8", Offset = "0xADDCA8", VA = "0xADDCA8")]
		[MonoPInvokeCallback]
		private static void AcceptInviteCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0xADF4BC", Offset = "0xADF4BC", VA = "0xADF4BC")]
		public void AcceptInvite(long userId, AcceptInviteHandler callback)
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0xADDD54", Offset = "0xADDD54", VA = "0xADDD54")]
		[MonoPInvokeCallback]
		private static void OnActivityJoinImpl(IntPtr ptr, string secret)
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0xADDE18", Offset = "0xADDE18", VA = "0xADDE18")]
		[MonoPInvokeCallback]
		private static void OnActivitySpectateImpl(IntPtr ptr, string secret)
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0xADDEDC", Offset = "0xADDEDC", VA = "0xADDEDC")]
		[MonoPInvokeCallback]
		private static void OnActivityJoinRequestImpl(IntPtr ptr, ref User user)
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0xADDFA0", Offset = "0xADDFA0", VA = "0xADDFA0")]
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
		[Address(RVA = "0xAE16E0", Offset = "0xAE16E0", VA = "0xAE16E0")]
		public static ImageHandle User(long id)
		{
			return default(ImageHandle);
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0xAE16F4", Offset = "0xAE16F4", VA = "0xAE16F4")]
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
			[Address(RVA = "0xAE1700", Offset = "0xAE1700", VA = "0xAE1700")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0xAE1818", Offset = "0xAE1818", VA = "0xAE1818")]
		public void SetType(LobbyType type)
		{
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0xAE18E4", Offset = "0xAE18E4", VA = "0xAE18E4")]
		public void SetOwner(long ownerId)
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0xAE19B0", Offset = "0xAE19B0", VA = "0xAE19B0")]
		public void SetCapacity(uint capacity)
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0xAE1A7C", Offset = "0xAE1A7C", VA = "0xAE1A7C")]
		public void SetMetadata(string key, string value)
		{
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0xAE1B58", Offset = "0xAE1B58", VA = "0xAE1B58")]
		public void DeleteMetadata(string key)
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0xAE1C24", Offset = "0xAE1C24", VA = "0xAE1C24")]
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
			[Address(RVA = "0xAE26EC", Offset = "0xAE26EC", VA = "0xAE26EC")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0xAE27F8", Offset = "0xAE27F8", VA = "0xAE27F8")]
		public void SetMetadata(string key, string value)
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0xAE28C8", Offset = "0xAE28C8", VA = "0xAE28C8")]
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
			[Address(RVA = "0xAE2CAC", Offset = "0xAE2CAC", VA = "0xAE2CAC")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0xAE2DBC", Offset = "0xAE2DBC", VA = "0xAE2DBC")]
		public void Filter(string key, LobbySearchComparison comparison, LobbySearchCast cast, string value)
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0xAE2EB0", Offset = "0xAE2EB0", VA = "0xAE2EB0")]
		public void Sort(string key, LobbySearchCast cast, string value)
		{
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0xAE2F94", Offset = "0xAE2F94", VA = "0xAE2F94")]
		public void Limit(uint limit)
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0xAE3060", Offset = "0xAE3060", VA = "0xAE3060")]
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
		[Address(RVA = "0xADE7E8", Offset = "0xADE7E8", VA = "0xADE7E8")]
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
			[Address(RVA = "0xAE3984", Offset = "0xAE3984", VA = "0xAE3984")]
			get
			{
				return default(FFIMethods);
			}
		}

		[PreserveSig]
		[Token(Token = "0x60009D9")]
		[Address(RVA = "0xAE38EC", Offset = "0xAE38EC", VA = "0xAE38EC")]
		private static extern Result DiscordCreate(uint version, ref FFICreateParams createParams, out IntPtr manager);

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0xAE3A98", Offset = "0xAE3A98", VA = "0xAE3A98")]
		public Discord(long clientId, ulong flags)
		{
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0xAE3EB4", Offset = "0xAE3EB4", VA = "0xAE3EB4")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0xAE3F24", Offset = "0xAE3F24", VA = "0xAE3F24", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0xAE40BC", Offset = "0xAE40BC", VA = "0xAE40BC")]
		public void RunCallbacks()
		{
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0xAE3848", Offset = "0xAE3848", VA = "0xAE3848")]
		[MonoPInvokeCallback]
		private static void SetLogHookCallbackImpl(IntPtr ptr, LogLevel level, string message)
		{
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0xAE414C", Offset = "0xAE414C", VA = "0xAE414C")]
		public void SetLogHook(LogLevel minLevel, SetLogHookHandler callback)
		{
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0xAE4380", Offset = "0xAE4380", VA = "0xAE4380")]
		public ApplicationManager GetApplicationManager()
		{
			return null;
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0xAE44FC", Offset = "0xAE44FC", VA = "0xAE44FC")]
		public UserManager GetUserManager()
		{
			return null;
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0xAE4680", Offset = "0xAE4680", VA = "0xAE4680")]
		public ImageManager GetImageManager()
		{
			return null;
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0xAE47FC", Offset = "0xAE47FC", VA = "0xAE47FC")]
		public ActivityManager GetActivityManager()
		{
			return null;
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0xAE48B4", Offset = "0xAE48B4", VA = "0xAE48B4")]
		public RelationshipManager GetRelationshipManager()
		{
			return null;
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0xAE4A38", Offset = "0xAE4A38", VA = "0xAE4A38")]
		public LobbyManager GetLobbyManager()
		{
			return null;
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0xAE4BBC", Offset = "0xAE4BBC", VA = "0xAE4BBC")]
		public NetworkManager GetNetworkManager()
		{
			return null;
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0xAE4C78", Offset = "0xAE4C78", VA = "0xAE4C78")]
		public OverlayManager GetOverlayManager()
		{
			return null;
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0xAE4D34", Offset = "0xAE4D34", VA = "0xAE4D34")]
		public StorageManager GetStorageManager()
		{
			return null;
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0xAE4DF0", Offset = "0xAE4DF0", VA = "0xAE4DF0")]
		public StoreManager GetStoreManager()
		{
			return null;
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0xAE4EAC", Offset = "0xAE4EAC", VA = "0xAE4EAC")]
		public VoiceManager GetVoiceManager()
		{
			return null;
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0xAE4F68", Offset = "0xAE4F68", VA = "0xAE4F68")]
		public AchievementManager GetAchievementManager()
		{
			return null;
		}
	}
	[Token(Token = "0x20001AC")]
	internal class MonoPInvokeCallbackAttribute : Attribute
	{
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0xAE6948", Offset = "0xAE6948", VA = "0xAE6948")]
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
			[Address(RVA = "0xAE6B64", Offset = "0xAE6B64", VA = "0xAE6B64")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0xAE4438", Offset = "0xAE4438", VA = "0xAE4438")]
		internal ApplicationManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0xAE6C7C", Offset = "0xAE6C7C", VA = "0xAE6C7C")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0xAE6950", Offset = "0xAE6950", VA = "0xAE6950")]
		[MonoPInvokeCallback]
		private static void ValidateOrExitCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0xAE6CEC", Offset = "0xAE6CEC", VA = "0xAE6CEC")]
		public void ValidateOrExit(ValidateOrExitHandler callback)
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0xAE6E8C", Offset = "0xAE6E8C", VA = "0xAE6E8C")]
		public string GetCurrentLocale()
		{
			return null;
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0xAE6F2C", Offset = "0xAE6F2C", VA = "0xAE6F2C")]
		public string GetCurrentBranch()
		{
			return null;
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0xAE69FC", Offset = "0xAE69FC", VA = "0xAE69FC")]
		[MonoPInvokeCallback]
		private static void GetOAuth2TokenCallbackImpl(IntPtr ptr, Result result, ref OAuth2Token oauth2Token)
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0xAE6FCC", Offset = "0xAE6FCC", VA = "0xAE6FCC")]
		public void GetOAuth2Token(GetOAuth2TokenHandler callback)
		{
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0xAE6AB0", Offset = "0xAE6AB0", VA = "0xAE6AB0")]
		[MonoPInvokeCallback]
		private static void GetTicketCallbackImpl(IntPtr ptr, Result result, ref string data)
		{
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0xAE716C", Offset = "0xAE716C", VA = "0xAE716C")]
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
			[Address(RVA = "0xAE8364", Offset = "0xAE8364", VA = "0xAE8364")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000005")]
		public event CurrentUserUpdateHandler OnCurrentUserUpdate
		{
			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0xAE8474", Offset = "0xAE8474", VA = "0xAE8474")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0xAE8510", Offset = "0xAE8510", VA = "0xAE8510")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0xAE45B4", Offset = "0xAE45B4", VA = "0xAE45B4")]
		internal UserManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0xAE85AC", Offset = "0xAE85AC", VA = "0xAE85AC")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0xAE873C", Offset = "0xAE873C", VA = "0xAE873C")]
		public User GetCurrentUser()
		{
			return default(User);
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0xAE81FC", Offset = "0xAE81FC", VA = "0xAE81FC")]
		[MonoPInvokeCallback]
		private static void GetUserCallbackImpl(IntPtr ptr, Result result, ref User user)
		{
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0xAE87F0", Offset = "0xAE87F0", VA = "0xAE87F0")]
		public void GetUser(long userId, GetUserHandler callback)
		{
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0xAE8998", Offset = "0xAE8998", VA = "0xAE8998")]
		public PremiumType GetCurrentUserPremiumType()
		{
			return default(PremiumType);
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0xAE8A34", Offset = "0xAE8A34", VA = "0xAE8A34")]
		public bool CurrentUserHasFlag(UserFlag flag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0xAE82B0", Offset = "0xAE82B0", VA = "0xAE82B0")]
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
			[Address(RVA = "0xAE972C", Offset = "0xAE972C", VA = "0xAE972C")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0xAE4738", Offset = "0xAE4738", VA = "0xAE4738")]
		internal ImageManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0xAE9844", Offset = "0xAE9844", VA = "0xAE9844")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0xAE9650", Offset = "0xAE9650", VA = "0xAE9650")]
		[MonoPInvokeCallback]
		private static void FetchCallbackImpl(IntPtr ptr, Result result, ImageHandle handleResult)
		{
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0xAE98B4", Offset = "0xAE98B4", VA = "0xAE98B4")]
		public void Fetch(ImageHandle handle, bool refresh, FetchHandler callback)
		{
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0xAE9A90", Offset = "0xAE9A90", VA = "0xAE9A90")]
		public ImageDimensions GetDimensions(ImageHandle handle)
		{
			return default(ImageDimensions);
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0xAE9B4C", Offset = "0xAE9B4C", VA = "0xAE9B4C")]
		public void GetData(ImageHandle handle, byte[] data)
		{
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0xAE9C10", Offset = "0xAE9C10", VA = "0xAE9C10")]
		public void Fetch(ImageHandle handle, FetchHandler callback)
		{
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0xAE9C44", Offset = "0xAE9C44", VA = "0xAE9C44")]
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
			[Address(RVA = "0xAEA84C", Offset = "0xAEA84C", VA = "0xAEA84C")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000006")]
		public event RefreshHandler OnRefresh
		{
			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0xAEA95C", Offset = "0xAEA95C", VA = "0xAEA95C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0xAEA9F8", Offset = "0xAEA9F8", VA = "0xAEA9F8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event RelationshipUpdateHandler OnRelationshipUpdate
		{
			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0xAEAA94", Offset = "0xAEAA94", VA = "0xAEAA94")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0xAEAB30", Offset = "0xAEAB30", VA = "0xAEAB30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0xAE496C", Offset = "0xAE496C", VA = "0xAE496C")]
		internal RelationshipManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0xAEABCC", Offset = "0xAEABCC", VA = "0xAEABCC")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0xAEA634", Offset = "0xAEA634", VA = "0xAEA634")]
		[MonoPInvokeCallback]
		private static bool FilterCallbackImpl(IntPtr ptr, ref Relationship relationship)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0xAEAE70", Offset = "0xAEAE70", VA = "0xAEAE70")]
		public void Filter(FilterHandler callback)
		{
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0xAEB024", Offset = "0xAEB024", VA = "0xAEB024")]
		public int Count()
		{
			return default(int);
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0xAEB0C0", Offset = "0xAEB0C0", VA = "0xAEB0C0")]
		public Relationship Get(long userId)
		{
			return default(Relationship);
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0xAEB188", Offset = "0xAEB188", VA = "0xAEB188")]
		public Relationship GetAt(uint index)
		{
			return default(Relationship);
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0xAEA6D4", Offset = "0xAEA6D4", VA = "0xAEA6D4")]
		[MonoPInvokeCallback]
		private static void OnRefreshImpl(IntPtr ptr)
		{
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0xAEA788", Offset = "0xAEA788", VA = "0xAEA788")]
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
			[Address(RVA = "0xAECF30", Offset = "0xAECF30", VA = "0xAECF30")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000008")]
		public event LobbyUpdateHandler OnLobbyUpdate
		{
			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0xAED044", Offset = "0xAED044", VA = "0xAED044")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AE9")]
			[Address(RVA = "0xAED0E0", Offset = "0xAED0E0", VA = "0xAED0E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event LobbyDeleteHandler OnLobbyDelete
		{
			[Token(Token = "0x6000AEA")]
			[Address(RVA = "0xAED17C", Offset = "0xAED17C", VA = "0xAED17C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0xAED218", Offset = "0xAED218", VA = "0xAED218")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event MemberConnectHandler OnMemberConnect
		{
			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0xAED2B4", Offset = "0xAED2B4", VA = "0xAED2B4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AED")]
			[Address(RVA = "0xAED350", Offset = "0xAED350", VA = "0xAED350")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event MemberUpdateHandler OnMemberUpdate
		{
			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0xAED3EC", Offset = "0xAED3EC", VA = "0xAED3EC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0xAED488", Offset = "0xAED488", VA = "0xAED488")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event MemberDisconnectHandler OnMemberDisconnect
		{
			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0xAED524", Offset = "0xAED524", VA = "0xAED524")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0xAED5C0", Offset = "0xAED5C0", VA = "0xAED5C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event LobbyMessageHandler OnLobbyMessage
		{
			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0xAED65C", Offset = "0xAED65C", VA = "0xAED65C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0xAED6F8", Offset = "0xAED6F8", VA = "0xAED6F8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event SpeakingHandler OnSpeaking
		{
			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0xAED794", Offset = "0xAED794", VA = "0xAED794")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0xAED830", Offset = "0xAED830", VA = "0xAED830")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public event NetworkMessageHandler OnNetworkMessage
		{
			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0xAED8CC", Offset = "0xAED8CC", VA = "0xAED8CC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0xAED968", Offset = "0xAED968", VA = "0xAED968")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0xAE4AF0", Offset = "0xAE4AF0", VA = "0xAE4AF0")]
		internal LobbyManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0xAEDA04", Offset = "0xAEDA04", VA = "0xAEDA04")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0xAEDD1C", Offset = "0xAEDD1C", VA = "0xAEDD1C")]
		public LobbyTransaction GetLobbyCreateTransaction()
		{
			return default(LobbyTransaction);
		}

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0xAEDDB8", Offset = "0xAEDDB8", VA = "0xAEDDB8")]
		public LobbyTransaction GetLobbyUpdateTransaction(long lobbyId)
		{
			return default(LobbyTransaction);
		}

		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0xAEDE58", Offset = "0xAEDE58", VA = "0xAEDE58")]
		public LobbyMemberTransaction GetMemberUpdateTransaction(long lobbyId, long userId)
		{
			return default(LobbyMemberTransaction);
		}

		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0xAEC01C", Offset = "0xAEC01C", VA = "0xAEC01C")]
		[MonoPInvokeCallback]
		private static void CreateLobbyCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby)
		{
		}

		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0xAEDF08", Offset = "0xAEDF08", VA = "0xAEDF08")]
		public void CreateLobby(LobbyTransaction transaction, CreateLobbyHandler callback)
		{
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0xAEC0D0", Offset = "0xAEC0D0", VA = "0xAEC0D0")]
		[MonoPInvokeCallback]
		private static void UpdateLobbyCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000B00")]
		[Address(RVA = "0xAEE004", Offset = "0xAEE004", VA = "0xAEE004")]
		public void UpdateLobby(long lobbyId, LobbyTransaction transaction, UpdateLobbyHandler callback)
		{
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0xAEC17C", Offset = "0xAEC17C", VA = "0xAEC17C")]
		[MonoPInvokeCallback]
		private static void DeleteLobbyCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0xAEE108", Offset = "0xAEE108", VA = "0xAEE108")]
		public void DeleteLobby(long lobbyId, DeleteLobbyHandler callback)
		{
		}

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0xAEC228", Offset = "0xAEC228", VA = "0xAEC228")]
		[MonoPInvokeCallback]
		private static void ConnectLobbyCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby)
		{
		}

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0xAEE1F8", Offset = "0xAEE1F8", VA = "0xAEE1F8")]
		public void ConnectLobby(long lobbyId, string secret, ConnectLobbyHandler callback)
		{
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0xAEC2DC", Offset = "0xAEC2DC", VA = "0xAEC2DC")]
		[MonoPInvokeCallback]
		private static void ConnectLobbyWithActivitySecretCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby)
		{
		}

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0xAEE2F0", Offset = "0xAEE2F0", VA = "0xAEE2F0")]
		public void ConnectLobbyWithActivitySecret(string activitySecret, ConnectLobbyWithActivitySecretHandler callback)
		{
		}

		[Token(Token = "0x6000B07")]
		[Address(RVA = "0xAEC390", Offset = "0xAEC390", VA = "0xAEC390")]
		[MonoPInvokeCallback]
		private static void DisconnectLobbyCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0xAEE3E0", Offset = "0xAEE3E0", VA = "0xAEE3E0")]
		public void DisconnectLobby(long lobbyId, DisconnectLobbyHandler callback)
		{
		}

		[Token(Token = "0x6000B09")]
		[Address(RVA = "0xAEE4D0", Offset = "0xAEE4D0", VA = "0xAEE4D0")]
		public Lobby GetLobby(long lobbyId)
		{
			return default(Lobby);
		}

		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0xAEE594", Offset = "0xAEE594", VA = "0xAEE594")]
		public string GetLobbyActivitySecret(long lobbyId)
		{
			return null;
		}

		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0xAEE688", Offset = "0xAEE688", VA = "0xAEE688")]
		public string GetLobbyMetadataValue(long lobbyId, string key)
		{
			return null;
		}

		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0xAEE78C", Offset = "0xAEE78C", VA = "0xAEE78C")]
		public string GetLobbyMetadataKey(long lobbyId, int index)
		{
			return null;
		}

		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0xAEE890", Offset = "0xAEE890", VA = "0xAEE890")]
		public int LobbyMetadataCount(long lobbyId)
		{
			return default(int);
		}

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0xAEE930", Offset = "0xAEE930", VA = "0xAEE930")]
		public int MemberCount(long lobbyId)
		{
			return default(int);
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0xAEE9D0", Offset = "0xAEE9D0", VA = "0xAEE9D0")]
		public long GetMemberUserId(long lobbyId, int index)
		{
			return default(long);
		}

		[Token(Token = "0x6000B10")]
		[Address(RVA = "0xAEEA78", Offset = "0xAEEA78", VA = "0xAEEA78")]
		public User GetMemberUser(long lobbyId, long userId)
		{
			return default(User);
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0xAEEB4C", Offset = "0xAEEB4C", VA = "0xAEEB4C")]
		public string GetMemberMetadataValue(long lobbyId, long userId, string key)
		{
			return null;
		}

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0xAEEC58", Offset = "0xAEEC58", VA = "0xAEEC58")]
		public string GetMemberMetadataKey(long lobbyId, long userId, int index)
		{
			return null;
		}

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0xAEED64", Offset = "0xAEED64", VA = "0xAEED64")]
		public int MemberMetadataCount(long lobbyId, long userId)
		{
			return default(int);
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0xAEC43C", Offset = "0xAEC43C", VA = "0xAEC43C")]
		[MonoPInvokeCallback]
		private static void UpdateMemberCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0xAEEE14", Offset = "0xAEEE14", VA = "0xAEEE14")]
		public void UpdateMember(long lobbyId, long userId, LobbyMemberTransaction transaction, UpdateMemberHandler callback)
		{
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0xAEC4E8", Offset = "0xAEC4E8", VA = "0xAEC4E8")]
		[MonoPInvokeCallback]
		private static void SendLobbyMessageCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0xAEEF28", Offset = "0xAEEF28", VA = "0xAEEF28")]
		public void SendLobbyMessage(long lobbyId, byte[] data, SendLobbyMessageHandler callback)
		{
		}

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0xAEF028", Offset = "0xAEF028", VA = "0xAEF028")]
		public LobbySearchQuery GetSearchQuery()
		{
			return default(LobbySearchQuery);
		}

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0xAEC594", Offset = "0xAEC594", VA = "0xAEC594")]
		[MonoPInvokeCallback]
		private static void SearchCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0xAEF0C4", Offset = "0xAEF0C4", VA = "0xAEF0C4")]
		public void Search(LobbySearchQuery query, SearchHandler callback)
		{
		}

		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0xAEF1C0", Offset = "0xAEF1C0", VA = "0xAEF1C0")]
		public int LobbyCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0xAEF214", Offset = "0xAEF214", VA = "0xAEF214")]
		public long GetLobbyId(int index)
		{
			return default(long);
		}

		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0xAEC640", Offset = "0xAEC640", VA = "0xAEC640")]
		[MonoPInvokeCallback]
		private static void ConnectVoiceCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0xAEF2B4", Offset = "0xAEF2B4", VA = "0xAEF2B4")]
		public void ConnectVoice(long lobbyId, ConnectVoiceHandler callback)
		{
		}

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0xAEC6EC", Offset = "0xAEC6EC", VA = "0xAEC6EC")]
		[MonoPInvokeCallback]
		private static void DisconnectVoiceCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000B20")]
		[Address(RVA = "0xAEF3A4", Offset = "0xAEF3A4", VA = "0xAEF3A4")]
		public void DisconnectVoice(long lobbyId, DisconnectVoiceHandler callback)
		{
		}

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0xAEF494", Offset = "0xAEF494", VA = "0xAEF494")]
		public void ConnectNetwork(long lobbyId)
		{
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0xAEF52C", Offset = "0xAEF52C", VA = "0xAEF52C")]
		public void DisconnectNetwork(long lobbyId)
		{
		}

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0xAEF5C4", Offset = "0xAEF5C4", VA = "0xAEF5C4")]
		public void FlushNetwork()
		{
		}

		[Token(Token = "0x6000B24")]
		[Address(RVA = "0xAEF654", Offset = "0xAEF654", VA = "0xAEF654")]
		public void OpenNetworkChannel(long lobbyId, byte channelId, bool reliable)
		{
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0xAEF700", Offset = "0xAEF700", VA = "0xAEF700")]
		public void SendNetworkMessage(long lobbyId, long userId, byte channelId, byte[] data)
		{
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0xAEC798", Offset = "0xAEC798", VA = "0xAEC798")]
		[MonoPInvokeCallback]
		private static void OnLobbyUpdateImpl(IntPtr ptr, long lobbyId)
		{
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0xAEC85C", Offset = "0xAEC85C", VA = "0xAEC85C")]
		[MonoPInvokeCallback]
		private static void OnLobbyDeleteImpl(IntPtr ptr, long lobbyId, uint reason)
		{
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0xAEC928", Offset = "0xAEC928", VA = "0xAEC928")]
		[MonoPInvokeCallback]
		private static void OnMemberConnectImpl(IntPtr ptr, long lobbyId, long userId)
		{
		}

		[Token(Token = "0x6000B29")]
		[Address(RVA = "0xAEC9F4", Offset = "0xAEC9F4", VA = "0xAEC9F4")]
		[MonoPInvokeCallback]
		private static void OnMemberUpdateImpl(IntPtr ptr, long lobbyId, long userId)
		{
		}

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0xAECAC0", Offset = "0xAECAC0", VA = "0xAECAC0")]
		[MonoPInvokeCallback]
		private static void OnMemberDisconnectImpl(IntPtr ptr, long lobbyId, long userId)
		{
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0xAECB8C", Offset = "0xAECB8C", VA = "0xAECB8C")]
		[MonoPInvokeCallback]
		private static void OnLobbyMessageImpl(IntPtr ptr, long lobbyId, long userId, IntPtr dataPtr, int dataLen)
		{
		}

		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0xAECCE8", Offset = "0xAECCE8", VA = "0xAECCE8")]
		[MonoPInvokeCallback]
		private static void OnSpeakingImpl(IntPtr ptr, long lobbyId, long userId, bool speaking)
		{
		}

		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0xAECDC4", Offset = "0xAECDC4", VA = "0xAECDC4")]
		[MonoPInvokeCallback]
		private static void OnNetworkMessageImpl(IntPtr ptr, long lobbyId, long userId, byte channelId, IntPtr dataPtr, int dataLen)
		{
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0xAEF7C4", Offset = "0xAEF7C4", VA = "0xAEF7C4")]
		public IEnumerable<User> GetMemberUsers(long lobbyID)
		{
			return null;
		}

		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0xAEF94C", Offset = "0xAEF94C", VA = "0xAEF94C")]
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
			[Address(RVA = "0xAF84E8", Offset = "0xAF84E8", VA = "0xAF84E8")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000010")]
		public event MessageHandler OnMessage
		{
			[Token(Token = "0x6000C4D")]
			[Address(RVA = "0xAF8600", Offset = "0xAF8600", VA = "0xAF8600")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000C4E")]
			[Address(RVA = "0xAF869C", Offset = "0xAF869C", VA = "0xAF869C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event RouteUpdateHandler OnRouteUpdate
		{
			[Token(Token = "0x6000C4F")]
			[Address(RVA = "0xAF8738", Offset = "0xAF8738", VA = "0xAF8738")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000C50")]
			[Address(RVA = "0xAF87D4", Offset = "0xAF87D4", VA = "0xAF87D4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000C51")]
		[Address(RVA = "0xAF8870", Offset = "0xAF8870", VA = "0xAF8870")]
		internal NetworkManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000C52")]
		[Address(RVA = "0xAF8940", Offset = "0xAF8940", VA = "0xAF8940")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000C53")]
		[Address(RVA = "0xAF8BE4", Offset = "0xAF8BE4", VA = "0xAF8BE4")]
		public ulong GetPeerId()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000C54")]
		[Address(RVA = "0xAF8C30", Offset = "0xAF8C30", VA = "0xAF8C30")]
		public void Flush()
		{
		}

		[Token(Token = "0x6000C55")]
		[Address(RVA = "0xAF8CC4", Offset = "0xAF8CC4", VA = "0xAF8CC4")]
		public void OpenPeer(ulong peerId, string routeData)
		{
		}

		[Token(Token = "0x6000C56")]
		[Address(RVA = "0xAF8D68", Offset = "0xAF8D68", VA = "0xAF8D68")]
		public void UpdatePeer(ulong peerId, string routeData)
		{
		}

		[Token(Token = "0x6000C57")]
		[Address(RVA = "0xAF8E0C", Offset = "0xAF8E0C", VA = "0xAF8E0C")]
		public void ClosePeer(ulong peerId)
		{
		}

		[Token(Token = "0x6000C58")]
		[Address(RVA = "0xAF8EA8", Offset = "0xAF8EA8", VA = "0xAF8EA8")]
		public void OpenChannel(ulong peerId, byte channelId, bool reliable)
		{
		}

		[Token(Token = "0x6000C59")]
		[Address(RVA = "0xAF8F58", Offset = "0xAF8F58", VA = "0xAF8F58")]
		public void CloseChannel(ulong peerId, byte channelId)
		{
		}

		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0xAF8FFC", Offset = "0xAF8FFC", VA = "0xAF8FFC")]
		public void SendMessage(ulong peerId, byte channelId, byte[] data)
		{
		}

		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0xAF82C8", Offset = "0xAF82C8", VA = "0xAF82C8")]
		[MonoPInvokeCallback]
		private static void OnMessageImpl(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen)
		{
		}

		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0xAF8424", Offset = "0xAF8424", VA = "0xAF8424")]
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
			[Address(RVA = "0xAFA73C", Offset = "0xAFA73C", VA = "0xAFA73C")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000012")]
		public event ToggleHandler OnToggle
		{
			[Token(Token = "0x6000C8E")]
			[Address(RVA = "0xAFA854", Offset = "0xAFA854", VA = "0xAFA854")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000C8F")]
			[Address(RVA = "0xAFA8F0", Offset = "0xAFA8F0", VA = "0xAFA8F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000C90")]
		[Address(RVA = "0xAFA98C", Offset = "0xAFA98C", VA = "0xAFA98C")]
		internal OverlayManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000C91")]
		[Address(RVA = "0xAFAA5C", Offset = "0xAFAA5C", VA = "0xAFAA5C")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000C92")]
		[Address(RVA = "0xAFABEC", Offset = "0xAFABEC", VA = "0xAFABEC")]
		public bool IsEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C93")]
		[Address(RVA = "0xAFAC38", Offset = "0xAFAC38", VA = "0xAFAC38")]
		public bool IsLocked()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C94")]
		[Address(RVA = "0xAFA3C8", Offset = "0xAFA3C8", VA = "0xAFA3C8")]
		[MonoPInvokeCallback]
		private static void SetLockedCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000C95")]
		[Address(RVA = "0xAFAC84", Offset = "0xAFAC84", VA = "0xAFAC84")]
		public void SetLocked(bool locked, SetLockedHandler callback)
		{
		}

		[Token(Token = "0x6000C96")]
		[Address(RVA = "0xAFA474", Offset = "0xAFA474", VA = "0xAFA474")]
		[MonoPInvokeCallback]
		private static void OpenActivityInviteCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000C97")]
		[Address(RVA = "0xAFAE2C", Offset = "0xAFAE2C", VA = "0xAFAE2C")]
		public void OpenActivityInvite(ActivityActionType type, OpenActivityInviteHandler callback)
		{
		}

		[Token(Token = "0x6000C98")]
		[Address(RVA = "0xAFA520", Offset = "0xAFA520", VA = "0xAFA520")]
		[MonoPInvokeCallback]
		private static void OpenGuildInviteCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000C99")]
		[Address(RVA = "0xAFAFD4", Offset = "0xAFAFD4", VA = "0xAFAFD4")]
		public void OpenGuildInvite(string code, OpenGuildInviteHandler callback)
		{
		}

		[Token(Token = "0x6000C9A")]
		[Address(RVA = "0xAFA5CC", Offset = "0xAFA5CC", VA = "0xAFA5CC")]
		[MonoPInvokeCallback]
		private static void OpenVoiceSettingsCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000C9B")]
		[Address(RVA = "0xAFB17C", Offset = "0xAFB17C", VA = "0xAFB17C")]
		public void OpenVoiceSettings(OpenVoiceSettingsHandler callback)
		{
		}

		[Token(Token = "0x6000C9C")]
		[Address(RVA = "0xAFA678", Offset = "0xAFA678", VA = "0xAFA678")]
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
			[Address(RVA = "0xAFCB40", Offset = "0xAFCB40", VA = "0xAFCB40")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x6000CDE")]
		[Address(RVA = "0xAFCC54", Offset = "0xAFCC54", VA = "0xAFCC54")]
		internal StorageManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000CDF")]
		[Address(RVA = "0xAFCD1C", Offset = "0xAFCD1C", VA = "0xAFCD1C")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000CE0")]
		[Address(RVA = "0xAFCD8C", Offset = "0xAFCD8C", VA = "0xAFCD8C")]
		public uint Read(string name, byte[] data)
		{
			return default(uint);
		}

		[Token(Token = "0x6000CE1")]
		[Address(RVA = "0xAFC83C", Offset = "0xAFC83C", VA = "0xAFC83C")]
		[MonoPInvokeCallback]
		private static void ReadAsyncCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen)
		{
		}

		[Token(Token = "0x6000CE2")]
		[Address(RVA = "0xAFCE40", Offset = "0xAFCE40", VA = "0xAFCE40")]
		public void ReadAsync(string name, ReadAsyncHandler callback)
		{
		}

		[Token(Token = "0x6000CE3")]
		[Address(RVA = "0xAFC968", Offset = "0xAFC968", VA = "0xAFC968")]
		[MonoPInvokeCallback]
		private static void ReadAsyncPartialCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen)
		{
		}

		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0xAFCFE8", Offset = "0xAFCFE8", VA = "0xAFCFE8")]
		public void ReadAsyncPartial(string name, ulong offset, ulong length, ReadAsyncPartialHandler callback)
		{
		}

		[Token(Token = "0x6000CE5")]
		[Address(RVA = "0xAFD1A8", Offset = "0xAFD1A8", VA = "0xAFD1A8")]
		public void Write(string name, byte[] data)
		{
		}

		[Token(Token = "0x6000CE6")]
		[Address(RVA = "0xAFCA94", Offset = "0xAFCA94", VA = "0xAFCA94")]
		[MonoPInvokeCallback]
		private static void WriteAsyncCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000CE7")]
		[Address(RVA = "0xAFD250", Offset = "0xAFD250", VA = "0xAFD250")]
		public void WriteAsync(string name, byte[] data, WriteAsyncHandler callback)
		{
		}

		[Token(Token = "0x6000CE8")]
		[Address(RVA = "0xAFD410", Offset = "0xAFD410", VA = "0xAFD410")]
		public void Delete(string name)
		{
		}

		[Token(Token = "0x6000CE9")]
		[Address(RVA = "0xAFD4AC", Offset = "0xAFD4AC", VA = "0xAFD4AC")]
		public bool Exists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CEA")]
		[Address(RVA = "0xAFD550", Offset = "0xAFD550", VA = "0xAFD550")]
		public int Count()
		{
			return default(int);
		}

		[Token(Token = "0x6000CEB")]
		[Address(RVA = "0xAFD59C", Offset = "0xAFD59C", VA = "0xAFD59C")]
		public FileStat Stat(string name)
		{
			return default(FileStat);
		}

		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0xAFD654", Offset = "0xAFD654", VA = "0xAFD654")]
		public FileStat StatAt(int index)
		{
			return default(FileStat);
		}

		[Token(Token = "0x6000CED")]
		[Address(RVA = "0xAFD70C", Offset = "0xAFD70C", VA = "0xAFD70C")]
		public string GetPath()
		{
			return null;
		}

		[Token(Token = "0x6000CEE")]
		[Address(RVA = "0xAFD7F4", Offset = "0xAFD7F4", VA = "0xAFD7F4")]
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
			[Address(RVA = "0xAFF770", Offset = "0xAFF770", VA = "0xAFF770")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000013")]
		public event EntitlementCreateHandler OnEntitlementCreate
		{
			[Token(Token = "0x6000D34")]
			[Address(RVA = "0xAFF884", Offset = "0xAFF884", VA = "0xAFF884")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000D35")]
			[Address(RVA = "0xAFF920", Offset = "0xAFF920", VA = "0xAFF920")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event EntitlementDeleteHandler OnEntitlementDelete
		{
			[Token(Token = "0x6000D36")]
			[Address(RVA = "0xAFF9BC", Offset = "0xAFF9BC", VA = "0xAFF9BC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000D37")]
			[Address(RVA = "0xAFFA58", Offset = "0xAFFA58", VA = "0xAFFA58")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000D38")]
		[Address(RVA = "0xAFFAF4", Offset = "0xAFFAF4", VA = "0xAFFAF4")]
		internal StoreManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000D39")]
		[Address(RVA = "0xAFFBC4", Offset = "0xAFFBC4", VA = "0xAFFBC4")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000D3A")]
		[Address(RVA = "0xAFF3E4", Offset = "0xAFF3E4", VA = "0xAFF3E4")]
		[MonoPInvokeCallback]
		private static void FetchSkusCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000D3B")]
		[Address(RVA = "0xAFFE68", Offset = "0xAFFE68", VA = "0xAFFE68")]
		public void FetchSkus(FetchSkusHandler callback)
		{
		}

		[Token(Token = "0x6000D3C")]
		[Address(RVA = "0xB00008", Offset = "0xB00008", VA = "0xB00008")]
		public int CountSkus()
		{
			return default(int);
		}

		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0xB00054", Offset = "0xB00054", VA = "0xB00054")]
		public Sku GetSku(long skuId)
		{
			return default(Sku);
		}

		[Token(Token = "0x6000D3E")]
		[Address(RVA = "0xB00110", Offset = "0xB00110", VA = "0xB00110")]
		public Sku GetSkuAt(int index)
		{
			return default(Sku);
		}

		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0xAFF490", Offset = "0xAFF490", VA = "0xAFF490")]
		[MonoPInvokeCallback]
		private static void FetchEntitlementsCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000D40")]
		[Address(RVA = "0xB001CC", Offset = "0xB001CC", VA = "0xB001CC")]
		public void FetchEntitlements(FetchEntitlementsHandler callback)
		{
		}

		[Token(Token = "0x6000D41")]
		[Address(RVA = "0xB0036C", Offset = "0xB0036C", VA = "0xB0036C")]
		public int CountEntitlements()
		{
			return default(int);
		}

		[Token(Token = "0x6000D42")]
		[Address(RVA = "0xB003B8", Offset = "0xB003B8", VA = "0xB003B8")]
		public Entitlement GetEntitlement(long entitlementId)
		{
			return default(Entitlement);
		}

		[Token(Token = "0x6000D43")]
		[Address(RVA = "0xB00470", Offset = "0xB00470", VA = "0xB00470")]
		public Entitlement GetEntitlementAt(int index)
		{
			return default(Entitlement);
		}

		[Token(Token = "0x6000D44")]
		[Address(RVA = "0xB00528", Offset = "0xB00528", VA = "0xB00528")]
		public bool HasSkuEntitlement(long skuId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D45")]
		[Address(RVA = "0xAFF53C", Offset = "0xAFF53C", VA = "0xAFF53C")]
		[MonoPInvokeCallback]
		private static void StartPurchaseCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000D46")]
		[Address(RVA = "0xB005CC", Offset = "0xB005CC", VA = "0xB005CC")]
		public void StartPurchase(long skuId, StartPurchaseHandler callback)
		{
		}

		[Token(Token = "0x6000D47")]
		[Address(RVA = "0xAFF5E8", Offset = "0xAFF5E8", VA = "0xAFF5E8")]
		[MonoPInvokeCallback]
		private static void OnEntitlementCreateImpl(IntPtr ptr, ref Entitlement entitlement)
		{
		}

		[Token(Token = "0x6000D48")]
		[Address(RVA = "0xAFF6AC", Offset = "0xAFF6AC", VA = "0xAFF6AC")]
		[MonoPInvokeCallback]
		private static void OnEntitlementDeleteImpl(IntPtr ptr, ref Entitlement entitlement)
		{
		}

		[Token(Token = "0x6000D49")]
		[Address(RVA = "0xB00774", Offset = "0xB00774", VA = "0xB00774")]
		public IEnumerable<Entitlement> GetEntitlements()
		{
			return null;
		}

		[Token(Token = "0x6000D4A")]
		[Address(RVA = "0xB008DC", Offset = "0xB008DC", VA = "0xB008DC")]
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
			[Address(RVA = "0xB02904", Offset = "0xB02904", VA = "0xB02904")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000015")]
		public event SettingsUpdateHandler OnSettingsUpdate
		{
			[Token(Token = "0x6000D9C")]
			[Address(RVA = "0xB02A18", Offset = "0xB02A18", VA = "0xB02A18")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000D9D")]
			[Address(RVA = "0xB02AB4", Offset = "0xB02AB4", VA = "0xB02AB4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0xB02B50", Offset = "0xB02B50", VA = "0xB02B50")]
		internal VoiceManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0xB02C20", Offset = "0xB02C20", VA = "0xB02C20")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000DA0")]
		[Address(RVA = "0xB02DB0", Offset = "0xB02DB0", VA = "0xB02DB0")]
		public InputMode GetInputMode()
		{
			return default(InputMode);
		}

		[Token(Token = "0x6000DA1")]
		[Address(RVA = "0xB027A4", Offset = "0xB027A4", VA = "0xB027A4")]
		[MonoPInvokeCallback]
		private static void SetInputModeCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0xB02E50", Offset = "0xB02E50", VA = "0xB02E50")]
		public void SetInputMode(InputMode inputMode, SetInputModeHandler callback)
		{
		}

		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0xB03008", Offset = "0xB03008", VA = "0xB03008")]
		public bool IsSelfMute()
		{
			return default(bool);
		}

		[Token(Token = "0x6000DA4")]
		[Address(RVA = "0xB030A8", Offset = "0xB030A8", VA = "0xB030A8")]
		public void SetSelfMute(bool mute)
		{
		}

		[Token(Token = "0x6000DA5")]
		[Address(RVA = "0xB03144", Offset = "0xB03144", VA = "0xB03144")]
		public bool IsSelfDeaf()
		{
			return default(bool);
		}

		[Token(Token = "0x6000DA6")]
		[Address(RVA = "0xB031E4", Offset = "0xB031E4", VA = "0xB031E4")]
		public void SetSelfDeaf(bool deaf)
		{
		}

		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0xB03280", Offset = "0xB03280", VA = "0xB03280")]
		public bool IsLocalMute(long userId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000DA8")]
		[Address(RVA = "0xB03324", Offset = "0xB03324", VA = "0xB03324")]
		public void SetLocalMute(long userId, bool mute)
		{
		}

		[Token(Token = "0x6000DA9")]
		[Address(RVA = "0xB033C8", Offset = "0xB033C8", VA = "0xB033C8")]
		public byte GetLocalVolume(long userId)
		{
			return default(byte);
		}

		[Token(Token = "0x6000DAA")]
		[Address(RVA = "0xB0346C", Offset = "0xB0346C", VA = "0xB0346C")]
		public void SetLocalVolume(long userId, byte volume)
		{
		}

		[Token(Token = "0x6000DAB")]
		[Address(RVA = "0xB02850", Offset = "0xB02850", VA = "0xB02850")]
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
			[Address(RVA = "0xB04D08", Offset = "0xB04D08", VA = "0xB04D08")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000016")]
		public event UserAchievementUpdateHandler OnUserAchievementUpdate
		{
			[Token(Token = "0x6000DE5")]
			[Address(RVA = "0xB04E20", Offset = "0xB04E20", VA = "0xB04E20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000DE6")]
			[Address(RVA = "0xB04EBC", Offset = "0xB04EBC", VA = "0xB04EBC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000DE7")]
		[Address(RVA = "0xB04F58", Offset = "0xB04F58", VA = "0xB04F58")]
		internal AchievementManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000DE8")]
		[Address(RVA = "0xB05028", Offset = "0xB05028", VA = "0xB05028")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000DE9")]
		[Address(RVA = "0xB04AEC", Offset = "0xB04AEC", VA = "0xB04AEC")]
		[MonoPInvokeCallback]
		private static void SetUserAchievementCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000DEA")]
		[Address(RVA = "0xB051B8", Offset = "0xB051B8", VA = "0xB051B8")]
		public void SetUserAchievement(long achievementId, byte percentComplete, SetUserAchievementHandler callback)
		{
		}

		[Token(Token = "0x6000DEB")]
		[Address(RVA = "0xB04B98", Offset = "0xB04B98", VA = "0xB04B98")]
		[MonoPInvokeCallback]
		private static void FetchUserAchievementsCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000DEC")]
		[Address(RVA = "0xB05370", Offset = "0xB05370", VA = "0xB05370")]
		public void FetchUserAchievements(FetchUserAchievementsHandler callback)
		{
		}

		[Token(Token = "0x6000DED")]
		[Address(RVA = "0xB05510", Offset = "0xB05510", VA = "0xB05510")]
		public int CountUserAchievements()
		{
			return default(int);
		}

		[Token(Token = "0x6000DEE")]
		[Address(RVA = "0xB0555C", Offset = "0xB0555C", VA = "0xB0555C")]
		public UserAchievement GetUserAchievement(long userAchievementId)
		{
			return default(UserAchievement);
		}

		[Token(Token = "0x6000DEF")]
		[Address(RVA = "0xB0560C", Offset = "0xB0560C", VA = "0xB0560C")]
		public UserAchievement GetUserAchievementAt(int index)
		{
			return default(UserAchievement);
		}

		[Token(Token = "0x6000DF0")]
		[Address(RVA = "0xB04C44", Offset = "0xB04C44", VA = "0xB04C44")]
		[MonoPInvokeCallback]
		private static void OnUserAchievementUpdateImpl(IntPtr ptr, ref UserAchievement userAchievement)
		{
		}
	}
}
