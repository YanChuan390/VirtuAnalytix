using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using Virtence.VText;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class Loom : MonoBehaviour
{
	[Token(Token = "0x20000A1")]
	public struct DelayedQueueItem
	{
		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float time;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Action action;
	}

	[Serializable]
	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x893C20", Offset = "0x893C20")]
	private sealed class <>c
	{
		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<DelayedQueueItem, bool> <>9__21_0;

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x1171D90", Offset = "0x1171D90", VA = "0x1171D90")]
		public <>c()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x1171D98", Offset = "0x1171D98", VA = "0x1171D98")]
		internal bool <Update>b__21_0(DelayedQueueItem d)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int maxThreads;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int numThreads;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Loom _current;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int _count;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static bool initialized;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly List<Action> _actions;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly List<DelayedQueueItem> _delayed;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly List<DelayedQueueItem> _currentDelayed;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<Action> _currentActions;

	[Token(Token = "0x17000001")]
	public static Loom Current
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1170DF4", Offset = "0x1170DF4", VA = "0x1170DF4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1170D28", Offset = "0x1170D28", VA = "0x1170D28")]
		set
		{
		}
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1170F64", Offset = "0x1170F64", VA = "0x1170F64")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1170E60", Offset = "0x1170E60", VA = "0x1170E60")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1170FE8", Offset = "0x1170FE8", VA = "0x1170FE8")]
	public static void QueueOnMainThread(Action action)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1171050", Offset = "0x1171050", VA = "0x1171050")]
	public static void QueueOnMainThread(Action action, float time)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x11712F4", Offset = "0x11712F4", VA = "0x11712F4")]
	public static Thread RunAsync(Action a)
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1171404", Offset = "0x1171404", VA = "0x1171404")]
	private static void RunAction(object action)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x11715AC", Offset = "0x11715AC", VA = "0x11715AC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1171690", Offset = "0x1171690", VA = "0x1171690")]
	private void Start()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1171694", Offset = "0x1171694", VA = "0x1171694")]
	private void Update()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1171BCC", Offset = "0x1171BCC", VA = "0x1171BCC")]
	public Loom()
	{
	}
}
[Token(Token = "0x2000003")]
public class GenericEventArgs<T> : EventArgs, IGenericEventArgs<T>
{
	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private T _value;

	[Token(Token = "0x17000002")]
	public T Value
	{
		[Token(Token = "0x600000E")]
		get
		{
			return (T)null;
		}
	}

	[Token(Token = "0x600000F")]
	public GenericEventArgs(T value)
	{
	}
}
[Token(Token = "0x2000004")]
public interface IGenericEventArgs<T>
{
	[Token(Token = "0x17000003")]
	T Value
	{
		[Token(Token = "0x6000010")]
		get;
	}
}
[Serializable]
[Token(Token = "0x2000005")]
public class VTextParameter
{
	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float m_depth;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float m_bevel;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private bool m_needTangents;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	[SerializeField]
	private bool m_backface;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private float m_crease;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private int m_quality;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private string m_fontname;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private ShadowCastingMode m_shadowCastMode;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[SerializeField]
	private bool m_receiveShadows;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
	[SerializeField]
	private bool m_useLightProbes;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
	[HideInInspector]
	private bool m_modified;

	[Token(Token = "0x17000004")]
	public float Depth
	{
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x14227D4", Offset = "0x14227D4", VA = "0x14227D4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x14227DC", Offset = "0x14227DC", VA = "0x14227DC")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public float Crease
	{
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x14229F4", Offset = "0x14229F4", VA = "0x14229F4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x14229FC", Offset = "0x14229FC", VA = "0x14229FC")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public float Bevel
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1422AF0", Offset = "0x1422AF0", VA = "0x1422AF0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x14228E4", Offset = "0x14228E4", VA = "0x14228E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public int Quality
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1422AF8", Offset = "0x1422AF8", VA = "0x1422AF8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1422B00", Offset = "0x1422B00", VA = "0x1422B00")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public bool Backface
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1422BB0", Offset = "0x1422BB0", VA = "0x1422BB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1422BB8", Offset = "0x1422BB8", VA = "0x1422BB8")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public bool GenerateTangents
	{
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1422C74", Offset = "0x1422C74", VA = "0x1422C74")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1422C7C", Offset = "0x1422C7C", VA = "0x1422C7C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public string Fontname
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1422D38", Offset = "0x1422D38", VA = "0x1422D38")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1422D40", Offset = "0x1422D40", VA = "0x1422D40")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public ShadowCastingMode ShadowCastMode
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1422E0C", Offset = "0x1422E0C", VA = "0x1422E0C")]
		get
		{
			return default(ShadowCastingMode);
		}
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1422E14", Offset = "0x1422E14", VA = "0x1422E14")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public bool ReceiveShadows
	{
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1422EB8", Offset = "0x1422EB8", VA = "0x1422EB8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1422EC0", Offset = "0x1422EC0", VA = "0x1422EC0")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public bool UseLightProbes
	{
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1422F68", Offset = "0x1422F68", VA = "0x1422F68")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1422F70", Offset = "0x1422F70", VA = "0x1422F70")]
		set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event EventHandler<GenericEventArgs<float>> DepthChanged
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1421B04", Offset = "0x1421B04", VA = "0x1421B04")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C720", Offset = "0x89C720")]
		add
		{
		}
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1421BA8", Offset = "0x1421BA8", VA = "0x1421BA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C730", Offset = "0x89C730")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event EventHandler<GenericEventArgs<float>> BevelChanged
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1421C4C", Offset = "0x1421C4C", VA = "0x1421C4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C740", Offset = "0x89C740")]
		add
		{
		}
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1421CF0", Offset = "0x1421CF0", VA = "0x1421CF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C750", Offset = "0x89C750")]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event EventHandler<GenericEventArgs<bool>> NeedTangentsChanged
	{
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1421D94", Offset = "0x1421D94", VA = "0x1421D94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C760", Offset = "0x89C760")]
		add
		{
		}
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1421E38", Offset = "0x1421E38", VA = "0x1421E38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C770", Offset = "0x89C770")]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event EventHandler<GenericEventArgs<bool>> BackfaceChanged
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1421EDC", Offset = "0x1421EDC", VA = "0x1421EDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C780", Offset = "0x89C780")]
		add
		{
		}
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1421F80", Offset = "0x1421F80", VA = "0x1421F80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C790", Offset = "0x89C790")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event EventHandler<GenericEventArgs<float>> CreaseChanged
	{
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1422024", Offset = "0x1422024", VA = "0x1422024")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C7A0", Offset = "0x89C7A0")]
		add
		{
		}
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x14220C8", Offset = "0x14220C8", VA = "0x14220C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C7B0", Offset = "0x89C7B0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event EventHandler<GenericEventArgs<int>> QualityChanged
	{
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x142216C", Offset = "0x142216C", VA = "0x142216C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C7C0", Offset = "0x89C7C0")]
		add
		{
		}
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1422210", Offset = "0x1422210", VA = "0x1422210")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C7D0", Offset = "0x89C7D0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public event EventHandler<GenericEventArgs<string>> FontNameChanged
	{
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x14222B4", Offset = "0x14222B4", VA = "0x14222B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C7E0", Offset = "0x89C7E0")]
		add
		{
		}
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1422358", Offset = "0x1422358", VA = "0x1422358")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C7F0", Offset = "0x89C7F0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event EventHandler<GenericEventArgs<ShadowCastingMode>> ShadowCastingModeChanged
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x14223FC", Offset = "0x14223FC", VA = "0x14223FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C800", Offset = "0x89C800")]
		add
		{
		}
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x14224A0", Offset = "0x14224A0", VA = "0x14224A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C810", Offset = "0x89C810")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event EventHandler<GenericEventArgs<bool>> ReceiveShadowsChanged
	{
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1422544", Offset = "0x1422544", VA = "0x1422544")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C820", Offset = "0x89C820")]
		add
		{
		}
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x14225E8", Offset = "0x14225E8", VA = "0x14225E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C830", Offset = "0x89C830")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event EventHandler<GenericEventArgs<bool>> UseLightProbesChanged
	{
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x142268C", Offset = "0x142268C", VA = "0x142268C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C840", Offset = "0x89C840")]
		add
		{
		}
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1422730", Offset = "0x1422730", VA = "0x1422730")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C850", Offset = "0x89C850")]
		remove
		{
		}
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1420AD4", Offset = "0x1420AD4", VA = "0x1420AD4")]
	public bool CheckClearModified()
	{
		return default(bool);
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x141DE54", Offset = "0x141DE54", VA = "0x141DE54")]
	public VTextParameter()
	{
	}
}
[Serializable]
[Token(Token = "0x2000006")]
public class VTextLayout
{
	[Token(Token = "0x20000A3")]
	public enum align
	{
		[Token(Token = "0x4000543")]
		Base,
		[Token(Token = "0x4000544")]
		Start,
		[Token(Token = "0x4000545")]
		Center,
		[Token(Token = "0x4000546")]
		End,
		[Token(Token = "0x4000547")]
		Block
	}

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool m_horizontal;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private align m_major;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private align m_minor;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float m_size;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float m_spacing;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float m_glyphSpacing;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AnimationCurve m_curveXZ;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private AnimationCurve m_curveXY;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private bool m_orientXZ;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	[SerializeField]
	private bool m_orientXY;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
	[SerializeField]
	private bool m_isCircular;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private float m_startRadius;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float m_endRadius;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[SerializeField]
	private float m_circleRadius;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private bool m_animateRadius;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private AnimationCurve m_curveRadius;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	private bool m_modified;

	[Token(Token = "0x1700000E")]
	public bool Horizontal
	{
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x14214F8", Offset = "0x14214F8", VA = "0x14214F8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1421500", Offset = "0x1421500", VA = "0x1421500")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public align Major
	{
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x14215BC", Offset = "0x14215BC", VA = "0x14215BC")]
		get
		{
			return default(align);
		}
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x14215C4", Offset = "0x14215C4", VA = "0x14215C4")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public align Minor
	{
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1421680", Offset = "0x1421680", VA = "0x1421680")]
		get
		{
			return default(align);
		}
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1421688", Offset = "0x1421688", VA = "0x1421688")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public float Size
	{
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1421738", Offset = "0x1421738", VA = "0x1421738")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1421740", Offset = "0x1421740", VA = "0x1421740")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public float Spacing
	{
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x14217F8", Offset = "0x14217F8", VA = "0x14217F8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1421800", Offset = "0x1421800", VA = "0x1421800")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public float GlyphSpacing
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x14218B8", Offset = "0x14218B8", VA = "0x14218B8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x14218C0", Offset = "0x14218C0", VA = "0x14218C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public AnimationCurve CurveXZ
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1421978", Offset = "0x1421978", VA = "0x1421978")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1421980", Offset = "0x1421980", VA = "0x1421980")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public AnimationCurve CurveXY
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1421990", Offset = "0x1421990", VA = "0x1421990")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1421998", Offset = "0x1421998", VA = "0x1421998")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public bool OrientationXZ
	{
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x14219A8", Offset = "0x14219A8", VA = "0x14219A8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x14219B0", Offset = "0x14219B0", VA = "0x14219B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public bool OrientationXY
	{
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x14219D8", Offset = "0x14219D8", VA = "0x14219D8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x14219E0", Offset = "0x14219E0", VA = "0x14219E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public bool OrientationCircular
	{
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1421A08", Offset = "0x1421A08", VA = "0x1421A08")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1421A10", Offset = "0x1421A10", VA = "0x1421A10")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public float StartRadius
	{
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1421A38", Offset = "0x1421A38", VA = "0x1421A38")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1421A40", Offset = "0x1421A40", VA = "0x1421A40")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public float EndRadius
	{
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1421A5C", Offset = "0x1421A5C", VA = "0x1421A5C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1421A64", Offset = "0x1421A64", VA = "0x1421A64")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public float CircleRadius
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1421A80", Offset = "0x1421A80", VA = "0x1421A80")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1421A88", Offset = "0x1421A88", VA = "0x1421A88")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public bool AnimateRadius
	{
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1421AA4", Offset = "0x1421AA4", VA = "0x1421AA4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1421AAC", Offset = "0x1421AAC", VA = "0x1421AAC")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public AnimationCurve CurveRadius
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1421AD4", Offset = "0x1421AD4", VA = "0x1421AD4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1421ADC", Offset = "0x1421ADC", VA = "0x1421ADC")]
		set
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event EventHandler<GenericEventArgs<bool>> IsHorizontalLayoutChanged
	{
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1420D48", Offset = "0x1420D48", VA = "0x1420D48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C860", Offset = "0x89C860")]
		add
		{
		}
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1420DEC", Offset = "0x1420DEC", VA = "0x1420DEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C870", Offset = "0x89C870")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000C")]
	public event EventHandler<GenericEventArgs<float>> SizeChanged
	{
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1420E90", Offset = "0x1420E90", VA = "0x1420E90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C880", Offset = "0x89C880")]
		add
		{
		}
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1420F34", Offset = "0x1420F34", VA = "0x1420F34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C890", Offset = "0x89C890")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event EventHandler<GenericEventArgs<align>> MajorChanged
	{
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1420FD8", Offset = "0x1420FD8", VA = "0x1420FD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C8A0", Offset = "0x89C8A0")]
		add
		{
		}
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x142107C", Offset = "0x142107C", VA = "0x142107C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C8B0", Offset = "0x89C8B0")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public event EventHandler<GenericEventArgs<align>> MinorChanged
	{
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1421120", Offset = "0x1421120", VA = "0x1421120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C8C0", Offset = "0x89C8C0")]
		add
		{
		}
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x14211C4", Offset = "0x14211C4", VA = "0x14211C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C8D0", Offset = "0x89C8D0")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000F")]
	public event EventHandler<GenericEventArgs<float>> LineSpacingChanged
	{
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1421268", Offset = "0x1421268", VA = "0x1421268")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C8E0", Offset = "0x89C8E0")]
		add
		{
		}
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x142130C", Offset = "0x142130C", VA = "0x142130C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C8F0", Offset = "0x89C8F0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000010")]
	public event EventHandler<GenericEventArgs<float>> GlyphSpacingChanged
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x14213B0", Offset = "0x14213B0", VA = "0x14213B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C900", Offset = "0x89C900")]
		add
		{
		}
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1421454", Offset = "0x1421454", VA = "0x1421454")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89C910", Offset = "0x89C910")]
		remove
		{
		}
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x141DED4", Offset = "0x141DED4", VA = "0x141DED4")]
	public VTextLayout()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x141E634", Offset = "0x141E634", VA = "0x141E634")]
	public bool CheckClearModified()
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x2000007")]
public class VTextPhysics
{
	[Token(Token = "0x20000A4")]
	public enum ColliderType
	{
		[Token(Token = "0x4000549")]
		None,
		[Token(Token = "0x400054A")]
		Box,
		[Token(Token = "0x400054B")]
		Mesh
	}

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[HideInInspector]
	private bool _modified;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[SerializeField]
	private ColliderType _colliderType;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private PhysicMaterial _colliderMaterial;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _colliderIsTrigger;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	[SerializeField]
	private bool _colliderIsConvex;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	[SerializeField]
	private bool _createRigidBody;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _rigidbodyMass;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _rigidbodyDrag;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _rigidbodyAngularDrag;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool _rigidbodyUseGravity;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	[SerializeField]
	private bool _rigidbodyIsKinematic;

	[Token(Token = "0x1700001E")]
	public ColliderType Collider
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1423018", Offset = "0x1423018", VA = "0x1423018")]
		get
		{
			return default(ColliderType);
		}
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1423020", Offset = "0x1423020", VA = "0x1423020")]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public bool ColliderIsTrigger
	{
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x142303C", Offset = "0x142303C", VA = "0x142303C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1423044", Offset = "0x1423044", VA = "0x1423044")]
		set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public bool ColliderIsConvex
	{
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x142306C", Offset = "0x142306C", VA = "0x142306C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1423074", Offset = "0x1423074", VA = "0x1423074")]
		set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public PhysicMaterial ColliderMaterial
	{
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x142309C", Offset = "0x142309C", VA = "0x142309C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x14230A4", Offset = "0x14230A4", VA = "0x14230A4")]
		set
		{
		}
	}

	[Token(Token = "0x17000022")]
	public bool CreateRigidBody
	{
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1423140", Offset = "0x1423140", VA = "0x1423140")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1423148", Offset = "0x1423148", VA = "0x1423148")]
		set
		{
		}
	}

	[Token(Token = "0x17000023")]
	public float RigidbodyMass
	{
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1423170", Offset = "0x1423170", VA = "0x1423170")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1423178", Offset = "0x1423178", VA = "0x1423178")]
		set
		{
		}
	}

	[Token(Token = "0x17000024")]
	public float RigidbodyDrag
	{
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1423194", Offset = "0x1423194", VA = "0x1423194")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x142319C", Offset = "0x142319C", VA = "0x142319C")]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public float RigidbodyAngularDrag
	{
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x14231B8", Offset = "0x14231B8", VA = "0x14231B8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x14231C0", Offset = "0x14231C0", VA = "0x14231C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public bool RigidbodyUseGravity
	{
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x14231DC", Offset = "0x14231DC", VA = "0x14231DC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x14231E4", Offset = "0x14231E4", VA = "0x14231E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000027")]
	public bool RigidbodyIsKinematic
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x142320C", Offset = "0x142320C", VA = "0x142320C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1423214", Offset = "0x1423214", VA = "0x1423214")]
		set
		{
		}
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x141E650", Offset = "0x141E650", VA = "0x141E650")]
	public bool CheckClearModified()
	{
		return default(bool);
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x141E1F0", Offset = "0x141E1F0", VA = "0x141E1F0")]
	public VTextPhysics()
	{
	}
}
[Serializable]
[Token(Token = "0x2000008")]
public class VTextAdditionalComponents
{
	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[HideInInspector]
	private bool _modified;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _additionalComponentsObject;

	[Token(Token = "0x17000028")]
	public GameObject AdditionalComponentsObject
	{
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x141DA34", Offset = "0x141DA34", VA = "0x141DA34")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x141DA3C", Offset = "0x141DA3C", VA = "0x141DA3C")]
		set
		{
		}
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x141DAD8", Offset = "0x141DAD8", VA = "0x141DAD8")]
	public bool CheckClearModified()
	{
		return default(bool);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x141DAF4", Offset = "0x141DAF4", VA = "0x141DAF4")]
	public VTextAdditionalComponents()
	{
	}
}
[Token(Token = "0x2000009")]
[ExecuteInEditMode]
public class VTextInterface : MonoBehaviour
{
	[Token(Token = "0x20000A5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x893C30", Offset = "0x893C30")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Component c;

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x141FF20", Offset = "0x141FF20", VA = "0x141FF20")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x1420CB8", Offset = "0x1420CB8", VA = "0x1420CB8")]
		internal bool <UpdateAdditionalComponents>b__0(Type type)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x893C40", Offset = "0x893C40")]
	private sealed class <>c__DisplayClass25_1
	{
		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Component c;

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x141FF28", Offset = "0x141FF28", VA = "0x141FF28")]
		public <>c__DisplayClass25_1()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x1420D00", Offset = "0x1420D00", VA = "0x1420D00")]
		internal bool <UpdateAdditionalComponents>b__1(Type type)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public VTextParameter parameter;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public VTextLayout layout;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public VTextPhysics Physics;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public VTextAdditionalComponents AdditionalComponents;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public string RenderText;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string m_oldText;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material[] materials;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material[] usedMaterials;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static VFontInfo m_fontInfo;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<MonoBehaviour> m_changeListener;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<Type> _componentsToKeep;

	[Token(Token = "0x17000029")]
	private VFontInfo FontInfo
	{
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x141DAFC", Offset = "0x141DAFC", VA = "0x141DAFC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x141DB64", Offset = "0x141DB64", VA = "0x141DB64")]
		set
		{
		}
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x141DBD4", Offset = "0x141DBD4", VA = "0x141DBD4")]
	public VTextInterface()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x141E20C", Offset = "0x141E20C", VA = "0x141E20C", Slot = "1")]
	~VTextInterface()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x141E3A0", Offset = "0x141E3A0", VA = "0x141E3A0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x141E66C", Offset = "0x141E66C", VA = "0x141E66C")]
	public static List<string> GetAvailableFonts()
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x141E87C", Offset = "0x141E87C", VA = "0x141E87C")]
	public bool Is3D()
	{
		return default(bool);
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x141E8B4", Offset = "0x141E8B4", VA = "0x141E8B4")]
	public void RegisterListener(MonoBehaviour go)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x141E958", Offset = "0x141E958", VA = "0x141E958")]
	public void UnRegisterListener(MonoBehaviour go)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x141E9F0", Offset = "0x141E9F0", VA = "0x141E9F0")]
	private void clearChildren()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x141EB84", Offset = "0x141EB84", VA = "0x141EB84")]
	private void UpdateGlyphs(bool updateGeometry = false)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x141F6C4", Offset = "0x141F6C4", VA = "0x141F6C4")]
	private void UpdateLayout()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x141F864", Offset = "0x141F864", VA = "0x141F864")]
	private void UpdatePhysics()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x141FBEC", Offset = "0x141FBEC", VA = "0x141FBEC")]
	private void UpdateAdditionalComponents()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x141F8F8", Offset = "0x141F8F8", VA = "0x141F8F8")]
	private void CreateRigidbody(Transform t)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x141FA74", Offset = "0x141FA74", VA = "0x141FA74")]
	private void CreateCollider(Transform t)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x14201AC", Offset = "0x14201AC", VA = "0x14201AC")]
	private void RemoveCollider(Transform t)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x142029C", Offset = "0x142029C", VA = "0x142029C")]
	public void Rebuild(bool rebuildMesh = false)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1420450", Offset = "0x1420450", VA = "0x1420450")]
	public static void FinishRebuild()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1420508", Offset = "0x1420508", VA = "0x1420508")]
	public Bounds GetBounds()
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1420984", Offset = "0x1420984", VA = "0x1420984")]
	public void CheckRebuild(bool updateMesh, bool updateLayout, bool updatePhysics, bool updateAdditionalComponents)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1420AF0", Offset = "0x1420AF0", VA = "0x1420AF0")]
	private void Update()
	{
	}
}
namespace XftWeapon
{
	[Token(Token = "0x200000A")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x892EB0", Offset = "0x892EB0")]
	public class Spline
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<SplineControlPoint> mControlPoints;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<SplineControlPoint> mSegments;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int Granularity;

		[Token(Token = "0x1700002A")]
		public SplineControlPoint Item
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x1428C38", Offset = "0x1428C38", VA = "0x1428C38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public List<SplineControlPoint> Segments
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x1428CC0", Offset = "0x1428CC0", VA = "0x1428CC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public List<SplineControlPoint> ControlPoints
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x1428CC8", Offset = "0x1428CC8", VA = "0x1428CC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1428CD0", Offset = "0x1428CD0", VA = "0x1428CD0")]
		public SplineControlPoint NextControlPoint(SplineControlPoint controlpoint)
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1428D68", Offset = "0x1428D68", VA = "0x1428D68")]
		public SplineControlPoint PreviousControlPoint(SplineControlPoint controlpoint)
		{
			return null;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1428DFC", Offset = "0x1428DFC", VA = "0x1428DFC")]
		public Vector3 NextPosition(SplineControlPoint controlpoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1428E34", Offset = "0x1428E34", VA = "0x1428E34")]
		public Vector3 PreviousPosition(SplineControlPoint controlpoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1428E6C", Offset = "0x1428E6C", VA = "0x1428E6C")]
		public Vector3 PreviousNormal(SplineControlPoint controlpoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1428EA4", Offset = "0x1428EA4", VA = "0x1428EA4")]
		public Vector3 NextNormal(SplineControlPoint controlpoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1428EDC", Offset = "0x1428EDC", VA = "0x1428EDC")]
		public SplineControlPoint LenToSegment(float t, out float localF)
		{
			return null;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1429088", Offset = "0x1429088", VA = "0x1429088")]
		public static Vector3 CatmulRom(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1429210", Offset = "0x1429210", VA = "0x1429210")]
		public Vector3 InterpolateByLen(float tl)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1429340", Offset = "0x1429340", VA = "0x1429340")]
		public Vector3 InterpolateNormalByLen(float tl)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1429470", Offset = "0x1429470", VA = "0x1429470")]
		public SplineControlPoint AddControlPoint(Vector3 pos, Vector3 up)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x14295B0", Offset = "0x14295B0", VA = "0x14295B0")]
		public void Clear()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1429608", Offset = "0x1429608", VA = "0x1429608")]
		private void RefreshDistance()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1429800", Offset = "0x1429800", VA = "0x1429800")]
		public void RefreshSpline()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1429954", Offset = "0x1429954", VA = "0x1429954")]
		public Spline()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class SplineControlPoint
	{
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 Normal;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int ControlPointIndex;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int SegmentIndex;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Dist;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Spline mSpline;

		[Token(Token = "0x1700002D")]
		public SplineControlPoint NextControlPoint
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x1429A04", Offset = "0x1429A04", VA = "0x1429A04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public SplineControlPoint PreviousControlPoint
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x1429A20", Offset = "0x1429A20", VA = "0x1429A20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public Vector3 NextPosition
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x1429A3C", Offset = "0x1429A3C", VA = "0x1429A3C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000030")]
		public Vector3 PreviousPosition
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x1429A58", Offset = "0x1429A58", VA = "0x1429A58")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000031")]
		public Vector3 NextNormal
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x1429A74", Offset = "0x1429A74", VA = "0x1429A74")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000032")]
		public Vector3 PreviousNormal
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x1429A90", Offset = "0x1429A90", VA = "0x1429A90")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000033")]
		public bool IsValid
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x1429938", Offset = "0x1429938", VA = "0x1429938")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1429AAC", Offset = "0x1429AAC", VA = "0x1429AAC")]
		private Vector3 GetNext2Position()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1429AD4", Offset = "0x1429AD4", VA = "0x1429AD4")]
		private Vector3 GetNext2Normal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1429244", Offset = "0x1429244", VA = "0x1429244")]
		public Vector3 Interpolate(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1429374", Offset = "0x1429374", VA = "0x1429374")]
		public Vector3 InterpolateNormal(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1429580", Offset = "0x1429580", VA = "0x1429580")]
		public void Init(Spline owner)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1429570", Offset = "0x1429570", VA = "0x1429570")]
		public SplineControlPoint()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class VertexPool
	{
		[Token(Token = "0x20000A7")]
		public class VertexSegment
		{
			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int VertStart;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int IndexStart;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int VertCount;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int IndexCount;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexPool Pool;

			[Token(Token = "0x6000745")]
			[Address(RVA = "0x142A5F0", Offset = "0x142A5F0", VA = "0x142A5F0")]
			public VertexSegment(int start, int count, int istart, int icount, VertexPool pool)
			{
			}

			[Token(Token = "0x6000746")]
			[Address(RVA = "0x142A864", Offset = "0x142A864", VA = "0x142A864")]
			public void ClearIndices()
			{
			}
		}

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3[] Vertices;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] Indices;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2[] UVs;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color[] Colors;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IndiceChanged;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool ColorChanged;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool UVChanged;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool VertChanged;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool UV2Changed;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected int VertexTotal;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected int VertexUsed;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected int IndexTotal;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected int IndexUsed;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool FirstUpdate;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		protected bool VertCountChanged;

		[Token(Token = "0x4000067")]
		public const int BlockSize = 108;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float BoundsScheduleTime;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float ElapsedTime;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected XWeaponTrail _owner;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected MeshFilter _meshFilter;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected Mesh _mesh2d;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected Material _material;

		[Token(Token = "0x17000034")]
		public Mesh MyMesh
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x1429B08", Offset = "0x1429B08", VA = "0x1429B08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1429C10", Offset = "0x1429C10", VA = "0x1429C10")]
		public void RecalculateBounds()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1429C30", Offset = "0x1429C30", VA = "0x1429C30")]
		public void SetMeshObjectActive(bool flag)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1429CE4", Offset = "0x1429CE4", VA = "0x1429CE4")]
		private void CreateMeshObj(XWeaponTrail owner, Material material)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x142A014", Offset = "0x142A014", VA = "0x142A014")]
		public void Destroy()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x142A12C", Offset = "0x142A12C", VA = "0x142A12C")]
		public VertexPool(Material material, XWeaponTrail owner)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x142A310", Offset = "0x142A310", VA = "0x142A310")]
		public VertexSegment GetVertices(int vcount, int icount)
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x142A228", Offset = "0x142A228", VA = "0x142A228")]
		protected void InitArrays()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x142A460", Offset = "0x142A460", VA = "0x142A460")]
		public void EnlargeArrays(int count, int icount)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x142A64C", Offset = "0x142A64C", VA = "0x142A64C")]
		public void LateUpdate()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class XWeaponTrail : MonoBehaviour
	{
		[Token(Token = "0x20000A8")]
		public class Element
		{
			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 PointStart;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 PointEnd;

			[Token(Token = "0x170000CD")]
			public Vector3 Pos
			{
				[Token(Token = "0x6000747")]
				[Address(RVA = "0x142B290", Offset = "0x142B290", VA = "0x142B290")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000748")]
			[Address(RVA = "0x142C228", Offset = "0x142C228", VA = "0x142C228")]
			public Element(Vector3 start, Vector3 end)
			{
			}

			[Token(Token = "0x6000749")]
			[Address(RVA = "0x142C388", Offset = "0x142C388", VA = "0x142C388")]
			public Element()
			{
			}
		}

		[Token(Token = "0x20000A9")]
		public class ElementPool
		{
			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Stack<Element> _stack;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x898F68", Offset = "0x898F68")]
			private int <CountAll>k__BackingField;

			[Token(Token = "0x170000CE")]
			public int CountAll
			{
				[Token(Token = "0x600074A")]
				[Address(RVA = "0x142C3EC", Offset = "0x142C3EC", VA = "0x142C3EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F188", Offset = "0x89F188")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600074B")]
				[Address(RVA = "0x142C3F4", Offset = "0x142C3F4", VA = "0x142C3F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F198", Offset = "0x89F198")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CF")]
			public int CountActive
			{
				[Token(Token = "0x600074C")]
				[Address(RVA = "0x142C3FC", Offset = "0x142C3FC", VA = "0x142C3FC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x170000D0")]
			public int CountInactive
			{
				[Token(Token = "0x600074D")]
				[Address(RVA = "0x142C420", Offset = "0x142C420", VA = "0x142C420")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x600074E")]
			[Address(RVA = "0x142AB40", Offset = "0x142AB40", VA = "0x142AB40")]
			public ElementPool(int preCount)
			{
			}

			[Token(Token = "0x600074F")]
			[Address(RVA = "0x142C0C8", Offset = "0x142C0C8", VA = "0x142C0C8")]
			public Element Get()
			{
				return null;
			}

			[Token(Token = "0x6000750")]
			[Address(RVA = "0x142C160", Offset = "0x142C160", VA = "0x142C160")]
			public void Release(Element element)
			{
			}
		}

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Version;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UseWith2D;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string SortingLayerName;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int SortingOrder;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform PointStart;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform PointEnd;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int MaxFrame;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int Granularity;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float Fps;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Color MyColor;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Material MyMaterial;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected float mTrailWidth;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected Element mHeadElem;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected List<Element> mSnapshotList;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected ElementPool mElemPool;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected Spline mSpline;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected float mFadeT;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		protected bool mIsFading;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected float mFadeTime;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		protected float mElapsedTime;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected float mFadeElapsedime;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected GameObject mMeshObj;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected VertexPool mVertexPool;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected VertexPool.VertexSegment mVertexSegment;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected bool mInited;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		protected bool mActivated;

		[Token(Token = "0x17000035")]
		public float UpdateInterval
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x142A8F0", Offset = "0x142A8F0", VA = "0x142A8F0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000036")]
		public Vector3 CurHeadPos
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x142A900", Offset = "0x142A900", VA = "0x142A900")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000037")]
		public float TrailWidth
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x142A9DC", Offset = "0x142A9DC", VA = "0x142A9DC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x142A9E4", Offset = "0x142A9E4", VA = "0x142A9E4")]
		public void Init()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x142AFCC", Offset = "0x142AFCC", VA = "0x142AFCC")]
		public void Activate()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x142B8F8", Offset = "0x142B8F8", VA = "0x142B8F8")]
		public void Deactivate()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x142B934", Offset = "0x142B934", VA = "0x142B934")]
		public void StopSmoothly(float fadeTime)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x142B944", Offset = "0x142B944", VA = "0x142B944")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x142B948", Offset = "0x142B948", VA = "0x142B948")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x142B94C", Offset = "0x142B94C", VA = "0x142B94C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x142BC24", Offset = "0x142BC24", VA = "0x142BC24")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x142BC48", Offset = "0x142BC48", VA = "0x142BC48")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x142BC60", Offset = "0x142BC60", VA = "0x142BC60")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x142BC68", Offset = "0x142BC68", VA = "0x142BC68")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x142AE64", Offset = "0x142AE64", VA = "0x142AE64")]
		private void InitSpline()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x142B33C", Offset = "0x142B33C", VA = "0x142B33C")]
		private void RefreshSpline()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x142B544", Offset = "0x142B544", VA = "0x142B544")]
		private void UpdateVertex()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x142BE6C", Offset = "0x142BE6C", VA = "0x142BE6C")]
		private void UpdateIndices()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x142B9C8", Offset = "0x142B9C8", VA = "0x142B9C8")]
		private void UpdateHeadElem()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x142BBB4", Offset = "0x142BBB4", VA = "0x142BBB4")]
		private void UpdateFade()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x142BA84", Offset = "0x142BA84", VA = "0x142BA84")]
		private void RecordCurElem()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x142ACF4", Offset = "0x142ACF4", VA = "0x142ACF4")]
		private void InitOriginalElements()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x142AC40", Offset = "0x142AC40", VA = "0x142AC40")]
		private void InitMeshObj()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x142C288", Offset = "0x142C288", VA = "0x142C288")]
		public XWeaponTrail()
		{
		}
	}
}
namespace System
{
	[Token(Token = "0x200000E")]
	public static class ObjectExtensions
	{
		[Token(Token = "0x20000AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x893C50", Offset = "0x893C50")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IDictionary<object, object> visited;

			[Token(Token = "0x6000751")]
			[Address(RVA = "0x141D450", Offset = "0x141D450", VA = "0x141D450")]
			public <>c__DisplayClass3_0()
			{
			}
		}

		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x893C60", Offset = "0x893C60")]
		private sealed class <>c__DisplayClass3_1
		{
			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Array clonedArray;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass3_0 CS$<>8__locals1;

			[Token(Token = "0x6000752")]
			[Address(RVA = "0x141D458", Offset = "0x141D458", VA = "0x141D458")]
			public <>c__DisplayClass3_1()
			{
			}

			[Token(Token = "0x6000753")]
			[Address(RVA = "0x141D950", Offset = "0x141D950", VA = "0x141D950")]
			internal void <InternalCopy>b__0(Array array, int[] indices)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x893C70", Offset = "0x893C70")]
		private sealed class <>c
		{
			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<FieldInfo, bool> <>9__4_0;

			[Token(Token = "0x6000755")]
			[Address(RVA = "0x141D92C", Offset = "0x141D92C", VA = "0x141D92C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000756")]
			[Address(RVA = "0x141D934", Offset = "0x141D934", VA = "0x141D934")]
			internal bool <RecursiveCopyBaseTypePrivateFields>b__4_0(FieldInfo info)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly MethodInfo CloneMethod;

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x141CE30", Offset = "0x141CE30", VA = "0x141CE30")]
		public static bool IsPrimitive(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x141CEF0", Offset = "0x141CEF0", VA = "0x141CEF0")]
		public static object Copy(this object originalObject)
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x141CFF0", Offset = "0x141CFF0", VA = "0x141CFF0")]
		private static object InternalCopy(object originalObject, IDictionary<object, object> visited)
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x141D608", Offset = "0x141D608", VA = "0x141D608")]
		private static void RecursiveCopyBaseTypePrivateFields(object originalObject, IDictionary<object, object> visited, object cloneObject, Type typeToReflect)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x141D460", Offset = "0x141D460", VA = "0x141D460")]
		private static void CopyFields(object originalObject, IDictionary<object, object> visited, object cloneObject, Type typeToReflect, BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy, [Optional] Func<FieldInfo, bool> filter)
		{
		}

		[Token(Token = "0x60000E1")]
		public static T Copy<T>(this T original)
		{
			return (T)null;
		}
	}
	[Token(Token = "0x200000F")]
	public class ReferenceEqualityComparer : EqualityComparer<object>
	{
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x141DA08", Offset = "0x141DA08", VA = "0x141DA08", Slot = "8")]
		public override bool Equals(object x, object y)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x141DA14", Offset = "0x141DA14", VA = "0x141DA14", Slot = "9")]
		public override int GetHashCode(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x141CFA0", Offset = "0x141CFA0", VA = "0x141CFA0")]
		public ReferenceEqualityComparer()
		{
		}
	}
}
namespace System.ArrayExtensions
{
	[Token(Token = "0x2000010")]
	public static class ArrayExtensions
	{
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x141CB88", Offset = "0x141CB88", VA = "0x141CB88")]
		public static void ForEach(this Array array, Action<Array, int[]> action)
		{
		}
	}
	[Token(Token = "0x2000011")]
	internal class ArrayTraverse
	{
		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int[] Position;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int[] maxLengths;

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x141CC38", Offset = "0x141CC38", VA = "0x141CC38")]
		public ArrayTraverse(Array array)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x141CD6C", Offset = "0x141CD6C", VA = "0x141CD6C")]
		public bool Step()
		{
			return default(bool);
		}
	}
}
namespace Virtence.VText
{
	[Token(Token = "0x2000012")]
	public class VFontHash
	{
		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static Hashtable fonts;

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x142323C", Offset = "0x142323C", VA = "0x142323C")]
		static VFontHash()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x141F2DC", Offset = "0x141F2DC", VA = "0x141F2DC")]
		public static VFontInfo GetFontInfo(string fontname)
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x14232A8", Offset = "0x14232A8", VA = "0x14232A8")]
		public VFontHash()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public struct FontBounds
	{
		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float minX;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float maxX;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float minY;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float maxY;
	}
	[Token(Token = "0x2000014")]
	public class VFontInfo
	{
		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Hashtable m_glyphs;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr m_fontHandle;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FontBounds m_bounds;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected string m_fontName;

		[Token(Token = "0x17000038")]
		public float glyphMinX
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x14232B0", Offset = "0x14232B0", VA = "0x14232B0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000039")]
		public float glyphMaxX
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x14232B8", Offset = "0x14232B8", VA = "0x14232B8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003A")]
		public float glyphMinY
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x14232C0", Offset = "0x14232C0", VA = "0x14232C0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003B")]
		public float glyphMaxY
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x14232C8", Offset = "0x14232C8", VA = "0x14232C8")]
			get
			{
				return default(float);
			}
		}

		[PreserveSig]
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x14232D0", Offset = "0x14232D0", VA = "0x14232D0")]
		private static extern IntPtr OpenFont([In] IntPtr fontFilename);

		[PreserveSig]
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x142334C", Offset = "0x142334C", VA = "0x142334C")]
		private static extern void CloseFont([In] IntPtr fontHandle);

		[PreserveSig]
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x14233CC", Offset = "0x14233CC", VA = "0x14233CC")]
		private static extern float GetAscender([In] IntPtr fontHandle);

		[PreserveSig]
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x142344C", Offset = "0x142344C", VA = "0x142344C")]
		private static extern float GetDescender([In] IntPtr fontHandle);

		[PreserveSig]
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x14234CC", Offset = "0x14234CC", VA = "0x14234CC")]
		private static extern bool GetFontBounds([Out] IntPtr b, [In] IntPtr fontHandle);

		[PreserveSig]
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1423564", Offset = "0x1423564", VA = "0x1423564")]
		private static extern bool GetKerning2(ref float kx, ref float ky, [In] IntPtr fontHandle, uint first, uint second);

		[PreserveSig]
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x142361C", Offset = "0x142361C", VA = "0x142361C")]
		private static extern void SetQuality([In] IntPtr fontHandle, int percent);

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x14236AC", Offset = "0x14236AC", VA = "0x14236AC")]
		private void SafeOpenFont(string fn)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x141EF14", Offset = "0x141EF14", VA = "0x141EF14")]
		public VFontInfo(string fontname)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x14238F0", Offset = "0x14238F0", VA = "0x14238F0", Slot = "1")]
		~VFontInfo()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x141E334", Offset = "0x141E334", VA = "0x141E334")]
		public void Shutdown()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x141F25C", Offset = "0x141F25C", VA = "0x141F25C")]
		public void SetQuality(int percent)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1423958", Offset = "0x1423958", VA = "0x1423958")]
		protected VGlyphInfo FetchGlyphInfo(Hashtable glyphs, char c)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1423D58", Offset = "0x1423D58", VA = "0x1423D58")]
		protected Vector2 Kerning(char a, char b)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1423E08", Offset = "0x1423E08", VA = "0x1423E08")]
		public Vector2 LineSize(VTextInterface vtext, string str)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1420670", Offset = "0x1420670", VA = "0x1420670")]
		public Bounds GetBounds(VTextInterface vtext, string str)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x141F85C", Offset = "0x141F85C", VA = "0x141F85C")]
		public void LayoutText3D(VTextInterface vtext, string str)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x141F2D4", Offset = "0x141F2D4", VA = "0x141F2D4")]
		public void CreateText3D(VTextInterface vtext, string str)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1424018", Offset = "0x1424018", VA = "0x1424018")]
		protected void CreateText(VTextInterface vtext, string str, bool layoutOnly)
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class VGlyphInfo
	{
		[Token(Token = "0x20000AD")]
		public struct GlyphInfo
		{
			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float sizeX;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float sizeY;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float advanceX;

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float advanceY;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float horizBearingX;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float horizBearingY;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float vertBearingX;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float vertBearingY;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int numContours;
		}

		[Token(Token = "0x20000AE")]
		protected class BaseAttributes
		{
			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 _v;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 _bv;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 _n;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector2 _uv;

			[Token(Token = "0x6000757")]
			[Address(RVA = "0x1428B10", Offset = "0x1428B10", VA = "0x1428B10")]
			public BaseAttributes(Vector3 v, Vector3 bv, Vector3 n, float dist)
			{
			}
		}

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 size;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 advance;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 horizontalBearing;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 verticalBearing;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected char _id;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Mesh _mesh;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IntPtr _fh;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _numContours;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3[][] _contours;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected int[] sideIndices;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected int[] bevelIndices;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected Vector3 zVector;

		[PreserveSig]
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x142630C", Offset = "0x142630C", VA = "0x142630C")]
		private static extern bool GetGlyphInfo([Out] IntPtr gi, [In] IntPtr fontHandle, [In] uint id);

		[PreserveSig]
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x14263AC", Offset = "0x14263AC", VA = "0x14263AC")]
		private static extern int GetGlyphVertices(ref IntPtr buffer, [In] IntPtr fontHandle, [In] uint id);

		[PreserveSig]
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1426444", Offset = "0x1426444", VA = "0x1426444")]
		private static extern int GetGlyphTriangleIndices(ref IntPtr buffer, [In] IntPtr fontHandle, [In] uint id);

		[PreserveSig]
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x14264DC", Offset = "0x14264DC", VA = "0x14264DC")]
		private static extern void ClearGlyphData([In] IntPtr fontHandle, [In] uint id);

		[PreserveSig]
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x142656C", Offset = "0x142656C", VA = "0x142656C")]
		private static extern int GetGlyphContour(ref IntPtr buffer, [In] IntPtr fontHandle, [In] uint id, [In] int index, ref bool odd, ref bool reverse);

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x142665C", Offset = "0x142665C", VA = "0x142665C")]
		private VGlyphInfo()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x14266BC", Offset = "0x14266BC", VA = "0x14266BC", Slot = "1")]
		~VGlyphInfo()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1423AE4", Offset = "0x1423AE4", VA = "0x1423AE4")]
		public VGlyphInfo(IntPtr fontHandle, char id)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x142672C", Offset = "0x142672C", VA = "0x142672C")]
		protected bool fetchNext(ref Vector3 v, Vector3[] contour, int startIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x142687C", Offset = "0x142687C", VA = "0x142687C")]
		protected void CreateSides(VTextParameter p)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1425664", Offset = "0x1425664", VA = "0x1425664")]
		public Mesh GetMesh(Vector2 shift, Vector2 size, VTextInterface vtext, float ascender)
		{
			return null;
		}
	}
}
namespace Virtence.VText.Extensions
{
	[Token(Token = "0x2000016")]
	public static class ComponentExtensions
	{
		[Token(Token = "0x600010E")]
		public static T GetCopyOf<T>(this Component comp, T other) where T : Component
		{
			return null;
		}
	}
	[Token(Token = "0x2000017")]
	public static class GameObjectExtensions
	{
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x141FF30", Offset = "0x141FF30", VA = "0x141FF30")]
		public static Component AddComponentClone(this GameObject go, Component toAdd)
		{
			return null;
		}
	}
}
namespace RootMotion
{
	[Serializable]
	[Token(Token = "0x2000018")]
	public enum Axis
	{
		[Token(Token = "0x40000A1")]
		X,
		[Token(Token = "0x40000A2")]
		Y,
		[Token(Token = "0x40000A3")]
		Z
	}
	[Token(Token = "0x2000019")]
	public class AxisTools
	{
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1171DC4", Offset = "0x1171DC4", VA = "0x1171DC4")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1171E7C", Offset = "0x1171E7C", VA = "0x1171E7C")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1171F28", Offset = "0x1171F28", VA = "0x1171F28")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x117210C", Offset = "0x117210C", VA = "0x117210C")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1172044", Offset = "0x1172044", VA = "0x1172044")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1172228", Offset = "0x1172228", VA = "0x1172228")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1172454", Offset = "0x1172454", VA = "0x1172454")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001A")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x20000AF")]
		public class LimbOrientation
		{
			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000758")]
			[Address(RVA = "0x1172754", Offset = "0x1172754", VA = "0x1172754")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x1700003C")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x11724DC", Offset = "0x11724DC", VA = "0x11724DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x11727CC", Offset = "0x11727CC", VA = "0x11727CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x117245C", Offset = "0x117245C", VA = "0x117245C")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x200001B")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x20000B0")]
		public enum BoneType
		{
			[Token(Token = "0x400056D")]
			Unassigned,
			[Token(Token = "0x400056E")]
			Spine,
			[Token(Token = "0x400056F")]
			Head,
			[Token(Token = "0x4000570")]
			Arm,
			[Token(Token = "0x4000571")]
			Leg,
			[Token(Token = "0x4000572")]
			Tail,
			[Token(Token = "0x4000573")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x20000B1")]
		public enum BoneSide
		{
			[Token(Token = "0x4000575")]
			Center,
			[Token(Token = "0x4000576")]
			Left,
			[Token(Token = "0x4000577")]
			Right
		}

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1172A44", Offset = "0x1172A44", VA = "0x1172A44")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1172D4C", Offset = "0x1172D4C", VA = "0x1172D4C")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1172FA4", Offset = "0x1172FA4", VA = "0x1172FA4")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1173028", Offset = "0x1173028", VA = "0x1173028")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x11730D4", Offset = "0x11730D4", VA = "0x11730D4")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1172BFC", Offset = "0x1172BFC", VA = "0x1172BFC")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1172F04", Offset = "0x1172F04", VA = "0x1172F04")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1173914", Offset = "0x1173914", VA = "0x1173914")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x117372C", Offset = "0x117372C", VA = "0x117372C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1173820", Offset = "0x1173820", VA = "0x1173820")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x11732F4", Offset = "0x11732F4", VA = "0x11732F4")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x11733A8", Offset = "0x11733A8", VA = "0x11733A8")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x117345C", Offset = "0x117345C", VA = "0x117345C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1173510", Offset = "0x1173510", VA = "0x1173510")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x11735C4", Offset = "0x11735C4", VA = "0x11735C4")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1173678", Offset = "0x1173678", VA = "0x1173678")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1173B28", Offset = "0x1173B28", VA = "0x1173B28")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1173208", Offset = "0x1173208", VA = "0x1173208")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1173A98", Offset = "0x1173A98", VA = "0x1173A98")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1173B98", Offset = "0x1173B98", VA = "0x1173B98")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1173C70", Offset = "0x1173C70", VA = "0x1173C70")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1173A1C", Offset = "0x1173A1C", VA = "0x1173A1C")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x11739A4", Offset = "0x11739A4", VA = "0x11739A4")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200001C")]
	public class BipedReferences
	{
		[Token(Token = "0x20000B2")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x170000D1")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x600075A")]
				[Address(RVA = "0x117973C", Offset = "0x117973C", VA = "0x117973C")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x97A048", Offset = "0x97A048", VA = "0x97A048")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700003E")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x1176008", Offset = "0x1176008", VA = "0x1176008", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		public bool isEmpty
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x11763F4", Offset = "0x11763F4", VA = "0x11763F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1176404", Offset = "0x1176404", VA = "0x1176404", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1176830", Offset = "0x1176830", VA = "0x1176830", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1176C68", Offset = "0x1176C68", VA = "0x1176C68")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1177374", Offset = "0x1177374", VA = "0x1177374")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1176EE4", Offset = "0x1176EE4", VA = "0x1176EE4")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1177BA8", Offset = "0x1177BA8", VA = "0x1177BA8")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1177CA8", Offset = "0x1177CA8", VA = "0x1177CA8")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x117825C", Offset = "0x117825C", VA = "0x117825C")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x117804C", Offset = "0x117804C", VA = "0x117804C")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1177EC4", Offset = "0x1177EC4", VA = "0x1177EC4")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1177D48", Offset = "0x1177D48", VA = "0x1177D48")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1178150", Offset = "0x1178150", VA = "0x1178150")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1178358", Offset = "0x1178358", VA = "0x1178358")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1178EBC", Offset = "0x1178EBC", VA = "0x1178EBC")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1178988", Offset = "0x1178988", VA = "0x1178988")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1179204", Offset = "0x1179204", VA = "0x1179204")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1178CD4", Offset = "0x1178CD4", VA = "0x1178CD4")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x117920C", Offset = "0x117920C", VA = "0x117920C")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1179214", Offset = "0x1179214", VA = "0x1179214")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x11793E0", Offset = "0x11793E0", VA = "0x11793E0")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1179604", Offset = "0x1179604", VA = "0x1179604")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1176E5C", Offset = "0x1176E5C", VA = "0x1176E5C")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "MultilineAttribute", RVA = "0x894100", Offset = "0x894100")]
		public string text;

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1179744", Offset = "0x1179744", VA = "0x1179744")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x117974C", Offset = "0x117974C", VA = "0x117974C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x117988C", Offset = "0x117988C", VA = "0x117988C")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class Hierarchy
	{
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1417EDC", Offset = "0x1417EDC", VA = "0x1417EDC")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x14180DC", Offset = "0x14180DC", VA = "0x14180DC")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1417F74", Offset = "0x1417F74", VA = "0x1417F74")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1418200", Offset = "0x1418200", VA = "0x1418200")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1418324", Offset = "0x1418324", VA = "0x1418324")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x14185D4", Offset = "0x14185D4", VA = "0x14185D4")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x14186F0", Offset = "0x14186F0", VA = "0x14186F0")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1418878", Offset = "0x1418878", VA = "0x1418878")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1418C0C", Offset = "0x1418C0C", VA = "0x1418C0C")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x14189F8", Offset = "0x14189F8", VA = "0x14189F8")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1418DAC", Offset = "0x1418DAC", VA = "0x1418DAC")]
		public Hierarchy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000020")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000CF")]
		None,
		[Token(Token = "0x40000D0")]
		InOutCubic,
		[Token(Token = "0x40000D1")]
		InOutQuintic,
		[Token(Token = "0x40000D2")]
		InOutSine,
		[Token(Token = "0x40000D3")]
		InQuintic,
		[Token(Token = "0x40000D4")]
		InQuartic,
		[Token(Token = "0x40000D5")]
		InCubic,
		[Token(Token = "0x40000D6")]
		InQuadratic,
		[Token(Token = "0x40000D7")]
		InElastic,
		[Token(Token = "0x40000D8")]
		InElasticSmall,
		[Token(Token = "0x40000D9")]
		InElasticBig,
		[Token(Token = "0x40000DA")]
		InSine,
		[Token(Token = "0x40000DB")]
		InBack,
		[Token(Token = "0x40000DC")]
		OutQuintic,
		[Token(Token = "0x40000DD")]
		OutQuartic,
		[Token(Token = "0x40000DE")]
		OutCubic,
		[Token(Token = "0x40000DF")]
		OutInCubic,
		[Token(Token = "0x40000E0")]
		OutInQuartic,
		[Token(Token = "0x40000E1")]
		OutElastic,
		[Token(Token = "0x40000E2")]
		OutElasticSmall,
		[Token(Token = "0x40000E3")]
		OutElasticBig,
		[Token(Token = "0x40000E4")]
		OutSine,
		[Token(Token = "0x40000E5")]
		OutBack,
		[Token(Token = "0x40000E6")]
		OutBackCubic,
		[Token(Token = "0x40000E7")]
		OutBackQuartic,
		[Token(Token = "0x40000E8")]
		BackInCubic,
		[Token(Token = "0x40000E9")]
		BackInQuartic
	}
	[Token(Token = "0x2000021")]
	public class Interp
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1418DB4", Offset = "0x1418DB4", VA = "0x1418DB4")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x141981C", Offset = "0x141981C", VA = "0x141981C")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1419924", Offset = "0x1419924", VA = "0x1419924")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1419120", Offset = "0x1419120", VA = "0x1419120")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x141912C", Offset = "0x141912C", VA = "0x141912C")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1419150", Offset = "0x1419150", VA = "0x1419150")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x141918C", Offset = "0x141918C", VA = "0x141918C")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x14191A4", Offset = "0x14191A4", VA = "0x14191A4")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x14191B8", Offset = "0x14191B8", VA = "0x14191B8")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x14191CC", Offset = "0x14191CC", VA = "0x14191CC")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x14191DC", Offset = "0x14191DC", VA = "0x14191DC")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1419224", Offset = "0x1419224", VA = "0x1419224")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x141925C", Offset = "0x141925C", VA = "0x141925C")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1419284", Offset = "0x1419284", VA = "0x1419284")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1419A20", Offset = "0x1419A20", VA = "0x1419A20")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x14192B8", Offset = "0x14192B8", VA = "0x14192B8")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x14192E0", Offset = "0x14192E0", VA = "0x14192E0")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1419310", Offset = "0x1419310", VA = "0x1419310")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1419344", Offset = "0x1419344", VA = "0x1419344")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1419388", Offset = "0x1419388", VA = "0x1419388")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x14193EC", Offset = "0x14193EC", VA = "0x14193EC")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1419450", Offset = "0x1419450", VA = "0x1419450")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x14194A4", Offset = "0x14194A4", VA = "0x14194A4")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x14194F8", Offset = "0x14194F8", VA = "0x14194F8")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1419590", Offset = "0x1419590", VA = "0x1419590")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1419624", Offset = "0x1419624", VA = "0x1419624")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1419A54", Offset = "0x1419A54", VA = "0x1419A54")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x14196C8", Offset = "0x14196C8", VA = "0x14196C8")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x14197AC", Offset = "0x14197AC", VA = "0x14197AC")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x14197DC", Offset = "0x14197DC", VA = "0x14197DC")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1419B3C", Offset = "0x1419B3C", VA = "0x1419B3C")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1419B44", Offset = "0x1419B44", VA = "0x1419B44")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1419BD4", Offset = "0x1419BD4", VA = "0x1419BD4")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000023")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1419C68", Offset = "0x1419C68", VA = "0x1419C68")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1419CC0", Offset = "0x1419CC0", VA = "0x1419CC0")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1419D8C", Offset = "0x1419D8C", VA = "0x1419D8C")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1419CD8", Offset = "0x1419CD8", VA = "0x1419CD8")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1419DA4", Offset = "0x1419DA4", VA = "0x1419DA4")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1419E48", Offset = "0x1419E48", VA = "0x1419E48")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1419E74", Offset = "0x1419E74", VA = "0x1419E74")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1419EC4", Offset = "0x1419EC4", VA = "0x1419EC4")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1419F30", Offset = "0x1419F30", VA = "0x1419F30")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x141A024", Offset = "0x141A024", VA = "0x141A024")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x141A0FC", Offset = "0x141A0FC", VA = "0x141A0FC")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x141A15C", Offset = "0x141A15C", VA = "0x141A15C")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000024")]
	public static class QuaTools
	{
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x141A18C", Offset = "0x141A18C", VA = "0x141A18C")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x141A2D8", Offset = "0x141A2D8", VA = "0x141A2D8")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x141A424", Offset = "0x141A424", VA = "0x141A424")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x141A538", Offset = "0x141A538", VA = "0x141A538")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x141A64C", Offset = "0x141A64C", VA = "0x141A64C")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x141A7D8", Offset = "0x141A7D8", VA = "0x141A7D8")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x141A8A8", Offset = "0x141A8A8", VA = "0x141A8A8")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x141A9FC", Offset = "0x141A9FC", VA = "0x141A9FC")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x141AC80", Offset = "0x141AC80", VA = "0x141AC80")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x141AE94", Offset = "0x141AE94", VA = "0x141AE94")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x141B014", Offset = "0x141B014", VA = "0x141B014")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000025")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000040")]
		public static T instance
		{
			[Token(Token = "0x6000190")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000191")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000192")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894110", Offset = "0x894110")]
		public bool fixTransforms;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		protected bool skipSolverUpdate;

		[Token(Token = "0x17000041")]
		private bool animatePhysics
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x141B2BC", Offset = "0x141B2BC", VA = "0x141B2BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000042")]
		private bool isAnimated
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x141B5F0", Offset = "0x141B5F0", VA = "0x141B5F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x141B184", Offset = "0x141B184", VA = "0x141B184")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x141B21C", Offset = "0x141B21C", VA = "0x141B21C", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x141B220", Offset = "0x141B220", VA = "0x141B220", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x141B224", Offset = "0x141B224", VA = "0x141B224", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x141B228", Offset = "0x141B228", VA = "0x141B228", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x141B2B8", Offset = "0x141B2B8", VA = "0x141B2B8", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x141B260", Offset = "0x141B260", VA = "0x141B260")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x141B5A4", Offset = "0x141B5A4", VA = "0x141B5A4", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x141B3AC", Offset = "0x141B3AC", VA = "0x141B3AC")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x141B6AC", Offset = "0x141B6AC", VA = "0x141B6AC", Slot = "10")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x141B708", Offset = "0x141B708", VA = "0x141B708", Slot = "11")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x141B764", Offset = "0x141B764", VA = "0x141B764")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x141B7AC", Offset = "0x141B7AC", VA = "0x141B7AC")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x141B7BC", Offset = "0x141B7BC", VA = "0x141B7BC")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x141B874", Offset = "0x141B874", VA = "0x141B874")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x141B92C", Offset = "0x141B92C", VA = "0x141B92C")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x141B9E4", Offset = "0x141B9E4", VA = "0x141B9E4")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public static class V3Tools
	{
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x141B9EC", Offset = "0x141B9EC", VA = "0x141B9EC")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x141BAE4", Offset = "0x141BAE4", VA = "0x141BAE4")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x141BBDC", Offset = "0x141BBDC", VA = "0x141BBDC")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x141BCD4", Offset = "0x141BCD4", VA = "0x141BCD4")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x141BDD4", Offset = "0x141BDD4", VA = "0x141BDD4")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x141C010", Offset = "0x141C010", VA = "0x141C010")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x141C260", Offset = "0x141C260", VA = "0x141C260")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x141C460", Offset = "0x141C460", VA = "0x141C460")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000029")]
	public static class Warning
	{
		[Token(Token = "0x20000B3")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x141C63C", Offset = "0x141C63C", VA = "0x141C63C")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x141CA8C", Offset = "0x141CA8C", VA = "0x141CA8C")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Dynamics
{
	[Token(Token = "0x200002A")]
	public class AnimationBlocker : MonoBehaviour
	{
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1179FC0", Offset = "0x1179FC0", VA = "0x1179FC0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x117A098", Offset = "0x117A098", VA = "0x117A098")]
		public AnimationBlocker()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x892F38", Offset = "0x892F38")]
	public class BehaviourAnimatedStagger : BehaviourBase
	{
		[Serializable]
		[Token(Token = "0x20000B4")]
		public struct FallParams
		{
			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float startPinWeightMlp;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float startMuscleWeightMlp;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float losePinSpeed;
		}

		[Serializable]
		[Token(Token = "0x20000B5")]
		public struct FallParamsGroup
		{
			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Muscle.Group[] groups;

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public FallParams fallParams;
		}

		[Token(Token = "0x20000B6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x893C80", Offset = "0x893C80")]
		private sealed class <LoseBalance>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BehaviourAnimatedStagger <>4__this;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool <done>5__2;

			[Token(Token = "0x170000D2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000762")]
				[Address(RVA = "0x117ACD4", Offset = "0x117ACD4", VA = "0x117ACD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000764")]
				[Address(RVA = "0x117AD3C", Offset = "0x117AD3C", VA = "0x117AD3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0x117A170", Offset = "0x117A170", VA = "0x117A170")]
			[DebuggerHidden]
			public <LoseBalance>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0x117A29C", Offset = "0x117A29C", VA = "0x117A29C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000761")]
			[Address(RVA = "0x117A2A0", Offset = "0x117A2A0", VA = "0x117A2A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000763")]
			[Address(RVA = "0x117ACDC", Offset = "0x117ACDC", VA = "0x117ACDC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x894148", Offset = "0x894148")]
		public LayerMask groundLayers;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public float animationBlendSpeed;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public float animationMag;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public float momentumMag;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public float unbalancedMuscleWeightMlp;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float unbalancedMuscleDamperAdd;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public bool dropProps;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public float maxGetUpVelocity;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public float minHipHeight;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public SubBehaviourCOM centerOfMass;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x894180", Offset = "0x894180")]
		public FallParams defaults;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public FallParamsGroup[] groupOverrides;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8941B8", Offset = "0x8941B8")]
		public PuppetEvent onUngrounded;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public PuppetEvent onFallOver;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public PuppetEvent onRest;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[HideInInspector]
		public Vector3 moveVector;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		[HideInInspector]
		public bool isGrounded;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[HideInInspector]
		public Vector3 forward;

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x117A0A0", Offset = "0x117A0A0", VA = "0x117A0A0", Slot = "15")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x117A0C4", Offset = "0x117A0C4", VA = "0x117A0C4", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x117A16C", Offset = "0x117A16C", VA = "0x117A16C", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x117A0F0", Offset = "0x117A0F0", VA = "0x117A0F0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x89C9F0", Offset = "0x89C9F0")]
		private IEnumerator LoseBalance()
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x117A19C", Offset = "0x117A19C", VA = "0x117A19C")]
		private FallParams GetFallParams(Muscle.Group group)
		{
			return default(FallParams);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x117A260", Offset = "0x117A260", VA = "0x117A260")]
		public BehaviourAnimatedStagger()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public abstract class BehaviourBase : MonoBehaviour
	{
		[Token(Token = "0x20000B7")]
		public delegate void BehaviourDelegate();

		[Token(Token = "0x20000B8")]
		public delegate void HitDelegate(MuscleHit hit);

		[Token(Token = "0x20000B9")]
		public delegate void CollisionDelegate(MuscleCollision collision);

		[Serializable]
		[Token(Token = "0x20000BA")]
		public struct PuppetEvent
		{
			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898F78", Offset = "0x898F78")]
			public string switchToBehaviour;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898FB0", Offset = "0x898FB0")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898FE8", Offset = "0x898FE8")]
			public UnityEvent unityEvent;

			[Token(Token = "0x4000586")]
			private const string empty = "";

			[Token(Token = "0x170000D4")]
			public bool switchBehaviour
			{
				[Token(Token = "0x6000771")]
				[Address(RVA = "0x97A280", Offset = "0x97A280", VA = "0x97A280")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0x97A288", Offset = "0x97A288", VA = "0x97A288")]
			public void Trigger(PuppetMaster puppetMaster, bool switchBehaviourEnabled = true)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BB")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string animationState;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float crossfadeTime;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int layer;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400058B")]
			private const string empty = "";

			[Token(Token = "0x6000773")]
			[Address(RVA = "0x117C25C", Offset = "0x117C25C", VA = "0x117C25C")]
			public void Activate(Animator animator, Animation animation)
			{
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0x117C330", Offset = "0x117C330", VA = "0x117C330")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000775")]
			[Address(RVA = "0x117C434", Offset = "0x117C434", VA = "0x117C434")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000776")]
			[Address(RVA = "0x117C514", Offset = "0x117C514", VA = "0x117C514")]
			public AnimatorEvent()
			{
			}
		}

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BehaviourDelegate OnPreActivate;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BehaviourDelegate OnPreInitiate;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BehaviourDelegate OnPreFixedUpdate;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BehaviourDelegate OnPreUpdate;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BehaviourDelegate OnPreLateUpdate;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BehaviourDelegate OnPreDeactivate;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public BehaviourDelegate OnPreFixTransforms;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public BehaviourDelegate OnPreRead;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public BehaviourDelegate OnPreWrite;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public HitDelegate OnPreMuscleHit;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public CollisionDelegate OnPreMuscleCollision;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CollisionDelegate OnPreMuscleCollisionExit;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public BehaviourDelegate OnHierarchyChanged;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public BehaviourDelegate OnPostActivate;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public BehaviourDelegate OnPostInitiate;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public BehaviourDelegate OnPostFixedUpdate;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public BehaviourDelegate OnPostUpdate;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public BehaviourDelegate OnPostLateUpdate;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public BehaviourDelegate OnPostDeactivate;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public BehaviourDelegate OnPostDrawGizmos;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public BehaviourDelegate OnPostFixTransforms;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public BehaviourDelegate OnPostRead;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public BehaviourDelegate OnPostWrite;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public HitDelegate OnPostMuscleHit;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public CollisionDelegate OnPostMuscleCollision;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public CollisionDelegate OnPostMuscleCollisionExit;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[HideInInspector]
		public bool deactivated;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x894240", Offset = "0x894240")]
		private bool <forceActive>k__BackingField;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		private bool initiated;

		[Token(Token = "0x17000043")]
		public bool forceActive
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x117AFBC", Offset = "0x117AFBC", VA = "0x117AFBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CA54", Offset = "0x89CA54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x117AFC4", Offset = "0x117AFC4", VA = "0x117AFC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CA64", Offset = "0x89CA64")]
			protected set
			{
			}
		}

		[Token(Token = "0x60001B9")]
		public abstract void OnReactivate();

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x117AD44", Offset = "0x117AD44", VA = "0x117AD44", Slot = "5")]
		public virtual void Resurrect()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x117AD48", Offset = "0x117AD48", VA = "0x117AD48", Slot = "6")]
		public virtual void Freeze()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x117AD4C", Offset = "0x117AD4C", VA = "0x117AD4C", Slot = "7")]
		public virtual void Unfreeze()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x117AD50", Offset = "0x117AD50", VA = "0x117AD50", Slot = "8")]
		public virtual void KillStart()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x117AD54", Offset = "0x117AD54", VA = "0x117AD54", Slot = "9")]
		public virtual void KillEnd()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x117AD58", Offset = "0x117AD58", VA = "0x117AD58", Slot = "10")]
		public virtual void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x117AD5C", Offset = "0x117AD5C", VA = "0x117AD5C", Slot = "11")]
		public virtual void OnMuscleAdded(Muscle m)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x117AF78", Offset = "0x117AF78", VA = "0x117AF78", Slot = "12")]
		public virtual void OnMuscleRemoved(Muscle m)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x117AF88", Offset = "0x117AF88", VA = "0x117AF88", Slot = "13")]
		protected virtual void OnActivate()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x117AF8C", Offset = "0x117AF8C", VA = "0x117AF8C", Slot = "14")]
		protected virtual void OnDeactivate()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x117AF90", Offset = "0x117AF90", VA = "0x117AF90", Slot = "15")]
		protected virtual void OnInitiate()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x117AF94", Offset = "0x117AF94", VA = "0x117AF94", Slot = "16")]
		protected virtual void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x117AF98", Offset = "0x117AF98", VA = "0x117AF98", Slot = "17")]
		protected virtual void OnUpdate()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x117AF9C", Offset = "0x117AF9C", VA = "0x117AF9C", Slot = "18")]
		protected virtual void OnLateUpdate()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x117AFA0", Offset = "0x117AFA0", VA = "0x117AFA0", Slot = "19")]
		protected virtual void OnDrawGizmosBehaviour()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x117AFA4", Offset = "0x117AFA4", VA = "0x117AFA4", Slot = "20")]
		protected virtual void OnFixTransformsBehaviour()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x117AFA8", Offset = "0x117AFA8", VA = "0x117AFA8", Slot = "21")]
		protected virtual void OnReadBehaviour()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x117AFAC", Offset = "0x117AFAC", VA = "0x117AFAC", Slot = "22")]
		protected virtual void OnWriteBehaviour()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x117AFB0", Offset = "0x117AFB0", VA = "0x117AFB0", Slot = "23")]
		protected virtual void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x117AFB4", Offset = "0x117AFB4", VA = "0x117AFB4", Slot = "24")]
		protected virtual void OnMuscleCollisionBehaviour(MuscleCollision collision)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x117AFB8", Offset = "0x117AFB8", VA = "0x117AFB8", Slot = "25")]
		protected virtual void OnMuscleCollisionExitBehaviour(MuscleCollision collision)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x117AFD0", Offset = "0x117AFD0", VA = "0x117AFD0")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x117B028", Offset = "0x117B028", VA = "0x117B028")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x117B08C", Offset = "0x117B08C", VA = "0x117B08C")]
		public void OnRead()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x117B0F0", Offset = "0x117B0F0", VA = "0x117B0F0")]
		public void OnWrite()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x117B154", Offset = "0x117B154", VA = "0x117B154")]
		public void OnMuscleHit(MuscleHit hit)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x117B4B0", Offset = "0x117B4B0", VA = "0x117B4B0")]
		public void OnMuscleCollision(MuscleCollision collision)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x117B888", Offset = "0x117B888", VA = "0x117B888")]
		public void OnMuscleCollisionExit(MuscleCollision collision)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x117B930", Offset = "0x117B930", VA = "0x117B930")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x117B940", Offset = "0x117B940", VA = "0x117B940")]
		public void Activate()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x117BA60", Offset = "0x117BA60", VA = "0x117BA60")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x117BAB0", Offset = "0x117BAB0", VA = "0x117BAB0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x117BB54", Offset = "0x117BB54", VA = "0x117BB54")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x117BBF8", Offset = "0x117BBF8", VA = "0x117BBF8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x117BC9C", Offset = "0x117BC9C", VA = "0x117BC9C", Slot = "26")]
		protected virtual void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x117BCDC", Offset = "0x117BCDC", VA = "0x117BCDC")]
		protected void RotateTargetToRootMuscle()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x117BE74", Offset = "0x117BE74", VA = "0x117BE74")]
		protected void TranslateTargetToRootMuscle(float maintainY)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x117A974", Offset = "0x117A974", VA = "0x117A974")]
		protected void RemoveMusclesOfGroup(Muscle.Group group)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x117C09C", Offset = "0x117C09C", VA = "0x117C09C", Slot = "27")]
		protected virtual void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x117C01C", Offset = "0x117C01C", VA = "0x117C01C")]
		protected bool MusclesContainsGroup(Muscle.Group group)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x117A294", Offset = "0x117A294", VA = "0x117A294")]
		protected BehaviourBase()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x892F70", Offset = "0x892F70")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x892F70", Offset = "0x892F70")]
	public class BehaviourFall : BehaviourBase
	{
		[Token(Token = "0x20000BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x893C90", Offset = "0x893C90")]
		private sealed class <SmoothActivate>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BehaviourFall <>4__this;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <fader>5__2;

			[Token(Token = "0x170000D5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600077A")]
				[Address(RVA = "0x117D240", Offset = "0x117D240", VA = "0x117D240", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600077C")]
				[Address(RVA = "0x117D2A8", Offset = "0x117D2A8", VA = "0x117D2A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0x117C844", Offset = "0x117C844", VA = "0x117C844")]
			[DebuggerHidden]
			public <SmoothActivate>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000778")]
			[Address(RVA = "0x117D05C", Offset = "0x117D05C", VA = "0x117D05C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000779")]
			[Address(RVA = "0x117D060", Offset = "0x117D060", VA = "0x117D060", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600077B")]
			[Address(RVA = "0x117D248", Offset = "0x117D248", VA = "0x117D248", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x894250", Offset = "0x894250")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894250", Offset = "0x894250")]
		public string stateName;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8942B0", Offset = "0x8942B0")]
		public float transitionDuration;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8942E8", Offset = "0x8942E8")]
		public int layer;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894320", Offset = "0x894320")]
		public float fixedTime;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x894358", Offset = "0x894358")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894358", Offset = "0x894358")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8943B8", Offset = "0x8943B8")]
		public string blendParameter;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8943F0", Offset = "0x8943F0")]
		public float writheHeight;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894428", Offset = "0x894428")]
		public float writheYVelocity;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894460", Offset = "0x894460")]
		public float blendSpeed;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894498", Offset = "0x894498")]
		public float blendMappingSpeed;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8944D0", Offset = "0x8944D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8944D0", Offset = "0x8944D0")]
		public bool canEnd;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894530", Offset = "0x894530")]
		public float minTime;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894568", Offset = "0x894568")]
		public float maxEndVelocity;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8945A0", Offset = "0x8945A0")]
		public PuppetEvent onEnd;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private float timer;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private bool endTriggered;

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x117C6DC", Offset = "0x117C6DC", VA = "0x117C6DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89CA74", Offset = "0x89CA74")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x117C728", Offset = "0x117C728", VA = "0x117C728")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89CAAC", Offset = "0x89CAAC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x117C774", Offset = "0x117C774", VA = "0x117C774", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x117C830", Offset = "0x117C830", VA = "0x117C830", Slot = "14")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x117C838", Offset = "0x117C838", VA = "0x117C838", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x117C7B4", Offset = "0x117C7B4", VA = "0x117C7B4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x89CAE4", Offset = "0x89CAE4")]
		private IEnumerator SmoothActivate()
		{
			return null;
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x117C870", Offset = "0x117C870", VA = "0x117C870", Slot = "16")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x117CDB0", Offset = "0x117CDB0", VA = "0x117CDB0", Slot = "18")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x117CF50", Offset = "0x117CF50", VA = "0x117CF50", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x117CBFC", Offset = "0x117CBFC", VA = "0x117CBFC")]
		private float GetBlendTarget(float groundHeight)
		{
			return default(float);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x117CA84", Offset = "0x117CA84", VA = "0x117CA84")]
		private float GetGroundHeight()
		{
			return default(float);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x117CFB8", Offset = "0x117CFB8", VA = "0x117CFB8")]
		public BehaviourFall()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x892FD0", Offset = "0x892FD0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x892FD0", Offset = "0x892FD0")]
	public class BehaviourPuppet : BehaviourBase
	{
		[Serializable]
		[Token(Token = "0x20000BD")]
		public enum State
		{
			[Token(Token = "0x4000591")]
			Puppet,
			[Token(Token = "0x4000592")]
			Unpinned,
			[Token(Token = "0x4000593")]
			GetUp
		}

		[Serializable]
		[Token(Token = "0x20000BE")]
		public enum NormalMode
		{
			[Token(Token = "0x4000595")]
			Active,
			[Token(Token = "0x4000596")]
			Unmapped,
			[Token(Token = "0x4000597")]
			Kinematic
		}

		[Serializable]
		[Token(Token = "0x20000BF")]
		public class MasterProps
		{
			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NormalMode normalMode;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float mappingBlendSpeed;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool activateOnStaticCollisions;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float activateOnImpulse;

			[Token(Token = "0x600077D")]
			[Address(RVA = "0x11811D4", Offset = "0x11811D4", VA = "0x11811D4")]
			public MasterProps()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C0")]
		public struct MuscleProps
		{
			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899020", Offset = "0x899020")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x899020", Offset = "0x899020")]
			public float unpinParents;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899074", Offset = "0x899074")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x899074", Offset = "0x899074")]
			public float unpinChildren;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8990C8", Offset = "0x8990C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8990C8", Offset = "0x8990C8")]
			public float unpinGroup;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89911C", Offset = "0x89911C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89911C", Offset = "0x89911C")]
			public float minMappingWeight;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899170", Offset = "0x899170")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x899170", Offset = "0x899170")]
			public float maxMappingWeight;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8991C4", Offset = "0x8991C4")]
			public bool disableColliders;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8991FC", Offset = "0x8991FC")]
			public float regainPinSpeed;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899234", Offset = "0x899234")]
			public float collisionResistance;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89926C", Offset = "0x89926C")]
			public float knockOutDistance;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8992A4", Offset = "0x8992A4")]
			public PhysicMaterial puppetMaterial;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8992DC", Offset = "0x8992DC")]
			public PhysicMaterial unpinnedMaterial;
		}

		[Serializable]
		[Token(Token = "0x20000C1")]
		public struct MusclePropsGroup
		{
			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899324", Offset = "0x899324")]
			public Muscle.Group[] groups;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89935C", Offset = "0x89935C")]
			public MuscleProps props;
		}

		[Serializable]
		[Token(Token = "0x20000C2")]
		public struct CollisionResistanceMultiplier
		{
			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LayerMask layers;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899394", Offset = "0x899394")]
			public float multiplier;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8993CC", Offset = "0x8993CC")]
			public float collisionThreshold;
		}

		[Token(Token = "0x20000C3")]
		public delegate void CollisionImpulseDelegate(MuscleCollision m, float impulse);

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8945D8", Offset = "0x8945D8")]
		public MasterProps masterProps;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894610", Offset = "0x894610")]
		public LayerMask groundLayers;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894648", Offset = "0x894648")]
		public LayerMask collisionLayers;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894680", Offset = "0x894680")]
		public float collisionThreshold;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Weight collisionResistance;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8946B8", Offset = "0x8946B8")]
		public CollisionResistanceMultiplier[] collisionResistanceMultipliers;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8946F0", Offset = "0x8946F0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8946F0", Offset = "0x8946F0")]
		public int maxCollisions;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894744", Offset = "0x894744")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x894744", Offset = "0x894744")]
		public float regainPinSpeed;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89479C", Offset = "0x89479C")]
		public float boostFalloff;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8947D4", Offset = "0x8947D4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8947D4", Offset = "0x8947D4")]
		public MuscleProps defaults;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894834", Offset = "0x894834")]
		public MusclePropsGroup[] groupOverrides;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x89486C", Offset = "0x89486C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89486C", Offset = "0x89486C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89486C", Offset = "0x89486C")]
		public float knockOutDistance;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8948E8", Offset = "0x8948E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8948E8", Offset = "0x8948E8")]
		public float unpinnedMuscleWeightMlp;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89493C", Offset = "0x89493C")]
		public float maxRigidbodyVelocity;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894974", Offset = "0x894974")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x894974", Offset = "0x894974")]
		public float pinWeightThreshold;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8949C8", Offset = "0x8949C8")]
		public bool unpinnedMuscleKnockout;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x181")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894A00", Offset = "0x894A00")]
		public bool dropProps;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x182")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x894A38", Offset = "0x894A38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894A38", Offset = "0x894A38")]
		public bool canGetUp;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894A98", Offset = "0x894A98")]
		public float getUpDelay;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894AD0", Offset = "0x894AD0")]
		public float blendToAnimationTime;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894B08", Offset = "0x894B08")]
		public float maxGetUpVelocity;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894B40", Offset = "0x894B40")]
		public float minGetUpDuration;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894B78", Offset = "0x894B78")]
		public float getUpCollisionResistanceMlp;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894BB0", Offset = "0x894BB0")]
		public float getUpRegainPinSpeedMlp;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894BE8", Offset = "0x894BE8")]
		public float getUpKnockOutDistanceMlp;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894C20", Offset = "0x894C20")]
		public Vector3 getUpOffsetProne;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894C58", Offset = "0x894C58")]
		public Vector3 getUpOffsetSupine;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x894C90", Offset = "0x894C90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894C90", Offset = "0x894C90")]
		public PuppetEvent onGetUpProne;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894CF0", Offset = "0x894CF0")]
		public PuppetEvent onGetUpSupine;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894D28", Offset = "0x894D28")]
		public PuppetEvent onLoseBalance;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894D60", Offset = "0x894D60")]
		public PuppetEvent onLoseBalanceFromPuppet;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894D98", Offset = "0x894D98")]
		public PuppetEvent onLoseBalanceFromGetUp;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894DD0", Offset = "0x894DD0")]
		public PuppetEvent onRegainBalance;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public CollisionImpulseDelegate OnCollisionImpulse;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x894E08", Offset = "0x894E08")]
		private State <state>k__BackingField;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
		[HideInInspector]
		public bool canMoveTarget;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private float unpinnedTimer;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		private float getUpTimer;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private Vector3 hipsForward;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
		private Vector3 hipsUp;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private float getupAnimationBlendWeight;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
		private float getupAnimationBlendWeightV;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private bool getUpTargetFixed;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
		private NormalMode lastNormalMode;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private int collisions;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		private bool eventsEnabled;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private float lastKnockOutDistance;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
		private float knockOutDistanceSqr;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private bool getupDisabled;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x299")]
		private bool hasCollidedSinceGetUp;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29A")]
		private bool hasBoosted;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private MuscleCollisionBroadcaster broadcaster;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private Vector3 getUpPosition;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
		private bool dropPropFlag;

		[Token(Token = "0x17000044")]
		public State state
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x117D348", Offset = "0x117D348", VA = "0x117D348")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CBB8", Offset = "0x89CBB8")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x117D350", Offset = "0x117D350", VA = "0x117D350")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CBC8", Offset = "0x89CBC8")]
			private set
			{
			}
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x117D2B0", Offset = "0x117D2B0", VA = "0x117D2B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89CB48", Offset = "0x89CB48")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x117D2FC", Offset = "0x117D2FC", VA = "0x117D2FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89CB80", Offset = "0x89CB80")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x117D358", Offset = "0x117D358", VA = "0x117D358", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x117D604", Offset = "0x117D604", VA = "0x117D604")]
		public void Reset(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x117D670", Offset = "0x117D670", VA = "0x117D670", Slot = "10")]
		public override void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x117D7E0", Offset = "0x117D7E0", VA = "0x117D7E0", Slot = "15")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x117DD90", Offset = "0x117DD90", VA = "0x117DD90", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x117E5A4", Offset = "0x117E5A4", VA = "0x117E5A4", Slot = "8")]
		public override void KillStart()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x117E640", Offset = "0x117E640", VA = "0x117E640", Slot = "9")]
		public override void KillEnd()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x117E648", Offset = "0x117E648", VA = "0x117E648", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x117E6D4", Offset = "0x117E6D4", VA = "0x117E6D4", Slot = "14")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x117E6E0", Offset = "0x117E6E0", VA = "0x117E6E0", Slot = "16")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x117EEB8", Offset = "0x117EEB8", VA = "0x117EEB8", Slot = "18")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x117F1D0", Offset = "0x117F1D0", VA = "0x117F1D0")]
		private bool SetKinematic()
		{
			return default(bool);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x117F2B0", Offset = "0x117F2B0", VA = "0x117F2B0", Slot = "21")]
		protected override void OnReadBehaviour()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x117F038", Offset = "0x117F038", VA = "0x117F038")]
		private void BlendMuscleMapping(int muscleIndex, ref bool to)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x117F578", Offset = "0x117F578", VA = "0x117F578", Slot = "11")]
		public override void OnMuscleAdded(Muscle m)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x117F5B8", Offset = "0x117F5B8", VA = "0x117F5B8", Slot = "12")]
		public override void OnMuscleRemoved(Muscle m)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x117F540", Offset = "0x117F540", VA = "0x117F540")]
		protected void MoveTarget(Vector3 position)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x117F5F0", Offset = "0x117F5F0", VA = "0x117F5F0")]
		protected void RotateTarget(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x117F628", Offset = "0x117F628", VA = "0x117F628", Slot = "27")]
		protected override void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x117F63C", Offset = "0x117F63C", VA = "0x117F63C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x117F840", Offset = "0x117F840", VA = "0x117F840")]
		public void Boost(float immunity, float impulseMlp)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x117F8D0", Offset = "0x117F8D0", VA = "0x117F8D0")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x117FAB8", Offset = "0x117FAB8", VA = "0x117FAB8")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x117FCFC", Offset = "0x117FCFC", VA = "0x117FCFC")]
		public void BoostImmunity(float immunity)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x117F914", Offset = "0x117F914", VA = "0x117F914")]
		public void BoostImmunity(int muscleIndex, float immunity)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x117FD74", Offset = "0x117FD74", VA = "0x117FD74")]
		public void BoostImmunity(int muscleIndex, float immunity, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x117FE18", Offset = "0x117FE18", VA = "0x117FE18")]
		public void BoostImpulseMlp(float impulseMlp)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x117F9E8", Offset = "0x117F9E8", VA = "0x117F9E8")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x117FE88", Offset = "0x117FE88", VA = "0x117FE88")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x117FF2C", Offset = "0x117FF2C", VA = "0x117FF2C")]
		public void Unpin()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x117FFA8", Offset = "0x117FFA8", VA = "0x117FFA8", Slot = "23")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1180188", Offset = "0x1180188", VA = "0x1180188", Slot = "24")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1180518", Offset = "0x1180518", VA = "0x1180518")]
		private float GetImpulse(MuscleCollision m, ref float layerThreshold)
		{
			return default(float);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x118008C", Offset = "0x118008C", VA = "0x118008C")]
		private void UnPin(int muscleIndex, float unpin)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1180BD4", Offset = "0x1180BD4", VA = "0x1180BD4")]
		private void UnPinMuscle(int muscleIndex, float unpin)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x11809EC", Offset = "0x11809EC", VA = "0x11809EC")]
		private bool Activate(Collision collision, float impulse)
		{
			return default(bool);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1180DE0", Offset = "0x1180DE0", VA = "0x1180DE0")]
		public bool IsProne()
		{
			return default(bool);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x117FBD8", Offset = "0x117FBD8", VA = "0x117FBD8")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren)
		{
			return default(float);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1180A84", Offset = "0x1180A84", VA = "0x1180A84")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren, float falloffGroup)
		{
			return default(float);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1180F58", Offset = "0x1180F58", VA = "0x1180F58")]
		private bool InGroup(Muscle.Group group1, Muscle.Group group2)
		{
			return default(bool);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x117EDD0", Offset = "0x117EDD0", VA = "0x117EDD0")]
		private MuscleProps GetProps(Muscle.Group group)
		{
			return default(MuscleProps);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x117DE34", Offset = "0x117DE34", VA = "0x117DE34")]
		public void SetState(State newState)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1181038", Offset = "0x1181038", VA = "0x1181038")]
		public void SetColliders(bool unpinned)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x117D430", Offset = "0x117D430", VA = "0x117D430")]
		private void SetColliders(Muscle m, bool unpinned)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x11810C8", Offset = "0x11810C8", VA = "0x11810C8")]
		public BehaviourPuppet()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x893030", Offset = "0x893030")]
	public class BehaviourTemplate : BehaviourBase
	{
		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public SubBehaviourCOM centerOfMass;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public LayerMask groundLayers;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public PuppetEvent onLoseBalance;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float loseBalanceAngle;

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x11812B8", Offset = "0x11812B8", VA = "0x11812B8", Slot = "15")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x11812DC", Offset = "0x11812DC", VA = "0x11812DC", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x11812E0", Offset = "0x11812E0", VA = "0x11812E0", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x11812E4", Offset = "0x11812E4", VA = "0x11812E4", Slot = "14")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x11812E8", Offset = "0x11812E8", VA = "0x11812E8", Slot = "16")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1181320", Offset = "0x1181320", VA = "0x1181320", Slot = "18")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1181324", Offset = "0x1181324", VA = "0x1181324", Slot = "23")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x118132C", Offset = "0x118132C", VA = "0x118132C", Slot = "24")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1181334", Offset = "0x1181334", VA = "0x1181334")]
		public BehaviourTemplate()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	public class SubBehaviourBalancer : SubBehaviourBase
	{
		[Serializable]
		[Token(Token = "0x20000C4")]
		public class Settings
		{
			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899404", Offset = "0x899404")]
			public float damperForSpring;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89943C", Offset = "0x89943C")]
			public float maxForceMlp;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899474", Offset = "0x899474")]
			public float IMlp;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8994AC", Offset = "0x8994AC")]
			public float velocityF;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8994E4", Offset = "0x8994E4")]
			public Vector3 copOffset;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89951C", Offset = "0x89951C")]
			public float torqueMlp;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899554", Offset = "0x899554")]
			public float maxTorqueMag;

			[Token(Token = "0x6000782")]
			[Address(RVA = "0x10E0678", Offset = "0x10E0678", VA = "0x10E0678")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x894E28", Offset = "0x894E28")]
		private ConfigurableJoint <joint>k__BackingField;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x894E38", Offset = "0x894E38")]
		private Vector3 <dir>k__BackingField;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x894E48", Offset = "0x894E48")]
		private Vector3 <dirVel>k__BackingField;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x894E58", Offset = "0x894E58")]
		private Vector3 <cop>k__BackingField;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x894E68", Offset = "0x894E68")]
		private Vector3 <com>k__BackingField;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x894E78", Offset = "0x894E78")]
		private Vector3 <comV>k__BackingField;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Settings settings;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody[] rigidbodies;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform[] copPoints;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PressureSensor pressureSensor;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Rigidbody Ibody;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 I;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion toJointSpace;

		[Token(Token = "0x17000045")]
		public ConfigurableJoint joint
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x10DFDD4", Offset = "0x10DFDD4", VA = "0x10DFDD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CBD8", Offset = "0x89CBD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x10DFDDC", Offset = "0x10DFDDC", VA = "0x10DFDDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CBE8", Offset = "0x89CBE8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public Vector3 dir
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x10DFDE4", Offset = "0x10DFDE4", VA = "0x10DFDE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CBF8", Offset = "0x89CBF8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x10DFDF0", Offset = "0x10DFDF0", VA = "0x10DFDF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CC08", Offset = "0x89CC08")]
			private set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public Vector3 dirVel
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x10DFDFC", Offset = "0x10DFDFC", VA = "0x10DFDFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CC18", Offset = "0x89CC18")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x10DFE08", Offset = "0x10DFE08", VA = "0x10DFE08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CC28", Offset = "0x89CC28")]
			private set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public Vector3 cop
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x10DFE14", Offset = "0x10DFE14", VA = "0x10DFE14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CC38", Offset = "0x89CC38")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x10DFE20", Offset = "0x10DFE20", VA = "0x10DFE20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CC48", Offset = "0x89CC48")]
			private set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public Vector3 com
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x10DFE2C", Offset = "0x10DFE2C", VA = "0x10DFE2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CC58", Offset = "0x89CC58")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x10DFE38", Offset = "0x10DFE38", VA = "0x10DFE38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CC68", Offset = "0x89CC68")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public Vector3 comV
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x10DFE44", Offset = "0x10DFE44", VA = "0x10DFE44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CC78", Offset = "0x89CC78")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x10DFE50", Offset = "0x10DFE50", VA = "0x10DFE50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CC88", Offset = "0x89CC88")]
			private set
			{
			}
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x10DFE5C", Offset = "0x10DFE5C", VA = "0x10DFE5C")]
		public void Initiate(BehaviourBase behaviour, Settings settings, Rigidbody Ibody, Rigidbody[] rigidbodies, ConfigurableJoint joint, Transform[] copPoints, PressureSensor pressureSensor)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x10DFFD4", Offset = "0x10DFFD4", VA = "0x10DFFD4")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x10E05AC", Offset = "0x10E05AC", VA = "0x10E05AC")]
		public SubBehaviourBalancer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000031")]
	public abstract class SubBehaviourBase
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected BehaviourBase behaviour;

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x10E0694", Offset = "0x10E0694", VA = "0x10E0694")]
		protected static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x10E06C4", Offset = "0x10E06C4", VA = "0x10E06C4")]
		protected static Vector3 XYZ(Vector2 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x10E0700", Offset = "0x10E0700", VA = "0x10E0700")]
		protected static Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x10E0738", Offset = "0x10E0738", VA = "0x10E0738")]
		protected static Vector3 SetY(Vector3 v, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x10E0670", Offset = "0x10E0670", VA = "0x10E0670")]
		protected SubBehaviourBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000032")]
	public class SubBehaviourCOM : SubBehaviourBase
	{
		[Serializable]
		[Token(Token = "0x20000C5")]
		public enum Mode
		{
			[Token(Token = "0x40005B5")]
			FeetCentroid,
			[Token(Token = "0x40005B6")]
			CenterOfPressure
		}

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode mode;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float velocityDamper;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float velocityLerpSpeed;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float velocityMax;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centerOfPressureSpeed;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x894E88", Offset = "0x894E88")]
		private Vector3 <position>k__BackingField;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x894E98", Offset = "0x894E98")]
		private Vector3 <direction>k__BackingField;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x894EA8", Offset = "0x894EA8")]
		private float <angle>k__BackingField;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x894EB8", Offset = "0x894EB8")]
		private Vector3 <velocity>k__BackingField;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x894EC8", Offset = "0x894EC8")]
		private Vector3 <centerOfPressure>k__BackingField;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x894ED8", Offset = "0x894ED8")]
		private Quaternion <rotation>k__BackingField;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x894EE8", Offset = "0x894EE8")]
		private Quaternion <inverseRotation>k__BackingField;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x894EF8", Offset = "0x894EF8")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x894F08", Offset = "0x894F08")]
		private float <lastGroundedTime>k__BackingField;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public bool[] groundContacts;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Vector3[] groundContactPoints;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private LayerMask groundLayers;

		[Token(Token = "0x1700004B")]
		public Vector3 position
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x10E0770", Offset = "0x10E0770", VA = "0x10E0770")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CC98", Offset = "0x89CC98")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x10E077C", Offset = "0x10E077C", VA = "0x10E077C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CCA8", Offset = "0x89CCA8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public Vector3 direction
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x10E0788", Offset = "0x10E0788", VA = "0x10E0788")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CCB8", Offset = "0x89CCB8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x10E0794", Offset = "0x10E0794", VA = "0x10E0794")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CCC8", Offset = "0x89CCC8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public float angle
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x10E07A0", Offset = "0x10E07A0", VA = "0x10E07A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CCD8", Offset = "0x89CCD8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x10E07A8", Offset = "0x10E07A8", VA = "0x10E07A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CCE8", Offset = "0x89CCE8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public Vector3 velocity
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x10E07B0", Offset = "0x10E07B0", VA = "0x10E07B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CCF8", Offset = "0x89CCF8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x10E07BC", Offset = "0x10E07BC", VA = "0x10E07BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CD08", Offset = "0x89CD08")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public Vector3 centerOfPressure
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x10E07C8", Offset = "0x10E07C8", VA = "0x10E07C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CD18", Offset = "0x89CD18")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x10E07D4", Offset = "0x10E07D4", VA = "0x10E07D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CD28", Offset = "0x89CD28")]
			private set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public Quaternion rotation
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x10E07E0", Offset = "0x10E07E0", VA = "0x10E07E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CD38", Offset = "0x89CD38")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x10E07EC", Offset = "0x10E07EC", VA = "0x10E07EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CD48", Offset = "0x89CD48")]
			private set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public Quaternion inverseRotation
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x10E07F8", Offset = "0x10E07F8", VA = "0x10E07F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CD58", Offset = "0x89CD58")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x10E0804", Offset = "0x10E0804", VA = "0x10E0804")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CD68", Offset = "0x89CD68")]
			private set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public bool isGrounded
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x10E0810", Offset = "0x10E0810", VA = "0x10E0810")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CD78", Offset = "0x89CD78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x10E0818", Offset = "0x10E0818", VA = "0x10E0818")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CD88", Offset = "0x89CD88")]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public float lastGroundedTime
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x10E0824", Offset = "0x10E0824", VA = "0x10E0824")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CD98", Offset = "0x89CD98")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x10E082C", Offset = "0x10E082C", VA = "0x10E082C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CDA8", Offset = "0x89CDA8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x10E0834", Offset = "0x10E0834", VA = "0x10E0834")]
		public void Initiate(BehaviourBase behaviour, LayerMask groundLayers)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x10E0BB0", Offset = "0x10E0BB0", VA = "0x10E0BB0")]
		private void OnHierarchyChanged()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x10E0C50", Offset = "0x10E0C50", VA = "0x10E0C50")]
		private void OnPreMuscleCollision(MuscleCollision c)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x10E0EE8", Offset = "0x10E0EE8", VA = "0x10E0EE8")]
		private void OnPreMuscleCollisionExit(MuscleCollision c)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x10E0FE8", Offset = "0x10E0FE8", VA = "0x10E0FE8")]
		private void OnPreActivate()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x10E1468", Offset = "0x10E1468", VA = "0x10E1468")]
		private void OnPreLateUpdate()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x10E1C24", Offset = "0x10E1C24", VA = "0x10E1C24")]
		private void OnPreDeactivate()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x10E0D48", Offset = "0x10E0D48", VA = "0x10E0D48")]
		private Vector3 GetCollisionCOP(Collision collision)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x10E17FC", Offset = "0x10E17FC", VA = "0x10E17FC")]
		private bool IsGrounded()
		{
			return default(bool);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x10E1104", Offset = "0x10E1104", VA = "0x10E1104")]
		private Vector3 GetCenterOfMass()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x10E19E4", Offset = "0x10E19E4", VA = "0x10E19E4")]
		private Vector3 GetCenterOfMassVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x10E1C94", Offset = "0x10E1C94", VA = "0x10E1C94")]
		private Vector3 GetMomentum()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x10E1860", Offset = "0x10E1860", VA = "0x10E1860")]
		private Vector3 GetCenterOfPressure()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x10E12D4", Offset = "0x10E12D4", VA = "0x10E12D4")]
		private Vector3 GetFeetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x10E1E4C", Offset = "0x10E1E4C", VA = "0x10E1E4C")]
		public SubBehaviourCOM()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000033")]
	public class Booster
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894F38", Offset = "0x894F38")]
		public bool fullBody;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894F70", Offset = "0x894F70")]
		public ConfigurableJoint[] muscles;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894FA8", Offset = "0x894FA8")]
		public Muscle.Group[] groups;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x894FE0", Offset = "0x894FE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x894FE0", Offset = "0x894FE0")]
		public float immunity;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895034", Offset = "0x895034")]
		public float impulseMlp;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89506C", Offset = "0x89506C")]
		public float boostParents;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8950A4", Offset = "0x8950A4")]
		public float boostChildren;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8950DC", Offset = "0x8950DC")]
		public float delay;

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1185EB8", Offset = "0x1185EB8", VA = "0x1185EB8")]
		public void Boost(BehaviourPuppet puppet)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x11860C4", Offset = "0x11860C4", VA = "0x11860C4")]
		public Booster()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class JointBreakBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		public int muscleIndex;

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1186154", Offset = "0x1186154", VA = "0x1186154")]
		private void OnJointBreak()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x11861D8", Offset = "0x11861D8", VA = "0x11861D8")]
		public JointBreakBroadcaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000035")]
	public class Muscle
	{
		[Serializable]
		[Token(Token = "0x20000C6")]
		public enum Group
		{
			[Token(Token = "0x40005B8")]
			Hips,
			[Token(Token = "0x40005B9")]
			Spine,
			[Token(Token = "0x40005BA")]
			Head,
			[Token(Token = "0x40005BB")]
			LeftArm,
			[Token(Token = "0x40005BC")]
			RightArm,
			[Token(Token = "0x40005BD")]
			LeftHand,
			[Token(Token = "0x40005BE")]
			RightHand,
			[Token(Token = "0x40005BF")]
			Leg,
			[Token(Token = "0x40005C0")]
			LowerLeg,
			[Token(Token = "0x40005C1")]
			Foot,
			[Token(Token = "0x40005C2")]
			Tail,
			[Token(Token = "0x40005C3")]
			Prop,
			[Token(Token = "0x40005C4")]
			Extra1,
			[Token(Token = "0x40005C5")]
			Extra2,
			[Token(Token = "0x40005C6")]
			Extra3
		}

		[Serializable]
		[Token(Token = "0x20000C7")]
		public class Props
		{
			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89958C", Offset = "0x89958C")]
			public Group group;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8995C4", Offset = "0x8995C4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8995C4", Offset = "0x8995C4")]
			public float mappingWeight;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899618", Offset = "0x899618")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x899618", Offset = "0x899618")]
			public float pinWeight;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89966C", Offset = "0x89966C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89966C", Offset = "0x89966C")]
			public float muscleWeight;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8996C0", Offset = "0x8996C0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8996C0", Offset = "0x8996C0")]
			public float muscleDamper;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899714", Offset = "0x899714")]
			public bool mapPosition;

			[Token(Token = "0x6000783")]
			[Address(RVA = "0x13D4ECC", Offset = "0x13D4ECC", VA = "0x13D4ECC")]
			public Props()
			{
			}

			[Token(Token = "0x6000784")]
			[Address(RVA = "0x13D4F0C", Offset = "0x13D4F0C", VA = "0x13D4F0C")]
			public Props(float pinWeight, float muscleWeight, float mappingWeight, float muscleDamper, bool mapPosition, Group group = Group.Hips)
			{
			}

			[Token(Token = "0x6000785")]
			[Address(RVA = "0x13D401C", Offset = "0x13D401C", VA = "0x13D401C")]
			public void Clamp()
			{
			}
		}

		[Token(Token = "0x20000C8")]
		public struct State
		{
			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float mappingWeightMlp;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float pinWeightMlp;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float muscleWeightMlp;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float maxForceMlp;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float muscleDamperMlp;

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float muscleDamperAdd;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float immunity;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float impulseMlp;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 velocity;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 angularVelocity;

			[Token(Token = "0x170000D7")]
			public static State Default
			{
				[Token(Token = "0x6000786")]
				[Address(RVA = "0x13D26C0", Offset = "0x13D26C0", VA = "0x13D26C0")]
				get
				{
					return default(State);
				}
			}

			[Token(Token = "0x6000787")]
			[Address(RVA = "0x982834", Offset = "0x982834", VA = "0x982834")]
			public void Clamp()
			{
			}
		}

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public string name;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ConfigurableJoint joint;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform target;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Props props;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public State state;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public int[] parentIndexes;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public int[] childIndexes;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public bool[] childFlags;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public int[] kinshipDegrees;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[HideInInspector]
		public MuscleCollisionBroadcaster broadcaster;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public JointBreakBroadcaster jointBreakBroadcaster;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 positionOffset;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x895204", Offset = "0x895204")]
		private Transform <transform>k__BackingField;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x895214", Offset = "0x895214")]
		private Rigidbody <rigidbody>k__BackingField;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x895224", Offset = "0x895224")]
		private Transform <connectedBodyTarget>k__BackingField;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x895234", Offset = "0x895234")]
		private Vector3 <targetAnimatedPosition>k__BackingField;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x895244", Offset = "0x895244")]
		private Vector3 <targetVelocity>k__BackingField;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x895254", Offset = "0x895254")]
		private Vector3 <targetAngularVelocity>k__BackingField;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x895264", Offset = "0x895264")]
		private Vector3 <mappedVelocity>k__BackingField;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x895274", Offset = "0x895274")]
		private Vector3 <mappedAngularVelocity>k__BackingField;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x895284", Offset = "0x895284")]
		private Quaternion <targetRotationRelative>k__BackingField;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private JointDrive slerpDrive;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float lastJointDriveRotationWeight;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private float lastRotationDamper;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Vector3 defaultTargetLocalPosition;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Vector3 lastMappedPosition;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Quaternion localRotationConvert;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Quaternion toParentSpace;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private Quaternion toJointSpaceInverse;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private Quaternion toJointSpaceDefault;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private Quaternion targetAnimatedRotation;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Quaternion targetAnimatedWorldRotation;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private Quaternion rotationRelativeToTarget;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private Quaternion lastMappedRotation;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Transform targetParent;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private Transform connectedBodyTransform;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private ConfigurableJointMotion angularXMotionDefault;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private ConfigurableJointMotion angularYMotionDefault;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private ConfigurableJointMotion angularZMotionDefault;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		private bool directTargetParent;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x215")]
		private bool initiated;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Collider[] _colliders;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private float lastReadTime;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private float lastWriteTime;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private bool[] disabledColliders;

		[Token(Token = "0x17000054")]
		public Transform transform
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x13D1518", Offset = "0x13D1518", VA = "0x13D1518")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CDB8", Offset = "0x89CDB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x13D1520", Offset = "0x13D1520", VA = "0x13D1520")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CDC8", Offset = "0x89CDC8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public Rigidbody rigidbody
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x13D1528", Offset = "0x13D1528", VA = "0x13D1528")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CDD8", Offset = "0x89CDD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x13D1530", Offset = "0x13D1530", VA = "0x13D1530")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CDE8", Offset = "0x89CDE8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public Transform connectedBodyTarget
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x13D1538", Offset = "0x13D1538", VA = "0x13D1538")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CDF8", Offset = "0x89CDF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x13D1540", Offset = "0x13D1540", VA = "0x13D1540")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CE08", Offset = "0x89CE08")]
			private set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public Vector3 targetAnimatedPosition
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x13D1548", Offset = "0x13D1548", VA = "0x13D1548")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CE18", Offset = "0x89CE18")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x13D1554", Offset = "0x13D1554", VA = "0x13D1554")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CE28", Offset = "0x89CE28")]
			private set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public Collider[] colliders
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x13D1560", Offset = "0x13D1560", VA = "0x13D1560")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public Vector3 targetVelocity
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x13D1568", Offset = "0x13D1568", VA = "0x13D1568")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CE38", Offset = "0x89CE38")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x13D1574", Offset = "0x13D1574", VA = "0x13D1574")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CE48", Offset = "0x89CE48")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public Vector3 targetAngularVelocity
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x13D1580", Offset = "0x13D1580", VA = "0x13D1580")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CE58", Offset = "0x89CE58")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x13D158C", Offset = "0x13D158C", VA = "0x13D158C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CE68", Offset = "0x89CE68")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public Vector3 mappedVelocity
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x13D1598", Offset = "0x13D1598", VA = "0x13D1598")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CE78", Offset = "0x89CE78")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x13D15A4", Offset = "0x13D15A4", VA = "0x13D15A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CE88", Offset = "0x89CE88")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public Vector3 mappedAngularVelocity
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x13D15B0", Offset = "0x13D15B0", VA = "0x13D15B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CE98", Offset = "0x89CE98")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x13D15BC", Offset = "0x13D15BC", VA = "0x13D15BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CEA8", Offset = "0x89CEA8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public Quaternion targetRotationRelative
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x13D15C8", Offset = "0x13D15C8", VA = "0x13D15C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CEB8", Offset = "0x89CEB8")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x13D15D8", Offset = "0x13D15D8", VA = "0x13D15D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CEC8", Offset = "0x89CEC8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		private Quaternion localRotation
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x13D28D0", Offset = "0x13D28D0", VA = "0x13D28D0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x1700005F")]
		private Quaternion parentRotation
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x13D2A70", Offset = "0x13D2A70", VA = "0x13D2A70")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000060")]
		private Quaternion targetParentRotation
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x13D29B8", Offset = "0x13D29B8", VA = "0x13D29B8")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000061")]
		private Quaternion targetLocalRotation
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x13D2BC0", Offset = "0x13D2BC0", VA = "0x13D2BC0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x13D15E8", Offset = "0x13D15E8", VA = "0x13D15E8")]
		public bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x13D17CC", Offset = "0x13D17CC", VA = "0x13D17CC", Slot = "4")]
		public virtual void Initiate(Muscle[] colleagues)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x13D26DC", Offset = "0x13D26DC", VA = "0x13D26DC")]
		public void UpdateColliders()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x13D32BC", Offset = "0x13D32BC", VA = "0x13D32BC")]
		public void DisableColliders()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x13D337C", Offset = "0x13D337C", VA = "0x13D337C")]
		public void EnableColliders()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x13D2F60", Offset = "0x13D2F60", VA = "0x13D2F60")]
		private void AddColliders(Transform t, ref Collider[] C, bool includeMeshColliders)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x13D31B4", Offset = "0x13D31B4", VA = "0x13D31B4")]
		private void AddCompoundColliders(Transform t, ref Collider[] colliders)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x13D3428", Offset = "0x13D3428", VA = "0x13D3428")]
		public void IgnoreCollisions(Muscle m, bool ignore)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x13D35F4", Offset = "0x13D35F4", VA = "0x13D35F4")]
		public void IgnoreAngularLimits(bool ignore)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x13D3694", Offset = "0x13D3694", VA = "0x13D3694")]
		public void FixTargetTransforms()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x13D3700", Offset = "0x13D3700", VA = "0x13D3700")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x13D3950", Offset = "0x13D3950", VA = "0x13D3950")]
		public void MoveToTarget()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x13D2CE0", Offset = "0x13D2CE0", VA = "0x13D2CE0")]
		public void Read()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x13D3A84", Offset = "0x13D3A84", VA = "0x13D3A84")]
		public void ClearVelocities()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x13D3B9C", Offset = "0x13D3B9C", VA = "0x13D3B9C")]
		public void UpdateAnchor(bool supportTranslationAnimation)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x13D3F34", Offset = "0x13D3F34", VA = "0x13D3F34", Slot = "5")]
		public virtual void Update(float pinWeightMaster, float muscleWeightMaster, float muscleSpring, float muscleDamper, float pinPow, float pinDistanceFalloff, bool rotationTargetChanged)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x13D46A8", Offset = "0x13D46A8", VA = "0x13D46A8")]
		public void Map(float mappingWeightMaster)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x13D4AA4", Offset = "0x13D4AA4", VA = "0x13D4AA4")]
		public void CalculateMappedVelocity()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x13D41E8", Offset = "0x13D41E8", VA = "0x13D41E8")]
		private void Pin(float pinWeightMaster, float pinPow, float pinDistanceFalloff)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x13D44C4", Offset = "0x13D44C4", VA = "0x13D44C4")]
		private void MuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x13D4C60", Offset = "0x13D4C60", VA = "0x13D4C60")]
		private Quaternion LocalToJointSpace(Quaternion localRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x13D3E14", Offset = "0x13D3E14", VA = "0x13D3E14")]
		private static Vector3 InverseTransformPointUnscaled(Vector3 position, Quaternion rotation, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x13D2800", Offset = "0x13D2800", VA = "0x13D2800")]
		private Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x13D4D54", Offset = "0x13D4D54", VA = "0x13D4D54")]
		public Muscle()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public struct MuscleCollision
	{
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Collision collision;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isStay;

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x982878", Offset = "0x982878", VA = "0x982878")]
		public MuscleCollision(int muscleIndex, Collision collision, bool isStay = false)
		{
		}
	}
	[Token(Token = "0x2000037")]
	public struct MuscleHit
	{
		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float unPin;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3 force;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 position;

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x9828B4", Offset = "0x9828B4", VA = "0x9828B4")]
		public MuscleHit(int muscleIndex, float unPin, Vector3 force, Vector3 position)
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x893068", Offset = "0x893068")]
	public class MuscleCollisionBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		public int muscleIndex;

		[Token(Token = "0x40001D3")]
		private const string onMuscleHit = "OnMuscleHit";

		[Token(Token = "0x40001D4")]
		private const string onMuscleCollision = "OnMuscleCollision";

		[Token(Token = "0x40001D5")]
		private const string onMuscleCollisionExit = "OnMuscleCollisionExit";

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MuscleCollisionBroadcaster otherBroadcaster;

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x13D4FB4", Offset = "0x13D4FB4", VA = "0x13D4FB4")]
		public void Hit(float unPin, Vector3 force, Vector3 position)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x13D50B8", Offset = "0x13D50B8", VA = "0x13D50B8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x13D5270", Offset = "0x13D5270", VA = "0x13D5270")]
		private void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x13D54C4", Offset = "0x13D54C4", VA = "0x13D54C4")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x13D570C", Offset = "0x13D570C", VA = "0x13D570C")]
		public MuscleCollisionBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public static class PhysXTools
	{
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x13D5714", Offset = "0x13D5714", VA = "0x13D5714")]
		public static Vector3 GetCenterOfMass(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x13D590C", Offset = "0x13D590C", VA = "0x13D590C")]
		public static Vector3 GetCenterOfMassVelocity(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x13D5B04", Offset = "0x13D5B04", VA = "0x13D5B04")]
		public static void DivByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x13D5C44", Offset = "0x13D5C44", VA = "0x13D5C44")]
		public static void ScaleByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x13D5D80", Offset = "0x13D5D80", VA = "0x13D5D80")]
		public static Vector3 GetFromToAcceleration(Vector3 fromV, Vector3 toV)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x13D5EE4", Offset = "0x13D5EE4", VA = "0x13D5EE4")]
		public static Vector3 GetAngularAcceleration(Quaternion fromR, Quaternion toR)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x13D6170", Offset = "0x13D6170", VA = "0x13D6170")]
		public static void AddFromToTorque(Rigidbody r, Quaternion toR, ForceMode forceMode)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x13D6420", Offset = "0x13D6420", VA = "0x13D6420")]
		public static void AddFromToTorque(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x13D66D4", Offset = "0x13D66D4", VA = "0x13D66D4")]
		public static void AddFromToForce(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x13D6940", Offset = "0x13D6940", VA = "0x13D6940")]
		public static Vector3 GetLinearAcceleration(Vector3 fromPoint, Vector3 toPoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x13D6A14", Offset = "0x13D6A14", VA = "0x13D6A14")]
		public static Quaternion ToJointSpace(ConfigurableJoint joint)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x13D6B64", Offset = "0x13D6B64", VA = "0x13D6B64")]
		public static Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x13D5C04", Offset = "0x13D5C04", VA = "0x13D5C04")]
		public static Vector3 Div(Vector3 v, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200003A")]
	public class PressureSensor : MonoBehaviour
	{
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool visualize;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask layers;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x895304", Offset = "0x895304")]
		private Vector3 <center>k__BackingField;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x895314", Offset = "0x895314")]
		private bool <inContact>k__BackingField;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x895324", Offset = "0x895324")]
		private Vector3 <bottom>k__BackingField;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x895334", Offset = "0x895334")]
		private Rigidbody <r>k__BackingField;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool fixedFrame;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 P;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int count;

		[Token(Token = "0x17000062")]
		public Vector3 center
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x13D6BC8", Offset = "0x13D6BC8", VA = "0x13D6BC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CED8", Offset = "0x89CED8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x13D6BD4", Offset = "0x13D6BD4", VA = "0x13D6BD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CEE8", Offset = "0x89CEE8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public bool inContact
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x13D6BE0", Offset = "0x13D6BE0", VA = "0x13D6BE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CEF8", Offset = "0x89CEF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x13D6BE8", Offset = "0x13D6BE8", VA = "0x13D6BE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CF08", Offset = "0x89CF08")]
			private set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public Vector3 bottom
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x13D6BF4", Offset = "0x13D6BF4", VA = "0x13D6BF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CF18", Offset = "0x89CF18")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x13D6C00", Offset = "0x13D6C00", VA = "0x13D6C00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CF28", Offset = "0x89CF28")]
			private set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public Rigidbody r
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x13D6C0C", Offset = "0x13D6C0C", VA = "0x13D6C0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CF38", Offset = "0x89CF38")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x13D6C14", Offset = "0x13D6C14", VA = "0x13D6C14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CF48", Offset = "0x89CF48")]
			private set
			{
			}
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x13D6C1C", Offset = "0x13D6C1C", VA = "0x13D6C1C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x13D6CA4", Offset = "0x13D6CA4", VA = "0x13D6CA4")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x13D6EC4", Offset = "0x13D6EC4", VA = "0x13D6EC4")]
		private void OnCollisionStay(Collision c)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x13D6EC8", Offset = "0x13D6EC8", VA = "0x13D6EC8")]
		private void OnCollisionExit(Collision c)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x13D6ED0", Offset = "0x13D6ED0", VA = "0x13D6ED0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x13D6F64", Offset = "0x13D6F64", VA = "0x13D6F64")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x13D6CA8", Offset = "0x13D6CA8", VA = "0x13D6CA8")]
		private void ProcessCollision(Collision c)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x13D7014", Offset = "0x13D7014", VA = "0x13D7014")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x13D7038", Offset = "0x13D7038", VA = "0x13D7038")]
		public PressureSensor()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public abstract class Prop : MonoBehaviour
	{
		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895344", Offset = "0x895344")]
		public int propType;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x89537C", Offset = "0x89537C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89537C", Offset = "0x89537C")]
		public ConfigurableJoint muscle;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8953DC", Offset = "0x8953DC")]
		public Muscle.Props muscleProps;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895414", Offset = "0x895414")]
		public bool forceLayers;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x89544C", Offset = "0x89544C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89544C", Offset = "0x89544C")]
		public ConfigurableJoint additionalPin;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8954AC", Offset = "0x8954AC")]
		public Transform additionalPinTarget;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8954E4", Offset = "0x8954E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8954E4", Offset = "0x8954E4")]
		public float additionalPinWeight;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x895538", Offset = "0x895538")]
		private PropRoot <propRoot>k__BackingField;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ConfigurableJointMotion xMotion;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private ConfigurableJointMotion yMotion;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ConfigurableJointMotion zMotion;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private ConfigurableJointMotion angularXMotion;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ConfigurableJointMotion angularYMotion;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private ConfigurableJointMotion angularZMotion;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Collider[] colliders;

		[Token(Token = "0x17000066")]
		public bool isPickedUp
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x13D7040", Offset = "0x13D7040", VA = "0x13D7040")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000067")]
		public PropRoot propRoot
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x13D70B0", Offset = "0x13D70B0", VA = "0x13D70B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CF58", Offset = "0x89CF58")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x13D70B8", Offset = "0x13D70B8", VA = "0x13D70B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CF68", Offset = "0x89CF68")]
			private set
			{
			}
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x13D70C0", Offset = "0x13D70C0", VA = "0x13D70C0")]
		public void PickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x13D7274", Offset = "0x13D7274", VA = "0x13D7274")]
		public void Drop()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x13D72A8", Offset = "0x13D72A8", VA = "0x13D72A8")]
		public void StartPickedUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x13D72B0", Offset = "0x13D72B0", VA = "0x13D72B0", Slot = "4")]
		protected virtual void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x13D72B4", Offset = "0x13D72B4", VA = "0x13D72B4", Slot = "5")]
		protected virtual void OnDrop()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x13D72B8", Offset = "0x13D72B8", VA = "0x13D72B8", Slot = "6")]
		protected virtual void OnStart()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x13D72BC", Offset = "0x13D72BC", VA = "0x13D72BC", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x13D74A8", Offset = "0x13D74A8", VA = "0x13D74A8")]
		private void Start()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x13D74E0", Offset = "0x13D74E0", VA = "0x13D74E0")]
		private void ReleaseJoint()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x13D762C", Offset = "0x13D762C", VA = "0x13D762C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x13D77DC", Offset = "0x13D77DC", VA = "0x13D77DC")]
		protected Prop()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8930A0", Offset = "0x8930A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8930A0", Offset = "0x8930A0")]
	public class PropRoot : MonoBehaviour
	{
		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895548", Offset = "0x895548")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895580", Offset = "0x895580")]
		public Rigidbody connectTo;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8955B8", Offset = "0x8955B8")]
		public Prop currentProp;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Prop lastProp;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool fixedUpdateCalled;

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x13D78A0", Offset = "0x13D78A0", VA = "0x13D78A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89CF78", Offset = "0x89CF78")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x13D78EC", Offset = "0x13D78EC", VA = "0x13D78EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89CFB0", Offset = "0x89CFB0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x13D7938", Offset = "0x13D7938", VA = "0x13D7938")]
		public void DropImmediate()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x13D87DC", Offset = "0x13D87DC", VA = "0x13D87DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x13D8874", Offset = "0x13D8874", VA = "0x13D8874")]
		private void Update()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x13D89E4", Offset = "0x13D89E4", VA = "0x13D89E4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x13D8BE8", Offset = "0x13D8BE8", VA = "0x13D8BE8")]
		public void AttachProp(Prop prop)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x13D9754", Offset = "0x13D9754", VA = "0x13D9754")]
		public PropRoot()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x893100", Offset = "0x893100")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x893100", Offset = "0x893100")]
	public class PropTemplate : Prop
	{
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x13D975C", Offset = "0x13D975C", VA = "0x13D975C", Slot = "6")]
		protected override void OnStart()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x13D9760", Offset = "0x13D9760", VA = "0x13D9760", Slot = "4")]
		protected override void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x13D9764", Offset = "0x13D9764", VA = "0x13D9764", Slot = "5")]
		protected override void OnDrop()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x13D9768", Offset = "0x13D9768", VA = "0x13D9768")]
		public PropTemplate()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x893160", Offset = "0x893160")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x893160", Offset = "0x893160")]
	public class PuppetMaster : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C9")]
		public enum Mode
		{
			[Token(Token = "0x40005D8")]
			Active,
			[Token(Token = "0x40005D9")]
			Kinematic,
			[Token(Token = "0x40005DA")]
			Disabled
		}

		[Token(Token = "0x20000CA")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000CB")]
		public delegate void MuscleDelegate(Muscle muscle);

		[Serializable]
		[Token(Token = "0x20000CC")]
		public enum UpdateMode
		{
			[Token(Token = "0x40005DC")]
			Normal,
			[Token(Token = "0x40005DD")]
			AnimatePhysics,
			[Token(Token = "0x40005DE")]
			FixedUpdate
		}

		[Serializable]
		[Token(Token = "0x20000CD")]
		public enum State
		{
			[Token(Token = "0x40005E0")]
			Alive,
			[Token(Token = "0x40005E1")]
			Dead,
			[Token(Token = "0x40005E2")]
			Frozen
		}

		[Serializable]
		[Token(Token = "0x20000CE")]
		public struct StateSettings
		{
			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89974C", Offset = "0x89974C")]
			public float killDuration;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899784", Offset = "0x899784")]
			public float deadMuscleWeight;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8997BC", Offset = "0x8997BC")]
			public float deadMuscleDamper;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8997F4", Offset = "0x8997F4")]
			public float maxFreezeSqrVelocity;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89982C", Offset = "0x89982C")]
			public bool freezePermanently;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899864", Offset = "0x899864")]
			public bool enableAngularLimitsOnKill;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89989C", Offset = "0x89989C")]
			public bool enableInternalCollisionsOnKill;

			[Token(Token = "0x170000D8")]
			public static StateSettings Default
			{
				[Token(Token = "0x6000791")]
				[Address(RVA = "0x13D9C70", Offset = "0x13D9C70", VA = "0x13D9C70")]
				get
				{
					return default(StateSettings);
				}
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x982960", Offset = "0x982960", VA = "0x982960")]
			public StateSettings(float killDuration, float deadMuscleWeight = 0.01f, float deadMuscleDamper = 2f, float maxFreezeSqrVelocity = 0.02f, bool freezePermanently = false, bool enableAngularLimitsOnKill = true, bool enableInternalCollisionsOnKill = true)
			{
			}
		}

		[Token(Token = "0x20000CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x893CA0", Offset = "0x893CA0")]
		private sealed class <DisabledToActive>d__127 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x170000D9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000795")]
				[Address(RVA = "0x13E5C44", Offset = "0x13E5C44", VA = "0x13E5C44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000797")]
				[Address(RVA = "0x13E5CAC", Offset = "0x13E5CAC", VA = "0x13E5CAC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x13E0258", Offset = "0x13E0258", VA = "0x13E0258")]
			[DebuggerHidden]
			public <DisabledToActive>d__127(int <>1__state)
			{
			}

			[Token(Token = "0x6000793")]
			[Address(RVA = "0x13E5998", Offset = "0x13E5998", VA = "0x13E5998", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x13E599C", Offset = "0x13E599C", VA = "0x13E599C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0x13E5C4C", Offset = "0x13E5C4C", VA = "0x13E5C4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x893CB0", Offset = "0x893CB0")]
		private sealed class <KinematicToActive>d__129 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x170000DB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600079B")]
				[Address(RVA = "0x13E5EC4", Offset = "0x13E5EC4", VA = "0x13E5EC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600079D")]
				[Address(RVA = "0x13E5F2C", Offset = "0x13E5F2C", VA = "0x13E5F2C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000798")]
			[Address(RVA = "0x13E0284", Offset = "0x13E0284", VA = "0x13E0284")]
			[DebuggerHidden]
			public <KinematicToActive>d__129(int <>1__state)
			{
			}

			[Token(Token = "0x6000799")]
			[Address(RVA = "0x13E5CB4", Offset = "0x13E5CB4", VA = "0x13E5CB4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x13E5CB8", Offset = "0x13E5CB8", VA = "0x13E5CB8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0x13E5ECC", Offset = "0x13E5ECC", VA = "0x13E5ECC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x893CC0", Offset = "0x893CC0")]
		private sealed class <ActiveToDisabled>d__130 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x170000DD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007A1")]
				[Address(RVA = "0x13E530C", Offset = "0x13E530C", VA = "0x13E530C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007A3")]
				[Address(RVA = "0x13E5374", Offset = "0x13E5374", VA = "0x13E5374", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600079E")]
			[Address(RVA = "0x13E02B0", Offset = "0x13E02B0", VA = "0x13E02B0")]
			[DebuggerHidden]
			public <ActiveToDisabled>d__130(int <>1__state)
			{
			}

			[Token(Token = "0x600079F")]
			[Address(RVA = "0x13E51A0", Offset = "0x13E51A0", VA = "0x13E51A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x13E51A4", Offset = "0x13E51A4", VA = "0x13E51A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x13E5314", Offset = "0x13E5314", VA = "0x13E5314", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x893CD0", Offset = "0x893CD0")]
		private sealed class <ActiveToKinematic>d__131 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x170000DF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007A7")]
				[Address(RVA = "0x13E551C", Offset = "0x13E551C", VA = "0x13E551C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007A9")]
				[Address(RVA = "0x13E5584", Offset = "0x13E5584", VA = "0x13E5584", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x13E02DC", Offset = "0x13E02DC", VA = "0x13E02DC")]
			[DebuggerHidden]
			public <ActiveToKinematic>d__131(int <>1__state)
			{
			}

			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x13E537C", Offset = "0x13E537C", VA = "0x13E537C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x13E5380", Offset = "0x13E5380", VA = "0x13E5380", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x13E5524", Offset = "0x13E5524", VA = "0x13E5524", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x893CE0", Offset = "0x893CE0")]
		private sealed class <AliveToDead>d__183 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool freeze;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <range>5__2;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <mW>5__3;

			[Token(Token = "0x170000E1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007AD")]
				[Address(RVA = "0x13E5928", Offset = "0x13E5928", VA = "0x13E5928", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007AF")]
				[Address(RVA = "0x13E5990", Offset = "0x13E5990", VA = "0x13E5990", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x13E3ADC", Offset = "0x13E3ADC", VA = "0x13E3ADC")]
			[DebuggerHidden]
			public <AliveToDead>d__183(int <>1__state)
			{
			}

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x13E558C", Offset = "0x13E558C", VA = "0x13E558C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x13E5590", Offset = "0x13E5590", VA = "0x13E5590", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x13E5930", Offset = "0x13E5930", VA = "0x13E5930", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895600", Offset = "0x895600")]
		public PuppetMasterHumanoidConfig humanoidConfig;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform targetRoot;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x895638", Offset = "0x895638")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895638", Offset = "0x895638")]
		public State state;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x895698", Offset = "0x895698")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895698", Offset = "0x895698")]
		public StateSettings stateSettings;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895714", Offset = "0x895714")]
		public Mode mode;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89574C", Offset = "0x89574C")]
		public float blendTime;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895784", Offset = "0x895784")]
		public bool fixTargetTransforms;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8957BC", Offset = "0x8957BC")]
		public int solverIterationCount;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8957F4", Offset = "0x8957F4")]
		public bool visualizeTargetPose;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x89582C", Offset = "0x89582C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89582C", Offset = "0x89582C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89582C", Offset = "0x89582C")]
		public float mappingWeight;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8958A4", Offset = "0x8958A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8958A4", Offset = "0x8958A4")]
		public float pinWeight;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8958F8", Offset = "0x8958F8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8958F8", Offset = "0x8958F8")]
		public float muscleWeight;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x89594C", Offset = "0x89594C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89594C", Offset = "0x89594C")]
		public float muscleSpring;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8959AC", Offset = "0x8959AC")]
		public float muscleDamper;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8959E4", Offset = "0x8959E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8959E4", Offset = "0x8959E4")]
		public float pinPow;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895A38", Offset = "0x895A38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x895A38", Offset = "0x895A38")]
		public float pinDistanceFalloff;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895A90", Offset = "0x895A90")]
		public bool updateJointAnchors;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895AC8", Offset = "0x895AC8")]
		public bool supportTranslationAnimation;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895B00", Offset = "0x895B00")]
		public bool angularLimits;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895B38", Offset = "0x895B38")]
		public bool internalCollisions;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x895B70", Offset = "0x895B70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895B70", Offset = "0x895B70")]
		public Muscle[] muscles;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnRead;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnWrite;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public UpdateDelegate OnPostLateUpdate;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnHierarchyChanged;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public MuscleDelegate OnMuscleRemoved;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Animator targetAnimator;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool AllowAnimatorControl;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x895BD0", Offset = "0x895BD0")]
		private Animation <targetAnimation>k__BackingField;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x895BE0", Offset = "0x895BE0")]
		private BehaviourBase[] <behaviours>k__BackingField;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x895BF0", Offset = "0x895BF0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[HideInInspector]
		public List<SolverManager> solvers;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool internalCollisionsEnabled;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		private bool angularLimitsEnabled;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		private bool fixedFrame;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private int lastSolverIterationCount;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool isLegacy;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		private bool animatorDisabled;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		private bool awakeFailed;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFB")]
		private bool interpolated;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private bool freezeFlag;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
		private bool hasBeenDisabled;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFE")]
		private bool hierarchyIsFlat;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFF")]
		private bool teleport;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Vector3 teleportPosition;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private Quaternion teleportRotation;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private bool teleportMoveToTarget;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x895C10", Offset = "0x895C10")]
		private bool <isSwitchingMode>k__BackingField;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public Mode activeMode;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Mode lastMode;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public float mappingBlend;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x895C20", Offset = "0x895C20")]
		private bool <isKilling>k__BackingField;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public UpdateDelegate OnFreeze;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public UpdateDelegate OnUnfreeze;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public UpdateDelegate OnDeath;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public UpdateDelegate OnResurrection;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private State activeState;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private State lastState;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private bool angularLimitsEnabledOnKill;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
		private bool internalCollisionsEnabledOnKill;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15A")]
		private bool animationDisabledbyStates;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15B")]
		[HideInInspector]
		public bool storeTargetMappedState;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Transform[] targetChildren;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Vector3[] targetMappedPositions;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Quaternion[] targetMappedRotations;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Vector3[] targetSampledPositions;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Quaternion[] targetSampledRotations;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private bool targetMappedStateStored;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x189")]
		private bool targetMappedStateSampled;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18A")]
		private bool sampleTargetMappedState;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18B")]
		private bool hasProp;

		[Token(Token = "0x17000068")]
		public Animation targetAnimation
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x13D9C98", Offset = "0x13D9C98", VA = "0x13D9C98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89D190", Offset = "0x89D190")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x13D9CA0", Offset = "0x13D9CA0", VA = "0x13D9CA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89D1A0", Offset = "0x89D1A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public BehaviourBase[] behaviours
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x13D9CA8", Offset = "0x13D9CA8", VA = "0x13D9CA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89D1B0", Offset = "0x89D1B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x13D9CB0", Offset = "0x13D9CB0", VA = "0x13D9CB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89D1C0", Offset = "0x89D1C0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public bool isActive
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x13D9CB8", Offset = "0x13D9CB8", VA = "0x13D9CB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006B")]
		public bool initiated
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x13D9D3C", Offset = "0x13D9D3C", VA = "0x13D9D3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89D1D0", Offset = "0x89D1D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x13D9D44", Offset = "0x13D9D44", VA = "0x13D9D44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89D1E0", Offset = "0x89D1E0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public UpdateMode updateMode
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x13D9D50", Offset = "0x13D9D50", VA = "0x13D9D50")]
			get
			{
				return default(UpdateMode);
			}
		}

		[Token(Token = "0x1700006D")]
		public bool controlsAnimator
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x13D9E7C", Offset = "0x13D9E7C", VA = "0x13D9E7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006E")]
		public bool isBlending
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x13D9D18", Offset = "0x13D9D18", VA = "0x13D9D18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006F")]
		private AnimatorUpdateMode targetUpdateMode
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x13D9D90", Offset = "0x13D9D90", VA = "0x13D9D90")]
			get
			{
				return default(AnimatorUpdateMode);
			}
		}

		[Token(Token = "0x17000070")]
		public bool isSwitchingMode
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x13DFC74", Offset = "0x13DFC74", VA = "0x13DFC74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89D298", Offset = "0x89D298")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x13DFC7C", Offset = "0x13DFC7C", VA = "0x13DFC7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89D2A8", Offset = "0x89D2A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public bool isSwitchingState
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x13D9EDC", Offset = "0x13D9EDC", VA = "0x13D9EDC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000072")]
		public bool isKilling
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x13E34F0", Offset = "0x13E34F0", VA = "0x13E34F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89D448", Offset = "0x89D448")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x13E34F8", Offset = "0x13E34F8", VA = "0x13E34F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89D458", Offset = "0x89D458")]
			private set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public bool isAlive
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x13DE494", Offset = "0x13DE494", VA = "0x13DE494")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000074")]
		public bool isFrozen
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x13DDB4C", Offset = "0x13DDB4C", VA = "0x13DDB4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000011")]
		public event Action OnAfterBoneUpdate
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x13D976C", Offset = "0x13D976C", VA = "0x13D976C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CFE8", Offset = "0x89CFE8")]
			add
			{
			}
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x13D9810", Offset = "0x13D9810", VA = "0x13D9810")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89CFF8", Offset = "0x89CFF8")]
			remove
			{
			}
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x13D98B4", Offset = "0x13D98B4", VA = "0x13D98B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D008", Offset = "0x89D008")]
		private void OpenUserManualSetup()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x13D9900", Offset = "0x13D9900", VA = "0x13D9900")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D040", Offset = "0x89D040")]
		private void OpenUserManualComponent()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x13D994C", Offset = "0x13D994C", VA = "0x13D994C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D078", Offset = "0x89D078")]
		private void OpenUserManualPerformance()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x13D9998", Offset = "0x13D9998", VA = "0x13D9998")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D0B0", Offset = "0x89D0B0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x13D99E4", Offset = "0x13D99E4", VA = "0x13D99E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D0E8", Offset = "0x89D0E8")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x13D9A30", Offset = "0x13D9A30", VA = "0x13D9A30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D120", Offset = "0x89D120")]
		private void OpenComponentTutorial()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x13D9A7C", Offset = "0x13D9A7C", VA = "0x13D9A7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D158", Offset = "0x89D158")]
		private void AutoConnectMuscleTargets()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x13D9C54", Offset = "0x13D9C54", VA = "0x13D9C54")]
		private void ResetStateSettings()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x13D9EF0", Offset = "0x13D9EF0", VA = "0x13D9EF0")]
		public void Teleport(Vector3 position, Quaternion rotation, bool moveToTarget)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x13D9F20", Offset = "0x13D9F20", VA = "0x13D9F20")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x13D9FC8", Offset = "0x13D9FC8", VA = "0x13D9FC8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x13DA704", Offset = "0x13DA704", VA = "0x13DA704")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x13DAFDC", Offset = "0x13DAFDC", VA = "0x13DAFDC")]
		private void Start()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x13DB084", Offset = "0x13DB084", VA = "0x13DB084")]
		public Transform FindTargetRootRecursive(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x13DA748", Offset = "0x13DA748", VA = "0x13DA748")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x13DC834", Offset = "0x13DC834", VA = "0x13DC834")]
		private void ActivateBehaviour(BehaviourBase behaviour)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x13DCB3C", Offset = "0x13DCB3C", VA = "0x13DCB3C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x13DCC94", Offset = "0x13DCC94", VA = "0x13DCC94")]
		private bool IsInterpolated()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x13DCD20", Offset = "0x13DCD20", VA = "0x13DCD20", Slot = "4")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x13DDCF0", Offset = "0x13DDCF0", VA = "0x13DDCF0", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x13DDD68", Offset = "0x13DDD68", VA = "0x13DDD68", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x13DDDB8", Offset = "0x13DDDB8", VA = "0x13DDDB8", Slot = "7")]
		protected virtual void OnLateUpdate()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x13DE05C", Offset = "0x13DE05C", VA = "0x13DE05C")]
		private void MoveToTarget()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x13DD2B8", Offset = "0x13DD2B8", VA = "0x13DD2B8")]
		public void Read()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x13DD12C", Offset = "0x13DD12C", VA = "0x13DD12C")]
		private void FixTargetTransforms()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x13DE4A4", Offset = "0x13DE4A4", VA = "0x13DE4A4")]
		private void VisualizeTargetPose()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x13DE74C", Offset = "0x13DE74C", VA = "0x13DE74C")]
		private void VisualizeHierarchy(Transform t, Color color)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x13DDB5C", Offset = "0x13DDB5C", VA = "0x13DDB5C")]
		private void SetInternalCollisions(bool collide)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x13DDC54", Offset = "0x13DDC54", VA = "0x13DDC54")]
		private void SetAngularLimits(bool limited)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x13D8E24", Offset = "0x13D8E24", VA = "0x13D8E24")]
		public void AddMuscle(ConfigurableJoint joint, Transform target, Rigidbody connectTo, Transform targetParent, [Optional] Muscle.Props muscleProps, bool forceTreeHierarchy = false, bool forceLayers = true)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x13D7A38", Offset = "0x13D7A38", VA = "0x13D7A38")]
		public void RemoveMuscleRecursive(ConfigurableJoint joint, bool attachTarget, bool blockTargetAnimation = false, MuscleRemoveMode removeMode = MuscleRemoveMode.Sever)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x13DF4C4", Offset = "0x13DF4C4", VA = "0x13DF4C4")]
		public void ReplaceMuscle(ConfigurableJoint oldJoint, ConfigurableJoint newJoint)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x13DF564", Offset = "0x13DF564", VA = "0x13DF564")]
		public void SetMuscles(Muscle[] newMuscles)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x13DF604", Offset = "0x13DF604", VA = "0x13DF604")]
		public void DisableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x13DF6A4", Offset = "0x13DF6A4", VA = "0x13DF6A4")]
		public void EnableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x13DF744", Offset = "0x13DF744", VA = "0x13DF744")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D1F0", Offset = "0x89D1F0")]
		public void FlattenHierarchy()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x13DF854", Offset = "0x13DF854", VA = "0x13DF854")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D228", Offset = "0x89D228")]
		public void TreeHierarchy()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x13DF9C8", Offset = "0x13DF9C8", VA = "0x13DF9C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D260", Offset = "0x89D260")]
		public void FixMusclePositions()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x13DFB04", Offset = "0x13DFB04", VA = "0x13DFB04")]
		private void AddIndexesRecursive(int index, ref int[] indexes)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x13DC334", Offset = "0x13DC334", VA = "0x13DC334")]
		private bool HierarchyIsFlat()
		{
			return default(bool);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x13DEFAC", Offset = "0x13DEFAC", VA = "0x13DEFAC")]
		private void DisconnectJoint(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x13DF044", Offset = "0x13DF044", VA = "0x13DF044")]
		private void KillJoint(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x13DFC88", Offset = "0x13DFC88", VA = "0x13DFC88")]
		public void DisableImmediately()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x13DFD24", Offset = "0x13DFD24", VA = "0x13DFD24", Slot = "8")]
		protected virtual void SwitchModes()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x13DFE88", Offset = "0x13DFE88", VA = "0x13DFE88")]
		private void DisabledToKinematic()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x13DFFCC", Offset = "0x13DFFCC", VA = "0x13DFFCC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x89D2B8", Offset = "0x89D2B8")]
		private IEnumerator DisabledToActive()
		{
			return null;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x13E0048", Offset = "0x13E0048", VA = "0x13E0048")]
		private void KinematicToDisabled()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x13E00E4", Offset = "0x13E00E4", VA = "0x13E00E4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x89D31C", Offset = "0x89D31C")]
		private IEnumerator KinematicToActive()
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x13E0160", Offset = "0x13E0160", VA = "0x13E0160")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x89D380", Offset = "0x89D380")]
		private IEnumerator ActiveToDisabled()
		{
			return null;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x13E01DC", Offset = "0x13E01DC", VA = "0x13E01DC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x89D3E4", Offset = "0x89D3E4")]
		private IEnumerator ActiveToKinematic()
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x13E0308", Offset = "0x13E0308", VA = "0x13E0308")]
		public void UpdateInternalCollisions()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x13E03D8", Offset = "0x13E03D8", VA = "0x13E03D8")]
		public void SetMuscleWeights(Muscle.Group group, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x13E04A8", Offset = "0x13E04A8", VA = "0x13E04A8")]
		public void SetMuscleWeights(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x13E08DC", Offset = "0x13E08DC", VA = "0x13E08DC")]
		public void SetMuscleWeights(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x13E0B7C", Offset = "0x13E0B7C", VA = "0x13E0B7C")]
		public void SetMuscleWeightsRecursive(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x13E0CB0", Offset = "0x13E0CB0", VA = "0x13E0CB0")]
		public void SetMuscleWeightsRecursive(int muscleIndex, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x13E0D9C", Offset = "0x13E0D9C", VA = "0x13E0D9C")]
		public void SetMuscleWeightsRecursive(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x13E0708", Offset = "0x13E0708", VA = "0x13E0708")]
		public void SetMuscleWeights(int muscleIndex, float muscleWeight, float pinWeight, float mappingWeight, float muscleDamper)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x13E0E24", Offset = "0x13E0E24", VA = "0x13E0E24")]
		public Muscle GetMuscle(Transform target)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x13DEA4C", Offset = "0x13DEA4C", VA = "0x13DEA4C")]
		public Muscle GetMuscle(Rigidbody rigidbody)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x13E1058", Offset = "0x13E1058", VA = "0x13E1058")]
		public Muscle GetMuscle(ConfigurableJoint joint)
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x13DE95C", Offset = "0x13DE95C", VA = "0x13DE95C")]
		public bool ContainsJoint(ConfigurableJoint joint)
		{
			return default(bool);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x13E0964", Offset = "0x13E0964", VA = "0x13E0964")]
		public int GetMuscleIndex(HumanBodyBones humanBodyBone)
		{
			return default(int);
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x13E0530", Offset = "0x13E0530", VA = "0x13E0530")]
		public int GetMuscleIndex(Transform target)
		{
			return default(int);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x13E0E80", Offset = "0x13E0E80", VA = "0x13E0E80")]
		public int GetMuscleIndex(Rigidbody rigidbody)
		{
			return default(int);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x13DEDD4", Offset = "0x13DEDD4", VA = "0x13DEDD4")]
		public int GetMuscleIndex(ConfigurableJoint joint)
		{
			return default(int);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x13E10B4", Offset = "0x13E10B4", VA = "0x13E10B4")]
		public static PuppetMaster SetUp(Transform target, Transform ragdoll, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x13E1C94", Offset = "0x13E1C94", VA = "0x13E1C94")]
		public static PuppetMaster SetUp(Transform target, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x13E11A8", Offset = "0x13E11A8", VA = "0x13E11A8")]
		public void SetUpTo(Transform setUpTo, int characterControllerLayer, int ragdollLayer)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x13E1DF4", Offset = "0x13E1DF4", VA = "0x13E1DF4")]
		public static void RemoveRagdollComponents(Transform target, int characterControllerLayer)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x13E2618", Offset = "0x13E2618", VA = "0x13E2618")]
		private void SetUpMuscles(Transform setUpTo)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x13E3038", Offset = "0x13E3038", VA = "0x13E3038")]
		private static Muscle.Group FindGroup(Animator animator, Transform t)
		{
			return default(Muscle.Group);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x13E221C", Offset = "0x13E221C", VA = "0x13E221C")]
		private void RemoveUnnecessaryBones()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x13E2D24", Offset = "0x13E2D24", VA = "0x13E2D24")]
		private static bool IsClothCollider(Collider collider, Cloth[] cloths)
		{
			return default(bool);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x13E3504", Offset = "0x13E3504", VA = "0x13E3504")]
		public void Kill()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x13E3510", Offset = "0x13E3510", VA = "0x13E3510")]
		public void Kill(StateSettings stateSettings)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x13E352C", Offset = "0x13E352C", VA = "0x13E352C")]
		public void Freeze()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x13E3538", Offset = "0x13E3538", VA = "0x13E3538")]
		public void Freeze(StateSettings stateSettings)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x13E3554", Offset = "0x13E3554", VA = "0x13E3554")]
		public void Resurrect()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x13E355C", Offset = "0x13E355C", VA = "0x13E355C", Slot = "9")]
		protected virtual void SwitchStates()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x13E365C", Offset = "0x13E365C", VA = "0x13E365C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x89D468", Offset = "0x89D468")]
		private IEnumerator AliveToDead(bool freeze)
		{
			return null;
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x13DE1F0", Offset = "0x13DE1F0", VA = "0x13DE1F0")]
		private void OnFreezeFlag()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x13E36EC", Offset = "0x13E36EC", VA = "0x13E36EC")]
		private void DeadToAlive()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x13DA430", Offset = "0x13DA430", VA = "0x13DA430")]
		private void SetAnimationEnabled(bool to)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x13E37F8", Offset = "0x13E37F8", VA = "0x13E37F8")]
		private void DeadToFrozen()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x13E3804", Offset = "0x13E3804", VA = "0x13E3804")]
		private void FrozenToAlive()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x13E3A0C", Offset = "0x13E3A0C", VA = "0x13E3A0C")]
		private void FrozenToDead()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x13DA530", Offset = "0x13DA530", VA = "0x13DA530")]
		private void ActivateRagdoll(bool kinematic = false)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x13E3B08", Offset = "0x13E3B08", VA = "0x13E3B08")]
		private bool CanFreeze()
		{
			return default(bool);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x13E3BC4", Offset = "0x13E3BC4", VA = "0x13E3BC4")]
		public void SampleTargetMappedState()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x13E3CB8", Offset = "0x13E3CB8", VA = "0x13E3CB8")]
		public void FixTargetToSampledState(float weight)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x13DC444", Offset = "0x13DC444", VA = "0x13DC444")]
		public void StoreTargetMappedState()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x13DC108", Offset = "0x13DC108", VA = "0x13DC108")]
		private void UpdateHierarchies()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x13E479C", Offset = "0x13E479C", VA = "0x13E479C")]
		private bool HasProp()
		{
			return default(bool);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x13E4630", Offset = "0x13E4630", VA = "0x13E4630")]
		private void UpdateBroadcasterMuscleIndexes()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x13E41FC", Offset = "0x13E41FC", VA = "0x13E41FC")]
		private void AssignParentAndChildIndexes()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x13E4814", Offset = "0x13E4814", VA = "0x13E4814")]
		private void AddToParentsRecursive(ConfigurableJoint joint, ref int[] indexes)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x13E498C", Offset = "0x13E498C", VA = "0x13E498C")]
		private void AddToChildrenRecursive(ConfigurableJoint joint, ref int[] indexes, ref bool[] childFlags)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x13E4518", Offset = "0x13E4518", VA = "0x13E4518")]
		private void AssignKinshipDegrees()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x13E4C6C", Offset = "0x13E4C6C", VA = "0x13E4C6C")]
		private void AssignKinshipsDownRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x13E4DD0", Offset = "0x13E4DD0", VA = "0x13E4DD0")]
		private void AssignKinshipsUpRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x13E4B90", Offset = "0x13E4B90", VA = "0x13E4B90")]
		private int GetMuscleIndexLowLevel(ConfigurableJoint joint)
		{
			return default(int);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x13DB408", Offset = "0x13DB408", VA = "0x13DB408")]
		public bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x13DEAA8", Offset = "0x13DEAA8", VA = "0x13DEAA8")]
		private bool CheckMassVariation(float threshold, bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x13DE8CC", Offset = "0x13DE8CC", VA = "0x13DE8CC")]
		private bool CheckIfInitiated()
		{
			return default(bool);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x13E5034", Offset = "0x13E5034", VA = "0x13E5034")]
		public PuppetMaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003F")]
	public enum MuscleRemoveMode
	{
		[Token(Token = "0x400023F")]
		Sever,
		[Token(Token = "0x4000240")]
		Explode,
		[Token(Token = "0x4000241")]
		Numb
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x8931C0", Offset = "0x8931C0")]
	public class PuppetMasterHumanoidConfig : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x20000D4")]
		public class HumanoidMuscle
		{
			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			[HideInInspector]
			public string name;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Muscle.Props props;

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x13E61DC", Offset = "0x13E61DC", VA = "0x13E61DC")]
			public HumanoidMuscle()
			{
			}
		}

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x895C40", Offset = "0x895C40")]
		public PuppetMaster.State state;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PuppetMaster.StateSettings stateSettings;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PuppetMaster.Mode mode;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float blendTime;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool fixTargetTransforms;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int solverIterationCount;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool visualizeTargetPose;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x895C78", Offset = "0x895C78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x895C78", Offset = "0x895C78")]
		public float mappingWeight;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x895CCC", Offset = "0x895CCC")]
		public float pinWeight;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x895CE4", Offset = "0x895CE4")]
		public float muscleWeight;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x895CFC", Offset = "0x895CFC")]
		public float muscleSpring;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float muscleDamper;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x895D34", Offset = "0x895D34")]
		public float pinPow;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x895D4C", Offset = "0x895D4C")]
		public float pinDistanceFalloff;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool updateJointAnchors;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool supportTranslationAnimation;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool angularLimits;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		public bool internalCollisions;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x895D68", Offset = "0x895D68")]
		public HumanoidMuscle[] muscles;

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x13DBDC4", Offset = "0x13DBDC4", VA = "0x13DBDC4")]
		public void ApplyTo(PuppetMaster p)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x13E5FE8", Offset = "0x13E5FE8", VA = "0x13E5FE8")]
		private Muscle GetMuscle(HumanBodyBones boneId, Animator animator, PuppetMaster puppetMaster)
		{
			return null;
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x13E611C", Offset = "0x13E611C", VA = "0x13E611C")]
		public PuppetMasterHumanoidConfig()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x89322C", Offset = "0x89322C")]
	public class PuppetMasterSettings : Singleton<PuppetMasterSettings>
	{
		[Serializable]
		[Token(Token = "0x20000D5")]
		public class PuppetUpdateLimit
		{
			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89990C", Offset = "0x89990C")]
			public int puppetsPerFrame;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int index;

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x13E6734", Offset = "0x13E6734", VA = "0x13E6734")]
			public PuppetUpdateLimit()
			{
			}

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x13E6564", Offset = "0x13E6564", VA = "0x13E6564")]
			public void Step(int puppetCount)
			{
			}

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x13E621C", Offset = "0x13E621C", VA = "0x13E621C")]
			public bool Update(List<PuppetMaster> puppets, PuppetMaster puppetMaster)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x895DA0", Offset = "0x895DA0")]
		public PuppetUpdateLimit kinematicCollidersUpdateLimit;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PuppetUpdateLimit freeUpdateLimit;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PuppetUpdateLimit fixedUpdateLimit;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool collisionStayMessages;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool collisionExitMessages;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float activePuppetCollisionThresholdMlp;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x895DD8", Offset = "0x895DD8")]
		private int <currentlyActivePuppets>k__BackingField;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x895DE8", Offset = "0x895DE8")]
		private int <currentlyKinematicPuppets>k__BackingField;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x895DF8", Offset = "0x895DF8")]
		private int <currentlyDisabledPuppets>k__BackingField;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<PuppetMaster> _puppets;

		[Token(Token = "0x17000075")]
		public int currentlyActivePuppets
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x13E61E4", Offset = "0x13E61E4", VA = "0x13E61E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89D4CC", Offset = "0x89D4CC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x13E61EC", Offset = "0x13E61EC", VA = "0x13E61EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89D4DC", Offset = "0x89D4DC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public int currentlyKinematicPuppets
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x13E61F4", Offset = "0x13E61F4", VA = "0x13E61F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89D4EC", Offset = "0x89D4EC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x13E61FC", Offset = "0x13E61FC", VA = "0x13E61FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89D4FC", Offset = "0x89D4FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public int currentlyDisabledPuppets
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x13E6204", Offset = "0x13E6204", VA = "0x13E6204")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89D50C", Offset = "0x89D50C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x13E620C", Offset = "0x13E620C", VA = "0x13E620C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89D51C", Offset = "0x89D51C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public List<PuppetMaster> puppets
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x13E6214", Offset = "0x13E6214", VA = "0x13E6214")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x13DC79C", Offset = "0x13DC79C", VA = "0x13DC79C")]
		public void Register(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x13DCC2C", Offset = "0x13DCC2C", VA = "0x13DCC2C")]
		public void Unregister(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x13DE470", Offset = "0x13DE470", VA = "0x13DE470")]
		public bool UpdateMoveToTarget(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x13E6334", Offset = "0x13E6334", VA = "0x13E6334")]
		public bool UpdateFree(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x13E6358", Offset = "0x13E6358", VA = "0x13E6358")]
		public bool UpdateFixed(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x13E637C", Offset = "0x13E637C", VA = "0x13E637C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x13E6580", Offset = "0x13E6580", VA = "0x13E6580")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x13E65F0", Offset = "0x13E65F0", VA = "0x13E65F0")]
		public PuppetMasterSettings()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public static class PuppetMasterTools
	{
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x13E6760", Offset = "0x13E6760", VA = "0x13E6760")]
		public static void PositionRagdoll(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x13E6DE8", Offset = "0x13E6DE8", VA = "0x13E6DE8")]
		public static void RealignRagdoll(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x13E76EC", Offset = "0x13E76EC", VA = "0x13E76EC")]
		private static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x13E77A4", Offset = "0x13E77A4", VA = "0x13E77A4")]
		private static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public class Weight
	{
		[Serializable]
		[Token(Token = "0x20000D6")]
		public enum Mode
		{
			[Token(Token = "0x4000602")]
			Float,
			[Token(Token = "0x4000603")]
			Curve
		}

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mode mode;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float floatValue;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve curve;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string tooltip;

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x10E1E60", Offset = "0x10E1E60", VA = "0x10E1E60")]
		public Weight(float floatValue)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x10E1ED4", Offset = "0x10E1ED4", VA = "0x10E1ED4")]
		public Weight(float floatValue, string tooltip)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x10E1F64", Offset = "0x10E1F64", VA = "0x10E1F64")]
		public float GetValue(float param)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x893264", Offset = "0x893264")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x893264", Offset = "0x893264")]
	public class BipedRagdollCreator : RagdollCreator
	{
		[Serializable]
		[Token(Token = "0x20000D7")]
		public struct Options
		{
			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float weight;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x899928", Offset = "0x899928")]
			public bool spine;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public bool chest;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public bool hands;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public bool feet;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x899960", Offset = "0x899960")]
			public JointType joints;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float jointRange;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x899998", Offset = "0x899998")]
			public float colliderLengthOverlap;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ColliderType torsoColliders;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ColliderType headCollider;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ColliderType armColliders;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ColliderType handColliders;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public ColliderType legColliders;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ColliderType footColliders;

			[Token(Token = "0x170000E3")]
			public static Options Default
			{
				[Token(Token = "0x60007B4")]
				[Address(RVA = "0x1181658", Offset = "0x1181658", VA = "0x1181658")]
				get
				{
					return default(Options);
				}
			}
		}

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool canBuild;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedRagdollReferences references;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Options options;

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x1181344", Offset = "0x1181344", VA = "0x1181344")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D52C", Offset = "0x89D52C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1181390", Offset = "0x1181390", VA = "0x1181390")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D564", Offset = "0x89D564")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x11813DC", Offset = "0x11813DC", VA = "0x11813DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D59C", Offset = "0x89D59C")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1181428", Offset = "0x1181428", VA = "0x1181428")]
		public static Options AutodetectOptions(BipedRagdollReferences r)
		{
			return default(Options);
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x1181764", Offset = "0x1181764", VA = "0x1181764")]
		public static void Create(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1182100", Offset = "0x1182100", VA = "0x1182100")]
		private static void CreateColliders(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1183AA4", Offset = "0x1183AA4", VA = "0x1183AA4")]
		private static void CreateHandCollider(Transform hand, Transform lowerArm, Transform root, Options options)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1183D98", Offset = "0x1183D98", VA = "0x1183D98")]
		private static void CreateFootCollider(Transform foot, Transform lowerLeg, Transform upperLeg, Transform root, Options options)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x11843C8", Offset = "0x11843C8", VA = "0x11843C8")]
		private static Vector3 GetChildCentroid(Transform t, Vector3 fallback)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1182D38", Offset = "0x1182D38", VA = "0x1182D38")]
		private static void MassDistribution(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x118319C", Offset = "0x118319C", VA = "0x118319C")]
		private static void CreateJoints(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1184578", Offset = "0x1184578", VA = "0x1184578")]
		private static void CreateLimbJoints(Transform connectedBone, Transform bone1, Transform bone2, Transform bone3, Transform root, Vector3 defaultWorldDirection, JointType jointType, CreateJointParams.Limits limits1, CreateJointParams.Limits limits2, CreateJointParams.Limits limits3)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1184C7C", Offset = "0x1184C7C", VA = "0x1184C7C")]
		public static void ClearBipedRagdoll(BipedRagdollReferences r)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x11850F4", Offset = "0x11850F4", VA = "0x11850F4")]
		public static bool IsClear(BipedRagdollReferences r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x11839C0", Offset = "0x11839C0", VA = "0x11839C0")]
		private static Vector3 GetUpperArmToHeadCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1181690", Offset = "0x1181690", VA = "0x1181690")]
		private static Vector3 GetUpperArmCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x11851F0", Offset = "0x11851F0", VA = "0x11851F0")]
		public BipedRagdollCreator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public struct BipedRagdollReferences
	{
		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform root;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform hips;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform spine;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform chest;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform head;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftUpperLeg;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftLowerLeg;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform leftFoot;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightUpperLeg;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightLowerLeg;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightFoot;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftLowerArm;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform leftHand;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightLowerArm;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform rightHand;

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x97A454", Offset = "0x97A454", VA = "0x97A454")]
		public bool IsValid(ref string msg)
		{
			return default(bool);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x97A45C", Offset = "0x97A45C", VA = "0x97A45C")]
		private bool IsChildRecursive(Transform t, Transform parent)
		{
			return default(bool);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x97A464", Offset = "0x97A464", VA = "0x97A464")]
		public bool IsEmpty(bool considerRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x97A470", Offset = "0x97A470", VA = "0x97A470")]
		public bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x97A47C", Offset = "0x97A47C", VA = "0x97A47C")]
		public Transform[] GetRagdollTransforms()
		{
			return null;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1185A78", Offset = "0x1185A78", VA = "0x1185A78")]
		public static BipedRagdollReferences FromAvatar(Animator animator)
		{
			return default(BipedRagdollReferences);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1185D00", Offset = "0x1185D00", VA = "0x1185D00")]
		public static BipedRagdollReferences FromBipedReferences(BipedReferences biped)
		{
			return default(BipedRagdollReferences);
		}
	}
	[Token(Token = "0x2000046")]
	public static class JointConverter
	{
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x11861E0", Offset = "0x11861E0", VA = "0x11861E0")]
		public static void ToConfigurable(GameObject root)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x11866BC", Offset = "0x11866BC", VA = "0x11866BC")]
		public static void HingeToConfigurable(HingeJoint src)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1186970", Offset = "0x1186970", VA = "0x1186970")]
		public static void FixedToConfigurable(FixedJoint src)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1186ABC", Offset = "0x1186ABC", VA = "0x1186ABC")]
		public static void SpringToConfigurable(SpringJoint src)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x118647C", Offset = "0x118647C", VA = "0x118647C")]
		public static void CharacterToConfigurable(CharacterJoint src)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1186C64", Offset = "0x1186C64", VA = "0x1186C64")]
		private static void ConvertJoint(ref ConfigurableJoint conf, Joint src)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1186D9C", Offset = "0x1186D9C", VA = "0x1186D9C")]
		private static SoftJointLimit ConvertToHighSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1186E58", Offset = "0x1186E58", VA = "0x1186E58")]
		private static SoftJointLimit ConvertToLowSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1186E00", Offset = "0x1186E00", VA = "0x1186E00")]
		private static SoftJointLimitSpring ConvertToSoftJointLimitSpring(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimitSpring);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1186EBC", Offset = "0x1186EBC", VA = "0x1186EBC")]
		private static SoftJointLimit CopyLimit(SoftJointLimit src)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1186F1C", Offset = "0x1186F1C", VA = "0x1186F1C")]
		private static SoftJointLimitSpring CopyLimitSpring(SoftJointLimitSpring src)
		{
			return default(SoftJointLimitSpring);
		}
	}
	[Token(Token = "0x2000047")]
	public abstract class RagdollCreator : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D8")]
		public enum ColliderType
		{
			[Token(Token = "0x4000613")]
			Box,
			[Token(Token = "0x4000614")]
			Capsule
		}

		[Serializable]
		[Token(Token = "0x20000D9")]
		public enum JointType
		{
			[Token(Token = "0x4000616")]
			Configurable,
			[Token(Token = "0x4000617")]
			Character
		}

		[Serializable]
		[Token(Token = "0x20000DA")]
		public enum Direction
		{
			[Token(Token = "0x4000619")]
			X,
			[Token(Token = "0x400061A")]
			Y,
			[Token(Token = "0x400061B")]
			Z
		}

		[Token(Token = "0x20000DB")]
		public struct CreateJointParams
		{
			[Token(Token = "0x200011E")]
			public struct Limits
			{
				[Token(Token = "0x40007F8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public float minSwing;

				[Token(Token = "0x40007F9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public float maxSwing;

				[Token(Token = "0x40007FA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public float swing2;

				[Token(Token = "0x40007FB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public float twist;

				[Token(Token = "0x600092E")]
				[Address(RVA = "0x9799F8", Offset = "0x9799F8", VA = "0x9799F8")]
				public Limits(float minSwing, float maxSwing, float swing2, float twist)
				{
				}
			}

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rigidbody rigidbody;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Rigidbody connectedBody;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform child;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 worldSwingAxis;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Limits limits;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public JointType type;

			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x9799F0", Offset = "0x9799F0", VA = "0x9799F0")]
			public CreateJointParams(Rigidbody rigidbody, Rigidbody connectedBody, Transform child, Vector3 worldSwingAxis, Limits limits, JointType type)
			{
			}
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x10DE130", Offset = "0x10DE130", VA = "0x10DE130")]
		public static void ClearAll(Transform root)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x10DE330", Offset = "0x10DE330", VA = "0x10DE330")]
		protected static void ClearTransform(Transform transform)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x10DE564", Offset = "0x10DE564", VA = "0x10DE564")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x10DEAE0", Offset = "0x10DEAE0", VA = "0x10DEAE0")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width, float proportionAspect, Vector3 widthDirection)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x10DE958", Offset = "0x10DE958", VA = "0x10DE958")]
		protected static float GetScaleF(Transform t)
		{
			return default(float);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x10DEED8", Offset = "0x10DEED8", VA = "0x10DEED8")]
		protected static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x10DEF08", Offset = "0x10DEF08", VA = "0x10DEF08")]
		protected static void Vector3Abs(ref Vector3 v)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x10DEF88", Offset = "0x10DEF88", VA = "0x10DEF88")]
		protected static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x10DF040", Offset = "0x10DF040", VA = "0x10DF040")]
		protected static Vector3 DirectionToVector3(Direction dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x10DE988", Offset = "0x10DE988", VA = "0x10DE988")]
		protected static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x10DF0F8", Offset = "0x10DF0F8", VA = "0x10DF0F8")]
		protected static Vector3 GetLocalOrthoDirection(Transform transform, Vector3 worldDir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x10DF410", Offset = "0x10DF410", VA = "0x10DF410")]
		protected static Rigidbody GetConnectedBody(Transform bone, ref Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x10DF5D0", Offset = "0x10DF5D0", VA = "0x10DF5D0")]
		protected static void CreateJoint(CreateJointParams p)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x10DFBF0", Offset = "0x10DFBF0", VA = "0x10DFBF0")]
		private static SoftJointLimit ToSoftJointLimit(float limit)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x10DFC24", Offset = "0x10DFC24", VA = "0x10DFC24")]
		protected RagdollCreator()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8932C4", Offset = "0x8932C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8932C4", Offset = "0x8932C4")]
	public class RagdollEditor : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000DC")]
		public enum Mode
		{
			[Token(Token = "0x4000623")]
			Colliders,
			[Token(Token = "0x4000624")]
			Joints
		}

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public Rigidbody selectedRigidbody;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Collider selectedCollider;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool symmetry;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public Mode mode;

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x10DFCE0", Offset = "0x10DFCE0", VA = "0x10DFCE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D5D4", Offset = "0x89D5D4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x10DFD2C", Offset = "0x10DFD2C", VA = "0x10DFD2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D60C", Offset = "0x89D60C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x10DFD78", Offset = "0x10DFD78", VA = "0x10DFD78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D644", Offset = "0x89D644")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x10DFDC4", Offset = "0x10DFDC4", VA = "0x10DFDC4")]
		public RagdollEditor()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x2000049")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReactionVRIK hitReaction;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x11798C0", Offset = "0x11798C0", VA = "0x11798C0")]
		private void Update()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1179A8C", Offset = "0x1179A8C", VA = "0x1179A8C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1179C50", Offset = "0x1179C50", VA = "0x1179C50")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895E68", Offset = "0x895E68")]
		public VRIK ik;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895EA0", Offset = "0x895EA0")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895ED8", Offset = "0x895ED8")]
		public Transform headTracker;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895F10", Offset = "0x895F10")]
		public Transform bodyTracker;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895F48", Offset = "0x895F48")]
		public Transform leftHandTracker;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895F80", Offset = "0x895F80")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895FB8", Offset = "0x895FB8")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x895FF0", Offset = "0x895FF0")]
		public Transform rightFootTracker;

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1179C60", Offset = "0x1179C60", VA = "0x1179C60")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1179C9C", Offset = "0x1179C9C", VA = "0x1179C9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D67C", Offset = "0x89D67C")]
		private void Calibrate()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1179CD0", Offset = "0x1179CD0", VA = "0x1179CD0")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1179CD8", Offset = "0x1179CD8", VA = "0x1179CD8")]
		private void Start()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1179D34", Offset = "0x1179D34", VA = "0x1179D34")]
		private void Update()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1179F48", Offset = "0x1179F48", VA = "0x1179F48")]
		public VRIKPlatform()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x893324", Offset = "0x893324")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x893324", Offset = "0x893324")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x10E3AD0", Offset = "0x10E3AD0", VA = "0x10E3AD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D6B4", Offset = "0x89D6B4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x10E3B1C", Offset = "0x10E3B1C", VA = "0x10E3B1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D6EC", Offset = "0x89D6EC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x10E3B68", Offset = "0x10E3B68", VA = "0x10E3B68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D724", Offset = "0x89D724")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x10E3BB4", Offset = "0x10E3BB4", VA = "0x10E3BB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D75C", Offset = "0x89D75C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x10E3C00", Offset = "0x10E3C00", VA = "0x10E3C00")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x10E3C9C", Offset = "0x10E3C9C", VA = "0x10E3C9C")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x10E3CBC", Offset = "0x10E3CBC", VA = "0x10E3CBC")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x10E3CEC", Offset = "0x10E3CEC", VA = "0x10E3CEC")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x10E3D1C", Offset = "0x10E3D1C", VA = "0x10E3D1C")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x10E3D5C", Offset = "0x10E3D5C", VA = "0x10E3D5C")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x10E3DA0", Offset = "0x10E3DA0", VA = "0x10E3DA0")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x10E3DC4", Offset = "0x10E3DC4", VA = "0x10E3DC4")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x10E3DE8", Offset = "0x10E3DE8", VA = "0x10E3DE8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x10E3E10", Offset = "0x10E3E10", VA = "0x10E3E10")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x10E3E3C", Offset = "0x10E3E3C", VA = "0x10E3E3C")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x10E3E68", Offset = "0x10E3E68", VA = "0x10E3E68")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x10E3C20", Offset = "0x10E3C20", VA = "0x10E3C20")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x10E3E90", Offset = "0x10E3E90", VA = "0x10E3E90")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x10E3E9C", Offset = "0x10E3E9C", VA = "0x10E3E9C")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x10E3EA8", Offset = "0x10E3EA8", VA = "0x10E3EA8")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x10E41D0", Offset = "0x10E41D0", VA = "0x10E41D0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x10E4278", Offset = "0x10E4278", VA = "0x10E4278", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x10E45C4", Offset = "0x10E45C4", VA = "0x10E45C4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x10E4AAC", Offset = "0x10E4AAC", VA = "0x10E4AAC")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x10E4AE0", Offset = "0x10E4AE0", VA = "0x10E4AE0")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000079")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x10E4048", Offset = "0x10E4048", VA = "0x10E4048")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x10E4D24", Offset = "0x10E4D24", VA = "0x10E4D24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x10E4448", Offset = "0x10E4448", VA = "0x10E4448")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x10E4B7C", Offset = "0x10E4B7C", VA = "0x10E4B7C")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x1700007B")]
		public bool isValid
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x10E5394", Offset = "0x10E5394", VA = "0x10E5394")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003C6")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x10E5404", Offset = "0x10E5404", VA = "0x10E5404")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x10E540C", Offset = "0x10E540C", VA = "0x10E540C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x10E5518", Offset = "0x10E5518", VA = "0x10E5518")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x10E5520", Offset = "0x10E5520", VA = "0x10E5520")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x1700007C")]
		private bool positionChanged
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x10E56F0", Offset = "0x10E56F0", VA = "0x10E56F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x10E5554", Offset = "0x10E5554", VA = "0x10E5554", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x10E57AC", Offset = "0x10E57AC", VA = "0x10E57AC")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x10E57B4", Offset = "0x10E57B4", VA = "0x10E57B4")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000051")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x10E57E8", Offset = "0x10E57E8", VA = "0x10E57E8", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x10E5910", Offset = "0x10E5910", VA = "0x10E5910")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x10E5918", Offset = "0x10E5918", VA = "0x10E5918")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000052")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x1700007D")]
		private bool rotationChanged
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x10E5AEC", Offset = "0x10E5AEC", VA = "0x10E5AEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x10E594C", Offset = "0x10E594C", VA = "0x10E594C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x10E5BBC", Offset = "0x10E5BBC", VA = "0x10E5BBC")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x10E5BC4", Offset = "0x10E5BC4", VA = "0x10E5BC4")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class Constraints
	{
		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x896028", Offset = "0x896028")]
		public float positionWeight;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x896040", Offset = "0x896040")]
		public float rotationWeight;

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x10E5BF8", Offset = "0x10E5BF8", VA = "0x10E5BF8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x10E456C", Offset = "0x10E456C", VA = "0x10E456C")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x10E474C", Offset = "0x10E474C", VA = "0x10E474C")]
		public void Update()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x10E4F54", Offset = "0x10E4F54", VA = "0x10E4F54")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x20000DD")]
		public enum DOF
		{
			[Token(Token = "0x4000626")]
			One,
			[Token(Token = "0x4000627")]
			Three
		}

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896058", Offset = "0x896058")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x896058", Offset = "0x896058")]
		public float weight;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8960AC", Offset = "0x8960AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8960AC", Offset = "0x8960AC")]
		public float rotationWeight;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896100", Offset = "0x896100")]
		public DOF rotationDOF;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896138", Offset = "0x896138")]
		public Transform bone1;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896170", Offset = "0x896170")]
		public Transform bone2;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8961A8", Offset = "0x8961A8")]
		public Transform bone3;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8961E0", Offset = "0x8961E0")]
		public Transform tip;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896218", Offset = "0x896218")]
		public Transform target;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x896250", Offset = "0x896250")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x1700007E")]
		public bool initiated
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x10ED098", Offset = "0x10ED098", VA = "0x10ED098")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89D794", Offset = "0x89D794")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x10ED0A0", Offset = "0x10ED0A0", VA = "0x10ED0A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89D7A4", Offset = "0x89D7A4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x10ED0AC", Offset = "0x10ED0AC", VA = "0x10ED0AC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x10ED0CC", Offset = "0x10ED0CC", VA = "0x10ED0CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x10ED0EC", Offset = "0x10ED0EC", VA = "0x10ED0EC")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x10ED10C", Offset = "0x10ED10C", VA = "0x10ED10C")]
			set
			{
			}
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x10ED12C", Offset = "0x10ED12C", VA = "0x10ED12C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x10ED238", Offset = "0x10ED238", VA = "0x10ED238")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x10ED674", Offset = "0x10ED674", VA = "0x10ED674")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x10ED744", Offset = "0x10ED744", VA = "0x10ED744")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x10EDAFC", Offset = "0x10EDAFC", VA = "0x10EDAFC")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896260", Offset = "0x896260")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x896260", Offset = "0x896260")]
		public float weight;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8962B4", Offset = "0x8962B4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000081")]
		public bool initiated
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x10EDB0C", Offset = "0x10EDB0C", VA = "0x10EDB0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89D7B4", Offset = "0x89D7B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x10EDB14", Offset = "0x10EDB14", VA = "0x10EDB14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89D7C4", Offset = "0x89D7C4")]
			private set
			{
			}
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x10EDB20", Offset = "0x10EDB20", VA = "0x10EDB20")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x10EDBA8", Offset = "0x10EDBA8", VA = "0x10EDBA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D7D4", Offset = "0x89D7D4")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x10EDF20", Offset = "0x10EDF20", VA = "0x10EDF20")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x10EE0DC", Offset = "0x10EE0DC", VA = "0x10EE0DC")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x10EDE10", Offset = "0x10EDE10", VA = "0x10EDE10")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x10EE260", Offset = "0x10EE260", VA = "0x10EE260", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x10EE320", Offset = "0x10EE320", VA = "0x10EE320")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x10EE3A4", Offset = "0x10EE3A4", VA = "0x10EE3A4")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x10EE40C", Offset = "0x10EE40C", VA = "0x10EE40C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x10EE410", Offset = "0x10EE410", VA = "0x10EE410", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x10EE414", Offset = "0x10EE414", VA = "0x10EE414")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x20000DE")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8962C4", Offset = "0x8962C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8962C4", Offset = "0x8962C4")]
		public float weight;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896318", Offset = "0x896318")]
		public Grounding solver;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected bool initiated;

		[Token(Token = "0x60003F2")]
		public abstract void ResetPosition();

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x10EF4E4", Offset = "0x10EF4E4", VA = "0x10EF4E4")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x10EF7B8", Offset = "0x10EF7B8", VA = "0x10EF7B8")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x10EF628", Offset = "0x10EF628", VA = "0x10EF628")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x10EF7EC", Offset = "0x10EF7EC", VA = "0x10EF7EC")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F7")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60003F8")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x10EF9F4", Offset = "0x10EF9F4", VA = "0x10EF9F4")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x893384", Offset = "0x893384")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x893384", Offset = "0x893384")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896350", Offset = "0x896350")]
		public BipedIK ik;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896388", Offset = "0x896388")]
		public float spineBend;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8963C0", Offset = "0x8963C0")]
		public float spineSpeed;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x10EFCC8", Offset = "0x10EFCC8", VA = "0x10EFCC8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D80C", Offset = "0x89D80C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x10EFD14", Offset = "0x10EFD14", VA = "0x10EFD14", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D844", Offset = "0x89D844")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x10EFD60", Offset = "0x10EFD60", VA = "0x10EFD60", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x10EFDE4", Offset = "0x10EFDE4", VA = "0x10EFDE4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x10EFE94", Offset = "0x10EFE94", VA = "0x10EFE94")]
		private void Update()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x10EFF48", Offset = "0x10EFF48", VA = "0x10EFF48")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x10F025C", Offset = "0x10F025C", VA = "0x10F025C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x10F02B0", Offset = "0x10F02B0", VA = "0x10F02B0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x10F0804", Offset = "0x10F0804", VA = "0x10F0804")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x10F08D8", Offset = "0x10F08D8", VA = "0x10F08D8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x10F0A68", Offset = "0x10F0A68", VA = "0x10F0A68")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x10F0C0C", Offset = "0x10F0C0C", VA = "0x10F0C0C")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8933E4", Offset = "0x8933E4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8933E4", Offset = "0x8933E4")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x20000DF")]
		public class SpineEffector
		{
			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8999D0", Offset = "0x8999D0")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899A08", Offset = "0x899A08")]
			public float horizontalWeight;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899A40", Offset = "0x899A40")]
			public float verticalWeight;

			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x10F1B34", Offset = "0x10F1B34", VA = "0x10F1B34")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x10F1B44", Offset = "0x10F1B44", VA = "0x10F1B44")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8963F8", Offset = "0x8963F8")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896430", Offset = "0x896430")]
		public float spineBend;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896468", Offset = "0x896468")]
		public float spineSpeed;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x10F0CA4", Offset = "0x10F0CA4", VA = "0x10F0CA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D87C", Offset = "0x89D87C")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x10F0CF0", Offset = "0x10F0CF0", VA = "0x10F0CF0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D8B4", Offset = "0x89D8B4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x10F0D3C", Offset = "0x10F0D3C", VA = "0x10F0D3C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D8EC", Offset = "0x89D8EC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x10F0D88", Offset = "0x10F0D88", VA = "0x10F0D88", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x10F0E0C", Offset = "0x10F0E0C", VA = "0x10F0E0C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x10F0EA4", Offset = "0x10F0EA4", VA = "0x10F0EA4")]
		private void Update()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x10F11A0", Offset = "0x10F11A0", VA = "0x10F11A0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x10F11AC", Offset = "0x10F11AC", VA = "0x10F11AC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x10F0F60", Offset = "0x10F0F60", VA = "0x10F0F60")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x10F11B8", Offset = "0x10F11B8", VA = "0x10F11B8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x10F165C", Offset = "0x10F165C", VA = "0x10F165C")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x10F181C", Offset = "0x10F181C", VA = "0x10F181C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x10F1978", Offset = "0x10F1978", VA = "0x10F1978")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x10F1A9C", Offset = "0x10F1A9C", VA = "0x10F1A9C")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x893444", Offset = "0x893444")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x893444", Offset = "0x893444")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8964A0", Offset = "0x8964A0")]
		public Transform pelvis;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8964D8", Offset = "0x8964D8")]
		public Transform characterRoot;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896510", Offset = "0x896510")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x896510", Offset = "0x896510")]
		public float rootRotationWeight;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896564", Offset = "0x896564")]
		public float rootRotationSpeed;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89659C", Offset = "0x89659C")]
		public float maxRootRotationAngle;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x10F1B8C", Offset = "0x10F1B8C", VA = "0x10F1B8C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D924", Offset = "0x89D924")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x10F1BD8", Offset = "0x10F1BD8", VA = "0x10F1BD8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D95C", Offset = "0x89D95C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x10F1C24", Offset = "0x10F1C24", VA = "0x10F1C24", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x10F1C40", Offset = "0x10F1C40", VA = "0x10F1C40")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x10F1E30", Offset = "0x10F1E30", VA = "0x10F1E30")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x10F1F30", Offset = "0x10F1F30", VA = "0x10F1F30")]
		private void Update()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x10F2360", Offset = "0x10F2360", VA = "0x10F2360")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x10F277C", Offset = "0x10F277C", VA = "0x10F277C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x10F29F0", Offset = "0x10F29F0", VA = "0x10F29F0")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x10F2D10", Offset = "0x10F2D10", VA = "0x10F2D10")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x10F2E9C", Offset = "0x10F2E9C", VA = "0x10F2E9C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x10F3088", Offset = "0x10F3088", VA = "0x10F3088")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8934A4", Offset = "0x8934A4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8934A4", Offset = "0x8934A4")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x20000E0")]
		public struct Foot
		{
			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x984D00", Offset = "0x984D00", VA = "0x984D00")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8965D4", Offset = "0x8965D4")]
		public Grounding forelegSolver;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89660C", Offset = "0x89660C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89660C", Offset = "0x89660C")]
		public float rootRotationWeight;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896660", Offset = "0x896660")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x896660", Offset = "0x896660")]
		public float minRootRotation;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8966B8", Offset = "0x8966B8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8966B8", Offset = "0x8966B8")]
		public float maxRootRotation;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896710", Offset = "0x896710")]
		public float rootRotationSpeed;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896748", Offset = "0x896748")]
		public float maxLegOffset;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896780", Offset = "0x896780")]
		public float maxForeLegOffset;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8967B8", Offset = "0x8967B8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8967B8", Offset = "0x8967B8")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89680C", Offset = "0x89680C")]
		public Transform characterRoot;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896844", Offset = "0x896844")]
		public Transform pelvis;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89687C", Offset = "0x89687C")]
		public Transform lastSpineBone;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8968B4", Offset = "0x8968B4")]
		public Transform head;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x10F3120", Offset = "0x10F3120", VA = "0x10F3120", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D994", Offset = "0x89D994")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x10F316C", Offset = "0x10F316C", VA = "0x10F316C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89D9CC", Offset = "0x89D9CC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x10F31B8", Offset = "0x10F31B8", VA = "0x10F31B8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x10F31F4", Offset = "0x10F31F4", VA = "0x10F31F4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x10F3324", Offset = "0x10F3324", VA = "0x10F3324")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x10F34E4", Offset = "0x10F34E4", VA = "0x10F34E4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x10F354C", Offset = "0x10F354C", VA = "0x10F354C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x10F3604", Offset = "0x10F3604", VA = "0x10F3604")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x10F3918", Offset = "0x10F3918", VA = "0x10F3918")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x10F3C90", Offset = "0x10F3C90", VA = "0x10F3C90")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x10F3DDC", Offset = "0x10F3DDC", VA = "0x10F3DDC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x10F416C", Offset = "0x10F416C", VA = "0x10F416C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x10F4964", Offset = "0x10F4964", VA = "0x10F4964")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x10F4C24", Offset = "0x10F4C24", VA = "0x10F4C24")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x10F4D84", Offset = "0x10F4D84", VA = "0x10F4D84")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x10F5060", Offset = "0x10F5060", VA = "0x10F5060")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x10F5098", Offset = "0x10F5098", VA = "0x10F5098")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x10F527C", Offset = "0x10F527C", VA = "0x10F527C")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x893504", Offset = "0x893504")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8968FC", Offset = "0x8968FC")]
		public VRIK ik;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1478AF8", Offset = "0x1478AF8", VA = "0x1478AF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DA04", Offset = "0x89DA04")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1478AFC", Offset = "0x1478AFC", VA = "0x1478AFC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DA3C", Offset = "0x89DA3C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1478B00", Offset = "0x1478B00", VA = "0x1478B00", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DA74", Offset = "0x89DA74")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1478B04", Offset = "0x1478B04", VA = "0x1478B04", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1478BA0", Offset = "0x1478BA0", VA = "0x1478BA0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1478C38", Offset = "0x1478C38", VA = "0x1478C38")]
		private void Update()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1478CEC", Offset = "0x1478CEC", VA = "0x1478CEC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x147921C", Offset = "0x147921C", VA = "0x147921C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1479720", Offset = "0x1479720", VA = "0x1479720")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1479828", Offset = "0x1479828", VA = "0x1479828")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1479A28", Offset = "0x1479A28", VA = "0x1479A28")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1479B84", Offset = "0x1479B84", VA = "0x1479B84")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1479D30", Offset = "0x1479D30", VA = "0x1479D30")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x20000E1")]
		public enum Quality
		{
			[Token(Token = "0x4000630")]
			Fastest,
			[Token(Token = "0x4000631")]
			Simple,
			[Token(Token = "0x4000632")]
			Best
		}

		[Token(Token = "0x20000E2")]
		public class Leg
		{
			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x899A78", Offset = "0x899A78")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x899A88", Offset = "0x899A88")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x899A98", Offset = "0x899A98")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x899AA8", Offset = "0x899AA8")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x899AB8", Offset = "0x899AB8")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x899AC8", Offset = "0x899AC8")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x899AD8", Offset = "0x899AD8")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			[Token(Token = "0x170000E4")]
			public bool isGrounded
			{
				[Token(Token = "0x60007BD")]
				[Address(RVA = "0x147B880", Offset = "0x147B880", VA = "0x147B880")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F3D8", Offset = "0x89F3D8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60007BE")]
				[Address(RVA = "0x147B888", Offset = "0x147B888", VA = "0x147B888")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F3E8", Offset = "0x89F3E8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E5")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60007BF")]
				[Address(RVA = "0x147B894", Offset = "0x147B894", VA = "0x147B894")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F3F8", Offset = "0x89F3F8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007C0")]
				[Address(RVA = "0x147B8A0", Offset = "0x147B8A0", VA = "0x147B8A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F408", Offset = "0x89F408")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E6")]
			public bool initiated
			{
				[Token(Token = "0x60007C1")]
				[Address(RVA = "0x147B8AC", Offset = "0x147B8AC", VA = "0x147B8AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F418", Offset = "0x89F418")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60007C2")]
				[Address(RVA = "0x147B8B4", Offset = "0x147B8B4", VA = "0x147B8B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F428", Offset = "0x89F428")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E7")]
			public float heightFromGround
			{
				[Token(Token = "0x60007C3")]
				[Address(RVA = "0x147B8C0", Offset = "0x147B8C0", VA = "0x147B8C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F438", Offset = "0x89F438")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007C4")]
				[Address(RVA = "0x147B8C8", Offset = "0x147B8C8", VA = "0x147B8C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F448", Offset = "0x89F448")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E8")]
			public Vector3 velocity
			{
				[Token(Token = "0x60007C5")]
				[Address(RVA = "0x147B8D0", Offset = "0x147B8D0", VA = "0x147B8D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F458", Offset = "0x89F458")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007C6")]
				[Address(RVA = "0x147B8DC", Offset = "0x147B8DC", VA = "0x147B8DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F468", Offset = "0x89F468")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E9")]
			public Transform transform
			{
				[Token(Token = "0x60007C7")]
				[Address(RVA = "0x147B8E8", Offset = "0x147B8E8", VA = "0x147B8E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F478", Offset = "0x89F478")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007C8")]
				[Address(RVA = "0x147B8F0", Offset = "0x147B8F0", VA = "0x147B8F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F488", Offset = "0x89F488")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EA")]
			public float IKOffset
			{
				[Token(Token = "0x60007C9")]
				[Address(RVA = "0x147B8F8", Offset = "0x147B8F8", VA = "0x147B8F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F498", Offset = "0x89F498")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007CA")]
				[Address(RVA = "0x147B900", Offset = "0x147B900", VA = "0x147B900")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F4A8", Offset = "0x89F4A8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EB")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60007CF")]
				[Address(RVA = "0x147C280", Offset = "0x147C280", VA = "0x147C280")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000EC")]
			private float rootYOffset
			{
				[Token(Token = "0x60007D8")]
				[Address(RVA = "0x147C574", Offset = "0x147C574", VA = "0x147C574")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x147A470", Offset = "0x147A470", VA = "0x147A470")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x147B908", Offset = "0x147B908", VA = "0x147B908")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x147B358", Offset = "0x147B358", VA = "0x147B358")]
			public void Reset()
			{
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x147A5B4", Offset = "0x147A5B4", VA = "0x147A5B4")]
			public void Process()
			{
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x147BF18", Offset = "0x147BF18", VA = "0x147BF18")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x147B954", Offset = "0x147B954", VA = "0x147B954")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x147C400", Offset = "0x147C400", VA = "0x147C400")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x147BBA8", Offset = "0x147BBA8", VA = "0x147BBA8")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x147BCB0", Offset = "0x147BCB0", VA = "0x147BCB0")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x147C4FC", Offset = "0x147C4FC", VA = "0x147C4FC")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x147C30C", Offset = "0x147C30C", VA = "0x147C30C")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x147C6A8", Offset = "0x147C6A8", VA = "0x147C6A8")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x147A3C0", Offset = "0x147A3C0", VA = "0x147A3C0")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x20000E3")]
		public class Pelvis
		{
			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x899AE8", Offset = "0x899AE8")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x899AF8", Offset = "0x899AF8")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170000ED")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60007DA")]
				[Address(RVA = "0x147C798", Offset = "0x147C798", VA = "0x147C798")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F4B8", Offset = "0x89F4B8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007DB")]
				[Address(RVA = "0x147C7A4", Offset = "0x147C7A4", VA = "0x147C7A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F4C8", Offset = "0x89F4C8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EE")]
			public float heightOffset
			{
				[Token(Token = "0x60007DC")]
				[Address(RVA = "0x147C7B0", Offset = "0x147C7B0", VA = "0x147C7B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F4D8", Offset = "0x89F4D8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007DD")]
				[Address(RVA = "0x147C7B8", Offset = "0x147C7B8", VA = "0x147C7B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F4E8", Offset = "0x89F4E8")]
				private set
				{
				}
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x147A56C", Offset = "0x147A56C", VA = "0x147A56C")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x147B2A8", Offset = "0x147B2A8", VA = "0x147B2A8")]
			public void Reset()
			{
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x147C7C0", Offset = "0x147C7C0", VA = "0x147C7C0")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x147AE24", Offset = "0x147AE24", VA = "0x147AE24")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x147A468", Offset = "0x147A468", VA = "0x147A468")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896934", Offset = "0x896934")]
		public LayerMask layers;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89696C", Offset = "0x89696C")]
		public float maxStep;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8969A4", Offset = "0x8969A4")]
		public float heightOffset;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8969DC", Offset = "0x8969DC")]
		public float footSpeed;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896A14", Offset = "0x896A14")]
		public float footRadius;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896A4C", Offset = "0x896A4C")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896A98", Offset = "0x896A98")]
		public float prediction;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896AD0", Offset = "0x896AD0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x896AD0", Offset = "0x896AD0")]
		public float footRotationWeight;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896B24", Offset = "0x896B24")]
		public float footRotationSpeed;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896B5C", Offset = "0x896B5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x896B5C", Offset = "0x896B5C")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896BB4", Offset = "0x896BB4")]
		public bool rotateSolver;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896BEC", Offset = "0x896BEC")]
		public float pelvisSpeed;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896C24", Offset = "0x896C24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x896C24", Offset = "0x896C24")]
		public float pelvisDamper;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896C78", Offset = "0x896C78")]
		public float lowerPelvisWeight;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896CB0", Offset = "0x896CB0")]
		public float liftPelvisWeight;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896CE8", Offset = "0x896CE8")]
		public float rootSphereCastRadius;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896D20", Offset = "0x896D20")]
		public Quality quality;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x896D58", Offset = "0x896D58")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x896D68", Offset = "0x896D68")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x896D78", Offset = "0x896D78")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x896D88", Offset = "0x896D88")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x896D98", Offset = "0x896D98")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000082")]
		public Leg[] legs
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x1479D9C", Offset = "0x1479D9C", VA = "0x1479D9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89DAAC", Offset = "0x89DAAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x1479DA4", Offset = "0x1479DA4", VA = "0x1479DA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89DABC", Offset = "0x89DABC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x1479DAC", Offset = "0x1479DAC", VA = "0x1479DAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89DACC", Offset = "0x89DACC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x1479DB4", Offset = "0x1479DB4", VA = "0x1479DB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89DADC", Offset = "0x89DADC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public bool isGrounded
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x1479DBC", Offset = "0x1479DBC", VA = "0x1479DBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89DAEC", Offset = "0x89DAEC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x1479DC4", Offset = "0x1479DC4", VA = "0x1479DC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89DAFC", Offset = "0x89DAFC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public Transform root
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x1479DD0", Offset = "0x1479DD0", VA = "0x1479DD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89DB0C", Offset = "0x89DB0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x1479DD8", Offset = "0x1479DD8", VA = "0x1479DD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89DB1C", Offset = "0x89DB1C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x1479DE0", Offset = "0x1479DE0", VA = "0x1479DE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89DB2C", Offset = "0x89DB2C")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x1479DF8", Offset = "0x1479DF8", VA = "0x1479DF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89DB3C", Offset = "0x89DB3C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public bool rootGrounded
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x1479E18", Offset = "0x1479E18", VA = "0x1479E18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000088")]
		public Vector3 up
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x147A24C", Offset = "0x147A24C", VA = "0x147A24C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000089")]
		private bool useRootRotation
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x147B40C", Offset = "0x147B40C", VA = "0x147B40C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1479E6C", Offset = "0x1479E6C", VA = "0x1479E6C")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x147A2D8", Offset = "0x147A2D8", VA = "0x147A2D8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1478F64", Offset = "0x1478F64", VA = "0x1478F64")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x14794B8", Offset = "0x14794B8", VA = "0x14794B8")]
		public void Update()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x147B090", Offset = "0x147B090", VA = "0x147B090")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1478B1C", Offset = "0x1478B1C", VA = "0x1478B1C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x147A59C", Offset = "0x147A59C", VA = "0x147A59C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x147B4DC", Offset = "0x147B4DC", VA = "0x147B4DC")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x147B644", Offset = "0x147B644", VA = "0x147B644")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x147B748", Offset = "0x147B748", VA = "0x147B748")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x147B838", Offset = "0x147B838", VA = "0x147B838")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x89353C", Offset = "0x89353C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x89353C", Offset = "0x89353C")]
	public class AimIK : IK
	{
		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x10E2E84", Offset = "0x10E2E84", VA = "0x10E2E84", Slot = "13")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DB4C", Offset = "0x89DB4C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x10E2ED0", Offset = "0x10E2ED0", VA = "0x10E2ED0", Slot = "14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DB84", Offset = "0x89DB84")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x10E2F1C", Offset = "0x10E2F1C", VA = "0x10E2F1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DBBC", Offset = "0x89DBBC")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x10E2F68", Offset = "0x10E2F68", VA = "0x10E2F68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DBF4", Offset = "0x89DBF4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x10E2FB4", Offset = "0x10E2FB4", VA = "0x10E2FB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DC2C", Offset = "0x89DC2C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x10E3000", Offset = "0x10E3000", VA = "0x10E3000", Slot = "12")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x10E3008", Offset = "0x10E3008", VA = "0x10E3008")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x89359C", Offset = "0x89359C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x89359C", Offset = "0x89359C")]
	public class CCDIK : IK
	{
		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x10E51E8", Offset = "0x10E51E8", VA = "0x10E51E8", Slot = "13")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DC64", Offset = "0x89DC64")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x10E5234", Offset = "0x10E5234", VA = "0x10E5234", Slot = "14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DC9C", Offset = "0x89DC9C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x10E5280", Offset = "0x10E5280", VA = "0x10E5280")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DCD4", Offset = "0x89DCD4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x10E52CC", Offset = "0x10E52CC", VA = "0x10E52CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DD0C", Offset = "0x89DD0C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x10E5318", Offset = "0x10E5318", VA = "0x10E5318", Slot = "12")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x10E5320", Offset = "0x10E5320", VA = "0x10E5320")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8935FC", Offset = "0x8935FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8935FC", Offset = "0x8935FC")]
	public class FABRIK : IK
	{
		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x10E5C68", Offset = "0x10E5C68", VA = "0x10E5C68", Slot = "13")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DD44", Offset = "0x89DD44")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x10E5CB4", Offset = "0x10E5CB4", VA = "0x10E5CB4", Slot = "14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DD7C", Offset = "0x89DD7C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x10E5D00", Offset = "0x10E5D00", VA = "0x10E5D00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DDB4", Offset = "0x89DDB4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x10E5D4C", Offset = "0x10E5D4C", VA = "0x10E5D4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DDEC", Offset = "0x89DDEC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x10E5D98", Offset = "0x10E5D98", VA = "0x10E5D98", Slot = "12")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x10E5DA0", Offset = "0x10E5DA0", VA = "0x10E5DA0")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x89365C", Offset = "0x89365C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x89365C", Offset = "0x89365C")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x10E6444", Offset = "0x10E6444", VA = "0x10E6444", Slot = "13")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DE24", Offset = "0x89DE24")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x10E6490", Offset = "0x10E6490", VA = "0x10E6490", Slot = "14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DE5C", Offset = "0x89DE5C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x10E64DC", Offset = "0x10E64DC", VA = "0x10E64DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DE94", Offset = "0x89DE94")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x10E6528", Offset = "0x10E6528", VA = "0x10E6528")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DECC", Offset = "0x89DECC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x10E6574", Offset = "0x10E6574", VA = "0x10E6574", Slot = "12")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x10E657C", Offset = "0x10E657C", VA = "0x10E657C")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8936BC", Offset = "0x8936BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8936BC", Offset = "0x8936BC")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x10EE488", Offset = "0x10EE488", VA = "0x10EE488", Slot = "13")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DF04", Offset = "0x89DF04")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x10EE4D4", Offset = "0x10EE4D4", VA = "0x10EE4D4", Slot = "14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DF3C", Offset = "0x89DF3C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x10EE520", Offset = "0x10EE520", VA = "0x10EE520")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DF74", Offset = "0x89DF74")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x10EE56C", Offset = "0x10EE56C", VA = "0x10EE56C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DFAC", Offset = "0x89DFAC")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x10EE5B8", Offset = "0x10EE5B8", VA = "0x10EE5B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89DFE4", Offset = "0x89DFE4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x10EE604", Offset = "0x10EE604", VA = "0x10EE604")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E01C", Offset = "0x89E01C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x10EE650", Offset = "0x10EE650", VA = "0x10EE650")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x10EE694", Offset = "0x10EE694", VA = "0x10EE694", Slot = "12")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x10EE69C", Offset = "0x10EE69C", VA = "0x10EE69C")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x10EE864", Offset = "0x10EE864", VA = "0x10EE864")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x10EEBC4", Offset = "0x10EEBC4", VA = "0x10EEBC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E054", Offset = "0x89E054")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x10EEBE4", Offset = "0x10EEBE4", VA = "0x10EEBE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E08C", Offset = "0x89E08C")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x10EECD8", Offset = "0x10EECD8", VA = "0x10EECD8")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x600047D")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x147F30C", Offset = "0x147F30C", VA = "0x147F30C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x147F3D8", Offset = "0x147F3D8", VA = "0x147F3D8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x147F58C", Offset = "0x147F58C", VA = "0x147F58C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000481")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000482")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x147F5C8", Offset = "0x147F5C8", VA = "0x147F5C8")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896DA8", Offset = "0x896DA8")]
		public IK[] IKComponents;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896DE0", Offset = "0x896DE0")]
		public Animator animator;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x1700008A")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x1482638", Offset = "0x1482638", VA = "0x1482638")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x14826D4", Offset = "0x14826D4", VA = "0x14826D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1482744", Offset = "0x1482744", VA = "0x1482744")]
		private void Update()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1482800", Offset = "0x1482800", VA = "0x1482800")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x148283C", Offset = "0x148283C", VA = "0x148283C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1482778", Offset = "0x1482778", VA = "0x1482778")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x14828C8", Offset = "0x14828C8", VA = "0x14828C8")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x89371C", Offset = "0x89371C")]
	public class LegIK : IK
	{
		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x11020A0", Offset = "0x11020A0", VA = "0x11020A0", Slot = "13")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E0C4", Offset = "0x89E0C4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x110210C", Offset = "0x110210C", VA = "0x110210C", Slot = "14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E0FC", Offset = "0x89E0FC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x1102178", Offset = "0x1102178", VA = "0x1102178")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E134", Offset = "0x89E134")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x11021C4", Offset = "0x11021C4", VA = "0x11021C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E16C", Offset = "0x89E16C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1102210", Offset = "0x1102210", VA = "0x1102210", Slot = "12")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1102218", Offset = "0x1102218", VA = "0x1102218")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x893754", Offset = "0x893754")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x893754", Offset = "0x893754")]
	public class LimbIK : IK
	{
		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x110228C", Offset = "0x110228C", VA = "0x110228C", Slot = "13")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E1A4", Offset = "0x89E1A4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x11022D8", Offset = "0x11022D8", VA = "0x11022D8", Slot = "14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E1DC", Offset = "0x89E1DC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x1102324", Offset = "0x1102324", VA = "0x1102324")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E214", Offset = "0x89E214")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x1102370", Offset = "0x1102370", VA = "0x1102370")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E24C", Offset = "0x89E24C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x11023BC", Offset = "0x11023BC", VA = "0x11023BC", Slot = "12")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x11023C4", Offset = "0x11023C4", VA = "0x11023C4")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8937B4", Offset = "0x8937B4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8937B4", Offset = "0x8937B4")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x1102438", Offset = "0x1102438", VA = "0x1102438", Slot = "13")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E284", Offset = "0x89E284")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x1102484", Offset = "0x1102484", VA = "0x1102484", Slot = "14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E2BC", Offset = "0x89E2BC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x11024D0", Offset = "0x11024D0", VA = "0x11024D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E2F4", Offset = "0x89E2F4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x110251C", Offset = "0x110251C", VA = "0x110251C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E32C", Offset = "0x89E32C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x1102568", Offset = "0x1102568", VA = "0x1102568", Slot = "12")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1102570", Offset = "0x1102570", VA = "0x1102570")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x893814", Offset = "0x893814")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x893814", Offset = "0x893814")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x110A98C", Offset = "0x110A98C", VA = "0x110A98C", Slot = "13")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E364", Offset = "0x89E364")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x110A9D8", Offset = "0x110A9D8", VA = "0x110A9D8", Slot = "14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E39C", Offset = "0x89E39C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x110AA24", Offset = "0x110AA24", VA = "0x110AA24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E3D4", Offset = "0x89E3D4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x110AA70", Offset = "0x110AA70", VA = "0x110AA70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E40C", Offset = "0x89E40C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x110AABC", Offset = "0x110AABC", VA = "0x110AABC", Slot = "12")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x110AAC4", Offset = "0x110AAC4", VA = "0x110AAC4")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x893874", Offset = "0x893874")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x20000E4")]
		public class References
		{
			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform chest;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform neck;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform leftShoulder;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Transform rightShoulder;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Transform leftThigh;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Transform leftCalf;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Transform leftFoot;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public Transform leftToes;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public Transform rightThigh;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public Transform rightCalf;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public Transform rightFoot;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public Transform rightToes;

			[Token(Token = "0x170000EF")]
			public bool isFilled
			{
				[Token(Token = "0x60007E4")]
				[Address(RVA = "0x110C11C", Offset = "0x110C11C", VA = "0x110C11C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000F0")]
			public bool isEmpty
			{
				[Token(Token = "0x60007E5")]
				[Address(RVA = "0x110BCA0", Offset = "0x110BCA0", VA = "0x110BCA0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x110C520", Offset = "0x110C520", VA = "0x110C520")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x110B77C", Offset = "0x110B77C", VA = "0x110B77C")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x110C518", Offset = "0x110C518", VA = "0x110C518")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x896E18", Offset = "0x896E18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896E18", Offset = "0x896E18")]
		public References references;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896E94", Offset = "0x896E94")]
		public IKSolverVR solver;

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x110B630", Offset = "0x110B630", VA = "0x110B630", Slot = "13")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E444", Offset = "0x89E444")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x110B69C", Offset = "0x110B69C", VA = "0x110B69C", Slot = "14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E47C", Offset = "0x89E47C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x110B708", Offset = "0x110B708", VA = "0x110B708")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E4B4", Offset = "0x89E4B4")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x110B754", Offset = "0x110B754", VA = "0x110B754")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E4EC", Offset = "0x89E4EC")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x110BBFC", Offset = "0x110BBFC", VA = "0x110BBFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E524", Offset = "0x89E524")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x110BC24", Offset = "0x110BC24", VA = "0x110BC24", Slot = "12")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x110BC2C", Offset = "0x110BC2C", VA = "0x110BC2C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x110C478", Offset = "0x110C478", VA = "0x110C478")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public class FABRIKChain
	{
		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x896ECC", Offset = "0x896ECC")]
		public float pull;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x896EE4", Offset = "0x896EE4")]
		public float pin;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x10E5E14", Offset = "0x10E5E14", VA = "0x10E5E14")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x10E5EE8", Offset = "0x10E5EE8", VA = "0x10E5EE8")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x10E5F08", Offset = "0x10E5F08", VA = "0x10E5F08")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x10E62D8", Offset = "0x10E62D8", VA = "0x10E62D8")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x10E5FDC", Offset = "0x10E5FDC", VA = "0x10E5FDC")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x10E63D0", Offset = "0x10E63D0", VA = "0x10E63D0")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x10E65F0", Offset = "0x10E65F0", VA = "0x10E65F0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x10E6B6C", Offset = "0x10E6B6C", VA = "0x10E6B6C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x10E6D2C", Offset = "0x10E6D2C", VA = "0x10E6D2C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x10E6E48", Offset = "0x10E6E48", VA = "0x10E6E48")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E5")]
		public class BendBone
		{
			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899B08", Offset = "0x899B08")]
			public Transform transform;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899B40", Offset = "0x899B40")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x899B40", Offset = "0x899B40")]
			public float weight;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x10E9FD8", Offset = "0x10E9FD8", VA = "0x10E9FD8")]
			public BendBone()
			{
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x10EA058", Offset = "0x10EA058", VA = "0x10EA058")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x10E7698", Offset = "0x10E7698", VA = "0x10E7698")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x10E7A9C", Offset = "0x10E7A9C", VA = "0x10E7A9C")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896EFC", Offset = "0x896EFC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x896F34", Offset = "0x896F34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896F34", Offset = "0x896F34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x896F34", Offset = "0x896F34")]
		public float positionWeight;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x896FAC", Offset = "0x896FAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x896FAC", Offset = "0x896FAC")]
		public float bodyWeight;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897000", Offset = "0x897000")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897000", Offset = "0x897000")]
		public float thighWeight;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897054", Offset = "0x897054")]
		public bool handsPullBody;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x89708C", Offset = "0x89708C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89708C", Offset = "0x89708C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89708C", Offset = "0x89708C")]
		public float rotationWeight;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897104", Offset = "0x897104")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897104", Offset = "0x897104")]
		public float bodyClampWeight;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897158", Offset = "0x897158")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897158", Offset = "0x897158")]
		public float headClampWeight;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8971AC", Offset = "0x8971AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8971AC", Offset = "0x8971AC")]
		public float bendWeight;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897200", Offset = "0x897200")]
		public BendBone[] bendBones;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x897238", Offset = "0x897238")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897238", Offset = "0x897238")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897238", Offset = "0x897238")]
		public float CCDWeight;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8972B0", Offset = "0x8972B0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8972B0", Offset = "0x8972B0")]
		public float roll;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897304", Offset = "0x897304")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897304", Offset = "0x897304")]
		public float damper;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89735C", Offset = "0x89735C")]
		public Transform[] CCDBones;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x897394", Offset = "0x897394")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897394", Offset = "0x897394")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897394", Offset = "0x897394")]
		public float postStretchWeight;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89740C", Offset = "0x89740C")]
		public float maxStretch;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897444", Offset = "0x897444")]
		public float stretchDamper;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89747C", Offset = "0x89747C")]
		public bool fixHead;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8974B4", Offset = "0x8974B4")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8974EC", Offset = "0x8974EC")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897524", Offset = "0x897524")]
		public float chestDirectionWeight;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x10E6E50", Offset = "0x10E6E50", VA = "0x10E6E50")]
		private void Start()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x10E71D4", Offset = "0x10E71D4", VA = "0x10E71D4")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x10E76D0", Offset = "0x10E76D0", VA = "0x10E76D0")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x10E7AC4", Offset = "0x10E7AC4", VA = "0x10E7AC4")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x10E843C", Offset = "0x10E843C", VA = "0x10E843C")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x10E8788", Offset = "0x10E8788", VA = "0x10E8788")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x10E8B24", Offset = "0x10E8B24", VA = "0x10E8B24")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x10E9590", Offset = "0x10E9590", VA = "0x10E9590")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x10E8168", Offset = "0x10E8168", VA = "0x10E8168")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x10E97A0", Offset = "0x10E97A0", VA = "0x10E97A0")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x10E944C", Offset = "0x10E944C", VA = "0x10E944C")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x10E92B0", Offset = "0x10E92B0", VA = "0x10E92B0")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x10E9B0C", Offset = "0x10E9B0C", VA = "0x10E9B0C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x10E9DF0", Offset = "0x10E9DF0", VA = "0x10E9DF0")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x20000E6")]
		public class ChildConstraint
		{
			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x899BB4", Offset = "0x899BB4")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x899BC4", Offset = "0x899BC4")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x170000F1")]
			public float nominalDistance
			{
				[Token(Token = "0x60007EC")]
				[Address(RVA = "0x10ED00C", Offset = "0x10ED00C", VA = "0x10ED00C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F4F8", Offset = "0x89F4F8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007ED")]
				[Address(RVA = "0x10ED014", Offset = "0x10ED014", VA = "0x10ED014")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F508", Offset = "0x89F508")]
				private set
				{
				}
			}

			[Token(Token = "0x170000F2")]
			public bool isRigid
			{
				[Token(Token = "0x60007EE")]
				[Address(RVA = "0x10ED01C", Offset = "0x10ED01C", VA = "0x10ED01C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F518", Offset = "0x89F518")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60007EF")]
				[Address(RVA = "0x10ED024", Offset = "0x10ED024", VA = "0x10ED024")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F528", Offset = "0x89F528")]
				private set
				{
				}
			}

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x10ED030", Offset = "0x10ED030", VA = "0x10ED030")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x10EAD90", Offset = "0x10EAD90", VA = "0x10EAD90")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x10EB2D0", Offset = "0x10EB2D0", VA = "0x10EB2D0")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x10ECD08", Offset = "0x10ECD08", VA = "0x10ECD08")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E7")]
		public enum Smoothing
		{
			[Token(Token = "0x400066F")]
			None,
			[Token(Token = "0x4000670")]
			Exponential,
			[Token(Token = "0x4000671")]
			Cubic
		}

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89753C", Offset = "0x89753C")]
		public float pin;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897554", Offset = "0x897554")]
		public float pull;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89756C", Offset = "0x89756C")]
		public float push;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897584", Offset = "0x897584")]
		public float pushParent;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89759C", Offset = "0x89759C")]
		public float reach;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x4000373")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x10EA108", Offset = "0x10EA108", VA = "0x10EA108")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x10EA204", Offset = "0x10EA204", VA = "0x10EA204")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x10EA354", Offset = "0x10EA354", VA = "0x10EA354")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x10EA488", Offset = "0x10EA488", VA = "0x10EA488")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x10EA564", Offset = "0x10EA564", VA = "0x10EA564")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x10EA674", Offset = "0x10EA674", VA = "0x10EA674")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x10EADE8", Offset = "0x10EADE8", VA = "0x10EADE8")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x10EA810", Offset = "0x10EA810", VA = "0x10EA810")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x10EB4D4", Offset = "0x10EB4D4", VA = "0x10EB4D4")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x10EB878", Offset = "0x10EB878", VA = "0x10EB878")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x10EBC5C", Offset = "0x10EBC5C", VA = "0x10EBC5C")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x10EC1E0", Offset = "0x10EC1E0", VA = "0x10EC1E0")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x10EC7B0", Offset = "0x10EC7B0", VA = "0x10EC7B0")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x10ECA48", Offset = "0x10ECA48", VA = "0x10ECA48")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x10EC6A8", Offset = "0x10EC6A8", VA = "0x10EC6A8")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x10EBFC8", Offset = "0x10EBFC8", VA = "0x10EBFC8")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x10EC630", Offset = "0x10EC630", VA = "0x10EC630")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x10ECB30", Offset = "0x10ECB30", VA = "0x10ECB30")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x10EC550", Offset = "0x10EC550", VA = "0x10EC550")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x10EC930", Offset = "0x10EC930", VA = "0x10EC930")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006D")]
	public class IKConstraintBend
	{
		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8975B4", Offset = "0x8975B4")]
		public float weight;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8975CC", Offset = "0x8975CC")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700008B")]
		public bool initiated
		{
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x147F798", Offset = "0x147F798", VA = "0x147F798")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89E55C", Offset = "0x89E55C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x147F7A0", Offset = "0x147F7A0", VA = "0x147F7A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89E56C", Offset = "0x89E56C")]
			private set
			{
			}
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x147F5D0", Offset = "0x147F5D0", VA = "0x147F5D0")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x147F7AC", Offset = "0x147F7AC", VA = "0x147F7AC")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x147F830", Offset = "0x147F830", VA = "0x147F830")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x147F8E4", Offset = "0x147F8E4", VA = "0x147F8E4")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x147F934", Offset = "0x147F934", VA = "0x147F934")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x147FE5C", Offset = "0x147FE5C", VA = "0x147FE5C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x148008C", Offset = "0x148008C", VA = "0x148008C")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1480528", Offset = "0x1480528", VA = "0x1480528")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x147FC2C", Offset = "0x147FC2C", VA = "0x147FC2C")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x147FD44", Offset = "0x147FD44", VA = "0x147FD44")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class IKEffector
	{
		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8975DC", Offset = "0x8975DC")]
		public float positionWeight;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8975F4", Offset = "0x8975F4")]
		public float rotationWeight;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89760C", Offset = "0x89760C")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89761C", Offset = "0x89761C")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x1700008C")]
		public bool isEndEffector
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x1480BD8", Offset = "0x1480BD8", VA = "0x1480BD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89E57C", Offset = "0x89E57C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x1480BE0", Offset = "0x1480BE0", VA = "0x1480BE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89E58C", Offset = "0x89E58C")]
			private set
			{
			}
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1480B70", Offset = "0x1480B70", VA = "0x1480B70")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1480BEC", Offset = "0x1480BEC", VA = "0x1480BEC")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1480CC0", Offset = "0x1480CC0", VA = "0x1480CC0")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1480E2C", Offset = "0x1480E2C", VA = "0x1480E2C")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1480FD4", Offset = "0x1480FD4", VA = "0x1480FD4")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x14812D0", Offset = "0x14812D0", VA = "0x14812D0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1481594", Offset = "0x1481594", VA = "0x1481594")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x14816CC", Offset = "0x14816CC", VA = "0x14816CC")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1481778", Offset = "0x1481778", VA = "0x1481778")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1481DB8", Offset = "0x1481DB8", VA = "0x1481DB8")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1481E28", Offset = "0x1481E28", VA = "0x1481E28")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1482034", Offset = "0x1482034", VA = "0x1482034")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1482368", Offset = "0x1482368", VA = "0x1482368")]
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
		[Token(Token = "0x20000E8")]
		public class BoneMap
		{
			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x170000F3")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60007F5")]
				[Address(RVA = "0x1482B68", Offset = "0x1482B68", VA = "0x1482B68")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000F4")]
			public bool isNodeBone
			{
				[Token(Token = "0x60007F8")]
				[Address(RVA = "0x1482CD4", Offset = "0x1482CD4", VA = "0x1482CD4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000F5")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x600080C")]
				[Address(RVA = "0x14832D8", Offset = "0x14832D8", VA = "0x14832D8")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x1482B1C", Offset = "0x1482B1C", VA = "0x1482B1C")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x1482C34", Offset = "0x1482C34", VA = "0x1482C34")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x1482C84", Offset = "0x1482C84", VA = "0x1482C84")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x1482CE4", Offset = "0x1482CE4", VA = "0x1482CE4")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x1482DCC", Offset = "0x1482DCC", VA = "0x1482DCC")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x1482DD4", Offset = "0x1482DD4", VA = "0x1482DD4")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x1482F64", Offset = "0x1482F64", VA = "0x1482F64")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x1483070", Offset = "0x1483070", VA = "0x1483070")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x1483128", Offset = "0x1483128", VA = "0x1483128")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x14834FC", Offset = "0x14834FC", VA = "0x14834FC")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000800")]
			[Address(RVA = "0x1483534", Offset = "0x1483534", VA = "0x1483534")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000801")]
			[Address(RVA = "0x148356C", Offset = "0x148356C", VA = "0x148356C")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000802")]
			[Address(RVA = "0x1483594", Offset = "0x1483594", VA = "0x1483594")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000803")]
			[Address(RVA = "0x14836BC", Offset = "0x14836BC", VA = "0x14836BC")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x14839F4", Offset = "0x14839F4", VA = "0x14839F4")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000805")]
			[Address(RVA = "0x1483A24", Offset = "0x1483A24", VA = "0x1483A24")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000806")]
			[Address(RVA = "0x1483BBC", Offset = "0x1483BBC", VA = "0x1483BBC")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000807")]
			[Address(RVA = "0x1483C2C", Offset = "0x1483C2C", VA = "0x1483C2C")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000808")]
			[Address(RVA = "0x1483E70", Offset = "0x1483E70", VA = "0x1483E70")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x6000809")]
			[Address(RVA = "0x1484098", Offset = "0x1484098", VA = "0x1484098")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x600080A")]
			[Address(RVA = "0x14841B0", Offset = "0x14841B0", VA = "0x14841B0")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600080B")]
			[Address(RVA = "0x14837FC", Offset = "0x14837FC", VA = "0x14837FC")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600080D")]
			[Address(RVA = "0x1484340", Offset = "0x1484340", VA = "0x1484340")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x14828D0", Offset = "0x14828D0", VA = "0x14828D0", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x14828D8", Offset = "0x14828D8", VA = "0x14828D8", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x14828DC", Offset = "0x14828DC", VA = "0x14828DC")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1482A0C", Offset = "0x1482A0C", VA = "0x1482A0C")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1482B14", Offset = "0x1482B14", VA = "0x1482B14")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000070")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897634", Offset = "0x897634")]
		public float maintainRotationWeight;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x148435C", Offset = "0x148435C", VA = "0x148435C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1484408", Offset = "0x1484408", VA = "0x1484408")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1484498", Offset = "0x1484498", VA = "0x1484498")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1484544", Offset = "0x1484544", VA = "0x1484544")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x148455C", Offset = "0x148455C", VA = "0x148455C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1484578", Offset = "0x1484578", VA = "0x1484578", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1484624", Offset = "0x1484624", VA = "0x1484624")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x148463C", Offset = "0x148463C", VA = "0x148463C")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000071")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000E9")]
		public enum BoneMapType
		{
			[Token(Token = "0x4000689")]
			Parent,
			[Token(Token = "0x400068A")]
			Bone1,
			[Token(Token = "0x400068B")]
			Bone2,
			[Token(Token = "0x400068C")]
			Bone3
		}

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89764C", Offset = "0x89764C")]
		public float maintainRotationWeight;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897664", Offset = "0x897664")]
		public float weight;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1484660", Offset = "0x1484660", VA = "0x1484660", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x14846E4", Offset = "0x14846E4", VA = "0x14846E4")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x14847B8", Offset = "0x14847B8", VA = "0x14847B8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1484B0C", Offset = "0x1484B0C", VA = "0x1484B0C")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1484C3C", Offset = "0x1484C3C", VA = "0x1484C3C")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1484DA4", Offset = "0x1484DA4", VA = "0x1484DA4")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1484E08", Offset = "0x1484E08", VA = "0x1484E08")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1484EB0", Offset = "0x1484EB0", VA = "0x1484EB0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1484F68", Offset = "0x1484F68", VA = "0x1484F68", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1485230", Offset = "0x1485230", VA = "0x1485230")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x14852E8", Offset = "0x14852E8", VA = "0x14852E8")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000072")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89767C", Offset = "0x89767C")]
		public int iterations;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897694", Offset = "0x897694")]
		public float twistWeight;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1485450", Offset = "0x1485450", VA = "0x1485450", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1485748", Offset = "0x1485748", VA = "0x1485748")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x14858A0", Offset = "0x14858A0", VA = "0x14858A0")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1485A40", Offset = "0x1485A40", VA = "0x1485A40")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1485AC0", Offset = "0x1485AC0", VA = "0x1485AC0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1485B28", Offset = "0x1485B28", VA = "0x1485B28")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1485BA8", Offset = "0x1485BA8", VA = "0x1485BA8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1486280", Offset = "0x1486280", VA = "0x1486280")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x14862B8", Offset = "0x14862B8", VA = "0x14862B8")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1486598", Offset = "0x1486598", VA = "0x1486598")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1486944", Offset = "0x1486944", VA = "0x1486944")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1486A30", Offset = "0x1486A30", VA = "0x1486A30")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1486AF8", Offset = "0x1486AF8", VA = "0x1486AF8")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000073")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000EA")]
		public class Point
		{
			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x899BD4", Offset = "0x899BD4")]
			public float weight;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x600080E")]
			[Address(RVA = "0x1488664", Offset = "0x1488664", VA = "0x1488664")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600080F")]
			[Address(RVA = "0x14886B4", Offset = "0x14886B4", VA = "0x14886B4")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000810")]
			[Address(RVA = "0x148883C", Offset = "0x148883C", VA = "0x148883C")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000811")]
			[Address(RVA = "0x1488874", Offset = "0x1488874", VA = "0x1488874")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000812")]
			[Address(RVA = "0x14888AC", Offset = "0x14888AC", VA = "0x14888AC")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000813")]
			[Address(RVA = "0x14888FC", Offset = "0x14888FC", VA = "0x14888FC")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000814")]
			[Address(RVA = "0x1488100", Offset = "0x1488100", VA = "0x1488100")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EB")]
		public class Bone : Point
		{
			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x170000F6")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000815")]
				[Address(RVA = "0x14876BC", Offset = "0x14876BC", VA = "0x14876BC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000816")]
				[Address(RVA = "0x14877B8", Offset = "0x14877B8", VA = "0x14877B8")]
				set
				{
				}
			}

			[Token(Token = "0x6000817")]
			[Address(RVA = "0x148784C", Offset = "0x148784C", VA = "0x148784C")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000818")]
			[Address(RVA = "0x1487B0C", Offset = "0x1487B0C", VA = "0x1487B0C")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000819")]
			[Address(RVA = "0x1487DEC", Offset = "0x1487DEC", VA = "0x1487DEC")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600081A")]
			[Address(RVA = "0x1488054", Offset = "0x1488054", VA = "0x1488054")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x600081B")]
			[Address(RVA = "0x148807C", Offset = "0x148807C", VA = "0x148807C")]
			public Bone()
			{
			}

			[Token(Token = "0x600081C")]
			[Address(RVA = "0x1488180", Offset = "0x1488180", VA = "0x1488180")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600081D")]
			[Address(RVA = "0x1488220", Offset = "0x1488220", VA = "0x1488220")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EC")]
		public class Node : Point
		{
			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x600081E")]
			[Address(RVA = "0x14885EC", Offset = "0x14885EC", VA = "0x14885EC")]
			public Node()
			{
			}

			[Token(Token = "0x600081F")]
			[Address(RVA = "0x14885F0", Offset = "0x14885F0", VA = "0x14885F0")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000820")]
			[Address(RVA = "0x1488620", Offset = "0x1488620", VA = "0x1488620")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x20000ED")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000EE")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8976BC", Offset = "0x8976BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8976BC", Offset = "0x8976BC")]
		public float IKPositionWeight;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x897710", Offset = "0x897710")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x1700008D")]
		public bool initiated
		{
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x148710C", Offset = "0x148710C", VA = "0x148710C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89E59C", Offset = "0x89E59C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x1487114", Offset = "0x1487114", VA = "0x1487114")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89E5AC", Offset = "0x89E5AC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1486DD8", Offset = "0x1486DD8", VA = "0x1486DD8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000518")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x147F434", Offset = "0x147F434", VA = "0x147F434")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x147F370", Offset = "0x147F370", VA = "0x147F370")]
		public void Update()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1487060", Offset = "0x1487060", VA = "0x1487060", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x148706C", Offset = "0x148706C", VA = "0x148706C")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1487078", Offset = "0x1487078", VA = "0x1487078")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1487080", Offset = "0x1487080", VA = "0x1487080")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1487104", Offset = "0x1487104", VA = "0x1487104")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000522")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000523")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x6000524")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000525")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x6000526")]
		protected abstract void OnInitiate();

		[Token(Token = "0x6000527")]
		protected abstract void OnUpdate();

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1487120", Offset = "0x1487120", VA = "0x1487120")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1487138", Offset = "0x1487138", VA = "0x1487138")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1487274", Offset = "0x1487274", VA = "0x1487274")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1487320", Offset = "0x1487320", VA = "0x1487320")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x14876A4", Offset = "0x14876A4", VA = "0x14876A4")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000074")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897758", Offset = "0x897758")]
		public float poleWeight;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897770", Offset = "0x897770")]
		public float clampWeight;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897788", Offset = "0x897788")]
		public int clampSmoothing;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x1700008E")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x1488A84", Offset = "0x1488A84", VA = "0x1488A84")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700008F")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x1488B50", Offset = "0x1488B50", VA = "0x1488B50")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000090")]
		protected override int minBones
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x14898E0", Offset = "0x14898E0", VA = "0x14898E0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000091")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x1489E84", Offset = "0x1489E84", VA = "0x1489E84", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1488984", Offset = "0x1488984", VA = "0x1488984")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x1488C1C", Offset = "0x1488C1C", VA = "0x1488C1C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1488E9C", Offset = "0x1488E9C", VA = "0x1488E9C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x148982C", Offset = "0x148982C", VA = "0x148982C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1489454", Offset = "0x1489454", VA = "0x1489454")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x14898E8", Offset = "0x14898E8", VA = "0x14898E8")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1489EF8", Offset = "0x1489EF8", VA = "0x1489EF8")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000075")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1489F90", Offset = "0x1489F90", VA = "0x1489F90")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x148A040", Offset = "0x148A040", VA = "0x148A040", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x148A0C4", Offset = "0x148A0C4", VA = "0x148A0C4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x148A3C0", Offset = "0x148A3C0", VA = "0x148A3C0")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x148AB14", Offset = "0x148AB14", VA = "0x148AB14")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000076")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000092")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x148BD60", Offset = "0x148BD60", VA = "0x148BD60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x148AB1C", Offset = "0x148AB1C", VA = "0x148AB1C")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x148B264", Offset = "0x148B264", VA = "0x148B264")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x148B39C", Offset = "0x148B39C", VA = "0x148B39C", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x148B434", Offset = "0x148B434", VA = "0x148B434", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x148B9F8", Offset = "0x148B9F8", VA = "0x148B9F8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x148BD68", Offset = "0x148BD68", VA = "0x148BD68")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x148ABF0", Offset = "0x148ABF0", VA = "0x148ABF0")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x148B348", Offset = "0x148B348", VA = "0x148B348")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x148BD04", Offset = "0x148BD04", VA = "0x148BD04")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x148B08C", Offset = "0x148B08C", VA = "0x148B08C")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x148C5A8", Offset = "0x148C5A8", VA = "0x148C5A8")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x148C6B8", Offset = "0x148C6B8", VA = "0x148C6B8")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x148C7E4", Offset = "0x148C7E4", VA = "0x148C7E4")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x148C8FC", Offset = "0x148C8FC", VA = "0x148C8FC")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x148B760", Offset = "0x148B760", VA = "0x148B760")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x148B8AC", Offset = "0x148B8AC", VA = "0x148B8AC")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x148CAE8", Offset = "0x148CAE8", VA = "0x148CAE8")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x148C020", Offset = "0x148C020", VA = "0x148C020")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x148B338", Offset = "0x148B338", VA = "0x148B338")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x148D250", Offset = "0x148D250", VA = "0x148D250")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x148CCBC", Offset = "0x148CCBC", VA = "0x148CCBC")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x148BE80", Offset = "0x148BE80", VA = "0x148BE80")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x148BF5C", Offset = "0x148BF5C", VA = "0x148BF5C")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x148D31C", Offset = "0x148D31C", VA = "0x148D31C")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000077")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8977A0", Offset = "0x8977A0")]
		public float rootPin;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x148D3AC", Offset = "0x148D3AC", VA = "0x148D3AC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x148DD84", Offset = "0x148DD84", VA = "0x148DD84", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x148DE1C", Offset = "0x148DE1C", VA = "0x148DE1C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x148DEBC", Offset = "0x148DEBC", VA = "0x148DEBC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x148DFCC", Offset = "0x148DFCC", VA = "0x148DFCC")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x148E068", Offset = "0x148E068", VA = "0x148E068", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x148E5D0", Offset = "0x148E5D0", VA = "0x148E5D0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x148E7E8", Offset = "0x148E7E8", VA = "0x148E7E8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x148E680", Offset = "0x148E680", VA = "0x148E680")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x148E29C", Offset = "0x148E29C", VA = "0x148E29C")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x148E880", Offset = "0x148E880", VA = "0x148E880")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000078")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8977B8", Offset = "0x8977B8")]
		public int iterations;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x148E904", Offset = "0x148E904", VA = "0x148E904")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x148E9F8", Offset = "0x148E9F8", VA = "0x148E9F8")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x148EA54", Offset = "0x148EA54", VA = "0x148EA54")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1480B14", Offset = "0x1480B14", VA = "0x1480B14")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x147FBAC", Offset = "0x147FBAC", VA = "0x147FBAC")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x148EB88", Offset = "0x148EB88", VA = "0x148EB88", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x148ED28", Offset = "0x148ED28", VA = "0x148ED28", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x148EE9C", Offset = "0x148EE9C", VA = "0x148EE9C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x148F0A0", Offset = "0x148F0A0", VA = "0x148F0A0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x148F170", Offset = "0x148F170", VA = "0x148F170", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x148F24C", Offset = "0x148F24C", VA = "0x148F24C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x148F3BC", Offset = "0x148F3BC", VA = "0x148F3BC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x148F574", Offset = "0x148F574", VA = "0x148F574", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x148F7B0", Offset = "0x148F7B0", VA = "0x148F7B0", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x148FA70", Offset = "0x148FA70", VA = "0x148FA70", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x148FAB4", Offset = "0x148FAB4", VA = "0x148FAB4", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x148FB98", Offset = "0x148FB98", VA = "0x148FB98")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000079")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40003F0")]
		Body,
		[Token(Token = "0x40003F1")]
		LeftShoulder,
		[Token(Token = "0x40003F2")]
		RightShoulder,
		[Token(Token = "0x40003F3")]
		LeftThigh,
		[Token(Token = "0x40003F4")]
		RightThigh,
		[Token(Token = "0x40003F5")]
		LeftHand,
		[Token(Token = "0x40003F6")]
		RightHand,
		[Token(Token = "0x40003F7")]
		LeftFoot,
		[Token(Token = "0x40003F8")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x200007A")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40003FA")]
		LeftArm,
		[Token(Token = "0x40003FB")]
		RightArm,
		[Token(Token = "0x40003FC")]
		LeftLeg,
		[Token(Token = "0x40003FD")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8977D0", Offset = "0x8977D0")]
		public float spineStiffness;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8977E8", Offset = "0x8977E8")]
		public float pullBodyVertical;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897800", Offset = "0x897800")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x897818", Offset = "0x897818")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000093")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x12D860C", Offset = "0x12D860C", VA = "0x12D860C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x12D8754", Offset = "0x12D8754", VA = "0x12D8754")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x12D875C", Offset = "0x12D875C", VA = "0x12D875C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x12D8764", Offset = "0x12D8764", VA = "0x12D8764")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x12D876C", Offset = "0x12D876C", VA = "0x12D876C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x12D8774", Offset = "0x12D8774", VA = "0x12D8774")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x12D877C", Offset = "0x12D877C", VA = "0x12D877C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x12D8784", Offset = "0x12D8784", VA = "0x12D8784")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x12D878C", Offset = "0x12D878C", VA = "0x12D878C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x12D8794", Offset = "0x12D8794", VA = "0x12D8794")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x12D87CC", Offset = "0x12D87CC", VA = "0x12D87CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x12D8804", Offset = "0x12D8804", VA = "0x12D8804")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x12D883C", Offset = "0x12D883C", VA = "0x12D883C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x12D8874", Offset = "0x12D8874", VA = "0x12D8874")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000580")]
			[Address(RVA = "0x12D88A8", Offset = "0x12D88A8", VA = "0x12D88A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A2")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000581")]
			[Address(RVA = "0x12D88E0", Offset = "0x12D88E0", VA = "0x12D88E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A3")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x12D8918", Offset = "0x12D8918", VA = "0x12D8918")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A4")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x12D8950", Offset = "0x12D8950", VA = "0x12D8950")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x12DABE0", Offset = "0x12DABE0", VA = "0x12DABE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89E5BC", Offset = "0x89E5BC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x12DABEC", Offset = "0x12DABEC", VA = "0x12DABEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89E5CC", Offset = "0x89E5CC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x12D8984", Offset = "0x12D8984", VA = "0x12D8984")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x12D8A90", Offset = "0x12D8A90", VA = "0x12D8A90")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x12D89D8", Offset = "0x12D89D8", VA = "0x12D89D8")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x12D8B6C", Offset = "0x12D8B6C", VA = "0x12D8B6C")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x12D8614", Offset = "0x12D8614", VA = "0x12D8614")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x12D8C3C", Offset = "0x12D8C3C", VA = "0x12D8C3C")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x12D8CF4", Offset = "0x12D8CF4", VA = "0x12D8CF4")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x12D8DA8", Offset = "0x12D8DA8", VA = "0x12D8DA8")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x12D8E5C", Offset = "0x12D8E5C", VA = "0x12D8E5C")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x12D8E64", Offset = "0x12D8E64", VA = "0x12D8E64")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x12D8E98", Offset = "0x12D8E98", VA = "0x12D8E98")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x12D8F60", Offset = "0x12D8F60", VA = "0x12D8F60", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x12D90F8", Offset = "0x12D90F8", VA = "0x12D90F8")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x12DA4F8", Offset = "0x12DA4F8", VA = "0x12DA4F8")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x12DA98C", Offset = "0x12DA98C", VA = "0x12DA98C")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x12DA9EC", Offset = "0x12DA9EC", VA = "0x12DA9EC")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x12DA80C", Offset = "0x12DA80C", VA = "0x12DA80C")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x12DA8CC", Offset = "0x12DA8CC", VA = "0x12DA8CC")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x12DABF8", Offset = "0x12DABF8", VA = "0x12DABF8")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x12DACD4", Offset = "0x12DACD4", VA = "0x12DACD4", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x12DAE20", Offset = "0x12DAE20", VA = "0x12DAE20")]
		private void PullBody()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x12DAFB0", Offset = "0x12DAFB0", VA = "0x12DAFB0")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x12DB1B0", Offset = "0x12DB1B0", VA = "0x12DB1B0")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x12DB3B0", Offset = "0x12DB3B0", VA = "0x12DB3B0", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x12DB6E8", Offset = "0x12DB6E8", VA = "0x12DB6E8", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x12DB7EC", Offset = "0x12DB7EC", VA = "0x12DB7EC")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007C")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x170000A6")]
		protected virtual int minBones
		{
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x12DC094", Offset = "0x12DC094", VA = "0x12DC094", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A7")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x12DC09C", Offset = "0x12DC09C", VA = "0x12DC09C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A8")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x12DC0A4", Offset = "0x12DC0A4", VA = "0x12DC0A4", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A9")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x12DC634", Offset = "0x12DC634", VA = "0x12DC634", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000AA")]
		protected float positionOffset
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x12DC768", Offset = "0x12DC768", VA = "0x12DC768")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x12DB7FC", Offset = "0x12DB7FC", VA = "0x12DB7FC")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x12DB9B0", Offset = "0x12DB9B0", VA = "0x12DB9B0")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x12DBB14", Offset = "0x12DBB14", VA = "0x12DBB14", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x12DBB80", Offset = "0x12DBB80", VA = "0x12DBB80", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x12DBC00", Offset = "0x12DBC00", VA = "0x12DBC00", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x12DBF98", Offset = "0x12DBF98", VA = "0x12DBF98", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x12DBFA0", Offset = "0x12DBFA0", VA = "0x12DBFA0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x12DC0AC", Offset = "0x12DC0AC", VA = "0x12DC0AC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x12DC0B0", Offset = "0x12DC0B0", VA = "0x12DC0B0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x12DC0B4", Offset = "0x12DC0B4", VA = "0x12DC0B4")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x12DC82C", Offset = "0x12DC82C", VA = "0x12DC82C")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x12DCBD0", Offset = "0x12DCBD0", VA = "0x12DCBD0")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x12DCE84", Offset = "0x12DCE84", VA = "0x12DCE84")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007D")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897828", Offset = "0x897828")]
		public float IKRotationWeight;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x12DCF00", Offset = "0x12DCF00", VA = "0x12DCF00", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x12DD2BC", Offset = "0x12DD2BC", VA = "0x12DD2BC")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x12DD374", Offset = "0x12DD374", VA = "0x12DD374", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x12DD50C", Offset = "0x12DD50C", VA = "0x12DD50C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x12DD6A4", Offset = "0x12DD6A4", VA = "0x12DD6A4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x12DD700", Offset = "0x12DD700", VA = "0x12DD700", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x12DD770", Offset = "0x12DD770", VA = "0x12DD770", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x12DDAD4", Offset = "0x12DDAD4", VA = "0x12DDAD4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x12DDB00", Offset = "0x12DDB00", VA = "0x12DDB00")]
		private void Solve()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x12DD7D4", Offset = "0x12DD7D4", VA = "0x12DD7D4")]
		private void Read()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x12DDC00", Offset = "0x12DDC00", VA = "0x12DDC00")]
		private void Write()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x12DE124", Offset = "0x12DE124", VA = "0x12DE124")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007E")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x20000EF")]
		public enum BendModifier
		{
			[Token(Token = "0x400069D")]
			Animation,
			[Token(Token = "0x400069E")]
			Target,
			[Token(Token = "0x400069F")]
			Parent,
			[Token(Token = "0x40006A0")]
			Arm,
			[Token(Token = "0x40006A1")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x20000F0")]
		public struct AxisDirection
		{
			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x6000829")]
			[Address(RVA = "0x97D404", Offset = "0x97D404", VA = "0x97D404")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897840", Offset = "0x897840")]
		public float maintainRotationWeight;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897858", Offset = "0x897858")]
		public float bendModifierWeight;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x170000AB")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x12DFADC", Offset = "0x12DFADC", VA = "0x12DFADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x12DE384", Offset = "0x12DE384", VA = "0x12DE384")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x12DE3D4", Offset = "0x12DE3D4", VA = "0x12DE3D4")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x12DE4E8", Offset = "0x12DE4E8", VA = "0x12DE4E8", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x12DEB58", Offset = "0x12DEB58", VA = "0x12DEB58", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x12DF734", Offset = "0x12DF734", VA = "0x12DF734", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x12DF87C", Offset = "0x12DF87C", VA = "0x12DF87C")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x12DFA3C", Offset = "0x12DFA3C", VA = "0x12DFA3C")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x12DE864", Offset = "0x12DE864", VA = "0x12DE864")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x12DEC84", Offset = "0x12DEC84", VA = "0x12DEC84")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200007F")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000F1")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x170000F7")]
			public Vector3 forward
			{
				[Token(Token = "0x600082E")]
				[Address(RVA = "0x12E1A70", Offset = "0x12E1A70", VA = "0x12E1A70")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600082A")]
			[Address(RVA = "0x12E2214", Offset = "0x12E2214", VA = "0x12E2214")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x600082B")]
			[Address(RVA = "0x12E0DC0", Offset = "0x12E0DC0", VA = "0x12E0DC0")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x600082C")]
			[Address(RVA = "0x12E1148", Offset = "0x12E1148", VA = "0x12E1148")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x600082D")]
			[Address(RVA = "0x12E1E74", Offset = "0x12E1E74", VA = "0x12E1E74")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897870", Offset = "0x897870")]
		public float bodyWeight;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897888", Offset = "0x897888")]
		public float headWeight;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8978A0", Offset = "0x8978A0")]
		public float eyesWeight;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8978B8", Offset = "0x8978B8")]
		public float clampWeight;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8978D0", Offset = "0x8978D0")]
		public float clampWeightHead;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8978E8", Offset = "0x8978E8")]
		public float clampWeightEyes;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897900", Offset = "0x897900")]
		public int clampSmoothing;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] headForwards;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3[] eyeForward;

		[Token(Token = "0x170000AC")]
		private bool spineIsValid
		{
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x12E04A4", Offset = "0x12E04A4", VA = "0x12E04A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AD")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x12E067C", Offset = "0x12E067C", VA = "0x12E067C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AE")]
		private bool headIsValid
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x12E0588", Offset = "0x12E0588", VA = "0x12E0588")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AF")]
		private bool headIsEmpty
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x12E06A0", Offset = "0x12E06A0", VA = "0x12E06A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B0")]
		private bool eyesIsValid
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x12E0598", Offset = "0x12E0598", VA = "0x12E0598")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B1")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x12E071C", Offset = "0x12E071C", VA = "0x12E071C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x12DFB58", Offset = "0x12DFB58", VA = "0x12DFB58")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x12DFBDC", Offset = "0x12DFBDC", VA = "0x12DFBDC")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x12DFC88", Offset = "0x12DFC88", VA = "0x12DFC88")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x12DFD50", Offset = "0x12DFD50", VA = "0x12DFD50")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x12DFE3C", Offset = "0x12DFE3C", VA = "0x12DFE3C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x12DFF48", Offset = "0x12DFF48", VA = "0x12DFF48")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x12E0090", Offset = "0x12E0090", VA = "0x12E0090", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x12E01C0", Offset = "0x12E01C0", VA = "0x12E01C0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x12E0304", Offset = "0x12E0304", VA = "0x12E0304", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x12E0740", Offset = "0x12E0740", VA = "0x12E0740", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x12E09A8", Offset = "0x12E09A8", VA = "0x12E09A8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x12E0B48", Offset = "0x12E0B48", VA = "0x12E0B48")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x12E0DF4", Offset = "0x12E0DF4", VA = "0x12E0DF4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x12E1284", Offset = "0x12E1284", VA = "0x12E1284", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x12E1388", Offset = "0x12E1388", VA = "0x12E1388")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x12E15B4", Offset = "0x12E15B4", VA = "0x12E15B4")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x12E1810", Offset = "0x12E1810", VA = "0x12E1810")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x12E1B3C", Offset = "0x12E1B3C", VA = "0x12E1B3C")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x12E0C10", Offset = "0x12E0C10", VA = "0x12E0C10")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x12E1FDC", Offset = "0x12E1FDC", VA = "0x12E1FDC")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000F2")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x600082F")]
			[Address(RVA = "0x12E3868", Offset = "0x12E3868", VA = "0x12E3868")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000830")]
			[Address(RVA = "0x12E4410", Offset = "0x12E4410", VA = "0x12E4410")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000831")]
			[Address(RVA = "0x12DE41C", Offset = "0x12DE41C", VA = "0x12DE41C")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000832")]
			[Address(RVA = "0x12E44D8", Offset = "0x12E44D8", VA = "0x12E44D8")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897918", Offset = "0x897918")]
		public float IKRotationWeight;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x12E221C", Offset = "0x12E221C", VA = "0x12E221C")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x12E240C", Offset = "0x12E240C", VA = "0x12E240C")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x12E25C0", Offset = "0x12E25C0", VA = "0x12E25C0")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x12E25CC", Offset = "0x12E25CC", VA = "0x12E25CC")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x12E2650", Offset = "0x12E2650", VA = "0x12E2650")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x12E265C", Offset = "0x12E265C", VA = "0x12E265C")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x12E2664", Offset = "0x12E2664", VA = "0x12E2664", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x12E278C", Offset = "0x12E278C", VA = "0x12E278C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x12E28AC", Offset = "0x12E28AC", VA = "0x12E28AC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x12E28F8", Offset = "0x12E28F8", VA = "0x12E28F8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x12E2958", Offset = "0x12E2958", VA = "0x12E2958", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x12E2D64", Offset = "0x12E2D64", VA = "0x12E2D64")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x12E2DE4", Offset = "0x12E2DE4", VA = "0x12E2DE4")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x12E338C", Offset = "0x12E338C", VA = "0x12E338C")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x12E35A4", Offset = "0x12E35A4", VA = "0x12E35A4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x12E3760", Offset = "0x12E3760", VA = "0x12E3760")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x12E36DC", Offset = "0x12E36DC", VA = "0x12E36DC")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x12E3A08", Offset = "0x12E3A08", VA = "0x12E3A08", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x12E44CC", Offset = "0x12E44CC", VA = "0x12E44CC", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x12E44D0", Offset = "0x12E44D0", VA = "0x12E44D0", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x12E44D4", Offset = "0x12E44D4", VA = "0x12E44D4", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x12E4114", Offset = "0x12E4114", VA = "0x12E4114")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x12DF908", Offset = "0x12DF908", VA = "0x12DF908")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000F3")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x200011F")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x40007FD")]
				YawPitch,
				[Token(Token = "0x40007FE")]
				FromTo
			}

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899BEC", Offset = "0x899BEC")]
			public Transform target;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899C24", Offset = "0x899C24")]
			public Transform bendGoal;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899C5C", Offset = "0x899C5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x899C5C", Offset = "0x899C5C")]
			public float positionWeight;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899CB0", Offset = "0x899CB0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x899CB0", Offset = "0x899CB0")]
			public float rotationWeight;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899D04", Offset = "0x899D04")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899D3C", Offset = "0x899D3C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x899D3C", Offset = "0x899D3C")]
			public float shoulderRotationWeight;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899D90", Offset = "0x899D90")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x899D90", Offset = "0x899D90")]
			public float bendGoalWeight;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899DE4", Offset = "0x899DE4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x899DE4", Offset = "0x899DE4")]
			public float swivelOffset;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899E40", Offset = "0x899E40")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899E78", Offset = "0x899E78")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899EB0", Offset = "0x899EB0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x899EB0", Offset = "0x899EB0")]
			public float armLengthMlp;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899F08", Offset = "0x899F08")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x899F80", Offset = "0x899F80")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x899F90", Offset = "0x899F90")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x40006C0")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x40006C1")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x170000F8")]
			public Vector3 position
			{
				[Token(Token = "0x6000833")]
				[Address(RVA = "0x12EC710", Offset = "0x12EC710", VA = "0x12EC710")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F538", Offset = "0x89F538")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000834")]
				[Address(RVA = "0x12EC71C", Offset = "0x12EC71C", VA = "0x12EC71C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F548", Offset = "0x89F548")]
				private set
				{
				}
			}

			[Token(Token = "0x170000F9")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000835")]
				[Address(RVA = "0x12EC728", Offset = "0x12EC728", VA = "0x12EC728")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F558", Offset = "0x89F558")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000836")]
				[Address(RVA = "0x12EC734", Offset = "0x12EC734", VA = "0x12EC734")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F568", Offset = "0x89F568")]
				private set
				{
				}
			}

			[Token(Token = "0x170000FA")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000837")]
				[Address(RVA = "0x12EC740", Offset = "0x12EC740", VA = "0x12EC740")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FB")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000838")]
				[Address(RVA = "0x12EC774", Offset = "0x12EC774", VA = "0x12EC774")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FC")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000839")]
				[Address(RVA = "0x12EC7AC", Offset = "0x12EC7AC", VA = "0x12EC7AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FD")]
			private VirtualBone hand
			{
				[Token(Token = "0x600083A")]
				[Address(RVA = "0x12EC7E4", Offset = "0x12EC7E4", VA = "0x12EC7E4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600083B")]
			[Address(RVA = "0x12EC81C", Offset = "0x12EC81C", VA = "0x12EC81C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600083C")]
			[Address(RVA = "0x12ECFEC", Offset = "0x12ECFEC", VA = "0x12ECFEC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600083D")]
			[Address(RVA = "0x12ED1E0", Offset = "0x12ED1E0", VA = "0x12ED1E0", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600083E")]
			[Address(RVA = "0x12ED28C", Offset = "0x12ED28C", VA = "0x12ED28C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600083F")]
			[Address(RVA = "0x12EA7DC", Offset = "0x12EA7DC", VA = "0x12EA7DC")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000840")]
			[Address(RVA = "0x12EDED8", Offset = "0x12EDED8", VA = "0x12EDED8", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000841")]
			[Address(RVA = "0x12EDF48", Offset = "0x12EDF48", VA = "0x12EDF48", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000842")]
			[Address(RVA = "0x12ED6A4", Offset = "0x12ED6A4", VA = "0x12ED6A4")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000843")]
			[Address(RVA = "0x12ED77C", Offset = "0x12ED77C", VA = "0x12ED77C")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000844")]
			[Address(RVA = "0x12EE168", Offset = "0x12EE168", VA = "0x12EE168")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000845")]
			[Address(RVA = "0x12EC4F8", Offset = "0x12EC4F8", VA = "0x12EC4F8")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F4")]
		public abstract class BodyPart
		{
			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x899FA0", Offset = "0x899FA0")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x899FB0", Offset = "0x899FB0")]
			private float <mag>k__BackingField;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x170000FE")]
			public float sqrMag
			{
				[Token(Token = "0x600084B")]
				[Address(RVA = "0x12EE334", Offset = "0x12EE334", VA = "0x12EE334")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F578", Offset = "0x89F578")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600084C")]
				[Address(RVA = "0x12EE33C", Offset = "0x12EE33C", VA = "0x12EE33C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F588", Offset = "0x89F588")]
				private set
				{
				}
			}

			[Token(Token = "0x170000FF")]
			public float mag
			{
				[Token(Token = "0x600084D")]
				[Address(RVA = "0x12EE344", Offset = "0x12EE344", VA = "0x12EE344")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F598", Offset = "0x89F598")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600084E")]
				[Address(RVA = "0x12EE34C", Offset = "0x12EE34C", VA = "0x12EE34C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F5A8", Offset = "0x89F5A8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000846")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index);

			[Token(Token = "0x6000847")]
			public abstract void PreSolve();

			[Token(Token = "0x6000848")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000849")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x600084A")]
			public abstract void ResetOffsets();

			[Token(Token = "0x600084F")]
			[Address(RVA = "0x12DE05C", Offset = "0x12DE05C", VA = "0x12DE05C")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000850")]
			[Address(RVA = "0x12EE354", Offset = "0x12EE354", VA = "0x12EE354")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000851")]
			[Address(RVA = "0x12EE4C0", Offset = "0x12EE4C0", VA = "0x12EE4C0")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000852")]
			[Address(RVA = "0x12EE56C", Offset = "0x12EE56C", VA = "0x12EE56C")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000853")]
			[Address(RVA = "0x12EA598", Offset = "0x12EA598", VA = "0x12EA598")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000854")]
			[Address(RVA = "0x12EDD34", Offset = "0x12EDD34", VA = "0x12EDD34")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000855")]
			[Address(RVA = "0x12EE5C0", Offset = "0x12EE5C0", VA = "0x12EE5C0")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000856")]
			[Address(RVA = "0x12EE704", Offset = "0x12EE704", VA = "0x12EE704")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000857")]
			[Address(RVA = "0x12EE290", Offset = "0x12EE290", VA = "0x12EE290")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F5")]
		public class Footstep
		{
			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x899FD0", Offset = "0x899FD0")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x17000100")]
			public bool isStepping
			{
				[Token(Token = "0x6000858")]
				[Address(RVA = "0x12EE72C", Offset = "0x12EE72C", VA = "0x12EE72C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000101")]
			public float stepProgress
			{
				[Token(Token = "0x6000859")]
				[Address(RVA = "0x12EE740", Offset = "0x12EE740", VA = "0x12EE740")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F5B8", Offset = "0x89F5B8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600085A")]
				[Address(RVA = "0x12EE748", Offset = "0x12EE748", VA = "0x12EE748")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F5C8", Offset = "0x89F5C8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000102")]
			public float DeltaTime
			{
				[Token(Token = "0x600085B")]
				[Address(RVA = "0x12EE750", Offset = "0x12EE750", VA = "0x12EE750")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600085C")]
			[Address(RVA = "0x12EE758", Offset = "0x12EE758", VA = "0x12EE758")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x600085D")]
			[Address(RVA = "0x12EE888", Offset = "0x12EE888", VA = "0x12EE888")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x600085E")]
			[Address(RVA = "0x12EE9B8", Offset = "0x12EE9B8", VA = "0x12EE9B8")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600085F")]
			[Address(RVA = "0x12EEAB8", Offset = "0x12EEAB8", VA = "0x12EEAB8")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000860")]
			[Address(RVA = "0x12EEC90", Offset = "0x12EEC90", VA = "0x12EEC90")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000861")]
			[Address(RVA = "0x12EEE7C", Offset = "0x12EEE7C", VA = "0x12EEE7C")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F6")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x899FE0", Offset = "0x899FE0")]
			public Transform target;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A018", Offset = "0x89A018")]
			public Transform bendGoal;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A050", Offset = "0x89A050")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89A050", Offset = "0x89A050")]
			public float positionWeight;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A0A4", Offset = "0x89A0A4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89A0A4", Offset = "0x89A0A4")]
			public float rotationWeight;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A0F8", Offset = "0x89A0F8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89A0F8", Offset = "0x89A0F8")]
			public float bendGoalWeight;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A14C", Offset = "0x89A14C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89A14C", Offset = "0x89A14C")]
			public float swivelOffset;

			[NonSerialized]
			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89A208", Offset = "0x89A208")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89A218", Offset = "0x89A218")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89A228", Offset = "0x89A228")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89A238", Offset = "0x89A238")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Vector3 footPosition;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private Quaternion footRotation;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 bendNormal;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x17000103")]
			public Vector3 position
			{
				[Token(Token = "0x6000862")]
				[Address(RVA = "0x12EF098", Offset = "0x12EF098", VA = "0x12EF098")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F5D8", Offset = "0x89F5D8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000863")]
				[Address(RVA = "0x12EF0A4", Offset = "0x12EF0A4", VA = "0x12EF0A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F5E8", Offset = "0x89F5E8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000104")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000864")]
				[Address(RVA = "0x12EF0B0", Offset = "0x12EF0B0", VA = "0x12EF0B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F5F8", Offset = "0x89F5F8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000865")]
				[Address(RVA = "0x12EF0BC", Offset = "0x12EF0BC", VA = "0x12EF0BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F608", Offset = "0x89F608")]
				private set
				{
				}
			}

			[Token(Token = "0x17000105")]
			public bool hasToes
			{
				[Token(Token = "0x6000866")]
				[Address(RVA = "0x12EF0C8", Offset = "0x12EF0C8", VA = "0x12EF0C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F618", Offset = "0x89F618")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000867")]
				[Address(RVA = "0x12EF0D0", Offset = "0x12EF0D0", VA = "0x12EF0D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F628", Offset = "0x89F628")]
				private set
				{
				}
			}

			[Token(Token = "0x17000106")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000868")]
				[Address(RVA = "0x12EF0DC", Offset = "0x12EF0DC", VA = "0x12EF0DC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000107")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000869")]
				[Address(RVA = "0x12EF110", Offset = "0x12EF110", VA = "0x12EF110")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000108")]
			private VirtualBone foot
			{
				[Token(Token = "0x600086A")]
				[Address(RVA = "0x12EF148", Offset = "0x12EF148", VA = "0x12EF148")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000109")]
			private VirtualBone toes
			{
				[Token(Token = "0x600086B")]
				[Address(RVA = "0x12EF180", Offset = "0x12EF180", VA = "0x12EF180")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010A")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x600086C")]
				[Address(RVA = "0x12EA3E0", Offset = "0x12EA3E0", VA = "0x12EA3E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010B")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x600086D")]
				[Address(RVA = "0x12EF1B8", Offset = "0x12EF1B8", VA = "0x12EF1B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F638", Offset = "0x89F638")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600086E")]
				[Address(RVA = "0x12EF1C4", Offset = "0x12EF1C4", VA = "0x12EF1C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F648", Offset = "0x89F648")]
				private set
				{
				}
			}

			[Token(Token = "0x600086F")]
			[Address(RVA = "0x12EF1D0", Offset = "0x12EF1D0", VA = "0x12EF1D0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000870")]
			[Address(RVA = "0x12EF718", Offset = "0x12EF718", VA = "0x12EF718", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000871")]
			[Address(RVA = "0x12EFDF8", Offset = "0x12EFDF8", VA = "0x12EFDF8", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000872")]
			[Address(RVA = "0x12EFCF4", Offset = "0x12EFCF4", VA = "0x12EFCF4")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000873")]
			[Address(RVA = "0x12EFACC", Offset = "0x12EFACC", VA = "0x12EFACC")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000874")]
			[Address(RVA = "0x12DDD18", Offset = "0x12DDD18", VA = "0x12DDD18")]
			public void Solve()
			{
			}

			[Token(Token = "0x6000875")]
			[Address(RVA = "0x12F039C", Offset = "0x12F039C", VA = "0x12F039C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000876")]
			[Address(RVA = "0x12F04A4", Offset = "0x12F04A4", VA = "0x12F04A4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000877")]
			[Address(RVA = "0x12DE2D8", Offset = "0x12DE2D8", VA = "0x12DE2D8")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F7")]
		public class Locomotion
		{
			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A248", Offset = "0x89A248")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89A248", Offset = "0x89A248")]
			public float weight;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A29C", Offset = "0x89A29C")]
			public float footDistance;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A2D4", Offset = "0x89A2D4")]
			public float stepThreshold;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A30C", Offset = "0x89A30C")]
			public float angleThreshold;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A344", Offset = "0x89A344")]
			public float comAngleMlp;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A37C", Offset = "0x89A37C")]
			public float maxVelocity;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A3B4", Offset = "0x89A3B4")]
			public float velocityFactor;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A3EC", Offset = "0x89A3EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89A3EC", Offset = "0x89A3EC")]
			public float maxLegStretch;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A444", Offset = "0x89A444")]
			public float rootSpeed;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A47C", Offset = "0x89A47C")]
			public float stepSpeed;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A4B4", Offset = "0x89A4B4")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A4EC", Offset = "0x89A4EC")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A524", Offset = "0x89A524")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89A524", Offset = "0x89A524")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A57C", Offset = "0x89A57C")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A5B4", Offset = "0x89A5B4")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A5EC", Offset = "0x89A5EC")]
			public Vector3 offset;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float LegUpdateAngle;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A664", Offset = "0x89A664")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A69C", Offset = "0x89A69C")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89A6D4", Offset = "0x89A6D4")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Footstep[] footsteps;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Vector3 lastComPosition;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int leftFootIndex;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int rightFootIndex;

			[Token(Token = "0x1700010C")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000878")]
				[Address(RVA = "0x12F0554", Offset = "0x12F0554", VA = "0x12F0554")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F658", Offset = "0x89F658")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000879")]
				[Address(RVA = "0x12F0560", Offset = "0x12F0560", VA = "0x12F0560")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F668", Offset = "0x89F668")]
				private set
				{
				}
			}

			[Token(Token = "0x1700010D")]
			public float DeltaTime
			{
				[Token(Token = "0x600087A")]
				[Address(RVA = "0x12F056C", Offset = "0x12F056C", VA = "0x12F056C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700010E")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000880")]
				[Address(RVA = "0x12F09A8", Offset = "0x12F09A8", VA = "0x12F09A8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700010F")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000881")]
				[Address(RVA = "0x12F09E8", Offset = "0x12F09E8", VA = "0x12F09E8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000110")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000882")]
				[Address(RVA = "0x12F0A2C", Offset = "0x12F0A2C", VA = "0x12F0A2C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000111")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000883")]
				[Address(RVA = "0x12F0A6C", Offset = "0x12F0A6C", VA = "0x12F0A6C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600087B")]
			[Address(RVA = "0x12E8678", Offset = "0x12E8678", VA = "0x12E8678")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x600087C")]
			[Address(RVA = "0x12E6740", Offset = "0x12E6740", VA = "0x12E6740")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x600087D")]
			[Address(RVA = "0x12E5B58", Offset = "0x12E5B58", VA = "0x12E5B58")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x600087E")]
			[Address(RVA = "0x12E59A8", Offset = "0x12E59A8", VA = "0x12E59A8")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x600087F")]
			[Address(RVA = "0x12E8F20", Offset = "0x12E8F20", VA = "0x12E8F20")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000884")]
			[Address(RVA = "0x12F05B4", Offset = "0x12F05B4", VA = "0x12F05B4")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000885")]
			[Address(RVA = "0x12F0758", Offset = "0x12F0758", VA = "0x12F0758")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000886")]
			[Address(RVA = "0x12F07DC", Offset = "0x12F07DC", VA = "0x12F07DC")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000887")]
			[Address(RVA = "0x12EC600", Offset = "0x12EC600", VA = "0x12EC600")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F8")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A6E4", Offset = "0x89A6E4")]
			public Transform headTarget;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A71C", Offset = "0x89A71C")]
			public Transform pelvisTarget;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A754", Offset = "0x89A754")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89A754", Offset = "0x89A754")]
			public float positionWeight;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A7A8", Offset = "0x89A7A8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89A7A8", Offset = "0x89A7A8")]
			public float rotationWeight;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A7FC", Offset = "0x89A7FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89A7FC", Offset = "0x89A7FC")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A850", Offset = "0x89A850")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89A850", Offset = "0x89A850")]
			public float pelvisRotationWeight;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A8A4", Offset = "0x89A8A4")]
			public Transform chestGoal;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A8DC", Offset = "0x89A8DC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89A8DC", Offset = "0x89A8DC")]
			public float chestGoalWeight;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A930", Offset = "0x89A930")]
			public float minHeadHeight;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A968", Offset = "0x89A968")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89A968", Offset = "0x89A968")]
			public float bodyPosStiffness;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89A9BC", Offset = "0x89A9BC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89A9BC", Offset = "0x89A9BC")]
			public float bodyRotStiffness;

			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89AA10", Offset = "0x89AA10")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x89AA10", Offset = "0x89AA10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89AA10", Offset = "0x89AA10")]
			public float neckStiffness;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89AA88", Offset = "0x89AA88")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89AA88", Offset = "0x89AA88")]
			public float rotateChestByHands;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89AADC", Offset = "0x89AADC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89AADC", Offset = "0x89AADC")]
			public float chestClampWeight;

			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89AB30", Offset = "0x89AB30")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89AB30", Offset = "0x89AB30")]
			public float headClampWeight;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89AB84", Offset = "0x89AB84")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89ABBC", Offset = "0x89ABBC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89ABBC", Offset = "0x89ABBC")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89AC10", Offset = "0x89AC10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89AC10", Offset = "0x89AC10")]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89AD48", Offset = "0x89AD48")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private Quaternion headRotation;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private int pelvisIndex;

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private int spineIndex;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
			private int chestIndex;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private int neckIndex;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private int headIndex;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private float length;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
			private bool hasChest;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1ED")]
			private bool hasNeck;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private float headHeight;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			private float sizeMlp;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private Vector3 chestForward;

			[Token(Token = "0x17000112")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000888")]
				[Address(RVA = "0x12E69B4", Offset = "0x12E69B4", VA = "0x12E69B4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000113")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000889")]
				[Address(RVA = "0x12F0AB0", Offset = "0x12F0AB0", VA = "0x12F0AB0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000114")]
			public VirtualBone chest
			{
				[Token(Token = "0x600088A")]
				[Address(RVA = "0x12EA788", Offset = "0x12EA788", VA = "0x12EA788")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000115")]
			private VirtualBone neck
			{
				[Token(Token = "0x600088B")]
				[Address(RVA = "0x12F0AF0", Offset = "0x12F0AF0", VA = "0x12F0AF0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000116")]
			public VirtualBone head
			{
				[Token(Token = "0x600088C")]
				[Address(RVA = "0x12F0574", Offset = "0x12F0574", VA = "0x12F0574")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000117")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x600088D")]
				[Address(RVA = "0x12F0B30", Offset = "0x12F0B30", VA = "0x12F0B30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F678", Offset = "0x89F678")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600088E")]
				[Address(RVA = "0x12F0B44", Offset = "0x12F0B44", VA = "0x12F0B44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F688", Offset = "0x89F688")]
				private set
				{
				}
			}

			[Token(Token = "0x600088F")]
			[Address(RVA = "0x12F0B58", Offset = "0x12F0B58", VA = "0x12F0B58", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000890")]
			[Address(RVA = "0x12F15CC", Offset = "0x12F15CC", VA = "0x12F15CC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000891")]
			[Address(RVA = "0x12F17A0", Offset = "0x12F17A0", VA = "0x12F17A0", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000892")]
			[Address(RVA = "0x12F1CC4", Offset = "0x12F1CC4", VA = "0x12F1CC4")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000893")]
			[Address(RVA = "0x12E8990", Offset = "0x12E8990", VA = "0x12E8990")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000894")]
			[Address(RVA = "0x12F2684", Offset = "0x12F2684", VA = "0x12F2684")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x6000895")]
			[Address(RVA = "0x12F2D38", Offset = "0x12F2D38", VA = "0x12F2D38")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000896")]
			[Address(RVA = "0x12F30EC", Offset = "0x12F30EC", VA = "0x12F30EC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000897")]
			[Address(RVA = "0x12F32C8", Offset = "0x12F32C8", VA = "0x12F32C8", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000898")]
			[Address(RVA = "0x12F1EF4", Offset = "0x12F1EF4", VA = "0x12F1EF4")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000899")]
			[Address(RVA = "0x12EA420", Offset = "0x12EA420", VA = "0x12EA420")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x600089A")]
			[Address(RVA = "0x12F2278", Offset = "0x12F2278", VA = "0x12F2278")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x600089B")]
			[Address(RVA = "0x12F33C0", Offset = "0x12F33C0", VA = "0x12F33C0")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600089C")]
			[Address(RVA = "0x12F2AE8", Offset = "0x12F2AE8", VA = "0x12F2AE8")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600089D")]
			[Address(RVA = "0x12F287C", Offset = "0x12F287C", VA = "0x12F287C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600089E")]
			[Address(RVA = "0x12EC35C", Offset = "0x12EC35C", VA = "0x12EC35C")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F9")]
		public enum PositionOffset
		{
			[Token(Token = "0x400073C")]
			Pelvis,
			[Token(Token = "0x400073D")]
			Chest,
			[Token(Token = "0x400073E")]
			Head,
			[Token(Token = "0x400073F")]
			LeftHand,
			[Token(Token = "0x4000740")]
			RightHand,
			[Token(Token = "0x4000741")]
			LeftFoot,
			[Token(Token = "0x4000742")]
			RightFoot,
			[Token(Token = "0x4000743")]
			LeftHeel,
			[Token(Token = "0x4000744")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000FA")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000746")]
			Pelvis,
			[Token(Token = "0x4000747")]
			Chest,
			[Token(Token = "0x4000748")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000FB")]
		public class VirtualBone
		{
			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x600089F")]
			[Address(RVA = "0x10F6368", Offset = "0x10F6368", VA = "0x10F6368")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x10F63E4", Offset = "0x10F63E4", VA = "0x10F63E4")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x10F6404", Offset = "0x10F6404", VA = "0x10F6404")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x10F6694", Offset = "0x10F6694", VA = "0x10F6694")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x10F6980", Offset = "0x10F6980", VA = "0x10F6980")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x10F6B60", Offset = "0x10F6B60", VA = "0x10F6B60")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x10F6D78", Offset = "0x10F6D78", VA = "0x10F6D78")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x10F6F98", Offset = "0x10F6F98", VA = "0x10F6F98")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x10F7050", Offset = "0x10F7050", VA = "0x10F7050")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x10F75FC", Offset = "0x10F75FC", VA = "0x10F75FC")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x10F7814", Offset = "0x10F7814", VA = "0x10F7814")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x10F7C54", Offset = "0x10F7C54", VA = "0x10F7C54")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x10F7D5C", Offset = "0x10F7D5C", VA = "0x10F7D5C")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897930", Offset = "0x897930")]
		public bool plantFeet;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x897968", Offset = "0x897968")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897978", Offset = "0x897978")]
		public Spine spine;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8979B0", Offset = "0x8979B0")]
		public Arm leftArm;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8979E8", Offset = "0x8979E8")]
		public Arm rightArm;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897A20", Offset = "0x897A20")]
		public Leg leftLeg;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897A58", Offset = "0x897A58")]
		public Leg rightLeg;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897A90", Offset = "0x897A90")]
		public Locomotion locomotion;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Leg[] legs;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Arm[] arms;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3 headPosition;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 lastOffset;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 debugPos1;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 debugPos2;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos3;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos4;

		[Token(Token = "0x170000B2")]
		public float DeltaTime
		{
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x12E8670", Offset = "0x12E8670", VA = "0x12E8670")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B3")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x12EBB08", Offset = "0x12EBB08", VA = "0x12EBB08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89E5DC", Offset = "0x89E5DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x12EBB10", Offset = "0x12EBB10", VA = "0x12EBB10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89E5EC", Offset = "0x89E5EC")]
			private set
			{
			}
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x12E44E0", Offset = "0x12E44E0", VA = "0x12E44E0")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x12E492C", Offset = "0x12E492C", VA = "0x12E492C")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x12E47B4", Offset = "0x12E47B4", VA = "0x12E47B4")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x12E5310", Offset = "0x12E5310", VA = "0x12E5310")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x12E55EC", Offset = "0x12E55EC", VA = "0x12E55EC")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x12E5690", Offset = "0x12E5690", VA = "0x12E5690")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x12E5824", Offset = "0x12E5824", VA = "0x12E5824")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x12E5F30", Offset = "0x12E5F30", VA = "0x12E5F30")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x12E69F4", Offset = "0x12E69F4", VA = "0x12E69F4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x12E6B68", Offset = "0x12E6B68", VA = "0x12E6B68", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x12E6D04", Offset = "0x12E6D04", VA = "0x12E6D04", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x12E6D78", Offset = "0x12E6D78", VA = "0x12E6D78", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x12E6DEC", Offset = "0x12E6DEC", VA = "0x12E6DEC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x12E700C", Offset = "0x12E700C", VA = "0x12E700C")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x12E4BC4", Offset = "0x12E4BC4", VA = "0x12E4BC4")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x12E4D9C", Offset = "0x12E4D9C", VA = "0x12E4D9C")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x12E51EC", Offset = "0x12E51EC", VA = "0x12E51EC")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x12E608C", Offset = "0x12E608C", VA = "0x12E608C")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x12E72EC", Offset = "0x12E72EC", VA = "0x12E72EC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x12E7324", Offset = "0x12E7324", VA = "0x12E7324", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x12E8424", Offset = "0x12E8424", VA = "0x12E8424")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x12E61F4", Offset = "0x12E61F4", VA = "0x12E61F4")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x12E7484", Offset = "0x12E7484", VA = "0x12E7484")]
		private void Solve(bool updateLegs)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x12E8628", Offset = "0x12E8628", VA = "0x12E8628")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x12E85E4", Offset = "0x12E85E4", VA = "0x12E85E4")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x12E82D4", Offset = "0x12E82D4", VA = "0x12E82D4")]
		private void Write(bool updateLegs)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x12EBB18", Offset = "0x12EBB18", VA = "0x12EBB18")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x12EC100", Offset = "0x12EC100", VA = "0x12EC100")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897AC8", Offset = "0x897AC8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897AC8", Offset = "0x897AC8")]
		public float weight;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897B1C", Offset = "0x897B1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897B1C", Offset = "0x897B1C")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897B70", Offset = "0x897B70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x897B70", Offset = "0x897B70")]
		public float twistAngleOffset;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 axis;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform parent;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform child;

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x110AB38", Offset = "0x110AB38", VA = "0x110AB38")]
		public void Relax()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x110AF18", Offset = "0x110AF18", VA = "0x110AF18")]
		private void Start()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x110B364", Offset = "0x110B364", VA = "0x110B364")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x110B3EC", Offset = "0x110B3EC", VA = "0x110B3EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x110B474", Offset = "0x110B474", VA = "0x110B474")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x110B59C", Offset = "0x110B59C", VA = "0x110B59C")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public class InteractionEffector
	{
		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x897BCC", Offset = "0x897BCC")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x897BDC", Offset = "0x897BDC")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x897BEC", Offset = "0x897BEC")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float resetTimer;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool positionWeightUsed;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool rotationWeightUsed;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool pullUsed;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reachUsed;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool pushUsed;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool pushParentUsed;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pickedUp;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool defaults;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform target;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<bool> triggered;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool started;

		[Token(Token = "0x170000B4")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x10F8680", Offset = "0x10F8680", VA = "0x10F8680")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89E5FC", Offset = "0x89E5FC")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x10F8688", Offset = "0x10F8688", VA = "0x10F8688")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89E60C", Offset = "0x89E60C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public bool isPaused
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x10F8690", Offset = "0x10F8690", VA = "0x10F8690")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89E61C", Offset = "0x89E61C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x10F8698", Offset = "0x10F8698", VA = "0x10F8698")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89E62C", Offset = "0x89E62C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x10F86A4", Offset = "0x10F86A4", VA = "0x10F86A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89E63C", Offset = "0x89E63C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x10F86AC", Offset = "0x10F86AC", VA = "0x10F86AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89E64C", Offset = "0x89E64C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		public bool inInteraction
		{
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x10F86B4", Offset = "0x10F86B4", VA = "0x10F86B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B8")]
		public float progress
		{
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x10FB064", Offset = "0x10FB064", VA = "0x10FB064")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x10F8724", Offset = "0x10F8724", VA = "0x10F8724")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x10F87B4", Offset = "0x10F87B4", VA = "0x10F87B4")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x10F8884", Offset = "0x10F8884", VA = "0x10F8884")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x10F89C4", Offset = "0x10F89C4", VA = "0x10F89C4")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x10F8DC8", Offset = "0x10F8DC8", VA = "0x10F8DC8")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x10F9180", Offset = "0x10F9180", VA = "0x10F9180")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x10F91D4", Offset = "0x10F91D4", VA = "0x10F91D4")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x10F9D70", Offset = "0x10F9D70", VA = "0x10F9D70")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x10FA898", Offset = "0x10FA898", VA = "0x10FA898")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x10FAAC0", Offset = "0x10FAAC0", VA = "0x10FAAC0")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x10FAEF4", Offset = "0x10FAEF4", VA = "0x10FAEF4")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x10FB540", Offset = "0x10FB540", VA = "0x10FB540")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000084")]
	public class InteractionLookAt
	{
		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897BFC", Offset = "0x897BFC")]
		public LookAtIK ik;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897C34", Offset = "0x897C34")]
		public float lerpSpeed;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897C6C", Offset = "0x897C6C")]
		public float weightSpeed;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x10FB7A4", Offset = "0x10FB7A4", VA = "0x10FB7A4")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x10FB928", Offset = "0x10FB928", VA = "0x10FB928")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x10FB9D0", Offset = "0x10FB9D0", VA = "0x10FB9D0")]
		public void Update()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x10FBC24", Offset = "0x10FBC24", VA = "0x10FBC24")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x10FBD1C", Offset = "0x10FBD1C", VA = "0x10FBD1C")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x10FBDE8", Offset = "0x10FBDE8", VA = "0x10FBDE8")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8938AC", Offset = "0x8938AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8938AC", Offset = "0x8938AC")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000FC")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89AD58", Offset = "0x89AD58")]
			public float time;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89AD90", Offset = "0x89AD90")]
			public bool pause;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89ADC8", Offset = "0x89ADC8")]
			public bool pickUp;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89AE00", Offset = "0x89AE00")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89AE38", Offset = "0x89AE38")]
			public Message[] messages;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89AE70", Offset = "0x89AE70")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x10FB0A0", Offset = "0x10FB0A0", VA = "0x10FB0A0")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60008AD")]
			[Address(RVA = "0x10FD09C", Offset = "0x10FD09C", VA = "0x10FD09C")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FD")]
		public class Message
		{
			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89AEA8", Offset = "0x89AEA8")]
			public string function;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89AEE0", Offset = "0x89AEE0")]
			public GameObject recipient;

			[Token(Token = "0x4000758")]
			private const string empty = "";

			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x10FCFAC", Offset = "0x10FCFAC", VA = "0x10FCFAC")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x10FD0A4", Offset = "0x10FD0A4", VA = "0x10FD0A4")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FE")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89AF18", Offset = "0x89AF18")]
			public Animator animator;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89AF50", Offset = "0x89AF50")]
			public Animation animation;

			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89AF88", Offset = "0x89AF88")]
			public string animationState;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89AFC0", Offset = "0x89AFC0")]
			public float crossfadeTime;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89AFF8", Offset = "0x89AFF8")]
			public int layer;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B030", Offset = "0x89B030")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400075F")]
			private const string empty = "";

			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x10FCD0C", Offset = "0x10FCD0C", VA = "0x10FCD0C")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x10FCE00", Offset = "0x10FCE00", VA = "0x10FCE00")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x10FCEB8", Offset = "0x10FCEB8", VA = "0x10FCEB8")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x10FCF98", Offset = "0x10FCF98", VA = "0x10FCF98")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FF")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x2000120")]
			public enum Type
			{
				[Token(Token = "0x4000800")]
				PositionWeight,
				[Token(Token = "0x4000801")]
				RotationWeight,
				[Token(Token = "0x4000802")]
				PositionOffsetX,
				[Token(Token = "0x4000803")]
				PositionOffsetY,
				[Token(Token = "0x4000804")]
				PositionOffsetZ,
				[Token(Token = "0x4000805")]
				Pull,
				[Token(Token = "0x4000806")]
				Reach,
				[Token(Token = "0x4000807")]
				RotateBoneWeight,
				[Token(Token = "0x4000808")]
				Push,
				[Token(Token = "0x4000809")]
				PushParent,
				[Token(Token = "0x400080A")]
				PoserWeight
			}

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B068", Offset = "0x89B068")]
			public Type type;

			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B0A0", Offset = "0x89B0A0")]
			public AnimationCurve curve;

			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x10FC4FC", Offset = "0x10FC4FC", VA = "0x10FC4FC")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x10FD0BC", Offset = "0x10FD0BC", VA = "0x10FD0BC")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000100")]
		public class Multiplier
		{
			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B0D8", Offset = "0x89B0D8")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B110", Offset = "0x89B110")]
			public float multiplier;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B148", Offset = "0x89B148")]
			public WeightCurve.Type result;

			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x10FCB60", Offset = "0x10FCB60", VA = "0x10FCB60")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x10FD0AC", Offset = "0x10FD0AC", VA = "0x10FD0AC")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897CB4", Offset = "0x897CB4")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897CEC", Offset = "0x897CEC")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897D24", Offset = "0x897D24")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x897D5C", Offset = "0x897D5C")]
		private float <length>k__BackingField;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x897D6C", Offset = "0x897D6C")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x170000B9")]
		public float length
		{
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x10FBFC4", Offset = "0x10FBFC4", VA = "0x10FBFC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89E7AC", Offset = "0x89E7AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x10FBFCC", Offset = "0x10FBFCC", VA = "0x10FBFCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89E7BC", Offset = "0x89E7BC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x10FBFD4", Offset = "0x10FBFD4", VA = "0x10FBFD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89E7CC", Offset = "0x89E7CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x10FBFDC", Offset = "0x10FBFDC", VA = "0x10FBFDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89E7DC", Offset = "0x89E7DC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x10FC200", Offset = "0x10FC200", VA = "0x10FC200")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		public Transform targetsRoot
		{
			[Token(Token = "0x600064B")]
			[Address(RVA = "0x10FB414", Offset = "0x10FB414", VA = "0x10FB414")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x10FBDFC", Offset = "0x10FBDFC", VA = "0x10FBDFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E65C", Offset = "0x89E65C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x10FBE48", Offset = "0x10FBE48", VA = "0x10FBE48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E694", Offset = "0x89E694")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x10FBE94", Offset = "0x10FBE94", VA = "0x10FBE94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E6CC", Offset = "0x89E6CC")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x10FBEE0", Offset = "0x10FBEE0", VA = "0x10FBEE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E704", Offset = "0x89E704")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x10FBF2C", Offset = "0x10FBF2C", VA = "0x10FBF2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E73C", Offset = "0x89E73C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x10FBF78", Offset = "0x10FBF78", VA = "0x10FBF78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E774", Offset = "0x89E774")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x10FBFE4", Offset = "0x10FBFE4", VA = "0x10FBFE4")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x10FC290", Offset = "0x10FC290", VA = "0x10FC290")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x10F9790", Offset = "0x10F9790", VA = "0x10F9790")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x10FC414", Offset = "0x10FC414", VA = "0x10FC414")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x10F9644", Offset = "0x10F9644", VA = "0x10F9644")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x10F9788", Offset = "0x10F9788", VA = "0x10F9788")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x10FA47C", Offset = "0x10FA47C", VA = "0x10FA47C")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x10FACCC", Offset = "0x10FACCC", VA = "0x10FACCC")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x10FCB9C", Offset = "0x10FCB9C", VA = "0x10FCB9C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x10FC518", Offset = "0x10FC518", VA = "0x10FC518")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x10FC41C", Offset = "0x10FC41C", VA = "0x10FC41C")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x10FCAF8", Offset = "0x10FCAF8", VA = "0x10FCAF8")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x10FCBA0", Offset = "0x10FCBA0", VA = "0x10FCBA0")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x10FCC08", Offset = "0x10FCC08", VA = "0x10FCC08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E7EC", Offset = "0x89E7EC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x10FCC54", Offset = "0x10FCC54", VA = "0x10FCC54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E824", Offset = "0x89E824")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x10FCCA0", Offset = "0x10FCCA0", VA = "0x10FCCA0")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x89390C", Offset = "0x89390C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x89390C", Offset = "0x89390C")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x2000101")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x2000102")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897D7C", Offset = "0x897D7C")]
		public string targetTag;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897DB4", Offset = "0x897DB4")]
		public float fadeInTime;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897DEC", Offset = "0x897DEC")]
		public float speed;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897E24", Offset = "0x897E24")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x897E5C", Offset = "0x897E5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897E5C", Offset = "0x897E5C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x897E5C", Offset = "0x897E5C")]
		public Collider characterCollider;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897EE0", Offset = "0x897EE0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x897EE0", Offset = "0x897EE0")]
		public Transform FPSCamera;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897F40", Offset = "0x897F40")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897F78", Offset = "0x897F78")]
		public float camRaycastDistance;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x897FB0", Offset = "0x897FB0")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x897FC0", Offset = "0x897FC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x897FC0", Offset = "0x897FC0")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898020", Offset = "0x898020")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x170000BD")]
		public bool inInteraction
		{
			[Token(Token = "0x600065A")]
			[Address(RVA = "0x10FD28C", Offset = "0x10FD28C", VA = "0x10FD28C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BE")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000674")]
			[Address(RVA = "0x10FEEE4", Offset = "0x10FEEE4", VA = "0x10FEEE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x10FEEEC", Offset = "0x10FEEEC", VA = "0x10FEEEC")]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x10FEEF4", Offset = "0x10FEEF4", VA = "0x10FEEF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89E9AC", Offset = "0x89E9AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x10FEEFC", Offset = "0x10FEEFC", VA = "0x10FEEFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89E9BC", Offset = "0x89E9BC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x10FD0C4", Offset = "0x10FD0C4", VA = "0x10FD0C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E85C", Offset = "0x89E85C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x10FD110", Offset = "0x10FD110", VA = "0x10FD110")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E894", Offset = "0x89E894")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x10FD15C", Offset = "0x10FD15C", VA = "0x10FD15C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E8CC", Offset = "0x89E8CC")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x10FD1A8", Offset = "0x10FD1A8", VA = "0x10FD1A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E904", Offset = "0x89E904")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x10FD1F4", Offset = "0x10FD1F4", VA = "0x10FD1F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E93C", Offset = "0x89E93C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x10FD240", Offset = "0x10FD240", VA = "0x10FD240")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E974", Offset = "0x89E974")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x10FD41C", Offset = "0x10FD41C", VA = "0x10FD41C")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x10FD4E8", Offset = "0x10FD4E8", VA = "0x10FD4E8")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x10FD5B4", Offset = "0x10FD5B4", VA = "0x10FD5B4")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x10FD660", Offset = "0x10FD660", VA = "0x10FD660")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x10FD758", Offset = "0x10FD758", VA = "0x10FD758")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x10FD874", Offset = "0x10FD874", VA = "0x10FD874")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x10FD904", Offset = "0x10FD904", VA = "0x10FD904")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x10FD994", Offset = "0x10FD994", VA = "0x10FD994")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x10FDA24", Offset = "0x10FDA24", VA = "0x10FDA24")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x10FDA98", Offset = "0x10FDA98", VA = "0x10FDA98")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x10FDB0C", Offset = "0x10FDB0C", VA = "0x10FDB0C")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x10FDB74", Offset = "0x10FDB74", VA = "0x10FDB74")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x10FDC00", Offset = "0x10FDC00", VA = "0x10FDC00")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x10FDCB4", Offset = "0x10FDCB4", VA = "0x10FDCB4")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x10FDD98", Offset = "0x10FDD98", VA = "0x10FDD98")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x10FE03C", Offset = "0x10FE03C", VA = "0x10FE03C")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x10FE22C", Offset = "0x10FE22C", VA = "0x10FE22C")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x10FE4B0", Offset = "0x10FE4B0", VA = "0x10FE4B0")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x10FE7A4", Offset = "0x10FE7A4", VA = "0x10FE7A4")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x10FE7E8", Offset = "0x10FE7E8", VA = "0x10FE7E8")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x10FE860", Offset = "0x10FE860", VA = "0x10FE860")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x10FE998", Offset = "0x10FE998", VA = "0x10FE998")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x10FEB10", Offset = "0x10FEB10", VA = "0x10FEB10")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x10FEDB8", Offset = "0x10FEDB8", VA = "0x10FEDB8")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x10FE5B0", Offset = "0x10FE5B0", VA = "0x10FE5B0")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x10FEF04", Offset = "0x10FEF04", VA = "0x10FEF04", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x10FF6B8", Offset = "0x10FF6B8", VA = "0x10FF6B8")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x10FF6D8", Offset = "0x10FF6D8", VA = "0x10FF6D8")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x10FF6F4", Offset = "0x10FF6F4", VA = "0x10FF6F4")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x10FF710", Offset = "0x10FF710", VA = "0x10FF710")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x10FF770", Offset = "0x10FF770", VA = "0x10FF770")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x10FF88C", Offset = "0x10FF88C", VA = "0x10FF88C")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x10FF988", Offset = "0x10FF988", VA = "0x10FF988")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x10FFCE8", Offset = "0x10FFCE8", VA = "0x10FFCE8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x10FFE00", Offset = "0x10FFE00", VA = "0x10FFE00")]
		private void Update()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x110004C", Offset = "0x110004C", VA = "0x110004C")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x10FF418", Offset = "0x10FF418", VA = "0x10FF418")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x110018C", Offset = "0x110018C", VA = "0x110018C")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x11002B8", Offset = "0x11002B8", VA = "0x11002B8")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1100374", Offset = "0x1100374", VA = "0x1100374")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x1100470", Offset = "0x1100470", VA = "0x1100470")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x1100488", Offset = "0x1100488", VA = "0x1100488")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x10FD338", Offset = "0x10FD338", VA = "0x10FD338")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x10FDF38", Offset = "0x10FDF38", VA = "0x10FDF38")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x110084C", Offset = "0x110084C", VA = "0x110084C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89E9CC", Offset = "0x89E9CC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1100898", Offset = "0x1100898", VA = "0x1100898")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EA04", Offset = "0x89EA04")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x11008E4", Offset = "0x11008E4", VA = "0x11008E4")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x89396C", Offset = "0x89396C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x89396C", Offset = "0x89396C")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000103")]
		public class Multiplier
		{
			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B180", Offset = "0x89B180")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B1B8", Offset = "0x89B1B8")]
			public float multiplier;

			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x1101130", Offset = "0x1101130", VA = "0x1101130")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898058", Offset = "0x898058")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898090", Offset = "0x898090")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8980C8", Offset = "0x8980C8")]
		public float interactionSpeedMlp;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898100", Offset = "0x898100")]
		public Transform pivot;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898138", Offset = "0x898138")]
		public Vector3 twistAxis;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898170", Offset = "0x898170")]
		public float twistWeight;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8981A8", Offset = "0x8981A8")]
		public float swingWeight;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8981E0", Offset = "0x8981E0")]
		public bool rotateOnce;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1100E44", Offset = "0x1100E44", VA = "0x1100E44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EA3C", Offset = "0x89EA3C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x1100E90", Offset = "0x1100E90", VA = "0x1100E90")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EA74", Offset = "0x89EA74")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x1100EDC", Offset = "0x1100EDC", VA = "0x1100EDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EAAC", Offset = "0x89EAAC")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x1100F28", Offset = "0x1100F28", VA = "0x1100F28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EAE4", Offset = "0x89EAE4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1100F74", Offset = "0x1100F74", VA = "0x1100F74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EB1C", Offset = "0x89EB1C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x1100FC0", Offset = "0x1100FC0", VA = "0x1100FC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EB54", Offset = "0x89EB54")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x10FC48C", Offset = "0x10FC48C", VA = "0x10FC48C")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x10FB4A4", Offset = "0x10FB4A4", VA = "0x10FB4A4")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x10F9844", Offset = "0x10F9844", VA = "0x10F9844")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x110100C", Offset = "0x110100C", VA = "0x110100C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EB8C", Offset = "0x89EB8C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1101058", Offset = "0x1101058", VA = "0x1101058")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EBC4", Offset = "0x89EBC4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x11010A4", Offset = "0x11010A4", VA = "0x11010A4")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8939CC", Offset = "0x8939CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8939CC", Offset = "0x8939CC")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000104")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B1F0", Offset = "0x89B1F0")]
			public bool use;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B228", Offset = "0x89B228")]
			public Vector2 offset;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B260", Offset = "0x89B260")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89B260", Offset = "0x89B260")]
			public float angleOffset;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B2BC", Offset = "0x89B2BC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89B2BC", Offset = "0x89B2BC")]
			public float maxAngle;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B314", Offset = "0x89B314")]
			public float radius;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B34C", Offset = "0x89B34C")]
			public bool orbit;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B384", Offset = "0x89B384")]
			public bool fixYAxis;

			[Token(Token = "0x17000118")]
			public Vector3 offset3D
			{
				[Token(Token = "0x60008C1")]
				[Address(RVA = "0x11018C4", Offset = "0x11018C4", VA = "0x11018C4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000119")]
			public Vector3 direction3D
			{
				[Token(Token = "0x60008C2")]
				[Address(RVA = "0x1101900", Offset = "0x1101900", VA = "0x1101900")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x11019F8", Offset = "0x11019F8", VA = "0x11019F8")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x1102074", Offset = "0x1102074", VA = "0x1102074")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000105")]
		public class CameraPosition
		{
			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B3BC", Offset = "0x89B3BC")]
			public Collider lookAtTarget;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B3F4", Offset = "0x89B3F4")]
			public Vector3 direction;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B42C", Offset = "0x89B42C")]
			public float maxDistance;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B464", Offset = "0x89B464")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89B464", Offset = "0x89B464")]
			public float maxAngle;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B4BC", Offset = "0x89B4BC")]
			public bool fixYAxis;

			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x11013B0", Offset = "0x11013B0", VA = "0x11013B0")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x1101558", Offset = "0x1101558", VA = "0x1101558")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x1101838", Offset = "0x1101838", VA = "0x1101838")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000106")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x2000121")]
			public class Interaction
			{
				[Token(Token = "0x400080B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C368", Offset = "0x89C368")]
				public InteractionObject interactionObject;

				[Token(Token = "0x400080C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C3A0", Offset = "0x89C3A0")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x600092F")]
				[Address(RVA = "0x1102098", Offset = "0x1102098", VA = "0x1102098")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B564", Offset = "0x89B564")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B59C", Offset = "0x89B59C")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B5D4", Offset = "0x89B5D4")]
			public Interaction[] interactions;

			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x1101220", Offset = "0x1101220", VA = "0x1101220")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x1102088", Offset = "0x1102088", VA = "0x1102088")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898218", Offset = "0x898218")]
		public Range[] ranges;

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x1101138", Offset = "0x1101138", VA = "0x1101138")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EBFC", Offset = "0x89EBFC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x1101184", Offset = "0x1101184", VA = "0x1101184")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EC34", Offset = "0x89EC34")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x11011D0", Offset = "0x11011D0", VA = "0x11011D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EC6C", Offset = "0x89EC6C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x110121C", Offset = "0x110121C", VA = "0x110121C")]
		private void Start()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x10FFB2C", Offset = "0x10FFB2C", VA = "0x10FFB2C")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x1101344", Offset = "0x1101344", VA = "0x1101344")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x2000107")]
		public class Map
		{
			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x10EF06C", Offset = "0x10EF06C", VA = "0x10EF06C")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x10EF48C", Offset = "0x10EF48C", VA = "0x10EF48C")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x10EF440", Offset = "0x10EF440", VA = "0x10EF440")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x10EF238", Offset = "0x10EF238", VA = "0x10EF238")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x10EED78", Offset = "0x10EED78", VA = "0x10EED78", Slot = "12")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89ECA4", Offset = "0x89ECA4")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x10EF12C", Offset = "0x10EF12C", VA = "0x10EF12C", Slot = "13")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x10EF130", Offset = "0x10EF130", VA = "0x10EF130", Slot = "14")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x10EF3D8", Offset = "0x10EF3D8", VA = "0x10EF3D8", Slot = "15")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x10EF0C4", Offset = "0x10EF0C4", VA = "0x10EF0C4")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x10EEFCC", Offset = "0x10EEFCC", VA = "0x10EEFCC")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x10EF4DC", Offset = "0x10EF4DC", VA = "0x10EF4DC")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _poseRoot;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] children;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x147C820", Offset = "0x147C820", VA = "0x147C820", Slot = "12")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x147C8E8", Offset = "0x147C8E8", VA = "0x147C8E8", Slot = "13")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x147CACC", Offset = "0x147CACC", VA = "0x147CACC", Slot = "15")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x147CBC8", Offset = "0x147CBC8", VA = "0x147CBC8", Slot = "14")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x147C950", Offset = "0x147C950", VA = "0x147C950")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x147CF78", Offset = "0x147CF78", VA = "0x147CF78")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x898250", Offset = "0x898250")]
		public float weight;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x898268", Offset = "0x898268")]
		public float localRotationWeight;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x898280", Offset = "0x898280")]
		public float localPositionWeight;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x60006AD")]
		public abstract void AutoMapping();

		[Token(Token = "0x60006AE")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x60006AF")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x60006B0")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x110384C", Offset = "0x110384C", VA = "0x110384C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x11038A4", Offset = "0x11038A4", VA = "0x11038A4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x11038E4", Offset = "0x11038E4", VA = "0x11038E4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1103900", Offset = "0x1103900", VA = "0x1103900")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x893A2C", Offset = "0x893A2C")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x2000108")]
		public class Rigidbone
		{
			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x1103F30", Offset = "0x1103F30", VA = "0x1103F30")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x1104BA8", Offset = "0x1104BA8", VA = "0x1104BA8")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x110498C", Offset = "0x110498C", VA = "0x110498C")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x2000109")]
		public class Child
		{
			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x11040E0", Offset = "0x11040E0", VA = "0x11040E0")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x1104D44", Offset = "0x1104D44", VA = "0x1104D44")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x1104CF4", Offset = "0x1104CF4", VA = "0x1104CF4")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x200010A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x893CF0", Offset = "0x893CF0")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x1700011A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008D7")]
				[Address(RVA = "0x11053A4", Offset = "0x11053A4", VA = "0x11053A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008D9")]
				[Address(RVA = "0x110540C", Offset = "0x110540C", VA = "0x110540C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x1104158", Offset = "0x1104158", VA = "0x1104158")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x110513C", Offset = "0x110513C", VA = "0x110513C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x1105140", Offset = "0x1105140", VA = "0x1105140", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x11053AC", Offset = "0x11053AC", VA = "0x11053AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898298", Offset = "0x898298")]
		public IK ik;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8982D0", Offset = "0x8982D0")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898308", Offset = "0x898308")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898340", Offset = "0x898340")]
		public float applyVelocity;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898378", Offset = "0x898378")]
		public float applyAngularVelocity;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x170000C0")]
		private bool isRagdoll
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x1103948", Offset = "0x1103948", VA = "0x1103948")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C1")]
		private bool ikUsed
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x1104544", Offset = "0x1104544", VA = "0x1104544")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1103910", Offset = "0x1103910", VA = "0x1103910")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x11039C0", Offset = "0x11039C0", VA = "0x11039C0")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x1103AFC", Offset = "0x1103AFC", VA = "0x1103AFC")]
		public void Start()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x1103A80", Offset = "0x1103A80", VA = "0x1103A80")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x89ECDC", Offset = "0x89ECDC")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x1104184", Offset = "0x1104184", VA = "0x1104184")]
		private void Update()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x11043D0", Offset = "0x11043D0", VA = "0x11043D0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x1104488", Offset = "0x1104488", VA = "0x1104488")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x11046C8", Offset = "0x11046C8", VA = "0x11046C8")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x1104508", Offset = "0x1104508", VA = "0x1104508")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x1104684", Offset = "0x1104684", VA = "0x1104684")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x1104764", Offset = "0x1104764", VA = "0x1104764")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x11046FC", Offset = "0x11046FC", VA = "0x11046FC")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x1103A18", Offset = "0x1103A18", VA = "0x1103A18")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x1104410", Offset = "0x1104410", VA = "0x1104410")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1104F0C", Offset = "0x1104F0C", VA = "0x1104F0C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x1105034", Offset = "0x1105034", VA = "0x1105034")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x170000C2")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x1106CCC", Offset = "0x1106CCC", VA = "0x1106CCC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000C3")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x1106D08", Offset = "0x1106D08", VA = "0x1106D08")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x1106954", Offset = "0x1106954", VA = "0x1106954")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x1106998", Offset = "0x1106998", VA = "0x1106998")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x1106C24", Offset = "0x1106C24", VA = "0x1106C24")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x1106C94", Offset = "0x1106C94", VA = "0x1106C94")]
		public void Disable()
		{
		}

		[Token(Token = "0x60006CD")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x1106B34", Offset = "0x1106B34", VA = "0x1106B34")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x1106DD8", Offset = "0x1106DD8", VA = "0x1106DD8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1106DDC", Offset = "0x1106DDC", VA = "0x1106DDC")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x1106E10", Offset = "0x1106E10", VA = "0x1106E10")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x1106EF4", Offset = "0x1106EF4", VA = "0x1106EF4")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x1107170", Offset = "0x1107170", VA = "0x1107170")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x110722C", Offset = "0x110722C", VA = "0x110722C")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x893A90", Offset = "0x893A90")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x893A90", Offset = "0x893A90")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8983C0", Offset = "0x8983C0")]
		public float limit;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8983DC", Offset = "0x8983DC")]
		public float twistLimit;

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x11072A4", Offset = "0x11072A4", VA = "0x11072A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89ED40", Offset = "0x89ED40")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x11072F0", Offset = "0x11072F0", VA = "0x11072F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89ED78", Offset = "0x89ED78")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x110733C", Offset = "0x110733C", VA = "0x110733C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EDB0", Offset = "0x89EDB0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x1107388", Offset = "0x1107388", VA = "0x1107388")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EDE8", Offset = "0x89EDE8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x11073D4", Offset = "0x11073D4", VA = "0x11073D4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x110748C", Offset = "0x110748C", VA = "0x110748C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x11076D4", Offset = "0x11076D4", VA = "0x11076D4")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x893AF0", Offset = "0x893AF0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x893AF0", Offset = "0x893AF0")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool useLimits;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x11076E4", Offset = "0x11076E4", VA = "0x11076E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EE20", Offset = "0x89EE20")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x1107730", Offset = "0x1107730", VA = "0x1107730")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EE58", Offset = "0x89EE58")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x110777C", Offset = "0x110777C", VA = "0x110777C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EE90", Offset = "0x89EE90")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x11077C8", Offset = "0x11077C8", VA = "0x11077C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EEC8", Offset = "0x89EEC8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1107814", Offset = "0x1107814", VA = "0x1107814", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x110783C", Offset = "0x110783C", VA = "0x110783C")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x1107B3C", Offset = "0x1107B3C", VA = "0x1107B3C")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x893B50", Offset = "0x893B50")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x893B50", Offset = "0x893B50")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x200010B")]
		public class ReachCone
		{
			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x1700011C")]
			public Vector3 o
			{
				[Token(Token = "0x60008DA")]
				[Address(RVA = "0x1109BD4", Offset = "0x1109BD4", VA = "0x1109BD4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700011D")]
			public Vector3 a
			{
				[Token(Token = "0x60008DB")]
				[Address(RVA = "0x1109C0C", Offset = "0x1109C0C", VA = "0x1109C0C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700011E")]
			public Vector3 b
			{
				[Token(Token = "0x60008DC")]
				[Address(RVA = "0x1109C48", Offset = "0x1109C48", VA = "0x1109C48")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700011F")]
			public Vector3 c
			{
				[Token(Token = "0x60008DD")]
				[Address(RVA = "0x1109C84", Offset = "0x1109C84", VA = "0x1109C84")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000120")]
			public bool isValid
			{
				[Token(Token = "0x60008DF")]
				[Address(RVA = "0x1108D18", Offset = "0x1108D18", VA = "0x1108D18")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x1109364", Offset = "0x1109364", VA = "0x1109364")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x11094D8", Offset = "0x11094D8", VA = "0x11094D8")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010C")]
		public class LimitPoint
		{
			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x1108D28", Offset = "0x1108D28", VA = "0x1108D28")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x898408", Offset = "0x898408")]
		public float twistLimit;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x898424", Offset = "0x898424")]
		public int smoothIterations;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x1107BC4", Offset = "0x1107BC4", VA = "0x1107BC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EF00", Offset = "0x89EF00")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x1107C10", Offset = "0x1107C10", VA = "0x1107C10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EF38", Offset = "0x89EF38")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x1107C5C", Offset = "0x1107C5C", VA = "0x1107C5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EF70", Offset = "0x89EF70")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1107CA8", Offset = "0x1107CA8", VA = "0x1107CA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EFA8", Offset = "0x89EFA8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x1107CF4", Offset = "0x1107CF4", VA = "0x1107CF4")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1108238", Offset = "0x1108238", VA = "0x1108238", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x1108330", Offset = "0x1108330", VA = "0x1108330")]
		private void Start()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x1108938", Offset = "0x1108938", VA = "0x1108938")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1107DA0", Offset = "0x1107DA0", VA = "0x1107DA0")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1108DAC", Offset = "0x1108DAC", VA = "0x1108DAC")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x1109698", Offset = "0x1109698", VA = "0x1109698")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x11096DC", Offset = "0x11096DC", VA = "0x11096DC")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1109824", Offset = "0x1109824", VA = "0x1109824")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x11085FC", Offset = "0x11085FC", VA = "0x11085FC")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x11099B4", Offset = "0x11099B4", VA = "0x11099B4")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x1109B64", Offset = "0x1109B64", VA = "0x1109B64")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x893BB0", Offset = "0x893BB0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x893BB0", Offset = "0x893BB0")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8984E4", Offset = "0x8984E4")]
		public float twistLimit;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x1109CC0", Offset = "0x1109CC0", VA = "0x1109CC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89EFE0", Offset = "0x89EFE0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x1109D0C", Offset = "0x1109D0C", VA = "0x1109D0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89F018", Offset = "0x89F018")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x1109D58", Offset = "0x1109D58", VA = "0x1109D58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89F050", Offset = "0x89F050")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x1109DA4", Offset = "0x1109DA4", VA = "0x1109DA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x89F088", Offset = "0x89F088")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x1109DF0", Offset = "0x1109DF0", VA = "0x1109DF0")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1109E0C", Offset = "0x1109E0C", VA = "0x1109E0C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x1109EC4", Offset = "0x1109EC4", VA = "0x1109EC4")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x110A1F0", Offset = "0x110A1F0", VA = "0x110A1F0")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898538", Offset = "0x898538")]
		public AimIK ik;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898570", Offset = "0x898570")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x898570", Offset = "0x898570")]
		public float weight;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8985C4", Offset = "0x8985C4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8985C4", Offset = "0x8985C4")]
		public Transform target;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898624", Offset = "0x898624")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89865C", Offset = "0x89865C")]
		public float weightSmoothTime;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x898694", Offset = "0x898694")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898694", Offset = "0x898694")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8986F4", Offset = "0x8986F4")]
		public float maxRadiansDelta;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89872C", Offset = "0x89872C")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898764", Offset = "0x898764")]
		public float slerpSpeed;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89879C", Offset = "0x89879C")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8987D4", Offset = "0x8987D4")]
		public float minDistance;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89880C", Offset = "0x89880C")]
		public Vector3 offset;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x898844", Offset = "0x898844")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898844", Offset = "0x898844")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x898844", Offset = "0x898844")]
		public float maxRootAngle;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8988C0", Offset = "0x8988C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8988C0", Offset = "0x8988C0")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898920", Offset = "0x898920")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform lastTarget;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float switchWeight;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float switchWeightV;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float weightV;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 dir;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000C4")]
		private Vector3 pivot
		{
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x10E2094", Offset = "0x10E2094", VA = "0x10E2094")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x10E1F94", Offset = "0x10E1F94", VA = "0x10E1F94")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x10E21E0", Offset = "0x10E21E0", VA = "0x10E21E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x10E2908", Offset = "0x10E2908", VA = "0x10E2908")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x10E2AA4", Offset = "0x10E2AA4", VA = "0x10E2AA4")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x10E2DC0", Offset = "0x10E2DC0", VA = "0x10E2DC0")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010D")]
		public class Pose
		{
			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x10E3158", Offset = "0x10E3158", VA = "0x10E3158")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x10E34D0", Offset = "0x10E34D0", VA = "0x10E34D0")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x10E34D8", Offset = "0x10E34D8", VA = "0x10E34D8")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x10E307C", Offset = "0x10E307C", VA = "0x10E307C")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x10E33F0", Offset = "0x10E33F0", VA = "0x10E33F0")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x10E345C", Offset = "0x10E345C", VA = "0x10E345C")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200010E")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000122")]
			public class EffectorLink
			{
				[Token(Token = "0x400080D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C3D8", Offset = "0x89C3D8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400080E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C410", Offset = "0x89C410")]
				public float weight;

				[Token(Token = "0x6000930")]
				[Address(RVA = "0x10E3AC8", Offset = "0x10E3AC8", VA = "0x10E3AC8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B60C", Offset = "0x89B60C")]
			public Transform transform;

			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B644", Offset = "0x89B644")]
			public Transform relativeTo;

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B67C", Offset = "0x89B67C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B6B4", Offset = "0x89B6B4")]
			public float verticalWeight;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B6EC", Offset = "0x89B6EC")]
			public float horizontalWeight;

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B724", Offset = "0x89B724")]
			public float speed;

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x10E3634", Offset = "0x10E3634", VA = "0x10E3634")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x10E3AA0", Offset = "0x10E3AA0", VA = "0x10E3AA0")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x10E3AB0", Offset = "0x10E3AB0", VA = "0x10E3AB0")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898958", Offset = "0x898958")]
		public Body[] bodies;

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x10E34F4", Offset = "0x10E34F4", VA = "0x10E34F4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x10E3A98", Offset = "0x10E3A98", VA = "0x10E3A98")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898990", Offset = "0x898990")]
		public float tiltSpeed;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8989C8", Offset = "0x8989C8")]
		public float tiltSensitivity;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898A00", Offset = "0x898A00")]
		public OffsetPose poseLeft;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898A38", Offset = "0x898A38")]
		public OffsetPose poseRight;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x10E4F5C", Offset = "0x10E4F5C", VA = "0x10E4F5C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x10E4FA4", Offset = "0x10E4FA4", VA = "0x10E4FA4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x10E51D4", Offset = "0x10E51D4", VA = "0x10E51D4")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200010F")]
		public abstract class HitPoint
		{
			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B75C", Offset = "0x89B75C")]
			public string name;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B794", Offset = "0x89B794")]
			public Collider collider;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B7CC", Offset = "0x89B7CC")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89B818", Offset = "0x89B818")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89B828", Offset = "0x89B828")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89B838", Offset = "0x89B838")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89B848", Offset = "0x89B848")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x17000121")]
			public bool inProgress
			{
				[Token(Token = "0x60008E8")]
				[Address(RVA = "0x147D03C", Offset = "0x147D03C", VA = "0x147D03C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000122")]
			protected float crossFader
			{
				[Token(Token = "0x60008E9")]
				[Address(RVA = "0x147D5E4", Offset = "0x147D5E4", VA = "0x147D5E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F6E8", Offset = "0x89F6E8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60008EA")]
				[Address(RVA = "0x147D5EC", Offset = "0x147D5EC", VA = "0x147D5EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F6F8", Offset = "0x89F6F8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000123")]
			protected float timer
			{
				[Token(Token = "0x60008EB")]
				[Address(RVA = "0x147D5F4", Offset = "0x147D5F4", VA = "0x147D5F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F708", Offset = "0x89F708")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60008EC")]
				[Address(RVA = "0x147D5FC", Offset = "0x147D5FC", VA = "0x147D5FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F718", Offset = "0x89F718")]
				private set
				{
				}
			}

			[Token(Token = "0x17000124")]
			protected Vector3 force
			{
				[Token(Token = "0x60008ED")]
				[Address(RVA = "0x147D604", Offset = "0x147D604", VA = "0x147D604")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F728", Offset = "0x89F728")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60008EE")]
				[Address(RVA = "0x147D610", Offset = "0x147D610", VA = "0x147D610")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F738", Offset = "0x89F738")]
				private set
				{
				}
			}

			[Token(Token = "0x17000125")]
			protected Vector3 point
			{
				[Token(Token = "0x60008EF")]
				[Address(RVA = "0x147D61C", Offset = "0x147D61C", VA = "0x147D61C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F748", Offset = "0x89F748")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60008F0")]
				[Address(RVA = "0x147D628", Offset = "0x147D628", VA = "0x147D628")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F758", Offset = "0x89F758")]
				private set
				{
				}
			}

			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x147D4B0", Offset = "0x147D4B0", VA = "0x147D4B0")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60008F2")]
			[Address(RVA = "0x147D124", Offset = "0x147D124", VA = "0x147D124")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60008F3")]
			protected abstract float GetLength();

			[Token(Token = "0x60008F4")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60008F5")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x147D634", Offset = "0x147D634", VA = "0x147D634")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000110")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000123")]
			public class EffectorLink
			{
				[Token(Token = "0x400080F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C448", Offset = "0x89C448")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000810")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C480", Offset = "0x89C480")]
				public float weight;

				[Token(Token = "0x4000811")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000812")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000931")]
				[Address(RVA = "0x147DFB0", Offset = "0x147DFB0", VA = "0x147DFB0")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000932")]
				[Address(RVA = "0x147DDA4", Offset = "0x147DDA4", VA = "0x147DDA4")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000933")]
				[Address(RVA = "0x147E0EC", Offset = "0x147E0EC", VA = "0x147E0EC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B858", Offset = "0x89B858")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B890", Offset = "0x89B890")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B8C8", Offset = "0x89B8C8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x147DBC0", Offset = "0x147DBC0", VA = "0x147DBC0", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x147DD38", Offset = "0x147DD38", VA = "0x147DD38", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x147DDB8", Offset = "0x147DDB8", VA = "0x147DDB8", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x147E0D8", Offset = "0x147E0D8", VA = "0x147E0D8")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000111")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000124")]
			public class BoneLink
			{
				[Token(Token = "0x4000813")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C4B8", Offset = "0x89C4B8")]
				public Transform bone;

				[Token(Token = "0x4000814")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C4F0", Offset = "0x89C4F0")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89C4F0", Offset = "0x89C4F0")]
				public float weight;

				[Token(Token = "0x4000815")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000816")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000934")]
				[Address(RVA = "0x147D9C8", Offset = "0x147D9C8", VA = "0x147D9C8")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000935")]
				[Address(RVA = "0x147D750", Offset = "0x147D750", VA = "0x147D750")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000936")]
				[Address(RVA = "0x147DB38", Offset = "0x147DB38", VA = "0x147DB38")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B900", Offset = "0x89B900")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B938", Offset = "0x89B938")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x147D648", Offset = "0x147D648", VA = "0x147D648", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x147D6EC", Offset = "0x147D6EC", VA = "0x147D6EC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x147D75C", Offset = "0x147D75C", VA = "0x147D75C", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60008FE")]
			[Address(RVA = "0x147DB24", Offset = "0x147DB24", VA = "0x147DB24")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898A70", Offset = "0x898A70")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898AA8", Offset = "0x898AA8")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000C5")]
		public bool inProgress
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x147CF80", Offset = "0x147CF80", VA = "0x147CF80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x147D050", Offset = "0x147D050", VA = "0x147D050", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x147D270", Offset = "0x147D270", VA = "0x147D270")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x147D5DC", Offset = "0x147D5DC", VA = "0x147D5DC")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x2000112")]
		public abstract class Offset
		{
			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B970", Offset = "0x89B970")]
			public string name;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B9A8", Offset = "0x89B9A8")]
			public Collider collider;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89B9E0", Offset = "0x89B9E0")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89BA2C", Offset = "0x89BA2C")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89BA3C", Offset = "0x89BA3C")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89BA4C", Offset = "0x89BA4C")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89BA5C", Offset = "0x89BA5C")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x17000126")]
			protected float crossFader
			{
				[Token(Token = "0x60008FF")]
				[Address(RVA = "0x147E6A4", Offset = "0x147E6A4", VA = "0x147E6A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F768", Offset = "0x89F768")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000900")]
				[Address(RVA = "0x147E6AC", Offset = "0x147E6AC", VA = "0x147E6AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F778", Offset = "0x89F778")]
				private set
				{
				}
			}

			[Token(Token = "0x17000127")]
			protected float timer
			{
				[Token(Token = "0x6000901")]
				[Address(RVA = "0x147E6B4", Offset = "0x147E6B4", VA = "0x147E6B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F788", Offset = "0x89F788")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000902")]
				[Address(RVA = "0x147E6BC", Offset = "0x147E6BC", VA = "0x147E6BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F798", Offset = "0x89F798")]
				private set
				{
				}
			}

			[Token(Token = "0x17000128")]
			protected Vector3 force
			{
				[Token(Token = "0x6000903")]
				[Address(RVA = "0x147E6C4", Offset = "0x147E6C4", VA = "0x147E6C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F7A8", Offset = "0x89F7A8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000904")]
				[Address(RVA = "0x147E6D0", Offset = "0x147E6D0", VA = "0x147E6D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F7B8", Offset = "0x89F7B8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000129")]
			protected Vector3 point
			{
				[Token(Token = "0x6000905")]
				[Address(RVA = "0x147E6DC", Offset = "0x147E6DC", VA = "0x147E6DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F7C8", Offset = "0x89F7C8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000906")]
				[Address(RVA = "0x147E6E8", Offset = "0x147E6E8", VA = "0x147E6E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x89F7D8", Offset = "0x89F7D8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000907")]
			[Address(RVA = "0x147E55C", Offset = "0x147E55C", VA = "0x147E55C")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000908")]
			[Address(RVA = "0x147E1C0", Offset = "0x147E1C0", VA = "0x147E1C0")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000909")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x600090A")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600090B")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x600090C")]
			[Address(RVA = "0x147E6F4", Offset = "0x147E6F4", VA = "0x147E6F4")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000113")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000125")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000817")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C544", Offset = "0x89C544")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000818")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C57C", Offset = "0x89C57C")]
				public float weight;

				[Token(Token = "0x4000819")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400081A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000937")]
				[Address(RVA = "0x147EBB0", Offset = "0x147EBB0", VA = "0x147EBB0")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000938")]
				[Address(RVA = "0x147E96C", Offset = "0x147E96C", VA = "0x147E96C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000939")]
				[Address(RVA = "0x147ECCC", Offset = "0x147ECCC", VA = "0x147ECCC")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BA6C", Offset = "0x89BA6C")]
			public int forceDirCurveIndex;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BAA4", Offset = "0x89BAA4")]
			public int upDirCurveIndex;

			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BADC", Offset = "0x89BADC")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x600090D")]
			[Address(RVA = "0x147E708", Offset = "0x147E708", VA = "0x147E708", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600090E")]
			[Address(RVA = "0x147E900", Offset = "0x147E900", VA = "0x147E900", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600090F")]
			[Address(RVA = "0x147E980", Offset = "0x147E980", VA = "0x147E980", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000910")]
			[Address(RVA = "0x147ECB0", Offset = "0x147ECB0", VA = "0x147ECB0")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000114")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000126")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x400081B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C5B4", Offset = "0x89C5B4")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x400081C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C5EC", Offset = "0x89C5EC")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89C5EC", Offset = "0x89C5EC")]
				public float weight;

				[Token(Token = "0x400081D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x400081E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x600093A")]
				[Address(RVA = "0x147F148", Offset = "0x147F148", VA = "0x147F148")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600093B")]
				[Address(RVA = "0x147EE1C", Offset = "0x147EE1C", VA = "0x147EE1C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600093C")]
				[Address(RVA = "0x147F284", Offset = "0x147F284", VA = "0x147F284")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BB14", Offset = "0x89BB14")]
			public int curveIndex;

			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BB4C", Offset = "0x89BB4C")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000911")]
			[Address(RVA = "0x147ECD4", Offset = "0x147ECD4", VA = "0x147ECD4", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000912")]
			[Address(RVA = "0x147EDB8", Offset = "0x147EDB8", VA = "0x147EDB8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000913")]
			[Address(RVA = "0x147EE28", Offset = "0x147EE28", VA = "0x147EE28", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000914")]
			[Address(RVA = "0x147F270", Offset = "0x147F270", VA = "0x147F270")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898AE0", Offset = "0x898AE0")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898B18", Offset = "0x898B18")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x147E0F4", Offset = "0x147E0F4", VA = "0x147E0F4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x147E314", Offset = "0x147E314", VA = "0x147E314")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x147E69C", Offset = "0x147E69C", VA = "0x147E69C")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000115")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000127")]
			public class EffectorLink
			{
				[Token(Token = "0x400081F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C640", Offset = "0x89C640")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000820")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C678", Offset = "0x89C678")]
				public float weight;

				[Token(Token = "0x600093D")]
				[Address(RVA = "0x10F8678", Offset = "0x10F8678", VA = "0x10F8678")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BB84", Offset = "0x89BB84")]
			public Transform transform;

			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BBBC", Offset = "0x89BBBC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BBF4", Offset = "0x89BBF4")]
			public float speed;

			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BC2C", Offset = "0x89BC2C")]
			public float acceleration;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BC64", Offset = "0x89BC64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89BC64", Offset = "0x89BC64")]
			public float matchVelocity;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BCB8", Offset = "0x89BCB8")]
			public float gravity;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000915")]
			[Address(RVA = "0x10F8048", Offset = "0x10F8048", VA = "0x10F8048")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000916")]
			[Address(RVA = "0x10F8208", Offset = "0x10F8208", VA = "0x10F8208")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000917")]
			[Address(RVA = "0x10F865C", Offset = "0x10F865C", VA = "0x10F865C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898B50", Offset = "0x898B50")]
		public Body[] bodies;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898B88", Offset = "0x898B88")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x10F7FD0", Offset = "0x10F7FD0", VA = "0x10F7FD0")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x10F8124", Offset = "0x10F8124", VA = "0x10F8124", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x10F863C", Offset = "0x10F863C", VA = "0x10F863C")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000116")]
		public class OffsetLimits
		{
			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BCF0", Offset = "0x89BCF0")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BD28", Offset = "0x89BD28")]
			public float spring;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BD60", Offset = "0x89BD60")]
			public bool x;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BD98", Offset = "0x89BD98")]
			public bool y;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BDD0", Offset = "0x89BDD0")]
			public bool z;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BE08", Offset = "0x89BE08")]
			public float minX;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BE40", Offset = "0x89BE40")]
			public float maxX;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BE78", Offset = "0x89BE78")]
			public float minY;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BEB0", Offset = "0x89BEB0")]
			public float maxY;

			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BEE8", Offset = "0x89BEE8")]
			public float minZ;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BF20", Offset = "0x89BF20")]
			public float maxZ;

			[Token(Token = "0x6000918")]
			[Address(RVA = "0x11027C4", Offset = "0x11027C4", VA = "0x11027C4")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000919")]
			[Address(RVA = "0x1102D10", Offset = "0x1102D10", VA = "0x1102D10")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x600091A")]
			[Address(RVA = "0x1102D40", Offset = "0x1102D40", VA = "0x1102D40")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600091B")]
			[Address(RVA = "0x1102E18", Offset = "0x1102E18", VA = "0x1102E18")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x2000117")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x893D00", Offset = "0x893D00")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x1700012A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600091F")]
				[Address(RVA = "0x1102CA0", Offset = "0x1102CA0", VA = "0x1102CA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000921")]
				[Address(RVA = "0x1102D08", Offset = "0x1102D08", VA = "0x1102D08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600091C")]
			[Address(RVA = "0x110268C", Offset = "0x110268C", VA = "0x110268C")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600091D")]
			[Address(RVA = "0x1102B40", Offset = "0x1102B40", VA = "0x1102B40", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600091E")]
			[Address(RVA = "0x1102B44", Offset = "0x1102B44", VA = "0x1102B44", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000920")]
			[Address(RVA = "0x1102CA8", Offset = "0x1102CA8", VA = "0x1102CA8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898BC0", Offset = "0x898BC0")]
		public float weight;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898BF8", Offset = "0x898BF8")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000C6")]
		protected float deltaTime
		{
			[Token(Token = "0x6000713")]
			[Address(RVA = "0x10F81DC", Offset = "0x10F81DC", VA = "0x10F81DC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000714")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x11025E4", Offset = "0x11025E4", VA = "0x11025E4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1102610", Offset = "0x1102610", VA = "0x1102610")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x89F0C0", Offset = "0x89F0C0")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x11026B8", Offset = "0x11026B8", VA = "0x11026B8")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x10F8580", Offset = "0x10F8580", VA = "0x10F8580")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x1102A24", Offset = "0x1102A24", VA = "0x1102A24", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x10F864C", Offset = "0x10F864C", VA = "0x10F864C")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x2000118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x893D10", Offset = "0x893D10")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x1700012C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000925")]
				[Address(RVA = "0x11032B8", Offset = "0x11032B8", VA = "0x11032B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000927")]
				[Address(RVA = "0x1103320", Offset = "0x1103320", VA = "0x1103320", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000922")]
			[Address(RVA = "0x1102EF4", Offset = "0x1102EF4", VA = "0x1102EF4")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000923")]
			[Address(RVA = "0x1103158", Offset = "0x1103158", VA = "0x1103158", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000924")]
			[Address(RVA = "0x110315C", Offset = "0x110315C", VA = "0x110315C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000926")]
			[Address(RVA = "0x11032C0", Offset = "0x11032C0", VA = "0x11032C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898C30", Offset = "0x898C30")]
		public float weight;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898C68", Offset = "0x898C68")]
		public VRIK ik;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000C7")]
		protected float deltaTime
		{
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x1102E20", Offset = "0x1102E20", VA = "0x1102E20")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600071C")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x1102E4C", Offset = "0x1102E4C", VA = "0x1102E4C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x1102E78", Offset = "0x1102E78", VA = "0x1102E78")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x89F124", Offset = "0x89F124")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x1102F20", Offset = "0x1102F20", VA = "0x1102F20")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x110302C", Offset = "0x110302C", VA = "0x110302C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x1103148", Offset = "0x1103148", VA = "0x1103148")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000119")]
		public class EffectorLink
		{
			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000928")]
			[Address(RVA = "0x11033E8", Offset = "0x11033E8", VA = "0x11033E8")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000929")]
			[Address(RVA = "0x1103844", Offset = "0x1103844", VA = "0x1103844")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x1103328", Offset = "0x1103328", VA = "0x1103328")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x1103720", Offset = "0x1103720", VA = "0x1103720")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x11037D8", Offset = "0x11037D8", VA = "0x11037D8")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200011A")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x2000128")]
			public class EffectorLink
			{
				[Token(Token = "0x4000821")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C6B0", Offset = "0x89C6B0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000822")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C6E8", Offset = "0x89C6E8")]
				public float weight;

				[Token(Token = "0x600093E")]
				[Address(RVA = "0x110694C", Offset = "0x110694C", VA = "0x110694C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BF58", Offset = "0x89BF58")]
			public Vector3 offset;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BF90", Offset = "0x89BF90")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89BF90", Offset = "0x89BF90")]
			public float additivity;

			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89BFE4", Offset = "0x89BFE4")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C01C", Offset = "0x89C01C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x600092A")]
			[Address(RVA = "0x110563C", Offset = "0x110563C", VA = "0x110563C")]
			public void Start()
			{
			}

			[Token(Token = "0x600092B")]
			[Address(RVA = "0x11061F0", Offset = "0x11061F0", VA = "0x11061F0")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x600092C")]
			[Address(RVA = "0x1106938", Offset = "0x1106938", VA = "0x1106938")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200011B")]
		public enum Handedness
		{
			[Token(Token = "0x40007E9")]
			Right,
			[Token(Token = "0x40007EA")]
			Left
		}

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898CA0", Offset = "0x898CA0")]
		public AimIK aimIK;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898CD8", Offset = "0x898CD8")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898D10", Offset = "0x898D10")]
		public Handedness handedness;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898D48", Offset = "0x898D48")]
		public bool twoHanded;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898D80", Offset = "0x898D80")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898DB8", Offset = "0x898DB8")]
		public float magnitudeRandom;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898DF0", Offset = "0x898DF0")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898E28", Offset = "0x898E28")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898E60", Offset = "0x898E60")]
		public float blendTime;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x898E98", Offset = "0x898E98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898E98", Offset = "0x898E98")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000C8")]
		public bool isFinished
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x1105414", Offset = "0x1105414", VA = "0x1105414")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C9")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0x11064A4", Offset = "0x11064A4", VA = "0x11064A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CA")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x11064E4", Offset = "0x11064E4", VA = "0x11064E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CB")]
		private Transform primaryHand
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0x1106464", Offset = "0x1106464", VA = "0x1106464")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CC")]
		private Transform secondaryHand
		{
			[Token(Token = "0x600072E")]
			[Address(RVA = "0x1106484", Offset = "0x1106484", VA = "0x1106484")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x1105444", Offset = "0x1105444", VA = "0x1105444")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x1105470", Offset = "0x1105470", VA = "0x1105470")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x11056EC", Offset = "0x11056EC", VA = "0x11056EC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x1106524", Offset = "0x1106524", VA = "0x1106524")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x110667C", Offset = "0x110667C", VA = "0x110667C")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x11066B8", Offset = "0x11066B8", VA = "0x11066B8", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x1106884", Offset = "0x1106884", VA = "0x1106884")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898EF8", Offset = "0x898EF8")]
		public float weight;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x898F30", Offset = "0x898F30")]
		public float offset;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x110A1FC", Offset = "0x110A1FC", VA = "0x110A1FC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x110A2F0", Offset = "0x110A2F0", VA = "0x110A2F0")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x110A3DC", Offset = "0x110A3DC", VA = "0x110A3DC")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x110A824", Offset = "0x110A824", VA = "0x110A824")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x110A85C", Offset = "0x110A85C", VA = "0x110A85C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x110A978", Offset = "0x110A978", VA = "0x110A978")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x200011C")]
		public class Settings
		{
			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C054", Offset = "0x89C054")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C08C", Offset = "0x89C08C")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C0C4", Offset = "0x89C0C4")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C0FC", Offset = "0x89C0FC")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C134", Offset = "0x89C134")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C16C", Offset = "0x89C16C")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C1A4", Offset = "0x89C1A4")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C1DC", Offset = "0x89C1DC")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x89C214", Offset = "0x89C214")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C214", Offset = "0x89C214")]
			public Vector3 headOffset;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C264", Offset = "0x89C264")]
			public Vector3 handOffset;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C29C", Offset = "0x89C29C")]
			public float footForwardOffset;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C2D4", Offset = "0x89C2D4")]
			public float footInwardOffset;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x89C30C", Offset = "0x89C30C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x89C30C", Offset = "0x89C30C")]
			public float footHeadingOffset;

			[Token(Token = "0x600092D")]
			[Address(RVA = "0x14176B0", Offset = "0x14176B0", VA = "0x14176B0")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x110CA74", Offset = "0x110CA74", VA = "0x110CA74")]
		public static void Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x110DB28", Offset = "0x110DB28", VA = "0x110DB28")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvisTarget;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftFootTarget;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightFootTarget;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 pelvisTargetRight;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x1417798", Offset = "0x1417798", VA = "0x1417798")]
		private void Awake()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x141788C", Offset = "0x141788C", VA = "0x141788C")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x14179CC", Offset = "0x14179CC", VA = "0x14179CC")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x1417DB8", Offset = "0x1417DB8", VA = "0x1417DB8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x1417ED4", Offset = "0x1417ED4", VA = "0x1417ED4")]
		public VRIKRootController()
		{
		}
	}
}
