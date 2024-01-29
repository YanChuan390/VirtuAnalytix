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
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D79C0", Offset = "0x6D79C0")]
internal sealed class <>f__AnonymousType0<<A>j__TPar, <B>j__TPar, <C>j__TPar, <D>j__TPar>
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x6D9EB4", Offset = "0x6D9EB4")]
	private readonly <A>j__TPar <A>i__Field;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x6D9EC8", Offset = "0x6D9EC8")]
	private readonly <B>j__TPar <B>i__Field;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x6D9EDC", Offset = "0x6D9EDC")]
	private readonly <C>j__TPar <C>i__Field;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x6D9EF0", Offset = "0x6D9EF0")]
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
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D79D0", Offset = "0x6D79D0")]
internal sealed class <>f__AnonymousType1<<A>j__TPar, <B>j__TPar, <C>j__TPar, <D>j__TPar, <E>j__TPar>
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x6D9F04", Offset = "0x6D9F04")]
	private readonly <A>j__TPar <A>i__Field;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x6D9F18", Offset = "0x6D9F18")]
	private readonly <B>j__TPar <B>i__Field;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x6D9F2C", Offset = "0x6D9F2C")]
	private readonly <C>j__TPar <C>i__Field;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x6D9F40", Offset = "0x6D9F40")]
	private readonly <D>j__TPar <D>i__Field;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x6D9F54", Offset = "0x6D9F54")]
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
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6D79E0", Offset = "0x6D79E0")]
	public class DTVersionAttribute : Attribute
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Version;

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1218A10", Offset = "0x1218A10", VA = "0x1218A10")]
		public DTVersionAttribute(string version)
		{
		}
	}
	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6D7A14", Offset = "0x6D7A14")]
	public class DTAttribute : Attribute, IComparable
	{
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9F68", Offset = "0x6D9F68")]
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
			[Address(RVA = "0x121454C", Offset = "0x121454C", VA = "0x121454C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5088", Offset = "0x6E5088")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x1214554", Offset = "0x1214554", VA = "0x1214554")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5098", Offset = "0x6E5098")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x121455C", Offset = "0x121455C", VA = "0x121455C", Slot = "8")]
		public virtual int CompareTo(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x121462C", Offset = "0x121462C", VA = "0x121462C")]
		public DTAttribute(int sortOrder, bool showBelow = false)
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class GroupAttribute : DTAttribute, IDTGroupParsingAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9F78", Offset = "0x6D9F78")]
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
			[Address(RVA = "0x121AA00", Offset = "0x121AA00", VA = "0x121AA00", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x121AA08", Offset = "0x121AA08", VA = "0x121AA08")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public bool PathIsAbsolute
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x121AAFC", Offset = "0x121AAFC", VA = "0x121AAFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E50A8", Offset = "0x6E50A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x121AB04", Offset = "0x121AB04", VA = "0x121AB04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E50B8", Offset = "0x6E50B8")]
			private set
			{
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x121AB10", Offset = "0x121AB10", VA = "0x121AB10")]
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
		[Address(RVA = "0xF63BF4", Offset = "0xF63BF4", VA = "0xF63BF4")]
		protected ActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xF63C50", Offset = "0xF63C50", VA = "0xF63C50")]
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
			[Address(RVA = "0x11F9384", Offset = "0x11F9384", VA = "0x11F9384")]
			public Condition()
			{
			}
		}

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Condition[] Conditions;

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xEC4274", Offset = "0xEC4274", VA = "0xEC4274")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xEC43B4", Offset = "0xEC43B4", VA = "0xEC43B4")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xEC4594", Offset = "0xEC4594", VA = "0xEC4594")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xEC4808", Offset = "0xEC4808", VA = "0xEC4808")]
		protected ConditionalAttribute(string methodToQuery)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xEC492C", Offset = "0xEC492C", VA = "0xEC492C", Slot = "9")]
		public virtual bool ConditionMet(object classInstance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xEC49F8", Offset = "0xEC49F8", VA = "0xEC49F8")]
		private bool evaluate(Condition cond, object classInstance)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000011")]
	public class SortOrderAttribute : DTAttribute, IDTFieldParsingAttribute
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0xF48FA8", Offset = "0xF48FA8", VA = "0xF48FA8")]
		public SortOrderAttribute(int sort = 100)
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class AsGroupAttribute : GroupAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x6000027")]
		[Address(RVA = "0xF63EC4", Offset = "0xF63EC4", VA = "0xF63EC4")]
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
		[Address(RVA = "0x11EF968", Offset = "0x11EF968", VA = "0x11EF968")]
		public TabAttribute(string pathAndName)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x11EF9F8", Offset = "0x11EF9F8", VA = "0x11EF9F8")]
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
		[Address(RVA = "0xF43E20", Offset = "0xF43E20", VA = "0xF43E20")]
		public SectionAttribute(string name, bool expanded = true, bool fix = false, int sort = 100)
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class NoSectionAttribute : SectionAttribute
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0xF43DB4", Offset = "0xF43DB4", VA = "0xF43DB4")]
		public NoSectionAttribute()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class Hide : DTAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x121ABA4", Offset = "0x121ABA4", VA = "0x121ABA4")]
		public Hide()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class Inline : DTAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x121ABDC", Offset = "0x121ABDC", VA = "0x121ABDC")]
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
		[Address(RVA = "0xF63EA4", Offset = "0xF63EA4", VA = "0xF63EA4")]
		public ArrayExAttribute()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class FieldActionAttribute : ActionAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x12192B0", Offset = "0x12192B0", VA = "0x12192B0")]
		public FieldActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class GroupActionAttribute : ActionAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x121A9F8", Offset = "0x121A9F8", VA = "0x121A9F8")]
		public GroupActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class FieldConditionAttribute : ConditionalAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x12192B8", Offset = "0x12192B8", VA = "0x12192B8")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false, ActionEnum action = ActionEnum.Show, [Optional] object actionData, ActionPositionEnum position = ActionPositionEnum.Below)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x121930C", Offset = "0x121930C", VA = "0x121930C")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x121931C", Offset = "0x121931C", VA = "0x121931C")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1219340", Offset = "0x1219340", VA = "0x1219340")]
		public FieldConditionAttribute(string methodToQuery)
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class GroupConditionAttribute : ConditionalAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x121AB5C", Offset = "0x121AB5C", VA = "0x121AB5C")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x121AB68", Offset = "0x121AB68", VA = "0x121AB68")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x121AB78", Offset = "0x121AB78", VA = "0x121AB78")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x121AB9C", Offset = "0x121AB9C", VA = "0x121AB9C")]
		public GroupConditionAttribute(string methodToQuery)
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class Couple<T1, T2>
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9F88", Offset = "0x6D9F88")]
		private T1 <First>k__BackingField;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9F98", Offset = "0x6D9F98")]
		private T2 <Second>k__BackingField;

		[Token(Token = "0x1700000E")]
		public T1 First
		{
			[Token(Token = "0x6000039")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E50C8", Offset = "0x6E50C8")]
			get
			{
				return (T1)null;
			}
			[Token(Token = "0x600003A")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E50D8", Offset = "0x6E50D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public T2 Second
		{
			[Token(Token = "0x600003B")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E50E8", Offset = "0x6E50E8")]
			get
			{
				return (T2)null;
			}
			[Token(Token = "0x600003C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E50F8", Offset = "0x6E50F8")]
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
		[Address(RVA = "0x12166E4", Offset = "0x12166E4", VA = "0x12166E4")]
		public static float Ease(EasingMethod method, float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1217688", Offset = "0x1217688", VA = "0x1217688")]
		public static float Ease(EasingMethod method, float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1217658", Offset = "0x1217658", VA = "0x1217658")]
		public static float Linear(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x12184DC", Offset = "0x12184DC", VA = "0x12184DC")]
		public static float Linear(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1216AB8", Offset = "0x1216AB8", VA = "0x1216AB8")]
		public static float ExpoOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1217BD8", Offset = "0x1217BD8", VA = "0x1217BD8")]
		public static float ExpoOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1216A68", Offset = "0x1216A68", VA = "0x1216A68")]
		public static float ExpoIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1217B8C", Offset = "0x1217B8C", VA = "0x1217B8C")]
		public static float ExpoIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1216B0C", Offset = "0x1216B0C", VA = "0x1216B0C")]
		public static float ExpoInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1217C20", Offset = "0x1217C20", VA = "0x1217C20")]
		public static float ExpoInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1216BA4", Offset = "0x1216BA4", VA = "0x1216BA4")]
		public static float ExpoOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1217CB8", Offset = "0x1217CB8", VA = "0x1217CB8")]
		public static float ExpoOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1216CAC", Offset = "0x1216CAC", VA = "0x1216CAC")]
		public static float CircOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1217DA4", Offset = "0x1217DA4", VA = "0x1217DA4")]
		public static float CircOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1216C54", Offset = "0x1216C54", VA = "0x1216C54")]
		public static float CircIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1217D50", Offset = "0x1217D50", VA = "0x1217D50")]
		public static float CircIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1216D04", Offset = "0x1216D04", VA = "0x1216D04")]
		public static float CircInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1217DF8", Offset = "0x1217DF8", VA = "0x1217DF8")]
		public static float CircInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1216D90", Offset = "0x1216D90", VA = "0x1216D90")]
		public static float CircOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1217E80", Offset = "0x1217E80", VA = "0x1217E80")]
		public static float CircOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1216E88", Offset = "0x1216E88", VA = "0x1216E88")]
		public static float QuadOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1217F40", Offset = "0x1217F40", VA = "0x1217F40")]
		public static float QuadOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1216E54", Offset = "0x1216E54", VA = "0x1216E54")]
		public static float QuadIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1217F2C", Offset = "0x1217F2C", VA = "0x1217F2C")]
		public static float QuadIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1216EC4", Offset = "0x1216EC4", VA = "0x1216EC4")]
		public static float QuadInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1217F5C", Offset = "0x1217F5C", VA = "0x1217F5C")]
		public static float QuadInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1216F50", Offset = "0x1216F50", VA = "0x1216F50")]
		public static float QuadOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1217FE4", Offset = "0x1217FE4", VA = "0x1217FE4")]
		public static float QuadOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1217014", Offset = "0x1217014", VA = "0x1217014")]
		public static float SineOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1218078", Offset = "0x1218078", VA = "0x1218078")]
		public static float SineOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1216FD0", Offset = "0x1216FD0", VA = "0x1216FD0")]
		public static float SineIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1218038", Offset = "0x1218038", VA = "0x1218038")]
		public static float SineIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1217054", Offset = "0x1217054", VA = "0x1217054")]
		public static float SineInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x12180B4", Offset = "0x12180B4", VA = "0x12180B4")]
		public static float SineInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x12170E8", Offset = "0x12170E8", VA = "0x12170E8")]
		public static float SineOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x121813C", Offset = "0x121813C", VA = "0x121813C")]
		public static float SineOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x12171B4", Offset = "0x12171B4", VA = "0x12171B4")]
		public static float CubicOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x12181D4", Offset = "0x12181D4", VA = "0x12181D4")]
		public static float CubicOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x121717C", Offset = "0x121717C", VA = "0x121717C")]
		public static float CubicIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x12181BC", Offset = "0x12181BC", VA = "0x12181BC")]
		public static float CubicIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x12171FC", Offset = "0x12171FC", VA = "0x12171FC")]
		public static float CubicInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x12181FC", Offset = "0x12181FC", VA = "0x12181FC")]
		public static float CubicInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1217274", Offset = "0x1217274", VA = "0x1217274")]
		public static float CubicOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1218250", Offset = "0x1218250", VA = "0x1218250")]
		public static float CubicOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1217344", Offset = "0x1217344", VA = "0x1217344")]
		public static float QuartOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x12182CC", Offset = "0x12182CC", VA = "0x12182CC")]
		public static float QuartOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1217308", Offset = "0x1217308", VA = "0x1217308")]
		public static float QuartIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x12182B0", Offset = "0x12182B0", VA = "0x12182B0")]
		public static float QuartIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x121738C", Offset = "0x121738C", VA = "0x121738C")]
		public static float QuartInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x12182F4", Offset = "0x12182F4", VA = "0x12182F4")]
		public static float QuartInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1217408", Offset = "0x1217408", VA = "0x1217408")]
		public static float QuartOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1218350", Offset = "0x1218350", VA = "0x1218350")]
		public static float QuartOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x12174DC", Offset = "0x12174DC", VA = "0x12174DC")]
		public static float QuintOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x12183D8", Offset = "0x12183D8", VA = "0x12183D8")]
		public static float QuintOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x121749C", Offset = "0x121749C", VA = "0x121749C")]
		public static float QuintIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x12183B8", Offset = "0x12183B8", VA = "0x12183B8")]
		public static float QuintIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x121752C", Offset = "0x121752C", VA = "0x121752C")]
		public static float QuintInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1218408", Offset = "0x1218408", VA = "0x1218408")]
		public static float QuintInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x12175B4", Offset = "0x12175B4", VA = "0x12175B4")]
		public static float QuintOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x121846C", Offset = "0x121846C", VA = "0x121846C")]
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
		[Address(RVA = "0x1215738", Offset = "0x1215738", VA = "0x1215738")]
		public DTObjectDump(object o, int indent = 0)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x12164C8", Offset = "0x12164C8", VA = "0x12164C8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1215918", Offset = "0x1215918", VA = "0x1215918")]
		private void AppendHeader(string name)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x12159A8", Offset = "0x12159A8", VA = "0x12159A8")]
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
			[Address(RVA = "0x12184F4", Offset = "0x12184F4", VA = "0x12184F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x12184EC", Offset = "0x12184EC", VA = "0x12184EC")]
		public static Material GetDefaultMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x12184FC", Offset = "0x12184FC", VA = "0x12184FC")]
		public static float GetHandleSize(Vector3 position)
		{
			return default(float);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1218668", Offset = "0x1218668", VA = "0x1218668")]
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
		[Address(RVA = "0x12187BC", Offset = "0x12187BC", VA = "0x12187BC")]
		public static float RandomSign()
		{
			return default(float);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x12187E8", Offset = "0x12187E8", VA = "0x12187E8")]
		public static string GetHelpUrl(object forClass)
		{
			return null;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1218854", Offset = "0x1218854", VA = "0x1218854")]
		public static string GetHelpUrl(Type classType)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1218994", Offset = "0x1218994", VA = "0x1218994")]
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
			[Address(RVA = "0x1216598", Offset = "0x1216598", VA = "0x1216598")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000012")]
		public static float deltaTime
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x12165B4", Offset = "0x12165B4", VA = "0x12165B4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x121661C", Offset = "0x121661C", VA = "0x121661C")]
		public static void InitializeEditorTime()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x121667C", Offset = "0x121667C", VA = "0x121667C")]
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
			[Address(RVA = "0x11F4A94", Offset = "0x11F4A94", VA = "0x11F4A94")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000014")]
		public double LastMS
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x11F4B0C", Offset = "0x11F4B0C", VA = "0x11F4B0C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000015")]
		public double AverageMS
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x11F4B2C", Offset = "0x11F4B2C", VA = "0x11F4B2C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000016")]
		public double MinimumMS
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x11F4C14", Offset = "0x11F4C14", VA = "0x11F4C14")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000017")]
		public double MaximumMS
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x11F4D30", Offset = "0x11F4D30", VA = "0x11F4D30")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000018")]
		public double AverageTicks
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x11F4E4C", Offset = "0x11F4E4C", VA = "0x11F4E4C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000019")]
		public double MinimumTicks
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x11F4F24", Offset = "0x11F4F24", VA = "0x11F4F24")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700001A")]
		public double MaximumTicks
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x11F5030", Offset = "0x11F5030", VA = "0x11F5030")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x11F4944", Offset = "0x11F4944", VA = "0x11F4944")]
		public TimeMeasure(int size)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x11F49D8", Offset = "0x11F49D8", VA = "0x11F49D8")]
		public void Start()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x11F49F4", Offset = "0x11F49F4", VA = "0x11F49F4")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x11F4A78", Offset = "0x11F4A78", VA = "0x11F4A78")]
		public void Pause()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public static class DTMath
	{
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1214BDC", Offset = "0x1214BDC", VA = "0x1214BDC")]
		public static Vector3 ParallelTransportFrame(Vector3 up, Vector3 tan0, Vector3 tan1)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1214D3C", Offset = "0x1214D3C", VA = "0x1214D3C")]
		public static Vector3 LeftTan(ref Vector3 tan, ref Vector3 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1214D54", Offset = "0x1214D54", VA = "0x1214D54")]
		public static Vector3 RightTan(ref Vector3 tan, ref Vector3 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1214D6C", Offset = "0x1214D6C", VA = "0x1214D6C")]
		public static float Repeat(float t, float length)
		{
			return default(float);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1214D88", Offset = "0x1214D88", VA = "0x1214D88")]
		public static double FixNaN(double v)
		{
			return default(double);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1214E04", Offset = "0x1214E04", VA = "0x1214E04")]
		public static float FixNaN(float v)
		{
			return default(float);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1214E34", Offset = "0x1214E34", VA = "0x1214E34")]
		public static Vector2 FixNaN(Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1214E88", Offset = "0x1214E88", VA = "0x1214E88")]
		public static Vector3 FixNaN(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1213F78", Offset = "0x1213F78", VA = "0x1213F78")]
		public static float MapValue(float min, float max, float value, float vMin = -1f, float vMax = 1f)
		{
			return default(float);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1214EF8", Offset = "0x1214EF8", VA = "0x1214EF8")]
		public static float SnapPrecision(float value, int decimals)
		{
			return default(float);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1214F7C", Offset = "0x1214F7C", VA = "0x1214F7C")]
		public static Vector2 SnapPrecision(Vector2 value, int decimals)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1214FD0", Offset = "0x1214FD0", VA = "0x1214FD0")]
		public static Vector3 SnapPrecision(Vector3 value, int decimals)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1210718", Offset = "0x1210718", VA = "0x1210718")]
		public static float LinePointDistanceSqr(Vector3 l1, Vector3 l2, Vector3 p, out float frag)
		{
			return default(float);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1215044", Offset = "0x1215044", VA = "0x1215044")]
		public static bool RayLineSegmentIntersection(Vector2 r0, Vector2 dir, Vector2 l1, Vector2 l2, out Vector2 hit, out float frag)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x12150E4", Offset = "0x12150E4", VA = "0x12150E4")]
		public static bool ShortestIntersectionLine(Vector3 line1A, Vector3 line1B, Vector3 line2A, Vector3 line2B, out Vector3 resultSegmentA, out Vector3 resultSegmentB)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x12153D4", Offset = "0x12153D4", VA = "0x12153D4")]
		public static bool LineLineIntersection(Vector3 line1A, Vector3 line1B, Vector3 line2A, Vector3 line2B, out Vector3 hitPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1215500", Offset = "0x1215500", VA = "0x1215500")]
		public static bool LineLineIntersect(Vector2 line1A, Vector2 line1B, Vector2 line2A, Vector2 line2B, out Vector2 hitPoint, bool segmentOnly = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1215628", Offset = "0x1215628", VA = "0x1215628")]
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
		[Address(RVA = "0x1214674", Offset = "0x1214674", VA = "0x1214674")]
		public static void Log(object message)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x12146D8", Offset = "0x12146D8", VA = "0x12146D8")]
		public static void Log(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x120F1A8", Offset = "0x120F1A8", VA = "0x120F1A8")]
		public static void LogError(object message)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x121474C", Offset = "0x121474C", VA = "0x121474C")]
		public static void LogError(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x12147C0", Offset = "0x12147C0", VA = "0x12147C0")]
		public static void LogErrorFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1214834", Offset = "0x1214834", VA = "0x1214834")]
		public static void LogErrorFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x12148B0", Offset = "0x12148B0", VA = "0x12148B0")]
		public static void LogException(Exception exception)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1214914", Offset = "0x1214914", VA = "0x1214914")]
		public static void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1214988", Offset = "0x1214988", VA = "0x1214988")]
		public static void LogFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x12149FC", Offset = "0x12149FC", VA = "0x12149FC")]
		public static void LogFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1211A68", Offset = "0x1211A68", VA = "0x1211A68")]
		public static void LogWarning(object message)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1214A78", Offset = "0x1214A78", VA = "0x1214A78")]
		public static void LogWarning(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1214AEC", Offset = "0x1214AEC", VA = "0x1214AEC")]
		public static void LogWarningFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1214B60", Offset = "0x1214B60", VA = "0x1214B60")]
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
			[Address(RVA = "0x1219364", Offset = "0x1219364", VA = "0x1219364")]
			get
			{
				return default(FloatRegion);
			}
		}

		[Token(Token = "0x1700001C")]
		public bool Positive
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x121945C", Offset = "0x121945C", VA = "0x121945C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001D")]
		public float Low
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x1219410", Offset = "0x1219410", VA = "0x1219410")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x1219420", Offset = "0x1219420", VA = "0x1219420")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public float High
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x1219434", Offset = "0x1219434", VA = "0x1219434")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x1219444", Offset = "0x1219444", VA = "0x1219444")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public float Random
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x121946C", Offset = "0x121946C", VA = "0x121946C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000020")]
		public float Next
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x1219478", Offset = "0x1219478", VA = "0x1219478")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000021")]
		public float Length
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x1219494", Offset = "0x1219494", VA = "0x1219494")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000022")]
		public float LengthPositive
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x12194A0", Offset = "0x12194A0", VA = "0x12194A0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1219348", Offset = "0x1219348", VA = "0x1219348")]
		public FloatRegion(float value)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1219358", Offset = "0x1219358", VA = "0x1219358")]
		public FloatRegion(float A, float B)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1219370", Offset = "0x1219370", VA = "0x1219370")]
		public void MakePositive()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1219384", Offset = "0x1219384", VA = "0x1219384")]
		public void Clamp(float low, float high)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x12194B8", Offset = "0x12194B8", VA = "0x12194B8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x121955C", Offset = "0x121955C", VA = "0x121955C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1219594", Offset = "0x1219594", VA = "0x1219594", Slot = "4")]
		public bool Equals(FloatRegion other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x12195E4", Offset = "0x12195E4", VA = "0x12195E4", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1219690", Offset = "0x1219690", VA = "0x1219690")]
		public static FloatRegion operator +(FloatRegion a, FloatRegion b)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x12196C4", Offset = "0x12196C4", VA = "0x12196C4")]
		public static FloatRegion operator -(FloatRegion a, FloatRegion b)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x12196F8", Offset = "0x12196F8", VA = "0x12196F8")]
		public static FloatRegion operator -(FloatRegion a)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1219710", Offset = "0x1219710", VA = "0x1219710")]
		public static FloatRegion operator *(FloatRegion a, float v)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1219738", Offset = "0x1219738", VA = "0x1219738")]
		public static FloatRegion operator *(float v, FloatRegion a)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1219760", Offset = "0x1219760", VA = "0x1219760")]
		public static FloatRegion operator /(FloatRegion a, float v)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1219788", Offset = "0x1219788", VA = "0x1219788")]
		public static bool operator ==(FloatRegion lhs, FloatRegion rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x12197F8", Offset = "0x12197F8", VA = "0x12197F8")]
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
			[Address(RVA = "0xF3EBA8", Offset = "0xF3EBA8", VA = "0xF3EBA8")]
			get
			{
				return default(IntRegion);
			}
		}

		[Token(Token = "0x17000024")]
		public bool Positive
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0xF3EC98", Offset = "0xF3EC98", VA = "0xF3EC98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000025")]
		public int Low
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0xF3EC4C", Offset = "0xF3EC4C", VA = "0xF3EC4C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0xF3EC5C", Offset = "0xF3EC5C", VA = "0xF3EC5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public int High
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0xF3EC70", Offset = "0xF3EC70", VA = "0xF3EC70")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0xF3EC80", Offset = "0xF3EC80", VA = "0xF3EC80")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public int Random
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0xF3ECA8", Offset = "0xF3ECA8", VA = "0xF3ECA8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000028")]
		public int Length
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0xF3ECB8", Offset = "0xF3ECB8", VA = "0xF3ECB8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000029")]
		public int LengthPositive
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0xF3ECC4", Offset = "0xF3ECC4", VA = "0xF3ECC4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xF3EB8C", Offset = "0xF3EB8C", VA = "0xF3EB8C")]
		public IntRegion(int value)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xF3EB9C", Offset = "0xF3EB9C", VA = "0xF3EB9C")]
		public IntRegion(int A, int B)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xF3EBB4", Offset = "0xF3EBB4", VA = "0xF3EBB4")]
		public void MakePositive()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xF3EBC8", Offset = "0xF3EBC8", VA = "0xF3EBC8")]
		public void Clamp(int low, int high)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xF3ECD8", Offset = "0xF3ECD8", VA = "0xF3ECD8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xF3ED7C", Offset = "0xF3ED7C", VA = "0xF3ED7C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xF3EDB4", Offset = "0xF3EDB4", VA = "0xF3EDB4", Slot = "4")]
		public bool Equals(IntRegion other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xF3EDFC", Offset = "0xF3EDFC", VA = "0xF3EDFC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xF3EE9C", Offset = "0xF3EE9C", VA = "0xF3EE9C")]
		public static IntRegion operator +(IntRegion a, IntRegion b)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xF3EEB8", Offset = "0xF3EEB8", VA = "0xF3EEB8")]
		public static IntRegion operator -(IntRegion a, IntRegion b)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xF3EED4", Offset = "0xF3EED4", VA = "0xF3EED4")]
		public static IntRegion operator -(IntRegion a)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xF3EEEC", Offset = "0xF3EEEC", VA = "0xF3EEEC")]
		public static IntRegion operator *(IntRegion a, int v)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xF3EF04", Offset = "0xF3EF04", VA = "0xF3EF04")]
		public static IntRegion operator *(int v, IntRegion a)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xF3EF20", Offset = "0xF3EF20", VA = "0xF3EF20")]
		public static IntRegion operator /(IntRegion a, int v)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xF3EF38", Offset = "0xF3EF38", VA = "0xF3EF38")]
		public static bool operator ==(IntRegion lhs, IntRegion rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xF3EF70", Offset = "0xF3EF70", VA = "0xF3EF70")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9FA8", Offset = "0x6D9FA8")]
		private int <Seed>k__BackingField;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9FB8", Offset = "0x6D9FB8")]
		private bool <RandomizeSeed>k__BackingField;

		[Token(Token = "0x1700002A")]
		public int Seed
		{
			[Token(Token = "0x60000F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5108", Offset = "0x6E5108")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000F1")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5118", Offset = "0x6E5118")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public bool RandomizeSeed
		{
			[Token(Token = "0x60000F2")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5128", Offset = "0x6E5128")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F3")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5138", Offset = "0x6E5138")]
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
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6D7A4C", Offset = "0x6D7A4C")]
	public class Ring<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mList;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9FC8", Offset = "0x6D9FC8")]
		private int <Size>k__BackingField;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mIndex;

		[Token(Token = "0x1700002E")]
		public int Size
		{
			[Token(Token = "0x60000FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5148", Offset = "0x6E5148")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000FD")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5158", Offset = "0x6E5158")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9FD8", Offset = "0x6D9FD8")]
		private string <Identifier>k__BackingField;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9FE8", Offset = "0x6D9FE8")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5168", Offset = "0x6E5168")]
			get
			{
				return null;
			}
			[Token(Token = "0x600010E")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5178", Offset = "0x6E5178")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public PoolSettings Settings
		{
			[Token(Token = "0x600010F")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5188", Offset = "0x6E5188")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000110")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5198", Offset = "0x6E5198")]
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
			[Address(RVA = "0xF45D4C", Offset = "0xF45D4C", VA = "0xF45D4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000122")]
			[Address(RVA = "0xF45C60", Offset = "0xF45C60", VA = "0xF45C60")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public bool AutoCreate
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0xF45D54", Offset = "0xF45D54", VA = "0xF45D54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000124")]
			[Address(RVA = "0xF45C80", Offset = "0xF45C80", VA = "0xF45C80")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public bool AutoEnableDisable
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0xF45D5C", Offset = "0xF45D5C", VA = "0xF45D5C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000126")]
			[Address(RVA = "0xF45D64", Offset = "0xF45D64", VA = "0xF45D64")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public int MinItems
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0xF45D84", Offset = "0xF45D84", VA = "0xF45D84")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000128")]
			[Address(RVA = "0xF45CA0", Offset = "0xF45CA0", VA = "0xF45CA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public int Threshold
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0xF45D8C", Offset = "0xF45D8C", VA = "0xF45D8C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600012A")]
			[Address(RVA = "0xF45CD8", Offset = "0xF45CD8", VA = "0xF45CD8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public float Speed
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0xF45D94", Offset = "0xF45D94", VA = "0xF45D94")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600012C")]
			[Address(RVA = "0xF45D10", Offset = "0xF45D10", VA = "0xF45D10")]
			set
			{
			}
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xF45C48", Offset = "0xF45C48", VA = "0xF45C48")]
		public PoolSettings()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xF45470", Offset = "0xF45470", VA = "0xF45470")]
		public PoolSettings(PoolSettings src)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xF449BC", Offset = "0xF449BC", VA = "0xF449BC")]
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
		[Address(RVA = "0x12164E8", Offset = "0x12164E8", VA = "0x12164E8")]
		public DTPropertyAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class LabelAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000138")]
		[Address(RVA = "0xF40238", Offset = "0xF40238", VA = "0xF40238")]
		public LabelAttribute()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xF4028C", Offset = "0xF4028C", VA = "0xF4028C")]
		public LabelAttribute(string label, string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class ToggleButtonAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x11F5138", Offset = "0x11F5138", VA = "0x11F5138")]
		public ToggleButtonAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class LayerAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x600013B")]
		[Address(RVA = "0xF40294", Offset = "0xF40294", VA = "0xF40294")]
		public LayerAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class TagAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x11EFBD4", Offset = "0x11EFBD4", VA = "0x11EFBD4")]
		public TagAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class VectorExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x11F8760", Offset = "0x11F8760", VA = "0x11F8760")]
		public VectorExAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class AnimationCurveExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x600013E")]
		[Address(RVA = "0xF63E78", Offset = "0xF63E78", VA = "0xF63E78")]
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
		[Address(RVA = "0xF411D0", Offset = "0xF411D0", VA = "0xF411D0")]
		public MinAttribute(float value, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xF41204", Offset = "0xF41204", VA = "0xF41204")]
		public MinAttribute(string fieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class PositiveAttribute : MinAttribute
	{
		[Token(Token = "0x6000141")]
		[Address(RVA = "0xF45D9C", Offset = "0xF45D9C", VA = "0xF45D9C")]
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
		[Address(RVA = "0xF402B8", Offset = "0xF402B8", VA = "0xF402B8")]
		public MaxAttribute(float value, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xF402EC", Offset = "0xF402EC", VA = "0xF402EC")]
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
		[Address(RVA = "0xF46F48", Offset = "0xF46F48", VA = "0xF46F48")]
		public RangeExAttribute(float minValue, float maxValue, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xF46F8C", Offset = "0xF46F8C", VA = "0xF46F8C")]
		public RangeExAttribute(string minFieldOrProperty, float maxValue, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xF46FE4", Offset = "0xF46FE4", VA = "0xF46FE4")]
		public RangeExAttribute(float minValue, string maxFieldOrProperty, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xF47038", Offset = "0xF47038", VA = "0xF47038")]
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
		[Address(RVA = "0xF41240", Offset = "0xF41240", VA = "0xF41240")]
		public MinMaxAttribute(string maxValueField, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class EnumFlagAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x12192A8", Offset = "0x12192A8", VA = "0x12192A8")]
		public EnumFlagAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class ObjectSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x600014A")]
		[Address(RVA = "0xF44020", Offset = "0xF44020", VA = "0xF44020")]
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
		[Address(RVA = "0xF448C4", Offset = "0xF448C4", VA = "0xF448C4")]
		public PathSelectorAttribute(DialogMode mode = DialogMode.OpenFile)
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class EnumSelectionGridAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x12192AC", Offset = "0x12192AC", VA = "0x12192AC")]
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
		[Address(RVA = "0x1216540", Offset = "0x1216540", VA = "0x1216540")]
		public DTRegionAttribute()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class FloatRegionAttribute : DTRegionAttribute
	{
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x121986C", Offset = "0x121986C", VA = "0x121986C")]
		public FloatRegionAttribute()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class IntRegionAttribute : DTRegionAttribute
	{
		[Token(Token = "0x600014F")]
		[Address(RVA = "0xF3EFA8", Offset = "0xF3EFA8", VA = "0xF3EFA8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E51A8", Offset = "0x6E51A8")]
		private void <.ctor>b__6_0(object o)
		{
		}

		[Token(Token = "0x6000159")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E51B8", Offset = "0x6E51B8")]
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
		[Address(RVA = "0xF46F40", Offset = "0xF46F40", VA = "0xF46F40")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D7A84", Offset = "0x6D7A84")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D7A94", Offset = "0x6D7A94")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40000CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action act;

			[Token(Token = "0x6000170")]
			[Address(RVA = "0x11F4470", Offset = "0x11F4470", VA = "0x11F4470")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000171")]
			[Address(RVA = "0x11FA250", Offset = "0x11FA250", VA = "0x11FA250")]
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
		[Address(RVA = "0x11F40F0", Offset = "0x11F40F0", VA = "0x11F40F0")]
		public void QueueWorkItem(WaitCallback callback)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x11F4190", Offset = "0x11F4190", VA = "0x11F4190")]
		public void QueueWorkItem(Action act)
		{
		}

		[Token(Token = "0x6000161")]
		public void ParralelFor<T>(Action<T> action, List<T> list)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x11F42B8", Offset = "0x11F42B8", VA = "0x11F42B8")]
		private void QueueWorkItem(QueuedCallback callback)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x11F40F8", Offset = "0x11F40F8", VA = "0x11F40F8")]
		public void QueueWorkItem(WaitCallback callback, object state)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x11F4198", Offset = "0x11F4198", VA = "0x11F4198")]
		public void QueueWorkItem(Action act, object state)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x11F4478", Offset = "0x11F4478", VA = "0x11F4478")]
		public bool WaitAll()
		{
			return default(bool);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x11F45D0", Offset = "0x11F45D0", VA = "0x11F45D0")]
		public bool WaitAll(TimeSpan timeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x11F4484", Offset = "0x11F4484", VA = "0x11F4484")]
		public bool WaitAll(int millisecondsTimeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x11F4718", Offset = "0x11F4718", VA = "0x11F4718")]
		private void HandleWorkItem(object state)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x11F4630", Offset = "0x11F4630", VA = "0x11F4630")]
		private void DoneWorkItem()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x11F43FC", Offset = "0x11F43FC", VA = "0x11F43FC")]
		private void ThrowIfDisposed()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x11F4804", Offset = "0x11F4804", VA = "0x11F4804", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x11F48C8", Offset = "0x11F48C8", VA = "0x11F48C8")]
		public ThreadPoolWorker()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D7AA4", Offset = "0x6D7AA4")]
	public class ComponentPool : MonoBehaviour, IPool, ISerializationCallbackReceiver
	{
		[Token(Token = "0x200004F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D7ADC", Offset = "0x6D7ADC")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x40000D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string typeName;

			[Token(Token = "0x600018D")]
			[Address(RVA = "0x11F9338", Offset = "0x11F9338", VA = "0x11F9338")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x600018E")]
			[Address(RVA = "0x11F9340", Offset = "0x11F9340", VA = "0x11F9340")]
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
			[Address(RVA = "0xEC2A78", Offset = "0xEC2A78", VA = "0xEC2A78", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000173")]
			[Address(RVA = "0xEC2A80", Offset = "0xEC2A80", VA = "0xEC2A80")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public PoolManager Manager
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0xEC2AD0", Offset = "0xEC2AD0", VA = "0xEC2AD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public string Identifier
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0xEC2B84", Offset = "0xEC2B84", VA = "0xEC2B84", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0xEC2B8C", Offset = "0xEC2B8C", VA = "0xEC2B8C", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public Type Type
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0xEC2BE0", Offset = "0xEC2BE0", VA = "0xEC2BE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public int Count
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0xEC2CE4", Offset = "0xEC2CE4", VA = "0xEC2CE4", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xEC2D30", Offset = "0xEC2D30", VA = "0xEC2D30")]
		public void Initialize(Type type, PoolSettings settings)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xEC2F60", Offset = "0xEC2F60", VA = "0xEC2F60")]
		private void Start()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xEC2F84", Offset = "0xEC2F84", VA = "0xEC2F84")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xEC3040", Offset = "0xEC3040", VA = "0xEC3040")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xEC3044", Offset = "0xEC3044", VA = "0xEC3044", Slot = "9")]
		public void Update()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xEC2DFC", Offset = "0xEC2DFC", VA = "0xEC2DFC", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xEC359C", Offset = "0xEC359C", VA = "0xEC359C")]
		public void OnSceneLoaded(Scene scn, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xEC36B0", Offset = "0xEC36B0", VA = "0xEC36B0", Slot = "7")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xEC3798", Offset = "0xEC3798", VA = "0xEC3798")]
		public void Push(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xEC3AB8", Offset = "0xEC3AB8", VA = "0xEC3AB8")]
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
		[Address(RVA = "0xEC3430", Offset = "0xEC3430", VA = "0xEC3430")]
		private UnityEngine.Component create()
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xEC3378", Offset = "0xEC3378", VA = "0xEC3378")]
		private void destroy(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xEC3E90", Offset = "0xEC3E90", VA = "0xEC3E90")]
		private void setParent(UnityEngine.Component item, Transform parent)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xEC3CC4", Offset = "0xEC3CC4", VA = "0xEC3CC4")]
		private void sendAfterPop(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xEC38F0", Offset = "0xEC38F0", VA = "0xEC38F0")]
		private void sendBeforePush(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xEC3298", Offset = "0xEC3298", VA = "0xEC3298")]
		private void log(string msg)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xEC3F3C", Offset = "0xEC3F3C", VA = "0xEC3F3C", Slot = "11")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xEC3F40", Offset = "0xEC3F40", VA = "0xEC3F40", Slot = "12")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xEC41F0", Offset = "0xEC41F0", VA = "0xEC41F0")]
		public ComponentPool()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class DTSingleton<T> : MonoBehaviour, IDTSingleton where T : MonoBehaviour, IDTSingleton
	{
		[Serializable]
		[Token(Token = "0x2000051")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D7AEC", Offset = "0x6D7AEC")]
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
			[Address(RVA = "0x1218A44", Offset = "0x1218A44", VA = "0x1218A44")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x1218A4C", Offset = "0x1218A4C", VA = "0x1218A4C")]
			protected set
			{
			}
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1218A54", Offset = "0x1218A54", VA = "0x1218A54")]
		public void Destroy()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1218B04", Offset = "0x1218B04", VA = "0x1218B04")]
		protected DTVersionedMonoBehaviour()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D7AFC", Offset = "0x6D7AFC")]
	public abstract class DuplicateEditorMesh : MonoBehaviour
	{
		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MeshFilter mFilter;

		[Token(Token = "0x17000048")]
		public MeshFilter Filter
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x1218D34", Offset = "0x1218D34", VA = "0x1218D34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1218DE8", Offset = "0x1218DE8", VA = "0x1218DE8", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1219074", Offset = "0x1219074", VA = "0x1219074")]
		protected DuplicateEditorMesh()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D7B6C", Offset = "0x6D7B6C")]
	public class InspectorNote : MonoBehaviour
	{
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x6DA178", Offset = "0x6DA178")]
		private string m_Note;

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xF3EB84", Offset = "0xF3EB84", VA = "0xF3EB84")]
		public InspectorNote()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D7BA4", Offset = "0x6D7BA4")]
	public class PoolManager : MonoBehaviour
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6DA1B8", Offset = "0x6DA1B8")]
		[SerializeField]
		private bool m_AutoCreatePools;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "AsGroupAttribute", RVA = "0x6DA210", Offset = "0x6DA210")]
		[SerializeField]
		private PoolSettings m_DefaultSettings;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA254", Offset = "0x6DA254")]
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
			[Address(RVA = "0xF44940", Offset = "0xF44940", VA = "0xF44940")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0xF44948", Offset = "0xF44948", VA = "0xF44948")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public PoolSettings DefaultSettings
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0xF44968", Offset = "0xF44968", VA = "0xF44968")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0xF44970", Offset = "0xF44970", VA = "0xF44970")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public bool IsInitialized
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0xF44A34", Offset = "0xF44A34", VA = "0xF44A34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E51C8", Offset = "0x6E51C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0xF44A3C", Offset = "0xF44A3C", VA = "0xF44A3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E51D8", Offset = "0x6E51D8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public int Count
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0xF44A48", Offset = "0xF44A48", VA = "0xF44A48")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xF44AD0", Offset = "0xF44AD0", VA = "0xF44AD0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xF44AD8", Offset = "0xF44AD8", VA = "0xF44AD8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xF44C98", Offset = "0xF44C98", VA = "0xF44C98")]
		private void Initialize()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xF45124", Offset = "0xF45124", VA = "0xF45124")]
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
		[Address(RVA = "0xF451D8", Offset = "0xF451D8", VA = "0xF451D8")]
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
		[Address(RVA = "0xF452DC", Offset = "0xF452DC", VA = "0xF452DC")]
		public PrefabPool CreatePrefabPool(string name, [Optional] PoolSettings settings, params GameObject[] prefabs)
		{
			return null;
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xF4568C", Offset = "0xF4568C", VA = "0xF4568C")]
		public List<IPool> FindPools(string identifierStartsWith)
		{
			return null;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xF45858", Offset = "0xF45858", VA = "0xF45858")]
		public void DeletePools(string startsWith)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xF45910", Offset = "0xF45910", VA = "0xF45910")]
		public void DeletePool(IPool pool)
		{
		}

		[Token(Token = "0x60001B7")]
		public void DeletePool<T>()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xF45AF8", Offset = "0xF45AF8", VA = "0xF45AF8")]
		public PoolManager()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D7C00", Offset = "0x6D7C00")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D7C00", Offset = "0x6D7C00")]
	public class PrefabPool : MonoBehaviour, IPool
	{
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DA264", Offset = "0x6DA264")]
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
			[Address(RVA = "0xF45DF8", Offset = "0xF45DF8", VA = "0xF45DF8", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0xF45E00", Offset = "0xF45E00", VA = "0xF45E00", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public List<GameObject> Prefabs
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0xF45F34", Offset = "0xF45F34", VA = "0xF45F34")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0xF45F3C", Offset = "0xF45F3C", VA = "0xF45F3C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public PoolSettings Settings
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0xF45F54", Offset = "0xF45F54", VA = "0xF45F54", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0xF45F5C", Offset = "0xF45F5C", VA = "0xF45F5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public PoolManager Manager
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0xF45E80", Offset = "0xF45E80", VA = "0xF45E80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public int Count
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0xF46388", Offset = "0xF46388", VA = "0xF46388", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xF45FA8", Offset = "0xF45FA8", VA = "0xF45FA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xF45FAC", Offset = "0xF45FAC", VA = "0xF45FAC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xF4555C", Offset = "0xF4555C", VA = "0xF4555C")]
		public void Initialize(string ident, PoolSettings settings, params GameObject[] prefabs)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xF46134", Offset = "0xF46134", VA = "0xF46134", Slot = "9")]
		public void Update()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xF45FD0", Offset = "0xF45FD0", VA = "0xF45FD0", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xF466F4", Offset = "0xF466F4", VA = "0xF466F4", Slot = "7")]
		public void Clear()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xF467DC", Offset = "0xF467DC", VA = "0xF467DC")]
		public GameObject Pop([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xF46A38", Offset = "0xF46A38", VA = "0xF46A38", Slot = "11")]
		public virtual void Push(GameObject item)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xF46518", Offset = "0xF46518", VA = "0xF46518")]
		private GameObject create()
		{
			return null;
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xF464B4", Offset = "0xF464B4", VA = "0xF464B4")]
		private void destroy(GameObject go)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xF463D4", Offset = "0xF463D4", VA = "0xF463D4")]
		private void log(string msg)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xF46C38", Offset = "0xF46C38", VA = "0xF46C38")]
		private void setParent(Transform item, Transform parent)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xF469DC", Offset = "0xF469DC", VA = "0xF469DC")]
		private void sendAfterPop(GameObject item)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xF46BDC", Offset = "0xF46BDC", VA = "0xF46BDC")]
		private void sendBeforePush(GameObject item)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xF46CD8", Offset = "0xF46CD8", VA = "0xF46CD8")]
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
		[Address(RVA = "0xF43F48", Offset = "0xF43F48", VA = "0xF43F48")]
		public static void Destroy(this UnityEngine.Object c)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xF43FAC", Offset = "0xF43FAC", VA = "0xF43FAC")]
		public static string ToDumpString(this object o)
		{
			return null;
		}
	}
	[Token(Token = "0x2000059")]
	public static class Vector2Ext
	{
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x11F83BC", Offset = "0x11F83BC", VA = "0x11F83BC")]
		public static Vector2 Snap(this Vector2 v, float snapX, float snapY = -1f)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x11F8414", Offset = "0x11F8414", VA = "0x11F8414")]
		public static float AngleSigned(this Vector2 a, Vector2 b)
		{
			return default(float);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x11F8568", Offset = "0x11F8568", VA = "0x11F8568")]
		public static Vector2 LeftNormal(this Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x11F857C", Offset = "0x11F857C", VA = "0x11F857C")]
		public static Vector2 RightNormal(this Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x11F858C", Offset = "0x11F858C", VA = "0x11F858C")]
		public static Vector2 Rotate(this Vector2 v, float degree)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x11F85EC", Offset = "0x11F85EC", VA = "0x11F85EC")]
		public static Vector2 ToVector3(this Vector2 v)
		{
			return default(Vector2);
		}
	}
	[Token(Token = "0x200005A")]
	public static class Vector3Ext
	{
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x11F85F0", Offset = "0x11F85F0", VA = "0x11F85F0")]
		public static float AngleSigned(this Vector3 a, Vector3 b, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x11F8694", Offset = "0x11F8694", VA = "0x11F8694")]
		public static Vector3 RotateAround(this Vector3 point, Vector3 origin, Quaternion rotation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x11F86F4", Offset = "0x11F86F4", VA = "0x11F86F4")]
		public static Vector2 ToVector2(this Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x11F86F8", Offset = "0x11F86F8", VA = "0x11F86F8")]
		public static bool Approximately(this Vector3 v1, Vector3 v2)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x11F872C", Offset = "0x11F872C", VA = "0x11F872C")]
		public static bool NotApproximately(this Vector3 v1, Vector3 v2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200005B")]
	public static class QuaternionExt
	{
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xF46D88", Offset = "0xF46D88", VA = "0xF46D88")]
		public static bool SameOrientation(this Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xF46E64", Offset = "0xF46E64", VA = "0xF46E64")]
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
		[Address(RVA = "0xEC1A38", Offset = "0xEC1A38", VA = "0xEC1A38")]
		public static bool BoundsInView(this Camera c, Bounds bounds)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xEC1D2C", Offset = "0xEC1D2C", VA = "0xEC1D2C")]
		public static bool BoundsPartiallyInView(this Camera c, Bounds bounds)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200005D")]
	public static class GameObjectExt
	{
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1219CA8", Offset = "0x1219CA8", VA = "0x1219CA8")]
		public static GameObject DuplicateGameObject(this GameObject source, Transform newParent, bool keepPrefabReference = false)
		{
			return null;
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1219DAC", Offset = "0x1219DAC", VA = "0x1219DAC")]
		public static void StripComponents(this GameObject go, params Type[] toKeep)
		{
		}
	}
	[Token(Token = "0x200005E")]
	public static class ComponentExt
	{
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xEC2688", Offset = "0xEC2688", VA = "0xEC2688")]
		public static void StripComponents(this UnityEngine.Component c, params Type[] toKeep)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xEC2774", Offset = "0xEC2774", VA = "0xEC2774")]
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
		[Address(RVA = "0xEC281C", Offset = "0xEC281C", VA = "0xEC281C")]
		public static UnityEngine.Component DuplicateGameObject(this UnityEngine.Component source, Transform newParent, bool keepPrefabConnection = false)
		{
			return null;
		}
	}
	[Token(Token = "0x200005F")]
	public static class ColorExt
	{
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xEC20E4", Offset = "0xEC20E4", VA = "0xEC20E4")]
		public static string ToHtml(this Color c)
		{
			return null;
		}
	}
	[Token(Token = "0x2000060")]
	public static class EnumExt
	{
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x121907C", Offset = "0x121907C", VA = "0x121907C")]
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
		[Address(RVA = "0xF47098", Offset = "0xF47098", VA = "0xF47098")]
		public static Rect Set(this Rect rect, Vector2 pos, Vector2 size)
		{
			return default(Rect);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xF470F4", Offset = "0xF470F4", VA = "0xF470F4")]
		public static Rect SetBetween(this Rect rect, Vector2 pos, Vector2 pos2)
		{
			return default(Rect);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xF47150", Offset = "0xF47150", VA = "0xF47150")]
		public static Rect SetPosition(this Rect rect, Vector2 pos)
		{
			return default(Rect);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xF471BC", Offset = "0xF471BC", VA = "0xF471BC")]
		public static Rect SetPosition(this Rect rect, float x, float y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xF47228", Offset = "0xF47228", VA = "0xF47228")]
		public static Vector2 GetSize(this Rect rect)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xF47274", Offset = "0xF47274", VA = "0xF47274")]
		public static Rect SetSize(this Rect rect, Vector2 size)
		{
			return default(Rect);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xF472E0", Offset = "0xF472E0", VA = "0xF472E0")]
		public static Rect ScaleBy(this Rect rect, int pixel)
		{
			return default(Rect);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xF472E8", Offset = "0xF472E8", VA = "0xF472E8")]
		public static Rect ScaleBy(this Rect rect, int x, int y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xF473C0", Offset = "0xF473C0", VA = "0xF473C0")]
		public static Rect ShiftBy(this Rect rect, int x, int y)
		{
			return default(Rect);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xF47450", Offset = "0xF47450", VA = "0xF47450")]
		public static Rect Include(this Rect rect, Rect other)
		{
			return default(Rect);
		}
	}
	[Token(Token = "0x2000062")]
	public static class StringExt
	{
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x11EF2B0", Offset = "0x11EF2B0", VA = "0x11EF2B0")]
		public static Color ColorFromHtml(this string hexString)
		{
			return default(Color);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x11EF59C", Offset = "0x11EF59C", VA = "0x11EF59C")]
		public static string TrimStart(this string s, string trim, StringComparison compare = StringComparison.CurrentCultureIgnoreCase)
		{
			return null;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x11EF5F0", Offset = "0x11EF5F0", VA = "0x11EF5F0")]
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
		[Address(RVA = "0xF40328", Offset = "0xF40328", VA = "0xF40328")]
		public static Mesh PrepareNewShared(this MeshFilter m, string name = "Mesh")
		{
			return null;
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xF404B4", Offset = "0xF404B4", VA = "0xF404B4")]
		public static void CalculateTangents(this MeshFilter m)
		{
		}
	}
	[Token(Token = "0x2000066")]
	public static class TypeExt
	{
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x11F5140", Offset = "0x11F5140", VA = "0x11F5140")]
		public static Type[] GetLoadedTypes()
		{
			return null;
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x11F5684", Offset = "0x11F5684", VA = "0x11F5684")]
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
		[Address(RVA = "0x11F56A8", Offset = "0x11F56A8", VA = "0x11F56A8")]
		public static MethodInfo MethodByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x11F5858", Offset = "0x11F5858", VA = "0x11F5858")]
		public static FieldInfo FieldByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x11F5A20", Offset = "0x11F5A20", VA = "0x11F5A20")]
		public static PropertyInfo PropertyByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x11F5BD0", Offset = "0x11F5BD0", VA = "0x11F5BD0")]
		public static FieldInfo[] GetAllFields(this Type type, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x11F5D88", Offset = "0x11F5D88", VA = "0x11F5D88")]
		public static PropertyInfo[] GetAllProperties(this Type type, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x11F5F40", Offset = "0x11F5F40", VA = "0x11F5F40")]
		public static bool IsFrameworkType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x11F6060", Offset = "0x11F6060", VA = "0x11F6060")]
		public static bool IsArrayOrList(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x11F6150", Offset = "0x11F6150", VA = "0x11F6150")]
		public static Type GetEnumerableType(this Type t)
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x11F620C", Offset = "0x11F620C", VA = "0x11F620C")]
		private static Type FindIEnumerable(Type seqType)
		{
			return null;
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x11F56DC", Offset = "0x11F56DC", VA = "0x11F56DC")]
		private static MethodInfo GetMethodIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x11F5894", Offset = "0x11F5894", VA = "0x11F5894")]
		private static FieldInfo GetFieldIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x11F5A54", Offset = "0x11F5A54", VA = "0x11F5A54")]
		private static PropertyInfo GetPropertyIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x11F6678", Offset = "0x11F6678", VA = "0x11F6678")]
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
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D7D84", Offset = "0x6D7D84")]
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
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DA3D4", Offset = "0x6DA3D4")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6DA3D4", Offset = "0x6DA3D4")]
		private bool m_UVEdge;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[Positive]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DA4D0", Offset = "0x6DA4D0")]
		[SerializeField]
		private bool m_ExplicitU;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Positive]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x6DA590", Offset = "0x6DA590")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DA590", Offset = "0x6DA590")]
		private float m_FirstU;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Positive]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DA678", Offset = "0x6DA678")]
		[SerializeField]
		private float m_SecondU;

		[Token(Token = "0x17000052")]
		public int MaterialID
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0xF40B8C", Offset = "0xF40B8C", VA = "0xF40B8C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600021B")]
			[Address(RVA = "0xF40B94", Offset = "0xF40B94", VA = "0xF40B94")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public bool HardEdge
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0xF40BE0", Offset = "0xF40BE0", VA = "0xF40BE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600021D")]
			[Address(RVA = "0xF40BE8", Offset = "0xF40BE8", VA = "0xF40BE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public bool UVEdge
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0xF40C10", Offset = "0xF40C10", VA = "0xF40C10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600021F")]
			[Address(RVA = "0xF40C18", Offset = "0xF40C18", VA = "0xF40C18")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public bool ExplicitU
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0xF40C40", Offset = "0xF40C40", VA = "0xF40C40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0xF40C48", Offset = "0xF40C48", VA = "0xF40C48")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public float FirstU
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0xF40C70", Offset = "0xF40C70", VA = "0xF40C70")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0xF40C78", Offset = "0xF40C78", VA = "0xF40C78")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public float SecondU
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0xF40C94", Offset = "0xF40C94", VA = "0xF40C94")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000225")]
			[Address(RVA = "0xF40C9C", Offset = "0xF40C9C", VA = "0xF40C9C")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public float MaxStepDistance
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0xF40CB8", Offset = "0xF40CB8", VA = "0xF40CB8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000227")]
			[Address(RVA = "0xF40CC0", Offset = "0xF40CC0", VA = "0xF40CC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public bool HasDifferentMaterial
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0xF40D10", Offset = "0xF40D10", VA = "0xF40D10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005A")]
		private bool showUVEdge
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0xF40DD0", Offset = "0xF40DD0", VA = "0xF40DD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		private bool showExplicitU
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0xF40F1C", Offset = "0xF40F1C", VA = "0xF40F1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		private bool showFirstU
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0xF40FAC", Offset = "0xF40FAC", VA = "0xF40FAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		private bool showSecondU
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0xF41048", Offset = "0xF41048", VA = "0xF41048")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xF4105C", Offset = "0xF4105C", VA = "0xF4105C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xF41114", Offset = "0xF41114", VA = "0xF41114")]
		public float GetDefinedFirstU(float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xF41160", Offset = "0xF41160", VA = "0xF41160")]
		public float GetDefinedSecondU(float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xF411C8", Offset = "0xF411C8", VA = "0xF411C8")]
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
		[Address(RVA = "0xEC5620", Offset = "0xEC5620", VA = "0xEC5620")]
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
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D7DDC", Offset = "0x6D7DDC")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6D7DDC", Offset = "0x6D7DDC")]
	[ExecuteInEditMode]
	public class CurvyConnection : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000079")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D7E4C", Offset = "0x6D7E4C")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x400013F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CurvySplineSegment controlPoint;

			[Token(Token = "0x6000248")]
			[Address(RVA = "0x11F9538", Offset = "0x11F9538", VA = "0x11F9538")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x6000249")]
			[Address(RVA = "0x11F9540", Offset = "0x11F9540", VA = "0x11F9540")]
			internal bool <RemoveControlPoint>b__0(ControlPointCoordinates element)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200007A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D7E5C", Offset = "0x6D7E5C")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x4000140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CurvySplineSegment controlPoint;

			[Token(Token = "0x600024A")]
			[Address(RVA = "0x11F9564", Offset = "0x11F9564", VA = "0x11F9564")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x600024B")]
			[Address(RVA = "0x11F956C", Offset = "0x11F956C", VA = "0x11F956C")]
			internal bool <SetSynchronisationPositionAndRotation>b__0(ControlPointCoordinates element)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200007B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D7E6C", Offset = "0x6D7E6C")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x4000141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CurvySplineSegment controlPoint;

			[Token(Token = "0x600024C")]
			[Address(RVA = "0x11F9590", Offset = "0x11F9590", VA = "0x11F9590")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x600024D")]
			[Address(RVA = "0x11F9598", Offset = "0x11F9598", VA = "0x11F9598")]
			internal bool <DoUpdate>b__0(ControlPointCoordinates element)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x200007C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D7E7C", Offset = "0x6D7E7C")]
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
			[Address(RVA = "0x11F94B0", Offset = "0x11F94B0", VA = "0x11F94B0")]
			public <>c()
			{
			}

			[Token(Token = "0x6000250")]
			[Address(RVA = "0x11F94B8", Offset = "0x11F94B8", VA = "0x11F94B8")]
			internal bool <OnSceneLoaded>b__24_0(CurvySplineSegment cp)
			{
				return default(bool);
			}

			[Token(Token = "0x6000251")]
			[Address(RVA = "0x11F9520", Offset = "0x11F9520", VA = "0x11F9520")]
			internal bool <OnBeforeSerialize>b__26_0(CurvySplineSegment cp)
			{
				return default(bool);
			}

			[Token(Token = "0x6000252")]
			[Address(RVA = "0x11F952C", Offset = "0x11F952C", VA = "0x11F952C")]
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
			[Address(RVA = "0xEC95E8", Offset = "0xEC95E8", VA = "0xEC95E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		public int Count
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0xEC9660", Offset = "0xEC9660", VA = "0xEC9660")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000060")]
		public CurvySplineSegment Item
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0xEC96AC", Offset = "0xEC96AC", VA = "0xEC96AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xEC9720", Offset = "0xEC9720", VA = "0xEC9720")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xEC99D4", Offset = "0xEC99D4", VA = "0xEC99D4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xEC9A90", Offset = "0xEC9A90", VA = "0xEC9A90")]
		private void Update()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xECA108", Offset = "0xECA108", VA = "0xECA108")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xECA140", Offset = "0xECA140", VA = "0xECA140")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xECA178", Offset = "0xECA178", VA = "0xECA178")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xECA328", Offset = "0xECA328", VA = "0xECA328")]
		public static CurvyConnection Create(params CurvySplineSegment[] controlPoints)
		{
			return null;
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xECA4FC", Offset = "0xECA4FC", VA = "0xECA4FC")]
		public void AddControlPoints(params CurvySplineSegment[] controlPoints)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xECA6F0", Offset = "0xECA6F0", VA = "0xECA6F0")]
		public void AutoSetFollowUp()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xECA950", Offset = "0xECA950", VA = "0xECA950")]
		public void RemoveControlPoint(CurvySplineSegment controlPoint, bool destroySelfIfEmpty = true)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xECAC0C", Offset = "0xECAC0C", VA = "0xECAC0C")]
		public void Delete()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xECAC9C", Offset = "0xECAC9C", VA = "0xECAC9C")]
		public List<CurvySplineSegment> OtherControlPoints(CurvySplineSegment source)
		{
			return null;
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xECAD4C", Offset = "0xECAD4C", VA = "0xECAD4C")]
		public void SetSynchronisationPositionAndRotation(Vector3 referencePosition, Quaternion referenceRotation)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xEC9AC8", Offset = "0xEC9AC8", VA = "0xEC9AC8")]
		private void DoUpdate()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xECB114", Offset = "0xECB114", VA = "0xECB114")]
		private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xEC97E4", Offset = "0xEC97E4", VA = "0xEC97E4")]
		private void ResetProcessedCoordinates()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xECB2F0", Offset = "0xECB2F0", VA = "0xECB2F0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xECB41C", Offset = "0xECB41C", VA = "0xECB41C", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xECB548", Offset = "0xECB548", VA = "0xECB548")]
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
		[Address(RVA = "0xEC5768", Offset = "0xEC5768", VA = "0xEC5768")]
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
		[Address(RVA = "0xF11B10", Offset = "0xF11B10", VA = "0xF11B10")]
		public CurvyEventArgs(MonoBehaviour sender, object data)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007F")]
	public class CurvySplineEvent : UnityEventEx<CurvySplineEventArgs>
	{
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x120CD48", Offset = "0x120CD48", VA = "0x120CD48")]
		public CurvySplineEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public class CurvyControlPointEvent : UnityEventEx<CurvyControlPointEventArgs>
	{
		[Token(Token = "0x6000256")]
		[Address(RVA = "0xF0FB24", Offset = "0xF0FB24", VA = "0xF0FB24")]
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
		[Address(RVA = "0xF0FB70", Offset = "0xF0FB70", VA = "0xF0FB70")]
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
		[Address(RVA = "0x120CD94", Offset = "0x120CD94", VA = "0x120CD94")]
		public CurvySplineEventArgs(MonoBehaviour sender, CurvySpline spline, [Optional] object data)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000084")]
	public class CurvyCGEvent : UnityEventEx<CurvyCGEventArgs>
	{
		[Token(Token = "0x6000259")]
		[Address(RVA = "0xEC9450", Offset = "0xEC9450", VA = "0xEC9450")]
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
		[Address(RVA = "0xEC949C", Offset = "0xEC949C", VA = "0xEC949C")]
		public CurvyCGEventArgs(CGModule module)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xEC9544", Offset = "0xEC9544", VA = "0xEC9544")]
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
		[Address(RVA = "0xF158A8", Offset = "0xF158A8", VA = "0xF158A8")]
		public static void SegmentCurveGizmo(CurvySplineSegment seg, Color col, float stepSize = 0.05f)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xF15AE8", Offset = "0xF15AE8", VA = "0xF15AE8")]
		public static void SegmentApproximationGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xF15DBC", Offset = "0xF15DBC", VA = "0xF15DBC")]
		public static void SegmentOrientationAnchorGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xF15FF8", Offset = "0xF15FF8", VA = "0xF15FF8")]
		public static void SegmentOrientationGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xF162A0", Offset = "0xF162A0", VA = "0xF162A0")]
		public static void SegmentTangentGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xF164F8", Offset = "0xF164F8", VA = "0xF164F8")]
		public static void ControlPointGizmo(CurvySplineSegment cp, bool selected, Color col)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xF16874", Offset = "0xF16874", VA = "0xF16874")]
		public static void BoundsGizmo(CurvySplineSegment cp, Color col)
		{
		}
	}
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D7E8C", Offset = "0x6D7E8C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D7E8C", Offset = "0x6D7E8C")]
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
			[Address(RVA = "0xF16A84", Offset = "0xF16A84", VA = "0xF16A84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000265")]
			[Address(RVA = "0xF16AEC", Offset = "0xF16AEC", VA = "0xF16AEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public static bool ShowApproximationGizmo
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0xF16B84", Offset = "0xF16B84", VA = "0xF16B84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000267")]
			[Address(RVA = "0xF16BEC", Offset = "0xF16BEC", VA = "0xF16BEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public static bool ShowTangentsGizmo
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0xF16C84", Offset = "0xF16C84", VA = "0xF16C84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000269")]
			[Address(RVA = "0xF16CEC", Offset = "0xF16CEC", VA = "0xF16CEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public static bool ShowOrientationGizmo
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0xF16D84", Offset = "0xF16D84", VA = "0xF16D84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026B")]
			[Address(RVA = "0xF16DEC", Offset = "0xF16DEC", VA = "0xF16DEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public static bool ShowLabelsGizmo
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0xF16E84", Offset = "0xF16E84", VA = "0xF16E84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026D")]
			[Address(RVA = "0xF16EEC", Offset = "0xF16EEC", VA = "0xF16EEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public static bool ShowMetadataGizmo
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0xF16F84", Offset = "0xF16F84", VA = "0xF16F84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026F")]
			[Address(RVA = "0xF16FEC", Offset = "0xF16FEC", VA = "0xF16FEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public static bool ShowBoundsGizmo
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0xF17084", Offset = "0xF17084", VA = "0xF17084")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000271")]
			[Address(RVA = "0xF170EC", Offset = "0xF170EC", VA = "0xF170EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public PoolManager PoolManager
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0xF17184", Offset = "0xF17184", VA = "0xF17184")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		public ComponentPool ControlPointPool
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0xF17238", Offset = "0xF17238", VA = "0xF17238")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public CurvyConnection[] Connections
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0xF17240", Offset = "0xF17240", VA = "0xF17240")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xF1728C", Offset = "0xF1728C", VA = "0xF1728C")]
		public CurvyConnection[] GetContainingConnections(params CurvySpline[] splines)
		{
			return null;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xF17B34", Offset = "0xF17B34", VA = "0xF17B34", Slot = "5")]
		public override void Awake()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xF17CF4", Offset = "0xF17CF4", VA = "0xF17CF4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xF17D84", Offset = "0xF17D84", VA = "0xF17D84")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6E5658", Offset = "0x6E5658")]
		private static void LoadRuntimeSettings()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xF180D4", Offset = "0xF180D4", VA = "0xF180D4")]
		public static void SaveRuntimeSettings()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xF18374", Offset = "0xF18374", VA = "0xF18374", Slot = "7")]
		public override void MergeDoubleLoaded(IDTSingleton newInstance)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xF18498", Offset = "0xF18498", VA = "0xF18498")]
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
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D7F30", Offset = "0x6D7F30")]
	public abstract class CurvyMetadataBase : MonoBehaviour
	{
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvySplineSegment mCP;

		[Token(Token = "0x1700006C")]
		public CurvySplineSegment ControlPoint
		{
			[Token(Token = "0x6000280")]
			[Address(RVA = "0xF18FAC", Offset = "0xF18FAC", VA = "0xF18FAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		public CurvySpline Spline
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0xF18FB4", Offset = "0xF18FB4", VA = "0xF18FB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xF1903C", Offset = "0xF1903C", VA = "0xF1903C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xF190B0", Offset = "0xF190B0", VA = "0xF190B0")]
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
		[Address(RVA = "0xF190D0", Offset = "0xF190D0", VA = "0xF190D0")]
		protected void NotifyModification()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xF19170", Offset = "0xF19170", VA = "0xF19170")]
		protected CurvyMetadataBase()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6D7FA0", Offset = "0x6D7FA0")]
	public class CGResourceManagerAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string ResourceName;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool ReadOnly;

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xEB974C", Offset = "0xEB974C", VA = "0xEB974C")]
		public CGResourceManagerAttribute(string resourceName)
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6D7FD8", Offset = "0x6D7FD8")]
	public sealed class CGResourceCollectionManagerAttribute : CGResourceManagerAttribute
	{
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool ShowCount;

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xEB9724", Offset = "0xEB9724", VA = "0xEB9724")]
		public CGResourceCollectionManagerAttribute(string resourceName)
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6D8010", Offset = "0x6D8010")]
	public sealed class CGDataReferenceSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly Type DataType;

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xF6F95C", Offset = "0xF6F95C", VA = "0xF6F95C")]
		public CGDataReferenceSelectorAttribute(Type dataType)
		{
		}
	}
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D8048", Offset = "0x6D8048")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D8048", Offset = "0x6D8048")]
	public class CurvyShape : DTVersionedMonoBehaviour
	{
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DA7D8", Offset = "0x6DA7D8")]
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
			[Address(RVA = "0xF19178", Offset = "0xF19178", VA = "0xF19178")]
			get
			{
				return default(CurvyPlane);
			}
			[Token(Token = "0x600028C")]
			[Address(RVA = "0xF19180", Offset = "0xF19180", VA = "0xF19180")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public bool Persistent
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0xF1919C", Offset = "0xF1919C", VA = "0xF1919C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600028E")]
			[Address(RVA = "0xF191A4", Offset = "0xF191A4", VA = "0xF191A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public CurvySpline Spline
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0xF191D8", Offset = "0xF191D8", VA = "0xF191D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		public static Dictionary<CurvyShapeInfo, Type> ShapeDefinitions
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0xF1A868", Offset = "0xF1A868", VA = "0xF1A868")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xF19288", Offset = "0xF19288", VA = "0xF19288")]
		private void Update()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xF193B8", Offset = "0xF193B8", VA = "0xF193B8", Slot = "4")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xF193D0", Offset = "0xF193D0", VA = "0xF193D0")]
		public void Delete()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xF192C8", Offset = "0xF192C8", VA = "0xF192C8")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xF194CC", Offset = "0xF194CC", VA = "0xF194CC")]
		public CurvyShape Replace(string menuName)
		{
			return null;
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xF19840", Offset = "0xF19840", VA = "0xF19840")]
		protected void PrepareSpline(CurvyInterpolation interpolation, CurvyOrientation orientation = CurvyOrientation.Dynamic, int cachedensity = 50, bool closed = true)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xF19ADC", Offset = "0xF19ADC", VA = "0xF19ADC")]
		protected void SetPosition(int no, Vector3 position)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xF19B80", Offset = "0xF19B80", VA = "0xF19B80")]
		protected void SetRotation(int no, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xF19C2C", Offset = "0xF19C2C", VA = "0xF19C2C")]
		protected void SetBezierHandles(int no, float distanceFrag)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xF19C34", Offset = "0xF19C34", VA = "0xF19C34")]
		protected void SetBezierHandles(int no, float inDistanceFrag, float outDistanceFrag)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xF19F3C", Offset = "0xF19F3C", VA = "0xF19F3C")]
		protected void SetBezierHandles(int no, Vector3 i, Vector3 o, Space space = Space.World)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xF19E98", Offset = "0xF19E98", VA = "0xF19E98")]
		public static void SetBezierHandles(float distanceFrag, bool setIn, bool setOut, params CurvySplineSegment[] controlPoints)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xF1A094", Offset = "0xF1A094", VA = "0xF1A094")]
		protected void SetCGHardEdges(params int[] controlPoints)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xF1A204", Offset = "0xF1A204", VA = "0xF1A204", Slot = "5")]
		protected virtual void ApplyShape()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xF1A208", Offset = "0xF1A208", VA = "0xF1A208")]
		protected void PrepareControlPoints(int count)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xF1A9B8", Offset = "0xF1A9B8", VA = "0xF1A9B8")]
		public static List<string> GetShapesMenuNames(bool only2D = false)
		{
			return null;
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xF1ABA8", Offset = "0xF1ABA8", VA = "0xF1ABA8")]
		public static List<string> GetShapesMenuNames(Type currentShapeType, out int currentIndex, bool only2D = false)
		{
			return null;
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xF1AE8C", Offset = "0xF1AE8C", VA = "0xF1AE8C")]
		public static string GetShapeName(Type shapeType)
		{
			return null;
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xF19644", Offset = "0xF19644", VA = "0xF19644")]
		public static Type GetShapeType(string menuName)
		{
			return null;
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xF19434", Offset = "0xF19434", VA = "0xF19434")]
		private void applyPlane()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xF1B060", Offset = "0xF1B060", VA = "0xF1B060")]
		private void applyRotation(Quaternion q)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xF1B30C", Offset = "0xF1B30C", VA = "0xF1B30C")]
		public CurvyShape()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6D80DC", Offset = "0x6D80DC")]
	public sealed class CurvyShapeInfo : Attribute
	{
		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Name;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly bool Is2D;

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xF1B414", Offset = "0xF1B414", VA = "0xF1B414")]
		public CurvyShapeInfo(string name, bool is2D = true)
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class CurvyShape2D : CurvyShape
	{
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xF1B3A8", Offset = "0xF1B3A8", VA = "0xF1B3A8")]
		public CurvyShape2D()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D8114", Offset = "0x6D8114")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D8114", Offset = "0x6D8114")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6D8114", Offset = "0x6D8114")]
	public class CurvySpline : DTVersionedMonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000091")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D81AC", Offset = "0x6D81AC")]
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
			[Address(RVA = "0x11F9788", Offset = "0x11F9788", VA = "0x11F9788")]
			public <>c()
			{
			}

			[Token(Token = "0x6000378")]
			[Address(RVA = "0x11F9790", Offset = "0x11F9790", VA = "0x11F9790")]
			internal void <.ctor>b__4_0(CurvySplineSegment controlPoint)
			{
			}

			[Token(Token = "0x6000379")]
			[Address(RVA = "0x11F97AC", Offset = "0x11F97AC", VA = "0x11F97AC")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA8C0", Offset = "0x6DA8C0")]
		private Action<CurvySpline> <OnGlobalCoordinatesChanged>k__BackingField;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6DA8D0", Offset = "0x6DA8D0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6DA8D0", Offset = "0x6DA8D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DA8D0", Offset = "0x6DA8D0")]
		private CurvyInterpolation m_Interpolation;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x6DA98C", Offset = "0x6DA98C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DA98C", Offset = "0x6DA98C")]
		private bool m_RestrictTo2D;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6DAA00", Offset = "0x6DAA00")]
		[SerializeField]
		private bool m_Closed;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6DAA4C", Offset = "0x6DAA4C")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DAA4C", Offset = "0x6DAA4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DAA4C", Offset = "0x6DAA4C")]
		private bool m_AutoEndTangents;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6DAAE8", Offset = "0x6DAAE8")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DAAE8", Offset = "0x6DAAE8")]
		private CurvyOrientation m_Orientation;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6DAB58", Offset = "0x6DAB58")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6DAB58", Offset = "0x6DAB58")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x6DAB58", Offset = "0x6DAB58")]
		private float m_AutoHandleDistance;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6DAC88", Offset = "0x6DAC88")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6DAC88", Offset = "0x6DAC88")]
		[AttributeAttribute(Name = "GroupActionAttribute", RVA = "0x6DAC88", Offset = "0x6DAC88")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x6DAC88", Offset = "0x6DAC88")]
		private float m_Tension;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6DADCC", Offset = "0x6DADCC")]
		[SerializeField]
		private float m_Continuity;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6DAE18", Offset = "0x6DAE18")]
		[SerializeField]
		private float m_Bias;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6DAE64", Offset = "0x6DAE64")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x6DAE64", Offset = "0x6DAE64")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DAE64", Offset = "0x6DAE64")]
		[SerializeField]
		private Color m_GizmoColor;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DAF44", Offset = "0x6DAF44")]
		[SerializeField]
		private Color m_GizmoSelectionColor;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6DAFAC", Offset = "0x6DAFAC")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6DAFAC", Offset = "0x6DAFAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DAFAC", Offset = "0x6DAFAC")]
		private int m_CacheDensity;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DB068", Offset = "0x6DB068")]
		private float m_MaxPointsPerUnit;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DB0B4", Offset = "0x6DB0B4")]
		private bool m_UsePooling;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DB100", Offset = "0x6DB100")]
		private bool m_UseThreading;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6DB14C", Offset = "0x6DB14C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DB14C", Offset = "0x6DB14C")]
		private bool m_CheckTransform;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CurvyUpdateMethod m_UpdateIn;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x6DB1CC", Offset = "0x6DB1CC")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6DB1CC", Offset = "0x6DB1CC")]
		[SerializeField]
		protected CurvySplineEvent m_OnRefresh;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6DB254", Offset = "0x6DB254")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x6DB254", Offset = "0x6DB254")]
		[SerializeField]
		protected CurvySplineEvent m_OnAfterControlPointChanges;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6DB2BC", Offset = "0x6DB2BC")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x6DB2BC", Offset = "0x6DB2BC")]
		[SerializeField]
		protected CurvyControlPointEvent m_OnBeforeControlPointAdd;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x6DB324", Offset = "0x6DB324")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6DB324", Offset = "0x6DB324")]
		protected CurvyControlPointEvent m_OnAfterControlPointAdd;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6DB390", Offset = "0x6DB390")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x6DB390", Offset = "0x6DB390")]
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
			[Address(RVA = "0xF1B960", Offset = "0xF1B960", VA = "0xF1B960")]
			get
			{
				return default(CurvyInterpolation);
			}
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0xF1998C", Offset = "0xF1998C", VA = "0xF1998C")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public bool RestrictTo2D
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0xF1BD88", Offset = "0xF1BD88", VA = "0xF1BD88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0xF19AB0", Offset = "0xF19AB0", VA = "0xF19AB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public float AutoHandleDistance
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0xF1BD90", Offset = "0xF1BD90", VA = "0xF1BD90")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0xF1BD98", Offset = "0xF1BD98", VA = "0xF1BD98")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public bool Closed
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0xF1BDE4", Offset = "0xF1BDE4", VA = "0xF1BDE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0xF19A58", Offset = "0xF19A58", VA = "0xF19A58")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public bool AutoEndTangents
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0xF1BDEC", Offset = "0xF1BDEC", VA = "0xF1BDEC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0xF1BD08", Offset = "0xF1BD08", VA = "0xF1BD08")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public CurvyOrientation Orientation
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0xF1BE18", Offset = "0xF1BE18", VA = "0xF1BE18")]
			get
			{
				return default(CurvyOrientation);
			}
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0xF199D8", Offset = "0xF199D8", VA = "0xF199D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public CurvyUpdateMethod UpdateIn
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0xF1BE20", Offset = "0xF1BE20", VA = "0xF1BE20")]
			get
			{
				return default(CurvyUpdateMethod);
			}
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0xF1BE28", Offset = "0xF1BE28", VA = "0xF1BE28")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public Color GizmoColor
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0xF1BE3C", Offset = "0xF1BE3C", VA = "0xF1BE3C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0xF1BE48", Offset = "0xF1BE48", VA = "0xF1BE48")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public Color GizmoSelectionColor
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0xF1BEB4", Offset = "0xF1BEB4", VA = "0xF1BEB4")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0xF1BEC0", Offset = "0xF1BEC0", VA = "0xF1BEC0")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public int CacheDensity
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0xF1BF2C", Offset = "0xF1BF2C", VA = "0xF1BF2C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0xF199FC", Offset = "0xF199FC", VA = "0xF199FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public float MaxPointsPerUnit
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0xF1BF34", Offset = "0xF1BF34", VA = "0xF1BF34")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0xF1BF3C", Offset = "0xF1BF3C", VA = "0xF1BF3C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public bool UsePooling
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0xF1BF98", Offset = "0xF1BF98", VA = "0xF1BF98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0xF1BFA0", Offset = "0xF1BFA0", VA = "0xF1BFA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public bool UseThreading
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0xF1BFC0", Offset = "0xF1BFC0", VA = "0xF1BFC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0xF1BFC8", Offset = "0xF1BFC8", VA = "0xF1BFC8")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public bool CheckTransform
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0xF1BFE8", Offset = "0xF1BFE8", VA = "0xF1BFE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0xF1BFF0", Offset = "0xF1BFF0", VA = "0xF1BFF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public float Tension
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0xF1C01C", Offset = "0xF1C01C", VA = "0xF1C01C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0xF1C024", Offset = "0xF1C024", VA = "0xF1C024")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public float Continuity
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0xF1C044", Offset = "0xF1C044", VA = "0xF1C044")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0xF1C04C", Offset = "0xF1C04C", VA = "0xF1C04C")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public float Bias
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0xF1C06C", Offset = "0xF1C06C", VA = "0xF1C06C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0xF1C074", Offset = "0xF1C074", VA = "0xF1C074")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public bool IsInitialized
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0xF1C094", Offset = "0xF1C094", VA = "0xF1C094")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000084")]
		public Bounds Bounds
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0xF1C09C", Offset = "0xF1C09C", VA = "0xF1C09C")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000085")]
		public int Count
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0xF1C2BC", Offset = "0xF1C2BC", VA = "0xF1C2BC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000086")]
		public int ControlPointCount
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0xF19E4C", Offset = "0xF19E4C", VA = "0xF19E4C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000087")]
		public int CacheSize
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0xF1C43C", Offset = "0xF1C43C", VA = "0xF1C43C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000088")]
		public float Length
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0xF1C51C", Offset = "0xF1C51C", VA = "0xF1C51C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000089")]
		public bool Dirty
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0xF1C3A4", Offset = "0xF1C3A4", VA = "0xF1C3A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008A")]
		public CurvySplineSegment Item
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0xF1C31C", Offset = "0xF1C31C", VA = "0xF1C31C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008B")]
		public ReadOnlyCollection<CurvySplineSegment> ControlPointsList
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0xF17ABC", Offset = "0xF17ABC", VA = "0xF17ABC")]
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
			[Address(RVA = "0xF1C618", Offset = "0xF1C618", VA = "0xF1C618")]
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
			[Address(RVA = "0xF1A5E8", Offset = "0xF1A5E8", VA = "0xF1A5E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		public CurvySplineSegment FirstSegment
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0xF1CCE4", Offset = "0xF1CCE4", VA = "0xF1CCE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		public CurvySplineSegment LastSegment
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0xF1CD18", Offset = "0xF1CD18", VA = "0xF1CD18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		public bool GlobalCoordinatesChangedThisFrame
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0xF1CD4C", Offset = "0xF1CD4C", VA = "0xF1CD4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		public Action<CurvySpline> OnGlobalCoordinatesChanged
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0xF1CD54", Offset = "0xF1CD54", VA = "0xF1CD54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5668", Offset = "0x6E5668")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0xF1CD5C", Offset = "0xF1CD5C", VA = "0xF1CD5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5678", Offset = "0x6E5678")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public CurvySplineEvent OnRefresh
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0xF1CD64", Offset = "0xF1CD64", VA = "0xF1CD64")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0xF1CD6C", Offset = "0xF1CD6C", VA = "0xF1CD6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public CurvySplineEvent OnAfterControlPointChanges
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0xF1CD84", Offset = "0xF1CD84", VA = "0xF1CD84")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xF1CD8C", Offset = "0xF1CD8C", VA = "0xF1CD8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public CurvyControlPointEvent OnBeforeControlPointAdd
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0xF1CDA4", Offset = "0xF1CDA4", VA = "0xF1CDA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0xF1CDAC", Offset = "0xF1CDAC", VA = "0xF1CDAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public CurvyControlPointEvent OnAfterControlPointAdd
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0xF1CDC4", Offset = "0xF1CDC4", VA = "0xF1CDC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0xF1CDCC", Offset = "0xF1CDCC", VA = "0xF1CDCC")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public CurvyControlPointEvent OnBeforeControlPointDelete
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0xF1CDE4", Offset = "0xF1CDE4", VA = "0xF1CDE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0xF1CDEC", Offset = "0xF1CDEC", VA = "0xF1CDEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		private List<CurvySplineSegment> Segments
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0xF1C408", Offset = "0xF1C408", VA = "0xF1C408")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xF1B460", Offset = "0xF1B460", VA = "0xF1B460")]
		public CurvySpline()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xF1CE04", Offset = "0xF1CE04", VA = "0xF1CE04")]
		public static CurvySpline Create()
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xF1D01C", Offset = "0xF1D01C", VA = "0xF1D01C")]
		public static CurvySpline Create(CurvySpline takeOptionsFrom)
		{
			return null;
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xF1D1B8", Offset = "0xF1D1B8", VA = "0xF1D1B8")]
		public static int CalculateCacheSize(int density, float splineLength, float maxPointsPerUnit)
		{
			return default(int);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xF1D240", Offset = "0xF1D240", VA = "0xF1D240")]
		public static float CalculateSamplingPointsPerUnit(int density, float maxPointsPerUnit)
		{
			return default(float);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xF1D308", Offset = "0xF1D308", VA = "0xF1D308")]
		public static Vector3 Bezier(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xF1D3F8", Offset = "0xF1D3F8", VA = "0xF1D3F8")]
		public static Vector3 BezierTangent(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xF1D4C4", Offset = "0xF1D4C4", VA = "0xF1D4C4")]
		public static Vector3 CatmullRom(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xF1D5E4", Offset = "0xF1D5E4", VA = "0xF1D5E4")]
		public static Vector3 TCB(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f, float FT0, float FC0, float FB0, float FT1, float FC1, float FB1)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xF1D7FC", Offset = "0xF1D7FC", VA = "0xF1D7FC")]
		[NotNull]
		public static CurvySplineSegment GetFollowUpHeadingControlPoint(CurvySplineSegment followUp, ConnectionHeadingEnum headingDirection)
		{
			return null;
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xF1DA08", Offset = "0xF1DA08", VA = "0xF1DA08")]
		public Vector3 Interpolate(float tf, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xF1DAC0", Offset = "0xF1DAC0", VA = "0xF1DAC0")]
		public Vector3 InterpolateFast(float tf, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xF1DB48", Offset = "0xF1DB48", VA = "0xF1DB48")]
		public Vector3 InterpolateByDistance(float distance, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xF1DC2C", Offset = "0xF1DC2C", VA = "0xF1DC2C")]
		public Vector3 InterpolateByDistanceFast(float distance, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xF1DC5C", Offset = "0xF1DC5C", VA = "0xF1DC5C")]
		public Vector3 GetTangent(float tf, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xF1DCE4", Offset = "0xF1DCE4", VA = "0xF1DCE4")]
		public Vector3 GetTangent(float tf, Vector3 position, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xF1DD94", Offset = "0xF1DD94", VA = "0xF1DD94")]
		public Vector3 GetTangentFast(float tf, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xF1DE1C", Offset = "0xF1DE1C", VA = "0xF1DE1C")]
		public Vector3 GetTangentByDistance(float distance, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xF1DE4C", Offset = "0xF1DE4C", VA = "0xF1DE4C")]
		public Vector3 GetTangentByDistanceFast(float distance, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xF1DE7C", Offset = "0xF1DE7C", VA = "0xF1DE7C")]
		public void InterpolateAndGetTangent(float tf, out Vector3 position, out Vector3 tangent, Space space = Space.Self)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xF1DF2C", Offset = "0xF1DF2C", VA = "0xF1DF2C")]
		public void InterpolateAndGetTangentFast(float tf, out Vector3 position, out Vector3 tangent, Space space = Space.Self)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xF1DFDC", Offset = "0xF1DFDC", VA = "0xF1DFDC")]
		public Vector3 GetOrientationUpFast(float tf, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xF1E064", Offset = "0xF1E064", VA = "0xF1E064")]
		public Quaternion GetOrientationFast(float tf, bool inverse = false, Space space = Space.Self)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xF1E0FC", Offset = "0xF1E0FC", VA = "0xF1E0FC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6E5698", Offset = "0x6E5698")]
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
		[Address(RVA = "0xF1E14C", Offset = "0xF1E14C", VA = "0xF1E14C")]
		public float TFToDistance(float tf, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xF1E220", Offset = "0xF1E220", VA = "0xF1E220")]
		public CurvySplineSegment TFToSegment(float tf, out float localF, out bool isOnSegmentStart, out bool isOnSegmentEnd, CurvyClamping clamping)
		{
			return null;
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xF1E1F0", Offset = "0xF1E1F0", VA = "0xF1E1F0")]
		public CurvySplineSegment TFToSegment(float tf, out float localF, CurvyClamping clamping)
		{
			return null;
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xF1E2FC", Offset = "0xF1E2FC", VA = "0xF1E2FC")]
		public CurvySplineSegment TFToSegment(float tf, CurvyClamping clamping)
		{
			return null;
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xF1E334", Offset = "0xF1E334", VA = "0xF1E334")]
		public CurvySplineSegment TFToSegment(float tf)
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xF1DA90", Offset = "0xF1DA90", VA = "0xF1DA90")]
		public CurvySplineSegment TFToSegment(float tf, out float localF)
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xF1E36C", Offset = "0xF1E36C", VA = "0xF1E36C")]
		public float SegmentToTF(CurvySplineSegment segment)
		{
			return default(float);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xF1E384", Offset = "0xF1E384", VA = "0xF1E384")]
		public float SegmentToTF(CurvySplineSegment segment, float localF)
		{
			return default(float);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xF1DB78", Offset = "0xF1DB78", VA = "0xF1DB78")]
		public float DistanceToTF(float distance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xF1E458", Offset = "0xF1E458", VA = "0xF1E458")]
		public CurvySplineSegment DistanceToSegment(float distance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return null;
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xF1E428", Offset = "0xF1E428", VA = "0xF1E428")]
		public CurvySplineSegment DistanceToSegment(float distance, out float localDistance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xF1E490", Offset = "0xF1E490", VA = "0xF1E490")]
		public CurvySplineSegment DistanceToSegment(float distance, out float localDistance, out bool isOnSegmentStart, out bool isOnSegmentEnd, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xF1E620", Offset = "0xF1E620", VA = "0xF1E620")]
		public float ClampDistance(float distance, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xF1E65C", Offset = "0xF1E65C", VA = "0xF1E65C")]
		public float ClampDistance(float distance, CurvyClamping clamping, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xF1E6B0", Offset = "0xF1E6B0", VA = "0xF1E6B0")]
		public float ClampDistance(float distance, ref int dir, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xF1E6F4", Offset = "0xF1E6F4", VA = "0xF1E6F4")]
		public float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xF1E750", Offset = "0xF1E750", VA = "0xF1E750")]
		public CurvySplineSegment Add()
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xF1E75C", Offset = "0xF1E75C", VA = "0xF1E75C")]
		public CurvySplineSegment Add(Vector3 controlPointPosition, Space space)
		{
			return null;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xF1E9F0", Offset = "0xF1E9F0", VA = "0xF1E9F0")]
		public CurvySplineSegment[] Add(params Vector3[] controlPointsLocalPositions)
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xF1EB54", Offset = "0xF1EB54", VA = "0xF1EB54")]
		public CurvySplineSegment[] Add(Vector3[] controlPointsPositions, Space space)
		{
			return null;
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xF1ECC4", Offset = "0xF1ECC4", VA = "0xF1ECC4")]
		public CurvySplineSegment InsertBefore(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xF1EE4C", Offset = "0xF1EE4C", VA = "0xF1EE4C")]
		public CurvySplineSegment InsertBefore([CanBeNull] CurvySplineSegment controlPoint, Vector3 position, bool skipRefreshingAndEvents = false, Space space = Space.World)
		{
			return null;
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xF1A450", Offset = "0xF1A450", VA = "0xF1A450")]
		public CurvySplineSegment InsertAfter(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xF1E85C", Offset = "0xF1E85C", VA = "0xF1E85C")]
		public CurvySplineSegment InsertAfter([CanBeNull] CurvySplineSegment controlPoint, Vector3 position, bool skipRefreshingAndEvents = false, Space space = Space.World)
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xF1F39C", Offset = "0xF1F39C", VA = "0xF1F39C")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xF1F78C", Offset = "0xF1F78C", VA = "0xF1F78C")]
		public void Delete(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xF1A61C", Offset = "0xF1A61C", VA = "0xF1A61C")]
		public void Delete(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents, bool isUndoableDeletion)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xF18DF4", Offset = "0xF18DF4", VA = "0xF18DF4")]
		public Vector3[] GetApproximation(Space space = Space.Self)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xF1F9DC", Offset = "0xF1F9DC", VA = "0xF1F9DC")]
		public Vector3[] GetApproximation(float fromTF, float toTF, bool includeEndPoint = true, Space space = Space.Self)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xF1FEC0", Offset = "0xF1FEC0", VA = "0xF1FEC0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6E56D0", Offset = "0x6E56D0")]
		public Vector3[] GetApproximationPoints(float fromTF, float toTF, bool includeEndPoint = true, Space space = Space.Self)
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xF1FEC8", Offset = "0xF1FEC8", VA = "0xF1FEC8")]
		public Vector3[] GetApproximationT(Space space = Space.Self)
		{
			return null;
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xF20070", Offset = "0xF20070", VA = "0xF20070")]
		public Vector3[] GetApproximationUpVectors(Space space = Space.Self)
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xF20218", Offset = "0xF20218", VA = "0xF20218")]
		public float GetNearestPointTF(Vector3 localPosition)
		{
			return default(float);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xF20494", Offset = "0xF20494", VA = "0xF20494")]
		public float GetNearestPointTF(Vector3 position, Space space)
		{
			return default(float);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xF204D4", Offset = "0xF204D4", VA = "0xF204D4")]
		public float GetNearestPointTF(Vector3 localPosition, out Vector3 nearestPoint)
		{
			return default(float);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xF2050C", Offset = "0xF2050C", VA = "0xF2050C")]
		public float GetNearestPointTF(Vector3 position, out Vector3 nearestPoint, Space space)
		{
			return default(float);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xF20544", Offset = "0xF20544", VA = "0xF20544")]
		public float GetNearestPointTF(Vector3 position, int searchStartSegmentIndex = 0, int searchEndSegmentIndex = -1, Space space = Space.Self)
		{
			return default(float);
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xF20584", Offset = "0xF20584", VA = "0xF20584")]
		public float GetNearestPointTF(Vector3 position, out Vector3 nearestPoint, int searchStartSegmentIndex = 0, int searchEndSegmentIndex = -1, Space space = Space.Self)
		{
			return default(float);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xF20258", Offset = "0xF20258", VA = "0xF20258")]
		public float GetNearestPointTF(Vector3 position, out Vector3 nearestPoint, [CanBeNull] out CurvySplineSegment nearestSegment, out float nearestPointLocalF, int searchStartSegmentIndex = 0, int searchEndSegmentIndex = -1, Space space = Space.Self)
		{
			return default(float);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xF194A4", Offset = "0xF194A4", VA = "0xF194A4")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xF19498", Offset = "0xF19498", VA = "0xF19498")]
		public void SetDirtyAll()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xF1BA80", Offset = "0xF1BA80", VA = "0xF1BA80")]
		public void SetDirtyAll(SplineDirtyingType dirtyingType, bool dirtyConnectedControlPoints)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xF215C4", Offset = "0xF215C4", VA = "0xF215C4")]
		public void SetDirty(CurvySplineSegment dirtyControlPoint, SplineDirtyingType dirtyingType)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xF21B44", Offset = "0xF21B44", VA = "0xF21B44")]
		public void SetDirtyPartial(CurvySplineSegment dirtyControlPoint, SplineDirtyingType dirtyingType)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xF21B9C", Offset = "0xF21B9C", VA = "0xF21B9C")]
		public Vector3 ToWorldPosition(Vector3 localPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xF21BB8", Offset = "0xF21BB8", VA = "0xF21BB8")]
		public Vector3 ToWorldDirection(Vector3 localDirection)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xF21BD4", Offset = "0xF21BD4", VA = "0xF21BD4")]
		public Vector3 ToLocalPosition(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xF21BF0", Offset = "0xF21BF0", VA = "0xF21BF0")]
		public Vector3 ToLocalDirection(Vector3 localDirection)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xF21C0C", Offset = "0xF21C0C", VA = "0xF21C0C")]
		public void SyncSplineFromHierarchy()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xF21EF4", Offset = "0xF21EF4", VA = "0xF21EF4")]
		public bool IsPlanar(out int ignoreAxis)
		{
			return default(bool);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xF21F70", Offset = "0xF21F70", VA = "0xF21F70")]
		public bool IsPlanar(out bool xplanar, out bool yplanar, out bool zplanar)
		{
			return default(bool);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xF22194", Offset = "0xF22194", VA = "0xF22194")]
		public bool IsPlanar(CurvyPlane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xF22358", Offset = "0xF22358", VA = "0xF22358")]
		public void MakePlanar(CurvyPlane plane)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xF227A4", Offset = "0xF227A4", VA = "0xF227A4")]
		public void MakePlanar(int axis)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xF2295C", Offset = "0xF2295C", VA = "0xF2295C")]
		public void Subdivide([Optional] CurvySplineSegment fromCP, [Optional] CurvySplineSegment toCP)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xF23000", Offset = "0xF23000", VA = "0xF23000")]
		public void Simplify([Optional] CurvySplineSegment fromCP, [Optional] CurvySplineSegment toCP)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xF232FC", Offset = "0xF232FC", VA = "0xF232FC")]
		public void Equalize([Optional] CurvySplineSegment fromCP, [Optional] CurvySplineSegment toCP)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xF2376C", Offset = "0xF2376C", VA = "0xF2376C")]
		public void Normalize()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xF23928", Offset = "0xF23928", VA = "0xF23928")]
		public Vector3 SetPivot(float xRel = 0f, float yRel = 0f, float zRel = 0f, bool preview = false)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xF23B88", Offset = "0xF23B88", VA = "0xF23B88")]
		public void Flip()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xF23E74", Offset = "0xF23E74", VA = "0xF23E74")]
		public void MoveControlPoints(int startIndex, int count, CurvySplineSegment destCP)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xF24284", Offset = "0xF24284", VA = "0xF24284")]
		public void JoinWith(CurvySplineSegment destCP)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xF2436C", Offset = "0xF2436C", VA = "0xF2436C")]
		public CurvySpline Split(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xF24664", Offset = "0xF24664", VA = "0xF24664")]
		public void SetFirstControlPoint(CurvySplineSegment controlPoint)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xF247FC", Offset = "0xF247FC", VA = "0xF247FC")]
		public bool IsControlPointAnOrientationAnchor(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xF2494C", Offset = "0xF2494C", VA = "0xF2494C")]
		public bool CanControlPointHaveFollowUp(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xF1EEEC", Offset = "0xF1EEEC", VA = "0xF1EEEC")]
		public short GetControlPointIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xF24620", Offset = "0xF24620", VA = "0xF24620")]
		public short GetSegmentIndex(CurvySplineSegment segment)
		{
			return default(short);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xF1D95C", Offset = "0xF1D95C", VA = "0xF1D95C")]
		[CanBeNull]
		public CurvySplineSegment GetNextControlPoint(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xF24990", Offset = "0xF24990", VA = "0xF24990")]
		[CanBeNull]
		public short GetNextControlPointIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xF249D4", Offset = "0xF249D4", VA = "0xF249D4")]
		[CanBeNull]
		public CurvySplineSegment GetNextControlPointUsingFollowUp(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xF1D8B0", Offset = "0xF1D8B0", VA = "0xF1D8B0")]
		[CanBeNull]
		public CurvySplineSegment GetPreviousControlPoint(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xF24AE0", Offset = "0xF24AE0", VA = "0xF24AE0")]
		[CanBeNull]
		public short GetPreviousControlPointIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xF24B24", Offset = "0xF24B24", VA = "0xF24B24")]
		[CanBeNull]
		public CurvySplineSegment GetPreviousControlPointUsingFollowUp(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xF1FE14", Offset = "0xF1FE14", VA = "0xF1FE14")]
		[CanBeNull]
		public CurvySplineSegment GetNextSegment(CurvySplineSegment segment)
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xF24C30", Offset = "0xF24C30", VA = "0xF24C30")]
		[CanBeNull]
		public CurvySplineSegment GetPreviousSegment(CurvySplineSegment segment)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xF1E3E4", Offset = "0xF1E3E4", VA = "0xF1E3E4")]
		public bool IsControlPointASegment(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xF24908", Offset = "0xF24908", VA = "0xF24908")]
		public bool IsControlPointVisible(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xF24CDC", Offset = "0xF24CDC", VA = "0xF24CDC")]
		public short GetControlPointOrientationAnchorIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xF24D20", Offset = "0xF24D20", VA = "0xF24D20")]
		public void SetFromString(string fieldAndValue)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xF252FC", Offset = "0xF252FC", VA = "0xF252FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xF253A0", Offset = "0xF253A0", VA = "0xF253A0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xF1CFD8", Offset = "0xF1CFD8", VA = "0xF1CFD8")]
		public void Start()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xF25434", Offset = "0xF25434", VA = "0xF25434")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xF2543C", Offset = "0xF2543C", VA = "0xF2543C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xF255CC", Offset = "0xF255CC", VA = "0xF255CC", Slot = "4")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xF25778", Offset = "0xF25778", VA = "0xF25778")]
		private void Update()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xF25AB4", Offset = "0xF25AB4", VA = "0xF25AB4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xF25AF8", Offset = "0xF25AF8", VA = "0xF25AF8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xF253F4", Offset = "0xF253F4", VA = "0xF253F4")]
		private void Initialize()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xF257B8", Offset = "0xF257B8", VA = "0xF257B8")]
		private void doUpdate()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xF1BDF4", Offset = "0xF1BDF4", VA = "0xF1BDF4")]
		private bool canHaveManualEndCP()
		{
			return default(bool);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xF2161C", Offset = "0xF2161C", VA = "0xF2161C")]
		private void SetDirty(CurvySplineSegment controlPoint, SplineDirtyingType dirtyingType, CurvySplineSegment previousControlPoint, CurvySplineSegment nextControlPoint, bool ignoreConnectionOfInputControlPoint)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xF21574", Offset = "0xF21574", VA = "0xF21574")]
		private void SetDirtyingFlags(SplineDirtyingType dirtyingType)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xF23E08", Offset = "0xF23E08", VA = "0xF23E08")]
		private void ReverseControlPoints()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xF25BB4", Offset = "0xF25BB4", VA = "0xF25BB4")]
		private static short GetNextControlPointIndex(short controlPointIndex, bool isSplineClosed, int controlPointsCount)
		{
			return default(short);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xF25BE4", Offset = "0xF25BE4", VA = "0xF25BE4")]
		private static short GetPreviousControlPointIndex(short controlPointIndex, bool isSplineClosed, int controlPointsCount)
		{
			return default(short);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xF25C18", Offset = "0xF25C18", VA = "0xF25C18")]
		private static bool IsControlPointASegment(int controlPointIndex, int controlPointCount, bool isClosed, bool notAutoEndTangentsAndIsCatmullRomOrTCB)
		{
			return default(bool);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xF21D1C", Offset = "0xF21D1C", VA = "0xF21D1C")]
		private void AddControlPoint(CurvySplineSegment item)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xF240B0", Offset = "0xF240B0", VA = "0xF240B0")]
		private void InsertControlPoint(int index, CurvySplineSegment item)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xF1F798", Offset = "0xF1F798", VA = "0xF1F798")]
		private void RemoveControlPoint(CurvySplineSegment item)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xF1F618", Offset = "0xF1F618", VA = "0xF1F618")]
		private void ClearControlPoints()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xF1B968", Offset = "0xF1B968", VA = "0xF1B968")]
		internal void InvalidateControlPointsRelationshipCacheINTERNAL()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xF1C64C", Offset = "0xF1C64C", VA = "0xF1C64C")]
		private void RebuildControlPointsRelationshipCache(bool fixNonCoherentControlPoints)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xF205BC", Offset = "0xF205BC", VA = "0xF205BC")]
		private void ProcessDirtyControlPoints()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xF25F34", Offset = "0xF25F34", VA = "0xF25F34")]
		private void PrepareThreadCompatibleData()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xF25C50", Offset = "0xF25C50", VA = "0xF25C50")]
		private void FillDirtyCpsExtendedList()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xF19164", Offset = "0xF19164", VA = "0xF19164")]
		internal void NotifyMetaDataModification()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xF26100", Offset = "0xF26100", VA = "0xF26100")]
		private void SyncHierarchyFromSpline(bool renameControlPoints = true)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xF25B3C", Offset = "0xF25B3C", VA = "0xF25B3C")]
		private void UpdatedLastProcessedGlobalCoordinates()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xF1EF30", Offset = "0xF1EF30", VA = "0xF1EF30")]
		private CurvySplineSegment InsertAt(CurvySplineSegment controlPoint, Vector3 position, int insertionIndex, CurvyControlPointEventArgs.ModeEnum insertionMode, bool skipRefreshingAndEvents, Space space)
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xF2150C", Offset = "0xF2150C", VA = "0xF2150C")]
		private CurvySplineEventArgs OnRefreshEvent(CurvySplineEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xF1E7F4", Offset = "0xF1E7F4", VA = "0xF1E7F4")]
		private CurvyControlPointEventArgs OnBeforeControlPointAddEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xF1E920", Offset = "0xF1E920", VA = "0xF1E920")]
		private CurvyControlPointEventArgs OnAfterControlPointAddEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xF1F5B0", Offset = "0xF1F5B0", VA = "0xF1F5B0")]
		private CurvyControlPointEventArgs OnBeforeControlPointDeleteEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xF1E988", Offset = "0xF1E988", VA = "0xF1E988")]
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
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D81BC", Offset = "0x6D81BC")]
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
				[Address(RVA = "0x11F9834", Offset = "0x11F9834", VA = "0x11F9834")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000C3")]
			internal short SegmentIndex
			{
				[Token(Token = "0x6000405")]
				[Address(RVA = "0x11F983C", Offset = "0x11F983C", VA = "0x11F983C")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x170000C4")]
			internal short ControlPointIndex
			{
				[Token(Token = "0x6000406")]
				[Address(RVA = "0x11F9844", Offset = "0x11F9844", VA = "0x11F9844")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x170000C5")]
			internal short NextControlPointIndex
			{
				[Token(Token = "0x6000407")]
				[Address(RVA = "0x11F984C", Offset = "0x11F984C", VA = "0x11F984C")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x170000C6")]
			internal short PreviousControlPointIndex
			{
				[Token(Token = "0x6000408")]
				[Address(RVA = "0x11F9854", Offset = "0x11F9854", VA = "0x11F9854")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x170000C7")]
			internal bool PreviousControlPointIsSegment
			{
				[Token(Token = "0x6000409")]
				[Address(RVA = "0x11F985C", Offset = "0x11F985C", VA = "0x11F985C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000C8")]
			internal bool NextControlPointIsSegment
			{
				[Token(Token = "0x600040A")]
				[Address(RVA = "0x11F9864", Offset = "0x11F9864", VA = "0x11F9864")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000C9")]
			internal bool CanHaveFollowUp
			{
				[Token(Token = "0x600040B")]
				[Address(RVA = "0x11F986C", Offset = "0x11F986C", VA = "0x11F986C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000CA")]
			internal bool IsSegment
			{
				[Token(Token = "0x600040C")]
				[Address(RVA = "0x11F9874", Offset = "0x11F9874", VA = "0x11F9874")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000CB")]
			internal short OrientationAnchorIndex
			{
				[Token(Token = "0x600040D")]
				[Address(RVA = "0x11F9884", Offset = "0x11F9884", VA = "0x11F9884")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x600040E")]
			[Address(RVA = "0x11F988C", Offset = "0x11F988C", VA = "0x11F988C")]
			internal ControlPointExtrinsicProperties(bool isVisible, short segmentIndex, short controlPointIndex, short previousControlPointIndex, short nextControlPointIndex, bool previousControlPointIsSegment, bool nextControlPointIsSegment, bool canHaveFollowUp, short orientationAnchorIndex)
			{
			}

			[Token(Token = "0x600040F")]
			[Address(RVA = "0x11F98CC", Offset = "0x11F98CC", VA = "0x11F98CC", Slot = "4")]
			public bool Equals(ControlPointExtrinsicProperties other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000410")]
			[Address(RVA = "0x11F9990", Offset = "0x11F9990", VA = "0x11F9990", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000411")]
			[Address(RVA = "0x11F9A18", Offset = "0x11F9A18", VA = "0x11F9A18", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000412")]
			[Address(RVA = "0x11F9B6C", Offset = "0x11F9B6C", VA = "0x11F9B6C")]
			public static bool operator ==(ControlPointExtrinsicProperties left, ControlPointExtrinsicProperties right)
			{
				return default(bool);
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0x11F9B9C", Offset = "0x11F9B9C", VA = "0x11F9B9C")]
			public static bool operator !=(ControlPointExtrinsicProperties left, ControlPointExtrinsicProperties right)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000095")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D8218", Offset = "0x6D8218")]
		private sealed class <>c__DisplayClass102_0
		{
			[Token(Token = "0x40001E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HashSet<UnityEngine.Component> result;

			[Token(Token = "0x6000414")]
			[Address(RVA = "0x11F97C8", Offset = "0x11F97C8", VA = "0x11F97C8")]
			public <>c__DisplayClass102_0()
			{
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0x11F97D0", Offset = "0x11F97D0", VA = "0x11F97D0")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB3F8", Offset = "0x6DB3F8")]
		private float <Length>k__BackingField;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB408", Offset = "0x6DB408")]
		private float <Distance>k__BackingField;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB418", Offset = "0x6DB418")]
		private float <TF>k__BackingField;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6DB428", Offset = "0x6DB428")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x6DB428", Offset = "0x6DB428")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DB428", Offset = "0x6DB428")]
		private bool m_AutoBakeOrientation;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6DB4DC", Offset = "0x6DB4DC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DB4DC", Offset = "0x6DB4DC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DB4DC", Offset = "0x6DB4DC")]
		[SerializeField]
		private bool m_OrientationAnchor;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DB5D4", Offset = "0x6DB5D4")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DB5D4", Offset = "0x6DB5D4")]
		[SerializeField]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6DB5D4", Offset = "0x6DB5D4")]
		private CurvyOrientationSwirl m_Swirl;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DB6E0", Offset = "0x6DB6E0")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6DB6E0", Offset = "0x6DB6E0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DB6E0", Offset = "0x6DB6E0")]
		[SerializeField]
		private float m_SwirlTurns;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6DB83C", Offset = "0x6DB83C")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x6DB83C", Offset = "0x6DB83C")]
		[SerializeField]
		private bool m_AutoHandles;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6DB934", Offset = "0x6DB934")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DB934", Offset = "0x6DB934")]
		[SerializeField]
		private float m_AutoHandleDistance;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6DBA2C", Offset = "0x6DBA2C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6DBA2C", Offset = "0x6DBA2C")]
		private Vector3 m_HandleIn;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6DBAE0", Offset = "0x6DBAE0")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6DBAE0", Offset = "0x6DBAE0")]
		private Vector3 m_HandleOut;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x6DBB94", Offset = "0x6DBB94")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DBB94", Offset = "0x6DBB94")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6DBB94", Offset = "0x6DBB94")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6DBB94", Offset = "0x6DBB94")]
		[AttributeAttribute(Name = "GroupActionAttribute", RVA = "0x6DBB94", Offset = "0x6DBB94")]
		private bool m_OverrideGlobalTension;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DBD14", Offset = "0x6DBD14")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6DBD14", Offset = "0x6DBD14")]
		[SerializeField]
		private bool m_OverrideGlobalContinuity;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6DBDA0", Offset = "0x6DBDA0")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DBDA0", Offset = "0x6DBDA0")]
		private bool m_OverrideGlobalBias;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6DBE24", Offset = "0x6DBE24")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DBE24", Offset = "0x6DBE24")]
		private bool m_SynchronizeTCB;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DBE94", Offset = "0x6DBE94")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DBE94", Offset = "0x6DBE94")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6DBE94", Offset = "0x6DBE94")]
		private float m_StartTension;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6DBFA0", Offset = "0x6DBFA0")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DBFA0", Offset = "0x6DBFA0")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DBFA0", Offset = "0x6DBFA0")]
		private float m_EndTension;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6DC0E8", Offset = "0x6DC0E8")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DC0E8", Offset = "0x6DC0E8")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DC0E8", Offset = "0x6DC0E8")]
		[SerializeField]
		private float m_StartContinuity;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DC1F4", Offset = "0x6DC1F4")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6DC1F4", Offset = "0x6DC1F4")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DC1F4", Offset = "0x6DC1F4")]
		private float m_EndContinuity;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DC33C", Offset = "0x6DC33C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DC33C", Offset = "0x6DC33C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6DC33C", Offset = "0x6DC33C")]
		private float m_StartBias;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DC448", Offset = "0x6DC448")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DC448", Offset = "0x6DC448")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6DC448", Offset = "0x6DC448")]
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
			[Address(RVA = "0x120CF8C", Offset = "0x120CF8C", VA = "0x120CF8C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x120CF94", Offset = "0x120CF94", VA = "0x120CF94")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public bool SerializedOrientationAnchor
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x120CFB4", Offset = "0x120CFB4", VA = "0x120CFB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x120CFBC", Offset = "0x120CFBC", VA = "0x120CFBC")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public CurvyOrientationSwirl Swirl
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x120D028", Offset = "0x120D028", VA = "0x120D028")]
			get
			{
				return default(CurvyOrientationSwirl);
			}
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x120D030", Offset = "0x120D030", VA = "0x120D030")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public float SwirlTurns
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x120D06C", Offset = "0x120D06C", VA = "0x120D06C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x120D074", Offset = "0x120D074", VA = "0x120D074")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public Vector3 HandleIn
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x120D0AC", Offset = "0x120D0AC", VA = "0x120D0AC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x120D0B8", Offset = "0x120D0B8", VA = "0x120D0B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public Vector3 HandleOut
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x120D148", Offset = "0x120D148", VA = "0x120D148")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x120D154", Offset = "0x120D154", VA = "0x120D154")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public Vector3 HandleInPosition
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x120D1E4", Offset = "0x120D1E4", VA = "0x120D1E4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x120D268", Offset = "0x120D268", VA = "0x120D268")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public Vector3 HandleOutPosition
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x120D2EC", Offset = "0x120D2EC", VA = "0x120D2EC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x120D370", Offset = "0x120D370", VA = "0x120D370")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public bool AutoHandles
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x120D3F4", Offset = "0x120D3F4", VA = "0x120D3F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x120D3FC", Offset = "0x120D3FC", VA = "0x120D3FC")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public float AutoHandleDistance
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x120D5BC", Offset = "0x120D5BC", VA = "0x120D5BC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x120D5C4", Offset = "0x120D5C4", VA = "0x120D5C4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public bool SynchronizeTCB
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x120D628", Offset = "0x120D628", VA = "0x120D628")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x120D630", Offset = "0x120D630", VA = "0x120D630")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public bool OverrideGlobalTension
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x120D678", Offset = "0x120D678", VA = "0x120D678")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x120D680", Offset = "0x120D680", VA = "0x120D680")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public bool OverrideGlobalContinuity
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x120D6C8", Offset = "0x120D6C8", VA = "0x120D6C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x120D6D0", Offset = "0x120D6D0", VA = "0x120D6D0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public bool OverrideGlobalBias
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x120D718", Offset = "0x120D718", VA = "0x120D718")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x120D720", Offset = "0x120D720", VA = "0x120D720")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public float StartTension
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x120D768", Offset = "0x120D768", VA = "0x120D768")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x120D770", Offset = "0x120D770", VA = "0x120D770")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public float StartContinuity
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x120D7A8", Offset = "0x120D7A8", VA = "0x120D7A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x120D7B0", Offset = "0x120D7B0", VA = "0x120D7B0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public float StartBias
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x120D7E8", Offset = "0x120D7E8", VA = "0x120D7E8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x120D7F0", Offset = "0x120D7F0", VA = "0x120D7F0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public float EndTension
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x120D828", Offset = "0x120D828", VA = "0x120D828")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x120D830", Offset = "0x120D830", VA = "0x120D830")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public float EndContinuity
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x120D868", Offset = "0x120D868", VA = "0x120D868")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x120D870", Offset = "0x120D870", VA = "0x120D870")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public float EndBias
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x120D8A8", Offset = "0x120D8A8", VA = "0x120D8A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x120D8B0", Offset = "0x120D8B0", VA = "0x120D8B0")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public CurvySplineSegment FollowUp
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x120D8E8", Offset = "0x120D8E8", VA = "0x120D8E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x120D8F0", Offset = "0x120D8F0", VA = "0x120D8F0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public ConnectionHeadingEnum FollowUpHeading
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x120D9E8", Offset = "0x120D9E8", VA = "0x120D9E8")]
			get
			{
				return default(ConnectionHeadingEnum);
			}
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x120DB50", Offset = "0x120DB50", VA = "0x120DB50")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public bool ConnectionSyncPosition
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x120DC44", Offset = "0x120DC44", VA = "0x120DC44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x120DC4C", Offset = "0x120DC4C", VA = "0x120DC4C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public bool ConnectionSyncRotation
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x120DC6C", Offset = "0x120DC6C", VA = "0x120DC6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x120DC74", Offset = "0x120DC74", VA = "0x120DC74")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public CurvyConnection Connection
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x120DC94", Offset = "0x120DC94", VA = "0x120DC94")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x120DC9C", Offset = "0x120DC9C", VA = "0x120DC9C")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public int CacheSize
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x120DE74", Offset = "0x120DE74", VA = "0x120DE74")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x120DE7C", Offset = "0x120DE7C", VA = "0x120DE7C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public Bounds Bounds
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x120DE84", Offset = "0x120DE84", VA = "0x120DE84")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x170000B3")]
		public float Length
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x120E0F8", Offset = "0x120E0F8", VA = "0x120E0F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5788", Offset = "0x6E5788")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x120E100", Offset = "0x120E100", VA = "0x120E100")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5798", Offset = "0x6E5798")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public float Distance
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x120E108", Offset = "0x120E108", VA = "0x120E108")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E57A8", Offset = "0x6E57A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x120E110", Offset = "0x120E110", VA = "0x120E110")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E57B8", Offset = "0x6E57B8")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public float TF
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x120E118", Offset = "0x120E118", VA = "0x120E118")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E57C8", Offset = "0x6E57C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x120E120", Offset = "0x120E120", VA = "0x120E120")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E57D8", Offset = "0x6E57D8")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public bool IsFirstControlPoint
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x120E128", Offset = "0x120E128", VA = "0x120E128")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B7")]
		public bool IsLastControlPoint
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x120E158", Offset = "0x120E158", VA = "0x120E158")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6E6180", Offset = "0x6E6180")]
		public HashSet<UnityEngine.Component> MetaDataSet
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x120E1B0", Offset = "0x120E1B0", VA = "0x120E1B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		public HashSet<CurvyMetadataBase> Metadata
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x120E2EC", Offset = "0x120E2EC", VA = "0x120E2EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		public CurvySpline Spline
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x120E2F4", Offset = "0x120E2F4", VA = "0x120E2F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BB")]
		public bool HasUnprocessedLocalPosition
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x120E2FC", Offset = "0x120E2FC", VA = "0x120E2FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BC")]
		public bool HasUnprocessedLocalOrientation
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x120E348", Offset = "0x120E348", VA = "0x120E348")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BD")]
		public bool OrientatinInfluencesSpline
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x120E38C", Offset = "0x120E38C", VA = "0x120E38C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BE")]
		private CurvyInterpolation interpolation
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x1211734", Offset = "0x1211734", VA = "0x1211734")]
			get
			{
				return default(CurvyInterpolation);
			}
		}

		[Token(Token = "0x170000BF")]
		private bool isDynamicOrientation
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x12117BC", Offset = "0x12117BC", VA = "0x12117BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C0")]
		private bool IsOrientationAnchorEditable
		{
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x121184C", Offset = "0x121184C", VA = "0x121184C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C1")]
		private bool canHaveSwirl
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x1211950", Offset = "0x1211950", VA = "0x1211950")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x120E438", Offset = "0x120E438", VA = "0x120E438")]
		public void SetBezierHandleIn(Vector3 position, Space space = Space.Self, CurvyBezierModeEnum mode = CurvyBezierModeEnum.None)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x120E828", Offset = "0x120E828", VA = "0x120E828")]
		public void SetBezierHandleOut(Vector3 position, Space space = Space.Self, CurvyBezierModeEnum mode = CurvyBezierModeEnum.None)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x120EC10", Offset = "0x120EC10", VA = "0x120EC10")]
		public void SetBezierHandles(float distanceFrag = -1f, bool setIn = true, bool setOut = true, bool noDirtying = false)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x120EEBC", Offset = "0x120EEBC", VA = "0x120EEBC")]
		public void SetBezierHandles(float distanceFrag, Vector3 p, Vector3 n, bool setIn = true, bool setOut = true, bool noDirtying = false)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x120F044", Offset = "0x120F044", VA = "0x120F044")]
		public void SetFollowUp(CurvySplineSegment target, ConnectionHeadingEnum heading = ConnectionHeadingEnum.Auto)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x120F20C", Offset = "0x120F20C", VA = "0x120F20C")]
		public void Disconnect()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x120F214", Offset = "0x120F214", VA = "0x120F214")]
		public void Disconnect(bool destroyEmptyConnection)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x120F2DC", Offset = "0x120F2DC", VA = "0x120F2DC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6E57E8", Offset = "0x6E57E8")]
		public void ResetConnectionRelatedData()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x120F330", Offset = "0x120F330", VA = "0x120F330")]
		public Vector3 Interpolate(float localF, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x120F6F0", Offset = "0x120F6F0", VA = "0x120F6F0")]
		public Vector3 InterpolateFast(float localF, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x120F84C", Offset = "0x120F84C", VA = "0x120F84C")]
		public Vector3 GetTangent(float localF, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x120F8B0", Offset = "0x120F8B0", VA = "0x120F8B0")]
		public Vector3 GetTangent(float localF, Vector3 position, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x120FA54", Offset = "0x120FA54", VA = "0x120FA54")]
		public Vector3 GetTangentFast(float localF, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x120FB1C", Offset = "0x120FB1C", VA = "0x120FB1C")]
		public void InterpolateAndGetTangent(float localF, out Vector3 position, out Vector3 tangent, Space space = Space.Self)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x120FBA4", Offset = "0x120FBA4", VA = "0x120FBA4")]
		public void InterpolateAndGetTangentFast(float localF, out Vector3 position, out Vector3 tangent, Space space = Space.Self)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x120FD1C", Offset = "0x120FD1C", VA = "0x120FD1C")]
		public Vector3 GetOrientationUpFast(float localF, Space space = Space.Self)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x120FDE4", Offset = "0x120FDE4", VA = "0x120FDE4")]
		public Quaternion GetOrientationFast(float localF, bool inverse = false, Space space = Space.Self)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x120FEBC", Offset = "0x120FEBC", VA = "0x120FEBC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6E5820", Offset = "0x6E5820")]
		public Vector3 InterpolateScale(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1210000", Offset = "0x1210000", VA = "0x1210000")]
		public void ReloadMetaData()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1210340", Offset = "0x1210340", VA = "0x1210340")]
		public void RegisterMetaData(CurvyMetadataBase metaData)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x12103AC", Offset = "0x12103AC", VA = "0x12103AC")]
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
		[Address(RVA = "0x1210410", Offset = "0x1210410", VA = "0x1210410")]
		public void DeleteMetadata()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x12104D8", Offset = "0x12104D8", VA = "0x12104D8")]
		public float GetNearestPointF(Vector3 position, Space space = Space.Self)
		{
			return default(float);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1210800", Offset = "0x1210800", VA = "0x1210800")]
		public float DistanceToLocalF(float localDistance)
		{
			return default(float);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1210A9C", Offset = "0x1210A9C", VA = "0x1210A9C")]
		public float LocalFToDistance(float localF)
		{
			return default(float);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1210B4C", Offset = "0x1210B4C", VA = "0x1210B4C")]
		public float LocalFToTF(float localF)
		{
			return default(float);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1210B6C", Offset = "0x1210B6C", VA = "0x1210B6C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1210C3C", Offset = "0x1210C3C", VA = "0x1210C3C")]
		public void BakeOrientationToTransform()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x120F7B8", Offset = "0x120F7B8", VA = "0x120F7B8")]
		public int getApproximationIndexINTERNAL(float localF, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1210EB4", Offset = "0x1210EB4", VA = "0x1210EB4")]
		public void LinkToSpline(CurvySpline spline)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1210EBC", Offset = "0x1210EBC", VA = "0x1210EBC")]
		public void UnlinkFromSpline()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1210EC8", Offset = "0x1210EC8", VA = "0x1210EC8")]
		public void SetLocalPosition(Vector3 newPosition)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1211084", Offset = "0x1211084", VA = "0x1211084")]
		public void SetPosition(Vector3 value)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1210CE0", Offset = "0x1210CE0", VA = "0x1210CE0")]
		public void SetLocalRotation(Quaternion value)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1211240", Offset = "0x1211240", VA = "0x1211240")]
		public void SetRotation(Quaternion value)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1211414", Offset = "0x1211414", VA = "0x1211414")]
		public static bool CanFollowUpHeadToStart([NotNull] CurvySplineSegment followUp)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x121144C", Offset = "0x121144C", VA = "0x121144C")]
		public static bool CanFollowUpHeadToEnd([NotNull] CurvySplineSegment followUp)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1211484", Offset = "0x1211484", VA = "0x1211484", Slot = "4")]
		public void OnBeforePush()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1211570", Offset = "0x1211570", VA = "0x1211570", Slot = "5")]
		public void OnAfterPop()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1211650", Offset = "0x1211650", VA = "0x1211650")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1211728", Offset = "0x1211728", VA = "0x1211728")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x121172C", Offset = "0x121172C", VA = "0x121172C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1211574", Offset = "0x1211574", VA = "0x1211574")]
		public void Reset()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1211A4C", Offset = "0x1211A4C", VA = "0x1211A4C")]
		internal void SetExtrinsicPropertiesINTERNAL(ControlPointExtrinsicProperties value)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1211A60", Offset = "0x1211A60", VA = "0x1211A60")]
		internal unsafe ref ControlPointExtrinsicProperties GetExtrinsicPropertiesINTERNAL()
		{
			return ref *(ControlPointExtrinsicProperties*)null;
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x12100F8", Offset = "0x12100F8", VA = "0x12100F8")]
		private void CheckAgainstMetaDataDuplication()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x120DD54", Offset = "0x120DD54", VA = "0x120DD54")]
		private bool SetConnection(CurvyConnection newConnection)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x120DA54", Offset = "0x120DA54", VA = "0x120DA54")]
		private static ConnectionHeadingEnum GetValidateConnectionHeading(ConnectionHeadingEnum connectionHeading, [CanBeNull] CurvySplineSegment followUp)
		{
			return default(ConnectionHeadingEnum);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x120D448", Offset = "0x120D448", VA = "0x120D448")]
		private bool SetAutoHandles(bool newValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x12107F0", Offset = "0x12107F0", VA = "0x12107F0")]
		private float getApproximationLocalF(int idx)
		{
			return default(float);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1211ACC", Offset = "0x1211ACC", VA = "0x1211ACC")]
		internal void refreshCurveINTERNAL()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x12120C4", Offset = "0x12120C4", VA = "0x12120C4")]
		private float InterpolateBezierSegment(CurvySplineSegment nextControlPoint, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1212858", Offset = "0x1212858", VA = "0x1212858")]
		private float InterpolateTCBSegment(CurvySplineSegment nextControlPoint, int newCacheSize, float splineTension, float splineContinuity, float splineBias)
		{
			return default(float);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1212480", Offset = "0x1212480", VA = "0x1212480")]
		private float InterpolateCatmullSegment(CurvySplineSegment nextControlPoint, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1212D84", Offset = "0x1212D84", VA = "0x1212D84")]
		private float InterpolateLinearSegment(CurvySplineSegment nextControlPoint, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1212FDC", Offset = "0x1212FDC", VA = "0x1212FDC")]
		internal void refreshOrientationNoneINTERNAL()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1213020", Offset = "0x1213020", VA = "0x1213020")]
		internal void refreshOrientationStaticINTERNAL()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1213354", Offset = "0x1213354", VA = "0x1213354")]
		internal void refreshOrientationDynamicINTERNAL(Vector3 initialUp)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1213560", Offset = "0x1213560", VA = "0x1213560")]
		internal void ClearBoundsINTERNAL()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1213174", Offset = "0x1213174", VA = "0x1213174")]
		internal Vector3 getOrthoUp0INTERNAL()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x121321C", Offset = "0x121321C", VA = "0x121321C")]
		private Vector3 getOrthoUp1INTERNAL()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1213580", Offset = "0x1213580", VA = "0x1213580")]
		internal void UnsetFollowUpWithoutDirtyingINTERNAL()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x12135B4", Offset = "0x12135B4", VA = "0x12135B4")]
		internal void PrepareThreadCompatibleDataINTERNAL(bool useFollowUp)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x12138A0", Offset = "0x12138A0", VA = "0x12138A0")]
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
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D8228", Offset = "0x6D8228")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D8228", Offset = "0x6D8228")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D8228", Offset = "0x6D8228")]
	public class CurvyUISpline : CurvySpline
	{
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1213B30", Offset = "0x1213B30", VA = "0x1213B30")]
		public static CurvyUISpline CreateUISpline(string gameObjectName = "Curvy UI Spline")
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1213CDC", Offset = "0x1213CDC", VA = "0x1213CDC", Slot = "4")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1213C98", Offset = "0x1213C98", VA = "0x1213C98")]
		private void SetupUISpline()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1213D04", Offset = "0x1213D04", VA = "0x1213D04")]
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
		[Address(RVA = "0x1219FF0", Offset = "0x1219FF0", VA = "0x1219FF0")]
		public static bool IsWindingInside(WindingRule rule, int n)
		{
			return default(bool);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x121A09C", Offset = "0x121A09C", VA = "0x121A09C")]
		public static bool VertCCW(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(bool);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x121A0F0", Offset = "0x121A0F0", VA = "0x121A0F0")]
		public static bool VertEq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x121A134", Offset = "0x121A134", VA = "0x121A134")]
		public static bool VertLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x121A184", Offset = "0x121A184", VA = "0x121A184")]
		public static float EdgeEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x121A1F8", Offset = "0x121A1F8", VA = "0x121A1F8")]
		public static float EdgeSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x121A25C", Offset = "0x121A25C", VA = "0x121A25C")]
		public static bool TransLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x121A2AC", Offset = "0x121A2AC", VA = "0x121A2AC")]
		public static float TransEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x121A320", Offset = "0x121A320", VA = "0x121A320")]
		public static float TransSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x121A384", Offset = "0x121A384", VA = "0x121A384")]
		public static bool EdgeGoesLeft(MeshUtils.Edge e)
		{
			return default(bool);
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x121A3B4", Offset = "0x121A3B4", VA = "0x121A3B4")]
		public static bool EdgeGoesRight(MeshUtils.Edge e)
		{
			return default(bool);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x121A3E8", Offset = "0x121A3E8", VA = "0x121A3E8")]
		public static float VertL1dist(MeshUtils.Vertex u, MeshUtils.Vertex v)
		{
			return default(float);
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x121A480", Offset = "0x121A480", VA = "0x121A480")]
		public static void AddWinding(MeshUtils.Edge eDst, MeshUtils.Edge eSrc)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x121A4CC", Offset = "0x121A4CC", VA = "0x121A4CC")]
		public static float Interpolate(float a, float x, float b, float y)
		{
			return default(float);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x121A528", Offset = "0x121A528", VA = "0x121A528")]
		private static void Swap(ref MeshUtils.Vertex a, ref MeshUtils.Vertex b)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x121A560", Offset = "0x121A560", VA = "0x121A560")]
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
		[Address(RVA = "0xF3EFB0", Offset = "0xF3EFB0", VA = "0xF3EFB0")]
		public LTMesh()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xF3F20C", Offset = "0xF3F20C", VA = "0xF3F20C", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xF3F260", Offset = "0xF3F260", VA = "0xF3F260", Slot = "5")]
		public override void OnFree()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xF3F374", Offset = "0xF3F374", VA = "0xF3F374")]
		public MeshUtils.Edge MakeEdge()
		{
			return null;
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xF3F748", Offset = "0xF3F748", VA = "0xF3F748")]
		public void Splice(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xF3FA24", Offset = "0xF3FA24", VA = "0xF3FA24")]
		public void Delete(MeshUtils.Edge eDel)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xF3FC54", Offset = "0xF3FC54", VA = "0xF3FC54")]
		public MeshUtils.Edge AddEdgeVertex(MeshUtils.Edge eOrg)
		{
			return null;
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xF3FCF0", Offset = "0xF3FCF0", VA = "0xF3FCF0")]
		public MeshUtils.Edge SplitEdge(MeshUtils.Edge eOrg)
		{
			return null;
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xF3FDC4", Offset = "0xF3FDC4", VA = "0xF3FDC4")]
		public MeshUtils.Edge Connect(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
			return null;
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xF3FECC", Offset = "0xF3FECC", VA = "0xF3FECC")]
		public void ZapFace(MeshUtils.Face fZap)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xF40030", Offset = "0xF40030", VA = "0xF40030")]
		public void MergeConvexFaces(int maxVertsPerFace)
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xF4019C", Offset = "0xF4019C", VA = "0xF4019C")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x6E5858", Offset = "0x6E5858")]
		public void Check()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6D82D4", Offset = "0x6D82D4")]
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
			[Address(RVA = "0x11F3164", Offset = "0x11F3164", VA = "0x11F3164")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x11F2CD8", Offset = "0x11F2CD8", VA = "0x11F2CD8")]
			set
			{
			}
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x11F2BA0", Offset = "0x11F2BA0", VA = "0x11F2BA0")]
		public static void Sub(ref Vec3 lhs, ref Vec3 rhs, out Vec3 result)
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x11F2E54", Offset = "0x11F2E54", VA = "0x11F2E54")]
		public static void Neg(ref Vec3 v)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x11F31CC", Offset = "0x11F31CC", VA = "0x11F31CC")]
		public static void Dot(ref Vec3 u, ref Vec3 v, out float dot)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x11F823C", Offset = "0x11F823C", VA = "0x11F823C")]
		public static void Normalize(ref Vec3 v)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x11F2BD4", Offset = "0x11F2BD4", VA = "0x11F2BD4")]
		public static int LongAxis(ref Vec3 v)
		{
			return default(int);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x11F82F0", Offset = "0x11F82F0", VA = "0x11F82F0", Slot = "3")]
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
			[Address(RVA = "0x11FA010", Offset = "0x11FA010", VA = "0x11FA010", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x11FA0C8", Offset = "0x11FA0C8", VA = "0x11FA0C8")]
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
				[Address(RVA = "0x11F9F30", Offset = "0x11F9F30", VA = "0x11F9F30")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x600045E")]
			[Address(RVA = "0x11F9F64", Offset = "0x11F9F64", VA = "0x11F9F64", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0x11F9FC4", Offset = "0x11F9FC4", VA = "0x11F9FC4")]
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
			[Address(RVA = "0x11F9E68", Offset = "0x11F9E68", VA = "0x11F9E68")]
			public static EdgePair Create()
			{
				return default(EdgePair);
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x11F9DE8", Offset = "0x11F9DE8", VA = "0x11F9DE8")]
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
				[Address(RVA = "0x11F0DFC", Offset = "0x11F0DFC", VA = "0x11F0DFC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000463")]
				[Address(RVA = "0x11F9BD0", Offset = "0x11F9BD0", VA = "0x11F9BD0")]
				set
				{
				}
			}

			[Token(Token = "0x170000D2")]
			internal Vertex _Dst
			{
				[Token(Token = "0x6000464")]
				[Address(RVA = "0x11EFD5C", Offset = "0x11EFD5C", VA = "0x11EFD5C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000465")]
				[Address(RVA = "0x11F9BEC", Offset = "0x11F9BEC", VA = "0x11F9BEC")]
				set
				{
				}
			}

			[Token(Token = "0x170000D3")]
			internal Edge _Oprev
			{
				[Token(Token = "0x6000466")]
				[Address(RVA = "0x11F0278", Offset = "0x11F0278", VA = "0x11F0278")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000467")]
				[Address(RVA = "0x11F9C08", Offset = "0x11F9C08", VA = "0x11F9C08")]
				set
				{
				}
			}

			[Token(Token = "0x170000D4")]
			internal Edge _Lprev
			{
				[Token(Token = "0x6000468")]
				[Address(RVA = "0x11F025C", Offset = "0x11F025C", VA = "0x11F025C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000469")]
				[Address(RVA = "0x11F9C24", Offset = "0x11F9C24", VA = "0x11F9C24")]
				set
				{
				}
			}

			[Token(Token = "0x170000D5")]
			internal Edge _Dprev
			{
				[Token(Token = "0x600046A")]
				[Address(RVA = "0x11F9C40", Offset = "0x11F9C40", VA = "0x11F9C40")]
				get
				{
					return null;
				}
				[Token(Token = "0x600046B")]
				[Address(RVA = "0x11F9C5C", Offset = "0x11F9C5C", VA = "0x11F9C5C")]
				set
				{
				}
			}

			[Token(Token = "0x170000D6")]
			internal Edge _Rprev
			{
				[Token(Token = "0x600046C")]
				[Address(RVA = "0x11F0468", Offset = "0x11F0468", VA = "0x11F0468")]
				get
				{
					return null;
				}
				[Token(Token = "0x600046D")]
				[Address(RVA = "0x11F9C78", Offset = "0x11F9C78", VA = "0x11F9C78")]
				set
				{
				}
			}

			[Token(Token = "0x170000D7")]
			internal Edge _Dnext
			{
				[Token(Token = "0x600046E")]
				[Address(RVA = "0x11F1B20", Offset = "0x11F1B20", VA = "0x11F1B20")]
				get
				{
					return null;
				}
				[Token(Token = "0x600046F")]
				[Address(RVA = "0x11F9C94", Offset = "0x11F9C94", VA = "0x11F9C94")]
				set
				{
				}
			}

			[Token(Token = "0x170000D8")]
			internal Edge _Rnext
			{
				[Token(Token = "0x6000470")]
				[Address(RVA = "0x11F9CBC", Offset = "0x11F9CBC", VA = "0x11F9CBC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000471")]
				[Address(RVA = "0x11F9CE4", Offset = "0x11F9CE4", VA = "0x11F9CE4")]
				set
				{
				}
			}

			[Token(Token = "0x6000472")]
			[Address(RVA = "0x11F9D0C", Offset = "0x11F9D0C", VA = "0x11F9D0C")]
			internal static void EnsureFirst(ref Edge e)
			{
			}

			[Token(Token = "0x6000473")]
			[Address(RVA = "0x11F9D3C", Offset = "0x11F9D3C", VA = "0x11F9D3C", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0x11F9E1C", Offset = "0x11F9E1C", VA = "0x11F9E1C")]
			public Edge()
			{
			}
		}

		[Token(Token = "0x4000203")]
		public const int Undef = -1;

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xF3F3C8", Offset = "0xF3F3C8", VA = "0xF3F3C8")]
		public static Edge MakeEdge(Edge eNext)
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xF3F994", Offset = "0xF3F994", VA = "0xF3F994")]
		public static void Splice(Edge a, Edge b)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xF3F548", Offset = "0xF3F548", VA = "0xF3F548")]
		public static void MakeVertex(Edge eOrig, Vertex vNext)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xF3F638", Offset = "0xF3F638", VA = "0xF3F638")]
		public static void MakeFace(Edge eOrig, Face fNext)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xF3FBA0", Offset = "0xF3FBA0", VA = "0xF3FBA0")]
		public static void KillEdge(Edge eDel)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xF3F824", Offset = "0xF3F824", VA = "0xF3F824")]
		public static void KillVertex(Vertex vDel, Vertex newOrg)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xF3F8DC", Offset = "0xF3F8DC", VA = "0xF3F8DC")]
		public static void KillFace(Face fDel, Face newLFace)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xF40AE8", Offset = "0xF40AE8", VA = "0xF40AE8")]
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
			[Address(RVA = "0x11F0068", Offset = "0x11F0068", VA = "0x11F0068")]
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
			[Address(RVA = "0x11F2370", Offset = "0x11F2370", VA = "0x11F2370")]
			get
			{
				return default(Vec3);
			}
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x11F237C", Offset = "0x11F237C", VA = "0x11F237C")]
			set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public ContourVertex[] Vertices
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x11F2388", Offset = "0x11F2388", VA = "0x11F2388")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DD")]
		public int VertexCount
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x11F2390", Offset = "0x11F2390", VA = "0x11F2390")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DE")]
		public int[] Elements
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x11F2398", Offset = "0x11F2398", VA = "0x11F2398")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DF")]
		public int ElementCount
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x11F23A0", Offset = "0x11F23A0", VA = "0x11F23A0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x11EFBDC", Offset = "0x11EFBDC", VA = "0x11EFBDC")]
		private ActiveRegion RegionBelow(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x11EFC08", Offset = "0x11EFC08", VA = "0x11EFC08")]
		private ActiveRegion RegionAbove(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x11EFC34", Offset = "0x11EFC34", VA = "0x11EFC34")]
		private bool EdgeLeq(ActiveRegion reg1, ActiveRegion reg2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x11EFD78", Offset = "0x11EFD78", VA = "0x11EFD78")]
		private void DeleteRegion(ActiveRegion reg)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x11EFDF4", Offset = "0x11EFDF4", VA = "0x11EFDF4")]
		private void FixUpperEdge(ActiveRegion reg, MeshUtils.Edge newEdge)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x11EFE60", Offset = "0x11EFE60", VA = "0x11EFE60")]
		private ActiveRegion TopLeftRegion(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x11EFF28", Offset = "0x11EFF28", VA = "0x11EFF28")]
		private ActiveRegion TopRightRegion(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x11EFF88", Offset = "0x11EFF88", VA = "0x11EFF88")]
		private ActiveRegion AddRegionBelow(ActiveRegion regAbove, MeshUtils.Edge eNewUp)
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x11F0070", Offset = "0x11F0070", VA = "0x11F0070")]
		private void ComputeWinding(ActiveRegion reg)
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x11F00CC", Offset = "0x11F00CC", VA = "0x11F00CC")]
		private void FinishRegion(ActiveRegion reg)
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x11F011C", Offset = "0x11F011C", VA = "0x11F011C")]
		private MeshUtils.Edge FinishLeftRegions(ActiveRegion regFirst, ActiveRegion regLast)
		{
			return null;
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x11F0294", Offset = "0x11F0294", VA = "0x11F0294")]
		private void AddRightEdges(ActiveRegion regUp, MeshUtils.Edge eFirst, MeshUtils.Edge eLast, MeshUtils.Edge eTopLeft, bool cleanUp)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x11F087C", Offset = "0x11F087C", VA = "0x11F087C")]
		private void SpliceMergeVertices(MeshUtils.Edge e1, MeshUtils.Edge e2)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x11F0898", Offset = "0x11F0898", VA = "0x11F0898")]
		private void VertexWeights(MeshUtils.Vertex isect, MeshUtils.Vertex org, MeshUtils.Vertex dst, out float w0, out float w1)
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x11F099C", Offset = "0x11F099C", VA = "0x11F099C")]
		private void GetIntersectData(MeshUtils.Vertex isect, MeshUtils.Vertex orgUp, MeshUtils.Vertex dstUp, MeshUtils.Vertex orgLo, MeshUtils.Vertex dstLo)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x11F0484", Offset = "0x11F0484", VA = "0x11F0484")]
		private bool CheckForRightSplice(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x11F0C68", Offset = "0x11F0C68", VA = "0x11F0C68")]
		private bool CheckForLeftSplice(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x11F0E18", Offset = "0x11F0E18", VA = "0x11F0E18")]
		private bool CheckForIntersect(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x11F063C", Offset = "0x11F063C", VA = "0x11F063C")]
		private void WalkDirtyRegions(ActiveRegion regUp)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x11F14C8", Offset = "0x11F14C8", VA = "0x11F14C8")]
		private void ConnectRightVertex(ActiveRegion regUp, MeshUtils.Edge eBottomLeft)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x11F16E0", Offset = "0x11F16E0", VA = "0x11F16E0")]
		private void ConnectLeftDegenerate(ActiveRegion regUp, MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x11F18CC", Offset = "0x11F18CC", VA = "0x11F18CC")]
		private void ConnectLeftVertex(MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x11F17EC", Offset = "0x11F17EC", VA = "0x11F17EC")]
		private void SweepEvent(MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x11F1B48", Offset = "0x11F1B48", VA = "0x11F1B48")]
		private void AddSentinel(float smin, float smax, float t)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x11F1C8C", Offset = "0x11F1C8C", VA = "0x11F1C8C")]
		private void InitEdgeDict()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x11F1D90", Offset = "0x11F1D90", VA = "0x11F1D90")]
		private void DoneEdgeDict()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x11F1E24", Offset = "0x11F1E24", VA = "0x11F1E24")]
		private void RemoveDegenerateEdges()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x11F1F7C", Offset = "0x11F1F7C", VA = "0x11F1F7C")]
		private void InitPriorityQ()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x11F2194", Offset = "0x11F2194", VA = "0x11F2194")]
		private void DonePriorityQ()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x11F21A0", Offset = "0x11F21A0", VA = "0x11F21A0")]
		private void RemoveDegenerateFaces()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x11F2240", Offset = "0x11F2240", VA = "0x11F2240")]
		protected void ComputeInterior()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x11F23A8", Offset = "0x11F23A8", VA = "0x11F23A8")]
		public Tess()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x11F2480", Offset = "0x11F2480", VA = "0x11F2480")]
		private void ComputeNormal(ref Vec3 norm)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x11F2D40", Offset = "0x11F2D40", VA = "0x11F2D40")]
		private void CheckOrientation()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x11F2E70", Offset = "0x11F2E70", VA = "0x11F2E70")]
		private void ProjectPolygon()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x11F31F8", Offset = "0x11F31F8", VA = "0x11F31F8")]
		private void TessellateMonoRegion(MeshUtils.Face face)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x11F3410", Offset = "0x11F3410", VA = "0x11F3410")]
		private void TessellateInterior()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x11F347C", Offset = "0x11F347C", VA = "0x11F347C")]
		private void DiscardExterior()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x11F34E8", Offset = "0x11F34E8", VA = "0x11F34E8")]
		private void SetWindingNumber(int value, bool keepOnlyBoundary)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x11F35BC", Offset = "0x11F35BC", VA = "0x11F35BC")]
		private int GetNeighbourFace(MeshUtils.Edge edge)
		{
			return default(int);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x11F35F8", Offset = "0x11F35F8", VA = "0x11F35F8")]
		private void OutputPolymesh(ElementType elementType, int polySize)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x11F3A70", Offset = "0x11F3A70", VA = "0x11F3A70")]
		private void OutputContours()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x11F3CE4", Offset = "0x11F3CE4", VA = "0x11F3CE4")]
		private float SignedArea(ContourVertex[] vertices)
		{
			return default(float);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x11F3D84", Offset = "0x11F3D84", VA = "0x11F3D84")]
		public void AddContour(ContourVertex[] vertices)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x11F3D8C", Offset = "0x11F3D8C", VA = "0x11F3D8C")]
		public void AddContour(ContourVertex[] vertices, ContourOrientation forceOrientation)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x11F3F78", Offset = "0x11F3F78", VA = "0x11F3F78")]
		public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x11F3F80", Offset = "0x11F3F80", VA = "0x11F3F80")]
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
		[Address(RVA = "0xEC56D4", Offset = "0xEC56D4", VA = "0xEC56D4", Slot = "3")]
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
		[Address(RVA = "0xF402A0", Offset = "0xF402A0", VA = "0xF402A0")]
		public static Vec3 Vec3(this Vector3 v)
		{
			return default(Vec3);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xF402A4", Offset = "0xF402A4", VA = "0xF402A4")]
		public static ContourVertex ContourVertex(this Vector3 v)
		{
			return default(ContourVertex);
		}
	}
	[Token(Token = "0x20000B3")]
	public static class LibTessV3Extension
	{
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xF4029C", Offset = "0xF4029C", VA = "0xF4029C")]
		public static Vector3 Vector3(this Vec3 v)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000B4")]
	public static class UnityLibTessUtility
	{
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x11F7E40", Offset = "0x11F7E40", VA = "0x11F7E40")]
		public static ContourVertex[] ToContourVertex(Vector3[] v, bool zeroZ = false)
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x11F7F30", Offset = "0x11F7F30", VA = "0x11F7F30")]
		public static Vector3[] FromContourVertex(ContourVertex[] v)
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x11F7FAC", Offset = "0x11F7FAC", VA = "0x11F7FAC")]
		public static void SetFromContourVertex(ref Vector3[] v3Array, ref ContourVertex[] cvArray)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x11F80F4", Offset = "0x11F80F4", VA = "0x11F80F4")]
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
		[Address(RVA = "0xF4859C", Offset = "0xF4859C", VA = "0xF4859C")]
		public SerializedCurvySpline()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xF4866C", Offset = "0xF4866C", VA = "0xF4866C")]
		public SerializedCurvySpline([NotNull] CurvySpline spline, CurvySerializationSpace space)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xF48A1C", Offset = "0xF48A1C", VA = "0xF48A1C")]
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
		[Address(RVA = "0xF48D84", Offset = "0xF48D84", VA = "0xF48D84")]
		public SerializedCurvySplineSegment()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xF48910", Offset = "0xF48910", VA = "0xF48910")]
		public SerializedCurvySplineSegment([NotNull] CurvySplineSegment segment, CurvySerializationSpace space)
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xF48C30", Offset = "0xF48C30", VA = "0xF48C30")]
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
		[Address(RVA = "0xEC5618", Offset = "0xEC5618", VA = "0xEC5618")]
		protected ConnectedControlPointsSelector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B9")]
	public class ControllerEvent : UnityEventEx<CurvyController>
	{
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xEC5B8C", Offset = "0xEC5B8C", VA = "0xEC5B8C")]
		public ControllerEvent()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6D832C", Offset = "0x6D832C")]
	public class CurvyControllerEventArgs : CurvyEventArgs
	{
		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly CurvyController Controller;

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xF11ADC", Offset = "0xF11ADC", VA = "0xF11ADC")]
		public CurvyControllerEventArgs(MonoBehaviour sender, CurvyController controller)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BB")]
	public class CurvySplineMoveEvent : UnityEventEx<CurvySplineMoveEventArgs>
	{
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x120CDCC", Offset = "0x120CDCC", VA = "0x120CDCC")]
		public CurvySplineMoveEvent()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class CurvySplineMoveEventArgs : CancelEventArgs
	{
		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DC6A8", Offset = "0x6DC6A8")]
		private SplineController <Sender>k__BackingField;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DC6B8", Offset = "0x6DC6B8")]
		private CurvySpline <Spline>k__BackingField;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DC6C8", Offset = "0x6DC6C8")]
		private CurvySplineSegment <ControlPoint>k__BackingField;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DC6D8", Offset = "0x6DC6D8")]
		private bool <WorldUnits>k__BackingField;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DC6E8", Offset = "0x6DC6E8")]
		private MovementDirection <MovementDirection>k__BackingField;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DC6F8", Offset = "0x6DC6F8")]
		private float <Delta>k__BackingField;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DC708", Offset = "0x6DC708")]
		private float <Position>k__BackingField;

		[Token(Token = "0x170000E0")]
		public SplineController Sender
		{
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x120CE18", Offset = "0x120CE18", VA = "0x120CE18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E58C0", Offset = "0x6E58C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x120CE20", Offset = "0x120CE20", VA = "0x120CE20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E58D0", Offset = "0x6E58D0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public CurvySpline Spline
		{
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x120CE28", Offset = "0x120CE28", VA = "0x120CE28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E58E0", Offset = "0x6E58E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x120CE30", Offset = "0x120CE30", VA = "0x120CE30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E58F0", Offset = "0x6E58F0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public CurvySplineSegment ControlPoint
		{
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x120CE38", Offset = "0x120CE38", VA = "0x120CE38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5900", Offset = "0x6E5900")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x120CE40", Offset = "0x120CE40", VA = "0x120CE40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5910", Offset = "0x6E5910")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		public bool WorldUnits
		{
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x120CE48", Offset = "0x120CE48", VA = "0x120CE48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5920", Offset = "0x6E5920")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x120CE50", Offset = "0x120CE50", VA = "0x120CE50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5930", Offset = "0x6E5930")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		public MovementDirection MovementDirection
		{
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x120CE5C", Offset = "0x120CE5C", VA = "0x120CE5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5940", Offset = "0x6E5940")]
			get
			{
				return default(MovementDirection);
			}
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x120CE64", Offset = "0x120CE64", VA = "0x120CE64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5950", Offset = "0x6E5950")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E5")]
		public float Delta
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x120CE6C", Offset = "0x120CE6C", VA = "0x120CE6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5960", Offset = "0x6E5960")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x120CE74", Offset = "0x120CE74", VA = "0x120CE74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5970", Offset = "0x6E5970")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public float Position
		{
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x120CE7C", Offset = "0x120CE7C", VA = "0x120CE7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5980", Offset = "0x6E5980")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x120CE84", Offset = "0x120CE84", VA = "0x120CE84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5990", Offset = "0x6E5990")]
			private set
			{
			}
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x120CE8C", Offset = "0x120CE8C", VA = "0x120CE8C")]
		public CurvySplineMoveEventArgs(SplineController sender, CurvySpline spline, CurvySplineSegment controlPoint, float position, bool usingWorldUnits, float delta, MovementDirection direction)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x120CF04", Offset = "0x120CF04", VA = "0x120CF04")]
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
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6DC718", Offset = "0x6DC718")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DC718", Offset = "0x6DC718")]
		public CurvyUpdateMethod UpdateIn;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6DC7B0", Offset = "0x6DC7B0")]
		[SerializeField]
		private CurvyPositionMode m_PositionMode;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6DC834", Offset = "0x6DC834")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6DC834", Offset = "0x6DC834")]
		[SerializeField]
		protected float m_Position;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6DC8E0", Offset = "0x6DC8E0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DC9B4", Offset = "0x6DC9B4")]
		[SerializeField]
		private bool m_PlayAutomatically;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DCA00", Offset = "0x6DCA00")]
		[SerializeField]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6DCA00", Offset = "0x6DCA00")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DCA00", Offset = "0x6DCA00")]
		private OrientationModeEnum m_OrientationMode;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DCB48", Offset = "0x6DCB48")]
		[SerializeField]
		private bool m_LockRotation;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DCBB0", Offset = "0x6DCBB0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DCBB0", Offset = "0x6DCBB0")]
		[SerializeField]
		private OrientationAxisEnum m_OrientationAxis;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DCCEC", Offset = "0x6DCCEC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DCCEC", Offset = "0x6DCCEC")]
		private bool m_IgnoreDirection;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x6DCE14", Offset = "0x6DCE14")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DCE14", Offset = "0x6DCE14")]
		[SerializeField]
		private float m_DampingDirection;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DCF0C", Offset = "0x6DCF0C")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x6DCF0C", Offset = "0x6DCF0C")]
		private float m_DampingUp;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6DD004", Offset = "0x6DD004")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DD004", Offset = "0x6DD004")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6DD004", Offset = "0x6DD004")]
		[SerializeField]
		private float m_OffsetAngle;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DD15C", Offset = "0x6DD15C")]
		private float m_OffsetRadius;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DD210", Offset = "0x6DD210")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DD210", Offset = "0x6DD210")]
		[SerializeField]
		private bool m_OffsetCompensation;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6DD304", Offset = "0x6DD304")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DD368", Offset = "0x6DD368")]
		private bool <isInitialized>k__BackingField;

		[Token(Token = "0x170000E7")]
		public ControllerEvent OnInitialized
		{
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0xF0FBBC", Offset = "0xF0FBBC", VA = "0xF0FBBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E8")]
		public CurvyPositionMode PositionMode
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0xF0FBC4", Offset = "0xF0FBC4", VA = "0xF0FBC4")]
			get
			{
				return default(CurvyPositionMode);
			}
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0xF0FBCC", Offset = "0xF0FBCC", VA = "0xF0FBCC")]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public MoveModeEnum MoveMode
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0xF0FBD4", Offset = "0xF0FBD4", VA = "0xF0FBD4")]
			get
			{
				return default(MoveModeEnum);
			}
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0xF0FBDC", Offset = "0xF0FBDC", VA = "0xF0FBDC")]
			set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public bool PlayAutomatically
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0xF0FBF0", Offset = "0xF0FBF0", VA = "0xF0FBF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0xF0FBF8", Offset = "0xF0FBF8", VA = "0xF0FBF8")]
			set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public CurvyClamping Clamping
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0xF0FC18", Offset = "0xF0FC18", VA = "0xF0FC18")]
			get
			{
				return default(CurvyClamping);
			}
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0xF0FC20", Offset = "0xF0FC20", VA = "0xF0FC20")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public OrientationModeEnum OrientationMode
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0xF0FC34", Offset = "0xF0FC34", VA = "0xF0FC34")]
			get
			{
				return default(OrientationModeEnum);
			}
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0xF0FC3C", Offset = "0xF0FC3C", VA = "0xF0FC3C")]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public bool LockRotation
		{
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0xF0FC50", Offset = "0xF0FC50", VA = "0xF0FC50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0xF0FC58", Offset = "0xF0FC58", VA = "0xF0FC58")]
			set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public OrientationAxisEnum OrientationAxis
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0xF0FCC0", Offset = "0xF0FCC0", VA = "0xF0FCC0")]
			get
			{
				return default(OrientationAxisEnum);
			}
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0xF0FCC8", Offset = "0xF0FCC8", VA = "0xF0FCC8")]
			set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public float DirectionDampingTime
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0xF0FCDC", Offset = "0xF0FCDC", VA = "0xF0FCDC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0xF0FCE4", Offset = "0xF0FCE4", VA = "0xF0FCE4")]
			set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public float UpDampingTime
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0xF0FD20", Offset = "0xF0FD20", VA = "0xF0FD20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0xF0FD28", Offset = "0xF0FD28", VA = "0xF0FD28")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public bool IgnoreDirection
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0xF0FD64", Offset = "0xF0FD64", VA = "0xF0FD64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0xF0FD6C", Offset = "0xF0FD6C", VA = "0xF0FD6C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public float OffsetAngle
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0xF0FD8C", Offset = "0xF0FD8C", VA = "0xF0FD8C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000500")]
			[Address(RVA = "0xF0FD94", Offset = "0xF0FD94", VA = "0xF0FD94")]
			set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public float OffsetRadius
		{
			[Token(Token = "0x6000501")]
			[Address(RVA = "0xF0FDA8", Offset = "0xF0FDA8", VA = "0xF0FDA8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000502")]
			[Address(RVA = "0xF0FDB0", Offset = "0xF0FDB0", VA = "0xF0FDB0")]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public bool OffsetCompensation
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0xF0FDC4", Offset = "0xF0FDC4", VA = "0xF0FDC4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000504")]
			[Address(RVA = "0xF0FDCC", Offset = "0xF0FDCC", VA = "0xF0FDCC")]
			set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public float Speed
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0xF0FDD8", Offset = "0xF0FDD8", VA = "0xF0FDD8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000506")]
			[Address(RVA = "0xF0FDE0", Offset = "0xF0FDE0", VA = "0xF0FDE0")]
			set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public float RelativePosition
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0xF0FDF4", Offset = "0xF0FDF4", VA = "0xF0FDF4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000508")]
			[Address(RVA = "0xF0FF84", Offset = "0xF0FF84", VA = "0xF0FF84")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public float AbsolutePosition
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0xF10038", Offset = "0xF10038", VA = "0xF10038")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600050A")]
			[Address(RVA = "0xF10140", Offset = "0xF10140", VA = "0xF10140")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public float Position
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0xF10200", Offset = "0xF10200", VA = "0xF10200")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600050C")]
			[Address(RVA = "0xF10258", Offset = "0xF10258", VA = "0xF10258")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public MovementDirection MovementDirection
		{
			[Token(Token = "0x600050D")]
			[Address(RVA = "0xF102B0", Offset = "0xF102B0", VA = "0xF102B0")]
			get
			{
				return default(MovementDirection);
			}
			[Token(Token = "0x600050E")]
			[Address(RVA = "0xF102B8", Offset = "0xF102B8", VA = "0xF102B8")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public CurvyControllerState PlayState
		{
			[Token(Token = "0x600050F")]
			[Address(RVA = "0xF102C0", Offset = "0xF102C0", VA = "0xF102C0")]
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
			[Address(RVA = "0xF1063C", Offset = "0xF1063C", VA = "0xF1063C", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FD")]
		protected virtual bool ShowOrientationSection
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0xF11214", Offset = "0xF11214", VA = "0xF11214", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FE")]
		protected virtual bool ShowOffsetSection
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0xF1121C", Offset = "0xF1121C", VA = "0xF1121C", Slot = "26")]
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
			[Address(RVA = "0xF11964", Offset = "0xF11964", VA = "0xF11964")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E59A0", Offset = "0x6E59A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000537")]
			[Address(RVA = "0xF1196C", Offset = "0xF1196C", VA = "0xF1196C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E59B0", Offset = "0x6E59B0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000101")]
		protected float TimeSinceLastUpdate
		{
			[Token(Token = "0x6000538")]
			[Address(RVA = "0xF1045C", Offset = "0xF1045C", VA = "0xF1045C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000102")]
		protected bool UseOffset
		{
			[Token(Token = "0x6000539")]
			[Address(RVA = "0xF10948", Offset = "0xF10948", VA = "0xF10948")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000103")]
		private float maxPosition
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0xF11978", Offset = "0xF11978", VA = "0xF11978")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xF102C8", Offset = "0xF102C8", VA = "0xF102C8", Slot = "7")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xF10330", Offset = "0xF10330", VA = "0xF10330", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xF1040C", Offset = "0xF1040C", VA = "0xF1040C", Slot = "9")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xF10428", Offset = "0xF10428", VA = "0xF10428", Slot = "10")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xF10514", Offset = "0xF10514", VA = "0xF10514", Slot = "11")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xF1056C", Offset = "0xF1056C", VA = "0xF1056C", Slot = "12")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xF105A4", Offset = "0xF105A4", VA = "0xF105A4", Slot = "13")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xF10644", Offset = "0xF10644", VA = "0xF10644", Slot = "15")]
		protected virtual void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xF10B54", Offset = "0xF10B54", VA = "0xF10B54", Slot = "16")]
		protected virtual void ComputeTargetPositionAndRotation(out Vector3 targetPosition, out Vector3 targetUp, out Vector3 targetForward)
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xF110F0", Offset = "0xF110F0", VA = "0xF110F0", Slot = "17")]
		protected virtual void Initialize()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xF111B4", Offset = "0xF111B4", VA = "0xF111B4", Slot = "18")]
		protected virtual void Deinitialize()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xF111E4", Offset = "0xF111E4", VA = "0xF111E4", Slot = "19")]
		protected virtual void BindEvents()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xF111E8", Offset = "0xF111E8", VA = "0xF111E8", Slot = "20")]
		protected virtual void UnbindEvents()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xF111EC", Offset = "0xF111EC", VA = "0xF111EC", Slot = "21")]
		protected virtual void SavePrePlayState()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xF111FC", Offset = "0xF111FC", VA = "0xF111FC", Slot = "22")]
		protected virtual void RestorePrePlayState()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xF1120C", Offset = "0xF1120C", VA = "0xF1120C", Slot = "23")]
		protected virtual void UserAfterInit()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xF11210", Offset = "0xF11210", VA = "0xF11210", Slot = "24")]
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
		[Address(RVA = "0xF103CC", Offset = "0xF103CC", VA = "0xF103CC")]
		public void Play()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xF1122C", Offset = "0xF1122C", VA = "0xF1122C")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xF11268", Offset = "0xF11268", VA = "0xF11268")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xF11280", Offset = "0xF11280", VA = "0xF11280")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xF10464", Offset = "0xF10464", VA = "0xF10464")]
		public void ApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xF11288", Offset = "0xF11288", VA = "0xF11288")]
		public void TeleportTo(float newPosition)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xF112D0", Offset = "0xF112D0", VA = "0xF112D0")]
		public void TeleportBy(float distance, MovementDirection direction)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xF11388", Offset = "0xF11388", VA = "0xF11388")]
		public void SetFromString(string fieldAndValue)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xF11050", Offset = "0xF11050", VA = "0xF11050")]
		protected static Vector3 ApplyOffset(Vector3 position, Vector3 tangent, Vector3 up, float offsetAngle, float offsetRadius)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xF0FF04", Offset = "0xF0FF04", VA = "0xF0FF04")]
		protected static float GetClampedPosition(float position, CurvyPositionMode positionMode, CurvyClamping clampingMode, float length)
		{
			return default(float);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xF10958", Offset = "0xF10958", VA = "0xF10958")]
		protected float ComputeOffsetCompensatedSpeed(float deltaTime)
		{
			return default(float);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xF10F44", Offset = "0xF10F44", VA = "0xF10F44")]
		private void GetOrientationNoneUpAndForward(out Vector3 targetUp, out Vector3 targetForward)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xF11A0C", Offset = "0xF11A0C", VA = "0xF11A0C", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xF11A10", Offset = "0xF11A10", VA = "0xF11A10", Slot = "36")]
		public virtual void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xF11A50", Offset = "0xF11A50", VA = "0xF11A50")]
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
		[Address(RVA = "0xF43CF4", Offset = "0xF43CF4", VA = "0xF43CF4")]
		public static MovementDirection FromInt(int value)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xF43CFC", Offset = "0xF43CFC", VA = "0xF43CFC")]
		public static MovementDirection GetOpposite(this MovementDirection value)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xF43D58", Offset = "0xF43D58", VA = "0xF43D58")]
		public static int ToInt(this MovementDirection direction)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D835C", Offset = "0x6D835C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D835C", Offset = "0x6D835C")]
	public class PathController : CurvyController
	{
		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6DD378", Offset = "0x6DD378")]
		[SerializeField]
		[AttributeAttribute(Name = "CGDataReferenceSelectorAttribute", RVA = "0x6DD378", Offset = "0x6DD378")]
		private CGDataReference m_Path;

		[Token(Token = "0x17000104")]
		public CGDataReference Path
		{
			[Token(Token = "0x6000545")]
			[Address(RVA = "0xF442EC", Offset = "0xF442EC", VA = "0xF442EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000546")]
			[Address(RVA = "0xF442F4", Offset = "0xF442F4", VA = "0xF442F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public CGPath PathData
		{
			[Token(Token = "0x6000547")]
			[Address(RVA = "0xF442FC", Offset = "0xF442FC", VA = "0xF442FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000106")]
		public override float Length
		{
			[Token(Token = "0x6000548")]
			[Address(RVA = "0xF44370", Offset = "0xF44370", VA = "0xF44370", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000107")]
		public override bool IsReady
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0xF443B0", Offset = "0xF443B0", VA = "0xF443B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xF44400", Offset = "0xF44400", VA = "0xF44400", Slot = "31")]
		protected override float RelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xF4445C", Offset = "0xF4445C", VA = "0xF4445C", Slot = "30")]
		protected override float AbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xF444B8", Offset = "0xF444B8", VA = "0xF444B8", Slot = "32")]
		protected override Vector3 GetInterpolatedSourcePosition(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xF4452C", Offset = "0xF4452C", VA = "0xF4452C", Slot = "33")]
		protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up)
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xF44604", Offset = "0xF44604", VA = "0xF44604", Slot = "35")]
		protected override Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xF44678", Offset = "0xF44678", VA = "0xF44678", Slot = "34")]
		protected override Vector3 GetOrientation(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xF446EC", Offset = "0xF446EC", VA = "0xF446EC", Slot = "28")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xF44768", Offset = "0xF44768", VA = "0xF44768", Slot = "29")]
		protected override void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xF44854", Offset = "0xF44854", VA = "0xF44854")]
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
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D83C0", Offset = "0x6D83C0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D83C0", Offset = "0x6D83C0")]
	public class SplineController : CurvyController
	{
		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6DD438", Offset = "0x6DD438")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DD438", Offset = "0x6DD438")]
		[SerializeField]
		protected CurvySpline m_Spline;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DD4E4", Offset = "0x6DD4E4")]
		private bool m_UseCache;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6DD530", Offset = "0x6DD530")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DD530", Offset = "0x6DD530")]
		[SerializeField]
		private SplineControllerConnectionBehavior connectionBehavior;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DD5EC", Offset = "0x6DD5EC")]
		private bool allowDirectionChange;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DD64C", Offset = "0x6DD64C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DD64C", Offset = "0x6DD64C")]
		private bool rejectCurrentSpline;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBA")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DD734", Offset = "0x6DD734")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DD734", Offset = "0x6DD734")]
		private bool rejectTooDivergentSplines;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DD81C", Offset = "0x6DD81C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6DD81C", Offset = "0x6DD81C")]
		private float maxAllowedDivergenceAngle;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DD8A0", Offset = "0x6DD8A0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DD8A0", Offset = "0x6DD8A0")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DD8A0", Offset = "0x6DD8A0")]
		private ConnectedControlPointsSelector connectionCustomSelector;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6DD9D0", Offset = "0x6DD9D0")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DDA64", Offset = "0x6DDA64")]
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
			[Address(RVA = "0xF49B08", Offset = "0xF49B08", VA = "0xF49B08", Slot = "37")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000555")]
			[Address(RVA = "0xF49B10", Offset = "0xF49B10", VA = "0xF49B10", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public bool UseCache
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0xF49B18", Offset = "0xF49B18", VA = "0xF49B18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000557")]
			[Address(RVA = "0xF49B20", Offset = "0xF49B20", VA = "0xF49B20")]
			set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public SplineControllerConnectionBehavior ConnectionBehavior
		{
			[Token(Token = "0x6000558")]
			[Address(RVA = "0xF49B40", Offset = "0xF49B40", VA = "0xF49B40")]
			get
			{
				return default(SplineControllerConnectionBehavior);
			}
			[Token(Token = "0x6000559")]
			[Address(RVA = "0xF49B48", Offset = "0xF49B48", VA = "0xF49B48")]
			set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public ConnectedControlPointsSelector ConnectionCustomSelector
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0xF49B50", Offset = "0xF49B50", VA = "0xF49B50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600055B")]
			[Address(RVA = "0xF49B58", Offset = "0xF49B58", VA = "0xF49B58")]
			set
			{
			}
		}

		[Token(Token = "0x1700010C")]
		public bool AllowDirectionChange
		{
			[Token(Token = "0x600055C")]
			[Address(RVA = "0xF49B60", Offset = "0xF49B60", VA = "0xF49B60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600055D")]
			[Address(RVA = "0xF49B68", Offset = "0xF49B68", VA = "0xF49B68")]
			set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		public bool RejectCurrentSpline
		{
			[Token(Token = "0x600055E")]
			[Address(RVA = "0xF49B74", Offset = "0xF49B74", VA = "0xF49B74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600055F")]
			[Address(RVA = "0xF49B7C", Offset = "0xF49B7C", VA = "0xF49B7C")]
			set
			{
			}
		}

		[Token(Token = "0x1700010E")]
		public bool RejectTooDivergentSplines
		{
			[Token(Token = "0x6000560")]
			[Address(RVA = "0xF49B88", Offset = "0xF49B88", VA = "0xF49B88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000561")]
			[Address(RVA = "0xF49B90", Offset = "0xF49B90", VA = "0xF49B90")]
			set
			{
			}
		}

		[Token(Token = "0x1700010F")]
		public float MaxAllowedDivergenceAngle
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0xF49B9C", Offset = "0xF49B9C", VA = "0xF49B9C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000563")]
			[Address(RVA = "0xF49BA4", Offset = "0xF49BA4", VA = "0xF49BA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000110")]
		public CurvySplineMoveEvent OnControlPointReached
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0xF49BAC", Offset = "0xF49BAC", VA = "0xF49BAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000565")]
			[Address(RVA = "0xF49BB4", Offset = "0xF49BB4", VA = "0xF49BB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000111")]
		public CurvySplineMoveEvent OnEndReached
		{
			[Token(Token = "0x6000566")]
			[Address(RVA = "0xF49BBC", Offset = "0xF49BBC", VA = "0xF49BBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000567")]
			[Address(RVA = "0xF49BC4", Offset = "0xF49BC4", VA = "0xF49BC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000112")]
		public CurvySplineMoveEvent OnSwitch
		{
			[Token(Token = "0x6000568")]
			[Address(RVA = "0xF49BCC", Offset = "0xF49BCC", VA = "0xF49BCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000569")]
			[Address(RVA = "0xF49BD4", Offset = "0xF49BD4", VA = "0xF49BD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000113")]
		public bool IsSwitching
		{
			[Token(Token = "0x600056A")]
			[Address(RVA = "0xF49BDC", Offset = "0xF49BDC", VA = "0xF49BDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E59E0", Offset = "0x6E59E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600056B")]
			[Address(RVA = "0xF49BE4", Offset = "0xF49BE4", VA = "0xF49BE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E59F0", Offset = "0x6E59F0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000114")]
		public float SwitchProgress
		{
			[Token(Token = "0x600056C")]
			[Address(RVA = "0xF49BF0", Offset = "0xF49BF0", VA = "0xF49BF0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000115")]
		public override float Length
		{
			[Token(Token = "0x600056D")]
			[Address(RVA = "0xF49C34", Offset = "0xF49C34", VA = "0xF49C34", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000116")]
		public override bool IsReady
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0xF49EC4", Offset = "0xF49EC4", VA = "0xF49EC4", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000117")]
		private bool ShowRandomConnectionOptions
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0xF4BBE0", Offset = "0xF4BBE0", VA = "0xF4BBE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xF499C4", Offset = "0xF499C4", VA = "0xF499C4")]
		public SplineController()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xF49C94", Offset = "0xF49C94", VA = "0xF49C94", Slot = "39")]
		public virtual void SwitchTo(CurvySpline destinationSpline, float destinationTf, float duration)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xF49D48", Offset = "0xF49D48", VA = "0xF49D48")]
		public void FinishCurrentSwitch()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xF49D94", Offset = "0xF49D94", VA = "0xF49D94")]
		public void CancelCurrentSwitch()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xF49DA4", Offset = "0xF49DA4", VA = "0xF49DA4")]
		public static float GetAngleBetweenConnectedSplines(CurvySplineSegment before, MovementDirection movementMode, CurvySplineSegment after, bool allowMovementModeChange)
		{
			return default(float);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xF49F1C", Offset = "0xF49F1C", VA = "0xF49F1C", Slot = "21")]
		protected override void SavePrePlayState()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xF49F64", Offset = "0xF49F64", VA = "0xF49F64", Slot = "22")]
		protected override void RestorePrePlayState()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xF49F9C", Offset = "0xF49F9C", VA = "0xF49F9C", Slot = "31")]
		protected override float RelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xF49FE8", Offset = "0xF49FE8", VA = "0xF49FE8", Slot = "30")]
		protected override float AbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xF4A034", Offset = "0xF4A034", VA = "0xF4A034", Slot = "32")]
		protected override Vector3 GetInterpolatedSourcePosition(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xF4A0DC", Offset = "0xF4A0DC", VA = "0xF4A0DC", Slot = "33")]
		protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xF4A254", Offset = "0xF4A254", VA = "0xF4A254", Slot = "35")]
		protected override Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xF4A2FC", Offset = "0xF4A2FC", VA = "0xF4A2FC", Slot = "34")]
		protected override Vector3 GetOrientation(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xF4A37C", Offset = "0xF4A37C", VA = "0xF4A37C", Slot = "28")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xF4AE28", Offset = "0xF4AE28", VA = "0xF4AE28", Slot = "29")]
		protected override void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xF4ACF0", Offset = "0xF4ACF0", VA = "0xF4ACF0")]
		private void SimulateAdvanceOnSpline(ref float tf, ref MovementDirection curyDirection, CurvySpline spline, float distance)
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xF4AE8C", Offset = "0xF4AE8C", VA = "0xF4AE8C", Slot = "15")]
		protected override void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xF4AF38", Offset = "0xF4AF38", VA = "0xF4AF38", Slot = "16")]
		protected override void ComputeTargetPositionAndRotation(out Vector3 targetPosition, out Vector3 targetUp, out Vector3 targetForward)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xF4B1C8", Offset = "0xF4B1C8", VA = "0xF4B1C8")]
		private static float MovementCompatibleGetPosition(SplineController controller, CurvyPositionMode positionMode, out CurvySplineSegment controlPoint, out bool isOnControlPoint, float clampedPosition)
		{
			return default(float);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xF4B39C", Offset = "0xF4B39C", VA = "0xF4B39C")]
		private static void MovementCompatibleSetPosition(SplineController controller, CurvyPositionMode positionMode, float specialClampedPosition)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xF4A4B8", Offset = "0xF4A4B8", VA = "0xF4A4B8")]
		private void EventAwareMove(float distance)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xF4B4E8", Offset = "0xF4B4E8", VA = "0xF4B4E8")]
		private void HandleReachingNewControlPoint(CurvySplineSegment controlPoint, float controlPointPosition, CurvyPositionMode positionMode, float currentDelta, ref bool cancelMovement, out CurvySplineSegment postEventsControlPoint, out bool postEventsIsControllerOnControlPoint, out float postEventsControlPointPosition)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xF4BA80", Offset = "0xF4BA80", VA = "0xF4BA80")]
		private void InvokeEventHandler(CurvySplineMoveEvent @event, CurvySplineMoveEventArgs eventArgument, CurvyPositionMode positionMode, ref CurvySplineSegment postEventsControlPoint, ref bool postEventsIsControllerOnControlPoint, ref float postEventsControlPointPosition)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xF4B848", Offset = "0xF4B848", VA = "0xF4B848")]
		private CurvySplineSegment HandleRandomConnectionBehavior(CurvySplineSegment currentControlPoint, MovementDirection currentDirection, out MovementDirection newDirection, ReadOnlyCollection<CurvySplineSegment> connectedControlPoints)
		{
			return null;
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xF49E7C", Offset = "0xF49E7C", VA = "0xF49E7C")]
		private static MovementDirection GetPostConnectionDirection(CurvySplineSegment connectedControlPoint, MovementDirection currentDirection, bool directionChangeAllowed)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xF4B754", Offset = "0xF4B754", VA = "0xF4B754")]
		private CurvySplineSegment HandleFollowUpConnectionBehavior(CurvySplineSegment currentControlPoint, MovementDirection currentDirection, out MovementDirection newDirection)
		{
			return null;
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xF4BB64", Offset = "0xF4BB64", VA = "0xF4BB64")]
		private static MovementDirection HeadingToDirection(ConnectionHeadingEnum heading, CurvySplineSegment controlPoint, MovementDirection currentDirection)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xF4B474", Offset = "0xF4B474", VA = "0xF4B474")]
		private static float GetControlPointPosition(CurvySplineSegment controlPoint, CurvyPositionMode positionMode)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000C5")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D8424", Offset = "0x6D8424")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D8424", Offset = "0x6D8424")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D8424", Offset = "0x6D8424")]
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
				[Address(RVA = "0x11FA470", Offset = "0x11FA470", VA = "0x11FA470", Slot = "4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x11FA490", Offset = "0x11FA490", VA = "0x11FA490")]
			public void Load(List<UIVertex> verts, int index)
			{
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x11F7560", Offset = "0x11F7560", VA = "0x11F7560")]
			public void LoadTris(List<UIVertex> verts, int index)
			{
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x11FA6A8", Offset = "0x11FA6A8", VA = "0x11FA6A8")]
			public void calcRect()
			{
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x11FA71C", Offset = "0x11FA71C", VA = "0x11FA71C")]
			public void Save(List<UIVertex> verts, int index)
			{
			}

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x11F7778", Offset = "0x11F7778", VA = "0x11F7778")]
			public void Save(VertexHelper vh)
			{
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x11FA8D4", Offset = "0x11FA8D4", VA = "0x11FA8D4", Slot = "5")]
			public void Transpose(Vector3 v)
			{
			}

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x11FA944", Offset = "0x11FA944", VA = "0x11FA944", Slot = "6")]
			public void Rotate(Quaternion rotation)
			{
			}

			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x11F74F8", Offset = "0x11F74F8", VA = "0x11F74F8")]
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
				[Address(RVA = "0x11FA26C", Offset = "0x11FA26C", VA = "0x11FA26C", Slot = "4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x11F6BAC", Offset = "0x11F6BAC", VA = "0x11F6BAC")]
			public void Load(ref Vector3[] verts, int index)
			{
			}

			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x11FA28C", Offset = "0x11FA28C", VA = "0x11FA28C")]
			public void calcRect()
			{
			}

			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x11F7240", Offset = "0x11F7240", VA = "0x11F7240")]
			public void Save(ref Vector3[] verts, int index)
			{
			}

			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x11FA300", Offset = "0x11FA300", VA = "0x11FA300", Slot = "5")]
			public void Transpose(Vector3 v)
			{
			}

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x11FA370", Offset = "0x11FA370", VA = "0x11FA370", Slot = "6")]
			public void Rotate(Quaternion rotation)
			{
			}

			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x11F6B44", Offset = "0x11F6B44", VA = "0x11F6B44")]
			public GlyphPlain()
			{
			}
		}

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6DDA74", Offset = "0x6DDA74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DDA74", Offset = "0x6DDA74")]
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
			[Address(RVA = "0x11F6770", Offset = "0x11F6770", VA = "0x11F6770")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x11F6778", Offset = "0x11F6778", VA = "0x11F6778")]
			set
			{
			}
		}

		[Token(Token = "0x17000119")]
		protected override bool ShowOrientationSection
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x11F6784", Offset = "0x11F6784", VA = "0x11F6784", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011A")]
		protected override bool ShowOffsetSection
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x11F678C", Offset = "0x11F678C", VA = "0x11F678C", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011B")]
		protected Text Text
		{
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x11F6794", Offset = "0x11F6794", VA = "0x11F6794")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011C")]
		protected RectTransform Rect
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x11F6848", Offset = "0x11F6848", VA = "0x11F6848")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011D")]
		protected Graphic graphic
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x11F68FC", Offset = "0x11F68FC", VA = "0x11F68FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011E")]
		public override CurvySpline Spline
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x11F7904", Offset = "0x11F7904", VA = "0x11F7904", Slot = "37")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x11F790C", Offset = "0x11F790C", VA = "0x11F790C", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x11F69B0", Offset = "0x11F69B0", VA = "0x11F69B0", Slot = "15")]
		protected override void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x11F69F0", Offset = "0x11F69F0", VA = "0x11F69F0", Slot = "40")]
		public void ModifyMesh(Mesh verts)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x11F7378", Offset = "0x11F7378", VA = "0x11F7378", Slot = "41")]
		public void ModifyMesh(VertexHelper vertexHelper)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x11F6CE4", Offset = "0x11F6CE4", VA = "0x11F6CE4")]
		private void UpdateGlyph(IGlyph glyph)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x11F779C", Offset = "0x11F779C", VA = "0x11F779C", Slot = "7")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x11F7850", Offset = "0x11F7850", VA = "0x11F7850", Slot = "9")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x11F7C4C", Offset = "0x11F7C4C", VA = "0x11F7C4C", Slot = "19")]
		protected override void BindEvents()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x11F7C74", Offset = "0x11F7C74", VA = "0x11F7C74", Slot = "20")]
		protected override void UnbindEvents()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x11F7B08", Offset = "0x11F7B08", VA = "0x11F7B08")]
		private void BindSplineRelatedEvents()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x11F79CC", Offset = "0x11F79CC", VA = "0x11F79CC")]
		private void UnbindSplineRelatedEvents()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x11F7C9C", Offset = "0x11F7C9C", VA = "0x11F7C9C")]
		private void OnSplineRefreshed(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x11F7E38", Offset = "0x11F7E38", VA = "0x11F7E38")]
		public UITextSplineController()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D84CC", Offset = "0x6D84CC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D84CC", Offset = "0x6D84CC")]
	public class VolumeController : CurvyController
	{
		[Token(Token = "0x40002CD")]
		private const float CrossPositionRangeMin = -0.5f;

		[Token(Token = "0x40002CE")]
		private const float CrossPositionRangeMax = 0.5f;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[AttributeAttribute(Name = "CGDataReferenceSelectorAttribute", RVA = "0x6DDAF0", Offset = "0x6DDAF0")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6DDAF0", Offset = "0x6DDAF0")]
		private CGDataReference m_Volume;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[FloatRegion]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6DDBAC", Offset = "0x6DDBAC")]
		private FloatRegion m_CrossRange;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6DDC74", Offset = "0x6DDC74")]
		private float crossRelativePosition;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CurvyClamping m_CrossClamping;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[HideInInspector]
		[SerializeField]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6DDD1C", Offset = "0x6DDD1C")]
		private float m_CrossInitialPosition;

		[Token(Token = "0x17000122")]
		public CGDataReference Volume
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x11F878C", Offset = "0x11F878C", VA = "0x11F878C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x11F8794", Offset = "0x11F8794", VA = "0x11F8794")]
			set
			{
			}
		}

		[Token(Token = "0x17000123")]
		public CGVolume VolumeData
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x11F879C", Offset = "0x11F879C", VA = "0x11F879C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000124")]
		public float CrossFrom
		{
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x11F8810", Offset = "0x11F8810", VA = "0x11F8810")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x11F8818", Offset = "0x11F8818", VA = "0x11F8818")]
			set
			{
			}
		}

		[Token(Token = "0x17000125")]
		public float CrossTo
		{
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x11F8848", Offset = "0x11F8848", VA = "0x11F8848")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x11F8850", Offset = "0x11F8850", VA = "0x11F8850")]
			set
			{
			}
		}

		[Token(Token = "0x17000126")]
		public float CrossLength
		{
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x11F8880", Offset = "0x11F8880", VA = "0x11F8880")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000127")]
		public CurvyClamping CrossClamping
		{
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x11F888C", Offset = "0x11F888C", VA = "0x11F888C")]
			get
			{
				return default(CurvyClamping);
			}
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x11F8894", Offset = "0x11F8894", VA = "0x11F8894")]
			set
			{
			}
		}

		[Token(Token = "0x17000128")]
		public float CrossRelativePosition
		{
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x11F889C", Offset = "0x11F889C", VA = "0x11F889C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x11F88C8", Offset = "0x11F88C8", VA = "0x11F88C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000129")]
		public override float Length
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x11F88F8", Offset = "0x11F88F8", VA = "0x11F88F8", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700012A")]
		public override bool IsReady
		{
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x11F8A20", Offset = "0x11F8A20", VA = "0x11F8A20", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012B")]
		private RegionOptions<float> CrossRangeOptions
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x11F8F64", Offset = "0x11F8F64", VA = "0x11F8F64")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x1700012C")]
		private float MinCrossRelativePosition
		{
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x11F8FD4", Offset = "0x11F8FD4", VA = "0x11F8FD4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700012D")]
		private float MaxCrossRelativePosition
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x11F8FDC", Offset = "0x11F8FDC", VA = "0x11F8FDC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x11F8938", Offset = "0x11F8938", VA = "0x11F8938")]
		public float CrossRelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x11F89AC", Offset = "0x11F89AC", VA = "0x11F89AC")]
		public float CrossAbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x11F8A70", Offset = "0x11F8A70", VA = "0x11F8A70", Slot = "31")]
		protected override float RelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x11F8ACC", Offset = "0x11F8ACC", VA = "0x11F8ACC", Slot = "30")]
		protected override float AbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x11F8B28", Offset = "0x11F8B28", VA = "0x11F8B28", Slot = "32")]
		protected override Vector3 GetInterpolatedSourcePosition(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x11F8BC0", Offset = "0x11F8BC0", VA = "0x11F8BC0", Slot = "33")]
		protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x11F8CC4", Offset = "0x11F8CC4", VA = "0x11F8CC4", Slot = "35")]
		protected override Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x11F8D5C", Offset = "0x11F8D5C", VA = "0x11F8D5C", Slot = "34")]
		protected override Vector3 GetOrientation(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x11F8DF4", Offset = "0x11F8DF4", VA = "0x11F8DF4", Slot = "28")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x11F8E70", Offset = "0x11F8E70", VA = "0x11F8E70", Slot = "29")]
		protected override void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x11F88B4", Offset = "0x11F88B4", VA = "0x11F88B4")]
		private float GetClampedCrossPosition(float position)
		{
			return default(float);
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x11F8FE4", Offset = "0x11F8FE4", VA = "0x11F8FE4", Slot = "36")]
		public override void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x11F903C", Offset = "0x11F903C", VA = "0x11F903C")]
		public VolumeController()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Components
{
	[Token(Token = "0x20000CA")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D8530", Offset = "0x6D8530")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D8530", Offset = "0x6D8530")]
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
		[Address(RVA = "0xF11BA4", Offset = "0xF11BA4", VA = "0xF11BA4")]
		private void CreateLineMaterial()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xF11CC4", Offset = "0xF11CC4", VA = "0xF11CC4")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xF11EE4", Offset = "0xF11EE4", VA = "0xF11EE4")]
		private void sanitize()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xF12034", Offset = "0xF12034", VA = "0xF12034")]
		private void OnSplineRefresh(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xF121C0", Offset = "0xF121C0", VA = "0xF121C0")]
		private GLSlotData getSlot(CurvySpline spline)
		{
			return null;
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xF12380", Offset = "0xF12380", VA = "0xF12380")]
		public void Add(CurvySpline spline)
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xF12474", Offset = "0xF12474", VA = "0xF12474")]
		public void Remove(CurvySpline spline)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xF12598", Offset = "0xF12598", VA = "0xF12598")]
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
		[Address(RVA = "0x1219870", Offset = "0x1219870", VA = "0x1219870")]
		public void GetVertexData()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x12199F8", Offset = "0x12199F8", VA = "0x12199F8")]
		public void Render(Material mat)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x1219BE8", Offset = "0x1219BE8", VA = "0x1219BE8")]
		public GLSlotData()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D8590", Offset = "0x6D8590")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D8590", Offset = "0x6D8590")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D8590", Offset = "0x6D8590")]
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
			[Address(RVA = "0xF18648", Offset = "0xF18648", VA = "0xF18648")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0xF18650", Offset = "0xF18650", VA = "0xF18650")]
			set
			{
			}
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xF18BC8", Offset = "0xF18BC8", VA = "0xF18BC8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xF18D34", Offset = "0xF18D34", VA = "0xF18D34")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xF18D98", Offset = "0xF18D98", VA = "0xF18D98")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xF18D9C", Offset = "0xF18D9C", VA = "0xF18D9C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xF18DA0", Offset = "0xF18DA0", VA = "0xF18DA0")]
		private void Update()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xF18DA4", Offset = "0xF18DA4", VA = "0xF18DA4")]
		private void EnforceWorldSpaceUsage()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xF18A90", Offset = "0xF18A90", VA = "0xF18A90")]
		public void Refresh()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xF18F9C", Offset = "0xF18F9C", VA = "0xF18F9C")]
		private void OnSplineRefresh(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xF18FA0", Offset = "0xF18FA0", VA = "0xF18FA0")]
		private void OnSplineCoordinatesChanged(CurvySpline spline)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xF188CC", Offset = "0xF188CC", VA = "0xF188CC")]
		private void BindEvents()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xF18708", Offset = "0xF18708", VA = "0xF18708")]
		private void UnbindEvents()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xF18FA4", Offset = "0xF18FA4", VA = "0xF18FA4")]
		public CurvyLineRenderer()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Shapes
{
	[Token(Token = "0x20000CD")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D8648", Offset = "0x6D8648")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x6D8648", Offset = "0x6D8648")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D8648", Offset = "0x6D8648")]
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
			[Address(RVA = "0xEBFCD0", Offset = "0xEBFCD0", VA = "0xEBFCD0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0xEBFCD8", Offset = "0xEBFCD8", VA = "0xEBFCD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000130")]
		public float Radius
		{
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xEBFD18", Offset = "0xEBFD18", VA = "0xEBFD18")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0xEBFD20", Offset = "0xEBFD20", VA = "0xEBFD20")]
			set
			{
			}
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xEBFD64", Offset = "0xEBFD64", VA = "0xEBFD64", Slot = "4")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xEBFDD8", Offset = "0xEBFDD8", VA = "0xEBFDD8", Slot = "5")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xEBFF0C", Offset = "0xEBFF0C", VA = "0xEBFF0C")]
		public CSCircle()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D86F4", Offset = "0x6D86F4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D86F4", Offset = "0x6D86F4")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x6D86F4", Offset = "0x6D86F4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6DDE24", Offset = "0x6DDE24")]
		[SerializeField]
		private float m_Roundness;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6DDE64", Offset = "0x6DDE64")]
		private int m_Empty;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DDEE4", Offset = "0x6DDEE4")]
		private EatModeEnum m_Eat;

		[Token(Token = "0x17000131")]
		public float Roundness
		{
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0xEBFF20", Offset = "0xEBFF20", VA = "0xEBFF20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0xEBFF28", Offset = "0xEBFF28", VA = "0xEBFF28")]
			set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public int Empty
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xEBFF64", Offset = "0xEBFF64", VA = "0xEBFF64")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0xEBFF6C", Offset = "0xEBFF6C", VA = "0xEBFF6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000133")]
		private int maxEmpty
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0xEBFFB4", Offset = "0xEBFFB4", VA = "0xEBFFB4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000134")]
		public EatModeEnum Eat
		{
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0xEBFFBC", Offset = "0xEBFFBC", VA = "0xEBFFBC")]
			get
			{
				return default(EatModeEnum);
			}
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0xEBFFC4", Offset = "0xEBFFC4", VA = "0xEBFFC4")]
			set
			{
			}
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xEBFFE0", Offset = "0xEBFFE0", VA = "0xEBFFE0", Slot = "4")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xEC0068", Offset = "0xEC0068", VA = "0xEC0068")]
		private Vector3 cpPosition(int i, int empty, float d)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xEC00F4", Offset = "0xEC00F4", VA = "0xEC00F4", Slot = "5")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xEC0798", Offset = "0xEC0798", VA = "0xEC0798")]
		public CSPie()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D87A0", Offset = "0x6D87A0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D87A0", Offset = "0x6D87A0")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x6D87A0", Offset = "0x6D87A0")]
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
			[Address(RVA = "0xEC07B4", Offset = "0xEC07B4", VA = "0xEC07B4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0xEC07BC", Offset = "0xEC07BC", VA = "0xEC07BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public float Height
		{
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0xEC0800", Offset = "0xEC0800", VA = "0xEC0800")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0xEC0808", Offset = "0xEC0808", VA = "0xEC0808")]
			set
			{
			}
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xEC084C", Offset = "0xEC084C", VA = "0xEC084C", Slot = "4")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xEC08C0", Offset = "0xEC08C0", VA = "0xEC08C0", Slot = "5")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xEC0A68", Offset = "0xEC0A68", VA = "0xEC0A68")]
		public CSRectangle()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D884C", Offset = "0x6D884C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D884C", Offset = "0x6D884C")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x6D884C", Offset = "0x6D884C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6DE01C", Offset = "0x6DE01C")]
		[SerializeField]
		private float m_Roundness;

		[Token(Token = "0x17000137")]
		public float Width
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0xEC0A78", Offset = "0xEC0A78", VA = "0xEC0A78")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000604")]
			[Address(RVA = "0xEC0A80", Offset = "0xEC0A80", VA = "0xEC0A80")]
			set
			{
			}
		}

		[Token(Token = "0x17000138")]
		public float Height
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0xEC0AC4", Offset = "0xEC0AC4", VA = "0xEC0AC4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000606")]
			[Address(RVA = "0xEC0ACC", Offset = "0xEC0ACC", VA = "0xEC0ACC")]
			set
			{
			}
		}

		[Token(Token = "0x17000139")]
		public float Roundness
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0xEC0B10", Offset = "0xEC0B10", VA = "0xEC0B10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000608")]
			[Address(RVA = "0xEC0B18", Offset = "0xEC0B18", VA = "0xEC0B18")]
			set
			{
			}
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xEC0B54", Offset = "0xEC0B54", VA = "0xEC0B54", Slot = "4")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xEC0BEC", Offset = "0xEC0BEC", VA = "0xEC0BEC", Slot = "5")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xEC1150", Offset = "0xEC1150", VA = "0xEC1150")]
		public CSRoundedRectangle()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D88F8", Offset = "0x6D88F8")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x6D88F8", Offset = "0x6D88F8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D88F8", Offset = "0x6D88F8")]
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
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DE164", Offset = "0x6DE164")]
		private AnimationCurve m_RadiusFactor;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationCurve m_Z;

		[Token(Token = "0x1700013A")]
		public int Count
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0xEC1168", Offset = "0xEC1168", VA = "0xEC1168")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600060D")]
			[Address(RVA = "0xEC1170", Offset = "0xEC1170", VA = "0xEC1170")]
			set
			{
			}
		}

		[Token(Token = "0x1700013B")]
		public float Circles
		{
			[Token(Token = "0x600060E")]
			[Address(RVA = "0xEC11B0", Offset = "0xEC11B0", VA = "0xEC11B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600060F")]
			[Address(RVA = "0xEC11B8", Offset = "0xEC11B8", VA = "0xEC11B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700013C")]
		public float Radius
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0xEC11FC", Offset = "0xEC11FC", VA = "0xEC11FC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000611")]
			[Address(RVA = "0xEC1204", Offset = "0xEC1204", VA = "0xEC1204")]
			set
			{
			}
		}

		[Token(Token = "0x1700013D")]
		public AnimationCurve RadiusFactor
		{
			[Token(Token = "0x6000612")]
			[Address(RVA = "0xEC1248", Offset = "0xEC1248", VA = "0xEC1248")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000613")]
			[Address(RVA = "0xEC1250", Offset = "0xEC1250", VA = "0xEC1250")]
			set
			{
			}
		}

		[Token(Token = "0x1700013E")]
		public AnimationCurve Z
		{
			[Token(Token = "0x6000614")]
			[Address(RVA = "0xEC1288", Offset = "0xEC1288", VA = "0xEC1288")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000615")]
			[Address(RVA = "0xEC1290", Offset = "0xEC1290", VA = "0xEC1290")]
			set
			{
			}
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xEC12C8", Offset = "0xEC12C8", VA = "0xEC12C8", Slot = "4")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xEC13E4", Offset = "0xEC13E4", VA = "0xEC13E4", Slot = "5")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xEC1530", Offset = "0xEC1530", VA = "0xEC1530")]
		public CSSpiral()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D89A4", Offset = "0x6D89A4")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x6D89A4", Offset = "0x6D89A4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D89A4", Offset = "0x6D89A4")]
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
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6DE268", Offset = "0x6DE268")]
		private float m_OuterRoundness;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Positive]
		private float m_InnerRadius;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6DE310", Offset = "0x6DE310")]
		private float m_InnerRoundness;

		[Token(Token = "0x1700013F")]
		public int Sides
		{
			[Token(Token = "0x6000619")]
			[Address(RVA = "0xEC15C4", Offset = "0xEC15C4", VA = "0xEC15C4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600061A")]
			[Address(RVA = "0xEC15CC", Offset = "0xEC15CC", VA = "0xEC15CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000140")]
		public float OuterRadius
		{
			[Token(Token = "0x600061B")]
			[Address(RVA = "0xEC160C", Offset = "0xEC160C", VA = "0xEC160C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600061C")]
			[Address(RVA = "0xEC1614", Offset = "0xEC1614", VA = "0xEC1614")]
			set
			{
			}
		}

		[Token(Token = "0x17000141")]
		public float OuterRoundness
		{
			[Token(Token = "0x600061D")]
			[Address(RVA = "0xEC1660", Offset = "0xEC1660", VA = "0xEC1660")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600061E")]
			[Address(RVA = "0xEC1668", Offset = "0xEC1668", VA = "0xEC1668")]
			set
			{
			}
		}

		[Token(Token = "0x17000142")]
		public float InnerRadius
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0xEC16AC", Offset = "0xEC16AC", VA = "0xEC16AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000620")]
			[Address(RVA = "0xEC16B4", Offset = "0xEC16B4", VA = "0xEC16B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000143")]
		public float InnerRoundness
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0xEC16F8", Offset = "0xEC16F8", VA = "0xEC16F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000622")]
			[Address(RVA = "0xEC1700", Offset = "0xEC1700", VA = "0xEC1700")]
			set
			{
			}
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xEC1744", Offset = "0xEC1744", VA = "0xEC1744", Slot = "4")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xEC1830", Offset = "0xEC1830", VA = "0xEC1830", Slot = "5")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xEC1A1C", Offset = "0xEC1A1C", VA = "0xEC1A1C")]
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
		[Address(RVA = "0xF44028", Offset = "0xF44028", VA = "0xF44028")]
		public static Vector3 Addition(this Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xF44038", Offset = "0xF44038", VA = "0xF44038")]
		public static Vector3 UnaryNegation(this Vector3 a)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xF44048", Offset = "0xF44048", VA = "0xF44048")]
		public static Vector3 Subtraction(this Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xF44058", Offset = "0xF44058", VA = "0xF44058")]
		public static Vector3 Multiply(this Vector3 a, float d)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xF44068", Offset = "0xF44068", VA = "0xF44068")]
		public static Vector3 Multiply(this float d, Vector3 a)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xF4407C", Offset = "0xF4407C", VA = "0xF4407C")]
		public static Vector3 Division(this Vector3 a, float d)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xF44094", Offset = "0xF44094", VA = "0xF44094")]
		public static Vector3 Normalize(this Vector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xF44174", Offset = "0xF44174", VA = "0xF44174")]
		public static Vector3 LerpUnclamped(this Vector3 a, Vector3 b, float t)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000D5")]
	public static class CurvyUtility
	{
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x1213D68", Offset = "0x1213D68", VA = "0x1213D68")]
		public static float ClampTF(float tf, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x1213DDC", Offset = "0x1213DDC", VA = "0x1213DDC")]
		public static float ClampTF(float tf, ref int dir, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x1213EA8", Offset = "0x1213EA8", VA = "0x1213EA8")]
		public static float ClampValue(float tf, CurvyClamping clamping, float minTF, float maxTF)
		{
			return default(float);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x1213F94", Offset = "0x1213F94", VA = "0x1213F94")]
		public static float ClampDistance(float distance, CurvyClamping clamping, float length)
		{
			return default(float);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x1214020", Offset = "0x1214020", VA = "0x1214020")]
		public static float ClampDistance(float distance, CurvyClamping clamping, float length, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x1214124", Offset = "0x1214124", VA = "0x1214124")]
		public static float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float length)
		{
			return default(float);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x1214218", Offset = "0x1214218", VA = "0x1214218")]
		public static float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float length, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1214340", Offset = "0x1214340", VA = "0x1214340")]
		public static Material GetDefaultMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x121445C", Offset = "0x121445C", VA = "0x121445C")]
		public static bool Approximately(this float x, float y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x12108D0", Offset = "0x12108D0", VA = "0x12108D0")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DE380", Offset = "0x6DE380")]
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
			[Address(RVA = "0xF48FDC", Offset = "0xF48FDC", VA = "0xF48FDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5A90", Offset = "0x6E5A90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000639")]
			[Address(RVA = "0xF48FE4", Offset = "0xF48FE4", VA = "0xF48FE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5AA0", Offset = "0x6E5AA0")]
			private set
			{
			}
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xF48FEC", Offset = "0xF48FEC", VA = "0xF48FEC")]
		public bool Apply(out Mesh result)
		{
			return default(bool);
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xF49538", Offset = "0xF49538", VA = "0xF49538")]
		private bool triangulate()
		{
			return default(bool);
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xF498BC", Offset = "0xF498BC", VA = "0xF498BC")]
		private static bool polyLineIsValid(SplinePolyLine pl)
		{
			return default(bool);
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xF498FC", Offset = "0xF498FC", VA = "0xF498FC")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D8A70", Offset = "0x6D8A70")]
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
			[Address(RVA = "0x11EF2A8", Offset = "0x11EF2A8", VA = "0x11EF2A8")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x11FA19C", Offset = "0x11FA19C", VA = "0x11FA19C")]
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
			[Address(RVA = "0x11EEB10", Offset = "0x11EEB10", VA = "0x11EEB10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x11EEA18", Offset = "0x11EEA18", VA = "0x11EEA18")]
		public SplinePolyLine(CurvySpline spline)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x11EEAB8", Offset = "0x11EEAB8", VA = "0x11EEAB8")]
		public SplinePolyLine(CurvySpline spline, float angle, float distance)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x11EEA54", Offset = "0x11EEA54", VA = "0x11EEA54")]
		private SplinePolyLine(CurvySpline spline, VertexCalculation vertexMode, float angle, float distance, Space space = Space.World)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x11EEBA0", Offset = "0x11EEBA0", VA = "0x11EEBA0")]
		public Vector3[] GetVertices()
		{
			return null;
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x11EECD8", Offset = "0x11EECD8", VA = "0x11EECD8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DE390", Offset = "0x6DE390")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6DE390", Offset = "0x6DE390")]
		[SerializeField]
		private bool m_UseCache;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DE400", Offset = "0x6DE400")]
		[SerializeField]
		private bool m_UseGlobalSpace;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6DE44C", Offset = "0x6DE44C")]
		[SerializeField]
		protected CurvySplineSegment m_StartCP;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DE498", Offset = "0x6DE498")]
		[SerializeField]
		protected CurvySplineSegment m_EndCP;

		[Token(Token = "0x17000146")]
		public bool UseCache
		{
			[Token(Token = "0x6000646")]
			[Address(RVA = "0xF4BBF4", Offset = "0xF4BBF4", VA = "0xF4BBF4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000647")]
			[Address(RVA = "0xF4BBFC", Offset = "0xF4BBFC", VA = "0xF4BBFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000147")]
		public CurvySplineSegment StartCP
		{
			[Token(Token = "0x6000648")]
			[Address(RVA = "0xF4BC24", Offset = "0xF4BC24", VA = "0xF4BC24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000649")]
			[Address(RVA = "0xF4BC2C", Offset = "0xF4BC2C", VA = "0xF4BC2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000148")]
		public CurvySplineSegment EndCP
		{
			[Token(Token = "0x600064A")]
			[Address(RVA = "0xF4BCD4", Offset = "0xF4BCD4", VA = "0xF4BCD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600064B")]
			[Address(RVA = "0xF4BCDC", Offset = "0xF4BCDC", VA = "0xF4BCDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000149")]
		public bool UseGlobalSpace
		{
			[Token(Token = "0x600064C")]
			[Address(RVA = "0xF4BD84", Offset = "0xF4BD84", VA = "0xF4BD84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600064D")]
			[Address(RVA = "0xF4BD8C", Offset = "0xF4BD8C", VA = "0xF4BD8C")]
			set
			{
			}
		}

		[Token(Token = "0x1700014A")]
		public override bool IsConfigured
		{
			[Token(Token = "0x600064E")]
			[Address(RVA = "0xF4BDA0", Offset = "0xF4BDA0", VA = "0xF4BDA0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700014B")]
		public override bool IsInitialized
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0xF4BE44", Offset = "0xF4BE44", VA = "0xF4BE44", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700014C")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0xF4BF10", Offset = "0xF4BF10", VA = "0xF4BF10", Slot = "14")]
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
		[Address(RVA = "0xF4C02C", Offset = "0xF4C02C", VA = "0xF4C02C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xF4C074", Offset = "0xF4C074", VA = "0xF4C074", Slot = "6")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xF4C280", Offset = "0xF4C280", VA = "0xF4C280", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xF4C300", Offset = "0xF4C300", VA = "0xF4C300")]
		private void OnSplineRefreshed(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xF4C48C", Offset = "0xF4C48C", VA = "0xF4C48C")]
		private void OnInputSplineCoordinatesChanged(CurvySpline sender)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xF4C480", Offset = "0xF4C480", VA = "0xF4C480")]
		private void ForceRefresh()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xF4C64C", Offset = "0xF4C64C", VA = "0xF4C64C")]
		private float getPathLength(CurvySpline spline)
		{
			return default(float);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xF4BF68", Offset = "0xF4BF68", VA = "0xF4BF68")]
		private bool getPathClosed(CurvySpline spline)
		{
			return default(bool);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xF3C85C", Offset = "0xF3C85C", VA = "0xF3C85C")]
		protected CGData GetSplineData(CurvySpline spline, bool fullPath, CGDataRequestRasterization raster, CGDataRequestMetaCGOptions options)
		{
			return null;
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xF4C8E4", Offset = "0xF4C8E4", VA = "0xF4C8E4")]
		private static void FillData(CGShape dataToFill, SamplePointsMaterialGroup materialGroup, List<float> sourceFs, List<float> relativeFs, bool isFullPath, List<Vector3> positions, List<Vector3> tangents, List<Vector3> normals, bool considerSplineTransform, Transform splineTransform, Transform generatorTransform)
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xF4C75C", Offset = "0xF4C75C", VA = "0xF4C75C")]
		private static void AddPoint(float sourceF, float relativeF, bool isFullPath, Vector3 position, Vector3 tangent, Vector3 up, List<float> sourceFList, List<float> relativeFList, List<Vector3> positionList, List<Vector3> tangentList, List<Vector3> upList)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xF4CC78", Offset = "0xF4CC78", VA = "0xF4CC78")]
		private static bool MoveByAngleExt(CurvySpline spline, bool useCache, ref float tf, float maxDistance, float maxAngle, out Vector3 pos, out Vector3 tan, float stopTF, bool loop, float stepDist)
		{
			return default(bool);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xF4CE88", Offset = "0xF4CE88", VA = "0xF4CE88")]
		private static void CalculateExtendedUV(CurvySpline spline, float startTF, float endTF, List<SamplePointUData> ext, CGShape data)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xF4D68C", Offset = "0xF4D68C", VA = "0xF4D68C")]
		private static MetaCGOptions findPreviousReferenceCPOptions(CurvySpline spline, float tf, out CurvySplineSegment cp)
		{
			return null;
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xF4D800", Offset = "0xF4D800", VA = "0xF4D800")]
		private static MetaCGOptions findNextReferenceCPOptions(CurvySpline spline, float tf, out CurvySplineSegment cp)
		{
			return null;
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xF3E624", Offset = "0xF3E624", VA = "0xF3E624", Slot = "17")]
		protected virtual void OnSplineAssigned()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xF3C3B0", Offset = "0xF3C3B0", VA = "0xF3C3B0")]
		protected void ValidateStartAndEndCps()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xF3E060", Offset = "0xF3E060", VA = "0xF3E060")]
		protected SplineInputModuleBase()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public abstract class TRSModuleBase : CGModule
	{
		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6DE500", Offset = "0x6DE500")]
		[SerializeField]
		private Vector3 m_Transpose;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6DE568", Offset = "0x6DE568")]
		private Vector3 m_Rotation;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6DE5D0", Offset = "0x6DE5D0")]
		private Vector3 m_Scale;

		[Token(Token = "0x1700014E")]
		public Vector3 Transpose
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x11EF684", Offset = "0x11EF684", VA = "0x11EF684")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x11EF690", Offset = "0x11EF690", VA = "0x11EF690")]
			set
			{
			}
		}

		[Token(Token = "0x1700014F")]
		public Vector3 Rotation
		{
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x11EF700", Offset = "0x11EF700", VA = "0x11EF700")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000668")]
			[Address(RVA = "0x11EF70C", Offset = "0x11EF70C", VA = "0x11EF70C")]
			set
			{
			}
		}

		[Token(Token = "0x17000150")]
		public Vector3 Scale
		{
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x11EF77C", Offset = "0x11EF77C", VA = "0x11EF77C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x11EF788", Offset = "0x11EF788", VA = "0x11EF788")]
			set
			{
			}
		}

		[Token(Token = "0x17000151")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x11EF7F8", Offset = "0x11EF7F8", VA = "0x11EF7F8")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x11EF89C", Offset = "0x11EF89C", VA = "0x11EF89C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x11EF8E4", Offset = "0x11EF8E4", VA = "0x11EF8E4", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x11EF934", Offset = "0x11EF934", VA = "0x11EF934")]
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
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6D8A80", Offset = "0x6D8A80")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DE648", Offset = "0x6DE648")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DE79C", Offset = "0x6DE79C")]
		[SerializeField]
		private bool m_IgnoreModuleCrossBase;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DE7E8", Offset = "0x6DE7E8")]
		private bool m_RandomizeItems;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[IntRegion]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DE834", Offset = "0x6DE834")]
		private IntRegion m_RepeatingItems;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DE8BC", Offset = "0x6DE8BC")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DE9E4", Offset = "0x6DE9E4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DEB10", Offset = "0x6DEB10")]
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
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6DEC44", Offset = "0x6DEC44")]
		[SerializeField]
		[HideInInspector]
		private DistributionModeEnum m_DistributionMode;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6DECA0", Offset = "0x6DECA0")]
		[FloatRegion]
		private FloatRegion m_PositionOffset;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[HideInInspector]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6DED44", Offset = "0x6DED44")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_Height;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6DEDC0", Offset = "0x6DEDC0")]
		private CurvyRepeatingOrderEnum m_RepeatingOrder;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6DEE1C", Offset = "0x6DEE1C")]
		[HideInInspector]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6DEE1C", Offset = "0x6DEE1C")]
		private Vector3 m_RotationOffset;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[HideInInspector]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6DEEB8", Offset = "0x6DEEB8")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6DEEB8", Offset = "0x6DEEB8")]
		[SerializeField]
		private Vector3 m_RotationScatter;

		[Token(Token = "0x17000152")]
		public string Name
		{
			[Token(Token = "0x600066F")]
			[Address(RVA = "0xF6EE38", Offset = "0xF6EE38", VA = "0xF6EE38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000670")]
			[Address(RVA = "0xF6EE40", Offset = "0xF6EE40", VA = "0xF6EE40")]
			set
			{
			}
		}

		[Token(Token = "0x17000153")]
		public bool KeepTogether
		{
			[Token(Token = "0x6000671")]
			[Address(RVA = "0xF6EE88", Offset = "0xF6EE88", VA = "0xF6EE88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000672")]
			[Address(RVA = "0xF6EE90", Offset = "0xF6EE90", VA = "0xF6EE90")]
			set
			{
			}
		}

		[Token(Token = "0x17000154")]
		public FloatRegion SpaceBefore
		{
			[Token(Token = "0x6000673")]
			[Address(RVA = "0xF6EEB0", Offset = "0xF6EEB0", VA = "0xF6EEB0")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000674")]
			[Address(RVA = "0xF6EEC0", Offset = "0xF6EEC0", VA = "0xF6EEC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000155")]
		public FloatRegion SpaceAfter
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0xF6EF10", Offset = "0xF6EF10", VA = "0xF6EF10")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000676")]
			[Address(RVA = "0xF6EF20", Offset = "0xF6EF20", VA = "0xF6EF20")]
			set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public bool RandomizeItems
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0xF6EF70", Offset = "0xF6EF70", VA = "0xF6EF70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000678")]
			[Address(RVA = "0xF6EF78", Offset = "0xF6EF78", VA = "0xF6EF78")]
			set
			{
			}
		}

		[Token(Token = "0x17000157")]
		public IntRegion RepeatingItems
		{
			[Token(Token = "0x6000679")]
			[Address(RVA = "0xF6EF98", Offset = "0xF6EF98", VA = "0xF6EF98")]
			get
			{
				return default(IntRegion);
			}
			[Token(Token = "0x600067A")]
			[Address(RVA = "0xF6EFA8", Offset = "0xF6EFA8", VA = "0xF6EFA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000158")]
		public FloatRegion CrossBase
		{
			[Token(Token = "0x600067B")]
			[Address(RVA = "0xF6EFF8", Offset = "0xF6EFF8", VA = "0xF6EFF8")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x600067C")]
			[Address(RVA = "0xF6F008", Offset = "0xF6F008", VA = "0xF6F008")]
			set
			{
			}
		}

		[Token(Token = "0x17000159")]
		public bool IgnoreModuleCrossBase
		{
			[Token(Token = "0x600067D")]
			[Address(RVA = "0xF6F058", Offset = "0xF6F058", VA = "0xF6F058")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600067E")]
			[Address(RVA = "0xF6F060", Offset = "0xF6F060", VA = "0xF6F060")]
			set
			{
			}
		}

		[Token(Token = "0x1700015A")]
		public RotationModeEnum RotationMode
		{
			[Token(Token = "0x600067F")]
			[Address(RVA = "0xF6F080", Offset = "0xF6F080", VA = "0xF6F080")]
			get
			{
				return default(RotationModeEnum);
			}
			[Token(Token = "0x6000680")]
			[Address(RVA = "0xF6F088", Offset = "0xF6F088", VA = "0xF6F088")]
			set
			{
			}
		}

		[Token(Token = "0x1700015B")]
		public FloatRegion RotationX
		{
			[Token(Token = "0x6000681")]
			[Address(RVA = "0xF6F09C", Offset = "0xF6F09C", VA = "0xF6F09C")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000682")]
			[Address(RVA = "0xF6E7F4", Offset = "0xF6E7F4", VA = "0xF6E7F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700015C")]
		public FloatRegion RotationY
		{
			[Token(Token = "0x6000683")]
			[Address(RVA = "0xF6F0AC", Offset = "0xF6F0AC", VA = "0xF6F0AC")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000684")]
			[Address(RVA = "0xF6E844", Offset = "0xF6E844", VA = "0xF6E844")]
			set
			{
			}
		}

		[Token(Token = "0x1700015D")]
		public FloatRegion RotationZ
		{
			[Token(Token = "0x6000685")]
			[Address(RVA = "0xF6F0BC", Offset = "0xF6F0BC", VA = "0xF6F0BC")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000686")]
			[Address(RVA = "0xF6E894", Offset = "0xF6E894", VA = "0xF6E894")]
			set
			{
			}
		}

		[Token(Token = "0x1700015E")]
		public bool UniformScaling
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0xF6F0CC", Offset = "0xF6F0CC", VA = "0xF6F0CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000688")]
			[Address(RVA = "0xF6E8E4", Offset = "0xF6E8E4", VA = "0xF6E8E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700015F")]
		public FloatRegion ScaleX
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0xF6F0D4", Offset = "0xF6F0D4", VA = "0xF6F0D4")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x600068A")]
			[Address(RVA = "0xF6E904", Offset = "0xF6E904", VA = "0xF6E904")]
			set
			{
			}
		}

		[Token(Token = "0x17000160")]
		public FloatRegion ScaleY
		{
			[Token(Token = "0x600068B")]
			[Address(RVA = "0xF6F0E4", Offset = "0xF6F0E4", VA = "0xF6F0E4")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x600068C")]
			[Address(RVA = "0xF6E954", Offset = "0xF6E954", VA = "0xF6E954")]
			set
			{
			}
		}

		[Token(Token = "0x17000161")]
		public FloatRegion ScaleZ
		{
			[Token(Token = "0x600068D")]
			[Address(RVA = "0xF6F0F4", Offset = "0xF6F0F4", VA = "0xF6F0F4")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x600068E")]
			[Address(RVA = "0xF6E9A4", Offset = "0xF6E9A4", VA = "0xF6E9A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000162")]
		public bool RelativeTranslation
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0xF6F104", Offset = "0xF6F104", VA = "0xF6F104")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000690")]
			[Address(RVA = "0xF6E6E4", Offset = "0xF6E6E4", VA = "0xF6E6E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000163")]
		public FloatRegion TranslationX
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0xF6F10C", Offset = "0xF6F10C", VA = "0xF6F10C")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000692")]
			[Address(RVA = "0xF6E704", Offset = "0xF6E704", VA = "0xF6E704")]
			set
			{
			}
		}

		[Token(Token = "0x17000164")]
		public FloatRegion TranslationY
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0xF6F11C", Offset = "0xF6F11C", VA = "0xF6F11C")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000694")]
			[Address(RVA = "0xF6E754", Offset = "0xF6E754", VA = "0xF6E754")]
			set
			{
			}
		}

		[Token(Token = "0x17000165")]
		public FloatRegion TranslationZ
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0xF6F12C", Offset = "0xF6F12C", VA = "0xF6F12C")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000696")]
			[Address(RVA = "0xF6E7A4", Offset = "0xF6E7A4", VA = "0xF6E7A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000166")]
		public List<CGBoundsGroupItem> Items
		{
			[Token(Token = "0x6000697")]
			[Address(RVA = "0xF6F13C", Offset = "0xF6F13C", VA = "0xF6F13C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000167")]
		public int FirstRepeating
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0xF6D780", Offset = "0xF6D780", VA = "0xF6D780")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000699")]
			[Address(RVA = "0xF6F144", Offset = "0xF6F144", VA = "0xF6F144")]
			set
			{
			}
		}

		[Token(Token = "0x17000168")]
		public int LastRepeating
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0xF6D788", Offset = "0xF6D788", VA = "0xF6D788")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600069B")]
			[Address(RVA = "0xF6F19C", Offset = "0xF6F19C", VA = "0xF6F19C")]
			set
			{
			}
		}

		[Token(Token = "0x17000169")]
		public int ItemCount
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0xF6C95C", Offset = "0xF6C95C", VA = "0xF6C95C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700016A")]
		private RegionOptions<int> RepeatingGroupsOptions
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0xF6F200", Offset = "0xF6F200", VA = "0xF6F200")]
			get
			{
				return default(RegionOptions<int>);
			}
		}

		[Token(Token = "0x1700016B")]
		private RegionOptions<float> PositionRangeOptions
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0xF6F294", Offset = "0xF6F294", VA = "0xF6F294")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xF6D458", Offset = "0xF6D458", VA = "0xF6D458")]
		public CGBoundsGroup(string name)
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xF6E228", Offset = "0xF6E228", VA = "0xF6E228")]
		public static void FillItemBag(WeightedRandom<int> bag, IEnumerable<CGWeightedItem> itemsWeights, int firstItem, int lastItem)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xF6E9F4", Offset = "0xF6E9F4", VA = "0xF6E9F4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6E5AB0", Offset = "0x6E5AB0")]
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
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6D8AB8", Offset = "0x6D8AB8")]
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
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6DEF54", Offset = "0x6DEF54")]
		[SerializeField]
		private int m_Index;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6DEFBC", Offset = "0x6DEFBC")]
		[SerializeField]
		private Vector3 m_Position;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6DF030", Offset = "0x6DF030")]
		[SerializeField]
		private Quaternion m_Rotation;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6DF0A4", Offset = "0x6DF0A4")]
		[SerializeField]
		private Vector3 m_Scale;

		[Token(Token = "0x1700016C")]
		public int Index
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0xEBAD50", Offset = "0xEBAD50", VA = "0xEBAD50")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700016D")]
		public Vector3 Position
		{
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0xEBAD58", Offset = "0xEBAD58", VA = "0xEBAD58")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0xEBAD64", Offset = "0xEBAD64", VA = "0xEBAD64")]
			set
			{
			}
		}

		[Token(Token = "0x1700016E")]
		public Quaternion Rotation
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0xEBADC8", Offset = "0xEBADC8", VA = "0xEBADC8")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0xEBADD4", Offset = "0xEBADD4", VA = "0xEBADD4")]
			set
			{
			}
		}

		[Token(Token = "0x1700016F")]
		public Vector3 Scale
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0xEBAE40", Offset = "0xEBAE40", VA = "0xEBAE40")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0xEBAE4C", Offset = "0xEBAE4C", VA = "0xEBAE4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000170")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0xEBAEB0", Offset = "0xEBAEB0", VA = "0xEBAEB0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xEBAF10", Offset = "0xEBAF10", VA = "0xEBAF10")]
		public CGSpot(int index)
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xEBAF9C", Offset = "0xEBAF9C", VA = "0xEBAF9C")]
		public CGSpot(int index, Vector3 position, Quaternion rotation, Vector3 scale)
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xEBAFC4", Offset = "0xEBAFC4", VA = "0xEBAFC4")]
		public void ToTransform(Transform transform)
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xEBB024", Offset = "0xEBB024", VA = "0xEBB024", Slot = "4")]
		public bool Equals(CGSpot other)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xEBB0A4", Offset = "0xEBB0A4", VA = "0xEBB0A4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xEBB140", Offset = "0xEBB140", VA = "0xEBB140", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xEBB1B4", Offset = "0xEBB1B4", VA = "0xEBB1B4")]
		public static bool operator ==(CGSpot left, CGSpot right)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xEBB1E8", Offset = "0xEBB1E8", VA = "0xEBB1E8")]
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
		[Address(RVA = "0xF676B8", Offset = "0xF676B8", VA = "0xF676B8")]
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
		[Address(RVA = "0xF69070", Offset = "0xF69070", VA = "0xF69070")]
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
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6DF138", Offset = "0x6DF138")]
		[SerializeField]
		private Vector3 m_Translation;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6DF1A0", Offset = "0x6DF1A0")]
		[SerializeField]
		private Vector3 m_Rotation;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6DF208", Offset = "0x6DF208")]
		[SerializeField]
		private Vector3 m_Scale;

		[Token(Token = "0x17000171")]
		public Mesh Mesh
		{
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0xF70F28", Offset = "0xF70F28", VA = "0xF70F28")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0xF70F30", Offset = "0xF70F30", VA = "0xF70F30")]
			set
			{
			}
		}

		[Token(Token = "0x17000172")]
		public Material[] Material
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0xF71064", Offset = "0xF71064", VA = "0xF71064")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0xF7106C", Offset = "0xF7106C", VA = "0xF7106C")]
			set
			{
			}
		}

		[Token(Token = "0x17000173")]
		public Vector3 Translation
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0xF71084", Offset = "0xF71084", VA = "0xF71084")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0xF71090", Offset = "0xF71090", VA = "0xF71090")]
			set
			{
			}
		}

		[Token(Token = "0x17000174")]
		public Vector3 Rotation
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0xF710F4", Offset = "0xF710F4", VA = "0xF710F4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0xF71100", Offset = "0xF71100", VA = "0xF71100")]
			set
			{
			}
		}

		[Token(Token = "0x17000175")]
		public Vector3 Scale
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0xF71164", Offset = "0xF71164", VA = "0xF71164")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0xF71170", Offset = "0xF71170", VA = "0xF71170")]
			set
			{
			}
		}

		[Token(Token = "0x17000176")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0xF711D4", Offset = "0xF711D4", VA = "0xF711D4")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xF71278", Offset = "0xF71278", VA = "0xF71278")]
		public CGMeshProperties()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xF712F0", Offset = "0xF712F0", VA = "0xF712F0")]
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
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6DF280", Offset = "0x6DF280")]
		[SerializeField]
		private Vector3 m_Translation;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6DF2E8", Offset = "0x6DF2E8")]
		private Vector3 m_Rotation;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6DF350", Offset = "0x6DF350")]
		[SerializeField]
		private Vector3 m_Scale;

		[Token(Token = "0x17000177")]
		public GameObject Object
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0xF70710", Offset = "0xF70710", VA = "0xF70710")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0xF70718", Offset = "0xF70718", VA = "0xF70718")]
			set
			{
			}
		}

		[Token(Token = "0x17000178")]
		public Vector3 Translation
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0xF707B4", Offset = "0xF707B4", VA = "0xF707B4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0xF707C0", Offset = "0xF707C0", VA = "0xF707C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000179")]
		public Vector3 Rotation
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0xF70824", Offset = "0xF70824", VA = "0xF70824")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0xF70830", Offset = "0xF70830", VA = "0xF70830")]
			set
			{
			}
		}

		[Token(Token = "0x1700017A")]
		public Vector3 Scale
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0xF70894", Offset = "0xF70894", VA = "0xF70894")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0xF708A0", Offset = "0xF708A0", VA = "0xF708A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700017B")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0xF70904", Offset = "0xF70904", VA = "0xF70904")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xF709A8", Offset = "0xF709A8", VA = "0xF709A8")]
		public CGGameObjectProperties()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xF709DC", Offset = "0xF709DC", VA = "0xF709DC")]
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
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6DF3B8", Offset = "0x6DF3B8")]
		private float m_Weight;

		[Token(Token = "0x1700017C")]
		public float Weight
		{
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0xEBFC84", Offset = "0xEBFC84", VA = "0xEBFC84")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0xEBFC8C", Offset = "0xEBFC8C", VA = "0xEBFC8C")]
			set
			{
			}
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xEBFCC0", Offset = "0xEBFCC0", VA = "0xEBFCC0")]
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
		[Address(RVA = "0xF6D708", Offset = "0xF6D708", VA = "0xF6D708")]
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
		[Address(RVA = "0xEBBBD4", Offset = "0xEBBBD4", VA = "0xEBBBD4")]
		public ControlPointOption(float tf, float dist, bool includeAnyways, int materialID, bool hardEdge, float maxStepDistance, bool uvEdge, bool uvShift, float firstU, float secondU)
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xEC5858", Offset = "0xEC5858", VA = "0xEC5858", Slot = "4")]
		public bool Equals(ControlPointOption other)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xEC5970", Offset = "0xEC5970", VA = "0xEC5970", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xEC5A0C", Offset = "0xEC5A0C", VA = "0xEC5A0C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xEC5B20", Offset = "0xEC5B20", VA = "0xEC5B20")]
		public static bool operator ==(ControlPointOption left, ControlPointOption right)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xEC5B54", Offset = "0xEC5B54", VA = "0xEC5B54")]
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
			[Address(RVA = "0xF47BCC", Offset = "0xF47BCC", VA = "0xF47BCC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0xF48218", Offset = "0xF48218", VA = "0xF48218")]
			set
			{
			}
		}

		[Token(Token = "0x1700017E")]
		public int TriangleCount
		{
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0xF47AE8", Offset = "0xF47AE8", VA = "0xF47AE8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xF4824C", Offset = "0xF4824C", VA = "0xF4824C")]
		public SamplePointsPatch(int start)
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xF48254", Offset = "0xF48254", VA = "0xF48254", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xF4848C", Offset = "0xF4848C", VA = "0xF4848C", Slot = "4")]
		public bool Equals(SamplePointsPatch other)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xF484B4", Offset = "0xF484B4", VA = "0xF484B4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xF48548", Offset = "0xF48548", VA = "0xF48548", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xF4855C", Offset = "0xF4855C", VA = "0xF4855C")]
		public static bool operator ==(SamplePointsPatch left, SamplePointsPatch right)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xF4857C", Offset = "0xF4857C", VA = "0xF4857C")]
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
			[Address(RVA = "0xF47A34", Offset = "0xF47A34", VA = "0xF47A34")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000180")]
		public int StartVertex
		{
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0xF47AF4", Offset = "0xF47AF4", VA = "0xF47AF4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000181")]
		public int EndVertex
		{
			[Token(Token = "0x60006E2")]
			[Address(RVA = "0xF47B54", Offset = "0xF47B54", VA = "0xF47B54")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000182")]
		public int VertexCount
		{
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0xF47BD8", Offset = "0xF47BD8", VA = "0xF47BD8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xF47C0C", Offset = "0xF47C0C", VA = "0xF47C0C")]
		public SamplePointsMaterialGroup(int materialID)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xF47CA4", Offset = "0xF47CA4", VA = "0xF47CA4")]
		public void GetLengths(CGVolume volume, out float worldLength, out float uLength)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xF47E00", Offset = "0xF47E00", VA = "0xF47E00")]
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
		[Address(RVA = "0xF475EC", Offset = "0xF475EC", VA = "0xF475EC")]
		public SamplePointUData(int vt, bool uvEdge, float uv0, float uv1)
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xF47600", Offset = "0xF47600", VA = "0xF47600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xF47858", Offset = "0xF47858", VA = "0xF47858", Slot = "4")]
		public bool Equals(SamplePointUData other)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xF478D4", Offset = "0xF478D4", VA = "0xF478D4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xF4795C", Offset = "0xF4795C", VA = "0xF4795C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xF479D0", Offset = "0xF479D0", VA = "0xF479D0")]
		public static bool operator ==(SamplePointUData left, SamplePointUData right)
		{
			return default(bool);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xF47A00", Offset = "0xF47A00", VA = "0xF47A00")]
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
			[Address(RVA = "0xF47EC4", Offset = "0xF47EC4", VA = "0xF47EC4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xF47F70", Offset = "0xF47F70", VA = "0xF47F70")]
		public SamplePointsMaterialGroupCollection()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xF47FF0", Offset = "0xF47FF0", VA = "0xF47FF0")]
		public SamplePointsMaterialGroupCollection(int capacity)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xF48080", Offset = "0xF48080", VA = "0xF48080")]
		public SamplePointsMaterialGroupCollection(IEnumerable<SamplePointsMaterialGroup> collection)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xF48110", Offset = "0xF48110", VA = "0xF48110")]
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
			[Address(RVA = "0xF6F4E8", Offset = "0xF6F4E8", VA = "0xF6F4E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000185")]
		public CGModuleOutputSlot Slot
		{
			[Token(Token = "0x60006F4")]
			[Address(RVA = "0xF6F55C", Offset = "0xF6F55C", VA = "0xF6F55C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000186")]
		public bool HasValue
		{
			[Token(Token = "0x60006F5")]
			[Address(RVA = "0xF6F77C", Offset = "0xF6F77C", VA = "0xF6F77C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000187")]
		public bool IsEmpty
		{
			[Token(Token = "0x60006F6")]
			[Address(RVA = "0xF6F7AC", Offset = "0xF6F7AC", VA = "0xF6F7AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000188")]
		public CGModule Module
		{
			[Token(Token = "0x60006F7")]
			[Address(RVA = "0xF6F7B8", Offset = "0xF6F7B8", VA = "0xF6F7B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000189")]
		public string SlotName
		{
			[Token(Token = "0x60006F8")]
			[Address(RVA = "0xF6F7C0", Offset = "0xF6F7C0", VA = "0xF6F7C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xF6F7C8", Offset = "0xF6F7C8", VA = "0xF6F7C8")]
		public CGDataReference()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xF6F7D0", Offset = "0xF6F7D0", VA = "0xF6F7D0")]
		public CGDataReference(CGModule module, string slotName)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xF6F854", Offset = "0xF6F854", VA = "0xF6F854")]
		public CGDataReference(CurvyGenerator generator, string moduleName, string slotName)
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xF6F904", Offset = "0xF6F904", VA = "0xF6F904")]
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
		[Address(RVA = "0xF6F810", Offset = "0xF6F810", VA = "0xF6F810")]
		public void setINTERNAL(CGModule module, string slotName)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xF6F89C", Offset = "0xF6F89C", VA = "0xF6F89C")]
		public void setINTERNAL(CurvyGenerator generator, string moduleName, string slotName)
		{
		}
	}
	[Token(Token = "0x20000F1")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6D8AC8", Offset = "0x6D8AC8")]
	public sealed class CGDataInfoAttribute : Attribute
	{
		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Color Color;

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xF6F3EC", Offset = "0xF6F3EC", VA = "0xF6F3EC")]
		public CGDataInfoAttribute(Color color)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xF6F438", Offset = "0xF6F438", VA = "0xF6F438")]
		public CGDataInfoAttribute(float r, float g, float b, float a = 1f)
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xF6F4AC", Offset = "0xF6F4AC", VA = "0xF6F4AC")]
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
			[Address(RVA = "0xF6F304", Offset = "0xF6F304", VA = "0xF6F304", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xF66EB0", Offset = "0xF66EB0", VA = "0xF66EB0")]
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
		[Address(RVA = "0xF6F30C", Offset = "0xF6F30C", VA = "0xF6F30C")]
		protected int getGenericFIndex(ref float[] FMapArray, float fValue, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xF6ED30", Offset = "0xF6ED30", VA = "0xF6ED30")]
		public CGData()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x6D8ADC", Offset = "0x6D8ADC")]
	public class CGShape : CGData
	{
		[Serializable]
		[Token(Token = "0x20000F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D8B08", Offset = "0x6D8B08")]
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
			[Address(RVA = "0x11F92F8", Offset = "0x11F92F8", VA = "0x11F92F8")]
			public <>c()
			{
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x11F9300", Offset = "0x11F9300", VA = "0x11F9300")]
			internal SamplePointsMaterialGroup <.ctor>b__16_0(SamplePointsMaterialGroup g)
			{
				return null;
			}

			[Token(Token = "0x600071C")]
			[Address(RVA = "0x11F931C", Offset = "0x11F931C", VA = "0x11F931C")]
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
			[Address(RVA = "0xEBA11C", Offset = "0xEBA11C", VA = "0xEBA11C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xEB8610", Offset = "0xEB8610", VA = "0xEB8610")]
		public CGShape()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xEB8820", Offset = "0xEB8820", VA = "0xEB8820")]
		public CGShape(CGShape source)
		{
		}

		[Token(Token = "0x600070C")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xEB8D00", Offset = "0xEB8D00", VA = "0xEB8D00")]
		public static void Copy(CGShape dest, CGShape source)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xEBA138", Offset = "0xEBA138", VA = "0xEBA138")]
		public void Copy(CGShape source)
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xEBA13C", Offset = "0xEBA13C", VA = "0xEBA13C")]
		public float DistanceToF(float distance)
		{
			return default(float);
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xEBA170", Offset = "0xEBA170", VA = "0xEBA170")]
		public float FToDistance(float f)
		{
			return default(float);
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xEB9130", Offset = "0xEB9130", VA = "0xEB9130")]
		public int GetFIndex(float f, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xEBA19C", Offset = "0xEBA19C", VA = "0xEBA19C")]
		public Vector3 InterpolatePosition(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xEBA248", Offset = "0xEBA248", VA = "0xEBA248")]
		public Vector3 InterpolateUp(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xEBA2F4", Offset = "0xEBA2F4", VA = "0xEBA2F4")]
		public void Interpolate(float f, out Vector3 position, out Vector3 up)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xEBA428", Offset = "0xEBA428", VA = "0xEBA428")]
		public void Move(ref float f, ref int direction, float speed, CurvyClamping clamping)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xEBA46C", Offset = "0xEBA46C", VA = "0xEBA46C")]
		public void MoveBy(ref float f, ref int direction, float speedDist, CurvyClamping clamping)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xEB9468", Offset = "0xEB9468", VA = "0xEB9468", Slot = "6")]
		public virtual void Recalculate()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xEBA4F8", Offset = "0xEBA4F8", VA = "0xEBA4F8")]
		public void RecalculateNormals(List<int> softEdges)
		{
		}
	}
	[Token(Token = "0x20000F5")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x6D8B18", Offset = "0x6D8B18")]
	public class CGPath : CGShape
	{
		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3[] Direction;

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xEB85AC", Offset = "0xEB85AC", VA = "0xEB85AC")]
		public CGPath()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xEB8758", Offset = "0xEB8758", VA = "0xEB8758")]
		public CGPath(CGPath source)
		{
		}

		[Token(Token = "0x600071F")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xEB8C68", Offset = "0xEB8C68", VA = "0xEB8C68")]
		public static void Copy(CGPath dest, CGPath source)
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xEB8FA0", Offset = "0xEB8FA0", VA = "0xEB8FA0")]
		public void Interpolate(float f, out Vector3 position, out Vector3 direction, out Vector3 up)
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xEB91A0", Offset = "0xEB91A0", VA = "0xEB91A0")]
		public void Interpolate(float f, float angleF, out Vector3 pos, out Vector3 dir, out Vector3 up)
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xEB920C", Offset = "0xEB920C", VA = "0xEB920C")]
		public Vector3 InterpolateDirection(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xEB92B8", Offset = "0xEB92B8", VA = "0xEB92B8", Slot = "6")]
		public override void Recalculate()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x6D8B44", Offset = "0x6D8B44")]
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
			[Address(RVA = "0xEBC008", Offset = "0xEBC008", VA = "0xEBC008")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700018D")]
		public int VertexCount
		{
			[Token(Token = "0x6000726")]
			[Address(RVA = "0xEBE6B8", Offset = "0xEBE6B8", VA = "0xEBE6B8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xEBE6D4", Offset = "0xEBE6D4", VA = "0xEBE6D4")]
		public CGVolume()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xEBE7A0", Offset = "0xEBE7A0", VA = "0xEBE7A0")]
		public CGVolume(int samplePoints, CGShape crossShape)
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xEBEA18", Offset = "0xEBEA18", VA = "0xEBEA18")]
		public CGVolume(CGPath path, CGShape crossShape)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xEBEC98", Offset = "0xEBEC98", VA = "0xEBEC98")]
		public CGVolume(CGVolume source)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xEBEF4C", Offset = "0xEBEF4C", VA = "0xEBEF4C")]
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
		[Address(RVA = "0xEBF160", Offset = "0xEBF160", VA = "0xEBF160")]
		public void InterpolateVolume(float f, float crossF, out Vector3 pos, out Vector3 dir, out Vector3 up)
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xEBF39C", Offset = "0xEBF39C", VA = "0xEBF39C")]
		public Vector3 InterpolateVolumePosition(float f, float crossF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xEBF508", Offset = "0xEBF508", VA = "0xEBF508")]
		public Vector3 InterpolateVolumeDirection(float f, float crossF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xEBF62C", Offset = "0xEBF62C", VA = "0xEBF62C")]
		public Vector3 InterpolateVolumeUp(float f, float crossF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xEBF770", Offset = "0xEBF770", VA = "0xEBF770")]
		public float GetCrossLength(float pathF)
		{
			return default(float);
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xEBFA0C", Offset = "0xEBFA0C", VA = "0xEBFA0C")]
		public float CrossFToDistance(float f, float crossF, CurvyClamping crossClamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xEBFA50", Offset = "0xEBFA50", VA = "0xEBFA50")]
		public float CrossDistanceToF(float f, float distance, CurvyClamping crossClamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xEBF884", Offset = "0xEBF884", VA = "0xEBF884")]
		public void GetSegmentIndices(float pathF, out int s0Index, out int s1Index, out float frag)
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xEBFA98", Offset = "0xEBFA98", VA = "0xEBFA98")]
		public int GetSegmentIndex(int segment)
		{
			return default(int);
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xEBFAB8", Offset = "0xEBFAB8", VA = "0xEBFAB8")]
		public int GetCrossFIndex(float crossF, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xEBFB18", Offset = "0xEBFB18", VA = "0xEBFB18")]
		public int GetVertexIndex(float pathF, out float pathFrag)
		{
			return default(int);
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xEBF34C", Offset = "0xEBF34C", VA = "0xEBF34C")]
		public int GetVertexIndex(float pathF, float crossF, out float pathFrag, out float crossFrag)
		{
			return default(int);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xEBFB9C", Offset = "0xEBFB9C", VA = "0xEBFB9C")]
		public Vector3[] GetSegmentVertices(params int[] segmentIndices)
		{
			return null;
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xEBF91C", Offset = "0xEBF91C", VA = "0xEBF91C")]
		private float calcSegmentLength(int segmentIndex)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000F7")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x6D8B6C", Offset = "0x6D8B6C")]
	public class CGBounds : CGData
	{
		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Bounds? mBounds;

		[Token(Token = "0x1700018E")]
		public Bounds Bounds
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0xF6C7A0", Offset = "0xF6C7A0", VA = "0xF6C7A0")]
			get
			{
				return default(Bounds);
			}
			[Token(Token = "0x600073C")]
			[Address(RVA = "0xF6C83C", Offset = "0xF6C83C", VA = "0xF6C83C")]
			set
			{
			}
		}

		[Token(Token = "0x1700018F")]
		public float Depth
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0xF6C6D4", Offset = "0xF6C6D4", VA = "0xF6C6D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xF6ED28", Offset = "0xF6ED28", VA = "0xF6ED28")]
		public CGBounds()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xF6ED38", Offset = "0xF6ED38", VA = "0xF6ED38")]
		public CGBounds(Bounds bounds)
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xF6C70C", Offset = "0xF6C70C", VA = "0xF6C70C")]
		public CGBounds(CGBounds source)
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xF6ED84", Offset = "0xF6ED84", VA = "0xF6ED84", Slot = "6")]
		public virtual void RecalculateBounds()
		{
		}

		[Token(Token = "0x6000742")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xF6EDAC", Offset = "0xF6EDAC", VA = "0xF6EDAC")]
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
			[Address(RVA = "0xEBE50C", Offset = "0xEBE50C", VA = "0xEBE50C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xEBDFD4", Offset = "0xEBDFD4", VA = "0xEBDFD4")]
		public CGVSubMesh([Optional] Material material)
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xEBC808", Offset = "0xEBC808", VA = "0xEBC808")]
		public CGVSubMesh(int[] triangles, [Optional] Material material)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xEBE528", Offset = "0xEBE528", VA = "0xEBE528")]
		public CGVSubMesh(int triangleCount, [Optional] Material material)
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xEBC2F4", Offset = "0xEBC2F4", VA = "0xEBC2F4")]
		public CGVSubMesh(CGVSubMesh source)
		{
		}

		[Token(Token = "0x6000749")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xEBE5B0", Offset = "0xEBE5B0", VA = "0xEBE5B0")]
		public static CGVSubMesh Get(CGVSubMesh data, int triangleCount, [Optional] Material material)
		{
			return null;
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xEBE65C", Offset = "0xEBE65C", VA = "0xEBE65C")]
		public void ShiftIndices(int offset, int startIndex = 0)
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xEBD420", Offset = "0xEBD420", VA = "0xEBD420")]
		public void Add(CGVSubMesh other, int shiftIndexOffset = 0)
		{
		}
	}
	[Token(Token = "0x20000F9")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x6D8B90", Offset = "0x6D8B90")]
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
			[Address(RVA = "0xEBBC18", Offset = "0xEBBC18", VA = "0xEBBC18", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000192")]
		public bool HasUV
		{
			[Token(Token = "0x600074E")]
			[Address(RVA = "0xEBBC34", Offset = "0xEBBC34", VA = "0xEBBC34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000193")]
		public bool HasUV2
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0xEBBC58", Offset = "0xEBBC58", VA = "0xEBBC58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000194")]
		public bool HasNormals
		{
			[Token(Token = "0x6000750")]
			[Address(RVA = "0xEBBC7C", Offset = "0xEBBC7C", VA = "0xEBBC7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000195")]
		public bool HasTangents
		{
			[Token(Token = "0x6000751")]
			[Address(RVA = "0xEBBCA0", Offset = "0xEBBCA0", VA = "0xEBBCA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000196")]
		public int TriangleCount
		{
			[Token(Token = "0x6000752")]
			[Address(RVA = "0xEBBCC4", Offset = "0xEBBCC4", VA = "0xEBBCC4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xEBBD50", Offset = "0xEBBD50", VA = "0xEBBD50")]
		public CGVMesh()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xEBBD68", Offset = "0xEBBD68", VA = "0xEBBD68")]
		public CGVMesh(int vertexCount, bool addUV = false, bool addUV2 = false, bool addNormals = false, bool addTangents = false)
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xEBBED4", Offset = "0xEBBED4", VA = "0xEBBED4")]
		public CGVMesh(CGVolume volume)
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xEBBF30", Offset = "0xEBBF30", VA = "0xEBBF30")]
		public CGVMesh(CGVolume volume, IntRegion subset)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xEBC024", Offset = "0xEBC024", VA = "0xEBC024")]
		public CGVMesh(CGVMesh source)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xEBC3AC", Offset = "0xEBC3AC", VA = "0xEBC3AC")]
		public CGVMesh(CGMeshProperties meshProperties)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xEBC418", Offset = "0xEBC418", VA = "0xEBC418")]
		public CGVMesh(Mesh source, Material[] materials, Matrix4x4 trsMatrix)
		{
		}

		[Token(Token = "0x600075A")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xEBCA4C", Offset = "0xEBCA4C", VA = "0xEBCA4C")]
		public static CGVMesh Get(CGVMesh data, CGVolume source, bool addUV, bool reverseNormals)
		{
			return null;
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xEBCAD4", Offset = "0xEBCAD4", VA = "0xEBCAD4")]
		public static CGVMesh Get(CGVMesh data, CGVolume source, IntRegion subset, bool addUV, bool reverseNormals)
		{
			return null;
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xEBCDF8", Offset = "0xEBCDF8", VA = "0xEBCDF8")]
		public void SetSubMeshCount(int count)
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xEBCE54", Offset = "0xEBCE54", VA = "0xEBCE54")]
		public void AddSubMesh([Optional] CGVSubMesh submesh)
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xEBCEC0", Offset = "0xEBCEC0", VA = "0xEBCEC0")]
		public void MergeVMesh(CGVMesh source)
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xEBD520", Offset = "0xEBD520", VA = "0xEBD520")]
		public void MergeVMesh(CGVMesh source, Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xEBD71C", Offset = "0xEBD71C", VA = "0xEBD71C")]
		public void MergeVMeshes(List<CGVMesh> vMeshes, int startIndex, int endIndex)
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xEBCFFC", Offset = "0xEBCFFC", VA = "0xEBCFFC")]
		private void MergeUVsNormalsAndTangents(CGVMesh source, int preMergeVertexCount)
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xEBD2E4", Offset = "0xEBD2E4", VA = "0xEBD2E4")]
		public CGVSubMesh GetMaterialSubMesh(Material mat, bool createIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xEBE058", Offset = "0xEBE058", VA = "0xEBE058")]
		public Mesh AsMesh()
		{
			return null;
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0xEBE0CC", Offset = "0xEBE0CC", VA = "0xEBE0CC")]
		public void ToMesh(ref Mesh msh)
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xEBE208", Offset = "0xEBE208", VA = "0xEBE208")]
		public Material[] GetMaterials()
		{
			return null;
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xEBE30C", Offset = "0xEBE30C", VA = "0xEBE30C", Slot = "6")]
		public override void RecalculateBounds()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xEBE4DC", Offset = "0xEBE4DC", VA = "0xEBE4DC")]
		public void RecalculateUV2()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xEBC858", Offset = "0xEBC858", VA = "0xEBC858")]
		public void TRS(Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x600076A")]
		private void copyData<T>(ref T[] src, ref T[] dst, int currentSize, int extraSize)
		{
		}
	}
	[Token(Token = "0x20000FA")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x6D8BB4", Offset = "0x6D8BB4")]
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
			[Address(RVA = "0xF6FE94", Offset = "0xF6FE94", VA = "0xF6FE94")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xF6FF38", Offset = "0xF6FF38", VA = "0xF6FF38")]
		public CGGameObject()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xF6FF6C", Offset = "0xF6FF6C", VA = "0xF6FF6C")]
		public CGGameObject(CGGameObjectProperties properties)
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xF700F8", Offset = "0xF700F8", VA = "0xF700F8")]
		public CGGameObject(GameObject obj)
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xF6FFB4", Offset = "0xF6FFB4", VA = "0xF6FFB4")]
		public CGGameObject(GameObject obj, Vector3 translate, Vector3 rotate, Vector3 scale)
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xF70194", Offset = "0xF70194", VA = "0xF70194")]
		public CGGameObject(CGGameObject source)
		{
		}

		[Token(Token = "0x6000771")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xF70218", Offset = "0xF70218", VA = "0xF70218")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6E5AE8", Offset = "0x6E5AE8")]
		public static CGGameObject Get(CGGameObject data, GameObject obj, Vector3 translate, Vector3 rotate, Vector3 scale)
		{
			return null;
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xF70364", Offset = "0xF70364", VA = "0xF70364", Slot = "6")]
		public override void RecalculateBounds()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x6D8BEC", Offset = "0x6D8BEC")]
	public class CGSpots : CGData
	{
		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CGSpot[] Points;

		[Token(Token = "0x17000198")]
		public override int Count
		{
			[Token(Token = "0x6000774")]
			[Address(RVA = "0xEBB220", Offset = "0xEBB220", VA = "0xEBB220", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xEBB23C", Offset = "0xEBB23C", VA = "0xEBB23C")]
		public CGSpots()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xEBB2A4", Offset = "0xEBB2A4", VA = "0xEBB2A4")]
		public CGSpots(params CGSpot[] points)
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xEBB2D8", Offset = "0xEBB2D8", VA = "0xEBB2D8")]
		public CGSpots(params List<CGSpot>[] lists)
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xEBB42C", Offset = "0xEBB42C", VA = "0xEBB42C")]
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
		[Address(RVA = "0xF6FB94", Offset = "0xF6FB94", VA = "0xF6FB94")]
		public static implicit operator bool(CGDataRequestParameter a)
		{
			return default(bool);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xF6F9CC", Offset = "0xF6F9CC", VA = "0xF6F9CC")]
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
		[Address(RVA = "0xF66EF4", Offset = "0xF66EF4", VA = "0xF66EF4")]
		public CGDataRequestMetaCGOptions(bool checkEdges, bool checkMaterials, bool includeCP, bool extendedUV)
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xF6F9D4", Offset = "0xF6F9D4", VA = "0xF6F9D4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xF6FAE4", Offset = "0xF6FAE4", VA = "0xF6FAE4", Slot = "2")]
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
		[Address(RVA = "0xF66EBC", Offset = "0xF66EBC", VA = "0xF66EBC")]
		public CGDataRequestShapeRasterization(float[] pathF, float start, float rasterizedRelativeLength, int resolution, float angle, ModeEnum mode = ModeEnum.Even)
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xF6FD68", Offset = "0xF6FD68", VA = "0xF6FD68", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xF6FE50", Offset = "0xF6FE50", VA = "0xF6FE50", Slot = "2")]
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
		[Address(RVA = "0xF64C44", Offset = "0xF64C44", VA = "0xF64C44")]
		public CGDataRequestRasterization(float start, float rasterizedRelativeLength, int resolution, float angle, ModeEnum mode = ModeEnum.Even)
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xF6FBA0", Offset = "0xF6FBA0", VA = "0xF6FBA0")]
		public CGDataRequestRasterization(CGDataRequestRasterization source)
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0xF6FBC8", Offset = "0xF6FBC8", VA = "0xF6FBC8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xF6FCAC", Offset = "0xF6FCAC", VA = "0xF6FCAC", Slot = "2")]
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
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6D8C10", Offset = "0x6D8C10")]
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
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D8C48", Offset = "0x6D8C48")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D8C48", Offset = "0x6D8C48")]
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
			[Address(RVA = "0xF71418", Offset = "0xF71418", VA = "0xF71418")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019E")]
		public Collider Collider
		{
			[Token(Token = "0x600078E")]
			[Address(RVA = "0xF714CC", Offset = "0xF714CC", VA = "0xF714CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xF71580", Offset = "0xF71580", VA = "0xF71580")]
		public Mesh Prepare()
		{
			return null;
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xF715D8", Offset = "0xF715D8", VA = "0xF715D8")]
		public bool ColliderMatches(CGColliderEnum type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xF717C8", Offset = "0xF717C8", VA = "0xF717C8")]
		public void RemoveCollider()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xF718C4", Offset = "0xF718C4", VA = "0xF718C4")]
		public bool UpdateCollider(CGColliderEnum mode, bool convex, bool isTrigger, PhysicMaterial material, MeshColliderCookingOptions meshCookingOptions = MeshColliderCookingOptions.CookForFasterSimulation | MeshColliderCookingOptions.EnableMeshCleaning | MeshColliderCookingOptions.WeldColocatedVertices)
		{
			return default(bool);
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xF72084", Offset = "0xF72084", VA = "0xF72084", Slot = "5")]
		public void OnBeforePush()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xF72088", Offset = "0xF72088", VA = "0xF72088", Slot = "6")]
		public void OnAfterPop()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xF7208C", Offset = "0xF7208C", VA = "0xF7208C")]
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
			[Address(RVA = "0xF72094", Offset = "0xF72094", VA = "0xF72094", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001A0")]
		public UnityEngine.Component[] ItemsArray
		{
			[Token(Token = "0x6000797")]
			[Address(RVA = "0xF720E0", Offset = "0xF720E0", VA = "0xF720E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xF72134", Offset = "0xF72134", VA = "0xF72134")]
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
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6DF458", Offset = "0x6DF458")]
		protected CurvyCGEvent m_OnBeforeRefresh;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6DF4B4", Offset = "0x6DF4B4")]
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
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6DF570", Offset = "0x6DF570")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x6DF570", Offset = "0x6DF570")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x6DF570", Offset = "0x6DF570")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF68C", Offset = "0x6DF68C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF6CC", Offset = "0x6DF6CC")]
		private Dictionary<string, CGModuleInputSlot> <InputByName>k__BackingField;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF6DC", Offset = "0x6DF6DC")]
		private Dictionary<string, CGModuleOutputSlot> <OutputByName>k__BackingField;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF6EC", Offset = "0x6DF6EC")]
		private List<CGModuleInputSlot> <Input>k__BackingField;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF6FC", Offset = "0x6DF6FC")]
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
			[Address(RVA = "0xF72518", Offset = "0xF72518", VA = "0xF72518")]
			get
			{
				return null;
			}
			[Token(Token = "0x600079A")]
			[Address(RVA = "0xF72520", Offset = "0xF72520", VA = "0xF72520")]
			set
			{
			}
		}

		[Token(Token = "0x170001A2")]
		public CurvyCGEvent OnRefresh
		{
			[Token(Token = "0x600079B")]
			[Address(RVA = "0xF72538", Offset = "0xF72538", VA = "0xF72538")]
			get
			{
				return null;
			}
			[Token(Token = "0x600079C")]
			[Address(RVA = "0xF72540", Offset = "0xF72540", VA = "0xF72540")]
			set
			{
			}
		}

		[Token(Token = "0x170001A3")]
		public string ModuleName
		{
			[Token(Token = "0x600079F")]
			[Address(RVA = "0xF72628", Offset = "0xF72628", VA = "0xF72628")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A0")]
			[Address(RVA = "0xF72630", Offset = "0xF72630", VA = "0xF72630")]
			set
			{
			}
		}

		[Token(Token = "0x170001A4")]
		public bool Active
		{
			[Token(Token = "0x60007A1")]
			[Address(RVA = "0xF72880", Offset = "0xF72880", VA = "0xF72880")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A2")]
			[Address(RVA = "0xF72888", Offset = "0xF72888", VA = "0xF72888")]
			set
			{
			}
		}

		[Token(Token = "0x170001A5")]
		public int Seed
		{
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0xF728E4", Offset = "0xF728E4", VA = "0xF728E4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007A4")]
			[Address(RVA = "0xF728EC", Offset = "0xF728EC", VA = "0xF728EC")]
			set
			{
			}
		}

		[Token(Token = "0x170001A6")]
		public bool RandomizeSeed
		{
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0xF72904", Offset = "0xF72904", VA = "0xF72904")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0xF7290C", Offset = "0xF7290C", VA = "0xF7290C")]
			set
			{
			}
		}

		[Token(Token = "0x170001A7")]
		public CurvyGenerator Generator
		{
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0xF7292C", Offset = "0xF7292C", VA = "0xF7292C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A8")]
		public int UniqueID
		{
			[Token(Token = "0x60007A8")]
			[Address(RVA = "0xF72934", Offset = "0xF72934", VA = "0xF72934")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001A9")]
		public bool CircularReferenceError
		{
			[Token(Token = "0x60007A9")]
			[Address(RVA = "0xF7293C", Offset = "0xF7293C", VA = "0xF7293C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5B20", Offset = "0x6E5B20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0xF72944", Offset = "0xF72944", VA = "0xF72944")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5B30", Offset = "0x6E5B30")]
			set
			{
			}
		}

		[Token(Token = "0x170001AA")]
		public Dictionary<string, CGModuleInputSlot> InputByName
		{
			[Token(Token = "0x60007AB")]
			[Address(RVA = "0xF72950", Offset = "0xF72950", VA = "0xF72950")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5B40", Offset = "0x6E5B40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007AC")]
			[Address(RVA = "0xF72958", Offset = "0xF72958", VA = "0xF72958")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5B50", Offset = "0x6E5B50")]
			private set
			{
			}
		}

		[Token(Token = "0x170001AB")]
		public Dictionary<string, CGModuleOutputSlot> OutputByName
		{
			[Token(Token = "0x60007AD")]
			[Address(RVA = "0xF72960", Offset = "0xF72960", VA = "0xF72960")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5B60", Offset = "0x6E5B60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007AE")]
			[Address(RVA = "0xF72968", Offset = "0xF72968", VA = "0xF72968")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5B70", Offset = "0x6E5B70")]
			private set
			{
			}
		}

		[Token(Token = "0x170001AC")]
		public List<CGModuleInputSlot> Input
		{
			[Token(Token = "0x60007AF")]
			[Address(RVA = "0xF72970", Offset = "0xF72970", VA = "0xF72970")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5B80", Offset = "0x6E5B80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007B0")]
			[Address(RVA = "0xF72978", Offset = "0xF72978", VA = "0xF72978")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5B90", Offset = "0x6E5B90")]
			private set
			{
			}
		}

		[Token(Token = "0x170001AD")]
		public List<CGModuleOutputSlot> Output
		{
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0xF72980", Offset = "0xF72980", VA = "0xF72980")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5BA0", Offset = "0x6E5BA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0xF72988", Offset = "0xF72988", VA = "0xF72988")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5BB0", Offset = "0x6E5BB0")]
			private set
			{
			}
		}

		[Token(Token = "0x170001AE")]
		public ModuleInfoAttribute Info
		{
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0xF72990", Offset = "0xF72990", VA = "0xF72990")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AF")]
		public bool Dirty
		{
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0xF72AD8", Offset = "0xF72AD8", VA = "0xF72AD8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007B5")]
			[Address(RVA = "0xF63F38", Offset = "0xF63F38", VA = "0xF63F38")]
			set
			{
			}
		}

		[Token(Token = "0x170001B0")]
		public virtual bool IsConfigured
		{
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0xF74738", Offset = "0xF74738", VA = "0xF74738", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001B1")]
		public virtual bool IsInitialized
		{
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0xF74A08", Offset = "0xF74A08", VA = "0xF74A08", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xF72558", Offset = "0xF72558", VA = "0xF72558")]
		protected CurvyCGEventArgs OnBeforeRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xF725C0", Offset = "0xF725C0", VA = "0xF725C0")]
		protected CurvyCGEventArgs OnRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xF67544", Offset = "0xF67544", VA = "0xF67544", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xF6476C", Offset = "0xF6476C", VA = "0xF6476C", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xF72BB4", Offset = "0xF72BB4", VA = "0xF72BB4")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xF73258", Offset = "0xF73258", VA = "0xF73258", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xF7325C", Offset = "0xF7325C", VA = "0xF7325C", Slot = "7")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xF74730", Offset = "0xF74730", VA = "0xF74730")]
		private void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xF64BF0", Offset = "0xF64BF0", VA = "0xF64BF0", Slot = "10")]
		public virtual void Refresh()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xF64870", Offset = "0xF64870", VA = "0xF64870", Slot = "11")]
		public virtual void Reset()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xF743A8", Offset = "0xF743A8", VA = "0xF743A8")]
		public void ReInitializeLinkedSlots()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xF6B160", Offset = "0xF6B160", VA = "0xF6B160", Slot = "12")]
		public virtual void OnStateChange()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xF74A10", Offset = "0xF74A10", VA = "0xF74A10", Slot = "13")]
		public virtual void OnTemplateCreated()
		{
		}

		[Token(Token = "0x60007C3")]
		protected static T GetRequestParameter<T>(ref CGDataRequestParameter[] requests) where T : CGDataRequestParameter
		{
			return null;
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xF74A14", Offset = "0xF74A14", VA = "0xF74A14")]
		protected static void RemoveRequestParameter(ref CGDataRequestParameter[] requests, CGDataRequestParameter request)
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xF74AD4", Offset = "0xF74AD4", VA = "0xF74AD4")]
		public CGModuleLink GetOutputLink(CGModuleOutputSlot outSlot, CGModuleInputSlot inSlot)
		{
			return null;
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xF74BBC", Offset = "0xF74BBC", VA = "0xF74BBC")]
		public List<CGModuleLink> GetOutputLinks(CGModuleOutputSlot outSlot)
		{
			return null;
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xF74D00", Offset = "0xF74D00", VA = "0xF74D00")]
		public CGModuleLink GetInputLink(CGModuleInputSlot inSlot, CGModuleOutputSlot outSlot)
		{
			return null;
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xF74D08", Offset = "0xF74D08", VA = "0xF74D08")]
		public List<CGModuleLink> GetInputLinks(CGModuleInputSlot inSlot)
		{
			return null;
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xF74ADC", Offset = "0xF74ADC", VA = "0xF74ADC")]
		private static CGModuleLink GetLink(List<CGModuleLink> lst, CGModuleSlot source, CGModuleSlot target)
		{
			return null;
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xF74BC4", Offset = "0xF74BC4", VA = "0xF74BC4")]
		private static List<CGModuleLink> GetLinks(List<CGModuleLink> lst, CGModuleSlot source)
		{
			return null;
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xF74D10", Offset = "0xF74D10", VA = "0xF74D10")]
		public CGModule CopyTo(CurvyGenerator targetGenerator)
		{
			return null;
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xF74E3C", Offset = "0xF74E3C", VA = "0xF74E3C")]
		public UnityEngine.Component AddManagedResource(string resourceName, string context = "", int index = -1)
		{
			return null;
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xF74054", Offset = "0xF74054", VA = "0xF74054")]
		public void DeleteManagedResource(string resourceName, UnityEngine.Component res, string context = "", bool dontUsePool = false)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xF75298", Offset = "0xF75298", VA = "0xF75298")]
		public bool IsManagedResource(UnityEngine.Component res)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xF74FC4", Offset = "0xF74FC4", VA = "0xF74FC4")]
		protected void RenameResource(string resourceName, UnityEngine.Component resource, int index = -1)
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xF75380", Offset = "0xF75380", VA = "0xF75380")]
		protected PrefabPool GetPrefabPool(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xF754F8", Offset = "0xF754F8", VA = "0xF754F8")]
		public List<IPool> GetAllPrefabPools()
		{
			return null;
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xF755D0", Offset = "0xF755D0", VA = "0xF755D0")]
		public void DeleteAllPrefabPools()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xF756A8", Offset = "0xF756A8", VA = "0xF756A8")]
		public void Delete()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xF75748", Offset = "0xF75748", VA = "0xF75748")]
		public CGModuleInputSlot GetInputSlot(string name)
		{
			return null;
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xF74138", Offset = "0xF74138", VA = "0xF74138")]
		public List<CGModuleInputSlot> GetInputSlots([Optional] Type filterType)
		{
			return null;
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xF6F6E0", Offset = "0xF6F6E0", VA = "0xF6F6E0")]
		public CGModuleOutputSlot GetOutputSlot(string name)
		{
			return null;
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xF744CC", Offset = "0xF744CC", VA = "0xF744CC")]
		public List<CGModuleOutputSlot> GetOutputSlots([Optional] Type filterType)
		{
			return null;
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xF73B28", Offset = "0xF73B28", VA = "0xF73B28")]
		public bool GetManagedResources(out List<UnityEngine.Component> components, out List<string> componentNames)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xF74E10", Offset = "0xF74E10", VA = "0xF74E10")]
		public int SetUniqueIdINTERNAL()
		{
			return default(int);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xF757E4", Offset = "0xF757E4", VA = "0xF757E4")]
		internal void initializeSort()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xF758E8", Offset = "0xF758E8", VA = "0xF758E8")]
		internal List<CGModule> decrementChilds()
		{
			return null;
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xF75B18", Offset = "0xF75B18", VA = "0xF75B18")]
		internal void doRefresh()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xF729D4", Offset = "0xF729D4", VA = "0xF729D4")]
		internal ModuleInfoAttribute getInfo()
		{
			return null;
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xF75C60", Offset = "0xF75C60", VA = "0xF75C60")]
		private bool usesRandom()
		{
			return default(bool);
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xF72D98", Offset = "0xF72D98", VA = "0xF72D98")]
		private void loadSlots()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xF75CA0", Offset = "0xF75CA0", VA = "0xF75CA0")]
		private SlotInfo getSlotInfo(FieldInfo f)
		{
			return null;
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xF73948", Offset = "0xF73948", VA = "0xF73948")]
		private void setTreeDirtyStateChange()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xF72AE0", Offset = "0xF72AE0", VA = "0xF72AE0")]
		private CurvyGenerator RetrieveGenerator()
		{
			return null;
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xF76118", Offset = "0xF76118", VA = "0xF76118")]
		public void checkOnStateChangedINTERNAL()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xF72688", Offset = "0xF72688", VA = "0xF72688")]
		public void renameManagedResourcesINTERNAL()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xF64D8C", Offset = "0xF64D8C", VA = "0xF64D8C")]
		protected CGModule()
		{
		}
	}
	[Token(Token = "0x200010B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6D8CDC", Offset = "0x6D8CDC")]
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
		[Address(RVA = "0xF43C40", Offset = "0xF43C40", VA = "0xF43C40")]
		public ModuleInfoAttribute(string name)
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xF43C74", Offset = "0xF43C74", VA = "0xF43C74", Slot = "7")]
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
		[Address(RVA = "0xEB8014", Offset = "0xEB8014", VA = "0xEB8014")]
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
			[Address(RVA = "0xEB6C18", Offset = "0xEB6C18", VA = "0xEB6C18")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001B3")]
		public string SlotName
		{
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0xEB6C20", Offset = "0xEB6C20", VA = "0xEB6C20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B4")]
		public int TargetModuleID
		{
			[Token(Token = "0x60007EB")]
			[Address(RVA = "0xEB6C28", Offset = "0xEB6C28", VA = "0xEB6C28")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001B5")]
		public string TargetSlotName
		{
			[Token(Token = "0x60007EC")]
			[Address(RVA = "0xEB6C30", Offset = "0xEB6C30", VA = "0xEB6C30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xEB6C38", Offset = "0xEB6C38", VA = "0xEB6C38")]
		public CGModuleLink(int sourceID, string sourceSlotName, int targetID, string targetSlotName)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xEB6CA0", Offset = "0xEB6CA0", VA = "0xEB6CA0")]
		public CGModuleLink(CGModuleSlot source, CGModuleSlot target)
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xEB6DA8", Offset = "0xEB6DA8", VA = "0xEB6DA8")]
		public bool IsSame(CGModuleLink o)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xEB6E20", Offset = "0xEB6E20", VA = "0xEB6E20")]
		public bool IsSame(CGModuleSlot source, CGModuleSlot target)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xEB6F34", Offset = "0xEB6F34", VA = "0xEB6F34")]
		public bool IsTo(CGModuleSlot s)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xEB6FD4", Offset = "0xEB6FD4", VA = "0xEB6FD4")]
		public bool IsFrom(CGModuleSlot s)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xEB7074", Offset = "0xEB7074", VA = "0xEB7074")]
		public bool IsUsing(CGModule module)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xEB70AC", Offset = "0xEB70AC", VA = "0xEB70AC")]
		public bool IsBetween(CGModuleSlot one, CGModuleSlot another)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xEB7124", Offset = "0xEB7124", VA = "0xEB7124")]
		public void SetModuleIDIINTERNAL(int moduleID, int targetModuleID)
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xEB7130", Offset = "0xEB7130", VA = "0xEB7130")]
		public static implicit operator bool(CGModuleLink a)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xEB713C", Offset = "0xEB713C", VA = "0xEB713C", Slot = "3")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF74C", Offset = "0x6DF74C")]
		private CGModule <Module>k__BackingField;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF75C", Offset = "0x6DF75C")]
		private SlotInfo <Info>k__BackingField;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF76C", Offset = "0x6DF76C")]
		private Vector2 <Origin>k__BackingField;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DF77C", Offset = "0x6DF77C")]
		private Rect <DropZone>k__BackingField;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<CGModuleSlot> mLinkedSlots;

		[Token(Token = "0x170001B6")]
		public CGModule Module
		{
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0xEB8050", Offset = "0xEB8050", VA = "0xEB8050")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5BC0", Offset = "0x6E5BC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0xEB8058", Offset = "0xEB8058", VA = "0xEB8058")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5BD0", Offset = "0x6E5BD0")]
			internal set
			{
			}
		}

		[Token(Token = "0x170001B7")]
		public SlotInfo Info
		{
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0xEB8060", Offset = "0xEB8060", VA = "0xEB8060")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5BE0", Offset = "0x6E5BE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0xEB8068", Offset = "0xEB8068", VA = "0xEB8068")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5BF0", Offset = "0x6E5BF0")]
			internal set
			{
			}
		}

		[Token(Token = "0x170001B8")]
		public Vector2 Origin
		{
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0xEB8070", Offset = "0xEB8070", VA = "0xEB8070")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5C00", Offset = "0x6E5C00")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0xEB8078", Offset = "0xEB8078", VA = "0xEB8078")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5C10", Offset = "0x6E5C10")]
			set
			{
			}
		}

		[Token(Token = "0x170001B9")]
		public Rect DropZone
		{
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0xEB8080", Offset = "0xEB8080", VA = "0xEB8080")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5C20", Offset = "0x6E5C20")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0xEB808C", Offset = "0xEB808C", VA = "0xEB808C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5C30", Offset = "0x6E5C30")]
			set
			{
			}
		}

		[Token(Token = "0x170001BA")]
		public bool IsLinked
		{
			[Token(Token = "0x6000800")]
			[Address(RVA = "0xEB8098", Offset = "0xEB8098", VA = "0xEB8098")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001BB")]
		public bool IsLinkedAndConfigured
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0xEB80FC", Offset = "0xEB80FC", VA = "0xEB80FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001BC")]
		public IOnRequestProcessing OnRequestModule
		{
			[Token(Token = "0x6000802")]
			[Address(RVA = "0xEB81E0", Offset = "0xEB81E0", VA = "0xEB81E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BD")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6E61B8", Offset = "0x6E61B8")]
		public IOnRequestPath OnRequestPathModule
		{
			[Token(Token = "0x6000803")]
			[Address(RVA = "0xEB822C", Offset = "0xEB822C", VA = "0xEB822C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BE")]
		public IPathProvider PathProvider
		{
			[Token(Token = "0x6000804")]
			[Address(RVA = "0xEB8278", Offset = "0xEB8278", VA = "0xEB8278")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BF")]
		public IExternalInput ExternalInput
		{
			[Token(Token = "0x6000805")]
			[Address(RVA = "0xEB82C4", Offset = "0xEB82C4", VA = "0xEB82C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C0")]
		public List<CGModuleSlot> LinkedSlots
		{
			[Token(Token = "0x6000806")]
			[Address(RVA = "0xEB7D6C", Offset = "0xEB7D6C", VA = "0xEB7D6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C1")]
		public int Count
		{
			[Token(Token = "0x6000807")]
			[Address(RVA = "0xEB8310", Offset = "0xEB8310", VA = "0xEB8310")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001C2")]
		public string Name
		{
			[Token(Token = "0x6000808")]
			[Address(RVA = "0xEB6D50", Offset = "0xEB6D50", VA = "0xEB6D50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xEB7424", Offset = "0xEB7424", VA = "0xEB7424")]
		public CGModuleSlot()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xEB7868", Offset = "0xEB7868", VA = "0xEB7868")]
		public bool HasLinkTo(CGModuleSlot other)
		{
			return default(bool);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xEB8360", Offset = "0xEB8360", VA = "0xEB8360")]
		public List<CGModule> GetLinkedModules()
		{
			return null;
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xEB7AF8", Offset = "0xEB7AF8", VA = "0xEB7AF8", Slot = "4")]
		public virtual void LinkTo(CGModuleSlot other)
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xEB7930", Offset = "0xEB7930", VA = "0xEB7930")]
		protected static void LinkInputAndOutput(CGModuleSlot inputSlot, CGModuleSlot outputSlot)
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xEB7DFC", Offset = "0xEB7DFC", VA = "0xEB7DFC", Slot = "5")]
		public virtual void UnlinkFrom(CGModuleSlot other)
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xEB8484", Offset = "0xEB8484", VA = "0xEB8484", Slot = "6")]
		public virtual void UnlinkAll()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xEB7814", Offset = "0xEB7814", VA = "0xEB7814")]
		public void ReInitializeLinkedSlots()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xEB7810", Offset = "0xEB7810", VA = "0xEB7810", Slot = "7")]
		protected virtual void LoadLinkedSlots()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xEB8488", Offset = "0xEB8488", VA = "0xEB8488")]
		public static implicit operator bool(CGModuleSlot a)
		{
			return default(bool);
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xEB8494", Offset = "0xEB8494", VA = "0xEB8494", Slot = "3")]
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
			[Address(RVA = "0xF749A4", Offset = "0xF749A4", VA = "0xF749A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xF64D84", Offset = "0xF64D84", VA = "0xF64D84")]
		public CGModuleInputSlot()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xF76150", Offset = "0xF76150", VA = "0xF76150", Slot = "7")]
		protected override void LoadLinkedSlots()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xF7654C", Offset = "0xF7654C", VA = "0xF7654C", Slot = "6")]
		public override void UnlinkAll()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xF766BC", Offset = "0xF766BC", VA = "0xF766BC", Slot = "4")]
		public override void LinkTo(CGModuleSlot outputSlot)
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xF76710", Offset = "0xF76710", VA = "0xF76710", Slot = "5")]
		public override void UnlinkFrom(CGModuleSlot outputSlot)
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xF64520", Offset = "0xF64520", VA = "0xF64520")]
		public CGModuleOutputSlot SourceSlot(int index = 0)
		{
			return null;
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xF76898", Offset = "0xF76898", VA = "0xF76898")]
		public bool CanLinkTo(CGModuleOutputSlot source)
		{
			return default(bool);
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xF769C4", Offset = "0xF769C4", VA = "0xF769C4")]
		public static bool AreInputAndOutputSlotsCompatible(InputSlotInfo inputSlotInfo, bool inputSlotModuleIsOnRequest, OutputSlotInfo outputSlotInfo, bool outputSlotModuleIsOnRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xF76A44", Offset = "0xF76A44", VA = "0xF76A44")]
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
			[Address(RVA = "0xEB733C", Offset = "0xEB733C", VA = "0xEB733C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C5")]
		public bool HasData
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0xEB7EF8", Offset = "0xEB7EF8", VA = "0xEB7EF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xEB73BC", Offset = "0xEB73BC", VA = "0xEB73BC")]
		public CGModuleOutputSlot()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xEB742C", Offset = "0xEB742C", VA = "0xEB742C", Slot = "7")]
		protected override void LoadLinkedSlots()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xEB7820", Offset = "0xEB7820", VA = "0xEB7820", Slot = "4")]
		public override void LinkTo(CGModuleSlot inputSlot)
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xEB7BF4", Offset = "0xEB7BF4", VA = "0xEB7BF4", Slot = "5")]
		public override void UnlinkFrom(CGModuleSlot inputSlot)
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xEB7F38", Offset = "0xEB7F38", VA = "0xEB7F38")]
		public void ClearData()
		{
		}

		[Token(Token = "0x6000829")]
		public void SetData<T>(List<T> data) where T : CGData
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xEB7F94", Offset = "0xEB7F94", VA = "0xEB7F94")]
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
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6D8CF0", Offset = "0x6D8CF0")]
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
			[Address(RVA = "0xF48EE0", Offset = "0xF48EE0", VA = "0xF48EE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600082E")]
			[Address(RVA = "0xF48EF8", Offset = "0xF48EF8", VA = "0xF48EF8")]
			set
			{
			}
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xF3C180", Offset = "0xF3C180", VA = "0xF3C180")]
		protected SlotInfo(string name, params Type[] type)
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xF48F00", Offset = "0xF48F00", VA = "0xF48F00")]
		protected SlotInfo(params Type[] type)
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xF48F0C", Offset = "0xF48F0C", VA = "0xF48F0C", Slot = "7")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000113")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6D8D04", Offset = "0x6D8D04")]
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
		[Address(RVA = "0xF3C17C", Offset = "0xF3C17C", VA = "0xF3C17C")]
		public InputSlotInfo(string name, params Type[] type)
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xF3C1D8", Offset = "0xF3C1D8", VA = "0xF3C1D8")]
		public InputSlotInfo(params Type[] type)
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xF3C1E4", Offset = "0xF3C1E4", VA = "0xF3C1E4")]
		public bool IsValidFrom(Type outType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000114")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6D8D38", Offset = "0x6D8D38")]
	public class OutputSlotInfo : SlotInfo
	{
		[Token(Token = "0x170001C7")]
		public Type DataType
		{
			[Token(Token = "0x6000835")]
			[Address(RVA = "0xF4419C", Offset = "0xF4419C", VA = "0xF4419C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xF441D0", Offset = "0xF441D0", VA = "0xF441D0")]
		public OutputSlotInfo(Type type)
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xF441DC", Offset = "0xF441DC", VA = "0xF441DC")]
		public OutputSlotInfo(string name, Type type)
		{
		}
	}
	[Token(Token = "0x2000115")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6D8D6C", Offset = "0x6D8D6C")]
	public class ShapeOutputSlotInfo : OutputSlotInfo
	{
		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool OutputsVariableShape;

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xF48E30", Offset = "0xF48E30", VA = "0xF48E30")]
		public ShapeOutputSlotInfo()
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xF48E38", Offset = "0xF48E38", VA = "0xF48E38")]
		public ShapeOutputSlotInfo(string name)
		{
		}
	}
	[Token(Token = "0x2000116")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6D8DA0", Offset = "0x6D8DA0")]
	public sealed class ResourceLoaderAttribute : Attribute
	{
		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string ResourceName;

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xF475B8", Offset = "0xF475B8", VA = "0xF475B8")]
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
		[Address(RVA = "0xEB97BC", Offset = "0xEB97BC", VA = "0xEB97BC")]
		public static UnityEngine.Component CreateResource(CGModule module, string resName, string context)
		{
			return null;
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xEB9CFC", Offset = "0xEB9CFC", VA = "0xEB9CFC")]
		public static void DestroyResource(CGModule module, string resName, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xEB9A1C", Offset = "0xEB9A1C", VA = "0xEB9A1C")]
		private static void getLoaders()
		{
		}
	}
	[Token(Token = "0x2000118")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x6D8DB4", Offset = "0x6D8DB4")]
	public class CGSplineResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x600083F")]
		[Address(RVA = "0xEBAB84", Offset = "0xEBAB84", VA = "0xEBAB84", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xEBACAC", Offset = "0xEBACAC", VA = "0xEBACAC", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xEBAD48", Offset = "0xEBAD48", VA = "0xEBAD48")]
		public CGSplineResourceLoader()
		{
		}
	}
	[Token(Token = "0x2000119")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x6D8DEC", Offset = "0x6D8DEC")]
	public class CGShapeResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x6000842")]
		[Address(RVA = "0xEBA9E4", Offset = "0xEBA9E4", VA = "0xEBA9E4", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xEBAAE0", Offset = "0xEBAAE0", VA = "0xEBAAE0", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xEBAB7C", Offset = "0xEBAB7C", VA = "0xEBAB7C")]
		public CGShapeResourceLoader()
		{
		}
	}
	[Token(Token = "0x200011A")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x6D8E24", Offset = "0x6D8E24")]
	public class CGMeshResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x6000845")]
		[Address(RVA = "0xF721B8", Offset = "0xF721B8", VA = "0xF721B8", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xF7222C", Offset = "0xF7222C", VA = "0xF7222C", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xF72510", Offset = "0xF72510", VA = "0xF72510")]
		public CGMeshResourceLoader()
		{
		}
	}
	[Token(Token = "0x200011B")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x6D8E5C", Offset = "0x6D8E5C")]
	public class CGGameObjectResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x6000848")]
		[Address(RVA = "0xF70B90", Offset = "0xF70B90", VA = "0xF70B90", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xF70D00", Offset = "0xF70D00", VA = "0xF70D00", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xF70F20", Offset = "0xF70F20", VA = "0xF70F20")]
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
			[Address(RVA = "0xF70A20", Offset = "0xF70A20", VA = "0xF70A20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001C9")]
		public UnityEngine.Component[] ItemsArray
		{
			[Token(Token = "0x600084C")]
			[Address(RVA = "0xF70A6C", Offset = "0xF70A6C", VA = "0xF70A6C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xF70AC0", Offset = "0xF70AC0", VA = "0xF70AC0")]
		public CGGameObjectResourceCollection()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public static class CGUtility
	{
		[Token(Token = "0x600084E")]
		[Address(RVA = "0xEBB468", Offset = "0xEBB468", VA = "0xEBB468")]
		public static Vector2[] CalculateUV2(Vector2[] uv)
		{
			return null;
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xEBB588", Offset = "0xEBB588", VA = "0xEBB588")]
		public static List<ControlPointOption> GetControlPointsWithOptions(CGDataRequestMetaCGOptions options, CurvySpline shape, float startDist, float endDist, bool optimize, out int initialMaterialID, out float initialMaxStep)
		{
			return null;
		}
	}
	[Token(Token = "0x200011E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D8E94", Offset = "0x6D8E94")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D8E94", Offset = "0x6D8E94")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D8E94", Offset = "0x6D8E94")]
	public class CurvyGenerator : DTVersionedMonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200011F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D8F50", Offset = "0x6D8F50")]
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
			[Address(RVA = "0x11F9620", Offset = "0x11F9620", VA = "0x11F9620")]
			public <>c()
			{
			}

			[Token(Token = "0x600087F")]
			[Address(RVA = "0x11F9628", Offset = "0x11F9628", VA = "0x11F9628")]
			internal bool <ReorderModules>b__46_0(CGModule m)
			{
				return default(bool);
			}

			[Token(Token = "0x6000880")]
			[Address(RVA = "0x11F9688", Offset = "0x11F9688", VA = "0x11F9688")]
			internal float <ReorderModules>b__46_1(CGModule m)
			{
				return default(float);
			}

			[Token(Token = "0x6000881")]
			[Address(RVA = "0x11F96B0", Offset = "0x11F96B0", VA = "0x11F96B0")]
			internal IEnumerable<CGModule> <ReorderEndpointRecursiveInputs>b__65_0(CGModuleInputSlot i)
			{
				return null;
			}

			[Token(Token = "0x6000882")]
			[Address(RVA = "0x11F96CC", Offset = "0x11F96CC", VA = "0x11F96CC")]
			internal float <ReorderEndpointRecursiveInputs>b__65_1(CGModule m)
			{
				return default(float);
			}

			[Token(Token = "0x6000883")]
			[Address(RVA = "0x11F96F4", Offset = "0x11F96F4", VA = "0x11F96F4")]
			internal IEnumerable<CGModule> <UpdateModulesRecursiveInputs>b__66_0(CGModuleInputSlot i)
			{
				return null;
			}
		}

		[Token(Token = "0x2000120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D8F60", Offset = "0x6D8F60")]
		private sealed class <>c__DisplayClass66_0
		{
			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs;

			[Token(Token = "0x6000884")]
			[Address(RVA = "0x11F9710", Offset = "0x11F9710", VA = "0x11F9710")]
			public <>c__DisplayClass66_0()
			{
			}

			[Token(Token = "0x6000885")]
			[Address(RVA = "0x11F9718", Offset = "0x11F9718", VA = "0x11F9718")]
			internal IEnumerable<CGModule> <UpdateModulesRecursiveInputs>b__1(CGModule i)
			{
				return null;
			}
		}

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DF78C", Offset = "0x6DF78C")]
		private bool m_ShowDebug;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6DF7D8", Offset = "0x6DF7D8")]
		[SerializeField]
		private bool m_AutoRefresh;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Positive]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DF824", Offset = "0x6DF824")]
		private int m_RefreshDelay;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Positive]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DF904", Offset = "0x6DF904")]
		private int m_RefreshDelayEditor;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6DF9E4", Offset = "0x6DF9E4")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DFAA0", Offset = "0x6DFAA0")]
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
			[Address(RVA = "0xF1261C", Offset = "0xF1261C", VA = "0xF1261C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000851")]
			[Address(RVA = "0xF12624", Offset = "0xF12624", VA = "0xF12624")]
			set
			{
			}
		}

		[Token(Token = "0x170001CB")]
		public bool AutoRefresh
		{
			[Token(Token = "0x6000852")]
			[Address(RVA = "0xF12644", Offset = "0xF12644", VA = "0xF12644")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000853")]
			[Address(RVA = "0xF1264C", Offset = "0xF1264C", VA = "0xF1264C")]
			set
			{
			}
		}

		[Token(Token = "0x170001CC")]
		public int RefreshDelay
		{
			[Token(Token = "0x6000854")]
			[Address(RVA = "0xF1266C", Offset = "0xF1266C", VA = "0xF1266C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000855")]
			[Address(RVA = "0xF12674", Offset = "0xF12674", VA = "0xF12674")]
			set
			{
			}
		}

		[Token(Token = "0x170001CD")]
		public int RefreshDelayEditor
		{
			[Token(Token = "0x6000856")]
			[Address(RVA = "0xF126AC", Offset = "0xF126AC", VA = "0xF126AC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000857")]
			[Address(RVA = "0xF126B4", Offset = "0xF126B4", VA = "0xF126B4")]
			set
			{
			}
		}

		[Token(Token = "0x170001CE")]
		public PoolManager PoolManager
		{
			[Token(Token = "0x6000858")]
			[Address(RVA = "0xF126EC", Offset = "0xF126EC", VA = "0xF126EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CF")]
		public CurvyCGEvent OnRefresh
		{
			[Token(Token = "0x6000859")]
			[Address(RVA = "0xF127A0", Offset = "0xF127A0", VA = "0xF127A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600085A")]
			[Address(RVA = "0xF127A8", Offset = "0xF127A8", VA = "0xF127A8")]
			set
			{
			}
		}

		[Token(Token = "0x170001D0")]
		public bool IsInitialized
		{
			[Token(Token = "0x600085B")]
			[Address(RVA = "0xF127C0", Offset = "0xF127C0", VA = "0xF127C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001D1")]
		public bool Destroying
		{
			[Token(Token = "0x600085C")]
			[Address(RVA = "0xF127C8", Offset = "0xF127C8", VA = "0xF127C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5C40", Offset = "0x6E5C40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600085D")]
			[Address(RVA = "0xF127D0", Offset = "0xF127D0", VA = "0xF127D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5C50", Offset = "0x6E5C50")]
			private set
			{
			}
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xF127DC", Offset = "0xF127DC", VA = "0xF127DC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xF12800", Offset = "0xF12800", VA = "0xF12800")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xF12810", Offset = "0xF12810", VA = "0xF12810")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xF1281C", Offset = "0xF1281C", VA = "0xF1281C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xF12D4C", Offset = "0xF12D4C", VA = "0xF12D4C")]
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
		[Address(RVA = "0xF12EA8", Offset = "0xF12EA8", VA = "0xF12EA8")]
		public CGModule AddModule(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xF13024", Offset = "0xF13024", VA = "0xF13024")]
		public void ArrangeModules()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xF13338", Offset = "0xF13338", VA = "0xF13338")]
		public void ReorderModules()
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xF14240", Offset = "0xF14240", VA = "0xF14240")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xF14384", Offset = "0xF14384", VA = "0xF14384")]
		public void DeleteModule(CGModule module)
		{
		}

		[Token(Token = "0x6000869")]
		public List<T> FindModules<T>(bool includeOnRequestProcessing = false) where T : CGModule
		{
			return null;
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0xF1440C", Offset = "0xF1440C", VA = "0xF1440C")]
		public List<CGModule> GetModules(bool includeOnRequestProcessing = false)
		{
			return null;
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xF145A0", Offset = "0xF145A0", VA = "0xF145A0")]
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
		[Address(RVA = "0xF14654", Offset = "0xF14654", VA = "0xF14654")]
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
		[Address(RVA = "0xF147A8", Offset = "0xF147A8", VA = "0xF147A8")]
		public CGModuleOutputSlot GetModuleOutputSlot(int moduleId, string slotName)
		{
			return null;
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xF14864", Offset = "0xF14864", VA = "0xF14864")]
		public CGModuleOutputSlot GetModuleOutputSlot(string moduleName, string slotName)
		{
			return null;
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xF12830", Offset = "0xF12830", VA = "0xF12830")]
		public void Initialize(bool force = false)
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xF1492C", Offset = "0xF1492C", VA = "0xF1492C")]
		public void Refresh(bool forceUpdate = false)
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xF12CCC", Offset = "0xF12CCC", VA = "0xF12CCC")]
		public void TryAutoRefresh()
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xF1542C", Offset = "0xF1542C", VA = "0xF1542C")]
		protected CurvyCGEventArgs OnRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xF14244", Offset = "0xF14244", VA = "0xF14244")]
		private void clearModules()
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xF15494", Offset = "0xF15494", VA = "0xF15494")]
		public string getUniqueModuleNameINTERNAL(string name)
		{
			return null;
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xF14920", Offset = "0xF14920", VA = "0xF14920")]
		internal void sortModulesINTERNAL()
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xF15024", Offset = "0xF15024", VA = "0xF15024")]
		private bool doSortModules()
		{
			return default(bool);
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xF13CF4", Offset = "0xF13CF4", VA = "0xF13CF4")]
		private static void ReorderEndpointRecursiveInputs(CGModule endPoint, HashSet<int> reordredModuleIds, Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs)
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xF139BC", Offset = "0xF139BC", VA = "0xF139BC")]
		private static HashSet<CGModule> UpdateModulesRecursiveInputs(Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs, CGModule moduleToAdd)
		{
			return null;
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xF156D8", Offset = "0xF156D8", VA = "0xF156D8")]
		public CurvyGenerator()
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xF157FC", Offset = "0xF157FC", VA = "0xF157FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5C60", Offset = "0x6E5C60")]
		private bool <Initialize>b__57_0(CGModule m)
		{
			return default(bool);
		}
	}
}
namespace FluffyUnderware.Curvy.Generator.Modules
{
	[Token(Token = "0x2000121")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D8F70", Offset = "0x6D8F70")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D8F70", Offset = "0x6D8F70")]
	public class BuildRasterizedPath : CGModule, IPathProvider
	{
		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6DFAB0", Offset = "0x6DFAB0")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6DFB88", Offset = "0x6DFB88")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_Range;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6DFC9C", Offset = "0x6DFC9C")]
		[SerializeField]
		private int m_Resolution;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private bool m_Optimize;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6DFD20", Offset = "0x6DFD20")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6DFD20", Offset = "0x6DFD20")]
		private float m_AngleTreshold;

		[Token(Token = "0x170001D2")]
		public float From
		{
			[Token(Token = "0x6000886")]
			[Address(RVA = "0xF63EF0", Offset = "0xF63EF0", VA = "0xF63EF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000887")]
			[Address(RVA = "0xF63EF8", Offset = "0xF63EF8", VA = "0xF63EF8")]
			set
			{
			}
		}

		[Token(Token = "0x170001D3")]
		public float To
		{
			[Token(Token = "0x6000888")]
			[Address(RVA = "0xF6420C", Offset = "0xF6420C", VA = "0xF6420C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000889")]
			[Address(RVA = "0xF64214", Offset = "0xF64214", VA = "0xF64214")]
			set
			{
			}
		}

		[Token(Token = "0x170001D4")]
		public float Length
		{
			[Token(Token = "0x600088A")]
			[Address(RVA = "0xF64378", Offset = "0xF64378", VA = "0xF64378")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600088B")]
			[Address(RVA = "0xF643A8", Offset = "0xF643A8", VA = "0xF643A8")]
			set
			{
			}
		}

		[Token(Token = "0x170001D5")]
		public int Resolution
		{
			[Token(Token = "0x600088C")]
			[Address(RVA = "0xF643F8", Offset = "0xF643F8", VA = "0xF643F8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600088D")]
			[Address(RVA = "0xF64400", Offset = "0xF64400", VA = "0xF64400")]
			set
			{
			}
		}

		[Token(Token = "0x170001D6")]
		public bool Optimize
		{
			[Token(Token = "0x600088E")]
			[Address(RVA = "0xF6444C", Offset = "0xF6444C", VA = "0xF6444C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600088F")]
			[Address(RVA = "0xF64454", Offset = "0xF64454", VA = "0xF64454")]
			set
			{
			}
		}

		[Token(Token = "0x170001D7")]
		public float AngleThreshold
		{
			[Token(Token = "0x6000890")]
			[Address(RVA = "0xF64478", Offset = "0xF64478", VA = "0xF64478")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000891")]
			[Address(RVA = "0xF64480", Offset = "0xF64480", VA = "0xF64480")]
			set
			{
			}
		}

		[Token(Token = "0x170001D8")]
		public CGPath Path
		{
			[Token(Token = "0x6000892")]
			[Address(RVA = "0xF644CC", Offset = "0xF644CC", VA = "0xF644CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D9")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000893")]
			[Address(RVA = "0xF6428C", Offset = "0xF6428C", VA = "0xF6428C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001DA")]
		private RegionOptions<float> RangeOptions
		{
			[Token(Token = "0x6000894")]
			[Address(RVA = "0xF64608", Offset = "0xF64608", VA = "0xF64608")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xF64728", Offset = "0xF64728", VA = "0xF64728", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xF64800", Offset = "0xF64800", VA = "0xF64800", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xF649B0", Offset = "0xF649B0", VA = "0xF649B0", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xF64CC4", Offset = "0xF64CC4", VA = "0xF64CC4")]
		public BuildRasterizedPath()
		{
		}
	}
	[Token(Token = "0x2000122")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D9008", Offset = "0x6D9008")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D9008", Offset = "0x6D9008")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D90A0", Offset = "0x6D90A0")]
		private sealed class <>c
		{
			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<CGShape, int> <>9__152_0;

			[Token(Token = "0x60008EA")]
			[Address(RVA = "0x11F9148", Offset = "0x11F9148", VA = "0x11F9148")]
			public <>c()
			{
			}

			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x11F9150", Offset = "0x11F9150", VA = "0x11F9150")]
			internal int <Refresh>b__152_0(CGShape c)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6DFE20", Offset = "0x6DFE20")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6DFEDC", Offset = "0x6DFEDC")]
		[HideInInspector]
		public CGModuleInputSlot InCross;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6DFFA0", Offset = "0x6DFFA0")]
		[HideInInspector]
		public CGModuleOutputSlot OutVolume;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6E0010", Offset = "0x6E0010")]
		[HideInInspector]
		public CGModuleOutputSlot OutVolumeHollow;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[FloatRegion]
		[SerializeField]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6E0080", Offset = "0x6E0080")]
		private FloatRegion m_Range;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6E010C", Offset = "0x6E010C")]
		[SerializeField]
		private int m_Resolution;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private bool m_Optimize;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E0190", Offset = "0x6E0190")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6E0190", Offset = "0x6E0190")]
		[SerializeField]
		private float m_AngleThreshold;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6E02AC", Offset = "0x6E02AC")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x6E02AC", Offset = "0x6E02AC")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_CrossRange;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6E0364", Offset = "0x6E0364")]
		private int m_CrossResolution;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6E03EC", Offset = "0x6E03EC")]
		private bool m_CrossOptimize;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E044C", Offset = "0x6E044C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6E044C", Offset = "0x6E044C")]
		private float m_CrossAngleThreshold;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6E0560", Offset = "0x6E0560")]
		[SerializeField]
		private bool m_CrossIncludeControlpoints;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6E05C8", Offset = "0x6E05C8")]
		[SerializeField]
		private bool m_CrossHardEdges;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6E0630", Offset = "0x6E0630")]
		[SerializeField]
		private bool m_CrossMaterials;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFB")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6E0698", Offset = "0x6E0698")]
		[SerializeField]
		private bool m_CrossExtendedUV;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6E0700", Offset = "0x6E0700")]
		[SerializeField]
		private CrossShiftModeEnum m_CrossShiftMode;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E0784", Offset = "0x6E0784")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6E0784", Offset = "0x6E0784")]
		private float m_CrossShiftValue;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6E0884", Offset = "0x6E0884")]
		private bool m_CrossReverseNormals;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6E08E4", Offset = "0x6E08E4")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6E08E4", Offset = "0x6E08E4")]
		private ScaleModeEnum m_ScaleMode;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E0970", Offset = "0x6E0970")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6E0970", Offset = "0x6E0970")]
		private CGReferenceMode m_ScaleReference;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E0A58", Offset = "0x6E0A58")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6E0A58", Offset = "0x6E0A58")]
		[SerializeField]
		private float m_ScaleOffset;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6E0B40", Offset = "0x6E0B40")]
		[SerializeField]
		private bool m_ScaleUniform;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private float m_ScaleX;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E0BD4", Offset = "0x6E0BD4")]
		private float m_ScaleY;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E0C80", Offset = "0x6E0C80")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E0C80", Offset = "0x6E0C80")]
		[AttributeAttribute(Name = "AnimationCurveExAttribute", RVA = "0x6E0C80", Offset = "0x6E0C80")]
		private AnimationCurve m_ScaleCurveX;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "AnimationCurveExAttribute", RVA = "0x6E0D8C", Offset = "0x6E0D8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E0D8C", Offset = "0x6E0D8C")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E0D8C", Offset = "0x6E0D8C")]
		private AnimationCurve m_ScaleCurveY;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6E0EE0", Offset = "0x6E0EE0")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6E0EE0", Offset = "0x6E0EE0")]
		[SerializeField]
		private float m_HollowInset;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6E0F98", Offset = "0x6E0F98")]
		private bool m_HollowReverseNormals;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E0FF8", Offset = "0x6E0FF8")]
		private int <PathSamples>k__BackingField;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E1008", Offset = "0x6E1008")]
		private int <CrossSamples>k__BackingField;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E1018", Offset = "0x6E1018")]
		private int <CrossGroups>k__BackingField;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E1028", Offset = "0x6E1028")]
		private Vector3 <CrossPosition>k__BackingField;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E1038", Offset = "0x6E1038")]
		private Quaternion <CrossRotation>k__BackingField;

		[Token(Token = "0x170001DB")]
		public float From
		{
			[Token(Token = "0x6000899")]
			[Address(RVA = "0xF64F84", Offset = "0xF64F84", VA = "0xF64F84")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600089A")]
			[Address(RVA = "0xF64F8C", Offset = "0xF64F8C", VA = "0xF64F8C")]
			set
			{
			}
		}

		[Token(Token = "0x170001DC")]
		public float To
		{
			[Token(Token = "0x600089B")]
			[Address(RVA = "0xF64FCC", Offset = "0xF64FCC", VA = "0xF64FCC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600089C")]
			[Address(RVA = "0xF64FD4", Offset = "0xF64FD4", VA = "0xF64FD4")]
			set
			{
			}
		}

		[Token(Token = "0x170001DD")]
		public float Length
		{
			[Token(Token = "0x600089D")]
			[Address(RVA = "0xF6513C", Offset = "0xF6513C", VA = "0xF6513C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600089E")]
			[Address(RVA = "0xF6516C", Offset = "0xF6516C", VA = "0xF6516C")]
			set
			{
			}
		}

		[Token(Token = "0x170001DE")]
		public int Resolution
		{
			[Token(Token = "0x600089F")]
			[Address(RVA = "0xF651BC", Offset = "0xF651BC", VA = "0xF651BC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0xF651C4", Offset = "0xF651C4", VA = "0xF651C4")]
			set
			{
			}
		}

		[Token(Token = "0x170001DF")]
		public bool Optimize
		{
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0xF65210", Offset = "0xF65210", VA = "0xF65210")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0xF65218", Offset = "0xF65218", VA = "0xF65218")]
			set
			{
			}
		}

		[Token(Token = "0x170001E0")]
		public float AngleThreshold
		{
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0xF6523C", Offset = "0xF6523C", VA = "0xF6523C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0xF65244", Offset = "0xF65244", VA = "0xF65244")]
			set
			{
			}
		}

		[Token(Token = "0x170001E1")]
		public float CrossFrom
		{
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0xF65290", Offset = "0xF65290", VA = "0xF65290")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0xF65298", Offset = "0xF65298", VA = "0xF65298")]
			set
			{
			}
		}

		[Token(Token = "0x170001E2")]
		public float CrossTo
		{
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0xF652D8", Offset = "0xF652D8", VA = "0xF652D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0xF652E0", Offset = "0xF652E0", VA = "0xF652E0")]
			set
			{
			}
		}

		[Token(Token = "0x170001E3")]
		public float CrossLength
		{
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0xF65448", Offset = "0xF65448", VA = "0xF65448")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0xF65478", Offset = "0xF65478", VA = "0xF65478")]
			set
			{
			}
		}

		[Token(Token = "0x170001E4")]
		public int CrossResolution
		{
			[Token(Token = "0x60008AB")]
			[Address(RVA = "0xF654C8", Offset = "0xF654C8", VA = "0xF654C8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008AC")]
			[Address(RVA = "0xF654D0", Offset = "0xF654D0", VA = "0xF654D0")]
			set
			{
			}
		}

		[Token(Token = "0x170001E5")]
		public bool CrossOptimize
		{
			[Token(Token = "0x60008AD")]
			[Address(RVA = "0xF6551C", Offset = "0xF6551C", VA = "0xF6551C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0xF65524", Offset = "0xF65524", VA = "0xF65524")]
			set
			{
			}
		}

		[Token(Token = "0x170001E6")]
		public float CrossAngleThreshold
		{
			[Token(Token = "0x60008AF")]
			[Address(RVA = "0xF65548", Offset = "0xF65548", VA = "0xF65548")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0xF65550", Offset = "0xF65550", VA = "0xF65550")]
			set
			{
			}
		}

		[Token(Token = "0x170001E7")]
		public bool CrossIncludeControlPoints
		{
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0xF6559C", Offset = "0xF6559C", VA = "0xF6559C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0xF655A4", Offset = "0xF655A4", VA = "0xF655A4")]
			set
			{
			}
		}

		[Token(Token = "0x170001E8")]
		public bool CrossHardEdges
		{
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0xF655C8", Offset = "0xF655C8", VA = "0xF655C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008B4")]
			[Address(RVA = "0xF655D0", Offset = "0xF655D0", VA = "0xF655D0")]
			set
			{
			}
		}

		[Token(Token = "0x170001E9")]
		public bool CrossMaterials
		{
			[Token(Token = "0x60008B5")]
			[Address(RVA = "0xF655F4", Offset = "0xF655F4", VA = "0xF655F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0xF655FC", Offset = "0xF655FC", VA = "0xF655FC")]
			set
			{
			}
		}

		[Token(Token = "0x170001EA")]
		public bool CrossExtendedUV
		{
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0xF65620", Offset = "0xF65620", VA = "0xF65620")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0xF65628", Offset = "0xF65628", VA = "0xF65628")]
			set
			{
			}
		}

		[Token(Token = "0x170001EB")]
		public CrossShiftModeEnum CrossShiftMode
		{
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0xF6564C", Offset = "0xF6564C", VA = "0xF6564C")]
			get
			{
				return default(CrossShiftModeEnum);
			}
			[Token(Token = "0x60008BA")]
			[Address(RVA = "0xF65654", Offset = "0xF65654", VA = "0xF65654")]
			set
			{
			}
		}

		[Token(Token = "0x170001EC")]
		public float CrossShiftValue
		{
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0xF6566C", Offset = "0xF6566C", VA = "0xF6566C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0xF65674", Offset = "0xF65674", VA = "0xF65674")]
			set
			{
			}
		}

		[Token(Token = "0x170001ED")]
		public bool CrossReverseNormals
		{
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0xF656B4", Offset = "0xF656B4", VA = "0xF656B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0xF656BC", Offset = "0xF656BC", VA = "0xF656BC")]
			set
			{
			}
		}

		[Token(Token = "0x170001EE")]
		public ScaleModeEnum ScaleMode
		{
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0xF656E0", Offset = "0xF656E0", VA = "0xF656E0")]
			get
			{
				return default(ScaleModeEnum);
			}
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0xF656E8", Offset = "0xF656E8", VA = "0xF656E8")]
			set
			{
			}
		}

		[Token(Token = "0x170001EF")]
		public CGReferenceMode ScaleReference
		{
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0xF65700", Offset = "0xF65700", VA = "0xF65700")]
			get
			{
				return default(CGReferenceMode);
			}
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0xF65708", Offset = "0xF65708", VA = "0xF65708")]
			set
			{
			}
		}

		[Token(Token = "0x170001F0")]
		public bool ScaleUniform
		{
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0xF65720", Offset = "0xF65720", VA = "0xF65720")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0xF65728", Offset = "0xF65728", VA = "0xF65728")]
			set
			{
			}
		}

		[Token(Token = "0x170001F1")]
		public float ScaleOffset
		{
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0xF6574C", Offset = "0xF6574C", VA = "0xF6574C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0xF65754", Offset = "0xF65754", VA = "0xF65754")]
			set
			{
			}
		}

		[Token(Token = "0x170001F2")]
		public float ScaleX
		{
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0xF6576C", Offset = "0xF6576C", VA = "0xF6576C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0xF65774", Offset = "0xF65774", VA = "0xF65774")]
			set
			{
			}
		}

		[Token(Token = "0x170001F3")]
		public float ScaleY
		{
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0xF6578C", Offset = "0xF6578C", VA = "0xF6578C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0xF65794", Offset = "0xF65794", VA = "0xF65794")]
			set
			{
			}
		}

		[Token(Token = "0x170001F4")]
		public AnimationCurve ScaleMultiplierX
		{
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0xF657AC", Offset = "0xF657AC", VA = "0xF657AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008CC")]
			[Address(RVA = "0xF657B4", Offset = "0xF657B4", VA = "0xF657B4")]
			set
			{
			}
		}

		[Token(Token = "0x170001F5")]
		public AnimationCurve ScaleMultiplierY
		{
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0xF657F0", Offset = "0xF657F0", VA = "0xF657F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0xF657F8", Offset = "0xF657F8", VA = "0xF657F8")]
			set
			{
			}
		}

		[Token(Token = "0x170001F6")]
		public float HollowInset
		{
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0xF65834", Offset = "0xF65834", VA = "0xF65834")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0xF6583C", Offset = "0xF6583C", VA = "0xF6583C")]
			set
			{
			}
		}

		[Token(Token = "0x170001F7")]
		public bool HollowReverseNormals
		{
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0xF65878", Offset = "0xF65878", VA = "0xF65878")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008D2")]
			[Address(RVA = "0xF65880", Offset = "0xF65880", VA = "0xF65880")]
			set
			{
			}
		}

		[Token(Token = "0x170001F8")]
		public int PathSamples
		{
			[Token(Token = "0x60008D3")]
			[Address(RVA = "0xF658A4", Offset = "0xF658A4", VA = "0xF658A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5C70", Offset = "0x6E5C70")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008D4")]
			[Address(RVA = "0xF658AC", Offset = "0xF658AC", VA = "0xF658AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5C80", Offset = "0x6E5C80")]
			private set
			{
			}
		}

		[Token(Token = "0x170001F9")]
		public int CrossSamples
		{
			[Token(Token = "0x60008D5")]
			[Address(RVA = "0xF658B4", Offset = "0xF658B4", VA = "0xF658B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5C90", Offset = "0x6E5C90")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008D6")]
			[Address(RVA = "0xF658BC", Offset = "0xF658BC", VA = "0xF658BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5CA0", Offset = "0x6E5CA0")]
			private set
			{
			}
		}

		[Token(Token = "0x170001FA")]
		public int CrossGroups
		{
			[Token(Token = "0x60008D7")]
			[Address(RVA = "0xF658C4", Offset = "0xF658C4", VA = "0xF658C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5CB0", Offset = "0x6E5CB0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008D8")]
			[Address(RVA = "0xF658CC", Offset = "0xF658CC", VA = "0xF658CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5CC0", Offset = "0x6E5CC0")]
			private set
			{
			}
		}

		[Token(Token = "0x170001FB")]
		public IExternalInput Cross
		{
			[Token(Token = "0x60008D9")]
			[Address(RVA = "0xF658D4", Offset = "0xF658D4", VA = "0xF658D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FC")]
		public Vector3 CrossPosition
		{
			[Token(Token = "0x60008DA")]
			[Address(RVA = "0xF6592C", Offset = "0xF6592C", VA = "0xF6592C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5CD0", Offset = "0x6E5CD0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60008DB")]
			[Address(RVA = "0xF6593C", Offset = "0xF6593C", VA = "0xF6593C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5CE0", Offset = "0x6E5CE0")]
			protected set
			{
			}
		}

		[Token(Token = "0x170001FD")]
		public Quaternion CrossRotation
		{
			[Token(Token = "0x60008DC")]
			[Address(RVA = "0xF6594C", Offset = "0xF6594C", VA = "0xF6594C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5CF0", Offset = "0x6E5CF0")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60008DD")]
			[Address(RVA = "0xF65960", Offset = "0xF65960", VA = "0xF65960")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5D00", Offset = "0x6E5D00")]
			protected set
			{
			}
		}

		[Token(Token = "0x170001FE")]
		public bool PathIsClosed
		{
			[Token(Token = "0x60008DE")]
			[Address(RVA = "0xF65974", Offset = "0xF65974", VA = "0xF65974", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001FF")]
		private bool ClampPath
		{
			[Token(Token = "0x60008DF")]
			[Address(RVA = "0xF6504C", Offset = "0xF6504C", VA = "0xF6504C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000200")]
		private bool ClampCross
		{
			[Token(Token = "0x60008E0")]
			[Address(RVA = "0xF65358", Offset = "0xF65358", VA = "0xF65358")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000201")]
		private RegionOptions<float> RangeOptions
		{
			[Token(Token = "0x60008E1")]
			[Address(RVA = "0xF65A3C", Offset = "0xF65A3C", VA = "0xF65A3C")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x17000202")]
		private RegionOptions<float> CrossRangeOptions
		{
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0xF65B5C", Offset = "0xF65B5C", VA = "0xF65B5C")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xF65C7C", Offset = "0xF65C7C", VA = "0xF65C7C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0xF65CC0", Offset = "0xF65CC0", VA = "0xF65CC0", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xF65F38", Offset = "0xF65F38", VA = "0xF65F38", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0xF67008", Offset = "0xF67008", VA = "0xF67008")]
		public Vector3 GetScale(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0xF66F58", Offset = "0xF66F58", VA = "0xF66F58")]
		private void getScaleInternal(float f, Vector3 baseScale, ref Vector3 scale)
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xF67090", Offset = "0xF67090", VA = "0xF67090")]
		public BuildShapeExtrusion()
		{
		}
	}
	[Token(Token = "0x2000126")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D90B0", Offset = "0x6D90B0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D90B0", Offset = "0x6D90B0")]
	public class BuildVolumeCaps : CGModule
	{
		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E1048", Offset = "0x6E1048")]
		public CGModuleInputSlot InVolume;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E10EC", Offset = "0x6E10EC")]
		public CGModuleInputSlot InVolumeHoles;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6E11AC", Offset = "0x6E11AC")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6E1228", Offset = "0x6E1228")]
		[SerializeField]
		private CGYesNoAuto m_StartCap;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private CGYesNoAuto m_EndCap;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6E1284", Offset = "0x6E1284")]
		private bool m_ReverseTriOrder;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		[SerializeField]
		private bool m_GenerateUV;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6E12E0", Offset = "0x6E12E0")]
		[Inline]
		private CGMaterialSettings m_StartMaterialSettings;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6E133C", Offset = "0x6E133C")]
		[SerializeField]
		private Material m_StartMaterial;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6E13A4", Offset = "0x6E13A4")]
		[SerializeField]
		private bool m_CloneStartCap;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x6E13F0", Offset = "0x6E13F0")]
		[AttributeAttribute(Name = "AsGroupAttribute", RVA = "0x6E13F0", Offset = "0x6E13F0")]
		private CGMaterialSettings m_EndMaterialSettings;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6E14B0", Offset = "0x6E14B0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E14B0", Offset = "0x6E14B0")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x6E14B0", Offset = "0x6E14B0")]
		private Material m_EndMaterial;

		[Token(Token = "0x17000203")]
		public bool GenerateUV
		{
			[Token(Token = "0x60008EC")]
			[Address(RVA = "0xF67230", Offset = "0xF67230", VA = "0xF67230")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0xF67238", Offset = "0xF67238", VA = "0xF67238")]
			set
			{
			}
		}

		[Token(Token = "0x17000204")]
		public bool ReverseTriOrder
		{
			[Token(Token = "0x60008EE")]
			[Address(RVA = "0xF6725C", Offset = "0xF6725C", VA = "0xF6725C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008EF")]
			[Address(RVA = "0xF67264", Offset = "0xF67264", VA = "0xF67264")]
			set
			{
			}
		}

		[Token(Token = "0x17000205")]
		public CGYesNoAuto StartCap
		{
			[Token(Token = "0x60008F0")]
			[Address(RVA = "0xF67288", Offset = "0xF67288", VA = "0xF67288")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x60008F1")]
			[Address(RVA = "0xF67290", Offset = "0xF67290", VA = "0xF67290")]
			set
			{
			}
		}

		[Token(Token = "0x17000206")]
		public Material StartMaterial
		{
			[Token(Token = "0x60008F2")]
			[Address(RVA = "0xF672A8", Offset = "0xF672A8", VA = "0xF672A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0xF672B0", Offset = "0xF672B0", VA = "0xF672B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000207")]
		public CGMaterialSettings StartMaterialSettings
		{
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0xF6734C", Offset = "0xF6734C", VA = "0xF6734C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000208")]
		public CGYesNoAuto EndCap
		{
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0xF67354", Offset = "0xF67354", VA = "0xF67354")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0xF6735C", Offset = "0xF6735C", VA = "0xF6735C")]
			set
			{
			}
		}

		[Token(Token = "0x17000209")]
		public bool CloneStartCap
		{
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0xF67374", Offset = "0xF67374", VA = "0xF67374")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008F8")]
			[Address(RVA = "0xF6737C", Offset = "0xF6737C", VA = "0xF6737C")]
			set
			{
			}
		}

		[Token(Token = "0x1700020A")]
		public CGMaterialSettings EndMaterialSettings
		{
			[Token(Token = "0x60008F9")]
			[Address(RVA = "0xF673A0", Offset = "0xF673A0", VA = "0xF673A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020B")]
		public Material EndMaterial
		{
			[Token(Token = "0x60008FA")]
			[Address(RVA = "0xF673A8", Offset = "0xF673A8", VA = "0xF673A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008FB")]
			[Address(RVA = "0xF673B0", Offset = "0xF673B0", VA = "0xF673B0")]
			set
			{
			}
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0xF6744C", Offset = "0xF6744C", VA = "0xF6744C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0xF67570", Offset = "0xF67570", VA = "0xF67570", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xF676F4", Offset = "0xF676F4", VA = "0xF676F4", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0xF683C0", Offset = "0xF683C0", VA = "0xF683C0")]
		private static Matrix4x4 getMatrix(CGVolume vol, int index, bool inverse)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0xF68798", Offset = "0xF68798", VA = "0xF68798")]
		private static void flipTris(ref int[] indices, int start, int end)
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0xF6859C", Offset = "0xF6859C", VA = "0xF6859C")]
		private static Vector3[] applyMatrix(Vector3[] vt, Matrix4x4 matrix, out Bounds bounds)
		{
			return null;
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0xF68228", Offset = "0xF68228", VA = "0xF68228")]
		private static ContourVertex[] make2DSegment(CGVolume vol, int segmentIndex)
		{
			return null;
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0xF68820", Offset = "0xF68820", VA = "0xF68820")]
		private static void applyUV(Vector3[] vts, ref Vector2[] uvArray, int index, int count, CGMaterialSettings mat, Bounds bounds)
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0xF68AF0", Offset = "0xF68AF0", VA = "0xF68AF0")]
		public BuildVolumeCaps()
		{
		}
	}
	[Token(Token = "0x2000127")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D9148", Offset = "0x6D9148")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D9148", Offset = "0x6D9148")]
	public class BuildVolumeMesh : CGModule
	{
		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E15B8", Offset = "0x6E15B8")]
		[HideInInspector]
		public CGModuleInputSlot InVolume;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6E165C", Offset = "0x6E165C")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6E16D8", Offset = "0x6E16D8")]
		private bool m_GenerateUV;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		[SerializeField]
		private bool m_Split;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[Positive]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E1734", Offset = "0x6E1734")]
		[SerializeField]
		private float m_SplitLength;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x6E1800", Offset = "0x6E1800")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6E1800", Offset = "0x6E1800")]
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
			[Address(RVA = "0xF68C28", Offset = "0xF68C28", VA = "0xF68C28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000906")]
			[Address(RVA = "0xF68C30", Offset = "0xF68C30", VA = "0xF68C30")]
			set
			{
			}
		}

		[Token(Token = "0x1700020D")]
		public bool ReverseTriOrder
		{
			[Token(Token = "0x6000907")]
			[Address(RVA = "0xF68C54", Offset = "0xF68C54", VA = "0xF68C54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000908")]
			[Address(RVA = "0xF68C5C", Offset = "0xF68C5C", VA = "0xF68C5C")]
			set
			{
			}
		}

		[Token(Token = "0x1700020E")]
		public bool Split
		{
			[Token(Token = "0x6000909")]
			[Address(RVA = "0xF68C80", Offset = "0xF68C80", VA = "0xF68C80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600090A")]
			[Address(RVA = "0xF68C88", Offset = "0xF68C88", VA = "0xF68C88")]
			set
			{
			}
		}

		[Token(Token = "0x1700020F")]
		public float SplitLength
		{
			[Token(Token = "0x600090B")]
			[Address(RVA = "0xF68CAC", Offset = "0xF68CAC", VA = "0xF68CAC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600090C")]
			[Address(RVA = "0xF68CB4", Offset = "0xF68CB4", VA = "0xF68CB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000210")]
		public List<CGMaterialSettingsEx> MaterialSetttings
		{
			[Token(Token = "0x600090D")]
			[Address(RVA = "0xF68CF8", Offset = "0xF68CF8", VA = "0xF68CF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000211")]
		public int MaterialCount
		{
			[Token(Token = "0x600090E")]
			[Address(RVA = "0xF68D00", Offset = "0xF68D00", VA = "0xF68D00")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0xF68D4C", Offset = "0xF68D4C", VA = "0xF68D4C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0xF68E78", Offset = "0xF68E78", VA = "0xF68E78", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0xF69074", Offset = "0xF69074", VA = "0xF69074", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0xF68D98", Offset = "0xF68D98", VA = "0xF68D98")]
		public int AddMaterial()
		{
			return default(int);
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xF699BC", Offset = "0xF699BC", VA = "0xF699BC")]
		public void RemoveMaterial(int index)
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0xF69B40", Offset = "0xF69B40", VA = "0xF69B40")]
		public void SetMaterial(int index, Material mat)
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0xF69CB4", Offset = "0xF69CB4", VA = "0xF69CB4")]
		public Material GetMaterial(int index)
		{
			return null;
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0xF69594", Offset = "0xF69594", VA = "0xF69594")]
		private void prepare(CGVolume vol)
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0xF695C0", Offset = "0xF695C0", VA = "0xF695C0")]
		private void build(CGVMesh vmesh, CGVolume vol, IntRegion subset)
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0xF6A0D8", Offset = "0xF6A0D8", VA = "0xF6A0D8")]
		private static void prepareSubMeshes(CGVMesh vmesh, List<SamplePointsMaterialGroupCollection> groupsBySubMeshes, int extrusions, ref Material[] materials)
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0xF6A28C", Offset = "0xF6A28C", VA = "0xF6A28C")]
		private void createMaterialGroupUV(CGVMesh vmesh, CGVolume vol, SamplePointsMaterialGroup grp, int matIndex, float grpAspectCorrection, int sample, int baseVertex)
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0xF6A42C", Offset = "0xF6A42C", VA = "0xF6A42C")]
		private static int createPatchTriangles(ref int[] triangles, ref int triIdx, int curVTIndex, int patchSize, int crossSize, bool reverse)
		{
			return default(int);
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0xF69D10", Offset = "0xF69D10", VA = "0xF69D10")]
		private List<SamplePointsMaterialGroupCollection> getMaterialIDGroups(CGVolume volume)
		{
			return null;
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0xF69A84", Offset = "0xF69A84", VA = "0xF69A84")]
		private bool validateMaterialIndex(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0xF6A588", Offset = "0xF6A588", VA = "0xF6A588")]
		public BuildVolumeMesh()
		{
		}
	}
	[Token(Token = "0x2000128")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D91E0", Offset = "0x6D91E0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D91E0", Offset = "0x6D91E0")]
	public class BuildVolumeSpots : CGModule, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000129")]
		private class EndGroupData
		{
			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E20D8", Offset = "0x6E20D8")]
			private CGBoundsGroup <BoundsGroup>k__BackingField;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E20E8", Offset = "0x6E20E8")]
			private int[] <ItemIndices>k__BackingField;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E20F8", Offset = "0x6E20F8")]
			private readonly float <GroupDepth>k__BackingField;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E2108", Offset = "0x6E2108")]
			private readonly CGBounds[] <ItemBounds>k__BackingField;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E2118", Offset = "0x6E2118")]
			private readonly float <SpaceBefore>k__BackingField;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E2128", Offset = "0x6E2128")]
			private readonly float <SpaceAfter>k__BackingField;

			[Token(Token = "0x17000228")]
			internal CGBoundsGroup BoundsGroup
			{
				[Token(Token = "0x6000954")]
				[Address(RVA = "0x11F91C8", Offset = "0x11F91C8", VA = "0x11F91C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5D50", Offset = "0x6E5D50")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000955")]
				[Address(RVA = "0x11F91D0", Offset = "0x11F91D0", VA = "0x11F91D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5D60", Offset = "0x6E5D60")]
				private set
				{
				}
			}

			[Token(Token = "0x17000229")]
			internal int[] ItemIndices
			{
				[Token(Token = "0x6000956")]
				[Address(RVA = "0x11F91D8", Offset = "0x11F91D8", VA = "0x11F91D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5D70", Offset = "0x6E5D70")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000957")]
				[Address(RVA = "0x11F91E0", Offset = "0x11F91E0", VA = "0x11F91E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5D80", Offset = "0x6E5D80")]
				private set
				{
				}
			}

			[Token(Token = "0x1700022A")]
			internal float GroupDepth
			{
				[Token(Token = "0x6000958")]
				[Address(RVA = "0x11F91E8", Offset = "0x11F91E8", VA = "0x11F91E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5D90", Offset = "0x6E5D90")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700022B")]
			internal CGBounds[] ItemBounds
			{
				[Token(Token = "0x6000959")]
				[Address(RVA = "0x11F91F0", Offset = "0x11F91F0", VA = "0x11F91F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5DA0", Offset = "0x6E5DA0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700022C")]
			internal float SpaceBefore
			{
				[Token(Token = "0x600095A")]
				[Address(RVA = "0x11F91F8", Offset = "0x11F91F8", VA = "0x11F91F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5DB0", Offset = "0x6E5DB0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700022D")]
			internal float SpaceAfter
			{
				[Token(Token = "0x600095B")]
				[Address(RVA = "0x11F9200", Offset = "0x11F9200", VA = "0x11F9200")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5DC0", Offset = "0x6E5DC0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600095C")]
			[Address(RVA = "0x11F9208", Offset = "0x11F9208", VA = "0x11F9208")]
			public EndGroupData(CGBoundsGroup boundsGroup, int[] itemIndices, float groupDepth, CGBounds[] itemBounds, float spaceBefore, float spaceAfter)
			{
			}
		}

		[Token(Token = "0x200012A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9280", Offset = "0x6D9280")]
		private sealed class <>c__DisplayClass79_0
		{
			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EndGroupData endGroupData;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float availableSpace;

			[Token(Token = "0x600095D")]
			[Address(RVA = "0x11F9170", Offset = "0x11F9170", VA = "0x11F9170")]
			public <>c__DisplayClass79_0()
			{
			}

			[Token(Token = "0x600095E")]
			[Address(RVA = "0x11F9178", Offset = "0x11F9178", VA = "0x11F9178")]
			internal bool <Refresh>b__0(CGBounds i)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E18E4", Offset = "0x6E18E4")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E19C4", Offset = "0x6E19C4")]
		[HideInInspector]
		public CGModuleInputSlot InBounds;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6E1A7C", Offset = "0x6E1A7C")]
		public CGModuleOutputSlot OutSpots;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[HideInInspector]
		[SerializeField]
		private bool m_WasUpgraded;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6E1B24", Offset = "0x6E1B24")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6E1B24", Offset = "0x6E1B24")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_Range;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E1BD8", Offset = "0x6E1BD8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6E1BD8", Offset = "0x6E1BD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E1BD8", Offset = "0x6E1BD8")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6E1BD8", Offset = "0x6E1BD8")]
		private bool m_UseVolume;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6E1CC4", Offset = "0x6E1CC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E1CC4", Offset = "0x6E1CC4")]
		private float m_CrossBase;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6E1D58", Offset = "0x6E1D58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E1D58", Offset = "0x6E1D58")]
		private AnimationCurve m_CrossCurve;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x6E1DE4", Offset = "0x6E1DE4")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E1DE4", Offset = "0x6E1DE4")]
		private bool m_Simulate;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E1E60", Offset = "0x6E1E60")]
		private bool m_UseBuggedRNG;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6E1EAC", Offset = "0x6E1EAC")]
		[ArrayEx]
		[SerializeField]
		private List<CGBoundsGroup> m_Groups;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[IntRegion]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E1F14", Offset = "0x6E1F14")]
		[SerializeField]
		private IntRegion m_RepeatingGroups;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[SerializeField]
		private CurvyRepeatingOrderEnum m_RepeatingOrder;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E1FAC", Offset = "0x6E1FAC")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6E1FAC", Offset = "0x6E1FAC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E1FAC", Offset = "0x6E1FAC")]
		private bool m_FitEnd;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E20B8", Offset = "0x6E20B8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E20C8", Offset = "0x6E20C8")]
		private CGPath <Path>k__BackingField;

		[Token(Token = "0x17000212")]
		public FloatRegion Range
		{
			[Token(Token = "0x600091E")]
			[Address(RVA = "0xF6A6B8", Offset = "0xF6A6B8", VA = "0xF6A6B8")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x600091F")]
			[Address(RVA = "0xF6A6C8", Offset = "0xF6A6C8", VA = "0xF6A6C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000213")]
		public bool UseVolume
		{
			[Token(Token = "0x6000920")]
			[Address(RVA = "0xF6A720", Offset = "0xF6A720", VA = "0xF6A720")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000921")]
			[Address(RVA = "0xF6A728", Offset = "0xF6A728", VA = "0xF6A728")]
			set
			{
			}
		}

		[Token(Token = "0x17000214")]
		public bool Simulate
		{
			[Token(Token = "0x6000922")]
			[Address(RVA = "0xF6A74C", Offset = "0xF6A74C", VA = "0xF6A74C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000923")]
			[Address(RVA = "0xF6A754", Offset = "0xF6A754", VA = "0xF6A754")]
			set
			{
			}
		}

		[Token(Token = "0x17000215")]
		public bool UseBuggedRng
		{
			[Token(Token = "0x6000924")]
			[Address(RVA = "0xF6A778", Offset = "0xF6A778", VA = "0xF6A778")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000925")]
			[Address(RVA = "0xF6A780", Offset = "0xF6A780", VA = "0xF6A780")]
			set
			{
			}
		}

		[Token(Token = "0x17000216")]
		public float CrossBase
		{
			[Token(Token = "0x6000926")]
			[Address(RVA = "0xF6A7A4", Offset = "0xF6A7A4", VA = "0xF6A7A4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000927")]
			[Address(RVA = "0xF6A7AC", Offset = "0xF6A7AC", VA = "0xF6A7AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000217")]
		public AnimationCurve CrossCurve
		{
			[Token(Token = "0x6000928")]
			[Address(RVA = "0xF6A7EC", Offset = "0xF6A7EC", VA = "0xF6A7EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000929")]
			[Address(RVA = "0xF6A7F4", Offset = "0xF6A7F4", VA = "0xF6A7F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000218")]
		public List<CGBoundsGroup> Groups
		{
			[Token(Token = "0x600092A")]
			[Address(RVA = "0xF6A82C", Offset = "0xF6A82C", VA = "0xF6A82C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600092B")]
			[Address(RVA = "0xF6A834", Offset = "0xF6A834", VA = "0xF6A834")]
			set
			{
			}
		}

		[Token(Token = "0x17000219")]
		public CurvyRepeatingOrderEnum RepeatingOrder
		{
			[Token(Token = "0x600092C")]
			[Address(RVA = "0xF6A84C", Offset = "0xF6A84C", VA = "0xF6A84C")]
			get
			{
				return default(CurvyRepeatingOrderEnum);
			}
			[Token(Token = "0x600092D")]
			[Address(RVA = "0xF6A854", Offset = "0xF6A854", VA = "0xF6A854")]
			set
			{
			}
		}

		[Token(Token = "0x1700021A")]
		public int FirstRepeating
		{
			[Token(Token = "0x600092E")]
			[Address(RVA = "0xF6A86C", Offset = "0xF6A86C", VA = "0xF6A86C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600092F")]
			[Address(RVA = "0xF6A874", Offset = "0xF6A874", VA = "0xF6A874")]
			set
			{
			}
		}

		[Token(Token = "0x1700021B")]
		public int LastRepeating
		{
			[Token(Token = "0x6000930")]
			[Address(RVA = "0xF6A920", Offset = "0xF6A920", VA = "0xF6A920")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000931")]
			[Address(RVA = "0xF6A928", Offset = "0xF6A928", VA = "0xF6A928")]
			set
			{
			}
		}

		[Token(Token = "0x1700021C")]
		public bool FitEnd
		{
			[Token(Token = "0x6000932")]
			[Address(RVA = "0xF6A994", Offset = "0xF6A994", VA = "0xF6A994")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000933")]
			[Address(RVA = "0xF6A99C", Offset = "0xF6A99C", VA = "0xF6A99C")]
			set
			{
			}
		}

		[Token(Token = "0x1700021D")]
		public int GroupCount
		{
			[Token(Token = "0x6000934")]
			[Address(RVA = "0xF6A8D4", Offset = "0xF6A8D4", VA = "0xF6A8D4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700021E")]
		public GUIContent[] BoundsNames
		{
			[Token(Token = "0x6000935")]
			[Address(RVA = "0xF6A9C0", Offset = "0xF6A9C0", VA = "0xF6A9C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021F")]
		public int[] BoundsIndices
		{
			[Token(Token = "0x6000936")]
			[Address(RVA = "0xF6ABE4", Offset = "0xF6ABE4", VA = "0xF6ABE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000220")]
		public int Count
		{
			[Token(Token = "0x6000937")]
			[Address(RVA = "0xF6ACA8", Offset = "0xF6ACA8", VA = "0xF6ACA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5D10", Offset = "0x6E5D10")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000938")]
			[Address(RVA = "0xF6ACB0", Offset = "0xF6ACB0", VA = "0xF6ACB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5D20", Offset = "0x6E5D20")]
			private set
			{
			}
		}

		[Token(Token = "0x17000221")]
		private int lastGroupIndex
		{
			[Token(Token = "0x6000939")]
			[Address(RVA = "0xF6ACB8", Offset = "0xF6ACB8", VA = "0xF6ACB8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000222")]
		private RegionOptions<float> RangeOptions
		{
			[Token(Token = "0x600093A")]
			[Address(RVA = "0xF6ACD8", Offset = "0xF6ACD8", VA = "0xF6ACD8")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x17000223")]
		private RegionOptions<int> RepeatingGroupsOptions
		{
			[Token(Token = "0x600093B")]
			[Address(RVA = "0xF6AD48", Offset = "0xF6AD48", VA = "0xF6AD48")]
			get
			{
				return default(RegionOptions<int>);
			}
		}

		[Token(Token = "0x17000224")]
		private CGPath Path
		{
			[Token(Token = "0x600093C")]
			[Address(RVA = "0xF6ADDC", Offset = "0xF6ADDC", VA = "0xF6ADDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5D30", Offset = "0x6E5D30")]
			get
			{
				return null;
			}
			[Token(Token = "0x600093D")]
			[Address(RVA = "0xF6ADE4", Offset = "0xF6ADE4", VA = "0xF6ADE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5D40", Offset = "0x6E5D40")]
			set
			{
			}
		}

		[Token(Token = "0x17000225")]
		private CGVolume Volume
		{
			[Token(Token = "0x600093E")]
			[Address(RVA = "0xF6ADF4", Offset = "0xF6ADF4", VA = "0xF6ADF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000226")]
		private float Length
		{
			[Token(Token = "0x600093F")]
			[Address(RVA = "0xF6AE74", Offset = "0xF6AE74", VA = "0xF6AE74")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000227")]
		private bool ShowFitEnd
		{
			[Token(Token = "0x6000950")]
			[Address(RVA = "0xF6E378", Offset = "0xF6E378", VA = "0xF6E378")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0xF6AEB0", Offset = "0xF6AEB0", VA = "0xF6AEB0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0xF6AEE4", Offset = "0xF6AEE4", VA = "0xF6AEE4", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0xF6B11C", Offset = "0xF6B11C", VA = "0xF6B11C", Slot = "12")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0xF6B20C", Offset = "0xF6B20C", VA = "0xF6B20C")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0xF6B30C", Offset = "0xF6B30C", VA = "0xF6B30C", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0xF6B024", Offset = "0xF6B024", VA = "0xF6B024")]
		public CGBoundsGroup AddGroup(string name)
		{
			return null;
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0xF6D710", Offset = "0xF6D710", VA = "0xF6D710")]
		public void RemoveGroup(CGBoundsGroup group)
		{
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0xF6CE98", Offset = "0xF6CE98", VA = "0xF6CE98")]
		private static int[] GetGroupItemIndices(CGBoundsGroup boundsGroup, WeightedRandom<int> groupItemBag)
		{
			return null;
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0xF6D050", Offset = "0xF6D050", VA = "0xF6D050")]
		private float GetGroupDepth(int[] groupItemIndices, float spaceBefore, float spaceAfter, out CGBounds[] itemsBounds)
		{
			return default(float);
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0xF6CCCC", Offset = "0xF6CCCC", VA = "0xF6CCCC")]
		private bool AddGroupItems(int groupIndex, ref List<CGSpot> spots, float remainingLength, float startDistance, ref float currentDistance, out bool failedAddingAllItems, Dictionary<CGBoundsGroup, WeightedRandom<int>> itemsBagDictionary, int MaxSpotsCount)
		{
			return default(bool);
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0xF6D1E8", Offset = "0xF6D1E8", VA = "0xF6D1E8")]
		private void AddGroupItems(CGBoundsGroup group, ref List<CGSpot> spots, float remainingLength, float startDistance, ref float currentDistance, out bool failedAddingAllItems, int[] itemIndices, float groupDepth, CGBounds[] itemBounds, float spaceBefore, float spaceAfter)
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0xF6D790", Offset = "0xF6D790", VA = "0xF6D790")]
		private CGSpot GetSpot(int itemID, CGBoundsGroup boundsGroup, CGBounds bounds, float currentDistance, float startDistance)
		{
			return default(CGSpot);
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0xF6CFFC", Offset = "0xF6CFFC", VA = "0xF6CFFC")]
		private static float GetRegionNextValue(FloatRegion floatRegion)
		{
			return default(float);
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0xF6E05C", Offset = "0xF6E05C", VA = "0xF6E05C")]
		private void GetTRS(CGBoundsGroup boundsGroup, Vector3 tangent, Vector3 up, out Quaternion rotation, out Vector3 translation, out Vector3 scale)
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0xF6DC08", Offset = "0xF6DC08", VA = "0xF6DC08")]
		private void GetTRS630(CGBoundsGroup boundsGroup, Vector3 tangent, Vector3 up, out Quaternion rotation, out Vector3 translation, out Vector3 scale)
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0xF6C9A8", Offset = "0xF6C9A8", VA = "0xF6C9A8")]
		private Dictionary<CGBoundsGroup, WeightedRandom<int>> Prepare()
		{
			return null;
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0xF6E3D4", Offset = "0xF6E3D4", VA = "0xF6E3D4", Slot = "14")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0xF6E3D8", Offset = "0xF6E3D8", VA = "0xF6E3D8", Slot = "15")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0xF6EBC8", Offset = "0xF6EBC8", VA = "0xF6EBC8")]
		public BuildVolumeSpots()
		{
		}
	}
	[Token(Token = "0x200012B")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D9290", Offset = "0x6D9290")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D9290", Offset = "0x6D9290")]
	public class ConformPath : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E2138", Offset = "0x6E2138")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6E2210", Offset = "0x6E2210")]
		[HideInInspector]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E2280", Offset = "0x6E2280")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x6E2280", Offset = "0x6E2280")]
		private Vector3 m_Direction;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E230C", Offset = "0x6E230C")]
		private float m_MaxDistance;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E2358", Offset = "0x6E2358")]
		private float m_Offset;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E23A4", Offset = "0x6E23A4")]
		private bool m_Warp;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E23F0", Offset = "0x6E23F0")]
		private LayerMask m_LayerMask;

		[Token(Token = "0x1700022E")]
		public Vector3 Direction
		{
			[Token(Token = "0x600095F")]
			[Address(RVA = "0xEC4D74", Offset = "0xEC4D74", VA = "0xEC4D74")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000960")]
			[Address(RVA = "0xEC4D80", Offset = "0xEC4D80", VA = "0xEC4D80")]
			set
			{
			}
		}

		[Token(Token = "0x1700022F")]
		public float MaxDistance
		{
			[Token(Token = "0x6000961")]
			[Address(RVA = "0xEC4DF0", Offset = "0xEC4DF0", VA = "0xEC4DF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000962")]
			[Address(RVA = "0xEC4DF8", Offset = "0xEC4DF8", VA = "0xEC4DF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000230")]
		public float Offset
		{
			[Token(Token = "0x6000963")]
			[Address(RVA = "0xEC4E14", Offset = "0xEC4E14", VA = "0xEC4E14")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000964")]
			[Address(RVA = "0xEC4E1C", Offset = "0xEC4E1C", VA = "0xEC4E1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000231")]
		public bool Warp
		{
			[Token(Token = "0x6000965")]
			[Address(RVA = "0xEC4E38", Offset = "0xEC4E38", VA = "0xEC4E38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000966")]
			[Address(RVA = "0xEC4E40", Offset = "0xEC4E40", VA = "0xEC4E40")]
			set
			{
			}
		}

		[Token(Token = "0x17000232")]
		public LayerMask LayerMask
		{
			[Token(Token = "0x6000967")]
			[Address(RVA = "0xEC4E68", Offset = "0xEC4E68", VA = "0xEC4E68")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000968")]
			[Address(RVA = "0xEC4E70", Offset = "0xEC4E70", VA = "0xEC4E70")]
			set
			{
			}
		}

		[Token(Token = "0x17000233")]
		public bool PathIsClosed
		{
			[Token(Token = "0x600096B")]
			[Address(RVA = "0xEC4FB8", Offset = "0xEC4FB8", VA = "0xEC4FB8", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0xEC4ECC", Offset = "0xEC4ECC", VA = "0xEC4ECC", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0xEC4F04", Offset = "0xEC4F04", VA = "0xEC4F04", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0xEC50A4", Offset = "0xEC50A4", VA = "0xEC50A4", Slot = "14")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0xEC5238", Offset = "0xEC5238", VA = "0xEC5238")]
		public static CGPath Conform(Transform pathTransform, CGPath path, LayerMask layers, Vector3 projectionDirection, float offset, float rayLength, bool warp)
		{
			return null;
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0xEC5568", Offset = "0xEC5568", VA = "0xEC5568")]
		public ConformPath()
		{
		}
	}
	[Token(Token = "0x200012C")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D9328", Offset = "0x6D9328")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D9328", Offset = "0x6D9328")]
	public class CreateGameObject : CGModule
	{
		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E243C", Offset = "0x6E243C")]
		[HideInInspector]
		public CGModuleInputSlot InGameObjectArray;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E2510", Offset = "0x6E2510")]
		[HideInInspector]
		public CGModuleInputSlot InSpots;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceCollectionManagerAttribute", RVA = "0x6E25DC", Offset = "0x6E25DC")]
		private CGGameObjectResourceCollection m_Resources;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6E2634", Offset = "0x6E2634")]
		[SerializeField]
		private bool m_MakeStatic;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "LayerAttribute", RVA = "0x6E2680", Offset = "0x6E2680")]
		private int m_Layer;

		[Token(Token = "0x17000234")]
		public int Layer
		{
			[Token(Token = "0x600096F")]
			[Address(RVA = "0xEC5BD8", Offset = "0xEC5BD8", VA = "0xEC5BD8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000970")]
			[Address(RVA = "0xEC5BE0", Offset = "0xEC5BE0", VA = "0xEC5BE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000235")]
		public bool MakeStatic
		{
			[Token(Token = "0x6000971")]
			[Address(RVA = "0xEC5C2C", Offset = "0xEC5C2C", VA = "0xEC5C2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000972")]
			[Address(RVA = "0xEC5C34", Offset = "0xEC5C34", VA = "0xEC5C34")]
			set
			{
			}
		}

		[Token(Token = "0x17000236")]
		public CGGameObjectResourceCollection GameObjects
		{
			[Token(Token = "0x6000973")]
			[Address(RVA = "0xEC5C5C", Offset = "0xEC5C5C", VA = "0xEC5C5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000237")]
		public int GameObjectCount
		{
			[Token(Token = "0x6000974")]
			[Address(RVA = "0xEC5C64", Offset = "0xEC5C64", VA = "0xEC5C64")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0xEC5C80", Offset = "0xEC5C80", VA = "0xEC5C80", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0xEC5E2C", Offset = "0xEC5E2C", VA = "0xEC5E2C", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0xEC5E70", Offset = "0xEC5E70", VA = "0xEC5E70", Slot = "13")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0xEC5CD0", Offset = "0xEC5CD0", VA = "0xEC5CD0")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0xEC5E74", Offset = "0xEC5E74", VA = "0xEC5E74", Slot = "12")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0xEC5EBC", Offset = "0xEC5EBC", VA = "0xEC5EBC", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0xEC66E4", Offset = "0xEC66E4", VA = "0xEC66E4")]
		public CreateGameObject()
		{
		}
	}
	[Token(Token = "0x200012D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D93A4", Offset = "0x6D93A4")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D93A4", Offset = "0x6D93A4")]
	public class CreateMesh : CGModule
	{
		[Serializable]
		[Token(Token = "0x200012E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9420", Offset = "0x6D9420")]
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
			[Address(RVA = "0x11F93F0", Offset = "0x11F93F0", VA = "0x11F93F0")]
			public <>c()
			{
			}

			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x11F93F8", Offset = "0x11F93F8", VA = "0x11F93F8")]
			internal bool <Refresh>b__109_0(CGSpots s)
			{
				return default(bool);
			}

			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x11F9404", Offset = "0x11F9404", VA = "0x11F9404")]
			internal IEnumerable<CGSpot> <Refresh>b__109_1(CGSpots s)
			{
				return null;
			}

			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x11F941C", Offset = "0x11F941C", VA = "0x11F941C")]
			internal int <createSpotMeshes>b__114_0(CGSpot a, CGSpot b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000473")]
		private const string DefaultTag = "Untagged";

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E26E8", Offset = "0x6E26E8")]
		[HideInInspector]
		public CGModuleInputSlot InVMeshArray;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E27BC", Offset = "0x6E27BC")]
		public CGModuleInputSlot InSpots;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceCollectionManagerAttribute", RVA = "0x6E2898", Offset = "0x6E2898")]
		private CGMeshResourceCollection m_MeshResources;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E28F0", Offset = "0x6E28F0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E28F0", Offset = "0x6E28F0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6E28F0", Offset = "0x6E28F0")]
		private bool m_Combine;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E29F0", Offset = "0x6E29F0")]
		[SerializeField]
		private bool m_GroupMeshes;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E2A3C", Offset = "0x6E2A3C")]
		private CGYesNoAuto m_AddNormals;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E2AF4", Offset = "0x6E2AF4")]
		private CGYesNoAuto m_AddTangents;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E2BAC", Offset = "0x6E2BAC")]
		[SerializeField]
		private bool m_AddUV2;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E2C64", Offset = "0x6E2C64")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E2C64", Offset = "0x6E2C64")]
		private bool m_MakeStatic;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E2D40", Offset = "0x6E2D40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E2D40", Offset = "0x6E2D40")]
		[SerializeField]
		[AttributeAttribute(Name = "LayerAttribute", RVA = "0x6E2D40", Offset = "0x6E2D40")]
		private int m_Layer;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[AttributeAttribute(Name = "TagAttribute", RVA = "0x6E2E54", Offset = "0x6E2E54")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E2E54", Offset = "0x6E2E54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E2E54", Offset = "0x6E2E54")]
		private string m_Tag;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6E2F70", Offset = "0x6E2F70")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E2F70", Offset = "0x6E2F70")]
		private bool m_RendererEnabled;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E304C", Offset = "0x6E304C")]
		private ShadowCastingMode m_CastShadows;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E3104", Offset = "0x6E3104")]
		private bool m_ReceiveShadows;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E31BC", Offset = "0x6E31BC")]
		private LightProbeUsage m_LightProbeUsage;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[HideInInspector]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E3274", Offset = "0x6E3274")]
		private bool m_UseLightProbes;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E333C", Offset = "0x6E333C")]
		[SerializeField]
		private ReflectionProbeUsage m_ReflectionProbes;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E33F4", Offset = "0x6E33F4")]
		[SerializeField]
		private Transform m_AnchorOverride;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E34AC", Offset = "0x6E34AC")]
		[SerializeField]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6E34AC", Offset = "0x6E34AC")]
		private CGColliderEnum m_Collider;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E3588", Offset = "0x6E3588")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E3588", Offset = "0x6E3588")]
		private bool m_Convex;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x105")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E36AC", Offset = "0x6E36AC")]
		[SerializeField]
		private bool m_IsTrigger;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E3764", Offset = "0x6E3764")]
		[AttributeAttribute(Name = "EnumFlagAttribute", RVA = "0x6E3764", Offset = "0x6E3764")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E3764", Offset = "0x6E3764")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E3764", Offset = "0x6E3764")]
		[SerializeField]
		private MeshColliderCookingOptions m_CookingOptions;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6E38E4", Offset = "0x6E38E4")]
		private bool m_AutoUpdateColliders;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private PhysicMaterial m_Material;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E3954", Offset = "0x6E3954")]
		private int <VertexCount>k__BackingField;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private int mCurrentMeshCount;

		[Token(Token = "0x17000238")]
		public bool Combine
		{
			[Token(Token = "0x600097C")]
			[Address(RVA = "0xEC67B8", Offset = "0xEC67B8", VA = "0xEC67B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600097D")]
			[Address(RVA = "0xEC67C0", Offset = "0xEC67C0", VA = "0xEC67C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000239")]
		public bool GroupMeshes
		{
			[Token(Token = "0x600097E")]
			[Address(RVA = "0xEC67E8", Offset = "0xEC67E8", VA = "0xEC67E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600097F")]
			[Address(RVA = "0xEC67F0", Offset = "0xEC67F0", VA = "0xEC67F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700023A")]
		public CGYesNoAuto AddNormals
		{
			[Token(Token = "0x6000980")]
			[Address(RVA = "0xEC6818", Offset = "0xEC6818", VA = "0xEC6818")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x6000981")]
			[Address(RVA = "0xEC6820", Offset = "0xEC6820", VA = "0xEC6820")]
			set
			{
			}
		}

		[Token(Token = "0x1700023B")]
		public CGYesNoAuto AddTangents
		{
			[Token(Token = "0x6000982")]
			[Address(RVA = "0xEC683C", Offset = "0xEC683C", VA = "0xEC683C")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x6000983")]
			[Address(RVA = "0xEC6844", Offset = "0xEC6844", VA = "0xEC6844")]
			set
			{
			}
		}

		[Token(Token = "0x1700023C")]
		public bool AddUV2
		{
			[Token(Token = "0x6000984")]
			[Address(RVA = "0xEC6860", Offset = "0xEC6860", VA = "0xEC6860")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000985")]
			[Address(RVA = "0xEC6868", Offset = "0xEC6868", VA = "0xEC6868")]
			set
			{
			}
		}

		[Token(Token = "0x1700023D")]
		public int Layer
		{
			[Token(Token = "0x6000986")]
			[Address(RVA = "0xEC6890", Offset = "0xEC6890", VA = "0xEC6890")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000987")]
			[Address(RVA = "0xEC6898", Offset = "0xEC6898", VA = "0xEC6898")]
			set
			{
			}
		}

		[Token(Token = "0x1700023E")]
		public string Tag
		{
			[Token(Token = "0x6000988")]
			[Address(RVA = "0xEC68E4", Offset = "0xEC68E4", VA = "0xEC68E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000989")]
			[Address(RVA = "0xEC68EC", Offset = "0xEC68EC", VA = "0xEC68EC")]
			set
			{
			}
		}

		[Token(Token = "0x1700023F")]
		public bool MakeStatic
		{
			[Token(Token = "0x600098A")]
			[Address(RVA = "0xEC6944", Offset = "0xEC6944", VA = "0xEC6944")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600098B")]
			[Address(RVA = "0xEC694C", Offset = "0xEC694C", VA = "0xEC694C")]
			set
			{
			}
		}

		[Token(Token = "0x17000240")]
		public bool RendererEnabled
		{
			[Token(Token = "0x600098C")]
			[Address(RVA = "0xEC6974", Offset = "0xEC6974", VA = "0xEC6974")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600098D")]
			[Address(RVA = "0xEC697C", Offset = "0xEC697C", VA = "0xEC697C")]
			set
			{
			}
		}

		[Token(Token = "0x17000241")]
		public ShadowCastingMode CastShadows
		{
			[Token(Token = "0x600098E")]
			[Address(RVA = "0xEC69A4", Offset = "0xEC69A4", VA = "0xEC69A4")]
			get
			{
				return default(ShadowCastingMode);
			}
			[Token(Token = "0x600098F")]
			[Address(RVA = "0xEC69AC", Offset = "0xEC69AC", VA = "0xEC69AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000242")]
		public bool ReceiveShadows
		{
			[Token(Token = "0x6000990")]
			[Address(RVA = "0xEC69C8", Offset = "0xEC69C8", VA = "0xEC69C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000991")]
			[Address(RVA = "0xEC69D0", Offset = "0xEC69D0", VA = "0xEC69D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000243")]
		public bool UseLightProbes
		{
			[Token(Token = "0x6000992")]
			[Address(RVA = "0xEC69F8", Offset = "0xEC69F8", VA = "0xEC69F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000993")]
			[Address(RVA = "0xEC6A00", Offset = "0xEC6A00", VA = "0xEC6A00")]
			set
			{
			}
		}

		[Token(Token = "0x17000244")]
		public LightProbeUsage LightProbeUsage
		{
			[Token(Token = "0x6000994")]
			[Address(RVA = "0xEC6A28", Offset = "0xEC6A28", VA = "0xEC6A28")]
			get
			{
				return default(LightProbeUsage);
			}
			[Token(Token = "0x6000995")]
			[Address(RVA = "0xEC6A30", Offset = "0xEC6A30", VA = "0xEC6A30")]
			set
			{
			}
		}

		[Token(Token = "0x17000245")]
		public ReflectionProbeUsage ReflectionProbes
		{
			[Token(Token = "0x6000996")]
			[Address(RVA = "0xEC6A4C", Offset = "0xEC6A4C", VA = "0xEC6A4C")]
			get
			{
				return default(ReflectionProbeUsage);
			}
			[Token(Token = "0x6000997")]
			[Address(RVA = "0xEC6A54", Offset = "0xEC6A54", VA = "0xEC6A54")]
			set
			{
			}
		}

		[Token(Token = "0x17000246")]
		public Transform AnchorOverride
		{
			[Token(Token = "0x6000998")]
			[Address(RVA = "0xEC6A70", Offset = "0xEC6A70", VA = "0xEC6A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000999")]
			[Address(RVA = "0xEC6A78", Offset = "0xEC6A78", VA = "0xEC6A78")]
			set
			{
			}
		}

		[Token(Token = "0x17000247")]
		public CGColliderEnum Collider
		{
			[Token(Token = "0x600099A")]
			[Address(RVA = "0xEC6B18", Offset = "0xEC6B18", VA = "0xEC6B18")]
			get
			{
				return default(CGColliderEnum);
			}
			[Token(Token = "0x600099B")]
			[Address(RVA = "0xEC6B20", Offset = "0xEC6B20", VA = "0xEC6B20")]
			set
			{
			}
		}

		[Token(Token = "0x17000248")]
		public bool AutoUpdateColliders
		{
			[Token(Token = "0x600099C")]
			[Address(RVA = "0xEC6B3C", Offset = "0xEC6B3C", VA = "0xEC6B3C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600099D")]
			[Address(RVA = "0xEC6B44", Offset = "0xEC6B44", VA = "0xEC6B44")]
			set
			{
			}
		}

		[Token(Token = "0x17000249")]
		public bool Convex
		{
			[Token(Token = "0x600099E")]
			[Address(RVA = "0xEC6B6C", Offset = "0xEC6B6C", VA = "0xEC6B6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600099F")]
			[Address(RVA = "0xEC6B74", Offset = "0xEC6B74", VA = "0xEC6B74")]
			set
			{
			}
		}

		[Token(Token = "0x1700024A")]
		public bool IsTrigger
		{
			[Token(Token = "0x60009A0")]
			[Address(RVA = "0xEC6B9C", Offset = "0xEC6B9C", VA = "0xEC6B9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009A1")]
			[Address(RVA = "0xEC6BA4", Offset = "0xEC6BA4", VA = "0xEC6BA4")]
			set
			{
			}
		}

		[Token(Token = "0x1700024B")]
		public MeshColliderCookingOptions CookingOptions
		{
			[Token(Token = "0x60009A2")]
			[Address(RVA = "0xEC6BCC", Offset = "0xEC6BCC", VA = "0xEC6BCC")]
			get
			{
				return default(MeshColliderCookingOptions);
			}
			[Token(Token = "0x60009A3")]
			[Address(RVA = "0xEC6BD4", Offset = "0xEC6BD4", VA = "0xEC6BD4")]
			set
			{
			}
		}

		[Token(Token = "0x1700024C")]
		public PhysicMaterial Material
		{
			[Token(Token = "0x60009A4")]
			[Address(RVA = "0xEC6BF0", Offset = "0xEC6BF0", VA = "0xEC6BF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009A5")]
			[Address(RVA = "0xEC6BF8", Offset = "0xEC6BF8", VA = "0xEC6BF8")]
			set
			{
			}
		}

		[Token(Token = "0x1700024D")]
		public CGMeshResourceCollection Meshes
		{
			[Token(Token = "0x60009A6")]
			[Address(RVA = "0xEC6C94", Offset = "0xEC6C94", VA = "0xEC6C94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700024E")]
		public int MeshCount
		{
			[Token(Token = "0x60009A7")]
			[Address(RVA = "0xEC6C9C", Offset = "0xEC6C9C", VA = "0xEC6C9C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700024F")]
		public int VertexCount
		{
			[Token(Token = "0x60009A8")]
			[Address(RVA = "0xEC6CB8", Offset = "0xEC6CB8", VA = "0xEC6CB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5DD0", Offset = "0x6E5DD0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60009A9")]
			[Address(RVA = "0xEC6CC0", Offset = "0xEC6CC0", VA = "0xEC6CC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E5DE0", Offset = "0x6E5DE0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000250")]
		private bool canGroupMeshes
		{
			[Token(Token = "0x60009AA")]
			[Address(RVA = "0xEC6CC8", Offset = "0xEC6CC8", VA = "0xEC6CC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000251")]
		private bool canModifyStaticFlag
		{
			[Token(Token = "0x60009AB")]
			[Address(RVA = "0xEC6D0C", Offset = "0xEC6D0C", VA = "0xEC6D0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000252")]
		private bool canUpdate
		{
			[Token(Token = "0x60009AC")]
			[Address(RVA = "0xEC6D14", Offset = "0xEC6D14", VA = "0xEC6D14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000253")]
		private bool EnableIsTrigger
		{
			[Token(Token = "0x60009AD")]
			[Address(RVA = "0xEC6D50", Offset = "0xEC6D50", VA = "0xEC6D50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0xEC6DA8", Offset = "0xEC6DA8", VA = "0xEC6DA8", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0xEC7080", Offset = "0xEC7080", VA = "0xEC7080", Slot = "13")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0xEC7064", Offset = "0xEC7064", VA = "0xEC7064")]
		public void Clear()
		{
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0xEC71CC", Offset = "0xEC71CC", VA = "0xEC71CC", Slot = "12")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0xEC7220", Offset = "0xEC7220", VA = "0xEC7220", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0xEC867C", Offset = "0xEC867C", VA = "0xEC867C")]
		public GameObject SaveToScene([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0xEC84EC", Offset = "0xEC84EC", VA = "0xEC84EC")]
		public void UpdateColliders()
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0xEC889C", Offset = "0xEC889C", VA = "0xEC889C")]
		private static GameObject SaveMeshResourceToScene(UnityEngine.Component managedResource, Transform newParent)
		{
			return null;
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0xEC80B8", Offset = "0xEC80B8", VA = "0xEC80B8")]
		private void createMeshes(ref List<CGVMesh> vMeshes, bool combine)
		{
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0xEC770C", Offset = "0xEC770C", VA = "0xEC770C")]
		private void createSpotMeshes(ref List<CGVMesh> vMeshes, CGSpot[] spots, bool combine)
		{
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0xEC8A0C", Offset = "0xEC8A0C", VA = "0xEC8A0C")]
		private CGMeshResource writeVMeshToMesh(ref CGVMesh vmesh)
		{
			return null;
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0xEC709C", Offset = "0xEC709C", VA = "0xEC709C")]
		private void removeUnusedResource()
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0xEC8C48", Offset = "0xEC8C48", VA = "0xEC8C48")]
		private CGMeshResource getNewMesh()
		{
			return null;
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0xEC8F5C", Offset = "0xEC8F5C", VA = "0xEC8F5C")]
		public CreateMesh()
		{
		}
	}
	[Token(Token = "0x200012F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D9430", Offset = "0x6D9430")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D9430", Offset = "0x6D9430")]
	public class CreatePathLineRenderer : CGModule
	{
		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E3964", Offset = "0x6E3964")]
		[HideInInspector]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private LineRenderer mLineRenderer;

		[Token(Token = "0x17000254")]
		public LineRenderer LineRenderer
		{
			[Token(Token = "0x60009C1")]
			[Address(RVA = "0xEC9094", Offset = "0xEC9094", VA = "0xEC9094")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0xEC9148", Offset = "0xEC9148", VA = "0xEC9148", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0xEC9280", Offset = "0xEC9280", VA = "0xEC9280", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0xEC9170", Offset = "0xEC9170", VA = "0xEC9170")]
		private void createLR()
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0xEC93E0", Offset = "0xEC93E0", VA = "0xEC93E0")]
		public CreatePathLineRenderer()
		{
		}
	}
	[Token(Token = "0x2000130")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D94C8", Offset = "0x6D94C8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D94C8", Offset = "0x6D94C8")]
	public class DebugRasterizedPath : CGModule
	{
		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E3A30", Offset = "0x6E3A30")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E3AF4", Offset = "0x6E3AF4")]
		public bool ShowNormals;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E3B2C", Offset = "0x6E3B2C")]
		public bool ShowOrientation;

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x1218B0C", Offset = "0x1218B0C", VA = "0x1218B0C", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x1218B38", Offset = "0x1218B38", VA = "0x1218B38")]
		public DebugRasterizedPath()
		{
		}
	}
	[Token(Token = "0x2000131")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D9560", Offset = "0x6D9560")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D9560", Offset = "0x6D9560")]
	public class DebugVMesh : CGModule
	{
		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E3B64", Offset = "0x6E3B64")]
		public CGModuleInputSlot InData;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6E3C28", Offset = "0x6E3C28")]
		public bool ShowVertices;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool ShowVertexID;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
		public bool ShowUV;

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x1218BB0", Offset = "0x1218BB0", VA = "0x1218BB0", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x1218BDC", Offset = "0x1218BDC", VA = "0x1218BDC")]
		public DebugVMesh()
		{
		}
	}
	[Token(Token = "0x2000132")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D95DC", Offset = "0x6D95DC")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D95DC", Offset = "0x6D95DC")]
	public class DebugVolume : CGModule
	{
		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E3C60", Offset = "0x6E3C60")]
		public CGModuleInputSlot InData;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6E3D24", Offset = "0x6E3D24")]
		public bool ShowPathSamples;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool ShowCrossSamples;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E3D5C", Offset = "0x6E3D5C")]
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
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6E3E1C", Offset = "0x6E3E1C")]
		public bool Interpolate;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6E3E54", Offset = "0x6E3E54")]
		public float InterpolatePathF;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6E3EA8", Offset = "0x6E3EA8")]
		public float InterpolateCrossF;

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x1218C4C", Offset = "0x1218C4C", VA = "0x1218C4C")]
		public DebugVolume()
		{
		}
	}
	[Token(Token = "0x2000133")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D9658", Offset = "0x6D9658")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D9658", Offset = "0x6D9658")]
	public class InputGameObject : CGModule
	{
		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6E3EFC", Offset = "0x6E3EFC")]
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
			[Address(RVA = "0x121AC14", Offset = "0x121AC14", VA = "0x121AC14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000256")]
		public bool SupportsIPE
		{
			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x121AC1C", Offset = "0x121AC1C", VA = "0x121AC1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x121AC24", Offset = "0x121AC24", VA = "0x121AC24", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x121AC94", Offset = "0x121AC94", VA = "0x121AC94", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x121AE78", Offset = "0x121AE78", VA = "0x121AE78", Slot = "13")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x121AED8", Offset = "0x121AED8", VA = "0x121AED8")]
		public InputGameObject()
		{
		}
	}
	[Token(Token = "0x2000134")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D96F0", Offset = "0x6D96F0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D96F0", Offset = "0x6D96F0")]
	public class InputMesh : CGModule, IExternalInput
	{
		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6E3FB0", Offset = "0x6E3FB0")]
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
			[Address(RVA = "0x121AF94", Offset = "0x121AF94", VA = "0x121AF94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000258")]
		public bool SupportsIPE
		{
			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x121AF9C", Offset = "0x121AF9C", VA = "0x121AF9C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x121AFA4", Offset = "0x121AFA4", VA = "0x121AFA4", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x121B014", Offset = "0x121B014", VA = "0x121B014", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x121B23C", Offset = "0x121B23C", VA = "0x121B23C", Slot = "13")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x121B29C", Offset = "0x121B29C", VA = "0x121B29C")]
		public InputMesh()
		{
		}
	}
	[Token(Token = "0x2000135")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D9788", Offset = "0x6D9788")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D9788", Offset = "0x6D9788")]
	public class InputSplinePath : SplineInputModuleBase, IExternalInput, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6E4064", Offset = "0x6E4064")]
		public CGModuleOutputSlot Path;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CGResourceManagerAttribute", RVA = "0x6E40D4", Offset = "0x6E40D4")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6E40D4", Offset = "0x6E40D4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x6E40D4", Offset = "0x6E40D4")]
		[SerializeField]
		private CurvySpline m_Spline;

		[Token(Token = "0x17000259")]
		public CurvySpline Spline
		{
			[Token(Token = "0x60009D7")]
			[Address(RVA = "0xF3C2EC", Offset = "0xF3C2EC", VA = "0xF3C2EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0xF3C2F4", Offset = "0xF3C2F4", VA = "0xF3C2F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700025A")]
		public bool SupportsIPE
		{
			[Token(Token = "0x60009D9")]
			[Address(RVA = "0xF3C670", Offset = "0xF3C670", VA = "0xF3C670", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700025B")]
		protected override CurvySpline InputSpline
		{
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0xF3DFE4", Offset = "0xF3DFE4", VA = "0xF3DFE4", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0xF3DFEC", Offset = "0xF3DFEC", VA = "0xF3DFEC", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0xF3C678", Offset = "0xF3C678", VA = "0xF3C678", Slot = "19")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0xF3DF40", Offset = "0xF3DF40", VA = "0xF3DF40", Slot = "13")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0xF3DFF0", Offset = "0xF3DFF0", VA = "0xF3DFF0")]
		public InputSplinePath()
		{
		}
	}
	[Token(Token = "0x2000136")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D9820", Offset = "0x6D9820")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D9820", Offset = "0x6D9820")]
	public class InputSplineShape : SplineInputModuleBase, IExternalInput, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6E4198", Offset = "0x6E4198")]
		[HideInInspector]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x6E4208", Offset = "0x6E4208")]
		[AttributeAttribute(Name = "CGResourceManagerAttribute", RVA = "0x6E4208", Offset = "0x6E4208")]
		private CurvySpline m_Shape;

		[Token(Token = "0x1700025C")]
		public CurvySpline Shape
		{
			[Token(Token = "0x60009DF")]
			[Address(RVA = "0xF3E068", Offset = "0xF3E068", VA = "0xF3E068")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009E0")]
			[Address(RVA = "0xF3E070", Offset = "0xF3E070", VA = "0xF3E070")]
			set
			{
			}
		}

		[Token(Token = "0x1700025D")]
		public bool SupportsIPE
		{
			[Token(Token = "0x60009E1")]
			[Address(RVA = "0xF3E12C", Offset = "0xF3E12C", VA = "0xF3E12C", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700025E")]
		public bool FreeForm
		{
			[Token(Token = "0x60009E2")]
			[Address(RVA = "0xF3E130", Offset = "0xF3E130", VA = "0xF3E130")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009E3")]
			[Address(RVA = "0xF3E214", Offset = "0xF3E214", VA = "0xF3E214")]
			set
			{
			}
		}

		[Token(Token = "0x1700025F")]
		protected override CurvySpline InputSpline
		{
			[Token(Token = "0x60009E7")]
			[Address(RVA = "0xF3E580", Offset = "0xF3E580", VA = "0xF3E580", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009E8")]
			[Address(RVA = "0xF3E588", Offset = "0xF3E588", VA = "0xF3E588", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0xF3E374", Offset = "0xF3E374", VA = "0xF3E374", Slot = "19")]
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
		[Address(RVA = "0xF3E4C4", Offset = "0xF3E4C4", VA = "0xF3E4C4")]
		public void RemoveManagedShape()
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0xF3E58C", Offset = "0xF3E58C", VA = "0xF3E58C", Slot = "17")]
		protected override void OnSplineAssigned()
		{
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0xF3E824", Offset = "0xF3E824", VA = "0xF3E824")]
		public InputSplineShape()
		{
		}
	}
	[Token(Token = "0x2000137")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D98B8", Offset = "0x6D98B8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D98B8", Offset = "0x6D98B8")]
	public class InputSpots : CGModule
	{
		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6E427C", Offset = "0x6E427C")]
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
			[Address(RVA = "0xF3E894", Offset = "0xF3E894", VA = "0xF3E894")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009EC")]
			[Address(RVA = "0xF3E89C", Offset = "0xF3E89C", VA = "0xF3E89C")]
			set
			{
			}
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0xF3E8D8", Offset = "0xF3E8D8", VA = "0xF3E8D8", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0xF3E910", Offset = "0xF3E910", VA = "0xF3E910", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0xF3E980", Offset = "0xF3E980", VA = "0xF3E980", Slot = "12")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0xF3E988", Offset = "0xF3E988", VA = "0xF3E988", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0xF3EAC8", Offset = "0xF3EAC8", VA = "0xF3EAC8")]
		public InputSpots()
		{
		}
	}
	[Token(Token = "0x2000138")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D9950", Offset = "0x6D9950")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D9950", Offset = "0x6D9950")]
	public class ModifierMixPaths : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E4324", Offset = "0x6E4324")]
		public CGModuleInputSlot InPathA;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E43E8", Offset = "0x6E43E8")]
		public CGModuleInputSlot InPathB;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6E44AC", Offset = "0x6E44AC")]
		[HideInInspector]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6E451C", Offset = "0x6E451C")]
		[SerializeField]
		private float m_Mix;

		[Token(Token = "0x17000261")]
		public float Mix
		{
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0xF4128C", Offset = "0xF4128C", VA = "0xF4128C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009F3")]
			[Address(RVA = "0xF41294", Offset = "0xF41294", VA = "0xF41294")]
			set
			{
			}
		}

		[Token(Token = "0x17000262")]
		public bool PathIsClosed
		{
			[Token(Token = "0x60009F4")]
			[Address(RVA = "0xF412B0", Offset = "0xF412B0", VA = "0xF412B0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0xF41438", Offset = "0xF41438", VA = "0xF41438", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0xF41480", Offset = "0xF41480", VA = "0xF41480", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0xF414C0", Offset = "0xF414C0", VA = "0xF414C0", Slot = "14")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0xF41610", Offset = "0xF41610", VA = "0xF41610")]
		public static CGPath MixPath(CGPath pathA, CGPath pathB, float mix, [NotNull] List<string> warningsContainer)
		{
			return null;
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0xF421E8", Offset = "0xF421E8", VA = "0xF421E8")]
		public ModifierMixPaths()
		{
		}
	}
	[Token(Token = "0x2000139")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D99E8", Offset = "0x6D99E8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D99E8", Offset = "0x6D99E8")]
	public class ModifierMixShapes : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Serializable]
		[Token(Token = "0x200013A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9A80", Offset = "0x6D9A80")]
		private sealed class <>c
		{
			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<SamplePointsMaterialGroup, SamplePointsMaterialGroup> <>9__13_0;

			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x11FA178", Offset = "0x11FA178", VA = "0x11FA178")]
			public <>c()
			{
			}

			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x11FA180", Offset = "0x11FA180", VA = "0x11FA180")]
			internal SamplePointsMaterialGroup <InterpolateShape>b__13_0(SamplePointsMaterialGroup g)
			{
				return null;
			}
		}

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E45A8", Offset = "0x6E45A8")]
		public CGModuleInputSlot InShapeA;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E466C", Offset = "0x6E466C")]
		public CGModuleInputSlot InShapeB;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6E4730", Offset = "0x6E4730")]
		[HideInInspector]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x6E47A0", Offset = "0x6E47A0")]
		private float m_Mix;

		[Token(Token = "0x17000263")]
		public float Mix
		{
			[Token(Token = "0x60009FA")]
			[Address(RVA = "0xF422BC", Offset = "0xF422BC", VA = "0xF422BC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009FB")]
			[Address(RVA = "0xF422C4", Offset = "0xF422C4", VA = "0xF422C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000264")]
		public bool PathIsClosed
		{
			[Token(Token = "0x60009FC")]
			[Address(RVA = "0xF422E0", Offset = "0xF422E0", VA = "0xF422E0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0xF42468", Offset = "0xF42468", VA = "0xF42468", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0xF424B0", Offset = "0xF424B0", VA = "0xF424B0", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0xF424F0", Offset = "0xF424F0", VA = "0xF424F0", Slot = "14")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0xF42638", Offset = "0xF42638", VA = "0xF42638")]
		public static CGShape MixShapes(CGShape shapeA, CGShape shapeB, float mix, [NotNull] List<string> warningsContainer, bool ignoreWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0xF4198C", Offset = "0xF4198C", VA = "0xF4198C")]
		public static void InterpolateShape([NotNull] CGShape resultShape, CGShape shapeA, CGShape shapeB, float mix, [NotNull] List<string> warningsContainer, bool ignoreWarnings = false)
		{
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0xF426EC", Offset = "0xF426EC", VA = "0xF426EC")]
		public ModifierMixShapes()
		{
		}
	}
	[Token(Token = "0x200013B")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D9A90", Offset = "0x6D9A90")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D9A90", Offset = "0x6D9A90")]
	public class ModifierPathRelativeTranslation : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E482C", Offset = "0x6E482C")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6E4904", Offset = "0x6E4904")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6E4974", Offset = "0x6E4974")]
		private float lateralTranslation;

		[Token(Token = "0x17000265")]
		public float LateralTranslation
		{
			[Token(Token = "0x6000A06")]
			[Address(RVA = "0xF427C0", Offset = "0xF427C0", VA = "0xF427C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0xF427C8", Offset = "0xF427C8", VA = "0xF427C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000266")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A08")]
			[Address(RVA = "0xF427E8", Offset = "0xF427E8", VA = "0xF427E8", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0xF428D8", Offset = "0xF428D8", VA = "0xF428D8", Slot = "14")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0xF42AF4", Offset = "0xF42AF4", VA = "0xF42AF4", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0xF42B3C", Offset = "0xF42B3C", VA = "0xF42B3C", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0xF42B88", Offset = "0xF42B88", VA = "0xF42B88")]
		public ModifierPathRelativeTranslation()
		{
		}
	}
	[Token(Token = "0x200013C")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D9B28", Offset = "0x6D9B28")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D9B28", Offset = "0x6D9B28")]
	public class ModifierTRSMesh : TRSModuleBase
	{
		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E49C0", Offset = "0x6E49C0")]
		public CGModuleInputSlot InVMesh;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6E4A80", Offset = "0x6E4A80")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0xF42C30", Offset = "0xF42C30", VA = "0xF42C30", Slot = "10")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0xF42E34", Offset = "0xF42E34", VA = "0xF42E34")]
		public ModifierTRSMesh()
		{
		}
	}
	[Token(Token = "0x200013D")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D9BC0", Offset = "0x6D9BC0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D9BC0", Offset = "0x6D9BC0")]
	public class ModifierTRSPath : TRSModuleBase, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E4AFC", Offset = "0x6E4AFC")]
		[HideInInspector]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6E4BD0", Offset = "0x6E4BD0")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x17000267")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0xF42EDC", Offset = "0xF42EDC", VA = "0xF42EDC", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0xF42FCC", Offset = "0xF42FCC", VA = "0xF42FCC", Slot = "14")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0xF43274", Offset = "0xF43274", VA = "0xF43274")]
		public ModifierTRSPath()
		{
		}
	}
	[Token(Token = "0x200013E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D9C58", Offset = "0x6D9C58")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D9C58", Offset = "0x6D9C58")]
	public class ModifierTRSShape : TRSModuleBase, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E4C40", Offset = "0x6E4C40")]
		[HideInInspector]
		public CGModuleInputSlot InShape;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x6E4D14", Offset = "0x6E4D14")]
		[HideInInspector]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x17000268")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A12")]
			[Address(RVA = "0xF4331C", Offset = "0xF4331C", VA = "0xF4331C", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0xF4340C", Offset = "0xF4340C", VA = "0xF4340C", Slot = "14")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0xF436B4", Offset = "0xF436B4", VA = "0xF436B4")]
		public ModifierTRSShape()
		{
		}
	}
	[Token(Token = "0x200013F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D9CF0", Offset = "0x6D9CF0")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D9CF0", Offset = "0x6D9CF0")]
	public class ModifierVariableMixShapes : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E4D84", Offset = "0x6E4D84")]
		public CGModuleInputSlot InShapeA;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x6E4E48", Offset = "0x6E4E48")]
		[HideInInspector]
		public CGModuleInputSlot InShapeB;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "ShapeOutputSlotInfo", RVA = "0x6E4F14", Offset = "0x6E4F14")]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x6E4F68", Offset = "0x6E4F68")]
		private AnimationCurve m_MixCurve;

		[Token(Token = "0x17000269")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000A15")]
			[Address(RVA = "0xF4375C", Offset = "0xF4375C", VA = "0xF4375C", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700026A")]
		public AnimationCurve MixCurve
		{
			[Token(Token = "0x6000A16")]
			[Address(RVA = "0xF438E4", Offset = "0xF438E4", VA = "0xF438E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A17")]
			[Address(RVA = "0xF438EC", Offset = "0xF438EC", VA = "0xF438EC")]
			set
			{
			}
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0xF4391C", Offset = "0xF4391C", VA = "0xF4391C", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0xF43964", Offset = "0xF43964", VA = "0xF43964", Slot = "14")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0xF43B44", Offset = "0xF43B44", VA = "0xF43B44")]
		public ModifierVariableMixShapes()
		{
		}
	}
	[Token(Token = "0x2000140")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x6D9D88", Offset = "0x6D9D88")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D9D88", Offset = "0x6D9D88")]
	public class Note : CGModule, INoProcessing
	{
		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x6E4FC8", Offset = "0x6E4FC8")]
		private string m_Note;

		[Token(Token = "0x1700026B")]
		public string NoteText
		{
			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0xF43E70", Offset = "0xF43E70", VA = "0xF43E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0xF43E78", Offset = "0xF43E78", VA = "0xF43E78")]
			set
			{
			}
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0xF43EC0", Offset = "0xF43EC0", VA = "0xF43EC0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0xF43F08", Offset = "0xF43F08", VA = "0xF43F08", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0xF43F38", Offset = "0xF43F38", VA = "0xF43F38")]
		public Note()
		{
		}
	}
}
namespace Beebyte.Obfuscator
{
	[Token(Token = "0x2000141")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6D9E28", Offset = "0x6D9E28")]
	public class DoNotFakeAttribute : Attribute
	{
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x1218D2C", Offset = "0x1218D2C", VA = "0x1218D2C")]
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
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6D9E3C", Offset = "0x6D9E3C")]
	public class ObfuscateLiteralsAttribute : Attribute
	{
		[Token(Token = "0x6000A21")]
		[Address(RVA = "0xF43F40", Offset = "0xF43F40", VA = "0xF43F40")]
		public ObfuscateLiteralsAttribute()
		{
		}
	}
	[Token(Token = "0x2000144")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6D9E50", Offset = "0x6D9E50")]
	public class RenameAttribute : Attribute
	{
		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string target;

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0xF4756C", Offset = "0xF4756C", VA = "0xF4756C")]
		private RenameAttribute()
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0xF47574", Offset = "0xF47574", VA = "0xF47574")]
		public RenameAttribute(string target)
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0xF475A8", Offset = "0xF475A8", VA = "0xF475A8")]
		public string GetTarget()
		{
			return null;
		}
	}
	[Token(Token = "0x2000145")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6D9E64", Offset = "0x6D9E64")]
	public class ReplaceLiteralsWithNameAttribute : Attribute
	{
		[Token(Token = "0x6000A25")]
		[Address(RVA = "0xF475B0", Offset = "0xF475B0", VA = "0xF475B0")]
		public ReplaceLiteralsWithNameAttribute()
		{
		}
	}
	[Token(Token = "0x2000146")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6D9E78", Offset = "0x6D9E78")]
	public class SkipAttribute : Attribute
	{
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0xF48ED0", Offset = "0xF48ED0", VA = "0xF48ED0")]
		public SkipAttribute()
		{
		}
	}
	[Token(Token = "0x2000147")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6D9E8C", Offset = "0x6D9E8C")]
	public class SkipRenameAttribute : Attribute
	{
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0xF48ED8", Offset = "0xF48ED8", VA = "0xF48ED8")]
		public SkipRenameAttribute()
		{
		}
	}
	[Token(Token = "0x2000148")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x6D9EA0", Offset = "0x6D9EA0")]
	public class SuppressLogAttribute : Attribute
	{
		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly MessageCode _messageCode;

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x11EF650", Offset = "0x11EF650", VA = "0x11EF650")]
		private SuppressLogAttribute()
		{
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x11EF658", Offset = "0x11EF658", VA = "0x11EF658")]
		public SuppressLogAttribute(MessageCode messageCode)
		{
		}
	}
}
