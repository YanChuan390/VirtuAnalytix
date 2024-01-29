using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.CodeAnalysis;
using Oculus.Platform;
using Oculus.Platform.Models;
using TMPro;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702794", Offset = "0x702794")]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0xB0462C", Offset = "0xB0462C", VA = "0xB0462C")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7027CC", Offset = "0x7027CC")]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0xC126B0", Offset = "0xC126B0", VA = "0xC126B0")]
		public IsReadOnlyAttribute()
		{
		}
	}
}
[Token(Token = "0x2000004")]
public class RotateCamera : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float MouseRotateSpeed;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xB7CAF0", Offset = "0xB7CAF0", VA = "0xB7CAF0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xB7CAF4", Offset = "0xB7CAF4", VA = "0xB7CAF4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xB7CC1C", Offset = "0xB7CC1C", VA = "0xB7CC1C")]
	public RotateCamera()
	{
	}
}
[Token(Token = "0x2000005")]
public class AgentAction
{
	[Token(Token = "0x2000006")]
	public enum Posture
	{
		[Token(Token = "0x400000A")]
		Crouch,
		[Token(Token = "0x400000B")]
		Stand,
		[Token(Token = "0x400000C")]
		Jump
	}

	[Token(Token = "0x2000007")]
	public enum Action
	{
		[Token(Token = "0x400000E")]
		None,
		[Token(Token = "0x400000F")]
		Jab,
		[Token(Token = "0x4000010")]
		Kick,
		[Token(Token = "0x4000011")]
		Damage,
		[Token(Token = "0x4000012")]
		KO,
		[Token(Token = "0x4000013")]
		AttackCompleted,
		[Token(Token = "0x4000014")]
		AttackBlocked,
		[Token(Token = "0x4000015")]
		Uppercat,
		[Token(Token = "0x4000016")]
		Block,
		[Token(Token = "0x4000017")]
		Evade,
		[Token(Token = "0x4000018")]
		Hook,
		[Token(Token = "0x4000019")]
		Elbow,
		[Token(Token = "0x400001A")]
		BackFist,
		[Token(Token = "0x400001B")]
		BackSwing,
		[Token(Token = "0x400001C")]
		RoundKick,
		[Token(Token = "0x400001D")]
		AxeKick,
		[Token(Token = "0x400001E")]
		Push,
		[Token(Token = "0x400001F")]
		SlashPunch,
		[Token(Token = "0x4000020")]
		SlashKick,
		[Token(Token = "0x4000021")]
		Combo,
		[Token(Token = "0x4000022")]
		ComboCancel,
		[Token(Token = "0x4000023")]
		Overhand,
		[Token(Token = "0x4000024")]
		Special
	}

	[Token(Token = "0x2000008")]
	public enum ActionSide
	{
		[Token(Token = "0x4000026")]
		Left = -1,
		[Token(Token = "0x4000027")]
		Center,
		[Token(Token = "0x4000028")]
		Right
	}

	[Token(Token = "0x2000009")]
	public enum ActionHeight
	{
		[Token(Token = "0x400002A")]
		High = 1,
		[Token(Token = "0x400002B")]
		Center = 0,
		[Token(Token = "0x400002C")]
		Low = -1
	}

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70310C", Offset = "0x70310C")]
	private Vector2 <moveDirection>k__BackingField;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70311C", Offset = "0x70311C")]
	private Action <action>k__BackingField;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70312C", Offset = "0x70312C")]
	private ActionSide <actionSide>k__BackingField;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70313C", Offset = "0x70313C")]
	private ActionHeight <actionHeight>k__BackingField;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70314C", Offset = "0x70314C")]
	private Posture <posture>k__BackingField;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70315C", Offset = "0x70315C")]
	private int <subactionId>k__BackingField;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float angleDifference;

	[Token(Token = "0x17000001")]
	public Vector2 moveDirection
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0xCD514C", Offset = "0xCD514C", VA = "0xCD514C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705FF8", Offset = "0x705FF8")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000009")]
		[Address(RVA = "0xCD5154", Offset = "0xCD5154", VA = "0xCD5154")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706008", Offset = "0x706008")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public Action action
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0xCD515C", Offset = "0xCD515C", VA = "0xCD515C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706018", Offset = "0x706018")]
		get
		{
			return default(Action);
		}
		[Token(Token = "0x600000B")]
		[Address(RVA = "0xCD5164", Offset = "0xCD5164", VA = "0xCD5164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706028", Offset = "0x706028")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public ActionSide actionSide
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0xCD516C", Offset = "0xCD516C", VA = "0xCD516C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706038", Offset = "0x706038")]
		get
		{
			return default(ActionSide);
		}
		[Token(Token = "0x600000D")]
		[Address(RVA = "0xCD5174", Offset = "0xCD5174", VA = "0xCD5174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706048", Offset = "0x706048")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public ActionHeight actionHeight
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0xCD517C", Offset = "0xCD517C", VA = "0xCD517C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706058", Offset = "0x706058")]
		get
		{
			return default(ActionHeight);
		}
		[Token(Token = "0x600000F")]
		[Address(RVA = "0xCD5184", Offset = "0xCD5184", VA = "0xCD5184")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706068", Offset = "0x706068")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public Posture posture
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0xCD518C", Offset = "0xCD518C", VA = "0xCD518C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706078", Offset = "0x706078")]
		get
		{
			return default(Posture);
		}
		[Token(Token = "0x6000011")]
		[Address(RVA = "0xCD5194", Offset = "0xCD5194", VA = "0xCD5194")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706088", Offset = "0x706088")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public int subactionId
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0xCD519C", Offset = "0xCD519C", VA = "0xCD519C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706098", Offset = "0x706098")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000013")]
		[Address(RVA = "0xCD51A4", Offset = "0xCD51A4", VA = "0xCD51A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7060A8", Offset = "0x7060A8")]
		set
		{
		}
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xCD50D8", Offset = "0xCD50D8", VA = "0xCD50D8")]
	public AgentAction()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xCD50EC", Offset = "0xCD50EC", VA = "0xCD50EC")]
	public AgentAction(Action action, ActionSide side, ActionHeight height, Posture posture, int subactionId = 0)
	{
	}
}
[Token(Token = "0x200000A")]
public class AxeKickStartBehaviour : StateMachineBehaviour
{
	[Token(Token = "0x6000014")]
	[Address(RVA = "0xCD8520", Offset = "0xCD8520", VA = "0xCD8520", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xCD85D4", Offset = "0xCD85D4", VA = "0xCD85D4")]
	public AxeKickStartBehaviour()
	{
	}
}
[Token(Token = "0x200000B")]
public class BlockBehaviour : StateMachineBehaviour
{
	[Token(Token = "0x6000016")]
	[Address(RVA = "0xCD891C", Offset = "0xCD891C", VA = "0xCD891C", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xCD899C", Offset = "0xCD899C", VA = "0xCD899C", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xCD89BC", Offset = "0xCD89BC", VA = "0xCD89BC")]
	public BlockBehaviour()
	{
	}
}
[Token(Token = "0x200000C")]
public class ComboFinishBehaviour : StateMachineBehaviour
{
	[Token(Token = "0x6000019")]
	[Address(RVA = "0xAFA004", Offset = "0xAFA004", VA = "0xAFA004", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xAFA080", Offset = "0xAFA080", VA = "0xAFA080")]
	public ComboFinishBehaviour()
	{
	}
}
[Token(Token = "0x200000D")]
public class ComboStartBehaviour : StateMachineBehaviour
{
	[Token(Token = "0x600001B")]
	[Address(RVA = "0xAFA088", Offset = "0xAFA088", VA = "0xAFA088", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xAFA16C", Offset = "0xAFA16C", VA = "0xAFA16C")]
	public ComboStartBehaviour()
	{
	}
}
[Token(Token = "0x200000E")]
public class DamageBehaviour : StateMachineBehaviour
{
	[Token(Token = "0x600001D")]
	[Address(RVA = "0xAFF300", Offset = "0xAFF300", VA = "0xAFF300", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xAFF36C", Offset = "0xAFF36C", VA = "0xAFF36C")]
	public DamageBehaviour()
	{
	}
}
[Token(Token = "0x200000F")]
public class DuckBehaviour : StateMachineBehaviour
{
	[Token(Token = "0x600001F")]
	[Address(RVA = "0xB04584", Offset = "0xB04584", VA = "0xB04584", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xB04604", Offset = "0xB04604", VA = "0xB04604", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xB04624", Offset = "0xB04624", VA = "0xB04624")]
	public DuckBehaviour()
	{
	}
}
[Token(Token = "0x2000010")]
public class EvasionBehaviour : StateMachineBehaviour
{
	[Token(Token = "0x6000022")]
	[Address(RVA = "0xB0469C", Offset = "0xB0469C", VA = "0xB0469C", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xB0471C", Offset = "0xB0471C", VA = "0xB0471C", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xB0473C", Offset = "0xB0473C", VA = "0xB0473C")]
	public EvasionBehaviour()
	{
	}
}
[Token(Token = "0x2000011")]
public class IdleBehaviour : StateMachineBehaviour
{
	[Token(Token = "0x6000025")]
	[Address(RVA = "0xC0FBAC", Offset = "0xC0FBAC", VA = "0xC0FBAC", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xC0FC18", Offset = "0xC0FC18", VA = "0xC0FC18")]
	public IdleBehaviour()
	{
	}
}
[Token(Token = "0x2000012")]
public class PushBehaviour : StateMachineBehaviour
{
	[Token(Token = "0x6000027")]
	[Address(RVA = "0xB7AE48", Offset = "0xB7AE48", VA = "0xB7AE48", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xB7AEB4", Offset = "0xB7AEB4", VA = "0xB7AEB4")]
	public PushBehaviour()
	{
	}
}
[Token(Token = "0x2000013")]
public class SingleAttackBehaviour : StateMachineBehaviour
{
	[Token(Token = "0x6000029")]
	[Address(RVA = "0xB7FDBC", Offset = "0xB7FDBC", VA = "0xB7FDBC", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xB7FE8C", Offset = "0xB7FE8C", VA = "0xB7FE8C", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xB7FF08", Offset = "0xB7FF08", VA = "0xB7FF08")]
	public SingleAttackBehaviour()
	{
	}
}
[Token(Token = "0x2000014")]
public class SlashAttackBehaviour : StateMachineBehaviour
{
	[Token(Token = "0x600002C")]
	[Address(RVA = "0xB7FF10", Offset = "0xB7FF10", VA = "0xB7FF10", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xB80018", Offset = "0xB80018", VA = "0xB80018", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xB80094", Offset = "0xB80094", VA = "0xB80094")]
	public SlashAttackBehaviour()
	{
	}
}
[Token(Token = "0x2000015")]
public class SpecialBehaviour : StateMachineBehaviour
{
	[Token(Token = "0x600002F")]
	[Address(RVA = "0xB80E70", Offset = "0xB80E70", VA = "0xB80E70", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xB80F54", Offset = "0xB80F54", VA = "0xB80F54", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xB80FD0", Offset = "0xB80FD0", VA = "0xB80FD0")]
	public SpecialBehaviour()
	{
	}
}
[Token(Token = "0x2000016")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x702804", Offset = "0x702804")]
public class CharacterAgent : MonoBehaviour
{
	[Token(Token = "0x2000017")]
	public struct PotencialHit
	{
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 position;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 direction;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float distance;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string location;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool backwardAngle;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool tryCrouch;
	}

	[Serializable]
	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702864", Offset = "0x702864")]
	private sealed class <>c
	{
		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<CharacterStatus.EstimatedAttackAction> <>9__82_0;

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x19517A4", Offset = "0x19517A4", VA = "0x19517A4")]
		public <>c()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x19517AC", Offset = "0x19517AC", VA = "0x19517AC")]
		internal int <getAction>b__82_0(CharacterStatus.EstimatedAttackAction x, CharacterStatus.EstimatedAttackAction y)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702874", Offset = "0x702874")]
	private sealed class <PushCharacter>d__99 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CharacterAgent <>4__this;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 direction;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float multiplier;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <t>5__2;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x1951AD4", Offset = "0x1951AD4", VA = "0x1951AD4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x1951B1C", Offset = "0x1951B1C", VA = "0x1951B1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x19517E4", Offset = "0x19517E4", VA = "0x19517E4")]
		[DebuggerHidden]
		public <PushCharacter>d__99(int <>1__state)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1951810", Offset = "0x1951810", VA = "0x1951810", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1951814", Offset = "0x1951814", VA = "0x1951814", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1951ADC", Offset = "0x1951ADC", VA = "0x1951ADC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CharacterStatus status;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private PlayerStatus playerStatus;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private PlayerAgent playerAgent;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject playerPartialHeadCollider;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string targetTag;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject target;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Animator agentAnimator;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject rig;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject hitParticlesPrefab;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject defenseParticlePrefab;

	[Token(Token = "0x4000037")]
	public const float MIN_PLAYER_ATTACK_DISTANCE = 0.15f;

	[Token(Token = "0x4000038")]
	public const float PLAYER_ATTACK_CROUCH_DISTANCE = 1f;

	[Token(Token = "0x4000039")]
	public const float PLAYER_ATTACK_CROUCH_HEIGHT = 1.25f;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float minBlockDistance;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float retireStamina;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float retireDistance;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float maxTimeWithoutAttack;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float minStaminaForKick;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float attackRotationMultiplier;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float moveRotationMultiplier;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float playerApproachingStopMoveDistance;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float playerApproachingMinVelocity;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public float minDistanceForNotFrontalMove;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float maxDistanceForNotFrontalMove;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public float idleRandomRangeMin;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float idleRandomRangeMax;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float backMoveRandomRangeMin;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float backMoveRandomRangeMax;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float rightMoveRandomRangeMin;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float rightMoveRandomRangeMax;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public float leftMoveRandomRangeMin;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float leftMoveRandomRangeMax;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public int attackSelectionQuantity;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public float closestDistanceToPlayer;

	[Token(Token = "0x400004F")]
	private const float MIN_BOUND_DISTANCE = 0.25f;

	[Token(Token = "0x4000050")]
	private const float MAX_MOVE_DISTANCE = 1.5f;

	[Token(Token = "0x4000051")]
	private const float MAX_FRONTAL_MOVE_DISTANCE = 2f;

	[Token(Token = "0x4000052")]
	private const float EVASION_DISTANCE = 2f;

	[Token(Token = "0x4000053")]
	private const float LATERAL_EVASION_DISTANCE = 1.7f;

	[Token(Token = "0x4000054")]
	private const float SPECIAL_CLOSE_DISTANCE = 1.75f;

	[Token(Token = "0x4000055")]
	private const float SPECIAL_MEDIUM_DISTANCE = 2.5f;

	[Token(Token = "0x4000056")]
	private const float MIN_POTENCIAL_HIT_DISTANCE = 0.5f;

	[Token(Token = "0x4000057")]
	private const float MIN_PUSH_ACTION_ANGLE = 45f;

	[Token(Token = "0x4000058")]
	private const float MAX_PUSH_DISTANCE_FROM_CENTER = 1.5f;

	[Token(Token = "0x4000059")]
	private const float MAX_PUSH_FORWARD_TO_PLAYER_ANGLE = 130f;

	[Token(Token = "0x400005A")]
	private const float ANIMATION_UPDATE = 0.001f;

	[Token(Token = "0x400005B")]
	private const float STUN_COUNTER_TIME = 3f;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private FrameRateCounterAndDebugInfo debugInfo;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float maxPlayerDamage;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float lastPlayerDamage;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float sumPlayerDamage;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private int totalPlayerDamaging;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public float maxCharacterDamage;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public float lastCharacterDamage;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public float sumCharacterDamage;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public int totalCharacterDamaging;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private System.Random random;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private AudioSource rightHandAudioSource;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private AudioSource leftHandAudioSource;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private AudioSource rightFootAudioSource;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private AudioSource leftFootAudioSource;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private AudioSource positionAudioSource;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private AudioSource mouthAudioSource;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public AudioClip attackMoveSound;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public AudioClip blockSound;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public AudioClip hitSound;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public AudioClip pushSound;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public AudioClip slashAttackSound;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public AudioClip comboStepSound;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public AudioClip comboAttackMoveSound;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public AudioClip specialChargeSound;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public AudioClip specialExecuteSound;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public TutorialController tutorialController;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public SpecialTutorialController specialtutorialController;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private bool pushCorroutineActivated;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
	private int accumulatedStunHits;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private float stunTimeCounter;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	private float reducedStunTimeCounter;

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xCDFE08", Offset = "0xCDFE08", VA = "0xCDFE08")]
	private void Start()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xCE023C", Offset = "0xCE023C", VA = "0xCE023C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xCE0DB0", Offset = "0xCE0DB0", VA = "0xCE0DB0")]
	private void ApplyAction(AgentAction action)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xCE03E0", Offset = "0xCE03E0", VA = "0xCE03E0")]
	protected AgentAction getAction()
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xCE275C", Offset = "0xCE275C", VA = "0xCE275C")]
	private bool checkPushMove(AgentAction action, float distance, Vector3 distance3D)
	{
		return default(bool);
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xCE24E4", Offset = "0xCE24E4", VA = "0xCE24E4")]
	private bool checkCurrentMove(AgentAction action, bool attackPriority, Vector3 characterGround, float characterPositionMagnitude, float distance, Vector3 distance3D)
	{
		return default(bool);
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xCE22DC", Offset = "0xCE22DC", VA = "0xCE22DC")]
	private bool checkDuckMove(AgentAction action, bool highAttack, PotencialHit potencialHit)
	{
		return default(bool);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xCE2348", Offset = "0xCE2348", VA = "0xCE2348")]
	private bool checkBlockMove(AgentAction action, bool highAttack, PotencialHit potencialHit)
	{
		return default(bool);
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xCE1B98", Offset = "0xCE1B98", VA = "0xCE1B98")]
	private bool checkEvasionMove(AgentAction action, Vector3 characterGround, float characterPositionMagnitude, PotencialHit potencialHit, bool special = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xCE2998", Offset = "0xCE2998", VA = "0xCE2998")]
	public bool decideRandomMove(Vector3 characterGround, float characterPositionMagnitude, AgentAction action)
	{
		return default(bool);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xCE2904", Offset = "0xCE2904", VA = "0xCE2904")]
	public bool TestMove(Vector3 moveDir, Vector3 characterGround, float characterPositionMagnitude, float minBoundDistance)
	{
		return default(bool);
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xCE2C4C", Offset = "0xCE2C4C", VA = "0xCE2C4C")]
	public static Vector2 rotate(Vector2 v, float delta)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xCE2CC4", Offset = "0xCE2CC4", VA = "0xCE2CC4")]
	public void PlayerCollision(PlayerCollisionInfo collisionInfo)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xCE3B6C", Offset = "0xCE3B6C", VA = "0xCE3B6C")]
	public void ApplySpecialDamage(Vector3 direction, float damage, int collisionHeight, int collisionSide, bool characterHitFromBack)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xCE3970", Offset = "0xCE3970", VA = "0xCE3970")]
	private float GetReceivedDamage(PlayerCollisionInfo collisionInfo)
	{
		return default(float);
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xCE1660", Offset = "0xCE1660", VA = "0xCE1660")]
	private PotencialHit CloserAvoidablePlayerSpecialAttackHit()
	{
		return default(PotencialHit);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xCE1EB0", Offset = "0xCE1EB0", VA = "0xCE1EB0")]
	private PotencialHit CloserAvoidablePlayerAttackHit()
	{
		return default(PotencialHit);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xCE3440", Offset = "0xCE3440", VA = "0xCE3440")]
	private bool IsPlayerAttackStarted(PlayerCollisionInfo collisionInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xCE3DB0", Offset = "0xCE3DB0", VA = "0xCE3DB0")]
	public void CompleteAttack(bool blocked)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xCE3E78", Offset = "0xCE3E78", VA = "0xCE3E78")]
	private GameObject FindChildPosition(GameObject obj, string name)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xCE3ACC", Offset = "0xCE3ACC", VA = "0xCE3ACC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7060B8", Offset = "0x7060B8")]
	private IEnumerator PushCharacter(Vector3 direction, float multiplier)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xCE4268", Offset = "0xCE4268", VA = "0xCE4268")]
	private bool CanPlayAttackSound(int isCombo)
	{
		return default(bool);
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xCE42A8", Offset = "0xCE42A8", VA = "0xCE42A8")]
	public void RightHandAttackSound(int isCombo)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xCE43CC", Offset = "0xCE43CC", VA = "0xCE43CC")]
	public void LeftHandAttackSound(int isCombo)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xCE448C", Offset = "0xCE448C", VA = "0xCE448C")]
	public void RightFootAttackSound(int isCombo)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xCE454C", Offset = "0xCE454C", VA = "0xCE454C")]
	public void LeftFootAttackSound(int isCombo)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xCE39E8", Offset = "0xCE39E8", VA = "0xCE39E8")]
	public void PlayHitSound(PlayerCollisionInfo collisionInfo, bool block)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xCE460C", Offset = "0xCE460C", VA = "0xCE460C")]
	public void PlayPushSound()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xCE4368", Offset = "0xCE4368", VA = "0xCE4368")]
	public void PlayComboStepSound()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xCE4670", Offset = "0xCE4670", VA = "0xCE4670")]
	public void PlaySlashAttackSound()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xCE46D4", Offset = "0xCE46D4", VA = "0xCE46D4")]
	public void PlaySpecialChargeSound()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xCE4738", Offset = "0xCE4738", VA = "0xCE4738")]
	public void PlaySpecialExecuteSound()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xCE479C", Offset = "0xCE479C", VA = "0xCE479C")]
	public GameObject GetTarget()
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xCE47A4", Offset = "0xCE47A4", VA = "0xCE47A4")]
	public void CancelCombo()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xCDF05C", Offset = "0xCDF05C", VA = "0xCDF05C")]
	public void StopMovement()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xCDEF54", Offset = "0xCDEF54", VA = "0xCDEF54")]
	public void ResetAnimator()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xCE32FC", Offset = "0xCE32FC", VA = "0xCE32FC")]
	private bool IsCombatStarted()
	{
		return default(bool);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xCE484C", Offset = "0xCE484C", VA = "0xCE484C")]
	public CharacterAgent()
	{
	}
}
[Token(Token = "0x200001A")]
public class CharacterStatus : MonoBehaviour
{
	[Token(Token = "0x200001B")]
	public struct EstimatedAttackAction
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70319C", Offset = "0x70319C")]
		private AgentAction <action>k__BackingField;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7031AC", Offset = "0x7031AC")]
		private float <estimatedDamage>k__BackingField;

		[Token(Token = "0x1700000C")]
		public AgentAction action
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x1951DA8", Offset = "0x1951DA8", VA = "0x1951DA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7061C8", Offset = "0x7061C8")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x1951DB0", Offset = "0x1951DB0", VA = "0x1951DB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706200", Offset = "0x706200")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public float estimatedDamage
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x1951DB8", Offset = "0x1951DB8", VA = "0x1951DB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706210", Offset = "0x706210")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x1951DC0", Offset = "0x1951DC0", VA = "0x1951DC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706248", Offset = "0x706248")]
			set
			{
			}
		}
	}

	[Token(Token = "0x200001C")]
	public struct SpecialDescription
	{
		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7031BC", Offset = "0x7031BC")]
		private int <specialId>k__BackingField;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7031CC", Offset = "0x7031CC")]
		private string <prefabName>k__BackingField;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7031DC", Offset = "0x7031DC")]
		private Vector3 <initialPosition>k__BackingField;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7031EC", Offset = "0x7031EC")]
		private Vector3 <executeParticlesPosition>k__BackingField;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7031FC", Offset = "0x7031FC")]
		private SpecialCondition <conditions>k__BackingField;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70320C", Offset = "0x70320C")]
		private float <maxLifetime>k__BackingField;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70321C", Offset = "0x70321C")]
		private bool <attached>k__BackingField;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70322C", Offset = "0x70322C")]
		private float <cooldown>k__BackingField;

		[Token(Token = "0x1700000E")]
		public int specialId
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x1951DC8", Offset = "0x1951DC8", VA = "0x1951DC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706258", Offset = "0x706258")]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x1951DD0", Offset = "0x1951DD0", VA = "0x1951DD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706290", Offset = "0x706290")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public string prefabName
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x1951DD8", Offset = "0x1951DD8", VA = "0x1951DD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7062A0", Offset = "0x7062A0")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x1951DE0", Offset = "0x1951DE0", VA = "0x1951DE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7062D8", Offset = "0x7062D8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public Vector3 initialPosition
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x1951DE8", Offset = "0x1951DE8", VA = "0x1951DE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7062E8", Offset = "0x7062E8")]
			readonly get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x1951DF4", Offset = "0x1951DF4", VA = "0x1951DF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706320", Offset = "0x706320")]
			private set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public Vector3 executeParticlesPosition
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x1951E00", Offset = "0x1951E00", VA = "0x1951E00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706330", Offset = "0x706330")]
			readonly get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x1951E0C", Offset = "0x1951E0C", VA = "0x1951E0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706368", Offset = "0x706368")]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public SpecialCondition conditions
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x1951E18", Offset = "0x1951E18", VA = "0x1951E18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706378", Offset = "0x706378")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x1951E20", Offset = "0x1951E20", VA = "0x1951E20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7063B0", Offset = "0x7063B0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public float maxLifetime
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x1951E28", Offset = "0x1951E28", VA = "0x1951E28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7063C0", Offset = "0x7063C0")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x1951E30", Offset = "0x1951E30", VA = "0x1951E30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7063F8", Offset = "0x7063F8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public bool attached
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x1951E38", Offset = "0x1951E38", VA = "0x1951E38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706408", Offset = "0x706408")]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x1951E40", Offset = "0x1951E40", VA = "0x1951E40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706440", Offset = "0x706440")]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public float cooldown
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x1951E4C", Offset = "0x1951E4C", VA = "0x1951E4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706450", Offset = "0x706450")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x1951E54", Offset = "0x1951E54", VA = "0x1951E54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706488", Offset = "0x706488")]
			private set
			{
			}
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1951E5C", Offset = "0x1951E5C", VA = "0x1951E5C")]
		public SpecialDescription(int specialId, string prefabName, Vector3 initialPosition, SpecialCondition conditions, float maxLifetime, bool attached = false, float cooldown = 0f)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1951EF0", Offset = "0x1951EF0", VA = "0x1951EF0")]
		public SpecialDescription(int specialId, string prefabName, Vector3 initialPosition, Vector3 initialExecutePanticlesPos, SpecialCondition conditions, float maxLifetime, bool attached = false, float cooldown = 0f)
		{
		}
	}

	[Token(Token = "0x200001D")]
	public struct AttackDescription
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70323C", Offset = "0x70323C")]
		private float <baseDamage>k__BackingField;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public List<string> attackParts;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float minZDistance;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float minDistance;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxDistance;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 attackDirection;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 attackPosition;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 attackOrigin;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AgentAction attackAction;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string attackName;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject attackParticles;

		[Token(Token = "0x17000016")]
		public float baseDamage
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x1951B24", Offset = "0x1951B24", VA = "0x1951B24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706498", Offset = "0x706498")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x1951B2C", Offset = "0x1951B2C", VA = "0x1951B2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7064D0", Offset = "0x7064D0")]
			private set
			{
			}
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1951B34", Offset = "0x1951B34", VA = "0x1951B34")]
		public AttackDescription(string name, float damage, List<string> parts, float startZDist, Vector3 direction, Vector3 position, AgentAction action, GameObject particles)
		{
		}
	}

	[Token(Token = "0x200001E")]
	public enum ComboStepType
	{
		[Token(Token = "0x4000101")]
		None,
		[Token(Token = "0x4000102")]
		Punch,
		[Token(Token = "0x4000103")]
		Kick
	}

	[Token(Token = "0x200001F")]
	public struct ComboNextStepInfo
	{
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70324C", Offset = "0x70324C")]
		private float <attackMaxFrontalDistance>k__BackingField;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70325C", Offset = "0x70325C")]
		private float <attackMaxSideDistance>k__BackingField;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70326C", Offset = "0x70326C")]
		private List<string> <attackParts>k__BackingField;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70327C", Offset = "0x70327C")]
		private GameObject <attackParticles>k__BackingField;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70328C", Offset = "0x70328C")]
		private ComboStepType <stepType>k__BackingField;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70329C", Offset = "0x70329C")]
		private float <baseDamage>k__BackingField;

		[Token(Token = "0x17000017")]
		public float attackMaxFrontalDistance
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x1951CEC", Offset = "0x1951CEC", VA = "0x1951CEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7064E0", Offset = "0x7064E0")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x1951CF4", Offset = "0x1951CF4", VA = "0x1951CF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706518", Offset = "0x706518")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public float attackMaxSideDistance
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x1951CFC", Offset = "0x1951CFC", VA = "0x1951CFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706528", Offset = "0x706528")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x1951D04", Offset = "0x1951D04", VA = "0x1951D04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706560", Offset = "0x706560")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public List<string> attackParts
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x1951D0C", Offset = "0x1951D0C", VA = "0x1951D0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706570", Offset = "0x706570")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x1951D14", Offset = "0x1951D14", VA = "0x1951D14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7065A8", Offset = "0x7065A8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public GameObject attackParticles
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x1951D1C", Offset = "0x1951D1C", VA = "0x1951D1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7065B8", Offset = "0x7065B8")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x1951D24", Offset = "0x1951D24", VA = "0x1951D24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7065F0", Offset = "0x7065F0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public ComboStepType stepType
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x1951D2C", Offset = "0x1951D2C", VA = "0x1951D2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706600", Offset = "0x706600")]
			readonly get
			{
				return default(ComboStepType);
			}
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x1951D34", Offset = "0x1951D34", VA = "0x1951D34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706638", Offset = "0x706638")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public float baseDamage
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x1951D3C", Offset = "0x1951D3C", VA = "0x1951D3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706648", Offset = "0x706648")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x1951D44", Offset = "0x1951D44", VA = "0x1951D44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706680", Offset = "0x706680")]
			private set
			{
			}
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1951D4C", Offset = "0x1951D4C", VA = "0x1951D4C")]
		public ComboNextStepInfo(float maxFrontalDistance, float maxSideDistance, float stepBaseDamage, List<string> parts, GameObject particles, ComboStepType type)
		{
		}
	}

	[Token(Token = "0x2000020")]
	public struct ComboDescription
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AttackDescription startingAttack;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ComboStepType firstStepType;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public ComboNextStepInfo[] nextSteps;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float totalBaseDamage;

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1951C40", Offset = "0x1951C40", VA = "0x1951C40")]
		public ComboDescription(AttackDescription startingAttack, ComboStepType firstStepType, float totalBaseDamage, int stepsCount)
		{
		}
	}

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float health;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float mana;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxMana;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float manaRecovery;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float initialHealth;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float specialSpeed;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float attackSpeed;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float defenseSpeed;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float slashMoveSpeed;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float slashSpecialSpeed;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float damageMultiplier;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float stunMultiplier;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int maxContinuousStunHits;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float reducedStunTime;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float stamina;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float initialStamina;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float staminaRecovery;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float minSingleAttackPunchRecharge;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float maxSingleAttackPunchRecharge;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float minSingleAttackKickRecharge;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float maxSingleAttackKickRecharge;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float minSingleAttackBackFistRecharge;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float maxSingleAttackBackFistRecharge;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float minSingleAttackRoundKickRecharge;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float maxSingleAttackRoundKickRecharge;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float minSingleAttackAxeKickRecharge;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float maxSingleAttackAxeKickRecharge;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float minSingleAttackRoundRecharge;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float maxSingleAttackRoundRecharge;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public float minSingleAttackSlashRecharge;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float maxSingleAttackSlashRecharge;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public float minAttackRecharge;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float maxAttackRecharge;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float minComboRecharge;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float maxComboRecharge;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float minSpecialRecharge;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float maxSpecialRecharge;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public int maxAttackCadence5s;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Texture2D texture;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Texture2D textureFullBody;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private List<float> attacksTime;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float specialRecharge;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float comboAttackRecharge;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float attackRecharge;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private float singleAttackPunchRecharge;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float singleAttackKickRecharge;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float singleAttackRoundKickRecharge;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float singleAttackAxeKickRecharge;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private float singleAttackBackFistRecharge;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float singleAttackRoundRecharge;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private float singleAttackSlashRecharge;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool singleAttackRetiring;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private Vector3 startingMovePosition;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private float notMoveTimeOrDistance;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private Vector2 nextMove;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70316C", Offset = "0x70316C")]
	private bool <berserkActive>k__BackingField;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10D")]
	private bool attackCompleted;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10E")]
	private bool notFrontalMoving;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10F")]
	private bool frontalMove;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70317C", Offset = "0x70317C")]
	private bool <characterSlashing>k__BackingField;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private AgentAction.Action currentAttack;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private int currentComboId;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private int currentComboStep;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private int currentSpecialId;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private int lastAttackNameHash;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private int lastAttackRepetitions;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70318C", Offset = "0x70318C")]
	private float <timeFromLastAttack>k__BackingField;

	[Token(Token = "0x40000CC")]
	private const int MAX_ATTACK_REPETITION = 2;

	[Token(Token = "0x40000CD")]
	private const float MAX_ATTACK_REPETITION_RESET = 3f;

	[Token(Token = "0x40000CE")]
	private const float MIN_COMBO_STAMINA = 2f;

	[Token(Token = "0x40000CF")]
	private const float SPECIAL_STAMINA = 1.5f;

	[Token(Token = "0x40000D0")]
	private const float COMBO_PUNCH_STEP_ATTACK_STAMINA = 1f;

	[Token(Token = "0x40000D1")]
	private const float COMBO_KICK_STEP_ATTACK_STAMINA = 1.5f;

	[Token(Token = "0x40000D2")]
	private const float SLASH_KICK_ATTACK_STAMINA = 2.5f;

	[Token(Token = "0x40000D3")]
	private const float SLASH_PUNCH_ATTACK_STAMINA = 2f;

	[Token(Token = "0x40000D4")]
	private const float PUNCH_ATTACK_STAMINA = 1f;

	[Token(Token = "0x40000D5")]
	private const float KICK_ATTACK_STAMINA = 1.5f;

	[Token(Token = "0x40000D6")]
	private const float EVASION_STAMINA = 0.5f;

	[Token(Token = "0x40000D7")]
	private const float DUCK_STAMINA = 0.25f;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private CharacterAgent agent;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private GameObject leftHandParticles;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private GameObject rightHandParticles;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private GameObject leftFootParticles;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private GameObject rightFootParticles;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private GameObject rightHandSpecialParticles;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private GameObject leftHandSpecialParticles;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public GameObject specialExecuteParticles;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private GameObject leftHandBerserkParticles;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private GameObject rightHandBerserkParticles;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private Material characterMaterial;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public List<string> characterAttacks;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public List<int> characterCombos;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public List<int> characterSpecials;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private Dictionary<int, float> specialCoolDown;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private List<int> coolDownToDelete;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private Dictionary<int, AttackDescription> attacks;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private Dictionary<int, ComboDescription> combos;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private Dictionary<int, SpecialDescription> specials;

	[Token(Token = "0x17000009")]
	public bool berserkActive
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x15A9BBC", Offset = "0x15A9BBC", VA = "0x15A9BBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706168", Offset = "0x706168")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x15A9BC4", Offset = "0x15A9BC4", VA = "0x15A9BC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706178", Offset = "0x706178")]
		private set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public bool characterSlashing
	{
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x15A9BD0", Offset = "0x15A9BD0", VA = "0x15A9BD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706188", Offset = "0x706188")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x15A9BD8", Offset = "0x15A9BD8", VA = "0x15A9BD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706198", Offset = "0x706198")]
		private set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public float timeFromLastAttack
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x15A9BE4", Offset = "0x15A9BE4", VA = "0x15A9BE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7061A8", Offset = "0x7061A8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x15A9BEC", Offset = "0x15A9BEC", VA = "0x15A9BEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7061B8", Offset = "0x7061B8")]
		private set
		{
		}
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x15A9BF4", Offset = "0x15A9BF4", VA = "0x15A9BF4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x15AA010", Offset = "0x15AA010", VA = "0x15AA010")]
	private void initAttacksList()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x15B2A80", Offset = "0x15B2A80", VA = "0x15B2A80")]
	private void Update()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x15B31D0", Offset = "0x15B31D0", VA = "0x15B31D0")]
	public void ResetStatus()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x15B3264", Offset = "0x15B3264", VA = "0x15B3264")]
	public void SaveStatus()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x15B28D8", Offset = "0x15B28D8", VA = "0x15B28D8")]
	private void RestoreStatus()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x15B311C", Offset = "0x15B311C", VA = "0x15B311C")]
	private void UpdateAttacksTime()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x15B356C", Offset = "0x15B356C", VA = "0x15B356C")]
	public void IncreaseMana(float damage)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x15B35A8", Offset = "0x15B35A8", VA = "0x15B35A8")]
	public void ApplyDamage(float damage)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x15B3608", Offset = "0x15B3608", VA = "0x15B3608")]
	public AttackDescription GetAttackDescription(int hash)
	{
		return default(AttackDescription);
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x15B37B8", Offset = "0x15B37B8", VA = "0x15B37B8")]
	public float CalculateComboAttackDamage(float characterToPlayerDamageMultiplier, string characterPart)
	{
		return default(float);
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x15B3B0C", Offset = "0x15B3B0C", VA = "0x15B3B0C")]
	public float CalculateAttackDamage(AnimatorStateInfo animatorState, float characterToPlayerDamageMultiplier, string characterPart)
	{
		return default(float);
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x15B3A38", Offset = "0x15B3A38", VA = "0x15B3A38")]
	public float CalculateAttackDamage(AttackDescription attack, float characterToPlayerDamageMultiplier, string characterPart)
	{
		return default(float);
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x15B3ADC", Offset = "0x15B3ADC", VA = "0x15B3ADC")]
	public float CalculateDamage(float baseDamage, float characterToPlayerDamageMultiplier)
	{
		return default(float);
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x15B3BE4", Offset = "0x15B3BE4", VA = "0x15B3BE4")]
	public bool CanStartSingleAttack()
	{
		return default(bool);
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x15B3CA4", Offset = "0x15B3CA4", VA = "0x15B3CA4")]
	public bool CanStartSpecial()
	{
		return default(bool);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x15B3CF0", Offset = "0x15B3CF0", VA = "0x15B3CF0")]
	public bool CanStartCombo()
	{
		return default(bool);
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x15B3D2C", Offset = "0x15B3D2C", VA = "0x15B3D2C")]
	public bool CheckCadence()
	{
		return default(bool);
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x15B3D8C", Offset = "0x15B3D8C", VA = "0x15B3D8C")]
	public bool CanStartAttackType(AgentAction.Action action)
	{
		return default(bool);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x15B3FB4", Offset = "0x15B3FB4", VA = "0x15B3FB4")]
	public bool CanStartEvasion()
	{
		return default(bool);
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x15B3FD8", Offset = "0x15B3FD8", VA = "0x15B3FD8")]
	public bool CanStartDuck()
	{
		return default(bool);
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x15B3FFC", Offset = "0x15B3FFC", VA = "0x15B3FFC")]
	public bool IsCompatibleAttack(AnimatorStateInfo animatorState, string characterPart)
	{
		return default(bool);
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x15B3924", Offset = "0x15B3924", VA = "0x15B3924")]
	public bool IsCompatibleComboAttack(string characterPart)
	{
		return default(bool);
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x15B3B80", Offset = "0x15B3B80", VA = "0x15B3B80")]
	private bool IsCompatibleAttack(AttackDescription attack, string characterPart)
	{
		return default(bool);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x15B40B0", Offset = "0x15B40B0", VA = "0x15B40B0")]
	public float GetHealthNormalized()
	{
		return default(float);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x15B40C0", Offset = "0x15B40C0", VA = "0x15B40C0")]
	public void AttackRetiring()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x15B40CC", Offset = "0x15B40CC", VA = "0x15B40CC")]
	public void CompleteAttack()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x15B454C", Offset = "0x15B454C", VA = "0x15B454C")]
	public bool StartAttack(int action, int attackId, bool removeStamina = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x15B49C0", Offset = "0x15B49C0", VA = "0x15B49C0")]
	public void ExecuteSpecial()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x15B4C24", Offset = "0x15B4C24", VA = "0x15B4C24")]
	private void createSpecial()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x15B4F80", Offset = "0x15B4F80", VA = "0x15B4F80")]
	public void StartBlock()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x15B4F88", Offset = "0x15B4F88", VA = "0x15B4F88")]
	public void StartDuck()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x15B4FBC", Offset = "0x15B4FBC", VA = "0x15B4FBC")]
	public void StartEvasion()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x15B4FF0", Offset = "0x15B4FF0", VA = "0x15B4FF0")]
	public void SlashStart()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x15B325C", Offset = "0x15B325C", VA = "0x15B325C")]
	public void SlashEnd()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x15B5024", Offset = "0x15B5024", VA = "0x15B5024")]
	public void StartPush()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x15B502C", Offset = "0x15B502C", VA = "0x15B502C")]
	public void ComboNextStep()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x15B55A0", Offset = "0x15B55A0", VA = "0x15B55A0")]
	private void cancelComboStep()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x15B5280", Offset = "0x15B5280", VA = "0x15B5280")]
	public bool checkStepDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x15B5604", Offset = "0x15B5604", VA = "0x15B5604")]
	public bool IsLastComboStep()
	{
		return default(bool);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x15B569C", Offset = "0x15B569C", VA = "0x15B569C")]
	public bool IsAttackCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x15B56A4", Offset = "0x15B56A4", VA = "0x15B56A4")]
	public AgentAction.Action GetCurrentAttack()
	{
		return default(AgentAction.Action);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x15B56AC", Offset = "0x15B56AC", VA = "0x15B56AC")]
	public int GetCurrentComboId()
	{
		return default(int);
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x15B56B4", Offset = "0x15B56B4", VA = "0x15B56B4")]
	public int GetCurrentComboStep()
	{
		return default(int);
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x15B56BC", Offset = "0x15B56BC", VA = "0x15B56BC")]
	public void StartFrontalMove(Vector2 move, float maxMoveOrTime)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x15B5730", Offset = "0x15B5730", VA = "0x15B5730")]
	public void CompleteFrontalMove()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x15B5760", Offset = "0x15B5760", VA = "0x15B5760")]
	public bool IsFrontalMoving()
	{
		return default(bool);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x15B5768", Offset = "0x15B5768", VA = "0x15B5768")]
	public void StartNotFrontalMove(Vector2 move, float maxMoveOrTime)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x15B57EC", Offset = "0x15B57EC", VA = "0x15B57EC")]
	public void CompleteNotFrontalMove()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x15B581C", Offset = "0x15B581C", VA = "0x15B581C")]
	public Vector2 GetCurrentMove()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x15B5848", Offset = "0x15B5848", VA = "0x15B5848")]
	public bool IsNotFrontalMoving()
	{
		return default(bool);
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x15B5850", Offset = "0x15B5850", VA = "0x15B5850")]
	public float GetPendingMove()
	{
		return default(float);
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x15B5904", Offset = "0x15B5904", VA = "0x15B5904")]
	public List<AgentAction> GetPossibleSpecials(GameObject player)
	{
		return null;
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x15B5BF8", Offset = "0x15B5BF8", VA = "0x15B5BF8")]
	public List<EstimatedAttackAction> GetPossibleCombos(GameObject player)
	{
		return null;
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x15B62A4", Offset = "0x15B62A4", VA = "0x15B62A4")]
	public List<EstimatedAttackAction> GetPossibleAttacks(GameObject player, bool includeCrouch)
	{
		return null;
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x15B6974", Offset = "0x15B6974", VA = "0x15B6974")]
	public void StopAttacksParticles()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x15B4968", Offset = "0x15B4968", VA = "0x15B4968")]
	public void activateSpecialChargeParticlesAndSound()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x15B4508", Offset = "0x15B4508", VA = "0x15B4508")]
	public void deactivateSpecialHandParticles()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x15B69E0", Offset = "0x15B69E0", VA = "0x15B69E0")]
	private void activateBerserkParticles()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x15B6A24", Offset = "0x15B6A24", VA = "0x15B6A24")]
	private void deactivateBerserkParticles()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x15B6A68", Offset = "0x15B6A68", VA = "0x15B6A68")]
	public void activateBerserk()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x15A9F50", Offset = "0x15A9F50", VA = "0x15A9F50")]
	public void deactivateBerserk(bool resetStamina = true)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x15B6B28", Offset = "0x15B6B28", VA = "0x15B6B28")]
	public CharacterStatus()
	{
	}
}
[Token(Token = "0x2000021")]
public class FightingAreaRotator : MonoBehaviour
{
	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float rotation;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fadeMultiplier;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool fadeIn;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	private static bool fadeOut;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material m;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float initialAlpha;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Color c;

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xB0556C", Offset = "0xB0556C", VA = "0xB0556C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xB05668", Offset = "0xB05668", VA = "0xB05668")]
	private void Update()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xB05964", Offset = "0xB05964", VA = "0xB05964")]
	public static void FadeOut()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xB059D8", Offset = "0xB059D8", VA = "0xB059D8")]
	public static void FadeIn()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xB05A4C", Offset = "0xB05A4C", VA = "0xB05A4C")]
	public FightingAreaRotator()
	{
	}
}
[Token(Token = "0x2000022")]
public class ChampionshipControl : MonoBehaviour
{
	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702884", Offset = "0x702884")]
	private sealed class <FinishRoundCamvasFadeIn>d__96 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ChampionshipControl <>4__this;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CanvasGroup <loseCanvasgroup>5__2;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CanvasGroup <winCanvasGroup>5__3;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CanvasGroup <vsCanavasGroup>5__4;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CanvasGroup <winChampionhipGroup>5__5;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float <t>5__6;

		[Token(Token = "0x1700001E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x19516F0", Offset = "0x19516F0", VA = "0x19516F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x1951738", Offset = "0x1951738", VA = "0x1951738", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x19512F0", Offset = "0x19512F0", VA = "0x19512F0")]
		[DebuggerHidden]
		public <FinishRoundCamvasFadeIn>d__96(int <>1__state)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x195131C", Offset = "0x195131C", VA = "0x195131C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1951320", Offset = "0x1951320", VA = "0x1951320", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x19516F8", Offset = "0x19516F8", VA = "0x19516F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static System.Random random;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int SceneCount;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static int initialFightScene;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static int finalCharactersIndex;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static int[][] combats;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static string[] characterDifficultySuffix;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string fullString;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string enemyPositionObject;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string playerPositionObject;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string CHARACTERS_TEXTURES_FOLDER;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string loadingPanelName;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string vsPanelName;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string winPanelName;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string losePanelName;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string winChampionshipPanelName;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string pausePanelName;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string retriesLeftTextName;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private string playerVictory1Name;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string playerVictory2Name;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private string playerVictory1DeactivatedName;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private string playerVictory2DeactivatedName;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private string enemyVictory1Name;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private string enemyVictory2Name;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private string enemyVictory1DeactivatedName;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private string enemyVictory2DeactivatedName;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private string roundNumberLabelName;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private string roundFinishLabelName;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private string combatNumberLabelName;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private string winChampionshipTexture;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private string unlockedChampionshipTexture;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private string newCharacterObjectName;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private string newUnlockedChampionshipObjectName;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private string newUnlockedItemsChampionshipTexture;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private string newUnlockedItemsObjectName;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private string newUnlockedFinalCharacterObjectName;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private GameObject playerVictory1;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private GameObject playerVictory2;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private GameObject playerVictory1Deactivated;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private GameObject playerVictory2Deactivated;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private GameObject enemyVictory1;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private GameObject enemyVictory2;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private GameObject enemyVictory1Deactivated;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private GameObject enemyVictory2Deactivated;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private GameObject roundNumberLabel;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private GameObject roundFinishLabel;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private GameObject retriesLeft;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private GameObject enemyPosition;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private GameObject playerPosition;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private GameObject player;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private GameObject vrRig;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private PlayerAgent pAgent;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private PlayerStatus pStatus;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private GameObject loadingPanel;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private GameObject vsPanel;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private GameObject winPanel;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private GameObject losePanel;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private GameObject winChampionshipPanel;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private GameObject pausePanel;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private XRRayInteractor rightHandRay;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private XRRayInteractor leftHandRay;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public RawImage playerFullImage;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public RawImage enemyFullImage;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public RawImage playerLostImage;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public RawImage playerWinImage;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public RawImage newCharacterImage;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public RawImage unlockedItemCharacter;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public RawImage unlockedFinalCharacterImage;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public GameObject trackingLost;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public GameObject resumeButton;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public GameObject retryButton;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public TextMeshProUGUI playerName;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	public TextMeshProUGUI enemyName;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private bool startLoadingHidden;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7032AC", Offset = "0x7032AC")]
	private static bool <combatStarted>k__BackingField;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x229")]
	private bool moveUnblocked;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private ContinuousMoveControl moveControl;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private GameObject enemyGameObject;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	public AudioSource refereeAudio;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	public AudioClip koAudio;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	public AudioClip doubleKOAudio;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	public AudioClip timeAudio;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	public AudioClip fightAudio;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	public AudioClip noManaAudio;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private static bool sceneUnloading;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	private static bool roundFinshed;

	[Token(Token = "0x1700001D")]
	public static bool combatStarted
	{
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xCDB67C", Offset = "0xCDB67C", VA = "0xCDB67C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706690", Offset = "0x706690")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xCDB6E0", Offset = "0xCDB6E0", VA = "0xCDB6E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7066A0", Offset = "0x7066A0")]
		private set
		{
		}
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xCDB74C", Offset = "0xCDB74C", VA = "0xCDB74C")]
	public static void ResumeChampionship()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xCDB8C0", Offset = "0xCDB8C0", VA = "0xCDB8C0")]
	public void LoadNextCombat()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xCDBAA4", Offset = "0xCDBAA4", VA = "0xCDBAA4")]
	public void GoMain()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xCDBC08", Offset = "0xCDBC08", VA = "0xCDBC08")]
	public static int GetNextScene(int prevScene = 0)
	{
		return default(int);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xCDBCFC", Offset = "0xCDBCFC", VA = "0xCDBCFC")]
	public static string GetNextEnemy(int difficulty, int currentCombat = 0)
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xCDC17C", Offset = "0xCDC17C", VA = "0xCDC17C")]
	public void NoManaWarning()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xCDC1CC", Offset = "0xCDC1CC", VA = "0xCDC1CC")]
	public void FinishRound(bool KO, bool playerWin, bool enemyWin, float waitBeforeFadeIn)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xCDD0B0", Offset = "0xCDD0B0", VA = "0xCDD0B0")]
	private void DestroySpecials()
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xCDD2E8", Offset = "0xCDD2E8", VA = "0xCDD2E8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7066B0", Offset = "0x7066B0")]
	private IEnumerator FinishRoundCamvasFadeIn()
	{
		return null;
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xCDD360", Offset = "0xCDD360", VA = "0xCDD360")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xCDE344", Offset = "0xCDE344", VA = "0xCDE344")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xCDC904", Offset = "0xCDC904", VA = "0xCDC904")]
	private void UpdateUIRoundData(float waitBeforeFadeIn = 0f)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xCDE430", Offset = "0xCDE430", VA = "0xCDE430")]
	private void StartRoundPanelFadeIn()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xCDE574", Offset = "0xCDE574", VA = "0xCDE574")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xCDEAC8", Offset = "0xCDEAC8", VA = "0xCDEAC8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xCDEB50", Offset = "0xCDEB50", VA = "0xCDEB50")]
	public void StopCombat()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xCDEC38", Offset = "0xCDEC38", VA = "0xCDEC38")]
	public void StartCombat()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xCDC8D4", Offset = "0xCDC8D4", VA = "0xCDC8D4")]
	private void EnableCharacters(bool enable)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xCDEE44", Offset = "0xCDEE44", VA = "0xCDEE44")]
	private void EnableEnemy(bool enable)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xCDEF0C", Offset = "0xCDEF0C", VA = "0xCDEF0C")]
	private void EnablePlayer(bool enable)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xCDF17C", Offset = "0xCDF17C", VA = "0xCDF17C")]
	public void OnTrackingLost()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xCDF2A8", Offset = "0xCDF2A8", VA = "0xCDF2A8")]
	public void OnTrackingRestored()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xCDE810", Offset = "0xCDE810", VA = "0xCDE810")]
	public void PauseCombat()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xCDF3D0", Offset = "0xCDF3D0", VA = "0xCDF3D0")]
	public void ResumeCombat()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xCDF4BC", Offset = "0xCDF4BC", VA = "0xCDF4BC")]
	public void FinishChampionship()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xCDF524", Offset = "0xCDF524", VA = "0xCDF524")]
	public ChampionshipControl()
	{
	}
}
[Token(Token = "0x2000024")]
public static class CharactersData
{
	[Token(Token = "0x2000025")]
	public struct CharaterData
	{
		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7032BC", Offset = "0x7032BC")]
		private string <name>k__BackingField;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7032CC", Offset = "0x7032CC")]
		private string <special_1>k__BackingField;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7032DC", Offset = "0x7032DC")]
		private string <special_2>k__BackingField;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7032EC", Offset = "0x7032EC")]
		private string <special_3>k__BackingField;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7032FC", Offset = "0x7032FC")]
		private List<int> <specialIds>k__BackingField;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70330C", Offset = "0x70330C")]
		private float <height>k__BackingField;

		[Token(Token = "0x17000020")]
		public string name
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x1951F98", Offset = "0x1951F98", VA = "0x1951F98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706760", Offset = "0x706760")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x1951FA0", Offset = "0x1951FA0", VA = "0x1951FA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706798", Offset = "0x706798")]
			private set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public string special_1
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x1951FA8", Offset = "0x1951FA8", VA = "0x1951FA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7067A8", Offset = "0x7067A8")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x1951FB0", Offset = "0x1951FB0", VA = "0x1951FB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7067E0", Offset = "0x7067E0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public string special_2
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x1951FB8", Offset = "0x1951FB8", VA = "0x1951FB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7067F0", Offset = "0x7067F0")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x1951FC0", Offset = "0x1951FC0", VA = "0x1951FC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706828", Offset = "0x706828")]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public string special_3
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x1951FC8", Offset = "0x1951FC8", VA = "0x1951FC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706838", Offset = "0x706838")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x1951FD0", Offset = "0x1951FD0", VA = "0x1951FD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706870", Offset = "0x706870")]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public List<int> specialIds
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x1951FD8", Offset = "0x1951FD8", VA = "0x1951FD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706880", Offset = "0x706880")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x1951FE0", Offset = "0x1951FE0", VA = "0x1951FE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7068B8", Offset = "0x7068B8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public float height
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x1951FE8", Offset = "0x1951FE8", VA = "0x1951FE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7068C8", Offset = "0x7068C8")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x1951FF0", Offset = "0x1951FF0", VA = "0x1951FF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706900", Offset = "0x706900")]
			private set
			{
			}
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1951FF8", Offset = "0x1951FF8", VA = "0x1951FF8")]
		public CharaterData(string name, float height, List<int> specialIds, string special_1, string special_2, string special_3 = "")
		{
		}
	}

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Dictionary<string, CharaterData> characters;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static List<string> charactersList;
}
[Token(Token = "0x2000026")]
public class CheckPointControl : MonoBehaviour
{
	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject TutorialController;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool checkPointReached;

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xAF6E5C", Offset = "0xAF6E5C", VA = "0xAF6E5C")]
	public void Start()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xAF6E64", Offset = "0xAF6E64", VA = "0xAF6E64")]
	public void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xAF6F58", Offset = "0xAF6F58", VA = "0xAF6F58")]
	public CheckPointControl()
	{
	}
}
[Token(Token = "0x2000027")]
public class ConfigControl
{
	[Serializable]
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702894", Offset = "0x702894")]
	private sealed class <>c
	{
		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Message<User>.Callback <>9__149_0;

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1952478", Offset = "0x1952478", VA = "0x1952478")]
		public <>c()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1952480", Offset = "0x1952480", VA = "0x1952480")]
		internal void <InitUserAccount>b__149_0(Message<User> message)
		{
		}
	}

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string LANGUAGE;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static string TUTORIAL_COMPLETED;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static string AFTER_TUTORIAL;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static string SELECTED_CHARACTER;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static string UNLOCKED;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string FIGHTER;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static string RESUME_DIFFICULTY;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static string RESUME_CHARACTER;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static string RESUME_SCENE;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static string RESUME_ENEMY;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static string RESUME_ENEMY_PREFAB;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static string RESUME_DEFEATED_ENEMIES;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static string RESUME_COMBAT_NUMBER;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static string RESUME_ROUND_NUMBER;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static string RESUME_PLAYER_VICTORIES;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static string RESUME_ENEMY_VICTORIES;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static string RESUME_LAST_ROUND_RESULT;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static string RESUME_RETRIES;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static string RESUME_ROUND_TIME;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static string RESUME_PLAYER_HEALTH;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static string RESUME_PLAYER_STAMINA;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static string RESUME_PLAYER_MANA;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static string RESUME_PLAYER_STUN_FACTOR;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static string RESUME_ENEMY_HEALTH;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private static string RESUME_ENEMY_STAMINA;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private static string RESUME_ENEMY_MANA;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private static string RESUME_ENEMY_TIME_FROM_LAST_ATTACK;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private static string RESUME_ENEMYLAST_ATTACK_REPETITIONS;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private static string RESUME_ENEMY_SINGLE_ATTACK_PUNCH_RECHARGE;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private static string RESUME_ENEMY_SINGLE_ATTACK_KICK_RECHARGE;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private static string RESUME_ENEMY_SINGLE_ATTACK_ROUND_RECHARGE;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private static string RESUME_ENEMY_SINGLE_ATTACK_ROUND_KICK_RECHARGE;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private static string RESUME_ENEMY_SINGLE_ATTACK_AXE_KICK_RECHARGE;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private static string RESUME_ENEMY_SINGLE_ATTACK_BACK_FIST_RECHARGE;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private static string RESUME_ENEMY_SINGLE_ATTACK_SLASH_RECHARGE;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private static string RESUME_ENEMY_ATTACK_RECHARGE;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private static string RESUME_ENEMY_COMBO_ATTACK_RECHARGE;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private static string RESUME_ENEMY_SPECIAL_RECHARGE;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private static string LAST_COMBAT_MUSIC;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private static string COMBAT_MUSIC_ACTIVE;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private static string PLAYER_LEVEL;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private static string PLAYER_HEIGHT;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private static string ROUND_TIME;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private static string CHAMPIONSHIP_RETRIES;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private static string userId;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private static string userInitError;

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xAFA174", Offset = "0xAFA174", VA = "0xAFA174")]
	public static string GetLanguage()
	{
		return null;
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xAFA298", Offset = "0xAFA298", VA = "0xAFA298")]
	public static void SetLanguage(string language)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xAFA37C", Offset = "0xAFA37C", VA = "0xAFA37C")]
	public static void UnlockCharacter(string character)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xAFA46C", Offset = "0xAFA46C", VA = "0xAFA46C")]
	public static bool IsCharacterUnlocked(string character)
	{
		return default(bool);
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xAFA568", Offset = "0xAFA568", VA = "0xAFA568")]
	public static string GetSelectedCharacter()
	{
		return null;
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xAFA5D0", Offset = "0xAFA5D0", VA = "0xAFA5D0")]
	public static void SetSelectedCharacter(string character)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xAFA63C", Offset = "0xAFA63C", VA = "0xAFA63C")]
	public static string GetResumeChampionshipCharacter()
	{
		return null;
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xAFA6A4", Offset = "0xAFA6A4", VA = "0xAFA6A4")]
	public static void SetResumeChampionshipCharacter(string character)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xAFA710", Offset = "0xAFA710", VA = "0xAFA710")]
	public static int GetResumeChampionshipDifficulty()
	{
		return default(int);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xAFA778", Offset = "0xAFA778", VA = "0xAFA778")]
	public static void SetResumeChampionshipDifficulty(int difficulty)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xAFA7E4", Offset = "0xAFA7E4", VA = "0xAFA7E4")]
	public static int GetResumeChampionshipScene()
	{
		return default(int);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xAFA84C", Offset = "0xAFA84C", VA = "0xAFA84C")]
	public static void SetResumeChampionshipScene(int scene)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xAFA8B8", Offset = "0xAFA8B8", VA = "0xAFA8B8")]
	public static string GetResumeChampionshipEnemy()
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xAFA920", Offset = "0xAFA920", VA = "0xAFA920")]
	public static void SetResumeChampionshipEnemy(string enemy)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xAFA98C", Offset = "0xAFA98C", VA = "0xAFA98C")]
	public static string GetResumeChampionshipEnemyPrefab()
	{
		return null;
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xAFA9F4", Offset = "0xAFA9F4", VA = "0xAFA9F4")]
	public static void SetResumeChampionshipEnemyPrefab(string enemyPrefab)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xAFAA60", Offset = "0xAFAA60", VA = "0xAFAA60")]
	public static string GetResumeChampionshipDefetedEnemies()
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xAFAADC", Offset = "0xAFAADC", VA = "0xAFAADC")]
	public static void AddResumeChampionshipDefetedEnemy(string enemy)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xAFAB74", Offset = "0xAFAB74", VA = "0xAFAB74")]
	public static int GetResumeChampionshipCombatNumber()
	{
		return default(int);
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xAFABDC", Offset = "0xAFABDC", VA = "0xAFABDC")]
	public static void SetResumeChampionshipCombatNumber(int combat)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xAFAC48", Offset = "0xAFAC48", VA = "0xAFAC48")]
	public static int GetResumeChampionshipRoundNumber()
	{
		return default(int);
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xAFACB0", Offset = "0xAFACB0", VA = "0xAFACB0")]
	public static void SetResumeChampionshipRoundNumber(int round)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xAF8A94", Offset = "0xAF8A94", VA = "0xAF8A94")]
	public static int GetResumeChampionshipPlayerVictories()
	{
		return default(int);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xAFAD1C", Offset = "0xAFAD1C", VA = "0xAFAD1C")]
	public static void SetResumeChampionshipPlayerVictories(int victories)
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xAF8AFC", Offset = "0xAF8AFC", VA = "0xAF8AFC")]
	public static int GetResumeChampionshipEnemyVictories()
	{
		return default(int);
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xAFAD88", Offset = "0xAFAD88", VA = "0xAFAD88")]
	public static void SetResumeChampionshipEnemyVictories(int victories)
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xAFADF4", Offset = "0xAFADF4", VA = "0xAFADF4")]
	public static void SetResumeChampionshipLastRoundResult(string result)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xAFAE60", Offset = "0xAFAE60", VA = "0xAFAE60")]
	public static string GetResumeChampionshipLastRoundResult()
	{
		return null;
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xAF7D58", Offset = "0xAF7D58", VA = "0xAF7D58")]
	public static float GetResumeChampionshipRoundTime()
	{
		return default(float);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xAF9C94", Offset = "0xAF9C94", VA = "0xAF9C94")]
	public static void SetResumeChampionshipRoundTime(float time)
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xAFAFCC", Offset = "0xAFAFCC", VA = "0xAFAFCC")]
	public static float GetResumeChampionshipPlayerHealth()
	{
		return default(float);
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xAFB038", Offset = "0xAFB038", VA = "0xAFB038")]
	public static void SetResumeChampionshipPlayerHealth(float health)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xAFB0AC", Offset = "0xAFB0AC", VA = "0xAFB0AC")]
	public static float GetResumeChampionshipPlayerStamina()
	{
		return default(float);
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xAFB114", Offset = "0xAFB114", VA = "0xAFB114")]
	public static void SetResumeChampionshipPlayerStamina(float stamina)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xAFB188", Offset = "0xAFB188", VA = "0xAFB188")]
	public static float GetResumeChampionshipPlayerMana()
	{
		return default(float);
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xAFB1F0", Offset = "0xAFB1F0", VA = "0xAFB1F0")]
	public static void SetResumeChampionshipPlayerMana(float mana)
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xAFB264", Offset = "0xAFB264", VA = "0xAFB264")]
	public static float GetResumeChampionshipPlayerStunFactor()
	{
		return default(float);
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xAFB2CC", Offset = "0xAFB2CC", VA = "0xAFB2CC")]
	public static void SetResumeChampionshipPlayerStunFactor(float stunFactor)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xAFB340", Offset = "0xAFB340", VA = "0xAFB340")]
	public static float GetResumeChampionshipEnemyHealth()
	{
		return default(float);
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xAFB3AC", Offset = "0xAFB3AC", VA = "0xAFB3AC")]
	public static void SetResumeChampionshipEnemyHealth(float health)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xAFB420", Offset = "0xAFB420", VA = "0xAFB420")]
	public static float GetResumeChampionshipEnemyStamina()
	{
		return default(float);
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xAFB48C", Offset = "0xAFB48C", VA = "0xAFB48C")]
	public static void SetResumeChampionshipEnemyStamina(float stamina)
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xAFB500", Offset = "0xAFB500", VA = "0xAFB500")]
	public static float GetResumeChampionshipEnemyMana()
	{
		return default(float);
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xAFB56C", Offset = "0xAFB56C", VA = "0xAFB56C")]
	public static void SetResumeChampionshipEnemyMana(float mana)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xAFB5E0", Offset = "0xAFB5E0", VA = "0xAFB5E0")]
	public static float GetResumeChampionshipEnemyTimeFromLastAttack()
	{
		return default(float);
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xAFB648", Offset = "0xAFB648", VA = "0xAFB648")]
	public static void SetResumeChampionshipEnemyTimeFromLastAttack(float value)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xAFB6BC", Offset = "0xAFB6BC", VA = "0xAFB6BC")]
	public static int GetResumeChampionshipEnemyLastAttackRepetitions()
	{
		return default(int);
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xAFB724", Offset = "0xAFB724", VA = "0xAFB724")]
	public static void SetResumeChampionshipEnemyLastAttackRepetitions(int value)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xAFB790", Offset = "0xAFB790", VA = "0xAFB790")]
	public static float GetResumeChampionshipEnemySingleAttackPunchRecharge()
	{
		return default(float);
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xAFB7F8", Offset = "0xAFB7F8", VA = "0xAFB7F8")]
	public static void SetResumeChampionshipEnemySingleAttackPunchRecharge(float value)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xAFB86C", Offset = "0xAFB86C", VA = "0xAFB86C")]
	public static float GetResumeChampionshipEnemySingleAttackKickRecharge()
	{
		return default(float);
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xAFB8D4", Offset = "0xAFB8D4", VA = "0xAFB8D4")]
	public static void SetResumeChampionshipEnemySingleAttackKickRecharge(float value)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xAFB948", Offset = "0xAFB948", VA = "0xAFB948")]
	public static float GetResumeChampionshipEnemySingleAttackRoundRecharge()
	{
		return default(float);
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xAFB9B0", Offset = "0xAFB9B0", VA = "0xAFB9B0")]
	public static void SetResumeChampionshipEnemySingleAttackRoundRecharge(float value)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xAFBA24", Offset = "0xAFBA24", VA = "0xAFBA24")]
	public static float GetResumeChampionshipEnemySingleAttackRoundKickRecharge()
	{
		return default(float);
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xAFBA8C", Offset = "0xAFBA8C", VA = "0xAFBA8C")]
	public static void SetResumeChampionshipEnemySingleAttackRoundKickRecharge(float value)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xAFBB00", Offset = "0xAFBB00", VA = "0xAFBB00")]
	public static float GetResumeChampionshipEnemySingleAttackAxeKickRecharge()
	{
		return default(float);
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xAFBB68", Offset = "0xAFBB68", VA = "0xAFBB68")]
	public static void SetResumeChampionshipEnemySingleAttackAxeKickRecharge(float value)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xAFBBDC", Offset = "0xAFBBDC", VA = "0xAFBBDC")]
	public static float GetResumeChampionshipEnemySingleAttackBackFistRecharge()
	{
		return default(float);
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xAFBC44", Offset = "0xAFBC44", VA = "0xAFBC44")]
	public static void SetResumeChampionshipEnemySingleAttackBackFistRecharge(float value)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xAFBCB8", Offset = "0xAFBCB8", VA = "0xAFBCB8")]
	public static float GetResumeChampionshipEnemySingleAttackSlashRecharge()
	{
		return default(float);
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xAFBD20", Offset = "0xAFBD20", VA = "0xAFBD20")]
	public static void SetResumeChampionshipEnemySingleAttackSlashRecharge(float value)
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xAFBD94", Offset = "0xAFBD94", VA = "0xAFBD94")]
	public static float GetResumeChampionshipEnemyAttackRecharge()
	{
		return default(float);
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xAFBDFC", Offset = "0xAFBDFC", VA = "0xAFBDFC")]
	public static void SetResumeChampionshipEnemyAttackRecharge(float value)
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xAFBE70", Offset = "0xAFBE70", VA = "0xAFBE70")]
	public static float GetResumeChampionshipEnemyComboAttackRecharge()
	{
		return default(float);
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xAFBED8", Offset = "0xAFBED8", VA = "0xAFBED8")]
	public static void SetResumeChampionshipEnemyComboAttackRecharge(float value)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xAFBF4C", Offset = "0xAFBF4C", VA = "0xAFBF4C")]
	public static float GetResumeChampionshipEnemySpecialRecharge()
	{
		return default(float);
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xAFBFB4", Offset = "0xAFBFB4", VA = "0xAFBFB4")]
	public static void SetResumeChampionshipEnemySpecialRecharge(float value)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xAFC028", Offset = "0xAFC028", VA = "0xAFC028")]
	public static int GetResumeChampionshipRetries()
	{
		return default(int);
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xAFC090", Offset = "0xAFC090", VA = "0xAFC090")]
	public static void SetResumeChampionshipRetries(int retries)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xAFC0FC", Offset = "0xAFC0FC", VA = "0xAFC0FC")]
	public static int GetCurrentLevel()
	{
		return default(int);
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xAFC164", Offset = "0xAFC164", VA = "0xAFC164")]
	public static void SetCurrentLevel(int level)
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xAF9C2C", Offset = "0xAF9C2C", VA = "0xAF9C2C")]
	public static int GetChampionshipRoundTime()
	{
		return default(int);
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xAFC1D0", Offset = "0xAFC1D0", VA = "0xAFC1D0")]
	public static void SetChampionshipRoundTime(int time)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xAFC23C", Offset = "0xAFC23C", VA = "0xAFC23C")]
	public static int GetChampionshipRetries()
	{
		return default(int);
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xAFC2A4", Offset = "0xAFC2A4", VA = "0xAFC2A4")]
	public static void SetChampionshipRetries(int retries)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xAFC310", Offset = "0xAFC310", VA = "0xAFC310")]
	public static int GetTutorialCompleted()
	{
		return default(int);
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xAFC378", Offset = "0xAFC378", VA = "0xAFC378")]
	public static void SetTutorialCompleted(int value)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xAFC3E4", Offset = "0xAFC3E4", VA = "0xAFC3E4")]
	public static int GetAfterTutorialResumeFight()
	{
		return default(int);
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0xAFC44C", Offset = "0xAFC44C", VA = "0xAFC44C")]
	public static void SetAfterTutorialResumeFight(int value)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xAFC4B8", Offset = "0xAFC4B8", VA = "0xAFC4B8")]
	public static int GetLastCombatMusic()
	{
		return default(int);
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xAFC520", Offset = "0xAFC520", VA = "0xAFC520")]
	public static void SetLastCombatMusic(int value)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xAFC58C", Offset = "0xAFC58C", VA = "0xAFC58C")]
	public static int GetCombatMusicActive()
	{
		return default(int);
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xAFC5F4", Offset = "0xAFC5F4", VA = "0xAFC5F4")]
	public static void SetCombatMusicActive(int value)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xAFC660", Offset = "0xAFC660", VA = "0xAFC660")]
	public static float GetPlayerHeight()
	{
		return default(float);
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xAFC6C8", Offset = "0xAFC6C8", VA = "0xAFC6C8")]
	public static void SetPlayerHeight(float value)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xAFC73C", Offset = "0xAFC73C", VA = "0xAFC73C")]
	public static void NewChampionship(int difficulty, int startScene, string startEnemyPrefab)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xAFC928", Offset = "0xAFC928", VA = "0xAFC928")]
	public static void GenerateNextCombat(int scene, string nextEnemyPrefab)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0xAFC850", Offset = "0xAFC850", VA = "0xAFC850")]
	public static void ClearResumeData()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0xAFCA70", Offset = "0xAFCA70", VA = "0xAFCA70")]
	public static void DeleteRoundStats()
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0xAFCCAC", Offset = "0xAFCCAC", VA = "0xAFCCAC")]
	public static void ResetConfig(bool resetLevel = true)
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0xAFCD64", Offset = "0xAFCD64", VA = "0xAFCD64")]
	private static void DeleteAll()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xAFCF6C", Offset = "0xAFCF6C", VA = "0xAFCF6C")]
	private static string GetUserKey(string key)
	{
		return null;
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xAFCC44", Offset = "0xAFCC44", VA = "0xAFCC44")]
	private static void DeleteKey(string key)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0xAFA4F0", Offset = "0xAFA4F0", VA = "0xAFA4F0")]
	private static int GetInt(string key, int defaultValue = int.MinValue)
	{
		return default(int);
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xAFA3F4", Offset = "0xAFA3F4", VA = "0xAFA3F4")]
	private static void SetInt(string key, int value)
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xAFAEDC", Offset = "0xAFAEDC", VA = "0xAFAEDC")]
	private static float GetFloat(string key, float defaultValue = float.NaN)
	{
		return default(float);
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xAFAF54", Offset = "0xAFAF54", VA = "0xAFAF54")]
	private static void SetFloat(string key, float value)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xAFA220", Offset = "0xAFA220", VA = "0xAFA220")]
	private static string GetString(string key, [Optional] string defaultValue)
	{
		return null;
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xAFA304", Offset = "0xAFA304", VA = "0xAFA304")]
	private static void SetString(string key, string value)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xAFCF64", Offset = "0xAFCF64", VA = "0xAFCF64")]
	public static void SaveToDisk()
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xAFD060", Offset = "0xAFD060", VA = "0xAFD060")]
	public static string getUserId()
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0xAFD0C4", Offset = "0xAFD0C4", VA = "0xAFD0C4")]
	public static string getUserInitError()
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xAFD128", Offset = "0xAFD128", VA = "0xAFD128")]
	public static void InitUserAccount()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xAFD2AC", Offset = "0xAFD2AC", VA = "0xAFD2AC")]
	public ConfigControl()
	{
	}
}
[Token(Token = "0x2000029")]
public class HeightInterface : MonoBehaviour
{
	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject playerHeadObject;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI configHeight;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI heightValue;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private double heightVsEyeRatio;

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xC0F93C", Offset = "0xC0F93C", VA = "0xC0F93C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xC0FA38", Offset = "0xC0FA38", VA = "0xC0FA38")]
	public void CalibrateHeight()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xC0FB94", Offset = "0xC0FB94", VA = "0xC0FB94")]
	public HeightInterface()
	{
	}
}
[Token(Token = "0x200002A")]
public class LanguageControl : MonoBehaviour
{
	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TextMeshProUGUI[] textList;

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xC12CE0", Offset = "0xC12CE0", VA = "0xC12CE0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xC12FF8", Offset = "0xC12FF8", VA = "0xC12FF8")]
	public void ChangeLanguage(string language)
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xC12E84", Offset = "0xC12E84", VA = "0xC12E84")]
	private void TranslateTexts(string currentLanguage, string language)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xC130A8", Offset = "0xC130A8", VA = "0xC130A8")]
	public LanguageControl()
	{
	}
}
[Token(Token = "0x200002B")]
public class SpecialTutorialController : MonoBehaviour
{
	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject specialPerformPanel;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject specialSelectPanel;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] specialPanels;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject[] specialTrackingPanels;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject loadingPanel;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject pausePanel;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject initialSpecialSelected;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject activeSpecialPanel;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject activeSpecialTrackPanel;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GameObject trackStep1Image;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject trackStep2Image;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private GameObject trackStep3Image;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject step1CompleteImage;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject step2CompleteImage;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject step3CompleteImage;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int selectedSpecialPanel;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject masterGameObject;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject ghostOpponent;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public ContinuousMoveControl moveController;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public XRRayInteractor rightHandRay;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public XRRayInteractor leftHandRay;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject trackingLost;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject resumeButton;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private PlayerAgent pAgent;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private PlayerStatus pStatus;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private CharacterAgent cAgent;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private bool tutorialCombatStarted;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
	private bool sceneUnloading;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEA")]
	private bool firstUpdate;

	[Token(Token = "0x40001CE")]
	private const string TRACK_STEP_1_OBJ = "Step1Image";

	[Token(Token = "0x40001CF")]
	private const string TRACK_STEP_2_OBJ = "Step2Image";

	[Token(Token = "0x40001D0")]
	private const string TRACK_STEP_3_OBJ = "Step3Image";

	[Token(Token = "0x40001D1")]
	private const float TRACK_STEP_DEACTIVE = 0.65f;

	[Token(Token = "0x40001D2")]
	private const float TRACK_STEP_ACTIVE = 1f;

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xB8334C", Offset = "0xB8334C", VA = "0xB8334C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xB83630", Offset = "0xB83630", VA = "0xB83630")]
	private void Start()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xB83A6C", Offset = "0xB83A6C", VA = "0xB83A6C")]
	public void Update()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xB83D14", Offset = "0xB83D14", VA = "0xB83D14")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xB83D18", Offset = "0xB83D18", VA = "0xB83D18")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xB83D40", Offset = "0xB83D40", VA = "0xB83D40")]
	public bool TutorialCombatStarted()
	{
		return default(bool);
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xB83D48", Offset = "0xB83D48", VA = "0xB83D48")]
	public void OnTrackingLost()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xB83E74", Offset = "0xB83E74", VA = "0xB83E74")]
	public void OnTrackingRestored()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xB83F60", Offset = "0xB83F60", VA = "0xB83F60")]
	public void PauseCombat()
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xB840B8", Offset = "0xB840B8", VA = "0xB840B8")]
	private void DestroySpecials()
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0xB84234", Offset = "0xB84234", VA = "0xB84234")]
	public void ResumeCombat()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0xB84338", Offset = "0xB84338", VA = "0xB84338")]
	public void FinishTutorial()
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xB84344", Offset = "0xB84344", VA = "0xB84344")]
	public void ExitTutorial()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0xB843EC", Offset = "0xB843EC", VA = "0xB843EC")]
	public void StartTraining()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xB847AC", Offset = "0xB847AC", VA = "0xB847AC")]
	public void ShowSpecialPerformPanel()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xB847F0", Offset = "0xB847F0", VA = "0xB847F0")]
	public void HideSpecialPerformPanel()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xB82D8C", Offset = "0xB82D8C", VA = "0xB82D8C")]
	public void SetSpecialIndex(int index)
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xB84834", Offset = "0xB84834", VA = "0xB84834")]
	public void trackStep1()
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xB8498C", Offset = "0xB8498C", VA = "0xB8498C")]
	public void trackStep2()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xB84AE4", Offset = "0xB84AE4", VA = "0xB84AE4")]
	public void trackStep3()
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xB844F4", Offset = "0xB844F4", VA = "0xB844F4")]
	public void resetTrackState()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0xB83AD4", Offset = "0xB83AD4", VA = "0xB83AD4")]
	private void DeactivateOpponent()
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0xB842E4", Offset = "0xB842E4", VA = "0xB842E4")]
	private void ActivateOpponent()
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0xB83908", Offset = "0xB83908", VA = "0xB83908")]
	private void ResetPausePanelPosition()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0xB83B28", Offset = "0xB83B28", VA = "0xB83B28")]
	private void UpdateTrackingLostPosition()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0xB84C3C", Offset = "0xB84C3C", VA = "0xB84C3C")]
	public SpecialTutorialController()
	{
	}
}
[Token(Token = "0x200002C")]
public static class SpecialsData
{
	[Token(Token = "0x200002D")]
	public struct SpecialData
	{
		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70331C", Offset = "0x70331C")]
		private int <id>k__BackingField;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70332C", Offset = "0x70332C")]
		private string <name>k__BackingField;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70333C", Offset = "0x70333C")]
		private float <damage>k__BackingField;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70334C", Offset = "0x70334C")]
		private int <quantity>k__BackingField;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70335C", Offset = "0x70335C")]
		private int <blockablePercentage>k__BackingField;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70336C", Offset = "0x70336C")]
		private int <duration>k__BackingField;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70337C", Offset = "0x70337C")]
		private string <effectDescription>k__BackingField;

		[Token(Token = "0x17000026")]
		public int id
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x191C9A0", Offset = "0x191C9A0", VA = "0x191C9A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706910", Offset = "0x706910")]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x191C9A8", Offset = "0x191C9A8", VA = "0x191C9A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706948", Offset = "0x706948")]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public string name
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x191C9B0", Offset = "0x191C9B0", VA = "0x191C9B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706958", Offset = "0x706958")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x191C9B8", Offset = "0x191C9B8", VA = "0x191C9B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706990", Offset = "0x706990")]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public float damage
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x191C9C0", Offset = "0x191C9C0", VA = "0x191C9C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7069A0", Offset = "0x7069A0")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x191C9C8", Offset = "0x191C9C8", VA = "0x191C9C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7069D8", Offset = "0x7069D8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public int quantity
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x191C9D0", Offset = "0x191C9D0", VA = "0x191C9D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7069E8", Offset = "0x7069E8")]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x191C9D8", Offset = "0x191C9D8", VA = "0x191C9D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706A20", Offset = "0x706A20")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public int blockablePercentage
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x191C9E0", Offset = "0x191C9E0", VA = "0x191C9E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706A30", Offset = "0x706A30")]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x191C9E8", Offset = "0x191C9E8", VA = "0x191C9E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706A68", Offset = "0x706A68")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public int duration
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x191C9F0", Offset = "0x191C9F0", VA = "0x191C9F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706A78", Offset = "0x706A78")]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x191C9F8", Offset = "0x191C9F8", VA = "0x191C9F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706AB0", Offset = "0x706AB0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public string effectDescription
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x191CA00", Offset = "0x191CA00", VA = "0x191CA00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706AC0", Offset = "0x706AC0")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x191CA08", Offset = "0x191CA08", VA = "0x191CA08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706AF8", Offset = "0x706AF8")]
			private set
			{
			}
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x191CA10", Offset = "0x191CA10", VA = "0x191CA10")]
		public SpecialData(int id, string name, int quantity, float damage, int blockablePercentage, int duration, [Optional] string effectDescription)
		{
		}
	}

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Dictionary<string, SpecialData> specials;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static List<string> specialsList;
}
[Token(Token = "0x200002E")]
public class TranslationData
{
	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string[] LanguageList;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Dictionary<string, Dictionary<string, string>> translations;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Dictionary<string, Dictionary<string, string>> inverted_translations;

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0xB82CF0", Offset = "0xB82CF0", VA = "0xB82CF0")]
	public static string Translate(string text, string toLanguage)
	{
		return null;
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0xB8CA58", Offset = "0xB8CA58", VA = "0xB8CA58")]
	public static string Translate(string text, string fromLanguage, string toLanguage)
	{
		return null;
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0xB8CD44", Offset = "0xB8CD44", VA = "0xB8CD44")]
	public static void StarInvertedDictionary()
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xB8D290", Offset = "0xB8D290", VA = "0xB8D290")]
	public TranslationData()
	{
	}
}
[Token(Token = "0x200002F")]
public class TutorialController : MonoBehaviour
{
	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int currentStep;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int completedSteps;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] stepPanels;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject punchsCompletionPanel;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject blocksCompletionPanel;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject dodgesCompletionPanel;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject kicksCompletionPanel;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject slashKickCompletionPanel;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject loadingPanel;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject pausePanel;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject activeStepPanel;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject checkPoint;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject masterGameObject;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject ghostOpponent;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public CombatStatusUpdater statusUpdater;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public ContinuousMoveControl moveController;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public XRRayInteractor rightHandRay;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public XRRayInteractor leftHandRay;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject trackingLost;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject resumeButton;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public RawImage[] punchs;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public RawImage[] blocks;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public RawImage[] dodges;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public RawImage[] kicks;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public RawImage[] slashKick;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private PlayerAgent pAgent;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private CharacterAgent cAgent;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private int blockCount;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private int hitCount;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private int dodgeCount;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private int kickCount;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private int slashKickCount;

	[Token(Token = "0x40001FF")]
	private const int TUTORIAL_COMPLETION_COUNT = 3;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private bool tutorialCombatStarted;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
	private bool sceneUnloading;

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x19491EC", Offset = "0x19491EC", VA = "0x19491EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x19494A4", Offset = "0x19494A4", VA = "0x19494A4")]
	private void Start()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x19497AC", Offset = "0x19497AC", VA = "0x19497AC")]
	private void Update()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x1949808", Offset = "0x1949808", VA = "0x1949808")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x1949830", Offset = "0x1949830", VA = "0x1949830")]
	public void NextStep()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x19499D8", Offset = "0x19499D8", VA = "0x19499D8")]
	public void PrevStep()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x1949B24", Offset = "0x1949B24", VA = "0x1949B24")]
	public void CompleteCurrentStep()
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x1949D24", Offset = "0x1949D24", VA = "0x1949D24")]
	public bool TutorialCombatStarted()
	{
		return default(bool);
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x1949D2C", Offset = "0x1949D2C", VA = "0x1949D2C")]
	public void AddHit()
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x1949E58", Offset = "0x1949E58", VA = "0x1949E58")]
	public void AddBlock()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x1949F94", Offset = "0x1949F94", VA = "0x1949F94")]
	public void AddDodge()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x194A09C", Offset = "0x194A09C", VA = "0x194A09C")]
	public void AddKick()
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x194A1D8", Offset = "0x194A1D8", VA = "0x194A1D8")]
	public void SlaskKickPosition(bool value)
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x194A1DC", Offset = "0x194A1DC", VA = "0x194A1DC")]
	public void SlaskKickButton(bool value)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x194A1E0", Offset = "0x194A1E0", VA = "0x194A1E0")]
	public void SlaskKickSlash()
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x194A1E4", Offset = "0x194A1E4", VA = "0x194A1E4")]
	public void SlaskKickCompleted()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x194998C", Offset = "0x194998C", VA = "0x194998C")]
	private void ActivateCurrentStep()
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x194A1E8", Offset = "0x194A1E8", VA = "0x194A1E8")]
	private void ActivateStep1()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x194A250", Offset = "0x194A250", VA = "0x194A250")]
	private void ActivateStep3()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x194A34C", Offset = "0x194A34C", VA = "0x194A34C")]
	private void ActivateStep4()
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x194A454", Offset = "0x194A454", VA = "0x194A454")]
	private void ActivateStep6()
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x194A4FC", Offset = "0x194A4FC", VA = "0x194A4FC")]
	private void ActivateStep8()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x194A5A4", Offset = "0x194A5A4", VA = "0x194A5A4")]
	private void ActivateStep9()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x194A684", Offset = "0x194A684", VA = "0x194A684")]
	public void OnTrackingLost()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x194A880", Offset = "0x194A880", VA = "0x194A880")]
	public void OnTrackingRestored()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x194A7B4", Offset = "0x194A7B4", VA = "0x194A7B4")]
	private void PauseCombatTrackingLost()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x194AA00", Offset = "0x194AA00", VA = "0x194AA00")]
	public void PauseCombat()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x194AB98", Offset = "0x194AB98", VA = "0x194AB98")]
	public void ResumeCombat()
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x194AD38", Offset = "0x194AD38", VA = "0x194AD38")]
	public void FinishTutorial()
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x194ADAC", Offset = "0x194ADAC", VA = "0x194ADAC")]
	public void ExitTutorial()
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x194AF88", Offset = "0x194AF88", VA = "0x194AF88")]
	public TutorialController()
	{
	}
}
[Token(Token = "0x2000030")]
public class UserInitialization : MonoBehaviour
{
	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool loading;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool entitlements;

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x194D030", Offset = "0x194D030", VA = "0x194D030")]
	private void Start()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x194D258", Offset = "0x194D258", VA = "0x194D258")]
	private void Update()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x194D2D8", Offset = "0x194D2D8", VA = "0x194D2D8")]
	public UserInitialization()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x194D2E0", Offset = "0x194D2E0", VA = "0x194D2E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706B08", Offset = "0x706B08")]
	private void <Start>b__2_0(Message message)
	{
	}
}
[Token(Token = "0x2000031")]
public class KinematicInstantVelocity : MonoBehaviour
{
	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private PlayerStatus pStatus;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private PlayerAgent pAgent;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public PlayerStatus.PART_TYPE partType;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70338C", Offset = "0x70338C")]
	private Vector3 <velocity>k__BackingField;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70339C", Offset = "0x70339C")]
	private Vector3 <instantVelocity>k__BackingField;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<Vector3> prevPositions;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<float> prevDeltas;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float maxPositions;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private ContinuousMoveControl pMoveControl;

	[Token(Token = "0x1700002D")]
	public Vector3 velocity
	{
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xC126B8", Offset = "0xC126B8", VA = "0xC126B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706B18", Offset = "0x706B18")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xC126C4", Offset = "0xC126C4", VA = "0xC126C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706B28", Offset = "0x706B28")]
		private set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	public Vector3 instantVelocity
	{
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xC126D0", Offset = "0xC126D0", VA = "0xC126D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706B38", Offset = "0x706B38")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xC126DC", Offset = "0xC126DC", VA = "0xC126DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706B48", Offset = "0x706B48")]
		private set
		{
		}
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xC126E8", Offset = "0xC126E8", VA = "0xC126E8")]
	private void Start()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xC128D4", Offset = "0xC128D4", VA = "0xC128D4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xC12CC8", Offset = "0xC12CC8", VA = "0xC12CC8")]
	public KinematicInstantVelocity()
	{
	}
}
[Token(Token = "0x2000032")]
public class MeshBatcher : MonoBehaviour
{
	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SkinnedMeshRenderer SkMesh;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string fileName;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool saved;

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xC17C0C", Offset = "0xC17C0C", VA = "0xC17C0C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xC17C10", Offset = "0xC17C10", VA = "0xC17C10")]
	public MeshBatcher()
	{
	}
}
[Token(Token = "0x2000033")]
public class SaveRender : MonoBehaviour
{
	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int FileCounter;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Camera Cam;

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xB7D114", Offset = "0xB7D114", VA = "0xB7D114")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xB7D118", Offset = "0xB7D118", VA = "0xB7D118")]
	private void CamCapture()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xB7D378", Offset = "0xB7D378", VA = "0xB7D378")]
	public SaveRender()
	{
	}
}
[Token(Token = "0x2000034")]
public class BerserkSpecial : MonoBehaviour
{
	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string targetTag;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float duration;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject targetObjet;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float currentDuration;

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xCD85DC", Offset = "0xCD85DC", VA = "0xCD85DC")]
	private void Start()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0xCD86E8", Offset = "0xCD86E8", VA = "0xCD86E8")]
	private void Update()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0xCD8858", Offset = "0xCD8858", VA = "0xCD8858")]
	public BerserkSpecial()
	{
	}
}
[Token(Token = "0x2000035")]
public class DirectedParticle : MonoBehaviour
{
	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float speed;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float sqrSpeed;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string target;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject targetObject;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Rigidbody particleRigidBody;

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0xB02374", Offset = "0xB02374", VA = "0xB02374")]
	private void Start()
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0xB023F8", Offset = "0xB023F8", VA = "0xB023F8")]
	public void SetSpeed(float speed)
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0xB02404", Offset = "0xB02404", VA = "0xB02404")]
	private void Update()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0xB02540", Offset = "0xB02540", VA = "0xB02540")]
	public DirectedParticle()
	{
	}
}
[Token(Token = "0x2000036")]
public class InterSpecialsCollision : MonoBehaviour
{
	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject specialCollisionParticles;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float specialCollisionDestroy;

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0xC0FDC4", Offset = "0xC0FDC4", VA = "0xC0FDC4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0xC10378", Offset = "0xC10378", VA = "0xC10378")]
	public InterSpecialsCollision()
	{
	}
}
[Token(Token = "0x2000037")]
public class ParticlesSpawn : MonoBehaviour
{
	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string particlePrefab;

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x130C10C", Offset = "0x130C10C", VA = "0x130C10C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x130C6CC", Offset = "0x130C6CC", VA = "0x130C6CC")]
	public ParticlesSpawn()
	{
	}
}
[Token(Token = "0x2000038")]
public class PlayerSpecialKick : MonoBehaviour
{
	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private PlayerStatus status;

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x131438C", Offset = "0x131438C", VA = "0x131438C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x13144E8", Offset = "0x13144E8", VA = "0x13144E8")]
	public PlayerSpecialKick()
	{
	}
}
[Token(Token = "0x2000039")]
public interface SpecialCondition
{
	[Token(Token = "0x60001E6")]
	bool CheckCondition(GameObject origin, GameObject target);
}
[Token(Token = "0x200003A")]
public class SpecialDistanceCondition : SpecialCondition
{
	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Vector3 originCorrection;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float minDistance;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float maxDistance;

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0xB80FD8", Offset = "0xB80FD8", VA = "0xB80FD8")]
	public SpecialDistanceCondition(float minDistance, float maxDistance, Vector3 originCorrection)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0xB81034", Offset = "0xB81034", VA = "0xB81034", Slot = "4")]
	public bool CheckCondition(GameObject origin, GameObject target)
	{
		return default(bool);
	}
}
[Token(Token = "0x200003B")]
public class SpecialManager : MonoBehaviour
{
	[Token(Token = "0x200003C")]
	public enum SPECIAL_EVASION_DISTANCE
	{
		[Token(Token = "0x4000232")]
		ANY,
		[Token(Token = "0x4000233")]
		MEDIUM,
		[Token(Token = "0x4000234")]
		CLOSE
	}

	[Token(Token = "0x200003D")]
	public enum SPECIAL_EVASION_MOVE
	{
		[Token(Token = "0x4000236")]
		ANY,
		[Token(Token = "0x4000237")]
		SIDEWARD
	}

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject player;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private PlayerAgent playerAgent;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject character;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CharacterAgent characterAgent;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private CharacterStatus characterStatus;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<int> collisionSubemitters;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float damage;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float blockableDamage;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float colliderRaius;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float straightMove;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public SPECIAL_EVASION_DISTANCE evasionDistance;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public SPECIAL_EVASION_MOVE evasionMove;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7033AC", Offset = "0x7033AC")]
	private bool <damageDone>k__BackingField;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject collisionSoundObject;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private AudioSource lifeSound;

	[Token(Token = "0x1700002F")]
	public bool damageDone
	{
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xB8113C", Offset = "0xB8113C", VA = "0xB8113C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706B58", Offset = "0x706B58")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xB81144", Offset = "0xB81144", VA = "0xB81144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706B68", Offset = "0x706B68")]
		private set
		{
		}
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0xB81150", Offset = "0xB81150", VA = "0xB81150")]
	private void Start()
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0xB81340", Offset = "0xB81340", VA = "0xB81340")]
	public void SpecialsParticlesCollided(GameObject gameObject)
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0xB81344", Offset = "0xB81344", VA = "0xB81344")]
	private void OnParticleCollision(GameObject gameObject)
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0xB81AC4", Offset = "0xB81AC4", VA = "0xB81AC4")]
	public SpecialManager()
	{
	}
}
[Token(Token = "0x200003E")]
public class SpecialRayCondition : SpecialCondition
{
	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Vector3 originCorrection;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float minDistance;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float distance;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float radius;

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0xB81ACC", Offset = "0xB81ACC", VA = "0xB81ACC")]
	public SpecialRayCondition(Vector3 originCorrection, float minDistance, float distance, float radius)
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0xB81B2C", Offset = "0xB81B2C", VA = "0xB81B2C", Slot = "4")]
	public bool CheckCondition(GameObject origin, GameObject target)
	{
		return default(bool);
	}
}
[Token(Token = "0x200003F")]
public class TextureBiasSetter : MonoBehaviour
{
	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture[] textures;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float bias;

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0xB894D8", Offset = "0xB894D8", VA = "0xB894D8")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0xB89554", Offset = "0xB89554", VA = "0xB89554")]
	public TextureBiasSetter()
	{
	}
}
[Token(Token = "0x2000040")]
public class AsyncSceneLoader : MonoBehaviour
{
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7028A4", Offset = "0x7028A4")]
	private sealed class <LoadSceneAsync>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int scene;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AsyncOperation <asyncLoad>5__2;

		[Token(Token = "0x17000030")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x1950D9C", Offset = "0x1950D9C", VA = "0x1950D9C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x1950DE4", Offset = "0x1950DE4", VA = "0x1950DE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1950C8C", Offset = "0x1950C8C", VA = "0x1950C8C")]
		[DebuggerHidden]
		public <LoadSceneAsync>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1950CB8", Offset = "0x1950CB8", VA = "0x1950CB8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1950CBC", Offset = "0x1950CBC", VA = "0x1950CBC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1950DA4", Offset = "0x1950DA4", VA = "0x1950DA4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0xCD80A0", Offset = "0xCD80A0", VA = "0xCD80A0")]
	public void LoadScene(int scene)
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0xCD8124", Offset = "0xCD8124", VA = "0xCD8124")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x706B78", Offset = "0x706B78")]
	private IEnumerator LoadSceneAsync(int scene)
	{
		return null;
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0xCD8190", Offset = "0xCD8190", VA = "0xCD8190")]
	public AsyncSceneLoader()
	{
	}
}
[Token(Token = "0x2000042")]
public class ButtonControl : MonoBehaviour
{
	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip selectSound;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioClip enterSound;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioClip lockedSound;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioSource playerSound;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string buttonAudioSource;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string buttonIconObject;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string buttonTextObject;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Color activeColor;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Color unactiveColor;

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0xCDA1E8", Offset = "0xCDA1E8", VA = "0xCDA1E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0xCDA254", Offset = "0xCDA254", VA = "0xCDA254")]
	public void PointerEnter()
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xCDA39C", Offset = "0xCDA39C", VA = "0xCDA39C")]
	public void PointerClick()
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0xCDA50C", Offset = "0xCDA50C", VA = "0xCDA50C")]
	public void Activate()
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0xCDA634", Offset = "0xCDA634", VA = "0xCDA634")]
	public void Deactivate()
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0xCDA75C", Offset = "0xCDA75C", VA = "0xCDA75C")]
	public ButtonControl()
	{
	}
}
[Token(Token = "0x2000043")]
public class CharacterSelect : MonoBehaviour
{
	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject CharacterButtons;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Color activeColor;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Color deactiveColor;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Color lockedColor;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Texture selectedFrame;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Texture unselectedFrame;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AudioClip selectSound;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public AudioClip enterSound;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public AudioClip lockedSound;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string selectedCharacterTag;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<string, GameObject> charactersFull;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static GameObject selectedCharacterButton;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private GameObject selectedCharacterName;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private GameObject selectedCharacterSpecial1;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameObject selectedCharacterSpecial2;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private GameObject selectedCharacterSpecial3;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private string currentHover;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private string frameObject;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private string lockedImageObject;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private string characterNameObject;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private string characterSpecialObject;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private string fullSuffix;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private string buttonAudioSource;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private AudioSource buttonSound;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private bool started;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
	private bool locked;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private string character;

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x15A876C", Offset = "0x15A876C", VA = "0x15A876C")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x15A8CC4", Offset = "0x15A8CC4", VA = "0x15A8CC4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x15A94BC", Offset = "0x15A94BC", VA = "0x15A94BC")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x15A9664", Offset = "0x15A9664", VA = "0x15A9664")]
	public static void selectCurrentCharacter()
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x15A9764", Offset = "0x15A9764", VA = "0x15A9764")]
	public void characterEnter()
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x15A9984", Offset = "0x15A9984", VA = "0x15A9984")]
	public void characterExit()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x15A8E2C", Offset = "0x15A8E2C", VA = "0x15A8E2C")]
	public void characterSelected()
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x15A9A50", Offset = "0x15A9A50", VA = "0x15A9A50")]
	public CharacterSelect()
	{
	}
}
[Token(Token = "0x2000044")]
public class CombatStatusUpdater : MonoBehaviour
{
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7028B4", Offset = "0x7028B4")]
	private sealed class <CombatFinishFadeOutOverlay>d__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CombatStatusUpdater <>4__this;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ColorAdjustments <colorAdjusments>5__2;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <animatorReset>5__3;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <t>5__4;

		[Token(Token = "0x17000032")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x19523C4", Offset = "0x19523C4", VA = "0x19523C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x195240C", Offset = "0x195240C", VA = "0x195240C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1952088", Offset = "0x1952088", VA = "0x1952088")]
		[DebuggerHidden]
		public <CombatFinishFadeOutOverlay>d__62(int <>1__state)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x19520B4", Offset = "0x19520B4", VA = "0x19520B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x19520B8", Offset = "0x19520B8", VA = "0x19520B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x19523CC", Offset = "0x19523CC", VA = "0x19523CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject player;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private PlayerStatus pStatus;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private CharacterStatus cStatus;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CharacterAgent cAgent;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject statusPanel;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject loadingPanel;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject pausePanel;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject tutorialPanels;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Texture staminaOnIcon;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Texture staminaOn2Icon;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Texture powerOnIcon;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Texture powerOn2Icon;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Texture offIcon;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Texture off2Icon;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Material staminaOnMaterial;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Material powerOnMaterial;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Material offMaterial;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private RawImage playerImage;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Image playerHealth;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float playerInitialHeathImageWidth;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private float playerInitialHeathImageHeight;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private RawImage[] playerStaminaStatus;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private RawImage[] playerPowerStatus;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private MeshRenderer[,] staminaHand;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private MeshRenderer[,] powerHand;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private RawImage characterImage;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Image characterHealth;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float characterInitialHeathImageWidth;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private float characterInitialHeathImageHeight;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float roundTime;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private TextMeshProUGUI roundTimer;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private float finalPanelY;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private float currentPanelY;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private bool powerHandInitializated;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
	private bool staminaHandInitializated;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private string playerVictory1Name;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private string playerVictory2Name;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private string playerVictory1DeactivatedName;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private string playerVictory2DeactivatedName;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private string enemyVictory1Name;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private string enemyVictory2Name;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private string enemyVictory1DeactivatedName;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private string enemyVictory2DeactivatedName;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private GameObject playerVictory1;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private GameObject playerVictory2;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private GameObject playerVictory1Deactivated;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private GameObject playerVictory2Deactivated;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private GameObject enemyVictory1;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private GameObject enemyVictory2;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private GameObject enemyVictory1Deactivated;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private GameObject enemyVictory2Deactivated;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public TutorialController tutorialController;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public SpecialTutorialController specialTutorialController;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private bool resetTutorialPosition;

	[Token(Token = "0x600020B")]
	[Address(RVA = "0xAF7600", Offset = "0xAF7600", VA = "0xAF7600")]
	private void Start()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0xAF7F00", Offset = "0xAF7F00", VA = "0xAF7F00")]
	private void Update()
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0xAF7DC8", Offset = "0xAF7DC8", VA = "0xAF7DC8")]
	private void UpdateVictories()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0xAF8B64", Offset = "0xAF8B64", VA = "0xAF8B64")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xAF8CE0", Offset = "0xAF8CE0", VA = "0xAF8CE0")]
	public void UpdateStatusPanel()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0xAF85E0", Offset = "0xAF85E0", VA = "0xAF85E0")]
	private void CheckRoundFinish()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0xAF9B30", Offset = "0xAF9B30", VA = "0xAF9B30")]
	private void UpdateStatsOnFinishRound()
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0xAF9B04", Offset = "0xAF9B04", VA = "0xAF9B04")]
	private void FinishFadeOut()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0xAF9D08", Offset = "0xAF9D08", VA = "0xAF9D08")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x706C28", Offset = "0x706C28")]
	private IEnumerator CombatFinishFadeOutOverlay()
	{
		return null;
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0xAF93E8", Offset = "0xAF93E8", VA = "0xAF93E8")]
	private void UpdatePanelPosition()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0xAF849C", Offset = "0xAF849C", VA = "0xAF849C")]
	private bool IsCombatStarted()
	{
		return default(bool);
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0xAF9D80", Offset = "0xAF9D80", VA = "0xAF9D80")]
	public void ResetTutorialPanelPosition()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xAF9D8C", Offset = "0xAF9D8C", VA = "0xAF9D8C")]
	public CombatStatusUpdater()
	{
	}
}
[Token(Token = "0x2000046")]
public class ConfigurationInterface : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7028C4", Offset = "0x7028C4")]
	private sealed class <>c
	{
		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<TMP_Dropdown.OptionData> <>9__11_0;

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1952658", Offset = "0x1952658", VA = "0x1952658")]
		public <>c()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1952660", Offset = "0x1952660", VA = "0x1952660")]
		internal bool <Awake>b__11_0(TMP_Dropdown.OptionData option)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Slider roundTimeSlider;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Slider retriesSlider;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TMP_Dropdown languageDropdown;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Toggle combatMusicToggle;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public LanguageControl languageControl;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI languageLabel;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI playerHeight;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject heightCalibrationPanel;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string resetProfilePanelName;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject resetPanel;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool started;

	[Token(Token = "0x600021F")]
	[Address(RVA = "0xAFDA30", Offset = "0xAFDA30", VA = "0xAFDA30")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0xAFDCA4", Offset = "0xAFDCA4", VA = "0xAFDCA4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0xAFDD80", Offset = "0xAFDD80", VA = "0xAFDD80")]
	public void ResetPrefs()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0xAFDEC8", Offset = "0xAFDEC8", VA = "0xAFDEC8")]
	public void ShowResetWarningPanel()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0xAFDEA8", Offset = "0xAFDEA8", VA = "0xAFDEA8")]
	public void HideResetWarningPanel()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0xAFDE5C", Offset = "0xAFDE5C", VA = "0xAFDE5C")]
	public void ChangeLanguage()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0xAFDEE8", Offset = "0xAFDEE8", VA = "0xAFDEE8")]
	public void ChangeRoundTime()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0xAFDF94", Offset = "0xAFDF94", VA = "0xAFDF94")]
	public void ChangeRetries()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0xAFE034", Offset = "0xAFE034", VA = "0xAFE034")]
	public void ChangeCombatMusic()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0xAFE0A4", Offset = "0xAFE0A4", VA = "0xAFE0A4")]
	public ConfigurationInterface()
	{
	}
}
[Token(Token = "0x2000048")]
public class FightInterface : MonoBehaviour
{
	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string CHARACTERS_TEXTURES_FOLDER;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string prevCharacterImageObject;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string resumeLastObject;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string newChampionshipCharacterImageObject;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string mouseLeagueButtonObject;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string wolfLeagueButtonObject;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string tigerLeagueButtonObject;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string dragonLeagueButtonObject;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string extremeLeagueButtonObject;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string LostChampionshipWarningObject;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string DemoWarningObject;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string otherButtonsObject;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private string newChampionshipButtonsObject;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private GameObject prevCharacterImage;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private GameObject resumeLastButton;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameObject newChampionshipCharacterImage;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private GameObject otherButtons;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private GameObject newChampionshipButtons;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private GameObject mouseLeagueButton;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private GameObject wolfLeagueButton;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private GameObject tigerLeagueButton;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private GameObject dragonLeagueButton;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private GameObject extremeLeagueButton;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameObject lostChampionshipWarningPanel;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private GameObject demoWarningPanel;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Sprite easyResume;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Sprite mediumResume;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Sprite hardResume;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public Sprite proResume;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Image resumeDifficultyIcon;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public UINavigation uiNavigator;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private int afterWarningChampionshipDifficulty;

	[Token(Token = "0x600022D")]
	[Address(RVA = "0xB04744", Offset = "0xB04744", VA = "0xB04744")]
	private void Awake()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0xB048AC", Offset = "0xB048AC", VA = "0xB048AC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0xB04C9C", Offset = "0xB04C9C", VA = "0xB04C9C")]
	public void StartNewChampionship(int difficulty)
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0xB04DDC", Offset = "0xB04DDC", VA = "0xB04DDC")]
	public void ResumeChampionship()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0xB04E50", Offset = "0xB04E50", VA = "0xB04E50")]
	public void HideDemoWarningPanel()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0xB04EE0", Offset = "0xB04EE0", VA = "0xB04EE0")]
	public void ShowAfterWarningInterface()
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0xB04F38", Offset = "0xB04F38", VA = "0xB04F38")]
	public void HideAfterWarningInterface()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0xB04F90", Offset = "0xB04F90", VA = "0xB04F90")]
	public void StartAfterWarningChampionship()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0xB04FDC", Offset = "0xB04FDC", VA = "0xB04FDC")]
	public void NewEasyChampionship()
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0xB05040", Offset = "0xB05040", VA = "0xB05040")]
	public void NewMediumChampionship()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0xB050A4", Offset = "0xB050A4", VA = "0xB050A4")]
	public void NewHardChampionship()
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0xB05178", Offset = "0xB05178", VA = "0xB05178")]
	public void NewProChampionship()
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0xB0524C", Offset = "0xB0524C", VA = "0xB0524C")]
	public void NewExtremeChampionship()
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0xB05320", Offset = "0xB05320", VA = "0xB05320")]
	public FightInterface()
	{
	}
}
[Token(Token = "0x2000049")]
public class ImageBlink : MonoBehaviour
{
	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RawImage texture;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float multiplier;

	[Token(Token = "0x600023C")]
	[Address(RVA = "0xC0FC20", Offset = "0xC0FC20", VA = "0xC0FC20")]
	private void Awake()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xC0FC7C", Offset = "0xC0FC7C", VA = "0xC0FC7C")]
	public void ResetAlpha()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0xC0FCCC", Offset = "0xC0FCCC", VA = "0xC0FCCC")]
	private void Update()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0xC0FDB4", Offset = "0xC0FDB4", VA = "0xC0FDB4")]
	public ImageBlink()
	{
	}
}
[Token(Token = "0x200004A")]
public class MainMenu : MonoBehaviour
{
	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<string, GameObject> charactersFull;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string fullSuffix;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool started;

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xC161F0", Offset = "0xC161F0", VA = "0xC161F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0xC164B8", Offset = "0xC164B8", VA = "0xC164B8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0xC16688", Offset = "0xC16688", VA = "0xC16688")]
	public MainMenu()
	{
	}
}
[Token(Token = "0x200004B")]
public class SpecialSelect : MonoBehaviour
{
	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Color activeColor;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Color deactiveColor;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string specialName;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int panelIndex;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture selectedFrame;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Texture unselectedFrame;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AudioClip selectSound;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AudioClip enterSound;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject SpecialTutorialController;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string selectedSpecial;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static GameObject selectedSpecialButton;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private GameObject selectedSpecialName;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private GameObject selectedSpecialDamage;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private GameObject selectedSpecialBlockable;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameObject selectedSpecialDuration;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private GameObject selectedSpecialEffect;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private string currentHover;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private string frameObject;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private string selectedSpecialNameObject;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private string selectedSpecialDamageObject;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private string selectedSpecialBlockableObject;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private string selectedSpecialDurationObject;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private string selectedSpecialEffectObject;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private string buttonAudioSource;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private AudioSource buttonSound;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private bool started;

	[Token(Token = "0x6000243")]
	[Address(RVA = "0xB81F20", Offset = "0xB81F20", VA = "0xB81F20")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0xB82088", Offset = "0xB82088", VA = "0xB82088")]
	private void Start()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0xB8208C", Offset = "0xB8208C", VA = "0xB8208C")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0xB820F8", Offset = "0xB820F8", VA = "0xB820F8")]
	public void specialEnter()
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0xB822F4", Offset = "0xB822F4", VA = "0xB822F4")]
	public void specialExit()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0xB8239C", Offset = "0xB8239C", VA = "0xB8239C")]
	public void specialSelected(bool allowSound = true)
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0xB83120", Offset = "0xB83120", VA = "0xB83120")]
	public static int GetSelectedSpecial()
	{
		return default(int);
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0xB831D8", Offset = "0xB831D8", VA = "0xB831D8")]
	public SpecialSelect()
	{
	}
}
[Token(Token = "0x200004C")]
public class UINavigation : MonoBehaviour
{
	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject prevScreen;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject currentScreen;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject mainScreen;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject characterSelectionScreen;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject fightScreen;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject loadingCanvas;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject configurationScreen;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject calibrateHeightPanel;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject controlsScreen;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string mainScreenName;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string characterSelectionName;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private string fightScreenName;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string loadingCanvasName;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private string configurationScreenName;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private string calibrateHeightPanelName;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private string controlsScreenName;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private GameObject lastScreen;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private XRRayInteractor rightHandRay;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private XRRayInteractor leftHandRay;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool startLoadingHidden;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool sceneUnloading;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
	private bool firstUpdate;

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x194AF90", Offset = "0x194AF90", VA = "0x194AF90")]
	private void Awake()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x194B148", Offset = "0x194B148", VA = "0x194B148")]
	private void Start()
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x194B22C", Offset = "0x194B22C", VA = "0x194B22C")]
	private void Update()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x194B3E0", Offset = "0x194B3E0", VA = "0x194B3E0")]
	public void ShowCalibrateHeight()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x194B400", Offset = "0x194B400", VA = "0x194B400")]
	public void ShowConfigurationMenu()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x194B47C", Offset = "0x194B47C", VA = "0x194B47C")]
	public void ShowControlsInfo()
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x194B484", Offset = "0x194B484", VA = "0x194B484")]
	public void ShowMainMenu()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x194B48C", Offset = "0x194B48C", VA = "0x194B48C")]
	public void ShowCharacterSelection()
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x194B494", Offset = "0x194B494", VA = "0x194B494")]
	public void ShowFight()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x194B49C", Offset = "0x194B49C", VA = "0x194B49C")]
	public void GoBack()
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x194B408", Offset = "0x194B408", VA = "0x194B408")]
	private void UpdateCurrent(GameObject screen)
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x194B524", Offset = "0x194B524", VA = "0x194B524")]
	public void ShowLoading()
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x194B5A0", Offset = "0x194B5A0", VA = "0x194B5A0")]
	public void HideLoading()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x194B658", Offset = "0x194B658", VA = "0x194B658")]
	public void OnTrackingLost()
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x194B760", Offset = "0x194B760", VA = "0x194B760")]
	public void OnTrackingRestored()
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x194B868", Offset = "0x194B868", VA = "0x194B868")]
	public void LoadBasicTutorialWithResume()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x194B94C", Offset = "0x194B94C", VA = "0x194B94C")]
	public void LoadBasicTutorial()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x194BA30", Offset = "0x194BA30", VA = "0x194BA30")]
	public void LoadSpecialTutorial()
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x194BADC", Offset = "0x194BADC", VA = "0x194BADC")]
	public UINavigation()
	{
	}
}
[Token(Token = "0x200004D")]
public class SpawnEffect : MonoBehaviour
{
	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float spawnEffectTime;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float pause;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnimationCurve fadeIn;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ParticleSystem ps;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float timer;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Renderer _renderer;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int shaderProperty;

	[Token(Token = "0x600025E")]
	[Address(RVA = "0xB807E4", Offset = "0xB807E4", VA = "0xB807E4")]
	private void Start()
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0xB808DC", Offset = "0xB808DC", VA = "0xB808DC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0xB80998", Offset = "0xB80998", VA = "0xB80998")]
	public SpawnEffect()
	{
	}
}
[Token(Token = "0x200004E")]
public class WaterReflection : MonoBehaviour
{
	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Camera mainCamera;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Camera reflectionCamera;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7033BC", Offset = "0x7033BC")]
	public Transform reflectionPlane;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7033F4", Offset = "0x7033F4")]
	public RenderTexture outputTexture;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool copyCameraParamerers;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float verticalOffset;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool isReady;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform mainCamTransform;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform reflectionCamTransform;

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x194F30C", Offset = "0x194F30C", VA = "0x194F30C")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x194F4D8", Offset = "0x194F4D8", VA = "0x194F4D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x194F4E8", Offset = "0x194F4E8", VA = "0x194F4E8")]
	private void RenderReflection()
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x194F388", Offset = "0x194F388", VA = "0x194F388")]
	private void Validate()
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x194F6A4", Offset = "0x194F6A4", VA = "0x194F6A4")]
	public WaterReflection()
	{
	}
}
[Token(Token = "0x200004F")]
[ExecuteInEditMode]
public class OptimizeMesh : MonoBehaviour
{
	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x70342C", Offset = "0x70342C")]
	[SerializeField]
	private float _quality;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter _renderer;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Mesh _mesh;

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x130BA60", Offset = "0x130BA60", VA = "0x130BA60")]
	private void Start()
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x130BAE0", Offset = "0x130BAE0", VA = "0x130BAE0")]
	public OptimizeMesh()
	{
	}
}
[Token(Token = "0x2000050")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7028E4", Offset = "0x7028E4")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7028E4", Offset = "0x7028E4")]
public class MeshCombiner : MonoBehaviour
{
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702978", Offset = "0x702978")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MeshFilter[] meshFilters;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MeshCombiner <>4__this;

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1955DF0", Offset = "0x1955DF0", VA = "0x1955DF0")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1955DF8", Offset = "0x1955DF8", VA = "0x1955DF8")]
		internal bool <GetMeshFiltersToCombine>b__0(MeshFilter meshFilter)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702988", Offset = "0x702988")]
	private sealed class <>c__DisplayClass33_1
	{
		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public <>c__DisplayClass33_0 CS$<>8__locals1;

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1955E90", Offset = "0x1955E90", VA = "0x1955E90")]
		public <>c__DisplayClass33_1()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1955E98", Offset = "0x1955E98", VA = "0x1955E98")]
		internal bool <GetMeshFiltersToCombine>b__2(MeshFilter meshFilter)
		{
			return default(bool);
		}
	}

	[Serializable]
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702998", Offset = "0x702998")]
	private sealed class <>c
	{
		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<MeshFilter, bool> <>9__33_1;

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1955D80", Offset = "0x1955D80", VA = "0x1955D80")]
		public <>c()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1955D88", Offset = "0x1955D88", VA = "0x1955D88")]
		internal bool <GetMeshFiltersToCombine>b__33_1(MeshFilter meshFilter)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000317")]
	private const int Mesh16BitBufferVertexLimit = 65535;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool createMultiMaterialMesh;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[SerializeField]
	private bool combineInactiveChildren;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[SerializeField]
	private bool deactivateCombinedChildren;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[SerializeField]
	private bool deactivateCombinedChildrenMeshRenderers;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private bool generateUVMap;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[SerializeField]
	private bool destroyCombinedChildren;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string folderPath;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7034DC", Offset = "0x7034DC")]
	private MeshFilter[] meshFiltersToSkip;

	[Token(Token = "0x17000034")]
	public bool CreateMultiMaterialMesh
	{
		[Token(Token = "0x6000268")]
		[Address(RVA = "0xC17C18", Offset = "0xC17C18", VA = "0xC17C18")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000269")]
		[Address(RVA = "0xC17C20", Offset = "0xC17C20", VA = "0xC17C20")]
		set
		{
		}
	}

	[Token(Token = "0x17000035")]
	public bool CombineInactiveChildren
	{
		[Token(Token = "0x600026A")]
		[Address(RVA = "0xC17C2C", Offset = "0xC17C2C", VA = "0xC17C2C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600026B")]
		[Address(RVA = "0xC17C34", Offset = "0xC17C34", VA = "0xC17C34")]
		set
		{
		}
	}

	[Token(Token = "0x17000036")]
	public bool DeactivateCombinedChildren
	{
		[Token(Token = "0x600026C")]
		[Address(RVA = "0xC17C40", Offset = "0xC17C40", VA = "0xC17C40")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600026D")]
		[Address(RVA = "0xC17C48", Offset = "0xC17C48", VA = "0xC17C48")]
		set
		{
		}
	}

	[Token(Token = "0x17000037")]
	public bool DeactivateCombinedChildrenMeshRenderers
	{
		[Token(Token = "0x600026E")]
		[Address(RVA = "0xC17C7C", Offset = "0xC17C7C", VA = "0xC17C7C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600026F")]
		[Address(RVA = "0xC17C84", Offset = "0xC17C84", VA = "0xC17C84")]
		set
		{
		}
	}

	[Token(Token = "0x17000038")]
	public bool GenerateUVMap
	{
		[Token(Token = "0x6000270")]
		[Address(RVA = "0xC17CA4", Offset = "0xC17CA4", VA = "0xC17CA4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000271")]
		[Address(RVA = "0xC17CAC", Offset = "0xC17CAC", VA = "0xC17CAC")]
		set
		{
		}
	}

	[Token(Token = "0x17000039")]
	public bool DestroyCombinedChildren
	{
		[Token(Token = "0x6000272")]
		[Address(RVA = "0xC17CB8", Offset = "0xC17CB8", VA = "0xC17CB8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000273")]
		[Address(RVA = "0xC17CC0", Offset = "0xC17CC0", VA = "0xC17CC0")]
		set
		{
		}
	}

	[Token(Token = "0x1700003A")]
	public string FolderPath
	{
		[Token(Token = "0x6000274")]
		[Address(RVA = "0xC17CE4", Offset = "0xC17CE4", VA = "0xC17CE4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000275")]
		[Address(RVA = "0xC17CEC", Offset = "0xC17CEC", VA = "0xC17CEC")]
		set
		{
		}
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0xC17C64", Offset = "0xC17C64", VA = "0xC17C64")]
	private void CheckDeactivateCombinedChildren()
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0xC17CD4", Offset = "0xC17CD4", VA = "0xC17CD4")]
	private void CheckDestroyCombinedChildren()
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0xC17CF4", Offset = "0xC17CF4", VA = "0xC17CF4")]
	public void CombineMeshes(bool showCreatedMeshInfo)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0xC1952C", Offset = "0xC1952C", VA = "0xC1952C")]
	private MeshFilter[] GetMeshFiltersToCombine()
	{
		return null;
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0xC17F9C", Offset = "0xC17F9C", VA = "0xC17F9C")]
	private void CombineMeshesWithSingleMaterial(bool showCreatedMeshInfo)
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0xC1875C", Offset = "0xC1875C", VA = "0xC1875C")]
	private void CombineMeshesWithMutliMaterial(bool showCreatedMeshInfo)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0xC19868", Offset = "0xC19868", VA = "0xC19868")]
	private void DeactivateCombinedGameObjects(MeshFilter[] meshFilters)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0xC19864", Offset = "0xC19864", VA = "0xC19864")]
	private void GenerateUV(Mesh combinedMesh)
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0xC19A38", Offset = "0xC19A38", VA = "0xC19A38")]
	public MeshCombiner()
	{
	}
}
[Token(Token = "0x2000054")]
public class DebugUIBuilder : MonoBehaviour
{
	[Token(Token = "0x2000055")]
	public delegate void OnClick();

	[Token(Token = "0x2000056")]
	public delegate void OnToggleValueChange(Toggle t);

	[Token(Token = "0x2000057")]
	public delegate void OnSlider(float f);

	[Token(Token = "0x2000058")]
	public delegate bool ActiveUpdate();

	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7029A8", Offset = "0x7029A8")]
	private sealed class <>c__DisplayClass41_0
	{
		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnClick handler;

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1952930", Offset = "0x1952930", VA = "0x1952930")]
		public <>c__DisplayClass41_0()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1952938", Offset = "0x1952938", VA = "0x1952938")]
		internal void <AddButton>b__0()
		{
		}
	}

	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7029B8", Offset = "0x7029B8")]
	private sealed class <>c__DisplayClass43_0
	{
		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnSlider onValueChanged;

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1952B5C", Offset = "0x1952B5C", VA = "0x1952B5C")]
		public <>c__DisplayClass43_0()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x1952B64", Offset = "0x1952B64", VA = "0x1952B64")]
		internal void <AddSlider>b__0(float f)
		{
		}
	}

	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7029C8", Offset = "0x7029C8")]
	private sealed class <>c__DisplayClass45_0
	{
		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1952DB0", Offset = "0x1952DB0", VA = "0x1952DB0")]
		public <>c__DisplayClass45_0()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1952DB8", Offset = "0x1952DB8", VA = "0x1952DB8")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7029D8", Offset = "0x7029D8")]
	private sealed class <>c__DisplayClass46_0
	{
		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x1953150", Offset = "0x1953150", VA = "0x1953150")]
		public <>c__DisplayClass46_0()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x1953158", Offset = "0x1953158", VA = "0x1953158")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7029E8", Offset = "0x7029E8")]
	private sealed class <>c__DisplayClass47_0
	{
		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange handler;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle tb;

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1953178", Offset = "0x1953178", VA = "0x1953178")]
		public <>c__DisplayClass47_0()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1953180", Offset = "0x1953180", VA = "0x1953180")]
		internal void <AddRadio>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x4000326")]
	public const int DEBUG_PANE_CENTER = 0;

	[Token(Token = "0x4000327")]
	public const int DEBUG_PANE_RIGHT = 1;

	[Token(Token = "0x4000328")]
	public const int DEBUG_PANE_LEFT = 2;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform buttonPrefab;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform[] additionalButtonPrefab;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform labelPrefab;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform sliderPrefab;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform dividerPrefab;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform togglePrefab;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform radioPrefab;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject uiHelpersToInstantiate;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform[] targetContentPanels;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool[] reEnable;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<GameObject> toEnable;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private List<GameObject> toDisable;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DebugUIBuilder instance;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float elementSpacing;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float marginH;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float marginV;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector2[] insertPositions;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<RectTransform>[] insertedElements;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector3 menuOffset;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private OVRCameraRig rig;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Dictionary<string, ToggleGroup> radioGroups;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private LaserPointer lp;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private LineRenderer lr;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public LaserPointer.LaserBeamBehavior laserBeamBehavior;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public bool isHorizontal;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
	public bool usePanelCentricRelayout;

	[Token(Token = "0x6000286")]
	[Address(RVA = "0xAFF374", Offset = "0xAFF374", VA = "0xAFF374")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0xAFF8A8", Offset = "0xAFF8A8", VA = "0xAFF8A8")]
	public void Show()
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0xAFFC70", Offset = "0xAFFC70", VA = "0xAFFC70")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0xAFFE2C", Offset = "0xAFFE2C", VA = "0xAFFE2C")]
	private void StackedRelayout()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0xB0006C", Offset = "0xB0006C", VA = "0xB0006C")]
	private void PanelCentricRelayout()
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0xAFFC60", Offset = "0xAFFC60", VA = "0xAFFC60")]
	private void Relayout()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0xB0039C", Offset = "0xB0039C", VA = "0xB0039C")]
	private void AddRect(RectTransform r, int targetCanvas)
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0xB006BC", Offset = "0xB006BC", VA = "0xB006BC")]
	public RectTransform AddButton(string label, [Optional] OnClick handler, int buttonIndex = -1, int targetCanvas = 0, bool highResolutionText = false)
	{
		return null;
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0xB00A84", Offset = "0xB00A84", VA = "0xB00A84")]
	public RectTransform AddLabel(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0xB00B88", Offset = "0xB00B88", VA = "0xB00B88")]
	public RectTransform AddSlider(string label, float min, float max, OnSlider onValueChanged, bool wholeNumbersOnly = false, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0xB00D6C", Offset = "0xB00D6C", VA = "0xB00D6C")]
	public RectTransform AddDivider(int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0xB00E10", Offset = "0xB00E10", VA = "0xB00E10")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0xB01000", Offset = "0xB01000", VA = "0xB01000")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, bool defaultValue, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0xB01208", Offset = "0xB01208", VA = "0xB01208")]
	public RectTransform AddRadio(string label, string group, OnToggleValueChange handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0xB0150C", Offset = "0xB0150C", VA = "0xB0150C")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0xB01608", Offset = "0xB01608", VA = "0xB01608")]
	public void ToggleLaserPointer(bool isOn)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0xB016B4", Offset = "0xB016B4", VA = "0xB016B4")]
	public DebugUIBuilder()
	{
	}
}
[Token(Token = "0x200005E")]
public class HandedInputSelector : MonoBehaviour
{
	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRCameraRig m_CameraRig;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRInputModule m_InputModule;

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0xC0E174", Offset = "0xC0E174", VA = "0xC0E174")]
	private void Start()
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0xC0E224", Offset = "0xC0E224", VA = "0xC0E224")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0xC0E2E4", Offset = "0xC0E2E4", VA = "0xC0E2E4")]
	private void SetActiveController(OVRInput.Controller c)
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0xC0E320", Offset = "0xC0E320", VA = "0xC0E320")]
	public HandedInputSelector()
	{
	}
}
[Token(Token = "0x200005F")]
public class LaserPointer : OVRCursor
{
	[Token(Token = "0x2000060")]
	public enum LaserBeamBehavior
	{
		[Token(Token = "0x4000358")]
		On,
		[Token(Token = "0x4000359")]
		Off,
		[Token(Token = "0x400035A")]
		OnWhenHitTarget
	}

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cursorVisual;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxLength;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private LaserBeamBehavior _laserBeamBehavior;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_restoreOnInputAcquired;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 _startPoint;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 _forward;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 _endPoint;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _hitTarget;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x1700003B")]
	public LaserBeamBehavior laserBeamBehavior
	{
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xC130F4", Offset = "0xC130F4", VA = "0xC130F4")]
		get
		{
			return default(LaserBeamBehavior);
		}
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xC130B0", Offset = "0xC130B0", VA = "0xC130B0")]
		set
		{
		}
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0xC130FC", Offset = "0xC130FC", VA = "0xC130FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0xC13158", Offset = "0xC13158", VA = "0xC13158")]
	private void Start()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0xC1329C", Offset = "0xC1329C", VA = "0xC1329C", Slot = "5")]
	public override void SetCursorStartDest(Vector3 start, Vector3 dest, Vector3 normal)
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0xC132B8", Offset = "0xC132B8", VA = "0xC132B8", Slot = "4")]
	public override void SetCursorRay(Transform t)
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0xC1330C", Offset = "0xC1330C", VA = "0xC1330C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0xC134C8", Offset = "0xC134C8", VA = "0xC134C8")]
	private void UpdateLaserBeam(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0xC135DC", Offset = "0xC135DC", VA = "0xC135DC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0xC1366C", Offset = "0xC1366C", VA = "0xC1366C")]
	public void OnInputFocusLost()
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0xC13738", Offset = "0xC13738", VA = "0xC13738")]
	public void OnInputFocusAcquired()
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0xC137EC", Offset = "0xC137EC", VA = "0xC137EC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0xC138D8", Offset = "0xC138D8", VA = "0xC138D8")]
	public LaserPointer()
	{
	}
}
[Token(Token = "0x2000061")]
public class CharacterCameraConstraint : MonoBehaviour
{
	[Token(Token = "0x400035B")]
	private const float FADE_RAY_LENGTH = 0.25f;

	[Token(Token = "0x400035C")]
	private const float FADE_OVERLAP_MAXIMUM = 0.1f;

	[Token(Token = "0x400035D")]
	private const float FADE_AMOUNT_MAXIMUM = 1f;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7035E8", Offset = "0x7035E8")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703620", Offset = "0x703620")]
	public LayerMask CollideLayers;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703658", Offset = "0x703658")]
	public float HeightOffset;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703690", Offset = "0x703690")]
	public float MinimumHeight;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7036C8", Offset = "0x7036C8")]
	public float MaximumHeight;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CapsuleCollider _character;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SimpleCapsuleWithStickMovement _simplePlayerController;

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0xCE493C", Offset = "0xCE493C", VA = "0xCE493C")]
	private CharacterCameraConstraint()
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0xCE4944", Offset = "0xCE4944", VA = "0xCE4944")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0xCE49D0", Offset = "0xCE49D0", VA = "0xCE49D0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0xCE4A64", Offset = "0xCE4A64", VA = "0xCE4A64")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0xCE4AF8", Offset = "0xCE4AF8", VA = "0xCE4AF8")]
	private void CameraUpdate()
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0xCE4E24", Offset = "0xCE4E24", VA = "0xCE4E24")]
	private bool CheckCameraOverlapped()
	{
		return default(bool);
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0xCE5054", Offset = "0xCE5054", VA = "0xCE5054")]
	private bool CheckCameraNearClipping(out float result)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000062")]
public class LocomotionController : MonoBehaviour
{
	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CapsuleCollider CharacterController;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimpleCapsuleWithStickMovement PlayerController;

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0xC13A88", Offset = "0xC13A88", VA = "0xC13A88")]
	private void Start()
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0xC13B54", Offset = "0xC13B54", VA = "0xC13B54")]
	public LocomotionController()
	{
	}
}
[Token(Token = "0x2000063")]
public class LocomotionTeleport : MonoBehaviour
{
	[Token(Token = "0x2000064")]
	public enum States
	{
		[Token(Token = "0x400038B")]
		Ready,
		[Token(Token = "0x400038C")]
		Aim,
		[Token(Token = "0x400038D")]
		CancelAim,
		[Token(Token = "0x400038E")]
		PreTeleport,
		[Token(Token = "0x400038F")]
		CancelTeleport,
		[Token(Token = "0x4000390")]
		Teleporting,
		[Token(Token = "0x4000391")]
		PostTeleport
	}

	[Token(Token = "0x2000065")]
	public enum TeleportIntentions
	{
		[Token(Token = "0x4000393")]
		None,
		[Token(Token = "0x4000394")]
		Aim,
		[Token(Token = "0x4000395")]
		PreTeleport,
		[Token(Token = "0x4000396")]
		Teleport
	}

	[Token(Token = "0x2000066")]
	public enum AimCollisionTypes
	{
		[Token(Token = "0x4000398")]
		Point,
		[Token(Token = "0x4000399")]
		Sphere,
		[Token(Token = "0x400039A")]
		Capsule
	}

	[Token(Token = "0x2000067")]
	public class AimData
	{
		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RaycastHit TargetHitInfo;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool TargetValid;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3? Destination;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float Radius;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703AE0", Offset = "0x703AE0")]
		private List<Vector3> <Points>k__BackingField;

		[Token(Token = "0x1700003F")]
		public List<Vector3> Points
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x1955CAC", Offset = "0x1955CAC", VA = "0x1955CAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707150", Offset = "0x707150")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x1955CB4", Offset = "0x1955CB4", VA = "0x1955CB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707160", Offset = "0x707160")]
			private set
			{
			}
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x1955C28", Offset = "0x1955C28", VA = "0x1955C28")]
		public AimData()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x1955CBC", Offset = "0x1955CBC", VA = "0x1955CBC")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7029F8", Offset = "0x7029F8")]
	private sealed class <ReadyStateCoroutine>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000040")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x1955A74", Offset = "0x1955A74", VA = "0x1955A74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x1955ABC", Offset = "0x1955ABC", VA = "0x1955ABC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x1955938", Offset = "0x1955938", VA = "0x1955938")]
		[DebuggerHidden]
		public <ReadyStateCoroutine>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x1955964", Offset = "0x1955964", VA = "0x1955964", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1955968", Offset = "0x1955968", VA = "0x1955968", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x1955A7C", Offset = "0x1955A7C", VA = "0x1955A7C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702A08", Offset = "0x702A08")]
	private sealed class <AimStateCoroutine>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000042")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x19553A4", Offset = "0x19553A4", VA = "0x19553A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x19553EC", Offset = "0x19553EC", VA = "0x19553EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x195521C", Offset = "0x195521C", VA = "0x195521C")]
		[DebuggerHidden]
		public <AimStateCoroutine>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1955248", Offset = "0x1955248", VA = "0x1955248", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x195524C", Offset = "0x195524C", VA = "0x195524C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x19553AC", Offset = "0x19553AC", VA = "0x19553AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702A18", Offset = "0x702A18")]
	private sealed class <CancelAimStateCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000044")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x19554D0", Offset = "0x19554D0", VA = "0x19554D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x1955518", Offset = "0x1955518", VA = "0x1955518", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x19553F4", Offset = "0x19553F4", VA = "0x19553F4")]
		[DebuggerHidden]
		public <CancelAimStateCoroutine>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1955420", Offset = "0x1955420", VA = "0x1955420", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1955424", Offset = "0x1955424", VA = "0x1955424", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x19554D8", Offset = "0x19554D8", VA = "0x19554D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702A28", Offset = "0x702A28")]
	private sealed class <PreTeleportStateCoroutine>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000046")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x19558E8", Offset = "0x19558E8", VA = "0x19558E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x1955930", Offset = "0x1955930", VA = "0x1955930", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x19557CC", Offset = "0x19557CC", VA = "0x19557CC")]
		[DebuggerHidden]
		public <PreTeleportStateCoroutine>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x19557F8", Offset = "0x19557F8", VA = "0x19557F8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x19557FC", Offset = "0x19557FC", VA = "0x19557FC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x19558F0", Offset = "0x19558F0", VA = "0x19558F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702A38", Offset = "0x702A38")]
	private sealed class <CancelTeleportStateCoroutine>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000048")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x19555FC", Offset = "0x19555FC", VA = "0x19555FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x1955644", Offset = "0x1955644", VA = "0x1955644", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1955520", Offset = "0x1955520", VA = "0x1955520")]
		[DebuggerHidden]
		public <CancelTeleportStateCoroutine>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x195554C", Offset = "0x195554C", VA = "0x195554C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1955550", Offset = "0x1955550", VA = "0x1955550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1955604", Offset = "0x1955604", VA = "0x1955604", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702A48", Offset = "0x702A48")]
	private sealed class <TeleportingStateCoroutine>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700004A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x1955BD8", Offset = "0x1955BD8", VA = "0x1955BD8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x1955C20", Offset = "0x1955C20", VA = "0x1955C20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1955AC4", Offset = "0x1955AC4", VA = "0x1955AC4")]
		[DebuggerHidden]
		public <TeleportingStateCoroutine>d__80(int <>1__state)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1955AF0", Offset = "0x1955AF0", VA = "0x1955AF0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1955AF4", Offset = "0x1955AF4", VA = "0x1955AF4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1955BE0", Offset = "0x1955BE0", VA = "0x1955BE0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702A58", Offset = "0x702A58")]
	private sealed class <PostTeleportStateCoroutine>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700004C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x195577C", Offset = "0x195577C", VA = "0x195577C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x19557C4", Offset = "0x19557C4", VA = "0x19557C4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x195564C", Offset = "0x195564C", VA = "0x195564C")]
		[DebuggerHidden]
		public <PostTeleportStateCoroutine>d__84(int <>1__state)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1955678", Offset = "0x1955678", VA = "0x1955678", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x195567C", Offset = "0x195567C", VA = "0x195567C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1955784", Offset = "0x1955784", VA = "0x1955784", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703700", Offset = "0x703700")]
	public bool EnableMovementDuringReady;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703738", Offset = "0x703738")]
	public bool EnableMovementDuringAim;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703770", Offset = "0x703770")]
	public bool EnableMovementDuringPreTeleport;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7037A8", Offset = "0x7037A8")]
	public bool EnableMovementDuringPostTeleport;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7037E0", Offset = "0x7037E0")]
	public bool EnableRotationDuringReady;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703818", Offset = "0x703818")]
	public bool EnableRotationDuringAim;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703850", Offset = "0x703850")]
	public bool EnableRotationDuringPreTeleport;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703888", Offset = "0x703888")]
	public bool EnableRotationDuringPostTeleport;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7038C0", Offset = "0x7038C0")]
	private States <CurrentState>k__BackingField;

	[NonSerialized]
	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TeleportAimHandler AimHandler;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7038D0", Offset = "0x7038D0")]
	public TeleportDestination TeleportDestinationPrefab;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703908", Offset = "0x703908")]
	public int TeleportDestinationLayer;

	[NonSerialized]
	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TeleportInputHandler InputHandler;

	[NonSerialized]
	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TeleportIntentions CurrentIntention;

	[NonSerialized]
	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool IsPreTeleportRequested;

	[NonSerialized]
	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool IsTransitioning;

	[NonSerialized]
	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool IsPostTeleportRequested;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TeleportDestination _teleportDestination;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703950", Offset = "0x703950")]
	private LocomotionController <LocomotionController>k__BackingField;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703960", Offset = "0x703960")]
	public AimCollisionTypes AimCollisionType;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703998", Offset = "0x703998")]
	public bool UseCharacterCollisionData;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7039D0", Offset = "0x7039D0")]
	public float AimCollisionRadius;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703A08", Offset = "0x703A08")]
	public float AimCollisionHeight;

	[Token(Token = "0x1700003C")]
	public States CurrentState
	{
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xC14650", Offset = "0xC14650", VA = "0xC14650")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706CD8", Offset = "0x706CD8")]
		get
		{
			return default(States);
		}
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xC14658", Offset = "0xC14658", VA = "0xC14658")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706CE8", Offset = "0x706CE8")]
		private set
		{
		}
	}

	[Token(Token = "0x1700003D")]
	public Quaternion DestinationRotation
	{
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xC1487C", Offset = "0xC1487C", VA = "0xC1487C")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x1700003E")]
	public LocomotionController LocomotionController
	{
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xC148A4", Offset = "0xC148A4", VA = "0xC148A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706D18", Offset = "0x706D18")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xC148AC", Offset = "0xC148AC", VA = "0xC148AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706D28", Offset = "0x706D28")]
		private set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event Action<bool, Vector3?, Quaternion?, Quaternion?> UpdateTeleportDestination
	{
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xC14660", Offset = "0xC14660", VA = "0xC14660")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706CF8", Offset = "0x706CF8")]
		add
		{
		}
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xC14700", Offset = "0xC14700", VA = "0xC14700")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706D08", Offset = "0x706D08")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event Action EnterStateReady
	{
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xC14EEC", Offset = "0xC14EEC", VA = "0xC14EEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706D70", Offset = "0x706D70")]
		add
		{
		}
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xC14F8C", Offset = "0xC14F8C", VA = "0xC14F8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706D80", Offset = "0x706D80")]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event Action EnterStateAim
	{
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xC1502C", Offset = "0xC1502C", VA = "0xC1502C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706DF0", Offset = "0x706DF0")]
		add
		{
		}
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xC150CC", Offset = "0xC150CC", VA = "0xC150CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706E00", Offset = "0x706E00")]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event Action<AimData> UpdateAimData
	{
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xC1516C", Offset = "0xC1516C", VA = "0xC1516C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706E10", Offset = "0x706E10")]
		add
		{
		}
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xC1520C", Offset = "0xC1520C", VA = "0xC1520C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706E20", Offset = "0x706E20")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event Action ExitStateAim
	{
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xC1531C", Offset = "0xC1531C", VA = "0xC1531C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706E30", Offset = "0x706E30")]
		add
		{
		}
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xC153BC", Offset = "0xC153BC", VA = "0xC153BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706E40", Offset = "0x706E40")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event Action EnterStateCancelAim
	{
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xC154D4", Offset = "0xC154D4", VA = "0xC154D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706EB0", Offset = "0x706EB0")]
		add
		{
		}
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xC15574", Offset = "0xC15574", VA = "0xC15574")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706EC0", Offset = "0x706EC0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public event Action EnterStatePreTeleport
	{
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xC1568C", Offset = "0xC1568C", VA = "0xC1568C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706F30", Offset = "0x706F30")]
		add
		{
		}
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xC1572C", Offset = "0xC1572C", VA = "0xC1572C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706F40", Offset = "0x706F40")]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event Action EnterStateCancelTeleport
	{
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xC15844", Offset = "0xC15844", VA = "0xC15844")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706FB0", Offset = "0x706FB0")]
		add
		{
		}
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xC158E4", Offset = "0xC158E4", VA = "0xC158E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x706FC0", Offset = "0x706FC0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event Action EnterStateTeleporting
	{
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xC159FC", Offset = "0xC159FC", VA = "0xC159FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707030", Offset = "0x707030")]
		add
		{
		}
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xC15A9C", Offset = "0xC15A9C", VA = "0xC15A9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707040", Offset = "0x707040")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action EnterStatePostTeleport
	{
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xC15BB4", Offset = "0xC15BB4", VA = "0xC15BB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7070B0", Offset = "0x7070B0")]
		add
		{
		}
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xC15C54", Offset = "0xC15C54", VA = "0xC15C54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7070C0", Offset = "0x7070C0")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action<Transform, Vector3, Quaternion> Teleported
	{
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xC15D6C", Offset = "0xC15D6C", VA = "0xC15D6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707130", Offset = "0x707130")]
		add
		{
		}
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xC15E0C", Offset = "0xC15E0C", VA = "0xC15E0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707140", Offset = "0x707140")]
		remove
		{
		}
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0xC142FC", Offset = "0xC142FC", VA = "0xC142FC")]
	public void EnableMovement(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0xC14320", Offset = "0xC14320", VA = "0xC14320")]
	public void EnableRotation(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0xC147A0", Offset = "0xC147A0", VA = "0xC147A0")]
	public void OnUpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0xC148B4", Offset = "0xC148B4", VA = "0xC148B4")]
	public bool AimCollisionTest(Vector3 start, Vector3 end, LayerMask aimCollisionLayerMask, out RaycastHit hitInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0xC14B00", Offset = "0xC14B00", VA = "0xC14B00")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x706D38", Offset = "0x706D38")]
	protected void LogState(string msg)
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0xC14BB4", Offset = "0xC14BB4", VA = "0xC14BB4")]
	protected void CreateNewTeleportDestination()
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0xC14CB4", Offset = "0xC14CB4", VA = "0xC14CB4")]
	private void DeactivateDestination()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xC14CD0", Offset = "0xC14CD0", VA = "0xC14CD0")]
	public void RecycleTeleportDestination(TeleportDestination oldDestination)
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0xC14D94", Offset = "0xC14D94", VA = "0xC14D94")]
	private void EnableMotion(bool enableLinear, bool enableRotation)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0xC14DD8", Offset = "0xC14DD8", VA = "0xC14DD8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0xC14E3C", Offset = "0xC14E3C", VA = "0xC14E3C", Slot = "4")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0xC14EE4", Offset = "0xC14EE4", VA = "0xC14EE4", Slot = "5")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0xC14E6C", Offset = "0xC14E6C", VA = "0xC14E6C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x706D90", Offset = "0x706D90")]
	protected IEnumerator ReadyStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0xC152AC", Offset = "0xC152AC", VA = "0xC152AC")]
	public void OnUpdateAimData(AimData aimData)
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0xC1545C", Offset = "0xC1545C", VA = "0xC1545C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x706E50", Offset = "0x706E50")]
	protected IEnumerator AimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0xC15614", Offset = "0xC15614", VA = "0xC15614")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x706ED0", Offset = "0x706ED0")]
	protected IEnumerator CancelAimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0xC157CC", Offset = "0xC157CC", VA = "0xC157CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x706F50", Offset = "0x706F50")]
	protected IEnumerator PreTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0xC15984", Offset = "0xC15984", VA = "0xC15984")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x706FD0", Offset = "0x706FD0")]
	protected IEnumerator CancelTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0xC15B3C", Offset = "0xC15B3C", VA = "0xC15B3C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x707050", Offset = "0x707050")]
	protected IEnumerator TeleportingStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0xC15CF4", Offset = "0xC15CF4", VA = "0xC15CF4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7070D0", Offset = "0x7070D0")]
	protected IEnumerator PostTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0xC15EAC", Offset = "0xC15EAC", VA = "0xC15EAC")]
	public void DoTeleport()
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0xC15FEC", Offset = "0xC15FEC", VA = "0xC15FEC")]
	public Vector3 GetCharacterPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0xC16020", Offset = "0xC16020", VA = "0xC16020")]
	public Quaternion GetHeadRotationY()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0xC160E8", Offset = "0xC160E8", VA = "0xC160E8")]
	public void DoWarp(Vector3 startPos, float positionPercent)
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0xC161E0", Offset = "0xC161E0", VA = "0xC161E0")]
	public LocomotionTeleport()
	{
	}
}
[Token(Token = "0x200006F")]
public class SimpleCapsuleWithStickMovement : MonoBehaviour
{
	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableLinearMovement;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool EnableRotation;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool HMDRotatesPlayer;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool RotationEitherThumbstick;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float RotationAngle;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool ReadyToSnapTurn;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x1400000C")]
	public event Action CameraUpdated
	{
		[Token(Token = "0x600032D")]
		[Address(RVA = "0xB7E7BC", Offset = "0xB7E7BC", VA = "0xB7E7BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7073A0", Offset = "0x7073A0")]
		add
		{
		}
		[Token(Token = "0x600032E")]
		[Address(RVA = "0xB7E85C", Offset = "0xB7E85C", VA = "0xB7E85C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7073B0", Offset = "0x7073B0")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event Action PreCharacterMove
	{
		[Token(Token = "0x600032F")]
		[Address(RVA = "0xB7E8FC", Offset = "0xB7E8FC", VA = "0xB7E8FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7073C0", Offset = "0x7073C0")]
		add
		{
		}
		[Token(Token = "0x6000330")]
		[Address(RVA = "0xB7E99C", Offset = "0xB7E99C", VA = "0xB7E99C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7073D0", Offset = "0x7073D0")]
		remove
		{
		}
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0xB7EA3C", Offset = "0xB7EA3C", VA = "0xB7EA3C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0xB7EB28", Offset = "0xB7EB28", VA = "0xB7EB28")]
	private void Start()
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0xB7EB2C", Offset = "0xB7EB2C", VA = "0xB7EB2C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0xB7EBA0", Offset = "0xB7EBA0", VA = "0xB7EBA0")]
	private void RotatePlayerToHMD()
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0xB7ECC4", Offset = "0xB7ECC4", VA = "0xB7ECC4")]
	private void StickMovement()
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0xB7EEAC", Offset = "0xB7EEAC", VA = "0xB7EEAC")]
	private void SnapTurn()
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0xB7F0B4", Offset = "0xB7F0B4", VA = "0xB7F0B4")]
	public SimpleCapsuleWithStickMovement()
	{
	}
}
[Token(Token = "0x2000070")]
public abstract class TeleportAimHandler : TeleportSupport
{
	[Token(Token = "0x6000338")]
	[Address(RVA = "0xB86128", Offset = "0xB86128", VA = "0xB86128", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0xB861C8", Offset = "0xB861C8", VA = "0xB861C8", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600033A")]
	public abstract void GetPoints(List<Vector3> points);

	[Token(Token = "0x600033B")]
	[Address(RVA = "0xB862B8", Offset = "0xB862B8", VA = "0xB862B8")]
	protected TeleportAimHandler()
	{
	}
}
[Token(Token = "0x2000071")]
public class TeleportAimHandlerLaser : TeleportAimHandler
{
	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703B10", Offset = "0x703B10")]
	public float Range;

	[Token(Token = "0x600033C")]
	[Address(RVA = "0xB862C8", Offset = "0xB862C8", VA = "0xB862C8", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0xB863C4", Offset = "0xB863C4", VA = "0xB863C4")]
	public TeleportAimHandlerLaser()
	{
	}
}
[Token(Token = "0x2000072")]
public class TeleportAimHandlerParabolic : TeleportAimHandler
{
	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703B48", Offset = "0x703B48")]
	public float Range;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703B80", Offset = "0x703B80")]
	public float MinimumElevation;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703BB8", Offset = "0x703BB8")]
	public float Gravity;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x703BF0", Offset = "0x703BF0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703BF0", Offset = "0x703BF0")]
	public float AimVelocity;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x703C4C", Offset = "0x703C4C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703C4C", Offset = "0x703C4C")]
	public float AimStep;

	[Token(Token = "0x600033E")]
	[Address(RVA = "0xB863D4", Offset = "0xB863D4", VA = "0xB863D4", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0xB86564", Offset = "0xB86564", VA = "0xB86564")]
	public TeleportAimHandlerParabolic()
	{
	}
}
[Token(Token = "0x2000073")]
public class TeleportAimVisualLaser : TeleportSupport
{
	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703CA4", Offset = "0x703CA4")]
	public LineRenderer LaserPrefab;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _enterAimStateAction;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Action _exitAimStateAction;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] _linePoints;

	[Token(Token = "0x6000340")]
	[Address(RVA = "0xB86578", Offset = "0xB86578", VA = "0xB86578")]
	public TeleportAimVisualLaser()
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0xB866B4", Offset = "0xB866B4", VA = "0xB866B4")]
	private void EnterAimState()
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0xB866E4", Offset = "0xB866E4", VA = "0xB866E4")]
	private void ExitAimState()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0xB86714", Offset = "0xB86714", VA = "0xB86714")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0xB867C4", Offset = "0xB867C4", VA = "0xB867C4", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0xB86830", Offset = "0xB86830", VA = "0xB86830", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0xB86898", Offset = "0xB86898", VA = "0xB86898")]
	private void UpdateAimData(LocomotionTeleport.AimData obj)
	{
	}
}
[Token(Token = "0x2000074")]
public class TeleportDestination : MonoBehaviour
{
	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703CDC", Offset = "0x703CDC")]
	private bool <IsValidDestination>k__BackingField;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703CEC", Offset = "0x703CEC")]
	public Transform PositionIndicator;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703D24", Offset = "0x703D24")]
	public Transform OrientationIndicator;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703D5C", Offset = "0x703D5C")]
	public Quaternion LandingRotation;

	[NonSerialized]
	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocomotionTeleport LocomotionTeleport;

	[NonSerialized]
	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LocomotionTeleport.States TeleportState;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action<bool, Vector3?, Quaternion?, Quaternion?> _updateTeleportDestinationAction;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _eventsActive;

	[Token(Token = "0x1700004E")]
	public bool IsValidDestination
	{
		[Token(Token = "0x6000347")]
		[Address(RVA = "0xB869BC", Offset = "0xB869BC", VA = "0xB869BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7073E0", Offset = "0x7073E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000348")]
		[Address(RVA = "0xB869C4", Offset = "0xB869C4", VA = "0xB869C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7073F0", Offset = "0x7073F0")]
		private set
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public event Action<TeleportDestination> Deactivated
	{
		[Token(Token = "0x600034D")]
		[Address(RVA = "0xB86B80", Offset = "0xB86B80", VA = "0xB86B80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707400", Offset = "0x707400")]
		add
		{
		}
		[Token(Token = "0x600034E")]
		[Address(RVA = "0xB86C20", Offset = "0xB86C20", VA = "0xB86C20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707410", Offset = "0x707410")]
		remove
		{
		}
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0xB869D0", Offset = "0xB869D0", VA = "0xB869D0")]
	private TeleportDestination()
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0xB86A68", Offset = "0xB86A68", VA = "0xB86A68")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0xB86B3C", Offset = "0xB86B3C", VA = "0xB86B3C")]
	private void TryDisableEventHandlers()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0xB86B7C", Offset = "0xB86B7C", VA = "0xB86B7C")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0xB86CC0", Offset = "0xB86CC0", VA = "0xB86CC0")]
	public void OnDeactivated()
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0xB86D24", Offset = "0xB86D24", VA = "0xB86D24")]
	public void Recycle()
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0xB86D44", Offset = "0xB86D44", VA = "0xB86D44", Slot = "4")]
	public virtual void UpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}
}
[Token(Token = "0x2000075")]
public abstract class TeleportInputHandler : TeleportSupport
{
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702A68", Offset = "0x702A68")]
	private sealed class <TeleportReadyCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x1700004F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x191CC84", Offset = "0x191CC84", VA = "0x191CC84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x191CCCC", Offset = "0x191CCCC", VA = "0x191CCCC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x191CBBC", Offset = "0x191CBBC", VA = "0x191CBBC")]
		[DebuggerHidden]
		public <TeleportReadyCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x191CBE8", Offset = "0x191CBE8", VA = "0x191CBE8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x191CBEC", Offset = "0x191CBEC", VA = "0x191CBEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x191CC8C", Offset = "0x191CC8C", VA = "0x191CC8C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702A78", Offset = "0x702A78")]
	private sealed class <TeleportAimCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x17000051")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x191CB6C", Offset = "0x191CB6C", VA = "0x191CB6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x191CBB4", Offset = "0x191CBB4", VA = "0x191CBB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x191CAA0", Offset = "0x191CAA0", VA = "0x191CAA0")]
		[DebuggerHidden]
		public <TeleportAimCoroutine>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x191CACC", Offset = "0x191CACC", VA = "0x191CACC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x191CAD0", Offset = "0x191CAD0", VA = "0x191CAD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x191CB74", Offset = "0x191CB74", VA = "0x191CB74", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _startReadyAction;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x6000352")]
	[Address(RVA = "0xB86F50", Offset = "0xB86F50", VA = "0xB86F50")]
	protected TeleportInputHandler()
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0xB87024", Offset = "0xB87024", VA = "0xB87024", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0xB87084", Offset = "0xB87084", VA = "0xB87084", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0xB87144", Offset = "0xB87144", VA = "0xB87144")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x707420", Offset = "0x707420")]
	private IEnumerator TeleportReadyCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0xB871BC", Offset = "0xB871BC", VA = "0xB871BC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x707480", Offset = "0x707480")]
	private IEnumerator TeleportAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000357")]
	public abstract LocomotionTeleport.TeleportIntentions GetIntention();

	[Token(Token = "0x6000358")]
	public abstract void GetAimData(out Ray aimRay);

	[Token(Token = "0x6000359")]
	[Address(RVA = "0xB87234", Offset = "0xB87234", VA = "0xB87234")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7074E0", Offset = "0x7074E0")]
	private void <.ctor>b__2_0()
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0xB87260", Offset = "0xB87260", VA = "0xB87260")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7074F0", Offset = "0x7074F0")]
	private void <.ctor>b__2_1()
	{
	}
}
[Token(Token = "0x2000078")]
public class TeleportInputHandlerHMD : TeleportInputHandler
{
	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x703DA4", Offset = "0x703DA4")]
	private Transform <Pointer>k__BackingField;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703DB4", Offset = "0x703DB4")]
	public OVRInput.RawButton AimButton;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703DEC", Offset = "0x703DEC")]
	public OVRInput.RawButton TeleportButton;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703E24", Offset = "0x703E24")]
	public bool FastTeleport;

	[Token(Token = "0x17000053")]
	public Transform Pointer
	{
		[Token(Token = "0x6000367")]
		[Address(RVA = "0xB8728C", Offset = "0xB8728C", VA = "0xB8728C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7075A0", Offset = "0x7075A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000368")]
		[Address(RVA = "0xB87294", Offset = "0xB87294", VA = "0xB87294")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7075B0", Offset = "0x7075B0")]
		private set
		{
		}
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0xB8729C", Offset = "0xB8729C", VA = "0xB8729C", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0xB873F4", Offset = "0xB873F4", VA = "0xB873F4", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0xB874AC", Offset = "0xB874AC", VA = "0xB874AC")]
	public TeleportInputHandlerHMD()
	{
	}
}
[Token(Token = "0x2000079")]
public class TeleportInputHandlerTouch : TeleportInputHandlerHMD
{
	[Token(Token = "0x200007A")]
	public enum InputModes
	{
		[Token(Token = "0x40003EB")]
		CapacitiveButtonForAimAndTeleport,
		[Token(Token = "0x40003EC")]
		SeparateButtonsForAimAndTeleport,
		[Token(Token = "0x40003ED")]
		ThumbstickTeleport,
		[Token(Token = "0x40003EE")]
		ThumbstickTeleportForwardBackOnly
	}

	[Token(Token = "0x200007B")]
	public enum AimCapTouchButtons
	{
		[Token(Token = "0x40003F0")]
		A,
		[Token(Token = "0x40003F1")]
		B,
		[Token(Token = "0x40003F2")]
		LeftTrigger,
		[Token(Token = "0x40003F3")]
		LeftThumbstick,
		[Token(Token = "0x40003F4")]
		RightTrigger,
		[Token(Token = "0x40003F5")]
		RightThumbstick,
		[Token(Token = "0x40003F6")]
		X,
		[Token(Token = "0x40003F7")]
		Y
	}

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform LeftHand;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform RightHand;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703E5C", Offset = "0x703E5C")]
	public InputModes InputMode;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly OVRInput.RawButton[] _rawButtons;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly OVRInput.RawTouch[] _rawTouch;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703E94", Offset = "0x703E94")]
	public OVRInput.Controller AimingController;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private OVRInput.Controller InitiatingController;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703ECC", Offset = "0x703ECC")]
	public AimCapTouchButtons CapacitiveAimAndTeleportButton;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703F04", Offset = "0x703F04")]
	public float ThumbstickTeleportThreshold;

	[Token(Token = "0x600036C")]
	[Address(RVA = "0xB874B0", Offset = "0xB874B0", VA = "0xB874B0")]
	private void Start()
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0xB874B4", Offset = "0xB874B4", VA = "0xB874B4", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0xB8789C", Offset = "0xB8789C", VA = "0xB8789C", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0xB8795C", Offset = "0xB8795C", VA = "0xB8795C")]
	public TeleportInputHandlerTouch()
	{
	}
}
[Token(Token = "0x200007C")]
public abstract class TeleportOrientationHandler : TeleportSupport
{
	[Token(Token = "0x200007D")]
	public enum OrientationModes
	{
		[Token(Token = "0x40003FC")]
		HeadRelative,
		[Token(Token = "0x40003FD")]
		ForwardFacing
	}

	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702A88", Offset = "0x702A88")]
	private sealed class <UpdateOrientationCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportOrientationHandler <>4__this;

		[Token(Token = "0x17000054")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x191CDB4", Offset = "0x191CDB4", VA = "0x191CDB4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x191CDFC", Offset = "0x191CDFC", VA = "0x191CDFC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x191CCD4", Offset = "0x191CCD4", VA = "0x191CCD4")]
		[DebuggerHidden]
		public <UpdateOrientationCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x191CD00", Offset = "0x191CD00", VA = "0x191CD00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x191CD04", Offset = "0x191CD04", VA = "0x191CD04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x191CDBC", Offset = "0x191CDBC", VA = "0x191CDBC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _updateOrientationAction;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected LocomotionTeleport.AimData AimData;

	[Token(Token = "0x6000370")]
	[Address(RVA = "0xB87A40", Offset = "0xB87A40", VA = "0xB87A40")]
	protected TeleportOrientationHandler()
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0xB87B34", Offset = "0xB87B34", VA = "0xB87B34")]
	private void UpdateAimData(LocomotionTeleport.AimData aimData)
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0xB87B3C", Offset = "0xB87B3C", VA = "0xB87B3C", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0xB87B88", Offset = "0xB87B88", VA = "0xB87B88", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0xB87BD0", Offset = "0xB87BD0", VA = "0xB87BD0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7075C0", Offset = "0x7075C0")]
	private IEnumerator UpdateOrientationCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000375")]
	protected abstract void InitializeTeleportDestination();

	[Token(Token = "0x6000376")]
	protected abstract void UpdateTeleportDestination();

	[Token(Token = "0x6000377")]
	[Address(RVA = "0xB87C48", Offset = "0xB87C48", VA = "0xB87C48")]
	protected Quaternion GetLandingOrientation(OrientationModes mode, Quaternion rotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0xB87D04", Offset = "0xB87D04", VA = "0xB87D04")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707620", Offset = "0x707620")]
	private void <.ctor>b__3_0()
	{
	}
}
[Token(Token = "0x200007F")]
public class TeleportOrientationHandler360 : TeleportOrientationHandler
{
	[Token(Token = "0x600037F")]
	[Address(RVA = "0xB87D30", Offset = "0xB87D30", VA = "0xB87D30", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0xB87D34", Offset = "0xB87D34", VA = "0xB87D34", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0xB87DB0", Offset = "0xB87DB0", VA = "0xB87DB0")]
	public TeleportOrientationHandler360()
	{
	}
}
[Token(Token = "0x2000080")]
public class TeleportOrientationHandlerHMD : TeleportOrientationHandler
{
	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703F3C", Offset = "0x703F3C")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703F74", Offset = "0x703F74")]
	public bool UpdateOrientationDuringAim;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703FAC", Offset = "0x703FAC")]
	public float AimDistanceThreshold;

	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x703FE4", Offset = "0x703FE4")]
	public float AimDistanceMaxRange;

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion _initialRotation;

	[Token(Token = "0x6000382")]
	[Address(RVA = "0xB87DB4", Offset = "0xB87DB4", VA = "0xB87DB4", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0xB87DE0", Offset = "0xB87DE0", VA = "0xB87DE0", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0xB88190", Offset = "0xB88190", VA = "0xB88190")]
	public TeleportOrientationHandlerHMD()
	{
	}
}
[Token(Token = "0x2000081")]
public class TeleportOrientationHandlerThumbstick : TeleportOrientationHandler
{
	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x70401C", Offset = "0x70401C")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x704054", Offset = "0x704054")]
	public OVRInput.Controller Thumbstick;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x70408C", Offset = "0x70408C")]
	public float RotateStickThreshold;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion _initialRotation;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion _currentRotation;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector2 _lastValidDirection;

	[Token(Token = "0x6000385")]
	[Address(RVA = "0xB88194", Offset = "0xB88194", VA = "0xB88194", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0xB881D8", Offset = "0xB881D8", VA = "0xB881D8", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0xB88580", Offset = "0xB88580", VA = "0xB88580")]
	public TeleportOrientationHandlerThumbstick()
	{
	}
}
[Token(Token = "0x2000082")]
public class TeleportPoint : MonoBehaviour
{
	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float dimmingSpeed;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fullIntensity;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lowIntensity;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform destTransform;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float lastLookAtTime;

	[Token(Token = "0x6000388")]
	[Address(RVA = "0xB88590", Offset = "0xB88590", VA = "0xB88590")]
	private void Start()
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0xB88594", Offset = "0xB88594", VA = "0xB88594")]
	public Transform GetDestTransform()
	{
		return null;
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0xB8859C", Offset = "0xB8859C", VA = "0xB8859C")]
	private void Update()
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0xB88658", Offset = "0xB88658", VA = "0xB88658")]
	public void OnLookAt()
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0xB88680", Offset = "0xB88680", VA = "0xB88680")]
	public TeleportPoint()
	{
	}
}
[Token(Token = "0x2000083")]
public abstract class TeleportSupport : MonoBehaviour
{
	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7040C4", Offset = "0x7040C4")]
	private LocomotionTeleport <LocomotionTeleport>k__BackingField;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _eventsActive;

	[Token(Token = "0x17000056")]
	protected LocomotionTeleport LocomotionTeleport
	{
		[Token(Token = "0x600038D")]
		[Address(RVA = "0xB88698", Offset = "0xB88698", VA = "0xB88698")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707680", Offset = "0x707680")]
		get
		{
			return null;
		}
		[Token(Token = "0x600038E")]
		[Address(RVA = "0xB886A0", Offset = "0xB886A0", VA = "0xB886A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707690", Offset = "0x707690")]
		private set
		{
		}
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0xB8615C", Offset = "0xB8615C", VA = "0xB8615C", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0xB86284", Offset = "0xB86284", VA = "0xB86284", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0xB886A8", Offset = "0xB886A8", VA = "0xB886A8")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x7076A0", Offset = "0x7076A0")]
	private void LogEventHandler(string msg)
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0xB86824", Offset = "0xB86824", VA = "0xB86824", Slot = "6")]
	protected virtual void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0xB86890", Offset = "0xB86890", VA = "0xB86890", Slot = "7")]
	protected virtual void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0xB862C0", Offset = "0xB862C0", VA = "0xB862C0")]
	protected TeleportSupport()
	{
	}
}
[Token(Token = "0x2000084")]
public abstract class TeleportTargetHandler : TeleportSupport
{
	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702A98", Offset = "0x702A98")]
	private sealed class <TargetAimCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTargetHandler <>4__this;

		[Token(Token = "0x17000057")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x191D0D4", Offset = "0x191D0D4", VA = "0x191D0D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x191D11C", Offset = "0x191D11C", VA = "0x191D11C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x191CE04", Offset = "0x191CE04", VA = "0x191CE04")]
		[DebuggerHidden]
		public <TargetAimCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x191CE30", Offset = "0x191CE30", VA = "0x191CE30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x191CE34", Offset = "0x191CE34", VA = "0x191CE34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x191D0DC", Offset = "0x191D0DC", VA = "0x191D0DC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7040D4", Offset = "0x7040D4")]
	public LayerMask AimCollisionLayerMask;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly LocomotionTeleport.AimData AimData;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<Vector3> _aimPoints;

	[Token(Token = "0x4000417")]
	private const float ERROR_MARGIN = 0.1f;

	[Token(Token = "0x6000395")]
	[Address(RVA = "0xB88784", Offset = "0xB88784", VA = "0xB88784")]
	protected TeleportTargetHandler()
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0xB88894", Offset = "0xB88894", VA = "0xB88894", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0xB888C0", Offset = "0xB888C0", VA = "0xB888C0", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0xB888E8", Offset = "0xB888E8", VA = "0xB888E8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7076D8", Offset = "0x7076D8")]
	private IEnumerator TargetAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0xB88960", Offset = "0xB88960", VA = "0xB88960", Slot = "8")]
	protected virtual void ResetAimData()
	{
	}

	[Token(Token = "0x600039A")]
	protected abstract bool ConsiderTeleport(Vector3 start, ref Vector3 end);

	[Token(Token = "0x600039B")]
	[Address(RVA = "0xB8897C", Offset = "0xB8897C", VA = "0xB8897C", Slot = "10")]
	public virtual Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0xB88A9C", Offset = "0xB88A9C", VA = "0xB88A9C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707738", Offset = "0x707738")]
	private void <.ctor>b__3_0()
	{
	}
}
[Token(Token = "0x2000086")]
public class TeleportTargetHandlerNavMesh : TeleportTargetHandler
{
	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int NavMeshAreaMask;

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NavMeshPath _path;

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0xB88AC8", Offset = "0xB88AC8", VA = "0xB88AC8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0xB88B2C", Offset = "0xB88B2C", VA = "0xB88B2C", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0xB88C24", Offset = "0xB88C24", VA = "0xB88C24", Slot = "10")]
	public override Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0xB88D1C", Offset = "0xB88D1C", VA = "0xB88D1C")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x707798", Offset = "0x707798")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0xB88D20", Offset = "0xB88D20", VA = "0xB88D20")]
	public TeleportTargetHandlerNavMesh()
	{
	}
}
[Token(Token = "0x2000087")]
public class TeleportTargetHandlerNode : TeleportTargetHandler
{
	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x70410C", Offset = "0x70410C")]
	public float LOSOffset;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x704144", Offset = "0x704144")]
	public LayerMask TeleportLayerMask;

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0xB88D2C", Offset = "0xB88D2C", VA = "0xB88D2C", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0xB88F38", Offset = "0xB88F38", VA = "0xB88F38")]
	public TeleportTargetHandlerNode()
	{
	}
}
[Token(Token = "0x2000088")]
public class TeleportTargetHandlerPhysical : TeleportTargetHandler
{
	[Token(Token = "0x60003AA")]
	[Address(RVA = "0xB88F44", Offset = "0xB88F44", VA = "0xB88F44", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0xB8903C", Offset = "0xB8903C", VA = "0xB8903C")]
	public TeleportTargetHandlerPhysical()
	{
	}
}
[Token(Token = "0x2000089")]
public abstract class TeleportTransition : TeleportSupport
{
	[Token(Token = "0x60003AC")]
	[Address(RVA = "0xB89040", Offset = "0xB89040", VA = "0xB89040", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0xB890D4", Offset = "0xB890D4", VA = "0xB890D4", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60003AE")]
	protected abstract void LocomotionTeleportOnEnterStateTeleporting();

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0xB89164", Offset = "0xB89164", VA = "0xB89164")]
	protected TeleportTransition()
	{
	}
}
[Token(Token = "0x200008A")]
public class TeleportTransitionBlink : TeleportTransition
{
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702AA8", Offset = "0x702AA8")]
	private sealed class <BlinkCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionBlink <>4__this;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <teleportTime>5__3;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <teleported>5__4;

		[Token(Token = "0x17000059")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x191D25C", Offset = "0x191D25C", VA = "0x191D25C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x191D2A4", Offset = "0x191D2A4", VA = "0x191D2A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x191D124", Offset = "0x191D124", VA = "0x191D124")]
		[DebuggerHidden]
		public <BlinkCoroutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x191D150", Offset = "0x191D150", VA = "0x191D150", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x191D154", Offset = "0x191D154", VA = "0x191D154", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x191D264", Offset = "0x191D264", VA = "0x191D264", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x70417C", Offset = "0x70417C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x70417C", Offset = "0x70417C")]
	public float TransitionDuration;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7041D4", Offset = "0x7041D4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7041D4", Offset = "0x7041D4")]
	public float TeleportDelay;

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x704228", Offset = "0x704228")]
	public AnimationCurve FadeLevels;

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0xB8916C", Offset = "0xB8916C", VA = "0xB8916C", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0xB89198", Offset = "0xB89198", VA = "0xB89198")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7077D0", Offset = "0x7077D0")]
	protected IEnumerator BlinkCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0xB89210", Offset = "0xB89210", VA = "0xB89210")]
	public TeleportTransitionBlink()
	{
	}
}
[Token(Token = "0x200008C")]
public class TeleportTransitionInstant : TeleportTransition
{
	[Token(Token = "0x60003B9")]
	[Address(RVA = "0xB893BC", Offset = "0xB893BC", VA = "0xB893BC", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0xB893D8", Offset = "0xB893D8", VA = "0xB893D8")]
	public TeleportTransitionInstant()
	{
	}
}
[Token(Token = "0x200008D")]
public class TeleportTransitionWarp : TeleportTransition
{
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702AB8", Offset = "0x702AB8")]
	private sealed class <DoWarp>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionWarp <>4__this;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <startPosition>5__2;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x1700005B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x191D418", Offset = "0x191D418", VA = "0x191D418", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x191D460", Offset = "0x191D460", VA = "0x191D460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x191D2AC", Offset = "0x191D2AC", VA = "0x191D2AC")]
		[DebuggerHidden]
		public <DoWarp>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x191D2D8", Offset = "0x191D2D8", VA = "0x191D2D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x191D2DC", Offset = "0x191D2DC", VA = "0x191D2DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x191D420", Offset = "0x191D420", VA = "0x191D420", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x704260", Offset = "0x704260")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x704260", Offset = "0x704260")]
	public float TransitionDuration;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public AnimationCurve PositionLerp;

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0xB893E0", Offset = "0xB893E0", VA = "0xB893E0", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0xB8940C", Offset = "0xB8940C", VA = "0xB8940C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x707880", Offset = "0x707880")]
	private IEnumerator DoWarp()
	{
		return null;
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0xB89484", Offset = "0xB89484", VA = "0xB89484")]
	public TeleportTransitionWarp()
	{
	}
}
[Token(Token = "0x200008F")]
public static class NativeVideoPlayer
{
	[Token(Token = "0x2000090")]
	public enum PlabackState
	{
		[Token(Token = "0x4000447")]
		Idle = 1,
		[Token(Token = "0x4000448")]
		Preparing,
		[Token(Token = "0x4000449")]
		Buffering,
		[Token(Token = "0x400044A")]
		Ready,
		[Token(Token = "0x400044B")]
		Ended
	}

	[Token(Token = "0x2000091")]
	public enum StereoMode
	{
		[Token(Token = "0x400044D")]
		Unknown = -1,
		[Token(Token = "0x400044E")]
		Mono,
		[Token(Token = "0x400044F")]
		TopBottom,
		[Token(Token = "0x4000450")]
		LeftRight,
		[Token(Token = "0x4000451")]
		Mesh
	}

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IntPtr? _Activity;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static IntPtr? _VideoPlayerClass;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly jvalue[] EmptyParams;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static IntPtr getIsPlayingMethodId;

	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static IntPtr getCurrentPlaybackStateMethodId;

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static IntPtr getDurationMethodId;

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static IntPtr getStereoModeMethodId;

	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static IntPtr getWidthMethodId;

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static IntPtr getHeightMethodId;

	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static IntPtr getPlaybackPositionMethodId;

	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static IntPtr setPlaybackPositionMethodId;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static jvalue[] setPlaybackPositionParams;

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static IntPtr playVideoMethodId;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static jvalue[] playVideoParams;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static IntPtr stopMethodId;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static IntPtr resumeMethodId;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static IntPtr pauseMethodId;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static IntPtr setPlaybackSpeedMethodId;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static jvalue[] setPlaybackSpeedParams;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static IntPtr setLoopingMethodId;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static jvalue[] setLoopingParams;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static IntPtr setListenerRotationQuaternionMethodId;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private static jvalue[] setListenerRotationQuaternionParams;

	[Token(Token = "0x1700005D")]
	private static IntPtr VideoPlayerClass
	{
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xC1CA08", Offset = "0xC1CA08", VA = "0xC1CA08")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x1700005E")]
	private static IntPtr Activity
	{
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xC1CD38", Offset = "0xC1CD38", VA = "0xC1CD38")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x1700005F")]
	public static bool IsAvailable
	{
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xC19DA8", Offset = "0xC19DA8", VA = "0xC19DA8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000060")]
	public static bool IsPlaying
	{
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xC1B5A4", Offset = "0xC1B5A4", VA = "0xC1B5A4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000061")]
	public static PlabackState CurrentPlaybackState
	{
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xC1D008", Offset = "0xC1D008", VA = "0xC1D008")]
		get
		{
			return default(PlabackState);
		}
	}

	[Token(Token = "0x17000062")]
	public static long Duration
	{
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xC1B7C8", Offset = "0xC1B7C8", VA = "0xC1B7C8")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000063")]
	public static StereoMode VideoStereoMode
	{
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xC1A3D0", Offset = "0xC1A3D0", VA = "0xC1A3D0")]
		get
		{
			return default(StereoMode);
		}
	}

	[Token(Token = "0x17000064")]
	public static int VideoWidth
	{
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xC1A1A8", Offset = "0xC1A1A8", VA = "0xC1A1A8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000065")]
	public static int VideoHeight
	{
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xC1A2BC", Offset = "0xC1A2BC", VA = "0xC1A2BC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000066")]
	public static long PlaybackPosition
	{
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xC1B6B4", Offset = "0xC1B6B4", VA = "0xC1B6B4")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xC1AC88", Offset = "0xC1AC88", VA = "0xC1AC88")]
		set
		{
		}
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0xC1D11C", Offset = "0xC1D11C", VA = "0xC1D11C")]
	public static void PlayVideo(string path, string drmLicenseUrl, IntPtr surfaceObj)
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0xC1BB98", Offset = "0xC1BB98", VA = "0xC1BB98")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0xC1A8D4", Offset = "0xC1A8D4", VA = "0xC1A8D4")]
	public static void Play()
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0xC1AA74", Offset = "0xC1AA74", VA = "0xC1AA74")]
	public static void Pause()
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0xC1B990", Offset = "0xC1B990", VA = "0xC1B990")]
	public static void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0xC1D348", Offset = "0xC1D348", VA = "0xC1D348")]
	public static void SetLooping(bool looping)
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0xC1B3B4", Offset = "0xC1B3B4", VA = "0xC1B3B4")]
	public static void SetListenerRotation(Quaternion rotation)
	{
	}
}
[Token(Token = "0x2000092")]
public class ButtonDownListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Token(Token = "0x1400000F")]
	public event Action onButtonDown
	{
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xCDB414", Offset = "0xCDB414", VA = "0xCDB414")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707930", Offset = "0x707930")]
		add
		{
		}
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xCDB4B4", Offset = "0xCDB4B4", VA = "0xCDB4B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707940", Offset = "0x707940")]
		remove
		{
		}
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0xCDB554", Offset = "0xCDB554", VA = "0xCDB554", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0xCDB568", Offset = "0xCDB568", VA = "0xCDB568")]
	public ButtonDownListener()
	{
	}
}
[Token(Token = "0x2000093")]
public class MediaPlayerImage : Image
{
	[Token(Token = "0x2000094")]
	public enum ButtonType
	{
		[Token(Token = "0x4000455")]
		Play,
		[Token(Token = "0x4000456")]
		Pause,
		[Token(Token = "0x4000457")]
		FastForward,
		[Token(Token = "0x4000458")]
		Rewind,
		[Token(Token = "0x4000459")]
		SkipForward,
		[Token(Token = "0x400045A")]
		SkipBack,
		[Token(Token = "0x400045B")]
		Stop
	}

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private ButtonType m_ButtonType;

	[Token(Token = "0x17000067")]
	public ButtonType buttonType
	{
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xC166E4", Offset = "0xC166E4", VA = "0xC166E4")]
		get
		{
			return default(ButtonType);
		}
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xC166EC", Offset = "0xC166EC", VA = "0xC166EC")]
		set
		{
		}
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0xC16710", Offset = "0xC16710", VA = "0xC16710", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0xC17BA8", Offset = "0xC17BA8", VA = "0xC17BA8")]
	public MediaPlayerImage()
	{
	}
}
[Token(Token = "0x2000095")]
public class MoviePlayerSample : MonoBehaviour
{
	[Token(Token = "0x2000096")]
	public enum VideoShape
	{
		[Token(Token = "0x4000470")]
		_360,
		[Token(Token = "0x4000471")]
		_180,
		[Token(Token = "0x4000472")]
		Quad
	}

	[Token(Token = "0x2000097")]
	public enum VideoStereo
	{
		[Token(Token = "0x4000474")]
		Mono,
		[Token(Token = "0x4000475")]
		TopBottom,
		[Token(Token = "0x4000476")]
		LeftRight,
		[Token(Token = "0x4000477")]
		BottomTop
	}

	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702AC8", Offset = "0x702AC8")]
	private sealed class <Start>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x1700006B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x1956238", Offset = "0x1956238", VA = "0x1956238", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x1956280", Offset = "0x1956280", VA = "0x1956280", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1956044", Offset = "0x1956044", VA = "0x1956044")]
		[DebuggerHidden]
		public <Start>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1956070", Offset = "0x1956070", VA = "0x1956070", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1956074", Offset = "0x1956074", VA = "0x1956074", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1956240", Offset = "0x1956240", VA = "0x1956240", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702AD8", Offset = "0x702AD8")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string moviePath;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string drmLicencesUrl;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1955F4C", Offset = "0x1955F4C", VA = "0x1955F4C")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1955F54", Offset = "0x1955F54", VA = "0x1955F54")]
		internal void <Play>b__0()
		{
		}
	}

	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool videoPausedBeforeAppPause;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVROverlay overlay;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer mediaRenderer;

	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7042E8", Offset = "0x7042E8")]
	private bool <IsPlaying>k__BackingField;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7042F8", Offset = "0x7042F8")]
	private long <Duration>k__BackingField;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x704308", Offset = "0x704308")]
	private long <PlaybackPosition>k__BackingField;

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RenderTexture copyTexture;

	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material externalTex2DMaterial;

	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string MovieName;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string DrmLicenseUrl;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool LoopVideo;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public VideoShape Shape;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public VideoStereo Stereo;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool AutoDetectStereoLayout;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool DisplayMono;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private VideoShape _LastShape;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private VideoStereo _LastStereo;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _LastDisplayMono;

	[Token(Token = "0x17000068")]
	public bool IsPlaying
	{
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xC19ACC", Offset = "0xC19ACC", VA = "0xC19ACC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707950", Offset = "0x707950")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xC19AD4", Offset = "0xC19AD4", VA = "0xC19AD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707960", Offset = "0x707960")]
		private set
		{
		}
	}

	[Token(Token = "0x17000069")]
	public long Duration
	{
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xC19AE0", Offset = "0xC19AE0", VA = "0xC19AE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707970", Offset = "0x707970")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xC19AE8", Offset = "0xC19AE8", VA = "0xC19AE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707980", Offset = "0x707980")]
		private set
		{
		}
	}

	[Token(Token = "0x1700006A")]
	public long PlaybackPosition
	{
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xC19AF0", Offset = "0xC19AF0", VA = "0xC19AF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707990", Offset = "0x707990")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xC19AF8", Offset = "0xC19AF8", VA = "0xC19AF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7079A0", Offset = "0x7079A0")]
		private set
		{
		}
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0xC19B00", Offset = "0xC19B00", VA = "0xC19B00")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0xC19E18", Offset = "0xC19E18", VA = "0xC19E18")]
	private bool IsLocalVideo(string movieName)
	{
		return default(bool);
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0xC19E7C", Offset = "0xC19E7C", VA = "0xC19E7C")]
	private void UpdateShapeAndStereo()
	{
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0xC1A4E4", Offset = "0xC1A4E4", VA = "0xC1A4E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7079B0", Offset = "0x7079B0")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0xC1A55C", Offset = "0xC1A55C", VA = "0xC1A55C")]
	public void Play(string moviePath, string drmLicencesUrl)
	{
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0xC1A844", Offset = "0xC1A844", VA = "0xC1A844")]
	public void Play()
	{
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0xC1A9E8", Offset = "0xC1A9E8", VA = "0xC1A9E8")]
	public void Pause()
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0xC1AB88", Offset = "0xC1AB88", VA = "0xC1AB88")]
	public void SeekTo(long position)
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0xC1ADFC", Offset = "0xC1ADFC", VA = "0xC1ADFC")]
	private void Update()
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0xC1B8DC", Offset = "0xC1B8DC", VA = "0xC1B8DC")]
	public void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0xC1BB0C", Offset = "0xC1BB0C", VA = "0xC1BB0C")]
	public void Stop()
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0xC1BCAC", Offset = "0xC1BCAC", VA = "0xC1BCAC")]
	private void OnApplicationPause(bool appWasPaused)
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0xC1BD98", Offset = "0xC1BD98", VA = "0xC1BD98")]
	public MoviePlayerSample()
	{
	}
}
[Token(Token = "0x200009A")]
public class MoviePlayerSampleControls : MonoBehaviour
{
	[Token(Token = "0x200009B")]
	private enum PlaybackState
	{
		[Token(Token = "0x4000494")]
		Playing,
		[Token(Token = "0x4000495")]
		Paused,
		[Token(Token = "0x4000496")]
		Rewinding,
		[Token(Token = "0x4000497")]
		FastForwarding
	}

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MoviePlayerSample Player;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRInputModule InputModule;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRGazePointer GazePointer;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand;

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject RightHand;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Canvas Canvas;

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ButtonDownListener PlayPause;

	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MediaPlayerImage PlayPauseImage;

	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Slider ProgressBar;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ButtonDownListener FastForward;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public MediaPlayerImage FastForwardImage;

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ButtonDownListener Rewind;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MediaPlayerImage RewindImage;

	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float TimeoutTime;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool _isVisible;

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _lastButtonTime;

	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool _didSeek;

	[Token(Token = "0x400048F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private long _seekPreviousPosition;

	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private long _rewindStartPosition;

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float _rewindStartTime;

	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private PlaybackState _state;

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0xC1BDA8", Offset = "0xC1BDA8", VA = "0xC1BDA8")]
	private void Start()
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0xC1C0FC", Offset = "0xC1C0FC", VA = "0xC1C0FC")]
	private void OnPlayPauseClicked()
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0xC1C2D8", Offset = "0xC1C2D8", VA = "0xC1C2D8")]
	private void OnFastForwardClicked()
	{
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0xC1C40C", Offset = "0xC1C40C", VA = "0xC1C40C")]
	private void OnRewindClicked()
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0xC1C514", Offset = "0xC1C514", VA = "0xC1C514")]
	private void OnSeekBarMoved(float value)
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0xC1C3E0", Offset = "0xC1C3E0", VA = "0xC1C3E0")]
	private void Seek(long pos)
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0xC1C574", Offset = "0xC1C574", VA = "0xC1C574")]
	private void Update()
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0xC1BFE8", Offset = "0xC1BFE8", VA = "0xC1BFE8")]
	private void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0xC1C8D8", Offset = "0xC1C8D8", VA = "0xC1C8D8")]
	public MoviePlayerSampleControls()
	{
	}
}
[Token(Token = "0x200009C")]
public static class VectorUtil
{
	[Token(Token = "0x6000403")]
	[Address(RVA = "0x194E53C", Offset = "0x194E53C", VA = "0x194E53C")]
	public static Vector4 ToVector(this Rect rect)
	{
		return default(Vector4);
	}
}
[Token(Token = "0x200009D")]
public class AppDeeplinkUI : MonoBehaviour
{
	[Token(Token = "0x4000498")]
	private const ulong UNITY_COMPANION_APP_ID = 3535750239844224uL;

	[Token(Token = "0x4000499")]
	private const ulong UNREAL_COMPANION_APP_ID = 4055411724486843uL;

	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform deeplinkAppId;

	[Token(Token = "0x400049B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform deeplinkMessage;

	[Token(Token = "0x400049C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform uiLaunchType;

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform uiLaunchSource;

	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RectTransform uiDeepLinkMessage;

	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool inMenu;

	[Token(Token = "0x6000404")]
	[Address(RVA = "0xCD758C", Offset = "0xCD758C", VA = "0xCD758C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0xCD79A0", Offset = "0xCD79A0", VA = "0xCD79A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0xCD7C2C", Offset = "0xCD7C2C", VA = "0xCD7C2C")]
	private void LaunchUnrealDeeplinkSample()
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0xCD7D94", Offset = "0xCD7D94", VA = "0xCD7D94")]
	private void LaunchSelf()
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0xCD7F00", Offset = "0xCD7F00", VA = "0xCD7F00")]
	private void LaunchOtherApp()
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0xCD8090", Offset = "0xCD8090", VA = "0xCD8090")]
	public AppDeeplinkUI()
	{
	}
}
[Token(Token = "0x200009E")]
public class CustomDebugUI : MonoBehaviour
{
	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CustomDebugUI instance;

	[Token(Token = "0x40004A2")]
	private const BindingFlags privateFlags = BindingFlags.Instance | BindingFlags.NonPublic;

	[Token(Token = "0x600040A")]
	[Address(RVA = "0xAFEDF8", Offset = "0xAFEDF8", VA = "0xAFEDF8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0xAFEE4C", Offset = "0xAFEE4C", VA = "0xAFEE4C")]
	private void Start()
	{
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0xAFEE50", Offset = "0xAFEE50", VA = "0xAFEE50")]
	private void Update()
	{
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0xAFEE54", Offset = "0xAFEE54", VA = "0xAFEE54")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0xAFF0C8", Offset = "0xAFF0C8", VA = "0xAFF0C8")]
	public void RemoveFromCanvas(RectTransform element, int targetCanvas = 0)
	{
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0xAFF2F8", Offset = "0xAFF2F8", VA = "0xAFF2F8")]
	public CustomDebugUI()
	{
	}
}
[Token(Token = "0x200009F")]
public class DebugUISample : MonoBehaviour
{
	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool inMenu;

	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text sliderText;

	[Token(Token = "0x6000410")]
	[Address(RVA = "0xB01748", Offset = "0xB01748", VA = "0xB01748")]
	private void Start()
	{
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0xB01C64", Offset = "0xB01C64", VA = "0xB01C64")]
	public void TogglePressed(Toggle t)
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0xB01D24", Offset = "0xB01D24", VA = "0xB01D24")]
	public void RadioPressed(string radioLabel, string group, Toggle t)
	{
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0xB01FA4", Offset = "0xB01FA4", VA = "0xB01FA4")]
	public void SliderPressed(float f)
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0xB02084", Offset = "0xB02084", VA = "0xB02084")]
	private void Update()
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0xB02168", Offset = "0xB02168", VA = "0xB02168")]
	private void LogButtonPressed()
	{
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0xB021DC", Offset = "0xB021DC", VA = "0xB021DC")]
	public DebugUISample()
	{
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0xB021E4", Offset = "0xB021E4", VA = "0xB021E4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707A70", Offset = "0x707A70")]
	private void <Start>b__2_0(Toggle t)
	{
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0xB02248", Offset = "0xB02248", VA = "0xB02248")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707A80", Offset = "0x707A80")]
	private void <Start>b__2_1(Toggle t)
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0xB022AC", Offset = "0xB022AC", VA = "0xB022AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707A90", Offset = "0x707A90")]
	private void <Start>b__2_2(Toggle t)
	{
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0xB02310", Offset = "0xB02310", VA = "0xB02310")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x707AA0", Offset = "0x707AA0")]
	private void <Start>b__2_3(Toggle t)
	{
	}
}
[Token(Token = "0x20000A0")]
public class AnalyticsUI : MonoBehaviour
{
	[Token(Token = "0x600041B")]
	[Address(RVA = "0xCD51AC", Offset = "0xCD51AC", VA = "0xCD51AC")]
	public AnalyticsUI()
	{
	}
}
[Token(Token = "0x20000A1")]
public class SampleUI : MonoBehaviour
{
	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform collectionButton;

	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform inputText;

	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform valueText;

	[Token(Token = "0x40004A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool inMenu;

	[Token(Token = "0x600041C")]
	[Address(RVA = "0xB7CF1C", Offset = "0xB7CF1C", VA = "0xB7CF1C")]
	private void Start()
	{
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0xB7CFC0", Offset = "0xB7CFC0", VA = "0xB7CFC0")]
	private void Update()
	{
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0xB7D0AC", Offset = "0xB7D0AC", VA = "0xB7D0AC")]
	private string GetText()
	{
		return null;
	}

	[Token(Token = "0x600041F")]
	[Address(RVA = "0xB7D10C", Offset = "0xB7D10C", VA = "0xB7D10C")]
	public SampleUI()
	{
	}
}
[Token(Token = "0x20000A2")]
public class StartCrashlytics : MonoBehaviour
{
	[Token(Token = "0x6000420")]
	[Address(RVA = "0xB855C0", Offset = "0xB855C0", VA = "0xB855C0")]
	public StartCrashlytics()
	{
	}
}
[Token(Token = "0x20000A3")]
public class HandsActiveChecker : MonoBehaviour
{
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702AF8", Offset = "0x702AF8")]
	private sealed class <GetCenterEye>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandsActiveChecker <>4__this;

		[Token(Token = "0x1700006D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x1954934", Offset = "0x1954934", VA = "0x1954934", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600042A")]
			[Address(RVA = "0x195497C", Offset = "0x195497C", VA = "0x195497C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x19547B8", Offset = "0x19547B8", VA = "0x19547B8")]
		[DebuggerHidden]
		public <GetCenterEye>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x19547E4", Offset = "0x19547E4", VA = "0x19547E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x19547E8", Offset = "0x19547E8", VA = "0x19547E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x195493C", Offset = "0x195493C", VA = "0x195493C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _notificationPrefab;

	[Token(Token = "0x40004AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _notification;

	[Token(Token = "0x40004AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRCameraRig _cameraRig;

	[Token(Token = "0x40004AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _centerEye;

	[Token(Token = "0x6000421")]
	[Address(RVA = "0xC0E328", Offset = "0xC0E328", VA = "0xC0E328")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0xC0E444", Offset = "0xC0E444", VA = "0xC0E444")]
	private void Update()
	{
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0xC0E3CC", Offset = "0xC0E3CC", VA = "0xC0E3CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x707AB0", Offset = "0x707AB0")]
	private IEnumerator GetCenterEye()
	{
		return null;
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0xC0E5F0", Offset = "0xC0E5F0", VA = "0xC0E5F0")]
	public HandsActiveChecker()
	{
	}
}
[Token(Token = "0x20000A5")]
[ExecuteInEditMode]
public class CharacterCapsule : MonoBehaviour
{
	[Token(Token = "0x40004B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CharacterController _character;

	[Token(Token = "0x40004B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter _meshFilter;

	[Token(Token = "0x40004B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _height;

	[Token(Token = "0x40004B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _radius;

	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x704338", Offset = "0x704338")]
	public int SubdivisionsU;

	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x704354", Offset = "0x704354")]
	public int SubdivisionsV;

	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _subdivisionU;

	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int _subdivisionV;

	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3[] _vertices;

	[Token(Token = "0x40004B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int[] _triangles;

	[Token(Token = "0x600042B")]
	[Address(RVA = "0xCE5520", Offset = "0xCE5520", VA = "0xCE5520")]
	private void Update()
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0xCE5F68", Offset = "0xCE5F68", VA = "0xCE5F68")]
	public CharacterCapsule()
	{
	}
}
[Token(Token = "0x20000A6")]
public class LocomotionSampleSupport : MonoBehaviour
{
	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LocomotionController lc;

	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool inMenu;

	[Token(Token = "0x1700006F")]
	private LocomotionTeleport TeleportController
	{
		[Token(Token = "0x600042D")]
		[Address(RVA = "0xC13B5C", Offset = "0xC13B5C", VA = "0xC13B5C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0xC13BB0", Offset = "0xC13BB0", VA = "0xC13BB0")]
	public void Start()
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0xC13FD8", Offset = "0xC13FD8", VA = "0xC13FD8")]
	public void Update()
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0xC140C4", Offset = "0xC140C4", VA = "0xC140C4")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x707B60", Offset = "0x707B60")]
	private static void Log(string msg)
	{
	}

	[Token(Token = "0x6000431")]
	public static TActivate ActivateCategory<TCategory, TActivate>(GameObject target) where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000432")]
	protected void ActivateHandlers<TInput, TAim, TTarget, TOrientation, TTransition>() where TInput : TeleportInputHandler where TAim : TeleportAimHandler where TTarget : TeleportTargetHandler where TOrientation : TeleportOrientationHandler where TTransition : TeleportTransition
	{
	}

	[Token(Token = "0x6000433")]
	protected void ActivateInput<TActivate>() where TActivate : TeleportInputHandler
	{
	}

	[Token(Token = "0x6000434")]
	protected void ActivateAim<TActivate>() where TActivate : TeleportAimHandler
	{
	}

	[Token(Token = "0x6000435")]
	protected void ActivateTarget<TActivate>() where TActivate : TeleportTargetHandler
	{
	}

	[Token(Token = "0x6000436")]
	protected void ActivateOrientation<TActivate>() where TActivate : TeleportOrientationHandler
	{
	}

	[Token(Token = "0x6000437")]
	protected void ActivateTransition<TActivate>() where TActivate : TeleportTransition
	{
	}

	[Token(Token = "0x6000438")]
	protected TActivate ActivateCategory<TCategory, TActivate>() where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0xC14128", Offset = "0xC14128", VA = "0xC14128")]
	protected void UpdateToggle(Toggle toggle, bool enabled)
	{
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0xC14164", Offset = "0xC14164", VA = "0xC14164")]
	private void SetupNonCap()
	{
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0xC141D4", Offset = "0xC141D4", VA = "0xC141D4")]
	private void SetupTeleportDefaults()
	{
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0xC14344", Offset = "0xC14344", VA = "0xC14344")]
	protected GameObject AddInstance(GameObject template, string label)
	{
		return null;
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0xC14420", Offset = "0xC14420", VA = "0xC14420")]
	private void SetupNodeTeleport()
	{
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0xC13ED0", Offset = "0xC13ED0", VA = "0xC13ED0")]
	private void SetupTwoStickTeleport()
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0xC144E8", Offset = "0xC144E8", VA = "0xC144E8")]
	private void SetupWalkOnly()
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0xC14550", Offset = "0xC14550", VA = "0xC14550")]
	private void SetupLeftStrafeRightTeleport()
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0xC14648", Offset = "0xC14648", VA = "0xC14648")]
	public LocomotionSampleSupport()
	{
	}
}
[Token(Token = "0x20000A7")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x702B18", Offset = "0x702B18")]
public class OVROverlayCanvas : MonoBehaviour
{
	[Token(Token = "0x20000A8")]
	public enum DrawMode
	{
		[Token(Token = "0x40004D1")]
		Opaque,
		[Token(Token = "0x40004D2")]
		OpaqueWithClip,
		[Token(Token = "0x40004D3")]
		TransparentDefaultAlpha,
		[Token(Token = "0x40004D4")]
		TransparentCorrectAlpha
	}

	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	private Shader _transparentShader;

	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	private Shader _opaqueShader;

	[Token(Token = "0x40004BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform _rectTransform;

	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Canvas _canvas;

	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Camera _camera;

	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OVROverlay _overlay;

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTexture _renderTexture;

	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MeshRenderer _meshRenderer;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Mesh _quad;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material _defaultMat;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int MaxTextureSize;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int MinTextureSize;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float PixelsPerUnit;

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int DrawRate;

	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int DrawFrameOffset;

	[Token(Token = "0x40004CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool Expensive;

	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int Layer;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public DrawMode Opacity;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool ScaleViewport;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Plane[] _FrustumPlanes;

	[Token(Token = "0x17000070")]
	public bool overlayEnabled
	{
		[Token(Token = "0x6000448")]
		[Address(RVA = "0xC1EAB8", Offset = "0xC1EAB8", VA = "0xC1EAB8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000449")]
		[Address(RVA = "0xC1EB48", Offset = "0xC1EB48", VA = "0xC1EB48")]
		set
		{
		}
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0xC1D534", Offset = "0xC1D534", VA = "0xC1D534")]
	private void Start()
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0xC1E124", Offset = "0xC1E124", VA = "0xC1E124")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0xC1E1A4", Offset = "0xC1E1A4", VA = "0xC1E1A4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0xC1E294", Offset = "0xC1E294", VA = "0xC1E294")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0xC1E384", Offset = "0xC1E384", VA = "0xC1E384", Slot = "4")]
	protected virtual bool ShouldRender()
	{
		return default(bool);
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0xC1E590", Offset = "0xC1E590", VA = "0xC1E590")]
	private void Update()
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0xC1EC14", Offset = "0xC1EC14", VA = "0xC1EC14")]
	public OVROverlayCanvas()
	{
	}
}
[Token(Token = "0x20000A9")]
public class AugmentedObject : MonoBehaviour
{
	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform shadow;

	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool groundShadow;

	[Token(Token = "0x600044C")]
	[Address(RVA = "0xCD8198", Offset = "0xCD8198", VA = "0xCD8198")]
	private void Start()
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0xCD8380", Offset = "0xCD8380", VA = "0xCD8380")]
	private void Update()
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0xCD8508", Offset = "0xCD8508", VA = "0xCD8508")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0xCD8510", Offset = "0xCD8510", VA = "0xCD8510")]
	public void Release()
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0xCD84F8", Offset = "0xCD84F8", VA = "0xCD84F8")]
	private void ToggleShadowType()
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0xCD8518", Offset = "0xCD8518", VA = "0xCD8518")]
	public AugmentedObject()
	{
	}
}
[Token(Token = "0x20000AA")]
public class BrushController : MonoBehaviour
{
	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702B78", Offset = "0x702B78")]
	private sealed class <FadeCameraClearColor>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeTime;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color newColor;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <timer>5__2;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <currentColor>5__3;

		[Token(Token = "0x17000071")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x1951098", Offset = "0x1951098", VA = "0x1951098", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x19510E0", Offset = "0x19510E0", VA = "0x19510E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1950F68", Offset = "0x1950F68", VA = "0x1950F68")]
		[DebuggerHidden]
		public <FadeCameraClearColor>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1950F94", Offset = "0x1950F94", VA = "0x1950F94", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1950F98", Offset = "0x1950F98", VA = "0x1950F98", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x19510A0", Offset = "0x19510A0", VA = "0x19510A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702B88", Offset = "0x702B88")]
	private sealed class <FadeSphere>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BrushController <>4__this;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool disableOnFinish;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x17000073")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x19512A0", Offset = "0x19512A0", VA = "0x19512A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x19512E8", Offset = "0x19512E8", VA = "0x19512E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x19510E8", Offset = "0x19510E8", VA = "0x19510E8")]
		[DebuggerHidden]
		public <FadeSphere>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1951114", Offset = "0x1951114", VA = "0x1951114", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1951118", Offset = "0x1951118", VA = "0x1951118", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x19512A8", Offset = "0x19512A8", VA = "0x19512A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PassthroughBrush brush;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer backgroundSphere;

	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator grabRoutine;

	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator releaseRoutine;

	[Token(Token = "0x6000452")]
	[Address(RVA = "0xCD9BC0", Offset = "0xCD9BC0", VA = "0xCD9BC0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0xCD9E94", Offset = "0xCD9E94", VA = "0xCD9E94")]
	private void Update()
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0xCD9EF0", Offset = "0xCD9EF0", VA = "0xCD9EF0")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0xCDA070", Offset = "0xCDA070", VA = "0xCDA070")]
	public void Release()
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0xCDA144", Offset = "0xCDA144", VA = "0xCDA144")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x707B98", Offset = "0x707B98")]
	private IEnumerator FadeCameraClearColor(Color newColor, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0xCD9FAC", Offset = "0xCD9FAC", VA = "0xCD9FAC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x707BF8", Offset = "0x707BF8")]
	private IEnumerator FadeSphere(Color newColor, float fadeTime, bool disableOnFinish = false)
	{
		return null;
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0xCDA1E0", Offset = "0xCDA1E0", VA = "0xCDA1E0")]
	public BrushController()
	{
	}
}
[Token(Token = "0x20000AD")]
public class EnableUnpremultipliedAlpha : MonoBehaviour
{
	[Token(Token = "0x6000465")]
	[Address(RVA = "0xB04634", Offset = "0xB04634", VA = "0xB04634")]
	private void Start()
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0xB04694", Offset = "0xB04694", VA = "0xB04694")]
	public EnableUnpremultipliedAlpha()
	{
	}
}
[Token(Token = "0x20000AE")]
public class Flashlight : MonoBehaviour
{
	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject lightVolume;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Light spotlight;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject bulbGlow;

	[Token(Token = "0x6000467")]
	[Address(RVA = "0xB06514", Offset = "0xB06514", VA = "0xB06514")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0xB06648", Offset = "0xB06648", VA = "0xB06648")]
	public void ToggleFlashlight()
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0xB066DC", Offset = "0xB066DC", VA = "0xB066DC")]
	public void EnableFlashlight(bool doEnable)
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0xB06744", Offset = "0xB06744", VA = "0xB06744")]
	public Flashlight()
	{
	}
}
[Token(Token = "0x20000AF")]
public class FlashlightController : MonoBehaviour
{
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702B98", Offset = "0x702B98")]
	private sealed class <FadeLighting>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FlashlightController <>4__this;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sceneLightIntensity;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float <currentLight>5__4;

		[Token(Token = "0x17000075")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000477")]
			[Address(RVA = "0x1953D4C", Offset = "0x1953D4C", VA = "0x1953D4C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x1953D94", Offset = "0x1953D94", VA = "0x1953D94", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x1953B40", Offset = "0x1953B40", VA = "0x1953B40")]
		[DebuggerHidden]
		public <FadeLighting>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1953B6C", Offset = "0x1953B6C", VA = "0x1953B6C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x1953B70", Offset = "0x1953B70", VA = "0x1953B70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1953D54", Offset = "0x1953D54", VA = "0x1953D54", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Light sceneLight;

	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform flashlightRoot;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 localPosition;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Quaternion localRotation;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMesh infoText;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GrabObject externalController;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private OVRSkeleton[] skeletons;

	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private OVRHand[] hands;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int handIndex;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool pinching;

	[Token(Token = "0x600046B")]
	[Address(RVA = "0xB0674C", Offset = "0xB0674C", VA = "0xB0674C")]
	private void Start()
	{
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0xB06A30", Offset = "0xB06A30", VA = "0xB06A30")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0xB06D80", Offset = "0xB06D80", VA = "0xB06D80")]
	private void FindHands()
	{
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0xB070DC", Offset = "0xB070DC", VA = "0xB070DC")]
	private void AlignWithHand(OVRHand hand, OVRSkeleton skeleton)
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0xB073E0", Offset = "0xB073E0", VA = "0xB073E0")]
	private void AlignWithController(OVRInput.Controller controller)
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0xB074D4", Offset = "0xB074D4", VA = "0xB074D4")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0xB076A0", Offset = "0xB076A0", VA = "0xB076A0")]
	public void Release()
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0xB075EC", Offset = "0xB075EC", VA = "0xB075EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x707CF8", Offset = "0x707CF8")]
	private IEnumerator FadeLighting(Color newColor, float sceneLightIntensity, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0xB07788", Offset = "0xB07788", VA = "0xB07788")]
	public FlashlightController()
	{
	}
}
[Token(Token = "0x20000B1")]
public class GrabObject : MonoBehaviour
{
	[Token(Token = "0x20000B2")]
	public enum ManipulationType
	{
		[Token(Token = "0x4000509")]
		Default,
		[Token(Token = "0x400050A")]
		ForcedHand,
		[Token(Token = "0x400050B")]
		DollyHand,
		[Token(Token = "0x400050C")]
		DollyAttached,
		[Token(Token = "0x400050D")]
		HorizontalScaled,
		[Token(Token = "0x400050E")]
		VerticalScaled,
		[Token(Token = "0x400050F")]
		Menu
	}

	[Token(Token = "0x20000B3")]
	public delegate void GrabbedObject(OVRInput.Controller grabHand);

	[Token(Token = "0x20000B4")]
	public delegate void ReleasedObject();

	[Token(Token = "0x20000B5")]
	public delegate void SetCursorPosition(Vector3 cursorPosition);

	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x7043E0", Offset = "0x7043E0")]
	public string ObjectName;

	[Token(Token = "0x4000501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x7043F0", Offset = "0x7043F0")]
	public string ObjectInstructions;

	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ManipulationType objectManipulationType;

	[Token(Token = "0x4000503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool showLaserWhileGrabbed;

	[Token(Token = "0x4000504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Quaternion grabbedRotation;

	[Token(Token = "0x4000505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GrabbedObject GrabbedObjectDelegate;

	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ReleasedObject ReleasedObjectDelegate;

	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SetCursorPosition CursorPositionDelegate;

	[Token(Token = "0x600047A")]
	[Address(RVA = "0xB08600", Offset = "0xB08600", VA = "0xB08600")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0xB0865C", Offset = "0xB0865C", VA = "0xB0865C")]
	public void Release()
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0xB08670", Offset = "0xB08670", VA = "0xB08670")]
	public void CursorPos(Vector3 cursorPos)
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0xB08684", Offset = "0xB08684", VA = "0xB08684")]
	public GrabObject()
	{
	}
}
[Token(Token = "0x20000B6")]
public class HandMeshMask : MonoBehaviour
{
	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSkeleton referenceHand;

	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material maskMaterial;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x704410", Offset = "0x704410")]
	public int radialDivisions;

	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x704448", Offset = "0x704448")]
	public float borderSize;

	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x704480", Offset = "0x704480")]
	public float fingerTaper;

	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7044B8", Offset = "0x7044B8")]
	public float fingerTipLength;

	[Token(Token = "0x4000516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7044F0", Offset = "0x7044F0")]
	public float webOffset;

	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float handScale;

	[Token(Token = "0x4000518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject maskMeshObject;

	[Token(Token = "0x4000519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Mesh maskMesh;

	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] handVertices;

	[Token(Token = "0x400051B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector2[] handUVs;

	[Token(Token = "0x400051C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color32[] handColors;

	[Token(Token = "0x400051D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int[] handTriangles;

	[Token(Token = "0x400051E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int vertCounter;

	[Token(Token = "0x400051F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int triCounter;

	[Token(Token = "0x600048A")]
	[Address(RVA = "0xB09568", Offset = "0xB09568", VA = "0xB09568")]
	private void Awake()
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0xB09768", Offset = "0xB09768", VA = "0xB09768")]
	private void Update()
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0xB09974", Offset = "0xB09974", VA = "0xB09974")]
	private void CreateHandMesh()
	{
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0xB09FF8", Offset = "0xB09FF8", VA = "0xB09FF8")]
	private void AddKnuckleMesh(int knuckleVerts, float point1scale, float point2scale, Vector3 point1, Vector3 point2)
	{
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0xB0A628", Offset = "0xB0A628", VA = "0xB0A628")]
	private void AddPalmMesh(int knuckleVerts)
	{
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0xB0CCA4", Offset = "0xB0CCA4", VA = "0xB0CCA4")]
	private void AddVertex(Vector3 position, Vector2 uv, Color color)
	{
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0xB0CD60", Offset = "0xB0CD60", VA = "0xB0CD60")]
	public HandMeshMask()
	{
	}
}
[Token(Token = "0x20000B7")]
public class HandMeshUI : MonoBehaviour
{
	[Token(Token = "0x4000520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SphereCollider[] knobs;

	[Token(Token = "0x4000521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh[] readouts;

	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int rightHeldKnob;

	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int leftHeldKnob;

	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public OVRSkeleton leftHand;

	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public OVRSkeleton rightHand;

	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public HandMeshMask leftMask;

	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public HandMeshMask rightMask;

	[Token(Token = "0x6000491")]
	[Address(RVA = "0xC0C0CC", Offset = "0xC0C0CC", VA = "0xC0C0CC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000492")]
	[Address(RVA = "0xC0C404", Offset = "0xC0C404", VA = "0xC0C404")]
	private void Update()
	{
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0xC0C174", Offset = "0xC0C174", VA = "0xC0C174")]
	private void SetSliderValue(int sliderID, float value, bool isNormalized)
	{
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0xC0C7F4", Offset = "0xC0C7F4", VA = "0xC0C7F4")]
	private void CheckForHands()
	{
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0xC0CCE4", Offset = "0xC0CCE4", VA = "0xC0CCE4")]
	public HandMeshUI()
	{
	}
}
[Token(Token = "0x20000B8")]
public class ObjectManipulator : MonoBehaviour
{
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702BA8", Offset = "0x702BA8")]
	private sealed class <StartDemo>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ObjectManipulator <>4__this;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <fadeTime>5__3;

		[Token(Token = "0x17000077")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x195695C", Offset = "0x195695C", VA = "0x195695C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x19569A4", Offset = "0x19569A4", VA = "0x19569A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x195668C", Offset = "0x195668C", VA = "0x195668C")]
		[DebuggerHidden]
		public <StartDemo>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x19566B8", Offset = "0x19566B8", VA = "0x19566B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x19566BC", Offset = "0x19566BC", VA = "0x19566BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1956964", Offset = "0x1956964", VA = "0x1956964", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRInput.Controller controller;

	[Token(Token = "0x4000529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject hoverObject;

	[Token(Token = "0x400052A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject grabObject;

	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float grabTime;

	[Token(Token = "0x400052C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 localGrabOffset;

	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Quaternion localGrabRotation;

	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 camGrabPosition;

	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion camGrabRotation;

	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 handGrabPosition;

	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Quaternion handGrabRotation;

	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 cursorPosition;

	[Token(Token = "0x4000533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float rotationOffset;

	[Token(Token = "0x4000534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public LineRenderer laser;

	[Token(Token = "0x4000535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform objectInfo;

	[Token(Token = "0x4000536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMesh objectNameLabel;

	[Token(Token = "0x4000537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMesh objectInstructionsLabel;

	[Token(Token = "0x4000538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Image objectInfoBG;

	[Token(Token = "0x4000539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject demoObjects;

	[Token(Token = "0x400053A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public OVRPassthroughLayer passthrough;

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x1309A90", Offset = "0x1309A90", VA = "0x1309A90")]
	private void Start()
	{
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x1309CC8", Offset = "0x1309CC8", VA = "0x1309CC8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x130A918", Offset = "0x130A918", VA = "0x130A918")]
	private void GrabHoverObject(GameObject grbObj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x130B520", Offset = "0x130B520", VA = "0x130B520")]
	private void ReleaseObject()
	{
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x1309C50", Offset = "0x1309C50", VA = "0x1309C50")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x707DA8", Offset = "0x707DA8")]
	private IEnumerator StartDemo()
	{
		return null;
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0x1309F34", Offset = "0x1309F34", VA = "0x1309F34")]
	private void FindHoverObject(Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x130ABDC", Offset = "0x130ABDC", VA = "0x130ABDC")]
	private void ManipulateObject(GameObject obj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x130B7E4", Offset = "0x130B7E4", VA = "0x130B7E4")]
	private void ClampGrabOffset(ref Vector3 localOffset, float thumbY)
	{
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x130B870", Offset = "0x130B870", VA = "0x130B870")]
	private Vector3 ClampScale(Vector3 localScale, Vector2 thumb)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x130B8A0", Offset = "0x130B8A0", VA = "0x130B8A0")]
	private void CheckForDominantHand()
	{
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x130B6AC", Offset = "0x130B6AC", VA = "0x130B6AC")]
	private void AssignInstructions(GrabObject targetObject)
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x130B9C4", Offset = "0x130B9C4", VA = "0x130B9C4")]
	public ObjectManipulator()
	{
	}
}
[Token(Token = "0x20000BA")]
public class OverlayPassthrough : MonoBehaviour
{
	[Token(Token = "0x4000540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x130BAF0", Offset = "0x130BAF0", VA = "0x130BAF0")]
	private void Start()
	{
	}

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x130BC88", Offset = "0x130BC88", VA = "0x130BC88")]
	private void Update()
	{
	}

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x130BD50", Offset = "0x130BD50", VA = "0x130BD50")]
	public OverlayPassthrough()
	{
	}
}
[Token(Token = "0x20000BB")]
public class PassthroughBrush : MonoBehaviour
{
	[Token(Token = "0x20000BC")]
	public enum BrushState
	{
		[Token(Token = "0x400054C")]
		Idle,
		[Token(Token = "0x400054D")]
		Inking
	}

	[Token(Token = "0x4000541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject lineSegmentPrefab;

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject lineContainer;

	[Token(Token = "0x4000544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool forceActive;

	[Token(Token = "0x4000545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LineRenderer currentLineSegment;

	[Token(Token = "0x4000546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Vector3> inkPositions;

	[Token(Token = "0x4000547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float minInkDist;

	[Token(Token = "0x4000548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float strokeWidth;

	[Token(Token = "0x4000549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float strokeLength;

	[Token(Token = "0x400054A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private BrushState brushStatus;

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x130C6D4", Offset = "0x130C6D4", VA = "0x130C6D4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x130C6DC", Offset = "0x130C6DC", VA = "0x130C6DC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x130C9C4", Offset = "0x130C9C4", VA = "0x130C9C4")]
	private void StartLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x130CBBC", Offset = "0x130CBBC", VA = "0x130CBBC")]
	private void UpdateLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x130CD64", Offset = "0x130CD64", VA = "0x130CD64")]
	public void ClearLines()
	{
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x130C8D0", Offset = "0x130C8D0", VA = "0x130C8D0")]
	public void UndoInkLine()
	{
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x130CE40", Offset = "0x130CE40", VA = "0x130CE40")]
	public PassthroughBrush()
	{
	}
}
[Token(Token = "0x20000BD")]
public class PassthroughController : MonoBehaviour
{
	[Token(Token = "0x400054E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x130CED8", Offset = "0x130CED8", VA = "0x130CED8")]
	private void Start()
	{
	}

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x130D070", Offset = "0x130D070", VA = "0x130D070")]
	private void Update()
	{
	}

	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x130D1D8", Offset = "0x130D1D8", VA = "0x130D1D8")]
	public PassthroughController()
	{
	}
}
[Token(Token = "0x20000BE")]
public class PassthroughProjectionSurface : MonoBehaviour
{
	[Token(Token = "0x400054F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x4000551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer quadOutline;

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x130D1EC", Offset = "0x130D1EC", VA = "0x130D1EC")]
	private void Start()
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x130D400", Offset = "0x130D400", VA = "0x130D400")]
	private void Update()
	{
	}

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x130D5D0", Offset = "0x130D5D0", VA = "0x130D5D0")]
	public PassthroughProjectionSurface()
	{
	}
}
[Token(Token = "0x20000BF")]
public class PassthroughStyler : MonoBehaviour
{
	[Token(Token = "0x20000C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702BB8", Offset = "0x702BB8")]
	private sealed class <FadeToCurrentStyle>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <edgeCol>5__5;

		[Token(Token = "0x17000079")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x1956D9C", Offset = "0x1956D9C", VA = "0x1956D9C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x1956DE4", Offset = "0x1956DE4", VA = "0x1956DE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1956BE8", Offset = "0x1956BE8", VA = "0x1956BE8")]
		[DebuggerHidden]
		public <FadeToCurrentStyle>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1956C14", Offset = "0x1956C14", VA = "0x1956C14", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1956C18", Offset = "0x1956C18", VA = "0x1956C18", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1956DA4", Offset = "0x1956DA4", VA = "0x1956DA4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702BC8", Offset = "0x702BC8")]
	private sealed class <FadeToDefaultPassthrough>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <edgeCol>5__5;

		[Token(Token = "0x1700007B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x1956FE0", Offset = "0x1956FE0", VA = "0x1956FE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x1957028", Offset = "0x1957028", VA = "0x1957028", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1956DEC", Offset = "0x1956DEC", VA = "0x1956DEC")]
		[DebuggerHidden]
		public <FadeToDefaultPassthrough>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1956E18", Offset = "0x1956E18", VA = "0x1956E18", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1956E1C", Offset = "0x1956E1C", VA = "0x1956E1C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1956FE8", Offset = "0x1956FE8", VA = "0x1956FE8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator fadeIn;

	[Token(Token = "0x4000555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator fadeOut;

	[Token(Token = "0x4000556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RectTransform[] menuOptions;

	[Token(Token = "0x4000557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RectTransform colorWheel;

	[Token(Token = "0x4000558")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D colorTexture;

	[Token(Token = "0x4000559")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 cursorPosition;

	[Token(Token = "0x400055A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool settingColor;

	[Token(Token = "0x400055B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color savedColor;

	[Token(Token = "0x400055C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float savedBrightness;

	[Token(Token = "0x400055D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float savedContrast;

	[Token(Token = "0x400055E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public CanvasGroup mainCanvas;

	[Token(Token = "0x400055F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject[] compactObjects;

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x130D5D8", Offset = "0x130D5D8", VA = "0x130D5D8")]
	private void Start()
	{
	}

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x130D924", Offset = "0x130D924", VA = "0x130D924")]
	private void Update()
	{
	}

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0x130DB7C", Offset = "0x130DB7C", VA = "0x130DB7C")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x130DD00", Offset = "0x130DD00", VA = "0x130DD00")]
	public void Release()
	{
	}

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x130DC78", Offset = "0x130DC78", VA = "0x130DC78")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x707E58", Offset = "0x707E58")]
	private IEnumerator FadeToCurrentStyle(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x130DDF0", Offset = "0x130DDF0", VA = "0x130DDF0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x707EB8", Offset = "0x707EB8")]
	private IEnumerator FadeToDefaultPassthrough(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x130DE78", Offset = "0x130DE78", VA = "0x130DE78")]
	public void OnBrightnessChanged(float newValue)
	{
	}

	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x130DE98", Offset = "0x130DE98", VA = "0x130DE98")]
	public void OnContrastChanged(float newValue)
	{
	}

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x130DEB8", Offset = "0x130DEB8", VA = "0x130DEB8")]
	public void OnAlphaChanged(float newValue)
	{
	}

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x130D8A8", Offset = "0x130D8A8", VA = "0x130D8A8")]
	private void ShowFullMenu(bool doShow)
	{
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x130DF1C", Offset = "0x130DF1C", VA = "0x130DF1C")]
	public void Cursor(Vector3 cP)
	{
	}

	[Token(Token = "0x60004C3")]
	[Address(RVA = "0x130DF28", Offset = "0x130DF28", VA = "0x130DF28")]
	public void DoColorDrag(bool doDrag)
	{
	}

	[Token(Token = "0x60004C4")]
	[Address(RVA = "0x130D93C", Offset = "0x130D93C", VA = "0x130D93C")]
	public void GetColorFromWheel()
	{
	}

	[Token(Token = "0x60004C5")]
	[Address(RVA = "0x130DF34", Offset = "0x130DF34", VA = "0x130DF34")]
	public PassthroughStyler()
	{
	}
}
[Token(Token = "0x20000C2")]
public class PassthroughSurface : MonoBehaviour
{
	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x130DF78", Offset = "0x130DF78", VA = "0x130DF78")]
	private void Start()
	{
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x130E038", Offset = "0x130E038", VA = "0x130E038")]
	public PassthroughSurface()
	{
	}
}
[Token(Token = "0x20000C3")]
public class SPPquad : MonoBehaviour
{
	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x4000574")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRInput.Controller controllerHand;

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0xB7CC2C", Offset = "0xB7CC2C", VA = "0xB7CC2C")]
	private void Start()
	{
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0xB7CE70", Offset = "0xB7CE70", VA = "0xB7CE70")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0xB7CEC8", Offset = "0xB7CEC8", VA = "0xB7CEC8")]
	public void Release()
	{
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0xB7CF14", Offset = "0xB7CF14", VA = "0xB7CF14")]
	public SPPquad()
	{
	}
}
[Token(Token = "0x20000C4")]
public class SceneSampler : MonoBehaviour
{
	[Token(Token = "0x4000575")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int currentSceneIndex;

	[Token(Token = "0x4000576")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject displayText;

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0xB7D380", Offset = "0xB7D380", VA = "0xB7D380")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0xB7D3F8", Offset = "0xB7D3F8", VA = "0xB7D3F8")]
	private void Update()
	{
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0xB7D71C", Offset = "0xB7D71C", VA = "0xB7D71C")]
	public SceneSampler()
	{
	}
}
[Token(Token = "0x20000C5")]
public class SelectivePassthroughExperience : MonoBehaviour
{
	[Token(Token = "0x4000577")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject leftMaskObject;

	[Token(Token = "0x4000578")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject rightMaskObject;

	[Token(Token = "0x60004DB")]
	[Address(RVA = "0xB7DD78", Offset = "0xB7DD78", VA = "0xB7DD78")]
	private void Update()
	{
	}

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0xB7E200", Offset = "0xB7E200", VA = "0xB7E200")]
	public SelectivePassthroughExperience()
	{
	}
}
[Token(Token = "0x20000C6")]
public class BouncingBallLogic : MonoBehaviour
{
	[Token(Token = "0x20000C7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702BD8", Offset = "0x702BD8")]
	private sealed class <PlayPopCallback>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float clipLength;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BouncingBallLogic <>4__this;

		[Token(Token = "0x1700007D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x1950F18", Offset = "0x1950F18", VA = "0x1950F18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x1950F60", Offset = "0x1950F60", VA = "0x1950F60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1950DEC", Offset = "0x1950DEC", VA = "0x1950DEC")]
		[DebuggerHidden]
		public <PlayPopCallback>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1950E18", Offset = "0x1950E18", VA = "0x1950E18", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1950E1C", Offset = "0x1950E1C", VA = "0x1950E1C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1950F20", Offset = "0x1950F20", VA = "0x1950F20", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000579")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float TTL;

	[Token(Token = "0x400057A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip pop;

	[Token(Token = "0x400057B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioClip bounce;

	[Token(Token = "0x400057C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioClip loadball;

	[Token(Token = "0x400057D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Material visibleMat;

	[Token(Token = "0x400057E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Material hiddenMat;

	[Token(Token = "0x400057F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AudioSource audioSource;

	[Token(Token = "0x4000580")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform centerEyeCamera;

	[Token(Token = "0x4000581")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool isVisible;

	[Token(Token = "0x4000582")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float timer;

	[Token(Token = "0x4000583")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isReleased;

	[Token(Token = "0x4000584")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool isReadyForDestroy;

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0xCD9288", Offset = "0xCD9288", VA = "0xCD9288")]
	private void OnCollisionEnter()
	{
	}

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0xCD92AC", Offset = "0xCD92AC", VA = "0xCD92AC")]
	private void Start()
	{
	}

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0xCD93CC", Offset = "0xCD93CC", VA = "0xCD93CC")]
	private void Update()
	{
	}

	[Token(Token = "0x60004E0")]
	[Address(RVA = "0xCD9480", Offset = "0xCD9480", VA = "0xCD9480")]
	private void UpdateVisibility()
	{
	}

	[Token(Token = "0x60004E1")]
	[Address(RVA = "0xCD96AC", Offset = "0xCD96AC", VA = "0xCD96AC")]
	private void SetVisible(bool setVisible)
	{
	}

	[Token(Token = "0x60004E2")]
	[Address(RVA = "0xCD9764", Offset = "0xCD9764", VA = "0xCD9764")]
	public void Release(Vector3 pos, Vector3 vel, Vector3 angVel)
	{
	}

	[Token(Token = "0x60004E3")]
	[Address(RVA = "0xCD9624", Offset = "0xCD9624", VA = "0xCD9624")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x707FB8", Offset = "0x707FB8")]
	private IEnumerator PlayPopCallback(float clipLength)
	{
		return null;
	}

	[Token(Token = "0x60004E4")]
	[Address(RVA = "0xCD9884", Offset = "0xCD9884", VA = "0xCD9884")]
	public BouncingBallLogic()
	{
	}
}
[Token(Token = "0x20000C8")]
public class BouncingBallMgr : MonoBehaviour
{
	[Token(Token = "0x4000589")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform trackingspace;

	[Token(Token = "0x400058A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject rightControllerPivot;

	[Token(Token = "0x400058B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private OVRInput.RawButton actionBtn;

	[Token(Token = "0x400058C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject ball;

	[Token(Token = "0x400058D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject currentBall;

	[Token(Token = "0x400058E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool ballGrabbed;

	[Token(Token = "0x60004EB")]
	[Address(RVA = "0xCD989C", Offset = "0xCD989C", VA = "0xCD989C")]
	private void Update()
	{
	}

	[Token(Token = "0x60004EC")]
	[Address(RVA = "0xCD9BB8", Offset = "0xCD9BB8", VA = "0xCD9BB8")]
	public BouncingBallMgr()
	{
	}
}
[Token(Token = "0x20000C9")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x702BE8", Offset = "0x702BE8")]
[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0x702BE8", Offset = "0x702BE8")]
public class FurnitureSpawner : MonoBehaviour
{
	[Token(Token = "0x400058F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7045C8", Offset = "0x7045C8")]
	public GameObject RoomLightPrefab;

	[Token(Token = "0x4000590")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Spawnable> SpawnablePrefabs;

	[Token(Token = "0x4000591")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRSceneAnchor _sceneAnchor;

	[Token(Token = "0x4000592")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private OVRSemanticClassification _classification;

	[Token(Token = "0x4000593")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameObject _roomLightRef;

	[Token(Token = "0x4000594")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _frameCounter;

	[Token(Token = "0x60004ED")]
	[Address(RVA = "0xB07AFC", Offset = "0xB07AFC", VA = "0xB07AFC")]
	private void Start()
	{
	}

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0xB07D30", Offset = "0xB07D30", VA = "0xB07D30")]
	private void SpawnSpawnable()
	{
	}

	[Token(Token = "0x60004EF")]
	[Address(RVA = "0xB08190", Offset = "0xB08190", VA = "0xB08190")]
	private bool FindValidSpawnable(out Spawnable currentSpawnable)
	{
		return default(bool);
	}

	[Token(Token = "0x60004F0")]
	[Address(RVA = "0xB07B98", Offset = "0xB07B98", VA = "0xB07B98")]
	private void AddRoomLight()
	{
	}

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0xB08390", Offset = "0xB08390", VA = "0xB08390")]
	private void GetVolumeFromTopPlane(Transform plane, Vector2 dimensions, float height, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0xB08484", Offset = "0xB08484", VA = "0xB08484")]
	public FurnitureSpawner()
	{
	}
}
[Token(Token = "0x20000CA")]
public class MyCustomSceneModelLoader : OVRSceneModelLoader
{
	[Token(Token = "0x20000CB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702C5C", Offset = "0x702C5C")]
	private sealed class <DelayedLoad>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MyCustomSceneModelLoader <>4__this;

		[Token(Token = "0x1700007F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x19563BC", Offset = "0x19563BC", VA = "0x19563BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x1956404", Offset = "0x1956404", VA = "0x1956404", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1956288", Offset = "0x1956288", VA = "0x1956288")]
		[DebuggerHidden]
		public <DelayedLoad>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x19562B4", Offset = "0x19562B4", VA = "0x19562B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x19562B8", Offset = "0x19562B8", VA = "0x19562B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x19563C4", Offset = "0x19563C4", VA = "0x19563C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0xC1C8E8", Offset = "0xC1C8E8", VA = "0xC1C8E8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x708068", Offset = "0x708068")]
	private IEnumerator DelayedLoad()
	{
		return null;
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0xC1C960", Offset = "0xC1C960", VA = "0xC1C960", Slot = "4")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0xC1C98C", Offset = "0xC1C98C", VA = "0xC1C98C", Slot = "6")]
	protected override void OnNoSceneModelToLoad()
	{
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0xC1CA00", Offset = "0xC1CA00", VA = "0xC1CA00")]
	public MyCustomSceneModelLoader()
	{
	}
}
[Token(Token = "0x20000CC")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x702C6C", Offset = "0x702C6C")]
public class PassthroughPlayInEditor : MonoBehaviour
{
	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x130D1E0", Offset = "0x130D1E0", VA = "0x130D1E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x130D1E4", Offset = "0x130D1E4", VA = "0x130D1E4")]
	public PassthroughPlayInEditor()
	{
	}
}
[Token(Token = "0x20000CD")]
public class RequestCaptureFlow : MonoBehaviour
{
	[Token(Token = "0x4000598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Button RequestCaptureBtn;

	[Token(Token = "0x4000599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRSceneManager _sceneManager;

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0xB7C9CC", Offset = "0xB7C9CC", VA = "0xB7C9CC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000500")]
	[Address(RVA = "0xB7CA50", Offset = "0xB7CA50", VA = "0xB7CA50")]
	private void Update()
	{
	}

	[Token(Token = "0x6000501")]
	[Address(RVA = "0xB7CAE0", Offset = "0xB7CAE0", VA = "0xB7CAE0")]
	public RequestCaptureFlow()
	{
	}
}
[Token(Token = "0x20000CE")]
[ExecuteInEditMode]
public class SimpleResizable : MonoBehaviour
{
	[Token(Token = "0x20000CF")]
	public enum Method
	{
		[Token(Token = "0x40005A9")]
		Adapt,
		[Token(Token = "0x40005AA")]
		AdaptWithAsymmetricalPadding,
		[Token(Token = "0x40005AB")]
		Scale,
		[Token(Token = "0x40005AC")]
		None
	}

	[Token(Token = "0x400059A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x704600", Offset = "0x704600")]
	public Method ScalingX;

	[Token(Token = "0x400059B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x704614", Offset = "0x704614")]
	public float PaddingX;

	[Token(Token = "0x400059C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x70462C", Offset = "0x70462C")]
	public float PaddingXMax;

	[Token(Token = "0x400059D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x704644", Offset = "0x704644")]
	public Method ScalingY;

	[Token(Token = "0x400059E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x704658", Offset = "0x704658")]
	public float PaddingY;

	[Token(Token = "0x400059F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x704670", Offset = "0x704670")]
	public float PaddingYMax;

	[Token(Token = "0x40005A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x704688", Offset = "0x704688")]
	public Method ScalingZ;

	[Token(Token = "0x40005A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x70469C", Offset = "0x70469C")]
	public float PaddingZ;

	[Token(Token = "0x40005A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7046B4", Offset = "0x7046B4")]
	public float PaddingZMax;

	[Token(Token = "0x40005A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7046CC", Offset = "0x7046CC")]
	private Vector3 <NewSize>k__BackingField;

	[Token(Token = "0x40005A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7046DC", Offset = "0x7046DC")]
	private Vector3 <DefaultSize>k__BackingField;

	[Token(Token = "0x40005A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7046EC", Offset = "0x7046EC")]
	private Mesh <Mesh>k__BackingField;

	[Token(Token = "0x40005A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Bounds _bounds;

	[Token(Token = "0x40005A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Transform _pivotTransform;

	[Token(Token = "0x17000081")]
	public Vector3 PivotPosition
	{
		[Token(Token = "0x6000502")]
		[Address(RVA = "0xB7F588", Offset = "0xB7F588", VA = "0xB7F588")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000082")]
	public Vector3 NewSize
	{
		[Token(Token = "0x6000503")]
		[Address(RVA = "0xB7F5A4", Offset = "0xB7F5A4", VA = "0xB7F5A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708118", Offset = "0x708118")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000504")]
		[Address(RVA = "0xB7F5B0", Offset = "0xB7F5B0", VA = "0xB7F5B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708128", Offset = "0x708128")]
		set
		{
		}
	}

	[Token(Token = "0x17000083")]
	public Vector3 DefaultSize
	{
		[Token(Token = "0x6000505")]
		[Address(RVA = "0xB7F5BC", Offset = "0xB7F5BC", VA = "0xB7F5BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708138", Offset = "0x708138")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000506")]
		[Address(RVA = "0xB7F5C8", Offset = "0xB7F5C8", VA = "0xB7F5C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708148", Offset = "0x708148")]
		private set
		{
		}
	}

	[Token(Token = "0x17000084")]
	public Mesh Mesh
	{
		[Token(Token = "0x6000507")]
		[Address(RVA = "0xB7F5D4", Offset = "0xB7F5D4", VA = "0xB7F5D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708158", Offset = "0x708158")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000508")]
		[Address(RVA = "0xB7F5DC", Offset = "0xB7F5DC", VA = "0xB7F5DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708168", Offset = "0x708168")]
		private set
		{
		}
	}

	[Token(Token = "0x6000509")]
	[Address(RVA = "0xB7F5E4", Offset = "0xB7F5E4", VA = "0xB7F5E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600050A")]
	[Address(RVA = "0xB7F72C", Offset = "0xB7F72C", VA = "0xB7F72C")]
	public SimpleResizable()
	{
	}
}
[Token(Token = "0x20000D0")]
public class SimpleResizer
{
	[Token(Token = "0x600050B")]
	[Address(RVA = "0xB7F734", Offset = "0xB7F734", VA = "0xB7F734")]
	public void CreateResizedObject(Vector3 newSize, GameObject parent, SimpleResizable sourcePrefab)
	{
	}

	[Token(Token = "0x600050C")]
	[Address(RVA = "0xB7FA40", Offset = "0xB7FA40", VA = "0xB7FA40")]
	private Mesh ProcessVertices(SimpleResizable resizable, Vector3 newSize)
	{
		return null;
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0xB7FCD8", Offset = "0xB7FCD8", VA = "0xB7FCD8")]
	private float CalculateNewVertexPosition(SimpleResizable.Method resizeMethod, float currentPosition, float currentSize, float newSize, float padding, float paddingMax, float pivot)
	{
		return default(float);
	}

	[Token(Token = "0x600050E")]
	[Address(RVA = "0xB7FDB4", Offset = "0xB7FDB4", VA = "0xB7FDB4")]
	public SimpleResizer()
	{
	}
}
[Serializable]
[Token(Token = "0x20000D1")]
public class Spawnable : ISerializationCallbackReceiver
{
	[Token(Token = "0x40005AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public SimpleResizable ResizablePrefab;

	[Token(Token = "0x40005AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string ClassificationLabel;

	[Token(Token = "0x40005AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _editorClassificationIndex;

	[Token(Token = "0x600050F")]
	[Address(RVA = "0xB809AC", Offset = "0xB809AC", VA = "0xB809AC", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000510")]
	[Address(RVA = "0xB809B0", Offset = "0xB809B0", VA = "0xB809B0", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000511")]
	[Address(RVA = "0xB80E14", Offset = "0xB80E14", VA = "0xB80E14")]
	public Spawnable()
	{
	}

	[Token(Token = "0x6000512")]
	[Address(RVA = "0xB80B20", Offset = "0xB80B20", VA = "0xB80B20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708178", Offset = "0x708178")]
	internal static int <OnAfterDeserialize>g__IndexOf|4_0(string label, IEnumerable<string> collection)
	{
		return default(int);
	}
}
[Token(Token = "0x20000D2")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x702CDC", Offset = "0x702CDC")]
public class VolumeAndPlaneSwitcher : MonoBehaviour
{
	[Token(Token = "0x20000D3")]
	public enum GeometryType
	{
		[Token(Token = "0x40005B4")]
		Plane,
		[Token(Token = "0x40005B5")]
		Volume
	}

	[Serializable]
	[Token(Token = "0x20000D4")]
	public struct LabelGeometryPair
	{
		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string label;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public GeometryType desiredGeometryType;
	}

	[Token(Token = "0x40005B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSceneAnchor planePrefab;

	[Token(Token = "0x40005B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRSceneAnchor volumePrefab;

	[Token(Token = "0x40005B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<LabelGeometryPair> desiredSwitches;

	[Token(Token = "0x6000513")]
	[Address(RVA = "0x194E5D0", Offset = "0x194E5D0", VA = "0x194E5D0")]
	private void ReplaceAnchor(OVRSceneAnchor prefab, Vector3 position, Quaternion rotation, Vector3 localScale)
	{
	}

	[Token(Token = "0x6000514")]
	[Address(RVA = "0x194E9DC", Offset = "0x194E9DC", VA = "0x194E9DC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000515")]
	[Address(RVA = "0x194F280", Offset = "0x194F280", VA = "0x194F280")]
	private void GetVolumeFromTopPlane(Transform plane, Vector2 dimensions, float height, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x6000516")]
	[Address(RVA = "0x194F184", Offset = "0x194F184", VA = "0x194F184")]
	private void GetTopPlaneFromVolume(Transform volume, Vector3 dimensions, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
	}

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x194F304", Offset = "0x194F304", VA = "0x194F304")]
	public VolumeAndPlaneSwitcher()
	{
	}
}
[Token(Token = "0x20000D5")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x702D3C", Offset = "0x702D3C")]
public class Anchor : MonoBehaviour
{
	[Token(Token = "0x20000D6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702D9C", Offset = "0x702D9C")]
	private sealed class <Start>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Anchor <>4__this;

		[Token(Token = "0x17000086")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x19504D8", Offset = "0x19504D8", VA = "0x19504D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x1950520", Offset = "0x1950520", VA = "0x1950520", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1950314", Offset = "0x1950314", VA = "0x1950314")]
		[DebuggerHidden]
		public <Start>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1950340", Offset = "0x1950340", VA = "0x1950340", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1950344", Offset = "0x1950344", VA = "0x1950344", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x19504E0", Offset = "0x19504E0", VA = "0x19504E0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005B8")]
	public const string NumUuidsPlayerPref = "numUuids";

	[Token(Token = "0x40005B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x70471C", Offset = "0x70471C")]
	[SerializeField]
	private Canvas _canvas;

	[Token(Token = "0x40005BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x704768", Offset = "0x704768")]
	private Transform _pivot;

	[Token(Token = "0x40005BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7047B4", Offset = "0x7047B4")]
	[SerializeField]
	private GameObject _anchorMenu;

	[Token(Token = "0x40005BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool _isSelected;

	[Token(Token = "0x40005BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool _isHovered;

	[Token(Token = "0x40005BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x704800", Offset = "0x704800")]
	[SerializeField]
	private TextMeshProUGUI _anchorName;

	[Token(Token = "0x40005BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x70484C", Offset = "0x70484C")]
	private GameObject _saveIcon;

	[Token(Token = "0x40005C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x704898", Offset = "0x704898")]
	private Image _labelImage;

	[Token(Token = "0x40005C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7048E4", Offset = "0x7048E4")]
	private Color _labelBaseColor;

	[Token(Token = "0x40005C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x704930", Offset = "0x704930")]
	[SerializeField]
	private Color _labelHighlightColor;

	[Token(Token = "0x40005C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x70497C", Offset = "0x70497C")]
	[SerializeField]
	private Color _labelSelectedColor;

	[Token(Token = "0x40005C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7049C8", Offset = "0x7049C8")]
	[SerializeField]
	private AnchorUIManager _uiManager;

	[Token(Token = "0x40005C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x704A14", Offset = "0x704A14")]
	[SerializeField]
	private MeshRenderer[] _renderers;

	[Token(Token = "0x40005C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int _menuIndex;

	[Token(Token = "0x40005C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x704A60", Offset = "0x704A60")]
	private List<Button> _buttonList;

	[Token(Token = "0x40005C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Button _selectedButton;

	[Token(Token = "0x40005C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private OVRSpatialAnchor _spatialAnchor;

	[Token(Token = "0x40005CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private GameObject _icon;

	[Token(Token = "0x17000085")]
	public bool ShowSaveIcon
	{
		[Token(Token = "0x600051E")]
		[Address(RVA = "0xCD588C", Offset = "0xCD588C", VA = "0xCD588C")]
		set
		{
		}
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0xCD51B4", Offset = "0xCD51B4", VA = "0xCD51B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000519")]
	[Address(RVA = "0xCD532C", Offset = "0xCD532C", VA = "0xCD532C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x708188", Offset = "0x708188")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600051A")]
	[Address(RVA = "0xCD53A4", Offset = "0xCD53A4", VA = "0xCD53A4")]
	private void Update()
	{
	}

	[Token(Token = "0x600051B")]
	[Address(RVA = "0xCD5624", Offset = "0xCD5624", VA = "0xCD5624")]
	public void OnSaveLocalButtonPressed()
	{
	}

	[Token(Token = "0x600051C")]
	[Address(RVA = "0xCD571C", Offset = "0xCD571C", VA = "0xCD571C")]
	public void OnHideButtonPressed()
	{
	}

	[Token(Token = "0x600051D")]
	[Address(RVA = "0xCD5794", Offset = "0xCD5794", VA = "0xCD5794")]
	public void OnEraseButtonPressed()
	{
	}

	[Token(Token = "0x600051F")]
	[Address(RVA = "0xCD58AC", Offset = "0xCD58AC", VA = "0xCD58AC")]
	public void OnHoverStart()
	{
	}

	[Token(Token = "0x6000520")]
	[Address(RVA = "0xCD59B4", Offset = "0xCD59B4", VA = "0xCD59B4")]
	public void OnHoverEnd()
	{
	}

	[Token(Token = "0x6000521")]
	[Address(RVA = "0xCD5AD4", Offset = "0xCD5AD4", VA = "0xCD5AD4")]
	public void OnSelect()
	{
	}

	[Token(Token = "0x6000522")]
	[Address(RVA = "0xCD5400", Offset = "0xCD5400", VA = "0xCD5400")]
	private void BillboardPanel(Transform panel)
	{
	}

	[Token(Token = "0x6000523")]
	[Address(RVA = "0xCD5514", Offset = "0xCD5514", VA = "0xCD5514")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x6000524")]
	[Address(RVA = "0xCD5BA8", Offset = "0xCD5BA8", VA = "0xCD5BA8")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x6000525")]
	[Address(RVA = "0xCD5D00", Offset = "0xCD5D00", VA = "0xCD5D00")]
	public Anchor()
	{
	}

	[Token(Token = "0x6000526")]
	[Address(RVA = "0xCD5D08", Offset = "0xCD5D08", VA = "0xCD5D08")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7081E8", Offset = "0x7081E8")]
	private void <OnSaveLocalButtonPressed>b__22_0(OVRSpatialAnchor anchor, bool success)
	{
	}

	[Token(Token = "0x6000527")]
	[Address(RVA = "0xCD5E30", Offset = "0xCD5E30", VA = "0xCD5E30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7081F8", Offset = "0x7081F8")]
	private void <OnEraseButtonPressed>b__24_0(OVRSpatialAnchor anchor, bool success)
	{
	}
}
[Token(Token = "0x20000D7")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x702DAC", Offset = "0x702DAC")]
public class AnchorUIManager : MonoBehaviour
{
	[Token(Token = "0x20000D8")]
	public enum AnchorMode
	{
		[Token(Token = "0x40005E1")]
		Create,
		[Token(Token = "0x40005E2")]
		Select
	}

	[Token(Token = "0x20000D9")]
	private delegate void PrimaryPressDelegate();

	[Token(Token = "0x40005CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorUIManager Instance;

	[Token(Token = "0x40005CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x704AAC", Offset = "0x704AAC")]
	[SerializeField]
	private GameObject _createModeButton;

	[Token(Token = "0x40005D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x704AF8", Offset = "0x704AF8")]
	private GameObject _selectModeButton;

	[Token(Token = "0x40005D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x704B44", Offset = "0x704B44")]
	private Transform _trackedDevice;

	[Token(Token = "0x40005D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _raycastOrigin;

	[Token(Token = "0x40005D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool _drawRaycast;

	[Token(Token = "0x40005D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x704B90", Offset = "0x704B90")]
	[SerializeField]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x40005D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Anchor _hoveredAnchor;

	[Token(Token = "0x40005D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Anchor _selectedAnchor;

	[Token(Token = "0x40005D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AnchorMode _mode;

	[Token(Token = "0x40005D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x704BDC", Offset = "0x704BDC")]
	private List<Button> _buttonList;

	[Token(Token = "0x40005D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int _menuIndex;

	[Token(Token = "0x40005DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Button _selectedButton;

	[Token(Token = "0x40005DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Anchor _anchorPrefab;

	[Token(Token = "0x40005DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x704C38", Offset = "0x704C38")]
	private GameObject _placementPreview;

	[Token(Token = "0x40005DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x704C84", Offset = "0x704C84")]
	private Transform _anchorPlacementTransform;

	[Token(Token = "0x40005DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private PrimaryPressDelegate _primaryPressDelegate;

	[Token(Token = "0x40005DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool _isFocused;

	[Token(Token = "0x17000088")]
	public Anchor AnchorPrefab
	{
		[Token(Token = "0x600052E")]
		[Address(RVA = "0xCD5E58", Offset = "0xCD5E58", VA = "0xCD5E58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600052F")]
	[Address(RVA = "0xCD5E60", Offset = "0xCD5E60", VA = "0xCD5E60")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000530")]
	[Address(RVA = "0xCD5F38", Offset = "0xCD5F38", VA = "0xCD5F38")]
	private void Start()
	{
	}

	[Token(Token = "0x6000531")]
	[Address(RVA = "0xCD60A4", Offset = "0xCD60A4", VA = "0xCD60A4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000532")]
	[Address(RVA = "0xCD64F8", Offset = "0xCD64F8", VA = "0xCD64F8")]
	public void OnCreateModeButtonPressed()
	{
	}

	[Token(Token = "0x6000533")]
	[Address(RVA = "0xCD6568", Offset = "0xCD6568", VA = "0xCD6568")]
	public void OnLoadAnchorsButtonPressed()
	{
	}

	[Token(Token = "0x6000534")]
	[Address(RVA = "0xCD602C", Offset = "0xCD602C", VA = "0xCD602C")]
	private void ToggleCreateMode()
	{
	}

	[Token(Token = "0x6000535")]
	[Address(RVA = "0xCD65F0", Offset = "0xCD65F0", VA = "0xCD65F0")]
	private void StartPlacementMode()
	{
	}

	[Token(Token = "0x6000536")]
	[Address(RVA = "0xCD6678", Offset = "0xCD6678", VA = "0xCD6678")]
	private void EndPlacementMode()
	{
	}

	[Token(Token = "0x6000537")]
	[Address(RVA = "0xCD66A4", Offset = "0xCD66A4", VA = "0xCD66A4")]
	private void StartSelectMode()
	{
	}

	[Token(Token = "0x6000538")]
	[Address(RVA = "0xCD65C4", Offset = "0xCD65C4", VA = "0xCD65C4")]
	private void EndSelectMode()
	{
	}

	[Token(Token = "0x6000539")]
	[Address(RVA = "0xCD63E8", Offset = "0xCD63E8", VA = "0xCD63E8")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x600053A")]
	[Address(RVA = "0xCD67E0", Offset = "0xCD67E0", VA = "0xCD67E0")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x600053B")]
	[Address(RVA = "0xCD672C", Offset = "0xCD672C", VA = "0xCD672C")]
	private void ShowAnchorPreview()
	{
	}

	[Token(Token = "0x600053C")]
	[Address(RVA = "0xCD674C", Offset = "0xCD674C", VA = "0xCD674C")]
	private void HideAnchorPreview()
	{
	}

	[Token(Token = "0x600053D")]
	[Address(RVA = "0xCD68F8", Offset = "0xCD68F8", VA = "0xCD68F8")]
	private void PlaceAnchor()
	{
	}

	[Token(Token = "0x600053E")]
	[Address(RVA = "0xCD676C", Offset = "0xCD676C", VA = "0xCD676C")]
	private void ShowRaycastLine()
	{
	}

	[Token(Token = "0x600053F")]
	[Address(RVA = "0xCD67A8", Offset = "0xCD67A8", VA = "0xCD67A8")]
	private void HideRaycastLine()
	{
	}

	[Token(Token = "0x6000540")]
	[Address(RVA = "0xCD61B0", Offset = "0xCD61B0", VA = "0xCD61B0")]
	private void ControllerRaycast()
	{
	}

	[Token(Token = "0x6000541")]
	[Address(RVA = "0xCD69F0", Offset = "0xCD69F0", VA = "0xCD69F0")]
	private void HoverAnchor(Anchor anchor)
	{
	}

	[Token(Token = "0x6000542")]
	[Address(RVA = "0xCD6A24", Offset = "0xCD6A24", VA = "0xCD6A24")]
	private void UnhoverAnchor()
	{
	}

	[Token(Token = "0x6000543")]
	[Address(RVA = "0xCD6AC0", Offset = "0xCD6AC0", VA = "0xCD6AC0")]
	private void SelectAnchor()
	{
	}

	[Token(Token = "0x6000544")]
	[Address(RVA = "0xCD6C3C", Offset = "0xCD6C3C", VA = "0xCD6C3C")]
	public AnchorUIManager()
	{
	}
}
[Token(Token = "0x20000DA")]
public class SpatialAnchorLoader : MonoBehaviour
{
	[Token(Token = "0x40005E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OVRSpatialAnchor _anchorPrefab;

	[Token(Token = "0x40005E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Action<OVRSpatialAnchor.UnboundAnchor, bool> _onLoadAnchor;

	[Token(Token = "0x6000549")]
	[Address(RVA = "0xB8009C", Offset = "0xB8009C", VA = "0xB8009C")]
	public void LoadAnchorsByUuid()
	{
	}

	[Token(Token = "0x600054A")]
	[Address(RVA = "0xB80444", Offset = "0xB80444", VA = "0xB80444")]
	private void Awake()
	{
	}

	[Token(Token = "0x600054B")]
	[Address(RVA = "0xB8034C", Offset = "0xB8034C", VA = "0xB8034C")]
	private void Load(OVRSpatialAnchor.LoadOptions options)
	{
	}

	[Token(Token = "0x600054C")]
	[Address(RVA = "0xB804D8", Offset = "0xB804D8", VA = "0xB804D8")]
	private void OnLocalized(OVRSpatialAnchor.UnboundAnchor unboundAnchor, bool success)
	{
	}

	[Token(Token = "0x600054D")]
	[Address(RVA = "0xB802BC", Offset = "0xB802BC", VA = "0xB802BC")]
	private static void Log(string message)
	{
	}

	[Token(Token = "0x600054E")]
	[Address(RVA = "0xB8068C", Offset = "0xB8068C", VA = "0xB8068C")]
	public SpatialAnchorLoader()
	{
	}

	[Token(Token = "0x600054F")]
	[Address(RVA = "0xB80694", Offset = "0xB80694", VA = "0xB80694")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708258", Offset = "0x708258")]
	private void <Load>b__4_0(OVRSpatialAnchor.UnboundAnchor[] anchors)
	{
	}
}
[Token(Token = "0x20000DB")]
public class StartMenu : MonoBehaviour
{
	[Token(Token = "0x20000DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702E0C", Offset = "0x702E0C")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int sceneIndex;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StartMenu <>4__this;

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x191CA74", Offset = "0x191CA74", VA = "0x191CA74")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x191CA7C", Offset = "0x191CA7C", VA = "0x191CA7C")]
		internal void <Start>b__0()
		{
		}
	}

	[Token(Token = "0x40005E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVROverlay overlay;

	[Token(Token = "0x40005E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVROverlay text;

	[Token(Token = "0x40005E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig vrRig;

	[Token(Token = "0x6000550")]
	[Address(RVA = "0xB855C8", Offset = "0xB855C8", VA = "0xB855C8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000551")]
	[Address(RVA = "0xB857E4", Offset = "0xB857E4", VA = "0xB857E4")]
	private void LoadScene(int idx)
	{
	}

	[Token(Token = "0x6000552")]
	[Address(RVA = "0xB858F4", Offset = "0xB858F4", VA = "0xB858F4")]
	public StartMenu()
	{
	}
}
[Token(Token = "0x20000DD")]
public class LocalizedHaptics : MonoBehaviour
{
	[Token(Token = "0x40005EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x704CE0", Offset = "0x704CE0")]
	private OVRInput.Handedness m_handedness;

	[Token(Token = "0x40005EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private OVRInput.Controller m_controller;

	[Token(Token = "0x6000555")]
	[Address(RVA = "0xC138E8", Offset = "0xC138E8", VA = "0xC138E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000556")]
	[Address(RVA = "0xC13910", Offset = "0xC13910", VA = "0xC13910")]
	private void Update()
	{
	}

	[Token(Token = "0x6000557")]
	[Address(RVA = "0xC13A78", Offset = "0xC13A78", VA = "0xC13A78")]
	public LocalizedHaptics()
	{
	}
}
[Token(Token = "0x20000DE")]
public class SceneSettings : MonoBehaviour
{
	[Token(Token = "0x40005EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x704D2C", Offset = "0x704D2C")]
	private float m_fixedTimeStep;

	[Token(Token = "0x40005ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x704D78", Offset = "0x704D78")]
	[SerializeField]
	private float m_gravityScalar;

	[Token(Token = "0x40005EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float m_defaultContactOffset;

	[Token(Token = "0x6000558")]
	[Address(RVA = "0xB7D724", Offset = "0xB7D724", VA = "0xB7D724")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000559")]
	[Address(RVA = "0xB7D788", Offset = "0xB7D788", VA = "0xB7D788")]
	private void Start()
	{
	}

	[Token(Token = "0x600055A")]
	[Address(RVA = "0xB7D790", Offset = "0xB7D790", VA = "0xB7D790")]
	private static void CollidersSetContactOffset(float contactOffset)
	{
	}

	[Token(Token = "0x600055B")]
	[Address(RVA = "0xB7D868", Offset = "0xB7D868", VA = "0xB7D868")]
	public SceneSettings()
	{
	}
}
[Token(Token = "0x20000DF")]
public class StylusTip : MonoBehaviour
{
	[Token(Token = "0x40005EF")]
	private const int MaxBreadCrumbs = 60;

	[Token(Token = "0x40005F0")]
	private const float BreadCrumbMinSize = 0.005f;

	[Token(Token = "0x40005F1")]
	private const float BreadCrumbMaxSize = 0.02f;

	[Token(Token = "0x40005F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x704DD4", Offset = "0x704DD4")]
	private Transform m_trackingSpace;

	[Token(Token = "0x40005F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x704E20", Offset = "0x704E20")]
	private OVRInput.Handedness m_handedness;

	[Token(Token = "0x40005F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject m_breadCrumbPf;

	[Token(Token = "0x40005F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject m_breadCrumbContainer;

	[Token(Token = "0x40005F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject[] m_breadCrumbs;

	[Token(Token = "0x40005F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int m_breadCrumbIndexPrev;

	[Token(Token = "0x40005F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int m_breadCrumbIndexCurr;

	[Token(Token = "0x40005F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private OVRInput.Controller m_controller;

	[Token(Token = "0x600055C")]
	[Address(RVA = "0xB858FC", Offset = "0xB858FC", VA = "0xB858FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600055D")]
	[Address(RVA = "0xB85B94", Offset = "0xB85B94", VA = "0xB85B94")]
	private void Update()
	{
	}

	[Token(Token = "0x600055E")]
	[Address(RVA = "0xB85FD8", Offset = "0xB85FD8", VA = "0xB85FD8")]
	private static Pose GetT_Device_StylusTip(OVRInput.Controller controller)
	{
		return default(Pose);
	}

	[Token(Token = "0x600055F")]
	[Address(RVA = "0xB86110", Offset = "0xB86110", VA = "0xB86110")]
	public StylusTip()
	{
	}
}
[Token(Token = "0x20000E0")]
public class UiAxis1dInspector : MonoBehaviour
{
	[Token(Token = "0x40005FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x704E7C", Offset = "0x704E7C")]
	private float m_minExtent;

	[Token(Token = "0x40005FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float m_maxExtent;

	[Token(Token = "0x40005FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x704ED8", Offset = "0x704ED8")]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x40005FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI m_valueLabel;

	[Token(Token = "0x40005FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Slider m_slider;

	[Token(Token = "0x6000560")]
	[Address(RVA = "0x194BC18", Offset = "0x194BC18", VA = "0x194BC18")]
	public void SetExtents(float minExtent, float maxExtent)
	{
	}

	[Token(Token = "0x6000561")]
	[Address(RVA = "0x194BC20", Offset = "0x194BC20", VA = "0x194BC20")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0x194BC44", Offset = "0x194BC44", VA = "0x194BC44")]
	public void SetValue(float value)
	{
	}

	[Token(Token = "0x6000563")]
	[Address(RVA = "0x194BD54", Offset = "0x194BD54", VA = "0x194BD54")]
	public UiAxis1dInspector()
	{
	}
}
[Token(Token = "0x20000E1")]
public class UiAxis2dInspector : MonoBehaviour
{
	[Token(Token = "0x40005FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x704F44", Offset = "0x704F44")]
	private Vector2 m_xExtent;

	[Token(Token = "0x4000600")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector2 m_yExtent;

	[Token(Token = "0x4000601")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x704FA0", Offset = "0x704FA0")]
	[SerializeField]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x4000602")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private TextMeshProUGUI m_valueLabel;

	[Token(Token = "0x4000603")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image m_handle;

	[Token(Token = "0x6000564")]
	[Address(RVA = "0x194BD64", Offset = "0x194BD64", VA = "0x194BD64")]
	public void SetExtents(Vector2 xExtent, Vector2 yExtent)
	{
	}

	[Token(Token = "0x6000565")]
	[Address(RVA = "0x194BD70", Offset = "0x194BD70", VA = "0x194BD70")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x6000566")]
	[Address(RVA = "0x194BD94", Offset = "0x194BD94", VA = "0x194BD94")]
	public void SetValue(bool isTouching, Vector2 value)
	{
	}

	[Token(Token = "0x6000567")]
	[Address(RVA = "0x194C174", Offset = "0x194C174", VA = "0x194C174")]
	public UiAxis2dInspector()
	{
	}
}
[Token(Token = "0x20000E2")]
public class UiBoolInspector : MonoBehaviour
{
	[Token(Token = "0x4000604")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x70500C", Offset = "0x70500C")]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x4000605")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Toggle m_toggle;

	[Token(Token = "0x6000568")]
	[Address(RVA = "0x194C188", Offset = "0x194C188", VA = "0x194C188")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x6000569")]
	[Address(RVA = "0x194C1AC", Offset = "0x194C1AC", VA = "0x194C1AC")]
	public void SetValue(bool value)
	{
	}

	[Token(Token = "0x600056A")]
	[Address(RVA = "0x194C1CC", Offset = "0x194C1CC", VA = "0x194C1CC")]
	public UiBoolInspector()
	{
	}
}
[Token(Token = "0x20000E3")]
public class UiDeviceInspector : MonoBehaviour
{
	[Token(Token = "0x4000606")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x705068", Offset = "0x705068")]
	private OVRInput.Handedness m_handedness;

	[Token(Token = "0x4000607")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7050B4", Offset = "0x7050B4")]
	[SerializeField]
	private TextMeshProUGUI m_title;

	[Token(Token = "0x4000608")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI m_status;

	[Token(Token = "0x4000609")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UiBoolInspector m_thumbRestTouch;

	[Token(Token = "0x400060A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UiAxis1dInspector m_thumbRestForce;

	[Token(Token = "0x400060B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UiAxis1dInspector m_indexTrigger;

	[Token(Token = "0x400060C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private UiAxis1dInspector m_gripTrigger;

	[Token(Token = "0x400060D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private UiAxis1dInspector m_stylusTipForce;

	[Token(Token = "0x400060E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private UiAxis1dInspector m_indexCurl1d;

	[Token(Token = "0x400060F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UiAxis1dInspector m_indexSlider1d;

	[Token(Token = "0x4000610")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x705180", Offset = "0x705180")]
	[SerializeField]
	private UiBoolInspector m_ax;

	[Token(Token = "0x4000611")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UiBoolInspector m_axTouch;

	[Token(Token = "0x4000612")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private UiBoolInspector m_by;

	[Token(Token = "0x4000613")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UiBoolInspector m_byTouch;

	[Token(Token = "0x4000614")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UiBoolInspector m_indexTouch;

	[Token(Token = "0x4000615")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private UiAxis2dInspector m_thumbstick;

	[Token(Token = "0x4000616")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private OVRInput.Controller m_controller;

	[Token(Token = "0x600056B")]
	[Address(RVA = "0x194C1D4", Offset = "0x194C1D4", VA = "0x194C1D4")]
	private void Start()
	{
	}

	[Token(Token = "0x600056C")]
	[Address(RVA = "0x194C1FC", Offset = "0x194C1FC", VA = "0x194C1FC")]
	private void Update()
	{
	}

	[Token(Token = "0x600056D")]
	[Address(RVA = "0x194C78C", Offset = "0x194C78C", VA = "0x194C78C")]
	private static string ToDeviceModel()
	{
		return null;
	}

	[Token(Token = "0x600056E")]
	[Address(RVA = "0x194C7D0", Offset = "0x194C7D0", VA = "0x194C7D0")]
	private static string ToHandednessString(OVRInput.Handedness handedness)
	{
		return null;
	}

	[Token(Token = "0x600056F")]
	[Address(RVA = "0x194C850", Offset = "0x194C850", VA = "0x194C850")]
	public UiDeviceInspector()
	{
	}
}
[Token(Token = "0x20000E4")]
public class UiSceneMenu : MonoBehaviour
{
	[Token(Token = "0x4000617")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x70521C", Offset = "0x70521C")]
	[SerializeField]
	private VerticalLayoutGroup m_layoutGroup;

	[Token(Token = "0x4000618")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI m_labelPf;

	[Token(Token = "0x4000619")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Vector2 s_lastThumbstickL;

	[Token(Token = "0x400061A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Vector2 s_lastThumbstickR;

	[Token(Token = "0x400061B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Scene m_activeScene;

	[Token(Token = "0x6000570")]
	[Address(RVA = "0x194C860", Offset = "0x194C860", VA = "0x194C860")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000571")]
	[Address(RVA = "0x194CB5C", Offset = "0x194CB5C", VA = "0x194CB5C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000572")]
	[Address(RVA = "0x194CC88", Offset = "0x194CC88", VA = "0x194CC88")]
	private bool InputPrevScene()
	{
		return default(bool);
	}

	[Token(Token = "0x6000573")]
	[Address(RVA = "0x194CD40", Offset = "0x194CD40", VA = "0x194CD40")]
	private bool InputNextScene()
	{
		return default(bool);
	}

	[Token(Token = "0x6000574")]
	[Address(RVA = "0x194CD94", Offset = "0x194CD94", VA = "0x194CD94")]
	private bool KeyboardPrevScene()
	{
		return default(bool);
	}

	[Token(Token = "0x6000575")]
	[Address(RVA = "0x194CE3C", Offset = "0x194CE3C", VA = "0x194CE3C")]
	private bool KeyboardNextScene()
	{
		return default(bool);
	}

	[Token(Token = "0x6000576")]
	[Address(RVA = "0x194CDA0", Offset = "0x194CDA0", VA = "0x194CDA0")]
	private bool ThumbstickPrevScene(OVRInput.Controller controller)
	{
		return default(bool);
	}

	[Token(Token = "0x6000577")]
	[Address(RVA = "0x194CE48", Offset = "0x194CE48", VA = "0x194CE48")]
	private bool ThumbstickNextScene(OVRInput.Controller controller)
	{
		return default(bool);
	}

	[Token(Token = "0x6000578")]
	[Address(RVA = "0x194CEE4", Offset = "0x194CEE4", VA = "0x194CEE4")]
	private Vector2 GetLastThumbstickValue(OVRInput.Controller controller)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000579")]
	[Address(RVA = "0x194CCDC", Offset = "0x194CCDC", VA = "0x194CCDC")]
	private void ChangeScene(int nextScene)
	{
	}

	[Token(Token = "0x600057A")]
	[Address(RVA = "0x194C920", Offset = "0x194C920", VA = "0x194C920")]
	private void CreateLabel(int sceneIndex, string scenePath)
	{
	}

	[Token(Token = "0x600057B")]
	[Address(RVA = "0x194CF50", Offset = "0x194CF50", VA = "0x194CF50")]
	public UiSceneMenu()
	{
	}
}
[Token(Token = "0x20000E5")]
public class UiVectorInspector : MonoBehaviour
{
	[Token(Token = "0x400061C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x705278", Offset = "0x705278")]
	private TextMeshProUGUI m_nameLabel;

	[Token(Token = "0x400061D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI m_valueLabel;

	[Token(Token = "0x600057C")]
	[Address(RVA = "0x194CF58", Offset = "0x194CF58", VA = "0x194CF58")]
	public void SetName(string name)
	{
	}

	[Token(Token = "0x600057D")]
	[Address(RVA = "0x194CF7C", Offset = "0x194CF7C", VA = "0x194CF7C")]
	public void SetValue(bool value)
	{
	}

	[Token(Token = "0x600057E")]
	[Address(RVA = "0x194D028", Offset = "0x194D028", VA = "0x194D028")]
	public UiVectorInspector()
	{
	}
}
[Token(Token = "0x20000E6")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x702E1C", Offset = "0x702E1C")]
public class RampAsset : ScriptableObject
{
	[Token(Token = "0x400061E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Gradient gradient;

	[Token(Token = "0x400061F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int size;

	[Token(Token = "0x4000620")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool up;

	[Token(Token = "0x4000621")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool overwriteExisting;

	[Token(Token = "0x600057F")]
	[Address(RVA = "0xB7AEBC", Offset = "0xB7AEBC", VA = "0xB7AEBC")]
	public RampAsset()
	{
	}
}
[Token(Token = "0x20000E7")]
public class AdjustTimeScale : MonoBehaviour
{
	[Token(Token = "0x4000622")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private TextMeshProUGUI textMesh;

	[Token(Token = "0x6000580")]
	[Address(RVA = "0xCD4E74", Offset = "0xCD4E74", VA = "0xCD4E74")]
	private void Start()
	{
	}

	[Token(Token = "0x6000581")]
	[Address(RVA = "0xCD4ED0", Offset = "0xCD4ED0", VA = "0xCD4ED0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000582")]
	[Address(RVA = "0xCD50A8", Offset = "0xCD50A8", VA = "0xCD50A8")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000583")]
	[Address(RVA = "0xCD50D0", Offset = "0xCD50D0", VA = "0xCD50D0")]
	public AdjustTimeScale()
	{
	}
}
[Token(Token = "0x20000E8")]
public class ProximityActivate : MonoBehaviour
{
	[Token(Token = "0x4000623")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform distanceActivator;

	[Token(Token = "0x4000624")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform lookAtActivator;

	[Token(Token = "0x4000625")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float distance;

	[Token(Token = "0x4000626")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform activator;

	[Token(Token = "0x4000627")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool activeState;

	[Token(Token = "0x4000628")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public CanvasGroup target;

	[Token(Token = "0x4000629")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool lookAtCamera;

	[Token(Token = "0x400062A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool enableInfoPanel;

	[Token(Token = "0x400062B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject infoIcon;

	[Token(Token = "0x400062C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float alpha;

	[Token(Token = "0x400062D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public CanvasGroup infoPanel;

	[Token(Token = "0x400062E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Quaternion originRotation;

	[Token(Token = "0x400062F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Quaternion targetRotation;

	[Token(Token = "0x6000584")]
	[Address(RVA = "0x13198E8", Offset = "0x13198E8", VA = "0x13198E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000585")]
	[Address(RVA = "0x1319A0C", Offset = "0x1319A0C", VA = "0x1319A0C")]
	private bool IsTargetNear()
	{
		return default(bool);
	}

	[Token(Token = "0x6000586")]
	[Address(RVA = "0x1319C40", Offset = "0x1319C40", VA = "0x1319C40")]
	private void Update()
	{
	}

	[Token(Token = "0x6000587")]
	[Address(RVA = "0x1319EE8", Offset = "0x1319EE8", VA = "0x1319EE8")]
	public ProximityActivate()
	{
	}
}
[Token(Token = "0x20000E9")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x702E2C", Offset = "0x702E2C")]
public class SimpleCharacterMotor : MonoBehaviour
{
	[Token(Token = "0x4000630")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CursorLockMode cursorLockMode;

	[Token(Token = "0x4000631")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool cursorVisible;

	[Token(Token = "0x4000632")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7052D4", Offset = "0x7052D4")]
	public float walkSpeed;

	[Token(Token = "0x4000633")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float runSpeed;

	[Token(Token = "0x4000634")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float gravity;

	[Token(Token = "0x4000635")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x70530C", Offset = "0x70530C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x70530C", Offset = "0x70530C")]
	public Transform cameraPivot;

	[Token(Token = "0x4000636")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float lookSpeed;

	[Token(Token = "0x4000637")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool invertY;

	[Token(Token = "0x4000638")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x705358", Offset = "0x705358")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x705358", Offset = "0x705358")]
	public float movementAcceleration;

	[Token(Token = "0x4000639")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private CharacterController controller;

	[Token(Token = "0x400063A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 movement;

	[Token(Token = "0x400063B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Vector3 finalMovement;

	[Token(Token = "0x400063C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float speed;

	[Token(Token = "0x400063D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Quaternion targetRotation;

	[Token(Token = "0x400063E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Quaternion targetPivotRotation;

	[Token(Token = "0x6000588")]
	[Address(RVA = "0xB7F0D4", Offset = "0xB7F0D4", VA = "0xB7F0D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000589")]
	[Address(RVA = "0xB7F164", Offset = "0xB7F164", VA = "0xB7F164")]
	private void Update()
	{
	}

	[Token(Token = "0x600058A")]
	[Address(RVA = "0xB7F330", Offset = "0xB7F330", VA = "0xB7F330")]
	private void UpdateLookRotation()
	{
	}

	[Token(Token = "0x600058B")]
	[Address(RVA = "0xB7F188", Offset = "0xB7F188", VA = "0xB7F188")]
	private void UpdateTranslation()
	{
	}

	[Token(Token = "0x600058C")]
	[Address(RVA = "0xB7F54C", Offset = "0xB7F54C", VA = "0xB7F54C")]
	public SimpleCharacterMotor()
	{
	}
}
[Token(Token = "0x20000EA")]
public class AnimateTiledTextureOnTrail : MonoBehaviour
{
	[Token(Token = "0x20000EB")]
	public delegate void VoidEvent();

	[Token(Token = "0x20000EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702E8C", Offset = "0x702E8C")]
	private sealed class <updateTiling>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimateTiledTextureOnTrail <>4__this;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <checkAgainst>5__2;

		[Token(Token = "0x17000089")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x195098C", Offset = "0x195098C", VA = "0x195098C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x19509D4", Offset = "0x19509D4", VA = "0x19509D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x19507D8", Offset = "0x19507D8", VA = "0x19507D8")]
		[DebuggerHidden]
		public <updateTiling>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1950804", Offset = "0x1950804", VA = "0x1950804", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1950808", Offset = "0x1950808", VA = "0x1950808", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1950994", Offset = "0x1950994", VA = "0x1950994", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400063F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int _columns;

	[Token(Token = "0x4000640")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int _rows;

	[Token(Token = "0x4000641")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector2 _scale;

	[Token(Token = "0x4000642")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 _offset;

	[Token(Token = "0x4000643")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector2 _buffer;

	[Token(Token = "0x4000644")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float _framesPerSecond;

	[Token(Token = "0x4000645")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool _playOnce;

	[Token(Token = "0x4000646")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	public bool _disableUponCompletion;

	[Token(Token = "0x4000647")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	public bool _enableEvents;

	[Token(Token = "0x4000648")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
	public bool _playOnEnable;

	[Token(Token = "0x4000649")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool _newMaterialInstance;

	[Token(Token = "0x400064A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int _index;

	[Token(Token = "0x400064B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector2 _textureSize;

	[Token(Token = "0x400064C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Material _materialInstance;

	[Token(Token = "0x400064D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _hasMaterialInstance;

	[Token(Token = "0x400064E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	private bool _isPlaying;

	[Token(Token = "0x400064F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<VoidEvent> _voidEventCallbackList;

	[Token(Token = "0x600058D")]
	[Address(RVA = "0xCD6C4C", Offset = "0xCD6C4C", VA = "0xCD6C4C")]
	public void RegisterCallback(VoidEvent cbFunction)
	{
	}

	[Token(Token = "0x600058E")]
	[Address(RVA = "0xCD6D10", Offset = "0xCD6D10", VA = "0xCD6D10")]
	public void UnRegisterCallback(VoidEvent cbFunction)
	{
	}

	[Token(Token = "0x600058F")]
	[Address(RVA = "0xCD6DD4", Offset = "0xCD6DD4", VA = "0xCD6DD4")]
	public void Play()
	{
	}

	[Token(Token = "0x6000590")]
	[Address(RVA = "0xCD6EFC", Offset = "0xCD6EFC", VA = "0xCD6EFC")]
	public void ChangeMaterial(Material newMaterial, bool newInstance = false)
	{
	}

	[Token(Token = "0x6000591")]
	[Address(RVA = "0xCD70D0", Offset = "0xCD70D0", VA = "0xCD70D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000592")]
	[Address(RVA = "0xCD7190", Offset = "0xCD7190", VA = "0xCD7190")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000593")]
	[Address(RVA = "0xCD723C", Offset = "0xCD723C", VA = "0xCD723C")]
	private void HandleCallbacks(List<VoidEvent> cbList)
	{
	}

	[Token(Token = "0x6000594")]
	[Address(RVA = "0xCD72D4", Offset = "0xCD72D4", VA = "0xCD72D4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000595")]
	[Address(RVA = "0xCD70AC", Offset = "0xCD70AC", VA = "0xCD70AC")]
	private void CalcTextureSize()
	{
	}

	[Token(Token = "0x6000596")]
	[Address(RVA = "0xCD6E84", Offset = "0xCD6E84", VA = "0xCD6E84")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x708268", Offset = "0x708268")]
	private IEnumerator updateTiling()
	{
		return null;
	}

	[Token(Token = "0x6000597")]
	[Address(RVA = "0xCD7304", Offset = "0xCD7304", VA = "0xCD7304")]
	private void ApplyOffset()
	{
	}

	[Token(Token = "0x6000598")]
	[Address(RVA = "0xCD7414", Offset = "0xCD7414", VA = "0xCD7414")]
	public AnimateTiledTextureOnTrail()
	{
	}
}
[Token(Token = "0x20000ED")]
public class AnimatedUVs : MonoBehaviour
{
	[Token(Token = "0x4000654")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speedY;

	[Token(Token = "0x4000655")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float speedx;

	[Token(Token = "0x4000656")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float offsety;

	[Token(Token = "0x4000657")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float offsetx;

	[Token(Token = "0x4000658")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Renderer rend;

	[Token(Token = "0x60005A3")]
	[Address(RVA = "0xCD7478", Offset = "0xCD7478", VA = "0xCD7478")]
	private void Start()
	{
	}

	[Token(Token = "0x60005A4")]
	[Address(RVA = "0xCD74D4", Offset = "0xCD74D4", VA = "0xCD74D4")]
	private void Update()
	{
	}

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0xCD757C", Offset = "0xCD757C", VA = "0xCD757C")]
	public AnimatedUVs()
	{
	}
}
[Token(Token = "0x20000EE")]
public class BillBoard : MonoBehaviour
{
	[Token(Token = "0x60005A6")]
	[Address(RVA = "0xCD88BC", Offset = "0xCD88BC", VA = "0xCD88BC")]
	private void Start()
	{
	}

	[Token(Token = "0x60005A7")]
	[Address(RVA = "0xCD88C0", Offset = "0xCD88C0", VA = "0xCD88C0")]
	private void Update()
	{
	}

	[Token(Token = "0x60005A8")]
	[Address(RVA = "0xCD8914", Offset = "0xCD8914", VA = "0xCD8914")]
	public BillBoard()
	{
	}
}
[Token(Token = "0x20000EF")]
public class button_target : MonoBehaviour
{
	[Token(Token = "0x4000659")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject MY_target;

	[Token(Token = "0x400065A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject temp_target;

	[Token(Token = "0x400065B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject[] ALL_target;

	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x194FE04", Offset = "0x194FE04", VA = "0x194FE04")]
	private void Start()
	{
	}

	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x194FF34", Offset = "0x194FF34", VA = "0x194FF34")]
	private void Update()
	{
	}

	[Token(Token = "0x60005AB")]
	[Address(RVA = "0x194FF38", Offset = "0x194FF38", VA = "0x194FF38")]
	public void ShowTarget()
	{
	}

	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x195000C", Offset = "0x195000C", VA = "0x195000C")]
	public button_target()
	{
	}
}
[Token(Token = "0x20000F0")]
public class demo : MonoBehaviour
{
	[Token(Token = "0x60005AD")]
	[Address(RVA = "0x1950014", Offset = "0x1950014", VA = "0x1950014")]
	private void Start()
	{
	}

	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x1950018", Offset = "0x1950018", VA = "0x1950018")]
	private void Update()
	{
	}

	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x195001C", Offset = "0x195001C", VA = "0x195001C")]
	public void GoURL_FX()
	{
	}

	[Token(Token = "0x60005B0")]
	[Address(RVA = "0x1950064", Offset = "0x1950064", VA = "0x1950064")]
	public void GoURL_Free()
	{
	}

	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x19500AC", Offset = "0x19500AC", VA = "0x19500AC")]
	public demo()
	{
	}
}
[Token(Token = "0x20000F1")]
public class tazo_UVScroller : MonoBehaviour
{
	[Token(Token = "0x400065C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int targetMaterialSlot;

	[Token(Token = "0x400065D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Renderer myrender;

	[Token(Token = "0x400065E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speedY;

	[Token(Token = "0x400065F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float speedX;

	[Token(Token = "0x4000660")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float timeWentX;

	[Token(Token = "0x4000661")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float timeWentY;

	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x19500B4", Offset = "0x19500B4", VA = "0x19500B4")]
	private void Start()
	{
	}

	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x1950110", Offset = "0x1950110", VA = "0x1950110")]
	private void Update()
	{
	}

	[Token(Token = "0x60005B4")]
	[Address(RVA = "0x19501B8", Offset = "0x19501B8", VA = "0x19501B8")]
	public tazo_UVScroller()
	{
	}
}
[Token(Token = "0x20000F2")]
public class tazo_UVScroller_r : MonoBehaviour
{
	[Token(Token = "0x4000662")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int targetMaterialSlot;

	[Token(Token = "0x4000663")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Renderer myrender;

	[Token(Token = "0x4000664")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speedY;

	[Token(Token = "0x4000665")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float speedX;

	[Token(Token = "0x4000666")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float timeWentX;

	[Token(Token = "0x4000667")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float timeWentY;

	[Token(Token = "0x60005B5")]
	[Address(RVA = "0x19501C8", Offset = "0x19501C8", VA = "0x19501C8")]
	private void Start()
	{
	}

	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x1950224", Offset = "0x1950224", VA = "0x1950224")]
	private void Update()
	{
	}

	[Token(Token = "0x60005B7")]
	[Address(RVA = "0x1950304", Offset = "0x1950304", VA = "0x1950304")]
	public tazo_UVScroller_r()
	{
	}
}
[Token(Token = "0x20000F3")]
public class Readme : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20000F4")]
	public class Section
	{
		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string heading;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string linkText;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string url;

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x195AC58", Offset = "0x195AC58", VA = "0x195AC58")]
		public Section()
		{
		}
	}

	[Token(Token = "0x4000668")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D icon;

	[Token(Token = "0x4000669")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string title;

	[Token(Token = "0x400066A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Section[] sections;

	[Token(Token = "0x400066B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool loadedLayout;

	[Token(Token = "0x60005B8")]
	[Address(RVA = "0xB7C9C4", Offset = "0xB7C9C4", VA = "0xB7C9C4")]
	public Readme()
	{
	}
}
[Token(Token = "0x20000F5")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x702E9C", Offset = "0x702E9C")]
public class PlayerAgent : MonoBehaviour
{
	[Token(Token = "0x20000F6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702EFC", Offset = "0x702EFC")]
	private sealed class <PushPlayer>d__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isHit;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PlayerAgent <>4__this;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float multiplier;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <t>5__2;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float <totalMove>5__3;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float <maxMove>5__4;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float <dirMagnitude>5__5;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool <maxMoveReach>5__6;

		[Token(Token = "0x1700008B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x195802C", Offset = "0x195802C", VA = "0x195802C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x1958074", Offset = "0x1958074", VA = "0x1958074", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x1957C80", Offset = "0x1957C80", VA = "0x1957C80")]
		[DebuggerHidden]
		public <PushPlayer>d__73(int <>1__state)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1957CAC", Offset = "0x1957CAC", VA = "0x1957CAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1957CB0", Offset = "0x1957CB0", VA = "0x1957CB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x1958034", Offset = "0x1958034", VA = "0x1958034", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000F7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702F0C", Offset = "0x702F0C")]
	private sealed class <DamageOverlay>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerAgent <>4__this;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float damage;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ColorAdjustments <colorAdjusments>5__2;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <t>5__3;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Color <toColor>5__4;

		[Token(Token = "0x1700008D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x195742C", Offset = "0x195742C", VA = "0x195742C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x1957474", Offset = "0x1957474", VA = "0x1957474", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x1957030", Offset = "0x1957030", VA = "0x1957030")]
		[DebuggerHidden]
		public <DamageOverlay>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x195705C", Offset = "0x195705C", VA = "0x195705C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x1957060", Offset = "0x1957060", VA = "0x1957060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x1957434", Offset = "0x1957434", VA = "0x1957434", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702F1C", Offset = "0x702F1C")]
	private sealed class <StunEffect>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerAgent <>4__this;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Bloom <bloom>5__2;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ColorAdjustments <colorAdjusments>5__3;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AudioSource <playerSource>5__4;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <t>5__5;

		[Token(Token = "0x1700008F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x19587B0", Offset = "0x19587B0", VA = "0x19587B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x19587F8", Offset = "0x19587F8", VA = "0x19587F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x1958350", Offset = "0x1958350", VA = "0x1958350")]
		[DebuggerHidden]
		public <StunEffect>d__80(int <>1__state)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x195837C", Offset = "0x195837C", VA = "0x195837C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x1958380", Offset = "0x1958380", VA = "0x1958380", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x19587B8", Offset = "0x19587B8", VA = "0x19587B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000F9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702F2C", Offset = "0x702F2C")]
	private sealed class <KickAnimation>d__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject leg;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject foot;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float startZAxisRotation;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float startYAxisRotation;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float overrotation;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float angularSpeed;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float finalXAxisRotation;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float activationXangle;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public PlayerAgent <>4__this;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool isRightLeg;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float footRotationCorrection;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float forward;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool <secondExtension>5__2;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool <attackActivated>5__3;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float <totalRotation>5__4;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float <multiplyFactor>5__5;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float <footAngleDiference>5__6;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float <footAngleTest>5__7;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float <forwardCorrection>5__8;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool <nextStep>5__9;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		private bool <slaskKick>5__10;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x76")]
		private bool <finished>5__11;

		[Token(Token = "0x17000091")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x1957C30", Offset = "0x1957C30", VA = "0x1957C30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000092")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x1957C78", Offset = "0x1957C78", VA = "0x1957C78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x195747C", Offset = "0x195747C", VA = "0x195747C")]
		[DebuggerHidden]
		public <KickAnimation>d__87(int <>1__state)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x19574A8", Offset = "0x19574A8", VA = "0x19574A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x19574AC", Offset = "0x19574AC", VA = "0x19574AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x1957C38", Offset = "0x1957C38", VA = "0x1957C38", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000FA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702F3C", Offset = "0x702F3C")]
	private sealed class <SpecialKickJump>d__103 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerAgent <>4__this;

		[Token(Token = "0x17000093")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x1958300", Offset = "0x1958300", VA = "0x1958300", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x1958348", Offset = "0x1958348", VA = "0x1958348", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x195807C", Offset = "0x195807C", VA = "0x195807C")]
		[DebuggerHidden]
		public <SpecialKickJump>d__103(int <>1__state)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x19580A8", Offset = "0x19580A8", VA = "0x19580A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x19580AC", Offset = "0x19580AC", VA = "0x19580AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x1958308", Offset = "0x1958308", VA = "0x1958308", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000670")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private PlayerStatus status;

	[Token(Token = "0x4000671")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private InputDevice leftHandTargetDevice;

	[Token(Token = "0x4000672")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private InputDevice rightHandTargetDevice;

	[Token(Token = "0x4000673")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool damageShown;

	[Token(Token = "0x4000674")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool stunShown;

	[Token(Token = "0x4000675")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	private bool finishFadeOut;

	[Token(Token = "0x4000676")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject rig;

	[Token(Token = "0x4000677")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject playerPartialHeadCollider;

	[Token(Token = "0x4000678")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject player;

	[Token(Token = "0x4000679")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private PlayerSpecialManager playerSpecialManager;

	[Token(Token = "0x400067A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject character;

	[Token(Token = "0x400067B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private CharacterAgent characterAgent;

	[Token(Token = "0x400067C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private CharacterStatus characterStatus;

	[Token(Token = "0x400067D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject defenseParticlePrefab;

	[Token(Token = "0x400067E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float combatAreaRadius;

	[Token(Token = "0x400067F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public Color berserkColor;

	[Token(Token = "0x4000680")]
	private const float PUSH_PLAYER_MULTIPLIER = 8f;

	[Token(Token = "0x4000681")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private bool pussed;

	[Token(Token = "0x4000682")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private AudioSource positionSound;

	[Token(Token = "0x4000683")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private AudioSource combatMusicSource;

	[Token(Token = "0x4000684")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private AudioSource playerLeftFootAudio;

	[Token(Token = "0x4000685")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private AudioSource playerLeftFootExtAudio;

	[Token(Token = "0x4000686")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private AudioSource playerRightFootAudio;

	[Token(Token = "0x4000687")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private AudioSource playerRightFootExtAudio;

	[Token(Token = "0x4000688")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private AudioSource rightHandAudioSource;

	[Token(Token = "0x4000689")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private AudioSource leftHandAudioSource;

	[Token(Token = "0x400068A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public AudioClip blockSound;

	[Token(Token = "0x400068B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public AudioClip hitSound;

	[Token(Token = "0x400068C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public AudioClip notAllowedSound;

	[Token(Token = "0x400068D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public AudioClip attackMoveSound;

	[Token(Token = "0x400068E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public AudioClip stunSound;

	[Token(Token = "0x400068F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public AudioClip[] combatMusic;

	[Token(Token = "0x4000690")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private GameObject legs;

	[Token(Token = "0x4000691")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private GameObject leftLeg;

	[Token(Token = "0x4000692")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private GameObject leftFoot;

	[Token(Token = "0x4000693")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private GameObject leftFootExtended;

	[Token(Token = "0x4000694")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private GameObject rightLeg;

	[Token(Token = "0x4000695")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private GameObject rightFoot;

	[Token(Token = "0x4000696")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private GameObject rightFootExtended;

	[Token(Token = "0x4000697")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private Vector3 initialLeftLegPosition;

	[Token(Token = "0x4000698")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	private Vector3 initialRightLegPosition;

	[Token(Token = "0x4000699")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private GameObject playerAttackRightHand;

	[Token(Token = "0x400069A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private GameObject playerAttackLeftHand;

	[Token(Token = "0x400069B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private GameObject playerRightPunchParticles;

	[Token(Token = "0x400069C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private GameObject playerLeftPunchParticles;

	[Token(Token = "0x400069D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private GameObject playerSpecialLeftHand;

	[Token(Token = "0x400069E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private GameObject playerSpecialRightHand;

	[Token(Token = "0x400069F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private Transform rightFootTransform;

	[Token(Token = "0x40006A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private Transform leftFootTransform;

	[Token(Token = "0x40006A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private Transform rightFootExtTransform;

	[Token(Token = "0x40006A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private Transform leftFootExtTransform;

	[Token(Token = "0x40006A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private bool rightPrimaryNeedRelease;

	[Token(Token = "0x40006A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B1")]
	private bool leftPrimaryNeedRelease;

	[Token(Token = "0x40006A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B2")]
	private bool leftHandSoundAttackPlayed;

	[Token(Token = "0x40006A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B3")]
	private bool rightHandSoundAttackPlayed;

	[Token(Token = "0x40006A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	private bool attackSoundActivated;

	[Token(Token = "0x40006A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B5")]
	private bool hitPushCorroutineCalled;

	[Token(Token = "0x40006A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B6")]
	private bool specialKickJumpRunning;

	[Token(Token = "0x40006AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private List<InputDevice> devicesLeft;

	[Token(Token = "0x40006AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private List<InputDevice> devicesRight;

	[Token(Token = "0x40006AC")]
	public const float MIN_ATTACK_SOUND_DISTANCE = 0.25f;

	[Token(Token = "0x40006AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private FrameRateCounterAndDebugInfo debugInfo;

	[Token(Token = "0x40006AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public TutorialController tutorialController;

	[Token(Token = "0x40006AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public ChampionshipControl championshipControl;

	[Token(Token = "0x40006B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public SpecialTutorialController specialTutorialController;

	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x130E4AC", Offset = "0x130E4AC", VA = "0x130E4AC")]
	private void Start()
	{
	}

	[Token(Token = "0x60005BB")]
	[Address(RVA = "0x130F1DC", Offset = "0x130F1DC", VA = "0x130F1DC")]
	private void testPauseTurotial()
	{
	}

	[Token(Token = "0x60005BC")]
	[Address(RVA = "0x130F2E0", Offset = "0x130F2E0", VA = "0x130F2E0")]
	private void Update()
	{
	}

	[Token(Token = "0x60005BD")]
	[Address(RVA = "0x130F130", Offset = "0x130F130", VA = "0x130F130")]
	private void TryToInitializeDevices()
	{
	}

	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x130FAFC", Offset = "0x130FAFC", VA = "0x130FAFC")]
	public void PlayerCollision(PlayerCollisionInfo collisionInfo)
	{
	}

	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x1310AF8", Offset = "0x1310AF8", VA = "0x1310AF8")]
	private void UpdatePlayerAttackStatus(PlayerCollisionInfo collisionInfo)
	{
	}

	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x1310F60", Offset = "0x1310F60", VA = "0x1310F60")]
	public void ApplySpecialDamage(Vector3 direction, float damage)
	{
	}

	[Token(Token = "0x60005C1")]
	[Address(RVA = "0x13109B4", Offset = "0x13109B4", VA = "0x13109B4")]
	private bool IsAttackBlock(PlayerCollisionInfo collisionInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x13106BC", Offset = "0x13106BC", VA = "0x13106BC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x708318", Offset = "0x708318")]
	private IEnumerator PushPlayer(Vector3 direction, float multiplier, bool isHit = true)
	{
		return null;
	}

	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x1311010", Offset = "0x1311010", VA = "0x1311010")]
	public void RoundFinishing()
	{
	}

	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x131101C", Offset = "0x131101C", VA = "0x131101C")]
	public void RoundFinished()
	{
	}

	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x131082C", Offset = "0x131082C", VA = "0x131082C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x708378", Offset = "0x708378")]
	private IEnumerator DamageOverlay(float damage)
	{
		return null;
	}

	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x1311024", Offset = "0x1311024", VA = "0x1311024")]
	public void ActivateBerserkOverlay()
	{
	}

	[Token(Token = "0x60005C7")]
	[Address(RVA = "0x1311148", Offset = "0x1311148", VA = "0x1311148")]
	public void DeactivateBerserkOverlay()
	{
	}

	[Token(Token = "0x60005C8")]
	[Address(RVA = "0x1311294", Offset = "0x1311294", VA = "0x1311294")]
	public void StartStunEffect()
	{
	}

	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x13112F8", Offset = "0x13112F8", VA = "0x13112F8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7083D8", Offset = "0x7083D8")]
	private IEnumerator StunEffect()
	{
		return null;
	}

	[Token(Token = "0x60005CA")]
	[Address(RVA = "0x1311370", Offset = "0x1311370", VA = "0x1311370")]
	public void CheckBoundsAndPositions()
	{
	}

	[Token(Token = "0x60005CB")]
	[Address(RVA = "0x13108F0", Offset = "0x13108F0", VA = "0x13108F0")]
	public void PlayHitSound(PlayerCollisionInfo collisionInfo, bool block)
	{
	}

	[Token(Token = "0x60005CC")]
	[Address(RVA = "0x13118CC", Offset = "0x13118CC", VA = "0x13118CC")]
	public void PlayActionNotAllowed(Vector3 position)
	{
	}

	[Token(Token = "0x60005CD")]
	[Address(RVA = "0x1311978", Offset = "0x1311978", VA = "0x1311978")]
	public void StartLeftLegKickAnimation(int side, int height)
	{
	}

	[Token(Token = "0x60005CE")]
	[Address(RVA = "0x1311F6C", Offset = "0x1311F6C", VA = "0x1311F6C")]
	public void StartRightLegKickAnimation(int side, int height)
	{
	}

	[Token(Token = "0x60005CF")]
	[Address(RVA = "0x1311BBC", Offset = "0x1311BBC", VA = "0x1311BBC")]
	private void RelocateLegs()
	{
	}

	[Token(Token = "0x60005D0")]
	[Address(RVA = "0x1311D6C", Offset = "0x1311D6C", VA = "0x1311D6C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x708438", Offset = "0x708438")]
	private IEnumerator KickAnimation(GameObject leg, GameObject foot, float finalXAxisRotation, float startYAxisRotation, float startZAxisRotation, float activationXangle, float footRotationCorrection, float overrotation, float angularSpeed, float forward, bool isRightLeg)
	{
		return null;
	}

	[Token(Token = "0x60005D1")]
	[Address(RVA = "0x13122B4", Offset = "0x13122B4", VA = "0x13122B4")]
	private void UpdateAttacksStates(bool isRightLeg, PlayerStatus.ATTACK_STATUS attackStatus)
	{
	}

	[Token(Token = "0x60005D2")]
	[Address(RVA = "0x13123D8", Offset = "0x13123D8", VA = "0x13123D8")]
	public void RightHandAttackSound()
	{
	}

	[Token(Token = "0x60005D3")]
	[Address(RVA = "0x1312440", Offset = "0x1312440", VA = "0x1312440")]
	public void LeftHandAttackSound()
	{
	}

	[Token(Token = "0x60005D4")]
	[Address(RVA = "0x13121C0", Offset = "0x13121C0", VA = "0x13121C0")]
	public void RightFootAttackSound()
	{
	}

	[Token(Token = "0x60005D5")]
	[Address(RVA = "0x1311E78", Offset = "0x1311E78", VA = "0x1311E78")]
	public void LeftFootAttackSound()
	{
	}

	[Token(Token = "0x60005D6")]
	[Address(RVA = "0x13124A8", Offset = "0x13124A8", VA = "0x13124A8")]
	public void DeactivateRightHandTrail()
	{
	}

	[Token(Token = "0x60005D7")]
	[Address(RVA = "0x13124C8", Offset = "0x13124C8", VA = "0x13124C8")]
	public void DeactivateLeftHandTrail()
	{
	}

	[Token(Token = "0x60005D8")]
	[Address(RVA = "0x13124E8", Offset = "0x13124E8", VA = "0x13124E8")]
	public void ActivateRightHandTrail(KinematicInstantVelocity partVelocity)
	{
	}

	[Token(Token = "0x60005D9")]
	[Address(RVA = "0x1312680", Offset = "0x1312680", VA = "0x1312680")]
	public void ActivateLeftHandTrail(KinematicInstantVelocity partVelocity)
	{
	}

	[Token(Token = "0x60005DA")]
	[Address(RVA = "0x13108B4", Offset = "0x13108B4", VA = "0x13108B4")]
	public void BothHandsVibration(float intensity, float duration = 0.5f)
	{
	}

	[Token(Token = "0x60005DB")]
	[Address(RVA = "0x13105CC", Offset = "0x13105CC", VA = "0x13105CC")]
	public void LeftHandVibration(float intensity, float duration = 0.5f)
	{
	}

	[Token(Token = "0x60005DC")]
	[Address(RVA = "0x1310644", Offset = "0x1310644", VA = "0x1310644")]
	public void RightHandVibration(float intensity, float duration = 0.5f)
	{
	}

	[Token(Token = "0x60005DD")]
	[Address(RVA = "0x1312750", Offset = "0x1312750", VA = "0x1312750")]
	public void HideSpecialCharging()
	{
	}

	[Token(Token = "0x60005DE")]
	[Address(RVA = "0x13127BC", Offset = "0x13127BC", VA = "0x13127BC")]
	public void ShowSpecialCharging()
	{
	}

	[Token(Token = "0x60005DF")]
	[Address(RVA = "0x1312828", Offset = "0x1312828", VA = "0x1312828")]
	public void StartSpecialKickJump()
	{
	}

	[Token(Token = "0x60005E0")]
	[Address(RVA = "0x1312854", Offset = "0x1312854", VA = "0x1312854")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x708498", Offset = "0x708498")]
	private IEnumerator SpecialKickJump()
	{
		return null;
	}

	[Token(Token = "0x60005E1")]
	[Address(RVA = "0x13128CC", Offset = "0x13128CC", VA = "0x13128CC")]
	public void CompleteSpecialSlash()
	{
	}

	[Token(Token = "0x60005E2")]
	[Address(RVA = "0x1310428", Offset = "0x1310428", VA = "0x1310428")]
	public bool IsCombatStarted()
	{
		return default(bool);
	}

	[Token(Token = "0x60005E3")]
	[Address(RVA = "0x131292C", Offset = "0x131292C", VA = "0x131292C")]
	public PlayerAgent()
	{
	}
}
[Token(Token = "0x20000FB")]
public class PlayerCollisionInfo
{
	[Token(Token = "0x20000FC")]
	public struct HitSource
	{
		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool hand;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public bool elbow;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public bool foot;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public bool knee;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int side;
	}

	[Token(Token = "0x20000FD")]
	public class Location
	{
		[Token(Token = "0x20000FE")]
		public struct ReceiveDamageData
		{
			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int height;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int side;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float multiplier;
		}

		[Token(Token = "0x20000FF")]
		public struct MakeDamageData
		{
			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool hand;

			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool foot;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public bool elbow;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public bool knee;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int side;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float multiplier;
		}

		[Token(Token = "0x2000100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702F4C", Offset = "0x702F4C")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string currentlocation;

			[Token(Token = "0x600061F")]
			[Address(RVA = "0x191DF80", Offset = "0x191DF80", VA = "0x191DF80")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x6000620")]
			[Address(RVA = "0x191DF88", Offset = "0x191DF88", VA = "0x191DF88")]
			internal bool <IsLocation>b__0(string x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] HEAD;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] NECK;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] UPPER_THORAX;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] LOWER_THORAX_CENTER;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] LOWER_THORAX_LEFT;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] LOWER_THORAX_RIGHT;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] ABDOMEN_CENTER;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] ABDOMEN_LEFT;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] ABDOMEN_RIGHT;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] PELVIS_CENTER;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] PELVIS_LEFT;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] PELVIS_RIGHT;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] RIGHT_HAND;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] RIGHT_FOREARM;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] RIGHT_ELBOW;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] RIGHT_UPPERARM;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] LEFT_HAND;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] LEFT_FOREARM;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static string[] LEFT_ELBOW;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static string[] LEFT_UPPERARM;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static string[] RIGHT_THIGH;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static string[] RIGHT_KNEE;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static string[] RIGHT_CALF;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static string[] RIGHT_FOOT;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public static string[] LEFT_THIGH;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public static string[] LEFT_KNEE;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public static string[] LEFT_CALF;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public static string[] LEFT_FOOT;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public static string[] CHIN;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public static string[] NOSE;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public static string[] RIGHT_TEMPLE;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public static string[] LEFT_TEMPLE;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public static string[] LIVER;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public static string[] STOMACH_PIT;

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x1958800", Offset = "0x1958800", VA = "0x1958800")]
		public static MakeDamageData makeDamageMultiplier(string location)
		{
			return default(MakeDamageData);
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x1958CC4", Offset = "0x1958CC4", VA = "0x1958CC4")]
		public static ReceiveDamageData receiveDamageMultiplier(string location)
		{
			return default(ReceiveDamageData);
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x1958BD0", Offset = "0x1958BD0", VA = "0x1958BD0")]
		public static bool IsLocation(string[] locationNames, string currentlocation)
		{
			return default(bool);
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x195946C", Offset = "0x195946C", VA = "0x195946C")]
		public Location()
		{
		}
	}

	[Token(Token = "0x40006E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7053A4", Offset = "0x7053A4")]
	private readonly GameObject <playerPartGameObject>k__BackingField;

	[Token(Token = "0x40006E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7053B4", Offset = "0x7053B4")]
	private readonly GameObject <characterPartGameObject>k__BackingField;

	[Token(Token = "0x40006E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7053C4", Offset = "0x7053C4")]
	private GameObject <playerRootGameObject>k__BackingField;

	[Token(Token = "0x40006E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7053D4", Offset = "0x7053D4")]
	private GameObject <characterRootGameObject>k__BackingField;

	[Token(Token = "0x40006E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7053E4", Offset = "0x7053E4")]
	private readonly Collision <collision>k__BackingField;

	[Token(Token = "0x40006EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7053F4", Offset = "0x7053F4")]
	private readonly string <playerHitLocation>k__BackingField;

	[Token(Token = "0x40006EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705404", Offset = "0x705404")]
	private readonly string <characterHitLocation>k__BackingField;

	[Token(Token = "0x40006EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705414", Offset = "0x705414")]
	private readonly Vector3 <collisionPoint>k__BackingField;

	[Token(Token = "0x40006ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705424", Offset = "0x705424")]
	private readonly float <playerApliedDefense>k__BackingField;

	[Token(Token = "0x40006EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705434", Offset = "0x705434")]
	private readonly float <playerPotentialDamageMultiplier>k__BackingField;

	[Token(Token = "0x40006EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705444", Offset = "0x705444")]
	private readonly float <playerToCharacterDamageMultiplier>k__BackingField;

	[Token(Token = "0x40006F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705454", Offset = "0x705454")]
	private readonly float <characterApliedDefenseMultiplier>k__BackingField;

	[Token(Token = "0x40006F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705464", Offset = "0x705464")]
	private readonly float <characterPotentialDamageMultiplier>k__BackingField;

	[Token(Token = "0x40006F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705474", Offset = "0x705474")]
	private readonly float <characterToPlayerDamageMultiplier>k__BackingField;

	[Token(Token = "0x40006F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705484", Offset = "0x705484")]
	private readonly Vector3 <playerPartVelocity>k__BackingField;

	[Token(Token = "0x40006F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705494", Offset = "0x705494")]
	private readonly Vector3 <characterPartVelocity>k__BackingField;

	[Token(Token = "0x40006F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public int playerCollisionHeight;

	[Token(Token = "0x40006F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public int playerCollisionSide;

	[Token(Token = "0x40006F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public int characterCollisionHeight;

	[Token(Token = "0x40006F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public int characterCollisionSide;

	[Token(Token = "0x40006F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool characterHitFromBack;

	[Token(Token = "0x40006FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
	public bool playerHitFromBack;

	[Token(Token = "0x40006FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public HitSource playerHitSource;

	[Token(Token = "0x40006FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public HitSource characterHitSource;

	[Token(Token = "0x17000095")]
	public GameObject playerPartGameObject
	{
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x1312A20", Offset = "0x1312A20", VA = "0x1312A20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708688", Offset = "0x708688")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000096")]
	public GameObject characterPartGameObject
	{
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x1312A28", Offset = "0x1312A28", VA = "0x1312A28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708698", Offset = "0x708698")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000097")]
	public GameObject playerRootGameObject
	{
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x1312A30", Offset = "0x1312A30", VA = "0x1312A30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7086A8", Offset = "0x7086A8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x1312A38", Offset = "0x1312A38", VA = "0x1312A38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7086B8", Offset = "0x7086B8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000098")]
	public GameObject characterRootGameObject
	{
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x1312A40", Offset = "0x1312A40", VA = "0x1312A40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7086C8", Offset = "0x7086C8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x1312A48", Offset = "0x1312A48", VA = "0x1312A48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7086D8", Offset = "0x7086D8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000099")]
	public Collision collision
	{
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x1312A50", Offset = "0x1312A50", VA = "0x1312A50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7086E8", Offset = "0x7086E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009A")]
	public string playerHitLocation
	{
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x1312A58", Offset = "0x1312A58", VA = "0x1312A58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7086F8", Offset = "0x7086F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009B")]
	public string characterHitLocation
	{
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x1312A60", Offset = "0x1312A60", VA = "0x1312A60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708708", Offset = "0x708708")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009C")]
	public Vector3 collisionPoint
	{
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x1312A68", Offset = "0x1312A68", VA = "0x1312A68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708718", Offset = "0x708718")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700009D")]
	public float playerApliedDefense
	{
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x1312A74", Offset = "0x1312A74", VA = "0x1312A74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708728", Offset = "0x708728")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700009E")]
	public float playerPotentialDamageMultiplier
	{
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x1312A7C", Offset = "0x1312A7C", VA = "0x1312A7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708738", Offset = "0x708738")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700009F")]
	public float playerToCharacterDamageMultiplier
	{
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x1312A84", Offset = "0x1312A84", VA = "0x1312A84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708748", Offset = "0x708748")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170000A0")]
	public float characterApliedDefenseMultiplier
	{
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x1312A8C", Offset = "0x1312A8C", VA = "0x1312A8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708758", Offset = "0x708758")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170000A1")]
	public float characterPotentialDamageMultiplier
	{
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x1312A94", Offset = "0x1312A94", VA = "0x1312A94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708768", Offset = "0x708768")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170000A2")]
	public float characterToPlayerDamageMultiplier
	{
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x1312A9C", Offset = "0x1312A9C", VA = "0x1312A9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708778", Offset = "0x708778")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170000A3")]
	public Vector3 playerPartVelocity
	{
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x1312AA4", Offset = "0x1312AA4", VA = "0x1312AA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708788", Offset = "0x708788")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170000A4")]
	public Vector3 characterPartVelocity
	{
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x1312AB0", Offset = "0x1312AB0", VA = "0x1312AB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708798", Offset = "0x708798")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000614")]
	[Address(RVA = "0x1312ABC", Offset = "0x1312ABC", VA = "0x1312ABC")]
	public PlayerCollisionInfo(GameObject playerGameObject, Collision col, PlayerStatus playerStatus)
	{
	}

	[Token(Token = "0x6000615")]
	[Address(RVA = "0x131364C", Offset = "0x131364C", VA = "0x131364C")]
	private int correctSide(GameObject receiver, Vector3 giverVelocity, int collisionSide)
	{
		return default(int);
	}

	[Token(Token = "0x6000616")]
	[Address(RVA = "0x13138A8", Offset = "0x13138A8", VA = "0x13138A8")]
	private float angleMultiplier(Vector3 hitVelocity, Vector3 bestDirectionPlayer)
	{
		return default(float);
	}

	[Token(Token = "0x6000617")]
	[Address(RVA = "0x131335C", Offset = "0x131335C", VA = "0x131335C")]
	private Vector3 calculateCenter(Collision collision)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000618")]
	[Address(RVA = "0x13138EC", Offset = "0x13138EC", VA = "0x13138EC")]
	private Vector3 getColliderCenter(Collider collider)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000619")]
	[Address(RVA = "0x1313170", Offset = "0x1313170", VA = "0x1313170")]
	private GameObject GetRoot(GameObject collidedObject)
	{
		return null;
	}
}
[Token(Token = "0x2000101")]
public class PlayerCollisionsManager : MonoBehaviour
{
	[Token(Token = "0x400072E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private PlayerAgent playerAgent;

	[Token(Token = "0x400072F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private PlayerStatus playerStatus;

	[Token(Token = "0x4000730")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject playerHead;

	[Token(Token = "0x4000731")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material ActiveMaterial;

	[Token(Token = "0x4000732")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Material UnactiveMaterial;

	[Token(Token = "0x4000733")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SkinnedMeshRenderer partMesh;

	[Token(Token = "0x4000734")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject berserkParticles;

	[Token(Token = "0x4000735")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private HashSet<GameObject> collidedObjects;

	[Token(Token = "0x6000621")]
	[Address(RVA = "0x1313B80", Offset = "0x1313B80", VA = "0x1313B80")]
	private void Start()
	{
	}

	[Token(Token = "0x6000622")]
	[Address(RVA = "0x1313D18", Offset = "0x1313D18", VA = "0x1313D18")]
	public void Update()
	{
	}

	[Token(Token = "0x6000623")]
	[Address(RVA = "0x13140C4", Offset = "0x13140C4", VA = "0x13140C4")]
	public void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000624")]
	[Address(RVA = "0x13142B0", Offset = "0x13142B0", VA = "0x13142B0")]
	public void OnCollisionExit(Collision collision)
	{
	}

	[Token(Token = "0x6000625")]
	[Address(RVA = "0x1314328", Offset = "0x1314328", VA = "0x1314328")]
	private void OnUserPresenceLost()
	{
	}

	[Token(Token = "0x6000626")]
	[Address(RVA = "0x1314384", Offset = "0x1314384", VA = "0x1314384")]
	public PlayerCollisionsManager()
	{
	}
}
[Token(Token = "0x2000102")]
public class PlayerSpecialManager : MonoBehaviour
{
	[Token(Token = "0x2000103")]
	public enum HandPositionType
	{
		[Token(Token = "0x4000754")]
		ANY,
		[Token(Token = "0x4000755")]
		BACK,
		[Token(Token = "0x4000756")]
		FRONT
	}

	[Token(Token = "0x2000104")]
	public enum HandSideType
	{
		[Token(Token = "0x4000758")]
		ANY,
		[Token(Token = "0x4000759")]
		LEFT,
		[Token(Token = "0x400075A")]
		RIGHT
	}

	[Token(Token = "0x2000105")]
	public enum HandHeightType
	{
		[Token(Token = "0x400075C")]
		ANY,
		[Token(Token = "0x400075D")]
		UP,
		[Token(Token = "0x400075E")]
		DOWN,
		[Token(Token = "0x400075F")]
		FLOOR
	}

	[Token(Token = "0x2000106")]
	public enum HandStateType
	{
		[Token(Token = "0x4000761")]
		ANY,
		[Token(Token = "0x4000762")]
		OPEN,
		[Token(Token = "0x4000763")]
		CLOSED
	}

	[Token(Token = "0x2000107")]
	public enum TriggerStateType
	{
		[Token(Token = "0x4000765")]
		ANY,
		[Token(Token = "0x4000766")]
		PRESSED,
		[Token(Token = "0x4000767")]
		RELEASED
	}

	[Token(Token = "0x2000108")]
	public enum HandsTogetherType
	{
		[Token(Token = "0x4000769")]
		ANY,
		[Token(Token = "0x400076A")]
		TOGETHER,
		[Token(Token = "0x400076B")]
		SEPARATE
	}

	[Token(Token = "0x2000109")]
	public enum SpecialDirectionType
	{
		[Token(Token = "0x400076D")]
		LEFT_HAND,
		[Token(Token = "0x400076E")]
		RIGHT_HAND,
		[Token(Token = "0x400076F")]
		BOTH_HANDS,
		[Token(Token = "0x4000770")]
		VIEW_LEFT_HAND,
		[Token(Token = "0x4000771")]
		VIEW_RIGHT_HAND,
		[Token(Token = "0x4000772")]
		VIEW_BOTH_HANDS,
		[Token(Token = "0x4000773")]
		VIEW
	}

	[Token(Token = "0x200010A")]
	public enum SpecialAttachment
	{
		[Token(Token = "0x4000775")]
		NONE,
		[Token(Token = "0x4000776")]
		BODY,
		[Token(Token = "0x4000777")]
		HEAD,
		[Token(Token = "0x4000778")]
		KICK
	}

	[Token(Token = "0x200010B")]
	public struct PlayerSpecialHandCondition
	{
		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public HandPositionType position;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public HandSideType side;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public HandHeightType height;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public HandStateType state;

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x195AC4C", Offset = "0x195AC4C", VA = "0x195AC4C")]
		public PlayerSpecialHandCondition(HandPositionType position, HandSideType side, HandHeightType height, HandStateType state = HandStateType.ANY)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x195A92C", Offset = "0x195A92C", VA = "0x195A92C")]
		public bool CheckHandCondition(PlayerSpecialHandCondition currentHandCondition, bool checkState = true)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200010C")]
	public struct PlayerSpecialCondition
	{
		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PlayerSpecialHandCondition rightHandCondition;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PlayerSpecialHandCondition leftHandCondition;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandsTogetherType handsTogether;

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x195A8A4", Offset = "0x195A8A4", VA = "0x195A8A4")]
		public PlayerSpecialCondition(PlayerSpecialHandCondition rightHandCondition, PlayerSpecialHandCondition leftHandCondition, HandsTogetherType handsTogether)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x195A8B4", Offset = "0x195A8B4", VA = "0x195A8B4")]
		public bool CheckConditions(PlayerSpecialCondition currentCondition, bool checkState = true)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200010D")]
	public struct PlayerSpecialDescription
	{
		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7054A4", Offset = "0x7054A4")]
		private int <specialId>k__BackingField;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7054B4", Offset = "0x7054B4")]
		private string <prefabName>k__BackingField;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7054C4", Offset = "0x7054C4")]
		private PlayerSpecialCondition <initCondition>k__BackingField;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7054D4", Offset = "0x7054D4")]
		private PlayerSpecialCondition <finishCondition>k__BackingField;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7054E4", Offset = "0x7054E4")]
		private float <maxLifetime>k__BackingField;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7054F4", Offset = "0x7054F4")]
		private SpecialAttachment <attachment>k__BackingField;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705504", Offset = "0x705504")]
		private SpecialDirectionType <direction>k__BackingField;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705514", Offset = "0x705514")]
		private TriggerStateType <leftHandTriggerFinish>k__BackingField;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705524", Offset = "0x705524")]
		private TriggerStateType <rightHandTriggerFinish>k__BackingField;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705534", Offset = "0x705534")]
		private bool <floored>k__BackingField;

		[Token(Token = "0x170000A5")]
		public int specialId
		{
			[Token(Token = "0x6000638")]
			[Address(RVA = "0x195A988", Offset = "0x195A988", VA = "0x195A988")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708808", Offset = "0x708808")]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x195A990", Offset = "0x195A990", VA = "0x195A990")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708840", Offset = "0x708840")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public string prefabName
		{
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x195A998", Offset = "0x195A998", VA = "0x195A998")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708850", Offset = "0x708850")]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x195A9A0", Offset = "0x195A9A0", VA = "0x195A9A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708888", Offset = "0x708888")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public PlayerSpecialCondition initCondition
		{
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x195A9A8", Offset = "0x195A9A8", VA = "0x195A9A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708898", Offset = "0x708898")]
			readonly get
			{
				return default(PlayerSpecialCondition);
			}
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x195A9BC", Offset = "0x195A9BC", VA = "0x195A9BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7088D0", Offset = "0x7088D0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public PlayerSpecialCondition finishCondition
		{
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x195A9D0", Offset = "0x195A9D0", VA = "0x195A9D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7088E0", Offset = "0x7088E0")]
			readonly get
			{
				return default(PlayerSpecialCondition);
			}
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x195A9E8", Offset = "0x195A9E8", VA = "0x195A9E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708918", Offset = "0x708918")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public float maxLifetime
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x195AA00", Offset = "0x195AA00", VA = "0x195AA00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708928", Offset = "0x708928")]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x195AA08", Offset = "0x195AA08", VA = "0x195AA08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708960", Offset = "0x708960")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public SpecialAttachment attachment
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x195AA10", Offset = "0x195AA10", VA = "0x195AA10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708970", Offset = "0x708970")]
			readonly get
			{
				return default(SpecialAttachment);
			}
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x195AA18", Offset = "0x195AA18", VA = "0x195AA18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7089A8", Offset = "0x7089A8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public SpecialDirectionType direction
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x195AA20", Offset = "0x195AA20", VA = "0x195AA20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7089B8", Offset = "0x7089B8")]
			readonly get
			{
				return default(SpecialDirectionType);
			}
			[Token(Token = "0x6000645")]
			[Address(RVA = "0x195AA28", Offset = "0x195AA28", VA = "0x195AA28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7089F0", Offset = "0x7089F0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public TriggerStateType leftHandTriggerFinish
		{
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x195AA30", Offset = "0x195AA30", VA = "0x195AA30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708A00", Offset = "0x708A00")]
			readonly get
			{
				return default(TriggerStateType);
			}
			[Token(Token = "0x6000647")]
			[Address(RVA = "0x195AA38", Offset = "0x195AA38", VA = "0x195AA38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708A38", Offset = "0x708A38")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public TriggerStateType rightHandTriggerFinish
		{
			[Token(Token = "0x6000648")]
			[Address(RVA = "0x195AA40", Offset = "0x195AA40", VA = "0x195AA40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708A48", Offset = "0x708A48")]
			readonly get
			{
				return default(TriggerStateType);
			}
			[Token(Token = "0x6000649")]
			[Address(RVA = "0x195AA48", Offset = "0x195AA48", VA = "0x195AA48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708A80", Offset = "0x708A80")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public bool floored
		{
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x195AA50", Offset = "0x195AA50", VA = "0x195AA50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708A90", Offset = "0x708A90")]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x600064B")]
			[Address(RVA = "0x195AA58", Offset = "0x195AA58", VA = "0x195AA58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708AC8", Offset = "0x708AC8")]
			private set
			{
			}
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x195AA64", Offset = "0x195AA64", VA = "0x195AA64")]
		public PlayerSpecialDescription(int specialId, string prefabName, PlayerSpecialCondition initCondition, PlayerSpecialCondition finishCondition, TriggerStateType rightHandTriggerFinish, TriggerStateType leftHandTriggerFinish, float maxLifetime, SpecialAttachment attachment = SpecialAttachment.NONE, SpecialDirectionType direction = SpecialDirectionType.BOTH_HANDS, bool floored = false)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x195AB08", Offset = "0x195AB08", VA = "0x195AB08")]
		public bool CheckInitCondition(PlayerSpecialCondition currentCondition)
		{
			return default(bool);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x195AB54", Offset = "0x195AB54", VA = "0x195AB54")]
		public bool CheckFinishCondition(PlayerSpecialCondition currentCondition, bool rightTrigger, bool leftTrigger, SpecialTutorialController specialTutorial)
		{
			return default(bool);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x195AC04", Offset = "0x195AC04", VA = "0x195AC04")]
		private bool CheckFinishTriggers(bool rightTrigger, bool leftTrigger)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200010E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702F5C", Offset = "0x702F5C")]
	private sealed class <resetTutorial>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerSpecialManager <>4__this;

		[Token(Token = "0x170000AF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x195A854", Offset = "0x195A854", VA = "0x195A854", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000655")]
			[Address(RVA = "0x195A89C", Offset = "0x195A89C", VA = "0x195A89C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x195A728", Offset = "0x195A728", VA = "0x195A728")]
		[DebuggerHidden]
		public <resetTutorial>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x195A754", Offset = "0x195A754", VA = "0x195A754", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x195A758", Offset = "0x195A758", VA = "0x195A758", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x195A85C", Offset = "0x195A85C", VA = "0x195A85C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000736")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SpecialTutorialController specialTutorial;

	[Token(Token = "0x4000737")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ChampionshipControl championshipControl;

	[Token(Token = "0x4000738")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float triggerSensitivity;

	[Token(Token = "0x4000739")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float backPlaneDist;

	[Token(Token = "0x400073A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float floorDist;

	[Token(Token = "0x400073B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float maxSpellCastTime;

	[Token(Token = "0x400073C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float maxFinishCastTime;

	[Token(Token = "0x400073D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float maxHandsTogetherDistance;

	[Token(Token = "0x400073E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float maxHandsTogetherDistanceSqr;

	[Token(Token = "0x400073F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private bool castStarted;

	[Token(Token = "0x4000740")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float currentCastTime;

	[Token(Token = "0x4000741")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Vector3 rightStartPosition;

	[Token(Token = "0x4000742")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 leftStartPosition;

	[Token(Token = "0x4000743")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Plane BackPlanePosition;

	[Token(Token = "0x4000744")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private bool waitingCastFinish;

	[Token(Token = "0x4000745")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float currentCastFinishTime;

	[Token(Token = "0x4000746")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private InputDevice leftDevice;

	[Token(Token = "0x4000747")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private InputDevice rightDevice;

	[Token(Token = "0x4000748")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private GameObject leftHand;

	[Token(Token = "0x4000749")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private GameObject rightHand;

	[Token(Token = "0x400074A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private GameObject playerHead;

	[Token(Token = "0x400074B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private PlayerStatus playerStatus;

	[Token(Token = "0x400074C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private PlayerAgent playerAgent;

	[Token(Token = "0x400074D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool leftTrigger;

	[Token(Token = "0x400074E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	private bool rightTrigger;

	[Token(Token = "0x400074F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private PlayerSpecialCondition handsCondition;

	[Token(Token = "0x4000750")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool noManaPlayed;

	[Token(Token = "0x4000751")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private List<PlayerSpecialDescription> playerSpecials;

	[Token(Token = "0x4000752")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private List<PlayerSpecialDescription> possibleSpecials;

	[Token(Token = "0x6000627")]
	[Address(RVA = "0x13144F0", Offset = "0x13144F0", VA = "0x13144F0")]
	private void TryToInitializeDevices()
	{
	}

	[Token(Token = "0x6000628")]
	[Address(RVA = "0x13145EC", Offset = "0x13145EC", VA = "0x13145EC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000629")]
	[Address(RVA = "0x1314730", Offset = "0x1314730", VA = "0x1314730")]
	private void Update()
	{
	}

	[Token(Token = "0x600062A")]
	[Address(RVA = "0x1314CBC", Offset = "0x1314CBC", VA = "0x1314CBC")]
	private void ReadTriggers()
	{
	}

	[Token(Token = "0x600062B")]
	[Address(RVA = "0x1314878", Offset = "0x1314878", VA = "0x1314878")]
	private void ReadPositions()
	{
	}

	[Token(Token = "0x600062C")]
	[Address(RVA = "0x1314E60", Offset = "0x1314E60", VA = "0x1314E60")]
	private void RecheckCast()
	{
	}

	[Token(Token = "0x600062D")]
	[Address(RVA = "0x1314EE4", Offset = "0x1314EE4", VA = "0x1314EE4")]
	public void AbortCast()
	{
	}

	[Token(Token = "0x600062E")]
	[Address(RVA = "0x13154F0", Offset = "0x13154F0", VA = "0x13154F0")]
	private void CheckCastStart()
	{
	}

	[Token(Token = "0x600062F")]
	[Address(RVA = "0x1314FA8", Offset = "0x1314FA8", VA = "0x1314FA8")]
	private void CheckCastFinish()
	{
	}

	[Token(Token = "0x6000630")]
	[Address(RVA = "0x1315ED4", Offset = "0x1315ED4", VA = "0x1315ED4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7087A8", Offset = "0x7087A8")]
	private IEnumerator resetTutorial()
	{
		return null;
	}

	[Token(Token = "0x6000631")]
	[Address(RVA = "0x1315F4C", Offset = "0x1315F4C", VA = "0x1315F4C")]
	public void AddSpecial(PlayerSpecialDescription special)
	{
	}

	[Token(Token = "0x6000632")]
	[Address(RVA = "0x1315FE4", Offset = "0x1315FE4", VA = "0x1315FE4")]
	public void EmptySpecials()
	{
	}

	[Token(Token = "0x6000633")]
	[Address(RVA = "0x131604C", Offset = "0x131604C", VA = "0x131604C")]
	public PlayerSpecialManager()
	{
	}
}
[Token(Token = "0x200010F")]
public class PlayerStatus : MonoBehaviour
{
	[Token(Token = "0x2000110")]
	public enum ATTACK_STATUS
	{
		[Token(Token = "0x40007C7")]
		NOT_ACTIVE,
		[Token(Token = "0x40007C8")]
		STARTED,
		[Token(Token = "0x40007C9")]
		COMPLETED
	}

	[Token(Token = "0x2000111")]
	public enum PART_TYPE
	{
		[Token(Token = "0x40007CB")]
		PlayerLeftHand = 0,
		[Token(Token = "0x40007CC")]
		PlayerRightHand = 1,
		[Token(Token = "0x40007CD")]
		PlayerLeftElbow = 2,
		[Token(Token = "0x40007CE")]
		PlayerRightElbow = 3,
		[Token(Token = "0x40007CF")]
		PlayerLeftFoot = 4,
		[Token(Token = "0x40007D0")]
		PlayerRightFoot = 5,
		[Token(Token = "0x40007D1")]
		PlayerLeftKnee = 6,
		[Token(Token = "0x40007D2")]
		PlayerRightKnee = 7,
		[Token(Token = "0x40007D3")]
		Other = -1
	}

	[Token(Token = "0x400078D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705544", Offset = "0x705544")]
	private float <height>k__BackingField;

	[Token(Token = "0x400078E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float health;

	[Token(Token = "0x400078F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705554", Offset = "0x705554")]
	private float <stamina>k__BackingField;

	[Token(Token = "0x4000790")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float staminaRecovery;

	[Token(Token = "0x4000791")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float mana;

	[Token(Token = "0x4000792")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float manaRecovery;

	[Token(Token = "0x4000793")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float stunFactor;

	[Token(Token = "0x4000794")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float stunRecovery;

	[Token(Token = "0x4000795")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705564", Offset = "0x705564")]
	private float <stunDamageMultiplier>k__BackingField;

	[Token(Token = "0x4000796")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705574", Offset = "0x705574")]
	private bool <stunActive>k__BackingField;

	[Token(Token = "0x4000797")]
	private const float STUN_ACTIVATION_FACTOR = 10f;

	[Token(Token = "0x4000798")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float initialHealth;

	[Token(Token = "0x4000799")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float maxMana;

	[Token(Token = "0x400079A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float initialStamina;

	[Token(Token = "0x400079B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Texture2D texture;

	[Token(Token = "0x400079C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Texture2D textureFullBody;

	[Token(Token = "0x400079D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GameObject playerHeadPosition;

	[Token(Token = "0x400079E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject playerLeftHand;

	[Token(Token = "0x400079F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private GameObject playerRightHand;

	[Token(Token = "0x40007A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private GameObject rig;

	[Token(Token = "0x40007A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private PlayerAgent agent;

	[Token(Token = "0x40007A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private PlayerSpecialManager playerSpecialManager;

	[Token(Token = "0x40007A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Quaternion createSpecialInitialRotation;

	[Token(Token = "0x40007A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector3 createSpecialInitialPosition;

	[Token(Token = "0x40007A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private PlayerSpecialManager.PlayerSpecialDescription createSpecialInfo;

	[Token(Token = "0x40007A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private GameObject bodySpecialAttachment;

	[Token(Token = "0x40007A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private GameObject kickSpecialAttachment;

	[Token(Token = "0x40007A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private GameObject[] leftHandBerserkParticles;

	[Token(Token = "0x40007A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private GameObject[] rightHandBerserkParticles;

	[Token(Token = "0x40007AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public GameObject specialExecuteParticles;

	[Token(Token = "0x40007AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private GameObject lastSpecialInstace;

	[Token(Token = "0x40007AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public List<int> specialsIds;

	[Token(Token = "0x40007AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public bool kickAttackActive;

	[Token(Token = "0x40007AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
	public bool kickRetireActive;

	[Token(Token = "0x40007AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15A")]
	private bool rightKickLeg;

	[Token(Token = "0x40007B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15B")]
	private bool canSlashWithKick;

	[Token(Token = "0x40007B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705584", Offset = "0x705584")]
	private bool <slashingForward>k__BackingField;

	[Token(Token = "0x40007B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705594", Offset = "0x705594")]
	private bool <slashingOther>k__BackingField;

	[Token(Token = "0x40007B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7055A4", Offset = "0x7055A4")]
	private bool <berserkActive>k__BackingField;

	[Token(Token = "0x40007B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7055B4", Offset = "0x7055B4")]
	private bool <specialKickActive>k__BackingField;

	[Token(Token = "0x40007B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public bool playerMoving;

	[Token(Token = "0x40007B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x161")]
	private bool leftGrabActive;

	[Token(Token = "0x40007B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x162")]
	private bool rightGrabActive;

	[Token(Token = "0x40007B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private ATTACK_STATUS[] attackStatus;

	[Token(Token = "0x40007B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private Vector3[] attackActivationPosition;

	[Token(Token = "0x40007BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private float[] part_attack_damage;

	[Token(Token = "0x40007BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private List<float>[] lastsVelocities;

	[Token(Token = "0x40007BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float INITIAL_MIN_VELOCITY;

	[Token(Token = "0x40007BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float[] MAX_VELOCITY_PERCENTILES;

	[Token(Token = "0x40007BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private float[] minVelocity;

	[Token(Token = "0x40007BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private float[] maxVelocity;

	[Token(Token = "0x40007C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private int maxTrackedVelocities;

	[Token(Token = "0x40007C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	private float min_headheight_for_kick;

	[Token(Token = "0x40007C2")]
	private const float KICK_ATTACK_STAMINA = 1f;

	[Token(Token = "0x40007C3")]
	private const float SLASH_STAMINA = 1f;

	[Token(Token = "0x40007C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public bool berserckObjectsInitialized;

	[Token(Token = "0x40007C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A1")]
	public bool statusPanelInitialized;

	[Token(Token = "0x170000B1")]
	public float height
	{
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x131611C", Offset = "0x131611C", VA = "0x131611C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708B28", Offset = "0x708B28")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x1316124", Offset = "0x1316124", VA = "0x1316124")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708B38", Offset = "0x708B38")]
		private set
		{
		}
	}

	[Token(Token = "0x170000B2")]
	public float stamina
	{
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x131612C", Offset = "0x131612C", VA = "0x131612C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708B48", Offset = "0x708B48")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x1316134", Offset = "0x1316134", VA = "0x1316134")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708B58", Offset = "0x708B58")]
		private set
		{
		}
	}

	[Token(Token = "0x170000B3")]
	public float stunDamageMultiplier
	{
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x131613C", Offset = "0x131613C", VA = "0x131613C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708B68", Offset = "0x708B68")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x1316144", Offset = "0x1316144", VA = "0x1316144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708B78", Offset = "0x708B78")]
		private set
		{
		}
	}

	[Token(Token = "0x170000B4")]
	public bool stunActive
	{
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x131614C", Offset = "0x131614C", VA = "0x131614C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708B88", Offset = "0x708B88")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x1316154", Offset = "0x1316154", VA = "0x1316154")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708B98", Offset = "0x708B98")]
		private set
		{
		}
	}

	[Token(Token = "0x170000B5")]
	public bool slashingForward
	{
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x1316160", Offset = "0x1316160", VA = "0x1316160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708BA8", Offset = "0x708BA8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x1316168", Offset = "0x1316168", VA = "0x1316168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708BB8", Offset = "0x708BB8")]
		private set
		{
		}
	}

	[Token(Token = "0x170000B6")]
	public bool slashingOther
	{
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x1316174", Offset = "0x1316174", VA = "0x1316174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708BC8", Offset = "0x708BC8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x131617C", Offset = "0x131617C", VA = "0x131617C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708BD8", Offset = "0x708BD8")]
		private set
		{
		}
	}

	[Token(Token = "0x170000B7")]
	public bool berserkActive
	{
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x1316188", Offset = "0x1316188", VA = "0x1316188")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708BE8", Offset = "0x708BE8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1316190", Offset = "0x1316190", VA = "0x1316190")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708BF8", Offset = "0x708BF8")]
		private set
		{
		}
	}

	[Token(Token = "0x170000B8")]
	public bool specialKickActive
	{
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x131619C", Offset = "0x131619C", VA = "0x131619C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708C08", Offset = "0x708C08")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000665")]
		[Address(RVA = "0x13161A4", Offset = "0x13161A4", VA = "0x13161A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708C18", Offset = "0x708C18")]
		private set
		{
		}
	}

	[Token(Token = "0x6000666")]
	[Address(RVA = "0x13161B0", Offset = "0x13161B0", VA = "0x13161B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000667")]
	[Address(RVA = "0x13165EC", Offset = "0x13165EC", VA = "0x13165EC")]
	private void InitBerserkObjects()
	{
	}

	[Token(Token = "0x6000668")]
	[Address(RVA = "0x1318394", Offset = "0x1318394", VA = "0x1318394")]
	public void UpdatePlayerSpecials()
	{
	}

	[Token(Token = "0x6000669")]
	[Address(RVA = "0x13166C0", Offset = "0x13166C0", VA = "0x13166C0")]
	private void AddPlayerSpecials()
	{
	}

	[Token(Token = "0x600066A")]
	[Address(RVA = "0x13183C4", Offset = "0x13183C4", VA = "0x13183C4")]
	private void Update()
	{
	}

	[Token(Token = "0x600066B")]
	[Address(RVA = "0x131868C", Offset = "0x131868C", VA = "0x131868C")]
	public void ResetStatus()
	{
	}

	[Token(Token = "0x600066C")]
	[Address(RVA = "0x13186D4", Offset = "0x13186D4", VA = "0x13186D4")]
	public void SaveStatus()
	{
	}

	[Token(Token = "0x600066D")]
	[Address(RVA = "0x131828C", Offset = "0x131828C", VA = "0x131828C")]
	private void RestoreStatus()
	{
	}

	[Token(Token = "0x600066E")]
	[Address(RVA = "0x13188D8", Offset = "0x13188D8", VA = "0x13188D8")]
	public void IncreaseMana(float damage)
	{
	}

	[Token(Token = "0x600066F")]
	[Address(RVA = "0x1310770", Offset = "0x1310770", VA = "0x1310770")]
	public void ApplyDamage(float damage)
	{
	}

	[Token(Token = "0x6000670")]
	[Address(RVA = "0x1318918", Offset = "0x1318918", VA = "0x1318918")]
	public void StunReset()
	{
	}

	[Token(Token = "0x6000671")]
	[Address(RVA = "0x1310D94", Offset = "0x1310D94", VA = "0x1310D94")]
	public void UpdateAttackState(PART_TYPE part, ATTACK_STATUS status, Vector3 position)
	{
	}

	[Token(Token = "0x6000672")]
	[Address(RVA = "0x130F708", Offset = "0x130F708", VA = "0x130F708")]
	public void PrimaryButtonPressed(InputDevice device)
	{
	}

	[Token(Token = "0x6000673")]
	[Address(RVA = "0x130F6F4", Offset = "0x130F6F4", VA = "0x130F6F4")]
	public void UpdateGrabTriggersState(bool rightState, bool leftState)
	{
	}

	[Token(Token = "0x6000674")]
	[Address(RVA = "0x131056C", Offset = "0x131056C", VA = "0x131056C")]
	public ATTACK_STATUS GetAttackState(PART_TYPE part)
	{
		return default(ATTACK_STATUS);
	}

	[Token(Token = "0x6000675")]
	[Address(RVA = "0x13125B4", Offset = "0x13125B4", VA = "0x13125B4")]
	public float GetAttackDistance(PART_TYPE part, Vector3 position)
	{
		return default(float);
	}

	[Token(Token = "0x6000676")]
	[Address(RVA = "0x1318924", Offset = "0x1318924", VA = "0x1318924")]
	public float GetAttackBaseDamage(PlayerCollisionInfo.HitSource source)
	{
		return default(float);
	}

	[Token(Token = "0x6000677")]
	[Address(RVA = "0x131899C", Offset = "0x131899C", VA = "0x131899C")]
	public float GetAttackBaseDamage(PART_TYPE part)
	{
		return default(float);
	}

	[Token(Token = "0x6000678")]
	[Address(RVA = "0x1310D04", Offset = "0x1310D04", VA = "0x1310D04")]
	public static PART_TYPE GetPart(PlayerCollisionInfo.HitSource hitsource)
	{
		return default(PART_TYPE);
	}

	[Token(Token = "0x6000679")]
	[Address(RVA = "0x1313494", Offset = "0x1313494", VA = "0x1313494")]
	public void RegisterSpeed(PlayerCollisionInfo.HitSource source, Vector3 speed)
	{
	}

	[Token(Token = "0x600067A")]
	[Address(RVA = "0x13189F4", Offset = "0x13189F4", VA = "0x13189F4")]
	public void RegisterSpeed(PART_TYPE part, Vector3 speed)
	{
	}

	[Token(Token = "0x600067B")]
	[Address(RVA = "0x1313534", Offset = "0x1313534", VA = "0x1313534")]
	public Vector3 NormalizeVelocity(PlayerCollisionInfo.HitSource source, Vector3 velocity)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600067C")]
	[Address(RVA = "0x1318E50", Offset = "0x1318E50", VA = "0x1318E50")]
	public Vector3 NormalizeVelocity(PART_TYPE part, Vector3 velocity)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600067D")]
	[Address(RVA = "0x13135D4", Offset = "0x13135D4", VA = "0x13135D4")]
	public float MaxVelocity(PlayerCollisionInfo.HitSource source)
	{
		return default(float);
	}

	[Token(Token = "0x600067E")]
	[Address(RVA = "0x1318F5C", Offset = "0x1318F5C", VA = "0x1318F5C")]
	public float MaxVelocity(PART_TYPE part)
	{
		return default(float);
	}

	[Token(Token = "0x600067F")]
	[Address(RVA = "0x1318FA4", Offset = "0x1318FA4", VA = "0x1318FA4")]
	public float MinVelocity(PlayerCollisionInfo.HitSource source)
	{
		return default(float);
	}

	[Token(Token = "0x6000680")]
	[Address(RVA = "0x131901C", Offset = "0x131901C", VA = "0x131901C")]
	public float MinVelocity(PART_TYPE part)
	{
		return default(float);
	}

	[Token(Token = "0x6000681")]
	[Address(RVA = "0x1318CF4", Offset = "0x1318CF4", VA = "0x1318CF4")]
	public static float GetPercentile(List<float> sortedSource, float percentile)
	{
		return default(float);
	}

	[Token(Token = "0x6000682")]
	[Address(RVA = "0x1311138", Offset = "0x1311138", VA = "0x1311138")]
	public float GetHealthNormalized()
	{
		return default(float);
	}

	[Token(Token = "0x6000683")]
	[Address(RVA = "0x1319064", Offset = "0x1319064", VA = "0x1319064")]
	public bool StartSlash(bool forward)
	{
		return default(bool);
	}

	[Token(Token = "0x6000684")]
	[Address(RVA = "0x13186CC", Offset = "0x13186CC", VA = "0x13186CC")]
	public void FinishSlash()
	{
	}

	[Token(Token = "0x6000685")]
	[Address(RVA = "0x1315968", Offset = "0x1315968", VA = "0x1315968")]
	public bool CanStartSpecial()
	{
		return default(bool);
	}

	[Token(Token = "0x6000686")]
	[Address(RVA = "0x13159CC", Offset = "0x13159CC", VA = "0x13159CC")]
	public void ExecuteSpecial(PlayerSpecialManager.PlayerSpecialDescription specialInfo, Vector3 rightInitPosition, Vector3 rightFinishPosition, Vector3 leftInitPosition, Vector3 leftFinishPosition)
	{
	}

	[Token(Token = "0x6000687")]
	[Address(RVA = "0x1319210", Offset = "0x1319210", VA = "0x1319210")]
	private void createSpecial()
	{
	}

	[Token(Token = "0x6000688")]
	[Address(RVA = "0x1319428", Offset = "0x1319428", VA = "0x1319428")]
	public void abortSpecialCasts()
	{
	}

	[Token(Token = "0x6000689")]
	[Address(RVA = "0x1319440", Offset = "0x1319440", VA = "0x1319440")]
	public void activateBerserk()
	{
	}

	[Token(Token = "0x600068A")]
	[Address(RVA = "0x1318358", Offset = "0x1318358", VA = "0x1318358")]
	public void deactivateBerserk(bool resetStamina = true)
	{
	}

	[Token(Token = "0x600068B")]
	[Address(RVA = "0x1319460", Offset = "0x1319460", VA = "0x1319460")]
	private void activateBerserkParticles()
	{
	}

	[Token(Token = "0x600068C")]
	[Address(RVA = "0x131952C", Offset = "0x131952C", VA = "0x131952C")]
	private void deactivateBerserkParticles()
	{
	}

	[Token(Token = "0x600068D")]
	[Address(RVA = "0x1314418", Offset = "0x1314418", VA = "0x1314418")]
	public void startKickSpecial()
	{
	}

	[Token(Token = "0x600068E")]
	[Address(RVA = "0x13195F8", Offset = "0x13195F8", VA = "0x13195F8")]
	public void finishKickSpecial()
	{
	}

	[Token(Token = "0x600068F")]
	[Address(RVA = "0x1319600", Offset = "0x1319600", VA = "0x1319600")]
	public PlayerStatus()
	{
	}
}
[Token(Token = "0x2000112")]
public class FrameRateCounterAndDebugInfo : MonoBehaviour
{
	[Token(Token = "0x40007D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI fpsDisplay;

	[Token(Token = "0x40007D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI averageFPSDisplay;

	[Token(Token = "0x40007D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI minFPSDisplay;

	[Token(Token = "0x40007D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI maxFPSDisplay;

	[Token(Token = "0x40007D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI debugInfoDisplay;

	[Token(Token = "0x40007D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI debugInfoDisplay2;

	[Token(Token = "0x40007DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string debugInfo;

	[Token(Token = "0x40007DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string debugInfo2;

	[Token(Token = "0x40007DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int framesPassed;

	[Token(Token = "0x40007DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int prevMinUpdate;

	[Token(Token = "0x40007DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float fpsTotal;

	[Token(Token = "0x40007DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float fps;

	[Token(Token = "0x40007E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float minFPS;

	[Token(Token = "0x40007E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float maxFPS;

	[Token(Token = "0x40007E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float deltaTime;

	[Token(Token = "0x6000691")]
	[Address(RVA = "0xB077D4", Offset = "0xB077D4", VA = "0xB077D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000692")]
	[Address(RVA = "0xB07824", Offset = "0xB07824", VA = "0xB07824")]
	private void UpdateFrameRate()
	{
	}

	[Token(Token = "0x6000693")]
	[Address(RVA = "0xB078A0", Offset = "0xB078A0", VA = "0xB078A0")]
	public void setDebugInfo(string info)
	{
	}

	[Token(Token = "0x6000694")]
	[Address(RVA = "0xB078A8", Offset = "0xB078A8", VA = "0xB078A8")]
	public void setDebugInfo2(string info)
	{
	}

	[Token(Token = "0x6000695")]
	[Address(RVA = "0xB078B0", Offset = "0xB078B0", VA = "0xB078B0")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000696")]
	[Address(RVA = "0xB07AEC", Offset = "0xB07AEC", VA = "0xB07AEC")]
	public FrameRateCounterAndDebugInfo()
	{
	}
}
[Token(Token = "0x2000113")]
public class BodyFollowHead : MonoBehaviour
{
	[Token(Token = "0x40007E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject player;

	[Token(Token = "0x40007E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject body;

	[Token(Token = "0x40007E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 offset;

	[Token(Token = "0x6000697")]
	[Address(RVA = "0xCD89C4", Offset = "0xCD89C4", VA = "0xCD89C4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000698")]
	[Address(RVA = "0xCD8AC4", Offset = "0xCD8AC4", VA = "0xCD8AC4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000699")]
	[Address(RVA = "0xCD8BE8", Offset = "0xCD8BE8", VA = "0xCD8BE8")]
	public BodyFollowHead()
	{
	}
}
[Token(Token = "0x2000114")]
public class CharacterFollowHeadSet : MonoBehaviour
{
	[Token(Token = "0x40007E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CharacterController character;

	[Token(Token = "0x40007E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private SphereCollider headCollider;

	[Token(Token = "0x40007E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private XROrigin rig;

	[Token(Token = "0x40007E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public LocomotionSystem system;

	[Token(Token = "0x40007EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float additionalHeight;

	[Token(Token = "0x40007EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool headColliding;

	[Token(Token = "0x40007EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private InputDevice leftDevice;

	[Token(Token = "0x40007ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private InputDevice rightDevice;

	[Token(Token = "0x600069A")]
	[Address(RVA = "0x15A7EF0", Offset = "0x15A7EF0", VA = "0x15A7EF0")]
	private void Start()
	{
	}

	[Token(Token = "0x600069B")]
	[Address(RVA = "0x15A80FC", Offset = "0x15A80FC", VA = "0x15A80FC")]
	private void Update()
	{
	}

	[Token(Token = "0x600069C")]
	[Address(RVA = "0x15A81F4", Offset = "0x15A81F4", VA = "0x15A81F4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600069D")]
	[Address(RVA = "0x15A7F14", Offset = "0x15A7F14", VA = "0x15A7F14")]
	private void FindCharacterController()
	{
	}

	[Token(Token = "0x600069E")]
	[Address(RVA = "0x15A8000", Offset = "0x15A8000", VA = "0x15A8000")]
	private void TryToInitializeDevices()
	{
	}

	[Token(Token = "0x600069F")]
	[Address(RVA = "0x15A82E4", Offset = "0x15A82E4", VA = "0x15A82E4")]
	private void CapsuleFollowhead()
	{
	}

	[Token(Token = "0x60006A0")]
	[Address(RVA = "0x15A8478", Offset = "0x15A8478", VA = "0x15A8478")]
	private bool CheckSticksMovement()
	{
		return default(bool);
	}

	[Token(Token = "0x60006A1")]
	[Address(RVA = "0x15A8528", Offset = "0x15A8528", VA = "0x15A8528")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60006A2")]
	[Address(RVA = "0x15A874C", Offset = "0x15A874C", VA = "0x15A874C")]
	private void OnCollisionStay(Collision collision)
	{
	}

	[Token(Token = "0x60006A3")]
	[Address(RVA = "0x15A852C", Offset = "0x15A852C", VA = "0x15A852C")]
	private void UpdateCollisionPositions(Collision collision)
	{
	}

	[Token(Token = "0x60006A4")]
	[Address(RVA = "0x15A8750", Offset = "0x15A8750", VA = "0x15A8750")]
	private void OnCollisionExit(Collision collision)
	{
	}

	[Token(Token = "0x60006A5")]
	[Address(RVA = "0x15A8758", Offset = "0x15A8758", VA = "0x15A8758")]
	public CharacterFollowHeadSet()
	{
	}
}
[Token(Token = "0x2000115")]
public class ContinuousMoveControl : MonoBehaviour
{
	[Token(Token = "0x2000116")]
	public enum MOVE_STICK
	{
		[Token(Token = "0x4000806")]
		leftPrimary2DAxis,
		[Token(Token = "0x4000807")]
		rightPrimary2DAxis
	}

	[Token(Token = "0x2000117")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702F6C", Offset = "0x702F6C")]
	private sealed class <SlashMove>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ContinuousMoveControl <>4__this;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 speed;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <t>5__2;

		[Token(Token = "0x170000BC")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x19528E0", Offset = "0x19528E0", VA = "0x19528E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x1952928", Offset = "0x1952928", VA = "0x1952928", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x19526DC", Offset = "0x19526DC", VA = "0x19526DC")]
		[DebuggerHidden]
		public <SlashMove>d__40(int <>1__state)
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x1952708", Offset = "0x1952708", VA = "0x1952708", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x195270C", Offset = "0x195270C", VA = "0x195270C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x19528E8", Offset = "0x19528E8", VA = "0x19528E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float slashSpeed;

	[Token(Token = "0x40007EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float specialKickSpeed;

	[Token(Token = "0x40007F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float slashDuration;

	[Token(Token = "0x40007F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float forwardSpeed;

	[Token(Token = "0x40007F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float backwardSpeed;

	[Token(Token = "0x40007F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float sidewardSpeed;

	[Token(Token = "0x40007F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float minAxisValue;

	[Token(Token = "0x40007F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float minSlashAxisValue;

	[Token(Token = "0x40007F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool slashing;

	[Token(Token = "0x40007F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool needReleaseSlashStick;

	[Token(Token = "0x40007F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private FrameRateCounterAndDebugInfo debugInfo;

	[Token(Token = "0x40007F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public MOVE_STICK moveContoller;

	[Token(Token = "0x40007FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private InputDevice moveTargetDevice;

	[Token(Token = "0x40007FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private InputDevice slashTargetDevice;

	[Token(Token = "0x40007FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private InputDeviceCharacteristics moveControllerharacteristics;

	[Token(Token = "0x40007FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private InputDeviceCharacteristics slashControllerharacteristics;

	[Token(Token = "0x40007FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7055C4", Offset = "0x7055C4")]
	private bool <blockMove>k__BackingField;

	[Token(Token = "0x40007FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7055D4", Offset = "0x7055D4")]
	private bool <blockForwardSlash>k__BackingField;

	[Token(Token = "0x4000800")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7055E4", Offset = "0x7055E4")]
	private Vector3 <currentSpeed>k__BackingField;

	[Token(Token = "0x4000801")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameObject VRRig;

	[Token(Token = "0x4000802")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private GameObject Player;

	[Token(Token = "0x4000803")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private PlayerStatus playerStatus;

	[Token(Token = "0x4000804")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool stopSlash;

	[Token(Token = "0x170000B9")]
	public bool blockMove
	{
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xAFE110", Offset = "0xAFE110", VA = "0xAFE110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708C28", Offset = "0x708C28")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xAFE118", Offset = "0xAFE118", VA = "0xAFE118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708C38", Offset = "0x708C38")]
		private set
		{
		}
	}

	[Token(Token = "0x170000BA")]
	private bool blockForwardSlash
	{
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xAFE124", Offset = "0xAFE124", VA = "0xAFE124")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708C48", Offset = "0x708C48")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xAFE12C", Offset = "0xAFE12C", VA = "0xAFE12C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708C58", Offset = "0x708C58")]
		set
		{
		}
	}

	[Token(Token = "0x170000BB")]
	public Vector3 currentSpeed
	{
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xAFE138", Offset = "0xAFE138", VA = "0xAFE138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708C68", Offset = "0x708C68")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xAFE144", Offset = "0xAFE144", VA = "0xAFE144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708C78", Offset = "0x708C78")]
		private set
		{
		}
	}

	[Token(Token = "0x60006AC")]
	[Address(RVA = "0xAFE150", Offset = "0xAFE150", VA = "0xAFE150")]
	private void Start()
	{
	}

	[Token(Token = "0x60006AD")]
	[Address(RVA = "0xAFE3E0", Offset = "0xAFE3E0", VA = "0xAFE3E0")]
	public void SetMoveController(MOVE_STICK stick)
	{
	}

	[Token(Token = "0x60006AE")]
	[Address(RVA = "0xAFE2E4", Offset = "0xAFE2E4", VA = "0xAFE2E4")]
	private void TryToInitialize()
	{
	}

	[Token(Token = "0x60006AF")]
	[Address(RVA = "0xAFE3F0", Offset = "0xAFE3F0", VA = "0xAFE3F0")]
	private void Update()
	{
	}

	[Token(Token = "0x60006B0")]
	[Address(RVA = "0xAFE740", Offset = "0xAFE740", VA = "0xAFE740")]
	private bool applyContinuousMove()
	{
		return default(bool);
	}

	[Token(Token = "0x60006B1")]
	[Address(RVA = "0xAFE498", Offset = "0xAFE498", VA = "0xAFE498")]
	private void CheckSlashStickReleased()
	{
	}

	[Token(Token = "0x60006B2")]
	[Address(RVA = "0xAFE54C", Offset = "0xAFE54C", VA = "0xAFE54C")]
	private bool checkSlashMove()
	{
		return default(bool);
	}

	[Token(Token = "0x60006B3")]
	[Address(RVA = "0xAFE960", Offset = "0xAFE960", VA = "0xAFE960")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x708C88", Offset = "0x708C88")]
	private IEnumerator SlashMove(Vector3 speed)
	{
		return null;
	}

	[Token(Token = "0x60006B4")]
	[Address(RVA = "0xAFE9FC", Offset = "0xAFE9FC", VA = "0xAFE9FC")]
	public void StopCurrentSlash()
	{
	}

	[Token(Token = "0x60006B5")]
	[Address(RVA = "0xAFEA08", Offset = "0xAFEA08", VA = "0xAFEA08")]
	public void BlockAllMove()
	{
	}

	[Token(Token = "0x60006B6")]
	[Address(RVA = "0xAFEA14", Offset = "0xAFEA14", VA = "0xAFEA14")]
	public void BlockMove()
	{
	}

	[Token(Token = "0x60006B7")]
	[Address(RVA = "0xAFEA20", Offset = "0xAFEA20", VA = "0xAFEA20")]
	public void UnblockAllMove()
	{
	}

	[Token(Token = "0x60006B8")]
	[Address(RVA = "0xAFEA28", Offset = "0xAFEA28", VA = "0xAFEA28")]
	public void StartKickSpecial()
	{
	}

	[Token(Token = "0x60006B9")]
	[Address(RVA = "0xAFEB20", Offset = "0xAFEB20", VA = "0xAFEB20")]
	public ContinuousMoveControl()
	{
	}
}
[Token(Token = "0x2000118")]
public class HandPresence : MonoBehaviour
{
	[Token(Token = "0x400080D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InputDeviceCharacteristics controllerharacteristics;

	[Token(Token = "0x400080E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject handModelPrefab;

	[Token(Token = "0x400080F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject collisionHandModelPrefab;

	[Token(Token = "0x4000810")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private InputDevice targetDevice;

	[Token(Token = "0x4000811")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject spawnedHand;

	[Token(Token = "0x4000812")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject collisionHand;

	[Token(Token = "0x4000813")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject player;

	[Token(Token = "0x4000814")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private PlayerStatus pStatus;

	[Token(Token = "0x4000815")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Animator handAnimator;

	[Token(Token = "0x4000816")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Animator collisionHandAnimator;

	[Token(Token = "0x4000817")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool collisionHandActive;

	[Token(Token = "0x4000818")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private Vector3 collisionPosition;

	[Token(Token = "0x4000819")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float collisionRadius;

	[Token(Token = "0x400081A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<GameObject> HandStatus;

	[Token(Token = "0x400081B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool retryPresenceLost;

	[Token(Token = "0x400081C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	private bool retryPresenceRestored;

	[Token(Token = "0x400081D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
	private bool mainScene;

	[Token(Token = "0x60006C0")]
	[Address(RVA = "0xC0CD14", Offset = "0xC0CD14", VA = "0xC0CD14")]
	private void Start()
	{
	}

	[Token(Token = "0x60006C1")]
	[Address(RVA = "0xC0CE14", Offset = "0xC0CE14", VA = "0xC0CE14")]
	private void TryToInitialize()
	{
	}

	[Token(Token = "0x60006C2")]
	[Address(RVA = "0xC0D410", Offset = "0xC0D410", VA = "0xC0D410")]
	private void UpdateHandAnimation()
	{
	}

	[Token(Token = "0x60006C3")]
	[Address(RVA = "0xC0D5CC", Offset = "0xC0D5CC", VA = "0xC0D5CC")]
	private void Update()
	{
	}

	[Token(Token = "0x60006C4")]
	[Address(RVA = "0xC0D640", Offset = "0xC0D640", VA = "0xC0D640")]
	private void UpdateCollisionHand()
	{
	}

	[Token(Token = "0x60006C5")]
	[Address(RVA = "0xC0D9E0", Offset = "0xC0D9E0", VA = "0xC0D9E0")]
	private void OnUserPresenceLost()
	{
	}

	[Token(Token = "0x60006C6")]
	[Address(RVA = "0xC0DBD8", Offset = "0xC0DBD8", VA = "0xC0DBD8")]
	private void OnUserPresenceRestored()
	{
	}

	[Token(Token = "0x60006C7")]
	[Address(RVA = "0xC0DDD0", Offset = "0xC0DDD0", VA = "0xC0DDD0")]
	public void ActivateCollisionHand()
	{
	}

	[Token(Token = "0x60006C8")]
	[Address(RVA = "0xC0DFB0", Offset = "0xC0DFB0", VA = "0xC0DFB0")]
	public void DeactivateCollisionHand()
	{
	}

	[Token(Token = "0x60006C9")]
	[Address(RVA = "0xC0E0E4", Offset = "0xC0E0E4", VA = "0xC0E0E4")]
	public HandPresence()
	{
	}
}
[Token(Token = "0x2000119")]
public class UserPresence : MonoBehaviour
{
	[Token(Token = "0x400081E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private InputDevice HDMDevice;

	[Token(Token = "0x400081F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool previouslyPresent;

	[Token(Token = "0x4000820")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	private static bool currentlyPresent;

	[Token(Token = "0x4000821")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	private static bool focus;

	[Token(Token = "0x4000822")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
	private static bool paused;

	[Token(Token = "0x4000823")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static float initialFixedDeltaTime;

	[Token(Token = "0x4000824")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static List<AudioSource> pausedAudios;

	[Token(Token = "0x4000825")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static UnityEvent UserPresenceRestoredEvent;

	[Token(Token = "0x4000826")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static UnityEvent UserPresenceLostEvent;

	[Token(Token = "0x4000827")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool eventListenersInitialized;

	[Token(Token = "0x4000828")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static FrameRateCounterAndDebugInfo debugInfo;

	[Token(Token = "0x60006CA")]
	[Address(RVA = "0x194D388", Offset = "0x194D388", VA = "0x194D388")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006CB")]
	[Address(RVA = "0x194D520", Offset = "0x194D520", VA = "0x194D520")]
	private void Start()
	{
	}

	[Token(Token = "0x60006CC")]
	[Address(RVA = "0x194D5F0", Offset = "0x194D5F0", VA = "0x194D5F0")]
	private void TryToInitialize()
	{
	}

	[Token(Token = "0x60006CD")]
	[Address(RVA = "0x194D774", Offset = "0x194D774", VA = "0x194D774")]
	private void Update()
	{
	}

	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x194DD6C", Offset = "0x194DD6C", VA = "0x194DD6C")]
	public static bool CanPauseGame()
	{
		return default(bool);
	}

	[Token(Token = "0x60006CF")]
	[Address(RVA = "0x194A938", Offset = "0x194A938", VA = "0x194A938")]
	public static bool PauseGame()
	{
		return default(bool);
	}

	[Token(Token = "0x60006D0")]
	[Address(RVA = "0x194DE04", Offset = "0x194DE04", VA = "0x194DE04")]
	public static bool CanResume()
	{
		return default(bool);
	}

	[Token(Token = "0x60006D1")]
	[Address(RVA = "0x194AC64", Offset = "0x194AC64", VA = "0x194AC64")]
	public static bool ResumeGame()
	{
		return default(bool);
	}

	[Token(Token = "0x60006D2")]
	[Address(RVA = "0x194DEC0", Offset = "0x194DEC0", VA = "0x194DEC0")]
	public static void ResetPauseValues()
	{
	}

	[Token(Token = "0x60006D3")]
	[Address(RVA = "0x194E0D4", Offset = "0x194E0D4", VA = "0x194E0D4")]
	private void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x60006D4")]
	[Address(RVA = "0x194E240", Offset = "0x194E240", VA = "0x194E240")]
	private void OculusFocusLost()
	{
	}

	[Token(Token = "0x60006D5")]
	[Address(RVA = "0x194E248", Offset = "0x194E248", VA = "0x194E248")]
	private void OculusFocusAquired()
	{
	}

	[Token(Token = "0x60006D6")]
	[Address(RVA = "0x1949734", Offset = "0x1949734", VA = "0x1949734")]
	public static void AddUserPresenceRestoredListener(UnityAction call)
	{
	}

	[Token(Token = "0x60006D7")]
	[Address(RVA = "0x194E250", Offset = "0x194E250", VA = "0x194E250")]
	public static void RemovePresenceRestoredListener(UnityAction call)
	{
	}

	[Token(Token = "0x60006D8")]
	[Address(RVA = "0x19496BC", Offset = "0x19496BC", VA = "0x19496BC")]
	public static void AddUserPresenceLostListener(UnityAction call)
	{
	}

	[Token(Token = "0x60006D9")]
	[Address(RVA = "0x194E2C8", Offset = "0x194E2C8", VA = "0x194E2C8")]
	public static void RemovePresenceLostListener(UnityAction call)
	{
	}

	[Token(Token = "0x60006DA")]
	[Address(RVA = "0x194DA5C", Offset = "0x194DA5C", VA = "0x194DA5C")]
	private static void PausePlayingAudios()
	{
	}

	[Token(Token = "0x60006DB")]
	[Address(RVA = "0x194DBE0", Offset = "0x194DBE0", VA = "0x194DBE0")]
	private static void RestorePlayingAudios()
	{
	}

	[Token(Token = "0x60006DC")]
	[Address(RVA = "0x194DF48", Offset = "0x194DF48", VA = "0x194DF48")]
	private static void ResetPlayingAudios()
	{
	}

	[Token(Token = "0x60006DD")]
	[Address(RVA = "0x194E340", Offset = "0x194E340", VA = "0x194E340")]
	public static bool IsUserPresent()
	{
		return default(bool);
	}

	[Token(Token = "0x60006DE")]
	[Address(RVA = "0x194E3A4", Offset = "0x194E3A4", VA = "0x194E3A4")]
	public static bool IsFocus()
	{
		return default(bool);
	}

	[Token(Token = "0x60006DF")]
	[Address(RVA = "0x194E408", Offset = "0x194E408", VA = "0x194E408")]
	public UserPresence()
	{
	}
}
namespace UnityTemplateProjects
{
	[Token(Token = "0x200011A")]
	public class SimpleCameraController : MonoBehaviour
	{
		[Token(Token = "0x200011B")]
		private class CameraState
		{
			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x4000834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x4000835")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x195AC60", Offset = "0x195AC60", VA = "0x195AC60")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x195ACE8", Offset = "0x195ACE8", VA = "0x195ACE8")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x195AD64", Offset = "0x195AD64", VA = "0x195AD64")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x195AE2C", Offset = "0x195AE2C", VA = "0x195AE2C")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x195AE78", Offset = "0x195AE78", VA = "0x195AE78")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7055F4", Offset = "0x7055F4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7055F4", Offset = "0x7055F4")]
		public float boost;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x705654", Offset = "0x705654")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x705654", Offset = "0x705654")]
		public float positionLerpTime;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7056AC", Offset = "0x7056AC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7056AC", Offset = "0x7056AC")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x70570C", Offset = "0x70570C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x70570C", Offset = "0x70570C")]
		public float rotationLerpTime;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x705764", Offset = "0x705764")]
		public bool invertY;

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xB7E208", Offset = "0xB7E208", VA = "0xB7E208")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xB7E268", Offset = "0xB7E268", VA = "0xB7E268")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xB7E37C", Offset = "0xB7E37C", VA = "0xB7E37C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xB7E5E0", Offset = "0xB7E5E0", VA = "0xB7E5E0")]
		public SimpleCameraController()
		{
		}
	}
}
namespace OculusSampleFramework
{
	[Token(Token = "0x200011C")]
	public class ColorGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color COLOR_GRAB;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Color COLOR_HIGHLIGHT;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color m_color;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshRenderer[] m_meshRenderers;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_highlight;

		[Token(Token = "0x170000BE")]
		public bool Highlight
		{
			[Token(Token = "0x60006EA")]
			[Address(RVA = "0xAF7018", Offset = "0xAF7018", VA = "0xAF7018")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006EB")]
			[Address(RVA = "0xAF7020", Offset = "0xAF7020", VA = "0xAF7020")]
			set
			{
			}
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xAF702C", Offset = "0xAF702C", VA = "0xAF702C")]
		protected void UpdateColor()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xAF71F4", Offset = "0xAF71F4", VA = "0xAF71F4", Slot = "4")]
		public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xAF721C", Offset = "0xAF721C", VA = "0xAF721C", Slot = "5")]
		public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xAF7244", Offset = "0xAF7244", VA = "0xAF7244")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xAF70F4", Offset = "0xAF70F4", VA = "0xAF70F4")]
		private void SetColor(Color color)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xAF7518", Offset = "0xAF7518", VA = "0xAF7518")]
		public ColorGrabbable()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class DistanceGrabbable : OVRGrabbable
	{
		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_materialColorField;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GrabbableCrosshair m_crosshair;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GrabManager m_crosshairManager;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer m_renderer;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MaterialPropertyBlock m_mpb;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_inRange;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_targeted;

		[Token(Token = "0x170000BF")]
		public bool InRange
		{
			[Token(Token = "0x60006F3")]
			[Address(RVA = "0xB025A4", Offset = "0xB025A4", VA = "0xB025A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006F4")]
			[Address(RVA = "0xB025AC", Offset = "0xB025AC", VA = "0xB025AC")]
			set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public bool Targeted
		{
			[Token(Token = "0x60006F5")]
			[Address(RVA = "0xB02724", Offset = "0xB02724", VA = "0xB02724")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006F6")]
			[Address(RVA = "0xB0272C", Offset = "0xB0272C", VA = "0xB0272C")]
			set
			{
			}
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xB02738", Offset = "0xB02738", VA = "0xB02738", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xB025B8", Offset = "0xB025B8", VA = "0xB025B8")]
		private void RefreshCrosshair()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xB02940", Offset = "0xB02940", VA = "0xB02940")]
		public DistanceGrabbable()
		{
		}
	}
	[Token(Token = "0x200011E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x702F7C", Offset = "0x702F7C")]
	public class DistanceGrabber : OVRGrabber
	{
		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float m_spherecastRadius;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float m_noSnapThreshhold;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool m_useSpherecast;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		public bool m_preventGrabThroughWalls;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float m_objectPullVelocity;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float m_objectPullMaxRotationRate;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_movingObjectToHand;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float m_maxGrabDistance;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int m_grabObjectsInLayer;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private int m_obstructionLayer;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private DistanceGrabber m_otherHand;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected DistanceGrabbable m_target;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected Collider m_targetCollider;

		[Token(Token = "0x170000C1")]
		public bool UseSpherecast
		{
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0xB02948", Offset = "0xB02948", VA = "0xB02948")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0xB02950", Offset = "0xB02950", VA = "0xB02950")]
			set
			{
			}
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xB0296C", Offset = "0xB0296C", VA = "0xB0296C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xB02BAC", Offset = "0xB02BAC", VA = "0xB02BAC", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xB034C4", Offset = "0xB034C4", VA = "0xB034C4", Slot = "7")]
		protected override void GrabBegin()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xB03958", Offset = "0xB03958", VA = "0xB03958", Slot = "8")]
		protected override void MoveGrabbedObject(Vector3 pos, Quaternion rot, bool forceTeleport = false)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xB03C18", Offset = "0xB03C18", VA = "0xB03C18")]
		private static DistanceGrabbable HitInfoToGrabbable(RaycastHit hitInfo)
		{
			return null;
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xB02E20", Offset = "0xB02E20", VA = "0xB02E20")]
		protected bool FindTarget(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xB03D08", Offset = "0xB03D08", VA = "0xB03D08")]
		protected bool FindTargetWithSpherecast(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xB04164", Offset = "0xB04164", VA = "0xB04164", Slot = "9")]
		protected override void GrabVolumeEnable(bool enabled)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xB0417C", Offset = "0xB0417C", VA = "0xB0417C", Slot = "10")]
		protected override void OffhandGrabbed(OVRGrabbable grabbable)
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xB04184", Offset = "0xB04184", VA = "0xB04184")]
		public DistanceGrabber()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class GrabManager : MonoBehaviour
	{
		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider m_grabVolume;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color OutlineColorInRange;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color OutlineColorHighlighted;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color OutlineColorOutOfRange;

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xB0848C", Offset = "0xB0848C", VA = "0xB0848C")]
		private void OnTriggerEnter(Collider otherCollider)
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xB08544", Offset = "0xB08544", VA = "0xB08544")]
		private void OnTriggerExit(Collider otherCollider)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xB085F8", Offset = "0xB085F8", VA = "0xB085F8")]
		public GrabManager()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class GrabbableCrosshair : MonoBehaviour
	{
		[Token(Token = "0x2000121")]
		public enum CrosshairState
		{
			[Token(Token = "0x4000858")]
			Disabled,
			[Token(Token = "0x4000859")]
			Enabled,
			[Token(Token = "0x400085A")]
			Targeted
		}

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CrosshairState m_state;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_centerEyeAnchor;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_targetedCrosshair;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_enabledCrosshair;

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xB086B8", Offset = "0xB086B8", VA = "0xB086B8")]
		private void Start()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xB028A4", Offset = "0xB028A4", VA = "0xB028A4")]
		public void SetState(CrosshairState cs)
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xB08724", Offset = "0xB08724", VA = "0xB08724")]
		private void Update()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xB0876C", Offset = "0xB0876C", VA = "0xB0876C")]
		public GrabbableCrosshair()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class PauseOnInputLoss : MonoBehaviour
	{
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x130E040", Offset = "0x130E040", VA = "0x130E040")]
		private void Start()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x130E12C", Offset = "0x130E12C", VA = "0x130E12C")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x130E138", Offset = "0x130E138", VA = "0x130E138")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x130E144", Offset = "0x130E144", VA = "0x130E144")]
		public PauseOnInputLoss()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class BoneCapsuleTriggerLogic : MonoBehaviour
	{
		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableToolTags ToolTags;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HashSet<ColliderZone> CollidersTouchingUs;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ColliderZone> _elementsToCleanUp;

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xCD8BF0", Offset = "0xCD8BF0", VA = "0xCD8BF0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xCD8C44", Offset = "0xCD8C44", VA = "0xCD8C44")]
		private void Update()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xCD8FB0", Offset = "0xCD8FB0", VA = "0xCD8FB0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xCD90B4", Offset = "0xCD90B4", VA = "0xCD90B4")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xCD8C48", Offset = "0xCD8C48", VA = "0xCD8C48")]
		private void CleanUpDeadColliders()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xCD91B8", Offset = "0xCD91B8", VA = "0xCD91B8")]
		public BoneCapsuleTriggerLogic()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class ButtonController : Interactable
	{
		[Token(Token = "0x2000125")]
		public enum ContactTest
		{
			[Token(Token = "0x400086D")]
			PerpenTest,
			[Token(Token = "0x400086E")]
			BackwardsPress
		}

		[Token(Token = "0x400085E")]
		private const float ENTRY_DOT_THRESHOLD = 0.8f;

		[Token(Token = "0x400085F")]
		private const float PERP_DOT_THRESHOLD = 0.5f;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _proximityZone;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _contactZone;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _actionZone;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ContactTest[] _contactTests;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _buttonPlaneCenter;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _makeSureToolIsOnPositiveSide;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector3 _localButtonDirection;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InteractableToolTags[] _allValidToolsTags;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _toolTagsMask;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool _allowMultipleNearFieldInteraction;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7058CC", Offset = "0x7058CC")]
		private InteractableState <CurrentButtonState>k__BackingField;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<InteractableTool, InteractableState> _toolToState;

		[Token(Token = "0x170000C2")]
		public override int ValidToolTagsMask
		{
			[Token(Token = "0x6000717")]
			[Address(RVA = "0xCDA800", Offset = "0xCDA800", VA = "0xCDA800", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C3")]
		public Vector3 LocalButtonDirection
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0xCDA808", Offset = "0xCDA808", VA = "0xCDA808")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000C4")]
		public InteractableState CurrentButtonState
		{
			[Token(Token = "0x6000719")]
			[Address(RVA = "0xCDA814", Offset = "0xCDA814", VA = "0xCDA814")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708D38", Offset = "0x708D38")]
			get
			{
				return default(InteractableState);
			}
			[Token(Token = "0x600071A")]
			[Address(RVA = "0xCDA81C", Offset = "0xCDA81C", VA = "0xCDA81C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708D48", Offset = "0x708D48")]
			private set
			{
			}
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xCDA824", Offset = "0xCDA824", VA = "0xCDA824", Slot = "9")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xCDA938", Offset = "0xCDA938", VA = "0xCDA938")]
		private void FireInteractionEventsOnDepth(InteractableCollisionDepth oldDepth, InteractableTool collidingTool, InteractionType interactionType)
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xCDAAA4", Offset = "0xCDAAA4", VA = "0xCDAAA4", Slot = "8")]
		public override void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth)
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xCDB05C", Offset = "0xCDB05C", VA = "0xCDB05C")]
		private InteractableState GetUpcomingStateNearField(InteractableState oldState, InteractableCollisionDepth newCollisionDepth, bool toolIsInActionZone, bool toolIsInContactZone, bool toolIsInProximity, bool validContact, bool onPositiveSideOfInteractable)
		{
			return default(InteractableState);
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xCDB108", Offset = "0xCDB108", VA = "0xCDB108")]
		public void ForceResetButton()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xCDAF74", Offset = "0xCDAF74", VA = "0xCDAF74")]
		private bool IsValidContact(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xCDB214", Offset = "0xCDB214", VA = "0xCDB214")]
		private bool PassEntryTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xCDB298", Offset = "0xCDB298", VA = "0xCDB298")]
		private bool PassPerpTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xCDB324", Offset = "0xCDB324", VA = "0xCDB324")]
		public ButtonController()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class ButtonTriggerZone : MonoBehaviour, ColliderZone
	{
		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _parentInteractableObj;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7058EC", Offset = "0x7058EC")]
		private Collider <Collider>k__BackingField;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7058FC", Offset = "0x7058FC")]
		private Interactable <ParentInteractable>k__BackingField;

		[Token(Token = "0x170000C5")]
		public Collider Collider
		{
			[Token(Token = "0x6000724")]
			[Address(RVA = "0xCDB570", Offset = "0xCDB570", VA = "0xCDB570", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708D58", Offset = "0x708D58")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000725")]
			[Address(RVA = "0xCDB578", Offset = "0xCDB578", VA = "0xCDB578")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708D68", Offset = "0x708D68")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public Interactable ParentInteractable
		{
			[Token(Token = "0x6000726")]
			[Address(RVA = "0xCDB580", Offset = "0xCDB580", VA = "0xCDB580", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708D78", Offset = "0x708D78")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000727")]
			[Address(RVA = "0xCDB588", Offset = "0xCDB588", VA = "0xCDB588")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708D88", Offset = "0x708D88")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x6000728")]
			[Address(RVA = "0xCDB590", Offset = "0xCDB590", VA = "0xCDB590", Slot = "6")]
			get
			{
				return default(InteractableCollisionDepth);
			}
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xCDB5E0", Offset = "0xCDB5E0", VA = "0xCDB5E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xCDB674", Offset = "0xCDB674", VA = "0xCDB674")]
		public ButtonTriggerZone()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public interface ColliderZone
	{
		[Token(Token = "0x170000C8")]
		Collider Collider
		{
			[Token(Token = "0x600072B")]
			get;
		}

		[Token(Token = "0x170000C9")]
		Interactable ParentInteractable
		{
			[Token(Token = "0x600072C")]
			get;
		}

		[Token(Token = "0x170000CA")]
		InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x600072D")]
			get;
		}
	}
	[Token(Token = "0x2000128")]
	public class ColliderZoneArgs : EventArgs
	{
		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ColliderZone Collider;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly float FrameTime;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableTool CollidingTool;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly InteractionType InteractionT;

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xAF6F60", Offset = "0xAF6F60", VA = "0xAF6F60")]
		public ColliderZoneArgs(ColliderZone collider, float frameTime, InteractableTool collidingTool, InteractionType interactionType)
		{
		}
	}
	[Token(Token = "0x2000129")]
	public enum InteractionType
	{
		[Token(Token = "0x4000877")]
		Enter,
		[Token(Token = "0x4000878")]
		Stay,
		[Token(Token = "0x4000879")]
		Exit
	}
	[Token(Token = "0x200012A")]
	public class HandsManager : MonoBehaviour
	{
		[Token(Token = "0x200012B")]
		public enum HandsVisualMode
		{
			[Token(Token = "0x400088B")]
			Mesh,
			[Token(Token = "0x400088C")]
			Skeleton,
			[Token(Token = "0x400088D")]
			Both
		}

		[Token(Token = "0x200012C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702FDC", Offset = "0x702FDC")]
		private sealed class <FindSkeletonVisualGameObjects>d__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400088E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400088F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandsManager <>4__this;

			[Token(Token = "0x170000D6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000750")]
				[Address(RVA = "0x1954C18", Offset = "0x1954C18", VA = "0x1954C18", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000752")]
				[Address(RVA = "0x1954C60", Offset = "0x1954C60", VA = "0x1954C60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600074D")]
			[Address(RVA = "0x1954984", Offset = "0x1954984", VA = "0x1954984")]
			[DebuggerHidden]
			public <FindSkeletonVisualGameObjects>d__52(int <>1__state)
			{
			}

			[Token(Token = "0x600074E")]
			[Address(RVA = "0x19549B0", Offset = "0x19549B0", VA = "0x19549B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600074F")]
			[Address(RVA = "0x19549B4", Offset = "0x19549B4", VA = "0x19549B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000751")]
			[Address(RVA = "0x1954C20", Offset = "0x1954C20", VA = "0x1954C20", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400087A")]
		private const string SKELETON_VISUALIZER_NAME = "SkeletonRenderer";

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _leftHand;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rightHand;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandsVisualMode VisualMode;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private OVRHand[] _hand;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private OVRSkeleton[] _handSkeleton;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRSkeletonRenderer[] _handSkeletonRenderer;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OVRMesh[] _handMesh;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private OVRMeshRenderer[] _handMeshRenderer;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SkinnedMeshRenderer _leftMeshRenderer;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SkinnedMeshRenderer _rightMeshRenderer;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _leftSkeletonVisual;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject _rightSkeletonVisual;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _currentHandAlpha;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int HandAlphaId;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70592C", Offset = "0x70592C")]
		private static HandsManager <Instance>k__BackingField;

		[Token(Token = "0x170000CB")]
		public OVRHand RightHand
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0xC0E5F8", Offset = "0xC0E5F8", VA = "0xC0E5F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000730")]
			[Address(RVA = "0xC0E630", Offset = "0xC0E630", VA = "0xC0E630")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public OVRSkeleton RightHandSkeleton
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0xC0E6A0", Offset = "0xC0E6A0", VA = "0xC0E6A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000732")]
			[Address(RVA = "0xC0E6D8", Offset = "0xC0E6D8", VA = "0xC0E6D8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		public OVRSkeletonRenderer RightHandSkeletonRenderer
		{
			[Token(Token = "0x6000733")]
			[Address(RVA = "0xC0E748", Offset = "0xC0E748", VA = "0xC0E748")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000734")]
			[Address(RVA = "0xC0E780", Offset = "0xC0E780", VA = "0xC0E780")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public OVRMesh RightHandMesh
		{
			[Token(Token = "0x6000735")]
			[Address(RVA = "0xC0E7F0", Offset = "0xC0E7F0", VA = "0xC0E7F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000736")]
			[Address(RVA = "0xC0E828", Offset = "0xC0E828", VA = "0xC0E828")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public OVRMeshRenderer RightHandMeshRenderer
		{
			[Token(Token = "0x6000737")]
			[Address(RVA = "0xC0E898", Offset = "0xC0E898", VA = "0xC0E898")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000738")]
			[Address(RVA = "0xC0E8D0", Offset = "0xC0E8D0", VA = "0xC0E8D0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public OVRHand LeftHand
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0xC0E940", Offset = "0xC0E940", VA = "0xC0E940")]
			get
			{
				return null;
			}
			[Token(Token = "0x600073A")]
			[Address(RVA = "0xC0E974", Offset = "0xC0E974", VA = "0xC0E974")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public OVRSkeleton LeftHandSkeleton
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0xC0E9E0", Offset = "0xC0E9E0", VA = "0xC0E9E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600073C")]
			[Address(RVA = "0xC0EA14", Offset = "0xC0EA14", VA = "0xC0EA14")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public OVRSkeletonRenderer LeftHandSkeletonRenderer
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0xC0EA80", Offset = "0xC0EA80", VA = "0xC0EA80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600073E")]
			[Address(RVA = "0xC0EAB4", Offset = "0xC0EAB4", VA = "0xC0EAB4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public OVRMesh LeftHandMesh
		{
			[Token(Token = "0x600073F")]
			[Address(RVA = "0xC0EB20", Offset = "0xC0EB20", VA = "0xC0EB20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000740")]
			[Address(RVA = "0xC0EB54", Offset = "0xC0EB54", VA = "0xC0EB54")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public OVRMeshRenderer LeftHandMeshRenderer
		{
			[Token(Token = "0x6000741")]
			[Address(RVA = "0xC0EBC0", Offset = "0xC0EBC0", VA = "0xC0EBC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000742")]
			[Address(RVA = "0xC0EBF4", Offset = "0xC0EBF4", VA = "0xC0EBF4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public static HandsManager Instance
		{
			[Token(Token = "0x6000743")]
			[Address(RVA = "0xC0EC60", Offset = "0xC0EC60", VA = "0xC0EC60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708D98", Offset = "0x708D98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000744")]
			[Address(RVA = "0xC0ECAC", Offset = "0xC0ECAC", VA = "0xC0ECAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708DA8", Offset = "0x708DA8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xC0ED00", Offset = "0xC0ED00", VA = "0xC0ED00")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xC0F0D4", Offset = "0xC0F0D4", VA = "0xC0F0D4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xC0F05C", Offset = "0xC0F05C", VA = "0xC0F05C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x708DB8", Offset = "0x708DB8")]
		private IEnumerator FindSkeletonVisualGameObjects()
		{
			return null;
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xC0F15C", Offset = "0xC0F15C", VA = "0xC0F15C")]
		public void SwitchVisualization()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xC0F240", Offset = "0xC0F240", VA = "0xC0F240")]
		private void SetToCurrentVisualMode()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xC0F420", Offset = "0xC0F420", VA = "0xC0F420")]
		public static List<OVRBoneCapsule> GetCapsulesPerBone(OVRSkeleton skeleton, OVRSkeleton.BoneId boneId)
		{
			return null;
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xC0F65C", Offset = "0xC0F65C", VA = "0xC0F65C")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xC0F7E8", Offset = "0xC0F7E8", VA = "0xC0F7E8")]
		public HandsManager()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public abstract class Interactable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200012E")]
		public class InteractableStateArgsEvent : UnityEvent<InteractableStateArgs>
		{
			[Token(Token = "0x6000764")]
			[Address(RVA = "0x1954C68", Offset = "0x1954C68", VA = "0x1954C68")]
			public InteractableStateArgsEvent()
			{
			}
		}

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ColliderZone _proximityZoneCollider;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ColliderZone _contactZoneCollider;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected ColliderZone _actionZoneCollider;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractableStateArgsEvent InteractableStateChanged;

		[Token(Token = "0x170000D8")]
		public ColliderZone ProximityCollider
		{
			[Token(Token = "0x6000753")]
			[Address(RVA = "0xC10388", Offset = "0xC10388", VA = "0xC10388")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D9")]
		public ColliderZone ContactCollider
		{
			[Token(Token = "0x6000754")]
			[Address(RVA = "0xC10390", Offset = "0xC10390", VA = "0xC10390")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DA")]
		public ColliderZone ActionCollider
		{
			[Token(Token = "0x6000755")]
			[Address(RVA = "0xC10398", Offset = "0xC10398", VA = "0xC10398")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DB")]
		public virtual int ValidToolTagsMask
		{
			[Token(Token = "0x6000756")]
			[Address(RVA = "0xC103A0", Offset = "0xC103A0", VA = "0xC103A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000010")]
		public event Action<ColliderZoneArgs> ProximityZoneEvent
		{
			[Token(Token = "0x6000757")]
			[Address(RVA = "0xC103A8", Offset = "0xC103A8", VA = "0xC103A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708E68", Offset = "0x708E68")]
			add
			{
			}
			[Token(Token = "0x6000758")]
			[Address(RVA = "0xC10448", Offset = "0xC10448", VA = "0xC10448")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708E78", Offset = "0x708E78")]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event Action<ColliderZoneArgs> ContactZoneEvent
		{
			[Token(Token = "0x600075A")]
			[Address(RVA = "0xC10558", Offset = "0xC10558", VA = "0xC10558")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708E88", Offset = "0x708E88")]
			add
			{
			}
			[Token(Token = "0x600075B")]
			[Address(RVA = "0xC105F8", Offset = "0xC105F8", VA = "0xC105F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708E98", Offset = "0x708E98")]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event Action<ColliderZoneArgs> ActionZoneEvent
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0xC10708", Offset = "0xC10708", VA = "0xC10708")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708EA8", Offset = "0x708EA8")]
			add
			{
			}
			[Token(Token = "0x600075E")]
			[Address(RVA = "0xC107A8", Offset = "0xC107A8", VA = "0xC107A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708EB8", Offset = "0x708EB8")]
			remove
			{
			}
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xC104E8", Offset = "0xC104E8", VA = "0xC104E8", Slot = "5")]
		protected virtual void OnProximityZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xC10698", Offset = "0xC10698", VA = "0xC10698", Slot = "6")]
		protected virtual void OnContactZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xC10848", Offset = "0xC10848", VA = "0xC10848", Slot = "7")]
		protected virtual void OnActionZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x6000760")]
		public abstract void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth);

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xC108B8", Offset = "0xC108B8", VA = "0xC108B8", Slot = "9")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xC109E4", Offset = "0xC109E4", VA = "0xC109E4", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xC10B10", Offset = "0xC10B10", VA = "0xC10B10")]
		protected Interactable()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public enum InteractableCollisionDepth
	{
		[Token(Token = "0x4000899")]
		None,
		[Token(Token = "0x400089A")]
		Proximity,
		[Token(Token = "0x400089B")]
		Contact,
		[Token(Token = "0x400089C")]
		Action
	}
	[Token(Token = "0x2000130")]
	public enum InteractableState
	{
		[Token(Token = "0x400089E")]
		Default,
		[Token(Token = "0x400089F")]
		ProximityState,
		[Token(Token = "0x40008A0")]
		ContactState,
		[Token(Token = "0x40008A1")]
		ActionState
	}
	[Token(Token = "0x2000131")]
	public class InteractableStateArgs : EventArgs
	{
		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Interactable Interactable;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly InteractableTool Tool;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableState OldInteractableState;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly InteractableState NewInteractableState;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ColliderZoneArgs ColliderArgs;

		[Token(Token = "0x6000765")]
		[Address(RVA = "0xC10C68", Offset = "0xC10C68", VA = "0xC10C68")]
		public InteractableStateArgs(Interactable interactable, InteractableTool tool, InteractableState newInteractableState, InteractableState oldState, ColliderZoneArgs colliderArgs)
		{
		}
	}
	[Token(Token = "0x2000132")]
	public class InteractableRegistry : MonoBehaviour
	{
		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HashSet<Interactable> _interactables;

		[Token(Token = "0x170000DC")]
		public static HashSet<Interactable> Interactables
		{
			[Token(Token = "0x6000766")]
			[Address(RVA = "0xC10B70", Offset = "0xC10B70", VA = "0xC10B70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xC10918", Offset = "0xC10918", VA = "0xC10918")]
		public static void RegisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xC10A44", Offset = "0xC10A44", VA = "0xC10A44")]
		public static void UnregisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xC10BD4", Offset = "0xC10BD4", VA = "0xC10BD4")]
		public InteractableRegistry()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public class InteractableToolsCreator : MonoBehaviour
	{
		[Token(Token = "0x2000134")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702FEC", Offset = "0x702FEC")]
		private sealed class <AttachToolsToHands>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform[] toolObjects;

			[Token(Token = "0x40008AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isRightHand;

			[Token(Token = "0x40008AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public InteractableToolsCreator <>4__this;

			[Token(Token = "0x40008AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private HandsManager <handsManagerObj>5__2;

			[Token(Token = "0x40008B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private HashSet<Transform>.Enumerator <>7__wrap2;

			[Token(Token = "0x40008B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Transform <toolObject>5__4;

			[Token(Token = "0x40008B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private OVRSkeleton <handSkeletonToAttachTo>5__5;

			[Token(Token = "0x170000DD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000773")]
				[Address(RVA = "0x19551CC", Offset = "0x19551CC", VA = "0x19551CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000775")]
				[Address(RVA = "0x1955214", Offset = "0x1955214", VA = "0x1955214", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600076F")]
			[Address(RVA = "0x1954CB4", Offset = "0x1954CB4", VA = "0x1954CB4")]
			[DebuggerHidden]
			public <AttachToolsToHands>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000770")]
			[Address(RVA = "0x1954CE0", Offset = "0x1954CE0", VA = "0x1954CE0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0x1954D50", Offset = "0x1954D50", VA = "0x1954D50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0x1954CFC", Offset = "0x1954CFC", VA = "0x1954CFC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0x19551D4", Offset = "0x19551D4", VA = "0x19551D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] LeftHandTools;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] RightHandTools;

		[Token(Token = "0x600076B")]
		[Address(RVA = "0xC119EC", Offset = "0xC119EC", VA = "0xC119EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xC11A68", Offset = "0xC11A68", VA = "0xC11A68")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x708EC8", Offset = "0x708EC8")]
		private IEnumerator AttachToolsToHands(Transform[] toolObjects, bool isRightHand)
		{
			return null;
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xC11B08", Offset = "0xC11B08", VA = "0xC11B08")]
		private void AttachToolToHandTransform(Transform tool, bool isRightHanded)
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xC11BF0", Offset = "0xC11BF0", VA = "0xC11BF0")]
		public InteractableToolsCreator()
		{
		}
	}
	[Token(Token = "0x2000135")]
	public class InteractableToolsInputRouter : MonoBehaviour
	{
		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InteractableToolsInputRouter _instance;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _leftPinch;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _rightPinch;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<InteractableTool> _leftHandNearTools;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<InteractableTool> _leftHandFarTools;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<InteractableTool> _rightHandNearTools;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<InteractableTool> _rightHandFarTools;

		[Token(Token = "0x170000DF")]
		public static InteractableToolsInputRouter Instance
		{
			[Token(Token = "0x6000776")]
			[Address(RVA = "0xC11BF8", Offset = "0xC11BF8", VA = "0xC11BF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xC11D78", Offset = "0xC11D78", VA = "0xC11D78")]
		public void RegisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xC11E20", Offset = "0xC11E20", VA = "0xC11E20")]
		public void UnregisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xC11EC8", Offset = "0xC11EC8", VA = "0xC11EC8")]
		private void Update()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xC12174", Offset = "0xC12174", VA = "0xC12174")]
		private bool UpdateToolsAndEnableState(HashSet<InteractableTool> tools, bool toolsAreEnabledThisFrame)
		{
			return default(bool);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xC121BC", Offset = "0xC121BC", VA = "0xC121BC")]
		private bool UpdateTools(HashSet<InteractableTool> tools, bool resetCollisionData = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xC1246C", Offset = "0xC1246C", VA = "0xC1246C")]
		private void ToggleToolsEnableState(HashSet<InteractableTool> tools, bool enableState)
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xC125B8", Offset = "0xC125B8", VA = "0xC125B8")]
		public InteractableToolsInputRouter()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class FingerTipPokeTool : InteractableTool
	{
		[Token(Token = "0x2000137")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702FFC", Offset = "0x702FFC")]
		private sealed class <AttachTriggerLogic>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FingerTipPokeTool <>4__this;

			[Token(Token = "0x170000E4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600078F")]
				[Address(RVA = "0x1953AF0", Offset = "0x1953AF0", VA = "0x1953AF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000791")]
				[Address(RVA = "0x1953B38", Offset = "0x1953B38", VA = "0x1953B38", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600078C")]
			[Address(RVA = "0x19536BC", Offset = "0x19536BC", VA = "0x19536BC")]
			[DebuggerHidden]
			public <AttachTriggerLogic>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600078D")]
			[Address(RVA = "0x19536E8", Offset = "0x19536E8", VA = "0x19536E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0x19536EC", Offset = "0x19536EC", VA = "0x19536EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x1953AF8", Offset = "0x1953AF8", VA = "0x1953AF8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008BA")]
		private const int NUM_VELOCITY_FRAMES = 10;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FingerTipPokeToolView _fingerTipPokeToolView;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private OVRPlugin.HandFinger _fingerToFollow;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] _velocityFrames;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _currVelocityFrame;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool _sampledMaxFramesAlready;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 _position;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BoneCapsuleTriggerLogic[] _boneCapsuleTriggerLogic;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastScale;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isInitialized;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private OVRBoneCapsule _capsuleToTrack;

		[Token(Token = "0x170000E0")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x600077E")]
			[Address(RVA = "0xB05A64", Offset = "0xB05A64", VA = "0xB05A64", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170000E1")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x600077F")]
			[Address(RVA = "0xB05A6C", Offset = "0xB05A6C", VA = "0xB05A6C", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000E2")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0xB05A74", Offset = "0xB05A74", VA = "0xB05A74", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E3")]
		public override bool EnableState
		{
			[Token(Token = "0x6000781")]
			[Address(RVA = "0xB05A7C", Offset = "0xB05A7C", VA = "0xB05A7C", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000782")]
			[Address(RVA = "0xB05AA8", Offset = "0xB05AA8", VA = "0xB05AA8", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xB05AE4", Offset = "0xB05AE4", VA = "0xB05AE4", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0xB05B9C", Offset = "0xB05B9C", VA = "0xB05B9C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x708F78", Offset = "0x708F78")]
		private IEnumerator AttachTriggerLogic()
		{
			return null;
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xB05C14", Offset = "0xB05C14", VA = "0xB05C14")]
		private void Update()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0xB05EB4", Offset = "0xB05EB4", VA = "0xB05EB4")]
		private void UpdateAverageVelocity()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0xB06040", Offset = "0xB06040", VA = "0xB06040")]
		private void CheckAndUpdateScale()
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0xB06138", Offset = "0xB06138", VA = "0xB06138", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xB06430", Offset = "0xB06430", VA = "0xB06430", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xB06434", Offset = "0xB06434", VA = "0xB06434", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xB06438", Offset = "0xB06438", VA = "0xB06438")]
		public FingerTipPokeTool()
		{
		}
	}
	[Token(Token = "0x2000138")]
	public class FingerTipPokeToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _sphereMeshRenderer;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7059BC", Offset = "0x7059BC")]
		private InteractableTool <InteractableTool>k__BackingField;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7059CC", Offset = "0x7059CC")]
		private bool <ToolActivateState>k__BackingField;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7059DC", Offset = "0x7059DC")]
		private float <SphereRadius>k__BackingField;

		[Token(Token = "0x170000E6")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x6000792")]
			[Address(RVA = "0xB06450", Offset = "0xB06450", VA = "0xB06450", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x709028", Offset = "0x709028")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000793")]
			[Address(RVA = "0xB06458", Offset = "0xB06458", VA = "0xB06458")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x709038", Offset = "0x709038")]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public bool EnableState
		{
			[Token(Token = "0x6000794")]
			[Address(RVA = "0xB06460", Offset = "0xB06460", VA = "0xB06460", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000795")]
			[Address(RVA = "0xB0647C", Offset = "0xB0647C", VA = "0xB0647C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public bool ToolActivateState
		{
			[Token(Token = "0x6000796")]
			[Address(RVA = "0xB0649C", Offset = "0xB0649C", VA = "0xB0649C", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x709048", Offset = "0x709048")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000797")]
			[Address(RVA = "0xB064A4", Offset = "0xB064A4", VA = "0xB064A4", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x709058", Offset = "0x709058")]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public float SphereRadius
		{
			[Token(Token = "0x6000798")]
			[Address(RVA = "0xB064B0", Offset = "0xB064B0", VA = "0xB064B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x709068", Offset = "0x709068")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000799")]
			[Address(RVA = "0xB064B8", Offset = "0xB064B8", VA = "0xB064B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x709078", Offset = "0x709078")]
			private set
			{
			}
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xB064C0", Offset = "0xB064C0", VA = "0xB064C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xB06508", Offset = "0xB06508", VA = "0xB06508", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xB0650C", Offset = "0xB0650C", VA = "0xB0650C")]
		public FingerTipPokeToolView()
		{
		}
	}
	[Token(Token = "0x2000139")]
	[Flags]
	public enum InteractableToolTags
	{
		[Token(Token = "0x40008CD")]
		None = 0,
		[Token(Token = "0x40008CE")]
		Ray = 1,
		[Token(Token = "0x40008CF")]
		Poke = 4,
		[Token(Token = "0x40008D0")]
		All = -1
	}
	[Token(Token = "0x200013A")]
	public enum ToolInputState
	{
		[Token(Token = "0x40008D2")]
		Inactive,
		[Token(Token = "0x40008D3")]
		PrimaryInputDown,
		[Token(Token = "0x40008D4")]
		PrimaryInputDownStay,
		[Token(Token = "0x40008D5")]
		PrimaryInputUp
	}
	[Token(Token = "0x200013B")]
	public class InteractableCollisionInfo
	{
		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ColliderZone InteractableCollider;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableCollisionDepth CollisionDepth;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractableTool CollidingTool;

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xC10B18", Offset = "0xC10B18", VA = "0xC10B18")]
		public InteractableCollisionInfo(ColliderZone collider, InteractableCollisionDepth collisionDepth, InteractableTool collidingTool)
		{
		}
	}
	[Token(Token = "0x200013C")]
	public abstract class InteractableTool : MonoBehaviour
	{
		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7059EC", Offset = "0x7059EC")]
		private bool <IsRightHandedTool>k__BackingField;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7059FC", Offset = "0x7059FC")]
		private Vector3 <Velocity>k__BackingField;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705A0C", Offset = "0x705A0C")]
		private Vector3 <InteractionPosition>k__BackingField;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<InteractableCollisionInfo> _currentIntersectingObjects;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Interactable> _addedInteractables;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Interactable> _removedInteractables;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Interactable> _remainingInteractables;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Interactable, InteractableCollisionInfo> _currInteractableToCollisionInfos;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<Interactable, InteractableCollisionInfo> _prevInteractableToCollisionInfos;

		[Token(Token = "0x170000EA")]
		public Transform ToolTransform
		{
			[Token(Token = "0x600079E")]
			[Address(RVA = "0xC10D2C", Offset = "0xC10D2C", VA = "0xC10D2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EB")]
		public bool IsRightHandedTool
		{
			[Token(Token = "0x600079F")]
			[Address(RVA = "0xC10D34", Offset = "0xC10D34", VA = "0xC10D34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x709088", Offset = "0x709088")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A0")]
			[Address(RVA = "0xC10D3C", Offset = "0xC10D3C", VA = "0xC10D3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x709098", Offset = "0x709098")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public abstract InteractableToolTags ToolTags
		{
			[Token(Token = "0x60007A1")]
			get;
		}

		[Token(Token = "0x170000ED")]
		public abstract ToolInputState ToolInputState
		{
			[Token(Token = "0x60007A2")]
			get;
		}

		[Token(Token = "0x170000EE")]
		public abstract bool IsFarFieldTool
		{
			[Token(Token = "0x60007A3")]
			get;
		}

		[Token(Token = "0x170000EF")]
		public Vector3 Velocity
		{
			[Token(Token = "0x60007A4")]
			[Address(RVA = "0xC10D48", Offset = "0xC10D48", VA = "0xC10D48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7090A8", Offset = "0x7090A8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0xC10D54", Offset = "0xC10D54", VA = "0xC10D54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7090B8", Offset = "0x7090B8")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public Vector3 InteractionPosition
		{
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0xC10D60", Offset = "0xC10D60", VA = "0xC10D60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7090C8", Offset = "0x7090C8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0xC10D6C", Offset = "0xC10D6C", VA = "0xC10D6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7090D8", Offset = "0x7090D8")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public abstract bool EnableState
		{
			[Token(Token = "0x60007AC")]
			get;
			[Token(Token = "0x60007AD")]
			set;
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xC10D78", Offset = "0xC10D78", VA = "0xC10D78")]
		public List<InteractableCollisionInfo> GetCurrentIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60007A9")]
		public abstract List<InteractableCollisionInfo> GetNextIntersectingObjects();

		[Token(Token = "0x60007AA")]
		public abstract void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone);

		[Token(Token = "0x60007AB")]
		public abstract void DeFocus();

		[Token(Token = "0x60007AE")]
		public abstract void Initialize();

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xC10D80", Offset = "0xC10D80", VA = "0xC10D80")]
		public KeyValuePair<Interactable, InteractableCollisionInfo> GetFirstCurrentCollisionInfo()
		{
			return default(KeyValuePair<Interactable, InteractableCollisionInfo>);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xC10DCC", Offset = "0xC10DCC", VA = "0xC10DCC")]
		public void ClearAllCurrentCollisionInfos()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xC10E20", Offset = "0xC10E20", VA = "0xC10E20", Slot = "13")]
		public virtual void UpdateCurrentCollisionsBasedOnDepth()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xC110D0", Offset = "0xC110D0", VA = "0xC110D0", Slot = "14")]
		public virtual void UpdateLatestCollisionData()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xC1185C", Offset = "0xC1185C", VA = "0xC1185C")]
		protected InteractableTool()
		{
		}
	}
	[Token(Token = "0x200013D")]
	public interface InteractableToolView
	{
		[Token(Token = "0x170000F2")]
		InteractableTool InteractableTool
		{
			[Token(Token = "0x60007B4")]
			get;
		}

		[Token(Token = "0x170000F3")]
		bool EnableState
		{
			[Token(Token = "0x60007B6")]
			get;
			[Token(Token = "0x60007B7")]
			set;
		}

		[Token(Token = "0x170000F4")]
		bool ToolActivateState
		{
			[Token(Token = "0x60007B8")]
			get;
			[Token(Token = "0x60007B9")]
			set;
		}

		[Token(Token = "0x60007B5")]
		void SetFocusedInteractable(Interactable interactable);
	}
	[Token(Token = "0x200013E")]
	public class PinchStateModule
	{
		[Token(Token = "0x200013F")]
		private enum PinchState
		{
			[Token(Token = "0x40008E6")]
			None,
			[Token(Token = "0x40008E7")]
			PinchDown,
			[Token(Token = "0x40008E8")]
			PinchStay,
			[Token(Token = "0x40008E9")]
			PinchUp
		}

		[Token(Token = "0x40008E2")]
		private const float PINCH_STRENGTH_THRESHOLD = 1f;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PinchState _currPinchState;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Interactable _firstFocusedInteractable;

		[Token(Token = "0x170000F5")]
		public bool PinchUpAndDownOnFocusedObject
		{
			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x130E14C", Offset = "0x130E14C", VA = "0x130E14C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F6")]
		public bool PinchSteadyOnFocusedObject
		{
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x130E1D4", Offset = "0x130E1D4", VA = "0x130E1D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F7")]
		public bool PinchDownOnFocusedObject
		{
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x130E25C", Offset = "0x130E25C", VA = "0x130E25C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x130E2E4", Offset = "0x130E2E4", VA = "0x130E2E4")]
		public PinchStateModule()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x130E318", Offset = "0x130E318", VA = "0x130E318")]
		public void UpdateState(OVRHand hand, Interactable currFocusedInteractable)
		{
		}
	}
	[Token(Token = "0x2000140")]
	public class RayTool : InteractableTool
	{
		[Token(Token = "0x40008EA")]
		private const float MINIMUM_RAY_CAST_DISTANCE = 0.8f;

		[Token(Token = "0x40008EB")]
		private const float COLLIDER_RADIUS = 0.01f;

		[Token(Token = "0x40008EC")]
		private const int NUM_MAX_PRIMARY_HITS = 10;

		[Token(Token = "0x40008ED")]
		private const int NUM_MAX_SECONDARY_HITS = 25;

		[Token(Token = "0x40008EE")]
		private const int NUM_COLLIDERS_TO_TEST = 20;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RayToolView _rayToolView;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x705A2C", Offset = "0x705A2C")]
		[SerializeField]
		private float _coneAngleDegrees;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _farFieldMaxDistance;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PinchStateModule _pinchStateModule;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Interactable _focusedInteractable;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] _collidersOverlapped;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Interactable _currInteractableCastedAgainst;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _coneAngleReleaseDegrees;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RaycastHit[] _primaryHits;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] _secondaryOverlapResults;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _initialized;

		[Token(Token = "0x170000F8")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0xB7AF3C", Offset = "0xB7AF3C", VA = "0xB7AF3C", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170000F9")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x60007C0")]
			[Address(RVA = "0xB7AF44", Offset = "0xB7AF44", VA = "0xB7AF44", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000FA")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x60007C1")]
			[Address(RVA = "0xB7AFB8", Offset = "0xB7AFB8", VA = "0xB7AFB8", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FB")]
		public override bool EnableState
		{
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0xB7AFC0", Offset = "0xB7AFC0", VA = "0xB7AFC0", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0xB7B004", Offset = "0xB7B004", VA = "0xB7B004", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xB7B078", Offset = "0xB7B078", VA = "0xB7B078", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xB7B0E0", Offset = "0xB7B0E0", VA = "0xB7B0E0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xB7B184", Offset = "0xB7B184", VA = "0xB7B184")]
		private void Update()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xB7B448", Offset = "0xB7B448", VA = "0xB7B448")]
		private Vector3 GetRayCastOrigin()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xB7B4D0", Offset = "0xB7B4D0", VA = "0xB7B4D0", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xB7B8A0", Offset = "0xB7B8A0", VA = "0xB7B8A0")]
		private bool HasRayReleasedInteractable(Interactable focusedInteractable)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xB7B9B0", Offset = "0xB7B9B0", VA = "0xB7B9B0")]
		private Interactable FindTargetInteractable()
		{
			return null;
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xB7BAD4", Offset = "0xB7BAD4", VA = "0xB7BAD4")]
		private Interactable FindPrimaryRaycastHit(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xB7BDD8", Offset = "0xB7BDD8", VA = "0xB7BDD8")]
		private Interactable FindInteractableViaConeTest(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xB7C16C", Offset = "0xB7C16C", VA = "0xB7C16C", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xB7C254", Offset = "0xB7C254", VA = "0xB7C254", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xB7C290", Offset = "0xB7C290", VA = "0xB7C290")]
		public RayTool()
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class RayToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x40008FA")]
		private const int NUM_RAY_LINE_POSITIONS = 25;

		[Token(Token = "0x40008FB")]
		private const float DEFAULT_RAY_CAST_DISTANCE = 3f;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _targetTransform;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LineRenderer _lineRenderer;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _toolActivateState;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _focusedTransform;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] linePositions;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Gradient _oldColorGradient;

		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Gradient _highLightColorGradient;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705AA0", Offset = "0x705AA0")]
		private InteractableTool <InteractableTool>k__BackingField;

		[Token(Token = "0x170000FC")]
		public bool EnableState
		{
			[Token(Token = "0x60007D0")]
			[Address(RVA = "0xB7AFE8", Offset = "0xB7AFE8", VA = "0xB7AFE8", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007D1")]
			[Address(RVA = "0xB7B020", Offset = "0xB7B020", VA = "0xB7B020", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public bool ToolActivateState
		{
			[Token(Token = "0x60007D2")]
			[Address(RVA = "0xB7C388", Offset = "0xB7C388", VA = "0xB7C388", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007D3")]
			[Address(RVA = "0xB7B40C", Offset = "0xB7B40C", VA = "0xB7B40C", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0xB7C5E8", Offset = "0xB7C5E8", VA = "0xB7C5E8", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7090E8", Offset = "0x7090E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0xB7C5F0", Offset = "0xB7C5F0", VA = "0xB7C5F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7090F8", Offset = "0x7090F8")]
			set
			{
			}
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xB7C390", Offset = "0xB7C390", VA = "0xB7C390")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xB7C1A8", Offset = "0xB7C1A8", VA = "0xB7C1A8", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xB7C5F8", Offset = "0xB7C5F8", VA = "0xB7C5F8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xB7C86C", Offset = "0xB7C86C", VA = "0xB7C86C")]
		public static Vector3 GetPointOnBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xB7C95C", Offset = "0xB7C95C", VA = "0xB7C95C")]
		public RayToolView()
		{
		}
	}
	[Token(Token = "0x2000142")]
	public class DistanceGrabberSample : MonoBehaviour
	{
		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool useSpherecast;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool allowGrabThroughWalls;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DistanceGrabber[] m_grabbers;

		[Token(Token = "0x170000FF")]
		public bool UseSpherecast
		{
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0xB041A4", Offset = "0xB041A4", VA = "0xB041A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007DC")]
			[Address(RVA = "0xB041AC", Offset = "0xB041AC", VA = "0xB041AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public bool AllowGrabThroughWalls
		{
			[Token(Token = "0x60007DD")]
			[Address(RVA = "0xB04234", Offset = "0xB04234", VA = "0xB04234")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0xB0423C", Offset = "0xB0423C", VA = "0xB0423C")]
			set
			{
			}
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xB042A8", Offset = "0xB042A8", VA = "0xB042A8")]
		private void Start()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xB0455C", Offset = "0xB0455C", VA = "0xB0455C")]
		public void ToggleSphereCasting(Toggle t)
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xB0456C", Offset = "0xB0456C", VA = "0xB0456C")]
		public void ToggleGrabThroughWalls(Toggle t)
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xB0457C", Offset = "0xB0457C", VA = "0xB0457C")]
		public DistanceGrabberSample()
		{
		}
	}
	[Token(Token = "0x2000143")]
	public class ControllerBoxController : MonoBehaviour
	{
		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TrainLocomotive _locomotive;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CowController _cowController;

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xAFEB6C", Offset = "0xAFEB6C", VA = "0xAFEB6C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xAFEB70", Offset = "0xAFEB70", VA = "0xAFEB70")]
		public void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xAFEBA8", Offset = "0xAFEBA8", VA = "0xAFEBA8")]
		public void DecreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xAFEBE0", Offset = "0xAFEBE0", VA = "0xAFEBE0")]
		public void IncreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xAFEC18", Offset = "0xAFEC18", VA = "0xAFEC18")]
		public void SmokeButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xAFEC50", Offset = "0xAFEC50", VA = "0xAFEC50")]
		public void WhistleButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xAFEC88", Offset = "0xAFEC88", VA = "0xAFEC88")]
		public void ReverseButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xAFECC0", Offset = "0xAFECC0", VA = "0xAFECC0")]
		public void SwitchVisualization(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xAFED34", Offset = "0xAFED34", VA = "0xAFED34")]
		public void GoMoo(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xAFEDA4", Offset = "0xAFEDA4", VA = "0xAFEDA4")]
		public ControllerBoxController()
		{
		}
	}
	[Token(Token = "0x2000144")]
	public class CowController : MonoBehaviour
	{
		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animation _cowAnimation;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource _mooCowAudioSource;

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xAFEDAC", Offset = "0xAFEDAC", VA = "0xAFEDAC")]
		private void Start()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xAFEDB0", Offset = "0xAFEDB0", VA = "0xAFEDB0")]
		public void PlayMooSound()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xAFED68", Offset = "0xAFED68", VA = "0xAFED68")]
		public void GoMooCowGo()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xAFEDF0", Offset = "0xAFEDF0", VA = "0xAFEDF0")]
		public CowController()
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class PanelHMDFollower : MonoBehaviour
	{
		[Token(Token = "0x2000146")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70301C", Offset = "0x70301C")]
		private sealed class <LerpToHMD>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000915")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000916")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000917")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PanelHMDFollower <>4__this;

			[Token(Token = "0x4000918")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <newPanelPosition>5__2;

			[Token(Token = "0x4000919")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <startTime>5__3;

			[Token(Token = "0x400091A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <endTime>5__4;

			[Token(Token = "0x17000101")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007F9")]
				[Address(RVA = "0x1956B98", Offset = "0x1956B98", VA = "0x1956B98", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000102")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007FB")]
				[Address(RVA = "0x1956BE0", Offset = "0x1956BE0", VA = "0x1956BE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x19569AC", Offset = "0x19569AC", VA = "0x19569AC")]
			[DebuggerHidden]
			public <LerpToHMD>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x19569D8", Offset = "0x19569D8", VA = "0x19569D8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x19569DC", Offset = "0x19569DC", VA = "0x19569DC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x1956BA0", Offset = "0x1956BA0", VA = "0x1956BA0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400090B")]
		private const float TOTAL_DURATION = 3f;

		[Token(Token = "0x400090C")]
		private const float HMD_MOVEMENT_THRESHOLD = 0.3f;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _maxDistance;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _minDistance;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minZDistance;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OVRCameraRig _cameraRig;

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _panelInitialPosition;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _coroutine;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _prevPos;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _lastMovedToPos;

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x130BD58", Offset = "0x130BD58", VA = "0x130BD58")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x130BE04", Offset = "0x130BE04", VA = "0x130BE04")]
		private void Update()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x130C054", Offset = "0x130C054", VA = "0x130C054")]
		private Vector3 CalculateIdealAnchorPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x130BFDC", Offset = "0x130BFDC", VA = "0x130BFDC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x709108", Offset = "0x709108")]
		private IEnumerator LerpToHMD()
		{
			return null;
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x130C0A0", Offset = "0x130C0A0", VA = "0x130C0A0")]
		public PanelHMDFollower()
		{
		}
	}
	[Token(Token = "0x2000147")]
	public class SelectionCylinder : MonoBehaviour
	{
		[Token(Token = "0x2000148")]
		public enum SelectionState
		{
			[Token(Token = "0x4000922")]
			Off,
			[Token(Token = "0x4000923")]
			Selected,
			[Token(Token = "0x4000924")]
			Highlighted
		}

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _selectionMeshRenderer;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _colorId;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material[] _selectionMaterials;

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color[] _defaultSelectionColors;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color[] _highlightColors;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SelectionState _currSelectionState;

		[Token(Token = "0x17000103")]
		public SelectionState CurrSelectionState
		{
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0xB7D888", Offset = "0xB7D888", VA = "0xB7D888")]
			get
			{
				return default(SelectionState);
			}
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0xB7D890", Offset = "0xB7D890", VA = "0xB7D890")]
			set
			{
			}
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xB7DA14", Offset = "0xB7DA14", VA = "0xB7DA14")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xB7DC18", Offset = "0xB7DC18", VA = "0xB7DC18")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xB7D918", Offset = "0xB7D918", VA = "0xB7D918")]
		private void AffectSelectionColor(Color[] newColors)
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xB7DD04", Offset = "0xB7DD04", VA = "0xB7DD04")]
		public SelectionCylinder()
		{
		}
	}
	[Token(Token = "0x2000149")]
	public class TrackSegment : MonoBehaviour
	{
		[Token(Token = "0x200014A")]
		public enum SegmentType
		{
			[Token(Token = "0x4000933")]
			Straight,
			[Token(Token = "0x4000934")]
			LeftTurn,
			[Token(Token = "0x4000935")]
			RightTurn,
			[Token(Token = "0x4000936")]
			Switch
		}

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SegmentType _segmentType;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshFilter _straight;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshFilter _leftTurn;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshFilter _rightTurn;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _gridSize;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _subDivCount;

		[Token(Token = "0x400092B")]
		private const float _originalGridSize = 0.8f;

		[Token(Token = "0x400092C")]
		private const float _trackWidth = 0.15f;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _mesh;

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705B80", Offset = "0x705B80")]
		private float <StartDistance>k__BackingField;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Pose _p1;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Pose _p2;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Pose _endPose;

		[Token(Token = "0x17000104")]
		public float StartDistance
		{
			[Token(Token = "0x6000803")]
			[Address(RVA = "0xB898EC", Offset = "0xB898EC", VA = "0xB898EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7091B8", Offset = "0x7091B8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000804")]
			[Address(RVA = "0xB898F4", Offset = "0xB898F4", VA = "0xB898F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7091C8", Offset = "0x7091C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public float GridSize
		{
			[Token(Token = "0x6000805")]
			[Address(RVA = "0xB898FC", Offset = "0xB898FC", VA = "0xB898FC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000806")]
			[Address(RVA = "0xB89904", Offset = "0xB89904", VA = "0xB89904")]
			private set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public int SubDivCount
		{
			[Token(Token = "0x6000807")]
			[Address(RVA = "0xB8990C", Offset = "0xB8990C", VA = "0xB8990C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000808")]
			[Address(RVA = "0xB89914", Offset = "0xB89914", VA = "0xB89914")]
			set
			{
			}
		}

		[Token(Token = "0x17000107")]
		public SegmentType Type
		{
			[Token(Token = "0x6000809")]
			[Address(RVA = "0xB8991C", Offset = "0xB8991C", VA = "0xB8991C")]
			get
			{
				return default(SegmentType);
			}
		}

		[Token(Token = "0x17000108")]
		public Pose EndPose
		{
			[Token(Token = "0x600080A")]
			[Address(RVA = "0xB89924", Offset = "0xB89924", VA = "0xB89924")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000109")]
		public float Radius
		{
			[Token(Token = "0x600080B")]
			[Address(RVA = "0xB89C80", Offset = "0xB89C80", VA = "0xB89C80")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700010A")]
		public float SegmentLength
		{
			[Token(Token = "0x600080D")]
			[Address(RVA = "0xB8998C", Offset = "0xB8998C", VA = "0xB8998C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xB89C90", Offset = "0xB89C90", VA = "0xB89C90")]
		public float setGridSize(float size)
		{
			return default(float);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xB89CA8", Offset = "0xB89CA8", VA = "0xB89CA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xB899CC", Offset = "0xB899CC", VA = "0xB899CC")]
		public void UpdatePose(float distanceIntoSegment, Pose pose)
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xB89CAC", Offset = "0xB89CAC", VA = "0xB89CAC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xB89CB0", Offset = "0xB89CB0", VA = "0xB89CB0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xB89D18", Offset = "0xB89D18", VA = "0xB89D18")]
		private void DrawDebugLines()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xB8A5E0", Offset = "0xB8A5E0", VA = "0xB8A5E0")]
		public void RegenerateTrackAndMesh()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xB8A88C", Offset = "0xB8A88C", VA = "0xB8A88C")]
		public TrackSegment()
		{
		}
	}
	[Token(Token = "0x200014B")]
	public class TrainButtonVisualController : MonoBehaviour
	{
		[Token(Token = "0x200014C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70302C", Offset = "0x70302C")]
		private sealed class <ResetPosition>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400094A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainButtonVisualController <>4__this;

			[Token(Token = "0x400094B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <startTime>5__2;

			[Token(Token = "0x400094C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <endTime>5__3;

			[Token(Token = "0x1700010B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000823")]
				[Address(RVA = "0x191D60C", Offset = "0x191D60C", VA = "0x191D60C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000825")]
				[Address(RVA = "0x191D654", Offset = "0x191D654", VA = "0x191D654", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000820")]
			[Address(RVA = "0x191D468", Offset = "0x191D468", VA = "0x191D468")]
			[DebuggerHidden]
			public <ResetPosition>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000821")]
			[Address(RVA = "0x191D494", Offset = "0x191D494", VA = "0x191D494", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000822")]
			[Address(RVA = "0x191D498", Offset = "0x191D498", VA = "0x191D498", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000824")]
			[Address(RVA = "0x191D614", Offset = "0x191D614", VA = "0x191D614", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000937")]
		private const float LERP_TO_OLD_POS_DURATION = 1f;

		[Token(Token = "0x4000938")]
		private const float LOCAL_SIZE_HALVED = 0.5f;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _meshRenderer;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer _glowRenderer;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonController _buttonController;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _buttonContactColor;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _buttonActionColor;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip _actionSoundEffect;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _buttonContactTransform;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _contactMaxDisplacementDistance;

		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material _buttonMaterial;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color _buttonDefaultColor;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _materialColorId;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _buttonInContactOrActionStates;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine _lerpToOldPositionCr;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 _oldPosition;

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xB8A95C", Offset = "0xB8A95C", VA = "0xB8A95C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xB8AA18", Offset = "0xB8AA18", VA = "0xB8AA18")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xB8AAC8", Offset = "0xB8AAC8", VA = "0xB8AAC8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xB8AC40", Offset = "0xB8AC40", VA = "0xB8AC40")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xB8AE08", Offset = "0xB8AE08", VA = "0xB8AE08")]
		private void ActionOrInContactZoneStayEvent(ColliderZoneArgs collisionArgs)
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xB8AEF0", Offset = "0xB8AEF0", VA = "0xB8AEF0")]
		private void InteractableStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xB8B104", Offset = "0xB8B104", VA = "0xB8B104")]
		private void PlaySound(AudioClip clip)
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xB8B004", Offset = "0xB8B004", VA = "0xB8B004")]
		private void StopResetLerping()
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xB8B018", Offset = "0xB8B018", VA = "0xB8B018")]
		private void LerpToOldPosition()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xB8B15C", Offset = "0xB8B15C", VA = "0xB8B15C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7091D8", Offset = "0x7091D8")]
		private IEnumerator ResetPosition()
		{
			return null;
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xB8B1D4", Offset = "0xB8B1D4", VA = "0xB8B1D4")]
		public TrainButtonVisualController()
		{
		}
	}
	[Token(Token = "0x200014D")]
	public class TrainCar : TrainCarBase
	{
		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TrainCarBase _parentLocomotive;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float _distanceBehindParent;

		[Token(Token = "0x1700010D")]
		public float DistanceBehindParentScaled
		{
			[Token(Token = "0x6000826")]
			[Address(RVA = "0xB8B284", Offset = "0xB8B284", VA = "0xB8B284")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xB8B294", Offset = "0xB8B294", VA = "0xB8B294", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xB8B29C", Offset = "0xB8B29C", VA = "0xB8B29C", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xB8B5E0", Offset = "0xB8B5E0", VA = "0xB8B5E0")]
		public TrainCar()
		{
		}
	}
	[Token(Token = "0x200014E")]
	public abstract class TrainCarBase : MonoBehaviour
	{
		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 OFFSET;

		[Token(Token = "0x4000950")]
		private const float WHEEL_RADIUS = 0.027f;

		[Token(Token = "0x4000951")]
		private const float TWO_PI = (float)Math.PI * 2f;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform _frontWheels;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform _rearWheels;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TrainTrack _trainTrack;

		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform[] _individualWheels;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705C80", Offset = "0x705C80")]
		private float <Distance>k__BackingField;

		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float scale;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Pose _frontPose;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Pose _rearPose;

		[Token(Token = "0x1700010E")]
		public float Distance
		{
			[Token(Token = "0x600082A")]
			[Address(RVA = "0xB8B6F0", Offset = "0xB8B6F0", VA = "0xB8B6F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x709288", Offset = "0x709288")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600082B")]
			[Address(RVA = "0xB8B6F8", Offset = "0xB8B6F8", VA = "0xB8B6F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x709298", Offset = "0x709298")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700010F")]
		public float Scale
		{
			[Token(Token = "0x600082C")]
			[Address(RVA = "0xB8B700", Offset = "0xB8B700", VA = "0xB8B700")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600082D")]
			[Address(RVA = "0xB8B708", Offset = "0xB8B708", VA = "0xB8B708")]
			set
			{
			}
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xB8B298", Offset = "0xB8B298", VA = "0xB8B298", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xB8B710", Offset = "0xB8B710", VA = "0xB8B710")]
		public void UpdatePose(float distance, TrainCarBase train, Pose pose)
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xB8B2E4", Offset = "0xB8B2E4", VA = "0xB8B2E4")]
		protected void UpdateCarPosition()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xB8B508", Offset = "0xB8B508", VA = "0xB8B508")]
		protected void RotateCarWheels()
		{
		}

		[Token(Token = "0x6000832")]
		public abstract void UpdatePosition();

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xB8B64C", Offset = "0xB8B64C", VA = "0xB8B64C")]
		protected TrainCarBase()
		{
		}
	}
	[Token(Token = "0x200014F")]
	public class TrainCrossingController : MonoBehaviour
	{
		[Token(Token = "0x2000150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70303C", Offset = "0x70303C")]
		private sealed class <AnimateCrossing>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainCrossingController <>4__this;

			[Token(Token = "0x4000967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float animationLength;

			[Token(Token = "0x4000968")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <animationEndTime>5__2;

			[Token(Token = "0x4000969")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <lightBlinkDuration>5__3;

			[Token(Token = "0x400096A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <lightBlinkStartTime>5__4;

			[Token(Token = "0x400096B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <lightBlinkEndTime>5__5;

			[Token(Token = "0x400096C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Material <lightToBlinkOn>5__6;

			[Token(Token = "0x400096D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Material <lightToBlinkOff>5__7;

			[Token(Token = "0x400096E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Color <onColor>5__8;

			[Token(Token = "0x400096F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Color <offColor>5__9;

			[Token(Token = "0x17000110")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000841")]
				[Address(RVA = "0x191D8F4", Offset = "0x191D8F4", VA = "0x191D8F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000111")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000843")]
				[Address(RVA = "0x191D93C", Offset = "0x191D93C", VA = "0x191D93C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600083E")]
			[Address(RVA = "0x191D65C", Offset = "0x191D65C", VA = "0x191D65C")]
			[DebuggerHidden]
			public <AnimateCrossing>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x600083F")]
			[Address(RVA = "0x191D688", Offset = "0x191D688", VA = "0x191D688", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000840")]
			[Address(RVA = "0x191D68C", Offset = "0x191D68C", VA = "0x191D68C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000842")]
			[Address(RVA = "0x191D8FC", Offset = "0x191D8FC", VA = "0x191D8FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip[] _crossingSounds;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshRenderer _lightSide1Renderer;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshRenderer _lightSide2Renderer;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material _lightsSide1Mat;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material _lightsSide2Mat;

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _colorId;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _xingAnimationCr;

		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xB8B8B0", Offset = "0xB8B8B0", VA = "0xB8B8B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xB8B910", Offset = "0xB8B910", VA = "0xB8B910")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xB8BA18", Offset = "0xB8BA18", VA = "0xB8BA18")]
		public void CrossingButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xB8BB88", Offset = "0xB8BB88", VA = "0xB8BB88")]
		private void Update()
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xB8BA78", Offset = "0xB8BA78", VA = "0xB8BA78")]
		private void ActivateTrainCrossing()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xB8BC60", Offset = "0xB8BC60", VA = "0xB8BC60")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7092A8", Offset = "0x7092A8")]
		private IEnumerator AnimateCrossing(float animationLength)
		{
			return null;
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xB8BCE8", Offset = "0xB8BCE8", VA = "0xB8BCE8")]
		private void AffectMaterials(Material[] materials, Color newColor)
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xB8BD94", Offset = "0xB8BD94", VA = "0xB8BD94")]
		private void ToggleLightObjects(bool enableState)
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xB8BDF4", Offset = "0xB8BDF4", VA = "0xB8BDF4")]
		public TrainCrossingController()
		{
		}
	}
	[Token(Token = "0x2000151")]
	public class TrainLocomotive : TrainCarBase
	{
		[Token(Token = "0x2000152")]
		private enum EngineSoundState
		{
			[Token(Token = "0x400098E")]
			Start,
			[Token(Token = "0x400098F")]
			AccelerateOrSetProperSpeed,
			[Token(Token = "0x4000990")]
			Stop
		}

		[Token(Token = "0x2000153")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70304C", Offset = "0x70304C")]
		private sealed class <StartStopTrain>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000991")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000992")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000993")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool startTrain;

			[Token(Token = "0x4000994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrainLocomotive <>4__this;

			[Token(Token = "0x4000995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <endSpeed>5__2;

			[Token(Token = "0x4000996")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <timePeriodForSpeedChange>5__3;

			[Token(Token = "0x4000997")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x4000998")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <endTime>5__5;

			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <startSpeed>5__6;

			[Token(Token = "0x17000112")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000856")]
				[Address(RVA = "0x191DBB8", Offset = "0x191DBB8", VA = "0x191DBB8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000113")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000858")]
				[Address(RVA = "0x191DC00", Offset = "0x191DC00", VA = "0x191DC00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000853")]
			[Address(RVA = "0x191D944", Offset = "0x191D944", VA = "0x191D944")]
			[DebuggerHidden]
			public <StartStopTrain>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x6000854")]
			[Address(RVA = "0x191D970", Offset = "0x191D970", VA = "0x191D970", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000855")]
			[Address(RVA = "0x191D974", Offset = "0x191D974", VA = "0x191D974", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000857")]
			[Address(RVA = "0x191DBC0", Offset = "0x191DBC0", VA = "0x191DBC0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000970")]
		private const float MIN_SPEED = 0.2f;

		[Token(Token = "0x4000971")]
		private const float MAX_SPEED = 2.7f;

		[Token(Token = "0x4000972")]
		private const float SMOKE_SPEED_MULTIPLIER = 8f;

		[Token(Token = "0x4000973")]
		private const int MAX_PARTICLES_MULTIPLIER = 3;

		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x705CE0", Offset = "0x705CE0")]
		[SerializeField]
		protected float _initialSpeed;

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x4000976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _decreaseSpeedButton;

		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _increaseSpeedButton;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _smokeButton;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _whistleButton;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _reverseButton;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AudioSource _whistleAudioSource;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioClip _whistleSound;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AudioSource _engineAudioSource;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioClip[] _accelerationSounds;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AudioClip[] _decelerationSounds;

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AudioClip _startUpSound;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AudioSource _smokeStackAudioSource;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AudioClip _smokeSound;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ParticleSystem _smoke1;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ParticleSystem _smoke2;

		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TrainCarBase[] _childCars;

		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool _isMoving;

		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool _reverse;

		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float _currentSpeed;

		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _speedDiv;

		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _standardRateOverTimeMultiplier;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _standardMaxParticles;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Coroutine _startStopTrainCr;

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xB8BE50", Offset = "0xB8BE50", VA = "0xB8BE50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xB8BFBC", Offset = "0xB8BFBC", VA = "0xB8BFBC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xB8BFC8", Offset = "0xB8BFC8", VA = "0xB8BFC8", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xB8C118", Offset = "0xB8C118", VA = "0xB8C118")]
		public void StartStopStateChanged()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xB8BF30", Offset = "0xB8BF30", VA = "0xB8BF30")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x709358", Offset = "0x709358")]
		private IEnumerator StartStopTrain(bool startTrain)
		{
			return null;
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xB8C178", Offset = "0xB8C178", VA = "0xB8C178")]
		private float PlayEngineSound(EngineSoundState engineSoundState)
		{
			return default(float);
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xB8C0B4", Offset = "0xB8C0B4", VA = "0xB8C0B4")]
		private void UpdateDistance()
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xB8C394", Offset = "0xB8C394", VA = "0xB8C394")]
		public void DecreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xB8C4D0", Offset = "0xB8C4D0", VA = "0xB8C4D0")]
		public void IncreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xB8C400", Offset = "0xB8C400", VA = "0xB8C400")]
		private void UpdateSmokeEmissionBasedOnSpeed()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xB8C53C", Offset = "0xB8C53C", VA = "0xB8C53C")]
		private float GetCurrentSmokeEmission()
		{
			return default(float);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xB8C55C", Offset = "0xB8C55C", VA = "0xB8C55C")]
		public void SmokeButtonStateChanged()
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xB8C5E8", Offset = "0xB8C5E8", VA = "0xB8C5E8")]
		public void WhistleButtonStateChanged()
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xB8C6A0", Offset = "0xB8C6A0", VA = "0xB8C6A0")]
		public void ReverseButtonStateChanged()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xB8C6B0", Offset = "0xB8C6B0", VA = "0xB8C6B0")]
		public TrainLocomotive()
		{
		}
	}
	[Token(Token = "0x2000154")]
	public class TrainTrack : MonoBehaviour
	{
		[Token(Token = "0x400099A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _gridSize;

		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _subDivCount;

		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _segmentParent;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _trainParent;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _regnerateTrackMeshOnAwake;

		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _trainLength;

		[Token(Token = "0x40009A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TrackSegment[] _trackSegments;

		[Token(Token = "0x17000114")]
		public float TrackLength
		{
			[Token(Token = "0x6000859")]
			[Address(RVA = "0xB8C718", Offset = "0xB8C718", VA = "0xB8C718")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600085A")]
			[Address(RVA = "0xB8C720", Offset = "0xB8C720", VA = "0xB8C720")]
			private set
			{
			}
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xB8C728", Offset = "0xB8C728", VA = "0xB8C728")]
		private void Awake()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xB8B790", Offset = "0xB8B790", VA = "0xB8B790")]
		public TrackSegment GetSegment(float distance)
		{
			return null;
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xB8C72C", Offset = "0xB8C72C", VA = "0xB8C72C")]
		public void Regenerate()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xB8C940", Offset = "0xB8C940", VA = "0xB8C940")]
		private void SetScale(float ratio)
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xB8CA3C", Offset = "0xB8CA3C", VA = "0xB8CA3C")]
		public TrainTrack()
		{
		}
	}
	[Token(Token = "0x2000155")]
	public class Pose
	{
		[Token(Token = "0x40009A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x40009A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion Rotation;

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x1319834", Offset = "0x1319834", VA = "0x1319834")]
		public Pose()
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x1319878", Offset = "0x1319878", VA = "0x1319878")]
		public Pose(Vector3 position, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000156")]
	public class WindmillBladesController : MonoBehaviour
	{
		[Token(Token = "0x2000157")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70305C", Offset = "0x70305C")]
		private sealed class <LerpToSpeed>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x40009B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float goalSpeed;

			[Token(Token = "0x40009B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <totalTime>5__2;

			[Token(Token = "0x40009B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startSpeed>5__3;

			[Token(Token = "0x17000116")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600086E")]
				[Address(RVA = "0x191DDD8", Offset = "0x191DDD8", VA = "0x191DDD8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000117")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000870")]
				[Address(RVA = "0x191DE20", Offset = "0x191DE20", VA = "0x191DE20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600086B")]
			[Address(RVA = "0x191DC08", Offset = "0x191DC08", VA = "0x191DC08")]
			[DebuggerHidden]
			public <LerpToSpeed>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x600086C")]
			[Address(RVA = "0x191DC34", Offset = "0x191DC34", VA = "0x191DC34", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600086D")]
			[Address(RVA = "0x191DC38", Offset = "0x191DC38", VA = "0x191DC38", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600086F")]
			[Address(RVA = "0x191DDE0", Offset = "0x191DDE0", VA = "0x191DDE0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70306C", Offset = "0x70306C")]
		private sealed class <PlaySoundDelayed>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x40009B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioClip initial;

			[Token(Token = "0x40009B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float timeDelayAfterInitial;

			[Token(Token = "0x40009B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AudioClip clip;

			[Token(Token = "0x17000118")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000874")]
				[Address(RVA = "0x191DF30", Offset = "0x191DF30", VA = "0x191DF30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000119")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000876")]
				[Address(RVA = "0x191DF78", Offset = "0x191DF78", VA = "0x191DF78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000871")]
			[Address(RVA = "0x191DE28", Offset = "0x191DE28", VA = "0x191DE28")]
			[DebuggerHidden]
			public <PlaySoundDelayed>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000872")]
			[Address(RVA = "0x191DE54", Offset = "0x191DE54", VA = "0x191DE54", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000873")]
			[Address(RVA = "0x191DE58", Offset = "0x191DE58", VA = "0x191DE58", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000875")]
			[Address(RVA = "0x191DF38", Offset = "0x191DF38", VA = "0x191DF38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40009A3")]
		private const float MAX_TIME = 1f;

		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x40009A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip _windMillRotationSound;

		[Token(Token = "0x40009A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip _windMillStartSound;

		[Token(Token = "0x40009A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip _windMillStopSound;

		[Token(Token = "0x40009A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x705EC8", Offset = "0x705EC8")]
		private bool <IsMoving>k__BackingField;

		[Token(Token = "0x40009A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _currentSpeed;

		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _lerpSpeedCoroutine;

		[Token(Token = "0x40009AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine _audioChangeCr;

		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion _originalRotation;

		[Token(Token = "0x40009AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _rotAngle;

		[Token(Token = "0x17000115")]
		public bool IsMoving
		{
			[Token(Token = "0x6000862")]
			[Address(RVA = "0x194F6AC", Offset = "0x194F6AC", VA = "0x194F6AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x709408", Offset = "0x709408")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000863")]
			[Address(RVA = "0x194F6B4", Offset = "0x194F6B4", VA = "0x194F6B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x709418", Offset = "0x709418")]
			private set
			{
			}
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x194F6C0", Offset = "0x194F6C0", VA = "0x194F6C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x194F6FC", Offset = "0x194F6FC", VA = "0x194F6FC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x194F7E0", Offset = "0x194F7E0", VA = "0x194F7E0")]
		public void SetMoveState(bool newMoveState, float goalSpeed)
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x194F854", Offset = "0x194F854", VA = "0x194F854")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x709428", Offset = "0x709428")]
		private IEnumerator LerpToSpeed(float goalSpeed)
		{
			return null;
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x194F8DC", Offset = "0x194F8DC", VA = "0x194F8DC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x709488", Offset = "0x709488")]
		private IEnumerator PlaySoundDelayed(AudioClip initial, AudioClip clip, float timeDelayAfterInitial)
		{
			return null;
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x194F994", Offset = "0x194F994", VA = "0x194F994")]
		private void PlaySound(AudioClip clip, bool loop = false)
		{
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x194FA00", Offset = "0x194FA00", VA = "0x194FA00")]
		public WindmillBladesController()
		{
		}
	}
	[Token(Token = "0x2000159")]
	public class WindmillController : MonoBehaviour
	{
		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxSpeed;

		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WindmillBladesController _bladesRotation;

		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x194FA08", Offset = "0x194FA08", VA = "0x194FA08")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x194FA7C", Offset = "0x194FA7C", VA = "0x194FA7C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x194FB60", Offset = "0x194FB60", VA = "0x194FB60")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x194FC98", Offset = "0x194FC98", VA = "0x194FC98")]
		private void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x194FD18", Offset = "0x194FD18", VA = "0x194FD18")]
		private void Update()
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x194FDF4", Offset = "0x194FDF4", VA = "0x194FDF4")]
		public WindmillController()
		{
		}
	}
	[Token(Token = "0x200015A")]
	public enum EUiDisplayType
	{
		[Token(Token = "0x40009C0")]
		EUDT_WorldGeoQuad,
		[Token(Token = "0x40009C1")]
		EUDT_OverlayQuad,
		[Token(Token = "0x40009C2")]
		EUDT_None,
		[Token(Token = "0x40009C3")]
		EUDT_MaxDislayTypes
	}
	[Token(Token = "0x200015B")]
	public class OVROverlaySample : MonoBehaviour
	{
		[Token(Token = "0x200015C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70307C", Offset = "0x70307C")]
		private sealed class <WaitforOVROverlay>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OVROverlaySample <>4__this;

			[Token(Token = "0x1700011A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000890")]
				[Address(RVA = "0x195663C", Offset = "0x195663C", VA = "0x195663C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000892")]
				[Address(RVA = "0x1956684", Offset = "0x1956684", VA = "0x1956684", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600088D")]
			[Address(RVA = "0x195640C", Offset = "0x195640C", VA = "0x195640C")]
			[DebuggerHidden]
			public <WaitforOVROverlay>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x600088E")]
			[Address(RVA = "0x1956438", Offset = "0x1956438", VA = "0x1956438", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600088F")]
			[Address(RVA = "0x195643C", Offset = "0x195643C", VA = "0x195643C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000891")]
			[Address(RVA = "0x1956644", Offset = "0x1956644", VA = "0x1956644", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inMenu;

		[Token(Token = "0x40009C5")]
		private const string ovrOverlayID = "OVROverlayID";

		[Token(Token = "0x40009C6")]
		private const string applicationID = "ApplicationID";

		[Token(Token = "0x40009C7")]
		private const string noneID = "NoneID";

		[Token(Token = "0x40009C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Toggle applicationRadioButton;

		[Token(Token = "0x40009C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Toggle noneRadioButton;

		[Token(Token = "0x40009CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x705F08", Offset = "0x705F08")]
		public GameObject mainCamera;

		[Token(Token = "0x40009CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject uiCamera;

		[Token(Token = "0x40009CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject uiGeoParent;

		[Token(Token = "0x40009CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject worldspaceGeoParent;

		[Token(Token = "0x40009CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OVROverlay cameraRenderOverlay;

		[Token(Token = "0x40009CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OVROverlay renderingLabelOverlay;

		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture applicationLabelTexture;

		[Token(Token = "0x40009D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture compositorLabelTexture;

		[Token(Token = "0x40009D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x705F40", Offset = "0x705F40")]
		public GameObject prefabForLevelLoadSim;

		[Token(Token = "0x40009D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public OVROverlay cubemapOverlay;

		[Token(Token = "0x40009D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public OVROverlay loadingTextQuadOverlay;

		[Token(Token = "0x40009D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float distanceFromCamToLoadText;

		[Token(Token = "0x40009D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float cubeSpawnRadius;

		[Token(Token = "0x40009D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float heightBetweenItems;

		[Token(Token = "0x40009D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int numObjectsPerLevel;

		[Token(Token = "0x40009D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int numLevels;

		[Token(Token = "0x40009DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int numLoopsTrigger;

		[Token(Token = "0x40009DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<GameObject> spawnedCubes;

		[Token(Token = "0x600087D")]
		[Address(RVA = "0xC1ECDC", Offset = "0xC1ECDC", VA = "0xC1ECDC")]
		private void Start()
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0xC1F538", Offset = "0xC1F538", VA = "0xC1F538")]
		private void Update()
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0xC1F680", Offset = "0xC1F680", VA = "0xC1F680")]
		private void ActivateWorldGeo()
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0xC1F7BC", Offset = "0xC1F7BC", VA = "0xC1F7BC")]
		private void ActivateOVROverlay()
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0xC1F8F8", Offset = "0xC1F8F8", VA = "0xC1F8F8")]
		private void ActivateNone()
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xC1F654", Offset = "0xC1F654", VA = "0xC1F654")]
		private void TriggerLoad()
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xC1F9D8", Offset = "0xC1F9D8", VA = "0xC1F9D8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x709588", Offset = "0x709588")]
		private IEnumerator WaitforOVROverlay()
		{
			return null;
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xC1FA50", Offset = "0xC1FA50", VA = "0xC1FA50")]
		private void TriggerUnload()
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xC1F144", Offset = "0xC1F144", VA = "0xC1F144")]
		private void CameraAndRenderTargetSetup()
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xC1FBA4", Offset = "0xC1FBA4", VA = "0xC1FBA4")]
		private void SimulateLevelLoad()
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xC1FA84", Offset = "0xC1FA84", VA = "0xC1FA84")]
		private void ClearObjects()
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xC1FEBC", Offset = "0xC1FEBC", VA = "0xC1FEBC")]
		public void RadioPressed(string radioLabel, string group, Toggle t)
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xC1FFAC", Offset = "0xC1FFAC", VA = "0xC1FFAC")]
		public OVROverlaySample()
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xC2003C", Offset = "0xC2003C", VA = "0xC2003C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7095E8", Offset = "0x7095E8")]
		private void <Start>b__24_0(Toggle t)
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xC20094", Offset = "0xC20094", VA = "0xC20094")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7095F8", Offset = "0x7095F8")]
		private void <Start>b__24_1(Toggle t)
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0xC200EC", Offset = "0xC200EC", VA = "0xC200EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x709608", Offset = "0x709608")]
		private void <Start>b__24_2(Toggle t)
		{
		}
	}
}
namespace OVRTouchSample
{
	[Token(Token = "0x200015D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x70308C", Offset = "0x70308C")]
	public class Hand : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200015E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7030EC", Offset = "0x7030EC")]
		private sealed class <>c
		{
			[Token(Token = "0x40009FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40009FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Collider, bool> <>9__28_0;

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x1954784", Offset = "0x1954784", VA = "0x1954784")]
			public <>c()
			{
			}

			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x195478C", Offset = "0x195478C", VA = "0x195478C")]
			internal bool <Start>b__28_0(Collider childCollider)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40009DF")]
		public const string ANIM_LAYER_NAME_POINT = "Point Layer";

		[Token(Token = "0x40009E0")]
		public const string ANIM_LAYER_NAME_THUMB = "Thumb Layer";

		[Token(Token = "0x40009E1")]
		public const string ANIM_PARAM_NAME_FLEX = "Flex";

		[Token(Token = "0x40009E2")]
		public const string ANIM_PARAM_NAME_POSE = "Pose";

		[Token(Token = "0x40009E3")]
		public const float THRESH_COLLISION_FLEX = 0.9f;

		[Token(Token = "0x40009E4")]
		public const float INPUT_RATE_CHANGE = 20f;

		[Token(Token = "0x40009E5")]
		public const float COLLIDER_SCALE_MIN = 0.01f;

		[Token(Token = "0x40009E6")]
		public const float COLLIDER_SCALE_MAX = 1f;

		[Token(Token = "0x40009E7")]
		public const float COLLIDER_SCALE_PER_SECOND = 1f;

		[Token(Token = "0x40009E8")]
		public const float TRIGGER_DEBOUNCE_TIME = 0.05f;

		[Token(Token = "0x40009E9")]
		public const float THUMB_DEBOUNCE_TIME = 0.15f;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandPose m_defaultGrabPose;

		[Token(Token = "0x40009ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider[] m_colliders;

		[Token(Token = "0x40009EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_collisionEnabled;

		[Token(Token = "0x40009EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRGrabber m_grabber;

		[Token(Token = "0x40009F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Renderer> m_showAfterInputFocusAcquired;

		[Token(Token = "0x40009F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_animLayerIndexThumb;

		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_animLayerIndexPoint;

		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_animParamIndexFlex;

		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_animParamIndexPose;

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isPointing;

		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_isGivingThumbsUp;

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_pointBlend;

		[Token(Token = "0x40009F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_thumbsUpBlend;

		[Token(Token = "0x40009F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x40009FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_collisionScaleCurrent;

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xB08774", Offset = "0xB08774", VA = "0xB08774")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xB087D0", Offset = "0xB087D0", VA = "0xB087D0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xB08C64", Offset = "0xB08C64", VA = "0xB08C64")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xB08D50", Offset = "0xB08D50", VA = "0xB08D50")]
		private void Update()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xB08EB4", Offset = "0xB08EB4", VA = "0xB08EB4")]
		private void UpdateCapTouchStates()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xB091BC", Offset = "0xB091BC", VA = "0xB091BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0xB092B4", Offset = "0xB092B4", VA = "0xB092B4")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xB09414", Offset = "0xB09414", VA = "0xB09414")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0xB08F4C", Offset = "0xB08F4C", VA = "0xB08F4C")]
		private float InputValueRateChange(bool isDown, float value)
		{
			return default(float);
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xB08FA0", Offset = "0xB08FA0", VA = "0xB08FA0")]
		private void UpdateAnimStates()
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xB08B08", Offset = "0xB08B08", VA = "0xB08B08")]
		private void CollisionEnable(bool enabled)
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0xB09550", Offset = "0xB09550", VA = "0xB09550")]
		public Hand()
		{
		}
	}
	[Token(Token = "0x200015F")]
	public enum HandPoseId
	{
		[Token(Token = "0x40009FE")]
		Default,
		[Token(Token = "0x40009FF")]
		Generic,
		[Token(Token = "0x4000A00")]
		PingPongBall,
		[Token(Token = "0x4000A01")]
		Controller
	}
	[Token(Token = "0x2000160")]
	public class HandPose : MonoBehaviour
	{
		[Token(Token = "0x4000A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_allowPointing;

		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_allowThumbsUp;

		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private HandPoseId m_poseId;

		[Token(Token = "0x1700011C")]
		public bool AllowPointing
		{
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0xC0CCF4", Offset = "0xC0CCF4", VA = "0xC0CCF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011D")]
		public bool AllowThumbsUp
		{
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0xC0CCFC", Offset = "0xC0CCFC", VA = "0xC0CCFC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011E")]
		public HandPoseId PoseId
		{
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0xC0CD04", Offset = "0xC0CD04", VA = "0xC0CD04")]
			get
			{
				return default(HandPoseId);
			}
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0xC0CD0C", Offset = "0xC0CD0C", VA = "0xC0CD0C")]
		public HandPose()
		{
		}
	}
	[Token(Token = "0x2000161")]
	public class TouchController : MonoBehaviour
	{
		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xB8955C", Offset = "0xB8955C", VA = "0xB8955C")]
		private void Update()
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0xB89844", Offset = "0xB89844", VA = "0xB89844")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0xB898A0", Offset = "0xB898A0", VA = "0xB898A0")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xB898E4", Offset = "0xB898E4", VA = "0xB898E4")]
		public TouchController()
		{
		}
	}
}
