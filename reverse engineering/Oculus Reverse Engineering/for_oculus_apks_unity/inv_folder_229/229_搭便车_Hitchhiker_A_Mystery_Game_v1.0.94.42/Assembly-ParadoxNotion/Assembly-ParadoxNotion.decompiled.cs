using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Il2CppDummyDll;
using Microsoft.CodeAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using ParadoxNotion.Serialization.FullSerializer;
using ParadoxNotion.Serialization.FullSerializer.Internal;
using ParadoxNotion.Services;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF94C", Offset = "0x9DF94C")]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1369000", Offset = "0x1369000", VA = "0x1369000")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF984", Offset = "0x9DF984")]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x151030C", Offset = "0x151030C", VA = "0x151030C")]
		public IsReadOnlyAttribute()
		{
		}
	}
}
namespace FlowCanvas
{
	[Token(Token = "0x2000004")]
	public class BinderConnection<T> : BinderConnection
	{
		[Token(Token = "0x6000003")]
		public override void Bind()
		{
		}

		[Token(Token = "0x6000004")]
		public override void UnBind()
		{
		}

		[Token(Token = "0x6000005")]
		private void DoNormalBinding(Port source, Port target)
		{
		}

		[Token(Token = "0x6000006")]
		public BinderConnection()
		{
		}
	}
	[Token(Token = "0x2000005")]
	public class BinderConnection : Connection
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "fsSerializeAsAttribute", RVA = "0x9E9140", Offset = "0x9E9140")]
		private string _sourcePortID;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "fsSerializeAsAttribute", RVA = "0x9E9178", Offset = "0x9E9178")]
		private string _targetPortID;

		[NonSerialized]
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Port _sourcePort;

		[NonSerialized]
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Port _targetPort;

		[Token(Token = "0x17000001")]
		public string sourcePortID
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x135B6B0", Offset = "0x135B6B0", VA = "0x135B6B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x135B79C", Offset = "0x135B79C", VA = "0x135B79C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public string targetPortID
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x135B7A4", Offset = "0x135B7A4", VA = "0x135B7A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x135B890", Offset = "0x135B890", VA = "0x135B890")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public Port sourcePort
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x135B6F4", Offset = "0x135B6F4", VA = "0x135B6F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		public Port targetPort
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x135B7E8", Offset = "0x135B7E8", VA = "0x135B7E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		public Type bindingType
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x135BBA0", Offset = "0x135BBA0", VA = "0x135BBA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x135BCDC", Offset = "0x135BCDC", VA = "0x135BCDC")]
		public static BinderConnection Create(Port source, Port target)
		{
			return null;
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x135C6B0", Offset = "0x135C6B0", VA = "0x135C6B0")]
		public void SetSourcePort(Port newSourcePort)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x135C448", Offset = "0x135C448", VA = "0x135C448")]
		private void SetSourcePort(Port newSourcePort, bool isNew)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x135CA60", Offset = "0x135CA60", VA = "0x135CA60")]
		public void SetTargetPort(Port newTargetPort)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x135C57C", Offset = "0x135C57C", VA = "0x135C57C")]
		private void SetTargetPort(Port newTargetPort, bool isNew)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x135C8D4", Offset = "0x135C8D4", VA = "0x135C8D4")]
		public void GatherAndValidateSourcePort()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x135CC88", Offset = "0x135CC88", VA = "0x135CC88")]
		public void GatherAndValidateTargetPort()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x135CF88", Offset = "0x135CF88", VA = "0x135CF88")]
		public static bool CanBeBound(Port source, Port target, [Optional] BinderConnection refConnection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x135C16C", Offset = "0x135C16C", VA = "0x135C16C")]
		public static string CanBeBoundVerbosed(Port source, Port target, [Optional] BinderConnection refConnection)
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x135CFA4", Offset = "0x135CFA4", VA = "0x135CFA4", Slot = "7")]
		public sealed override void OnDestroy()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x135D0C0", Offset = "0x135D0C0", VA = "0x135D0C0", Slot = "8")]
		public virtual void Bind()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x135D25C", Offset = "0x135D25C", VA = "0x135D25C", Slot = "9")]
		public virtual void UnBind()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x135C438", Offset = "0x135C438", VA = "0x135C438")]
		public BinderConnection()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public delegate void FlowHandler(Flow f);
	[Token(Token = "0x2000007")]
	[SpoofAOT]
	public delegate T ValueHandler<T>();
	[Token(Token = "0x2000008")]
	public delegate object ValueHandlerObject();
	[Token(Token = "0x2000009")]
	public delegate void FlowBreak();
	[Token(Token = "0x200000A")]
	public delegate void FlowReturn(object value);
	[Serializable]
	[Token(Token = "0x200000B")]
	public class DynamicPortDefinition : ISerializationCallbackReceiver
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _ID;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _name;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _type;

		[NonSerialized]
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Type resolvedType;

		[Token(Token = "0x17000006")]
		public string ID
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x1366BE0", Offset = "0x1366BE0", VA = "0x1366BE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x1368FD0", Offset = "0x1368FD0", VA = "0x1368FD0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public string name
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x1368FD8", Offset = "0x1368FD8", VA = "0x1368FD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x1368FE0", Offset = "0x1368FE0", VA = "0x1368FE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public Type type
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x1368FE8", Offset = "0x1368FE8", VA = "0x1368FE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x1368FF0", Offset = "0x1368FF0", VA = "0x1368FF0")]
			set
			{
			}
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1368EB0", Offset = "0x1368EB0", VA = "0x1368EB0", Slot = "4")]
		private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1368F50", Offset = "0x1368F50", VA = "0x1368F50", Slot = "5")]
		private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1368FF8", Offset = "0x1368FF8", VA = "0x1368FF8")]
		public DynamicPortDefinition()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x136780C", Offset = "0x136780C", VA = "0x136780C")]
		public DynamicPortDefinition(string name, Type type)
		{
		}
	}
	[Token(Token = "0x200000C")]
	[SpoofAOT]
	public struct Flow
	{
		[Token(Token = "0x200000D")]
		public struct ReturnData
		{
			[Token(Token = "0x400000D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E91E0", Offset = "0x9E91E0")]
			private FlowReturn <returnCall>k__BackingField;

			[Token(Token = "0x400000E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E91F0", Offset = "0x9E91F0")]
			private Type <returnType>k__BackingField;

			[Token(Token = "0x1700000A")]
			public FlowReturn returnCall
			{
				[Token(Token = "0x6000042")]
				[Address(RVA = "0x1468B3C", Offset = "0x1468B3C", VA = "0x1468B3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA554", Offset = "0x9EA554")]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6000043")]
				[Address(RVA = "0x1468B44", Offset = "0x1468B44", VA = "0x1468B44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA58C", Offset = "0x9EA58C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700000B")]
			public Type returnType
			{
				[Token(Token = "0x6000044")]
				[Address(RVA = "0x1468B4C", Offset = "0x1468B4C", VA = "0x1468B4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA59C", Offset = "0x9EA59C")]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6000045")]
				[Address(RVA = "0x1468B54", Offset = "0x1468B54", VA = "0x1468B54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA5D4", Offset = "0x9EA5D4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000046")]
			[Address(RVA = "0x1468B5C", Offset = "0x1468B5C", VA = "0x1468B5C")]
			public ReturnData(FlowReturn call, Type type)
			{
			}
		}

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int ticks;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private Dictionary<string, object> parameters;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ReturnData returnData;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FlowBreak breakCall;

		[Token(Token = "0x17000009")]
		public static Flow New
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x136B228", Offset = "0x136B228", VA = "0x136B228")]
			get
			{
				return default(Flow);
			}
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x136B238", Offset = "0x136B238", VA = "0x136B238")]
		public void Call(FlowOutput port)
		{
		}

		[Token(Token = "0x600003B")]
		public T ReadParameter<T>(string name)
		{
			return (T)null;
		}

		[Token(Token = "0x600003C")]
		public void WriteParameter<T>(string name, T value)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x13676D4", Offset = "0x13676D4", VA = "0x13676D4")]
		public void SetReturnData(FlowReturn call, Type expectedType)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x136B288", Offset = "0x136B288", VA = "0x136B288")]
		public void Return(object value, FlowNode context)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x136B828", Offset = "0x136B828", VA = "0x136B828")]
		public void BeginBreakBlock(FlowBreak callback)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x136B830", Offset = "0x136B830", VA = "0x136B830")]
		public void EndBreakBlock()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x135FB08", Offset = "0x135FB08", VA = "0x135FB08")]
		public void Break(FlowNode context)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000E")]
	[GraphInfo]
	public abstract class FlowGraph : Graph
	{
		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool hasInitialized;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<IUpdatable> updatableNodes;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Dictionary<string, IInvokable> functions;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<Type, Component> cachedAgentComponents;

		[Token(Token = "0x1700000C")]
		public override Type baseNodeType
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x136BFD4", Offset = "0x136BFD4", VA = "0x136BFD4", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		public override bool useLocalBlackboard
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x136C04C", Offset = "0x136C04C", VA = "0x136C04C", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		public override bool requiresAgent
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x136C054", Offset = "0x136C054", VA = "0x136C054", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		public override bool requiresPrimeNode
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x136C05C", Offset = "0x136C05C", VA = "0x136C05C", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000010")]
		public override bool isTree
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x136C064", Offset = "0x136C064", VA = "0x136C064", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000011")]
		public override bool canAcceptVariableDrops
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x136C06C", Offset = "0x136C06C", VA = "0x136C06C", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600004D")]
		public T CallFunction<T>(string name, params object[] args)
		{
			return (T)null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x136C074", Offset = "0x136C074", VA = "0x136C074")]
		public object CallFunction(string name, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x136C180", Offset = "0x136C180", VA = "0x136C180")]
		public void CallFunctionAsync(string name, Action<object> callback, params object[] args)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x136C28C", Offset = "0x136C28C", VA = "0x136C28C")]
		public UnityEngine.Object GetAgentComponent(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x136C5E8", Offset = "0x136C5E8", VA = "0x136C5E8", Slot = "22")]
		protected override void OnGraphStarted()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x136CD1C", Offset = "0x136CD1C", VA = "0x136CD1C", Slot = "23")]
		protected override void OnGraphUpdate()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x136CE34", Offset = "0x136CE34", VA = "0x136CE34", Slot = "24")]
		protected override void OnGraphStoped()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x136CF70", Offset = "0x136CF70", VA = "0x136CF70")]
		protected FlowGraph()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public abstract class FlowNode : Node, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000010")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9DFA74", Offset = "0x9DFA74")]
		public class ContextDefinedInputsAttribute : Attribute
		{
			[Token(Token = "0x4000016")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly Type[] types;

			[Token(Token = "0x600008C")]
			[Address(RVA = "0x1468F74", Offset = "0x1468F74", VA = "0x1468F74")]
			public ContextDefinedInputsAttribute(params Type[] types)
			{
			}
		}

		[Token(Token = "0x2000011")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9DFA88", Offset = "0x9DFA88")]
		public class ContextDefinedOutputsAttribute : Attribute
		{
			[Token(Token = "0x4000017")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly Type[] types;

			[Token(Token = "0x600008D")]
			[Address(RVA = "0x1468FA8", Offset = "0x1468FA8", VA = "0x1468FA8")]
			public ContextDefinedOutputsAttribute(params Type[] types)
			{
			}
		}

		[Token(Token = "0x2000012")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9DFA9C", Offset = "0x9DFA9C")]
		public class HasRefreshButtonAttribute : Attribute
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x146902C", Offset = "0x146902C", VA = "0x146902C")]
			public HasRefreshButtonAttribute()
			{
			}
		}

		[Token(Token = "0x2000013")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9DFAB0", Offset = "0x9DFAB0")]
		public class GatherPortsCallbackAttribute : CallbackAttribute
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x1468FDC", Offset = "0x1468FDC", VA = "0x1468FDC")]
			public GatherPortsCallbackAttribute()
			{
			}
		}

		[Token(Token = "0x2000014")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFAC4", Offset = "0x9DFAC4")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x4000018")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FlowNode <>4__this;

			[Token(Token = "0x4000019")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string ID;

			[Token(Token = "0x6000090")]
			[Address(RVA = "0x1468D74", Offset = "0x1468D74", VA = "0x1468D74")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6000091")]
			[Address(RVA = "0x1468D7C", Offset = "0x1468D7C", VA = "0x1468D7C")]
			internal bool <GetInputPort>b__0(Port p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000015")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFAD4", Offset = "0x9DFAD4")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x400001A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FlowNode <>4__this;

			[Token(Token = "0x400001B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string ID;

			[Token(Token = "0x6000092")]
			[Address(RVA = "0x1468DA0", Offset = "0x1468DA0", VA = "0x1468DA0")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6000093")]
			[Address(RVA = "0x1468DA8", Offset = "0x1468DA8", VA = "0x1468DA8")]
			internal bool <GetOutputPort>b__0(Port p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000016")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFAE4", Offset = "0x9DFAE4")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x400001C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type type;

			[Token(Token = "0x6000094")]
			[Address(RVA = "0x1468DCC", Offset = "0x1468DCC", VA = "0x1468DCC")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000095")]
			[Address(RVA = "0x1468DD4", Offset = "0x1468DD4", VA = "0x1468DD4")]
			internal bool <GetFirstInputOfType>b__1(Port p)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000017")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFAF4", Offset = "0x9DFAF4")]
		private sealed class <>c
		{
			[Token(Token = "0x400001D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400001E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Port, int> <>9__39_0;

			[Token(Token = "0x400001F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Port, int> <>9__40_0;

			[Token(Token = "0x4000020")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<KeyValuePair<string, object>, string> <>9__63_0;

			[Token(Token = "0x4000021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<KeyValuePair<string, object>, object> <>9__63_1;

			[Token(Token = "0x6000097")]
			[Address(RVA = "0x1468BF4", Offset = "0x1468BF4", VA = "0x1468BF4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000098")]
			[Address(RVA = "0x1468BFC", Offset = "0x1468BFC", VA = "0x1468BFC")]
			internal int <GetFirstInputOfType>b__39_0(Port p)
			{
				return default(int);
			}

			[Token(Token = "0x6000099")]
			[Address(RVA = "0x1468C78", Offset = "0x1468C78", VA = "0x1468C78")]
			internal int <GetFirstOutputOfType>b__40_0(Port p)
			{
				return default(int);
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x1468CF4", Offset = "0x1468CF4", VA = "0x1468CF4")]
			internal string <ReplaceWith>b__63_0(KeyValuePair<string, object> k)
			{
				return null;
			}

			[Token(Token = "0x600009B")]
			[Address(RVA = "0x1468D34", Offset = "0x1468D34", VA = "0x1468D34")]
			internal object <ReplaceWith>b__63_1(KeyValuePair<string, object> v)
			{
				return null;
			}
		}

		[Token(Token = "0x2000018")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFB04", Offset = "0x9DFB04")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x4000022")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type type;

			[Token(Token = "0x600009C")]
			[Address(RVA = "0x1468E6C", Offset = "0x1468E6C", VA = "0x1468E6C")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x600009D")]
			[Address(RVA = "0x1468E74", Offset = "0x1468E74", VA = "0x1468E74")]
			internal bool <GetFirstOutputOfType>b__1(Port p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000019")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFB14", Offset = "0x9DFB14")]
		private sealed class <>c__DisplayClass44_0
		{
			[Token(Token = "0x4000023")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public KeyValuePair<string, object> pair;

			[Token(Token = "0x4000024")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FlowNode <>4__this;

			[Token(Token = "0x600009E")]
			[Address(RVA = "0x1468F0C", Offset = "0x1468F0C", VA = "0x1468F0C")]
			public <>c__DisplayClass44_0()
			{
			}

			[Token(Token = "0x600009F")]
			[Address(RVA = "0x1468F14", Offset = "0x1468F14", VA = "0x1468F14")]
			internal bool <DeserializeInputPortValues>b__0(Port p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Dictionary<string, object> _inputPortValues;

		[NonSerialized]
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Dictionary<string, Port> inputPorts;

		[NonSerialized]
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Dictionary<string, Port> outputPorts;

		[Token(Token = "0x17000012")]
		public sealed override int maxInConnections
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x136D42C", Offset = "0x136D42C", VA = "0x136D42C", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000013")]
		public sealed override int maxOutConnections
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x136D434", Offset = "0x136D434", VA = "0x136D434", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000014")]
		public sealed override bool allowAsPrime
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x136D43C", Offset = "0x136D43C", VA = "0x136D43C", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000015")]
		public sealed override Type outConnectionType
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x136D444", Offset = "0x136D444", VA = "0x136D444", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public sealed override Alignment2x2 commentsAlignment
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x136D4BC", Offset = "0x136D4BC", VA = "0x136D4BC", Slot = "13")]
			get
			{
				return default(Alignment2x2);
			}
		}

		[Token(Token = "0x17000017")]
		public override Alignment2x2 iconAlignment
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x136D4C4", Offset = "0x136D4C4", VA = "0x136D4C4", Slot = "14")]
			get
			{
				return default(Alignment2x2);
			}
		}

		[Token(Token = "0x17000018")]
		public FlowGraph flowGraph
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x1367C38", Offset = "0x1367C38", VA = "0x1367C38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x136D4CC", Offset = "0x136D4CC", VA = "0x136D4CC", Slot = "34")]
		private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x136D6EC", Offset = "0x136D6EC", VA = "0x136D6EC", Slot = "35")]
		private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x136D6F0", Offset = "0x136D6F0", VA = "0x136D6F0", Slot = "16")]
		public sealed override void OnValidate(Graph flowGraph)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x136D6F4", Offset = "0x136D6F4", VA = "0x136D6F4", Slot = "22")]
		public sealed override void OnParentConnected(int i)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x136D6F8", Offset = "0x136D6F8", VA = "0x136D6F8", Slot = "24")]
		public sealed override void OnChildConnected(int i)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x136D6FC", Offset = "0x136D6FC", VA = "0x136D6FC", Slot = "23")]
		public sealed override void OnParentDisconnected(int i)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x136D700", Offset = "0x136D700", VA = "0x136D700", Slot = "25")]
		public sealed override void OnChildDisconnected(int i)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x136D704", Offset = "0x136D704", VA = "0x136D704", Slot = "36")]
		public virtual void OnPortConnected(Port port, Port otherPort)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x136D848", Offset = "0x136D848", VA = "0x136D848", Slot = "37")]
		public virtual void OnPortDisconnected(Port port, Port otherPort)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x136CC18", Offset = "0x136CC18", VA = "0x136CC18")]
		public void BindPorts()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x136D84C", Offset = "0x136D84C", VA = "0x136D84C")]
		public void UnBindPorts()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x135BA1C", Offset = "0x135BA1C", VA = "0x135BA1C")]
		public Port GetInputPort(string ID)
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x135B898", Offset = "0x135B898", VA = "0x135B898")]
		public Port GetOutputPort(string ID)
		{
			return null;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x136D950", Offset = "0x136D950", VA = "0x136D950")]
		public Port[] GetAllPorts()
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x136BE40", Offset = "0x136BE40", VA = "0x136BE40")]
		public FlowOutput[] GetOutputFlowPorts()
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x136D9FC", Offset = "0x136D9FC", VA = "0x136D9FC")]
		public ValueOutput[] GetOutputValuePorts()
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x136BDB4", Offset = "0x136BDB4", VA = "0x136BDB4")]
		public FlowInput[] GetInputFlowPorts()
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x136DA88", Offset = "0x136DA88", VA = "0x136DA88")]
		public ValueInput[] GetInputValuePorts()
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x136DB14", Offset = "0x136DB14", VA = "0x136DB14")]
		public Port GetFirstInputOfType(Type type)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x136DD34", Offset = "0x136DD34", VA = "0x136DD34")]
		public Port GetFirstOutputOfType(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x136CAD0", Offset = "0x136CAD0", VA = "0x136CAD0")]
		public void AssignSelfInstancePort()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x135FE30", Offset = "0x135FE30", VA = "0x135FE30")]
		public void GatherPorts()
		{
		}

		[Token(Token = "0x6000072")]
		protected abstract void RegisterPorts();

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x136DF54", Offset = "0x136DF54", VA = "0x136DF54")]
		private void DeserializeInputPortValues()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x136E34C", Offset = "0x136E34C", VA = "0x136E34C")]
		private void ValidateConnections()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1368E9C", Offset = "0x1368E9C", VA = "0x1368E9C")]
		public FlowInput AddFlowInput(string name, string ID, FlowHandler pointer)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x135631C", Offset = "0x135631C", VA = "0x135631C")]
		public FlowInput AddFlowInput(string name, FlowHandler pointer, string ID = "")
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1356200", Offset = "0x1356200", VA = "0x1356200")]
		public FlowOutput AddFlowOutput(string name, string ID = "")
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		public ValueInput<T> AddValueInput<T>(string name, string ID = "")
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		public ValueOutput<T> AddValueOutput<T>(string name, string ID, ValueHandler<T> getter)
		{
			return null;
		}

		[Token(Token = "0x600007A")]
		public ValueOutput<T> AddValueOutput<T>(string name, ValueHandler<T> getter, string ID = "")
		{
			return null;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x136E624", Offset = "0x136E624", VA = "0x136E624")]
		public ValueInput AddValueInput(string name, string ID, Type type)
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x136036C", Offset = "0x136036C", VA = "0x136036C")]
		public ValueInput AddValueInput(string name, Type type, string ID = "")
		{
			return null;
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1360474", Offset = "0x1360474", VA = "0x1360474")]
		public ValueOutput AddValueOutput(string name, string ID, Type type, ValueHandlerObject getter)
		{
			return null;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x136E634", Offset = "0x136E634", VA = "0x136E634")]
		public ValueOutput AddValueOutput(string name, Type type, ValueHandlerObject getter, string ID = "")
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x136E4CC", Offset = "0x136E4CC", VA = "0x136E4CC")]
		private void QualifyPortNameAndID(ref string name, ref string ID, IDictionary dict)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x136E744", Offset = "0x136E744", VA = "0x136E744")]
		private bool CheckReverseIDEquality(Port port, string requestedID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x136E86C", Offset = "0x136E86C", VA = "0x136E86C")]
		public void TryAddReflectionBasedRegistrationForObject(object instance)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x136EA08", Offset = "0x136EA08", VA = "0x136EA08")]
		public FlowInput TryAddMethodFlowInput(MethodInfo method, object instance)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x136F0D0", Offset = "0x136F0D0", VA = "0x136F0D0")]
		public FlowOutput TryAddFieldDelegateFlowOutput(FieldInfo field, object instance)
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x136F2A4", Offset = "0x136F2A4", VA = "0x136F2A4")]
		public ValueInput TryAddFieldDelegateValueInput(FieldInfo field, object instance)
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x136EC60", Offset = "0x136EC60", VA = "0x136EC60")]
		public ValueOutput TryAddPropertyValueOutput(PropertyInfo prop, object instance)
		{
			return null;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x136F814", Offset = "0x136F814", VA = "0x136F814")]
		public FlowNode ReplaceWith(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x136FB90", Offset = "0x136FB90", VA = "0x136FB90", Slot = "39")]
		public virtual Type GetNodeWildDefinitionType()
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x136D76C", Offset = "0x136D76C", VA = "0x136D76C")]
		private void TryHandleWildPortConnection(Type currentType, Type targetType)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x136FC08", Offset = "0x136FC08", VA = "0x136FC08")]
		public static Type TryGetNewGenericTypeForWild(Type wildType, Type currentType, Type targetType, Type content, Type context)
		{
			return null;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x13700B0", Offset = "0x13700B0", VA = "0x13700B0")]
		public static MethodInfo TryGetNewGenericMethodForWild(Type wildType, Type currentType, Type targetType, MethodInfo content)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1368028", Offset = "0x1368028", VA = "0x1368028")]
		protected FlowNode()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x9DFB24", Offset = "0x9DFB24")]
	public class FlowScript : FlowScriptBase
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1370540", Offset = "0x1370540", VA = "0x1370540")]
		public FlowScript()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public abstract class FlowScriptBase : FlowGraph
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1370544", Offset = "0x1370544", VA = "0x1370544")]
		protected FlowScriptBase()
		{
		}
	}
	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9DFB68", Offset = "0x9DFB68")]
	public class FlowScriptController : GraphOwner<FlowScript>
	{
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1370548", Offset = "0x1370548", VA = "0x1370548")]
		public object CallFunction(string name, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x13705A8", Offset = "0x13705A8", VA = "0x13705A8")]
		public void CallFunctionAsync(string name, Action<object> callback, params object[] args)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1370618", Offset = "0x1370618", VA = "0x1370618")]
		public FlowScriptController()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public interface IEditorMenuCallbackReceiver
	{
	}
	[Token(Token = "0x200001E")]
	[SpoofAOT]
	public abstract class Port
	{
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E9210", Offset = "0x9E9210")]
		private FlowNode <parent>k__BackingField;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E9220", Offset = "0x9E9220")]
		private string <ID>k__BackingField;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E9230", Offset = "0x9E9230")]
		private string <name>k__BackingField;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E9240", Offset = "0x9E9240")]
		private int <connections>k__BackingField;

		[Token(Token = "0x17000019")]
		public FlowNode parent
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x151DE7C", Offset = "0x151DE7C", VA = "0x151DE7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA5E4", Offset = "0x9EA5E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x151DE84", Offset = "0x151DE84", VA = "0x151DE84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA5F4", Offset = "0x9EA5F4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public string ID
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x151DE8C", Offset = "0x151DE8C", VA = "0x151DE8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA604", Offset = "0x9EA604")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x151DE94", Offset = "0x151DE94", VA = "0x151DE94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA614", Offset = "0x9EA614")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public string name
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x151DE9C", Offset = "0x151DE9C", VA = "0x151DE9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA624", Offset = "0x9EA624")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x151DEA4", Offset = "0x151DEA4", VA = "0x151DEA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA634", Offset = "0x9EA634")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public int connections
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x151DEAC", Offset = "0x151DEAC", VA = "0x151DEAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA644", Offset = "0x9EA644")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x151DEB4", Offset = "0x151DEB4", VA = "0x151DEB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA654", Offset = "0x9EA654")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public bool isConnected
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x151DEBC", Offset = "0x151DEBC", VA = "0x151DEBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001E")]
		public bool isInputConnected
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x151DECC", Offset = "0x151DECC", VA = "0x151DECC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001F")]
		public bool isOutputConnected
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x151DFCC", Offset = "0x151DFCC", VA = "0x151DFCC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public abstract Type type
		{
			[Token(Token = "0x60000B2")]
			get;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x151DE10", Offset = "0x151DE10", VA = "0x151DE10")]
		public Port()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x151DE18", Offset = "0x151DE18", VA = "0x151DE18")]
		public Port(FlowNode parent, string name, string ID)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x151E0CC", Offset = "0x151E0CC", VA = "0x151E0CC")]
		public bool CanAcceptConnections()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x151E20C", Offset = "0x151E20C", VA = "0x151E20C")]
		public BinderConnection[] GetPortConnections()
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x151DEE8", Offset = "0x151DEE8", VA = "0x151DEE8")]
		public BinderConnection GetFirstInputConnection()
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x151DFE8", Offset = "0x151DFE8", VA = "0x151DFE8")]
		public BinderConnection GetFirstOutputConnection()
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x151E418", Offset = "0x151E418", VA = "0x151E418")]
		public bool IsFlowPort()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x151E4D4", Offset = "0x151E4D4", VA = "0x151E4D4")]
		public bool IsValuePort()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x151E35C", Offset = "0x151E35C", VA = "0x151E35C")]
		public bool IsInputPort()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x151E590", Offset = "0x151E590", VA = "0x151E590")]
		public bool IsOutputPort()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x151E64C", Offset = "0x151E64C", VA = "0x151E64C")]
		public bool IsUnityObject()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x151E720", Offset = "0x151E720", VA = "0x151E720")]
		public bool IsUnitySceneObject()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x151E878", Offset = "0x151E878", VA = "0x151E878")]
		public bool IsDelegate()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x151E94C", Offset = "0x151E94C", VA = "0x151E94C")]
		public bool IsEnumerableCollection()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x151E9C8", Offset = "0x151E9C8", VA = "0x151E9C8")]
		public bool IsWild()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x151EA6C", Offset = "0x151EA6C", VA = "0x151EA6C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x151EAD4", Offset = "0x151EAD4", VA = "0x151EAD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA664", Offset = "0x9EA664")]
		private bool <GetPortConnections>b__27_0(BinderConnection c)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x151EB0C", Offset = "0x151EB0C", VA = "0x151EB0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA674", Offset = "0x9EA674")]
		private bool <GetPortConnections>b__27_1(BinderConnection c)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x151EB44", Offset = "0x151EB44", VA = "0x151EB44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA684", Offset = "0x9EA684")]
		private bool <GetFirstInputConnection>b__28_0(BinderConnection c)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x151EB7C", Offset = "0x151EB7C", VA = "0x151EB7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA694", Offset = "0x9EA694")]
		private bool <GetFirstOutputConnection>b__29_0(BinderConnection c)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200001F")]
	public class FlowInput : Port
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E9250", Offset = "0x9E9250")]
		private FlowHandler <pointer>k__BackingField;

		[Token(Token = "0x17000021")]
		public FlowHandler pointer
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x136D3A4", Offset = "0x136D3A4", VA = "0x136D3A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA6A4", Offset = "0x9EA6A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x136D3AC", Offset = "0x136D3AC", VA = "0x136D3AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA6B4", Offset = "0x9EA6B4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public override Type type
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x136D3B4", Offset = "0x136D3B4", VA = "0x136D3B4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x136D370", Offset = "0x136D370", VA = "0x136D370")]
		public FlowInput(FlowNode parent, string name, string ID, FlowHandler pointer)
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class FlowOutput : Port
	{
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E9260", Offset = "0x9E9260")]
		private FlowHandler <pointer>k__BackingField;

		[Token(Token = "0x17000023")]
		public FlowHandler pointer
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x13703FC", Offset = "0x13703FC", VA = "0x13703FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA6C4", Offset = "0x9EA6C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x1370404", Offset = "0x1370404", VA = "0x1370404")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA6D4", Offset = "0x9EA6D4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public override Type type
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x137040C", Offset = "0x137040C", VA = "0x137040C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x136E61C", Offset = "0x136E61C", VA = "0x136E61C")]
		public FlowOutput(FlowNode parent, string name, string ID)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x135654C", Offset = "0x135654C", VA = "0x135654C")]
		public void Call(Flow f)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x135D240", Offset = "0x135D240", VA = "0x135D240")]
		public void BindTo(FlowInput target)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1370484", Offset = "0x1370484", VA = "0x1370484")]
		public void Append(FlowHandler action)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x135D328", Offset = "0x135D328", VA = "0x135D328")]
		public void UnBind()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public abstract class ValueInput : Port
	{
		[Token(Token = "0x17000025")]
		public object value
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x1453F78", Offset = "0x1453F78", VA = "0x1453F78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		public abstract object defaultValue
		{
			[Token(Token = "0x60000D7")]
			get;
			[Token(Token = "0x60000D8")]
			set;
		}

		[Token(Token = "0x17000027")]
		public abstract object serializedValue
		{
			[Token(Token = "0x60000D9")]
			get;
			[Token(Token = "0x60000DA")]
			set;
		}

		[Token(Token = "0x17000028")]
		public abstract bool isDefaultValue
		{
			[Token(Token = "0x60000DB")]
			get;
		}

		[Token(Token = "0x17000029")]
		public abstract override Type type
		{
			[Token(Token = "0x60000DC")]
			get;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x14553D0", Offset = "0x14553D0", VA = "0x14553D0")]
		public ValueInput()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x14553D8", Offset = "0x14553D8", VA = "0x14553D8")]
		public ValueInput(FlowNode parent, string name, string ID)
		{
		}

		[Token(Token = "0x60000D3")]
		public static ValueInput<T> CreateInstance<T>(FlowNode parent, string name, string ID)
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x14553E0", Offset = "0x14553E0", VA = "0x14553E0")]
		public static ValueInput CreateInstance(Type t, FlowNode parent, string name, string ID)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1455654", Offset = "0x1455654", VA = "0x1455654")]
		public ValueInput SetDefaultAndSerializedValue(object v)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		public abstract void BindTo(ValueOutput target);

		[Token(Token = "0x60000DE")]
		public abstract void UnBind();

		[Token(Token = "0x60000DF")]
		public abstract object GetObjectValue();
	}
	[Token(Token = "0x2000022")]
	public class ValueInput<T> : ValueInput
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E9270", Offset = "0x9E9270")]
		private ValueHandler<T> <getter>k__BackingField;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T _value;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T _defaultValue;

		[Token(Token = "0x1700002A")]
		public ValueHandler<T> getter
		{
			[Token(Token = "0x60000E2")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA6E4", Offset = "0x9EA6E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E3")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA6F4", Offset = "0x9EA6F4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public new T value
		{
			[Token(Token = "0x60000E4")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x1700002C")]
		public override object defaultValue
		{
			[Token(Token = "0x60000E5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E6")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public override object serializedValue
		{
			[Token(Token = "0x60000E7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public override bool isDefaultValue
		{
			[Token(Token = "0x60000E9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002F")]
		public override Type type
		{
			[Token(Token = "0x60000EA")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E0")]
		public ValueInput()
		{
		}

		[Token(Token = "0x60000E1")]
		public ValueInput(FlowNode parent, string name, string ID)
		{
		}

		[Token(Token = "0x60000EB")]
		public ValueInput<T> SetDefaultAndSerializedValue(T v)
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		public T GetValue()
		{
			return (T)null;
		}

		[Token(Token = "0x60000ED")]
		public override object GetObjectValue()
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		public override void BindTo(ValueOutput source)
		{
		}

		[Token(Token = "0x60000EF")]
		public void BindTo(ValueHandler<T> getter)
		{
		}

		[Token(Token = "0x60000F0")]
		public override void UnBind()
		{
		}

		[Token(Token = "0x60000F1")]
		public static explicit operator T(ValueInput<T> port)
		{
			return (T)null;
		}
	}
	[Token(Token = "0x2000023")]
	public abstract class ValueOutput : Port
	{
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1455698", Offset = "0x1455698", VA = "0x1455698")]
		public ValueOutput()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x14556A0", Offset = "0x14556A0", VA = "0x14556A0")]
		public ValueOutput(FlowNode parent, string name, string ID)
		{
		}

		[Token(Token = "0x60000F4")]
		public static ValueOutput<T> CreateInstance<T>(FlowNode parent, string name, string ID, ValueHandler<T> getter)
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x14556A8", Offset = "0x14556A8", VA = "0x14556A8")]
		public static ValueOutput CreateInstance(Type t, FlowNode parent, string name, string ID, ValueHandlerObject getter)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		public abstract object GetObjectValue();
	}
	[Token(Token = "0x2000024")]
	public class ValueOutput<T> : ValueOutput
	{
		[Token(Token = "0x2000025")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFBB0", Offset = "0x9DFBB0")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueHandlerObject getter;

			[Token(Token = "0x60000FF")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000100")]
			internal T <.ctor>b__0()
			{
				return (T)null;
			}
		}

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E9280", Offset = "0x9E9280")]
		private ValueHandler<T> <getter>k__BackingField;

		[Token(Token = "0x17000030")]
		public ValueHandler<T> getter
		{
			[Token(Token = "0x60000FA")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA704", Offset = "0x9EA704")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FB")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA714", Offset = "0x9EA714")]
			private set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public override Type type
		{
			[Token(Token = "0x60000FD")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F7")]
		public ValueOutput()
		{
		}

		[Token(Token = "0x60000F8")]
		public ValueOutput(FlowNode parent, string name, string ID, ValueHandler<T> getter)
		{
		}

		[Token(Token = "0x60000F9")]
		public ValueOutput(FlowNode parent, string name, string ID, ValueHandlerObject getter)
		{
		}

		[Token(Token = "0x60000FC")]
		public override object GetObjectValue()
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		public static explicit operator T(ValueOutput<T> port)
		{
			return (T)null;
		}
	}
	[Token(Token = "0x2000026")]
	[SpoofAOT]
	public static class TypeConverter
	{
		[Token(Token = "0x2000027")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFBD0", Offset = "0x9DFBD0")]
		private sealed class <>c__DisplayClass0_0<T>
		{
			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueHandler<object> func;

			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Type targetType;

			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UnaryExpression exp;

			[Token(Token = "0x6000105")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000106")]
			internal T <GetConverterFuncFromTo>b__0()
			{
				return (T)null;
			}

			[Token(Token = "0x6000107")]
			internal T <GetConverterFuncFromTo>b__1()
			{
				return (T)null;
			}

			[Token(Token = "0x6000108")]
			internal T <GetConverterFuncFromTo>b__2()
			{
				return (T)null;
			}

			[Token(Token = "0x6000109")]
			internal T <GetConverterFuncFromTo>b__3()
			{
				return (T)null;
			}

			[Token(Token = "0x600010A")]
			internal T <GetConverterFuncFromTo>b__4()
			{
				return (T)null;
			}

			[Token(Token = "0x600010B")]
			internal T <GetConverterFuncFromTo>b__5()
			{
				return (T)null;
			}

			[Token(Token = "0x600010C")]
			internal T <GetConverterFuncFromTo>b__6()
			{
				return (T)null;
			}

			[Token(Token = "0x600010D")]
			internal T <GetConverterFuncFromTo>b__7()
			{
				return (T)null;
			}

			[Token(Token = "0x600010E")]
			internal T <GetConverterFuncFromTo>b__8()
			{
				return (T)null;
			}

			[Token(Token = "0x600010F")]
			internal T <GetConverterFuncFromTo>b__9()
			{
				return (T)null;
			}

			[Token(Token = "0x6000110")]
			internal T <GetConverterFuncFromTo>b__10()
			{
				return (T)null;
			}

			[Token(Token = "0x6000111")]
			internal T <GetConverterFuncFromTo>b__11()
			{
				return (T)null;
			}

			[Token(Token = "0x6000112")]
			internal T <GetConverterFuncFromTo>b__12()
			{
				return (T)null;
			}

			[Token(Token = "0x6000113")]
			internal T <GetConverterFuncFromTo>b__13()
			{
				return (T)null;
			}

			[Token(Token = "0x6000114")]
			internal T <GetConverterFuncFromTo>b__14()
			{
				return (T)null;
			}
		}

		[Token(Token = "0x2000028")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFBE0", Offset = "0x9DFBE0")]
		private sealed class <>c__DisplayClass0_1<T>
		{
			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Type listType;

			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public <>c__DisplayClass0_0<T> CS$<>8__locals1;

			[Token(Token = "0x6000115")]
			public <>c__DisplayClass0_1()
			{
			}

			[Token(Token = "0x6000116")]
			internal T <GetConverterFuncFromTo>b__15()
			{
				return (T)null;
			}
		}

		[Token(Token = "0x2000029")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFBF0", Offset = "0x9DFBF0")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object obj;

			[Token(Token = "0x6000117")]
			[Address(RVA = "0x26A75C8", Offset = "0x26A75C8", VA = "0x26A75C8")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000118")]
			[Address(RVA = "0x26A75D0", Offset = "0x26A75D0", VA = "0x26A75D0")]
			internal object <QuickConvert>b__0()
			{
				return null;
			}
		}

		[Token(Token = "0x6000101")]
		public static ValueHandler<T> GetConverterFuncFromTo<T>(Type sourceType, Type targetType, ValueHandler<object> func)
		{
			return null;
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1BC84C8", Offset = "0x1BC84C8", VA = "0x1BC84C8")]
		public static bool HasConvertion(Type sourceType, Type targetType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000103")]
		public static T QuickConvert<T>(object obj)
		{
			return (T)null;
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1BC85CC", Offset = "0x1BC85CC", VA = "0x1BC85CC")]
		public static object QuickConvert(object obj, Type type)
		{
			return null;
		}
	}
	[Token(Token = "0x200002A")]
	public class Wild
	{
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x145737C", Offset = "0x145737C", VA = "0x145737C")]
		public Wild()
		{
		}
	}
}
namespace FlowCanvas.Nodes
{
	[Token(Token = "0x200002B")]
	public abstract class CustomObjectWrapper : FlowNode
	{
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1367E0C", Offset = "0x1367E0C", VA = "0x1367E0C")]
		public static Type[] FindCustomObjectWrappersForType(Type targetType)
		{
			return null;
		}

		[Token(Token = "0x600011B")]
		public abstract void SetTarget(UnityEngine.Object target);

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1368020", Offset = "0x1368020", VA = "0x1368020")]
		protected CustomObjectWrapper()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "IconAttribute", RVA = "0x9DFC00", Offset = "0x9DFC00")]
	public abstract class CustomObjectWrapper<T> : CustomObjectWrapper where T : UnityEngine.Object
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private T _target;

		[Token(Token = "0x17000032")]
		public T target
		{
			[Token(Token = "0x600011D")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011E")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public override string name
		{
			[Token(Token = "0x600011F")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000120")]
		public override void SetTarget(UnityEngine.Object target)
		{
		}

		[Token(Token = "0x6000121")]
		protected Type GetRuntimeIconType()
		{
			return null;
		}

		[Token(Token = "0x6000122")]
		protected CustomObjectWrapper()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9DFC50", Offset = "0x9DFC50")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9DFC50", Offset = "0x9DFC50")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9DFC50", Offset = "0x9DFC50")]
	public class ApplicationPauseEvent : EventNode
	{
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FlowOutput pause;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool isPause;

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1358820", Offset = "0x1358820", VA = "0x1358820", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x13588D4", Offset = "0x13588D4", VA = "0x13588D4", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1358988", Offset = "0x1358988", VA = "0x1358988")]
		private void ApplicationPause(bool isPause)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x13589E4", Offset = "0x13589E4", VA = "0x13589E4", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1358AF8", Offset = "0x1358AF8", VA = "0x1358AF8")]
		public ApplicationPauseEvent()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1358B08", Offset = "0x1358B08", VA = "0x1358B08")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA724", Offset = "0x9EA724")]
		private bool <RegisterPorts>b__5_0()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9DFCD8", Offset = "0x9DFCD8")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9DFCD8", Offset = "0x9DFCD8")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9DFCD8", Offset = "0x9DFCD8")]
	public class ApplicationQuitEvent : EventNode
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FlowOutput quit;

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1358B10", Offset = "0x1358B10", VA = "0x1358B10", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1358BB0", Offset = "0x1358BB0", VA = "0x1358BB0", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1358C50", Offset = "0x1358C50", VA = "0x1358C50")]
		private void ApplicationQuit()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1358CA0", Offset = "0x1358CA0", VA = "0x1358CA0", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1358D14", Offset = "0x1358D14", VA = "0x1358D14")]
		public ApplicationQuitEvent()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9DFD60", Offset = "0x9DFD60")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9DFD60", Offset = "0x9DFD60")]
	[DoNotList]
	public class CSharpAutoCallbackEvent : EventNode
	{
		[Token(Token = "0x2000030")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFDD4", Offset = "0x9DFDD4")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CSharpAutoCallbackEvent <>4__this;

			[Token(Token = "0x6000137")]
			[Address(RVA = "0x1467D74", Offset = "0x1467D74", VA = "0x1467D74")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000138")]
			[Address(RVA = "0x1467D7C", Offset = "0x1467D7C", VA = "0x1467D7C")]
			internal object <RegisterPorts>b__0()
			{
				return null;
			}
		}

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SerializedEventInfo _event;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ReflectedDelegateEvent reflectedEvent;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ValueInput instancePort;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FlowOutput callback;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private object instance;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private object[] args;

		[Token(Token = "0x17000034")]
		private EventInfo eventInfo
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x135FB84", Offset = "0x135FB84", VA = "0x135FB84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		private bool isStaticEvent
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x135FB9C", Offset = "0x135FB9C", VA = "0x135FB9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000036")]
		public override string name
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x135FC48", Offset = "0x135FC48", VA = "0x135FC48", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x135FDB4", Offset = "0x135FDB4", VA = "0x135FDB4")]
		public void SetEvent(EventInfo info, [Optional] object instance)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x135FFB8", Offset = "0x135FFB8", VA = "0x135FFB8", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1360488", Offset = "0x1360488", VA = "0x1360488", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1360600", Offset = "0x1360600", VA = "0x1360600", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1360700", Offset = "0x1360700", VA = "0x1360700")]
		private void OnEventRaised(params object[] args)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1360768", Offset = "0x1360768", VA = "0x1360768")]
		public CSharpAutoCallbackEvent()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9DFDE4", Offset = "0x9DFDE4")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9DFDE4", Offset = "0x9DFDE4")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9DFDE4", Offset = "0x9DFDE4")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9DFDE4", Offset = "0x9DFDE4")]
	public class CSharpEventCallback : EventNode
	{
		[Token(Token = "0x2000032")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFEE8", Offset = "0x9DFEE8")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			[Token(Token = "0x4000049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CSharpEventCallback <>4__this;

			[Token(Token = "0x6000145")]
			[Address(RVA = "0x1467DC4", Offset = "0x1467DC4", VA = "0x1467DC4")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000146")]
			[Address(RVA = "0x1467DCC", Offset = "0x1467DCC", VA = "0x1467DCC")]
			internal object <RegisterPorts>b__0()
			{
				return null;
			}
		}

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9E92B0", Offset = "0x9E92B0")]
		[GatherPortsCallback]
		[SerializeField]
		[ExposeField]
		protected bool _autoHandleRegistration;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private SerializedTypeInfo _type;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private object[] argValues;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ValueInput eventInput;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private FlowOutput flowCallback;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ReflectedDelegateEvent reflectedEvent;

		[Token(Token = "0x17000037")]
		private Type type
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x1360770", Offset = "0x1360770", VA = "0x1360770")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x1360788", Offset = "0x1360788", VA = "0x1360788")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		private bool autoHandleRegistration
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x1360858", Offset = "0x1360858", VA = "0x1360858")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1360860", Offset = "0x1360860", VA = "0x1360860", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x13609B0", Offset = "0x13609B0", VA = "0x13609B0", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1360AC0", Offset = "0x1360AC0", VA = "0x1360AC0", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1360870", Offset = "0x1360870", VA = "0x1360870")]
		private void Register([Optional] Flow f)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x13609C0", Offset = "0x13609C0", VA = "0x13609C0")]
		private void Unregister([Optional] Flow f)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1360FF4", Offset = "0x1360FF4", VA = "0x1360FF4")]
		private void Callback(params object[] args)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x136105C", Offset = "0x136105C", VA = "0x136105C", Slot = "39")]
		public override Type GetNodeWildDefinitionType()
		{
			return null;
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x13610D4", Offset = "0x13610D4", VA = "0x13610D4", Slot = "36")]
		public override void OnPortConnected(Port port, Port otherPort)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1361208", Offset = "0x1361208", VA = "0x1361208")]
		public CSharpEventCallback()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9DFEF8", Offset = "0x9DFEF8")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9DFEF8", Offset = "0x9DFEF8")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9DFEF8", Offset = "0x9DFEF8")]
	public class CustomEvent : MessageEventNode<GraphOwner>
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0x9E932C", Offset = "0x9E932C")]
		[DelayedField]
		public BBParameter<string> eventName;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private FlowOutput onReceived;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GraphOwner sender;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private GraphOwner receiver;

		[Token(Token = "0x17000039")]
		public override string name
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x136602C", Offset = "0x136602C", VA = "0x136602C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x13660B4", Offset = "0x13660B4", VA = "0x13660B4", Slot = "40")]
		protected override string[] GetTargetMessageEvents()
		{
			return null;
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1366174", Offset = "0x1366174", VA = "0x1366174", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x13662EC", Offset = "0x13662EC", VA = "0x13662EC")]
		public void OnCustomEvent(MessageRouter.MessageData<EventData> msg)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x13664F8", Offset = "0x13664F8", VA = "0x13664F8")]
		public CustomEvent()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1366588", Offset = "0x1366588", VA = "0x1366588")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA734", Offset = "0x9EA734")]
		private GraphOwner <RegisterPorts>b__7_0()
		{
			return null;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1366590", Offset = "0x1366590", VA = "0x1366590")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA744", Offset = "0x9EA744")]
		private GraphOwner <RegisterPorts>b__7_1()
		{
			return null;
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9DFF80", Offset = "0x9DFF80")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9DFF80", Offset = "0x9DFF80")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9DFF80", Offset = "0x9DFF80")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9DFF80", Offset = "0x9DFF80")]
	public class CustomEvent<T> : MessageEventNode<GraphOwner>
	{
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0x9E9364", Offset = "0x9E9364")]
		public BBParameter<string> eventName;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FlowOutput onReceived;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GraphOwner sender;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GraphOwner receiver;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T receivedValue;

		[Token(Token = "0x1700003A")]
		public override string name
		{
			[Token(Token = "0x600014E")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600014F")]
		protected override string[] GetTargetMessageEvents()
		{
			return null;
		}

		[Token(Token = "0x6000150")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000151")]
		public void OnCustomEvent(MessageRouter.MessageData<EventData> msg)
		{
		}

		[Token(Token = "0x6000152")]
		public CustomEvent()
		{
		}

		[Token(Token = "0x6000153")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA754", Offset = "0x9EA754")]
		private GraphOwner <RegisterPorts>b__8_0()
		{
			return null;
		}

		[Token(Token = "0x6000154")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA764", Offset = "0x9EA764")]
		private GraphOwner <RegisterPorts>b__8_1()
		{
			return null;
		}

		[Token(Token = "0x6000155")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA774", Offset = "0x9EA774")]
		private T <RegisterPorts>b__8_2()
		{
			return (T)null;
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E0084", Offset = "0x9E0084")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E0084", Offset = "0x9E0084")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E0084", Offset = "0x9E0084")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E0084", Offset = "0x9E0084")]
	public class DelegateCallbackEvent : EventNode
	{
		[Token(Token = "0x2000036")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E01B4", Offset = "0x9E01B4")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DelegateCallbackEvent <>4__this;

			[Token(Token = "0x600015D")]
			[Address(RVA = "0x146884C", Offset = "0x146884C", VA = "0x146884C")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600015E")]
			[Address(RVA = "0x1468854", Offset = "0x1468854", VA = "0x1468854")]
			internal object <RegisterPorts>b__1()
			{
				return null;
			}
		}

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SerializedTypeInfo _type;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ReflectedDelegateEvent reflectedEvent;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ValueOutput delegatePort;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FlowOutput callbackPort;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private object[] args;

		[Token(Token = "0x1700003B")]
		private Type delegateType
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x1368208", Offset = "0x1368208", VA = "0x1368208")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x1368220", Offset = "0x1368220", VA = "0x1368220")]
			set
			{
			}
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x13682F0", Offset = "0x13682F0", VA = "0x13682F0", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x13687B4", Offset = "0x13687B4", VA = "0x13687B4")]
		private void Callback(params object[] args)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x136881C", Offset = "0x136881C", VA = "0x136881C", Slot = "36")]
		public override void OnPortConnected(Port port, Port otherPort)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1368950", Offset = "0x1368950", VA = "0x1368950")]
		public DelegateCallbackEvent()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1368958", Offset = "0x1368958", VA = "0x1368958")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA784", Offset = "0x9EA784")]
		private object <RegisterPorts>b__8_0()
		{
			return null;
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E01C4", Offset = "0x9E01C4")]
	[DoNotList]
	public class GetSharpEvent : FlowNode
	{
		[Token(Token = "0x2000038")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0210", Offset = "0x9E0210")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400005C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SharpEvent wrapper;

			[Token(Token = "0x400005D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GetSharpEvent <>4__this;

			[Token(Token = "0x6000164")]
			[Address(RVA = "0x1469800", Offset = "0x1469800", VA = "0x1469800")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000165")]
			[Address(RVA = "0x1469808", Offset = "0x1469808", VA = "0x1469808")]
			internal object <RegisterPorts>b__0()
			{
				return null;
			}
		}

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SerializedEventInfo _event;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ValueInput instancePort;

		[Token(Token = "0x1700003C")]
		private EventInfo eventInfo
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x1505024", Offset = "0x1505024", VA = "0x1505024")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public override string name
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x150503C", Offset = "0x150503C", VA = "0x150503C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x150530C", Offset = "0x150530C", VA = "0x150530C")]
		public void SetEvent(EventInfo info, [Optional] object instance)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x150538C", Offset = "0x150538C", VA = "0x150538C", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x15055F4", Offset = "0x15055F4", VA = "0x15055F4")]
		public GetSharpEvent()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[DoNotList]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E0220", Offset = "0x9E0220")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E0220", Offset = "0x9E0220")]
	public class UnityEventAutoCallbackEvent : EventNode
	{
		[Token(Token = "0x200003A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0294", Offset = "0x9E0294")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000064")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			[Token(Token = "0x4000065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UnityEventAutoCallbackEvent <>4__this;

			[Token(Token = "0x600016E")]
			[Address(RVA = "0x26A89DC", Offset = "0x26A89DC", VA = "0x26A89DC")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x600016F")]
			[Address(RVA = "0x26A89E4", Offset = "0x26A89E4", VA = "0x26A89E4")]
			internal object <RegisterPorts>b__0()
			{
				return null;
			}
		}

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SerializedFieldInfo _field;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ReflectedUnityEvent reflectedEvent;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private UnityEventBase unityEvent;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ValueInput instancePort;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private FlowOutput callback;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private object[] args;

		[Token(Token = "0x1700003E")]
		private FieldInfo field
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x1453814", Offset = "0x1453814", VA = "0x1453814")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public override string name
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x145382C", Offset = "0x145382C", VA = "0x145382C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1453944", Offset = "0x1453944", VA = "0x1453944")]
		public void SetEvent(FieldInfo field, [Optional] object instance)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x14539C4", Offset = "0x14539C4", VA = "0x14539C4", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1453DB4", Offset = "0x1453DB4", VA = "0x1453DB4", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1453F84", Offset = "0x1453F84", VA = "0x1453F84", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1454034", Offset = "0x1454034", VA = "0x1454034")]
		private void OnEventRaised(params object[] args)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x14540A0", Offset = "0x14540A0", VA = "0x14540A0")]
		public UnityEventAutoCallbackEvent()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E02A4", Offset = "0x9E02A4")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E02A4", Offset = "0x9E02A4")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E02A4", Offset = "0x9E02A4")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E02A4", Offset = "0x9E02A4")]
	public class UnityEventCallbackEvent : EventNode
	{
		[Token(Token = "0x200003C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E03A8", Offset = "0x9E03A8")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x400006C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			[Token(Token = "0x400006D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UnityEventCallbackEvent <>4__this;

			[Token(Token = "0x600017C")]
			[Address(RVA = "0x26A8A2C", Offset = "0x26A8A2C", VA = "0x26A8A2C")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x600017D")]
			[Address(RVA = "0x26A8A34", Offset = "0x26A8A34", VA = "0x26A8A34")]
			internal object <RegisterPorts>b__0()
			{
				return null;
			}
		}

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[ExposeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9E93A4", Offset = "0x9E93A4")]
		[GatherPortsCallback]
		protected bool _autoHandleRegistration;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private SerializedTypeInfo _type;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private object[] argValues;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ValueInput eventInput;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private FlowOutput flowCallback;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ReflectedUnityEvent reflectedEvent;

		[Token(Token = "0x17000040")]
		private Type eventType
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x14540A8", Offset = "0x14540A8", VA = "0x14540A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x14540C0", Offset = "0x14540C0", VA = "0x14540C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public bool autoHandleRegistration
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x1454190", Offset = "0x1454190", VA = "0x1454190")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1454198", Offset = "0x1454198", VA = "0x1454198", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x14542F0", Offset = "0x14542F0", VA = "0x14542F0", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1454404", Offset = "0x1454404", VA = "0x1454404", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x14541A8", Offset = "0x14541A8", VA = "0x14541A8")]
		private void Register([Optional] Flow f)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1454300", Offset = "0x1454300", VA = "0x1454300")]
		private void Unregister([Optional] Flow f)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x14549A0", Offset = "0x14549A0", VA = "0x14549A0")]
		private void OnEventRaised(params object[] args)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1454A0C", Offset = "0x1454A0C", VA = "0x1454A0C", Slot = "39")]
		public override Type GetNodeWildDefinitionType()
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1454A84", Offset = "0x1454A84", VA = "0x1454A84", Slot = "36")]
		public override void OnPortConnected(Port port, Port otherPort)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1454BBC", Offset = "0x1454BBC", VA = "0x1454BBC")]
		public UnityEventCallbackEvent()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "ExecutionPriorityAttribute", RVA = "0x9E03B8", Offset = "0x9E03B8")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E03B8", Offset = "0x9E03B8")]
	[AttributeAttribute(Name = "ColorAttribute", RVA = "0x9E03B8", Offset = "0x9E03B8")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E03B8", Offset = "0x9E03B8")]
	public abstract class EventNode : FlowNode
	{
		[Token(Token = "0x17000042")]
		public override string name
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x135FD44", Offset = "0x135FD44", VA = "0x135FD44", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1358B00", Offset = "0x1358B00", VA = "0x1358B00")]
		protected EventNode()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E04A8", Offset = "0x9E04A8")]
	public abstract class EventNode<T> : EventNode where T : Component
	{
		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T> target;

		[Token(Token = "0x17000043")]
		public override string name
		{
			[Token(Token = "0x6000180")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000181")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x6000182")]
		protected void ResolveSelf()
		{
		}

		[Token(Token = "0x6000183")]
		protected EventNode()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E053C", Offset = "0x9E053C")]
	public abstract class MessageEventNode<T> : EventNode where T : Component
	{
		[Token(Token = "0x2000040")]
		public enum TargetMode
		{
			[Token(Token = "0x4000073")]
			SingleTarget,
			[Token(Token = "0x4000074")]
			MultipleTargets
		}

		[Token(Token = "0x2000041")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E05D0", Offset = "0x9E05D0")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000075")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GameObject receiver;

			[Token(Token = "0x600018A")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x600018B")]
			internal bool <ResolveReceiver>b__0(T t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TargetMode targetMode;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x9E9420", Offset = "0x9E9420")]
		public BBParameter<T> target;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x9E945C", Offset = "0x9E945C")]
		public BBParameter<List<T>> targets;

		[Token(Token = "0x17000044")]
		public override string name
		{
			[Token(Token = "0x6000184")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000185")]
		protected abstract string[] GetTargetMessageEvents();

		[Token(Token = "0x6000186")]
		public sealed override void OnGraphStarted()
		{
		}

		[Token(Token = "0x6000187")]
		public sealed override void OnGraphStoped()
		{
		}

		[Token(Token = "0x6000188")]
		protected T ResolveReceiver(GameObject receiver)
		{
			return null;
		}

		[Token(Token = "0x6000189")]
		protected MessageEventNode()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E05E0", Offset = "0x9E05E0")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E05E0", Offset = "0x9E05E0")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E05E0", Offset = "0x9E05E0")]
	[AttributeAttribute(Name = "ExecutionPriorityAttribute", RVA = "0x9E05E0", Offset = "0x9E05E0")]
	public class ConstructionEvent : EventNode
	{
		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FlowOutput awake;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool called;

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1365120", Offset = "0x1365120", VA = "0x1365120", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1365184", Offset = "0x1365184", VA = "0x1365184", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x13651F8", Offset = "0x13651F8", VA = "0x13651F8")]
		public ConstructionEvent()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "ExecutionPriorityAttribute", RVA = "0x9E067C", Offset = "0x9E067C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E067C", Offset = "0x9E067C")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E067C", Offset = "0x9E067C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E067C", Offset = "0x9E067C")]
	public class DisableEvent : EventNode
	{
		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FlowOutput disable;

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1368AE8", Offset = "0x1368AE8", VA = "0x1368AE8", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1368B38", Offset = "0x1368B38", VA = "0x1368B38", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1368BAC", Offset = "0x1368BAC", VA = "0x1368BAC")]
		public DisableEvent()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E0718", Offset = "0x9E0718")]
	[AttributeAttribute(Name = "ExecutionPriorityAttribute", RVA = "0x9E0718", Offset = "0x9E0718")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E0718", Offset = "0x9E0718")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E0718", Offset = "0x9E0718")]
	public class EnableEvent : EventNode
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FlowOutput enable;

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1369008", Offset = "0x1369008", VA = "0x1369008", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1369058", Offset = "0x1369058", VA = "0x1369058", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x13690CC", Offset = "0x13690CC", VA = "0x13690CC")]
		public EnableEvent()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E07B4", Offset = "0x9E07B4")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E07B4", Offset = "0x9E07B4")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E07B4", Offset = "0x9E07B4")]
	[AttributeAttribute(Name = "ExecutionPriorityAttribute", RVA = "0x9E07B4", Offset = "0x9E07B4")]
	public class FixedUpdateEvent : EventNode
	{
		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FlowOutput fixedUpdate;

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x136A7E4", Offset = "0x136A7E4", VA = "0x136A7E4", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x136A858", Offset = "0x136A858", VA = "0x136A858", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x136A8F8", Offset = "0x136A8F8", VA = "0x136A8F8", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x136A998", Offset = "0x136A998", VA = "0x136A998")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x136A9E8", Offset = "0x136A9E8", VA = "0x136A9E8")]
		public FixedUpdateEvent()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E0850", Offset = "0x9E0850")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E0850", Offset = "0x9E0850")]
	[AttributeAttribute(Name = "ExecutionPriorityAttribute", RVA = "0x9E0850", Offset = "0x9E0850")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E0850", Offset = "0x9E0850")]
	public class LateUpdateEvent : EventNode
	{
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FlowOutput lateUpdate;

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x15119D0", Offset = "0x15119D0", VA = "0x15119D0", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1511A48", Offset = "0x1511A48", VA = "0x1511A48", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1511B80", Offset = "0x1511B80", VA = "0x1511B80", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1511CB8", Offset = "0x1511CB8", VA = "0x1511CB8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1511D0C", Offset = "0x1511D0C", VA = "0x1511D0C")]
		public LateUpdateEvent()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E08EC", Offset = "0x9E08EC")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E08EC", Offset = "0x9E08EC")]
	[AttributeAttribute(Name = "ExecutionPriorityAttribute", RVA = "0x9E08EC", Offset = "0x9E08EC")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E08EC", Offset = "0x9E08EC")]
	public class StartEvent : EventNode
	{
		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FlowOutput start;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool called;

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1BC139C", Offset = "0x1BC139C", VA = "0x1BC139C", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1BC1404", Offset = "0x1BC1404", VA = "0x1BC1404", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1BC147C", Offset = "0x1BC147C", VA = "0x1BC147C")]
		public StartEvent()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E0988", Offset = "0x9E0988")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E0988", Offset = "0x9E0988")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E0988", Offset = "0x9E0988")]
	[AttributeAttribute(Name = "ExecutionPriorityAttribute", RVA = "0x9E0988", Offset = "0x9E0988")]
	public class UpdateEvent : EventNode, IUpdatable
	{
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public BBParameter<float> updateInterval;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FlowOutput update;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float lastUpdatedTime;

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1454F84", Offset = "0x1454F84", VA = "0x1454F84", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1454FFC", Offset = "0x1454FFC", VA = "0x1454FFC", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1455008", Offset = "0x1455008", VA = "0x1455008", Slot = "40")]
		public void Update()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x145511C", Offset = "0x145511C", VA = "0x145511C")]
		public UpdateEvent()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E0A24", Offset = "0x9E0A24")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E0A24", Offset = "0x9E0A24")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E0A24", Offset = "0x9E0A24")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E0A24", Offset = "0x9E0A24")]
	public class InputAxisEvent : EventNode, IUpdatable
	{
		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FlowOutput o;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float horizontal;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float vertical;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool calledLastFrame;

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x150F134", Offset = "0x150F134", VA = "0x150F134", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x150F2B0", Offset = "0x150F2B0", VA = "0x150F2B0", Slot = "40")]
		public void Update()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x150F3E4", Offset = "0x150F3E4", VA = "0x150F3E4")]
		public InputAxisEvent()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x150F3EC", Offset = "0x150F3EC", VA = "0x150F3EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA794", Offset = "0x9EA794")]
		private float <RegisterPorts>b__4_0()
		{
			return default(float);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x150F3F4", Offset = "0x150F3F4", VA = "0x150F3F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA7A4", Offset = "0x9EA7A4")]
		private float <RegisterPorts>b__4_1()
		{
			return default(float);
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E0AD0", Offset = "0x9E0AD0")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E0AD0", Offset = "0x9E0AD0")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E0AD0", Offset = "0x9E0AD0")]
	public class InputButtonEvents : EventNode, IUpdatable
	{
		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0x9E9498", Offset = "0x9E9498")]
		public BBParameter<string> buttonName;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FlowOutput down;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private FlowOutput up;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FlowOutput pressed;

		[Token(Token = "0x17000045")]
		public override string name
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x150F3FC", Offset = "0x150F3FC", VA = "0x150F3FC", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x150F460", Offset = "0x150F460", VA = "0x150F460", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x150F548", Offset = "0x150F548", VA = "0x150F548", Slot = "40")]
		public void Update()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x150F674", Offset = "0x150F674", VA = "0x150F674")]
		public InputButtonEvents()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E0B58", Offset = "0x9E0B58")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E0B58", Offset = "0x9E0B58")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E0B58", Offset = "0x9E0B58")]
	public class InputCustomAxisEvent : EventNode, IUpdatable
	{
		[Token(Token = "0x200004C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0BE0", Offset = "0x9E0BE0")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400008D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			[Token(Token = "0x400008E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InputCustomAxisEvent <>4__this;

			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x1469E6C", Offset = "0x1469E6C", VA = "0x1469E6C")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x1469E74", Offset = "0x1469E74", VA = "0x1469E74")]
			internal float <RegisterPorts>b__0()
			{
				return default(float);
			}
		}

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public BBParameter<List<string>> axis;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float[] axisValues;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool calledLastFrame;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FlowOutput o;

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x150F6F0", Offset = "0x150F6F0", VA = "0x150F6F0", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x150F990", Offset = "0x150F990", VA = "0x150F990", Slot = "40")]
		public void Update()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x150FB4C", Offset = "0x150FB4C", VA = "0x150FB4C")]
		public InputCustomAxisEvent()
		{
		}
	}
	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E0BF0", Offset = "0x9E0BF0")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E0BF0", Offset = "0x9E0BF0")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E0BF0", Offset = "0x9E0BF0")]
	public class KeyboardEvents : EventNode, IUpdatable
	{
		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public BBParameter<KeyCode> keyCode;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FlowOutput down;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private FlowOutput up;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FlowOutput pressed;

		[Token(Token = "0x17000046")]
		public override string name
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x1510C68", Offset = "0x1510C68", VA = "0x1510C68", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1510CCC", Offset = "0x1510CCC", VA = "0x1510CCC", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1510DB4", Offset = "0x1510DB4", VA = "0x1510DB4", Slot = "40")]
		public void Update()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1510EE0", Offset = "0x1510EE0", VA = "0x1510EE0")]
		public KeyboardEvents()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E0C78", Offset = "0x9E0C78")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E0C78", Offset = "0x9E0C78")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E0C78", Offset = "0x9E0C78")]
	public class MouseEvents : EventNode, IUpdatable
	{
		[Token(Token = "0x200004F")]
		public enum ButtonKeys
		{
			[Token(Token = "0x4000098")]
			Left,
			[Token(Token = "0x4000099")]
			Right,
			[Token(Token = "0x400009A")]
			Middle
		}

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public BBParameter<ButtonKeys> buttonKey;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FlowOutput down;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private FlowOutput pressed;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FlowOutput up;

		[Token(Token = "0x17000047")]
		public override string name
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x1519688", Offset = "0x1519688", VA = "0x1519688", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x15196EC", Offset = "0x15196EC", VA = "0x15196EC", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x15197D4", Offset = "0x15197D4", VA = "0x15197D4", Slot = "40")]
		public void Update()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1519900", Offset = "0x1519900", VA = "0x1519900")]
		public MouseEvents()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E0D00", Offset = "0x9E0D00")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E0D00", Offset = "0x9E0D00")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E0D00", Offset = "0x9E0D00")]
	public class MousePickEvent : EventNode, IUpdatable
	{
		[Token(Token = "0x2000051")]
		public enum ButtonKeys
		{
			[Token(Token = "0x40000A0")]
			Left,
			[Token(Token = "0x40000A1")]
			Right,
			[Token(Token = "0x40000A2")]
			Middle
		}

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public BBParameter<ButtonKeys> buttonKey;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public BBParameter<LayerMask> mask;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private FlowOutput o;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RaycastHit hit;

		[Token(Token = "0x17000048")]
		public override string name
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x1519908", Offset = "0x1519908", VA = "0x1519908", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x151996C", Offset = "0x151996C", VA = "0x151996C", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x1519A84", Offset = "0x1519A84", VA = "0x1519A84", Slot = "40")]
		public void Update()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1519BBC", Offset = "0x1519BBC", VA = "0x1519BBC")]
		public MousePickEvent()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1519C60", Offset = "0x1519C60", VA = "0x1519C60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA7B4", Offset = "0x9EA7B4")]
		private RaycastHit <RegisterPorts>b__7_0()
		{
			return default(RaycastHit);
		}
	}
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E0D88", Offset = "0x9E0D88")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E0D88", Offset = "0x9E0D88")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E0D88", Offset = "0x9E0D88")]
	public class AnimatorEvents : MessageEventNode<Animator>
	{
		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FlowOutput onAnimatorMove;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private FlowOutput onAnimatorIK;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Animator receiver;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int layerIndex;

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1357E0C", Offset = "0x1357E0C", VA = "0x1357E0C", Slot = "40")]
		protected override string[] GetTargetMessageEvents()
		{
			return null;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1357F1C", Offset = "0x1357F1C", VA = "0x1357F1C", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x13580FC", Offset = "0x13580FC", VA = "0x13580FC")]
		private void OnAnimatorMove(MessageRouter.MessageData msg)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x13581B0", Offset = "0x13581B0", VA = "0x13581B0")]
		private void OnAnimatorIK(MessageRouter.MessageData<int> msg)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1358278", Offset = "0x1358278", VA = "0x1358278")]
		public AnimatorEvents()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x13582C4", Offset = "0x13582C4", VA = "0x13582C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA7C4", Offset = "0x9EA7C4")]
		private Animator <RegisterPorts>b__5_0()
		{
			return null;
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x13582CC", Offset = "0x13582CC", VA = "0x13582CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA7D4", Offset = "0x9EA7D4")]
		private int <RegisterPorts>b__5_1()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E0E10", Offset = "0x9E0E10")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E0E10", Offset = "0x9E0E10")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E0E10", Offset = "0x9E0E10")]
	public class CharacterControllerEvents : MessageEventNode<CharacterController>
	{
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FlowOutput onHit;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private CharacterController receiver;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ControllerColliderHit hitInfo;

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1361694", Offset = "0x1361694", VA = "0x1361694", Slot = "40")]
		protected override string[] GetTargetMessageEvents()
		{
			return null;
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1361754", Offset = "0x1361754", VA = "0x1361754", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1361A30", Offset = "0x1361A30", VA = "0x1361A30")]
		private void OnControllerColliderHit(MessageRouter.MessageData<ControllerColliderHit> msg)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1361B00", Offset = "0x1361B00", VA = "0x1361B00")]
		public CharacterControllerEvents()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1361B4C", Offset = "0x1361B4C", VA = "0x1361B4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA7E4", Offset = "0x9EA7E4")]
		private CharacterController <RegisterPorts>b__4_0()
		{
			return null;
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1361B54", Offset = "0x1361B54", VA = "0x1361B54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA7F4", Offset = "0x9EA7F4")]
		private GameObject <RegisterPorts>b__4_1()
		{
			return null;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1361B70", Offset = "0x1361B70", VA = "0x1361B70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA804", Offset = "0x9EA804")]
		private Vector3 <RegisterPorts>b__4_2()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1361B8C", Offset = "0x1361B8C", VA = "0x1361B8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA814", Offset = "0x9EA814")]
		private ControllerColliderHit <RegisterPorts>b__4_3()
		{
			return null;
		}
	}
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E0E98", Offset = "0x9E0E98")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E0E98", Offset = "0x9E0E98")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E0E98", Offset = "0x9E0E98")]
	public class Collision2DEvents : MessageEventNode<Collider2D>
	{
		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FlowOutput onEnter;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private FlowOutput onStay;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private FlowOutput onExit;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Collider2D receiver;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Collision2D collision;

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x136237C", Offset = "0x136237C", VA = "0x136237C", Slot = "40")]
		protected override string[] GetTargetMessageEvents()
		{
			return null;
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x13624DC", Offset = "0x13624DC", VA = "0x13624DC", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1362820", Offset = "0x1362820", VA = "0x1362820")]
		private void OnCollisionEnter2D(MessageRouter.MessageData<Collision2D> msg)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x13628F0", Offset = "0x13628F0", VA = "0x13628F0")]
		private void OnCollisionStay2D(MessageRouter.MessageData<Collision2D> msg)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x13629C0", Offset = "0x13629C0", VA = "0x13629C0")]
		private void OnCollisionExit2D(MessageRouter.MessageData<Collision2D> msg)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1362A90", Offset = "0x1362A90", VA = "0x1362A90")]
		public Collision2DEvents()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1362ADC", Offset = "0x1362ADC", VA = "0x1362ADC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA824", Offset = "0x9EA824")]
		private Collider2D <RegisterPorts>b__6_0()
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1362AE4", Offset = "0x1362AE4", VA = "0x1362AE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA834", Offset = "0x9EA834")]
		private GameObject <RegisterPorts>b__6_1()
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1362B00", Offset = "0x1362B00", VA = "0x1362B00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA844", Offset = "0x9EA844")]
		private ContactPoint2D <RegisterPorts>b__6_2()
		{
			return default(ContactPoint2D);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1362B60", Offset = "0x1362B60", VA = "0x1362B60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA854", Offset = "0x9EA854")]
		private Collision2D <RegisterPorts>b__6_3()
		{
			return null;
		}
	}
	[Token(Token = "0x2000055")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E0F20", Offset = "0x9E0F20")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E0F20", Offset = "0x9E0F20")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E0F20", Offset = "0x9E0F20")]
	public class CollisionEvents : MessageEventNode<Collider>
	{
		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FlowOutput onEnter;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private FlowOutput onStay;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private FlowOutput onExit;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Collider receiver;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Collision collision;

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1362B68", Offset = "0x1362B68", VA = "0x1362B68", Slot = "40")]
		protected override string[] GetTargetMessageEvents()
		{
			return null;
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1362CC8", Offset = "0x1362CC8", VA = "0x1362CC8", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x136300C", Offset = "0x136300C", VA = "0x136300C")]
		private void OnCollisionEnter(MessageRouter.MessageData<Collision> msg)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x13630DC", Offset = "0x13630DC", VA = "0x13630DC")]
		private void OnCollisionStay(MessageRouter.MessageData<Collision> msg)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x13631AC", Offset = "0x13631AC", VA = "0x13631AC")]
		private void OnCollisionExit(MessageRouter.MessageData<Collision> msg)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x136327C", Offset = "0x136327C", VA = "0x136327C")]
		public CollisionEvents()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x13632C8", Offset = "0x13632C8", VA = "0x13632C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA864", Offset = "0x9EA864")]
		private Collider <RegisterPorts>b__6_0()
		{
			return null;
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x13632D0", Offset = "0x13632D0", VA = "0x13632D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA874", Offset = "0x9EA874")]
		private GameObject <RegisterPorts>b__6_1()
		{
			return null;
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x13632EC", Offset = "0x13632EC", VA = "0x13632EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA884", Offset = "0x9EA884")]
		private ContactPoint <RegisterPorts>b__6_2()
		{
			return default(ContactPoint);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1363344", Offset = "0x1363344", VA = "0x1363344")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA894", Offset = "0x9EA894")]
		private Collision <RegisterPorts>b__6_3()
		{
			return null;
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E0FA8", Offset = "0x9E0FA8")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E0FA8", Offset = "0x9E0FA8")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E0FA8", Offset = "0x9E0FA8")]
	public class MouseAgent2DEvents : MessageEventNode<Collider2D>
	{
		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FlowOutput onEnter;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private FlowOutput onOver;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private FlowOutput onExit;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private FlowOutput onDown;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private FlowOutput onUp;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private FlowOutput onDrag;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Collider2D receiver;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RaycastHit2D hit;

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1518034", Offset = "0x1518034", VA = "0x1518034", Slot = "40")]
		protected override string[] GetTargetMessageEvents()
		{
			return null;
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1518284", Offset = "0x1518284", VA = "0x1518284", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x151854C", Offset = "0x151854C", VA = "0x151854C")]
		private void OnMouseEnter(MessageRouter.MessageData msg)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1518784", Offset = "0x1518784", VA = "0x1518784")]
		private void OnMouseOver(MessageRouter.MessageData msg)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1518844", Offset = "0x1518844", VA = "0x1518844")]
		private void OnMouseExit(MessageRouter.MessageData msg)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1518904", Offset = "0x1518904", VA = "0x1518904")]
		private void OnMouseDown(MessageRouter.MessageData msg)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x15189C4", Offset = "0x15189C4", VA = "0x15189C4")]
		private void OnMouseUp(MessageRouter.MessageData msg)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1518A84", Offset = "0x1518A84", VA = "0x1518A84")]
		private void OnMouseDrag(MessageRouter.MessageData msg)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x151860C", Offset = "0x151860C", VA = "0x151860C")]
		private void StoreHit()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x1518B44", Offset = "0x1518B44", VA = "0x1518B44")]
		public MouseAgent2DEvents()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1518B90", Offset = "0x1518B90", VA = "0x1518B90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA8A4", Offset = "0x9EA8A4")]
		private Collider2D <RegisterPorts>b__9_0()
		{
			return null;
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x1518B98", Offset = "0x1518B98", VA = "0x1518B98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA8B4", Offset = "0x9EA8B4")]
		private RaycastHit2D <RegisterPorts>b__9_1()
		{
			return default(RaycastHit2D);
		}
	}
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E1030", Offset = "0x9E1030")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E1030", Offset = "0x9E1030")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E1030", Offset = "0x9E1030")]
	public class MouseAgentEvents : MessageEventNode<Collider>
	{
		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FlowOutput onEnter;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private FlowOutput onOver;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private FlowOutput onExit;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private FlowOutput onDown;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private FlowOutput onUp;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private FlowOutput onDrag;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Collider receiver;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RaycastHit hit;

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1518BAC", Offset = "0x1518BAC", VA = "0x1518BAC", Slot = "40")]
		protected override string[] GetTargetMessageEvents()
		{
			return null;
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1518DFC", Offset = "0x1518DFC", VA = "0x1518DFC", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x15190C4", Offset = "0x15190C4", VA = "0x15190C4")]
		private void OnMouseEnter(MessageRouter.MessageData msg)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1519260", Offset = "0x1519260", VA = "0x1519260")]
		private void OnMouseOver(MessageRouter.MessageData msg)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1519320", Offset = "0x1519320", VA = "0x1519320")]
		private void OnMouseExit(MessageRouter.MessageData msg)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x15193E0", Offset = "0x15193E0", VA = "0x15193E0")]
		private void OnMouseDown(MessageRouter.MessageData msg)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x15194A0", Offset = "0x15194A0", VA = "0x15194A0")]
		private void OnMouseUp(MessageRouter.MessageData msg)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1519560", Offset = "0x1519560", VA = "0x1519560")]
		private void OnMouseDrag(MessageRouter.MessageData msg)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1519184", Offset = "0x1519184", VA = "0x1519184")]
		private void StoreHit()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1519620", Offset = "0x1519620", VA = "0x1519620")]
		public MouseAgentEvents()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x151966C", Offset = "0x151966C", VA = "0x151966C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA8C4", Offset = "0x9EA8C4")]
		private Collider <RegisterPorts>b__9_0()
		{
			return null;
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1519674", Offset = "0x1519674", VA = "0x1519674")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA8D4", Offset = "0x9EA8D4")]
		private RaycastHit <RegisterPorts>b__9_1()
		{
			return default(RaycastHit);
		}
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E10B8", Offset = "0x9E10B8")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E10B8", Offset = "0x9E10B8")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E10B8", Offset = "0x9E10B8")]
	public class ObjectStateEvents : MessageEventNode<Transform>
	{
		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FlowOutput onEnable;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private FlowOutput onDisable;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private FlowOutput onDestroy;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private GameObject receiver;

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x151BF90", Offset = "0x151BF90", VA = "0x151BF90", Slot = "40")]
		protected override string[] GetTargetMessageEvents()
		{
			return null;
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x151C0F0", Offset = "0x151C0F0", VA = "0x151C0F0", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x151C278", Offset = "0x151C278", VA = "0x151C278")]
		private void OnEnable(MessageRouter.MessageData msg)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x151C33C", Offset = "0x151C33C", VA = "0x151C33C")]
		private void OnDisable(MessageRouter.MessageData msg)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x151C400", Offset = "0x151C400", VA = "0x151C400")]
		private void OnDestroy(MessageRouter.MessageData msg)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x151C4C4", Offset = "0x151C4C4", VA = "0x151C4C4")]
		public ObjectStateEvents()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x151C510", Offset = "0x151C510", VA = "0x151C510")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA8E4", Offset = "0x9EA8E4")]
		private GameObject <RegisterPorts>b__5_0()
		{
			return null;
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E1140", Offset = "0x9E1140")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E1140", Offset = "0x9E1140")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E1140", Offset = "0x9E1140")]
	public class ParticleCollision2DEvents : MessageEventNode<Collider2D>
	{
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FlowOutput onCollision;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Collider2D receiver;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ParticleSystem particle;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<ParticleCollisionEvent> collisionEvents;

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x151CEC4", Offset = "0x151CEC4", VA = "0x151CEC4", Slot = "40")]
		protected override string[] GetTargetMessageEvents()
		{
			return null;
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x151CF84", Offset = "0x151CF84", VA = "0x151CF84", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x151D28C", Offset = "0x151D28C", VA = "0x151D28C")]
		private void OnParticleCollision(MessageRouter.MessageData<GameObject> msg)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x151D450", Offset = "0x151D450", VA = "0x151D450")]
		public ParticleCollision2DEvents()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x151D49C", Offset = "0x151D49C", VA = "0x151D49C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA8F4", Offset = "0x9EA8F4")]
		private Collider2D <RegisterPorts>b__5_0()
		{
			return null;
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x151D4A4", Offset = "0x151D4A4", VA = "0x151D4A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA904", Offset = "0x9EA904")]
		private ParticleSystem <RegisterPorts>b__5_1()
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x151D4AC", Offset = "0x151D4AC", VA = "0x151D4AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA914", Offset = "0x9EA914")]
		private Vector3 <RegisterPorts>b__5_2()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x151D538", Offset = "0x151D538", VA = "0x151D538")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA924", Offset = "0x9EA924")]
		private Vector3 <RegisterPorts>b__5_3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x151D5C4", Offset = "0x151D5C4", VA = "0x151D5C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA934", Offset = "0x9EA934")]
		private Vector3 <RegisterPorts>b__5_4()
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E11C8", Offset = "0x9E11C8")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E11C8", Offset = "0x9E11C8")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E11C8", Offset = "0x9E11C8")]
	public class ParticleCollisionEvents : MessageEventNode<Collider>
	{
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FlowOutput onCollision;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Collider receiver;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ParticleSystem particle;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<ParticleCollisionEvent> collisionEvents;

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x151D650", Offset = "0x151D650", VA = "0x151D650", Slot = "40")]
		protected override string[] GetTargetMessageEvents()
		{
			return null;
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x151D710", Offset = "0x151D710", VA = "0x151D710", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x151DA18", Offset = "0x151DA18", VA = "0x151DA18")]
		private void OnParticleCollision(MessageRouter.MessageData<GameObject> msg)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x151DBDC", Offset = "0x151DBDC", VA = "0x151DBDC")]
		public ParticleCollisionEvents()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x151DC28", Offset = "0x151DC28", VA = "0x151DC28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA944", Offset = "0x9EA944")]
		private Collider <RegisterPorts>b__5_0()
		{
			return null;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x151DC30", Offset = "0x151DC30", VA = "0x151DC30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA954", Offset = "0x9EA954")]
		private ParticleSystem <RegisterPorts>b__5_1()
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x151DC38", Offset = "0x151DC38", VA = "0x151DC38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA964", Offset = "0x9EA964")]
		private Vector3 <RegisterPorts>b__5_2()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x151DCC4", Offset = "0x151DCC4", VA = "0x151DCC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA974", Offset = "0x9EA974")]
		private Vector3 <RegisterPorts>b__5_3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x151DD50", Offset = "0x151DD50", VA = "0x151DD50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA984", Offset = "0x9EA984")]
		private Vector3 <RegisterPorts>b__5_4()
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E1250", Offset = "0x9E1250")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E1250", Offset = "0x9E1250")]
	public class TransformEvents : MessageEventNode<Transform>
	{
		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FlowOutput onParentChanged;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private FlowOutput onChildrenChanged;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Transform receiver;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Transform parent;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private IEnumerable<Transform> children;

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1BC7050", Offset = "0x1BC7050", VA = "0x1BC7050", Slot = "40")]
		protected override string[] GetTargetMessageEvents()
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1BC7160", Offset = "0x1BC7160", VA = "0x1BC7160", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1BC73AC", Offset = "0x1BC73AC", VA = "0x1BC73AC")]
		private void OnTransformParentChanged(MessageRouter.MessageData msg)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1BC74B4", Offset = "0x1BC74B4", VA = "0x1BC74B4")]
		private void OnTransformChildrenChanged(MessageRouter.MessageData msg)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1BC75BC", Offset = "0x1BC75BC", VA = "0x1BC75BC")]
		public TransformEvents()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1BC7608", Offset = "0x1BC7608", VA = "0x1BC7608")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA994", Offset = "0x9EA994")]
		private Transform <RegisterPorts>b__6_0()
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1BC7610", Offset = "0x1BC7610", VA = "0x1BC7610")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA9A4", Offset = "0x9EA9A4")]
		private Transform <RegisterPorts>b__6_1()
		{
			return null;
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1BC7618", Offset = "0x1BC7618", VA = "0x1BC7618")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA9B4", Offset = "0x9EA9B4")]
		private IEnumerable<Transform> <RegisterPorts>b__6_2()
		{
			return null;
		}
	}
	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E12B0", Offset = "0x9E12B0")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E12B0", Offset = "0x9E12B0")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E12B0", Offset = "0x9E12B0")]
	public class Trigger2DEvents : MessageEventNode<Collider2D>
	{
		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FlowOutput onEnter;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private FlowOutput onStay;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private FlowOutput onExit;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Collider2D receiver;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private GameObject other;

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1BC7620", Offset = "0x1BC7620", VA = "0x1BC7620", Slot = "40")]
		protected override string[] GetTargetMessageEvents()
		{
			return null;
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1BC7780", Offset = "0x1BC7780", VA = "0x1BC7780", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1BC79A0", Offset = "0x1BC79A0", VA = "0x1BC79A0")]
		private void OnTriggerEnter2D(MessageRouter.MessageData<Collider2D> msg)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1BC7A84", Offset = "0x1BC7A84", VA = "0x1BC7A84")]
		private void OnTriggerStay2D(MessageRouter.MessageData<Collider2D> msg)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1BC7B68", Offset = "0x1BC7B68", VA = "0x1BC7B68")]
		private void OnTriggerExit2D(MessageRouter.MessageData<Collider2D> msg)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1BC7C4C", Offset = "0x1BC7C4C", VA = "0x1BC7C4C")]
		public Trigger2DEvents()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1BC7C98", Offset = "0x1BC7C98", VA = "0x1BC7C98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA9C4", Offset = "0x9EA9C4")]
		private Collider2D <RegisterPorts>b__6_0()
		{
			return null;
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1BC7CA0", Offset = "0x1BC7CA0", VA = "0x1BC7CA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA9D4", Offset = "0x9EA9D4")]
		private GameObject <RegisterPorts>b__6_1()
		{
			return null;
		}
	}
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E1338", Offset = "0x9E1338")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E1338", Offset = "0x9E1338")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E1338", Offset = "0x9E1338")]
	public class TriggerEvents : MessageEventNode<Collider>
	{
		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FlowOutput onEnter;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private FlowOutput onStay;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private FlowOutput onExit;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Collider receiver;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private GameObject other;

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1BC7CA8", Offset = "0x1BC7CA8", VA = "0x1BC7CA8", Slot = "40")]
		protected override string[] GetTargetMessageEvents()
		{
			return null;
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1BC7E08", Offset = "0x1BC7E08", VA = "0x1BC7E08", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1BC8028", Offset = "0x1BC8028", VA = "0x1BC8028")]
		private void OnTriggerEnter(MessageRouter.MessageData<Collider> msg)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1BC810C", Offset = "0x1BC810C", VA = "0x1BC810C")]
		private void OnTriggerStay(MessageRouter.MessageData<Collider> msg)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x1BC81F0", Offset = "0x1BC81F0", VA = "0x1BC81F0")]
		private void OnTriggerExit(MessageRouter.MessageData<Collider> msg)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1BC82D4", Offset = "0x1BC82D4", VA = "0x1BC82D4")]
		public TriggerEvents()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1BC8320", Offset = "0x1BC8320", VA = "0x1BC8320")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA9E4", Offset = "0x9EA9E4")]
		private Collider <RegisterPorts>b__6_0()
		{
			return null;
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1BC8328", Offset = "0x1BC8328", VA = "0x1BC8328")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA9F4", Offset = "0x9EA9F4")]
		private GameObject <RegisterPorts>b__6_1()
		{
			return null;
		}
	}
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E13C0", Offset = "0x9E13C0")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E13C0", Offset = "0x9E13C0")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E13C0", Offset = "0x9E13C0")]
	public class UIButtonEvent : EventNode<Button>
	{
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FlowOutput o;

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1450FF8", Offset = "0x1450FF8", VA = "0x1450FF8", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x14510F8", Offset = "0x14510F8", VA = "0x14510F8", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x14511D8", Offset = "0x14511D8", VA = "0x14511D8", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x14512F0", Offset = "0x14512F0", VA = "0x14512F0")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1451344", Offset = "0x1451344", VA = "0x1451344")]
		public UIButtonEvent()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1451390", Offset = "0x1451390", VA = "0x1451390")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAA04", Offset = "0x9EAA04")]
		private Button <RegisterPorts>b__3_0()
		{
			return null;
		}
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E1448", Offset = "0x9E1448")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E1448", Offset = "0x9E1448")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E1448", Offset = "0x9E1448")]
	public class UIDropdownEvent : EventNode<Dropdown>
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FlowOutput o;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int value;

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x14513E4", Offset = "0x14513E4", VA = "0x14513E4", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x145150C", Offset = "0x145150C", VA = "0x145150C", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1451614", Offset = "0x1451614", VA = "0x1451614", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x14517C4", Offset = "0x14517C4", VA = "0x14517C4")]
		private void OnValueChanged(int value)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x145181C", Offset = "0x145181C", VA = "0x145181C")]
		public UIDropdownEvent()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1451868", Offset = "0x1451868", VA = "0x1451868")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAA14", Offset = "0x9EAA14")]
		private Dropdown <RegisterPorts>b__4_0()
		{
			return null;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x14518BC", Offset = "0x14518BC", VA = "0x14518BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAA24", Offset = "0x9EAA24")]
		private int <RegisterPorts>b__4_1()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E14D0", Offset = "0x9E14D0")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E14D0", Offset = "0x9E14D0")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E14D0", Offset = "0x9E14D0")]
	public class UIInputFieldEvent : EventNode<InputField>
	{
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FlowOutput onValueChanged;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private FlowOutput onEndEdit;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private string value;

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x14518C4", Offset = "0x14518C4", VA = "0x14518C4", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1451A60", Offset = "0x1451A60", VA = "0x1451A60", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1451BDC", Offset = "0x1451BDC", VA = "0x1451BDC", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1451DC4", Offset = "0x1451DC4", VA = "0x1451DC4")]
		private void OnValueChanged(string value)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1451E30", Offset = "0x1451E30", VA = "0x1451E30")]
		private void OnEndEdit(string value)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1451E9C", Offset = "0x1451E9C", VA = "0x1451E9C")]
		public UIInputFieldEvent()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1451EE8", Offset = "0x1451EE8", VA = "0x1451EE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAA34", Offset = "0x9EAA34")]
		private InputField <RegisterPorts>b__5_0()
		{
			return null;
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1451F3C", Offset = "0x1451F3C", VA = "0x1451F3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAA44", Offset = "0x9EAA44")]
		private string <RegisterPorts>b__5_1()
		{
			return null;
		}
	}
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E1558", Offset = "0x9E1558")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E1558", Offset = "0x9E1558")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E1558", Offset = "0x9E1558")]
	public class UIPointerEvents : MessageEventNode<Transform>
	{
		[Token(Token = "0x2000062")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E15E0", Offset = "0x9E15E0")]
		private sealed class <UpdatePressed>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIPointerEvents <>4__this;

			[Token(Token = "0x17000049")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000250")]
				[Address(RVA = "0x26A898C", Offset = "0x26A898C", VA = "0x26A898C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000252")]
				[Address(RVA = "0x26A89D4", Offset = "0x26A89D4", VA = "0x26A89D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600024D")]
			[Address(RVA = "0x26A88B8", Offset = "0x26A88B8", VA = "0x26A88B8")]
			[DebuggerHidden]
			public <UpdatePressed>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x600024E")]
			[Address(RVA = "0x26A88E4", Offset = "0x26A88E4", VA = "0x26A88E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600024F")]
			[Address(RVA = "0x26A88E8", Offset = "0x26A88E8", VA = "0x26A88E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000251")]
			[Address(RVA = "0x26A8994", Offset = "0x26A8994", VA = "0x26A8994", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FlowOutput onPointerDown;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private FlowOutput onPointerPressed;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private FlowOutput onPointerUp;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private FlowOutput onPointerEnter;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private FlowOutput onPointerExit;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private FlowOutput onPointerClick;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private GameObject receiver;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private PointerEventData eventData;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool updatePressed;

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1451F44", Offset = "0x1451F44", VA = "0x1451F44", Slot = "40")]
		protected override string[] GetTargetMessageEvents()
		{
			return null;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1452144", Offset = "0x1452144", VA = "0x1452144", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x145240C", Offset = "0x145240C", VA = "0x145240C")]
		private void OnPointerDown(MessageRouter.MessageData<PointerEventData> msg)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1452588", Offset = "0x1452588", VA = "0x1452588")]
		private void OnPointerUp(MessageRouter.MessageData<PointerEventData> msg)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1452510", Offset = "0x1452510", VA = "0x1452510")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9EAA54", Offset = "0x9EAA54")]
		private IEnumerator UpdatePressed()
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1452670", Offset = "0x1452670", VA = "0x1452670")]
		private void OnPointerEnter(MessageRouter.MessageData<PointerEventData> msg)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1452750", Offset = "0x1452750", VA = "0x1452750")]
		private void OnPointerExit(MessageRouter.MessageData<PointerEventData> msg)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1452830", Offset = "0x1452830", VA = "0x1452830")]
		private void OnPointerClick(MessageRouter.MessageData<PointerEventData> msg)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1452910", Offset = "0x1452910", VA = "0x1452910")]
		public UIPointerEvents()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x145295C", Offset = "0x145295C", VA = "0x145295C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAAB4", Offset = "0x9EAAB4")]
		private GameObject <RegisterPorts>b__10_0()
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1452964", Offset = "0x1452964", VA = "0x1452964")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAAC4", Offset = "0x9EAAC4")]
		private PointerEventData <RegisterPorts>b__10_1()
		{
			return null;
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E15F0", Offset = "0x9E15F0")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E15F0", Offset = "0x9E15F0")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E15F0", Offset = "0x9E15F0")]
	public class UIScrollbarEvent : EventNode<Scrollbar>
	{
		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FlowOutput o;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float value;

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x145296C", Offset = "0x145296C", VA = "0x145296C", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1452A94", Offset = "0x1452A94", VA = "0x1452A94", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1452B9C", Offset = "0x1452B9C", VA = "0x1452B9C", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1452D4C", Offset = "0x1452D4C", VA = "0x1452D4C")]
		private void OnValueChanged(float value)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1452DA4", Offset = "0x1452DA4", VA = "0x1452DA4")]
		public UIScrollbarEvent()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1452DF0", Offset = "0x1452DF0", VA = "0x1452DF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAB24", Offset = "0x9EAB24")]
		private Scrollbar <RegisterPorts>b__4_0()
		{
			return null;
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1452E44", Offset = "0x1452E44", VA = "0x1452E44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAB34", Offset = "0x9EAB34")]
		private float <RegisterPorts>b__4_1()
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E1678", Offset = "0x9E1678")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E1678", Offset = "0x9E1678")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E1678", Offset = "0x9E1678")]
	public class UISliderEvent : EventNode<Slider>
	{
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FlowOutput o;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float value;

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1452E4C", Offset = "0x1452E4C", VA = "0x1452E4C", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1452F74", Offset = "0x1452F74", VA = "0x1452F74", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x145307C", Offset = "0x145307C", VA = "0x145307C", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x145322C", Offset = "0x145322C", VA = "0x145322C")]
		private void OnValueChanged(float value)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1453284", Offset = "0x1453284", VA = "0x1453284")]
		public UISliderEvent()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x14532D0", Offset = "0x14532D0", VA = "0x14532D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAB44", Offset = "0x9EAB44")]
		private Slider <RegisterPorts>b__4_0()
		{
			return null;
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1453324", Offset = "0x1453324", VA = "0x1453324")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAB54", Offset = "0x9EAB54")]
		private float <RegisterPorts>b__4_1()
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E1700", Offset = "0x9E1700")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E1700", Offset = "0x9E1700")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E1700", Offset = "0x9E1700")]
	public class UIToggleEvent : EventNode<UnityEngine.UI.Toggle>
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FlowOutput o;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool state;

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x145332C", Offset = "0x145332C", VA = "0x145332C", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1453454", Offset = "0x1453454", VA = "0x1453454", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x145355C", Offset = "0x145355C", VA = "0x145355C", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x145370C", Offset = "0x145370C", VA = "0x145370C")]
		private void OnValueChanged(bool state)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x145376C", Offset = "0x145376C", VA = "0x145376C")]
		public UIToggleEvent()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x14537B8", Offset = "0x14537B8", VA = "0x14537B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAB64", Offset = "0x9EAB64")]
		private UnityEngine.UI.Toggle <RegisterPorts>b__4_0()
		{
			return null;
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x145380C", Offset = "0x145380C", VA = "0x145380C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAB74", Offset = "0x9EAB74")]
		private bool <RegisterPorts>b__4_1()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E1788", Offset = "0x9E1788")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E1788", Offset = "0x9E1788")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E1788", Offset = "0x9E1788")]
	public class VisibilityEvents : MessageEventNode<Transform>
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FlowOutput onVisible;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private FlowOutput onInvisible;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GameObject receiver;

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x14567C0", Offset = "0x14567C0", VA = "0x14567C0", Slot = "40")]
		protected override string[] GetTargetMessageEvents()
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x14568D0", Offset = "0x14568D0", VA = "0x14568D0", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x1456A20", Offset = "0x1456A20", VA = "0x1456A20")]
		private void OnBecameVisible(MessageRouter.MessageData msg)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1456AE4", Offset = "0x1456AE4", VA = "0x1456AE4")]
		private void OnBecameInvisible(MessageRouter.MessageData msg)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1456BA8", Offset = "0x1456BA8", VA = "0x1456BA8")]
		public VisibilityEvents()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1456BF4", Offset = "0x1456BF4", VA = "0x1456BF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAB84", Offset = "0x9EAB84")]
		private GameObject <RegisterPorts>b__4_0()
		{
			return null;
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E1810", Offset = "0x9E1810")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E1810", Offset = "0x9E1810")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E1810", Offset = "0x9E1810")]
	public class ConditionalUpdateEvent : EventNode, IUpdatable
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FlowOutput becameTrue;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FlowOutput becameFalse;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ValueInput<bool> condition;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool lastState;

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1364810", Offset = "0x1364810", VA = "0x1364810", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1364904", Offset = "0x1364904", VA = "0x1364904", Slot = "40")]
		public void Update()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x13649EC", Offset = "0x13649EC", VA = "0x13649EC")]
		public ConditionalUpdateEvent()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E1898", Offset = "0x9E1898")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E1898", Offset = "0x9E1898")]
	public class DebugEvent : EventNode, IUpdatable
	{
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1368190", Offset = "0x1368190", VA = "0x1368190", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x13681F4", Offset = "0x13681F4", VA = "0x13681F4", Slot = "40")]
		public void Update()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x13681F8", Offset = "0x13681F8", VA = "0x13681F8")]
		public DebugEvent()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E18F8", Offset = "0x9E18F8")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E18F8", Offset = "0x9E18F8")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E18F8", Offset = "0x9E18F8")]
	public class OscillatorEvent : EventNode, IUpdatable
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public BBParameter<AnimationCurve> curve;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float time;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float value;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private FlowOutput hi;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private FlowOutput low;

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x151C87C", Offset = "0x151C87C", VA = "0x151C87C")]
		public OscillatorEvent()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x151CAAC", Offset = "0x151CAAC", VA = "0x151CAAC", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x151CBFC", Offset = "0x151CBFC", VA = "0x151CBFC", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x151CC04", Offset = "0x151CC04", VA = "0x151CC04", Slot = "40")]
		public void Update()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x151CCF4", Offset = "0x151CCF4", VA = "0x151CCF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAB94", Offset = "0x9EAB94")]
		private float <RegisterPorts>b__6_0()
		{
			return default(float);
		}
	}
	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E1980", Offset = "0x9E1980")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E1980", Offset = "0x9E1980")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E1980", Offset = "0x9E1980")]
	public class VariableChangedEvent : EventNode
	{
		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[BlackboardOnly]
		public BBObjectParameter targetVariable;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FlowOutput fOut;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private object newValue;

		[Token(Token = "0x1700004B")]
		public override string name
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x1456148", Offset = "0x1456148", VA = "0x1456148", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x14561AC", Offset = "0x14561AC", VA = "0x14561AC", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1456268", Offset = "0x1456268", VA = "0x1456268", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1456324", Offset = "0x1456324", VA = "0x1456324", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1456444", Offset = "0x1456444", VA = "0x1456444")]
		private void OnValueChanged(string name, object value)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x14564B4", Offset = "0x14564B4", VA = "0x14564B4")]
		private void OnVariableRefChange(Variable newVarRef)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1456518", Offset = "0x1456518", VA = "0x1456518")]
		public VariableChangedEvent()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1456520", Offset = "0x1456520", VA = "0x1456520")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EABA4", Offset = "0x9EABA4")]
		private object <RegisterPorts>b__7_0()
		{
			return null;
		}
	}
	[Token(Token = "0x200006B")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E1A08", Offset = "0x9E1A08")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E1A08", Offset = "0x9E1A08")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E1A08", Offset = "0x9E1A08")]
	public class Chance : FlowControlNode
	{
		[Token(Token = "0x200006C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1AE4", Offset = "0x9E1AE4")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000106")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ValueInput<float> min;

			[Token(Token = "0x4000107")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ValueInput<float> max;

			[Token(Token = "0x4000108")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ValueInput<float> chance;

			[Token(Token = "0x4000109")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FlowOutput success;

			[Token(Token = "0x400010A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public FlowOutput failure;

			[Token(Token = "0x6000283")]
			[Address(RVA = "0x1467E90", Offset = "0x1467E90", VA = "0x1467E90")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000284")]
			[Address(RVA = "0x1467E98", Offset = "0x1467E98", VA = "0x1467E98")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1361434", Offset = "0x1361434", VA = "0x1361434", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1361690", Offset = "0x1361690", VA = "0x1361690")]
		public Chance()
		{
		}
	}
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E1AF4", Offset = "0x9E1AF4")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E1AF4", Offset = "0x9E1AF4")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E1AF4", Offset = "0x9E1AF4")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E1AF4", Offset = "0x9E1AF4")]
	public class Cooldown : FlowControlNode
	{
		[Token(Token = "0x200006E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1C18", Offset = "0x9E1C18")]
		private sealed class <CountDown>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000114")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Cooldown <>4__this;

			[Token(Token = "0x4000115")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Flow f;

			[Token(Token = "0x4000116")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float <total>5__2;

			[Token(Token = "0x1700004D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000292")]
				[Address(RVA = "0x1468314", Offset = "0x1468314", VA = "0x1468314", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000294")]
				[Address(RVA = "0x146835C", Offset = "0x146835C", VA = "0x146835C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600028F")]
			[Address(RVA = "0x14680F8", Offset = "0x14680F8", VA = "0x14680F8")]
			[DebuggerHidden]
			public <CountDown>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000290")]
			[Address(RVA = "0x1468124", Offset = "0x1468124", VA = "0x1468124", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000291")]
			[Address(RVA = "0x1468128", Offset = "0x1468128", VA = "0x1468128", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000293")]
			[Address(RVA = "0x146831C", Offset = "0x146831C", VA = "0x146831C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Coroutine coroutine;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float remaining;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float remainingNormalized;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private FlowOutput start;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private FlowOutput finish;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private FlowOutput update;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private ValueInput<float> time;

		[Token(Token = "0x1700004C")]
		public override string name
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x1365200", Offset = "0x1365200", VA = "0x1365200", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1365298", Offset = "0x1365298", VA = "0x1365298", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x13652A8", Offset = "0x13652A8", VA = "0x13652A8", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x13652EC", Offset = "0x13652EC", VA = "0x13652EC", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x136566C", Offset = "0x136566C", VA = "0x136566C")]
		private void Begin(Flow f)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1365794", Offset = "0x1365794", VA = "0x1365794")]
		private void Cancel(Flow f)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x13656F0", Offset = "0x13656F0", VA = "0x13656F0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9EABB4", Offset = "0x9EABB4")]
		private IEnumerator CountDown(Flow f)
		{
			return null;
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x13657D8", Offset = "0x13657D8", VA = "0x13657D8")]
		public Cooldown()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x13657DC", Offset = "0x13657DC", VA = "0x13657DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAC14", Offset = "0x9EAC14")]
		private float <RegisterPorts>b__11_0()
		{
			return default(float);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x13657EC", Offset = "0x13657EC", VA = "0x13657EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAC24", Offset = "0x9EAC24")]
		private float <RegisterPorts>b__11_1()
		{
			return default(float);
		}
	}
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E1C28", Offset = "0x9E1C28")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E1C28", Offset = "0x9E1C28")]
	public class DoOnce : FlowControlNode
	{
		[Token(Token = "0x2000070")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1C88", Offset = "0x9E1C88")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000118")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DoOnce <>4__this;

			[Token(Token = "0x4000119")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FlowOutput o;

			[Token(Token = "0x6000298")]
			[Address(RVA = "0x146889C", Offset = "0x146889C", VA = "0x146889C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000299")]
			[Address(RVA = "0x14688A4", Offset = "0x14688A4", VA = "0x14688A4")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}

			[Token(Token = "0x600029A")]
			[Address(RVA = "0x146890C", Offset = "0x146890C", VA = "0x146890C")]
			internal void <RegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool called;

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1368BBC", Offset = "0x1368BBC", VA = "0x1368BBC", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1368BC4", Offset = "0x1368BC4", VA = "0x1368BC4", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1368D64", Offset = "0x1368D64", VA = "0x1368D64")]
		public DoOnce()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E1C98", Offset = "0x9E1C98")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E1C98", Offset = "0x9E1C98")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E1C98", Offset = "0x9E1C98")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E1C98", Offset = "0x9E1C98")]
	public class ReadFlowParameter<T> : FlowControlNode
	{
		[Token(Token = "0x2000072")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1D9C", Offset = "0x9E1D9C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400011B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReadFlowParameter<T> <>4__this;

			[Token(Token = "0x400011C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<string> pName;

			[Token(Token = "0x400011D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x600029D")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600029E")]
			internal T <RegisterPorts>b__0()
			{
				return (T)null;
			}

			[Token(Token = "0x600029F")]
			internal void <RegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T flowValue;

		[Token(Token = "0x600029B")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600029C")]
		public ReadFlowParameter()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E1DAC", Offset = "0x9E1DAC")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E1DAC", Offset = "0x9E1DAC")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E1DAC", Offset = "0x9E1DAC")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E1DAC", Offset = "0x9E1DAC")]
	public class WriteFlowParameter<T> : FlowControlNode
	{
		[Token(Token = "0x2000074")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1EB0", Offset = "0x9E1EB0")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400011E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<string> pName;

			[Token(Token = "0x400011F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T> pValue;

			[Token(Token = "0x4000120")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x60002A2")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60002A3")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x60002A0")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60002A1")]
		public WriteFlowParameter()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E1EC0", Offset = "0x9E1EC0")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E1EC0", Offset = "0x9E1EC0")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E1EC0", Offset = "0x9E1EC0")]
	[AttributeAttribute(Name = "DeserializeFromAttribute", RVA = "0x9E1EC0", Offset = "0x9E1EC0")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E1EC0", Offset = "0x9E1EC0")]
	public class LatchBool : FlowControlNode
	{
		[Token(Token = "0x2000076")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E1FE8", Offset = "0x9E1FE8")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000122")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LatchBool <>4__this;

			[Token(Token = "0x4000123")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FlowOutput o;

			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x1469EBC", Offset = "0x1469EBC", VA = "0x1469EBC")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x1469EC4", Offset = "0x1469EC4", VA = "0x1469EC4")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}

			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x1469F24", Offset = "0x1469F24", VA = "0x1469F24")]
			internal void <RegisterPorts>b__1(Flow f)
			{
			}

			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x1469F80", Offset = "0x1469F80", VA = "0x1469F80")]
			internal bool <RegisterPorts>b__2()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool latched;

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1511548", Offset = "0x1511548", VA = "0x1511548", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1511774", Offset = "0x1511774", VA = "0x1511774")]
		public LatchBool()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E1FF8", Offset = "0x9E1FF8")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E1FF8", Offset = "0x9E1FF8")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E1FF8", Offset = "0x9E1FF8")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E1FF8", Offset = "0x9E1FF8")]
	public class LatchInt : FlowControlNode
	{
		[Token(Token = "0x2000078")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E20FC", Offset = "0x9E20FC")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000126")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LatchInt <>4__this;

			[Token(Token = "0x4000127")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FlowOutput o;

			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x1469F9C", Offset = "0x1469F9C", VA = "0x1469F9C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x1469FA4", Offset = "0x1469FA4", VA = "0x1469FA4")]
			internal int <RegisterPorts>b__0()
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000079")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E210C", Offset = "0x9E210C")]
		private sealed class <>c__DisplayClass2_1
		{
			[Token(Token = "0x4000128")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			[Token(Token = "0x4000129")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass2_0 CS$<>8__locals1;

			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x1469FC0", Offset = "0x1469FC0", VA = "0x1469FC0")]
			public <>c__DisplayClass2_1()
			{
			}

			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x1469FC8", Offset = "0x1469FC8", VA = "0x1469FC8")]
			internal void <RegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[DelayedField]
		[AttributeAttribute(Name = "MinValueAttribute", RVA = "0x9E94B8", Offset = "0x9E94B8")]
		[GatherPortsCallback]
		[ExposeField]
		[SerializeField]
		private int _portCount;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int latched;

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x151177C", Offset = "0x151177C", VA = "0x151177C", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x15119C0", Offset = "0x15119C0", VA = "0x15119C0")]
		public LatchInt()
		{
		}
	}
	[Token(Token = "0x200007A")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E211C", Offset = "0x9E211C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E211C", Offset = "0x9E211C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E211C", Offset = "0x9E211C")]
	public class ANDMerge : FlowControlNode
	{
		[Token(Token = "0x200007B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E21A4", Offset = "0x9E21A4")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400012E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			[Token(Token = "0x400012F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ANDMerge <>4__this;

			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x1467A98", Offset = "0x1467A98", VA = "0x1467A98")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x1467AA0", Offset = "0x1467AA0", VA = "0x1467AA0")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[DelayedField]
		[AttributeAttribute(Name = "MinValueAttribute", RVA = "0x9E9524", Offset = "0x9E9524")]
		[GatherPortsCallback]
		[ExposeField]
		private int _portCount;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private FlowOutput fOut;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int[] calls;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastFrameCall;

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x135605C", Offset = "0x135605C", VA = "0x135605C", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1356440", Offset = "0x1356440", VA = "0x1356440")]
		private void Check(int index, Flow f)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x13565C4", Offset = "0x13565C4", VA = "0x13565C4")]
		public ANDMerge()
		{
		}
	}
	[Token(Token = "0x200007C")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E21B4", Offset = "0x9E21B4")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E21B4", Offset = "0x9E21B4")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E21B4", Offset = "0x9E21B4")]
	public class ORMerge : FlowControlNode
	{
		[Token(Token = "0x200007D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E223C", Offset = "0x9E223C")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000133")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			[Token(Token = "0x4000134")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ORMerge <>4__this;

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x26A46A8", Offset = "0x26A46A8", VA = "0x26A46A8")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x26A46B0", Offset = "0x26A46B0", VA = "0x26A46B0")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[GatherPortsCallback]
		[ExposeField]
		[DelayedField]
		[AttributeAttribute(Name = "MinValueAttribute", RVA = "0x9E9590", Offset = "0x9E9590")]
		[SerializeField]
		private int _portCount;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private FlowOutput fOut;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int lastFrameCall;

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x151BD90", Offset = "0x151BD90", VA = "0x151BD90", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x151BF00", Offset = "0x151BF00", VA = "0x151BF00")]
		private void Check(int index, Flow f)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x151BF80", Offset = "0x151BF80", VA = "0x151BF80")]
		public ORMerge()
		{
		}
	}
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E224C", Offset = "0x9E224C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E224C", Offset = "0x9E224C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E224C", Offset = "0x9E224C")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E224C", Offset = "0x9E224C")]
	public class XORMerge : FlowControlNode
	{
		[Token(Token = "0x200007F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E22E4", Offset = "0x9E22E4")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			[Token(Token = "0x400013A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public XORMerge <>4__this;

			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x26A9668", Offset = "0x26A9668", VA = "0x26A9668")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x26A9670", Offset = "0x26A9670", VA = "0x26A9670")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[DelayedField]
		[SerializeField]
		[ExposeField]
		[GatherPortsCallback]
		[AttributeAttribute(Name = "MinValueAttribute", RVA = "0x9E95FC", Offset = "0x9E95FC")]
		private int _portCount;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private FlowOutput fOut;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int[] calls;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastFrameCall;

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x14573DC", Offset = "0x14573DC", VA = "0x14573DC", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x145757C", Offset = "0x145757C", VA = "0x145757C")]
		private void Check(int index, Flow f)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1457678", Offset = "0x1457678", VA = "0x1457678")]
		public XORMerge()
		{
		}
	}
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E22F4", Offset = "0x9E22F4")]
	[AttributeAttribute(Name = "ColorAttribute", RVA = "0x9E22F4", Offset = "0x9E22F4")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E22F4", Offset = "0x9E22F4")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E22F4", Offset = "0x9E22F4")]
	public abstract class FlowControlNode : FlowNode
	{
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool isIntegrityConfirmed;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<string> _errorMessages;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string _nodePath;

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x136BB3C", Offset = "0x136BB3C", VA = "0x136BB3C", Slot = "30")]
		public override bool CheckIntegrity(string nodePath, out string[] messages)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x136BC0C", Offset = "0x136BC0C", VA = "0x136BC0C", Slot = "31")]
		public override void IntegrityCheck()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x136BECC", Offset = "0x136BECC", VA = "0x136BECC")]
		protected void ReportIntegrityCheckError(string message)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x13565D0", Offset = "0x13565D0", VA = "0x13565D0")]
		protected FlowControlNode()
		{
		}
	}
	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E2418", Offset = "0x9E2418")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E2418", Offset = "0x9E2418")]
	public class Break : FlowControlNode
	{
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x135FA3C", Offset = "0x135FA3C", VA = "0x135FA3C", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x135FAF4", Offset = "0x135FAF4", VA = "0x135FAF4")]
		public Break()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x135FAF8", Offset = "0x135FAF8", VA = "0x135FAF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAC84", Offset = "0x9EAC84")]
		private void <RegisterPorts>b__0_0(Flow f)
		{
		}
	}
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E2478", Offset = "0x9E2478")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E2478", Offset = "0x9E2478")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E2478", Offset = "0x9E2478")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E2478", Offset = "0x9E2478")]
	public class ForEach : FlowControlNode
	{
		[Token(Token = "0x2000083")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E25B0", Offset = "0x9E25B0")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ForEach <>4__this;

			[Token(Token = "0x4000143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FlowOutput fFinish;

			[Token(Token = "0x4000144")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FlowOutput fCurrent;

			[Token(Token = "0x4000145")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FlowBreak <>9__4;

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x1469034", Offset = "0x1469034", VA = "0x1469034")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x146903C", Offset = "0x146903C", VA = "0x146903C")]
			internal object <RegisterPorts>b__0()
			{
				return null;
			}

			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x1469058", Offset = "0x1469058", VA = "0x1469058")]
			internal int <RegisterPorts>b__1()
			{
				return default(int);
			}

			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x1469074", Offset = "0x1469074", VA = "0x1469074")]
			internal void <RegisterPorts>b__2(Flow f)
			{
			}

			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x14694D8", Offset = "0x14694D8", VA = "0x14694D8")]
			internal void <RegisterPorts>b__4()
			{
			}

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x14694F8", Offset = "0x14694F8", VA = "0x14694F8")]
			internal void <RegisterPorts>b__3(Flow f)
			{
			}
		}

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private object currentObject;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int currentIndex;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool broken;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ValueInput<IEnumerable> enumerableInput;

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1370664", Offset = "0x1370664", VA = "0x1370664", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x13709B4", Offset = "0x13709B4", VA = "0x13709B4", Slot = "39")]
		public override Type GetNodeWildDefinitionType()
		{
			return null;
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1370A2C", Offset = "0x1370A2C", VA = "0x1370A2C", Slot = "36")]
		public override void OnPortConnected(Port port, Port otherPort)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1370C18", Offset = "0x1370C18", VA = "0x1370C18")]
		public ForEach()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E25C0", Offset = "0x9E25C0")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E25C0", Offset = "0x9E25C0")]
	[ExposeAsDefinition]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E25C0", Offset = "0x9E25C0")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E25C0", Offset = "0x9E25C0")]
	public class ForEach<T> : FlowControlNode
	{
		[Token(Token = "0x2000085")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2708", Offset = "0x9E2708")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000149")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ForEach<T> <>4__this;

			[Token(Token = "0x400014A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<IEnumerable<T>> list;

			[Token(Token = "0x400014B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput fFinish;

			[Token(Token = "0x400014C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput fCurrent;

			[Token(Token = "0x400014D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowBreak <>9__4;

			[Token(Token = "0x60002D2")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60002D3")]
			internal T <RegisterPorts>b__0()
			{
				return (T)null;
			}

			[Token(Token = "0x60002D4")]
			internal int <RegisterPorts>b__1()
			{
				return default(int);
			}

			[Token(Token = "0x60002D5")]
			internal void <RegisterPorts>b__2(Flow f)
			{
			}

			[Token(Token = "0x60002D6")]
			internal void <RegisterPorts>b__4()
			{
			}

			[Token(Token = "0x60002D7")]
			internal void <RegisterPorts>b__3(Flow f)
			{
			}
		}

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T currentObject;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int currentIndex;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool broken;

		[Token(Token = "0x60002D0")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60002D1")]
		public ForEach()
		{
		}
	}
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E2718", Offset = "0x9E2718")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E2718", Offset = "0x9E2718")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E2718", Offset = "0x9E2718")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E2718", Offset = "0x9E2718")]
	public class ForLoop : FlowControlNode
	{
		[Token(Token = "0x2000087")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E283C", Offset = "0x9E283C")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000154")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ForLoop <>4__this;

			[Token(Token = "0x4000155")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FlowOutput fCurrent;

			[Token(Token = "0x4000156")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FlowOutput fFinish;

			[Token(Token = "0x4000157")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FlowBreak <>9__3;

			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x1469518", Offset = "0x1469518", VA = "0x1469518")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x1469520", Offset = "0x1469520", VA = "0x1469520")]
			internal int <RegisterPorts>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x146953C", Offset = "0x146953C", VA = "0x146953C")]
			internal void <RegisterPorts>b__1(Flow f)
			{
			}

			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x14697C0", Offset = "0x14697C0", VA = "0x14697C0")]
			internal void <RegisterPorts>b__3()
			{
			}

			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x14697E0", Offset = "0x14697E0", VA = "0x14697E0")]
			internal void <RegisterPorts>b__2(Flow f)
			{
			}
		}

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9E9668", Offset = "0x9E9668")]
		public bool reverse;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int current;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool broken;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ValueInput<int> first;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ValueInput<int> last;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ValueInput<int> step;

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1370C1C", Offset = "0x1370C1C", VA = "0x1370C1C", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1370F7C", Offset = "0x1370F7C", VA = "0x1370F7C")]
		public ForLoop()
		{
		}
	}
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E284C", Offset = "0x9E284C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E284C", Offset = "0x9E284C")]
	public class Dummy : FlowControlNode
	{
		[Token(Token = "0x2000089")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E28B0", Offset = "0x9E28B0")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000158")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FlowOutput fOut;

			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x1468928", Offset = "0x1468928", VA = "0x1468928")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x1468930", Offset = "0x1468930", VA = "0x1468930")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public override string name
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x1368D70", Offset = "0x1368D70", VA = "0x1368D70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1368D78", Offset = "0x1368D78", VA = "0x1368D78", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1368EAC", Offset = "0x1368EAC", VA = "0x1368EAC")]
		public Dummy()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E28C0", Offset = "0x9E28C0")]
	public class Finish : FlowControlNode
	{
		[Token(Token = "0x200008B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E28F8", Offset = "0x9E28F8")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000159")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Finish <>4__this;

			[Token(Token = "0x400015A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ValueInput<bool> c;

			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x1468A20", Offset = "0x1468A20", VA = "0x1468A20")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x1468A28", Offset = "0x1468A28", VA = "0x1468A28")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x136A694", Offset = "0x136A694", VA = "0x136A694", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x136A7E0", Offset = "0x136A7E0", VA = "0x136A7E0")]
		public Finish()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E2908", Offset = "0x9E2908")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E2908", Offset = "0x9E2908")]
	public class Merge : FlowControlNode
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[ExposeField]
		[AttributeAttribute(Name = "MinValueAttribute", RVA = "0x9E96A0", Offset = "0x9E96A0")]
		[DelayedField]
		[GatherPortsCallback]
		private int _portCount;

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x151515C", Offset = "0x151515C", VA = "0x151515C", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x151527C", Offset = "0x151527C", VA = "0x151527C")]
		public Merge()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E296C", Offset = "0x9E296C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E296C", Offset = "0x9E296C")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E296C", Offset = "0x9E296C")]
	public class Random : FlowControlNode
	{
		[Token(Token = "0x200008E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2A74", Offset = "0x9E2A74")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400015E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Random <>4__this;

			[Token(Token = "0x400015F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<FlowOutput> outs;

			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x26A4DD8", Offset = "0x26A4DD8", VA = "0x26A4DD8")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x26A4DE0", Offset = "0x26A4DE0", VA = "0x26A4DE0")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}

			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x26A4EB4", Offset = "0x26A4EB4", VA = "0x26A4EB4")]
			internal int <RegisterPorts>b__1()
			{
				return default(int);
			}
		}

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "MinValueAttribute", RVA = "0x9E970C", Offset = "0x9E970C")]
		[DelayedField]
		[GatherPortsCallback]
		[ExposeField]
		[SerializeField]
		private int _portCount;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int current;

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1BB09A4", Offset = "0x1BB09A4", VA = "0x1BB09A4", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1BB0C1C", Offset = "0x1BB0C1C", VA = "0x1BB0C1C")]
		public Random()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E2A84", Offset = "0x9E2A84")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E2A84", Offset = "0x9E2A84")]
	public class Split : FlowControlNode
	{
		[Token(Token = "0x2000090")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2AE8", Offset = "0x9E2AE8")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000161")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Split <>4__this;

			[Token(Token = "0x4000162")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<FlowOutput> outs;

			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x26A6894", Offset = "0x26A6894", VA = "0x26A6894")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x26A689C", Offset = "0x26A689C", VA = "0x26A689C")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[GatherPortsCallback]
		[ExposeField]
		[SerializeField]
		[AttributeAttribute(Name = "MinValueAttribute", RVA = "0x9E9778", Offset = "0x9E9778")]
		[DelayedField]
		private int _portCount;

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1BC11A4", Offset = "0x1BC11A4", VA = "0x1BC11A4", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1BC1384", Offset = "0x1BC1384", VA = "0x1BC1384")]
		public Split()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E2AF8", Offset = "0x9E2AF8")]
	public class TryCatch : FlowControlNode
	{
		[Token(Token = "0x2000092")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2B30", Offset = "0x9E2B30")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000163")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FlowOutput fTry;

			[Token(Token = "0x4000164")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FlowOutput fCatch;

			[Token(Token = "0x4000165")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FlowOutput fFinally;

			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x26A73F4", Offset = "0x26A73F4", VA = "0x26A73F4")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x26A73FC", Offset = "0x26A73FC", VA = "0x26A73FC")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1BC8330", Offset = "0x1BC8330", VA = "0x1BC8330", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1BC84C0", Offset = "0x1BC84C0", VA = "0x1BC84C0")]
		public TryCatch()
		{
		}
	}
	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E2B40", Offset = "0x9E2B40")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E2B40", Offset = "0x9E2B40")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E2B40", Offset = "0x9E2B40")]
	public class CoroutineState : FlowControlNode
	{
		[Token(Token = "0x2000094")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2BC8", Offset = "0x9E2BC8")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000168")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CoroutineState <>4__this;

			[Token(Token = "0x4000169")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FlowOutput fStart;

			[Token(Token = "0x400016A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FlowOutput fUpdate;

			[Token(Token = "0x400016B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FlowOutput fFinish;

			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x1468364", Offset = "0x1468364", VA = "0x1468364")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x146836C", Offset = "0x146836C", VA = "0x146836C")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x1468408", Offset = "0x1468408", VA = "0x1468408")]
			internal void <RegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x2000095")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2BD8", Offset = "0x9E2BD8")]
		private sealed class <DoRepeat>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400016C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400016D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400016E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FlowOutput fStart;

			[Token(Token = "0x400016F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Flow f;

			[Token(Token = "0x4000170")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public CoroutineState <>4__this;

			[Token(Token = "0x4000171")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public FlowOutput fUpdate;

			[Token(Token = "0x4000172")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public FlowOutput fFinish;

			[Token(Token = "0x17000050")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000302")]
				[Address(RVA = "0x1468640", Offset = "0x1468640", VA = "0x1468640", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000051")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000304")]
				[Address(RVA = "0x1468688", Offset = "0x1468688", VA = "0x1468688", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x1468424", Offset = "0x1468424", VA = "0x1468424")]
			[DebuggerHidden]
			public <DoRepeat>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0x1468450", Offset = "0x1468450", VA = "0x1468450", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000301")]
			[Address(RVA = "0x1468454", Offset = "0x1468454", VA = "0x1468454", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000303")]
			[Address(RVA = "0x1468648", Offset = "0x1468648", VA = "0x1468648", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool active;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Coroutine coroutine;

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x13657F8", Offset = "0x13657F8", VA = "0x13657F8", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x1365828", Offset = "0x1365828", VA = "0x1365828", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1365A1C", Offset = "0x1365A1C", VA = "0x1365A1C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9EAC94", Offset = "0x9EAC94")]
		private IEnumerator DoRepeat(FlowOutput fStart, FlowOutput fUpdate, FlowOutput fFinish, Flow f)
		{
			return null;
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1365B04", Offset = "0x1365B04", VA = "0x1365B04")]
		public CoroutineState()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1365B08", Offset = "0x1365B08", VA = "0x1365B08")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EACF4", Offset = "0x9EACF4")]
		private void <DoRepeat>b__4_0()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E2BE8", Offset = "0x9E2BE8")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E2BE8", Offset = "0x9E2BE8")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E2BE8", Offset = "0x9E2BE8")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E2BE8", Offset = "0x9E2BE8")]
	public class While : FlowControlNode
	{
		[Token(Token = "0x2000097")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2CEC", Offset = "0x9E2CEC")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000174")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public While <>4__this;

			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FlowOutput fUpdate;

			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FlowOutput fFinish;

			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ValueInput<bool> c;

			[Token(Token = "0x600030A")]
			[Address(RVA = "0x26A9308", Offset = "0x26A9308", VA = "0x26A9308")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600030B")]
			[Address(RVA = "0x26A9310", Offset = "0x26A9310", VA = "0x26A9310")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x2000098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2CFC", Offset = "0x9E2CFC")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool active;

			[Token(Token = "0x600030C")]
			[Address(RVA = "0x26A9390", Offset = "0x26A9390", VA = "0x26A9390")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x600030D")]
			[Address(RVA = "0x26A9398", Offset = "0x26A9398", VA = "0x26A9398")]
			internal void <DoWhile>b__0()
			{
			}
		}

		[Token(Token = "0x2000099")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2D0C", Offset = "0x9E2D0C")]
		private sealed class <DoWhile>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400017A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400017B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Flow f;

			[Token(Token = "0x400017C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public While <>4__this;

			[Token(Token = "0x400017D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public FlowOutput fUpdate;

			[Token(Token = "0x400017E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass4_0 <>8__1;

			[Token(Token = "0x400017F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public ValueInput<bool> condition;

			[Token(Token = "0x4000180")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public FlowOutput fFinish;

			[Token(Token = "0x17000052")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000311")]
				[Address(RVA = "0x26A9618", Offset = "0x26A9618", VA = "0x26A9618", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000053")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000313")]
				[Address(RVA = "0x26A9660", Offset = "0x26A9660", VA = "0x26A9660", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600030E")]
			[Address(RVA = "0x26A93A0", Offset = "0x26A93A0", VA = "0x26A93A0")]
			[DebuggerHidden]
			public <DoWhile>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600030F")]
			[Address(RVA = "0x26A93CC", Offset = "0x26A93CC", VA = "0x26A93CC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x26A93D0", Offset = "0x26A93D0", VA = "0x26A93D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0x26A9620", Offset = "0x26A9620", VA = "0x26A9620", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Coroutine coroutine;

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1457084", Offset = "0x1457084", VA = "0x1457084", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1457090", Offset = "0x1457090", VA = "0x1457090", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x14570D8", Offset = "0x14570D8", VA = "0x14570D8", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x1457290", Offset = "0x1457290", VA = "0x1457290")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9EAD54", Offset = "0x9EAD54")]
		private IEnumerator DoWhile(FlowOutput fUpdate, FlowOutput fFinish, Flow f, ValueInput<bool> condition)
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1457374", Offset = "0x1457374", VA = "0x1457374")]
		public While()
		{
		}
	}
	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E2D1C", Offset = "0x9E2D1C")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E2D1C", Offset = "0x9E2D1C")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E2D1C", Offset = "0x9E2D1C")]
	[ExposeAsDefinition]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E2D1C", Offset = "0x9E2D1C")]
	public class SelectOnBool<T> : FlowControlNode
	{
		[Token(Token = "0x200009B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2E7C", Offset = "0x9E2E7C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<bool> condition;

			[Token(Token = "0x4000182")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T> isTrue;

			[Token(Token = "0x4000183")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T> isFalse;

			[Token(Token = "0x6000316")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000317")]
			internal T <RegisterPorts>b__0()
			{
				return (T)null;
			}
		}

		[Token(Token = "0x6000314")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000315")]
		public SelectOnBool()
		{
		}
	}
	[Token(Token = "0x200009C")]
	[ExposeAsDefinition]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E2E8C", Offset = "0x9E2E8C")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E2E8C", Offset = "0x9E2E8C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E2E8C", Offset = "0x9E2E8C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E2E8C", Offset = "0x9E2E8C")]
	public class SelectOnEnum<T> : FlowControlNode
	{
		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E2FEC", Offset = "0x9E2FEC")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000185")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput selector;

			[Token(Token = "0x4000186")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T>[] cases;

			[Token(Token = "0x600031E")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x600031F")]
			internal T <RegisterPorts>b__0()
			{
				return (T)null;
			}
		}

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private SerializedTypeInfo _type;

		[Token(Token = "0x17000054")]
		private Type type
		{
			[Token(Token = "0x6000318")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000319")]
			set
			{
			}
		}

		[Token(Token = "0x600031A")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600031B")]
		public override Type GetNodeWildDefinitionType()
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		public override void OnPortConnected(Port port, Port otherPort)
		{
		}

		[Token(Token = "0x600031D")]
		public SelectOnEnum()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[ExposeAsDefinition]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E2FFC", Offset = "0x9E2FFC")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E2FFC", Offset = "0x9E2FFC")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E2FFC", Offset = "0x9E2FFC")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E2FFC", Offset = "0x9E2FFC")]
	public class SelectOnInt<T> : FlowControlNode
	{
		[Token(Token = "0x200009F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E315C", Offset = "0x9E315C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<int> selector;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T>[] cases;

			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T> defaultCase;

			[Token(Token = "0x6000322")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000323")]
			internal T <RegisterPorts>b__0()
			{
				return (T)null;
			}
		}

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "MinValueAttribute", RVA = "0x9E97F4", Offset = "0x9E97F4")]
		[DelayedField]
		[ExposeField]
		[GatherPortsCallback]
		[SerializeField]
		private int _portCount;

		[Token(Token = "0x6000320")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000321")]
		public SelectOnInt()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E316C", Offset = "0x9E316C")]
	[ExposeAsDefinition]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E316C", Offset = "0x9E316C")]
	[HasRefreshButton]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E316C", Offset = "0x9E316C")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E316C", Offset = "0x9E316C")]
	public class SelectOnString<T> : FlowControlNode
	{
		[Token(Token = "0x20000A1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E32DC", Offset = "0x9E32DC")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<string> selector;

			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SelectOnString<T> <>4__this;

			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T>[] cases;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T> defaultCase;

			[Token(Token = "0x6000326")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000327")]
			internal T <RegisterPorts>b__0()
			{
				return (T)null;
			}
		}

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E9860", Offset = "0x9E9860")]
		public List<string> stringCases;

		[Token(Token = "0x6000324")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000325")]
		public SelectOnString()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	[HasRefreshButton]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E32EC", Offset = "0x9E32EC")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E32EC", Offset = "0x9E32EC")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E32EC", Offset = "0x9E32EC")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E32EC", Offset = "0x9E32EC")]
	[ExposeAsDefinition]
	public class SelectOnTag<T> : FlowControlNode
	{
		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E345C", Offset = "0x9E345C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<GameObject> selector;

			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SelectOnTag<T> <>4__this;

			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T>[] cases;

			[Token(Token = "0x600032A")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600032B")]
			internal T <RegisterPorts>b__0()
			{
				return (T)null;
			}
		}

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private string[] _tagNames;

		[Token(Token = "0x6000328")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000329")]
		public SelectOnTag()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E346C", Offset = "0x9E346C")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E346C", Offset = "0x9E346C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E346C", Offset = "0x9E346C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E346C", Offset = "0x9E346C")]
	public class SwitchBool : FlowControlNode
	{
		[Token(Token = "0x20000A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3570", Offset = "0x9E3570")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ValueInput<bool> selector;

			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FlowOutput caseTrue;

			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FlowOutput caseFalse;

			[Token(Token = "0x600032E")]
			[Address(RVA = "0x26A697C", Offset = "0x26A697C", VA = "0x26A697C")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600032F")]
			[Address(RVA = "0x26A6984", Offset = "0x26A6984", VA = "0x26A6984")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1BC2A94", Offset = "0x1BC2A94", VA = "0x1BC2A94", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1BC2C38", Offset = "0x1BC2C38", VA = "0x1BC2C38")]
		public SwitchBool()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E3580", Offset = "0x9E3580")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E3580", Offset = "0x9E3580")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E3580", Offset = "0x9E3580")]
	public class SwitchComparison : FlowControlNode
	{
		[Token(Token = "0x20000A7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E365C", Offset = "0x9E365C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ValueInput<IComparable> a;

			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ValueInput<IComparable> b;

			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FlowOutput equal;

			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FlowOutput notEqual;

			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public FlowOutput greater;

			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public FlowOutput less;

			[Token(Token = "0x6000332")]
			[Address(RVA = "0x26A6A04", Offset = "0x26A6A04", VA = "0x26A6A04")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000333")]
			[Address(RVA = "0x26A6A0C", Offset = "0x26A6A0C", VA = "0x26A6A0C")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1BC2C40", Offset = "0x1BC2C40", VA = "0x1BC2C40", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1BC2EDC", Offset = "0x1BC2EDC", VA = "0x1BC2EDC")]
		public SwitchComparison()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E366C", Offset = "0x9E366C")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E366C", Offset = "0x9E366C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E366C", Offset = "0x9E366C")]
	public class SwitchEnum : FlowControlNode
	{
		[Token(Token = "0x20000A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3748", Offset = "0x9E3748")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ValueInput selector;

			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Dictionary<string, FlowOutput> cases;

			[Token(Token = "0x600033A")]
			[Address(RVA = "0x26A6C24", Offset = "0x26A6C24", VA = "0x26A6C24")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x600033B")]
			[Address(RVA = "0x26A6C2C", Offset = "0x26A6C2C", VA = "0x26A6C2C")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private SerializedTypeInfo _type;

		[Token(Token = "0x17000055")]
		private Type type
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x1BC2EE4", Offset = "0x1BC2EE4", VA = "0x1BC2EE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x1BC2EFC", Offset = "0x1BC2EFC", VA = "0x1BC2EFC")]
			set
			{
			}
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1BC2FD8", Offset = "0x1BC2FD8", VA = "0x1BC2FD8", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1BC3384", Offset = "0x1BC3384", VA = "0x1BC3384", Slot = "39")]
		public override Type GetNodeWildDefinitionType()
		{
			return null;
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1BC33FC", Offset = "0x1BC33FC", VA = "0x1BC33FC", Slot = "36")]
		public override void OnPortConnected(Port port, Port otherPort)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1BC3588", Offset = "0x1BC3588", VA = "0x1BC3588")]
		public SwitchEnum()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E3758", Offset = "0x9E3758")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E3758", Offset = "0x9E3758")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E3758", Offset = "0x9E3758")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E3758", Offset = "0x9E3758")]
	public class SwitchInt : FlowControlNode
	{
		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E385C", Offset = "0x9E385C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40001A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ValueInput<int> selector;

			[Token(Token = "0x40001A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FlowOutput[] cases;

			[Token(Token = "0x40001A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FlowOutput defaultCase;

			[Token(Token = "0x600033E")]
			[Address(RVA = "0x26A6CF0", Offset = "0x26A6CF0", VA = "0x26A6CF0")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600033F")]
			[Address(RVA = "0x26A6CF8", Offset = "0x26A6CF8", VA = "0x26A6CF8")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[ExposeField]
		[GatherPortsCallback]
		[AttributeAttribute(Name = "MinValueAttribute", RVA = "0x9E98BC", Offset = "0x9E98BC")]
		[DelayedField]
		private int _portCount;

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1BC3590", Offset = "0x1BC3590", VA = "0x1BC3590", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1BC3800", Offset = "0x1BC3800", VA = "0x1BC3800")]
		public SwitchInt()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E386C", Offset = "0x9E386C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E386C", Offset = "0x9E386C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E386C", Offset = "0x9E386C")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E386C", Offset = "0x9E386C")]
	[HasRefreshButton]
	public class SwitchIntCustom : FlowControlNode
	{
		[Token(Token = "0x20000AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3980", Offset = "0x9E3980")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40001A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ValueInput<int> selector;

			[Token(Token = "0x40001A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SwitchIntCustom <>4__this;

			[Token(Token = "0x40001A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FlowOutput[] cases;

			[Token(Token = "0x40001A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FlowOutput defaultCase;

			[Token(Token = "0x6000342")]
			[Address(RVA = "0x26A6DA0", Offset = "0x26A6DA0", VA = "0x26A6DA0")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000343")]
			[Address(RVA = "0x26A6DA8", Offset = "0x26A6DA8", VA = "0x26A6DA8")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public List<int> intCases;

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1BC3810", Offset = "0x1BC3810", VA = "0x1BC3810", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1BC3AF4", Offset = "0x1BC3AF4", VA = "0x1BC3AF4")]
		public SwitchIntCustom()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E3990", Offset = "0x9E3990")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E3990", Offset = "0x9E3990")]
	[HasRefreshButton]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E3990", Offset = "0x9E3990")]
	public class SwitchString : FlowControlNode
	{
		[Token(Token = "0x20000AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3A7C", Offset = "0x9E3A7C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40001AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ValueInput<string> selector;

			[Token(Token = "0x40001AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SwitchString <>4__this;

			[Token(Token = "0x40001AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FlowOutput[] cases;

			[Token(Token = "0x40001AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FlowOutput defaultCase;

			[Token(Token = "0x6000346")]
			[Address(RVA = "0x26A6F24", Offset = "0x26A6F24", VA = "0x26A6F24")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000347")]
			[Address(RVA = "0x26A6F2C", Offset = "0x26A6F2C", VA = "0x26A6F2C")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E9928", Offset = "0x9E9928")]
		public List<string> comparisonOutputs;

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1BC3B78", Offset = "0x1BC3B78", VA = "0x1BC3B78", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1BC3E60", Offset = "0x1BC3E60", VA = "0x1BC3E60")]
		public SwitchString()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E3A8C", Offset = "0x9E3A8C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E3A8C", Offset = "0x9E3A8C")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E3A8C", Offset = "0x9E3A8C")]
	[HasRefreshButton]
	public class SwitchTag : FlowControlNode
	{
		[Token(Token = "0x20000B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3B78", Offset = "0x9E3B78")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40001AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SwitchTag <>4__this;

			[Token(Token = "0x40001B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ValueInput<GameObject> selector;

			[Token(Token = "0x40001B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FlowOutput[] cases;

			[Token(Token = "0x600034A")]
			[Address(RVA = "0x26A70BC", Offset = "0x26A70BC", VA = "0x26A70BC")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600034B")]
			[Address(RVA = "0x26A70C4", Offset = "0x26A70C4", VA = "0x26A70C4")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private string[] _tagNames;

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1BC3EE4", Offset = "0x1BC3EE4", VA = "0x1BC3EE4", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1BC4148", Offset = "0x1BC4148", VA = "0x1BC4148")]
		public SwitchTag()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E3B88", Offset = "0x9E3B88")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E3B88", Offset = "0x9E3B88")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E3B88", Offset = "0x9E3B88")]
	public class FlipFlop : FlowControlNode
	{
		[Token(Token = "0x20000B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3C64", Offset = "0x9E3C64")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x40001B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FlipFlop <>4__this;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FlowOutput fFlip;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FlowOutput fFlop;

			[Token(Token = "0x6000351")]
			[Address(RVA = "0x1468A9C", Offset = "0x1468A9C", VA = "0x1468A9C")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000352")]
			[Address(RVA = "0x1468AA4", Offset = "0x1468AA4", VA = "0x1468AA4")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}

			[Token(Token = "0x6000353")]
			[Address(RVA = "0x1468B04", Offset = "0x1468B04", VA = "0x1468B04")]
			internal void <RegisterPorts>b__1(Flow f)
			{
			}

			[Token(Token = "0x6000354")]
			[Address(RVA = "0x1468B20", Offset = "0x1468B20", VA = "0x1468B20")]
			internal bool <RegisterPorts>b__2()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool isFlip;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		private bool original;

		[Token(Token = "0x17000056")]
		public override string name
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x136A9F0", Offset = "0x136A9F0", VA = "0x136A9F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x136AA80", Offset = "0x136AA80", VA = "0x136AA80", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x136AA8C", Offset = "0x136AA8C", VA = "0x136AA8C", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x136AA98", Offset = "0x136AA98", VA = "0x136AA98", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x136AD04", Offset = "0x136AD04", VA = "0x136AD04")]
		public FlipFlop()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E3C74", Offset = "0x9E3C74")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E3C74", Offset = "0x9E3C74")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E3C74", Offset = "0x9E3C74")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E3C74", Offset = "0x9E3C74")]
	public class MultiToggle : FlowControlNode
	{
		[Token(Token = "0x20000B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3D78", Offset = "0x9E3D78")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<FlowOutput> outs;

			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MultiToggle <>4__this;

			[Token(Token = "0x600035A")]
			[Address(RVA = "0x26A4290", Offset = "0x26A4290", VA = "0x26A4290")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600035B")]
			[Address(RVA = "0x26A4298", Offset = "0x26A4298", VA = "0x26A4298")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}

			[Token(Token = "0x600035C")]
			[Address(RVA = "0x26A4350", Offset = "0x26A4350", VA = "0x26A4350")]
			internal void <RegisterPorts>b__1(Flow f)
			{
			}

			[Token(Token = "0x600035D")]
			[Address(RVA = "0x26A43B0", Offset = "0x26A43B0", VA = "0x26A43B0")]
			internal void <RegisterPorts>b__2(Flow f)
			{
			}

			[Token(Token = "0x600035E")]
			[Address(RVA = "0x26A4410", Offset = "0x26A4410", VA = "0x26A4410")]
			internal int <RegisterPorts>b__3()
			{
				return default(int);
			}
		}

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[ExposeField]
		[DelayedField]
		[AttributeAttribute(Name = "MinValueAttribute", RVA = "0x9E9974", Offset = "0x9E9974")]
		[SerializeField]
		[GatherPortsCallback]
		private int _portCount;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E99E0", Offset = "0x9E99E0")]
		public int current;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int original;

		[Token(Token = "0x17000057")]
		public override string name
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x1519DAC", Offset = "0x1519DAC", VA = "0x1519DAC", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1519E40", Offset = "0x1519E40", VA = "0x1519E40", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1519E74", Offset = "0x1519E74", VA = "0x1519E74", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1519E80", Offset = "0x1519E80", VA = "0x1519E80", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x151A1B0", Offset = "0x151A1B0", VA = "0x151A1B0")]
		public MultiToggle()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E3D88", Offset = "0x9E3D88")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E3D88", Offset = "0x9E3D88")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E3D88", Offset = "0x9E3D88")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E3D88", Offset = "0x9E3D88")]
	public class Sequence : FlowControlNode
	{
		[Token(Token = "0x20000B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3E8C", Offset = "0x9E3E8C")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40001BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<FlowOutput> outs;

			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Sequence <>4__this;

			[Token(Token = "0x6000364")]
			[Address(RVA = "0x26A6144", Offset = "0x26A6144", VA = "0x26A6144")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000365")]
			[Address(RVA = "0x26A614C", Offset = "0x26A614C", VA = "0x26A614C")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}

			[Token(Token = "0x6000366")]
			[Address(RVA = "0x26A6248", Offset = "0x26A6248", VA = "0x26A6248")]
			internal void <RegisterPorts>b__1(Flow f)
			{
			}

			[Token(Token = "0x6000367")]
			[Address(RVA = "0x26A6264", Offset = "0x26A6264", VA = "0x26A6264")]
			internal int <RegisterPorts>b__2()
			{
				return default(int);
			}
		}

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[ExposeField]
		[AttributeAttribute(Name = "MinValueAttribute", RVA = "0x9E9A1C", Offset = "0x9E9A1C")]
		[SerializeField]
		[DelayedField]
		[GatherPortsCallback]
		private int _portCount;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "MinValueAttribute", RVA = "0x9E9A88", Offset = "0x9E9A88")]
		public int current;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int original;

		[Token(Token = "0x17000058")]
		public override string name
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x1BBE618", Offset = "0x1BBE618", VA = "0x1BBE618", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1BBE5D8", Offset = "0x1BBE5D8", VA = "0x1BBE5D8", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1BBE60C", Offset = "0x1BBE60C", VA = "0x1BBE60C", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1BBE6B0", Offset = "0x1BBE6B0", VA = "0x1BBE6B0", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x1BBE984", Offset = "0x1BBE984", VA = "0x1BBE984")]
		public Sequence()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E3E9C", Offset = "0x9E3E9C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E3E9C", Offset = "0x9E3E9C")]
	public class Toggle : FlowControlNode
	{
		[Token(Token = "0x20000B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E3EFC", Offset = "0x9E3EFC")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Toggle <>4__this;

			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FlowOutput fOn;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FlowOutput fOff;

			[Token(Token = "0x600036D")]
			[Address(RVA = "0x26A7350", Offset = "0x26A7350", VA = "0x26A7350")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x600036E")]
			[Address(RVA = "0x26A7358", Offset = "0x26A7358", VA = "0x26A7358")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}

			[Token(Token = "0x600036F")]
			[Address(RVA = "0x26A7394", Offset = "0x26A7394", VA = "0x26A7394")]
			internal void <RegisterPorts>b__1(Flow f)
			{
			}

			[Token(Token = "0x6000370")]
			[Address(RVA = "0x26A73B4", Offset = "0x26A73B4", VA = "0x26A73B4")]
			internal void <RegisterPorts>b__2(Flow f)
			{
			}

			[Token(Token = "0x6000371")]
			[Address(RVA = "0x26A73D0", Offset = "0x26A73D0", VA = "0x26A73D0")]
			internal void <RegisterPorts>b__3(Flow f)
			{
			}
		}

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E9A9C", Offset = "0x9E9A9C")]
		public bool open;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		private bool original;

		[Token(Token = "0x17000059")]
		public override string name
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x1BC6CE0", Offset = "0x1BC6CE0", VA = "0x1BC6CE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x1BC6D70", Offset = "0x1BC6D70", VA = "0x1BC6D70", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1BC6D7C", Offset = "0x1BC6D7C", VA = "0x1BC6D7C", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x1BC6D88", Offset = "0x1BC6D88", VA = "0x1BC6D88", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1BC700C", Offset = "0x1BC700C", VA = "0x1BC700C")]
		public Toggle()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	[DoNotList]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E3F0C", Offset = "0x9E3F0C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E3F0C", Offset = "0x9E3F0C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E3F0C", Offset = "0x9E3F0C")]
	[AttributeAttribute(Name = "DeserializeFromAttribute", RVA = "0x9E3F0C", Offset = "0x9E3F0C")]
	public class CustomFunctionCall : FlowControlNode
	{
		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private string _sourceOutputUID;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ValueInput[] portArgs;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private object[] objectArgs;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private FlowOutput fOut;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private object _sourceFunction;

		[Token(Token = "0x1700005A")]
		private string sourceFunctionUID
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x1366598", Offset = "0x1366598", VA = "0x1366598")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x13665A0", Offset = "0x13665A0", VA = "0x13665A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public CustomFunctionEvent sourceFunction
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x13665A8", Offset = "0x13665A8", VA = "0x13665A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x1366738", Offset = "0x1366738", VA = "0x1366738")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public override string name
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x1366740", Offset = "0x1366740", VA = "0x1366740", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public override string description
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x13667CC", Offset = "0x13667CC", VA = "0x13667CC", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1366834", Offset = "0x1366834", VA = "0x1366834")]
		public void SetFunction(CustomFunctionEvent func)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1366890", Offset = "0x1366890", VA = "0x1366890", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1366C24", Offset = "0x1366C24", VA = "0x1366C24")]
		private void Invoke(Flow f)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1367030", Offset = "0x1367030", VA = "0x1367030")]
		public CustomFunctionCall()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1367034", Offset = "0x1367034", VA = "0x1367034")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAE04", Offset = "0x9EAE04")]
		private bool <get_sourceFunction>b__9_0(CustomFunctionEvent i)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "DeserializeFromAttribute", RVA = "0x9E3FC8", Offset = "0x9E3FC8")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E3FC8", Offset = "0x9E3FC8")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E3FC8", Offset = "0x9E3FC8")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E3FC8", Offset = "0x9E3FC8")]
	public class CustomFunctionEvent : EventNode, IInvokable, IEditorMenuCallbackReceiver
	{
		[Serializable]
		[Token(Token = "0x20000BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4074", Offset = "0x9E4074")]
		private sealed class <>c
		{
			[Token(Token = "0x40001D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40001D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<DynamicPortDefinition, Type> <>9__16_0;

			[Token(Token = "0x6000391")]
			[Address(RVA = "0x14686F4", Offset = "0x14686F4", VA = "0x14686F4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000392")]
			[Address(RVA = "0x14686FC", Offset = "0x14686FC", VA = "0x14686FC")]
			internal Type <get_parameterTypes>b__16_0(DynamicPortDefinition p)
			{
				return null;
			}
		}

		[Token(Token = "0x20000BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4084", Offset = "0x9E4084")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x40001D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			[Token(Token = "0x40001D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CustomFunctionEvent <>4__this;

			[Token(Token = "0x6000393")]
			[Address(RVA = "0x1468714", Offset = "0x1468714", VA = "0x1468714")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x6000394")]
			[Address(RVA = "0x146871C", Offset = "0x146871C", VA = "0x146871C")]
			internal object <RegisterPorts>b__0()
			{
				return null;
			}
		}

		[Token(Token = "0x20000BE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4094", Offset = "0x9E4094")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x40001D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<object> callback;

			[Token(Token = "0x40001D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CustomFunctionEvent <>4__this;

			[Token(Token = "0x6000395")]
			[Address(RVA = "0x1468764", Offset = "0x1468764", VA = "0x1468764")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6000396")]
			[Address(RVA = "0x146876C", Offset = "0x146876C", VA = "0x146876C")]
			internal void <NodeCanvas.Framework.IInvokable.InvokeAsync>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x20000BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E40A4", Offset = "0x9E40A4")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x40001D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomFunctionEvent <>4__this;

			[Token(Token = "0x40001D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FlowHandler flowCallback;

			[Token(Token = "0x40001DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Flow f;

			[Token(Token = "0x6000397")]
			[Address(RVA = "0x14687CC", Offset = "0x14687CC", VA = "0x14687CC")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000398")]
			[Address(RVA = "0x14687D4", Offset = "0x14687D4", VA = "0x14687D4")]
			internal void <InvokeAsync>b__0(object o)
			{
			}
		}

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9E9AE8", Offset = "0x9E9AE8")]
		[DelayedField]
		public string identifier;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private List<DynamicPortDefinition> _parameters;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private DynamicPortDefinition _returns;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private object[] args;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private object returnValue;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private FlowOutput onInvoke;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool isInvoking;

		[Token(Token = "0x1700005E")]
		public List<DynamicPortDefinition> parameters
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x136706C", Offset = "0x136706C", VA = "0x136706C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x1367074", Offset = "0x1367074", VA = "0x1367074")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public DynamicPortDefinition returns
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x136707C", Offset = "0x136707C", VA = "0x136707C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x1367084", Offset = "0x1367084", VA = "0x1367084")]
			private set
			{
			}
		}

		[Token(Token = "0x17000060")]
		private Type returnType
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x136708C", Offset = "0x136708C", VA = "0x136708C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		private Type[] parameterTypes
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x13670A8", Offset = "0x13670A8", VA = "0x13670A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		public override string name
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x13671E8", Offset = "0x13671E8", VA = "0x13671E8", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1367238", Offset = "0x1367238", VA = "0x1367238", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x13673F4", Offset = "0x13673F4", VA = "0x13673F4", Slot = "40")]
		private string NodeCanvas.Framework.IInvokable.GetInvocationID()
		{
			return null;
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x13673FC", Offset = "0x13673FC", VA = "0x13673FC", Slot = "41")]
		private object NodeCanvas.Framework.IInvokable.Invoke(params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x13675B4", Offset = "0x13675B4", VA = "0x13675B4", Slot = "42")]
		private void NodeCanvas.Framework.IInvokable.InvokeAsync(Action<object> callback, params object[] args)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1367404", Offset = "0x1367404", VA = "0x1367404")]
		public object Invoke(Flow f, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1366E00", Offset = "0x1366E00", VA = "0x1366E00")]
		public void InvokeAsync(Flow f, FlowHandler flowCallback, params object[] args)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x136771C", Offset = "0x136771C", VA = "0x136771C")]
		public object GetReturnValue()
		{
			return null;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1367724", Offset = "0x1367724", VA = "0x1367724")]
		private void AddParameter(Type type)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x13678D8", Offset = "0x13678D8", VA = "0x13678D8")]
		private void GatherPortsUpdateRefs()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1367CB4", Offset = "0x1367CB4", VA = "0x1367CB4")]
		public CustomFunctionEvent()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1367DAC", Offset = "0x1367DAC", VA = "0x1367DAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAE14", Offset = "0x9EAE14")]
		private void <Invoke>b__23_0(object o)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1367DD8", Offset = "0x1367DD8", VA = "0x1367DD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAE24", Offset = "0x9EAE24")]
		private bool <GatherPortsUpdateRefs>b__27_0(CustomFunctionCall n)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000C0")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E40B4", Offset = "0x9E40B4")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E40B4", Offset = "0x9E40B4")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E40B4", Offset = "0x9E40B4")]
	public class Return : FlowControlNode
	{
		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[GatherPortsCallback]
		public bool useReturnValue;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ValueInput<object> returnPort;

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1BBE278", Offset = "0x1BBE278", VA = "0x1BBE278", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1BBE384", Offset = "0x1BBE384", VA = "0x1BBE384")]
		public Return()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1BBE394", Offset = "0x1BBE394", VA = "0x1BBE394")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAE34", Offset = "0x9EAE34")]
		private void <RegisterPorts>b__2_0(Flow f)
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public abstract class CallableActionNodeBase : SimplexNode
	{
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1361348", Offset = "0x1361348", VA = "0x1361348")]
		protected CallableActionNodeBase()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public abstract class CallableActionNode : CallableActionNodeBase
	{
		[Token(Token = "0x20000C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4190", Offset = "0x9E4190")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40001DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CallableActionNode <>4__this;

			[Token(Token = "0x40001DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FlowOutput o;

			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x1467E14", Offset = "0x1467E14", VA = "0x1467E14")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x1467E1C", Offset = "0x1467E1C", VA = "0x1467E1C")]
			internal void <OnRegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x600039D")]
		public abstract void Invoke();

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1361210", Offset = "0x1361210", VA = "0x1361210", Slot = "6")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1361340", Offset = "0x1361340", VA = "0x1361340")]
		protected CallableActionNode()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public abstract class CallableActionNode<T1> : CallableActionNodeBase
	{
		[Token(Token = "0x20000C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E41A0", Offset = "0x9E41A0")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40001DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallableActionNode<T1> <>4__this;

			[Token(Token = "0x40001E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x40001E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x60003A5")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60003A6")]
			internal void <OnRegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x60003A2")]
		public abstract void Invoke(T1 a);

		[Token(Token = "0x60003A3")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60003A4")]
		protected CallableActionNode()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public abstract class CallableActionNode<T1, T2> : CallableActionNodeBase
	{
		[Token(Token = "0x20000C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E41B0", Offset = "0x9E41B0")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40001E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallableActionNode<T1, T2> <>4__this;

			[Token(Token = "0x40001E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x40001E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x40001E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x60003AA")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60003AB")]
			internal void <OnRegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x60003A7")]
		public abstract void Invoke(T1 a, T2 b);

		[Token(Token = "0x60003A8")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60003A9")]
		protected CallableActionNode()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public abstract class CallableActionNode<T1, T2, T3> : CallableActionNodeBase
	{
		[Token(Token = "0x20000C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E41C0", Offset = "0x9E41C0")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40001E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallableActionNode<T1, T2, T3> <>4__this;

			[Token(Token = "0x40001E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x40001E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x40001E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x40001EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x60003AF")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60003B0")]
			internal void <OnRegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x60003AC")]
		public abstract void Invoke(T1 a, T2 b, T3 c);

		[Token(Token = "0x60003AD")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60003AE")]
		protected CallableActionNode()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public abstract class CallableActionNode<T1, T2, T3, T4> : CallableActionNodeBase
	{
		[Token(Token = "0x20000CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E41D0", Offset = "0x9E41D0")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40001EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallableActionNode<T1, T2, T3, T4> <>4__this;

			[Token(Token = "0x40001EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x40001ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x40001EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x40001EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x40001F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x60003B4")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60003B5")]
			internal void <OnRegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x60003B1")]
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d);

		[Token(Token = "0x60003B2")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60003B3")]
		protected CallableActionNode()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public abstract class CallableActionNode<T1, T2, T3, T4, T5> : CallableActionNodeBase
	{
		[Token(Token = "0x20000CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E41E0", Offset = "0x9E41E0")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallableActionNode<T1, T2, T3, T4, T5> <>4__this;

			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x40001F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x40001F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x40001F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x40001F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x60003B9")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60003BA")]
			internal void <OnRegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x60003B6")]
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e);

		[Token(Token = "0x60003B7")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60003B8")]
		protected CallableActionNode()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6> : CallableActionNodeBase
	{
		[Token(Token = "0x20000CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E41F0", Offset = "0x9E41F0")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallableActionNode<T1, T2, T3, T4, T5, T6> <>4__this;

			[Token(Token = "0x40001F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x40001FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x40001FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x40001FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x40001FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x40001FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x40001FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x60003BE")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60003BF")]
			internal void <OnRegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x60003BB")]
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);

		[Token(Token = "0x60003BC")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60003BD")]
		protected CallableActionNode()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6, T7> : CallableActionNodeBase
	{
		[Token(Token = "0x20000D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4200", Offset = "0x9E4200")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallableActionNode<T1, T2, T3, T4, T5, T6, T7> <>4__this;

			[Token(Token = "0x4000201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x4000202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x4000206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x4000207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T7> p7;

			[Token(Token = "0x4000208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x60003C3")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60003C4")]
			internal void <OnRegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x60003C0")]
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);

		[Token(Token = "0x60003C1")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60003C2")]
		protected CallableActionNode()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6, T7, T8> : CallableActionNodeBase
	{
		[Token(Token = "0x20000D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4210", Offset = "0x9E4210")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallableActionNode<T1, T2, T3, T4, T5, T6, T7, T8> <>4__this;

			[Token(Token = "0x400020A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x400020B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x400020C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x400020D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x400020E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x400020F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x4000210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T7> p7;

			[Token(Token = "0x4000211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T8> p8;

			[Token(Token = "0x4000212")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x60003C8")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60003C9")]
			internal void <OnRegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x60003C5")]
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);

		[Token(Token = "0x60003C6")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60003C7")]
		protected CallableActionNode()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9> : CallableActionNodeBase
	{
		[Token(Token = "0x20000D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4220", Offset = "0x9E4220")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallableActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9> <>4__this;

			[Token(Token = "0x4000214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x4000215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x4000216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x4000217")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x4000218")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x4000219")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x400021A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T7> p7;

			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T8> p8;

			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T9> p9;

			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x60003CD")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60003CE")]
			internal void <OnRegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x60003CA")]
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i);

		[Token(Token = "0x60003CB")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60003CC")]
		protected CallableActionNode()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public abstract class CallableActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : CallableActionNodeBase
	{
		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4230", Offset = "0x9E4230")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallableActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> <>4__this;

			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x4000223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x4000224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x4000225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T7> p7;

			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T8> p8;

			[Token(Token = "0x4000227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T9> p9;

			[Token(Token = "0x4000228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T10> p10;

			[Token(Token = "0x4000229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x60003D2")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60003D3")]
			internal void <OnRegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x60003CF")]
		public abstract void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j);

		[Token(Token = "0x60003D0")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60003D1")]
		protected CallableActionNode()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public abstract class CallableFunctionNodeBase : SimplexNode
	{
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1361350", Offset = "0x1361350", VA = "0x1361350")]
		protected CallableFunctionNodeBase()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public abstract class CallableFunctionNode<TResult> : CallableFunctionNodeBase
	{
		[Token(Token = "0x20000DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4240", Offset = "0x9E4240")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400022B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallableFunctionNode<TResult> <>4__this;

			[Token(Token = "0x400022C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x60003D8")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60003D9")]
			internal TResult <OnRegisterPorts>b__0()
			{
				return (TResult)null;
			}

			[Token(Token = "0x60003DA")]
			internal void <OnRegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TResult result;

		[Token(Token = "0x60003D5")]
		public abstract TResult Invoke();

		[Token(Token = "0x60003D6")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60003D7")]
		protected CallableFunctionNode()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public abstract class CallableFunctionNode<TResult, T1> : CallableFunctionNodeBase
	{
		[Token(Token = "0x20000DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4250", Offset = "0x9E4250")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400022E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallableFunctionNode<TResult, T1> <>4__this;

			[Token(Token = "0x400022F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x4000230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x60003DE")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60003DF")]
			internal TResult <OnRegisterPorts>b__0()
			{
				return (TResult)null;
			}

			[Token(Token = "0x60003E0")]
			internal void <OnRegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TResult result;

		[Token(Token = "0x60003DB")]
		public abstract TResult Invoke(T1 a);

		[Token(Token = "0x60003DC")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60003DD")]
		protected CallableFunctionNode()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public abstract class CallableFunctionNode<TResult, T1, T2> : CallableFunctionNodeBase
	{
		[Token(Token = "0x20000DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4260", Offset = "0x9E4260")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallableFunctionNode<TResult, T1, T2> <>4__this;

			[Token(Token = "0x4000233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x4000234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x4000235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x60003E4")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60003E5")]
			internal TResult <OnRegisterPorts>b__0()
			{
				return (TResult)null;
			}

			[Token(Token = "0x60003E6")]
			internal void <OnRegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TResult result;

		[Token(Token = "0x60003E1")]
		public abstract TResult Invoke(T1 a, T2 b);

		[Token(Token = "0x60003E2")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60003E3")]
		protected CallableFunctionNode()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public abstract class CallableFunctionNode<TResult, T1, T2, T3> : CallableFunctionNodeBase
	{
		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4270", Offset = "0x9E4270")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallableFunctionNode<TResult, T1, T2, T3> <>4__this;

			[Token(Token = "0x4000238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x4000239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x400023A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x400023B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x60003EA")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60003EB")]
			internal TResult <OnRegisterPorts>b__0()
			{
				return (TResult)null;
			}

			[Token(Token = "0x60003EC")]
			internal void <OnRegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TResult result;

		[Token(Token = "0x60003E7")]
		public abstract TResult Invoke(T1 a, T2 b, T3 c);

		[Token(Token = "0x60003E8")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60003E9")]
		protected CallableFunctionNode()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4> : CallableFunctionNodeBase
	{
		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4280", Offset = "0x9E4280")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400023D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallableFunctionNode<TResult, T1, T2, T3, T4> <>4__this;

			[Token(Token = "0x400023E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x60003F0")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60003F1")]
			internal TResult <OnRegisterPorts>b__0()
			{
				return (TResult)null;
			}

			[Token(Token = "0x60003F2")]
			internal void <OnRegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TResult result;

		[Token(Token = "0x60003ED")]
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d);

		[Token(Token = "0x60003EE")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60003EF")]
		protected CallableFunctionNode()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5> : CallableFunctionNodeBase
	{
		[Token(Token = "0x20000E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4290", Offset = "0x9E4290")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallableFunctionNode<TResult, T1, T2, T3, T4, T5> <>4__this;

			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x4000248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x4000249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x400024A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x60003F6")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60003F7")]
			internal TResult <OnRegisterPorts>b__0()
			{
				return (TResult)null;
			}

			[Token(Token = "0x60003F8")]
			internal void <OnRegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TResult result;

		[Token(Token = "0x60003F3")]
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e);

		[Token(Token = "0x60003F4")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60003F5")]
		protected CallableFunctionNode()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6> : CallableFunctionNodeBase
	{
		[Token(Token = "0x20000E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E42A0", Offset = "0x9E42A0")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400024C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6> <>4__this;

			[Token(Token = "0x400024D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x400024E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x400024F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x4000250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x4000251")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x4000252")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x4000253")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x60003FC")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60003FD")]
			internal TResult <OnRegisterPorts>b__0()
			{
				return (TResult)null;
			}

			[Token(Token = "0x60003FE")]
			internal void <OnRegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TResult result;

		[Token(Token = "0x60003F9")]
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);

		[Token(Token = "0x60003FA")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60003FB")]
		protected CallableFunctionNode()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7> : CallableFunctionNodeBase
	{
		[Token(Token = "0x20000E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E42B0", Offset = "0x9E42B0")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000255")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7> <>4__this;

			[Token(Token = "0x4000256")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x4000257")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x4000258")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x4000259")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x400025A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x400025B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x400025C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T7> p7;

			[Token(Token = "0x400025D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x6000402")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000403")]
			internal TResult <OnRegisterPorts>b__0()
			{
				return (TResult)null;
			}

			[Token(Token = "0x6000404")]
			internal void <OnRegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TResult result;

		[Token(Token = "0x60003FF")]
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);

		[Token(Token = "0x6000400")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x6000401")]
		protected CallableFunctionNode()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8> : CallableFunctionNodeBase
	{
		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E42C0", Offset = "0x9E42C0")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400025F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8> <>4__this;

			[Token(Token = "0x4000260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x4000261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x4000262")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x4000263")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x4000264")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x4000265")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x4000266")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T7> p7;

			[Token(Token = "0x4000267")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T8> p8;

			[Token(Token = "0x4000268")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x6000408")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000409")]
			internal TResult <OnRegisterPorts>b__0()
			{
				return (TResult)null;
			}

			[Token(Token = "0x600040A")]
			internal void <OnRegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TResult result;

		[Token(Token = "0x6000405")]
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);

		[Token(Token = "0x6000406")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x6000407")]
		protected CallableFunctionNode()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9> : CallableFunctionNodeBase
	{
		[Token(Token = "0x20000EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E42D0", Offset = "0x9E42D0")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400026A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9> <>4__this;

			[Token(Token = "0x400026B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x400026C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x400026D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x400026E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x400026F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x4000270")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x4000271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T7> p7;

			[Token(Token = "0x4000272")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T8> p8;

			[Token(Token = "0x4000273")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T9> p9;

			[Token(Token = "0x4000274")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x600040E")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600040F")]
			internal TResult <OnRegisterPorts>b__0()
			{
				return (TResult)null;
			}

			[Token(Token = "0x6000410")]
			internal void <OnRegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TResult result;

		[Token(Token = "0x600040B")]
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i);

		[Token(Token = "0x600040C")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x600040D")]
		protected CallableFunctionNode()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public abstract class CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : CallableFunctionNodeBase
	{
		[Token(Token = "0x20000EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E42E0", Offset = "0x9E42E0")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000276")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallableFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> <>4__this;

			[Token(Token = "0x4000277")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x4000278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x4000279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x400027A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x400027B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x400027C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x400027D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T7> p7;

			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T8> p8;

			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T9> p9;

			[Token(Token = "0x4000280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T10> p10;

			[Token(Token = "0x4000281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x6000414")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000415")]
			internal TResult <OnRegisterPorts>b__0()
			{
				return (TResult)null;
			}

			[Token(Token = "0x6000416")]
			internal void <OnRegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TResult result;

		[Token(Token = "0x6000411")]
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j);

		[Token(Token = "0x6000412")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x6000413")]
		protected CallableFunctionNode()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public abstract class ExtractorNode : SimplexNode
	{
		[Serializable]
		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E42F0", Offset = "0x9E42F0")]
		private sealed class <>c
		{
			[Token(Token = "0x4000283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Type, bool> <>9__1_0;

			[Token(Token = "0x600041A")]
			[Address(RVA = "0x14689E4", Offset = "0x14689E4", VA = "0x14689E4")]
			public <>c()
			{
			}

			[Token(Token = "0x600041B")]
			[Address(RVA = "0x14689EC", Offset = "0x14689EC", VA = "0x14689EC")]
			internal bool <GetExtractorType>b__1_0(Type t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, Type> _extractors;

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x136A0A0", Offset = "0x136A0A0", VA = "0x136A0A0")]
		public static Type GetExtractorType(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x136A68C", Offset = "0x136A68C", VA = "0x136A68C")]
		protected ExtractorNode()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public abstract class ExtractorNode<TInstance, T1, T2> : ExtractorNode
	{
		[Token(Token = "0x20000F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4300", Offset = "0x9E4300")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ExtractorNode<TInstance, T1, T2> <>4__this;

			[Token(Token = "0x4000288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<TInstance> i;

			[Token(Token = "0x600041F")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000420")]
			internal T1 <OnRegisterPorts>b__0()
			{
				return (T1)null;
			}

			[Token(Token = "0x6000421")]
			internal T2 <OnRegisterPorts>b__1()
			{
				return (T2)null;
			}
		}

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 a;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T2 b;

		[Token(Token = "0x600041C")]
		public abstract void Invoke(TInstance instance, out T1 a, out T2 b);

		[Token(Token = "0x600041D")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x600041E")]
		protected ExtractorNode()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public abstract class ExtractorNode<TInstance, T1, T2, T3> : ExtractorNode
	{
		[Token(Token = "0x20000F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4310", Offset = "0x9E4310")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400028C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ExtractorNode<TInstance, T1, T2, T3> <>4__this;

			[Token(Token = "0x400028D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<TInstance> i;

			[Token(Token = "0x6000425")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000426")]
			internal T1 <OnRegisterPorts>b__0()
			{
				return (T1)null;
			}

			[Token(Token = "0x6000427")]
			internal T2 <OnRegisterPorts>b__1()
			{
				return (T2)null;
			}

			[Token(Token = "0x6000428")]
			internal T3 <OnRegisterPorts>b__2()
			{
				return (T3)null;
			}
		}

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 a;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T2 b;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T3 c;

		[Token(Token = "0x6000422")]
		public abstract void Invoke(TInstance instance, out T1 a, out T2 b, out T3 c);

		[Token(Token = "0x6000423")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x6000424")]
		protected ExtractorNode()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public abstract class ExtractorNode<TInstance, T1, T2, T3, T4> : ExtractorNode
	{
		[Token(Token = "0x20000F6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4320", Offset = "0x9E4320")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000292")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ExtractorNode<TInstance, T1, T2, T3, T4> <>4__this;

			[Token(Token = "0x4000293")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<TInstance> i;

			[Token(Token = "0x600042C")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x600042D")]
			internal T1 <OnRegisterPorts>b__0()
			{
				return (T1)null;
			}

			[Token(Token = "0x600042E")]
			internal T2 <OnRegisterPorts>b__1()
			{
				return (T2)null;
			}

			[Token(Token = "0x600042F")]
			internal T3 <OnRegisterPorts>b__2()
			{
				return (T3)null;
			}

			[Token(Token = "0x6000430")]
			internal T4 <OnRegisterPorts>b__3()
			{
				return (T4)null;
			}
		}

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 a;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T2 b;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T3 c;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T4 d;

		[Token(Token = "0x6000429")]
		public abstract void Invoke(TInstance instance, out T1 a, out T2 b, out T3 c, out T4 d);

		[Token(Token = "0x600042A")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x600042B")]
		protected ExtractorNode()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public abstract class ExtractorNode<TInstance, T1, T2, T3, T4, T5> : ExtractorNode
	{
		[Token(Token = "0x20000F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4330", Offset = "0x9E4330")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000299")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ExtractorNode<TInstance, T1, T2, T3, T4, T5> <>4__this;

			[Token(Token = "0x400029A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<TInstance> i;

			[Token(Token = "0x6000434")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000435")]
			internal T1 <OnRegisterPorts>b__0()
			{
				return (T1)null;
			}

			[Token(Token = "0x6000436")]
			internal T2 <OnRegisterPorts>b__1()
			{
				return (T2)null;
			}

			[Token(Token = "0x6000437")]
			internal T3 <OnRegisterPorts>b__2()
			{
				return (T3)null;
			}

			[Token(Token = "0x6000438")]
			internal T4 <OnRegisterPorts>b__3()
			{
				return (T4)null;
			}

			[Token(Token = "0x6000439")]
			internal T5 <OnRegisterPorts>b__4()
			{
				return (T5)null;
			}
		}

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 a;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T2 b;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T3 c;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T4 d;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T5 e;

		[Token(Token = "0x6000431")]
		public abstract void Invoke(TInstance instance, out T1 a, out T2 b, out T3 c, out T4 d, out T5 e);

		[Token(Token = "0x6000432")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x6000433")]
		protected ExtractorNode()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public abstract class ExtractorNode<TInstance, T1, T2, T3, T4, T5, T6> : ExtractorNode
	{
		[Token(Token = "0x20000FA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E4340", Offset = "0x9E4340")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ExtractorNode<TInstance, T1, T2, T3, T4, T5, T6> <>4__this;

			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<TInstance> i;

			[Token(Token = "0x600043D")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600043E")]
			internal T1 <OnRegisterPorts>b__0()
			{
				return (T1)null;
			}

			[Token(Token = "0x600043F")]
			internal T2 <OnRegisterPorts>b__1()
			{
				return (T2)null;
			}

			[Token(Token = "0x6000440")]
			internal T3 <OnRegisterPorts>b__2()
			{
				return (T3)null;
			}

			[Token(Token = "0x6000441")]
			internal T4 <OnRegisterPorts>b__3()
			{
				return (T4)null;
			}

			[Token(Token = "0x6000442")]
			internal T5 <OnRegisterPorts>b__4()
			{
				return (T5)null;
			}

			[Token(Token = "0x6000443")]
			internal T6 <OnRegisterPorts>b__5()
			{
				return (T6)null;
			}
		}

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 a;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T2 b;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T3 c;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T4 d;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T5 e;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T6 f;

		[Token(Token = "0x600043A")]
		public abstract void Invoke(TInstance instance, out T1 a, out T2 b, out T3 c, out T4 d, out T5 e, out T6 f);

		[Token(Token = "0x600043B")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x600043C")]
		protected ExtractorNode()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	[ExposeAsDefinition]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4350", Offset = "0x9E4350")]
	public class AddDictionaryItem<T> : CallableFunctionNode<IDictionary<string, T>, IDictionary<string, T>, string, T>
	{
		[Token(Token = "0x6000444")]
		public override IDictionary<string, T> Invoke(IDictionary<string, T> dict, string key, T item)
		{
			return null;
		}

		[Token(Token = "0x6000445")]
		public AddDictionaryItem()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E439C", Offset = "0x9E439C")]
	[ExposeAsDefinition]
	public class GetDictionaryItem<T> : CallableFunctionNode<T, IDictionary<string, T>, string>
	{
		[Token(Token = "0x6000446")]
		public override T Invoke(IDictionary<string, T> dict, string key)
		{
			return (T)null;
		}

		[Token(Token = "0x6000447")]
		public GetDictionaryItem()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	[ExposeAsDefinition]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E43E8", Offset = "0x9E43E8")]
	public class RemoveDictionaryKey<T> : CallableFunctionNode<IDictionary<string, T>, IDictionary<string, T>, string>
	{
		[Token(Token = "0x6000448")]
		public override IDictionary<string, T> Invoke(IDictionary<string, T> dict, string key)
		{
			return null;
		}

		[Token(Token = "0x6000449")]
		public RemoveDictionaryKey()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	[ExposeAsDefinition]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4434", Offset = "0x9E4434")]
	public class ClearDictionary : CallableFunctionNode<IDictionary, IDictionary>
	{
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1361B94", Offset = "0x1361B94", VA = "0x1361B94", Slot = "12")]
		public override IDictionary Invoke(IDictionary dict)
		{
			return null;
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1361C48", Offset = "0x1361C48", VA = "0x1361C48")]
		public ClearDictionary()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4480", Offset = "0x9E4480")]
	[ExposeAsDefinition]
	public class TryGetValue<T> : CallableFunctionNode<T, IDictionary<string, T>, string>
	{
		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E9B64", Offset = "0x9E9B64")]
		private bool <exists>k__BackingField;

		[Token(Token = "0x17000063")]
		public bool exists
		{
			[Token(Token = "0x600044C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAE44", Offset = "0x9EAE44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600044D")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAE54", Offset = "0x9EAE54")]
			private set
			{
			}
		}

		[Token(Token = "0x600044E")]
		public override T Invoke(IDictionary<string, T> dict, string key)
		{
			return (T)null;
		}

		[Token(Token = "0x600044F")]
		public TryGetValue()
		{
		}
	}
	[Token(Token = "0x2000100")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E44CC", Offset = "0x9E44CC")]
	[ExposeAsDefinition]
	public class DictionaryContainsKey<T> : CallableFunctionNode<bool, IDictionary<string, T>, string>
	{
		[Token(Token = "0x6000450")]
		public override bool Invoke(IDictionary<string, T> dict, string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000451")]
		public DictionaryContainsKey()
		{
		}
	}
	[Token(Token = "0x2000101")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4518", Offset = "0x9E4518")]
	public class ClearList : CallableFunctionNode<IList, IList>
	{
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1361C94", Offset = "0x1361C94", VA = "0x1361C94", Slot = "12")]
		public override IList Invoke(IList list)
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1361D48", Offset = "0x1361D48", VA = "0x1361D48")]
		public ClearList()
		{
		}
	}
	[Token(Token = "0x2000102")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4550", Offset = "0x9E4550")]
	[ExposeAsDefinition]
	public class AddListItem<T> : CallableFunctionNode<IList<T>, List<T>, T>
	{
		[Token(Token = "0x6000454")]
		public override IList<T> Invoke(List<T> list, T item)
		{
			return null;
		}

		[Token(Token = "0x6000455")]
		public AddListItem()
		{
		}
	}
	[Token(Token = "0x2000103")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E459C", Offset = "0x9E459C")]
	[ExposeAsDefinition]
	public class InsertListItem<T> : CallableFunctionNode<IList<T>, List<T>, int, T>
	{
		[Token(Token = "0x6000456")]
		public override IList<T> Invoke(List<T> list, int index, T item)
		{
			return null;
		}

		[Token(Token = "0x6000457")]
		public InsertListItem()
		{
		}
	}
	[Token(Token = "0x2000104")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E45E8", Offset = "0x9E45E8")]
	[ExposeAsDefinition]
	public class RemoveListItem<T> : CallableFunctionNode<IList<T>, List<T>, T>
	{
		[Token(Token = "0x6000458")]
		public override IList<T> Invoke(List<T> list, T item)
		{
			return null;
		}

		[Token(Token = "0x6000459")]
		public RemoveListItem()
		{
		}
	}
	[Token(Token = "0x2000105")]
	[ExposeAsDefinition]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4634", Offset = "0x9E4634")]
	public class RemoveListItemAt<T> : CallableFunctionNode<IList<T>, List<T>, int>
	{
		[Token(Token = "0x600045A")]
		public override IList<T> Invoke(List<T> list, int index)
		{
			return null;
		}

		[Token(Token = "0x600045B")]
		public RemoveListItemAt()
		{
		}
	}
	[Token(Token = "0x2000106")]
	[ExposeAsDefinition]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4680", Offset = "0x9E4680")]
	public class SetListItem<T> : CallableFunctionNode<IList<T>, IList<T>, int, T>
	{
		[Token(Token = "0x600045C")]
		public override IList<T> Invoke(IList<T> list, int index, T item)
		{
			return null;
		}

		[Token(Token = "0x600045D")]
		public SetListItem()
		{
		}
	}
	[Token(Token = "0x2000107")]
	[ExposeAsDefinition]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E46CC", Offset = "0x9E46CC")]
	public class ShuffleList<T> : CallableFunctionNode<IList<T>, IList<T>>
	{
		[Token(Token = "0x600045E")]
		public override IList<T> Invoke(IList<T> list)
		{
			return null;
		}

		[Token(Token = "0x600045F")]
		public ShuffleList()
		{
		}
	}
	[Token(Token = "0x2000108")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4718", Offset = "0x9E4718")]
	[ExposeAsDefinition]
	public class GetListItem<T> : PureFunctionNode<T, IList<T>, int>
	{
		[Token(Token = "0x6000460")]
		public override T Invoke(IList<T> list, int index)
		{
			return (T)null;
		}

		[Token(Token = "0x6000461")]
		public GetListItem()
		{
		}
	}
	[Token(Token = "0x2000109")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4764", Offset = "0x9E4764")]
	[ExposeAsDefinition]
	public class GetRandomListItem<T> : PureFunctionNode<T, IList<T>>
	{
		[Token(Token = "0x6000462")]
		public override T Invoke(IList<T> list)
		{
			return (T)null;
		}

		[Token(Token = "0x6000463")]
		public GetRandomListItem()
		{
		}
	}
	[Token(Token = "0x200010A")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E47B0", Offset = "0x9E47B0")]
	[ExposeAsDefinition]
	public class GetLastListItem<T> : PureFunctionNode<T, IList<T>>
	{
		[Token(Token = "0x6000464")]
		public override T Invoke(IList<T> list)
		{
			return (T)null;
		}

		[Token(Token = "0x6000465")]
		public GetLastListItem()
		{
		}
	}
	[Token(Token = "0x200010B")]
	[ExposeAsDefinition]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E47FC", Offset = "0x9E47FC")]
	public class GetFirstListItem<T> : PureFunctionNode<T, IList<T>>
	{
		[Token(Token = "0x6000466")]
		public override T Invoke(IList<T> list)
		{
			return (T)null;
		}

		[Token(Token = "0x6000467")]
		public GetFirstListItem()
		{
		}
	}
	[Token(Token = "0x200010C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4848", Offset = "0x9E4848")]
	[ExposeAsDefinition]
	public class GetListItemIndex : PureFunctionNode<int, IList, object>
	{
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1504F1C", Offset = "0x1504F1C", VA = "0x1504F1C", Slot = "12")]
		public override int Invoke(IList list, object item)
		{
			return default(int);
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1504FD8", Offset = "0x1504FD8", VA = "0x1504FD8")]
		public GetListItemIndex()
		{
		}
	}
	[Token(Token = "0x200010D")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4894", Offset = "0x9E4894")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E4894", Offset = "0x9E4894")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E4894", Offset = "0x9E4894")]
	public class IsNotNull : PureFunctionNode<bool, object>
	{
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1510178", Offset = "0x1510178", VA = "0x1510178", Slot = "12")]
		public override bool Invoke(object OBJECT)
		{
			return default(bool);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x15101B0", Offset = "0x15101B0", VA = "0x15101B0")]
		public IsNotNull()
		{
		}
	}
	[Token(Token = "0x200010E")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E491C", Offset = "0x9E491C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E491C", Offset = "0x9E491C")]
	public class IsOfType : PureFunctionNode<bool, object, Type>
	{
		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E9B74", Offset = "0x9E9B74")]
		private object <OBJECT>k__BackingField;

		[Token(Token = "0x17000064")]
		public object OBJECT
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x15101FC", Offset = "0x15101FC", VA = "0x15101FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAE64", Offset = "0x9EAE64")]
			get
			{
				return null;
			}
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x1510204", Offset = "0x1510204", VA = "0x1510204")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAE74", Offset = "0x9EAE74")]
			private set
			{
			}
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x151020C", Offset = "0x151020C", VA = "0x151020C", Slot = "12")]
		public override bool Invoke(object OBJECT, Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x15102C0", Offset = "0x15102C0", VA = "0x15102C0")]
		public IsOfType()
		{
		}
	}
	[Token(Token = "0x200010F")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E497C", Offset = "0x9E497C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E497C", Offset = "0x9E497C")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E497C", Offset = "0x9E497C")]
	public class AnyGreaterThan : PureFunctionNode<bool, IComparable, IComparable>
	{
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x135845C", Offset = "0x135845C", VA = "0x135845C", Slot = "12")]
		public override bool Invoke(IComparable a, IComparable b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1358520", Offset = "0x1358520", VA = "0x1358520")]
		public AnyGreaterThan()
		{
		}
	}
	[Token(Token = "0x2000110")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E4A04", Offset = "0x9E4A04")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4A04", Offset = "0x9E4A04")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E4A04", Offset = "0x9E4A04")]
	public class AnyGreaterEqualThan : PureFunctionNode<bool, IComparable, IComparable>
	{
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1358330", Offset = "0x1358330", VA = "0x1358330", Slot = "12")]
		public override bool Invoke(IComparable a, IComparable b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x1358410", Offset = "0x1358410", VA = "0x1358410")]
		public AnyGreaterEqualThan()
		{
		}
	}
	[Token(Token = "0x2000111")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E4A8C", Offset = "0x9E4A8C")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E4A8C", Offset = "0x9E4A8C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4A8C", Offset = "0x9E4A8C")]
	public class AnyLessThan : PureFunctionNode<bool, IComparable, IComparable>
	{
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x135869C", Offset = "0x135869C", VA = "0x135869C", Slot = "12")]
		public override bool Invoke(IComparable a, IComparable b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1358760", Offset = "0x1358760", VA = "0x1358760")]
		public AnyLessThan()
		{
		}
	}
	[Token(Token = "0x2000112")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E4B14", Offset = "0x9E4B14")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E4B14", Offset = "0x9E4B14")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4B14", Offset = "0x9E4B14")]
	public class AnyLessEqualThan : PureFunctionNode<bool, IComparable, IComparable>
	{
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x135856C", Offset = "0x135856C", VA = "0x135856C", Slot = "12")]
		public override bool Invoke(IComparable a, IComparable b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1358650", Offset = "0x1358650", VA = "0x1358650")]
		public AnyLessEqualThan()
		{
		}
	}
	[Token(Token = "0x2000113")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E4B9C", Offset = "0x9E4B9C")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E4B9C", Offset = "0x9E4B9C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4B9C", Offset = "0x9E4B9C")]
	public class AnyEqual : PureFunctionNode<bool, object, object>
	{
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x13582D4", Offset = "0x13582D4", VA = "0x13582D4", Slot = "12")]
		public override bool Invoke(object a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x13582E4", Offset = "0x13582E4", VA = "0x13582E4")]
		public AnyEqual()
		{
		}
	}
	[Token(Token = "0x2000114")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E4C24", Offset = "0x9E4C24")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E4C24", Offset = "0x9E4C24")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4C24", Offset = "0x9E4C24")]
	public class AnyNotEqual : PureFunctionNode<bool, object, object>
	{
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x13587AC", Offset = "0x13587AC", VA = "0x13587AC", Slot = "12")]
		public override bool Invoke(object a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x13587D4", Offset = "0x13587D4", VA = "0x13587D4")]
		public AnyNotEqual()
		{
		}
	}
	[Token(Token = "0x2000115")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4CAC", Offset = "0x9E4CAC")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E4CAC", Offset = "0x9E4CAC")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E4CAC", Offset = "0x9E4CAC")]
	public class FloatAdd : PureFunctionNode<float, float, float>
	{
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x136AD10", Offset = "0x136AD10", VA = "0x136AD10", Slot = "12")]
		public override float Invoke(float a, float b)
		{
			return default(float);
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x136AD18", Offset = "0x136AD18", VA = "0x136AD18")]
		public FloatAdd()
		{
		}
	}
	[Token(Token = "0x2000116")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4D34", Offset = "0x9E4D34")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E4D34", Offset = "0x9E4D34")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E4D34", Offset = "0x9E4D34")]
	public class FloatSubtract : PureFunctionNode<float, float, float>
	{
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x136B1D4", Offset = "0x136B1D4", VA = "0x136B1D4", Slot = "12")]
		public override float Invoke(float a, float b)
		{
			return default(float);
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x136B1DC", Offset = "0x136B1DC", VA = "0x136B1DC")]
		public FloatSubtract()
		{
		}
	}
	[Token(Token = "0x2000117")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4DBC", Offset = "0x9E4DBC")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E4DBC", Offset = "0x9E4DBC")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E4DBC", Offset = "0x9E4DBC")]
	public class FloatMultiply : PureFunctionNode<float, float, float>
	{
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x136B014", Offset = "0x136B014", VA = "0x136B014", Slot = "12")]
		public override float Invoke(float a, float b)
		{
			return default(float);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x136B01C", Offset = "0x136B01C", VA = "0x136B01C")]
		public FloatMultiply()
		{
		}
	}
	[Token(Token = "0x2000118")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4E44", Offset = "0x9E4E44")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E4E44", Offset = "0x9E4E44")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E4E44", Offset = "0x9E4E44")]
	public class FloatDivide : PureFunctionNode<float, float, float>
	{
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x136AD64", Offset = "0x136AD64", VA = "0x136AD64", Slot = "12")]
		public override float Invoke(float a, float b)
		{
			return default(float);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x136AD6C", Offset = "0x136AD6C", VA = "0x136AD6C")]
		public FloatDivide()
		{
		}
	}
	[Token(Token = "0x2000119")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4ECC", Offset = "0x9E4ECC")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E4ECC", Offset = "0x9E4ECC")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E4ECC", Offset = "0x9E4ECC")]
	public class FloatModulo : PureFunctionNode<float, float, float>
	{
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x136AFC4", Offset = "0x136AFC4", VA = "0x136AFC4", Slot = "12")]
		public override float Invoke(float value, float mod)
		{
			return default(float);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x136AFC8", Offset = "0x136AFC8", VA = "0x136AFC8")]
		public FloatModulo()
		{
		}
	}
	[Token(Token = "0x200011A")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E4F54", Offset = "0x9E4F54")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4F54", Offset = "0x9E4F54")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E4F54", Offset = "0x9E4F54")]
	public class FloatGreaterThan : PureFunctionNode<bool, float, float>
	{
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x136AE68", Offset = "0x136AE68", VA = "0x136AE68", Slot = "12")]
		public override bool Invoke(float a, float b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x136AE74", Offset = "0x136AE74", VA = "0x136AE74")]
		public FloatGreaterThan()
		{
		}
	}
	[Token(Token = "0x200011B")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E4FDC", Offset = "0x9E4FDC")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E4FDC", Offset = "0x9E4FDC")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E4FDC", Offset = "0x9E4FDC")]
	public class FloatGreaterEqualThan : PureFunctionNode<bool, float, float>
	{
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x136AE10", Offset = "0x136AE10", VA = "0x136AE10", Slot = "12")]
		public override bool Invoke(float a, float b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x136AE1C", Offset = "0x136AE1C", VA = "0x136AE1C")]
		public FloatGreaterEqualThan()
		{
		}
	}
	[Token(Token = "0x200011C")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E5064", Offset = "0x9E5064")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E5064", Offset = "0x9E5064")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E5064", Offset = "0x9E5064")]
	public class FloatLessThan : PureFunctionNode<bool, float, float>
	{
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x136AF6C", Offset = "0x136AF6C", VA = "0x136AF6C", Slot = "12")]
		public override bool Invoke(float a, float b)
		{
			return default(bool);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x136AF78", Offset = "0x136AF78", VA = "0x136AF78")]
		public FloatLessThan()
		{
		}
	}
	[Token(Token = "0x200011D")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E50EC", Offset = "0x9E50EC")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E50EC", Offset = "0x9E50EC")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E50EC", Offset = "0x9E50EC")]
	public class FloatLessEqualThan : PureFunctionNode<bool, float, float>
	{
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x136AF14", Offset = "0x136AF14", VA = "0x136AF14", Slot = "12")]
		public override bool Invoke(float a, float b)
		{
			return default(bool);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x136AF20", Offset = "0x136AF20", VA = "0x136AF20")]
		public FloatLessEqualThan()
		{
		}
	}
	[Token(Token = "0x200011E")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E5174", Offset = "0x9E5174")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E5174", Offset = "0x9E5174")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E5174", Offset = "0x9E5174")]
	public class FloatEqual : PureFunctionNode<bool, float, float>
	{
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x136ADB8", Offset = "0x136ADB8", VA = "0x136ADB8", Slot = "12")]
		public override bool Invoke(float a, float b)
		{
			return default(bool);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x136ADC4", Offset = "0x136ADC4", VA = "0x136ADC4")]
		public FloatEqual()
		{
		}
	}
	[Token(Token = "0x200011F")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E51FC", Offset = "0x9E51FC")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E51FC", Offset = "0x9E51FC")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E51FC", Offset = "0x9E51FC")]
	public class FloatNotEqual : PureFunctionNode<bool, float, float>
	{
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x136B068", Offset = "0x136B068", VA = "0x136B068", Slot = "12")]
		public override bool Invoke(float a, float b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x136B074", Offset = "0x136B074", VA = "0x136B074")]
		public FloatNotEqual()
		{
		}
	}
	[Token(Token = "0x2000120")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E5284", Offset = "0x9E5284")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E5284", Offset = "0x9E5284")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E5284", Offset = "0x9E5284")]
	public class FloatInvert : PureFunctionNode<float, float>
	{
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x136AEC0", Offset = "0x136AEC0", VA = "0x136AEC0", Slot = "12")]
		public override float Invoke(float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x136AEC8", Offset = "0x136AEC8", VA = "0x136AEC8")]
		public FloatInvert()
		{
		}
	}
	[Token(Token = "0x2000121")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E530C", Offset = "0x9E530C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E530C", Offset = "0x9E530C")]
	public class FloatSnap : PureFunctionNode<int, float, int>
	{
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x136B0C0", Offset = "0x136B0C0", VA = "0x136B0C0", Slot = "12")]
		public override int Invoke(float value, int interval)
		{
			return default(int);
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x136B188", Offset = "0x136B188", VA = "0x136B188")]
		public FloatSnap()
		{
		}
	}
	[Token(Token = "0x2000122")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E536C", Offset = "0x9E536C")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E536C", Offset = "0x9E536C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E536C", Offset = "0x9E536C")]
	public class IntegerAdd : PureFunctionNode<int, int, int>
	{
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x150FC5C", Offset = "0x150FC5C", VA = "0x150FC5C", Slot = "12")]
		public override int Invoke(int a, int b)
		{
			return default(int);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x150FC64", Offset = "0x150FC64", VA = "0x150FC64")]
		public IntegerAdd()
		{
		}
	}
	[Token(Token = "0x2000123")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E53F4", Offset = "0x9E53F4")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E53F4", Offset = "0x9E53F4")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E53F4", Offset = "0x9E53F4")]
	public class IntegerSubtract : PureFunctionNode<int, int, int>
	{
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x1510124", Offset = "0x1510124", VA = "0x1510124", Slot = "12")]
		public override int Invoke(int a, int b)
		{
			return default(int);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x151012C", Offset = "0x151012C", VA = "0x151012C")]
		public IntegerSubtract()
		{
		}
	}
	[Token(Token = "0x2000124")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E547C", Offset = "0x9E547C")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E547C", Offset = "0x9E547C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E547C", Offset = "0x9E547C")]
	public class IntegerMultiply : PureFunctionNode<int, int, int>
	{
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x150FF70", Offset = "0x150FF70", VA = "0x150FF70", Slot = "12")]
		public override int Invoke(int a, int b)
		{
			return default(int);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x150FF78", Offset = "0x150FF78", VA = "0x150FF78")]
		public IntegerMultiply()
		{
		}
	}
	[Token(Token = "0x2000125")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E5504", Offset = "0x9E5504")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E5504", Offset = "0x9E5504")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E5504", Offset = "0x9E5504")]
	public class IntegerDivide : PureFunctionNode<int, int, int>
	{
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x150FCB0", Offset = "0x150FCB0", VA = "0x150FCB0", Slot = "12")]
		public override int Invoke(int a, int b)
		{
			return default(int);
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x150FCC0", Offset = "0x150FCC0", VA = "0x150FCC0")]
		public IntegerDivide()
		{
		}
	}
	[Token(Token = "0x2000126")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E558C", Offset = "0x9E558C")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E558C", Offset = "0x9E558C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E558C", Offset = "0x9E558C")]
	public class IntegerModulo : PureFunctionNode<int, int, int>
	{
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x150FF18", Offset = "0x150FF18", VA = "0x150FF18", Slot = "12")]
		public override int Invoke(int value, int mod)
		{
			return default(int);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x150FF24", Offset = "0x150FF24", VA = "0x150FF24")]
		public IntegerModulo()
		{
		}
	}
	[Token(Token = "0x2000127")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E5614", Offset = "0x9E5614")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E5614", Offset = "0x9E5614")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E5614", Offset = "0x9E5614")]
	public class IntegerGreaterThan : PureFunctionNode<bool, int, int>
	{
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x150FDBC", Offset = "0x150FDBC", VA = "0x150FDBC", Slot = "12")]
		public override bool Invoke(int a, int b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x150FDC8", Offset = "0x150FDC8", VA = "0x150FDC8")]
		public IntegerGreaterThan()
		{
		}
	}
	[Token(Token = "0x2000128")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E569C", Offset = "0x9E569C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E569C", Offset = "0x9E569C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E569C", Offset = "0x9E569C")]
	public class IntegerGreaterEqualThan : PureFunctionNode<bool, int, int>
	{
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x150FD64", Offset = "0x150FD64", VA = "0x150FD64", Slot = "12")]
		public override bool Invoke(int a, int b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x150FD70", Offset = "0x150FD70", VA = "0x150FD70")]
		public IntegerGreaterEqualThan()
		{
		}
	}
	[Token(Token = "0x2000129")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E5724", Offset = "0x9E5724")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E5724", Offset = "0x9E5724")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E5724", Offset = "0x9E5724")]
	public class IntegerLessThan : PureFunctionNode<bool, int, int>
	{
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x150FEC0", Offset = "0x150FEC0", VA = "0x150FEC0", Slot = "12")]
		public override bool Invoke(int a, int b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x150FECC", Offset = "0x150FECC", VA = "0x150FECC")]
		public IntegerLessThan()
		{
		}
	}
	[Token(Token = "0x200012A")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E57AC", Offset = "0x9E57AC")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E57AC", Offset = "0x9E57AC")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E57AC", Offset = "0x9E57AC")]
	public class IntegerLessEqualThan : PureFunctionNode<bool, int, int>
	{
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x150FE68", Offset = "0x150FE68", VA = "0x150FE68", Slot = "12")]
		public override bool Invoke(int a, int b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x150FE74", Offset = "0x150FE74", VA = "0x150FE74")]
		public IntegerLessEqualThan()
		{
		}
	}
	[Token(Token = "0x200012B")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E5834", Offset = "0x9E5834")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E5834", Offset = "0x9E5834")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E5834", Offset = "0x9E5834")]
	public class IntegerEqual : PureFunctionNode<bool, int, int>
	{
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x150FD0C", Offset = "0x150FD0C", VA = "0x150FD0C", Slot = "12")]
		public override bool Invoke(int a, int b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x150FD18", Offset = "0x150FD18", VA = "0x150FD18")]
		public IntegerEqual()
		{
		}
	}
	[Token(Token = "0x200012C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E58BC", Offset = "0x9E58BC")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E58BC", Offset = "0x9E58BC")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E58BC", Offset = "0x9E58BC")]
	public class IntegerNotEqual : PureFunctionNode<bool, int, int>
	{
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x150FFC4", Offset = "0x150FFC4", VA = "0x150FFC4", Slot = "12")]
		public override bool Invoke(int a, int b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x150FFD0", Offset = "0x150FFD0", VA = "0x150FFD0")]
		public IntegerNotEqual()
		{
		}
	}
	[Token(Token = "0x200012D")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E5944", Offset = "0x9E5944")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E5944", Offset = "0x9E5944")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E5944", Offset = "0x9E5944")]
	public class IntegerInvert : PureFunctionNode<int, int>
	{
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x150FE14", Offset = "0x150FE14", VA = "0x150FE14", Slot = "12")]
		public override int Invoke(int value)
		{
			return default(int);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x150FE1C", Offset = "0x150FE1C", VA = "0x150FE1C")]
		public IntegerInvert()
		{
		}
	}
	[Token(Token = "0x200012E")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E59CC", Offset = "0x9E59CC")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E59CC", Offset = "0x9E59CC")]
	public class IntegerSnap : PureFunctionNode<int, int, int>
	{
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x151001C", Offset = "0x151001C", VA = "0x151001C", Slot = "12")]
		public override int Invoke(int value, int interval)
		{
			return default(int);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x15100D8", Offset = "0x15100D8", VA = "0x15100D8")]
		public IntegerSnap()
		{
		}
	}
	[Token(Token = "0x200012F")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E5A2C", Offset = "0x9E5A2C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E5A2C", Offset = "0x9E5A2C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E5A2C", Offset = "0x9E5A2C")]
	public class BooleanEqual : PureFunctionNode<bool, bool, bool>
	{
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x135F608", Offset = "0x135F608", VA = "0x135F608", Slot = "12")]
		public override bool Invoke(bool a, bool b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x135F614", Offset = "0x135F614", VA = "0x135F614")]
		public BooleanEqual()
		{
		}
	}
	[Token(Token = "0x2000130")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E5AB4", Offset = "0x9E5AB4")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E5AB4", Offset = "0x9E5AB4")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E5AB4", Offset = "0x9E5AB4")]
	public class BooleanNotEqual : PureFunctionNode<bool, bool, bool>
	{
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x135F660", Offset = "0x135F660", VA = "0x135F660", Slot = "12")]
		public override bool Invoke(bool a, bool b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x135F66C", Offset = "0x135F66C", VA = "0x135F66C")]
		public BooleanNotEqual()
		{
		}
	}
	[Token(Token = "0x2000131")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E5B3C", Offset = "0x9E5B3C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E5B3C", Offset = "0x9E5B3C")]
	public class AND : PureFunctionNode<bool, bool, bool>
	{
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1356004", Offset = "0x1356004", VA = "0x1356004", Slot = "12")]
		public override bool Invoke(bool a, bool b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x1356010", Offset = "0x1356010", VA = "0x1356010")]
		public AND()
		{
		}
	}
	[Token(Token = "0x2000132")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E5B9C", Offset = "0x9E5B9C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E5B9C", Offset = "0x9E5B9C")]
	public class OR : PureFunctionNode<bool, bool, bool>
	{
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x151BD38", Offset = "0x151BD38", VA = "0x151BD38", Slot = "12")]
		public override bool Invoke(bool a, bool b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x151BD44", Offset = "0x151BD44", VA = "0x151BD44")]
		public OR()
		{
		}
	}
	[Token(Token = "0x2000133")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E5BFC", Offset = "0x9E5BFC")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E5BFC", Offset = "0x9E5BFC")]
	public class XOR : PureFunctionNode<bool, bool, bool>
	{
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1457384", Offset = "0x1457384", VA = "0x1457384", Slot = "12")]
		public override bool Invoke(bool a, bool b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1457390", Offset = "0x1457390", VA = "0x1457390")]
		public XOR()
		{
		}
	}
	[Token(Token = "0x2000134")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E5C5C", Offset = "0x9E5C5C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E5C5C", Offset = "0x9E5C5C")]
	public class NOT : PureFunctionNode<bool, bool>
	{
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x151A1C0", Offset = "0x151A1C0", VA = "0x151A1C0", Slot = "12")]
		public override bool Invoke(bool value)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x151A1CC", Offset = "0x151A1CC", VA = "0x151A1CC")]
		public NOT()
		{
		}
	}
	[Token(Token = "0x2000135")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E5CBC", Offset = "0x9E5CBC")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E5CBC", Offset = "0x9E5CBC")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E5CBC", Offset = "0x9E5CBC")]
	public class Vector3Equal : PureFunctionNode<bool, Vector3, Vector3>
	{
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1456604", Offset = "0x1456604", VA = "0x1456604", Slot = "12")]
		public override bool Invoke(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x145660C", Offset = "0x145660C", VA = "0x145660C")]
		public Vector3Equal()
		{
		}
	}
	[Token(Token = "0x2000136")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E5D44", Offset = "0x9E5D44")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E5D44", Offset = "0x9E5D44")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E5D44", Offset = "0x9E5D44")]
	public class Vector3NotEqual : PureFunctionNode<bool, Vector3, Vector3>
	{
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1456710", Offset = "0x1456710", VA = "0x1456710", Slot = "12")]
		public override bool Invoke(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1456718", Offset = "0x1456718", VA = "0x1456718")]
		public Vector3NotEqual()
		{
		}
	}
	[Token(Token = "0x2000137")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E5DCC", Offset = "0x9E5DCC")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E5DCC", Offset = "0x9E5DCC")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E5DCC", Offset = "0x9E5DCC")]
	public class Vector3Add : PureFunctionNode<Vector3, Vector3, Vector3>
	{
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x145654C", Offset = "0x145654C", VA = "0x145654C", Slot = "12")]
		public override Vector3 Invoke(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x145655C", Offset = "0x145655C", VA = "0x145655C")]
		public Vector3Add()
		{
		}
	}
	[Token(Token = "0x2000138")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E5E54", Offset = "0x9E5E54")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E5E54", Offset = "0x9E5E54")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E5E54", Offset = "0x9E5E54")]
	public class Vector3Subtract : PureFunctionNode<Vector3, Vector3, Vector3>
	{
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1456764", Offset = "0x1456764", VA = "0x1456764", Slot = "12")]
		public override Vector3 Invoke(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1456774", Offset = "0x1456774", VA = "0x1456774")]
		public Vector3Subtract()
		{
		}
	}
	[Token(Token = "0x2000139")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E5EDC", Offset = "0x9E5EDC")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E5EDC", Offset = "0x9E5EDC")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E5EDC", Offset = "0x9E5EDC")]
	public class Vector3Multiply : PureFunctionNode<Vector3, Vector3, float>
	{
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x14566B4", Offset = "0x14566B4", VA = "0x14566B4", Slot = "12")]
		public override Vector3 Invoke(Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x14566C4", Offset = "0x14566C4", VA = "0x14566C4")]
		public Vector3Multiply()
		{
		}
	}
	[Token(Token = "0x200013A")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E5F64", Offset = "0x9E5F64")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E5F64", Offset = "0x9E5F64")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E5F64", Offset = "0x9E5F64")]
	public class Vector3Divide : PureFunctionNode<Vector3, Vector3, float>
	{
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x14565A8", Offset = "0x14565A8", VA = "0x14565A8", Slot = "12")]
		public override Vector3 Invoke(Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x14565B8", Offset = "0x14565B8", VA = "0x14565B8")]
		public Vector3Divide()
		{
		}
	}
	[Token(Token = "0x200013B")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E5FEC", Offset = "0x9E5FEC")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E5FEC", Offset = "0x9E5FEC")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E5FEC", Offset = "0x9E5FEC")]
	public class Vector3Invert : PureFunctionNode<Vector3, Vector3>
	{
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1456658", Offset = "0x1456658", VA = "0x1456658", Slot = "12")]
		public override Vector3 Invoke(Vector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1456668", Offset = "0x1456668", VA = "0x1456668")]
		public Vector3Invert()
		{
		}
	}
	[Token(Token = "0x200013C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E6074", Offset = "0x9E6074")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E6074", Offset = "0x9E6074")]
	public class Wait : LatentActionNode<float>
	{
		[Token(Token = "0x200013D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E60D4", Offset = "0x9E60D4")]
		private sealed class <Invoke>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Wait <>4__this;

			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float time;

			[Token(Token = "0x17000067")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004D3")]
				[Address(RVA = "0x26A8C94", Offset = "0x26A8C94", VA = "0x26A8C94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000068")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004D5")]
				[Address(RVA = "0x26A8CDC", Offset = "0x26A8CDC", VA = "0x26A8CDC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x26A8BAC", Offset = "0x26A8BAC", VA = "0x26A8BAC")]
			[DebuggerHidden]
			public <Invoke>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x26A8BD8", Offset = "0x26A8BD8", VA = "0x26A8BD8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x26A8BDC", Offset = "0x26A8BDC", VA = "0x26A8BDC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x26A8C9C", Offset = "0x26A8C9C", VA = "0x26A8C9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E9B84", Offset = "0x9E9B84")]
		private float <timeLeft>k__BackingField;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E9B94", Offset = "0x9E9B94")]
		private float <normalized>k__BackingField;

		[Token(Token = "0x17000065")]
		public float timeLeft
		{
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x1456BFC", Offset = "0x1456BFC", VA = "0x1456BFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAE84", Offset = "0x9EAE84")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x1456C04", Offset = "0x1456C04", VA = "0x1456C04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAE94", Offset = "0x9EAE94")]
			private set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public float normalized
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x1456C0C", Offset = "0x1456C0C", VA = "0x1456C0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAEA4", Offset = "0x9EAEA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x1456C14", Offset = "0x1456C14", VA = "0x1456C14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EAEB4", Offset = "0x9EAEB4")]
			private set
			{
			}
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1456C1C", Offset = "0x1456C1C", VA = "0x1456C1C", Slot = "15")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9EAEC4", Offset = "0x9EAEC4")]
		public override IEnumerator Invoke(float time = 1f)
		{
			return null;
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1456CA4", Offset = "0x1456CA4", VA = "0x1456CA4")]
		public Wait()
		{
		}
	}
	[Token(Token = "0x200013E")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E60E4", Offset = "0x9E60E4")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E60E4", Offset = "0x9E60E4")]
	public class WaitForOneFrame : LatentActionNode
	{
		[Token(Token = "0x200013F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6144", Offset = "0x9E6144")]
		private sealed class <Invoke>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x1700006A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004DC")]
				[Address(RVA = "0x26A8E88", Offset = "0x26A8E88", VA = "0x26A8E88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004DE")]
				[Address(RVA = "0x26A8ED0", Offset = "0x26A8ED0", VA = "0x26A8ED0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x26A8DFC", Offset = "0x26A8DFC", VA = "0x26A8DFC")]
			[DebuggerHidden]
			public <Invoke>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x26A8E28", Offset = "0x26A8E28", VA = "0x26A8E28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x26A8E2C", Offset = "0x26A8E2C", VA = "0x26A8E2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x26A8E90", Offset = "0x26A8E90", VA = "0x26A8E90", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x17000069")]
		public override bool allowRoutineQueueing
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x1456D5C", Offset = "0x1456D5C", VA = "0x1456D5C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1456D64", Offset = "0x1456D64", VA = "0x1456D64", Slot = "15")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9EAF74", Offset = "0x9EAF74")]
		public override IEnumerator Invoke()
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1456DC0", Offset = "0x1456DC0", VA = "0x1456DC0")]
		public WaitForOneFrame()
		{
		}
	}
	[Token(Token = "0x2000140")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E6154", Offset = "0x9E6154")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E6154", Offset = "0x9E6154")]
	public class WaitForPhysicsFrame : LatentActionNode
	{
		[Token(Token = "0x2000141")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E61B4", Offset = "0x9E61B4")]
		private sealed class <Invoke>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x1700006D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004E5")]
				[Address(RVA = "0x26A8FA0", Offset = "0x26A8FA0", VA = "0x26A8FA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004E7")]
				[Address(RVA = "0x26A8FE8", Offset = "0x26A8FE8", VA = "0x26A8FE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x26A8ED8", Offset = "0x26A8ED8", VA = "0x26A8ED8")]
			[DebuggerHidden]
			public <Invoke>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x26A8F04", Offset = "0x26A8F04", VA = "0x26A8F04", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x26A8F08", Offset = "0x26A8F08", VA = "0x26A8F08", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x26A8FA8", Offset = "0x26A8FA8", VA = "0x26A8FA8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public override bool allowRoutineQueueing
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x1456DC8", Offset = "0x1456DC8", VA = "0x1456DC8", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1456DD0", Offset = "0x1456DD0", VA = "0x1456DD0", Slot = "15")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9EB024", Offset = "0x9EB024")]
		public override IEnumerator Invoke()
		{
			return null;
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1456E2C", Offset = "0x1456E2C", VA = "0x1456E2C")]
		public WaitForPhysicsFrame()
		{
		}
	}
	[Token(Token = "0x2000142")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E61C4", Offset = "0x9E61C4")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E61C4", Offset = "0x9E61C4")]
	public class WaitForEndOfFrame : LatentActionNode
	{
		[Token(Token = "0x2000143")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6224", Offset = "0x9E6224")]
		private sealed class <Invoke>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000070")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004EE")]
				[Address(RVA = "0x26A8DAC", Offset = "0x26A8DAC", VA = "0x26A8DAC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004F0")]
				[Address(RVA = "0x26A8DF4", Offset = "0x26A8DF4", VA = "0x26A8DF4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x26A8CE4", Offset = "0x26A8CE4", VA = "0x26A8CE4")]
			[DebuggerHidden]
			public <Invoke>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x26A8D10", Offset = "0x26A8D10", VA = "0x26A8D10", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x26A8D14", Offset = "0x26A8D14", VA = "0x26A8D14", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x26A8DB4", Offset = "0x26A8DB4", VA = "0x26A8DB4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public override bool allowRoutineQueueing
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x1456CF0", Offset = "0x1456CF0", VA = "0x1456CF0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1456CF8", Offset = "0x1456CF8", VA = "0x1456CF8", Slot = "15")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9EB0D4", Offset = "0x9EB0D4")]
		public override IEnumerator Invoke()
		{
			return null;
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1456D54", Offset = "0x1456D54", VA = "0x1456D54")]
		public WaitForEndOfFrame()
		{
		}
	}
	[Token(Token = "0x2000144")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E6234", Offset = "0x9E6234")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E6234", Offset = "0x9E6234")]
	public class WaitUntil : LatentActionNode
	{
		[Token(Token = "0x2000145")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6294", Offset = "0x9E6294")]
		private sealed class <Invoke>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WaitUntil <>4__this;

			[Token(Token = "0x17000073")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004F8")]
				[Address(RVA = "0x26A912C", Offset = "0x26A912C", VA = "0x26A912C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004FA")]
				[Address(RVA = "0x26A9174", Offset = "0x26A9174", VA = "0x26A9174", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x26A8FF0", Offset = "0x26A8FF0", VA = "0x26A8FF0")]
			[DebuggerHidden]
			public <Invoke>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x26A901C", Offset = "0x26A901C", VA = "0x26A901C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x26A9020", Offset = "0x26A9020", VA = "0x26A9020", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x26A9134", Offset = "0x26A9134", VA = "0x26A9134", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ValueInput<bool> condition;

		[Token(Token = "0x17000072")]
		public override bool allowRoutineQueueing
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x1456E34", Offset = "0x1456E34", VA = "0x1456E34", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1456E3C", Offset = "0x1456E3C", VA = "0x1456E3C", Slot = "15")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9EB184", Offset = "0x9EB184")]
		public override IEnumerator Invoke()
		{
			return null;
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x1456EB4", Offset = "0x1456EB4", VA = "0x1456EB4", Slot = "7")]
		protected override void OnRegisterExtraPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1456F54", Offset = "0x1456F54", VA = "0x1456F54")]
		public WaitUntil()
		{
		}
	}
	[Token(Token = "0x2000146")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E62A4", Offset = "0x9E62A4")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E62A4", Offset = "0x9E62A4")]
	public class WaitWhile : LatentActionNode
	{
		[Token(Token = "0x2000147")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6304", Offset = "0x9E6304")]
		private sealed class <Invoke>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WaitWhile <>4__this;

			[Token(Token = "0x17000076")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000502")]
				[Address(RVA = "0x26A92B8", Offset = "0x26A92B8", VA = "0x26A92B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000077")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000504")]
				[Address(RVA = "0x26A9300", Offset = "0x26A9300", VA = "0x26A9300", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x26A917C", Offset = "0x26A917C", VA = "0x26A917C")]
			[DebuggerHidden]
			public <Invoke>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000500")]
			[Address(RVA = "0x26A91A8", Offset = "0x26A91A8", VA = "0x26A91A8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000501")]
			[Address(RVA = "0x26A91AC", Offset = "0x26A91AC", VA = "0x26A91AC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000503")]
			[Address(RVA = "0x26A92C0", Offset = "0x26A92C0", VA = "0x26A92C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ValueInput<bool> condition;

		[Token(Token = "0x17000075")]
		public override bool allowRoutineQueueing
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x1456F5C", Offset = "0x1456F5C", VA = "0x1456F5C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1456F64", Offset = "0x1456F64", VA = "0x1456F64", Slot = "15")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9EB234", Offset = "0x9EB234")]
		public override IEnumerator Invoke()
		{
			return null;
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1456FDC", Offset = "0x1456FDC", VA = "0x1456FDC", Slot = "7")]
		protected override void OnRegisterExtraPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x145707C", Offset = "0x145707C", VA = "0x145707C")]
		public WaitWhile()
		{
		}
	}
	[Token(Token = "0x2000148")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E6314", Offset = "0x9E6314")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E6314", Offset = "0x9E6314")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E6314", Offset = "0x9E6314")]
	public class DeltaTimed : PureFunctionNode<float, float, float>
	{
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1368974", Offset = "0x1368974", VA = "0x1368974", Slot = "12")]
		public override float Invoke(float value, float multiplier = 1f)
		{
			return default(float);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x13689A4", Offset = "0x13689A4", VA = "0x13689A4")]
		public DeltaTimed()
		{
		}
	}
	[Token(Token = "0x2000149")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E639C", Offset = "0x9E639C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E639C", Offset = "0x9E639C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E639C", Offset = "0x9E639C")]
	public class DeltaTimedVector3 : PureFunctionNode<Vector3, Vector3, float>
	{
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x13689F0", Offset = "0x13689F0", VA = "0x13689F0", Slot = "12")]
		public override Vector3 Invoke(Vector3 value, float multiplier = 1f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1368A34", Offset = "0x1368A34", VA = "0x1368A34")]
		public DeltaTimedVector3()
		{
		}
	}
	[Token(Token = "0x200014A")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E6424", Offset = "0x9E6424")]
	[ExposeAsDefinition]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E6424", Offset = "0x9E6424")]
	public class Buffer<T> : PureFunctionNode<T, T, int>
	{
		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int lastFrame;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Queue<T> q;

		[Token(Token = "0x6000509")]
		public override T Invoke(T value, int size = 60)
		{
			return (T)null;
		}

		[Token(Token = "0x600050A")]
		public Buffer()
		{
		}
	}
	[Token(Token = "0x200014B")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E6494", Offset = "0x9E6494")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E6494", Offset = "0x9E6494")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E6494", Offset = "0x9E6494")]
	public class DampFloat : PureFunctionNode<float, float, float, float>
	{
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1368030", Offset = "0x1368030", VA = "0x1368030", Slot = "12")]
		public override float Invoke(float current, float target, float damp = 1f)
		{
			return default(float);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1368074", Offset = "0x1368074", VA = "0x1368074")]
		public DampFloat()
		{
		}
	}
	[Token(Token = "0x200014C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E651C", Offset = "0x9E651C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E651C", Offset = "0x9E651C")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E651C", Offset = "0x9E651C")]
	public class DampVector3 : PureFunctionNode<Vector3, Vector3, Vector3, float>
	{
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x13680C0", Offset = "0x13680C0", VA = "0x13680C0", Slot = "12")]
		public override Vector3 Invoke(Vector3 current, Vector3 target, float damp = 1f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1368144", Offset = "0x1368144", VA = "0x1368144")]
		public DampVector3()
		{
		}
	}
	[Token(Token = "0x200014D")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E65A4", Offset = "0x9E65A4")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E65A4", Offset = "0x9E65A4")]
	public class MoveTo : LatentActionNode<NavMeshAgent, Vector3, float, float>
	{
		[Token(Token = "0x200014E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6604", Offset = "0x9E6604")]
		private sealed class <Invoke>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MoveTo <>4__this;

			[Token(Token = "0x40002BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public NavMeshAgent agent;

			[Token(Token = "0x40002C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float speed;

			[Token(Token = "0x40002C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float stoppingDistance;

			[Token(Token = "0x40002C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 destination;

			[Token(Token = "0x17000078")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000515")]
				[Address(RVA = "0x146ADD8", Offset = "0x146ADD8", VA = "0x146ADD8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000079")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000517")]
				[Address(RVA = "0x146AE20", Offset = "0x146AE20", VA = "0x146AE20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000512")]
			[Address(RVA = "0x146AC94", Offset = "0x146AC94", VA = "0x146AC94")]
			[DebuggerHidden]
			public <Invoke>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000513")]
			[Address(RVA = "0x146ACC0", Offset = "0x146ACC0", VA = "0x146ACC0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000514")]
			[Address(RVA = "0x146ACC4", Offset = "0x146ACC4", VA = "0x146ACC4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000516")]
			[Address(RVA = "0x146ADE0", Offset = "0x146ADE0", VA = "0x146ADE0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private NavMeshAgent agent;

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1519C78", Offset = "0x1519C78", VA = "0x1519C78", Slot = "15")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9EB2E4", Offset = "0x9EB2E4")]
		public override IEnumerator Invoke(NavMeshAgent agent, Vector3 destination, float speed, float stoppingDistance)
		{
			return null;
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1519D44", Offset = "0x1519D44", VA = "0x1519D44", Slot = "13")]
		public override void OnBreak()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1519D60", Offset = "0x1519D60", VA = "0x1519D60")]
		public MoveTo()
		{
		}
	}
	[Token(Token = "0x200014F")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E6614", Offset = "0x9E6614")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E6614", Offset = "0x9E6614")]
	public class AddComponent<T> : CallableFunctionNode<T, GameObject, bool> where T : Component
	{
		[Token(Token = "0x6000518")]
		public override T Invoke(GameObject gameObject, bool tryGetExisting)
		{
			return null;
		}

		[Token(Token = "0x6000519")]
		public AddComponent()
		{
		}
	}
	[Token(Token = "0x2000150")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E6674", Offset = "0x9E6674")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E6674", Offset = "0x9E6674")]
	public class NewScriptableObject<T> : CallableFunctionNode<T> where T : ScriptableObject
	{
		[Token(Token = "0x600051A")]
		public override T Invoke()
		{
			return null;
		}

		[Token(Token = "0x600051B")]
		public NewScriptableObject()
		{
		}
	}
	[Token(Token = "0x2000151")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E66D4", Offset = "0x9E66D4")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E66D4", Offset = "0x9E66D4")]
	public class GetComponent<T> : PureFunctionNode<T, GameObject> where T : Component
	{
		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T _component;

		[Token(Token = "0x600051C")]
		public override T Invoke(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x600051D")]
		public GetComponent()
		{
		}
	}
	[Token(Token = "0x2000152")]
	[ExposeAsDefinition]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E6734", Offset = "0x9E6734")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E6734", Offset = "0x9E6734")]
	public class Instantiate<T> : CallableFunctionNode<T, T, Vector3, Quaternion, Transform> where T : UnityEngine.Object
	{
		[Token(Token = "0x600051E")]
		public override T Invoke(T original, Vector3 position, Quaternion rotation, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600051F")]
		public Instantiate()
		{
		}
	}
	[Token(Token = "0x2000153")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E67A4", Offset = "0x9E67A4")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E67A4", Offset = "0x9E67A4")]
	public class GetChildTransforms : PureFunctionNode<IEnumerable<Transform>, Transform>
	{
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1504E84", Offset = "0x1504E84", VA = "0x1504E84", Slot = "12")]
		public override IEnumerable<Transform> Invoke(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1504ED0", Offset = "0x1504ED0", VA = "0x1504ED0")]
		public GetChildTransforms()
		{
		}
	}
	[Token(Token = "0x2000154")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E6804", Offset = "0x9E6804")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E6804", Offset = "0x9E6804")]
	[ExposeAsDefinition]
	public class Cast<T> : PureFunctionNode<T, object>
	{
		[Token(Token = "0x6000522")]
		public override T Invoke(object obj)
		{
			return (T)null;
		}

		[Token(Token = "0x6000523")]
		public Cast()
		{
		}
	}
	[Token(Token = "0x2000155")]
	[ExposeAsDefinition]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E6874", Offset = "0x9E6874")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E6874", Offset = "0x9E6874")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E6874", Offset = "0x9E6874")]
	public class Identity<T> : PureFunctionNode<T, T>
	{
		[Token(Token = "0x1700007A")]
		public override string name
		{
			[Token(Token = "0x6000524")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000525")]
		public override T Invoke(T value)
		{
			return (T)null;
		}

		[Token(Token = "0x6000526")]
		public Identity()
		{
		}
	}
	[Token(Token = "0x2000156")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E690C", Offset = "0x9E690C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E690C", Offset = "0x9E690C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E690C", Offset = "0x9E690C")]
	[ExposeAsDefinition]
	public class Cache<T> : CallableFunctionNode<T, T>
	{
		[Token(Token = "0x6000527")]
		public override T Invoke(T value)
		{
			return (T)null;
		}

		[Token(Token = "0x6000528")]
		public Cache()
		{
		}
	}
	[Token(Token = "0x2000157")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E69A4", Offset = "0x9E69A4")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E69A4", Offset = "0x9E69A4")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E69A4", Offset = "0x9E69A4")]
	public class RemapFloat : PureFunctionNode<float, float, float, float, float, float>
	{
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1BBE108", Offset = "0x1BBE108", VA = "0x1BBE108", Slot = "12")]
		public override float Invoke(float current, float iMin, float iMax = 1f, float oMin = 0f, float oMax = 100f)
		{
			return default(float);
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1BBE150", Offset = "0x1BBE150", VA = "0x1BBE150")]
		public RemapFloat()
		{
		}
	}
	[Token(Token = "0x2000158")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E6A2C", Offset = "0x9E6A2C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E6A2C", Offset = "0x9E6A2C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E6A2C", Offset = "0x9E6A2C")]
	public class RemapVector3 : PureFunctionNode<Vector3, float, float, float, Vector3, Vector3>
	{
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1BBE19C", Offset = "0x1BBE19C", VA = "0x1BBE19C", Slot = "12")]
		public override Vector3 Invoke(float current, float iMin, float iMax, Vector3 oMin, Vector3 oMax)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1BBE21C", Offset = "0x1BBE21C", VA = "0x1BBE21C")]
		public RemapVector3()
		{
		}
	}
	[Token(Token = "0x2000159")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E6AB4", Offset = "0x9E6AB4")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E6AB4", Offset = "0x9E6AB4")]
	public class LogValue : CallableActionNode<object>
	{
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x15127BC", Offset = "0x15127BC", VA = "0x15127BC", Slot = "12")]
		public override void Invoke(object obj)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1512820", Offset = "0x1512820", VA = "0x1512820")]
		public LogValue()
		{
		}
	}
	[Token(Token = "0x200015A")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E6B14", Offset = "0x9E6B14")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E6B14", Offset = "0x9E6B14")]
	public class LogText : CallableActionNode<string>
	{
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x151270C", Offset = "0x151270C", VA = "0x151270C", Slot = "12")]
		public override void Invoke(string text)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x1512770", Offset = "0x1512770", VA = "0x1512770")]
		public LogText()
		{
		}
	}
	[Token(Token = "0x200015B")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E6B74", Offset = "0x9E6B74")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E6B74", Offset = "0x9E6B74")]
	public class SendEvent : CallableActionNode<GraphOwner, string>
	{
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1BBE418", Offset = "0x1BBE418", VA = "0x1BBE418", Slot = "12")]
		public override void Invoke(GraphOwner target, string eventName)
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1BBE49C", Offset = "0x1BBE49C", VA = "0x1BBE49C")]
		public SendEvent()
		{
		}
	}
	[Token(Token = "0x200015C")]
	[ExposeAsDefinition]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E6BD4", Offset = "0x9E6BD4")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E6BD4", Offset = "0x9E6BD4")]
	public class SendEvent<T> : CallableActionNode<GraphOwner, string, T>
	{
		[Token(Token = "0x6000533")]
		public override void Invoke(GraphOwner target, string eventName, T eventValue)
		{
		}

		[Token(Token = "0x6000534")]
		public SendEvent()
		{
		}
	}
	[Token(Token = "0x200015D")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E6C44", Offset = "0x9E6C44")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E6C44", Offset = "0x9E6C44")]
	public class SendGlobalEvent : CallableActionNode<string>
	{
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1BBE4E8", Offset = "0x1BBE4E8", VA = "0x1BBE4E8", Slot = "12")]
		public override void Invoke(string eventName)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1BBE58C", Offset = "0x1BBE58C", VA = "0x1BBE58C")]
		public SendGlobalEvent()
		{
		}
	}
	[Token(Token = "0x200015E")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E6CA4", Offset = "0x9E6CA4")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E6CA4", Offset = "0x9E6CA4")]
	[ExposeAsDefinition]
	public class SendGlobalEvent<T> : CallableActionNode<string, T>
	{
		[Token(Token = "0x6000537")]
		public override void Invoke(string eventName, T eventValue)
		{
		}

		[Token(Token = "0x6000538")]
		public SendGlobalEvent()
		{
		}
	}
	[Token(Token = "0x200015F")]
	public abstract class LatentActionNodeBase : SimplexNode
	{
		[Token(Token = "0x2000160")]
		public enum InvocationMode
		{
			[Token(Token = "0x40002CD")]
			QueueCalls,
			[Token(Token = "0x40002CE")]
			FilterCalls
		}

		[Token(Token = "0x2000161")]
		private struct RoutineData
		{
			[Token(Token = "0x40002CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IEnumerator enumerator;

			[Token(Token = "0x40002D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Flow flow;

			[Token(Token = "0x6000547")]
			[Address(RVA = "0x146A44C", Offset = "0x146A44C", VA = "0x146A44C")]
			public RoutineData(IEnumerator enumerator, Flow flow)
			{
			}
		}

		[Token(Token = "0x2000162")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6D14", Offset = "0x9E6D14")]
		private sealed class <InternalCoroutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LatentActionNodeBase <>4__this;

			[Token(Token = "0x40002D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RoutineData data;

			[Token(Token = "0x1700007D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600054B")]
				[Address(RVA = "0x146A3FC", Offset = "0x146A3FC", VA = "0x146A3FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600054D")]
				[Address(RVA = "0x146A444", Offset = "0x146A444", VA = "0x146A444", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000548")]
			[Address(RVA = "0x146A038", Offset = "0x146A038", VA = "0x146A038")]
			[DebuggerHidden]
			public <InternalCoroutine>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000549")]
			[Address(RVA = "0x146A064", Offset = "0x146A064", VA = "0x146A064", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600054A")]
			[Address(RVA = "0x146A068", Offset = "0x146A068", VA = "0x146A068", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0x146A404", Offset = "0x146A404", VA = "0x146A404", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InvocationMode invocationMode;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private FlowOutput onStart;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private FlowOutput onUpdate;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private FlowOutput onFinish;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Queue<RoutineData> routineQueue;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine currentCoroutine;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool graphStoped;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool graphPaused;

		[Token(Token = "0x1700007B")]
		public override string name
		{
			[Token(Token = "0x6000539")]
			[Address(RVA = "0x1511FE0", Offset = "0x1511FE0", VA = "0x1511FE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public virtual bool allowRoutineQueueing
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x1512460", Offset = "0x1512460", VA = "0x1512460", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x15120A8", Offset = "0x15120A8", VA = "0x15120A8", Slot = "8")]
		public sealed override void OnGraphStarted()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x15120B0", Offset = "0x15120B0", VA = "0x15120B0", Slot = "11")]
		public sealed override void OnGraphStoped()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1512194", Offset = "0x1512194", VA = "0x1512194", Slot = "9")]
		public sealed override void OnGraphPaused()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x15121A0", Offset = "0x15121A0", VA = "0x15121A0", Slot = "10")]
		public sealed override void OnGraphUnpaused()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1511E44", Offset = "0x1511E44", VA = "0x1511E44")]
		protected void Begin(IEnumerator enumerator, Flow f)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x15120BC", Offset = "0x15120BC", VA = "0x15120BC")]
		protected void BreakAll()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x15121A8", Offset = "0x15121A8", VA = "0x15121A8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9EB394", Offset = "0x9EB394")]
		private IEnumerator InternalCoroutine(RoutineData data)
		{
			return null;
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1512254", Offset = "0x1512254", VA = "0x1512254", Slot = "6")]
		protected override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x6000542")]
		protected abstract void OnRegisterDerivedPorts(FlowNode node);

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x151245C", Offset = "0x151245C", VA = "0x151245C", Slot = "13")]
		public virtual void OnBreak()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1511DE0", Offset = "0x1511DE0", VA = "0x1511DE0")]
		protected LatentActionNodeBase()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1512468", Offset = "0x1512468", VA = "0x1512468")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB3F4", Offset = "0x9EB3F4")]
		private void <OnRegisterPorts>b__19_0(Flow f)
		{
		}
	}
	[Token(Token = "0x2000163")]
	public abstract class LatentActionNode : LatentActionNodeBase
	{
		[Token(Token = "0x600054E")]
		public abstract IEnumerator Invoke();

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1511D14", Offset = "0x1511D14", VA = "0x1511D14", Slot = "12")]
		protected sealed override void OnRegisterDerivedPorts(FlowNode node)
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1511DD8", Offset = "0x1511DD8", VA = "0x1511DD8")]
		protected LatentActionNode()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1511DE8", Offset = "0x1511DE8", VA = "0x1511DE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB454", Offset = "0x9EB454")]
		private void <OnRegisterDerivedPorts>b__1_0(Flow f)
		{
		}
	}
	[Token(Token = "0x2000164")]
	public abstract class LatentActionNode<T1> : LatentActionNodeBase
	{
		[Token(Token = "0x2000165")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6D24", Offset = "0x9E6D24")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40002D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LatentActionNode<T1> <>4__this;

			[Token(Token = "0x40002D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x6000555")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000556")]
			internal void <OnRegisterDerivedPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x6000552")]
		public abstract IEnumerator Invoke(T1 a);

		[Token(Token = "0x6000553")]
		protected sealed override void OnRegisterDerivedPorts(FlowNode node)
		{
		}

		[Token(Token = "0x6000554")]
		protected LatentActionNode()
		{
		}
	}
	[Token(Token = "0x2000166")]
	public abstract class LatentActionNode<T1, T2> : LatentActionNodeBase
	{
		[Token(Token = "0x2000167")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6D34", Offset = "0x9E6D34")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40002D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LatentActionNode<T1, T2> <>4__this;

			[Token(Token = "0x40002D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x40002D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x600055A")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600055B")]
			internal void <OnRegisterDerivedPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x6000557")]
		public abstract IEnumerator Invoke(T1 a, T2 b);

		[Token(Token = "0x6000558")]
		protected sealed override void OnRegisterDerivedPorts(FlowNode node)
		{
		}

		[Token(Token = "0x6000559")]
		protected LatentActionNode()
		{
		}
	}
	[Token(Token = "0x2000168")]
	public abstract class LatentActionNode<T1, T2, T3> : LatentActionNodeBase
	{
		[Token(Token = "0x2000169")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6D44", Offset = "0x9E6D44")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40002DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LatentActionNode<T1, T2, T3> <>4__this;

			[Token(Token = "0x40002DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x40002DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x40002DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x600055F")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000560")]
			internal void <OnRegisterDerivedPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x600055C")]
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c);

		[Token(Token = "0x600055D")]
		protected sealed override void OnRegisterDerivedPorts(FlowNode node)
		{
		}

		[Token(Token = "0x600055E")]
		protected LatentActionNode()
		{
		}
	}
	[Token(Token = "0x200016A")]
	public abstract class LatentActionNode<T1, T2, T3, T4> : LatentActionNodeBase
	{
		[Token(Token = "0x200016B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6D54", Offset = "0x9E6D54")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40002DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LatentActionNode<T1, T2, T3, T4> <>4__this;

			[Token(Token = "0x40002DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x40002E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x40002E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x40002E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x6000564")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000565")]
			internal void <OnRegisterDerivedPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x6000561")]
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d);

		[Token(Token = "0x6000562")]
		protected sealed override void OnRegisterDerivedPorts(FlowNode node)
		{
		}

		[Token(Token = "0x6000563")]
		protected LatentActionNode()
		{
		}
	}
	[Token(Token = "0x200016C")]
	public abstract class LatentActionNode<T1, T2, T3, T4, T5> : LatentActionNodeBase
	{
		[Token(Token = "0x200016D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6D64", Offset = "0x9E6D64")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40002E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LatentActionNode<T1, T2, T3, T4, T5> <>4__this;

			[Token(Token = "0x40002E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x40002E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x40002E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x40002E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x40002E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x6000569")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600056A")]
			internal void <OnRegisterDerivedPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x6000566")]
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e);

		[Token(Token = "0x6000567")]
		protected sealed override void OnRegisterDerivedPorts(FlowNode node)
		{
		}

		[Token(Token = "0x6000568")]
		protected LatentActionNode()
		{
		}
	}
	[Token(Token = "0x200016E")]
	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6> : LatentActionNodeBase
	{
		[Token(Token = "0x200016F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6D74", Offset = "0x9E6D74")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40002E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LatentActionNode<T1, T2, T3, T4, T5, T6> <>4__this;

			[Token(Token = "0x40002EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x40002EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x40002EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x40002ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x40002EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x40002EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x600056E")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600056F")]
			internal void <OnRegisterDerivedPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x600056B")]
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);

		[Token(Token = "0x600056C")]
		protected sealed override void OnRegisterDerivedPorts(FlowNode node)
		{
		}

		[Token(Token = "0x600056D")]
		protected LatentActionNode()
		{
		}
	}
	[Token(Token = "0x2000170")]
	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6, T7> : LatentActionNodeBase
	{
		[Token(Token = "0x2000171")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6D84", Offset = "0x9E6D84")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40002F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LatentActionNode<T1, T2, T3, T4, T5, T6, T7> <>4__this;

			[Token(Token = "0x40002F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x40002F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x40002F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x40002F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x40002F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x40002F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x40002F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T7> p7;

			[Token(Token = "0x6000573")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000574")]
			internal void <OnRegisterDerivedPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x6000570")]
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);

		[Token(Token = "0x6000571")]
		protected sealed override void OnRegisterDerivedPorts(FlowNode node)
		{
		}

		[Token(Token = "0x6000572")]
		protected LatentActionNode()
		{
		}
	}
	[Token(Token = "0x2000172")]
	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6, T7, T8> : LatentActionNodeBase
	{
		[Token(Token = "0x2000173")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6D94", Offset = "0x9E6D94")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40002F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LatentActionNode<T1, T2, T3, T4, T5, T6, T7, T8> <>4__this;

			[Token(Token = "0x40002F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x40002FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x40002FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x40002FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x40002FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x40002FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x40002FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T7> p7;

			[Token(Token = "0x4000300")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T8> p8;

			[Token(Token = "0x6000578")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000579")]
			internal void <OnRegisterDerivedPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x6000575")]
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);

		[Token(Token = "0x6000576")]
		protected sealed override void OnRegisterDerivedPorts(FlowNode node)
		{
		}

		[Token(Token = "0x6000577")]
		protected LatentActionNode()
		{
		}
	}
	[Token(Token = "0x2000174")]
	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9> : LatentActionNodeBase
	{
		[Token(Token = "0x2000175")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6DA4", Offset = "0x9E6DA4")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000301")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LatentActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9> <>4__this;

			[Token(Token = "0x4000302")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x4000303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x4000305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x4000306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x4000307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x4000308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T7> p7;

			[Token(Token = "0x4000309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T8> p8;

			[Token(Token = "0x400030A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T9> p9;

			[Token(Token = "0x600057D")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600057E")]
			internal void <OnRegisterDerivedPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x600057A")]
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i);

		[Token(Token = "0x600057B")]
		protected sealed override void OnRegisterDerivedPorts(FlowNode node)
		{
		}

		[Token(Token = "0x600057C")]
		protected LatentActionNode()
		{
		}
	}
	[Token(Token = "0x2000176")]
	public abstract class LatentActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : LatentActionNodeBase
	{
		[Token(Token = "0x2000177")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6DB4", Offset = "0x9E6DB4")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400030B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LatentActionNode<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> <>4__this;

			[Token(Token = "0x400030C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x400030D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x400030E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x400030F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x4000310")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x4000311")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x4000312")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T7> p7;

			[Token(Token = "0x4000313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T8> p8;

			[Token(Token = "0x4000314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T9> p9;

			[Token(Token = "0x4000315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T10> p10;

			[Token(Token = "0x6000582")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000583")]
			internal void <OnRegisterDerivedPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x600057F")]
		public abstract IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j);

		[Token(Token = "0x6000580")]
		protected sealed override void OnRegisterDerivedPorts(FlowNode node)
		{
		}

		[Token(Token = "0x6000581")]
		protected LatentActionNode()
		{
		}
	}
	[Token(Token = "0x2000178")]
	public abstract class PureFunctionNodeBase : SimplexNode
	{
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x151EBBC", Offset = "0x151EBBC", VA = "0x151EBBC")]
		protected PureFunctionNodeBase()
		{
		}
	}
	[Token(Token = "0x2000179")]
	public abstract class PureFunctionNode<TResult> : PureFunctionNodeBase
	{
		[Token(Token = "0x6000585")]
		public abstract TResult Invoke();

		[Token(Token = "0x6000586")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x6000587")]
		protected PureFunctionNode()
		{
		}

		[Token(Token = "0x6000588")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB464", Offset = "0x9EB464")]
		private TResult <OnRegisterPorts>b__1_0()
		{
			return (TResult)null;
		}
	}
	[Token(Token = "0x200017A")]
	public abstract class PureFunctionNode<TResult, T1> : PureFunctionNodeBase
	{
		[Token(Token = "0x200017B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6DC4", Offset = "0x9E6DC4")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public PureFunctionNode<TResult, T1> <>4__this;

			[Token(Token = "0x4000317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x600058C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600058D")]
			internal TResult <OnRegisterPorts>b__0()
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x6000589")]
		public abstract TResult Invoke(T1 a);

		[Token(Token = "0x600058A")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x600058B")]
		protected PureFunctionNode()
		{
		}
	}
	[Token(Token = "0x200017C")]
	public abstract class PureFunctionNode<TResult, T1, T2> : PureFunctionNodeBase
	{
		[Token(Token = "0x200017D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6DD4", Offset = "0x9E6DD4")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000318")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public PureFunctionNode<TResult, T1, T2> <>4__this;

			[Token(Token = "0x4000319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x400031A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x6000591")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000592")]
			internal TResult <OnRegisterPorts>b__0()
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x600058E")]
		public abstract TResult Invoke(T1 a, T2 b);

		[Token(Token = "0x600058F")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x6000590")]
		protected PureFunctionNode()
		{
		}
	}
	[Token(Token = "0x200017E")]
	public abstract class PureFunctionNode<TResult, T1, T2, T3> : PureFunctionNodeBase
	{
		[Token(Token = "0x200017F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6DE4", Offset = "0x9E6DE4")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400031B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public PureFunctionNode<TResult, T1, T2, T3> <>4__this;

			[Token(Token = "0x400031C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x400031D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x400031E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x6000596")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000597")]
			internal TResult <OnRegisterPorts>b__0()
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x6000593")]
		public abstract TResult Invoke(T1 a, T2 b, T3 c);

		[Token(Token = "0x6000594")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x6000595")]
		protected PureFunctionNode()
		{
		}
	}
	[Token(Token = "0x2000180")]
	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4> : PureFunctionNodeBase
	{
		[Token(Token = "0x2000181")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6DF4", Offset = "0x9E6DF4")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400031F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public PureFunctionNode<TResult, T1, T2, T3, T4> <>4__this;

			[Token(Token = "0x4000320")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x4000321")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x4000322")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x4000323")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x600059B")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600059C")]
			internal TResult <OnRegisterPorts>b__0()
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x6000598")]
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d);

		[Token(Token = "0x6000599")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x600059A")]
		protected PureFunctionNode()
		{
		}
	}
	[Token(Token = "0x2000182")]
	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5> : PureFunctionNodeBase
	{
		[Token(Token = "0x2000183")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6E04", Offset = "0x9E6E04")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000324")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public PureFunctionNode<TResult, T1, T2, T3, T4, T5> <>4__this;

			[Token(Token = "0x4000325")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x4000326")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x4000327")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x4000328")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x4000329")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x60005A0")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60005A1")]
			internal TResult <OnRegisterPorts>b__0()
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x600059D")]
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e);

		[Token(Token = "0x600059E")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x600059F")]
		protected PureFunctionNode()
		{
		}
	}
	[Token(Token = "0x2000184")]
	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6> : PureFunctionNodeBase
	{
		[Token(Token = "0x2000185")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6E14", Offset = "0x9E6E14")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400032A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6> <>4__this;

			[Token(Token = "0x400032B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x400032C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x400032D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x400032F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x60005A5")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60005A6")]
			internal TResult <OnRegisterPorts>b__0()
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x60005A2")]
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);

		[Token(Token = "0x60005A3")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60005A4")]
		protected PureFunctionNode()
		{
		}
	}
	[Token(Token = "0x2000186")]
	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7> : PureFunctionNodeBase
	{
		[Token(Token = "0x2000187")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6E24", Offset = "0x9E6E24")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7> <>4__this;

			[Token(Token = "0x4000332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x4000333")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x4000334")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x4000335")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x4000336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T7> p7;

			[Token(Token = "0x60005AA")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60005AB")]
			internal TResult <OnRegisterPorts>b__0()
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x60005A7")]
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);

		[Token(Token = "0x60005A8")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60005A9")]
		protected PureFunctionNode()
		{
		}
	}
	[Token(Token = "0x2000188")]
	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8> : PureFunctionNodeBase
	{
		[Token(Token = "0x2000189")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6E34", Offset = "0x9E6E34")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8> <>4__this;

			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x400033F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x4000340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T7> p7;

			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T8> p8;

			[Token(Token = "0x60005AF")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60005B0")]
			internal TResult <OnRegisterPorts>b__0()
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x60005AC")]
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);

		[Token(Token = "0x60005AD")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60005AE")]
		protected PureFunctionNode()
		{
		}
	}
	[Token(Token = "0x200018A")]
	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9> : PureFunctionNodeBase
	{
		[Token(Token = "0x200018B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6E44", Offset = "0x9E6E44")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9> <>4__this;

			[Token(Token = "0x4000343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x4000344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x4000345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x4000346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x4000347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x4000349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T7> p7;

			[Token(Token = "0x400034A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T8> p8;

			[Token(Token = "0x400034B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T9> p9;

			[Token(Token = "0x60005B4")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60005B5")]
			internal TResult <OnRegisterPorts>b__0()
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x60005B1")]
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i);

		[Token(Token = "0x60005B2")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60005B3")]
		protected PureFunctionNode()
		{
		}
	}
	[Token(Token = "0x200018C")]
	public abstract class PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : PureFunctionNodeBase
	{
		[Token(Token = "0x200018D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6E54", Offset = "0x9E6E54")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public PureFunctionNode<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> <>4__this;

			[Token(Token = "0x400034D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x400034E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x400034F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x4000350")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x4000351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x4000352")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x4000353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T7> p7;

			[Token(Token = "0x4000354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T8> p8;

			[Token(Token = "0x4000355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T9> p9;

			[Token(Token = "0x4000356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T10> p10;

			[Token(Token = "0x60005B9")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60005BA")]
			internal TResult <OnRegisterPorts>b__0()
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x60005B6")]
		public abstract TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j);

		[Token(Token = "0x60005B7")]
		protected sealed override void OnRegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60005B8")]
		protected PureFunctionNode()
		{
		}
	}
	[Token(Token = "0x200018E")]
	[SpoofAOT]
	public abstract class SimplexNode
	{
		[NonSerialized]
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string _name;

		[NonSerialized]
		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _description;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E9BA4", Offset = "0x9E9BA4")]
		private FlowNode <parentNode>k__BackingField;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParameterInfo[] _parameters;

		[Token(Token = "0x1700007F")]
		protected FlowNode parentNode
		{
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x1BC0B78", Offset = "0x1BC0B78", VA = "0x1BC0B78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB474", Offset = "0x9EB474")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x1BC0B80", Offset = "0x1BC0B80", VA = "0x1BC0B80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB484", Offset = "0x9EB484")]
			private set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public virtual string name
		{
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x1BC0B88", Offset = "0x1BC0B88", VA = "0x1BC0B88", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public virtual string description
		{
			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x1BC0CCC", Offset = "0x1BC0CCC", VA = "0x1BC0CCC", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public ParameterInfo[] parameters
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x1BC0DA8", Offset = "0x1BC0DA8", VA = "0x1BC0DA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1BC0E8C", Offset = "0x1BC0E8C", VA = "0x1BC0E8C")]
		public void RegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1BC0FA4", Offset = "0x1BC0FA4", VA = "0x1BC0FA4")]
		public void SetDefaultParameters(FlowNode node)
		{
		}

		[Token(Token = "0x60005C2")]
		protected abstract void OnRegisterPorts(FlowNode node);

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1BC1108", Offset = "0x1BC1108", VA = "0x1BC1108", Slot = "7")]
		protected virtual void OnRegisterExtraPorts(FlowNode node)
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1BC110C", Offset = "0x1BC110C", VA = "0x1BC110C", Slot = "8")]
		public virtual void OnGraphStarted()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1BC1110", Offset = "0x1BC1110", VA = "0x1BC1110", Slot = "9")]
		public virtual void OnGraphPaused()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1BC1114", Offset = "0x1BC1114", VA = "0x1BC1114", Slot = "10")]
		public virtual void OnGraphUnpaused()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1BC1118", Offset = "0x1BC1118", VA = "0x1BC1118", Slot = "11")]
		public virtual void OnGraphStoped()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1BC111C", Offset = "0x1BC111C", VA = "0x1BC111C")]
		protected SimplexNode()
		{
		}
	}
	[Token(Token = "0x200018F")]
	[AttributeAttribute(Name = "IconAttribute", RVA = "0x9E6E74", Offset = "0x9E6E74")]
	[DoNotList]
	public abstract class SimplexNodeWrapper : FlowNode
	{
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1BC1124", Offset = "0x1BC1124", VA = "0x1BC1124")]
		protected SimplexNodeWrapper()
		{
		}
	}
	[Token(Token = "0x2000190")]
	public class SimplexNodeWrapper<T> : SimplexNodeWrapper where T : SimplexNode
	{
		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private T _simplexNode;

		[Token(Token = "0x17000083")]
		public T simplexNode
		{
			[Token(Token = "0x60005CB")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public override string name
		{
			[Token(Token = "0x60005CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public override string description
		{
			[Token(Token = "0x60005CD")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005CA")]
		private Type GetRuntimeIconType()
		{
			return null;
		}

		[Token(Token = "0x60005CE")]
		public override Type GetNodeWildDefinitionType()
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		public override void OnCreate(Graph assignedGraph)
		{
		}

		[Token(Token = "0x60005D0")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x60005D1")]
		public override void OnGraphPaused()
		{
		}

		[Token(Token = "0x60005D2")]
		public override void OnGraphUnpaused()
		{
		}

		[Token(Token = "0x60005D3")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x60005D4")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60005D5")]
		public SimplexNodeWrapper()
		{
		}
	}
	[Token(Token = "0x2000191")]
	public delegate void EventUniversalDelegate();
	[Token(Token = "0x2000192")]
	public delegate void EventUniversalDelegate<in T1>(T1 arg1);
	[Token(Token = "0x2000193")]
	public delegate void EventUniversalDelegate<in T1, in T2>(T1 arg1, T2 arg2);
	[Token(Token = "0x2000194")]
	public delegate void EventUniversalDelegate<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3);
	[Token(Token = "0x2000195")]
	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
	[Token(Token = "0x2000196")]
	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
	[Token(Token = "0x2000197")]
	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
	[Token(Token = "0x2000198")]
	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6, in T7>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
	[Token(Token = "0x2000199")]
	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
	[Token(Token = "0x200019A")]
	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);
	[Token(Token = "0x200019B")]
	public delegate void EventUniversalDelegate<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);
	[Token(Token = "0x200019C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E6EE0", Offset = "0x9E6EE0")]
	public class GeneratedKeyAttribute : Attribute
	{
		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string memberString;

		[Token(Token = "0x17000086")]
		public string MemberName
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x1504E7C", Offset = "0x1504E7C", VA = "0x1504E7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x1504E48", Offset = "0x1504E48", VA = "0x1504E48")]
		public GeneratedKeyAttribute(string memberName)
		{
		}
	}
	[Token(Token = "0x200019D")]
	public struct ParamDef
	{
		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Type paramType;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Type arrayType;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ParamMode paramMode;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string portName;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string portId;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isParamsArray;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MemberInfo presentedInfo;
	}
	[Token(Token = "0x200019E")]
	public enum ParamMode
	{
		[Token(Token = "0x4000365")]
		Undefined = 0,
		[Token(Token = "0x4000366")]
		In = 1,
		[Token(Token = "0x4000367")]
		Out = 2,
		[Token(Token = "0x4000368")]
		Ref = 3,
		[Token(Token = "0x4000369")]
		Instance = 4,
		[Token(Token = "0x400036A")]
		Result = 6
	}
	[Token(Token = "0x200019F")]
	public struct ParametresDef
	{
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<ParamDef> paramDefinitions;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ParamDef instanceDef;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ParamDef resultDef;
	}
	[Token(Token = "0x20001A0")]
	public static class ReflectedNodesHelper
	{
		[Token(Token = "0x400036E")]
		private const string RETURN_VALUE_NAME = "Value";

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x1BB6270", Offset = "0x1BB6270", VA = "0x1BB6270")]
		public static ParamDef GetGetterDefFromInfo(MemberInfo info)
		{
			return default(ParamDef);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x1BB64D8", Offset = "0x1BB64D8", VA = "0x1BB64D8")]
		public static ParamDef GetDefFromInfo(ParameterInfo info, bool last)
		{
			return default(ParamDef);
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x1BB6904", Offset = "0x1BB6904", VA = "0x1BB6904")]
		public static bool InitParams(Type targetType, bool isStatic, MemberInfo[] infos, out ParametresDef parametres)
		{
			return default(bool);
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x1BB6C24", Offset = "0x1BB6C24", VA = "0x1BB6C24")]
		private static bool InitParams(ParameterInfo[] prms, Type returnType, ref ParametresDef parametres)
		{
			return default(bool);
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x1BB6EC0", Offset = "0x1BB6EC0", VA = "0x1BB6EC0")]
		public static bool InitParams(ConstructorInfo constructor, out ParametresDef parametres)
		{
			return default(bool);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x1BB7164", Offset = "0x1BB7164", VA = "0x1BB7164")]
		public static bool InitParams(MethodInfo method, out ParametresDef parametres)
		{
			return default(bool);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x1BB73BC", Offset = "0x1BB73BC", VA = "0x1BB73BC")]
		public static bool InitParams(FieldInfo field, out ParametresDef parametres)
		{
			return default(bool);
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x1BB7604", Offset = "0x1BB7604", VA = "0x1BB7604")]
		public static string GetGeneratedKey(MemberInfo memberInfo)
		{
			return null;
		}
	}
	[Token(Token = "0x20001A1")]
	public delegate void UniversalDelegate(UniversalDelegateParam[] delegateParams);
	[Token(Token = "0x20001A2")]
	public abstract class UniversalDelegateParam
	{
		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ParamDef paramDef;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool paramsArrayNeeded;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int paramsArrayCount;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UniversalDelegate referencedDelegate;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UniversalDelegateParam[] referencedParams;

		[Token(Token = "0x17000087")]
		public abstract FieldInfo ValueField
		{
			[Token(Token = "0x6000617")]
			get;
		}

		[Token(Token = "0x6000610")]
		public abstract Type GetCurrentType();

		[Token(Token = "0x6000611")]
		public abstract void RegisterAsInput(FlowNode node);

		[Token(Token = "0x6000612")]
		public abstract void RegisterAsOutput(FlowNode node);

		[Token(Token = "0x6000613")]
		public abstract void RegisterAsOutput(FlowNode node, Action beforeReturn);

		[Token(Token = "0x6000614")]
		public abstract void RegisterAsOutput(FlowNode node, Action<UniversalDelegateParam> beforeReturn);

		[Token(Token = "0x6000615")]
		public abstract void SetFromInput();

		[Token(Token = "0x6000616")]
		public abstract void SetFromValue(object value);

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x1454F7C", Offset = "0x1454F7C", VA = "0x1454F7C")]
		protected UniversalDelegateParam()
		{
		}
	}
	[Token(Token = "0x20001A3")]
	public class UniversalDelegateParam<T> : UniversalDelegateParam
	{
		[Token(Token = "0x20001A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6EF4", Offset = "0x9E6EF4")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Delegate beforeReturn;

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UniversalDelegateParam<T> <>4__this;

			[Token(Token = "0x6000623")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000624")]
			internal T <RegisterAsOutputInternal>b__0()
			{
				return (T)null;
			}
		}

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T value;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ValueInput<T> valueInput;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FieldInfo _fieldInfo;

		[Token(Token = "0x17000088")]
		public override FieldInfo ValueField
		{
			[Token(Token = "0x6000622")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000619")]
		public UniversalDelegateParam()
		{
		}

		[Token(Token = "0x600061A")]
		public override Type GetCurrentType()
		{
			return null;
		}

		[Token(Token = "0x600061B")]
		public override void RegisterAsInput(FlowNode node)
		{
		}

		[Token(Token = "0x600061C")]
		private void RegisterAsOutputInternal(FlowNode node, Delegate beforeReturn)
		{
		}

		[Token(Token = "0x600061D")]
		public override void RegisterAsOutput(FlowNode node)
		{
		}

		[Token(Token = "0x600061E")]
		public override void RegisterAsOutput(FlowNode node, Action beforeReturn)
		{
		}

		[Token(Token = "0x600061F")]
		public override void RegisterAsOutput(FlowNode node, Action<UniversalDelegateParam> beforeReturn)
		{
		}

		[Token(Token = "0x6000620")]
		public override void SetFromInput()
		{
		}

		[Token(Token = "0x6000621")]
		public override void SetFromValue(object newValue)
		{
		}
	}
	[Token(Token = "0x20001A5")]
	public class UniversalDelegateParam<TArray, TValue> : UniversalDelegateParam<TArray>
	{
		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ValueInput<TValue>[] valueInputs;

		[Token(Token = "0x6000625")]
		public override void RegisterAsInput(FlowNode node)
		{
		}

		[Token(Token = "0x6000626")]
		public override void SetFromInput()
		{
		}

		[Token(Token = "0x6000627")]
		public UniversalDelegateParam()
		{
		}
	}
	[Token(Token = "0x20001A6")]
	public abstract class BaseReflectedConstructorNode
	{
		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected ConstructorInfo constructorInfo;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected List<ParamDef> paramDefinitions;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ParamDef instanceDef;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected ParamDef resultDef;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected ReflectedMethodRegistrationOptions options;

		[Token(Token = "0x14000001")]
		protected static event Func<ConstructorInfo, BaseReflectedConstructorNode> OnGetAotReflectedConstructorNode
		{
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x135A5E4", Offset = "0x135A5E4", VA = "0x135A5E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB494", Offset = "0x9EB494")]
			add
			{
			}
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x135A6A0", Offset = "0x135A6A0", VA = "0x135A6A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB4A4", Offset = "0x9EB4A4")]
			remove
			{
			}
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x135A75C", Offset = "0x135A75C", VA = "0x135A75C")]
		public static BaseReflectedConstructorNode GetConstructorNode(ConstructorInfo targetConstructor, ReflectedMethodRegistrationOptions options)
		{
			return null;
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x135A89C", Offset = "0x135A89C", VA = "0x135A89C")]
		protected bool Init(ConstructorInfo constructor, ParametresDef parametres)
		{
			return default(bool);
		}

		[Token(Token = "0x600062C")]
		protected abstract bool InitInternal(ConstructorInfo constructor);

		[Token(Token = "0x600062D")]
		public abstract void RegisterPorts(FlowNode node, ReflectedMethodRegistrationOptions options);

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x135AA60", Offset = "0x135AA60", VA = "0x135AA60")]
		protected BaseReflectedConstructorNode()
		{
		}
	}
	[Token(Token = "0x20001A7")]
	public class PureReflectionConstructorNode : BaseReflectedConstructorNode
	{
		[Token(Token = "0x20001A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6F04", Offset = "0x9E6F04")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool callable;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PureReflectionConstructorNode <>4__this;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int idx;

			[Token(Token = "0x6000635")]
			[Address(RVA = "0x26A4D64", Offset = "0x26A4D64", VA = "0x26A4D64")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000636")]
			[Address(RVA = "0x26A4D6C", Offset = "0x26A4D6C", VA = "0x26A4D6C")]
			internal object <RegisterOutput>b__0()
			{
				return null;
			}
		}

		[Token(Token = "0x20001A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6F14", Offset = "0x9E6F14")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PureReflectionConstructorNode <>4__this;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ReflectedMethodRegistrationOptions options;

			[Token(Token = "0x6000637")]
			[Address(RVA = "0x26A4C98", Offset = "0x26A4C98", VA = "0x26A4C98")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000638")]
			[Address(RVA = "0x26A4CA0", Offset = "0x26A4CA0", VA = "0x26A4CA0")]
			internal object <RegisterPorts>b__0()
			{
				return null;
			}
		}

		[Token(Token = "0x20001AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6F24", Offset = "0x9E6F24")]
		private sealed class <>c__DisplayClass10_1
		{
			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FlowOutput output;

			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass10_0 CS$<>8__locals1;

			[Token(Token = "0x6000639")]
			[Address(RVA = "0x26A4CE4", Offset = "0x26A4CE4", VA = "0x26A4CE4")]
			public <>c__DisplayClass10_1()
			{
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0x26A4CEC", Offset = "0x26A4CEC", VA = "0x26A4CEC")]
			internal void <RegisterPorts>b__1(Flow flow)
			{
			}
		}

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private object resultObject;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private object[] callParams;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ValueInput[] inputs;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ValueInput[] arrayInputs;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int arrayParamsInput;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Type arrayParamsType;

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x1BAFFCC", Offset = "0x1BAFFCC", VA = "0x1BAFFCC", Slot = "4")]
		protected override bool InitInternal(ConstructorInfo constructor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x1BB0150", Offset = "0x1BB0150", VA = "0x1BB0150")]
		private void Call()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x1BB0310", Offset = "0x1BB0310", VA = "0x1BB0310")]
		private void RegisterOutput(FlowNode node, bool callable, ParamDef def, int idx)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x1BB0414", Offset = "0x1BB0414", VA = "0x1BB0414")]
		private void RegisterInput(FlowNode node, ParamDef def, int idx)
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x1BB05F4", Offset = "0x1BB05F4", VA = "0x1BB05F4", Slot = "5")]
		public override void RegisterPorts(FlowNode node, ReflectedMethodRegistrationOptions options)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x1BB0994", Offset = "0x1BB0994", VA = "0x1BB0994")]
		public PureReflectionConstructorNode()
		{
		}
	}
	[Token(Token = "0x20001AB")]
	[SpoofAOT]
	public class ReflectedDelegateEvent
	{
		[Token(Token = "0x20001AC")]
		public delegate void DelegateEventCallback(params object[] args);

		[Serializable]
		[Token(Token = "0x20001AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6F44", Offset = "0x9E6F44")]
		private sealed class <>c
		{
			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<ParameterInfo, Type> <>9__10_0;

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x26A5038", Offset = "0x26A5038", VA = "0x26A5038")]
			public <>c()
			{
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x26A5040", Offset = "0x26A5040", VA = "0x26A5040")]
			internal Type <GetMethodForDelegateType>b__10_0(ParameterInfo p)
			{
				return null;
			}
		}

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Delegate theDelegate;

		[Token(Token = "0x14000002")]
		private event DelegateEventCallback onCallback
		{
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x1BB2C50", Offset = "0x1BB2C50", VA = "0x1BB2C50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB4B4", Offset = "0x9EB4B4")]
			add
			{
			}
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x1BB2CF0", Offset = "0x1BB2CF0", VA = "0x1BB2CF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB4C4", Offset = "0x9EB4C4")]
			remove
			{
			}
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x1BB2D90", Offset = "0x1BB2D90", VA = "0x1BB2D90")]
		public ReflectedDelegateEvent()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1BB2D98", Offset = "0x1BB2D98", VA = "0x1BB2D98")]
		public ReflectedDelegateEvent(Type delegateType)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x1BB34B4", Offset = "0x1BB34B4", VA = "0x1BB34B4")]
		public void Add(DelegateEventCallback callback)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x1BB34B8", Offset = "0x1BB34B8", VA = "0x1BB34B8")]
		public void Remove(DelegateEventCallback callback)
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x1BB34BC", Offset = "0x1BB34BC", VA = "0x1BB34BC")]
		public Delegate AsDelegate()
		{
			return null;
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x1BB2E3C", Offset = "0x1BB2E3C", VA = "0x1BB2E3C")]
		private MethodInfo GetMethodForDelegateType(Type delegateType)
		{
			return null;
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1BB34C4", Offset = "0x1BB34C4", VA = "0x1BB34C4")]
		public void Callback0()
		{
		}

		[Token(Token = "0x6000644")]
		public void Callback1<T0>(T0 arg0)
		{
		}

		[Token(Token = "0x6000645")]
		public void Callback2<T0, T1>(T0 arg0, T1 arg1)
		{
		}

		[Token(Token = "0x6000646")]
		public void Callback3<T0, T1, T2>(T0 arg0, T1 arg1, T2 arg2)
		{
		}

		[Token(Token = "0x6000647")]
		public void Callback4<T0, T1, T2, T3>(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Token(Token = "0x6000648")]
		public void Callback5<T0, T1, T2, T3, T4>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Token(Token = "0x6000649")]
		public void Callback6<T0, T1, T2, T3, T4, T5>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Token(Token = "0x600064A")]
		public void Callback7<T0, T1, T2, T3, T4, T5, T6>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Token(Token = "0x600064B")]
		public void Callback8<T0, T1, T2, T3, T4, T5, T6, T7>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Token(Token = "0x600064C")]
		public void Callback9<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Token(Token = "0x600064D")]
		public void Callback10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x1BB35A8", Offset = "0x1BB35A8", VA = "0x1BB35A8")]
		public static explicit operator Delegate(ReflectedDelegateEvent that)
		{
			return null;
		}
	}
	[Token(Token = "0x20001AE")]
	[SpoofAOT]
	public class ReflectedUnityEvent
	{
		[Token(Token = "0x20001AF")]
		public delegate void UnityEventCallback(params object[] args);

		[Serializable]
		[Token(Token = "0x20001B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6F64", Offset = "0x9E6F64")]
		private sealed class <>c
		{
			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<ParameterInfo, Type> <>9__15_0;

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x26A58C8", Offset = "0x26A58C8", VA = "0x26A58C8")]
			public <>c()
			{
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x26A58D0", Offset = "0x26A58D0", VA = "0x26A58D0")]
			internal Type <InitForEventType>b__15_0(ParameterInfo p)
			{
				return null;
			}
		}

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Type _eventType;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MethodInfo _addListenerMethod;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MethodInfo _removeListenerMethod;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParameterInfo[] _parameters;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MethodInfo _callMethod;

		[Token(Token = "0x17000089")]
		public ParameterInfo[] parameters
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x1BB784C", Offset = "0x1BB784C", VA = "0x1BB784C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		public Type eventType
		{
			[Token(Token = "0x6000659")]
			[Address(RVA = "0x1BB7854", Offset = "0x1BB7854", VA = "0x1BB7854")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000003")]
		private event UnityEventCallback _callback
		{
			[Token(Token = "0x6000656")]
			[Address(RVA = "0x1BB770C", Offset = "0x1BB770C", VA = "0x1BB770C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB4D4", Offset = "0x9EB4D4")]
			add
			{
			}
			[Token(Token = "0x6000657")]
			[Address(RVA = "0x1BB77AC", Offset = "0x1BB77AC", VA = "0x1BB77AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB4E4", Offset = "0x9EB4E4")]
			remove
			{
			}
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x1BB785C", Offset = "0x1BB785C", VA = "0x1BB785C")]
		public ReflectedUnityEvent()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x1BB7864", Offset = "0x1BB7864", VA = "0x1BB7864")]
		public ReflectedUnityEvent(Type eventType)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x1BB7894", Offset = "0x1BB7894", VA = "0x1BB7894")]
		public void InitForEventType(Type eventType)
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x1BB804C", Offset = "0x1BB804C", VA = "0x1BB804C")]
		public void StartListening(UnityEventBase targetEvent, UnityEventCallback callback)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x1BB8158", Offset = "0x1BB8158", VA = "0x1BB8158")]
		public void StopListening(UnityEventBase targetEvent, UnityEventCallback callback)
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x1BB8264", Offset = "0x1BB8264", VA = "0x1BB8264")]
		public void CallbackMethod0()
		{
		}

		[Token(Token = "0x6000660")]
		public void CallbackMethod1<T0>(T0 arg0)
		{
		}

		[Token(Token = "0x6000661")]
		public void CallbackMethod2<T0, T1>(T0 arg0, T1 arg1)
		{
		}

		[Token(Token = "0x6000662")]
		public void CallbackMethod3<T0, T1, T2>(T0 arg0, T1 arg1, T2 arg2)
		{
		}

		[Token(Token = "0x6000663")]
		public void CallbackMethod4<T0, T1, T2, T3>(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
		{
		}
	}
	[Token(Token = "0x20001B1")]
	public abstract class SharpEvent
	{
		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E9BF4", Offset = "0x9E9BF4")]
		private object <instance>k__BackingField;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E9C04", Offset = "0x9E9C04")]
		private EventInfo <eventInfo>k__BackingField;

		[Token(Token = "0x1700008B")]
		public object instance
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x1BC0800", Offset = "0x1BC0800", VA = "0x1BC0800")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB4F4", Offset = "0x9EB4F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x1BC0808", Offset = "0x1BC0808", VA = "0x1BC0808")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB504", Offset = "0x9EB504")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public EventInfo eventInfo
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x1BC0810", Offset = "0x1BC0810", VA = "0x1BC0810")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB514", Offset = "0x9EB514")]
			get
			{
				return null;
			}
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x1BC0818", Offset = "0x1BC0818", VA = "0x1BC0818")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB524", Offset = "0x9EB524")]
			private set
			{
			}
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x1BC0820", Offset = "0x1BC0820", VA = "0x1BC0820")]
		public static SharpEvent Create(EventInfo eventInfo)
		{
			return null;
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x1BC0A08", Offset = "0x1BC0A08", VA = "0x1BC0A08")]
		public void SetInstance(object instance)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x1BC0A10", Offset = "0x1BC0A10", VA = "0x1BC0A10")]
		public void StartListening(ReflectedDelegateEvent reflectedEvent, ReflectedDelegateEvent.DelegateEventCallback callback)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x1BC0A70", Offset = "0x1BC0A70", VA = "0x1BC0A70")]
		public void StopListening(ReflectedDelegateEvent reflectedEvent, ReflectedDelegateEvent.DelegateEventCallback callback)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x1BC0AD0", Offset = "0x1BC0AD0", VA = "0x1BC0AD0")]
		protected SharpEvent()
		{
		}
	}
	[Token(Token = "0x20001B2")]
	public class SharpEvent<T> : SharpEvent
	{
		[Token(Token = "0x6000674")]
		public SharpEvent()
		{
		}
	}
	[Token(Token = "0x20001B3")]
	public abstract class BaseReflectedExtractorNode
	{
		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E9C24", Offset = "0x9E9C24")]
		private ParametresDef <Params>k__BackingField;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E9C34", Offset = "0x9E9C34")]
		private Type <TargetType>k__BackingField;

		[Token(Token = "0x1700008D")]
		protected ParametresDef Params
		{
			[Token(Token = "0x6000678")]
			[Address(RVA = "0x135ADE4", Offset = "0x135ADE4", VA = "0x135ADE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB554", Offset = "0x9EB554")]
			get
			{
				return default(ParametresDef);
			}
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x135ADF4", Offset = "0x135ADF4", VA = "0x135ADF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB564", Offset = "0x9EB564")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		protected Type TargetType
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x135AE24", Offset = "0x135AE24", VA = "0x135AE24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB574", Offset = "0x9EB574")]
			get
			{
				return null;
			}
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x135AE2C", Offset = "0x135AE2C", VA = "0x135AE2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB584", Offset = "0x9EB584")]
			private set
			{
			}
		}

		[Token(Token = "0x14000004")]
		protected static event Func<Type, bool, MemberInfo[], BaseReflectedExtractorNode> OnGetAotExtractorNode
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x135AA68", Offset = "0x135AA68", VA = "0x135AA68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB534", Offset = "0x9EB534")]
			add
			{
			}
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x135AB24", Offset = "0x135AB24", VA = "0x135AB24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB544", Offset = "0x9EB544")]
			remove
			{
			}
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x135ABE0", Offset = "0x135ABE0", VA = "0x135ABE0")]
		public static BaseReflectedExtractorNode GetExtractorNode(Type targetType, bool isStatic, MemberInfo[] infos)
		{
			return null;
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x135AD84", Offset = "0x135AD84", VA = "0x135AD84")]
		protected bool Init(ParametresDef paramsDef, Type targetType)
		{
			return default(bool);
		}

		[Token(Token = "0x600067D")]
		protected abstract bool InitInternal();

		[Token(Token = "0x600067E")]
		public abstract void RegisterPorts(FlowNode node);

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x135AE34", Offset = "0x135AE34", VA = "0x135AE34")]
		protected BaseReflectedExtractorNode()
		{
		}
	}
	[Token(Token = "0x20001B4")]
	public class PureReflectedExtractorNode : BaseReflectedExtractorNode
	{
		[Token(Token = "0x20001B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6F74", Offset = "0x9E6F74")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PureReflectedExtractorNode <>4__this;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FieldInfo info;

			[Token(Token = "0x6000686")]
			[Address(RVA = "0x26A4708", Offset = "0x26A4708", VA = "0x26A4708")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000687")]
			[Address(RVA = "0x26A4710", Offset = "0x26A4710", VA = "0x26A4710")]
			internal object <GetPortHandler>b__0()
			{
				return null;
			}
		}

		[Token(Token = "0x20001B6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6F84", Offset = "0x9E6F84")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PureReflectedExtractorNode <>4__this;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MethodInfo info;

			[Token(Token = "0x6000688")]
			[Address(RVA = "0x26A4768", Offset = "0x26A4768", VA = "0x26A4768")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0x26A4770", Offset = "0x26A4770", VA = "0x26A4770")]
			internal object <GetPortHandler>b__0()
			{
				return null;
			}
		}

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly object[] EmptyParams;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ValueInput instanceInput;

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x151EBC4", Offset = "0x151EBC4", VA = "0x151EBC4", Slot = "4")]
		protected override bool InitInternal()
		{
			return default(bool);
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x151EBE4", Offset = "0x151EBE4", VA = "0x151EBE4")]
		private ValueHandlerObject GetPortHandler(FieldInfo info)
		{
			return null;
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x151ECD4", Offset = "0x151ECD4", VA = "0x151ECD4")]
		private ValueHandlerObject GetPortHandler(MethodInfo info)
		{
			return null;
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x151EDC4", Offset = "0x151EDC4", VA = "0x151EDC4", Slot = "5")]
		public override void RegisterPorts(FlowNode node)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x151EFF8", Offset = "0x151EFF8", VA = "0x151EFF8")]
		public PureReflectedExtractorNode()
		{
		}
	}
	[Token(Token = "0x20001B7")]
	public abstract class BaseReflectedFieldNode
	{
		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected FieldInfo fieldInfo;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ParamDef instanceDef;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected ParamDef resultDef;

		[Token(Token = "0x14000005")]
		protected static event Func<FieldInfo, BaseReflectedFieldNode> OnGetAotReflectedFieldNode
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x135AE3C", Offset = "0x135AE3C", VA = "0x135AE3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB594", Offset = "0x9EB594")]
			add
			{
			}
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x135AEF8", Offset = "0x135AEF8", VA = "0x135AEF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB5A4", Offset = "0x9EB5A4")]
			remove
			{
			}
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x135AFB4", Offset = "0x135AFB4", VA = "0x135AFB4")]
		public static BaseReflectedFieldNode GetFieldNode(FieldInfo targetField)
		{
			return null;
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x135B0F8", Offset = "0x135B0F8", VA = "0x135B0F8")]
		protected bool Init(FieldInfo field, ParametresDef parametres)
		{
			return default(bool);
		}

		[Token(Token = "0x600068E")]
		protected abstract bool InitInternal(FieldInfo field);

		[Token(Token = "0x600068F")]
		public abstract void RegisterPorts(FlowNode node, ReflectedFieldNodeWrapper.AccessMode accessMode);

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x135B250", Offset = "0x135B250", VA = "0x135B250")]
		protected BaseReflectedFieldNode()
		{
		}
	}
	[Token(Token = "0x20001B8")]
	public class PureReflectedFieldNode : BaseReflectedFieldNode
	{
		[Token(Token = "0x20001B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6F94", Offset = "0x9E6F94")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FlowOutput output;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PureReflectedFieldNode <>4__this;

			[Token(Token = "0x6000698")]
			[Address(RVA = "0x26A481C", Offset = "0x26A481C", VA = "0x26A481C")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0x26A4824", Offset = "0x26A4824", VA = "0x26A4824")]
			internal void <RegisterPorts>b__2(Flow flow)
			{
			}
		}

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ValueInput instanceInput;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ValueInput valueInput;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private object instanceObject;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private object valueObject;

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x151F074", Offset = "0x151F074", VA = "0x151F074", Slot = "4")]
		protected override bool InitInternal(FieldInfo method)
		{
			return default(bool);
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x151F0C0", Offset = "0x151F0C0", VA = "0x151F0C0")]
		private void SetValue()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x151F148", Offset = "0x151F148", VA = "0x151F148")]
		private void GetValue()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x151F1BC", Offset = "0x151F1BC", VA = "0x151F1BC", Slot = "5")]
		public override void RegisterPorts(FlowNode node, ReflectedFieldNodeWrapper.AccessMode accessMode)
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x151F538", Offset = "0x151F538", VA = "0x151F538")]
		public PureReflectedFieldNode()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x151F540", Offset = "0x151F540", VA = "0x151F540")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB5B4", Offset = "0x9EB5B4")]
		private object <RegisterPorts>b__7_0()
		{
			return null;
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x151F548", Offset = "0x151F548", VA = "0x151F548")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB5C4", Offset = "0x9EB5C4")]
		private object <RegisterPorts>b__7_1()
		{
			return null;
		}
	}
	[Token(Token = "0x20001BA")]
	public abstract class BaseReflectedMethodNode
	{
		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected MethodInfo methodInfo;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected List<ParamDef> paramDefinitions;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ParamDef instanceDef;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected ParamDef resultDef;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected ReflectedMethodRegistrationOptions options;

		[Token(Token = "0x14000006")]
		protected static event Func<MethodInfo, BaseReflectedMethodNode> OnGetAotReflectedMethodNode
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x135B258", Offset = "0x135B258", VA = "0x135B258")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB5D4", Offset = "0x9EB5D4")]
			add
			{
			}
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x135B314", Offset = "0x135B314", VA = "0x135B314")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB5E4", Offset = "0x9EB5E4")]
			remove
			{
			}
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x135B3D0", Offset = "0x135B3D0", VA = "0x135B3D0")]
		public static BaseReflectedMethodNode GetMethodNode(MethodInfo targetMethod, ReflectedMethodRegistrationOptions options)
		{
			return null;
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x135B510", Offset = "0x135B510", VA = "0x135B510")]
		protected bool Init(MethodInfo method, ParametresDef parametres)
		{
			return default(bool);
		}

		[Token(Token = "0x600069E")]
		protected abstract bool InitInternal(MethodInfo method);

		[Token(Token = "0x600069F")]
		public abstract void RegisterPorts(FlowNode node, ReflectedMethodRegistrationOptions options);

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x135B6A8", Offset = "0x135B6A8", VA = "0x135B6A8")]
		protected BaseReflectedMethodNode()
		{
		}
	}
	[Token(Token = "0x20001BB")]
	public class PureReflectedMethodNode : BaseReflectedMethodNode
	{
		[Token(Token = "0x20001BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6FA4", Offset = "0x9E6FA4")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool callable;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PureReflectedMethodNode <>4__this;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int idx;

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x26A49D8", Offset = "0x26A49D8", VA = "0x26A49D8")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x26A49E0", Offset = "0x26A49E0", VA = "0x26A49E0")]
			internal object <RegisterOutput>b__0()
			{
				return null;
			}
		}

		[Token(Token = "0x20001BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6FB4", Offset = "0x9E6FB4")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PureReflectedMethodNode <>4__this;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ReflectedMethodRegistrationOptions options;

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x26A4A4C", Offset = "0x26A4A4C", VA = "0x26A4A4C")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x26A4A54", Offset = "0x26A4A54", VA = "0x26A4A54")]
			internal object <RegisterPorts>b__0()
			{
				return null;
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x26A4A70", Offset = "0x26A4A70", VA = "0x26A4A70")]
			internal object <RegisterPorts>b__1()
			{
				return null;
			}
		}

		[Token(Token = "0x20001BE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E6FC4", Offset = "0x9E6FC4")]
		private sealed class <>c__DisplayClass12_1
		{
			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FlowOutput output;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass12_0 CS$<>8__locals1;

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x26A4AB4", Offset = "0x26A4AB4", VA = "0x26A4AB4")]
			public <>c__DisplayClass12_1()
			{
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x26A4ABC", Offset = "0x26A4ABC", VA = "0x26A4ABC")]
			internal void <RegisterPorts>b__2(Flow flow)
			{
			}
		}

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ValueInput instanceInput;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private object instanceObject;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private object resultObject;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private object[] callParams;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ValueInput[] inputs;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ValueInput[] arrayInputs;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int arrayParamsInput;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Type arrayParamsType;

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x151FA8C", Offset = "0x151FA8C", VA = "0x151FA8C", Slot = "4")]
		protected override bool InitInternal(MethodInfo method)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x151FC20", Offset = "0x151FC20", VA = "0x151FC20")]
		private void Call()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x151FE08", Offset = "0x151FE08", VA = "0x151FE08")]
		private void RegisterOutput(FlowNode node, bool callable, ParamDef def, int idx)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x151FF0C", Offset = "0x151FF0C", VA = "0x151FF0C")]
		private void RegisterInput(FlowNode node, ParamDef def, int idx)
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x15200EC", Offset = "0x15200EC", VA = "0x15200EC", Slot = "5")]
		public override void RegisterPorts(FlowNode node, ReflectedMethodRegistrationOptions options)
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x1520520", Offset = "0x1520520", VA = "0x1520520")]
		public PureReflectedMethodNode()
		{
		}
	}
	[Token(Token = "0x20001BF")]
	public class ReflectedConstructorNodeWrapper : ReflectedMethodBaseNodeWrapper
	{
		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private SerializedConstructorInfo _constructor;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E9C74", Offset = "0x9E9C74")]
		private BaseReflectedConstructorNode <reflectedConstructorNode>k__BackingField;

		[Token(Token = "0x1700008F")]
		protected override SerializedMethodBaseInfo serializedMethodBase
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x1BB26E8", Offset = "0x1BB26E8", VA = "0x1BB26E8", Slot = "41")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		private BaseReflectedConstructorNode reflectedConstructorNode
		{
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x1BB26F0", Offset = "0x1BB26F0", VA = "0x1BB26F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB5F4", Offset = "0x9EB5F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x1BB26F8", Offset = "0x1BB26F8", VA = "0x1BB26F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB604", Offset = "0x9EB604")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		private ConstructorInfo constructor
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x1BB2700", Offset = "0x1BB2700", VA = "0x1BB2700")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000092")]
		public override string name
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x1BB2718", Offset = "0x1BB2718", VA = "0x1BB2718", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x1BB2870", Offset = "0x1BB2870", VA = "0x1BB2870", Slot = "42")]
		public override void SetMethodBase(MethodBase newMethod, [Optional] object instance)
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1BB2908", Offset = "0x1BB2908", VA = "0x1BB2908")]
		private void SetConstructor(ConstructorInfo newConstructor)
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1BB2B44", Offset = "0x1BB2B44", VA = "0x1BB2B44", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x1BB2C40", Offset = "0x1BB2C40", VA = "0x1BB2C40")]
		public ReflectedConstructorNodeWrapper()
		{
		}
	}
	[Token(Token = "0x20001C0")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E6FD4", Offset = "0x9E6FD4")]
	[AttributeAttribute(Name = "IconAttribute", RVA = "0x9E6FD4", Offset = "0x9E6FD4")]
	[DoNotList]
	public class ReflectedExtractorNodeWrapper<T> : FlowNode, IReflectedWrapper
	{
		[Serializable]
		[Token(Token = "0x20001C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E7064", Offset = "0x9E7064")]
		private sealed class <>c
		{
			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<string, bool> <>9__11_0;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<string, int> <>9__11_1;

			[Token(Token = "0x60006BF")]
			public <>c()
			{
			}

			[Token(Token = "0x60006C0")]
			internal bool <ReValidateList>b__11_0(string x)
			{
				return default(bool);
			}

			[Token(Token = "0x60006C1")]
			internal int <ReValidateList>b__11_1(string x)
			{
				return default(int);
			}
		}

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, MemberInfo> _memberInfos;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<string> _instanceMemberNames;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<string> _staticMemberNames;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<string> _selectedInstanceMembers;

		[NonSerialized]
		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private BaseReflectedExtractorNode extractorNode;

		[Token(Token = "0x17000093")]
		public override string name
		{
			[Token(Token = "0x60006BA")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006B7")]
		private MemberInfo NodeCanvas.Framework.IReflectedWrapper.GetMemberInfo()
		{
			return null;
		}

		[Token(Token = "0x60006B8")]
		public Type GetRuntimeIconType()
		{
			return null;
		}

		[Token(Token = "0x60006B9")]
		private static void PopulateInfos()
		{
		}

		[Token(Token = "0x60006BB")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60006BC")]
		private void ReValidateList()
		{
		}

		[Token(Token = "0x60006BD")]
		public ReflectedExtractorNodeWrapper()
		{
		}
	}
	[Token(Token = "0x20001C2")]
	[DoNotList]
	[AttributeAttribute(Name = "IconAttribute", RVA = "0x9E7074", Offset = "0x9E7074")]
	public class ReflectedFieldNodeWrapper : FlowNode, IReflectedWrapper
	{
		[Token(Token = "0x20001C3")]
		public enum AccessMode
		{
			[Token(Token = "0x40003D3")]
			GetField,
			[Token(Token = "0x40003D4")]
			SetField
		}

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string fieldName;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Type targetType;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AccessMode accessMode;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E9CC4", Offset = "0x9E9CC4")]
		private BaseReflectedFieldNode <reflectedFieldNode>k__BackingField;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private FieldInfo _field;

		[Token(Token = "0x17000094")]
		private BaseReflectedFieldNode reflectedFieldNode
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x1BB374C", Offset = "0x1BB374C", VA = "0x1BB374C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB614", Offset = "0x9EB614")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x1BB3754", Offset = "0x1BB3754", VA = "0x1BB3754")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB624", Offset = "0x9EB624")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		private FieldInfo field
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x1BB3624", Offset = "0x1BB3624", VA = "0x1BB3624")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		public override string name
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x1BB375C", Offset = "0x1BB375C", VA = "0x1BB375C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x1BB3620", Offset = "0x1BB3620", VA = "0x1BB3620", Slot = "40")]
		private MemberInfo NodeCanvas.Framework.IReflectedWrapper.GetMemberInfo()
		{
			return null;
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x1BB36F4", Offset = "0x1BB36F4", VA = "0x1BB36F4")]
		private Type GetRuntimeIconType()
		{
			return null;
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x1BB3B00", Offset = "0x1BB3B00", VA = "0x1BB3B00")]
		public void SetField(FieldInfo newField, AccessMode mode, [Optional] object instance)
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x1BB3D18", Offset = "0x1BB3D18", VA = "0x1BB3D18", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x1BB3D8C", Offset = "0x1BB3D8C", VA = "0x1BB3D8C")]
		public ReflectedFieldNodeWrapper()
		{
		}
	}
	[Token(Token = "0x20001C4")]
	[DoNotList]
	[AttributeAttribute(Name = "IconAttribute", RVA = "0x9E70D8", Offset = "0x9E70D8")]
	public abstract class ReflectedMethodBaseNodeWrapper : FlowNode, IReflectedWrapper
	{
		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		protected bool _callable;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		[SerializeField]
		protected bool _exposeParams;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		protected int _exposedParamsCount;

		[Token(Token = "0x17000097")]
		protected abstract SerializedMethodBaseInfo serializedMethodBase
		{
			[Token(Token = "0x60006CD")]
			get;
		}

		[Token(Token = "0x17000098")]
		private MethodBase method
		{
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x1BB43E0", Offset = "0x1BB43E0", VA = "0x1BB43E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		public bool callable
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x1BB4498", Offset = "0x1BB4498", VA = "0x1BB4498")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x1BB44A0", Offset = "0x1BB44A0", VA = "0x1BB44A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public bool exposeParams
		{
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x1BB44C8", Offset = "0x1BB44C8", VA = "0x1BB44C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x1BB44D0", Offset = "0x1BB44D0", VA = "0x1BB44D0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public int exposedParamsCount
		{
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x1BB4528", Offset = "0x1BB4528", VA = "0x1BB4528")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x1BB4530", Offset = "0x1BB4530", VA = "0x1BB4530")]
			set
			{
			}
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x1BB43DC", Offset = "0x1BB43DC", VA = "0x1BB43DC", Slot = "40")]
		private MemberInfo NodeCanvas.Framework.IReflectedWrapper.GetMemberInfo()
		{
			return null;
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x1BB4440", Offset = "0x1BB4440", VA = "0x1BB4440")]
		public Type GetRuntimeIconType()
		{
			return null;
		}

		[Token(Token = "0x60006D5")]
		public abstract void SetMethodBase(MethodBase newMethod, [Optional] object instance);

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x1BB29DC", Offset = "0x1BB29DC", VA = "0x1BB29DC")]
		public void SetDefaultParameterValues(MethodBase newMethod)
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x1BB4558", Offset = "0x1BB4558", VA = "0x1BB4558")]
		public void SetDropInstanceReference(MethodBase newMethod, [Optional] object instance)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x1BB2C48", Offset = "0x1BB2C48", VA = "0x1BB2C48")]
		protected ReflectedMethodBaseNodeWrapper()
		{
		}
	}
	[Token(Token = "0x20001C5")]
	public class ReflectedMethodNodeWrapper : ReflectedMethodBaseNodeWrapper
	{
		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private SerializedMethodInfo _method;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E9D14", Offset = "0x9E9D14")]
		private BaseReflectedMethodNode <reflectedMethodNode>k__BackingField;

		[Token(Token = "0x1700009C")]
		protected override SerializedMethodBaseInfo serializedMethodBase
		{
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x1BB5238", Offset = "0x1BB5238", VA = "0x1BB5238", Slot = "41")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		private BaseReflectedMethodNode reflectedMethodNode
		{
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x1BB5240", Offset = "0x1BB5240", VA = "0x1BB5240")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB634", Offset = "0x9EB634")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x1BB5248", Offset = "0x1BB5248", VA = "0x1BB5248")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB644", Offset = "0x9EB644")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		private MethodInfo method
		{
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x1BB5250", Offset = "0x1BB5250", VA = "0x1BB5250")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public override string name
		{
			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x1BB5268", Offset = "0x1BB5268", VA = "0x1BB5268", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x1BB5B54", Offset = "0x1BB5B54", VA = "0x1BB5B54", Slot = "42")]
		public override void SetMethodBase(MethodBase newMethod, [Optional] object instance)
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x1BB5BF4", Offset = "0x1BB5BF4", VA = "0x1BB5BF4")]
		private void SetMethod(MethodInfo newMethod, [Optional] object instance)
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1BB5FAC", Offset = "0x1BB5FAC", VA = "0x1BB5FAC", Slot = "36")]
		public override void OnPortConnected(Port port, Port otherPort)
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x1BB613C", Offset = "0x1BB613C", VA = "0x1BB613C", Slot = "39")]
		public override Type GetNodeWildDefinitionType()
		{
			return null;
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x1BB61B0", Offset = "0x1BB61B0", VA = "0x1BB61B0", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x1BB6268", Offset = "0x1BB6268", VA = "0x1BB6268")]
		public ReflectedMethodNodeWrapper()
		{
		}
	}
	[Token(Token = "0x20001C6")]
	public struct ReflectedMethodRegistrationOptions
	{
		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool callable;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public bool exposeParams;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int exposedParamsCount;
	}
	[Token(Token = "0x20001C7")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E713C", Offset = "0x9E713C")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E713C", Offset = "0x9E713C")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E713C", Offset = "0x9E713C")]
	public class CreateCollection<T> : VariableNode
	{
		[Token(Token = "0x20001C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E7250", Offset = "0x9E7250")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<ValueInput<T>> ins;

			[Token(Token = "0x60006E7")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60006E8")]
			internal T[] <RegisterPorts>b__0()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x20001C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E7260", Offset = "0x9E7260")]
		private sealed class <>c
		{
			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<ValueInput<T>, T> <>9__2_1;

			[Token(Token = "0x60006EA")]
			public <>c()
			{
			}

			[Token(Token = "0x60006EB")]
			internal T <RegisterPorts>b__2_1(ValueInput<T> p)
			{
				return (T)null;
			}
		}

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[ExposeField]
		[GatherPortsCallback]
		[AttributeAttribute(Name = "MinValueAttribute", RVA = "0x9E9D24", Offset = "0x9E9D24")]
		[DelayedField]
		private int _portCount;

		[Token(Token = "0x60006E4")]
		public override void SetVariable(object o)
		{
		}

		[Token(Token = "0x60006E5")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60006E6")]
		public CreateCollection()
		{
		}
	}
	[Token(Token = "0x20001CA")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E7270", Offset = "0x9E7270")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E7270", Offset = "0x9E7270")]
	public class CreateDictionary<T> : VariableNode
	{
		[Token(Token = "0x20001CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E7354", Offset = "0x9E7354")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<ValueInput<string>> keys;

			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<ValueInput<T>> values;

			[Token(Token = "0x60006EF")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60006F0")]
			internal IDictionary<string, T> <RegisterPorts>b__0()
			{
				return null;
			}
		}

		[Token(Token = "0x20001CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E7364", Offset = "0x9E7364")]
		private sealed class <>c__DisplayClass2_1
		{
			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<T> v;

			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<string> k;

			[Token(Token = "0x60006F1")]
			public <>c__DisplayClass2_1()
			{
			}

			[Token(Token = "0x60006F2")]
			internal T <RegisterPorts>b__4(string x)
			{
				return (T)null;
			}
		}

		[Serializable]
		[Token(Token = "0x20001CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E7374", Offset = "0x9E7374")]
		private sealed class <>c
		{
			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<ValueInput<string>, string> <>9__2_1;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<ValueInput<T>, T> <>9__2_2;

			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<string, string> <>9__2_3;

			[Token(Token = "0x60006F4")]
			public <>c()
			{
			}

			[Token(Token = "0x60006F5")]
			internal string <RegisterPorts>b__2_1(ValueInput<string> x)
			{
				return null;
			}

			[Token(Token = "0x60006F6")]
			internal T <RegisterPorts>b__2_2(ValueInput<T> x)
			{
				return (T)null;
			}

			[Token(Token = "0x60006F7")]
			internal string <RegisterPorts>b__2_3(string x)
			{
				return null;
			}
		}

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[DelayedField]
		[AttributeAttribute(Name = "MinValueAttribute", RVA = "0x9E9D90", Offset = "0x9E9D90")]
		[GatherPortsCallback]
		[SerializeField]
		[ExposeField]
		private int _portCount;

		[Token(Token = "0x60006EC")]
		public override void SetVariable(object o)
		{
		}

		[Token(Token = "0x60006ED")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60006EE")]
		public CreateDictionary()
		{
		}
	}
	[Token(Token = "0x20001CE")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E7384", Offset = "0x9E7384")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E7384", Offset = "0x9E7384")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E7384", Offset = "0x9E7384")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E7384", Offset = "0x9E7384")]
	public class GetOtherVariable<T> : VariableNode
	{
		[Token(Token = "0x20001CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E7488", Offset = "0x9E7488")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<Blackboard> bb;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<string> varName;

			[Token(Token = "0x60006FC")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60006FD")]
			internal T <RegisterPorts>b__0()
			{
				return (T)null;
			}
		}

		[Token(Token = "0x170000A0")]
		public override string name
		{
			[Token(Token = "0x60006F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006F9")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60006FA")]
		public override void SetVariable(object o)
		{
		}

		[Token(Token = "0x60006FB")]
		public GetOtherVariable()
		{
		}
	}
	[Token(Token = "0x20001D0")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E7498", Offset = "0x9E7498")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E7498", Offset = "0x9E7498")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E7498", Offset = "0x9E7498")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E7498", Offset = "0x9E7498")]
	public class GetVariable<T> : VariableNode
	{
		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T> value;

		[Token(Token = "0x60006FE")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60006FF")]
		public void SetTargetVariableName(string name)
		{
		}

		[Token(Token = "0x6000700")]
		public override void SetVariable(object o)
		{
		}

		[Token(Token = "0x6000701")]
		public GetVariable()
		{
		}

		[Token(Token = "0x6000702")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB654", Offset = "0x9EB654")]
		private T <RegisterPorts>b__1_0()
		{
			return (T)null;
		}
	}
	[Token(Token = "0x20001D1")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E759C", Offset = "0x9E759C")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E759C", Offset = "0x9E759C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E759C", Offset = "0x9E759C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E759C", Offset = "0x9E759C")]
	[AttributeAttribute(Name = "ColorAttribute", RVA = "0x9E759C", Offset = "0x9E759C")]
	public class GoToLabel : FlowControlNode, IEditorMenuCallbackReceiver
	{
		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9E9DFC", Offset = "0x9E9DFC")]
		[DelayedField]
		public string identifier;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E9E48", Offset = "0x9E9E48")]
		private FlowOutput <port>k__BackingField;

		[Token(Token = "0x170000A1")]
		[HideInInspector]
		public FlowOutput port
		{
			[Token(Token = "0x6000703")]
			[Address(RVA = "0x15060B8", Offset = "0x15060B8", VA = "0x15060B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB664", Offset = "0x9EB664")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000704")]
			[Address(RVA = "0x15060C0", Offset = "0x15060C0", VA = "0x15060C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB674", Offset = "0x9EB674")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public override string name
		{
			[Token(Token = "0x6000705")]
			[Address(RVA = "0x15060C8", Offset = "0x15060C8", VA = "0x15060C8", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x1506130", Offset = "0x1506130", VA = "0x1506130", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x15061A8", Offset = "0x15061A8", VA = "0x15061A8")]
		public GoToLabel()
		{
		}
	}
	[Token(Token = "0x20001D2")]
	[DoNotList]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E76C4", Offset = "0x9E76C4")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E76C4", Offset = "0x9E76C4")]
	public class GoToStatement : FlowControlNode
	{
		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private string _targetLabelUID;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private object _targetLabel;

		[Token(Token = "0x170000A3")]
		private string targetLabelUID
		{
			[Token(Token = "0x6000708")]
			[Address(RVA = "0x1506204", Offset = "0x1506204", VA = "0x1506204")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x150620C", Offset = "0x150620C", VA = "0x150620C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		private GoToLabel targetLabel
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x1506214", Offset = "0x1506214", VA = "0x1506214")]
			get
			{
				return null;
			}
			[Token(Token = "0x600070B")]
			[Address(RVA = "0x15063A4", Offset = "0x15063A4", VA = "0x15063A4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public override string name
		{
			[Token(Token = "0x600070C")]
			[Address(RVA = "0x15063AC", Offset = "0x15063AC", VA = "0x15063AC", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x1506444", Offset = "0x1506444", VA = "0x1506444")]
		public void SetTarget(GoToLabel target)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x1506550", Offset = "0x1506550", VA = "0x1506550", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x1506600", Offset = "0x1506600", VA = "0x1506600")]
		public GoToStatement()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1506608", Offset = "0x1506608", VA = "0x1506608")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB684", Offset = "0x9EB684")]
		private bool <get_targetLabel>b__6_0(GoToLabel i)
		{
			return default(bool);
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x150663C", Offset = "0x150663C", VA = "0x150663C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB694", Offset = "0x9EB694")]
		private void <RegisterPorts>b__11_0(Flow f)
		{
		}
	}
	[Token(Token = "0x20001D3")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E778C", Offset = "0x9E778C")]
	[AttributeAttribute(Name = "ColorAttribute", RVA = "0x9E778C", Offset = "0x9E778C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E778C", Offset = "0x9E778C")]
	[ExposeAsDefinition]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E778C", Offset = "0x9E778C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E778C", Offset = "0x9E778C")]
	public abstract class RelayValueInputBase : FlowNode
	{
		[Token(Token = "0x170000A6")]
		public abstract Type relayType
		{
			[Token(Token = "0x6000712")]
			get;
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x1BBE0F8", Offset = "0x1BBE0F8", VA = "0x1BBE0F8")]
		protected RelayValueInputBase()
		{
		}
	}
	[Token(Token = "0x20001D4")]
	public class RelayValueInput<T> : RelayValueInputBase, IEditorMenuCallbackReceiver
	{
		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9E9E68", Offset = "0x9E9E68")]
		[DelayedField]
		public string identifier;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E9EB4", Offset = "0x9E9EB4")]
		private ValueInput<T> <port>k__BackingField;

		[Token(Token = "0x170000A7")]
		[HideInInspector]
		public ValueInput<T> port
		{
			[Token(Token = "0x6000714")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB6A4", Offset = "0x9EB6A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000715")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB6B4", Offset = "0x9EB6B4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public override Type relayType
		{
			[Token(Token = "0x6000716")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A9")]
		public override string name
		{
			[Token(Token = "0x6000717")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000718")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000719")]
		public RelayValueInput()
		{
		}
	}
	[Token(Token = "0x20001D5")]
	[AttributeAttribute(Name = "ColorAttribute", RVA = "0x9E78C4", Offset = "0x9E78C4")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E78C4", Offset = "0x9E78C4")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E78C4", Offset = "0x9E78C4")]
	[DoNotList]
	public abstract class RelayValueOutputBase : FlowNode
	{
		[Token(Token = "0x600071A")]
		public abstract void SetSource(RelayValueInputBase source);

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x1BBE100", Offset = "0x1BBE100", VA = "0x1BBE100")]
		protected RelayValueOutputBase()
		{
		}
	}
	[Token(Token = "0x20001D6")]
	public class RelayValueOutput<T> : RelayValueOutputBase
	{
		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private string _sourceInputUID;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object _sourceInput;

		[Token(Token = "0x170000AA")]
		private string sourceInputUID
		{
			[Token(Token = "0x600071C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600071D")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		private RelayValueInput<T> sourceInput
		{
			[Token(Token = "0x600071E")]
			get
			{
				return null;
			}
			[Token(Token = "0x600071F")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public override string name
		{
			[Token(Token = "0x6000720")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000721")]
		public override void SetSource(RelayValueInputBase source)
		{
		}

		[Token(Token = "0x6000722")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000723")]
		public RelayValueOutput()
		{
		}

		[Token(Token = "0x6000724")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB6C4", Offset = "0x9EB6C4")]
		private bool <get_sourceInput>b__6_0(RelayValueInput<T> i)
		{
			return default(bool);
		}

		[Token(Token = "0x6000725")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB6D4", Offset = "0x9EB6D4")]
		private T <RegisterPorts>b__11_0()
		{
			return (T)null;
		}
	}
	[Token(Token = "0x20001D7")]
	[AttributeAttribute(Name = "ContextDefinedOutputsAttribute", RVA = "0x9E79B0", Offset = "0x9E79B0")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E79B0", Offset = "0x9E79B0")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E79B0", Offset = "0x9E79B0")]
	public class OwnerVariable : VariableNode
	{
		[Token(Token = "0x170000AD")]
		public override string name
		{
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x151CCFC", Offset = "0x151CCFC", VA = "0x151CCFC", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x151CD40", Offset = "0x151CD40", VA = "0x151CD40", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x151CE18", Offset = "0x151CE18", VA = "0x151CE18", Slot = "40")]
		public override void SetVariable(object o)
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x151CE1C", Offset = "0x151CE1C", VA = "0x151CE1C")]
		public OwnerVariable()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x151CE24", Offset = "0x151CE24", VA = "0x151CE24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB6E4", Offset = "0x9EB6E4")]
		private GameObject <RegisterPorts>b__2_0()
		{
			return null;
		}
	}
	[Token(Token = "0x20001D8")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E7A90", Offset = "0x9E7A90")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E7A90", Offset = "0x9E7A90")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E7A90", Offset = "0x9E7A90")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E7A90", Offset = "0x9E7A90")]
	public class SetOtherVariable<T> : FlowNode
	{
		[Token(Token = "0x20001D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E7BC0", Offset = "0x9E7BC0")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<Blackboard> bb;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SetOtherVariable<T> <>4__this;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T> v;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x600072F")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000730")]
			internal T <RegisterPorts>b__0()
			{
				return (T)null;
			}

			[Token(Token = "0x6000731")]
			internal void <RegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public OperationMethod operation;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ValueInput<string> varName;

		[Token(Token = "0x170000AE")]
		public override string name
		{
			[Token(Token = "0x600072B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600072C")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600072D")]
		private void DoSet(Blackboard bb, string name, T value)
		{
		}

		[Token(Token = "0x600072E")]
		public SetOtherVariable()
		{
		}
	}
	[Token(Token = "0x20001DA")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E7BD0", Offset = "0x9E7BD0")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E7BD0", Offset = "0x9E7BD0")]
	[AttributeAttribute(Name = "ContextDefinedInputsAttribute", RVA = "0x9E7BD0", Offset = "0x9E7BD0")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E7BD0", Offset = "0x9E7BD0")]
	public class SetVariable<T> : FlowNode
	{
		[Token(Token = "0x20001DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E7CD4", Offset = "0x9E7CD4")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SetVariable<T> <>4__this;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T> v;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x6000737")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000738")]
			internal T <RegisterPorts>b__0()
			{
				return (T)null;
			}

			[Token(Token = "0x6000739")]
			internal void <RegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[BlackboardOnly]
		public BBParameter<T> targetVariable;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public OperationMethod operation;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public bool perSecond;

		[Token(Token = "0x170000AF")]
		public override string name
		{
			[Token(Token = "0x6000732")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000733")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000734")]
		private void DoSet(T value)
		{
		}

		[Token(Token = "0x6000735")]
		public void SetTargetVariableName(string name)
		{
		}

		[Token(Token = "0x6000736")]
		public SetVariable()
		{
		}
	}
	[Token(Token = "0x20001DC")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E7CE4", Offset = "0x9E7CE4")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E7CE4", Offset = "0x9E7CE4")]
	[DoNotList]
	public class TagVariable : VariableNode
	{
		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[TagField]
		public BBParameter<string> tagName;

		[Token(Token = "0x170000B0")]
		public override string name
		{
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x1BC4158", Offset = "0x1BC4158", VA = "0x1BC4158", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x1BC41AC", Offset = "0x1BC41AC", VA = "0x1BC41AC", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x1BC4284", Offset = "0x1BC4284", VA = "0x1BC4284", Slot = "40")]
		public override void SetVariable(object o)
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x1BC4320", Offset = "0x1BC4320", VA = "0x1BC4320")]
		public TagVariable()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x1BC439C", Offset = "0x1BC439C", VA = "0x1BC439C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB6F4", Offset = "0x9EB6F4")]
		private string <RegisterPorts>b__3_0()
		{
			return null;
		}
	}
	[Token(Token = "0x20001DD")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E7D58", Offset = "0x9E7D58")]
	public abstract class VariableNode : FlowNode
	{
		[Token(Token = "0x600073F")]
		public abstract void SetVariable(object o);

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x1456528", Offset = "0x1456528", VA = "0x1456528")]
		protected VariableNode()
		{
		}
	}
	[Token(Token = "0x20001DE")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E7D90", Offset = "0x9E7D90")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E7D90", Offset = "0x9E7D90")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E7D90", Offset = "0x9E7D90")]
	public abstract class CodeEventBase : EventNode<Transform>
	{
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected string eventName;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		protected Type targetType;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected Component targetComponent;

		[Token(Token = "0x170000B1")]
		protected EventInfo eventInfo
		{
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x1362028", Offset = "0x1362028", VA = "0x1362028")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x13622CC", Offset = "0x13622CC", VA = "0x13622CC")]
		public void SetEvent(EventInfo e, [Optional] object instace)
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x1361E44", Offset = "0x1361E44", VA = "0x1361E44", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x1362280", Offset = "0x1362280", VA = "0x1362280")]
		protected CodeEventBase()
		{
		}
	}
	[Token(Token = "0x20001DF")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E7E00", Offset = "0x9E7E00")]
	public class CodeEvent : CodeEventBase
	{
		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private FlowOutput o;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Action pointer;

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x1361D94", Offset = "0x1361D94", VA = "0x1361D94", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x13620E8", Offset = "0x13620E8", VA = "0x13620E8", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x13621B0", Offset = "0x13621B0", VA = "0x13621B0", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x136222C", Offset = "0x136222C", VA = "0x136222C")]
		private void Call()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x136227C", Offset = "0x136227C", VA = "0x136227C")]
		public CodeEvent()
		{
		}
	}
	[Token(Token = "0x20001E0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E7E10", Offset = "0x9E7E10")]
	public class CodeEvent<T> : CodeEventBase
	{
		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FlowOutput o;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<T> pointer;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T eventValue;

		[Token(Token = "0x600074A")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x600074B")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x600074C")]
		private void Call(T eventValue)
		{
		}

		[Token(Token = "0x600074D")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600074E")]
		public CodeEvent()
		{
		}

		[Token(Token = "0x600074F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB704", Offset = "0x9EB704")]
		private T <RegisterPorts>b__6_0()
		{
			return (T)null;
		}
	}
	[Token(Token = "0x20001E1")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E7E20", Offset = "0x9E7E20")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E7E20", Offset = "0x9E7E20")]
	public class NewGameObject : CallableFunctionNode<GameObject, string, Vector3, Quaternion>
	{
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x151A33C", Offset = "0x151A33C", VA = "0x151A33C", Slot = "12")]
		public override GameObject Invoke(string name, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x151A42C", Offset = "0x151A42C", VA = "0x151A42C")]
		public NewGameObject()
		{
		}
	}
	[Token(Token = "0x20001E2")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E7E6C", Offset = "0x9E7E6C")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E7E6C", Offset = "0x9E7E6C")]
	public class NewVector2 : PureFunctionNode<Vector2, float, float>
	{
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x151A5D0", Offset = "0x151A5D0", VA = "0x151A5D0", Slot = "12")]
		public override Vector2 Invoke(float x, float y)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x151A5D4", Offset = "0x151A5D4", VA = "0x151A5D4")]
		public NewVector2()
		{
		}
	}
	[Token(Token = "0x20001E3")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E7EB8", Offset = "0x9E7EB8")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E7EB8", Offset = "0x9E7EB8")]
	public class NewVector3 : PureFunctionNode<Vector3, float, float, float>
	{
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x151A620", Offset = "0x151A620", VA = "0x151A620", Slot = "12")]
		public override Vector3 Invoke(float x, float y, float z)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x151A624", Offset = "0x151A624", VA = "0x151A624")]
		public NewVector3()
		{
		}
	}
	[Token(Token = "0x20001E4")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E7F04", Offset = "0x9E7F04")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E7F04", Offset = "0x9E7F04")]
	public class NewVector4 : PureFunctionNode<Vector4, float, float, float, float>
	{
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x151A670", Offset = "0x151A670", VA = "0x151A670", Slot = "12")]
		public override Vector4 Invoke(float x, float y, float z, float w)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x151A6A0", Offset = "0x151A6A0", VA = "0x151A6A0")]
		public NewVector4()
		{
		}
	}
	[Token(Token = "0x20001E5")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E7F50", Offset = "0x9E7F50")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E7F50", Offset = "0x9E7F50")]
	public class NewQuaternion : PureFunctionNode<Quaternion, float, float, float, float>
	{
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x151A478", Offset = "0x151A478", VA = "0x151A478", Slot = "12")]
		public override Quaternion Invoke(float x, float y, float z, float w)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x151A4A8", Offset = "0x151A4A8", VA = "0x151A4A8")]
		public NewQuaternion()
		{
		}
	}
	[Token(Token = "0x20001E6")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E7F9C", Offset = "0x9E7F9C")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E7F9C", Offset = "0x9E7F9C")]
	public class NewColor : PureFunctionNode<Color, float, float, float, float>
	{
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x151A2C0", Offset = "0x151A2C0", VA = "0x151A2C0", Slot = "12")]
		public override Color Invoke(float r, float g, float b, float a = 1f)
		{
			return default(Color);
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x151A2F0", Offset = "0x151A2F0", VA = "0x151A2F0")]
		public NewColor()
		{
		}
	}
	[Token(Token = "0x20001E7")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E7FE8", Offset = "0x9E7FE8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E7FE8", Offset = "0x9E7FE8")]
	public class NewBounds : PureFunctionNode<Bounds, Vector3, Vector3>
	{
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x151A260", Offset = "0x151A260", VA = "0x151A260", Slot = "12")]
		public override Bounds Invoke(Vector3 center, Vector3 size)
		{
			return default(Bounds);
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x151A274", Offset = "0x151A274", VA = "0x151A274")]
		public NewBounds()
		{
		}
	}
	[Token(Token = "0x20001E8")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E8034", Offset = "0x9E8034")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E8034", Offset = "0x9E8034")]
	public class NewRect : PureFunctionNode<Rect, float, float, float, float>
	{
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x151A554", Offset = "0x151A554", VA = "0x151A554", Slot = "12")]
		public override Rect Invoke(float left, float top, float width, float height)
		{
			return default(Rect);
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x151A584", Offset = "0x151A584", VA = "0x151A584")]
		public NewRect()
		{
		}
	}
	[Token(Token = "0x20001E9")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E8080", Offset = "0x9E8080")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E8080", Offset = "0x9E8080")]
	public class NewRay : PureFunctionNode<Ray, Vector3, Vector3>
	{
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x151A4F4", Offset = "0x151A4F4", VA = "0x151A4F4", Slot = "12")]
		public override Ray Invoke(Vector3 origin, Vector3 direction)
		{
			return default(Ray);
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x151A508", Offset = "0x151A508", VA = "0x151A508")]
		public NewRay()
		{
		}
	}
	[Token(Token = "0x20001EA")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E80CC", Offset = "0x9E80CC")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E80CC", Offset = "0x9E80CC")]
	public class ConvertTo<T> : PureFunctionNode<T, IConvertible> where T : IConvertible
	{
		[Token(Token = "0x6000762")]
		public override T Invoke(IConvertible obj)
		{
			return (T)null;
		}

		[Token(Token = "0x6000763")]
		public ConvertTo()
		{
		}
	}
	[Token(Token = "0x20001EB")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E8118", Offset = "0x9E8118")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E8118", Offset = "0x9E8118")]
	public class CastTo<T> : PureFunctionNode<T, object>
	{
		[Token(Token = "0x6000764")]
		public override T Invoke(object obj)
		{
			return (T)null;
		}

		[Token(Token = "0x6000765")]
		public CastTo()
		{
		}
	}
	[Token(Token = "0x20001EC")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E8164", Offset = "0x9E8164")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E8164", Offset = "0x9E8164")]
	public class ToArray<T> : PureFunctionNode<T[], IList<T>>
	{
		[Token(Token = "0x6000766")]
		public override T[] Invoke(IList<T> list)
		{
			return null;
		}

		[Token(Token = "0x6000767")]
		public ToArray()
		{
		}
	}
	[Token(Token = "0x20001ED")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E81B0", Offset = "0x9E81B0")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E81B0", Offset = "0x9E81B0")]
	public class ToList<T> : PureFunctionNode<List<T>, IList<T>>
	{
		[Token(Token = "0x6000768")]
		public override List<T> Invoke(IList<T> list)
		{
			return null;
		}

		[Token(Token = "0x6000769")]
		public ToList()
		{
		}
	}
	[Token(Token = "0x20001EE")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E81FC", Offset = "0x9E81FC")]
	public class ExtractVector2 : ExtractorNode<Vector2, float, float>
	{
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x1369F8C", Offset = "0x1369F8C", VA = "0x1369F8C", Slot = "12")]
		public override void Invoke(Vector2 vector, out float x, out float y)
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x1369F98", Offset = "0x1369F98", VA = "0x1369F98")]
		public ExtractVector2()
		{
		}
	}
	[Token(Token = "0x20001EF")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E820C", Offset = "0x9E820C")]
	public class ExtractVector3 : ExtractorNode<Vector3, float, float, float>
	{
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x1369FE4", Offset = "0x1369FE4", VA = "0x1369FE4", Slot = "12")]
		public override void Invoke(Vector3 vector, out float x, out float y, out float z)
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x1369FF4", Offset = "0x1369FF4", VA = "0x1369FF4")]
		public ExtractVector3()
		{
		}
	}
	[Token(Token = "0x20001F0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E821C", Offset = "0x9E821C")]
	public class ExtractVector4 : ExtractorNode<Vector4, float, float, float, float>
	{
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x136A040", Offset = "0x136A040", VA = "0x136A040", Slot = "12")]
		public override void Invoke(Vector4 vector, out float x, out float y, out float z, out float w)
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x136A054", Offset = "0x136A054", VA = "0x136A054")]
		public ExtractVector4()
		{
		}
	}
	[Token(Token = "0x20001F1")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E822C", Offset = "0x9E822C")]
	public class ExtractQuaternion : ExtractorNode<Quaternion, float, float, float, float, Vector3>
	{
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x1369A9C", Offset = "0x1369A9C", VA = "0x1369A9C", Slot = "12")]
		public override void Invoke(Quaternion quaternion, out float x, out float y, out float z, out float w, out Vector3 eulerAngles)
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x1369AEC", Offset = "0x1369AEC", VA = "0x1369AEC")]
		public ExtractQuaternion()
		{
		}
	}
	[Token(Token = "0x20001F2")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E823C", Offset = "0x9E823C")]
	public class ExtractRect : ExtractorNode<Rect, Vector2, float, float, float, float>
	{
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x1369EA4", Offset = "0x1369EA4", VA = "0x1369EA4", Slot = "12")]
		public override void Invoke(Rect rect, out Vector2 center, out float xMin, out float xMax, out float yMin, out float yMax)
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x1369F40", Offset = "0x1369F40", VA = "0x1369F40")]
		public ExtractRect()
		{
		}
	}
	[Token(Token = "0x20001F3")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E824C", Offset = "0x9E824C")]
	public class ExtractColor : ExtractorNode<Color, float, float, float, float>
	{
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x13697B4", Offset = "0x13697B4", VA = "0x13697B4", Slot = "12")]
		public override void Invoke(Color color, out float r, out float g, out float b, out float a)
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x13697C8", Offset = "0x13697C8", VA = "0x13697C8")]
		public ExtractColor()
		{
		}
	}
	[Token(Token = "0x20001F4")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E825C", Offset = "0x9E825C")]
	public class ExtractRaycastHit : ExtractorNode<RaycastHit, GameObject, float, Vector3, Vector3>
	{
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x1369BD8", Offset = "0x1369BD8", VA = "0x1369BD8", Slot = "12")]
		public override void Invoke(RaycastHit hit, out GameObject gameObject, out float distance, out Vector3 normal, out Vector3 point)
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x1369CE4", Offset = "0x1369CE4", VA = "0x1369CE4")]
		public ExtractRaycastHit()
		{
		}
	}
	[Token(Token = "0x20001F5")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E826C", Offset = "0x9E826C")]
	public class ExtractRaycastHit2D : ExtractorNode<RaycastHit2D, GameObject, float, float, Vector3, Vector3>
	{
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1369D30", Offset = "0x1369D30", VA = "0x1369D30", Slot = "12")]
		public override void Invoke(RaycastHit2D hit, out GameObject gameObject, out float distance, out float fraction, out Vector3 normal, out Vector3 point)
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x1369E58", Offset = "0x1369E58", VA = "0x1369E58")]
		public ExtractRaycastHit2D()
		{
		}
	}
	[Token(Token = "0x20001F6")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E827C", Offset = "0x9E827C")]
	public class ExtractRay : ExtractorNode<Ray, Vector3, Vector3>
	{
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x1369B38", Offset = "0x1369B38", VA = "0x1369B38", Slot = "12")]
		public override void Invoke(Ray ray, out Vector3 origin, out Vector3 direction)
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x1369B8C", Offset = "0x1369B8C", VA = "0x1369B8C")]
		public ExtractRay()
		{
		}
	}
	[Token(Token = "0x20001F7")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E828C", Offset = "0x9E828C")]
	public class ExtractBounds : ExtractorNode<Bounds, Vector3, Vector3, Vector3, Vector3, Vector3>
	{
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x13694A0", Offset = "0x13694A0", VA = "0x13694A0", Slot = "12")]
		public override void Invoke(Bounds bounds, out Vector3 center, out Vector3 extents, out Vector3 max, out Vector3 min, out Vector3 size)
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x1369544", Offset = "0x1369544", VA = "0x1369544")]
		public ExtractBounds()
		{
		}
	}
	[Token(Token = "0x20001F8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E829C", Offset = "0x9E829C")]
	public class ExtractCollision : ExtractorNode<Collision, ContactPoint[], ContactPoint, GameObject, Vector3>
	{
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x1369590", Offset = "0x1369590", VA = "0x1369590", Slot = "12")]
		public override void Invoke(Collision collision, out ContactPoint[] contacts, out ContactPoint firstContact, out GameObject gameObject, out Vector3 velocity)
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x1369654", Offset = "0x1369654", VA = "0x1369654")]
		public ExtractCollision()
		{
		}
	}
	[Token(Token = "0x20001F9")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E82AC", Offset = "0x9E82AC")]
	public class ExtractCollision2D : ExtractorNode<Collision2D, ContactPoint2D[], ContactPoint2D, GameObject, Vector2>
	{
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x13696A0", Offset = "0x13696A0", VA = "0x13696A0", Slot = "12")]
		public override void Invoke(Collision2D collision, out ContactPoint2D[] contacts, out ContactPoint2D firstContact, out GameObject gameObject, out Vector2 velocity)
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1369768", Offset = "0x1369768", VA = "0x1369768")]
		public ExtractCollision2D()
		{
		}
	}
	[Token(Token = "0x20001FA")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E82BC", Offset = "0x9E82BC")]
	public class ExtractContactPoint : ExtractorNode<ContactPoint, Vector3, Vector3, Collider, Collider>
	{
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1369814", Offset = "0x1369814", VA = "0x1369814", Slot = "12")]
		public override void Invoke(ContactPoint contactPoint, out Vector3 normal, out Vector3 point, out Collider colliderA, out Collider colliderB)
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x13698AC", Offset = "0x13698AC", VA = "0x13698AC")]
		public ExtractContactPoint()
		{
		}
	}
	[Token(Token = "0x20001FB")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E82CC", Offset = "0x9E82CC")]
	public class ExtractContactPoint2D : ExtractorNode<ContactPoint2D, Vector2, Vector2, Collider2D, Collider2D>
	{
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x13698F8", Offset = "0x13698F8", VA = "0x13698F8", Slot = "12")]
		public override void Invoke(ContactPoint2D contactPoint, out Vector2 normal, out Vector2 point, out Collider2D colliderA, out Collider2D colliderB)
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1369988", Offset = "0x1369988", VA = "0x1369988")]
		public ExtractContactPoint2D()
		{
		}
	}
	[Token(Token = "0x20001FC")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E82DC", Offset = "0x9E82DC")]
	public class ExtractAnimationCurve : ExtractorNode<AnimationCurve, Keyframe[], float, WrapMode, WrapMode>
	{
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x13693C0", Offset = "0x13693C0", VA = "0x13693C0", Slot = "12")]
		public override void Invoke(AnimationCurve curve, out Keyframe[] keys, out float length, out WrapMode postWrapMode, out WrapMode preWrapMode)
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x1369454", Offset = "0x1369454", VA = "0x1369454")]
		public ExtractAnimationCurve()
		{
		}
	}
	[Token(Token = "0x20001FD")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E82EC", Offset = "0x9E82EC")]
	public class ExtractKeyFrame : ExtractorNode<Keyframe, float, float, float, float>
	{
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x13699D4", Offset = "0x13699D4", VA = "0x13699D4", Slot = "12")]
		public override void Invoke(Keyframe key, out float inTangent, out float outTangent, out float time, out float value)
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1369A50", Offset = "0x1369A50", VA = "0x1369A50")]
		public ExtractKeyFrame()
		{
		}
	}
	[Token(Token = "0x20001FE")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E82FC", Offset = "0x9E82FC")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E82FC", Offset = "0x9E82FC")]
	[ExposeAsDefinition]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E82FC", Offset = "0x9E82FC")]
	[AttributeAttribute(Name = "NameAttribute", RVA = "0x9E82FC", Offset = "0x9E82FC")]
	public class SwitchValue<T> : PureFunctionNode<T, bool, T, T>
	{
		[Token(Token = "0x600078A")]
		public override T Invoke(bool condition, T isTrue, T isFalse)
		{
			return (T)null;
		}

		[Token(Token = "0x600078B")]
		public SwitchValue()
		{
		}
	}
	[Token(Token = "0x20001FF")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E83A4", Offset = "0x9E83A4")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E83A4", Offset = "0x9E83A4")]
	[ExposeAsDefinition]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E83A4", Offset = "0x9E83A4")]
	public class PickValue<T> : PureFunctionNode<T, int, IList<T>>
	{
		[Token(Token = "0x600078C")]
		public override T Invoke(int index, IList<T> values)
		{
			return (T)null;
		}

		[Token(Token = "0x600078D")]
		public PickValue()
		{
		}
	}
	[Token(Token = "0x2000200")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E8424", Offset = "0x9E8424")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E8424", Offset = "0x9E8424")]
	[AttributeAttribute(Name = "CategoryAttribute", RVA = "0x9E8424", Offset = "0x9E8424")]
	public abstract class StaticCodeEventBase : EventNode
	{
		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		protected string eventName;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected Type targetType;

		[Token(Token = "0x170000B2")]
		protected EventInfo eventInfo
		{
			[Token(Token = "0x600078E")]
			[Address(RVA = "0x1BC164C", Offset = "0x1BC164C", VA = "0x1BC164C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1BC1860", Offset = "0x1BC1860", VA = "0x1BC1860")]
		public void SetEvent(EventInfo e)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1BC1540", Offset = "0x1BC1540", VA = "0x1BC1540", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x1BC1858", Offset = "0x1BC1858", VA = "0x1BC1858")]
		protected StaticCodeEventBase()
		{
		}
	}
	[Token(Token = "0x2000201")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E8494", Offset = "0x9E8494")]
	public class StaticCodeEvent : StaticCodeEventBase
	{
		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private FlowOutput o;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Action pointer;

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x1BC1484", Offset = "0x1BC1484", VA = "0x1BC1484", Slot = "26")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x1BC1708", Offset = "0x1BC1708", VA = "0x1BC1708", Slot = "27")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x1BC177C", Offset = "0x1BC177C", VA = "0x1BC177C")]
		private void Call()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x1BC17D0", Offset = "0x1BC17D0", VA = "0x1BC17D0", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x1BC1850", Offset = "0x1BC1850", VA = "0x1BC1850")]
		public StaticCodeEvent()
		{
		}
	}
	[Token(Token = "0x2000202")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E84A4", Offset = "0x9E84A4")]
	public class StaticCodeEvent<T> : StaticCodeEventBase
	{
		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FlowOutput o;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<T> pointer;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T eventValue;

		[Token(Token = "0x6000797")]
		public override void OnGraphStarted()
		{
		}

		[Token(Token = "0x6000798")]
		public override void OnGraphStoped()
		{
		}

		[Token(Token = "0x6000799")]
		private void Call(T value)
		{
		}

		[Token(Token = "0x600079A")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x600079B")]
		public StaticCodeEvent()
		{
		}

		[Token(Token = "0x600079C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB714", Offset = "0x9EB714")]
		private T <RegisterPorts>b__6_0()
		{
			return (T)null;
		}
	}
}
namespace FlowCanvas.Nodes.Legacy
{
	[Token(Token = "0x2000203")]
	public abstract class ReflectedFieldNode
	{
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x1BB35C0", Offset = "0x1BB35C0", VA = "0x1BB35C0")]
		public static ReflectedFieldNode Create(FieldInfo field)
		{
			return null;
		}

		[Token(Token = "0x600079E")]
		public abstract void RegisterPorts(FlowNode node, FieldInfo field, ReflectedFieldNodeWrapper.AccessMode accessMode);

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x1BB3618", Offset = "0x1BB3618", VA = "0x1BB3618")]
		protected ReflectedFieldNode()
		{
		}
	}
	[Token(Token = "0x2000204")]
	public sealed class PureReflectedFieldNode : ReflectedFieldNode
	{
		[Token(Token = "0x2000205")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E84B4", Offset = "0x9E84B4")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FieldInfo field;

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x26A4894", Offset = "0x26A4894", VA = "0x26A4894")]
			public <>c__DisplayClass0_0()
			{
			}
		}

		[Token(Token = "0x2000206")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E84C4", Offset = "0x9E84C4")]
		private sealed class <>c__DisplayClass0_1
		{
			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object constantValue;

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x26A489C", Offset = "0x26A489C", VA = "0x26A489C")]
			public <>c__DisplayClass0_1()
			{
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x26A48A4", Offset = "0x26A48A4", VA = "0x26A48A4")]
			internal object <RegisterPorts>b__0()
			{
				return null;
			}
		}

		[Token(Token = "0x2000207")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E84D4", Offset = "0x9E84D4")]
		private sealed class <>c__DisplayClass0_2
		{
			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ValueInput instanceInput;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass0_0 CS$<>8__locals1;

			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x26A48AC", Offset = "0x26A48AC", VA = "0x26A48AC")]
			public <>c__DisplayClass0_2()
			{
			}

			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x26A48B4", Offset = "0x26A48B4", VA = "0x26A48B4")]
			internal object <RegisterPorts>b__1()
			{
				return null;
			}
		}

		[Token(Token = "0x2000208")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E84E4", Offset = "0x9E84E4")]
		private sealed class <>c__DisplayClass0_3
		{
			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object instance;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ValueInput instanceInput;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ValueInput valueInput;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FlowOutput flowOut;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public <>c__DisplayClass0_0 CS$<>8__locals2;

			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x26A4904", Offset = "0x26A4904", VA = "0x26A4904")]
			public <>c__DisplayClass0_3()
			{
			}

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x26A490C", Offset = "0x26A490C", VA = "0x26A490C")]
			internal object <RegisterPorts>b__2()
			{
				return null;
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x26A4914", Offset = "0x26A4914", VA = "0x26A4914")]
			internal void <RegisterPorts>b__3(Flow f)
			{
			}
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x151F56C", Offset = "0x151F56C", VA = "0x151F56C", Slot = "4")]
		public override void RegisterPorts(FlowNode node, FieldInfo field, ReflectedFieldNodeWrapper.AccessMode accessMode)
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x151FA84", Offset = "0x151FA84", VA = "0x151FA84")]
		public PureReflectedFieldNode()
		{
		}
	}
	[Token(Token = "0x2000209")]
	public abstract class ReflectedMethodNode
	{
		[Token(Token = "0x200020A")]
		protected delegate void ActionCall();

		[Token(Token = "0x200020B")]
		protected delegate void ActionCall<T1>(T1 a);

		[Token(Token = "0x200020C")]
		protected delegate void ActionCall<T1, T2>(T1 a, T2 b);

		[Token(Token = "0x200020D")]
		protected delegate void ActionCall<T1, T2, T3>(T1 a, T2 b, T3 c);

		[Token(Token = "0x200020E")]
		protected delegate void ActionCall<T1, T2, T3, T4>(T1 a, T2 b, T3 c, T4 d);

		[Token(Token = "0x200020F")]
		protected delegate void ActionCall<T1, T2, T3, T4, T5>(T1 a, T2 b, T3 c, T4 d, T5 e);

		[Token(Token = "0x2000210")]
		protected delegate void ActionCall<T1, T2, T3, T4, T5, T6>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);

		[Token(Token = "0x2000211")]
		protected delegate void ActionCall<T1, T2, T3, T4, T5, T6, T7>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);

		[Token(Token = "0x2000212")]
		protected delegate void ActionCall<T1, T2, T3, T4, T5, T6, T7, T8>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);

		[Token(Token = "0x2000213")]
		protected delegate TResult FunctionCall<TResult>();

		[Token(Token = "0x2000214")]
		protected delegate TResult FunctionCall<T1, TResult>(T1 a);

		[Token(Token = "0x2000215")]
		protected delegate TResult FunctionCall<T1, T2, TResult>(T1 a, T2 b);

		[Token(Token = "0x2000216")]
		protected delegate TResult FunctionCall<T1, T2, T3, TResult>(T1 a, T2 b, T3 c);

		[Token(Token = "0x2000217")]
		protected delegate TResult FunctionCall<T1, T2, T3, T4, TResult>(T1 a, T2 b, T3 c, T4 d);

		[Token(Token = "0x2000218")]
		protected delegate TResult FunctionCall<T1, T2, T3, T4, T5, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e);

		[Token(Token = "0x2000219")]
		protected delegate TResult FunctionCall<T1, T2, T3, T4, T5, T6, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);

		[Token(Token = "0x200021A")]
		protected delegate TResult FunctionCall<T1, T2, T3, T4, T5, T6, T7, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);

		[Token(Token = "0x200021B")]
		protected delegate TResult FunctionCall<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);

		[Token(Token = "0x200021C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E84F4", Offset = "0x9E84F4")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ParameterInfo[] parameters;

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x26A5550", Offset = "0x26A5550", VA = "0x26A5550")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x26A5558", Offset = "0x26A5558", VA = "0x26A5558")]
			internal bool <Create>b__0(ParameterInfo p)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x200021D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8504", Offset = "0x9E8504")]
		private sealed class <>c
		{
			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<ParameterInfo, Type> <>9__20_0;

			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<ParameterInfo, Type> <>9__20_1;

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x26A5508", Offset = "0x26A5508", VA = "0x26A5508")]
			public <>c()
			{
			}

			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x26A5510", Offset = "0x26A5510", VA = "0x26A5510")]
			internal Type <TryCreateJit>b__20_0(ParameterInfo p)
			{
				return null;
			}

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x26A5530", Offset = "0x26A5530", VA = "0x26A5530")]
			internal Type <TryCreateJit>b__20_1(ParameterInfo p)
			{
				return null;
			}
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x1BAFFC4", Offset = "0x1BAFFC4", VA = "0x1BAFFC4")]
		public ReflectedMethodNode()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x1BB4630", Offset = "0x1BB4630", VA = "0x1BB4630")]
		public static ReflectedMethodNode Create(MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x1BB486C", Offset = "0x1BB486C", VA = "0x1BB486C")]
		private static ReflectedMethodNode TryCreateJit(MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x1BB50A0", Offset = "0x1BB50A0", VA = "0x1BB50A0")]
		public string GetName(MethodInfo method, int i)
		{
			return null;
		}

		[Token(Token = "0x60007AE")]
		public abstract void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options);
	}
	[Token(Token = "0x200021E")]
	public sealed class PureReflectedMethodNode : ReflectedMethodNode
	{
		[Token(Token = "0x200021F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8514", Offset = "0x9E8514")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PureReflectedMethodNode <>4__this;

			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ReflectedMethodRegistrationOptions options;

			[Token(Token = "0x6000800")]
			[Address(RVA = "0x26A4B34", Offset = "0x26A4B34", VA = "0x26A4B34")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000801")]
			[Address(RVA = "0x26A4B3C", Offset = "0x26A4B3C", VA = "0x26A4B3C")]
			internal object <RegisterPorts>b__0()
			{
				return null;
			}

			[Token(Token = "0x6000802")]
			[Address(RVA = "0x26A4B58", Offset = "0x26A4B58", VA = "0x26A4B58")]
			internal object <RegisterPorts>b__1()
			{
				return null;
			}
		}

		[Token(Token = "0x2000220")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8524", Offset = "0x9E8524")]
		private sealed class <>c__DisplayClass8_1
		{
			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FlowOutput o;

			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass8_0 CS$<>8__locals1;

			[Token(Token = "0x6000803")]
			[Address(RVA = "0x26A4B88", Offset = "0x26A4B88", VA = "0x26A4B88")]
			public <>c__DisplayClass8_1()
			{
			}

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x26A4B90", Offset = "0x26A4B90", VA = "0x26A4B90")]
			internal void <RegisterPorts>b__2(Flow f)
			{
			}
		}

		[Token(Token = "0x2000221")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8534", Offset = "0x9E8534")]
		private sealed class <>c__DisplayClass8_2
		{
			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass8_0 CS$<>8__locals2;

			[Token(Token = "0x6000805")]
			[Address(RVA = "0x26A4C08", Offset = "0x26A4C08", VA = "0x26A4C08")]
			public <>c__DisplayClass8_2()
			{
			}

			[Token(Token = "0x6000806")]
			[Address(RVA = "0x26A4C10", Offset = "0x26A4C10", VA = "0x26A4C10")]
			internal object <RegisterPorts>b__3()
			{
				return null;
			}
		}

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private MethodInfo method;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ValueInput instanceInput;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<ValueInput> inputs;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ValueInput> paramsInputs;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Type paramsArrayType;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private object[] args;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private object instance;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private object returnValue;

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x1BAEBB0", Offset = "0x1BAEBB0", VA = "0x1BAEBB0", Slot = "4")]
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options)
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x1BAFCDC", Offset = "0x1BAFCDC", VA = "0x1BAFCDC")]
		private object CallMethod()
		{
			return null;
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x1BAFFBC", Offset = "0x1BAFFBC", VA = "0x1BAFFBC")]
		public PureReflectedMethodNode()
		{
		}
	}
	[Token(Token = "0x2000222")]
	public sealed class ReflectedActionNode : ReflectedMethodNode
	{
		[Token(Token = "0x2000223")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8544", Offset = "0x9E8544")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReflectedActionNode <>4__this;

			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FlowOutput o;

			[Token(Token = "0x600080A")]
			[Address(RVA = "0x26A4ED0", Offset = "0x26A4ED0", VA = "0x26A4ED0")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600080B")]
			[Address(RVA = "0x26A4ED8", Offset = "0x26A4ED8", VA = "0x26A4ED8")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ActionCall call;

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x1BB1F2C", Offset = "0x1BB1F2C", VA = "0x1BB1F2C")]
		private void Call()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x1BB1F48", Offset = "0x1BB1F48", VA = "0x1BB1F48", Slot = "4")]
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options)
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x1BB20D8", Offset = "0x1BB20D8", VA = "0x1BB20D8")]
		public ReflectedActionNode()
		{
		}
	}
	[Token(Token = "0x2000224")]
	public sealed class ReflectedActionNode<T1> : ReflectedMethodNode
	{
		[Token(Token = "0x2000225")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8554", Offset = "0x9E8554")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedActionNode<T1> <>4__this;

			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x600080F")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000810")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}

			[Token(Token = "0x6000811")]
			internal T1 <RegisterPorts>b__1()
			{
				return (T1)null;
			}
		}

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ActionCall<T1> call;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 instance;

		[Token(Token = "0x600080C")]
		private void Call(T1 a)
		{
		}

		[Token(Token = "0x600080D")]
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options)
		{
		}

		[Token(Token = "0x600080E")]
		public ReflectedActionNode()
		{
		}
	}
	[Token(Token = "0x2000226")]
	public sealed class ReflectedActionNode<T1, T2> : ReflectedMethodNode
	{
		[Token(Token = "0x2000227")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8564", Offset = "0x9E8564")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedActionNode<T1, T2> <>4__this;

			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x6000815")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000816")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}

			[Token(Token = "0x6000817")]
			internal T1 <RegisterPorts>b__1()
			{
				return (T1)null;
			}
		}

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ActionCall<T1, T2> call;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 instance;

		[Token(Token = "0x6000812")]
		private void Call(T1 a, T2 b)
		{
		}

		[Token(Token = "0x6000813")]
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options)
		{
		}

		[Token(Token = "0x6000814")]
		public ReflectedActionNode()
		{
		}
	}
	[Token(Token = "0x2000228")]
	public sealed class ReflectedActionNode<T1, T2, T3> : ReflectedMethodNode
	{
		[Token(Token = "0x2000229")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8574", Offset = "0x9E8574")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedActionNode<T1, T2, T3> <>4__this;

			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x600081B")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600081C")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}

			[Token(Token = "0x600081D")]
			internal T1 <RegisterPorts>b__1()
			{
				return (T1)null;
			}
		}

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ActionCall<T1, T2, T3> call;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 instance;

		[Token(Token = "0x6000818")]
		private void Call(T1 a, T2 b, T3 c)
		{
		}

		[Token(Token = "0x6000819")]
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options)
		{
		}

		[Token(Token = "0x600081A")]
		public ReflectedActionNode()
		{
		}
	}
	[Token(Token = "0x200022A")]
	public sealed class ReflectedActionNode<T1, T2, T3, T4> : ReflectedMethodNode
	{
		[Token(Token = "0x200022B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8584", Offset = "0x9E8584")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedActionNode<T1, T2, T3, T4> <>4__this;

			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x6000821")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000822")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}

			[Token(Token = "0x6000823")]
			internal T1 <RegisterPorts>b__1()
			{
				return (T1)null;
			}
		}

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ActionCall<T1, T2, T3, T4> call;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 instance;

		[Token(Token = "0x600081E")]
		private void Call(T1 a, T2 b, T3 c, T4 d)
		{
		}

		[Token(Token = "0x600081F")]
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options)
		{
		}

		[Token(Token = "0x6000820")]
		public ReflectedActionNode()
		{
		}
	}
	[Token(Token = "0x200022C")]
	public sealed class ReflectedActionNode<T1, T2, T3, T4, T5> : ReflectedMethodNode
	{
		[Token(Token = "0x200022D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8594", Offset = "0x9E8594")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedActionNode<T1, T2, T3, T4, T5> <>4__this;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x6000827")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000828")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}

			[Token(Token = "0x6000829")]
			internal T1 <RegisterPorts>b__1()
			{
				return (T1)null;
			}
		}

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ActionCall<T1, T2, T3, T4, T5> call;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 instance;

		[Token(Token = "0x6000824")]
		private void Call(T1 a, T2 b, T3 c, T4 d, T5 e)
		{
		}

		[Token(Token = "0x6000825")]
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options)
		{
		}

		[Token(Token = "0x6000826")]
		public ReflectedActionNode()
		{
		}
	}
	[Token(Token = "0x200022E")]
	public sealed class ReflectedActionNode<T1, T2, T3, T4, T5, T6> : ReflectedMethodNode
	{
		[Token(Token = "0x200022F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E85A4", Offset = "0x9E85A4")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedActionNode<T1, T2, T3, T4, T5, T6> <>4__this;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x600082D")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600082E")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}

			[Token(Token = "0x600082F")]
			internal T1 <RegisterPorts>b__1()
			{
				return (T1)null;
			}
		}

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ActionCall<T1, T2, T3, T4, T5, T6> call;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 instance;

		[Token(Token = "0x600082A")]
		private void Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
		}

		[Token(Token = "0x600082B")]
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options)
		{
		}

		[Token(Token = "0x600082C")]
		public ReflectedActionNode()
		{
		}
	}
	[Token(Token = "0x2000230")]
	public sealed class ReflectedActionNode<T1, T2, T3, T4, T5, T6, T7> : ReflectedMethodNode
	{
		[Token(Token = "0x2000231")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E85B4", Offset = "0x9E85B4")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedActionNode<T1, T2, T3, T4, T5, T6, T7> <>4__this;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T7> p7;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x6000833")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000834")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}

			[Token(Token = "0x6000835")]
			internal T1 <RegisterPorts>b__1()
			{
				return (T1)null;
			}
		}

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ActionCall<T1, T2, T3, T4, T5, T6, T7> call;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 instance;

		[Token(Token = "0x6000830")]
		private void Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		{
		}

		[Token(Token = "0x6000831")]
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options)
		{
		}

		[Token(Token = "0x6000832")]
		public ReflectedActionNode()
		{
		}
	}
	[Token(Token = "0x2000232")]
	public sealed class ReflectedActionNode<T1, T2, T3, T4, T5, T6, T7, T8> : ReflectedMethodNode
	{
		[Token(Token = "0x2000233")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E85C4", Offset = "0x9E85C4")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedActionNode<T1, T2, T3, T4, T5, T6, T7, T8> <>4__this;

			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T7> p7;

			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T8> p8;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x6000839")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600083A")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}

			[Token(Token = "0x600083B")]
			internal T1 <RegisterPorts>b__1()
			{
				return (T1)null;
			}
		}

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ActionCall<T1, T2, T3, T4, T5, T6, T7, T8> call;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 instance;

		[Token(Token = "0x6000836")]
		private void Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		{
		}

		[Token(Token = "0x6000837")]
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options)
		{
		}

		[Token(Token = "0x6000838")]
		public ReflectedActionNode()
		{
		}
	}
	[Token(Token = "0x2000234")]
	public sealed class ReflectedFunctionNode<TResult> : ReflectedMethodNode
	{
		[Token(Token = "0x2000235")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E85D4", Offset = "0x9E85D4")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedFunctionNode<TResult> <>4__this;

			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedMethodRegistrationOptions options;

			[Token(Token = "0x600083F")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000840")]
			internal TResult <RegisterPorts>b__0()
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x2000236")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E85E4", Offset = "0x9E85E4")]
		private sealed class <>c__DisplayClass3_1
		{
			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public <>c__DisplayClass3_0 CS$<>8__locals1;

			[Token(Token = "0x6000841")]
			public <>c__DisplayClass3_1()
			{
			}

			[Token(Token = "0x6000842")]
			internal void <RegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FunctionCall<TResult> call;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TResult returnValue;

		[Token(Token = "0x600083C")]
		private TResult Call()
		{
			return (TResult)null;
		}

		[Token(Token = "0x600083D")]
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options)
		{
		}

		[Token(Token = "0x600083E")]
		public ReflectedFunctionNode()
		{
		}
	}
	[Token(Token = "0x2000237")]
	public sealed class ReflectedFunctionNode<T1, TResult> : ReflectedMethodNode
	{
		[Token(Token = "0x2000238")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E85F4", Offset = "0x9E85F4")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedFunctionNode<T1, TResult> <>4__this;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedMethodRegistrationOptions options;

			[Token(Token = "0x6000846")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000847")]
			internal T1 <RegisterPorts>b__2()
			{
				return (T1)null;
			}

			[Token(Token = "0x6000848")]
			internal TResult <RegisterPorts>b__0()
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x2000239")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8604", Offset = "0x9E8604")]
		private sealed class <>c__DisplayClass4_1
		{
			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public <>c__DisplayClass4_0 CS$<>8__locals1;

			[Token(Token = "0x6000849")]
			public <>c__DisplayClass4_1()
			{
			}

			[Token(Token = "0x600084A")]
			internal void <RegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FunctionCall<T1, TResult> call;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TResult returnValue;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 instance;

		[Token(Token = "0x6000843")]
		private TResult Call(T1 a)
		{
			return (TResult)null;
		}

		[Token(Token = "0x6000844")]
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options)
		{
		}

		[Token(Token = "0x6000845")]
		public ReflectedFunctionNode()
		{
		}
	}
	[Token(Token = "0x200023A")]
	public sealed class ReflectedFunctionNode<T1, T2, TResult> : ReflectedMethodNode
	{
		[Token(Token = "0x200023B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8614", Offset = "0x9E8614")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedFunctionNode<T1, T2, TResult> <>4__this;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedMethodRegistrationOptions options;

			[Token(Token = "0x600084E")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x600084F")]
			internal T1 <RegisterPorts>b__2()
			{
				return (T1)null;
			}

			[Token(Token = "0x6000850")]
			internal TResult <RegisterPorts>b__0()
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x200023C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8624", Offset = "0x9E8624")]
		private sealed class <>c__DisplayClass4_1
		{
			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public <>c__DisplayClass4_0 CS$<>8__locals1;

			[Token(Token = "0x6000851")]
			public <>c__DisplayClass4_1()
			{
			}

			[Token(Token = "0x6000852")]
			internal void <RegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FunctionCall<T1, T2, TResult> call;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TResult returnValue;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 instance;

		[Token(Token = "0x600084B")]
		private TResult Call(T1 a, T2 b)
		{
			return (TResult)null;
		}

		[Token(Token = "0x600084C")]
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options)
		{
		}

		[Token(Token = "0x600084D")]
		public ReflectedFunctionNode()
		{
		}
	}
	[Token(Token = "0x200023D")]
	public sealed class ReflectedFunctionNode<T1, T2, T3, TResult> : ReflectedMethodNode
	{
		[Token(Token = "0x200023E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8634", Offset = "0x9E8634")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedFunctionNode<T1, T2, T3, TResult> <>4__this;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedMethodRegistrationOptions options;

			[Token(Token = "0x6000856")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000857")]
			internal T1 <RegisterPorts>b__2()
			{
				return (T1)null;
			}

			[Token(Token = "0x6000858")]
			internal TResult <RegisterPorts>b__0()
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x200023F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8644", Offset = "0x9E8644")]
		private sealed class <>c__DisplayClass4_1
		{
			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public <>c__DisplayClass4_0 CS$<>8__locals1;

			[Token(Token = "0x6000859")]
			public <>c__DisplayClass4_1()
			{
			}

			[Token(Token = "0x600085A")]
			internal void <RegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FunctionCall<T1, T2, T3, TResult> call;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TResult returnValue;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 instance;

		[Token(Token = "0x6000853")]
		private TResult Call(T1 a, T2 b, T3 c)
		{
			return (TResult)null;
		}

		[Token(Token = "0x6000854")]
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options)
		{
		}

		[Token(Token = "0x6000855")]
		public ReflectedFunctionNode()
		{
		}
	}
	[Token(Token = "0x2000240")]
	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, TResult> : ReflectedMethodNode
	{
		[Token(Token = "0x2000241")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8654", Offset = "0x9E8654")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedFunctionNode<T1, T2, T3, T4, TResult> <>4__this;

			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedMethodRegistrationOptions options;

			[Token(Token = "0x600085E")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x600085F")]
			internal T1 <RegisterPorts>b__2()
			{
				return (T1)null;
			}

			[Token(Token = "0x6000860")]
			internal TResult <RegisterPorts>b__0()
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x2000242")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8664", Offset = "0x9E8664")]
		private sealed class <>c__DisplayClass4_1
		{
			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public <>c__DisplayClass4_0 CS$<>8__locals1;

			[Token(Token = "0x6000861")]
			public <>c__DisplayClass4_1()
			{
			}

			[Token(Token = "0x6000862")]
			internal void <RegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FunctionCall<T1, T2, T3, T4, TResult> call;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TResult returnValue;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 instance;

		[Token(Token = "0x600085B")]
		private TResult Call(T1 a, T2 b, T3 c, T4 d)
		{
			return (TResult)null;
		}

		[Token(Token = "0x600085C")]
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options)
		{
		}

		[Token(Token = "0x600085D")]
		public ReflectedFunctionNode()
		{
		}
	}
	[Token(Token = "0x2000243")]
	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, T5, TResult> : ReflectedMethodNode
	{
		[Token(Token = "0x2000244")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8674", Offset = "0x9E8674")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedFunctionNode<T1, T2, T3, T4, T5, TResult> <>4__this;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedMethodRegistrationOptions options;

			[Token(Token = "0x6000866")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000867")]
			internal T1 <RegisterPorts>b__2()
			{
				return (T1)null;
			}

			[Token(Token = "0x6000868")]
			internal TResult <RegisterPorts>b__0()
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x2000245")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8684", Offset = "0x9E8684")]
		private sealed class <>c__DisplayClass4_1
		{
			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public <>c__DisplayClass4_0 CS$<>8__locals1;

			[Token(Token = "0x6000869")]
			public <>c__DisplayClass4_1()
			{
			}

			[Token(Token = "0x600086A")]
			internal void <RegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FunctionCall<T1, T2, T3, T4, T5, TResult> call;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TResult returnValue;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 instance;

		[Token(Token = "0x6000863")]
		private TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (TResult)null;
		}

		[Token(Token = "0x6000864")]
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options)
		{
		}

		[Token(Token = "0x6000865")]
		public ReflectedFunctionNode()
		{
		}
	}
	[Token(Token = "0x2000246")]
	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, T5, T6, TResult> : ReflectedMethodNode
	{
		[Token(Token = "0x2000247")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8694", Offset = "0x9E8694")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedFunctionNode<T1, T2, T3, T4, T5, T6, TResult> <>4__this;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedMethodRegistrationOptions options;

			[Token(Token = "0x600086E")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x600086F")]
			internal T1 <RegisterPorts>b__2()
			{
				return (T1)null;
			}

			[Token(Token = "0x6000870")]
			internal TResult <RegisterPorts>b__0()
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x2000248")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E86A4", Offset = "0x9E86A4")]
		private sealed class <>c__DisplayClass4_1
		{
			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public <>c__DisplayClass4_0 CS$<>8__locals1;

			[Token(Token = "0x6000871")]
			public <>c__DisplayClass4_1()
			{
			}

			[Token(Token = "0x6000872")]
			internal void <RegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FunctionCall<T1, T2, T3, T4, T5, T6, TResult> call;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TResult returnValue;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 instance;

		[Token(Token = "0x600086B")]
		private TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return (TResult)null;
		}

		[Token(Token = "0x600086C")]
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options)
		{
		}

		[Token(Token = "0x600086D")]
		public ReflectedFunctionNode()
		{
		}
	}
	[Token(Token = "0x2000249")]
	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, T5, T6, T7, TResult> : ReflectedMethodNode
	{
		[Token(Token = "0x200024A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E86B4", Offset = "0x9E86B4")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedFunctionNode<T1, T2, T3, T4, T5, T6, T7, TResult> <>4__this;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T7> p7;

			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedMethodRegistrationOptions options;

			[Token(Token = "0x6000876")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000877")]
			internal T1 <RegisterPorts>b__2()
			{
				return (T1)null;
			}

			[Token(Token = "0x6000878")]
			internal TResult <RegisterPorts>b__0()
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x200024B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E86C4", Offset = "0x9E86C4")]
		private sealed class <>c__DisplayClass4_1
		{
			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public <>c__DisplayClass4_0 CS$<>8__locals1;

			[Token(Token = "0x6000879")]
			public <>c__DisplayClass4_1()
			{
			}

			[Token(Token = "0x600087A")]
			internal void <RegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FunctionCall<T1, T2, T3, T4, T5, T6, T7, TResult> call;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TResult returnValue;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 instance;

		[Token(Token = "0x6000873")]
		private TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		{
			return (TResult)null;
		}

		[Token(Token = "0x6000874")]
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options)
		{
		}

		[Token(Token = "0x6000875")]
		public ReflectedFunctionNode()
		{
		}
	}
	[Token(Token = "0x200024C")]
	public sealed class ReflectedFunctionNode<T1, T2, T3, T4, T5, T6, T7, T8, TResult> : ReflectedMethodNode
	{
		[Token(Token = "0x200024D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E86D4", Offset = "0x9E86D4")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedFunctionNode<T1, T2, T3, T4, T5, T6, T7, T8, TResult> <>4__this;

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T1> p1;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T2> p2;

			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T3> p3;

			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T4> p4;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T5> p5;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T6> p6;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T7> p7;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ValueInput<T8> p8;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectedMethodRegistrationOptions options;

			[Token(Token = "0x600087E")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x600087F")]
			internal T1 <RegisterPorts>b__2()
			{
				return (T1)null;
			}

			[Token(Token = "0x6000880")]
			internal TResult <RegisterPorts>b__0()
			{
				return (TResult)null;
			}
		}

		[Token(Token = "0x200024E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E86E4", Offset = "0x9E86E4")]
		private sealed class <>c__DisplayClass4_1
		{
			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FlowOutput o;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public <>c__DisplayClass4_0 CS$<>8__locals1;

			[Token(Token = "0x6000881")]
			public <>c__DisplayClass4_1()
			{
			}

			[Token(Token = "0x6000882")]
			internal void <RegisterPorts>b__1(Flow f)
			{
			}
		}

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FunctionCall<T1, T2, T3, T4, T5, T6, T7, T8, TResult> call;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TResult returnValue;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T1 instance;

		[Token(Token = "0x600087B")]
		private TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		{
			return (TResult)null;
		}

		[Token(Token = "0x600087C")]
		public override void RegisterPorts(FlowNode node, MethodInfo method, ReflectedMethodRegistrationOptions options)
		{
		}

		[Token(Token = "0x600087D")]
		public ReflectedFunctionNode()
		{
		}
	}
}
namespace FlowCanvas.Macros
{
	[Token(Token = "0x200024F")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x9E86F4", Offset = "0x9E86F4")]
	public class Macro : FlowScriptBase
	{
		[Serializable]
		[Token(Token = "0x2000250")]
		private struct DerivedSerializationData
		{
			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<DynamicPortDefinition> inputDefinitions;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public List<DynamicPortDefinition> outputDefinitions;
		}

		[Token(Token = "0x2000251")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8738", Offset = "0x9E8738")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DynamicPortDefinition def;

			[Token(Token = "0x600088C")]
			[Address(RVA = "0x146A8AC", Offset = "0x146A8AC", VA = "0x146A8AC")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x600088D")]
			[Address(RVA = "0x146A8B4", Offset = "0x146A8B4", VA = "0x146A8B4")]
			internal bool <AddInputDefinition>b__0(DynamicPortDefinition d)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000252")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8748", Offset = "0x9E8748")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DynamicPortDefinition def;

			[Token(Token = "0x600088E")]
			[Address(RVA = "0x146A908", Offset = "0x146A908", VA = "0x146A908")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x600088F")]
			[Address(RVA = "0x146A910", Offset = "0x146A910", VA = "0x146A910")]
			internal bool <AddOutputDefinition>b__0(DynamicPortDefinition d)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		public List<DynamicPortDefinition> inputDefinitions;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		public List<DynamicPortDefinition> outputDefinitions;

		[NonSerialized]
		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Dictionary<string, FlowHandler> entryActionMap;

		[NonSerialized]
		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Dictionary<string, FlowHandler> exitActionMap;

		[NonSerialized]
		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Dictionary<string, ValueHandlerObject> entryFunctionMap;

		[NonSerialized]
		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Dictionary<string, ValueHandlerObject> exitFunctionMap;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private MacroInputNode _entry;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private MacroOutputNode _exit;

		[Token(Token = "0x170000B3")]
		public override bool useLocalBlackboard
		{
			[Token(Token = "0x6000885")]
			[Address(RVA = "0x15134E8", Offset = "0x15134E8", VA = "0x15134E8", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B4")]
		public MacroInputNode entry
		{
			[Token(Token = "0x6000886")]
			[Address(RVA = "0x15134F0", Offset = "0x15134F0", VA = "0x15134F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B5")]
		public MacroOutputNode exit
		{
			[Token(Token = "0x6000887")]
			[Address(RVA = "0x15135C8", Offset = "0x15135C8", VA = "0x15135C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x15133A4", Offset = "0x15133A4", VA = "0x15133A4", Slot = "13")]
		public override object OnDerivedDataSerialization()
		{
			return null;
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x151342C", Offset = "0x151342C", VA = "0x151342C", Slot = "14")]
		public override void OnDerivedDataDeserialization(object data)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x15136A8", Offset = "0x15136A8", VA = "0x15136A8", Slot = "15")]
		protected override void OnGraphValidate()
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x151388C", Offset = "0x151388C", VA = "0x151388C")]
		public Port AddInputDefinition(DynamicPortDefinition def)
		{
			return null;
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x1513A20", Offset = "0x1513A20", VA = "0x1513A20")]
		public Port AddOutputDefinition(DynamicPortDefinition def)
		{
			return null;
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x1513BB4", Offset = "0x1513BB4", VA = "0x1513BB4")]
		public Macro()
		{
		}
	}
	[Token(Token = "0x2000253")]
	[DoNotList]
	[AttributeAttribute(Name = "IconAttribute", RVA = "0x9E8758", Offset = "0x9E8758")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E8758", Offset = "0x9E8758")]
	[ProtectedSingleton]
	public class MacroInputNode : FlowNode
	{
		[Token(Token = "0x2000254")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E87F8", Offset = "0x9E87F8")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DynamicPortDefinition def;

			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MacroInputNode <>4__this;

			[Token(Token = "0x6000894")]
			[Address(RVA = "0x146A964", Offset = "0x146A964", VA = "0x146A964")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000895")]
			[Address(RVA = "0x146A96C", Offset = "0x146A96C", VA = "0x146A96C")]
			internal object <RegisterPorts>b__0()
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		public override Alignment2x2 iconAlignment
		{
			[Token(Token = "0x6000890")]
			[Address(RVA = "0x1513E98", Offset = "0x1513E98", VA = "0x1513E98", Slot = "14")]
			get
			{
				return default(Alignment2x2);
			}
		}

		[Token(Token = "0x170000B7")]
		private Macro macro
		{
			[Token(Token = "0x6000891")]
			[Address(RVA = "0x1513EA0", Offset = "0x1513EA0", VA = "0x1513EA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x1513F20", Offset = "0x1513F20", VA = "0x1513F20", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x1514250", Offset = "0x1514250", VA = "0x1514250")]
		public MacroInputNode()
		{
		}
	}
	[Token(Token = "0x2000255")]
	[DoNotList]
	[AttributeAttribute(Name = "ColorAttribute", RVA = "0x9E8808", Offset = "0x9E8808")]
	public class MacroNodeWrapper : FlowNode, IGraphAssignable, IUpdatable
	{
		[Token(Token = "0x2000256")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8854", Offset = "0x9E8854")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DynamicPortDefinition defIn;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MacroNodeWrapper <>4__this;

			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x146A9F8", Offset = "0x146A9F8", VA = "0x146A9F8")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x146AA00", Offset = "0x146AA00", VA = "0x146AA00")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x2000257")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8864", Offset = "0x9E8864")]
		private sealed class <>c__DisplayClass15_1
		{
			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DynamicPortDefinition defOut;

			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MacroNodeWrapper <>4__this;

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x146AAC4", Offset = "0x146AAC4", VA = "0x146AAC4")]
			public <>c__DisplayClass15_1()
			{
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x146AACC", Offset = "0x146AACC", VA = "0x146AACC")]
			internal object <RegisterPorts>b__1()
			{
				return null;
			}
		}

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Macro _macro;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool instantiated;

		[Token(Token = "0x170000B8")]
		public override string name
		{
			[Token(Token = "0x6000896")]
			[Address(RVA = "0x1514258", Offset = "0x1514258", VA = "0x1514258", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		public override string description
		{
			[Token(Token = "0x6000897")]
			[Address(RVA = "0x1514300", Offset = "0x1514300", VA = "0x1514300", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		public Macro macro
		{
			[Token(Token = "0x6000898")]
			[Address(RVA = "0x1514488", Offset = "0x1514488", VA = "0x1514488")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000899")]
			[Address(RVA = "0x1514490", Offset = "0x1514490", VA = "0x1514490")]
			set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		private Graph NodeCanvas.Framework.IGraphAssignable.nestedGraph
		{
			[Token(Token = "0x600089A")]
			[Address(RVA = "0x1514574", Offset = "0x1514574", VA = "0x1514574", Slot = "40")]
			get
			{
				return null;
			}
			[Token(Token = "0x600089B")]
			[Address(RVA = "0x151457C", Offset = "0x151457C", VA = "0x151457C", Slot = "41")]
			set
			{
			}
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x151460C", Offset = "0x151460C", VA = "0x151460C", Slot = "42")]
		private Graph[] NodeCanvas.Framework.IGraphAssignable.GetInstances()
		{
			return null;
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x15146D0", Offset = "0x15146D0", VA = "0x15146D0")]
		public void CheckInstance()
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x15147B8", Offset = "0x15147B8", VA = "0x15147B8", Slot = "43")]
		private void NodeCanvas.Framework.IUpdatable.Update()
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x1514860", Offset = "0x1514860", VA = "0x1514860", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x1514DA0", Offset = "0x1514DA0", VA = "0x1514DA0")]
		public MacroNodeWrapper()
		{
		}
	}
	[Token(Token = "0x2000258")]
	[DoNotList]
	[AttributeAttribute(Name = "IconAttribute", RVA = "0x9E8874", Offset = "0x9E8874")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E8874", Offset = "0x9E8874")]
	[ProtectedSingleton]
	public class MacroOutputNode : FlowNode
	{
		[Token(Token = "0x2000259")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8914", Offset = "0x9E8914")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DynamicPortDefinition def;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MacroOutputNode <>4__this;

			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x146AB50", Offset = "0x146AB50", VA = "0x146AB50")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x146AB58", Offset = "0x146AB58", VA = "0x146AB58")]
			internal void <RegisterPorts>b__0(Flow f)
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public override Alignment2x2 iconAlignment
		{
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x1514DA8", Offset = "0x1514DA8", VA = "0x1514DA8", Slot = "14")]
			get
			{
				return default(Alignment2x2);
			}
		}

		[Token(Token = "0x170000BD")]
		private Macro macro
		{
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x1514DB0", Offset = "0x1514DB0", VA = "0x1514DB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x1514E30", Offset = "0x1514E30", VA = "0x1514E30", Slot = "38")]
		protected override void RegisterPorts()
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x1515154", Offset = "0x1515154", VA = "0x1515154")]
		public MacroOutputNode()
		{
		}
	}
}
namespace NodeCanvas.Framework
{
	[Token(Token = "0x200025A")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E8924", Offset = "0x9E8924")]
	public class GraphInfoAttribute : Attribute
	{
		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string packageName;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string docsURL;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string resourcesURL;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string forumsURL;

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x150DE88", Offset = "0x150DE88", VA = "0x150DE88")]
		public GraphInfoAttribute()
		{
		}
	}
	[Token(Token = "0x200025B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E8938", Offset = "0x9E8938")]
	public class ToolbarMenuItemAttribute : Attribute
	{
		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string path;

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x1BC701C", Offset = "0x1BC701C", VA = "0x1BC701C")]
		public ToolbarMenuItemAttribute(string path)
		{
		}
	}
	[Token(Token = "0x200025C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E894C", Offset = "0x9E894C")]
	public class BlackboardOnlyAttribute : Attribute
	{
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x135F354", Offset = "0x135F354", VA = "0x135F354")]
		public BlackboardOnlyAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200025D")]
	public class CanvasGroup
	{
		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rect rect;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color color;

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x136139C", Offset = "0x136139C", VA = "0x136139C")]
		public CanvasGroup()
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x13613A4", Offset = "0x13613A4", VA = "0x13613A4")]
		public CanvasGroup(Rect rect, string name)
		{
		}
	}
	[Token(Token = "0x200025E")]
	[SpoofAOT]
	public abstract class Connection : IGraphElement
	{
		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Node _sourceNode;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Node _targetNode;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _isDisabled;

		[NonSerialized]
		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Status _status;

		[Token(Token = "0x170000BE")]
		public Node sourceNode
		{
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x13649F4", Offset = "0x13649F4", VA = "0x13649F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x13649FC", Offset = "0x13649FC", VA = "0x13649FC")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public Node targetNode
		{
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x1364A04", Offset = "0x1364A04", VA = "0x1364A04")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x1364A0C", Offset = "0x1364A0C", VA = "0x1364A0C")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public bool isActive
		{
			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x135D230", Offset = "0x135D230", VA = "0x135D230")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x1364A14", Offset = "0x1364A14", VA = "0x1364A14")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public Status status
		{
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x1364A94", Offset = "0x1364A94", VA = "0x1364A94")]
			get
			{
				return default(Status);
			}
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x1364A9C", Offset = "0x1364A9C", VA = "0x1364A9C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public Graph graph
		{
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x135CF70", Offset = "0x135CF70", VA = "0x135CF70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x135D334", Offset = "0x135D334", VA = "0x135D334")]
		public Connection()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x1364AA4", Offset = "0x1364AA4", VA = "0x1364AA4")]
		public static Connection Create(Node source, Node target, int sourceIndex = -1, int targetIndex = -1)
		{
			return null;
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x1364D10", Offset = "0x1364D10", VA = "0x1364D10")]
		public Connection Duplicate(Node newSource, Node newTarget)
		{
			return null;
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x1365054", Offset = "0x1365054", VA = "0x1365054", Slot = "5")]
		public virtual void OnCreate(int sourceIndex, int targetIndex)
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x1365058", Offset = "0x1365058", VA = "0x1365058", Slot = "6")]
		public virtual void OnValidate(int sourceIndex, int targetIndex)
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x136505C", Offset = "0x136505C", VA = "0x136505C", Slot = "7")]
		public virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x135C6B8", Offset = "0x135C6B8", VA = "0x135C6B8")]
		public int SetSourceNode(Node newSource, int index = -1)
		{
			return default(int);
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x135CA68", Offset = "0x135CA68", VA = "0x135CA68")]
		public int SetTargetNode(Node newTarget, int index = -1)
		{
			return default(int);
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x1365060", Offset = "0x1365060", VA = "0x1365060", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x13650DC", Offset = "0x13650DC", VA = "0x13650DC")]
		public Status Execute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x1364A58", Offset = "0x1364A58", VA = "0x1364A58")]
		public void Reset(bool recursively = true)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200025F")]
	public abstract class Graph : ScriptableObject, ITaskSystem, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000260")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8970", Offset = "0x9E8970")]
		private sealed class <>c__DisplayClass107_0
		{
			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graph targetGraph;

			[Token(Token = "0x6000937")]
			[Address(RVA = "0x1469AD0", Offset = "0x1469AD0", VA = "0x1469AD0")]
			public <>c__DisplayClass107_0()
			{
			}

			[Token(Token = "0x6000938")]
			[Address(RVA = "0x1469AD8", Offset = "0x1469AD8", VA = "0x1469AD8")]
			internal bool <CloneNodes>b__0(Node n)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000261")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8980", Offset = "0x9E8980")]
		private sealed class <>c
		{
			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Node, bool> <>9__112_0;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Node, int> <>9__112_1;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<Node, bool> <>9__130_0;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<Node, bool> <>9__131_0;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<BBParameter, bool> <>9__146_0;

			[Token(Token = "0x600093A")]
			[Address(RVA = "0x146997C", Offset = "0x146997C", VA = "0x146997C")]
			public <>c()
			{
			}

			[Token(Token = "0x600093B")]
			[Address(RVA = "0x1469984", Offset = "0x1469984", VA = "0x1469984")]
			internal bool <UpdateNodeIDs>b__112_0(Node n)
			{
				return default(bool);
			}

			[Token(Token = "0x600093C")]
			[Address(RVA = "0x14699DC", Offset = "0x14699DC", VA = "0x14699DC")]
			internal int <UpdateNodeIDs>b__112_1(Node n)
			{
				return default(int);
			}

			[Token(Token = "0x600093D")]
			[Address(RVA = "0x1469A08", Offset = "0x1469A08", VA = "0x1469A08")]
			internal bool <GetRootNodes>b__130_0(Node n)
			{
				return default(bool);
			}

			[Token(Token = "0x600093E")]
			[Address(RVA = "0x1469A60", Offset = "0x1469A60", VA = "0x1469A60")]
			internal bool <GetLeafNodes>b__131_0(Node n)
			{
				return default(bool);
			}

			[Token(Token = "0x600093F")]
			[Address(RVA = "0x1469AB8", Offset = "0x1469AB8", VA = "0x1469AB8")]
			internal bool <GetDefinedParameters>b__146_0(BBParameter p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000262")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8990", Offset = "0x9E8990")]
		private sealed class <>c__DisplayClass125_0
		{
			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int searchID;

			[Token(Token = "0x6000940")]
			[Address(RVA = "0x1469B4C", Offset = "0x1469B4C", VA = "0x1469B4C")]
			public <>c__DisplayClass125_0()
			{
			}

			[Token(Token = "0x6000941")]
			[Address(RVA = "0x1469B54", Offset = "0x1469B54", VA = "0x1469B54")]
			internal bool <GetNodeWithID>b__0(Node n)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000263")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E89A0", Offset = "0x9E89A0")]
		private sealed class <>c__DisplayClass152_0
		{
			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Node node;

			[Token(Token = "0x6000942")]
			[Address(RVA = "0x1469B78", Offset = "0x1469B78", VA = "0x1469B78")]
			public <>c__DisplayClass152_0()
			{
			}

			[Token(Token = "0x6000943")]
			[Address(RVA = "0x1469B80", Offset = "0x1469B80", VA = "0x1469B80")]
			internal bool <RemoveNode>b__0(Node n)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _serializedGraph;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<UnityEngine.Object> _objectReferences;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _deserializationFailed;

		[NonSerialized]
		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool hasDeserialized;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string _category;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string _comments;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector2 _translation;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _zoomFactor;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Node> _nodes;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<CanvasGroup> _canvasGroups;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BlackboardSource _localBlackboard;

		[NonSerialized]
		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Component _agent;

		[NonSerialized]
		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IBlackboard _blackboard;

		[NonSerialized]
		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<Graph> runningGraphs;

		[NonSerialized]
		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float timeStarted;

		[NonSerialized]
		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool initialReferencesUpdated;

		[NonSerialized]
		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool _isAutoUpdated;

		[NonSerialized]
		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
		private bool _isRunning;

		[NonSerialized]
		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x87")]
		private bool _isPaused;

		[Token(Token = "0x170000C3")]
		public abstract Type baseNodeType
		{
			[Token(Token = "0x60008E0")]
			get;
		}

		[Token(Token = "0x170000C4")]
		public abstract bool requiresAgent
		{
			[Token(Token = "0x60008E1")]
			get;
		}

		[Token(Token = "0x170000C5")]
		public abstract bool requiresPrimeNode
		{
			[Token(Token = "0x60008E2")]
			get;
		}

		[Token(Token = "0x170000C6")]
		public abstract bool isTree
		{
			[Token(Token = "0x60008E3")]
			get;
		}

		[Token(Token = "0x170000C7")]
		public abstract bool useLocalBlackboard
		{
			[Token(Token = "0x60008E4")]
			get;
		}

		[Token(Token = "0x170000C8")]
		public abstract bool canAcceptVariableDrops
		{
			[Token(Token = "0x60008E5")]
			get;
		}

		[Token(Token = "0x170000C9")]
		public new string name
		{
			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x1508EB8", Offset = "0x1508EB8", VA = "0x1508EB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x1508EC0", Offset = "0x1508EC0", VA = "0x1508EC0")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public string category
		{
			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x1508EC8", Offset = "0x1508EC8", VA = "0x1508EC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x1508ED0", Offset = "0x1508ED0", VA = "0x1508ED0")]
			set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public string comments
		{
			[Token(Token = "0x60008EA")]
			[Address(RVA = "0x1508ED8", Offset = "0x1508ED8", VA = "0x1508ED8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x1508EE0", Offset = "0x1508EE0", VA = "0x1508EE0")]
			set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public float elapsedTime
		{
			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x1508EE8", Offset = "0x1508EE8", VA = "0x1508EE8", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000CD")]
		public bool isRunning
		{
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x1508F2C", Offset = "0x1508F2C", VA = "0x1508F2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x1508F34", Offset = "0x1508F34", VA = "0x1508F34")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public bool isPaused
		{
			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x1508F40", Offset = "0x1508F40", VA = "0x1508F40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x1508F48", Offset = "0x1508F48", VA = "0x1508F48")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public bool isAutoUpdated
		{
			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x1508F54", Offset = "0x1508F54", VA = "0x1508F54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008F2")]
			[Address(RVA = "0x1508F5C", Offset = "0x1508F5C", VA = "0x1508F5C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public List<Node> allNodes
		{
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x1508F68", Offset = "0x1508F68", VA = "0x1508F68")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x1508F70", Offset = "0x1508F70", VA = "0x1508F70")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public Node primeNode
		{
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x1508F78", Offset = "0x1508F78", VA = "0x1508F78")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x150901C", Offset = "0x150901C", VA = "0x150901C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public List<CanvasGroup> canvasGroups
		{
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x1509248", Offset = "0x1509248", VA = "0x1509248")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x1509250", Offset = "0x1509250", VA = "0x1509250")]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public Vector2 translation
		{
			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x1509258", Offset = "0x1509258", VA = "0x1509258")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x1509260", Offset = "0x1509260", VA = "0x1509260")]
			set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public float zoomFactor
		{
			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x1509268", Offset = "0x1509268", VA = "0x1509268")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x1509270", Offset = "0x1509270", VA = "0x1509270")]
			set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public Component agent
		{
			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x1509278", Offset = "0x1509278", VA = "0x1509278", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008FE")]
			[Address(RVA = "0x1509280", Offset = "0x1509280", VA = "0x1509280")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		public IBlackboard blackboard
		{
			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x1509288", Offset = "0x1509288", VA = "0x1509288", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000900")]
			[Address(RVA = "0x15092C8", Offset = "0x15092C8", VA = "0x15092C8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public BlackboardSource localBlackboard
		{
			[Token(Token = "0x6000901")]
			[Address(RVA = "0x1508CD4", Offset = "0x1508CD4", VA = "0x1508CD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D8")]
		private UnityEngine.Object NodeCanvas.Framework.ITaskSystem.contextObject
		{
			[Token(Token = "0x6000902")]
			[Address(RVA = "0x1509328", Offset = "0x1509328", VA = "0x1509328", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000007")]
		public static event Action<Graph> onGraphSerialized
		{
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x1506A68", Offset = "0x1506A68", VA = "0x1506A68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB724", Offset = "0x9EB724")]
			add
			{
			}
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x1506B5C", Offset = "0x1506B5C", VA = "0x1506B5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB734", Offset = "0x9EB734")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public static event Action<Graph> onGraphDeserialized
		{
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x1506C50", Offset = "0x1506C50", VA = "0x1506C50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB744", Offset = "0x9EB744")]
			add
			{
			}
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x1506D48", Offset = "0x1506D48", VA = "0x1506D48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB754", Offset = "0x9EB754")]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event Action<bool> onFinish
		{
			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x1508D78", Offset = "0x1508D78", VA = "0x1508D78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB764", Offset = "0x9EB764")]
			add
			{
			}
			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x1508E18", Offset = "0x1508E18", VA = "0x1508E18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB774", Offset = "0x9EB774")]
			remove
			{
			}
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x1506E40", Offset = "0x1506E40", VA = "0x1506E40", Slot = "11")]
		private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x1506FCC", Offset = "0x1506FCC", VA = "0x1506FCC", Slot = "12")]
		private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x15071F8", Offset = "0x15071F8", VA = "0x15071F8")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x150763C", Offset = "0x150763C", VA = "0x150763C")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x1507640", Offset = "0x1507640", VA = "0x1507640")]
		protected void OnDestroy()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x1507644", Offset = "0x1507644", VA = "0x1507644")]
		protected void OnValidate()
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x1507648", Offset = "0x1507648", VA = "0x1507648")]
		protected void Reset()
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x1506E44", Offset = "0x1506E44", VA = "0x1506E44")]
		public void Serialize()
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x1506FD0", Offset = "0x1506FD0", VA = "0x1506FD0")]
		public void Deserialize()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x15078AC", Offset = "0x15078AC", VA = "0x15078AC")]
		public string Serialize(bool pretyJson, List<UnityEngine.Object> objectReferences)
		{
			return null;
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x15076C8", Offset = "0x15076C8", VA = "0x15076C8")]
		public GraphSerializationData Deserialize(string serializedGraph, bool validate, List<UnityEngine.Object> objectReferences)
		{
			return null;
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x15084E4", Offset = "0x15084E4", VA = "0x15084E4")]
		private bool LoadGraphData(GraphSerializationData data, bool validate)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x1508940", Offset = "0x1508940", VA = "0x1508940", Slot = "13")]
		public virtual object OnDerivedDataSerialization()
		{
			return null;
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x1508948", Offset = "0x1508948", VA = "0x1508948", Slot = "14")]
		public virtual void OnDerivedDataDeserialization(object data)
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x150894C", Offset = "0x150894C", VA = "0x150894C")]
		public void GetSerializationData(out string json, out List<UnityEngine.Object> references)
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x15089F8", Offset = "0x15089F8", VA = "0x15089F8")]
		public void SetSerializationObjectReferences(List<UnityEngine.Object> references)
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x1508A00", Offset = "0x1508A00", VA = "0x1508A00")]
		public string SerializeLocalBlackboard()
		{
			return null;
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x1508AD4", Offset = "0x1508AD4", VA = "0x1508AD4")]
		public bool DeserializeLocalBlackboard(string json)
		{
			return default(bool);
		}

		[Token(Token = "0x60008DA")]
		public static T Clone<T>(T graph) where T : Graph
		{
			return null;
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x1508C90", Offset = "0x1508C90", VA = "0x1508C90")]
		public void CopySerialized(Graph target)
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x1507208", Offset = "0x1507208", VA = "0x1507208")]
		public void Validate()
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x1508D74", Offset = "0x1508D74", VA = "0x1508D74", Slot = "15")]
		protected virtual void OnGraphValidate()
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x150932C", Offset = "0x150932C", VA = "0x150932C")]
		public static List<Node> CloneNodes(List<Node> originalNodes, [Optional] Graph targetGraph, [Optional] Vector2 originPosition)
		{
			return null;
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x150A268", Offset = "0x150A268", VA = "0x150A268")]
		public void UpdateReferencesFromOwner(GraphOwner owner)
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x150A310", Offset = "0x150A310", VA = "0x150A310")]
		public void UpdateReferences(Component newAgent, IBlackboard newBlackboard)
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x150A41C", Offset = "0x150A41C", VA = "0x150A41C")]
		private void UpdateNodeBBFields()
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x150A4EC", Offset = "0x150A4EC", VA = "0x150A4EC", Slot = "8")]
		public void SendTaskOwnerDefaults()
		{
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x1507B0C", Offset = "0x1507B0C", VA = "0x1507B0C")]
		public void UpdateNodeIDs(bool alsoReorderList)
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x150A5B4", Offset = "0x150A5B4", VA = "0x150A5B4")]
		private int AssignNodeID(Node node, int lastID, ref Node[] parsed)
		{
			return default(int);
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x150A700", Offset = "0x150A700", VA = "0x150A700")]
		public void StartGraph(Component newAgent, IBlackboard newBlackboard, bool autoUpdate, [Optional] Action<bool> callback)
		{
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x150AF50", Offset = "0x150AF50", VA = "0x150AF50")]
		public void Stop(bool success = true)
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x150B208", Offset = "0x150B208", VA = "0x150B208")]
		public void Pause()
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x150AF34", Offset = "0x150AF34", VA = "0x150AF34")]
		public void UpdateGraph()
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x150B3A4", Offset = "0x150B3A4", VA = "0x150B3A4", Slot = "22")]
		protected virtual void OnGraphStarted()
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x150B3A8", Offset = "0x150B3A8", VA = "0x150B3A8", Slot = "23")]
		protected virtual void OnGraphUpdate()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x150B3AC", Offset = "0x150B3AC", VA = "0x150B3AC", Slot = "24")]
		protected virtual void OnGraphStoped()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x150B3B0", Offset = "0x150B3B0", VA = "0x150B3B0", Slot = "25")]
		protected virtual void OnGraphPaused()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x150B3B4", Offset = "0x150B3B4", VA = "0x150B3B4", Slot = "26")]
		protected virtual void OnGraphUnpaused()
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x150B3B8", Offset = "0x150B3B8", VA = "0x150B3B8", Slot = "9")]
		public void SendEvent(EventData eventData, object sender)
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x150B53C", Offset = "0x150B53C", VA = "0x150B53C")]
		public static void SendGlobalEvent(EventData eventData, object sender)
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x150B734", Offset = "0x150B734", VA = "0x150B734")]
		public Node GetNodeWithID(int searchID)
		{
			return null;
		}

		[Token(Token = "0x6000916")]
		public List<T> GetAllNodesOfType<T>() where T : Node
		{
			return null;
		}

		[Token(Token = "0x6000917")]
		public T GetNodeWithTag<T>(string tagName) where T : Node
		{
			return null;
		}

		[Token(Token = "0x6000918")]
		public List<T> GetNodesWithTag<T>(string tagName) where T : Node
		{
			return null;
		}

		[Token(Token = "0x6000919")]
		public List<T> GetAllTagedNodes<T>() where T : Node
		{
			return null;
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x150B848", Offset = "0x150B848", VA = "0x150B848")]
		public List<Node> GetRootNodes()
		{
			return null;
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x150B988", Offset = "0x150B988", VA = "0x150B988")]
		public List<Node> GetLeafNodes()
		{
			return null;
		}

		[Token(Token = "0x600091C")]
		public List<T> GetAllNestedGraphs<T>(bool recursive) where T : Graph
		{
			return null;
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x150BAC8", Offset = "0x150BAC8", VA = "0x150BAC8")]
		public List<Graph> GetAllInstancedNestedGraphs()
		{
			return null;
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x150BF10", Offset = "0x150BF10", VA = "0x150BF10")]
		public static Graph GetElementGraph(object obj)
		{
			return null;
		}

		[Token(Token = "0x600091F")]
		public List<T> GetAllTasksOfType<T>() where T : Task
		{
			return null;
		}

		[Token(Token = "0x6000920")]
		private void GetObjectTasks<T>(object obj, ref List<T> tasks) where T : Task
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x150C0CC", Offset = "0x150C0CC", VA = "0x150C0CC")]
		public HierarchyTree.Element GetFlatGraphHierarchy()
		{
			return null;
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x150C368", Offset = "0x150C368", VA = "0x150C368")]
		public HierarchyTree.Element GetFullGraphHierarchy()
		{
			return null;
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x150C4C8", Offset = "0x150C4C8", VA = "0x150C4C8")]
		public HierarchyTree.Element GetNestedGraphHierarchy()
		{
			return null;
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x150C1C4", Offset = "0x150C1C4", VA = "0x150C1C4")]
		private HierarchyTree.Element GetTreeNodeElement(Node node, bool recurse, ref int lastID)
		{
			return null;
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x150C6E8", Offset = "0x150C6E8", VA = "0x150C6E8")]
		public static HierarchyTree.Element GetTaskAndParametersStructureInTarget(object obj)
		{
			return null;
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x150CAA8", Offset = "0x150CAA8", VA = "0x150CAA8")]
		public IGraphElement GetTaskParentElement(Task targetTask)
		{
			return null;
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x150CB2C", Offset = "0x150CB2C", VA = "0x150CB2C")]
		public IGraphElement GetParameterParentElement(BBParameter targetParameter)
		{
			return null;
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x150CBB0", Offset = "0x150CBB0", VA = "0x150CBB0")]
		public static Task[] GetTasksInElement(IGraphElement target)
		{
			return null;
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x150CC54", Offset = "0x150CC54", VA = "0x150CC54")]
		public static BBParameter[] GetParametersInElement(IGraphElement target)
		{
			return null;
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x150CCF8", Offset = "0x150CCF8", VA = "0x150CCF8")]
		public BBParameter[] GetDefinedParameters()
		{
			return null;
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x150CE6C", Offset = "0x150CE6C", VA = "0x150CE6C")]
		public void PromoteDefinedParametersToVariables(IBlackboard bb)
		{
		}

		[Token(Token = "0x600092C")]
		public T AddNode<T>() where T : Node
		{
			return null;
		}

		[Token(Token = "0x600092D")]
		public T AddNode<T>(Vector2 pos) where T : Node
		{
			return null;
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x150CEEC", Offset = "0x150CEEC", VA = "0x150CEEC")]
		public Node AddNode(Type nodeType)
		{
			return null;
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x150CF04", Offset = "0x150CF04", VA = "0x150CF04")]
		public Node AddNode(Type nodeType, Vector2 pos)
		{
			return null;
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x150D444", Offset = "0x150D444", VA = "0x150D444")]
		public void RemoveNode(Node node, bool recordUndo = true, bool force = false)
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x150D964", Offset = "0x150D964", VA = "0x150D964")]
		public Connection ConnectNodes(Node sourceNode, Node targetNode, int sourceIndex = -1, int targetIndex = -1)
		{
			return null;
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x150D810", Offset = "0x150D810", VA = "0x150D810")]
		public void RemoveConnection(Connection connection, bool recordUndo = true)
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x1509244", Offset = "0x1509244", VA = "0x1509244", Slot = "10")]
		public void RecordUndo(string name)
		{
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x150DC60", Offset = "0x150DC60", VA = "0x150DC60")]
		public void ClearGraph()
		{
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x150DD2C", Offset = "0x150DD2C", VA = "0x150DD2C")]
		protected Graph()
		{
		}
	}
	[Token(Token = "0x2000264")]
	public abstract class GraphOwner : MonoBehaviour
	{
		[Token(Token = "0x2000265")]
		public enum EnableAction
		{
			[Token(Token = "0x4000520")]
			EnableBehaviour,
			[Token(Token = "0x4000521")]
			DoNothing
		}

		[Token(Token = "0x2000266")]
		public enum DisableAction
		{
			[Token(Token = "0x4000523")]
			DisableBehaviour,
			[Token(Token = "0x4000524")]
			PauseBehaviour,
			[Token(Token = "0x4000525")]
			DoNothing
		}

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string boundGraphSerialization;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<UnityEngine.Object> boundGraphObjectReferences;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public EnableAction enableAction;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public DisableAction disableAction;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<GraphOwner> onOwnerBehaviourStateChange;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<Graph, Graph> instances;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool initialized;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool startCalled;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool isQuiting;

		[Token(Token = "0x170000D9")]
		public abstract Graph graph
		{
			[Token(Token = "0x6000944")]
			get;
			[Token(Token = "0x6000945")]
			set;
		}

		[Token(Token = "0x170000DA")]
		public abstract IBlackboard blackboard
		{
			[Token(Token = "0x6000946")]
			get;
			[Token(Token = "0x6000947")]
			set;
		}

		[Token(Token = "0x170000DB")]
		public abstract Type graphType
		{
			[Token(Token = "0x6000948")]
			get;
		}

		[Token(Token = "0x170000DC")]
		public bool isRunning
		{
			[Token(Token = "0x6000949")]
			[Address(RVA = "0x150DE90", Offset = "0x150DE90", VA = "0x150DE90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DD")]
		public bool isPaused
		{
			[Token(Token = "0x600094A")]
			[Address(RVA = "0x150DF44", Offset = "0x150DF44", VA = "0x150DF44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DE")]
		public float elapsedTime
		{
			[Token(Token = "0x600094B")]
			[Address(RVA = "0x150DFF8", Offset = "0x150DFF8", VA = "0x150DFF8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x150E0CC", Offset = "0x150E0CC", VA = "0x150E0CC")]
		protected Graph GetInstance(Graph originalGraph)
		{
			return null;
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x150E240", Offset = "0x150E240", VA = "0x150E240")]
		public void StartBehaviour()
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x150E3A8", Offset = "0x150E3A8", VA = "0x150E3A8")]
		public void StartBehaviour(Action<bool> callback)
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x150E24C", Offset = "0x150E24C", VA = "0x150E24C")]
		public void StartBehaviour(bool autoUpdate, Action<bool> callback)
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x150E3B4", Offset = "0x150E3B4", VA = "0x150E3B4")]
		public void PauseBehaviour()
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x150E4A4", Offset = "0x150E4A4", VA = "0x150E4A4")]
		public void StopBehaviour(bool success = true)
		{
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x150E5A8", Offset = "0x150E5A8", VA = "0x150E5A8")]
		public void UpdateBehaviour()
		{
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x150E668", Offset = "0x150E668", VA = "0x150E668")]
		public void RestartBehaviour()
		{
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x150E698", Offset = "0x150E698", VA = "0x150E698")]
		public void SendEvent(string eventName)
		{
		}

		[Token(Token = "0x6000955")]
		public void SendEvent<T>(string eventName, T eventValue)
		{
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x150E70C", Offset = "0x150E70C", VA = "0x150E70C")]
		public void SendEvent(EventData eventData, object sender)
		{
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x150E7D4", Offset = "0x150E7D4", VA = "0x150E7D4")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x150EA5C", Offset = "0x150EA5C", VA = "0x150EA5C")]
		protected void Awake()
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x150EA60", Offset = "0x150EA60", VA = "0x150EA60")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x150EA80", Offset = "0x150EA80", VA = "0x150EA80")]
		protected void Start()
		{
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x150EAA0", Offset = "0x150EAA0", VA = "0x150EAA0")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x150EB24", Offset = "0x150EB24", VA = "0x150EB24")]
		protected void OnDestroy()
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x150EE94", Offset = "0x150EE94", VA = "0x150EE94")]
		protected void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x150EEE4", Offset = "0x150EEE4", VA = "0x150EEE4")]
		protected GraphOwner()
		{
		}
	}
	[Token(Token = "0x2000267")]
	public abstract class GraphOwner<T> : GraphOwner where T : Graph
	{
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private T _graph;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private UnityEngine.Object _blackboard;

		[Token(Token = "0x170000DF")]
		public sealed override Graph graph
		{
			[Token(Token = "0x600095F")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000960")]
			set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public T behaviour
		{
			[Token(Token = "0x6000961")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000962")]
			set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public sealed override IBlackboard blackboard
		{
			[Token(Token = "0x6000963")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000964")]
			set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public sealed override Type graphType
		{
			[Token(Token = "0x6000965")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000966")]
		public void StartBehaviour(T newGraph)
		{
		}

		[Token(Token = "0x6000967")]
		public void StartBehaviour(T newGraph, Action<bool> callback)
		{
		}

		[Token(Token = "0x6000968")]
		public void StartBehaviour(T newGraph, bool autoUpdate, Action<bool> callback)
		{
		}

		[Token(Token = "0x6000969")]
		public void SwitchBehaviour(T newGraph)
		{
		}

		[Token(Token = "0x600096A")]
		public void SwitchBehaviour(T newGraph, Action<bool> callback)
		{
		}

		[Token(Token = "0x600096B")]
		public void SwitchBehaviour(T newGraph, bool autoUpdate, Action<bool> callback)
		{
		}

		[Token(Token = "0x600096C")]
		protected GraphOwner()
		{
		}
	}
	[Token(Token = "0x2000268")]
	public interface IUpdatable
	{
		[Token(Token = "0x600096D")]
		void Update();
	}
	[Token(Token = "0x2000269")]
	public interface IInvokable
	{
		[Token(Token = "0x600096E")]
		string GetInvocationID();

		[Token(Token = "0x600096F")]
		object Invoke(params object[] args);

		[Token(Token = "0x6000970")]
		void InvokeAsync(Action<object> callback, params object[] args);
	}
	[Token(Token = "0x200026A")]
	public interface IGraphAssignable
	{
		[Token(Token = "0x170000E3")]
		Graph nestedGraph
		{
			[Token(Token = "0x6000971")]
			get;
			[Token(Token = "0x6000972")]
			set;
		}

		[Token(Token = "0x6000973")]
		Graph[] GetInstances();
	}
	[Token(Token = "0x200026B")]
	public interface ITaskAssignable
	{
		[Token(Token = "0x170000E4")]
		Task task
		{
			[Token(Token = "0x6000974")]
			get;
			[Token(Token = "0x6000975")]
			set;
		}
	}
	[Token(Token = "0x200026C")]
	public interface ITaskAssignable<T> : ITaskAssignable where T : Task
	{
	}
	[Token(Token = "0x200026D")]
	public interface ISubTasksContainer
	{
		[Token(Token = "0x6000976")]
		Task[] GetSubTasks();
	}
	[Token(Token = "0x200026E")]
	public interface ISubParametersContainer
	{
		[Token(Token = "0x6000977")]
		BBParameter[] GetSubParameters();
	}
	[Token(Token = "0x200026F")]
	public interface IGraphElement
	{
		[Token(Token = "0x170000E5")]
		Graph graph
		{
			[Token(Token = "0x6000978")]
			get;
		}
	}
	[Token(Token = "0x2000270")]
	public interface IReflectedWrapper
	{
		[Token(Token = "0x6000979")]
		MemberInfo GetMemberInfo();
	}
	[Serializable]
	[Token(Token = "0x2000271")]
	[SpoofAOT]
	public abstract class Node : IGraphElement
	{
		[Token(Token = "0x2000272")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E89C0", Offset = "0x9E89C0")]
		private sealed class <YieldBreak>d__85 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action resume;

			[Token(Token = "0x170000FE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009CF")]
				[Address(RVA = "0x26A4658", Offset = "0x26A4658", VA = "0x26A4658", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009D1")]
				[Address(RVA = "0x26A46A0", Offset = "0x26A46A0", VA = "0x26A46A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x26A4570", Offset = "0x26A4570", VA = "0x26A4570")]
			[DebuggerHidden]
			public <YieldBreak>d__85(int <>1__state)
			{
			}

			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x26A459C", Offset = "0x26A459C", VA = "0x26A459C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x26A45A0", Offset = "0x26A45A0", VA = "0x26A45A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x26A4660", Offset = "0x26A4660", VA = "0x26A4660", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000273")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E89D0", Offset = "0x9E89D0")]
		private sealed class <>c__DisplayClass100_0
		{
			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Node b;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Node a;

			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x26A44C8", Offset = "0x26A44C8", VA = "0x26A44C8")]
			public <>c__DisplayClass100_0()
			{
			}

			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x26A44D0", Offset = "0x26A44D0", VA = "0x26A44D0")]
			internal bool <AreNodesConnected>b__0(Connection c)
			{
				return default(bool);
			}

			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x26A44F4", Offset = "0x26A44F4", VA = "0x26A44F4")]
			internal bool <AreNodesConnected>b__1(Connection c)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000274")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E89E0", Offset = "0x9E89E0")]
		private sealed class <>c
		{
			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Connection, Node> <>9__103_0;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Connection, Node> <>9__104_0;

			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x26A4490", Offset = "0x26A4490", VA = "0x26A4490")]
			public <>c()
			{
			}

			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x26A4498", Offset = "0x26A4498", VA = "0x26A4498")]
			internal Node <GetParentNodes>b__103_0(Connection c)
			{
				return null;
			}

			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x26A44B0", Offset = "0x26A44B0", VA = "0x26A44B0")]
			internal Node <GetChildNodes>b__104_0(Connection c)
			{
				return null;
			}
		}

		[Token(Token = "0x2000275")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E89F0", Offset = "0x9E89F0")]
		private sealed class <>c__DisplayClass105_0
		{
			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Node parentNode;

			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x26A4518", Offset = "0x26A4518", VA = "0x26A4518")]
			public <>c__DisplayClass105_0()
			{
			}

			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x26A4520", Offset = "0x26A4520", VA = "0x26A4520")]
			internal bool <IsChildOf>b__0(Connection c)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000276")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8A00", Offset = "0x9E8A00")]
		private sealed class <>c__DisplayClass106_0
		{
			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Node childNode;

			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x26A4544", Offset = "0x26A4544", VA = "0x26A4544")]
			public <>c__DisplayClass106_0()
			{
			}

			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x26A454C", Offset = "0x26A454C", VA = "0x26A454C")]
			internal bool <IsParentOf>b__0(Connection c)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector2 _position;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _UID;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _name;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _tag;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _comment;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _isBreakpoint;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Graph _graph;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Connection> _inConnections;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Connection> _outConnections;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _ID;

		[NonSerialized]
		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Status _status;

		[NonSerialized]
		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string _nameCache;

		[NonSerialized]
		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string _descriptionCache;

		[NonSerialized]
		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int _priorityCache;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA0D4", Offset = "0x9EA0D4")]
		private bool <isChecked>k__BackingField;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA0E4", Offset = "0x9EA0E4")]
		private bool <breakPointReached>k__BackingField;

		[Token(Token = "0x170000E6")]
		public Graph graph
		{
			[Token(Token = "0x600097A")]
			[Address(RVA = "0x151A6EC", Offset = "0x151A6EC", VA = "0x151A6EC", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600097B")]
			[Address(RVA = "0x151A6F4", Offset = "0x151A6F4", VA = "0x151A6F4")]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public int ID
		{
			[Token(Token = "0x600097C")]
			[Address(RVA = "0x151A6FC", Offset = "0x151A6FC", VA = "0x151A6FC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600097D")]
			[Address(RVA = "0x151A704", Offset = "0x151A704", VA = "0x151A704")]
			set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public List<Connection> inConnections
		{
			[Token(Token = "0x600097E")]
			[Address(RVA = "0x151A70C", Offset = "0x151A70C", VA = "0x151A70C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600097F")]
			[Address(RVA = "0x151A714", Offset = "0x151A714", VA = "0x151A714")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public List<Connection> outConnections
		{
			[Token(Token = "0x6000980")]
			[Address(RVA = "0x151A71C", Offset = "0x151A71C", VA = "0x151A71C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000981")]
			[Address(RVA = "0x151A724", Offset = "0x151A724", VA = "0x151A724")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public Vector2 position
		{
			[Token(Token = "0x6000982")]
			[Address(RVA = "0x151A72C", Offset = "0x151A72C", VA = "0x151A72C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000983")]
			[Address(RVA = "0x151A734", Offset = "0x151A734", VA = "0x151A734")]
			set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public string UID
		{
			[Token(Token = "0x6000984")]
			[Address(RVA = "0x15064A0", Offset = "0x15064A0", VA = "0x15064A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EC")]
		private string customName
		{
			[Token(Token = "0x6000985")]
			[Address(RVA = "0x151A73C", Offset = "0x151A73C", VA = "0x151A73C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000986")]
			[Address(RVA = "0x151A744", Offset = "0x151A744", VA = "0x151A744")]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public string tag
		{
			[Token(Token = "0x6000987")]
			[Address(RVA = "0x151A74C", Offset = "0x151A74C", VA = "0x151A74C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000988")]
			[Address(RVA = "0x151A754", Offset = "0x151A754", VA = "0x151A754")]
			set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public string comments
		{
			[Token(Token = "0x6000989")]
			[Address(RVA = "0x151A75C", Offset = "0x151A75C", VA = "0x151A75C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600098A")]
			[Address(RVA = "0x151A764", Offset = "0x151A764", VA = "0x151A764")]
			set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public bool isBreakpoint
		{
			[Token(Token = "0x600098B")]
			[Address(RVA = "0x151A76C", Offset = "0x151A76C", VA = "0x151A76C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600098C")]
			[Address(RVA = "0x151A774", Offset = "0x151A774", VA = "0x151A774")]
			set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public virtual string name
		{
			[Token(Token = "0x600098D")]
			[Address(RVA = "0x15051AC", Offset = "0x15051AC", VA = "0x15051AC", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600098E")]
			[Address(RVA = "0x151A780", Offset = "0x151A780", VA = "0x151A780", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public virtual string description
		{
			[Token(Token = "0x600098F")]
			[Address(RVA = "0x15143AC", Offset = "0x15143AC", VA = "0x15143AC", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F2")]
		public virtual int priority
		{
			[Token(Token = "0x6000990")]
			[Address(RVA = "0x151A788", Offset = "0x151A788", VA = "0x151A788", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000F3")]
		public abstract int maxInConnections
		{
			[Token(Token = "0x6000991")]
			get;
		}

		[Token(Token = "0x170000F4")]
		public abstract int maxOutConnections
		{
			[Token(Token = "0x6000992")]
			get;
		}

		[Token(Token = "0x170000F5")]
		public abstract Type outConnectionType
		{
			[Token(Token = "0x6000993")]
			get;
		}

		[Token(Token = "0x170000F6")]
		public abstract bool allowAsPrime
		{
			[Token(Token = "0x6000994")]
			get;
		}

		[Token(Token = "0x170000F7")]
		public abstract Alignment2x2 commentsAlignment
		{
			[Token(Token = "0x6000995")]
			get;
		}

		[Token(Token = "0x170000F8")]
		public abstract Alignment2x2 iconAlignment
		{
			[Token(Token = "0x6000996")]
			get;
		}

		[Token(Token = "0x170000F9")]
		public Status status
		{
			[Token(Token = "0x6000997")]
			[Address(RVA = "0x151A838", Offset = "0x151A838", VA = "0x151A838")]
			get
			{
				return default(Status);
			}
			[Token(Token = "0x6000998")]
			[Address(RVA = "0x151A840", Offset = "0x151A840", VA = "0x151A840")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public Component graphAgent
		{
			[Token(Token = "0x6000999")]
			[Address(RVA = "0x151A848", Offset = "0x151A848", VA = "0x151A848")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FB")]
		public IBlackboard graphBlackboard
		{
			[Token(Token = "0x600099A")]
			[Address(RVA = "0x151A8D4", Offset = "0x151A8D4", VA = "0x151A8D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FC")]
		private bool isChecked
		{
			[Token(Token = "0x600099B")]
			[Address(RVA = "0x151A984", Offset = "0x151A984", VA = "0x151A984")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB784", Offset = "0x9EB784")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600099C")]
			[Address(RVA = "0x151A98C", Offset = "0x151A98C", VA = "0x151A98C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB794", Offset = "0x9EB794")]
			set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		private bool breakPointReached
		{
			[Token(Token = "0x600099D")]
			[Address(RVA = "0x151A998", Offset = "0x151A998", VA = "0x151A998")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB7A4", Offset = "0x9EB7A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600099E")]
			[Address(RVA = "0x151A9A0", Offset = "0x151A9A0", VA = "0x151A9A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB7B4", Offset = "0x9EB7B4")]
			set
			{
			}
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x1517694", Offset = "0x1517694", VA = "0x1517694")]
		public Node()
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x150D1F0", Offset = "0x150D1F0", VA = "0x150D1F0")]
		public static Node Create(Graph targetGraph, Type nodeType, Vector2 pos)
		{
			return null;
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x1509E34", Offset = "0x1509E34", VA = "0x1509E34")]
		public Node Duplicate(Graph targetGraph)
		{
			return null;
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x151A9AC", Offset = "0x151A9AC", VA = "0x151A9AC", Slot = "15")]
		public virtual void OnCreate(Graph assignedGraph)
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x151A9B0", Offset = "0x151A9B0", VA = "0x151A9B0", Slot = "16")]
		public virtual void OnValidate(Graph assignedGraph)
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x151A9B4", Offset = "0x151A9B4", VA = "0x151A9B4", Slot = "17")]
		public virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x151A9B8", Offset = "0x151A9B8", VA = "0x151A9B8")]
		public Status Execute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x150915C", Offset = "0x150915C", VA = "0x150915C")]
		public void Reset(bool recursively = true)
		{
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x151A9E8", Offset = "0x151A9E8", VA = "0x151A9E8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9EB7C4", Offset = "0x9EB7C4")]
		private IEnumerator YieldBreak(Action resume)
		{
			return null;
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x151AA60", Offset = "0x151AA60", VA = "0x151AA60")]
		public Status Error(object msg)
		{
			return default(Status);
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x151ABB4", Offset = "0x151ABB4", VA = "0x151ABB4")]
		public Status Fail(string msg)
		{
			return default(Status);
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x151AC48", Offset = "0x151AC48", VA = "0x151AC48")]
		public void Warn(string msg)
		{
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x151224C", Offset = "0x151224C", VA = "0x151224C")]
		public void SetStatus(Status status)
		{
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x151ACD0", Offset = "0x151ACD0", VA = "0x151ACD0")]
		protected void SendEvent(EventData eventData)
		{
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x151ACEC", Offset = "0x151ACEC", VA = "0x151ACEC")]
		public void RegisterEvents(params string[] eventNames)
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x151AD1C", Offset = "0x151AD1C", VA = "0x151AD1C")]
		public void RegisterEvents(Component targetAgent, params string[] eventNames)
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x151AEA8", Offset = "0x151AEA8", VA = "0x151AEA8")]
		public void UnRegisterEvents(params string[] eventNames)
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x151AED8", Offset = "0x151AED8", VA = "0x151AED8")]
		public void UnRegisterEvents(Component targetAgent, params string[] eventNames)
		{
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x151AFD4", Offset = "0x151AFD4", VA = "0x151AFD4")]
		public void UnregisterAllEvents()
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x151AFFC", Offset = "0x151AFFC", VA = "0x151AFFC")]
		public void UnregisterAllEvents(Component targetAgent)
		{
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x150DA08", Offset = "0x150DA08", VA = "0x150DA08")]
		public static bool IsNewConnectionAllowed(Node sourceNode, Node targetNode, [Optional] Connection refConnection)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x151B0F0", Offset = "0x151B0F0", VA = "0x151B0F0", Slot = "18")]
		protected virtual bool CanConnectToTarget(Node targetNode)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x151B0F8", Offset = "0x151B0F8", VA = "0x151B0F8", Slot = "19")]
		protected virtual bool CanConnectFromSource(Node sourceNode)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x151B100", Offset = "0x151B100", VA = "0x151B100")]
		public static bool AreNodesConnected(Node a, Node b)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x151B2A4", Offset = "0x151B2A4", VA = "0x151B2A4")]
		protected Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x151B2D4", Offset = "0x151B2D4", VA = "0x151B2D4")]
		protected void StopCoroutine(Coroutine routine)
		{
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x151B304", Offset = "0x151B304", VA = "0x151B304")]
		public Node[] GetParentNodes()
		{
			return null;
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x151B488", Offset = "0x151B488", VA = "0x151B488")]
		public Node[] GetChildNodes()
		{
			return null;
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x151B60C", Offset = "0x151B60C", VA = "0x151B60C")]
		public bool IsChildOf(Node parentNode)
		{
			return default(bool);
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x151B704", Offset = "0x151B704", VA = "0x151B704")]
		public bool IsParentOf(Node childNode)
		{
			return default(bool);
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x151B7FC", Offset = "0x151B7FC", VA = "0x151B7FC", Slot = "20")]
		protected virtual Status OnExecute(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x151B804", Offset = "0x151B804", VA = "0x151B804", Slot = "21")]
		protected virtual void OnReset()
		{
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x151B808", Offset = "0x151B808", VA = "0x151B808", Slot = "22")]
		public virtual void OnParentConnected(int connectionIndex)
		{
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x151B80C", Offset = "0x151B80C", VA = "0x151B80C", Slot = "23")]
		public virtual void OnParentDisconnected(int connectionIndex)
		{
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x151B810", Offset = "0x151B810", VA = "0x151B810", Slot = "24")]
		public virtual void OnChildConnected(int connectionIndex)
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x151B814", Offset = "0x151B814", VA = "0x151B814", Slot = "25")]
		public virtual void OnChildDisconnected(int connectionIndex)
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x151B818", Offset = "0x151B818", VA = "0x151B818", Slot = "26")]
		public virtual void OnGraphStarted()
		{
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x151B81C", Offset = "0x151B81C", VA = "0x151B81C", Slot = "27")]
		public virtual void OnGraphStoped()
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x151B820", Offset = "0x151B820", VA = "0x151B820", Slot = "28")]
		public virtual void OnGraphPaused()
		{
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x151B824", Offset = "0x151B824", VA = "0x151B824", Slot = "29")]
		public virtual void OnGraphUnpaused()
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x151B828", Offset = "0x151B828", VA = "0x151B828", Slot = "30")]
		public virtual bool CheckIntegrity(string nodePath, out string[] messages)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x151B84C", Offset = "0x151B84C", VA = "0x151B84C", Slot = "31")]
		public virtual void IntegrityCheck()
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x151B850", Offset = "0x151B850", VA = "0x151B850", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x151BA28", Offset = "0x151BA28", VA = "0x151BA28", Slot = "32")]
		public virtual void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x151BBB0", Offset = "0x151BBB0", VA = "0x151BBB0", Slot = "33")]
		public virtual void OnDrawGizmosSelected()
		{
		}
	}
	[Token(Token = "0x2000277")]
	public enum Status
	{
		[Token(Token = "0x4000543")]
		Failure,
		[Token(Token = "0x4000544")]
		Success,
		[Token(Token = "0x4000545")]
		Running,
		[Token(Token = "0x4000546")]
		Resting,
		[Token(Token = "0x4000547")]
		Error,
		[Token(Token = "0x4000548")]
		Optional
	}
	[Token(Token = "0x2000278")]
	[DoNotList]
	public class ActionList : ActionTask, ISubTasksContainer
	{
		[Token(Token = "0x2000279")]
		public enum ActionsExecutionMode
		{
			[Token(Token = "0x400054F")]
			ActionsRunInSequence,
			[Token(Token = "0x4000550")]
			ActionsRunInParallel
		}

		[Serializable]
		[Token(Token = "0x200027A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8A20", Offset = "0x9E8A20")]
		private sealed class <>c
		{
			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<ActionTask, bool> <>9__10_0;

			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x1467B5C", Offset = "0x1467B5C", VA = "0x1467B5C")]
			public <>c()
			{
			}

			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x1467B64", Offset = "0x1467B64", VA = "0x1467B64")]
			internal bool <OnInit>b__10_0(ActionTask a)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public ActionsExecutionMode executionMode;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<ActionTask> actions;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<ActionTask> initialActiveActions;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int currentActionIndex;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly List<int> finishedIndeces;

		[Token(Token = "0x17000100")]
		protected override string info
		{
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x1356654", Offset = "0x1356654", VA = "0x1356654", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x13568CC", Offset = "0x13568CC", VA = "0x13568CC", Slot = "18")]
		private Task[] NodeCanvas.Framework.ISubTasksContainer.GetSubTasks()
		{
			return null;
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x1356920", Offset = "0x1356920", VA = "0x1356920", Slot = "5")]
		public override Task Duplicate(ITaskSystem newOwnerSystem)
		{
			return null;
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x1356CD0", Offset = "0x1356CD0", VA = "0x1356CD0", Slot = "10")]
		protected override string OnInit()
		{
			return null;
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x1356E3C", Offset = "0x1356E3C", VA = "0x1356E3C", Slot = "13")]
		protected override void OnExecute()
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x1356E98", Offset = "0x1356E98", VA = "0x1356E98", Slot = "14")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x1357278", Offset = "0x1357278", VA = "0x1357278", Slot = "16")]
		protected override void OnStop()
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x13573FC", Offset = "0x13573FC", VA = "0x13573FC", Slot = "17")]
		protected override void OnPause()
		{
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x135751C", Offset = "0x135751C", VA = "0x135751C", Slot = "11")]
		public override void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x13575F4", Offset = "0x13575F4", VA = "0x13575F4", Slot = "12")]
		public override void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x1356B34", Offset = "0x1356B34", VA = "0x1356B34")]
		public void AddAction(ActionTask action)
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x13576CC", Offset = "0x13576CC", VA = "0x13576CC")]
		public ActionList()
		{
		}
	}
	[Token(Token = "0x200027B")]
	public abstract class ActionTask<T> : ActionTask where T : class
	{
		[Token(Token = "0x17000101")]
		public sealed override Type agentType
		{
			[Token(Token = "0x60009EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000102")]
		public new T agent
		{
			[Token(Token = "0x60009ED")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009EE")]
		protected ActionTask()
		{
		}
	}
	[Token(Token = "0x200027C")]
	public abstract class ActionTask : Task
	{
		[Token(Token = "0x200027D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8A30", Offset = "0x9E8A30")]
		private sealed class <ActionUpdater>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ActionTask <>4__this;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Component agent;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public IBlackboard blackboard;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<bool> callback;

			[Token(Token = "0x17000106")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A03")]
				[Address(RVA = "0x1467C68", Offset = "0x1467C68", VA = "0x1467C68", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000107")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A05")]
				[Address(RVA = "0x1467CB0", Offset = "0x1467CB0", VA = "0x1467CB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x1467B80", Offset = "0x1467B80", VA = "0x1467B80")]
			[DebuggerHidden]
			public <ActionUpdater>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x1467BAC", Offset = "0x1467BAC", VA = "0x1467BAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x1467BB0", Offset = "0x1467BB0", VA = "0x1467BB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x1467C70", Offset = "0x1467C70", VA = "0x1467C70", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[NonSerialized]
		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Status status;

		[NonSerialized]
		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float startedTime;

		[NonSerialized]
		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float pausedTime;

		[NonSerialized]
		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool latch;

		[NonSerialized]
		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool _isPaused;

		[Token(Token = "0x17000103")]
		public float elapsedTime
		{
			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x13577B4", Offset = "0x13577B4", VA = "0x13577B4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000104")]
		public bool isRunning
		{
			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x13568BC", Offset = "0x13568BC", VA = "0x13568BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000105")]
		public bool isPaused
		{
			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x1357800", Offset = "0x1357800", VA = "0x1357800")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x1357808", Offset = "0x1357808", VA = "0x1357808")]
			private set
			{
			}
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x1357814", Offset = "0x1357814", VA = "0x1357814")]
		public void ExecuteAction(Component agent, IBlackboard blackboard, Action<bool> callback)
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x13578A0", Offset = "0x13578A0", VA = "0x13578A0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9EB874", Offset = "0x9EB874")]
		private IEnumerator ActionUpdater(Component agent, IBlackboard blackboard, Action<bool> callback)
		{
			return null;
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x1357110", Offset = "0x1357110", VA = "0x1357110")]
		public Status ExecuteAction(Component agent, IBlackboard blackboard)
		{
			return default(Status);
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x1357108", Offset = "0x1357108", VA = "0x1357108")]
		public void EndAction()
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x1357208", Offset = "0x1357208", VA = "0x1357208")]
		public void EndAction(bool success)
		{
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x135734C", Offset = "0x135734C", VA = "0x135734C")]
		public void EndAction(bool? success)
		{
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x13574CC", Offset = "0x13574CC", VA = "0x13574CC")]
		public void PauseAction()
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x1357964", Offset = "0x1357964", VA = "0x1357964", Slot = "13")]
		protected virtual void OnExecute()
		{
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x1357968", Offset = "0x1357968", VA = "0x1357968", Slot = "14")]
		protected virtual void OnUpdate()
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x135796C", Offset = "0x135796C", VA = "0x135796C", Slot = "15")]
		protected virtual void OnStop(bool interrupted)
		{
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x135797C", Offset = "0x135797C", VA = "0x135797C", Slot = "16")]
		protected virtual void OnStop()
		{
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x1357980", Offset = "0x1357980", VA = "0x1357980", Slot = "17")]
		protected virtual void OnPause()
		{
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x13577A4", Offset = "0x13577A4", VA = "0x13577A4")]
		protected ActionTask()
		{
		}
	}
	[Token(Token = "0x200027E")]
	[DoNotList]
	public class ConditionList : ConditionTask, ISubTasksContainer
	{
		[Token(Token = "0x200027F")]
		public enum ConditionsCheckMode
		{
			[Token(Token = "0x4000562")]
			AllTrueRequired,
			[Token(Token = "0x4000563")]
			AnyTrueSuffice
		}

		[Serializable]
		[Token(Token = "0x2000280")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8A50", Offset = "0x9E8A50")]
		private sealed class <>c
		{
			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<ConditionTask, bool> <>9__10_0;

			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x1467FBC", Offset = "0x1467FBC", VA = "0x1467FBC")]
			public <>c()
			{
			}

			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x1467FC4", Offset = "0x1467FC4", VA = "0x1467FC4")]
			internal bool <OnInit>b__10_0(ConditionTask c)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public ConditionsCheckMode checkMode;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<ConditionTask> conditions;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<ConditionTask> initialActiveConditions;

		[Token(Token = "0x17000108")]
		private bool allTrueRequired
		{
			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x13638C8", Offset = "0x13638C8", VA = "0x13638C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000109")]
		protected override string info
		{
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x13638D8", Offset = "0x13638D8", VA = "0x13638D8", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x1363B84", Offset = "0x1363B84", VA = "0x1363B84", Slot = "16")]
		private Task[] NodeCanvas.Framework.ISubTasksContainer.GetSubTasks()
		{
			return null;
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x1363BD8", Offset = "0x1363BD8", VA = "0x1363BD8", Slot = "5")]
		public override Task Duplicate(ITaskSystem newOwnerSystem)
		{
			return null;
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x1363F88", Offset = "0x1363F88", VA = "0x1363F88", Slot = "10")]
		protected override string OnInit()
		{
			return null;
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x13640F4", Offset = "0x13640F4", VA = "0x13640F4", Slot = "13")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x1364208", Offset = "0x1364208", VA = "0x1364208", Slot = "14")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x13642FC", Offset = "0x13642FC", VA = "0x13642FC", Slot = "15")]
		protected override bool OnCheck()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x13644CC", Offset = "0x13644CC", VA = "0x13644CC", Slot = "11")]
		public override void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x13645A4", Offset = "0x13645A4", VA = "0x13645A4", Slot = "12")]
		public override void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x1363DEC", Offset = "0x1363DEC", VA = "0x1363DEC")]
		public void AddCondition(ConditionTask condition)
		{
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x136467C", Offset = "0x136467C", VA = "0x136467C")]
		public ConditionList()
		{
		}
	}
	[Token(Token = "0x2000281")]
	public abstract class ConditionTask<T> : ConditionTask where T : class
	{
		[Token(Token = "0x1700010A")]
		public sealed override Type agentType
		{
			[Token(Token = "0x6000A15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010B")]
		public new T agent
		{
			[Token(Token = "0x6000A16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A17")]
		protected ConditionTask()
		{
		}
	}
	[Token(Token = "0x2000282")]
	public abstract class ConditionTask : Task
	{
		[Token(Token = "0x2000283")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8A60", Offset = "0x9E8A60")]
		private sealed class <Flip>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ConditionTask <>4__this;

			[Token(Token = "0x1700010D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A26")]
				[Address(RVA = "0x14680A8", Offset = "0x14680A8", VA = "0x14680A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A28")]
				[Address(RVA = "0x14680F0", Offset = "0x14680F0", VA = "0x14680F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x1467FE0", Offset = "0x1467FE0", VA = "0x1467FE0")]
			[DebuggerHidden]
			public <Flip>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x146800C", Offset = "0x146800C", VA = "0x146800C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x1468010", Offset = "0x1468010", VA = "0x1468010", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A27")]
			[Address(RVA = "0x14680B0", Offset = "0x14680B0", VA = "0x14680B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _invert;

		[NonSerialized]
		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int yieldReturn;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int yields;

		[Token(Token = "0x1700010C")]
		public bool invert
		{
			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x1364718", Offset = "0x1364718", VA = "0x1364718")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x1364720", Offset = "0x1364720", VA = "0x1364720")]
			set
			{
			}
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x13641C4", Offset = "0x13641C4", VA = "0x13641C4")]
		public void Enable(Component agent, IBlackboard bb)
		{
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x13642C4", Offset = "0x13642C4", VA = "0x13642C4")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x1364420", Offset = "0x1364420", VA = "0x1364420")]
		public bool CheckCondition(Component agent, IBlackboard blackboard)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x136472C", Offset = "0x136472C", VA = "0x136472C")]
		protected void YieldReturn(bool value)
		{
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x1364800", Offset = "0x1364800", VA = "0x1364800", Slot = "13")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x1364804", Offset = "0x1364804", VA = "0x1364804", Slot = "14")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x1364808", Offset = "0x1364808", VA = "0x1364808", Slot = "15")]
		protected virtual bool OnCheck()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x1364788", Offset = "0x1364788", VA = "0x1364788")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9EB924", Offset = "0x9EB924")]
		private IEnumerator Flip()
		{
			return null;
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x1364708", Offset = "0x1364708", VA = "0x1364708")]
		protected ConditionTask()
		{
		}
	}
	[Token(Token = "0x2000284")]
	public interface ITaskSystem
	{
		[Token(Token = "0x1700010F")]
		Component agent
		{
			[Token(Token = "0x6000A29")]
			get;
		}

		[Token(Token = "0x17000110")]
		IBlackboard blackboard
		{
			[Token(Token = "0x6000A2A")]
			get;
		}

		[Token(Token = "0x17000111")]
		float elapsedTime
		{
			[Token(Token = "0x6000A2B")]
			get;
		}

		[Token(Token = "0x17000112")]
		UnityEngine.Object contextObject
		{
			[Token(Token = "0x6000A2C")]
			get;
		}

		[Token(Token = "0x6000A2D")]
		void SendTaskOwnerDefaults();

		[Token(Token = "0x6000A2E")]
		void SendEvent(EventData eventData, object sender);

		[Token(Token = "0x6000A2F")]
		void RecordUndo(string name);
	}
	[Serializable]
	[Token(Token = "0x2000285")]
	[SpoofAOT]
	public abstract class Task : ISubParametersContainer
	{
		[Token(Token = "0x2000286")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E8A80", Offset = "0x9E8A80")]
		protected class EventReceiverAttribute : Attribute
		{
			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly string[] eventMessages;

			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x26A71E8", Offset = "0x26A71E8", VA = "0x26A71E8")]
			public EventReceiverAttribute(params string[] args)
			{
			}
		}

		[Token(Token = "0x2000287")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E8A94", Offset = "0x9E8A94")]
		protected class GetFromAgentAttribute : Attribute
		{
			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x26A721C", Offset = "0x26A721C", VA = "0x26A721C")]
			public GetFromAgentAttribute()
			{
			}
		}

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _isDisabled;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TaskAgentParameter overrideAgent;

		[NonSerialized]
		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IBlackboard _blackboard;

		[NonSerialized]
		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ITaskSystem _ownerSystem;

		[NonSerialized]
		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Component current;

		[NonSerialized]
		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string _taskName;

		[NonSerialized]
		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string _taskDescription;

		[NonSerialized]
		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string _obsoleteInfo;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA124", Offset = "0x9EA124")]
		private string <firstWarningMessage>k__BackingField;

		[Token(Token = "0x17000113")]
		public ITaskSystem ownerSystem
		{
			[Token(Token = "0x6000A38")]
			[Address(RVA = "0x1BC4924", Offset = "0x1BC4924", VA = "0x1BC4924")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A39")]
			[Address(RVA = "0x1BC492C", Offset = "0x1BC492C", VA = "0x1BC492C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000114")]
		public Component ownerAgent
		{
			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x1BC4934", Offset = "0x1BC4934", VA = "0x1BC4934")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000115")]
		public IBlackboard ownerBlackboard
		{
			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x1BC49EC", Offset = "0x1BC49EC", VA = "0x1BC49EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000116")]
		protected float ownerElapsedTime
		{
			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x1BC4AA8", Offset = "0x1BC4AA8", VA = "0x1BC4AA8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000117")]
		public bool isActive
		{
			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x1BC4B64", Offset = "0x1BC4B64", VA = "0x1BC4B64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x1BC4B74", Offset = "0x1BC4B74", VA = "0x1BC4B74")]
			set
			{
			}
		}

		[Token(Token = "0x17000118")]
		public string obsolete
		{
			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x1BC4B84", Offset = "0x1BC4B84", VA = "0x1BC4B84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000119")]
		public string name
		{
			[Token(Token = "0x6000A40")]
			[Address(RVA = "0x1BC4C60", Offset = "0x1BC4C60", VA = "0x1BC4C60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011A")]
		public string description
		{
			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x1BC4D9C", Offset = "0x1BC4D9C", VA = "0x1BC4D9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011B")]
		public virtual Type agentType
		{
			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x1BC4E78", Offset = "0x1BC4E78", VA = "0x1BC4E78", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011C")]
		public string summaryInfo
		{
			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x1BC4E80", Offset = "0x1BC4E80", VA = "0x1BC4E80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011D")]
		protected virtual string info
		{
			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x1BC502C", Offset = "0x1BC502C", VA = "0x1BC502C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011E")]
		public string agentInfo
		{
			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x1BC5030", Offset = "0x1BC5030", VA = "0x1BC5030")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011F")]
		public bool agentIsOverride
		{
			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x1BC501C", Offset = "0x1BC501C", VA = "0x1BC501C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x1BC5094", Offset = "0x1BC5094", VA = "0x1BC5094")]
			set
			{
			}
		}

		[Token(Token = "0x17000120")]
		public string overrideAgentParameterName
		{
			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x1BC51A4", Offset = "0x1BC51A4", VA = "0x1BC51A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000121")]
		public Component agent
		{
			[Token(Token = "0x6000A49")]
			[Address(RVA = "0x1BC51BC", Offset = "0x1BC51BC", VA = "0x1BC51BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000122")]
		public IBlackboard blackboard
		{
			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0x1BC55C8", Offset = "0x1BC55C8", VA = "0x1BC55C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x1BC55D0", Offset = "0x1BC55D0", VA = "0x1BC55D0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000123")]
		public string firstWarningMessage
		{
			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0x1BC5630", Offset = "0x1BC5630", VA = "0x1BC5630")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB9D4", Offset = "0x9EB9D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x1BC5638", Offset = "0x1BC5638", VA = "0x1BC5638")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB9E4", Offset = "0x9EB9E4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x1BC43F0", Offset = "0x1BC43F0", VA = "0x1BC43F0", Slot = "4")]
		private BBParameter[] NodeCanvas.Framework.ISubParametersContainer.GetSubParameters()
		{
			return null;
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x1BC44AC", Offset = "0x1BC44AC", VA = "0x1BC44AC")]
		public Task()
		{
		}

		[Token(Token = "0x6000A32")]
		public static T Create<T>(ITaskSystem newOwnerSystem) where T : Task
		{
			return null;
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x1BC44B4", Offset = "0x1BC44B4", VA = "0x1BC44B4")]
		public static Task Create(Type type, ITaskSystem newOwnerSystem)
		{
			return null;
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x1BC4754", Offset = "0x1BC4754", VA = "0x1BC4754", Slot = "5")]
		public virtual Task Duplicate(ITaskSystem newOwnerSystem)
		{
			return null;
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x1BC491C", Offset = "0x1BC491C", VA = "0x1BC491C", Slot = "6")]
		public virtual void OnCreate(ITaskSystem ownerSystem)
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x1BC4920", Offset = "0x1BC4920", VA = "0x1BC4920", Slot = "7")]
		public virtual void OnValidate(ITaskSystem ownerSystem)
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x1BC4694", Offset = "0x1BC4694", VA = "0x1BC4694")]
		public void SetOwnerSystem(ITaskSystem newOwnerSystem)
		{
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x1BC5640", Offset = "0x1BC5640", VA = "0x1BC5640")]
		protected Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x1BC5674", Offset = "0x1BC5674", VA = "0x1BC5674")]
		protected void StopCoroutine(Coroutine routine)
		{
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x1BC56A8", Offset = "0x1BC56A8", VA = "0x1BC56A8")]
		protected void SendEvent(EventData eventData)
		{
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x1BC5778", Offset = "0x1BC5778", VA = "0x1BC5778", Slot = "10")]
		protected virtual string OnInit()
		{
			return null;
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x1BC5780", Offset = "0x1BC5780", VA = "0x1BC5780")]
		protected bool Set(Component newAgent, IBlackboard newBB)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x1BC53D8", Offset = "0x1BC53D8", VA = "0x1BC53D8")]
		private static Component TransformAgent(Component input, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x1BC591C", Offset = "0x1BC591C", VA = "0x1BC591C")]
		private bool Initialize(Component newAgent)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x1BC5F00", Offset = "0x1BC5F00", VA = "0x1BC5F00")]
		private bool InitializeAttributes(Component newAgent)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x1BC5C4C", Offset = "0x1BC5C4C", VA = "0x1BC5C4C")]
		protected bool Error(string error)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x1BC61EC", Offset = "0x1BC61EC", VA = "0x1BC61EC")]
		public void RegisterEvent(string eventName)
		{
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x1BC5DB8", Offset = "0x1BC5DB8", VA = "0x1BC5DB8")]
		public void RegisterEvents(params string[] eventNames)
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x1BC62A4", Offset = "0x1BC62A4", VA = "0x1BC62A4")]
		public void UnRegisterEvent(string eventName)
		{
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x1BC635C", Offset = "0x1BC635C", VA = "0x1BC635C")]
		public void UnRegisterEvents(params string[] eventNames)
		{
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x1BC5B44", Offset = "0x1BC5B44", VA = "0x1BC5B44")]
		public void UnRegisterAllEvents()
		{
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x1BC646C", Offset = "0x1BC646C", VA = "0x1BC646C")]
		public string GetWarning()
		{
			return null;
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x1BC64A0", Offset = "0x1BC64A0", VA = "0x1BC64A0")]
		private string Internal_GetWarning()
		{
			return null;
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x1BC6A58", Offset = "0x1BC6A58", VA = "0x1BC6A58", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x1BC6A5C", Offset = "0x1BC6A5C", VA = "0x1BC6A5C", Slot = "11")]
		public virtual void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x1BC6A60", Offset = "0x1BC6A60", VA = "0x1BC6A60", Slot = "12")]
		public virtual void OnDrawGizmosSelected()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000288")]
	[SpoofAOT]
	public abstract class BBParameter
	{
		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _name;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _targetVariableID;

		[NonSerialized]
		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IBlackboard _bb;

		[NonSerialized]
		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Variable _varRef;

		[Token(Token = "0x17000124")]
		private string targetVariableID
		{
			[Token(Token = "0x6000A67")]
			[Address(RVA = "0x1359A6C", Offset = "0x1359A6C", VA = "0x1359A6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A68")]
			[Address(RVA = "0x1359A74", Offset = "0x1359A74", VA = "0x1359A74")]
			set
			{
			}
		}

		[Token(Token = "0x17000125")]
		public Variable varRef
		{
			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x1359A7C", Offset = "0x1359A7C", VA = "0x1359A7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0x1359A84", Offset = "0x1359A84", VA = "0x1359A84")]
			set
			{
			}
		}

		[Token(Token = "0x17000126")]
		public IBlackboard bb
		{
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x1359AD4", Offset = "0x1359AD4", VA = "0x1359AD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x1359174", Offset = "0x1359174", VA = "0x1359174")]
			set
			{
			}
		}

		[Token(Token = "0x17000127")]
		public string name
		{
			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0x1359D44", Offset = "0x1359D44", VA = "0x1359D44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0x1359D4C", Offset = "0x1359D4C", VA = "0x1359D4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000128")]
		public bool useBlackboard
		{
			[Token(Token = "0x6000A6F")]
			[Address(RVA = "0x1359DCC", Offset = "0x1359DCC", VA = "0x1359DCC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A70")]
			[Address(RVA = "0x1359DDC", Offset = "0x1359DDC", VA = "0x1359DDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000129")]
		public bool isNone
		{
			[Token(Token = "0x6000A71")]
			[Address(RVA = "0x1359E68", Offset = "0x1359E68", VA = "0x1359E68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012A")]
		public bool isDefined
		{
			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x1359EC0", Offset = "0x1359EC0", VA = "0x1359EC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012B")]
		public bool isNull
		{
			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x1359EE4", Offset = "0x1359EE4", VA = "0x1359EE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012C")]
		public Type refType
		{
			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x1359FE4", Offset = "0x1359FE4", VA = "0x1359FE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012D")]
		public object value
		{
			[Token(Token = "0x6000A75")]
			[Address(RVA = "0x1359FFC", Offset = "0x1359FFC", VA = "0x1359FFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A76")]
			[Address(RVA = "0x135A008", Offset = "0x135A008", VA = "0x135A008")]
			set
			{
			}
		}

		[Token(Token = "0x1700012E")]
		protected abstract object objectValue
		{
			[Token(Token = "0x6000A77")]
			get;
			[Token(Token = "0x6000A78")]
			set;
		}

		[Token(Token = "0x1700012F")]
		public abstract Type varType
		{
			[Token(Token = "0x6000A79")]
			get;
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x1358F90", Offset = "0x1358F90", VA = "0x1358F90")]
		public BBParameter()
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x1358F98", Offset = "0x1358F98", VA = "0x1358F98")]
		public static BBParameter CreateInstance(Type t, IBlackboard bb)
		{
			return null;
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x13591D8", Offset = "0x13591D8", VA = "0x13591D8")]
		public static void SetBBFields(object o, IBlackboard bb)
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x13592AC", Offset = "0x13592AC", VA = "0x13592AC")]
		public static List<BBParameter> GetObjectBBParameters(object o)
		{
			return null;
		}

		[Token(Token = "0x6000A7A")]
		protected abstract void Bind(Variable data);

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x1359ADC", Offset = "0x1359ADC", VA = "0x1359ADC")]
		private Variable ResolveReference(IBlackboard targetBlackboard, bool useID)
		{
			return null;
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x135A014", Offset = "0x135A014", VA = "0x135A014")]
		public Variable PromoteToVariable(IBlackboard targetBB)
		{
			return null;
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x135A410", Offset = "0x135A410", VA = "0x135A410", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000289")]
	public class BBParameter<T> : BBParameter
	{
		[Token(Token = "0x200028A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8AB8", Offset = "0x9E8AB8")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<object> convertFunc;

			[Token(Token = "0x6000A89")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6000A8A")]
			internal T <BindGetter>b__0()
			{
				return (T)null;
			}
		}

		[Token(Token = "0x200028B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8AC8", Offset = "0x9E8AC8")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<object> convertFunc;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Variable variable;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public BBParameter<T> <>4__this;

			[Token(Token = "0x6000A8B")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000A8C")]
			internal void <BindSetter>b__0(T value)
			{
			}

			[Token(Token = "0x6000A8D")]
			internal void <BindSetter>b__1(T value)
			{
			}
		}

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Func<T> getter;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<T> setter;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected T _value;

		[Token(Token = "0x17000130")]
		public new T value
		{
			[Token(Token = "0x6000A80")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000A81")]
			set
			{
			}
		}

		[Token(Token = "0x17000131")]
		protected override object objectValue
		{
			[Token(Token = "0x6000A82")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A83")]
			set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public override Type varType
		{
			[Token(Token = "0x6000A84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A7E")]
		public BBParameter()
		{
		}

		[Token(Token = "0x6000A7F")]
		public BBParameter(T value)
		{
		}

		[Token(Token = "0x6000A85")]
		protected override void Bind(Variable variable)
		{
		}

		[Token(Token = "0x6000A86")]
		private bool BindGetter(Variable variable)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A87")]
		private bool BindSetter(Variable variable)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A88")]
		public static implicit operator BBParameter<T>(T value)
		{
			return null;
		}
	}
	[Token(Token = "0x200028C")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9E8AD8", Offset = "0x9E8AD8")]
	[SpoofAOT]
	public class Blackboard : MonoBehaviour, ISerializationCallbackReceiver, IBlackboard
	{
		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _serializedBlackboard;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<UnityEngine.Object> _objectReferences;

		[NonSerialized]
		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BlackboardSource _blackboard;

		[NonSerialized]
		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool hasDeserialized;

		[Token(Token = "0x17000133")]
		public new string name
		{
			[Token(Token = "0x6000A95")]
			[Address(RVA = "0x135D9B0", Offset = "0x135D9B0", VA = "0x135D9B0", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A96")]
			[Address(RVA = "0x135DA48", Offset = "0x135DA48", VA = "0x135DA48", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000134")]
		public object Item
		{
			[Token(Token = "0x6000A97")]
			[Address(RVA = "0x135DAE4", Offset = "0x135DAE4", VA = "0x135DAE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A98")]
			[Address(RVA = "0x135DBF0", Offset = "0x135DBF0", VA = "0x135DBF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000135")]
		public Dictionary<string, Variable> variables
		{
			[Token(Token = "0x6000A99")]
			[Address(RVA = "0x135DC20", Offset = "0x135DC20", VA = "0x135DC20", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0x135DC3C", Offset = "0x135DC3C", VA = "0x135DC3C", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public GameObject propertiesBindTarget
		{
			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0x135D850", Offset = "0x135D850", VA = "0x135D850", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400000A")]
		public event Action<Variable> onVariableAdded
		{
			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x135D344", Offset = "0x135D344", VA = "0x135D344", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EB9F4", Offset = "0x9EB9F4")]
			add
			{
			}
			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x135D3E4", Offset = "0x135D3E4", VA = "0x135D3E4", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EBA04", Offset = "0x9EBA04")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event Action<Variable> onVariableRemoved
		{
			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x135D484", Offset = "0x135D484", VA = "0x135D484", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EBA14", Offset = "0x9EBA14")]
			add
			{
			}
			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x135D524", Offset = "0x135D524", VA = "0x135D524", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EBA24", Offset = "0x9EBA24")]
			remove
			{
			}
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x135D5C4", Offset = "0x135D5C4", VA = "0x135D5C4", Slot = "4")]
		private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x135D5C8", Offset = "0x135D5C8", VA = "0x135D5C8", Slot = "5")]
		private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x135D818", Offset = "0x135D818", VA = "0x135D818", Slot = "25")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x135DC58", Offset = "0x135DC58", VA = "0x135DC58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9EBA34", Offset = "0x9EBA34")]
		private void ShowJson()
		{
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x135DCD4", Offset = "0x135DCD4", VA = "0x135DCD4", Slot = "15")]
		public Variable AddVariable(string name, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x135E080", Offset = "0x135E080", VA = "0x135E080", Slot = "16")]
		public Variable AddVariable(string name, object value)
		{
			return null;
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x135E1DC", Offset = "0x135E1DC", VA = "0x135E1DC", Slot = "17")]
		public Variable RemoveVariable(string name)
		{
			return null;
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x135E328", Offset = "0x135E328", VA = "0x135E328", Slot = "18")]
		public Variable GetVariable(string name, [Optional] Type ofType)
		{
			return null;
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x135E438", Offset = "0x135E438", VA = "0x135E438", Slot = "19")]
		public Variable GetVariableByID(string ID)
		{
			return null;
		}

		[Token(Token = "0x6000AA2")]
		public Variable<T> GetVariable<T>(string name)
		{
			return null;
		}

		[Token(Token = "0x6000AA3")]
		public T GetValue<T>(string name)
		{
			return (T)null;
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x135DC08", Offset = "0x135DC08", VA = "0x135DC08", Slot = "22")]
		public Variable SetValue(string name, object value)
		{
			return null;
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x135E8E4", Offset = "0x135E8E4", VA = "0x135E8E4", Slot = "23")]
		public string[] GetVariableNames()
		{
			return null;
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x135E96C", Offset = "0x135E96C", VA = "0x135E96C", Slot = "24")]
		public string[] GetVariableNames(Type ofType)
		{
			return null;
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x135EBB8", Offset = "0x135EBB8", VA = "0x135EBB8")]
		public string Save()
		{
			return null;
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x135EC00", Offset = "0x135EC00", VA = "0x135EC00")]
		public string Save(string saveKey)
		{
			return null;
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x135EC48", Offset = "0x135EC48", VA = "0x135EC48")]
		public bool Load()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x135EC70", Offset = "0x135EC70", VA = "0x135EC70")]
		public bool Load(string saveKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x135EC40", Offset = "0x135EC40", VA = "0x135EC40")]
		public string Serialize()
		{
			return null;
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x135ED5C", Offset = "0x135ED5C", VA = "0x135ED5C")]
		public string Serialize(List<UnityEngine.Object> storedObjectReferences)
		{
			return null;
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x135ED50", Offset = "0x135ED50", VA = "0x135ED50")]
		public bool Deserialize(string json)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x135EE34", Offset = "0x135EE34", VA = "0x135EE34")]
		public bool Deserialize(string json, List<UnityEngine.Object> storedObjectReferences, bool removeMissing = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x135F2E8", Offset = "0x135F2E8", VA = "0x135F2E8")]
		public Blackboard()
		{
		}
	}
	[Token(Token = "0x200028D")]
	[ExecuteInEditMode]
	public class GlobalBlackboard : Blackboard
	{
		[Token(Token = "0x200028E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8B34", Offset = "0x9E8B34")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0x1469868", Offset = "0x1469868", VA = "0x1469868")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x1469870", Offset = "0x1469870", VA = "0x1469870")]
			internal bool <Find>b__0(GlobalBlackboard b)
			{
				return default(bool);
			}

			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0x14698A8", Offset = "0x14698A8", VA = "0x14698A8")]
			internal bool <Find>b__1(GlobalBlackboard b)
			{
				return default(bool);
			}

			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0x14698E0", Offset = "0x14698E0", VA = "0x14698E0")]
			internal bool <Find>b__2(GlobalBlackboard b)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<GlobalBlackboard> allGlobals;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool dontDestroy;

		[Token(Token = "0x17000137")]
		public new string name
		{
			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x15055FC", Offset = "0x15055FC", VA = "0x15055FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x1505604", Offset = "0x1505604", VA = "0x1505604")]
			set
			{
			}
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x150581C", Offset = "0x150581C", VA = "0x150581C")]
		public static GlobalBlackboard Create()
		{
			return null;
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x15058D8", Offset = "0x15058D8", VA = "0x15058D8")]
		public static GlobalBlackboard Find(string name)
		{
			return null;
		}

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x1505C38", Offset = "0x1505C38", VA = "0x1505C38", Slot = "25")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x1505ED0", Offset = "0x1505ED0", VA = "0x1505ED0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x15056E8", Offset = "0x15056E8", VA = "0x15056E8")]
		private bool IsUnique()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x1505F5C", Offset = "0x1505F5C", VA = "0x1505F5C")]
		public GlobalBlackboard()
		{
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x1505FF8", Offset = "0x1505FF8", VA = "0x1505FF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EBA6C", Offset = "0x9EBA6C")]
		private bool <IsUnique>b__9_0(GlobalBlackboard b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200028F")]
	[SpoofAOT]
	public interface IBlackboard
	{
		[Token(Token = "0x17000138")]
		string name
		{
			[Token(Token = "0x6000AC2")]
			get;
			[Token(Token = "0x6000AC3")]
			set;
		}

		[Token(Token = "0x17000139")]
		Dictionary<string, Variable> variables
		{
			[Token(Token = "0x6000AC4")]
			get;
			[Token(Token = "0x6000AC5")]
			set;
		}

		[Token(Token = "0x1700013A")]
		GameObject propertiesBindTarget
		{
			[Token(Token = "0x6000AC6")]
			get;
		}

		[Token(Token = "0x1400000C")]
		event Action<Variable> onVariableAdded;

		[Token(Token = "0x1400000D")]
		event Action<Variable> onVariableRemoved;

		[Token(Token = "0x6000AC7")]
		Variable AddVariable(string varName, Type type);

		[Token(Token = "0x6000AC8")]
		Variable AddVariable(string varName, object value);

		[Token(Token = "0x6000AC9")]
		Variable RemoveVariable(string varName);

		[Token(Token = "0x6000ACA")]
		Variable GetVariable(string varName, [Optional] Type ofType);

		[Token(Token = "0x6000ACB")]
		Variable GetVariableByID(string ID);

		[Token(Token = "0x6000ACC")]
		Variable<T> GetVariable<T>(string varName);

		[Token(Token = "0x6000ACD")]
		T GetValue<T>(string varName);

		[Token(Token = "0x6000ACE")]
		Variable SetValue(string varName, object value);

		[Token(Token = "0x6000ACF")]
		string[] GetVariableNames();

		[Token(Token = "0x6000AD0")]
		string[] GetVariableNames(Type ofType);
	}
	[Serializable]
	[Token(Token = "0x2000290")]
	[SpoofAOT]
	public abstract class Variable
	{
		[Token(Token = "0x2000291")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8B64", Offset = "0x9E8B64")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Variable <>4__this;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<object, object> converter;

			[Token(Token = "0x6000AED")]
			[Address(RVA = "0x26A8A7C", Offset = "0x26A8A7C", VA = "0x26A8A7C")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0x26A8A84", Offset = "0x26A8A84", VA = "0x26A8A84")]
			internal object <GetGetConverter>b__0()
			{
				return null;
			}

			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0x26A8AA0", Offset = "0x26A8AA0", VA = "0x26A8AA0")]
			internal object <GetGetConverter>b__1()
			{
				return null;
			}
		}

		[Token(Token = "0x2000292")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8B74", Offset = "0x9E8B74")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Variable <>4__this;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<object, object> converter;

			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0x26A8B0C", Offset = "0x26A8B0C", VA = "0x26A8B0C")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0x26A8B14", Offset = "0x26A8B14", VA = "0x26A8B14")]
			internal void <GetSetConverter>b__0(object x)
			{
			}

			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0x26A8B30", Offset = "0x26A8B30", VA = "0x26A8B30")]
			internal void <GetSetConverter>b__1(object x)
			{
			}
		}

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _name;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _id;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _protected;

		[Token(Token = "0x1700013B")]
		public string name
		{
			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0x1455BDC", Offset = "0x1455BDC", VA = "0x1455BDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0x1455BE4", Offset = "0x1455BE4", VA = "0x1455BE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700013C")]
		public string ID
		{
			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x1455C7C", Offset = "0x1455C7C", VA = "0x1455C7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013D")]
		public object value
		{
			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0x1455D20", Offset = "0x1455D20", VA = "0x1455D20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0x1455D2C", Offset = "0x1455D2C", VA = "0x1455D2C")]
			set
			{
			}
		}

		[Token(Token = "0x1700013E")]
		public bool isProtected
		{
			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0x1455D38", Offset = "0x1455D38", VA = "0x1455D38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0x1455D40", Offset = "0x1455D40", VA = "0x1455D40")]
			set
			{
			}
		}

		[Token(Token = "0x1700013F")]
		protected abstract object objectValue
		{
			[Token(Token = "0x6000ADF")]
			get;
			[Token(Token = "0x6000AE0")]
			set;
		}

		[Token(Token = "0x17000140")]
		public abstract Type varType
		{
			[Token(Token = "0x6000AE1")]
			get;
		}

		[Token(Token = "0x17000141")]
		public abstract bool hasBinding
		{
			[Token(Token = "0x6000AE2")]
			get;
		}

		[Token(Token = "0x17000142")]
		public abstract string propertyPath
		{
			[Token(Token = "0x6000AE3")]
			get;
			[Token(Token = "0x6000AE4")]
			set;
		}

		[Token(Token = "0x1400000E")]
		public event Action<string> onNameChanged
		{
			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0x145595C", Offset = "0x145595C", VA = "0x145595C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EBABC", Offset = "0x9EBABC")]
			add
			{
			}
			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0x14559FC", Offset = "0x14559FC", VA = "0x14559FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EBACC", Offset = "0x9EBACC")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public event Action<string, object> onValueChanged
		{
			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0x1455A9C", Offset = "0x1455A9C", VA = "0x1455A9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EBADC", Offset = "0x9EBADC")]
			add
			{
			}
			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0x1455B3C", Offset = "0x1455B3C", VA = "0x1455B3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EBAEC", Offset = "0x9EBAEC")]
			remove
			{
			}
		}

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x1455D4C", Offset = "0x1455D4C", VA = "0x1455D4C")]
		protected bool HasValueChangeEvent()
		{
			return default(bool);
		}

		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x1455D5C", Offset = "0x1455D5C", VA = "0x1455D5C")]
		protected void OnValueChanged(string name, object value)
		{
		}

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x1455DD4", Offset = "0x1455DD4", VA = "0x1455DD4")]
		public Variable()
		{
		}

		[Token(Token = "0x6000AE5")]
		public abstract void BindProperty(MemberInfo prop, [Optional] GameObject target);

		[Token(Token = "0x6000AE6")]
		public abstract void UnBindProperty();

		[Token(Token = "0x6000AE7")]
		public abstract void InitializePropertyBinding(GameObject go, bool callSetter = false);

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x1455DDC", Offset = "0x1455DDC", VA = "0x1455DDC")]
		public bool CanConvertTo(Type toType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x1455DF8", Offset = "0x1455DF8", VA = "0x1455DF8")]
		public Func<object> GetGetConverter(Type toType)
		{
			return null;
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x1455F8C", Offset = "0x1455F8C", VA = "0x1455F8C")]
		public bool CanConvertFrom(Type fromType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x1455FA8", Offset = "0x1455FA8", VA = "0x1455FA8")]
		public Action<object> GetSetConverter(Type fromType)
		{
			return null;
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x1456140", Offset = "0x1456140", VA = "0x1456140", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000293")]
	public class Variable<T> : Variable
	{
		[Token(Token = "0x2000294")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8B84", Offset = "0x9E8B84")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Variable<T> <>4__this;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GameObject go;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FieldInfo field;

			[Token(Token = "0x6000B01")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6000B02")]
			internal T <InitializePropertyBinding>b__1()
			{
				return (T)null;
			}

			[Token(Token = "0x6000B03")]
			internal void <InitializePropertyBinding>b__3(T o)
			{
			}
		}

		[Token(Token = "0x2000295")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8B94", Offset = "0x9E8B94")]
		private sealed class <>c__DisplayClass22_1
		{
			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public MethodInfo getMethod;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Component instance;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public MethodInfo setMethod;

			[Token(Token = "0x6000B04")]
			public <>c__DisplayClass22_1()
			{
			}

			[Token(Token = "0x6000B05")]
			internal T <InitializePropertyBinding>b__0()
			{
				return (T)null;
			}

			[Token(Token = "0x6000B06")]
			internal void <InitializePropertyBinding>b__2(T o)
			{
			}
		}

		[Token(Token = "0x2000296")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8BA4", Offset = "0x9E8BA4")]
		private sealed class <>c__DisplayClass22_2
		{
			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Component instance;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public <>c__DisplayClass22_0 CS$<>8__locals1;

			[Token(Token = "0x6000B07")]
			public <>c__DisplayClass22_2()
			{
			}

			[Token(Token = "0x6000B08")]
			internal T <InitializePropertyBinding>b__4()
			{
				return (T)null;
			}

			[Token(Token = "0x6000B09")]
			internal void <InitializePropertyBinding>b__5(T o)
			{
			}
		}

		[Token(Token = "0x2000297")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8BB4", Offset = "0x9E8BB4")]
		private sealed class <>c__DisplayClass22_3
		{
			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T value;

			[Token(Token = "0x6000B0A")]
			public <>c__DisplayClass22_3()
			{
			}

			[Token(Token = "0x6000B0B")]
			internal T <InitializePropertyBinding>b__6()
			{
				return (T)null;
			}
		}

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private T _value;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private string _propertyPath;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Func<T> getter;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<T> setter;

		[Token(Token = "0x17000143")]
		public override string propertyPath
		{
			[Token(Token = "0x6000AF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AF5")]
			set
			{
			}
		}

		[Token(Token = "0x17000144")]
		public override bool hasBinding
		{
			[Token(Token = "0x6000AF6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000145")]
		protected override object objectValue
		{
			[Token(Token = "0x6000AF7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000146")]
		public override Type varType
		{
			[Token(Token = "0x6000AF9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000147")]
		public new T value
		{
			[Token(Token = "0x6000AFA")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000AFB")]
			set
			{
			}
		}

		[Token(Token = "0x6000AF3")]
		public Variable()
		{
		}

		[Token(Token = "0x6000AFC")]
		public T GetValue()
		{
			return (T)null;
		}

		[Token(Token = "0x6000AFD")]
		public void SetValue(T newValue)
		{
		}

		[Token(Token = "0x6000AFE")]
		public override void BindProperty(MemberInfo prop, [Optional] GameObject target)
		{
		}

		[Token(Token = "0x6000AFF")]
		public override void UnBindProperty()
		{
		}

		[Token(Token = "0x6000B00")]
		public override void InitializePropertyBinding(GameObject go, bool callSetter = false)
		{
		}
	}
	[Token(Token = "0x2000298")]
	public class VariableSeperator
	{
		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA214", Offset = "0x9EA214")]
		private bool <isEditingName>k__BackingField;

		[Token(Token = "0x17000148")]
		public bool isEditingName
		{
			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0x1456530", Offset = "0x1456530", VA = "0x1456530")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EBAFC", Offset = "0x9EBAFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x1456538", Offset = "0x1456538", VA = "0x1456538")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EBB0C", Offset = "0x9EBB0C")]
			set
			{
			}
		}

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x1456544", Offset = "0x1456544", VA = "0x1456544")]
		public VariableSeperator()
		{
		}
	}
}
namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	[Token(Token = "0x2000299")]
	public class GraphSerializationData
	{
		[Token(Token = "0x40005A1")]
		public const float FRAMEWORK_VERSION = 2.92f;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float version;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string name;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string category;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string comments;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector2 translation;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float zoomFactor;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<Node> nodes;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<Connection> connections;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<CanvasGroup> canvasGroups;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public BlackboardSource localBlackboard;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public object derivedData;

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x150EF68", Offset = "0x150EF68", VA = "0x150EF68")]
		public GraphSerializationData()
		{
		}

		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x1507E50", Offset = "0x1507E50", VA = "0x1507E50")]
		public GraphSerializationData(Graph graph)
		{
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x1508724", Offset = "0x1508724", VA = "0x1508724")]
		public void Reconstruct(Graph graph)
		{
		}
	}
	[Token(Token = "0x200029A")]
	[DoNotList]
	public sealed class MissingConnection : Connection, IMissingRecoverable
	{
		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _missingType;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _recoveryState;

		[Token(Token = "0x17000149")]
		private string ParadoxNotion.Serialization.IMissingRecoverable.missingType
		{
			[Token(Token = "0x6000B12")]
			[Address(RVA = "0x15175D4", Offset = "0x15175D4", VA = "0x15175D4", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B13")]
			[Address(RVA = "0x15175DC", Offset = "0x15175DC", VA = "0x15175DC", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x1700014A")]
		private string ParadoxNotion.Serialization.IMissingRecoverable.recoveryState
		{
			[Token(Token = "0x6000B14")]
			[Address(RVA = "0x15175E4", Offset = "0x15175E4", VA = "0x15175E4", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B15")]
			[Address(RVA = "0x15175EC", Offset = "0x15175EC", VA = "0x15175EC", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x15175F4", Offset = "0x15175F4", VA = "0x15175F4")]
		public MissingConnection()
		{
		}
	}
	[Token(Token = "0x200029B")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E8BD4", Offset = "0x9E8BD4")]
	[DoNotList]
	public sealed class MissingNode : Node, IMissingRecoverable
	{
		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private string _missingType;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private string _recoveryState;

		[Token(Token = "0x1700014B")]
		private string ParadoxNotion.Serialization.IMissingRecoverable.missingType
		{
			[Token(Token = "0x6000B17")]
			[Address(RVA = "0x15175FC", Offset = "0x15175FC", VA = "0x15175FC", Slot = "34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B18")]
			[Address(RVA = "0x1517604", Offset = "0x1517604", VA = "0x1517604", Slot = "35")]
			set
			{
			}
		}

		[Token(Token = "0x1700014C")]
		private string ParadoxNotion.Serialization.IMissingRecoverable.recoveryState
		{
			[Token(Token = "0x6000B19")]
			[Address(RVA = "0x151760C", Offset = "0x151760C", VA = "0x151760C", Slot = "36")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B1A")]
			[Address(RVA = "0x1517614", Offset = "0x1517614", VA = "0x1517614", Slot = "37")]
			set
			{
			}
		}

		[Token(Token = "0x1700014D")]
		public override string name
		{
			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0x151761C", Offset = "0x151761C", VA = "0x151761C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014E")]
		public override Type outConnectionType
		{
			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0x1517660", Offset = "0x1517660", VA = "0x1517660", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014F")]
		public override int maxInConnections
		{
			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0x1517668", Offset = "0x1517668", VA = "0x1517668", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000150")]
		public override int maxOutConnections
		{
			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0x1517670", Offset = "0x1517670", VA = "0x1517670", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000151")]
		public override bool allowAsPrime
		{
			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0x1517678", Offset = "0x1517678", VA = "0x1517678", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000152")]
		public override Alignment2x2 commentsAlignment
		{
			[Token(Token = "0x6000B20")]
			[Address(RVA = "0x1517680", Offset = "0x1517680", VA = "0x1517680", Slot = "13")]
			get
			{
				return default(Alignment2x2);
			}
		}

		[Token(Token = "0x17000153")]
		public override Alignment2x2 iconAlignment
		{
			[Token(Token = "0x6000B21")]
			[Address(RVA = "0x1517688", Offset = "0x1517688", VA = "0x1517688", Slot = "14")]
			get
			{
				return default(Alignment2x2);
			}
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x1517690", Offset = "0x1517690", VA = "0x1517690")]
		public MissingNode()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200029C")]
	public class ReflectedAction : ReflectedActionWrapper
	{
		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ActionCall call;

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x1BB1DF4", Offset = "0x1BB1DF4", VA = "0x1BB1DF4", Slot = "4")]
		public override BBParameter[] GetVariables()
		{
			return null;
		}

		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x1BB1E3C", Offset = "0x1BB1E3C", VA = "0x1BB1E3C", Slot = "5")]
		public override void Init(object instance)
		{
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x1BB1F00", Offset = "0x1BB1F00", VA = "0x1BB1F00", Slot = "6")]
		public override void Call()
		{
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x1BB1F1C", Offset = "0x1BB1F1C", VA = "0x1BB1F1C")]
		public ReflectedAction()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200029D")]
	[SpoofAOT]
	public class ReflectedAction<T1> : ReflectedActionWrapper
	{
		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ActionCall<T1> call;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T1> p1;

		[Token(Token = "0x6000B27")]
		public override BBParameter[] GetVariables()
		{
			return null;
		}

		[Token(Token = "0x6000B28")]
		public override void Init(object instance)
		{
		}

		[Token(Token = "0x6000B29")]
		public override void Call()
		{
		}

		[Token(Token = "0x6000B2A")]
		public ReflectedAction()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200029E")]
	public class ReflectedAction<T1, T2> : ReflectedActionWrapper
	{
		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ActionCall<T1, T2> call;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T1> p1;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T2> p2;

		[Token(Token = "0x6000B2B")]
		public override BBParameter[] GetVariables()
		{
			return null;
		}

		[Token(Token = "0x6000B2C")]
		public override void Init(object instance)
		{
		}

		[Token(Token = "0x6000B2D")]
		public override void Call()
		{
		}

		[Token(Token = "0x6000B2E")]
		public ReflectedAction()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200029F")]
	public class ReflectedAction<T1, T2, T3> : ReflectedActionWrapper
	{
		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ActionCall<T1, T2, T3> call;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T1> p1;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T2> p2;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T3> p3;

		[Token(Token = "0x6000B2F")]
		public override BBParameter[] GetVariables()
		{
			return null;
		}

		[Token(Token = "0x6000B30")]
		public override void Init(object instance)
		{
		}

		[Token(Token = "0x6000B31")]
		public override void Call()
		{
		}

		[Token(Token = "0x6000B32")]
		public ReflectedAction()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20002A0")]
	public class ReflectedAction<T1, T2, T3, T4> : ReflectedActionWrapper
	{
		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ActionCall<T1, T2, T3, T4> call;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T1> p1;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T2> p2;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T3> p3;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T4> p4;

		[Token(Token = "0x6000B33")]
		public override BBParameter[] GetVariables()
		{
			return null;
		}

		[Token(Token = "0x6000B34")]
		public override void Init(object instance)
		{
		}

		[Token(Token = "0x6000B35")]
		public override void Call()
		{
		}

		[Token(Token = "0x6000B36")]
		public ReflectedAction()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20002A1")]
	public class ReflectedAction<T1, T2, T3, T4, T5> : ReflectedActionWrapper
	{
		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ActionCall<T1, T2, T3, T4, T5> call;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T1> p1;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T2> p2;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T3> p3;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T4> p4;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T5> p5;

		[Token(Token = "0x6000B37")]
		public override BBParameter[] GetVariables()
		{
			return null;
		}

		[Token(Token = "0x6000B38")]
		public override void Init(object instance)
		{
		}

		[Token(Token = "0x6000B39")]
		public override void Call()
		{
		}

		[Token(Token = "0x6000B3A")]
		public ReflectedAction()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20002A2")]
	public class ReflectedAction<T1, T2, T3, T4, T5, T6> : ReflectedActionWrapper
	{
		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ActionCall<T1, T2, T3, T4, T5, T6> call;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T1> p1;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T2> p2;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T3> p3;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T4> p4;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T5> p5;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T6> p6;

		[Token(Token = "0x6000B3B")]
		public override BBParameter[] GetVariables()
		{
			return null;
		}

		[Token(Token = "0x6000B3C")]
		public override void Init(object instance)
		{
		}

		[Token(Token = "0x6000B3D")]
		public override void Call()
		{
		}

		[Token(Token = "0x6000B3E")]
		public ReflectedAction()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20002A3")]
	[SpoofAOT]
	public class ReflectedFunction<TResult> : ReflectedFunctionWrapper
	{
		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FunctionCall<TResult> call;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[BlackboardOnly]
		public BBParameter<TResult> result;

		[Token(Token = "0x6000B3F")]
		public override BBParameter[] GetVariables()
		{
			return null;
		}

		[Token(Token = "0x6000B40")]
		public override void Init(object instance)
		{
		}

		[Token(Token = "0x6000B41")]
		public override object Call()
		{
			return null;
		}

		[Token(Token = "0x6000B42")]
		public ReflectedFunction()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20002A4")]
	public class ReflectedFunction<TResult, T1> : ReflectedFunctionWrapper
	{
		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FunctionCall<T1, TResult> call;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T1> p1;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[BlackboardOnly]
		public BBParameter<TResult> result;

		[Token(Token = "0x6000B43")]
		public override BBParameter[] GetVariables()
		{
			return null;
		}

		[Token(Token = "0x6000B44")]
		public override void Init(object instance)
		{
		}

		[Token(Token = "0x6000B45")]
		public override object Call()
		{
			return null;
		}

		[Token(Token = "0x6000B46")]
		public ReflectedFunction()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20002A5")]
	public class ReflectedFunction<TResult, T1, T2> : ReflectedFunctionWrapper
	{
		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FunctionCall<T1, T2, TResult> call;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T1> p1;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T2> p2;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[BlackboardOnly]
		public BBParameter<TResult> result;

		[Token(Token = "0x6000B47")]
		public override BBParameter[] GetVariables()
		{
			return null;
		}

		[Token(Token = "0x6000B48")]
		public override void Init(object instance)
		{
		}

		[Token(Token = "0x6000B49")]
		public override object Call()
		{
			return null;
		}

		[Token(Token = "0x6000B4A")]
		public ReflectedFunction()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20002A6")]
	public class ReflectedFunction<TResult, T1, T2, T3> : ReflectedFunctionWrapper
	{
		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FunctionCall<T1, T2, T3, TResult> call;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T1> p1;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T2> p2;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T3> p3;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[BlackboardOnly]
		public BBParameter<TResult> result;

		[Token(Token = "0x6000B4B")]
		public override BBParameter[] GetVariables()
		{
			return null;
		}

		[Token(Token = "0x6000B4C")]
		public override void Init(object instance)
		{
		}

		[Token(Token = "0x6000B4D")]
		public override object Call()
		{
			return null;
		}

		[Token(Token = "0x6000B4E")]
		public ReflectedFunction()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20002A7")]
	public class ReflectedFunction<TResult, T1, T2, T3, T4> : ReflectedFunctionWrapper
	{
		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FunctionCall<T1, T2, T3, T4, TResult> call;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T1> p1;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T2> p2;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T3> p3;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T4> p4;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[BlackboardOnly]
		public BBParameter<TResult> result;

		[Token(Token = "0x6000B4F")]
		public override BBParameter[] GetVariables()
		{
			return null;
		}

		[Token(Token = "0x6000B50")]
		public override void Init(object instance)
		{
		}

		[Token(Token = "0x6000B51")]
		public override object Call()
		{
			return null;
		}

		[Token(Token = "0x6000B52")]
		public ReflectedFunction()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20002A8")]
	public class ReflectedFunction<TResult, T1, T2, T3, T4, T5> : ReflectedFunctionWrapper
	{
		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FunctionCall<T1, T2, T3, T4, T5, TResult> call;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T1> p1;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T2> p2;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T3> p3;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T4> p4;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T5> p5;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[BlackboardOnly]
		public BBParameter<TResult> result;

		[Token(Token = "0x6000B53")]
		public override BBParameter[] GetVariables()
		{
			return null;
		}

		[Token(Token = "0x6000B54")]
		public override void Init(object instance)
		{
		}

		[Token(Token = "0x6000B55")]
		public override object Call()
		{
			return null;
		}

		[Token(Token = "0x6000B56")]
		public ReflectedFunction()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20002A9")]
	public class ReflectedFunction<TResult, T1, T2, T3, T4, T5, T6> : ReflectedFunctionWrapper
	{
		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private FunctionCall<T1, T2, T3, T4, T5, T6, TResult> call;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T1> p1;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T2> p2;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T3> p3;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T4> p4;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T5> p5;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BBParameter<T6> p6;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[BlackboardOnly]
		public BBParameter<TResult> result;

		[Token(Token = "0x6000B57")]
		public override BBParameter[] GetVariables()
		{
			return null;
		}

		[Token(Token = "0x6000B58")]
		public override void Init(object instance)
		{
		}

		[Token(Token = "0x6000B59")]
		public override object Call()
		{
			return null;
		}

		[Token(Token = "0x6000B5A")]
		public ReflectedFunction()
		{
		}
	}
	[Token(Token = "0x20002AA")]
	public abstract class ReflectedWrapper
	{
		[Token(Token = "0x20002AB")]
		protected delegate void ActionCall();

		[Token(Token = "0x20002AC")]
		protected delegate void ActionCall<T1>(T1 a);

		[Token(Token = "0x20002AD")]
		protected delegate void ActionCall<T1, T2>(T1 a, T2 b);

		[Token(Token = "0x20002AE")]
		protected delegate void ActionCall<T1, T2, T3>(T1 a, T2 b, T3 c);

		[Token(Token = "0x20002AF")]
		protected delegate void ActionCall<T1, T2, T3, T4>(T1 a, T2 b, T3 c, T4 d);

		[Token(Token = "0x20002B0")]
		protected delegate void ActionCall<T1, T2, T3, T4, T5>(T1 a, T2 b, T3 c, T4 d, T5 e);

		[Token(Token = "0x20002B1")]
		protected delegate void ActionCall<T1, T2, T3, T4, T5, T6>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);

		[Token(Token = "0x20002B2")]
		protected delegate TResult FunctionCall<TResult>();

		[Token(Token = "0x20002B3")]
		protected delegate TResult FunctionCall<T1, TResult>(T1 a);

		[Token(Token = "0x20002B4")]
		protected delegate TResult FunctionCall<T1, T2, TResult>(T1 a, T2 b);

		[Token(Token = "0x20002B5")]
		protected delegate TResult FunctionCall<T1, T2, T3, TResult>(T1 a, T2 b, T3 c);

		[Token(Token = "0x20002B6")]
		protected delegate TResult FunctionCall<T1, T2, T3, T4, TResult>(T1 a, T2 b, T3 c, T4 d);

		[Token(Token = "0x20002B7")]
		protected delegate TResult FunctionCall<T1, T2, T3, T4, T5, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e);

		[Token(Token = "0x20002B8")]
		protected delegate TResult FunctionCall<T1, T2, T3, T4, T5, T6, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected SerializedMethodInfo _targetMethod;

		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x1BB26E0", Offset = "0x1BB26E0", VA = "0x1BB26E0")]
		public ReflectedWrapper()
		{
		}

		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x1BB8348", Offset = "0x1BB8348", VA = "0x1BB8348")]
		public static ReflectedWrapper Create(MethodInfo method, IBlackboard bb)
		{
			return null;
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x1BB8444", Offset = "0x1BB8444", VA = "0x1BB8444")]
		public void SetVariablesBB(IBlackboard bb)
		{
		}

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x1BB84D0", Offset = "0x1BB84D0", VA = "0x1BB84D0")]
		public bool HasChanged()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x1BB1EE8", Offset = "0x1BB1EE8", VA = "0x1BB1EE8")]
		public MethodInfo GetMethod()
		{
			return null;
		}

		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x1BB84E8", Offset = "0x1BB84E8", VA = "0x1BB84E8")]
		public string GetMethodString()
		{
			return null;
		}

		[Token(Token = "0x6000B61")]
		public abstract BBParameter[] GetVariables();

		[Token(Token = "0x6000B62")]
		public abstract void Init(object instance);
	}
	[Token(Token = "0x20002B9")]
	public abstract class ReflectedActionWrapper : ReflectedWrapper
	{
		[Serializable]
		[Token(Token = "0x20002BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8C40", Offset = "0x9E8C40")]
		private sealed class <>c
		{
			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<ParameterInfo, Type> <>9__0_0;

			[Token(Token = "0x6000B9F")]
			[Address(RVA = "0x26A4FAC", Offset = "0x26A4FAC", VA = "0x26A4FAC")]
			public <>c()
			{
			}

			[Token(Token = "0x6000BA0")]
			[Address(RVA = "0x26A4FB4", Offset = "0x26A4FB4", VA = "0x26A4FB4")]
			internal Type <Create>b__0_0(ParameterInfo p)
			{
				return null;
			}
		}

		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x1BB20E0", Offset = "0x1BB20E0", VA = "0x1BB20E0")]
		public new static ReflectedActionWrapper Create(MethodInfo method, IBlackboard bb)
		{
			return null;
		}

		[Token(Token = "0x6000B9C")]
		public abstract void Call();

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x1BB1F24", Offset = "0x1BB1F24", VA = "0x1BB1F24")]
		protected ReflectedActionWrapper()
		{
		}
	}
	[Token(Token = "0x20002BB")]
	public abstract class ReflectedFunctionWrapper : ReflectedWrapper
	{
		[Serializable]
		[Token(Token = "0x20002BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8C50", Offset = "0x9E8C50")]
		private sealed class <>c
		{
			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<ParameterInfo, Type> <>9__0_0;

			[Token(Token = "0x6000BA5")]
			[Address(RVA = "0x26A547C", Offset = "0x26A547C", VA = "0x26A547C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000BA6")]
			[Address(RVA = "0x26A5484", Offset = "0x26A5484", VA = "0x26A5484")]
			internal Type <Create>b__0_0(ParameterInfo p)
			{
				return null;
			}
		}

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x1BB3D94", Offset = "0x1BB3D94", VA = "0x1BB3D94")]
		public new static ReflectedFunctionWrapper Create(MethodInfo method, IBlackboard bb)
		{
			return null;
		}

		[Token(Token = "0x6000BA2")]
		public abstract object Call();

		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x1BB43D4", Offset = "0x1BB43D4", VA = "0x1BB43D4")]
		protected ReflectedFunctionWrapper()
		{
		}
	}
	[Token(Token = "0x20002BD")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E8C60", Offset = "0x9E8C60")]
	[DoNotList]
	public class MissingAction : ActionTask, IMissingRecoverable
	{
		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _missingType;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string _recoveryState;

		[Token(Token = "0x17000154")]
		private string ParadoxNotion.Serialization.IMissingRecoverable.missingType
		{
			[Token(Token = "0x6000BA7")]
			[Address(RVA = "0x1517380", Offset = "0x1517380", VA = "0x1517380", Slot = "18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BA8")]
			[Address(RVA = "0x1517388", Offset = "0x1517388", VA = "0x1517388", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000155")]
		private string ParadoxNotion.Serialization.IMissingRecoverable.recoveryState
		{
			[Token(Token = "0x6000BA9")]
			[Address(RVA = "0x1517390", Offset = "0x1517390", VA = "0x1517390", Slot = "20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BAA")]
			[Address(RVA = "0x1517398", Offset = "0x1517398", VA = "0x1517398", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x17000156")]
		protected override string info
		{
			[Token(Token = "0x6000BAB")]
			[Address(RVA = "0x15173A0", Offset = "0x15173A0", VA = "0x15173A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x151746C", Offset = "0x151746C", VA = "0x151746C")]
		public MissingAction()
		{
		}
	}
	[Token(Token = "0x20002BE")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x9E8CAC", Offset = "0x9E8CAC")]
	[DoNotList]
	public class MissingCondition : ConditionTask, IMissingRecoverable
	{
		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _missingType;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string _recoveryState;

		[Token(Token = "0x17000157")]
		private string ParadoxNotion.Serialization.IMissingRecoverable.missingType
		{
			[Token(Token = "0x6000BAD")]
			[Address(RVA = "0x15174E0", Offset = "0x15174E0", VA = "0x15174E0", Slot = "16")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BAE")]
			[Address(RVA = "0x15174E8", Offset = "0x15174E8", VA = "0x15174E8", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x17000158")]
		private string ParadoxNotion.Serialization.IMissingRecoverable.recoveryState
		{
			[Token(Token = "0x6000BAF")]
			[Address(RVA = "0x15174F0", Offset = "0x15174F0", VA = "0x15174F0", Slot = "18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB0")]
			[Address(RVA = "0x15174F8", Offset = "0x15174F8", VA = "0x15174F8", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000159")]
		protected override string info
		{
			[Token(Token = "0x6000BB1")]
			[Address(RVA = "0x1517500", Offset = "0x1517500", VA = "0x1517500", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x15175CC", Offset = "0x15175CC", VA = "0x15175CC")]
		public MissingCondition()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20002BF")]
	public class TaskAgentParameter : BBParameter<UnityEngine.Object>
	{
		[Token(Token = "0x1700015A")]
		public new UnityEngine.Object value
		{
			[Token(Token = "0x6000BB3")]
			[Address(RVA = "0x1BC52C0", Offset = "0x1BC52C0", VA = "0x1BC52C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB4")]
			[Address(RVA = "0x1BC6A64", Offset = "0x1BC6A64", VA = "0x1BC6A64")]
			set
			{
			}
		}

		[Token(Token = "0x1700015B")]
		protected override object objectValue
		{
			[Token(Token = "0x6000BB5")]
			[Address(RVA = "0x1BC6A6C", Offset = "0x1BC6A6C", VA = "0x1BC6A6C", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB6")]
			[Address(RVA = "0x1BC6A70", Offset = "0x1BC6A70", VA = "0x1BC6A70", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0x1BC5158", Offset = "0x1BC5158", VA = "0x1BC5158")]
		public TaskAgentParameter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20002C0")]
	public class BBObjectParameter : BBParameter<object>
	{
		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Type _type;

		[Token(Token = "0x1700015C")]
		public override Type varType
		{
			[Token(Token = "0x6000BB8")]
			[Address(RVA = "0x1358D1C", Offset = "0x1358D1C", VA = "0x1358D1C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0x1358D24", Offset = "0x1358D24", VA = "0x1358D24")]
		public BBObjectParameter()
		{
		}

		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x1358F2C", Offset = "0x1358F2C", VA = "0x1358F2C")]
		public BBObjectParameter(Type t)
		{
		}

		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x1358DCC", Offset = "0x1358DCC", VA = "0x1358DCC")]
		public void SetType(Type t)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20002C1")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9E8CF8", Offset = "0x9E8CF8")]
	public sealed class BlackboardSource : IBlackboard
	{
		[Token(Token = "0x20002C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8D30", Offset = "0x9E8D30")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type ofType;

			[Token(Token = "0x6000BD5")]
			[Address(RVA = "0x1467D3C", Offset = "0x1467D3C", VA = "0x1467D3C")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000BD6")]
			[Address(RVA = "0x1467D44", Offset = "0x1467D44", VA = "0x1467D44")]
			internal bool <GetVariableNames>b__0(Variable v)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20002C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8D40", Offset = "0x9E8D40")]
		private sealed class <>c
		{
			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Variable, string> <>9__30_1;

			[Token(Token = "0x6000BD8")]
			[Address(RVA = "0x1467D1C", Offset = "0x1467D1C", VA = "0x1467D1C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000BD9")]
			[Address(RVA = "0x1467D24", Offset = "0x1467D24", VA = "0x1467D24")]
			internal string <GetVariableNames>b__30_1(Variable v)
			{
				return null;
			}
		}

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _name;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Dictionary<string, Variable> _variables;

		[Token(Token = "0x1700015D")]
		public string name
		{
			[Token(Token = "0x6000BC0")]
			[Address(RVA = "0x135F5DC", Offset = "0x135F5DC", VA = "0x135F5DC", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC1")]
			[Address(RVA = "0x135F5E4", Offset = "0x135F5E4", VA = "0x135F5E4", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x1700015E")]
		public Dictionary<string, Variable> variables
		{
			[Token(Token = "0x6000BC2")]
			[Address(RVA = "0x135F5EC", Offset = "0x135F5EC", VA = "0x135F5EC", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC3")]
			[Address(RVA = "0x135F5F4", Offset = "0x135F5F4", VA = "0x135F5F4", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x1700015F")]
		public GameObject propertiesBindTarget
		{
			[Token(Token = "0x6000BC4")]
			[Address(RVA = "0x135F5FC", Offset = "0x135F5FC", VA = "0x135F5FC", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000160")]
		public object Item
		{
			[Token(Token = "0x6000BC5")]
			[Address(RVA = "0x135DAFC", Offset = "0x135DAFC", VA = "0x135DAFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC6")]
			[Address(RVA = "0x135F604", Offset = "0x135F604", VA = "0x135F604")]
			set
			{
			}
		}

		[Token(Token = "0x14000010")]
		public event Action<Variable> onVariableAdded
		{
			[Token(Token = "0x6000BBC")]
			[Address(RVA = "0x135F35C", Offset = "0x135F35C", VA = "0x135F35C", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EBB1C", Offset = "0x9EBB1C")]
			add
			{
			}
			[Token(Token = "0x6000BBD")]
			[Address(RVA = "0x135F3FC", Offset = "0x135F3FC", VA = "0x135F3FC", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EBB2C", Offset = "0x9EBB2C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event Action<Variable> onVariableRemoved
		{
			[Token(Token = "0x6000BBE")]
			[Address(RVA = "0x135F49C", Offset = "0x135F49C", VA = "0x135F49C", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EBB3C", Offset = "0x9EBB3C")]
			add
			{
			}
			[Token(Token = "0x6000BBF")]
			[Address(RVA = "0x135F53C", Offset = "0x135F53C", VA = "0x135F53C", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EBB4C", Offset = "0x9EBB4C")]
			remove
			{
			}
		}

		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x135D718", Offset = "0x135D718", VA = "0x135D718")]
		public BlackboardSource()
		{
		}

		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x135D858", Offset = "0x135D858", VA = "0x135D858")]
		public void InitializePropertiesBinding(GameObject targetGO, bool callSetter)
		{
		}

		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x135E10C", Offset = "0x135E10C", VA = "0x135E10C", Slot = "14")]
		public Variable AddVariable(string varName, object value)
		{
			return null;
		}

		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x135DD60", Offset = "0x135DD60", VA = "0x135DD60", Slot = "13")]
		public Variable AddVariable(string varName, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x135E260", Offset = "0x135E260", VA = "0x135E260", Slot = "15")]
		public Variable RemoveVariable(string varName)
		{
			return null;
		}

		[Token(Token = "0x6000BCC")]
		public T GetValue<T>(string varName)
		{
			return (T)null;
		}

		[Token(Token = "0x6000BCD")]
		[Address(RVA = "0x135E5C8", Offset = "0x135E5C8", VA = "0x135E5C8", Slot = "20")]
		public Variable SetValue(string varName, object value)
		{
			return null;
		}

		[Token(Token = "0x6000BCE")]
		public Variable<T> GetVariable<T>(string varName)
		{
			return null;
		}

		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x135E340", Offset = "0x135E340", VA = "0x135E340", Slot = "16")]
		public Variable GetVariable(string varName, [Optional] Type ofType)
		{
			return null;
		}

		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x135E450", Offset = "0x135E450", VA = "0x135E450", Slot = "17")]
		public Variable GetVariableByID(string ID)
		{
			return null;
		}

		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x135E8FC", Offset = "0x135E8FC", VA = "0x135E8FC", Slot = "21")]
		public string[] GetVariableNames()
		{
			return null;
		}

		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x135E984", Offset = "0x135E984", VA = "0x135E984", Slot = "22")]
		public string[] GetVariableNames(Type ofType)
		{
			return null;
		}

		[Token(Token = "0x6000BD3")]
		public Variable<T> AddVariable<T>(string varName, T value)
		{
			return null;
		}

		[Token(Token = "0x6000BD4")]
		public Variable<T> AddVariable<T>(string varName)
		{
			return null;
		}
	}
	[Token(Token = "0x20002C4")]
	public class MissingBBParameterType : BBParameter<object>, IMissingRecoverable
	{
		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _missingType;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _recoveryState;

		[Token(Token = "0x17000161")]
		private string ParadoxNotion.Serialization.IMissingRecoverable.missingType
		{
			[Token(Token = "0x6000BDA")]
			[Address(RVA = "0x1517474", Offset = "0x1517474", VA = "0x1517474", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0x151747C", Offset = "0x151747C", VA = "0x151747C", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000162")]
		private string ParadoxNotion.Serialization.IMissingRecoverable.recoveryState
		{
			[Token(Token = "0x6000BDC")]
			[Address(RVA = "0x1517484", Offset = "0x1517484", VA = "0x1517484", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BDD")]
			[Address(RVA = "0x151748C", Offset = "0x151748C", VA = "0x151748C", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x1517494", Offset = "0x1517494", VA = "0x1517494")]
		public MissingBBParameterType()
		{
		}
	}
	[Token(Token = "0x20002C5")]
	public class MissingVariableType : Variable<object>, IMissingRecoverable
	{
		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _missingType;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _recoveryState;

		[Token(Token = "0x17000163")]
		public string missingType
		{
			[Token(Token = "0x6000BDF")]
			[Address(RVA = "0x1517754", Offset = "0x1517754", VA = "0x1517754", Slot = "13")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE0")]
			[Address(RVA = "0x151775C", Offset = "0x151775C", VA = "0x151775C", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x17000164")]
		public string recoveryState
		{
			[Token(Token = "0x6000BE1")]
			[Address(RVA = "0x1517764", Offset = "0x1517764", VA = "0x1517764", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0x151776C", Offset = "0x151776C", VA = "0x151776C", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x1517774", Offset = "0x1517774", VA = "0x1517774")]
		public MissingVariableType()
		{
		}
	}
	[Token(Token = "0x20002C6")]
	public class fsBBParameterProcessor : fsRecoveryProcessor<BBParameter, MissingBBParameterType>
	{
		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x1458748", Offset = "0x1458748", VA = "0x1458748", Slot = "8")]
		public override void OnBeforeDeserializeAfterInstanceCreation(Type storageType, object instance, ref fsData data)
		{
		}

		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x1459184", Offset = "0x1459184", VA = "0x1459184")]
		public fsBBParameterProcessor()
		{
		}
	}
}
namespace ParadoxNotion
{
	[Token(Token = "0x20002C7")]
	public enum CompareMethod
	{
		[Token(Token = "0x4000607")]
		EqualTo,
		[Token(Token = "0x4000608")]
		GreaterThan,
		[Token(Token = "0x4000609")]
		LessThan,
		[Token(Token = "0x400060A")]
		GreaterOrEqualTo,
		[Token(Token = "0x400060B")]
		LessOrEqualTo
	}
	[Token(Token = "0x20002C8")]
	public enum OperationMethod
	{
		[Token(Token = "0x400060D")]
		Set,
		[Token(Token = "0x400060E")]
		Add,
		[Token(Token = "0x400060F")]
		Subtract,
		[Token(Token = "0x4000610")]
		Multiply,
		[Token(Token = "0x4000611")]
		Divide
	}
	[Token(Token = "0x20002C9")]
	public enum ButtonKeys
	{
		[Token(Token = "0x4000613")]
		Left,
		[Token(Token = "0x4000614")]
		Right,
		[Token(Token = "0x4000615")]
		Middle
	}
	[Token(Token = "0x20002CA")]
	public enum PressTypes
	{
		[Token(Token = "0x4000617")]
		Down,
		[Token(Token = "0x4000618")]
		Up,
		[Token(Token = "0x4000619")]
		Pressed
	}
	[Token(Token = "0x20002CB")]
	public enum MouseClickEvent
	{
		[Token(Token = "0x400061B")]
		MouseDown,
		[Token(Token = "0x400061C")]
		MouseUp
	}
	[Token(Token = "0x20002CC")]
	public enum TriggerTypes
	{
		[Token(Token = "0x400061E")]
		TriggerEnter,
		[Token(Token = "0x400061F")]
		TriggerExit,
		[Token(Token = "0x4000620")]
		TriggerStay
	}
	[Token(Token = "0x20002CD")]
	public enum CollisionTypes
	{
		[Token(Token = "0x4000622")]
		CollisionEnter,
		[Token(Token = "0x4000623")]
		CollisionExit,
		[Token(Token = "0x4000624")]
		CollisionStay
	}
	[Token(Token = "0x20002CE")]
	public enum MouseInteractionTypes
	{
		[Token(Token = "0x4000626")]
		MouseEnter,
		[Token(Token = "0x4000627")]
		MouseExit,
		[Token(Token = "0x4000628")]
		MouseOver
	}
	[Token(Token = "0x20002CF")]
	public enum CompactStatus
	{
		[Token(Token = "0x400062A")]
		Failure,
		[Token(Token = "0x400062B")]
		Success
	}
	[Token(Token = "0x20002D0")]
	public enum PlayDirections
	{
		[Token(Token = "0x400062D")]
		Forward,
		[Token(Token = "0x400062E")]
		Backward,
		[Token(Token = "0x400062F")]
		Toggle
	}
	[Token(Token = "0x20002D1")]
	public enum PlanarDirection
	{
		[Token(Token = "0x4000631")]
		Horizontal,
		[Token(Token = "0x4000632")]
		Vertical,
		[Token(Token = "0x4000633")]
		Auto
	}
	[Token(Token = "0x20002D2")]
	public enum Alignment2x2
	{
		[Token(Token = "0x4000635")]
		Default,
		[Token(Token = "0x4000636")]
		Left,
		[Token(Token = "0x4000637")]
		Right,
		[Token(Token = "0x4000638")]
		Top,
		[Token(Token = "0x4000639")]
		Bottom
	}
	[Token(Token = "0x20002D3")]
	public enum Alignment3x3
	{
		[Token(Token = "0x400063B")]
		TopLeft,
		[Token(Token = "0x400063C")]
		TopCenter,
		[Token(Token = "0x400063D")]
		TopRight,
		[Token(Token = "0x400063E")]
		MiddleLeft,
		[Token(Token = "0x400063F")]
		MiddleCenter,
		[Token(Token = "0x4000640")]
		MiddleRight,
		[Token(Token = "0x4000641")]
		BottomLeft,
		[Token(Token = "0x4000642")]
		BottomCenter,
		[Token(Token = "0x4000643")]
		BottomRight
	}
	[Token(Token = "0x20002D4")]
	public class EventData
	{
		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA3B4", Offset = "0x9EA3B4")]
		private string <name>k__BackingField;

		[Token(Token = "0x17000165")]
		public string name
		{
			[Token(Token = "0x6000BE6")]
			[Address(RVA = "0x13690D4", Offset = "0x13690D4", VA = "0x13690D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EBB5C", Offset = "0x9EBB5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE7")]
			[Address(RVA = "0x13690DC", Offset = "0x13690DC", VA = "0x13690DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EBB6C", Offset = "0x9EBB6C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000166")]
		public object value
		{
			[Token(Token = "0x6000BE8")]
			[Address(RVA = "0x13690E4", Offset = "0x13690E4", VA = "0x13690E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x13690F0", Offset = "0x13690F0", VA = "0x13690F0", Slot = "4")]
		protected virtual object GetValue()
		{
			return null;
		}

		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x13690F8", Offset = "0x13690F8", VA = "0x13690F8")]
		public EventData(string name)
		{
		}
	}
	[Token(Token = "0x20002D5")]
	public class EventData<T> : EventData
	{
		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA3C4", Offset = "0x9EA3C4")]
		private T <value>k__BackingField;

		[Token(Token = "0x17000167")]
		public new T value
		{
			[Token(Token = "0x6000BEB")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EBB7C", Offset = "0x9EBB7C")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000BEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EBB8C", Offset = "0x9EBB8C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000BED")]
		protected override object GetValue()
		{
			return null;
		}

		[Token(Token = "0x6000BEE")]
		public EventData(string name, T value)
		{
		}
	}
	[Token(Token = "0x20002D6")]
	public class HierarchyTree
	{
		[Token(Token = "0x20002D7")]
		public class Element
		{
			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object reference;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Element parent;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<Element> children;

			[Token(Token = "0x6000BF0")]
			[Address(RVA = "0x1469C28", Offset = "0x1469C28", VA = "0x1469C28")]
			public Element(object reference)
			{
			}

			[Token(Token = "0x6000BF1")]
			[Address(RVA = "0x1469C5C", Offset = "0x1469C5C", VA = "0x1469C5C")]
			public void AddChild(Element child)
			{
			}

			[Token(Token = "0x6000BF2")]
			[Address(RVA = "0x1469D2C", Offset = "0x1469D2C", VA = "0x1469D2C")]
			public void RemoveChild(Element child)
			{
			}

			[Token(Token = "0x6000BF3")]
			[Address(RVA = "0x1469D9C", Offset = "0x1469D9C", VA = "0x1469D9C")]
			public Element GetRoot()
			{
				return null;
			}

			[Token(Token = "0x6000BF4")]
			[Address(RVA = "0x1469DA8", Offset = "0x1469DA8", VA = "0x1469DA8")]
			public Element FindReferenceElement(object target)
			{
				return null;
			}

			[Token(Token = "0x6000BF5")]
			public T GetFirstParentReferenceOfType<T>()
			{
				return (T)null;
			}

			[Token(Token = "0x6000BF6")]
			public List<T> GetAllChildrenReferencesOfType<T>()
			{
				return null;
			}
		}

		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x150F09C", Offset = "0x150F09C", VA = "0x150F09C")]
		public HierarchyTree()
		{
		}
	}
	[Token(Token = "0x20002D8")]
	public static class OperationTools
	{
		[Token(Token = "0x6000BF7")]
		[Address(RVA = "0x151C518", Offset = "0x151C518", VA = "0x151C518")]
		public static string GetOperationString(OperationMethod om)
		{
			return null;
		}

		[Token(Token = "0x6000BF8")]
		[Address(RVA = "0x151C5BC", Offset = "0x151C5BC", VA = "0x151C5BC")]
		public static float Operate(float a, float b, OperationMethod om, float delta = 1f)
		{
			return default(float);
		}

		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x151C618", Offset = "0x151C618", VA = "0x151C618")]
		public static int Operate(int a, int b, OperationMethod om)
		{
			return default(int);
		}

		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x151C664", Offset = "0x151C664", VA = "0x151C664")]
		public static Vector3 Operate(Vector3 a, Vector3 b, OperationMethod om, float delta = 1f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x151C704", Offset = "0x151C704", VA = "0x151C704")]
		public static string GetCompareString(CompareMethod cm)
		{
			return null;
		}

		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x151C7A8", Offset = "0x151C7A8", VA = "0x151C7A8")]
		public static bool Compare(float a, float b, CompareMethod cm, float floatingPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x151C814", Offset = "0x151C814", VA = "0x151C814")]
		public static bool Compare(int a, int b, CompareMethod cm)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20002D9")]
	public static class ReflectionTools
	{
		[Token(Token = "0x20002DA")]
		public enum MethodType
		{
			[Token(Token = "0x4000662")]
			Normal,
			[Token(Token = "0x4000663")]
			PropertyAccessor,
			[Token(Token = "0x4000664")]
			Event,
			[Token(Token = "0x4000665")]
			Operator
		}

		[Token(Token = "0x20002DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8D60", Offset = "0x9E8D60")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool includeObsolete;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<Type, bool> <>9__2;

			[Token(Token = "0x6000C51")]
			[Address(RVA = "0x26A6098", Offset = "0x26A6098", VA = "0x26A6098")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6000C52")]
			[Address(RVA = "0x26A60A0", Offset = "0x26A60A0", VA = "0x26A60A0")]
			internal bool <GetAllTypes>b__2(Type t)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20002DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8D70", Offset = "0x9E8D70")]
		private sealed class <>c
		{
			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Type, string> <>9__14_0;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Type, string> <>9__14_1;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<ParameterInfo, Type> <>9__83_0;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<ParameterInfo, Type> <>9__90_0;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<ConstructorInfo, bool> <>9__105_0;

			[Token(Token = "0x6000C54")]
			[Address(RVA = "0x26A5F64", Offset = "0x26A5F64", VA = "0x26A5F64")]
			public <>c()
			{
			}

			[Token(Token = "0x6000C55")]
			[Address(RVA = "0x26A5F6C", Offset = "0x26A5F6C", VA = "0x26A5F6C")]
			internal string <GetAllTypes>b__14_0(Type t)
			{
				return null;
			}

			[Token(Token = "0x6000C56")]
			[Address(RVA = "0x26A5FD4", Offset = "0x26A5FD4", VA = "0x26A5FD4")]
			internal string <GetAllTypes>b__14_1(Type t)
			{
				return null;
			}

			[Token(Token = "0x6000C57")]
			[Address(RVA = "0x26A5FF8", Offset = "0x26A5FF8", VA = "0x26A5FF8")]
			internal Type <RTCreateDelegate>b__83_0(ParameterInfo p)
			{
				return null;
			}

			[Token(Token = "0x6000C58")]
			[Address(RVA = "0x26A6018", Offset = "0x26A6018", VA = "0x26A6018")]
			internal Type <GetBaseDefinition>b__90_0(ParameterInfo p)
			{
				return null;
			}

			[Token(Token = "0x6000C59")]
			[Address(RVA = "0x26A6038", Offset = "0x26A6038", VA = "0x26A6038")]
			internal bool <IsAllowedByGenericArgument>b__105_0(ConstructorInfo info)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000649")]
		public const BindingFlags FLAGS_ALL = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;

		[Token(Token = "0x400064A")]
		public const BindingFlags FLAGS_ALL_DECLARED = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Assembly[] _loadedAssemblies;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<string, Type> typeMap;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Type[] _allTypes;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Dictionary<Type, Type[]> _subTypesMap;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static object[] _tempArgs;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly Dictionary<string, string> op_FriendlyNamesLong;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly Dictionary<string, string> op_FriendlyNamesShort;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly Dictionary<string, string> op_CSharpAliases;

		[Token(Token = "0x4000653")]
		public const string METHOD_SPECIAL_NAME_GET = "get_";

		[Token(Token = "0x4000654")]
		public const string METHOD_SPECIAL_NAME_SET = "set_";

		[Token(Token = "0x4000655")]
		public const string METHOD_SPECIAL_NAME_ADD = "add_";

		[Token(Token = "0x4000656")]
		public const string METHOD_SPECIAL_NAME_REMOVE = "remove_";

		[Token(Token = "0x4000657")]
		public const string METHOD_SPECIAL_NAME_OP = "op_";

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Dictionary<MethodBase, string> cacheSignatures;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static Dictionary<Type, ConstructorInfo[]> _typeConstructors;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static Dictionary<Type, MethodInfo[]> _typeMethods;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static Dictionary<Type, FieldInfo[]> _typeFields;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static Dictionary<Type, PropertyInfo[]> _typeProperties;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static Dictionary<Type, EventInfo[]> _typeEvents;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static Dictionary<Type, object[]> _typeAttributes;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static Dictionary<MemberInfo, object[]> _memberAttributes;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static Dictionary<Type, MethodInfo[]> _typeExtensions;

		[Token(Token = "0x17000168")]
		private static Assembly[] loadedAssemblies
		{
			[Token(Token = "0x6000BFE")]
			[Address(RVA = "0x1BB8500", Offset = "0x1BB8500", VA = "0x1BB8500")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x1BB85D8", Offset = "0x1BB85D8", VA = "0x1BB85D8")]
		public static Type GetType(string typeFullName)
		{
			return null;
		}

		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x1BB8A40", Offset = "0x1BB8A40", VA = "0x1BB8A40")]
		public static Type GetType(string typeFullName, Type fallbackAssignable)
		{
			return null;
		}

		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x1BB8640", Offset = "0x1BB8640", VA = "0x1BB8640")]
		public static Type GetType(string typeFullName, bool fallbackNoNamespace = false, [Optional] Type fallbackAssignable)
		{
			return null;
		}

		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x1BB8AB4", Offset = "0x1BB8AB4", VA = "0x1BB8AB4")]
		private static Type GetTypeDirect(string typeFullName)
		{
			return null;
		}

		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x1BB8CFC", Offset = "0x1BB8CFC", VA = "0x1BB8CFC")]
		private static Type TryResolveGenericType(string typeFullName, bool fallbackNoNamespace = false, [Optional] Type fallbackAssignable)
		{
			return null;
		}

		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x1BB93DC", Offset = "0x1BB93DC", VA = "0x1BB93DC")]
		private static Type TryResolveDeserializeFromAttribute(string typeName)
		{
			return null;
		}

		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x1BB9500", Offset = "0x1BB9500", VA = "0x1BB9500")]
		private static Type TryResolveWithoutNamespace(string typeName, [Optional] Type fallbackAssignable)
		{
			return null;
		}

		[Token(Token = "0x6000C06")]
		[Address(RVA = "0x1BB972C", Offset = "0x1BB972C", VA = "0x1BB972C")]
		public static Type[] GetAllTypes(bool includeObsolete)
		{
			return null;
		}

		[Token(Token = "0x6000C07")]
		[Address(RVA = "0x1BB9C78", Offset = "0x1BB9C78", VA = "0x1BB9C78")]
		public static Type[] GetImplementationsOf(Type baseType)
		{
			return null;
		}

		[Token(Token = "0x6000C08")]
		[Address(RVA = "0x1BB9F00", Offset = "0x1BB9F00", VA = "0x1BB9F00")]
		public static object[] SingleTempArgsArray(object arg)
		{
			return null;
		}

		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x1BB9FCC", Offset = "0x1BB9FCC", VA = "0x1BB9FCC")]
		public static MethodType GetMethodSpecialType(this MethodBase method)
		{
			return default(MethodType);
		}

		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x1BAF498", Offset = "0x1BAF498", VA = "0x1BAF498")]
		public static string FriendlyName(this Type t, bool compileSafe = false)
		{
			return null;
		}

		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0x1BBA170", Offset = "0x1BBA170", VA = "0x1BBA170")]
		public static string FriendlyName(this MemberInfo info)
		{
			return null;
		}

		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0x1BBA2F8", Offset = "0x1BBA2F8", VA = "0x1BBA2F8")]
		public static string FriendlyName(this MethodBase method)
		{
			return null;
		}

		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x1BB55EC", Offset = "0x1BB55EC", VA = "0x1BB55EC")]
		public static string FriendlyName(this MethodBase method, out MethodType specialNameType)
		{
			return null;
		}

		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0x1BBA428", Offset = "0x1BBA428", VA = "0x1BBA428")]
		public static string SignatureName(this MethodBase method)
		{
			return null;
		}

		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x1BB70C0", Offset = "0x1BB70C0", VA = "0x1BB70C0")]
		public static Type RTReflectedOrDeclaredType(this MemberInfo member)
		{
			return null;
		}

		[Token(Token = "0x6000C10")]
		[Address(RVA = "0x1BB9C58", Offset = "0x1BB9C58", VA = "0x1BB9C58")]
		public static bool RTIsAssignableFrom(this Type type, Type other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C11")]
		[Address(RVA = "0x1BBA914", Offset = "0x1BBA914", VA = "0x1BBA914")]
		public static bool RTIsAssignableTo(this Type type, Type other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C12")]
		[Address(RVA = "0x1BB9EE8", Offset = "0x1BB9EE8", VA = "0x1BB9EE8")]
		public static bool RTIsAbstract(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x1BB4854", Offset = "0x1BB4854", VA = "0x1BB4854")]
		public static bool RTIsValueType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C14")]
		[Address(RVA = "0x1BB67C4", Offset = "0x1BB67C4", VA = "0x1BB67C4")]
		public static bool RTIsArray(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C15")]
		[Address(RVA = "0x1BBA998", Offset = "0x1BBA998", VA = "0x1BBA998")]
		public static bool RTIsInterface(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C16")]
		[Address(RVA = "0x1BB7F3C", Offset = "0x1BB7F3C", VA = "0x1BB7F3C")]
		public static bool RTIsSubclassOf(this Type type, Type other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C17")]
		[Address(RVA = "0x1BBA110", Offset = "0x1BBA110", VA = "0x1BBA110")]
		public static bool RTIsGenericParameter(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x1BBA130", Offset = "0x1BBA130", VA = "0x1BBA130")]
		public static bool RTIsGenericType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x1BBA9B0", Offset = "0x1BBA9B0", VA = "0x1BBA9B0")]
		public static MethodInfo RTGetGetMethod(this PropertyInfo prop)
		{
			return null;
		}

		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x1BBA9C8", Offset = "0x1BBA9C8", VA = "0x1BBA9C8")]
		public static MethodInfo RTGetSetMethod(this PropertyInfo prop)
		{
			return null;
		}

		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0x1BBA9E0", Offset = "0x1BBA9E0", VA = "0x1BBA9E0")]
		public static MethodInfo RTGetDelegateMethodInfo(this Delegate del)
		{
			return null;
		}

		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0x1BB2688", Offset = "0x1BB2688", VA = "0x1BB2688")]
		public static Type RTMakeGenericType(this Type type, params Type[] typeArgs)
		{
			return null;
		}

		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x1BBA150", Offset = "0x1BBA150", VA = "0x1BBA150")]
		public static Type[] RTGetGenericArguments(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x1BBA9F8", Offset = "0x1BBA9F8", VA = "0x1BBA9F8")]
		public static Type[] RTGetEmptyTypes()
		{
			return null;
		}

		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x1BB67DC", Offset = "0x1BB67DC", VA = "0x1BB67DC")]
		public static Type RTGetElementType(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x1BB6874", Offset = "0x1BB6874", VA = "0x1BB6874")]
		public static bool RTIsByRef(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x1BBAA5C", Offset = "0x1BBAA5C", VA = "0x1BBAA5C")]
		public static object CreateObject(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x1BBAAE4", Offset = "0x1BBAAE4", VA = "0x1BBAAE4")]
		public static object CreateObjectUninitialized(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x1BBAB98", Offset = "0x1BBAB98", VA = "0x1BBAB98")]
		public static ConstructorInfo RTGetDefaultConstructor(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C24")]
		[Address(RVA = "0x1BBAD9C", Offset = "0x1BBAD9C", VA = "0x1BBAD9C")]
		public static ConstructorInfo RTGetConstructor(this Type type, Type[] paramTypes)
		{
			return null;
		}

		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x1BB7F5C", Offset = "0x1BB7F5C", VA = "0x1BB7F5C")]
		public static MethodInfo RTGetMethod(this Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x1BBB058", Offset = "0x1BBB058", VA = "0x1BBB058")]
		public static MethodInfo RTGetMethod(this Type type, string name, Type[] paramTypes)
		{
			return null;
		}

		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x1BBB228", Offset = "0x1BBB228", VA = "0x1BBB228")]
		public static FieldInfo RTGetField(this Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x6000C28")]
		[Address(RVA = "0x1BBB430", Offset = "0x1BBB430", VA = "0x1BBB430")]
		public static PropertyInfo RTGetProperty(this Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x1BBB638", Offset = "0x1BBB638", VA = "0x1BBB638")]
		public static EventInfo RTGetEvent(this Type type, string name)
		{
			return null;
		}

		[Token(Token = "0x6000C2A")]
		[Address(RVA = "0x1BBAC84", Offset = "0x1BBAC84", VA = "0x1BBAC84")]
		public static ConstructorInfo[] RTGetConstructors(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0x1BBAF40", Offset = "0x1BBAF40", VA = "0x1BBAF40")]
		public static MethodInfo[] RTGetMethods(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0x1BBB318", Offset = "0x1BBB318", VA = "0x1BBB318")]
		public static FieldInfo[] RTGetFields(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x1BBB520", Offset = "0x1BBB520", VA = "0x1BBB520")]
		public static PropertyInfo[] RTGetProperties(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0x1BBB728", Offset = "0x1BBB728", VA = "0x1BBB728")]
		public static EventInfo[] RTGetEvents(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C2F")]
		public static bool RTIsDefined<T>(this Type type, bool inherited) where T : Attribute
		{
			return default(bool);
		}

		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x1BBB840", Offset = "0x1BBB840", VA = "0x1BBB840")]
		public static bool RTIsDefined(this Type type, Type attributeType, bool inherited)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C31")]
		public static bool RTIsDefined<T>(this MemberInfo member, bool inherited) where T : Attribute
		{
			return default(bool);
		}

		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x1BBB864", Offset = "0x1BBB864", VA = "0x1BBB864")]
		public static bool RTIsDefined(this MemberInfo member, Type attributeType, bool inherited)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C33")]
		public static T RTGetAttribute<T>(this Type type, bool inherited) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000C34")]
		public static T RTGetAttribute<T>(this MemberInfo member, bool inherited) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000C35")]
		public static T[] RTGetAttributesRecursive<T>(this Type type) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x1BBB888", Offset = "0x1BBB888", VA = "0x1BBB888")]
		public static ParameterInfo[] RTGetDelegateTypeParameters(this Type delegateType)
		{
			return null;
		}

		[Token(Token = "0x6000C37")]
		public static T RTCreateDelegate<T>(this MethodInfo method, object instance)
		{
			return (T)null;
		}

		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x1BB325C", Offset = "0x1BB325C", VA = "0x1BB325C")]
		public static Delegate RTCreateDelegate(this MethodInfo method, Type type, object instance)
		{
			return null;
		}

		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x1BBBA08", Offset = "0x1BBBA08", VA = "0x1BBBA08")]
		public static Delegate ConvertDelegate(Delegate originalDelegate, Type targetDelegateType)
		{
			return null;
		}

		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x1BBBA48", Offset = "0x1BBBA48", VA = "0x1BBBA48")]
		public static bool IsReadOnly(this FieldInfo field)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x1BB3A78", Offset = "0x1BB3A78", VA = "0x1BB3A78")]
		public static bool IsConstant(this FieldInfo field)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x1BBBA90", Offset = "0x1BBBA90", VA = "0x1BBBA90")]
		public static bool IsStatic(this EventInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x1BAFA00", Offset = "0x1BAFA00", VA = "0x1BAFA00")]
		public static bool IsParams(this ParameterInfo parameter, ParameterInfo[] parameters)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x1BBBAE8", Offset = "0x1BBBAE8", VA = "0x1BBBAE8")]
		public static bool IsObsolete(this MemberInfo member, bool inherited = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x1BBBD3C", Offset = "0x1BBBD3C", VA = "0x1BBBD3C")]
		public static PropertyInfo GetBaseDefinition(this PropertyInfo propertyInfo)
		{
			return null;
		}

		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x1BB3C80", Offset = "0x1BB3C80", VA = "0x1BB3C80")]
		public static FieldInfo GetBaseDefinition(this FieldInfo fieldInfo)
		{
			return null;
		}

		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x1BBBFA8", Offset = "0x1BBBFA8", VA = "0x1BBBFA8")]
		public static MethodInfo[] GetExtensionMethods(this Type targetType)
		{
			return null;
		}

		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x1BB5AD8", Offset = "0x1BB5AD8", VA = "0x1BB5AD8")]
		public static bool IsExtensionMethod(this MethodInfo method)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x1BBBC04", Offset = "0x1BBBC04", VA = "0x1BBBC04")]
		public static bool IsPropertyAccessor(this MethodInfo method)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x1BBC31C", Offset = "0x1BBC31C", VA = "0x1BBC31C")]
		public static bool IsIndexerProperty(this PropertyInfo property)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x1BBC354", Offset = "0x1BBC354", VA = "0x1BBC354")]
		public static bool IsAutoProperty(this PropertyInfo property)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x1BBBC70", Offset = "0x1BBBC70", VA = "0x1BBBC70")]
		public static PropertyInfo GetAccessorProperty(this MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x1BBC478", Offset = "0x1BBC478", VA = "0x1BBC478")]
		public static bool IsEnumerableCollection(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C48")]
		[Address(RVA = "0x1BAFAE4", Offset = "0x1BAFAE4", VA = "0x1BAFAE4")]
		public static Type GetEnumerableElementType(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x1BBC5F4", Offset = "0x1BBC5F4", VA = "0x1BBC5F4")]
		public static Type GetFirstGenericParameterConstraintType(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x1BB5E3C", Offset = "0x1BB5E3C", VA = "0x1BB5E3C")]
		public static Type GetFirstGenericParameterConstraintType(this MethodInfo method)
		{
			return null;
		}

		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0x1BBC7B4", Offset = "0x1BBC7B4", VA = "0x1BBC7B4")]
		public static bool CanBeMadeGenericWith(this Type def, Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0x1BBCD0C", Offset = "0x1BBCD0C", VA = "0x1BBCD0C")]
		public static bool CanBeMadeGenericWith(this MethodInfo def, Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x1BBC8FC", Offset = "0x1BBC8FC", VA = "0x1BBC8FC")]
		public static bool IsAllowedByGenericArgument(this Type type, Type genericArgument)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x1BBCE10", Offset = "0x1BBCE10", VA = "0x1BBCE10")]
		public static Array Resize(this Array array, int newSize)
		{
			return null;
		}

		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x1BBCEFC", Offset = "0x1BBCEFC", VA = "0x1BBCEFC")]
		public static bool CanConvert(Type fromType, Type toType, out UnaryExpression exp)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20002DD")]
	public static class TypeConverter
	{
		[Token(Token = "0x20002DE")]
		public delegate Func<object, object> CustomConverter(Type fromType, Type toType);

		[Token(Token = "0x20002DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8D80", Offset = "0x9E8D80")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type toType;

			[Token(Token = "0x6000C62")]
			[Address(RVA = "0x26A7F70", Offset = "0x26A7F70", VA = "0x26A7F70")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000C63")]
			[Address(RVA = "0x26A7F78", Offset = "0x26A7F78", VA = "0x26A7F78")]
			internal object <Get>b__2(object value)
			{
				return null;
			}

			[Token(Token = "0x6000C64")]
			[Address(RVA = "0x26A80D0", Offset = "0x26A80D0", VA = "0x26A80D0")]
			internal object <Get>b__4(object value)
			{
				return null;
			}

			[Token(Token = "0x6000C65")]
			[Address(RVA = "0x26A81B4", Offset = "0x26A81B4", VA = "0x26A81B4")]
			internal object <Get>b__6(object value)
			{
				return null;
			}

			[Token(Token = "0x6000C66")]
			[Address(RVA = "0x26A82D0", Offset = "0x26A82D0", VA = "0x26A82D0")]
			internal object <Get>b__7(object value)
			{
				return null;
			}

			[Token(Token = "0x6000C67")]
			[Address(RVA = "0x26A83B4", Offset = "0x26A83B4", VA = "0x26A83B4")]
			internal object <Get>b__8(object value)
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x20002E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8D90", Offset = "0x9E8D90")]
		private sealed class <>c
		{
			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<object, object> <>9__4_0;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<object, object> <>9__4_1;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<object, object> <>9__4_3;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<object, object> <>9__4_5;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<object, object> <>9__4_9;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Func<object, object> <>9__4_10;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Func<object, object> <>9__4_11;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Func<object, object> <>9__4_12;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static Func<object, object> <>9__4_13;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static Func<object, object> <>9__4_14;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static Func<object, object> <>9__4_15;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static Func<object, object> <>9__4_16;

			[Token(Token = "0x6000C69")]
			[Address(RVA = "0x26A763C", Offset = "0x26A763C", VA = "0x26A763C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000C6A")]
			[Address(RVA = "0x26A7644", Offset = "0x26A7644", VA = "0x26A7644")]
			internal object <Get>b__4_0(object value)
			{
				return null;
			}

			[Token(Token = "0x6000C6B")]
			[Address(RVA = "0x26A764C", Offset = "0x26A764C", VA = "0x26A764C")]
			internal object <Get>b__4_1(object value)
			{
				return null;
			}

			[Token(Token = "0x6000C6C")]
			[Address(RVA = "0x26A76AC", Offset = "0x26A76AC", VA = "0x26A76AC")]
			internal object <Get>b__4_3(object value)
			{
				return null;
			}

			[Token(Token = "0x6000C6D")]
			[Address(RVA = "0x26A7710", Offset = "0x26A7710", VA = "0x26A7710")]
			internal object <Get>b__4_5(object value)
			{
				return null;
			}

			[Token(Token = "0x6000C6E")]
			[Address(RVA = "0x26A7810", Offset = "0x26A7810", VA = "0x26A7810")]
			internal object <Get>b__4_9(object value)
			{
				return null;
			}

			[Token(Token = "0x6000C6F")]
			[Address(RVA = "0x26A7924", Offset = "0x26A7924", VA = "0x26A7924")]
			internal object <Get>b__4_10(object value)
			{
				return null;
			}

			[Token(Token = "0x6000C70")]
			[Address(RVA = "0x26A7A64", Offset = "0x26A7A64", VA = "0x26A7A64")]
			internal object <Get>b__4_11(object value)
			{
				return null;
			}

			[Token(Token = "0x6000C71")]
			[Address(RVA = "0x26A7B7C", Offset = "0x26A7B7C", VA = "0x26A7B7C")]
			internal object <Get>b__4_12(object value)
			{
				return null;
			}

			[Token(Token = "0x6000C72")]
			[Address(RVA = "0x26A7CC0", Offset = "0x26A7CC0", VA = "0x26A7CC0")]
			internal object <Get>b__4_13(object value)
			{
				return null;
			}

			[Token(Token = "0x6000C73")]
			[Address(RVA = "0x26A7D78", Offset = "0x26A7D78", VA = "0x26A7D78")]
			internal object <Get>b__4_14(object value)
			{
				return null;
			}

			[Token(Token = "0x6000C74")]
			[Address(RVA = "0x26A7E2C", Offset = "0x26A7E2C", VA = "0x26A7E2C")]
			internal object <Get>b__4_15(object value)
			{
				return null;
			}

			[Token(Token = "0x6000C75")]
			[Address(RVA = "0x26A7ED0", Offset = "0x26A7ED0", VA = "0x26A7ED0")]
			internal object <Get>b__4_16(object value)
			{
				return null;
			}
		}

		[Token(Token = "0x14000012")]
		public static event CustomConverter customConverter
		{
			[Token(Token = "0x6000C5A")]
			[Address(RVA = "0x144FB20", Offset = "0x144FB20", VA = "0x144FB20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EBFDC", Offset = "0x9EBFDC")]
			add
			{
			}
			[Token(Token = "0x6000C5B")]
			[Address(RVA = "0x144FBDC", Offset = "0x144FBDC", VA = "0x144FBDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EBFEC", Offset = "0x9EBFEC")]
			remove
			{
			}
		}

		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x144FC98", Offset = "0x144FC98", VA = "0x144FC98")]
		public static Func<object, object> Get(Type fromType, Type toType)
		{
			return null;
		}

		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x1450FDC", Offset = "0x1450FDC", VA = "0x1450FDC")]
		public static bool CanConvert(Type fromType, Type toType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20002E1")]
	public static class ColorUtils
	{
		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Color32, string> colorHexCache;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<string, Color> hexColorCache;

		[Token(Token = "0x6000C76")]
		[Address(RVA = "0x1363380", Offset = "0x1363380", VA = "0x1363380")]
		public static Color WithAlpha(this Color color, float alpha)
		{
			return default(Color);
		}

		[Token(Token = "0x6000C77")]
		[Address(RVA = "0x1363388", Offset = "0x1363388", VA = "0x1363388")]
		public static string ColorToHex(Color32 color)
		{
			return null;
		}

		[Token(Token = "0x6000C78")]
		[Address(RVA = "0x1363534", Offset = "0x1363534", VA = "0x1363534")]
		public static Color HexToColor(string hex)
		{
			return default(Color);
		}
	}
	[Token(Token = "0x20002E2")]
	public static class CurveUtils
	{
		[Token(Token = "0x400067F")]
		private const float POS_CHECK_RES = 100f;

		[Token(Token = "0x4000680")]
		private const float POS_CHECK_DISTANCE = 10f;

		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x1365B10", Offset = "0x1365B10", VA = "0x1365B10")]
		public static Vector2 GetPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, float t)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x1365B8C", Offset = "0x1365B8C", VA = "0x1365B8C")]
		public static bool IsPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, Vector2 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x1365BBC", Offset = "0x1365BBC", VA = "0x1365BBC")]
		public static bool IsPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, Vector2 targetPosition, out float norm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x1365D38", Offset = "0x1365D38", VA = "0x1365D38")]
		public static void ResolveTangents(Vector2 from, Vector2 to, float rigidMlt, PlanarDirection direction, out Vector2 fromTangent, out Vector2 toTangent)
		{
		}

		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x1365E44", Offset = "0x1365E44", VA = "0x1365E44")]
		public static void ResolveTangents(Vector2 from, Vector2 to, Rect fromRect, Rect toRect, float rigidMlt, PlanarDirection direction, out Vector2 fromTangent, out Vector2 toTangent)
		{
		}
	}
	[Token(Token = "0x20002E3")]
	public static class GUIStyleUtils
	{
		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0x1371348", Offset = "0x1371348", VA = "0x1371348")]
		public static GUIStyle Margin(this GUIStyle style, int left, int right, int top, int bottom)
		{
			return null;
		}

		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x13713EC", Offset = "0x13713EC", VA = "0x13713EC")]
		public static GUIStyle Padding(this GUIStyle style, int left, int right, int top, int bottom)
		{
			return null;
		}

		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x1371490", Offset = "0x1371490", VA = "0x1371490")]
		public static GUIStyle Border(this GUIStyle style, int left, int right, int top, int bottom)
		{
			return null;
		}

		[Token(Token = "0x6000C82")]
		[Address(RVA = "0x1371534", Offset = "0x1371534", VA = "0x1371534")]
		public static GUIStyle Overflow(this GUIStyle style, int left, int right, int top, int bottom)
		{
			return null;
		}

		[Token(Token = "0x6000C83")]
		[Address(RVA = "0x13715D8", Offset = "0x13715D8", VA = "0x13715D8")]
		public static GUIStyle TextAlignment(this GUIStyle style, TextAnchor anchor)
		{
			return null;
		}

		[Token(Token = "0x6000C84")]
		[Address(RVA = "0x1371608", Offset = "0x1371608", VA = "0x1371608")]
		public static GUIStyle RichText(this GUIStyle style, bool rich)
		{
			return null;
		}
	}
	[Token(Token = "0x20002E4")]
	public static class RectUtils
	{
		[Token(Token = "0x6000C85")]
		[Address(RVA = "0x1BB1168", Offset = "0x1BB1168", VA = "0x1BB1168")]
		public static Rect GetBoundRect(params Rect[] rects)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000C86")]
		[Address(RVA = "0x1BB12C8", Offset = "0x1BB12C8", VA = "0x1BB12C8")]
		public static Rect GetBoundRect(params Vector2[] positions)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000C87")]
		[Address(RVA = "0x1BB13F4", Offset = "0x1BB13F4", VA = "0x1BB13F4")]
		public static bool Encapsulates(this Rect a, Rect b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C88")]
		[Address(RVA = "0x1BB14BC", Offset = "0x1BB14BC", VA = "0x1BB14BC")]
		public static Rect ExpandBy(this Rect rect, float margin)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000C89")]
		[Address(RVA = "0x1BB14CC", Offset = "0x1BB14CC", VA = "0x1BB14CC")]
		public static Rect ExpandBy(this Rect rect, float xMargin, float yMargin)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000C8A")]
		[Address(RVA = "0x1BB14D8", Offset = "0x1BB14D8", VA = "0x1BB14D8")]
		public static Rect ExpandBy(this Rect rect, float left, float top, float right, float bottom)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000C8B")]
		[Address(RVA = "0x1BB1580", Offset = "0x1BB1580", VA = "0x1BB1580")]
		public static Rect TransformSpace(this Rect rect, Rect oldContainer, Rect newContainer)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0x1BB17CC", Offset = "0x1BB17CC", VA = "0x1BB17CC")]
		public static Vector2 TransformSpace(this Vector2 vector, Rect oldContainer, Rect newContainer)
		{
			return default(Vector2);
		}
	}
	[Token(Token = "0x20002E5")]
	public static class StringUtils
	{
		[Token(Token = "0x4000681")]
		private const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly char[] CHAR_EMPTY_ARRAY;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<string, string> splitCaseCache;

		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0x1BB58FC", Offset = "0x1BB58FC", VA = "0x1BB58FC")]
		public static string SplitCamelCase(this string s)
		{
			return null;
		}

		[Token(Token = "0x6000C8E")]
		[Address(RVA = "0x1BBA36C", Offset = "0x1BBA36C", VA = "0x1BBA36C")]
		public static string CapitalizeFirst(this string s)
		{
			return null;
		}

		[Token(Token = "0x6000C8F")]
		[Address(RVA = "0x1BC1910", Offset = "0x1BC1910", VA = "0x1BC1910")]
		public static string CapLength(this string s, int max)
		{
			return null;
		}

		[Token(Token = "0x6000C90")]
		[Address(RVA = "0x1BC19C8", Offset = "0x1BC19C8", VA = "0x1BC19C8")]
		public static string GetCapitals(this string s)
		{
			return null;
		}

		[Token(Token = "0x6000C91")]
		[Address(RVA = "0x1BC1B08", Offset = "0x1BC1B08", VA = "0x1BC1B08")]
		public static string GetAlphabetLetter(int index)
		{
			return null;
		}

		[Token(Token = "0x6000C92")]
		[Address(RVA = "0x1BC1BAC", Offset = "0x1BC1BAC", VA = "0x1BC1BAC")]
		public static string GetStringWithin(this string input, string from, string to)
		{
			return null;
		}

		[Token(Token = "0x6000C93")]
		[Address(RVA = "0x1BC1C8C", Offset = "0x1BC1C8C", VA = "0x1BC1C8C")]
		public static float ScoreSearchMatch(string input, string leafName, string categoryName = "")
		{
			return default(float);
		}

		[Token(Token = "0x6000C94")]
		[Address(RVA = "0x1BC1F28", Offset = "0x1BC1F28", VA = "0x1BC1F28")]
		public static bool SearchMatch(string input, string leafName, string categoryName = "")
		{
			return default(bool);
		}

		[Token(Token = "0x6000C95")]
		[Address(RVA = "0x1BC2274", Offset = "0x1BC2274", VA = "0x1BC2274")]
		public static string ReplaceWithin(this string text, char startChar, char endChar, Func<string, string> Process)
		{
			return null;
		}

		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x1BC239C", Offset = "0x1BC239C", VA = "0x1BC239C")]
		public static string ToStringAdvanced(this object o)
		{
			return null;
		}
	}
}
namespace ParadoxNotion.Services
{
	[Token(Token = "0x20002E6")]
	public static class Logger
	{
		[Token(Token = "0x20002E7")]
		public struct Message
		{
			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LogType type;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string text;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string tag;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public object context;

			[Token(Token = "0x6000CA5")]
			[Address(RVA = "0x146A818", Offset = "0x146A818", VA = "0x146A818")]
			public bool IsSameAs(Message b)
			{
				return default(bool);
			}

			[Token(Token = "0x6000CA6")]
			[Address(RVA = "0x146A888", Offset = "0x146A888", VA = "0x146A888")]
			public bool IsValid()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20002E8")]
		public delegate bool LogHandler(Message message);

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<LogHandler> subscribers;

		[Token(Token = "0x6000C98")]
		[Address(RVA = "0x151286C", Offset = "0x151286C", VA = "0x151286C")]
		public static void AddListener(LogHandler callback)
		{
		}

		[Token(Token = "0x6000C99")]
		[Address(RVA = "0x15128F8", Offset = "0x15128F8", VA = "0x15128F8")]
		public static void RemoveListener(LogHandler callback)
		{
		}

		[Token(Token = "0x6000C9A")]
		[Address(RVA = "0x1512984", Offset = "0x1512984", VA = "0x1512984")]
		public static void Log(object message, [Optional] Enum tag, [Optional] object context)
		{
		}

		[Token(Token = "0x6000C9B")]
		[Address(RVA = "0x1507A90", Offset = "0x1507A90", VA = "0x1507A90")]
		public static void Log(object message, [Optional] string tag, [Optional] object context)
		{
		}

		[Token(Token = "0x6000C9C")]
		[Address(RVA = "0x1512E50", Offset = "0x1512E50", VA = "0x1512E50")]
		public static void LogWarning(object message, [Optional] Enum tag, [Optional] object context)
		{
		}

		[Token(Token = "0x6000C9D")]
		[Address(RVA = "0x150AC60", Offset = "0x150AC60", VA = "0x150AC60")]
		public static void LogWarning(object message, [Optional] string tag, [Optional] object context)
		{
		}

		[Token(Token = "0x6000C9E")]
		[Address(RVA = "0x1512EEC", Offset = "0x1512EEC", VA = "0x1512EEC")]
		public static void LogError(object message, [Optional] Enum tag, [Optional] object context)
		{
		}

		[Token(Token = "0x6000C9F")]
		[Address(RVA = "0x15086A8", Offset = "0x15086A8", VA = "0x15086A8")]
		public static void LogError(object message, [Optional] string tag, [Optional] object context)
		{
		}

		[Token(Token = "0x6000CA0")]
		[Address(RVA = "0x1512F88", Offset = "0x1512F88", VA = "0x1512F88")]
		public static void LogException(Exception exception, [Optional] Enum tag, [Optional] object context)
		{
		}

		[Token(Token = "0x6000CA1")]
		[Address(RVA = "0x150764C", Offset = "0x150764C", VA = "0x150764C")]
		public static void LogException(Exception exception, [Optional] string tag, [Optional] object context)
		{
		}

		[Token(Token = "0x6000CA2")]
		[Address(RVA = "0x1512A20", Offset = "0x1512A20", VA = "0x1512A20")]
		private static void Internal_Log(LogType type, object message, string tag, object context)
		{
		}

		[Token(Token = "0x6000CA3")]
		[Address(RVA = "0x1513024", Offset = "0x1513024", VA = "0x1513024")]
		private static void ForwardToUnity(LogType type, object message, string tag, object context)
		{
		}
	}
	[Token(Token = "0x20002E9")]
	public class MessageRouter : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IDragHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler
	{
		[Token(Token = "0x20002EA")]
		public class MessageData
		{
			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA3E4", Offset = "0x9EA3E4")]
			private GameObject <receiver>k__BackingField;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA3F4", Offset = "0x9EA3F4")]
			private object <sender>k__BackingField;

			[Token(Token = "0x1700016A")]
			public GameObject receiver
			{
				[Token(Token = "0x6000CDD")]
				[Address(RVA = "0x146AC24", Offset = "0x146AC24", VA = "0x146AC24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC13C", Offset = "0x9EC13C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000CDE")]
				[Address(RVA = "0x146AC2C", Offset = "0x146AC2C", VA = "0x146AC2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC14C", Offset = "0x9EC14C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700016B")]
			public object sender
			{
				[Token(Token = "0x6000CDF")]
				[Address(RVA = "0x146AC34", Offset = "0x146AC34", VA = "0x146AC34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC15C", Offset = "0x9EC15C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000CE0")]
				[Address(RVA = "0x146AC3C", Offset = "0x146AC3C", VA = "0x146AC3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC16C", Offset = "0x9EC16C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000CE1")]
			[Address(RVA = "0x146AC44", Offset = "0x146AC44", VA = "0x146AC44")]
			public MessageData(GameObject receiver, object sender)
			{
			}
		}

		[Token(Token = "0x20002EB")]
		public class MessageData<T> : MessageData
		{
			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA404", Offset = "0x9EA404")]
			private T <value>k__BackingField;

			[Token(Token = "0x1700016C")]
			public T value
			{
				[Token(Token = "0x6000CE2")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC17C", Offset = "0x9EC17C")]
				get
				{
					return (T)null;
				}
				[Token(Token = "0x6000CE3")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC18C", Offset = "0x9EC18C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000CE4")]
			public MessageData(T value, GameObject receiver, object sender)
			{
			}
		}

		[Token(Token = "0x4000689")]
		private const BindingFlags METHOD_FLAGS = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, List<object>> listeners;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private object _animator;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Collider> triggerStayObjects3D;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<Collider2D> triggerStayObjects2D;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Collision> collisionStayObjects3D;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Collision2D> collisionStayObjects2D;

		[Token(Token = "0x17000169")]
		private Animator animator
		{
			[Token(Token = "0x6000CAB")]
			[Address(RVA = "0x151528C", Offset = "0x151528C", VA = "0x151528C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0x1515388", Offset = "0x1515388", VA = "0x1515388", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x1515400", Offset = "0x1515400", VA = "0x1515400", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x1515478", Offset = "0x1515478", VA = "0x1515478", Slot = "6")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x15154F0", Offset = "0x15154F0", VA = "0x15154F0", Slot = "7")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0x1515568", Offset = "0x1515568", VA = "0x1515568", Slot = "8")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x15155E0", Offset = "0x15155E0", VA = "0x15155E0", Slot = "9")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x1515658", Offset = "0x1515658", VA = "0x1515658")]
		public void OnDrop(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000CB3")]
		[Address(RVA = "0x15156D0", Offset = "0x15156D0", VA = "0x15156D0", Slot = "10")]
		public void OnScroll(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000CB4")]
		[Address(RVA = "0x1515748", Offset = "0x1515748", VA = "0x1515748", Slot = "11")]
		public void OnUpdateSelected(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000CB5")]
		[Address(RVA = "0x15157C0", Offset = "0x15157C0", VA = "0x15157C0", Slot = "12")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0x1515838", Offset = "0x1515838", VA = "0x1515838", Slot = "13")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000CB7")]
		[Address(RVA = "0x15158B0", Offset = "0x15158B0", VA = "0x15158B0", Slot = "14")]
		public void OnMove(AxisEventData eventData)
		{
		}

		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0x1515928", Offset = "0x1515928", VA = "0x1515928", Slot = "15")]
		public void OnSubmit(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0x15159A0", Offset = "0x15159A0", VA = "0x15159A0")]
		private void OnMouseDown()
		{
		}

		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0x1515A58", Offset = "0x1515A58", VA = "0x1515A58")]
		private void OnMouseDrag()
		{
		}

		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0x1515AA8", Offset = "0x1515AA8", VA = "0x1515AA8")]
		private void OnMouseEnter()
		{
		}

		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x1515AF8", Offset = "0x1515AF8", VA = "0x1515AF8")]
		private void OnMouseExit()
		{
		}

		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x1515B48", Offset = "0x1515B48", VA = "0x1515B48")]
		private void OnMouseOver()
		{
		}

		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0x1515B98", Offset = "0x1515B98", VA = "0x1515B98")]
		private void OnMouseUp()
		{
		}

		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x1515BE8", Offset = "0x1515BE8", VA = "0x1515BE8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x1515C38", Offset = "0x1515C38", VA = "0x1515C38")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0x1515C88", Offset = "0x1515C88", VA = "0x1515C88")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000CC2")]
		[Address(RVA = "0x1515CD8", Offset = "0x1515CD8", VA = "0x1515CD8")]
		private void OnTransformChildrenChanged()
		{
		}

		[Token(Token = "0x6000CC3")]
		[Address(RVA = "0x1515D28", Offset = "0x1515D28", VA = "0x1515D28")]
		private void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x6000CC4")]
		[Address(RVA = "0x1515D78", Offset = "0x1515D78", VA = "0x1515D78")]
		private void OnAnimatorIK(int layerIndex)
		{
		}

		[Token(Token = "0x6000CC5")]
		[Address(RVA = "0x1515DF0", Offset = "0x1515DF0", VA = "0x1515DF0")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000CC6")]
		[Address(RVA = "0x1515E80", Offset = "0x1515E80", VA = "0x1515E80")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x6000CC7")]
		[Address(RVA = "0x1515ED0", Offset = "0x1515ED0", VA = "0x1515ED0")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x6000CC8")]
		[Address(RVA = "0x1515F20", Offset = "0x1515F20", VA = "0x1515F20")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x6000CC9")]
		[Address(RVA = "0x1515F98", Offset = "0x1515F98", VA = "0x1515F98")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x6000CCA")]
		[Address(RVA = "0x1516010", Offset = "0x1516010", VA = "0x1516010")]
		private void OnCollisionEnter(Collision collisionInfo)
		{
		}

		[Token(Token = "0x6000CCB")]
		[Address(RVA = "0x15160D8", Offset = "0x15160D8", VA = "0x15160D8")]
		private void OnCollisionExit(Collision collisionInfo)
		{
		}

		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0x15161A0", Offset = "0x15161A0", VA = "0x15161A0")]
		private void OnCollisionEnter2D(Collision2D collisionInfo)
		{
		}

		[Token(Token = "0x6000CCD")]
		[Address(RVA = "0x1516268", Offset = "0x1516268", VA = "0x1516268")]
		private void OnCollisionExit2D(Collision2D collisionInfo)
		{
		}

		[Token(Token = "0x6000CCE")]
		[Address(RVA = "0x1516330", Offset = "0x1516330", VA = "0x1516330")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000CCF")]
		[Address(RVA = "0x15163F8", Offset = "0x15163F8", VA = "0x15163F8")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000CD0")]
		[Address(RVA = "0x15164C0", Offset = "0x15164C0", VA = "0x15164C0")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000CD1")]
		[Address(RVA = "0x1516588", Offset = "0x1516588", VA = "0x1516588")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000CD2")]
		private void EnsureListInstance<T>(ref List<T> list)
		{
		}

		[Token(Token = "0x6000CD3")]
		[Address(RVA = "0x1516650", Offset = "0x1516650", VA = "0x1516650")]
		private void Update()
		{
		}

		[Token(Token = "0x6000CD4")]
		[Address(RVA = "0x1516900", Offset = "0x1516900", VA = "0x1516900")]
		public void Register(object target, params string[] messages)
		{
		}

		[Token(Token = "0x6000CD5")]
		[Address(RVA = "0x1516BC8", Offset = "0x1516BC8", VA = "0x1516BC8")]
		public void RegisterCallback(string message, Action callback)
		{
		}

		[Token(Token = "0x6000CD6")]
		public void RegisterCallback<T>(string message, Action<T> callback)
		{
		}

		[Token(Token = "0x6000CD7")]
		[Address(RVA = "0x1516BCC", Offset = "0x1516BCC", VA = "0x1516BCC")]
		private void Internal_RegisterCallback(string message, Delegate callback)
		{
		}

		[Token(Token = "0x6000CD8")]
		[Address(RVA = "0x1516D0C", Offset = "0x1516D0C", VA = "0x1516D0C")]
		public void UnRegister(object target)
		{
		}

		[Token(Token = "0x6000CD9")]
		[Address(RVA = "0x1517000", Offset = "0x1517000", VA = "0x1517000")]
		public void UnRegister(object target, params string[] messages)
		{
		}

		[Token(Token = "0x6000CDA")]
		[Address(RVA = "0x15159F0", Offset = "0x15159F0", VA = "0x15159F0")]
		public bool Dispatch(string message, [Optional] object sender)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CDB")]
		public bool Dispatch<T>(string message, T arg, [Optional] object sender)
		{
			return default(bool);
		}

		[Token(Token = "0x6000CDC")]
		[Address(RVA = "0x1517214", Offset = "0x1517214", VA = "0x1517214")]
		public MessageRouter()
		{
		}
	}
	[Token(Token = "0x20002EC")]
	public class MonoManager : MonoBehaviour
	{
		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA474", Offset = "0x9EA474")]
		private static bool <isQuiting>k__BackingField;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static MonoManager _current;

		[Token(Token = "0x1700016D")]
		public static bool isQuiting
		{
			[Token(Token = "0x6000CF1")]
			[Address(RVA = "0x1517CC0", Offset = "0x1517CC0", VA = "0x1517CC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC25C", Offset = "0x9EC25C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CF2")]
			[Address(RVA = "0x1517D0C", Offset = "0x1517D0C", VA = "0x1517D0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC26C", Offset = "0x9EC26C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700016E")]
		public static MonoManager current
		{
			[Token(Token = "0x6000CF3")]
			[Address(RVA = "0x150ACDC", Offset = "0x150ACDC", VA = "0x150ACDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000013")]
		public event Action onUpdate
		{
			[Token(Token = "0x6000CE5")]
			[Address(RVA = "0x150AE94", Offset = "0x150AE94", VA = "0x150AE94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC19C", Offset = "0x9EC19C")]
			add
			{
			}
			[Token(Token = "0x6000CE6")]
			[Address(RVA = "0x150B168", Offset = "0x150B168", VA = "0x150B168")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC1AC", Offset = "0x9EC1AC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event Action onLateUpdate
		{
			[Token(Token = "0x6000CE7")]
			[Address(RVA = "0x1511AE0", Offset = "0x1511AE0", VA = "0x1511AE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC1BC", Offset = "0x9EC1BC")]
			add
			{
			}
			[Token(Token = "0x6000CE8")]
			[Address(RVA = "0x1511C18", Offset = "0x1511C18", VA = "0x1511C18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC1CC", Offset = "0x9EC1CC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000015")]
		public event Action onFixedUpdate
		{
			[Token(Token = "0x6000CE9")]
			[Address(RVA = "0x15177C0", Offset = "0x15177C0", VA = "0x15177C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC1DC", Offset = "0x9EC1DC")]
			add
			{
			}
			[Token(Token = "0x6000CEA")]
			[Address(RVA = "0x1517860", Offset = "0x1517860", VA = "0x1517860")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC1EC", Offset = "0x9EC1EC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000016")]
		public event Action onGUI
		{
			[Token(Token = "0x6000CEB")]
			[Address(RVA = "0x1517900", Offset = "0x1517900", VA = "0x1517900")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC1FC", Offset = "0x9EC1FC")]
			add
			{
			}
			[Token(Token = "0x6000CEC")]
			[Address(RVA = "0x15179A0", Offset = "0x15179A0", VA = "0x15179A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC20C", Offset = "0x9EC20C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000017")]
		public event Action onApplicationQuit
		{
			[Token(Token = "0x6000CED")]
			[Address(RVA = "0x1517A40", Offset = "0x1517A40", VA = "0x1517A40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC21C", Offset = "0x9EC21C")]
			add
			{
			}
			[Token(Token = "0x6000CEE")]
			[Address(RVA = "0x1517AE0", Offset = "0x1517AE0", VA = "0x1517AE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC22C", Offset = "0x9EC22C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000018")]
		public event Action<bool> onApplicationPause
		{
			[Token(Token = "0x6000CEF")]
			[Address(RVA = "0x1517B80", Offset = "0x1517B80", VA = "0x1517B80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC23C", Offset = "0x9EC23C")]
			add
			{
			}
			[Token(Token = "0x6000CF0")]
			[Address(RVA = "0x1517C20", Offset = "0x1517C20", VA = "0x1517C20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC24C", Offset = "0x9EC24C")]
			remove
			{
			}
		}

		[Token(Token = "0x6000CF4")]
		[Address(RVA = "0x1517D60", Offset = "0x1517D60", VA = "0x1517D60")]
		public static void Create()
		{
		}

		[Token(Token = "0x6000CF5")]
		[Address(RVA = "0x1517DB8", Offset = "0x1517DB8", VA = "0x1517DB8")]
		protected void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000CF6")]
		[Address(RVA = "0x1517E24", Offset = "0x1517E24", VA = "0x1517E24")]
		protected void OnApplicationPause(bool isPause)
		{
		}

		[Token(Token = "0x6000CF7")]
		[Address(RVA = "0x1517E94", Offset = "0x1517E94", VA = "0x1517E94")]
		protected void Awake()
		{
		}

		[Token(Token = "0x6000CF8")]
		[Address(RVA = "0x1517FF0", Offset = "0x1517FF0", VA = "0x1517FF0")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000CF9")]
		[Address(RVA = "0x1518004", Offset = "0x1518004", VA = "0x1518004")]
		protected void LateUpdate()
		{
		}

		[Token(Token = "0x6000CFA")]
		[Address(RVA = "0x1518018", Offset = "0x1518018", VA = "0x1518018")]
		protected void FixedUpdate()
		{
		}

		[Token(Token = "0x6000CFB")]
		[Address(RVA = "0x151802C", Offset = "0x151802C", VA = "0x151802C")]
		public MonoManager()
		{
		}
	}
	[Token(Token = "0x20002ED")]
	public static class Threader
	{
		[Token(Token = "0x20002EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8DE0", Offset = "0x9E8DE0")]
		private sealed class <>c__DisplayClass1_0<T1>
		{
			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T1> function;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T1 parameter1;

			[Token(Token = "0x6000D06")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000D07")]
			internal void <StartAction>b__0()
			{
			}
		}

		[Token(Token = "0x20002EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8DF0", Offset = "0x9E8DF0")]
		private sealed class <>c__DisplayClass2_0<T1, T2>
		{
			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T1, T2> function;

			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T1 parameter1;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T2 parameter2;

			[Token(Token = "0x6000D08")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000D09")]
			internal void <StartAction>b__0()
			{
			}
		}

		[Token(Token = "0x20002F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8E00", Offset = "0x9E8E00")]
		private sealed class <>c__DisplayClass3_0<T1, T2, T3>
		{
			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T1, T2, T3> function;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T1 parameter1;

			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T2 parameter2;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T3 parameter3;

			[Token(Token = "0x6000D0A")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000D0B")]
			internal void <StartAction>b__0()
			{
			}
		}

		[Token(Token = "0x20002F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8E10", Offset = "0x9E8E10")]
		private sealed class <>c__DisplayClass4_0<TResult>
		{
			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TResult result;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<TResult> function;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<TResult> callback;

			[Token(Token = "0x6000D0C")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000D0D")]
			internal void <StartFunction>b__0()
			{
			}

			[Token(Token = "0x6000D0E")]
			internal void <StartFunction>b__1()
			{
			}
		}

		[Token(Token = "0x20002F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8E20", Offset = "0x9E8E20")]
		private sealed class <>c__DisplayClass5_0<TResult, T1>
		{
			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TResult result;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<T1, TResult> function;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T1 parameter1;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<TResult> callback;

			[Token(Token = "0x6000D0F")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000D10")]
			internal void <StartFunction>b__0()
			{
			}

			[Token(Token = "0x6000D11")]
			internal void <StartFunction>b__1()
			{
			}
		}

		[Token(Token = "0x20002F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8E30", Offset = "0x9E8E30")]
		private sealed class <>c__DisplayClass6_0<TResult, T1, T2>
		{
			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TResult result;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<T1, T2, TResult> function;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T1 parameter1;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T2 parameter2;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<TResult> callback;

			[Token(Token = "0x6000D12")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000D13")]
			internal void <StartFunction>b__0()
			{
			}

			[Token(Token = "0x6000D14")]
			internal void <StartFunction>b__1()
			{
			}
		}

		[Token(Token = "0x20002F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8E40", Offset = "0x9E8E40")]
		private sealed class <>c__DisplayClass7_0<TResult, T1, T2, T3>
		{
			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TResult result;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<T1, T2, T3, TResult> function;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T1 parameter1;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T2 parameter2;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T3 parameter3;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<TResult> callback;

			[Token(Token = "0x6000D15")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000D16")]
			internal void <StartFunction>b__0()
			{
			}

			[Token(Token = "0x6000D17")]
			internal void <StartFunction>b__1()
			{
			}
		}

		[Token(Token = "0x20002F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8E50", Offset = "0x9E8E50")]
		private sealed class <ThreadUpdater>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Thread thread;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action callback;

			[Token(Token = "0x1700016F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000D1B")]
				[Address(RVA = "0x26A7300", Offset = "0x26A7300", VA = "0x26A7300", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000170")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000D1D")]
				[Address(RVA = "0x26A7348", Offset = "0x26A7348", VA = "0x26A7348", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000D18")]
			[Address(RVA = "0x26A7224", Offset = "0x26A7224", VA = "0x26A7224")]
			[DebuggerHidden]
			public <ThreadUpdater>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000D19")]
			[Address(RVA = "0x26A7250", Offset = "0x26A7250", VA = "0x26A7250", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000D1A")]
			[Address(RVA = "0x26A7254", Offset = "0x26A7254", VA = "0x26A7254", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000D1C")]
			[Address(RVA = "0x26A7308", Offset = "0x26A7308", VA = "0x26A7308", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000CFC")]
		[Address(RVA = "0x1BC6B30", Offset = "0x1BC6B30", VA = "0x1BC6B30")]
		public static Thread StartAction(Action function, [Optional] Action callback)
		{
			return null;
		}

		[Token(Token = "0x6000CFD")]
		public static Thread StartAction<T1>(Action<T1> function, T1 parameter1, [Optional] Action callback)
		{
			return null;
		}

		[Token(Token = "0x6000CFE")]
		public static Thread StartAction<T1, T2>(Action<T1, T2> function, T1 parameter1, T2 parameter2, [Optional] Action callback)
		{
			return null;
		}

		[Token(Token = "0x6000CFF")]
		public static Thread StartAction<T1, T2, T3>(Action<T1, T2, T3> function, T1 parameter1, T2 parameter2, T3 parameter3, [Optional] Action callback)
		{
			return null;
		}

		[Token(Token = "0x6000D00")]
		public static Thread StartFunction<TResult>(Func<TResult> function, [Optional] Action<TResult> callback)
		{
			return null;
		}

		[Token(Token = "0x6000D01")]
		public static Thread StartFunction<TResult, T1>(Func<T1, TResult> function, T1 parameter1, [Optional] Action<TResult> callback)
		{
			return null;
		}

		[Token(Token = "0x6000D02")]
		public static Thread StartFunction<TResult, T1, T2>(Func<T1, T2, TResult> function, T1 parameter1, T2 parameter2, [Optional] Action<TResult> callback)
		{
			return null;
		}

		[Token(Token = "0x6000D03")]
		public static Thread StartFunction<TResult, T1, T2, T3>(Func<T1, T2, T3, TResult> function, T1 parameter1, T2 parameter2, T3 parameter3, [Optional] Action<TResult> callback)
		{
			return null;
		}

		[Token(Token = "0x6000D04")]
		[Address(RVA = "0x1BC6BEC", Offset = "0x1BC6BEC", VA = "0x1BC6BEC")]
		private static void Begin(Thread thread, Action callback)
		{
		}

		[Token(Token = "0x6000D05")]
		[Address(RVA = "0x1BC6C4C", Offset = "0x1BC6C4C", VA = "0x1BC6C4C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9EC27C", Offset = "0x9EC27C")]
		private static IEnumerator ThreadUpdater(Thread thread, Action callback)
		{
			return null;
		}
	}
}
namespace ParadoxNotion.Serialization
{
	[Token(Token = "0x20002F6")]
	public class DeserializeFromAttribute : Attribute
	{
		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string previousTypeFullName;

		[Token(Token = "0x6000D1E")]
		[Address(RVA = "0x1368AB4", Offset = "0x1368AB4", VA = "0x1368AB4")]
		public DeserializeFromAttribute(string previousTypeFullName)
		{
		}
	}
	[Token(Token = "0x20002F7")]
	public interface IMissingRecoverable
	{
		[Token(Token = "0x17000171")]
		string missingType
		{
			[Token(Token = "0x6000D1F")]
			get;
			[Token(Token = "0x6000D20")]
			set;
		}

		[Token(Token = "0x17000172")]
		string recoveryState
		{
			[Token(Token = "0x6000D21")]
			get;
			[Token(Token = "0x6000D22")]
			set;
		}
	}
	[Token(Token = "0x20002F8")]
	public static class JSONSerializer
	{
		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA484", Offset = "0x9EA484")]
		private static bool <applicationPlaying>k__BackingField;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<string, fsData> cache;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static object serializerLock;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static fsSerializer serializer;

		[Token(Token = "0x17000173")]
		public static bool applicationPlaying
		{
			[Token(Token = "0x6000D23")]
			[Address(RVA = "0x1510314", Offset = "0x1510314", VA = "0x1510314")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC32C", Offset = "0x9EC32C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D24")]
			[Address(RVA = "0x1510378", Offset = "0x1510378", VA = "0x1510378")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC33C", Offset = "0x9EC33C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000D25")]
		[Address(RVA = "0x15103E4", Offset = "0x15103E4", VA = "0x15103E4")]
		static JSONSerializer()
		{
		}

		[Token(Token = "0x6000D26")]
		[Address(RVA = "0x15081B8", Offset = "0x15081B8", VA = "0x15081B8")]
		public static string Serialize(Type type, object instance, bool pretyJson = false, [Optional] List<UnityEngine.Object> objectReferences)
		{
			return null;
		}

		[Token(Token = "0x6000D27")]
		public static T Deserialize<T>(string json, [Optional] List<UnityEngine.Object> objectReferences)
		{
			return (T)null;
		}

		[Token(Token = "0x6000D28")]
		[Address(RVA = "0x1510530", Offset = "0x1510530", VA = "0x1510530")]
		public static object Deserialize(Type type, string json, [Optional] List<UnityEngine.Object> objectReferences)
		{
			return null;
		}

		[Token(Token = "0x6000D29")]
		public static T DeserializeOverwrite<T>(T instance, string json, [Optional] List<UnityEngine.Object> objectReferences)
		{
			return (T)null;
		}

		[Token(Token = "0x6000D2A")]
		[Address(RVA = "0x15109AC", Offset = "0x15109AC", VA = "0x15109AC")]
		public static object DeserializeOverwrite(object instance, string json, [Optional] List<UnityEngine.Object> objectReferences)
		{
			return null;
		}

		[Token(Token = "0x6000D2B")]
		[Address(RVA = "0x15105AC", Offset = "0x15105AC", VA = "0x15105AC")]
		public static object Internal_Deserialize(Type type, string json, List<UnityEngine.Object> objectReferences, object instance)
		{
			return null;
		}

		[Token(Token = "0x6000D2C")]
		public static T Clone<T>(T original, [Optional] List<UnityEngine.Object> objectReferences)
		{
			return (T)null;
		}

		[Token(Token = "0x6000D2D")]
		[Address(RVA = "0x1510A44", Offset = "0x1510A44", VA = "0x1510A44")]
		public static object Clone(object original, [Optional] List<UnityEngine.Object> objectReferences)
		{
			return null;
		}

		[Token(Token = "0x6000D2E")]
		[Address(RVA = "0x1510AE8", Offset = "0x1510AE8", VA = "0x1510AE8")]
		public static void ShowData(string json, string fileName = "")
		{
		}

		[Token(Token = "0x6000D2F")]
		[Address(RVA = "0x1510C4C", Offset = "0x1510C4C", VA = "0x1510C4C")]
		public static string PrettifyJson(string json)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20002F9")]
	public class SerializedConstructorInfo : SerializedMethodBaseInfo
	{
		[Serializable]
		[Token(Token = "0x20002FA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8E60", Offset = "0x9E8E60")]
		private sealed class <>c
		{
			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<ParameterInfo, string> <>9__4_0;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<string, Type> <>9__5_0;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<Type, bool> <>9__5_1;

			[Token(Token = "0x6000D39")]
			[Address(RVA = "0x26A62E4", Offset = "0x26A62E4", VA = "0x26A62E4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000D3A")]
			[Address(RVA = "0x26A62EC", Offset = "0x26A62EC", VA = "0x26A62EC")]
			internal string <OnBeforeSerialize>b__4_0(ParameterInfo p)
			{
				return null;
			}

			[Token(Token = "0x6000D3B")]
			[Address(RVA = "0x26A6324", Offset = "0x26A6324", VA = "0x26A6324")]
			internal Type <OnAfterDeserialize>b__5_0(string n)
			{
				return null;
			}

			[Token(Token = "0x6000D3C")]
			[Address(RVA = "0x26A6390", Offset = "0x26A6390", VA = "0x26A6390")]
			internal bool <OnAfterDeserialize>b__5_1(Type t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _baseInfo;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _paramsInfo;

		[NonSerialized]
		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ConstructorInfo _constructor;

		[NonSerialized]
		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _hasChanged;

		[Token(Token = "0x6000D30")]
		[Address(RVA = "0x1BBE994", Offset = "0x1BBE994", VA = "0x1BBE994", Slot = "9")]
		public override void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000D31")]
		[Address(RVA = "0x1BBEC14", Offset = "0x1BBEC14", VA = "0x1BBEC14", Slot = "10")]
		public override void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000D32")]
		[Address(RVA = "0x1BBF0B4", Offset = "0x1BBF0B4", VA = "0x1BBF0B4")]
		public SerializedConstructorInfo()
		{
		}

		[Token(Token = "0x6000D33")]
		[Address(RVA = "0x1BB29A4", Offset = "0x1BB29A4", VA = "0x1BB29A4")]
		public SerializedConstructorInfo(ConstructorInfo constructor)
		{
		}

		[Token(Token = "0x6000D34")]
		[Address(RVA = "0x1BBF0C4", Offset = "0x1BBF0C4", VA = "0x1BBF0C4")]
		public ConstructorInfo Get()
		{
			return null;
		}

		[Token(Token = "0x6000D35")]
		[Address(RVA = "0x1BBF0CC", Offset = "0x1BBF0CC", VA = "0x1BBF0CC", Slot = "6")]
		public override MethodBase GetBase()
		{
			return null;
		}

		[Token(Token = "0x6000D36")]
		[Address(RVA = "0x1BBF0D4", Offset = "0x1BBF0D4", VA = "0x1BBF0D4", Slot = "7")]
		public override bool HasChanged()
		{
			return default(bool);
		}

		[Token(Token = "0x6000D37")]
		[Address(RVA = "0x1BBF0DC", Offset = "0x1BBF0DC", VA = "0x1BBF0DC", Slot = "8")]
		public override string GetMethodString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20002FB")]
	public class SerializedEventInfo : ISerializationCallbackReceiver
	{
		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _baseInfo;

		[NonSerialized]
		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private EventInfo _event;

		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0x1BBF1AC", Offset = "0x1BBF1AC", VA = "0x1BBF1AC", Slot = "4")]
		private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000D3E")]
		[Address(RVA = "0x1BBF2A0", Offset = "0x1BBF2A0", VA = "0x1BBF2A0", Slot = "5")]
		private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0x1BBF42C", Offset = "0x1BBF42C", VA = "0x1BBF42C")]
		public SerializedEventInfo()
		{
		}

		[Token(Token = "0x6000D40")]
		[Address(RVA = "0x1BBF434", Offset = "0x1BBF434", VA = "0x1BBF434")]
		public SerializedEventInfo(EventInfo info)
		{
		}

		[Token(Token = "0x6000D41")]
		[Address(RVA = "0x1BBF468", Offset = "0x1BBF468", VA = "0x1BBF468")]
		public EventInfo Get()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20002FC")]
	public class SerializedFieldInfo : ISerializationCallbackReceiver
	{
		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _baseInfo;

		[NonSerialized]
		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private FieldInfo _field;

		[Token(Token = "0x6000D42")]
		[Address(RVA = "0x1BBF470", Offset = "0x1BBF470", VA = "0x1BBF470", Slot = "4")]
		private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000D43")]
		[Address(RVA = "0x1BBF564", Offset = "0x1BBF564", VA = "0x1BBF564", Slot = "5")]
		private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000D44")]
		[Address(RVA = "0x1BBF6F0", Offset = "0x1BBF6F0", VA = "0x1BBF6F0")]
		public SerializedFieldInfo()
		{
		}

		[Token(Token = "0x6000D45")]
		[Address(RVA = "0x1BBF6F8", Offset = "0x1BBF6F8", VA = "0x1BBF6F8")]
		public SerializedFieldInfo(FieldInfo info)
		{
		}

		[Token(Token = "0x6000D46")]
		[Address(RVA = "0x1BBF72C", Offset = "0x1BBF72C", VA = "0x1BBF72C")]
		public FieldInfo Get()
		{
			return null;
		}
	}
	[Token(Token = "0x20002FD")]
	public abstract class SerializedMethodBaseInfo : ISerializationCallbackReceiver
	{
		[Token(Token = "0x6000D47")]
		public abstract MethodBase GetBase();

		[Token(Token = "0x6000D48")]
		public abstract bool HasChanged();

		[Token(Token = "0x6000D49")]
		public abstract string GetMethodString();

		[Token(Token = "0x6000D4A")]
		[Address(RVA = "0x1BBF734", Offset = "0x1BBF734", VA = "0x1BBF734", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000D4B")]
		public abstract void OnBeforeSerialize();

		[Token(Token = "0x6000D4C")]
		public abstract void OnAfterDeserialize();

		[Token(Token = "0x6000D4D")]
		[Address(RVA = "0x1BBF0BC", Offset = "0x1BBF0BC", VA = "0x1BBF0BC")]
		protected SerializedMethodBaseInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20002FE")]
	public class SerializedMethodInfo : SerializedMethodBaseInfo
	{
		[Serializable]
		[Token(Token = "0x20002FF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8E70", Offset = "0x9E8E70")]
		private sealed class <>c
		{
			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<ParameterInfo, string> <>9__5_0;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Type, string> <>9__5_1;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<string, Type> <>9__6_0;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<Type, bool> <>9__6_1;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<string, Type> <>9__6_3;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Func<ParameterInfo, Type> <>9__6_5;

			[Token(Token = "0x6000D57")]
			[Address(RVA = "0x26A645C", Offset = "0x26A645C", VA = "0x26A645C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000D58")]
			[Address(RVA = "0x26A6464", Offset = "0x26A6464", VA = "0x26A6464")]
			internal string <OnBeforeSerialize>b__5_0(ParameterInfo p)
			{
				return null;
			}

			[Token(Token = "0x6000D59")]
			[Address(RVA = "0x26A649C", Offset = "0x26A649C", VA = "0x26A649C")]
			internal string <OnBeforeSerialize>b__5_1(Type a)
			{
				return null;
			}

			[Token(Token = "0x6000D5A")]
			[Address(RVA = "0x26A64C0", Offset = "0x26A64C0", VA = "0x26A64C0")]
			internal Type <OnAfterDeserialize>b__6_0(string n)
			{
				return null;
			}

			[Token(Token = "0x6000D5B")]
			[Address(RVA = "0x26A652C", Offset = "0x26A652C", VA = "0x26A652C")]
			internal bool <OnAfterDeserialize>b__6_1(Type t)
			{
				return default(bool);
			}

			[Token(Token = "0x6000D5C")]
			[Address(RVA = "0x26A6594", Offset = "0x26A6594", VA = "0x26A6594")]
			internal Type <OnAfterDeserialize>b__6_3(string x)
			{
				return null;
			}

			[Token(Token = "0x6000D5D")]
			[Address(RVA = "0x26A6600", Offset = "0x26A6600", VA = "0x26A6600")]
			internal Type <OnAfterDeserialize>b__6_5(ParameterInfo p)
			{
				return null;
			}
		}

		[Token(Token = "0x2000300")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8E80", Offset = "0x9E8E80")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Type[] parameterTypes;

			[Token(Token = "0x6000D5E")]
			[Address(RVA = "0x26A6620", Offset = "0x26A6620", VA = "0x26A6620")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000D5F")]
			[Address(RVA = "0x26A6628", Offset = "0x26A6628", VA = "0x26A6628")]
			internal bool <OnAfterDeserialize>b__2(MethodInfo m)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000301")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8E90", Offset = "0x9E8E90")]
		private sealed class <>c__DisplayClass6_1
		{
			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type[] genericArgumentTypes;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass6_0 CS$<>8__locals1;

			[Token(Token = "0x6000D60")]
			[Address(RVA = "0x26A6668", Offset = "0x26A6668", VA = "0x26A6668")]
			public <>c__DisplayClass6_1()
			{
			}

			[Token(Token = "0x6000D61")]
			[Address(RVA = "0x26A6670", Offset = "0x26A6670", VA = "0x26A6670")]
			internal bool <OnAfterDeserialize>b__4(MethodInfo m)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _baseInfo;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _paramsInfo;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _genericArgumentsInfo;

		[NonSerialized]
		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MethodInfo _method;

		[NonSerialized]
		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _hasChanged;

		[Token(Token = "0x6000D4E")]
		[Address(RVA = "0x1BBF740", Offset = "0x1BBF740", VA = "0x1BBF740", Slot = "9")]
		public override void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000D4F")]
		[Address(RVA = "0x1BBFB4C", Offset = "0x1BBFB4C", VA = "0x1BBFB4C", Slot = "10")]
		public override void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000D50")]
		[Address(RVA = "0x1BC0598", Offset = "0x1BC0598", VA = "0x1BC0598")]
		public SerializedMethodInfo()
		{
		}

		[Token(Token = "0x6000D51")]
		[Address(RVA = "0x1BB26A8", Offset = "0x1BB26A8", VA = "0x1BB26A8")]
		public SerializedMethodInfo(MethodInfo method)
		{
		}

		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x1BC05A0", Offset = "0x1BC05A0", VA = "0x1BC05A0")]
		public MethodInfo Get()
		{
			return null;
		}

		[Token(Token = "0x6000D53")]
		[Address(RVA = "0x1BC05A8", Offset = "0x1BC05A8", VA = "0x1BC05A8", Slot = "6")]
		public override MethodBase GetBase()
		{
			return null;
		}

		[Token(Token = "0x6000D54")]
		[Address(RVA = "0x1BC05B0", Offset = "0x1BC05B0", VA = "0x1BC05B0", Slot = "7")]
		public override bool HasChanged()
		{
			return default(bool);
		}

		[Token(Token = "0x6000D55")]
		[Address(RVA = "0x1BC05B8", Offset = "0x1BC05B8", VA = "0x1BC05B8", Slot = "8")]
		public override string GetMethodString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000302")]
	public class SerializedTypeInfo : ISerializationCallbackReceiver
	{
		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _baseInfo;

		[NonSerialized]
		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Type _type;

		[Token(Token = "0x6000D62")]
		[Address(RVA = "0x1BC0688", Offset = "0x1BC0688", VA = "0x1BC0688", Slot = "4")]
		private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000D63")]
		[Address(RVA = "0x1BC0730", Offset = "0x1BC0730", VA = "0x1BC0730", Slot = "5")]
		private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000D64")]
		[Address(RVA = "0x1BC07BC", Offset = "0x1BC07BC", VA = "0x1BC07BC")]
		public SerializedTypeInfo()
		{
		}

		[Token(Token = "0x6000D65")]
		[Address(RVA = "0x1BC07C4", Offset = "0x1BC07C4", VA = "0x1BC07C4")]
		public SerializedTypeInfo(Type info)
		{
		}

		[Token(Token = "0x6000D66")]
		[Address(RVA = "0x1BC07F8", Offset = "0x1BC07F8", VA = "0x1BC07F8")]
		public Type Get()
		{
			return null;
		}
	}
	[Token(Token = "0x2000303")]
	public class fsRecoveryProcessor<TCanProcess, TMissing> : fsObjectProcessor where TMissing : TCanProcess, IMissingRecoverable
	{
		[Token(Token = "0x2000304")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8EA0", Offset = "0x9E8EA0")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Dictionary<string, fsData> json;

			[Token(Token = "0x6000D6B")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000D6C")]
			internal bool <OnBeforeDeserialize>b__0(KeyValuePair<string, fsData> kvp)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000305")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8EB0", Offset = "0x9E8EB0")]
		private sealed class <>c
		{
			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<KeyValuePair<string, fsData>, string> <>9__3_1;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<KeyValuePair<string, fsData>, fsData> <>9__3_2;

			[Token(Token = "0x6000D6E")]
			public <>c()
			{
			}

			[Token(Token = "0x6000D6F")]
			internal string <OnBeforeDeserialize>b__3_1(KeyValuePair<string, fsData> c)
			{
				return null;
			}

			[Token(Token = "0x6000D70")]
			internal fsData <OnBeforeDeserialize>b__3_2(KeyValuePair<string, fsData> c)
			{
				return null;
			}
		}

		[Token(Token = "0x40006DD")]
		private const string FIELD_NAME_TYPE = "_missingType";

		[Token(Token = "0x40006DE")]
		private const string FIELD_NAME_STATE = "_recoveryState";

		[Token(Token = "0x6000D67")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D68")]
		public override void OnBeforeDeserialize(Type storageType, ref fsData data)
		{
		}

		[Token(Token = "0x6000D69")]
		public override void OnAfterDeserialize(Type storageType, object instance)
		{
		}

		[Token(Token = "0x6000D6A")]
		public fsRecoveryProcessor()
		{
		}
	}
	[Token(Token = "0x2000306")]
	public class fsUnityObjectConverter : fsConverter
	{
		[Token(Token = "0x6000D71")]
		[Address(RVA = "0x1467600", Offset = "0x1467600", VA = "0x1467600", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D72")]
		[Address(RVA = "0x14676C0", Offset = "0x14676C0", VA = "0x14676C0", Slot = "5")]
		public override bool RequestCycleSupport(Type storageType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D73")]
		[Address(RVA = "0x14676C8", Offset = "0x14676C8", VA = "0x14676C8", Slot = "6")]
		public override bool RequestInheritanceSupport(Type storageType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D74")]
		[Address(RVA = "0x14676D0", Offset = "0x14676D0", VA = "0x14676D0", Slot = "7")]
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000D75")]
		[Address(RVA = "0x14678DC", Offset = "0x14678DC", VA = "0x14678DC", Slot = "8")]
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000D76")]
		[Address(RVA = "0x1467A90", Offset = "0x1467A90", VA = "0x1467A90", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		[Token(Token = "0x6000D77")]
		[Address(RVA = "0x1465FD0", Offset = "0x1465FD0", VA = "0x1465FD0")]
		public fsUnityObjectConverter()
		{
		}
	}
}
namespace ParadoxNotion.Serialization.FullSerializer
{
	[Token(Token = "0x2000307")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E8EC0", Offset = "0x9E8EC0")]
	public sealed class fsForwardAttribute : Attribute
	{
		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string MemberName;

		[Token(Token = "0x6000D78")]
		[Address(RVA = "0x145D838", Offset = "0x145D838", VA = "0x145D838")]
		public fsForwardAttribute(string memberName)
		{
		}
	}
	[Token(Token = "0x2000308")]
	public class fsMetaType
	{
		[Token(Token = "0x2000309")]
		private delegate object ObjectGenerator();

		[Token(Token = "0x200030A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8ED4", Offset = "0x9E8ED4")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FieldInfo field;

			[Token(Token = "0x6000D8A")]
			[Address(RVA = "0x26A98F0", Offset = "0x26A98F0", VA = "0x26A98F0")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6000D8B")]
			[Address(RVA = "0x26A98F8", Offset = "0x26A98F8", VA = "0x26A98F8")]
			internal bool <CollectProperties>b__0(Type t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200030B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8EE4", Offset = "0x9E8EE4")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FieldInfo field;

			[Token(Token = "0x6000D8C")]
			[Address(RVA = "0x26A9974", Offset = "0x26A9974", VA = "0x26A9974")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000D8D")]
			[Address(RVA = "0x26A997C", Offset = "0x26A997C", VA = "0x26A997C")]
			internal bool <CanSerializeField>b__0(Type t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200030C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8EF4", Offset = "0x9E8EF4")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type reflectedType;

			[Token(Token = "0x6000D8E")]
			[Address(RVA = "0x26A99F8", Offset = "0x26A99F8", VA = "0x26A99F8")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000D8F")]
			[Address(RVA = "0x26A9A00", Offset = "0x26A9A00", VA = "0x26A9A00")]
			internal object <GetGenerator>b__0()
			{
				return null;
			}

			[Token(Token = "0x6000D90")]
			[Address(RVA = "0x26A9A98", Offset = "0x26A9A98", VA = "0x26A9A98")]
			internal object <GetGenerator>b__1()
			{
				return null;
			}

			[Token(Token = "0x6000D91")]
			[Address(RVA = "0x26A9AA4", Offset = "0x26A9AA4", VA = "0x26A9AA4")]
			internal object <GetGenerator>b__2()
			{
				return null;
			}

			[Token(Token = "0x6000D92")]
			[Address(RVA = "0x26A9AD8", Offset = "0x26A9AD8", VA = "0x26A9AD8")]
			internal object <GetGenerator>b__4()
			{
				return null;
			}

			[Token(Token = "0x6000D93")]
			[Address(RVA = "0x26A9B40", Offset = "0x26A9B40", VA = "0x26A9B40")]
			internal object <GetGenerator>b__5()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x200030D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8F04", Offset = "0x9E8F04")]
		private sealed class <>c
		{
			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static ObjectGenerator <>9__16_3;

			[Token(Token = "0x6000D95")]
			[Address(RVA = "0x26A989C", Offset = "0x26A989C", VA = "0x26A989C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000D96")]
			[Address(RVA = "0x26A98A4", Offset = "0x26A98A4", VA = "0x26A98A4")]
			internal object <GetGenerator>b__16_3()
			{
				return null;
			}
		}

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<fsConfig, Dictionary<Type, fsMetaType>> _configMetaTypes;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ObjectGenerator generator;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA514", Offset = "0x9EA514")]
		private Type <reflectedType>k__BackingField;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA524", Offset = "0x9EA524")]
		private fsMetaProperty[] <Properties>k__BackingField;

		[Token(Token = "0x17000174")]
		public Type reflectedType
		{
			[Token(Token = "0x6000D7B")]
			[Address(RVA = "0x1462390", Offset = "0x1462390", VA = "0x1462390")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC34C", Offset = "0x9EC34C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D7C")]
			[Address(RVA = "0x1462398", Offset = "0x1462398", VA = "0x1462398")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC35C", Offset = "0x9EC35C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000175")]
		public fsMetaProperty[] Properties
		{
			[Token(Token = "0x6000D7D")]
			[Address(RVA = "0x14623A0", Offset = "0x14623A0", VA = "0x14623A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC36C", Offset = "0x9EC36C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D7E")]
			[Address(RVA = "0x14623A8", Offset = "0x14623A8", VA = "0x14623A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC37C", Offset = "0x9EC37C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000D79")]
		[Address(RVA = "0x14582B0", Offset = "0x14582B0", VA = "0x14582B0")]
		public static fsMetaType Get(fsConfig config, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000D7A")]
		[Address(RVA = "0x14622EC", Offset = "0x14622EC", VA = "0x14622EC")]
		public static void ClearCache()
		{
		}

		[Token(Token = "0x6000D7F")]
		[Address(RVA = "0x14621CC", Offset = "0x14621CC", VA = "0x14621CC")]
		private fsMetaType(fsConfig config, Type reflectedType)
		{
		}

		[Token(Token = "0x6000D80")]
		[Address(RVA = "0x14626FC", Offset = "0x14626FC", VA = "0x14626FC")]
		private static void CollectProperties(fsConfig config, List<fsMetaProperty> properties, Type reflectedType)
		{
		}

		[Token(Token = "0x6000D81")]
		[Address(RVA = "0x14629BC", Offset = "0x14629BC", VA = "0x14629BC")]
		private static bool CanSerializeField(fsConfig config, FieldInfo field)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D82")]
		[Address(RVA = "0x14623B0", Offset = "0x14623B0", VA = "0x14623B0")]
		private static ObjectGenerator GetGenerator(Type reflectedType)
		{
			return null;
		}

		[Token(Token = "0x6000D83")]
		[Address(RVA = "0x1462C30", Offset = "0x1462C30", VA = "0x1462C30")]
		private static bool HasDefaultConstructor(Type reflectedType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D84")]
		[Address(RVA = "0x1458480", Offset = "0x1458480", VA = "0x1458480")]
		public object CreateInstance()
		{
			return null;
		}
	}
	[Token(Token = "0x200030E")]
	public abstract class fsBaseConverter
	{
		[Serializable]
		[Token(Token = "0x200030F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E8F14", Offset = "0x9E8F14")]
		private sealed class <>c
		{
			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<fsDataType, string> <>9__6_0;

			[Token(Token = "0x6000DA4")]
			[Address(RVA = "0x26A972C", Offset = "0x26A972C", VA = "0x26A972C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000DA5")]
			[Address(RVA = "0x26A9734", Offset = "0x26A9734", VA = "0x26A9734")]
			internal string <FailExpectedType>b__6_0(fsDataType t)
			{
				return null;
			}
		}

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public fsSerializer Serializer;

		[Token(Token = "0x6000D97")]
		[Address(RVA = "0x14591D0", Offset = "0x14591D0", VA = "0x14591D0", Slot = "4")]
		public virtual object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		[Token(Token = "0x6000D98")]
		[Address(RVA = "0x1459400", Offset = "0x1459400", VA = "0x1459400", Slot = "5")]
		public virtual bool RequestCycleSupport(Type storageType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D99")]
		[Address(RVA = "0x14594CC", Offset = "0x14594CC", VA = "0x14594CC", Slot = "6")]
		public virtual bool RequestInheritanceSupport(Type storageType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D9A")]
		public abstract fsResult TrySerialize(object instance, out fsData serialized, Type storageType);

		[Token(Token = "0x6000D9B")]
		public abstract fsResult TryDeserialize(fsData data, ref object instance, Type storageType);

		[Token(Token = "0x6000D9C")]
		[Address(RVA = "0x14594F8", Offset = "0x14594F8", VA = "0x14594F8")]
		protected fsResult FailExpectedType(fsData data, params fsDataType[] types)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000D9D")]
		[Address(RVA = "0x1457E54", Offset = "0x1457E54", VA = "0x1457E54")]
		protected fsResult CheckType(fsData data, fsDataType type)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0x1459BC0", Offset = "0x1459BC0", VA = "0x1459BC0")]
		protected fsResult CheckKey(fsData data, string key, out fsData subitem)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0x1459C0C", Offset = "0x1459C0C", VA = "0x1459C0C")]
		protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000DA0")]
		protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, T value)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000DA1")]
		protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, out T value)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0x1459EB0", Offset = "0x1459EB0", VA = "0x1459EB0")]
		protected fsBaseConverter()
		{
		}
	}
	[Token(Token = "0x2000310")]
	public static class fsGlobalConfig
	{
		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool SerializeDefaultValues;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static bool IsCaseSensitive;
	}
	[Token(Token = "0x2000311")]
	public class fsConfig
	{
		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Type[] SerializeAttributes;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type[] IgnoreSerializeAttributes;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string CustomDateTimeFormatString;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool Serialize64BitIntegerAsString;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool SerializeEnumsAsInteger;

		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0x1459EB8", Offset = "0x1459EB8", VA = "0x1459EB8")]
		public fsConfig()
		{
		}
	}
	[Token(Token = "0x2000312")]
	public sealed class fsContext
	{
		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<Type, object> _contextObjects;

		[Token(Token = "0x6000DA8")]
		[Address(RVA = "0x145A100", Offset = "0x145A100", VA = "0x145A100")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000DA9")]
		public void Set<T>(T obj)
		{
		}

		[Token(Token = "0x6000DAA")]
		public bool Has<T>()
		{
			return default(bool);
		}

		[Token(Token = "0x6000DAB")]
		public T Get<T>()
		{
			return (T)null;
		}

		[Token(Token = "0x6000DAC")]
		[Address(RVA = "0x145A154", Offset = "0x145A154", VA = "0x145A154")]
		public fsContext()
		{
		}
	}
	[Token(Token = "0x2000313")]
	public abstract class fsConverter : fsBaseConverter
	{
		[Token(Token = "0x6000DAD")]
		public abstract bool CanProcess(Type type);

		[Token(Token = "0x6000DAE")]
		[Address(RVA = "0x1458740", Offset = "0x1458740", VA = "0x1458740")]
		protected fsConverter()
		{
		}
	}
	[Token(Token = "0x2000314")]
	public enum fsDataType
	{
		[Token(Token = "0x40006F9")]
		Array,
		[Token(Token = "0x40006FA")]
		Object,
		[Token(Token = "0x40006FB")]
		Double,
		[Token(Token = "0x40006FC")]
		Int64,
		[Token(Token = "0x40006FD")]
		Boolean,
		[Token(Token = "0x40006FE")]
		String,
		[Token(Token = "0x40006FF")]
		Null
	}
	[Token(Token = "0x2000315")]
	public sealed class fsData
	{
		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private object _value;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly fsData True;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly fsData False;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly fsData Null;

		[Token(Token = "0x17000176")]
		public fsDataType Type
		{
			[Token(Token = "0x6000DAF")]
			[Address(RVA = "0x1459958", Offset = "0x1459958", VA = "0x1459958")]
			get
			{
				return default(fsDataType);
			}
		}

		[Token(Token = "0x17000177")]
		public bool IsNull
		{
			[Token(Token = "0x6000DBC")]
			[Address(RVA = "0x145ADCC", Offset = "0x145ADCC", VA = "0x145ADCC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000178")]
		public bool IsDouble
		{
			[Token(Token = "0x6000DBD")]
			[Address(RVA = "0x145ADDC", Offset = "0x145ADDC", VA = "0x145ADDC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000179")]
		public bool IsInt64
		{
			[Token(Token = "0x6000DBE")]
			[Address(RVA = "0x145AE40", Offset = "0x145AE40", VA = "0x145AE40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700017A")]
		public bool IsBool
		{
			[Token(Token = "0x6000DBF")]
			[Address(RVA = "0x145AEA4", Offset = "0x145AEA4", VA = "0x145AEA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700017B")]
		public bool IsString
		{
			[Token(Token = "0x6000DC0")]
			[Address(RVA = "0x145AF08", Offset = "0x145AF08", VA = "0x145AF08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700017C")]
		public bool IsDictionary
		{
			[Token(Token = "0x6000DC1")]
			[Address(RVA = "0x14589B4", Offset = "0x14589B4", VA = "0x14589B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700017D")]
		public bool IsList
		{
			[Token(Token = "0x6000DC2")]
			[Address(RVA = "0x145AF6C", Offset = "0x145AF6C", VA = "0x145AF6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700017E")]
		public double AsDouble
		{
			[Token(Token = "0x6000DC3")]
			[Address(RVA = "0x145AFEC", Offset = "0x145AFEC", VA = "0x145AFEC")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700017F")]
		public long AsInt64
		{
			[Token(Token = "0x6000DC4")]
			[Address(RVA = "0x145B038", Offset = "0x145B038", VA = "0x145B038")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000180")]
		public bool AsBool
		{
			[Token(Token = "0x6000DC5")]
			[Address(RVA = "0x145B084", Offset = "0x145B084", VA = "0x145B084")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000181")]
		public string AsString
		{
			[Token(Token = "0x6000DC6")]
			[Address(RVA = "0x145B0D0", Offset = "0x145B0D0", VA = "0x145B0D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000182")]
		public Dictionary<string, fsData> AsDictionary
		{
			[Token(Token = "0x6000DC7")]
			[Address(RVA = "0x1458A34", Offset = "0x1458A34", VA = "0x1458A34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000183")]
		public List<fsData> AsList
		{
			[Token(Token = "0x6000DC8")]
			[Address(RVA = "0x1457AA8", Offset = "0x1457AA8", VA = "0x1457AA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000DB0")]
		[Address(RVA = "0x145A7B4", Offset = "0x145A7B4", VA = "0x145A7B4")]
		public fsData()
		{
		}

		[Token(Token = "0x6000DB1")]
		[Address(RVA = "0x145A7E4", Offset = "0x145A7E4", VA = "0x145A7E4")]
		public fsData(bool boolean)
		{
		}

		[Token(Token = "0x6000DB2")]
		[Address(RVA = "0x145A860", Offset = "0x145A860", VA = "0x145A860")]
		public fsData(double f)
		{
		}

		[Token(Token = "0x6000DB3")]
		[Address(RVA = "0x145A8DC", Offset = "0x145A8DC", VA = "0x145A8DC")]
		public fsData(long i)
		{
		}

		[Token(Token = "0x6000DB4")]
		[Address(RVA = "0x145A958", Offset = "0x145A958", VA = "0x145A958")]
		public fsData(string str)
		{
		}

		[Token(Token = "0x6000DB5")]
		[Address(RVA = "0x145A98C", Offset = "0x145A98C", VA = "0x145A98C")]
		public fsData(Dictionary<string, fsData> dict)
		{
		}

		[Token(Token = "0x6000DB6")]
		[Address(RVA = "0x145A9C0", Offset = "0x145A9C0", VA = "0x145A9C0")]
		public fsData(List<fsData> list)
		{
		}

		[Token(Token = "0x6000DB7")]
		[Address(RVA = "0x145A9F4", Offset = "0x145A9F4", VA = "0x145A9F4")]
		public static fsData CreateDictionary()
		{
			return null;
		}

		[Token(Token = "0x6000DB8")]
		[Address(RVA = "0x145ABA4", Offset = "0x145ABA4", VA = "0x145ABA4")]
		public static fsData CreateList()
		{
			return null;
		}

		[Token(Token = "0x6000DB9")]
		[Address(RVA = "0x14579FC", Offset = "0x14579FC", VA = "0x14579FC")]
		public static fsData CreateList(int capacity)
		{
			return null;
		}

		[Token(Token = "0x6000DBA")]
		[Address(RVA = "0x145AC48", Offset = "0x145AC48", VA = "0x145AC48")]
		internal void BecomeDictionary()
		{
		}

		[Token(Token = "0x6000DBB")]
		[Address(RVA = "0x145AD3C", Offset = "0x145AD3C", VA = "0x145AD3C")]
		internal fsData Clone()
		{
			return null;
		}

		[Token(Token = "0x6000DC9")]
		private T Cast<T>()
		{
			return (T)null;
		}

		[Token(Token = "0x6000DCA")]
		[Address(RVA = "0x145B11C", Offset = "0x145B11C", VA = "0x145B11C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000DCB")]
		[Address(RVA = "0x145B2CC", Offset = "0x145B2CC", VA = "0x145B2CC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000DCC")]
		[Address(RVA = "0x145B33C", Offset = "0x145B33C", VA = "0x145B33C")]
		public bool Equals(fsData other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000DCD")]
		[Address(RVA = "0x145B80C", Offset = "0x145B80C", VA = "0x145B80C")]
		public static bool operator ==(fsData a, fsData b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000DCE")]
		[Address(RVA = "0x145B934", Offset = "0x145B934", VA = "0x145B934")]
		public static bool operator !=(fsData a, fsData b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000DCF")]
		[Address(RVA = "0x145B9B0", Offset = "0x145B9B0", VA = "0x145B9B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000316")]
	public abstract class fsDirectConverter : fsBaseConverter
	{
		[Token(Token = "0x17000184")]
		public abstract Type ModelType
		{
			[Token(Token = "0x6000DD1")]
			get;
		}

		[Token(Token = "0x6000DD2")]
		[Address(RVA = "0x145CD40", Offset = "0x145CD40", VA = "0x145CD40")]
		protected fsDirectConverter()
		{
		}
	}
	[Token(Token = "0x2000317")]
	public abstract class fsDirectConverter<TModel> : fsDirectConverter
	{
		[Token(Token = "0x17000185")]
		public override Type ModelType
		{
			[Token(Token = "0x6000DD3")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000DD4")]
		public sealed override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000DD5")]
		public sealed override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000DD6")]
		protected abstract fsResult DoSerialize(TModel model, Dictionary<string, fsData> serialized);

		[Token(Token = "0x6000DD7")]
		protected abstract fsResult DoDeserialize(Dictionary<string, fsData> data, ref TModel model);

		[Token(Token = "0x6000DD8")]
		protected fsDirectConverter()
		{
		}
	}
	[Token(Token = "0x2000318")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E8F24", Offset = "0x9E8F24")]
	public sealed class fsIgnoreAttribute : Attribute
	{
		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0x145DEE0", Offset = "0x145DEE0", VA = "0x145DEE0")]
		public fsIgnoreAttribute()
		{
		}
	}
	[Token(Token = "0x2000319")]
	public class fsJsonParser
	{
		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _start;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _input;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly StringBuilder _cachedStringBuilder;

		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x145DEE8", Offset = "0x145DEE8", VA = "0x145DEE8")]
		private fsResult MakeFailure(string message)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000DDB")]
		[Address(RVA = "0x145E18C", Offset = "0x145E18C", VA = "0x145E18C")]
		private bool TryMoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000DDC")]
		[Address(RVA = "0x145E1C8", Offset = "0x145E1C8", VA = "0x145E1C8")]
		private bool HasValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000DDD")]
		[Address(RVA = "0x145E1FC", Offset = "0x145E1FC", VA = "0x145E1FC")]
		private bool HasValue(int offset)
		{
			return default(bool);
		}

		[Token(Token = "0x6000DDE")]
		[Address(RVA = "0x145E234", Offset = "0x145E234", VA = "0x145E234")]
		private char Character()
		{
			return default(char);
		}

		[Token(Token = "0x6000DDF")]
		[Address(RVA = "0x145E23C", Offset = "0x145E23C", VA = "0x145E23C")]
		private char Character(int offset)
		{
			return default(char);
		}

		[Token(Token = "0x6000DE0")]
		[Address(RVA = "0x145E264", Offset = "0x145E264", VA = "0x145E264")]
		private void SkipSpace()
		{
		}

		[Token(Token = "0x6000DE1")]
		[Address(RVA = "0x145E510", Offset = "0x145E510", VA = "0x145E510")]
		private bool IsHex(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000DE2")]
		[Address(RVA = "0x145E54C", Offset = "0x145E54C", VA = "0x145E54C")]
		private uint ParseSingleChar(char c1, uint multipliyer)
		{
			return default(uint);
		}

		[Token(Token = "0x6000DE3")]
		[Address(RVA = "0x145E5A4", Offset = "0x145E5A4", VA = "0x145E5A4")]
		private uint ParseUnicode(char c1, char c2, char c3, char c4)
		{
			return default(uint);
		}

		[Token(Token = "0x6000DE4")]
		[Address(RVA = "0x145E714", Offset = "0x145E714", VA = "0x145E714")]
		private fsResult TryUnescapeChar(out char escaped)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000DE5")]
		[Address(RVA = "0x145EDE4", Offset = "0x145EDE4", VA = "0x145EDE4")]
		private fsResult TryParseExact(string content)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000DE6")]
		[Address(RVA = "0x145EF4C", Offset = "0x145EF4C", VA = "0x145EF4C")]
		private fsResult TryParseTrue(out fsData data)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000DE7")]
		[Address(RVA = "0x145F044", Offset = "0x145F044", VA = "0x145F044")]
		private fsResult TryParseFalse(out fsData data)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000DE8")]
		[Address(RVA = "0x145F13C", Offset = "0x145F13C", VA = "0x145F13C")]
		private fsResult TryParseNull(out fsData data)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000DE9")]
		[Address(RVA = "0x145F244", Offset = "0x145F244", VA = "0x145F244")]
		private bool IsSeparator(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000DEA")]
		[Address(RVA = "0x145F2D4", Offset = "0x145F2D4", VA = "0x145F2D4")]
		private fsResult TryParseNumber(out fsData data)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000DEB")]
		[Address(RVA = "0x145F66C", Offset = "0x145F66C", VA = "0x145F66C")]
		private fsResult TryParseString(out string str)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000DEC")]
		[Address(RVA = "0x145F968", Offset = "0x145F968", VA = "0x145F968")]
		private fsResult TryParseArray(out fsData arr)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000DED")]
		[Address(RVA = "0x145FF6C", Offset = "0x145FF6C", VA = "0x145FF6C")]
		private fsResult TryParseObject(out fsData obj)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000DEE")]
		[Address(RVA = "0x145FC98", Offset = "0x145FC98", VA = "0x145FC98")]
		private fsResult RunParse(out fsData data)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000DEF")]
		[Address(RVA = "0x1460480", Offset = "0x1460480", VA = "0x1460480")]
		public static fsResult Parse(string input, out fsData data)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000DF0")]
		[Address(RVA = "0x1460600", Offset = "0x1460600", VA = "0x1460600")]
		public static fsData Parse(string input)
		{
			return null;
		}

		[Token(Token = "0x6000DF1")]
		[Address(RVA = "0x1460568", Offset = "0x1460568", VA = "0x1460568")]
		private fsJsonParser(string input)
		{
		}
	}
	[Token(Token = "0x200031A")]
	public static class fsJsonPrinter
	{
		[Token(Token = "0x6000DF2")]
		[Address(RVA = "0x1460674", Offset = "0x1460674", VA = "0x1460674")]
		private static void InsertSpacing(TextWriter stream, int count)
		{
		}

		[Token(Token = "0x6000DF3")]
		[Address(RVA = "0x14606F4", Offset = "0x14606F4", VA = "0x14606F4")]
		private static string EscapeString(string str)
		{
			return null;
		}

		[Token(Token = "0x6000DF4")]
		[Address(RVA = "0x1460A80", Offset = "0x1460A80", VA = "0x1460A80")]
		private static void BuildCompressedString(fsData data, TextWriter stream)
		{
		}

		[Token(Token = "0x6000DF5")]
		[Address(RVA = "0x14610A4", Offset = "0x14610A4", VA = "0x14610A4")]
		private static void BuildPrettyString(fsData data, TextWriter stream, int depth)
		{
		}

		[Token(Token = "0x6000DF6")]
		[Address(RVA = "0x1461608", Offset = "0x1461608", VA = "0x1461608")]
		public static string ToJson(fsData data, bool pretty)
		{
			return null;
		}

		[Token(Token = "0x6000DF7")]
		[Address(RVA = "0x14617C4", Offset = "0x14617C4", VA = "0x14617C4")]
		public static void PrettyJson(fsData data, TextWriter outputStream)
		{
		}

		[Token(Token = "0x6000DF8")]
		[Address(RVA = "0x1461614", Offset = "0x1461614", VA = "0x1461614")]
		public static string PrettyJson(fsData data)
		{
			return null;
		}

		[Token(Token = "0x6000DF9")]
		[Address(RVA = "0x14617CC", Offset = "0x14617CC", VA = "0x14617CC")]
		public static void CompressedJson(fsData data, StreamWriter outputStream)
		{
		}

		[Token(Token = "0x6000DFA")]
		[Address(RVA = "0x145B120", Offset = "0x145B120", VA = "0x145B120")]
		public static string CompressedJson(fsData data)
		{
			return null;
		}

		[Token(Token = "0x6000DFB")]
		[Address(RVA = "0x1460ED4", Offset = "0x1460ED4", VA = "0x1460ED4")]
		private static string ConvertDoubleToString(double d)
		{
			return null;
		}
	}
	[Token(Token = "0x200031B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E8F38", Offset = "0x9E8F38")]
	public sealed class fsObjectAttribute : Attribute
	{
		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Type Converter;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type Processor;

		[Token(Token = "0x6000DFC")]
		[Address(RVA = "0x1462D9C", Offset = "0x1462D9C", VA = "0x1462D9C")]
		public fsObjectAttribute()
		{
		}
	}
	[Token(Token = "0x200031C")]
	public abstract class fsObjectProcessor
	{
		[Token(Token = "0x6000DFD")]
		[Address(RVA = "0x1462DA4", Offset = "0x1462DA4", VA = "0x1462DA4", Slot = "4")]
		public virtual bool CanProcess(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000DFE")]
		[Address(RVA = "0x1462DE4", Offset = "0x1462DE4", VA = "0x1462DE4", Slot = "5")]
		public virtual void OnBeforeSerialize(Type storageType, object instance)
		{
		}

		[Token(Token = "0x6000DFF")]
		[Address(RVA = "0x1462DE8", Offset = "0x1462DE8", VA = "0x1462DE8", Slot = "6")]
		public virtual void OnAfterSerialize(Type storageType, object instance, ref fsData data)
		{
		}

		[Token(Token = "0x6000E00")]
		[Address(RVA = "0x1462DEC", Offset = "0x1462DEC", VA = "0x1462DEC", Slot = "7")]
		public virtual void OnBeforeDeserialize(Type storageType, ref fsData data)
		{
		}

		[Token(Token = "0x6000E01")]
		[Address(RVA = "0x1462DF0", Offset = "0x1462DF0", VA = "0x1462DF0", Slot = "8")]
		public virtual void OnBeforeDeserializeAfterInstanceCreation(Type storageType, object instance, ref fsData data)
		{
		}

		[Token(Token = "0x6000E02")]
		[Address(RVA = "0x1462DF4", Offset = "0x1462DF4", VA = "0x1462DF4", Slot = "9")]
		public virtual void OnAfterDeserialize(Type storageType, object instance)
		{
		}

		[Token(Token = "0x6000E03")]
		[Address(RVA = "0x1462DF8", Offset = "0x1462DF8", VA = "0x1462DF8")]
		protected fsObjectProcessor()
		{
		}
	}
	[Token(Token = "0x200031D")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E8F4C", Offset = "0x9E8F4C")]
	public sealed class fsSerializeAsAttribute : Attribute
	{
		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Name;

		[Token(Token = "0x6000E04")]
		[Address(RVA = "0x146563C", Offset = "0x146563C", VA = "0x146563C")]
		public fsSerializeAsAttribute(string name)
		{
		}
	}
	[Token(Token = "0x200031E")]
	public struct fsResult
	{
		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string[] EmptyStringArray;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _success;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private List<string> _messages;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static fsResult Success;

		[Token(Token = "0x17000186")]
		public bool Failed
		{
			[Token(Token = "0x6000E0B")]
			[Address(RVA = "0x1457BD0", Offset = "0x1457BD0", VA = "0x1457BD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000187")]
		public bool Succeeded
		{
			[Token(Token = "0x6000E0C")]
			[Address(RVA = "0x14652EC", Offset = "0x14652EC", VA = "0x14652EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000188")]
		public bool HasWarnings
		{
			[Token(Token = "0x6000E0D")]
			[Address(RVA = "0x14652F4", Offset = "0x14652F4", VA = "0x14652F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000189")]
		public Exception AsException
		{
			[Token(Token = "0x6000E10")]
			[Address(RVA = "0x1465350", Offset = "0x1465350", VA = "0x1465350")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018A")]
		public IEnumerable<string> RawMessages
		{
			[Token(Token = "0x6000E11")]
			[Address(RVA = "0x14654C0", Offset = "0x14654C0", VA = "0x14654C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018B")]
		public string FormattedMessages
		{
			[Token(Token = "0x6000E12")]
			[Address(RVA = "0x1465530", Offset = "0x1465530", VA = "0x1465530")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000E05")]
		[Address(RVA = "0x1465088", Offset = "0x1465088", VA = "0x1465088")]
		public static fsResult Warn(string warning)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x1459B04", Offset = "0x1459B04", VA = "0x1459B04")]
		public static fsResult Fail(string warning)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E07")]
		[Address(RVA = "0x1465150", Offset = "0x1465150", VA = "0x1465150")]
		public void AddMessage(string message)
		{
		}

		[Token(Token = "0x6000E08")]
		[Address(RVA = "0x1457B04", Offset = "0x1457B04", VA = "0x1457B04")]
		public void AddMessages(fsResult result)
		{
		}

		[Token(Token = "0x6000E09")]
		[Address(RVA = "0x1465208", Offset = "0x1465208", VA = "0x1465208")]
		private fsResult Merge(fsResult other)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E0A")]
		[Address(RVA = "0x14581F0", Offset = "0x14581F0", VA = "0x14581F0")]
		public static fsResult operator +(fsResult a, fsResult b)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E0E")]
		[Address(RVA = "0x1460634", Offset = "0x1460634", VA = "0x1460634")]
		public fsResult AssertSuccess()
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E0F")]
		[Address(RVA = "0x1465438", Offset = "0x1465438", VA = "0x1465438")]
		public fsResult AssertSuccessWithoutWarnings()
		{
			return default(fsResult);
		}
	}
	[Token(Token = "0x200031F")]
	public class fsSerializer
	{
		[Token(Token = "0x2000320")]
		internal class fsLazyCycleDefinitionWriter
		{
			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Dictionary<int, fsData> _pendingDefinitions;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private HashSet<int> _references;

			[Token(Token = "0x6000E2C")]
			[Address(RVA = "0x26A9DB0", Offset = "0x26A9DB0", VA = "0x26A9DB0")]
			public void WriteDefinition(int id, fsData data)
			{
			}

			[Token(Token = "0x6000E2D")]
			[Address(RVA = "0x26A9F08", Offset = "0x26A9F08", VA = "0x26A9F08")]
			public void WriteReference(int id, Dictionary<string, fsData> dict)
			{
			}

			[Token(Token = "0x6000E2E")]
			[Address(RVA = "0x26AA108", Offset = "0x26AA108", VA = "0x26AA108")]
			public void Clear()
			{
			}

			[Token(Token = "0x6000E2F")]
			[Address(RVA = "0x26AA180", Offset = "0x26AA180", VA = "0x26AA180")]
			public fsLazyCycleDefinitionWriter()
			{
			}
		}

		[Token(Token = "0x400070E")]
		public const string KEY_OBJECT_REFERENCE = "$ref";

		[Token(Token = "0x400070F")]
		public const string KEY_OBJECT_DEFINITION = "$id";

		[Token(Token = "0x4000710")]
		public const string KEY_INSTANCE_TYPE = "$type";

		[Token(Token = "0x4000711")]
		public const string KEY_VERSION = "$version";

		[Token(Token = "0x4000712")]
		public const string KEY_CONTENT = "$content";

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<Type, fsBaseConverter> _cachedOverrideConverterInstances;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<Type, fsBaseConverter> _cachedConverters;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<fsConverter> _availableConverters;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Dictionary<Type, fsDirectConverter> _availableDirectConverters;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly List<fsObjectProcessor> _processors;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<Type, List<fsObjectProcessor>> _cachedProcessors;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly fsCyclicReferenceManager _references;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly fsLazyCycleDefinitionWriter _lazyReferenceWriter;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public fsContext Context;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public fsConfig Config;

		[Token(Token = "0x6000E14")]
		[Address(RVA = "0x145CC30", Offset = "0x145CC30", VA = "0x145CC30")]
		public static bool IsReservedKeyword(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E15")]
		[Address(RVA = "0x1465670", Offset = "0x1465670", VA = "0x1465670")]
		private static bool IsObjectReference(fsData data)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E16")]
		[Address(RVA = "0x1465700", Offset = "0x1465700", VA = "0x1465700")]
		private static bool IsObjectDefinition(fsData data)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E17")]
		[Address(RVA = "0x1465790", Offset = "0x1465790", VA = "0x1465790")]
		private static bool IsVersioned(fsData data)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E18")]
		[Address(RVA = "0x1465820", Offset = "0x1465820", VA = "0x1465820")]
		private static bool IsTypeSpecified(fsData data)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E19")]
		[Address(RVA = "0x14658B0", Offset = "0x14658B0", VA = "0x14658B0")]
		private static bool IsWrappedData(fsData data)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E1A")]
		[Address(RVA = "0x1465940", Offset = "0x1465940", VA = "0x1465940")]
		private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, Type storageType, object instance)
		{
		}

		[Token(Token = "0x6000E1B")]
		[Address(RVA = "0x1465B0C", Offset = "0x1465B0C", VA = "0x1465B0C")]
		private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data)
		{
		}

		[Token(Token = "0x6000E1C")]
		[Address(RVA = "0x1465BD4", Offset = "0x1465BD4", VA = "0x1465BD4")]
		private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, Type storageType, ref fsData data)
		{
		}

		[Token(Token = "0x6000E1D")]
		[Address(RVA = "0x1465C88", Offset = "0x1465C88", VA = "0x1465C88")]
		private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data)
		{
		}

		[Token(Token = "0x6000E1E")]
		[Address(RVA = "0x1465D4C", Offset = "0x1465D4C", VA = "0x1465D4C")]
		private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, Type storageType, object instance)
		{
		}

		[Token(Token = "0x6000E1F")]
		[Address(RVA = "0x1465F2C", Offset = "0x1465F2C", VA = "0x1465F2C")]
		private static void EnsureDictionary(fsData data)
		{
		}

		[Token(Token = "0x6000E20")]
		[Address(RVA = "0x1458A80", Offset = "0x1458A80", VA = "0x1458A80")]
		public fsSerializer()
		{
		}

		[Token(Token = "0x6000E21")]
		[Address(RVA = "0x1466238", Offset = "0x1466238", VA = "0x1466238")]
		private List<fsObjectProcessor> GetProcessors(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000E22")]
		[Address(RVA = "0x1465FE0", Offset = "0x1465FE0", VA = "0x1465FE0")]
		public void AddConverter(fsBaseConverter converter)
		{
		}

		[Token(Token = "0x6000E23")]
		[Address(RVA = "0x146651C", Offset = "0x146651C", VA = "0x146651C")]
		private fsBaseConverter GetConverter(Type type, Type overrideConverterType)
		{
			return null;
		}

		[Token(Token = "0x6000E24")]
		public fsResult TrySerialize<T>(T instance, out fsData data)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E25")]
		[Address(RVA = "0x1457AF4", Offset = "0x1457AF4", VA = "0x1457AF4")]
		public fsResult TrySerialize(Type storageType, object instance, out fsData data)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E26")]
		[Address(RVA = "0x146487C", Offset = "0x146487C", VA = "0x146487C")]
		public fsResult TrySerialize(Type storageType, Type overrideConverterType, object instance, out fsData data)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E27")]
		[Address(RVA = "0x1466958", Offset = "0x1466958", VA = "0x1466958")]
		private fsResult Internal_Serialize(Type storageType, Type overrideConverterType, object instance, out fsData data)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E28")]
		public fsResult TryDeserialize<T>(fsData data, ref T instance)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E29")]
		[Address(RVA = "0x145821C", Offset = "0x145821C", VA = "0x145821C")]
		public fsResult TryDeserialize(fsData data, Type storageType, ref object result)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E2A")]
		[Address(RVA = "0x1464CE0", Offset = "0x1464CE0", VA = "0x1464CE0")]
		public fsResult TryDeserialize(fsData data, Type storageType, Type overrideConverterType, ref object result)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E2B")]
		[Address(RVA = "0x1466CEC", Offset = "0x1466CEC", VA = "0x1466CEC")]
		private fsResult Internal_Deserialize(Type overrideConverterType, fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors)
		{
			return default(fsResult);
		}
	}
}
namespace ParadoxNotion.Serialization.FullSerializer.Internal
{
	[Token(Token = "0x2000321")]
	public class fsArrayConverter : fsConverter
	{
		[Token(Token = "0x6000E30")]
		[Address(RVA = "0x1457688", Offset = "0x1457688", VA = "0x1457688", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E31")]
		[Address(RVA = "0x14576A4", Offset = "0x14576A4", VA = "0x14576A4", Slot = "5")]
		public override bool RequestCycleSupport(Type storageType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E32")]
		[Address(RVA = "0x14576AC", Offset = "0x14576AC", VA = "0x14576AC", Slot = "6")]
		public override bool RequestInheritanceSupport(Type storageType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E33")]
		[Address(RVA = "0x14576B4", Offset = "0x14576B4", VA = "0x14576B4", Slot = "7")]
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E34")]
		[Address(RVA = "0x1457BE0", Offset = "0x1457BE0", VA = "0x1457BE0", Slot = "8")]
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E35")]
		[Address(RVA = "0x1458228", Offset = "0x1458228", VA = "0x1458228", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		[Token(Token = "0x6000E36")]
		[Address(RVA = "0x1458738", Offset = "0x1458738", VA = "0x1458738")]
		public fsArrayConverter()
		{
		}
	}
	[Token(Token = "0x2000322")]
	public class fsDictionaryConverter : fsConverter
	{
		[Token(Token = "0x6000E37")]
		[Address(RVA = "0x145BA94", Offset = "0x145BA94", VA = "0x145BA94", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E38")]
		[Address(RVA = "0x145BB6C", Offset = "0x145BB6C", VA = "0x145BB6C", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		[Token(Token = "0x6000E39")]
		[Address(RVA = "0x145BBF4", Offset = "0x145BBF4", VA = "0x145BBF4", Slot = "7")]
		public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E3A")]
		[Address(RVA = "0x145C48C", Offset = "0x145C48C", VA = "0x145C48C", Slot = "8")]
		public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E3B")]
		[Address(RVA = "0x145CD38", Offset = "0x145CD38", VA = "0x145CD38")]
		public fsDictionaryConverter()
		{
		}
	}
	[Token(Token = "0x2000323")]
	public class fsEnumConverter : fsConverter
	{
		[Token(Token = "0x6000E3C")]
		[Address(RVA = "0x145CD48", Offset = "0x145CD48", VA = "0x145CD48", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E3D")]
		[Address(RVA = "0x145CD6C", Offset = "0x145CD6C", VA = "0x145CD6C", Slot = "5")]
		public override bool RequestCycleSupport(Type storageType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E3E")]
		[Address(RVA = "0x145CD74", Offset = "0x145CD74", VA = "0x145CD74", Slot = "6")]
		public override bool RequestInheritanceSupport(Type storageType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E3F")]
		[Address(RVA = "0x145CD7C", Offset = "0x145CD7C", VA = "0x145CD7C", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		[Token(Token = "0x6000E40")]
		[Address(RVA = "0x145CE1C", Offset = "0x145CE1C", VA = "0x145CE1C", Slot = "7")]
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E41")]
		[Address(RVA = "0x145D350", Offset = "0x145D350", VA = "0x145D350", Slot = "8")]
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E42")]
		private static bool ArrayContains<T>(T[] values, T value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E43")]
		[Address(RVA = "0x145D830", Offset = "0x145D830", VA = "0x145D830")]
		public fsEnumConverter()
		{
		}
	}
	[Token(Token = "0x2000324")]
	public class fsForwardConverter : fsConverter
	{
		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _memberName;

		[Token(Token = "0x6000E44")]
		[Address(RVA = "0x145D86C", Offset = "0x145D86C", VA = "0x145D86C")]
		public fsForwardConverter(fsForwardAttribute attribute)
		{
		}

		[Token(Token = "0x6000E45")]
		[Address(RVA = "0x145D8A8", Offset = "0x145D8A8", VA = "0x145D8A8", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E46")]
		[Address(RVA = "0x145D8FC", Offset = "0x145D8FC", VA = "0x145D8FC")]
		private fsResult GetProperty(object instance, out fsMetaProperty property)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E47")]
		[Address(RVA = "0x145DB64", Offset = "0x145DB64", VA = "0x145DB64", Slot = "7")]
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E48")]
		[Address(RVA = "0x145DCD8", Offset = "0x145DCD8", VA = "0x145DCD8", Slot = "8")]
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E49")]
		[Address(RVA = "0x145DE54", Offset = "0x145DE54", VA = "0x145DE54", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}
	}
	[Token(Token = "0x2000325")]
	public class fsListConverter : fsConverter
	{
		[Token(Token = "0x6000E4A")]
		[Address(RVA = "0x14617D0", Offset = "0x14617D0", VA = "0x14617D0", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E4B")]
		[Address(RVA = "0x14618A8", Offset = "0x14618A8", VA = "0x14618A8", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		[Token(Token = "0x6000E4C")]
		[Address(RVA = "0x1461930", Offset = "0x1461930", VA = "0x1461930", Slot = "7")]
		public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E4D")]
		[Address(RVA = "0x1461DF4", Offset = "0x1461DF4", VA = "0x1461DF4", Slot = "8")]
		public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E4E")]
		[Address(RVA = "0x146208C", Offset = "0x146208C", VA = "0x146208C")]
		public fsListConverter()
		{
		}
	}
	[Token(Token = "0x2000326")]
	public class fsPrimitiveConverter : fsConverter
	{
		[Token(Token = "0x6000E4F")]
		[Address(RVA = "0x1462E00", Offset = "0x1462E00", VA = "0x1462E00", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E50")]
		[Address(RVA = "0x1462F10", Offset = "0x1462F10", VA = "0x1462F10", Slot = "5")]
		public override bool RequestCycleSupport(Type storageType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E51")]
		[Address(RVA = "0x1462F18", Offset = "0x1462F18", VA = "0x1462F18", Slot = "6")]
		public override bool RequestInheritanceSupport(Type storageType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E52")]
		[Address(RVA = "0x1462F20", Offset = "0x1462F20", VA = "0x1462F20")]
		private static bool UseBool(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E53")]
		[Address(RVA = "0x1462FAC", Offset = "0x1462FAC", VA = "0x1462FAC")]
		private static bool UseInt64(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E54")]
		[Address(RVA = "0x1463284", Offset = "0x1463284", VA = "0x1463284")]
		private static bool UseDouble(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E55")]
		[Address(RVA = "0x14633CC", Offset = "0x14633CC", VA = "0x14633CC")]
		private static bool UseString(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E56")]
		[Address(RVA = "0x14634C4", Offset = "0x14634C4", VA = "0x14634C4", Slot = "7")]
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E57")]
		[Address(RVA = "0x1463BE4", Offset = "0x1463BE4", VA = "0x1463BE4", Slot = "8")]
		public override fsResult TryDeserialize(fsData storage, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E58")]
		[Address(RVA = "0x146446C", Offset = "0x146446C", VA = "0x146446C")]
		public fsPrimitiveConverter()
		{
		}
	}
	[Token(Token = "0x2000327")]
	public class fsReflectedConverter : fsConverter
	{
		[Token(Token = "0x6000E59")]
		[Address(RVA = "0x1464474", Offset = "0x1464474", VA = "0x1464474", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E5A")]
		[Address(RVA = "0x1464534", Offset = "0x1464534", VA = "0x1464534", Slot = "7")]
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E5B")]
		[Address(RVA = "0x1464A94", Offset = "0x1464A94", VA = "0x1464A94", Slot = "8")]
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E5C")]
		[Address(RVA = "0x1464FF8", Offset = "0x1464FF8", VA = "0x1464FF8", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		[Token(Token = "0x6000E5D")]
		[Address(RVA = "0x1465080", Offset = "0x1465080", VA = "0x1465080")]
		public fsReflectedConverter()
		{
		}
	}
	[Token(Token = "0x2000328")]
	public class fsTypeConverter : fsConverter
	{
		[Token(Token = "0x6000E5E")]
		[Address(RVA = "0x1467268", Offset = "0x1467268", VA = "0x1467268", Slot = "9")]
		public override bool CanProcess(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E5F")]
		[Address(RVA = "0x1467300", Offset = "0x1467300", VA = "0x1467300", Slot = "5")]
		public override bool RequestCycleSupport(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E60")]
		[Address(RVA = "0x1467308", Offset = "0x1467308", VA = "0x1467308", Slot = "6")]
		public override bool RequestInheritanceSupport(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E61")]
		[Address(RVA = "0x1467310", Offset = "0x1467310", VA = "0x1467310", Slot = "7")]
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E62")]
		[Address(RVA = "0x1467434", Offset = "0x1467434", VA = "0x1467434", Slot = "8")]
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E63")]
		[Address(RVA = "0x14675F8", Offset = "0x14675F8", VA = "0x14675F8", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		[Token(Token = "0x6000E64")]
		[Address(RVA = "0x1465FD8", Offset = "0x1465FD8", VA = "0x1465FD8")]
		public fsTypeConverter()
		{
		}
	}
	[Token(Token = "0x2000329")]
	public class fsCyclicReferenceManager
	{
		[Token(Token = "0x200032A")]
		private class ObjectReferenceEqualityComparator : IEqualityComparer<object>
		{
			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly IEqualityComparer<object> Instance;

			[Token(Token = "0x6000E6D")]
			[Address(RVA = "0x26A97B4", Offset = "0x26A97B4", VA = "0x26A97B4", Slot = "4")]
			private bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000E6E")]
			[Address(RVA = "0x26A97C0", Offset = "0x26A97C0", VA = "0x26A97C0", Slot = "5")]
			private int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj)
			{
				return default(int);
			}

			[Token(Token = "0x6000E6F")]
			[Address(RVA = "0x26A97CC", Offset = "0x26A97CC", VA = "0x26A97CC")]
			public ObjectReferenceEqualityComparator()
			{
			}
		}

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<object, int> _objectIds;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _nextId;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<int, object> _marked;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _depth;

		[Token(Token = "0x6000E65")]
		[Address(RVA = "0x145A1D8", Offset = "0x145A1D8", VA = "0x145A1D8")]
		public fsCyclicReferenceManager()
		{
		}

		[Token(Token = "0x6000E66")]
		[Address(RVA = "0x145A2EC", Offset = "0x145A2EC", VA = "0x145A2EC")]
		public void Enter()
		{
		}

		[Token(Token = "0x6000E67")]
		[Address(RVA = "0x145A2FC", Offset = "0x145A2FC", VA = "0x145A2FC")]
		public bool Exit()
		{
			return default(bool);
		}

		[Token(Token = "0x6000E68")]
		[Address(RVA = "0x145A3E8", Offset = "0x145A3E8", VA = "0x145A3E8")]
		public object GetReferenceObject(int id)
		{
			return null;
		}

		[Token(Token = "0x6000E69")]
		[Address(RVA = "0x145A4E4", Offset = "0x145A4E4", VA = "0x145A4E4")]
		public void AddReferenceWithId(int id, object reference)
		{
		}

		[Token(Token = "0x6000E6A")]
		[Address(RVA = "0x145A550", Offset = "0x145A550", VA = "0x145A550")]
		public int GetReferenceId(object item)
		{
			return default(int);
		}

		[Token(Token = "0x6000E6B")]
		[Address(RVA = "0x145A600", Offset = "0x145A600", VA = "0x145A600")]
		public bool IsReference(object item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000E6C")]
		[Address(RVA = "0x145A674", Offset = "0x145A674", VA = "0x145A674")]
		public void MarkSerialized(object item)
		{
		}
	}
	[Token(Token = "0x200032B")]
	public class fsMetaProperty
	{
		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private FieldInfo _fieldInfo;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA534", Offset = "0x9EA534")]
		private Type <StorageType>k__BackingField;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EA544", Offset = "0x9EA544")]
		private string <JsonName>k__BackingField;

		[Token(Token = "0x1700018C")]
		public Type StorageType
		{
			[Token(Token = "0x6000E71")]
			[Address(RVA = "0x1462094", Offset = "0x1462094", VA = "0x1462094")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC38C", Offset = "0x9EC38C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E72")]
			[Address(RVA = "0x146209C", Offset = "0x146209C", VA = "0x146209C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC39C", Offset = "0x9EC39C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700018D")]
		public string JsonName
		{
			[Token(Token = "0x6000E73")]
			[Address(RVA = "0x14620A4", Offset = "0x14620A4", VA = "0x14620A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC3AC", Offset = "0x9EC3AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E74")]
			[Address(RVA = "0x14620AC", Offset = "0x14620AC", VA = "0x14620AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EC3BC", Offset = "0x9EC3BC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700018E")]
		public string MemberName
		{
			[Token(Token = "0x6000E75")]
			[Address(RVA = "0x145DB44", Offset = "0x145DB44", VA = "0x145DB44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000E76")]
		[Address(RVA = "0x14620B4", Offset = "0x14620B4", VA = "0x14620B4")]
		internal fsMetaProperty(fsConfig config, FieldInfo field)
		{
		}

		[Token(Token = "0x6000E77")]
		[Address(RVA = "0x145DE38", Offset = "0x145DE38", VA = "0x145DE38")]
		public void Write(object context, object value)
		{
		}

		[Token(Token = "0x6000E78")]
		[Address(RVA = "0x145DCB4", Offset = "0x145DCB4", VA = "0x145DCB4")]
		public object Read(object context)
		{
			return null;
		}
	}
}
namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters
{
	[Token(Token = "0x200032C")]
	public class AnimationCurve_DirectConverter : fsDirectConverter<AnimationCurve>
	{
		[Token(Token = "0x6000E79")]
		[Address(RVA = "0x1357984", Offset = "0x1357984", VA = "0x1357984", Slot = "10")]
		protected override fsResult DoSerialize(AnimationCurve model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E7A")]
		[Address(RVA = "0x1357B3C", Offset = "0x1357B3C", VA = "0x1357B3C", Slot = "11")]
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref AnimationCurve model)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E7B")]
		[Address(RVA = "0x1357D68", Offset = "0x1357D68", VA = "0x1357D68", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		[Token(Token = "0x6000E7C")]
		[Address(RVA = "0x1357DC0", Offset = "0x1357DC0", VA = "0x1357DC0")]
		public AnimationCurve_DirectConverter()
		{
		}
	}
	[Token(Token = "0x200032D")]
	public class Bounds_DirectConverter : fsDirectConverter<Bounds>
	{
		[Token(Token = "0x6000E7D")]
		[Address(RVA = "0x135F6B8", Offset = "0x135F6B8", VA = "0x135F6B8", Slot = "10")]
		protected override fsResult DoSerialize(Bounds model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E7E")]
		[Address(RVA = "0x135F7F0", Offset = "0x135F7F0", VA = "0x135F7F0", Slot = "11")]
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Bounds model)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E7F")]
		[Address(RVA = "0x135F994", Offset = "0x135F994", VA = "0x135F994", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		[Token(Token = "0x6000E80")]
		[Address(RVA = "0x135F9F0", Offset = "0x135F9F0", VA = "0x135F9F0")]
		public Bounds_DirectConverter()
		{
		}
	}
	[Token(Token = "0x200032E")]
	public class GUIStyleState_DirectConverter : fsDirectConverter<GUIStyleState>
	{
		[Token(Token = "0x6000E81")]
		[Address(RVA = "0x1370F88", Offset = "0x1370F88", VA = "0x1370F88", Slot = "10")]
		protected override fsResult DoSerialize(GUIStyleState model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E82")]
		[Address(RVA = "0x13710E0", Offset = "0x13710E0", VA = "0x13710E0", Slot = "11")]
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyleState model)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E83")]
		[Address(RVA = "0x13712A4", Offset = "0x13712A4", VA = "0x13712A4", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		[Token(Token = "0x6000E84")]
		[Address(RVA = "0x13712FC", Offset = "0x13712FC", VA = "0x13712FC")]
		public GUIStyleState_DirectConverter()
		{
		}
	}
	[Token(Token = "0x200032F")]
	public class GUIStyle_DirectConverter : fsDirectConverter<GUIStyle>
	{
		[Token(Token = "0x6000E85")]
		[Address(RVA = "0x137163C", Offset = "0x137163C", VA = "0x137163C", Slot = "10")]
		protected override fsResult DoSerialize(GUIStyle model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E86")]
		[Address(RVA = "0x13720FC", Offset = "0x13720FC", VA = "0x13720FC", Slot = "11")]
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyle model)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E87")]
		[Address(RVA = "0x1372F18", Offset = "0x1372F18", VA = "0x1372F18", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		[Token(Token = "0x6000E88")]
		[Address(RVA = "0x1372F70", Offset = "0x1372F70", VA = "0x1372F70")]
		public GUIStyle_DirectConverter()
		{
		}
	}
	[Token(Token = "0x2000330")]
	public class Gradient_DirectConverter : fsDirectConverter<Gradient>
	{
		[Token(Token = "0x6000E89")]
		[Address(RVA = "0x15066B0", Offset = "0x15066B0", VA = "0x15066B0", Slot = "10")]
		protected override fsResult DoSerialize(Gradient model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E8A")]
		[Address(RVA = "0x150680C", Offset = "0x150680C", VA = "0x150680C", Slot = "11")]
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Gradient model)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E8B")]
		[Address(RVA = "0x15069C4", Offset = "0x15069C4", VA = "0x15069C4", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		[Token(Token = "0x6000E8C")]
		[Address(RVA = "0x1506A1C", Offset = "0x1506A1C", VA = "0x1506A1C")]
		public Gradient_DirectConverter()
		{
		}
	}
	[Token(Token = "0x2000331")]
	public class Keyframe_DirectConverter : fsDirectConverter<Keyframe>
	{
		[Token(Token = "0x6000E8D")]
		[Address(RVA = "0x1510F48", Offset = "0x1510F48", VA = "0x1510F48", Slot = "10")]
		protected override fsResult DoSerialize(Keyframe model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E8E")]
		[Address(RVA = "0x15111A0", Offset = "0x15111A0", VA = "0x15111A0", Slot = "11")]
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Keyframe model)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E8F")]
		[Address(RVA = "0x1511498", Offset = "0x1511498", VA = "0x1511498", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		[Token(Token = "0x6000E90")]
		[Address(RVA = "0x15114FC", Offset = "0x15114FC", VA = "0x15114FC")]
		public Keyframe_DirectConverter()
		{
		}
	}
	[Token(Token = "0x2000332")]
	public class LayerMask_DirectConverter : fsDirectConverter<LayerMask>
	{
		[Token(Token = "0x6000E91")]
		[Address(RVA = "0x1512474", Offset = "0x1512474", VA = "0x1512474", Slot = "10")]
		protected override fsResult DoSerialize(LayerMask model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E92")]
		[Address(RVA = "0x151255C", Offset = "0x151255C", VA = "0x151255C", Slot = "11")]
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref LayerMask model)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E93")]
		[Address(RVA = "0x1512670", Offset = "0x1512670", VA = "0x1512670", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		[Token(Token = "0x6000E94")]
		[Address(RVA = "0x15126C0", Offset = "0x15126C0", VA = "0x15126C0")]
		public LayerMask_DirectConverter()
		{
		}
	}
	[Token(Token = "0x2000333")]
	public class RectOffset_DirectConverter : fsDirectConverter<RectOffset>
	{
		[Token(Token = "0x6000E95")]
		[Address(RVA = "0x1BB0C2C", Offset = "0x1BB0C2C", VA = "0x1BB0C2C", Slot = "10")]
		protected override fsResult DoSerialize(RectOffset model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E96")]
		[Address(RVA = "0x1BB0E2C", Offset = "0x1BB0E2C", VA = "0x1BB0E2C", Slot = "11")]
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref RectOffset model)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E97")]
		[Address(RVA = "0x1BB10C4", Offset = "0x1BB10C4", VA = "0x1BB10C4", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		[Token(Token = "0x6000E98")]
		[Address(RVA = "0x1BB111C", Offset = "0x1BB111C", VA = "0x1BB111C")]
		public RectOffset_DirectConverter()
		{
		}
	}
	[Token(Token = "0x2000334")]
	public class Rect_DirectConverter : fsDirectConverter<Rect>
	{
		[Token(Token = "0x6000E99")]
		[Address(RVA = "0x1BB18E8", Offset = "0x1BB18E8", VA = "0x1BB18E8", Slot = "10")]
		protected override fsResult DoSerialize(Rect model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E9A")]
		[Address(RVA = "0x1BB1AE0", Offset = "0x1BB1AE0", VA = "0x1BB1AE0", Slot = "11")]
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Rect model)
		{
			return default(fsResult);
		}

		[Token(Token = "0x6000E9B")]
		[Address(RVA = "0x1BB1D50", Offset = "0x1BB1D50", VA = "0x1BB1D50", Slot = "4")]
		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		[Token(Token = "0x6000E9C")]
		[Address(RVA = "0x1BB1DA8", Offset = "0x1BB1DA8", VA = "0x1BB1DA8")]
		public Rect_DirectConverter()
		{
		}
	}
}
namespace ParadoxNotion.Design
{
	[Token(Token = "0x2000335")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E8F60", Offset = "0x9E8F60")]
	public class SpoofAOTAttribute : Attribute
	{
		[Token(Token = "0x6000E9D")]
		[Address(RVA = "0x1BC1394", Offset = "0x1BC1394", VA = "0x1BC1394")]
		public SpoofAOTAttribute()
		{
		}
	}
	[Token(Token = "0x2000336")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E8F74", Offset = "0x9E8F74")]
	public class DoNotListAttribute : Attribute
	{
		[Token(Token = "0x6000E9E")]
		[Address(RVA = "0x1368BB4", Offset = "0x1368BB4", VA = "0x1368BB4")]
		public DoNotListAttribute()
		{
		}
	}
	[Token(Token = "0x2000337")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E8F88", Offset = "0x9E8F88")]
	public class ProtectedSingletonAttribute : Attribute
	{
		[Token(Token = "0x6000E9F")]
		[Address(RVA = "0x151EBB4", Offset = "0x151EBB4", VA = "0x151EBB4")]
		public ProtectedSingletonAttribute()
		{
		}
	}
	[Token(Token = "0x2000338")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E8F9C", Offset = "0x9E8F9C")]
	public class ExecutionPriorityAttribute : Attribute
	{
		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly int priority;

		[Token(Token = "0x6000EA0")]
		[Address(RVA = "0x1369384", Offset = "0x1369384", VA = "0x1369384")]
		public ExecutionPriorityAttribute(int priority)
		{
		}
	}
	[Token(Token = "0x2000339")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E8FB0", Offset = "0x9E8FB0")]
	public class ExposeAsDefinitionAttribute : Attribute
	{
		[Token(Token = "0x6000EA1")]
		[Address(RVA = "0x13693B0", Offset = "0x13693B0", VA = "0x13693B0")]
		public ExposeAsDefinitionAttribute()
		{
		}
	}
	[Token(Token = "0x200033A")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E8FC4", Offset = "0x9E8FC4")]
	public class ExposeFieldAttribute : Attribute
	{
		[Token(Token = "0x6000EA2")]
		[Address(RVA = "0x13693B8", Offset = "0x13693B8", VA = "0x13693B8")]
		public ExposeFieldAttribute()
		{
		}
	}
	[Token(Token = "0x200033B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E8FD8", Offset = "0x9E8FD8")]
	public class NameAttribute : Attribute
	{
		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string name;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly int priority;

		[Token(Token = "0x6000EA3")]
		[Address(RVA = "0x151A218", Offset = "0x151A218", VA = "0x151A218")]
		public NameAttribute(string name, int priority = 0)
		{
		}
	}
	[Token(Token = "0x200033C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E8FEC", Offset = "0x9E8FEC")]
	public class CategoryAttribute : Attribute
	{
		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string category;

		[Token(Token = "0x6000EA4")]
		[Address(RVA = "0x1361400", Offset = "0x1361400", VA = "0x1361400")]
		public CategoryAttribute(string category)
		{
		}
	}
	[Token(Token = "0x200033D")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E9000", Offset = "0x9E9000")]
	public class DescriptionAttribute : Attribute
	{
		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string description;

		[Token(Token = "0x6000EA5")]
		[Address(RVA = "0x1368A80", Offset = "0x1368A80", VA = "0x1368A80")]
		public DescriptionAttribute(string description)
		{
		}
	}
	[Token(Token = "0x200033E")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E9014", Offset = "0x9E9014")]
	public class IconAttribute : Attribute
	{
		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string iconName;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly bool fixedColor;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly string runtimeIconTypeCallback;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly Type fromType;

		[Token(Token = "0x6000EA6")]
		[Address(RVA = "0x150F0A4", Offset = "0x150F0A4", VA = "0x150F0A4")]
		public IconAttribute(string iconName = "", bool fixedColor = false, string runtimeIconTypeCallback = "")
		{
		}

		[Token(Token = "0x6000EA7")]
		[Address(RVA = "0x150F100", Offset = "0x150F100", VA = "0x150F100")]
		public IconAttribute(Type fromType)
		{
		}
	}
	[Token(Token = "0x200033F")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E9028", Offset = "0x9E9028")]
	public class ColorAttribute : Attribute
	{
		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string hexColor;

		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0x136334C", Offset = "0x136334C", VA = "0x136334C")]
		public ColorAttribute(string hexColor)
		{
		}
	}
	[Token(Token = "0x2000340")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E903C", Offset = "0x9E903C")]
	public abstract class DrawerAttribute : Attribute
	{
		[Token(Token = "0x1700018F")]
		public virtual int priority
		{
			[Token(Token = "0x6000EA9")]
			[Address(RVA = "0x1368D68", Offset = "0x1368D68", VA = "0x1368D68", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000EAA")]
		[Address(RVA = "0x1361394", Offset = "0x1361394", VA = "0x1361394")]
		protected DrawerAttribute()
		{
		}
	}
	[Token(Token = "0x2000341")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E9050", Offset = "0x9E9050")]
	public class ShowIfAttribute : DrawerAttribute
	{
		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string fieldName;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly int checkValue;

		[Token(Token = "0x17000190")]
		public override int priority
		{
			[Token(Token = "0x6000EAB")]
			[Address(RVA = "0x1BC0B28", Offset = "0x1BC0B28", VA = "0x1BC0B28", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000EAC")]
		[Address(RVA = "0x1BC0B30", Offset = "0x1BC0B30", VA = "0x1BC0B30")]
		public ShowIfAttribute(string fieldName, int checkValue)
		{
		}
	}
	[Token(Token = "0x2000342")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E9064", Offset = "0x9E9064")]
	public class RequiredFieldAttribute : DrawerAttribute
	{
		[Token(Token = "0x17000191")]
		public override int priority
		{
			[Token(Token = "0x6000EAD")]
			[Address(RVA = "0x1BBE268", Offset = "0x1BBE268", VA = "0x1BBE268", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000EAE")]
		[Address(RVA = "0x1BBE270", Offset = "0x1BBE270", VA = "0x1BBE270")]
		public RequiredFieldAttribute()
		{
		}
	}
	[Token(Token = "0x2000343")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E9078", Offset = "0x9E9078")]
	public class CallbackAttribute : DrawerAttribute
	{
		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string methodName;

		[Token(Token = "0x17000192")]
		public override int priority
		{
			[Token(Token = "0x6000EAF")]
			[Address(RVA = "0x1361358", Offset = "0x1361358", VA = "0x1361358", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000EB0")]
		[Address(RVA = "0x1361360", Offset = "0x1361360", VA = "0x1361360")]
		public CallbackAttribute(string methodName)
		{
		}
	}
	[Token(Token = "0x2000344")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E908C", Offset = "0x9E908C")]
	public class MinValueAttribute : DrawerAttribute
	{
		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly float min;

		[Token(Token = "0x17000193")]
		public override int priority
		{
			[Token(Token = "0x6000EB1")]
			[Address(RVA = "0x1517314", Offset = "0x1517314", VA = "0x1517314", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000EB2")]
		[Address(RVA = "0x151731C", Offset = "0x151731C", VA = "0x151731C")]
		public MinValueAttribute(float min)
		{
		}

		[Token(Token = "0x6000EB3")]
		[Address(RVA = "0x1517350", Offset = "0x1517350", VA = "0x1517350")]
		public MinValueAttribute(int min)
		{
		}
	}
	[Token(Token = "0x2000345")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E90A0", Offset = "0x9E90A0")]
	public class DelayedFieldAttribute : DrawerAttribute
	{
		[Token(Token = "0x6000EB4")]
		[Address(RVA = "0x1368200", Offset = "0x1368200", VA = "0x1368200")]
		public DelayedFieldAttribute()
		{
		}
	}
	[Token(Token = "0x2000346")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E90B4", Offset = "0x9E90B4")]
	public class LayerFieldAttribute : DrawerAttribute
	{
		[Token(Token = "0x6000EB5")]
		[Address(RVA = "0x151246C", Offset = "0x151246C", VA = "0x151246C")]
		public LayerFieldAttribute()
		{
		}
	}
	[Token(Token = "0x2000347")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E90C8", Offset = "0x9E90C8")]
	public class TagFieldAttribute : DrawerAttribute
	{
		[Token(Token = "0x6000EB6")]
		[Address(RVA = "0x1BC4150", Offset = "0x1BC4150", VA = "0x1BC4150")]
		public TagFieldAttribute()
		{
		}
	}
	[Token(Token = "0x2000348")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E90DC", Offset = "0x9E90DC")]
	public class TextAreaFieldAttribute : DrawerAttribute
	{
		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly int numberOfLines;

		[Token(Token = "0x6000EB7")]
		[Address(RVA = "0x1BC6B04", Offset = "0x1BC6B04", VA = "0x1BC6B04")]
		public TextAreaFieldAttribute(int numberOfLines)
		{
		}
	}
	[Token(Token = "0x2000349")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E90F0", Offset = "0x9E90F0")]
	public class PopupFieldAttribute : DrawerAttribute
	{
		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly object[] options;

		[Token(Token = "0x6000EB8")]
		[Address(RVA = "0x151DDDC", Offset = "0x151DDDC", VA = "0x151DDDC")]
		public PopupFieldAttribute(params object[] options)
		{
		}
	}
	[Token(Token = "0x200034A")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E9104", Offset = "0x9E9104")]
	public class SliderFieldAttribute : DrawerAttribute
	{
		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly float min;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public readonly float max;

		[Token(Token = "0x6000EB9")]
		[Address(RVA = "0x1BC112C", Offset = "0x1BC112C", VA = "0x1BC112C")]
		public SliderFieldAttribute(float min, float max)
		{
		}

		[Token(Token = "0x6000EBA")]
		[Address(RVA = "0x1BC1164", Offset = "0x1BC1164", VA = "0x1BC1164")]
		public SliderFieldAttribute(int min, int max)
		{
		}
	}
	[Token(Token = "0x200034B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E9118", Offset = "0x9E9118")]
	public class ShowButtonAttribute : DrawerAttribute
	{
		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string buttonTitle;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string methodnameCallback;

		[Token(Token = "0x6000EBB")]
		[Address(RVA = "0x1BC0AD8", Offset = "0x1BC0AD8", VA = "0x1BC0AD8")]
		public ShowButtonAttribute(string buttonTitle, string methodnameCallback)
		{
		}
	}
	[Token(Token = "0x200034C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9E912C", Offset = "0x9E912C")]
	public class ForceObjectFieldAttribute : DrawerAttribute
	{
		[Token(Token = "0x6000EBC")]
		[Address(RVA = "0x1370F80", Offset = "0x1370F80", VA = "0x1370F80")]
		public ForceObjectFieldAttribute()
		{
		}
	}
}
