using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using FluffyUnderware.Curvy.Generator;
using FluffyUnderware.Curvy.ThirdParty.LibTessDotNet;
using FluffyUnderware.DevTools;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FF194", Offset = "0x4FF194")]
internal sealed class <>f__AnonymousType0<<A>j__TPar, <B>j__TPar, <C>j__TPar, <D>j__TPar>
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x501688", Offset = "0x501688")]
	private readonly <A>j__TPar <A>i__Field;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x50169C", Offset = "0x50169C")]
	private readonly <B>j__TPar <B>i__Field;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x5016B0", Offset = "0x5016B0")]
	private readonly <C>j__TPar <C>i__Field;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x5016C4", Offset = "0x5016C4")]
	private readonly <D>j__TPar <D>i__Field;

	[Token(Token = "0x17000001")]
	public <A>j__TPar A
	{
		[Token(Token = "0x6000001")]
		get
		{
			return (<A>j__TPar)null;
		}
	}

	[Token(Token = "0x17000002")]
	public <B>j__TPar B
	{
		[Token(Token = "0x6000002")]
		get
		{
			return (<B>j__TPar)null;
		}
	}

	[Token(Token = "0x17000003")]
	public <C>j__TPar C
	{
		[Token(Token = "0x6000003")]
		get
		{
			return (<C>j__TPar)null;
		}
	}

	[Token(Token = "0x17000004")]
	public <D>j__TPar D
	{
		[Token(Token = "0x6000004")]
		get
		{
			return (<D>j__TPar)null;
		}
	}

	[Token(Token = "0x6000005")]
	[DebuggerHidden]
	public <>f__AnonymousType0(<A>j__TPar A, <B>j__TPar B, <C>j__TPar C, <D>j__TPar D)
	{
	}

	[Token(Token = "0x6000006")]
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[DebuggerHidden]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FF1A4", Offset = "0x4FF1A4")]
internal sealed class <>f__AnonymousType1<<A>j__TPar, <B>j__TPar, <C>j__TPar, <D>j__TPar, <E>j__TPar>
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x5016D8", Offset = "0x5016D8")]
	private readonly <A>j__TPar <A>i__Field;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x5016EC", Offset = "0x5016EC")]
	private readonly <B>j__TPar <B>i__Field;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x501700", Offset = "0x501700")]
	private readonly <C>j__TPar <C>i__Field;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x501714", Offset = "0x501714")]
	private readonly <D>j__TPar <D>i__Field;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x501728", Offset = "0x501728")]
	private readonly <E>j__TPar <E>i__Field;

	[Token(Token = "0x17000005")]
	public <A>j__TPar A
	{
		[Token(Token = "0x6000009")]
		get
		{
			return (<A>j__TPar)null;
		}
	}

	[Token(Token = "0x17000006")]
	public <B>j__TPar B
	{
		[Token(Token = "0x600000A")]
		get
		{
			return (<B>j__TPar)null;
		}
	}

	[Token(Token = "0x17000007")]
	public <C>j__TPar C
	{
		[Token(Token = "0x600000B")]
		get
		{
			return (<C>j__TPar)null;
		}
	}

	[Token(Token = "0x17000008")]
	public <D>j__TPar D
	{
		[Token(Token = "0x600000C")]
		get
		{
			return (<D>j__TPar)null;
		}
	}

	[Token(Token = "0x17000009")]
	public <E>j__TPar E
	{
		[Token(Token = "0x600000D")]
		get
		{
			return (<E>j__TPar)null;
		}
	}

	[Token(Token = "0x600000E")]
	[DebuggerHidden]
	public <>f__AnonymousType1(<A>j__TPar A, <B>j__TPar B, <C>j__TPar C, <D>j__TPar D, <E>j__TPar E)
	{
	}

	[Token(Token = "0x600000F")]
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000010")]
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000011")]
	[DebuggerHidden]
	public override string ToString()
	{
		return null;
	}
}
namespace FluffyUnderware.DevTools
{
	[Token(Token = "0x2000004")]
	public interface IDTGroupParsingAttribute
	{
		[Token(Token = "0x1700000A")]
		string Path
		{
			[Token(Token = "0x6000012")]
			get;
		}
	}
	[Token(Token = "0x2000005")]
	public interface IDTFieldParsingAttribute
	{
	}
	[Token(Token = "0x2000006")]
	public interface IDTGroupRenderAttribute
	{
	}
	[Token(Token = "0x2000007")]
	public interface IDTFieldRenderAttribute
	{
	}
	[Token(Token = "0x2000008")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x4FF1B4", Offset = "0x4FF1B4")]
	public class DTVersionAttribute : Attribute
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Version;

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xEBB034", Offset = "0xEBB034", VA = "0xEBB034")]
		public DTVersionAttribute(string version)
		{
		}
	}
	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x4FF1E8", Offset = "0x4FF1E8")]
	public class DTAttribute : Attribute, IComparable
	{
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50173C", Offset = "0x50173C")]
		private int <TypeSort>k__BackingField;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int Sort;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ShowBelowProperty;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int Space;

		[Token(Token = "0x1700000B")]
		public int TypeSort
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0xEB6B70", Offset = "0xEB6B70", VA = "0xEB6B70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50D85C", Offset = "0x50D85C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000015")]
			[Address(RVA = "0xEB6B78", Offset = "0xEB6B78", VA = "0xEB6B78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50D86C", Offset = "0x50D86C")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xEB6B80", Offset = "0xEB6B80", VA = "0xEB6B80", Slot = "8")]
		public virtual int CompareTo(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xEB6C50", Offset = "0xEB6C50", VA = "0xEB6C50")]
		public DTAttribute(int sortOrder, bool showBelow = false)
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class GroupAttribute : DTAttribute, IDTGroupParsingAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50174C", Offset = "0x50174C")]
		private bool <PathIsAbsolute>k__BackingField;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool Expanded;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool Invisible;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Label;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Tooltip;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string HelpURL;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string mPath;

		[Token(Token = "0x1700000C")]
		public string Path
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0xEBD024", Offset = "0xEBD024", VA = "0xEBD024", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0xEBD02C", Offset = "0xEBD02C", VA = "0xEBD02C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public bool PathIsAbsolute
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0xEBD120", Offset = "0xEBD120", VA = "0xEBD120")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50D87C", Offset = "0x50D87C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0xEBD128", Offset = "0xEBD128", VA = "0xEBD128")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50D88C", Offset = "0x50D88C")]
			private set
			{
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xEBD134", Offset = "0xEBD134", VA = "0xEBD134")]
		public GroupAttribute(string pathAndName)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class ActionAttribute : DTAttribute
	{
		[Token(Token = "0x200000C")]
		public enum ActionEnum
		{
			[Token(Token = "0x400001B")]
			Show,
			[Token(Token = "0x400001C")]
			Hide,
			[Token(Token = "0x400001D")]
			Enable,
			[Token(Token = "0x400001E")]
			Disable,
			[Token(Token = "0x400001F")]
			ShowInfo,
			[Token(Token = "0x4000020")]
			ShowWarning,
			[Token(Token = "0x4000021")]
			ShowError,
			[Token(Token = "0x4000022")]
			Callback
		}

		[Token(Token = "0x200000D")]
		public enum ActionPositionEnum
		{
			[Token(Token = "0x4000024")]
			Above,
			[Token(Token = "0x4000025")]
			Below
		}

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ActionEnum Action;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public ActionPositionEnum Position;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public object ActionData;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MethodInfo mCallback;

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xC053D4", Offset = "0xC053D4", VA = "0xC053D4")]
		protected ActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xC05430", Offset = "0xC05430", VA = "0xC05430")]
		public void Callback(object classInstance)
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class ConditionalAttribute : ActionAttribute
	{
		[Token(Token = "0x200000F")]
		public enum OperatorEnum
		{
			[Token(Token = "0x4000028")]
			AND,
			[Token(Token = "0x4000029")]
			OR
		}

		[Token(Token = "0x2000010")]
		public class Condition
		{
			[Token(Token = "0x400002A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string FieldName;

			[Token(Token = "0x400002B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FieldInfo FieldInfo;

			[Token(Token = "0x400002C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PropertyInfo PropertyInfo;

			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object CompareTo;

			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool CompareFalse;

			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public OperatorEnum Operator;

			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MethodInfo MethodInfo;

			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string MethodName;

			[Token(Token = "0x6000025")]
			[Address(RVA = "0xE7E1D0", Offset = "0xE7E1D0", VA = "0xE7E1D0")]
			public Condition()
			{
			}
		}

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Condition[] Conditions;

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xB89AE8", Offset = "0xB89AE8", VA = "0xB89AE8")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xB89C28", Offset = "0xB89C28", VA = "0xB89C28")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xB89E08", Offset = "0xB89E08", VA = "0xB89E08")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xB8A07C", Offset = "0xB8A07C", VA = "0xB8A07C")]
		protected ConditionalAttribute(string methodToQuery)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xB8A1A0", Offset = "0xB8A1A0", VA = "0xB8A1A0", Slot = "9")]
		public virtual bool ConditionMet(object classInstance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xB8A26C", Offset = "0xB8A26C", VA = "0xB8A26C")]
		private bool evaluate(Condition cond, object classInstance)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000011")]
	public class SortOrderAttribute : DTAttribute, IDTFieldParsingAttribute
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0xC009D8", Offset = "0xC009D8", VA = "0xC009D8")]
		public SortOrderAttribute(int sort = 100)
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class AsGroupAttribute : GroupAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x6000027")]
		[Address(RVA = "0xC056A4", Offset = "0xC056A4", VA = "0xC056A4")]
		public AsGroupAttribute([Optional] string pathAndName)
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class TabAttribute : GroupAttribute
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly string TabName;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly string TabBarName;

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xE747B4", Offset = "0xE747B4", VA = "0xE747B4")]
		public TabAttribute(string pathAndName)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xE74844", Offset = "0xE74844", VA = "0xE74844")]
		private static bool split(string pathAndName, out string path, out string tabBar, out string tabname)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000014")]
	public class SectionAttribute : GroupAttribute
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool Fixed;

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xBFB850", Offset = "0xBFB850", VA = "0xBFB850")]
		public SectionAttribute(string name, bool expanded = true, bool fix = false, int sort = 100)
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class NoSectionAttribute : SectionAttribute
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0xBFB7E4", Offset = "0xBFB7E4", VA = "0xBFB7E4")]
		public NoSectionAttribute()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class Hide : DTAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x600002C")]
		[Address(RVA = "0xEBD1C8", Offset = "0xEBD1C8", VA = "0xEBD1C8")]
		public Hide()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class Inline : DTAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0xEBD200", Offset = "0xEBD200", VA = "0xEBD200")]
		public Inline()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class ArrayExAttribute : DTAttribute, IDTFieldParsingAttribute
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Draggable;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool ShowHeader;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool ShowAdd;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool ShowDelete;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool DropTarget;

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xC05684", Offset = "0xC05684", VA = "0xC05684")]
		public ArrayExAttribute()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class FieldActionAttribute : ActionAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x600002F")]
		[Address(RVA = "0xEBB8D4", Offset = "0xEBB8D4", VA = "0xEBB8D4")]
		public FieldActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class GroupActionAttribute : ActionAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x6000030")]
		[Address(RVA = "0xEBD01C", Offset = "0xEBD01C", VA = "0xEBD01C")]
		public GroupActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class FieldConditionAttribute : ConditionalAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0xEBB8DC", Offset = "0xEBB8DC", VA = "0xEBB8DC")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false, ActionEnum action = ActionEnum.Show, [Optional] object actionData, ActionPositionEnum position = ActionPositionEnum.Below)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xEBB930", Offset = "0xEBB930", VA = "0xEBB930")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xEBB940", Offset = "0xEBB940", VA = "0xEBB940")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xEBB964", Offset = "0xEBB964", VA = "0xEBB964")]
		public FieldConditionAttribute(string methodToQuery)
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class GroupConditionAttribute : ConditionalAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x6000035")]
		[Address(RVA = "0xEBD180", Offset = "0xEBD180", VA = "0xEBD180")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xEBD18C", Offset = "0xEBD18C", VA = "0xEBD18C")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xEBD19C", Offset = "0xEBD19C", VA = "0xEBD19C")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xEBD1C0", Offset = "0xEBD1C0", VA = "0xEBD1C0")]
		public GroupConditionAttribute(string methodToQuery)
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class Couple<T1, T2>
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50175C", Offset = "0x50175C")]
		private T1 <First>k__BackingField;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50176C", Offset = "0x50176C")]
		private T2 <Second>k__BackingField;

		[Token(Token = "0x1700000E")]
		public T1 First
		{
			[Token(Token = "0x6000039")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50D89C", Offset = "0x50D89C")]
			get
			{
				return (T1)null;
			}
			[Token(Token = "0x600003A")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50D8AC", Offset = "0x50D8AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public T2 Second
		{
			[Token(Token = "0x600003B")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50D8BC", Offset = "0x50D8BC")]
			get
			{
				return (T2)null;
			}
			[Token(Token = "0x600003C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50D8CC", Offset = "0x50D8CC")]
			set
			{
			}
		}

		[Token(Token = "0x600003D")]
		public Couple(T1 first, T2 second)
		{
		}
	}
	[Token(Token = "0x200001E")]
	public static class DTTween
	{
		[Token(Token = "0x200001F")]
		public enum EasingMethod
		{
			[Token(Token = "0x400003D")]
			Linear,
			[Token(Token = "0x400003E")]
			ExponentialIn,
			[Token(Token = "0x400003F")]
			ExponentialOut,
			[Token(Token = "0x4000040")]
			ExponentialInOut,
			[Token(Token = "0x4000041")]
			ExponentialOutIn,
			[Token(Token = "0x4000042")]
			CircularIn,
			[Token(Token = "0x4000043")]
			CircularOut,
			[Token(Token = "0x4000044")]
			CircularInOut,
			[Token(Token = "0x4000045")]
			CircularOutIn,
			[Token(Token = "0x4000046")]
			QuadraticIn,
			[Token(Token = "0x4000047")]
			QuadraticOut,
			[Token(Token = "0x4000048")]
			QuadraticInOut,
			[Token(Token = "0x4000049")]
			QuadraticOutIn,
			[Token(Token = "0x400004A")]
			SinusIn,
			[Token(Token = "0x400004B")]
			SinusOut,
			[Token(Token = "0x400004C")]
			SinusInOut,
			[Token(Token = "0x400004D")]
			SinusOutIn,
			[Token(Token = "0x400004E")]
			CubicIn,
			[Token(Token = "0x400004F")]
			CubicOut,
			[Token(Token = "0x4000050")]
			CubicInOut,
			[Token(Token = "0x4000051")]
			CubicOutIn,
			[Token(Token = "0x4000052")]
			QuarticIn,
			[Token(Token = "0x4000053")]
			QuarticOut,
			[Token(Token = "0x4000054")]
			QuarticInOut,
			[Token(Token = "0x4000055")]
			QuarticOutIn,
			[Token(Token = "0x4000056")]
			QuinticIn,
			[Token(Token = "0x4000057")]
			QuinticOut,
			[Token(Token = "0x4000058")]
			QuinticInOut,
			[Token(Token = "0x4000059")]
			QuinticOutIn
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xEB8D08", Offset = "0xEB8D08", VA = "0xEB8D08")]
		public static float Ease(EasingMethod method, float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xEB9CAC", Offset = "0xEB9CAC", VA = "0xEB9CAC")]
		public static float Ease(EasingMethod method, float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xEB9C7C", Offset = "0xEB9C7C", VA = "0xEB9C7C")]
		public static float Linear(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xEBAB00", Offset = "0xEBAB00", VA = "0xEBAB00")]
		public static float Linear(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xEB90DC", Offset = "0xEB90DC", VA = "0xEB90DC")]
		public static float ExpoOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xEBA1FC", Offset = "0xEBA1FC", VA = "0xEBA1FC")]
		public static float ExpoOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xEB908C", Offset = "0xEB908C", VA = "0xEB908C")]
		public static float ExpoIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xEBA1B0", Offset = "0xEBA1B0", VA = "0xEBA1B0")]
		public static float ExpoIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xEB9130", Offset = "0xEB9130", VA = "0xEB9130")]
		public static float ExpoInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xEBA244", Offset = "0xEBA244", VA = "0xEBA244")]
		public static float ExpoInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xEB91C8", Offset = "0xEB91C8", VA = "0xEB91C8")]
		public static float ExpoOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xEBA2DC", Offset = "0xEBA2DC", VA = "0xEBA2DC")]
		public static float ExpoOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xEB92D0", Offset = "0xEB92D0", VA = "0xEB92D0")]
		public static float CircOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xEBA3C8", Offset = "0xEBA3C8", VA = "0xEBA3C8")]
		public static float CircOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xEB9278", Offset = "0xEB9278", VA = "0xEB9278")]
		public static float CircIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xEBA374", Offset = "0xEBA374", VA = "0xEBA374")]
		public static float CircIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xEB9328", Offset = "0xEB9328", VA = "0xEB9328")]
		public static float CircInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xEBA41C", Offset = "0xEBA41C", VA = "0xEBA41C")]
		public static float CircInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xEB93B4", Offset = "0xEB93B4", VA = "0xEB93B4")]
		public static float CircOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xEBA4A4", Offset = "0xEBA4A4", VA = "0xEBA4A4")]
		public static float CircOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xEB94AC", Offset = "0xEB94AC", VA = "0xEB94AC")]
		public static float QuadOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xEBA564", Offset = "0xEBA564", VA = "0xEBA564")]
		public static float QuadOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xEB9478", Offset = "0xEB9478", VA = "0xEB9478")]
		public static float QuadIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xEBA550", Offset = "0xEBA550", VA = "0xEBA550")]
		public static float QuadIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xEB94E8", Offset = "0xEB94E8", VA = "0xEB94E8")]
		public static float QuadInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xEBA580", Offset = "0xEBA580", VA = "0xEBA580")]
		public static float QuadInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xEB9574", Offset = "0xEB9574", VA = "0xEB9574")]
		public static float QuadOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xEBA608", Offset = "0xEBA608", VA = "0xEBA608")]
		public static float QuadOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xEB9638", Offset = "0xEB9638", VA = "0xEB9638")]
		public static float SineOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xEBA69C", Offset = "0xEBA69C", VA = "0xEBA69C")]
		public static float SineOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xEB95F4", Offset = "0xEB95F4", VA = "0xEB95F4")]
		public static float SineIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xEBA65C", Offset = "0xEBA65C", VA = "0xEBA65C")]
		public static float SineIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xEB9678", Offset = "0xEB9678", VA = "0xEB9678")]
		public static float SineInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xEBA6D8", Offset = "0xEBA6D8", VA = "0xEBA6D8")]
		public static float SineInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xEB970C", Offset = "0xEB970C", VA = "0xEB970C")]
		public static float SineOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xEBA760", Offset = "0xEBA760", VA = "0xEBA760")]
		public static float SineOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xEB97D8", Offset = "0xEB97D8", VA = "0xEB97D8")]
		public static float CubicOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xEBA7F8", Offset = "0xEBA7F8", VA = "0xEBA7F8")]
		public static float CubicOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xEB97A0", Offset = "0xEB97A0", VA = "0xEB97A0")]
		public static float CubicIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xEBA7E0", Offset = "0xEBA7E0", VA = "0xEBA7E0")]
		public static float CubicIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xEB9820", Offset = "0xEB9820", VA = "0xEB9820")]
		public static float CubicInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xEBA820", Offset = "0xEBA820", VA = "0xEBA820")]
		public static float CubicInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xEB9898", Offset = "0xEB9898", VA = "0xEB9898")]
		public static float CubicOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xEBA874", Offset = "0xEBA874", VA = "0xEBA874")]
		public static float CubicOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xEB9968", Offset = "0xEB9968", VA = "0xEB9968")]
		public static float QuartOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xEBA8F0", Offset = "0xEBA8F0", VA = "0xEBA8F0")]
		public static float QuartOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xEB992C", Offset = "0xEB992C", VA = "0xEB992C")]
		public static float QuartIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xEBA8D4", Offset = "0xEBA8D4", VA = "0xEBA8D4")]
		public static float QuartIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xEB99B0", Offset = "0xEB99B0", VA = "0xEB99B0")]
		public static float QuartInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xEBA918", Offset = "0xEBA918", VA = "0xEBA918")]
		public static float QuartInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xEB9A2C", Offset = "0xEB9A2C", VA = "0xEB9A2C")]
		public static float QuartOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xEBA974", Offset = "0xEBA974", VA = "0xEBA974")]
		public static float QuartOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xEB9B00", Offset = "0xEB9B00", VA = "0xEB9B00")]
		public static float QuintOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xEBA9FC", Offset = "0xEBA9FC", VA = "0xEBA9FC")]
		public static float QuintOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xEB9AC0", Offset = "0xEB9AC0", VA = "0xEB9AC0")]
		public static float QuintIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xEBA9DC", Offset = "0xEBA9DC", VA = "0xEBA9DC")]
		public static float QuintIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xEB9B50", Offset = "0xEB9B50", VA = "0xEB9B50")]
		public static float QuintInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xEBAA2C", Offset = "0xEBAA2C", VA = "0xEBAA2C")]
		public static float QuintInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xEB9BD8", Offset = "0xEB9BD8", VA = "0xEB9BD8")]
		public static float QuintOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xEBAA90", Offset = "0xEBAA90", VA = "0xEBAA90")]
		public static float QuintOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000020")]
	public class DTObjectDump
	{
		[Token(Token = "0x400005A")]
		private const int INDENTSPACES = 5;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string mIndent;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private StringBuilder mSB;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private object mObject;

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xEB7D5C", Offset = "0xEB7D5C", VA = "0xEB7D5C")]
		public DTObjectDump(object o, int indent = 0)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xEB8AEC", Offset = "0xEB8AEC", VA = "0xEB8AEC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xEB7F3C", Offset = "0xEB7F3C", VA = "0xEB7F3C")]
		private void AppendHeader(string name)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xEB7FCC", Offset = "0xEB7FCC", VA = "0xEB7FCC")]
		private void AppendMember(MemberInfo info)
		{
		}
	}
	[Token(Token = "0x2000021")]
	public static class DTUtility
	{
		[Token(Token = "0x400005E")]
		public const string HelpUrlBase = "https://curvyeditor.com/doclink/";

		[Token(Token = "0x17000010")]
		public static bool IsEditorStateChange
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0xEBAB18", Offset = "0xEBAB18", VA = "0xEBAB18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xEBAB10", Offset = "0xEBAB10", VA = "0xEBAB10")]
		public static Material GetDefaultMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xEBAB20", Offset = "0xEBAB20", VA = "0xEBAB20")]
		public static float GetHandleSize(Vector3 position)
		{
			return default(float);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xEBAC8C", Offset = "0xEBAC8C", VA = "0xEBAC8C")]
		public static float GetHandleSize(Vector3 position, Camera camera, Vector3 cameraPosition, Vector3 cameraZDirection, Transform cameraTransform)
		{
			return default(float);
		}

		[Token(Token = "0x6000082")]
		public static void SetPlayerPrefs<T>(string key, T value)
		{
		}

		[Token(Token = "0x6000083")]
		public static T GetPlayerPrefs<T>(string key, T defaultValue)
		{
			return (T)null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xEBADE0", Offset = "0xEBADE0", VA = "0xEBADE0")]
		public static float RandomSign()
		{
			return default(float);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xEBAE0C", Offset = "0xEBAE0C", VA = "0xEBAE0C")]
		public static string GetHelpUrl(object forClass)
		{
			return null;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xEBAE78", Offset = "0xEBAE78", VA = "0xEBAE78")]
		public static string GetHelpUrl(Type classType)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xEBAFB8", Offset = "0xEBAFB8", VA = "0xEBAFB8")]
		public static Vector3 GetCenterPosition(Vector3 fallback, params Vector3[] vectors)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000088")]
		public static T CreateGameObject<T>(Transform parent, string name) where T : MonoBehaviour
		{
			return null;
		}
	}
	[Token(Token = "0x2000022")]
	public static class DTTime
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float _EditorDeltaTime;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float _EditorLastTime;

		[Token(Token = "0x17000011")]
		public static double TimeSinceStartup
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0xEB8BBC", Offset = "0xEB8BBC", VA = "0xEB8BBC")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000012")]
		public static float deltaTime
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0xEB8BD8", Offset = "0xEB8BD8", VA = "0xEB8BD8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xEB8C40", Offset = "0xEB8C40", VA = "0xEB8C40")]
		public static void InitializeEditorTime()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xEB8CA0", Offset = "0xEB8CA0", VA = "0xEB8CA0")]
		public static void UpdateEditorTime()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class TimeMeasure : Ring<long>
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Stopwatch mWatch;

		[Token(Token = "0x17000013")]
		public double LastTicks
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0xE798E0", Offset = "0xE798E0", VA = "0xE798E0")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000014")]
		public double LastMS
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0xE79958", Offset = "0xE79958", VA = "0xE79958")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000015")]
		public double AverageMS
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0xE79978", Offset = "0xE79978", VA = "0xE79978")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000016")]
		public double MinimumMS
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0xE79A60", Offset = "0xE79A60", VA = "0xE79A60")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000017")]
		public double MaximumMS
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0xE79B7C", Offset = "0xE79B7C", VA = "0xE79B7C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000018")]
		public double AverageTicks
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0xE79C98", Offset = "0xE79C98", VA = "0xE79C98")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000019")]
		public double MinimumTicks
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0xE79D70", Offset = "0xE79D70", VA = "0xE79D70")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700001A")]
		public double MaximumTicks
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0xE79E7C", Offset = "0xE79E7C", VA = "0xE79E7C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xE79790", Offset = "0xE79790", VA = "0xE79790")]
		public TimeMeasure(int size)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xE79824", Offset = "0xE79824", VA = "0xE79824")]
		public void Start()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xE79840", Offset = "0xE79840", VA = "0xE79840")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xE798C4", Offset = "0xE798C4", VA = "0xE798C4")]
		public void Pause()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public static class DTMath
	{
		[Token(Token = "0x6000099")]
		[Address(RVA = "0xEB7200", Offset = "0xEB7200", VA = "0xEB7200")]
		public static Vector3 ParallelTransportFrame(Vector3 up, Vector3 tan0, Vector3 tan1)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xEB7360", Offset = "0xEB7360", VA = "0xEB7360")]
		public static Vector3 LeftTan(ref Vector3 tan, ref Vector3 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xEB7378", Offset = "0xEB7378", VA = "0xEB7378")]
		public static Vector3 RightTan(ref Vector3 tan, ref Vector3 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xEB7390", Offset = "0xEB7390", VA = "0xEB7390")]
		public static float Repeat(float t, float length)
		{
			return default(float);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xEB73AC", Offset = "0xEB73AC", VA = "0xEB73AC")]
		public static double FixNaN(double v)
		{
			return default(double);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xEB7428", Offset = "0xEB7428", VA = "0xEB7428")]
		public static float FixNaN(float v)
		{
			return default(float);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xEB7458", Offset = "0xEB7458", VA = "0xEB7458")]
		public static Vector2 FixNaN(Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xEB74AC", Offset = "0xEB74AC", VA = "0xEB74AC")]
		public static Vector3 FixNaN(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xEB659C", Offset = "0xEB659C", VA = "0xEB659C")]
		public static float MapValue(float min, float max, float value, float vMin = -1f, float vMax = 1f)
		{
			return default(float);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xEB751C", Offset = "0xEB751C", VA = "0xEB751C")]
		public static float SnapPrecision(float value, int decimals)
		{
			return default(float);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xEB75A0", Offset = "0xEB75A0", VA = "0xEB75A0")]
		public static Vector2 SnapPrecision(Vector2 value, int decimals)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xEB75F4", Offset = "0xEB75F4", VA = "0xEB75F4")]
		public static Vector3 SnapPrecision(Vector3 value, int decimals)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xEB2D3C", Offset = "0xEB2D3C", VA = "0xEB2D3C")]
		public static float LinePointDistanceSqr(Vector3 l1, Vector3 l2, Vector3 p, out float frag)
		{
			return default(float);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xEB7668", Offset = "0xEB7668", VA = "0xEB7668")]
		public static bool RayLineSegmentIntersection(Vector2 r0, Vector2 dir, Vector2 l1, Vector2 l2, out Vector2 hit, out float frag)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xEB7708", Offset = "0xEB7708", VA = "0xEB7708")]
		public static bool ShortestIntersectionLine(Vector3 line1A, Vector3 line1B, Vector3 line2A, Vector3 line2B, out Vector3 resultSegmentA, out Vector3 resultSegmentB)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xEB79F8", Offset = "0xEB79F8", VA = "0xEB79F8")]
		public static bool LineLineIntersection(Vector3 line1A, Vector3 line1B, Vector3 line2A, Vector3 line2B, out Vector3 hitPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xEB7B24", Offset = "0xEB7B24", VA = "0xEB7B24")]
		public static bool LineLineIntersect(Vector2 line1A, Vector2 line1B, Vector2 line2A, Vector2 line2B, out Vector2 hitPoint, bool segmentOnly = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xEB7C4C", Offset = "0xEB7C4C", VA = "0xEB7C4C")]
		public static bool PointInsideTriangle(Vector3 A, Vector3 B, Vector3 C, Vector3 p, out float ac, out float ab, bool edgesAllowed)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000025")]
	public class UnityEventEx<T0> : UnityEvent<T0>
	{
		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object mCallerList;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private MethodInfo mCallsCount;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mCount;

		[Token(Token = "0x60000AB")]
		public void AddListenerOnce(UnityAction<T0> call)
		{
		}

		[Token(Token = "0x60000AC")]
		public bool HasListeners()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AD")]
		public void CheckForListeners()
		{
		}

		[Token(Token = "0x60000AE")]
		public UnityEventEx()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public static class DTLog
	{
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xEB6C98", Offset = "0xEB6C98", VA = "0xEB6C98")]
		public static void Log(object message)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xEB6CFC", Offset = "0xEB6CFC", VA = "0xEB6CFC")]
		public static void Log(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xEB17CC", Offset = "0xEB17CC", VA = "0xEB17CC")]
		public static void LogError(object message)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xEB6D70", Offset = "0xEB6D70", VA = "0xEB6D70")]
		public static void LogError(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xEB6DE4", Offset = "0xEB6DE4", VA = "0xEB6DE4")]
		public static void LogErrorFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xEB6E58", Offset = "0xEB6E58", VA = "0xEB6E58")]
		public static void LogErrorFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xEB6ED4", Offset = "0xEB6ED4", VA = "0xEB6ED4")]
		public static void LogException(Exception exception)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xEB6F38", Offset = "0xEB6F38", VA = "0xEB6F38")]
		public static void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xEB6FAC", Offset = "0xEB6FAC", VA = "0xEB6FAC")]
		public static void LogFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xEB7020", Offset = "0xEB7020", VA = "0xEB7020")]
		public static void LogFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xEB408C", Offset = "0xEB408C", VA = "0xEB408C")]
		public static void LogWarning(object message)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xEB709C", Offset = "0xEB709C", VA = "0xEB709C")]
		public static void LogWarning(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xEB7110", Offset = "0xEB7110", VA = "0xEB7110")]
		public static void LogWarningFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xEB7184", Offset = "0xEB7184", VA = "0xEB7184")]
		public static void LogWarningFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000027")]
	public struct FloatRegion : IEquatable<FloatRegion>
	{
		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float From;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float To;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool SimpleValue;

		[Token(Token = "0x1700001B")]
		public static FloatRegion ZeroOne
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0xEBB988", Offset = "0xEBB988", VA = "0xEBB988")]
			get
			{
				return default(FloatRegion);
			}
		}

		[Token(Token = "0x1700001C")]
		public bool Positive
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0xEBBA80", Offset = "0xEBBA80", VA = "0xEBBA80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001D")]
		public float Low
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0xEBBA34", Offset = "0xEBBA34", VA = "0xEBBA34")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0xEBBA44", Offset = "0xEBBA44", VA = "0xEBBA44")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public float High
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0xEBBA58", Offset = "0xEBBA58", VA = "0xEBBA58")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0xEBBA68", Offset = "0xEBBA68", VA = "0xEBBA68")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public float Random
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0xEBBA90", Offset = "0xEBBA90", VA = "0xEBBA90")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000020")]
		public float Next
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0xEBBA9C", Offset = "0xEBBA9C", VA = "0xEBBA9C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000021")]
		public float Length
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0xEBBAB8", Offset = "0xEBBAB8", VA = "0xEBBAB8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000022")]
		public float LengthPositive
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0xEBBAC4", Offset = "0xEBBAC4", VA = "0xEBBAC4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xEBB96C", Offset = "0xEBB96C", VA = "0xEBB96C")]
		public FloatRegion(float value)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xEBB97C", Offset = "0xEBB97C", VA = "0xEBB97C")]
		public FloatRegion(float A, float B)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xEBB994", Offset = "0xEBB994", VA = "0xEBB994")]
		public void MakePositive()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xEBB9A8", Offset = "0xEBB9A8", VA = "0xEBB9A8")]
		public void Clamp(float low, float high)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xEBBADC", Offset = "0xEBBADC", VA = "0xEBBADC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xEBBB80", Offset = "0xEBBB80", VA = "0xEBBB80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xEBBBB8", Offset = "0xEBBBB8", VA = "0xEBBBB8", Slot = "4")]
		public bool Equals(FloatRegion other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xEBBC08", Offset = "0xEBBC08", VA = "0xEBBC08", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xEBBCB4", Offset = "0xEBBCB4", VA = "0xEBBCB4")]
		public static FloatRegion operator +(FloatRegion a, FloatRegion b)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xEBBCE8", Offset = "0xEBBCE8", VA = "0xEBBCE8")]
		public static FloatRegion operator -(FloatRegion a, FloatRegion b)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xEBBD1C", Offset = "0xEBBD1C", VA = "0xEBBD1C")]
		public static FloatRegion operator -(FloatRegion a)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xEBBD34", Offset = "0xEBBD34", VA = "0xEBBD34")]
		public static FloatRegion operator *(FloatRegion a, float v)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xEBBD5C", Offset = "0xEBBD5C", VA = "0xEBBD5C")]
		public static FloatRegion operator *(float v, FloatRegion a)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xEBBD84", Offset = "0xEBBD84", VA = "0xEBBD84")]
		public static FloatRegion operator /(FloatRegion a, float v)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xEBBDAC", Offset = "0xEBBDAC", VA = "0xEBBDAC")]
		public static bool operator ==(FloatRegion lhs, FloatRegion rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xEBBE1C", Offset = "0xEBBE1C", VA = "0xEBBE1C")]
		public static bool operator !=(FloatRegion lhs, FloatRegion rhs)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000028")]
	public struct IntRegion : IEquatable<IntRegion>
	{
		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int From;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int To;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool SimpleValue;

		[Token(Token = "0x17000023")]
		public static IntRegion ZeroOne
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0xBF65D8", Offset = "0xBF65D8", VA = "0xBF65D8")]
			get
			{
				return default(IntRegion);
			}
		}

		[Token(Token = "0x17000024")]
		public bool Positive
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0xBF66C8", Offset = "0xBF66C8", VA = "0xBF66C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000025")]
		public int Low
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0xBF667C", Offset = "0xBF667C", VA = "0xBF667C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0xBF668C", Offset = "0xBF668C", VA = "0xBF668C")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public int High
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0xBF66A0", Offset = "0xBF66A0", VA = "0xBF66A0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0xBF66B0", Offset = "0xBF66B0", VA = "0xBF66B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public int Random
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0xBF66D8", Offset = "0xBF66D8", VA = "0xBF66D8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000028")]
		public int Length
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0xBF66E8", Offset = "0xBF66E8", VA = "0xBF66E8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000029")]
		public int LengthPositive
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0xBF66F4", Offset = "0xBF66F4", VA = "0xBF66F4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xBF65BC", Offset = "0xBF65BC", VA = "0xBF65BC")]
		public IntRegion(int value)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xBF65CC", Offset = "0xBF65CC", VA = "0xBF65CC")]
		public IntRegion(int A, int B)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xBF65E4", Offset = "0xBF65E4", VA = "0xBF65E4")]
		public void MakePositive()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xBF65F8", Offset = "0xBF65F8", VA = "0xBF65F8")]
		public void Clamp(int low, int high)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xBF6708", Offset = "0xBF6708", VA = "0xBF6708", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xBF67AC", Offset = "0xBF67AC", VA = "0xBF67AC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xBF67E4", Offset = "0xBF67E4", VA = "0xBF67E4", Slot = "4")]
		public bool Equals(IntRegion other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xBF682C", Offset = "0xBF682C", VA = "0xBF682C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xBF68CC", Offset = "0xBF68CC", VA = "0xBF68CC")]
		public static IntRegion operator +(IntRegion a, IntRegion b)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xBF68E8", Offset = "0xBF68E8", VA = "0xBF68E8")]
		public static IntRegion operator -(IntRegion a, IntRegion b)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xBF6904", Offset = "0xBF6904", VA = "0xBF6904")]
		public static IntRegion operator -(IntRegion a)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xBF691C", Offset = "0xBF691C", VA = "0xBF691C")]
		public static IntRegion operator *(IntRegion a, int v)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xBF6934", Offset = "0xBF6934", VA = "0xBF6934")]
		public static IntRegion operator *(int v, IntRegion a)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xBF6950", Offset = "0xBF6950", VA = "0xBF6950")]
		public static IntRegion operator /(IntRegion a, int v)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xBF6968", Offset = "0xBF6968", VA = "0xBF6968")]
		public static bool operator ==(IntRegion lhs, IntRegion rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xBF69A0", Offset = "0xBF69A0", VA = "0xBF69A0")]
		public static bool operator !=(IntRegion lhs, IntRegion rhs)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000029")]
	public class WeightedRandom<T>
	{
		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mData;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mCurrentPosition;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T mCurrentItem;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50177C", Offset = "0x50177C")]
		private int <Seed>k__BackingField;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50178C", Offset = "0x50178C")]
		private bool <RandomizeSeed>k__BackingField;

		[Token(Token = "0x1700002A")]
		public int Seed
		{
			[Token(Token = "0x60000F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50D8DC", Offset = "0x50D8DC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000F1")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50D8EC", Offset = "0x50D8EC")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public bool RandomizeSeed
		{
			[Token(Token = "0x60000F2")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50D8FC", Offset = "0x50D8FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F3")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50D90C", Offset = "0x50D90C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		private int Capacity
		{
			[Token(Token = "0x60000F4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002D")]
		public int Size
		{
			[Token(Token = "0x60000F5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60000F6")]
		public WeightedRandom(int initCapacity = 0)
		{
		}

		[Token(Token = "0x60000F7")]
		public WeightedRandom(int initCapacity, int seed)
		{
		}

		[Token(Token = "0x60000F8")]
		public void Add(T item, int amount)
		{
		}

		[Token(Token = "0x60000F9")]
		public T Next()
		{
			return (T)null;
		}

		[Token(Token = "0x60000FA")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000FB")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x4FF220", Offset = "0x4FF220")]
	public class Ring<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mList;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50179C", Offset = "0x50179C")]
		private int <Size>k__BackingField;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mIndex;

		[Token(Token = "0x1700002E")]
		public int Size
		{
			[Token(Token = "0x60000FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50D91C", Offset = "0x50D91C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000FD")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50D92C", Offset = "0x50D92C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public T Item
		{
			[Token(Token = "0x6000104")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000105")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public int Count
		{
			[Token(Token = "0x6000109")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000031")]
		public bool IsReadOnly
		{
			[Token(Token = "0x600010A")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000FE")]
		public Ring(int size)
		{
		}

		[Token(Token = "0x60000FF")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x6000100")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000101")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Token(Token = "0x6000102")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x6000103")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000106")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000107")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000108")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x600010B")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x600010C")]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x200002B")]
	public class Pool<T> : IPool
	{
		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mObjects;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5017AC", Offset = "0x5017AC")]
		private string <Identifier>k__BackingField;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5017BC", Offset = "0x5017BC")]
		private PoolSettings <Settings>k__BackingField;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private double mLastTime;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private double mDeltaTime;

		[Token(Token = "0x17000032")]
		public string Identifier
		{
			[Token(Token = "0x600010D")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50D93C", Offset = "0x50D93C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600010E")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50D94C", Offset = "0x50D94C")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public PoolSettings Settings
		{
			[Token(Token = "0x600010F")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50D95C", Offset = "0x50D95C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000110")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50D96C", Offset = "0x50D96C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public Type Type
		{
			[Token(Token = "0x6000111")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public int Count
		{
			[Token(Token = "0x6000116")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000112")]
		public Pool([Optional] PoolSettings settings)
		{
		}

		[Token(Token = "0x6000113")]
		public void Update()
		{
		}

		[Token(Token = "0x6000114")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000115")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000117")]
		public virtual T Pop([Optional] Transform parent)
		{
			return (T)null;
		}

		[Token(Token = "0x6000118")]
		public virtual void Push(T item)
		{
		}

		[Token(Token = "0x6000119")]
		protected virtual void sendBeforePush(T item)
		{
		}

		[Token(Token = "0x600011A")]
		protected virtual void sendAfterPop(T item)
		{
		}

		[Token(Token = "0x600011B")]
		protected virtual void setParent(T item, Transform parent)
		{
		}

		[Token(Token = "0x600011C")]
		protected virtual T create()
		{
			return (T)null;
		}

		[Token(Token = "0x600011D")]
		protected virtual void destroy(T item)
		{
		}

		[Token(Token = "0x600011E")]
		private void log(string msg)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002C")]
	public class PoolSettings
	{
		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool m_Prewarm;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[SerializeField]
		private bool m_AutoCreate;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		[SerializeField]
		private bool m_AutoEnableDisable;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		[Positive]
		private int m_MinItems;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Positive]
		[SerializeField]
		private int m_Threshold;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Positive]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Debug;

		[Token(Token = "0x17000036")]
		public bool Prewarm
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0xBFD77C", Offset = "0xBFD77C", VA = "0xBFD77C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000122")]
			[Address(RVA = "0xBFD690", Offset = "0xBFD690", VA = "0xBFD690")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public bool AutoCreate
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0xBFD784", Offset = "0xBFD784", VA = "0xBFD784")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000124")]
			[Address(RVA = "0xBFD6B0", Offset = "0xBFD6B0", VA = "0xBFD6B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public bool AutoEnableDisable
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0xBFD78C", Offset = "0xBFD78C", VA = "0xBFD78C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000126")]
			[Address(RVA = "0xBFD794", Offset = "0xBFD794", VA = "0xBFD794")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public int MinItems
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0xBFD7B4", Offset = "0xBFD7B4", VA = "0xBFD7B4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000128")]
			[Address(RVA = "0xBFD6D0", Offset = "0xBFD6D0", VA = "0xBFD6D0")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public int Threshold
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0xBFD7BC", Offset = "0xBFD7BC", VA = "0xBFD7BC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600012A")]
			[Address(RVA = "0xBFD708", Offset = "0xBFD708", VA = "0xBFD708")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public float Speed
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0xBFD7C4", Offset = "0xBFD7C4", VA = "0xBFD7C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600012C")]
			[Address(RVA = "0xBFD740", Offset = "0xBFD740", VA = "0xBFD740")]
			set
			{
			}
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xBFD678", Offset = "0xBFD678", VA = "0xBFD678")]
		public PoolSettings()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xBFCEA0", Offset = "0xBFCEA0", VA = "0xBFCEA0")]
		public PoolSettings(PoolSettings src)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xBFC3EC", Offset = "0xBFC3EC", VA = "0xBFC3EC")]
		public void OnValidate()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public interface IPool
	{
		[Token(Token = "0x1700003C")]
		string Identifier
		{
			[Token(Token = "0x600012E")]
			get;
			[Token(Token = "0x600012F")]
			set;
		}

		[Token(Token = "0x1700003D")]
		PoolSettings Settings
		{
			[Token(Token = "0x6000130")]
			get;
		}

		[Token(Token = "0x1700003E")]
		int Count
		{
			[Token(Token = "0x6000134")]
			get;
		}

		[Token(Token = "0x6000131")]
		void Clear();

		[Token(Token = "0x6000132")]
		void Reset();

		[Token(Token = "0x6000133")]
		void Update();
	}
	[Token(Token = "0x200002E")]
	public interface IPoolable
	{
		[Token(Token = "0x6000135")]
		void OnBeforePush();

		[Token(Token = "0x6000136")]
		void OnAfterPop();
	}
	[Token(Token = "0x200002F")]
	public enum DTMessageType
	{
		[Token(Token = "0x4000080")]
		None,
		[Token(Token = "0x4000081")]
		Info,
		[Token(Token = "0x4000082")]
		Warning,
		[Token(Token = "0x4000083")]
		Error
	}
	[Token(Token = "0x2000030")]
	public enum AttributeOptionsFlags
	{
		[Token(Token = "0x4000085")]
		None = 0,
		[Token(Token = "0x4000086")]
		Compact = 1,
		[Token(Token = "0x4000087")]
		Clipboard = 128,
		[Token(Token = "0x4000088")]
		Zero = 256,
		[Token(Token = "0x4000089")]
		One = 512,
		[Token(Token = "0x400008A")]
		Negate = 1024,
		[Token(Token = "0x400008B")]
		Full = 1920,
		[Token(Token = "0x400008C")]
		FullCompact = 1921
	}
	[Token(Token = "0x2000031")]
	public class DTPropertyAttribute : PropertyAttribute
	{
		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Label;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Tooltip;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Color;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AttributeOptionsFlags Options;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int Precision;

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xEB8B0C", Offset = "0xEB8B0C", VA = "0xEB8B0C")]
		public DTPropertyAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class LabelAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000138")]
		[Address(RVA = "0xBF7C68", Offset = "0xBF7C68", VA = "0xBF7C68")]
		public LabelAttribute()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xBF7CBC", Offset = "0xBF7CBC", VA = "0xBF7CBC")]
		public LabelAttribute(string label, string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class ToggleButtonAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0xE79F84", Offset = "0xE79F84", VA = "0xE79F84")]
		public ToggleButtonAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class LayerAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x600013B")]
		[Address(RVA = "0xBF7CC4", Offset = "0xBF7CC4", VA = "0xBF7CC4")]
		public LayerAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class TagAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x600013C")]
		[Address(RVA = "0xE74A20", Offset = "0xE74A20", VA = "0xE74A20")]
		public TagAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class VectorExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x600013D")]
		[Address(RVA = "0xE7D5AC", Offset = "0xE7D5AC", VA = "0xE7D5AC")]
		public VectorExAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class AnimationCurveExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x600013E")]
		[Address(RVA = "0xC05658", Offset = "0xC05658", VA = "0xC05658")]
		public AnimationCurveExAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class MinAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float MinValue;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string MinFieldOrPropertyName;

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xBF8C00", Offset = "0xBF8C00", VA = "0xBF8C00")]
		public MinAttribute(float value, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xBF8C34", Offset = "0xBF8C34", VA = "0xBF8C34")]
		public MinAttribute(string fieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class PositiveAttribute : MinAttribute
	{
		[Token(Token = "0x6000141")]
		[Address(RVA = "0xBFD7CC", Offset = "0xBFD7CC", VA = "0xBFD7CC")]
		public PositiveAttribute()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class MaxAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float MaxValue;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string MaxFieldOrPropertyName;

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xBF7CE8", Offset = "0xBF7CE8", VA = "0xBF7CE8")]
		public MaxAttribute(float value, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xBF7D1C", Offset = "0xBF7D1C", VA = "0xBF7D1C")]
		public MaxAttribute(string fieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class RangeExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float MinValue;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string MinFieldOrPropertyName;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float MaxValue;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string MaxFieldOrPropertyName;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool Slider;

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xBFE978", Offset = "0xBFE978", VA = "0xBFE978")]
		public RangeExAttribute(float minValue, float maxValue, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xBFE9BC", Offset = "0xBFE9BC", VA = "0xBFE9BC")]
		public RangeExAttribute(string minFieldOrProperty, float maxValue, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xBFEA14", Offset = "0xBFEA14", VA = "0xBFEA14")]
		public RangeExAttribute(float minValue, string maxFieldOrProperty, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xBFEA68", Offset = "0xBFEA68", VA = "0xBFEA68")]
		public RangeExAttribute(string minFieldOrProperty, string maxFieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class MinMaxAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string MaxValueField;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float Min;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string MinBoundFieldOrPropertyName;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float Max;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string MaxBoundFieldOrPropertyName;

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xBF8C70", Offset = "0xBF8C70", VA = "0xBF8C70")]
		public MinMaxAttribute(string maxValueField, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class EnumFlagAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000149")]
		[Address(RVA = "0xEBB8CC", Offset = "0xEBB8CC", VA = "0xEBB8CC")]
		public EnumFlagAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class ObjectSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x600014A")]
		[Address(RVA = "0xBFBA50", Offset = "0xBFBA50", VA = "0xBFBA50")]
		public ObjectSelectorAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class PathSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x2000040")]
		public enum DialogMode
		{
			[Token(Token = "0x40000A6")]
			OpenFile,
			[Token(Token = "0x40000A7")]
			OpenFolder,
			[Token(Token = "0x40000A8")]
			CreateFile
		}

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly DialogMode Mode;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string Title;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string Directory;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string Extension;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string DefaultName;

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xBFC2F4", Offset = "0xBFC2F4", VA = "0xBFC2F4")]
		public PathSelectorAttribute(DialogMode mode = DialogMode.OpenFile)
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class EnumSelectionGridAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x600014C")]
		[Address(RVA = "0xEBB8D0", Offset = "0xEBB8D0", VA = "0xEBB8D0")]
		public EnumSelectionGridAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class DTRegionAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool RegionIsOptional;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string RegionOptionsPropertyName;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool UseSlider;

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xEB8B64", Offset = "0xEB8B64", VA = "0xEB8B64")]
		public DTRegionAttribute()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class FloatRegionAttribute : DTRegionAttribute
	{
		[Token(Token = "0x600014E")]
		[Address(RVA = "0xEBBE90", Offset = "0xEBBE90", VA = "0xEBBE90")]
		public FloatRegionAttribute()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class IntRegionAttribute : DTRegionAttribute
	{
		[Token(Token = "0x600014F")]
		[Address(RVA = "0xBF69D8", Offset = "0xBF69D8", VA = "0xBF69D8")]
		public IntRegionAttribute()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public struct RegionOptions<T>
	{
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string LabelFrom;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string LabelTo;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string OptionalTooltip;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DTValueClamping ClampFrom;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DTValueClamping ClampTo;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T FromMin;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T FromMax;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T ToMin;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T ToMax;

		[Token(Token = "0x1700003F")]
		public static RegionOptions<T> Default
		{
			[Token(Token = "0x6000150")]
			get
			{
				return default(RegionOptions<T>);
			}
		}

		[Token(Token = "0x6000151")]
		public static RegionOptions<T> MinMax(T min, T max)
		{
			return default(RegionOptions<T>);
		}
	}
	[Token(Token = "0x2000046")]
	public enum DTValueClamping
	{
		[Token(Token = "0x40000B6")]
		None,
		[Token(Token = "0x40000B7")]
		Min,
		[Token(Token = "0x40000B8")]
		Max,
		[Token(Token = "0x40000B9")]
		Range
	}
	[Token(Token = "0x2000047")]
	public class ThreadPoolWorker<T> : IDisposable
	{
		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly SimplePool<QueuedCallback> queuedCallbackPool;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly SimplePool<LoopState<T>> loopStatePool;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _remainingWorkItems;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ManualResetEvent _done;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private WaitCallback handleWorkItemCallBack;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private WaitCallback handleLoopCallBack;

		[Token(Token = "0x6000152")]
		public ThreadPoolWorker()
		{
		}

		[Token(Token = "0x6000153")]
		public void ParralelFor(Action<T> action, List<T> list)
		{
		}

		[Token(Token = "0x6000154")]
		private bool WaitAll(int millisecondsTimeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x6000155")]
		private void ThrowIfDisposed()
		{
		}

		[Token(Token = "0x6000156")]
		private void DoneWorkItem()
		{
		}

		[Token(Token = "0x6000157")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50D97C", Offset = "0x50D97C")]
		private void <.ctor>b__6_0(object o)
		{
		}

		[Token(Token = "0x6000159")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50D98C", Offset = "0x50D98C")]
		private void <.ctor>b__6_1(object state)
		{
		}
	}
	[Token(Token = "0x2000048")]
	internal class SimplePool<T> where T : new()
	{
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<T> freeItemsBackfield;

		[Token(Token = "0x600015A")]
		public SimplePool(int preCreatedElementsCount)
		{
		}

		[Token(Token = "0x600015B")]
		public T GetItem()
		{
			return (T)null;
		}

		[Token(Token = "0x600015C")]
		public void ReleaseItem(T item)
		{
		}
	}
	[Token(Token = "0x2000049")]
	internal class QueuedCallback
	{
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public WaitCallback Callback;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public object State;

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xBFE970", Offset = "0xBFE970", VA = "0xBFE970")]
		public QueuedCallback()
		{
		}
	}
	[Token(Token = "0x200004A")]
	internal class LoopState<T>
	{
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short StartIndex;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short EndIndex;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<T> Items;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action<T> Action;

		[Token(Token = "0x600015E")]
		public LoopState()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class ThreadPoolWorker : IDisposable
	{
		[Serializable]
		[Token(Token = "0x200004C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FF258", Offset = "0x4FF258")]
		private sealed class <>c__4<T>
		{
			[Token(Token = "0x40000C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__4<T> <>9;

			[Token(Token = "0x40000CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static WaitCallback <>9__4_0;

			[Token(Token = "0x600016E")]
			public <>c__4()
			{
			}

			[Token(Token = "0x600016F")]
			internal void <ParralelFor>b__4_0(object state)
			{
			}
		}

		[Token(Token = "0x200004D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FF268", Offset = "0x4FF268")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40000CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action act;

			[Token(Token = "0x6000170")]
			[Address(RVA = "0xE792BC", Offset = "0xE792BC", VA = "0xE792BC")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000171")]
			[Address(RVA = "0xE7F09C", Offset = "0xE7F09C", VA = "0xE7F09C")]
			internal void <QueueWorkItem>b__0(object x)
			{
			}
		}

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _remainingWorkItems;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ManualResetEvent _done;

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xE78F3C", Offset = "0xE78F3C", VA = "0xE78F3C")]
		public void QueueWorkItem(WaitCallback callback)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xE78FDC", Offset = "0xE78FDC", VA = "0xE78FDC")]
		public void QueueWorkItem(Action act)
		{
		}

		[Token(Token = "0x6000161")]
		public void ParralelFor<T>(Action<T> action, List<T> list)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xE79104", Offset = "0xE79104", VA = "0xE79104")]
		private void QueueWorkItem(QueuedCallback callback)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xE78F44", Offset = "0xE78F44", VA = "0xE78F44")]
		public void QueueWorkItem(WaitCallback callback, object state)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xE78FE4", Offset = "0xE78FE4", VA = "0xE78FE4")]
		public void QueueWorkItem(Action act, object state)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xE792C4", Offset = "0xE792C4", VA = "0xE792C4")]
		public bool WaitAll()
		{
			return default(bool);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xE7941C", Offset = "0xE7941C", VA = "0xE7941C")]
		public bool WaitAll(TimeSpan timeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xE792D0", Offset = "0xE792D0", VA = "0xE792D0")]
		public bool WaitAll(int millisecondsTimeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xE79564", Offset = "0xE79564", VA = "0xE79564")]
		private void HandleWorkItem(object state)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xE7947C", Offset = "0xE7947C", VA = "0xE7947C")]
		private void DoneWorkItem()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xE79248", Offset = "0xE79248", VA = "0xE79248")]
		private void ThrowIfDisposed()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xE79650", Offset = "0xE79650", VA = "0xE79650", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xE79714", Offset = "0xE79714", VA = "0xE79714")]
		public ThreadPoolWorker()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4FF278", Offset = "0x4FF278")]
	public class ComponentPool : MonoBehaviour, IPool, ISerializationCallbackReceiver
	{
		[Token(Token = "0x200004F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FF2B0", Offset = "0x4FF2B0")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x40000D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string typeName;

			[Token(Token = "0x600018D")]
			[Address(RVA = "0xE7E184", Offset = "0xE7E184", VA = "0xE7E184")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x600018E")]
			[Address(RVA = "0xE7E18C", Offset = "0xE7E18C", VA = "0xE7E18C")]
			internal bool <OnAfterDeserialize>b__0(Type t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		private string m_Identifier;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Inline]
		private PoolSettings m_Settings;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PoolManager mManager;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<UnityEngine.Component> mObjects;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private double mLastTime;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private double mDeltaTime;

		[Token(Token = "0x17000040")]
		public PoolSettings Settings
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0xB882EC", Offset = "0xB882EC", VA = "0xB882EC", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000173")]
			[Address(RVA = "0xB882F4", Offset = "0xB882F4", VA = "0xB882F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public PoolManager Manager
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0xB88344", Offset = "0xB88344", VA = "0xB88344")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public string Identifier
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0xB883F8", Offset = "0xB883F8", VA = "0xB883F8", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0xB88400", Offset = "0xB88400", VA = "0xB88400", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public Type Type
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0xB88454", Offset = "0xB88454", VA = "0xB88454")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public int Count
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0xB88558", Offset = "0xB88558", VA = "0xB88558", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xB885A4", Offset = "0xB885A4", VA = "0xB885A4")]
		public void Initialize(Type type, PoolSettings settings)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xB887D4", Offset = "0xB887D4", VA = "0xB887D4")]
		private void Start()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xB887F8", Offset = "0xB887F8", VA = "0xB887F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xB888B4", Offset = "0xB888B4", VA = "0xB888B4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xB888B8", Offset = "0xB888B8", VA = "0xB888B8", Slot = "9")]
		public void Update()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xB88670", Offset = "0xB88670", VA = "0xB88670", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xB88E10", Offset = "0xB88E10", VA = "0xB88E10")]
		public void OnSceneLoaded(Scene scn, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xB88F24", Offset = "0xB88F24", VA = "0xB88F24", Slot = "7")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xB8900C", Offset = "0xB8900C", VA = "0xB8900C")]
		public void Push(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xB8932C", Offset = "0xB8932C", VA = "0xB8932C")]
		public UnityEngine.Component Pop([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000183")]
		public T Pop<T>(Transform parent) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xB88CA4", Offset = "0xB88CA4", VA = "0xB88CA4")]
		private UnityEngine.Component create()
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xB88BEC", Offset = "0xB88BEC", VA = "0xB88BEC")]
		private void destroy(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xB89704", Offset = "0xB89704", VA = "0xB89704")]
		private void setParent(UnityEngine.Component item, Transform parent)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xB89538", Offset = "0xB89538", VA = "0xB89538")]
		private void sendAfterPop(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xB89164", Offset = "0xB89164", VA = "0xB89164")]
		private void sendBeforePush(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xB88B0C", Offset = "0xB88B0C", VA = "0xB88B0C")]
		private void log(string msg)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xB897B0", Offset = "0xB897B0", VA = "0xB897B0", Slot = "11")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xB897B4", Offset = "0xB897B4", VA = "0xB897B4", Slot = "12")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xB89A64", Offset = "0xB89A64", VA = "0xB89A64")]
		public ComponentPool()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class DTSingleton<T> : MonoBehaviour, IDTSingleton where T : MonoBehaviour, IDTSingleton
	{
		[Serializable]
		[Token(Token = "0x2000051")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FF2C0", Offset = "0x4FF2C0")]
		private sealed class <>c
		{
			[Token(Token = "0x40000D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<UnityEngine.Object, bool> <>9__7_0;

			[Token(Token = "0x6000198")]
			public <>c()
			{
			}

			[Token(Token = "0x6000199")]
			internal bool <get_Instance>b__7_0(UnityEngine.Object o)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object _lock;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool applicationIsQuitting;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool isDuplicateInstance;

		[Token(Token = "0x17000045")]
		public static bool HasInstance
		{
			[Token(Token = "0x600018F")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		public static T Instance
		{
			[Token(Token = "0x6000190")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000191")]
		public virtual void Awake()
		{
		}

		[Token(Token = "0x6000192")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000193")]
		public virtual void MergeDoubleLoaded(IDTSingleton newInstance)
		{
		}

		[Token(Token = "0x6000194")]
		private void DestroySelf()
		{
		}

		[Token(Token = "0x6000195")]
		public DTSingleton()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public interface IDTSingleton
	{
		[Token(Token = "0x600019A")]
		void MergeDoubleLoaded(IDTSingleton newInstance);
	}
	[Token(Token = "0x2000053")]
	public abstract class DTVersionedMonoBehaviour : MonoBehaviour
	{
		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		private string m_Version;

		[Token(Token = "0x17000047")]
		public string Version
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0xEBB068", Offset = "0xEBB068", VA = "0xEBB068")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019C")]
			[Address(RVA = "0xEBB070", Offset = "0xEBB070", VA = "0xEBB070")]
			protected set
			{
			}
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xEBB078", Offset = "0xEBB078", VA = "0xEBB078")]
		public void Destroy()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xEBB128", Offset = "0xEBB128", VA = "0xEBB128")]
		protected DTVersionedMonoBehaviour()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4FF2D0", Offset = "0x4FF2D0")]
	public abstract class DuplicateEditorMesh : MonoBehaviour
	{
		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MeshFilter mFilter;

		[Token(Token = "0x17000048")]
		public MeshFilter Filter
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0xEBB358", Offset = "0xEBB358", VA = "0xEBB358")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xEBB40C", Offset = "0xEBB40C", VA = "0xEBB40C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xEBB698", Offset = "0xEBB698", VA = "0xEBB698")]
		protected DuplicateEditorMesh()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4FF340", Offset = "0x4FF340")]
	public class InspectorNote : MonoBehaviour
	{
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x50194C", Offset = "0x50194C")]
		private string m_Note;

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xBF65B4", Offset = "0xBF65B4", VA = "0xBF65B4")]
		public InspectorNote()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4FF378", Offset = "0x4FF378")]
	public class PoolManager : MonoBehaviour
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x50198C", Offset = "0x50198C")]
		[SerializeField]
		private bool m_AutoCreatePools;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "AsGroupAttribute", RVA = "0x5019E4", Offset = "0x5019E4")]
		[SerializeField]
		private PoolSettings m_DefaultSettings;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x501A28", Offset = "0x501A28")]
		private bool <IsInitialized>k__BackingField;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<string, IPool> Pools;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Dictionary<Type, IPool> TypePools;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IPool[] mPools;

		[Token(Token = "0x17000049")]
		public bool AutoCreatePools
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0xBFC370", Offset = "0xBFC370", VA = "0xBFC370")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0xBFC378", Offset = "0xBFC378", VA = "0xBFC378")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public PoolSettings DefaultSettings
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0xBFC398", Offset = "0xBFC398", VA = "0xBFC398")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0xBFC3A0", Offset = "0xBFC3A0", VA = "0xBFC3A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public bool IsInitialized
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0xBFC464", Offset = "0xBFC464", VA = "0xBFC464")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50D99C", Offset = "0x50D99C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0xBFC46C", Offset = "0xBFC46C", VA = "0xBFC46C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50D9AC", Offset = "0x50D9AC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public int Count
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0xBFC478", Offset = "0xBFC478", VA = "0xBFC478")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xBFC500", Offset = "0xBFC500", VA = "0xBFC500")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xBFC508", Offset = "0xBFC508", VA = "0xBFC508")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xBFC6C8", Offset = "0xBFC6C8", VA = "0xBFC6C8")]
		private void Initialize()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xBFCB54", Offset = "0xBFCB54", VA = "0xBFCB54")]
		public string GetUniqueIdentifier(string ident)
		{
			return null;
		}

		[Token(Token = "0x60001AE")]
		public Pool<T> GetTypePool<T>()
		{
			return null;
		}

		[Token(Token = "0x60001AF")]
		public ComponentPool GetComponentPool<T>() where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xBFCC08", Offset = "0xBFCC08", VA = "0xBFCC08")]
		public PrefabPool GetPrefabPool(string identifier, params GameObject[] prefabs)
		{
			return null;
		}

		[Token(Token = "0x60001B1")]
		public Pool<T> CreateTypePool<T>([Optional] PoolSettings settings)
		{
			return null;
		}

		[Token(Token = "0x60001B2")]
		public ComponentPool CreateComponentPool<T>([Optional] PoolSettings settings) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xBFCD0C", Offset = "0xBFCD0C", VA = "0xBFCD0C")]
		public PrefabPool CreatePrefabPool(string name, [Optional] PoolSettings settings, params GameObject[] prefabs)
		{
			return null;
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xBFD0BC", Offset = "0xBFD0BC", VA = "0xBFD0BC")]
		public List<IPool> FindPools(string identifierStartsWith)
		{
			return null;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xBFD288", Offset = "0xBFD288", VA = "0xBFD288")]
		public void DeletePools(string startsWith)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xBFD340", Offset = "0xBFD340", VA = "0xBFD340")]
		public void DeletePool(IPool pool)
		{
		}

		[Token(Token = "0x60001B7")]
		public void DeletePool<T>()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xBFD528", Offset = "0xBFD528", VA = "0xBFD528")]
		public PoolManager()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4FF3D4", Offset = "0x4FF3D4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4FF3D4", Offset = "0x4FF3D4")]
	public class PrefabPool : MonoBehaviour, IPool
	{
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x501A38", Offset = "0x501A38")]
		[SerializeField]
		private string m_Identifier;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> m_Prefabs;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Inline]
		private PoolSettings m_Settings;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PoolManager mManager;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<GameObject> mObjects;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private double mLastTime;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private double mDeltaTime;

		[Token(Token = "0x1700004D")]
		public string Identifier
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xBFD828", Offset = "0xBFD828", VA = "0xBFD828", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0xBFD830", Offset = "0xBFD830", VA = "0xBFD830", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public List<GameObject> Prefabs
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0xBFD964", Offset = "0xBFD964", VA = "0xBFD964")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0xBFD96C", Offset = "0xBFD96C", VA = "0xBFD96C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public PoolSettings Settings
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0xBFD984", Offset = "0xBFD984", VA = "0xBFD984", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0xBFD98C", Offset = "0xBFD98C", VA = "0xBFD98C")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public PoolManager Manager
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0xBFD8B0", Offset = "0xBFD8B0", VA = "0xBFD8B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public int Count
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0xBFDDB8", Offset = "0xBFDDB8", VA = "0xBFDDB8", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xBFD9D8", Offset = "0xBFD9D8", VA = "0xBFD9D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xBFD9DC", Offset = "0xBFD9DC", VA = "0xBFD9DC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xBFCF8C", Offset = "0xBFCF8C", VA = "0xBFCF8C")]
		public void Initialize(string ident, PoolSettings settings, params GameObject[] prefabs)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xBFDB64", Offset = "0xBFDB64", VA = "0xBFDB64", Slot = "9")]
		public void Update()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xBFDA00", Offset = "0xBFDA00", VA = "0xBFDA00", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xBFE124", Offset = "0xBFE124", VA = "0xBFE124", Slot = "7")]
		public void Clear()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xBFE20C", Offset = "0xBFE20C", VA = "0xBFE20C")]
		public GameObject Pop([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xBFE468", Offset = "0xBFE468", VA = "0xBFE468", Slot = "11")]
		public virtual void Push(GameObject item)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xBFDF48", Offset = "0xBFDF48", VA = "0xBFDF48")]
		private GameObject create()
		{
			return null;
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xBFDEE4", Offset = "0xBFDEE4", VA = "0xBFDEE4")]
		private void destroy(GameObject go)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xBFDE04", Offset = "0xBFDE04", VA = "0xBFDE04")]
		private void log(string msg)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xBFE668", Offset = "0xBFE668", VA = "0xBFE668")]
		private void setParent(Transform item, Transform parent)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xBFE40C", Offset = "0xBFE40C", VA = "0xBFE40C")]
		private void sendAfterPop(GameObject item)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xBFE60C", Offset = "0xBFE60C", VA = "0xBFE60C")]
		private void sendBeforePush(GameObject item)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xBFE708", Offset = "0xBFE708", VA = "0xBFE708")]
		public PrefabPool()
		{
		}
	}
}
namespace FluffyUnderware.DevTools.Extensions
{
	[Token(Token = "0x2000058")]
	public static class ObjectExt
	{
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xBFB978", Offset = "0xBFB978", VA = "0xBFB978")]
		public static void Destroy(this UnityEngine.Object c)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xBFB9DC", Offset = "0xBFB9DC", VA = "0xBFB9DC")]
		public static string ToDumpString(this object o)
		{
			return null;
		}
	}
	[Token(Token = "0x2000059")]
	public static class Vector2Ext
	{
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xE7D208", Offset = "0xE7D208", VA = "0xE7D208")]
		public static Vector2 Snap(this Vector2 v, float snapX, float snapY = -1f)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xE7D260", Offset = "0xE7D260", VA = "0xE7D260")]
		public static float AngleSigned(this Vector2 a, Vector2 b)
		{
			return default(float);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xE7D3B4", Offset = "0xE7D3B4", VA = "0xE7D3B4")]
		public static Vector2 LeftNormal(this Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xE7D3C8", Offset = "0xE7D3C8", VA = "0xE7D3C8")]
		public static Vector2 RightNormal(this Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xE7D3D8", Offset = "0xE7D3D8", VA = "0xE7D3D8")]
		public static Vector2 Rotate(this Vector2 v, float degree)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xE7D438", Offset = "0xE7D438", VA = "0xE7D438")]
		public static Vector2 ToVector3(this Vector2 v)
		{
			return default(Vector2);
		}
	}
	[Token(Token = "0x200005A")]
	public static class Vector3Ext
	{
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xE7D43C", Offset = "0xE7D43C", VA = "0xE7D43C")]
		public static float AngleSigned(this Vector3 a, Vector3 b, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xE7D4E0", Offset = "0xE7D4E0", VA = "0xE7D4E0")]
		public static Vector3 RotateAround(this Vector3 point, Vector3 origin, Quaternion rotation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xE7D540", Offset = "0xE7D540", VA = "0xE7D540")]
		public static Vector2 ToVector2(this Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xE7D544", Offset = "0xE7D544", VA = "0xE7D544")]
		public static bool Approximately(this Vector3 v1, Vector3 v2)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xE7D578", Offset = "0xE7D578", VA = "0xE7D578")]
		public static bool NotApproximately(this Vector3 v1, Vector3 v2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200005B")]
	public static class QuaternionExt
	{
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xBFE7B8", Offset = "0xBFE7B8", VA = "0xBFE7B8")]
		public static bool SameOrientation(this Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xBFE894", Offset = "0xBFE894", VA = "0xBFE894")]
		public static bool DifferentOrientation(this Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200005C")]
	public static class CameraExt
	{
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Plane[] camPlanes;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Vector3 camPos;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static Vector3 camForward;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static float fov;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static float screenW;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static float screenH;

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xB8724C", Offset = "0xB8724C", VA = "0xB8724C")]
		public static bool BoundsInView(this Camera c, Bounds bounds)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xB87540", Offset = "0xB87540", VA = "0xB87540")]
		public static bool BoundsPartiallyInView(this Camera c, Bounds bounds)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200005D")]
	public static class GameObjectExt
	{
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xEBC2CC", Offset = "0xEBC2CC", VA = "0xEBC2CC")]
		public static GameObject DuplicateGameObject(this GameObject source, Transform newParent, bool keepPrefabReference = false)
		{
			return null;
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xEBC3D0", Offset = "0xEBC3D0", VA = "0xEBC3D0")]
		public static void StripComponents(this GameObject go, params Type[] toKeep)
		{
		}
	}
	[Token(Token = "0x200005E")]
	public static class ComponentExt
	{
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xB87EFC", Offset = "0xB87EFC", VA = "0xB87EFC")]
		public static void StripComponents(this UnityEngine.Component c, params Type[] toKeep)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xB87FE8", Offset = "0xB87FE8", VA = "0xB87FE8")]
		public static GameObject AddChildGameObject(this UnityEngine.Component c, string name)
		{
			return null;
		}

		[Token(Token = "0x60001E6")]
		public static T AddChildGameObject<T>(this UnityEngine.Component c, string name) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x60001E7")]
		public static T DuplicateGameObject<T>(this UnityEngine.Component source, Transform newParent, bool keepPrefabConnection = false) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xB88090", Offset = "0xB88090", VA = "0xB88090")]
		public static UnityEngine.Component DuplicateGameObject(this UnityEngine.Component source, Transform newParent, bool keepPrefabConnection = false)
		{
			return null;
		}
	}
	[Token(Token = "0x200005F")]
	public static class ColorExt
	{
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xB878F8", Offset = "0xB878F8", VA = "0xB878F8")]
		public static string ToHtml(this Color c)
		{
			return null;
		}
	}
	[Token(Token = "0x2000060")]
	public static class EnumExt
	{
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xEBB6A0", Offset = "0xEBB6A0", VA = "0xEBB6A0")]
		public static bool HasFlag(this Enum variable, params Enum[] flags)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EB")]
		public static bool HasFlag<T>(this T value, T flag) where T : struct
		{
			return default(bool);
		}

		[Token(Token = "0x60001EC")]
		public static T Set<T>(this Enum value, T append)
		{
			return (T)null;
		}

		[Token(Token = "0x60001ED")]
		public static T Set<T>(this Enum value, T append, bool OnOff)
		{
			return (T)null;
		}
	}
	[Token(Token = "0x2000061")]
	public static class RectExt
	{
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xBFEAC8", Offset = "0xBFEAC8", VA = "0xBFEAC8")]
		public static Rect Set(this Rect rect, Vector2 pos, Vector2 size)
		{
			return default(Rect);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xBFEB24", Offset = "0xBFEB24", VA = "0xBFEB24")]
		public static Rect SetBetween(this Rect rect, Vector2 pos, Vector2 pos2)
		{
			return default(Rect);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xBFEB80", Offset = "0xBFEB80", VA = "0xBFEB80")]
		public static Rect SetPosition(this Rect rect, Vector2 pos)
		{
			return default(Rect);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xBFEBEC", Offset = "0xBFEBEC", VA = "0xBFEBEC")]
		public static Rect SetPosition(this Rect rect, float x, float y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xBFEC58", Offset = "0xBFEC58", VA = "0xBFEC58")]
		public static Vector2 GetSize(this Rect rect)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xBFECA4", Offset = "0xBFECA4", VA = "0xBFECA4")]
		public static Rect SetSize(this Rect rect, Vector2 size)
		{
			return default(Rect);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xBFED10", Offset = "0xBFED10", VA = "0xBFED10")]
		public static Rect ScaleBy(this Rect rect, int pixel)
		{
			return default(Rect);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xBFED18", Offset = "0xBFED18", VA = "0xBFED18")]
		public static Rect ScaleBy(this Rect rect, int x, int y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xBFEDF0", Offset = "0xBFEDF0", VA = "0xBFEDF0")]
		public static Rect ShiftBy(this Rect rect, int x, int y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xBFEE80", Offset = "0xBFEE80", VA = "0xBFEE80")]
		public static Rect Include(this Rect rect, Rect other)
		{
			return default(Rect);
		}
	}
	[Token(Token = "0x2000062")]
	public static class StringExt
	{
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xE740FC", Offset = "0xE740FC", VA = "0xE740FC")]
		public static Color ColorFromHtml(this string hexString)
		{
			return default(Color);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xE743E8", Offset = "0xE743E8", VA = "0xE743E8")]
		public static string TrimStart(this string s, string trim, StringComparison compare = StringComparison.CurrentCultureIgnoreCase)
		{
			return null;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xE7443C", Offset = "0xE7443C", VA = "0xE7443C")]
		public static string TrimEnd(this string s, string trim, StringComparison compare = StringComparison.CurrentCultureIgnoreCase)
		{
			return null;
		}
	}
	[Token(Token = "0x2000063")]
	public static class IEnumerableExt
	{
		[Token(Token = "0x60001FB")]
		public static void ForEach<T>(this IEnumerable<T> ie, Action<T> action)
		{
		}
	}
	[Token(Token = "0x2000064")]
	public static class ArrayExt
	{
		[Token(Token = "0x60001FC")]
		public static T[] SubArray<T>(this T[] data, int index, int length)
		{
			return null;
		}

		[Token(Token = "0x60001FD")]
		public static T[] RemoveAt<T>(this T[] source, int index)
		{
			return null;
		}

		[Token(Token = "0x60001FE")]
		public static T[] InsertAt<T>(this T[] source, int index)
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		public static T[] Swap<T>(this T[] source, int index, int with)
		{
			return null;
		}

		[Token(Token = "0x6000200")]
		public static T[] Add<T>(this T[] source, T item)
		{
			return null;
		}

		[Token(Token = "0x6000201")]
		public static T[] AddRange<T>(this T[] source, T[] items)
		{
			return null;
		}

		[Token(Token = "0x6000202")]
		public static T[] RemoveDuplicates<T>(this T[] source)
		{
			return null;
		}

		[Token(Token = "0x6000203")]
		public static int IndexOf<T>(this T[] source, T item)
		{
			return default(int);
		}

		[Token(Token = "0x6000204")]
		public static T[] Remove<T>(this T[] source, T item)
		{
			return null;
		}
	}
	[Token(Token = "0x2000065")]
	public static class MeshFilterExt
	{
		[Token(Token = "0x6000205")]
		[Address(RVA = "0xBF7D58", Offset = "0xBF7D58", VA = "0xBF7D58")]
		public static Mesh PrepareNewShared(this MeshFilter m, string name = "Mesh")
		{
			return null;
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xBF7EE4", Offset = "0xBF7EE4", VA = "0xBF7EE4")]
		public static void CalculateTangents(this MeshFilter m)
		{
		}
	}
	[Token(Token = "0x2000066")]
	public static class TypeExt
	{
		[Token(Token = "0x6000207")]
		[Address(RVA = "0xE79F8C", Offset = "0xE79F8C", VA = "0xE79F8C")]
		public static Type[] GetLoadedTypes()
		{
			return null;
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xE7A4D0", Offset = "0xE7A4D0", VA = "0xE7A4D0")]
		public static IEnumerable<Assembly> GetLoadedAssemblies()
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		public static Dictionary<U, Type> GetAllTypesWithAttribute<U>(this Type type)
		{
			return null;
		}

		[Token(Token = "0x600020A")]
		public static List<FieldInfo> GetFieldsWithAttribute<T>(this Type type, bool includeInherited = false, bool includePrivate = false) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x600020B")]
		public static T GetCustomAttribute<T>(this Type type) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xE7A4F4", Offset = "0xE7A4F4", VA = "0xE7A4F4")]
		public static MethodInfo MethodByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xE7A6A4", Offset = "0xE7A6A4", VA = "0xE7A6A4")]
		public static FieldInfo FieldByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xE7A86C", Offset = "0xE7A86C", VA = "0xE7A86C")]
		public static PropertyInfo PropertyByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xE7AA1C", Offset = "0xE7AA1C", VA = "0xE7AA1C")]
		public static FieldInfo[] GetAllFields(this Type type, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xE7ABD4", Offset = "0xE7ABD4", VA = "0xE7ABD4")]
		public static PropertyInfo[] GetAllProperties(this Type type, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xE7AD8C", Offset = "0xE7AD8C", VA = "0xE7AD8C")]
		public static bool IsFrameworkType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xE7AEAC", Offset = "0xE7AEAC", VA = "0xE7AEAC")]
		public static bool IsArrayOrList(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xE7AF9C", Offset = "0xE7AF9C", VA = "0xE7AF9C")]
		public static Type GetEnumerableType(this Type t)
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xE7B058", Offset = "0xE7B058", VA = "0xE7B058")]
		private static Type FindIEnumerable(Type seqType)
		{
			return null;
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xE7A528", Offset = "0xE7A528", VA = "0xE7A528")]
		private static MethodInfo GetMethodIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xE7A6E0", Offset = "0xE7A6E0", VA = "0xE7A6E0")]
		private static FieldInfo GetFieldIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xE7A8A0", Offset = "0xE7A8A0", VA = "0xE7A8A0")]
		private static PropertyInfo GetPropertyIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xE7B4C4", Offset = "0xE7B4C4", VA = "0xE7B4C4")]
		public static bool Matches(this Type type, params Type[] types)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000067")]
	public static class FieldInfoExt
	{
		[Token(Token = "0x6000219")]
		public static T GetCustomAttribute<T>(this FieldInfo field) where T : Attribute
		{
			return null;
		}
	}
}
namespace FluffyUnderware.Curvy
{
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4FF558", Offset = "0x4FF558")]
	public class MetaCGOptions : CurvyMetadataBase
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Positive]
		[SerializeField]
		private int m_MaterialID;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_HardEdge;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Positive]
		private float m_MaxStepDistance;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x501BA8", Offset = "0x501BA8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x501BA8", Offset = "0x501BA8")]
		private bool m_UVEdge;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[Positive]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x501CA4", Offset = "0x501CA4")]
		[SerializeField]
		private bool m_ExplicitU;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Positive]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x501D64", Offset = "0x501D64")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x501D64", Offset = "0x501D64")]
		private float m_FirstU;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Positive]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x501E4C", Offset = "0x501E4C")]
		[SerializeField]
		private float m_SecondU;

		[Token(Token = "0x17000052")]
		public int MaterialID
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0xBF85BC", Offset = "0xBF85BC", VA = "0xBF85BC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600021B")]
			[Address(RVA = "0xBF85C4", Offset = "0xBF85C4", VA = "0xBF85C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public bool HardEdge
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0xBF8610", Offset = "0xBF8610", VA = "0xBF8610")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600021D")]
			[Address(RVA = "0xBF8618", Offset = "0xBF8618", VA = "0xBF8618")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public bool UVEdge
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0xBF8640", Offset = "0xBF8640", VA = "0xBF8640")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600021F")]
			[Address(RVA = "0xBF8648", Offset = "0xBF8648", VA = "0xBF8648")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public bool ExplicitU
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0xBF8670", Offset = "0xBF8670", VA = "0xBF8670")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0xBF8678", Offset = "0xBF8678", VA = "0xBF8678")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public float FirstU
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0xBF86A0", Offset = "0xBF86A0", VA = "0xBF86A0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0xBF86A8", Offset = "0xBF86A8", VA = "0xBF86A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public float SecondU
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0xBF86C4", Offset = "0xBF86C4", VA = "0xBF86C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000225")]
			[Address(RVA = "0xBF86CC", Offset = "0xBF86CC", VA = "0xBF86CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public float MaxStepDistance
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0xBF86E8", Offset = "0xBF86E8", VA = "0xBF86E8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000227")]
			[Address(RVA = "0xBF86F0", Offset = "0xBF86F0", VA = "0xBF86F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public bool HasDifferentMaterial
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0xBF8740", Offset = "0xBF8740", VA = "0xBF8740")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005A")]
		private bool showUVEdge
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0xBF8800", Offset = "0xBF8800", VA = "0xBF8800")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		private bool showExplicitU
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0xBF894C", Offset = "0xBF894C", VA = "0xBF894C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		private bool showFirstU
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0xBF89DC", Offset = "0xBF89DC", VA = "0xBF89DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		private bool showSecondU
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0xBF8A78", Offset = "0xBF8A78", VA = "0xBF8A78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xBF8A8C", Offset = "0xBF8A8C", VA = "0xBF8A8C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xBF8B44", Offset = "0xBF8B44", VA = "0xBF8B44")]
		public float GetDefinedFirstU(float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xBF8B90", Offset = "0xBF8B90", VA = "0xBF8B90")]
		public float GetDefinedSecondU(float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xBF8BF8", Offset = "0xBF8BF8", VA = "0xBF8BF8")]
		public MetaCGOptions()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public enum OrientationModeEnum
	{
		[Token(Token = "0x40000F7")]
		None,
		[Token(Token = "0x40000F8")]
		Orientation,
		[Token(Token = "0x40000F9")]
		Tangent
	}
	[Token(Token = "0x200006A")]
	public enum OrientationAxisEnum
	{
		[Token(Token = "0x40000FB")]
		Up,
		[Token(Token = "0x40000FC")]
		Down,
		[Token(Token = "0x40000FD")]
		Forward,
		[Token(Token = "0x40000FE")]
		Backward,
		[Token(Token = "0x40000FF")]
		Left,
		[Token(Token = "0x4000100")]
		Right
	}
	[Token(Token = "0x200006B")]
	public enum ConnectionHeadingEnum
	{
		[Token(Token = "0x4000102")]
		Minus = -1,
		[Token(Token = "0x4000103")]
		Sharp,
		[Token(Token = "0x4000104")]
		Plus,
		[Token(Token = "0x4000105")]
		Auto
	}
	[Token(Token = "0x200006C")]
	public static class ConnectionHeadingEnumMethods
	{
		[Token(Token = "0x6000231")]
		[Address(RVA = "0xB8AE94", Offset = "0xB8AE94", VA = "0xB8AE94")]
		public static ConnectionHeadingEnum ResolveAuto(this ConnectionHeadingEnum heading, CurvySplineSegment followUp)
		{
			return default(ConnectionHeadingEnum);
		}
	}
	[Token(Token = "0x200006D")]
	public enum CurvyUpdateMethod
	{
		[Token(Token = "0x4000107")]
		Update,
		[Token(Token = "0x4000108")]
		LateUpdate,
		[Token(Token = "0x4000109")]
		FixedUpdate
	}
	[Token(Token = "0x200006E")]
	public enum CurvyRepeatingOrderEnum
	{
		[Token(Token = "0x400010B")]
		Random,
		[Token(Token = "0x400010C")]
		Row
	}
	[Token(Token = "0x200006F")]
	public enum CurvyPlane
	{
		[Token(Token = "0x400010E")]
		XY,
		[Token(Token = "0x400010F")]
		XZ,
		[Token(Token = "0x4000110")]
		YZ
	}
	[Token(Token = "0x2000070")]
	public enum CurvyPositionMode
	{
		[Token(Token = "0x4000112")]
		Relative,
		[Token(Token = "0x4000113")]
		WorldUnits
	}
	[Token(Token = "0x2000071")]
	[Flags]
	public enum CurvyBezierModeEnum
	{
		[Token(Token = "0x4000115")]
		None = 0,
		[Token(Token = "0x4000116")]
		Direction = 1,
		[Token(Token = "0x4000117")]
		Length = 2,
		[Token(Token = "0x4000118")]
		Connections = 4,
		[Token(Token = "0x4000119")]
		Combine = 8
	}
	[Token(Token = "0x2000072")]
	public enum CurvyAdvBezierModeEnum
	{
		[Token(Token = "0x400011B")]
		None = 0,
		[Token(Token = "0x400011C")]
		Direction = 1,
		[Token(Token = "0x400011D")]
		Length = 2,
		[Token(Token = "0x400011E")]
		Combine = 8
	}
	[Token(Token = "0x2000073")]
	public enum CurvyInterpolation
	{
		[Token(Token = "0x4000120")]
		Linear,
		[Token(Token = "0x4000121")]
		CatmullRom,
		[Token(Token = "0x4000122")]
		TCB,
		[Token(Token = "0x4000123")]
		Bezier
	}
	[Token(Token = "0x2000074")]
	public enum CurvyClamping
	{
		[Token(Token = "0x4000125")]
		Clamp,
		[Token(Token = "0x4000126")]
		Loop,
		[Token(Token = "0x4000127")]
		PingPong
	}
	[Token(Token = "0x2000075")]
	public enum CurvyOrientation
	{
		[Token(Token = "0x4000129")]
		None,
		[Token(Token = "0x400012A")]
		Dynamic,
		[Token(Token = "0x400012B")]
		Static
	}
	[Token(Token = "0x2000076")]
	public enum CurvyOrientationSwirl
	{
		[Token(Token = "0x400012D")]
		None,
		[Token(Token = "0x400012E")]
		Segment,
		[Token(Token = "0x400012F")]
		AnchorGroup,
		[Token(Token = "0x4000130")]
		AnchorGroupAbs
	}
	[Token(Token = "0x2000077")]
	public enum CurvySplineGizmos
	{
		[Token(Token = "0x4000132")]
		None = 0,
		[Token(Token = "0x4000133")]
		Curve = 2,
		[Token(Token = "0x4000134")]
		Approximation = 4,
		[Token(Token = "0x4000135")]
		Tangents = 8,
		[Token(Token = "0x4000136")]
		Orientation = 16,
		[Token(Token = "0x4000137")]
		Labels = 32,
		[Token(Token = "0x4000138")]
		Metadata = 64,
		[Token(Token = "0x4000139")]
		Bounds = 128,
		[Token(Token = "0x400013A")]
		All = 65535
	}
	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4FF5B0", Offset = "0x4FF5B0")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x4FF5B0", Offset = "0x4FF5B0")]
	[ExecuteInEditMode]
	public class CurvyConnection : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000079")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FF620", Offset = "0x4FF620")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x400013F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CurvySplineSegment controlPoint;

			[Token(Token = "0x6000248")]
			[Address(RVA = "0xE7E384", Offset = "0xE7E384", VA = "0xE7E384")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x6000249")]
			[Address(RVA = "0xE7E38C", Offset = "0xE7E38C", VA = "0xE7E38C")]
			internal bool <RemoveControlPoint>b__0(ControlPointCoordinates element)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200007A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FF630", Offset = "0x4FF630")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x4000140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CurvySplineSegment controlPoint;

			[Token(Token = "0x600024A")]
			[Address(RVA = "0xE7E3B0", Offset = "0xE7E3B0", VA = "0xE7E3B0")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x600024B")]
			[Address(RVA = "0xE7E3B8", Offset = "0xE7E3B8", VA = "0xE7E3B8")]
			internal bool <SetSynchronisationPositionAndRotation>b__0(ControlPointCoordinates element)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200007B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FF640", Offset = "0x4FF640")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x4000141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CurvySplineSegment controlPoint;

			[Token(Token = "0x600024C")]
			[Address(RVA = "0xE7E3DC", Offset = "0xE7E3DC", VA = "0xE7E3DC")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x600024D")]
			[Address(RVA = "0xE7E3E4", Offset = "0xE7E3E4", VA = "0xE7E3E4")]
			internal bool <DoUpdate>b__0(ControlPointCoordinates element)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x200007C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FF650", Offset = "0x4FF650")]
		private sealed class <>c
		{
			[Token(Token = "0x4000142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<CurvySplineSegment> <>9__24_0;

			[Token(Token = "0x4000144")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<CurvySplineSegment> <>9__26_0;

			[Token(Token = "0x4000145")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Predicate<CurvySplineSegment> <>9__27_0;

			[Token(Token = "0x600024F")]
			[Address(RVA = "0xE7E2FC", Offset = "0xE7E2FC", VA = "0xE7E2FC")]
			public <>c()
			{
			}

			[Token(Token = "0x6000250")]
			[Address(RVA = "0xE7E304", Offset = "0xE7E304", VA = "0xE7E304")]
			internal bool <OnSceneLoaded>b__24_0(CurvySplineSegment cp)
			{
				return default(bool);
			}

			[Token(Token = "0x6000251")]
			[Address(RVA = "0xE7E36C", Offset = "0xE7E36C", VA = "0xE7E36C")]
			internal bool <OnBeforeSerialize>b__26_0(CurvySplineSegment cp)
			{
				return default(bool);
			}

			[Token(Token = "0x6000252")]
			[Address(RVA = "0xE7E378", Offset = "0xE7E378", VA = "0xE7E378")]
			internal bool <OnAfterDeserialize>b__27_0(CurvySplineSegment cp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Hide]
		[SerializeField]
		private List<CurvySplineSegment> m_ControlPoints;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ReadOnlyCollection<CurvySplineSegment> readOnlyControlPoints;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Couple<Vector3, Quaternion> processedConnectionCoordinates;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Hide]
		[SerializeField]
		private List<ControlPointCoordinates> processedControlPointsCoordinates;

		[Token(Token = "0x1700005E")]
		public ReadOnlyCollection<CurvySplineSegment> ControlPointsList
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0xB8EE5C", Offset = "0xB8EE5C", VA = "0xB8EE5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		public int Count
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0xB8EED4", Offset = "0xB8EED4", VA = "0xB8EED4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000060")]
		public CurvySplineSegment Item
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0xB8EF20", Offset = "0xB8EF20", VA = "0xB8EF20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xB8EF94", Offset = "0xB8EF94", VA = "0xB8EF94")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xB8F248", Offset = "0xB8F248", VA = "0xB8F248")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xB8F304", Offset = "0xB8F304", VA = "0xB8F304")]
		private void Update()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xB8F97C", Offset = "0xB8F97C", VA = "0xB8F97C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xB8F9B4", Offset = "0xB8F9B4", VA = "0xB8F9B4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xB8F9EC", Offset = "0xB8F9EC", VA = "0xB8F9EC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xB8FB9C", Offset = "0xB8FB9C", VA = "0xB8FB9C")]
		public static CurvyConnection Create(params CurvySplineSegment[] controlPoints)
		{
			return null;
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xB8FD70", Offset = "0xB8FD70", VA = "0xB8FD70")]
		public void AddControlPoints(params CurvySplineSegment[] controlPoints)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xB8FF64", Offset = "0xB8FF64", VA = "0xB8FF64")]
		public void AutoSetFollowUp()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xB901C4", Offset = "0xB901C4", VA = "0xB901C4")]
		public void RemoveControlPoint(CurvySplineSegment controlPoint, bool destroySelfIfEmpty = true)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xB90480", Offset = "0xB90480", VA = "0xB90480")]
		public void Delete()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xB90510", Offset = "0xB90510", VA = "0xB90510")]
		public List<CurvySplineSegment> OtherControlPoints(CurvySplineSegment source)
		{
			return null;
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xB905C0", Offset = "0xB905C0", VA = "0xB905C0")]
		public void SetSynchronisationPositionAndRotation(Vector3 referencePosition, Quaternion referenceRotation)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xB8F33C", Offset = "0xB8F33C", VA = "0xB8F33C")]
		private void DoUpdate()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xB90988", Offset = "0xB90988", VA = "0xB90988")]
		private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xB8F058", Offset = "0xB8F058", VA = "0xB8F058")]
		private void ResetProcessedCoordinates()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xB90B64", Offset = "0xB90B64", VA = "0xB90B64", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xB90C90", Offset = "0xB90C90", VA = "0xB90C90", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xB90DBC", Offset = "0xB90DBC", VA = "0xB90DBC")]
		public CurvyConnection()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007D")]
	internal class ControlPointCoordinates
	{
		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		internal CurvySplineSegment ControlPoint;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		internal Vector3 Position;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		internal Quaternion Rotation;

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xB8AFDC", Offset = "0xB8AFDC", VA = "0xB8AFDC")]
		internal ControlPointCoordinates(CurvySplineSegment controlPoint)
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class CurvyEventArgs : EventArgs
	{
		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly MonoBehaviour Sender;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly object Data;

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xBAEBD0", Offset = "0xBAEBD0", VA = "0xBAEBD0")]
		public CurvyEventArgs(MonoBehaviour sender, object data)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007F")]
	public class CurvySplineEvent : UnityEventEx<CurvySplineEventArgs>
	{
		[Token(Token = "0x6000255")]
		[Address(RVA = "0xEAF36C", Offset = "0xEAF36C", VA = "0xEAF36C")]
		public CurvySplineEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public class CurvyControlPointEvent : UnityEventEx<CurvyControlPointEventArgs>
	{
		[Token(Token = "0x6000256")]
		[Address(RVA = "0xBACBE4", Offset = "0xBACBE4", VA = "0xBACBE4")]
		public CurvyControlPointEvent()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class CurvyControlPointEventArgs : CurvySplineEventArgs
	{
		[Token(Token = "0x2000082")]
		public enum ModeEnum
		{
			[Token(Token = "0x400014E")]
			None,
			[Token(Token = "0x400014F")]
			AddBefore,
			[Token(Token = "0x4000150")]
			AddAfter,
			[Token(Token = "0x4000151")]
			Delete
		}

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ModeEnum Mode;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly CurvySplineSegment ControlPoint;

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xBACC30", Offset = "0xBACC30", VA = "0xBACC30")]
		public CurvyControlPointEventArgs(MonoBehaviour sender, CurvySpline spline, CurvySplineSegment cp, ModeEnum mode = ModeEnum.None, [Optional] object data)
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class CurvySplineEventArgs : CurvyEventArgs
	{
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly CurvySpline Spline;

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xEAF3B8", Offset = "0xEAF3B8", VA = "0xEAF3B8")]
		public CurvySplineEventArgs(MonoBehaviour sender, CurvySpline spline, [Optional] object data)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000084")]
	public class CurvyCGEvent : UnityEventEx<CurvyCGEventArgs>
	{
		[Token(Token = "0x6000259")]
		[Address(RVA = "0xB8ECC4", Offset = "0xB8ECC4", VA = "0xB8ECC4")]
		public CurvyCGEvent()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class CurvyCGEventArgs : EventArgs
	{
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly MonoBehaviour Sender;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly CurvyGenerator Generator;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly CGModule Module;

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xB8ED10", Offset = "0xB8ED10", VA = "0xB8ED10")]
		public CurvyCGEventArgs(CGModule module)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xB8EDB8", Offset = "0xB8EDB8", VA = "0xB8EDB8")]
		public CurvyCGEventArgs(CurvyGenerator generator, CGModule module)
		{
		}
	}
	[Token(Token = "0x2000086")]
	public static class CurvyGizmoHelper
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Matrix4x4 Matrix;

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xBB2968", Offset = "0xBB2968", VA = "0xBB2968")]
		public static void SegmentCurveGizmo(CurvySplineSegment seg, Color col, float stepSize = 0.05f)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xBB2BA8", Offset = "0xBB2BA8", VA = "0xBB2BA8")]
		public static void SegmentApproximationGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xBB2E7C", Offset = "0xBB2E7C", VA = "0xBB2E7C")]
		public static void SegmentOrientationAnchorGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xBB30B8", Offset = "0xBB30B8", VA = "0xBB30B8")]
		public static void SegmentOrientationGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xBB3360", Offset = "0xBB3360", VA = "0xBB3360")]
		public static void SegmentTangentGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xBB35B8", Offset = "0xBB35B8", VA = "0xBB35B8")]
		public static void ControlPointGizmo(CurvySplineSegment cp, bool selected, Color col)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xBB3934", Offset = "0xBB3934", VA = "0xBB3934")]
		public static void BoundsGizmo(CurvySplineSegment cp, Color col)
		{
		}
	}
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4FF660", Offset = "0x4FF660")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4FF660", Offset = "0x4FF660")]
	[ExecuteInEditMode]
	public class CurvyGlobalManager : DTSingleton<CurvyGlobalManager>
	{
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool HideManager;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float SceneViewResolution;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Color DefaultGizmoColor;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Color DefaultGizmoSelectionColor;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static CurvyInterpolation DefaultInterpolation;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static float GizmoControlPointSize;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static float GizmoOrientationLength;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static Color GizmoOrientationColor;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static int SplineLayer;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static CurvySplineGizmos Gizmos;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private PoolManager mPoolManager;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ComponentPool mControlPointPool;

		[Token(Token = "0x17000061")]
		public static bool ShowCurveGizmo
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0xBB3B44", Offset = "0xBB3B44", VA = "0xBB3B44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000265")]
			[Address(RVA = "0xBB3BAC", Offset = "0xBB3BAC", VA = "0xBB3BAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public static bool ShowApproximationGizmo
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0xBB3C44", Offset = "0xBB3C44", VA = "0xBB3C44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000267")]
			[Address(RVA = "0xBB3CAC", Offset = "0xBB3CAC", VA = "0xBB3CAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public static bool ShowTangentsGizmo
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0xBB3D44", Offset = "0xBB3D44", VA = "0xBB3D44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000269")]
			[Address(RVA = "0xBB3DAC", Offset = "0xBB3DAC", VA = "0xBB3DAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public static bool ShowOrientationGizmo
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0xBB3E44", Offset = "0xBB3E44", VA = "0xBB3E44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026B")]
			[Address(RVA = "0xBB3EAC", Offset = "0xBB3EAC", VA = "0xBB3EAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public static bool ShowLabelsGizmo
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0xBB3F44", Offset = "0xBB3F44", VA = "0xBB3F44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026D")]
			[Address(RVA = "0xBB3FAC", Offset = "0xBB3FAC", VA = "0xBB3FAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public static bool ShowMetadataGizmo
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0xBB4044", Offset = "0xBB4044", VA = "0xBB4044")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026F")]
			[Address(RVA = "0xBB40AC", Offset = "0xBB40AC", VA = "0xBB40AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public static bool ShowBoundsGizmo
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0xBB4144", Offset = "0xBB4144", VA = "0xBB4144")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000271")]
			[Address(RVA = "0xBB41AC", Offset = "0xBB41AC", VA = "0xBB41AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public PoolManager PoolManager
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0xBB4244", Offset = "0xBB4244", VA = "0xBB4244")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		public ComponentPool ControlPointPool
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0xBB42F8", Offset = "0xBB42F8", VA = "0xBB42F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public CurvyConnection[] Connections
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0xBB4300", Offset = "0xBB4300", VA = "0xBB4300")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xBB434C", Offset = "0xBB434C", VA = "0xBB434C")]
		public CurvyConnection[] GetContainingConnections(params CurvySpline[] splines)
		{
			return null;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xBB4BF4", Offset = "0xBB4BF4", VA = "0xBB4BF4", Slot = "5")]
		public override void Awake()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xBB4DB4", Offset = "0xBB4DB4", VA = "0xBB4DB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xBB4E44", Offset = "0xBB4E44", VA = "0xBB4E44")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x50DE2C", Offset = "0x50DE2C")]
		private static void LoadRuntimeSettings()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xBB5194", Offset = "0xBB5194", VA = "0xBB5194")]
		public static void SaveRuntimeSettings()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xBB5434", Offset = "0xBB5434", VA = "0xBB5434", Slot = "7")]
		public override void MergeDoubleLoaded(IDTSingleton newInstance)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xBB5558", Offset = "0xBB5558", VA = "0xBB5558")]
		public CurvyGlobalManager()
		{
		}
	}
	[Token(Token = "0x2000088")]
	[ExecuteInEditMode]
	public abstract class CurvyInterpolatableMetadataBase<T> : CurvyMetadataBase
	{
		[Token(Token = "0x1700006B")]
		public abstract T MetaDataValue
		{
			[Token(Token = "0x600027D")]
			get;
		}

		[Token(Token = "0x600027E")]
		public abstract T Interpolate(CurvyInterpolatableMetadataBase<T> nextMetadata, float interpolationTime);

		[Token(Token = "0x600027F")]
		protected CurvyInterpolatableMetadataBase()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4FF704", Offset = "0x4FF704")]
	public abstract class CurvyMetadataBase : MonoBehaviour
	{
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvySplineSegment mCP;

		[Token(Token = "0x1700006C")]
		public CurvySplineSegment ControlPoint
		{
			[Token(Token = "0x6000280")]
			[Address(RVA = "0xBB606C", Offset = "0xBB606C", VA = "0xBB606C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		public CurvySpline Spline
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0xBB6074", Offset = "0xBB6074", VA = "0xBB6074")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xBB60FC", Offset = "0xBB60FC", VA = "0xBB60FC", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xBB6170", Offset = "0xBB6170", VA = "0xBB6170")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000284")]
		public T GetPreviousData<T>(bool autoCreate = true, bool segmentsOnly = true, bool useFollowUp = false) where T : CurvyMetadataBase
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		public T GetNextData<T>(bool autoCreate = true, bool segmentsOnly = true, bool useFollowUp = false) where T : CurvyMetadataBase
		{
			return null;
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xBB6190", Offset = "0xBB6190", VA = "0xBB6190")]
		protected void NotifyModification()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xBB6230", Offset = "0xBB6230", VA = "0xBB6230")]
		protected CurvyMetadataBase()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x4FF774", Offset = "0x4FF774")]
	public class CGResourceManagerAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string ResourceName;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool ReadOnly;

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xB7EF60", Offset = "0xB7EF60", VA = "0xB7EF60")]
		public CGResourceManagerAttribute(string resourceName)
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x4FF7AC", Offset = "0x4FF7AC")]
	public sealed class CGResourceCollectionManagerAttribute : CGResourceManagerAttribute
	{
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool ShowCount;

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xB7EF38", Offset = "0xB7EF38", VA = "0xB7EF38")]
		public CGResourceCollectionManagerAttribute(string resourceName)
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x4FF7E4", Offset = "0x4FF7E4")]
	public sealed class CGDataReferenceSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly Type DataType;

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xC1113C", Offset = "0xC1113C", VA = "0xC1113C")]
		public CGDataReferenceSelectorAttribute(Type dataType)
		{
		}
	}
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4FF81C", Offset = "0x4FF81C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4FF81C", Offset = "0x4FF81C")]
	public class CurvyShape : DTVersionedMonoBehaviour
	{
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x501FAC", Offset = "0x501FAC")]
		[SerializeField]
		private CurvyPlane m_Plane;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		[SerializeField]
		private bool m_Persistent;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<CurvyShapeInfo, Type> mShapeDefs;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CurvySpline mSpline;

		[NonSerialized]
		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool Dirty;

		[Token(Token = "0x1700006E")]
		public CurvyPlane Plane
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0xBB6238", Offset = "0xBB6238", VA = "0xBB6238")]
			get
			{
				return default(CurvyPlane);
			}
			[Token(Token = "0x600028C")]
			[Address(RVA = "0xBB6240", Offset = "0xBB6240", VA = "0xBB6240")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public bool Persistent
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0xBB625C", Offset = "0xBB625C", VA = "0xBB625C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600028E")]
			[Address(RVA = "0xBB6264", Offset = "0xBB6264", VA = "0xBB6264")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public CurvySpline Spline
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0xBB6298", Offset = "0xBB6298", VA = "0xBB6298")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		public static Dictionary<CurvyShapeInfo, Type> ShapeDefinitions
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0xBB7928", Offset = "0xBB7928", VA = "0xBB7928")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xBB6348", Offset = "0xBB6348", VA = "0xBB6348")]
		private void Update()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xBB6478", Offset = "0xBB6478", VA = "0xBB6478", Slot = "4")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xBB6490", Offset = "0xBB6490", VA = "0xBB6490")]
		public void Delete()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xBB6388", Offset = "0xBB6388", VA = "0xBB6388")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xBB658C", Offset = "0xBB658C", VA = "0xBB658C")]
		public CurvyShape Replace(string menuName)
		{
			return null;
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xBB6900", Offset = "0xBB6900", VA = "0xBB6900")]
		protected void PrepareSpline(CurvyInterpolation interpolation, CurvyOrientation orientation = CurvyOrientation.Dynamic, int cachedensity = 50, bool closed = true)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xBB6B9C", Offset = "0xBB6B9C", VA = "0xBB6B9C")]
		protected void SetPosition(int no, Vector3 position)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xBB6C40", Offset = "0xBB6C40", VA = "0xBB6C40")]
		protected void SetRotation(int no, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xBB6CEC", Offset = "0xBB6CEC", VA = "0xBB6CEC")]
		protected void SetBezierHandles(int no, float distanceFrag)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xBB6CF4", Offset = "0xBB6CF4", VA = "0xBB6CF4")]
		protected void SetBezierHandles(int no, float inDistanceFrag, float outDistanceFrag)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xBB6FFC", Offset = "0xBB6FFC", VA = "0xBB6FFC")]
		protected void SetBezierHandles(int no, Vector3 i, Vector3 o, Space space = Space.World)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xBB6F58", Offset = "0xBB6F58", VA = "0xBB6F58")]
		public static void SetBezierHandles(float distanceFrag, bool setIn, bool setOut, params CurvySplineSegment[] controlPoints)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xBB7154", Offset = "0xBB7154", VA = "0xBB7154")]
		protected void SetCGHardEdges(params int[] controlPoints)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xBB72C4", Offset = "0xBB72C4", VA = "0xBB72C4", Slot = "5")]
		protected virtual void ApplyShape()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xBB72C8", Offset = "0xBB72C8", VA = "0xBB72C8")]
		protected void PrepareControlPoints(int count)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xBB7A78", Offset = "0xBB7A78", VA = "0xBB7A78")]
		public static List<string> GetShapesMenuNames(bool only2D = false)
		{
			return null;
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xBB7C68", Offset = "0xBB7C68", VA = "0xBB7C68")]
		public static List<string> GetShapesMenuNames(Type currentShapeType, out int currentIndex, bool only2D = false)
		{
			return null;
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xBB7F4C", Offset = "0xBB7F4C", VA = "0xBB7F4C")]
		public static string GetShapeName(Type shapeType)
		{
			return null;
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xBB6704", Offset = "0xBB6704", VA = "0xBB6704")]
		public static Type GetShapeType(string menuName)
		{
			return null;
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xBB64F4", Offset = "0xBB64F4", VA = "0xBB64F4")]
		private void applyPlane()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xBB8120", Offset = "0xBB8120", VA = "0xBB8120")]
		private void applyRotation(Quaternion q)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xBB83CC", Offset = "0xBB83CC", VA = "0xBB83CC")]
		public CurvyShape()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x4FF8B0", Offset = "0x4FF8B0")]
	public sealed class CurvyShapeInfo : Attribute
	{
		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Name;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly bool Is2D;

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xBB84D4", Offset = "0xBB84D4", VA = "0xBB84D4")]
		public CurvyShapeInfo(string name, bool is2D = true)
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class CurvyShape2D : CurvyShape
	{
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xBB8468", Offset = "0xBB8468", VA = "0xBB8468")]
		public CurvyShape2D()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4FF8E8", Offset = "0x4FF8E8")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4FF8E8", Offset = "0x4FF8E8")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x4FF8E8", Offset = "0x4FF8E8")]
	public class CurvySpline : DTVersionedMonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000091")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FF980", Offset = "0x4FF980")]
		private sealed class <>c
		{
			[Token(Token = "0x40001AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40001AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<CurvySplineSegment> <>9__4_0;

			[Token(Token = "0x40001AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action<CurvySplineSegment> <>9__290_0;

			[Token(Token = "0x6000377")]
			[Address(RVA = "0xE7E5D4", Offset = "0xE7E5D4", VA = "0xE7E5D4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000378")]
			[Address(RVA = "0xE7E5DC", Offset = "0xE7E5DC", VA = "0xE7E5DC")]
			internal void <.ctor>b__4_0(CurvySplineSegment controlPoint)
			{
			}

			[Token(Token = "0x6000379")]
			[Address(RVA = "0xE7E5F8", Offset = "0xE7E5F8", VA = "0xE7E5F8")]
			internal void <ProcessDirtyControlPoints>b__290_0(CurvySplineSegment controlPoint)
			{
			}
		}

		[Token(Token = "0x400016F")]
		public const string VERSION = "7.1.3";

		[Token(Token = "0x4000170")]
		public const string APIVERSION = "710";

		[Token(Token = "0x4000171")]
		public const string WEBROOT = "https://curvyeditor.com/";

		[Token(Token = "0x4000172")]
		public const string DOCLINK = "https://curvyeditor.com/doclink/";

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		private List<CurvySplineSegment> ControlPoints;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool ShowGizmos;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x502094", Offset = "0x502094")]
		private Action<CurvySpline> <OnGlobalCoordinatesChanged>k__BackingField;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x5020A4", Offset = "0x5020A4")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5020A4", Offset = "0x5020A4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5020A4", Offset = "0x5020A4")]
		private CurvyInterpolation m_Interpolation;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x502160", Offset = "0x502160")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x502160", Offset = "0x502160")]
		private bool m_RestrictTo2D;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5021D4", Offset = "0x5021D4")]
		[SerializeField]
		private bool m_Closed;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x502220", Offset = "0x502220")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x502220", Offset = "0x502220")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x502220", Offset = "0x502220")]
		private bool m_AutoEndTangents;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5022BC", Offset = "0x5022BC")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5022BC", Offset = "0x5022BC")]
		private CurvyOrientation m_Orientation;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x50232C", Offset = "0x50232C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x50232C", Offset = "0x50232C")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x50232C", Offset = "0x50232C")]
		private float m_AutoHandleDistance;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x50245C", Offset = "0x50245C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x50245C", Offset = "0x50245C")]
		[AttributeAttribute(Name = "GroupActionAttribute", RVA = "0x50245C", Offset = "0x50245C")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x50245C", Offset = "0x50245C")]
		private float m_Tension;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5025A0", Offset = "0x5025A0")]
		[SerializeField]
		private float m_Continuity;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5025EC", Offset = "0x5025EC")]
		[SerializeField]
		private float m_Bias;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x502638", Offset = "0x502638")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x502638", Offset = "0x502638")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x502638", Offset = "0x502638")]
		[SerializeField]
		private Color m_GizmoColor;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x502718", Offset = "0x502718")]
		[SerializeField]
		private Color m_GizmoSelectionColor;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x502780", Offset = "0x502780")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x502780", Offset = "0x502780")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x502780", Offset = "0x502780")]
		private int m_CacheDensity;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x50283C", Offset = "0x50283C")]
		private float m_MaxPointsPerUnit;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x502888", Offset = "0x502888")]
		private bool m_UsePooling;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5028D4", Offset = "0x5028D4")]
		private bool m_UseThreading;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x502920", Offset = "0x502920")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x502920", Offset = "0x502920")]
		private bool m_CheckTransform;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CurvyUpdateMethod m_UpdateIn;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x5029A0", Offset = "0x5029A0")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x5029A0", Offset = "0x5029A0")]
		[SerializeField]
		protected CurvySplineEvent m_OnRefresh;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x502A28", Offset = "0x502A28")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x502A28", Offset = "0x502A28")]
		[SerializeField]
		protected CurvySplineEvent m_OnAfterControlPointChanges;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x502A90", Offset = "0x502A90")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x502A90", Offset = "0x502A90")]
		[SerializeField]
		protected CurvyControlPointEvent m_OnBeforeControlPointAdd;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x502AF8", Offset = "0x502AF8")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x502AF8", Offset = "0x502AF8")]
		protected CurvyControlPointEvent m_OnAfterControlPointAdd;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x502B64", Offset = "0x502B64")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x502B64", Offset = "0x502B64")]
		[SerializeField]
		protected CurvyControlPointEvent m_OnBeforeControlPointDelete;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool mIsInitialized;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool isStarted;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
		private bool sendOnRefreshEventNextUpdate;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly object controlPointsRelationshipCacheLock;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<CurvySplineSegment> mSegments;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ReadOnlyCollection<CurvySplineSegment> readOnlyControlPoints;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float length;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int mCacheSize;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Bounds? mBounds;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private bool mDirtyCurve;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF5")]
		private bool mDirtyOrientation;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private HashSet<CurvySplineSegment> dirtyControlPointsMinimalSet;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private List<CurvySplineSegment> dirtyCpsExtendedList;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool allControlPointsAreDirty;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private ThreadPoolWorker<CurvySplineSegment> mThreadWorker;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private readonly CurvySplineEventArgs defaultSplineEventArgs;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private readonly CurvyControlPointEventArgs defaultAddAfterEventArgs;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private readonly CurvyControlPointEventArgs defaultDeleteEventArgs;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float[] controlPointsDistances;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private readonly Action<CurvySplineSegment> refreshCurveAction;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 lastProcessedPosition;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Quaternion lastProcessedRotation;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private Vector3 lastProcessedScale;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private bool globalCoordinatesChangedThisFrame;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
		private bool isCpsRelationshipCacheValid;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private CurvySplineSegment firstSegment;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private CurvySplineSegment lastSegment;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private CurvySplineSegment firstVisibleControlPoint;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private CurvySplineSegment lastVisibleControlPoint;

		[Token(Token = "0x40001A9")]
		private const float MinimalMaxPointsPerUnit = 0.0001f;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string InvalidCPErrorMessage;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Transform cachedTransform;

		[Token(Token = "0x17000072")]
		public CurvyInterpolation Interpolation
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0xBB8A20", Offset = "0xBB8A20", VA = "0xBB8A20")]
			get
			{
				return default(CurvyInterpolation);
			}
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0xBB6A4C", Offset = "0xBB6A4C", VA = "0xBB6A4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public bool RestrictTo2D
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0xBB8E48", Offset = "0xBB8E48", VA = "0xBB8E48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0xBB6B70", Offset = "0xBB6B70", VA = "0xBB6B70")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public float AutoHandleDistance
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0xBB8E50", Offset = "0xBB8E50", VA = "0xBB8E50")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0xBB8E58", Offset = "0xBB8E58", VA = "0xBB8E58")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public bool Closed
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0xBB8EA4", Offset = "0xBB8EA4", VA = "0xBB8EA4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0xBB6B18", Offset = "0xBB6B18", VA = "0xBB6B18")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public bool AutoEndTangents
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0xBB8EAC", Offset = "0xBB8EAC", VA = "0xBB8EAC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0xBB8DC8", Offset = "0xBB8DC8", VA = "0xBB8DC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public CurvyOrientation Orientation
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0xBB8ED8", Offset = "0xBB8ED8", VA = "0xBB8ED8")]
			get
			{
				return default(CurvyOrientation);
			}
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0xBB6A98", Offset = "0xBB6A98", VA = "0xBB6A98")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public CurvyUpdateMethod UpdateIn
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0xBB8EE0", Offset = "0xBB8EE0", VA = "0xBB8EE0")]
			get
			{
				return default(CurvyUpdateMethod);
			}
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0xBB8EE8", Offset = "0xBB8EE8", VA = "0xBB8EE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public Color GizmoColor
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0xBB8EFC", Offset = "0xBB8EFC", VA = "0xBB8EFC")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0xBB8F08", Offset = "0xBB8F08", VA = "0xBB8F08")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public Color GizmoSelectionColor
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0xBB8F74", Offset = "0xBB8F74", VA = "0xBB8F74")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0xBB8F80", Offset = "0xBB8F80", VA = "0xBB8F80")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public int CacheDensity
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0xBB8FEC", Offset = "0xBB8FEC", VA = "0xBB8FEC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0xBB6ABC", Offset = "0xBB6ABC", VA = "0xBB6ABC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public float MaxPointsPerUnit
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0xBB8FF4", Offset = "0xBB8FF4", VA = "0xBB8FF4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0xBB8FFC", Offset = "0xBB8FFC", VA = "0xBB8FFC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public bool UsePooling
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0xBB9058", Offset = "0xBB9058", VA = "0xBB9058")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0xBB9060", Offset = "0xBB9060", VA = "0xBB9060")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public bool UseThreading
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0xBB9080", Offset = "0xBB9080", VA = "0xBB9080")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0xBB9088", Offset = "0xBB9088", VA = "0xBB9088")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public bool CheckTransform
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0xBB90A8", Offset = "0xBB90A8", VA = "0xBB90A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0xBB90B0", Offset = "0xBB90B0", VA = "0xBB90B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public float Tension
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0xBB90DC", Offset = "0xBB90DC", VA = "0xBB90DC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0xBB90E4", Offset = "0xBB90E4", VA = "0xBB90E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public float Continuity
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0xBB9104", Offset = "0xBB9104", VA = "0xBB9104")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0xBB910C", Offset = "0xBB910C", VA = "0xBB910C")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public float Bias
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0xBB912C", Offset = "0xBB912C", VA = "0xBB912C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0xBB9134", Offset = "0xBB9134", VA = "0xBB9134")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public bool IsInitialized
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0xBB9154", Offset = "0xBB9154", VA = "0xBB9154")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000084")]
		public Bounds Bounds
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0xBB915C", Offset = "0xBB915C", VA = "0xBB915C")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000085")]
		public int Count
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0xBB937C", Offset = "0xBB937C", VA = "0xBB937C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000086")]
		public int ControlPointCount
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0xBB6F0C", Offset = "0xBB6F0C", VA = "0xBB6F0C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000087")]
		public int CacheSize
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0xBB94FC", Offset = "0xBB94FC", VA = "0xBB94FC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000088")]
		public float Length
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0xBB95DC", Offset = "0xBB95DC", VA = "0xBB95DC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000089")]
		public bool Dirty
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0xBB9464", Offset = "0xBB9464", VA = "0xBB9464")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008A")]
		public CurvySplineSegment Item
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0xBB93DC", Offset = "0xBB93DC", VA = "0xBB93DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008B")]
		public ReadOnlyCollection<CurvySplineSegment> ControlPointsList
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0xBB4B7C", Offset = "0xBB4B7C", VA = "0xBB4B7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		[CanBeNull]
		public CurvySplineSegment FirstVisibleControlPoint
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0xBB96D8", Offset = "0xBB96D8", VA = "0xBB96D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		[CanBeNull]
		public CurvySplineSegment LastVisibleControlPoint
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0xBB76A8", Offset = "0xBB76A8", VA = "0xBB76A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		public CurvySplineSegment FirstSegment
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0xBB9DA4", Offset = "0xBB9DA4", VA = "0xBB9DA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		public CurvySplineSegment LastSegment
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0xBB9DD8", Offset = "0xBB9DD8", VA = "0xBB9DD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		public bool GlobalCoordinatesChangedThisFrame
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0xBB9E0C", Offset = "0xBB9E0C", VA = "0xBB9E0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		public Action<CurvySpline> OnGlobalCoordinatesChanged
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0xBB9E14", Offset = "0xBB9E14", VA = "0xBB9E14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50DE3C", Offset = "0x50DE3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0xBB9E1C", Offset = "0xBB9E1C", VA = "0xBB9E1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50DE4C", Offset = "0x50DE4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public CurvySplineEvent OnRefresh
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0xBB9E24", Offset = "0xBB9E24", VA = "0xBB9E24")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0xBB9E2C", Offset = "0xBB9E2C", VA = "0xBB9E2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public CurvySplineEvent OnAfterControlPointChanges
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0xBB9E44", Offset = "0xBB9E44", VA = "0xBB9E44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xBB9E4C", Offset = "0xBB9E4C", VA = "0xBB9E4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public CurvyControlPointEvent OnBeforeControlPointAdd
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0xBB9E64", Offset = "0xBB9E64", VA = "0xBB9E64")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0xBB9E6C", Offset = "0xBB9E6C", VA = "0xBB9E6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public CurvyControlPointEvent OnAfterControlPointAdd
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0xBB9E84", Offset = "0xBB9E84", VA = "0xBB9E84")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0xBB9E8C", Offset = "0xBB9E8C", VA = "0xBB9E8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public CurvyControlPointEvent OnBeforeControlPointDelete
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0xBB9EA4", Offset = "0xBB9EA4", VA = "0xBB9EA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0xBB9EAC", Offset = "0xBB9EAC", VA = "0xBB9EAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		private List<CurvySplineSegment> Segments
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0xBB94C8", Offset = "0xBB94C8", VA = "0xBB94C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xBB8520", Offset = "0xBB8520", VA = "0xBB8520")]
		public CurvySpline()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xBB9EC4", Offset = "0xBB9EC4", VA = "0xBB9EC4")]
		public static CurvySpline Create()
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xBBA0DC", Offset = "0xBBA0DC", VA = "0xBBA0DC")]
		public static CurvySpline Create(CurvySpline takeOptionsFrom)
		{
			return null;
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xBBA278", Offset = "0xBBA278", VA = "0xBBA278")]
		public static int CalculateCacheSize(int density, float splineLength, float maxPointsPerUnit)
		{
			return default(int);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xBBA300", Offset = "0xBBA300", VA = "0xBBA300")]
		public static float CalculateSamplingPointsPerUnit(int density, float maxPointsPerUnit)
		{
			return default(float);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xBBA3C8", Offset = "0xBBA3C8", VA = "0xBBA3C8")]
		public static Vector3 Bezier(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xBBA4B8", Offset = "0xBBA4B8", VA = "0xBBA4B8")]
		public static Vector3 BezierTangent(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xBBA584", Offset = "0xBBA584", VA = "0xBBA584")]
		public static Vector3 CatmullRom(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xBBA6A4", Offset = "0xBBA6A4", VA = "0xBBA6A4")]
		public static Vector3 TCB(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f, float FT0, float FC0, float FB0, float FT1, float FC1, float FB1)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xBBA8BC", Offset = "0xBBA8BC", VA = "0xBBA8BC")]
		[NotNull]
		public static CurvySplineSegment GetFollowUpHeadingControlPoint(CurvySplineSegment followUp, ConnectionHeadingEnum headingDirection)
		{
			return null;
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xBBAAC8", Offset = "0xBBAAC8", VA = "0xBBAAC8")]
		public Vector3 Interpolate(float tf, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xBBAB80", Offset = "0xBBAB80", VA = "0xBBAB80")]
		public Vector3 InterpolateFast(float tf, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xBBAC08", Offset = "0xBBAC08", VA = "0xBBAC08")]
		public Vector3 InterpolateByDistance(float distance, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xBBACEC", Offset = "0xBBACEC", VA = "0xBBACEC")]
		public Vector3 InterpolateByDistanceFast(float distance, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xBBAD1C", Offset = "0xBBAD1C", VA = "0xBBAD1C")]
		public Vector3 GetTangent(float tf, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xBBADA4", Offset = "0xBBADA4", VA = "0xBBADA4")]
		public Vector3 GetTangent(float tf, Vector3 position, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xBBAE54", Offset = "0xBBAE54", VA = "0xBBAE54")]
		public Vector3 GetTangentFast(float tf, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xBBAEDC", Offset = "0xBBAEDC", VA = "0xBBAEDC")]
		public Vector3 GetTangentByDistance(float distance, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xBBAF0C", Offset = "0xBBAF0C", VA = "0xBBAF0C")]
		public Vector3 GetTangentByDistanceFast(float distance, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xBBAF3C", Offset = "0xBBAF3C", VA = "0xBBAF3C")]
		public void InterpolateAndGetTangent(float tf, out Vector3 position, out Vector3 tangent, Space space = Space.Self)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xBBAFEC", Offset = "0xBBAFEC", VA = "0xBBAFEC")]
		public void InterpolateAndGetTangentFast(float tf, out Vector3 position, out Vector3 tangent, Space space = Space.Self)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xBBB09C", Offset = "0xBBB09C", VA = "0xBBB09C")]
		public Vector3 GetOrientationUpFast(float tf, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xBBB124", Offset = "0xBBB124", VA = "0xBBB124")]
		public Quaternion GetOrientationFast(float tf, bool inverse = false, Space space = Space.Self)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xBBB1BC", Offset = "0xBBB1BC", VA = "0xBBB1BC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x50DE6C", Offset = "0x50DE6C")]
		public Vector3 InterpolateScale(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002FE")]
		public T GetMetadata<T>(float tf) where T : CurvyMetadataBase
		{
			return null;
		}

		[Token(Token = "0x60002FF")]
		public U GetInterpolatedMetadata<T, U>(float tf) where T : CurvyInterpolatableMetadataBase<U>
		{
			return (U)null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xBBB20C", Offset = "0xBBB20C", VA = "0xBBB20C")]
		public float TFToDistance(float tf, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xBBB2E0", Offset = "0xBBB2E0", VA = "0xBBB2E0")]
		public CurvySplineSegment TFToSegment(float tf, out float localF, out bool isOnSegmentStart, out bool isOnSegmentEnd, CurvyClamping clamping)
		{
			return null;
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xBBB2B0", Offset = "0xBBB2B0", VA = "0xBBB2B0")]
		public CurvySplineSegment TFToSegment(float tf, out float localF, CurvyClamping clamping)
		{
			return null;
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xBBB3BC", Offset = "0xBBB3BC", VA = "0xBBB3BC")]
		public CurvySplineSegment TFToSegment(float tf, CurvyClamping clamping)
		{
			return null;
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xBBB3F4", Offset = "0xBBB3F4", VA = "0xBBB3F4")]
		public CurvySplineSegment TFToSegment(float tf)
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xBBAB50", Offset = "0xBBAB50", VA = "0xBBAB50")]
		public CurvySplineSegment TFToSegment(float tf, out float localF)
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xBBB42C", Offset = "0xBBB42C", VA = "0xBBB42C")]
		public float SegmentToTF(CurvySplineSegment segment)
		{
			return default(float);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xBBB444", Offset = "0xBBB444", VA = "0xBBB444")]
		public float SegmentToTF(CurvySplineSegment segment, float localF)
		{
			return default(float);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xBBAC38", Offset = "0xBBAC38", VA = "0xBBAC38")]
		public float DistanceToTF(float distance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xBBB518", Offset = "0xBBB518", VA = "0xBBB518")]
		public CurvySplineSegment DistanceToSegment(float distance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return null;
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xBBB4E8", Offset = "0xBBB4E8", VA = "0xBBB4E8")]
		public CurvySplineSegment DistanceToSegment(float distance, out float localDistance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xBBB550", Offset = "0xBBB550", VA = "0xBBB550")]
		public CurvySplineSegment DistanceToSegment(float distance, out float localDistance, out bool isOnSegmentStart, out bool isOnSegmentEnd, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xBBB6E0", Offset = "0xBBB6E0", VA = "0xBBB6E0")]
		public float ClampDistance(float distance, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xBBB71C", Offset = "0xBBB71C", VA = "0xBBB71C")]
		public float ClampDistance(float distance, CurvyClamping clamping, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xBBB770", Offset = "0xBBB770", VA = "0xBBB770")]
		public float ClampDistance(float distance, ref int dir, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xBBB7B4", Offset = "0xBBB7B4", VA = "0xBBB7B4")]
		public float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xBBB810", Offset = "0xBBB810", VA = "0xBBB810")]
		public CurvySplineSegment Add()
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xBBB81C", Offset = "0xBBB81C", VA = "0xBBB81C")]
		public CurvySplineSegment Add(Vector3 controlPointPosition, Space space)
		{
			return null;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xBBBAB0", Offset = "0xBBBAB0", VA = "0xBBBAB0")]
		public CurvySplineSegment[] Add(params Vector3[] controlPointsLocalPositions)
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xBBBC14", Offset = "0xBBBC14", VA = "0xBBBC14")]
		public CurvySplineSegment[] Add(Vector3[] controlPointsPositions, Space space)
		{
			return null;
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xBBBD84", Offset = "0xBBBD84", VA = "0xBBBD84")]
		public CurvySplineSegment InsertBefore(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xBBBF0C", Offset = "0xBBBF0C", VA = "0xBBBF0C")]
		public CurvySplineSegment InsertBefore([CanBeNull] CurvySplineSegment controlPoint, Vector3 position, bool skipRefreshingAndEvents = false, Space space = Space.World)
		{
			return null;
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xBB7510", Offset = "0xBB7510", VA = "0xBB7510")]
		public CurvySplineSegment InsertAfter(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xBBB91C", Offset = "0xBBB91C", VA = "0xBBB91C")]
		public CurvySplineSegment InsertAfter([CanBeNull] CurvySplineSegment controlPoint, Vector3 position, bool skipRefreshingAndEvents = false, Space space = Space.World)
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xBBC45C", Offset = "0xBBC45C", VA = "0xBBC45C")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xBBC84C", Offset = "0xBBC84C", VA = "0xBBC84C")]
		public void Delete(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xBB76DC", Offset = "0xBB76DC", VA = "0xBB76DC")]
		public void Delete(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents, bool isUndoableDeletion)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xBB5EB4", Offset = "0xBB5EB4", VA = "0xBB5EB4")]
		public Vector3[] GetApproximation(Space space = Space.Self)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xBBCA9C", Offset = "0xBBCA9C", VA = "0xBBCA9C")]
		public Vector3[] GetApproximation(float fromTF, float toTF, bool includeEndPoint = true, Space space = Space.Self)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xBBCF80", Offset = "0xBBCF80", VA = "0xBBCF80")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x50DEA4", Offset = "0x50DEA4")]
		public Vector3[] GetApproximationPoints(float fromTF, float toTF, bool includeEndPoint = true, Space space = Space.Self)
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xBBCF88", Offset = "0xBBCF88", VA = "0xBBCF88")]
		public Vector3[] GetApproximationT(Space space = Space.Self)
		{
			return null;
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xBBD130", Offset = "0xBBD130", VA = "0xBBD130")]
		public Vector3[] GetApproximationUpVectors(Space space = Space.Self)
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xBBD2D8", Offset = "0xBBD2D8", VA = "0xBBD2D8")]
		public float GetNearestPointTF(Vector3 localPosition)
		{
			return default(float);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xBBD554", Offset = "0xBBD554", VA = "0xBBD554")]
		public float GetNearestPointTF(Vector3 position, Space space)
		{
			return default(float);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xBBD594", Offset = "0xBBD594", VA = "0xBBD594")]
		public float GetNearestPointTF(Vector3 localPosition, out Vector3 nearestPoint)
		{
			return default(float);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xBBD5CC", Offset = "0xBBD5CC", VA = "0xBBD5CC")]
		public float GetNearestPointTF(Vector3 position, out Vector3 nearestPoint, Space space)
		{
			return default(float);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xBBD604", Offset = "0xBBD604", VA = "0xBBD604")]
		public float GetNearestPointTF(Vector3 position, int searchStartSegmentIndex = 0, int searchEndSegmentIndex = -1, Space space = Space.Self)
		{
			return default(float);
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xBBD644", Offset = "0xBBD644", VA = "0xBBD644")]
		public float GetNearestPointTF(Vector3 position, out Vector3 nearestPoint, int searchStartSegmentIndex = 0, int searchEndSegmentIndex = -1, Space space = Space.Self)
		{
			return default(float);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xBBD318", Offset = "0xBBD318", VA = "0xBBD318")]
		public float GetNearestPointTF(Vector3 position, out Vector3 nearestPoint, [CanBeNull] out CurvySplineSegment nearestSegment, out float nearestPointLocalF, int searchStartSegmentIndex = 0, int searchEndSegmentIndex = -1, Space space = Space.Self)
		{
			return default(float);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xBB6564", Offset = "0xBB6564", VA = "0xBB6564")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xBB6558", Offset = "0xBB6558", VA = "0xBB6558")]
		public void SetDirtyAll()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xBB8B40", Offset = "0xBB8B40", VA = "0xBB8B40")]
		public void SetDirtyAll(SplineDirtyingType dirtyingType, bool dirtyConnectedControlPoints)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xBBE684", Offset = "0xBBE684", VA = "0xBBE684")]
		public void SetDirty(CurvySplineSegment dirtyControlPoint, SplineDirtyingType dirtyingType)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xBBEC04", Offset = "0xBBEC04", VA = "0xBBEC04")]
		public void SetDirtyPartial(CurvySplineSegment dirtyControlPoint, SplineDirtyingType dirtyingType)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xBBEC5C", Offset = "0xBBEC5C", VA = "0xBBEC5C")]
		public Vector3 ToWorldPosition(Vector3 localPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xBBEC78", Offset = "0xBBEC78", VA = "0xBBEC78")]
		public Vector3 ToWorldDirection(Vector3 localDirection)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xBBEC94", Offset = "0xBBEC94", VA = "0xBBEC94")]
		public Vector3 ToLocalPosition(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xBBECB0", Offset = "0xBBECB0", VA = "0xBBECB0")]
		public Vector3 ToLocalDirection(Vector3 localDirection)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xBBECCC", Offset = "0xBBECCC", VA = "0xBBECCC")]
		public void SyncSplineFromHierarchy()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xBBEFB4", Offset = "0xBBEFB4", VA = "0xBBEFB4")]
		public bool IsPlanar(out int ignoreAxis)
		{
			return default(bool);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xBBF030", Offset = "0xBBF030", VA = "0xBBF030")]
		public bool IsPlanar(out bool xplanar, out bool yplanar, out bool zplanar)
		{
			return default(bool);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xBBF254", Offset = "0xBBF254", VA = "0xBBF254")]
		public bool IsPlanar(CurvyPlane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xBBF418", Offset = "0xBBF418", VA = "0xBBF418")]
		public void MakePlanar(CurvyPlane plane)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xBBF864", Offset = "0xBBF864", VA = "0xBBF864")]
		public void MakePlanar(int axis)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xBBFA1C", Offset = "0xBBFA1C", VA = "0xBBFA1C")]
		public void Subdivide([Optional] CurvySplineSegment fromCP, [Optional] CurvySplineSegment toCP)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xBC00C0", Offset = "0xBC00C0", VA = "0xBC00C0")]
		public void Simplify([Optional] CurvySplineSegment fromCP, [Optional] CurvySplineSegment toCP)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xBC03BC", Offset = "0xBC03BC", VA = "0xBC03BC")]
		public void Equalize([Optional] CurvySplineSegment fromCP, [Optional] CurvySplineSegment toCP)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xBC082C", Offset = "0xBC082C", VA = "0xBC082C")]
		public void Normalize()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xBC09E8", Offset = "0xBC09E8", VA = "0xBC09E8")]
		public Vector3 SetPivot(float xRel = 0f, float yRel = 0f, float zRel = 0f, bool preview = false)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xBC0C48", Offset = "0xBC0C48", VA = "0xBC0C48")]
		public void Flip()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xBC0F34", Offset = "0xBC0F34", VA = "0xBC0F34")]
		public void MoveControlPoints(int startIndex, int count, CurvySplineSegment destCP)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xBC1344", Offset = "0xBC1344", VA = "0xBC1344")]
		public void JoinWith(CurvySplineSegment destCP)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xBC142C", Offset = "0xBC142C", VA = "0xBC142C")]
		public CurvySpline Split(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xBC1724", Offset = "0xBC1724", VA = "0xBC1724")]
		public void SetFirstControlPoint(CurvySplineSegment controlPoint)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xBC18BC", Offset = "0xBC18BC", VA = "0xBC18BC")]
		public bool IsControlPointAnOrientationAnchor(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xBC1A0C", Offset = "0xBC1A0C", VA = "0xBC1A0C")]
		public bool CanControlPointHaveFollowUp(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xBBBFAC", Offset = "0xBBBFAC", VA = "0xBBBFAC")]
		public short GetControlPointIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xBC16E0", Offset = "0xBC16E0", VA = "0xBC16E0")]
		public short GetSegmentIndex(CurvySplineSegment segment)
		{
			return default(short);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xBBAA1C", Offset = "0xBBAA1C", VA = "0xBBAA1C")]
		[CanBeNull]
		public CurvySplineSegment GetNextControlPoint(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xBC1A50", Offset = "0xBC1A50", VA = "0xBC1A50")]
		[CanBeNull]
		public short GetNextControlPointIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xBC1A94", Offset = "0xBC1A94", VA = "0xBC1A94")]
		[CanBeNull]
		public CurvySplineSegment GetNextControlPointUsingFollowUp(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xBBA970", Offset = "0xBBA970", VA = "0xBBA970")]
		[CanBeNull]
		public CurvySplineSegment GetPreviousControlPoint(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xBC1BA0", Offset = "0xBC1BA0", VA = "0xBC1BA0")]
		[CanBeNull]
		public short GetPreviousControlPointIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xBC1BE4", Offset = "0xBC1BE4", VA = "0xBC1BE4")]
		[CanBeNull]
		public CurvySplineSegment GetPreviousControlPointUsingFollowUp(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xBBCED4", Offset = "0xBBCED4", VA = "0xBBCED4")]
		[CanBeNull]
		public CurvySplineSegment GetNextSegment(CurvySplineSegment segment)
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xBC1CF0", Offset = "0xBC1CF0", VA = "0xBC1CF0")]
		[CanBeNull]
		public CurvySplineSegment GetPreviousSegment(CurvySplineSegment segment)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xBBB4A4", Offset = "0xBBB4A4", VA = "0xBBB4A4")]
		public bool IsControlPointASegment(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xBC19C8", Offset = "0xBC19C8", VA = "0xBC19C8")]
		public bool IsControlPointVisible(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xBC1D9C", Offset = "0xBC1D9C", VA = "0xBC1D9C")]
		public short GetControlPointOrientationAnchorIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xBC1DE0", Offset = "0xBC1DE0", VA = "0xBC1DE0")]
		public void SetFromString(string fieldAndValue)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xBC23BC", Offset = "0xBC23BC", VA = "0xBC23BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xBC2460", Offset = "0xBC2460", VA = "0xBC2460")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xBBA098", Offset = "0xBBA098", VA = "0xBBA098")]
		public void Start()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xBC24F4", Offset = "0xBC24F4", VA = "0xBC24F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xBC24FC", Offset = "0xBC24FC", VA = "0xBC24FC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xBC268C", Offset = "0xBC268C", VA = "0xBC268C", Slot = "4")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xBC2838", Offset = "0xBC2838", VA = "0xBC2838")]
		private void Update()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xBC2B74", Offset = "0xBC2B74", VA = "0xBC2B74")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xBC2BB8", Offset = "0xBC2BB8", VA = "0xBC2BB8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xBC24B4", Offset = "0xBC24B4", VA = "0xBC24B4")]
		private void Initialize()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xBC2878", Offset = "0xBC2878", VA = "0xBC2878")]
		private void doUpdate()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xBB8EB4", Offset = "0xBB8EB4", VA = "0xBB8EB4")]
		private bool canHaveManualEndCP()
		{
			return default(bool);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xBBE6DC", Offset = "0xBBE6DC", VA = "0xBBE6DC")]
		private void SetDirty(CurvySplineSegment controlPoint, SplineDirtyingType dirtyingType, CurvySplineSegment previousControlPoint, CurvySplineSegment nextControlPoint, bool ignoreConnectionOfInputControlPoint)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xBBE634", Offset = "0xBBE634", VA = "0xBBE634")]
		private void SetDirtyingFlags(SplineDirtyingType dirtyingType)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xBC0EC8", Offset = "0xBC0EC8", VA = "0xBC0EC8")]
		private void ReverseControlPoints()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xBC2C74", Offset = "0xBC2C74", VA = "0xBC2C74")]
		private static short GetNextControlPointIndex(short controlPointIndex, bool isSplineClosed, int controlPointsCount)
		{
			return default(short);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xBC2CA4", Offset = "0xBC2CA4", VA = "0xBC2CA4")]
		private static short GetPreviousControlPointIndex(short controlPointIndex, bool isSplineClosed, int controlPointsCount)
		{
			return default(short);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xBC2CD8", Offset = "0xBC2CD8", VA = "0xBC2CD8")]
		private static bool IsControlPointASegment(int controlPointIndex, int controlPointCount, bool isClosed, bool notAutoEndTangentsAndIsCatmullRomOrTCB)
		{
			return default(bool);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xBBEDDC", Offset = "0xBBEDDC", VA = "0xBBEDDC")]
		private void AddControlPoint(CurvySplineSegment item)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xBC1170", Offset = "0xBC1170", VA = "0xBC1170")]
		private void InsertControlPoint(int index, CurvySplineSegment item)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xBBC858", Offset = "0xBBC858", VA = "0xBBC858")]
		private void RemoveControlPoint(CurvySplineSegment item)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xBBC6D8", Offset = "0xBBC6D8", VA = "0xBBC6D8")]
		private void ClearControlPoints()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xBB8A28", Offset = "0xBB8A28", VA = "0xBB8A28")]
		internal void InvalidateControlPointsRelationshipCacheINTERNAL()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xBB970C", Offset = "0xBB970C", VA = "0xBB970C")]
		private void RebuildControlPointsRelationshipCache(bool fixNonCoherentControlPoints)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xBBD67C", Offset = "0xBBD67C", VA = "0xBBD67C")]
		private void ProcessDirtyControlPoints()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xBC2FF4", Offset = "0xBC2FF4", VA = "0xBC2FF4")]
		private void PrepareThreadCompatibleData()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xBC2D10", Offset = "0xBC2D10", VA = "0xBC2D10")]
		private void FillDirtyCpsExtendedList()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xBB6224", Offset = "0xBB6224", VA = "0xBB6224")]
		internal void NotifyMetaDataModification()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xBC31C0", Offset = "0xBC31C0", VA = "0xBC31C0")]
		private void SyncHierarchyFromSpline(bool renameControlPoints = true)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xBC2BFC", Offset = "0xBC2BFC", VA = "0xBC2BFC")]
		private void UpdatedLastProcessedGlobalCoordinates()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xBBBFF0", Offset = "0xBBBFF0", VA = "0xBBBFF0")]
		private CurvySplineSegment InsertAt(CurvySplineSegment controlPoint, Vector3 position, int insertionIndex, CurvyControlPointEventArgs.ModeEnum insertionMode, bool skipRefreshingAndEvents, Space space)
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xBBE5CC", Offset = "0xBBE5CC", VA = "0xBBE5CC")]
		private CurvySplineEventArgs OnRefreshEvent(CurvySplineEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xBBB8B4", Offset = "0xBBB8B4", VA = "0xBBB8B4")]
		private CurvyControlPointEventArgs OnBeforeControlPointAddEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xBBB9E0", Offset = "0xBBB9E0", VA = "0xBBB9E0")]
		private CurvyControlPointEventArgs OnAfterControlPointAddEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xBBC670", Offset = "0xBBC670", VA = "0xBBC670")]
		private CurvyControlPointEventArgs OnBeforeControlPointDeleteEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xBBBA48", Offset = "0xBBBA48", VA = "0xBBBA48")]
		private CurvySplineEventArgs OnAfterControlPointChangesEvent(CurvySplineEventArgs e)
		{
			return null;
		}
	}
	[Token(Token = "0x2000092")]
	public enum SplineDirtyingType
	{
		[Token(Token = "0x40001B0")]
		OrientationOnly,
		[Token(Token = "0x40001B1")]
		Everything
	}
	[Token(Token = "0x2000093")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4FF990", Offset = "0x4FF990")]
	public class CurvySplineSegment : MonoBehaviour, IPoolable
	{
		[Token(Token = "0x2000094")]
		internal readonly struct ControlPointExtrinsicProperties : IEquatable<ControlPointExtrinsicProperties>
		{
			[Token(Token = "0x40001DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly bool isVisible;

			[Token(Token = "0x40001E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			private readonly short segmentIndex;

			[Token(Token = "0x40001E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private readonly short controlPointIndex;

			[Token(Token = "0x40001E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			private readonly short nextControlPointIndex;

			[Token(Token = "0x40001E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly short previousControlPointIndex;

			[Token(Token = "0x40001E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			private readonly bool previousControlPointIsSegment;

			[Token(Token = "0x40001E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
			private readonly bool nextControlPointIsSegment;

			[Token(Token = "0x40001E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private readonly bool canHaveFollowUp;

			[Token(Token = "0x40001E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			private readonly short orientationAnchorIndex;

			[Token(Token = "0x170000C2")]
			internal bool IsVisible
			{
				[Token(Token = "0x6000404")]
				[Address(RVA = "0xE7E680", Offset = "0xE7E680", VA = "0xE7E680")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000C3")]
			internal short SegmentIndex
			{
				[Token(Token = "0x6000405")]
				[Address(RVA = "0xE7E688", Offset = "0xE7E688", VA = "0xE7E688")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x170000C4")]
			internal short ControlPointIndex
			{
				[Token(Token = "0x6000406")]
				[Address(RVA = "0xE7E690", Offset = "0xE7E690", VA = "0xE7E690")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x170000C5")]
			internal short NextControlPointIndex
			{
				[Token(Token = "0x6000407")]
				[Address(RVA = "0xE7E698", Offset = "0xE7E698", VA = "0xE7E698")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x170000C6")]
			internal short PreviousControlPointIndex
			{
				[Token(Token = "0x6000408")]
				[Address(RVA = "0xE7E6A0", Offset = "0xE7E6A0", VA = "0xE7E6A0")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x170000C7")]
			internal bool PreviousControlPointIsSegment
			{
				[Token(Token = "0x6000409")]
				[Address(RVA = "0xE7E6A8", Offset = "0xE7E6A8", VA = "0xE7E6A8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000C8")]
			internal bool NextControlPointIsSegment
			{
				[Token(Token = "0x600040A")]
				[Address(RVA = "0xE7E6B0", Offset = "0xE7E6B0", VA = "0xE7E6B0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000C9")]
			internal bool CanHaveFollowUp
			{
				[Token(Token = "0x600040B")]
				[Address(RVA = "0xE7E6B8", Offset = "0xE7E6B8", VA = "0xE7E6B8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000CA")]
			internal bool IsSegment
			{
				[Token(Token = "0x600040C")]
				[Address(RVA = "0xE7E6C0", Offset = "0xE7E6C0", VA = "0xE7E6C0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000CB")]
			internal short OrientationAnchorIndex
			{
				[Token(Token = "0x600040D")]
				[Address(RVA = "0xE7E6D0", Offset = "0xE7E6D0", VA = "0xE7E6D0")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x600040E")]
			[Address(RVA = "0xE7E6D8", Offset = "0xE7E6D8", VA = "0xE7E6D8")]
			internal ControlPointExtrinsicProperties(bool isVisible, short segmentIndex, short controlPointIndex, short previousControlPointIndex, short nextControlPointIndex, bool previousControlPointIsSegment, bool nextControlPointIsSegment, bool canHaveFollowUp, short orientationAnchorIndex)
			{
			}

			[Token(Token = "0x600040F")]
			[Address(RVA = "0xE7E718", Offset = "0xE7E718", VA = "0xE7E718", Slot = "4")]
			public bool Equals(ControlPointExtrinsicProperties other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000410")]
			[Address(RVA = "0xE7E7DC", Offset = "0xE7E7DC", VA = "0xE7E7DC", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000411")]
			[Address(RVA = "0xE7E864", Offset = "0xE7E864", VA = "0xE7E864", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000412")]
			[Address(RVA = "0xE7E9B8", Offset = "0xE7E9B8", VA = "0xE7E9B8")]
			public static bool operator ==(ControlPointExtrinsicProperties left, ControlPointExtrinsicProperties right)
			{
				return default(bool);
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0xE7E9E8", Offset = "0xE7E9E8", VA = "0xE7E9E8")]
			public static bool operator !=(ControlPointExtrinsicProperties left, ControlPointExtrinsicProperties right)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000095")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FF9EC", Offset = "0x4FF9EC")]
		private sealed class <>c__DisplayClass102_0
		{
			[Token(Token = "0x40001E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HashSet<UnityEngine.Component> result;

			[Token(Token = "0x6000414")]
			[Address(RVA = "0xE7E614", Offset = "0xE7E614", VA = "0xE7E614")]
			public <>c__DisplayClass102_0()
			{
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0xE7E61C", Offset = "0xE7E61C", VA = "0xE7E61C")]
			internal void <get_MetaDataSet>b__0(CurvyMetadataBase md)
			{
			}
		}

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color GizmoTangentColor;

		[NonSerialized]
		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] Approximation;

		[NonSerialized]
		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float[] ApproximationDistances;

		[NonSerialized]
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3[] ApproximationUp;

		[NonSerialized]
		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3[] ApproximationT;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x502BCC", Offset = "0x502BCC")]
		private float <Length>k__BackingField;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x502BDC", Offset = "0x502BDC")]
		private float <Distance>k__BackingField;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x502BEC", Offset = "0x502BEC")]
		private float <TF>k__BackingField;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x502BFC", Offset = "0x502BFC")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x502BFC", Offset = "0x502BFC")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x502BFC", Offset = "0x502BFC")]
		private bool m_AutoBakeOrientation;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x502CB0", Offset = "0x502CB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x502CB0", Offset = "0x502CB0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x502CB0", Offset = "0x502CB0")]
		[SerializeField]
		private bool m_OrientationAnchor;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x502DA8", Offset = "0x502DA8")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x502DA8", Offset = "0x502DA8")]
		[SerializeField]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x502DA8", Offset = "0x502DA8")]
		private CurvyOrientationSwirl m_Swirl;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x502EB4", Offset = "0x502EB4")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x502EB4", Offset = "0x502EB4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x502EB4", Offset = "0x502EB4")]
		[SerializeField]
		private float m_SwirlTurns;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x503010", Offset = "0x503010")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x503010", Offset = "0x503010")]
		[SerializeField]
		private bool m_AutoHandles;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x503108", Offset = "0x503108")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x503108", Offset = "0x503108")]
		[SerializeField]
		private float m_AutoHandleDistance;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x503200", Offset = "0x503200")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x503200", Offset = "0x503200")]
		private Vector3 m_HandleIn;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x5032B4", Offset = "0x5032B4")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5032B4", Offset = "0x5032B4")]
		private Vector3 m_HandleOut;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x503368", Offset = "0x503368")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x503368", Offset = "0x503368")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x503368", Offset = "0x503368")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x503368", Offset = "0x503368")]
		[AttributeAttribute(Name = "GroupActionAttribute", RVA = "0x503368", Offset = "0x503368")]
		private bool m_OverrideGlobalTension;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x5034E8", Offset = "0x5034E8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5034E8", Offset = "0x5034E8")]
		[SerializeField]
		private bool m_OverrideGlobalContinuity;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x503574", Offset = "0x503574")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x503574", Offset = "0x503574")]
		private bool m_OverrideGlobalBias;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5035F8", Offset = "0x5035F8")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5035F8", Offset = "0x5035F8")]
		private bool m_SynchronizeTCB;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x503668", Offset = "0x503668")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x503668", Offset = "0x503668")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x503668", Offset = "0x503668")]
		private float m_StartTension;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x503774", Offset = "0x503774")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x503774", Offset = "0x503774")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x503774", Offset = "0x503774")]
		private float m_EndTension;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5038BC", Offset = "0x5038BC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x5038BC", Offset = "0x5038BC")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x5038BC", Offset = "0x5038BC")]
		[SerializeField]
		private float m_StartContinuity;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x5039C8", Offset = "0x5039C8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5039C8", Offset = "0x5039C8")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x5039C8", Offset = "0x5039C8")]
		private float m_EndContinuity;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x503B10", Offset = "0x503B10")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x503B10", Offset = "0x503B10")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x503B10", Offset = "0x503B10")]
		private float m_StartBias;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x503C1C", Offset = "0x503C1C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x503C1C", Offset = "0x503C1C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x503C1C", Offset = "0x503C1C")]
		private float m_EndBias;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[HideInInspector]
		private CurvySplineSegment m_FollowUp;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[HideInInspector]
		private ConnectionHeadingEnum m_FollowUpHeading;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		[HideInInspector]
		private bool m_ConnectionSyncPosition;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		[SerializeField]
		[HideInInspector]
		private bool m_ConnectionSyncRotation;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[HideInInspector]
		private CurvyConnection m_Connection;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int cacheSize;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform cachedTransform;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 threadSafeLocalPosition;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Vector3 threadSafeNextCpLocalPosition;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 threadSafePreviousCpLocalPosition;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Quaternion threadSafeLocalRotation;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private CurvySplineSegment cachedNextControlPoint;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private CurvySpline mSpline;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private float mStepSize;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Bounds? mBounds;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private readonly HashSet<CurvyMetadataBase> mMetadata;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 lastProcessedLocalPosition;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Quaternion lastProcessedLocalRotation;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private ControlPointExtrinsicProperties extrinsicPropertiesINTERNAL;

		[Token(Token = "0x17000098")]
		public bool AutoBakeOrientation
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0xEAF5B0", Offset = "0xEAF5B0", VA = "0xEAF5B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600037B")]
			[Address(RVA = "0xEAF5B8", Offset = "0xEAF5B8", VA = "0xEAF5B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public bool SerializedOrientationAnchor
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0xEAF5D8", Offset = "0xEAF5D8", VA = "0xEAF5D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600037D")]
			[Address(RVA = "0xEAF5E0", Offset = "0xEAF5E0", VA = "0xEAF5E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public CurvyOrientationSwirl Swirl
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0xEAF64C", Offset = "0xEAF64C", VA = "0xEAF64C")]
			get
			{
				return default(CurvyOrientationSwirl);
			}
			[Token(Token = "0x600037F")]
			[Address(RVA = "0xEAF654", Offset = "0xEAF654", VA = "0xEAF654")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public float SwirlTurns
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0xEAF690", Offset = "0xEAF690", VA = "0xEAF690")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000381")]
			[Address(RVA = "0xEAF698", Offset = "0xEAF698", VA = "0xEAF698")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public Vector3 HandleIn
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0xEAF6D0", Offset = "0xEAF6D0", VA = "0xEAF6D0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000383")]
			[Address(RVA = "0xEAF6DC", Offset = "0xEAF6DC", VA = "0xEAF6DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public Vector3 HandleOut
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0xEAF76C", Offset = "0xEAF76C", VA = "0xEAF76C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000385")]
			[Address(RVA = "0xEAF778", Offset = "0xEAF778", VA = "0xEAF778")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public Vector3 HandleInPosition
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0xEAF808", Offset = "0xEAF808", VA = "0xEAF808")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000387")]
			[Address(RVA = "0xEAF88C", Offset = "0xEAF88C", VA = "0xEAF88C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public Vector3 HandleOutPosition
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0xEAF910", Offset = "0xEAF910", VA = "0xEAF910")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000389")]
			[Address(RVA = "0xEAF994", Offset = "0xEAF994", VA = "0xEAF994")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public bool AutoHandles
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0xEAFA18", Offset = "0xEAFA18", VA = "0xEAFA18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600038B")]
			[Address(RVA = "0xEAFA20", Offset = "0xEAFA20", VA = "0xEAFA20")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public float AutoHandleDistance
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0xEAFBE0", Offset = "0xEAFBE0", VA = "0xEAFBE0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600038D")]
			[Address(RVA = "0xEAFBE8", Offset = "0xEAFBE8", VA = "0xEAFBE8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public bool SynchronizeTCB
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0xEAFC4C", Offset = "0xEAFC4C", VA = "0xEAFC4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600038F")]
			[Address(RVA = "0xEAFC54", Offset = "0xEAFC54", VA = "0xEAFC54")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public bool OverrideGlobalTension
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0xEAFC9C", Offset = "0xEAFC9C", VA = "0xEAFC9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000391")]
			[Address(RVA = "0xEAFCA4", Offset = "0xEAFCA4", VA = "0xEAFCA4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public bool OverrideGlobalContinuity
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0xEAFCEC", Offset = "0xEAFCEC", VA = "0xEAFCEC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000393")]
			[Address(RVA = "0xEAFCF4", Offset = "0xEAFCF4", VA = "0xEAFCF4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public bool OverrideGlobalBias
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0xEAFD3C", Offset = "0xEAFD3C", VA = "0xEAFD3C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000395")]
			[Address(RVA = "0xEAFD44", Offset = "0xEAFD44", VA = "0xEAFD44")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public float StartTension
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0xEAFD8C", Offset = "0xEAFD8C", VA = "0xEAFD8C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000397")]
			[Address(RVA = "0xEAFD94", Offset = "0xEAFD94", VA = "0xEAFD94")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public float StartContinuity
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0xEAFDCC", Offset = "0xEAFDCC", VA = "0xEAFDCC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000399")]
			[Address(RVA = "0xEAFDD4", Offset = "0xEAFDD4", VA = "0xEAFDD4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public float StartBias
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0xEAFE0C", Offset = "0xEAFE0C", VA = "0xEAFE0C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600039B")]
			[Address(RVA = "0xEAFE14", Offset = "0xEAFE14", VA = "0xEAFE14")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public float EndTension
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0xEAFE4C", Offset = "0xEAFE4C", VA = "0xEAFE4C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600039D")]
			[Address(RVA = "0xEAFE54", Offset = "0xEAFE54", VA = "0xEAFE54")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public float EndContinuity
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0xEAFE8C", Offset = "0xEAFE8C", VA = "0xEAFE8C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600039F")]
			[Address(RVA = "0xEAFE94", Offset = "0xEAFE94", VA = "0xEAFE94")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public float EndBias
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0xEAFECC", Offset = "0xEAFECC", VA = "0xEAFECC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0xEAFED4", Offset = "0xEAFED4", VA = "0xEAFED4")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public CurvySplineSegment FollowUp
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0xEAFF0C", Offset = "0xEAFF0C", VA = "0xEAFF0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0xEAFF14", Offset = "0xEAFF14", VA = "0xEAFF14")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public ConnectionHeadingEnum FollowUpHeading
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0xEB000C", Offset = "0xEB000C", VA = "0xEB000C")]
			get
			{
				return default(ConnectionHeadingEnum);
			}
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0xEB0174", Offset = "0xEB0174", VA = "0xEB0174")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public bool ConnectionSyncPosition
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0xEB0268", Offset = "0xEB0268", VA = "0xEB0268")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0xEB0270", Offset = "0xEB0270", VA = "0xEB0270")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public bool ConnectionSyncRotation
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0xEB0290", Offset = "0xEB0290", VA = "0xEB0290")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0xEB0298", Offset = "0xEB0298", VA = "0xEB0298")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public CurvyConnection Connection
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0xEB02B8", Offset = "0xEB02B8", VA = "0xEB02B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0xEB02C0", Offset = "0xEB02C0", VA = "0xEB02C0")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public int CacheSize
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0xEB0498", Offset = "0xEB0498", VA = "0xEB0498")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0xEB04A0", Offset = "0xEB04A0", VA = "0xEB04A0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public Bounds Bounds
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0xEB04A8", Offset = "0xEB04A8", VA = "0xEB04A8")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x170000B3")]
		public float Length
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0xEB071C", Offset = "0xEB071C", VA = "0xEB071C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50DF5C", Offset = "0x50DF5C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0xEB0724", Offset = "0xEB0724", VA = "0xEB0724")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50DF6C", Offset = "0x50DF6C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public float Distance
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0xEB072C", Offset = "0xEB072C", VA = "0xEB072C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50DF7C", Offset = "0x50DF7C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0xEB0734", Offset = "0xEB0734", VA = "0xEB0734")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50DF8C", Offset = "0x50DF8C")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public float TF
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0xEB073C", Offset = "0xEB073C", VA = "0xEB073C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50DF9C", Offset = "0x50DF9C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0xEB0744", Offset = "0xEB0744", VA = "0xEB0744")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50DFAC", Offset = "0x50DFAC")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public bool IsFirstControlPoint
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0xEB074C", Offset = "0xEB074C", VA = "0xEB074C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B7")]
		public bool IsLastControlPoint
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0xEB077C", Offset = "0xEB077C", VA = "0xEB077C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x50E954", Offset = "0x50E954")]
		public HashSet<UnityEngine.Component> MetaDataSet
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0xEB07D4", Offset = "0xEB07D4", VA = "0xEB07D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		public HashSet<CurvyMetadataBase> Metadata
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0xEB0910", Offset = "0xEB0910", VA = "0xEB0910")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		public CurvySpline Spline
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0xEB0918", Offset = "0xEB0918", VA = "0xEB0918")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BB")]
		public bool HasUnprocessedLocalPosition
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0xEB0920", Offset = "0xEB0920", VA = "0xEB0920")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BC")]
		public bool HasUnprocessedLocalOrientation
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0xEB096C", Offset = "0xEB096C", VA = "0xEB096C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BD")]
		public bool OrientatinInfluencesSpline
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0xEB09B0", Offset = "0xEB09B0", VA = "0xEB09B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BE")]
		private CurvyInterpolation interpolation
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xEB3D58", Offset = "0xEB3D58", VA = "0xEB3D58")]
			get
			{
				return default(CurvyInterpolation);
			}
		}

		[Token(Token = "0x170000BF")]
		private bool isDynamicOrientation
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0xEB3DE0", Offset = "0xEB3DE0", VA = "0xEB3DE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C0")]
		private bool IsOrientationAnchorEditable
		{
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0xEB3E70", Offset = "0xEB3E70", VA = "0xEB3E70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C1")]
		private bool canHaveSwirl
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0xEB3F74", Offset = "0xEB3F74", VA = "0xEB3F74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xEB0A5C", Offset = "0xEB0A5C", VA = "0xEB0A5C")]
		public void SetBezierHandleIn(Vector3 position, Space space = Space.Self, CurvyBezierModeEnum mode = CurvyBezierModeEnum.None)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xEB0E4C", Offset = "0xEB0E4C", VA = "0xEB0E4C")]
		public void SetBezierHandleOut(Vector3 position, Space space = Space.Self, CurvyBezierModeEnum mode = CurvyBezierModeEnum.None)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xEB1234", Offset = "0xEB1234", VA = "0xEB1234")]
		public void SetBezierHandles(float distanceFrag = -1f, bool setIn = true, bool setOut = true, bool noDirtying = false)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xEB14E0", Offset = "0xEB14E0", VA = "0xEB14E0")]
		public void SetBezierHandles(float distanceFrag, Vector3 p, Vector3 n, bool setIn = true, bool setOut = true, bool noDirtying = false)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xEB1668", Offset = "0xEB1668", VA = "0xEB1668")]
		public void SetFollowUp(CurvySplineSegment target, ConnectionHeadingEnum heading = ConnectionHeadingEnum.Auto)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xEB1830", Offset = "0xEB1830", VA = "0xEB1830")]
		public void Disconnect()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xEB1838", Offset = "0xEB1838", VA = "0xEB1838")]
		public void Disconnect(bool destroyEmptyConnection)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xEB1900", Offset = "0xEB1900", VA = "0xEB1900")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x50DFBC", Offset = "0x50DFBC")]
		public void ResetConnectionRelatedData()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xEB1954", Offset = "0xEB1954", VA = "0xEB1954")]
		public Vector3 Interpolate(float localF, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xEB1D14", Offset = "0xEB1D14", VA = "0xEB1D14")]
		public Vector3 InterpolateFast(float localF, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xEB1E70", Offset = "0xEB1E70", VA = "0xEB1E70")]
		public Vector3 GetTangent(float localF, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xEB1ED4", Offset = "0xEB1ED4", VA = "0xEB1ED4")]
		public Vector3 GetTangent(float localF, Vector3 position, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xEB2078", Offset = "0xEB2078", VA = "0xEB2078")]
		public Vector3 GetTangentFast(float localF, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xEB2140", Offset = "0xEB2140", VA = "0xEB2140")]
		public void InterpolateAndGetTangent(float localF, out Vector3 position, out Vector3 tangent, Space space = Space.Self)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xEB21C8", Offset = "0xEB21C8", VA = "0xEB21C8")]
		public void InterpolateAndGetTangentFast(float localF, out Vector3 position, out Vector3 tangent, Space space = Space.Self)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xEB2340", Offset = "0xEB2340", VA = "0xEB2340")]
		public Vector3 GetOrientationUpFast(float localF, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xEB2408", Offset = "0xEB2408", VA = "0xEB2408")]
		public Quaternion GetOrientationFast(float localF, bool inverse = false, Space space = Space.Self)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xEB24E0", Offset = "0xEB24E0", VA = "0xEB24E0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x50DFF4", Offset = "0x50DFF4")]
		public Vector3 InterpolateScale(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xEB2624", Offset = "0xEB2624", VA = "0xEB2624")]
		public void ReloadMetaData()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xEB2964", Offset = "0xEB2964", VA = "0xEB2964")]
		public void RegisterMetaData(CurvyMetadataBase metaData)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xEB29D0", Offset = "0xEB29D0", VA = "0xEB29D0")]
		public void UnregisterMetaData(CurvyMetadataBase metaData)
		{
		}

		[Token(Token = "0x60003D2")]
		public T GetMetadata<T>(bool autoCreate = false) where T : CurvyMetadataBase
		{
			return null;
		}

		[Token(Token = "0x60003D3")]
		public U GetInterpolatedMetadata<T, U>(float f) where T : CurvyInterpolatableMetadataBase<U>
		{
			return (U)null;
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xEB2A34", Offset = "0xEB2A34", VA = "0xEB2A34")]
		public void DeleteMetadata()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xEB2AFC", Offset = "0xEB2AFC", VA = "0xEB2AFC")]
		public float GetNearestPointF(Vector3 position, Space space = Space.Self)
		{
			return default(float);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xEB2E24", Offset = "0xEB2E24", VA = "0xEB2E24")]
		public float DistanceToLocalF(float localDistance)
		{
			return default(float);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xEB30C0", Offset = "0xEB30C0", VA = "0xEB30C0")]
		public float LocalFToDistance(float localF)
		{
			return default(float);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xEB3170", Offset = "0xEB3170", VA = "0xEB3170")]
		public float LocalFToTF(float localF)
		{
			return default(float);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xEB3190", Offset = "0xEB3190", VA = "0xEB3190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xEB3260", Offset = "0xEB3260", VA = "0xEB3260")]
		public void BakeOrientationToTransform()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xEB1DDC", Offset = "0xEB1DDC", VA = "0xEB1DDC")]
		public int getApproximationIndexINTERNAL(float localF, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xEB34D8", Offset = "0xEB34D8", VA = "0xEB34D8")]
		public void LinkToSpline(CurvySpline spline)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xEB34E0", Offset = "0xEB34E0", VA = "0xEB34E0")]
		public void UnlinkFromSpline()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xEB34EC", Offset = "0xEB34EC", VA = "0xEB34EC")]
		public void SetLocalPosition(Vector3 newPosition)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xEB36A8", Offset = "0xEB36A8", VA = "0xEB36A8")]
		public void SetPosition(Vector3 value)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xEB3304", Offset = "0xEB3304", VA = "0xEB3304")]
		public void SetLocalRotation(Quaternion value)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xEB3864", Offset = "0xEB3864", VA = "0xEB3864")]
		public void SetRotation(Quaternion value)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xEB3A38", Offset = "0xEB3A38", VA = "0xEB3A38")]
		public static bool CanFollowUpHeadToStart([NotNull] CurvySplineSegment followUp)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xEB3A70", Offset = "0xEB3A70", VA = "0xEB3A70")]
		public static bool CanFollowUpHeadToEnd([NotNull] CurvySplineSegment followUp)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xEB3AA8", Offset = "0xEB3AA8", VA = "0xEB3AA8", Slot = "4")]
		public void OnBeforePush()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xEB3B94", Offset = "0xEB3B94", VA = "0xEB3B94", Slot = "5")]
		public void OnAfterPop()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xEB3C74", Offset = "0xEB3C74", VA = "0xEB3C74")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xEB3D4C", Offset = "0xEB3D4C", VA = "0xEB3D4C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xEB3D50", Offset = "0xEB3D50", VA = "0xEB3D50")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xEB3B98", Offset = "0xEB3B98", VA = "0xEB3B98")]
		public void Reset()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xEB4070", Offset = "0xEB4070", VA = "0xEB4070")]
		internal void SetExtrinsicPropertiesINTERNAL(ControlPointExtrinsicProperties value)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xEB4084", Offset = "0xEB4084", VA = "0xEB4084")]
		internal unsafe ref ControlPointExtrinsicProperties GetExtrinsicPropertiesINTERNAL()
		{
			return ref *(ControlPointExtrinsicProperties*)null;
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xEB271C", Offset = "0xEB271C", VA = "0xEB271C")]
		private void CheckAgainstMetaDataDuplication()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xEB0378", Offset = "0xEB0378", VA = "0xEB0378")]
		private bool SetConnection(CurvyConnection newConnection)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xEB0078", Offset = "0xEB0078", VA = "0xEB0078")]
		private static ConnectionHeadingEnum GetValidateConnectionHeading(ConnectionHeadingEnum connectionHeading, [CanBeNull] CurvySplineSegment followUp)
		{
			return default(ConnectionHeadingEnum);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xEAFA6C", Offset = "0xEAFA6C", VA = "0xEAFA6C")]
		private bool SetAutoHandles(bool newValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xEB2E14", Offset = "0xEB2E14", VA = "0xEB2E14")]
		private float getApproximationLocalF(int idx)
		{
			return default(float);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xEB40F0", Offset = "0xEB40F0", VA = "0xEB40F0")]
		internal void refreshCurveINTERNAL()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xEB46E8", Offset = "0xEB46E8", VA = "0xEB46E8")]
		private float InterpolateBezierSegment(CurvySplineSegment nextControlPoint, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xEB4E7C", Offset = "0xEB4E7C", VA = "0xEB4E7C")]
		private float InterpolateTCBSegment(CurvySplineSegment nextControlPoint, int newCacheSize, float splineTension, float splineContinuity, float splineBias)
		{
			return default(float);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xEB4AA4", Offset = "0xEB4AA4", VA = "0xEB4AA4")]
		private float InterpolateCatmullSegment(CurvySplineSegment nextControlPoint, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xEB53A8", Offset = "0xEB53A8", VA = "0xEB53A8")]
		private float InterpolateLinearSegment(CurvySplineSegment nextControlPoint, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xEB5600", Offset = "0xEB5600", VA = "0xEB5600")]
		internal void refreshOrientationNoneINTERNAL()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xEB5644", Offset = "0xEB5644", VA = "0xEB5644")]
		internal void refreshOrientationStaticINTERNAL()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xEB5978", Offset = "0xEB5978", VA = "0xEB5978")]
		internal void refreshOrientationDynamicINTERNAL(Vector3 initialUp)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xEB5B84", Offset = "0xEB5B84", VA = "0xEB5B84")]
		internal void ClearBoundsINTERNAL()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xEB5798", Offset = "0xEB5798", VA = "0xEB5798")]
		internal Vector3 getOrthoUp0INTERNAL()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xEB5840", Offset = "0xEB5840", VA = "0xEB5840")]
		private Vector3 getOrthoUp1INTERNAL()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xEB5BA4", Offset = "0xEB5BA4", VA = "0xEB5BA4")]
		internal void UnsetFollowUpWithoutDirtyingINTERNAL()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xEB5BD8", Offset = "0xEB5BD8", VA = "0xEB5BD8")]
		internal void PrepareThreadCompatibleDataINTERNAL(bool useFollowUp)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xEB5EC4", Offset = "0xEB5EC4", VA = "0xEB5EC4")]
		public CurvySplineSegment()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public static class CurvySplineSegmentDefaultValues
	{
		[Token(Token = "0x40001E9")]
		public const CurvyOrientationSwirl Swirl = CurvyOrientationSwirl.None;

		[Token(Token = "0x40001EA")]
		public const bool AutoHandles = true;

		[Token(Token = "0x40001EB")]
		public const float AutoHandleDistance = 0.39f;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector3 HandleIn;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly Vector3 HandleOut;
	}
	[Token(Token = "0x2000097")]
	public static class CurvySplineDefaultValues
	{
		[Token(Token = "0x40001EE")]
		public const bool AutoEndTangents = true;

		[Token(Token = "0x40001EF")]
		public const CurvyOrientation Orientation = CurvyOrientation.Dynamic;

		[Token(Token = "0x40001F0")]
		public const float AutoHandleDistance = 0.39f;

		[Token(Token = "0x40001F1")]
		public const int CacheDensity = 50;

		[Token(Token = "0x40001F2")]
		public const float MaxPointsPerUnit = 8f;

		[Token(Token = "0x40001F3")]
		public const bool UsePooling = true;

		[Token(Token = "0x40001F4")]
		public const CurvyUpdateMethod UpdateIn = CurvyUpdateMethod.Update;

		[Token(Token = "0x40001F5")]
		public const bool CheckTransform = true;
	}
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4FF9FC", Offset = "0x4FF9FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4FF9FC", Offset = "0x4FF9FC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4FF9FC", Offset = "0x4FF9FC")]
	public class CurvyUISpline : CurvySpline
	{
		[Token(Token = "0x6000417")]
		[Address(RVA = "0xEB6154", Offset = "0xEB6154", VA = "0xEB6154")]
		public static CurvyUISpline CreateUISpline(string gameObjectName = "Curvy UI Spline")
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xEB6300", Offset = "0xEB6300", VA = "0xEB6300", Slot = "4")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xEB62BC", Offset = "0xEB62BC", VA = "0xEB62BC")]
		private void SetupUISpline()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xEB6328", Offset = "0xEB6328", VA = "0xEB6328")]
		public CurvyUISpline()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.ThirdParty.LibTessDotNet
{
	[Token(Token = "0x2000099")]
	internal class Dict<TValue> where TValue : class
	{
		[Token(Token = "0x200009A")]
		public class Node
		{
			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TValue _key;

			[Token(Token = "0x40001F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Node _prev;

			[Token(Token = "0x40001FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Node _next;

			[Token(Token = "0x170000CC")]
			public TValue Key
			{
				[Token(Token = "0x6000421")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CD")]
			public Node Prev
			{
				[Token(Token = "0x6000422")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			public Node Next
			{
				[Token(Token = "0x6000423")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000424")]
			public Node()
			{
			}
		}

		[Token(Token = "0x200009B")]
		public delegate bool LessOrEqual(TValue lhs, TValue rhs);

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LessOrEqual _leq;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Node _head;

		[Token(Token = "0x600041B")]
		public Dict(LessOrEqual leq)
		{
		}

		[Token(Token = "0x600041C")]
		public Node Insert(TValue key)
		{
			return null;
		}

		[Token(Token = "0x600041D")]
		public Node InsertBefore(Node node, TValue key)
		{
			return null;
		}

		[Token(Token = "0x600041E")]
		public Node Find(TValue key)
		{
			return null;
		}

		[Token(Token = "0x600041F")]
		public Node Min()
		{
			return null;
		}

		[Token(Token = "0x6000420")]
		public void Remove(Node node)
		{
		}
	}
	[Token(Token = "0x200009C")]
	internal static class Geom
	{
		[Token(Token = "0x6000429")]
		[Address(RVA = "0xEBC614", Offset = "0xEBC614", VA = "0xEBC614")]
		public static bool IsWindingInside(WindingRule rule, int n)
		{
			return default(bool);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xEBC6C0", Offset = "0xEBC6C0", VA = "0xEBC6C0")]
		public static bool VertCCW(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(bool);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xEBC714", Offset = "0xEBC714", VA = "0xEBC714")]
		public static bool VertEq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xEBC758", Offset = "0xEBC758", VA = "0xEBC758")]
		public static bool VertLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xEBC7A8", Offset = "0xEBC7A8", VA = "0xEBC7A8")]
		public static float EdgeEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xEBC81C", Offset = "0xEBC81C", VA = "0xEBC81C")]
		public static float EdgeSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xEBC880", Offset = "0xEBC880", VA = "0xEBC880")]
		public static bool TransLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xEBC8D0", Offset = "0xEBC8D0", VA = "0xEBC8D0")]
		public static float TransEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xEBC944", Offset = "0xEBC944", VA = "0xEBC944")]
		public static float TransSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xEBC9A8", Offset = "0xEBC9A8", VA = "0xEBC9A8")]
		public static bool EdgeGoesLeft(MeshUtils.Edge e)
		{
			return default(bool);
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xEBC9D8", Offset = "0xEBC9D8", VA = "0xEBC9D8")]
		public static bool EdgeGoesRight(MeshUtils.Edge e)
		{
			return default(bool);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xEBCA0C", Offset = "0xEBCA0C", VA = "0xEBCA0C")]
		public static float VertL1dist(MeshUtils.Vertex u, MeshUtils.Vertex v)
		{
			return default(float);
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xEBCAA4", Offset = "0xEBCAA4", VA = "0xEBCAA4")]
		public static void AddWinding(MeshUtils.Edge eDst, MeshUtils.Edge eSrc)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xEBCAF0", Offset = "0xEBCAF0", VA = "0xEBCAF0")]
		public static float Interpolate(float a, float x, float b, float y)
		{
			return default(float);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xEBCB4C", Offset = "0xEBCB4C", VA = "0xEBCB4C")]
		private static void Swap(ref MeshUtils.Vertex a, ref MeshUtils.Vertex b)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xEBCB84", Offset = "0xEBCB84", VA = "0xEBCB84")]
		public static void EdgeIntersect(MeshUtils.Vertex o1, MeshUtils.Vertex d1, MeshUtils.Vertex o2, MeshUtils.Vertex d2, MeshUtils.Vertex v)
		{
		}
	}
	[Token(Token = "0x200009D")]
	internal class LTMesh : MeshUtils.Pooled<LTMesh>
	{
		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal MeshUtils.Vertex _vHead;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal MeshUtils.Face _fHead;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal MeshUtils.Edge _eHead;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal MeshUtils.Edge _eHeadSym;

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xBF69E0", Offset = "0xBF69E0", VA = "0xBF69E0")]
		public LTMesh()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xBF6C3C", Offset = "0xBF6C3C", VA = "0xBF6C3C", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xBF6C90", Offset = "0xBF6C90", VA = "0xBF6C90", Slot = "5")]
		public override void OnFree()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xBF6DA4", Offset = "0xBF6DA4", VA = "0xBF6DA4")]
		public MeshUtils.Edge MakeEdge()
		{
			return null;
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xBF7178", Offset = "0xBF7178", VA = "0xBF7178")]
		public void Splice(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xBF7454", Offset = "0xBF7454", VA = "0xBF7454")]
		public void Delete(MeshUtils.Edge eDel)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xBF7684", Offset = "0xBF7684", VA = "0xBF7684")]
		public MeshUtils.Edge AddEdgeVertex(MeshUtils.Edge eOrg)
		{
			return null;
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xBF7720", Offset = "0xBF7720", VA = "0xBF7720")]
		public MeshUtils.Edge SplitEdge(MeshUtils.Edge eOrg)
		{
			return null;
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xBF77F4", Offset = "0xBF77F4", VA = "0xBF77F4")]
		public MeshUtils.Edge Connect(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
			return null;
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xBF78FC", Offset = "0xBF78FC", VA = "0xBF78FC")]
		public void ZapFace(MeshUtils.Face fZap)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xBF7A60", Offset = "0xBF7A60", VA = "0xBF7A60")]
		public void MergeConvexFaces(int maxVertsPerFace)
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xBF7BCC", Offset = "0xBF7BCC", VA = "0xBF7BCC")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x50E02C", Offset = "0x50E02C")]
		public void Check()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x4FFAA8", Offset = "0x4FFAA8")]
	public struct Vec3
	{
		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vec3 Zero;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float X;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Y;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float Z;

		[Token(Token = "0x170000CF")]
		public float Item
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0xE77FB0", Offset = "0xE77FB0", VA = "0xE77FB0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000446")]
			[Address(RVA = "0xE77B24", Offset = "0xE77B24", VA = "0xE77B24")]
			set
			{
			}
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xE779EC", Offset = "0xE779EC", VA = "0xE779EC")]
		public static void Sub(ref Vec3 lhs, ref Vec3 rhs, out Vec3 result)
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xE77CA0", Offset = "0xE77CA0", VA = "0xE77CA0")]
		public static void Neg(ref Vec3 v)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xE78018", Offset = "0xE78018", VA = "0xE78018")]
		public static void Dot(ref Vec3 u, ref Vec3 v, out float dot)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xE7D088", Offset = "0xE7D088", VA = "0xE7D088")]
		public static void Normalize(ref Vec3 v)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xE77A20", Offset = "0xE77A20", VA = "0xE77A20")]
		public static int LongAxis(ref Vec3 v)
		{
			return default(int);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xE7D13C", Offset = "0xE7D13C", VA = "0xE7D13C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200009F")]
	internal static class MeshUtils
	{
		[Token(Token = "0x20000A0")]
		public abstract class Pooled<T> where T : Pooled<T>, new()
		{
			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static Stack<T> _stack;

			[Token(Token = "0x6000456")]
			public abstract void Reset();

			[Token(Token = "0x6000457")]
			public virtual void OnFree()
			{
			}

			[Token(Token = "0x6000458")]
			public static T Create()
			{
				return null;
			}

			[Token(Token = "0x6000459")]
			public void Free()
			{
			}

			[Token(Token = "0x600045A")]
			protected Pooled()
			{
			}
		}

		[Token(Token = "0x20000A1")]
		public class Vertex : Pooled<Vertex>
		{
			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Vertex _prev;

			[Token(Token = "0x4000206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Vertex _next;

			[Token(Token = "0x4000207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _anEdge;

			[Token(Token = "0x4000208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Vec3 _coords;

			[Token(Token = "0x4000209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal float _s;

			[Token(Token = "0x400020A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal float _t;

			[Token(Token = "0x400020B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal PQHandle _pqHandle;

			[Token(Token = "0x400020C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal int _n;

			[Token(Token = "0x400020D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal object _data;

			[Token(Token = "0x600045B")]
			[Address(RVA = "0xE7EE5C", Offset = "0xE7EE5C", VA = "0xE7EE5C", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0xE7EF14", Offset = "0xE7EF14", VA = "0xE7EF14")]
			public Vertex()
			{
			}
		}

		[Token(Token = "0x20000A2")]
		public class Face : Pooled<Face>
		{
			[Token(Token = "0x400020E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Face _prev;

			[Token(Token = "0x400020F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Face _next;

			[Token(Token = "0x4000210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _anEdge;

			[Token(Token = "0x4000211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Face _trail;

			[Token(Token = "0x4000212")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal int _n;

			[Token(Token = "0x4000213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal bool _marked;

			[Token(Token = "0x4000214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
			internal bool _inside;

			[Token(Token = "0x170000D0")]
			internal int VertsCount
			{
				[Token(Token = "0x600045D")]
				[Address(RVA = "0xE7ED7C", Offset = "0xE7ED7C", VA = "0xE7ED7C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x600045E")]
			[Address(RVA = "0xE7EDB0", Offset = "0xE7EDB0", VA = "0xE7EDB0", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0xE7EE10", Offset = "0xE7EE10", VA = "0xE7EE10")]
			public Face()
			{
			}
		}

		[Token(Token = "0x20000A3")]
		public struct EdgePair
		{
			[Token(Token = "0x4000215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Edge _e;

			[Token(Token = "0x4000216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Edge _eSym;

			[Token(Token = "0x6000460")]
			[Address(RVA = "0xE7ECB4", Offset = "0xE7ECB4", VA = "0xE7ECB4")]
			public static EdgePair Create()
			{
				return default(EdgePair);
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0xE7EC34", Offset = "0xE7EC34", VA = "0xE7EC34")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x20000A4")]
		public class Edge : Pooled<Edge>
		{
			[Token(Token = "0x4000217")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal EdgePair _pair;

			[Token(Token = "0x4000218")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _next;

			[Token(Token = "0x4000219")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Edge _Sym;

			[Token(Token = "0x400021A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Edge _Onext;

			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Edge _Lnext;

			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal Vertex _Org;

			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal Face _Lface;

			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal Tess.ActiveRegion _activeRegion;

			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal int _winding;

			[Token(Token = "0x170000D1")]
			internal Face _Rface
			{
				[Token(Token = "0x6000462")]
				[Address(RVA = "0xE75C48", Offset = "0xE75C48", VA = "0xE75C48")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000463")]
				[Address(RVA = "0xE7EA1C", Offset = "0xE7EA1C", VA = "0xE7EA1C")]
				set
				{
				}
			}

			[Token(Token = "0x170000D2")]
			internal Vertex _Dst
			{
				[Token(Token = "0x6000464")]
				[Address(RVA = "0xE74BA8", Offset = "0xE74BA8", VA = "0xE74BA8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000465")]
				[Address(RVA = "0xE7EA38", Offset = "0xE7EA38", VA = "0xE7EA38")]
				set
				{
				}
			}

			[Token(Token = "0x170000D3")]
			internal Edge _Oprev
			{
				[Token(Token = "0x6000466")]
				[Address(RVA = "0xE750C4", Offset = "0xE750C4", VA = "0xE750C4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000467")]
				[Address(RVA = "0xE7EA54", Offset = "0xE7EA54", VA = "0xE7EA54")]
				set
				{
				}
			}

			[Token(Token = "0x170000D4")]
			internal Edge _Lprev
			{
				[Token(Token = "0x6000468")]
				[Address(RVA = "0xE750A8", Offset = "0xE750A8", VA = "0xE750A8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000469")]
				[Address(RVA = "0xE7EA70", Offset = "0xE7EA70", VA = "0xE7EA70")]
				set
				{
				}
			}

			[Token(Token = "0x170000D5")]
			internal Edge _Dprev
			{
				[Token(Token = "0x600046A")]
				[Address(RVA = "0xE7EA8C", Offset = "0xE7EA8C", VA = "0xE7EA8C")]
				get
				{
					return null;
				}
				[Token(Token = "0x600046B")]
				[Address(RVA = "0xE7EAA8", Offset = "0xE7EAA8", VA = "0xE7EAA8")]
				set
				{
				}
			}

			[Token(Token = "0x170000D6")]
			internal Edge _Rprev
			{
				[Token(Token = "0x600046C")]
				[Address(RVA = "0xE752B4", Offset = "0xE752B4", VA = "0xE752B4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600046D")]
				[Address(RVA = "0xE7EAC4", Offset = "0xE7EAC4", VA = "0xE7EAC4")]
				set
				{
				}
			}

			[Token(Token = "0x170000D7")]
			internal Edge _Dnext
			{
				[Token(Token = "0x600046E")]
				[Address(RVA = "0xE7696C", Offset = "0xE7696C", VA = "0xE7696C")]
				get
				{
					return null;
				}
				[Token(Token = "0x600046F")]
				[Address(RVA = "0xE7EAE0", Offset = "0xE7EAE0", VA = "0xE7EAE0")]
				set
				{
				}
			}

			[Token(Token = "0x170000D8")]
			internal Edge _Rnext
			{
				[Token(Token = "0x6000470")]
				[Address(RVA = "0xE7EB08", Offset = "0xE7EB08", VA = "0xE7EB08")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000471")]
				[Address(RVA = "0xE7EB30", Offset = "0xE7EB30", VA = "0xE7EB30")]
				set
				{
				}
			}

			[Token(Token = "0x6000472")]
			[Address(RVA = "0xE7EB58", Offset = "0xE7EB58", VA = "0xE7EB58")]
			internal static void EnsureFirst(ref Edge e)
			{
			}

			[Token(Token = "0x6000473")]
			[Address(RVA = "0xE7EB88", Offset = "0xE7EB88", VA = "0xE7EB88", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0xE7EC68", Offset = "0xE7EC68", VA = "0xE7EC68")]
			public Edge()
			{
			}
		}

		[Token(Token = "0x4000203")]
		public const int Undef = -1;

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xBF6DF8", Offset = "0xBF6DF8", VA = "0xBF6DF8")]
		public static Edge MakeEdge(Edge eNext)
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xBF73C4", Offset = "0xBF73C4", VA = "0xBF73C4")]
		public static void Splice(Edge a, Edge b)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xBF6F78", Offset = "0xBF6F78", VA = "0xBF6F78")]
		public static void MakeVertex(Edge eOrig, Vertex vNext)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xBF7068", Offset = "0xBF7068", VA = "0xBF7068")]
		public static void MakeFace(Edge eOrig, Face fNext)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xBF75D0", Offset = "0xBF75D0", VA = "0xBF75D0")]
		public static void KillEdge(Edge eDel)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xBF7254", Offset = "0xBF7254", VA = "0xBF7254")]
		public static void KillVertex(Vertex vDel, Vertex newOrg)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xBF730C", Offset = "0xBF730C", VA = "0xBF730C")]
		public static void KillFace(Face fDel, Face newLFace)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xBF8518", Offset = "0xBF8518", VA = "0xBF8518")]
		public static float FaceArea(Face f)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000A5")]
	internal struct PQHandle
	{
		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int Invalid;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal int _handle;
	}
	[Token(Token = "0x20000A6")]
	internal class PriorityHeap<TValue> where TValue : class
	{
		[Token(Token = "0x20000A7")]
		public delegate bool LessOrEqual(TValue lhs, TValue rhs);

		[Token(Token = "0x20000A8")]
		protected class HandleElem
		{
			[Token(Token = "0x4000229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TValue _key;

			[Token(Token = "0x400022A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int _node;

			[Token(Token = "0x6000483")]
			public HandleElem()
			{
			}
		}

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LessOrEqual _leq;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] _nodes;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private HandleElem[] _handles;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _size;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _max;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _freeList;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _initialized;

		[Token(Token = "0x170000D9")]
		public bool Empty
		{
			[Token(Token = "0x6000476")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000477")]
		public PriorityHeap(int initialSize, LessOrEqual leq)
		{
		}

		[Token(Token = "0x6000478")]
		private void FloatDown(int curr)
		{
		}

		[Token(Token = "0x6000479")]
		private void FloatUp(int curr)
		{
		}

		[Token(Token = "0x600047A")]
		public void Init()
		{
		}

		[Token(Token = "0x600047B")]
		public PQHandle Insert(TValue value)
		{
			return default(PQHandle);
		}

		[Token(Token = "0x600047C")]
		public TValue ExtractMin()
		{
			return null;
		}

		[Token(Token = "0x600047D")]
		public TValue Minimum()
		{
			return null;
		}

		[Token(Token = "0x600047E")]
		public void Remove(PQHandle handle)
		{
		}
	}
	[Token(Token = "0x20000A9")]
	internal class PriorityQueue<TValue> where TValue : class
	{
		[Token(Token = "0x20000AA")]
		private class StackItem
		{
			[Token(Token = "0x4000232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int p;

			[Token(Token = "0x4000233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int r;

			[Token(Token = "0x600048C")]
			public StackItem()
			{
			}
		}

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PriorityHeap<TValue>.LessOrEqual _leq;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PriorityHeap<TValue> _heap;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TValue[] _keys;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] _order;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _size;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _max;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _initialized;

		[Token(Token = "0x170000DA")]
		public bool Empty
		{
			[Token(Token = "0x6000484")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000485")]
		public PriorityQueue(int initialSize, PriorityHeap<TValue>.LessOrEqual leq)
		{
		}

		[Token(Token = "0x6000486")]
		private static void Swap(ref int a, ref int b)
		{
		}

		[Token(Token = "0x6000487")]
		public void Init()
		{
		}

		[Token(Token = "0x6000488")]
		public PQHandle Insert(TValue value)
		{
			return default(PQHandle);
		}

		[Token(Token = "0x6000489")]
		public TValue ExtractMin()
		{
			return null;
		}

		[Token(Token = "0x600048A")]
		public TValue Minimum()
		{
			return null;
		}

		[Token(Token = "0x600048B")]
		public void Remove(PQHandle handle)
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class Tess
	{
		[Token(Token = "0x20000AC")]
		internal class ActiveRegion
		{
			[Token(Token = "0x400024A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal MeshUtils.Edge _eUp;

			[Token(Token = "0x400024B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Dict<ActiveRegion>.Node _nodeUp;

			[Token(Token = "0x400024C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int _windingNumber;

			[Token(Token = "0x400024D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal bool _inside;

			[Token(Token = "0x400024E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			internal bool _sentinel;

			[Token(Token = "0x400024F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
			internal bool _dirty;

			[Token(Token = "0x4000250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
			internal bool _fixUpperEdge;

			[Token(Token = "0x60004C2")]
			[Address(RVA = "0xE74EB4", Offset = "0xE74EB4", VA = "0xE74EB4")]
			public ActiveRegion()
			{
			}
		}

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private LTMesh _mesh;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vec3 _normal;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vec3 _sUnit;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vec3 _tUnit;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _bminX;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _bminY;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float _bmaxX;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _bmaxY;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private WindingRule _windingRule;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dict<ActiveRegion> _dict;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PriorityQueue<MeshUtils.Vertex> _pq;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshUtils.Vertex _event;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CombineCallback _combineCallback;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ContourVertex[] _vertices;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _vertexCount;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int[] _elements;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _elementCount;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float SUnitX;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float SUnitY;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float SentinelCoord;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool NoEmptyPolygons;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool UsePooling;

		[Token(Token = "0x170000DB")]
		public Vec3 Normal
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0xE771BC", Offset = "0xE771BC", VA = "0xE771BC")]
			get
			{
				return default(Vec3);
			}
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0xE771C8", Offset = "0xE771C8", VA = "0xE771C8")]
			set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public ContourVertex[] Vertices
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0xE771D4", Offset = "0xE771D4", VA = "0xE771D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DD")]
		public int VertexCount
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0xE771DC", Offset = "0xE771DC", VA = "0xE771DC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DE")]
		public int[] Elements
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0xE771E4", Offset = "0xE771E4", VA = "0xE771E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DF")]
		public int ElementCount
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0xE771EC", Offset = "0xE771EC", VA = "0xE771EC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xE74A28", Offset = "0xE74A28", VA = "0xE74A28")]
		private ActiveRegion RegionBelow(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xE74A54", Offset = "0xE74A54", VA = "0xE74A54")]
		private ActiveRegion RegionAbove(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xE74A80", Offset = "0xE74A80", VA = "0xE74A80")]
		private bool EdgeLeq(ActiveRegion reg1, ActiveRegion reg2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xE74BC4", Offset = "0xE74BC4", VA = "0xE74BC4")]
		private void DeleteRegion(ActiveRegion reg)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xE74C40", Offset = "0xE74C40", VA = "0xE74C40")]
		private void FixUpperEdge(ActiveRegion reg, MeshUtils.Edge newEdge)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xE74CAC", Offset = "0xE74CAC", VA = "0xE74CAC")]
		private ActiveRegion TopLeftRegion(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xE74D74", Offset = "0xE74D74", VA = "0xE74D74")]
		private ActiveRegion TopRightRegion(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xE74DD4", Offset = "0xE74DD4", VA = "0xE74DD4")]
		private ActiveRegion AddRegionBelow(ActiveRegion regAbove, MeshUtils.Edge eNewUp)
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xE74EBC", Offset = "0xE74EBC", VA = "0xE74EBC")]
		private void ComputeWinding(ActiveRegion reg)
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xE74F18", Offset = "0xE74F18", VA = "0xE74F18")]
		private void FinishRegion(ActiveRegion reg)
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xE74F68", Offset = "0xE74F68", VA = "0xE74F68")]
		private MeshUtils.Edge FinishLeftRegions(ActiveRegion regFirst, ActiveRegion regLast)
		{
			return null;
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xE750E0", Offset = "0xE750E0", VA = "0xE750E0")]
		private void AddRightEdges(ActiveRegion regUp, MeshUtils.Edge eFirst, MeshUtils.Edge eLast, MeshUtils.Edge eTopLeft, bool cleanUp)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xE756C8", Offset = "0xE756C8", VA = "0xE756C8")]
		private void SpliceMergeVertices(MeshUtils.Edge e1, MeshUtils.Edge e2)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xE756E4", Offset = "0xE756E4", VA = "0xE756E4")]
		private void VertexWeights(MeshUtils.Vertex isect, MeshUtils.Vertex org, MeshUtils.Vertex dst, out float w0, out float w1)
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xE757E8", Offset = "0xE757E8", VA = "0xE757E8")]
		private void GetIntersectData(MeshUtils.Vertex isect, MeshUtils.Vertex orgUp, MeshUtils.Vertex dstUp, MeshUtils.Vertex orgLo, MeshUtils.Vertex dstLo)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xE752D0", Offset = "0xE752D0", VA = "0xE752D0")]
		private bool CheckForRightSplice(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xE75AB4", Offset = "0xE75AB4", VA = "0xE75AB4")]
		private bool CheckForLeftSplice(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xE75C64", Offset = "0xE75C64", VA = "0xE75C64")]
		private bool CheckForIntersect(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xE75488", Offset = "0xE75488", VA = "0xE75488")]
		private void WalkDirtyRegions(ActiveRegion regUp)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xE76314", Offset = "0xE76314", VA = "0xE76314")]
		private void ConnectRightVertex(ActiveRegion regUp, MeshUtils.Edge eBottomLeft)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xE7652C", Offset = "0xE7652C", VA = "0xE7652C")]
		private void ConnectLeftDegenerate(ActiveRegion regUp, MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xE76718", Offset = "0xE76718", VA = "0xE76718")]
		private void ConnectLeftVertex(MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xE76638", Offset = "0xE76638", VA = "0xE76638")]
		private void SweepEvent(MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xE76994", Offset = "0xE76994", VA = "0xE76994")]
		private void AddSentinel(float smin, float smax, float t)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xE76AD8", Offset = "0xE76AD8", VA = "0xE76AD8")]
		private void InitEdgeDict()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xE76BDC", Offset = "0xE76BDC", VA = "0xE76BDC")]
		private void DoneEdgeDict()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xE76C70", Offset = "0xE76C70", VA = "0xE76C70")]
		private void RemoveDegenerateEdges()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xE76DC8", Offset = "0xE76DC8", VA = "0xE76DC8")]
		private void InitPriorityQ()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xE76FE0", Offset = "0xE76FE0", VA = "0xE76FE0")]
		private void DonePriorityQ()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xE76FEC", Offset = "0xE76FEC", VA = "0xE76FEC")]
		private void RemoveDegenerateFaces()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xE7708C", Offset = "0xE7708C", VA = "0xE7708C")]
		protected void ComputeInterior()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xE771F4", Offset = "0xE771F4", VA = "0xE771F4")]
		public Tess()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xE772CC", Offset = "0xE772CC", VA = "0xE772CC")]
		private void ComputeNormal(ref Vec3 norm)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xE77B8C", Offset = "0xE77B8C", VA = "0xE77B8C")]
		private void CheckOrientation()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xE77CBC", Offset = "0xE77CBC", VA = "0xE77CBC")]
		private void ProjectPolygon()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xE78044", Offset = "0xE78044", VA = "0xE78044")]
		private void TessellateMonoRegion(MeshUtils.Face face)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xE7825C", Offset = "0xE7825C", VA = "0xE7825C")]
		private void TessellateInterior()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xE782C8", Offset = "0xE782C8", VA = "0xE782C8")]
		private void DiscardExterior()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xE78334", Offset = "0xE78334", VA = "0xE78334")]
		private void SetWindingNumber(int value, bool keepOnlyBoundary)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xE78408", Offset = "0xE78408", VA = "0xE78408")]
		private int GetNeighbourFace(MeshUtils.Edge edge)
		{
			return default(int);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xE78444", Offset = "0xE78444", VA = "0xE78444")]
		private void OutputPolymesh(ElementType elementType, int polySize)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xE788BC", Offset = "0xE788BC", VA = "0xE788BC")]
		private void OutputContours()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xE78B30", Offset = "0xE78B30", VA = "0xE78B30")]
		private float SignedArea(ContourVertex[] vertices)
		{
			return default(float);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xE78BD0", Offset = "0xE78BD0", VA = "0xE78BD0")]
		public void AddContour(ContourVertex[] vertices)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xE78BD8", Offset = "0xE78BD8", VA = "0xE78BD8")]
		public void AddContour(ContourVertex[] vertices, ContourOrientation forceOrientation)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xE78DC4", Offset = "0xE78DC4", VA = "0xE78DC4")]
		public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xE78DCC", Offset = "0xE78DCC", VA = "0xE78DCC")]
		public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize, CombineCallback combineCallback)
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public enum WindingRule
	{
		[Token(Token = "0x4000252")]
		EvenOdd,
		[Token(Token = "0x4000253")]
		NonZero,
		[Token(Token = "0x4000254")]
		Positive,
		[Token(Token = "0x4000255")]
		Negative,
		[Token(Token = "0x4000256")]
		AbsGeqTwo
	}
	[Token(Token = "0x20000AE")]
	public enum ElementType
	{
		[Token(Token = "0x4000258")]
		Polygons,
		[Token(Token = "0x4000259")]
		ConnectedPolygons,
		[Token(Token = "0x400025A")]
		BoundaryContours
	}
	[Token(Token = "0x20000AF")]
	public enum ContourOrientation
	{
		[Token(Token = "0x400025C")]
		Original,
		[Token(Token = "0x400025D")]
		Clockwise,
		[Token(Token = "0x400025E")]
		CounterClockwise
	}
	[Token(Token = "0x20000B0")]
	public struct ContourVertex
	{
		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vec3 Position;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public object Data;

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xB8AF48", Offset = "0xB8AF48", VA = "0xB8AF48", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20000B1")]
	public delegate object CombineCallback(Vec3 position, object[] data, float[] weights);
	[Token(Token = "0x20000B2")]
	public static class LibTessVector3Extension
	{
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xBF7CD0", Offset = "0xBF7CD0", VA = "0xBF7CD0")]
		public static Vec3 Vec3(this Vector3 v)
		{
			return default(Vec3);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xBF7CD4", Offset = "0xBF7CD4", VA = "0xBF7CD4")]
		public static ContourVertex ContourVertex(this Vector3 v)
		{
			return default(ContourVertex);
		}
	}
	[Token(Token = "0x20000B3")]
	public static class LibTessV3Extension
	{
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xBF7CCC", Offset = "0xBF7CCC", VA = "0xBF7CCC")]
		public static Vector3 Vector3(this Vec3 v)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000B4")]
	public static class UnityLibTessUtility
	{
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xE7CC8C", Offset = "0xE7CC8C", VA = "0xE7CC8C")]
		public static ContourVertex[] ToContourVertex(Vector3[] v, bool zeroZ = false)
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xE7CD7C", Offset = "0xE7CD7C", VA = "0xE7CD7C")]
		public static Vector3[] FromContourVertex(ContourVertex[] v)
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xE7CDF8", Offset = "0xE7CDF8", VA = "0xE7CDF8")]
		public static void SetFromContourVertex(ref Vector3[] v3Array, ref ContourVertex[] cvArray)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xE7CF40", Offset = "0xE7CF40", VA = "0xE7CF40")]
		public static void SetToContourVertex(ref ContourVertex[] cvArray, ref Vector3[] v3Array)
		{
		}
	}
}
namespace FluffyUnderware.Curvy.ImportExport
{
	[Token(Token = "0x20000B5")]
	public enum CurvySerializationSpace
	{
		[Token(Token = "0x4000262")]
		Global,
		[Token(Token = "0x4000263")]
		Local
	}
	[Serializable]
	[Token(Token = "0x20000B6")]
	public class SerializedCurvySpline
	{
		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Position;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 Rotation;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CurvyInterpolation Interpolation;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool RestrictTo2D;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		public bool Closed;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		public bool AutoEndTangents;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CurvyOrientation Orientation;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float AutoHandleDistance;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int CacheDensity;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float MaxPointsPerUnit;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool UsePooling;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool UseThreading;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool CheckTransform;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public CurvyUpdateMethod UpdateIn;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SerializedCurvySplineSegment[] ControlPoints;

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xBFFFCC", Offset = "0xBFFFCC", VA = "0xBFFFCC")]
		public SerializedCurvySpline()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xC0009C", Offset = "0xC0009C", VA = "0xC0009C")]
		public SerializedCurvySpline([NotNull] CurvySpline spline, CurvySerializationSpace space)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xC0044C", Offset = "0xC0044C", VA = "0xC0044C")]
		public void WriteIntoSpline([NotNull] CurvySpline deserializedSpline, CurvySerializationSpace space)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B7")]
	public class SerializedCurvySplineSegment
	{
		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 Rotation;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool AutoBakeOrientation;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool OrientationAnchor;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public CurvyOrientationSwirl Swirl;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float SwirlTurns;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool AutoHandles;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float AutoHandleDistance;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 HandleOut;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 HandleIn;

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xC007B4", Offset = "0xC007B4", VA = "0xC007B4")]
		public SerializedCurvySplineSegment()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xC00340", Offset = "0xC00340", VA = "0xC00340")]
		public SerializedCurvySplineSegment([NotNull] CurvySplineSegment segment, CurvySerializationSpace space)
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xC00660", Offset = "0xC00660", VA = "0xC00660")]
		public void WriteIntoControlPoint([NotNull] CurvySplineSegment controlPoint, CurvySerializationSpace space)
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Controllers
{
	[Token(Token = "0x20000B8")]
	public abstract class ConnectedControlPointsSelector : MonoBehaviour
	{
		[Token(Token = "0x60004D5")]
		public abstract CurvySplineSegment SelectConnectedControlPoint(SplineController caller, CurvyConnection connection, CurvySplineSegment currentControlPoint);

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xB8AE8C", Offset = "0xB8AE8C", VA = "0xB8AE8C")]
		protected ConnectedControlPointsSelector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B9")]
	public class ControllerEvent : UnityEventEx<CurvyController>
	{
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xB8B400", Offset = "0xB8B400", VA = "0xB8B400")]
		public ControllerEvent()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4FFB00", Offset = "0x4FFB00")]
	public class CurvyControllerEventArgs : CurvyEventArgs
	{
		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly CurvyController Controller;

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xBAEB9C", Offset = "0xBAEB9C", VA = "0xBAEB9C")]
		public CurvyControllerEventArgs(MonoBehaviour sender, CurvyController controller)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BB")]
	public class CurvySplineMoveEvent : UnityEventEx<CurvySplineMoveEventArgs>
	{
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xEAF3F0", Offset = "0xEAF3F0", VA = "0xEAF3F0")]
		public CurvySplineMoveEvent()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class CurvySplineMoveEventArgs : CancelEventArgs
	{
		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503E7C", Offset = "0x503E7C")]
		private SplineController <Sender>k__BackingField;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503E8C", Offset = "0x503E8C")]
		private CurvySpline <Spline>k__BackingField;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503E9C", Offset = "0x503E9C")]
		private CurvySplineSegment <ControlPoint>k__BackingField;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503EAC", Offset = "0x503EAC")]
		private bool <WorldUnits>k__BackingField;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503EBC", Offset = "0x503EBC")]
		private MovementDirection <MovementDirection>k__BackingField;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503ECC", Offset = "0x503ECC")]
		private float <Delta>k__BackingField;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x503EDC", Offset = "0x503EDC")]
		private float <Position>k__BackingField;

		[Token(Token = "0x170000E0")]
		public SplineController Sender
		{
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0xEAF43C", Offset = "0xEAF43C", VA = "0xEAF43C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E094", Offset = "0x50E094")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0xEAF444", Offset = "0xEAF444", VA = "0xEAF444")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E0A4", Offset = "0x50E0A4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public CurvySpline Spline
		{
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0xEAF44C", Offset = "0xEAF44C", VA = "0xEAF44C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E0B4", Offset = "0x50E0B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0xEAF454", Offset = "0xEAF454", VA = "0xEAF454")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E0C4", Offset = "0x50E0C4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public CurvySplineSegment ControlPoint
		{
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0xEAF45C", Offset = "0xEAF45C", VA = "0xEAF45C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E0D4", Offset = "0x50E0D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0xEAF464", Offset = "0xEAF464", VA = "0xEAF464")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E0E4", Offset = "0x50E0E4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		public bool WorldUnits
		{
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0xEAF46C", Offset = "0xEAF46C", VA = "0xEAF46C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E0F4", Offset = "0x50E0F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0xEAF474", Offset = "0xEAF474", VA = "0xEAF474")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E104", Offset = "0x50E104")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		public MovementDirection MovementDirection
		{
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0xEAF480", Offset = "0xEAF480", VA = "0xEAF480")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E114", Offset = "0x50E114")]
			get
			{
				return default(MovementDirection);
			}
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0xEAF488", Offset = "0xEAF488", VA = "0xEAF488")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E124", Offset = "0x50E124")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E5")]
		public float Delta
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0xEAF490", Offset = "0xEAF490", VA = "0xEAF490")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E134", Offset = "0x50E134")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0xEAF498", Offset = "0xEAF498", VA = "0xEAF498")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E144", Offset = "0x50E144")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public float Position
		{
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0xEAF4A0", Offset = "0xEAF4A0", VA = "0xEAF4A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E154", Offset = "0x50E154")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0xEAF4A8", Offset = "0xEAF4A8", VA = "0xEAF4A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E164", Offset = "0x50E164")]
			private set
			{
			}
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xEAF4B0", Offset = "0xEAF4B0", VA = "0xEAF4B0")]
		public CurvySplineMoveEventArgs(SplineController sender, CurvySpline spline, CurvySplineSegment controlPoint, float position, bool usingWorldUnits, float delta, MovementDirection direction)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xEAF528", Offset = "0xEAF528", VA = "0xEAF528")]
		internal void Set_INTERNAL(SplineController sender, CurvySpline spline, CurvySplineSegment controlPoint, float position, float delta, MovementDirection direction, bool usingWorldUnits)
		{
		}
	}
	[Token(Token = "0x20000BD")]
	[ExecuteInEditMode]
	public abstract class CurvyController : DTVersionedMonoBehaviour, ISerializationCallbackReceiver
	{
		[Token(Token = "0x20000BE")]
		public enum MoveModeEnum
		{
			[Token(Token = "0x40002A1")]
			Relative,
			[Token(Token = "0x40002A2")]
			AbsolutePrecise
		}

		[Token(Token = "0x20000BF")]
		public enum CurvyControllerState
		{
			[Token(Token = "0x40002A4")]
			Stopped,
			[Token(Token = "0x40002A5")]
			Playing,
			[Token(Token = "0x40002A6")]
			Paused
		}

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x503EEC", Offset = "0x503EEC")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x503EEC", Offset = "0x503EEC")]
		public CurvyUpdateMethod UpdateIn;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x503F84", Offset = "0x503F84")]
		[SerializeField]
		private CurvyPositionMode m_PositionMode;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x504008", Offset = "0x504008")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x504008", Offset = "0x504008")]
		[SerializeField]
		protected float m_Position;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x5040B4", Offset = "0x5040B4")]
		private MoveModeEnum m_MoveMode;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Positive]
		private float m_Speed;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private MovementDirection m_Direction;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CurvyClamping m_Clamping;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x504188", Offset = "0x504188")]
		[SerializeField]
		private bool m_PlayAutomatically;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x5041D4", Offset = "0x5041D4")]
		[SerializeField]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x5041D4", Offset = "0x5041D4")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x5041D4", Offset = "0x5041D4")]
		private OrientationModeEnum m_OrientationMode;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x50431C", Offset = "0x50431C")]
		[SerializeField]
		private bool m_LockRotation;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x504384", Offset = "0x504384")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x504384", Offset = "0x504384")]
		[SerializeField]
		private OrientationAxisEnum m_OrientationAxis;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5044C0", Offset = "0x5044C0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x5044C0", Offset = "0x5044C0")]
		private bool m_IgnoreDirection;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x5045E8", Offset = "0x5045E8")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x5045E8", Offset = "0x5045E8")]
		[SerializeField]
		private float m_DampingDirection;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x5046E0", Offset = "0x5046E0")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x5046E0", Offset = "0x5046E0")]
		private float m_DampingUp;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x5047D8", Offset = "0x5047D8")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x5047D8", Offset = "0x5047D8")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x5047D8", Offset = "0x5047D8")]
		[SerializeField]
		private float m_OffsetAngle;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x504930", Offset = "0x504930")]
		private float m_OffsetRadius;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x5049E4", Offset = "0x5049E4")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x5049E4", Offset = "0x5049E4")]
		[SerializeField]
		private bool m_OffsetCompensation;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x504AD8", Offset = "0x504AD8")]
		protected ControllerEvent onInitialized;

		[Token(Token = "0x4000298")]
		protected const string ControllerNotReadyMessage = "The controller is not yet ready";

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected CurvyControllerState State;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		protected Vector3 DirectionDampingVelocity;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected Vector3 UpDampingVelocity;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		protected float PrePlayPosition;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected MovementDirection PrePlayDirection;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		protected Quaternion LockedRotation;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x504B3C", Offset = "0x504B3C")]
		private bool <isInitialized>k__BackingField;

		[Token(Token = "0x170000E7")]
		public ControllerEvent OnInitialized
		{
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0xBACC7C", Offset = "0xBACC7C", VA = "0xBACC7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E8")]
		public CurvyPositionMode PositionMode
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0xBACC84", Offset = "0xBACC84", VA = "0xBACC84")]
			get
			{
				return default(CurvyPositionMode);
			}
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0xBACC8C", Offset = "0xBACC8C", VA = "0xBACC8C")]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public MoveModeEnum MoveMode
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0xBACC94", Offset = "0xBACC94", VA = "0xBACC94")]
			get
			{
				return default(MoveModeEnum);
			}
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0xBACC9C", Offset = "0xBACC9C", VA = "0xBACC9C")]
			set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public bool PlayAutomatically
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0xBACCB0", Offset = "0xBACCB0", VA = "0xBACCB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0xBACCB8", Offset = "0xBACCB8", VA = "0xBACCB8")]
			set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public CurvyClamping Clamping
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0xBACCD8", Offset = "0xBACCD8", VA = "0xBACCD8")]
			get
			{
				return default(CurvyClamping);
			}
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0xBACCE0", Offset = "0xBACCE0", VA = "0xBACCE0")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public OrientationModeEnum OrientationMode
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0xBACCF4", Offset = "0xBACCF4", VA = "0xBACCF4")]
			get
			{
				return default(OrientationModeEnum);
			}
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0xBACCFC", Offset = "0xBACCFC", VA = "0xBACCFC")]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public bool LockRotation
		{
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0xBACD10", Offset = "0xBACD10", VA = "0xBACD10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0xBACD18", Offset = "0xBACD18", VA = "0xBACD18")]
			set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public OrientationAxisEnum OrientationAxis
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0xBACD80", Offset = "0xBACD80", VA = "0xBACD80")]
			get
			{
				return default(OrientationAxisEnum);
			}
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0xBACD88", Offset = "0xBACD88", VA = "0xBACD88")]
			set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public float DirectionDampingTime
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0xBACD9C", Offset = "0xBACD9C", VA = "0xBACD9C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0xBACDA4", Offset = "0xBACDA4", VA = "0xBACDA4")]
			set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public float UpDampingTime
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0xBACDE0", Offset = "0xBACDE0", VA = "0xBACDE0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0xBACDE8", Offset = "0xBACDE8", VA = "0xBACDE8")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public bool IgnoreDirection
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0xBACE24", Offset = "0xBACE24", VA = "0xBACE24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0xBACE2C", Offset = "0xBACE2C", VA = "0xBACE2C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public float OffsetAngle
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0xBACE4C", Offset = "0xBACE4C", VA = "0xBACE4C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000500")]
			[Address(RVA = "0xBACE54", Offset = "0xBACE54", VA = "0xBACE54")]
			set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public float OffsetRadius
		{
			[Token(Token = "0x6000501")]
			[Address(RVA = "0xBACE68", Offset = "0xBACE68", VA = "0xBACE68")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000502")]
			[Address(RVA = "0xBACE70", Offset = "0xBACE70", VA = "0xBACE70")]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public bool OffsetCompensation
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0xBACE84", Offset = "0xBACE84", VA = "0xBACE84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000504")]
			[Address(RVA = "0xBACE8C", Offset = "0xBACE8C", VA = "0xBACE8C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public float Speed
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0xBACE98", Offset = "0xBACE98", VA = "0xBACE98")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000506")]
			[Address(RVA = "0xBACEA0", Offset = "0xBACEA0", VA = "0xBACEA0")]
			set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public float RelativePosition
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0xBACEB4", Offset = "0xBACEB4", VA = "0xBACEB4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000508")]
			[Address(RVA = "0xBAD044", Offset = "0xBAD044", VA = "0xBAD044")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public float AbsolutePosition
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0xBAD0F8", Offset = "0xBAD0F8", VA = "0xBAD0F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600050A")]
			[Address(RVA = "0xBAD200", Offset = "0xBAD200", VA = "0xBAD200")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public float Position
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0xBAD2C0", Offset = "0xBAD2C0", VA = "0xBAD2C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600050C")]
			[Address(RVA = "0xBAD318", Offset = "0xBAD318", VA = "0xBAD318")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public MovementDirection MovementDirection
		{
			[Token(Token = "0x600050D")]
			[Address(RVA = "0xBAD370", Offset = "0xBAD370", VA = "0xBAD370")]
			get
			{
				return default(MovementDirection);
			}
			[Token(Token = "0x600050E")]
			[Address(RVA = "0xBAD378", Offset = "0xBAD378", VA = "0xBAD378")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public CurvyControllerState PlayState
		{
			[Token(Token = "0x600050F")]
			[Address(RVA = "0xBAD380", Offset = "0xBAD380", VA = "0xBAD380")]
			get
			{
				return default(CurvyControllerState);
			}
		}

		[Token(Token = "0x170000FB")]
		public abstract bool IsReady
		{
			[Token(Token = "0x6000510")]
			get;
		}

		[Token(Token = "0x170000FC")]
		public virtual Transform Transform
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0xBAD6FC", Offset = "0xBAD6FC", VA = "0xBAD6FC", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FD")]
		protected virtual bool ShowOrientationSection
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0xBAE2D4", Offset = "0xBAE2D4", VA = "0xBAE2D4", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FE")]
		protected virtual bool ShowOffsetSection
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0xBAE2DC", Offset = "0xBAE2DC", VA = "0xBAE2DC", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FF")]
		public abstract float Length
		{
			[Token(Token = "0x6000525")]
			get;
		}

		[Token(Token = "0x17000100")]
		protected bool isInitialized
		{
			[Token(Token = "0x6000536")]
			[Address(RVA = "0xBAEA24", Offset = "0xBAEA24", VA = "0xBAEA24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E174", Offset = "0x50E174")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000537")]
			[Address(RVA = "0xBAEA2C", Offset = "0xBAEA2C", VA = "0xBAEA2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E184", Offset = "0x50E184")]
			private set
			{
			}
		}

		[Token(Token = "0x17000101")]
		protected float TimeSinceLastUpdate
		{
			[Token(Token = "0x6000538")]
			[Address(RVA = "0xBAD51C", Offset = "0xBAD51C", VA = "0xBAD51C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000102")]
		protected bool UseOffset
		{
			[Token(Token = "0x6000539")]
			[Address(RVA = "0xBADA08", Offset = "0xBADA08", VA = "0xBADA08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000103")]
		private float maxPosition
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0xBAEA38", Offset = "0xBAEA38", VA = "0xBAEA38")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xBAD388", Offset = "0xBAD388", VA = "0xBAD388", Slot = "7")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xBAD3F0", Offset = "0xBAD3F0", VA = "0xBAD3F0", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xBAD4CC", Offset = "0xBAD4CC", VA = "0xBAD4CC", Slot = "9")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xBAD4E8", Offset = "0xBAD4E8", VA = "0xBAD4E8", Slot = "10")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xBAD5D4", Offset = "0xBAD5D4", VA = "0xBAD5D4", Slot = "11")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xBAD62C", Offset = "0xBAD62C", VA = "0xBAD62C", Slot = "12")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xBAD664", Offset = "0xBAD664", VA = "0xBAD664", Slot = "13")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xBAD704", Offset = "0xBAD704", VA = "0xBAD704", Slot = "15")]
		protected virtual void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xBADC14", Offset = "0xBADC14", VA = "0xBADC14", Slot = "16")]
		protected virtual void ComputeTargetPositionAndRotation(out Vector3 targetPosition, out Vector3 targetUp, out Vector3 targetForward)
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xBAE1B0", Offset = "0xBAE1B0", VA = "0xBAE1B0", Slot = "17")]
		protected virtual void Initialize()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xBAE274", Offset = "0xBAE274", VA = "0xBAE274", Slot = "18")]
		protected virtual void Deinitialize()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xBAE2A4", Offset = "0xBAE2A4", VA = "0xBAE2A4", Slot = "19")]
		protected virtual void BindEvents()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xBAE2A8", Offset = "0xBAE2A8", VA = "0xBAE2A8", Slot = "20")]
		protected virtual void UnbindEvents()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xBAE2AC", Offset = "0xBAE2AC", VA = "0xBAE2AC", Slot = "21")]
		protected virtual void SavePrePlayState()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xBAE2BC", Offset = "0xBAE2BC", VA = "0xBAE2BC", Slot = "22")]
		protected virtual void RestorePrePlayState()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xBAE2CC", Offset = "0xBAE2CC", VA = "0xBAE2CC", Slot = "23")]
		protected virtual void UserAfterInit()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xBAE2D0", Offset = "0xBAE2D0", VA = "0xBAE2D0", Slot = "24")]
		protected virtual void UserAfterUpdate()
		{
		}

		[Token(Token = "0x6000526")]
		protected abstract void Advance(float speed, float deltaTime);

		[Token(Token = "0x6000527")]
		protected abstract void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime);

		[Token(Token = "0x6000528")]
		protected abstract float AbsoluteToRelative(float worldUnitDistance);

		[Token(Token = "0x6000529")]
		protected abstract float RelativeToAbsolute(float relativeDistance);

		[Token(Token = "0x600052A")]
		protected abstract Vector3 GetInterpolatedSourcePosition(float tf);

		[Token(Token = "0x600052B")]
		protected abstract void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up);

		[Token(Token = "0x600052C")]
		protected abstract Vector3 GetOrientation(float tf);

		[Token(Token = "0x600052D")]
		protected abstract Vector3 GetTangent(float tf);

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xBAD48C", Offset = "0xBAD48C", VA = "0xBAD48C")]
		public void Play()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xBAE2EC", Offset = "0xBAE2EC", VA = "0xBAE2EC")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xBAE328", Offset = "0xBAE328", VA = "0xBAE328")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xBAE340", Offset = "0xBAE340", VA = "0xBAE340")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xBAD524", Offset = "0xBAD524", VA = "0xBAD524")]
		public void ApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xBAE348", Offset = "0xBAE348", VA = "0xBAE348")]
		public void TeleportTo(float newPosition)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xBAE390", Offset = "0xBAE390", VA = "0xBAE390")]
		public void TeleportBy(float distance, MovementDirection direction)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xBAE448", Offset = "0xBAE448", VA = "0xBAE448")]
		public void SetFromString(string fieldAndValue)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xBAE110", Offset = "0xBAE110", VA = "0xBAE110")]
		protected static Vector3 ApplyOffset(Vector3 position, Vector3 tangent, Vector3 up, float offsetAngle, float offsetRadius)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xBACFC4", Offset = "0xBACFC4", VA = "0xBACFC4")]
		protected static float GetClampedPosition(float position, CurvyPositionMode positionMode, CurvyClamping clampingMode, float length)
		{
			return default(float);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xBADA18", Offset = "0xBADA18", VA = "0xBADA18")]
		protected float ComputeOffsetCompensatedSpeed(float deltaTime)
		{
			return default(float);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xBAE004", Offset = "0xBAE004", VA = "0xBAE004")]
		private void GetOrientationNoneUpAndForward(out Vector3 targetUp, out Vector3 targetForward)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xBAEACC", Offset = "0xBAEACC", VA = "0xBAEACC", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xBAEAD0", Offset = "0xBAEAD0", VA = "0xBAEAD0", Slot = "36")]
		public virtual void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xBAEB10", Offset = "0xBAEB10", VA = "0xBAEB10")]
		protected CurvyController()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public enum MovementDirection
	{
		[Token(Token = "0x40002A8")]
		Forward,
		[Token(Token = "0x40002A9")]
		Backward
	}
	[Token(Token = "0x20000C1")]
	public static class MovementDirectionMethods
	{
		[Token(Token = "0x6000542")]
		[Address(RVA = "0xBFB724", Offset = "0xBFB724", VA = "0xBFB724")]
		public static MovementDirection FromInt(int value)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xBFB72C", Offset = "0xBFB72C", VA = "0xBFB72C")]
		public static MovementDirection GetOpposite(this MovementDirection value)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xBFB788", Offset = "0xBFB788", VA = "0xBFB788")]
		public static int ToInt(this MovementDirection direction)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4FFB30", Offset = "0x4FFB30")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4FFB30", Offset = "0x4FFB30")]
	public class PathController : CurvyController
	{
		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x504B4C", Offset = "0x504B4C")]
		[SerializeField]
		[AttributeAttribute(Name = "CGDataReferenceSelectorAttribute", RVA = "0x504B4C", Offset = "0x504B4C")]
		private CGDataReference m_Path;

		[Token(Token = "0x17000104")]
		public CGDataReference Path
		{
			[Token(Token = "0x6000545")]
			[Address(RVA = "0xBFBD1C", Offset = "0xBFBD1C", VA = "0xBFBD1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000546")]
			[Address(RVA = "0xBFBD24", Offset = "0xBFBD24", VA = "0xBFBD24")]
			set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public CGPath PathData
		{
			[Token(Token = "0x6000547")]
			[Address(RVA = "0xBFBD2C", Offset = "0xBFBD2C", VA = "0xBFBD2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000106")]
		public override float Length
		{
			[Token(Token = "0x6000548")]
			[Address(RVA = "0xBFBDA0", Offset = "0xBFBDA0", VA = "0xBFBDA0", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000107")]
		public override bool IsReady
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0xBFBDE0", Offset = "0xBFBDE0", VA = "0xBFBDE0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xBFBE30", Offset = "0xBFBE30", VA = "0xBFBE30", Slot = "31")]
		protected override float RelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xBFBE8C", Offset = "0xBFBE8C", VA = "0xBFBE8C", Slot = "30")]
		protected override float AbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xBFBEE8", Offset = "0xBFBEE8", VA = "0xBFBEE8", Slot = "32")]
		protected override Vector3 GetInterpolatedSourcePosition(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xBFBF5C", Offset = "0xBFBF5C", VA = "0xBFBF5C", Slot = "33")]
		protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up)
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xBFC034", Offset = "0xBFC034", VA = "0xBFC034", Slot = "35")]
		protected override Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xBFC0A8", Offset = "0xBFC0A8", VA = "0xBFC0A8", Slot = "34")]
		protected override Vector3 GetOrientation(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xBFC11C", Offset = "0xBFC11C", VA = "0xBFC11C", Slot = "28")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xBFC198", Offset = "0xBFC198", VA = "0xBFC198", Slot = "29")]
		protected override void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xBFC284", Offset = "0xBFC284", VA = "0xBFC284")]
		public PathController()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public enum SplineControllerConnectionBehavior
	{
		[Token(Token = "0x40002AC")]
		CurrentSpline,
		[Token(Token = "0x40002AD")]
		FollowUpSpline,
		[Token(Token = "0x40002AE")]
		RandomSpline,
		[Token(Token = "0x40002AF")]
		FollowUpOtherwiseRandom,
		[Token(Token = "0x40002B0")]
		Custom
	}
	[Token(Token = "0x20000C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4FFB94", Offset = "0x4FFB94")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4FFB94", Offset = "0x4FFB94")]
	public class SplineController : CurvyController
	{
		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x504C0C", Offset = "0x504C0C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x504C0C", Offset = "0x504C0C")]
		[SerializeField]
		protected CurvySpline m_Spline;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x504CB8", Offset = "0x504CB8")]
		private bool m_UseCache;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x504D04", Offset = "0x504D04")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x504D04", Offset = "0x504D04")]
		[SerializeField]
		private SplineControllerConnectionBehavior connectionBehavior;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x504DC0", Offset = "0x504DC0")]
		private bool allowDirectionChange;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x504E20", Offset = "0x504E20")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x504E20", Offset = "0x504E20")]
		private bool rejectCurrentSpline;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBA")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x504F08", Offset = "0x504F08")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x504F08", Offset = "0x504F08")]
		private bool rejectTooDivergentSplines;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x504FF0", Offset = "0x504FF0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x504FF0", Offset = "0x504FF0")]
		private float maxAllowedDivergenceAngle;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x505074", Offset = "0x505074")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x505074", Offset = "0x505074")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x505074", Offset = "0x505074")]
		private ConnectedControlPointsSelector connectionCustomSelector;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x5051A4", Offset = "0x5051A4")]
		[SerializeField]
		protected CurvySplineMoveEvent m_OnControlPointReached;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		protected CurvySplineMoveEvent m_OnEndReached;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		protected CurvySplineMoveEvent m_OnSwitch;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x505238", Offset = "0x505238")]
		private bool <IsSwitching>k__BackingField;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private CurvySpline prePlaySpline;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly CurvySplineMoveEventArgs preAllocatedEventArgs;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected float SwitchStartTime;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		protected float SwitchDuration;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		protected CurvySpline SwitchTarget;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		protected float TfOnSwitchTarget;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		protected MovementDirection DirectionOnSwitchTarget;

		[Token(Token = "0x40002C4")]
		private const string InvalidSegmentErrorMessage = "[Curvy] Controller {0} reached segment {1} which is invalid segment because it has a length of 0. Please fix the invalid segment to avoid issues with the controller";

		[Token(Token = "0x17000108")]
		public virtual CurvySpline Spline
		{
			[Token(Token = "0x6000554")]
			[Address(RVA = "0xC01538", Offset = "0xC01538", VA = "0xC01538", Slot = "37")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000555")]
			[Address(RVA = "0xC01540", Offset = "0xC01540", VA = "0xC01540", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public bool UseCache
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0xC01548", Offset = "0xC01548", VA = "0xC01548")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000557")]
			[Address(RVA = "0xC01550", Offset = "0xC01550", VA = "0xC01550")]
			set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public SplineControllerConnectionBehavior ConnectionBehavior
		{
			[Token(Token = "0x6000558")]
			[Address(RVA = "0xC01570", Offset = "0xC01570", VA = "0xC01570")]
			get
			{
				return default(SplineControllerConnectionBehavior);
			}
			[Token(Token = "0x6000559")]
			[Address(RVA = "0xC01578", Offset = "0xC01578", VA = "0xC01578")]
			set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public ConnectedControlPointsSelector ConnectionCustomSelector
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0xC01580", Offset = "0xC01580", VA = "0xC01580")]
			get
			{
				return null;
			}
			[Token(Token = "0x600055B")]
			[Address(RVA = "0xC01588", Offset = "0xC01588", VA = "0xC01588")]
			set
			{
			}
		}

		[Token(Token = "0x1700010C")]
		public bool AllowDirectionChange
		{
			[Token(Token = "0x600055C")]
			[Address(RVA = "0xC01590", Offset = "0xC01590", VA = "0xC01590")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600055D")]
			[Address(RVA = "0xC01598", Offset = "0xC01598", VA = "0xC01598")]
			set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		public bool RejectCurrentSpline
		{
			[Token(Token = "0x600055E")]
			[Address(RVA = "0xC015A4", Offset = "0xC015A4", VA = "0xC015A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600055F")]
			[Address(RVA = "0xC015AC", Offset = "0xC015AC", VA = "0xC015AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700010E")]
		public bool RejectTooDivergentSplines
		{
			[Token(Token = "0x6000560")]
			[Address(RVA = "0xC015B8", Offset = "0xC015B8", VA = "0xC015B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000561")]
			[Address(RVA = "0xC015C0", Offset = "0xC015C0", VA = "0xC015C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700010F")]
		public float MaxAllowedDivergenceAngle
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0xC015CC", Offset = "0xC015CC", VA = "0xC015CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000563")]
			[Address(RVA = "0xC015D4", Offset = "0xC015D4", VA = "0xC015D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000110")]
		public CurvySplineMoveEvent OnControlPointReached
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0xC015DC", Offset = "0xC015DC", VA = "0xC015DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000565")]
			[Address(RVA = "0xC015E4", Offset = "0xC015E4", VA = "0xC015E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000111")]
		public CurvySplineMoveEvent OnEndReached
		{
			[Token(Token = "0x6000566")]
			[Address(RVA = "0xC015EC", Offset = "0xC015EC", VA = "0xC015EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000567")]
			[Address(RVA = "0xC015F4", Offset = "0xC015F4", VA = "0xC015F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000112")]
		public CurvySplineMoveEvent OnSwitch
		{
			[Token(Token = "0x6000568")]
			[Address(RVA = "0xC015FC", Offset = "0xC015FC", VA = "0xC015FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000569")]
			[Address(RVA = "0xC01604", Offset = "0xC01604", VA = "0xC01604")]
			set
			{
			}
		}

		[Token(Token = "0x17000113")]
		public bool IsSwitching
		{
			[Token(Token = "0x600056A")]
			[Address(RVA = "0xC0160C", Offset = "0xC0160C", VA = "0xC0160C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E1B4", Offset = "0x50E1B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600056B")]
			[Address(RVA = "0xC01614", Offset = "0xC01614", VA = "0xC01614")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E1C4", Offset = "0x50E1C4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000114")]
		public float SwitchProgress
		{
			[Token(Token = "0x600056C")]
			[Address(RVA = "0xC01620", Offset = "0xC01620", VA = "0xC01620")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000115")]
		public override float Length
		{
			[Token(Token = "0x600056D")]
			[Address(RVA = "0xC01664", Offset = "0xC01664", VA = "0xC01664", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000116")]
		public override bool IsReady
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0xC018F4", Offset = "0xC018F4", VA = "0xC018F4", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000117")]
		private bool ShowRandomConnectionOptions
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0xC03610", Offset = "0xC03610", VA = "0xC03610")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xC013F4", Offset = "0xC013F4", VA = "0xC013F4")]
		public SplineController()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xC016C4", Offset = "0xC016C4", VA = "0xC016C4", Slot = "39")]
		public virtual void SwitchTo(CurvySpline destinationSpline, float destinationTf, float duration)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xC01778", Offset = "0xC01778", VA = "0xC01778")]
		public void FinishCurrentSwitch()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xC017C4", Offset = "0xC017C4", VA = "0xC017C4")]
		public void CancelCurrentSwitch()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xC017D4", Offset = "0xC017D4", VA = "0xC017D4")]
		public static float GetAngleBetweenConnectedSplines(CurvySplineSegment before, MovementDirection movementMode, CurvySplineSegment after, bool allowMovementModeChange)
		{
			return default(float);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xC0194C", Offset = "0xC0194C", VA = "0xC0194C", Slot = "21")]
		protected override void SavePrePlayState()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xC01994", Offset = "0xC01994", VA = "0xC01994", Slot = "22")]
		protected override void RestorePrePlayState()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xC019CC", Offset = "0xC019CC", VA = "0xC019CC", Slot = "31")]
		protected override float RelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xC01A18", Offset = "0xC01A18", VA = "0xC01A18", Slot = "30")]
		protected override float AbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xC01A64", Offset = "0xC01A64", VA = "0xC01A64", Slot = "32")]
		protected override Vector3 GetInterpolatedSourcePosition(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xC01B0C", Offset = "0xC01B0C", VA = "0xC01B0C", Slot = "33")]
		protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xC01C84", Offset = "0xC01C84", VA = "0xC01C84", Slot = "35")]
		protected override Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xC01D2C", Offset = "0xC01D2C", VA = "0xC01D2C", Slot = "34")]
		protected override Vector3 GetOrientation(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xC01DAC", Offset = "0xC01DAC", VA = "0xC01DAC", Slot = "28")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xC02858", Offset = "0xC02858", VA = "0xC02858", Slot = "29")]
		protected override void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xC02720", Offset = "0xC02720", VA = "0xC02720")]
		private void SimulateAdvanceOnSpline(ref float tf, ref MovementDirection curyDirection, CurvySpline spline, float distance)
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xC028BC", Offset = "0xC028BC", VA = "0xC028BC", Slot = "15")]
		protected override void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xC02968", Offset = "0xC02968", VA = "0xC02968", Slot = "16")]
		protected override void ComputeTargetPositionAndRotation(out Vector3 targetPosition, out Vector3 targetUp, out Vector3 targetForward)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xC02BF8", Offset = "0xC02BF8", VA = "0xC02BF8")]
		private static float MovementCompatibleGetPosition(SplineController controller, CurvyPositionMode positionMode, out CurvySplineSegment controlPoint, out bool isOnControlPoint, float clampedPosition)
		{
			return default(float);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xC02DCC", Offset = "0xC02DCC", VA = "0xC02DCC")]
		private static void MovementCompatibleSetPosition(SplineController controller, CurvyPositionMode positionMode, float specialClampedPosition)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xC01EE8", Offset = "0xC01EE8", VA = "0xC01EE8")]
		private void EventAwareMove(float distance)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xC02F18", Offset = "0xC02F18", VA = "0xC02F18")]
		private void HandleReachingNewControlPoint(CurvySplineSegment controlPoint, float controlPointPosition, CurvyPositionMode positionMode, float currentDelta, ref bool cancelMovement, out CurvySplineSegment postEventsControlPoint, out bool postEventsIsControllerOnControlPoint, out float postEventsControlPointPosition)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xC034B0", Offset = "0xC034B0", VA = "0xC034B0")]
		private void InvokeEventHandler(CurvySplineMoveEvent @event, CurvySplineMoveEventArgs eventArgument, CurvyPositionMode positionMode, ref CurvySplineSegment postEventsControlPoint, ref bool postEventsIsControllerOnControlPoint, ref float postEventsControlPointPosition)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xC03278", Offset = "0xC03278", VA = "0xC03278")]
		private CurvySplineSegment HandleRandomConnectionBehavior(CurvySplineSegment currentControlPoint, MovementDirection currentDirection, out MovementDirection newDirection, ReadOnlyCollection<CurvySplineSegment> connectedControlPoints)
		{
			return null;
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xC018AC", Offset = "0xC018AC", VA = "0xC018AC")]
		private static MovementDirection GetPostConnectionDirection(CurvySplineSegment connectedControlPoint, MovementDirection currentDirection, bool directionChangeAllowed)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xC03184", Offset = "0xC03184", VA = "0xC03184")]
		private CurvySplineSegment HandleFollowUpConnectionBehavior(CurvySplineSegment currentControlPoint, MovementDirection currentDirection, out MovementDirection newDirection)
		{
			return null;
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xC03594", Offset = "0xC03594", VA = "0xC03594")]
		private static MovementDirection HeadingToDirection(ConnectionHeadingEnum heading, CurvySplineSegment controlPoint, MovementDirection currentDirection)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xC02EA4", Offset = "0xC02EA4", VA = "0xC02EA4")]
		private static float GetControlPointPosition(CurvySplineSegment controlPoint, CurvyPositionMode positionMode)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000C5")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4FFBF8", Offset = "0x4FFBF8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4FFBF8", Offset = "0x4FFBF8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4FFBF8", Offset = "0x4FFBF8")]
	public class UITextSplineController : SplineController, IMeshModifier
	{
		[Token(Token = "0x20000C6")]
		protected interface IGlyph
		{
			[Token(Token = "0x1700011F")]
			Vector3 Center
			{
				[Token(Token = "0x60005A0")]
				get;
			}

			[Token(Token = "0x60005A1")]
			void Transpose(Vector3 v);

			[Token(Token = "0x60005A2")]
			void Rotate(Quaternion rotation);
		}

		[Token(Token = "0x20000C7")]
		protected class GlyphQuad : IGlyph
		{
			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIVertex[] V;

			[Token(Token = "0x40002CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rect Rect;

			[Token(Token = "0x17000120")]
			public Vector3 Center
			{
				[Token(Token = "0x60005A3")]
				[Address(RVA = "0xE7F2BC", Offset = "0xE7F2BC", VA = "0xE7F2BC", Slot = "4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0xE7F2DC", Offset = "0xE7F2DC", VA = "0xE7F2DC")]
			public void Load(List<UIVertex> verts, int index)
			{
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0xE7C3AC", Offset = "0xE7C3AC", VA = "0xE7C3AC")]
			public void LoadTris(List<UIVertex> verts, int index)
			{
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0xE7F4F4", Offset = "0xE7F4F4", VA = "0xE7F4F4")]
			public void calcRect()
			{
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0xE7F568", Offset = "0xE7F568", VA = "0xE7F568")]
			public void Save(List<UIVertex> verts, int index)
			{
			}

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0xE7C5C4", Offset = "0xE7C5C4", VA = "0xE7C5C4")]
			public void Save(VertexHelper vh)
			{
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xE7F720", Offset = "0xE7F720", VA = "0xE7F720", Slot = "5")]
			public void Transpose(Vector3 v)
			{
			}

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0xE7F790", Offset = "0xE7F790", VA = "0xE7F790", Slot = "6")]
			public void Rotate(Quaternion rotation)
			{
			}

			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xE7C344", Offset = "0xE7C344", VA = "0xE7C344")]
			public GlyphQuad()
			{
			}
		}

		[Token(Token = "0x20000C8")]
		protected class GlyphPlain : IGlyph
		{
			[Token(Token = "0x40002CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] V;

			[Token(Token = "0x40002CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rect Rect;

			[Token(Token = "0x17000121")]
			public Vector3 Center
			{
				[Token(Token = "0x60005AC")]
				[Address(RVA = "0xE7F0B8", Offset = "0xE7F0B8", VA = "0xE7F0B8", Slot = "4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60005AD")]
			[Address(RVA = "0xE7B9F8", Offset = "0xE7B9F8", VA = "0xE7B9F8")]
			public void Load(ref Vector3[] verts, int index)
			{
			}

			[Token(Token = "0x60005AE")]
			[Address(RVA = "0xE7F0D8", Offset = "0xE7F0D8", VA = "0xE7F0D8")]
			public void calcRect()
			{
			}

			[Token(Token = "0x60005AF")]
			[Address(RVA = "0xE7C08C", Offset = "0xE7C08C", VA = "0xE7C08C")]
			public void Save(ref Vector3[] verts, int index)
			{
			}

			[Token(Token = "0x60005B0")]
			[Address(RVA = "0xE7F14C", Offset = "0xE7F14C", VA = "0xE7F14C", Slot = "5")]
			public void Transpose(Vector3 v)
			{
			}

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0xE7F1BC", Offset = "0xE7F1BC", VA = "0xE7F1BC", Slot = "6")]
			public void Rotate(Quaternion rotation)
			{
			}

			[Token(Token = "0x60005B2")]
			[Address(RVA = "0xE7B990", Offset = "0xE7B990", VA = "0xE7B990")]
			public GlyphPlain()
			{
			}
		}

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x505248", Offset = "0x505248")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x505248", Offset = "0x505248")]
		[SerializeField]
		private bool staticOrientation;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Graphic m_Graphic;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private RectTransform mRect;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Text mText;

		[Token(Token = "0x17000118")]
		public bool StaticOrientation
		{
			[Token(Token = "0x600058B")]
			[Address(RVA = "0xE7B5BC", Offset = "0xE7B5BC", VA = "0xE7B5BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600058C")]
			[Address(RVA = "0xE7B5C4", Offset = "0xE7B5C4", VA = "0xE7B5C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000119")]
		protected override bool ShowOrientationSection
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0xE7B5D0", Offset = "0xE7B5D0", VA = "0xE7B5D0", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011A")]
		protected override bool ShowOffsetSection
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0xE7B5D8", Offset = "0xE7B5D8", VA = "0xE7B5D8", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011B")]
		protected Text Text
		{
			[Token(Token = "0x600058F")]
			[Address(RVA = "0xE7B5E0", Offset = "0xE7B5E0", VA = "0xE7B5E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011C")]
		protected RectTransform Rect
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0xE7B694", Offset = "0xE7B694", VA = "0xE7B694")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011D")]
		protected Graphic graphic
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0xE7B748", Offset = "0xE7B748", VA = "0xE7B748")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011E")]
		public override CurvySpline Spline
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0xE7C750", Offset = "0xE7C750", VA = "0xE7C750", Slot = "37")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000599")]
			[Address(RVA = "0xE7C758", Offset = "0xE7C758", VA = "0xE7C758", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xE7B7FC", Offset = "0xE7B7FC", VA = "0xE7B7FC", Slot = "15")]
		protected override void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xE7B83C", Offset = "0xE7B83C", VA = "0xE7B83C", Slot = "40")]
		public void ModifyMesh(Mesh verts)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xE7C1C4", Offset = "0xE7C1C4", VA = "0xE7C1C4", Slot = "41")]
		public void ModifyMesh(VertexHelper vertexHelper)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xE7BB30", Offset = "0xE7BB30", VA = "0xE7BB30")]
		private void UpdateGlyph(IGlyph glyph)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xE7C5E8", Offset = "0xE7C5E8", VA = "0xE7C5E8", Slot = "7")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xE7C69C", Offset = "0xE7C69C", VA = "0xE7C69C", Slot = "9")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xE7CA98", Offset = "0xE7CA98", VA = "0xE7CA98", Slot = "19")]
		protected override void BindEvents()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xE7CAC0", Offset = "0xE7CAC0", VA = "0xE7CAC0", Slot = "20")]
		protected override void UnbindEvents()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xE7C954", Offset = "0xE7C954", VA = "0xE7C954")]
		private void BindSplineRelatedEvents()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xE7C818", Offset = "0xE7C818", VA = "0xE7C818")]
		private void UnbindSplineRelatedEvents()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xE7CAE8", Offset = "0xE7CAE8", VA = "0xE7CAE8")]
		private void OnSplineRefreshed(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xE7CC84", Offset = "0xE7CC84", VA = "0xE7CC84")]
		public UITextSplineController()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4FFCA0", Offset = "0x4FFCA0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4FFCA0", Offset = "0x4FFCA0")]
	public class VolumeController : CurvyController
	{
		[Token(Token = "0x40002CD")]
		private const float CrossPositionRangeMin = -0.5f;

		[Token(Token = "0x40002CE")]
		private const float CrossPositionRangeMax = 0.5f;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[AttributeAttribute(Name = "CGDataReferenceSelectorAttribute", RVA = "0x5052C4", Offset = "0x5052C4")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x5052C4", Offset = "0x5052C4")]
		private CGDataReference m_Volume;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[FloatRegion]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x505380", Offset = "0x505380")]
		private FloatRegion m_CrossRange;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x505448", Offset = "0x505448")]
		private float crossRelativePosition;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CurvyClamping m_CrossClamping;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[HideInInspector]
		[SerializeField]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5054F0", Offset = "0x5054F0")]
		private float m_CrossInitialPosition;

		[Token(Token = "0x17000122")]
		public CGDataReference Volume
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0xE7D5D8", Offset = "0xE7D5D8", VA = "0xE7D5D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0xE7D5E0", Offset = "0xE7D5E0", VA = "0xE7D5E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000123")]
		public CGVolume VolumeData
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0xE7D5E8", Offset = "0xE7D5E8", VA = "0xE7D5E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000124")]
		public float CrossFrom
		{
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0xE7D65C", Offset = "0xE7D65C", VA = "0xE7D65C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0xE7D664", Offset = "0xE7D664", VA = "0xE7D664")]
			set
			{
			}
		}

		[Token(Token = "0x17000125")]
		public float CrossTo
		{
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0xE7D694", Offset = "0xE7D694", VA = "0xE7D694")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xE7D69C", Offset = "0xE7D69C", VA = "0xE7D69C")]
			set
			{
			}
		}

		[Token(Token = "0x17000126")]
		public float CrossLength
		{
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0xE7D6CC", Offset = "0xE7D6CC", VA = "0xE7D6CC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000127")]
		public CurvyClamping CrossClamping
		{
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0xE7D6D8", Offset = "0xE7D6D8", VA = "0xE7D6D8")]
			get
			{
				return default(CurvyClamping);
			}
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0xE7D6E0", Offset = "0xE7D6E0", VA = "0xE7D6E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000128")]
		public float CrossRelativePosition
		{
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0xE7D6E8", Offset = "0xE7D6E8", VA = "0xE7D6E8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005BE")]
			[Address(RVA = "0xE7D714", Offset = "0xE7D714", VA = "0xE7D714")]
			set
			{
			}
		}

		[Token(Token = "0x17000129")]
		public override float Length
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0xE7D744", Offset = "0xE7D744", VA = "0xE7D744", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700012A")]
		public override bool IsReady
		{
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0xE7D86C", Offset = "0xE7D86C", VA = "0xE7D86C", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012B")]
		private RegionOptions<float> CrossRangeOptions
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0xE7DDB0", Offset = "0xE7DDB0", VA = "0xE7DDB0")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x1700012C")]
		private float MinCrossRelativePosition
		{
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0xE7DE20", Offset = "0xE7DE20", VA = "0xE7DE20")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700012D")]
		private float MaxCrossRelativePosition
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0xE7DE28", Offset = "0xE7DE28", VA = "0xE7DE28")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xE7D784", Offset = "0xE7D784", VA = "0xE7D784")]
		public float CrossRelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xE7D7F8", Offset = "0xE7D7F8", VA = "0xE7D7F8")]
		public float CrossAbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xE7D8BC", Offset = "0xE7D8BC", VA = "0xE7D8BC", Slot = "31")]
		protected override float RelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xE7D918", Offset = "0xE7D918", VA = "0xE7D918", Slot = "30")]
		protected override float AbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xE7D974", Offset = "0xE7D974", VA = "0xE7D974", Slot = "32")]
		protected override Vector3 GetInterpolatedSourcePosition(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xE7DA0C", Offset = "0xE7DA0C", VA = "0xE7DA0C", Slot = "33")]
		protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xE7DB10", Offset = "0xE7DB10", VA = "0xE7DB10", Slot = "35")]
		protected override Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xE7DBA8", Offset = "0xE7DBA8", VA = "0xE7DBA8", Slot = "34")]
		protected override Vector3 GetOrientation(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xE7DC40", Offset = "0xE7DC40", VA = "0xE7DC40", Slot = "28")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xE7DCBC", Offset = "0xE7DCBC", VA = "0xE7DCBC", Slot = "29")]
		protected override void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xE7D700", Offset = "0xE7D700", VA = "0xE7D700")]
		private float GetClampedCrossPosition(float position)
		{
			return default(float);
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xE7DE30", Offset = "0xE7DE30", VA = "0xE7DE30", Slot = "36")]
		public override void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xE7DE88", Offset = "0xE7DE88", VA = "0xE7DE88")]
		public VolumeController()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Components
{
	[Token(Token = "0x20000CA")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4FFD04", Offset = "0x4FFD04")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4FFD04", Offset = "0x4FFD04")]
	public class CurvyGLRenderer : MonoBehaviour
	{
		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[ArrayEx]
		public List<GLSlotData> Splines;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material lineMaterial;

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xBAEC64", Offset = "0xBAEC64", VA = "0xBAEC64")]
		private void CreateLineMaterial()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xBAED84", Offset = "0xBAED84", VA = "0xBAED84")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xBAEFA4", Offset = "0xBAEFA4", VA = "0xBAEFA4")]
		private void sanitize()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xBAF0F4", Offset = "0xBAF0F4", VA = "0xBAF0F4")]
		private void OnSplineRefresh(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xBAF280", Offset = "0xBAF280", VA = "0xBAF280")]
		private GLSlotData getSlot(CurvySpline spline)
		{
			return null;
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xBAF440", Offset = "0xBAF440", VA = "0xBAF440")]
		public void Add(CurvySpline spline)
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xBAF534", Offset = "0xBAF534", VA = "0xBAF534")]
		public void Remove(CurvySpline spline)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xBAF658", Offset = "0xBAF658", VA = "0xBAF658")]
		public CurvyGLRenderer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CB")]
	public class GLSlotData
	{
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		public CurvySpline Spline;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color LineColor;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Vector3[]> VertexData;

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xEBBE94", Offset = "0xEBBE94", VA = "0xEBBE94")]
		public void GetVertexData()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xEBC01C", Offset = "0xEBC01C", VA = "0xEBC01C")]
		public void Render(Material mat)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xEBC20C", Offset = "0xEBC20C", VA = "0xEBC20C")]
		public GLSlotData()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4FFD64", Offset = "0x4FFD64")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4FFD64", Offset = "0x4FFD64")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x4FFD64", Offset = "0x4FFD64")]
	public class CurvyLineRenderer : MonoBehaviour
	{
		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvySpline m_Spline;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LineRenderer mRenderer;

		[Token(Token = "0x1700012E")]
		public CurvySpline Spline
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0xBB5708", Offset = "0xBB5708", VA = "0xBB5708")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0xBB5710", Offset = "0xBB5710", VA = "0xBB5710")]
			set
			{
			}
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xBB5C88", Offset = "0xBB5C88", VA = "0xBB5C88")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xBB5DF4", Offset = "0xBB5DF4", VA = "0xBB5DF4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xBB5E58", Offset = "0xBB5E58", VA = "0xBB5E58")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xBB5E5C", Offset = "0xBB5E5C", VA = "0xBB5E5C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xBB5E60", Offset = "0xBB5E60", VA = "0xBB5E60")]
		private void Update()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xBB5E64", Offset = "0xBB5E64", VA = "0xBB5E64")]
		private void EnforceWorldSpaceUsage()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xBB5B50", Offset = "0xBB5B50", VA = "0xBB5B50")]
		public void Refresh()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xBB605C", Offset = "0xBB605C", VA = "0xBB605C")]
		private void OnSplineRefresh(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xBB6060", Offset = "0xBB6060", VA = "0xBB6060")]
		private void OnSplineCoordinatesChanged(CurvySpline spline)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xBB598C", Offset = "0xBB598C", VA = "0xBB598C")]
		private void BindEvents()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xBB57C8", Offset = "0xBB57C8", VA = "0xBB57C8")]
		private void UnbindEvents()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xBB6064", Offset = "0xBB6064", VA = "0xBB6064")]
		public CurvyLineRenderer()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Shapes
{
	[Token(Token = "0x20000CD")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4FFE1C", Offset = "0x4FFE1C")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x4FFE1C", Offset = "0x4FFE1C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4FFE1C", Offset = "0x4FFE1C")]
	public class CSCircle : CurvyShape2D
	{
		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Positive]
		[SerializeField]
		private int m_Count;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_Radius;

		[Token(Token = "0x1700012F")]
		public int Count
		{
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0xB854E4", Offset = "0xB854E4", VA = "0xB854E4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0xB854EC", Offset = "0xB854EC", VA = "0xB854EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000130")]
		public float Radius
		{
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xB8552C", Offset = "0xB8552C", VA = "0xB8552C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0xB85534", Offset = "0xB85534", VA = "0xB85534")]
			set
			{
			}
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xB85578", Offset = "0xB85578", VA = "0xB85578", Slot = "4")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xB855EC", Offset = "0xB855EC", VA = "0xB855EC", Slot = "5")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xB85720", Offset = "0xB85720", VA = "0xB85720")]
		public CSCircle()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4FFEC8", Offset = "0x4FFEC8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4FFEC8", Offset = "0x4FFEC8")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x4FFEC8", Offset = "0x4FFEC8")]
	public class CSPie : CSCircle
	{
		[Token(Token = "0x20000CF")]
		public enum EatModeEnum
		{
			[Token(Token = "0x40002E1")]
			Left,
			[Token(Token = "0x40002E2")]
			Right,
			[Token(Token = "0x40002E3")]
			Center
		}

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5055F8", Offset = "0x5055F8")]
		[SerializeField]
		private float m_Roundness;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x505638", Offset = "0x505638")]
		private int m_Empty;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x5056B8", Offset = "0x5056B8")]
		private EatModeEnum m_Eat;

		[Token(Token = "0x17000131")]
		public float Roundness
		{
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0xB85734", Offset = "0xB85734", VA = "0xB85734")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0xB8573C", Offset = "0xB8573C", VA = "0xB8573C")]
			set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public int Empty
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xB85778", Offset = "0xB85778", VA = "0xB85778")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0xB85780", Offset = "0xB85780", VA = "0xB85780")]
			set
			{
			}
		}

		[Token(Token = "0x17000133")]
		private int maxEmpty
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0xB857C8", Offset = "0xB857C8", VA = "0xB857C8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000134")]
		public EatModeEnum Eat
		{
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0xB857D0", Offset = "0xB857D0", VA = "0xB857D0")]
			get
			{
				return default(EatModeEnum);
			}
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0xB857D8", Offset = "0xB857D8", VA = "0xB857D8")]
			set
			{
			}
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xB857F4", Offset = "0xB857F4", VA = "0xB857F4", Slot = "4")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xB8587C", Offset = "0xB8587C", VA = "0xB8587C")]
		private Vector3 cpPosition(int i, int empty, float d)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xB85908", Offset = "0xB85908", VA = "0xB85908", Slot = "5")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xB85FAC", Offset = "0xB85FAC", VA = "0xB85FAC")]
		public CSPie()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4FFF74", Offset = "0x4FFF74")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x4FFF74", Offset = "0x4FFF74")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x4FFF74", Offset = "0x4FFF74")]
	public class CSRectangle : CurvyShape2D
	{
		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Positive]
		[SerializeField]
		private float m_Width;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Positive]
		private float m_Height;

		[Token(Token = "0x17000135")]
		public float Width
		{
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0xB85FC8", Offset = "0xB85FC8", VA = "0xB85FC8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0xB85FD0", Offset = "0xB85FD0", VA = "0xB85FD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public float Height
		{
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0xB86014", Offset = "0xB86014", VA = "0xB86014")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0xB8601C", Offset = "0xB8601C", VA = "0xB8601C")]
			set
			{
			}
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xB86060", Offset = "0xB86060", VA = "0xB86060", Slot = "4")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xB860D4", Offset = "0xB860D4", VA = "0xB860D4", Slot = "5")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xB8627C", Offset = "0xB8627C", VA = "0xB8627C")]
		public CSRectangle()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x500020", Offset = "0x500020")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x500020", Offset = "0x500020")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x500020", Offset = "0x500020")]
	public class CSRoundedRectangle : CurvyShape2D
	{
		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Positive]
		[SerializeField]
		private float m_Width;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Positive]
		[SerializeField]
		private float m_Height;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5057F0", Offset = "0x5057F0")]
		[SerializeField]
		private float m_Roundness;

		[Token(Token = "0x17000137")]
		public float Width
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0xB8628C", Offset = "0xB8628C", VA = "0xB8628C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000604")]
			[Address(RVA = "0xB86294", Offset = "0xB86294", VA = "0xB86294")]
			set
			{
			}
		}

		[Token(Token = "0x17000138")]
		public float Height
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0xB862D8", Offset = "0xB862D8", VA = "0xB862D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000606")]
			[Address(RVA = "0xB862E0", Offset = "0xB862E0", VA = "0xB862E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000139")]
		public float Roundness
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0xB86324", Offset = "0xB86324", VA = "0xB86324")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000608")]
			[Address(RVA = "0xB8632C", Offset = "0xB8632C", VA = "0xB8632C")]
			set
			{
			}
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xB86368", Offset = "0xB86368", VA = "0xB86368", Slot = "4")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xB86400", Offset = "0xB86400", VA = "0xB86400", Slot = "5")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xB86964", Offset = "0xB86964", VA = "0xB86964")]
		public CSRoundedRectangle()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5000CC", Offset = "0x5000CC")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x5000CC", Offset = "0x5000CC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x5000CC", Offset = "0x5000CC")]
	public class CSSpiral : CurvyShape2D
	{
		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Positive]
		[SerializeField]
		private int m_Count;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Positive]
		[SerializeField]
		private float m_Circles;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Positive]
		private float m_Radius;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x505938", Offset = "0x505938")]
		private AnimationCurve m_RadiusFactor;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationCurve m_Z;

		[Token(Token = "0x1700013A")]
		public int Count
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0xB8697C", Offset = "0xB8697C", VA = "0xB8697C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600060D")]
			[Address(RVA = "0xB86984", Offset = "0xB86984", VA = "0xB86984")]
			set
			{
			}
		}

		[Token(Token = "0x1700013B")]
		public float Circles
		{
			[Token(Token = "0x600060E")]
			[Address(RVA = "0xB869C4", Offset = "0xB869C4", VA = "0xB869C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600060F")]
			[Address(RVA = "0xB869CC", Offset = "0xB869CC", VA = "0xB869CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700013C")]
		public float Radius
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0xB86A10", Offset = "0xB86A10", VA = "0xB86A10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000611")]
			[Address(RVA = "0xB86A18", Offset = "0xB86A18", VA = "0xB86A18")]
			set
			{
			}
		}

		[Token(Token = "0x1700013D")]
		public AnimationCurve RadiusFactor
		{
			[Token(Token = "0x6000612")]
			[Address(RVA = "0xB86A5C", Offset = "0xB86A5C", VA = "0xB86A5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000613")]
			[Address(RVA = "0xB86A64", Offset = "0xB86A64", VA = "0xB86A64")]
			set
			{
			}
		}

		[Token(Token = "0x1700013E")]
		public AnimationCurve Z
		{
			[Token(Token = "0x6000614")]
			[Address(RVA = "0xB86A9C", Offset = "0xB86A9C", VA = "0xB86A9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000615")]
			[Address(RVA = "0xB86AA4", Offset = "0xB86AA4", VA = "0xB86AA4")]
			set
			{
			}
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xB86ADC", Offset = "0xB86ADC", VA = "0xB86ADC", Slot = "4")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xB86BF8", Offset = "0xB86BF8", VA = "0xB86BF8", Slot = "5")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xB86D44", Offset = "0xB86D44", VA = "0xB86D44")]
		public CSSpiral()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x500178", Offset = "0x500178")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x500178", Offset = "0x500178")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x500178", Offset = "0x500178")]
	public class CSStar : CurvyShape2D
	{
		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Positive]
		private int m_Sides;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Positive]
		private float m_OuterRadius;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x505A3C", Offset = "0x505A3C")]
		private float m_OuterRoundness;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Positive]
		private float m_InnerRadius;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x505AE4", Offset = "0x505AE4")]
		private float m_InnerRoundness;

		[Token(Token = "0x1700013F")]
		public int Sides
		{
			[Token(Token = "0x6000619")]
			[Address(RVA = "0xB86DD8", Offset = "0xB86DD8", VA = "0xB86DD8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600061A")]
			[Address(RVA = "0xB86DE0", Offset = "0xB86DE0", VA = "0xB86DE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000140")]
		public float OuterRadius
		{
			[Token(Token = "0x600061B")]
			[Address(RVA = "0xB86E20", Offset = "0xB86E20", VA = "0xB86E20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600061C")]
			[Address(RVA = "0xB86E28", Offset = "0xB86E28", VA = "0xB86E28")]
			set
			{
			}
		}

		[Token(Token = "0x17000141")]
		public float OuterRoundness
		{
			[Token(Token = "0x600061D")]
			[Address(RVA = "0xB86E74", Offset = "0xB86E74", VA = "0xB86E74")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600061E")]
			[Address(RVA = "0xB86E7C", Offset = "0xB86E7C", VA = "0xB86E7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000142")]
		public float InnerRadius
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0xB86EC0", Offset = "0xB86EC0", VA = "0xB86EC0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000620")]
			[Address(RVA = "0xB86EC8", Offset = "0xB86EC8", VA = "0xB86EC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000143")]
		public float InnerRoundness
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0xB86F0C", Offset = "0xB86F0C", VA = "0xB86F0C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000622")]
			[Address(RVA = "0xB86F14", Offset = "0xB86F14", VA = "0xB86F14")]
			set
			{
			}
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xB86F58", Offset = "0xB86F58", VA = "0xB86F58", Slot = "4")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xB87044", Offset = "0xB87044", VA = "0xB87044", Slot = "5")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xB87230", Offset = "0xB87230", VA = "0xB87230")]
		public CSStar()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Utils
{
	[Token(Token = "0x20000D4")]
	public static class OptimizedOperators
	{
		[Token(Token = "0x6000626")]
		[Address(RVA = "0xBFBA58", Offset = "0xBFBA58", VA = "0xBFBA58")]
		public static Vector3 Addition(this Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xBFBA68", Offset = "0xBFBA68", VA = "0xBFBA68")]
		public static Vector3 UnaryNegation(this Vector3 a)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xBFBA78", Offset = "0xBFBA78", VA = "0xBFBA78")]
		public static Vector3 Subtraction(this Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xBFBA88", Offset = "0xBFBA88", VA = "0xBFBA88")]
		public static Vector3 Multiply(this Vector3 a, float d)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xBFBA98", Offset = "0xBFBA98", VA = "0xBFBA98")]
		public static Vector3 Multiply(this float d, Vector3 a)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xBFBAAC", Offset = "0xBFBAAC", VA = "0xBFBAAC")]
		public static Vector3 Division(this Vector3 a, float d)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xBFBAC4", Offset = "0xBFBAC4", VA = "0xBFBAC4")]
		public static Vector3 Normalize(this Vector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xBFBBA4", Offset = "0xBFBBA4", VA = "0xBFBBA4")]
		public static Vector3 LerpUnclamped(this Vector3 a, Vector3 b, float t)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000D5")]
	public static class CurvyUtility
	{
		[Token(Token = "0x600062E")]
		[Address(RVA = "0xEB638C", Offset = "0xEB638C", VA = "0xEB638C")]
		public static float ClampTF(float tf, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xEB6400", Offset = "0xEB6400", VA = "0xEB6400")]
		public static float ClampTF(float tf, ref int dir, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xEB64CC", Offset = "0xEB64CC", VA = "0xEB64CC")]
		public static float ClampValue(float tf, CurvyClamping clamping, float minTF, float maxTF)
		{
			return default(float);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xEB65B8", Offset = "0xEB65B8", VA = "0xEB65B8")]
		public static float ClampDistance(float distance, CurvyClamping clamping, float length)
		{
			return default(float);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xEB6644", Offset = "0xEB6644", VA = "0xEB6644")]
		public static float ClampDistance(float distance, CurvyClamping clamping, float length, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xEB6748", Offset = "0xEB6748", VA = "0xEB6748")]
		public static float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float length)
		{
			return default(float);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xEB683C", Offset = "0xEB683C", VA = "0xEB683C")]
		public static float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float length, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xEB6964", Offset = "0xEB6964", VA = "0xEB6964")]
		public static Material GetDefaultMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xEB6A80", Offset = "0xEB6A80", VA = "0xEB6A80")]
		public static bool Approximately(this float x, float y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xEB2EF4", Offset = "0xEB2EF4", VA = "0xEB2EF4")]
		public static int InterpolationSearch(float[] array, float x)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000D6")]
	public class Spline2Mesh
	{
		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<SplinePolyLine> Lines;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WindingRule Winding;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 UVTiling;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector2 UVOffset;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool SuppressUVMapping;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool UV2;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string MeshName;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool VertexLineOnly;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x505B54", Offset = "0x505B54")]
		private string <Error>k__BackingField;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Tess mTess;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Mesh mMesh;

		[Token(Token = "0x17000144")]
		public string Error
		{
			[Token(Token = "0x6000638")]
			[Address(RVA = "0xC00A0C", Offset = "0xC00A0C", VA = "0xC00A0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E264", Offset = "0x50E264")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000639")]
			[Address(RVA = "0xC00A14", Offset = "0xC00A14", VA = "0xC00A14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E274", Offset = "0x50E274")]
			private set
			{
			}
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xC00A1C", Offset = "0xC00A1C", VA = "0xC00A1C")]
		public bool Apply(out Mesh result)
		{
			return default(bool);
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xC00F68", Offset = "0xC00F68", VA = "0xC00F68")]
		private bool triangulate()
		{
			return default(bool);
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xC012EC", Offset = "0xC012EC", VA = "0xC012EC")]
		private static bool polyLineIsValid(SplinePolyLine pl)
		{
			return default(bool);
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xC0132C", Offset = "0xC0132C", VA = "0xC0132C")]
		public Spline2Mesh()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D7")]
	public class SplinePolyLine
	{
		[Token(Token = "0x20000D8")]
		public enum VertexCalculation
		{
			[Token(Token = "0x4000305")]
			ByApproximation,
			[Token(Token = "0x4000306")]
			ByAngle
		}

		[Token(Token = "0x20000D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x500244", Offset = "0x500244")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Vector3> vPos;

			[Token(Token = "0x4000308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 curPos;

			[Token(Token = "0x4000309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<Vector3> vTan;

			[Token(Token = "0x400030A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 curTangent;

			[Token(Token = "0x400030B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public List<float> vTF;

			[Token(Token = "0x400030C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float angleFromLast;

			[Token(Token = "0x400030D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float distAccu;

			[Token(Token = "0x400030E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public int linearSteps;

			[Token(Token = "0x6000644")]
			[Address(RVA = "0xE740F4", Offset = "0xE740F4", VA = "0xE740F4")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0xE7EFE8", Offset = "0xE7EFE8", VA = "0xE7EFE8")]
			internal void <GetPolygon>b__0(float f)
			{
			}
		}

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ContourOrientation Orientation;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvySpline Spline;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VertexCalculation VertexMode;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float Angle;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Distance;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Space Space;

		[Token(Token = "0x17000145")]
		public bool IsClosed
		{
			[Token(Token = "0x6000641")]
			[Address(RVA = "0xE7395C", Offset = "0xE7395C", VA = "0xE7395C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xE73864", Offset = "0xE73864", VA = "0xE73864")]
		public SplinePolyLine(CurvySpline spline)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xE73904", Offset = "0xE73904", VA = "0xE73904")]
		public SplinePolyLine(CurvySpline spline, float angle, float distance)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xE738A0", Offset = "0xE738A0", VA = "0xE738A0")]
		private SplinePolyLine(CurvySpline spline, VertexCalculation vertexMode, float angle, float distance, Space space = Space.World)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xE739EC", Offset = "0xE739EC", VA = "0xE739EC")]
		public Vector3[] GetVertices()
		{
			return null;
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xE73B24", Offset = "0xE73B24", VA = "0xE73B24")]
		private static Vector3[] GetPolygon(CurvySpline spline, float fromTF, float toTF, float maxAngle, float minDistance, float maxDistance, out List<float> vertexTF, out List<Vector3> vertexTangents, bool includeEndPoint = true, float stepSize = 0.01f)
		{
			return null;
		}
	}
}
namespace FluffyUnderware.Curvy.Generator
{
	[Token(Token = "0x20000DA")]
	public abstract class SplineInputModuleBase : CGModule
	{
		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x505B64", Offset = "0x505B64")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x505B64", Offset = "0x505B64")]
		[SerializeField]
		private bool m_UseCache;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x505BD4", Offset = "0x505BD4")]
		[SerializeField]
		private bool m_UseGlobalSpace;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x505C20", Offset = "0x505C20")]
		[SerializeField]
		protected CurvySplineSegment m_StartCP;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x505C6C", Offset = "0x505C6C")]
		[SerializeField]
		protected CurvySplineSegment m_EndCP;

		[Token(Token = "0x17000146")]
		public bool UseCache
		{
			[Token(Token = "0x6000646")]
			[Address(RVA = "0xC03624", Offset = "0xC03624", VA = "0xC03624")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000647")]
			[Address(RVA = "0xC0362C", Offset = "0xC0362C", VA = "0xC0362C")]
			set
			{
			}
		}

		[Token(Token = "0x17000147")]
		public CurvySplineSegment StartCP
		{
			[Token(Token = "0x6000648")]
			[Address(RVA = "0xC03654", Offset = "0xC03654", VA = "0xC03654")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000649")]
			[Address(RVA = "0xC0365C", Offset = "0xC0365C", VA = "0xC0365C")]
			set
			{
			}
		}

		[Token(Token = "0x17000148")]
		public CurvySplineSegment EndCP
		{
			[Token(Token = "0x600064A")]
			[Address(RVA = "0xC03704", Offset = "0xC03704", VA = "0xC03704")]
			get
			{
				return null;
			}
			[Token(Token = "0x600064B")]
			[Address(RVA = "0xC0370C", Offset = "0xC0370C", VA = "0xC0370C")]
			set
			{
			}
		}

		[Token(Token = "0x17000149")]
		public bool UseGlobalSpace
		{
			[Token(Token = "0x600064C")]
			[Address(RVA = "0xC037B4", Offset = "0xC037B4", VA = "0xC037B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600064D")]
			[Address(RVA = "0xC037BC", Offset = "0xC037BC", VA = "0xC037BC")]
			set
			{
			}
		}

		[Token(Token = "0x1700014A")]
		public override bool IsConfigured
		{
			[Token(Token = "0x600064E")]
			[Address(RVA = "0xC037D0", Offset = "0xC037D0", VA = "0xC037D0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700014B")]
		public override bool IsInitialized
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0xC03874", Offset = "0xC03874", VA = "0xC03874", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700014C")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0xC03940", Offset = "0xC03940", VA = "0xC03940", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700014D")]
		protected abstract CurvySpline InputSpline
		{
			[Token(Token = "0x6000660")]
			get;
			[Token(Token = "0x6000661")]
			set;
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xC03A5C", Offset = "0xC03A5C", VA = "0xC03A5C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xC03AA4", Offset = "0xC03AA4", VA = "0xC03AA4", Slot = "6")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xC03CB0", Offset = "0xC03CB0", VA = "0xC03CB0", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xC03D30", Offset = "0xC03D30", VA = "0xC03D30")]
		private void OnSplineRefreshed(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xC03EBC", Offset = "0xC03EBC", VA = "0xC03EBC")]
		private void OnInputSplineCoordinatesChanged(CurvySpline sender)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xC03EB0", Offset = "0xC03EB0", VA = "0xC03EB0")]
		private void ForceRefresh()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xC0407C", Offset = "0xC0407C", VA = "0xC0407C")]
		private float getPathLength(CurvySpline spline)
		{
			return default(float);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xC03998", Offset = "0xC03998", VA = "0xC03998")]
		private bool getPathClosed(CurvySpline spline)
		{
			return default(bool);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xBF428C", Offset = "0xBF428C", VA = "0xBF428C")]
		protected CGData GetSplineData(CurvySpline spline, bool fullPath, CGDataRequestRasterization raster, CGDataRequestMetaCGOptions options)
		{
			return null;
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xC04314", Offset = "0xC04314", VA = "0xC04314")]
		private static void FillData(CGShape dataToFill, SamplePointsMaterialGroup materialGroup, List<float> sourceFs, List<float> relativeFs, bool isFullPath, List<Vector3> positions, List<Vector3> tangents, List<Vector3> normals, bool considerSplineTransform, Transform splineTransform, Transform generatorTransform)
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xC0418C", Offset = "0xC0418C", VA = "0xC0418C")]
		private static void AddPoint(float sourceF, float relativeF, bool isFullPath, Vector3 position, Vector3 tangent, Vector3 up, List<float> sourceFList, List<float> relativeFList, List<Vector3> positionList, List<Vector3> tangentList, List<Vector3> upList)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xC046A8", Offset = "0xC046A8", VA = "0xC046A8")]
		private static bool MoveByAngleExt(CurvySpline spline, bool useCache, ref float tf, float maxDistance, float maxAngle, out Vector3 pos, out Vector3 tan, float stopTF, bool loop, float stepDist)
		{
			return default(bool);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xC048B8", Offset = "0xC048B8", VA = "0xC048B8")]
		private static void CalculateExtendedUV(CurvySpline spline, float startTF, float endTF, List<SamplePointUData> ext, CGShape data)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xC050BC", Offset = "0xC050BC", VA = "0xC050BC")]
		private static MetaCGOptions findPreviousReferenceCPOptions(CurvySpline spline, float tf, out CurvySplineSegment cp)
		{
			return null;
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xC05230", Offset = "0xC05230", VA = "0xC05230")]
		private static MetaCGOptions findNextReferenceCPOptions(CurvySpline spline, float tf, out CurvySplineSegment cp)
		{
			return null;
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xBF6054", Offset = "0xBF6054", VA = "0xBF6054", Slot = "17")]
		protected virtual void OnSplineAssigned()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xBF3DE0", Offset = "0xBF3DE0", VA = "0xBF3DE0")]
		protected void ValidateStartAndEndCps()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xBF5A90", Offset = "0xBF5A90", VA = "0xBF5A90")]
		protected SplineInputModuleBase()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public abstract class TRSModuleBase : CGModule
	{
		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x505CD4", Offset = "0x505CD4")]
		[SerializeField]
		private Vector3 m_Transpose;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x505D3C", Offset = "0x505D3C")]
		private Vector3 m_Rotation;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x505DA4", Offset = "0x505DA4")]
		private Vector3 m_Scale;

		[Token(Token = "0x1700014E")]
		public Vector3 Transpose
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0xE744D0", Offset = "0xE744D0", VA = "0xE744D0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000666")]
			[Address(RVA = "0xE744DC", Offset = "0xE744DC", VA = "0xE744DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700014F")]
		public Vector3 Rotation
		{
			[Token(Token = "0x6000667")]
			[Address(RVA = "0xE7454C", Offset = "0xE7454C", VA = "0xE7454C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000668")]
			[Address(RVA = "0xE74558", Offset = "0xE74558", VA = "0xE74558")]
			set
			{
			}
		}

		[Token(Token = "0x17000150")]
		public Vector3 Scale
		{
			[Token(Token = "0x6000669")]
			[Address(RVA = "0xE745C8", Offset = "0xE745C8", VA = "0xE745C8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600066A")]
			[Address(RVA = "0xE745D4", Offset = "0xE745D4", VA = "0xE745D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000151")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0xE74644", Offset = "0xE74644", VA = "0xE74644")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xE746E8", Offset = "0xE746E8", VA = "0xE746E8", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xE74730", Offset = "0xE74730", VA = "0xE74730", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xE74780", Offset = "0xE74780", VA = "0xE74780")]
		protected TRSModuleBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000DC")]
	public class CGBoundsGroup : CGWeightedItem
	{
		[Token(Token = "0x20000DD")]
		public enum RotationModeEnum
		{
			[Token(Token = "0x4000332")]
			Full,
			[Token(Token = "0x4000333")]
			Direction,
			[Token(Token = "0x4000334")]
			Horizontal,
			[Token(Token = "0x4000335")]
			Independent
		}

		[Token(Token = "0x20000DE")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x500254", Offset = "0x500254")]
		private enum DistributionModeEnum
		{
			[Token(Token = "0x4000337")]
			Parent,
			[Token(Token = "0x4000338")]
			Self
		}

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_Name;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x505E1C", Offset = "0x505E1C")]
		private bool m_KeepTogether;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_SpaceBefore;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_SpaceAfter;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_CrossBase;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x505F70", Offset = "0x505F70")]
		[SerializeField]
		private bool m_IgnoreModuleCrossBase;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x505FBC", Offset = "0x505FBC")]
		private bool m_RandomizeItems;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[IntRegion]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x506008", Offset = "0x506008")]
		private IntRegion m_RepeatingItems;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x506090", Offset = "0x506090")]
		private bool m_RelativeTranslation;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_TranslationX;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_TranslationY;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_TranslationZ;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5061B8", Offset = "0x5061B8")]
		[SerializeField]
		private RotationModeEnum m_RotationMode;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_RotationX;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_RotationY;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_RotationZ;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5062E4", Offset = "0x5062E4")]
		[SerializeField]
		private bool m_UniformScaling;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_ScaleX;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_ScaleY;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_ScaleZ;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private List<CGBoundsGroupItem> m_Items;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x506418", Offset = "0x506418")]
		[SerializeField]
		[HideInInspector]
		private DistributionModeEnum m_DistributionMode;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x506474", Offset = "0x506474")]
		[FloatRegion]
		private FloatRegion m_PositionOffset;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[HideInInspector]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x506518", Offset = "0x506518")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_Height;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x506594", Offset = "0x506594")]
		private CurvyRepeatingOrderEnum m_RepeatingOrder;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5065F0", Offset = "0x5065F0")]
		[HideInInspector]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x5065F0", Offset = "0x5065F0")]
		private Vector3 m_RotationOffset;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[HideInInspector]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x50668C", Offset = "0x50668C")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x50668C", Offset = "0x50668C")]
		[SerializeField]
		private Vector3 m_RotationScatter;

		[Token(Token = "0x17000152")]
		public string Name
		{
			[Token(Token = "0x600066F")]
			[Address(RVA = "0xC10618", Offset = "0xC10618", VA = "0xC10618")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000670")]
			[Address(RVA = "0xC10620", Offset = "0xC10620", VA = "0xC10620")]
			set
			{
			}
		}

		[Token(Token = "0x17000153")]
		public bool KeepTogether
		{
			[Token(Token = "0x6000671")]
			[Address(RVA = "0xC10668", Offset = "0xC10668", VA = "0xC10668")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000672")]
			[Address(RVA = "0xC10670", Offset = "0xC10670", VA = "0xC10670")]
			set
			{
			}
		}

		[Token(Token = "0x17000154")]
		public FloatRegion SpaceBefore
		{
			[Token(Token = "0x6000673")]
			[Address(RVA = "0xC10690", Offset = "0xC10690", VA = "0xC10690")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000674")]
			[Address(RVA = "0xC106A0", Offset = "0xC106A0", VA = "0xC106A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000155")]
		public FloatRegion SpaceAfter
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0xC106F0", Offset = "0xC106F0", VA = "0xC106F0")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000676")]
			[Address(RVA = "0xC10700", Offset = "0xC10700", VA = "0xC10700")]
			set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public bool RandomizeItems
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0xC10750", Offset = "0xC10750", VA = "0xC10750")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000678")]
			[Address(RVA = "0xC10758", Offset = "0xC10758", VA = "0xC10758")]
			set
			{
			}
		}

		[Token(Token = "0x17000157")]
		public IntRegion RepeatingItems
		{
			[Token(Token = "0x6000679")]
			[Address(RVA = "0xC10778", Offset = "0xC10778", VA = "0xC10778")]
			get
			{
				return default(IntRegion);
			}
			[Token(Token = "0x600067A")]
			[Address(RVA = "0xC10788", Offset = "0xC10788", VA = "0xC10788")]
			set
			{
			}
		}

		[Token(Token = "0x17000158")]
		public FloatRegion CrossBase
		{
			[Token(Token = "0x600067B")]
			[Address(RVA = "0xC107D8", Offset = "0xC107D8", VA = "0xC107D8")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x600067C")]
			[Address(RVA = "0xC107E8", Offset = "0xC107E8", VA = "0xC107E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000159")]
		public bool IgnoreModuleCrossBase
		{
			[Token(Token = "0x600067D")]
			[Address(RVA = "0xC10838", Offset = "0xC10838", VA = "0xC10838")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600067E")]
			[Address(RVA = "0xC10840", Offset = "0xC10840", VA = "0xC10840")]
			set
			{
			}
		}

		[Token(Token = "0x1700015A")]
		public RotationModeEnum RotationMode
		{
			[Token(Token = "0x600067F")]
			[Address(RVA = "0xC10860", Offset = "0xC10860", VA = "0xC10860")]
			get
			{
				return default(RotationModeEnum);
			}
			[Token(Token = "0x6000680")]
			[Address(RVA = "0xC10868", Offset = "0xC10868", VA = "0xC10868")]
			set
			{
			}
		}

		[Token(Token = "0x1700015B")]
		public FloatRegion RotationX
		{
			[Token(Token = "0x6000681")]
			[Address(RVA = "0xC1087C", Offset = "0xC1087C", VA = "0xC1087C")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000682")]
			[Address(RVA = "0xC0FFD4", Offset = "0xC0FFD4", VA = "0xC0FFD4")]
			set
			{
			}
		}

		[Token(Token = "0x1700015C")]
		public FloatRegion RotationY
		{
			[Token(Token = "0x6000683")]
			[Address(RVA = "0xC1088C", Offset = "0xC1088C", VA = "0xC1088C")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000684")]
			[Address(RVA = "0xC10024", Offset = "0xC10024", VA = "0xC10024")]
			set
			{
			}
		}

		[Token(Token = "0x1700015D")]
		public FloatRegion RotationZ
		{
			[Token(Token = "0x6000685")]
			[Address(RVA = "0xC1089C", Offset = "0xC1089C", VA = "0xC1089C")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000686")]
			[Address(RVA = "0xC10074", Offset = "0xC10074", VA = "0xC10074")]
			set
			{
			}
		}

		[Token(Token = "0x1700015E")]
		public bool UniformScaling
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0xC108AC", Offset = "0xC108AC", VA = "0xC108AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000688")]
			[Address(RVA = "0xC100C4", Offset = "0xC100C4", VA = "0xC100C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700015F")]
		public FloatRegion ScaleX
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0xC108B4", Offset = "0xC108B4", VA = "0xC108B4")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x600068A")]
			[Address(RVA = "0xC100E4", Offset = "0xC100E4", VA = "0xC100E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000160")]
		public FloatRegion ScaleY
		{
			[Token(Token = "0x600068B")]
			[Address(RVA = "0xC108C4", Offset = "0xC108C4", VA = "0xC108C4")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x600068C")]
			[Address(RVA = "0xC10134", Offset = "0xC10134", VA = "0xC10134")]
			set
			{
			}
		}

		[Token(Token = "0x17000161")]
		public FloatRegion ScaleZ
		{
			[Token(Token = "0x600068D")]
			[Address(RVA = "0xC108D4", Offset = "0xC108D4", VA = "0xC108D4")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x600068E")]
			[Address(RVA = "0xC10184", Offset = "0xC10184", VA = "0xC10184")]
			set
			{
			}
		}

		[Token(Token = "0x17000162")]
		public bool RelativeTranslation
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0xC108E4", Offset = "0xC108E4", VA = "0xC108E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000690")]
			[Address(RVA = "0xC0FEC4", Offset = "0xC0FEC4", VA = "0xC0FEC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000163")]
		public FloatRegion TranslationX
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0xC108EC", Offset = "0xC108EC", VA = "0xC108EC")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000692")]
			[Address(RVA = "0xC0FEE4", Offset = "0xC0FEE4", VA = "0xC0FEE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000164")]
		public FloatRegion TranslationY
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0xC108FC", Offset = "0xC108FC", VA = "0xC108FC")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000694")]
			[Address(RVA = "0xC0FF34", Offset = "0xC0FF34", VA = "0xC0FF34")]
			set
			{
			}
		}

		[Token(Token = "0x17000165")]
		public FloatRegion TranslationZ
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0xC1090C", Offset = "0xC1090C", VA = "0xC1090C")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000696")]
			[Address(RVA = "0xC0FF84", Offset = "0xC0FF84", VA = "0xC0FF84")]
			set
			{
			}
		}

		[Token(Token = "0x17000166")]
		public List<CGBoundsGroupItem> Items
		{
			[Token(Token = "0x6000697")]
			[Address(RVA = "0xC1091C", Offset = "0xC1091C", VA = "0xC1091C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000167")]
		public int FirstRepeating
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0xC0EF60", Offset = "0xC0EF60", VA = "0xC0EF60")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000699")]
			[Address(RVA = "0xC10924", Offset = "0xC10924", VA = "0xC10924")]
			set
			{
			}
		}

		[Token(Token = "0x17000168")]
		public int LastRepeating
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0xC0EF68", Offset = "0xC0EF68", VA = "0xC0EF68")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600069B")]
			[Address(RVA = "0xC1097C", Offset = "0xC1097C", VA = "0xC1097C")]
			set
			{
			}
		}

		[Token(Token = "0x17000169")]
		public int ItemCount
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0xC0E13C", Offset = "0xC0E13C", VA = "0xC0E13C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700016A")]
		private RegionOptions<int> RepeatingGroupsOptions
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0xC109E0", Offset = "0xC109E0", VA = "0xC109E0")]
			get
			{
				return default(RegionOptions<int>);
			}
		}

		[Token(Token = "0x1700016B")]
		private RegionOptions<float> PositionRangeOptions
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0xC10A74", Offset = "0xC10A74", VA = "0xC10A74")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xC0EC38", Offset = "0xC0EC38", VA = "0xC0EC38")]
		public CGBoundsGroup(string name)
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xC0FA08", Offset = "0xC0FA08", VA = "0xC0FA08")]
		public static void FillItemBag(WeightedRandom<int> bag, IEnumerable<CGWeightedItem> itemsWeights, int firstItem, int lastItem)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xC101D4", Offset = "0xC101D4", VA = "0xC101D4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x50E284", Offset = "0x50E284")]
		public void ConvertObsoleteData()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public enum CGYesNoAuto
	{
		[Token(Token = "0x400033A")]
		Yes,
		[Token(Token = "0x400033B")]
		No,
		[Token(Token = "0x400033C")]
		Auto
	}
	[Token(Token = "0x20000E0")]
	public enum CGReferenceMode
	{
		[Token(Token = "0x400033E")]
		Source,
		[Token(Token = "0x400033F")]
		Self
	}
	[Token(Token = "0x20000E1")]
	public enum CGKeepAspectMode
	{
		[Token(Token = "0x4000341")]
		Off,
		[Token(Token = "0x4000342")]
		ScaleU,
		[Token(Token = "0x4000343")]
		ScaleV
	}
	[Token(Token = "0x20000E2")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x50028C", Offset = "0x50028C")]
	public enum CGUVEnum
	{
		[Token(Token = "0x4000345")]
		U,
		[Token(Token = "0x4000346")]
		V
	}
	[Token(Token = "0x20000E3")]
	public enum CGColliderEnum
	{
		[Token(Token = "0x4000348")]
		None,
		[Token(Token = "0x4000349")]
		Mesh,
		[Token(Token = "0x400034A")]
		Box,
		[Token(Token = "0x400034B")]
		Sphere,
		[Token(Token = "0x400034C")]
		Capsule
	}
	[Serializable]
	[Token(Token = "0x20000E4")]
	public struct CGSpot : IEquatable<CGSpot>
	{
		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x506728", Offset = "0x506728")]
		[SerializeField]
		private int m_Index;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x506790", Offset = "0x506790")]
		[SerializeField]
		private Vector3 m_Position;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x506804", Offset = "0x506804")]
		[SerializeField]
		private Quaternion m_Rotation;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x506878", Offset = "0x506878")]
		[SerializeField]
		private Vector3 m_Scale;

		[Token(Token = "0x1700016C")]
		public int Index
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0xB80564", Offset = "0xB80564", VA = "0xB80564")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700016D")]
		public Vector3 Position
		{
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0xB8056C", Offset = "0xB8056C", VA = "0xB8056C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0xB80578", Offset = "0xB80578", VA = "0xB80578")]
			set
			{
			}
		}

		[Token(Token = "0x1700016E")]
		public Quaternion Rotation
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0xB805DC", Offset = "0xB805DC", VA = "0xB805DC")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0xB805E8", Offset = "0xB805E8", VA = "0xB805E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700016F")]
		public Vector3 Scale
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0xB80654", Offset = "0xB80654", VA = "0xB80654")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0xB80660", Offset = "0xB80660", VA = "0xB80660")]
			set
			{
			}
		}

		[Token(Token = "0x17000170")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0xB806C4", Offset = "0xB806C4", VA = "0xB806C4")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xB80724", Offset = "0xB80724", VA = "0xB80724")]
		public CGSpot(int index)
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xB807B0", Offset = "0xB807B0", VA = "0xB807B0")]
		public CGSpot(int index, Vector3 position, Quaternion rotation, Vector3 scale)
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xB807D8", Offset = "0xB807D8", VA = "0xB807D8")]
		public void ToTransform(Transform transform)
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xB80838", Offset = "0xB80838", VA = "0xB80838", Slot = "4")]
		public bool Equals(CGSpot other)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xB808B8", Offset = "0xB808B8", VA = "0xB808B8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xB80954", Offset = "0xB80954", VA = "0xB80954", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xB809C8", Offset = "0xB809C8", VA = "0xB809C8")]
		public static bool operator ==(CGSpot left, CGSpot right)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xB809FC", Offset = "0xB809FC", VA = "0xB809FC")]
		public static bool operator !=(CGSpot left, CGSpot right)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x20000E5")]
	public class CGMaterialSettings
	{
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool SwapUV;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public CGKeepAspectMode KeepAspect;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float UVRotation;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 UVOffset;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector2 UVScale;

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xC08E98", Offset = "0xC08E98", VA = "0xC08E98")]
		public CGMaterialSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E6")]
	public class CGMaterialSettingsEx : CGMaterialSettings
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int MaterialID;

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xC0A850", Offset = "0xC0A850", VA = "0xC0A850")]
		public CGMaterialSettingsEx()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E7")]
	public class CGMeshProperties
	{
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Mesh m_Mesh;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Material[] m_Material;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x50690C", Offset = "0x50690C")]
		[SerializeField]
		private Vector3 m_Translation;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x506974", Offset = "0x506974")]
		[SerializeField]
		private Vector3 m_Rotation;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x5069DC", Offset = "0x5069DC")]
		[SerializeField]
		private Vector3 m_Scale;

		[Token(Token = "0x17000171")]
		public Mesh Mesh
		{
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0xC12708", Offset = "0xC12708", VA = "0xC12708")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0xC12710", Offset = "0xC12710", VA = "0xC12710")]
			set
			{
			}
		}

		[Token(Token = "0x17000172")]
		public Material[] Material
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0xC12844", Offset = "0xC12844", VA = "0xC12844")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0xC1284C", Offset = "0xC1284C", VA = "0xC1284C")]
			set
			{
			}
		}

		[Token(Token = "0x17000173")]
		public Vector3 Translation
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0xC12864", Offset = "0xC12864", VA = "0xC12864")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0xC12870", Offset = "0xC12870", VA = "0xC12870")]
			set
			{
			}
		}

		[Token(Token = "0x17000174")]
		public Vector3 Rotation
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0xC128D4", Offset = "0xC128D4", VA = "0xC128D4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0xC128E0", Offset = "0xC128E0", VA = "0xC128E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000175")]
		public Vector3 Scale
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0xC12944", Offset = "0xC12944", VA = "0xC12944")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0xC12950", Offset = "0xC12950", VA = "0xC12950")]
			set
			{
			}
		}

		[Token(Token = "0x17000176")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0xC129B4", Offset = "0xC129B4", VA = "0xC129B4")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xC12A58", Offset = "0xC12A58", VA = "0xC12A58")]
		public CGMeshProperties()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xC12AD0", Offset = "0xC12AD0", VA = "0xC12AD0")]
		public CGMeshProperties(Mesh mesh)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E8")]
	public class CGGameObjectProperties
	{
		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject m_Object;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x506A54", Offset = "0x506A54")]
		[SerializeField]
		private Vector3 m_Translation;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x506ABC", Offset = "0x506ABC")]
		private Vector3 m_Rotation;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x506B24", Offset = "0x506B24")]
		[SerializeField]
		private Vector3 m_Scale;

		[Token(Token = "0x17000177")]
		public GameObject Object
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0xC11EF0", Offset = "0xC11EF0", VA = "0xC11EF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0xC11EF8", Offset = "0xC11EF8", VA = "0xC11EF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000178")]
		public Vector3 Translation
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0xC11F94", Offset = "0xC11F94", VA = "0xC11F94")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0xC11FA0", Offset = "0xC11FA0", VA = "0xC11FA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000179")]
		public Vector3 Rotation
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0xC12004", Offset = "0xC12004", VA = "0xC12004")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0xC12010", Offset = "0xC12010", VA = "0xC12010")]
			set
			{
			}
		}

		[Token(Token = "0x1700017A")]
		public Vector3 Scale
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0xC12074", Offset = "0xC12074", VA = "0xC12074")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0xC12080", Offset = "0xC12080", VA = "0xC12080")]
			set
			{
			}
		}

		[Token(Token = "0x1700017B")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0xC120E4", Offset = "0xC120E4", VA = "0xC120E4")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xC12188", Offset = "0xC12188", VA = "0xC12188")]
		public CGGameObjectProperties()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xC121BC", Offset = "0xC121BC", VA = "0xC121BC")]
		public CGGameObjectProperties(GameObject gameObject)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E9")]
	public class CGWeightedItem
	{
		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x506B8C", Offset = "0x506B8C")]
		private float m_Weight;

		[Token(Token = "0x1700017C")]
		public float Weight
		{
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0xB85498", Offset = "0xB85498", VA = "0xB85498")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0xB854A0", Offset = "0xB854A0", VA = "0xB854A0")]
			set
			{
			}
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xB854D4", Offset = "0xB854D4", VA = "0xB854D4")]
		public CGWeightedItem()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000EA")]
	public class CGBoundsGroupItem : CGWeightedItem
	{
		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int Index;

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xC0EEE8", Offset = "0xC0EEE8", VA = "0xC0EEE8")]
		public CGBoundsGroupItem()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public struct ControlPointOption : IEquatable<ControlPointOption>
	{
		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float TF;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Distance;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool Include;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int MaterialID;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool HardEdge;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float MaxStepDistance;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UVEdge;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool UVShift;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FirstU;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float SecondU;

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xB813E8", Offset = "0xB813E8", VA = "0xB813E8")]
		public ControlPointOption(float tf, float dist, bool includeAnyways, int materialID, bool hardEdge, float maxStepDistance, bool uvEdge, bool uvShift, float firstU, float secondU)
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xB8B0CC", Offset = "0xB8B0CC", VA = "0xB8B0CC", Slot = "4")]
		public bool Equals(ControlPointOption other)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xB8B1E4", Offset = "0xB8B1E4", VA = "0xB8B1E4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xB8B280", Offset = "0xB8B280", VA = "0xB8B280", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xB8B394", Offset = "0xB8B394", VA = "0xB8B394")]
		public static bool operator ==(ControlPointOption left, ControlPointOption right)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xB8B3C8", Offset = "0xB8B3C8", VA = "0xB8B3C8")]
		public static bool operator !=(ControlPointOption left, ControlPointOption right)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000EC")]
	public struct SamplePointsPatch : IEquatable<SamplePointsPatch>
	{
		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Start;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int Count;

		[Token(Token = "0x1700017D")]
		public int End
		{
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0xBFF5FC", Offset = "0xBFF5FC", VA = "0xBFF5FC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0xBFFC48", Offset = "0xBFFC48", VA = "0xBFFC48")]
			set
			{
			}
		}

		[Token(Token = "0x1700017E")]
		public int TriangleCount
		{
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0xBFF518", Offset = "0xBFF518", VA = "0xBFF518")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xBFFC7C", Offset = "0xBFFC7C", VA = "0xBFFC7C")]
		public SamplePointsPatch(int start)
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xBFFC84", Offset = "0xBFFC84", VA = "0xBFFC84", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xBFFEBC", Offset = "0xBFFEBC", VA = "0xBFFEBC", Slot = "4")]
		public bool Equals(SamplePointsPatch other)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xBFFEE4", Offset = "0xBFFEE4", VA = "0xBFFEE4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xBFFF78", Offset = "0xBFFF78", VA = "0xBFFF78", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xBFFF8C", Offset = "0xBFFF8C", VA = "0xBFFF8C")]
		public static bool operator ==(SamplePointsPatch left, SamplePointsPatch right)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xBFFFAC", Offset = "0xBFFFAC", VA = "0xBFFFAC")]
		public static bool operator !=(SamplePointsPatch left, SamplePointsPatch right)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000ED")]
	public class SamplePointsMaterialGroup
	{
		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int MaterialID;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<SamplePointsPatch> Patches;

		[Token(Token = "0x1700017F")]
		public int TriangleCount
		{
			[Token(Token = "0x60006E0")]
			[Address(RVA = "0xBFF464", Offset = "0xBFF464", VA = "0xBFF464")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000180")]
		public int StartVertex
		{
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0xBFF524", Offset = "0xBFF524", VA = "0xBFF524")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000181")]
		public int EndVertex
		{
			[Token(Token = "0x60006E2")]
			[Address(RVA = "0xBFF584", Offset = "0xBFF584", VA = "0xBFF584")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000182")]
		public int VertexCount
		{
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0xBFF608", Offset = "0xBFF608", VA = "0xBFF608")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xBFF63C", Offset = "0xBFF63C", VA = "0xBFF63C")]
		public SamplePointsMaterialGroup(int materialID)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xBFF6D4", Offset = "0xBFF6D4", VA = "0xBFF6D4")]
		public void GetLengths(CGVolume volume, out float worldLength, out float uLength)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xBFF830", Offset = "0xBFF830", VA = "0xBFF830")]
		public SamplePointsMaterialGroup Clone()
		{
			return null;
		}
	}
	[Token(Token = "0x20000EE")]
	public struct SamplePointUData : IEquatable<SamplePointUData>
	{
		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Vertex;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool UVEdge;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float FirstU;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float SecondU;

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xBFF01C", Offset = "0xBFF01C", VA = "0xBFF01C")]
		public SamplePointUData(int vt, bool uvEdge, float uv0, float uv1)
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xBFF030", Offset = "0xBFF030", VA = "0xBFF030", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xBFF288", Offset = "0xBFF288", VA = "0xBFF288", Slot = "4")]
		public bool Equals(SamplePointUData other)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xBFF304", Offset = "0xBFF304", VA = "0xBFF304", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xBFF38C", Offset = "0xBFF38C", VA = "0xBFF38C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xBFF400", Offset = "0xBFF400", VA = "0xBFF400")]
		public static bool operator ==(SamplePointUData left, SamplePointUData right)
		{
			return default(bool);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xBFF430", Offset = "0xBFF430", VA = "0xBFF430")]
		public static bool operator !=(SamplePointUData left, SamplePointUData right)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000EF")]
	public class SamplePointsMaterialGroupCollection : List<SamplePointsMaterialGroup>
	{
		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int MaterialID;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float AspectCorrection;

		[Token(Token = "0x17000183")]
		public int TriangleCount
		{
			[Token(Token = "0x60006EE")]
			[Address(RVA = "0xBFF8F4", Offset = "0xBFF8F4", VA = "0xBFF8F4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xBFF9A0", Offset = "0xBFF9A0", VA = "0xBFF9A0")]
		public SamplePointsMaterialGroupCollection()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xBFFA20", Offset = "0xBFFA20", VA = "0xBFFA20")]
		public SamplePointsMaterialGroupCollection(int capacity)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xBFFAB0", Offset = "0xBFFAB0", VA = "0xBFFAB0")]
		public SamplePointsMaterialGroupCollection(IEnumerable<SamplePointsMaterialGroup> collection)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xBFFB40", Offset = "0xBFFB40", VA = "0xBFFB40")]
		public void CalculateAspectCorrection(CGVolume volume, CGMaterialSettingsEx matSettings)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F0")]
	public class CGDataReference
	{
		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CGModule m_Module;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_SlotName;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CGModuleOutputSlot mSlot;

		[Token(Token = "0x17000184")]
		public CGData[] Data
		{
			[Token(Token = "0x60006F3")]
			[Address(RVA = "0xC10CC8", Offset = "0xC10CC8", VA = "0xC10CC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000185")]
		public CGModuleOutputSlot Slot
		{
			[Token(Token = "0x60006F4")]
			[Address(RVA = "0xC10D3C", Offset = "0xC10D3C", VA = "0xC10D3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000186")]
		public bool HasValue
		{
			[Token(Token = "0x60006F5")]
			[Address(RVA = "0xC10F5C", Offset = "0xC10F5C", VA = "0xC10F5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000187")]
		public bool IsEmpty
		{
			[Token(Token = "0x60006F6")]
			[Address(RVA = "0xC10F8C", Offset = "0xC10F8C", VA = "0xC10F8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000188")]
		public CGModule Module
		{
			[Token(Token = "0x60006F7")]
			[Address(RVA = "0xC10F98", Offset = "0xC10F98", VA = "0xC10F98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000189")]
		public string SlotName
		{
			[Token(Token = "0x60006F8")]
			[Address(RVA = "0xC10FA0", Offset = "0xC10FA0", VA = "0xC10FA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xC10FA8", Offset = "0xC10FA8", VA = "0xC10FA8")]
		public CGDataReference()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xC10FB0", Offset = "0xC10FB0", VA = "0xC10FB0")]
		public CGDataReference(CGModule module, string slotName)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xC11034", Offset = "0xC11034", VA = "0xC11034")]
		public CGDataReference(CurvyGenerator generator, string moduleName, string slotName)
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xC110E4", Offset = "0xC110E4", VA = "0xC110E4")]
		public void Clear()
		{
		}

		[Token(Token = "0x60006FD")]
		public T GetData<T>() where T : CGData
		{
			return null;
		}

		[Token(Token = "0x60006FE")]
		public T[] GetAllData<T>() where T : CGData
		{
			return null;
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xC10FF0", Offset = "0xC10FF0", VA = "0xC10FF0")]
		public void setINTERNAL(CGModule module, string slotName)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xC1107C", Offset = "0xC1107C", VA = "0xC1107C")]
		public void setINTERNAL(CurvyGenerator generator, string moduleName, string slotName)
		{
		}
	}
	[Token(Token = "0x20000F1")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x50029C", Offset = "0x50029C")]
	public sealed class CGDataInfoAttribute : Attribute
	{
		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Color Color;

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xC10BCC", Offset = "0xC10BCC", VA = "0xC10BCC")]
		public CGDataInfoAttribute(Color color)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xC10C18", Offset = "0xC10C18", VA = "0xC10C18")]
		public CGDataInfoAttribute(float r, float g, float b, float a = 1f)
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xC10C8C", Offset = "0xC10C8C", VA = "0xC10C8C")]
		public CGDataInfoAttribute(string htmlColor)
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class CGData
	{
		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x1700018A")]
		public virtual int Count
		{
			[Token(Token = "0x6000704")]
			[Address(RVA = "0xC10AE4", Offset = "0xC10AE4", VA = "0xC10AE4", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xC08690", Offset = "0xC08690", VA = "0xC08690")]
		public static implicit operator bool(CGData a)
		{
			return default(bool);
		}

		[Token(Token = "0x6000706")]
		public virtual T Clone<T>() where T : CGData
		{
			return null;
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xC10AEC", Offset = "0xC10AEC", VA = "0xC10AEC")]
		protected int getGenericFIndex(ref float[] FMapArray, float fValue, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xC10510", Offset = "0xC10510", VA = "0xC10510")]
		public CGData()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x5002B0", Offset = "0x5002B0")]
	public class CGShape : CGData
	{
		[Serializable]
		[Token(Token = "0x20000F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5002DC", Offset = "0x5002DC")]
		private sealed class <>c
		{
			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<SamplePointsMaterialGroup, SamplePointsMaterialGroup> <>9__16_0;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<SamplePointsMaterialGroup, SamplePointsMaterialGroup> <>9__18_0;

			[Token(Token = "0x600071A")]
			[Address(RVA = "0xE7E144", Offset = "0xE7E144", VA = "0xE7E144")]
			public <>c()
			{
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0xE7E14C", Offset = "0xE7E14C", VA = "0xE7E14C")]
			internal SamplePointsMaterialGroup <.ctor>b__16_0(SamplePointsMaterialGroup g)
			{
				return null;
			}

			[Token(Token = "0x600071C")]
			[Address(RVA = "0xE7E168", Offset = "0xE7E168", VA = "0xE7E168")]
			internal SamplePointsMaterialGroup <Copy>b__18_0(SamplePointsMaterialGroup g)
			{
				return null;
			}
		}

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] SourceF;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float[] F;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3[] Position;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3[] Normal;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float[] Map;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<SamplePointsMaterialGroup> MaterialGroups;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool SourceIsManaged;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool Closed;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool Seamless;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float Length;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float mCacheLastF;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int mCacheLastIndex;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float mCacheLastFrag;

		[Token(Token = "0x1700018B")]
		public override int Count
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0xB7F930", Offset = "0xB7F930", VA = "0xB7F930", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xB7DE24", Offset = "0xB7DE24", VA = "0xB7DE24")]
		public CGShape()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xB7E034", Offset = "0xB7E034", VA = "0xB7E034")]
		public CGShape(CGShape source)
		{
		}

		[Token(Token = "0x600070C")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xB7E514", Offset = "0xB7E514", VA = "0xB7E514")]
		public static void Copy(CGShape dest, CGShape source)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xB7F94C", Offset = "0xB7F94C", VA = "0xB7F94C")]
		public void Copy(CGShape source)
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xB7F950", Offset = "0xB7F950", VA = "0xB7F950")]
		public float DistanceToF(float distance)
		{
			return default(float);
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xB7F984", Offset = "0xB7F984", VA = "0xB7F984")]
		public float FToDistance(float f)
		{
			return default(float);
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xB7E944", Offset = "0xB7E944", VA = "0xB7E944")]
		public int GetFIndex(float f, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xB7F9B0", Offset = "0xB7F9B0", VA = "0xB7F9B0")]
		public Vector3 InterpolatePosition(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xB7FA5C", Offset = "0xB7FA5C", VA = "0xB7FA5C")]
		public Vector3 InterpolateUp(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xB7FB08", Offset = "0xB7FB08", VA = "0xB7FB08")]
		public void Interpolate(float f, out Vector3 position, out Vector3 up)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xB7FC3C", Offset = "0xB7FC3C", VA = "0xB7FC3C")]
		public void Move(ref float f, ref int direction, float speed, CurvyClamping clamping)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xB7FC80", Offset = "0xB7FC80", VA = "0xB7FC80")]
		public void MoveBy(ref float f, ref int direction, float speedDist, CurvyClamping clamping)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xB7EC7C", Offset = "0xB7EC7C", VA = "0xB7EC7C", Slot = "6")]
		public virtual void Recalculate()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xB7FD0C", Offset = "0xB7FD0C", VA = "0xB7FD0C")]
		public void RecalculateNormals(List<int> softEdges)
		{
		}
	}
	[Token(Token = "0x20000F5")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x5002EC", Offset = "0x5002EC")]
	public class CGPath : CGShape
	{
		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3[] Direction;

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xB7DDC0", Offset = "0xB7DDC0", VA = "0xB7DDC0")]
		public CGPath()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xB7DF6C", Offset = "0xB7DF6C", VA = "0xB7DF6C")]
		public CGPath(CGPath source)
		{
		}

		[Token(Token = "0x600071F")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xB7E47C", Offset = "0xB7E47C", VA = "0xB7E47C")]
		public static void Copy(CGPath dest, CGPath source)
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xB7E7B4", Offset = "0xB7E7B4", VA = "0xB7E7B4")]
		public void Interpolate(float f, out Vector3 position, out Vector3 direction, out Vector3 up)
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xB7E9B4", Offset = "0xB7E9B4", VA = "0xB7E9B4")]
		public void Interpolate(float f, float angleF, out Vector3 pos, out Vector3 dir, out Vector3 up)
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xB7EA20", Offset = "0xB7EA20", VA = "0xB7EA20")]
		public Vector3 InterpolateDirection(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xB7EACC", Offset = "0xB7EACC", VA = "0xB7EACC", Slot = "6")]
		public override void Recalculate()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x500318", Offset = "0x500318")]
	public class CGVolume : CGPath
	{
		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Vector3[] Vertex;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3[] VertexNormal;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float[] CrossF;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float[] CrossMap;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float[] SegmentLength;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool CrossClosed;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool CrossSeamless;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float CrossFShift;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public SamplePointsMaterialGroupCollection CrossMaterialGroups;

		[Token(Token = "0x1700018C")]
		public int CrossSize
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0xB8181C", Offset = "0xB8181C", VA = "0xB8181C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700018D")]
		public int VertexCount
		{
			[Token(Token = "0x6000726")]
			[Address(RVA = "0xB83ECC", Offset = "0xB83ECC", VA = "0xB83ECC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xB83EE8", Offset = "0xB83EE8", VA = "0xB83EE8")]
		public CGVolume()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xB83FB4", Offset = "0xB83FB4", VA = "0xB83FB4")]
		public CGVolume(int samplePoints, CGShape crossShape)
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xB8422C", Offset = "0xB8422C", VA = "0xB8422C")]
		public CGVolume(CGPath path, CGShape crossShape)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xB844AC", Offset = "0xB844AC", VA = "0xB844AC")]
		public CGVolume(CGVolume source)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xB84760", Offset = "0xB84760", VA = "0xB84760")]
		public static CGVolume Get(CGVolume data, CGPath path, CGShape crossShape)
		{
			return null;
		}

		[Token(Token = "0x600072C")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xB84974", Offset = "0xB84974", VA = "0xB84974")]
		public void InterpolateVolume(float f, float crossF, out Vector3 pos, out Vector3 dir, out Vector3 up)
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xB84BB0", Offset = "0xB84BB0", VA = "0xB84BB0")]
		public Vector3 InterpolateVolumePosition(float f, float crossF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xB84D1C", Offset = "0xB84D1C", VA = "0xB84D1C")]
		public Vector3 InterpolateVolumeDirection(float f, float crossF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xB84E40", Offset = "0xB84E40", VA = "0xB84E40")]
		public Vector3 InterpolateVolumeUp(float f, float crossF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xB84F84", Offset = "0xB84F84", VA = "0xB84F84")]
		public float GetCrossLength(float pathF)
		{
			return default(float);
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xB85220", Offset = "0xB85220", VA = "0xB85220")]
		public float CrossFToDistance(float f, float crossF, CurvyClamping crossClamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xB85264", Offset = "0xB85264", VA = "0xB85264")]
		public float CrossDistanceToF(float f, float distance, CurvyClamping crossClamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xB85098", Offset = "0xB85098", VA = "0xB85098")]
		public void GetSegmentIndices(float pathF, out int s0Index, out int s1Index, out float frag)
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xB852AC", Offset = "0xB852AC", VA = "0xB852AC")]
		public int GetSegmentIndex(int segment)
		{
			return default(int);
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xB852CC", Offset = "0xB852CC", VA = "0xB852CC")]
		public int GetCrossFIndex(float crossF, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xB8532C", Offset = "0xB8532C", VA = "0xB8532C")]
		public int GetVertexIndex(float pathF, out float pathFrag)
		{
			return default(int);
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xB84B60", Offset = "0xB84B60", VA = "0xB84B60")]
		public int GetVertexIndex(float pathF, float crossF, out float pathFrag, out float crossFrag)
		{
			return default(int);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xB853B0", Offset = "0xB853B0", VA = "0xB853B0")]
		public Vector3[] GetSegmentVertices(params int[] segmentIndices)
		{
			return null;
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xB85130", Offset = "0xB85130", VA = "0xB85130")]
		private float calcSegmentLength(int segmentIndex)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000F7")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x500340", Offset = "0x500340")]
	public class CGBounds : CGData
	{
		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Bounds? mBounds;

		[Token(Token = "0x1700018E")]
		public Bounds Bounds
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0xC0DF80", Offset = "0xC0DF80", VA = "0xC0DF80")]
			get
			{
				return default(Bounds);
			}
			[Token(Token = "0x600073C")]
			[Address(RVA = "0xC0E01C", Offset = "0xC0E01C", VA = "0xC0E01C")]
			set
			{
			}
		}

		[Token(Token = "0x1700018F")]
		public float Depth
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0xC0DEB4", Offset = "0xC0DEB4", VA = "0xC0DEB4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xC10508", Offset = "0xC10508", VA = "0xC10508")]
		public CGBounds()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xC10518", Offset = "0xC10518", VA = "0xC10518")]
		public CGBounds(Bounds bounds)
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xC0DEEC", Offset = "0xC0DEEC", VA = "0xC0DEEC")]
		public CGBounds(CGBounds source)
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xC10564", Offset = "0xC10564", VA = "0xC10564", Slot = "6")]
		public virtual void RecalculateBounds()
		{
		}

		[Token(Token = "0x6000742")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xC1058C", Offset = "0xC1058C", VA = "0xC1058C")]
		public static void Copy(CGBounds dest, CGBounds source)
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class CGVSubMesh : CGData
	{
		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] Triangles;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Material Material;

		[Token(Token = "0x17000190")]
		public override int Count
		{
			[Token(Token = "0x6000744")]
			[Address(RVA = "0xB83D20", Offset = "0xB83D20", VA = "0xB83D20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xB837E8", Offset = "0xB837E8", VA = "0xB837E8")]
		public CGVSubMesh([Optional] Material material)
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xB8201C", Offset = "0xB8201C", VA = "0xB8201C")]
		public CGVSubMesh(int[] triangles, [Optional] Material material)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xB83D3C", Offset = "0xB83D3C", VA = "0xB83D3C")]
		public CGVSubMesh(int triangleCount, [Optional] Material material)
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xB81B08", Offset = "0xB81B08", VA = "0xB81B08")]
		public CGVSubMesh(CGVSubMesh source)
		{
		}

		[Token(Token = "0x6000749")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xB83DC4", Offset = "0xB83DC4", VA = "0xB83DC4")]
		public static CGVSubMesh Get(CGVSubMesh data, int triangleCount, [Optional] Material material)
		{
			return null;
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xB83E70", Offset = "0xB83E70", VA = "0xB83E70")]
		public void ShiftIndices(int offset, int startIndex = 0)
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xB82C34", Offset = "0xB82C34", VA = "0xB82C34")]
		public void Add(CGVSubMesh other, int shiftIndexOffset = 0)
		{
		}
	}
	[Token(Token = "0x20000F9")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x500364", Offset = "0x500364")]
	public class CGVMesh : CGBounds
	{
		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3[] Vertex;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector2[] UV;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector2[] UV2;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3[] Normal;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector4[] Tangents;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CGVSubMesh[] SubMeshes;

		[Token(Token = "0x17000191")]
		public override int Count
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0xB8142C", Offset = "0xB8142C", VA = "0xB8142C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000192")]
		public bool HasUV
		{
			[Token(Token = "0x600074E")]
			[Address(RVA = "0xB81448", Offset = "0xB81448", VA = "0xB81448")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000193")]
		public bool HasUV2
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0xB8146C", Offset = "0xB8146C", VA = "0xB8146C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000194")]
		public bool HasNormals
		{
			[Token(Token = "0x6000750")]
			[Address(RVA = "0xB81490", Offset = "0xB81490", VA = "0xB81490")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000195")]
		public bool HasTangents
		{
			[Token(Token = "0x6000751")]
			[Address(RVA = "0xB814B4", Offset = "0xB814B4", VA = "0xB814B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000196")]
		public int TriangleCount
		{
			[Token(Token = "0x6000752")]
			[Address(RVA = "0xB814D8", Offset = "0xB814D8", VA = "0xB814D8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xB81564", Offset = "0xB81564", VA = "0xB81564")]
		public CGVMesh()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xB8157C", Offset = "0xB8157C", VA = "0xB8157C")]
		public CGVMesh(int vertexCount, bool addUV = false, bool addUV2 = false, bool addNormals = false, bool addTangents = false)
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xB816E8", Offset = "0xB816E8", VA = "0xB816E8")]
		public CGVMesh(CGVolume volume)
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xB81744", Offset = "0xB81744", VA = "0xB81744")]
		public CGVMesh(CGVolume volume, IntRegion subset)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xB81838", Offset = "0xB81838", VA = "0xB81838")]
		public CGVMesh(CGVMesh source)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xB81BC0", Offset = "0xB81BC0", VA = "0xB81BC0")]
		public CGVMesh(CGMeshProperties meshProperties)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xB81C2C", Offset = "0xB81C2C", VA = "0xB81C2C")]
		public CGVMesh(Mesh source, Material[] materials, Matrix4x4 trsMatrix)
		{
		}

		[Token(Token = "0x600075A")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xB82260", Offset = "0xB82260", VA = "0xB82260")]
		public static CGVMesh Get(CGVMesh data, CGVolume source, bool addUV, bool reverseNormals)
		{
			return null;
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xB822E8", Offset = "0xB822E8", VA = "0xB822E8")]
		public static CGVMesh Get(CGVMesh data, CGVolume source, IntRegion subset, bool addUV, bool reverseNormals)
		{
			return null;
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xB8260C", Offset = "0xB8260C", VA = "0xB8260C")]
		public void SetSubMeshCount(int count)
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xB82668", Offset = "0xB82668", VA = "0xB82668")]
		public void AddSubMesh([Optional] CGVSubMesh submesh)
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xB826D4", Offset = "0xB826D4", VA = "0xB826D4")]
		public void MergeVMesh(CGVMesh source)
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xB82D34", Offset = "0xB82D34", VA = "0xB82D34")]
		public void MergeVMesh(CGVMesh source, Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xB82F30", Offset = "0xB82F30", VA = "0xB82F30")]
		public void MergeVMeshes(List<CGVMesh> vMeshes, int startIndex, int endIndex)
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xB82810", Offset = "0xB82810", VA = "0xB82810")]
		private void MergeUVsNormalsAndTangents(CGVMesh source, int preMergeVertexCount)
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xB82AF8", Offset = "0xB82AF8", VA = "0xB82AF8")]
		public CGVSubMesh GetMaterialSubMesh(Material mat, bool createIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xB8386C", Offset = "0xB8386C", VA = "0xB8386C")]
		public Mesh AsMesh()
		{
			return null;
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0xB838E0", Offset = "0xB838E0", VA = "0xB838E0")]
		public void ToMesh(ref Mesh msh)
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xB83A1C", Offset = "0xB83A1C", VA = "0xB83A1C")]
		public Material[] GetMaterials()
		{
			return null;
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xB83B20", Offset = "0xB83B20", VA = "0xB83B20", Slot = "6")]
		public override void RecalculateBounds()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xB83CF0", Offset = "0xB83CF0", VA = "0xB83CF0")]
		public void RecalculateUV2()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xB8206C", Offset = "0xB8206C", VA = "0xB8206C")]
		public void TRS(Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x600076A")]
		private void copyData<T>(ref T[] src, ref T[] dst, int currentSize, int extraSize)
		{
		}
	}
	[Token(Token = "0x20000FA")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x500388", Offset = "0x500388")]
	public class CGGameObject : CGBounds
	{
		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject Object;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 Translate;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 Rotate;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 Scale;

		[Token(Token = "0x17000197")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x600076B")]
			[Address(RVA = "0xC11674", Offset = "0xC11674", VA = "0xC11674")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xC11718", Offset = "0xC11718", VA = "0xC11718")]
		public CGGameObject()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xC1174C", Offset = "0xC1174C", VA = "0xC1174C")]
		public CGGameObject(CGGameObjectProperties properties)
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xC118D8", Offset = "0xC118D8", VA = "0xC118D8")]
		public CGGameObject(GameObject obj)
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xC11794", Offset = "0xC11794", VA = "0xC11794")]
		public CGGameObject(GameObject obj, Vector3 translate, Vector3 rotate, Vector3 scale)
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xC11974", Offset = "0xC11974", VA = "0xC11974")]
		public CGGameObject(CGGameObject source)
		{
		}

		[Token(Token = "0x6000771")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xC119F8", Offset = "0xC119F8", VA = "0xC119F8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x50E2BC", Offset = "0x50E2BC")]
		public static CGGameObject Get(CGGameObject data, GameObject obj, Vector3 translate, Vector3 rotate, Vector3 scale)
		{
			return null;
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xC11B44", Offset = "0xC11B44", VA = "0xC11B44", Slot = "6")]
		public override void RecalculateBounds()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x5003C0", Offset = "0x5003C0")]
	public class CGSpots : CGData
	{
		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CGSpot[] Points;

		[Token(Token = "0x17000198")]
		public override int Count
		{
			[Token(Token = "0x6000774")]
			[Address(RVA = "0xB80A34", Offset = "0xB80A34", VA = "0xB80A34", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xB80A50", Offset = "0xB80A50", VA = "0xB80A50")]
		public CGSpots()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xB80AB8", Offset = "0xB80AB8", VA = "0xB80AB8")]
		public CGSpots(params CGSpot[] points)
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xB80AEC", Offset = "0xB80AEC", VA = "0xB80AEC")]
		public CGSpots(params List<CGSpot>[] lists)
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xB80C40", Offset = "0xB80C40", VA = "0xB80C40")]
		public CGSpots(CGSpots source)
		{
		}

		[Token(Token = "0x6000779")]
		public override T Clone<T>()
		{
			return null;
		}
	}
	[Token(Token = "0x20000FC")]
	public class CGDataRequestParameter
	{
		[Token(Token = "0x600077A")]
		[Address(RVA = "0xC11374", Offset = "0xC11374", VA = "0xC11374")]
		public static implicit operator bool(CGDataRequestParameter a)
		{
			return default(bool);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xC111AC", Offset = "0xC111AC", VA = "0xC111AC")]
		public CGDataRequestParameter()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class CGDataRequestMetaCGOptions : CGDataRequestParameter
	{
		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool CheckHardEdges;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool CheckMaterialID;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool IncludeControlPoints;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool CheckExtendedUV;

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xC086D4", Offset = "0xC086D4", VA = "0xC086D4")]
		public CGDataRequestMetaCGOptions(bool checkEdges, bool checkMaterials, bool includeCP, bool extendedUV)
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xC111B4", Offset = "0xC111B4", VA = "0xC111B4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xC112C4", Offset = "0xC112C4", VA = "0xC112C4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000FE")]
	public class CGDataRequestShapeRasterization : CGDataRequestRasterization
	{
		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float[] PathF;

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xC0869C", Offset = "0xC0869C", VA = "0xC0869C")]
		public CGDataRequestShapeRasterization(float[] pathF, float start, float rasterizedRelativeLength, int resolution, float angle, ModeEnum mode = ModeEnum.Even)
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xC11548", Offset = "0xC11548", VA = "0xC11548", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xC11630", Offset = "0xC11630", VA = "0xC11630", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000FF")]
	public class CGDataRequestRasterization : CGDataRequestParameter
	{
		[Token(Token = "0x2000100")]
		public enum ModeEnum
		{
			[Token(Token = "0x40003AE")]
			Even,
			[Token(Token = "0x40003AF")]
			Optimized
		}

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float Start;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float RasterizedRelativeLength;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Resolution;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float AngleThreshold;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ModeEnum Mode;

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xC06424", Offset = "0xC06424", VA = "0xC06424")]
		public CGDataRequestRasterization(float start, float rasterizedRelativeLength, int resolution, float angle, ModeEnum mode = ModeEnum.Even)
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xC11380", Offset = "0xC11380", VA = "0xC11380")]
		public CGDataRequestRasterization(CGDataRequestRasterization source)
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0xC113A8", Offset = "0xC113A8", VA = "0xC113A8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xC1148C", Offset = "0xC1148C", VA = "0xC1148C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000101")]
	public interface INoProcessing
	{
	}
	[Token(Token = "0x2000102")]
	public interface IExternalInput
	{
		[Token(Token = "0x17000199")]
		bool SupportsIPE
		{
			[Token(Token = "0x6000786")]
			get;
		}
	}
	[Token(Token = "0x2000103")]
	public interface IOnRequestProcessing
	{
		[Token(Token = "0x6000787")]
		CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests);
	}
	[Token(Token = "0x2000104")]
	public interface IPathProvider
	{
		[Token(Token = "0x1700019A")]
		bool PathIsClosed
		{
			[Token(Token = "0x6000788")]
			get;
		}
	}
	[Token(Token = "0x2000105")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5003E4", Offset = "0x5003E4")]
	public interface IOnRequestPath : IOnRequestProcessing, IPathProvider
	{
	}
	[Token(Token = "0x2000106")]
	public interface ICGResourceLoader
	{
		[Token(Token = "0x6000789")]
		UnityEngine.Component Create(CGModule cgModule, string context);

		[Token(Token = "0x600078A")]
		void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill);
	}
	[Token(Token = "0x2000107")]
	public interface ICGResourceCollection
	{
		[Token(Token = "0x1700019B")]
		int Count
		{
			[Token(Token = "0x600078B")]
			get;
		}

		[Token(Token = "0x1700019C")]
		UnityEngine.Component[] ItemsArray
		{
			[Token(Token = "0x600078C")]
			get;
		}
	}
	[Token(Token = "0x2000108")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x50041C", Offset = "0x50041C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x50041C", Offset = "0x50041C")]
	public class CGMeshResource : DuplicateEditorMesh, IPoolable
	{
		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MeshRenderer mRenderer;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider mCollider;

		[Token(Token = "0x1700019D")]
		public MeshRenderer Renderer
		{
			[Token(Token = "0x600078D")]
			[Address(RVA = "0xC12BF8", Offset = "0xC12BF8", VA = "0xC12BF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019E")]
		public Collider Collider
		{
			[Token(Token = "0x600078E")]
			[Address(RVA = "0xC12CAC", Offset = "0xC12CAC", VA = "0xC12CAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xC12D60", Offset = "0xC12D60", VA = "0xC12D60")]
		public Mesh Prepare()
		{
			return null;
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xC12DB8", Offset = "0xC12DB8", VA = "0xC12DB8")]
		public bool ColliderMatches(CGColliderEnum type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xC12FA8", Offset = "0xC12FA8", VA = "0xC12FA8")]
		public void RemoveCollider()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xC130A4", Offset = "0xC130A4", VA = "0xC130A4")]
		public bool UpdateCollider(CGColliderEnum mode, bool convex, bool isTrigger, PhysicMaterial material, MeshColliderCookingOptions meshCookingOptions = MeshColliderCookingOptions.CookForFasterSimulation | MeshColliderCookingOptions.EnableMeshCleaning | MeshColliderCookingOptions.WeldColocatedVertices)
		{
			return default(bool);
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xC13864", Offset = "0xC13864", VA = "0xC13864", Slot = "5")]
		public void OnBeforePush()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xC13868", Offset = "0xC13868", VA = "0xC13868", Slot = "6")]
		public void OnAfterPop()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xC1386C", Offset = "0xC1386C", VA = "0xC1386C")]
		public CGMeshResource()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000109")]
	public class CGMeshResourceCollection : ICGResourceCollection
	{
		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<CGMeshResource> Items;

		[Token(Token = "0x1700019F")]
		public int Count
		{
			[Token(Token = "0x6000796")]
			[Address(RVA = "0xC13874", Offset = "0xC13874", VA = "0xC13874", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001A0")]
		public UnityEngine.Component[] ItemsArray
		{
			[Token(Token = "0x6000797")]
			[Address(RVA = "0xC138C0", Offset = "0xC138C0", VA = "0xC138C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xC13914", Offset = "0xC13914", VA = "0xC13914")]
		public CGMeshResourceCollection()
		{
		}
	}
	[Token(Token = "0x200010A")]
	[ExecuteInEditMode]
	public abstract class CGModule : DTVersionedMonoBehaviour
	{
		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x506C2C", Offset = "0x506C2C")]
		protected CurvyCGEvent m_OnBeforeRefresh;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x506C88", Offset = "0x506C88")]
		protected CurvyCGEvent m_OnRefresh;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private string m_ModuleName;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private bool m_Active;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x506D44", Offset = "0x506D44")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x506D44", Offset = "0x506D44")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x506D44", Offset = "0x506D44")]
		[SerializeField]
		private bool m_RandomizeSeed;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[HideInInspector]
		private int m_Seed;

		[NonSerialized]
		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<string> UIMessages;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CurvyGenerator mGenerator;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private int m_UniqueID;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x506E60", Offset = "0x506E60")]
		private bool <CircularReferenceError>k__BackingField;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal int SortAncestors;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public CGModuleProperties Properties;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public List<CGModuleLink> InputLinks;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public List<CGModuleLink> OutputLinks;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x506EA0", Offset = "0x506EA0")]
		private Dictionary<string, CGModuleInputSlot> <InputByName>k__BackingField;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x506EB0", Offset = "0x506EB0")]
		private Dictionary<string, CGModuleOutputSlot> <OutputByName>k__BackingField;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x506EC0", Offset = "0x506EC0")]
		private List<CGModuleInputSlot> <Input>k__BackingField;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x506ED0", Offset = "0x506ED0")]
		private List<CGModuleOutputSlot> <Output>k__BackingField;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ModuleInfoAttribute mInfo;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool mDirty;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool mInitialized;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		private bool mStateChangeDirty;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		private bool mLastIsConfiguredState;

		[Token(Token = "0x170001A1")]
		public CurvyCGEvent OnBeforeRefresh
		{
			[Token(Token = "0x6000799")]
			[Address(RVA = "0xC13CF8", Offset = "0xC13CF8", VA = "0xC13CF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600079A")]
			[Address(RVA = "0xC13D00", Offset = "0xC13D00", VA = "0xC13D00")]
			set
			{
			}
		}

		[Token(Token = "0x170001A2")]
		public CurvyCGEvent OnRefresh
		{
			[Token(Token = "0x600079B")]
			[Address(RVA = "0xC13D18", Offset = "0xC13D18", VA = "0xC13D18")]
			get
			{
				return null;
			}
			[Token(Token = "0x600079C")]
			[Address(RVA = "0xC13D20", Offset = "0xC13D20", VA = "0xC13D20")]
			set
			{
			}
		}

		[Token(Token = "0x170001A3")]
		public string ModuleName
		{
			[Token(Token = "0x600079F")]
			[Address(RVA = "0xC13E08", Offset = "0xC13E08", VA = "0xC13E08")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A0")]
			[Address(RVA = "0xC13E10", Offset = "0xC13E10", VA = "0xC13E10")]
			set
			{
			}
		}

		[Token(Token = "0x170001A4")]
		public bool Active
		{
			[Token(Token = "0x60007A1")]
			[Address(RVA = "0xC14060", Offset = "0xC14060", VA = "0xC14060")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A2")]
			[Address(RVA = "0xC14068", Offset = "0xC14068", VA = "0xC14068")]
			set
			{
			}
		}

		[Token(Token = "0x170001A5")]
		public int Seed
		{
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0xC140C4", Offset = "0xC140C4", VA = "0xC140C4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007A4")]
			[Address(RVA = "0xC140CC", Offset = "0xC140CC", VA = "0xC140CC")]
			set
			{
			}
		}

		[Token(Token = "0x170001A6")]
		public bool RandomizeSeed
		{
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0xC140E4", Offset = "0xC140E4", VA = "0xC140E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0xC140EC", Offset = "0xC140EC", VA = "0xC140EC")]
			set
			{
			}
		}

		[Token(Token = "0x170001A7")]
		public CurvyGenerator Generator
		{
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0xC1410C", Offset = "0xC1410C", VA = "0xC1410C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A8")]
		public int UniqueID
		{
			[Token(Token = "0x60007A8")]
			[Address(RVA = "0xC14114", Offset = "0xC14114", VA = "0xC14114")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001A9")]
		public bool CircularReferenceError
		{
			[Token(Token = "0x60007A9")]
			[Address(RVA = "0xC1411C", Offset = "0xC1411C", VA = "0xC1411C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E2F4", Offset = "0x50E2F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0xC14124", Offset = "0xC14124", VA = "0xC14124")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E304", Offset = "0x50E304")]
			set
			{
			}
		}

		[Token(Token = "0x170001AA")]
		public Dictionary<string, CGModuleInputSlot> InputByName
		{
			[Token(Token = "0x60007AB")]
			[Address(RVA = "0xC14130", Offset = "0xC14130", VA = "0xC14130")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E314", Offset = "0x50E314")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007AC")]
			[Address(RVA = "0xC14138", Offset = "0xC14138", VA = "0xC14138")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E324", Offset = "0x50E324")]
			private set
			{
			}
		}

		[Token(Token = "0x170001AB")]
		public Dictionary<string, CGModuleOutputSlot> OutputByName
		{
			[Token(Token = "0x60007AD")]
			[Address(RVA = "0xC14140", Offset = "0xC14140", VA = "0xC14140")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E334", Offset = "0x50E334")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007AE")]
			[Address(RVA = "0xC14148", Offset = "0xC14148", VA = "0xC14148")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E344", Offset = "0x50E344")]
			private set
			{
			}
		}

		[Token(Token = "0x170001AC")]
		public List<CGModuleInputSlot> Input
		{
			[Token(Token = "0x60007AF")]
			[Address(RVA = "0xC14150", Offset = "0xC14150", VA = "0xC14150")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E354", Offset = "0x50E354")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007B0")]
			[Address(RVA = "0xC14158", Offset = "0xC14158", VA = "0xC14158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E364", Offset = "0x50E364")]
			private set
			{
			}
		}

		[Token(Token = "0x170001AD")]
		public List<CGModuleOutputSlot> Output
		{
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0xC14160", Offset = "0xC14160", VA = "0xC14160")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E374", Offset = "0x50E374")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0xC14168", Offset = "0xC14168", VA = "0xC14168")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E384", Offset = "0x50E384")]
			private set
			{
			}
		}

		[Token(Token = "0x170001AE")]
		public ModuleInfoAttribute Info
		{
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0xC14170", Offset = "0xC14170", VA = "0xC14170")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AF")]
		public bool Dirty
		{
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0xC142B8", Offset = "0xC142B8", VA = "0xC142B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007B5")]
			[Address(RVA = "0xC05718", Offset = "0xC05718", VA = "0xC05718")]
			set
			{
			}
		}

		[Token(Token = "0x170001B0")]
		public virtual bool IsConfigured
		{
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0xC15F18", Offset = "0xC15F18", VA = "0xC15F18", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001B1")]
		public virtual bool IsInitialized
		{
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0xC161E8", Offset = "0xC161E8", VA = "0xC161E8", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xC13D38", Offset = "0xC13D38", VA = "0xC13D38")]
		protected CurvyCGEventArgs OnBeforeRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xC13DA0", Offset = "0xC13DA0", VA = "0xC13DA0")]
		protected CurvyCGEventArgs OnRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xC08D24", Offset = "0xC08D24", VA = "0xC08D24", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xC05F4C", Offset = "0xC05F4C", VA = "0xC05F4C", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xC14394", Offset = "0xC14394", VA = "0xC14394")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xC14A38", Offset = "0xC14A38", VA = "0xC14A38", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xC14A3C", Offset = "0xC14A3C", VA = "0xC14A3C", Slot = "7")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xC15F10", Offset = "0xC15F10", VA = "0xC15F10")]
		private void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xC063D0", Offset = "0xC063D0", VA = "0xC063D0", Slot = "10")]
		public virtual void Refresh()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xC06050", Offset = "0xC06050", VA = "0xC06050", Slot = "11")]
		public virtual void Reset()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xC15B88", Offset = "0xC15B88", VA = "0xC15B88")]
		public void ReInitializeLinkedSlots()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xC0C940", Offset = "0xC0C940", VA = "0xC0C940", Slot = "12")]
		public virtual void OnStateChange()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xC161F0", Offset = "0xC161F0", VA = "0xC161F0", Slot = "13")]
		public virtual void OnTemplateCreated()
		{
		}

		[Token(Token = "0x60007C3")]
		protected static T GetRequestParameter<T>(ref CGDataRequestParameter[] requests) where T : CGDataRequestParameter
		{
			return null;
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xC161F4", Offset = "0xC161F4", VA = "0xC161F4")]
		protected static void RemoveRequestParameter(ref CGDataRequestParameter[] requests, CGDataRequestParameter request)
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xC162B4", Offset = "0xC162B4", VA = "0xC162B4")]
		public CGModuleLink GetOutputLink(CGModuleOutputSlot outSlot, CGModuleInputSlot inSlot)
		{
			return null;
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xC1639C", Offset = "0xC1639C", VA = "0xC1639C")]
		public List<CGModuleLink> GetOutputLinks(CGModuleOutputSlot outSlot)
		{
			return null;
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xC164E0", Offset = "0xC164E0", VA = "0xC164E0")]
		public CGModuleLink GetInputLink(CGModuleInputSlot inSlot, CGModuleOutputSlot outSlot)
		{
			return null;
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xC164E8", Offset = "0xC164E8", VA = "0xC164E8")]
		public List<CGModuleLink> GetInputLinks(CGModuleInputSlot inSlot)
		{
			return null;
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xC162BC", Offset = "0xC162BC", VA = "0xC162BC")]
		private static CGModuleLink GetLink(List<CGModuleLink> lst, CGModuleSlot source, CGModuleSlot target)
		{
			return null;
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xC163A4", Offset = "0xC163A4", VA = "0xC163A4")]
		private static List<CGModuleLink> GetLinks(List<CGModuleLink> lst, CGModuleSlot source)
		{
			return null;
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xC164F0", Offset = "0xC164F0", VA = "0xC164F0")]
		public CGModule CopyTo(CurvyGenerator targetGenerator)
		{
			return null;
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xC1661C", Offset = "0xC1661C", VA = "0xC1661C")]
		public UnityEngine.Component AddManagedResource(string resourceName, string context = "", int index = -1)
		{
			return null;
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xC15834", Offset = "0xC15834", VA = "0xC15834")]
		public void DeleteManagedResource(string resourceName, UnityEngine.Component res, string context = "", bool dontUsePool = false)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xC16A78", Offset = "0xC16A78", VA = "0xC16A78")]
		public bool IsManagedResource(UnityEngine.Component res)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xC167A4", Offset = "0xC167A4", VA = "0xC167A4")]
		protected void RenameResource(string resourceName, UnityEngine.Component resource, int index = -1)
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xC16B60", Offset = "0xC16B60", VA = "0xC16B60")]
		protected PrefabPool GetPrefabPool(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xC16CD8", Offset = "0xC16CD8", VA = "0xC16CD8")]
		public List<IPool> GetAllPrefabPools()
		{
			return null;
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xC16DB0", Offset = "0xC16DB0", VA = "0xC16DB0")]
		public void DeleteAllPrefabPools()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xC16E88", Offset = "0xC16E88", VA = "0xC16E88")]
		public void Delete()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xC16F28", Offset = "0xC16F28", VA = "0xC16F28")]
		public CGModuleInputSlot GetInputSlot(string name)
		{
			return null;
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xC15918", Offset = "0xC15918", VA = "0xC15918")]
		public List<CGModuleInputSlot> GetInputSlots([Optional] Type filterType)
		{
			return null;
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xC10EC0", Offset = "0xC10EC0", VA = "0xC10EC0")]
		public CGModuleOutputSlot GetOutputSlot(string name)
		{
			return null;
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xC15CAC", Offset = "0xC15CAC", VA = "0xC15CAC")]
		public List<CGModuleOutputSlot> GetOutputSlots([Optional] Type filterType)
		{
			return null;
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xC15308", Offset = "0xC15308", VA = "0xC15308")]
		public bool GetManagedResources(out List<UnityEngine.Component> components, out List<string> componentNames)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xC165F0", Offset = "0xC165F0", VA = "0xC165F0")]
		public int SetUniqueIdINTERNAL()
		{
			return default(int);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xC16FC4", Offset = "0xC16FC4", VA = "0xC16FC4")]
		internal void initializeSort()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xC170C8", Offset = "0xC170C8", VA = "0xC170C8")]
		internal List<CGModule> decrementChilds()
		{
			return null;
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xC172F8", Offset = "0xC172F8", VA = "0xC172F8")]
		internal void doRefresh()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xC141B4", Offset = "0xC141B4", VA = "0xC141B4")]
		internal ModuleInfoAttribute getInfo()
		{
			return null;
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xC17440", Offset = "0xC17440", VA = "0xC17440")]
		private bool usesRandom()
		{
			return default(bool);
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xC14578", Offset = "0xC14578", VA = "0xC14578")]
		private void loadSlots()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xC17480", Offset = "0xC17480", VA = "0xC17480")]
		private SlotInfo getSlotInfo(FieldInfo f)
		{
			return null;
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xC15128", Offset = "0xC15128", VA = "0xC15128")]
		private void setTreeDirtyStateChange()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xC142C0", Offset = "0xC142C0", VA = "0xC142C0")]
		private CurvyGenerator RetrieveGenerator()
		{
			return null;
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xC178F8", Offset = "0xC178F8", VA = "0xC178F8")]
		public void checkOnStateChangedINTERNAL()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xC13E68", Offset = "0xC13E68", VA = "0xC13E68")]
		public void renameManagedResourcesINTERNAL()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xC0656C", Offset = "0xC0656C", VA = "0xC0656C")]
		protected CGModule()
		{
		}
	}
	[Token(Token = "0x200010B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x5004B0", Offset = "0x5004B0")]
	public sealed class ModuleInfoAttribute : Attribute, IComparable
	{
		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string MenuName;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ModuleName;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Description;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool UsesRandom;

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xBFB670", Offset = "0xBFB670", VA = "0xBFB670")]
		public ModuleInfoAttribute(string name)
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xBFB6A4", Offset = "0xBFB6A4", VA = "0xBFB6A4", Slot = "7")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200010C")]
	public class CGModuleProperties
	{
		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rect Dimensions;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MinWidth;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float LabelWidth;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color BackgroundColor;

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xB7D828", Offset = "0xB7D828", VA = "0xB7D828")]
		public CGModuleProperties()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010D")]
	public class CGModuleLink
	{
		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int m_ModuleID;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_SlotName;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_TargetModuleID;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string m_TargetSlotName;

		[Token(Token = "0x170001B2")]
		public int ModuleID
		{
			[Token(Token = "0x60007E9")]
			[Address(RVA = "0xB7C42C", Offset = "0xB7C42C", VA = "0xB7C42C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001B3")]
		public string SlotName
		{
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0xB7C434", Offset = "0xB7C434", VA = "0xB7C434")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B4")]
		public int TargetModuleID
		{
			[Token(Token = "0x60007EB")]
			[Address(RVA = "0xB7C43C", Offset = "0xB7C43C", VA = "0xB7C43C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001B5")]
		public string TargetSlotName
		{
			[Token(Token = "0x60007EC")]
			[Address(RVA = "0xB7C444", Offset = "0xB7C444", VA = "0xB7C444")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xB7C44C", Offset = "0xB7C44C", VA = "0xB7C44C")]
		public CGModuleLink(int sourceID, string sourceSlotName, int targetID, string targetSlotName)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xB7C4B4", Offset = "0xB7C4B4", VA = "0xB7C4B4")]
		public CGModuleLink(CGModuleSlot source, CGModuleSlot target)
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xB7C5BC", Offset = "0xB7C5BC", VA = "0xB7C5BC")]
		public bool IsSame(CGModuleLink o)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xB7C634", Offset = "0xB7C634", VA = "0xB7C634")]
		public bool IsSame(CGModuleSlot source, CGModuleSlot target)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xB7C748", Offset = "0xB7C748", VA = "0xB7C748")]
		public bool IsTo(CGModuleSlot s)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xB7C7E8", Offset = "0xB7C7E8", VA = "0xB7C7E8")]
		public bool IsFrom(CGModuleSlot s)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xB7C888", Offset = "0xB7C888", VA = "0xB7C888")]
		public bool IsUsing(CGModule module)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xB7C8C0", Offset = "0xB7C8C0", VA = "0xB7C8C0")]
		public bool IsBetween(CGModuleSlot one, CGModuleSlot another)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xB7C938", Offset = "0xB7C938", VA = "0xB7C938")]
		public void SetModuleIDIINTERNAL(int moduleID, int targetModuleID)
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xB7C944", Offset = "0xB7C944", VA = "0xB7C944")]
		public static implicit operator bool(CGModuleLink a)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xB7C950", Offset = "0xB7C950", VA = "0xB7C950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200010E")]
	public class CGModuleSlot
	{
		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x506F20", Offset = "0x506F20")]
		private CGModule <Module>k__BackingField;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x506F30", Offset = "0x506F30")]
		private SlotInfo <Info>k__BackingField;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x506F40", Offset = "0x506F40")]
		private Vector2 <Origin>k__BackingField;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x506F50", Offset = "0x506F50")]
		private Rect <DropZone>k__BackingField;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<CGModuleSlot> mLinkedSlots;

		[Token(Token = "0x170001B6")]
		public CGModule Module
		{
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0xB7D864", Offset = "0xB7D864", VA = "0xB7D864")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E394", Offset = "0x50E394")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0xB7D86C", Offset = "0xB7D86C", VA = "0xB7D86C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E3A4", Offset = "0x50E3A4")]
			internal set
			{
			}
		}

		[Token(Token = "0x170001B7")]
		public SlotInfo Info
		{
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0xB7D874", Offset = "0xB7D874", VA = "0xB7D874")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E3B4", Offset = "0x50E3B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0xB7D87C", Offset = "0xB7D87C", VA = "0xB7D87C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E3C4", Offset = "0x50E3C4")]
			internal set
			{
			}
		}

		[Token(Token = "0x170001B8")]
		public Vector2 Origin
		{
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0xB7D884", Offset = "0xB7D884", VA = "0xB7D884")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E3D4", Offset = "0x50E3D4")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0xB7D88C", Offset = "0xB7D88C", VA = "0xB7D88C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E3E4", Offset = "0x50E3E4")]
			set
			{
			}
		}

		[Token(Token = "0x170001B9")]
		public Rect DropZone
		{
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0xB7D894", Offset = "0xB7D894", VA = "0xB7D894")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E3F4", Offset = "0x50E3F4")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0xB7D8A0", Offset = "0xB7D8A0", VA = "0xB7D8A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E404", Offset = "0x50E404")]
			set
			{
			}
		}

		[Token(Token = "0x170001BA")]
		public bool IsLinked
		{
			[Token(Token = "0x6000800")]
			[Address(RVA = "0xB7D8AC", Offset = "0xB7D8AC", VA = "0xB7D8AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001BB")]
		public bool IsLinkedAndConfigured
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0xB7D910", Offset = "0xB7D910", VA = "0xB7D910")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001BC")]
		public IOnRequestProcessing OnRequestModule
		{
			[Token(Token = "0x6000802")]
			[Address(RVA = "0xB7D9F4", Offset = "0xB7D9F4", VA = "0xB7D9F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BD")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x50E98C", Offset = "0x50E98C")]
		public IOnRequestPath OnRequestPathModule
		{
			[Token(Token = "0x6000803")]
			[Address(RVA = "0xB7DA40", Offset = "0xB7DA40", VA = "0xB7DA40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BE")]
		public IPathProvider PathProvider
		{
			[Token(Token = "0x6000804")]
			[Address(RVA = "0xB7DA8C", Offset = "0xB7DA8C", VA = "0xB7DA8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BF")]
		public IExternalInput ExternalInput
		{
			[Token(Token = "0x6000805")]
			[Address(RVA = "0xB7DAD8", Offset = "0xB7DAD8", VA = "0xB7DAD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C0")]
		public List<CGModuleSlot> LinkedSlots
		{
			[Token(Token = "0x6000806")]
			[Address(RVA = "0xB7D580", Offset = "0xB7D580", VA = "0xB7D580")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C1")]
		public int Count
		{
			[Token(Token = "0x6000807")]
			[Address(RVA = "0xB7DB24", Offset = "0xB7DB24", VA = "0xB7DB24")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001C2")]
		public string Name
		{
			[Token(Token = "0x6000808")]
			[Address(RVA = "0xB7C564", Offset = "0xB7C564", VA = "0xB7C564")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xB7CC38", Offset = "0xB7CC38", VA = "0xB7CC38")]
		public CGModuleSlot()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xB7D07C", Offset = "0xB7D07C", VA = "0xB7D07C")]
		public bool HasLinkTo(CGModuleSlot other)
		{
			return default(bool);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xB7DB74", Offset = "0xB7DB74", VA = "0xB7DB74")]
		public List<CGModule> GetLinkedModules()
		{
			return null;
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xB7D30C", Offset = "0xB7D30C", VA = "0xB7D30C", Slot = "4")]
		public virtual void LinkTo(CGModuleSlot other)
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xB7D144", Offset = "0xB7D144", VA = "0xB7D144")]
		protected static void LinkInputAndOutput(CGModuleSlot inputSlot, CGModuleSlot outputSlot)
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xB7D610", Offset = "0xB7D610", VA = "0xB7D610", Slot = "5")]
		public virtual void UnlinkFrom(CGModuleSlot other)
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xB7DC98", Offset = "0xB7DC98", VA = "0xB7DC98", Slot = "6")]
		public virtual void UnlinkAll()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xB7D028", Offset = "0xB7D028", VA = "0xB7D028")]
		public void ReInitializeLinkedSlots()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xB7D024", Offset = "0xB7D024", VA = "0xB7D024", Slot = "7")]
		protected virtual void LoadLinkedSlots()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xB7DC9C", Offset = "0xB7DC9C", VA = "0xB7DC9C")]
		public static implicit operator bool(CGModuleSlot a)
		{
			return default(bool);
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xB7DCA8", Offset = "0xB7DCA8", VA = "0xB7DCA8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200010F")]
	public class CGModuleInputSlot : CGModuleSlot
	{
		[Token(Token = "0x170001C3")]
		public InputSlotInfo InputInfo
		{
			[Token(Token = "0x6000814")]
			[Address(RVA = "0xC16184", Offset = "0xC16184", VA = "0xC16184")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xC06564", Offset = "0xC06564", VA = "0xC06564")]
		public CGModuleInputSlot()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xC17930", Offset = "0xC17930", VA = "0xC17930", Slot = "7")]
		protected override void LoadLinkedSlots()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xC17D2C", Offset = "0xC17D2C", VA = "0xC17D2C", Slot = "6")]
		public override void UnlinkAll()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xC17E9C", Offset = "0xC17E9C", VA = "0xC17E9C", Slot = "4")]
		public override void LinkTo(CGModuleSlot outputSlot)
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xC17EF0", Offset = "0xC17EF0", VA = "0xC17EF0", Slot = "5")]
		public override void UnlinkFrom(CGModuleSlot outputSlot)
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xC05D00", Offset = "0xC05D00", VA = "0xC05D00")]
		public CGModuleOutputSlot SourceSlot(int index = 0)
		{
			return null;
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xC18078", Offset = "0xC18078", VA = "0xC18078")]
		public bool CanLinkTo(CGModuleOutputSlot source)
		{
			return default(bool);
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xC181A4", Offset = "0xC181A4", VA = "0xC181A4")]
		public static bool AreInputAndOutputSlotsCompatible(InputSlotInfo inputSlotInfo, bool inputSlotModuleIsOnRequest, OutputSlotInfo outputSlotInfo, bool outputSlotModuleIsOnRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xC18224", Offset = "0xC18224", VA = "0xC18224")]
		private CGModule SourceModule(int index)
		{
			return null;
		}

		[Token(Token = "0x600081E")]
		public T GetData<T>(params CGDataRequestParameter[] requests) where T : CGData
		{
			return null;
		}

		[Token(Token = "0x600081F")]
		public List<T> GetAllData<T>(params CGDataRequestParameter[] requests) where T : CGData
		{
			return null;
		}

		[Token(Token = "0x6000820")]
		private CGData[] GetData<T>(int slotIndex, params CGDataRequestParameter[] requests) where T : CGData
		{
			return null;
		}

		[Token(Token = "0x6000821")]
		private static CGData[] cloneData<T>(ref CGData[] source) where T : CGData
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000110")]
	public class CGModuleOutputSlot : CGModuleSlot
	{
		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public CGData[] Data;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CGDataRequestParameter[] LastRequestParameters;

		[Token(Token = "0x170001C4")]
		public OutputSlotInfo OutputInfo
		{
			[Token(Token = "0x6000822")]
			[Address(RVA = "0xB7CB50", Offset = "0xB7CB50", VA = "0xB7CB50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C5")]
		public bool HasData
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0xB7D70C", Offset = "0xB7D70C", VA = "0xB7D70C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xB7CBD0", Offset = "0xB7CBD0", VA = "0xB7CBD0")]
		public CGModuleOutputSlot()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xB7CC40", Offset = "0xB7CC40", VA = "0xB7CC40", Slot = "7")]
		protected override void LoadLinkedSlots()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xB7D034", Offset = "0xB7D034", VA = "0xB7D034", Slot = "4")]
		public override void LinkTo(CGModuleSlot inputSlot)
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xB7D408", Offset = "0xB7D408", VA = "0xB7D408", Slot = "5")]
		public override void UnlinkFrom(CGModuleSlot inputSlot)
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xB7D74C", Offset = "0xB7D74C", VA = "0xB7D74C")]
		public void ClearData()
		{
		}

		[Token(Token = "0x6000829")]
		public void SetData<T>(List<T> data) where T : CGData
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xB7D7A8", Offset = "0xB7D7A8", VA = "0xB7D7A8")]
		public void SetData(params CGData[] data)
		{
		}

		[Token(Token = "0x600082B")]
		public T GetData<T>() where T : CGData
		{
			return null;
		}

		[Token(Token = "0x600082C")]
		public T[] GetAllData<T>() where T : CGData
		{
			return null;
		}
	}
	[Token(Token = "0x2000111")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x5004C4", Offset = "0x5004C4")]
	public class SlotInfo : Attribute, IComparable
	{
		[Token(Token = "0x2000112")]
		public enum SlotArrayType
		{
			[Token(Token = "0x40003E4")]
			Unknown,
			[Token(Token = "0x40003E5")]
			Normal,
			[Token(Token = "0x40003E6")]
			Hidden
		}

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Type[] DataTypes;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string displayName;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Tooltip;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool Array;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public SlotArrayType ArrayType;

		[Token(Token = "0x170001C6")]
		public string DisplayName
		{
			[Token(Token = "0x600082D")]
			[Address(RVA = "0xC00910", Offset = "0xC00910", VA = "0xC00910")]
			get
			{
				return null;
			}
			[Token(Token = "0x600082E")]
			[Address(RVA = "0xC00928", Offset = "0xC00928", VA = "0xC00928")]
			set
			{
			}
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xBF3BB0", Offset = "0xBF3BB0", VA = "0xBF3BB0")]
		protected SlotInfo(string name, params Type[] type)
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xC00930", Offset = "0xC00930", VA = "0xC00930")]
		protected SlotInfo(params Type[] type)
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xC0093C", Offset = "0xC0093C", VA = "0xC0093C", Slot = "7")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000113")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x5004D8", Offset = "0x5004D8")]
	public sealed class InputSlotInfo : SlotInfo
	{
		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool RequestDataOnly;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool Optional;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public bool ModifiesData;

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xBF3BAC", Offset = "0xBF3BAC", VA = "0xBF3BAC")]
		public InputSlotInfo(string name, params Type[] type)
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xBF3C08", Offset = "0xBF3C08", VA = "0xBF3C08")]
		public InputSlotInfo(params Type[] type)
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xBF3C14", Offset = "0xBF3C14", VA = "0xBF3C14")]
		public bool IsValidFrom(Type outType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000114")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x50050C", Offset = "0x50050C")]
	public class OutputSlotInfo : SlotInfo
	{
		[Token(Token = "0x170001C7")]
		public Type DataType
		{
			[Token(Token = "0x6000835")]
			[Address(RVA = "0xBFBBCC", Offset = "0xBFBBCC", VA = "0xBFBBCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xBFBC00", Offset = "0xBFBC00", VA = "0xBFBC00")]
		public OutputSlotInfo(Type type)
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xBFBC0C", Offset = "0xBFBC0C", VA = "0xBFBC0C")]
		public OutputSlotInfo(string name, Type type)
		{
		}
	}
	[Token(Token = "0x2000115")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x500540", Offset = "0x500540")]
	public class ShapeOutputSlotInfo : OutputSlotInfo
	{
		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool OutputsVariableShape;

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xC00860", Offset = "0xC00860", VA = "0xC00860")]
		public ShapeOutputSlotInfo()
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xC00868", Offset = "0xC00868", VA = "0xC00868")]
		public ShapeOutputSlotInfo(string name)
		{
		}
	}
	[Token(Token = "0x2000116")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x500574", Offset = "0x500574")]
	public sealed class ResourceLoaderAttribute : Attribute
	{
		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string ResourceName;

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xBFEFE8", Offset = "0xBFEFE8", VA = "0xBFEFE8")]
		public ResourceLoaderAttribute(string resName)
		{
		}
	}
	[Token(Token = "0x2000117")]
	public static class CGResourceHandler
	{
		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, ICGResourceLoader> Loader;

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xB7EFD0", Offset = "0xB7EFD0", VA = "0xB7EFD0")]
		public static UnityEngine.Component CreateResource(CGModule module, string resName, string context)
		{
			return null;
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xB7F510", Offset = "0xB7F510", VA = "0xB7F510")]
		public static void DestroyResource(CGModule module, string resName, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xB7F230", Offset = "0xB7F230", VA = "0xB7F230")]
		private static void getLoaders()
		{
		}
	}
	[Token(Token = "0x2000118")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x500588", Offset = "0x500588")]
	public class CGSplineResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x600083F")]
		[Address(RVA = "0xB80398", Offset = "0xB80398", VA = "0xB80398", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xB804C0", Offset = "0xB804C0", VA = "0xB804C0", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xB8055C", Offset = "0xB8055C", VA = "0xB8055C")]
		public CGSplineResourceLoader()
		{
		}
	}
	[Token(Token = "0x2000119")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x5005C0", Offset = "0x5005C0")]
	public class CGShapeResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x6000842")]
		[Address(RVA = "0xB801F8", Offset = "0xB801F8", VA = "0xB801F8", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xB802F4", Offset = "0xB802F4", VA = "0xB802F4", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xB80390", Offset = "0xB80390", VA = "0xB80390")]
		public CGShapeResourceLoader()
		{
		}
	}
	[Token(Token = "0x200011A")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x5005F8", Offset = "0x5005F8")]
	public class CGMeshResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x6000845")]
		[Address(RVA = "0xC13998", Offset = "0xC13998", VA = "0xC13998", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xC13A0C", Offset = "0xC13A0C", VA = "0xC13A0C", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xC13CF0", Offset = "0xC13CF0", VA = "0xC13CF0")]
		public CGMeshResourceLoader()
		{
		}
	}
	[Token(Token = "0x200011B")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x500630", Offset = "0x500630")]
	public class CGGameObjectResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x6000848")]
		[Address(RVA = "0xC12370", Offset = "0xC12370", VA = "0xC12370", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xC124E0", Offset = "0xC124E0", VA = "0xC124E0", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xC12700", Offset = "0xC12700", VA = "0xC12700")]
		public CGGameObjectResourceLoader()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200011C")]
	public class CGGameObjectResourceCollection : ICGResourceCollection
	{
		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<Transform> Items;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> PoolNames;

		[Token(Token = "0x170001C8")]
		public int Count
		{
			[Token(Token = "0x600084B")]
			[Address(RVA = "0xC12200", Offset = "0xC12200", VA = "0xC12200", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001C9")]
		public UnityEngine.Component[] ItemsArray
		{
			[Token(Token = "0x600084C")]
			[Address(RVA = "0xC1224C", Offset = "0xC1224C", VA = "0xC1224C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xC122A0", Offset = "0xC122A0", VA = "0xC122A0")]
		public CGGameObjectResourceCollection()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public static class CGUtility
	{
		[Token(Token = "0x600084E")]
		[Address(RVA = "0xB80C7C", Offset = "0xB80C7C", VA = "0xB80C7C")]
		public static Vector2[] CalculateUV2(Vector2[] uv)
		{
			return null;
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xB80D9C", Offset = "0xB80D9C", VA = "0xB80D9C")]
		public static List<ControlPointOption> GetControlPointsWithOptions(CGDataRequestMetaCGOptions options, CurvySpline shape, float startDist, float endDist, bool optimize, out int initialMaterialID, out float initialMaxStep)
		{
			return null;
		}
	}
	[Token(Token = "0x200011E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x500668", Offset = "0x500668")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x500668", Offset = "0x500668")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x500668", Offset = "0x500668")]
	public class CurvyGenerator : DTVersionedMonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200011F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x500724", Offset = "0x500724")]
		private sealed class <>c
		{
			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<CGModule, bool> <>9__46_0;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<CGModule, float> <>9__46_1;

			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<CGModuleInputSlot, IEnumerable<CGModule>> <>9__65_0;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<CGModule, float> <>9__65_1;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<CGModuleInputSlot, IEnumerable<CGModule>> <>9__66_0;

			[Token(Token = "0x600087E")]
			[Address(RVA = "0xE7E46C", Offset = "0xE7E46C", VA = "0xE7E46C")]
			public <>c()
			{
			}

			[Token(Token = "0x600087F")]
			[Address(RVA = "0xE7E474", Offset = "0xE7E474", VA = "0xE7E474")]
			internal bool <ReorderModules>b__46_0(CGModule m)
			{
				return default(bool);
			}

			[Token(Token = "0x6000880")]
			[Address(RVA = "0xE7E4D4", Offset = "0xE7E4D4", VA = "0xE7E4D4")]
			internal float <ReorderModules>b__46_1(CGModule m)
			{
				return default(float);
			}

			[Token(Token = "0x6000881")]
			[Address(RVA = "0xE7E4FC", Offset = "0xE7E4FC", VA = "0xE7E4FC")]
			internal IEnumerable<CGModule> <ReorderEndpointRecursiveInputs>b__65_0(CGModuleInputSlot i)
			{
				return null;
			}

			[Token(Token = "0x6000882")]
			[Address(RVA = "0xE7E518", Offset = "0xE7E518", VA = "0xE7E518")]
			internal float <ReorderEndpointRecursiveInputs>b__65_1(CGModule m)
			{
				return default(float);
			}

			[Token(Token = "0x6000883")]
			[Address(RVA = "0xE7E540", Offset = "0xE7E540", VA = "0xE7E540")]
			internal IEnumerable<CGModule> <UpdateModulesRecursiveInputs>b__66_0(CGModuleInputSlot i)
			{
				return null;
			}
		}

		[Token(Token = "0x2000120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x500734", Offset = "0x500734")]
		private sealed class <>c__DisplayClass66_0
		{
			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs;

			[Token(Token = "0x6000884")]
			[Address(RVA = "0xE7E55C", Offset = "0xE7E55C", VA = "0xE7E55C")]
			public <>c__DisplayClass66_0()
			{
			}

			[Token(Token = "0x6000885")]
			[Address(RVA = "0xE7E564", Offset = "0xE7E564", VA = "0xE7E564")]
			internal IEnumerable<CGModule> <UpdateModulesRecursiveInputs>b__1(CGModule i)
			{
				return null;
			}
		}

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x506F60", Offset = "0x506F60")]
		private bool m_ShowDebug;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x506FAC", Offset = "0x506FAC")]
		[SerializeField]
		private bool m_AutoRefresh;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Positive]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x506FF8", Offset = "0x506FF8")]
		private int m_RefreshDelay;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Positive]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x5070D8", Offset = "0x5070D8")]
		private int m_RefreshDelayEditor;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x5071B8", Offset = "0x5071B8")]
		protected CurvyCGEvent m_OnRefresh;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public List<CGModule> Modules;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		internal int m_LastModuleID;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x507274", Offset = "0x507274")]
		private bool <Destroying>k__BackingField;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Dictionary<int, CGModule> ModulesByID;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool mInitialized;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool mInitializedPhaseOne;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool mNeedSort;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private double mLastUpdateTime;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private PoolManager mPoolManager;

		[Token(Token = "0x40003FD")]
		private const int ModulesReorderingDeltaX = 50;

		[Token(Token = "0x40003FE")]
		private const int ModulesReorderingDeltaY = 20;

		[Token(Token = "0x170001CA")]
		public bool ShowDebug
		{
			[Token(Token = "0x6000850")]
			[Address(RVA = "0xBAF6DC", Offset = "0xBAF6DC", VA = "0xBAF6DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000851")]
			[Address(RVA = "0xBAF6E4", Offset = "0xBAF6E4", VA = "0xBAF6E4")]
			set
			{
			}
		}

		[Token(Token = "0x170001CB")]
		public bool AutoRefresh
		{
			[Token(Token = "0x6000852")]
			[Address(RVA = "0xBAF704", Offset = "0xBAF704", VA = "0xBAF704")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000853")]
			[Address(RVA = "0xBAF70C", Offset = "0xBAF70C", VA = "0xBAF70C")]
			set
			{
			}
		}

		[Token(Token = "0x170001CC")]
		public int RefreshDelay
		{
			[Token(Token = "0x6000854")]
			[Address(RVA = "0xBAF72C", Offset = "0xBAF72C", VA = "0xBAF72C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000855")]
			[Address(RVA = "0xBAF734", Offset = "0xBAF734", VA = "0xBAF734")]
			set
			{
			}
		}

		[Token(Token = "0x170001CD")]
		public int RefreshDelayEditor
		{
			[Token(Token = "0x6000856")]
			[Address(RVA = "0xBAF76C", Offset = "0xBAF76C", VA = "0xBAF76C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000857")]
			[Address(RVA = "0xBAF774", Offset = "0xBAF774", VA = "0xBAF774")]
			set
			{
			}
		}

		[Token(Token = "0x170001CE")]
		public PoolManager PoolManager
		{
			[Token(Token = "0x6000858")]
			[Address(RVA = "0xBAF7AC", Offset = "0xBAF7AC", VA = "0xBAF7AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CF")]
		public CurvyCGEvent OnRefresh
		{
			[Token(Token = "0x6000859")]
			[Address(RVA = "0xBAF860", Offset = "0xBAF860", VA = "0xBAF860")]
			get
			{
				return null;
			}
			[Token(Token = "0x600085A")]
			[Address(RVA = "0xBAF868", Offset = "0xBAF868", VA = "0xBAF868")]
			set
			{
			}
		}

		[Token(Token = "0x170001D0")]
		public bool IsInitialized
		{
			[Token(Token = "0x600085B")]
			[Address(RVA = "0xBAF880", Offset = "0xBAF880", VA = "0xBAF880")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001D1")]
		public bool Destroying
		{
			[Token(Token = "0x600085C")]
			[Address(RVA = "0xBAF888", Offset = "0xBAF888", VA = "0xBAF888")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E414", Offset = "0x50E414")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600085D")]
			[Address(RVA = "0xBAF890", Offset = "0xBAF890", VA = "0xBAF890")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E424", Offset = "0x50E424")]
			private set
			{
			}
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xBAF89C", Offset = "0xBAF89C", VA = "0xBAF89C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xBAF8C0", Offset = "0xBAF8C0", VA = "0xBAF8C0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xBAF8D0", Offset = "0xBAF8D0", VA = "0xBAF8D0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xBAF8DC", Offset = "0xBAF8DC", VA = "0xBAF8DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xBAFE0C", Offset = "0xBAFE0C", VA = "0xBAFE0C")]
		public static CurvyGenerator Create()
		{
			return null;
		}

		[Token(Token = "0x6000863")]
		public T AddModule<T>() where T : CGModule
		{
			return null;
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xBAFF68", Offset = "0xBAFF68", VA = "0xBAFF68")]
		public CGModule AddModule(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xBB00E4", Offset = "0xBB00E4", VA = "0xBB00E4")]
		public void ArrangeModules()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xBB03F8", Offset = "0xBB03F8", VA = "0xBB03F8")]
		public void ReorderModules()
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xBB1300", Offset = "0xBB1300", VA = "0xBB1300")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xBB1444", Offset = "0xBB1444", VA = "0xBB1444")]
		public void DeleteModule(CGModule module)
		{
		}

		[Token(Token = "0x6000869")]
		public List<T> FindModules<T>(bool includeOnRequestProcessing = false) where T : CGModule
		{
			return null;
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0xBB14CC", Offset = "0xBB14CC", VA = "0xBB14CC")]
		public List<CGModule> GetModules(bool includeOnRequestProcessing = false)
		{
			return null;
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xBB1660", Offset = "0xBB1660", VA = "0xBB1660")]
		public CGModule GetModule(int moduleID, bool includeOnRequestProcessing = false)
		{
			return null;
		}

		[Token(Token = "0x600086C")]
		public T GetModule<T>(int moduleID, bool includeOnRequestProcessing = false) where T : CGModule
		{
			return null;
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xBB1714", Offset = "0xBB1714", VA = "0xBB1714")]
		public CGModule GetModule(string moduleName, bool includeOnRequestProcessing = false)
		{
			return null;
		}

		[Token(Token = "0x600086E")]
		public T GetModule<T>(string moduleName, bool includeOnRequestProcessing = false) where T : CGModule
		{
			return null;
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xBB1868", Offset = "0xBB1868", VA = "0xBB1868")]
		public CGModuleOutputSlot GetModuleOutputSlot(int moduleId, string slotName)
		{
			return null;
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xBB1924", Offset = "0xBB1924", VA = "0xBB1924")]
		public CGModuleOutputSlot GetModuleOutputSlot(string moduleName, string slotName)
		{
			return null;
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xBAF8F0", Offset = "0xBAF8F0", VA = "0xBAF8F0")]
		public void Initialize(bool force = false)
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xBB19EC", Offset = "0xBB19EC", VA = "0xBB19EC")]
		public void Refresh(bool forceUpdate = false)
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xBAFD8C", Offset = "0xBAFD8C", VA = "0xBAFD8C")]
		public void TryAutoRefresh()
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xBB24EC", Offset = "0xBB24EC", VA = "0xBB24EC")]
		protected CurvyCGEventArgs OnRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xBB1304", Offset = "0xBB1304", VA = "0xBB1304")]
		private void clearModules()
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xBB2554", Offset = "0xBB2554", VA = "0xBB2554")]
		public string getUniqueModuleNameINTERNAL(string name)
		{
			return null;
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xBB19E0", Offset = "0xBB19E0", VA = "0xBB19E0")]
		internal void sortModulesINTERNAL()
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xBB20E4", Offset = "0xBB20E4", VA = "0xBB20E4")]
		private bool doSortModules()
		{
			return default(bool);
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xBB0DB4", Offset = "0xBB0DB4", VA = "0xBB0DB4")]
		private static void ReorderEndpointRecursiveInputs(CGModule endPoint, HashSet<int> reordredModuleIds, Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs)
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xBB0A7C", Offset = "0xBB0A7C", VA = "0xBB0A7C")]
		private static HashSet<CGModule> UpdateModulesRecursiveInputs(Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs, CGModule moduleToAdd)
		{
			return null;
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xBB2798", Offset = "0xBB2798", VA = "0xBB2798")]
		public CurvyGenerator()
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xBB28BC", Offset = "0xBB28BC", VA = "0xBB28BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E434", Offset = "0x50E434")]
		private bool <Initialize>b__57_0(CGModule m)
		{
			return default(bool);
		}
	}
}
namespace FluffyUnderware.Curvy.Generator.Modules
{
	[Token(Token = "0x2000121")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x500744", Offset = "0x500744")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x500744", Offset = "0x500744")]
	public class BuildRasterizedPath : CGModule, IPathProvider
	{
		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x507284", Offset = "0x507284")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x50735C", Offset = "0x50735C")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_Range;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x507470", Offset = "0x507470")]
		[SerializeField]
		private int m_Resolution;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private bool m_Optimize;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x5074F4", Offset = "0x5074F4")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x5074F4", Offset = "0x5074F4")]
		private float m_AngleTreshold;

		[Token(Token = "0x170001D2")]
		public float From
		{
			[Token(Token = "0x6000886")]
			[Address(RVA = "0xC056D0", Offset = "0xC056D0", VA = "0xC056D0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000887")]
			[Address(RVA = "0xC056D8", Offset = "0xC056D8", VA = "0xC056D8")]
			set
			{
			}
		}

		[Token(Token = "0x170001D3")]
		public float To
		{
			[Token(Token = "0x6000888")]
			[Address(RVA = "0xC059EC", Offset = "0xC059EC", VA = "0xC059EC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000889")]
			[Address(RVA = "0xC059F4", Offset = "0xC059F4", VA = "0xC059F4")]
			set
			{
			}
		}

		[Token(Token = "0x170001D4")]
		public float Length
		{
			[Token(Token = "0x600088A")]
			[Address(RVA = "0xC05B58", Offset = "0xC05B58", VA = "0xC05B58")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600088B")]
			[Address(RVA = "0xC05B88", Offset = "0xC05B88", VA = "0xC05B88")]
			set
			{
			}
		}

		[Token(Token = "0x170001D5")]
		public int Resolution
		{
			[Token(Token = "0x600088C")]
			[Address(RVA = "0xC05BD8", Offset = "0xC05BD8", VA = "0xC05BD8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600088D")]
			[Address(RVA = "0xC05BE0", Offset = "0xC05BE0", VA = "0xC05BE0")]
			set
			{
			}
		}

		[Token(Token = "0x170001D6")]
		public bool Optimize
		{
			[Token(Token = "0x600088E")]
			[Address(RVA = "0xC05C2C", Offset = "0xC05C2C", VA = "0xC05C2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600088F")]
			[Address(RVA = "0xC05C34", Offset = "0xC05C34", VA = "0xC05C34")]
			set
			{
			}
		}

		[Token(Token = "0x170001D7")]
		public float AngleThreshold
		{
			[Token(Token = "0x6000890")]
			[Address(RVA = "0xC05C58", Offset = "0xC05C58", VA = "0xC05C58")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000891")]
			[Address(RVA = "0xC05C60", Offset = "0xC05C60", VA = "0xC05C60")]
			set
			{
			}
		}

		[Token(Token = "0x170001D8")]
		public CGPath Path
		{
			[Token(Token = "0x6000892")]
			[Address(RVA = "0xC05CAC", Offset = "0xC05CAC", VA = "0xC05CAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D9")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000893")]
			[Address(RVA = "0xC05A6C", Offset = "0xC05A6C", VA = "0xC05A6C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001DA")]
		private RegionOptions<float> RangeOptions
		{
			[Token(Token = "0x6000894")]
			[Address(RVA = "0xC05DE8", Offset = "0xC05DE8", VA = "0xC05DE8")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xC05F08", Offset = "0xC05F08", VA = "0xC05F08", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xC05FE0", Offset = "0xC05FE0", VA = "0xC05FE0", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xC06190", Offset = "0xC06190", VA = "0xC06190", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xC064A4", Offset = "0xC064A4", VA = "0xC064A4")]
		public BuildRasterizedPath()
		{
		}
	}
	[Token(Token = "0x2000122")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x5007DC", Offset = "0x5007DC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5007DC", Offset = "0x5007DC")]
	public class BuildShapeExtrusion : CGModule, IPathProvider
	{
		[Token(Token = "0x2000123")]
		public enum ScaleModeEnum
		{
			[Token(Token = "0x400042F")]
			Simple,
			[Token(Token = "0x4000430")]
			Advanced
		}

		[Token(Token = "0x2000124")]
		public enum CrossShiftModeEnum
		{
			[Token(Token = "0x4000432")]
			None,
			[Token(Token = "0x4000433")]
			ByOrientation,
			[Token(Token = "0x4000434")]
			Custom
		}

		[Serializable]
		[Token(Token = "0x2000125")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x500874", Offset = "0x500874")]
		private sealed class <>c
		{
			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<CGShape, int> <>9__152_0;

			[Token(Token = "0x60008EA")]
			[Address(RVA = "0xE7DF94", Offset = "0xE7DF94", VA = "0xE7DF94")]
			public <>c()
			{
			}

			[Token(Token = "0x60008EB")]
			[Address(RVA = "0xE7DF9C", Offset = "0xE7DF9C", VA = "0xE7DF9C")]
			internal int <Refresh>b__152_0(CGShape c)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x5075F4", Offset = "0x5075F4")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x5076B0", Offset = "0x5076B0")]
		[HideInInspector]
		public CGModuleInputSlot InCross;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x507774", Offset = "0x507774")]
		[HideInInspector]
		public CGModuleOutputSlot OutVolume;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x5077E4", Offset = "0x5077E4")]
		[HideInInspector]
		public CGModuleOutputSlot OutVolumeHollow;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[FloatRegion]
		[SerializeField]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x507854", Offset = "0x507854")]
		private FloatRegion m_Range;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x5078E0", Offset = "0x5078E0")]
		[SerializeField]
		private int m_Resolution;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private bool m_Optimize;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x507964", Offset = "0x507964")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x507964", Offset = "0x507964")]
		[SerializeField]
		private float m_AngleThreshold;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x507A80", Offset = "0x507A80")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x507A80", Offset = "0x507A80")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_CrossRange;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x507B38", Offset = "0x507B38")]
		private int m_CrossResolution;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x507BC0", Offset = "0x507BC0")]
		private bool m_CrossOptimize;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x507C20", Offset = "0x507C20")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x507C20", Offset = "0x507C20")]
		private float m_CrossAngleThreshold;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x507D34", Offset = "0x507D34")]
		[SerializeField]
		private bool m_CrossIncludeControlpoints;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x507D9C", Offset = "0x507D9C")]
		[SerializeField]
		private bool m_CrossHardEdges;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x507E04", Offset = "0x507E04")]
		[SerializeField]
		private bool m_CrossMaterials;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFB")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x507E6C", Offset = "0x507E6C")]
		[SerializeField]
		private bool m_CrossExtendedUV;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x507ED4", Offset = "0x507ED4")]
		[SerializeField]
		private CrossShiftModeEnum m_CrossShiftMode;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x507F58", Offset = "0x507F58")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x507F58", Offset = "0x507F58")]
		private float m_CrossShiftValue;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x508058", Offset = "0x508058")]
		private bool m_CrossReverseNormals;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x5080B8", Offset = "0x5080B8")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x5080B8", Offset = "0x5080B8")]
		private ScaleModeEnum m_ScaleMode;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x508144", Offset = "0x508144")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x508144", Offset = "0x508144")]
		private CGReferenceMode m_ScaleReference;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50822C", Offset = "0x50822C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x50822C", Offset = "0x50822C")]
		[SerializeField]
		private float m_ScaleOffset;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x508314", Offset = "0x508314")]
		[SerializeField]
		private bool m_ScaleUniform;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private float m_ScaleX;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x5083A8", Offset = "0x5083A8")]
		private float m_ScaleY;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x508454", Offset = "0x508454")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x508454", Offset = "0x508454")]
		[AttributeAttribute(Name = "AnimationCurveExAttribute", RVA = "0x508454", Offset = "0x508454")]
		private AnimationCurve m_ScaleCurveX;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "AnimationCurveExAttribute", RVA = "0x508560", Offset = "0x508560")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x508560", Offset = "0x508560")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x508560", Offset = "0x508560")]
		private AnimationCurve m_ScaleCurveY;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x5086B4", Offset = "0x5086B4")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x5086B4", Offset = "0x5086B4")]
		[SerializeField]
		private float m_HollowInset;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x50876C", Offset = "0x50876C")]
		private bool m_HollowReverseNormals;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5087CC", Offset = "0x5087CC")]
		private int <PathSamples>k__BackingField;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5087DC", Offset = "0x5087DC")]
		private int <CrossSamples>k__BackingField;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5087EC", Offset = "0x5087EC")]
		private int <CrossGroups>k__BackingField;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5087FC", Offset = "0x5087FC")]
		private Vector3 <CrossPosition>k__BackingField;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50880C", Offset = "0x50880C")]
		private Quaternion <CrossRotation>k__BackingField;

		[Token(Token = "0x170001DB")]
		public float From
		{
			[Token(Token = "0x6000899")]
			[Address(RVA = "0xC06764", Offset = "0xC06764", VA = "0xC06764")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600089A")]
			[Address(RVA = "0xC0676C", Offset = "0xC0676C", VA = "0xC0676C")]
			set
			{
			}
		}

		[Token(Token = "0x170001DC")]
		public float To
		{
			[Token(Token = "0x600089B")]
			[Address(RVA = "0xC067AC", Offset = "0xC067AC", VA = "0xC067AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600089C")]
			[Address(RVA = "0xC067B4", Offset = "0xC067B4", VA = "0xC067B4")]
			set
			{
			}
		}

		[Token(Token = "0x170001DD")]
		public float Length
		{
			[Token(Token = "0x600089D")]
			[Address(RVA = "0xC0691C", Offset = "0xC0691C", VA = "0xC0691C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600089E")]
			[Address(RVA = "0xC0694C", Offset = "0xC0694C", VA = "0xC0694C")]
			set
			{
			}
		}

		[Token(Token = "0x170001DE")]
		public int Resolution
		{
			[Token(Token = "0x600089F")]
			[Address(RVA = "0xC0699C", Offset = "0xC0699C", VA = "0xC0699C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0xC069A4", Offset = "0xC069A4", VA = "0xC069A4")]
			set
			{
			}
		}

		[Token(Token = "0x170001DF")]
		public bool Optimize
		{
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0xC069F0", Offset = "0xC069F0", VA = "0xC069F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0xC069F8", Offset = "0xC069F8", VA = "0xC069F8")]
			set
			{
			}
		}

		[Token(Token = "0x170001E0")]
		public float AngleThreshold
		{
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0xC06A1C", Offset = "0xC06A1C", VA = "0xC06A1C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0xC06A24", Offset = "0xC06A24", VA = "0xC06A24")]
			set
			{
			}
		}

		[Token(Token = "0x170001E1")]
		public float CrossFrom
		{
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0xC06A70", Offset = "0xC06A70", VA = "0xC06A70")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0xC06A78", Offset = "0xC06A78", VA = "0xC06A78")]
			set
			{
			}
		}

		[Token(Token = "0x170001E2")]
		public float CrossTo
		{
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0xC06AB8", Offset = "0xC06AB8", VA = "0xC06AB8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0xC06AC0", Offset = "0xC06AC0", VA = "0xC06AC0")]
			set
			{
			}
		}

		[Token(Token = "0x170001E3")]
		public float CrossLength
		{
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0xC06C28", Offset = "0xC06C28", VA = "0xC06C28")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0xC06C58", Offset = "0xC06C58", VA = "0xC06C58")]
			set
			{
			}
		}

		[Token(Token = "0x170001E4")]
		public int CrossResolution
		{
			[Token(Token = "0x60008AB")]
			[Address(RVA = "0xC06CA8", Offset = "0xC06CA8", VA = "0xC06CA8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008AC")]
			[Address(RVA = "0xC06CB0", Offset = "0xC06CB0", VA = "0xC06CB0")]
			set
			{
			}
		}

		[Token(Token = "0x170001E5")]
		public bool CrossOptimize
		{
			[Token(Token = "0x60008AD")]
			[Address(RVA = "0xC06CFC", Offset = "0xC06CFC", VA = "0xC06CFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0xC06D04", Offset = "0xC06D04", VA = "0xC06D04")]
			set
			{
			}
		}

		[Token(Token = "0x170001E6")]
		public float CrossAngleThreshold
		{
			[Token(Token = "0x60008AF")]
			[Address(RVA = "0xC06D28", Offset = "0xC06D28", VA = "0xC06D28")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0xC06D30", Offset = "0xC06D30", VA = "0xC06D30")]
			set
			{
			}
		}

		[Token(Token = "0x170001E7")]
		public bool CrossIncludeControlPoints
		{
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0xC06D7C", Offset = "0xC06D7C", VA = "0xC06D7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0xC06D84", Offset = "0xC06D84", VA = "0xC06D84")]
			set
			{
			}
		}

		[Token(Token = "0x170001E8")]
		public bool CrossHardEdges
		{
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0xC06DA8", Offset = "0xC06DA8", VA = "0xC06DA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008B4")]
			[Address(RVA = "0xC06DB0", Offset = "0xC06DB0", VA = "0xC06DB0")]
			set
			{
			}
		}

		[Token(Token = "0x170001E9")]
		public bool CrossMaterials
		{
			[Token(Token = "0x60008B5")]
			[Address(RVA = "0xC06DD4", Offset = "0xC06DD4", VA = "0xC06DD4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0xC06DDC", Offset = "0xC06DDC", VA = "0xC06DDC")]
			set
			{
			}
		}

		[Token(Token = "0x170001EA")]
		public bool CrossExtendedUV
		{
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0xC06E00", Offset = "0xC06E00", VA = "0xC06E00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0xC06E08", Offset = "0xC06E08", VA = "0xC06E08")]
			set
			{
			}
		}

		[Token(Token = "0x170001EB")]
		public CrossShiftModeEnum CrossShiftMode
		{
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0xC06E2C", Offset = "0xC06E2C", VA = "0xC06E2C")]
			get
			{
				return default(CrossShiftModeEnum);
			}
			[Token(Token = "0x60008BA")]
			[Address(RVA = "0xC06E34", Offset = "0xC06E34", VA = "0xC06E34")]
			set
			{
			}
		}

		[Token(Token = "0x170001EC")]
		public float CrossShiftValue
		{
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0xC06E4C", Offset = "0xC06E4C", VA = "0xC06E4C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0xC06E54", Offset = "0xC06E54", VA = "0xC06E54")]
			set
			{
			}
		}

		[Token(Token = "0x170001ED")]
		public bool CrossReverseNormals
		{
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0xC06E94", Offset = "0xC06E94", VA = "0xC06E94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0xC06E9C", Offset = "0xC06E9C", VA = "0xC06E9C")]
			set
			{
			}
		}

		[Token(Token = "0x170001EE")]
		public ScaleModeEnum ScaleMode
		{
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0xC06EC0", Offset = "0xC06EC0", VA = "0xC06EC0")]
			get
			{
				return default(ScaleModeEnum);
			}
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0xC06EC8", Offset = "0xC06EC8", VA = "0xC06EC8")]
			set
			{
			}
		}

		[Token(Token = "0x170001EF")]
		public CGReferenceMode ScaleReference
		{
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0xC06EE0", Offset = "0xC06EE0", VA = "0xC06EE0")]
			get
			{
				return default(CGReferenceMode);
			}
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0xC06EE8", Offset = "0xC06EE8", VA = "0xC06EE8")]
			set
			{
			}
		}

		[Token(Token = "0x170001F0")]
		public bool ScaleUniform
		{
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0xC06F00", Offset = "0xC06F00", VA = "0xC06F00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0xC06F08", Offset = "0xC06F08", VA = "0xC06F08")]
			set
			{
			}
		}

		[Token(Token = "0x170001F1")]
		public float ScaleOffset
		{
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0xC06F2C", Offset = "0xC06F2C", VA = "0xC06F2C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0xC06F34", Offset = "0xC06F34", VA = "0xC06F34")]
			set
			{
			}
		}

		[Token(Token = "0x170001F2")]
		public float ScaleX
		{
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0xC06F4C", Offset = "0xC06F4C", VA = "0xC06F4C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0xC06F54", Offset = "0xC06F54", VA = "0xC06F54")]
			set
			{
			}
		}

		[Token(Token = "0x170001F3")]
		public float ScaleY
		{
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0xC06F6C", Offset = "0xC06F6C", VA = "0xC06F6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0xC06F74", Offset = "0xC06F74", VA = "0xC06F74")]
			set
			{
			}
		}

		[Token(Token = "0x170001F4")]
		public AnimationCurve ScaleMultiplierX
		{
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0xC06F8C", Offset = "0xC06F8C", VA = "0xC06F8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008CC")]
			[Address(RVA = "0xC06F94", Offset = "0xC06F94", VA = "0xC06F94")]
			set
			{
			}
		}

		[Token(Token = "0x170001F5")]
		public AnimationCurve ScaleMultiplierY
		{
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0xC06FD0", Offset = "0xC06FD0", VA = "0xC06FD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0xC06FD8", Offset = "0xC06FD8", VA = "0xC06FD8")]
			set
			{
			}
		}

		[Token(Token = "0x170001F6")]
		public float HollowInset
		{
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0xC07014", Offset = "0xC07014", VA = "0xC07014")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0xC0701C", Offset = "0xC0701C", VA = "0xC0701C")]
			set
			{
			}
		}

		[Token(Token = "0x170001F7")]
		public bool HollowReverseNormals
		{
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0xC07058", Offset = "0xC07058", VA = "0xC07058")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008D2")]
			[Address(RVA = "0xC07060", Offset = "0xC07060", VA = "0xC07060")]
			set
			{
			}
		}

		[Token(Token = "0x170001F8")]
		public int PathSamples
		{
			[Token(Token = "0x60008D3")]
			[Address(RVA = "0xC07084", Offset = "0xC07084", VA = "0xC07084")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E444", Offset = "0x50E444")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008D4")]
			[Address(RVA = "0xC0708C", Offset = "0xC0708C", VA = "0xC0708C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E454", Offset = "0x50E454")]
			private set
			{
			}
		}

		[Token(Token = "0x170001F9")]
		public int CrossSamples
		{
			[Token(Token = "0x60008D5")]
			[Address(RVA = "0xC07094", Offset = "0xC07094", VA = "0xC07094")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E464", Offset = "0x50E464")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008D6")]
			[Address(RVA = "0xC0709C", Offset = "0xC0709C", VA = "0xC0709C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E474", Offset = "0x50E474")]
			private set
			{
			}
		}

		[Token(Token = "0x170001FA")]
		public int CrossGroups
		{
			[Token(Token = "0x60008D7")]
			[Address(RVA = "0xC070A4", Offset = "0xC070A4", VA = "0xC070A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E484", Offset = "0x50E484")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008D8")]
			[Address(RVA = "0xC070AC", Offset = "0xC070AC", VA = "0xC070AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E494", Offset = "0x50E494")]
			private set
			{
			}
		}

		[Token(Token = "0x170001FB")]
		public IExternalInput Cross
		{
			[Token(Token = "0x60008D9")]
			[Address(RVA = "0xC070B4", Offset = "0xC070B4", VA = "0xC070B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FC")]
		public Vector3 CrossPosition
		{
			[Token(Token = "0x60008DA")]
			[Address(RVA = "0xC0710C", Offset = "0xC0710C", VA = "0xC0710C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E4A4", Offset = "0x50E4A4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60008DB")]
			[Address(RVA = "0xC0711C", Offset = "0xC0711C", VA = "0xC0711C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E4B4", Offset = "0x50E4B4")]
			protected set
			{
			}
		}

		[Token(Token = "0x170001FD")]
		public Quaternion CrossRotation
		{
			[Token(Token = "0x60008DC")]
			[Address(RVA = "0xC0712C", Offset = "0xC0712C", VA = "0xC0712C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E4C4", Offset = "0x50E4C4")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60008DD")]
			[Address(RVA = "0xC07140", Offset = "0xC07140", VA = "0xC07140")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E4D4", Offset = "0x50E4D4")]
			protected set
			{
			}
		}

		[Token(Token = "0x170001FE")]
		public bool PathIsClosed
		{
			[Token(Token = "0x60008DE")]
			[Address(RVA = "0xC07154", Offset = "0xC07154", VA = "0xC07154", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001FF")]
		private bool ClampPath
		{
			[Token(Token = "0x60008DF")]
			[Address(RVA = "0xC0682C", Offset = "0xC0682C", VA = "0xC0682C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000200")]
		private bool ClampCross
		{
			[Token(Token = "0x60008E0")]
			[Address(RVA = "0xC06B38", Offset = "0xC06B38", VA = "0xC06B38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000201")]
		private RegionOptions<float> RangeOptions
		{
			[Token(Token = "0x60008E1")]
			[Address(RVA = "0xC0721C", Offset = "0xC0721C", VA = "0xC0721C")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x17000202")]
		private RegionOptions<float> CrossRangeOptions
		{
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0xC0733C", Offset = "0xC0733C", VA = "0xC0733C")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xC0745C", Offset = "0xC0745C", VA = "0xC0745C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0xC074A0", Offset = "0xC074A0", VA = "0xC074A0", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xC07718", Offset = "0xC07718", VA = "0xC07718", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0xC087E8", Offset = "0xC087E8", VA = "0xC087E8")]
		public Vector3 GetScale(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0xC08738", Offset = "0xC08738", VA = "0xC08738")]
		private void getScaleInternal(float f, Vector3 baseScale, ref Vector3 scale)
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xC08870", Offset = "0xC08870", VA = "0xC08870")]
		public BuildShapeExtrusion()
		{
		}
	}
	[Token(Token = "0x2000126")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x500884", Offset = "0x500884")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x500884", Offset = "0x500884")]
	public class BuildVolumeCaps : CGModule
	{
		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x50881C", Offset = "0x50881C")]
		public CGModuleInputSlot InVolume;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x5088C0", Offset = "0x5088C0")]
		public CGModuleInputSlot InVolumeHoles;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x508980", Offset = "0x508980")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x5089FC", Offset = "0x5089FC")]
		[SerializeField]
		private CGYesNoAuto m_StartCap;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private CGYesNoAuto m_EndCap;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x508A58", Offset = "0x508A58")]
		private bool m_ReverseTriOrder;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		[SerializeField]
		private bool m_GenerateUV;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x508AB4", Offset = "0x508AB4")]
		[Inline]
		private CGMaterialSettings m_StartMaterialSettings;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x508B10", Offset = "0x508B10")]
		[SerializeField]
		private Material m_StartMaterial;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x508B78", Offset = "0x508B78")]
		[SerializeField]
		private bool m_CloneStartCap;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x508BC4", Offset = "0x508BC4")]
		[AttributeAttribute(Name = "AsGroupAttribute", RVA = "0x508BC4", Offset = "0x508BC4")]
		private CGMaterialSettings m_EndMaterialSettings;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x508C84", Offset = "0x508C84")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x508C84", Offset = "0x508C84")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x508C84", Offset = "0x508C84")]
		private Material m_EndMaterial;

		[Token(Token = "0x17000203")]
		public bool GenerateUV
		{
			[Token(Token = "0x60008EC")]
			[Address(RVA = "0xC08A10", Offset = "0xC08A10", VA = "0xC08A10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0xC08A18", Offset = "0xC08A18", VA = "0xC08A18")]
			set
			{
			}
		}

		[Token(Token = "0x17000204")]
		public bool ReverseTriOrder
		{
			[Token(Token = "0x60008EE")]
			[Address(RVA = "0xC08A3C", Offset = "0xC08A3C", VA = "0xC08A3C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008EF")]
			[Address(RVA = "0xC08A44", Offset = "0xC08A44", VA = "0xC08A44")]
			set
			{
			}
		}

		[Token(Token = "0x17000205")]
		public CGYesNoAuto StartCap
		{
			[Token(Token = "0x60008F0")]
			[Address(RVA = "0xC08A68", Offset = "0xC08A68", VA = "0xC08A68")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x60008F1")]
			[Address(RVA = "0xC08A70", Offset = "0xC08A70", VA = "0xC08A70")]
			set
			{
			}
		}

		[Token(Token = "0x17000206")]
		public Material StartMaterial
		{
			[Token(Token = "0x60008F2")]
			[Address(RVA = "0xC08A88", Offset = "0xC08A88", VA = "0xC08A88")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0xC08A90", Offset = "0xC08A90", VA = "0xC08A90")]
			set
			{
			}
		}

		[Token(Token = "0x17000207")]
		public CGMaterialSettings StartMaterialSettings
		{
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0xC08B2C", Offset = "0xC08B2C", VA = "0xC08B2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000208")]
		public CGYesNoAuto EndCap
		{
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0xC08B34", Offset = "0xC08B34", VA = "0xC08B34")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0xC08B3C", Offset = "0xC08B3C", VA = "0xC08B3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000209")]
		public bool CloneStartCap
		{
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0xC08B54", Offset = "0xC08B54", VA = "0xC08B54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008F8")]
			[Address(RVA = "0xC08B5C", Offset = "0xC08B5C", VA = "0xC08B5C")]
			set
			{
			}
		}

		[Token(Token = "0x1700020A")]
		public CGMaterialSettings EndMaterialSettings
		{
			[Token(Token = "0x60008F9")]
			[Address(RVA = "0xC08B80", Offset = "0xC08B80", VA = "0xC08B80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020B")]
		public Material EndMaterial
		{
			[Token(Token = "0x60008FA")]
			[Address(RVA = "0xC08B88", Offset = "0xC08B88", VA = "0xC08B88")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008FB")]
			[Address(RVA = "0xC08B90", Offset = "0xC08B90", VA = "0xC08B90")]
			set
			{
			}
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0xC08C2C", Offset = "0xC08C2C", VA = "0xC08C2C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0xC08D50", Offset = "0xC08D50", VA = "0xC08D50", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xC08ED4", Offset = "0xC08ED4", VA = "0xC08ED4", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0xC09BA0", Offset = "0xC09BA0", VA = "0xC09BA0")]
		private static Matrix4x4 getMatrix(CGVolume vol, int index, bool inverse)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0xC09F78", Offset = "0xC09F78", VA = "0xC09F78")]
		private static void flipTris(ref int[] indices, int start, int end)
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0xC09D7C", Offset = "0xC09D7C", VA = "0xC09D7C")]
		private static Vector3[] applyMatrix(Vector3[] vt, Matrix4x4 matrix, out Bounds bounds)
		{
			return null;
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0xC09A08", Offset = "0xC09A08", VA = "0xC09A08")]
		private static ContourVertex[] make2DSegment(CGVolume vol, int segmentIndex)
		{
			return null;
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0xC0A000", Offset = "0xC0A000", VA = "0xC0A000")]
		private static void applyUV(Vector3[] vts, ref Vector2[] uvArray, int index, int count, CGMaterialSettings mat, Bounds bounds)
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0xC0A2D0", Offset = "0xC0A2D0", VA = "0xC0A2D0")]
		public BuildVolumeCaps()
		{
		}
	}
	[Token(Token = "0x2000127")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x50091C", Offset = "0x50091C")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x50091C", Offset = "0x50091C")]
	public class BuildVolumeMesh : CGModule
	{
		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x508D8C", Offset = "0x508D8C")]
		[HideInInspector]
		public CGModuleInputSlot InVolume;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x508E30", Offset = "0x508E30")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x508EAC", Offset = "0x508EAC")]
		private bool m_GenerateUV;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		[SerializeField]
		private bool m_Split;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[Positive]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x508F08", Offset = "0x508F08")]
		[SerializeField]
		private float m_SplitLength;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x508FD4", Offset = "0x508FD4")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x508FD4", Offset = "0x508FD4")]
		[SerializeField]
		private bool m_ReverseTriOrder;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[HideInInspector]
		[SerializeField]
		private List<CGMaterialSettingsEx> m_MaterialSettings;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[HideInInspector]
		private Material[] m_Material;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<SamplePointsMaterialGroupCollection> groupsByMatID;

		[Token(Token = "0x1700020C")]
		public bool GenerateUV
		{
			[Token(Token = "0x6000905")]
			[Address(RVA = "0xC0A408", Offset = "0xC0A408", VA = "0xC0A408")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000906")]
			[Address(RVA = "0xC0A410", Offset = "0xC0A410", VA = "0xC0A410")]
			set
			{
			}
		}

		[Token(Token = "0x1700020D")]
		public bool ReverseTriOrder
		{
			[Token(Token = "0x6000907")]
			[Address(RVA = "0xC0A434", Offset = "0xC0A434", VA = "0xC0A434")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000908")]
			[Address(RVA = "0xC0A43C", Offset = "0xC0A43C", VA = "0xC0A43C")]
			set
			{
			}
		}

		[Token(Token = "0x1700020E")]
		public bool Split
		{
			[Token(Token = "0x6000909")]
			[Address(RVA = "0xC0A460", Offset = "0xC0A460", VA = "0xC0A460")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600090A")]
			[Address(RVA = "0xC0A468", Offset = "0xC0A468", VA = "0xC0A468")]
			set
			{
			}
		}

		[Token(Token = "0x1700020F")]
		public float SplitLength
		{
			[Token(Token = "0x600090B")]
			[Address(RVA = "0xC0A48C", Offset = "0xC0A48C", VA = "0xC0A48C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600090C")]
			[Address(RVA = "0xC0A494", Offset = "0xC0A494", VA = "0xC0A494")]
			set
			{
			}
		}

		[Token(Token = "0x17000210")]
		public List<CGMaterialSettingsEx> MaterialSetttings
		{
			[Token(Token = "0x600090D")]
			[Address(RVA = "0xC0A4D8", Offset = "0xC0A4D8", VA = "0xC0A4D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000211")]
		public int MaterialCount
		{
			[Token(Token = "0x600090E")]
			[Address(RVA = "0xC0A4E0", Offset = "0xC0A4E0", VA = "0xC0A4E0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0xC0A52C", Offset = "0xC0A52C", VA = "0xC0A52C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0xC0A658", Offset = "0xC0A658", VA = "0xC0A658", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0xC0A854", Offset = "0xC0A854", VA = "0xC0A854", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0xC0A578", Offset = "0xC0A578", VA = "0xC0A578")]
		public int AddMaterial()
		{
			return default(int);
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xC0B19C", Offset = "0xC0B19C", VA = "0xC0B19C")]
		public void RemoveMaterial(int index)
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0xC0B320", Offset = "0xC0B320", VA = "0xC0B320")]
		public void SetMaterial(int index, Material mat)
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0xC0B494", Offset = "0xC0B494", VA = "0xC0B494")]
		public Material GetMaterial(int index)
		{
			return null;
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0xC0AD74", Offset = "0xC0AD74", VA = "0xC0AD74")]
		private void prepare(CGVolume vol)
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0xC0ADA0", Offset = "0xC0ADA0", VA = "0xC0ADA0")]
		private void build(CGVMesh vmesh, CGVolume vol, IntRegion subset)
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0xC0B8B8", Offset = "0xC0B8B8", VA = "0xC0B8B8")]
		private static void prepareSubMeshes(CGVMesh vmesh, List<SamplePointsMaterialGroupCollection> groupsBySubMeshes, int extrusions, ref Material[] materials)
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0xC0BA6C", Offset = "0xC0BA6C", VA = "0xC0BA6C")]
		private void createMaterialGroupUV(CGVMesh vmesh, CGVolume vol, SamplePointsMaterialGroup grp, int matIndex, float grpAspectCorrection, int sample, int baseVertex)
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0xC0BC0C", Offset = "0xC0BC0C", VA = "0xC0BC0C")]
		private static int createPatchTriangles(ref int[] triangles, ref int triIdx, int curVTIndex, int patchSize, int crossSize, bool reverse)
		{
			return default(int);
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0xC0B4F0", Offset = "0xC0B4F0", VA = "0xC0B4F0")]
		private List<SamplePointsMaterialGroupCollection> getMaterialIDGroups(CGVolume volume)
		{
			return null;
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0xC0B264", Offset = "0xC0B264", VA = "0xC0B264")]
		private bool validateMaterialIndex(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0xC0BD68", Offset = "0xC0BD68", VA = "0xC0BD68")]
		public BuildVolumeMesh()
		{
		}
	}
	[Token(Token = "0x2000128")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x5009B4", Offset = "0x5009B4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5009B4", Offset = "0x5009B4")]
	public class BuildVolumeSpots : CGModule, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000129")]
		private class EndGroupData
		{
			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5098AC", Offset = "0x5098AC")]
			private CGBoundsGroup <BoundsGroup>k__BackingField;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5098BC", Offset = "0x5098BC")]
			private int[] <ItemIndices>k__BackingField;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5098CC", Offset = "0x5098CC")]
			private readonly float <GroupDepth>k__BackingField;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5098DC", Offset = "0x5098DC")]
			private readonly CGBounds[] <ItemBounds>k__BackingField;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5098EC", Offset = "0x5098EC")]
			private readonly float <SpaceBefore>k__BackingField;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5098FC", Offset = "0x5098FC")]
			private readonly float <SpaceAfter>k__BackingField;

			[Token(Token = "0x17000228")]
			internal CGBoundsGroup BoundsGroup
			{
				[Token(Token = "0x6000954")]
				[Address(RVA = "0xE7E014", Offset = "0xE7E014", VA = "0xE7E014")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E524", Offset = "0x50E524")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000955")]
				[Address(RVA = "0xE7E01C", Offset = "0xE7E01C", VA = "0xE7E01C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E534", Offset = "0x50E534")]
				private set
				{
				}
			}

			[Token(Token = "0x17000229")]
			internal int[] ItemIndices
			{
				[Token(Token = "0x6000956")]
				[Address(RVA = "0xE7E024", Offset = "0xE7E024", VA = "0xE7E024")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E544", Offset = "0x50E544")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000957")]
				[Address(RVA = "0xE7E02C", Offset = "0xE7E02C", VA = "0xE7E02C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E554", Offset = "0x50E554")]
				private set
				{
				}
			}

			[Token(Token = "0x1700022A")]
			internal float GroupDepth
			{
				[Token(Token = "0x6000958")]
				[Address(RVA = "0xE7E034", Offset = "0xE7E034", VA = "0xE7E034")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E564", Offset = "0x50E564")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700022B")]
			internal CGBounds[] ItemBounds
			{
				[Token(Token = "0x6000959")]
				[Address(RVA = "0xE7E03C", Offset = "0xE7E03C", VA = "0xE7E03C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E574", Offset = "0x50E574")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700022C")]
			internal float SpaceBefore
			{
				[Token(Token = "0x600095A")]
				[Address(RVA = "0xE7E044", Offset = "0xE7E044", VA = "0xE7E044")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E584", Offset = "0x50E584")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700022D")]
			internal float SpaceAfter
			{
				[Token(Token = "0x600095B")]
				[Address(RVA = "0xE7E04C", Offset = "0xE7E04C", VA = "0xE7E04C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E594", Offset = "0x50E594")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600095C")]
			[Address(RVA = "0xE7E054", Offset = "0xE7E054", VA = "0xE7E054")]
			public EndGroupData(CGBoundsGroup boundsGroup, int[] itemIndices, float groupDepth, CGBounds[] itemBounds, float spaceBefore, float spaceAfter)
			{
			}
		}

		[Token(Token = "0x200012A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x500A54", Offset = "0x500A54")]
		private sealed class <>c__DisplayClass79_0
		{
			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EndGroupData endGroupData;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float availableSpace;

			[Token(Token = "0x600095D")]
			[Address(RVA = "0xE7DFBC", Offset = "0xE7DFBC", VA = "0xE7DFBC")]
			public <>c__DisplayClass79_0()
			{
			}

			[Token(Token = "0x600095E")]
			[Address(RVA = "0xE7DFC4", Offset = "0xE7DFC4", VA = "0xE7DFC4")]
			internal bool <Refresh>b__0(CGBounds i)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x5090B8", Offset = "0x5090B8")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x509198", Offset = "0x509198")]
		[HideInInspector]
		public CGModuleInputSlot InBounds;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x509250", Offset = "0x509250")]
		public CGModuleOutputSlot OutSpots;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[HideInInspector]
		[SerializeField]
		private bool m_WasUpgraded;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x5092F8", Offset = "0x5092F8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x5092F8", Offset = "0x5092F8")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_Range;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x5093AC", Offset = "0x5093AC")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x5093AC", Offset = "0x5093AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5093AC", Offset = "0x5093AC")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x5093AC", Offset = "0x5093AC")]
		private bool m_UseVolume;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x509498", Offset = "0x509498")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x509498", Offset = "0x509498")]
		private float m_CrossBase;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x50952C", Offset = "0x50952C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x50952C", Offset = "0x50952C")]
		private AnimationCurve m_CrossCurve;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x5095B8", Offset = "0x5095B8")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5095B8", Offset = "0x5095B8")]
		private bool m_Simulate;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x509634", Offset = "0x509634")]
		private bool m_UseBuggedRNG;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x509680", Offset = "0x509680")]
		[ArrayEx]
		[SerializeField]
		private List<CGBoundsGroup> m_Groups;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[IntRegion]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5096E8", Offset = "0x5096E8")]
		[SerializeField]
		private IntRegion m_RepeatingGroups;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[SerializeField]
		private CurvyRepeatingOrderEnum m_RepeatingOrder;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x509780", Offset = "0x509780")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x509780", Offset = "0x509780")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x509780", Offset = "0x509780")]
		private bool m_FitEnd;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50988C", Offset = "0x50988C")]
		private int <Count>k__BackingField;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public CGSpots SimulatedSpots;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private WeightedRandom<int> mGroupBag;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private List<CGBounds> mBounds;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50989C", Offset = "0x50989C")]
		private CGPath <Path>k__BackingField;

		[Token(Token = "0x17000212")]
		public FloatRegion Range
		{
			[Token(Token = "0x600091E")]
			[Address(RVA = "0xC0BE98", Offset = "0xC0BE98", VA = "0xC0BE98")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x600091F")]
			[Address(RVA = "0xC0BEA8", Offset = "0xC0BEA8", VA = "0xC0BEA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000213")]
		public bool UseVolume
		{
			[Token(Token = "0x6000920")]
			[Address(RVA = "0xC0BF00", Offset = "0xC0BF00", VA = "0xC0BF00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000921")]
			[Address(RVA = "0xC0BF08", Offset = "0xC0BF08", VA = "0xC0BF08")]
			set
			{
			}
		}

		[Token(Token = "0x17000214")]
		public bool Simulate
		{
			[Token(Token = "0x6000922")]
			[Address(RVA = "0xC0BF2C", Offset = "0xC0BF2C", VA = "0xC0BF2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000923")]
			[Address(RVA = "0xC0BF34", Offset = "0xC0BF34", VA = "0xC0BF34")]
			set
			{
			}
		}

		[Token(Token = "0x17000215")]
		public bool UseBuggedRng
		{
			[Token(Token = "0x6000924")]
			[Address(RVA = "0xC0BF58", Offset = "0xC0BF58", VA = "0xC0BF58")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000925")]
			[Address(RVA = "0xC0BF60", Offset = "0xC0BF60", VA = "0xC0BF60")]
			set
			{
			}
		}

		[Token(Token = "0x17000216")]
		public float CrossBase
		{
			[Token(Token = "0x6000926")]
			[Address(RVA = "0xC0BF84", Offset = "0xC0BF84", VA = "0xC0BF84")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000927")]
			[Address(RVA = "0xC0BF8C", Offset = "0xC0BF8C", VA = "0xC0BF8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000217")]
		public AnimationCurve CrossCurve
		{
			[Token(Token = "0x6000928")]
			[Address(RVA = "0xC0BFCC", Offset = "0xC0BFCC", VA = "0xC0BFCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000929")]
			[Address(RVA = "0xC0BFD4", Offset = "0xC0BFD4", VA = "0xC0BFD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000218")]
		public List<CGBoundsGroup> Groups
		{
			[Token(Token = "0x600092A")]
			[Address(RVA = "0xC0C00C", Offset = "0xC0C00C", VA = "0xC0C00C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600092B")]
			[Address(RVA = "0xC0C014", Offset = "0xC0C014", VA = "0xC0C014")]
			set
			{
			}
		}

		[Token(Token = "0x17000219")]
		public CurvyRepeatingOrderEnum RepeatingOrder
		{
			[Token(Token = "0x600092C")]
			[Address(RVA = "0xC0C02C", Offset = "0xC0C02C", VA = "0xC0C02C")]
			get
			{
				return default(CurvyRepeatingOrderEnum);
			}
			[Token(Token = "0x600092D")]
			[Address(RVA = "0xC0C034", Offset = "0xC0C034", VA = "0xC0C034")]
			set
			{
			}
		}

		[Token(Token = "0x1700021A")]
		public int FirstRepeating
		{
			[Token(Token = "0x600092E")]
			[Address(RVA = "0xC0C04C", Offset = "0xC0C04C", VA = "0xC0C04C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600092F")]
			[Address(RVA = "0xC0C054", Offset = "0xC0C054", VA = "0xC0C054")]
			set
			{
			}
		}

		[Token(Token = "0x1700021B")]
		public int LastRepeating
		{
			[Token(Token = "0x6000930")]
			[Address(RVA = "0xC0C100", Offset = "0xC0C100", VA = "0xC0C100")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000931")]
			[Address(RVA = "0xC0C108", Offset = "0xC0C108", VA = "0xC0C108")]
			set
			{
			}
		}

		[Token(Token = "0x1700021C")]
		public bool FitEnd
		{
			[Token(Token = "0x6000932")]
			[Address(RVA = "0xC0C174", Offset = "0xC0C174", VA = "0xC0C174")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000933")]
			[Address(RVA = "0xC0C17C", Offset = "0xC0C17C", VA = "0xC0C17C")]
			set
			{
			}
		}

		[Token(Token = "0x1700021D")]
		public int GroupCount
		{
			[Token(Token = "0x6000934")]
			[Address(RVA = "0xC0C0B4", Offset = "0xC0C0B4", VA = "0xC0C0B4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700021E")]
		public GUIContent[] BoundsNames
		{
			[Token(Token = "0x6000935")]
			[Address(RVA = "0xC0C1A0", Offset = "0xC0C1A0", VA = "0xC0C1A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021F")]
		public int[] BoundsIndices
		{
			[Token(Token = "0x6000936")]
			[Address(RVA = "0xC0C3C4", Offset = "0xC0C3C4", VA = "0xC0C3C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000220")]
		public int Count
		{
			[Token(Token = "0x6000937")]
			[Address(RVA = "0xC0C488", Offset = "0xC0C488", VA = "0xC0C488")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E4E4", Offset = "0x50E4E4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000938")]
			[Address(RVA = "0xC0C490", Offset = "0xC0C490", VA = "0xC0C490")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E4F4", Offset = "0x50E4F4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000221")]
		private int lastGroupIndex
		{
			[Token(Token = "0x6000939")]
			[Address(RVA = "0xC0C498", Offset = "0xC0C498", VA = "0xC0C498")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000222")]
		private RegionOptions<float> RangeOptions
		{
			[Token(Token = "0x600093A")]
			[Address(RVA = "0xC0C4B8", Offset = "0xC0C4B8", VA = "0xC0C4B8")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x17000223")]
		private RegionOptions<int> RepeatingGroupsOptions
		{
			[Token(Token = "0x600093B")]
			[Address(RVA = "0xC0C528", Offset = "0xC0C528", VA = "0xC0C528")]
			get
			{
				return default(RegionOptions<int>);
			}
		}

		[Token(Token = "0x17000224")]
		private CGPath Path
		{
			[Token(Token = "0x600093C")]
			[Address(RVA = "0xC0C5BC", Offset = "0xC0C5BC", VA = "0xC0C5BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E504", Offset = "0x50E504")]
			get
			{
				return null;
			}
			[Token(Token = "0x600093D")]
			[Address(RVA = "0xC0C5C4", Offset = "0xC0C5C4", VA = "0xC0C5C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E514", Offset = "0x50E514")]
			set
			{
			}
		}

		[Token(Token = "0x17000225")]
		private CGVolume Volume
		{
			[Token(Token = "0x600093E")]
			[Address(RVA = "0xC0C5D4", Offset = "0xC0C5D4", VA = "0xC0C5D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000226")]
		private float Length
		{
			[Token(Token = "0x600093F")]
			[Address(RVA = "0xC0C654", Offset = "0xC0C654", VA = "0xC0C654")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000227")]
		private bool ShowFitEnd
		{
			[Token(Token = "0x6000950")]
			[Address(RVA = "0xC0FB58", Offset = "0xC0FB58", VA = "0xC0FB58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0xC0C690", Offset = "0xC0C690", VA = "0xC0C690", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0xC0C6C4", Offset = "0xC0C6C4", VA = "0xC0C6C4", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0xC0C8FC", Offset = "0xC0C8FC", VA = "0xC0C8FC", Slot = "12")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0xC0C9EC", Offset = "0xC0C9EC", VA = "0xC0C9EC")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0xC0CAEC", Offset = "0xC0CAEC", VA = "0xC0CAEC", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0xC0C804", Offset = "0xC0C804", VA = "0xC0C804")]
		public CGBoundsGroup AddGroup(string name)
		{
			return null;
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0xC0EEF0", Offset = "0xC0EEF0", VA = "0xC0EEF0")]
		public void RemoveGroup(CGBoundsGroup group)
		{
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0xC0E678", Offset = "0xC0E678", VA = "0xC0E678")]
		private static int[] GetGroupItemIndices(CGBoundsGroup boundsGroup, WeightedRandom<int> groupItemBag)
		{
			return null;
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0xC0E830", Offset = "0xC0E830", VA = "0xC0E830")]
		private float GetGroupDepth(int[] groupItemIndices, float spaceBefore, float spaceAfter, out CGBounds[] itemsBounds)
		{
			return default(float);
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0xC0E4AC", Offset = "0xC0E4AC", VA = "0xC0E4AC")]
		private bool AddGroupItems(int groupIndex, ref List<CGSpot> spots, float remainingLength, float startDistance, ref float currentDistance, out bool failedAddingAllItems, Dictionary<CGBoundsGroup, WeightedRandom<int>> itemsBagDictionary, int MaxSpotsCount)
		{
			return default(bool);
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0xC0E9C8", Offset = "0xC0E9C8", VA = "0xC0E9C8")]
		private void AddGroupItems(CGBoundsGroup group, ref List<CGSpot> spots, float remainingLength, float startDistance, ref float currentDistance, out bool failedAddingAllItems, int[] itemIndices, float groupDepth, CGBounds[] itemBounds, float spaceBefore, float spaceAfter)
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0xC0EF70", Offset = "0xC0EF70", VA = "0xC0EF70")]
		private CGSpot GetSpot(int itemID, CGBoundsGroup boundsGroup, CGBounds bounds, float currentDistance, float startDistance)
		{
			return default(CGSpot);
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0xC0E7DC", Offset = "0xC0E7DC", VA = "0xC0E7DC")]
		private static float GetRegionNextValue(FloatRegion floatRegion)
		{
			return default(float);
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0xC0F83C", Offset = "0xC0F83C", VA = "0xC0F83C")]
		private void GetTRS(CGBoundsGroup boundsGroup, Vector3 tangent, Vector3 up, out Quaternion rotation, out Vector3 translation, out Vector3 scale)
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0xC0F3E8", Offset = "0xC0F3E8", VA = "0xC0F3E8")]
		private void GetTRS630(CGBoundsGroup boundsGroup, Vector3 tangent, Vector3 up, out Quaternion rotation, out Vector3 translation, out Vector3 scale)
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0xC0E188", Offset = "0xC0E188", VA = "0xC0E188")]
		private Dictionary<CGBoundsGroup, WeightedRandom<int>> Prepare()
		{
			return null;
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0xC0FBB4", Offset = "0xC0FBB4", VA = "0xC0FBB4", Slot = "14")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0xC0FBB8", Offset = "0xC0FBB8", VA = "0xC0FBB8", Slot = "15")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0xC103A8", Offset = "0xC103A8", VA = "0xC103A8")]
		public BuildVolumeSpots()
		{
		}
	}
	[Token(Token = "0x200012B")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x500A64", Offset = "0x500A64")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x500A64", Offset = "0x500A64")]
	public class ConformPath : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x50990C", Offset = "0x50990C")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x5099E4", Offset = "0x5099E4")]
		[HideInInspector]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x509A54", Offset = "0x509A54")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x509A54", Offset = "0x509A54")]
		private Vector3 m_Direction;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x509AE0", Offset = "0x509AE0")]
		private float m_MaxDistance;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x509B2C", Offset = "0x509B2C")]
		private float m_Offset;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x509B78", Offset = "0x509B78")]
		private bool m_Warp;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x509BC4", Offset = "0x509BC4")]
		private LayerMask m_LayerMask;

		[Token(Token = "0x1700022E")]
		public Vector3 Direction
		{
			[Token(Token = "0x600095F")]
			[Address(RVA = "0xB8A5E8", Offset = "0xB8A5E8", VA = "0xB8A5E8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000960")]
			[Address(RVA = "0xB8A5F4", Offset = "0xB8A5F4", VA = "0xB8A5F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700022F")]
		public float MaxDistance
		{
			[Token(Token = "0x6000961")]
			[Address(RVA = "0xB8A664", Offset = "0xB8A664", VA = "0xB8A664")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000962")]
			[Address(RVA = "0xB8A66C", Offset = "0xB8A66C", VA = "0xB8A66C")]
			set
			{
			}
		}

		[Token(Token = "0x17000230")]
		public float Offset
		{
			[Token(Token = "0x6000963")]
			[Address(RVA = "0xB8A688", Offset = "0xB8A688", VA = "0xB8A688")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000964")]
			[Address(RVA = "0xB8A690", Offset = "0xB8A690", VA = "0xB8A690")]
			set
			{
			}
		}

		[Token(Token = "0x17000231")]
		public bool Warp
		{
			[Token(Token = "0x6000965")]
			[Address(RVA = "0xB8A6AC", Offset = "0xB8A6AC", VA = "0xB8A6AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000966")]
			[Address(RVA = "0xB8A6B4", Offset = "0xB8A6B4", VA = "0xB8A6B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000232")]
		public LayerMask LayerMask
		{
			[Token(Token = "0x6000967")]
			[Address(RVA = "0xB8A6DC", Offset = "0xB8A6DC", VA = "0xB8A6DC")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000968")]
			[Address(RVA = "0xB8A6E4", Offset = "0xB8A6E4", VA = "0xB8A6E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000233")]
		public bool PathIsClosed
		{
			[Token(Token = "0x600096B")]
			[Address(RVA = "0xB8A82C", Offset = "0xB8A82C", VA = "0xB8A82C", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0xB8A740", Offset = "0xB8A740", VA = "0xB8A740", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0xB8A778", Offset = "0xB8A778", VA = "0xB8A778", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0xB8A918", Offset = "0xB8A918", VA = "0xB8A918", Slot = "14")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0xB8AAAC", Offset = "0xB8AAAC", VA = "0xB8AAAC")]
		public static CGPath Conform(Transform pathTransform, CGPath path, LayerMask layers, Vector3 projectionDirection, float offset, float rayLength, bool warp)
		{
			return null;
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0xB8ADDC", Offset = "0xB8ADDC", VA = "0xB8ADDC")]
		public ConformPath()
		{
		}
	}
	[Token(Token = "0x200012C")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x500AFC", Offset = "0x500AFC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x500AFC", Offset = "0x500AFC")]
	public class CreateGameObject : CGModule
	{
		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x509C10", Offset = "0x509C10")]
		[HideInInspector]
		public CGModuleInputSlot InGameObjectArray;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x509CE4", Offset = "0x509CE4")]
		[HideInInspector]
		public CGModuleInputSlot InSpots;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceCollectionManagerAttribute", RVA = "0x509DB0", Offset = "0x509DB0")]
		private CGGameObjectResourceCollection m_Resources;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x509E08", Offset = "0x509E08")]
		[SerializeField]
		private bool m_MakeStatic;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "LayerAttribute", RVA = "0x509E54", Offset = "0x509E54")]
		private int m_Layer;

		[Token(Token = "0x17000234")]
		public int Layer
		{
			[Token(Token = "0x600096F")]
			[Address(RVA = "0xB8B44C", Offset = "0xB8B44C", VA = "0xB8B44C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000970")]
			[Address(RVA = "0xB8B454", Offset = "0xB8B454", VA = "0xB8B454")]
			set
			{
			}
		}

		[Token(Token = "0x17000235")]
		public bool MakeStatic
		{
			[Token(Token = "0x6000971")]
			[Address(RVA = "0xB8B4A0", Offset = "0xB8B4A0", VA = "0xB8B4A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000972")]
			[Address(RVA = "0xB8B4A8", Offset = "0xB8B4A8", VA = "0xB8B4A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000236")]
		public CGGameObjectResourceCollection GameObjects
		{
			[Token(Token = "0x6000973")]
			[Address(RVA = "0xB8B4D0", Offset = "0xB8B4D0", VA = "0xB8B4D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000237")]
		public int GameObjectCount
		{
			[Token(Token = "0x6000974")]
			[Address(RVA = "0xB8B4D8", Offset = "0xB8B4D8", VA = "0xB8B4D8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0xB8B4F4", Offset = "0xB8B4F4", VA = "0xB8B4F4", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0xB8B6A0", Offset = "0xB8B6A0", VA = "0xB8B6A0", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0xB8B6E4", Offset = "0xB8B6E4", VA = "0xB8B6E4", Slot = "13")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0xB8B544", Offset = "0xB8B544", VA = "0xB8B544")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0xB8B6E8", Offset = "0xB8B6E8", VA = "0xB8B6E8", Slot = "12")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0xB8B730", Offset = "0xB8B730", VA = "0xB8B730", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0xB8BF58", Offset = "0xB8BF58", VA = "0xB8BF58")]
		public CreateGameObject()
		{
		}
	}
	[Token(Token = "0x200012D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x500B78", Offset = "0x500B78")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x500B78", Offset = "0x500B78")]
	public class CreateMesh : CGModule
	{
		[Serializable]
		[Token(Token = "0x200012E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x500BF4", Offset = "0x500BF4")]
		private sealed class <>c
		{
			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<CGSpots, bool> <>9__109_0;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<CGSpots, IEnumerable<CGSpot>> <>9__109_1;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Comparison<CGSpot> <>9__114_0;

			[Token(Token = "0x60009BD")]
			[Address(RVA = "0xE7E23C", Offset = "0xE7E23C", VA = "0xE7E23C")]
			public <>c()
			{
			}

			[Token(Token = "0x60009BE")]
			[Address(RVA = "0xE7E244", Offset = "0xE7E244", VA = "0xE7E244")]
			internal bool <Refresh>b__109_0(CGSpots s)
			{
				return default(bool);
			}

			[Token(Token = "0x60009BF")]
			[Address(RVA = "0xE7E250", Offset = "0xE7E250", VA = "0xE7E250")]
			internal IEnumerable<CGSpot> <Refresh>b__109_1(CGSpots s)
			{
				return null;
			}

			[Token(Token = "0x60009C0")]
			[Address(RVA = "0xE7E268", Offset = "0xE7E268", VA = "0xE7E268")]
			internal int <createSpotMeshes>b__114_0(CGSpot a, CGSpot b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000473")]
		private const string DefaultTag = "Untagged";

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x509EBC", Offset = "0x509EBC")]
		[HideInInspector]
		public CGModuleInputSlot InVMeshArray;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x509F90", Offset = "0x509F90")]
		public CGModuleInputSlot InSpots;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceCollectionManagerAttribute", RVA = "0x50B06C", Offset = "0x50B06C")]
		private CGMeshResourceCollection m_MeshResources;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50B0C4", Offset = "0x50B0C4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x50B0C4", Offset = "0x50B0C4")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x50B0C4", Offset = "0x50B0C4")]
		private bool m_Combine;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x50B1C4", Offset = "0x50B1C4")]
		[SerializeField]
		private bool m_GroupMeshes;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50B210", Offset = "0x50B210")]
		private CGYesNoAuto m_AddNormals;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50B2C8", Offset = "0x50B2C8")]
		private CGYesNoAuto m_AddTangents;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50B380", Offset = "0x50B380")]
		[SerializeField]
		private bool m_AddUV2;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50B438", Offset = "0x50B438")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x50B438", Offset = "0x50B438")]
		private bool m_MakeStatic;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50B514", Offset = "0x50B514")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x50B514", Offset = "0x50B514")]
		[SerializeField]
		[AttributeAttribute(Name = "LayerAttribute", RVA = "0x50B514", Offset = "0x50B514")]
		private int m_Layer;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[AttributeAttribute(Name = "TagAttribute", RVA = "0x50B628", Offset = "0x50B628")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50B628", Offset = "0x50B628")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x50B628", Offset = "0x50B628")]
		private string m_Tag;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x50B744", Offset = "0x50B744")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50B744", Offset = "0x50B744")]
		private bool m_RendererEnabled;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50B820", Offset = "0x50B820")]
		private ShadowCastingMode m_CastShadows;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50B8D8", Offset = "0x50B8D8")]
		private bool m_ReceiveShadows;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50B990", Offset = "0x50B990")]
		private LightProbeUsage m_LightProbeUsage;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[HideInInspector]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50BA48", Offset = "0x50BA48")]
		private bool m_UseLightProbes;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50BB10", Offset = "0x50BB10")]
		[SerializeField]
		private ReflectionProbeUsage m_ReflectionProbes;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50BBC8", Offset = "0x50BBC8")]
		[SerializeField]
		private Transform m_AnchorOverride;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50BC80", Offset = "0x50BC80")]
		[SerializeField]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x50BC80", Offset = "0x50BC80")]
		private CGColliderEnum m_Collider;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50BD5C", Offset = "0x50BD5C")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50BD5C", Offset = "0x50BD5C")]
		private bool m_Convex;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x105")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50BE80", Offset = "0x50BE80")]
		[SerializeField]
		private bool m_IsTrigger;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50BF38", Offset = "0x50BF38")]
		[AttributeAttribute(Name = "EnumFlagAttribute", RVA = "0x50BF38", Offset = "0x50BF38")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50BF38", Offset = "0x50BF38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x50BF38", Offset = "0x50BF38")]
		[SerializeField]
		private MeshColliderCookingOptions m_CookingOptions;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x50C0B8", Offset = "0x50C0B8")]
		private bool m_AutoUpdateColliders;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private PhysicMaterial m_Material;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50C128", Offset = "0x50C128")]
		private int <VertexCount>k__BackingField;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private int mCurrentMeshCount;

		[Token(Token = "0x17000238")]
		public bool Combine
		{
			[Token(Token = "0x600097C")]
			[Address(RVA = "0xB8C02C", Offset = "0xB8C02C", VA = "0xB8C02C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600097D")]
			[Address(RVA = "0xB8C034", Offset = "0xB8C034", VA = "0xB8C034")]
			set
			{
			}
		}

		[Token(Token = "0x17000239")]
		public bool GroupMeshes
		{
			[Token(Token = "0x600097E")]
			[Address(RVA = "0xB8C05C", Offset = "0xB8C05C", VA = "0xB8C05C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600097F")]
			[Address(RVA = "0xB8C064", Offset = "0xB8C064", VA = "0xB8C064")]
			set
			{
			}
		}

		[Token(Token = "0x1700023A")]
		public CGYesNoAuto AddNormals
		{
			[Token(Token = "0x6000980")]
			[Address(RVA = "0xB8C08C", Offset = "0xB8C08C", VA = "0xB8C08C")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x6000981")]
			[Address(RVA = "0xB8C094", Offset = "0xB8C094", VA = "0xB8C094")]
			set
			{
			}
		}

		[Token(Token = "0x1700023B")]
		public CGYesNoAuto AddTangents
		{
			[Token(Token = "0x6000982")]
			[Address(RVA = "0xB8C0B0", Offset = "0xB8C0B0", VA = "0xB8C0B0")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x6000983")]
			[Address(RVA = "0xB8C0B8", Offset = "0xB8C0B8", VA = "0xB8C0B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700023C")]
		public bool AddUV2
		{
			[Token(Token = "0x6000984")]
			[Address(RVA = "0xB8C0D4", Offset = "0xB8C0D4", VA = "0xB8C0D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000985")]
			[Address(RVA = "0xB8C0DC", Offset = "0xB8C0DC", VA = "0xB8C0DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700023D")]
		public int Layer
		{
			[Token(Token = "0x6000986")]
			[Address(RVA = "0xB8C104", Offset = "0xB8C104", VA = "0xB8C104")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000987")]
			[Address(RVA = "0xB8C10C", Offset = "0xB8C10C", VA = "0xB8C10C")]
			set
			{
			}
		}

		[Token(Token = "0x1700023E")]
		public string Tag
		{
			[Token(Token = "0x6000988")]
			[Address(RVA = "0xB8C158", Offset = "0xB8C158", VA = "0xB8C158")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000989")]
			[Address(RVA = "0xB8C160", Offset = "0xB8C160", VA = "0xB8C160")]
			set
			{
			}
		}

		[Token(Token = "0x1700023F")]
		public bool MakeStatic
		{
			[Token(Token = "0x600098A")]
			[Address(RVA = "0xB8C1B8", Offset = "0xB8C1B8", VA = "0xB8C1B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600098B")]
			[Address(RVA = "0xB8C1C0", Offset = "0xB8C1C0", VA = "0xB8C1C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000240")]
		public bool RendererEnabled
		{
			[Token(Token = "0x600098C")]
			[Address(RVA = "0xB8C1E8", Offset = "0xB8C1E8", VA = "0xB8C1E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600098D")]
			[Address(RVA = "0xB8C1F0", Offset = "0xB8C1F0", VA = "0xB8C1F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000241")]
		public ShadowCastingMode CastShadows
		{
			[Token(Token = "0x600098E")]
			[Address(RVA = "0xB8C218", Offset = "0xB8C218", VA = "0xB8C218")]
			get
			{
				return default(ShadowCastingMode);
			}
			[Token(Token = "0x600098F")]
			[Address(RVA = "0xB8C220", Offset = "0xB8C220", VA = "0xB8C220")]
			set
			{
			}
		}

		[Token(Token = "0x17000242")]
		public bool ReceiveShadows
		{
			[Token(Token = "0x6000990")]
			[Address(RVA = "0xB8C23C", Offset = "0xB8C23C", VA = "0xB8C23C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000991")]
			[Address(RVA = "0xB8C244", Offset = "0xB8C244", VA = "0xB8C244")]
			set
			{
			}
		}

		[Token(Token = "0x17000243")]
		public bool UseLightProbes
		{
			[Token(Token = "0x6000992")]
			[Address(RVA = "0xB8C26C", Offset = "0xB8C26C", VA = "0xB8C26C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000993")]
			[Address(RVA = "0xB8C274", Offset = "0xB8C274", VA = "0xB8C274")]
			set
			{
			}
		}

		[Token(Token = "0x17000244")]
		public LightProbeUsage LightProbeUsage
		{
			[Token(Token = "0x6000994")]
			[Address(RVA = "0xB8C29C", Offset = "0xB8C29C", VA = "0xB8C29C")]
			get
			{
				return default(LightProbeUsage);
			}
			[Token(Token = "0x6000995")]
			[Address(RVA = "0xB8C2A4", Offset = "0xB8C2A4", VA = "0xB8C2A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000245")]
		public ReflectionProbeUsage ReflectionProbes
		{
			[Token(Token = "0x6000996")]
			[Address(RVA = "0xB8C2C0", Offset = "0xB8C2C0", VA = "0xB8C2C0")]
			get
			{
				return default(ReflectionProbeUsage);
			}
			[Token(Token = "0x6000997")]
			[Address(RVA = "0xB8C2C8", Offset = "0xB8C2C8", VA = "0xB8C2C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000246")]
		public Transform AnchorOverride
		{
			[Token(Token = "0x6000998")]
			[Address(RVA = "0xB8C2E4", Offset = "0xB8C2E4", VA = "0xB8C2E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000999")]
			[Address(RVA = "0xB8C2EC", Offset = "0xB8C2EC", VA = "0xB8C2EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000247")]
		public CGColliderEnum Collider
		{
			[Token(Token = "0x600099A")]
			[Address(RVA = "0xB8C38C", Offset = "0xB8C38C", VA = "0xB8C38C")]
			get
			{
				return default(CGColliderEnum);
			}
			[Token(Token = "0x600099B")]
			[Address(RVA = "0xB8C394", Offset = "0xB8C394", VA = "0xB8C394")]
			set
			{
			}
		}

		[Token(Token = "0x17000248")]
		public bool AutoUpdateColliders
		{
			[Token(Token = "0x600099C")]
			[Address(RVA = "0xB8C3B0", Offset = "0xB8C3B0", VA = "0xB8C3B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600099D")]
			[Address(RVA = "0xB8C3B8", Offset = "0xB8C3B8", VA = "0xB8C3B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000249")]
		public bool Convex
		{
			[Token(Token = "0x600099E")]
			[Address(RVA = "0xB8C3E0", Offset = "0xB8C3E0", VA = "0xB8C3E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600099F")]
			[Address(RVA = "0xB8C3E8", Offset = "0xB8C3E8", VA = "0xB8C3E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700024A")]
		public bool IsTrigger
		{
			[Token(Token = "0x60009A0")]
			[Address(RVA = "0xB8C410", Offset = "0xB8C410", VA = "0xB8C410")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009A1")]
			[Address(RVA = "0xB8C418", Offset = "0xB8C418", VA = "0xB8C418")]
			set
			{
			}
		}

		[Token(Token = "0x1700024B")]
		public MeshColliderCookingOptions CookingOptions
		{
			[Token(Token = "0x60009A2")]
			[Address(RVA = "0xB8C440", Offset = "0xB8C440", VA = "0xB8C440")]
			get
			{
				return default(MeshColliderCookingOptions);
			}
			[Token(Token = "0x60009A3")]
			[Address(RVA = "0xB8C448", Offset = "0xB8C448", VA = "0xB8C448")]
			set
			{
			}
		}

		[Token(Token = "0x1700024C")]
		public PhysicMaterial Material
		{
			[Token(Token = "0x60009A4")]
			[Address(RVA = "0xB8C464", Offset = "0xB8C464", VA = "0xB8C464")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009A5")]
			[Address(RVA = "0xB8C46C", Offset = "0xB8C46C", VA = "0xB8C46C")]
			set
			{
			}
		}

		[Token(Token = "0x1700024D")]
		public CGMeshResourceCollection Meshes
		{
			[Token(Token = "0x60009A6")]
			[Address(RVA = "0xB8C508", Offset = "0xB8C508", VA = "0xB8C508")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700024E")]
		public int MeshCount
		{
			[Token(Token = "0x60009A7")]
			[Address(RVA = "0xB8C510", Offset = "0xB8C510", VA = "0xB8C510")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700024F")]
		public int VertexCount
		{
			[Token(Token = "0x60009A8")]
			[Address(RVA = "0xB8C52C", Offset = "0xB8C52C", VA = "0xB8C52C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E5A4", Offset = "0x50E5A4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009A9")]
			[Address(RVA = "0xB8C534", Offset = "0xB8C534", VA = "0xB8C534")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50E5B4", Offset = "0x50E5B4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000250")]
		private bool canGroupMeshes
		{
			[Token(Token = "0x60009AA")]
			[Address(RVA = "0xB8C53C", Offset = "0xB8C53C", VA = "0xB8C53C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000251")]
		private bool canModifyStaticFlag
		{
			[Token(Token = "0x60009AB")]
			[Address(RVA = "0xB8C580", Offset = "0xB8C580", VA = "0xB8C580")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000252")]
		private bool canUpdate
		{
			[Token(Token = "0x60009AC")]
			[Address(RVA = "0xB8C588", Offset = "0xB8C588", VA = "0xB8C588")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000253")]
		private bool EnableIsTrigger
		{
			[Token(Token = "0x60009AD")]
			[Address(RVA = "0xB8C5C4", Offset = "0xB8C5C4", VA = "0xB8C5C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0xB8C61C", Offset = "0xB8C61C", VA = "0xB8C61C", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0xB8C8F4", Offset = "0xB8C8F4", VA = "0xB8C8F4", Slot = "13")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0xB8C8D8", Offset = "0xB8C8D8", VA = "0xB8C8D8")]
		public void Clear()
		{
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0xB8CA40", Offset = "0xB8CA40", VA = "0xB8CA40", Slot = "12")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0xB8CA94", Offset = "0xB8CA94", VA = "0xB8CA94", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0xB8DEF0", Offset = "0xB8DEF0", VA = "0xB8DEF0")]
		public GameObject SaveToScene([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0xB8DD60", Offset = "0xB8DD60", VA = "0xB8DD60")]
		public void UpdateColliders()
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0xB8E110", Offset = "0xB8E110", VA = "0xB8E110")]
		private static GameObject SaveMeshResourceToScene(UnityEngine.Component managedResource, Transform newParent)
		{
			return null;
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0xB8D92C", Offset = "0xB8D92C", VA = "0xB8D92C")]
		private void createMeshes(ref List<CGVMesh> vMeshes, bool combine)
		{
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0xB8CF80", Offset = "0xB8CF80", VA = "0xB8CF80")]
		private void createSpotMeshes(ref List<CGVMesh> vMeshes, CGSpot[] spots, bool combine)
		{
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0xB8E280", Offset = "0xB8E280", VA = "0xB8E280")]
		private CGMeshResource writeVMeshToMesh(ref CGVMesh vmesh)
		{
			return null;
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0xB8C910", Offset = "0xB8C910", VA = "0xB8C910")]
		private void removeUnusedResource()
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0xB8E4BC", Offset = "0xB8E4BC", VA = "0xB8E4BC")]
		private CGMeshResource getNewMesh()
		{
			return null;
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0xB8E7D0", Offset = "0xB8E7D0", VA = "0xB8E7D0")]
		public CreateMesh()
		{
		}
	}
	[Token(Token = "0x200012F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x500C04", Offset = "0x500C04")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x500C04", Offset = "0x500C04")]
	public class CreatePathLineRenderer : CGModule
	{
		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x50C138", Offset = "0x50C138")]
		[HideInInspector]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private LineRenderer mLineRenderer;

		[Token(Token = "0x17000254")]
		public LineRenderer LineRenderer
		{
			[Token(Token = "0x60009C1")]
			[Address(RVA = "0xB8E908", Offset = "0xB8E908", VA = "0xB8E908")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0xB8E9BC", Offset = "0xB8E9BC", VA = "0xB8E9BC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0xB8EAF4", Offset = "0xB8EAF4", VA = "0xB8EAF4", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0xB8E9E4", Offset = "0xB8E9E4", VA = "0xB8E9E4")]
		private void createLR()
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0xB8EC54", Offset = "0xB8EC54", VA = "0xB8EC54")]
		public CreatePathLineRenderer()
		{
		}
	}
	[Token(Token = "0x2000130")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x500C9C", Offset = "0x500C9C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x500C9C", Offset = "0x500C9C")]
	public class DebugRasterizedPath : CGModule
	{
		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x50C204", Offset = "0x50C204")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x50C2C8", Offset = "0x50C2C8")]
		public bool ShowNormals;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x50C300", Offset = "0x50C300")]
		public bool ShowOrientation;

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0xEBB130", Offset = "0xEBB130", VA = "0xEBB130", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0xEBB15C", Offset = "0xEBB15C", VA = "0xEBB15C")]
		public DebugRasterizedPath()
		{
		}
	}
	[Token(Token = "0x2000131")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x500D34", Offset = "0x500D34")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x500D34", Offset = "0x500D34")]
	public class DebugVMesh : CGModule
	{
		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x50C338", Offset = "0x50C338")]
		public CGModuleInputSlot InData;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x50C3FC", Offset = "0x50C3FC")]
		public bool ShowVertices;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool ShowVertexID;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
		public bool ShowUV;

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0xEBB1D4", Offset = "0xEBB1D4", VA = "0xEBB1D4", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0xEBB200", Offset = "0xEBB200", VA = "0xEBB200")]
		public DebugVMesh()
		{
		}
	}
	[Token(Token = "0x2000132")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x500DB0", Offset = "0x500DB0")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x500DB0", Offset = "0x500DB0")]
	public class DebugVolume : CGModule
	{
		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x50C434", Offset = "0x50C434")]
		public CGModuleInputSlot InData;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x50C4F8", Offset = "0x50C4F8")]
		public bool ShowPathSamples;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool ShowCrossSamples;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50C530", Offset = "0x50C530")]
		[IntRegion]
		public IntRegion LimitCross;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool ShowNormals;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		public bool ShowIndex;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC2")]
		public bool ShowMap;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Color PathColor;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public Color VolumeColor;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public Color NormalColor;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x50C5F0", Offset = "0x50C5F0")]
		public bool Interpolate;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x50C628", Offset = "0x50C628")]
		public float InterpolatePathF;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x50C67C", Offset = "0x50C67C")]
		public float InterpolateCrossF;

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0xEBB270", Offset = "0xEBB270", VA = "0xEBB270")]
		public DebugVolume()
		{
		}
	}
	[Token(Token = "0x2000133")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x500E2C", Offset = "0x500E2C")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x500E2C", Offset = "0x500E2C")]
	public class InputGameObject : CGModule
	{
		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x50C6D0", Offset = "0x50C6D0")]
		public CGModuleOutputSlot OutGameObject;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[ArrayEx]
		[SerializeField]
		private List<CGGameObjectProperties> m_GameObjects;

		[Token(Token = "0x17000255")]
		public List<CGGameObjectProperties> GameObjects
		{
			[Token(Token = "0x60009CB")]
			[Address(RVA = "0xEBD238", Offset = "0xEBD238", VA = "0xEBD238")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000256")]
		public bool SupportsIPE
		{
			[Token(Token = "0x60009CC")]
			[Address(RVA = "0xEBD240", Offset = "0xEBD240", VA = "0xEBD240")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0xEBD248", Offset = "0xEBD248", VA = "0xEBD248", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0xEBD2B8", Offset = "0xEBD2B8", VA = "0xEBD2B8", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0xEBD49C", Offset = "0xEBD49C", VA = "0xEBD49C", Slot = "13")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0xEBD4FC", Offset = "0xEBD4FC", VA = "0xEBD4FC")]
		public InputGameObject()
		{
		}
	}
	[Token(Token = "0x2000134")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x500EC4", Offset = "0x500EC4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x500EC4", Offset = "0x500EC4")]
	public class InputMesh : CGModule, IExternalInput
	{
		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x50C784", Offset = "0x50C784")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[ArrayEx]
		private List<CGMeshProperties> m_Meshes;

		[Token(Token = "0x17000257")]
		public List<CGMeshProperties> Meshes
		{
			[Token(Token = "0x60009D1")]
			[Address(RVA = "0xEBD5B8", Offset = "0xEBD5B8", VA = "0xEBD5B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000258")]
		public bool SupportsIPE
		{
			[Token(Token = "0x60009D2")]
			[Address(RVA = "0xEBD5C0", Offset = "0xEBD5C0", VA = "0xEBD5C0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0xEBD5C8", Offset = "0xEBD5C8", VA = "0xEBD5C8", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0xEBD638", Offset = "0xEBD638", VA = "0xEBD638", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0xEBD860", Offset = "0xEBD860", VA = "0xEBD860", Slot = "13")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0xEBD8C0", Offset = "0xEBD8C0", VA = "0xEBD8C0")]
		public InputMesh()
		{
		}
	}
	[Token(Token = "0x2000135")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x500F5C", Offset = "0x500F5C")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x500F5C", Offset = "0x500F5C")]
	public class InputSplinePath : SplineInputModuleBase, IExternalInput, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x50C838", Offset = "0x50C838")]
		public CGModuleOutputSlot Path;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CGResourceManagerAttribute", RVA = "0x50C8A8", Offset = "0x50C8A8")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x50C8A8", Offset = "0x50C8A8")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x50C8A8", Offset = "0x50C8A8")]
		[SerializeField]
		private CurvySpline m_Spline;

		[Token(Token = "0x17000259")]
		public CurvySpline Spline
		{
			[Token(Token = "0x60009D7")]
			[Address(RVA = "0xBF3D1C", Offset = "0xBF3D1C", VA = "0xBF3D1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0xBF3D24", Offset = "0xBF3D24", VA = "0xBF3D24")]
			set
			{
			}
		}

		[Token(Token = "0x1700025A")]
		public bool SupportsIPE
		{
			[Token(Token = "0x60009D9")]
			[Address(RVA = "0xBF40A0", Offset = "0xBF40A0", VA = "0xBF40A0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700025B")]
		protected override CurvySpline InputSpline
		{
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0xBF5A14", Offset = "0xBF5A14", VA = "0xBF5A14", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0xBF5A1C", Offset = "0xBF5A1C", VA = "0xBF5A1C", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0xBF40A8", Offset = "0xBF40A8", VA = "0xBF40A8", Slot = "19")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0xBF5970", Offset = "0xBF5970", VA = "0xBF5970", Slot = "13")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0xBF5A20", Offset = "0xBF5A20", VA = "0xBF5A20")]
		public InputSplinePath()
		{
		}
	}
	[Token(Token = "0x2000136")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x500FF4", Offset = "0x500FF4")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x500FF4", Offset = "0x500FF4")]
	public class InputSplineShape : SplineInputModuleBase, IExternalInput, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x50C96C", Offset = "0x50C96C")]
		[HideInInspector]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x50C9DC", Offset = "0x50C9DC")]
		[AttributeAttribute(Name = "CGResourceManagerAttribute", RVA = "0x50C9DC", Offset = "0x50C9DC")]
		private CurvySpline m_Shape;

		[Token(Token = "0x1700025C")]
		public CurvySpline Shape
		{
			[Token(Token = "0x60009DF")]
			[Address(RVA = "0xBF5A98", Offset = "0xBF5A98", VA = "0xBF5A98")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009E0")]
			[Address(RVA = "0xBF5AA0", Offset = "0xBF5AA0", VA = "0xBF5AA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700025D")]
		public bool SupportsIPE
		{
			[Token(Token = "0x60009E1")]
			[Address(RVA = "0xBF5B5C", Offset = "0xBF5B5C", VA = "0xBF5B5C", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700025E")]
		public bool FreeForm
		{
			[Token(Token = "0x60009E2")]
			[Address(RVA = "0xBF5B60", Offset = "0xBF5B60", VA = "0xBF5B60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009E3")]
			[Address(RVA = "0xBF5C44", Offset = "0xBF5C44", VA = "0xBF5C44")]
			set
			{
			}
		}

		[Token(Token = "0x1700025F")]
		protected override CurvySpline InputSpline
		{
			[Token(Token = "0x60009E7")]
			[Address(RVA = "0xBF5FB0", Offset = "0xBF5FB0", VA = "0xBF5FB0", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009E8")]
			[Address(RVA = "0xBF5FB8", Offset = "0xBF5FB8", VA = "0xBF5FB8", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0xBF5DA4", Offset = "0xBF5DA4", VA = "0xBF5DA4", Slot = "19")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x60009E5")]
		public T SetManagedShape<T>() where T : CurvyShape2D
		{
			return null;
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0xBF5EF4", Offset = "0xBF5EF4", VA = "0xBF5EF4")]
		public void RemoveManagedShape()
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0xBF5FBC", Offset = "0xBF5FBC", VA = "0xBF5FBC", Slot = "17")]
		protected override void OnSplineAssigned()
		{
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0xBF6254", Offset = "0xBF6254", VA = "0xBF6254")]
		public InputSplineShape()
		{
		}
	}
	[Token(Token = "0x2000137")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x50108C", Offset = "0x50108C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x50108C", Offset = "0x50108C")]
	public class InputSpots : CGModule
	{
		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x50CA50", Offset = "0x50CA50")]
		[HideInInspector]
		public CGModuleOutputSlot OutSpots;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[ArrayEx]
		private List<CGSpot> m_Spots;

		[Token(Token = "0x17000260")]
		public List<CGSpot> Spots
		{
			[Token(Token = "0x60009EB")]
			[Address(RVA = "0xBF62C4", Offset = "0xBF62C4", VA = "0xBF62C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009EC")]
			[Address(RVA = "0xBF62CC", Offset = "0xBF62CC", VA = "0xBF62CC")]
			set
			{
			}
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0xBF6308", Offset = "0xBF6308", VA = "0xBF6308", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0xBF6340", Offset = "0xBF6340", VA = "0xBF6340", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0xBF63B0", Offset = "0xBF63B0", VA = "0xBF63B0", Slot = "12")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0xBF63B8", Offset = "0xBF63B8", VA = "0xBF63B8", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0xBF64F8", Offset = "0xBF64F8", VA = "0xBF64F8")]
		public InputSpots()
		{
		}
	}
	[Token(Token = "0x2000138")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x501124", Offset = "0x501124")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x501124", Offset = "0x501124")]
	public class ModifierMixPaths : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x50CAF8", Offset = "0x50CAF8")]
		public CGModuleInputSlot InPathA;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x50CBBC", Offset = "0x50CBBC")]
		public CGModuleInputSlot InPathB;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x50CC80", Offset = "0x50CC80")]
		[HideInInspector]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x50CCF0", Offset = "0x50CCF0")]
		[SerializeField]
		private float m_Mix;

		[Token(Token = "0x17000261")]
		public float Mix
		{
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0xBF8CBC", Offset = "0xBF8CBC", VA = "0xBF8CBC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009F3")]
			[Address(RVA = "0xBF8CC4", Offset = "0xBF8CC4", VA = "0xBF8CC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000262")]
		public bool PathIsClosed
		{
			[Token(Token = "0x60009F4")]
			[Address(RVA = "0xBF8CE0", Offset = "0xBF8CE0", VA = "0xBF8CE0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0xBF8E68", Offset = "0xBF8E68", VA = "0xBF8E68", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0xBF8EB0", Offset = "0xBF8EB0", VA = "0xBF8EB0", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0xBF8EF0", Offset = "0xBF8EF0", VA = "0xBF8EF0", Slot = "14")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0xBF9040", Offset = "0xBF9040", VA = "0xBF9040")]
		public static CGPath MixPath(CGPath pathA, CGPath pathB, float mix, [NotNull] List<string> warningsContainer)
		{
			return null;
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0xBF9C18", Offset = "0xBF9C18", VA = "0xBF9C18")]
		public ModifierMixPaths()
		{
		}
	}
	[Token(Token = "0x2000139")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x5011BC", Offset = "0x5011BC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5011BC", Offset = "0x5011BC")]
	public class ModifierMixShapes : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Serializable]
		[Token(Token = "0x200013A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x501254", Offset = "0x501254")]
		private sealed class <>c
		{
			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<SamplePointsMaterialGroup, SamplePointsMaterialGroup> <>9__13_0;

			[Token(Token = "0x6000A04")]
			[Address(RVA = "0xE7EFC4", Offset = "0xE7EFC4", VA = "0xE7EFC4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000A05")]
			[Address(RVA = "0xE7EFCC", Offset = "0xE7EFCC", VA = "0xE7EFCC")]
			internal SamplePointsMaterialGroup <InterpolateShape>b__13_0(SamplePointsMaterialGroup g)
			{
				return null;
			}
		}

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x50CD7C", Offset = "0x50CD7C")]
		public CGModuleInputSlot InShapeA;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x50CE40", Offset = "0x50CE40")]
		public CGModuleInputSlot InShapeB;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x50CF04", Offset = "0x50CF04")]
		[HideInInspector]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x50CF74", Offset = "0x50CF74")]
		private float m_Mix;

		[Token(Token = "0x17000263")]
		public float Mix
		{
			[Token(Token = "0x60009FA")]
			[Address(RVA = "0xBF9CEC", Offset = "0xBF9CEC", VA = "0xBF9CEC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009FB")]
			[Address(RVA = "0xBF9CF4", Offset = "0xBF9CF4", VA = "0xBF9CF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000264")]
		public bool PathIsClosed
		{
			[Token(Token = "0x60009FC")]
			[Address(RVA = "0xBF9D10", Offset = "0xBF9D10", VA = "0xBF9D10", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0xBF9E98", Offset = "0xBF9E98", VA = "0xBF9E98", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0xBF9EE0", Offset = "0xBF9EE0", VA = "0xBF9EE0", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0xBF9F20", Offset = "0xBF9F20", VA = "0xBF9F20", Slot = "14")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0xBFA068", Offset = "0xBFA068", VA = "0xBFA068")]
		public static CGShape MixShapes(CGShape shapeA, CGShape shapeB, float mix, [NotNull] List<string> warningsContainer, bool ignoreWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0xBF93BC", Offset = "0xBF93BC", VA = "0xBF93BC")]
		public static void InterpolateShape([NotNull] CGShape resultShape, CGShape shapeA, CGShape shapeB, float mix, [NotNull] List<string> warningsContainer, bool ignoreWarnings = false)
		{
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0xBFA11C", Offset = "0xBFA11C", VA = "0xBFA11C")]
		public ModifierMixShapes()
		{
		}
	}
	[Token(Token = "0x200013B")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x501264", Offset = "0x501264")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x501264", Offset = "0x501264")]
	public class ModifierPathRelativeTranslation : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x50D000", Offset = "0x50D000")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x50D0D8", Offset = "0x50D0D8")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x50D148", Offset = "0x50D148")]
		private float lateralTranslation;

		[Token(Token = "0x17000265")]
		public float LateralTranslation
		{
			[Token(Token = "0x6000A06")]
			[Address(RVA = "0xBFA1F0", Offset = "0xBFA1F0", VA = "0xBFA1F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0xBFA1F8", Offset = "0xBFA1F8", VA = "0xBFA1F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000266")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A08")]
			[Address(RVA = "0xBFA218", Offset = "0xBFA218", VA = "0xBFA218", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0xBFA308", Offset = "0xBFA308", VA = "0xBFA308", Slot = "14")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0xBFA524", Offset = "0xBFA524", VA = "0xBFA524", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0xBFA56C", Offset = "0xBFA56C", VA = "0xBFA56C", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0xBFA5B8", Offset = "0xBFA5B8", VA = "0xBFA5B8")]
		public ModifierPathRelativeTranslation()
		{
		}
	}
	[Token(Token = "0x200013C")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x5012FC", Offset = "0x5012FC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5012FC", Offset = "0x5012FC")]
	public class ModifierTRSMesh : TRSModuleBase
	{
		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x50D194", Offset = "0x50D194")]
		public CGModuleInputSlot InVMesh;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x50D254", Offset = "0x50D254")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0xBFA660", Offset = "0xBFA660", VA = "0xBFA660", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0xBFA864", Offset = "0xBFA864", VA = "0xBFA864")]
		public ModifierTRSMesh()
		{
		}
	}
	[Token(Token = "0x200013D")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x501394", Offset = "0x501394")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x501394", Offset = "0x501394")]
	public class ModifierTRSPath : TRSModuleBase, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x50D2D0", Offset = "0x50D2D0")]
		[HideInInspector]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x50D3A4", Offset = "0x50D3A4")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x17000267")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0xBFA90C", Offset = "0xBFA90C", VA = "0xBFA90C", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0xBFA9FC", Offset = "0xBFA9FC", VA = "0xBFA9FC", Slot = "14")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0xBFACA4", Offset = "0xBFACA4", VA = "0xBFACA4")]
		public ModifierTRSPath()
		{
		}
	}
	[Token(Token = "0x200013E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x50142C", Offset = "0x50142C")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x50142C", Offset = "0x50142C")]
	public class ModifierTRSShape : TRSModuleBase, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x50D414", Offset = "0x50D414")]
		[HideInInspector]
		public CGModuleInputSlot InShape;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x50D4E8", Offset = "0x50D4E8")]
		[HideInInspector]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x17000268")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A12")]
			[Address(RVA = "0xBFAD4C", Offset = "0xBFAD4C", VA = "0xBFAD4C", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0xBFAE3C", Offset = "0xBFAE3C", VA = "0xBFAE3C", Slot = "14")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0xBFB0E4", Offset = "0xBFB0E4", VA = "0xBFB0E4")]
		public ModifierTRSShape()
		{
		}
	}
	[Token(Token = "0x200013F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5014C4", Offset = "0x5014C4")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x5014C4", Offset = "0x5014C4")]
	public class ModifierVariableMixShapes : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x50D558", Offset = "0x50D558")]
		public CGModuleInputSlot InShapeA;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x50D61C", Offset = "0x50D61C")]
		[HideInInspector]
		public CGModuleInputSlot InShapeB;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "ShapeOutputSlotInfo", RVA = "0x50D6E8", Offset = "0x50D6E8")]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x50D73C", Offset = "0x50D73C")]
		private AnimationCurve m_MixCurve;

		[Token(Token = "0x17000269")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A15")]
			[Address(RVA = "0xBFB18C", Offset = "0xBFB18C", VA = "0xBFB18C", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700026A")]
		public AnimationCurve MixCurve
		{
			[Token(Token = "0x6000A16")]
			[Address(RVA = "0xBFB314", Offset = "0xBFB314", VA = "0xBFB314")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A17")]
			[Address(RVA = "0xBFB31C", Offset = "0xBFB31C", VA = "0xBFB31C")]
			set
			{
			}
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0xBFB34C", Offset = "0xBFB34C", VA = "0xBFB34C", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0xBFB394", Offset = "0xBFB394", VA = "0xBFB394", Slot = "14")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0xBFB574", Offset = "0xBFB574", VA = "0xBFB574")]
		public ModifierVariableMixShapes()
		{
		}
	}
	[Token(Token = "0x2000140")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x50155C", Offset = "0x50155C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x50155C", Offset = "0x50155C")]
	public class Note : CGModule, INoProcessing
	{
		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x50D79C", Offset = "0x50D79C")]
		private string m_Note;

		[Token(Token = "0x1700026B")]
		public string NoteText
		{
			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0xBFB8A0", Offset = "0xBFB8A0", VA = "0xBFB8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0xBFB8A8", Offset = "0xBFB8A8", VA = "0xBFB8A8")]
			set
			{
			}
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0xBFB8F0", Offset = "0xBFB8F0", VA = "0xBFB8F0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0xBFB938", Offset = "0xBFB938", VA = "0xBFB938", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0xBFB968", Offset = "0xBFB968", VA = "0xBFB968")]
		public Note()
		{
		}
	}
}
namespace Beebyte.Obfuscator
{
	[Token(Token = "0x2000141")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x5015FC", Offset = "0x5015FC")]
	public class DoNotFakeAttribute : Attribute
	{
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0xEBB350", Offset = "0xEBB350", VA = "0xEBB350")]
		public DoNotFakeAttribute()
		{
		}
	}
	[Token(Token = "0x2000142")]
	public enum MessageCode
	{
		[Token(Token = "0x40004CB")]
		UnityReflectionMethodNotFound
	}
	[Token(Token = "0x2000143")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x501610", Offset = "0x501610")]
	public class ObfuscateLiteralsAttribute : Attribute
	{
		[Token(Token = "0x6000A21")]
		[Address(RVA = "0xBFB970", Offset = "0xBFB970", VA = "0xBFB970")]
		public ObfuscateLiteralsAttribute()
		{
		}
	}
	[Token(Token = "0x2000144")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x501624", Offset = "0x501624")]
	public class RenameAttribute : Attribute
	{
		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string target;

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0xBFEF9C", Offset = "0xBFEF9C", VA = "0xBFEF9C")]
		private RenameAttribute()
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0xBFEFA4", Offset = "0xBFEFA4", VA = "0xBFEFA4")]
		public RenameAttribute(string target)
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0xBFEFD8", Offset = "0xBFEFD8", VA = "0xBFEFD8")]
		public string GetTarget()
		{
			return null;
		}
	}
	[Token(Token = "0x2000145")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x501638", Offset = "0x501638")]
	public class ReplaceLiteralsWithNameAttribute : Attribute
	{
		[Token(Token = "0x6000A25")]
		[Address(RVA = "0xBFEFE0", Offset = "0xBFEFE0", VA = "0xBFEFE0")]
		public ReplaceLiteralsWithNameAttribute()
		{
		}
	}
	[Token(Token = "0x2000146")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x50164C", Offset = "0x50164C")]
	public class SkipAttribute : Attribute
	{
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0xC00900", Offset = "0xC00900", VA = "0xC00900")]
		public SkipAttribute()
		{
		}
	}
	[Token(Token = "0x2000147")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x501660", Offset = "0x501660")]
	public class SkipRenameAttribute : Attribute
	{
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0xC00908", Offset = "0xC00908", VA = "0xC00908")]
		public SkipRenameAttribute()
		{
		}
	}
	[Token(Token = "0x2000148")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x501674", Offset = "0x501674")]
	public class SuppressLogAttribute : Attribute
	{
		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly MessageCode _messageCode;

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0xE7449C", Offset = "0xE7449C", VA = "0xE7449C")]
		private SuppressLogAttribute()
		{
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0xE744A4", Offset = "0xE744A4", VA = "0xE744A4")]
		public SuppressLogAttribute(MessageCode messageCode)
		{
		}
	}
}
