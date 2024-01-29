using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Edelweiss.Pattern;
using Il2CppDummyDll;
using SPStudios.SerializableDictionary;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Edelweiss.Coroutine.Examples
{
	[Token(Token = "0x2000002")]
	public class ExceptionThrowingSafeCoroutinesExample : MonoBehaviour
	{
		[Token(Token = "0x200024F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B271C", Offset = "0x2B271C")]
		private sealed class <ExceptionThrowingCoroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal ExceptionThrowingSafeCoroutinesExample $this;

			[Token(Token = "0x40009BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x40009BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x40009C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x17000022")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A55")]
				[Address(RVA = "0x36AD7C", Offset = "0x36AD7C", VA = "0x36AD7C", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000023")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A56")]
				[Address(RVA = "0x36AD84", Offset = "0x36AD84", VA = "0x36AD84", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x36A830", Offset = "0x36A830", VA = "0x36A830")]
			[DebuggerHidden]
			public <ExceptionThrowingCoroutine>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x36AC88", Offset = "0x36AC88", VA = "0x36AC88", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x36AD8C", Offset = "0x36AD8C", VA = "0x36AD8C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x36ADA0", Offset = "0x36ADA0", VA = "0x36ADA0", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private SafeCoroutine m_ExceptionThrowingCoroutine;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_ThrowExceptionInNextFrame;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x36A6B0", Offset = "0x36A6B0", VA = "0x36A6B0")]
		public ExceptionThrowingSafeCoroutinesExample()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x36A6B8", Offset = "0x36A6B8", VA = "0x36A6B8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x36A6F4", Offset = "0x36A6F4", VA = "0x36A6F4")]
		[DebuggerHidden]
		private IEnumerator ExceptionThrowingCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x36A838", Offset = "0x36A838", VA = "0x36A838")]
		private void OnGUI()
		{
		}
	}
	[Token(Token = "0x2000003")]
	public class ExecutionOrderSafeCoroutinesExample : MonoBehaviour
	{
		[Token(Token = "0x2000250")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B27AC", Offset = "0x2B27AC")]
		private sealed class <FixedUpdateCoroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal string a_Name;

			[Token(Token = "0x40009C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x40009C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x40009C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x17000024")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A5B")]
				[Address(RVA = "0x36B5F0", Offset = "0x36B5F0", VA = "0x36B5F0", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000025")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A5C")]
				[Address(RVA = "0x36B5F8", Offset = "0x36B5F8", VA = "0x36B5F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A59")]
			[Address(RVA = "0x36B0E8", Offset = "0x36B0E8", VA = "0x36B0E8")]
			[DebuggerHidden]
			public <FixedUpdateCoroutine>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0x36B4A4", Offset = "0x36B4A4", VA = "0x36B4A4", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0x36B600", Offset = "0x36B600", VA = "0x36B600", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0x36B614", Offset = "0x36B614", VA = "0x36B614", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000251")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B280C", Offset = "0x2B280C")]
		private sealed class <UpdateCoroutine>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal string a_Name;

			[Token(Token = "0x40009C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x40009C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x40009C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x17000026")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A61")]
				[Address(RVA = "0x36B7C8", Offset = "0x36B7C8", VA = "0x36B7C8", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000027")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A62")]
				[Address(RVA = "0x36B7D0", Offset = "0x36B7D0", VA = "0x36B7D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0x36B0F0", Offset = "0x36B0F0", VA = "0x36B0F0")]
			[DebuggerHidden]
			public <UpdateCoroutine>c__Iterator1()
			{
			}

			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x36B698", Offset = "0x36B698", VA = "0x36B698", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x36B7D8", Offset = "0x36B7D8", VA = "0x36B7D8", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x36B7EC", Offset = "0x36B7EC", VA = "0x36B7EC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000252")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B286C", Offset = "0x2B286C")]
		private sealed class <EndOfFrameCoroutine>c__Iterator2 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal string a_Name;

			[Token(Token = "0x40009CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x40009CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x40009CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x17000028")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A67")]
				[Address(RVA = "0x36B3FC", Offset = "0x36B3FC", VA = "0x36B3FC", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000029")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A68")]
				[Address(RVA = "0x36B404", Offset = "0x36B404", VA = "0x36B404", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A65")]
			[Address(RVA = "0x36B0F8", Offset = "0x36B0F8", VA = "0x36B0F8")]
			[DebuggerHidden]
			public <EndOfFrameCoroutine>c__Iterator2()
			{
			}

			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x36B2B0", Offset = "0x36B2B0", VA = "0x36B2B0", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x36B40C", Offset = "0x36B40C", VA = "0x36B40C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0x36B420", Offset = "0x36B420", VA = "0x36B420", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x36AE24", Offset = "0x36AE24", VA = "0x36AE24")]
		public ExecutionOrderSafeCoroutinesExample()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x36AE2C", Offset = "0x36AE2C", VA = "0x36AE2C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x36AF68", Offset = "0x36AF68", VA = "0x36AF68")]
		[DebuggerHidden]
		private IEnumerator FixedUpdateCoroutine(string a_Name)
		{
			return null;
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x36AFE8", Offset = "0x36AFE8", VA = "0x36AFE8")]
		[DebuggerHidden]
		private IEnumerator UpdateCoroutine(string a_Name)
		{
			return null;
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x36B068", Offset = "0x36B068", VA = "0x36B068")]
		[DebuggerHidden]
		private IEnumerator EndOfFrameCoroutine(string a_Name)
		{
			return null;
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x36B100", Offset = "0x36B100", VA = "0x36B100")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x36B190", Offset = "0x36B190", VA = "0x36B190")]
		private void Update()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x36B220", Offset = "0x36B220", VA = "0x36B220")]
		private void LateUpdate()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public class FailingNestedSafeCoroutinesExample : MonoBehaviour
	{
		[Token(Token = "0x2000253")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B28FC", Offset = "0x2B28FC")]
		private sealed class <OuterExampleCoroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal FailingNestedSafeCoroutinesExample $this;

			[Token(Token = "0x40009CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x40009CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x40009D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x1700002A")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A6D")]
				[Address(RVA = "0x36C5C0", Offset = "0x36C5C0", VA = "0x36C5C0", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A6E")]
				[Address(RVA = "0x36C5C8", Offset = "0x36C5C8", VA = "0x36C5C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x36B924", Offset = "0x36B924", VA = "0x36B924")]
			[DebuggerHidden]
			public <OuterExampleCoroutine>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x36C478", Offset = "0x36C478", VA = "0x36C478", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A6F")]
			[Address(RVA = "0x36C5D0", Offset = "0x36C5D0", VA = "0x36C5D0", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A70")]
			[Address(RVA = "0x36C5E4", Offset = "0x36C5E4", VA = "0x36C5E4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000254")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B295C", Offset = "0x2B295C")]
		private sealed class <InnerExampleCoroutine>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal FailingNestedSafeCoroutinesExample $this;

			[Token(Token = "0x40009D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x40009D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x40009D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x1700002C")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A73")]
				[Address(RVA = "0x36C3D0", Offset = "0x36C3D0", VA = "0x36C3D0", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A74")]
				[Address(RVA = "0x36C3D8", Offset = "0x36C3D8", VA = "0x36C3D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A71")]
			[Address(RVA = "0x36B9AC", Offset = "0x36B9AC", VA = "0x36B9AC")]
			[DebuggerHidden]
			public <InnerExampleCoroutine>c__Iterator1()
			{
			}

			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x36C330", Offset = "0x36C330", VA = "0x36C330", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A75")]
			[Address(RVA = "0x36C3E0", Offset = "0x36C3E0", VA = "0x36C3E0", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A76")]
			[Address(RVA = "0x36C3F4", Offset = "0x36C3F4", VA = "0x36C3F4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private bool m_UseUnityCoroutineToFail;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private SafeCoroutine m_OuterCoroutine;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private SafeCoroutine m_InnerCoroutine;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_InnerCoroutineTimer;

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x36B870", Offset = "0x36B870", VA = "0x36B870")]
		public FailingNestedSafeCoroutinesExample()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x36B880", Offset = "0x36B880", VA = "0x36B880")]
		private void Awake()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x36B8A4", Offset = "0x36B8A4", VA = "0x36B8A4")]
		[DebuggerHidden]
		private IEnumerator OuterExampleCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x36B92C", Offset = "0x36B92C", VA = "0x36B92C")]
		[DebuggerHidden]
		private IEnumerator InnerExampleCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x36B9B4", Offset = "0x36B9B4", VA = "0x36B9B4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x36BC90", Offset = "0x36BC90", VA = "0x36BC90")]
		private static void CoroutineGUI(string a_Name, SafeCoroutine a_SafeCoroutine)
		{
		}
	}
	[Token(Token = "0x2000005")]
	public class NestedSafeCoroutinesExample : MonoBehaviour
	{
		[Token(Token = "0x2000255")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B29EC", Offset = "0x2B29EC")]
		private sealed class <OuterExampleCoroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal NestedSafeCoroutinesExample $this;

			[Token(Token = "0x40009D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x40009D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x40009D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x1700002E")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A79")]
				[Address(RVA = "0x36D0F8", Offset = "0x36D0F8", VA = "0x36D0F8", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A7A")]
				[Address(RVA = "0x36D100", Offset = "0x36D100", VA = "0x36D100", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A77")]
			[Address(RVA = "0x36C714", Offset = "0x36C714", VA = "0x36C714")]
			[DebuggerHidden]
			public <OuterExampleCoroutine>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A78")]
			[Address(RVA = "0x36D008", Offset = "0x36D008", VA = "0x36D008", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x36D108", Offset = "0x36D108", VA = "0x36D108", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x36D11C", Offset = "0x36D11C", VA = "0x36D11C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000256")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B2A4C", Offset = "0x2B2A4C")]
		private sealed class <InnerExampleCoroutine>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal NestedSafeCoroutinesExample $this;

			[Token(Token = "0x40009DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x40009DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x40009DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x17000030")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A7F")]
				[Address(RVA = "0x36CF60", Offset = "0x36CF60", VA = "0x36CF60", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000031")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A80")]
				[Address(RVA = "0x36CF68", Offset = "0x36CF68", VA = "0x36CF68", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x36C79C", Offset = "0x36C79C", VA = "0x36C79C")]
			[DebuggerHidden]
			public <InnerExampleCoroutine>c__Iterator1()
			{
			}

			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0x36CEC0", Offset = "0x36CEC0", VA = "0x36CEC0", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x36CF70", Offset = "0x36CF70", VA = "0x36CF70", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x36CF84", Offset = "0x36CF84", VA = "0x36CF84", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private bool m_FinishOuterCoroutineAutomatically;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private SafeCoroutine m_OuterCoroutine;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private SafeCoroutine m_InnerCoroutine;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_InnerCoroutineTimer;

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x36C668", Offset = "0x36C668", VA = "0x36C668")]
		public NestedSafeCoroutinesExample()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x36C670", Offset = "0x36C670", VA = "0x36C670")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x36C694", Offset = "0x36C694", VA = "0x36C694")]
		[DebuggerHidden]
		private IEnumerator OuterExampleCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x36C71C", Offset = "0x36C71C", VA = "0x36C71C")]
		[DebuggerHidden]
		private IEnumerator InnerExampleCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x36C7A4", Offset = "0x36C7A4", VA = "0x36C7A4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x36C8F8", Offset = "0x36C8F8", VA = "0x36C8F8")]
		private static void CoroutineStateGUI(string a_Name, SafeCoroutine a_SafeCoroutine)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x36CAE4", Offset = "0x36CAE4", VA = "0x36CAE4")]
		private static void CoroutineGUI(string a_Name, SafeCoroutine a_SafeCoroutine)
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class NotifierSafeCoroutinesExample : MonoBehaviour
	{
		[Token(Token = "0x2000257")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B2ACC", Offset = "0x2B2ACC")]
		private sealed class <SimpleCoroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal NotifierSafeCoroutinesExample $this;

			[Token(Token = "0x40009DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x40009DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x40009E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x17000032")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A85")]
				[Address(RVA = "0x36E9A0", Offset = "0x36E9A0", VA = "0x36E9A0", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000033")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A86")]
				[Address(RVA = "0x36E9A8", Offset = "0x36E9A8", VA = "0x36E9A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x36D56C", Offset = "0x36D56C", VA = "0x36D56C")]
			[DebuggerHidden]
			public <SimpleCoroutine>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A84")]
			[Address(RVA = "0x36E92C", Offset = "0x36E92C", VA = "0x36E92C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x36E9B0", Offset = "0x36E9B0", VA = "0x36E9B0", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x36E9C4", Offset = "0x36E9C4", VA = "0x36E9C4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000258")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B2B2C", Offset = "0x2B2B2C")]
		private sealed class <ResultReturningCoroutine>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal NotifierSafeCoroutinesExample $this;

			[Token(Token = "0x40009E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x40009E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x40009E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x17000034")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A8B")]
				[Address(RVA = "0x36E884", Offset = "0x36E884", VA = "0x36E884", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000035")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A8C")]
				[Address(RVA = "0x36E88C", Offset = "0x36E88C", VA = "0x36E88C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x36D574", Offset = "0x36D574", VA = "0x36D574")]
			[DebuggerHidden]
			public <ResultReturningCoroutine>c__Iterator1()
			{
			}

			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x36E778", Offset = "0x36E778", VA = "0x36E778", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x36E894", Offset = "0x36E894", VA = "0x36E894", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x36E8A8", Offset = "0x36E8A8", VA = "0x36E8A8", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private SafeCoroutine m_SafeCoroutine;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_FinishSafeCoroutineInNextFrame;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private SafeCoroutine<float> m_ResultReturningSafeCoroutine;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_FinishResultReturningSafeCoroutineInNextFrame;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector2 m_ScrollPosition;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private string m_Messages;

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x36D1A0", Offset = "0x36D1A0", VA = "0x36D1A0")]
		public NotifierSafeCoroutinesExample()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x36D240", Offset = "0x36D240", VA = "0x36D240")]
		private void Awake()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x36D3F8", Offset = "0x36D3F8", VA = "0x36D3F8")]
		[DebuggerHidden]
		private IEnumerator SimpleCoroutine()
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x36D4EC", Offset = "0x36D4EC", VA = "0x36D4EC")]
		[DebuggerHidden]
		private IEnumerator ResultReturningCoroutine()
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x36D57C", Offset = "0x36D57C", VA = "0x36D57C")]
		private void OnSafeCoroutineStateChange(SafeCoroutineState a_State)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x36D89C", Offset = "0x36D89C", VA = "0x36D89C")]
		private void OnResultReturningSafeCoroutineStateChange(SafeCoroutine<float> a_SafeCoroutine, SafeCoroutineState a_State)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x36DE00", Offset = "0x36DE00", VA = "0x36DE00")]
		private void OnGUI()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class ResultReturningSafeCoroutinesExample : MonoBehaviour
	{
		[Token(Token = "0x2000259")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B2B9C", Offset = "0x2B2B9C")]
		private sealed class <ResultReturningCoroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal ResultReturningSafeCoroutinesExample $this;

			[Token(Token = "0x40009E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x40009E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x40009E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x17000036")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A91")]
				[Address(RVA = "0x36EED0", Offset = "0x36EED0", VA = "0x36EED0", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000037")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A92")]
				[Address(RVA = "0x36EED8", Offset = "0x36EED8", VA = "0x36EED8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x36EB48", Offset = "0x36EB48", VA = "0x36EB48")]
			[DebuggerHidden]
			public <ResultReturningCoroutine>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x36EDC4", Offset = "0x36EDC4", VA = "0x36EDC4", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A93")]
			[Address(RVA = "0x36EEE0", Offset = "0x36EEE0", VA = "0x36EEE0", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x36EEF4", Offset = "0x36EEF4", VA = "0x36EEF4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private SafeCoroutine<float> m_ResultReturningCoroutine;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_ReturnResultInNextFrame;

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x36EA48", Offset = "0x36EA48", VA = "0x36EA48")]
		public ResultReturningSafeCoroutinesExample()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x36EA50", Offset = "0x36EA50", VA = "0x36EA50")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x36EAC8", Offset = "0x36EAC8", VA = "0x36EAC8")]
		[DebuggerHidden]
		private IEnumerator ResultReturningCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x36EB50", Offset = "0x36EB50", VA = "0x36EB50")]
		private void OnGUI()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class SimpleNotifierSafeCoroutinesExample : MonoBehaviour
	{
		[Token(Token = "0x200025A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B2C0C", Offset = "0x2B2C0C")]
		private sealed class <ResultReturningCoroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal object $current;

			[Token(Token = "0x40009EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal bool $disposing;

			[Token(Token = "0x40009EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int $PC;

			[Token(Token = "0x17000038")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A97")]
				[Address(RVA = "0x36F5B4", Offset = "0x36F5B4", VA = "0x36F5B4", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000039")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A98")]
				[Address(RVA = "0x36F5BC", Offset = "0x36F5BC", VA = "0x36F5BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A95")]
			[Address(RVA = "0x36F0F8", Offset = "0x36F0F8", VA = "0x36F0F8")]
			[DebuggerHidden]
			public <ResultReturningCoroutine>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A96")]
			[Address(RVA = "0x36F4A8", Offset = "0x36F4A8", VA = "0x36F4A8", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A99")]
			[Address(RVA = "0x36F5C4", Offset = "0x36F5C4", VA = "0x36F5C4", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0x36F5D8", Offset = "0x36F5D8", VA = "0x36F5D8", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x36EF78", Offset = "0x36EF78", VA = "0x36EF78")]
		public SimpleNotifierSafeCoroutinesExample()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x36EF80", Offset = "0x36EF80", VA = "0x36EF80")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x36F08C", Offset = "0x36F08C", VA = "0x36F08C")]
		[DebuggerHidden]
		private IEnumerator ResultReturningCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x36F100", Offset = "0x36F100", VA = "0x36F100")]
		private void OnResultReturningSafeCoroutineStateChange(SafeCoroutine<float> a_SafeCoroutine, SafeCoroutineState a_State)
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class SimpleSafeCoroutinesExample : MonoBehaviour
	{
		[Token(Token = "0x200025B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B2C7C", Offset = "0x2B2C7C")]
		private sealed class <ExampleCoroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal object $current;

			[Token(Token = "0x40009ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal bool $disposing;

			[Token(Token = "0x40009EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int $PC;

			[Token(Token = "0x1700003A")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A9D")]
				[Address(RVA = "0x36FCEC", Offset = "0x36FCEC", VA = "0x36FCEC", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A9E")]
				[Address(RVA = "0x36FCF4", Offset = "0x36FCF4", VA = "0x36FCF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0x36F708", Offset = "0x36F708", VA = "0x36F708")]
			[DebuggerHidden]
			public <ExampleCoroutine>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0x36FCAC", Offset = "0x36FCAC", VA = "0x36FCAC", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A9F")]
			[Address(RVA = "0x36FCFC", Offset = "0x36FCFC", VA = "0x36FCFC", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0x36FD10", Offset = "0x36FD10", VA = "0x36FD10", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private SafeCoroutine m_SafeCoroutine1;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private SafeCoroutine m_SafeCoroutine2;

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x36F65C", Offset = "0x36F65C", VA = "0x36F65C")]
		public SimpleSafeCoroutinesExample()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x36F664", Offset = "0x36F664", VA = "0x36F664")]
		private void Awake()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x36F69C", Offset = "0x36F69C", VA = "0x36F69C")]
		[DebuggerHidden]
		private IEnumerator ExampleCoroutine()
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x36F710", Offset = "0x36F710", VA = "0x36F710")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x36F8E4", Offset = "0x36F8E4", VA = "0x36F8E4")]
		private static void CoroutineGUI(string a_Name, SafeCoroutine a_SafeCoroutine)
		{
		}
	}
}
namespace Edelweiss.Coroutine
{
	[Token(Token = "0x200000A")]
	public class SafeCoroutine
	{
		[Token(Token = "0x200025C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B2CEC", Offset = "0x2B2CEC")]
		private sealed class <WrappingCoroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal IEnumerator a_Coroutine;

			[Token(Token = "0x40009F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object <l_Yield>__1;

			[Token(Token = "0x40009F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal SafeCoroutine <l_EncapsulatedSafeCoroutine>__1;

			[Token(Token = "0x40009F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal bool <l_HasEncapsulatedSafeCoroutine>__1;

			[Token(Token = "0x40009F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal SafeCoroutine $this;

			[Token(Token = "0x40009F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal object $current;

			[Token(Token = "0x40009F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal bool $disposing;

			[Token(Token = "0x40009F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal int $PC;

			[Token(Token = "0x1700003C")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000AA3")]
				[Address(RVA = "0x3709DC", Offset = "0x3709DC", VA = "0x3709DC", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AA4")]
				[Address(RVA = "0x3709E4", Offset = "0x3709E4", VA = "0x3709E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0x370544", Offset = "0x370544", VA = "0x370544")]
			[DebuggerHidden]
			public <WrappingCoroutine>c__Iterator0()
			{
			}

			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0x37054C", Offset = "0x37054C", VA = "0x37054C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x3709EC", Offset = "0x3709EC", VA = "0x3709EC", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x370A00", Offset = "0x370A00", VA = "0x370A00", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly ModifiablePropertyChangeNotifier<SafeCoroutine, SafeCoroutineState> m_StateChangeNotifier;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private bool m_IsSelfPaused;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		private bool m_IsParentPaused;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected internal IEnumerator m_WrappedCoroutine;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool m_CatchExceptions;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Exception m_Exception;

		[Token(Token = "0x17000001")]
		public PropertyChangeNotifier<SafeCoroutine, SafeCoroutineState> StateChangeNotifier
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x36D478", Offset = "0x36D478", VA = "0x36D478")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public SafeCoroutineState State
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x36AB2C", Offset = "0x36AB2C", VA = "0x36AB2C")]
			get
			{
				return default(SafeCoroutineState);
			}
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x36FE38", Offset = "0x36FE38", VA = "0x36FE38")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public bool IsRunning
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x36AC70", Offset = "0x36AC70", VA = "0x36AC70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000004")]
		public bool IsPaused
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x36C238", Offset = "0x36C238", VA = "0x36C238")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000005")]
		public bool IsSelfPaused
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x36C050", Offset = "0x36C050", VA = "0x36C050")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000006")]
		public bool IsParentPaused
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x36C14C", Offset = "0x36C14C", VA = "0x36C14C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000007")]
		public bool HasFinished
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x36FEC8", Offset = "0x36FEC8", VA = "0x36FEC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public bool IsStopped
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x36FEE8", Offset = "0x36FEE8", VA = "0x36FEE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		public bool ThrewException
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x36ABA0", Offset = "0x36ABA0", VA = "0x36ABA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		internal virtual IEnumerator WrappedCoroutine
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x36FF08", Offset = "0x36FF08", VA = "0x36FF08", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		public bool CatchExceptions
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x37005C", Offset = "0x37005C", VA = "0x37005C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x36A828", Offset = "0x36A828", VA = "0x36A828")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Exception ThrownException
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x36ABC0", Offset = "0x36ABC0", VA = "0x36ABC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x36FD94", Offset = "0x36FD94", VA = "0x36FD94")]
		internal SafeCoroutine(IEnumerator a_WrappedCoroutine)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x36C154", Offset = "0x36C154", VA = "0x36C154")]
		public void Pause()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x370064", Offset = "0x370064", VA = "0x370064")]
		private void PauseChildCoroutines()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x36C058", Offset = "0x36C058", VA = "0x36C058")]
		public void Resume()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x370210", Offset = "0x370210", VA = "0x370210")]
		private void ResumeChildCoroutines()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x36C25C", Offset = "0x36C25C", VA = "0x36C25C")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x3703B0", Offset = "0x3703B0", VA = "0x3703B0")]
		private void StopChildRoutines()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x36FFC4", Offset = "0x36FFC4", VA = "0x36FFC4")]
		[DebuggerHidden]
		private IEnumerator WrappingCoroutine(IEnumerator a_Coroutine)
		{
			return null;
		}
	}
	[Token(Token = "0x200000B")]
	public class SafeCoroutine<G> : SafeCoroutine
	{
		[Token(Token = "0x200025D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B2D5C", Offset = "0x2B2D5C")]
		private sealed class <WrappingCoroutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal IEnumerator a_Coroutine;

			[Token(Token = "0x40009F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal object <l_Yield>__1;

			[Token(Token = "0x40009F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal SafeCoroutine <l_EncapsulatedSafeCoroutine>__1;

			[Token(Token = "0x40009FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal bool <l_HasEncapsulatedSafeCoroutine>__1;

			[Token(Token = "0x40009FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal SafeCoroutine<G> $this;

			[Token(Token = "0x40009FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal object $current;

			[Token(Token = "0x40009FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal bool $disposing;

			[Token(Token = "0x40009FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int $PC;

			[Token(Token = "0x1700003E")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000AA9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AAA")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AA7")]
			[DebuggerHidden]
			public <WrappingCoroutine>c__Iterator0()
			{
			}

			[Token(Token = "0x6000AA8")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AAB")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000AAC")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ModifiablePropertyChangeNotifier<SafeCoroutine<G>, SafeCoroutineState> m_StateChangeNotifier;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private G m_Result;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_HasResult;

		[Token(Token = "0x1700000D")]
		public PropertyChangeNotifier<SafeCoroutine<G>, SafeCoroutineState> GenericStateChangeNotifier
		{
			[Token(Token = "0x6000045")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		internal override IEnumerator WrappedCoroutine
		{
			[Token(Token = "0x6000046")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public G Result
		{
			[Token(Token = "0x6000047")]
			get
			{
				return (G)null;
			}
		}

		[Token(Token = "0x17000010")]
		public bool HasResult
		{
			[Token(Token = "0x6000048")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000044")]
		internal SafeCoroutine(IEnumerator a_InternalCoroutine)
		{
		}

		[Token(Token = "0x6000049")]
		private void PropagateStateChange(SafeCoroutineState a_State)
		{
		}

		[Token(Token = "0x600004A")]
		[DebuggerHidden]
		private IEnumerator WrappingCoroutine(IEnumerator a_Coroutine)
		{
			return null;
		}
	}
	[Token(Token = "0x200000C")]
	public static class SafeCoroutineExtension
	{
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x36A774", Offset = "0x36A774", VA = "0x36A774")]
		public static SafeCoroutine StartSafeCoroutine(this MonoBehaviour a_MonoBehaviour, IEnumerator a_SafeCoroutine)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		public static SafeCoroutine<TResult> StartSafeCoroutine<TResult>(this MonoBehaviour a_MonoBehaviour, IEnumerator a_SafeCoroutine)
		{
			return null;
		}
	}
	[Token(Token = "0x200000D")]
	public enum SafeCoroutineState
	{
		[Token(Token = "0x400001F")]
		Created,
		[Token(Token = "0x4000020")]
		Running,
		[Token(Token = "0x4000021")]
		Paused,
		[Token(Token = "0x4000022")]
		Finished,
		[Token(Token = "0x4000023")]
		Stopped,
		[Token(Token = "0x4000024")]
		ThrewException
	}
}
namespace Edelweiss.Pattern
{
	[Token(Token = "0x200000E")]
	public class CommandNotifier<TSender> where TSender : class
	{
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ExecutableCommandNotifier<TSender> m_ExecutableCommandNotifier;

		[Token(Token = "0x600004D")]
		internal CommandNotifier(ExecutableCommandNotifier<TSender> a_ExecutableCommandNotifier)
		{
		}

		[Token(Token = "0x600004E")]
		public void Subscribe(Action a_Subscriber)
		{
		}

		[Token(Token = "0x600004F")]
		public void Subscribe(Action<TSender> a_Subscriber)
		{
		}

		[Token(Token = "0x6000050")]
		public void Unsubscribe(Action a_Subscriber)
		{
		}

		[Token(Token = "0x6000051")]
		public void Unsubscribe(Action<TSender> a_Subscriber)
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class CommandNotifier<TSender, TArgument> where TSender : class
	{
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ExecutableCommandNotifier<TSender, TArgument> m_ExecutableCommandNotifier;

		[Token(Token = "0x6000052")]
		internal CommandNotifier(ExecutableCommandNotifier<TSender, TArgument> a_ExecutableCommandNotifier)
		{
		}

		[Token(Token = "0x6000053")]
		public void Subscribe(Action<TArgument> a_Subscriber)
		{
		}

		[Token(Token = "0x6000054")]
		public void Subscribe(Action<TSender, TArgument> a_Subscriber)
		{
		}

		[Token(Token = "0x6000055")]
		public void Unsubscribe(Action<TArgument> a_Subscriber)
		{
		}

		[Token(Token = "0x6000056")]
		public void Unsubscribe(Action<TSender, TArgument> a_Subscriber)
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class ExecutableCommandNotifier<TSender> : IDisposable where TSender : class
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TSender m_Sender;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action m_Notifier;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<TSender> m_NotifierWithSender;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly CommandNotifier<TSender> m_CommandNotifier;

		[Token(Token = "0x17000011")]
		public TSender Sender
		{
			[Token(Token = "0x6000058")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public CommandNotifier<TSender> CommandNotifier
		{
			[Token(Token = "0x6000059")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000057")]
		public ExecutableCommandNotifier(TSender a_Sender)
		{
		}

		[Token(Token = "0x600005A")]
		public void Execute()
		{
		}

		[Token(Token = "0x600005B")]
		public void Subscribe(Action a_Subscriber)
		{
		}

		[Token(Token = "0x600005C")]
		public void Subscribe(Action<TSender> a_Subscriber)
		{
		}

		[Token(Token = "0x600005D")]
		public void Unsubscribe(Action a_Subscriber)
		{
		}

		[Token(Token = "0x600005E")]
		public void Unsubscribe(Action<TSender> a_Subscriber)
		{
		}

		[Token(Token = "0x600005F")]
		private void System.IDisposable.Dispose()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class ExecutableCommandNotifier<TSender, TArgument> : IDisposable where TSender : class
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TSender m_Sender;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<TArgument> m_Notifier;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<TSender, TArgument> m_NotifierWithSender;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly CommandNotifier<TSender, TArgument> m_CommandNotifier;

		[Token(Token = "0x17000013")]
		public TSender Sender
		{
			[Token(Token = "0x6000061")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public CommandNotifier<TSender, TArgument> CommandNotifier
		{
			[Token(Token = "0x6000062")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000060")]
		public ExecutableCommandNotifier(TSender a_Sender)
		{
		}

		[Token(Token = "0x6000063")]
		public void Execute(TArgument a_Argument)
		{
		}

		[Token(Token = "0x6000064")]
		public void Subscribe(Action<TArgument> a_Subscriber)
		{
		}

		[Token(Token = "0x6000065")]
		public void Subscribe(Action<TSender, TArgument> a_Subscriber)
		{
		}

		[Token(Token = "0x6000066")]
		public void Unsubscribe(Action<TArgument> a_Subscriber)
		{
		}

		[Token(Token = "0x6000067")]
		public void Unsubscribe(Action<TSender, TArgument> a_Subscriber)
		{
		}

		[Token(Token = "0x6000068")]
		private void System.IDisposable.Dispose()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class ModifiablePropertyChangeNotifier<TSender, TProperty> : IDisposable where TSender : class
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TSender m_Sender;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<TProperty> m_Notifier;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<TSender, TProperty> m_NotifierWithSender;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TProperty m_Value;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly PropertyChangeNotifier<TSender, TProperty> m_PropertyChangeNotifier;

		[Token(Token = "0x17000015")]
		public TSender Sender
		{
			[Token(Token = "0x600006B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public TProperty Value
		{
			[Token(Token = "0x600006C")]
			get
			{
				return (TProperty)null;
			}
			[Token(Token = "0x600006D")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public PropertyChangeNotifier<TSender, TProperty> PropertyChangeNotifier
		{
			[Token(Token = "0x600006E")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000069")]
		public ModifiablePropertyChangeNotifier(TSender a_Sender)
		{
		}

		[Token(Token = "0x600006A")]
		public ModifiablePropertyChangeNotifier(TSender a_Sender, TProperty a_Value)
		{
		}

		[Token(Token = "0x600006F")]
		public void Subscribe(Action<TProperty> a_Subscriber)
		{
		}

		[Token(Token = "0x6000070")]
		public void Subscribe(Action<TSender, TProperty> a_Subscriber)
		{
		}

		[Token(Token = "0x6000071")]
		public void Unsubscribe(Action<TProperty> a_Subscriber)
		{
		}

		[Token(Token = "0x6000072")]
		public void Unsubscribe(Action<TSender, TProperty> a_Subscriber)
		{
		}

		[Token(Token = "0x6000073")]
		private void System.IDisposable.Dispose()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class PropertyChangeNotifier<TSender, TProperty> where TSender : class
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ModifiablePropertyChangeNotifier<TSender, TProperty> m_ModifiablePropertyChangeNotifier;

		[Token(Token = "0x6000074")]
		internal PropertyChangeNotifier(ModifiablePropertyChangeNotifier<TSender, TProperty> a_ModifiablePropertyChangeNotifier)
		{
		}

		[Token(Token = "0x6000075")]
		public void Subscribe(Action<TProperty> a_Subscriber)
		{
		}

		[Token(Token = "0x6000076")]
		public void Subscribe(Action<TSender, TProperty> a_Subscriber)
		{
		}

		[Token(Token = "0x6000077")]
		public void Unsubscribe(Action<TProperty> a_Subscriber)
		{
		}

		[Token(Token = "0x6000078")]
		public void Unsubscribe(Action<TSender, TProperty> a_Subscriber)
		{
		}
	}
}
namespace SPStudios.Examples.Inspectionary
{
	[Token(Token = "0x2000014")]
	public class ComplexExample : MonoBehaviour
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B2DEC", Offset = "0x2B2DEC")]
		public ComplexExampleInspectionary TheInspectionary;

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x370C80", Offset = "0x370C80", VA = "0x370C80")]
		public ComplexExample()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x370C88", Offset = "0x370C88", VA = "0x370C88")]
		private void OnEnable()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000015")]
	public class ComplexExampleClass
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Color CubeColor;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CubePositionSettings CubeSettings;

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x371030", Offset = "0x371030", VA = "0x371030")]
		public ComplexExampleClass()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000016")]
	public class CubePositionSettings
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3 CubePosition;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Quaternion CubeRotation;

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x37144C", Offset = "0x37144C", VA = "0x37144C")]
		public CubePositionSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000017")]
	public class ComplexExampleInspectionary : InspectionaryDictionary<GameObject, ComplexExampleClass>
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x371038", Offset = "0x371038", VA = "0x371038")]
		public ComplexExampleInspectionary()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public enum CubeControllerSetting
	{
		[Token(Token = "0x400003B")]
		Horizontal,
		[Token(Token = "0x400003C")]
		Vertical,
		[Token(Token = "0x400003D")]
		Triangle
	}
	[Serializable]
	[Token(Token = "0x2000019")]
	public class CubeSettingColor : InspectionaryDictionary<CubeControllerSetting, Color>
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x371454", Offset = "0x371454", VA = "0x371454")]
		public CubeSettingColor()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001A")]
	public class CubeSettingVec3 : InspectionaryDictionary<CubeControllerSetting, Vector3>
	{
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x37151C", Offset = "0x37151C", VA = "0x37151C")]
		public CubeSettingVec3()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001B")]
	public class CubeSettingQuat : InspectionaryDictionary<CubeControllerSetting, Quaternion>
	{
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x3714B8", Offset = "0x3714B8", VA = "0x3714B8")]
		public CubeSettingQuat()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class CubeController : MonoBehaviour
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B2E38", Offset = "0x2B2E38")]
		public CubeSettingColor Colors;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B2E84", Offset = "0x2B2E84")]
		public CubeSettingVec3 Positions;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B2ED0", Offset = "0x2B2ED0")]
		public CubeSettingQuat Rotations;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B2F1C", Offset = "0x2B2F1C")]
		public CubeSettingVec3 Scales;

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x3711C8", Offset = "0x3711C8", VA = "0x3711C8")]
		public CubeController()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x3711D0", Offset = "0x3711D0", VA = "0x3711D0")]
		public void AdjustCube(CubeControllerSetting setting)
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class EnumExample : MonoBehaviour
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B2F68", Offset = "0x2B2F68")]
		public CubeEnumExampleInspectionary CubeDefinitions;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B2FB4", Offset = "0x2B2FB4")]
		public EnumComplexExampleInspectionary CubeSettings;

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x371650", Offset = "0x371650", VA = "0x371650")]
		public EnumExample()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x371658", Offset = "0x371658", VA = "0x371658")]
		private void OnEnable()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public enum ExampleCubeEnum
	{
		[Token(Token = "0x4000045")]
		Left,
		[Token(Token = "0x4000046")]
		Center,
		[Token(Token = "0x4000047")]
		Right
	}
	[Serializable]
	[Token(Token = "0x200001F")]
	public class CubeEnumExampleInspectionary : InspectionaryDictionary<GameObject, ExampleCubeEnum>
	{
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x3713E8", Offset = "0x3713E8", VA = "0x3713E8")]
		public CubeEnumExampleInspectionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000020")]
	public class EnumComplexExampleInspectionary : InspectionaryDictionary<ExampleCubeEnum, ComplexExampleClass>
	{
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x3715EC", Offset = "0x3715EC", VA = "0x3715EC")]
		public EnumComplexExampleInspectionary()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public enum InspectionaryExampleType
	{
		[Token(Token = "0x4000049")]
		Complex,
		[Token(Token = "0x400004A")]
		Enum,
		[Token(Token = "0x400004B")]
		Preconfigured
	}
	[Serializable]
	[Token(Token = "0x2000022")]
	public class ExampleToRunInspectionary : InspectionaryDictionary<InspectionaryExampleType, GameObject>
	{
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x372764", Offset = "0x372764", VA = "0x372764")]
		public ExampleToRunInspectionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000023")]
	public class DefaultCubeState
	{
		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3 Pos;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Quaternion Rot;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color Col;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x371580", Offset = "0x371580", VA = "0x371580")]
		public DefaultCubeState()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000024")]
	public class DefaultCubeStateInspectionary : InspectionaryDictionary<GameObject, DefaultCubeState>
	{
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x371588", Offset = "0x371588", VA = "0x371588")]
		public DefaultCubeStateInspectionary()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class ExampleSceneHandler : MonoBehaviour
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B3000", Offset = "0x2B3000")]
		public DefaultCubeStateInspectionary DefaultStates;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B304C", Offset = "0x2B304C")]
		public ExampleToRunInspectionary ExampleDictionary;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public InspectionaryExampleType StartType;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<CubeController> Cubes;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Rect DrawRect;

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x371B08", Offset = "0x371B08", VA = "0x371B08")]
		public ExampleSceneHandler()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x371BE8", Offset = "0x371BE8", VA = "0x371BE8")]
		private void Start()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x371DE4", Offset = "0x371DE4", VA = "0x371DE4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x3722BC", Offset = "0x3722BC", VA = "0x3722BC")]
		private void SetGameObjectStates(CubeControllerSetting type)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x371BF0", Offset = "0x371BF0", VA = "0x371BF0")]
		private void SetGameObjectStates(InspectionaryExampleType exampleType)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x37239C", Offset = "0x37239C", VA = "0x37239C")]
		private void ResetCubeStates()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class PreconfiguredExample : MonoBehaviour
	{
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public GameObjectBoolDictionary DisplayCubes;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B3098", Offset = "0x2B3098")]
		public GameObjectVector3Dictionary CubePositions;

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x3728F4", Offset = "0x3728F4", VA = "0x3728F4")]
		public PreconfiguredExample()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x372A54", Offset = "0x372A54", VA = "0x372A54")]
		private void OnEnable()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class PropertyTypeExample : MonoBehaviour
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B30E4", Offset = "0x2B30E4")]
		public AnimationCurveExampleInspectionary AnimationCurveExample;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B3130", Offset = "0x2B3130")]
		public BooleanExampleInspectionary BooleanExample;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B317C", Offset = "0x2B317C")]
		public BoundsExampleInspectionary BoundsExample;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B31C8", Offset = "0x2B31C8")]
		public CharacterExampleInspectionary CharacterExample;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B3214", Offset = "0x2B3214")]
		public ColorExampleInspectionary ColorExample;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B3260", Offset = "0x2B3260")]
		public EnumExampleInspectionary EnumExample;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B32AC", Offset = "0x2B32AC")]
		public FloatExampleInspectionary FloatExample;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B32F8", Offset = "0x2B32F8")]
		public IntegerExampleInspectionary IntegerExample;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B3344", Offset = "0x2B3344")]
		public ObjectReferenceExampleInspectionary ObjectReferenceExample;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B3390", Offset = "0x2B3390")]
		public RectExampleInspectionary RectExample;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B33DC", Offset = "0x2B33DC")]
		public StringExampleInspectionary StringExample;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B3428", Offset = "0x2B3428")]
		public Vector2ExampleInspectionary Vector2Example;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B3474", Offset = "0x2B3474")]
		public Vector3ExampleInspectionary Vector3Example;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B34C0", Offset = "0x2B34C0")]
		public QuaternionExampleInspectionary QuaternionExample;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B350C", Offset = "0x2B350C")]
		public Vector4ExampleInspectionary Vector4Example;

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x372D20", Offset = "0x372D20", VA = "0x372D20")]
		public PropertyTypeExample()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public enum PropertyTypeExampleEnum
	{
		[Token(Token = "0x4000066")]
		ExampleValue1,
		[Token(Token = "0x4000067")]
		ExampleValue2,
		[Token(Token = "0x4000068")]
		ExampleValue3,
		[Token(Token = "0x4000069")]
		ExampleValue4,
		[Token(Token = "0x400006A")]
		ExampleValue5
	}
	[Serializable]
	[Token(Token = "0x2000029")]
	public class AnimationCurveExampleInspectionary : InspectionaryDictionary<AnimationCurve, AnimationCurve>
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x370A84", Offset = "0x370A84", VA = "0x370A84")]
		public AnimationCurveExampleInspectionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002A")]
	public class BooleanExampleInspectionary : InspectionaryDictionary<bool, bool>
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x370AE8", Offset = "0x370AE8", VA = "0x370AE8")]
		public BooleanExampleInspectionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002B")]
	public class BoundsExampleInspectionary : InspectionaryDictionary<Bounds, Bounds>
	{
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x370B4C", Offset = "0x370B4C", VA = "0x370B4C")]
		public BoundsExampleInspectionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002C")]
	public class CharacterExampleInspectionary : InspectionaryDictionary<char, char>
	{
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x370BB0", Offset = "0x370BB0", VA = "0x370BB0")]
		public CharacterExampleInspectionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002D")]
	public class ColorExampleInspectionary : InspectionaryDictionary<Color, Color>
	{
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x370C14", Offset = "0x370C14", VA = "0x370C14")]
		public ColorExampleInspectionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002E")]
	public class EnumExampleInspectionary : InspectionaryDictionary<PropertyTypeExampleEnum, PropertyTypeExampleEnum>
	{
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x371AA4", Offset = "0x371AA4", VA = "0x371AA4")]
		public EnumExampleInspectionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002F")]
	public class FloatExampleInspectionary : InspectionaryDictionary<float, float>
	{
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x3727C8", Offset = "0x3727C8", VA = "0x3727C8")]
		public FloatExampleInspectionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	public class IntegerExampleInspectionary : InspectionaryDictionary<int, int>
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x37282C", Offset = "0x37282C", VA = "0x37282C")]
		public IntegerExampleInspectionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000031")]
	public class ObjectReferenceExampleInspectionary : InspectionaryDictionary<GameObject, GameObject>
	{
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x372890", Offset = "0x372890", VA = "0x372890")]
		public ObjectReferenceExampleInspectionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000032")]
	public class RectExampleInspectionary : InspectionaryDictionary<Rect, Rect>
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x372D8C", Offset = "0x372D8C", VA = "0x372D8C")]
		public RectExampleInspectionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000033")]
	public class StringExampleInspectionary : InspectionaryDictionary<string, string>
	{
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x3730D4", Offset = "0x3730D4", VA = "0x3730D4")]
		public StringExampleInspectionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000034")]
	public class Vector2ExampleInspectionary : InspectionaryDictionary<Vector2, Vector2>
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x373148", Offset = "0x373148", VA = "0x373148")]
		public Vector2ExampleInspectionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000035")]
	public class Vector3ExampleInspectionary : InspectionaryDictionary<Vector3, Vector3>
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x3731AC", Offset = "0x3731AC", VA = "0x3731AC")]
		public Vector3ExampleInspectionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000036")]
	public class QuaternionExampleInspectionary : InspectionaryDictionary<Quaternion, Quaternion>
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x372D28", Offset = "0x372D28", VA = "0x372D28")]
		public QuaternionExampleInspectionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000037")]
	public class Vector4ExampleInspectionary : InspectionaryDictionary<Vector4, Vector4>
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x373210", Offset = "0x373210", VA = "0x373210")]
		public Vector4ExampleInspectionary()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public abstract class SimpleExample : MonoBehaviour
	{
		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B3558", Offset = "0x2B3558")]
		public SimpleExampleInspectionary TheInspectionary;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x372DF0", Offset = "0x372DF0", VA = "0x372DF0")]
		protected SimpleExample()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x372DF8", Offset = "0x372DF8", VA = "0x372DF8")]
		private void OnEnable()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000039")]
	public class SimpleExampleInspectionary : InspectionaryDictionary<GameObject, Color>
	{
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x37300C", Offset = "0x37300C", VA = "0x37300C")]
		public SimpleExampleInspectionary()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class VariationExample : MonoBehaviour
	{
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B35A4", Offset = "0x2B35A4")]
		public int InvalidDictionaryExample;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B35F0", Offset = "0x2B35F0")]
		public SimpleInspectionary SimpleDictionary;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B363C", Offset = "0x2B363C")]
		public ComplexKeyInspectionary ComplexKeyDictionary;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B3688", Offset = "0x2B3688")]
		public ComplexValueInspectionary ComplexValueDictionary;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "InspectionaryAttribute", RVA = "0x2B36D4", Offset = "0x2B36D4")]
		public ComplexKeyValuePairInspectionary ComplexKeyValuePairDictionary;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x373140", Offset = "0x373140", VA = "0x373140")]
		public VariationExample()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003B")]
	public class SimpleInspectionary : InspectionaryDictionary<int, int>
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x373070", Offset = "0x373070", VA = "0x373070")]
		public SimpleInspectionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003C")]
	public class ComplexKeyInspectionary : InspectionaryDictionary<ComplexClass, int>
	{
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x37109C", Offset = "0x37109C", VA = "0x37109C")]
		public ComplexKeyInspectionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003D")]
	public class ComplexValueInspectionary : InspectionaryDictionary<int, ComplexClass>
	{
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x371164", Offset = "0x371164", VA = "0x371164")]
		public ComplexValueInspectionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003E")]
	public class ComplexKeyValuePairInspectionary : InspectionaryDictionary<ComplexClass, ComplexClass>
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x371100", Offset = "0x371100", VA = "0x371100")]
		public ComplexKeyValuePairInspectionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003F")]
	public class ComplexClass
	{
		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int IntegerValue;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 Vector3Value;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SubComplexClass SubClass;

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x370C78", Offset = "0x370C78", VA = "0x370C78")]
		public ComplexClass()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000040")]
	public class SubComplexClass
	{
		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int SubIntValue;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 SubVec3Value;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x373138", Offset = "0x373138", VA = "0x373138")]
		public SubComplexClass()
		{
		}
	}
}
namespace System.Collections.Generic
{
	[Token(Token = "0x2000041")]
	public class InspectionaryAttribute : PropertyAttribute
	{
		[Token(Token = "0x4000076")]
		protected const string DEFAULT_KEY_LABEL = "Key";

		[Token(Token = "0x4000077")]
		protected const string DEFAULT_VALUE_LABEL = "Value";

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly string KeyLabel;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public readonly string ValueLabel;

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x134E8E8", Offset = "0x134E8E8", VA = "0x134E8E8")]
		public InspectionaryAttribute(string keyLabel = "Key", string valueLabel = "Value")
		{
		}
	}
}
namespace SPStudios.SerializableDictionary
{
	[Serializable]
	[Token(Token = "0x2000042")]
	public class ComponentStringDictionary : InspectionaryDictionary<Component, string>
	{
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x373468", Offset = "0x373468", VA = "0x373468")]
		public ComponentStringDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public class ComponentIntDictionary : InspectionaryDictionary<Component, int>
	{
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x373404", Offset = "0x373404", VA = "0x373404")]
		public ComponentIntDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public class ComponentFloatDictionary : InspectionaryDictionary<Component, float>
	{
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x37333C", Offset = "0x37333C", VA = "0x37333C")]
		public ComponentFloatDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public class ComponentBoolDictionary : InspectionaryDictionary<Component, bool>
	{
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x373274", Offset = "0x373274", VA = "0x373274")]
		public ComponentBoolDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public class ComponentVector3Dictionary : InspectionaryDictionary<Component, Vector3>
	{
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x373530", Offset = "0x373530", VA = "0x373530")]
		public ComponentVector3Dictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public class ComponentGameObjectDictionary : InspectionaryDictionary<Component, GameObject>
	{
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x3733A0", Offset = "0x3733A0", VA = "0x3733A0")]
		public ComponentGameObjectDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000048")]
	public class ComponentComponentDictionary : InspectionaryDictionary<Component, Component>
	{
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x3732D8", Offset = "0x3732D8", VA = "0x3732D8")]
		public ComponentComponentDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000049")]
	public class ComponentTransformDictionary : InspectionaryDictionary<Component, Transform>
	{
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x3734CC", Offset = "0x3734CC", VA = "0x3734CC")]
		public ComponentTransformDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004A")]
	public class ComponentDictionary<T> : InspectionaryDictionary<Component, T>
	{
		[Token(Token = "0x60000B5")]
		public ComponentDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class FloatStringDictionary : InspectionaryDictionary<float, string>
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x373788", Offset = "0x373788", VA = "0x373788")]
		public FloatStringDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004C")]
	public class FloatIntDictionary : InspectionaryDictionary<float, int>
	{
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x373724", Offset = "0x373724", VA = "0x373724")]
		public FloatIntDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class FloatFloatDictionary : InspectionaryDictionary<float, float>
	{
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x37365C", Offset = "0x37365C", VA = "0x37365C")]
		public FloatFloatDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class FloatBoolDictionary : InspectionaryDictionary<float, bool>
	{
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x373594", Offset = "0x373594", VA = "0x373594")]
		public FloatBoolDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class FloatVector3Dictionary : InspectionaryDictionary<float, Vector3>
	{
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x373850", Offset = "0x373850", VA = "0x373850")]
		public FloatVector3Dictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class FloatGameObjectDictionary : InspectionaryDictionary<float, GameObject>
	{
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x3736C0", Offset = "0x3736C0", VA = "0x3736C0")]
		public FloatGameObjectDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000051")]
	public class FloatComponentDictionary : InspectionaryDictionary<float, Component>
	{
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x3735F8", Offset = "0x3735F8", VA = "0x3735F8")]
		public FloatComponentDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000052")]
	public class FloatTransformDictionary : InspectionaryDictionary<float, Transform>
	{
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x3737EC", Offset = "0x3737EC", VA = "0x3737EC")]
		public FloatTransformDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class FloatDictionary<T> : InspectionaryDictionary<float, T>
	{
		[Token(Token = "0x60000BE")]
		public FloatDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public class GameObjectStringDictionary : InspectionaryDictionary<GameObject, string>
	{
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x373A44", Offset = "0x373A44", VA = "0x373A44")]
		public GameObjectStringDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class GameObjectIntDictionary : InspectionaryDictionary<GameObject, int>
	{
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x3739E0", Offset = "0x3739E0", VA = "0x3739E0")]
		public GameObjectIntDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public class GameObjectFloatDictionary : InspectionaryDictionary<GameObject, float>
	{
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x373918", Offset = "0x373918", VA = "0x373918")]
		public GameObjectFloatDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class GameObjectBoolDictionary : InspectionaryDictionary<GameObject, bool>
	{
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x37298C", Offset = "0x37298C", VA = "0x37298C")]
		public GameObjectBoolDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class GameObjectVector3Dictionary : InspectionaryDictionary<GameObject, Vector3>
	{
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x3729F0", Offset = "0x3729F0", VA = "0x3729F0")]
		public GameObjectVector3Dictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public class GameObjectGameObjectDictionary : InspectionaryDictionary<GameObject, GameObject>
	{
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x37397C", Offset = "0x37397C", VA = "0x37397C")]
		public GameObjectGameObjectDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005A")]
	public class GameObjectComponentDictionary : InspectionaryDictionary<GameObject, Component>
	{
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x3738B4", Offset = "0x3738B4", VA = "0x3738B4")]
		public GameObjectComponentDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class GameObjectTransformDictionary : InspectionaryDictionary<GameObject, Transform>
	{
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x373AA8", Offset = "0x373AA8", VA = "0x373AA8")]
		public GameObjectTransformDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public class GameObjectDictionary<T> : InspectionaryDictionary<GameObject, T>
	{
		[Token(Token = "0x60000C7")]
		public GameObjectDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	public class IntStringDictionary : InspectionaryDictionary<int, string>
	{
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x373D00", Offset = "0x373D00", VA = "0x373D00")]
		public IntStringDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005E")]
	public class IntIntDictionary : InspectionaryDictionary<int, int>
	{
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x373C9C", Offset = "0x373C9C", VA = "0x373C9C")]
		public IntIntDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005F")]
	public class IntFloatDictionary : InspectionaryDictionary<int, float>
	{
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x373BD4", Offset = "0x373BD4", VA = "0x373BD4")]
		public IntFloatDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class IntBoolDictionary : InspectionaryDictionary<int, bool>
	{
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x373B0C", Offset = "0x373B0C", VA = "0x373B0C")]
		public IntBoolDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000061")]
	public class IntVector3Dictionary : InspectionaryDictionary<int, Vector3>
	{
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x373DC8", Offset = "0x373DC8", VA = "0x373DC8")]
		public IntVector3Dictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000062")]
	public class IntGameObjectDictionary : InspectionaryDictionary<int, GameObject>
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x373C38", Offset = "0x373C38", VA = "0x373C38")]
		public IntGameObjectDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public class IntComponentDictionary : InspectionaryDictionary<int, Component>
	{
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x373B70", Offset = "0x373B70", VA = "0x373B70")]
		public IntComponentDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	public class IntTransformDictionary : InspectionaryDictionary<int, Transform>
	{
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x373D64", Offset = "0x373D64", VA = "0x373D64")]
		public IntTransformDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class IntDictionary<T> : InspectionaryDictionary<int, T>
	{
		[Token(Token = "0x60000D0")]
		public IntDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public class StringStringDictionary : InspectionaryDictionary<string, string>
	{
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x374020", Offset = "0x374020", VA = "0x374020")]
		public StringStringDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000067")]
	public class StringIntDictionary : InspectionaryDictionary<string, int>
	{
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x373FBC", Offset = "0x373FBC", VA = "0x373FBC")]
		public StringIntDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000068")]
	public class StringFloatDictionary : InspectionaryDictionary<string, float>
	{
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x373EF4", Offset = "0x373EF4", VA = "0x373EF4")]
		public StringFloatDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public class StringBoolDictionary : InspectionaryDictionary<string, bool>
	{
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x373E2C", Offset = "0x373E2C", VA = "0x373E2C")]
		public StringBoolDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public class StringVector3Dictionary : InspectionaryDictionary<string, Vector3>
	{
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x3740E8", Offset = "0x3740E8", VA = "0x3740E8")]
		public StringVector3Dictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	public class StringGameObjectDictionary : InspectionaryDictionary<string, GameObject>
	{
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x373F58", Offset = "0x373F58", VA = "0x373F58")]
		public StringGameObjectDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public class StringComponentDictionary : InspectionaryDictionary<string, Component>
	{
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x373E90", Offset = "0x373E90", VA = "0x373E90")]
		public StringComponentDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006D")]
	public class StringTransformDictionary : InspectionaryDictionary<string, Transform>
	{
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x374084", Offset = "0x374084", VA = "0x374084")]
		public StringTransformDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class StringDictionary<T> : InspectionaryDictionary<string, T>
	{
		[Token(Token = "0x60000D9")]
		public StringDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006F")]
	public class TransformStringDictionary : InspectionaryDictionary<Transform, string>
	{
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x374340", Offset = "0x374340", VA = "0x374340")]
		public TransformStringDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000070")]
	public class TransformIntDictionary : InspectionaryDictionary<Transform, int>
	{
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x3742DC", Offset = "0x3742DC", VA = "0x3742DC")]
		public TransformIntDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000071")]
	public class TransformFloatDictionary : InspectionaryDictionary<Transform, float>
	{
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x374214", Offset = "0x374214", VA = "0x374214")]
		public TransformFloatDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000072")]
	public class TransformBoolDictionary : InspectionaryDictionary<Transform, bool>
	{
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x37414C", Offset = "0x37414C", VA = "0x37414C")]
		public TransformBoolDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000073")]
	public class TransformVector3Dictionary : InspectionaryDictionary<Transform, Vector3>
	{
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x374408", Offset = "0x374408", VA = "0x374408")]
		public TransformVector3Dictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000074")]
	public class TransformGameObjectDictionary : InspectionaryDictionary<Transform, GameObject>
	{
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x374278", Offset = "0x374278", VA = "0x374278")]
		public TransformGameObjectDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000075")]
	public class TransformComponentDictionary : InspectionaryDictionary<Transform, Component>
	{
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x3741B0", Offset = "0x3741B0", VA = "0x3741B0")]
		public TransformComponentDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000076")]
	public class TransformTransformDictionary : InspectionaryDictionary<Transform, Transform>
	{
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x3743A4", Offset = "0x3743A4", VA = "0x3743A4")]
		public TransformTransformDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000077")]
	public class TransformDictionary<T> : InspectionaryDictionary<Transform, T>
	{
		[Token(Token = "0x60000E2")]
		public TransformDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000078")]
	public class Vector3StringDictionary : InspectionaryDictionary<Vector3, string>
	{
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x374660", Offset = "0x374660", VA = "0x374660")]
		public Vector3StringDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000079")]
	public class Vector3IntDictionary : InspectionaryDictionary<Vector3, int>
	{
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x3745FC", Offset = "0x3745FC", VA = "0x3745FC")]
		public Vector3IntDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007A")]
	public class Vector3FloatDictionary : InspectionaryDictionary<Vector3, float>
	{
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x374534", Offset = "0x374534", VA = "0x374534")]
		public Vector3FloatDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public class Vector3BoolDictionary : InspectionaryDictionary<Vector3, bool>
	{
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x37446C", Offset = "0x37446C", VA = "0x37446C")]
		public Vector3BoolDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007C")]
	public class Vector3Vector3Dictionary : InspectionaryDictionary<Vector3, Vector3>
	{
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x374728", Offset = "0x374728", VA = "0x374728")]
		public Vector3Vector3Dictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007D")]
	public class Vector3GameObjectDictionary : InspectionaryDictionary<Vector3, GameObject>
	{
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x374598", Offset = "0x374598", VA = "0x374598")]
		public Vector3GameObjectDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007E")]
	public class Vector3ComponentDictionary : InspectionaryDictionary<Vector3, Component>
	{
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x3744D0", Offset = "0x3744D0", VA = "0x3744D0")]
		public Vector3ComponentDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007F")]
	public class Vector3TransformDictionary : InspectionaryDictionary<Vector3, Transform>
	{
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x3746C4", Offset = "0x3746C4", VA = "0x3746C4")]
		public Vector3TransformDictionary()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public class Vector3Dictionary<T> : InspectionaryDictionary<Vector3, T>
	{
		[Token(Token = "0x60000EB")]
		public Vector3Dictionary()
		{
		}
	}
}
namespace System.Collections.Generic
{
	[Serializable]
	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x2B3720", Offset = "0x2B3720")]
	public class InspectionaryDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IEnumerable, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>
	{
		[Token(Token = "0x400007A")]
		private const string ERROR_INVALID_ARRAY_SIZES = "Cannot have a different number of values and keys.";

		[Token(Token = "0x400007B")]
		private const string ERROR_NON_UNIQUE_KEY_LIST = "Cannot have duplicate keys";

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Dictionary<TKey, TValue> _cachedDict;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected List<TKey> KeysList;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected List<TValue> ValuesList;

		[NonSerialized]
		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool _isValidated;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool InspectorWasUpdated;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool UpdateInspectorValues;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<string> CustomLabels;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool EditingLabel;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int LabelNum;

		[Token(Token = "0x17000018")]
		private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys
		{
			[Token(Token = "0x60000FF")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values
		{
			[Token(Token = "0x6000100")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public IEqualityComparer<TKey> Comparer
		{
			[Token(Token = "0x60000F2")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public int Count
		{
			[Token(Token = "0x60000F3")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001C")]
		public Dictionary<TKey, TValue>.KeyCollection Keys
		{
			[Token(Token = "0x60000F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public Dictionary<TKey, TValue>.ValueCollection Values
		{
			[Token(Token = "0x60000F5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public TValue Item
		{
			[Token(Token = "0x60000F6")]
			get
			{
				return (TValue)null;
			}
			[Token(Token = "0x60000F7")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000101")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000EC")]
		public InspectionaryDictionary()
		{
		}

		[Token(Token = "0x60000ED")]
		protected virtual void BeforeDictionaryOperation()
		{
		}

		[Token(Token = "0x60000EE")]
		protected virtual void AfterDictionaryOperation()
		{
		}

		[Token(Token = "0x60000EF")]
		private bool AreKeysUnique()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F0")]
		public static implicit operator Dictionary<TKey, TValue>(InspectionaryDictionary<TKey, TValue> serialized)
		{
			return null;
		}

		[Token(Token = "0x60000F1")]
		public static explicit operator InspectionaryDictionary<TKey, TValue>(Dictionary<TKey, TValue> regDict)
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		public void Add(TKey key, TValue value)
		{
		}

		[Token(Token = "0x60000F9")]
		public void Clear()
		{
		}

		[Token(Token = "0x60000FA")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FB")]
		public bool ContainsValue(TValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FC")]
		public Dictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			return default(Dictionary<TKey, TValue>.Enumerator);
		}

		[Token(Token = "0x60000FD")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FE")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000102")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000103")]
		private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000104")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item)
		{
		}

		[Token(Token = "0x6000105")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000106")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000107")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}
	}
}
namespace Steamworks
{
	[Token(Token = "0x2000082")]
	public static class SteamAppList
	{
		[Token(Token = "0x6000108")]
		[Address(RVA = "0xE3AFD0", Offset = "0xE3AFD0", VA = "0xE3AFD0")]
		public static uint GetNumInstalledApps()
		{
			return default(uint);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xE3B004", Offset = "0xE3B004", VA = "0xE3B004")]
		public static uint GetInstalledApps(AppId_t[] pvecAppID, uint unMaxAppIDs)
		{
			return default(uint);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xE3B054", Offset = "0xE3B054", VA = "0xE3B054")]
		public static int GetAppName(AppId_t nAppID, out string pchName, int cchNameMax)
		{
			return default(int);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xE3B188", Offset = "0xE3B188", VA = "0xE3B188")]
		public static int GetAppInstallDir(AppId_t nAppID, out string pchDirectory, int cchNameMax)
		{
			return default(int);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xE3B2BC", Offset = "0xE3B2BC", VA = "0xE3B2BC")]
		public static int GetAppBuildId(AppId_t nAppID)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000083")]
	public static class SteamApps
	{
		[Token(Token = "0x600010D")]
		[Address(RVA = "0xE3B2F8", Offset = "0xE3B2F8", VA = "0xE3B2F8")]
		public static bool BIsSubscribed()
		{
			return default(bool);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xE3B32C", Offset = "0xE3B32C", VA = "0xE3B32C")]
		public static bool BIsLowViolence()
		{
			return default(bool);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xE3B360", Offset = "0xE3B360", VA = "0xE3B360")]
		public static bool BIsCybercafe()
		{
			return default(bool);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xE3B394", Offset = "0xE3B394", VA = "0xE3B394")]
		public static bool BIsVACBanned()
		{
			return default(bool);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xE3B3C8", Offset = "0xE3B3C8", VA = "0xE3B3C8")]
		public static string GetCurrentGameLanguage()
		{
			return null;
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xE3B40C", Offset = "0xE3B40C", VA = "0xE3B40C")]
		public static string GetAvailableGameLanguages()
		{
			return null;
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xE3B450", Offset = "0xE3B450", VA = "0xE3B450")]
		public static bool BIsSubscribedApp(AppId_t appID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xE3B48C", Offset = "0xE3B48C", VA = "0xE3B48C")]
		public static bool BIsDlcInstalled(AppId_t appID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xE3B4C8", Offset = "0xE3B4C8", VA = "0xE3B4C8")]
		public static uint GetEarliestPurchaseUnixTime(AppId_t nAppID)
		{
			return default(uint);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xE3B504", Offset = "0xE3B504", VA = "0xE3B504")]
		public static bool BIsSubscribedFromFreeWeekend()
		{
			return default(bool);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xE3B538", Offset = "0xE3B538", VA = "0xE3B538")]
		public static int GetDLCCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xE3B56C", Offset = "0xE3B56C", VA = "0xE3B56C")]
		public static bool BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, out string pchName, int cchNameBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xE3B6AC", Offset = "0xE3B6AC", VA = "0xE3B6AC")]
		public static void InstallDLC(AppId_t nAppID)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xE3B6E8", Offset = "0xE3B6E8", VA = "0xE3B6E8")]
		public static void UninstallDLC(AppId_t nAppID)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xE3B724", Offset = "0xE3B724", VA = "0xE3B724")]
		public static void RequestAppProofOfPurchaseKey(AppId_t nAppID)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xE3B760", Offset = "0xE3B760", VA = "0xE3B760")]
		public static bool GetCurrentBetaName(out string pchName, int cchNameBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xE3B890", Offset = "0xE3B890", VA = "0xE3B890")]
		public static bool MarkContentCorrupt(bool bMissingFilesOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xE3B8CC", Offset = "0xE3B8CC", VA = "0xE3B8CC")]
		public static uint GetInstalledDepots(AppId_t appID, DepotId_t[] pvecDepots, uint cMaxDepots)
		{
			return default(uint);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xE3B920", Offset = "0xE3B920", VA = "0xE3B920")]
		public static uint GetAppInstallDir(AppId_t appID, out string pchFolder, uint cchFolderBufferSize)
		{
			return default(uint);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xE3BA54", Offset = "0xE3BA54", VA = "0xE3BA54")]
		public static bool BIsAppInstalled(AppId_t appID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xE3BA90", Offset = "0xE3BA90", VA = "0xE3BA90")]
		public static CSteamID GetAppOwner()
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xE3BB5C", Offset = "0xE3BB5C", VA = "0xE3BB5C")]
		public static string GetLaunchQueryParam(string pchKey)
		{
			return null;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xE3BCD0", Offset = "0xE3BCD0", VA = "0xE3BCD0")]
		public static bool GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			return default(bool);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xE3BD24", Offset = "0xE3BD24", VA = "0xE3BD24")]
		public static int GetAppBuildId()
		{
			return default(int);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xE3BD58", Offset = "0xE3BD58", VA = "0xE3BD58")]
		public static void RequestAllProofOfPurchaseKeys()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xE3BD8C", Offset = "0xE3BD8C", VA = "0xE3BD8C")]
		public static SteamAPICall_t GetFileDetails(string pszFileName)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x2000084")]
	public static class SteamClient
	{
		[Token(Token = "0x6000127")]
		[Address(RVA = "0xE3BF3C", Offset = "0xE3BF3C", VA = "0xE3BF3C")]
		public static HSteamPipe CreateSteamPipe()
		{
			return default(HSteamPipe);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xE3BF80", Offset = "0xE3BF80", VA = "0xE3BF80")]
		public static bool BReleaseSteamPipe(HSteamPipe hSteamPipe)
		{
			return default(bool);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xE3BFBC", Offset = "0xE3BFBC", VA = "0xE3BFBC")]
		public static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe)
		{
			return default(HSteamUser);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xE3C008", Offset = "0xE3C008", VA = "0xE3C008")]
		public static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType)
		{
			return default(HSteamUser);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xE3C068", Offset = "0xE3C068", VA = "0xE3C068")]
		public static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xE3C0B8", Offset = "0xE3C0B8", VA = "0xE3C0B8")]
		public static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xE3C228", Offset = "0xE3C228", VA = "0xE3C228")]
		public static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xE3C398", Offset = "0xE3C398", VA = "0xE3C398")]
		public static void SetLocalIPBinding(uint unIP, ushort usPort)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xE3C3E8", Offset = "0xE3C3E8", VA = "0xE3C3E8")]
		public static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xE3C558", Offset = "0xE3C558", VA = "0xE3C558")]
		public static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xE3C6C4", Offset = "0xE3C6C4", VA = "0xE3C6C4")]
		public static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xE3C834", Offset = "0xE3C834", VA = "0xE3C834")]
		public static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xE3C9A4", Offset = "0xE3C9A4", VA = "0xE3C9A4")]
		public static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xE3CB14", Offset = "0xE3CB14", VA = "0xE3CB14")]
		public static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xE3CC84", Offset = "0xE3CC84", VA = "0xE3CC84")]
		public static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xE3CDF4", Offset = "0xE3CDF4", VA = "0xE3CDF4")]
		public static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xE3CF64", Offset = "0xE3CF64", VA = "0xE3CF64")]
		public static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xE3D0D4", Offset = "0xE3D0D4", VA = "0xE3D0D4")]
		public static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xE3D244", Offset = "0xE3D244", VA = "0xE3D244")]
		public static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xE3D3B4", Offset = "0xE3D3B4", VA = "0xE3D3B4")]
		public static uint GetIPCCallCount()
		{
			return default(uint);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xE3D3E8", Offset = "0xE3D3E8", VA = "0xE3D3E8")]
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xE3D424", Offset = "0xE3D424", VA = "0xE3D424")]
		public static bool BShutdownIfAllPipesClosed()
		{
			return default(bool);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xE3D458", Offset = "0xE3D458", VA = "0xE3D458")]
		public static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xE3D5C8", Offset = "0xE3D5C8", VA = "0xE3D5C8")]
		public static IntPtr GetISteamUnifiedMessages(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xE3D738", Offset = "0xE3D738", VA = "0xE3D738")]
		public static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xE3D8A8", Offset = "0xE3D8A8", VA = "0xE3D8A8")]
		public static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xE3DA18", Offset = "0xE3DA18", VA = "0xE3DA18")]
		public static IntPtr GetISteamAppList(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xE3DB88", Offset = "0xE3DB88", VA = "0xE3DB88")]
		public static IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xE3DCF8", Offset = "0xE3DCF8", VA = "0xE3DCF8")]
		public static IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xE3DE68", Offset = "0xE3DE68", VA = "0xE3DE68")]
		public static IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xE3DFD8", Offset = "0xE3DFD8", VA = "0xE3DFD8")]
		public static IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xE3E148", Offset = "0xE3E148", VA = "0xE3E148")]
		public static IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xE3E2B8", Offset = "0xE3E2B8", VA = "0xE3E2B8")]
		public static IntPtr GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x2000085")]
	public static class SteamController
	{
		[Token(Token = "0x6000148")]
		[Address(RVA = "0xE3E428", Offset = "0xE3E428", VA = "0xE3E428")]
		public static bool Init()
		{
			return default(bool);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xE3E45C", Offset = "0xE3E45C", VA = "0xE3E45C")]
		public static bool Shutdown()
		{
			return default(bool);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xE3E490", Offset = "0xE3E490", VA = "0xE3E490")]
		public static void RunFrame()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xE3E4C4", Offset = "0xE3E4C4", VA = "0xE3E4C4")]
		public static int GetConnectedControllers(ControllerHandle_t[] handlesOut)
		{
			return default(int);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xE3E5A8", Offset = "0xE3E5A8", VA = "0xE3E5A8")]
		public static bool ShowBindingPanel(ControllerHandle_t controllerHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xE3E5F8", Offset = "0xE3E5F8", VA = "0xE3E5F8")]
		public static ControllerActionSetHandle_t GetActionSetHandle(string pszActionSetName)
		{
			return default(ControllerActionSetHandle_t);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xE3E794", Offset = "0xE3E794", VA = "0xE3E794")]
		public static void ActivateActionSet(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xE3E7EC", Offset = "0xE3E7EC", VA = "0xE3E7EC")]
		public static ControllerActionSetHandle_t GetCurrentActionSet(ControllerHandle_t controllerHandle)
		{
			return default(ControllerActionSetHandle_t);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xE3E858", Offset = "0xE3E858", VA = "0xE3E858")]
		public static ControllerDigitalActionHandle_t GetDigitalActionHandle(string pszActionName)
		{
			return default(ControllerDigitalActionHandle_t);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xE3E9F4", Offset = "0xE3E9F4", VA = "0xE3E9F4")]
		public static ControllerDigitalActionData_t GetDigitalActionData(ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle)
		{
			return default(ControllerDigitalActionData_t);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xE3EA4C", Offset = "0xE3EA4C", VA = "0xE3EA4C")]
		public static int GetDigitalActionOrigins(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerDigitalActionHandle_t digitalActionHandle, EControllerActionOrigin[] originsOut)
		{
			return default(int);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xE3EAB8", Offset = "0xE3EAB8", VA = "0xE3EAB8")]
		public static ControllerAnalogActionHandle_t GetAnalogActionHandle(string pszActionName)
		{
			return default(ControllerAnalogActionHandle_t);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xE3EC54", Offset = "0xE3EC54", VA = "0xE3EC54")]
		public static ControllerAnalogActionData_t GetAnalogActionData(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle)
		{
			return default(ControllerAnalogActionData_t);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xE3ECB8", Offset = "0xE3ECB8", VA = "0xE3ECB8")]
		public static int GetAnalogActionOrigins(ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerAnalogActionHandle_t analogActionHandle, EControllerActionOrigin[] originsOut)
		{
			return default(int);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xE3ED24", Offset = "0xE3ED24", VA = "0xE3ED24")]
		public static void StopAnalogActionMomentum(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t eAction)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xE3ED7C", Offset = "0xE3ED7C", VA = "0xE3ED7C")]
		public static void TriggerHapticPulse(ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xE3EDD4", Offset = "0xE3EDD4", VA = "0xE3EDD4")]
		public static void TriggerRepeatedHapticPulse(ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xE3EE40", Offset = "0xE3EE40", VA = "0xE3EE40")]
		public static void TriggerVibration(ControllerHandle_t controllerHandle, ushort usLeftSpeed, ushort usRightSpeed)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xE3EE98", Offset = "0xE3EE98", VA = "0xE3EE98")]
		public static void SetLEDColor(ControllerHandle_t controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xE3EEF8", Offset = "0xE3EEF8", VA = "0xE3EEF8")]
		public static int GetGamepadIndexForController(ControllerHandle_t ulControllerHandle)
		{
			return default(int);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xE3EF48", Offset = "0xE3EF48", VA = "0xE3EF48")]
		public static ControllerHandle_t GetControllerForGamepadIndex(int nIndex)
		{
			return default(ControllerHandle_t);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xE3EFAC", Offset = "0xE3EFAC", VA = "0xE3EFAC")]
		public static ControllerMotionData_t GetMotionData(ControllerHandle_t controllerHandle)
		{
			return default(ControllerMotionData_t);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xE3F000", Offset = "0xE3F000", VA = "0xE3F000")]
		public static bool ShowDigitalActionOrigins(ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle, float flScale, float flXPosition, float flYPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xE3F078", Offset = "0xE3F078", VA = "0xE3F078")]
		public static bool ShowAnalogActionOrigins(ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle, float flScale, float flXPosition, float flYPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xE3F0F0", Offset = "0xE3F0F0", VA = "0xE3F0F0")]
		public static string GetStringForActionOrigin(EControllerActionOrigin eOrigin)
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xE3F13C", Offset = "0xE3F13C", VA = "0xE3F13C")]
		public static string GetGlyphForActionOrigin(EControllerActionOrigin eOrigin)
		{
			return null;
		}
	}
	[Token(Token = "0x2000086")]
	public static class SteamFriends
	{
		[Token(Token = "0x6000162")]
		[Address(RVA = "0xE3F44C", Offset = "0xE3F44C", VA = "0xE3F44C")]
		public static string GetPersonaName()
		{
			return null;
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xE3F490", Offset = "0xE3F490", VA = "0xE3F490")]
		public static SteamAPICall_t SetPersonaName(string pchPersonaName)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xE3F640", Offset = "0xE3F640", VA = "0xE3F640")]
		public static EPersonaState GetPersonaState()
		{
			return default(EPersonaState);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xE3F674", Offset = "0xE3F674", VA = "0xE3F674")]
		public static int GetFriendCount(EFriendFlags iFriendFlags)
		{
			return default(int);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xE3F6B0", Offset = "0xE3F6B0", VA = "0xE3F6B0")]
		public static CSteamID GetFriendByIndex(int iFriend, EFriendFlags iFriendFlags)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xE3F78C", Offset = "0xE3F78C", VA = "0xE3F78C")]
		public static EFriendRelationship GetFriendRelationship(CSteamID steamIDFriend)
		{
			return default(EFriendRelationship);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xE3F7DC", Offset = "0xE3F7DC", VA = "0xE3F7DC")]
		public static EPersonaState GetFriendPersonaState(CSteamID steamIDFriend)
		{
			return default(EPersonaState);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xE3F82C", Offset = "0xE3F82C", VA = "0xE3F82C")]
		public static string GetFriendPersonaName(CSteamID steamIDFriend)
		{
			return null;
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xE3F88C", Offset = "0xE3F88C", VA = "0xE3F88C")]
		public static bool GetFriendGamePlayed(CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xE3F8E0", Offset = "0xE3F8E0", VA = "0xE3F8E0")]
		public static string GetFriendPersonaNameHistory(CSteamID steamIDFriend, int iPersonaName)
		{
			return null;
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xE3F944", Offset = "0xE3F944", VA = "0xE3F944")]
		public static int GetFriendSteamLevel(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xE3F994", Offset = "0xE3F994", VA = "0xE3F994")]
		public static string GetPlayerNickname(CSteamID steamIDPlayer)
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xE3F9F4", Offset = "0xE3F9F4", VA = "0xE3F9F4")]
		public static int GetFriendsGroupCount()
		{
			return default(int);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xE3FA28", Offset = "0xE3FA28", VA = "0xE3FA28")]
		public static FriendsGroupID_t GetFriendsGroupIDByIndex(int iFG)
		{
			return default(FriendsGroupID_t);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xE3FAE0", Offset = "0xE3FAE0", VA = "0xE3FAE0")]
		public static string GetFriendsGroupName(FriendsGroupID_t friendsGroupID)
		{
			return null;
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xE3FB2C", Offset = "0xE3FB2C", VA = "0xE3FB2C")]
		public static int GetFriendsGroupMembersCount(FriendsGroupID_t friendsGroupID)
		{
			return default(int);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xE3FB68", Offset = "0xE3FB68", VA = "0xE3FB68")]
		public static void GetFriendsGroupMembersList(FriendsGroupID_t friendsGroupID, CSteamID[] pOutSteamIDMembers, int nMembersCount)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xE3FBBC", Offset = "0xE3FBBC", VA = "0xE3FBBC")]
		public static bool HasFriend(CSteamID steamIDFriend, EFriendFlags iFriendFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xE3FC10", Offset = "0xE3FC10", VA = "0xE3FC10")]
		public static int GetClanCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xE3FC44", Offset = "0xE3FC44", VA = "0xE3FC44")]
		public static CSteamID GetClanByIndex(int iClan)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xE3FD18", Offset = "0xE3FD18", VA = "0xE3FD18")]
		public static string GetClanName(CSteamID steamIDClan)
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xE3FD78", Offset = "0xE3FD78", VA = "0xE3FD78")]
		public static string GetClanTag(CSteamID steamIDClan)
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xE3FDD8", Offset = "0xE3FDD8", VA = "0xE3FDD8")]
		public static bool GetClanActivityCounts(CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting)
		{
			return default(bool);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xE3FE38", Offset = "0xE3FE38", VA = "0xE3FE38")]
		public static SteamAPICall_t DownloadClanActivityCounts(CSteamID[] psteamIDClans, int cClansToRequest)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xE3FF00", Offset = "0xE3FF00", VA = "0xE3FF00")]
		public static int GetFriendCountFromSource(CSteamID steamIDSource)
		{
			return default(int);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xE3FF50", Offset = "0xE3FF50", VA = "0xE3FF50")]
		public static CSteamID GetFriendFromSourceByIndex(CSteamID steamIDSource, int iFriend)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xE40034", Offset = "0xE40034", VA = "0xE40034")]
		public static bool IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource)
		{
			return default(bool);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xE40090", Offset = "0xE40090", VA = "0xE40090")]
		public static void SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xE400E4", Offset = "0xE400E4", VA = "0xE400E4")]
		public static void ActivateGameOverlay(string pchDialog)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xE40238", Offset = "0xE40238", VA = "0xE40238")]
		public static void ActivateGameOverlayToUser(string pchDialog, CSteamID steamID)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xE403A4", Offset = "0xE403A4", VA = "0xE403A4")]
		public static void ActivateGameOverlayToWebPage(string pchURL)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xE404F8", Offset = "0xE404F8", VA = "0xE404F8")]
		public static void ActivateGameOverlayToStore(AppId_t nAppID, EOverlayToStoreFlag eFlag)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xE40548", Offset = "0xE40548", VA = "0xE40548")]
		public static void SetPlayedWith(CSteamID steamIDUserPlayedWith)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xE40598", Offset = "0xE40598", VA = "0xE40598")]
		public static void ActivateGameOverlayInviteDialog(CSteamID steamIDLobby)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xE405E8", Offset = "0xE405E8", VA = "0xE405E8")]
		public static int GetSmallFriendAvatar(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xE40638", Offset = "0xE40638", VA = "0xE40638")]
		public static int GetMediumFriendAvatar(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xE40688", Offset = "0xE40688", VA = "0xE40688")]
		public static int GetLargeFriendAvatar(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xE406D8", Offset = "0xE406D8", VA = "0xE406D8")]
		public static bool RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xE4072C", Offset = "0xE4072C", VA = "0xE4072C")]
		public static SteamAPICall_t RequestClanOfficerList(CSteamID steamIDClan)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xE407F4", Offset = "0xE407F4", VA = "0xE407F4")]
		public static CSteamID GetClanOwner(CSteamID steamIDClan)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xE408D0", Offset = "0xE408D0", VA = "0xE408D0")]
		public static int GetClanOfficerCount(CSteamID steamIDClan)
		{
			return default(int);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xE40920", Offset = "0xE40920", VA = "0xE40920")]
		public static CSteamID GetClanOfficerByIndex(CSteamID steamIDClan, int iOfficer)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xE40A04", Offset = "0xE40A04", VA = "0xE40A04")]
		public static uint GetUserRestrictions()
		{
			return default(uint);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xE40A38", Offset = "0xE40A38", VA = "0xE40A38")]
		public static bool SetRichPresence(string pchKey, string pchValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xE40CDC", Offset = "0xE40CDC", VA = "0xE40CDC")]
		public static void ClearRichPresence()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xE40D10", Offset = "0xE40D10", VA = "0xE40D10")]
		public static string GetFriendRichPresence(CSteamID steamIDFriend, string pchKey)
		{
			return null;
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xE40E94", Offset = "0xE40E94", VA = "0xE40E94")]
		public static int GetFriendRichPresenceKeyCount(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xE40EE4", Offset = "0xE40EE4", VA = "0xE40EE4")]
		public static string GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, int iKey)
		{
			return null;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xE40F48", Offset = "0xE40F48", VA = "0xE40F48")]
		public static void RequestFriendRichPresence(CSteamID steamIDFriend)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xE40F98", Offset = "0xE40F98", VA = "0xE40F98")]
		public static bool InviteUserToGame(CSteamID steamIDFriend, string pchConnectString)
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xE41108", Offset = "0xE41108", VA = "0xE41108")]
		public static int GetCoplayFriendCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xE4113C", Offset = "0xE4113C", VA = "0xE4113C")]
		public static CSteamID GetCoplayFriend(int iCoplayFriend)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xE41210", Offset = "0xE41210", VA = "0xE41210")]
		public static int GetFriendCoplayTime(CSteamID steamIDFriend)
		{
			return default(int);
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xE41260", Offset = "0xE41260", VA = "0xE41260")]
		public static AppId_t GetFriendCoplayGame(CSteamID steamIDFriend)
		{
			return default(AppId_t);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xE4132C", Offset = "0xE4132C", VA = "0xE4132C")]
		public static SteamAPICall_t JoinClanChatRoom(CSteamID steamIDClan)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xE413F4", Offset = "0xE413F4", VA = "0xE413F4")]
		public static bool LeaveClanChatRoom(CSteamID steamIDClan)
		{
			return default(bool);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xE41444", Offset = "0xE41444", VA = "0xE41444")]
		public static int GetClanChatMemberCount(CSteamID steamIDClan)
		{
			return default(int);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xE41494", Offset = "0xE41494", VA = "0xE41494")]
		public static CSteamID GetChatMemberByIndex(CSteamID steamIDClan, int iUser)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xE41578", Offset = "0xE41578", VA = "0xE41578")]
		public static bool SendClanChatMessage(CSteamID steamIDClanChat, string pchText)
		{
			return default(bool);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xE416E8", Offset = "0xE416E8", VA = "0xE416E8")]
		public static int GetClanChatMessage(CSteamID steamIDClanChat, int iMessage, out string prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter)
		{
			return default(int);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xE41838", Offset = "0xE41838", VA = "0xE41838")]
		public static bool IsClanChatAdmin(CSteamID steamIDClanChat, CSteamID steamIDUser)
		{
			return default(bool);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xE41894", Offset = "0xE41894", VA = "0xE41894")]
		public static bool IsClanChatWindowOpenInSteam(CSteamID steamIDClanChat)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xE418E4", Offset = "0xE418E4", VA = "0xE418E4")]
		public static bool OpenClanChatWindowInSteam(CSteamID steamIDClanChat)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xE41934", Offset = "0xE41934", VA = "0xE41934")]
		public static bool CloseClanChatWindowInSteam(CSteamID steamIDClanChat)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xE41984", Offset = "0xE41984", VA = "0xE41984")]
		public static bool SetListenForFriendsMessages(bool bInterceptEnabled)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xE419C0", Offset = "0xE419C0", VA = "0xE419C0")]
		public static bool ReplyToFriendMessage(CSteamID steamIDFriend, string pchMsgToSend)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xE41B30", Offset = "0xE41B30", VA = "0xE41B30")]
		public static int GetFriendMessage(CSteamID steamIDFriend, int iMessageID, out string pvData, int cubData, out EChatEntryType peChatEntryType)
		{
			return default(int);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xE41C78", Offset = "0xE41C78", VA = "0xE41C78")]
		public static SteamAPICall_t GetFollowerCount(CSteamID steamID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xE41D40", Offset = "0xE41D40", VA = "0xE41D40")]
		public static SteamAPICall_t IsFollowing(CSteamID steamID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xE41E08", Offset = "0xE41E08", VA = "0xE41E08")]
		public static SteamAPICall_t EnumerateFollowingList(uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x2000087")]
	public static class SteamGameServer
	{
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xE41EBC", Offset = "0xE41EBC", VA = "0xE41EBC")]
		public static bool InitGameServer(uint unIP, ushort usGamePort, ushort usQueryPort, uint unFlags, AppId_t nGameAppId, string pchVersionString)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xE42044", Offset = "0xE42044", VA = "0xE42044")]
		public static void SetProduct(string pszProduct)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xE42198", Offset = "0xE42198", VA = "0xE42198")]
		public static void SetGameDescription(string pszGameDescription)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xE422EC", Offset = "0xE422EC", VA = "0xE422EC")]
		public static void SetModDir(string pszModDir)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xE42440", Offset = "0xE42440", VA = "0xE42440")]
		public static void SetDedicatedServer(bool bDedicated)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xE4247C", Offset = "0xE4247C", VA = "0xE4247C")]
		public static void LogOn(string pszToken)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xE425D0", Offset = "0xE425D0", VA = "0xE425D0")]
		public static void LogOnAnonymous()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xE42604", Offset = "0xE42604", VA = "0xE42604")]
		public static void LogOff()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xE42638", Offset = "0xE42638", VA = "0xE42638")]
		public static bool BLoggedOn()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xE4266C", Offset = "0xE4266C", VA = "0xE4266C")]
		public static bool BSecure()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xE426A0", Offset = "0xE426A0", VA = "0xE426A0")]
		public static CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xE4276C", Offset = "0xE4276C", VA = "0xE4276C")]
		public static bool WasRestartRequested()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xE427A0", Offset = "0xE427A0", VA = "0xE427A0")]
		public static void SetMaxPlayerCount(int cPlayersMax)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xE427DC", Offset = "0xE427DC", VA = "0xE427DC")]
		public static void SetBotPlayerCount(int cBotplayers)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xE42818", Offset = "0xE42818", VA = "0xE42818")]
		public static void SetServerName(string pszServerName)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xE4296C", Offset = "0xE4296C", VA = "0xE4296C")]
		public static void SetMapName(string pszMapName)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xE42AC0", Offset = "0xE42AC0", VA = "0xE42AC0")]
		public static void SetPasswordProtected(bool bPasswordProtected)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xE42AFC", Offset = "0xE42AFC", VA = "0xE42AFC")]
		public static void SetSpectatorPort(ushort unSpectatorPort)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xE42B38", Offset = "0xE42B38", VA = "0xE42B38")]
		public static void SetSpectatorServerName(string pszSpectatorServerName)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xE42C8C", Offset = "0xE42C8C", VA = "0xE42C8C")]
		public static void ClearAllKeyValues()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xE42CC0", Offset = "0xE42CC0", VA = "0xE42CC0")]
		public static void SetKeyValue(string pKey, string pValue)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xE42F20", Offset = "0xE42F20", VA = "0xE42F20")]
		public static void SetGameTags(string pchGameTags)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xE43074", Offset = "0xE43074", VA = "0xE43074")]
		public static void SetGameData(string pchGameData)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xE431C8", Offset = "0xE431C8", VA = "0xE431C8")]
		public static void SetRegion(string pszRegion)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xE4331C", Offset = "0xE4331C", VA = "0xE4331C")]
		public static bool SendUserConnectAndAuthenticate(uint unIPClient, byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xE43378", Offset = "0xE43378", VA = "0xE43378")]
		public static CSteamID CreateUnauthenticatedUserConnection()
		{
			return default(CSteamID);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xE43444", Offset = "0xE43444", VA = "0xE43444")]
		public static void SendUserDisconnect(CSteamID steamIDUser)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xE43494", Offset = "0xE43494", VA = "0xE43494")]
		public static bool BUpdateUserData(CSteamID steamIDUser, string pchPlayerName, uint uScore)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xE4360C", Offset = "0xE4360C", VA = "0xE4360C")]
		public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			return default(HAuthTicket);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xE436DC", Offset = "0xE436DC", VA = "0xE436DC")]
		public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID)
		{
			return default(EBeginAuthSessionResult);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xE43738", Offset = "0xE43738", VA = "0xE43738")]
		public static void EndAuthSession(CSteamID steamID)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xE43788", Offset = "0xE43788", VA = "0xE43788")]
		public static void CancelAuthTicket(HAuthTicket hAuthTicket)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xE437C4", Offset = "0xE437C4", VA = "0xE437C4")]
		public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID)
		{
			return default(EUserHasLicenseForAppResult);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xE43818", Offset = "0xE43818", VA = "0xE43818")]
		public static bool RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xE43874", Offset = "0xE43874", VA = "0xE43874")]
		public static void GetGameplayStats()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xE438A8", Offset = "0xE438A8", VA = "0xE438A8")]
		public static SteamAPICall_t GetServerReputation()
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xE43954", Offset = "0xE43954", VA = "0xE43954")]
		public static uint GetPublicIP()
		{
			return default(uint);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xE43988", Offset = "0xE43988", VA = "0xE43988")]
		public static bool HandleIncomingPacket(byte[] pData, int cbData, uint srcIP, ushort srcPort)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xE439E4", Offset = "0xE439E4", VA = "0xE439E4")]
		public static int GetNextOutgoingPacket(byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort)
		{
			return default(int);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xE43A40", Offset = "0xE43A40", VA = "0xE43A40")]
		public static void EnableHeartbeats(bool bActive)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xE43A7C", Offset = "0xE43A7C", VA = "0xE43A7C")]
		public static void SetHeartbeatInterval(int iHeartbeatInterval)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xE43AB8", Offset = "0xE43AB8", VA = "0xE43AB8")]
		public static void ForceHeartbeat()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xE43AEC", Offset = "0xE43AEC", VA = "0xE43AEC")]
		public static SteamAPICall_t AssociateWithClan(CSteamID steamIDClan)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xE43BB4", Offset = "0xE43BB4", VA = "0xE43BB4")]
		public static SteamAPICall_t ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x2000088")]
	public static class SteamGameServerApps
	{
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xE43C7C", Offset = "0xE43C7C", VA = "0xE43C7C")]
		public static bool BIsSubscribed()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xE43CB0", Offset = "0xE43CB0", VA = "0xE43CB0")]
		public static bool BIsLowViolence()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xE43CE4", Offset = "0xE43CE4", VA = "0xE43CE4")]
		public static bool BIsCybercafe()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xE43D18", Offset = "0xE43D18", VA = "0xE43D18")]
		public static bool BIsVACBanned()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xE43D4C", Offset = "0xE43D4C", VA = "0xE43D4C")]
		public static string GetCurrentGameLanguage()
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xE43D90", Offset = "0xE43D90", VA = "0xE43D90")]
		public static string GetAvailableGameLanguages()
		{
			return null;
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xE43DD4", Offset = "0xE43DD4", VA = "0xE43DD4")]
		public static bool BIsSubscribedApp(AppId_t appID)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xE43E10", Offset = "0xE43E10", VA = "0xE43E10")]
		public static bool BIsDlcInstalled(AppId_t appID)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xE43E4C", Offset = "0xE43E4C", VA = "0xE43E4C")]
		public static uint GetEarliestPurchaseUnixTime(AppId_t nAppID)
		{
			return default(uint);
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xE43E88", Offset = "0xE43E88", VA = "0xE43E88")]
		public static bool BIsSubscribedFromFreeWeekend()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xE43EBC", Offset = "0xE43EBC", VA = "0xE43EBC")]
		public static int GetDLCCount()
		{
			return default(int);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xE43EF0", Offset = "0xE43EF0", VA = "0xE43EF0")]
		public static bool BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, out string pchName, int cchNameBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xE44030", Offset = "0xE44030", VA = "0xE44030")]
		public static void InstallDLC(AppId_t nAppID)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xE4406C", Offset = "0xE4406C", VA = "0xE4406C")]
		public static void UninstallDLC(AppId_t nAppID)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xE440A8", Offset = "0xE440A8", VA = "0xE440A8")]
		public static void RequestAppProofOfPurchaseKey(AppId_t nAppID)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xE440E4", Offset = "0xE440E4", VA = "0xE440E4")]
		public static bool GetCurrentBetaName(out string pchName, int cchNameBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xE44214", Offset = "0xE44214", VA = "0xE44214")]
		public static bool MarkContentCorrupt(bool bMissingFilesOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xE44250", Offset = "0xE44250", VA = "0xE44250")]
		public static uint GetInstalledDepots(AppId_t appID, DepotId_t[] pvecDepots, uint cMaxDepots)
		{
			return default(uint);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xE442A4", Offset = "0xE442A4", VA = "0xE442A4")]
		public static uint GetAppInstallDir(AppId_t appID, out string pchFolder, uint cchFolderBufferSize)
		{
			return default(uint);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xE443D8", Offset = "0xE443D8", VA = "0xE443D8")]
		public static bool BIsAppInstalled(AppId_t appID)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xE44414", Offset = "0xE44414", VA = "0xE44414")]
		public static CSteamID GetAppOwner()
		{
			return default(CSteamID);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xE444E0", Offset = "0xE444E0", VA = "0xE444E0")]
		public static string GetLaunchQueryParam(string pchKey)
		{
			return null;
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xE44654", Offset = "0xE44654", VA = "0xE44654")]
		public static bool GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xE446A8", Offset = "0xE446A8", VA = "0xE446A8")]
		public static int GetAppBuildId()
		{
			return default(int);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xE446DC", Offset = "0xE446DC", VA = "0xE446DC")]
		public static void RequestAllProofOfPurchaseKeys()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xE44710", Offset = "0xE44710", VA = "0xE44710")]
		public static SteamAPICall_t GetFileDetails(string pszFileName)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x2000089")]
	public static class SteamGameServerClient
	{
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xE448C0", Offset = "0xE448C0", VA = "0xE448C0")]
		public static HSteamPipe CreateSteamPipe()
		{
			return default(HSteamPipe);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xE44904", Offset = "0xE44904", VA = "0xE44904")]
		public static bool BReleaseSteamPipe(HSteamPipe hSteamPipe)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xE44940", Offset = "0xE44940", VA = "0xE44940")]
		public static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe)
		{
			return default(HSteamUser);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xE4498C", Offset = "0xE4498C", VA = "0xE4498C")]
		public static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType)
		{
			return default(HSteamUser);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xE449EC", Offset = "0xE449EC", VA = "0xE449EC")]
		public static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xE44A3C", Offset = "0xE44A3C", VA = "0xE44A3C")]
		public static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xE44BAC", Offset = "0xE44BAC", VA = "0xE44BAC")]
		public static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xE44D1C", Offset = "0xE44D1C", VA = "0xE44D1C")]
		public static void SetLocalIPBinding(uint unIP, ushort usPort)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xE44D6C", Offset = "0xE44D6C", VA = "0xE44D6C")]
		public static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xE44EDC", Offset = "0xE44EDC", VA = "0xE44EDC")]
		public static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xE45048", Offset = "0xE45048", VA = "0xE45048")]
		public static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xE451B8", Offset = "0xE451B8", VA = "0xE451B8")]
		public static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xE45328", Offset = "0xE45328", VA = "0xE45328")]
		public static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xE45498", Offset = "0xE45498", VA = "0xE45498")]
		public static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xE45608", Offset = "0xE45608", VA = "0xE45608")]
		public static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xE45778", Offset = "0xE45778", VA = "0xE45778")]
		public static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xE458E8", Offset = "0xE458E8", VA = "0xE458E8")]
		public static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xE45A58", Offset = "0xE45A58", VA = "0xE45A58")]
		public static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xE45BC8", Offset = "0xE45BC8", VA = "0xE45BC8")]
		public static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xE45D38", Offset = "0xE45D38", VA = "0xE45D38")]
		public static uint GetIPCCallCount()
		{
			return default(uint);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xE45D6C", Offset = "0xE45D6C", VA = "0xE45D6C")]
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xE45DA8", Offset = "0xE45DA8", VA = "0xE45DA8")]
		public static bool BShutdownIfAllPipesClosed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xE45DDC", Offset = "0xE45DDC", VA = "0xE45DDC")]
		public static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xE45F4C", Offset = "0xE45F4C", VA = "0xE45F4C")]
		public static IntPtr GetISteamUnifiedMessages(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xE460BC", Offset = "0xE460BC", VA = "0xE460BC")]
		public static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xE4622C", Offset = "0xE4622C", VA = "0xE4622C")]
		public static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xE4639C", Offset = "0xE4639C", VA = "0xE4639C")]
		public static IntPtr GetISteamAppList(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xE4650C", Offset = "0xE4650C", VA = "0xE4650C")]
		public static IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xE4667C", Offset = "0xE4667C", VA = "0xE4667C")]
		public static IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xE467EC", Offset = "0xE467EC", VA = "0xE467EC")]
		public static IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xE4695C", Offset = "0xE4695C", VA = "0xE4695C")]
		public static IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xE46ACC", Offset = "0xE46ACC", VA = "0xE46ACC")]
		public static IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xE46C3C", Offset = "0xE46C3C", VA = "0xE46C3C")]
		public static IntPtr GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x200008A")]
	public static class SteamGameServerHTTP
	{
		[Token(Token = "0x600020F")]
		[Address(RVA = "0xE46DAC", Offset = "0xE46DAC", VA = "0xE46DAC")]
		public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
		{
			return default(HTTPRequestHandle);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xE46F5C", Offset = "0xE46F5C", VA = "0xE46F5C")]
		public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xE46FB0", Offset = "0xE46FB0", VA = "0xE46FB0")]
		public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds)
		{
			return default(bool);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xE47000", Offset = "0xE47000", VA = "0xE47000")]
		public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xE47294", Offset = "0xE47294", VA = "0xE47294")]
		public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xE47528", Offset = "0xE47528", VA = "0xE47528")]
		public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xE47578", Offset = "0xE47578", VA = "0xE47578")]
		public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xE475C8", Offset = "0xE475C8", VA = "0xE475C8")]
		public static bool DeferHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xE47604", Offset = "0xE47604", VA = "0xE47604")]
		public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xE47640", Offset = "0xE47640", VA = "0xE47640")]
		public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xE477B0", Offset = "0xE477B0", VA = "0xE477B0")]
		public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xE47928", Offset = "0xE47928", VA = "0xE47928")]
		public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize)
		{
			return default(bool);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xE47978", Offset = "0xE47978", VA = "0xE47978")]
		public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xE479CC", Offset = "0xE479CC", VA = "0xE479CC")]
		public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xE47A28", Offset = "0xE47A28", VA = "0xE47A28")]
		public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xE47A64", Offset = "0xE47A64", VA = "0xE47A64")]
		public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut)
		{
			return default(bool);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xE47AB4", Offset = "0xE47AB4", VA = "0xE47AB4")]
		public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen)
		{
			return default(bool);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xE47C2C", Offset = "0xE47C2C", VA = "0xE47C2C")]
		public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify)
		{
			return default(HTTPCookieContainerHandle);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xE47CE4", Offset = "0xE47CE4", VA = "0xE47CE4")]
		public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xE47D20", Offset = "0xE47D20", VA = "0xE47D20")]
		public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie)
		{
			return default(bool);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xE480D8", Offset = "0xE480D8", VA = "0xE480D8")]
		public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xE48128", Offset = "0xE48128", VA = "0xE48128")]
		public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xE48294", Offset = "0xE48294", VA = "0xE48294")]
		public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate)
		{
			return default(bool);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xE482E4", Offset = "0xE482E4", VA = "0xE482E4")]
		public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds)
		{
			return default(bool);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xE48334", Offset = "0xE48334", VA = "0xE48334")]
		public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200008B")]
	public static class SteamGameServerInventory
	{
		[Token(Token = "0x6000228")]
		[Address(RVA = "0xE48384", Offset = "0xE48384", VA = "0xE48384")]
		public static EResult GetResultStatus(SteamInventoryResult_t resultHandle)
		{
			return default(EResult);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xE483C0", Offset = "0xE483C0", VA = "0xE483C0")]
		public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize)
		{
			return default(bool);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xE48414", Offset = "0xE48414", VA = "0xE48414")]
		public static bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			return default(bool);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xE4862C", Offset = "0xE4862C", VA = "0xE4862C")]
		public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle)
		{
			return default(uint);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xE48668", Offset = "0xE48668", VA = "0xE48668")]
		public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected)
		{
			return default(bool);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xE486BC", Offset = "0xE486BC", VA = "0xE486BC")]
		public static void DestroyResult(SteamInventoryResult_t resultHandle)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xE486F8", Offset = "0xE486F8", VA = "0xE486F8")]
		public static bool GetAllItems(out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xE48734", Offset = "0xE48734", VA = "0xE48734")]
		public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xE48788", Offset = "0xE48788", VA = "0xE48788")]
		public static bool SerializeResult(SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xE487DC", Offset = "0xE487DC", VA = "0xE487DC")]
		public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xE48838", Offset = "0xE48838", VA = "0xE48838")]
		public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xE48894", Offset = "0xE48894", VA = "0xE48894")]
		public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xE488D0", Offset = "0xE488D0", VA = "0xE488D0")]
		public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef)
		{
			return default(bool);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xE48920", Offset = "0xE48920", VA = "0xE48920")]
		public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xE48974", Offset = "0xE48974", VA = "0xE48974")]
		public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity)
		{
			return default(bool);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xE489D4", Offset = "0xE489D4", VA = "0xE489D4")]
		public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xE48A40", Offset = "0xE48A40", VA = "0xE48A40")]
		public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xE48AAC", Offset = "0xE48AAC", VA = "0xE48AAC")]
		public static void SendItemDropHeartbeat()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xE48AE0", Offset = "0xE48AE0", VA = "0xE48AE0")]
		public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition)
		{
			return default(bool);
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xE48B30", Offset = "0xE48B30", VA = "0xE48B30")]
		public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength)
		{
			return default(bool);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xE48BB0", Offset = "0xE48BB0", VA = "0xE48BB0")]
		public static bool LoadItemDefinitions()
		{
			return default(bool);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xE48BE4", Offset = "0xE48BE4", VA = "0xE48BE4")]
		public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize)
		{
			return default(bool);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xE48C34", Offset = "0xE48C34", VA = "0xE48C34")]
		public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			return default(bool);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xE48E48", Offset = "0xE48E48", VA = "0xE48E48")]
		public static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xE48F10", Offset = "0xE48F10", VA = "0xE48F10")]
		public static bool GetEligiblePromoItemDefinitionIDs(CSteamID steamID, SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200008C")]
	public static class SteamGameServerNetworking
	{
		[Token(Token = "0x6000241")]
		[Address(RVA = "0xE48F6C", Offset = "0xE48F6C", VA = "0xE48F6C")]
		public static bool SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xE48FCC", Offset = "0xE48FCC", VA = "0xE48FCC")]
		public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xE4901C", Offset = "0xE4901C", VA = "0xE4901C")]
		public static bool ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xE4907C", Offset = "0xE4907C", VA = "0xE4907C")]
		public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xE490CC", Offset = "0xE490CC", VA = "0xE490CC")]
		public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xE4911C", Offset = "0xE4911C", VA = "0xE4911C")]
		public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel)
		{
			return default(bool);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xE49170", Offset = "0xE49170", VA = "0xE49170")]
		public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState)
		{
			return default(bool);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xE491C4", Offset = "0xE491C4", VA = "0xE491C4")]
		public static bool AllowP2PPacketRelay(bool bAllow)
		{
			return default(bool);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xE49200", Offset = "0xE49200", VA = "0xE49200")]
		public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, bool bAllowUseOfPacketRelay)
		{
			return default(SNetListenSocket_t);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xE4925C", Offset = "0xE4925C", VA = "0xE4925C")]
		public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay)
		{
			return default(SNetSocket_t);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xE492BC", Offset = "0xE492BC", VA = "0xE492BC")]
		public static SNetSocket_t CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec)
		{
			return default(SNetSocket_t);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xE49310", Offset = "0xE49310", VA = "0xE49310")]
		public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xE49360", Offset = "0xE49360", VA = "0xE49360")]
		public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xE493B0", Offset = "0xE493B0", VA = "0xE493B0")]
		public static bool SendDataOnSocket(SNetSocket_t hSocket, byte[] pubData, uint cubData, bool bReliable)
		{
			return default(bool);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xE4940C", Offset = "0xE4940C", VA = "0xE4940C")]
		public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xE4945C", Offset = "0xE4945C", VA = "0xE4945C")]
		public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xE494B8", Offset = "0xE494B8", VA = "0xE494B8")]
		public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			return default(bool);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xE4950C", Offset = "0xE4950C", VA = "0xE4950C")]
		public static bool RetrieveData(SNetListenSocket_t hListenSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			return default(bool);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xE4956C", Offset = "0xE4956C", VA = "0xE4956C")]
		public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xE495CC", Offset = "0xE495CC", VA = "0xE495CC")]
		public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort)
		{
			return default(bool);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xE49620", Offset = "0xE49620", VA = "0xE49620")]
		public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket)
		{
			return default(ESNetSocketConnectionType);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xE4965C", Offset = "0xE4965C", VA = "0xE4965C")]
		public static int GetMaxPacketSize(SNetSocket_t hSocket)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200008D")]
	public static class SteamGameServerStats
	{
		[Token(Token = "0x6000257")]
		[Address(RVA = "0xE49698", Offset = "0xE49698", VA = "0xE49698")]
		public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xE49760", Offset = "0xE49760", VA = "0xE49760")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xE498D8", Offset = "0xE498D8", VA = "0xE498D8")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData)
		{
			return default(bool);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xE49A50", Offset = "0xE49A50", VA = "0xE49A50")]
		public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved)
		{
			return default(bool);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xE49BC8", Offset = "0xE49BC8", VA = "0xE49BC8")]
		public static bool SetUserStat(CSteamID steamIDUser, string pchName, int nData)
		{
			return default(bool);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xE49D40", Offset = "0xE49D40", VA = "0xE49D40")]
		public static bool SetUserStat(CSteamID steamIDUser, string pchName, float fData)
		{
			return default(bool);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xE49EBC", Offset = "0xE49EBC", VA = "0xE49EBC")]
		public static bool UpdateUserAvgRateStat(CSteamID steamIDUser, string pchName, float flCountThisSession, double dSessionLength)
		{
			return default(bool);
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xE4A040", Offset = "0xE4A040", VA = "0xE4A040")]
		public static bool SetUserAchievement(CSteamID steamIDUser, string pchName)
		{
			return default(bool);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xE4A1B0", Offset = "0xE4A1B0", VA = "0xE4A1B0")]
		public static bool ClearUserAchievement(CSteamID steamIDUser, string pchName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xE4A320", Offset = "0xE4A320", VA = "0xE4A320")]
		public static SteamAPICall_t StoreUserStats(CSteamID steamIDUser)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x200008E")]
	public static class SteamGameServerUGC
	{
		[Token(Token = "0x6000261")]
		[Address(RVA = "0xE4A3E8", Offset = "0xE4A3E8", VA = "0xE4A3E8")]
		public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xE4A4E8", Offset = "0xE4A4E8", VA = "0xE4A4E8")]
		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xE4A5DC", Offset = "0xE4A5DC", VA = "0xE4A5DC")]
		public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xE4A6B8", Offset = "0xE4A6B8", VA = "0xE4A6B8")]
		public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xE4A780", Offset = "0xE4A780", VA = "0xE4A780")]
		public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails)
		{
			return default(bool);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xE4A7D8", Offset = "0xE4A7D8", VA = "0xE4A7D8")]
		public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xE4A920", Offset = "0xE4A920", VA = "0xE4A920")]
		public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xE4AA68", Offset = "0xE4AA68", VA = "0xE4AA68")]
		public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return default(bool);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xE4AAC0", Offset = "0xE4AAC0", VA = "0xE4AAC0")]
		public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xE4AB18", Offset = "0xE4AB18", VA = "0xE4AB18")]
		public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index)
		{
			return default(uint);
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xE4AB6C", Offset = "0xE4AB6C", VA = "0xE4AB6C")]
		public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out string pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType)
		{
			return default(bool);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xE4AD44", Offset = "0xE4AD44", VA = "0xE4AD44")]
		public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index)
		{
			return default(uint);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xE4AD98", Offset = "0xE4AD98", VA = "0xE4AD98")]
		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xE4AF64", Offset = "0xE4AF64", VA = "0xE4AF64")]
		public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(bool);
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xE4AFB4", Offset = "0xE4AFB4", VA = "0xE4AFB4")]
		public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xE4B124", Offset = "0xE4B124", VA = "0xE4B124")]
		public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xE4B294", Offset = "0xE4B294", VA = "0xE4B294")]
		public static bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xE4B2E8", Offset = "0xE4B2E8", VA = "0xE4B2E8")]
		public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xE4B33C", Offset = "0xE4B33C", VA = "0xE4B33C")]
		public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription)
		{
			return default(bool);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xE4B390", Offset = "0xE4B390", VA = "0xE4B390")]
		public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata)
		{
			return default(bool);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xE4B3E4", Offset = "0xE4B3E4", VA = "0xE4B3E4")]
		public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren)
		{
			return default(bool);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xE4B438", Offset = "0xE4B438", VA = "0xE4B438")]
		public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews)
		{
			return default(bool);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xE4B48C", Offset = "0xE4B48C", VA = "0xE4B48C")]
		public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xE4B4E0", Offset = "0xE4B4E0", VA = "0xE4B4E0")]
		public static bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays)
		{
			return default(bool);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xE4B534", Offset = "0xE4B534", VA = "0xE4B534")]
		public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage)
		{
			return default(bool);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xE4B6A4", Offset = "0xE4B6A4", VA = "0xE4B6A4")]
		public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds)
		{
			return default(bool);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xE4B6F8", Offset = "0xE4B6F8", VA = "0xE4B6F8")]
		public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName)
		{
			return default(bool);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xE4B868", Offset = "0xE4B868", VA = "0xE4B868")]
		public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag)
		{
			return default(bool);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xE4B8BC", Offset = "0xE4B8BC", VA = "0xE4B8BC")]
		public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText)
		{
			return default(bool);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xE4BA2C", Offset = "0xE4BA2C", VA = "0xE4BA2C")]
		public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays)
		{
			return default(bool);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xE4BA80", Offset = "0xE4BA80", VA = "0xE4BA80")]
		public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xE4BD28", Offset = "0xE4BD28", VA = "0xE4BD28")]
		public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xE4BDF8", Offset = "0xE4BDF8", VA = "0xE4BDF8")]
		public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xE4BEC0", Offset = "0xE4BEC0", VA = "0xE4BEC0")]
		public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(UGCUpdateHandle_t);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xE4BFA0", Offset = "0xE4BFA0", VA = "0xE4BFA0")]
		public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xE4C110", Offset = "0xE4C110", VA = "0xE4C110")]
		public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription)
		{
			return default(bool);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xE4C280", Offset = "0xE4C280", VA = "0xE4C280")]
		public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xE4C3F0", Offset = "0xE4C3F0", VA = "0xE4C3F0")]
		public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xE4C560", Offset = "0xE4C560", VA = "0xE4C560")]
		public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			return default(bool);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xE4C5B4", Offset = "0xE4C5B4", VA = "0xE4C5B4")]
		public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<string> pTags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xE4C67C", Offset = "0xE4C67C", VA = "0xE4C67C")]
		public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder)
		{
			return default(bool);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xE4C7EC", Offset = "0xE4C7EC", VA = "0xE4C7EC")]
		public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile)
		{
			return default(bool);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xE4C95C", Offset = "0xE4C95C", VA = "0xE4C95C")]
		public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey)
		{
			return default(bool);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xE4CACC", Offset = "0xE4CACC", VA = "0xE4CACC")]
		public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xE4CD74", Offset = "0xE4CD74", VA = "0xE4CD74")]
		public static bool AddItemPreviewFile(UGCUpdateHandle_t handle, string pszPreviewFile, EItemPreviewType type)
		{
			return default(bool);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xE4CEEC", Offset = "0xE4CEEC", VA = "0xE4CEEC")]
		public static bool AddItemPreviewVideo(UGCUpdateHandle_t handle, string pszVideoID)
		{
			return default(bool);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xE4D05C", Offset = "0xE4D05C", VA = "0xE4D05C")]
		public static bool UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, string pszPreviewFile)
		{
			return default(bool);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xE4D1D0", Offset = "0xE4D1D0", VA = "0xE4D1D0")]
		public static bool UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, string pszVideoID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xE4D344", Offset = "0xE4D344", VA = "0xE4D344")]
		public static bool RemoveItemPreview(UGCUpdateHandle_t handle, uint index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xE4D398", Offset = "0xE4D398", VA = "0xE4D398")]
		public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xE4D554", Offset = "0xE4D554", VA = "0xE4D554")]
		public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal)
		{
			return default(EItemUpdateStatus);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xE4D5AC", Offset = "0xE4D5AC", VA = "0xE4D5AC")]
		public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xE4D67C", Offset = "0xE4D67C", VA = "0xE4D67C")]
		public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xE4D744", Offset = "0xE4D744", VA = "0xE4D744")]
		public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xE4D810", Offset = "0xE4D810", VA = "0xE4D810")]
		public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xE4D8DC", Offset = "0xE4D8DC", VA = "0xE4D8DC")]
		public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xE4D9A4", Offset = "0xE4D9A4", VA = "0xE4D9A4")]
		public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xE4DA6C", Offset = "0xE4DA6C", VA = "0xE4DA6C")]
		public static uint GetNumSubscribedItems()
		{
			return default(uint);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xE4DAA0", Offset = "0xE4DAA0", VA = "0xE4DAA0")]
		public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return default(uint);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xE4DAF0", Offset = "0xE4DAF0", VA = "0xE4DAF0")]
		public static uint GetItemState(PublishedFileId_t nPublishedFileID)
		{
			return default(uint);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xE4DB40", Offset = "0xE4DB40", VA = "0xE4DB40")]
		public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp)
		{
			return default(bool);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xE4DC90", Offset = "0xE4DC90", VA = "0xE4DC90")]
		public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			return default(bool);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xE4DCE8", Offset = "0xE4DCE8", VA = "0xE4DCE8")]
		public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xE4DD3C", Offset = "0xE4DD3C", VA = "0xE4DD3C")]
		public static bool BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, string pszFolder)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xE4DEA8", Offset = "0xE4DEA8", VA = "0xE4DEA8")]
		public static void SuspendDownloads(bool bSuspend)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xE4DEE4", Offset = "0xE4DEE4", VA = "0xE4DEE4")]
		public static SteamAPICall_t StartPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xE4DFAC", Offset = "0xE4DFAC", VA = "0xE4DFAC")]
		public static SteamAPICall_t StopPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xE4E074", Offset = "0xE4E074", VA = "0xE4E074")]
		public static SteamAPICall_t StopPlaytimeTrackingForAllItems()
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xE4E120", Offset = "0xE4E120", VA = "0xE4E120")]
		public static SteamAPICall_t AddDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xE4E1F8", Offset = "0xE4E1F8", VA = "0xE4E1F8")]
		public static SteamAPICall_t RemoveDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xE4E2D0", Offset = "0xE4E2D0", VA = "0xE4E2D0")]
		public static SteamAPICall_t AddAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xE4E3A0", Offset = "0xE4E3A0", VA = "0xE4E3A0")]
		public static SteamAPICall_t RemoveAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xE4E470", Offset = "0xE4E470", VA = "0xE4E470")]
		public static SteamAPICall_t GetAppDependencies(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xE4E538", Offset = "0xE4E538", VA = "0xE4E538")]
		public static SteamAPICall_t DeleteItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x200008F")]
	public static class SteamGameServerUtils
	{
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xE4E600", Offset = "0xE4E600", VA = "0xE4E600")]
		public static uint GetSecondsSinceAppActive()
		{
			return default(uint);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xE4E634", Offset = "0xE4E634", VA = "0xE4E634")]
		public static uint GetSecondsSinceComputerActive()
		{
			return default(uint);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xE4E668", Offset = "0xE4E668", VA = "0xE4E668")]
		public static EUniverse GetConnectedUniverse()
		{
			return default(EUniverse);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xE4E69C", Offset = "0xE4E69C", VA = "0xE4E69C")]
		public static uint GetServerRealTime()
		{
			return default(uint);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xE4E6D0", Offset = "0xE4E6D0", VA = "0xE4E6D0")]
		public static string GetIPCountry()
		{
			return null;
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xE4E714", Offset = "0xE4E714", VA = "0xE4E714")]
		public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xE4E768", Offset = "0xE4E768", VA = "0xE4E768")]
		public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xE4E7BC", Offset = "0xE4E7BC", VA = "0xE4E7BC")]
		public static bool GetCSERIPPort(out uint unIP, out ushort usPort)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xE4E80C", Offset = "0xE4E80C", VA = "0xE4E80C")]
		public static byte GetCurrentBatteryPower()
		{
			return default(byte);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xE4E840", Offset = "0xE4E840", VA = "0xE4E840")]
		public static AppId_t GetAppID()
		{
			return default(AppId_t);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xE4E8F0", Offset = "0xE4E8F0", VA = "0xE4E8F0")]
		public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xE4E92C", Offset = "0xE4E92C", VA = "0xE4E92C")]
		public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xE4E980", Offset = "0xE4E980", VA = "0xE4E980")]
		public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
		{
			return default(ESteamAPICallFailure);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xE4E9D0", Offset = "0xE4E9D0", VA = "0xE4E9D0")]
		public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xE4EA30", Offset = "0xE4EA30", VA = "0xE4EA30")]
		public static uint GetIPCCallCount()
		{
			return default(uint);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xE4EA64", Offset = "0xE4EA64", VA = "0xE4EA64")]
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xE4EAA0", Offset = "0xE4EAA0", VA = "0xE4EAA0")]
		public static bool IsOverlayEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xE4EAD4", Offset = "0xE4EAD4", VA = "0xE4EAD4")]
		public static bool BOverlayNeedsPresent()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xE4EB08", Offset = "0xE4EB08", VA = "0xE4EB08")]
		public static SteamAPICall_t CheckFileSignature(string szFileName)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xE4ECB8", Offset = "0xE4ECB8", VA = "0xE4ECB8")]
		public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xE4EF68", Offset = "0xE4EF68", VA = "0xE4EF68")]
		public static uint GetEnteredGamepadTextLength()
		{
			return default(uint);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xE4EF9C", Offset = "0xE4EF9C", VA = "0xE4EF9C")]
		public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xE4F0CC", Offset = "0xE4F0CC", VA = "0xE4F0CC")]
		public static string GetSteamUILanguage()
		{
			return null;
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xE4F110", Offset = "0xE4F110", VA = "0xE4F110")]
		public static bool IsSteamRunningInVR()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xE4F144", Offset = "0xE4F144", VA = "0xE4F144")]
		public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xE4F194", Offset = "0xE4F194", VA = "0xE4F194")]
		public static bool IsSteamInBigPictureMode()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xE4F1C8", Offset = "0xE4F1C8", VA = "0xE4F1C8")]
		public static void StartVRDashboard()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xE4F1FC", Offset = "0xE4F1FC", VA = "0xE4F1FC")]
		public static bool IsVRHeadsetStreamingEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xE4F230", Offset = "0xE4F230", VA = "0xE4F230")]
		public static void SetVRHeadsetStreamingEnabled(bool bEnabled)
		{
		}
	}
	[Token(Token = "0x2000090")]
	public static class SteamHTMLSurface
	{
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xE4F26C", Offset = "0xE4F26C", VA = "0xE4F26C")]
		public static bool Init()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xE4F2A0", Offset = "0xE4F2A0", VA = "0xE4F2A0")]
		public static bool Shutdown()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xE4F2D4", Offset = "0xE4F2D4", VA = "0xE4F2D4")]
		public static SteamAPICall_t CreateBrowser(string pchUserAgent, string pchUserCSS)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xE4F5A0", Offset = "0xE4F5A0", VA = "0xE4F5A0")]
		public static void RemoveBrowser(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xE4F5DC", Offset = "0xE4F5DC", VA = "0xE4F5DC")]
		public static void LoadURL(HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xE4F840", Offset = "0xE4F840", VA = "0xE4F840")]
		public static void SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xE4F894", Offset = "0xE4F894", VA = "0xE4F894")]
		public static void StopLoad(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xE4F8D0", Offset = "0xE4F8D0", VA = "0xE4F8D0")]
		public static void Reload(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xE4F90C", Offset = "0xE4F90C", VA = "0xE4F90C")]
		public static void GoBack(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xE4F948", Offset = "0xE4F948", VA = "0xE4F948")]
		public static void GoForward(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xE4F984", Offset = "0xE4F984", VA = "0xE4F984")]
		public static void AddHeader(HHTMLBrowser unBrowserHandle, string pchKey, string pchValue)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xE4FBE8", Offset = "0xE4FBE8", VA = "0xE4FBE8")]
		public static void ExecuteJavascript(HHTMLBrowser unBrowserHandle, string pchScript)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xE4FD50", Offset = "0xE4FD50", VA = "0xE4FD50")]
		public static void MouseUp(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xE4FDA0", Offset = "0xE4FDA0", VA = "0xE4FDA0")]
		public static void MouseDown(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xE4FDF0", Offset = "0xE4FDF0", VA = "0xE4FDF0")]
		public static void MouseDoubleClick(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xE4FE40", Offset = "0xE4FE40", VA = "0xE4FE40")]
		public static void MouseMove(HHTMLBrowser unBrowserHandle, int x, int y)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xE4FE94", Offset = "0xE4FE94", VA = "0xE4FE94")]
		public static void MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xE4FEE4", Offset = "0xE4FEE4", VA = "0xE4FEE4")]
		public static void KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xE4FF38", Offset = "0xE4FF38", VA = "0xE4FF38")]
		public static void KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xE4FF8C", Offset = "0xE4FF8C", VA = "0xE4FF8C")]
		public static void KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xE4FFE0", Offset = "0xE4FFE0", VA = "0xE4FFE0")]
		public static void SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xE50030", Offset = "0xE50030", VA = "0xE50030")]
		public static void SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xE50080", Offset = "0xE50080", VA = "0xE50080")]
		public static void SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xE500D0", Offset = "0xE500D0", VA = "0xE500D0")]
		public static void ViewSource(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xE5010C", Offset = "0xE5010C", VA = "0xE5010C")]
		public static void CopyToClipboard(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xE50148", Offset = "0xE50148", VA = "0xE50148")]
		public static void PasteFromClipboard(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xE50184", Offset = "0xE50184", VA = "0xE50184")]
		public static void Find(HHTMLBrowser unBrowserHandle, string pchSearchStr, bool bCurrentlyInFind, bool bReverse)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xE502F8", Offset = "0xE502F8", VA = "0xE502F8")]
		public static void StopFind(HHTMLBrowser unBrowserHandle)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xE50334", Offset = "0xE50334", VA = "0xE50334")]
		public static void GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xE50388", Offset = "0xE50388", VA = "0xE50388")]
		public static void SetCookie(string pchHostname, string pchKey, string pchValue, string pchPath = "/", uint nExpires = 0u, bool bSecure = false, bool bHTTPOnly = false)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xE5085C", Offset = "0xE5085C", VA = "0xE5085C")]
		public static void SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xE508B8", Offset = "0xE508B8", VA = "0xE508B8")]
		public static void SetBackgroundMode(HHTMLBrowser unBrowserHandle, bool bBackgroundMode)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xE50908", Offset = "0xE50908", VA = "0xE50908")]
		public static void SetDPIScalingFactor(HHTMLBrowser unBrowserHandle, float flDPIScaling)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xE50958", Offset = "0xE50958", VA = "0xE50958")]
		public static void AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xE509A8", Offset = "0xE509A8", VA = "0xE509A8")]
		public static void JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xE509F8", Offset = "0xE509F8", VA = "0xE509F8")]
		public static void FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles)
		{
		}
	}
	[Token(Token = "0x2000091")]
	public static class SteamHTTP
	{
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xE50A48", Offset = "0xE50A48", VA = "0xE50A48")]
		public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
		{
			return default(HTTPRequestHandle);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xE50BF8", Offset = "0xE50BF8", VA = "0xE50BF8")]
		public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xE50C4C", Offset = "0xE50C4C", VA = "0xE50C4C")]
		public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xE50C9C", Offset = "0xE50C9C", VA = "0xE50C9C")]
		public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xE50F30", Offset = "0xE50F30", VA = "0xE50F30")]
		public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xE511C4", Offset = "0xE511C4", VA = "0xE511C4")]
		public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xE51214", Offset = "0xE51214", VA = "0xE51214")]
		public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xE51264", Offset = "0xE51264", VA = "0xE51264")]
		public static bool DeferHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xE512A0", Offset = "0xE512A0", VA = "0xE512A0")]
		public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xE512DC", Offset = "0xE512DC", VA = "0xE512DC")]
		public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xE5144C", Offset = "0xE5144C", VA = "0xE5144C")]
		public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xE515C4", Offset = "0xE515C4", VA = "0xE515C4")]
		public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xE51614", Offset = "0xE51614", VA = "0xE51614")]
		public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xE51668", Offset = "0xE51668", VA = "0xE51668")]
		public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xE516C4", Offset = "0xE516C4", VA = "0xE516C4")]
		public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xE51700", Offset = "0xE51700", VA = "0xE51700")]
		public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xE51750", Offset = "0xE51750", VA = "0xE51750")]
		public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xE518C8", Offset = "0xE518C8", VA = "0xE518C8")]
		public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify)
		{
			return default(HTTPCookieContainerHandle);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xE51980", Offset = "0xE51980", VA = "0xE51980")]
		public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xE519BC", Offset = "0xE519BC", VA = "0xE519BC")]
		public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie)
		{
			return default(bool);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xE51D74", Offset = "0xE51D74", VA = "0xE51D74")]
		public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xE51DC4", Offset = "0xE51DC4", VA = "0xE51DC4")]
		public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xE51F30", Offset = "0xE51F30", VA = "0xE51F30")]
		public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate)
		{
			return default(bool);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xE51F80", Offset = "0xE51F80", VA = "0xE51F80")]
		public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds)
		{
			return default(bool);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xE51FD0", Offset = "0xE51FD0", VA = "0xE51FD0")]
		public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000092")]
	public static class SteamInventory
	{
		[Token(Token = "0x6000305")]
		[Address(RVA = "0xE52020", Offset = "0xE52020", VA = "0xE52020")]
		public static EResult GetResultStatus(SteamInventoryResult_t resultHandle)
		{
			return default(EResult);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xE5205C", Offset = "0xE5205C", VA = "0xE5205C")]
		public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xE520B0", Offset = "0xE520B0", VA = "0xE520B0")]
		public static bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xE522C8", Offset = "0xE522C8", VA = "0xE522C8")]
		public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle)
		{
			return default(uint);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xE52304", Offset = "0xE52304", VA = "0xE52304")]
		public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected)
		{
			return default(bool);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xE52358", Offset = "0xE52358", VA = "0xE52358")]
		public static void DestroyResult(SteamInventoryResult_t resultHandle)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xE52394", Offset = "0xE52394", VA = "0xE52394")]
		public static bool GetAllItems(out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xE523D0", Offset = "0xE523D0", VA = "0xE523D0")]
		public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs)
		{
			return default(bool);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xE52424", Offset = "0xE52424", VA = "0xE52424")]
		public static bool SerializeResult(SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xE52478", Offset = "0xE52478", VA = "0xE52478")]
		public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xE524D4", Offset = "0xE524D4", VA = "0xE524D4")]
		public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xE52530", Offset = "0xE52530", VA = "0xE52530")]
		public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xE5256C", Offset = "0xE5256C", VA = "0xE5256C")]
		public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef)
		{
			return default(bool);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xE525BC", Offset = "0xE525BC", VA = "0xE525BC")]
		public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xE52610", Offset = "0xE52610", VA = "0xE52610")]
		public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity)
		{
			return default(bool);
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xE52670", Offset = "0xE52670", VA = "0xE52670")]
		public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xE526DC", Offset = "0xE526DC", VA = "0xE526DC")]
		public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xE52748", Offset = "0xE52748", VA = "0xE52748")]
		public static void SendItemDropHeartbeat()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xE5277C", Offset = "0xE5277C", VA = "0xE5277C")]
		public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xE527CC", Offset = "0xE527CC", VA = "0xE527CC")]
		public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xE5284C", Offset = "0xE5284C", VA = "0xE5284C")]
		public static bool LoadItemDefinitions()
		{
			return default(bool);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xE52880", Offset = "0xE52880", VA = "0xE52880")]
		public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize)
		{
			return default(bool);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xE528D0", Offset = "0xE528D0", VA = "0xE528D0")]
		public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			return default(bool);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xE52AE4", Offset = "0xE52AE4", VA = "0xE52AE4")]
		public static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xE52BAC", Offset = "0xE52BAC", VA = "0xE52BAC")]
		public static bool GetEligiblePromoItemDefinitionIDs(CSteamID steamID, SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000093")]
	public static class SteamMatchmaking
	{
		[Token(Token = "0x600031E")]
		[Address(RVA = "0xE53520", Offset = "0xE53520", VA = "0xE53520")]
		public static int GetFavoriteGameCount()
		{
			return default(int);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xE53554", Offset = "0xE53554", VA = "0xE53554")]
		public static bool GetFavoriteGame(int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xE535C0", Offset = "0xE535C0", VA = "0xE535C0")]
		public static int AddFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer)
		{
			return default(int);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xE53620", Offset = "0xE53620", VA = "0xE53620")]
		public static bool RemoveFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xE53680", Offset = "0xE53680", VA = "0xE53680")]
		public static SteamAPICall_t RequestLobbyList()
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xE5372C", Offset = "0xE5372C", VA = "0xE5372C")]
		public static void AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, ELobbyComparison eComparisonType)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xE53990", Offset = "0xE53990", VA = "0xE53990")]
		public static void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xE53AFC", Offset = "0xE53AFC", VA = "0xE53AFC")]
		public static void AddRequestLobbyListNearValueFilter(string pchKeyToMatch, int nValueToBeCloseTo)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xE53C64", Offset = "0xE53C64", VA = "0xE53C64")]
		public static void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xE53CA0", Offset = "0xE53CA0", VA = "0xE53CA0")]
		public static void AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xE53CDC", Offset = "0xE53CDC", VA = "0xE53CDC")]
		public static void AddRequestLobbyListResultCountFilter(int cMaxResults)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xE53D18", Offset = "0xE53D18", VA = "0xE53D18")]
		public static void AddRequestLobbyListCompatibleMembersFilter(CSteamID steamIDLobby)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xE53D68", Offset = "0xE53D68", VA = "0xE53D68")]
		public static CSteamID GetLobbyByIndex(int iLobby)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xE53E3C", Offset = "0xE53E3C", VA = "0xE53E3C")]
		public static SteamAPICall_t CreateLobby(ELobbyType eLobbyType, int cMaxMembers)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xE53F04", Offset = "0xE53F04", VA = "0xE53F04")]
		public static SteamAPICall_t JoinLobby(CSteamID steamIDLobby)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xE53FCC", Offset = "0xE53FCC", VA = "0xE53FCC")]
		public static void LeaveLobby(CSteamID steamIDLobby)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xE5401C", Offset = "0xE5401C", VA = "0xE5401C")]
		public static bool InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee)
		{
			return default(bool);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xE54078", Offset = "0xE54078", VA = "0xE54078")]
		public static int GetNumLobbyMembers(CSteamID steamIDLobby)
		{
			return default(int);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xE540C8", Offset = "0xE540C8", VA = "0xE540C8")]
		public static CSteamID GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xE541AC", Offset = "0xE541AC", VA = "0xE541AC")]
		public static string GetLobbyData(CSteamID steamIDLobby, string pchKey)
		{
			return null;
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xE54330", Offset = "0xE54330", VA = "0xE54330")]
		public static bool SetLobbyData(CSteamID steamIDLobby, string pchKey, string pchValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xE545D8", Offset = "0xE545D8", VA = "0xE545D8")]
		public static int GetLobbyDataCount(CSteamID steamIDLobby)
		{
			return default(int);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xE54628", Offset = "0xE54628", VA = "0xE54628")]
		public static bool GetLobbyDataByIndex(CSteamID steamIDLobby, int iLobbyData, out string pchKey, int cchKeyBufferSize, out string pchValue, int cchValueBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xE547EC", Offset = "0xE547EC", VA = "0xE547EC")]
		public static bool DeleteLobbyData(CSteamID steamIDLobby, string pchKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xE5495C", Offset = "0xE5495C", VA = "0xE5495C")]
		public static string GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey)
		{
			return null;
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xE54AEC", Offset = "0xE54AEC", VA = "0xE54AEC")]
		public static void SetLobbyMemberData(CSteamID steamIDLobby, string pchKey, string pchValue)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xE54D58", Offset = "0xE54D58", VA = "0xE54D58")]
		public static bool SendLobbyChatMsg(CSteamID steamIDLobby, byte[] pvMsgBody, int cubMsgBody)
		{
			return default(bool);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xE54DB4", Offset = "0xE54DB4", VA = "0xE54DB4")]
		public static int GetLobbyChatEntry(CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, byte[] pvData, int cubData, out EChatEntryType peChatEntryType)
		{
			return default(int);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xE54E20", Offset = "0xE54E20", VA = "0xE54E20")]
		public static bool RequestLobbyData(CSteamID steamIDLobby)
		{
			return default(bool);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xE54E70", Offset = "0xE54E70", VA = "0xE54E70")]
		public static void SetLobbyGameServer(CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xE54ED0", Offset = "0xE54ED0", VA = "0xE54ED0")]
		public static bool GetLobbyGameServer(CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer)
		{
			return default(bool);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xE54F30", Offset = "0xE54F30", VA = "0xE54F30")]
		public static bool SetLobbyMemberLimit(CSteamID steamIDLobby, int cMaxMembers)
		{
			return default(bool);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xE54F84", Offset = "0xE54F84", VA = "0xE54F84")]
		public static int GetLobbyMemberLimit(CSteamID steamIDLobby)
		{
			return default(int);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xE54FD4", Offset = "0xE54FD4", VA = "0xE54FD4")]
		public static bool SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xE55028", Offset = "0xE55028", VA = "0xE55028")]
		public static bool SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable)
		{
			return default(bool);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xE5507C", Offset = "0xE5507C", VA = "0xE5507C")]
		public static CSteamID GetLobbyOwner(CSteamID steamIDLobby)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xE55158", Offset = "0xE55158", VA = "0xE55158")]
		public static bool SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner)
		{
			return default(bool);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xE551B4", Offset = "0xE551B4", VA = "0xE551B4")]
		public static bool SetLinkedLobby(CSteamID steamIDLobby, CSteamID steamIDLobbyDependent)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000094")]
	public static class SteamMatchmakingServers
	{
		[Token(Token = "0x6000344")]
		[Address(RVA = "0xE55210", Offset = "0xE55210", VA = "0xE55210")]
		public static HServerListRequest RequestInternetServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xE55334", Offset = "0xE55334", VA = "0xE55334")]
		public static HServerListRequest RequestLANServerList(AppId_t iApp, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xE55414", Offset = "0xE55414", VA = "0xE55414")]
		public static HServerListRequest RequestFriendsServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xE55538", Offset = "0xE55538", VA = "0xE55538")]
		public static HServerListRequest RequestFavoritesServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xE5565C", Offset = "0xE5565C", VA = "0xE5565C")]
		public static HServerListRequest RequestHistoryServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xE55780", Offset = "0xE55780", VA = "0xE55780")]
		public static HServerListRequest RequestSpectatorServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xE558A4", Offset = "0xE558A4", VA = "0xE558A4")]
		public static void ReleaseRequest(HServerListRequest hServerListRequest)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xE558E0", Offset = "0xE558E0", VA = "0xE558E0")]
		public static gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xE55A88", Offset = "0xE55A88", VA = "0xE55A88")]
		public static void CancelQuery(HServerListRequest hRequest)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xE55AC4", Offset = "0xE55AC4", VA = "0xE55AC4")]
		public static void RefreshQuery(HServerListRequest hRequest)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xE55B00", Offset = "0xE55B00", VA = "0xE55B00")]
		public static bool IsRefreshing(HServerListRequest hRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xE55B3C", Offset = "0xE55B3C", VA = "0xE55B3C")]
		public static int GetServerCount(HServerListRequest hRequest)
		{
			return default(int);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xE55B78", Offset = "0xE55B78", VA = "0xE55B78")]
		public static void RefreshServer(HServerListRequest hRequest, int iServer)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xE55BC8", Offset = "0xE55BC8", VA = "0xE55BC8")]
		public static HServerQuery PingServer(uint unIP, ushort usPort, ISteamMatchmakingPingResponse pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xE55CAC", Offset = "0xE55CAC", VA = "0xE55CAC")]
		public static HServerQuery PlayerDetails(uint unIP, ushort usPort, ISteamMatchmakingPlayersResponse pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xE55D90", Offset = "0xE55D90", VA = "0xE55D90")]
		public static HServerQuery ServerRules(uint unIP, ushort usPort, ISteamMatchmakingRulesResponse pRequestServersResponse)
		{
			return default(HServerQuery);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xE55E74", Offset = "0xE55E74", VA = "0xE55E74")]
		public static void CancelServerQuery(HServerQuery hServerQuery)
		{
		}
	}
	[Token(Token = "0x2000095")]
	public static class SteamMusic
	{
		[Token(Token = "0x6000355")]
		[Address(RVA = "0xE55EB0", Offset = "0xE55EB0", VA = "0xE55EB0")]
		public static bool BIsEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xE55EE4", Offset = "0xE55EE4", VA = "0xE55EE4")]
		public static bool BIsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xE55F18", Offset = "0xE55F18", VA = "0xE55F18")]
		public static AudioPlayback_Status GetPlaybackStatus()
		{
			return default(AudioPlayback_Status);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xE55F4C", Offset = "0xE55F4C", VA = "0xE55F4C")]
		public static void Play()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xE55F80", Offset = "0xE55F80", VA = "0xE55F80")]
		public static void Pause()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xE55FB4", Offset = "0xE55FB4", VA = "0xE55FB4")]
		public static void PlayPrevious()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xE55FE8", Offset = "0xE55FE8", VA = "0xE55FE8")]
		public static void PlayNext()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xE5601C", Offset = "0xE5601C", VA = "0xE5601C")]
		public static void SetVolume(float flVolume)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xE56058", Offset = "0xE56058", VA = "0xE56058")]
		public static float GetVolume()
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000096")]
	public static class SteamMusicRemote
	{
		[Token(Token = "0x600035E")]
		[Address(RVA = "0xE5608C", Offset = "0xE5608C", VA = "0xE5608C")]
		public static bool RegisterSteamMusicRemote(string pchName)
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xE561F0", Offset = "0xE561F0", VA = "0xE561F0")]
		public static bool DeregisterSteamMusicRemote()
		{
			return default(bool);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xE56224", Offset = "0xE56224", VA = "0xE56224")]
		public static bool BIsCurrentMusicRemote()
		{
			return default(bool);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xE56258", Offset = "0xE56258", VA = "0xE56258")]
		public static bool BActivationSuccess(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xE56294", Offset = "0xE56294", VA = "0xE56294")]
		public static bool SetDisplayName(string pchDisplayName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xE563F8", Offset = "0xE563F8", VA = "0xE563F8")]
		public static bool SetPNGIcon_64x64(byte[] pvBuffer, uint cbBufferLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xE56448", Offset = "0xE56448", VA = "0xE56448")]
		public static bool EnablePlayPrevious(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xE56484", Offset = "0xE56484", VA = "0xE56484")]
		public static bool EnablePlayNext(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xE564C0", Offset = "0xE564C0", VA = "0xE564C0")]
		public static bool EnableShuffled(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xE564FC", Offset = "0xE564FC", VA = "0xE564FC")]
		public static bool EnableLooped(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xE56538", Offset = "0xE56538", VA = "0xE56538")]
		public static bool EnableQueue(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xE56574", Offset = "0xE56574", VA = "0xE56574")]
		public static bool EnablePlaylists(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xE565B0", Offset = "0xE565B0", VA = "0xE565B0")]
		public static bool UpdatePlaybackStatus(AudioPlayback_Status nStatus)
		{
			return default(bool);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xE565EC", Offset = "0xE565EC", VA = "0xE565EC")]
		public static bool UpdateShuffled(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xE56628", Offset = "0xE56628", VA = "0xE56628")]
		public static bool UpdateLooped(bool bValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xE56664", Offset = "0xE56664", VA = "0xE56664")]
		public static bool UpdateVolume(float flValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xE566A0", Offset = "0xE566A0", VA = "0xE566A0")]
		public static bool CurrentEntryWillChange()
		{
			return default(bool);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xE566D4", Offset = "0xE566D4", VA = "0xE566D4")]
		public static bool CurrentEntryIsAvailable(bool bAvailable)
		{
			return default(bool);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xE56710", Offset = "0xE56710", VA = "0xE56710")]
		public static bool UpdateCurrentEntryText(string pchText)
		{
			return default(bool);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xE56874", Offset = "0xE56874", VA = "0xE56874")]
		public static bool UpdateCurrentEntryElapsedSeconds(int nValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xE568B0", Offset = "0xE568B0", VA = "0xE568B0")]
		public static bool UpdateCurrentEntryCoverArt(byte[] pvBuffer, uint cbBufferLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xE56900", Offset = "0xE56900", VA = "0xE56900")]
		public static bool CurrentEntryDidChange()
		{
			return default(bool);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xE56934", Offset = "0xE56934", VA = "0xE56934")]
		public static bool QueueWillChange()
		{
			return default(bool);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xE56968", Offset = "0xE56968", VA = "0xE56968")]
		public static bool ResetQueueEntries()
		{
			return default(bool);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xE5699C", Offset = "0xE5699C", VA = "0xE5699C")]
		public static bool SetQueueEntry(int nID, int nPosition, string pchEntryText)
		{
			return default(bool);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xE56B0C", Offset = "0xE56B0C", VA = "0xE56B0C")]
		public static bool SetCurrentQueueEntry(int nID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xE56B48", Offset = "0xE56B48", VA = "0xE56B48")]
		public static bool QueueDidChange()
		{
			return default(bool);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xE56B7C", Offset = "0xE56B7C", VA = "0xE56B7C")]
		public static bool PlaylistWillChange()
		{
			return default(bool);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xE56BB0", Offset = "0xE56BB0", VA = "0xE56BB0")]
		public static bool ResetPlaylistEntries()
		{
			return default(bool);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xE56BE4", Offset = "0xE56BE4", VA = "0xE56BE4")]
		public static bool SetPlaylistEntry(int nID, int nPosition, string pchEntryText)
		{
			return default(bool);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xE56D54", Offset = "0xE56D54", VA = "0xE56D54")]
		public static bool SetCurrentPlaylistEntry(int nID)
		{
			return default(bool);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xE56D90", Offset = "0xE56D90", VA = "0xE56D90")]
		public static bool PlaylistDidChange()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000097")]
	public static class SteamNetworking
	{
		[Token(Token = "0x600037E")]
		[Address(RVA = "0xE56DC4", Offset = "0xE56DC4", VA = "0xE56DC4")]
		public static bool SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xE56E24", Offset = "0xE56E24", VA = "0xE56E24")]
		public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xE56E74", Offset = "0xE56E74", VA = "0xE56E74")]
		public static bool ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xE56ED4", Offset = "0xE56ED4", VA = "0xE56ED4")]
		public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xE56F24", Offset = "0xE56F24", VA = "0xE56F24")]
		public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xE56F74", Offset = "0xE56F74", VA = "0xE56F74")]
		public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel)
		{
			return default(bool);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xE56FC8", Offset = "0xE56FC8", VA = "0xE56FC8")]
		public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState)
		{
			return default(bool);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xE5701C", Offset = "0xE5701C", VA = "0xE5701C")]
		public static bool AllowP2PPacketRelay(bool bAllow)
		{
			return default(bool);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xE57058", Offset = "0xE57058", VA = "0xE57058")]
		public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, bool bAllowUseOfPacketRelay)
		{
			return default(SNetListenSocket_t);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xE570B4", Offset = "0xE570B4", VA = "0xE570B4")]
		public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay)
		{
			return default(SNetSocket_t);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xE57114", Offset = "0xE57114", VA = "0xE57114")]
		public static SNetSocket_t CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec)
		{
			return default(SNetSocket_t);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xE57168", Offset = "0xE57168", VA = "0xE57168")]
		public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xE571B8", Offset = "0xE571B8", VA = "0xE571B8")]
		public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xE57208", Offset = "0xE57208", VA = "0xE57208")]
		public static bool SendDataOnSocket(SNetSocket_t hSocket, byte[] pubData, uint cubData, bool bReliable)
		{
			return default(bool);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xE57264", Offset = "0xE57264", VA = "0xE57264")]
		public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xE572B4", Offset = "0xE572B4", VA = "0xE572B4")]
		public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize)
		{
			return default(bool);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xE57310", Offset = "0xE57310", VA = "0xE57310")]
		public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			return default(bool);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xE57364", Offset = "0xE57364", VA = "0xE57364")]
		public static bool RetrieveData(SNetListenSocket_t hListenSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			return default(bool);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xE573C4", Offset = "0xE573C4", VA = "0xE573C4")]
		public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote)
		{
			return default(bool);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xE57424", Offset = "0xE57424", VA = "0xE57424")]
		public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort)
		{
			return default(bool);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xE57478", Offset = "0xE57478", VA = "0xE57478")]
		public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket)
		{
			return default(ESNetSocketConnectionType);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xE574B4", Offset = "0xE574B4", VA = "0xE574B4")]
		public static int GetMaxPacketSize(SNetSocket_t hSocket)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000098")]
	public static class SteamParentalSettings
	{
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x133FB74", Offset = "0x133FB74", VA = "0x133FB74")]
		public static bool BIsParentalLockEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x133FBA8", Offset = "0x133FBA8", VA = "0x133FBA8")]
		public static bool BIsParentalLockLocked()
		{
			return default(bool);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x133FBDC", Offset = "0x133FBDC", VA = "0x133FBDC")]
		public static bool BIsAppBlocked(AppId_t nAppID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x133FC18", Offset = "0x133FC18", VA = "0x133FC18")]
		public static bool BIsAppInBlockList(AppId_t nAppID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x133FC54", Offset = "0x133FC54", VA = "0x133FC54")]
		public static bool BIsFeatureBlocked(EParentalFeature eFeature)
		{
			return default(bool);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x133FC90", Offset = "0x133FC90", VA = "0x133FC90")]
		public static bool BIsFeatureInBlockList(EParentalFeature eFeature)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000099")]
	public static class SteamRemoteStorage
	{
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x133FCCC", Offset = "0x133FCCC", VA = "0x133FCCC")]
		public static bool FileWrite(string pchFile, byte[] pvData, int cubData)
		{
			return default(bool);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x133FE3C", Offset = "0x133FE3C", VA = "0x133FE3C")]
		public static int FileRead(string pchFile, byte[] pvData, int cubDataToRead)
		{
			return default(int);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x133FFAC", Offset = "0x133FFAC", VA = "0x133FFAC")]
		public static SteamAPICall_t FileWriteAsync(string pchFile, byte[] pvData, uint cubData)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1340184", Offset = "0x1340184", VA = "0x1340184")]
		public static SteamAPICall_t FileReadAsync(string pchFile, uint nOffset, uint cubToRead)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x134035C", Offset = "0x134035C", VA = "0x134035C")]
		public static bool FileReadAsyncComplete(SteamAPICall_t hReadCall, byte[] pvBuffer, uint cubToRead)
		{
			return default(bool);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x13403B4", Offset = "0x13403B4", VA = "0x13403B4")]
		public static bool FileForget(string pchFile)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1340518", Offset = "0x1340518", VA = "0x1340518")]
		public static bool FileDelete(string pchFile)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x134067C", Offset = "0x134067C", VA = "0x134067C")]
		public static SteamAPICall_t FileShare(string pchFile)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1340844", Offset = "0x1340844", VA = "0x1340844")]
		public static bool SetSyncPlatforms(string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x13409B0", Offset = "0x13409B0", VA = "0x13409B0")]
		public static UGCFileWriteStreamHandle_t FileWriteStreamOpen(string pchFile)
		{
			return default(UGCFileWriteStreamHandle_t);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1340B70", Offset = "0x1340B70", VA = "0x1340B70")]
		public static bool FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, byte[] pvData, int cubData)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1340BC8", Offset = "0x1340BC8", VA = "0x1340BC8")]
		public static bool FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1340C18", Offset = "0x1340C18", VA = "0x1340C18")]
		public static bool FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1340C68", Offset = "0x1340C68", VA = "0x1340C68")]
		public static bool FileExists(string pchFile)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1340DCC", Offset = "0x1340DCC", VA = "0x1340DCC")]
		public static bool FilePersisted(string pchFile)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1340F30", Offset = "0x1340F30", VA = "0x1340F30")]
		public static int GetFileSize(string pchFile)
		{
			return default(int);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1341094", Offset = "0x1341094", VA = "0x1341094")]
		public static long GetFileTimestamp(string pchFile)
		{
			return default(long);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x134120C", Offset = "0x134120C", VA = "0x134120C")]
		public static ERemoteStoragePlatform GetSyncPlatforms(string pchFile)
		{
			return default(ERemoteStoragePlatform);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1341370", Offset = "0x1341370", VA = "0x1341370")]
		public static int GetFileCount()
		{
			return default(int);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x13413A4", Offset = "0x13413A4", VA = "0x13413A4")]
		public static string GetFileNameAndSize(int iFile, out int pnFileSizeInBytes)
		{
			return null;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1341404", Offset = "0x1341404", VA = "0x1341404")]
		public static bool GetQuota(out ulong pnTotalBytes, out ulong puAvailableBytes)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x1341454", Offset = "0x1341454", VA = "0x1341454")]
		public static bool IsCloudEnabledForAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1341488", Offset = "0x1341488", VA = "0x1341488")]
		public static bool IsCloudEnabledForApp()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x13414BC", Offset = "0x13414BC", VA = "0x13414BC")]
		public static void SetCloudEnabledForApp(bool bEnabled)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x13414F8", Offset = "0x13414F8", VA = "0x13414F8")]
		public static SteamAPICall_t UGCDownload(UGCHandle_t hContent, uint unPriority)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x13415DC", Offset = "0x13415DC", VA = "0x13415DC")]
		public static bool GetUGCDownloadProgress(UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x1341634", Offset = "0x1341634", VA = "0x1341634")]
		public static bool GetUGCDetails(UGCHandle_t hContent, out AppId_t pnAppID, out string ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x13416CC", Offset = "0x13416CC", VA = "0x13416CC")]
		public static int UGCRead(UGCHandle_t hContent, byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction)
		{
			return default(int);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x134172C", Offset = "0x134172C", VA = "0x134172C")]
		public static int GetCachedUGCCount()
		{
			return default(int);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x1341760", Offset = "0x1341760", VA = "0x1341760")]
		public static UGCHandle_t GetCachedUGCHandle(int iCachedContent)
		{
			return default(UGCHandle_t);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x1341824", Offset = "0x1341824", VA = "0x1341824")]
		public static SteamAPICall_t PublishWorkshopFile(string pchFile, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags, EWorkshopFileType eWorkshopFileType)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1341DEC", Offset = "0x1341DEC", VA = "0x1341DEC")]
		public static PublishedFileUpdateHandle_t CreatePublishedFileUpdateRequest(PublishedFileId_t unPublishedFileId)
		{
			return default(PublishedFileUpdateHandle_t);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1341EC8", Offset = "0x1341EC8", VA = "0x1341EC8")]
		public static bool UpdatePublishedFileFile(PublishedFileUpdateHandle_t updateHandle, string pchFile)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x1342038", Offset = "0x1342038", VA = "0x1342038")]
		public static bool UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle_t updateHandle, string pchPreviewFile)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x13421A8", Offset = "0x13421A8", VA = "0x13421A8")]
		public static bool UpdatePublishedFileTitle(PublishedFileUpdateHandle_t updateHandle, string pchTitle)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x1342318", Offset = "0x1342318", VA = "0x1342318")]
		public static bool UpdatePublishedFileDescription(PublishedFileUpdateHandle_t updateHandle, string pchDescription)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x1342488", Offset = "0x1342488", VA = "0x1342488")]
		public static bool UpdatePublishedFileVisibility(PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x13424DC", Offset = "0x13424DC", VA = "0x13424DC")]
		public static bool UpdatePublishedFileTags(PublishedFileUpdateHandle_t updateHandle, IList<string> pTags)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x13425A4", Offset = "0x13425A4", VA = "0x13425A4")]
		public static SteamAPICall_t CommitPublishedFileUpdate(PublishedFileUpdateHandle_t updateHandle)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x1342680", Offset = "0x1342680", VA = "0x1342680")]
		public static SteamAPICall_t GetPublishedFileDetails(PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1342764", Offset = "0x1342764", VA = "0x1342764")]
		public static SteamAPICall_t DeletePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1342840", Offset = "0x1342840", VA = "0x1342840")]
		public static SteamAPICall_t EnumerateUserPublishedFiles(uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1342914", Offset = "0x1342914", VA = "0x1342914")]
		public static SteamAPICall_t SubscribePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x13429F0", Offset = "0x13429F0", VA = "0x13429F0")]
		public static SteamAPICall_t EnumerateUserSubscribedFiles(uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x1342AC4", Offset = "0x1342AC4", VA = "0x1342AC4")]
		public static SteamAPICall_t UnsubscribePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1342BA0", Offset = "0x1342BA0", VA = "0x1342BA0")]
		public static bool UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle_t updateHandle, string pchChangeDescription)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1342D10", Offset = "0x1342D10", VA = "0x1342D10")]
		public static SteamAPICall_t GetPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1342DEC", Offset = "0x1342DEC", VA = "0x1342DEC")]
		public static SteamAPICall_t UpdateUserPublishedItemVote(PublishedFileId_t unPublishedFileId, bool bVoteUp)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1342ED0", Offset = "0x1342ED0", VA = "0x1342ED0")]
		public static SteamAPICall_t GetUserPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1342FAC", Offset = "0x1342FAC", VA = "0x1342FAC")]
		public static SteamAPICall_t EnumerateUserSharedWorkshopFiles(CSteamID steamId, uint unStartIndex, IList<string> pRequiredTags, IList<string> pExcludedTags)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x13430FC", Offset = "0x13430FC", VA = "0x13430FC")]
		public static SteamAPICall_t PublishVideo(EWorkshopVideoProvider eVideoProvider, string pchVideoAccount, string pchVideoIdentifier, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x13437D8", Offset = "0x13437D8", VA = "0x13437D8")]
		public static SteamAPICall_t SetUserPublishedFileAction(PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x13438BC", Offset = "0x13438BC", VA = "0x13438BC")]
		public static SteamAPICall_t EnumeratePublishedFilesByUserAction(EWorkshopFileAction eAction, uint unStartIndex)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1343998", Offset = "0x1343998", VA = "0x1343998")]
		public static SteamAPICall_t EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IList<string> pTags, IList<string> pUserTags)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1343AF0", Offset = "0x1343AF0", VA = "0x1343AF0")]
		public static SteamAPICall_t UGCDownloadToLocation(UGCHandle_t hContent, string pchLocation, uint unPriority)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x200009A")]
	public static class SteamScreenshots
	{
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1343CD0", Offset = "0x1343CD0", VA = "0x1343CD0")]
		public static ScreenshotHandle WriteScreenshot(byte[] pubRGB, uint cubRGB, int nWidth, int nHeight)
		{
			return default(ScreenshotHandle);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1343DA4", Offset = "0x1343DA4", VA = "0x1343DA4")]
		public static ScreenshotHandle AddScreenshotToLibrary(string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight)
		{
			return default(ScreenshotHandle);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1344064", Offset = "0x1344064", VA = "0x1344064")]
		public static void TriggerScreenshot()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1344098", Offset = "0x1344098", VA = "0x1344098")]
		public static void HookScreenshots(bool bHook)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x13440D4", Offset = "0x13440D4", VA = "0x13440D4")]
		public static bool SetLocation(ScreenshotHandle hScreenshot, string pchLocation)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1344240", Offset = "0x1344240", VA = "0x1344240")]
		public static bool TagUser(ScreenshotHandle hScreenshot, CSteamID steamID)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1344294", Offset = "0x1344294", VA = "0x1344294")]
		public static bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x13442E8", Offset = "0x13442E8", VA = "0x13442E8")]
		public static bool IsScreenshotsHooked()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x134431C", Offset = "0x134431C", VA = "0x134431C")]
		public static ScreenshotHandle AddVRScreenshotToLibrary(EVRScreenshotType eType, string pchFilename, string pchVRFilename)
		{
			return default(ScreenshotHandle);
		}
	}
	[Token(Token = "0x200009B")]
	public static class SteamUGC
	{
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x13445D8", Offset = "0x13445D8", VA = "0x13445D8")]
		public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x13446D4", Offset = "0x13446D4", VA = "0x13446D4")]
		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x13447B4", Offset = "0x13447B4", VA = "0x13447B4")]
		public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x134487C", Offset = "0x134487C", VA = "0x134487C")]
		public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1344958", Offset = "0x1344958", VA = "0x1344958")]
		public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x13449B0", Offset = "0x13449B0", VA = "0x13449B0")]
		public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1344AF8", Offset = "0x1344AF8", VA = "0x1344AF8")]
		public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1344C40", Offset = "0x1344C40", VA = "0x1344C40")]
		public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1344C98", Offset = "0x1344C98", VA = "0x1344C98")]
		public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1344CF0", Offset = "0x1344CF0", VA = "0x1344CF0")]
		public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index)
		{
			return default(uint);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1344D44", Offset = "0x1344D44", VA = "0x1344D44")]
		public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out string pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1344F1C", Offset = "0x1344F1C", VA = "0x1344F1C")]
		public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index)
		{
			return default(uint);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1344F70", Offset = "0x1344F70", VA = "0x1344F70")]
		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x134513C", Offset = "0x134513C", VA = "0x134513C")]
		public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x134518C", Offset = "0x134518C", VA = "0x134518C")]
		public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x13452FC", Offset = "0x13452FC", VA = "0x13452FC")]
		public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x134546C", Offset = "0x134546C", VA = "0x134546C")]
		public static bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x13454C0", Offset = "0x13454C0", VA = "0x13454C0")]
		public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1345514", Offset = "0x1345514", VA = "0x1345514")]
		public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription)
		{
			return default(bool);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1345568", Offset = "0x1345568", VA = "0x1345568")]
		public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x13455BC", Offset = "0x13455BC", VA = "0x13455BC")]
		public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1345610", Offset = "0x1345610", VA = "0x1345610")]
		public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1345664", Offset = "0x1345664", VA = "0x1345664")]
		public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x13456B8", Offset = "0x13456B8", VA = "0x13456B8")]
		public static bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x134570C", Offset = "0x134570C", VA = "0x134570C")]
		public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x134587C", Offset = "0x134587C", VA = "0x134587C")]
		public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x13458D0", Offset = "0x13458D0", VA = "0x13458D0")]
		public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1345A40", Offset = "0x1345A40", VA = "0x1345A40")]
		public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1345A94", Offset = "0x1345A94", VA = "0x1345A94")]
		public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1345C04", Offset = "0x1345C04", VA = "0x1345C04")]
		public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1345C58", Offset = "0x1345C58", VA = "0x1345C58")]
		public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1345F00", Offset = "0x1345F00", VA = "0x1345F00")]
		public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1345FE4", Offset = "0x1345FE4", VA = "0x1345FE4")]
		public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x13460C0", Offset = "0x13460C0", VA = "0x13460C0")]
		public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(UGCUpdateHandle_t);
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x134619C", Offset = "0x134619C", VA = "0x134619C")]
		public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x134630C", Offset = "0x134630C", VA = "0x134630C")]
		public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x134647C", Offset = "0x134647C", VA = "0x134647C")]
		public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x13465EC", Offset = "0x13465EC", VA = "0x13465EC")]
		public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x134675C", Offset = "0x134675C", VA = "0x134675C")]
		public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			return default(bool);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x13467B0", Offset = "0x13467B0", VA = "0x13467B0")]
		public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<string> pTags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1346878", Offset = "0x1346878", VA = "0x1346878")]
		public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder)
		{
			return default(bool);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x13469E8", Offset = "0x13469E8", VA = "0x13469E8")]
		public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile)
		{
			return default(bool);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1346B58", Offset = "0x1346B58", VA = "0x1346B58")]
		public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1346CC8", Offset = "0x1346CC8", VA = "0x1346CC8")]
		public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1346F70", Offset = "0x1346F70", VA = "0x1346F70")]
		public static bool AddItemPreviewFile(UGCUpdateHandle_t handle, string pszPreviewFile, EItemPreviewType type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x13470E8", Offset = "0x13470E8", VA = "0x13470E8")]
		public static bool AddItemPreviewVideo(UGCUpdateHandle_t handle, string pszVideoID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1347258", Offset = "0x1347258", VA = "0x1347258")]
		public static bool UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, string pszPreviewFile)
		{
			return default(bool);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x13473CC", Offset = "0x13473CC", VA = "0x13473CC")]
		public static bool UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, string pszVideoID)
		{
			return default(bool);
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1347540", Offset = "0x1347540", VA = "0x1347540")]
		public static bool RemoveItemPreview(UGCUpdateHandle_t handle, uint index)
		{
			return default(bool);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1347594", Offset = "0x1347594", VA = "0x1347594")]
		public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x134776C", Offset = "0x134776C", VA = "0x134776C")]
		public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal)
		{
			return default(EItemUpdateStatus);
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x13477C4", Offset = "0x13477C4", VA = "0x13477C4")]
		public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x13478A8", Offset = "0x13478A8", VA = "0x13478A8")]
		public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1347984", Offset = "0x1347984", VA = "0x1347984")]
		public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1347A64", Offset = "0x1347A64", VA = "0x1347A64")]
		public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1347B44", Offset = "0x1347B44", VA = "0x1347B44")]
		public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1347C20", Offset = "0x1347C20", VA = "0x1347C20")]
		public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1347CFC", Offset = "0x1347CFC", VA = "0x1347CFC")]
		public static uint GetNumSubscribedItems()
		{
			return default(uint);
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1347D30", Offset = "0x1347D30", VA = "0x1347D30")]
		public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			return default(uint);
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1347D80", Offset = "0x1347D80", VA = "0x1347D80")]
		public static uint GetItemState(PublishedFileId_t nPublishedFileID)
		{
			return default(uint);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1347DD0", Offset = "0x1347DD0", VA = "0x1347DD0")]
		public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1347F20", Offset = "0x1347F20", VA = "0x1347F20")]
		public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			return default(bool);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1347F78", Offset = "0x1347F78", VA = "0x1347F78")]
		public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority)
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1347FCC", Offset = "0x1347FCC", VA = "0x1347FCC")]
		public static bool BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, string pszFolder)
		{
			return default(bool);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1348138", Offset = "0x1348138", VA = "0x1348138")]
		public static void SuspendDownloads(bool bSuspend)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1348174", Offset = "0x1348174", VA = "0x1348174")]
		public static SteamAPICall_t StartPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1348250", Offset = "0x1348250", VA = "0x1348250")]
		public static SteamAPICall_t StopPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x134832C", Offset = "0x134832C", VA = "0x134832C")]
		public static SteamAPICall_t StopPlaytimeTrackingForAllItems()
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x13483F8", Offset = "0x13483F8", VA = "0x13483F8")]
		public static SteamAPICall_t AddDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x13484E4", Offset = "0x13484E4", VA = "0x13484E4")]
		public static SteamAPICall_t RemoveDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x13485D0", Offset = "0x13485D0", VA = "0x13485D0")]
		public static SteamAPICall_t AddAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x13486B4", Offset = "0x13486B4", VA = "0x13486B4")]
		public static SteamAPICall_t RemoveAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1348798", Offset = "0x1348798", VA = "0x1348798")]
		public static SteamAPICall_t GetAppDependencies(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1348874", Offset = "0x1348874", VA = "0x1348874")]
		public static SteamAPICall_t DeleteItem(PublishedFileId_t nPublishedFileID)
		{
			return default(SteamAPICall_t);
		}
	}
	[Token(Token = "0x200009C")]
	public static class SteamUnifiedMessages
	{
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1348CF8", Offset = "0x1348CF8", VA = "0x1348CF8")]
		public static ClientUnifiedMessageHandle SendMethod(string pchServiceMethod, byte[] pRequestBuffer, uint unRequestBufferSize, ulong unContext)
		{
			return default(ClientUnifiedMessageHandle);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1348EE4", Offset = "0x1348EE4", VA = "0x1348EE4")]
		public static bool GetMethodResponseInfo(ClientUnifiedMessageHandle hHandle, out uint punResponseSize, out EResult peResult)
		{
			return default(bool);
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1348F3C", Offset = "0x1348F3C", VA = "0x1348F3C")]
		public static bool GetMethodResponseData(ClientUnifiedMessageHandle hHandle, byte[] pResponseBuffer, uint unResponseBufferSize, bool bAutoRelease)
		{
			return default(bool);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1348F94", Offset = "0x1348F94", VA = "0x1348F94")]
		public static bool ReleaseMethod(ClientUnifiedMessageHandle hHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1348FE4", Offset = "0x1348FE4", VA = "0x1348FE4")]
		public static bool SendNotification(string pchServiceNotification, byte[] pNotificationBuffer, uint unNotificationBufferSize)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200009D")]
	public static class SteamUser
	{
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1349154", Offset = "0x1349154", VA = "0x1349154")]
		public static HSteamUser GetHSteamUser()
		{
			return default(HSteamUser);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1349198", Offset = "0x1349198", VA = "0x1349198")]
		public static bool BLoggedOn()
		{
			return default(bool);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x13491CC", Offset = "0x13491CC", VA = "0x13491CC")]
		public static CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1349298", Offset = "0x1349298", VA = "0x1349298")]
		public static int InitiateGameConnection(byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure)
		{
			return default(int);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1349304", Offset = "0x1349304", VA = "0x1349304")]
		public static void TerminateGameConnection(uint unIPServer, ushort usPortServer)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1349354", Offset = "0x1349354", VA = "0x1349354")]
		public static void TrackAppUsageEvent(CGameID gameID, int eAppUsageEvent, string pchExtraInfo = "")
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x13494C8", Offset = "0x13494C8", VA = "0x13494C8")]
		public static bool GetUserDataFolder(out string pchBuffer, int cubBuffer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x13495F8", Offset = "0x13495F8", VA = "0x13495F8")]
		public static void StartVoiceRecording()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x134962C", Offset = "0x134962C", VA = "0x134962C")]
		public static void StopVoiceRecording()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1349660", Offset = "0x1349660", VA = "0x1349660")]
		public static EVoiceResult GetAvailableVoice(out uint pcbCompressed)
		{
			return default(EVoiceResult);
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x13496EC", Offset = "0x13496EC", VA = "0x13496EC")]
		public static EVoiceResult GetVoice(bool bWantCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten)
		{
			return default(EVoiceResult);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1349798", Offset = "0x1349798", VA = "0x1349798")]
		public static EVoiceResult DecompressVoice(byte[] pCompressed, uint cbCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate)
		{
			return default(EVoiceResult);
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x13497F8", Offset = "0x13497F8", VA = "0x13497F8")]
		public static uint GetVoiceOptimalSampleRate()
		{
			return default(uint);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x134982C", Offset = "0x134982C", VA = "0x134982C")]
		public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			return default(HAuthTicket);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x13498FC", Offset = "0x13498FC", VA = "0x13498FC")]
		public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID)
		{
			return default(EBeginAuthSessionResult);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1349958", Offset = "0x1349958", VA = "0x1349958")]
		public static void EndAuthSession(CSteamID steamID)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x13499A8", Offset = "0x13499A8", VA = "0x13499A8")]
		public static void CancelAuthTicket(HAuthTicket hAuthTicket)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x13499E4", Offset = "0x13499E4", VA = "0x13499E4")]
		public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID)
		{
			return default(EUserHasLicenseForAppResult);
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1349A38", Offset = "0x1349A38", VA = "0x1349A38")]
		public static bool BIsBehindNAT()
		{
			return default(bool);
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1349A6C", Offset = "0x1349A6C", VA = "0x1349A6C")]
		public static void AdvertiseGame(CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1349AC8", Offset = "0x1349AC8", VA = "0x1349AC8")]
		public static SteamAPICall_t RequestEncryptedAppTicket(byte[] pDataToInclude, int cbDataToInclude)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1349BA4", Offset = "0x1349BA4", VA = "0x1349BA4")]
		public static bool GetEncryptedAppTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			return default(bool);
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1349BF8", Offset = "0x1349BF8", VA = "0x1349BF8")]
		public static int GetGameBadgeLevel(int nSeries, bool bFoil)
		{
			return default(int);
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1349C48", Offset = "0x1349C48", VA = "0x1349C48")]
		public static int GetPlayerSteamLevel()
		{
			return default(int);
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1349C7C", Offset = "0x1349C7C", VA = "0x1349C7C")]
		public static SteamAPICall_t RequestStoreAuthURL(string pchRedirectURL)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x1349E44", Offset = "0x1349E44", VA = "0x1349E44")]
		public static bool BIsPhoneVerified()
		{
			return default(bool);
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x1349E78", Offset = "0x1349E78", VA = "0x1349E78")]
		public static bool BIsTwoFactorEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x1349EAC", Offset = "0x1349EAC", VA = "0x1349EAC")]
		public static bool BIsPhoneIdentifying()
		{
			return default(bool);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1349EE0", Offset = "0x1349EE0", VA = "0x1349EE0")]
		public static bool BIsPhoneRequiringVerification()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200009E")]
	public static class SteamUserStats
	{
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x1349F14", Offset = "0x1349F14", VA = "0x1349F14")]
		public static bool RequestCurrentStats()
		{
			return default(bool);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1349F48", Offset = "0x1349F48", VA = "0x1349F48")]
		public static bool GetStat(string pchName, out int pData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x134A0B4", Offset = "0x134A0B4", VA = "0x134A0B4")]
		public static bool GetStat(string pchName, out float pData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x134A220", Offset = "0x134A220", VA = "0x134A220")]
		public static bool SetStat(string pchName, int nData)
		{
			return default(bool);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x134A38C", Offset = "0x134A38C", VA = "0x134A38C")]
		public static bool SetStat(string pchName, float fData)
		{
			return default(bool);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x134A4F8", Offset = "0x134A4F8", VA = "0x134A4F8")]
		public static bool UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength)
		{
			return default(bool);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x134A66C", Offset = "0x134A66C", VA = "0x134A66C")]
		public static bool GetAchievement(string pchName, out bool pbAchieved)
		{
			return default(bool);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x134A7D8", Offset = "0x134A7D8", VA = "0x134A7D8")]
		public static bool SetAchievement(string pchName)
		{
			return default(bool);
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x134A93C", Offset = "0x134A93C", VA = "0x134A93C")]
		public static bool ClearAchievement(string pchName)
		{
			return default(bool);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x134AAA0", Offset = "0x134AAA0", VA = "0x134AAA0")]
		public static bool GetAchievementAndUnlockTime(string pchName, out bool pbAchieved, out uint punUnlockTime)
		{
			return default(bool);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x134AC10", Offset = "0x134AC10", VA = "0x134AC10")]
		public static bool StoreStats()
		{
			return default(bool);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x134AC44", Offset = "0x134AC44", VA = "0x134AC44")]
		public static int GetAchievementIcon(string pchName)
		{
			return default(int);
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x134ADA8", Offset = "0x134ADA8", VA = "0x134ADA8")]
		public static string GetAchievementDisplayAttribute(string pchName, string pchKey)
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x134B02C", Offset = "0x134B02C", VA = "0x134B02C")]
		public static bool IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress)
		{
			return default(bool);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x134B19C", Offset = "0x134B19C", VA = "0x134B19C")]
		public static uint GetNumAchievements()
		{
			return default(uint);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x134B1D0", Offset = "0x134B1D0", VA = "0x134B1D0")]
		public static string GetAchievementName(uint iAchievement)
		{
			return null;
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x134B21C", Offset = "0x134B21C", VA = "0x134B21C")]
		public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x134B2F8", Offset = "0x134B2F8", VA = "0x134B2F8")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x134B470", Offset = "0x134B470", VA = "0x134B470")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x134B5E8", Offset = "0x134B5E8", VA = "0x134B5E8")]
		public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved)
		{
			return default(bool);
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x134B760", Offset = "0x134B760", VA = "0x134B760")]
		public static bool GetUserAchievementAndUnlockTime(CSteamID steamIDUser, string pchName, out bool pbAchieved, out uint punUnlockTime)
		{
			return default(bool);
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x134B8E4", Offset = "0x134B8E4", VA = "0x134B8E4")]
		public static bool ResetAllStats(bool bAchievementsToo)
		{
			return default(bool);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x134B920", Offset = "0x134B920", VA = "0x134B920")]
		public static SteamAPICall_t FindOrCreateLeaderboard(string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x134BAF8", Offset = "0x134BAF8", VA = "0x134BAF8")]
		public static SteamAPICall_t FindLeaderboard(string pchLeaderboardName)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x134BCC0", Offset = "0x134BCC0", VA = "0x134BCC0")]
		public static string GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard)
		{
			return null;
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x134BD20", Offset = "0x134BD20", VA = "0x134BD20")]
		public static int GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard)
		{
			return default(int);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x134BD70", Offset = "0x134BD70", VA = "0x134BD70")]
		public static ELeaderboardSortMethod GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard)
		{
			return default(ELeaderboardSortMethod);
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x134BDC0", Offset = "0x134BDC0", VA = "0x134BDC0")]
		public static ELeaderboardDisplayType GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard)
		{
			return default(ELeaderboardDisplayType);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x134BE10", Offset = "0x134BE10", VA = "0x134BE10")]
		public static SteamAPICall_t DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x134BF04", Offset = "0x134BF04", VA = "0x134BF04")]
		public static SteamAPICall_t DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, CSteamID[] prgUsers, int cUsers)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x134BFF0", Offset = "0x134BFF0", VA = "0x134BFF0")]
		public static bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, int[] pDetails, int cDetailsMax)
		{
			return default(bool);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x134C050", Offset = "0x134C050", VA = "0x134C050")]
		public static SteamAPICall_t UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, int[] pScoreDetails, int cScoreDetailsCount)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x134C148", Offset = "0x134C148", VA = "0x134C148")]
		public static SteamAPICall_t AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x134C234", Offset = "0x134C234", VA = "0x134C234")]
		public static SteamAPICall_t GetNumberOfCurrentPlayers()
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x134C300", Offset = "0x134C300", VA = "0x134C300")]
		public static SteamAPICall_t RequestGlobalAchievementPercentages()
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x134C3CC", Offset = "0x134C3CC", VA = "0x134C3CC")]
		public static int GetMostAchievedAchievementInfo(out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
		{
			return default(int);
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x134C508", Offset = "0x134C508", VA = "0x134C508")]
		public static int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
		{
			return default(int);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x134C64C", Offset = "0x134C64C", VA = "0x134C64C")]
		public static bool GetAchievementAchievedPercent(string pchName, out float pflPercent)
		{
			return default(bool);
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x134C7B8", Offset = "0x134C7B8", VA = "0x134C7B8")]
		public static SteamAPICall_t RequestGlobalStats(int nHistoryDays)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x134C88C", Offset = "0x134C88C", VA = "0x134C88C")]
		public static bool GetGlobalStat(string pchStatName, out long pData)
		{
			return default(bool);
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x134C9F8", Offset = "0x134C9F8", VA = "0x134C9F8")]
		public static bool GetGlobalStat(string pchStatName, out double pData)
		{
			return default(bool);
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x134CB64", Offset = "0x134CB64", VA = "0x134CB64")]
		public static int GetGlobalStatHistory(string pchStatName, long[] pData, uint cubData)
		{
			return default(int);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x134CCD4", Offset = "0x134CCD4", VA = "0x134CCD4")]
		public static int GetGlobalStatHistory(string pchStatName, double[] pData, uint cubData)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200009F")]
	public static class SteamUtils
	{
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x134CE44", Offset = "0x134CE44", VA = "0x134CE44")]
		public static uint GetSecondsSinceAppActive()
		{
			return default(uint);
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x134CE78", Offset = "0x134CE78", VA = "0x134CE78")]
		public static uint GetSecondsSinceComputerActive()
		{
			return default(uint);
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x134CEAC", Offset = "0x134CEAC", VA = "0x134CEAC")]
		public static EUniverse GetConnectedUniverse()
		{
			return default(EUniverse);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x134CEE0", Offset = "0x134CEE0", VA = "0x134CEE0")]
		public static uint GetServerRealTime()
		{
			return default(uint);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x134CF14", Offset = "0x134CF14", VA = "0x134CF14")]
		public static string GetIPCountry()
		{
			return null;
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x134CF58", Offset = "0x134CF58", VA = "0x134CF58")]
		public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight)
		{
			return default(bool);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x134CFAC", Offset = "0x134CFAC", VA = "0x134CFAC")]
		public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x134D000", Offset = "0x134D000", VA = "0x134D000")]
		public static bool GetCSERIPPort(out uint unIP, out ushort usPort)
		{
			return default(bool);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x134D050", Offset = "0x134D050", VA = "0x134D050")]
		public static byte GetCurrentBatteryPower()
		{
			return default(byte);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x134D084", Offset = "0x134D084", VA = "0x134D084")]
		public static AppId_t GetAppID()
		{
			return default(AppId_t);
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x134D134", Offset = "0x134D134", VA = "0x134D134")]
		public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x134D170", Offset = "0x134D170", VA = "0x134D170")]
		public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed)
		{
			return default(bool);
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x134D1C4", Offset = "0x134D1C4", VA = "0x134D1C4")]
		public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
		{
			return default(ESteamAPICallFailure);
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x134D214", Offset = "0x134D214", VA = "0x134D214")]
		public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed)
		{
			return default(bool);
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x134D274", Offset = "0x134D274", VA = "0x134D274")]
		public static uint GetIPCCallCount()
		{
			return default(uint);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x134D2A8", Offset = "0x134D2A8", VA = "0x134D2A8")]
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x134D2E4", Offset = "0x134D2E4", VA = "0x134D2E4")]
		public static bool IsOverlayEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x134D318", Offset = "0x134D318", VA = "0x134D318")]
		public static bool BOverlayNeedsPresent()
		{
			return default(bool);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x134D34C", Offset = "0x134D34C", VA = "0x134D34C")]
		public static SteamAPICall_t CheckFileSignature(string szFileName)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x134D514", Offset = "0x134D514", VA = "0x134D514")]
		public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
		{
			return default(bool);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x134D7C4", Offset = "0x134D7C4", VA = "0x134D7C4")]
		public static uint GetEnteredGamepadTextLength()
		{
			return default(uint);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x134D7F8", Offset = "0x134D7F8", VA = "0x134D7F8")]
		public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText)
		{
			return default(bool);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x134D928", Offset = "0x134D928", VA = "0x134D928")]
		public static string GetSteamUILanguage()
		{
			return null;
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x134D96C", Offset = "0x134D96C", VA = "0x134D96C")]
		public static bool IsSteamRunningInVR()
		{
			return default(bool);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x134D9A0", Offset = "0x134D9A0", VA = "0x134D9A0")]
		public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x134D9F0", Offset = "0x134D9F0", VA = "0x134D9F0")]
		public static bool IsSteamInBigPictureMode()
		{
			return default(bool);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x134DA24", Offset = "0x134DA24", VA = "0x134DA24")]
		public static void StartVRDashboard()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x134DA58", Offset = "0x134DA58", VA = "0x134DA58")]
		public static bool IsVRHeadsetStreamingEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x134DA8C", Offset = "0x134DA8C", VA = "0x134DA8C")]
		public static void SetVRHeadsetStreamingEnabled(bool bEnabled)
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public static class SteamVideo
	{
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x134DAC8", Offset = "0x134DAC8", VA = "0x134DAC8")]
		public static void GetVideoURL(AppId_t unVideoAppID)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x134DB04", Offset = "0x134DB04", VA = "0x134DB04")]
		public static bool IsBroadcasting(out int pnNumViewers)
		{
			return default(bool);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x134DB40", Offset = "0x134DB40", VA = "0x134DB40")]
		public static void GetOPFSettings(AppId_t unVideoAppID)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x134DB7C", Offset = "0x134DB7C", VA = "0x134DB7C")]
		public static bool GetOPFStringForApp(AppId_t unVideoAppID, out string pchBuffer, ref int pnBufferSize)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000A1")]
	[SuppressUnmanagedCodeSecurity]
	internal static class NativeMethods
	{
		[Token(Token = "0x4000085")]
		internal const string NativeLibraryName = "steam_api";

		[Token(Token = "0x4000086")]
		internal const string NativeLibrary_SDKEncryptedAppTicket = "sdkencryptedappticket";

		[PreserveSig]
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x38300C", Offset = "0x38300C", VA = "0x38300C")]
		public static extern bool SteamAPI_Init();

		[PreserveSig]
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x3830C8", Offset = "0x3830C8", VA = "0x3830C8")]
		public static extern void SteamAPI_Shutdown();

		[PreserveSig]
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x383178", Offset = "0x383178", VA = "0x383178")]
		public static extern bool SteamAPI_RestartAppIfNecessary(AppId_t unOwnAppID);

		[PreserveSig]
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x383244", Offset = "0x383244", VA = "0x383244")]
		public static extern void SteamAPI_ReleaseCurrentThreadMemory();

		[PreserveSig]
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x3832F4", Offset = "0x3832F4", VA = "0x3832F4")]
		public static extern void SteamAPI_WriteMiniDump(uint uStructuredExceptionCode, IntPtr pvExceptionInfo, uint uBuildID);

		[PreserveSig]
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x3833C4", Offset = "0x3833C4", VA = "0x3833C4")]
		public static extern void SteamAPI_SetMiniDumpComment(InteropHelp.UTF8StringHandle pchMsg);

		[PreserveSig]
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x3833EC", Offset = "0x3833EC", VA = "0x3833EC")]
		public static extern void SteamAPI_RunCallbacks();

		[PreserveSig]
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x38349C", Offset = "0x38349C", VA = "0x38349C")]
		public static extern void SteamAPI_RegisterCallback(IntPtr pCallback, int iCallback);

		[PreserveSig]
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x383564", Offset = "0x383564", VA = "0x383564")]
		public static extern void SteamAPI_UnregisterCallback(IntPtr pCallback);

		[PreserveSig]
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x383624", Offset = "0x383624", VA = "0x383624")]
		public static extern void SteamAPI_RegisterCallResult(IntPtr pCallback, ulong hAPICall);

		[PreserveSig]
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x3836F4", Offset = "0x3836F4", VA = "0x3836F4")]
		public static extern void SteamAPI_UnregisterCallResult(IntPtr pCallback, ulong hAPICall);

		[PreserveSig]
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x3837C4", Offset = "0x3837C4", VA = "0x3837C4")]
		public static extern bool SteamAPI_IsSteamRunning();

		[PreserveSig]
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x383880", Offset = "0x383880", VA = "0x383880")]
		public static extern void Steam_RunCallbacks(HSteamPipe hSteamPipe, bool bGameServerCallbacks);

		[PreserveSig]
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x383948", Offset = "0x383948", VA = "0x383948")]
		public static extern void Steam_RegisterInterfaceFuncs(IntPtr hModule);

		[PreserveSig]
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x383A08", Offset = "0x383A08", VA = "0x383A08")]
		public static extern int Steam_GetHSteamUserCurrent();

		[PreserveSig]
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x383AB8", Offset = "0x383AB8", VA = "0x383AB8")]
		public static extern int SteamAPI_GetSteamInstallPath();

		[PreserveSig]
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x383B68", Offset = "0x383B68", VA = "0x383B68")]
		public static extern int SteamAPI_GetHSteamPipe();

		[PreserveSig]
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x383C18", Offset = "0x383C18", VA = "0x383C18")]
		public static extern void SteamAPI_SetTryCatchCallbacks(bool bTryCatchCallbacks);

		[PreserveSig]
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x383CD8", Offset = "0x383CD8", VA = "0x383CD8")]
		public static extern int SteamAPI_GetHSteamUser();

		[PreserveSig]
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x383D88", Offset = "0x383D88", VA = "0x383D88")]
		public static extern IntPtr SteamInternal_ContextInit(IntPtr pContextInitData);

		[PreserveSig]
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x376FA8", Offset = "0x376FA8", VA = "0x376FA8")]
		public static extern IntPtr SteamInternal_CreateInterface(InteropHelp.UTF8StringHandle ver);

		[PreserveSig]
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x383E48", Offset = "0x383E48", VA = "0x383E48")]
		public static extern void SteamAPI_UseBreakpadCrashHandler(InteropHelp.UTF8StringHandle pchVersion, InteropHelp.UTF8StringHandle pchDate, InteropHelp.UTF8StringHandle pchTime, bool bFullMemoryDumps, IntPtr pvContext, IntPtr m_pfnPreMinidumpCallback);

		[PreserveSig]
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x383E70", Offset = "0x383E70", VA = "0x383E70")]
		public static extern void SteamAPI_SetBreakpadAppID(uint unAppID);

		[PreserveSig]
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x378EFC", Offset = "0x378EFC", VA = "0x378EFC")]
		public static extern bool SteamGameServer_Init(uint unIP, ushort usSteamPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, InteropHelp.UTF8StringHandle pchVersionString);

		[PreserveSig]
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x378FBC", Offset = "0x378FBC", VA = "0x378FBC")]
		public static extern void SteamGameServer_Shutdown();

		[PreserveSig]
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x379104", Offset = "0x379104", VA = "0x379104")]
		public static extern void SteamGameServer_RunCallbacks();

		[PreserveSig]
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x37924C", Offset = "0x37924C", VA = "0x37924C")]
		public static extern void SteamGameServer_ReleaseCurrentThreadMemory();

		[PreserveSig]
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x379394", Offset = "0x379394", VA = "0x379394")]
		public static extern bool SteamGameServer_BSecure();

		[PreserveSig]
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x379524", Offset = "0x379524", VA = "0x379524")]
		public static extern ulong SteamGameServer_GetSteamID();

		[PreserveSig]
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x3795D4", Offset = "0x3795D4", VA = "0x3795D4")]
		public static extern int SteamGameServer_GetHSteamPipe();

		[PreserveSig]
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x379684", Offset = "0x379684", VA = "0x379684")]
		public static extern int SteamGameServer_GetHSteamUser();

		[PreserveSig]
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x383F30", Offset = "0x383F30", VA = "0x383F30")]
		public static extern bool SteamInternal_GameServer_Init(uint unIP, ushort usPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, InteropHelp.UTF8StringHandle pchVersionString);

		[PreserveSig]
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x383F58", Offset = "0x383F58", VA = "0x383F58")]
		public static extern IntPtr SteamClient();

		[PreserveSig]
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x384008", Offset = "0x384008", VA = "0x384008")]
		public static extern IntPtr SteamGameServerClient();

		[PreserveSig]
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x3840B8", Offset = "0x3840B8", VA = "0x3840B8")]
		public static extern bool SteamEncryptedAppTicket_BDecryptTicket(byte[] rgubTicketEncrypted, uint cubTicketEncrypted, byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, byte[] rgubKey, int cubKey);

		[PreserveSig]
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x3841C0", Offset = "0x3841C0", VA = "0x3841C0")]
		public static extern bool SteamEncryptedAppTicket_BIsTicketForApp(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x3842A4", Offset = "0x3842A4", VA = "0x3842A4")]
		public static extern uint SteamEncryptedAppTicket_GetTicketIssueTime(byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[PreserveSig]
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x384374", Offset = "0x384374", VA = "0x384374")]
		public static extern void SteamEncryptedAppTicket_GetTicketSteamID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID);

		[PreserveSig]
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x384460", Offset = "0x384460", VA = "0x384460")]
		public static extern uint SteamEncryptedAppTicket_GetTicketAppID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[PreserveSig]
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x384530", Offset = "0x384530", VA = "0x384530")]
		public static extern bool SteamEncryptedAppTicket_BUserOwnsAppInTicket(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x384614", Offset = "0x384614", VA = "0x384614")]
		public static extern bool SteamEncryptedAppTicket_BUserIsVacBanned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[PreserveSig]
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x3846F0", Offset = "0x3846F0", VA = "0x3846F0")]
		public static extern IntPtr SteamEncryptedAppTicket_GetUserVariableData(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData);

		[PreserveSig]
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x3847D8", Offset = "0x3847D8", VA = "0x3847D8")]
		public static extern uint ISteamAppList_GetNumInstalledApps(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x384898", Offset = "0x384898", VA = "0x384898")]
		public static extern uint ISteamAppList_GetInstalledApps(IntPtr instancePtr, [In][Out] AppId_t[] pvecAppID, uint unMaxAppIDs);

		[PreserveSig]
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x384970", Offset = "0x384970", VA = "0x384970")]
		public static extern int ISteamAppList_GetAppName(IntPtr instancePtr, AppId_t nAppID, IntPtr pchName, int cchNameMax);

		[PreserveSig]
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x384A44", Offset = "0x384A44", VA = "0x384A44")]
		public static extern int ISteamAppList_GetAppInstallDir(IntPtr instancePtr, AppId_t nAppID, IntPtr pchDirectory, int cchNameMax);

		[PreserveSig]
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x384B18", Offset = "0x384B18", VA = "0x384B18")]
		public static extern int ISteamAppList_GetAppBuildId(IntPtr instancePtr, AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x384BE0", Offset = "0x384BE0", VA = "0x384BE0")]
		public static extern bool ISteamApps_BIsSubscribed(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x384CAC", Offset = "0x384CAC", VA = "0x384CAC")]
		public static extern bool ISteamApps_BIsLowViolence(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x384D78", Offset = "0x384D78", VA = "0x384D78")]
		public static extern bool ISteamApps_BIsCybercafe(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x384E44", Offset = "0x384E44", VA = "0x384E44")]
		public static extern bool ISteamApps_BIsVACBanned(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x384F10", Offset = "0x384F10", VA = "0x384F10")]
		public static extern IntPtr ISteamApps_GetCurrentGameLanguage(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x384FD0", Offset = "0x384FD0", VA = "0x384FD0")]
		public static extern IntPtr ISteamApps_GetAvailableGameLanguages(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x385090", Offset = "0x385090", VA = "0x385090")]
		public static extern bool ISteamApps_BIsSubscribedApp(IntPtr instancePtr, AppId_t appID);

		[PreserveSig]
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x385164", Offset = "0x385164", VA = "0x385164")]
		public static extern bool ISteamApps_BIsDlcInstalled(IntPtr instancePtr, AppId_t appID);

		[PreserveSig]
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x385238", Offset = "0x385238", VA = "0x385238")]
		public static extern uint ISteamApps_GetEarliestPurchaseUnixTime(IntPtr instancePtr, AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x385300", Offset = "0x385300", VA = "0x385300")]
		public static extern bool ISteamApps_BIsSubscribedFromFreeWeekend(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x3853CC", Offset = "0x3853CC", VA = "0x3853CC")]
		public static extern int ISteamApps_GetDLCCount(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x38548C", Offset = "0x38548C", VA = "0x38548C")]
		public static extern bool ISteamApps_BGetDLCDataByIndex(IntPtr instancePtr, int iDLC, out AppId_t pAppID, out bool pbAvailable, IntPtr pchName, int cchNameBufferSize);

		[PreserveSig]
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x3855A4", Offset = "0x3855A4", VA = "0x3855A4")]
		public static extern void ISteamApps_InstallDLC(IntPtr instancePtr, AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x38566C", Offset = "0x38566C", VA = "0x38566C")]
		public static extern void ISteamApps_UninstallDLC(IntPtr instancePtr, AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x385734", Offset = "0x385734", VA = "0x385734")]
		public static extern void ISteamApps_RequestAppProofOfPurchaseKey(IntPtr instancePtr, AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x3857FC", Offset = "0x3857FC", VA = "0x3857FC")]
		public static extern bool ISteamApps_GetCurrentBetaName(IntPtr instancePtr, IntPtr pchName, int cchNameBufferSize);

		[PreserveSig]
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x3858D8", Offset = "0x3858D8", VA = "0x3858D8")]
		public static extern bool ISteamApps_MarkContentCorrupt(IntPtr instancePtr, bool bMissingFilesOnly);

		[PreserveSig]
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x3859AC", Offset = "0x3859AC", VA = "0x3859AC")]
		public static extern uint ISteamApps_GetInstalledDepots(IntPtr instancePtr, AppId_t appID, [In][Out] DepotId_t[] pvecDepots, uint cMaxDepots);

		[PreserveSig]
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x385A88", Offset = "0x385A88", VA = "0x385A88")]
		public static extern uint ISteamApps_GetAppInstallDir(IntPtr instancePtr, AppId_t appID, IntPtr pchFolder, uint cchFolderBufferSize);

		[PreserveSig]
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x385B5C", Offset = "0x385B5C", VA = "0x385B5C")]
		public static extern bool ISteamApps_BIsAppInstalled(IntPtr instancePtr, AppId_t appID);

		[PreserveSig]
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x385C30", Offset = "0x385C30", VA = "0x385C30")]
		public static extern ulong ISteamApps_GetAppOwner(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x385CF0", Offset = "0x385CF0", VA = "0x385CF0")]
		public static extern IntPtr ISteamApps_GetLaunchQueryParam(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x385D18", Offset = "0x385D18", VA = "0x385D18")]
		public static extern bool ISteamApps_GetDlcDownloadProgress(IntPtr instancePtr, AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal);

		[PreserveSig]
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x385E24", Offset = "0x385E24", VA = "0x385E24")]
		public static extern int ISteamApps_GetAppBuildId(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x385EE4", Offset = "0x385EE4", VA = "0x385EE4")]
		public static extern void ISteamApps_RequestAllProofOfPurchaseKeys(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x385FA4", Offset = "0x385FA4", VA = "0x385FA4")]
		public static extern ulong ISteamApps_GetFileDetails(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszFileName);

		[PreserveSig]
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x385FCC", Offset = "0x385FCC", VA = "0x385FCC")]
		public static extern int ISteamClient_CreateSteamPipe(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x38608C", Offset = "0x38608C", VA = "0x38608C")]
		public static extern bool ISteamClient_BReleaseSteamPipe(IntPtr instancePtr, HSteamPipe hSteamPipe);

		[PreserveSig]
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x386160", Offset = "0x386160", VA = "0x386160")]
		public static extern int ISteamClient_ConnectToGlobalUser(IntPtr instancePtr, HSteamPipe hSteamPipe);

		[PreserveSig]
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x386228", Offset = "0x386228", VA = "0x386228")]
		public static extern int ISteamClient_CreateLocalUser(IntPtr instancePtr, out HSteamPipe phSteamPipe, EAccountType eAccountType);

		[PreserveSig]
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x386308", Offset = "0x386308", VA = "0x386308")]
		public static extern void ISteamClient_ReleaseUser(IntPtr instancePtr, HSteamPipe hSteamPipe, HSteamUser hUser);

		[PreserveSig]
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x3863D8", Offset = "0x3863D8", VA = "0x3863D8")]
		public static extern IntPtr ISteamClient_GetISteamUser(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x386400", Offset = "0x386400", VA = "0x386400")]
		public static extern IntPtr ISteamClient_GetISteamGameServer(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x386428", Offset = "0x386428", VA = "0x386428")]
		public static extern void ISteamClient_SetLocalIPBinding(IntPtr instancePtr, uint unIP, ushort usPort);

		[PreserveSig]
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x3864F8", Offset = "0x3864F8", VA = "0x3864F8")]
		public static extern IntPtr ISteamClient_GetISteamFriends(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x386520", Offset = "0x386520", VA = "0x386520")]
		public static extern IntPtr ISteamClient_GetISteamUtils(IntPtr instancePtr, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x386548", Offset = "0x386548", VA = "0x386548")]
		public static extern IntPtr ISteamClient_GetISteamMatchmaking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x386570", Offset = "0x386570", VA = "0x386570")]
		public static extern IntPtr ISteamClient_GetISteamMatchmakingServers(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x386598", Offset = "0x386598", VA = "0x386598")]
		public static extern IntPtr ISteamClient_GetISteamGenericInterface(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x3865C0", Offset = "0x3865C0", VA = "0x3865C0")]
		public static extern IntPtr ISteamClient_GetISteamUserStats(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x3865E8", Offset = "0x3865E8", VA = "0x3865E8")]
		public static extern IntPtr ISteamClient_GetISteamGameServerStats(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x386610", Offset = "0x386610", VA = "0x386610")]
		public static extern IntPtr ISteamClient_GetISteamApps(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x386638", Offset = "0x386638", VA = "0x386638")]
		public static extern IntPtr ISteamClient_GetISteamNetworking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x386660", Offset = "0x386660", VA = "0x386660")]
		public static extern IntPtr ISteamClient_GetISteamRemoteStorage(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x386688", Offset = "0x386688", VA = "0x386688")]
		public static extern IntPtr ISteamClient_GetISteamScreenshots(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x3866B0", Offset = "0x3866B0", VA = "0x3866B0")]
		public static extern uint ISteamClient_GetIPCCallCount(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x386770", Offset = "0x386770", VA = "0x386770")]
		public static extern void ISteamClient_SetWarningMessageHook(IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction);

		[PreserveSig]
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x386848", Offset = "0x386848", VA = "0x386848")]
		public static extern bool ISteamClient_BShutdownIfAllPipesClosed(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x386914", Offset = "0x386914", VA = "0x386914")]
		public static extern IntPtr ISteamClient_GetISteamHTTP(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x38693C", Offset = "0x38693C", VA = "0x38693C")]
		public static extern IntPtr ISteamClient_GetISteamUnifiedMessages(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x386964", Offset = "0x386964", VA = "0x386964")]
		public static extern IntPtr ISteamClient_GetISteamController(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x38698C", Offset = "0x38698C", VA = "0x38698C")]
		public static extern IntPtr ISteamClient_GetISteamUGC(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x3869B4", Offset = "0x3869B4", VA = "0x3869B4")]
		public static extern IntPtr ISteamClient_GetISteamAppList(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x3869DC", Offset = "0x3869DC", VA = "0x3869DC")]
		public static extern IntPtr ISteamClient_GetISteamMusic(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x386A04", Offset = "0x386A04", VA = "0x386A04")]
		public static extern IntPtr ISteamClient_GetISteamMusicRemote(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x386A2C", Offset = "0x386A2C", VA = "0x386A2C")]
		public static extern IntPtr ISteamClient_GetISteamHTMLSurface(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x386A54", Offset = "0x386A54", VA = "0x386A54")]
		public static extern IntPtr ISteamClient_GetISteamInventory(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x386A7C", Offset = "0x386A7C", VA = "0x386A7C")]
		public static extern IntPtr ISteamClient_GetISteamVideo(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x386AA4", Offset = "0x386AA4", VA = "0x386AA4")]
		public static extern IntPtr ISteamClient_GetISteamParentalSettings(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x386ACC", Offset = "0x386ACC", VA = "0x386ACC")]
		public static extern bool ISteamController_Init(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x386B98", Offset = "0x386B98", VA = "0x386B98")]
		public static extern bool ISteamController_Shutdown(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x386C64", Offset = "0x386C64", VA = "0x386C64")]
		public static extern void ISteamController_RunFrame(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x386D24", Offset = "0x386D24", VA = "0x386D24")]
		public static extern int ISteamController_GetConnectedControllers(IntPtr instancePtr, [In][Out] ControllerHandle_t[] handlesOut);

		[PreserveSig]
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x386DF4", Offset = "0x386DF4", VA = "0x386DF4")]
		public static extern bool ISteamController_ShowBindingPanel(IntPtr instancePtr, ControllerHandle_t controllerHandle);

		[PreserveSig]
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x386ED0", Offset = "0x386ED0", VA = "0x386ED0")]
		public static extern ulong ISteamController_GetActionSetHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionSetName);

		[PreserveSig]
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x386EF8", Offset = "0x386EF8", VA = "0x386EF8")]
		public static extern void ISteamController_ActivateActionSet(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle);

		[PreserveSig]
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x386FD8", Offset = "0x386FD8", VA = "0x386FD8")]
		public static extern ulong ISteamController_GetCurrentActionSet(IntPtr instancePtr, ControllerHandle_t controllerHandle);

		[PreserveSig]
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x3870A8", Offset = "0x3870A8", VA = "0x3870A8")]
		public static extern ulong ISteamController_GetDigitalActionHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionName);

		[PreserveSig]
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x3870D0", Offset = "0x3870D0", VA = "0x3870D0")]
		public static extern ControllerDigitalActionData_t ISteamController_GetDigitalActionData(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle);

		[PreserveSig]
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x3871B0", Offset = "0x3871B0", VA = "0x3871B0")]
		public static extern int ISteamController_GetDigitalActionOrigins(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerDigitalActionHandle_t digitalActionHandle, [In][Out] EControllerActionOrigin[] originsOut);

		[PreserveSig]
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x3872B0", Offset = "0x3872B0", VA = "0x3872B0")]
		public static extern ulong ISteamController_GetAnalogActionHandle(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszActionName);

		[PreserveSig]
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x3872D8", Offset = "0x3872D8", VA = "0x3872D8")]
		public static extern ControllerAnalogActionData_t ISteamController_GetAnalogActionData(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle);

		[PreserveSig]
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x3873B8", Offset = "0x3873B8", VA = "0x3873B8")]
		public static extern int ISteamController_GetAnalogActionOrigins(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerActionSetHandle_t actionSetHandle, ControllerAnalogActionHandle_t analogActionHandle, [In][Out] EControllerActionOrigin[] originsOut);

		[PreserveSig]
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x3874B8", Offset = "0x3874B8", VA = "0x3874B8")]
		public static extern void ISteamController_StopAnalogActionMomentum(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t eAction);

		[PreserveSig]
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x387598", Offset = "0x387598", VA = "0x387598")]
		public static extern void ISteamController_TriggerHapticPulse(IntPtr instancePtr, ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec);

		[PreserveSig]
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x387678", Offset = "0x387678", VA = "0x387678")]
		public static extern void ISteamController_TriggerRepeatedHapticPulse(IntPtr instancePtr, ControllerHandle_t controllerHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags);

		[PreserveSig]
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x387770", Offset = "0x387770", VA = "0x387770")]
		public static extern void ISteamController_TriggerVibration(IntPtr instancePtr, ControllerHandle_t controllerHandle, ushort usLeftSpeed, ushort usRightSpeed);

		[PreserveSig]
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x387850", Offset = "0x387850", VA = "0x387850")]
		public static extern void ISteamController_SetLEDColor(IntPtr instancePtr, ControllerHandle_t controllerHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags);

		[PreserveSig]
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x387940", Offset = "0x387940", VA = "0x387940")]
		public static extern int ISteamController_GetGamepadIndexForController(IntPtr instancePtr, ControllerHandle_t ulControllerHandle);

		[PreserveSig]
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x387A10", Offset = "0x387A10", VA = "0x387A10")]
		public static extern ulong ISteamController_GetControllerForGamepadIndex(IntPtr instancePtr, int nIndex);

		[PreserveSig]
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x387AD8", Offset = "0x387AD8", VA = "0x387AD8")]
		public static extern ControllerMotionData_t ISteamController_GetMotionData(IntPtr instancePtr, ControllerHandle_t controllerHandle);

		[PreserveSig]
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x387BA8", Offset = "0x387BA8", VA = "0x387BA8")]
		public static extern bool ISteamController_ShowDigitalActionOrigins(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerDigitalActionHandle_t digitalActionHandle, float flScale, float flXPosition, float flYPosition);

		[PreserveSig]
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x387CAC", Offset = "0x387CAC", VA = "0x387CAC")]
		public static extern bool ISteamController_ShowAnalogActionOrigins(IntPtr instancePtr, ControllerHandle_t controllerHandle, ControllerAnalogActionHandle_t analogActionHandle, float flScale, float flXPosition, float flYPosition);

		[PreserveSig]
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x387DB0", Offset = "0x387DB0", VA = "0x387DB0")]
		public static extern IntPtr ISteamController_GetStringForActionOrigin(IntPtr instancePtr, EControllerActionOrigin eOrigin);

		[PreserveSig]
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x387E78", Offset = "0x387E78", VA = "0x387E78")]
		public static extern IntPtr ISteamController_GetGlyphForActionOrigin(IntPtr instancePtr, EControllerActionOrigin eOrigin);

		[PreserveSig]
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x387F40", Offset = "0x387F40", VA = "0x387F40")]
		public static extern IntPtr ISteamFriends_GetPersonaName(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x388000", Offset = "0x388000", VA = "0x388000")]
		public static extern ulong ISteamFriends_SetPersonaName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchPersonaName);

		[PreserveSig]
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x388028", Offset = "0x388028", VA = "0x388028")]
		public static extern EPersonaState ISteamFriends_GetPersonaState(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x3880E8", Offset = "0x3880E8", VA = "0x3880E8")]
		public static extern int ISteamFriends_GetFriendCount(IntPtr instancePtr, EFriendFlags iFriendFlags);

		[PreserveSig]
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x3881B0", Offset = "0x3881B0", VA = "0x3881B0")]
		public static extern ulong ISteamFriends_GetFriendByIndex(IntPtr instancePtr, int iFriend, EFriendFlags iFriendFlags);

		[PreserveSig]
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x388280", Offset = "0x388280", VA = "0x388280")]
		public static extern EFriendRelationship ISteamFriends_GetFriendRelationship(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x388350", Offset = "0x388350", VA = "0x388350")]
		public static extern EPersonaState ISteamFriends_GetFriendPersonaState(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x388420", Offset = "0x388420", VA = "0x388420")]
		public static extern IntPtr ISteamFriends_GetFriendPersonaName(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x3884F0", Offset = "0x3884F0", VA = "0x3884F0")]
		public static extern bool ISteamFriends_GetFriendGamePlayed(IntPtr instancePtr, CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo);

		[PreserveSig]
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x3885EC", Offset = "0x3885EC", VA = "0x3885EC")]
		public static extern IntPtr ISteamFriends_GetFriendPersonaNameHistory(IntPtr instancePtr, CSteamID steamIDFriend, int iPersonaName);

		[PreserveSig]
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x3886C0", Offset = "0x3886C0", VA = "0x3886C0")]
		public static extern int ISteamFriends_GetFriendSteamLevel(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x388790", Offset = "0x388790", VA = "0x388790")]
		public static extern IntPtr ISteamFriends_GetPlayerNickname(IntPtr instancePtr, CSteamID steamIDPlayer);

		[PreserveSig]
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x388860", Offset = "0x388860", VA = "0x388860")]
		public static extern int ISteamFriends_GetFriendsGroupCount(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x388920", Offset = "0x388920", VA = "0x388920")]
		public static extern short ISteamFriends_GetFriendsGroupIDByIndex(IntPtr instancePtr, int iFG);

		[PreserveSig]
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x3889E8", Offset = "0x3889E8", VA = "0x3889E8")]
		public static extern IntPtr ISteamFriends_GetFriendsGroupName(IntPtr instancePtr, FriendsGroupID_t friendsGroupID);

		[PreserveSig]
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x388AB0", Offset = "0x388AB0", VA = "0x388AB0")]
		public static extern int ISteamFriends_GetFriendsGroupMembersCount(IntPtr instancePtr, FriendsGroupID_t friendsGroupID);

		[PreserveSig]
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x388B78", Offset = "0x388B78", VA = "0x388B78")]
		public static extern void ISteamFriends_GetFriendsGroupMembersList(IntPtr instancePtr, FriendsGroupID_t friendsGroupID, [In][Out] CSteamID[] pOutSteamIDMembers, int nMembersCount);

		[PreserveSig]
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x388C54", Offset = "0x388C54", VA = "0x388C54")]
		public static extern bool ISteamFriends_HasFriend(IntPtr instancePtr, CSteamID steamIDFriend, EFriendFlags iFriendFlags);

		[PreserveSig]
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x388D34", Offset = "0x388D34", VA = "0x388D34")]
		public static extern int ISteamFriends_GetClanCount(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x388DF4", Offset = "0x388DF4", VA = "0x388DF4")]
		public static extern ulong ISteamFriends_GetClanByIndex(IntPtr instancePtr, int iClan);

		[PreserveSig]
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x388EBC", Offset = "0x388EBC", VA = "0x388EBC")]
		public static extern IntPtr ISteamFriends_GetClanName(IntPtr instancePtr, CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x388F8C", Offset = "0x388F8C", VA = "0x388F8C")]
		public static extern IntPtr ISteamFriends_GetClanTag(IntPtr instancePtr, CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x38905C", Offset = "0x38905C", VA = "0x38905C")]
		public static extern bool ISteamFriends_GetClanActivityCounts(IntPtr instancePtr, CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting);

		[PreserveSig]
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x389180", Offset = "0x389180", VA = "0x389180")]
		public static extern ulong ISteamFriends_DownloadClanActivityCounts(IntPtr instancePtr, [In][Out] CSteamID[] psteamIDClans, int cClansToRequest);

		[PreserveSig]
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x389258", Offset = "0x389258", VA = "0x389258")]
		public static extern int ISteamFriends_GetFriendCountFromSource(IntPtr instancePtr, CSteamID steamIDSource);

		[PreserveSig]
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x389328", Offset = "0x389328", VA = "0x389328")]
		public static extern ulong ISteamFriends_GetFriendFromSourceByIndex(IntPtr instancePtr, CSteamID steamIDSource, int iFriend);

		[PreserveSig]
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x3893FC", Offset = "0x3893FC", VA = "0x3893FC")]
		public static extern bool ISteamFriends_IsUserInSource(IntPtr instancePtr, CSteamID steamIDUser, CSteamID steamIDSource);

		[PreserveSig]
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x3894E4", Offset = "0x3894E4", VA = "0x3894E4")]
		public static extern void ISteamFriends_SetInGameVoiceSpeaking(IntPtr instancePtr, CSteamID steamIDUser, bool bSpeaking);

		[PreserveSig]
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x3895B8", Offset = "0x3895B8", VA = "0x3895B8")]
		public static extern void ISteamFriends_ActivateGameOverlay(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDialog);

		[PreserveSig]
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x3895E0", Offset = "0x3895E0", VA = "0x3895E0")]
		public static extern void ISteamFriends_ActivateGameOverlayToUser(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDialog, CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x389608", Offset = "0x389608", VA = "0x389608")]
		public static extern void ISteamFriends_ActivateGameOverlayToWebPage(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchURL);

		[PreserveSig]
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x389630", Offset = "0x389630", VA = "0x389630")]
		public static extern void ISteamFriends_ActivateGameOverlayToStore(IntPtr instancePtr, AppId_t nAppID, EOverlayToStoreFlag eFlag);

		[PreserveSig]
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x389700", Offset = "0x389700", VA = "0x389700")]
		public static extern void ISteamFriends_SetPlayedWith(IntPtr instancePtr, CSteamID steamIDUserPlayedWith);

		[PreserveSig]
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x3897D0", Offset = "0x3897D0", VA = "0x3897D0")]
		public static extern void ISteamFriends_ActivateGameOverlayInviteDialog(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x3898A0", Offset = "0x3898A0", VA = "0x3898A0")]
		public static extern int ISteamFriends_GetSmallFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x389970", Offset = "0x389970", VA = "0x389970")]
		public static extern int ISteamFriends_GetMediumFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x389A40", Offset = "0x389A40", VA = "0x389A40")]
		public static extern int ISteamFriends_GetLargeFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x389B10", Offset = "0x389B10", VA = "0x389B10")]
		public static extern bool ISteamFriends_RequestUserInformation(IntPtr instancePtr, CSteamID steamIDUser, bool bRequireNameOnly);

		[PreserveSig]
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x389BF0", Offset = "0x389BF0", VA = "0x389BF0")]
		public static extern ulong ISteamFriends_RequestClanOfficerList(IntPtr instancePtr, CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x389CC0", Offset = "0x389CC0", VA = "0x389CC0")]
		public static extern ulong ISteamFriends_GetClanOwner(IntPtr instancePtr, CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x389D90", Offset = "0x389D90", VA = "0x389D90")]
		public static extern int ISteamFriends_GetClanOfficerCount(IntPtr instancePtr, CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x389E60", Offset = "0x389E60", VA = "0x389E60")]
		public static extern ulong ISteamFriends_GetClanOfficerByIndex(IntPtr instancePtr, CSteamID steamIDClan, int iOfficer);

		[PreserveSig]
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x389F34", Offset = "0x389F34", VA = "0x389F34")]
		public static extern uint ISteamFriends_GetUserRestrictions(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x389FF4", Offset = "0x389FF4", VA = "0x389FF4")]
		public static extern bool ISteamFriends_SetRichPresence(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x38A01C", Offset = "0x38A01C", VA = "0x38A01C")]
		public static extern void ISteamFriends_ClearRichPresence(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x38A0DC", Offset = "0x38A0DC", VA = "0x38A0DC")]
		public static extern IntPtr ISteamFriends_GetFriendRichPresence(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x38A104", Offset = "0x38A104", VA = "0x38A104")]
		public static extern int ISteamFriends_GetFriendRichPresenceKeyCount(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x38A1D4", Offset = "0x38A1D4", VA = "0x38A1D4")]
		public static extern IntPtr ISteamFriends_GetFriendRichPresenceKeyByIndex(IntPtr instancePtr, CSteamID steamIDFriend, int iKey);

		[PreserveSig]
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x38A2A8", Offset = "0x38A2A8", VA = "0x38A2A8")]
		public static extern void ISteamFriends_RequestFriendRichPresence(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x38A378", Offset = "0x38A378", VA = "0x38A378")]
		public static extern bool ISteamFriends_InviteUserToGame(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchConnectString);

		[PreserveSig]
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x38A3A0", Offset = "0x38A3A0", VA = "0x38A3A0")]
		public static extern int ISteamFriends_GetCoplayFriendCount(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x38A460", Offset = "0x38A460", VA = "0x38A460")]
		public static extern ulong ISteamFriends_GetCoplayFriend(IntPtr instancePtr, int iCoplayFriend);

		[PreserveSig]
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x38A528", Offset = "0x38A528", VA = "0x38A528")]
		public static extern int ISteamFriends_GetFriendCoplayTime(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x38A5F8", Offset = "0x38A5F8", VA = "0x38A5F8")]
		public static extern uint ISteamFriends_GetFriendCoplayGame(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x38A6C8", Offset = "0x38A6C8", VA = "0x38A6C8")]
		public static extern ulong ISteamFriends_JoinClanChatRoom(IntPtr instancePtr, CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x38A798", Offset = "0x38A798", VA = "0x38A798")]
		public static extern bool ISteamFriends_LeaveClanChatRoom(IntPtr instancePtr, CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x38A874", Offset = "0x38A874", VA = "0x38A874")]
		public static extern int ISteamFriends_GetClanChatMemberCount(IntPtr instancePtr, CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x38A944", Offset = "0x38A944", VA = "0x38A944")]
		public static extern ulong ISteamFriends_GetChatMemberByIndex(IntPtr instancePtr, CSteamID steamIDClan, int iUser);

		[PreserveSig]
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x38AA18", Offset = "0x38AA18", VA = "0x38AA18")]
		public static extern bool ISteamFriends_SendClanChatMessage(IntPtr instancePtr, CSteamID steamIDClanChat, InteropHelp.UTF8StringHandle pchText);

		[PreserveSig]
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x38AA40", Offset = "0x38AA40", VA = "0x38AA40")]
		public static extern int ISteamFriends_GetClanChatMessage(IntPtr instancePtr, CSteamID steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter);

		[PreserveSig]
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x38AB50", Offset = "0x38AB50", VA = "0x38AB50")]
		public static extern bool ISteamFriends_IsClanChatAdmin(IntPtr instancePtr, CSteamID steamIDClanChat, CSteamID steamIDUser);

		[PreserveSig]
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x38AC38", Offset = "0x38AC38", VA = "0x38AC38")]
		public static extern bool ISteamFriends_IsClanChatWindowOpenInSteam(IntPtr instancePtr, CSteamID steamIDClanChat);

		[PreserveSig]
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x38AD14", Offset = "0x38AD14", VA = "0x38AD14")]
		public static extern bool ISteamFriends_OpenClanChatWindowInSteam(IntPtr instancePtr, CSteamID steamIDClanChat);

		[PreserveSig]
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x38ADF0", Offset = "0x38ADF0", VA = "0x38ADF0")]
		public static extern bool ISteamFriends_CloseClanChatWindowInSteam(IntPtr instancePtr, CSteamID steamIDClanChat);

		[PreserveSig]
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x38AECC", Offset = "0x38AECC", VA = "0x38AECC")]
		public static extern bool ISteamFriends_SetListenForFriendsMessages(IntPtr instancePtr, bool bInterceptEnabled);

		[PreserveSig]
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x38AFA0", Offset = "0x38AFA0", VA = "0x38AFA0")]
		public static extern bool ISteamFriends_ReplyToFriendMessage(IntPtr instancePtr, CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchMsgToSend);

		[PreserveSig]
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x38AFC8", Offset = "0x38AFC8", VA = "0x38AFC8")]
		public static extern int ISteamFriends_GetFriendMessage(IntPtr instancePtr, CSteamID steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out EChatEntryType peChatEntryType);

		[PreserveSig]
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x38B0B4", Offset = "0x38B0B4", VA = "0x38B0B4")]
		public static extern ulong ISteamFriends_GetFollowerCount(IntPtr instancePtr, CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x38B184", Offset = "0x38B184", VA = "0x38B184")]
		public static extern ulong ISteamFriends_IsFollowing(IntPtr instancePtr, CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x38B254", Offset = "0x38B254", VA = "0x38B254")]
		public static extern ulong ISteamFriends_EnumerateFollowingList(IntPtr instancePtr, uint unStartIndex);

		[PreserveSig]
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x38B31C", Offset = "0x38B31C", VA = "0x38B31C")]
		public static extern bool ISteamGameServer_InitGameServer(IntPtr instancePtr, uint unIP, ushort usGamePort, ushort usQueryPort, uint unFlags, AppId_t nGameAppId, InteropHelp.UTF8StringHandle pchVersionString);

		[PreserveSig]
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x38B344", Offset = "0x38B344", VA = "0x38B344")]
		public static extern void ISteamGameServer_SetProduct(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszProduct);

		[PreserveSig]
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x38B36C", Offset = "0x38B36C", VA = "0x38B36C")]
		public static extern void ISteamGameServer_SetGameDescription(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszGameDescription);

		[PreserveSig]
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x38B394", Offset = "0x38B394", VA = "0x38B394")]
		public static extern void ISteamGameServer_SetModDir(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszModDir);

		[PreserveSig]
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x38B3BC", Offset = "0x38B3BC", VA = "0x38B3BC")]
		public static extern void ISteamGameServer_SetDedicatedServer(IntPtr instancePtr, bool bDedicated);

		[PreserveSig]
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x38B484", Offset = "0x38B484", VA = "0x38B484")]
		public static extern void ISteamGameServer_LogOn(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszToken);

		[PreserveSig]
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x38B4AC", Offset = "0x38B4AC", VA = "0x38B4AC")]
		public static extern void ISteamGameServer_LogOnAnonymous(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x38B56C", Offset = "0x38B56C", VA = "0x38B56C")]
		public static extern void ISteamGameServer_LogOff(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x38B62C", Offset = "0x38B62C", VA = "0x38B62C")]
		public static extern bool ISteamGameServer_BLoggedOn(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x38B6F8", Offset = "0x38B6F8", VA = "0x38B6F8")]
		public static extern bool ISteamGameServer_BSecure(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x38B7C4", Offset = "0x38B7C4", VA = "0x38B7C4")]
		public static extern ulong ISteamGameServer_GetSteamID(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x38B884", Offset = "0x38B884", VA = "0x38B884")]
		public static extern bool ISteamGameServer_WasRestartRequested(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x38B950", Offset = "0x38B950", VA = "0x38B950")]
		public static extern void ISteamGameServer_SetMaxPlayerCount(IntPtr instancePtr, int cPlayersMax);

		[PreserveSig]
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x38BA18", Offset = "0x38BA18", VA = "0x38BA18")]
		public static extern void ISteamGameServer_SetBotPlayerCount(IntPtr instancePtr, int cBotplayers);

		[PreserveSig]
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x38BAE0", Offset = "0x38BAE0", VA = "0x38BAE0")]
		public static extern void ISteamGameServer_SetServerName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszServerName);

		[PreserveSig]
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x38BB08", Offset = "0x38BB08", VA = "0x38BB08")]
		public static extern void ISteamGameServer_SetMapName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszMapName);

		[PreserveSig]
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x38BB30", Offset = "0x38BB30", VA = "0x38BB30")]
		public static extern void ISteamGameServer_SetPasswordProtected(IntPtr instancePtr, bool bPasswordProtected);

		[PreserveSig]
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x38BBF8", Offset = "0x38BBF8", VA = "0x38BBF8")]
		public static extern void ISteamGameServer_SetSpectatorPort(IntPtr instancePtr, ushort unSpectatorPort);

		[PreserveSig]
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x38BCC0", Offset = "0x38BCC0", VA = "0x38BCC0")]
		public static extern void ISteamGameServer_SetSpectatorServerName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszSpectatorServerName);

		[PreserveSig]
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x38BCE8", Offset = "0x38BCE8", VA = "0x38BCE8")]
		public static extern void ISteamGameServer_ClearAllKeyValues(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x38BDA8", Offset = "0x38BDA8", VA = "0x38BDA8")]
		public static extern void ISteamGameServer_SetKeyValue(IntPtr instancePtr, InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue);

		[PreserveSig]
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x38BDD0", Offset = "0x38BDD0", VA = "0x38BDD0")]
		public static extern void ISteamGameServer_SetGameTags(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchGameTags);

		[PreserveSig]
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x38BDF8", Offset = "0x38BDF8", VA = "0x38BDF8")]
		public static extern void ISteamGameServer_SetGameData(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchGameData);

		[PreserveSig]
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x38BE20", Offset = "0x38BE20", VA = "0x38BE20")]
		public static extern void ISteamGameServer_SetRegion(IntPtr instancePtr, InteropHelp.UTF8StringHandle pszRegion);

		[PreserveSig]
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x38BE48", Offset = "0x38BE48", VA = "0x38BE48")]
		public static extern bool ISteamGameServer_SendUserConnectAndAuthenticate(IntPtr instancePtr, uint unIPClient, byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser);

		[PreserveSig]
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x38BF54", Offset = "0x38BF54", VA = "0x38BF54")]
		public static extern ulong ISteamGameServer_CreateUnauthenticatedUserConnection(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x38C014", Offset = "0x38C014", VA = "0x38C014")]
		public static extern void ISteamGameServer_SendUserDisconnect(IntPtr instancePtr, CSteamID steamIDUser);

		[PreserveSig]
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x38C0E4", Offset = "0x38C0E4", VA = "0x38C0E4")]
		public static extern bool ISteamGameServer_BUpdateUserData(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchPlayerName, uint uScore);

		[PreserveSig]
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x38C10C", Offset = "0x38C10C", VA = "0x38C10C")]
		public static extern uint ISteamGameServer_GetAuthSessionTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		[PreserveSig]
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x38C1FC", Offset = "0x38C1FC", VA = "0x38C1FC")]
		public static extern EBeginAuthSessionResult ISteamGameServer_BeginAuthSession(IntPtr instancePtr, byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x38C2E0", Offset = "0x38C2E0", VA = "0x38C2E0")]
		public static extern void ISteamGameServer_EndAuthSession(IntPtr instancePtr, CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x38C3B0", Offset = "0x38C3B0", VA = "0x38C3B0")]
		public static extern void ISteamGameServer_CancelAuthTicket(IntPtr instancePtr, HAuthTicket hAuthTicket);

		[PreserveSig]
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x38C478", Offset = "0x38C478", VA = "0x38C478")]
		public static extern EUserHasLicenseForAppResult ISteamGameServer_UserHasLicenseForApp(IntPtr instancePtr, CSteamID steamID, AppId_t appID);

		[PreserveSig]
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x38C54C", Offset = "0x38C54C", VA = "0x38C54C")]
		public static extern bool ISteamGameServer_RequestUserGroupStatus(IntPtr instancePtr, CSteamID steamIDUser, CSteamID steamIDGroup);

		[PreserveSig]
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x38C634", Offset = "0x38C634", VA = "0x38C634")]
		public static extern void ISteamGameServer_GetGameplayStats(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x38C6F4", Offset = "0x38C6F4", VA = "0x38C6F4")]
		public static extern ulong ISteamGameServer_GetServerReputation(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x38C7B4", Offset = "0x38C7B4", VA = "0x38C7B4")]
		public static extern uint ISteamGameServer_GetPublicIP(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x38C874", Offset = "0x38C874", VA = "0x38C874")]
		public static extern bool ISteamGameServer_HandleIncomingPacket(IntPtr instancePtr, byte[] pData, int cbData, uint srcIP, ushort srcPort);

		[PreserveSig]
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x38C964", Offset = "0x38C964", VA = "0x38C964")]
		public static extern int ISteamGameServer_GetNextOutgoingPacket(IntPtr instancePtr, byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort);

		[PreserveSig]
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x38CA6C", Offset = "0x38CA6C", VA = "0x38CA6C")]
		public static extern void ISteamGameServer_EnableHeartbeats(IntPtr instancePtr, bool bActive);

		[PreserveSig]
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x38CB34", Offset = "0x38CB34", VA = "0x38CB34")]
		public static extern void ISteamGameServer_SetHeartbeatInterval(IntPtr instancePtr, int iHeartbeatInterval);

		[PreserveSig]
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x38CBFC", Offset = "0x38CBFC", VA = "0x38CBFC")]
		public static extern void ISteamGameServer_ForceHeartbeat(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x38CCBC", Offset = "0x38CCBC", VA = "0x38CCBC")]
		public static extern ulong ISteamGameServer_AssociateWithClan(IntPtr instancePtr, CSteamID steamIDClan);

		[PreserveSig]
		[Token(Token = "0x6000587")]
		[Address(RVA = "0x38CD8C", Offset = "0x38CD8C", VA = "0x38CD8C")]
		public static extern ulong ISteamGameServer_ComputeNewPlayerCompatibility(IntPtr instancePtr, CSteamID steamIDNewPlayer);

		[PreserveSig]
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x38CE5C", Offset = "0x38CE5C", VA = "0x38CE5C")]
		public static extern ulong ISteamGameServerStats_RequestUserStats(IntPtr instancePtr, CSteamID steamIDUser);

		[PreserveSig]
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x38CF2C", Offset = "0x38CF2C", VA = "0x38CF2C")]
		public static extern bool ISteamGameServerStats_GetUserStat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out int pData);

		[PreserveSig]
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x38CF54", Offset = "0x38CF54", VA = "0x38CF54")]
		public static extern bool ISteamGameServerStats_GetUserStat0(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out float pData);

		[PreserveSig]
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x38CF7C", Offset = "0x38CF7C", VA = "0x38CF7C")]
		public static extern bool ISteamGameServerStats_GetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		[PreserveSig]
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x38CFA4", Offset = "0x38CFA4", VA = "0x38CFA4")]
		public static extern bool ISteamGameServerStats_SetUserStat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, int nData);

		[PreserveSig]
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x38CFCC", Offset = "0x38CFCC", VA = "0x38CFCC")]
		public static extern bool ISteamGameServerStats_SetUserStat0(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, float fData);

		[PreserveSig]
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x38CFF4", Offset = "0x38CFF4", VA = "0x38CFF4")]
		public static extern bool ISteamGameServerStats_UpdateUserAvgRateStat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, float flCountThisSession, double dSessionLength);

		[PreserveSig]
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x38D01C", Offset = "0x38D01C", VA = "0x38D01C")]
		public static extern bool ISteamGameServerStats_SetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x38D044", Offset = "0x38D044", VA = "0x38D044")]
		public static extern bool ISteamGameServerStats_ClearUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x38D06C", Offset = "0x38D06C", VA = "0x38D06C")]
		public static extern ulong ISteamGameServerStats_StoreUserStats(IntPtr instancePtr, CSteamID steamIDUser);

		[PreserveSig]
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x38D13C", Offset = "0x38D13C", VA = "0x38D13C")]
		public static extern bool ISteamHTMLSurface_Init(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x38D208", Offset = "0x38D208", VA = "0x38D208")]
		public static extern bool ISteamHTMLSurface_Shutdown(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x38D2D4", Offset = "0x38D2D4", VA = "0x38D2D4")]
		public static extern ulong ISteamHTMLSurface_CreateBrowser(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchUserAgent, InteropHelp.UTF8StringHandle pchUserCSS);

		[PreserveSig]
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x38D2FC", Offset = "0x38D2FC", VA = "0x38D2FC")]
		public static extern void ISteamHTMLSurface_RemoveBrowser(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x38D3C4", Offset = "0x38D3C4", VA = "0x38D3C4")]
		public static extern void ISteamHTMLSurface_LoadURL(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchURL, InteropHelp.UTF8StringHandle pchPostData);

		[PreserveSig]
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x38D3EC", Offset = "0x38D3EC", VA = "0x38D3EC")]
		public static extern void ISteamHTMLSurface_SetSize(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight);

		[PreserveSig]
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x38D4C0", Offset = "0x38D4C0", VA = "0x38D4C0")]
		public static extern void ISteamHTMLSurface_StopLoad(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x38D588", Offset = "0x38D588", VA = "0x38D588")]
		public static extern void ISteamHTMLSurface_Reload(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x38D650", Offset = "0x38D650", VA = "0x38D650")]
		public static extern void ISteamHTMLSurface_GoBack(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x38D718", Offset = "0x38D718", VA = "0x38D718")]
		public static extern void ISteamHTMLSurface_GoForward(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x38D7E0", Offset = "0x38D7E0", VA = "0x38D7E0")]
		public static extern void ISteamHTMLSurface_AddHeader(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x38D808", Offset = "0x38D808", VA = "0x38D808")]
		public static extern void ISteamHTMLSurface_ExecuteJavascript(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchScript);

		[PreserveSig]
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x38D830", Offset = "0x38D830", VA = "0x38D830")]
		public static extern void ISteamHTMLSurface_MouseUp(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		[PreserveSig]
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x38D900", Offset = "0x38D900", VA = "0x38D900")]
		public static extern void ISteamHTMLSurface_MouseDown(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		[PreserveSig]
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x38D9D0", Offset = "0x38D9D0", VA = "0x38D9D0")]
		public static extern void ISteamHTMLSurface_MouseDoubleClick(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		[PreserveSig]
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x38DAA0", Offset = "0x38DAA0", VA = "0x38DAA0")]
		public static extern void ISteamHTMLSurface_MouseMove(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int x, int y);

		[PreserveSig]
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x38DB74", Offset = "0x38DB74", VA = "0x38DB74")]
		public static extern void ISteamHTMLSurface_MouseWheel(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int nDelta);

		[PreserveSig]
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x38DC44", Offset = "0x38DC44", VA = "0x38DC44")]
		public static extern void ISteamHTMLSurface_KeyDown(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers);

		[PreserveSig]
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x38DD18", Offset = "0x38DD18", VA = "0x38DD18")]
		public static extern void ISteamHTMLSurface_KeyUp(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers);

		[PreserveSig]
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x38DDEC", Offset = "0x38DDEC", VA = "0x38DDEC")]
		public static extern void ISteamHTMLSurface_KeyChar(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers);

		[PreserveSig]
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x38DEC0", Offset = "0x38DEC0", VA = "0x38DEC0")]
		public static extern void ISteamHTMLSurface_SetHorizontalScroll(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);

		[PreserveSig]
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x38DF90", Offset = "0x38DF90", VA = "0x38DF90")]
		public static extern void ISteamHTMLSurface_SetVerticalScroll(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);

		[PreserveSig]
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x38E060", Offset = "0x38E060", VA = "0x38E060")]
		public static extern void ISteamHTMLSurface_SetKeyFocus(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bHasKeyFocus);

		[PreserveSig]
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x38E130", Offset = "0x38E130", VA = "0x38E130")]
		public static extern void ISteamHTMLSurface_ViewSource(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x38E1F8", Offset = "0x38E1F8", VA = "0x38E1F8")]
		public static extern void ISteamHTMLSurface_CopyToClipboard(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x38E2C0", Offset = "0x38E2C0", VA = "0x38E2C0")]
		public static extern void ISteamHTMLSurface_PasteFromClipboard(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x38E388", Offset = "0x38E388", VA = "0x38E388")]
		public static extern void ISteamHTMLSurface_Find(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchSearchStr, bool bCurrentlyInFind, bool bReverse);

		[PreserveSig]
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x38E3B0", Offset = "0x38E3B0", VA = "0x38E3B0")]
		public static extern void ISteamHTMLSurface_StopFind(IntPtr instancePtr, HHTMLBrowser unBrowserHandle);

		[PreserveSig]
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x38E478", Offset = "0x38E478", VA = "0x38E478")]
		public static extern void ISteamHTMLSurface_GetLinkAtPosition(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int x, int y);

		[PreserveSig]
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x38E54C", Offset = "0x38E54C", VA = "0x38E54C")]
		public static extern void ISteamHTMLSurface_SetCookie(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchHostname, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue, InteropHelp.UTF8StringHandle pchPath, uint nExpires, bool bSecure, bool bHTTPOnly);

		[PreserveSig]
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x38E574", Offset = "0x38E574", VA = "0x38E574")]
		public static extern void ISteamHTMLSurface_SetPageScaleFactor(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY);

		[PreserveSig]
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x38E650", Offset = "0x38E650", VA = "0x38E650")]
		public static extern void ISteamHTMLSurface_SetBackgroundMode(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bBackgroundMode);

		[PreserveSig]
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x38E720", Offset = "0x38E720", VA = "0x38E720")]
		public static extern void ISteamHTMLSurface_SetDPIScalingFactor(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, float flDPIScaling);

		[PreserveSig]
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x38E7F0", Offset = "0x38E7F0", VA = "0x38E7F0")]
		public static extern void ISteamHTMLSurface_AllowStartRequest(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bAllowed);

		[PreserveSig]
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x38E8C0", Offset = "0x38E8C0", VA = "0x38E8C0")]
		public static extern void ISteamHTMLSurface_JSDialogResponse(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bResult);

		[PreserveSig]
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x38E990", Offset = "0x38E990", VA = "0x38E990")]
		public static extern void ISteamHTMLSurface_FileLoadDialogResponse(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles);

		[PreserveSig]
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x38EA60", Offset = "0x38EA60", VA = "0x38EA60")]
		public static extern uint ISteamHTTP_CreateHTTPRequest(IntPtr instancePtr, EHTTPMethod eHTTPRequestMethod, InteropHelp.UTF8StringHandle pchAbsoluteURL);

		[PreserveSig]
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x38EA88", Offset = "0x38EA88", VA = "0x38EA88")]
		public static extern bool ISteamHTTP_SetHTTPRequestContextValue(IntPtr instancePtr, HTTPRequestHandle hRequest, ulong ulContextValue);

		[PreserveSig]
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x38EB64", Offset = "0x38EB64", VA = "0x38EB64")]
		public static extern bool ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(IntPtr instancePtr, HTTPRequestHandle hRequest, uint unTimeoutSeconds);

		[PreserveSig]
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x38EC40", Offset = "0x38EC40", VA = "0x38EC40")]
		public static extern bool ISteamHTTP_SetHTTPRequestHeaderValue(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, InteropHelp.UTF8StringHandle pchHeaderValue);

		[PreserveSig]
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x38EC68", Offset = "0x38EC68", VA = "0x38EC68")]
		public static extern bool ISteamHTTP_SetHTTPRequestGetOrPostParameter(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchParamName, InteropHelp.UTF8StringHandle pchParamValue);

		[PreserveSig]
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x38EC90", Offset = "0x38EC90", VA = "0x38EC90")]
		public static extern bool ISteamHTTP_SendHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		[PreserveSig]
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x38ED80", Offset = "0x38ED80", VA = "0x38ED80")]
		public static extern bool ISteamHTTP_SendHTTPRequestAndStreamResponse(IntPtr instancePtr, HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		[PreserveSig]
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x38EE70", Offset = "0x38EE70", VA = "0x38EE70")]
		public static extern bool ISteamHTTP_DeferHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest);

		[PreserveSig]
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x38EF44", Offset = "0x38EF44", VA = "0x38EF44")]
		public static extern bool ISteamHTTP_PrioritizeHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest);

		[PreserveSig]
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x38F018", Offset = "0x38F018", VA = "0x38F018")]
		public static extern bool ISteamHTTP_GetHTTPResponseHeaderSize(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, out uint unResponseHeaderSize);

		[PreserveSig]
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x38F040", Offset = "0x38F040", VA = "0x38F040")]
		public static extern bool ISteamHTTP_GetHTTPResponseHeaderValue(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x38F068", Offset = "0x38F068", VA = "0x38F068")]
		public static extern bool ISteamHTTP_GetHTTPResponseBodySize(IntPtr instancePtr, HTTPRequestHandle hRequest, out uint unBodySize);

		[PreserveSig]
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x38F154", Offset = "0x38F154", VA = "0x38F154")]
		public static extern bool ISteamHTTP_GetHTTPResponseBodyData(IntPtr instancePtr, HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x38F23C", Offset = "0x38F23C", VA = "0x38F23C")]
		public static extern bool ISteamHTTP_GetHTTPStreamingResponseBodyData(IntPtr instancePtr, HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x38F32C", Offset = "0x38F32C", VA = "0x38F32C")]
		public static extern bool ISteamHTTP_ReleaseHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest);

		[PreserveSig]
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x38F400", Offset = "0x38F400", VA = "0x38F400")]
		public static extern bool ISteamHTTP_GetHTTPDownloadProgressPct(IntPtr instancePtr, HTTPRequestHandle hRequest, out float pflPercentOut);

		[PreserveSig]
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x38F4EC", Offset = "0x38F4EC", VA = "0x38F4EC")]
		public static extern bool ISteamHTTP_SetHTTPRequestRawPostBody(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchContentType, byte[] pubBody, uint unBodyLen);

		[PreserveSig]
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x38F514", Offset = "0x38F514", VA = "0x38F514")]
		public static extern uint ISteamHTTP_CreateCookieContainer(IntPtr instancePtr, bool bAllowResponsesToModify);

		[PreserveSig]
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x38F5DC", Offset = "0x38F5DC", VA = "0x38F5DC")]
		public static extern bool ISteamHTTP_ReleaseCookieContainer(IntPtr instancePtr, HTTPCookieContainerHandle hCookieContainer);

		[PreserveSig]
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x38F6B0", Offset = "0x38F6B0", VA = "0x38F6B0")]
		public static extern bool ISteamHTTP_SetCookie(IntPtr instancePtr, HTTPCookieContainerHandle hCookieContainer, InteropHelp.UTF8StringHandle pchHost, InteropHelp.UTF8StringHandle pchUrl, InteropHelp.UTF8StringHandle pchCookie);

		[PreserveSig]
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x38F6D8", Offset = "0x38F6D8", VA = "0x38F6D8")]
		public static extern bool ISteamHTTP_SetHTTPRequestCookieContainer(IntPtr instancePtr, HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer);

		[PreserveSig]
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x38F7B4", Offset = "0x38F7B4", VA = "0x38F7B4")]
		public static extern bool ISteamHTTP_SetHTTPRequestUserAgentInfo(IntPtr instancePtr, HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchUserAgentInfo);

		[PreserveSig]
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x38F7DC", Offset = "0x38F7DC", VA = "0x38F7DC")]
		public static extern bool ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate(IntPtr instancePtr, HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate);

		[PreserveSig]
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x38F8B8", Offset = "0x38F8B8", VA = "0x38F8B8")]
		public static extern bool ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS(IntPtr instancePtr, HTTPRequestHandle hRequest, uint unMilliseconds);

		[PreserveSig]
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x38F994", Offset = "0x38F994", VA = "0x38F994")]
		public static extern bool ISteamHTTP_GetHTTPRequestWasTimedOut(IntPtr instancePtr, HTTPRequestHandle hRequest, out bool pbWasTimedOut);

		[PreserveSig]
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x38FA88", Offset = "0x38FA88", VA = "0x38FA88")]
		public static extern EResult ISteamInventory_GetResultStatus(IntPtr instancePtr, SteamInventoryResult_t resultHandle);

		[PreserveSig]
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x38FB50", Offset = "0x38FB50", VA = "0x38FB50")]
		public static extern bool ISteamInventory_GetResultItems(IntPtr instancePtr, SteamInventoryResult_t resultHandle, [In][Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize);

		[PreserveSig]
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x38FC38", Offset = "0x38FC38", VA = "0x38FC38")]
		public static extern bool ISteamInventory_GetResultItemProperty(IntPtr instancePtr, SteamInventoryResult_t resultHandle, uint unItemIndex, InteropHelp.UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut);

		[PreserveSig]
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x38FC60", Offset = "0x38FC60", VA = "0x38FC60")]
		public static extern uint ISteamInventory_GetResultTimestamp(IntPtr instancePtr, SteamInventoryResult_t resultHandle);

		[PreserveSig]
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x38FD28", Offset = "0x38FD28", VA = "0x38FD28")]
		public static extern bool ISteamInventory_CheckResultSteamID(IntPtr instancePtr, SteamInventoryResult_t resultHandle, CSteamID steamIDExpected);

		[PreserveSig]
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x38FE08", Offset = "0x38FE08", VA = "0x38FE08")]
		public static extern void ISteamInventory_DestroyResult(IntPtr instancePtr, SteamInventoryResult_t resultHandle);

		[PreserveSig]
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x38FED0", Offset = "0x38FED0", VA = "0x38FED0")]
		public static extern bool ISteamInventory_GetAllItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle);

		[PreserveSig]
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x38FFB4", Offset = "0x38FFB4", VA = "0x38FFB4")]
		public static extern bool ISteamInventory_GetItemsByID(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs);

		[PreserveSig]
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x3900AC", Offset = "0x3900AC", VA = "0x3900AC")]
		public static extern bool ISteamInventory_SerializeResult(IntPtr instancePtr, SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize);

		[PreserveSig]
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x3901A8", Offset = "0x3901A8", VA = "0x3901A8")]
		public static extern bool ISteamInventory_DeserializeResult(IntPtr instancePtr, out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE);

		[PreserveSig]
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x3902A8", Offset = "0x3902A8", VA = "0x3902A8")]
		public static extern bool ISteamInventory_GenerateItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayItemDefs, [In][Out] uint[] punArrayQuantity, uint unArrayLength);

		[PreserveSig]
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x3903B0", Offset = "0x3903B0", VA = "0x3903B0")]
		public static extern bool ISteamInventory_GrantPromoItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle);

		[PreserveSig]
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x390494", Offset = "0x390494", VA = "0x390494")]
		public static extern bool ISteamInventory_AddPromoItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef);

		[PreserveSig]
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x390580", Offset = "0x390580", VA = "0x390580")]
		public static extern bool ISteamInventory_AddPromoItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayItemDefs, uint unArrayLength);

		[PreserveSig]
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x390678", Offset = "0x390678", VA = "0x390678")]
		public static extern bool ISteamInventory_ConsumeItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity);

		[PreserveSig]
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x39076C", Offset = "0x39076C", VA = "0x39076C")]
		public static extern bool ISteamInventory_ExchangeItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayGenerate, [In][Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In][Out] SteamItemInstanceID_t[] pArrayDestroy, [In][Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength);

		[PreserveSig]
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x39089C", Offset = "0x39089C", VA = "0x39089C")]
		public static extern bool ISteamInventory_TransferItemQuantity(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest);

		[PreserveSig]
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x39099C", Offset = "0x39099C", VA = "0x39099C")]
		public static extern void ISteamInventory_SendItemDropHeartbeat(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x390A5C", Offset = "0x390A5C", VA = "0x390A5C")]
		public static extern bool ISteamInventory_TriggerItemDrop(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition);

		[PreserveSig]
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x390B48", Offset = "0x390B48", VA = "0x390B48")]
		public static extern bool ISteamInventory_TradeItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, [In][Out] SteamItemInstanceID_t[] pArrayGive, [In][Out] uint[] pArrayGiveQuantity, uint nArrayGiveLength, [In][Out] SteamItemInstanceID_t[] pArrayGet, [In][Out] uint[] pArrayGetQuantity, uint nArrayGetLength);

		[PreserveSig]
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x390C80", Offset = "0x390C80", VA = "0x390C80")]
		public static extern bool ISteamInventory_LoadItemDefinitions(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x390D4C", Offset = "0x390D4C", VA = "0x390D4C")]
		public static extern bool ISteamInventory_GetItemDefinitionIDs(IntPtr instancePtr, [In][Out] SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize);

		[PreserveSig]
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x390E40", Offset = "0x390E40", VA = "0x390E40")]
		public static extern bool ISteamInventory_GetItemDefinitionProperty(IntPtr instancePtr, SteamItemDef_t iDefinition, InteropHelp.UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut);

		[PreserveSig]
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x390E68", Offset = "0x390E68", VA = "0x390E68")]
		public static extern ulong ISteamInventory_RequestEligiblePromoItemDefinitionsIDs(IntPtr instancePtr, CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x390F38", Offset = "0x390F38", VA = "0x390F38")]
		public static extern bool ISteamInventory_GetEligiblePromoItemDefinitionIDs(IntPtr instancePtr, CSteamID steamID, [In][Out] SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize);

		[PreserveSig]
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x391028", Offset = "0x391028", VA = "0x391028")]
		public static extern int ISteamMatchmaking_GetFavoriteGameCount(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x3910E8", Offset = "0x3910E8", VA = "0x3910E8")]
		public static extern bool ISteamMatchmaking_GetFavoriteGame(IntPtr instancePtr, int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer);

		[PreserveSig]
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x391248", Offset = "0x391248", VA = "0x391248")]
		public static extern int ISteamMatchmaking_AddFavoriteGame(IntPtr instancePtr, AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer);

		[PreserveSig]
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x391334", Offset = "0x391334", VA = "0x391334")]
		public static extern bool ISteamMatchmaking_RemoveFavoriteGame(IntPtr instancePtr, AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags);

		[PreserveSig]
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x391424", Offset = "0x391424", VA = "0x391424")]
		public static extern ulong ISteamMatchmaking_RequestLobbyList(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x3914E4", Offset = "0x3914E4", VA = "0x3914E4")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListStringFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, InteropHelp.UTF8StringHandle pchValueToMatch, ELobbyComparison eComparisonType);

		[PreserveSig]
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x39150C", Offset = "0x39150C", VA = "0x39150C")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListNumericalFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType);

		[PreserveSig]
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x391534", Offset = "0x391534", VA = "0x391534")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListNearValueFilter(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchKeyToMatch, int nValueToBeCloseTo);

		[PreserveSig]
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x39155C", Offset = "0x39155C", VA = "0x39155C")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable(IntPtr instancePtr, int nSlotsAvailable);

		[PreserveSig]
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x391624", Offset = "0x391624", VA = "0x391624")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListDistanceFilter(IntPtr instancePtr, ELobbyDistanceFilter eLobbyDistanceFilter);

		[PreserveSig]
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x3916EC", Offset = "0x3916EC", VA = "0x3916EC")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListResultCountFilter(IntPtr instancePtr, int cMaxResults);

		[PreserveSig]
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x3917B4", Offset = "0x3917B4", VA = "0x3917B4")]
		public static extern void ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x391884", Offset = "0x391884", VA = "0x391884")]
		public static extern ulong ISteamMatchmaking_GetLobbyByIndex(IntPtr instancePtr, int iLobby);

		[PreserveSig]
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x39194C", Offset = "0x39194C", VA = "0x39194C")]
		public static extern ulong ISteamMatchmaking_CreateLobby(IntPtr instancePtr, ELobbyType eLobbyType, int cMaxMembers);

		[PreserveSig]
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x391A1C", Offset = "0x391A1C", VA = "0x391A1C")]
		public static extern ulong ISteamMatchmaking_JoinLobby(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x391AEC", Offset = "0x391AEC", VA = "0x391AEC")]
		public static extern void ISteamMatchmaking_LeaveLobby(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x391BBC", Offset = "0x391BBC", VA = "0x391BBC")]
		public static extern bool ISteamMatchmaking_InviteUserToLobby(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDInvitee);

		[PreserveSig]
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x391CA4", Offset = "0x391CA4", VA = "0x391CA4")]
		public static extern int ISteamMatchmaking_GetNumLobbyMembers(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x391D74", Offset = "0x391D74", VA = "0x391D74")]
		public static extern ulong ISteamMatchmaking_GetLobbyMemberByIndex(IntPtr instancePtr, CSteamID steamIDLobby, int iMember);

		[PreserveSig]
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x391E48", Offset = "0x391E48", VA = "0x391E48")]
		public static extern IntPtr ISteamMatchmaking_GetLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x391E70", Offset = "0x391E70", VA = "0x391E70")]
		public static extern bool ISteamMatchmaking_SetLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x391E98", Offset = "0x391E98", VA = "0x391E98")]
		public static extern int ISteamMatchmaking_GetLobbyDataCount(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x391F68", Offset = "0x391F68", VA = "0x391F68")]
		public static extern bool ISteamMatchmaking_GetLobbyDataByIndex(IntPtr instancePtr, CSteamID steamIDLobby, int iLobbyData, IntPtr pchKey, int cchKeyBufferSize, IntPtr pchValue, int cchValueBufferSize);

		[PreserveSig]
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x392068", Offset = "0x392068", VA = "0x392068")]
		public static extern bool ISteamMatchmaking_DeleteLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x392090", Offset = "0x392090", VA = "0x392090")]
		public static extern IntPtr ISteamMatchmaking_GetLobbyMemberData(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x3920B8", Offset = "0x3920B8", VA = "0x3920B8")]
		public static extern void ISteamMatchmaking_SetLobbyMemberData(IntPtr instancePtr, CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x3920E0", Offset = "0x3920E0", VA = "0x3920E0")]
		public static extern bool ISteamMatchmaking_SendLobbyChatMsg(IntPtr instancePtr, CSteamID steamIDLobby, byte[] pvMsgBody, int cubMsgBody);

		[PreserveSig]
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x3921D0", Offset = "0x3921D0", VA = "0x3921D0")]
		public static extern int ISteamMatchmaking_GetLobbyChatEntry(IntPtr instancePtr, CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, byte[] pvData, int cubData, out EChatEntryType peChatEntryType);

		[PreserveSig]
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x3922E4", Offset = "0x3922E4", VA = "0x3922E4")]
		public static extern bool ISteamMatchmaking_RequestLobbyData(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x3923C0", Offset = "0x3923C0", VA = "0x3923C0")]
		public static extern void ISteamMatchmaking_SetLobbyGameServer(IntPtr instancePtr, CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer);

		[PreserveSig]
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x3924AC", Offset = "0x3924AC", VA = "0x3924AC")]
		public static extern bool ISteamMatchmaking_GetLobbyGameServer(IntPtr instancePtr, CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer);

		[PreserveSig]
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x3925D8", Offset = "0x3925D8", VA = "0x3925D8")]
		public static extern bool ISteamMatchmaking_SetLobbyMemberLimit(IntPtr instancePtr, CSteamID steamIDLobby, int cMaxMembers);

		[PreserveSig]
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x3926B8", Offset = "0x3926B8", VA = "0x3926B8")]
		public static extern int ISteamMatchmaking_GetLobbyMemberLimit(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x392788", Offset = "0x392788", VA = "0x392788")]
		public static extern bool ISteamMatchmaking_SetLobbyType(IntPtr instancePtr, CSteamID steamIDLobby, ELobbyType eLobbyType);

		[PreserveSig]
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x392868", Offset = "0x392868", VA = "0x392868")]
		public static extern bool ISteamMatchmaking_SetLobbyJoinable(IntPtr instancePtr, CSteamID steamIDLobby, bool bLobbyJoinable);

		[PreserveSig]
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x392948", Offset = "0x392948", VA = "0x392948")]
		public static extern ulong ISteamMatchmaking_GetLobbyOwner(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x392A18", Offset = "0x392A18", VA = "0x392A18")]
		public static extern bool ISteamMatchmaking_SetLobbyOwner(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDNewOwner);

		[PreserveSig]
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x392B00", Offset = "0x392B00", VA = "0x392B00")]
		public static extern bool ISteamMatchmaking_SetLinkedLobby(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDLobbyDependent);

		[PreserveSig]
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x392BE8", Offset = "0x392BE8", VA = "0x392BE8")]
		public static extern IntPtr ISteamMatchmakingServers_RequestInternetServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x392CC4", Offset = "0x392CC4", VA = "0x392CC4")]
		public static extern IntPtr ISteamMatchmakingServers_RequestLANServerList(IntPtr instancePtr, AppId_t iApp, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x392D94", Offset = "0x392D94", VA = "0x392D94")]
		public static extern IntPtr ISteamMatchmakingServers_RequestFriendsServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x392E70", Offset = "0x392E70", VA = "0x392E70")]
		public static extern IntPtr ISteamMatchmakingServers_RequestFavoritesServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x392F4C", Offset = "0x392F4C", VA = "0x392F4C")]
		public static extern IntPtr ISteamMatchmakingServers_RequestHistoryServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x393028", Offset = "0x393028", VA = "0x393028")]
		public static extern IntPtr ISteamMatchmakingServers_RequestSpectatorServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x393104", Offset = "0x393104", VA = "0x393104")]
		public static extern void ISteamMatchmakingServers_ReleaseRequest(IntPtr instancePtr, HServerListRequest hServerListRequest);

		[PreserveSig]
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x3931CC", Offset = "0x3931CC", VA = "0x3931CC")]
		public static extern IntPtr ISteamMatchmakingServers_GetServerDetails(IntPtr instancePtr, HServerListRequest hRequest, int iServer);

		[PreserveSig]
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x39329C", Offset = "0x39329C", VA = "0x39329C")]
		public static extern void ISteamMatchmakingServers_CancelQuery(IntPtr instancePtr, HServerListRequest hRequest);

		[PreserveSig]
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x393364", Offset = "0x393364", VA = "0x393364")]
		public static extern void ISteamMatchmakingServers_RefreshQuery(IntPtr instancePtr, HServerListRequest hRequest);

		[PreserveSig]
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x39342C", Offset = "0x39342C", VA = "0x39342C")]
		public static extern bool ISteamMatchmakingServers_IsRefreshing(IntPtr instancePtr, HServerListRequest hRequest);

		[PreserveSig]
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x393500", Offset = "0x393500", VA = "0x393500")]
		public static extern int ISteamMatchmakingServers_GetServerCount(IntPtr instancePtr, HServerListRequest hRequest);

		[PreserveSig]
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x3935C8", Offset = "0x3935C8", VA = "0x3935C8")]
		public static extern void ISteamMatchmakingServers_RefreshServer(IntPtr instancePtr, HServerListRequest hRequest, int iServer);

		[PreserveSig]
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x393698", Offset = "0x393698", VA = "0x393698")]
		public static extern int ISteamMatchmakingServers_PingServer(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x39376C", Offset = "0x39376C", VA = "0x39376C")]
		public static extern int ISteamMatchmakingServers_PlayerDetails(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x393840", Offset = "0x393840", VA = "0x393840")]
		public static extern int ISteamMatchmakingServers_ServerRules(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		[PreserveSig]
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x393914", Offset = "0x393914", VA = "0x393914")]
		public static extern void ISteamMatchmakingServers_CancelServerQuery(IntPtr instancePtr, HServerQuery hServerQuery);

		[PreserveSig]
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x3939DC", Offset = "0x3939DC", VA = "0x3939DC")]
		public static extern bool ISteamMusic_BIsEnabled(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x393AA8", Offset = "0x393AA8", VA = "0x393AA8")]
		public static extern bool ISteamMusic_BIsPlaying(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x393B74", Offset = "0x393B74", VA = "0x393B74")]
		public static extern AudioPlayback_Status ISteamMusic_GetPlaybackStatus(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x393C34", Offset = "0x393C34", VA = "0x393C34")]
		public static extern void ISteamMusic_Play(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x393CF4", Offset = "0x393CF4", VA = "0x393CF4")]
		public static extern void ISteamMusic_Pause(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x393DB4", Offset = "0x393DB4", VA = "0x393DB4")]
		public static extern void ISteamMusic_PlayPrevious(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x393E74", Offset = "0x393E74", VA = "0x393E74")]
		public static extern void ISteamMusic_PlayNext(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x393F34", Offset = "0x393F34", VA = "0x393F34")]
		public static extern void ISteamMusic_SetVolume(IntPtr instancePtr, float flVolume);

		[PreserveSig]
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x393FFC", Offset = "0x393FFC", VA = "0x393FFC")]
		public static extern float ISteamMusic_GetVolume(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x3940BC", Offset = "0x3940BC", VA = "0x3940BC")]
		public static extern bool ISteamMusicRemote_RegisterSteamMusicRemote(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x3940E4", Offset = "0x3940E4", VA = "0x3940E4")]
		public static extern bool ISteamMusicRemote_DeregisterSteamMusicRemote(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x3941B0", Offset = "0x3941B0", VA = "0x3941B0")]
		public static extern bool ISteamMusicRemote_BIsCurrentMusicRemote(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x39427C", Offset = "0x39427C", VA = "0x39427C")]
		public static extern bool ISteamMusicRemote_BActivationSuccess(IntPtr instancePtr, bool bValue);

		[PreserveSig]
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x394350", Offset = "0x394350", VA = "0x394350")]
		public static extern bool ISteamMusicRemote_SetDisplayName(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDisplayName);

		[PreserveSig]
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x394378", Offset = "0x394378", VA = "0x394378")]
		public static extern bool ISteamMusicRemote_SetPNGIcon_64x64(IntPtr instancePtr, byte[] pvBuffer, uint cbBufferLength);

		[PreserveSig]
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x39445C", Offset = "0x39445C", VA = "0x39445C")]
		public static extern bool ISteamMusicRemote_EnablePlayPrevious(IntPtr instancePtr, bool bValue);

		[PreserveSig]
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x394530", Offset = "0x394530", VA = "0x394530")]
		public static extern bool ISteamMusicRemote_EnablePlayNext(IntPtr instancePtr, bool bValue);

		[PreserveSig]
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x394604", Offset = "0x394604", VA = "0x394604")]
		public static extern bool ISteamMusicRemote_EnableShuffled(IntPtr instancePtr, bool bValue);

		[PreserveSig]
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x3946D8", Offset = "0x3946D8", VA = "0x3946D8")]
		public static extern bool ISteamMusicRemote_EnableLooped(IntPtr instancePtr, bool bValue);

		[PreserveSig]
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x3947AC", Offset = "0x3947AC", VA = "0x3947AC")]
		public static extern bool ISteamMusicRemote_EnableQueue(IntPtr instancePtr, bool bValue);

		[PreserveSig]
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x394880", Offset = "0x394880", VA = "0x394880")]
		public static extern bool ISteamMusicRemote_EnablePlaylists(IntPtr instancePtr, bool bValue);

		[PreserveSig]
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x394954", Offset = "0x394954", VA = "0x394954")]
		public static extern bool ISteamMusicRemote_UpdatePlaybackStatus(IntPtr instancePtr, AudioPlayback_Status nStatus);

		[PreserveSig]
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x394A28", Offset = "0x394A28", VA = "0x394A28")]
		public static extern bool ISteamMusicRemote_UpdateShuffled(IntPtr instancePtr, bool bValue);

		[PreserveSig]
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x394AFC", Offset = "0x394AFC", VA = "0x394AFC")]
		public static extern bool ISteamMusicRemote_UpdateLooped(IntPtr instancePtr, bool bValue);

		[PreserveSig]
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x394BD0", Offset = "0x394BD0", VA = "0x394BD0")]
		public static extern bool ISteamMusicRemote_UpdateVolume(IntPtr instancePtr, float flValue);

		[PreserveSig]
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x394CA4", Offset = "0x394CA4", VA = "0x394CA4")]
		public static extern bool ISteamMusicRemote_CurrentEntryWillChange(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x394D70", Offset = "0x394D70", VA = "0x394D70")]
		public static extern bool ISteamMusicRemote_CurrentEntryIsAvailable(IntPtr instancePtr, bool bAvailable);

		[PreserveSig]
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x394E44", Offset = "0x394E44", VA = "0x394E44")]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryText(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchText);

		[PreserveSig]
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x394E6C", Offset = "0x394E6C", VA = "0x394E6C")]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds(IntPtr instancePtr, int nValue);

		[PreserveSig]
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x394F40", Offset = "0x394F40", VA = "0x394F40")]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryCoverArt(IntPtr instancePtr, byte[] pvBuffer, uint cbBufferLength);

		[PreserveSig]
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x395024", Offset = "0x395024", VA = "0x395024")]
		public static extern bool ISteamMusicRemote_CurrentEntryDidChange(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x3950F0", Offset = "0x3950F0", VA = "0x3950F0")]
		public static extern bool ISteamMusicRemote_QueueWillChange(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x3951BC", Offset = "0x3951BC", VA = "0x3951BC")]
		public static extern bool ISteamMusicRemote_ResetQueueEntries(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x395288", Offset = "0x395288", VA = "0x395288")]
		public static extern bool ISteamMusicRemote_SetQueueEntry(IntPtr instancePtr, int nID, int nPosition, InteropHelp.UTF8StringHandle pchEntryText);

		[PreserveSig]
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x3952B0", Offset = "0x3952B0", VA = "0x3952B0")]
		public static extern bool ISteamMusicRemote_SetCurrentQueueEntry(IntPtr instancePtr, int nID);

		[PreserveSig]
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x395384", Offset = "0x395384", VA = "0x395384")]
		public static extern bool ISteamMusicRemote_QueueDidChange(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x395450", Offset = "0x395450", VA = "0x395450")]
		public static extern bool ISteamMusicRemote_PlaylistWillChange(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x39551C", Offset = "0x39551C", VA = "0x39551C")]
		public static extern bool ISteamMusicRemote_ResetPlaylistEntries(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x3955E8", Offset = "0x3955E8", VA = "0x3955E8")]
		public static extern bool ISteamMusicRemote_SetPlaylistEntry(IntPtr instancePtr, int nID, int nPosition, InteropHelp.UTF8StringHandle pchEntryText);

		[PreserveSig]
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x395610", Offset = "0x395610", VA = "0x395610")]
		public static extern bool ISteamMusicRemote_SetCurrentPlaylistEntry(IntPtr instancePtr, int nID);

		[PreserveSig]
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x3956E4", Offset = "0x3956E4", VA = "0x3956E4")]
		public static extern bool ISteamMusicRemote_PlaylistDidChange(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x3957B0", Offset = "0x3957B0", VA = "0x3957B0")]
		public static extern bool ISteamNetworking_SendP2PPacket(IntPtr instancePtr, CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel);

		[PreserveSig]
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x3958B0", Offset = "0x3958B0", VA = "0x3958B0")]
		public static extern bool ISteamNetworking_IsP2PPacketAvailable(IntPtr instancePtr, out uint pcubMsgSize, int nChannel);

		[PreserveSig]
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x39599C", Offset = "0x39599C", VA = "0x39599C")]
		public static extern bool ISteamNetworking_ReadP2PPacket(IntPtr instancePtr, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel);

		[PreserveSig]
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x395AC0", Offset = "0x395AC0", VA = "0x395AC0")]
		public static extern bool ISteamNetworking_AcceptP2PSessionWithUser(IntPtr instancePtr, CSteamID steamIDRemote);

		[PreserveSig]
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x395B9C", Offset = "0x395B9C", VA = "0x395B9C")]
		public static extern bool ISteamNetworking_CloseP2PSessionWithUser(IntPtr instancePtr, CSteamID steamIDRemote);

		[PreserveSig]
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x395C78", Offset = "0x395C78", VA = "0x395C78")]
		public static extern bool ISteamNetworking_CloseP2PChannelWithUser(IntPtr instancePtr, CSteamID steamIDRemote, int nChannel);

		[PreserveSig]
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x395D58", Offset = "0x395D58", VA = "0x395D58")]
		public static extern bool ISteamNetworking_GetP2PSessionState(IntPtr instancePtr, CSteamID steamIDRemote, out P2PSessionState_t pConnectionState);

		[PreserveSig]
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x395E54", Offset = "0x395E54", VA = "0x395E54")]
		public static extern bool ISteamNetworking_AllowP2PPacketRelay(IntPtr instancePtr, bool bAllow);

		[PreserveSig]
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x395F28", Offset = "0x395F28", VA = "0x395F28")]
		public static extern uint ISteamNetworking_CreateListenSocket(IntPtr instancePtr, int nVirtualP2PPort, uint nIP, ushort nPort, bool bAllowUseOfPacketRelay);

		[PreserveSig]
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x396004", Offset = "0x396004", VA = "0x396004")]
		public static extern uint ISteamNetworking_CreateP2PConnectionSocket(IntPtr instancePtr, CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay);

		[PreserveSig]
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x3960E8", Offset = "0x3960E8", VA = "0x3960E8")]
		public static extern uint ISteamNetworking_CreateConnectionSocket(IntPtr instancePtr, uint nIP, ushort nPort, int nTimeoutSec);

		[PreserveSig]
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x3961BC", Offset = "0x3961BC", VA = "0x3961BC")]
		public static extern bool ISteamNetworking_DestroySocket(IntPtr instancePtr, SNetSocket_t hSocket, bool bNotifyRemoteEnd);

		[PreserveSig]
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x396298", Offset = "0x396298", VA = "0x396298")]
		public static extern bool ISteamNetworking_DestroyListenSocket(IntPtr instancePtr, SNetListenSocket_t hSocket, bool bNotifyRemoteEnd);

		[PreserveSig]
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x396374", Offset = "0x396374", VA = "0x396374")]
		public static extern bool ISteamNetworking_SendDataOnSocket(IntPtr instancePtr, SNetSocket_t hSocket, byte[] pubData, uint cubData, bool bReliable);

		[PreserveSig]
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x396464", Offset = "0x396464", VA = "0x396464")]
		public static extern bool ISteamNetworking_IsDataAvailableOnSocket(IntPtr instancePtr, SNetSocket_t hSocket, out uint pcubMsgSize);

		[PreserveSig]
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x396550", Offset = "0x396550", VA = "0x396550")]
		public static extern bool ISteamNetworking_RetrieveDataFromSocket(IntPtr instancePtr, SNetSocket_t hSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize);

		[PreserveSig]
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x396654", Offset = "0x396654", VA = "0x396654")]
		public static extern bool ISteamNetworking_IsDataAvailable(IntPtr instancePtr, SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket);

		[PreserveSig]
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x396754", Offset = "0x396754", VA = "0x396754")]
		public static extern bool ISteamNetworking_RetrieveData(IntPtr instancePtr, SNetListenSocket_t hListenSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket);

		[PreserveSig]
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x396870", Offset = "0x396870", VA = "0x396870")]
		public static extern bool ISteamNetworking_GetSocketInfo(IntPtr instancePtr, SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote);

		[PreserveSig]
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x3969A8", Offset = "0x3969A8", VA = "0x3969A8")]
		public static extern bool ISteamNetworking_GetListenSocketInfo(IntPtr instancePtr, SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort);

		[PreserveSig]
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x396AA8", Offset = "0x396AA8", VA = "0x396AA8")]
		public static extern ESNetSocketConnectionType ISteamNetworking_GetSocketConnectionType(IntPtr instancePtr, SNetSocket_t hSocket);

		[PreserveSig]
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x396B70", Offset = "0x396B70", VA = "0x396B70")]
		public static extern int ISteamNetworking_GetMaxPacketSize(IntPtr instancePtr, SNetSocket_t hSocket);

		[PreserveSig]
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x396C38", Offset = "0x396C38", VA = "0x396C38")]
		public static extern bool ISteamParentalSettings_BIsParentalLockEnabled(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x396D04", Offset = "0x396D04", VA = "0x396D04")]
		public static extern bool ISteamParentalSettings_BIsParentalLockLocked(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x396DD0", Offset = "0x396DD0", VA = "0x396DD0")]
		public static extern bool ISteamParentalSettings_BIsAppBlocked(IntPtr instancePtr, AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x396EA4", Offset = "0x396EA4", VA = "0x396EA4")]
		public static extern bool ISteamParentalSettings_BIsAppInBlockList(IntPtr instancePtr, AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x396F78", Offset = "0x396F78", VA = "0x396F78")]
		public static extern bool ISteamParentalSettings_BIsFeatureBlocked(IntPtr instancePtr, EParentalFeature eFeature);

		[PreserveSig]
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x39704C", Offset = "0x39704C", VA = "0x39704C")]
		public static extern bool ISteamParentalSettings_BIsFeatureInBlockList(IntPtr instancePtr, EParentalFeature eFeature);

		[PreserveSig]
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x397120", Offset = "0x397120", VA = "0x397120")]
		public static extern bool ISteamRemoteStorage_FileWrite(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, int cubData);

		[PreserveSig]
		[Token(Token = "0x6000665")]
		[Address(RVA = "0x397148", Offset = "0x397148", VA = "0x397148")]
		public static extern int ISteamRemoteStorage_FileRead(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, int cubDataToRead);

		[PreserveSig]
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x397170", Offset = "0x397170", VA = "0x397170")]
		public static extern ulong ISteamRemoteStorage_FileWriteAsync(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, uint cubData);

		[PreserveSig]
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x397198", Offset = "0x397198", VA = "0x397198")]
		public static extern ulong ISteamRemoteStorage_FileReadAsync(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, uint nOffset, uint cubToRead);

		[PreserveSig]
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x3971C0", Offset = "0x3971C0", VA = "0x3971C0")]
		public static extern bool ISteamRemoteStorage_FileReadAsyncComplete(IntPtr instancePtr, SteamAPICall_t hReadCall, byte[] pvBuffer, uint cubToRead);

		[PreserveSig]
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x3972B4", Offset = "0x3972B4", VA = "0x3972B4")]
		public static extern bool ISteamRemoteStorage_FileForget(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x600066A")]
		[Address(RVA = "0x3972DC", Offset = "0x3972DC", VA = "0x3972DC")]
		public static extern bool ISteamRemoteStorage_FileDelete(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x600066B")]
		[Address(RVA = "0x397304", Offset = "0x397304", VA = "0x397304")]
		public static extern ulong ISteamRemoteStorage_FileShare(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x39732C", Offset = "0x39732C", VA = "0x39732C")]
		public static extern bool ISteamRemoteStorage_SetSyncPlatforms(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, ERemoteStoragePlatform eRemoteStoragePlatform);

		[PreserveSig]
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x397354", Offset = "0x397354", VA = "0x397354")]
		public static extern ulong ISteamRemoteStorage_FileWriteStreamOpen(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x39737C", Offset = "0x39737C", VA = "0x39737C")]
		public static extern bool ISteamRemoteStorage_FileWriteStreamWriteChunk(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle, byte[] pvData, int cubData);

		[PreserveSig]
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x397470", Offset = "0x397470", VA = "0x397470")]
		public static extern bool ISteamRemoteStorage_FileWriteStreamClose(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle);

		[PreserveSig]
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x39754C", Offset = "0x39754C", VA = "0x39754C")]
		public static extern bool ISteamRemoteStorage_FileWriteStreamCancel(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle);

		[PreserveSig]
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x397628", Offset = "0x397628", VA = "0x397628")]
		public static extern bool ISteamRemoteStorage_FileExists(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x397650", Offset = "0x397650", VA = "0x397650")]
		public static extern bool ISteamRemoteStorage_FilePersisted(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x6000673")]
		[Address(RVA = "0x397678", Offset = "0x397678", VA = "0x397678")]
		public static extern int ISteamRemoteStorage_GetFileSize(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x3976A0", Offset = "0x3976A0", VA = "0x3976A0")]
		public static extern long ISteamRemoteStorage_GetFileTimestamp(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x3976C8", Offset = "0x3976C8", VA = "0x3976C8")]
		public static extern ERemoteStoragePlatform ISteamRemoteStorage_GetSyncPlatforms(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x3976F0", Offset = "0x3976F0", VA = "0x3976F0")]
		public static extern int ISteamRemoteStorage_GetFileCount(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000677")]
		[Address(RVA = "0x3977B0", Offset = "0x3977B0", VA = "0x3977B0")]
		public static extern IntPtr ISteamRemoteStorage_GetFileNameAndSize(IntPtr instancePtr, int iFile, out int pnFileSizeInBytes);

		[PreserveSig]
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x397890", Offset = "0x397890", VA = "0x397890")]
		public static extern bool ISteamRemoteStorage_GetQuota(IntPtr instancePtr, out ulong pnTotalBytes, out ulong puAvailableBytes);

		[PreserveSig]
		[Token(Token = "0x6000679")]
		[Address(RVA = "0x397994", Offset = "0x397994", VA = "0x397994")]
		public static extern bool ISteamRemoteStorage_IsCloudEnabledForAccount(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x600067A")]
		[Address(RVA = "0x397A60", Offset = "0x397A60", VA = "0x397A60")]
		public static extern bool ISteamRemoteStorage_IsCloudEnabledForApp(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x397B2C", Offset = "0x397B2C", VA = "0x397B2C")]
		public static extern void ISteamRemoteStorage_SetCloudEnabledForApp(IntPtr instancePtr, bool bEnabled);

		[PreserveSig]
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x397BF4", Offset = "0x397BF4", VA = "0x397BF4")]
		public static extern ulong ISteamRemoteStorage_UGCDownload(IntPtr instancePtr, UGCHandle_t hContent, uint unPriority);

		[PreserveSig]
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x397CCC", Offset = "0x397CCC", VA = "0x397CCC")]
		public static extern bool ISteamRemoteStorage_GetUGCDownloadProgress(IntPtr instancePtr, UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected);

		[PreserveSig]
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x397DDC", Offset = "0x397DDC", VA = "0x397DDC")]
		public static extern bool ISteamRemoteStorage_GetUGCDetails(IntPtr instancePtr, UGCHandle_t hContent, out AppId_t pnAppID, out IntPtr ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner);

		[PreserveSig]
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x397F24", Offset = "0x397F24", VA = "0x397F24")]
		public static extern int ISteamRemoteStorage_UGCRead(IntPtr instancePtr, UGCHandle_t hContent, byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction);

		[PreserveSig]
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x39801C", Offset = "0x39801C", VA = "0x39801C")]
		public static extern int ISteamRemoteStorage_GetCachedUGCCount(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x3980DC", Offset = "0x3980DC", VA = "0x3980DC")]
		public static extern ulong ISteamRemoteStorage_GetCachedUGCHandle(IntPtr instancePtr, int iCachedContent);

		[PreserveSig]
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x3981A4", Offset = "0x3981A4", VA = "0x3981A4")]
		public static extern ulong ISteamRemoteStorage_PublishWorkshopFile(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, InteropHelp.UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags, EWorkshopFileType eWorkshopFileType);

		[PreserveSig]
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x3981CC", Offset = "0x3981CC", VA = "0x3981CC")]
		public static extern ulong ISteamRemoteStorage_CreatePublishedFileUpdateRequest(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x39829C", Offset = "0x39829C", VA = "0x39829C")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileFile(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x3982C4", Offset = "0x3982C4", VA = "0x3982C4")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFilePreviewFile(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchPreviewFile);

		[PreserveSig]
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x3982EC", Offset = "0x3982EC", VA = "0x3982EC")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileTitle(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchTitle);

		[PreserveSig]
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x398314", Offset = "0x398314", VA = "0x398314")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileDescription(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchDescription);

		[PreserveSig]
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x39833C", Offset = "0x39833C", VA = "0x39833C")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileVisibility(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility);

		[PreserveSig]
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x398420", Offset = "0x398420", VA = "0x398420")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileTags(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, IntPtr pTags);

		[PreserveSig]
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x398504", Offset = "0x398504", VA = "0x398504")]
		public static extern ulong ISteamRemoteStorage_CommitPublishedFileUpdate(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle);

		[PreserveSig]
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x3985D4", Offset = "0x3985D4", VA = "0x3985D4")]
		public static extern ulong ISteamRemoteStorage_GetPublishedFileDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld);

		[PreserveSig]
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x3986AC", Offset = "0x3986AC", VA = "0x3986AC")]
		public static extern ulong ISteamRemoteStorage_DeletePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x39877C", Offset = "0x39877C", VA = "0x39877C")]
		public static extern ulong ISteamRemoteStorage_EnumerateUserPublishedFiles(IntPtr instancePtr, uint unStartIndex);

		[PreserveSig]
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x398844", Offset = "0x398844", VA = "0x398844")]
		public static extern ulong ISteamRemoteStorage_SubscribePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x398914", Offset = "0x398914", VA = "0x398914")]
		public static extern ulong ISteamRemoteStorage_EnumerateUserSubscribedFiles(IntPtr instancePtr, uint unStartIndex);

		[PreserveSig]
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x3989DC", Offset = "0x3989DC", VA = "0x3989DC")]
		public static extern ulong ISteamRemoteStorage_UnsubscribePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x398AAC", Offset = "0x398AAC", VA = "0x398AAC")]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchChangeDescription);

		[PreserveSig]
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x398AD4", Offset = "0x398AD4", VA = "0x398AD4")]
		public static extern ulong ISteamRemoteStorage_GetPublishedItemVoteDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x398BA4", Offset = "0x398BA4", VA = "0x398BA4")]
		public static extern ulong ISteamRemoteStorage_UpdateUserPublishedItemVote(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, bool bVoteUp);

		[PreserveSig]
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x398C7C", Offset = "0x398C7C", VA = "0x398C7C")]
		public static extern ulong ISteamRemoteStorage_GetUserPublishedItemVoteDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId);

		[PreserveSig]
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x398D4C", Offset = "0x398D4C", VA = "0x398D4C")]
		public static extern ulong ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles(IntPtr instancePtr, CSteamID steamId, uint unStartIndex, IntPtr pRequiredTags, IntPtr pExcludedTags);

		[PreserveSig]
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x398E30", Offset = "0x398E30", VA = "0x398E30")]
		public static extern ulong ISteamRemoteStorage_PublishVideo(IntPtr instancePtr, EWorkshopVideoProvider eVideoProvider, InteropHelp.UTF8StringHandle pchVideoAccount, InteropHelp.UTF8StringHandle pchVideoIdentifier, InteropHelp.UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags);

		[PreserveSig]
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x398E58", Offset = "0x398E58", VA = "0x398E58")]
		public static extern ulong ISteamRemoteStorage_SetUserPublishedFileAction(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction);

		[PreserveSig]
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x398F30", Offset = "0x398F30", VA = "0x398F30")]
		public static extern ulong ISteamRemoteStorage_EnumeratePublishedFilesByUserAction(IntPtr instancePtr, EWorkshopFileAction eAction, uint unStartIndex);

		[PreserveSig]
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x399000", Offset = "0x399000", VA = "0x399000")]
		public static extern ulong ISteamRemoteStorage_EnumeratePublishedWorkshopFiles(IntPtr instancePtr, EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IntPtr pTags, IntPtr pUserTags);

		[PreserveSig]
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x3990EC", Offset = "0x3990EC", VA = "0x3990EC")]
		public static extern ulong ISteamRemoteStorage_UGCDownloadToLocation(IntPtr instancePtr, UGCHandle_t hContent, InteropHelp.UTF8StringHandle pchLocation, uint unPriority);

		[PreserveSig]
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x399114", Offset = "0x399114", VA = "0x399114")]
		public static extern uint ISteamScreenshots_WriteScreenshot(IntPtr instancePtr, byte[] pubRGB, uint cubRGB, int nWidth, int nHeight);

		[PreserveSig]
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x3991F8", Offset = "0x3991F8", VA = "0x3991F8")]
		public static extern uint ISteamScreenshots_AddScreenshotToLibrary(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFilename, InteropHelp.UTF8StringHandle pchThumbnailFilename, int nWidth, int nHeight);

		[PreserveSig]
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x399220", Offset = "0x399220", VA = "0x399220")]
		public static extern void ISteamScreenshots_TriggerScreenshot(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x3992E0", Offset = "0x3992E0", VA = "0x3992E0")]
		public static extern void ISteamScreenshots_HookScreenshots(IntPtr instancePtr, bool bHook);

		[PreserveSig]
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x3993A8", Offset = "0x3993A8", VA = "0x3993A8")]
		public static extern bool ISteamScreenshots_SetLocation(IntPtr instancePtr, ScreenshotHandle hScreenshot, InteropHelp.UTF8StringHandle pchLocation);

		[PreserveSig]
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x3993D0", Offset = "0x3993D0", VA = "0x3993D0")]
		public static extern bool ISteamScreenshots_TagUser(IntPtr instancePtr, ScreenshotHandle hScreenshot, CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x3994B0", Offset = "0x3994B0", VA = "0x3994B0")]
		public static extern bool ISteamScreenshots_TagPublishedFile(IntPtr instancePtr, ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x39958C", Offset = "0x39958C", VA = "0x39958C")]
		public static extern bool ISteamScreenshots_IsScreenshotsHooked(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x399658", Offset = "0x399658", VA = "0x399658")]
		public static extern uint ISteamScreenshots_AddVRScreenshotToLibrary(IntPtr instancePtr, EVRScreenshotType eType, InteropHelp.UTF8StringHandle pchFilename, InteropHelp.UTF8StringHandle pchVRFilename);

		[PreserveSig]
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x399680", Offset = "0x399680", VA = "0x399680")]
		public static extern ulong ISteamUGC_CreateQueryUserUGCRequest(IntPtr instancePtr, AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		[PreserveSig]
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x399774", Offset = "0x399774", VA = "0x399774")]
		public static extern ulong ISteamUGC_CreateQueryAllUGCRequest(IntPtr instancePtr, EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		[PreserveSig]
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x399858", Offset = "0x399858", VA = "0x399858")]
		public static extern ulong ISteamUGC_CreateQueryUGCDetailsRequest(IntPtr instancePtr, [In][Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		[PreserveSig]
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x399930", Offset = "0x399930", VA = "0x399930")]
		public static extern ulong ISteamUGC_SendQueryUGCRequest(IntPtr instancePtr, UGCQueryHandle_t handle);

		[PreserveSig]
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x399A00", Offset = "0x399A00", VA = "0x399A00")]
		public static extern bool ISteamUGC_GetQueryUGCResult(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails);

		[PreserveSig]
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x399B34", Offset = "0x399B34", VA = "0x399B34")]
		public static extern bool ISteamUGC_GetQueryUGCPreviewURL(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, IntPtr pchURL, uint cchURLSize);

		[PreserveSig]
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x399C28", Offset = "0x399C28", VA = "0x399C28")]
		public static extern bool ISteamUGC_GetQueryUGCMetadata(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, IntPtr pchMetadata, uint cchMetadatasize);

		[PreserveSig]
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x399D1C", Offset = "0x399D1C", VA = "0x399D1C")]
		public static extern bool ISteamUGC_GetQueryUGCChildren(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, [In][Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		[PreserveSig]
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x399E18", Offset = "0x399E18", VA = "0x399E18")]
		public static extern bool ISteamUGC_GetQueryUGCStatistic(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue);

		[PreserveSig]
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x399F24", Offset = "0x399F24", VA = "0x399F24")]
		public static extern uint ISteamUGC_GetQueryUGCNumAdditionalPreviews(IntPtr instancePtr, UGCQueryHandle_t handle, uint index);

		[PreserveSig]
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x399FFC", Offset = "0x399FFC", VA = "0x399FFC")]
		public static extern bool ISteamUGC_GetQueryUGCAdditionalPreview(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint previewIndex, IntPtr pchURLOrVideoID, uint cchURLSize, IntPtr pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType);

		[PreserveSig]
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x39A104", Offset = "0x39A104", VA = "0x39A104")]
		public static extern uint ISteamUGC_GetQueryUGCNumKeyValueTags(IntPtr instancePtr, UGCQueryHandle_t handle, uint index);

		[PreserveSig]
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x39A1DC", Offset = "0x39A1DC", VA = "0x39A1DC")]
		public static extern bool ISteamUGC_GetQueryUGCKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, IntPtr pchKey, uint cchKeySize, IntPtr pchValue, uint cchValueSize);

		[PreserveSig]
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x39A2E4", Offset = "0x39A2E4", VA = "0x39A2E4")]
		public static extern bool ISteamUGC_ReleaseQueryUGCRequest(IntPtr instancePtr, UGCQueryHandle_t handle);

		[PreserveSig]
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x39A3C0", Offset = "0x39A3C0", VA = "0x39A3C0")]
		public static extern bool ISteamUGC_AddRequiredTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		[PreserveSig]
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x39A3E8", Offset = "0x39A3E8", VA = "0x39A3E8")]
		public static extern bool ISteamUGC_AddExcludedTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		[PreserveSig]
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x39A410", Offset = "0x39A410", VA = "0x39A410")]
		public static extern bool ISteamUGC_SetReturnOnlyIDs(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnOnlyIDs);

		[PreserveSig]
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x39A4F4", Offset = "0x39A4F4", VA = "0x39A4F4")]
		public static extern bool ISteamUGC_SetReturnKeyValueTags(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnKeyValueTags);

		[PreserveSig]
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x39A5D8", Offset = "0x39A5D8", VA = "0x39A5D8")]
		public static extern bool ISteamUGC_SetReturnLongDescription(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnLongDescription);

		[PreserveSig]
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x39A6BC", Offset = "0x39A6BC", VA = "0x39A6BC")]
		public static extern bool ISteamUGC_SetReturnMetadata(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnMetadata);

		[PreserveSig]
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x39A7A0", Offset = "0x39A7A0", VA = "0x39A7A0")]
		public static extern bool ISteamUGC_SetReturnChildren(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnChildren);

		[PreserveSig]
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x39A884", Offset = "0x39A884", VA = "0x39A884")]
		public static extern bool ISteamUGC_SetReturnAdditionalPreviews(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnAdditionalPreviews);

		[PreserveSig]
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x39A968", Offset = "0x39A968", VA = "0x39A968")]
		public static extern bool ISteamUGC_SetReturnTotalOnly(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnTotalOnly);

		[PreserveSig]
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x39AA4C", Offset = "0x39AA4C", VA = "0x39AA4C")]
		public static extern bool ISteamUGC_SetReturnPlaytimeStats(IntPtr instancePtr, UGCQueryHandle_t handle, uint unDays);

		[PreserveSig]
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x39AB30", Offset = "0x39AB30", VA = "0x39AB30")]
		public static extern bool ISteamUGC_SetLanguage(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		[PreserveSig]
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x39AB58", Offset = "0x39AB58", VA = "0x39AB58")]
		public static extern bool ISteamUGC_SetAllowCachedResponse(IntPtr instancePtr, UGCQueryHandle_t handle, uint unMaxAgeSeconds);

		[PreserveSig]
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x39AC3C", Offset = "0x39AC3C", VA = "0x39AC3C")]
		public static extern bool ISteamUGC_SetCloudFileNameFilter(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pMatchCloudFileName);

		[PreserveSig]
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x39AC64", Offset = "0x39AC64", VA = "0x39AC64")]
		public static extern bool ISteamUGC_SetMatchAnyTag(IntPtr instancePtr, UGCQueryHandle_t handle, bool bMatchAnyTag);

		[PreserveSig]
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x39AD48", Offset = "0x39AD48", VA = "0x39AD48")]
		public static extern bool ISteamUGC_SetSearchText(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pSearchText);

		[PreserveSig]
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x39AD70", Offset = "0x39AD70", VA = "0x39AD70")]
		public static extern bool ISteamUGC_SetRankedByTrendDays(IntPtr instancePtr, UGCQueryHandle_t handle, uint unDays);

		[PreserveSig]
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x39AE54", Offset = "0x39AE54", VA = "0x39AE54")]
		public static extern bool ISteamUGC_AddRequiredKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue);

		[PreserveSig]
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x39AE7C", Offset = "0x39AE7C", VA = "0x39AE7C")]
		public static extern ulong ISteamUGC_RequestUGCDetails(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds);

		[PreserveSig]
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x39AF54", Offset = "0x39AF54", VA = "0x39AF54")]
		public static extern ulong ISteamUGC_CreateItem(IntPtr instancePtr, AppId_t nConsumerAppId, EWorkshopFileType eFileType);

		[PreserveSig]
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x39B024", Offset = "0x39B024", VA = "0x39B024")]
		public static extern ulong ISteamUGC_StartItemUpdate(IntPtr instancePtr, AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x39B0F4", Offset = "0x39B0F4", VA = "0x39B0F4")]
		public static extern bool ISteamUGC_SetItemTitle(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchTitle);

		[PreserveSig]
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x39B11C", Offset = "0x39B11C", VA = "0x39B11C")]
		public static extern bool ISteamUGC_SetItemDescription(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchDescription);

		[PreserveSig]
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x39B144", Offset = "0x39B144", VA = "0x39B144")]
		public static extern bool ISteamUGC_SetItemUpdateLanguage(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		[PreserveSig]
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x39B16C", Offset = "0x39B16C", VA = "0x39B16C")]
		public static extern bool ISteamUGC_SetItemMetadata(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchMetaData);

		[PreserveSig]
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x39B194", Offset = "0x39B194", VA = "0x39B194")]
		public static extern bool ISteamUGC_SetItemVisibility(IntPtr instancePtr, UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility);

		[PreserveSig]
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x39B278", Offset = "0x39B278", VA = "0x39B278")]
		public static extern bool ISteamUGC_SetItemTags(IntPtr instancePtr, UGCUpdateHandle_t updateHandle, IntPtr pTags);

		[PreserveSig]
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x39B35C", Offset = "0x39B35C", VA = "0x39B35C")]
		public static extern bool ISteamUGC_SetItemContent(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszContentFolder);

		[PreserveSig]
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x39B384", Offset = "0x39B384", VA = "0x39B384")]
		public static extern bool ISteamUGC_SetItemPreview(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile);

		[PreserveSig]
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x39B3AC", Offset = "0x39B3AC", VA = "0x39B3AC")]
		public static extern bool ISteamUGC_RemoveItemKeyValueTags(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x39B3D4", Offset = "0x39B3D4", VA = "0x39B3D4")]
		public static extern bool ISteamUGC_AddItemKeyValueTag(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[PreserveSig]
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x39B3FC", Offset = "0x39B3FC", VA = "0x39B3FC")]
		public static extern bool ISteamUGC_AddItemPreviewFile(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile, EItemPreviewType type);

		[PreserveSig]
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x39B424", Offset = "0x39B424", VA = "0x39B424")]
		public static extern bool ISteamUGC_AddItemPreviewVideo(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszVideoID);

		[PreserveSig]
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x39B44C", Offset = "0x39B44C", VA = "0x39B44C")]
		public static extern bool ISteamUGC_UpdateItemPreviewFile(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index, InteropHelp.UTF8StringHandle pszPreviewFile);

		[PreserveSig]
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x39B474", Offset = "0x39B474", VA = "0x39B474")]
		public static extern bool ISteamUGC_UpdateItemPreviewVideo(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index, InteropHelp.UTF8StringHandle pszVideoID);

		[PreserveSig]
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x39B49C", Offset = "0x39B49C", VA = "0x39B49C")]
		public static extern bool ISteamUGC_RemoveItemPreview(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index);

		[PreserveSig]
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x39B580", Offset = "0x39B580", VA = "0x39B580")]
		public static extern ulong ISteamUGC_SubmitItemUpdate(IntPtr instancePtr, UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchChangeNote);

		[PreserveSig]
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x39B5A8", Offset = "0x39B5A8", VA = "0x39B5A8")]
		public static extern EItemUpdateStatus ISteamUGC_GetItemUpdateProgress(IntPtr instancePtr, UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal);

		[PreserveSig]
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x39B6BC", Offset = "0x39B6BC", VA = "0x39B6BC")]
		public static extern ulong ISteamUGC_SetUserItemVote(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, bool bVoteUp);

		[PreserveSig]
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x39B794", Offset = "0x39B794", VA = "0x39B794")]
		public static extern ulong ISteamUGC_GetUserItemVote(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x39B864", Offset = "0x39B864", VA = "0x39B864")]
		public static extern ulong ISteamUGC_AddItemToFavorites(IntPtr instancePtr, AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x39B934", Offset = "0x39B934", VA = "0x39B934")]
		public static extern ulong ISteamUGC_RemoveItemFromFavorites(IntPtr instancePtr, AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x39BA04", Offset = "0x39BA04", VA = "0x39BA04")]
		public static extern ulong ISteamUGC_SubscribeItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x39BAD4", Offset = "0x39BAD4", VA = "0x39BAD4")]
		public static extern ulong ISteamUGC_UnsubscribeItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x39BBA4", Offset = "0x39BBA4", VA = "0x39BBA4")]
		public static extern uint ISteamUGC_GetNumSubscribedItems(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x39BC64", Offset = "0x39BC64", VA = "0x39BC64")]
		public static extern uint ISteamUGC_GetSubscribedItems(IntPtr instancePtr, [In][Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		[PreserveSig]
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x39BD3C", Offset = "0x39BD3C", VA = "0x39BD3C")]
		public static extern uint ISteamUGC_GetItemState(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x39BE0C", Offset = "0x39BE0C", VA = "0x39BE0C")]
		public static extern bool ISteamUGC_GetItemInstallInfo(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, out uint punTimeStamp);

		[PreserveSig]
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x39BF34", Offset = "0x39BF34", VA = "0x39BF34")]
		public static extern bool ISteamUGC_GetItemDownloadInfo(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal);

		[PreserveSig]
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x39C054", Offset = "0x39C054", VA = "0x39C054")]
		public static extern bool ISteamUGC_DownloadItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, bool bHighPriority);

		[PreserveSig]
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x39C138", Offset = "0x39C138", VA = "0x39C138")]
		public static extern bool ISteamUGC_BInitWorkshopForGameServer(IntPtr instancePtr, DepotId_t unWorkshopDepotID, InteropHelp.UTF8StringHandle pszFolder);

		[PreserveSig]
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x39C160", Offset = "0x39C160", VA = "0x39C160")]
		public static extern void ISteamUGC_SuspendDownloads(IntPtr instancePtr, bool bSuspend);

		[PreserveSig]
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x39C228", Offset = "0x39C228", VA = "0x39C228")]
		public static extern ulong ISteamUGC_StartPlaytimeTracking(IntPtr instancePtr, [In][Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		[PreserveSig]
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x39C300", Offset = "0x39C300", VA = "0x39C300")]
		public static extern ulong ISteamUGC_StopPlaytimeTracking(IntPtr instancePtr, [In][Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		[PreserveSig]
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x39C3D8", Offset = "0x39C3D8", VA = "0x39C3D8")]
		public static extern ulong ISteamUGC_StopPlaytimeTrackingForAllItems(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x39C498", Offset = "0x39C498", VA = "0x39C498")]
		public static extern ulong ISteamUGC_AddDependency(IntPtr instancePtr, PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x39C578", Offset = "0x39C578", VA = "0x39C578")]
		public static extern ulong ISteamUGC_RemoveDependency(IntPtr instancePtr, PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x39C658", Offset = "0x39C658", VA = "0x39C658")]
		public static extern ulong ISteamUGC_AddAppDependency(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x39C730", Offset = "0x39C730", VA = "0x39C730")]
		public static extern ulong ISteamUGC_RemoveAppDependency(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, AppId_t nAppID);

		[PreserveSig]
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x39C808", Offset = "0x39C808", VA = "0x39C808")]
		public static extern ulong ISteamUGC_GetAppDependencies(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x39C8D8", Offset = "0x39C8D8", VA = "0x39C8D8")]
		public static extern ulong ISteamUGC_DeleteItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID);

		[PreserveSig]
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x39C9A8", Offset = "0x39C9A8", VA = "0x39C9A8")]
		public static extern ulong ISteamUnifiedMessages_SendMethod(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchServiceMethod, byte[] pRequestBuffer, uint unRequestBufferSize, ulong unContext);

		[PreserveSig]
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x39C9D0", Offset = "0x39C9D0", VA = "0x39C9D0")]
		public static extern bool ISteamUnifiedMessages_GetMethodResponseInfo(IntPtr instancePtr, ClientUnifiedMessageHandle hHandle, out uint punResponseSize, out EResult peResult);

		[PreserveSig]
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x39CAD0", Offset = "0x39CAD0", VA = "0x39CAD0")]
		public static extern bool ISteamUnifiedMessages_GetMethodResponseData(IntPtr instancePtr, ClientUnifiedMessageHandle hHandle, byte[] pResponseBuffer, uint unResponseBufferSize, bool bAutoRelease);

		[PreserveSig]
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x39CBCC", Offset = "0x39CBCC", VA = "0x39CBCC")]
		public static extern bool ISteamUnifiedMessages_ReleaseMethod(IntPtr instancePtr, ClientUnifiedMessageHandle hHandle);

		[PreserveSig]
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x39CCA8", Offset = "0x39CCA8", VA = "0x39CCA8")]
		public static extern bool ISteamUnifiedMessages_SendNotification(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchServiceNotification, byte[] pNotificationBuffer, uint unNotificationBufferSize);

		[PreserveSig]
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x39CCD0", Offset = "0x39CCD0", VA = "0x39CCD0")]
		public static extern int ISteamUser_GetHSteamUser(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x39CD90", Offset = "0x39CD90", VA = "0x39CD90")]
		public static extern bool ISteamUser_BLoggedOn(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x39CE5C", Offset = "0x39CE5C", VA = "0x39CE5C")]
		public static extern ulong ISteamUser_GetSteamID(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x39CF1C", Offset = "0x39CF1C", VA = "0x39CF1C")]
		public static extern int ISteamUser_InitiateGameConnection(IntPtr instancePtr, byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure);

		[PreserveSig]
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x39D014", Offset = "0x39D014", VA = "0x39D014")]
		public static extern void ISteamUser_TerminateGameConnection(IntPtr instancePtr, uint unIPServer, ushort usPortServer);

		[PreserveSig]
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x39D0E4", Offset = "0x39D0E4", VA = "0x39D0E4")]
		public static extern void ISteamUser_TrackAppUsageEvent(IntPtr instancePtr, CGameID gameID, int eAppUsageEvent, InteropHelp.UTF8StringHandle pchExtraInfo);

		[PreserveSig]
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x39D10C", Offset = "0x39D10C", VA = "0x39D10C")]
		public static extern bool ISteamUser_GetUserDataFolder(IntPtr instancePtr, IntPtr pchBuffer, int cubBuffer);

		[PreserveSig]
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x39D1E8", Offset = "0x39D1E8", VA = "0x39D1E8")]
		public static extern void ISteamUser_StartVoiceRecording(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x39D2A8", Offset = "0x39D2A8", VA = "0x39D2A8")]
		public static extern void ISteamUser_StopVoiceRecording(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x39D368", Offset = "0x39D368", VA = "0x39D368")]
		public static extern EVoiceResult ISteamUser_GetAvailableVoice(IntPtr instancePtr, out uint pcbCompressed, IntPtr pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated);

		[PreserveSig]
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x39D44C", Offset = "0x39D44C", VA = "0x39D44C")]
		public static extern EVoiceResult ISteamUser_GetVoice(IntPtr instancePtr, bool bWantCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, IntPtr nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated);

		[PreserveSig]
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x39D564", Offset = "0x39D564", VA = "0x39D564")]
		public static extern EVoiceResult ISteamUser_DecompressVoice(IntPtr instancePtr, byte[] pCompressed, uint cbCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate);

		[PreserveSig]
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x39D670", Offset = "0x39D670", VA = "0x39D670")]
		public static extern uint ISteamUser_GetVoiceOptimalSampleRate(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x39D730", Offset = "0x39D730", VA = "0x39D730")]
		public static extern uint ISteamUser_GetAuthSessionTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		[PreserveSig]
		[Token(Token = "0x6000701")]
		[Address(RVA = "0x39D820", Offset = "0x39D820", VA = "0x39D820")]
		public static extern EBeginAuthSessionResult ISteamUser_BeginAuthSession(IntPtr instancePtr, byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x6000702")]
		[Address(RVA = "0x39D904", Offset = "0x39D904", VA = "0x39D904")]
		public static extern void ISteamUser_EndAuthSession(IntPtr instancePtr, CSteamID steamID);

		[PreserveSig]
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x39D9D4", Offset = "0x39D9D4", VA = "0x39D9D4")]
		public static extern void ISteamUser_CancelAuthTicket(IntPtr instancePtr, HAuthTicket hAuthTicket);

		[PreserveSig]
		[Token(Token = "0x6000704")]
		[Address(RVA = "0x39DA9C", Offset = "0x39DA9C", VA = "0x39DA9C")]
		public static extern EUserHasLicenseForAppResult ISteamUser_UserHasLicenseForApp(IntPtr instancePtr, CSteamID steamID, AppId_t appID);

		[PreserveSig]
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x39DB70", Offset = "0x39DB70", VA = "0x39DB70")]
		public static extern bool ISteamUser_BIsBehindNAT(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x39DC3C", Offset = "0x39DC3C", VA = "0x39DC3C")]
		public static extern void ISteamUser_AdvertiseGame(IntPtr instancePtr, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer);

		[PreserveSig]
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x39DD18", Offset = "0x39DD18", VA = "0x39DD18")]
		public static extern ulong ISteamUser_RequestEncryptedAppTicket(IntPtr instancePtr, byte[] pDataToInclude, int cbDataToInclude);

		[PreserveSig]
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x39DDF0", Offset = "0x39DDF0", VA = "0x39DDF0")]
		public static extern bool ISteamUser_GetEncryptedAppTicket(IntPtr instancePtr, byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		[PreserveSig]
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x39DEEC", Offset = "0x39DEEC", VA = "0x39DEEC")]
		public static extern int ISteamUser_GetGameBadgeLevel(IntPtr instancePtr, int nSeries, bool bFoil);

		[PreserveSig]
		[Token(Token = "0x600070A")]
		[Address(RVA = "0x39DFBC", Offset = "0x39DFBC", VA = "0x39DFBC")]
		public static extern int ISteamUser_GetPlayerSteamLevel(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x39E07C", Offset = "0x39E07C", VA = "0x39E07C")]
		public static extern ulong ISteamUser_RequestStoreAuthURL(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchRedirectURL);

		[PreserveSig]
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x39E0A4", Offset = "0x39E0A4", VA = "0x39E0A4")]
		public static extern bool ISteamUser_BIsPhoneVerified(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x39E170", Offset = "0x39E170", VA = "0x39E170")]
		public static extern bool ISteamUser_BIsTwoFactorEnabled(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x39E23C", Offset = "0x39E23C", VA = "0x39E23C")]
		public static extern bool ISteamUser_BIsPhoneIdentifying(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x39E308", Offset = "0x39E308", VA = "0x39E308")]
		public static extern bool ISteamUser_BIsPhoneRequiringVerification(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x39E3D4", Offset = "0x39E3D4", VA = "0x39E3D4")]
		public static extern bool ISteamUserStats_RequestCurrentStats(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x39E4A0", Offset = "0x39E4A0", VA = "0x39E4A0")]
		public static extern bool ISteamUserStats_GetStat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out int pData);

		[PreserveSig]
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x39E4C8", Offset = "0x39E4C8", VA = "0x39E4C8")]
		public static extern bool ISteamUserStats_GetStat0(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out float pData);

		[PreserveSig]
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x39E4F0", Offset = "0x39E4F0", VA = "0x39E4F0")]
		public static extern bool ISteamUserStats_SetStat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, int nData);

		[PreserveSig]
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x39E518", Offset = "0x39E518", VA = "0x39E518")]
		public static extern bool ISteamUserStats_SetStat0(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, float fData);

		[PreserveSig]
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x39E540", Offset = "0x39E540", VA = "0x39E540")]
		public static extern bool ISteamUserStats_UpdateAvgRateStat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, float flCountThisSession, double dSessionLength);

		[PreserveSig]
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x39E568", Offset = "0x39E568", VA = "0x39E568")]
		public static extern bool ISteamUserStats_GetAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		[PreserveSig]
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x39E590", Offset = "0x39E590", VA = "0x39E590")]
		public static extern bool ISteamUserStats_SetAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x39E5B8", Offset = "0x39E5B8", VA = "0x39E5B8")]
		public static extern bool ISteamUserStats_ClearAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x39E5E0", Offset = "0x39E5E0", VA = "0x39E5E0")]
		public static extern bool ISteamUserStats_GetAchievementAndUnlockTime(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime);

		[PreserveSig]
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x39E608", Offset = "0x39E608", VA = "0x39E608")]
		public static extern bool ISteamUserStats_StoreStats(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x39E6D4", Offset = "0x39E6D4", VA = "0x39E6D4")]
		public static extern int ISteamUserStats_GetAchievementIcon(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x39E6FC", Offset = "0x39E6FC", VA = "0x39E6FC")]
		public static extern IntPtr ISteamUserStats_GetAchievementDisplayAttribute(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, InteropHelp.UTF8StringHandle pchKey);

		[PreserveSig]
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x39E724", Offset = "0x39E724", VA = "0x39E724")]
		public static extern bool ISteamUserStats_IndicateAchievementProgress(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, uint nCurProgress, uint nMaxProgress);

		[PreserveSig]
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x39E74C", Offset = "0x39E74C", VA = "0x39E74C")]
		public static extern uint ISteamUserStats_GetNumAchievements(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x39E80C", Offset = "0x39E80C", VA = "0x39E80C")]
		public static extern IntPtr ISteamUserStats_GetAchievementName(IntPtr instancePtr, uint iAchievement);

		[PreserveSig]
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x39E8D4", Offset = "0x39E8D4", VA = "0x39E8D4")]
		public static extern ulong ISteamUserStats_RequestUserStats(IntPtr instancePtr, CSteamID steamIDUser);

		[PreserveSig]
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x39E9A4", Offset = "0x39E9A4", VA = "0x39E9A4")]
		public static extern bool ISteamUserStats_GetUserStat(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out int pData);

		[PreserveSig]
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x39E9CC", Offset = "0x39E9CC", VA = "0x39E9CC")]
		public static extern bool ISteamUserStats_GetUserStat0(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out float pData);

		[PreserveSig]
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x39E9F4", Offset = "0x39E9F4", VA = "0x39E9F4")]
		public static extern bool ISteamUserStats_GetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		[PreserveSig]
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x39EA1C", Offset = "0x39EA1C", VA = "0x39EA1C")]
		public static extern bool ISteamUserStats_GetUserAchievementAndUnlockTime(IntPtr instancePtr, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime);

		[PreserveSig]
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x39EA44", Offset = "0x39EA44", VA = "0x39EA44")]
		public static extern bool ISteamUserStats_ResetAllStats(IntPtr instancePtr, bool bAchievementsToo);

		[PreserveSig]
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x39EB18", Offset = "0x39EB18", VA = "0x39EB18")]
		public static extern ulong ISteamUserStats_FindOrCreateLeaderboard(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType);

		[PreserveSig]
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x39EB40", Offset = "0x39EB40", VA = "0x39EB40")]
		public static extern ulong ISteamUserStats_FindLeaderboard(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchLeaderboardName);

		[PreserveSig]
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x39EB68", Offset = "0x39EB68", VA = "0x39EB68")]
		public static extern IntPtr ISteamUserStats_GetLeaderboardName(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		[PreserveSig]
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x39EC38", Offset = "0x39EC38", VA = "0x39EC38")]
		public static extern int ISteamUserStats_GetLeaderboardEntryCount(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		[PreserveSig]
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x39ED08", Offset = "0x39ED08", VA = "0x39ED08")]
		public static extern ELeaderboardSortMethod ISteamUserStats_GetLeaderboardSortMethod(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		[PreserveSig]
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x39EDD8", Offset = "0x39EDD8", VA = "0x39EDD8")]
		public static extern ELeaderboardDisplayType ISteamUserStats_GetLeaderboardDisplayType(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard);

		[PreserveSig]
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x39EEA8", Offset = "0x39EEA8", VA = "0x39EEA8")]
		public static extern ulong ISteamUserStats_DownloadLeaderboardEntries(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd);

		[PreserveSig]
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x39EF90", Offset = "0x39EF90", VA = "0x39EF90")]
		public static extern ulong ISteamUserStats_DownloadLeaderboardEntriesForUsers(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, [In][Out] CSteamID[] prgUsers, int cUsers);

		[PreserveSig]
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x39F078", Offset = "0x39F078", VA = "0x39F078")]
		public static extern bool ISteamUserStats_GetDownloadedLeaderboardEntry(IntPtr instancePtr, SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, [In][Out] int[] pDetails, int cDetailsMax);

		[PreserveSig]
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x39F198", Offset = "0x39F198", VA = "0x39F198")]
		public static extern ulong ISteamUserStats_UploadLeaderboardScore(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, [In][Out] int[] pScoreDetails, int cScoreDetailsCount);

		[PreserveSig]
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x39F290", Offset = "0x39F290", VA = "0x39F290")]
		public static extern ulong ISteamUserStats_AttachLeaderboardUGC(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC);

		[PreserveSig]
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x39F370", Offset = "0x39F370", VA = "0x39F370")]
		public static extern ulong ISteamUserStats_GetNumberOfCurrentPlayers(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x39F430", Offset = "0x39F430", VA = "0x39F430")]
		public static extern ulong ISteamUserStats_RequestGlobalAchievementPercentages(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x39F4F0", Offset = "0x39F4F0", VA = "0x39F4F0")]
		public static extern int ISteamUserStats_GetMostAchievedAchievementInfo(IntPtr instancePtr, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved);

		[PreserveSig]
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x39F5F8", Offset = "0x39F5F8", VA = "0x39F5F8")]
		public static extern int ISteamUserStats_GetNextMostAchievedAchievementInfo(IntPtr instancePtr, int iIteratorPrevious, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved);

		[PreserveSig]
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x39F708", Offset = "0x39F708", VA = "0x39F708")]
		public static extern bool ISteamUserStats_GetAchievementAchievedPercent(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out float pflPercent);

		[PreserveSig]
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x39F730", Offset = "0x39F730", VA = "0x39F730")]
		public static extern ulong ISteamUserStats_RequestGlobalStats(IntPtr instancePtr, int nHistoryDays);

		[PreserveSig]
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x39F7F8", Offset = "0x39F7F8", VA = "0x39F7F8")]
		public static extern bool ISteamUserStats_GetGlobalStat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, out long pData);

		[PreserveSig]
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x39F820", Offset = "0x39F820", VA = "0x39F820")]
		public static extern bool ISteamUserStats_GetGlobalStat0(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, out double pData);

		[PreserveSig]
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x39F848", Offset = "0x39F848", VA = "0x39F848")]
		public static extern int ISteamUserStats_GetGlobalStatHistory(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, [In][Out] long[] pData, uint cubData);

		[PreserveSig]
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x39F870", Offset = "0x39F870", VA = "0x39F870")]
		public static extern int ISteamUserStats_GetGlobalStatHistory0(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchStatName, [In][Out] double[] pData, uint cubData);

		[PreserveSig]
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x39F898", Offset = "0x39F898", VA = "0x39F898")]
		public static extern uint ISteamUtils_GetSecondsSinceAppActive(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x39F958", Offset = "0x39F958", VA = "0x39F958")]
		public static extern uint ISteamUtils_GetSecondsSinceComputerActive(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x39FA18", Offset = "0x39FA18", VA = "0x39FA18")]
		public static extern EUniverse ISteamUtils_GetConnectedUniverse(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x39FAD8", Offset = "0x39FAD8", VA = "0x39FAD8")]
		public static extern uint ISteamUtils_GetServerRealTime(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x39FB98", Offset = "0x39FB98", VA = "0x39FB98")]
		public static extern IntPtr ISteamUtils_GetIPCountry(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x39FC58", Offset = "0x39FC58", VA = "0x39FC58")]
		public static extern bool ISteamUtils_GetImageSize(IntPtr instancePtr, int iImage, out uint pnWidth, out uint pnHeight);

		[PreserveSig]
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x39FD58", Offset = "0x39FD58", VA = "0x39FD58")]
		public static extern bool ISteamUtils_GetImageRGBA(IntPtr instancePtr, int iImage, byte[] pubDest, int nDestBufferSize);

		[PreserveSig]
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x39FE40", Offset = "0x39FE40", VA = "0x39FE40")]
		public static extern bool ISteamUtils_GetCSERIPPort(IntPtr instancePtr, out uint unIP, out ushort usPort);

		[PreserveSig]
		[Token(Token = "0x6000743")]
		[Address(RVA = "0x39FF38", Offset = "0x39FF38", VA = "0x39FF38")]
		public static extern byte ISteamUtils_GetCurrentBatteryPower(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x39FFF8", Offset = "0x39FFF8", VA = "0x39FFF8")]
		public static extern uint ISteamUtils_GetAppID(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x3A00B8", Offset = "0x3A00B8", VA = "0x3A00B8")]
		public static extern void ISteamUtils_SetOverlayNotificationPosition(IntPtr instancePtr, ENotificationPosition eNotificationPosition);

		[PreserveSig]
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x3A0180", Offset = "0x3A0180", VA = "0x3A0180")]
		public static extern bool ISteamUtils_IsAPICallCompleted(IntPtr instancePtr, SteamAPICall_t hSteamAPICall, out bool pbFailed);

		[PreserveSig]
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x3A0280", Offset = "0x3A0280", VA = "0x3A0280")]
		public static extern ESteamAPICallFailure ISteamUtils_GetAPICallFailureReason(IntPtr instancePtr, SteamAPICall_t hSteamAPICall);

		[PreserveSig]
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x3A0350", Offset = "0x3A0350", VA = "0x3A0350")]
		public static extern bool ISteamUtils_GetAPICallResult(IntPtr instancePtr, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed);

		[PreserveSig]
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x3A0468", Offset = "0x3A0468", VA = "0x3A0468")]
		public static extern uint ISteamUtils_GetIPCCallCount(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x3A0528", Offset = "0x3A0528", VA = "0x3A0528")]
		public static extern void ISteamUtils_SetWarningMessageHook(IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction);

		[PreserveSig]
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x3A0600", Offset = "0x3A0600", VA = "0x3A0600")]
		public static extern bool ISteamUtils_IsOverlayEnabled(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x3A06CC", Offset = "0x3A06CC", VA = "0x3A06CC")]
		public static extern bool ISteamUtils_BOverlayNeedsPresent(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x3A0798", Offset = "0x3A0798", VA = "0x3A0798")]
		public static extern ulong ISteamUtils_CheckFileSignature(IntPtr instancePtr, InteropHelp.UTF8StringHandle szFileName);

		[PreserveSig]
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x3A07C0", Offset = "0x3A07C0", VA = "0x3A07C0")]
		public static extern bool ISteamUtils_ShowGamepadTextInput(IntPtr instancePtr, EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, InteropHelp.UTF8StringHandle pchDescription, uint unCharMax, InteropHelp.UTF8StringHandle pchExistingText);

		[PreserveSig]
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x3A07E8", Offset = "0x3A07E8", VA = "0x3A07E8")]
		public static extern uint ISteamUtils_GetEnteredGamepadTextLength(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x3A08A8", Offset = "0x3A08A8", VA = "0x3A08A8")]
		public static extern bool ISteamUtils_GetEnteredGamepadTextInput(IntPtr instancePtr, IntPtr pchText, uint cchText);

		[PreserveSig]
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x3A0984", Offset = "0x3A0984", VA = "0x3A0984")]
		public static extern IntPtr ISteamUtils_GetSteamUILanguage(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x3A0A44", Offset = "0x3A0A44", VA = "0x3A0A44")]
		public static extern bool ISteamUtils_IsSteamRunningInVR(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x3A0B10", Offset = "0x3A0B10", VA = "0x3A0B10")]
		public static extern void ISteamUtils_SetOverlayNotificationInset(IntPtr instancePtr, int nHorizontalInset, int nVerticalInset);

		[PreserveSig]
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x3A0BE0", Offset = "0x3A0BE0", VA = "0x3A0BE0")]
		public static extern bool ISteamUtils_IsSteamInBigPictureMode(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x3A0CAC", Offset = "0x3A0CAC", VA = "0x3A0CAC")]
		public static extern void ISteamUtils_StartVRDashboard(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x3A0D6C", Offset = "0x3A0D6C", VA = "0x3A0D6C")]
		public static extern bool ISteamUtils_IsVRHeadsetStreamingEnabled(IntPtr instancePtr);

		[PreserveSig]
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x3A0E38", Offset = "0x3A0E38", VA = "0x3A0E38")]
		public static extern void ISteamUtils_SetVRHeadsetStreamingEnabled(IntPtr instancePtr, bool bEnabled);

		[PreserveSig]
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x3A0F00", Offset = "0x3A0F00", VA = "0x3A0F00")]
		public static extern void ISteamVideo_GetVideoURL(IntPtr instancePtr, AppId_t unVideoAppID);

		[PreserveSig]
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x3A0FC8", Offset = "0x3A0FC8", VA = "0x3A0FC8")]
		public static extern bool ISteamVideo_IsBroadcasting(IntPtr instancePtr, out int pnNumViewers);

		[PreserveSig]
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x3A10AC", Offset = "0x3A10AC", VA = "0x3A10AC")]
		public static extern void ISteamVideo_GetOPFSettings(IntPtr instancePtr, AppId_t unVideoAppID);

		[PreserveSig]
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x3A1174", Offset = "0x3A1174", VA = "0x3A1174")]
		public static extern bool ISteamVideo_GetOPFStringForApp(IntPtr instancePtr, AppId_t unVideoAppID, IntPtr pchBuffer, ref int pnBufferSize);
	}
	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B37D4", Offset = "0x2B37D4")]
	public struct SteamAppInstalled_t
	{
		[Token(Token = "0x4000087")]
		public const int k_iCallback = 3901;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B37E8", Offset = "0x2B37E8")]
	public struct SteamAppUninstalled_t
	{
		[Token(Token = "0x4000089")]
		public const int k_iCallback = 3902;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B37FC", Offset = "0x2B37FC")]
	public struct DlcInstalled_t
	{
		[Token(Token = "0x400008B")]
		public const int k_iCallback = 1005;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x20000A5")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3810", Offset = "0x2B3810")]
	public struct RegisterActivationCodeResponse_t
	{
		[Token(Token = "0x400008D")]
		public const int k_iCallback = 1008;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ERegisterActivationCodeResult m_eResult;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_unPackageRegistered;
	}
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3824", Offset = "0x2B3824")]
	public struct NewLaunchQueryParameters_t
	{
		[Token(Token = "0x4000090")]
		public const int k_iCallback = 1014;
	}
	[Token(Token = "0x20000A7")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3838", Offset = "0x2B3838")]
	public struct AppProofOfPurchaseKeyResponse_t
	{
		[Token(Token = "0x4000091")]
		public const int k_iCallback = 1021;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_nAppID;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_cchKeyLength;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string m_rgchKey;
	}
	[Token(Token = "0x20000A8")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B384C", Offset = "0x2B384C")]
	public struct FileDetailsResult_t
	{
		[Token(Token = "0x4000096")]
		public const int k_iCallback = 1023;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulFileSize;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] m_FileSHA;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint m_unFlags;
	}
	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3860", Offset = "0x2B3860")]
	public struct PersonaStateChange_t
	{
		[Token(Token = "0x400009B")]
		public const int k_iCallback = 304;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamID;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EPersonaChange m_nChangeFlags;
	}
	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3874", Offset = "0x2B3874")]
	public struct GameOverlayActivated_t
	{
		[Token(Token = "0x400009E")]
		public const int k_iCallback = 331;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_bActive;
	}
	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3888", Offset = "0x2B3888")]
	public struct GameServerChangeRequested_t
	{
		[Token(Token = "0x40000A0")]
		public const int k_iCallback = 332;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string m_rgchServer;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public string m_rgchPassword;
	}
	[Token(Token = "0x20000AC")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B389C", Offset = "0x2B389C")]
	public struct GameLobbyJoinRequested_t
	{
		[Token(Token = "0x40000A3")]
		public const int k_iCallback = 333;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDLobby;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDFriend;
	}
	[Token(Token = "0x20000AD")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B38B0", Offset = "0x2B38B0")]
	public struct AvatarImageLoaded_t
	{
		[Token(Token = "0x40000A6")]
		public const int k_iCallback = 334;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamID;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_iImage;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_iWide;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_iTall;
	}
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B38C4", Offset = "0x2B38C4")]
	public struct ClanOfficerListResponse_t
	{
		[Token(Token = "0x40000AB")]
		public const int k_iCallback = 335;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClan;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_cOfficers;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public byte m_bSuccess;
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B38D8", Offset = "0x2B38D8")]
	public struct FriendRichPresenceUpdate_t
	{
		[Token(Token = "0x40000AF")]
		public const int k_iCallback = 336;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDFriend;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B38EC", Offset = "0x2B38EC")]
	public struct GameRichPresenceJoinRequested_t
	{
		[Token(Token = "0x40000B2")]
		public const int k_iCallback = 337;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDFriend;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_rgchConnect;
	}
	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3900", Offset = "0x2B3900")]
	public struct GameConnectedClanChatMsg_t
	{
		[Token(Token = "0x40000B5")]
		public const int k_iCallback = 338;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDUser;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_iMessageID;
	}
	[Token(Token = "0x20000B2")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3914", Offset = "0x2B3914")]
	public struct GameConnectedChatJoin_t
	{
		[Token(Token = "0x40000B9")]
		public const int k_iCallback = 339;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3928", Offset = "0x2B3928")]
	public struct GameConnectedChatLeave_t
	{
		[Token(Token = "0x40000BC")]
		public const int k_iCallback = 340;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDUser;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bKicked;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool m_bDropped;
	}
	[Token(Token = "0x20000B4")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B393C", Offset = "0x2B393C")]
	public struct DownloadClanActivityCountsResult_t
	{
		[Token(Token = "0x40000C1")]
		public const int k_iCallback = 341;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_bSuccess;
	}
	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3950", Offset = "0x2B3950")]
	public struct JoinClanChatRoomCompletionResult_t
	{
		[Token(Token = "0x40000C3")]
		public const int k_iCallback = 342;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EChatRoomEnterResponse m_eChatRoomEnterResponse;
	}
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3964", Offset = "0x2B3964")]
	public struct GameConnectedFriendChatMsg_t
	{
		[Token(Token = "0x40000C6")]
		public const int k_iCallback = 343;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_iMessageID;
	}
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3978", Offset = "0x2B3978")]
	public struct FriendsGetFollowerCount_t
	{
		[Token(Token = "0x40000C9")]
		public const int k_iCallback = 344;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public CSteamID m_steamID;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_nCount;
	}
	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B398C", Offset = "0x2B398C")]
	public struct FriendsIsFollowing_t
	{
		[Token(Token = "0x40000CD")]
		public const int k_iCallback = 345;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public CSteamID m_steamID;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bIsFollowing;
	}
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B39A0", Offset = "0x2B39A0")]
	public struct FriendsEnumerateFollowingList_t
	{
		[Token(Token = "0x40000D1")]
		public const int k_iCallback = 346;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public CSteamID[] m_rgSteamID;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nResultsReturned;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_nTotalResultCount;
	}
	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B39B4", Offset = "0x2B39B4")]
	public struct SetPersonaNameResponse_t
	{
		[Token(Token = "0x40000D6")]
		public const int k_iCallback = 347;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_bSuccess;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public bool m_bLocalSuccess;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_result;
	}
	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B39C8", Offset = "0x2B39C8")]
	public struct GCMessageAvailable_t
	{
		[Token(Token = "0x40000DA")]
		public const int k_iCallback = 1701;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_nMessageSize;
	}
	[Token(Token = "0x20000BC")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B39DC", Offset = "0x2B39DC")]
	public struct GCMessageFailed_t
	{
		[Token(Token = "0x40000DC")]
		public const int k_iCallback = 1702;
	}
	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B39F0", Offset = "0x2B39F0")]
	public struct GSClientApprove_t
	{
		[Token(Token = "0x40000DD")]
		public const int k_iCallback = 201;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_OwnerSteamID;
	}
	[Token(Token = "0x20000BE")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3A04", Offset = "0x2B3A04")]
	public struct GSClientDeny_t
	{
		[Token(Token = "0x40000E0")]
		public const int k_iCallback = 202;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EDenyReason m_eDenyReason;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string m_rgchOptionalText;
	}
	[Token(Token = "0x20000BF")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3A18", Offset = "0x2B3A18")]
	public struct GSClientKick_t
	{
		[Token(Token = "0x40000E4")]
		public const int k_iCallback = 203;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EDenyReason m_eDenyReason;
	}
	[Token(Token = "0x20000C0")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3A2C", Offset = "0x2B3A2C")]
	public struct GSClientAchievementStatus_t
	{
		[Token(Token = "0x40000E7")]
		public const int k_iCallback = 206;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamID;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_pchAchievement;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bUnlocked;
	}
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3A40", Offset = "0x2B3A40")]
	public struct GSPolicyResponse_t
	{
		[Token(Token = "0x40000EB")]
		public const int k_iCallback = 115;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_bSecure;
	}
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3A54", Offset = "0x2B3A54")]
	public struct GSGameplayStats_t
	{
		[Token(Token = "0x40000ED")]
		public const int k_iCallback = 207;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nRank;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_unTotalConnects;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_unTotalMinutesPlayed;
	}
	[Token(Token = "0x20000C3")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3A68", Offset = "0x2B3A68")]
	public struct GSClientGroupStatus_t
	{
		[Token(Token = "0x40000F2")]
		public const int k_iCallback = 208;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamIDUser;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_SteamIDGroup;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bMember;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool m_bOfficer;
	}
	[Token(Token = "0x20000C4")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3A7C", Offset = "0x2B3A7C")]
	public struct GSReputation_t
	{
		[Token(Token = "0x40000F7")]
		public const int k_iCallback = 209;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_unReputationScore;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool m_bBanned;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_unBannedIP;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ushort m_usBannedPort;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ulong m_ulBannedGameID;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint m_unBanExpires;
	}
	[Token(Token = "0x20000C5")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3A90", Offset = "0x2B3A90")]
	public struct AssociateWithClanResult_t
	{
		[Token(Token = "0x40000FF")]
		public const int k_iCallback = 210;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000C6")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3AA4", Offset = "0x2B3AA4")]
	public struct ComputeNewPlayerCompatibilityResult_t
	{
		[Token(Token = "0x4000101")]
		public const int k_iCallback = 211;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_cPlayersThatDontLikeCandidate;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_cPlayersThatCandidateDoesntLike;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_cClanPlayersThatDontLikeCandidate;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CSteamID m_SteamIDCandidate;
	}
	[Token(Token = "0x20000C7")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3AB8", Offset = "0x2B3AB8")]
	public struct GSStatsReceived_t
	{
		[Token(Token = "0x4000107")]
		public const int k_iCallback = 1800;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3ACC", Offset = "0x2B3ACC")]
	public struct GSStatsStored_t
	{
		[Token(Token = "0x400010A")]
		public const int k_iCallback = 1801;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x20000C9")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3AE0", Offset = "0x2B3AE0")]
	public struct GSStatsUnloaded_t
	{
		[Token(Token = "0x400010D")]
		public const int k_iCallback = 1108;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x20000CA")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3AF4", Offset = "0x2B3AF4")]
	public struct HTML_BrowserReady_t
	{
		[Token(Token = "0x400010F")]
		public const int k_iCallback = 4501;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;
	}
	[Token(Token = "0x20000CB")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3B08", Offset = "0x2B3B08")]
	public struct HTML_NeedsPaint_t
	{
		[Token(Token = "0x4000111")]
		public const int k_iCallback = 4502;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public IntPtr pBGRA;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint unWide;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint unTall;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint unUpdateX;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint unUpdateY;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint unUpdateWide;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint unUpdateTall;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint unScrollX;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public uint unScrollY;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float flPageScale;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public uint unPageSerial;
	}
	[Token(Token = "0x20000CC")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3B1C", Offset = "0x2B3B1C")]
	public struct HTML_StartRequest_t
	{
		[Token(Token = "0x400011E")]
		public const int k_iCallback = 4503;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public string pchURL;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchTarget;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string pchPostData;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool bIsRedirect;
	}
	[Token(Token = "0x20000CD")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3B30", Offset = "0x2B3B30")]
	public struct HTML_CloseBrowser_t
	{
		[Token(Token = "0x4000124")]
		public const int k_iCallback = 4504;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;
	}
	[Token(Token = "0x20000CE")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3B44", Offset = "0x2B3B44")]
	public struct HTML_URLChanged_t
	{
		[Token(Token = "0x4000126")]
		public const int k_iCallback = 4505;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public string pchURL;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchPostData;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool bIsRedirect;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string pchPageTitle;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool bNewNavigation;
	}
	[Token(Token = "0x20000CF")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3B58", Offset = "0x2B3B58")]
	public struct HTML_FinishedRequest_t
	{
		[Token(Token = "0x400012D")]
		public const int k_iCallback = 4506;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public string pchURL;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchPageTitle;
	}
	[Token(Token = "0x20000D0")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3B6C", Offset = "0x2B3B6C")]
	public struct HTML_OpenLinkInNewTab_t
	{
		[Token(Token = "0x4000131")]
		public const int k_iCallback = 4507;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public string pchURL;
	}
	[Token(Token = "0x20000D1")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3B80", Offset = "0x2B3B80")]
	public struct HTML_ChangedTitle_t
	{
		[Token(Token = "0x4000134")]
		public const int k_iCallback = 4508;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public string pchTitle;
	}
	[Token(Token = "0x20000D2")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3B94", Offset = "0x2B3B94")]
	public struct HTML_SearchResults_t
	{
		[Token(Token = "0x4000137")]
		public const int k_iCallback = 4509;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint unResults;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint unCurrentMatch;
	}
	[Token(Token = "0x20000D3")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3BA8", Offset = "0x2B3BA8")]
	public struct HTML_CanGoBackAndForward_t
	{
		[Token(Token = "0x400013B")]
		public const int k_iCallback = 4510;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool bCanGoBack;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public bool bCanGoForward;
	}
	[Token(Token = "0x20000D4")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3BBC", Offset = "0x2B3BBC")]
	public struct HTML_HorizontalScroll_t
	{
		[Token(Token = "0x400013F")]
		public const int k_iCallback = 4511;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint unScrollMax;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint unScrollCurrent;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float flPageScale;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool bVisible;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint unPageSize;
	}
	[Token(Token = "0x20000D5")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3BD0", Offset = "0x2B3BD0")]
	public struct HTML_VerticalScroll_t
	{
		[Token(Token = "0x4000146")]
		public const int k_iCallback = 4512;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint unScrollMax;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint unScrollCurrent;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float flPageScale;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool bVisible;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint unPageSize;
	}
	[Token(Token = "0x20000D6")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3BE4", Offset = "0x2B3BE4")]
	public struct HTML_LinkAtPosition_t
	{
		[Token(Token = "0x400014D")]
		public const int k_iCallback = 4513;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint x;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint y;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string pchURL;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool bInput;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool bLiveLink;
	}
	[Token(Token = "0x20000D7")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3BF8", Offset = "0x2B3BF8")]
	public struct HTML_JSAlert_t
	{
		[Token(Token = "0x4000154")]
		public const int k_iCallback = 4514;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public string pchMessage;
	}
	[Token(Token = "0x20000D8")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3C0C", Offset = "0x2B3C0C")]
	public struct HTML_JSConfirm_t
	{
		[Token(Token = "0x4000157")]
		public const int k_iCallback = 4515;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public string pchMessage;
	}
	[Token(Token = "0x20000D9")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3C20", Offset = "0x2B3C20")]
	public struct HTML_FileOpenDialog_t
	{
		[Token(Token = "0x400015A")]
		public const int k_iCallback = 4516;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public string pchTitle;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string pchInitialFile;
	}
	[Token(Token = "0x20000DA")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3C34", Offset = "0x2B3C34")]
	public struct HTML_NewWindow_t
	{
		[Token(Token = "0x400015E")]
		public const int k_iCallback = 4521;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public string pchURL;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint unX;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint unY;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint unWide;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint unTall;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HHTMLBrowser unNewWindow_BrowserHandle;
	}
	[Token(Token = "0x20000DB")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3C48", Offset = "0x2B3C48")]
	public struct HTML_SetCursor_t
	{
		[Token(Token = "0x4000166")]
		public const int k_iCallback = 4522;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint eMouseCursor;
	}
	[Token(Token = "0x20000DC")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3C5C", Offset = "0x2B3C5C")]
	public struct HTML_StatusText_t
	{
		[Token(Token = "0x4000169")]
		public const int k_iCallback = 4523;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public string pchMsg;
	}
	[Token(Token = "0x20000DD")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3C70", Offset = "0x2B3C70")]
	public struct HTML_ShowToolTip_t
	{
		[Token(Token = "0x400016C")]
		public const int k_iCallback = 4524;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public string pchMsg;
	}
	[Token(Token = "0x20000DE")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3C84", Offset = "0x2B3C84")]
	public struct HTML_UpdateToolTip_t
	{
		[Token(Token = "0x400016F")]
		public const int k_iCallback = 4525;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public string pchMsg;
	}
	[Token(Token = "0x20000DF")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3C98", Offset = "0x2B3C98")]
	public struct HTML_HideToolTip_t
	{
		[Token(Token = "0x4000172")]
		public const int k_iCallback = 4526;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HHTMLBrowser unBrowserHandle;
	}
	[Token(Token = "0x20000E0")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3CAC", Offset = "0x2B3CAC")]
	public struct HTTPRequestCompleted_t
	{
		[Token(Token = "0x4000174")]
		public const int k_iCallback = 2101;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HTTPRequestHandle m_hRequest;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ulong m_ulContextValue;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bRequestSuccessful;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EHTTPStatusCode m_eStatusCode;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint m_unBodySize;
	}
	[Token(Token = "0x20000E1")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3CC0", Offset = "0x2B3CC0")]
	public struct HTTPRequestHeadersReceived_t
	{
		[Token(Token = "0x400017A")]
		public const int k_iCallback = 2102;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HTTPRequestHandle m_hRequest;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ulong m_ulContextValue;
	}
	[Token(Token = "0x20000E2")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3CD4", Offset = "0x2B3CD4")]
	public struct HTTPRequestDataReceived_t
	{
		[Token(Token = "0x400017D")]
		public const int k_iCallback = 2103;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HTTPRequestHandle m_hRequest;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ulong m_ulContextValue;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_cOffset;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_cBytesReceived;
	}
	[Token(Token = "0x20000E3")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3CE8", Offset = "0x2B3CE8")]
	public struct SteamInventoryResultReady_t
	{
		[Token(Token = "0x4000182")]
		public const int k_iCallback = 4700;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamInventoryResult_t m_handle;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_result;
	}
	[Token(Token = "0x20000E4")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3CFC", Offset = "0x2B3CFC")]
	public struct SteamInventoryFullUpdate_t
	{
		[Token(Token = "0x4000185")]
		public const int k_iCallback = 4701;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamInventoryResult_t m_handle;
	}
	[Token(Token = "0x20000E5")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3D10", Offset = "0x2B3D10")]
	public struct SteamInventoryDefinitionUpdate_t
	{
		[Token(Token = "0x4000187")]
		public const int k_iCallback = 4702;
	}
	[Token(Token = "0x20000E6")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3D24", Offset = "0x2B3D24")]
	public struct SteamInventoryEligiblePromoItemDefIDs_t
	{
		[Token(Token = "0x4000188")]
		public const int k_iCallback = 4703;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_result;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public CSteamID m_steamID;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_numEligiblePromoItemDefs;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool m_bCachedData;
	}
	[Token(Token = "0x20000E7")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3D38", Offset = "0x2B3D38")]
	public struct FavoritesListChanged_t
	{
		[Token(Token = "0x400018D")]
		public const int k_iCallback = 502;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_nIP;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_nQueryPort;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_nConnPort;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_nAppID;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_nFlags;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool m_bAdd;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AccountID_t m_unAccountId;
	}
	[Token(Token = "0x20000E8")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3D4C", Offset = "0x2B3D4C")]
	public struct LobbyInvite_t
	{
		[Token(Token = "0x4000195")]
		public const int k_iCallback = 503;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDUser;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ulong m_ulGameID;
	}
	[Token(Token = "0x20000E9")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3D60", Offset = "0x2B3D60")]
	public struct LobbyEnter_t
	{
		[Token(Token = "0x4000199")]
		public const int k_iCallback = 504;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_rgfChatPermissions;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bLocked;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_EChatRoomEnterResponse;
	}
	[Token(Token = "0x20000EA")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3D74", Offset = "0x2B3D74")]
	public struct LobbyDataUpdate_t
	{
		[Token(Token = "0x400019E")]
		public const int k_iCallback = 505;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDMember;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte m_bSuccess;
	}
	[Token(Token = "0x20000EB")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3D88", Offset = "0x2B3D88")]
	public struct LobbyChatUpdate_t
	{
		[Token(Token = "0x40001A2")]
		public const int k_iCallback = 506;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDUserChanged;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ulong m_ulSteamIDMakingChange;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint m_rgfChatMemberStateChange;
	}
	[Token(Token = "0x20000EC")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3D9C", Offset = "0x2B3D9C")]
	public struct LobbyChatMsg_t
	{
		[Token(Token = "0x40001A7")]
		public const int k_iCallback = 507;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDUser;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte m_eChatEntryType;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint m_iChatID;
	}
	[Token(Token = "0x20000ED")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3DB0", Offset = "0x2B3DB0")]
	public struct LobbyGameCreated_t
	{
		[Token(Token = "0x40001AC")]
		public const int k_iCallback = 509;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDGameServer;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_unIP;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ushort m_usPort;
	}
	[Token(Token = "0x20000EE")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3DC4", Offset = "0x2B3DC4")]
	public struct LobbyMatchList_t
	{
		[Token(Token = "0x40001B1")]
		public const int k_iCallback = 510;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_nLobbiesMatching;
	}
	[Token(Token = "0x20000EF")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3DD8", Offset = "0x2B3DD8")]
	public struct LobbyKicked_t
	{
		[Token(Token = "0x40001B3")]
		public const int k_iCallback = 512;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDAdmin;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte m_bKickedDueToDisconnect;
	}
	[Token(Token = "0x20000F0")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3DEC", Offset = "0x2B3DEC")]
	public struct LobbyCreated_t
	{
		[Token(Token = "0x40001B7")]
		public const int k_iCallback = 513;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ulong m_ulSteamIDLobby;
	}
	[Token(Token = "0x20000F1")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3E00", Offset = "0x2B3E00")]
	public struct FavoritesListAccountsUpdated_t
	{
		[Token(Token = "0x40001BA")]
		public const int k_iCallback = 516;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x20000F2")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3E14", Offset = "0x2B3E14")]
	public struct PlaybackStatusHasChanged_t
	{
		[Token(Token = "0x40001BC")]
		public const int k_iCallback = 4001;
	}
	[Token(Token = "0x20000F3")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3E28", Offset = "0x2B3E28")]
	public struct VolumeHasChanged_t
	{
		[Token(Token = "0x40001BD")]
		public const int k_iCallback = 4002;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m_flNewVolume;
	}
	[Token(Token = "0x20000F4")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3E3C", Offset = "0x2B3E3C")]
	public struct MusicPlayerRemoteWillActivate_t
	{
		[Token(Token = "0x40001BF")]
		public const int k_iCallback = 4101;
	}
	[Token(Token = "0x20000F5")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3E50", Offset = "0x2B3E50")]
	public struct MusicPlayerRemoteWillDeactivate_t
	{
		[Token(Token = "0x40001C0")]
		public const int k_iCallback = 4102;
	}
	[Token(Token = "0x20000F6")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3E64", Offset = "0x2B3E64")]
	public struct MusicPlayerRemoteToFront_t
	{
		[Token(Token = "0x40001C1")]
		public const int k_iCallback = 4103;
	}
	[Token(Token = "0x20000F7")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3E78", Offset = "0x2B3E78")]
	public struct MusicPlayerWillQuit_t
	{
		[Token(Token = "0x40001C2")]
		public const int k_iCallback = 4104;
	}
	[Token(Token = "0x20000F8")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3E8C", Offset = "0x2B3E8C")]
	public struct MusicPlayerWantsPlay_t
	{
		[Token(Token = "0x40001C3")]
		public const int k_iCallback = 4105;
	}
	[Token(Token = "0x20000F9")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3EA0", Offset = "0x2B3EA0")]
	public struct MusicPlayerWantsPause_t
	{
		[Token(Token = "0x40001C4")]
		public const int k_iCallback = 4106;
	}
	[Token(Token = "0x20000FA")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3EB4", Offset = "0x2B3EB4")]
	public struct MusicPlayerWantsPlayPrevious_t
	{
		[Token(Token = "0x40001C5")]
		public const int k_iCallback = 4107;
	}
	[Token(Token = "0x20000FB")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3EC8", Offset = "0x2B3EC8")]
	public struct MusicPlayerWantsPlayNext_t
	{
		[Token(Token = "0x40001C6")]
		public const int k_iCallback = 4108;
	}
	[Token(Token = "0x20000FC")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3EDC", Offset = "0x2B3EDC")]
	public struct MusicPlayerWantsShuffled_t
	{
		[Token(Token = "0x40001C7")]
		public const int k_iCallback = 4109;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_bShuffled;
	}
	[Token(Token = "0x20000FD")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3EF0", Offset = "0x2B3EF0")]
	public struct MusicPlayerWantsLooped_t
	{
		[Token(Token = "0x40001C9")]
		public const int k_iCallback = 4110;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_bLooped;
	}
	[Token(Token = "0x20000FE")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3F04", Offset = "0x2B3F04")]
	public struct MusicPlayerWantsVolume_t
	{
		[Token(Token = "0x40001CB")]
		public const int k_iCallback = 4011;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m_flNewVolume;
	}
	[Token(Token = "0x20000FF")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3F18", Offset = "0x2B3F18")]
	public struct MusicPlayerSelectsQueueEntry_t
	{
		[Token(Token = "0x40001CD")]
		public const int k_iCallback = 4012;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int nID;
	}
	[Token(Token = "0x2000100")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3F2C", Offset = "0x2B3F2C")]
	public struct MusicPlayerSelectsPlaylistEntry_t
	{
		[Token(Token = "0x40001CF")]
		public const int k_iCallback = 4013;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int nID;
	}
	[Token(Token = "0x2000101")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3F40", Offset = "0x2B3F40")]
	public struct MusicPlayerWantsPlayingRepeatStatus_t
	{
		[Token(Token = "0x40001D1")]
		public const int k_iCallback = 4114;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_nPlayingRepeatStatus;
	}
	[Token(Token = "0x2000102")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3F54", Offset = "0x2B3F54")]
	public struct P2PSessionRequest_t
	{
		[Token(Token = "0x40001D3")]
		public const int k_iCallback = 1202;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDRemote;
	}
	[Token(Token = "0x2000103")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3F68", Offset = "0x2B3F68")]
	public struct P2PSessionConnectFail_t
	{
		[Token(Token = "0x40001D5")]
		public const int k_iCallback = 1203;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDRemote;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte m_eP2PSessionError;
	}
	[Token(Token = "0x2000104")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3F7C", Offset = "0x2B3F7C")]
	public struct SocketStatusCallback_t
	{
		[Token(Token = "0x40001D8")]
		public const int k_iCallback = 1201;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SNetSocket_t m_hSocket;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public SNetListenSocket_t m_hListenSocket;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDRemote;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_eSNetSocketState;
	}
	[Token(Token = "0x2000105")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3F90", Offset = "0x2B3F90")]
	public struct SteamParentalSettingsChanged_t
	{
		[Token(Token = "0x40001DD")]
		public const int k_iCallback = 5001;
	}
	[Token(Token = "0x2000106")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3FA4", Offset = "0x2B3FA4")]
	public struct RemoteStorageAppSyncedClient_t
	{
		[Token(Token = "0x40001DE")]
		public const int k_iCallback = 1301;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_eResult;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_unNumDownloads;
	}
	[Token(Token = "0x2000107")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3FB8", Offset = "0x2B3FB8")]
	public struct RemoteStorageAppSyncedServer_t
	{
		[Token(Token = "0x40001E2")]
		public const int k_iCallback = 1302;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_eResult;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_unNumUploads;
	}
	[Token(Token = "0x2000108")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3FCC", Offset = "0x2B3FCC")]
	public struct RemoteStorageAppSyncProgress_t
	{
		[Token(Token = "0x40001E6")]
		public const int k_iCallback = 1303;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string m_rgchCurrentFile;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public AppId_t m_nAppID;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_uBytesTransferredThisChunk;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double m_dAppPercentComplete;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool m_bUploading;
	}
	[Token(Token = "0x2000109")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3FE0", Offset = "0x2B3FE0")]
	public struct RemoteStorageAppSyncStatusCheck_t
	{
		[Token(Token = "0x40001EC")]
		public const int k_iCallback = 1305;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_eResult;
	}
	[Token(Token = "0x200010A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B3FF4", Offset = "0x2B3FF4")]
	public struct RemoteStorageFileShareResult_t
	{
		[Token(Token = "0x40001EF")]
		public const int k_iCallback = 1307;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public UGCHandle_t m_hFile;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string m_rgchFilename;
	}
	[Token(Token = "0x200010B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4008", Offset = "0x2B4008")]
	public struct RemoteStoragePublishFileResult_t
	{
		[Token(Token = "0x40001F3")]
		public const int k_iCallback = 1309;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
	[Token(Token = "0x200010C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B401C", Offset = "0x2B401C")]
	public struct RemoteStorageDeletePublishedFileResult_t
	{
		[Token(Token = "0x40001F7")]
		public const int k_iCallback = 1311;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public PublishedFileId_t m_nPublishedFileId;
	}
	[Token(Token = "0x200010D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4030", Offset = "0x2B4030")]
	public struct RemoteStorageEnumerateUserPublishedFilesResult_t
	{
		[Token(Token = "0x40001FA")]
		public const int k_iCallback = 1312;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nResultsReturned;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nTotalResultCount;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public PublishedFileId_t[] m_rgPublishedFileId;
	}
	[Token(Token = "0x200010E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4044", Offset = "0x2B4044")]
	public struct RemoteStorageSubscribePublishedFileResult_t
	{
		[Token(Token = "0x40001FF")]
		public const int k_iCallback = 1313;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public PublishedFileId_t m_nPublishedFileId;
	}
	[Token(Token = "0x200010F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4058", Offset = "0x2B4058")]
	public struct RemoteStorageEnumerateUserSubscribedFilesResult_t
	{
		[Token(Token = "0x4000202")]
		public const int k_iCallback = 1314;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nResultsReturned;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nTotalResultCount;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public PublishedFileId_t[] m_rgPublishedFileId;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint[] m_rgRTimeSubscribed;
	}
	[Token(Token = "0x2000110")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B406C", Offset = "0x2B406C")]
	public struct RemoteStorageUnsubscribePublishedFileResult_t
	{
		[Token(Token = "0x4000208")]
		public const int k_iCallback = 1315;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public PublishedFileId_t m_nPublishedFileId;
	}
	[Token(Token = "0x2000111")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4080", Offset = "0x2B4080")]
	public struct RemoteStorageUpdatePublishedFileResult_t
	{
		[Token(Token = "0x400020B")]
		public const int k_iCallback = 1316;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
	[Token(Token = "0x2000112")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4094", Offset = "0x2B4094")]
	public struct RemoteStorageDownloadUGCResult_t
	{
		[Token(Token = "0x400020F")]
		public const int k_iCallback = 1317;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public UGCHandle_t m_hFile;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AppId_t m_nAppID;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int m_nSizeInBytes;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_pchFileName;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ulong m_ulSteamIDOwner;
	}
	[Token(Token = "0x2000113")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B40A8", Offset = "0x2B40A8")]
	public struct RemoteStorageGetPublishedFileDetailsResult_t
	{
		[Token(Token = "0x4000216")]
		public const int k_iCallback = 1318;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AppId_t m_nCreatorAppID;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public AppId_t m_nConsumerAppID;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_rgchTitle;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public string m_rgchDescription;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UGCHandle_t m_hFile;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UGCHandle_t m_hPreviewFile;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ulong m_ulSteamIDOwner;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public uint m_rtimeCreated;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public uint m_rtimeUpdated;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ERemoteStoragePublishedFileVisibility m_eVisibility;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool m_bBanned;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_rgchTags;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool m_bTagsTruncated;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string m_pchFileName;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int m_nFileSize;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int m_nPreviewFileSize;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public string m_rgchURL;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public EWorkshopFileType m_eFileType;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool m_bAcceptedForUse;
	}
	[Token(Token = "0x2000114")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B40BC", Offset = "0x2B40BC")]
	public struct RemoteStorageEnumerateWorkshopFilesResult_t
	{
		[Token(Token = "0x400022C")]
		public const int k_iCallback = 1319;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nResultsReturned;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nTotalResultCount;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public PublishedFileId_t[] m_rgPublishedFileId;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] m_rgScore;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public AppId_t m_nAppId;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint m_unStartIndex;
	}
	[Token(Token = "0x2000115")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B40D0", Offset = "0x2B40D0")]
	public struct RemoteStorageGetPublishedItemVoteDetailsResult_t
	{
		[Token(Token = "0x4000234")]
		public const int k_iCallback = 1320;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public PublishedFileId_t m_unPublishedFileId;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_nVotesFor;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_nVotesAgainst;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int m_nReports;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m_fScore;
	}
	[Token(Token = "0x2000116")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B40E4", Offset = "0x2B40E4")]
	public struct RemoteStoragePublishedFileSubscribed_t
	{
		[Token(Token = "0x400023B")]
		public const int k_iCallback = 1321;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x2000117")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B40F8", Offset = "0x2B40F8")]
	public struct RemoteStoragePublishedFileUnsubscribed_t
	{
		[Token(Token = "0x400023E")]
		public const int k_iCallback = 1322;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x2000118")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B410C", Offset = "0x2B410C")]
	public struct RemoteStoragePublishedFileDeleted_t
	{
		[Token(Token = "0x4000241")]
		public const int k_iCallback = 1323;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x2000119")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4120", Offset = "0x2B4120")]
	public struct RemoteStorageUpdateUserPublishedItemVoteResult_t
	{
		[Token(Token = "0x4000244")]
		public const int k_iCallback = 1324;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public PublishedFileId_t m_nPublishedFileId;
	}
	[Token(Token = "0x200011A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4134", Offset = "0x2B4134")]
	public struct RemoteStorageUserVoteDetails_t
	{
		[Token(Token = "0x4000247")]
		public const int k_iCallback = 1325;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public EWorkshopVote m_eVote;
	}
	[Token(Token = "0x200011B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4148", Offset = "0x2B4148")]
	public struct RemoteStorageEnumerateUserSharedWorkshopFilesResult_t
	{
		[Token(Token = "0x400024B")]
		public const int k_iCallback = 1326;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nResultsReturned;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nTotalResultCount;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public PublishedFileId_t[] m_rgPublishedFileId;
	}
	[Token(Token = "0x200011C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B415C", Offset = "0x2B415C")]
	public struct RemoteStorageSetUserPublishedFileActionResult_t
	{
		[Token(Token = "0x4000250")]
		public const int k_iCallback = 1327;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public EWorkshopFileAction m_eAction;
	}
	[Token(Token = "0x200011D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4170", Offset = "0x2B4170")]
	public struct RemoteStorageEnumeratePublishedFilesByUserActionResult_t
	{
		[Token(Token = "0x4000254")]
		public const int k_iCallback = 1328;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EWorkshopFileAction m_eAction;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nResultsReturned;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_nTotalResultCount;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint[] m_rgRTimeUpdated;
	}
	[Token(Token = "0x200011E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4184", Offset = "0x2B4184")]
	public struct RemoteStoragePublishFileProgress_t
	{
		[Token(Token = "0x400025B")]
		public const int k_iCallback = 1329;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double m_dPercentFile;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool m_bPreview;
	}
	[Token(Token = "0x200011F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4198", Offset = "0x2B4198")]
	public struct RemoteStoragePublishedFileUpdated_t
	{
		[Token(Token = "0x400025E")]
		public const int k_iCallback = 1330;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public ulong m_ulUnused;
	}
	[Token(Token = "0x2000120")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B41AC", Offset = "0x2B41AC")]
	public struct RemoteStorageFileWriteAsyncComplete_t
	{
		[Token(Token = "0x4000262")]
		public const int k_iCallback = 1331;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x2000121")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B41C0", Offset = "0x2B41C0")]
	public struct RemoteStorageFileReadAsyncComplete_t
	{
		[Token(Token = "0x4000264")]
		public const int k_iCallback = 1332;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamAPICall_t m_hFileReadAsync;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_nOffset;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_cubRead;
	}
	[Token(Token = "0x2000122")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B41D4", Offset = "0x2B41D4")]
	public struct ScreenshotReady_t
	{
		[Token(Token = "0x4000269")]
		public const int k_iCallback = 2301;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ScreenshotHandle m_hLocal;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_eResult;
	}
	[Token(Token = "0x2000123")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B41E8", Offset = "0x2B41E8")]
	public struct ScreenshotRequested_t
	{
		[Token(Token = "0x400026C")]
		public const int k_iCallback = 2302;
	}
	[Token(Token = "0x2000124")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B41FC", Offset = "0x2B41FC")]
	public struct SteamUGCQueryCompleted_t
	{
		[Token(Token = "0x400026D")]
		public const int k_iCallback = 3401;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UGCQueryHandle_t m_handle;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_unNumResultsReturned;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_unTotalMatchingResults;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool m_bCachedData;
	}
	[Token(Token = "0x2000125")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4210", Offset = "0x2B4210")]
	public struct SteamUGCRequestUGCDetailsResult_t
	{
		[Token(Token = "0x4000273")]
		public const int k_iCallback = 3402;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamUGCDetails_t m_details;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool m_bCachedData;
	}
	[Token(Token = "0x2000126")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4224", Offset = "0x2B4224")]
	public struct CreateItemResult_t
	{
		[Token(Token = "0x4000276")]
		public const int k_iCallback = 3403;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
	[Token(Token = "0x2000127")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4238", Offset = "0x2B4238")]
	public struct SubmitItemUpdateResult_t
	{
		[Token(Token = "0x400027A")]
		public const int k_iCallback = 3404;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
	[Token(Token = "0x2000128")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B424C", Offset = "0x2B424C")]
	public struct ItemInstalled_t
	{
		[Token(Token = "0x400027E")]
		public const int k_iCallback = 3405;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_unAppID;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public PublishedFileId_t m_nPublishedFileId;
	}
	[Token(Token = "0x2000129")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4260", Offset = "0x2B4260")]
	public struct DownloadItemResult_t
	{
		[Token(Token = "0x4000281")]
		public const int k_iCallback = 3406;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AppId_t m_unAppID;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public EResult m_eResult;
	}
	[Token(Token = "0x200012A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4274", Offset = "0x2B4274")]
	public struct UserFavoriteItemsListChanged_t
	{
		[Token(Token = "0x4000285")]
		public const int k_iCallback = 3407;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bWasAddRequest;
	}
	[Token(Token = "0x200012B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4288", Offset = "0x2B4288")]
	public struct SetUserItemVoteResult_t
	{
		[Token(Token = "0x4000289")]
		public const int k_iCallback = 3408;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bVoteUp;
	}
	[Token(Token = "0x200012C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B429C", Offset = "0x2B429C")]
	public struct GetUserItemVoteResult_t
	{
		[Token(Token = "0x400028D")]
		public const int k_iCallback = 3409;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bVotedUp;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public bool m_bVotedDown;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public bool m_bVoteSkipped;
	}
	[Token(Token = "0x200012D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B42B0", Offset = "0x2B42B0")]
	public struct StartPlaytimeTrackingResult_t
	{
		[Token(Token = "0x4000293")]
		public const int k_iCallback = 3410;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x200012E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B42C4", Offset = "0x2B42C4")]
	public struct StopPlaytimeTrackingResult_t
	{
		[Token(Token = "0x4000295")]
		public const int k_iCallback = 3411;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x200012F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B42D8", Offset = "0x2B42D8")]
	public struct AddUGCDependencyResult_t
	{
		[Token(Token = "0x4000297")]
		public const int k_iCallback = 3412;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public PublishedFileId_t m_nChildPublishedFileId;
	}
	[Token(Token = "0x2000130")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B42EC", Offset = "0x2B42EC")]
	public struct RemoveUGCDependencyResult_t
	{
		[Token(Token = "0x400029B")]
		public const int k_iCallback = 3413;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public PublishedFileId_t m_nChildPublishedFileId;
	}
	[Token(Token = "0x2000131")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4300", Offset = "0x2B4300")]
	public struct AddAppDependencyResult_t
	{
		[Token(Token = "0x400029F")]
		public const int k_iCallback = 3414;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x2000132")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4314", Offset = "0x2B4314")]
	public struct RemoveAppDependencyResult_t
	{
		[Token(Token = "0x40002A3")]
		public const int k_iCallback = 3415;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AppId_t m_nAppID;
	}
	[Token(Token = "0x2000133")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4328", Offset = "0x2B4328")]
	public struct GetAppDependenciesResult_t
	{
		[Token(Token = "0x40002A7")]
		public const int k_iCallback = 3416;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AppId_t[] m_rgAppIDs;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint m_nNumAppDependencies;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint m_nTotalNumAppDependencies;
	}
	[Token(Token = "0x2000134")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B433C", Offset = "0x2B433C")]
	public struct DeleteItemResult_t
	{
		[Token(Token = "0x40002AD")]
		public const int k_iCallback = 3417;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public PublishedFileId_t m_nPublishedFileId;
	}
	[Token(Token = "0x2000135")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4350", Offset = "0x2B4350")]
	public struct SteamUnifiedMessagesSendMethodResult_t
	{
		[Token(Token = "0x40002B0")]
		public const int k_iCallback = 2501;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ClientUnifiedMessageHandle m_hHandle;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong m_unContext;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EResult m_eResult;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint m_unResponseSize;
	}
	[Token(Token = "0x2000136")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4364", Offset = "0x2B4364")]
	public struct SteamServersConnected_t
	{
		[Token(Token = "0x40002B5")]
		public const int k_iCallback = 101;
	}
	[Token(Token = "0x2000137")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4378", Offset = "0x2B4378")]
	public struct SteamServerConnectFailure_t
	{
		[Token(Token = "0x40002B6")]
		public const int k_iCallback = 102;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool m_bStillRetrying;
	}
	[Token(Token = "0x2000138")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B438C", Offset = "0x2B438C")]
	public struct SteamServersDisconnected_t
	{
		[Token(Token = "0x40002B9")]
		public const int k_iCallback = 103;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x2000139")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B43A0", Offset = "0x2B43A0")]
	public struct ClientGameServerDeny_t
	{
		[Token(Token = "0x40002BB")]
		public const int k_iCallback = 113;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_uAppID;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_unGameServerIP;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ushort m_usGameServerPort;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public ushort m_bSecure;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_uReason;
	}
	[Token(Token = "0x200013A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B43B4", Offset = "0x2B43B4")]
	public struct IPCFailure_t
	{
		[Token(Token = "0x40002C1")]
		public const int k_iCallback = 117;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_eFailureType;
	}
	[Token(Token = "0x200013B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B43C8", Offset = "0x2B43C8")]
	public struct LicensesUpdated_t
	{
		[Token(Token = "0x40002C3")]
		public const int k_iCallback = 125;
	}
	[Token(Token = "0x200013C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B43DC", Offset = "0x2B43DC")]
	public struct ValidateAuthTicketResponse_t
	{
		[Token(Token = "0x40002C4")]
		public const int k_iCallback = 143;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EAuthSessionResponse m_eAuthSessionResponse;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public CSteamID m_OwnerSteamID;
	}
	[Token(Token = "0x200013D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B43F0", Offset = "0x2B43F0")]
	public struct MicroTxnAuthorizationResponse_t
	{
		[Token(Token = "0x40002C8")]
		public const int k_iCallback = 152;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_unAppID;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ulong m_ulOrderID;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public byte m_bAuthorized;
	}
	[Token(Token = "0x200013E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4404", Offset = "0x2B4404")]
	public struct EncryptedAppTicketResponse_t
	{
		[Token(Token = "0x40002CC")]
		public const int k_iCallback = 154;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
	[Token(Token = "0x200013F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4418", Offset = "0x2B4418")]
	public struct GetAuthSessionTicketResponse_t
	{
		[Token(Token = "0x40002CE")]
		public const int k_iCallback = 163;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HAuthTicket m_hAuthTicket;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public EResult m_eResult;
	}
	[Token(Token = "0x2000140")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B442C", Offset = "0x2B442C")]
	public struct GameWebCallback_t
	{
		[Token(Token = "0x40002D1")]
		public const int k_iCallback = 164;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string m_szURL;
	}
	[Token(Token = "0x2000141")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4440", Offset = "0x2B4440")]
	public struct StoreAuthURLResponse_t
	{
		[Token(Token = "0x40002D3")]
		public const int k_iCallback = 165;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string m_szURL;
	}
	[StructLayout(2)]
	[Token(Token = "0x2000142")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4454", Offset = "0x2B4454")]
	public struct UserStatsReceived_t
	{
		[Token(Token = "0x40002D5")]
		public const int k_iCallback = 1101;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x2000143")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4468", Offset = "0x2B4468")]
	public struct UserStatsStored_t
	{
		[Token(Token = "0x40002D9")]
		public const int k_iCallback = 1102;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;
	}
	[Token(Token = "0x2000144")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B447C", Offset = "0x2B447C")]
	public struct UserAchievementStored_t
	{
		[Token(Token = "0x40002DC")]
		public const int k_iCallback = 1103;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool m_bGroupAchievement;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string m_rgchAchievementName;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint m_nCurProgress;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint m_nMaxProgress;
	}
	[Token(Token = "0x2000145")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4490", Offset = "0x2B4490")]
	public struct LeaderboardFindResult_t
	{
		[Token(Token = "0x40002E2")]
		public const int k_iCallback = 1104;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte m_bLeaderboardFound;
	}
	[Token(Token = "0x2000146")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B44A4", Offset = "0x2B44A4")]
	public struct LeaderboardScoresDownloaded_t
	{
		[Token(Token = "0x40002E5")]
		public const int k_iCallback = 1105;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SteamLeaderboardEntries_t m_hSteamLeaderboardEntries;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_cEntryCount;
	}
	[Token(Token = "0x2000147")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B44B8", Offset = "0x2B44B8")]
	public struct LeaderboardScoreUploaded_t
	{
		[Token(Token = "0x40002E9")]
		public const int k_iCallback = 1106;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_bSuccess;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_nScore;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte m_bScoreChanged;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int m_nGlobalRankNew;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_nGlobalRankPrevious;
	}
	[Token(Token = "0x2000148")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B44CC", Offset = "0x2B44CC")]
	public struct NumberOfCurrentPlayers_t
	{
		[Token(Token = "0x40002F0")]
		public const int k_iCallback = 1107;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_bSuccess;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_cPlayers;
	}
	[Token(Token = "0x2000149")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B44E0", Offset = "0x2B44E0")]
	public struct UserStatsUnloaded_t
	{
		[Token(Token = "0x40002F3")]
		public const int k_iCallback = 1108;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;
	}
	[Token(Token = "0x200014A")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B44F4", Offset = "0x2B44F4")]
	public struct UserAchievementIconFetched_t
	{
		[Token(Token = "0x40002F5")]
		public const int k_iCallback = 1109;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CGameID m_nGameID;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_rgchAchievementName;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool m_bAchieved;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_nIconHandle;
	}
	[Token(Token = "0x200014B")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4508", Offset = "0x2B4508")]
	public struct GlobalAchievementPercentagesReady_t
	{
		[Token(Token = "0x40002FA")]
		public const int k_iCallback = 1110;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;
	}
	[Token(Token = "0x200014C")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B451C", Offset = "0x2B451C")]
	public struct LeaderboardUGCSet_t
	{
		[Token(Token = "0x40002FD")]
		public const int k_iCallback = 1111;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public SteamLeaderboard_t m_hSteamLeaderboard;
	}
	[Token(Token = "0x200014D")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4530", Offset = "0x2B4530")]
	public struct GlobalStatsReceived_t
	{
		[Token(Token = "0x4000300")]
		public const int k_iCallback = 1112;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;
	}
	[Token(Token = "0x200014E")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4544", Offset = "0x2B4544")]
	public struct IPCountry_t
	{
		[Token(Token = "0x4000303")]
		public const int k_iCallback = 701;
	}
	[Token(Token = "0x200014F")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4558", Offset = "0x2B4558")]
	public struct LowBatteryPower_t
	{
		[Token(Token = "0x4000304")]
		public const int k_iCallback = 702;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_nMinutesBatteryLeft;
	}
	[Token(Token = "0x2000150")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B456C", Offset = "0x2B456C")]
	public struct SteamAPICallCompleted_t
	{
		[Token(Token = "0x4000306")]
		public const int k_iCallback = 703;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamAPICall_t m_hAsyncCall;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_iCallback;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_cubParam;
	}
	[Token(Token = "0x2000151")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4580", Offset = "0x2B4580")]
	public struct SteamShutdown_t
	{
		[Token(Token = "0x400030A")]
		public const int k_iCallback = 704;
	}
	[Token(Token = "0x2000152")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B4594", Offset = "0x2B4594")]
	public struct CheckFileSignature_t
	{
		[Token(Token = "0x400030B")]
		public const int k_iCallback = 705;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ECheckFileSignature m_eCheckFileSignature;
	}
	[Token(Token = "0x2000153")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B45A8", Offset = "0x2B45A8")]
	public struct GamepadTextInputDismissed_t
	{
		[Token(Token = "0x400030D")]
		public const int k_iCallback = 714;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool m_bSubmitted;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint m_unSubmittedText;
	}
	[Token(Token = "0x2000154")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B45BC", Offset = "0x2B45BC")]
	public struct BroadcastUploadStart_t
	{
		[Token(Token = "0x4000310")]
		public const int k_iCallback = 4604;
	}
	[Token(Token = "0x2000155")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B45D0", Offset = "0x2B45D0")]
	public struct BroadcastUploadStop_t
	{
		[Token(Token = "0x4000311")]
		public const int k_iCallback = 4605;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EBroadcastUploadResult m_eResult;
	}
	[Token(Token = "0x2000156")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B45E4", Offset = "0x2B45E4")]
	public struct GetVideoURLResult_t
	{
		[Token(Token = "0x4000313")]
		public const int k_iCallback = 4611;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public AppId_t m_unVideoAppID;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string m_rgchURL;
	}
	[Token(Token = "0x2000157")]
	[AttributeAttribute(Name = "CallbackIdentityAttribute", RVA = "0x2B45F8", Offset = "0x2B45F8")]
	public struct GetOPFSettingsResult_t
	{
		[Token(Token = "0x4000317")]
		public const int k_iCallback = 4624;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public AppId_t m_unVideoAppID;
	}
	[Token(Token = "0x2000158")]
	public static class Constants
	{
		[Token(Token = "0x400031A")]
		public const string STEAMAPPLIST_INTERFACE_VERSION = "STEAMAPPLIST_INTERFACE_VERSION001";

		[Token(Token = "0x400031B")]
		public const string STEAMAPPS_INTERFACE_VERSION = "STEAMAPPS_INTERFACE_VERSION008";

		[Token(Token = "0x400031C")]
		public const string STEAMAPPTICKET_INTERFACE_VERSION = "STEAMAPPTICKET_INTERFACE_VERSION001";

		[Token(Token = "0x400031D")]
		public const string STEAMCLIENT_INTERFACE_VERSION = "SteamClient017";

		[Token(Token = "0x400031E")]
		public const string STEAMCONTROLLER_INTERFACE_VERSION = "SteamController005";

		[Token(Token = "0x400031F")]
		public const string STEAMFRIENDS_INTERFACE_VERSION = "SteamFriends015";

		[Token(Token = "0x4000320")]
		public const string STEAMGAMECOORDINATOR_INTERFACE_VERSION = "SteamGameCoordinator001";

		[Token(Token = "0x4000321")]
		public const string STEAMGAMESERVER_INTERFACE_VERSION = "SteamGameServer012";

		[Token(Token = "0x4000322")]
		public const string STEAMGAMESERVERSTATS_INTERFACE_VERSION = "SteamGameServerStats001";

		[Token(Token = "0x4000323")]
		public const string STEAMHTMLSURFACE_INTERFACE_VERSION = "STEAMHTMLSURFACE_INTERFACE_VERSION_004";

		[Token(Token = "0x4000324")]
		public const string STEAMHTTP_INTERFACE_VERSION = "STEAMHTTP_INTERFACE_VERSION002";

		[Token(Token = "0x4000325")]
		public const string STEAMINVENTORY_INTERFACE_VERSION = "STEAMINVENTORY_INTERFACE_V002";

		[Token(Token = "0x4000326")]
		public const string STEAMMATCHMAKING_INTERFACE_VERSION = "SteamMatchMaking009";

		[Token(Token = "0x4000327")]
		public const string STEAMMATCHMAKINGSERVERS_INTERFACE_VERSION = "SteamMatchMakingServers002";

		[Token(Token = "0x4000328")]
		public const string STEAMMUSIC_INTERFACE_VERSION = "STEAMMUSIC_INTERFACE_VERSION001";

		[Token(Token = "0x4000329")]
		public const string STEAMMUSICREMOTE_INTERFACE_VERSION = "STEAMMUSICREMOTE_INTERFACE_VERSION001";

		[Token(Token = "0x400032A")]
		public const string STEAMNETWORKING_INTERFACE_VERSION = "SteamNetworking005";

		[Token(Token = "0x400032B")]
		public const string STEAMPARENTALSETTINGS_INTERFACE_VERSION = "STEAMPARENTALSETTINGS_INTERFACE_VERSION001";

		[Token(Token = "0x400032C")]
		public const string STEAMREMOTESTORAGE_INTERFACE_VERSION = "STEAMREMOTESTORAGE_INTERFACE_VERSION014";

		[Token(Token = "0x400032D")]
		public const string STEAMSCREENSHOTS_INTERFACE_VERSION = "STEAMSCREENSHOTS_INTERFACE_VERSION003";

		[Token(Token = "0x400032E")]
		public const string STEAMUGC_INTERFACE_VERSION = "STEAMUGC_INTERFACE_VERSION010";

		[Token(Token = "0x400032F")]
		public const string STEAMUNIFIEDMESSAGES_INTERFACE_VERSION = "STEAMUNIFIEDMESSAGES_INTERFACE_VERSION001";

		[Token(Token = "0x4000330")]
		public const string STEAMUSER_INTERFACE_VERSION = "SteamUser019";

		[Token(Token = "0x4000331")]
		public const string STEAMUSERSTATS_INTERFACE_VERSION = "STEAMUSERSTATS_INTERFACE_VERSION011";

		[Token(Token = "0x4000332")]
		public const string STEAMUTILS_INTERFACE_VERSION = "SteamUtils009";

		[Token(Token = "0x4000333")]
		public const string STEAMVIDEO_INTERFACE_VERSION = "STEAMVIDEO_INTERFACE_V002";

		[Token(Token = "0x4000334")]
		public const int k_cubAppProofOfPurchaseKeyMax = 240;

		[Token(Token = "0x4000335")]
		public const int k_iSteamUserCallbacks = 100;

		[Token(Token = "0x4000336")]
		public const int k_iSteamGameServerCallbacks = 200;

		[Token(Token = "0x4000337")]
		public const int k_iSteamFriendsCallbacks = 300;

		[Token(Token = "0x4000338")]
		public const int k_iSteamBillingCallbacks = 400;

		[Token(Token = "0x4000339")]
		public const int k_iSteamMatchmakingCallbacks = 500;

		[Token(Token = "0x400033A")]
		public const int k_iSteamContentServerCallbacks = 600;

		[Token(Token = "0x400033B")]
		public const int k_iSteamUtilsCallbacks = 700;

		[Token(Token = "0x400033C")]
		public const int k_iClientFriendsCallbacks = 800;

		[Token(Token = "0x400033D")]
		public const int k_iClientUserCallbacks = 900;

		[Token(Token = "0x400033E")]
		public const int k_iSteamAppsCallbacks = 1000;

		[Token(Token = "0x400033F")]
		public const int k_iSteamUserStatsCallbacks = 1100;

		[Token(Token = "0x4000340")]
		public const int k_iSteamNetworkingCallbacks = 1200;

		[Token(Token = "0x4000341")]
		public const int k_iClientRemoteStorageCallbacks = 1300;

		[Token(Token = "0x4000342")]
		public const int k_iClientDepotBuilderCallbacks = 1400;

		[Token(Token = "0x4000343")]
		public const int k_iSteamGameServerItemsCallbacks = 1500;

		[Token(Token = "0x4000344")]
		public const int k_iClientUtilsCallbacks = 1600;

		[Token(Token = "0x4000345")]
		public const int k_iSteamGameCoordinatorCallbacks = 1700;

		[Token(Token = "0x4000346")]
		public const int k_iSteamGameServerStatsCallbacks = 1800;

		[Token(Token = "0x4000347")]
		public const int k_iSteam2AsyncCallbacks = 1900;

		[Token(Token = "0x4000348")]
		public const int k_iSteamGameStatsCallbacks = 2000;

		[Token(Token = "0x4000349")]
		public const int k_iClientHTTPCallbacks = 2100;

		[Token(Token = "0x400034A")]
		public const int k_iClientScreenshotsCallbacks = 2200;

		[Token(Token = "0x400034B")]
		public const int k_iSteamScreenshotsCallbacks = 2300;

		[Token(Token = "0x400034C")]
		public const int k_iClientAudioCallbacks = 2400;

		[Token(Token = "0x400034D")]
		public const int k_iClientUnifiedMessagesCallbacks = 2500;

		[Token(Token = "0x400034E")]
		public const int k_iSteamStreamLauncherCallbacks = 2600;

		[Token(Token = "0x400034F")]
		public const int k_iClientControllerCallbacks = 2700;

		[Token(Token = "0x4000350")]
		public const int k_iSteamControllerCallbacks = 2800;

		[Token(Token = "0x4000351")]
		public const int k_iClientParentalSettingsCallbacks = 2900;

		[Token(Token = "0x4000352")]
		public const int k_iClientDeviceAuthCallbacks = 3000;

		[Token(Token = "0x4000353")]
		public const int k_iClientNetworkDeviceManagerCallbacks = 3100;

		[Token(Token = "0x4000354")]
		public const int k_iClientMusicCallbacks = 3200;

		[Token(Token = "0x4000355")]
		public const int k_iClientRemoteClientManagerCallbacks = 3300;

		[Token(Token = "0x4000356")]
		public const int k_iClientUGCCallbacks = 3400;

		[Token(Token = "0x4000357")]
		public const int k_iSteamStreamClientCallbacks = 3500;

		[Token(Token = "0x4000358")]
		public const int k_IClientProductBuilderCallbacks = 3600;

		[Token(Token = "0x4000359")]
		public const int k_iClientShortcutsCallbacks = 3700;

		[Token(Token = "0x400035A")]
		public const int k_iClientRemoteControlManagerCallbacks = 3800;

		[Token(Token = "0x400035B")]
		public const int k_iSteamAppListCallbacks = 3900;

		[Token(Token = "0x400035C")]
		public const int k_iSteamMusicCallbacks = 4000;

		[Token(Token = "0x400035D")]
		public const int k_iSteamMusicRemoteCallbacks = 4100;

		[Token(Token = "0x400035E")]
		public const int k_iClientVRCallbacks = 4200;

		[Token(Token = "0x400035F")]
		public const int k_iClientGameNotificationCallbacks = 4300;

		[Token(Token = "0x4000360")]
		public const int k_iSteamGameNotificationCallbacks = 4400;

		[Token(Token = "0x4000361")]
		public const int k_iSteamHTMLSurfaceCallbacks = 4500;

		[Token(Token = "0x4000362")]
		public const int k_iClientVideoCallbacks = 4600;

		[Token(Token = "0x4000363")]
		public const int k_iClientInventoryCallbacks = 4700;

		[Token(Token = "0x4000364")]
		public const int k_iClientBluetoothManagerCallbacks = 4800;

		[Token(Token = "0x4000365")]
		public const int k_iClientSharedConnectionCallbacks = 4900;

		[Token(Token = "0x4000366")]
		public const int k_ISteamParentalSettingsCallbacks = 5000;

		[Token(Token = "0x4000367")]
		public const int k_cchMaxFriendsGroupName = 64;

		[Token(Token = "0x4000368")]
		public const int k_cFriendsGroupLimit = 100;

		[Token(Token = "0x4000369")]
		public const int k_cEnumerateFollowersMax = 50;

		[Token(Token = "0x400036A")]
		public const int k_cchPersonaNameMax = 128;

		[Token(Token = "0x400036B")]
		public const int k_cwchPersonaNameMax = 32;

		[Token(Token = "0x400036C")]
		public const int k_cubChatMetadataMax = 8192;

		[Token(Token = "0x400036D")]
		public const int k_cchMaxRichPresenceKeys = 20;

		[Token(Token = "0x400036E")]
		public const int k_cchMaxRichPresenceKeyLength = 64;

		[Token(Token = "0x400036F")]
		public const int k_cchMaxRichPresenceValueLength = 256;

		[Token(Token = "0x4000370")]
		public const int k_unServerFlagNone = 0;

		[Token(Token = "0x4000371")]
		public const int k_unServerFlagActive = 1;

		[Token(Token = "0x4000372")]
		public const int k_unServerFlagSecure = 2;

		[Token(Token = "0x4000373")]
		public const int k_unServerFlagDedicated = 4;

		[Token(Token = "0x4000374")]
		public const int k_unServerFlagLinux = 8;

		[Token(Token = "0x4000375")]
		public const int k_unServerFlagPassworded = 16;

		[Token(Token = "0x4000376")]
		public const int k_unServerFlagPrivate = 32;

		[Token(Token = "0x4000377")]
		public const int k_unFavoriteFlagNone = 0;

		[Token(Token = "0x4000378")]
		public const int k_unFavoriteFlagFavorite = 1;

		[Token(Token = "0x4000379")]
		public const int k_unFavoriteFlagHistory = 2;

		[Token(Token = "0x400037A")]
		public const int k_unMaxCloudFileChunkSize = 104857600;

		[Token(Token = "0x400037B")]
		public const int k_cchPublishedDocumentTitleMax = 129;

		[Token(Token = "0x400037C")]
		public const int k_cchPublishedDocumentDescriptionMax = 8000;

		[Token(Token = "0x400037D")]
		public const int k_cchPublishedDocumentChangeDescriptionMax = 8000;

		[Token(Token = "0x400037E")]
		public const int k_unEnumeratePublishedFilesMaxResults = 50;

		[Token(Token = "0x400037F")]
		public const int k_cchTagListMax = 1025;

		[Token(Token = "0x4000380")]
		public const int k_cchFilenameMax = 260;

		[Token(Token = "0x4000381")]
		public const int k_cchPublishedFileURLMax = 256;

		[Token(Token = "0x4000382")]
		public const int k_nScreenshotMaxTaggedUsers = 32;

		[Token(Token = "0x4000383")]
		public const int k_nScreenshotMaxTaggedPublishedFiles = 32;

		[Token(Token = "0x4000384")]
		public const int k_cubUFSTagTypeMax = 255;

		[Token(Token = "0x4000385")]
		public const int k_cubUFSTagValueMax = 255;

		[Token(Token = "0x4000386")]
		public const int k_ScreenshotThumbWidth = 200;

		[Token(Token = "0x4000387")]
		public const int kNumUGCResultsPerPage = 50;

		[Token(Token = "0x4000388")]
		public const int k_cchDeveloperMetadataMax = 5000;

		[Token(Token = "0x4000389")]
		public const int k_cchStatNameMax = 128;

		[Token(Token = "0x400038A")]
		public const int k_cchLeaderboardNameMax = 128;

		[Token(Token = "0x400038B")]
		public const int k_cLeaderboardDetailsMax = 64;

		[Token(Token = "0x400038C")]
		public const int k_cbMaxGameServerGameDir = 32;

		[Token(Token = "0x400038D")]
		public const int k_cbMaxGameServerMapName = 32;

		[Token(Token = "0x400038E")]
		public const int k_cbMaxGameServerGameDescription = 64;

		[Token(Token = "0x400038F")]
		public const int k_cbMaxGameServerName = 64;

		[Token(Token = "0x4000390")]
		public const int k_cbMaxGameServerTags = 128;

		[Token(Token = "0x4000391")]
		public const int k_cbMaxGameServerGameData = 2048;

		[Token(Token = "0x4000392")]
		public const int k_unSteamAccountIDMask = -1;

		[Token(Token = "0x4000393")]
		public const int k_unSteamAccountInstanceMask = 1048575;

		[Token(Token = "0x4000394")]
		public const int k_unSteamUserDesktopInstance = 1;

		[Token(Token = "0x4000395")]
		public const int k_unSteamUserConsoleInstance = 2;

		[Token(Token = "0x4000396")]
		public const int k_unSteamUserWebInstance = 4;

		[Token(Token = "0x4000397")]
		public const int k_cchGameExtraInfoMax = 64;

		[Token(Token = "0x4000398")]
		public const int k_nSteamEncryptedAppTicketSymmetricKeyLen = 32;

		[Token(Token = "0x4000399")]
		public const int k_cubSaltSize = 8;

		[Token(Token = "0x400039A")]
		public const ulong k_GIDNil = ulong.MaxValue;

		[Token(Token = "0x400039B")]
		public const ulong k_TxnIDNil = ulong.MaxValue;

		[Token(Token = "0x400039C")]
		public const ulong k_TxnIDUnknown = 0uL;

		[Token(Token = "0x400039D")]
		public const int k_uPackageIdFreeSub = 0;

		[Token(Token = "0x400039E")]
		public const int k_uPackageIdInvalid = -1;

		[Token(Token = "0x400039F")]
		public const ulong k_ulAssetClassIdInvalid = 0uL;

		[Token(Token = "0x40003A0")]
		public const int k_uPhysicalItemIdInvalid = 0;

		[Token(Token = "0x40003A1")]
		public const int k_uCellIDInvalid = -1;

		[Token(Token = "0x40003A2")]
		public const int k_uPartnerIdInvalid = 0;

		[Token(Token = "0x40003A3")]
		public const int STEAM_CONTROLLER_MAX_COUNT = 16;

		[Token(Token = "0x40003A4")]
		public const int STEAM_CONTROLLER_MAX_ANALOG_ACTIONS = 16;

		[Token(Token = "0x40003A5")]
		public const int STEAM_CONTROLLER_MAX_DIGITAL_ACTIONS = 128;

		[Token(Token = "0x40003A6")]
		public const int STEAM_CONTROLLER_MAX_ORIGINS = 8;

		[Token(Token = "0x40003A7")]
		public const ulong STEAM_CONTROLLER_HANDLE_ALL_CONTROLLERS = ulong.MaxValue;

		[Token(Token = "0x40003A8")]
		public const float STEAM_CONTROLLER_MIN_ANALOG_ACTION_DATA = -1f;

		[Token(Token = "0x40003A9")]
		public const float STEAM_CONTROLLER_MAX_ANALOG_ACTION_DATA = 1f;

		[Token(Token = "0x40003AA")]
		public const ushort MASTERSERVERUPDATERPORT_USEGAMESOCKETSHARE = ushort.MaxValue;

		[Token(Token = "0x40003AB")]
		public const int INVALID_HTTPREQUEST_HANDLE = 0;

		[Token(Token = "0x40003AC")]
		public const byte k_nMaxLobbyKeyLength = byte.MaxValue;

		[Token(Token = "0x40003AD")]
		public const int k_SteamMusicNameMaxLength = 255;

		[Token(Token = "0x40003AE")]
		public const int k_SteamMusicPNGMaxLength = 65535;

		[Token(Token = "0x40003AF")]
		public const int QUERY_PORT_NOT_INITIALIZED = 65535;

		[Token(Token = "0x40003B0")]
		public const int QUERY_PORT_ERROR = 65534;
	}
	[Token(Token = "0x2000159")]
	public enum ERegisterActivationCodeResult
	{
		[Token(Token = "0x40003B2")]
		k_ERegisterActivationCodeResultOK,
		[Token(Token = "0x40003B3")]
		k_ERegisterActivationCodeResultFail,
		[Token(Token = "0x40003B4")]
		k_ERegisterActivationCodeResultAlreadyRegistered,
		[Token(Token = "0x40003B5")]
		k_ERegisterActivationCodeResultTimeout,
		[Token(Token = "0x40003B6")]
		k_ERegisterActivationCodeAlreadyOwned
	}
	[Token(Token = "0x200015A")]
	public enum ESteamControllerPad
	{
		[Token(Token = "0x40003B8")]
		k_ESteamControllerPad_Left,
		[Token(Token = "0x40003B9")]
		k_ESteamControllerPad_Right
	}
	[Token(Token = "0x200015B")]
	public enum EControllerSource
	{
		[Token(Token = "0x40003BB")]
		k_EControllerSource_None,
		[Token(Token = "0x40003BC")]
		k_EControllerSource_LeftTrackpad,
		[Token(Token = "0x40003BD")]
		k_EControllerSource_RightTrackpad,
		[Token(Token = "0x40003BE")]
		k_EControllerSource_Joystick,
		[Token(Token = "0x40003BF")]
		k_EControllerSource_ABXY,
		[Token(Token = "0x40003C0")]
		k_EControllerSource_Switch,
		[Token(Token = "0x40003C1")]
		k_EControllerSource_LeftTrigger,
		[Token(Token = "0x40003C2")]
		k_EControllerSource_RightTrigger,
		[Token(Token = "0x40003C3")]
		k_EControllerSource_Gyro,
		[Token(Token = "0x40003C4")]
		k_EControllerSource_CenterTrackpad,
		[Token(Token = "0x40003C5")]
		k_EControllerSource_RightJoystick,
		[Token(Token = "0x40003C6")]
		k_EControllerSource_DPad,
		[Token(Token = "0x40003C7")]
		k_EControllerSource_Count
	}
	[Token(Token = "0x200015C")]
	public enum EControllerSourceMode
	{
		[Token(Token = "0x40003C9")]
		k_EControllerSourceMode_None,
		[Token(Token = "0x40003CA")]
		k_EControllerSourceMode_Dpad,
		[Token(Token = "0x40003CB")]
		k_EControllerSourceMode_Buttons,
		[Token(Token = "0x40003CC")]
		k_EControllerSourceMode_FourButtons,
		[Token(Token = "0x40003CD")]
		k_EControllerSourceMode_AbsoluteMouse,
		[Token(Token = "0x40003CE")]
		k_EControllerSourceMode_RelativeMouse,
		[Token(Token = "0x40003CF")]
		k_EControllerSourceMode_JoystickMove,
		[Token(Token = "0x40003D0")]
		k_EControllerSourceMode_JoystickMouse,
		[Token(Token = "0x40003D1")]
		k_EControllerSourceMode_JoystickCamera,
		[Token(Token = "0x40003D2")]
		k_EControllerSourceMode_ScrollWheel,
		[Token(Token = "0x40003D3")]
		k_EControllerSourceMode_Trigger,
		[Token(Token = "0x40003D4")]
		k_EControllerSourceMode_TouchMenu,
		[Token(Token = "0x40003D5")]
		k_EControllerSourceMode_MouseJoystick,
		[Token(Token = "0x40003D6")]
		k_EControllerSourceMode_MouseRegion,
		[Token(Token = "0x40003D7")]
		k_EControllerSourceMode_RadialMenu,
		[Token(Token = "0x40003D8")]
		k_EControllerSourceMode_SingleButton,
		[Token(Token = "0x40003D9")]
		k_EControllerSourceMode_Switches
	}
	[Token(Token = "0x200015D")]
	public enum EControllerActionOrigin
	{
		[Token(Token = "0x40003DB")]
		k_EControllerActionOrigin_None,
		[Token(Token = "0x40003DC")]
		k_EControllerActionOrigin_A,
		[Token(Token = "0x40003DD")]
		k_EControllerActionOrigin_B,
		[Token(Token = "0x40003DE")]
		k_EControllerActionOrigin_X,
		[Token(Token = "0x40003DF")]
		k_EControllerActionOrigin_Y,
		[Token(Token = "0x40003E0")]
		k_EControllerActionOrigin_LeftBumper,
		[Token(Token = "0x40003E1")]
		k_EControllerActionOrigin_RightBumper,
		[Token(Token = "0x40003E2")]
		k_EControllerActionOrigin_LeftGrip,
		[Token(Token = "0x40003E3")]
		k_EControllerActionOrigin_RightGrip,
		[Token(Token = "0x40003E4")]
		k_EControllerActionOrigin_Start,
		[Token(Token = "0x40003E5")]
		k_EControllerActionOrigin_Back,
		[Token(Token = "0x40003E6")]
		k_EControllerActionOrigin_LeftPad_Touch,
		[Token(Token = "0x40003E7")]
		k_EControllerActionOrigin_LeftPad_Swipe,
		[Token(Token = "0x40003E8")]
		k_EControllerActionOrigin_LeftPad_Click,
		[Token(Token = "0x40003E9")]
		k_EControllerActionOrigin_LeftPad_DPadNorth,
		[Token(Token = "0x40003EA")]
		k_EControllerActionOrigin_LeftPad_DPadSouth,
		[Token(Token = "0x40003EB")]
		k_EControllerActionOrigin_LeftPad_DPadWest,
		[Token(Token = "0x40003EC")]
		k_EControllerActionOrigin_LeftPad_DPadEast,
		[Token(Token = "0x40003ED")]
		k_EControllerActionOrigin_RightPad_Touch,
		[Token(Token = "0x40003EE")]
		k_EControllerActionOrigin_RightPad_Swipe,
		[Token(Token = "0x40003EF")]
		k_EControllerActionOrigin_RightPad_Click,
		[Token(Token = "0x40003F0")]
		k_EControllerActionOrigin_RightPad_DPadNorth,
		[Token(Token = "0x40003F1")]
		k_EControllerActionOrigin_RightPad_DPadSouth,
		[Token(Token = "0x40003F2")]
		k_EControllerActionOrigin_RightPad_DPadWest,
		[Token(Token = "0x40003F3")]
		k_EControllerActionOrigin_RightPad_DPadEast,
		[Token(Token = "0x40003F4")]
		k_EControllerActionOrigin_LeftTrigger_Pull,
		[Token(Token = "0x40003F5")]
		k_EControllerActionOrigin_LeftTrigger_Click,
		[Token(Token = "0x40003F6")]
		k_EControllerActionOrigin_RightTrigger_Pull,
		[Token(Token = "0x40003F7")]
		k_EControllerActionOrigin_RightTrigger_Click,
		[Token(Token = "0x40003F8")]
		k_EControllerActionOrigin_LeftStick_Move,
		[Token(Token = "0x40003F9")]
		k_EControllerActionOrigin_LeftStick_Click,
		[Token(Token = "0x40003FA")]
		k_EControllerActionOrigin_LeftStick_DPadNorth,
		[Token(Token = "0x40003FB")]
		k_EControllerActionOrigin_LeftStick_DPadSouth,
		[Token(Token = "0x40003FC")]
		k_EControllerActionOrigin_LeftStick_DPadWest,
		[Token(Token = "0x40003FD")]
		k_EControllerActionOrigin_LeftStick_DPadEast,
		[Token(Token = "0x40003FE")]
		k_EControllerActionOrigin_Gyro_Move,
		[Token(Token = "0x40003FF")]
		k_EControllerActionOrigin_Gyro_Pitch,
		[Token(Token = "0x4000400")]
		k_EControllerActionOrigin_Gyro_Yaw,
		[Token(Token = "0x4000401")]
		k_EControllerActionOrigin_Gyro_Roll,
		[Token(Token = "0x4000402")]
		k_EControllerActionOrigin_PS4_X,
		[Token(Token = "0x4000403")]
		k_EControllerActionOrigin_PS4_Circle,
		[Token(Token = "0x4000404")]
		k_EControllerActionOrigin_PS4_Triangle,
		[Token(Token = "0x4000405")]
		k_EControllerActionOrigin_PS4_Square,
		[Token(Token = "0x4000406")]
		k_EControllerActionOrigin_PS4_LeftBumper,
		[Token(Token = "0x4000407")]
		k_EControllerActionOrigin_PS4_RightBumper,
		[Token(Token = "0x4000408")]
		k_EControllerActionOrigin_PS4_Options,
		[Token(Token = "0x4000409")]
		k_EControllerActionOrigin_PS4_Share,
		[Token(Token = "0x400040A")]
		k_EControllerActionOrigin_PS4_LeftPad_Touch,
		[Token(Token = "0x400040B")]
		k_EControllerActionOrigin_PS4_LeftPad_Swipe,
		[Token(Token = "0x400040C")]
		k_EControllerActionOrigin_PS4_LeftPad_Click,
		[Token(Token = "0x400040D")]
		k_EControllerActionOrigin_PS4_LeftPad_DPadNorth,
		[Token(Token = "0x400040E")]
		k_EControllerActionOrigin_PS4_LeftPad_DPadSouth,
		[Token(Token = "0x400040F")]
		k_EControllerActionOrigin_PS4_LeftPad_DPadWest,
		[Token(Token = "0x4000410")]
		k_EControllerActionOrigin_PS4_LeftPad_DPadEast,
		[Token(Token = "0x4000411")]
		k_EControllerActionOrigin_PS4_RightPad_Touch,
		[Token(Token = "0x4000412")]
		k_EControllerActionOrigin_PS4_RightPad_Swipe,
		[Token(Token = "0x4000413")]
		k_EControllerActionOrigin_PS4_RightPad_Click,
		[Token(Token = "0x4000414")]
		k_EControllerActionOrigin_PS4_RightPad_DPadNorth,
		[Token(Token = "0x4000415")]
		k_EControllerActionOrigin_PS4_RightPad_DPadSouth,
		[Token(Token = "0x4000416")]
		k_EControllerActionOrigin_PS4_RightPad_DPadWest,
		[Token(Token = "0x4000417")]
		k_EControllerActionOrigin_PS4_RightPad_DPadEast,
		[Token(Token = "0x4000418")]
		k_EControllerActionOrigin_PS4_CenterPad_Touch,
		[Token(Token = "0x4000419")]
		k_EControllerActionOrigin_PS4_CenterPad_Swipe,
		[Token(Token = "0x400041A")]
		k_EControllerActionOrigin_PS4_CenterPad_Click,
		[Token(Token = "0x400041B")]
		k_EControllerActionOrigin_PS4_CenterPad_DPadNorth,
		[Token(Token = "0x400041C")]
		k_EControllerActionOrigin_PS4_CenterPad_DPadSouth,
		[Token(Token = "0x400041D")]
		k_EControllerActionOrigin_PS4_CenterPad_DPadWest,
		[Token(Token = "0x400041E")]
		k_EControllerActionOrigin_PS4_CenterPad_DPadEast,
		[Token(Token = "0x400041F")]
		k_EControllerActionOrigin_PS4_LeftTrigger_Pull,
		[Token(Token = "0x4000420")]
		k_EControllerActionOrigin_PS4_LeftTrigger_Click,
		[Token(Token = "0x4000421")]
		k_EControllerActionOrigin_PS4_RightTrigger_Pull,
		[Token(Token = "0x4000422")]
		k_EControllerActionOrigin_PS4_RightTrigger_Click,
		[Token(Token = "0x4000423")]
		k_EControllerActionOrigin_PS4_LeftStick_Move,
		[Token(Token = "0x4000424")]
		k_EControllerActionOrigin_PS4_LeftStick_Click,
		[Token(Token = "0x4000425")]
		k_EControllerActionOrigin_PS4_LeftStick_DPadNorth,
		[Token(Token = "0x4000426")]
		k_EControllerActionOrigin_PS4_LeftStick_DPadSouth,
		[Token(Token = "0x4000427")]
		k_EControllerActionOrigin_PS4_LeftStick_DPadWest,
		[Token(Token = "0x4000428")]
		k_EControllerActionOrigin_PS4_LeftStick_DPadEast,
		[Token(Token = "0x4000429")]
		k_EControllerActionOrigin_PS4_RightStick_Move,
		[Token(Token = "0x400042A")]
		k_EControllerActionOrigin_PS4_RightStick_Click,
		[Token(Token = "0x400042B")]
		k_EControllerActionOrigin_PS4_RightStick_DPadNorth,
		[Token(Token = "0x400042C")]
		k_EControllerActionOrigin_PS4_RightStick_DPadSouth,
		[Token(Token = "0x400042D")]
		k_EControllerActionOrigin_PS4_RightStick_DPadWest,
		[Token(Token = "0x400042E")]
		k_EControllerActionOrigin_PS4_RightStick_DPadEast,
		[Token(Token = "0x400042F")]
		k_EControllerActionOrigin_PS4_DPad_North,
		[Token(Token = "0x4000430")]
		k_EControllerActionOrigin_PS4_DPad_South,
		[Token(Token = "0x4000431")]
		k_EControllerActionOrigin_PS4_DPad_West,
		[Token(Token = "0x4000432")]
		k_EControllerActionOrigin_PS4_DPad_East,
		[Token(Token = "0x4000433")]
		k_EControllerActionOrigin_PS4_Gyro_Move,
		[Token(Token = "0x4000434")]
		k_EControllerActionOrigin_PS4_Gyro_Pitch,
		[Token(Token = "0x4000435")]
		k_EControllerActionOrigin_PS4_Gyro_Yaw,
		[Token(Token = "0x4000436")]
		k_EControllerActionOrigin_PS4_Gyro_Roll,
		[Token(Token = "0x4000437")]
		k_EControllerActionOrigin_XBoxOne_A,
		[Token(Token = "0x4000438")]
		k_EControllerActionOrigin_XBoxOne_B,
		[Token(Token = "0x4000439")]
		k_EControllerActionOrigin_XBoxOne_X,
		[Token(Token = "0x400043A")]
		k_EControllerActionOrigin_XBoxOne_Y,
		[Token(Token = "0x400043B")]
		k_EControllerActionOrigin_XBoxOne_LeftBumper,
		[Token(Token = "0x400043C")]
		k_EControllerActionOrigin_XBoxOne_RightBumper,
		[Token(Token = "0x400043D")]
		k_EControllerActionOrigin_XBoxOne_Menu,
		[Token(Token = "0x400043E")]
		k_EControllerActionOrigin_XBoxOne_View,
		[Token(Token = "0x400043F")]
		k_EControllerActionOrigin_XBoxOne_LeftTrigger_Pull,
		[Token(Token = "0x4000440")]
		k_EControllerActionOrigin_XBoxOne_LeftTrigger_Click,
		[Token(Token = "0x4000441")]
		k_EControllerActionOrigin_XBoxOne_RightTrigger_Pull,
		[Token(Token = "0x4000442")]
		k_EControllerActionOrigin_XBoxOne_RightTrigger_Click,
		[Token(Token = "0x4000443")]
		k_EControllerActionOrigin_XBoxOne_LeftStick_Move,
		[Token(Token = "0x4000444")]
		k_EControllerActionOrigin_XBoxOne_LeftStick_Click,
		[Token(Token = "0x4000445")]
		k_EControllerActionOrigin_XBoxOne_LeftStick_DPadNorth,
		[Token(Token = "0x4000446")]
		k_EControllerActionOrigin_XBoxOne_LeftStick_DPadSouth,
		[Token(Token = "0x4000447")]
		k_EControllerActionOrigin_XBoxOne_LeftStick_DPadWest,
		[Token(Token = "0x4000448")]
		k_EControllerActionOrigin_XBoxOne_LeftStick_DPadEast,
		[Token(Token = "0x4000449")]
		k_EControllerActionOrigin_XBoxOne_RightStick_Move,
		[Token(Token = "0x400044A")]
		k_EControllerActionOrigin_XBoxOne_RightStick_Click,
		[Token(Token = "0x400044B")]
		k_EControllerActionOrigin_XBoxOne_RightStick_DPadNorth,
		[Token(Token = "0x400044C")]
		k_EControllerActionOrigin_XBoxOne_RightStick_DPadSouth,
		[Token(Token = "0x400044D")]
		k_EControllerActionOrigin_XBoxOne_RightStick_DPadWest,
		[Token(Token = "0x400044E")]
		k_EControllerActionOrigin_XBoxOne_RightStick_DPadEast,
		[Token(Token = "0x400044F")]
		k_EControllerActionOrigin_XBoxOne_DPad_North,
		[Token(Token = "0x4000450")]
		k_EControllerActionOrigin_XBoxOne_DPad_South,
		[Token(Token = "0x4000451")]
		k_EControllerActionOrigin_XBoxOne_DPad_West,
		[Token(Token = "0x4000452")]
		k_EControllerActionOrigin_XBoxOne_DPad_East,
		[Token(Token = "0x4000453")]
		k_EControllerActionOrigin_XBox360_A,
		[Token(Token = "0x4000454")]
		k_EControllerActionOrigin_XBox360_B,
		[Token(Token = "0x4000455")]
		k_EControllerActionOrigin_XBox360_X,
		[Token(Token = "0x4000456")]
		k_EControllerActionOrigin_XBox360_Y,
		[Token(Token = "0x4000457")]
		k_EControllerActionOrigin_XBox360_LeftBumper,
		[Token(Token = "0x4000458")]
		k_EControllerActionOrigin_XBox360_RightBumper,
		[Token(Token = "0x4000459")]
		k_EControllerActionOrigin_XBox360_Start,
		[Token(Token = "0x400045A")]
		k_EControllerActionOrigin_XBox360_Back,
		[Token(Token = "0x400045B")]
		k_EControllerActionOrigin_XBox360_LeftTrigger_Pull,
		[Token(Token = "0x400045C")]
		k_EControllerActionOrigin_XBox360_LeftTrigger_Click,
		[Token(Token = "0x400045D")]
		k_EControllerActionOrigin_XBox360_RightTrigger_Pull,
		[Token(Token = "0x400045E")]
		k_EControllerActionOrigin_XBox360_RightTrigger_Click,
		[Token(Token = "0x400045F")]
		k_EControllerActionOrigin_XBox360_LeftStick_Move,
		[Token(Token = "0x4000460")]
		k_EControllerActionOrigin_XBox360_LeftStick_Click,
		[Token(Token = "0x4000461")]
		k_EControllerActionOrigin_XBox360_LeftStick_DPadNorth,
		[Token(Token = "0x4000462")]
		k_EControllerActionOrigin_XBox360_LeftStick_DPadSouth,
		[Token(Token = "0x4000463")]
		k_EControllerActionOrigin_XBox360_LeftStick_DPadWest,
		[Token(Token = "0x4000464")]
		k_EControllerActionOrigin_XBox360_LeftStick_DPadEast,
		[Token(Token = "0x4000465")]
		k_EControllerActionOrigin_XBox360_RightStick_Move,
		[Token(Token = "0x4000466")]
		k_EControllerActionOrigin_XBox360_RightStick_Click,
		[Token(Token = "0x4000467")]
		k_EControllerActionOrigin_XBox360_RightStick_DPadNorth,
		[Token(Token = "0x4000468")]
		k_EControllerActionOrigin_XBox360_RightStick_DPadSouth,
		[Token(Token = "0x4000469")]
		k_EControllerActionOrigin_XBox360_RightStick_DPadWest,
		[Token(Token = "0x400046A")]
		k_EControllerActionOrigin_XBox360_RightStick_DPadEast,
		[Token(Token = "0x400046B")]
		k_EControllerActionOrigin_XBox360_DPad_North,
		[Token(Token = "0x400046C")]
		k_EControllerActionOrigin_XBox360_DPad_South,
		[Token(Token = "0x400046D")]
		k_EControllerActionOrigin_XBox360_DPad_West,
		[Token(Token = "0x400046E")]
		k_EControllerActionOrigin_XBox360_DPad_East,
		[Token(Token = "0x400046F")]
		k_EControllerActionOrigin_SteamV2_A,
		[Token(Token = "0x4000470")]
		k_EControllerActionOrigin_SteamV2_B,
		[Token(Token = "0x4000471")]
		k_EControllerActionOrigin_SteamV2_X,
		[Token(Token = "0x4000472")]
		k_EControllerActionOrigin_SteamV2_Y,
		[Token(Token = "0x4000473")]
		k_EControllerActionOrigin_SteamV2_LeftBumper,
		[Token(Token = "0x4000474")]
		k_EControllerActionOrigin_SteamV2_RightBumper,
		[Token(Token = "0x4000475")]
		k_EControllerActionOrigin_SteamV2_LeftGrip,
		[Token(Token = "0x4000476")]
		k_EControllerActionOrigin_SteamV2_RightGrip,
		[Token(Token = "0x4000477")]
		k_EControllerActionOrigin_SteamV2_LeftGrip_Upper,
		[Token(Token = "0x4000478")]
		k_EControllerActionOrigin_SteamV2_RightGrip_Upper,
		[Token(Token = "0x4000479")]
		k_EControllerActionOrigin_SteamV2_LeftBumper_Pressure,
		[Token(Token = "0x400047A")]
		k_EControllerActionOrigin_SteamV2_RightBumper_Pressure,
		[Token(Token = "0x400047B")]
		k_EControllerActionOrigin_SteamV2_LeftGrip_Pressure,
		[Token(Token = "0x400047C")]
		k_EControllerActionOrigin_SteamV2_RightGrip_Pressure,
		[Token(Token = "0x400047D")]
		k_EControllerActionOrigin_SteamV2_LeftGrip_Upper_Pressure,
		[Token(Token = "0x400047E")]
		k_EControllerActionOrigin_SteamV2_RightGrip_Upper_Pressure,
		[Token(Token = "0x400047F")]
		k_EControllerActionOrigin_SteamV2_Start,
		[Token(Token = "0x4000480")]
		k_EControllerActionOrigin_SteamV2_Back,
		[Token(Token = "0x4000481")]
		k_EControllerActionOrigin_SteamV2_LeftPad_Touch,
		[Token(Token = "0x4000482")]
		k_EControllerActionOrigin_SteamV2_LeftPad_Swipe,
		[Token(Token = "0x4000483")]
		k_EControllerActionOrigin_SteamV2_LeftPad_Click,
		[Token(Token = "0x4000484")]
		k_EControllerActionOrigin_SteamV2_LeftPad_Pressure,
		[Token(Token = "0x4000485")]
		k_EControllerActionOrigin_SteamV2_LeftPad_DPadNorth,
		[Token(Token = "0x4000486")]
		k_EControllerActionOrigin_SteamV2_LeftPad_DPadSouth,
		[Token(Token = "0x4000487")]
		k_EControllerActionOrigin_SteamV2_LeftPad_DPadWest,
		[Token(Token = "0x4000488")]
		k_EControllerActionOrigin_SteamV2_LeftPad_DPadEast,
		[Token(Token = "0x4000489")]
		k_EControllerActionOrigin_SteamV2_RightPad_Touch,
		[Token(Token = "0x400048A")]
		k_EControllerActionOrigin_SteamV2_RightPad_Swipe,
		[Token(Token = "0x400048B")]
		k_EControllerActionOrigin_SteamV2_RightPad_Click,
		[Token(Token = "0x400048C")]
		k_EControllerActionOrigin_SteamV2_RightPad_Pressure,
		[Token(Token = "0x400048D")]
		k_EControllerActionOrigin_SteamV2_RightPad_DPadNorth,
		[Token(Token = "0x400048E")]
		k_EControllerActionOrigin_SteamV2_RightPad_DPadSouth,
		[Token(Token = "0x400048F")]
		k_EControllerActionOrigin_SteamV2_RightPad_DPadWest,
		[Token(Token = "0x4000490")]
		k_EControllerActionOrigin_SteamV2_RightPad_DPadEast,
		[Token(Token = "0x4000491")]
		k_EControllerActionOrigin_SteamV2_LeftTrigger_Pull,
		[Token(Token = "0x4000492")]
		k_EControllerActionOrigin_SteamV2_LeftTrigger_Click,
		[Token(Token = "0x4000493")]
		k_EControllerActionOrigin_SteamV2_RightTrigger_Pull,
		[Token(Token = "0x4000494")]
		k_EControllerActionOrigin_SteamV2_RightTrigger_Click,
		[Token(Token = "0x4000495")]
		k_EControllerActionOrigin_SteamV2_LeftStick_Move,
		[Token(Token = "0x4000496")]
		k_EControllerActionOrigin_SteamV2_LeftStick_Click,
		[Token(Token = "0x4000497")]
		k_EControllerActionOrigin_SteamV2_LeftStick_DPadNorth,
		[Token(Token = "0x4000498")]
		k_EControllerActionOrigin_SteamV2_LeftStick_DPadSouth,
		[Token(Token = "0x4000499")]
		k_EControllerActionOrigin_SteamV2_LeftStick_DPadWest,
		[Token(Token = "0x400049A")]
		k_EControllerActionOrigin_SteamV2_LeftStick_DPadEast,
		[Token(Token = "0x400049B")]
		k_EControllerActionOrigin_SteamV2_Gyro_Move,
		[Token(Token = "0x400049C")]
		k_EControllerActionOrigin_SteamV2_Gyro_Pitch,
		[Token(Token = "0x400049D")]
		k_EControllerActionOrigin_SteamV2_Gyro_Yaw,
		[Token(Token = "0x400049E")]
		k_EControllerActionOrigin_SteamV2_Gyro_Roll,
		[Token(Token = "0x400049F")]
		k_EControllerActionOrigin_Count
	}
	[Token(Token = "0x200015E")]
	public enum ESteamControllerLEDFlag
	{
		[Token(Token = "0x40004A1")]
		k_ESteamControllerLEDFlag_SetColor,
		[Token(Token = "0x40004A2")]
		k_ESteamControllerLEDFlag_RestoreUserDefault
	}
	[Token(Token = "0x200015F")]
	public enum EFriendRelationship
	{
		[Token(Token = "0x40004A4")]
		k_EFriendRelationshipNone,
		[Token(Token = "0x40004A5")]
		k_EFriendRelationshipBlocked,
		[Token(Token = "0x40004A6")]
		k_EFriendRelationshipRequestRecipient,
		[Token(Token = "0x40004A7")]
		k_EFriendRelationshipFriend,
		[Token(Token = "0x40004A8")]
		k_EFriendRelationshipRequestInitiator,
		[Token(Token = "0x40004A9")]
		k_EFriendRelationshipIgnored,
		[Token(Token = "0x40004AA")]
		k_EFriendRelationshipIgnoredFriend,
		[Token(Token = "0x40004AB")]
		k_EFriendRelationshipSuggested_DEPRECATED,
		[Token(Token = "0x40004AC")]
		k_EFriendRelationshipMax
	}
	[Token(Token = "0x2000160")]
	public enum EPersonaState
	{
		[Token(Token = "0x40004AE")]
		k_EPersonaStateOffline,
		[Token(Token = "0x40004AF")]
		k_EPersonaStateOnline,
		[Token(Token = "0x40004B0")]
		k_EPersonaStateBusy,
		[Token(Token = "0x40004B1")]
		k_EPersonaStateAway,
		[Token(Token = "0x40004B2")]
		k_EPersonaStateSnooze,
		[Token(Token = "0x40004B3")]
		k_EPersonaStateLookingToTrade,
		[Token(Token = "0x40004B4")]
		k_EPersonaStateLookingToPlay,
		[Token(Token = "0x40004B5")]
		k_EPersonaStateMax
	}
	[Token(Token = "0x2000161")]
	[Flags]
	public enum EFriendFlags
	{
		[Token(Token = "0x40004B7")]
		k_EFriendFlagNone = 0,
		[Token(Token = "0x40004B8")]
		k_EFriendFlagBlocked = 1,
		[Token(Token = "0x40004B9")]
		k_EFriendFlagFriendshipRequested = 2,
		[Token(Token = "0x40004BA")]
		k_EFriendFlagImmediate = 4,
		[Token(Token = "0x40004BB")]
		k_EFriendFlagClanMember = 8,
		[Token(Token = "0x40004BC")]
		k_EFriendFlagOnGameServer = 0x10,
		[Token(Token = "0x40004BD")]
		k_EFriendFlagRequestingFriendship = 0x80,
		[Token(Token = "0x40004BE")]
		k_EFriendFlagRequestingInfo = 0x100,
		[Token(Token = "0x40004BF")]
		k_EFriendFlagIgnored = 0x200,
		[Token(Token = "0x40004C0")]
		k_EFriendFlagIgnoredFriend = 0x400,
		[Token(Token = "0x40004C1")]
		k_EFriendFlagChatMember = 0x1000,
		[Token(Token = "0x40004C2")]
		k_EFriendFlagAll = 0xFFFF
	}
	[Token(Token = "0x2000162")]
	public enum EUserRestriction
	{
		[Token(Token = "0x40004C4")]
		k_nUserRestrictionNone = 0,
		[Token(Token = "0x40004C5")]
		k_nUserRestrictionUnknown = 1,
		[Token(Token = "0x40004C6")]
		k_nUserRestrictionAnyChat = 2,
		[Token(Token = "0x40004C7")]
		k_nUserRestrictionVoiceChat = 4,
		[Token(Token = "0x40004C8")]
		k_nUserRestrictionGroupChat = 8,
		[Token(Token = "0x40004C9")]
		k_nUserRestrictionRating = 0x10,
		[Token(Token = "0x40004CA")]
		k_nUserRestrictionGameInvites = 0x20,
		[Token(Token = "0x40004CB")]
		k_nUserRestrictionTrading = 0x40
	}
	[Token(Token = "0x2000163")]
	public enum EOverlayToStoreFlag
	{
		[Token(Token = "0x40004CD")]
		k_EOverlayToStoreFlag_None,
		[Token(Token = "0x40004CE")]
		k_EOverlayToStoreFlag_AddToCart,
		[Token(Token = "0x40004CF")]
		k_EOverlayToStoreFlag_AddToCartAndShow
	}
	[Token(Token = "0x2000164")]
	[Flags]
	public enum EPersonaChange
	{
		[Token(Token = "0x40004D1")]
		k_EPersonaChangeName = 1,
		[Token(Token = "0x40004D2")]
		k_EPersonaChangeStatus = 2,
		[Token(Token = "0x40004D3")]
		k_EPersonaChangeComeOnline = 4,
		[Token(Token = "0x40004D4")]
		k_EPersonaChangeGoneOffline = 8,
		[Token(Token = "0x40004D5")]
		k_EPersonaChangeGamePlayed = 0x10,
		[Token(Token = "0x40004D6")]
		k_EPersonaChangeGameServer = 0x20,
		[Token(Token = "0x40004D7")]
		k_EPersonaChangeAvatar = 0x40,
		[Token(Token = "0x40004D8")]
		k_EPersonaChangeJoinedSource = 0x80,
		[Token(Token = "0x40004D9")]
		k_EPersonaChangeLeftSource = 0x100,
		[Token(Token = "0x40004DA")]
		k_EPersonaChangeRelationshipChanged = 0x200,
		[Token(Token = "0x40004DB")]
		k_EPersonaChangeNameFirstSet = 0x400,
		[Token(Token = "0x40004DC")]
		k_EPersonaChangeFacebookInfo = 0x800,
		[Token(Token = "0x40004DD")]
		k_EPersonaChangeNickname = 0x1000,
		[Token(Token = "0x40004DE")]
		k_EPersonaChangeSteamLevel = 0x2000
	}
	[Token(Token = "0x2000165")]
	public enum EGCResults
	{
		[Token(Token = "0x40004E0")]
		k_EGCResultOK,
		[Token(Token = "0x40004E1")]
		k_EGCResultNoMessage,
		[Token(Token = "0x40004E2")]
		k_EGCResultBufferTooSmall,
		[Token(Token = "0x40004E3")]
		k_EGCResultNotLoggedOn,
		[Token(Token = "0x40004E4")]
		k_EGCResultInvalidMessage
	}
	[Token(Token = "0x2000166")]
	public enum EHTMLMouseButton
	{
		[Token(Token = "0x40004E6")]
		eHTMLMouseButton_Left,
		[Token(Token = "0x40004E7")]
		eHTMLMouseButton_Right,
		[Token(Token = "0x40004E8")]
		eHTMLMouseButton_Middle
	}
	[Token(Token = "0x2000167")]
	public enum EMouseCursor
	{
		[Token(Token = "0x40004EA")]
		dc_user,
		[Token(Token = "0x40004EB")]
		dc_none,
		[Token(Token = "0x40004EC")]
		dc_arrow,
		[Token(Token = "0x40004ED")]
		dc_ibeam,
		[Token(Token = "0x40004EE")]
		dc_hourglass,
		[Token(Token = "0x40004EF")]
		dc_waitarrow,
		[Token(Token = "0x40004F0")]
		dc_crosshair,
		[Token(Token = "0x40004F1")]
		dc_up,
		[Token(Token = "0x40004F2")]
		dc_sizenw,
		[Token(Token = "0x40004F3")]
		dc_sizese,
		[Token(Token = "0x40004F4")]
		dc_sizene,
		[Token(Token = "0x40004F5")]
		dc_sizesw,
		[Token(Token = "0x40004F6")]
		dc_sizew,
		[Token(Token = "0x40004F7")]
		dc_sizee,
		[Token(Token = "0x40004F8")]
		dc_sizen,
		[Token(Token = "0x40004F9")]
		dc_sizes,
		[Token(Token = "0x40004FA")]
		dc_sizewe,
		[Token(Token = "0x40004FB")]
		dc_sizens,
		[Token(Token = "0x40004FC")]
		dc_sizeall,
		[Token(Token = "0x40004FD")]
		dc_no,
		[Token(Token = "0x40004FE")]
		dc_hand,
		[Token(Token = "0x40004FF")]
		dc_blank,
		[Token(Token = "0x4000500")]
		dc_middle_pan,
		[Token(Token = "0x4000501")]
		dc_north_pan,
		[Token(Token = "0x4000502")]
		dc_north_east_pan,
		[Token(Token = "0x4000503")]
		dc_east_pan,
		[Token(Token = "0x4000504")]
		dc_south_east_pan,
		[Token(Token = "0x4000505")]
		dc_south_pan,
		[Token(Token = "0x4000506")]
		dc_south_west_pan,
		[Token(Token = "0x4000507")]
		dc_west_pan,
		[Token(Token = "0x4000508")]
		dc_north_west_pan,
		[Token(Token = "0x4000509")]
		dc_alias,
		[Token(Token = "0x400050A")]
		dc_cell,
		[Token(Token = "0x400050B")]
		dc_colresize,
		[Token(Token = "0x400050C")]
		dc_copycur,
		[Token(Token = "0x400050D")]
		dc_verticaltext,
		[Token(Token = "0x400050E")]
		dc_rowresize,
		[Token(Token = "0x400050F")]
		dc_zoomin,
		[Token(Token = "0x4000510")]
		dc_zoomout,
		[Token(Token = "0x4000511")]
		dc_help,
		[Token(Token = "0x4000512")]
		dc_custom,
		[Token(Token = "0x4000513")]
		dc_last
	}
	[Token(Token = "0x2000168")]
	[Flags]
	public enum EHTMLKeyModifiers
	{
		[Token(Token = "0x4000515")]
		k_eHTMLKeyModifier_None = 0,
		[Token(Token = "0x4000516")]
		k_eHTMLKeyModifier_AltDown = 1,
		[Token(Token = "0x4000517")]
		k_eHTMLKeyModifier_CtrlDown = 2,
		[Token(Token = "0x4000518")]
		k_eHTMLKeyModifier_ShiftDown = 4
	}
	[Token(Token = "0x2000169")]
	[Flags]
	public enum ESteamItemFlags
	{
		[Token(Token = "0x400051A")]
		k_ESteamItemNoTrade = 1,
		[Token(Token = "0x400051B")]
		k_ESteamItemRemoved = 0x100,
		[Token(Token = "0x400051C")]
		k_ESteamItemConsumed = 0x200
	}
	[Token(Token = "0x200016A")]
	public enum ELobbyType
	{
		[Token(Token = "0x400051E")]
		k_ELobbyTypePrivate,
		[Token(Token = "0x400051F")]
		k_ELobbyTypeFriendsOnly,
		[Token(Token = "0x4000520")]
		k_ELobbyTypePublic,
		[Token(Token = "0x4000521")]
		k_ELobbyTypeInvisible
	}
	[Token(Token = "0x200016B")]
	public enum ELobbyComparison
	{
		[Token(Token = "0x4000523")]
		k_ELobbyComparisonEqualToOrLessThan = -2,
		[Token(Token = "0x4000524")]
		k_ELobbyComparisonLessThan,
		[Token(Token = "0x4000525")]
		k_ELobbyComparisonEqual,
		[Token(Token = "0x4000526")]
		k_ELobbyComparisonGreaterThan,
		[Token(Token = "0x4000527")]
		k_ELobbyComparisonEqualToOrGreaterThan,
		[Token(Token = "0x4000528")]
		k_ELobbyComparisonNotEqual
	}
	[Token(Token = "0x200016C")]
	public enum ELobbyDistanceFilter
	{
		[Token(Token = "0x400052A")]
		k_ELobbyDistanceFilterClose,
		[Token(Token = "0x400052B")]
		k_ELobbyDistanceFilterDefault,
		[Token(Token = "0x400052C")]
		k_ELobbyDistanceFilterFar,
		[Token(Token = "0x400052D")]
		k_ELobbyDistanceFilterWorldwide
	}
	[Token(Token = "0x200016D")]
	[Flags]
	public enum EChatMemberStateChange
	{
		[Token(Token = "0x400052F")]
		k_EChatMemberStateChangeEntered = 1,
		[Token(Token = "0x4000530")]
		k_EChatMemberStateChangeLeft = 2,
		[Token(Token = "0x4000531")]
		k_EChatMemberStateChangeDisconnected = 4,
		[Token(Token = "0x4000532")]
		k_EChatMemberStateChangeKicked = 8,
		[Token(Token = "0x4000533")]
		k_EChatMemberStateChangeBanned = 0x10
	}
	[Token(Token = "0x200016E")]
	public enum AudioPlayback_Status
	{
		[Token(Token = "0x4000535")]
		AudioPlayback_Undefined,
		[Token(Token = "0x4000536")]
		AudioPlayback_Playing,
		[Token(Token = "0x4000537")]
		AudioPlayback_Paused,
		[Token(Token = "0x4000538")]
		AudioPlayback_Idle
	}
	[Token(Token = "0x200016F")]
	public enum EP2PSessionError
	{
		[Token(Token = "0x400053A")]
		k_EP2PSessionErrorNone,
		[Token(Token = "0x400053B")]
		k_EP2PSessionErrorNotRunningApp,
		[Token(Token = "0x400053C")]
		k_EP2PSessionErrorNoRightsToApp,
		[Token(Token = "0x400053D")]
		k_EP2PSessionErrorDestinationNotLoggedIn,
		[Token(Token = "0x400053E")]
		k_EP2PSessionErrorTimeout,
		[Token(Token = "0x400053F")]
		k_EP2PSessionErrorMax
	}
	[Token(Token = "0x2000170")]
	public enum EP2PSend
	{
		[Token(Token = "0x4000541")]
		k_EP2PSendUnreliable,
		[Token(Token = "0x4000542")]
		k_EP2PSendUnreliableNoDelay,
		[Token(Token = "0x4000543")]
		k_EP2PSendReliable,
		[Token(Token = "0x4000544")]
		k_EP2PSendReliableWithBuffering
	}
	[Token(Token = "0x2000171")]
	public enum ESNetSocketState
	{
		[Token(Token = "0x4000546")]
		k_ESNetSocketStateInvalid = 0,
		[Token(Token = "0x4000547")]
		k_ESNetSocketStateConnected = 1,
		[Token(Token = "0x4000548")]
		k_ESNetSocketStateInitiated = 10,
		[Token(Token = "0x4000549")]
		k_ESNetSocketStateLocalCandidatesFound = 11,
		[Token(Token = "0x400054A")]
		k_ESNetSocketStateReceivedRemoteCandidates = 12,
		[Token(Token = "0x400054B")]
		k_ESNetSocketStateChallengeHandshake = 15,
		[Token(Token = "0x400054C")]
		k_ESNetSocketStateDisconnecting = 21,
		[Token(Token = "0x400054D")]
		k_ESNetSocketStateLocalDisconnect = 22,
		[Token(Token = "0x400054E")]
		k_ESNetSocketStateTimeoutDuringConnect = 23,
		[Token(Token = "0x400054F")]
		k_ESNetSocketStateRemoteEndDisconnected = 24,
		[Token(Token = "0x4000550")]
		k_ESNetSocketStateConnectionBroken = 25
	}
	[Token(Token = "0x2000172")]
	public enum ESNetSocketConnectionType
	{
		[Token(Token = "0x4000552")]
		k_ESNetSocketConnectionTypeNotConnected,
		[Token(Token = "0x4000553")]
		k_ESNetSocketConnectionTypeUDP,
		[Token(Token = "0x4000554")]
		k_ESNetSocketConnectionTypeUDPRelay
	}
	[Token(Token = "0x2000173")]
	public enum EParentalFeature
	{
		[Token(Token = "0x4000556")]
		k_EFeatureInvalid,
		[Token(Token = "0x4000557")]
		k_EFeatureStore,
		[Token(Token = "0x4000558")]
		k_EFeatureCommunity,
		[Token(Token = "0x4000559")]
		k_EFeatureProfile,
		[Token(Token = "0x400055A")]
		k_EFeatureFriends,
		[Token(Token = "0x400055B")]
		k_EFeatureNews,
		[Token(Token = "0x400055C")]
		k_EFeatureTrading,
		[Token(Token = "0x400055D")]
		k_EFeatureSettings,
		[Token(Token = "0x400055E")]
		k_EFeatureConsole,
		[Token(Token = "0x400055F")]
		k_EFeatureBrowser,
		[Token(Token = "0x4000560")]
		k_EFeatureParentalSetup,
		[Token(Token = "0x4000561")]
		k_EFeatureLibrary,
		[Token(Token = "0x4000562")]
		k_EFeatureTest,
		[Token(Token = "0x4000563")]
		k_EFeatureMax
	}
	[Token(Token = "0x2000174")]
	[Flags]
	public enum ERemoteStoragePlatform
	{
		[Token(Token = "0x4000565")]
		k_ERemoteStoragePlatformNone = 0,
		[Token(Token = "0x4000566")]
		k_ERemoteStoragePlatformWindows = 1,
		[Token(Token = "0x4000567")]
		k_ERemoteStoragePlatformOSX = 2,
		[Token(Token = "0x4000568")]
		k_ERemoteStoragePlatformPS3 = 4,
		[Token(Token = "0x4000569")]
		k_ERemoteStoragePlatformLinux = 8,
		[Token(Token = "0x400056A")]
		k_ERemoteStoragePlatformReserved2 = 0x10,
		[Token(Token = "0x400056B")]
		k_ERemoteStoragePlatformAll = -1
	}
	[Token(Token = "0x2000175")]
	public enum ERemoteStoragePublishedFileVisibility
	{
		[Token(Token = "0x400056D")]
		k_ERemoteStoragePublishedFileVisibilityPublic,
		[Token(Token = "0x400056E")]
		k_ERemoteStoragePublishedFileVisibilityFriendsOnly,
		[Token(Token = "0x400056F")]
		k_ERemoteStoragePublishedFileVisibilityPrivate
	}
	[Token(Token = "0x2000176")]
	public enum EWorkshopFileType
	{
		[Token(Token = "0x4000571")]
		k_EWorkshopFileTypeFirst = 0,
		[Token(Token = "0x4000572")]
		k_EWorkshopFileTypeCommunity = 0,
		[Token(Token = "0x4000573")]
		k_EWorkshopFileTypeMicrotransaction = 1,
		[Token(Token = "0x4000574")]
		k_EWorkshopFileTypeCollection = 2,
		[Token(Token = "0x4000575")]
		k_EWorkshopFileTypeArt = 3,
		[Token(Token = "0x4000576")]
		k_EWorkshopFileTypeVideo = 4,
		[Token(Token = "0x4000577")]
		k_EWorkshopFileTypeScreenshot = 5,
		[Token(Token = "0x4000578")]
		k_EWorkshopFileTypeGame = 6,
		[Token(Token = "0x4000579")]
		k_EWorkshopFileTypeSoftware = 7,
		[Token(Token = "0x400057A")]
		k_EWorkshopFileTypeConcept = 8,
		[Token(Token = "0x400057B")]
		k_EWorkshopFileTypeWebGuide = 9,
		[Token(Token = "0x400057C")]
		k_EWorkshopFileTypeIntegratedGuide = 10,
		[Token(Token = "0x400057D")]
		k_EWorkshopFileTypeMerch = 11,
		[Token(Token = "0x400057E")]
		k_EWorkshopFileTypeControllerBinding = 12,
		[Token(Token = "0x400057F")]
		k_EWorkshopFileTypeSteamworksAccessInvite = 13,
		[Token(Token = "0x4000580")]
		k_EWorkshopFileTypeSteamVideo = 14,
		[Token(Token = "0x4000581")]
		k_EWorkshopFileTypeGameManagedItem = 15,
		[Token(Token = "0x4000582")]
		k_EWorkshopFileTypeMax = 16
	}
	[Token(Token = "0x2000177")]
	public enum EWorkshopVote
	{
		[Token(Token = "0x4000584")]
		k_EWorkshopVoteUnvoted,
		[Token(Token = "0x4000585")]
		k_EWorkshopVoteFor,
		[Token(Token = "0x4000586")]
		k_EWorkshopVoteAgainst,
		[Token(Token = "0x4000587")]
		k_EWorkshopVoteLater
	}
	[Token(Token = "0x2000178")]
	public enum EWorkshopFileAction
	{
		[Token(Token = "0x4000589")]
		k_EWorkshopFileActionPlayed,
		[Token(Token = "0x400058A")]
		k_EWorkshopFileActionCompleted
	}
	[Token(Token = "0x2000179")]
	public enum EWorkshopEnumerationType
	{
		[Token(Token = "0x400058C")]
		k_EWorkshopEnumerationTypeRankedByVote,
		[Token(Token = "0x400058D")]
		k_EWorkshopEnumerationTypeRecent,
		[Token(Token = "0x400058E")]
		k_EWorkshopEnumerationTypeTrending,
		[Token(Token = "0x400058F")]
		k_EWorkshopEnumerationTypeFavoritesOfFriends,
		[Token(Token = "0x4000590")]
		k_EWorkshopEnumerationTypeVotedByFriends,
		[Token(Token = "0x4000591")]
		k_EWorkshopEnumerationTypeContentByFriends,
		[Token(Token = "0x4000592")]
		k_EWorkshopEnumerationTypeRecentFromFollowedUsers
	}
	[Token(Token = "0x200017A")]
	public enum EWorkshopVideoProvider
	{
		[Token(Token = "0x4000594")]
		k_EWorkshopVideoProviderNone,
		[Token(Token = "0x4000595")]
		k_EWorkshopVideoProviderYoutube
	}
	[Token(Token = "0x200017B")]
	public enum EUGCReadAction
	{
		[Token(Token = "0x4000597")]
		k_EUGCRead_ContinueReadingUntilFinished,
		[Token(Token = "0x4000598")]
		k_EUGCRead_ContinueReading,
		[Token(Token = "0x4000599")]
		k_EUGCRead_Close
	}
	[Token(Token = "0x200017C")]
	public enum EVRScreenshotType
	{
		[Token(Token = "0x400059B")]
		k_EVRScreenshotType_None,
		[Token(Token = "0x400059C")]
		k_EVRScreenshotType_Mono,
		[Token(Token = "0x400059D")]
		k_EVRScreenshotType_Stereo,
		[Token(Token = "0x400059E")]
		k_EVRScreenshotType_MonoCubemap,
		[Token(Token = "0x400059F")]
		k_EVRScreenshotType_MonoPanorama,
		[Token(Token = "0x40005A0")]
		k_EVRScreenshotType_StereoPanorama
	}
	[Token(Token = "0x200017D")]
	public enum EUGCMatchingUGCType
	{
		[Token(Token = "0x40005A2")]
		k_EUGCMatchingUGCType_Items = 0,
		[Token(Token = "0x40005A3")]
		k_EUGCMatchingUGCType_Items_Mtx = 1,
		[Token(Token = "0x40005A4")]
		k_EUGCMatchingUGCType_Items_ReadyToUse = 2,
		[Token(Token = "0x40005A5")]
		k_EUGCMatchingUGCType_Collections = 3,
		[Token(Token = "0x40005A6")]
		k_EUGCMatchingUGCType_Artwork = 4,
		[Token(Token = "0x40005A7")]
		k_EUGCMatchingUGCType_Videos = 5,
		[Token(Token = "0x40005A8")]
		k_EUGCMatchingUGCType_Screenshots = 6,
		[Token(Token = "0x40005A9")]
		k_EUGCMatchingUGCType_AllGuides = 7,
		[Token(Token = "0x40005AA")]
		k_EUGCMatchingUGCType_WebGuides = 8,
		[Token(Token = "0x40005AB")]
		k_EUGCMatchingUGCType_IntegratedGuides = 9,
		[Token(Token = "0x40005AC")]
		k_EUGCMatchingUGCType_UsableInGame = 10,
		[Token(Token = "0x40005AD")]
		k_EUGCMatchingUGCType_ControllerBindings = 11,
		[Token(Token = "0x40005AE")]
		k_EUGCMatchingUGCType_GameManagedItems = 12,
		[Token(Token = "0x40005AF")]
		k_EUGCMatchingUGCType_All = -1
	}
	[Token(Token = "0x200017E")]
	public enum EUserUGCList
	{
		[Token(Token = "0x40005B1")]
		k_EUserUGCList_Published,
		[Token(Token = "0x40005B2")]
		k_EUserUGCList_VotedOn,
		[Token(Token = "0x40005B3")]
		k_EUserUGCList_VotedUp,
		[Token(Token = "0x40005B4")]
		k_EUserUGCList_VotedDown,
		[Token(Token = "0x40005B5")]
		k_EUserUGCList_WillVoteLater,
		[Token(Token = "0x40005B6")]
		k_EUserUGCList_Favorited,
		[Token(Token = "0x40005B7")]
		k_EUserUGCList_Subscribed,
		[Token(Token = "0x40005B8")]
		k_EUserUGCList_UsedOrPlayed,
		[Token(Token = "0x40005B9")]
		k_EUserUGCList_Followed
	}
	[Token(Token = "0x200017F")]
	public enum EUserUGCListSortOrder
	{
		[Token(Token = "0x40005BB")]
		k_EUserUGCListSortOrder_CreationOrderDesc,
		[Token(Token = "0x40005BC")]
		k_EUserUGCListSortOrder_CreationOrderAsc,
		[Token(Token = "0x40005BD")]
		k_EUserUGCListSortOrder_TitleAsc,
		[Token(Token = "0x40005BE")]
		k_EUserUGCListSortOrder_LastUpdatedDesc,
		[Token(Token = "0x40005BF")]
		k_EUserUGCListSortOrder_SubscriptionDateDesc,
		[Token(Token = "0x40005C0")]
		k_EUserUGCListSortOrder_VoteScoreDesc,
		[Token(Token = "0x40005C1")]
		k_EUserUGCListSortOrder_ForModeration
	}
	[Token(Token = "0x2000180")]
	public enum EUGCQuery
	{
		[Token(Token = "0x40005C3")]
		k_EUGCQuery_RankedByVote,
		[Token(Token = "0x40005C4")]
		k_EUGCQuery_RankedByPublicationDate,
		[Token(Token = "0x40005C5")]
		k_EUGCQuery_AcceptedForGameRankedByAcceptanceDate,
		[Token(Token = "0x40005C6")]
		k_EUGCQuery_RankedByTrend,
		[Token(Token = "0x40005C7")]
		k_EUGCQuery_FavoritedByFriendsRankedByPublicationDate,
		[Token(Token = "0x40005C8")]
		k_EUGCQuery_CreatedByFriendsRankedByPublicationDate,
		[Token(Token = "0x40005C9")]
		k_EUGCQuery_RankedByNumTimesReported,
		[Token(Token = "0x40005CA")]
		k_EUGCQuery_CreatedByFollowedUsersRankedByPublicationDate,
		[Token(Token = "0x40005CB")]
		k_EUGCQuery_NotYetRated,
		[Token(Token = "0x40005CC")]
		k_EUGCQuery_RankedByTotalVotesAsc,
		[Token(Token = "0x40005CD")]
		k_EUGCQuery_RankedByVotesUp,
		[Token(Token = "0x40005CE")]
		k_EUGCQuery_RankedByTextSearch,
		[Token(Token = "0x40005CF")]
		k_EUGCQuery_RankedByTotalUniqueSubscriptions,
		[Token(Token = "0x40005D0")]
		k_EUGCQuery_RankedByPlaytimeTrend,
		[Token(Token = "0x40005D1")]
		k_EUGCQuery_RankedByTotalPlaytime,
		[Token(Token = "0x40005D2")]
		k_EUGCQuery_RankedByAveragePlaytimeTrend,
		[Token(Token = "0x40005D3")]
		k_EUGCQuery_RankedByLifetimeAveragePlaytime,
		[Token(Token = "0x40005D4")]
		k_EUGCQuery_RankedByPlaytimeSessionsTrend,
		[Token(Token = "0x40005D5")]
		k_EUGCQuery_RankedByLifetimePlaytimeSessions
	}
	[Token(Token = "0x2000181")]
	public enum EItemUpdateStatus
	{
		[Token(Token = "0x40005D7")]
		k_EItemUpdateStatusInvalid,
		[Token(Token = "0x40005D8")]
		k_EItemUpdateStatusPreparingConfig,
		[Token(Token = "0x40005D9")]
		k_EItemUpdateStatusPreparingContent,
		[Token(Token = "0x40005DA")]
		k_EItemUpdateStatusUploadingContent,
		[Token(Token = "0x40005DB")]
		k_EItemUpdateStatusUploadingPreviewFile,
		[Token(Token = "0x40005DC")]
		k_EItemUpdateStatusCommittingChanges
	}
	[Token(Token = "0x2000182")]
	[Flags]
	public enum EItemState
	{
		[Token(Token = "0x40005DE")]
		k_EItemStateNone = 0,
		[Token(Token = "0x40005DF")]
		k_EItemStateSubscribed = 1,
		[Token(Token = "0x40005E0")]
		k_EItemStateLegacyItem = 2,
		[Token(Token = "0x40005E1")]
		k_EItemStateInstalled = 4,
		[Token(Token = "0x40005E2")]
		k_EItemStateNeedsUpdate = 8,
		[Token(Token = "0x40005E3")]
		k_EItemStateDownloading = 0x10,
		[Token(Token = "0x40005E4")]
		k_EItemStateDownloadPending = 0x20
	}
	[Token(Token = "0x2000183")]
	public enum EItemStatistic
	{
		[Token(Token = "0x40005E6")]
		k_EItemStatistic_NumSubscriptions,
		[Token(Token = "0x40005E7")]
		k_EItemStatistic_NumFavorites,
		[Token(Token = "0x40005E8")]
		k_EItemStatistic_NumFollowers,
		[Token(Token = "0x40005E9")]
		k_EItemStatistic_NumUniqueSubscriptions,
		[Token(Token = "0x40005EA")]
		k_EItemStatistic_NumUniqueFavorites,
		[Token(Token = "0x40005EB")]
		k_EItemStatistic_NumUniqueFollowers,
		[Token(Token = "0x40005EC")]
		k_EItemStatistic_NumUniqueWebsiteViews,
		[Token(Token = "0x40005ED")]
		k_EItemStatistic_ReportScore,
		[Token(Token = "0x40005EE")]
		k_EItemStatistic_NumSecondsPlayed,
		[Token(Token = "0x40005EF")]
		k_EItemStatistic_NumPlaytimeSessions,
		[Token(Token = "0x40005F0")]
		k_EItemStatistic_NumComments,
		[Token(Token = "0x40005F1")]
		k_EItemStatistic_NumSecondsPlayedDuringTimePeriod,
		[Token(Token = "0x40005F2")]
		k_EItemStatistic_NumPlaytimeSessionsDuringTimePeriod
	}
	[Token(Token = "0x2000184")]
	public enum EItemPreviewType
	{
		[Token(Token = "0x40005F4")]
		k_EItemPreviewType_Image = 0,
		[Token(Token = "0x40005F5")]
		k_EItemPreviewType_YouTubeVideo = 1,
		[Token(Token = "0x40005F6")]
		k_EItemPreviewType_Sketchfab = 2,
		[Token(Token = "0x40005F7")]
		k_EItemPreviewType_EnvironmentMap_HorizontalCross = 3,
		[Token(Token = "0x40005F8")]
		k_EItemPreviewType_EnvironmentMap_LatLong = 4,
		[Token(Token = "0x40005F9")]
		k_EItemPreviewType_ReservedMax = 255
	}
	[Token(Token = "0x2000185")]
	public enum EFailureType
	{
		[Token(Token = "0x40005FB")]
		k_EFailureFlushedCallbackQueue,
		[Token(Token = "0x40005FC")]
		k_EFailurePipeFail
	}
	[Token(Token = "0x2000186")]
	public enum ELeaderboardDataRequest
	{
		[Token(Token = "0x40005FE")]
		k_ELeaderboardDataRequestGlobal,
		[Token(Token = "0x40005FF")]
		k_ELeaderboardDataRequestGlobalAroundUser,
		[Token(Token = "0x4000600")]
		k_ELeaderboardDataRequestFriends,
		[Token(Token = "0x4000601")]
		k_ELeaderboardDataRequestUsers
	}
	[Token(Token = "0x2000187")]
	public enum ELeaderboardSortMethod
	{
		[Token(Token = "0x4000603")]
		k_ELeaderboardSortMethodNone,
		[Token(Token = "0x4000604")]
		k_ELeaderboardSortMethodAscending,
		[Token(Token = "0x4000605")]
		k_ELeaderboardSortMethodDescending
	}
	[Token(Token = "0x2000188")]
	public enum ELeaderboardDisplayType
	{
		[Token(Token = "0x4000607")]
		k_ELeaderboardDisplayTypeNone,
		[Token(Token = "0x4000608")]
		k_ELeaderboardDisplayTypeNumeric,
		[Token(Token = "0x4000609")]
		k_ELeaderboardDisplayTypeTimeSeconds,
		[Token(Token = "0x400060A")]
		k_ELeaderboardDisplayTypeTimeMilliSeconds
	}
	[Token(Token = "0x2000189")]
	public enum ELeaderboardUploadScoreMethod
	{
		[Token(Token = "0x400060C")]
		k_ELeaderboardUploadScoreMethodNone,
		[Token(Token = "0x400060D")]
		k_ELeaderboardUploadScoreMethodKeepBest,
		[Token(Token = "0x400060E")]
		k_ELeaderboardUploadScoreMethodForceUpdate
	}
	[Token(Token = "0x200018A")]
	public enum ESteamAPICallFailure
	{
		[Token(Token = "0x4000610")]
		k_ESteamAPICallFailureNone = -1,
		[Token(Token = "0x4000611")]
		k_ESteamAPICallFailureSteamGone,
		[Token(Token = "0x4000612")]
		k_ESteamAPICallFailureNetworkFailure,
		[Token(Token = "0x4000613")]
		k_ESteamAPICallFailureInvalidHandle,
		[Token(Token = "0x4000614")]
		k_ESteamAPICallFailureMismatchedCallback
	}
	[Token(Token = "0x200018B")]
	public enum EGamepadTextInputMode
	{
		[Token(Token = "0x4000616")]
		k_EGamepadTextInputModeNormal,
		[Token(Token = "0x4000617")]
		k_EGamepadTextInputModePassword
	}
	[Token(Token = "0x200018C")]
	public enum EGamepadTextInputLineMode
	{
		[Token(Token = "0x4000619")]
		k_EGamepadTextInputLineModeSingleLine,
		[Token(Token = "0x400061A")]
		k_EGamepadTextInputLineModeMultipleLines
	}
	[Token(Token = "0x200018D")]
	public enum ECheckFileSignature
	{
		[Token(Token = "0x400061C")]
		k_ECheckFileSignatureInvalidSignature,
		[Token(Token = "0x400061D")]
		k_ECheckFileSignatureValidSignature,
		[Token(Token = "0x400061E")]
		k_ECheckFileSignatureFileNotFound,
		[Token(Token = "0x400061F")]
		k_ECheckFileSignatureNoSignaturesFoundForThisApp,
		[Token(Token = "0x4000620")]
		k_ECheckFileSignatureNoSignaturesFoundForThisFile
	}
	[Token(Token = "0x200018E")]
	public enum EMatchMakingServerResponse
	{
		[Token(Token = "0x4000622")]
		eServerResponded,
		[Token(Token = "0x4000623")]
		eServerFailedToRespond,
		[Token(Token = "0x4000624")]
		eNoServersListedOnMasterServer
	}
	[Token(Token = "0x200018F")]
	public enum EServerMode
	{
		[Token(Token = "0x4000626")]
		eServerModeInvalid,
		[Token(Token = "0x4000627")]
		eServerModeNoAuthentication,
		[Token(Token = "0x4000628")]
		eServerModeAuthentication,
		[Token(Token = "0x4000629")]
		eServerModeAuthenticationAndSecure
	}
	[Token(Token = "0x2000190")]
	public enum EResult
	{
		[Token(Token = "0x400062B")]
		k_EResultOK = 1,
		[Token(Token = "0x400062C")]
		k_EResultFail = 2,
		[Token(Token = "0x400062D")]
		k_EResultNoConnection = 3,
		[Token(Token = "0x400062E")]
		k_EResultInvalidPassword = 5,
		[Token(Token = "0x400062F")]
		k_EResultLoggedInElsewhere = 6,
		[Token(Token = "0x4000630")]
		k_EResultInvalidProtocolVer = 7,
		[Token(Token = "0x4000631")]
		k_EResultInvalidParam = 8,
		[Token(Token = "0x4000632")]
		k_EResultFileNotFound = 9,
		[Token(Token = "0x4000633")]
		k_EResultBusy = 10,
		[Token(Token = "0x4000634")]
		k_EResultInvalidState = 11,
		[Token(Token = "0x4000635")]
		k_EResultInvalidName = 12,
		[Token(Token = "0x4000636")]
		k_EResultInvalidEmail = 13,
		[Token(Token = "0x4000637")]
		k_EResultDuplicateName = 14,
		[Token(Token = "0x4000638")]
		k_EResultAccessDenied = 15,
		[Token(Token = "0x4000639")]
		k_EResultTimeout = 16,
		[Token(Token = "0x400063A")]
		k_EResultBanned = 17,
		[Token(Token = "0x400063B")]
		k_EResultAccountNotFound = 18,
		[Token(Token = "0x400063C")]
		k_EResultInvalidSteamID = 19,
		[Token(Token = "0x400063D")]
		k_EResultServiceUnavailable = 20,
		[Token(Token = "0x400063E")]
		k_EResultNotLoggedOn = 21,
		[Token(Token = "0x400063F")]
		k_EResultPending = 22,
		[Token(Token = "0x4000640")]
		k_EResultEncryptionFailure = 23,
		[Token(Token = "0x4000641")]
		k_EResultInsufficientPrivilege = 24,
		[Token(Token = "0x4000642")]
		k_EResultLimitExceeded = 25,
		[Token(Token = "0x4000643")]
		k_EResultRevoked = 26,
		[Token(Token = "0x4000644")]
		k_EResultExpired = 27,
		[Token(Token = "0x4000645")]
		k_EResultAlreadyRedeemed = 28,
		[Token(Token = "0x4000646")]
		k_EResultDuplicateRequest = 29,
		[Token(Token = "0x4000647")]
		k_EResultAlreadyOwned = 30,
		[Token(Token = "0x4000648")]
		k_EResultIPNotFound = 31,
		[Token(Token = "0x4000649")]
		k_EResultPersistFailed = 32,
		[Token(Token = "0x400064A")]
		k_EResultLockingFailed = 33,
		[Token(Token = "0x400064B")]
		k_EResultLogonSessionReplaced = 34,
		[Token(Token = "0x400064C")]
		k_EResultConnectFailed = 35,
		[Token(Token = "0x400064D")]
		k_EResultHandshakeFailed = 36,
		[Token(Token = "0x400064E")]
		k_EResultIOFailure = 37,
		[Token(Token = "0x400064F")]
		k_EResultRemoteDisconnect = 38,
		[Token(Token = "0x4000650")]
		k_EResultShoppingCartNotFound = 39,
		[Token(Token = "0x4000651")]
		k_EResultBlocked = 40,
		[Token(Token = "0x4000652")]
		k_EResultIgnored = 41,
		[Token(Token = "0x4000653")]
		k_EResultNoMatch = 42,
		[Token(Token = "0x4000654")]
		k_EResultAccountDisabled = 43,
		[Token(Token = "0x4000655")]
		k_EResultServiceReadOnly = 44,
		[Token(Token = "0x4000656")]
		k_EResultAccountNotFeatured = 45,
		[Token(Token = "0x4000657")]
		k_EResultAdministratorOK = 46,
		[Token(Token = "0x4000658")]
		k_EResultContentVersion = 47,
		[Token(Token = "0x4000659")]
		k_EResultTryAnotherCM = 48,
		[Token(Token = "0x400065A")]
		k_EResultPasswordRequiredToKickSession = 49,
		[Token(Token = "0x400065B")]
		k_EResultAlreadyLoggedInElsewhere = 50,
		[Token(Token = "0x400065C")]
		k_EResultSuspended = 51,
		[Token(Token = "0x400065D")]
		k_EResultCancelled = 52,
		[Token(Token = "0x400065E")]
		k_EResultDataCorruption = 53,
		[Token(Token = "0x400065F")]
		k_EResultDiskFull = 54,
		[Token(Token = "0x4000660")]
		k_EResultRemoteCallFailed = 55,
		[Token(Token = "0x4000661")]
		k_EResultPasswordUnset = 56,
		[Token(Token = "0x4000662")]
		k_EResultExternalAccountUnlinked = 57,
		[Token(Token = "0x4000663")]
		k_EResultPSNTicketInvalid = 58,
		[Token(Token = "0x4000664")]
		k_EResultExternalAccountAlreadyLinked = 59,
		[Token(Token = "0x4000665")]
		k_EResultRemoteFileConflict = 60,
		[Token(Token = "0x4000666")]
		k_EResultIllegalPassword = 61,
		[Token(Token = "0x4000667")]
		k_EResultSameAsPreviousValue = 62,
		[Token(Token = "0x4000668")]
		k_EResultAccountLogonDenied = 63,
		[Token(Token = "0x4000669")]
		k_EResultCannotUseOldPassword = 64,
		[Token(Token = "0x400066A")]
		k_EResultInvalidLoginAuthCode = 65,
		[Token(Token = "0x400066B")]
		k_EResultAccountLogonDeniedNoMail = 66,
		[Token(Token = "0x400066C")]
		k_EResultHardwareNotCapableOfIPT = 67,
		[Token(Token = "0x400066D")]
		k_EResultIPTInitError = 68,
		[Token(Token = "0x400066E")]
		k_EResultParentalControlRestricted = 69,
		[Token(Token = "0x400066F")]
		k_EResultFacebookQueryError = 70,
		[Token(Token = "0x4000670")]
		k_EResultExpiredLoginAuthCode = 71,
		[Token(Token = "0x4000671")]
		k_EResultIPLoginRestrictionFailed = 72,
		[Token(Token = "0x4000672")]
		k_EResultAccountLockedDown = 73,
		[Token(Token = "0x4000673")]
		k_EResultAccountLogonDeniedVerifiedEmailRequired = 74,
		[Token(Token = "0x4000674")]
		k_EResultNoMatchingURL = 75,
		[Token(Token = "0x4000675")]
		k_EResultBadResponse = 76,
		[Token(Token = "0x4000676")]
		k_EResultRequirePasswordReEntry = 77,
		[Token(Token = "0x4000677")]
		k_EResultValueOutOfRange = 78,
		[Token(Token = "0x4000678")]
		k_EResultUnexpectedError = 79,
		[Token(Token = "0x4000679")]
		k_EResultDisabled = 80,
		[Token(Token = "0x400067A")]
		k_EResultInvalidCEGSubmission = 81,
		[Token(Token = "0x400067B")]
		k_EResultRestrictedDevice = 82,
		[Token(Token = "0x400067C")]
		k_EResultRegionLocked = 83,
		[Token(Token = "0x400067D")]
		k_EResultRateLimitExceeded = 84,
		[Token(Token = "0x400067E")]
		k_EResultAccountLoginDeniedNeedTwoFactor = 85,
		[Token(Token = "0x400067F")]
		k_EResultItemDeleted = 86,
		[Token(Token = "0x4000680")]
		k_EResultAccountLoginDeniedThrottle = 87,
		[Token(Token = "0x4000681")]
		k_EResultTwoFactorCodeMismatch = 88,
		[Token(Token = "0x4000682")]
		k_EResultTwoFactorActivationCodeMismatch = 89,
		[Token(Token = "0x4000683")]
		k_EResultAccountAssociatedToMultiplePartners = 90,
		[Token(Token = "0x4000684")]
		k_EResultNotModified = 91,
		[Token(Token = "0x4000685")]
		k_EResultNoMobileDevice = 92,
		[Token(Token = "0x4000686")]
		k_EResultTimeNotSynced = 93,
		[Token(Token = "0x4000687")]
		k_EResultSmsCodeFailed = 94,
		[Token(Token = "0x4000688")]
		k_EResultAccountLimitExceeded = 95,
		[Token(Token = "0x4000689")]
		k_EResultAccountActivityLimitExceeded = 96,
		[Token(Token = "0x400068A")]
		k_EResultPhoneActivityLimitExceeded = 97,
		[Token(Token = "0x400068B")]
		k_EResultRefundToWallet = 98,
		[Token(Token = "0x400068C")]
		k_EResultEmailSendFailure = 99,
		[Token(Token = "0x400068D")]
		k_EResultNotSettled = 100,
		[Token(Token = "0x400068E")]
		k_EResultNeedCaptcha = 101,
		[Token(Token = "0x400068F")]
		k_EResultGSLTDenied = 102,
		[Token(Token = "0x4000690")]
		k_EResultGSOwnerDenied = 103,
		[Token(Token = "0x4000691")]
		k_EResultInvalidItemType = 104,
		[Token(Token = "0x4000692")]
		k_EResultIPBanned = 105,
		[Token(Token = "0x4000693")]
		k_EResultGSLTExpired = 106,
		[Token(Token = "0x4000694")]
		k_EResultInsufficientFunds = 107,
		[Token(Token = "0x4000695")]
		k_EResultTooManyPending = 108,
		[Token(Token = "0x4000696")]
		k_EResultNoSiteLicensesFound = 109,
		[Token(Token = "0x4000697")]
		k_EResultWGNetworkSendExceeded = 110
	}
	[Token(Token = "0x2000191")]
	public enum EVoiceResult
	{
		[Token(Token = "0x4000699")]
		k_EVoiceResultOK,
		[Token(Token = "0x400069A")]
		k_EVoiceResultNotInitialized,
		[Token(Token = "0x400069B")]
		k_EVoiceResultNotRecording,
		[Token(Token = "0x400069C")]
		k_EVoiceResultNoData,
		[Token(Token = "0x400069D")]
		k_EVoiceResultBufferTooSmall,
		[Token(Token = "0x400069E")]
		k_EVoiceResultDataCorrupted,
		[Token(Token = "0x400069F")]
		k_EVoiceResultRestricted,
		[Token(Token = "0x40006A0")]
		k_EVoiceResultUnsupportedCodec,
		[Token(Token = "0x40006A1")]
		k_EVoiceResultReceiverOutOfDate,
		[Token(Token = "0x40006A2")]
		k_EVoiceResultReceiverDidNotAnswer
	}
	[Token(Token = "0x2000192")]
	public enum EDenyReason
	{
		[Token(Token = "0x40006A4")]
		k_EDenyInvalid,
		[Token(Token = "0x40006A5")]
		k_EDenyInvalidVersion,
		[Token(Token = "0x40006A6")]
		k_EDenyGeneric,
		[Token(Token = "0x40006A7")]
		k_EDenyNotLoggedOn,
		[Token(Token = "0x40006A8")]
		k_EDenyNoLicense,
		[Token(Token = "0x40006A9")]
		k_EDenyCheater,
		[Token(Token = "0x40006AA")]
		k_EDenyLoggedInElseWhere,
		[Token(Token = "0x40006AB")]
		k_EDenyUnknownText,
		[Token(Token = "0x40006AC")]
		k_EDenyIncompatibleAnticheat,
		[Token(Token = "0x40006AD")]
		k_EDenyMemoryCorruption,
		[Token(Token = "0x40006AE")]
		k_EDenyIncompatibleSoftware,
		[Token(Token = "0x40006AF")]
		k_EDenySteamConnectionLost,
		[Token(Token = "0x40006B0")]
		k_EDenySteamConnectionError,
		[Token(Token = "0x40006B1")]
		k_EDenySteamResponseTimedOut,
		[Token(Token = "0x40006B2")]
		k_EDenySteamValidationStalled,
		[Token(Token = "0x40006B3")]
		k_EDenySteamOwnerLeftGuestUser
	}
	[Token(Token = "0x2000193")]
	public enum EBeginAuthSessionResult
	{
		[Token(Token = "0x40006B5")]
		k_EBeginAuthSessionResultOK,
		[Token(Token = "0x40006B6")]
		k_EBeginAuthSessionResultInvalidTicket,
		[Token(Token = "0x40006B7")]
		k_EBeginAuthSessionResultDuplicateRequest,
		[Token(Token = "0x40006B8")]
		k_EBeginAuthSessionResultInvalidVersion,
		[Token(Token = "0x40006B9")]
		k_EBeginAuthSessionResultGameMismatch,
		[Token(Token = "0x40006BA")]
		k_EBeginAuthSessionResultExpiredTicket
	}
	[Token(Token = "0x2000194")]
	public enum EAuthSessionResponse
	{
		[Token(Token = "0x40006BC")]
		k_EAuthSessionResponseOK,
		[Token(Token = "0x40006BD")]
		k_EAuthSessionResponseUserNotConnectedToSteam,
		[Token(Token = "0x40006BE")]
		k_EAuthSessionResponseNoLicenseOrExpired,
		[Token(Token = "0x40006BF")]
		k_EAuthSessionResponseVACBanned,
		[Token(Token = "0x40006C0")]
		k_EAuthSessionResponseLoggedInElseWhere,
		[Token(Token = "0x40006C1")]
		k_EAuthSessionResponseVACCheckTimedOut,
		[Token(Token = "0x40006C2")]
		k_EAuthSessionResponseAuthTicketCanceled,
		[Token(Token = "0x40006C3")]
		k_EAuthSessionResponseAuthTicketInvalidAlreadyUsed,
		[Token(Token = "0x40006C4")]
		k_EAuthSessionResponseAuthTicketInvalid,
		[Token(Token = "0x40006C5")]
		k_EAuthSessionResponsePublisherIssuedBan
	}
	[Token(Token = "0x2000195")]
	public enum EUserHasLicenseForAppResult
	{
		[Token(Token = "0x40006C7")]
		k_EUserHasLicenseResultHasLicense,
		[Token(Token = "0x40006C8")]
		k_EUserHasLicenseResultDoesNotHaveLicense,
		[Token(Token = "0x40006C9")]
		k_EUserHasLicenseResultNoAuth
	}
	[Token(Token = "0x2000196")]
	public enum EAccountType
	{
		[Token(Token = "0x40006CB")]
		k_EAccountTypeInvalid,
		[Token(Token = "0x40006CC")]
		k_EAccountTypeIndividual,
		[Token(Token = "0x40006CD")]
		k_EAccountTypeMultiseat,
		[Token(Token = "0x40006CE")]
		k_EAccountTypeGameServer,
		[Token(Token = "0x40006CF")]
		k_EAccountTypeAnonGameServer,
		[Token(Token = "0x40006D0")]
		k_EAccountTypePending,
		[Token(Token = "0x40006D1")]
		k_EAccountTypeContentServer,
		[Token(Token = "0x40006D2")]
		k_EAccountTypeClan,
		[Token(Token = "0x40006D3")]
		k_EAccountTypeChat,
		[Token(Token = "0x40006D4")]
		k_EAccountTypeConsoleUser,
		[Token(Token = "0x40006D5")]
		k_EAccountTypeAnonUser,
		[Token(Token = "0x40006D6")]
		k_EAccountTypeMax
	}
	[Token(Token = "0x2000197")]
	public enum EAppReleaseState
	{
		[Token(Token = "0x40006D8")]
		k_EAppReleaseState_Unknown,
		[Token(Token = "0x40006D9")]
		k_EAppReleaseState_Unavailable,
		[Token(Token = "0x40006DA")]
		k_EAppReleaseState_Prerelease,
		[Token(Token = "0x40006DB")]
		k_EAppReleaseState_PreloadOnly,
		[Token(Token = "0x40006DC")]
		k_EAppReleaseState_Released
	}
	[Token(Token = "0x2000198")]
	[Flags]
	public enum EAppOwnershipFlags
	{
		[Token(Token = "0x40006DE")]
		k_EAppOwnershipFlags_None = 0,
		[Token(Token = "0x40006DF")]
		k_EAppOwnershipFlags_OwnsLicense = 1,
		[Token(Token = "0x40006E0")]
		k_EAppOwnershipFlags_FreeLicense = 2,
		[Token(Token = "0x40006E1")]
		k_EAppOwnershipFlags_RegionRestricted = 4,
		[Token(Token = "0x40006E2")]
		k_EAppOwnershipFlags_LowViolence = 8,
		[Token(Token = "0x40006E3")]
		k_EAppOwnershipFlags_InvalidPlatform = 0x10,
		[Token(Token = "0x40006E4")]
		k_EAppOwnershipFlags_SharedLicense = 0x20,
		[Token(Token = "0x40006E5")]
		k_EAppOwnershipFlags_FreeWeekend = 0x40,
		[Token(Token = "0x40006E6")]
		k_EAppOwnershipFlags_RetailLicense = 0x80,
		[Token(Token = "0x40006E7")]
		k_EAppOwnershipFlags_LicenseLocked = 0x100,
		[Token(Token = "0x40006E8")]
		k_EAppOwnershipFlags_LicensePending = 0x200,
		[Token(Token = "0x40006E9")]
		k_EAppOwnershipFlags_LicenseExpired = 0x400,
		[Token(Token = "0x40006EA")]
		k_EAppOwnershipFlags_LicensePermanent = 0x800,
		[Token(Token = "0x40006EB")]
		k_EAppOwnershipFlags_LicenseRecurring = 0x1000,
		[Token(Token = "0x40006EC")]
		k_EAppOwnershipFlags_LicenseCanceled = 0x2000,
		[Token(Token = "0x40006ED")]
		k_EAppOwnershipFlags_AutoGrant = 0x4000,
		[Token(Token = "0x40006EE")]
		k_EAppOwnershipFlags_PendingGift = 0x8000,
		[Token(Token = "0x40006EF")]
		k_EAppOwnershipFlags_RentalNotActivated = 0x10000,
		[Token(Token = "0x40006F0")]
		k_EAppOwnershipFlags_Rental = 0x20000,
		[Token(Token = "0x40006F1")]
		k_EAppOwnershipFlags_SiteLicense = 0x40000
	}
	[Token(Token = "0x2000199")]
	[Flags]
	public enum EAppType
	{
		[Token(Token = "0x40006F3")]
		k_EAppType_Invalid = 0,
		[Token(Token = "0x40006F4")]
		k_EAppType_Game = 1,
		[Token(Token = "0x40006F5")]
		k_EAppType_Application = 2,
		[Token(Token = "0x40006F6")]
		k_EAppType_Tool = 4,
		[Token(Token = "0x40006F7")]
		k_EAppType_Demo = 8,
		[Token(Token = "0x40006F8")]
		k_EAppType_Media_DEPRECATED = 0x10,
		[Token(Token = "0x40006F9")]
		k_EAppType_DLC = 0x20,
		[Token(Token = "0x40006FA")]
		k_EAppType_Guide = 0x40,
		[Token(Token = "0x40006FB")]
		k_EAppType_Driver = 0x80,
		[Token(Token = "0x40006FC")]
		k_EAppType_Config = 0x100,
		[Token(Token = "0x40006FD")]
		k_EAppType_Hardware = 0x200,
		[Token(Token = "0x40006FE")]
		k_EAppType_Franchise = 0x400,
		[Token(Token = "0x40006FF")]
		k_EAppType_Video = 0x800,
		[Token(Token = "0x4000700")]
		k_EAppType_Plugin = 0x1000,
		[Token(Token = "0x4000701")]
		k_EAppType_Music = 0x2000,
		[Token(Token = "0x4000702")]
		k_EAppType_Series = 0x4000,
		[Token(Token = "0x4000703")]
		k_EAppType_Comic = 0x8000,
		[Token(Token = "0x4000704")]
		k_EAppType_Shortcut = 0x40000000,
		[Token(Token = "0x4000705")]
		k_EAppType_DepotOnly = -2147483647
	}
	[Token(Token = "0x200019A")]
	public enum ESteamUserStatType
	{
		[Token(Token = "0x4000707")]
		k_ESteamUserStatTypeINVALID,
		[Token(Token = "0x4000708")]
		k_ESteamUserStatTypeINT,
		[Token(Token = "0x4000709")]
		k_ESteamUserStatTypeFLOAT,
		[Token(Token = "0x400070A")]
		k_ESteamUserStatTypeAVGRATE,
		[Token(Token = "0x400070B")]
		k_ESteamUserStatTypeACHIEVEMENTS,
		[Token(Token = "0x400070C")]
		k_ESteamUserStatTypeGROUPACHIEVEMENTS,
		[Token(Token = "0x400070D")]
		k_ESteamUserStatTypeMAX
	}
	[Token(Token = "0x200019B")]
	public enum EChatEntryType
	{
		[Token(Token = "0x400070F")]
		k_EChatEntryTypeInvalid = 0,
		[Token(Token = "0x4000710")]
		k_EChatEntryTypeChatMsg = 1,
		[Token(Token = "0x4000711")]
		k_EChatEntryTypeTyping = 2,
		[Token(Token = "0x4000712")]
		k_EChatEntryTypeInviteGame = 3,
		[Token(Token = "0x4000713")]
		k_EChatEntryTypeEmote = 4,
		[Token(Token = "0x4000714")]
		k_EChatEntryTypeLeftConversation = 6,
		[Token(Token = "0x4000715")]
		k_EChatEntryTypeEntered = 7,
		[Token(Token = "0x4000716")]
		k_EChatEntryTypeWasKicked = 8,
		[Token(Token = "0x4000717")]
		k_EChatEntryTypeWasBanned = 9,
		[Token(Token = "0x4000718")]
		k_EChatEntryTypeDisconnected = 10,
		[Token(Token = "0x4000719")]
		k_EChatEntryTypeHistoricalChat = 11,
		[Token(Token = "0x400071A")]
		k_EChatEntryTypeLinkBlocked = 14
	}
	[Token(Token = "0x200019C")]
	public enum EChatRoomEnterResponse
	{
		[Token(Token = "0x400071C")]
		k_EChatRoomEnterResponseSuccess = 1,
		[Token(Token = "0x400071D")]
		k_EChatRoomEnterResponseDoesntExist = 2,
		[Token(Token = "0x400071E")]
		k_EChatRoomEnterResponseNotAllowed = 3,
		[Token(Token = "0x400071F")]
		k_EChatRoomEnterResponseFull = 4,
		[Token(Token = "0x4000720")]
		k_EChatRoomEnterResponseError = 5,
		[Token(Token = "0x4000721")]
		k_EChatRoomEnterResponseBanned = 6,
		[Token(Token = "0x4000722")]
		k_EChatRoomEnterResponseLimited = 7,
		[Token(Token = "0x4000723")]
		k_EChatRoomEnterResponseClanDisabled = 8,
		[Token(Token = "0x4000724")]
		k_EChatRoomEnterResponseCommunityBan = 9,
		[Token(Token = "0x4000725")]
		k_EChatRoomEnterResponseMemberBlockedYou = 10,
		[Token(Token = "0x4000726")]
		k_EChatRoomEnterResponseYouBlockedMember = 11,
		[Token(Token = "0x4000727")]
		k_EChatRoomEnterResponseRatelimitExceeded = 15
	}
	[Token(Token = "0x200019D")]
	[Flags]
	public enum EChatSteamIDInstanceFlags
	{
		[Token(Token = "0x4000729")]
		k_EChatAccountInstanceMask = 0xFFF,
		[Token(Token = "0x400072A")]
		k_EChatInstanceFlagClan = 0x80000,
		[Token(Token = "0x400072B")]
		k_EChatInstanceFlagLobby = 0x40000,
		[Token(Token = "0x400072C")]
		k_EChatInstanceFlagMMSLobby = 0x20000
	}
	[Token(Token = "0x200019E")]
	[Flags]
	public enum EMarketingMessageFlags
	{
		[Token(Token = "0x400072E")]
		k_EMarketingMessageFlagsNone = 0,
		[Token(Token = "0x400072F")]
		k_EMarketingMessageFlagsHighPriority = 1,
		[Token(Token = "0x4000730")]
		k_EMarketingMessageFlagsPlatformWindows = 2,
		[Token(Token = "0x4000731")]
		k_EMarketingMessageFlagsPlatformMac = 4,
		[Token(Token = "0x4000732")]
		k_EMarketingMessageFlagsPlatformLinux = 8,
		[Token(Token = "0x4000733")]
		k_EMarketingMessageFlagsPlatformRestrictions = 0xE
	}
	[Token(Token = "0x200019F")]
	public enum ENotificationPosition
	{
		[Token(Token = "0x4000735")]
		k_EPositionTopLeft,
		[Token(Token = "0x4000736")]
		k_EPositionTopRight,
		[Token(Token = "0x4000737")]
		k_EPositionBottomLeft,
		[Token(Token = "0x4000738")]
		k_EPositionBottomRight
	}
	[Token(Token = "0x20001A0")]
	public enum EBroadcastUploadResult
	{
		[Token(Token = "0x400073A")]
		k_EBroadcastUploadResultNone,
		[Token(Token = "0x400073B")]
		k_EBroadcastUploadResultOK,
		[Token(Token = "0x400073C")]
		k_EBroadcastUploadResultInitFailed,
		[Token(Token = "0x400073D")]
		k_EBroadcastUploadResultFrameFailed,
		[Token(Token = "0x400073E")]
		k_EBroadcastUploadResultTimeout,
		[Token(Token = "0x400073F")]
		k_EBroadcastUploadResultBandwidthExceeded,
		[Token(Token = "0x4000740")]
		k_EBroadcastUploadResultLowFPS,
		[Token(Token = "0x4000741")]
		k_EBroadcastUploadResultMissingKeyFrames,
		[Token(Token = "0x4000742")]
		k_EBroadcastUploadResultNoConnection,
		[Token(Token = "0x4000743")]
		k_EBroadcastUploadResultRelayFailed,
		[Token(Token = "0x4000744")]
		k_EBroadcastUploadResultSettingsChanged,
		[Token(Token = "0x4000745")]
		k_EBroadcastUploadResultMissingAudio,
		[Token(Token = "0x4000746")]
		k_EBroadcastUploadResultTooFarBehind,
		[Token(Token = "0x4000747")]
		k_EBroadcastUploadResultTranscodeBehind
	}
	[Token(Token = "0x20001A1")]
	public enum ELaunchOptionType
	{
		[Token(Token = "0x4000749")]
		k_ELaunchOptionType_None = 0,
		[Token(Token = "0x400074A")]
		k_ELaunchOptionType_Default = 1,
		[Token(Token = "0x400074B")]
		k_ELaunchOptionType_SafeMode = 2,
		[Token(Token = "0x400074C")]
		k_ELaunchOptionType_Multiplayer = 3,
		[Token(Token = "0x400074D")]
		k_ELaunchOptionType_Config = 4,
		[Token(Token = "0x400074E")]
		k_ELaunchOptionType_OpenVR = 5,
		[Token(Token = "0x400074F")]
		k_ELaunchOptionType_Server = 6,
		[Token(Token = "0x4000750")]
		k_ELaunchOptionType_Editor = 7,
		[Token(Token = "0x4000751")]
		k_ELaunchOptionType_Manual = 8,
		[Token(Token = "0x4000752")]
		k_ELaunchOptionType_Benchmark = 9,
		[Token(Token = "0x4000753")]
		k_ELaunchOptionType_Option1 = 10,
		[Token(Token = "0x4000754")]
		k_ELaunchOptionType_Option2 = 11,
		[Token(Token = "0x4000755")]
		k_ELaunchOptionType_Option3 = 12,
		[Token(Token = "0x4000756")]
		k_ELaunchOptionType_OculusVR = 13,
		[Token(Token = "0x4000757")]
		k_ELaunchOptionType_OpenVROverlay = 14,
		[Token(Token = "0x4000758")]
		k_ELaunchOptionType_OSVR = 15,
		[Token(Token = "0x4000759")]
		k_ELaunchOptionType_Dialog = 1000
	}
	[Token(Token = "0x20001A2")]
	public enum EVRHMDType
	{
		[Token(Token = "0x400075B")]
		k_eEVRHMDType_None = -1,
		[Token(Token = "0x400075C")]
		k_eEVRHMDType_Unknown = 0,
		[Token(Token = "0x400075D")]
		k_eEVRHMDType_HTC_Dev = 1,
		[Token(Token = "0x400075E")]
		k_eEVRHMDType_HTC_VivePre = 2,
		[Token(Token = "0x400075F")]
		k_eEVRHMDType_HTC_Vive = 3,
		[Token(Token = "0x4000760")]
		k_eEVRHMDType_HTC_Unknown = 20,
		[Token(Token = "0x4000761")]
		k_eEVRHMDType_Oculus_DK1 = 21,
		[Token(Token = "0x4000762")]
		k_eEVRHMDType_Oculus_DK2 = 22,
		[Token(Token = "0x4000763")]
		k_eEVRHMDType_Oculus_Rift = 23,
		[Token(Token = "0x4000764")]
		k_eEVRHMDType_Oculus_Unknown = 40
	}
	[Token(Token = "0x20001A3")]
	public enum EHTTPMethod
	{
		[Token(Token = "0x4000766")]
		k_EHTTPMethodInvalid,
		[Token(Token = "0x4000767")]
		k_EHTTPMethodGET,
		[Token(Token = "0x4000768")]
		k_EHTTPMethodHEAD,
		[Token(Token = "0x4000769")]
		k_EHTTPMethodPOST,
		[Token(Token = "0x400076A")]
		k_EHTTPMethodPUT,
		[Token(Token = "0x400076B")]
		k_EHTTPMethodDELETE,
		[Token(Token = "0x400076C")]
		k_EHTTPMethodOPTIONS,
		[Token(Token = "0x400076D")]
		k_EHTTPMethodPATCH
	}
	[Token(Token = "0x20001A4")]
	public enum EHTTPStatusCode
	{
		[Token(Token = "0x400076F")]
		k_EHTTPStatusCodeInvalid = 0,
		[Token(Token = "0x4000770")]
		k_EHTTPStatusCode100Continue = 100,
		[Token(Token = "0x4000771")]
		k_EHTTPStatusCode101SwitchingProtocols = 101,
		[Token(Token = "0x4000772")]
		k_EHTTPStatusCode200OK = 200,
		[Token(Token = "0x4000773")]
		k_EHTTPStatusCode201Created = 201,
		[Token(Token = "0x4000774")]
		k_EHTTPStatusCode202Accepted = 202,
		[Token(Token = "0x4000775")]
		k_EHTTPStatusCode203NonAuthoritative = 203,
		[Token(Token = "0x4000776")]
		k_EHTTPStatusCode204NoContent = 204,
		[Token(Token = "0x4000777")]
		k_EHTTPStatusCode205ResetContent = 205,
		[Token(Token = "0x4000778")]
		k_EHTTPStatusCode206PartialContent = 206,
		[Token(Token = "0x4000779")]
		k_EHTTPStatusCode300MultipleChoices = 300,
		[Token(Token = "0x400077A")]
		k_EHTTPStatusCode301MovedPermanently = 301,
		[Token(Token = "0x400077B")]
		k_EHTTPStatusCode302Found = 302,
		[Token(Token = "0x400077C")]
		k_EHTTPStatusCode303SeeOther = 303,
		[Token(Token = "0x400077D")]
		k_EHTTPStatusCode304NotModified = 304,
		[Token(Token = "0x400077E")]
		k_EHTTPStatusCode305UseProxy = 305,
		[Token(Token = "0x400077F")]
		k_EHTTPStatusCode307TemporaryRedirect = 307,
		[Token(Token = "0x4000780")]
		k_EHTTPStatusCode400BadRequest = 400,
		[Token(Token = "0x4000781")]
		k_EHTTPStatusCode401Unauthorized = 401,
		[Token(Token = "0x4000782")]
		k_EHTTPStatusCode402PaymentRequired = 402,
		[Token(Token = "0x4000783")]
		k_EHTTPStatusCode403Forbidden = 403,
		[Token(Token = "0x4000784")]
		k_EHTTPStatusCode404NotFound = 404,
		[Token(Token = "0x4000785")]
		k_EHTTPStatusCode405MethodNotAllowed = 405,
		[Token(Token = "0x4000786")]
		k_EHTTPStatusCode406NotAcceptable = 406,
		[Token(Token = "0x4000787")]
		k_EHTTPStatusCode407ProxyAuthRequired = 407,
		[Token(Token = "0x4000788")]
		k_EHTTPStatusCode408RequestTimeout = 408,
		[Token(Token = "0x4000789")]
		k_EHTTPStatusCode409Conflict = 409,
		[Token(Token = "0x400078A")]
		k_EHTTPStatusCode410Gone = 410,
		[Token(Token = "0x400078B")]
		k_EHTTPStatusCode411LengthRequired = 411,
		[Token(Token = "0x400078C")]
		k_EHTTPStatusCode412PreconditionFailed = 412,
		[Token(Token = "0x400078D")]
		k_EHTTPStatusCode413RequestEntityTooLarge = 413,
		[Token(Token = "0x400078E")]
		k_EHTTPStatusCode414RequestURITooLong = 414,
		[Token(Token = "0x400078F")]
		k_EHTTPStatusCode415UnsupportedMediaType = 415,
		[Token(Token = "0x4000790")]
		k_EHTTPStatusCode416RequestedRangeNotSatisfiable = 416,
		[Token(Token = "0x4000791")]
		k_EHTTPStatusCode417ExpectationFailed = 417,
		[Token(Token = "0x4000792")]
		k_EHTTPStatusCode4xxUnknown = 418,
		[Token(Token = "0x4000793")]
		k_EHTTPStatusCode429TooManyRequests = 429,
		[Token(Token = "0x4000794")]
		k_EHTTPStatusCode500InternalServerError = 500,
		[Token(Token = "0x4000795")]
		k_EHTTPStatusCode501NotImplemented = 501,
		[Token(Token = "0x4000796")]
		k_EHTTPStatusCode502BadGateway = 502,
		[Token(Token = "0x4000797")]
		k_EHTTPStatusCode503ServiceUnavailable = 503,
		[Token(Token = "0x4000798")]
		k_EHTTPStatusCode504GatewayTimeout = 504,
		[Token(Token = "0x4000799")]
		k_EHTTPStatusCode505HTTPVersionNotSupported = 505,
		[Token(Token = "0x400079A")]
		k_EHTTPStatusCode5xxUnknown = 599
	}
	[Token(Token = "0x20001A5")]
	public enum EUniverse
	{
		[Token(Token = "0x400079C")]
		k_EUniverseInvalid,
		[Token(Token = "0x400079D")]
		k_EUniversePublic,
		[Token(Token = "0x400079E")]
		k_EUniverseBeta,
		[Token(Token = "0x400079F")]
		k_EUniverseInternal,
		[Token(Token = "0x40007A0")]
		k_EUniverseDev,
		[Token(Token = "0x40007A1")]
		k_EUniverseMax
	}
	[Token(Token = "0x20001A6")]
	public struct ControllerAnalogActionData_t
	{
		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EControllerSourceMode eMode;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float x;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float y;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public byte bActive;
	}
	[Token(Token = "0x20001A7")]
	public struct ControllerDigitalActionData_t
	{
		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte bState;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte bActive;
	}
	[Token(Token = "0x20001A8")]
	public struct ControllerMotionData_t
	{
		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float rotQuatX;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float rotQuatY;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float rotQuatZ;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float rotQuatW;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float posAccelX;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float posAccelY;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float posAccelZ;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rotVelX;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rotVelY;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotVelZ;
	}
	[Token(Token = "0x20001A9")]
	public struct FriendGameInfo_t
	{
		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CGameID m_gameID;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint m_unGameIP;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public ushort m_usGamePort;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public ushort m_usQueryPort;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CSteamID m_steamIDLobby;
	}
	[Token(Token = "0x20001AA")]
	public struct FriendSessionStateInfo_t
	{
		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_uiOnlineSessionInstances;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public byte m_uiPublishedToFriendsSessionInstance;
	}
	[Token(Token = "0x20001AB")]
	public struct SteamItemDetails_t
	{
		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SteamItemInstanceID_t m_itemId;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SteamItemDef_t m_iDefinition;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public ushort m_unQuantity;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public ushort m_unFlags;
	}
	[Token(Token = "0x20001AC")]
	public struct P2PSessionState_t
	{
		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte m_bConnectionActive;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte m_bConnecting;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public byte m_eP2PSessionError;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte m_bUsingRelay;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nBytesQueuedForSend;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nPacketsQueuedForSend;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint m_nRemoteIP;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ushort m_nRemotePort;
	}
	[Token(Token = "0x20001AD")]
	public struct SteamParamStringArray_t
	{
		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr m_ppStrings;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_nNumStrings;
	}
	[Token(Token = "0x20001AE")]
	public struct SteamUGCDetails_t
	{
		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public EWorkshopFileType m_eFileType;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AppId_t m_nCreatorAppID;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public AppId_t m_nConsumerAppID;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string m_rgchTitle;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public string m_rgchDescription;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ulong m_ulSteamIDOwner;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint m_rtimeCreated;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public uint m_rtimeUpdated;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public uint m_rtimeAddedToUserList;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public ERemoteStoragePublishedFileVisibility m_eVisibility;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool m_bBanned;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool m_bAcceptedForUse;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public bool m_bTagsTruncated;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public string m_rgchTags;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UGCHandle_t m_hFile;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UGCHandle_t m_hPreviewFile;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string m_pchFileName;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int m_nFileSize;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int m_nPreviewFileSize;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public string m_rgchURL;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public uint m_unVotesUp;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public uint m_unVotesDown;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float m_flScore;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public uint m_unNumChildren;
	}
	[Token(Token = "0x20001AF")]
	public struct CallbackMsg_t
	{
		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_hSteamUser;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int m_iCallback;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr m_pubParam;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_cubParam;
	}
	[Token(Token = "0x20001B0")]
	public struct LeaderboardEntry_t
	{
		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int m_nGlobalRank;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int m_nScore;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_cDetails;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public UGCHandle_t m_hUGC;
	}
	[Token(Token = "0x20001B1")]
	public struct MatchMakingKeyValuePair_t
	{
		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string m_szKey;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public string m_szValue;

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x382BF0", Offset = "0x382BF0", VA = "0x382BF0")]
		private MatchMakingKeyValuePair_t(string strKey, string strValue)
		{
		}
	}
	[Token(Token = "0x20001B2")]
	public static class CallbackDispatcher
	{
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x374B6C", Offset = "0x374B6C", VA = "0x374B6C")]
		public static void ExceptionHandler(Exception e)
		{
		}
	}
	[Token(Token = "0x20001B3")]
	public sealed class Callback<T> : IDisposable
	{
		[Token(Token = "0x20001B4")]
		public delegate void DispatchDelegate(T param);

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private CCallbackBaseVTable VTable;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr m_pVTable;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private CCallbackBase m_CCallbackBase;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GCHandle m_pCCallbackBase;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_bGameServer;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int m_size;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_bDisposed;

		[Token(Token = "0x14000001")]
		private event DispatchDelegate m_Func
		{
			[Token(Token = "0x600075F")]
			add
			{
			}
			[Token(Token = "0x6000760")]
			remove
			{
			}
		}

		[Token(Token = "0x600075E")]
		public Callback(DispatchDelegate func, bool bGameServer = false)
		{
		}

		[Token(Token = "0x6000761")]
		public static Callback<T> Create(DispatchDelegate func)
		{
			return null;
		}

		[Token(Token = "0x6000762")]
		public static Callback<T> CreateGameServer(DispatchDelegate func)
		{
			return null;
		}

		[Token(Token = "0x6000763")]
		~Callback()
		{
		}

		[Token(Token = "0x6000764")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000765")]
		public void Register(DispatchDelegate func)
		{
		}

		[Token(Token = "0x6000766")]
		public void Unregister()
		{
		}

		[Token(Token = "0x6000767")]
		public void SetGameserverFlag()
		{
		}

		[Token(Token = "0x6000768")]
		private void OnRunCallback(IntPtr thisptr, IntPtr pvParam)
		{
		}

		[Token(Token = "0x6000769")]
		private void OnRunCallResult(IntPtr thisptr, IntPtr pvParam, bool bFailed, ulong hSteamAPICall)
		{
		}

		[Token(Token = "0x600076A")]
		private int OnGetCallbackSizeBytes(IntPtr thisptr)
		{
			return default(int);
		}

		[Token(Token = "0x600076B")]
		private void BuildCCallbackBase()
		{
		}
	}
	[Token(Token = "0x20001B5")]
	public sealed class CallResult<T> : IDisposable
	{
		[Token(Token = "0x20001B6")]
		public delegate void APIDispatchDelegate(T param, bool bIOFailure);

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private CCallbackBaseVTable VTable;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr m_pVTable;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private CCallbackBase m_CCallbackBase;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GCHandle m_pCCallbackBase;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private SteamAPICall_t m_hAPICall;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int m_size;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_bDisposed;

		[Token(Token = "0x17000020")]
		public SteamAPICall_t Handle
		{
			[Token(Token = "0x6000773")]
			get
			{
				return default(SteamAPICall_t);
			}
		}

		[Token(Token = "0x14000002")]
		private event APIDispatchDelegate m_Func
		{
			[Token(Token = "0x6000771")]
			add
			{
			}
			[Token(Token = "0x6000772")]
			remove
			{
			}
		}

		[Token(Token = "0x6000770")]
		public CallResult([Optional] APIDispatchDelegate func)
		{
		}

		[Token(Token = "0x6000774")]
		public static CallResult<T> Create([Optional] APIDispatchDelegate func)
		{
			return null;
		}

		[Token(Token = "0x6000775")]
		~CallResult()
		{
		}

		[Token(Token = "0x6000776")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000777")]
		public void Set(SteamAPICall_t hAPICall, [Optional] APIDispatchDelegate func)
		{
		}

		[Token(Token = "0x6000778")]
		public bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x6000779")]
		public void Cancel()
		{
		}

		[Token(Token = "0x600077A")]
		public void SetGameserverFlag()
		{
		}

		[Token(Token = "0x600077B")]
		private void OnRunCallback(IntPtr thisptr, IntPtr pvParam)
		{
		}

		[Token(Token = "0x600077C")]
		private void OnRunCallResult(IntPtr thisptr, IntPtr pvParam, bool bFailed, ulong hSteamAPICall_)
		{
		}

		[Token(Token = "0x600077D")]
		private int OnGetCallbackSizeBytes(IntPtr thisptr)
		{
			return default(int);
		}

		[Token(Token = "0x600077E")]
		private void BuildCCallbackBase()
		{
		}
	}
	[StructLayout(0)]
	[Token(Token = "0x20001B7")]
	internal class CCallbackBase
	{
		[Token(Token = "0x40007FC")]
		public const byte k_ECallbackFlagsRegistered = 1;

		[Token(Token = "0x40007FD")]
		public const byte k_ECallbackFlagsGameServer = 2;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr m_vfptr;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public byte m_nCallbackFlags;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_iCallback;

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x374CC0", Offset = "0x374CC0", VA = "0x374CC0")]
		public CCallbackBase()
		{
		}
	}
	[StructLayout(0)]
	[Token(Token = "0x20001B8")]
	internal class CCallbackBaseVTable
	{
		[Token(Token = "0x20001B9")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x2B4724", Offset = "0x2B4724")]
		public delegate void RunCBDel(IntPtr thisptr, IntPtr pvParam);

		[Token(Token = "0x20001BA")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x2B4738", Offset = "0x2B4738")]
		public delegate void RunCRDel(IntPtr thisptr, IntPtr pvParam, bool bIOFailure, ulong hSteamAPICall);

		[Token(Token = "0x20001BB")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x2B474C", Offset = "0x2B474C")]
		public delegate int GetCallbackSizeBytesDel(IntPtr thisptr);

		[Token(Token = "0x4000801")]
		private const CallingConvention cc = CallingConvention.Cdecl;

		[NonSerialized]
		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public RunCBDel m_RunCallback;

		[NonSerialized]
		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public RunCRDel m_RunCallResult;

		[NonSerialized]
		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GetCallbackSizeBytesDel m_GetCallbackSizeBytes;

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x374DA8", Offset = "0x374DA8", VA = "0x374DA8")]
		public CCallbackBaseVTable()
		{
		}
	}
	[Token(Token = "0x20001BC")]
	internal class CallbackIdentities
	{
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x374B70", Offset = "0x374B70", VA = "0x374B70")]
		public CallbackIdentities()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x374B78", Offset = "0x374B78", VA = "0x374B78")]
		public static int GetCallbackIdentity(Type callbackStruct)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001BD")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x2B4760", Offset = "0x2B4760")]
	internal class CallbackIdentityAttribute : Attribute
	{
		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B4794", Offset = "0x2B4794")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2B4794", Offset = "0x2B4794")]
		private int <Identity>k__BackingField;

		[Token(Token = "0x17000021")]
		public int Identity
		{
			[Token(Token = "0x6000794")]
			[Address(RVA = "0x374C7C", Offset = "0x374C7C", VA = "0x374C7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B47C8", Offset = "0x2B47C8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000795")]
			[Address(RVA = "0x374C74", Offset = "0x374C74", VA = "0x374C74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B47D8", Offset = "0x2B47D8")]
			set
			{
			}
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x374C54", Offset = "0x374C54", VA = "0x374C54")]
		public CallbackIdentityAttribute(int callbackNum)
		{
		}
	}
	[Token(Token = "0x20001BE")]
	public class InteropHelp
	{
		[Token(Token = "0x20001BF")]
		public class UTF8StringHandle : IDisposable
		{
			[Token(Token = "0x600079B")]
			[Address(RVA = "0x376FA0", Offset = "0x376FA0", VA = "0x376FA0")]
			public UTF8StringHandle(string str)
			{
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0x37CE48", Offset = "0x37CE48", VA = "0x37CE48", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x20001C0")]
		public class SteamParamStringArray
		{
			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private IntPtr[] m_Strings;

			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private IntPtr m_ptrStrings;

			[Token(Token = "0x4000808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private IntPtr m_pSteamParamStringArray;

			[Token(Token = "0x600079D")]
			[Address(RVA = "0x37C558", Offset = "0x37C558", VA = "0x37C558")]
			public SteamParamStringArray(IList<string> strings)
			{
			}

			[Token(Token = "0x600079E")]
			[Address(RVA = "0x37CC50", Offset = "0x37CC50", VA = "0x37CC50", Slot = "1")]
			~SteamParamStringArray()
			{
			}

			[Token(Token = "0x600079F")]
			[Address(RVA = "0x37CE28", Offset = "0x37CE28", VA = "0x37CE28")]
			public static implicit operator IntPtr(SteamParamStringArray that)
			{
				return default(IntPtr);
			}
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x37C1AC", Offset = "0x37C1AC", VA = "0x37C1AC")]
		public InteropHelp()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x378E64", Offset = "0x378E64", VA = "0x378E64")]
		public static void TestIfPlatformSupported()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x37C1B4", Offset = "0x37C1B4", VA = "0x37C1B4")]
		public static void TestIfAvailableClient()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x37C288", Offset = "0x37C288", VA = "0x37C288")]
		public static void TestIfAvailableGameServer()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x37C35C", Offset = "0x37C35C", VA = "0x37C35C")]
		public static string PtrToStringUTF8(IntPtr nativeUtf8)
		{
			return null;
		}
	}
	[Token(Token = "0x20001C1")]
	public class MMKVPMarshaller
	{
		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private IntPtr m_pNativeArray;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private IntPtr m_pArrayEntries;

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x382BFC", Offset = "0x382BFC", VA = "0x382BFC")]
		public MMKVPMarshaller(MatchMakingKeyValuePair_t[] filters)
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x382E9C", Offset = "0x382E9C", VA = "0x382E9C", Slot = "1")]
		~MMKVPMarshaller()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x382FEC", Offset = "0x382FEC", VA = "0x382FEC")]
		public static implicit operator IntPtr(MMKVPMarshaller that)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x20001C2")]
	public class DllCheck
	{
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x3787F0", Offset = "0x3787F0", VA = "0x3787F0")]
		public DllCheck()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x3787F8", Offset = "0x3787F8", VA = "0x3787F8")]
		public static bool Test()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001C3")]
	public class ISteamMatchmakingServerListResponse
	{
		[Token(Token = "0x20001C4")]
		public delegate void ServerResponded(HServerListRequest hRequest, int iServer);

		[Token(Token = "0x20001C5")]
		public delegate void ServerFailedToRespond(HServerListRequest hRequest, int iServer);

		[Token(Token = "0x20001C6")]
		public delegate void RefreshComplete(HServerListRequest hRequest, EMatchMakingServerResponse response);

		[Token(Token = "0x20001C7")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x2B47E8", Offset = "0x2B47E8")]
		private delegate void InternalServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer);

		[Token(Token = "0x20001C8")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x2B47FC", Offset = "0x2B47FC")]
		private delegate void InternalServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer);

		[Token(Token = "0x20001C9")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x2B4810", Offset = "0x2B4810")]
		private delegate void InternalRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response);

		[StructLayout(0)]
		[Token(Token = "0x20001CA")]
		private class VTable
		{
			[NonSerialized]
			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public InternalServerResponded m_VTServerResponded;

			[NonSerialized]
			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public InternalServerFailedToRespond m_VTServerFailedToRespond;

			[NonSerialized]
			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InternalRefreshComplete m_VTRefreshComplete;

			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x3812BC", Offset = "0x3812BC", VA = "0x3812BC")]
			public VTable()
			{
			}
		}

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private VTable m_VTable;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private IntPtr m_pVTable;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private GCHandle m_pGCHandle;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private ServerResponded m_ServerResponded;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ServerFailedToRespond m_ServerFailedToRespond;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private RefreshComplete m_RefreshComplete;

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x381000", Offset = "0x381000", VA = "0x381000")]
		public ISteamMatchmakingServerListResponse(ServerResponded onServerResponded, ServerFailedToRespond onServerFailedToRespond, RefreshComplete onRefreshComplete)
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x381300", Offset = "0x381300", VA = "0x381300", Slot = "1")]
		~ISteamMatchmakingServerListResponse()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x381418", Offset = "0x381418", VA = "0x381418")]
		private void InternalOnServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x381678", Offset = "0x381678", VA = "0x381678")]
		private void InternalOnServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer)
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x3818D8", Offset = "0x3818D8", VA = "0x3818D8")]
		private void InternalOnRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response)
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x381B38", Offset = "0x381B38", VA = "0x381B38")]
		public static explicit operator IntPtr(ISteamMatchmakingServerListResponse that)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x20001CB")]
	public class ISteamMatchmakingPingResponse
	{
		[Token(Token = "0x20001CC")]
		public delegate void ServerResponded(gameserveritem_t server);

		[Token(Token = "0x20001CD")]
		public delegate void ServerFailedToRespond();

		[Token(Token = "0x20001CE")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x2B4824", Offset = "0x2B4824")]
		private delegate void InternalServerResponded(IntPtr thisptr, gameserveritem_t server);

		[Token(Token = "0x20001CF")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x2B4838", Offset = "0x2B4838")]
		private delegate void InternalServerFailedToRespond(IntPtr thisptr);

		[StructLayout(0)]
		[Token(Token = "0x20001D0")]
		private class VTable
		{
			[NonSerialized]
			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public InternalServerResponded m_VTServerResponded;

			[NonSerialized]
			[Token(Token = "0x400081A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public InternalServerFailedToRespond m_VTServerFailedToRespond;

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x37D0B0", Offset = "0x37D0B0", VA = "0x37D0B0")]
			public VTable()
			{
			}
		}

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private VTable m_VTable;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private IntPtr m_pVTable;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private GCHandle m_pGCHandle;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private ServerResponded m_ServerResponded;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ServerFailedToRespond m_ServerFailedToRespond;

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x37CE4C", Offset = "0x37CE4C", VA = "0x37CE4C")]
		public ISteamMatchmakingPingResponse(ServerResponded onServerResponded, ServerFailedToRespond onServerFailedToRespond)
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x37D0E0", Offset = "0x37D0E0", VA = "0x37D0E0", Slot = "1")]
		~ISteamMatchmakingPingResponse()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x37D1F8", Offset = "0x37D1F8", VA = "0x37D1F8")]
		private void InternalOnServerResponded(IntPtr thisptr, gameserveritem_t server)
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x37D5C8", Offset = "0x37D5C8", VA = "0x37D5C8")]
		private void InternalOnServerFailedToRespond(IntPtr thisptr)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x37D7EC", Offset = "0x37D7EC", VA = "0x37D7EC")]
		public static explicit operator IntPtr(ISteamMatchmakingPingResponse that)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x20001D1")]
	public class ISteamMatchmakingPlayersResponse
	{
		[Token(Token = "0x20001D2")]
		public delegate void AddPlayerToList(string pchName, int nScore, float flTimePlayed);

		[Token(Token = "0x20001D3")]
		public delegate void PlayersFailedToRespond();

		[Token(Token = "0x20001D4")]
		public delegate void PlayersRefreshComplete();

		[Token(Token = "0x20001D5")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x2B484C", Offset = "0x2B484C")]
		public delegate void InternalAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed);

		[Token(Token = "0x20001D6")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x2B4860", Offset = "0x2B4860")]
		public delegate void InternalPlayersFailedToRespond(IntPtr thisptr);

		[Token(Token = "0x20001D7")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x2B4874", Offset = "0x2B4874")]
		public delegate void InternalPlayersRefreshComplete(IntPtr thisptr);

		[StructLayout(0)]
		[Token(Token = "0x20001D8")]
		private class VTable
		{
			[NonSerialized]
			[Token(Token = "0x4000821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public InternalAddPlayerToList m_VTAddPlayerToList;

			[NonSerialized]
			[Token(Token = "0x4000822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public InternalPlayersFailedToRespond m_VTPlayersFailedToRespond;

			[NonSerialized]
			[Token(Token = "0x4000823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InternalPlayersRefreshComplete m_VTPlayersRefreshComplete;

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x37E280", Offset = "0x37E280", VA = "0x37E280")]
			public VTable()
			{
			}
		}

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private VTable m_VTable;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private IntPtr m_pVTable;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private GCHandle m_pGCHandle;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private AddPlayerToList m_AddPlayerToList;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlayersFailedToRespond m_PlayersFailedToRespond;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private PlayersRefreshComplete m_PlayersRefreshComplete;

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x37DFC4", Offset = "0x37DFC4", VA = "0x37DFC4")]
		public ISteamMatchmakingPlayersResponse(AddPlayerToList onAddPlayerToList, PlayersFailedToRespond onPlayersFailedToRespond, PlayersRefreshComplete onPlayersRefreshComplete)
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x37E2C4", Offset = "0x37E2C4", VA = "0x37E2C4", Slot = "1")]
		~ISteamMatchmakingPlayersResponse()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x37E3DC", Offset = "0x37E3DC", VA = "0x37E3DC")]
		private void InternalOnAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed)
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x37E840", Offset = "0x37E840", VA = "0x37E840")]
		private void InternalOnPlayersFailedToRespond(IntPtr thisptr)
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x37EA64", Offset = "0x37EA64", VA = "0x37EA64")]
		private void InternalOnPlayersRefreshComplete(IntPtr thisptr)
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x37EC88", Offset = "0x37EC88", VA = "0x37EC88")]
		public static explicit operator IntPtr(ISteamMatchmakingPlayersResponse that)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x20001D9")]
	public class ISteamMatchmakingRulesResponse
	{
		[Token(Token = "0x20001DA")]
		public delegate void RulesResponded(string pchRule, string pchValue);

		[Token(Token = "0x20001DB")]
		public delegate void RulesFailedToRespond();

		[Token(Token = "0x20001DC")]
		public delegate void RulesRefreshComplete();

		[Token(Token = "0x20001DD")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x2B4888", Offset = "0x2B4888")]
		public delegate void InternalRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue);

		[Token(Token = "0x20001DE")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x2B489C", Offset = "0x2B489C")]
		public delegate void InternalRulesFailedToRespond(IntPtr thisptr);

		[Token(Token = "0x20001DF")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x2B48B0", Offset = "0x2B48B0")]
		public delegate void InternalRulesRefreshComplete(IntPtr thisptr);

		[StructLayout(0)]
		[Token(Token = "0x20001E0")]
		private class VTable
		{
			[NonSerialized]
			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public InternalRulesResponded m_VTRulesResponded;

			[NonSerialized]
			[Token(Token = "0x400082B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public InternalRulesFailedToRespond m_VTRulesFailedToRespond;

			[NonSerialized]
			[Token(Token = "0x400082C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InternalRulesRefreshComplete m_VTRulesRefreshComplete;

			[Token(Token = "0x6000817")]
			[Address(RVA = "0x37FB38", Offset = "0x37FB38", VA = "0x37FB38")]
			public VTable()
			{
			}
		}

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private VTable m_VTable;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private IntPtr m_pVTable;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private GCHandle m_pGCHandle;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private RulesResponded m_RulesResponded;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RulesFailedToRespond m_RulesFailedToRespond;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private RulesRefreshComplete m_RulesRefreshComplete;

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x37F87C", Offset = "0x37F87C", VA = "0x37F87C")]
		public ISteamMatchmakingRulesResponse(RulesResponded onRulesResponded, RulesFailedToRespond onRulesFailedToRespond, RulesRefreshComplete onRulesRefreshComplete)
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x37FB7C", Offset = "0x37FB7C", VA = "0x37FB7C", Slot = "1")]
		~ISteamMatchmakingRulesResponse()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x37FC94", Offset = "0x37FC94", VA = "0x37FC94")]
		private void InternalOnRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue)
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x3800A8", Offset = "0x3800A8", VA = "0x3800A8")]
		private void InternalOnRulesFailedToRespond(IntPtr thisptr)
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x3802CC", Offset = "0x3802CC", VA = "0x3802CC")]
		private void InternalOnRulesRefreshComplete(IntPtr thisptr)
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x3804F0", Offset = "0x3804F0", VA = "0x3804F0")]
		public static explicit operator IntPtr(ISteamMatchmakingRulesResponse that)
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x20001E1")]
	public static class Packsize
	{
		[Token(Token = "0x20001E2")]
		private struct ValvePackingSentinel_t
		{
			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private uint m_u32;

			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private ulong m_u64;

			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private ushort m_u16;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private double m_d;
		}

		[Token(Token = "0x400082D")]
		public const int value = 4;

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xE386C0", Offset = "0xE386C0", VA = "0xE386C0")]
		public static bool Test()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001E3")]
	public static class Version
	{
		[Token(Token = "0x4000832")]
		public const string SteamworksNETVersion = "11.0.0";

		[Token(Token = "0x4000833")]
		public const string SteamworksSDKVersion = "1.41";

		[Token(Token = "0x4000834")]
		public const string SteamAPIDLLVersion = "01.00.00.01";

		[Token(Token = "0x4000835")]
		public const int SteamAPIDLLSize = 225056;

		[Token(Token = "0x4000836")]
		public const int SteamAPI64DLLSize = 249120;
	}
	[Token(Token = "0x20001E4")]
	public static class SteamAPI
	{
		[Token(Token = "0x6000819")]
		[Address(RVA = "0xE3A554", Offset = "0xE3A554", VA = "0xE3A554")]
		public static bool Init()
		{
			return default(bool);
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xE3A598", Offset = "0xE3A598", VA = "0xE3A598")]
		public static void Shutdown()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xE3A5BC", Offset = "0xE3A5BC", VA = "0xE3A5BC")]
		public static bool RestartAppIfNecessary(AppId_t unOwnAppID)
		{
			return default(bool);
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xE3A5E8", Offset = "0xE3A5E8", VA = "0xE3A5E8")]
		public static void ReleaseCurrentThreadMemory()
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xE3A60C", Offset = "0xE3A60C", VA = "0xE3A60C")]
		public static void RunCallbacks()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xE3A630", Offset = "0xE3A630", VA = "0xE3A630")]
		public static bool IsSteamRunning()
		{
			return default(bool);
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xE3A654", Offset = "0xE3A654", VA = "0xE3A654")]
		public static HSteamUser GetHSteamUserCurrent()
		{
			return default(HSteamUser);
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xE3A688", Offset = "0xE3A688", VA = "0xE3A688")]
		public static HSteamPipe GetHSteamPipe()
		{
			return default(HSteamPipe);
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xE3A6BC", Offset = "0xE3A6BC", VA = "0xE3A6BC")]
		public static HSteamUser GetHSteamUser()
		{
			return default(HSteamUser);
		}
	}
	[Token(Token = "0x20001E5")]
	public static class GameServer
	{
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x378D90", Offset = "0x378D90", VA = "0x378D90")]
		public static bool Init(uint unIP, ushort usSteamPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString)
		{
			return default(bool);
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x378F24", Offset = "0x378F24", VA = "0x378F24")]
		public static void Shutdown()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x37906C", Offset = "0x37906C", VA = "0x37906C")]
		public static void RunCallbacks()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x3791B4", Offset = "0x3791B4", VA = "0x3791B4")]
		public static void ReleaseCurrentThreadMemory()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x3792FC", Offset = "0x3792FC", VA = "0x3792FC")]
		public static bool BSecure()
		{
			return default(bool);
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x379450", Offset = "0x379450", VA = "0x379450")]
		public static CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x377A9C", Offset = "0x377A9C", VA = "0x377A9C")]
		public static HSteamPipe GetHSteamPipe()
		{
			return default(HSteamPipe);
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x377A04", Offset = "0x377A04", VA = "0x377A04")]
		public static HSteamUser GetHSteamUser()
		{
			return default(HSteamUser);
		}
	}
	[Token(Token = "0x20001E6")]
	public static class SteamEncryptedAppTicket
	{
		[Token(Token = "0x600082A")]
		[Address(RVA = "0xE3F188", Offset = "0xE3F188", VA = "0xE3F188")]
		public static bool BDecryptTicket(byte[] rgubTicketEncrypted, uint cubTicketEncrypted, byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, byte[] rgubKey, int cubKey)
		{
			return default(bool);
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xE3F1D8", Offset = "0xE3F1D8", VA = "0xE3F1D8")]
		public static bool BIsTicketForApp(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID)
		{
			return default(bool);
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xE3F220", Offset = "0xE3F220", VA = "0xE3F220")]
		public static uint GetTicketIssueTime(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			return default(uint);
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xE3F254", Offset = "0xE3F254", VA = "0xE3F254")]
		public static void GetTicketSteamID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID)
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xE3F29C", Offset = "0xE3F29C", VA = "0xE3F29C")]
		public static uint GetTicketAppID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			return default(uint);
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xE3F2D0", Offset = "0xE3F2D0", VA = "0xE3F2D0")]
		public static bool BUserOwnsAppInTicket(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xE3F318", Offset = "0xE3F318", VA = "0xE3F318")]
		public static bool BUserIsVacBanned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			return default(bool);
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xE3F34C", Offset = "0xE3F34C", VA = "0xE3F34C")]
		public static byte[] GetUserVariableData(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData)
		{
			return null;
		}
	}
	[Token(Token = "0x20001E7")]
	internal static class CSteamAPIContext
	{
		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IntPtr m_pSteamClient;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static IntPtr m_pSteamUser;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static IntPtr m_pSteamFriends;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static IntPtr m_pSteamUtils;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static IntPtr m_pSteamMatchmaking;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static IntPtr m_pSteamUserStats;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static IntPtr m_pSteamApps;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static IntPtr m_pSteamMatchmakingServers;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static IntPtr m_pSteamNetworking;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static IntPtr m_pSteamRemoteStorage;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static IntPtr m_pSteamScreenshots;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static IntPtr m_pSteamHTTP;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static IntPtr m_pSteamUnifiedMessages;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private static IntPtr m_pController;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static IntPtr m_pSteamUGC;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private static IntPtr m_pSteamAppList;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static IntPtr m_pSteamMusic;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private static IntPtr m_pSteamMusicRemote;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static IntPtr m_pSteamHTMLSurface;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private static IntPtr m_pSteamInventory;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static IntPtr m_pSteamVideo;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private static IntPtr m_pSteamParentalSettings;

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x37647C", Offset = "0x37647C", VA = "0x37647C")]
		internal static void Clear()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x3765EC", Offset = "0x3765EC", VA = "0x3765EC")]
		internal static bool Init()
		{
			return default(bool);
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x376FD0", Offset = "0x376FD0", VA = "0x376FD0")]
		internal static IntPtr GetSteamClient()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x377034", Offset = "0x377034", VA = "0x377034")]
		internal static IntPtr GetSteamUser()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x377098", Offset = "0x377098", VA = "0x377098")]
		internal static IntPtr GetSteamFriends()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x3770FC", Offset = "0x3770FC", VA = "0x3770FC")]
		internal static IntPtr GetSteamUtils()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x377160", Offset = "0x377160", VA = "0x377160")]
		internal static IntPtr GetSteamMatchmaking()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x3771C4", Offset = "0x3771C4", VA = "0x3771C4")]
		internal static IntPtr GetSteamUserStats()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x377228", Offset = "0x377228", VA = "0x377228")]
		internal static IntPtr GetSteamApps()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x37728C", Offset = "0x37728C", VA = "0x37728C")]
		internal static IntPtr GetSteamMatchmakingServers()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x3772F0", Offset = "0x3772F0", VA = "0x3772F0")]
		internal static IntPtr GetSteamNetworking()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x377354", Offset = "0x377354", VA = "0x377354")]
		internal static IntPtr GetSteamRemoteStorage()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x3773B8", Offset = "0x3773B8", VA = "0x3773B8")]
		internal static IntPtr GetSteamScreenshots()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x37741C", Offset = "0x37741C", VA = "0x37741C")]
		internal static IntPtr GetSteamHTTP()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x377480", Offset = "0x377480", VA = "0x377480")]
		internal static IntPtr GetSteamUnifiedMessages()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x3774E4", Offset = "0x3774E4", VA = "0x3774E4")]
		internal static IntPtr GetSteamController()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x377548", Offset = "0x377548", VA = "0x377548")]
		internal static IntPtr GetSteamUGC()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x3775AC", Offset = "0x3775AC", VA = "0x3775AC")]
		internal static IntPtr GetSteamAppList()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x377610", Offset = "0x377610", VA = "0x377610")]
		internal static IntPtr GetSteamMusic()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x377674", Offset = "0x377674", VA = "0x377674")]
		internal static IntPtr GetSteamMusicRemote()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x3776D8", Offset = "0x3776D8", VA = "0x3776D8")]
		internal static IntPtr GetSteamHTMLSurface()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x37773C", Offset = "0x37773C", VA = "0x37773C")]
		internal static IntPtr GetSteamInventory()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x3777A0", Offset = "0x3777A0", VA = "0x3777A0")]
		internal static IntPtr GetSteamVideo()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x377804", Offset = "0x377804", VA = "0x377804")]
		internal static IntPtr GetSteamParentalSettings()
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x20001E8")]
	internal static class CSteamGameServerAPIContext
	{
		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IntPtr m_pSteamClient;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static IntPtr m_pSteamGameServer;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static IntPtr m_pSteamUtils;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static IntPtr m_pSteamNetworking;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static IntPtr m_pSteamGameServerStats;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static IntPtr m_pSteamHTTP;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static IntPtr m_pSteamInventory;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static IntPtr m_pSteamUGC;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static IntPtr m_pSteamApps;

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x377868", Offset = "0x377868", VA = "0x377868")]
		internal static void Clear()
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x377930", Offset = "0x377930", VA = "0x377930")]
		internal static bool Init()
		{
			return default(bool);
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x377B34", Offset = "0x377B34", VA = "0x377B34")]
		internal static IntPtr GetSteamClient()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x377B98", Offset = "0x377B98", VA = "0x377B98")]
		internal static IntPtr GetSteamGameServer()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x377BFC", Offset = "0x377BFC", VA = "0x377BFC")]
		internal static IntPtr GetSteamUtils()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x377C60", Offset = "0x377C60", VA = "0x377C60")]
		internal static IntPtr GetSteamNetworking()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x377CC4", Offset = "0x377CC4", VA = "0x377CC4")]
		internal static IntPtr GetSteamGameServerStats()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x377D28", Offset = "0x377D28", VA = "0x377D28")]
		internal static IntPtr GetSteamHTTP()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x377D8C", Offset = "0x377D8C", VA = "0x377D8C")]
		internal static IntPtr GetSteamInventory()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x377DF0", Offset = "0x377DF0", VA = "0x377DF0")]
		internal static IntPtr GetSteamUGC()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x377E54", Offset = "0x377E54", VA = "0x377E54")]
		internal static IntPtr GetSteamApps()
		{
			return default(IntPtr);
		}
	}
	[Serializable]
	[StructLayout(0)]
	[Token(Token = "0x20001E9")]
	public class gameserveritem_t
	{
		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public servernetadr_t m_NetAdr;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int m_nPing;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool m_bHadSuccessfulResponse;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public bool m_bDoNotRefresh;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private byte[] m_szGameDir;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private byte[] m_szMap;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private byte[] m_szGameDescription;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public uint m_nAppID;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int m_nPlayers;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int m_nMaxPlayers;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int m_nBotPlayers;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool m_bPassword;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		public bool m_bSecure;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public uint m_ulTimeLastPlayed;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int m_nServerVersion;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private byte[] m_szServerName;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private byte[] m_szGameTags;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CSteamID m_steamID;

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x379C94", Offset = "0x379C94", VA = "0x379C94")]
		public gameserveritem_t()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x379C9C", Offset = "0x379C9C", VA = "0x379C9C")]
		public string GetGameDir()
		{
			return null;
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x379D84", Offset = "0x379D84", VA = "0x379D84")]
		public void SetGameDir(string dir)
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x379EA8", Offset = "0x379EA8", VA = "0x379EA8")]
		public string GetMap()
		{
			return null;
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x379F90", Offset = "0x379F90", VA = "0x379F90")]
		public void SetMap(string map)
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x37A0B4", Offset = "0x37A0B4", VA = "0x37A0B4")]
		public string GetGameDescription()
		{
			return null;
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x37A19C", Offset = "0x37A19C", VA = "0x37A19C")]
		public void SetGameDescription(string desc)
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x37A2C0", Offset = "0x37A2C0", VA = "0x37A2C0")]
		public string GetServerName()
		{
			return null;
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x37A3F0", Offset = "0x37A3F0", VA = "0x37A3F0")]
		public void SetServerName(string name)
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x37A514", Offset = "0x37A514", VA = "0x37A514")]
		public string GetGameTags()
		{
			return null;
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x37A5FC", Offset = "0x37A5FC", VA = "0x37A5FC")]
		public void SetGameTags(string tags)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001EA")]
	public struct servernetadr_t
	{
		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort m_usConnectionPort;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private ushort m_usQueryPort;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private uint m_unIP;

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xE39D78", Offset = "0xE39D78", VA = "0xE39D78")]
		public void Init(uint ip, ushort usQueryPort, ushort usConnectionPort)
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xE39D88", Offset = "0xE39D88", VA = "0xE39D88")]
		public ushort GetQueryPort()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xE39D90", Offset = "0xE39D90", VA = "0xE39D90")]
		public void SetQueryPort(ushort usPort)
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xE39D98", Offset = "0xE39D98", VA = "0xE39D98")]
		public ushort GetConnectionPort()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xE39DA0", Offset = "0xE39DA0", VA = "0xE39DA0")]
		public void SetConnectionPort(ushort usPort)
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xE39DA8", Offset = "0xE39DA8", VA = "0xE39DA8")]
		public uint GetIP()
		{
			return default(uint);
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xE39DB0", Offset = "0xE39DB0", VA = "0xE39DB0")]
		public void SetIP(uint unIP)
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xE3A0D4", Offset = "0xE3A0D4", VA = "0xE3A0D4")]
		public string GetConnectionAddressString()
		{
			return null;
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xE3A0E0", Offset = "0xE3A0E0", VA = "0xE3A0E0")]
		public string GetQueryAddressString()
		{
			return null;
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0xE39DC4", Offset = "0xE39DC4", VA = "0xE39DC4")]
		public static string ToString(uint unIP, ushort usPort)
		{
			return null;
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0xE3A0EC", Offset = "0xE3A0EC", VA = "0xE3A0EC")]
		public static bool operator <(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xE3A118", Offset = "0xE3A118", VA = "0xE3A118")]
		public static bool operator >(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xE3A230", Offset = "0xE3A230", VA = "0xE3A230", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xE3A278", Offset = "0xE3A278", VA = "0xE3A278", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xE3A200", Offset = "0xE3A200", VA = "0xE3A200")]
		public static bool operator ==(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xE3A280", Offset = "0xE3A280", VA = "0xE3A280")]
		public static bool operator !=(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xE3A2B0", Offset = "0xE3A2B0", VA = "0xE3A2B0")]
		public bool Equals(servernetadr_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xE3A334", Offset = "0xE3A334", VA = "0xE3A334")]
		public int CompareTo(servernetadr_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001EB")]
	public struct HSteamPipe : IEquatable<HSteamPipe>, IComparable<HSteamPipe>
	{
		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_HSteamPipe;

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x37B394", Offset = "0x37B394", VA = "0x37B394")]
		public HSteamPipe(int value)
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x37B39C", Offset = "0x37B39C", VA = "0x37B39C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x37B43C", Offset = "0x37B43C", VA = "0x37B43C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x37B444", Offset = "0x37B444", VA = "0x37B444", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x376F90", Offset = "0x376F90", VA = "0x376F90")]
		public static bool operator ==(HSteamPipe x, HSteamPipe y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x37B450", Offset = "0x37B450", VA = "0x37B450")]
		public static bool operator !=(HSteamPipe x, HSteamPipe y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x376F88", Offset = "0x376F88", VA = "0x376F88")]
		public static explicit operator HSteamPipe(int value)
		{
			return default(HSteamPipe);
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x37B460", Offset = "0x37B460", VA = "0x37B460")]
		public static explicit operator int(HSteamPipe that)
		{
			return default(int);
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x37B468", Offset = "0x37B468", VA = "0x37B468", Slot = "4")]
		public bool Equals(HSteamPipe other)
		{
			return default(bool);
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x37B47C", Offset = "0x37B47C", VA = "0x37B47C", Slot = "5")]
		public int CompareTo(HSteamPipe other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001EC")]
	public struct HSteamUser : IEquatable<HSteamUser>, IComparable<HSteamUser>
	{
		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_HSteamUser;

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x37B488", Offset = "0x37B488", VA = "0x37B488")]
		public HSteamUser(int value)
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x37B490", Offset = "0x37B490", VA = "0x37B490", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x37B540", Offset = "0x37B540", VA = "0x37B540", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x37B548", Offset = "0x37B548", VA = "0x37B548", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x37B530", Offset = "0x37B530", VA = "0x37B530")]
		public static bool operator ==(HSteamUser x, HSteamUser y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x37B554", Offset = "0x37B554", VA = "0x37B554")]
		public static bool operator !=(HSteamUser x, HSteamUser y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x379734", Offset = "0x379734", VA = "0x379734")]
		public static explicit operator HSteamUser(int value)
		{
			return default(HSteamUser);
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x37B564", Offset = "0x37B564", VA = "0x37B564")]
		public static explicit operator int(HSteamUser that)
		{
			return default(int);
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x37B56C", Offset = "0x37B56C", VA = "0x37B56C", Slot = "4")]
		public bool Equals(HSteamUser other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x37B580", Offset = "0x37B580", VA = "0x37B580", Slot = "5")]
		public int CompareTo(HSteamUser other)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001ED")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x2B48C4", Offset = "0x2B48C4")]
	public delegate void SteamAPI_CheckCallbackRegistered_t(int iCallbackNum);
	[Token(Token = "0x20001EE")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x2B48D8", Offset = "0x2B48D8")]
	public delegate void SteamAPIWarningMessageHook_t(int nSeverity, StringBuilder pchDebugText);
	[Serializable]
	[Token(Token = "0x20001EF")]
	public struct CGameID : IEquatable<CGameID>, IComparable<CGameID>
	{
		[Token(Token = "0x20001F0")]
		public enum EGameIDType
		{
			[Token(Token = "0x400086F")]
			k_EGameIDTypeApp,
			[Token(Token = "0x4000870")]
			k_EGameIDTypeGameMod,
			[Token(Token = "0x4000871")]
			k_EGameIDTypeShortcut,
			[Token(Token = "0x4000872")]
			k_EGameIDTypeP2P
		}

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_GameID;

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x375794", Offset = "0x375794", VA = "0x375794")]
		public CGameID(ulong GameID)
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x37582C", Offset = "0x37582C", VA = "0x37582C")]
		public CGameID(AppId_t nAppID)
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x37583C", Offset = "0x37583C", VA = "0x37583C")]
		public CGameID(AppId_t nAppID, uint nModID)
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x375874", Offset = "0x375874", VA = "0x375874")]
		public bool IsSteamApp()
		{
			return default(bool);
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x375888", Offset = "0x375888", VA = "0x375888")]
		public bool IsMod()
		{
			return default(bool);
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x3758A0", Offset = "0x3758A0", VA = "0x3758A0")]
		public bool IsShortcut()
		{
			return default(bool);
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x3758B8", Offset = "0x3758B8", VA = "0x3758B8")]
		public bool IsP2PFile()
		{
			return default(bool);
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x3758D0", Offset = "0x3758D0", VA = "0x3758D0")]
		public AppId_t AppID()
		{
			return default(AppId_t);
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x3758DC", Offset = "0x3758DC", VA = "0x3758DC")]
		public EGameIDType Type()
		{
			return default(EGameIDType);
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x3758E4", Offset = "0x3758E4", VA = "0x3758E4")]
		public uint ModID()
		{
			return default(uint);
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x375A88", Offset = "0x375A88", VA = "0x375A88")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x375A90", Offset = "0x375A90", VA = "0x375A90")]
		public void Reset()
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x375AA0", Offset = "0x375AA0", VA = "0x375AA0")]
		public void Set(ulong GameID)
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x375AB0", Offset = "0x375AB0", VA = "0x375AB0")]
		private void SetAppID(AppId_t other)
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x375AB8", Offset = "0x375AB8", VA = "0x375AB8")]
		private void SetType(EGameIDType other)
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x375AC0", Offset = "0x375AC0", VA = "0x375AC0")]
		private void SetModID(uint other)
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x375AC8", Offset = "0x375AC8", VA = "0x375AC8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x375B90", Offset = "0x375B90", VA = "0x375B90", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x375B98", Offset = "0x375B98", VA = "0x375B98", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x375B70", Offset = "0x375B70", VA = "0x375B70")]
		public static bool operator ==(CGameID x, CGameID y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x375BA4", Offset = "0x375BA4", VA = "0x375BA4")]
		public static bool operator !=(CGameID x, CGameID y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x375BC0", Offset = "0x375BC0", VA = "0x375BC0")]
		public static explicit operator CGameID(ulong value)
		{
			return default(CGameID);
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x375BD0", Offset = "0x375BD0", VA = "0x375BD0")]
		public static explicit operator ulong(CGameID that)
		{
			return default(ulong);
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x375BDC", Offset = "0x375BDC", VA = "0x375BDC", Slot = "4")]
		public bool Equals(CGameID other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x375BF8", Offset = "0x375BF8", VA = "0x375BF8", Slot = "5")]
		public int CompareTo(CGameID other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001F1")]
	public struct CSteamID : IEquatable<CSteamID>, IComparable<CSteamID>
	{
		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly CSteamID Nil;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly CSteamID OutofDateGS;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly CSteamID LanModeGS;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly CSteamID NotInitYetGS;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly CSteamID NonSteamGS;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamID;

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x377EB8", Offset = "0x377EB8", VA = "0x377EB8")]
		public CSteamID(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x377EE0", Offset = "0x377EE0", VA = "0x377EE0")]
		public CSteamID(AccountID_t unAccountID, uint unAccountInstance, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x377F04", Offset = "0x377F04", VA = "0x377F04")]
		public CSteamID(ulong ulSteamID)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x377F10", Offset = "0x377F10", VA = "0x377F10")]
		public void Set(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x377F48", Offset = "0x377F48", VA = "0x377F48")]
		public void InstancedSet(AccountID_t unAccountID, uint unInstance, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x377F6C", Offset = "0x377F6C", VA = "0x377F6C")]
		public void Clear()
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x377F7C", Offset = "0x377F7C", VA = "0x377F7C")]
		public void CreateBlankAnonLogon(EUniverse eUniverse)
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x377F94", Offset = "0x377F94", VA = "0x377F94")]
		public void CreateBlankAnonUserLogon(EUniverse eUniverse)
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x377FAC", Offset = "0x377FAC", VA = "0x377FAC")]
		public bool BBlankAnonAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x377FEC", Offset = "0x377FEC", VA = "0x377FEC")]
		public bool BGameServerAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x378008", Offset = "0x378008", VA = "0x378008")]
		public bool BPersistentGameServerAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x378020", Offset = "0x378020", VA = "0x378020")]
		public bool BAnonGameServerAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x378038", Offset = "0x378038", VA = "0x378038")]
		public bool BContentServerAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x378050", Offset = "0x378050", VA = "0x378050")]
		public bool BClanAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x378068", Offset = "0x378068", VA = "0x378068")]
		public bool BChatAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x378080", Offset = "0x378080", VA = "0x378080")]
		public bool IsLobby()
		{
			return default(bool);
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x378098", Offset = "0x378098", VA = "0x378098")]
		public bool BIndividualAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x3780B8", Offset = "0x3780B8", VA = "0x3780B8")]
		public bool BAnonAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x3780E0", Offset = "0x3780E0", VA = "0x3780E0")]
		public bool BAnonUserAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x3780F8", Offset = "0x3780F8", VA = "0x3780F8")]
		public bool BConsoleUserAccount()
		{
			return default(bool);
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x378110", Offset = "0x378110", VA = "0x378110")]
		public void SetAccountID(AccountID_t other)
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x378118", Offset = "0x378118", VA = "0x378118")]
		public void SetAccountInstance(uint other)
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x378130", Offset = "0x378130", VA = "0x378130")]
		public void SetEAccountType(EAccountType other)
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x378148", Offset = "0x378148", VA = "0x378148")]
		public void SetEUniverse(EUniverse other)
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x378150", Offset = "0x378150", VA = "0x378150")]
		public void ClearIndividualInstance()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x378178", Offset = "0x378178", VA = "0x378178")]
		public bool HasNoIndividualInstance()
		{
			return default(bool);
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x3781B0", Offset = "0x3781B0", VA = "0x3781B0")]
		public AccountID_t GetAccountID()
		{
			return default(AccountID_t);
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x3781B8", Offset = "0x3781B8", VA = "0x3781B8")]
		public uint GetUnAccountInstance()
		{
			return default(uint);
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x3781C4", Offset = "0x3781C4", VA = "0x3781C4")]
		public EAccountType GetEAccountType()
		{
			return default(EAccountType);
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x3781D0", Offset = "0x3781D0", VA = "0x3781D0")]
		public EUniverse GetEUniverse()
		{
			return default(EUniverse);
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x378258", Offset = "0x378258", VA = "0x378258")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x378260", Offset = "0x378260", VA = "0x378260", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x3783B4", Offset = "0x3783B4", VA = "0x3783B4", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x3783BC", Offset = "0x3783BC", VA = "0x3783BC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x378398", Offset = "0x378398", VA = "0x378398")]
		public static bool operator ==(CSteamID x, CSteamID y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x3783C8", Offset = "0x3783C8", VA = "0x3783C8")]
		public static bool operator !=(CSteamID x, CSteamID y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x37845C", Offset = "0x37845C", VA = "0x37845C")]
		public static explicit operator CSteamID(ulong value)
		{
			return default(CSteamID);
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x37846C", Offset = "0x37846C", VA = "0x37846C")]
		public static explicit operator ulong(CSteamID that)
		{
			return default(ulong);
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x378478", Offset = "0x378478", VA = "0x378478", Slot = "4")]
		public bool Equals(CSteamID other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x378498", Offset = "0x378498", VA = "0x378498", Slot = "5")]
		public int CompareTo(CSteamID other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001F2")]
	public struct HAuthTicket : IEquatable<HAuthTicket>, IComparable<HAuthTicket>
	{
		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HAuthTicket Invalid;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_HAuthTicket;

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x37A9C0", Offset = "0x37A9C0", VA = "0x37A9C0")]
		public HAuthTicket(uint value)
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x37A9C8", Offset = "0x37A9C8", VA = "0x37A9C8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x37AB00", Offset = "0x37AB00", VA = "0x37AB00", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x37AB08", Offset = "0x37AB08", VA = "0x37AB08", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x37AAF0", Offset = "0x37AAF0", VA = "0x37AAF0")]
		public static bool operator ==(HAuthTicket x, HAuthTicket y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x37AB14", Offset = "0x37AB14", VA = "0x37AB14")]
		public static bool operator !=(HAuthTicket x, HAuthTicket y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x37AB9C", Offset = "0x37AB9C", VA = "0x37AB9C")]
		public static explicit operator HAuthTicket(uint value)
		{
			return default(HAuthTicket);
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x37ABA4", Offset = "0x37ABA4", VA = "0x37ABA4")]
		public static explicit operator uint(HAuthTicket that)
		{
			return default(uint);
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x37ABAC", Offset = "0x37ABAC", VA = "0x37ABAC", Slot = "4")]
		public bool Equals(HAuthTicket other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x37ABC0", Offset = "0x37ABC0", VA = "0x37ABC0", Slot = "5")]
		public int CompareTo(HAuthTicket other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001F3")]
	public struct ControllerActionSetHandle_t : IEquatable<ControllerActionSetHandle_t>, IComparable<ControllerActionSetHandle_t>
	{
		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ControllerActionSetHandle;

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x375EEC", Offset = "0x375EEC", VA = "0x375EEC")]
		public ControllerActionSetHandle_t(ulong value)
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x375EFC", Offset = "0x375EFC", VA = "0x375EFC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x375FC4", Offset = "0x375FC4", VA = "0x375FC4", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x375FCC", Offset = "0x375FCC", VA = "0x375FCC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x375FA4", Offset = "0x375FA4", VA = "0x375FA4")]
		public static bool operator ==(ControllerActionSetHandle_t x, ControllerActionSetHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x375FD8", Offset = "0x375FD8", VA = "0x375FD8")]
		public static bool operator !=(ControllerActionSetHandle_t x, ControllerActionSetHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x375FF4", Offset = "0x375FF4", VA = "0x375FF4")]
		public static explicit operator ControllerActionSetHandle_t(ulong value)
		{
			return default(ControllerActionSetHandle_t);
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x376004", Offset = "0x376004", VA = "0x376004")]
		public static explicit operator ulong(ControllerActionSetHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x376010", Offset = "0x376010", VA = "0x376010", Slot = "4")]
		public bool Equals(ControllerActionSetHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x37602C", Offset = "0x37602C", VA = "0x37602C", Slot = "5")]
		public int CompareTo(ControllerActionSetHandle_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001F4")]
	public struct ControllerAnalogActionHandle_t : IEquatable<ControllerAnalogActionHandle_t>, IComparable<ControllerAnalogActionHandle_t>
	{
		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ControllerAnalogActionHandle;

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x376050", Offset = "0x376050", VA = "0x376050")]
		public ControllerAnalogActionHandle_t(ulong value)
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x376060", Offset = "0x376060", VA = "0x376060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x376128", Offset = "0x376128", VA = "0x376128", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x376130", Offset = "0x376130", VA = "0x376130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x376108", Offset = "0x376108", VA = "0x376108")]
		public static bool operator ==(ControllerAnalogActionHandle_t x, ControllerAnalogActionHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x37613C", Offset = "0x37613C", VA = "0x37613C")]
		public static bool operator !=(ControllerAnalogActionHandle_t x, ControllerAnalogActionHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x376158", Offset = "0x376158", VA = "0x376158")]
		public static explicit operator ControllerAnalogActionHandle_t(ulong value)
		{
			return default(ControllerAnalogActionHandle_t);
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x376168", Offset = "0x376168", VA = "0x376168")]
		public static explicit operator ulong(ControllerAnalogActionHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x376174", Offset = "0x376174", VA = "0x376174", Slot = "4")]
		public bool Equals(ControllerAnalogActionHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x376190", Offset = "0x376190", VA = "0x376190", Slot = "5")]
		public int CompareTo(ControllerAnalogActionHandle_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001F5")]
	public struct ControllerDigitalActionHandle_t : IEquatable<ControllerDigitalActionHandle_t>, IComparable<ControllerDigitalActionHandle_t>
	{
		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ControllerDigitalActionHandle;

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x3761B4", Offset = "0x3761B4", VA = "0x3761B4")]
		public ControllerDigitalActionHandle_t(ulong value)
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x3761C4", Offset = "0x3761C4", VA = "0x3761C4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x37628C", Offset = "0x37628C", VA = "0x37628C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x376294", Offset = "0x376294", VA = "0x376294", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x37626C", Offset = "0x37626C", VA = "0x37626C")]
		public static bool operator ==(ControllerDigitalActionHandle_t x, ControllerDigitalActionHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x3762A0", Offset = "0x3762A0", VA = "0x3762A0")]
		public static bool operator !=(ControllerDigitalActionHandle_t x, ControllerDigitalActionHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x3762BC", Offset = "0x3762BC", VA = "0x3762BC")]
		public static explicit operator ControllerDigitalActionHandle_t(ulong value)
		{
			return default(ControllerDigitalActionHandle_t);
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x3762CC", Offset = "0x3762CC", VA = "0x3762CC")]
		public static explicit operator ulong(ControllerDigitalActionHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x3762D8", Offset = "0x3762D8", VA = "0x3762D8", Slot = "4")]
		public bool Equals(ControllerDigitalActionHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x3762F4", Offset = "0x3762F4", VA = "0x3762F4", Slot = "5")]
		public int CompareTo(ControllerDigitalActionHandle_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001F6")]
	public struct ControllerHandle_t : IEquatable<ControllerHandle_t>, IComparable<ControllerHandle_t>
	{
		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ControllerHandle;

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x376318", Offset = "0x376318", VA = "0x376318")]
		public ControllerHandle_t(ulong value)
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x376328", Offset = "0x376328", VA = "0x376328", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x3763F0", Offset = "0x3763F0", VA = "0x3763F0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x3763F8", Offset = "0x3763F8", VA = "0x3763F8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x3763D0", Offset = "0x3763D0", VA = "0x3763D0")]
		public static bool operator ==(ControllerHandle_t x, ControllerHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x376404", Offset = "0x376404", VA = "0x376404")]
		public static bool operator !=(ControllerHandle_t x, ControllerHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x376420", Offset = "0x376420", VA = "0x376420")]
		public static explicit operator ControllerHandle_t(ulong value)
		{
			return default(ControllerHandle_t);
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x376430", Offset = "0x376430", VA = "0x376430")]
		public static explicit operator ulong(ControllerHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x37643C", Offset = "0x37643C", VA = "0x37643C", Slot = "4")]
		public bool Equals(ControllerHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x376458", Offset = "0x376458", VA = "0x376458", Slot = "5")]
		public int CompareTo(ControllerHandle_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001F7")]
	public struct FriendsGroupID_t : IEquatable<FriendsGroupID_t>, IComparable<FriendsGroupID_t>
	{
		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly FriendsGroupID_t Invalid;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short m_FriendsGroupID;

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x378AC8", Offset = "0x378AC8", VA = "0x378AC8")]
		public FriendsGroupID_t(short value)
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x378AD0", Offset = "0x378AD0", VA = "0x378AD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x378C10", Offset = "0x378C10", VA = "0x378C10", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x378C18", Offset = "0x378C18", VA = "0x378C18", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x378BF8", Offset = "0x378BF8", VA = "0x378BF8")]
		public static bool operator ==(FriendsGroupID_t x, FriendsGroupID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x378C24", Offset = "0x378C24", VA = "0x378C24")]
		public static bool operator !=(FriendsGroupID_t x, FriendsGroupID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x378CB4", Offset = "0x378CB4", VA = "0x378CB4")]
		public static explicit operator FriendsGroupID_t(short value)
		{
			return default(FriendsGroupID_t);
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x378CBC", Offset = "0x378CBC", VA = "0x378CBC")]
		public static explicit operator short(FriendsGroupID_t that)
		{
			return default(short);
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x378CC4", Offset = "0x378CC4", VA = "0x378CC4", Slot = "4")]
		public bool Equals(FriendsGroupID_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x378CDC", Offset = "0x378CDC", VA = "0x378CDC", Slot = "5")]
		public int CompareTo(FriendsGroupID_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001F8")]
	public struct HHTMLBrowser : IEquatable<HHTMLBrowser>, IComparable<HHTMLBrowser>
	{
		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HHTMLBrowser Invalid;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_HHTMLBrowser;

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x37AC34", Offset = "0x37AC34", VA = "0x37AC34")]
		public HHTMLBrowser(uint value)
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x37AC3C", Offset = "0x37AC3C", VA = "0x37AC3C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x37AD74", Offset = "0x37AD74", VA = "0x37AD74", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x37AD7C", Offset = "0x37AD7C", VA = "0x37AD7C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x37AD64", Offset = "0x37AD64", VA = "0x37AD64")]
		public static bool operator ==(HHTMLBrowser x, HHTMLBrowser y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x37AD88", Offset = "0x37AD88", VA = "0x37AD88")]
		public static bool operator !=(HHTMLBrowser x, HHTMLBrowser y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x37AE10", Offset = "0x37AE10", VA = "0x37AE10")]
		public static explicit operator HHTMLBrowser(uint value)
		{
			return default(HHTMLBrowser);
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x37AE18", Offset = "0x37AE18", VA = "0x37AE18")]
		public static explicit operator uint(HHTMLBrowser that)
		{
			return default(uint);
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x37AE20", Offset = "0x37AE20", VA = "0x37AE20", Slot = "4")]
		public bool Equals(HHTMLBrowser other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x37AE34", Offset = "0x37AE34", VA = "0x37AE34", Slot = "5")]
		public int CompareTo(HHTMLBrowser other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001F9")]
	public struct HTTPCookieContainerHandle : IEquatable<HTTPCookieContainerHandle>, IComparable<HTTPCookieContainerHandle>
	{
		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HTTPCookieContainerHandle Invalid;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_HTTPCookieContainerHandle;

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x37BCC4", Offset = "0x37BCC4", VA = "0x37BCC4")]
		public HTTPCookieContainerHandle(uint value)
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x37BCCC", Offset = "0x37BCCC", VA = "0x37BCCC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x37BE04", Offset = "0x37BE04", VA = "0x37BE04", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x37BE0C", Offset = "0x37BE0C", VA = "0x37BE0C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x37BDF4", Offset = "0x37BDF4", VA = "0x37BDF4")]
		public static bool operator ==(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x37BE18", Offset = "0x37BE18", VA = "0x37BE18")]
		public static bool operator !=(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x37BEA0", Offset = "0x37BEA0", VA = "0x37BEA0")]
		public static explicit operator HTTPCookieContainerHandle(uint value)
		{
			return default(HTTPCookieContainerHandle);
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x37BEA8", Offset = "0x37BEA8", VA = "0x37BEA8")]
		public static explicit operator uint(HTTPCookieContainerHandle that)
		{
			return default(uint);
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x37BEB0", Offset = "0x37BEB0", VA = "0x37BEB0", Slot = "4")]
		public bool Equals(HTTPCookieContainerHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x37BEC4", Offset = "0x37BEC4", VA = "0x37BEC4", Slot = "5")]
		public int CompareTo(HTTPCookieContainerHandle other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001FA")]
	public struct HTTPRequestHandle : IEquatable<HTTPRequestHandle>, IComparable<HTTPRequestHandle>
	{
		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HTTPRequestHandle Invalid;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_HTTPRequestHandle;

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x37BF38", Offset = "0x37BF38", VA = "0x37BF38")]
		public HTTPRequestHandle(uint value)
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x37BF40", Offset = "0x37BF40", VA = "0x37BF40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x37C078", Offset = "0x37C078", VA = "0x37C078", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x37C080", Offset = "0x37C080", VA = "0x37C080", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x37C068", Offset = "0x37C068", VA = "0x37C068")]
		public static bool operator ==(HTTPRequestHandle x, HTTPRequestHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x37C08C", Offset = "0x37C08C", VA = "0x37C08C")]
		public static bool operator !=(HTTPRequestHandle x, HTTPRequestHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x37C114", Offset = "0x37C114", VA = "0x37C114")]
		public static explicit operator HTTPRequestHandle(uint value)
		{
			return default(HTTPRequestHandle);
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x37C11C", Offset = "0x37C11C", VA = "0x37C11C")]
		public static explicit operator uint(HTTPRequestHandle that)
		{
			return default(uint);
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x37C124", Offset = "0x37C124", VA = "0x37C124", Slot = "4")]
		public bool Equals(HTTPRequestHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x37C138", Offset = "0x37C138", VA = "0x37C138", Slot = "5")]
		public int CompareTo(HTTPRequestHandle other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001FB")]
	public struct SteamInventoryResult_t : IEquatable<SteamInventoryResult_t>, IComparable<SteamInventoryResult_t>
	{
		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SteamInventoryResult_t Invalid;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_SteamInventoryResult;

		[Token(Token = "0x600092F")]
		[Address(RVA = "0xE52C08", Offset = "0xE52C08", VA = "0xE52C08")]
		public SteamInventoryResult_t(int value)
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0xE52C10", Offset = "0xE52C10", VA = "0xE52C10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0xE52D48", Offset = "0xE52D48", VA = "0xE52D48", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0xE52D50", Offset = "0xE52D50", VA = "0xE52D50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0xE52D38", Offset = "0xE52D38", VA = "0xE52D38")]
		public static bool operator ==(SteamInventoryResult_t x, SteamInventoryResult_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0xE52D5C", Offset = "0xE52D5C", VA = "0xE52D5C")]
		public static bool operator !=(SteamInventoryResult_t x, SteamInventoryResult_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0xE52DE4", Offset = "0xE52DE4", VA = "0xE52DE4")]
		public static explicit operator SteamInventoryResult_t(int value)
		{
			return default(SteamInventoryResult_t);
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0xE52DEC", Offset = "0xE52DEC", VA = "0xE52DEC")]
		public static explicit operator int(SteamInventoryResult_t that)
		{
			return default(int);
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0xE52DF4", Offset = "0xE52DF4", VA = "0xE52DF4", Slot = "4")]
		public bool Equals(SteamInventoryResult_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0xE52E08", Offset = "0xE52E08", VA = "0xE52E08", Slot = "5")]
		public int CompareTo(SteamInventoryResult_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001FC")]
	public struct SteamItemDef_t : IEquatable<SteamItemDef_t>, IComparable<SteamItemDef_t>
	{
		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_SteamItemDef;

		[Token(Token = "0x600093A")]
		[Address(RVA = "0xE52E7C", Offset = "0xE52E7C", VA = "0xE52E7C")]
		public SteamItemDef_t(int value)
		{
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0xE52E84", Offset = "0xE52E84", VA = "0xE52E84", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0xE52F34", Offset = "0xE52F34", VA = "0xE52F34", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0xE52F3C", Offset = "0xE52F3C", VA = "0xE52F3C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0xE52F24", Offset = "0xE52F24", VA = "0xE52F24")]
		public static bool operator ==(SteamItemDef_t x, SteamItemDef_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0xE52F48", Offset = "0xE52F48", VA = "0xE52F48")]
		public static bool operator !=(SteamItemDef_t x, SteamItemDef_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0xE52F58", Offset = "0xE52F58", VA = "0xE52F58")]
		public static explicit operator SteamItemDef_t(int value)
		{
			return default(SteamItemDef_t);
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0xE52F60", Offset = "0xE52F60", VA = "0xE52F60")]
		public static explicit operator int(SteamItemDef_t that)
		{
			return default(int);
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0xE52F68", Offset = "0xE52F68", VA = "0xE52F68", Slot = "4")]
		public bool Equals(SteamItemDef_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0xE52F7C", Offset = "0xE52F7C", VA = "0xE52F7C", Slot = "5")]
		public int CompareTo(SteamItemDef_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001FD")]
	public struct SteamItemInstanceID_t : IEquatable<SteamItemInstanceID_t>, IComparable<SteamItemInstanceID_t>
	{
		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SteamItemInstanceID_t Invalid;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamItemInstanceID;

		[Token(Token = "0x6000944")]
		[Address(RVA = "0xE52F88", Offset = "0xE52F88", VA = "0xE52F88")]
		public SteamItemInstanceID_t(ulong value)
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0xE52F98", Offset = "0xE52F98", VA = "0xE52F98", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0xE530E8", Offset = "0xE530E8", VA = "0xE530E8", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0xE530F0", Offset = "0xE530F0", VA = "0xE530F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0xE530C8", Offset = "0xE530C8", VA = "0xE530C8")]
		public static bool operator ==(SteamItemInstanceID_t x, SteamItemInstanceID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0xE530FC", Offset = "0xE530FC", VA = "0xE530FC")]
		public static bool operator !=(SteamItemInstanceID_t x, SteamItemInstanceID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0xE53190", Offset = "0xE53190", VA = "0xE53190")]
		public static explicit operator SteamItemInstanceID_t(ulong value)
		{
			return default(SteamItemInstanceID_t);
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0xE531A0", Offset = "0xE531A0", VA = "0xE531A0")]
		public static explicit operator ulong(SteamItemInstanceID_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0xE531AC", Offset = "0xE531AC", VA = "0xE531AC", Slot = "4")]
		public bool Equals(SteamItemInstanceID_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0xE531C8", Offset = "0xE531C8", VA = "0xE531C8", Slot = "5")]
		public int CompareTo(SteamItemInstanceID_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20001FE")]
	public struct HServerListRequest : IEquatable<HServerListRequest>
	{
		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HServerListRequest Invalid;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr m_HServerListRequest;

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x37AEA8", Offset = "0x37AEA8", VA = "0x37AEA8")]
		public HServerListRequest(IntPtr value)
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x37AEB0", Offset = "0x37AEB0", VA = "0x37AEB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x37AFEC", Offset = "0x37AFEC", VA = "0x37AFEC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x37AFF4", Offset = "0x37AFF4", VA = "0x37AFF4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x37AFE0", Offset = "0x37AFE0", VA = "0x37AFE0")]
		public static bool operator ==(HServerListRequest x, HServerListRequest y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x37B000", Offset = "0x37B000", VA = "0x37B000")]
		public static bool operator !=(HServerListRequest x, HServerListRequest y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x37B094", Offset = "0x37B094", VA = "0x37B094")]
		public static explicit operator HServerListRequest(IntPtr value)
		{
			return default(HServerListRequest);
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x37B09C", Offset = "0x37B09C", VA = "0x37B09C")]
		public static explicit operator IntPtr(HServerListRequest that)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x37B0A4", Offset = "0x37B0A4", VA = "0x37B0A4", Slot = "4")]
		public bool Equals(HServerListRequest other)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x20001FF")]
	public struct HServerQuery : IEquatable<HServerQuery>, IComparable<HServerQuery>
	{
		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly HServerQuery Invalid;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int m_HServerQuery;

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x37B120", Offset = "0x37B120", VA = "0x37B120")]
		public HServerQuery(int value)
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x37B128", Offset = "0x37B128", VA = "0x37B128", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x37B260", Offset = "0x37B260", VA = "0x37B260", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x37B268", Offset = "0x37B268", VA = "0x37B268", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x37B250", Offset = "0x37B250", VA = "0x37B250")]
		public static bool operator ==(HServerQuery x, HServerQuery y)
		{
			return default(bool);
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x37B274", Offset = "0x37B274", VA = "0x37B274")]
		public static bool operator !=(HServerQuery x, HServerQuery y)
		{
			return default(bool);
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x37B2FC", Offset = "0x37B2FC", VA = "0x37B2FC")]
		public static explicit operator HServerQuery(int value)
		{
			return default(HServerQuery);
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x37B304", Offset = "0x37B304", VA = "0x37B304")]
		public static explicit operator int(HServerQuery that)
		{
			return default(int);
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x37B30C", Offset = "0x37B30C", VA = "0x37B30C", Slot = "4")]
		public bool Equals(HServerQuery other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x37B320", Offset = "0x37B320", VA = "0x37B320", Slot = "5")]
		public int CompareTo(HServerQuery other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000200")]
	public struct SNetListenSocket_t : IEquatable<SNetListenSocket_t>, IComparable<SNetListenSocket_t>
	{
		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_SNetListenSocket;

		[Token(Token = "0x6000964")]
		[Address(RVA = "0xE3A33C", Offset = "0xE3A33C", VA = "0xE3A33C")]
		public SNetListenSocket_t(uint value)
		{
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0xE3A344", Offset = "0xE3A344", VA = "0xE3A344", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0xE3A3F4", Offset = "0xE3A3F4", VA = "0xE3A3F4", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0xE3A3FC", Offset = "0xE3A3FC", VA = "0xE3A3FC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0xE3A3E4", Offset = "0xE3A3E4", VA = "0xE3A3E4")]
		public static bool operator ==(SNetListenSocket_t x, SNetListenSocket_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0xE3A408", Offset = "0xE3A408", VA = "0xE3A408")]
		public static bool operator !=(SNetListenSocket_t x, SNetListenSocket_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0xE3A418", Offset = "0xE3A418", VA = "0xE3A418")]
		public static explicit operator SNetListenSocket_t(uint value)
		{
			return default(SNetListenSocket_t);
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0xE3A420", Offset = "0xE3A420", VA = "0xE3A420")]
		public static explicit operator uint(SNetListenSocket_t that)
		{
			return default(uint);
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0xE3A428", Offset = "0xE3A428", VA = "0xE3A428", Slot = "4")]
		public bool Equals(SNetListenSocket_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0xE3A43C", Offset = "0xE3A43C", VA = "0xE3A43C", Slot = "5")]
		public int CompareTo(SNetListenSocket_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000201")]
	public struct SNetSocket_t : IEquatable<SNetSocket_t>, IComparable<SNetSocket_t>
	{
		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_SNetSocket;

		[Token(Token = "0x600096E")]
		[Address(RVA = "0xE3A448", Offset = "0xE3A448", VA = "0xE3A448")]
		public SNetSocket_t(uint value)
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0xE3A450", Offset = "0xE3A450", VA = "0xE3A450", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0xE3A500", Offset = "0xE3A500", VA = "0xE3A500", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0xE3A508", Offset = "0xE3A508", VA = "0xE3A508", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0xE3A4F0", Offset = "0xE3A4F0", VA = "0xE3A4F0")]
		public static bool operator ==(SNetSocket_t x, SNetSocket_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0xE3A514", Offset = "0xE3A514", VA = "0xE3A514")]
		public static bool operator !=(SNetSocket_t x, SNetSocket_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0xE3A524", Offset = "0xE3A524", VA = "0xE3A524")]
		public static explicit operator SNetSocket_t(uint value)
		{
			return default(SNetSocket_t);
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0xE3A52C", Offset = "0xE3A52C", VA = "0xE3A52C")]
		public static explicit operator uint(SNetSocket_t that)
		{
			return default(uint);
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0xE3A534", Offset = "0xE3A534", VA = "0xE3A534", Slot = "4")]
		public bool Equals(SNetSocket_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0xE3A548", Offset = "0xE3A548", VA = "0xE3A548", Slot = "5")]
		public int CompareTo(SNetSocket_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000202")]
	public struct PublishedFileId_t : IEquatable<PublishedFileId_t>, IComparable<PublishedFileId_t>
	{
		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly PublishedFileId_t Invalid;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_PublishedFileId;

		[Token(Token = "0x6000978")]
		[Address(RVA = "0xE387E0", Offset = "0xE387E0", VA = "0xE387E0")]
		public PublishedFileId_t(ulong value)
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0xE387F0", Offset = "0xE387F0", VA = "0xE387F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0xE38940", Offset = "0xE38940", VA = "0xE38940", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0xE38948", Offset = "0xE38948", VA = "0xE38948", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0xE38920", Offset = "0xE38920", VA = "0xE38920")]
		public static bool operator ==(PublishedFileId_t x, PublishedFileId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0xE38954", Offset = "0xE38954", VA = "0xE38954")]
		public static bool operator !=(PublishedFileId_t x, PublishedFileId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0xE389E8", Offset = "0xE389E8", VA = "0xE389E8")]
		public static explicit operator PublishedFileId_t(ulong value)
		{
			return default(PublishedFileId_t);
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0xE389F8", Offset = "0xE389F8", VA = "0xE389F8")]
		public static explicit operator ulong(PublishedFileId_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0xE38A04", Offset = "0xE38A04", VA = "0xE38A04", Slot = "4")]
		public bool Equals(PublishedFileId_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0xE38A20", Offset = "0xE38A20", VA = "0xE38A20", Slot = "5")]
		public int CompareTo(PublishedFileId_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000203")]
	public struct PublishedFileUpdateHandle_t : IEquatable<PublishedFileUpdateHandle_t>, IComparable<PublishedFileUpdateHandle_t>
	{
		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly PublishedFileUpdateHandle_t Invalid;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_PublishedFileUpdateHandle;

		[Token(Token = "0x6000983")]
		[Address(RVA = "0xE38AB0", Offset = "0xE38AB0", VA = "0xE38AB0")]
		public PublishedFileUpdateHandle_t(ulong value)
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0xE38AC0", Offset = "0xE38AC0", VA = "0xE38AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0xE38C10", Offset = "0xE38C10", VA = "0xE38C10", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0xE38C18", Offset = "0xE38C18", VA = "0xE38C18", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0xE38BF0", Offset = "0xE38BF0", VA = "0xE38BF0")]
		public static bool operator ==(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0xE38C24", Offset = "0xE38C24", VA = "0xE38C24")]
		public static bool operator !=(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0xE38CB8", Offset = "0xE38CB8", VA = "0xE38CB8")]
		public static explicit operator PublishedFileUpdateHandle_t(ulong value)
		{
			return default(PublishedFileUpdateHandle_t);
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0xE38CC8", Offset = "0xE38CC8", VA = "0xE38CC8")]
		public static explicit operator ulong(PublishedFileUpdateHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0xE38CD4", Offset = "0xE38CD4", VA = "0xE38CD4", Slot = "4")]
		public bool Equals(PublishedFileUpdateHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0xE38CF0", Offset = "0xE38CF0", VA = "0xE38CF0", Slot = "5")]
		public int CompareTo(PublishedFileUpdateHandle_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000204")]
	public struct UGCFileWriteStreamHandle_t : IEquatable<UGCFileWriteStreamHandle_t>, IComparable<UGCFileWriteStreamHandle_t>
	{
		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly UGCFileWriteStreamHandle_t Invalid;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_UGCFileWriteStreamHandle;

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x134DCD8", Offset = "0x134DCD8", VA = "0x134DCD8")]
		public UGCFileWriteStreamHandle_t(ulong value)
		{
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x134DCE8", Offset = "0x134DCE8", VA = "0x134DCE8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x134DE38", Offset = "0x134DE38", VA = "0x134DE38", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x134DE40", Offset = "0x134DE40", VA = "0x134DE40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x134DE18", Offset = "0x134DE18", VA = "0x134DE18")]
		public static bool operator ==(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x134DE4C", Offset = "0x134DE4C", VA = "0x134DE4C")]
		public static bool operator !=(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x1340B60", Offset = "0x1340B60", VA = "0x1340B60")]
		public static explicit operator UGCFileWriteStreamHandle_t(ulong value)
		{
			return default(UGCFileWriteStreamHandle_t);
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x134DEE0", Offset = "0x134DEE0", VA = "0x134DEE0")]
		public static explicit operator ulong(UGCFileWriteStreamHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x134DEEC", Offset = "0x134DEEC", VA = "0x134DEEC", Slot = "4")]
		public bool Equals(UGCFileWriteStreamHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x134DF08", Offset = "0x134DF08", VA = "0x134DF08", Slot = "5")]
		public int CompareTo(UGCFileWriteStreamHandle_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000205")]
	public struct UGCHandle_t : IEquatable<UGCHandle_t>, IComparable<UGCHandle_t>
	{
		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly UGCHandle_t Invalid;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_UGCHandle;

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x134DF98", Offset = "0x134DF98", VA = "0x134DF98")]
		public UGCHandle_t(ulong value)
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x134DFA8", Offset = "0x134DFA8", VA = "0x134DFA8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x134E0F8", Offset = "0x134E0F8", VA = "0x134E0F8", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x134E100", Offset = "0x134E100", VA = "0x134E100", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x134E0D8", Offset = "0x134E0D8", VA = "0x134E0D8")]
		public static bool operator ==(UGCHandle_t x, UGCHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x134E10C", Offset = "0x134E10C", VA = "0x134E10C")]
		public static bool operator !=(UGCHandle_t x, UGCHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x1341814", Offset = "0x1341814", VA = "0x1341814")]
		public static explicit operator UGCHandle_t(ulong value)
		{
			return default(UGCHandle_t);
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x134E1A0", Offset = "0x134E1A0", VA = "0x134E1A0")]
		public static explicit operator ulong(UGCHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x134E1AC", Offset = "0x134E1AC", VA = "0x134E1AC", Slot = "4")]
		public bool Equals(UGCHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x134E1C8", Offset = "0x134E1C8", VA = "0x134E1C8", Slot = "5")]
		public int CompareTo(UGCHandle_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000206")]
	public struct ScreenshotHandle : IEquatable<ScreenshotHandle>, IComparable<ScreenshotHandle>
	{
		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ScreenshotHandle Invalid;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_ScreenshotHandle;

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0xE39B04", Offset = "0xE39B04", VA = "0xE39B04")]
		public ScreenshotHandle(uint value)
		{
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0xE39B0C", Offset = "0xE39B0C", VA = "0xE39B0C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0xE39C44", Offset = "0xE39C44", VA = "0xE39C44", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0xE39C4C", Offset = "0xE39C4C", VA = "0xE39C4C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0xE39C34", Offset = "0xE39C34", VA = "0xE39C34")]
		public static bool operator ==(ScreenshotHandle x, ScreenshotHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0xE39C58", Offset = "0xE39C58", VA = "0xE39C58")]
		public static bool operator !=(ScreenshotHandle x, ScreenshotHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0xE39CE0", Offset = "0xE39CE0", VA = "0xE39CE0")]
		public static explicit operator ScreenshotHandle(uint value)
		{
			return default(ScreenshotHandle);
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0xE39CE8", Offset = "0xE39CE8", VA = "0xE39CE8")]
		public static explicit operator uint(ScreenshotHandle that)
		{
			return default(uint);
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0xE39CF0", Offset = "0xE39CF0", VA = "0xE39CF0", Slot = "4")]
		public bool Equals(ScreenshotHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0xE39D04", Offset = "0xE39D04", VA = "0xE39D04", Slot = "5")]
		public int CompareTo(ScreenshotHandle other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000207")]
	public struct AccountID_t : IEquatable<AccountID_t>, IComparable<AccountID_t>
	{
		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_AccountID;

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x37478C", Offset = "0x37478C", VA = "0x37478C")]
		public AccountID_t(uint value)
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x374794", Offset = "0x374794", VA = "0x374794", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x374844", Offset = "0x374844", VA = "0x374844", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x37484C", Offset = "0x37484C", VA = "0x37484C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x374834", Offset = "0x374834", VA = "0x374834")]
		public static bool operator ==(AccountID_t x, AccountID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x374858", Offset = "0x374858", VA = "0x374858")]
		public static bool operator !=(AccountID_t x, AccountID_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x374868", Offset = "0x374868", VA = "0x374868")]
		public static explicit operator AccountID_t(uint value)
		{
			return default(AccountID_t);
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x374870", Offset = "0x374870", VA = "0x374870")]
		public static explicit operator uint(AccountID_t that)
		{
			return default(uint);
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x374878", Offset = "0x374878", VA = "0x374878", Slot = "4")]
		public bool Equals(AccountID_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x37488C", Offset = "0x37488C", VA = "0x37488C", Slot = "5")]
		public int CompareTo(AccountID_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000208")]
	public struct AppId_t : IEquatable<AppId_t>, IComparable<AppId_t>
	{
		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly AppId_t Invalid;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_AppId;

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x374898", Offset = "0x374898", VA = "0x374898")]
		public AppId_t(uint value)
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x3748A0", Offset = "0x3748A0", VA = "0x3748A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x3749D8", Offset = "0x3749D8", VA = "0x3749D8", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x3749E0", Offset = "0x3749E0", VA = "0x3749E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x3749C8", Offset = "0x3749C8", VA = "0x3749C8")]
		public static bool operator ==(AppId_t x, AppId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x3749EC", Offset = "0x3749EC", VA = "0x3749EC")]
		public static bool operator !=(AppId_t x, AppId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x374A74", Offset = "0x374A74", VA = "0x374A74")]
		public static explicit operator AppId_t(uint value)
		{
			return default(AppId_t);
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x374A7C", Offset = "0x374A7C", VA = "0x374A7C")]
		public static explicit operator uint(AppId_t that)
		{
			return default(uint);
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x374A84", Offset = "0x374A84", VA = "0x374A84", Slot = "4")]
		public bool Equals(AppId_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x374A98", Offset = "0x374A98", VA = "0x374A98", Slot = "5")]
		public int CompareTo(AppId_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000209")]
	public struct DepotId_t : IEquatable<DepotId_t>, IComparable<DepotId_t>
	{
		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly DepotId_t Invalid;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint m_DepotId;

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x37857C", Offset = "0x37857C", VA = "0x37857C")]
		public DepotId_t(uint value)
		{
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x378584", Offset = "0x378584", VA = "0x378584", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x3786BC", Offset = "0x3786BC", VA = "0x3786BC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x3786C4", Offset = "0x3786C4", VA = "0x3786C4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x3786AC", Offset = "0x3786AC", VA = "0x3786AC")]
		public static bool operator ==(DepotId_t x, DepotId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x3786D0", Offset = "0x3786D0", VA = "0x3786D0")]
		public static bool operator !=(DepotId_t x, DepotId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x378758", Offset = "0x378758", VA = "0x378758")]
		public static explicit operator DepotId_t(uint value)
		{
			return default(DepotId_t);
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x378760", Offset = "0x378760", VA = "0x378760")]
		public static explicit operator uint(DepotId_t that)
		{
			return default(uint);
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x378768", Offset = "0x378768", VA = "0x378768", Slot = "4")]
		public bool Equals(DepotId_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x37877C", Offset = "0x37877C", VA = "0x37877C", Slot = "5")]
		public int CompareTo(DepotId_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200020A")]
	public struct ManifestId_t : IEquatable<ManifestId_t>, IComparable<ManifestId_t>
	{
		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ManifestId_t Invalid;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ManifestId;

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x3828C4", Offset = "0x3828C4", VA = "0x3828C4")]
		public ManifestId_t(ulong value)
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x3828D4", Offset = "0x3828D4", VA = "0x3828D4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x382A24", Offset = "0x382A24", VA = "0x382A24", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x382A2C", Offset = "0x382A2C", VA = "0x382A2C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x382A04", Offset = "0x382A04", VA = "0x382A04")]
		public static bool operator ==(ManifestId_t x, ManifestId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x382A38", Offset = "0x382A38", VA = "0x382A38")]
		public static bool operator !=(ManifestId_t x, ManifestId_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x382ACC", Offset = "0x382ACC", VA = "0x382ACC")]
		public static explicit operator ManifestId_t(ulong value)
		{
			return default(ManifestId_t);
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x382ADC", Offset = "0x382ADC", VA = "0x382ADC")]
		public static explicit operator ulong(ManifestId_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x382AE8", Offset = "0x382AE8", VA = "0x382AE8", Slot = "4")]
		public bool Equals(ManifestId_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x382B04", Offset = "0x382B04", VA = "0x382B04", Slot = "5")]
		public int CompareTo(ManifestId_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200020B")]
	public struct SteamAPICall_t : IEquatable<SteamAPICall_t>, IComparable<SteamAPICall_t>
	{
		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SteamAPICall_t Invalid;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamAPICall;

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0xE3A9CC", Offset = "0xE3A9CC", VA = "0xE3A9CC")]
		public SteamAPICall_t(ulong value)
		{
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0xE3A9DC", Offset = "0xE3A9DC", VA = "0xE3A9DC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0xE3AB2C", Offset = "0xE3AB2C", VA = "0xE3AB2C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0xE3AB34", Offset = "0xE3AB34", VA = "0xE3AB34", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0xE3AB0C", Offset = "0xE3AB0C", VA = "0xE3AB0C")]
		public static bool operator ==(SteamAPICall_t x, SteamAPICall_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0xE3AB40", Offset = "0xE3AB40", VA = "0xE3AB40")]
		public static bool operator !=(SteamAPICall_t x, SteamAPICall_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0xE3ABD4", Offset = "0xE3ABD4", VA = "0xE3ABD4")]
		public static explicit operator SteamAPICall_t(ulong value)
		{
			return default(SteamAPICall_t);
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0xE3ABE4", Offset = "0xE3ABE4", VA = "0xE3ABE4")]
		public static explicit operator ulong(SteamAPICall_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0xE3ABF0", Offset = "0xE3ABF0", VA = "0xE3ABF0", Slot = "4")]
		public bool Equals(SteamAPICall_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0xE3AC0C", Offset = "0xE3AC0C", VA = "0xE3AC0C", Slot = "5")]
		public int CompareTo(SteamAPICall_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200020C")]
	public struct UGCQueryHandle_t : IEquatable<UGCQueryHandle_t>, IComparable<UGCQueryHandle_t>
	{
		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly UGCQueryHandle_t Invalid;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_UGCQueryHandle;

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x134E258", Offset = "0x134E258", VA = "0x134E258")]
		public UGCQueryHandle_t(ulong value)
		{
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x134E268", Offset = "0x134E268", VA = "0x134E268", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x134E3B8", Offset = "0x134E3B8", VA = "0x134E3B8", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x134E3C0", Offset = "0x134E3C0", VA = "0x134E3C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x134E398", Offset = "0x134E398", VA = "0x134E398")]
		public static bool operator ==(UGCQueryHandle_t x, UGCQueryHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x134E3CC", Offset = "0x134E3CC", VA = "0x134E3CC")]
		public static bool operator !=(UGCQueryHandle_t x, UGCQueryHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x13446C4", Offset = "0x13446C4", VA = "0x13446C4")]
		public static explicit operator UGCQueryHandle_t(ulong value)
		{
			return default(UGCQueryHandle_t);
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x134E460", Offset = "0x134E460", VA = "0x134E460")]
		public static explicit operator ulong(UGCQueryHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x134E46C", Offset = "0x134E46C", VA = "0x134E46C", Slot = "4")]
		public bool Equals(UGCQueryHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x134E488", Offset = "0x134E488", VA = "0x134E488", Slot = "5")]
		public int CompareTo(UGCQueryHandle_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200020D")]
	public struct UGCUpdateHandle_t : IEquatable<UGCUpdateHandle_t>, IComparable<UGCUpdateHandle_t>
	{
		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly UGCUpdateHandle_t Invalid;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_UGCUpdateHandle;

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x134E518", Offset = "0x134E518", VA = "0x134E518")]
		public UGCUpdateHandle_t(ulong value)
		{
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x134E528", Offset = "0x134E528", VA = "0x134E528", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x134E678", Offset = "0x134E678", VA = "0x134E678", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x134E680", Offset = "0x134E680", VA = "0x134E680", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x134E658", Offset = "0x134E658", VA = "0x134E658")]
		public static bool operator ==(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x134E68C", Offset = "0x134E68C", VA = "0x134E68C")]
		public static bool operator !=(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x134618C", Offset = "0x134618C", VA = "0x134618C")]
		public static explicit operator UGCUpdateHandle_t(ulong value)
		{
			return default(UGCUpdateHandle_t);
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x134E720", Offset = "0x134E720", VA = "0x134E720")]
		public static explicit operator ulong(UGCUpdateHandle_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x134E72C", Offset = "0x134E72C", VA = "0x134E72C", Slot = "4")]
		public bool Equals(UGCUpdateHandle_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x134E748", Offset = "0x134E748", VA = "0x134E748", Slot = "5")]
		public int CompareTo(UGCUpdateHandle_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200020E")]
	public struct ClientUnifiedMessageHandle : IEquatable<ClientUnifiedMessageHandle>, IComparable<ClientUnifiedMessageHandle>
	{
		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ClientUnifiedMessageHandle Invalid;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_ClientUnifiedMessageHandle;

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x375C1C", Offset = "0x375C1C", VA = "0x375C1C")]
		public ClientUnifiedMessageHandle(ulong value)
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x375C2C", Offset = "0x375C2C", VA = "0x375C2C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x375D7C", Offset = "0x375D7C", VA = "0x375D7C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x375D84", Offset = "0x375D84", VA = "0x375D84", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x375D5C", Offset = "0x375D5C", VA = "0x375D5C")]
		public static bool operator ==(ClientUnifiedMessageHandle x, ClientUnifiedMessageHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x375D90", Offset = "0x375D90", VA = "0x375D90")]
		public static bool operator !=(ClientUnifiedMessageHandle x, ClientUnifiedMessageHandle y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x375E24", Offset = "0x375E24", VA = "0x375E24")]
		public static explicit operator ClientUnifiedMessageHandle(ulong value)
		{
			return default(ClientUnifiedMessageHandle);
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x375E34", Offset = "0x375E34", VA = "0x375E34")]
		public static explicit operator ulong(ClientUnifiedMessageHandle that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x375E40", Offset = "0x375E40", VA = "0x375E40", Slot = "4")]
		public bool Equals(ClientUnifiedMessageHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x375E5C", Offset = "0x375E5C", VA = "0x375E5C", Slot = "5")]
		public int CompareTo(ClientUnifiedMessageHandle other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200020F")]
	public struct SteamLeaderboard_t : IEquatable<SteamLeaderboard_t>, IComparable<SteamLeaderboard_t>
	{
		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamLeaderboard;

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0xE53258", Offset = "0xE53258", VA = "0xE53258")]
		public SteamLeaderboard_t(ulong value)
		{
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0xE53268", Offset = "0xE53268", VA = "0xE53268", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0xE53330", Offset = "0xE53330", VA = "0xE53330", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0xE53338", Offset = "0xE53338", VA = "0xE53338", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0xE53310", Offset = "0xE53310", VA = "0xE53310")]
		public static bool operator ==(SteamLeaderboard_t x, SteamLeaderboard_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0xE53344", Offset = "0xE53344", VA = "0xE53344")]
		public static bool operator !=(SteamLeaderboard_t x, SteamLeaderboard_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0xE53360", Offset = "0xE53360", VA = "0xE53360")]
		public static explicit operator SteamLeaderboard_t(ulong value)
		{
			return default(SteamLeaderboard_t);
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0xE53370", Offset = "0xE53370", VA = "0xE53370")]
		public static explicit operator ulong(SteamLeaderboard_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0xE5337C", Offset = "0xE5337C", VA = "0xE5337C", Slot = "4")]
		public bool Equals(SteamLeaderboard_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0xE53398", Offset = "0xE53398", VA = "0xE53398", Slot = "5")]
		public int CompareTo(SteamLeaderboard_t other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000210")]
	public struct SteamLeaderboardEntries_t : IEquatable<SteamLeaderboardEntries_t>, IComparable<SteamLeaderboardEntries_t>
	{
		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong m_SteamLeaderboardEntries;

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0xE533BC", Offset = "0xE533BC", VA = "0xE533BC")]
		public SteamLeaderboardEntries_t(ulong value)
		{
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0xE533CC", Offset = "0xE533CC", VA = "0xE533CC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0xE53494", Offset = "0xE53494", VA = "0xE53494", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0xE5349C", Offset = "0xE5349C", VA = "0xE5349C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0xE53474", Offset = "0xE53474", VA = "0xE53474")]
		public static bool operator ==(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0xE534A8", Offset = "0xE534A8", VA = "0xE534A8")]
		public static bool operator !=(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0xE534C4", Offset = "0xE534C4", VA = "0xE534C4")]
		public static explicit operator SteamLeaderboardEntries_t(ulong value)
		{
			return default(SteamLeaderboardEntries_t);
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0xE534D4", Offset = "0xE534D4", VA = "0xE534D4")]
		public static explicit operator ulong(SteamLeaderboardEntries_t that)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0xE534E0", Offset = "0xE534E0", VA = "0xE534E0", Slot = "4")]
		public bool Equals(SteamLeaderboardEntries_t other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0xE534FC", Offset = "0xE534FC", VA = "0xE534FC", Slot = "5")]
		public int CompareTo(SteamLeaderboardEntries_t other)
		{
			return default(int);
		}
	}
}
namespace wvr
{
	[Token(Token = "0x2000211")]
	public class Interop
	{
		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x134E910", Offset = "0x134E910", VA = "0x134E910")]
		public Interop()
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x134E918", Offset = "0x134E918", VA = "0x134E918")]
		public static extern bool WVR_PollEventQueue(ref WVR_Event_t e);

		[PreserveSig]
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x134E9E0", Offset = "0x134E9E0", VA = "0x134E9E0")]
		public static extern int WVR_GetInputDeviceCapability(WVR_DeviceType type, WVR_InputType inputType);

		[PreserveSig]
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x134EAA8", Offset = "0x134EAA8", VA = "0x134EAA8")]
		public static extern bool WVR_GetInputDeviceState(WVR_DeviceType type, uint inputMask, ref uint buttons, ref uint touches, [In][Out] WVR_AnalogState_t[] analogArray, uint analogArrayCount);

		[PreserveSig]
		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x134EB9C", Offset = "0x134EB9C", VA = "0x134EB9C")]
		public static extern int WVR_GetInputTypeCount(WVR_DeviceType type, WVR_InputType inputType);

		[PreserveSig]
		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x134EC64", Offset = "0x134EC64", VA = "0x134EC64")]
		public static extern bool WVR_GetInputButtonState(WVR_DeviceType type, WVR_InputId id);

		[PreserveSig]
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x134ED34", Offset = "0x134ED34", VA = "0x134ED34")]
		public static extern bool WVR_GetInputTouchState(WVR_DeviceType type, WVR_InputId id);

		[PreserveSig]
		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x134EE04", Offset = "0x134EE04", VA = "0x134EE04")]
		public static extern WVR_Axis_t WVR_GetInputAnalogAxis(WVR_DeviceType type, WVR_InputId id);

		[PreserveSig]
		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x134EED4", Offset = "0x134EED4", VA = "0x134EED4")]
		public static extern void WVR_GetPoseState(WVR_DeviceType type, WVR_PoseOriginModel originModel, uint predictedMilliSec, ref WVR_PoseState_t poseState);

		[PreserveSig]
		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x134F3A8", Offset = "0x134F3A8", VA = "0x134F3A8")]
		public static extern void WVR_GetSyncPose(WVR_PoseOriginModel originModel, [In][Out] WVR_DevicePosePair_t[] poseArray, uint pairArrayCount);

		[PreserveSig]
		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x134F860", Offset = "0x134F860", VA = "0x134F860")]
		public static extern bool WVR_IsDeviceConnected(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x134F928", Offset = "0x134F928", VA = "0x134F928")]
		public static extern void WVR_TriggerVibrator(WVR_DeviceType type, WVR_InputId id, ushort durationMicroSec);

		[PreserveSig]
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x134F9F8", Offset = "0x134F9F8", VA = "0x134F9F8")]
		public static extern void WVR_TriggerRecenter();

		[PreserveSig]
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x134FAA8", Offset = "0x134FAA8", VA = "0x134FAA8")]
		public static extern WVR_Arena_t WVR_GetArena();

		[PreserveSig]
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x134FB64", Offset = "0x134FB64", VA = "0x134FB64")]
		public static extern bool WVR_SetArena(ref WVR_Arena_t arena);

		[PreserveSig]
		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x134FC2C", Offset = "0x134FC2C", VA = "0x134FC2C")]
		public static extern WVR_ArenaVisible WVR_GetArenaVisible();

		[PreserveSig]
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x134FCDC", Offset = "0x134FCDC", VA = "0x134FCDC")]
		public static extern void WVR_SetArenaVisible(WVR_ArenaVisible config);

		[PreserveSig]
		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x134FD9C", Offset = "0x134FD9C", VA = "0x134FD9C")]
		public static extern bool WVR_IsOverArenaRange();

		[PreserveSig]
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x134FE54", Offset = "0x134FE54", VA = "0x134FE54")]
		public static extern float WVR_GetDeviceBatteryPercentage(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x134FF14", Offset = "0x134FF14", VA = "0x134FF14")]
		public static extern WVR_BatteryStatus WVR_GetBatteryStatus(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x134FFD4", Offset = "0x134FFD4", VA = "0x134FFD4")]
		public static extern WVR_ChargeStatus WVR_GetChargeStatus(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x1350094", Offset = "0x1350094", VA = "0x1350094")]
		public static extern WVR_BatteryTemperatureStatus WVR_GetBatteryTemperatureStatus(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x1350154", Offset = "0x1350154", VA = "0x1350154")]
		public static extern float WVR_GetBatteryTemperature(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x1350214", Offset = "0x1350214", VA = "0x1350214")]
		public static extern WVR_InitError WVR_Init(WVR_AppType eType);

		[PreserveSig]
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x13502D4", Offset = "0x13502D4", VA = "0x13502D4")]
		public static extern void WVR_Quit();

		[PreserveSig]
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x1350384", Offset = "0x1350384", VA = "0x1350384")]
		public static extern IntPtr WVR_GetInitErrorString(WVR_InitError error);

		[PreserveSig]
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x1350444", Offset = "0x1350444", VA = "0x1350444")]
		public static extern uint WVR_GetWaveRuntimeVersion();

		[PreserveSig]
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x13504F4", Offset = "0x13504F4", VA = "0x13504F4")]
		public static extern uint WVR_GetWaveSDKVersion();

		[PreserveSig]
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x13505A4", Offset = "0x13505A4", VA = "0x13505A4")]
		public static extern bool WVR_IsInputFocusCapturedBySystem();

		[PreserveSig]
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x135065C", Offset = "0x135065C", VA = "0x135065C")]
		internal static extern WVR_RenderError WVR_RenderInit(ref WVR_RenderInitParams_t param);

		[PreserveSig]
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x135071C", Offset = "0x135071C", VA = "0x135071C")]
		public static extern bool WVR_StartCamera(ref WVR_CameraInfo_t info);

		[PreserveSig]
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x13507E4", Offset = "0x13507E4", VA = "0x13507E4")]
		public static extern void WVR_StopCamera();

		[PreserveSig]
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x1350894", Offset = "0x1350894", VA = "0x1350894")]
		public static extern bool WVR_UpdateTexture(uint textureid);

		[PreserveSig]
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x135095C", Offset = "0x135095C", VA = "0x135095C")]
		public static extern bool WVR_GetCameraIntrinsic(WVR_CameraPosition position, ref WVR_CameraIntrinsic_t intrinsic);

		[PreserveSig]
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x1350A2C", Offset = "0x1350A2C", VA = "0x1350A2C")]
		public static extern bool WVR_IsDeviceSuspend(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x1350AF4", Offset = "0x1350AF4", VA = "0x1350AF4")]
		public static extern void WVR_ConvertMatrixQuaternion(ref WVR_Matrix4f_t mat, ref WVR_Quatf_t quat, bool m2q);

		[PreserveSig]
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x1350BC4", Offset = "0x1350BC4", VA = "0x1350BC4")]
		public static extern WVR_NumDoF WVR_GetDegreeOfFreedom(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x1350C84", Offset = "0x1350C84", VA = "0x1350C84")]
		public static extern void WVR_SetParameters(WVR_DeviceType type, IntPtr pchValue);

		[PreserveSig]
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x1350D4C", Offset = "0x1350D4C", VA = "0x1350D4C")]
		public static extern uint WVR_GetParameters(WVR_DeviceType type, IntPtr pchValue, IntPtr retValue, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x1350E20", Offset = "0x1350E20", VA = "0x1350E20")]
		public static extern WVR_DeviceType WVR_GetDefaultControllerRole();

		[PreserveSig]
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x1350ED0", Offset = "0x1350ED0", VA = "0x1350ED0")]
		public static extern void WVR_GetRenderTargetSize(ref uint width, ref uint height);

		[PreserveSig]
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x1350F98", Offset = "0x1350F98", VA = "0x1350F98")]
		public static extern WVR_Matrix4f_t WVR_GetProjection(WVR_Eye eye, float near, float far);

		[PreserveSig]
		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x1351070", Offset = "0x1351070", VA = "0x1351070")]
		public static extern void WVR_GetClippingPlaneBoundary(WVR_Eye eye, ref float left, ref float right, ref float top, ref float bottom);

		[PreserveSig]
		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x135114C", Offset = "0x135114C", VA = "0x135114C")]
		public static extern WVR_Matrix4f_t WVR_GetTransformFromEyeToHead(WVR_Eye eye, WVR_NumDoF dof);

		[PreserveSig]
		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x135121C", Offset = "0x135121C", VA = "0x135121C")]
		public static extern WVR_SubmitError WVR_SubmitFrame(WVR_Eye eye, ref WVR_TextureParams_t param, ref WVR_PoseState_t pose, WVR_SubmitExtend extendMethod);

		[PreserveSig]
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x135156C", Offset = "0x135156C", VA = "0x135156C")]
		public static extern bool WVR_RequestScreenshot(uint width, uint height, WVR_ScreenshotMode mode, IntPtr filename);

		[PreserveSig]
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x1351648", Offset = "0x1351648", VA = "0x1351648")]
		public static extern void WVR_RenderMask(WVR_Eye eye);

		[PreserveSig]
		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x1351708", Offset = "0x1351708", VA = "0x1351708")]
		public static extern bool WVR_GetRenderProps(ref WVR_RenderProps_t props);

		[PreserveSig]
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x1351830", Offset = "0x1351830", VA = "0x1351830")]
		public static extern IntPtr WVR_ObtainTextureQueue(WVR_TextureTarget target, WVR_TextureFormat format, WVR_TextureType type, uint width, uint height, int level);

		[PreserveSig]
		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x1351914", Offset = "0x1351914", VA = "0x1351914")]
		public static extern uint WVR_GetTextureQueueLength(IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x13519D4", Offset = "0x13519D4", VA = "0x13519D4")]
		public static extern WVR_TextureParams_t WVR_GetTexture(IntPtr handle, int index);

		[PreserveSig]
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x1351A9C", Offset = "0x1351A9C", VA = "0x1351A9C")]
		public static extern int WVR_GetAvailableTextureIndex(IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x1351B5C", Offset = "0x1351B5C", VA = "0x1351B5C")]
		public static extern void WVR_ReleaseTextureQueue(IntPtr handle);
	}
	[Token(Token = "0x2000212")]
	public enum WVR_AppType
	{
		[Token(Token = "0x40008AE")]
		WVR_AppType_VRContent = 1,
		[Token(Token = "0x40008AF")]
		WVR_AppType_NonVRContent
	}
	[Token(Token = "0x2000213")]
	public enum WVR_InitError
	{
		[Token(Token = "0x40008B1")]
		WVR_InitError_None,
		[Token(Token = "0x40008B2")]
		WVR_InitError_Unknown,
		[Token(Token = "0x40008B3")]
		WVR_InitError_NotInitialized
	}
	[Token(Token = "0x2000214")]
	public enum WVR_EventType
	{
		[Token(Token = "0x40008B5")]
		WVR_EventType_Quit = 99,
		[Token(Token = "0x40008B6")]
		WVR_EventType_DeviceConnected = 100,
		[Token(Token = "0x40008B7")]
		WVR_EventType_DeviceDisconnected = 101,
		[Token(Token = "0x40008B8")]
		WVR_EventType_DeviceStatusUpdate = 102,
		[Token(Token = "0x40008B9")]
		WVR_EventType_IpdChanged = 105,
		[Token(Token = "0x40008BA")]
		WVR_EventType_DeviceSuspend = 106,
		[Token(Token = "0x40008BB")]
		WVR_EventType_DeviceResume = 107,
		[Token(Token = "0x40008BC")]
		WVR_EventType_DeviceRoleChanged = 108,
		[Token(Token = "0x40008BD")]
		WVR_EventType_BatteryStatus_Update = 30004,
		[Token(Token = "0x40008BE")]
		WVR_EventType_ChargeStatus_Update = 30005,
		[Token(Token = "0x40008BF")]
		WVR_EventType_DeviceErrorStatus_Update = 30006,
		[Token(Token = "0x40008C0")]
		WVR_EventType_BatteryTemperatureStatus_Update = 30007,
		[Token(Token = "0x40008C1")]
		WVR_EventType_RecenterSuccess = 30010,
		[Token(Token = "0x40008C2")]
		WVR_EventType_RecenterFail = 30011,
		[Token(Token = "0x40008C3")]
		WVR_EventType_RecenterSuccess_3DoF = 30012,
		[Token(Token = "0x40008C4")]
		WVR_EventType_RecenterFail_3DoF = 30013,
		[Token(Token = "0x40008C5")]
		WVR_EventType_TouchpadSwipe_LeftToRight = 30014,
		[Token(Token = "0x40008C6")]
		WVR_EventType_TouchpadSwipe_RightToLeft = 30015,
		[Token(Token = "0x40008C7")]
		WVR_EventType_TouchpadSwipe_DownToUp = 30016,
		[Token(Token = "0x40008C8")]
		WVR_EventType_TouchpadSwipe_UpToDown = 30017,
		[Token(Token = "0x40008C9")]
		WVR_EventType_Settings_Controller = 30022,
		[Token(Token = "0x40008CA")]
		WVR_EventType_TrackingModeChanged = 30106,
		[Token(Token = "0x40008CB")]
		WVR_EventType_ButtonPressed = 200,
		[Token(Token = "0x40008CC")]
		WVR_EventType_ButtonUnpressed = 201,
		[Token(Token = "0x40008CD")]
		WVR_EventType_TouchTapped = 202,
		[Token(Token = "0x40008CE")]
		WVR_EventType_TouchUntapped = 203
	}
	[Token(Token = "0x2000215")]
	public enum WVR_DeviceType
	{
		[Token(Token = "0x40008D0")]
		WVR_DeviceType_HMD = 1,
		[Token(Token = "0x40008D1")]
		WVR_DeviceType_Controller_Right,
		[Token(Token = "0x40008D2")]
		WVR_DeviceType_Controller_Left
	}
	[Token(Token = "0x2000216")]
	public enum WVR_InputType
	{
		[Token(Token = "0x40008D4")]
		WVR_InputType_Button = 1,
		[Token(Token = "0x40008D5")]
		WVR_InputType_Touch = 2,
		[Token(Token = "0x40008D6")]
		WVR_InputType_Analog = 4
	}
	[Token(Token = "0x2000217")]
	public enum WVR_BatteryStatus
	{
		[Token(Token = "0x40008D8")]
		WVR_BatteryStatus_Unknown,
		[Token(Token = "0x40008D9")]
		WVR_BatteryStatus_Normal,
		[Token(Token = "0x40008DA")]
		WVR_BatteryStatus_Low,
		[Token(Token = "0x40008DB")]
		WVR_BatteryStatus_UltraLow
	}
	[Token(Token = "0x2000218")]
	public enum WVR_ChargeStatus
	{
		[Token(Token = "0x40008DD")]
		WVR_ChargeStatus_Unknown,
		[Token(Token = "0x40008DE")]
		WVR_ChargeStatus_Discharging,
		[Token(Token = "0x40008DF")]
		WVR_ChargeStatus_Charging,
		[Token(Token = "0x40008E0")]
		WVR_ChargeStatus_Full
	}
	[Token(Token = "0x2000219")]
	public enum WVR_BatteryTemperatureStatus
	{
		[Token(Token = "0x40008E2")]
		WVR_BatteryTemperature_Unknown,
		[Token(Token = "0x40008E3")]
		WVR_BatteryTemperature_Normal,
		[Token(Token = "0x40008E4")]
		WVR_BatteryTemperature_Overheat,
		[Token(Token = "0x40008E5")]
		WVR_BatteryTemperature_UltraOverheat
	}
	[Token(Token = "0x200021A")]
	public enum WVR_DeviceErrorStatus
	{
		[Token(Token = "0x40008E7")]
		WVR_DeviceErrorStatus_None = 0,
		[Token(Token = "0x40008E8")]
		WVR_DeviceErrorStatus_BatteryOverheat = 1,
		[Token(Token = "0x40008E9")]
		WVR_DeviceErrorStatus_BatteryOverheatRestore = 2,
		[Token(Token = "0x40008EA")]
		WVR_DeviceErrorStatus_BatteryOvervoltage = 4,
		[Token(Token = "0x40008EB")]
		WVR_DeviceErrorStatus_BatteryOvervoltageRestore = 8,
		[Token(Token = "0x40008EC")]
		WVR_DeviceErrorStatus_DeviceConnectFail = 0x10,
		[Token(Token = "0x40008ED")]
		WVR_DeviceErrorStatus_DeviceConnectRestore = 0x20,
		[Token(Token = "0x40008EE")]
		WVR_DeviceErrorStatus_DeviceLostTracking = 0x40,
		[Token(Token = "0x40008EF")]
		WVR_DeviceErrorStatus_DeviceLostTrackingRestore = 0x80,
		[Token(Token = "0x40008F0")]
		WVR_DeviceErrorStatus_ChargeFail = 0x100,
		[Token(Token = "0x40008F1")]
		WVR_DeviceErrorStatus_ChargeRestore = 0x200
	}
	[Token(Token = "0x200021B")]
	public enum WVR_InputId
	{
		[Token(Token = "0x40008F3")]
		WVR_InputId_0 = 0,
		[Token(Token = "0x40008F4")]
		WVR_InputId_1 = 1,
		[Token(Token = "0x40008F5")]
		WVR_InputId_2 = 2,
		[Token(Token = "0x40008F6")]
		WVR_InputId_3 = 3,
		[Token(Token = "0x40008F7")]
		WVR_InputId_4 = 4,
		[Token(Token = "0x40008F8")]
		WVR_InputId_5 = 5,
		[Token(Token = "0x40008F9")]
		WVR_InputId_6 = 6,
		[Token(Token = "0x40008FA")]
		WVR_InputId_7 = 7,
		[Token(Token = "0x40008FB")]
		WVR_InputId_8 = 8,
		[Token(Token = "0x40008FC")]
		WVR_InputId_9 = 9,
		[Token(Token = "0x40008FD")]
		WVR_InputId_16 = 16,
		[Token(Token = "0x40008FE")]
		WVR_InputId_17 = 17,
		[Token(Token = "0x40008FF")]
		WVR_InputId_Alias1_System = 0,
		[Token(Token = "0x4000900")]
		WVR_InputId_Alias1_Menu = 1,
		[Token(Token = "0x4000901")]
		WVR_InputId_Alias1_Grip = 2,
		[Token(Token = "0x4000902")]
		WVR_InputId_Alias1_DPad_Left = 3,
		[Token(Token = "0x4000903")]
		WVR_InputId_Alias1_DPad_Up = 4,
		[Token(Token = "0x4000904")]
		WVR_InputId_Alias1_DPad_Right = 5,
		[Token(Token = "0x4000905")]
		WVR_InputId_Alias1_DPad_Down = 6,
		[Token(Token = "0x4000906")]
		WVR_InputId_Alias1_Volume_Up = 7,
		[Token(Token = "0x4000907")]
		WVR_InputId_Alias1_Volume_Down = 8,
		[Token(Token = "0x4000908")]
		WVR_InputId_Alias1_Bumper = 9,
		[Token(Token = "0x4000909")]
		WVR_InputId_Alias1_Touchpad = 16,
		[Token(Token = "0x400090A")]
		WVR_InputId_Alias1_Trigger = 17,
		[Token(Token = "0x400090B")]
		WVR_InputId_Max = 32
	}
	[Token(Token = "0x200021C")]
	public enum WVR_AnalogType
	{
		[Token(Token = "0x400090D")]
		WVR_AnalogType_None,
		[Token(Token = "0x400090E")]
		WVR_AnalogType_TouchPad,
		[Token(Token = "0x400090F")]
		WVR_AnalogType_Trigger
	}
	[Token(Token = "0x200021D")]
	public enum WVR_PoseOriginModel
	{
		[Token(Token = "0x4000911")]
		WVR_PoseOriginModel_OriginOnHead,
		[Token(Token = "0x4000912")]
		WVR_PoseOriginModel_OriginOnGround,
		[Token(Token = "0x4000913")]
		WVR_PoseOriginModel_OriginOnTrackingObserver,
		[Token(Token = "0x4000914")]
		WVR_PoseOriginModel_OriginOnHead_3DoF
	}
	[Token(Token = "0x200021E")]
	public enum WVR_ArenaVisible
	{
		[Token(Token = "0x4000916")]
		WVR_ArenaVisible_Auto,
		[Token(Token = "0x4000917")]
		WVR_ArenaVisible_ForceOn,
		[Token(Token = "0x4000918")]
		WVR_ArenaVisible_ForceOff
	}
	[Token(Token = "0x200021F")]
	public enum WVR_GraphicsApiType
	{
		[Token(Token = "0x400091A")]
		WVR_GraphicsApiType_OpenGL = 1
	}
	[Token(Token = "0x2000220")]
	public enum WVR_ScreenshotMode
	{
		[Token(Token = "0x400091C")]
		WVR_ScreenshotMode_Default,
		[Token(Token = "0x400091D")]
		WVR_ScreenshotMode_Raw
	}
	[Token(Token = "0x2000221")]
	public enum WVR_SubmitError
	{
		[Token(Token = "0x400091F")]
		WVR_SubmitError_None = 0,
		[Token(Token = "0x4000920")]
		WVR_SubmitError_InvalidTexture = 400,
		[Token(Token = "0x4000921")]
		WVR_SubmitError_ThreadStop = 401,
		[Token(Token = "0x4000922")]
		WVR_SubmitError_BufferSubmitFailed = 402,
		[Token(Token = "0x4000923")]
		WVR_SubmitError_Max = 65535
	}
	[Token(Token = "0x2000222")]
	public enum WVR_SubmitExtend
	{
		[Token(Token = "0x4000925")]
		WVR_SubmitExtend_Default
	}
	[Token(Token = "0x2000223")]
	public enum WVR_Eye
	{
		[Token(Token = "0x4000927")]
		WVR_Eye_Left,
		[Token(Token = "0x4000928")]
		WVR_Eye_Right
	}
	[Token(Token = "0x2000224")]
	public enum WVR_TextureTarget
	{
		[Token(Token = "0x400092A")]
		WVR_TextureTarget_2D,
		[Token(Token = "0x400092B")]
		WVR_TextureTarget_2D_ARRAY
	}
	[Token(Token = "0x2000225")]
	public enum WVR_TextureFormat
	{
		[Token(Token = "0x400092D")]
		WVR_TextureFormat_RGBA
	}
	[Token(Token = "0x2000226")]
	public enum WVR_TextureType
	{
		[Token(Token = "0x400092F")]
		WVR_TextureType_UnsignedByte
	}
	[Token(Token = "0x2000227")]
	public enum WVR_RenderError
	{
		[Token(Token = "0x4000931")]
		WVR_RenderError_None = 0,
		[Token(Token = "0x4000932")]
		WVR_RenderError_RuntimeInitFailed = 410,
		[Token(Token = "0x4000933")]
		WVR_RenderError_ContextSetupFailed = 411,
		[Token(Token = "0x4000934")]
		WVR_RenderError_DisplaySetupFailed = 412,
		[Token(Token = "0x4000935")]
		WVR_RenderError_LibNotSupported = 413,
		[Token(Token = "0x4000936")]
		WVR_RenderError_NullPtr = 414,
		[Token(Token = "0x4000937")]
		WVR_RenderError_Max = 65535
	}
	[Token(Token = "0x2000228")]
	public enum WVR_RenderConfig
	{
		[Token(Token = "0x4000939")]
		WVR_RenderConfig_Default = 0,
		[Token(Token = "0x400093A")]
		WVR_RenderConfig_Direct_Mode = 1,
		[Token(Token = "0x400093B")]
		WVR_RenderConfig_MSAA = 2,
		[Token(Token = "0x400093C")]
		WVR_RenderConfig_Vertical_Sync = 16,
		[Token(Token = "0x400093D")]
		WVR_RenderConfig_Timewarp = 256,
		[Token(Token = "0x400093E")]
		WVR_RenderConfig_Timewarp_Asynchronous = 768
	}
	[Token(Token = "0x2000229")]
	public enum WVR_CameraImageType
	{
		[Token(Token = "0x4000940")]
		WVR_CameraImageType_Invalid,
		[Token(Token = "0x4000941")]
		WVR_CameraImageType_SingleEye,
		[Token(Token = "0x4000942")]
		WVR_CameraImageType_DualEye
	}
	[Token(Token = "0x200022A")]
	public enum WVR_CameraImageFormat
	{
		[Token(Token = "0x4000944")]
		WVR_CameraImageFormat_Invalid,
		[Token(Token = "0x4000945")]
		WVR_CameraImageFormat_YUV_420,
		[Token(Token = "0x4000946")]
		WVR_CameraImageFormat_Grayscale
	}
	[Token(Token = "0x200022B")]
	public enum WVR_CameraPosition
	{
		[Token(Token = "0x4000948")]
		WVR_CameraPosition_Invalid,
		[Token(Token = "0x4000949")]
		WVR_CameraPosition_left,
		[Token(Token = "0x400094A")]
		WVR_CameraPosition_Right
	}
	[Token(Token = "0x200022C")]
	public enum WVR_OverlayError
	{
		[Token(Token = "0x400094C")]
		WVR_OverlayError_None = 0,
		[Token(Token = "0x400094D")]
		WVR_OverlayError_UnknownOverlay = 10,
		[Token(Token = "0x400094E")]
		WVR_OverlayError_OverlayUnavailable = 11,
		[Token(Token = "0x400094F")]
		WVR_OverlayError_InvalidParameter = 20
	}
	[Token(Token = "0x200022D")]
	public enum WVR_OverlayTransformType
	{
		[Token(Token = "0x4000951")]
		WVR_OverlayTransformType_None,
		[Token(Token = "0x4000952")]
		WVR_OverlayTransformType_Absolute,
		[Token(Token = "0x4000953")]
		WVR_OverlayTransformType_Fixed
	}
	[Token(Token = "0x200022E")]
	public enum WVR_NumDoF
	{
		[Token(Token = "0x4000955")]
		WVR_NumDoF_3DoF,
		[Token(Token = "0x4000956")]
		WVR_NumDoF_6DoF
	}
	[Token(Token = "0x200022F")]
	public enum WVR_ArenaShape
	{
		[Token(Token = "0x4000958")]
		WVR_ArenaShape_None,
		[Token(Token = "0x4000959")]
		WVR_ArenaShape_Rectangle,
		[Token(Token = "0x400095A")]
		WVR_ArenaShape_Round
	}
	[Token(Token = "0x2000230")]
	public struct WVR_RenderInitParams_t
	{
		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_GraphicsApiType graphicsApi;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong renderConfig;
	}
	[Token(Token = "0x2000231")]
	public struct WVR_Matrix4f_t
	{
		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m0;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float m1;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float m2;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float m3;

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float m4;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float m5;

		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m6;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float m7;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m8;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float m9;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m10;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m11;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m12;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float m13;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float m14;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float m15;
	}
	[Token(Token = "0x2000232")]
	public struct WVR_Vector2f_t
	{
		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float v0;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float v1;
	}
	[Token(Token = "0x2000233")]
	public struct WVR_Vector3f_t
	{
		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float v0;

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float v1;

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float v2;
	}
	[Token(Token = "0x2000234")]
	public struct WVR_CameraIntrinsic_t
	{
		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_Vector2f_t focalLength;

		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public WVR_Vector2f_t principalPoint;
	}
	[Token(Token = "0x2000235")]
	public struct WVR_CameraInfo_t
	{
		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_CameraImageType imgType;

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public WVR_CameraImageFormat imgFormat;

		[Token(Token = "0x4000976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint width;

		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint height;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint size;
	}
	[Token(Token = "0x2000236")]
	public struct WVR_Quatf_t
	{
		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float w;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float x;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float y;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float z;
	}
	[StructLayout(2)]
	[Token(Token = "0x2000237")]
	public struct WVR_PoseState_t
	{
		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool IsValidPose;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public WVR_Matrix4f_t PoseMatrix;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public WVR_Vector3f_t Velocity;

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public WVR_Vector3f_t AngularVelocity;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool Is6DoFPose;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public long PoseTimestamp_ns;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public WVR_Vector3f_t Acceleration;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public WVR_Vector3f_t AngularAcceleration;

		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float PredictedMilliSec;

		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public WVR_PoseOriginModel OriginModel;
	}
	[StructLayout(2)]
	[Token(Token = "0x2000238")]
	public struct WVR_DevicePosePair_t
	{
		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_DeviceType type;

		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public WVR_PoseState_t pose;
	}
	[Token(Token = "0x2000239")]
	public struct WVR_Hexagon_t
	{
		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_Vector3f_t vCorners0;

		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public WVR_Vector3f_t vCorners1;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WVR_Vector3f_t vCorners2;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public WVR_Vector3f_t vCorners3;

		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WVR_Vector3f_t vCorners4;

		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public WVR_Vector3f_t vCorners5;
	}
	[Token(Token = "0x200023A")]
	public struct WVR_TextureParams_t
	{
		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr id;
	}
	[Token(Token = "0x200023B")]
	public struct WVR_RenderProps_t
	{
		[Token(Token = "0x4000990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float refreshRate;

		[Token(Token = "0x4000991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool hasExternal;
	}
	[Token(Token = "0x200023C")]
	public struct WVR_CommonEvent_t
	{
		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_EventType type;

		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long timestamp;
	}
	[Token(Token = "0x200023D")]
	public struct WVR_DeviceEvent_t
	{
		[Token(Token = "0x4000994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_CommonEvent_t common;

		[Token(Token = "0x4000995")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public WVR_DeviceType type;
	}
	[Token(Token = "0x200023E")]
	public struct WVR_InputEvent_t
	{
		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_DeviceEvent_t device;

		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WVR_InputId inputId;
	}
	[Token(Token = "0x200023F")]
	public struct WVR_ErrorStatusEvent_t
	{
		[Token(Token = "0x4000998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_DeviceEvent_t device;

		[Token(Token = "0x4000999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WVR_DeviceErrorStatus status;
	}
	[Token(Token = "0x2000240")]
	public struct WVR_IPDEvent_t
	{
		[Token(Token = "0x400099A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_CommonEvent_t common;

		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float ipdMeters;
	}
	[Token(Token = "0x2000241")]
	public struct WVR_TrackingModeEvent_t
	{
		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_CommonEvent_t common;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public WVR_NumDoF trackingMode;
	}
	[StructLayout(2)]
	[Token(Token = "0x2000242")]
	public struct WVR_Event_t
	{
		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_CommonEvent_t common;

		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_DeviceEvent_t device;

		[Token(Token = "0x40009A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_InputEvent_t input;

		[Token(Token = "0x40009A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_ErrorStatusEvent_t error;

		[Token(Token = "0x40009A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_IPDEvent_t ipd;

		[Token(Token = "0x40009A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_TrackingModeEvent_t trmode;
	}
	[Token(Token = "0x2000243")]
	public struct WVR_Axis_t
	{
		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x40009A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;
	}
	[StructLayout(2)]
	[Token(Token = "0x2000244")]
	public struct WVR_AnalogState_t
	{
		[Token(Token = "0x40009A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_InputId id;

		[Token(Token = "0x40009A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public WVR_AnalogType type;

		[Token(Token = "0x40009A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public WVR_Axis_t axis;
	}
	[StructLayout(2)]
	[Token(Token = "0x2000245")]
	public struct WVR_Pose_t
	{
		[Token(Token = "0x40009A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_Vector3f_t position;

		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public WVR_Quatf_t rotation;
	}
	[Token(Token = "0x2000246")]
	public struct WVR_OverlayPosition_t
	{
		[Token(Token = "0x40009AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x40009AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;
	}
	[Token(Token = "0x2000247")]
	public struct WVR_OverlayBlendColor_t
	{
		[Token(Token = "0x40009AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float r;

		[Token(Token = "0x40009AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float g;

		[Token(Token = "0x40009B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float b;
	}
	[Token(Token = "0x2000248")]
	public struct WVR_OverlayTexture_t
	{
		[Token(Token = "0x40009B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint textureId;

		[Token(Token = "0x40009B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint width;

		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint height;
	}
	[Token(Token = "0x2000249")]
	public struct WVR_ArenaRectangle_t
	{
		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float width;

		[Token(Token = "0x40009B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float length;
	}
	[Token(Token = "0x200024A")]
	public struct WVR_ArenaRound_t
	{
		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float diameter;
	}
	[StructLayout(2)]
	[Token(Token = "0x200024B")]
	public struct WVR_ArenaArea_t
	{
		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_ArenaRectangle_t rectangle;

		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_ArenaRound_t round;
	}
	[Token(Token = "0x200024C")]
	public struct WVR_Arena_t
	{
		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_ArenaShape shape;

		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public WVR_ArenaArea_t area;
	}
	[Token(Token = "0x200024D")]
	public delegate void WVR_OverlayInputEventCallback(int overlayId, WVR_EventType type, WVR_InputId inputId);
	[Token(Token = "0x200024E")]
	public struct WVR_OverlayInputEvent_t
	{
		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int overlayId;

		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public IntPtr callback;
	}
}
