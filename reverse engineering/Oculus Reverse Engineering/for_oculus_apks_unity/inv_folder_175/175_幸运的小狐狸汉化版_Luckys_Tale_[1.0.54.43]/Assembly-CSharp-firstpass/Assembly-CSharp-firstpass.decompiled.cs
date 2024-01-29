using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class Go : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static GoEaseType defaultEaseType;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static GoLoopType defaultLoopType;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static GoUpdateType defaultUpdateType;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static GoDuplicatePropertyRuleType duplicatePropertyRule;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static GoLogLevel logLevel;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public static bool validateTargetObjectsEachTick;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	private static bool _applicationIsQuitting;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static List<AbstractGoTween> _tweens;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool _timeScaleIndependentUpdateIsRunning;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Go _instance;

	[Token(Token = "0x17000001")]
	public static Go instance
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0xED6698", Offset = "0xED6698", VA = "0xED6698")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xED68D0", Offset = "0xED68D0", VA = "0xED68D0")]
	private void handleUpdateOfType(GoUpdateType updateType, float deltaTime)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xED6BE8", Offset = "0xED6BE8", VA = "0xED6BE8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xED6C88", Offset = "0xED6C88", VA = "0xED6C88")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xED6D18", Offset = "0xED6D18", VA = "0xED6D18")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xED6DA8", Offset = "0xED6DA8", VA = "0xED6DA8")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xED6E64", Offset = "0xED6E64", VA = "0xED6E64")]
	private static bool handleDuplicatePropertiesInTween(GoTween tween)
	{
		return default(bool);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xED7430", Offset = "0xED7430", VA = "0xED7430")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x6ECC64", Offset = "0x6ECC64")]
	private static void log(object format, params object[] paramList)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xED74F8", Offset = "0xED74F8", VA = "0xED74F8")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x6ECC9C", Offset = "0x6ECC9C")]
	public static void warn(object format, params object[] paramList)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xED7628", Offset = "0xED7628", VA = "0xED7628")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x6ECCD4", Offset = "0x6ECCD4")]
	public static void error(object format, params object[] paramList)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xED7780", Offset = "0xED7780", VA = "0xED7780")]
	public static GoTween to(object target, float duration, GoTweenConfig config)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xED7A0C", Offset = "0xED7A0C", VA = "0xED7A0C")]
	public static GoTween from(object target, float duration, GoTweenConfig config)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xED3D0C", Offset = "0xED3D0C", VA = "0xED3D0C")]
	public static void addTween(AbstractGoTween tween)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xED6A74", Offset = "0xED6A74", VA = "0xED6A74")]
	public static bool removeTween(AbstractGoTween tween)
	{
		return default(bool);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xED7AD4", Offset = "0xED7AD4", VA = "0xED7AD4")]
	public static List<AbstractGoTween> tweensWithId(int id)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xED71D8", Offset = "0xED71D8", VA = "0xED71D8")]
	public static List<GoTween> tweensWithTarget(object target, bool traverseCollections = false)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xED7C6C", Offset = "0xED7C6C", VA = "0xED7C6C")]
	public static void killAllTweensWithTarget(object target)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xED7D94", Offset = "0xED7D94", VA = "0xED7D94")]
	public Go()
	{
	}
}
[Token(Token = "0x2000003")]
public class GoDummyPath : MonoBehaviour
{
	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string pathName;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color pathColor;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector3> nodes;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool useStandardHandles;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool forceStraightLinePath;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int pathResolution;

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xED7E64", Offset = "0xED7E64", VA = "0xED7E64")]
	public void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xED811C", Offset = "0xED811C", VA = "0xED811C")]
	public GoDummyPath()
	{
	}
}
[Token(Token = "0x2000004")]
public class GoTween : AbstractGoTween
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBE04", Offset = "0x6EBE04")]
	private object <target>k__BackingField;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBE14", Offset = "0x6EBE14")]
	private float <delay>k__BackingField;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float _elapsedDelay;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool _delayComplete;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBE24", Offset = "0x6EBE24")]
	private bool <isFrom>k__BackingField;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<AbstractTweenProperty> _tweenPropertyList;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private GoEaseType _easeType;

	[Token(Token = "0x17000002")]
	public object target
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0xEDD338", Offset = "0xEDD338", VA = "0xEDD338")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECD0C", Offset = "0x6ECD0C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000017")]
		[Address(RVA = "0xEDD340", Offset = "0xEDD340", VA = "0xEDD340")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECD1C", Offset = "0x6ECD1C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public float delay
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0xEDD348", Offset = "0xEDD348", VA = "0xEDD348")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECD2C", Offset = "0x6ECD2C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000019")]
		[Address(RVA = "0xEDD350", Offset = "0xEDD350", VA = "0xEDD350")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECD3C", Offset = "0x6ECD3C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public bool isFrom
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0xEDD358", Offset = "0xEDD358", VA = "0xEDD358")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECD4C", Offset = "0x6ECD4C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600001B")]
		[Address(RVA = "0xEDD360", Offset = "0xEDD360", VA = "0xEDD360")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECD5C", Offset = "0x6ECD5C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public GoEaseType easeType
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0xEDD36C", Offset = "0xEDD36C", VA = "0xEDD36C")]
		get
		{
			return default(GoEaseType);
		}
		[Token(Token = "0x600001D")]
		[Address(RVA = "0xEDD374", Offset = "0xEDD374", VA = "0xEDD374")]
		set
		{
		}
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xED7840", Offset = "0xED7840", VA = "0xED7840")]
	public GoTween(object target, float duration, GoTweenConfig config, [Optional] Action<AbstractGoTween> onComplete)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xEDD59C", Offset = "0xEDD59C", VA = "0xEDD59C", Slot = "10")]
	public override bool update(float deltaTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xEDD7A4", Offset = "0xEDD7A4", VA = "0xEDD7A4", Slot = "11")]
	public override bool isValid()
	{
		return default(bool);
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xEDD480", Offset = "0xEDD480", VA = "0xEDD480")]
	public void addTweenProperty(AbstractTweenProperty tweenProp)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xEDD7B4", Offset = "0xEDD7B4", VA = "0xEDD7B4", Slot = "12")]
	public override bool removeTweenProperty(AbstractTweenProperty property)
	{
		return default(bool);
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xEDD84C", Offset = "0xEDD84C", VA = "0xEDD84C", Slot = "13")]
	public override bool containsTweenProperty(AbstractTweenProperty property)
	{
		return default(bool);
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xEDD8B4", Offset = "0xEDD8B4", VA = "0xEDD8B4")]
	public void clearTweenProperties()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xEDD90C", Offset = "0xEDD90C", VA = "0xEDD90C", Slot = "14")]
	public override List<AbstractTweenProperty> allTweenProperties()
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xEDD914", Offset = "0xEDD914", VA = "0xEDD914", Slot = "4")]
	protected override void onInit()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xEDD9B8", Offset = "0xEDD9B8", VA = "0xEDD9B8", Slot = "15")]
	public override void destroy()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xEDDA20", Offset = "0xEDDA20", VA = "0xEDDA20", Slot = "22")]
	public override void goTo(float time, bool skipDelay = true)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xEDDBD0", Offset = "0xEDDBD0", VA = "0xEDDBD0", Slot = "21")]
	public override void complete()
	{
	}
}
[Token(Token = "0x2000005")]
public class GoTweenChain : AbstractGoTweenCollection
{
	[Token(Token = "0x600002A")]
	[Address(RVA = "0xEDDC08", Offset = "0xEDDC08", VA = "0xEDDC08")]
	public GoTweenChain()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xEDDCF4", Offset = "0xEDDCF4", VA = "0xEDDCF4")]
	public GoTweenChain(GoTweenCollectionConfig config)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xEDDCF8", Offset = "0xEDDCF8", VA = "0xEDDCF8")]
	private void append(TweenFlowItem item)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xEDDE94", Offset = "0xEDDE94", VA = "0xEDDE94")]
	private void prepend(TweenFlowItem item)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xEDE0E4", Offset = "0xEDE0E4", VA = "0xEDE0E4")]
	public GoTweenChain append(AbstractGoTween tween)
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xEDE16C", Offset = "0xEDE16C", VA = "0xEDE16C")]
	public GoTweenChain appendDelay(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xEDE1F8", Offset = "0xEDE1F8", VA = "0xEDE1F8")]
	public GoTweenChain prepend(AbstractGoTween tween)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xEDE274", Offset = "0xEDE274", VA = "0xEDE274")]
	public GoTweenChain prependDelay(float delay)
	{
		return null;
	}
}
[Token(Token = "0x2000006")]
public class GoTweenCollectionConfig
{
	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int iterations;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GoLoopType loopType;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public GoUpdateType propertyUpdateType;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Action<AbstractGoTween> onInitHandler;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Action<AbstractGoTween> onBeginHandler;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Action<AbstractGoTween> onIterationStartHandler;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Action<AbstractGoTween> onUpdateHandler;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Action<AbstractGoTween> onIterationEndHandler;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Action<AbstractGoTween> onCompleteHandler;

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xEDE2F4", Offset = "0xEDE2F4", VA = "0xEDE2F4")]
	public GoTweenCollectionConfig setIterations(int iterations)
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xEDE2FC", Offset = "0xEDE2FC", VA = "0xEDE2FC")]
	public GoTweenCollectionConfig setIterations(int iterations, GoLoopType loopType)
	{
		return null;
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xEDE304", Offset = "0xEDE304", VA = "0xEDE304")]
	public GoTweenCollectionConfig setUpdateType(GoUpdateType setUpdateType)
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xEDE30C", Offset = "0xEDE30C", VA = "0xEDE30C")]
	public GoTweenCollectionConfig onInit(Action<AbstractGoTween> onInit)
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xEDE314", Offset = "0xEDE314", VA = "0xEDE314")]
	public GoTweenCollectionConfig onBegin(Action<AbstractGoTween> onBegin)
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xEDE31C", Offset = "0xEDE31C", VA = "0xEDE31C")]
	public GoTweenCollectionConfig onIterationStart(Action<AbstractGoTween> onIterationStart)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xEDE324", Offset = "0xEDE324", VA = "0xEDE324")]
	public GoTweenCollectionConfig onUpdate(Action<AbstractGoTween> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xEDE32C", Offset = "0xEDE32C", VA = "0xEDE32C")]
	public GoTweenCollectionConfig onIterationEnd(Action<AbstractGoTween> onIterationEnd)
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xEDE334", Offset = "0xEDE334", VA = "0xEDE334")]
	public GoTweenCollectionConfig onComplete(Action<AbstractGoTween> onComplete)
	{
		return null;
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xEDE33C", Offset = "0xEDE33C", VA = "0xEDE33C")]
	public GoTweenCollectionConfig setId(int id)
	{
		return null;
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xEDDC68", Offset = "0xEDDC68", VA = "0xEDDC68")]
	public GoTweenCollectionConfig()
	{
	}
}
[Token(Token = "0x2000007")]
public class GoTweenConfig
{
	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<AbstractTweenProperty> _tweenProperties;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int id;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float delay;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int iterations;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int timeScale;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GoLoopType loopType;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public GoEaseType easeType;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool isPaused;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public GoUpdateType propertyUpdateType;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool isFrom;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Action<AbstractGoTween> onInitHandler;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Action<AbstractGoTween> onBeginHandler;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Action<AbstractGoTween> onIterationStartHandler;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Action<AbstractGoTween> onUpdateHandler;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Action<AbstractGoTween> onIterationEndHandler;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Action<AbstractGoTween> onCompleteHandler;

	[Token(Token = "0x17000006")]
	public List<AbstractTweenProperty> tweenProperties
	{
		[Token(Token = "0x600003D")]
		[Address(RVA = "0xEDE344", Offset = "0xEDE344", VA = "0xEDE344")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xED9A84", Offset = "0xED9A84", VA = "0xED9A84")]
	public GoTweenConfig position(Vector3 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xED9C10", Offset = "0xED9C10", VA = "0xED9C10")]
	public GoTweenConfig localPosition(Vector3 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xEDE3B4", Offset = "0xEDE3B4", VA = "0xEDE3B4")]
	public GoTweenConfig positionPath(GoSpline path, bool isRelative = false, GoLookAtType lookAtType = GoLookAtType.None, [Optional] Transform lookTarget)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xEDE4D0", Offset = "0xEDE4D0", VA = "0xEDE4D0")]
	public GoTweenConfig scale(float endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xED9E08", Offset = "0xED9E08", VA = "0xED9E08")]
	public GoTweenConfig scale(Vector3 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xEDE57C", Offset = "0xEDE57C", VA = "0xEDE57C")]
	public GoTweenConfig scalePath(GoSpline path, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xED9768", Offset = "0xED9768", VA = "0xED9768")]
	public GoTweenConfig eulerAngles(Vector3 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xED98F4", Offset = "0xED98F4", VA = "0xED98F4")]
	public GoTweenConfig localEulerAngles(Vector3 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xED944C", Offset = "0xED944C", VA = "0xED944C")]
	public GoTweenConfig rotation(Vector3 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xED95D8", Offset = "0xED95D8", VA = "0xED95D8")]
	public GoTweenConfig localRotation(Vector3 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xEDE6C0", Offset = "0xEDE6C0", VA = "0xEDE6C0")]
	public GoTweenConfig rotation(Quaternion endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xEDE7EC", Offset = "0xEDE7EC", VA = "0xEDE7EC")]
	public GoTweenConfig localRotation(Quaternion endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xEDA714", Offset = "0xEDA714", VA = "0xEDA714")]
	public GoTweenConfig materialColor(Color endValue, string colorName = "_Color", bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xED9FA8", Offset = "0xED9FA8", VA = "0xED9FA8")]
	public GoTweenConfig shake(Vector3 shakeMagnitude, GoShakeType shakeType = GoShakeType.Position, int frameMod = 1, bool useLocalProperties = false)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xEDE98C", Offset = "0xEDE98C", VA = "0xEDE98C")]
	public GoTweenConfig vector2Prop(string propertyName, Vector2 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xEDEA3C", Offset = "0xEDEA3C", VA = "0xEDEA3C")]
	public GoTweenConfig vector3Prop(string propertyName, Vector3 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xEDEAFC", Offset = "0xEDEAFC", VA = "0xEDEAFC")]
	public GoTweenConfig vector4Prop(string propertyName, Vector4 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xEDEBC4", Offset = "0xEDEBC4", VA = "0xEDEBC4")]
	public GoTweenConfig vector3PathProp(string propertyName, GoSpline path, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xEDEC6C", Offset = "0xEDEC6C", VA = "0xEDEC6C")]
	public GoTweenConfig vector3XProp(string propertyName, float endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xEDED14", Offset = "0xEDED14", VA = "0xEDED14")]
	public GoTweenConfig vector3YProp(string propertyName, float endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xEDEDBC", Offset = "0xEDEDBC", VA = "0xEDEDBC")]
	public GoTweenConfig vector3ZProp(string propertyName, float endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xEDEE64", Offset = "0xEDEE64", VA = "0xEDEE64")]
	public GoTweenConfig colorProp(string propertyName, Color endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xEDEF28", Offset = "0xEDEF28", VA = "0xEDEF28")]
	public GoTweenConfig intProp(string propertyName, int endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xEDF01C", Offset = "0xEDF01C", VA = "0xEDF01C")]
	public GoTweenConfig floatProp(string propertyName, float endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xEDF0C8", Offset = "0xEDF0C8", VA = "0xEDF0C8")]
	public GoTweenConfig addTweenProperty(AbstractTweenProperty tweenProp)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xEDF138", Offset = "0xEDF138", VA = "0xEDF138")]
	public GoTweenConfig clearProperties()
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xEDF198", Offset = "0xEDF198", VA = "0xEDF198")]
	public GoTweenConfig clearEvents()
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xEDF1A8", Offset = "0xEDF1A8", VA = "0xEDF1A8")]
	public GoTweenConfig setDelay(float seconds)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xEDF1B0", Offset = "0xEDF1B0", VA = "0xEDF1B0")]
	public GoTweenConfig setIterations(int iterations)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xEDF1B8", Offset = "0xEDF1B8", VA = "0xEDF1B8")]
	public GoTweenConfig setIterations(int iterations, GoLoopType loopType)
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xEDF1C4", Offset = "0xEDF1C4", VA = "0xEDF1C4")]
	public GoTweenConfig setTimeScale(int timeScale)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xEDF1CC", Offset = "0xEDF1CC", VA = "0xEDF1CC")]
	public GoTweenConfig setEaseType(GoEaseType easeType)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xEDF1D4", Offset = "0xEDF1D4", VA = "0xEDF1D4")]
	public GoTweenConfig startPaused()
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xEDF1E0", Offset = "0xEDF1E0", VA = "0xEDF1E0")]
	public GoTweenConfig setUpdateType(GoUpdateType setUpdateType)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xED7AC8", Offset = "0xED7AC8", VA = "0xED7AC8")]
	public GoTweenConfig setIsFrom()
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xED7838", Offset = "0xED7838", VA = "0xED7838")]
	public GoTweenConfig setIsTo()
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xEDF1E8", Offset = "0xEDF1E8", VA = "0xEDF1E8")]
	public GoTweenConfig onInit(Action<AbstractGoTween> onInit)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xEDF1F0", Offset = "0xEDF1F0", VA = "0xEDF1F0")]
	public GoTweenConfig onBegin(Action<AbstractGoTween> onBegin)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xEDF1F8", Offset = "0xEDF1F8", VA = "0xEDF1F8")]
	public GoTweenConfig onIterationStart(Action<AbstractGoTween> onIterationStart)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xEDF200", Offset = "0xEDF200", VA = "0xEDF200")]
	public GoTweenConfig onUpdate(Action<AbstractGoTween> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xEDF208", Offset = "0xEDF208", VA = "0xEDF208")]
	public GoTweenConfig onIterationEnd(Action<AbstractGoTween> onIterationEnd)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xEDF210", Offset = "0xEDF210", VA = "0xEDF210")]
	public GoTweenConfig onComplete(Action<AbstractGoTween> onComplete)
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xEDF218", Offset = "0xEDF218", VA = "0xEDF218")]
	public GoTweenConfig setId(int id)
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xED938C", Offset = "0xED938C", VA = "0xED938C")]
	public GoTweenConfig()
	{
	}
}
[Token(Token = "0x2000008")]
public class GoTweenFlow : AbstractGoTweenCollection
{
	[Serializable]
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBD44", Offset = "0x6EBD44")]
	private sealed class <>c
	{
		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<TweenFlowItem> <>9__2_0;

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xEDF60C", Offset = "0xEDF60C", VA = "0xEDF60C")]
		public <>c()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xEDF614", Offset = "0xEDF614", VA = "0xEDF614")]
		internal int <insert>b__2_0(TweenFlowItem x, TweenFlowItem y)
		{
			return default(int);
		}
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xEDF220", Offset = "0xEDF220", VA = "0xEDF220")]
	public GoTweenFlow()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xEDF280", Offset = "0xEDF280", VA = "0xEDF280")]
	public GoTweenFlow(GoTweenCollectionConfig config)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xEDF284", Offset = "0xEDF284", VA = "0xEDF284")]
	private void insert(TweenFlowItem item)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xEDF520", Offset = "0xEDF520", VA = "0xEDF520")]
	public GoTweenFlow insert(float startTime, AbstractGoTween tween)
	{
		return null;
	}
}
[Token(Token = "0x2000009")]
public abstract class AbstractGoTween
{
	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBD54", Offset = "0x6EBD54")]
	private sealed class <waitForCompletion>d__93 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AbstractGoTween <>4__this;

		[Token(Token = "0x1700005B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0xED3B88", Offset = "0xED3B88", VA = "0xED3B88", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0xED3BF0", Offset = "0xED3BF0", VA = "0xED3BF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xED3AFC", Offset = "0xED3AFC", VA = "0xED3AFC")]
		[DebuggerHidden]
		public <waitForCompletion>d__93(int <>1__state)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xED3B30", Offset = "0xED3B30", VA = "0xED3B30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xED3B34", Offset = "0xED3B34", VA = "0xED3B34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xED3B90", Offset = "0xED3B90", VA = "0xED3B90", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBE34", Offset = "0x6EBE34")]
	private GoTweenState <state>k__BackingField;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBE44", Offset = "0x6EBE44")]
	private float <duration>k__BackingField;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBE54", Offset = "0x6EBE54")]
	private float <totalDuration>k__BackingField;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBE64", Offset = "0x6EBE64")]
	private float <timeScale>k__BackingField;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBE74", Offset = "0x6EBE74")]
	private GoUpdateType <updateType>k__BackingField;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBE84", Offset = "0x6EBE84")]
	private GoLoopType <loopType>k__BackingField;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBE94", Offset = "0x6EBE94")]
	private int <iterations>k__BackingField;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBEA4", Offset = "0x6EBEA4")]
	private bool <autoRemoveOnComplete>k__BackingField;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBEB4", Offset = "0x6EBEB4")]
	private bool <isReversed>k__BackingField;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBEC4", Offset = "0x6EBEC4")]
	private bool <allowEvents>k__BackingField;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	protected bool _didInit;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	protected bool _didBegin;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	protected bool _fireIterationStart;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
	protected bool _fireIterationEnd;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected float _elapsedTime;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	protected float _totalElapsedTime;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected bool _isLoopingBackOnPingPong;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	protected bool _didIterateLastFrame;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	protected bool _didIterateThisFrame;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	protected int _deltaIterations;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected int _completedIterations;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected Action<AbstractGoTween> _onInit;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected Action<AbstractGoTween> _onBegin;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected Action<AbstractGoTween> _onIterationStart;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Action<AbstractGoTween> _onUpdate;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Action<AbstractGoTween> _onIterationEnd;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected Action<AbstractGoTween> _onComplete;

	[Token(Token = "0x17000007")]
	public GoTweenState state
	{
		[Token(Token = "0x600006E")]
		[Address(RVA = "0xED3118", Offset = "0xED3118", VA = "0xED3118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECD6C", Offset = "0x6ECD6C")]
		get
		{
			return default(GoTweenState);
		}
		[Token(Token = "0x600006F")]
		[Address(RVA = "0xED3120", Offset = "0xED3120", VA = "0xED3120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECD7C", Offset = "0x6ECD7C")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public float duration
	{
		[Token(Token = "0x6000070")]
		[Address(RVA = "0xED3128", Offset = "0xED3128", VA = "0xED3128")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECD8C", Offset = "0x6ECD8C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000071")]
		[Address(RVA = "0xED3130", Offset = "0xED3130", VA = "0xED3130")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECD9C", Offset = "0x6ECD9C")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public float totalDuration
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0xED3138", Offset = "0xED3138", VA = "0xED3138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECDAC", Offset = "0x6ECDAC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000073")]
		[Address(RVA = "0xED3140", Offset = "0xED3140", VA = "0xED3140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECDBC", Offset = "0x6ECDBC")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public float timeScale
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0xED3148", Offset = "0xED3148", VA = "0xED3148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECDCC", Offset = "0x6ECDCC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000075")]
		[Address(RVA = "0xED3150", Offset = "0xED3150", VA = "0xED3150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECDDC", Offset = "0x6ECDDC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public GoUpdateType updateType
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0xED3158", Offset = "0xED3158", VA = "0xED3158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECDEC", Offset = "0x6ECDEC")]
		get
		{
			return default(GoUpdateType);
		}
		[Token(Token = "0x6000077")]
		[Address(RVA = "0xED3160", Offset = "0xED3160", VA = "0xED3160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECDFC", Offset = "0x6ECDFC")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public GoLoopType loopType
	{
		[Token(Token = "0x6000078")]
		[Address(RVA = "0xED3168", Offset = "0xED3168", VA = "0xED3168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECE0C", Offset = "0x6ECE0C")]
		get
		{
			return default(GoLoopType);
		}
		[Token(Token = "0x6000079")]
		[Address(RVA = "0xED3170", Offset = "0xED3170", VA = "0xED3170")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECE1C", Offset = "0x6ECE1C")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public int iterations
	{
		[Token(Token = "0x600007A")]
		[Address(RVA = "0xED3178", Offset = "0xED3178", VA = "0xED3178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECE2C", Offset = "0x6ECE2C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600007B")]
		[Address(RVA = "0xED3180", Offset = "0xED3180", VA = "0xED3180")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECE3C", Offset = "0x6ECE3C")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public bool autoRemoveOnComplete
	{
		[Token(Token = "0x600007C")]
		[Address(RVA = "0xED3188", Offset = "0xED3188", VA = "0xED3188")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECE4C", Offset = "0x6ECE4C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600007D")]
		[Address(RVA = "0xED3190", Offset = "0xED3190", VA = "0xED3190")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECE5C", Offset = "0x6ECE5C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public bool isReversed
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0xED319C", Offset = "0xED319C", VA = "0xED319C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECE6C", Offset = "0x6ECE6C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600007F")]
		[Address(RVA = "0xED31A4", Offset = "0xED31A4", VA = "0xED31A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECE7C", Offset = "0x6ECE7C")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public bool allowEvents
	{
		[Token(Token = "0x6000080")]
		[Address(RVA = "0xED31B0", Offset = "0xED31B0", VA = "0xED31B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECE8C", Offset = "0x6ECE8C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000081")]
		[Address(RVA = "0xED31B8", Offset = "0xED31B8", VA = "0xED31B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ECE9C", Offset = "0x6ECE9C")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public float totalElapsedTime
	{
		[Token(Token = "0x6000082")]
		[Address(RVA = "0xED31C4", Offset = "0xED31C4", VA = "0xED31C4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000012")]
	public bool isLoopingBackOnPingPong
	{
		[Token(Token = "0x6000083")]
		[Address(RVA = "0xED31CC", Offset = "0xED31CC", VA = "0xED31CC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000013")]
	public int completedIterations
	{
		[Token(Token = "0x6000084")]
		[Address(RVA = "0xED31D4", Offset = "0xED31D4", VA = "0xED31D4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xED31DC", Offset = "0xED31DC", VA = "0xED31DC")]
	public void setOnInitHandler(Action<AbstractGoTween> onInit)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xED31E4", Offset = "0xED31E4", VA = "0xED31E4")]
	public void setOnBeginHandler(Action<AbstractGoTween> onBegin)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xED31EC", Offset = "0xED31EC", VA = "0xED31EC")]
	public void setonIterationStartHandler(Action<AbstractGoTween> onIterationStart)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xED31F4", Offset = "0xED31F4", VA = "0xED31F4")]
	public void setOnUpdateHandler(Action<AbstractGoTween> onUpdate)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xED31FC", Offset = "0xED31FC", VA = "0xED31FC")]
	public void setonIterationEndHandler(Action<AbstractGoTween> onIterationEnd)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xED3204", Offset = "0xED3204", VA = "0xED3204")]
	public void setOnCompleteHandler(Action<AbstractGoTween> onComplete)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xED320C", Offset = "0xED320C", VA = "0xED320C", Slot = "4")]
	protected virtual void onInit()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xED3278", Offset = "0xED3278", VA = "0xED3278", Slot = "5")]
	protected virtual void onBegin()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xED3308", Offset = "0xED3308", VA = "0xED3308", Slot = "6")]
	protected virtual void onIterationStart()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xED3374", Offset = "0xED3374", VA = "0xED3374", Slot = "7")]
	protected virtual void onUpdate()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xED33E0", Offset = "0xED33E0", VA = "0xED33E0", Slot = "8")]
	protected virtual void onIterationEnd()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xED344C", Offset = "0xED344C", VA = "0xED344C", Slot = "9")]
	protected virtual void onComplete()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xED34B8", Offset = "0xED34B8", VA = "0xED34B8", Slot = "10")]
	public virtual bool update(float deltaTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6000092")]
	public abstract bool isValid();

	[Token(Token = "0x6000093")]
	public abstract bool removeTweenProperty(AbstractTweenProperty property);

	[Token(Token = "0x6000094")]
	public abstract bool containsTweenProperty(AbstractTweenProperty property);

	[Token(Token = "0x6000095")]
	public abstract List<AbstractTweenProperty> allTweenProperties();

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xED37C0", Offset = "0xED37C0", VA = "0xED37C0", Slot = "15")]
	public virtual void destroy()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xED37CC", Offset = "0xED37CC", VA = "0xED37CC", Slot = "16")]
	public virtual void pause()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xED37D8", Offset = "0xED37D8", VA = "0xED37D8", Slot = "17")]
	public virtual void play()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xED37E0", Offset = "0xED37E0", VA = "0xED37E0")]
	public void playForward()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xED3828", Offset = "0xED3828", VA = "0xED3828")]
	public void playBackwards()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xED3870", Offset = "0xED3870", VA = "0xED3870", Slot = "18")]
	protected virtual void reset(bool skipDelay = true)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xED38C0", Offset = "0xED38C0", VA = "0xED38C0", Slot = "19")]
	public virtual void rewind(bool skipDelay = true)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xED3900", Offset = "0xED3900", VA = "0xED3900")]
	public void restart(bool skipDelay = true)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xED3940", Offset = "0xED3940", VA = "0xED3940", Slot = "20")]
	public virtual void reverse()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xED3A1C", Offset = "0xED3A1C", VA = "0xED3A1C", Slot = "21")]
	public virtual void complete()
	{
	}

	[Token(Token = "0x60000A0")]
	public abstract void goTo(float time, bool skipDelay = true);

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xED3A4C", Offset = "0xED3A4C", VA = "0xED3A4C")]
	public void goToAndPlay(float time, bool skipDelay = true)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xED3A8C", Offset = "0xED3A8C", VA = "0xED3A8C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6ECEAC", Offset = "0x6ECEAC")]
	public IEnumerator waitForCompletion()
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xED3B28", Offset = "0xED3B28", VA = "0xED3B28")]
	protected AbstractGoTween()
	{
	}
}
[Token(Token = "0x200000A")]
public class AbstractGoTweenCollection : AbstractGoTween
{
	[Token(Token = "0x2000086")]
	protected class TweenFlowItem
	{
		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float startTime;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float duration;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AbstractGoTween tween;

		[Token(Token = "0x1700005D")]
		public float endTime
		{
			[Token(Token = "0x6000433")]
			[Address(RVA = "0xED4BB4", Offset = "0xED4BB4", VA = "0xED4BB4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xED523C", Offset = "0xED523C", VA = "0xED523C")]
		public TweenFlowItem(float startTime, AbstractGoTween tween)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xED5288", Offset = "0xED5288", VA = "0xED5288")]
		public TweenFlowItem(float startTime, float duration)
		{
		}
	}

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected List<TweenFlowItem> _tweenFlows;

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xED3BF8", Offset = "0xED3BF8", VA = "0xED3BF8")]
	public AbstractGoTweenCollection(GoTweenCollectionConfig config)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xED3F64", Offset = "0xED3F64", VA = "0xED3F64")]
	public List<GoTween> tweensWithTarget(object target)
	{
		return null;
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xED4194", Offset = "0xED4194", VA = "0xED4194", Slot = "12")]
	public override bool removeTweenProperty(AbstractTweenProperty property)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xED42B8", Offset = "0xED42B8", VA = "0xED42B8", Slot = "13")]
	public override bool containsTweenProperty(AbstractTweenProperty property)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xED43E0", Offset = "0xED43E0", VA = "0xED43E0", Slot = "14")]
	public override List<AbstractTweenProperty> allTweenProperties()
	{
		return null;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xED453C", Offset = "0xED453C", VA = "0xED453C", Slot = "11")]
	public override bool isValid()
	{
		return default(bool);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xED4544", Offset = "0xED4544", VA = "0xED4544", Slot = "17")]
	public override void play()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xED4650", Offset = "0xED4650", VA = "0xED4650", Slot = "16")]
	public override void pause()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xED4760", Offset = "0xED4760", VA = "0xED4760", Slot = "10")]
	public override bool update(float deltaTime)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xED4BC0", Offset = "0xED4BC0", VA = "0xED4BC0", Slot = "20")]
	public override void reverse()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xED4DC8", Offset = "0xED4DC8", VA = "0xED4DC8", Slot = "22")]
	public override void goTo(float time, bool skipDelay = true)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xED50C8", Offset = "0xED50C8", VA = "0xED50C8")]
	private void changeTimeForFlowItem(TweenFlowItem flowItem, float time)
	{
	}
}
[Token(Token = "0x200000B")]
public static class GoEaseBack
{
	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xED821C", Offset = "0xED821C", VA = "0xED821C")]
	public static float EaseIn(float t, float b, float c, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xED824C", Offset = "0xED824C", VA = "0xED824C")]
	public static float EaseOut(float t, float b, float c, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xED828C", Offset = "0xED828C", VA = "0xED828C")]
	public static float EaseInOut(float t, float b, float c, float d)
	{
		return default(float);
	}
}
[Token(Token = "0x200000C")]
public static class GoEaseBounce
{
	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xED830C", Offset = "0xED830C", VA = "0xED830C")]
	public static float EaseOut(float t, float b, float c, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xED83D8", Offset = "0xED83D8", VA = "0xED83D8")]
	public static float EaseIn(float t, float b, float c, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xED840C", Offset = "0xED840C", VA = "0xED840C")]
	public static float EaseInOut(float t, float b, float c, float d)
	{
		return default(float);
	}
}
[Token(Token = "0x200000D")]
public static class GoEaseCircular
{
	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xED848C", Offset = "0xED848C", VA = "0xED848C")]
	public static float EaseIn(float t, float b, float c, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xED853C", Offset = "0xED853C", VA = "0xED853C")]
	public static float EaseOut(float t, float b, float c, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xED85EC", Offset = "0xED85EC", VA = "0xED85EC")]
	public static float EaseInOut(float t, float b, float c, float d)
	{
		return default(float);
	}
}
[Token(Token = "0x200000E")]
public static class GoEaseCubic
{
	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xED86E8", Offset = "0xED86E8", VA = "0xED86E8")]
	public static float EaseIn(float t, float b, float c, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xED8700", Offset = "0xED8700", VA = "0xED8700")]
	public static float EaseOut(float t, float b, float c, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xED8728", Offset = "0xED8728", VA = "0xED8728")]
	public static float EaseInOut(float t, float b, float c, float d)
	{
		return default(float);
	}
}
[Token(Token = "0x200000F")]
public class GoEaseElastic
{
	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xED877C", Offset = "0xED877C", VA = "0xED877C")]
	public static float EaseIn(float t, float b, float c, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xED889C", Offset = "0xED889C", VA = "0xED889C")]
	public static float EaseOut(float t, float b, float c, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xED89BC", Offset = "0xED89BC", VA = "0xED89BC")]
	public static float EaseInOut(float t, float b, float c, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xED8B70", Offset = "0xED8B70", VA = "0xED8B70")]
	public static float Punch(float t, float b, float c, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xED8C38", Offset = "0xED8C38", VA = "0xED8C38")]
	public GoEaseElastic()
	{
	}
}
[Token(Token = "0x2000010")]
public static class GoEaseExponential
{
	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xED8C40", Offset = "0xED8C40", VA = "0xED8C40")]
	public static float EaseIn(float t, float b, float c, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xED8CF8", Offset = "0xED8CF8", VA = "0xED8CF8")]
	public static float EaseOut(float t, float b, float c, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xED8DAC", Offset = "0xED8DAC", VA = "0xED8DAC")]
	public static float EaseInOut(float t, float b, float c, float d)
	{
		return default(float);
	}
}
[Token(Token = "0x2000011")]
public static class GoEaseLinear
{
	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xED8EDC", Offset = "0xED8EDC", VA = "0xED8EDC")]
	public static float EaseNone(float t, float b, float c, float d)
	{
		return default(float);
	}
}
[Token(Token = "0x2000012")]
public static class GoEaseQuadratic
{
	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xED8EEC", Offset = "0xED8EEC", VA = "0xED8EEC")]
	public static float EaseIn(float t, float b, float c, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xED8F00", Offset = "0xED8F00", VA = "0xED8F00")]
	public static float EaseOut(float t, float b, float c, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xED8F1C", Offset = "0xED8F1C", VA = "0xED8F1C")]
	public static float EaseInOut(float t, float b, float c, float d)
	{
		return default(float);
	}
}
[Token(Token = "0x2000013")]
public static class GoEaseQuartic
{
	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xED8F70", Offset = "0xED8F70", VA = "0xED8F70")]
	public static float EaseIn(float t, float b, float c, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xED8F8C", Offset = "0xED8F8C", VA = "0xED8F8C")]
	public static float EaseOut(float t, float b, float c, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xED8FB4", Offset = "0xED8FB4", VA = "0xED8FB4")]
	public static float EaseInOut(float t, float b, float c, float d)
	{
		return default(float);
	}
}
[Token(Token = "0x2000014")]
public static class GoEaseQuintic
{
	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xED9010", Offset = "0xED9010", VA = "0xED9010")]
	public static float EaseIn(float t, float b, float c, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xED9030", Offset = "0xED9030", VA = "0xED9030")]
	public static float EaseOut(float t, float b, float c, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xED9060", Offset = "0xED9060", VA = "0xED9060")]
	public static float EaseInOut(float t, float b, float c, float d)
	{
		return default(float);
	}
}
[Token(Token = "0x2000015")]
public static class GoEaseSinusoidal
{
	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xED90C4", Offset = "0xED90C4", VA = "0xED90C4")]
	public static float EaseIn(float t, float b, float c, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xED9168", Offset = "0xED9168", VA = "0xED9168")]
	public static float EaseOut(float t, float b, float c, float d)
	{
		return default(float);
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xED9208", Offset = "0xED9208", VA = "0xED9208")]
	public static float EaseInOut(float t, float b, float c, float d)
	{
		return default(float);
	}
}
[Token(Token = "0x2000016")]
public enum GoDuplicatePropertyRuleType
{
	[Token(Token = "0x4000050")]
	None,
	[Token(Token = "0x4000051")]
	RemoveRunningProperty,
	[Token(Token = "0x4000052")]
	DontAddCurrentProperty
}
[Token(Token = "0x2000017")]
public enum GoEaseType
{
	[Token(Token = "0x4000054")]
	Linear,
	[Token(Token = "0x4000055")]
	SineIn,
	[Token(Token = "0x4000056")]
	SineOut,
	[Token(Token = "0x4000057")]
	SineInOut,
	[Token(Token = "0x4000058")]
	QuadIn,
	[Token(Token = "0x4000059")]
	QuadOut,
	[Token(Token = "0x400005A")]
	QuadInOut,
	[Token(Token = "0x400005B")]
	CubicIn,
	[Token(Token = "0x400005C")]
	CubicOut,
	[Token(Token = "0x400005D")]
	CubicInOut,
	[Token(Token = "0x400005E")]
	QuartIn,
	[Token(Token = "0x400005F")]
	QuartOut,
	[Token(Token = "0x4000060")]
	QuartInOut,
	[Token(Token = "0x4000061")]
	QuintIn,
	[Token(Token = "0x4000062")]
	QuintOut,
	[Token(Token = "0x4000063")]
	QuintInOut,
	[Token(Token = "0x4000064")]
	ExpoIn,
	[Token(Token = "0x4000065")]
	ExpoOut,
	[Token(Token = "0x4000066")]
	ExpoInOut,
	[Token(Token = "0x4000067")]
	CircIn,
	[Token(Token = "0x4000068")]
	CircOut,
	[Token(Token = "0x4000069")]
	CircInOut,
	[Token(Token = "0x400006A")]
	ElasticIn,
	[Token(Token = "0x400006B")]
	ElasticOut,
	[Token(Token = "0x400006C")]
	ElasticInOut,
	[Token(Token = "0x400006D")]
	Punch,
	[Token(Token = "0x400006E")]
	BackIn,
	[Token(Token = "0x400006F")]
	BackOut,
	[Token(Token = "0x4000070")]
	BackInOut,
	[Token(Token = "0x4000071")]
	BounceIn,
	[Token(Token = "0x4000072")]
	BounceOut,
	[Token(Token = "0x4000073")]
	BounceInOut
}
[Token(Token = "0x2000018")]
public enum GoLogLevel
{
	[Token(Token = "0x4000075")]
	None,
	[Token(Token = "0x4000076")]
	Info,
	[Token(Token = "0x4000077")]
	Warn,
	[Token(Token = "0x4000078")]
	Error
}
[Token(Token = "0x2000019")]
public enum GoLookAtType
{
	[Token(Token = "0x400007A")]
	None,
	[Token(Token = "0x400007B")]
	NextPathNode,
	[Token(Token = "0x400007C")]
	TargetTransform
}
[Token(Token = "0x200001A")]
public enum GoLoopType
{
	[Token(Token = "0x400007E")]
	RestartFromBeginning,
	[Token(Token = "0x400007F")]
	PingPong
}
[Token(Token = "0x200001B")]
public enum GoMaterialColorType
{
	[Token(Token = "0x4000081")]
	Color,
	[Token(Token = "0x4000082")]
	SpecColor,
	[Token(Token = "0x4000083")]
	Emission,
	[Token(Token = "0x4000084")]
	ReflectColor
}
[Token(Token = "0x200001C")]
[Flags]
public enum GoShakeType
{
	[Token(Token = "0x4000086")]
	Position = 1,
	[Token(Token = "0x4000087")]
	Scale = 2,
	[Token(Token = "0x4000088")]
	Eulers = 4
}
[Token(Token = "0x200001D")]
public enum GoSplineType
{
	[Token(Token = "0x400008A")]
	StraightLine,
	[Token(Token = "0x400008B")]
	QuadraticBezier,
	[Token(Token = "0x400008C")]
	CubicBezier,
	[Token(Token = "0x400008D")]
	CatmullRom
}
[Token(Token = "0x200001E")]
public enum GoTweenState
{
	[Token(Token = "0x400008F")]
	Running,
	[Token(Token = "0x4000090")]
	Paused,
	[Token(Token = "0x4000091")]
	Complete,
	[Token(Token = "0x4000092")]
	Destroyed
}
[Token(Token = "0x200001F")]
public enum GoUpdateType
{
	[Token(Token = "0x4000094")]
	Update,
	[Token(Token = "0x4000095")]
	LateUpdate,
	[Token(Token = "0x4000096")]
	FixedUpdate,
	[Token(Token = "0x4000097")]
	TimeScaleIndependentUpdate
}
[Token(Token = "0x2000020")]
public static class GoKitTweenExtensions
{
	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xED92BC", Offset = "0xED92BC", VA = "0xED92BC")]
	public static GoTween rotationTo(this Transform self, float duration, Vector3 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xED9508", Offset = "0xED9508", VA = "0xED9508")]
	public static GoTween localRotationTo(this Transform self, float duration, Vector3 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xED9698", Offset = "0xED9698", VA = "0xED9698")]
	public static GoTween eulerAnglesTo(this Transform self, float duration, Vector3 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xED9824", Offset = "0xED9824", VA = "0xED9824")]
	public static GoTween localEulerAnglesTo(this Transform self, float duration, Vector3 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xED99B4", Offset = "0xED99B4", VA = "0xED99B4")]
	public static GoTween positionTo(this Transform self, float duration, Vector3 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xED9B40", Offset = "0xED9B40", VA = "0xED9B40")]
	public static GoTween localPositionTo(this Transform self, float duration, Vector3 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xED9CD0", Offset = "0xED9CD0", VA = "0xED9CD0")]
	public static GoTween scaleTo(this Transform self, float duration, float endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xED9D38", Offset = "0xED9D38", VA = "0xED9D38")]
	public static GoTween scaleTo(this Transform self, float duration, Vector3 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xED9EC0", Offset = "0xED9EC0", VA = "0xED9EC0")]
	public static GoTween shake(this Transform self, float duration, Vector3 shakeMagnitude, GoShakeType shakeType = GoShakeType.Position, int frameMod = 1, bool useLocalProperties = false)
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xEDA080", Offset = "0xEDA080", VA = "0xEDA080")]
	public static GoTween rotationFrom(this Transform self, float duration, Vector3 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xEDA150", Offset = "0xEDA150", VA = "0xEDA150")]
	public static GoTween localRotationFrom(this Transform self, float duration, Vector3 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xEDA220", Offset = "0xEDA220", VA = "0xEDA220")]
	public static GoTween eulerAnglesFrom(this Transform self, float duration, Vector3 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xEDA2F0", Offset = "0xEDA2F0", VA = "0xEDA2F0")]
	public static GoTween localEulerAnglesFrom(this Transform self, float duration, Vector3 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xEDA3C0", Offset = "0xEDA3C0", VA = "0xEDA3C0")]
	public static GoTween positionFrom(this Transform self, float duration, Vector3 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xEDA490", Offset = "0xEDA490", VA = "0xEDA490")]
	public static GoTween localPositionFrom(this Transform self, float duration, Vector3 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xEDA560", Offset = "0xEDA560", VA = "0xEDA560")]
	public static GoTween scaleFrom(this Transform self, float duration, Vector3 endValue, bool isRelative = false)
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xEDA630", Offset = "0xEDA630", VA = "0xEDA630")]
	public static GoTween colorTo(this Material self, float duration, Color endValue, string colorName = "_Color")
	{
		return null;
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xEDA7D8", Offset = "0xEDA7D8", VA = "0xEDA7D8")]
	public static GoTween colorFrom(this Material self, float duration, Color endValue, string colorName = "_Color")
	{
		return null;
	}
}
[Token(Token = "0x2000021")]
public static class GoTweenUtils
{
	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xED57DC", Offset = "0xED57DC", VA = "0xED57DC")]
	public static Func<float, float, float, float, float> easeFunctionForType(GoEaseType easeType)
	{
		return null;
	}

	[Token(Token = "0x60000E4")]
	public static T setterForProperty<T>(object targetObject, string propertyName)
	{
		return (T)null;
	}

	[Token(Token = "0x60000E5")]
	public static T getterForProperty<T>(object targetObject, string propertyName)
	{
		return (T)null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xED603C", Offset = "0xED603C", VA = "0xED603C")]
	public static Color unclampedColorLerp(Color c1, Color diff, float value)
	{
		return default(Color);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xEDF63C", Offset = "0xEDF63C", VA = "0xEDF63C")]
	public static Vector2 unclampedVector2Lerp(Vector2 v1, Vector2 diff, float value)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xED6400", Offset = "0xED6400", VA = "0xED6400")]
	public static Vector3 unclampedVector3Lerp(Vector3 v1, Vector3 diff, float value)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xEDF678", Offset = "0xEDF678", VA = "0xEDF678")]
	public static Vector4 unclampedVector4Lerp(Vector4 v1, Vector4 diff, float value)
	{
		return default(Vector4);
	}
}
[Token(Token = "0x2000022")]
public abstract class AbstractColorTweenProperty : AbstractTweenProperty
{
	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected Material _target;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Color _originalEndValue;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected Color _startValue;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected Color _endValue;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected Color _diffValue;

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xED29F4", Offset = "0xED29F4", VA = "0xED29F4")]
	public AbstractColorTweenProperty(Color endValue, bool isRelative)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xED2A7C", Offset = "0xED2A7C", VA = "0xED2A7C", Slot = "5")]
	public override bool validateTarget(object target)
	{
		return default(bool);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xED2B8C", Offset = "0xED2B8C", VA = "0xED2B8C", Slot = "4")]
	public override void init(GoTween owner)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xED2D0C", Offset = "0xED2D0C", VA = "0xED2D0C", Slot = "7")]
	public override void prepareForUse()
	{
	}
}
[Token(Token = "0x2000023")]
public abstract class AbstractQuaternionTweenProperty : AbstractTweenProperty
{
	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected Transform _target;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Quaternion _originalEndValue;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected Quaternion _startValue;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected Quaternion _endValue;

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xED52C0", Offset = "0xED52C0", VA = "0xED52C0")]
	public AbstractQuaternionTweenProperty()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xED52E8", Offset = "0xED52E8", VA = "0xED52E8")]
	public AbstractQuaternionTweenProperty(Quaternion endValue, bool isRelative = false)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xED5340", Offset = "0xED5340", VA = "0xED5340", Slot = "5")]
	public override bool validateTarget(object target)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xED53C0", Offset = "0xED53C0", VA = "0xED53C0", Slot = "7")]
	public override void prepareForUse()
	{
	}
}
[Token(Token = "0x2000024")]
public abstract class AbstractTweenProperty
{
	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected bool _isInitialized;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	protected bool _isRelative;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected GoTween _ownerTween;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected Func<float, float, float, float, float> _easeFunction;

	[Token(Token = "0x17000014")]
	public bool isInitialized
	{
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xED549C", Offset = "0xED549C", VA = "0xED549C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xED2A4C", Offset = "0xED2A4C", VA = "0xED2A4C")]
	public AbstractTweenProperty(bool isRelative = false)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xED54A4", Offset = "0xED54A4", VA = "0xED54A4", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xED54AC", Offset = "0xED54AC", VA = "0xED54AC", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xED2CC8", Offset = "0xED2CC8", VA = "0xED2CC8", Slot = "4")]
	public virtual void init(GoTween owner)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xED574C", Offset = "0xED574C", VA = "0xED574C")]
	public AbstractTweenProperty clone()
	{
		return null;
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xED5724", Offset = "0xED5724", VA = "0xED5724")]
	public void setEaseType(GoEaseType easeType)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xED5BD8", Offset = "0xED5BD8", VA = "0xED5BD8", Slot = "5")]
	public virtual bool validateTarget(object target)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FA")]
	public abstract void tick(float totalElapsedTime);

	[Token(Token = "0x60000FB")]
	public abstract void prepareForUse();
}
[Token(Token = "0x2000025")]
public abstract class AbstractVector3TweenProperty : AbstractTweenProperty
{
	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected Transform _target;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Vector3 _originalEndValue;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	protected Vector3 _startValue;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected Vector3 _endValue;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	protected Vector3 _diffValue;

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xED5BE0", Offset = "0xED5BE0", VA = "0xED5BE0")]
	public AbstractVector3TweenProperty()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xED5C08", Offset = "0xED5C08", VA = "0xED5C08")]
	public AbstractVector3TweenProperty(Vector3 endValue, bool isRelative = false)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xED5C5C", Offset = "0xED5C5C", VA = "0xED5C5C", Slot = "5")]
	public override bool validateTarget(object target)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xED5CDC", Offset = "0xED5CDC", VA = "0xED5CDC", Slot = "7")]
	public override void prepareForUse()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xED5DB8", Offset = "0xED5DB8", VA = "0xED5DB8")]
	public void resetWithNewEndValue(Vector3 endValue)
	{
	}
}
[Token(Token = "0x2000026")]
public class ColorTweenProperty : AbstractColorTweenProperty, IGenericProperty
{
	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBED4", Offset = "0x6EBED4")]
	private string <propertyName>k__BackingField;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Action<Color> _setter;

	[Token(Token = "0x17000015")]
	public string propertyName
	{
		[Token(Token = "0x6000101")]
		[Address(RVA = "0xED5DCC", Offset = "0xED5DCC", VA = "0xED5DCC", Slot = "8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED030", Offset = "0x6ED030")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000102")]
		[Address(RVA = "0xED5DD4", Offset = "0xED5DD4", VA = "0xED5DD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED040", Offset = "0x6ED040")]
		private set
		{
		}
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xED5DDC", Offset = "0xED5DDC", VA = "0xED5DDC")]
	public ColorTweenProperty(string propertyName, Color endValue, bool isRelative = false)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xED5E44", Offset = "0xED5E44", VA = "0xED5E44", Slot = "5")]
	public override bool validateTarget(object target)
	{
		return default(bool);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xED5EB8", Offset = "0xED5EB8", VA = "0xED5EB8", Slot = "7")]
	public override void prepareForUse()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xED5F84", Offset = "0xED5F84", VA = "0xED5F84", Slot = "6")]
	public override void tick(float totalElapsedTime)
	{
	}
}
[Token(Token = "0x2000027")]
public class FloatTweenProperty : AbstractTweenProperty, IGenericProperty
{
	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBEE4", Offset = "0x6EBEE4")]
	private string <propertyName>k__BackingField;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Action<float> _setter;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected float _originalEndValue;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	protected float _startValue;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected float _endValue;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	protected float _diffValue;

	[Token(Token = "0x17000016")]
	public string propertyName
	{
		[Token(Token = "0x6000107")]
		[Address(RVA = "0xED644C", Offset = "0xED644C", VA = "0xED644C", Slot = "8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED050", Offset = "0x6ED050")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000108")]
		[Address(RVA = "0xED6454", Offset = "0xED6454", VA = "0xED6454")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED060", Offset = "0x6ED060")]
		private set
		{
		}
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xED645C", Offset = "0xED645C", VA = "0xED645C")]
	public FloatTweenProperty(string propertyName, float endValue, bool isRelative = false)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xED64AC", Offset = "0xED64AC", VA = "0xED64AC", Slot = "5")]
	public override bool validateTarget(object target)
	{
		return default(bool);
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xED6520", Offset = "0xED6520", VA = "0xED6520", Slot = "7")]
	public override void prepareForUse()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xED6604", Offset = "0xED6604", VA = "0xED6604", Slot = "6")]
	public override void tick(float totalElapsedTime)
	{
	}
}
[Token(Token = "0x2000028")]
public interface IGenericProperty
{
	[Token(Token = "0x17000017")]
	string propertyName
	{
		[Token(Token = "0x600010D")]
		get;
	}
}
[Token(Token = "0x2000029")]
public class IntTweenProperty : AbstractTweenProperty, IGenericProperty
{
	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBEF4", Offset = "0x6EBEF4")]
	private string <propertyName>k__BackingField;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Action<int> _setter;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected int _originalEndValue;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	protected int _startValue;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected int _endValue;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	protected int _diffValue;

	[Token(Token = "0x17000018")]
	public string propertyName
	{
		[Token(Token = "0x600010E")]
		[Address(RVA = "0xEDF6CC", Offset = "0xEDF6CC", VA = "0xEDF6CC", Slot = "8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED070", Offset = "0x6ED070")]
		get
		{
			return null;
		}
		[Token(Token = "0x600010F")]
		[Address(RVA = "0xEDF6D4", Offset = "0xEDF6D4", VA = "0xEDF6D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED080", Offset = "0x6ED080")]
		private set
		{
		}
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xEDEFD4", Offset = "0xEDEFD4", VA = "0xEDEFD4")]
	public IntTweenProperty(string propertyName, int endValue, bool isRelative = false)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xEDF6DC", Offset = "0xEDF6DC", VA = "0xEDF6DC", Slot = "5")]
	public override bool validateTarget(object target)
	{
		return default(bool);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xEDF750", Offset = "0xEDF750", VA = "0xEDF750", Slot = "7")]
	public override void prepareForUse()
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xEDF830", Offset = "0xEDF830", VA = "0xEDF830", Slot = "6")]
	public override void tick(float totalElapsedTime)
	{
	}
}
[Token(Token = "0x200002A")]
public class Vector2TweenProperty : AbstractTweenProperty, IGenericProperty
{
	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBF04", Offset = "0x6EBF04")]
	private string <propertyName>k__BackingField;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Action<Vector2> _setter;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected Vector2 _originalEndValue;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected Vector2 _startValue;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected Vector2 _endValue;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected Vector2 _diffValue;

	[Token(Token = "0x17000019")]
	public string propertyName
	{
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x9A2D74", Offset = "0x9A2D74", VA = "0x9A2D74", Slot = "8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED090", Offset = "0x6ED090")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x9A2D7C", Offset = "0x9A2D7C", VA = "0x9A2D7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED0A0", Offset = "0x6ED0A0")]
		private set
		{
		}
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x9A2D84", Offset = "0x9A2D84", VA = "0x9A2D84")]
	public Vector2TweenProperty(string propertyName, Vector2 endValue, bool isRelative = false)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x9A2DC8", Offset = "0x9A2DC8", VA = "0x9A2DC8", Slot = "5")]
	public override bool validateTarget(object target)
	{
		return default(bool);
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x9A2E3C", Offset = "0x9A2E3C", VA = "0x9A2E3C", Slot = "7")]
	public override void prepareForUse()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x9A2F68", Offset = "0x9A2F68", VA = "0x9A2F68", Slot = "6")]
	public override void tick(float totalElapsedTime)
	{
	}
}
[Token(Token = "0x200002B")]
public class Vector3PathTweenProperty : AbstractTweenProperty, IGenericProperty
{
	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBF14", Offset = "0x6EBF14")]
	private string <propertyName>k__BackingField;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Action<Vector3> _setter;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GoSpline _path;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 _startValue;

	[Token(Token = "0x1700001A")]
	public string propertyName
	{
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x9A3018", Offset = "0x9A3018", VA = "0x9A3018", Slot = "8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED0B0", Offset = "0x6ED0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x9A3020", Offset = "0x9A3020", VA = "0x9A3020")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED0C0", Offset = "0x6ED0C0")]
		private set
		{
		}
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x9A3028", Offset = "0x9A3028", VA = "0x9A3028")]
	public Vector3PathTweenProperty(string propertyName, GoSpline path, bool isRelative = false)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x9A3068", Offset = "0x9A3068", VA = "0x9A3068", Slot = "5")]
	public override bool validateTarget(object target)
	{
		return default(bool);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x9A30DC", Offset = "0x9A30DC", VA = "0x9A30DC", Slot = "7")]
	public override void prepareForUse()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x9A31B4", Offset = "0x9A31B4", VA = "0x9A31B4", Slot = "6")]
	public override void tick(float totalElapsedTime)
	{
	}
}
[Token(Token = "0x200002C")]
public class Vector3TweenProperty : AbstractVector3TweenProperty, IGenericProperty
{
	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBF24", Offset = "0x6EBF24")]
	private string <propertyName>k__BackingField;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Action<Vector3> _setter;

	[Token(Token = "0x1700001B")]
	public string propertyName
	{
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x9A32DC", Offset = "0x9A32DC", VA = "0x9A32DC", Slot = "8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED0D0", Offset = "0x6ED0D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x9A32E4", Offset = "0x9A32E4", VA = "0x9A32E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED0E0", Offset = "0x6ED0E0")]
		private set
		{
		}
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x9A32EC", Offset = "0x9A32EC", VA = "0x9A32EC")]
	public Vector3TweenProperty(string propertyName, Vector3 endValue, bool isRelative = false)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x9A331C", Offset = "0x9A331C", VA = "0x9A331C", Slot = "5")]
	public override bool validateTarget(object target)
	{
		return default(bool);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x9A3390", Offset = "0x9A3390", VA = "0x9A3390", Slot = "7")]
	public override void prepareForUse()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x9A3460", Offset = "0x9A3460", VA = "0x9A3460", Slot = "6")]
	public override void tick(float totalElapsedTime)
	{
	}
}
[Token(Token = "0x200002D")]
public class Vector3XTweenProperty : AbstractVector3TweenProperty, IGenericProperty
{
	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBF34", Offset = "0x6EBF34")]
	private string <propertyName>k__BackingField;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Action<Vector3> _setter;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected Func<Vector3> _getter;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected new float _originalEndValue;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	protected new float _startValue;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected new float _endValue;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	protected new float _diffValue;

	[Token(Token = "0x1700001C")]
	public string propertyName
	{
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x9A3518", Offset = "0x9A3518", VA = "0x9A3518", Slot = "8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED0F0", Offset = "0x6ED0F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x9A3520", Offset = "0x9A3520", VA = "0x9A3520")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED100", Offset = "0x6ED100")]
		private set
		{
		}
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x9A3528", Offset = "0x9A3528", VA = "0x9A3528")]
	public Vector3XTweenProperty(string propertyName, float endValue, bool isRelative = false)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x9A3578", Offset = "0x9A3578", VA = "0x9A3578", Slot = "5")]
	public override bool validateTarget(object target)
	{
		return default(bool);
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x9A35EC", Offset = "0x9A35EC", VA = "0x9A35EC", Slot = "7")]
	public override void prepareForUse()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x9A36D4", Offset = "0x9A36D4", VA = "0x9A36D4", Slot = "6")]
	public override void tick(float totalElapsedTime)
	{
	}
}
[Token(Token = "0x200002E")]
public class Vector3YTweenProperty : Vector3XTweenProperty
{
	[Token(Token = "0x600012C")]
	[Address(RVA = "0x9A3798", Offset = "0x9A3798", VA = "0x9A3798")]
	public Vector3YTweenProperty(string propertyName, float endValue, bool isRelative = false)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x9A37E8", Offset = "0x9A37E8", VA = "0x9A37E8", Slot = "7")]
	public override void prepareForUse()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x9A38D0", Offset = "0x9A38D0", VA = "0x9A38D0", Slot = "6")]
	public override void tick(float totalElapsedTime)
	{
	}
}
[Token(Token = "0x200002F")]
public class Vector3ZTweenProperty : Vector3XTweenProperty
{
	[Token(Token = "0x600012F")]
	[Address(RVA = "0x9A3998", Offset = "0x9A3998", VA = "0x9A3998")]
	public Vector3ZTweenProperty(string propertyName, float endValue, bool isRelative = false)
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x9A39E8", Offset = "0x9A39E8", VA = "0x9A39E8", Slot = "7")]
	public override void prepareForUse()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x9A3AD0", Offset = "0x9A3AD0", VA = "0x9A3AD0", Slot = "6")]
	public override void tick(float totalElapsedTime)
	{
	}
}
[Token(Token = "0x2000030")]
public class Vector4TweenProperty : AbstractTweenProperty, IGenericProperty
{
	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBF44", Offset = "0x6EBF44")]
	private string <propertyName>k__BackingField;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Action<Vector4> _setter;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected Vector4 _originalEndValue;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected Vector4 _startValue;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected Vector4 _endValue;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Vector4 _diffValue;

	[Token(Token = "0x1700001D")]
	public string propertyName
	{
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x9A3B98", Offset = "0x9A3B98", VA = "0x9A3B98", Slot = "8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED110", Offset = "0x6ED110")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x9A3BA0", Offset = "0x9A3BA0", VA = "0x9A3BA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED120", Offset = "0x6ED120")]
		private set
		{
		}
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x9A3BA8", Offset = "0x9A3BA8", VA = "0x9A3BA8")]
	public Vector4TweenProperty(string propertyName, Vector4 endValue, bool isRelative = false)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x9A3C00", Offset = "0x9A3C00", VA = "0x9A3C00", Slot = "5")]
	public override bool validateTarget(object target)
	{
		return default(bool);
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x9A3C74", Offset = "0x9A3C74", VA = "0x9A3C74", Slot = "7")]
	public override void prepareForUse()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x9A3DD8", Offset = "0x9A3DD8", VA = "0x9A3DD8", Slot = "6")]
	public override void tick(float totalElapsedTime)
	{
	}
}
[Token(Token = "0x2000031")]
public struct GoSmoothedQuaternion
{
	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GoSmoothingType smoothingType;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float duration;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private Quaternion _currentValue;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Quaternion _target;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Quaternion _start;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float _startTime;

	[Token(Token = "0x1700001E")]
	public Quaternion smoothValue
	{
		[Token(Token = "0x6000139")]
		[Address(RVA = "0xEDA908", Offset = "0xEDA908", VA = "0xEDA908")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600013A")]
		[Address(RVA = "0xEDAA70", Offset = "0xEDAA70", VA = "0xEDAA70")]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public float x
	{
		[Token(Token = "0x600013B")]
		[Address(RVA = "0xEDAACC", Offset = "0xEDAACC", VA = "0xEDAACC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600013C")]
		[Address(RVA = "0xEDAAD4", Offset = "0xEDAAD4", VA = "0xEDAAD4")]
		set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public float y
	{
		[Token(Token = "0x600013D")]
		[Address(RVA = "0xEDAB20", Offset = "0xEDAB20", VA = "0xEDAB20")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600013E")]
		[Address(RVA = "0xEDAB28", Offset = "0xEDAB28", VA = "0xEDAB28")]
		set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public float z
	{
		[Token(Token = "0x600013F")]
		[Address(RVA = "0xEDAB78", Offset = "0xEDAB78", VA = "0xEDAB78")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000140")]
		[Address(RVA = "0xEDAB80", Offset = "0xEDAB80", VA = "0xEDAB80")]
		set
		{
		}
	}

	[Token(Token = "0x17000022")]
	public float w
	{
		[Token(Token = "0x6000141")]
		[Address(RVA = "0xEDABD0", Offset = "0xEDABD0", VA = "0xEDABD0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000142")]
		[Address(RVA = "0xEDABD8", Offset = "0xEDABD8", VA = "0xEDABD8")]
		set
		{
		}
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xEDA8BC", Offset = "0xEDA8BC", VA = "0xEDA8BC")]
	public GoSmoothedQuaternion(Quaternion quat)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xEDAC28", Offset = "0xEDAC28", VA = "0xEDAC28")]
	public static implicit operator GoSmoothedQuaternion(Quaternion q)
	{
		return default(GoSmoothedQuaternion);
	}
}
[Token(Token = "0x2000032")]
public struct GoSmoothedVector3
{
	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GoSmoothingType smoothingType;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float duration;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private Vector3 _currentValue;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Vector3 _target;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 _start;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _startTime;

	[Token(Token = "0x17000023")]
	public Vector3 smoothValue
	{
		[Token(Token = "0x6000145")]
		[Address(RVA = "0xEDAC8C", Offset = "0xEDAC8C", VA = "0xEDAC8C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000146")]
		[Address(RVA = "0xEDADCC", Offset = "0xEDADCC", VA = "0xEDADCC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000024")]
	public float x
	{
		[Token(Token = "0x6000147")]
		[Address(RVA = "0xEDAE24", Offset = "0xEDAE24", VA = "0xEDAE24")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000148")]
		[Address(RVA = "0xEDAE2C", Offset = "0xEDAE2C", VA = "0xEDAE2C")]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public float y
	{
		[Token(Token = "0x6000149")]
		[Address(RVA = "0xEDAE78", Offset = "0xEDAE78", VA = "0xEDAE78")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600014A")]
		[Address(RVA = "0xEDAE80", Offset = "0xEDAE80", VA = "0xEDAE80")]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public float z
	{
		[Token(Token = "0x600014B")]
		[Address(RVA = "0xEDAED0", Offset = "0xEDAED0", VA = "0xEDAED0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600014C")]
		[Address(RVA = "0xEDAED8", Offset = "0xEDAED8", VA = "0xEDAED8")]
		set
		{
		}
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xEDAC44", Offset = "0xEDAC44", VA = "0xEDAC44")]
	public GoSmoothedVector3(Vector3 vector)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xEDAF28", Offset = "0xEDAF28", VA = "0xEDAF28")]
	public static implicit operator GoSmoothedVector3(Vector3 v)
	{
		return default(GoSmoothedVector3);
	}
}
[Token(Token = "0x2000033")]
public enum GoSmoothingType
{
	[Token(Token = "0x40000DE")]
	Lerp,
	[Token(Token = "0x40000DF")]
	Slerp
}
[Token(Token = "0x2000034")]
public class EulerAnglesTweenProperty : AbstractVector3TweenProperty
{
	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool _useLocalEulers;

	[Token(Token = "0x17000027")]
	public bool useLocalEulers
	{
		[Token(Token = "0x600014E")]
		[Address(RVA = "0xED6090", Offset = "0xED6090", VA = "0xED6090")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xED6098", Offset = "0xED6098", VA = "0xED6098")]
	public EulerAnglesTweenProperty(Vector3 endValue, bool isRelative = false, bool useLocalEulers = false)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xED6100", Offset = "0xED6100", VA = "0xED6100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xED6108", Offset = "0xED6108", VA = "0xED6108", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xED622C", Offset = "0xED622C", VA = "0xED622C", Slot = "7")]
	public override void prepareForUse()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xED6338", Offset = "0xED6338", VA = "0xED6338", Slot = "6")]
	public override void tick(float totalElapsedTime)
	{
	}
}
[Token(Token = "0x2000035")]
public class MaterialColorTweenProperty : AbstractColorTweenProperty
{
	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private string _materialColorName;

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xEDE8B0", Offset = "0xEDE8B0", VA = "0xEDE8B0")]
	public MaterialColorTweenProperty(Color endValue, string colorName = "_Color", bool isRelative = false)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xEDFD48", Offset = "0xEDFD48", VA = "0xEDFD48", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0xEDFD50", Offset = "0xEDFD50", VA = "0xEDFD50", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xEDFE10", Offset = "0xEDFE10", VA = "0xEDFE10", Slot = "7")]
	public override void prepareForUse()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xEDFE98", Offset = "0xEDFE98", VA = "0xEDFE98", Slot = "6")]
	public override void tick(float totalElapsedTime)
	{
	}
}
[Token(Token = "0x2000036")]
public class PositionPathTweenProperty : AbstractTweenProperty
{
	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected bool _useLocalPosition;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Transform _target;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected Vector3 _startValue;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GoSpline _path;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GoLookAtType _lookAtType;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Transform _lookTarget;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GoSmoothedQuaternion _smoothedRotation;

	[Token(Token = "0x17000028")]
	public bool useLocalPosition
	{
		[Token(Token = "0x6000159")]
		[Address(RVA = "0xEE01F8", Offset = "0xEE01F8", VA = "0xEE01F8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xEDE46C", Offset = "0xEDE46C", VA = "0xEDE46C")]
	public PositionPathTweenProperty(GoSpline path, bool isRelative = false, bool useLocalPosition = false, GoLookAtType lookAtType = GoLookAtType.None, [Optional] Transform lookTarget)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xEE0200", Offset = "0xEE0200", VA = "0xEE0200", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xEE0208", Offset = "0xEE0208", VA = "0xEE0208", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xEE032C", Offset = "0xEE032C", VA = "0xEE032C", Slot = "7")]
	public override void prepareForUse()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xEE04EC", Offset = "0xEE04EC", VA = "0xEE04EC", Slot = "6")]
	public override void tick(float totalElapsedTime)
	{
	}
}
[Token(Token = "0x2000037")]
public class PositionTweenProperty : AbstractVector3TweenProperty
{
	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected bool _useLocalPosition;

	[Token(Token = "0x17000029")]
	public bool useLocalPosition
	{
		[Token(Token = "0x600015F")]
		[Address(RVA = "0xEE07B8", Offset = "0xEE07B8", VA = "0xEE07B8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0xEDE34C", Offset = "0xEDE34C", VA = "0xEDE34C")]
	public PositionTweenProperty(Vector3 endValue, bool isRelative = false, bool useLocalPosition = false)
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0xEE07C0", Offset = "0xEE07C0", VA = "0xEE07C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0xEE07C8", Offset = "0xEE07C8", VA = "0xEE07C8", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xEE08EC", Offset = "0xEE08EC", VA = "0xEE08EC", Slot = "7")]
	public override void prepareForUse()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xEE0B08", Offset = "0xEE0B08", VA = "0xEE0B08", Slot = "6")]
	public override void tick(float totalElapsedTime)
	{
	}
}
[Token(Token = "0x2000038")]
public class RotationQuaternionTweenProperty : AbstractQuaternionTweenProperty
{
	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool _useLocalRotation;

	[Token(Token = "0x1700002A")]
	public bool useLocalRotation
	{
		[Token(Token = "0x6000165")]
		[Address(RVA = "0xEE1904", Offset = "0xEE1904", VA = "0xEE1904")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xEDE780", Offset = "0xEDE780", VA = "0xEDE780")]
	public RotationQuaternionTweenProperty(Quaternion endValue, bool isRelative = false, bool useLocalRotation = false)
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xEE190C", Offset = "0xEE190C", VA = "0xEE190C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xEE1914", Offset = "0xEE1914", VA = "0xEE1914", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xEE19D8", Offset = "0xEE19D8", VA = "0xEE19D8", Slot = "7")]
	public override void prepareForUse()
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xEE1AE4", Offset = "0xEE1AE4", VA = "0xEE1AE4", Slot = "6")]
	public override void tick(float totalElapsedTime)
	{
	}
}
[Token(Token = "0x2000039")]
public class RotationTweenProperty : AbstractVector3TweenProperty
{
	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool _useLocalRotation;

	[Token(Token = "0x1700002B")]
	public bool useLocalRotation
	{
		[Token(Token = "0x600016B")]
		[Address(RVA = "0xEE1C24", Offset = "0xEE1C24", VA = "0xEE1C24")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xEDE658", Offset = "0xEDE658", VA = "0xEDE658")]
	public RotationTweenProperty(Vector3 endValue, bool isRelative = false, bool useLocalRotation = false)
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0xEE1C2C", Offset = "0xEE1C2C", VA = "0xEE1C2C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xEE1C34", Offset = "0xEE1C34", VA = "0xEE1C34", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xEE1D58", Offset = "0xEE1D58", VA = "0xEE1D58", Slot = "7")]
	public override void prepareForUse()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xEE1FB4", Offset = "0xEE1FB4", VA = "0xEE1FB4", Slot = "6")]
	public override void tick(float totalElapsedTime)
	{
	}
}
[Token(Token = "0x200003A")]
public class ScalePathTweenProperty : AbstractTweenProperty
{
	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected Transform _target;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Vector3 _startValue;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GoSpline _path;

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xEDE618", Offset = "0xEDE618", VA = "0xEDE618")]
	public ScalePathTweenProperty(GoSpline path, bool isRelative = false)
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xEE23B4", Offset = "0xEE23B4", VA = "0xEE23B4", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0xEE23BC", Offset = "0xEE23BC", VA = "0xEE23BC", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xEE248C", Offset = "0xEE248C", VA = "0xEE248C", Slot = "7")]
	public override void prepareForUse()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xEE2590", Offset = "0xEE2590", VA = "0xEE2590", Slot = "6")]
	public override void tick(float totalElapsedTime)
	{
	}
}
[Token(Token = "0x200003B")]
public class ScaleTweenProperty : AbstractVector3TweenProperty
{
	[Token(Token = "0x6000176")]
	[Address(RVA = "0xEDE528", Offset = "0xEDE528", VA = "0xEDE528")]
	public ScaleTweenProperty(Vector3 endValue, bool isRelative = false)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xEE26AC", Offset = "0xEE26AC", VA = "0xEE26AC", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xEE26B4", Offset = "0xEE26B4", VA = "0xEE26B4", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xEE2784", Offset = "0xEE2784", VA = "0xEE2784", Slot = "7")]
	public override void prepareForUse()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xEE2868", Offset = "0xEE2868", VA = "0xEE2868", Slot = "6")]
	public override void tick(float totalElapsedTime)
	{
	}
}
[Token(Token = "0x200003C")]
public class ShakeTweenProperty : AbstractTweenProperty
{
	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _target;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 _shakeMagnitude;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 _originalEndValue;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 _startPosition;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector3 _startScale;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3 _startEulers;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private GoShakeType _shakeType;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int _frameCount;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int _frameMod;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool _useLocalProperties;

	[Token(Token = "0x1700002C")]
	public bool useLocalProperties
	{
		[Token(Token = "0x600017B")]
		[Address(RVA = "0xEE2918", Offset = "0xEE2918", VA = "0xEE2918")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xEDE918", Offset = "0xEDE918", VA = "0xEDE918")]
	public ShakeTweenProperty(Vector3 shakeMagnitude, GoShakeType shakeType, int frameMod = 1, bool useLocalProperties = false)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xEE2920", Offset = "0xEE2920", VA = "0xEE2920", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xEE2928", Offset = "0xEE2928", VA = "0xEE2928", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xEE29E0", Offset = "0xEE29E0", VA = "0xEE29E0", Slot = "5")]
	public override bool validateTarget(object target)
	{
		return default(bool);
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xEE2A60", Offset = "0xEE2A60", VA = "0xEE2A60", Slot = "7")]
	public override void prepareForUse()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xEE2B68", Offset = "0xEE2B68", VA = "0xEE2B68")]
	private Vector3 randomDiminishingTarget(float falloffValue)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xEE2C04", Offset = "0xEE2C04", VA = "0xEE2C04", Slot = "6")]
	public override void tick(float totalElapsedTime)
	{
	}
}
[Token(Token = "0x200003D")]
public abstract class AbstractGoSplineSolver
{
	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected List<Vector3> _nodes;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected float _pathLength;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected int totalSubdivisionsPerNodeForLookupTable;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected Dictionary<float, float> _segmentTimeForDistance;

	[Token(Token = "0x1700002D")]
	public List<Vector3> nodes
	{
		[Token(Token = "0x6000183")]
		[Address(RVA = "0xED2D70", Offset = "0xED2D70", VA = "0xED2D70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xED2D78", Offset = "0xED2D78", VA = "0xED2D78", Slot = "4")]
	public virtual void buildPath()
	{
	}

	[Token(Token = "0x6000185")]
	public abstract void closePath();

	[Token(Token = "0x6000186")]
	public abstract Vector3 getPoint(float t);

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xED2F1C", Offset = "0xED2F1C", VA = "0xED2F1C", Slot = "7")]
	public virtual Vector3 getPointOnPath(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0xED30AC", Offset = "0xED30AC", VA = "0xED30AC")]
	public void reverseNodes()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xED3104", Offset = "0xED3104", VA = "0xED3104", Slot = "8")]
	public virtual void drawGizmos()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xED3108", Offset = "0xED3108", VA = "0xED3108")]
	protected AbstractGoSplineSolver()
	{
	}
}
[Token(Token = "0x200003E")]
public class GoSpline
{
	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBF54", Offset = "0x6EBF54")]
	private int <currentSegment>k__BackingField;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBF64", Offset = "0x6EBF64")]
	private bool <isClosed>k__BackingField;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBF74", Offset = "0x6EBF74")]
	private GoSplineType <splineType>k__BackingField;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private bool _isReversed;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AbstractGoSplineSolver _solver;

	[Token(Token = "0x1700002E")]
	public int currentSegment
	{
		[Token(Token = "0x600018B")]
		[Address(RVA = "0xEDAF7C", Offset = "0xEDAF7C", VA = "0xEDAF7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED130", Offset = "0x6ED130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600018C")]
		[Address(RVA = "0xEDAF84", Offset = "0xEDAF84", VA = "0xEDAF84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED140", Offset = "0x6ED140")]
		private set
		{
		}
	}

	[Token(Token = "0x1700002F")]
	public bool isClosed
	{
		[Token(Token = "0x600018D")]
		[Address(RVA = "0xEDAF8C", Offset = "0xEDAF8C", VA = "0xEDAF8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED150", Offset = "0x6ED150")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600018E")]
		[Address(RVA = "0xEDAF94", Offset = "0xEDAF94", VA = "0xEDAF94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED160", Offset = "0x6ED160")]
		private set
		{
		}
	}

	[Token(Token = "0x17000030")]
	public GoSplineType splineType
	{
		[Token(Token = "0x600018F")]
		[Address(RVA = "0xEDAFA0", Offset = "0xEDAFA0", VA = "0xEDAFA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED170", Offset = "0x6ED170")]
		get
		{
			return default(GoSplineType);
		}
		[Token(Token = "0x6000190")]
		[Address(RVA = "0xEDAFA8", Offset = "0xEDAFA8", VA = "0xEDAFA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED180", Offset = "0x6ED180")]
		private set
		{
		}
	}

	[Token(Token = "0x17000031")]
	public List<Vector3> nodes
	{
		[Token(Token = "0x6000191")]
		[Address(RVA = "0xEDAFB0", Offset = "0xEDAFB0", VA = "0xEDAFB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0xED7F0C", Offset = "0xED7F0C", VA = "0xED7F0C")]
	public GoSpline(List<Vector3> nodes, bool useStraightLines = false)
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0xEDB09C", Offset = "0xEDB09C", VA = "0xEDB09C")]
	public GoSpline(Vector3[] nodes, bool useStraightLines = false)
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0xEDB120", Offset = "0xEDB120", VA = "0xEDB120")]
	public GoSpline(string pathAssetName, bool useStraightLines = false)
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0xEDB154", Offset = "0xEDB154", VA = "0xEDB154")]
	private static List<Vector3> nodeListFromAsset(string pathAssetName)
	{
		return null;
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0xEDB320", Offset = "0xEDB320", VA = "0xEDB320")]
	public static List<Vector3> bytesToVector3List(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0xEDB46C", Offset = "0xEDB46C", VA = "0xEDB46C")]
	public Vector3 getLastNode()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0xEDB4E4", Offset = "0xEDB4E4", VA = "0xEDB4E4")]
	public void buildPath()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0xEDB504", Offset = "0xEDB504", VA = "0xEDB504")]
	private Vector3 getPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0xEDB524", Offset = "0xEDB524", VA = "0xEDB524")]
	public Vector3 getPointOnPath(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0xEDB5F0", Offset = "0xEDB5F0", VA = "0xEDB5F0")]
	public void closePath()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0xEDB628", Offset = "0xEDB628", VA = "0xEDB628")]
	public void reverseNodes()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0xEDB664", Offset = "0xEDB664", VA = "0xEDB664")]
	public void unreverseNodes()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0xED7FFC", Offset = "0xED7FFC", VA = "0xED7FFC")]
	public void drawGizmos(float resolution)
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xEDB69C", Offset = "0xEDB69C", VA = "0xEDB69C")]
	public static void drawGizmos(Vector3[] path, float resolution = 50f)
	{
	}
}
[Token(Token = "0x200003F")]
public class GoSplineCatmullRomSolver : AbstractGoSplineSolver
{
	[Token(Token = "0x60001A0")]
	[Address(RVA = "0xEDB068", Offset = "0xEDB068", VA = "0xEDB068")]
	public GoSplineCatmullRomSolver(List<Vector3> nodes)
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0xEDB718", Offset = "0xEDB718", VA = "0xEDB718", Slot = "5")]
	public override void closePath()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0xEDBC50", Offset = "0xEDBC50", VA = "0xEDBC50", Slot = "6")]
	public override Vector3 getPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xEDC0F0", Offset = "0xEDC0F0", VA = "0xEDC0F0", Slot = "8")]
	public override void drawGizmos()
	{
	}
}
[Token(Token = "0x2000040")]
public class GoSplineCubicBezierSolver : AbstractGoSplineSolver
{
	[Token(Token = "0x60001A4")]
	[Address(RVA = "0xEDB034", Offset = "0xEDB034", VA = "0xEDB034")]
	public GoSplineCubicBezierSolver(List<Vector3> nodes)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0xEDC2C0", Offset = "0xEDC2C0", VA = "0xEDC2C0", Slot = "5")]
	public override void closePath()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0xEDC2C4", Offset = "0xEDC2C4", VA = "0xEDC2C4", Slot = "6")]
	public override Vector3 getPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0xEDC4BC", Offset = "0xEDC4BC", VA = "0xEDC4BC", Slot = "8")]
	public override void drawGizmos()
	{
	}
}
[Token(Token = "0x2000041")]
public class GoSplineQuadraticBezierSolver : AbstractGoSplineSolver
{
	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xEDB000", Offset = "0xEDB000", VA = "0xEDB000")]
	public GoSplineQuadraticBezierSolver(List<Vector3> nodes)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0xEDC630", Offset = "0xEDC630", VA = "0xEDC630")]
	protected float quadBezierLength(Vector3 startPoint, Vector3 controlPoint, Vector3 endPoint)
	{
		return default(float);
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0xEDC9AC", Offset = "0xEDC9AC", VA = "0xEDC9AC", Slot = "5")]
	public override void closePath()
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0xEDC9B0", Offset = "0xEDC9B0", VA = "0xEDC9B0", Slot = "6")]
	public override Vector3 getPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0xEDCB34", Offset = "0xEDCB34", VA = "0xEDCB34", Slot = "8")]
	public override void drawGizmos()
	{
	}
}
[Token(Token = "0x2000042")]
public class GoSplineStraightLineSolver : AbstractGoSplineSolver
{
	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<int, float> _segmentStartLocations;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<int, float> _segmentDistances;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _currentSegment;

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0xEDAFCC", Offset = "0xEDAFCC", VA = "0xEDAFCC")]
	public GoSplineStraightLineSolver(List<Vector3> nodes)
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0xEDCCA8", Offset = "0xEDCCA8", VA = "0xEDCCA8", Slot = "4")]
	public override void buildPath()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0xEDCF04", Offset = "0xEDCF04", VA = "0xEDCF04", Slot = "5")]
	public override void closePath()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0xEDD054", Offset = "0xEDD054", VA = "0xEDD054", Slot = "6")]
	public override Vector3 getPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0xEDD060", Offset = "0xEDD060", VA = "0xEDD060", Slot = "7")]
	public override Vector3 getPointOnPath(float t)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x2000043")]
public class Log
{
	[Token(Token = "0x60001B2")]
	[Address(RVA = "0xEDF984", Offset = "0xEDF984", VA = "0xEDF984")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x6ED190", Offset = "0x6ED190")]
	public static void Debug(string logString)
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0xEDF9EC", Offset = "0xEDF9EC", VA = "0xEDF9EC")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x6ED1C8", Offset = "0x6ED1C8")]
	public static void Debug(object message, UnityEngine.Object context)
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0xEDFA64", Offset = "0xEDFA64", VA = "0xEDFA64")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x6ED200", Offset = "0x6ED200")]
	public static void Warning(object message)
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0xEDFACC", Offset = "0xEDFACC", VA = "0xEDFACC")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x6ED238", Offset = "0x6ED238")]
	public static void Warning(object message, UnityEngine.Object context)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0xEDFB44", Offset = "0xEDFB44", VA = "0xEDFB44")]
	public static void Error(object message)
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xEDFBAC", Offset = "0xEDFBAC", VA = "0xEDFBAC")]
	public static void Error(object message, UnityEngine.Object context)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0xEDFC24", Offset = "0xEDFC24", VA = "0xEDFC24")]
	public static void ErrorFormat(object message, params object[] args)
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0xEDFC60", Offset = "0xEDFC60", VA = "0xEDFC60")]
	public static void Exception(Exception message)
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0xEDFCC8", Offset = "0xEDFCC8", VA = "0xEDFCC8")]
	public static void Exception(Exception message, UnityEngine.Object context)
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0xEDFD40", Offset = "0xEDFD40", VA = "0xEDFD40")]
	public Log()
	{
	}
}
[Token(Token = "0x2000044")]
public class PostProcessingOrderHook
{
	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBF84", Offset = "0x6EBF84")]
	private Behaviour <RequiredObject>k__BackingField;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBF94", Offset = "0x6EBF94")]
	private PostProcessingOrderController <Controller>k__BackingField;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBFA4", Offset = "0x6EBFA4")]
	private PostProcessingOrderController.RenderImageDelegate <Callback>k__BackingField;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBFB4", Offset = "0x6EBFB4")]
	private int <Order>k__BackingField;

	[Token(Token = "0x17000032")]
	public Behaviour RequiredObject
	{
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xEE15E0", Offset = "0xEE15E0", VA = "0xEE15E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED270", Offset = "0x6ED270")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xEE15E8", Offset = "0xEE15E8", VA = "0xEE15E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED280", Offset = "0x6ED280")]
		private set
		{
		}
	}

	[Token(Token = "0x17000033")]
	public PostProcessingOrderController Controller
	{
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xEE15F0", Offset = "0xEE15F0", VA = "0xEE15F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED290", Offset = "0x6ED290")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xEE15F8", Offset = "0xEE15F8", VA = "0xEE15F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED2A0", Offset = "0x6ED2A0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000034")]
	public PostProcessingOrderController.RenderImageDelegate Callback
	{
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xEE1600", Offset = "0xEE1600", VA = "0xEE1600")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED2B0", Offset = "0x6ED2B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xEE1608", Offset = "0xEE1608", VA = "0xEE1608")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED2C0", Offset = "0x6ED2C0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000035")]
	public int Order
	{
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xEE1610", Offset = "0xEE1610", VA = "0xEE1610")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED2D0", Offset = "0x6ED2D0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xEE1618", Offset = "0xEE1618", VA = "0xEE1618")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED2E0", Offset = "0x6ED2E0")]
		private set
		{
		}
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0xEE1620", Offset = "0xEE1620", VA = "0xEE1620")]
	public void PreRender()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0xEE163C", Offset = "0xEE163C", VA = "0xEE163C")]
	public void TriggerRender(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xEE0EC8", Offset = "0xEE0EC8", VA = "0xEE0EC8")]
	public PostProcessingOrderHook(Behaviour requiredObject, PostProcessingOrderController controller, PostProcessingOrderController.RenderImageDelegate callback, int priority)
	{
	}
}
[Token(Token = "0x2000045")]
public class PostProcessingOrderController : MonoBehaviour
{
	[Token(Token = "0x2000087")]
	public delegate void RenderImageDelegate(RenderTexture source, RenderTexture destination);

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<PostProcessingOrderHook> _hooks;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int _currentIndex;

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xEE0BD0", Offset = "0xEE0BD0", VA = "0xEE0BD0")]
	private static int CompareHooks(PostProcessingOrderHook a, PostProcessingOrderHook b)
	{
		return default(int);
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xEE0C10", Offset = "0xEE0C10", VA = "0xEE0C10")]
	public void Start()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xEE0C14", Offset = "0xEE0C14", VA = "0xEE0C14")]
	public void AddHook(PostProcessingOrderHook hook)
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xEE0CE4", Offset = "0xEE0CE4", VA = "0xEE0CE4")]
	public static void Hook(Component comp, PostProcessingOrderHook hook)
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xEE0DB8", Offset = "0xEE0DB8", VA = "0xEE0DB8")]
	public static PostProcessingOrderHook Hook(Behaviour behaviour, RenderImageDelegate callback, int order)
	{
		return null;
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xEE0F18", Offset = "0xEE0F18", VA = "0xEE0F18")]
	public void PreRender()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xEE0F20", Offset = "0xEE0F20", VA = "0xEE0F20")]
	public void TriggerRender(RenderTexture source, RenderTexture destination, object caller)
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xEE1524", Offset = "0xEE1524", VA = "0xEE1524")]
	public PostProcessingOrderController()
	{
	}
}
[Token(Token = "0x2000046")]
public static class RendererCommon
{
	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xEE1654", Offset = "0xEE1654", VA = "0xEE1654")]
	public static float GetLightmapScale(Renderer a)
	{
		return default(float);
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xEE165C", Offset = "0xEE165C", VA = "0xEE165C")]
	public static void SetLightmapScale(Renderer a, float scale)
	{
	}
}
[Token(Token = "0x2000047")]
public interface ISimpleJob
{
	[Token(Token = "0x60001D1")]
	void RunJob();

	[Token(Token = "0x60001D2")]
	void OnFinished();
}
[Token(Token = "0x2000048")]
public class SimpleJob : ISimpleJob
{
	[Token(Token = "0x2000088")]
	public delegate void WorkCB(ISimpleJob job);

	[Token(Token = "0x2000089")]
	public delegate void FinishedCB(ISimpleJob job);

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private WorkCB _work;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private FinishedCB _finished;

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xEE894C", Offset = "0xEE894C", VA = "0xEE894C")]
	public SimpleJob(WorkCB work)
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xEE8978", Offset = "0xEE8978", VA = "0xEE8978")]
	public SimpleJob(WorkCB work, FinishedCB finished)
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xEE89B0", Offset = "0xEE89B0", VA = "0xEE89B0", Slot = "4")]
	public void RunJob()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xEE8D58", Offset = "0xEE8D58", VA = "0xEE8D58", Slot = "5")]
	public void OnFinished()
	{
	}
}
[Token(Token = "0x2000049")]
public class SimpleJobSystem
{
	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly int MAX_QUEUED_JOBS;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ThreadSafeQueue<ISimpleJob> _jobQueue;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ThreadSafeQueue<ISimpleJob> _finishedQueue;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int _owningThread;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool _isRunning;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Thread[] _workers;

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xEE9180", Offset = "0xEE9180", VA = "0xEE9180")]
	public void Start(int threadCount)
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xEE931C", Offset = "0xEE931C", VA = "0xEE931C")]
	public void Stop()
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xEE9418", Offset = "0xEE9418", VA = "0xEE9418")]
	public int TickFinished()
	{
		return default(int);
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0xEE954C", Offset = "0xEE954C", VA = "0xEE954C")]
	public void Enqueue(ISimpleJob job)
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0xEE95F8", Offset = "0xEE95F8", VA = "0xEE95F8")]
	public void Enqueue(SimpleJob.WorkCB action, SimpleJob.FinishedCB finish)
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0xEE9670", Offset = "0xEE9670", VA = "0xEE9670")]
	private void SimpleJobThread()
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0xEE9788", Offset = "0xEE9788", VA = "0xEE9788", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0xEE9854", Offset = "0xEE9854", VA = "0xEE9854")]
	public SimpleJobSystem()
	{
	}
}
[Token(Token = "0x200004A")]
public class ThreadSafeQueue<T>
{
	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Queue<T> _queue;

	[Token(Token = "0x17000036")]
	public int Count
	{
		[Token(Token = "0x60001E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60001DF")]
	public ThreadSafeQueue()
	{
	}

	[Token(Token = "0x60001E1")]
	public void Enqueue(T obj)
	{
	}

	[Token(Token = "0x60001E2")]
	public T Dequeue()
	{
		return (T)null;
	}

	[Token(Token = "0x60001E3")]
	public bool TryDequeue(out T outObj)
	{
		return default(bool);
	}
}
[Token(Token = "0x200004B")]
public class iTween : MonoBehaviour
{
	[Token(Token = "0x200008A")]
	private delegate float EasingFunction(float start, float end, float Value);

	[Token(Token = "0x200008B")]
	private delegate void ApplyTween();

	[Token(Token = "0x200008C")]
	public enum EaseType
	{
		[Token(Token = "0x4000331")]
		easeInQuad,
		[Token(Token = "0x4000332")]
		easeOutQuad,
		[Token(Token = "0x4000333")]
		easeInOutQuad,
		[Token(Token = "0x4000334")]
		easeInCubic,
		[Token(Token = "0x4000335")]
		easeOutCubic,
		[Token(Token = "0x4000336")]
		easeInOutCubic,
		[Token(Token = "0x4000337")]
		easeInQuart,
		[Token(Token = "0x4000338")]
		easeOutQuart,
		[Token(Token = "0x4000339")]
		easeInOutQuart,
		[Token(Token = "0x400033A")]
		easeInQuint,
		[Token(Token = "0x400033B")]
		easeOutQuint,
		[Token(Token = "0x400033C")]
		easeInOutQuint,
		[Token(Token = "0x400033D")]
		easeInSine,
		[Token(Token = "0x400033E")]
		easeOutSine,
		[Token(Token = "0x400033F")]
		easeInOutSine,
		[Token(Token = "0x4000340")]
		easeInExpo,
		[Token(Token = "0x4000341")]
		easeOutExpo,
		[Token(Token = "0x4000342")]
		easeInOutExpo,
		[Token(Token = "0x4000343")]
		easeInCirc,
		[Token(Token = "0x4000344")]
		easeOutCirc,
		[Token(Token = "0x4000345")]
		easeInOutCirc,
		[Token(Token = "0x4000346")]
		linear,
		[Token(Token = "0x4000347")]
		spring,
		[Token(Token = "0x4000348")]
		easeInBounce,
		[Token(Token = "0x4000349")]
		easeOutBounce,
		[Token(Token = "0x400034A")]
		easeInOutBounce,
		[Token(Token = "0x400034B")]
		easeInBack,
		[Token(Token = "0x400034C")]
		easeOutBack,
		[Token(Token = "0x400034D")]
		easeInOutBack,
		[Token(Token = "0x400034E")]
		easeInElastic,
		[Token(Token = "0x400034F")]
		easeOutElastic,
		[Token(Token = "0x4000350")]
		easeInOutElastic,
		[Token(Token = "0x4000351")]
		punch
	}

	[Token(Token = "0x200008D")]
	public enum LoopType
	{
		[Token(Token = "0x4000353")]
		none,
		[Token(Token = "0x4000354")]
		loop,
		[Token(Token = "0x4000355")]
		pingPong
	}

	[Token(Token = "0x200008E")]
	public enum NamedValueColor
	{
		[Token(Token = "0x4000357")]
		_Color,
		[Token(Token = "0x4000358")]
		_SpecColor,
		[Token(Token = "0x4000359")]
		_Emission,
		[Token(Token = "0x400035A")]
		_ReflectColor
	}

	[Token(Token = "0x200008F")]
	public static class Defaults
	{
		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float time;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float delay;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static NamedValueColor namedColorValue;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static LoopType loopType;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static EaseType easeType;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static float lookSpeed;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static bool isLocal;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static Space space;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static bool orientToPath;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static Color color;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static float updateTimePercentage;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static float updateTime;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static float lookAhead;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static bool useRealTime;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static Vector3 up;
	}

	[Token(Token = "0x2000090")]
	private class CRSpline
	{
		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3[] pts;

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1392074", Offset = "0x1392074", VA = "0x1392074")]
		public CRSpline(params Vector3[] pts)
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x13920FC", Offset = "0x13920FC", VA = "0x13920FC")]
		public Vector3 Interp(float t)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBD64", Offset = "0x6EBD64")]
	private sealed class <TweenDelay>d__145 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x1700005E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x1391C34", Offset = "0x1391C34", VA = "0x1391C34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x1391C9C", Offset = "0x1391C9C", VA = "0x1391C9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1391B30", Offset = "0x1391B30", VA = "0x1391B30")]
		[DebuggerHidden]
		public <TweenDelay>d__145(int <>1__state)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x1391B5C", Offset = "0x1391B5C", VA = "0x1391B5C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1391B60", Offset = "0x1391B60", VA = "0x1391B60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1391C3C", Offset = "0x1391C3C", VA = "0x1391C3C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBD74", Offset = "0x6EBD74")]
	private sealed class <TweenRestart>d__147 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x17000060")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x1391DB0", Offset = "0x1391DB0", VA = "0x1391DB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x1391E18", Offset = "0x1391E18", VA = "0x1391E18", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1391CA4", Offset = "0x1391CA4", VA = "0x1391CA4")]
		[DebuggerHidden]
		public <TweenRestart>d__147(int <>1__state)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1391CD0", Offset = "0x1391CD0", VA = "0x1391CD0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1391CD4", Offset = "0x1391CD4", VA = "0x1391CD4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x1391DB8", Offset = "0x1391DB8", VA = "0x1391DB8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBD84", Offset = "0x6EBD84")]
	private sealed class <Start>d__229 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x17000062")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x1391AC0", Offset = "0x1391AC0", VA = "0x1391AC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x1391B28", Offset = "0x1391B28", VA = "0x1391B28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x13919E4", Offset = "0x13919E4", VA = "0x13919E4")]
		[DebuggerHidden]
		public <Start>d__229(int <>1__state)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1391A10", Offset = "0x1391A10", VA = "0x1391A10", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1391A14", Offset = "0x1391A14", VA = "0x1391A14", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1391AC8", Offset = "0x1391AC8", VA = "0x1391AC8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<Hashtable> tweens;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string id;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string type;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string method;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public EaseType easeType;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float time;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float delay;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public LoopType loopType;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isRunning;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool isPaused;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string _name;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float runningTime;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float percentage;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float delayStarted;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool kinematic;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	private bool isLocal;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
	private bool loop;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
	private bool reverse;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool wasPaused;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool physics;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Hashtable tweenArguments;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Space space;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private EasingFunction ease;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private ApplyTween apply;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private AudioSource audioSource;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3[] vector3s;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector2[] vector2s;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Color[,] colors;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float[] floats;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Rect[] rects;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private CRSpline path;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Vector3 preUpdate;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private Vector3 postUpdate;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private NamedValueColor namedcolorvalue;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float lastRealTime;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private bool useRealTime;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Transform thisTransform;

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x9A3E94", Offset = "0x9A3E94", VA = "0x9A3E94")]
	public static void Init(GameObject target)
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x9A4118", Offset = "0x9A4118", VA = "0x9A4118")]
	public static void ValueTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x9A50E8", Offset = "0x9A50E8", VA = "0x9A50E8")]
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x9A53C8", Offset = "0x9A53C8", VA = "0x9A53C8")]
	public static void FadeFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x9A5E1C", Offset = "0x9A5E1C", VA = "0x9A5E1C")]
	public static void FadeTo(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x9A5FCC", Offset = "0x9A5FCC", VA = "0x9A5FCC")]
	public static void FadeTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x9A652C", Offset = "0x9A652C", VA = "0x9A652C")]
	public static void ColorFrom(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x9A543C", Offset = "0x9A543C", VA = "0x9A543C")]
	public static void ColorFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x9A6708", Offset = "0x9A6708", VA = "0x9A6708")]
	public static void ColorTo(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x9A6040", Offset = "0x9A6040", VA = "0x9A6040")]
	public static void ColorTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x9A68E4", Offset = "0x9A68E4", VA = "0x9A68E4")]
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x9A6B10", Offset = "0x9A6B10", VA = "0x9A6B10")]
	public static void AudioFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x9A6F18", Offset = "0x9A6F18", VA = "0x9A6F18")]
	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x9A7144", Offset = "0x9A7144", VA = "0x9A7144")]
	public static void AudioTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x9A72A0", Offset = "0x9A72A0", VA = "0x9A72A0")]
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x9A7434", Offset = "0x9A7434", VA = "0x9A7434")]
	public static void Stab(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x9A74E4", Offset = "0x9A74E4", VA = "0x9A74E4")]
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x9A76B0", Offset = "0x9A76B0", VA = "0x9A76B0")]
	public static void LookFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x9A7D10", Offset = "0x9A7D10", VA = "0x9A7D10")]
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x9A7EDC", Offset = "0x9A7EDC", VA = "0x9A7EDC")]
	public static void LookTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x9A81FC", Offset = "0x9A81FC", VA = "0x9A81FC")]
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x9A83C8", Offset = "0x9A83C8", VA = "0x9A83C8")]
	public static void MoveTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x9A8768", Offset = "0x9A8768", VA = "0x9A8768")]
	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x9A8934", Offset = "0x9A8934", VA = "0x9A8934")]
	public static void MoveFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x9A9234", Offset = "0x9A9234", VA = "0x9A9234")]
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x9A9400", Offset = "0x9A9400", VA = "0x9A9400")]
	public static void MoveAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x9A3F4C", Offset = "0x9A3F4C", VA = "0x9A3F4C")]
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x9A94DC", Offset = "0x9A94DC", VA = "0x9A94DC")]
	public static void MoveBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x9A95B8", Offset = "0x9A95B8", VA = "0x9A95B8")]
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x9A9784", Offset = "0x9A9784", VA = "0x9A9784")]
	public static void ScaleTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x9A9B1C", Offset = "0x9A9B1C", VA = "0x9A9B1C")]
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x9A9CE8", Offset = "0x9A9CE8", VA = "0x9A9CE8")]
	public static void ScaleFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x9AA194", Offset = "0x9AA194", VA = "0x9AA194")]
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x9AA360", Offset = "0x9AA360", VA = "0x9AA360")]
	public static void ScaleAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x9AA43C", Offset = "0x9AA43C", VA = "0x9AA43C")]
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x9AA608", Offset = "0x9AA608", VA = "0x9AA608")]
	public static void ScaleBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x9AA6E4", Offset = "0x9AA6E4", VA = "0x9AA6E4")]
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x9AA8B0", Offset = "0x9AA8B0", VA = "0x9AA8B0")]
	public static void RotateTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x9AAC50", Offset = "0x9AAC50", VA = "0x9AAC50")]
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x9AAE1C", Offset = "0x9AAE1C", VA = "0x9AAE1C")]
	public static void RotateFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x9AB380", Offset = "0x9AB380", VA = "0x9AB380")]
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x9AB54C", Offset = "0x9AB54C", VA = "0x9AB54C")]
	public static void RotateAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x9AB628", Offset = "0x9AB628", VA = "0x9AB628")]
	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x9AB7F4", Offset = "0x9AB7F4", VA = "0x9AB7F4")]
	public static void RotateBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x9AB8D0", Offset = "0x9AB8D0", VA = "0x9AB8D0")]
	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x9ABA9C", Offset = "0x9ABA9C", VA = "0x9ABA9C")]
	public static void ShakePosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x9ABB78", Offset = "0x9ABB78", VA = "0x9ABB78")]
	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x9ABD44", Offset = "0x9ABD44", VA = "0x9ABD44")]
	public static void ShakeScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x9ABE20", Offset = "0x9ABE20", VA = "0x9ABE20")]
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x9ABFEC", Offset = "0x9ABFEC", VA = "0x9ABFEC")]
	public static void ShakeRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x9AC0C8", Offset = "0x9AC0C8", VA = "0x9AC0C8")]
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x9AC294", Offset = "0x9AC294", VA = "0x9AC294")]
	public static void PunchPosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x9AC3B4", Offset = "0x9AC3B4", VA = "0x9AC3B4")]
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x9AC580", Offset = "0x9AC580", VA = "0x9AC580")]
	public static void PunchRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x9AC6A0", Offset = "0x9AC6A0", VA = "0x9AC6A0")]
	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x9AC86C", Offset = "0x9AC86C", VA = "0x9AC86C")]
	public static void PunchScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x9AC98C", Offset = "0x9AC98C", VA = "0x9AC98C")]
	private void GenerateTargets()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x9ADA0C", Offset = "0x9ADA0C", VA = "0x9ADA0C")]
	private void GenerateRectTargets()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x9AD8A0", Offset = "0x9AD8A0", VA = "0x9AD8A0")]
	private void GenerateColorTargets()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x9AD640", Offset = "0x9AD640", VA = "0x9AD640")]
	private void GenerateVector3Targets()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x9AD3AC", Offset = "0x9AD3AC", VA = "0x9AD3AC")]
	private void GenerateVector2Targets()
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x9AD1B8", Offset = "0x9AD1B8", VA = "0x9AD1B8")]
	private void GenerateFloatTargets()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x9ADB48", Offset = "0x9ADB48", VA = "0x9ADB48")]
	private void GenerateColorToTargets()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x9AE4A0", Offset = "0x9AE4A0", VA = "0x9AE4A0")]
	private void GenerateAudioToTargets()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x9B3244", Offset = "0x9B3244", VA = "0x9B3244")]
	private void GenerateStabTargets()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x9B2A18", Offset = "0x9B2A18", VA = "0x9B2A18")]
	private void GenerateLookToTargets()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x9AE7AC", Offset = "0x9AE7AC", VA = "0x9AE7AC")]
	private void GenerateMoveToPathTargets()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x9AEEDC", Offset = "0x9AEEDC", VA = "0x9AEEDC")]
	private void GenerateMoveToTargets()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x9AF528", Offset = "0x9AF528", VA = "0x9AF528")]
	private void GenerateMoveByTargets()
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x9AFB24", Offset = "0x9AFB24", VA = "0x9AFB24")]
	private void GenerateScaleToTargets()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x9B0074", Offset = "0x9B0074", VA = "0x9B0074")]
	private void GenerateScaleByTargets()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x9B04C8", Offset = "0x9B04C8", VA = "0x9B04C8")]
	private void GenerateScaleAddTargets()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x9B0910", Offset = "0x9B0910", VA = "0x9B0910")]
	private void GenerateRotateToTargets()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x9B0F40", Offset = "0x9B0F40", VA = "0x9B0F40")]
	private void GenerateRotateAddTargets()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x9B1390", Offset = "0x9B1390", VA = "0x9B1390")]
	private void GenerateRotateByTargets()
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x9B184C", Offset = "0x9B184C", VA = "0x9B184C")]
	private void GenerateShakePositionTargets()
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x9B1B40", Offset = "0x9B1B40", VA = "0x9B1B40")]
	private void GenerateShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x9B1E08", Offset = "0x9B1E08", VA = "0x9B1E08")]
	private void GenerateShakeRotationTargets()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x9B20D0", Offset = "0x9B20D0", VA = "0x9B20D0")]
	private void GeneratePunchPositionTargets()
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x9B2408", Offset = "0x9B2408", VA = "0x9B2408")]
	private void GeneratePunchRotationTargets()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x9B2714", Offset = "0x9B2714", VA = "0x9B2714")]
	private void GeneratePunchScaleTargets()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x9B3948", Offset = "0x9B3948", VA = "0x9B3948")]
	private void ApplyRectTargets()
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x9B3C48", Offset = "0x9B3C48", VA = "0x9B3C48")]
	private void ApplyColorTargets()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x9B3E78", Offset = "0x9B3E78", VA = "0x9B3E78")]
	private void ApplyVector3Targets()
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x9B406C", Offset = "0x9B406C", VA = "0x9B406C")]
	private void ApplyVector2Targets()
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x9B420C", Offset = "0x9B420C", VA = "0x9B420C")]
	private void ApplyFloatTargets()
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x9B4364", Offset = "0x9B4364", VA = "0x9B4364")]
	private void ApplyColorToTargets()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x9B48C4", Offset = "0x9B48C4", VA = "0x9B48C4")]
	private void ApplyAudioToTargets()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x9B4A30", Offset = "0x9B4A30", VA = "0x9B4A30")]
	private void ApplyStabTargets()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x9B4A34", Offset = "0x9B4A34", VA = "0x9B4A34")]
	private void ApplyMoveToPathTargets()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x9B4D94", Offset = "0x9B4D94", VA = "0x9B4D94")]
	private void ApplyMoveToTargets()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x9B4FA0", Offset = "0x9B4FA0", VA = "0x9B4FA0")]
	private void ApplyMoveByTargets()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x9B52E0", Offset = "0x9B52E0", VA = "0x9B52E0")]
	private void ApplyScaleToTargets()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x9B5448", Offset = "0x9B5448", VA = "0x9B5448")]
	private void ApplyLookToTargets()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x9B5620", Offset = "0x9B5620", VA = "0x9B5620")]
	private void ApplyRotateToTargets()
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x9B5950", Offset = "0x9B5950", VA = "0x9B5950")]
	private void ApplyRotateAddTargets()
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x9B5BE4", Offset = "0x9B5BE4", VA = "0x9B5BE4")]
	private void ApplyShakePositionTargets()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x9B5FFC", Offset = "0x9B5FFC", VA = "0x9B5FFC")]
	private void ApplyShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x9B6210", Offset = "0x9B6210", VA = "0x9B6210")]
	private void ApplyShakeRotationTargets()
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x9B6480", Offset = "0x9B6480", VA = "0x9B6480")]
	private void ApplyPunchPositionTargets()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x9B6934", Offset = "0x9B6934", VA = "0x9B6934")]
	private void ApplyPunchRotationTargets()
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x9B6C7C", Offset = "0x9B6C7C", VA = "0x9B6C7C")]
	private void ApplyPunchScaleTargets()
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x9B6EDC", Offset = "0x9B6EDC", VA = "0x9B6EDC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6ED2F0", Offset = "0x6ED2F0")]
	private IEnumerator TweenDelay()
	{
		return null;
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x9B6F4C", Offset = "0x9B6F4C", VA = "0x9B6F4C")]
	private void TweenStart()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x9B78E0", Offset = "0x9B78E0", VA = "0x9B78E0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6ED354", Offset = "0x6ED354")]
	private IEnumerator TweenRestart()
	{
		return null;
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x9B7950", Offset = "0x9B7950", VA = "0x9B7950")]
	private void TweenUpdate()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x9B7A34", Offset = "0x9B7A34", VA = "0x9B7A34")]
	private void TweenComplete()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x9B7B04", Offset = "0x9B7B04", VA = "0x9B7B04")]
	private void TweenLoop()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x9B7BA8", Offset = "0x9B7BA8", VA = "0x9B7BA8")]
	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
	{
		return default(Rect);
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x9B7D70", Offset = "0x9B7D70", VA = "0x9B7D70")]
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x9B7E7C", Offset = "0x9B7E7C", VA = "0x9B7E7C")]
	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x9B7D30", Offset = "0x9B7D30", VA = "0x9B7D30")]
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		return default(float);
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x9B7F60", Offset = "0x9B7F60", VA = "0x9B7F60")]
	public static void FadeUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x9B89DC", Offset = "0x9B89DC", VA = "0x9B89DC")]
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x9B8020", Offset = "0x9B8020", VA = "0x9B8020")]
	public static void ColorUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x9B8B8C", Offset = "0x9B8B8C", VA = "0x9B8B8C")]
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x9B8D68", Offset = "0x9B8D68", VA = "0x9B8D68")]
	public static void AudioUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x9B9218", Offset = "0x9B9218", VA = "0x9B9218")]
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x9B9444", Offset = "0x9B9444", VA = "0x9B9444")]
	public static void RotateUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x9B9A6C", Offset = "0x9B9A6C", VA = "0x9B9A6C")]
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x9B9C38", Offset = "0x9B9C38", VA = "0x9B9C38")]
	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x9BA220", Offset = "0x9BA220", VA = "0x9BA220")]
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x9BA3EC", Offset = "0x9BA3EC", VA = "0x9BA3EC")]
	public static void MoveUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x9BB55C", Offset = "0x9BB55C", VA = "0x9BB55C")]
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x9BAC50", Offset = "0x9BAC50", VA = "0x9BAC50")]
	public static void LookUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x9BB728", Offset = "0x9BB728", VA = "0x9BB728")]
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x9BB8F4", Offset = "0x9BB8F4", VA = "0x9BB8F4")]
	public static float PathLength(Transform[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x9B37D0", Offset = "0x9B37D0", VA = "0x9B37D0")]
	public static float PathLength(Vector3[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x9BC1D8", Offset = "0x9BC1D8", VA = "0x9BC1D8")]
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x9BC288", Offset = "0x9BC288", VA = "0x9BC288")]
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x9BC320", Offset = "0x9BC320", VA = "0x9BC320")]
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x9BC458", Offset = "0x9BC458", VA = "0x9BC458")]
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x9BC578", Offset = "0x9BC578", VA = "0x9BC578")]
	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x9BC684", Offset = "0x9BC684", VA = "0x9BC684")]
	public static void DrawLine(Vector3[] line)
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x9BC8E8", Offset = "0x9BC8E8", VA = "0x9BC8E8")]
	public static void DrawLine(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x9BC9AC", Offset = "0x9BC9AC", VA = "0x9BC9AC")]
	public static void DrawLine(Transform[] line)
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x9BCB20", Offset = "0x9BCB20", VA = "0x9BCB20")]
	public static void DrawLine(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x9BCC74", Offset = "0x9BCC74", VA = "0x9BCC74")]
	public static void DrawLineGizmos(Vector3[] line)
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x9BCD58", Offset = "0x9BCD58", VA = "0x9BCD58")]
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x9BCE1C", Offset = "0x9BCE1C", VA = "0x9BCE1C")]
	public static void DrawLineGizmos(Transform[] line)
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x9BCF90", Offset = "0x9BCF90", VA = "0x9BCF90")]
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x9BD0E4", Offset = "0x9BD0E4", VA = "0x9BD0E4")]
	public static void DrawLineHandles(Vector3[] line)
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x9BD1C8", Offset = "0x9BD1C8", VA = "0x9BD1C8")]
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x9BD28C", Offset = "0x9BD28C", VA = "0x9BD28C")]
	public static void DrawLineHandles(Transform[] line)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x9BD400", Offset = "0x9BD400", VA = "0x9BD400")]
	public static void DrawLineHandles(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x9BD554", Offset = "0x9BD554", VA = "0x9BD554")]
	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x9BD5CC", Offset = "0x9BD5CC", VA = "0x9BD5CC")]
	public static void DrawPath(Vector3[] path)
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x9BD8A4", Offset = "0x9BD8A4", VA = "0x9BD8A4")]
	public static void DrawPath(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x9BD968", Offset = "0x9BD968", VA = "0x9BD968")]
	public static void DrawPath(Transform[] path)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x9BDADC", Offset = "0x9BDADC", VA = "0x9BDADC")]
	public static void DrawPath(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x9BDC30", Offset = "0x9BDC30", VA = "0x9BDC30")]
	public static void DrawPathGizmos(Vector3[] path)
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x9BDD14", Offset = "0x9BDD14", VA = "0x9BDD14")]
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x9BDDD8", Offset = "0x9BDDD8", VA = "0x9BDDD8")]
	public static void DrawPathGizmos(Transform[] path)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x9BDF4C", Offset = "0x9BDF4C", VA = "0x9BDF4C")]
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x9BE0A0", Offset = "0x9BE0A0", VA = "0x9BE0A0")]
	public static void DrawPathHandles(Vector3[] path)
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x9BE184", Offset = "0x9BE184", VA = "0x9BE184")]
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x9BE248", Offset = "0x9BE248", VA = "0x9BE248")]
	public static void DrawPathHandles(Transform[] path)
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x9BE3BC", Offset = "0x9BE3BC", VA = "0x9BE3BC")]
	public static void DrawPathHandles(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x9BE510", Offset = "0x9BE510", VA = "0x9BE510")]
	public static void Resume(GameObject target)
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x9BE600", Offset = "0x9BE600", VA = "0x9BE600")]
	public static void Resume(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x9BE8AC", Offset = "0x9BE8AC", VA = "0x9BE8AC")]
	public static void Resume(GameObject target, string type)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x9BEA04", Offset = "0x9BEA04", VA = "0x9BEA04")]
	public static void Resume(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x9BEDA0", Offset = "0x9BEDA0", VA = "0x9BEDA0")]
	public static void Resume()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x9BEEC0", Offset = "0x9BEEC0", VA = "0x9BEEC0")]
	public static void Resume(string type)
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x9BF0F0", Offset = "0x9BF0F0", VA = "0x9BF0F0")]
	public static void Pause(GameObject target)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x9BF23C", Offset = "0x9BF23C", VA = "0x9BF23C")]
	public static void Pause(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x9BF4E8", Offset = "0x9BF4E8", VA = "0x9BF4E8")]
	public static void Pause(GameObject target, string type)
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x9BF694", Offset = "0x9BF694", VA = "0x9BF694")]
	public static void Pause(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x9BFA84", Offset = "0x9BFA84", VA = "0x9BFA84")]
	public static void Pause()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x9BFBA4", Offset = "0x9BFBA4", VA = "0x9BFBA4")]
	public static void Pause(string type)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x9BFDD4", Offset = "0x9BFDD4", VA = "0x9BFDD4")]
	public static int Count()
	{
		return default(int);
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x9BFE48", Offset = "0x9BFE48", VA = "0x9BFE48")]
	public static int Count(string type)
	{
		return default(int);
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x9C0024", Offset = "0x9C0024", VA = "0x9C0024")]
	public static int Count(GameObject target)
	{
		return default(int);
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x9C0088", Offset = "0x9C0088", VA = "0x9C0088")]
	public static int Count(GameObject target, string type)
	{
		return default(int);
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x9C01E4", Offset = "0x9C01E4", VA = "0x9C01E4")]
	public static void Stop()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x9C041C", Offset = "0x9C041C", VA = "0x9C041C")]
	public static void Stop(string type)
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x9C079C", Offset = "0x9C079C", VA = "0x9C079C")]
	public static void StopByName(string name)
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x9C0334", Offset = "0x9C0334", VA = "0x9C0334")]
	public static void Stop(GameObject target)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x9C0ADC", Offset = "0x9C0ADC", VA = "0x9C0ADC")]
	public static void Stop(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x9C064C", Offset = "0x9C064C", VA = "0x9C064C")]
	public static void Stop(GameObject target, string type)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x9C09CC", Offset = "0x9C09CC", VA = "0x9C09CC")]
	public static void StopByName(GameObject target, string name)
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x9C0D88", Offset = "0x9C0D88", VA = "0x9C0D88")]
	public static void Stop(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x9C111C", Offset = "0x9C111C", VA = "0x9C111C")]
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x9A5298", Offset = "0x9A5298", VA = "0x9A5298")]
	public static Hashtable Hash(params object[] args)
	{
		return null;
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x9C1470", Offset = "0x9C1470", VA = "0x9C1470")]
	private iTween(Hashtable h)
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x9C149C", Offset = "0x9C149C", VA = "0x9C149C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x9C2508", Offset = "0x9C2508", VA = "0x9C2508")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6ED3B8", Offset = "0x6ED3B8")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x9C2578", Offset = "0x9C2578", VA = "0x9C2578")]
	private void Update()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x9C25B8", Offset = "0x9C25B8", VA = "0x9C25B8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x9C25F8", Offset = "0x9C25F8", VA = "0x9C25F8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x9C270C", Offset = "0x9C270C", VA = "0x9C270C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x9C2788", Offset = "0x9C2788", VA = "0x9C2788")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x9BC768", Offset = "0x9BC768", VA = "0x9BC768")]
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x9BD6B0", Offset = "0x9BD6B0", VA = "0x9BD6B0")]
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x9BBAE8", Offset = "0x9BBAE8", VA = "0x9BBAE8")]
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x9BBDAC", Offset = "0x9BBDAC", VA = "0x9BBDAC")]
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x9A4F94", Offset = "0x9A4F94", VA = "0x9A4F94")]
	private static void Launch(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x9A45F4", Offset = "0x9A45F4", VA = "0x9A45F4")]
	private static Hashtable CleanArgs(Hashtable args)
	{
		return null;
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x9C278C", Offset = "0x9C278C", VA = "0x9C278C")]
	private static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x9C14D8", Offset = "0x9C14D8", VA = "0x9C14D8")]
	private void RetrieveArgs()
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x9C280C", Offset = "0x9C280C", VA = "0x9C280C")]
	private void GetEasingFunction()
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x9B79BC", Offset = "0x9B79BC", VA = "0x9B79BC")]
	private void UpdatePercentage()
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x9B70C4", Offset = "0x9B70C4", VA = "0x9B70C4")]
	private void CallBack(string callbackType)
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x9B3560", Offset = "0x9B3560", VA = "0x9B3560")]
	private void Dispose()
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x9B739C", Offset = "0x9B739C", VA = "0x9B739C")]
	private void ConflictCheck()
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x9B78DC", Offset = "0x9B78DC", VA = "0x9B78DC")]
	private void EnableKinematic()
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x9B7BA4", Offset = "0x9B7BA4", VA = "0x9B7BA4")]
	private void DisableKinematic()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x9C2734", Offset = "0x9C2734", VA = "0x9C2734")]
	private void ResumeDelay()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x9C2C00", Offset = "0x9C2C00", VA = "0x9C2C00")]
	private float linear(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x9B36FC", Offset = "0x9B36FC", VA = "0x9B36FC")]
	private float clerp(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x9C2C88", Offset = "0x9C2C88", VA = "0x9C2C88")]
	private float spring(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x9C2D8C", Offset = "0x9C2D8C", VA = "0x9C2D8C")]
	private float easeInQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x9C2DA0", Offset = "0x9C2DA0", VA = "0x9C2DA0")]
	private float easeOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x9C2DBC", Offset = "0x9C2DBC", VA = "0x9C2DBC")]
	private float easeInOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x9C2E10", Offset = "0x9C2E10", VA = "0x9C2E10")]
	private float easeInCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x9C2E28", Offset = "0x9C2E28", VA = "0x9C2E28")]
	private float easeOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x9C2E50", Offset = "0x9C2E50", VA = "0x9C2E50")]
	private float easeInOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x9C2EA8", Offset = "0x9C2EA8", VA = "0x9C2EA8")]
	private float easeInQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x9C2EC4", Offset = "0x9C2EC4", VA = "0x9C2EC4")]
	private float easeOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x9C2EEC", Offset = "0x9C2EEC", VA = "0x9C2EEC")]
	private float easeInOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x9C2F48", Offset = "0x9C2F48", VA = "0x9C2F48")]
	private float easeInQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x9C2F68", Offset = "0x9C2F68", VA = "0x9C2F68")]
	private float easeOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x9C2F98", Offset = "0x9C2F98", VA = "0x9C2F98")]
	private float easeInOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x9C3000", Offset = "0x9C3000", VA = "0x9C3000")]
	private float easeInSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x9C3098", Offset = "0x9C3098", VA = "0x9C3098")]
	private float easeOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x9C312C", Offset = "0x9C312C", VA = "0x9C312C")]
	private float easeInOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x9C31D0", Offset = "0x9C31D0", VA = "0x9C31D0")]
	private float easeInExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x9C3268", Offset = "0x9C3268", VA = "0x9C3268")]
	private float easeOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x9C3300", Offset = "0x9C3300", VA = "0x9C3300")]
	private float easeInOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x9C33F0", Offset = "0x9C33F0", VA = "0x9C33F0")]
	private float easeInCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x9C349C", Offset = "0x9C349C", VA = "0x9C349C")]
	private float easeOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x9C3548", Offset = "0x9C3548", VA = "0x9C3548")]
	private float easeInOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x9C3640", Offset = "0x9C3640", VA = "0x9C3640")]
	private float easeInBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x9C367C", Offset = "0x9C367C", VA = "0x9C367C")]
	private float easeOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x9C3748", Offset = "0x9C3748", VA = "0x9C3748")]
	private float easeInOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x9C37CC", Offset = "0x9C37CC", VA = "0x9C37CC")]
	private float easeInBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x9C37FC", Offset = "0x9C37FC", VA = "0x9C37FC")]
	private float easeOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x9C383C", Offset = "0x9C383C", VA = "0x9C383C")]
	private float easeInOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x9B6874", Offset = "0x9B6874", VA = "0x9B6874")]
	private float punch(float amplitude, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x9C38C0", Offset = "0x9C38C0", VA = "0x9C38C0")]
	private float easeInElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x9C39A8", Offset = "0x9C39A8", VA = "0x9C39A8")]
	private float easeOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x9C3A8C", Offset = "0x9C3A8C", VA = "0x9C3A8C")]
	private float easeInOutElastic(float start, float end, float value)
	{
		return default(float);
	}
}
[Token(Token = "0x200004C")]
public class MoveSample : MonoBehaviour
{
	[Token(Token = "0x60002D7")]
	[Address(RVA = "0xEDFF4C", Offset = "0xEDFF4C", VA = "0xEDFF4C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0xEE01F0", Offset = "0xEE01F0", VA = "0xEE01F0")]
	public MoveSample()
	{
	}
}
[Token(Token = "0x200004D")]
public class RotateSample : MonoBehaviour
{
	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xEE1660", Offset = "0xEE1660", VA = "0xEE1660")]
	private void Start()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0xEE18FC", Offset = "0xEE18FC", VA = "0xEE18FC")]
	public RotateSample()
	{
	}
}
[Token(Token = "0x200004E")]
public class SampleInfo : MonoBehaviour
{
	[Token(Token = "0x60002DB")]
	[Address(RVA = "0xEE20F8", Offset = "0xEE20F8", VA = "0xEE20F8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0xEE23AC", Offset = "0xEE23AC", VA = "0xEE23AC")]
	public SampleInfo()
	{
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x200004F")]
	public enum AAMode
	{
		[Token(Token = "0x400013A")]
		FXAA2,
		[Token(Token = "0x400013B")]
		FXAA3Console,
		[Token(Token = "0x400013C")]
		FXAA1PresetA,
		[Token(Token = "0x400013D")]
		FXAA1PresetB,
		[Token(Token = "0x400013E")]
		NFAA,
		[Token(Token = "0x400013F")]
		SSAA,
		[Token(Token = "0x4000140")]
		DLAA
	}
	[Token(Token = "0x2000050")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EA9D0", Offset = "0x6EA9D0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EA9D0", Offset = "0x6EA9D0")]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AAMode mode;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool showGeneratedNormals;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float offsetScale;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float blurRadius;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float edgeThresholdMin;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float edgeThreshold;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float edgeSharpness;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool dlaaSharp;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader ssaaShader;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material ssaa;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader dlaaShader;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material dlaa;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Shader nfaaShader;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material nfaa;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Shader shaderFXAAII;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Material materialFXAAII;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Material materialFXAAIII;

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xEE9864", Offset = "0xEE9864", VA = "0xEE9864")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xEE98C8", Offset = "0xEE98C8", VA = "0xEE98C8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xEE99B4", Offset = "0xEE99B4", VA = "0xEE99B4")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xEE9EFC", Offset = "0xEE9EFC", VA = "0xEE9EFC")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EAA68", Offset = "0x6EAA68")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EAA68", Offset = "0x6EAA68")]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x2000094")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x4000375")]
			Ghosting,
			[Token(Token = "0x4000376")]
			Anamorphic,
			[Token(Token = "0x4000377")]
			Combined
		}

		[Token(Token = "0x2000095")]
		public enum TweakMode
		{
			[Token(Token = "0x4000379")]
			Basic,
			[Token(Token = "0x400037A")]
			Complex
		}

		[Token(Token = "0x2000096")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x400037C")]
			Auto,
			[Token(Token = "0x400037D")]
			On,
			[Token(Token = "0x400037E")]
			Off
		}

		[Token(Token = "0x2000097")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x4000380")]
			Screen,
			[Token(Token = "0x4000381")]
			Add
		}

		[Token(Token = "0x2000098")]
		public enum BloomQuality
		{
			[Token(Token = "0x4000383")]
			Cheap,
			[Token(Token = "0x4000384")]
			High
		}

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public TweakMode tweakMode;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public HDRBloomMode hdr;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool doHdr;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sepBlurSpread;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BloomQuality quality;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float bloomIntensity;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float bloomThreshold;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color bloomThresholdColor;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int bloomBlurIterations;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float flareRotation;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float hollyStretchWidth;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float lensflareIntensity;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float lensflareThreshold;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float lensFlareSaturation;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Color flareColorA;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Color flareColorB;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public Color flareColorC;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Color flareColorD;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Shader lensFlareShader;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Material lensFlareMaterial;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader screenBlendShader;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Material screenBlend;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x98BB1C", Offset = "0x98BB1C", VA = "0x98BB1C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x98C0F4", Offset = "0x98C0F4", VA = "0x98C0F4")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x98D4B0", Offset = "0x98D4B0", VA = "0x98D4B0")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x98D2B0", Offset = "0x98D2B0", VA = "0x98D2B0")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x98CFB8", Offset = "0x98CFB8", VA = "0x98CFB8")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x98CED4", Offset = "0x98CED4", VA = "0x98CED4")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x98D0A4", Offset = "0x98D0A4", VA = "0x98D0A4")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x98D578", Offset = "0x98D578", VA = "0x98D578")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public enum LensflareStyle34
	{
		[Token(Token = "0x4000176")]
		Ghosting,
		[Token(Token = "0x4000177")]
		Anamorphic,
		[Token(Token = "0x4000178")]
		Combined
	}
	[Token(Token = "0x2000053")]
	public enum TweakMode34
	{
		[Token(Token = "0x400017A")]
		Basic,
		[Token(Token = "0x400017B")]
		Complex
	}
	[Token(Token = "0x2000054")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x400017D")]
		Auto,
		[Token(Token = "0x400017E")]
		On,
		[Token(Token = "0x400017F")]
		Off
	}
	[Token(Token = "0x2000055")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x4000181")]
		Screen,
		[Token(Token = "0x4000182")]
		Add
	}
	[Token(Token = "0x2000056")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EAB00", Offset = "0x6EAB00")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EAB00", Offset = "0x6EAB00")]
	public class BloomAndFlares : PostEffectsBase
	{
		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public TweakMode34 tweakMode;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public HDRBloomMode hdr;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool doHdr;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sepBlurSpread;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float useSrcAlphaAsMask;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float bloomIntensity;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float bloomThreshold;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int bloomBlurIterations;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool lensflares;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public LensflareStyle34 lensflareMode;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float hollyStretchWidth;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float lensflareIntensity;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float lensflareThreshold;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Color flareColorA;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Color flareColorB;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color flareColorC;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color flareColorD;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Shader lensFlareShader;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Shader vignetteShader;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Material vignetteMaterial;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader separableBlurShader;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material separableBlurMaterial;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader addBrightStuffOneOneShader;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader screenBlendShader;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material screenBlend;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader hollywoodFlaresShader;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material hollywoodFlaresMaterial;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x98D6D4", Offset = "0x98D6D4", VA = "0x98D6D4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x98D78C", Offset = "0x98D78C", VA = "0x98D78C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x98E6D8", Offset = "0x98E6D8", VA = "0x98E6D8")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x98E4E8", Offset = "0x98E4E8", VA = "0x98E4E8")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x98E26C", Offset = "0x98E26C", VA = "0x98E26C")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x98E394", Offset = "0x98E394", VA = "0x98E394")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x98E78C", Offset = "0x98E78C", VA = "0x98E78C")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EAB98", Offset = "0x6EAB98")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EAB98", Offset = "0x6EAB98")]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000099")]
		public enum Resolution
		{
			[Token(Token = "0x4000386")]
			Low,
			[Token(Token = "0x4000387")]
			High
		}

		[Token(Token = "0x200009A")]
		public enum BlurType
		{
			[Token(Token = "0x4000389")]
			Standard,
			[Token(Token = "0x400038A")]
			Sgx
		}

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EBFC4", Offset = "0x6EBFC4")]
		public float threshold;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EBFDC", Offset = "0x6EBFDC")]
		public float intensity;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EBFF4", Offset = "0x6EBFF4")]
		public float blurSize;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Resolution resolution;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC00C", Offset = "0x6EC00C")]
		public int blurIterations;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BlurType blurType;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader fastBloomShader;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material fastBloomMaterial;

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x98E8C8", Offset = "0x98E8C8", VA = "0x98E8C8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x98E920", Offset = "0x98E920", VA = "0x98E920")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x98E9D0", Offset = "0x98E9D0", VA = "0x98E9D0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x98ED9C", Offset = "0x98ED9C", VA = "0x98ED9C")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EAC30", Offset = "0x6EAC30")]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC024", Offset = "0x6EC024")]
		public int iterations;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC03C", Offset = "0x6EC03C")]
		public float blurSpread;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x17000037")]
		protected Material material
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x98EDC8", Offset = "0x98EDC8", VA = "0x98EDC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x98EF00", Offset = "0x98EF00", VA = "0x98EF00")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x98EFFC", Offset = "0x98EFFC", VA = "0x98EFFC")]
		protected void Start()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x98F0BC", Offset = "0x98F0BC", VA = "0x98F0BC")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x98F260", Offset = "0x98F260", VA = "0x98F260")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x98F3D8", Offset = "0x98F3D8", VA = "0x98F3D8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x98F544", Offset = "0x98F544", VA = "0x98F544")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EAC7C", Offset = "0x6EAC7C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EAC7C", Offset = "0x6EAC7C")]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x200009B")]
		public enum BlurType
		{
			[Token(Token = "0x400038C")]
			StandardGauss,
			[Token(Token = "0x400038D")]
			SgxGauss
		}

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC054", Offset = "0x6EC054")]
		public int downsample;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC06C", Offset = "0x6EC06C")]
		public float blurSize;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC084", Offset = "0x6EC084")]
		public int blurIterations;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BlurType blurType;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader blurShader;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material blurMaterial;

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x98F560", Offset = "0x98F560", VA = "0x98F560", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x98F5B8", Offset = "0x98F5B8", VA = "0x98F5B8")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x98F668", Offset = "0x98F668", VA = "0x98F668")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x98FA0C", Offset = "0x98FA0C", VA = "0x98FA0C")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EAD14", Offset = "0x6EAD14")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EAD14", Offset = "0x6EAD14")]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x200009C")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x400038F")]
			CameraMotion,
			[Token(Token = "0x4000390")]
			LocalBlur,
			[Token(Token = "0x4000391")]
			Reconstruction,
			[Token(Token = "0x4000392")]
			ReconstructionDX11,
			[Token(Token = "0x4000393")]
			ReconstructionDisc
		}

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool preview;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 previewScale;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float movementScale;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rotationScale;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxVelocity;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float minVelocity;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float velocityScale;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float softZDistance;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int velocityDownsample;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public LayerMask excludeLayers;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject tmpCam;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader shader;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader replacementClear;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material motionBlurMaterial;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Texture2D noiseTexture;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float jitter;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool showVelocity;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float showVelocityScale;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private int prevFrameCount;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool wasActive;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 prevFramePos;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Camera _camera;

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x98FA34", Offset = "0x98FA34", VA = "0x98FA34")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x98FB80", Offset = "0x98FB80", VA = "0x98FB80")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x98FD04", Offset = "0x98FD04", VA = "0x98FD04")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x98FDC4", Offset = "0x98FDC4", VA = "0x98FDC4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x98FF28", Offset = "0x98FF28", VA = "0x98FF28", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x99000C", Offset = "0x99000C", VA = "0x99000C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x98FC58", Offset = "0x98FC58", VA = "0x98FC58")]
		private void Remember()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x991694", Offset = "0x991694", VA = "0x991694")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x9915A8", Offset = "0x9915A8", VA = "0x9915A8")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x991684", Offset = "0x991684", VA = "0x991684")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x9919D0", Offset = "0x9919D0", VA = "0x9919D0")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EADAC", Offset = "0x6EADAC")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x200009D")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x4000395")]
			Simple,
			[Token(Token = "0x4000396")]
			Advanced
		}

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve redChannel;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useDepthCorrection;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve zCurve;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material ccMaterial;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material ccDepthMaterial;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Texture2D zCurveTex;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float saturation;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public bool selectiveCc;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Color selectiveFromColor;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Color selectiveToColor;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool updateTextures;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x991B2C", Offset = "0x991B2C", VA = "0x991B2C")]
		private new void Start()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x991B68", Offset = "0x991B68", VA = "0x991B68")]
		private void Awake()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x991B6C", Offset = "0x991B6C", VA = "0x991B6C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x991DCC", Offset = "0x991DCC", VA = "0x991DCC")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x9921DC", Offset = "0x9921DC", VA = "0x9921DC")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x9921E0", Offset = "0x9921E0", VA = "0x9921E0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x9924DC", Offset = "0x9924DC", VA = "0x9924DC")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EADF8", Offset = "0x6EADF8")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader shader;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material material;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture3D converted3DLut;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string basedOnTempTex;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PostProcessingOrderHook _hook;

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x992B18", Offset = "0x992B18", VA = "0x992B18", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x992B6C", Offset = "0x992B6C", VA = "0x992B6C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x992C14", Offset = "0x992C14", VA = "0x992C14")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x992CBC", Offset = "0x992CBC", VA = "0x992CBC")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x992D40", Offset = "0x992D40", VA = "0x992D40")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x992F3C", Offset = "0x992F3C", VA = "0x992F3C")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x993030", Offset = "0x993030", VA = "0x993030")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x99333C", Offset = "0x99333C", VA = "0x99333C")]
		private void OnPreRender()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x993358", Offset = "0x993358", VA = "0x993358")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x993374", Offset = "0x993374", VA = "0x993374")]
		private void InternalRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x993560", Offset = "0x993560", VA = "0x993560")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EAE44", Offset = "0x6EAE44")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x9935C4", Offset = "0x9935C4", VA = "0x9935C4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x993740", Offset = "0x993740", VA = "0x993740")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EAE90", Offset = "0x6EAE90")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EAE90", Offset = "0x6EAE90")]
	public class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC09C", Offset = "0x6EC09C")]
		public float intensity;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC0B4", Offset = "0x6EC0B4")]
		public float threshold;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material separableBlurMaterial;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC0D0", Offset = "0x6EC0D0")]
		public float blurSpread;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader separableBlurShader;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x993750", Offset = "0x993750", VA = "0x993750", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x9937C0", Offset = "0x9937C0", VA = "0x9937C0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x993B28", Offset = "0x993B28", VA = "0x993B28")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EAF28", Offset = "0x6EAF28")]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC0E8", Offset = "0x6EC0E8")]
		public float adaptationSpeed;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC104", Offset = "0x6EC104")]
		public float limitMinimum;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC11C", Offset = "0x6EC11C")]
		public float limitMaximum;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		[Token(Token = "0x17000038")]
		protected Material materialLum
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x993B4C", Offset = "0x993B4C", VA = "0x993B4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		protected Material materialReduce
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x993C10", Offset = "0x993C10", VA = "0x993C10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		protected Material materialAdapt
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x993CD4", Offset = "0x993CD4", VA = "0x993CD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		protected Material materialApply
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x993D98", Offset = "0x993D98", VA = "0x993D98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x993E5C", Offset = "0x993E5C", VA = "0x993E5C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x993EF0", Offset = "0x993EF0", VA = "0x993EF0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x994040", Offset = "0x994040", VA = "0x994040")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x994268", Offset = "0x994268", VA = "0x994268")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x9944C4", Offset = "0x9944C4", VA = "0x9944C4")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x9946D4", Offset = "0x9946D4", VA = "0x9946D4")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EAF74", Offset = "0x6EAF74")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EAF74", Offset = "0x6EAF74")]
	public class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float intensity;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int softness;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float spread;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader blurShader;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material blurMaterial;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader depthFetchShader;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material depthFetchMaterial;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader creaseApplyShader;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x99474C", Offset = "0x99474C", VA = "0x99474C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x9947C4", Offset = "0x9947C4", VA = "0x9947C4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x994B6C", Offset = "0x994B6C", VA = "0x994B6C")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EB00C", Offset = "0x6EB00C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EB00C", Offset = "0x6EB00C")]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x200009E")]
		public enum BlurType
		{
			[Token(Token = "0x4000398")]
			DiscBlur,
			[Token(Token = "0x4000399")]
			DX11
		}

		[Token(Token = "0x200009F")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x400039B")]
			Low,
			[Token(Token = "0x400039C")]
			Medium,
			[Token(Token = "0x400039D")]
			High
		}

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool visualizeFocus;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float focalLength;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float focalSize;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float aperture;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform focalTransform;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxBlurSize;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool highResolution;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BlurType blurType;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool nearBlur;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float foregroundOverlap;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader dofHdrShader;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material dofHdrMaterial;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dx11BokehShader;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float dx11BokehThreshold;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float dx11BokehScale;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float focalDistance01;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float internalBlurWidth;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Camera cachedCamera;

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x994B94", Offset = "0x994B94", VA = "0x994B94", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x994D34", Offset = "0x994D34", VA = "0x994D34")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x994DAC", Offset = "0x994DAC", VA = "0x994DAC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x994EB4", Offset = "0x994EB4", VA = "0x994EB4")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x994C18", Offset = "0x994C18", VA = "0x994C18")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x994EF8", Offset = "0x994EF8", VA = "0x994EF8")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x995054", Offset = "0x995054", VA = "0x995054")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x995374", Offset = "0x995374", VA = "0x995374")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x9969CC", Offset = "0x9969CC", VA = "0x9969CC")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EB0A4", Offset = "0x6EB0A4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EB0A4", Offset = "0x6EB0A4")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x20000A0")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x400039F")]
			OnlyBackground = 1,
			[Token(Token = "0x40003A0")]
			BackgroundAndForeground
		}

		[Token(Token = "0x20000A1")]
		public enum DofResolution
		{
			[Token(Token = "0x40003A2")]
			High = 2,
			[Token(Token = "0x40003A3")]
			Medium,
			[Token(Token = "0x40003A4")]
			Low
		}

		[Token(Token = "0x20000A2")]
		public enum DofBlurriness
		{
			[Token(Token = "0x40003A6")]
			Low = 1,
			[Token(Token = "0x40003A7")]
			High = 2,
			[Token(Token = "0x40003A8")]
			VeryHigh = 4
		}

		[Token(Token = "0x20000A3")]
		public enum BokehDestination
		{
			[Token(Token = "0x40003AA")]
			Background = 1,
			[Token(Token = "0x40003AB")]
			Foreground,
			[Token(Token = "0x40003AC")]
			BackgroundAndForeground
		}

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DofResolution resolution;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool simpleTweakMode;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float focalPoint;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float smoothness;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float focalZDistance;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float focalZStartCurve;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float focalZEndCurve;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float focalStartCurve;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float focalEndCurve;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float focalDistance01;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform objectFocus;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float focalSize;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public DofBlurriness bluriness;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxBlurSpread;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Shader dofBlurShader;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material dofBlurMaterial;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dofShader;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material dofMaterial;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool visualize;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float widthOverHeight;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float oneOverBaseSize;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool bokeh;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool bokehSupport;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Shader bokehShader;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Texture2D bokehTexture;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float bokehScale;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float bokehIntensity;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float bokehThresholdContrast;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public int bokehDownsample;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Material bokehMaterial;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Camera _camera;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderTexture bokehSource;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x996A30", Offset = "0x996A30", VA = "0x996A30")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x996B04", Offset = "0x996B04", VA = "0x996B04", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x996C08", Offset = "0x996C08", VA = "0x996C08")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x996E34", Offset = "0x996E34", VA = "0x996E34")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x996EAC", Offset = "0x996EAC", VA = "0x996EAC")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x997008", Offset = "0x997008", VA = "0x997008")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x99702C", Offset = "0x99702C", VA = "0x99702C")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x997050", Offset = "0x997050", VA = "0x997050")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x997E34", Offset = "0x997E34", VA = "0x997E34")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x9984E8", Offset = "0x9984E8", VA = "0x9984E8")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x998950", Offset = "0x998950", VA = "0x998950")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x997CE8", Offset = "0x997CE8", VA = "0x997CE8")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x9980D0", Offset = "0x9980D0", VA = "0x9980D0")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x9987A4", Offset = "0x9987A4", VA = "0x9987A4")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x9979B4", Offset = "0x9979B4", VA = "0x9979B4")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x998E38", Offset = "0x998E38", VA = "0x998E38")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EB13C", Offset = "0x6EB13C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EB13C", Offset = "0x6EB13C")]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x20000A4")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x40003AE")]
			TriangleDepthNormals,
			[Token(Token = "0x40003AF")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x40003B0")]
			SobelDepth,
			[Token(Token = "0x40003B1")]
			SobelDepthThin,
			[Token(Token = "0x40003B2")]
			TriangleLuminance
		}

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public EdgeDetectMode mode;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sensitivityDepth;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float sensitivityNormals;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float lumThreshold;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float edgeExp;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float sampleDist;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float edgesOnly;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader edgeDetectShader;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x998F1C", Offset = "0x998F1C", VA = "0x998F1C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x999054", Offset = "0x999054", VA = "0x999054")]
		private new void Start()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x998F94", Offset = "0x998F94", VA = "0x998F94")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x999060", Offset = "0x999060", VA = "0x999060")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x999064", Offset = "0x999064", VA = "0x999064")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x999250", Offset = "0x999250", VA = "0x999250")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EB1D4", Offset = "0x6EB1D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EB1D4", Offset = "0x6EB1D4")]
	public class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC134", Offset = "0x6EC134")]
		public float strengthX;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC14C", Offset = "0x6EC14C")]
		public float strengthY;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader fishEyeShader;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material fisheyeMaterial;

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x9992B0", Offset = "0x9992B0", VA = "0x9992B0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x999308", Offset = "0x999308", VA = "0x999308")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x999478", Offset = "0x999478", VA = "0x999478")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EB26C", Offset = "0x6EB26C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EB26C", Offset = "0x6EB26C")]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC164", Offset = "0x6EC164")]
		public bool distanceFog;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC19C", Offset = "0x6EC19C")]
		public bool excludeFarPixels;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC1D4", Offset = "0x6EC1D4")]
		public bool useRadialDistance;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC20C", Offset = "0x6EC20C")]
		public bool heightFog;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC244", Offset = "0x6EC244")]
		public float height;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC27C", Offset = "0x6EC27C")]
		public float heightDensity;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC298", Offset = "0x6EC298")]
		public float startDistance;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader fogShader;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material fogMaterial;

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x99949C", Offset = "0x99949C", VA = "0x99949C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x9994F4", Offset = "0x9994F4", VA = "0x9994F4")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x999D1C", Offset = "0x999D1C", VA = "0x999D1C")]
		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x999E8C", Offset = "0x999E8C", VA = "0x999E8C")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EB304", Offset = "0x6EB304")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC2D0", Offset = "0x6EC2D0")]
		public float rampOffset;

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x999EB8", Offset = "0x999EB8", VA = "0x999EB8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x999F94", Offset = "0x999F94", VA = "0x999F94")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EB350", Offset = "0x6EB350")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EB350", Offset = "0x6EB350")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x1700003C")]
		protected Material material
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x99367C", Offset = "0x99367C", VA = "0x99367C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x999F9C", Offset = "0x999F9C", VA = "0x999F9C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x99A04C", Offset = "0x99A04C", VA = "0x99A04C", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x993748", Offset = "0x993748", VA = "0x993748")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EB3D8", Offset = "0x6EB3D8")]
	public class ImageEffects
	{
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x99A0FC", Offset = "0x99A0FC", VA = "0x99A0FC")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x99A378", Offset = "0x99A378", VA = "0x99A378")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6ED43C", Offset = "0x6ED43C")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x99A3F0", Offset = "0x99A3F0", VA = "0x99A3F0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6ED474", Offset = "0x6ED474")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x99A470", Offset = "0x99A470", VA = "0x99A470")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EB410", Offset = "0x6EB410")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EB410", Offset = "0x6EB410")]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC2E8", Offset = "0x6EC2E8")]
		public float blurAmount;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x99A478", Offset = "0x99A478", VA = "0x99A478", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x99A4BC", Offset = "0x99A4BC", VA = "0x99A4BC", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x99A530", Offset = "0x99A530", VA = "0x99A530")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x99A8B4", Offset = "0x99A8B4", VA = "0x99A8B4")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x200006A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EB4A8", Offset = "0x6EB4A8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EB4A8", Offset = "0x6EB4A8")]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float intensityMultiplier;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float generalIntensity;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float blackIntensity;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float whiteIntensity;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float midGrey;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool dx11Grain;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float softness;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool monochrome;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 intensities;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 tiling;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float monochromeTiling;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public FilterMode filterMode;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture2D noiseTexture;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader noiseShader;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material noiseMaterial;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x99A8C8", Offset = "0x99A8C8", VA = "0x99A8C8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x99A940", Offset = "0x99A940", VA = "0x99A940")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x99B2A8", Offset = "0x99B2A8", VA = "0x99B2A8")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x99B624", Offset = "0x99B624", VA = "0x99B624")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x200006B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EB540", Offset = "0x6EB540")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EB540", Offset = "0x6EB540")]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC304", Offset = "0x6EC304")]
		public float grainIntensityMin;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC31C", Offset = "0x6EC31C")]
		public float grainIntensityMax;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC334", Offset = "0x6EC334")]
		public float grainSize;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC354", Offset = "0x6EC354")]
		public float scratchIntensityMin;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC36C", Offset = "0x6EC36C")]
		public float scratchIntensityMax;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC384", Offset = "0x6EC384")]
		public float scratchFPS;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC39C", Offset = "0x6EC39C")]
		public float scratchJitter;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float scratchY;

		[Token(Token = "0x1700003D")]
		protected Material material
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x99B87C", Offset = "0x99B87C", VA = "0x99B87C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x99B73C", Offset = "0x99B73C", VA = "0x99B73C")]
		protected void Start()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x99B9D8", Offset = "0x99B9D8", VA = "0x99B9D8")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x99BADC", Offset = "0x99BADC", VA = "0x99BADC")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x99BC18", Offset = "0x99BC18", VA = "0x99BC18")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x99BF60", Offset = "0x99BF60", VA = "0x99BF60")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x200006C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EB5D8", Offset = "0x6EB5D8")]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x98BCB8", Offset = "0x98BCB8", VA = "0x98BCB8")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x99BFC0", Offset = "0x99BFC0", VA = "0x99BFC0")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x99C1B0", Offset = "0x99C1B0", VA = "0x99C1B0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x99C1BC", Offset = "0x99C1BC", VA = "0x99C1BC")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x99C1C4", Offset = "0x99C1C4", VA = "0x99C1C4", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x991B5C", Offset = "0x991B5C", VA = "0x991B5C")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x98BBA4", Offset = "0x98BBA4", VA = "0x98BBA4")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x98FFB0", Offset = "0x98FFB0", VA = "0x98FFB0")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x99C274", Offset = "0x99C274", VA = "0x99C274")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x98C04C", Offset = "0x98C04C", VA = "0x98C04C")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x99C27C", Offset = "0x99C27C", VA = "0x99C27C")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x99BF94", Offset = "0x99BF94", VA = "0x99BF94")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x99C47C", Offset = "0x99C47C", VA = "0x99C47C")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x98D6C0", Offset = "0x98D6C0", VA = "0x98D6C0")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x200006D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EB64C", Offset = "0x6EB64C")]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x99C7F8", Offset = "0x99C7F8", VA = "0x99C7F8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x99C864", Offset = "0x99C864", VA = "0x99C864")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x99CAE0", Offset = "0x99CAE0", VA = "0x99CAE0")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x99CE58", Offset = "0x99CE58", VA = "0x99CE58")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x99D004", Offset = "0x99D004", VA = "0x99D004")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x200006E")]
	internal class Quads
	{
		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x99D00C", Offset = "0x99D00C", VA = "0x99D00C")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x996C64", Offset = "0x996C64", VA = "0x996C64")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x998B78", Offset = "0x998B78", VA = "0x998B78")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x99D130", Offset = "0x99D130", VA = "0x99D130")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x99D664", Offset = "0x99D664", VA = "0x99D664")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EB6C0", Offset = "0x6EB6C0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EB6C0", Offset = "0x6EB6C0")]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x20000A5")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x40003B4")]
			Additive,
			[Token(Token = "0x40003B5")]
			ScreenBlend,
			[Token(Token = "0x40003B6")]
			Multiply,
			[Token(Token = "0x40003B7")]
			Overlay,
			[Token(Token = "0x40003B8")]
			AlphaBlend
		}

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float intensity;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture2D texture;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader overlayShader;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material overlayMaterial;

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x99D670", Offset = "0x99D670", VA = "0x99D670", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x99D6C8", Offset = "0x99D6C8", VA = "0x99D6C8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x99D830", Offset = "0x99D830", VA = "0x99D830")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EB758", Offset = "0x6EB758")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EB758", Offset = "0x6EB758")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC3B4", Offset = "0x6EC3B4")]
		public float intensity;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC3CC", Offset = "0x6EC3CC")]
		public float radius;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC3E8", Offset = "0x6EC3E8")]
		public int blurIterations;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC400", Offset = "0x6EC400")]
		public float blurFilterDistance;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC418", Offset = "0x6EC418")]
		public int downsample;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D rand;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader aoShader;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material aoMaterial;

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x99D850", Offset = "0x99D850", VA = "0x99D850", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x99D8A8", Offset = "0x99D8A8", VA = "0x99D8A8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x99D950", Offset = "0x99D950", VA = "0x99D950")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x99DF24", Offset = "0x99DF24", VA = "0x99DF24")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EB7F0", Offset = "0x6EB7F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EB7F0", Offset = "0x6EB7F0")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x20000A6")]
		public enum SSAOSamples
		{
			[Token(Token = "0x40003BA")]
			Low,
			[Token(Token = "0x40003BB")]
			Medium,
			[Token(Token = "0x40003BC")]
			High
		}

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC430", Offset = "0x6EC430")]
		public float m_Radius;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC44C", Offset = "0x6EC44C")]
		public float m_OcclusionIntensity;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC464", Offset = "0x6EC464")]
		public int m_Blur;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC47C", Offset = "0x6EC47C")]
		public int m_Downsampling;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC494", Offset = "0x6EC494")]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC4B0", Offset = "0x6EC4B0")]
		public float m_MinZ;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x99DF50", Offset = "0x99DF50", VA = "0x99DF50")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x99E000", Offset = "0x99E000", VA = "0x99E000")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x99E09C", Offset = "0x99E09C", VA = "0x99E09C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x99E0A4", Offset = "0x99E0A4", VA = "0x99E0A4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x99E238", Offset = "0x99E238", VA = "0x99E238")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x99E17C", Offset = "0x99E17C", VA = "0x99E17C")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x99E2AC", Offset = "0x99E2AC", VA = "0x99E2AC")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x99E968", Offset = "0x99E968", VA = "0x99E968")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public enum SSRDebugMode
	{
		[Token(Token = "0x40002B5")]
		None,
		[Token(Token = "0x40002B6")]
		IncomingRadiance,
		[Token(Token = "0x40002B7")]
		SSRResult,
		[Token(Token = "0x40002B8")]
		FinalGlossyTerm,
		[Token(Token = "0x40002B9")]
		SSRMask,
		[Token(Token = "0x40002BA")]
		Roughness,
		[Token(Token = "0x40002BB")]
		BaseColor,
		[Token(Token = "0x40002BC")]
		SpecColor,
		[Token(Token = "0x40002BD")]
		Reflectivity,
		[Token(Token = "0x40002BE")]
		ReflectionProbeOnly,
		[Token(Token = "0x40002BF")]
		ReflectionProbeMinusSSR,
		[Token(Token = "0x40002C0")]
		SSRMinusReflectionProbe,
		[Token(Token = "0x40002C1")]
		NoGlossy,
		[Token(Token = "0x40002C2")]
		NegativeNoGlossy,
		[Token(Token = "0x40002C3")]
		MipLevel
	}
	[Token(Token = "0x2000073")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EB888", Offset = "0x6EB888")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EB888", Offset = "0x6EB888")]
	public class ScreenSpaceReflection : PostEffectsBase
	{
		[Token(Token = "0x20000A7")]
		private enum PassIndex
		{
			[Token(Token = "0x40003BE")]
			RayTraceStep1,
			[Token(Token = "0x40003BF")]
			RayTraceStep2,
			[Token(Token = "0x40003C0")]
			RayTraceStep4,
			[Token(Token = "0x40003C1")]
			RayTraceStep8,
			[Token(Token = "0x40003C2")]
			RayTraceStep16,
			[Token(Token = "0x40003C3")]
			CompositeFinal,
			[Token(Token = "0x40003C4")]
			Blur,
			[Token(Token = "0x40003C5")]
			CompositeSSR,
			[Token(Token = "0x40003C6")]
			Blit,
			[Token(Token = "0x40003C7")]
			EdgeGeneration,
			[Token(Token = "0x40003C8")]
			MinMipGeneration,
			[Token(Token = "0x40003C9")]
			HitPointToReflections,
			[Token(Token = "0x40003CA")]
			BilateralKeyPack
		}

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC4CC", Offset = "0x6EC4CC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC4CC", Offset = "0x6EC4CC")]
		public int maxSteps;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC524", Offset = "0x6EC524")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC524", Offset = "0x6EC524")]
		public int rayPixelsStep;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC578", Offset = "0x6EC578")]
		public bool halfResolution;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC5B0", Offset = "0x6EC5B0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC5B0", Offset = "0x6EC5B0")]
		public float maxDistance;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC608", Offset = "0x6EC608")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC608", Offset = "0x6EC608")]
		public float fadeDistance;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC660", Offset = "0x6EC660")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC660", Offset = "0x6EC660")]
		public float expectedWallThicknessMeters;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC6B8", Offset = "0x6EC6B8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC6B8", Offset = "0x6EC6B8")]
		public float screenEdgeFading;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC70C", Offset = "0x6EC70C")]
		public bool additiveReflection;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC744", Offset = "0x6EC744")]
		public bool improveCorners;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC77C", Offset = "0x6EC77C")]
		public bool reduceBanding;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC7B4", Offset = "0x6EC7B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC7B4", Offset = "0x6EC7B4")]
		public float reflectionMultiplier;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC808", Offset = "0x6EC808")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC808", Offset = "0x6EC808")]
		private float mipBias;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool useOcclusion;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		private bool fullResolutionFiltering;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		private bool fallbackToSky;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC85C", Offset = "0x6EC85C")]
		public bool treatBackfaceHitAsMiss;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC894", Offset = "0x6EC894")]
		public bool suppressBackwardsRays;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC8CC", Offset = "0x6EC8CC")]
		public SSRDebugMode m_DebugMode;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC904", Offset = "0x6EC904")]
		public bool enableSSR;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC93C", Offset = "0x6EC93C")]
		private bool useEdgeDetector;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC974", Offset = "0x6EC974")]
		public bool useHDRIntermediates;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6EC9AC", Offset = "0x6EC9AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6EC9AC", Offset = "0x6EC9AC")]
		public float minSmoothness;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECA00", Offset = "0x6ECA00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6ECA00", Offset = "0x6ECA00")]
		public float smoothnessFalloffRange;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECA58", Offset = "0x6ECA58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6ECA58", Offset = "0x6ECA58")]
		public float distanceBlur;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECAAC", Offset = "0x6ECAAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6ECAAC", Offset = "0x6ECAAC")]
		public float fresnelFade;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECB00", Offset = "0x6ECB00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6ECB00", Offset = "0x6ECB00")]
		public float fresnelFadePower;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECB58", Offset = "0x6ECB58")]
		public bool bilateralUpsample;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECB90", Offset = "0x6ECB90")]
		public bool fullResResolve;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6ECBC8", Offset = "0x6ECBC8")]
		public bool traceEverywhere;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader ssrShader;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material ssrMaterial;

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x99E99C", Offset = "0x99E99C", VA = "0x99E99C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x99E9F4", Offset = "0x99E9F4", VA = "0x99E9F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x99EA9C", Offset = "0x99EA9C", VA = "0x99EA9C")]
		[ImageEffectOpaque]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x99FF58", Offset = "0x99FF58", VA = "0x99FF58")]
		public ScreenSpaceReflection()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EB920", Offset = "0x6EB920")]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x99FFC4", Offset = "0x99FFC4", VA = "0x99FFC4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x9A0054", Offset = "0x9A0054", VA = "0x9A0054")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EB96C", Offset = "0x6EB96C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EB96C", Offset = "0x6EB96C")]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x20000A8")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x40003CC")]
			Low,
			[Token(Token = "0x40003CD")]
			Normal,
			[Token(Token = "0x40003CE")]
			High
		}

		[Token(Token = "0x20000A9")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x40003D0")]
			Screen,
			[Token(Token = "0x40003D1")]
			Add
		}

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SunShaftsResolution resolution;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform sunTransform;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int radialBlurIterations;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Color sunColor;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Color sunThreshold;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float sunShaftBlurRadius;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float sunShaftIntensity;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float maxRadius;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool useDepthTexture;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader sunShaftsShader;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material sunShaftsMaterial;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader simpleClearShader;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material simpleClearMaterial;

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x9A005C", Offset = "0x9A005C", VA = "0x9A005C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x9A00C4", Offset = "0x9A00C4", VA = "0x9A00C4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x9A08B0", Offset = "0x9A08B0", VA = "0x9A08B0")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EBA04", Offset = "0x6EBA04")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EBA04", Offset = "0x6EBA04")]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x20000AA")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x40003D3")]
			TiltShiftMode,
			[Token(Token = "0x40003D4")]
			IrisMode
		}

		[Token(Token = "0x20000AB")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x40003D6")]
			Preview,
			[Token(Token = "0x40003D7")]
			Normal,
			[Token(Token = "0x40003D8")]
			High
		}

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public TiltShiftMode mode;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TiltShiftQuality quality;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6ECC00", Offset = "0x6ECC00")]
		public float blurArea;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6ECC18", Offset = "0x6ECC18")]
		public float maxBlurSize;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6ECC30", Offset = "0x6ECC30")]
		public int downsample;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader tiltShiftShader;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x9A0950", Offset = "0x9A0950", VA = "0x9A0950", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x9A09A8", Offset = "0x9A09A8", VA = "0x9A09A8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x9A0C38", Offset = "0x9A0C38", VA = "0x9A0C38")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EBA8C", Offset = "0x6EBA8C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EBA8C", Offset = "0x6EBA8C")]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x20000AC")]
		public enum TonemapperType
		{
			[Token(Token = "0x40003DA")]
			SimpleReinhard,
			[Token(Token = "0x40003DB")]
			UserCurve,
			[Token(Token = "0x40003DC")]
			Hable,
			[Token(Token = "0x40003DD")]
			Photographic,
			[Token(Token = "0x40003DE")]
			OptimizedHejiDawson,
			[Token(Token = "0x40003DF")]
			AdaptiveReinhard,
			[Token(Token = "0x40003E0")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x20000AD")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x40003E2")]
			Square16 = 0x10,
			[Token(Token = "0x40003E3")]
			Square32 = 0x20,
			[Token(Token = "0x40003E4")]
			Square64 = 0x40,
			[Token(Token = "0x40003E5")]
			Square128 = 0x80,
			[Token(Token = "0x40003E6")]
			Square256 = 0x100,
			[Token(Token = "0x40003E7")]
			Square512 = 0x200,
			[Token(Token = "0x40003E8")]
			Square1024 = 0x400
		}

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public TonemapperType type;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Texture2D curveTex;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float exposureAdjustment;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float middleGrey;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float white;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float adaptionSpeed;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader tonemapper;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material tonemapMaterial;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RenderTexture rt;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x9A0C5C", Offset = "0x9A0C5C", VA = "0x9A0C5C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x9A0D98", Offset = "0x9A0D98", VA = "0x9A0D98")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x9A105C", Offset = "0x9A105C", VA = "0x9A105C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x9A11B4", Offset = "0x9A11B4", VA = "0x9A11B4")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x9A12A4", Offset = "0x9A12A4", VA = "0x9A12A4")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x9A1AC8", Offset = "0x9A1AC8", VA = "0x9A1AC8")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x2000078")]
	internal class Triangles
	{
		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x9A1B00", Offset = "0x9A1B00", VA = "0x9A1B00")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x9A1C3C", Offset = "0x9A1C3C", VA = "0x9A1C3C")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x9A1E0C", Offset = "0x9A1E0C", VA = "0x9A1E0C")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x9A20CC", Offset = "0x9A20CC", VA = "0x9A20CC")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x9A24FC", Offset = "0x9A24FC", VA = "0x9A24FC")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x2000079")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EBB24", Offset = "0x6EBB24")]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6ECC48", Offset = "0x6ECC48")]
		public float angle;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x9A2508", Offset = "0x9A2508", VA = "0x9A2508")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x9A254C", Offset = "0x9A254C", VA = "0x9A254C")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x200007A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6EBB70", Offset = "0x6EBB70")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EBB70", Offset = "0x6EBB70")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x20000AE")]
		public enum AberrationMode
		{
			[Token(Token = "0x40003EA")]
			Simple,
			[Token(Token = "0x40003EB")]
			Advanced
		}

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AberrationMode mode;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float intensity;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float chromaticAberration;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float axialAberration;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float blur;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float blurSpread;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float luminanceDependency;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float blurDistance;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader vignetteShader;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader chromAberrationShader;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x9A25C8", Offset = "0x9A25C8", VA = "0x9A25C8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x9A264C", Offset = "0x9A264C", VA = "0x9A264C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x9A2C78", Offset = "0x9A2C78", VA = "0x9A2C78")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x200007B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6EBC08", Offset = "0x6EBC08")]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x9A2CB4", Offset = "0x9A2CB4", VA = "0x9A2CB4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x9A2CF8", Offset = "0x9A2CF8", VA = "0x9A2CF8")]
		public Vortex()
		{
		}
	}
}
namespace SimpleJSON
{
	[Token(Token = "0x200007C")]
	public enum JSONBinaryTag
	{
		[Token(Token = "0x400031C")]
		Array = 1,
		[Token(Token = "0x400031D")]
		Class,
		[Token(Token = "0x400031E")]
		Value,
		[Token(Token = "0x400031F")]
		IntValue,
		[Token(Token = "0x4000320")]
		DoubleValue,
		[Token(Token = "0x4000321")]
		BoolValue,
		[Token(Token = "0x4000322")]
		FloatValue
	}
	[Token(Token = "0x200007D")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6EBC54", Offset = "0x6EBC54")]
	public class JSONNode
	{
		[Token(Token = "0x20000AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBD94", Offset = "0x6EBD94")]
		private sealed class <get_Childs>d__17 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x17000064")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000462")]
				[Address(RVA = "0xEE80F0", Offset = "0xEE80F0", VA = "0xEE80F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000464")]
				[Address(RVA = "0xEE8158", Offset = "0xEE8158", VA = "0xEE8158", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0xEE6E0C", Offset = "0xEE6E0C", VA = "0xEE6E0C")]
			[DebuggerHidden]
			public <get_Childs>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0xEE80D4", Offset = "0xEE80D4", VA = "0xEE80D4", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0xEE80D8", Offset = "0xEE80D8", VA = "0xEE80D8", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0xEE80F8", Offset = "0xEE80F8", VA = "0xEE80F8", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0xEE8160", Offset = "0xEE8160", VA = "0xEE8160", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0xEE81F8", Offset = "0xEE81F8", VA = "0xEE81F8", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBDA4", Offset = "0x6EBDA4")]
		private sealed class <get_DeepChilds>d__19 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONNode <>4__this;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;

			[Token(Token = "0x17000066")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x600046C")]
				[Address(RVA = "0xEE882C", Offset = "0xEE882C", VA = "0xEE882C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600046E")]
				[Address(RVA = "0xEE8894", Offset = "0xEE8894", VA = "0xEE8894", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0xEE6EC4", Offset = "0xEE6EC4", VA = "0xEE6EC4")]
			[DebuggerHidden]
			public <get_DeepChilds>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0xEE81FC", Offset = "0xEE81FC", VA = "0xEE81FC", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0xEE840C", Offset = "0xEE840C", VA = "0xEE840C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0xEE834C", Offset = "0xEE834C", VA = "0xEE834C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0xEE828C", Offset = "0xEE828C", VA = "0xEE828C")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x600046D")]
			[Address(RVA = "0xEE8834", Offset = "0xEE8834", VA = "0xEE8834", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600046F")]
			[Address(RVA = "0xEE889C", Offset = "0xEE889C", VA = "0xEE889C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000470")]
			[Address(RVA = "0xEE8948", Offset = "0xEE8948", VA = "0xEE8948", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0xEE6CB0", Offset = "0xEE6CB0", VA = "0xEE6CB0", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0xEE6CB8", Offset = "0xEE6CB8", VA = "0xEE6CB8", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0xEE6CBC", Offset = "0xEE6CBC", VA = "0xEE6CBC", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0xEE6CC4", Offset = "0xEE6CC4", VA = "0xEE6CC4", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public virtual string Value
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0xEE6CC8", Offset = "0xEE6CC8", VA = "0xEE6CC8", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0xEE6D10", Offset = "0xEE6D10", VA = "0xEE6D10", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public virtual int Count
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0xEE6D14", Offset = "0xEE6D14", VA = "0xEE6D14", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000042")]
		public virtual IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0xEE6D9C", Offset = "0xEE6D9C", VA = "0xEE6D9C", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6ED4EC", Offset = "0x6ED4EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IEnumerable<JSONNode> DeepChilds
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0xEE6E44", Offset = "0xEE6E44", VA = "0xEE6E44")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6ED550", Offset = "0x6ED550")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public virtual int AsInt
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0xEE6F8C", Offset = "0xEE6F8C", VA = "0xEE6F8C", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0xEE6FCC", Offset = "0xEE6FCC", VA = "0xEE6FCC", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public virtual float AsFloat
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0xEE700C", Offset = "0xEE700C", VA = "0xEE700C", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0xEE7050", Offset = "0xEE7050", VA = "0xEE7050", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public virtual double AsDouble
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0xEE7090", Offset = "0xEE7090", VA = "0xEE7090", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0xEE7134", Offset = "0xEE7134", VA = "0xEE7134", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public virtual bool AsBool
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0xEE7174", Offset = "0xEE7174", VA = "0xEE7174", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0xEE723C", Offset = "0xEE723C", VA = "0xEE723C", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0xEE72B8", Offset = "0xEE72B8", VA = "0xEE72B8", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public virtual JSONClass AsObject
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0xEE7338", Offset = "0xEE7338", VA = "0xEE7338", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xEE6CAC", Offset = "0xEE6CAC", VA = "0xEE6CAC", Slot = "4")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xEE6D1C", Offset = "0xEE6D1C", VA = "0xEE6D1C", Slot = "12")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xEE6D84", Offset = "0xEE6D84", VA = "0xEE6D84", Slot = "13")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xEE6D8C", Offset = "0xEE6D8C", VA = "0xEE6D8C", Slot = "14")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xEE6D94", Offset = "0xEE6D94", VA = "0xEE6D94", Slot = "15")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xEE6EFC", Offset = "0xEE6EFC", VA = "0xEE6EFC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xEE6F44", Offset = "0xEE6F44", VA = "0xEE6F44", Slot = "17")]
		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xEE73B8", Offset = "0xEE73B8", VA = "0xEE73B8")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xEE741C", Offset = "0xEE741C", VA = "0xEE741C")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xEE58C0", Offset = "0xEE58C0", VA = "0xEE58C0")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xEE7468", Offset = "0xEE7468", VA = "0xEE7468")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xEE7484", Offset = "0xEE7484", VA = "0xEE7484", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xEE6714", Offset = "0xEE6714", VA = "0xEE6714", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xEE50AC", Offset = "0xEE50AC", VA = "0xEE50AC")]
		public static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xEE2E78", Offset = "0xEE2E78", VA = "0xEE2E78")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xEE7490", Offset = "0xEE7490", VA = "0xEE7490", Slot = "28")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xEE7494", Offset = "0xEE7494", VA = "0xEE7494")]
		public void SaveToStream(Stream aData)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xEE7514", Offset = "0xEE7514", VA = "0xEE7514")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xEE7580", Offset = "0xEE7580", VA = "0xEE7580")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xEE75EC", Offset = "0xEE75EC", VA = "0xEE75EC")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xEE7658", Offset = "0xEE7658", VA = "0xEE7658")]
		public void SaveToFile(string aFileName)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xEE77AC", Offset = "0xEE77AC", VA = "0xEE77AC")]
		public string SaveToBase64()
		{
			return null;
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xEE7930", Offset = "0xEE7930", VA = "0xEE7930")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xEE7CB8", Offset = "0xEE7CB8", VA = "0xEE7CB8")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xEE7D24", Offset = "0xEE7D24", VA = "0xEE7D24")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xEE7D90", Offset = "0xEE7D90", VA = "0xEE7D90")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xEE7DFC", Offset = "0xEE7DFC", VA = "0xEE7DFC")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xEE7F18", Offset = "0xEE7F18", VA = "0xEE7F18")]
		public static JSONNode LoadFromFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xEE8020", Offset = "0xEE8020", VA = "0xEE8020")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xEE3F44", Offset = "0xEE3F44", VA = "0xEE3F44")]
		public JSONNode()
		{
		}
	}
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6EBC8C", Offset = "0x6EBC8C")]
	public class JSONArray : JSONNode, IEnumerable
	{
		[Token(Token = "0x20000B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBDB4", Offset = "0x6EBDB4")]
		private sealed class <get_Childs>d__13 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONArray <>4__this;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000068")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000475")]
				[Address(RVA = "0xEE434C", Offset = "0xEE434C", VA = "0xEE434C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000069")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000477")]
				[Address(RVA = "0xEE43B4", Offset = "0xEE43B4", VA = "0xEE43B4", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000471")]
			[Address(RVA = "0xEE399C", Offset = "0xEE399C", VA = "0xEE399C")]
			[DebuggerHidden]
			public <get_Childs>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000472")]
			[Address(RVA = "0xEE4184", Offset = "0xEE4184", VA = "0xEE4184", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000473")]
			[Address(RVA = "0xEE41F8", Offset = "0xEE41F8", VA = "0xEE41F8", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0xEE41A0", Offset = "0xEE41A0", VA = "0xEE41A0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0xEE4354", Offset = "0xEE4354", VA = "0xEE4354", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0xEE43BC", Offset = "0xEE43BC", VA = "0xEE43BC", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000479")]
			[Address(RVA = "0xEE4468", Offset = "0xEE4468", VA = "0xEE4468", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBDC4", Offset = "0x6EBDC4")]
		private sealed class <GetEnumerator>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONArray <>4__this;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700006A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600047E")]
				[Address(RVA = "0xEE4114", Offset = "0xEE4114", VA = "0xEE4114", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000480")]
				[Address(RVA = "0xEE417C", Offset = "0xEE417C", VA = "0xEE417C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600047A")]
			[Address(RVA = "0xEE3A44", Offset = "0xEE3A44", VA = "0xEE3A44")]
			[DebuggerHidden]
			public <GetEnumerator>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600047B")]
			[Address(RVA = "0xEE3F4C", Offset = "0xEE3F4C", VA = "0xEE3F4C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600047C")]
			[Address(RVA = "0xEE3FC0", Offset = "0xEE3FC0", VA = "0xEE3FC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0xEE3F68", Offset = "0xEE3F68", VA = "0xEE3F68")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0xEE411C", Offset = "0xEE411C", VA = "0xEE411C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		[Token(Token = "0x1700004A")]
		public override JSONNode Item
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0xEE3504", Offset = "0xEE3504", VA = "0xEE3504", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0xEE35D8", Offset = "0xEE35D8", VA = "0xEE35D8", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public override JSONNode Item
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xEE367C", Offset = "0xEE367C", VA = "0xEE367C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0xEE36E0", Offset = "0xEE36E0", VA = "0xEE36E0", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public override int Count
		{
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0xEE3748", Offset = "0xEE3748", VA = "0xEE3748", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004D")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0xEE391C", Offset = "0xEE391C", VA = "0xEE391C", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6ED5B4", Offset = "0x6ED5B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xEE3798", Offset = "0xEE3798", VA = "0xEE3798", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xEE3800", Offset = "0xEE3800", VA = "0xEE3800", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xEE38AC", Offset = "0xEE38AC", VA = "0xEE38AC", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xEE39D4", Offset = "0xEE39D4", VA = "0xEE39D4", Slot = "29")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6ED618", Offset = "0x6ED618")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xEE3A70", Offset = "0xEE3A70", VA = "0xEE3A70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xEE3C08", Offset = "0xEE3C08", VA = "0xEE3C08", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xEE3DF4", Offset = "0xEE3DF4", VA = "0xEE3DF4", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xEE3ED4", Offset = "0xEE3ED4", VA = "0xEE3ED4")]
		public JSONArray()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6EBCC4", Offset = "0x6EBCC4")]
	public class JSONClass : JSONNode, IEnumerable
	{
		[Token(Token = "0x20000B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBDD4", Offset = "0x6EBDD4")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public JSONNode aNode;

			[Token(Token = "0x6000481")]
			[Address(RVA = "0xEE4BE8", Offset = "0xEE4BE8", VA = "0xEE4BE8")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0xEE586C", Offset = "0xEE586C", VA = "0xEE586C")]
			internal bool <Remove>b__0(KeyValuePair<string, JSONNode> k)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBDE4", Offset = "0x6EBDE4")]
		private sealed class <get_Childs>d__14 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONClass <>4__this;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700006C")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000487")]
				[Address(RVA = "0xEE5D88", Offset = "0xEE5D88", VA = "0xEE5D88", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000489")]
				[Address(RVA = "0xEE5DF0", Offset = "0xEE5DF0", VA = "0xEE5DF0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0xEE4C70", Offset = "0xEE4C70", VA = "0xEE4C70")]
			[DebuggerHidden]
			public <get_Childs>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0xEE5BB8", Offset = "0xEE5BB8", VA = "0xEE5BB8", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000485")]
			[Address(RVA = "0xEE5C2C", Offset = "0xEE5C2C", VA = "0xEE5C2C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0xEE5BD4", Offset = "0xEE5BD4", VA = "0xEE5BD4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000488")]
			[Address(RVA = "0xEE5D90", Offset = "0xEE5D90", VA = "0xEE5D90", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0xEE5DF8", Offset = "0xEE5DF8", VA = "0xEE5DF8", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0xEE5EA4", Offset = "0xEE5EA4", VA = "0xEE5EA4", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EBDF4", Offset = "0x6EBDF4")]
		private sealed class <GetEnumerator>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONClass <>4__this;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700006E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000490")]
				[Address(RVA = "0xEE5B48", Offset = "0xEE5B48", VA = "0xEE5B48", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000492")]
				[Address(RVA = "0xEE5BB0", Offset = "0xEE5BB0", VA = "0xEE5BB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0xEE4D18", Offset = "0xEE4D18", VA = "0xEE4D18")]
			[DebuggerHidden]
			public <GetEnumerator>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0xEE5958", Offset = "0xEE5958", VA = "0xEE5958", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0xEE59CC", Offset = "0xEE59CC", VA = "0xEE59CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0xEE5974", Offset = "0xEE5974", VA = "0xEE5974")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0xEE5B50", Offset = "0xEE5B50", VA = "0xEE5B50", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x1700004E")]
		public override JSONNode Item
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0xEE446C", Offset = "0xEE446C", VA = "0xEE446C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0xEE4560", Offset = "0xEE4560", VA = "0xEE4560", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public override JSONNode Item
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0xEE461C", Offset = "0xEE461C", VA = "0xEE461C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0xEE46B4", Offset = "0xEE46B4", VA = "0xEE46B4", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public override int Count
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0xEE4774", Offset = "0xEE4774", VA = "0xEE4774", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000051")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0xEE4BF0", Offset = "0xEE4BF0", VA = "0xEE4BF0", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6ED67C", Offset = "0x6ED67C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xEE47CC", Offset = "0xEE47CC", VA = "0xEE47CC", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xEE48F8", Offset = "0xEE48F8", VA = "0xEE48F8", Slot = "13")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xEE49B4", Offset = "0xEE49B4", VA = "0xEE49B4", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xEE4A70", Offset = "0xEE4A70", VA = "0xEE4A70", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xEE4CA8", Offset = "0xEE4CA8", VA = "0xEE4CA8", Slot = "29")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6ED6E0", Offset = "0x6ED6E0")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xEE4D44", Offset = "0xEE4D44", VA = "0xEE4D44", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xEE5284", Offset = "0xEE5284", VA = "0xEE5284", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xEE5644", Offset = "0xEE5644", VA = "0xEE5644", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xEE57FC", Offset = "0xEE57FC", VA = "0xEE57FC")]
		public JSONClass()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class JSONData : JSONNode
	{
		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_Data;

		[Token(Token = "0x17000052")]
		public override string Value
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0xEE5EA8", Offset = "0xEE5EA8", VA = "0xEE5EA8", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000406")]
			[Address(RVA = "0xEE5EB0", Offset = "0xEE5EB0", VA = "0xEE5EB0", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xEE5EB8", Offset = "0xEE5EB8", VA = "0xEE5EB8")]
		public JSONData(string aData)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xEE5EE4", Offset = "0xEE5EE4", VA = "0xEE5EE4")]
		public JSONData(float aData)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xEE5F28", Offset = "0xEE5F28", VA = "0xEE5F28")]
		public JSONData(double aData)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xEE5F6C", Offset = "0xEE5F6C", VA = "0xEE5F6C")]
		public JSONData(bool aData)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xEE5FA8", Offset = "0xEE5FA8", VA = "0xEE5FA8")]
		public JSONData(int aData)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xEE5FE4", Offset = "0xEE5FE4", VA = "0xEE5FE4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xEE6044", Offset = "0xEE6044", VA = "0xEE6044", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xEE60A4", Offset = "0xEE60A4", VA = "0xEE60A4", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x6EBCFC", Offset = "0x6EBCFC")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_Key;

		[Token(Token = "0x17000053")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0xEE63C0", Offset = "0xEE63C0", VA = "0xEE63C0", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000413")]
			[Address(RVA = "0xEE6424", Offset = "0xEE6424", VA = "0xEE6424", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000414")]
			[Address(RVA = "0xEE64AC", Offset = "0xEE64AC", VA = "0xEE64AC", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000415")]
			[Address(RVA = "0xEE651C", Offset = "0xEE651C", VA = "0xEE651C", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public override int AsInt
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0xEE67AC", Offset = "0xEE67AC", VA = "0xEE67AC", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600041F")]
			[Address(RVA = "0xEE6830", Offset = "0xEE6830", VA = "0xEE6830", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public override float AsFloat
		{
			[Token(Token = "0x6000420")]
			[Address(RVA = "0xEE68B8", Offset = "0xEE68B8", VA = "0xEE68B8", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000421")]
			[Address(RVA = "0xEE693C", Offset = "0xEE693C", VA = "0xEE693C", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public override double AsDouble
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0xEE69C4", Offset = "0xEE69C4", VA = "0xEE69C4", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000423")]
			[Address(RVA = "0xEE6A48", Offset = "0xEE6A48", VA = "0xEE6A48", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public override bool AsBool
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0xEE6AD0", Offset = "0xEE6AD0", VA = "0xEE6AD0", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000425")]
			[Address(RVA = "0xEE6B54", Offset = "0xEE6B54", VA = "0xEE6B54", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0xEE6BDC", Offset = "0xEE6BDC", VA = "0xEE6BDC", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public override JSONClass AsObject
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0xEE6C44", Offset = "0xEE6C44", VA = "0xEE6C44", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xEE35AC", Offset = "0xEE35AC", VA = "0xEE35AC")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xEE4528", Offset = "0xEE4528", VA = "0xEE4528")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xEE6360", Offset = "0xEE6360", VA = "0xEE6360")]
		private void Set(JSONNode aVal)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xEE65AC", Offset = "0xEE65AC", VA = "0xEE65AC", Slot = "12")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xEE6634", Offset = "0xEE6634", VA = "0xEE6634", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xEE66C4", Offset = "0xEE66C4", VA = "0xEE66C4")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xEE66DC", Offset = "0xEE66DC", VA = "0xEE66DC")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xEE66F4", Offset = "0xEE66F4", VA = "0xEE66F4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xEE670C", Offset = "0xEE670C", VA = "0xEE670C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xEE671C", Offset = "0xEE671C", VA = "0xEE671C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xEE6764", Offset = "0xEE6764", VA = "0xEE6764", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}
	}
	[Token(Token = "0x2000082")]
	public static class JSON
	{
		[Token(Token = "0x6000428")]
		[Address(RVA = "0xEE2E74", Offset = "0xEE2E74", VA = "0xEE2E74")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}
	}
}
